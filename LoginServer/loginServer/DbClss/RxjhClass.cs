namespace LoginServer.DbClss
{
    using LoginServer.HelperTools;
    using System;
    using System.Data;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    public class RxjhClass
    {
        static RxjhClass()
        {
            ZYXDNGuarder.Startup();
        }

        public static string GetFq(string account)
        {
            DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM TBL_ACCOUNT WHERE FLD_ID='{account}'");
            string str = "";
            if (dBToDataTable != null)
            {
                if (dBToDataTable.Rows.Count == 0)
                {
                    dBToDataTable.Dispose();
                    return str;
                }
                str = dBToDataTable.Rows[0]["FLD_FQ"].ToString();
                dBToDataTable.Dispose();
                return str;
            }
            dBToDataTable.Dispose();
            return str;
        }

        public static int GetUserId(string id, string pwd, string ip)
        {
            string sqlCommand = $"EXEC CHECK_ACCOUNT '{id}','{ip}'";
            string str2 = $"UPDATE TBL_ACCOUNT SET FLD_ONLINE=1 where FLD_ID='{id}'";
            DataTable dBToDataTable = DBA.GetDBToDataTable(sqlCommand);
            if (dBToDataTable == null)
            {
                return -1;
            }
            if (dBToDataTable.Rows.Count == 0)
            {
                return -1;
            }
            string str3 = "";
            if (pwd.Length >= 0x24)
            {
                byte[] buffer = new byte[] { 170, 0xab, 0xac, 0xad, 0xae, 0xaf, 0xba, 0xbb, 0xbc, 0xbd, 190, 0xbf };
                MD5 md = new MD5CryptoServiceProvider();
                str3 = BitConverter.ToString(md.ComputeHash(Encoding.ASCII.GetBytes(dBToDataTable.Rows[0]["FLD_PASSWORD"].ToString()))).Replace("-", "").ToLower();
                int index = int.Parse(pwd.Remove(2, pwd.Length - 2));
                int num2 = buffer[index];
                byte[] bytes = Converter.hexStringToByte(pwd);
                for (int i = 0; i < bytes.Length; i++)
                {
                    bytes[i] = (byte) (bytes[i] ^ ((byte) num2));
                }
                string str4 = Converter.ToString(bytes).Replace(" ", "").ToLower();
                //pwd = str4.Substring(2, str4.Length - 4);
            }
            else
            {
                str3 = dBToDataTable.Rows[0]["FLD_PASSWORD"].ToString();
            }
            if (str3 != pwd)
            {
                return 0;
            }
            if (dBToDataTable.Rows[0]["FLD_ZT"].ToString() == "1")
            {
                return 2;
            }
            SetUserId(id, ip);
            DBA.ExeSqlCommand(str2);
            return 1;
        }

        public static int GetUserIP(string ip)
        {
            DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM TBL_BANED WHERE FLD_BANEDIP='{ip}'");
            if (dBToDataTable == null)
            {
                return 0;
            }
            if (dBToDataTable.Rows.Count == 0)
            {
                return 0;
            }
            return -1;
        }

        public static string GetUserIpadds(string ip)
        {
            try
            {
                string dataPath = Application.StartupPath + @"\QQWry.Dat";
                IPScaner scaner = new IPScaner();
                return scaner.IPLocation(dataPath, ip);
            }
            catch
            {
                return "";
            }
        }

        public static int ReplaceComma(string WebString)
        {
            if (!Regex.IsMatch(WebString, @"^(?:[\u4e00-\u9fa5]*\w*\s*)+$"))
            {
                return -1;
            }
            return 0;
        }

        public static void SetUserId(string id, string ip)
        {
            DBA.ExeSqlCommand($"EXEC update_ACCOUNT '{id}','{ip}'");
        }

        public static void SetUserIdONLINE(string id)
        {
            DBA.ExeSqlCommand($"UPDATE TBL_ACCOUNT SET FLD_ONLINE=0 where FLD_ID='{id}'");
        }
    }
}

