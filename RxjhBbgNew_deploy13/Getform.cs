using System;
using System.Collections.Specialized;
using System.Text;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;

public class Getform : System.Web.UI.Page, IRequiresSessionState
{
	protected HttpApplication ApplicationInstance
	{
		get
		{
			return this.Context.ApplicationInstance;
		}
	}

	protected DefaultProfile Profile
	{
		get
		{
			return (DefaultProfile)this.Context.Profile;
		}
	}

	public Getform()
	{
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		object[] item;
		base.Response.ContentEncoding = Encoding.GetEncoding("utf-8");
		string str = (base.Request.QueryString["itemid"] == null ? "1" : WebFun.ReplaceComma(base.Request.QueryString["itemid"]));
		string str1 = (base.Request.QueryString["itemnum"] == null ? "1" : WebFun.ReplaceComma(base.Request.QueryString["itemnum"]));
		string str2 = (base.Request.QueryString["itemje"] == null ? "1" : WebFun.ReplaceComma(base.Request.QueryString["itemje"]));
		string str3 = (base.Request.QueryString["type"] == null ? "0" : WebFun.ReplaceComma(base.Request.QueryString["type"]));
		string str4 = (base.Request.QueryString["option1"] == null ? "0" : WebFun.ReplaceComma(base.Request.QueryString["option1"]));
		string str5 = (base.Request.QueryString["option2"] == null ? "0" : WebFun.ReplaceComma(base.Request.QueryString["option2"]));
		string str6 = (base.Request.QueryString["option3"] == null ? "0" : WebFun.ReplaceComma(base.Request.QueryString["option3"]));
		string str7 = (base.Request.QueryString["option4"] == null ? "0" : WebFun.ReplaceComma(base.Request.QueryString["option4"]));
		int num = (this.Session["SSPOINT"] == null ? 0 : int.Parse(this.Session["SSPOINT"].ToString()));
		int num1 = (this.Session["SSCASH"] == null ? 0 : int.Parse(this.Session["SSCASH"].ToString()));
		int num2 = (this.Session["SSBLANK"] == null ? 0 : int.Parse(this.Session["SSBLANK"].ToString()));
		int num3 = int.Parse(str2);
		int num4 = int.Parse(str1);
		if (num4 > num2)
		{
			base.Response.Write("{\"goumai\": [ { \"state\": \"0\",\"title\":\"인벤토리 부족 구입실패 1\"}]} ");
		}
		else if (!(num3 > num & num3 > num1))
		{
			if (str3 == "3")
			{
				item = new object[] { this.Session["Id"], ",", str, ",", str1, ",", str2, ",0,", str4, ",", str5, ",", str6, ",", str7 };
				if (PublicClass.SendBuyShuxing(string.Concat(item)))
				{
					if (num3 > 0)
					{
						if (num < num3)
						{
							if (num1 >= num3)
							{
								this.Session["SSCASH"] = num1 - num3;
								this.Session["SSBLANK"] = num2 - num4;
								base.Response.Write("{\"goumai\": [ { \"state\": \"1\",\"title\":\"축하합니다 ~! 판매 성공\"}]} ");
								return;
							}
							base.Response.Write("{\"goumai\": [ { \"state\": \"0\",\"title\":\"포인트 부족 1\"}]} ");
							return;
						}
						this.Session["SSPOINT"] = num - num3;
					}
					this.Session["SSBLANK"] = num2 - num4;
					base.Response.Write("{\"goumai\": [ { \"state\": \"1\",\"title\":\"축하합니다 ~! 판매 성공\"}]} ");
				}
				else
				{
					base.Response.Write("{\"goumai\": [ { \"state\": \"0\",\"title\":\"구매오류 1\"}]} ");
				}
				return;
			}
			else
			{
				item = new object[] { this.Session["Id"], ",", str, ",", str1, ",", str2, "," };
				if (PublicClass.SendBuy(string.Concat(item)))
				{
					if (num3 > 0)
					{
						if (num < num3)
						{
							if (num1 >= num3)
							{
								this.Session["SSCASH"] = num1 - num3;
								this.Session["SSBLANK"] = num2 - num4;
								base.Response.Write("{\"goumai\": [ { \"state\": \"1\",\"title\":\"축하합니다 ~! 판매 성공\"}]} ");
								this.Session["SSCASH"] = num1 - num3;
								this.Session["SSBLANK"] = num2 - num4;
								base.Response.Write("{\"goumai\": [ { \"state\": \"1\",\"title\":\"축하합니다 ~! 판매 성공\"}]} ");
								return;
							}
							base.Response.Write("{\"goumai\": [ { \"state\": \"0\",\"title\":\"구매 오류 2\"}]} ");
							return;
						}
						this.Session["SSPOINT"] = num - num3;
					}
					this.Session["SSBLANK"] = num2 - num4;
					base.Response.Write("{\"goumai\": [ { \"state\": \"1\",\"title\":\"축하합니다 ~! 판매 성공\"}]} ");
				}
				else
				{
					base.Response.Write("{\"goumai\": [ { \"state\": \"0\",\"title\":\"구매오류 3\"}]} ");
				}
				return;
			}
			this.Session["SSCASH"] = num1 - num3;
			this.Session["SSBLANK"] = num2 - num4;
			base.Response.Write("{\"goumai\": [ { \"state\": \"1\",\"title\":\"축하합니다 ~! 판매 성공\"}]} ");
			return;
		}
		else
		{
			base.Response.Write("{\"goumai\": [ { \"state\": \"0\",\"title\":\"인벤토리 부족 구입실패 2\"}]} ");
		}
	}
}