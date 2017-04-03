using System;
using System.Collections.Specialized;
using System.IO;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;

public class test : System.Web.UI.Page, IRequiresSessionState
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

	public test()
	{
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		test.SqlLog(HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"].ToString());
	}

	public static void SqlLog(string ErrTxt)
	{
		try
		{
			string str = Path.Combine(HttpContext.Current.Request.ServerVariables["APPL_PHYSICAL_PATH"], Path.GetFileName("Error.log"));
			StreamWriter streamWriter = new StreamWriter(new FileStream(str, FileMode.Append, FileAccess.Write, FileShare.Read));
			try
			{
				object[] now = new object[] { DateTime.Now, " ", ErrTxt, "\r\n" };
				streamWriter.Write(string.Concat(now));
			}
			finally
			{
				if (streamWriter != null)
				{
					((IDisposable)streamWriter).Dispose();
				}
			}
		}
		catch
		{
		}
	}
}