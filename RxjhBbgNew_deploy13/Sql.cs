using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public class Sql
{
	public Sql()
	{
	}

	public static DataSet GetList(string TBName, int PageSize, int CurPage, string KeyField, string Condition, string Order)
	{
		DataSet dataSet = null;
		SqlConnection sqlConnection = new SqlConnection(ConfigurationSettings.AppSettings["ConnString"]);
		try
		{
			SqlParameter[] sqlParameterArray = new SqlParameter[] { SqlDBA.MakeInParam("@TBName", SqlDbType.NVarChar, 100, TBName), SqlDBA.MakeInParam("@PageSize", SqlDbType.Int, 10, PageSize), SqlDBA.MakeInParam("@CurPage", SqlDbType.Int, 10, CurPage), SqlDBA.MakeInParam("@KeyField", SqlDbType.NVarChar, 100, KeyField), SqlDBA.MakeInParam("@Condition", SqlDbType.NVarChar, 200, Condition), SqlDBA.MakeInParam("@Order", SqlDbType.NVarChar, 200, Order) };
			SqlDBA.RunProc(sqlConnection, "XW_PublicTurnPageWebSite", sqlParameterArray, out dataSet);
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			WebFun.ScriptMessage(string.Concat("SqlDBA发生错误，信息为：", exception.Message), true);
		}
		return dataSet;
	}

	public static void SetLog(string userid, string username, string itmename, string serverid, int sl, int POINT)
	{
		object[] objArray = new object[] { userid, username, itmename, serverid, sl, POINT };
		DBA.ExeSqlCommand(string.Format("INSERT INTO BBGLog (userid,username,itmename,serverid,sl,POINT)values('{0}','{1}','{2}','{3}',{4},{5})", objArray));
	}
}