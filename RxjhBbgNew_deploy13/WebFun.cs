using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;

public class WebFun
{
      private const string CRLF = "\r\n";

      public static void Alert(Page page, string message)
      {
            CtrlCharSupport(ref message);
            string s = "<script language='javascript'>\r\nalert('" + message + "');\r\n</script>\r\n<noscript>you browse can't suppport javascript.</noscript>";
            HttpContext.Current.Response.Write(s);
      }

      public static void AlertInfo(Page page, string message)
      {
            CtrlCharSupport(ref message);
            page.RegisterStartupScript("alert", "<script language='javascript'>\r\nalert('" + message + "');\r\n</script>\r\n<noscript>you browse can't suppport javascript.</noscript>");
      }

      public static bool CheckCustomerIP(string strCustomerIP)
      {
            if (Regex.IsMatch(strCustomerIP, @"^(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])$"))
            {
                  return true;
            }
            ClientScriptBack("alert('您的IP格式不对，请重新输入！');", true);
            return false;
      }

      public static void CheckField(int length, string str, string strName)
      {
            if (Encoding.Default.GetByteCount(str) > length)
            {
                  ScriptMessage(string.Concat(new object[] { "对不起，\"", strName, "\"字段超长最大为：", length, "个字节,请检查！" }), true);
                  HttpContext.Current.Response.End();
            }
      }

      public static void CheckMinField(int length, string str, string strName)
      {
            if (Encoding.Default.GetByteCount(str) < length)
            {
                  ScriptMessage(string.Concat(new object[] { "对不起，\"", strName, "\"字段超长最小为：", length, "个字节,请检查！" }), true);
                  HttpContext.Current.Response.End();
            }
      }

      public static void CheckNull(string strText, string strName)
      {
            if ((strText == null) || strText.Trim().Equals(string.Empty))
            {
                  ScriptMessage("对不起\"" + strName + "\"不能为空,请检查！", true);
                  HttpContext.Current.Response.End();
            }
      }

      public static string ClarityWebString(string WebString, int intCount, string strPage, string strRelation)
      {
            bool flag;
            if ((WebString.IndexOf("'") != -1) || (WebString.IndexOf("-") != -1))
            {
                  flag = false;
            }
            else
            {
                  flag = (WebString.IndexOf(";") == -1) && (WebString.IndexOf("|") == -1);
            }
            if (!flag)
            {
            }
            string str2 = WebString.Replace("'", "").Replace("-", "").Replace(";", "").Replace("|", "");
            return ((str2.Length <= intCount) ? str2 : str2.Substring(0, intCount));
      }

      public static void ClientScript(string scriptText)
      {
            HttpResponse response = HttpContext.Current.Response;
            response.Buffer = true;
            response.Expires = 0;
            response.CacheControl = "Private";
            response.StatusCode = 200;
            response.Clear();
            response.Write("<script language='javascript'>\r\n" + scriptText + "\r\n</script>\r\n<noscript>you browse can't suppport javascript.</noscript>");
            response.End();
      }

      public static void ClientScriptBack(string scriptText, bool back)
      {
            HttpResponse response = HttpContext.Current.Response;
            response.Buffer = true;
            response.Expires = 0;
            response.CacheControl = "Private";
            response.StatusCode = 200;
            response.Clear();
            string[] strArray2 = new string[5];
            strArray2[0] = "<script language='javascript'>\r\n";
            strArray2[1] = scriptText;
            strArray2[2] = "\r\n";
            string[] strArray = strArray2;
            strArray[3] = back ? "window.history.go(-1);" : "";
            strArray[4] = "</script>\r\n<noscript>you browse can't suppport javascript.</noscript>";
            response.Write(string.Concat(strArray));
            response.End();
      }

