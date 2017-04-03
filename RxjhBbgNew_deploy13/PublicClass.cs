using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Web;
using System.Web.SessionState;

public class PublicClass
{
	public PublicClass()
	{
	}

	public static bool aacc()
	{
		bool flag;
		try
		{
			SymmetricMethod symmetricMethod = new SymmetricMethod();
			string str = symmetricMethod.Decrypto(ConfigurationSettings.AppSettings["LicenseKey"]);
			string item = HttpContext.Current.Request.ServerVariables["HTTP_HOST"];
			if (item.IndexOf("localhost") != -1)
			{
				flag = true;
			}
			else if (item.IndexOf("127.0.0.1") != -1)
			{
				flag = true;
			}
			else if (str == "")
			{
				flag = false;
			}
			else
			{
				char[] chrArray = new char[] { '|' };
				string str1 = str.Split(chrArray)[0];
				chrArray = new char[] { ',' };
				string[] strArrays = str1.Split(chrArray);
				bool flag1 = false;
				for (int i = 0; i < (int)strArrays.Length; i++)
				{
					if (item.IndexOf(strArrays[i]) != -1)
					{
						flag1 = true;
					}
				}
				flag = (flag1 ? true : false);
			}
		}
		catch
		{
			flag = false;
		}
		return flag;
	}

	public static int GetValue(string Line)
	{
		string[] strArrays = HttpContext.Current.Session["server"].ToString().Split(new char[] { ':' });
		Connect connect = new Connect(strArrays[0], int.Parse(strArrays[1]));
		connect.Sestup();
		Line = string.Concat("查询,", Line);
		connect.发送(Line);
		int num = int.Parse(connect.收());
		connect.Dispose();
		return num;
	}

	public static bool Login(string Line)
	{
		bool flag;
		string[] strArrays = HttpContext.Current.Session["server"].ToString().Split(new char[] { ':' });
		Connect connect = new Connect(strArrays[0], int.Parse(strArrays[1]));
		connect.Sestup();
		Line = string.Concat("用户登陆,", Line);
		connect.发送(Line);
		if (connect.收() != "登陆成功")
		{
			connect.Dispose();
			flag = false;
		}
		else
		{
			connect.Dispose();
			flag = true;
		}
		return flag;
	}

	public static bool SendBuy(string Line)
	{
		bool flag;
		string[] strArrays = HttpContext.Current.Session["server"].ToString().Split(new char[] { ':' });
		Connect connect = new Connect(strArrays[0], int.Parse(strArrays[1]));
		connect.Sestup();
		Line = string.Concat("购买,", Line);
		connect.发送(Line);
		if (connect.收() != "购买成功")
		{
			connect.Dispose();
			flag = false;
		}
		else
		{
			connect.Dispose();
			flag = true;
		}
		return flag;
	}

	public static bool SendBuyShuxing(string Line)
	{
		bool flag;
		string[] strArrays = HttpContext.Current.Session["server"].ToString().Split(new char[] { ':' });
		Connect connect = new Connect(strArrays[0], int.Parse(strArrays[1]));
		connect.Sestup();
		Line = string.Concat("购买属性物品,", Line);
		connect.发送(Line);
		if (connect.收() != "购买成功")
		{
			connect.Dispose();
			flag = false;
		}
		else
		{
			connect.Dispose();
			flag = true;
		}
		return flag;
	}
}