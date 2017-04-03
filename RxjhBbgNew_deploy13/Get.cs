using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;

public class Get : System.Web.UI.Page, IRequiresSessionState
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

	public Get()
	{
	}

	public void GetItme()
	{
		object[] str;
		string str1 = (base.Request.QueryString["type"] == null ? "1" : WebFun.ReplaceComma(base.Request.QueryString["type"]));
		string str2 = (base.Request.QueryString["page"] == null ? "1" : WebFun.ReplaceComma(base.Request.QueryString["page"]));
		string str3 = string.Concat("and FLD_TYPE=", str1);
		base.Response.Write("{ \"item\": [ ");
		int num = 0;
		int num1 = 0;
		int num2 = 5;
		DataSet newList = DBA.GetNewList("ITEMSELL", num2, int.Parse(str2), str3, "ID", "ID", 1, out num, out num1);
		string str4 = "";
		for (int i = 0; i < newList.Tables[0].Rows.Count; i++)
		{
			int item = (int)newList.Tables[0].Rows[i]["FLD_PRICE"];
			item = item * 4;
			str = new object[] { str4, "{ \"id\":\"", newList.Tables[0].Rows[i]["FLD_PID"].ToString(), "\",\"name\": \"", newList.Tables[0].Rows[i]["FLD_NAME"].ToString(), "\", \"pic\":\"Images/Item/", newList.Tables[0].Rows[i]["FLD_PID"].ToString(), ".gif\",\"yjg\":\"", item, "\",\"jg\":\"", newList.Tables[0].Rows[i]["FLD_PRICE"].ToString(), "\",\"info\":\"", newList.Tables[0].Rows[i]["FLD_DESC"].ToString(), "\",\"type\":\"", newList.Tables[0].Rows[i]["FLD_TYPE"].ToString(), "\"}" };
			string str5 = string.Concat(str);
			base.Response.Write(str5.Replace("\n", ""));
			str4 = ",";
		}
		base.Response.Write("],");
		HttpResponse response = base.Response;
		str = new object[] { "\"pages\": [{\"curpage\":\"", str2, "\",\"pagenum\":\"", num, "\",\"type\":\"", str1, "\"}]" };
		response.Write(string.Concat(str));
		base.Response.Write("}");
		newList.Dispose();
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		base.Response.ContentEncoding = Encoding.GetEncoding("utf-8");
		string str = (base.Request.QueryString["act"] == null ? "" : base.Request.QueryString["act"]);
            if ((str != null) || (str.Trim() != string.Empty))
            {
			string str1 = str;
			if (str1 != null)
			{
				if (str1 == "userCash")
				{
					HttpResponse response = base.Response;
					object[] item = new object[] { "{ \"userCash\": [ { \"user\": \"ysd\", \"cash\":\"", this.Session["SSCASH"], "\", \"free\": \"", this.Session["SSPOINT"], "\" } ]} " };
					response.Write(string.Concat(item));
				}
				else if (str1 == "ann")
				{
					base.Response.Write("{ \"ann\": [{ \"news\": \"NO REGISTED NEWS\", \"time\":\"\" }]}");
				}
				else if (str1 == "mybag")
				{
					base.Response.Write(string.Concat("{ \"mybag\": [{ \"all\": \"64\", \"now\":\"", this.Session["SSBLANK"], "\"}]} "));
				}
				else if (str1 == "mybuylog")
				{
					base.Response.Write("{ \"Buylog\": [ ]} ");
				}
				else if (str1 == "item")
				{
					this.GetItme();
				}
			}
		}
	}
}