      private static bool CtrlCharSupport(ref string text)
      {
            if ((text != null) && (text != ""))
            {
                  text = text.Replace(@"\", @"\\").Replace("\r", @"\r").Replace("\n", @"\n").Replace("'", @"\'");
                  return true;
            }
            return false;
      }

      public static string getDiskCode(string strOperate) =>
          (((strOperate == null) || strOperate.Trim().Equals("")) ? "" : strOperate.Substring(0, strOperate.IndexOf(":") + 1));

      public static string getFileName(string strPath)
      {
            int num = strPath.LastIndexOf(@"\");
            int num2 = strPath.LastIndexOf("/");
            num = (num > num2) ? num : num2;
            return (((strPath != null) && !strPath.Trim().Equals("")) ? strPath.Substring(num + 1, (strPath.Length - num) - 1) : "");
      }

      public static string getFilePath(string strPath)
      {
            int num = strPath.LastIndexOf(@"\");
            int num2 = strPath.Replace(@"\", "/").LastIndexOf("/");
            num = (num > num2) ? num : num2;
            return (((strPath != null) && !strPath.Trim().Equals("")) ? strPath.Substring(0, num + 1) : "");
      }

      public static void getFTPServerInfo(string strServerInfo, out string strHost, out string strUser, out string strPass)
      {
            strServerInfo = strServerInfo.Replace("ftp://", "");
            strHost = "";
            strUser = "";
            strPass = "";
            if (strServerInfo != "")
            {
                  int length = strServerInfo.LastIndexOf("@");
                  string str = strServerInfo.Substring(0, length);
                  strHost = strServerInfo.Substring(length + 1, (strServerInfo.Length - length) - 1);
                  string[] strArray = str.Split(new char[] { ':' });
                  strUser = strArray[0];
                  strPass = strArray[1];
            }
      }

      public static string GetLengthStringAgent(string strOld, string strCue, int intMin, int intMax)
      {
            if ((strOld.IndexOf(";") >= 0) || (strOld.IndexOf("'") >= 0))
            {
                  ClientScriptBack("alert('对不起，您的“ " + strCue + "”中有非法字符,请重新输入!')", true);
                  return ReplaceComma(strOld.Trim());
            }
            if ((strOld.Length == 0) && (intMin != 0))
            {
                  ClientScriptBack("alert('“" + strCue + "”不能为空！')", true);
            }
            if (strOld.Length > intMax)
            {
                  ClientScriptBack(string.Concat(new object[] { "alert('“", strCue, "”字符最多不能超过", intMax, "个')" }), true);
            }
            if (strOld.Length < intMin)
            {
                  ClientScriptBack(string.Concat(new object[] { "alert('“", strCue, "”字符最少不能少于", intMin, "个')" }), true);
            }
            return ReplaceComma(strOld.Trim());
      }

      public static string getPathName(string strPath)
      {
            int length = strPath.LastIndexOf(@"\");
            int num2 = strPath.LastIndexOf("/");
            length = (length > num2) ? length : num2;
            return (((strPath != null) && !strPath.Trim().Equals("")) ? strPath.Substring(0, length) : "");
      }

      public static string GetSysPath(string strPath, string strFile) =>
          (HttpContext.Current.Request.PhysicalApplicationPath + @"\" + strPath + @"\" + strFile).Replace(@"\\", @"\");

      public static string IsCodeNumber(string strString, string strName, int intMin, long logMax)
      {
            if ((strString == null) || strString.Trim().Equals(""))
            {
                  ScriptMessage("“" + strName + "”不能为空,请重新输入!", true);
            }
            if (!Regex.IsMatch(strString, "^[a-zA-Z0-9]$"))
            {
                  ScriptMessage("“" + strName + "”不为字母,请重新输入!", true);
            }
            if ((logMax != 0L) && (strString.Length > logMax))
            {
                  ScriptMessage(string.Concat(new object[] { "“", strName, "”输入字符最大不能超过", logMax, ",请重新输入!" }), true);
            }
            if (strString.Length < intMin)
            {
                  ScriptMessage(string.Concat(new object[] { "“", strName, "”输入字符最少不能少于", intMin, ",请重新输入!" }), true);
            }
            return strString;
      }

      public static double IsDouble(string strNumber, string strName, double dubMin, double dubMax)
      {
            if (strNumber == null)
            {
                  ScriptMessage("“" + strName + "”不为浮点数,或正整数,请重新输入!", true);
            }
            if (!Regex.IsMatch(strNumber, @"^[-\+]?\d+(\.\d+)?$") && !Regex.IsMatch(strNumber, @"^-\d+$"))
            {
                  ScriptMessage("“" + strName + "”不为浮点数,或正整数,请重新输入!", true);
            }
            if ((dubMin != 0.0) && (Convert.ToDouble(dubMax) < dubMin))
            {
                  ScriptMessage(string.Concat(new object[] { "“", strName, "”输入数字最小不能小于", dubMin, ",请重新输入!" }), true);
            }
            if ((dubMax != 0.0) && (Convert.ToDouble(dubMax) > dubMax))
            {
                  ScriptMessage(string.Concat(new object[] { "“", strName, "”输入数字最大不能超过", dubMax, ",请重新输入!" }), true);
            }
            return Convert.ToDouble(strNumber);
      }

      public static int IsNumber(string strNumber, string strName, long logMax)
      {
            if (strNumber == null)
            {
                  ScriptMessage("“" + strName + "”不为正整数,请重新输入!", true);
            }
            if (!Regex.IsMatch(strNumber, @"^\d+$"))
            {
                  ScriptMessage("“" + strName + "”不为正整数,请重新输入!", true);
            }
            if ((logMax != 0L) && (Convert.ToInt32(strNumber) > logMax))
            {
                  ScriptMessage(string.Concat(new object[] { "“", strName, "”输入数字最大不能超过", logMax, ",请重新输入!" }), true);
            }
            return Convert.ToInt32(strNumber);
      }

      public static string IsString(string strString, string strName, int intMin, long logMax)
      {
            if ((strString == null) || strString.Trim().Equals(""))
            {
                  ScriptMessage("“" + strName + "”不能为空,请重新输入!", true);
            }
            if (!Regex.IsMatch(strString, "^[a-zA-Z]$"))
            {
                  ScriptMessage("“" + strName + "”不为字母,请重新输入!", true);
            }
            if ((logMax != 0L) && (strString.Length > logMax))
            {
                  ScriptMessage(string.Concat(new object[] { "“", strName, "”输入字符最大不能超过", logMax, ",请重新输入!" }), true);
            }
            if (strString.Length < intMin)
            {
                  ScriptMessage(string.Concat(new object[] { "“", strName, "”输入字符最少不能少于", intMin, ",请重新输入!" }), true);
            }
            return strString;
      }

      public static string ReplaceBlank(string WebString, bool bolType)
      {
            if (bolType)
            {
                  WebString = WebString.Replace(" ", "");
            }
            return WebString.Replace("<br>", "").Replace("'", "").Replace("\t", "").Replace("<p>", "");
      }

      public static string ReplaceComma(string WebString)
      {
            if (WebString == null)
            {
                  return null;
            }
            if (!Regex.IsMatch(WebString, @"^(?:[\u4e00-\u9fa5]*\w*\s*)+$"))
            {
                  ScriptMessage("检查到非法字符,请重新输入!", true);
            }
            return WebString.Replace(";", "").Replace("'", "''");
      }

      public static string ReplaceEnter(string WebString) =>
          WebString.Replace("\r", "").Replace("\n", "");

      public static void ScriptMessage(string text, bool back)
      {
            CtrlCharSupport(ref text);
            ClientScript("alert('" + text + "');\r\n" + (back ? "window.history.go(-1);" : ""));
      }

      public static void ShowMessage(string scriptText)
      {
            HttpResponse response = HttpContext.Current.Response;
            scriptText = "alert('" + scriptText + "');";
            response.Buffer = true;
            response.Expires = 0;
            response.CacheControl = "Private";
            response.StatusCode = 200;
            response.Clear();
            response.Write("<script language='javascript'>\r\n" + scriptText + "\r\n</script>\r\n<noscript>you browse can't suppport javascript.</noscript>");
      }

      private static bool URLReplace(ref string url)
      {
            if ((url != null) && (url != ""))
            {
                  url = url.Replace("'", @"\'");
                  return true;
            }
            return false;
      }

      public static string ValidateWebString(string WebString) =>
          WebString.Replace("'", "''").Replace("-", "");
}

