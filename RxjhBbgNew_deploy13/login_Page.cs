using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;

public class login_Page : System.Web.UI.Page, IRequiresSessionState
{
	protected HtmlForm form1;

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

	public login_Page()
	{
	}

	public void GetYb()
	{
		int value = 0;
		int num = 0;
		int value1 = 0;
		string str = string.Concat(this.Session["Id"], ",热血元宝,");
		value = PublicClass.GetValue(str);
		if (value == -1)
		{
			base.Response.Redirect("error.htm");
		}
		str = string.Concat(this.Session["Id"], ",赠品元宝,");
		num = PublicClass.GetValue(str);
		if (num == -1)
		{
			base.Response.Redirect("error.htm");
		}
		str = string.Concat(this.Session["Id"], ",空位,");
		value1 = PublicClass.GetValue(str);
		if (value1 == -1)
		{
			base.Response.Redirect("error.htm");
		}
		this.Session["SSBLANK"] = value1;
		this.Session["SSCASH"] = value;
		this.Session["SSPOINT"] = num;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
            //mgid=1&param=12,1,....222,0,35
		string item = base.Request["mgid"];
		string str = base.Request["param"];
		string str1 = string.Concat(item, ",", str);
		if (item == null | str == null)
		{
			base.Response.Redirect("error.htm");
		}
		string[] strArrays = str.Split(new char[] { ',' });
		string item1 = base.Request.QueryString["server"];
		string item2 = ConfigurationManager.AppSettings[item1];
		if (item2 == null)
		{
			HttpContext.Current.Response.Write(string.Concat("Web.config中没有这个参数:", item1));
			HttpContext.Current.Response.End();
		}
		else
		{
			this.Session["server"] = item2;
			if (PublicClass.Login(str1))
			{
				this.Session["Login"] = true;
				this.Session["Id"] = item;
				this.Session["Name"] = strArrays[2];
				this.GetYb();
				base.Response.Redirect("default.htm");
			}
			else
			{
				this.Session["Login"] = false;
				base.Response.Redirect("error.htm");
			}
		}
	}
}