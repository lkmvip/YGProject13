using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

public class DBA
{
	public static string strConnection;

	static DBA()
	{
		DBA.strConnection = ConfigurationSettings.AppSettings["ConnString"];
	}

	public DBA()
	{
	}

	public static int ExeSqlCommand(string sqlCommand)
	{
		int num;
		SqlConnection sqlConnection = new SqlConnection(DBA.strConnection);
		SqlCommand sqlCommand1 = new SqlCommand(sqlCommand, sqlConnection);
		int num1 = -1;
		try
		{
			sqlConnection.Open();
		}
		catch
		{
			num = -1;
			return num;
		}
		try
		{
			num1 = sqlCommand1.ExecuteNonQuery();
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			WebFun.ScriptMessage(string.Concat("SQL错误:", exception.Message), true);
		}
		sqlConnection.Close();
		num = num1;
		return num;
	}

	public static int ExeSqlCommand(string sqlCommand, ref Exception exception)
	{
		int num;
		SqlConnection sqlConnection = new SqlConnection(DBA.strConnection);
		SqlCommand sqlCommand1 = new SqlCommand(sqlCommand, sqlConnection);
		try
		{
			sqlConnection.Open();
		}
		catch (Exception exception1)
		{
			exception = exception1;
			num = -1;
			return num;
		}
		int num1 = sqlCommand1.ExecuteNonQuery();
		sqlConnection.Close();
		num = num1;
		return num;
	}

	public static bool ExeSqlCommands(string[] sqlCommands)
	{
		bool flag;
		bool flag1;
		if ((int)sqlCommands.Length < 1)
		{
			flag = false;
		}
		else
		{
			SqlConnection sqlConnection = new SqlConnection(DBA.strConnection);
			try
			{
				sqlConnection.Open();
			}
			catch
			{
				flag = false;
				flag1 = flag;
				return flag1;
			}
			int num = 0;
			SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();
			try
			{
				while (num < (int)sqlCommands.Length)
				{
					SqlCommand sqlCommand = new SqlCommand(sqlCommands[num], sqlConnection)
					{
						Transaction = sqlTransaction
					};
					SqlCommand sqlCommand1 = sqlCommand;
					try
					{
						sqlCommand1.ExecuteNonQuery();
					}
					catch
					{
						sqlTransaction.Rollback();
						flag = false;
						flag1 = flag;
						return flag1;
					}
					num++;
				}
				if (num >= (int)sqlCommands.Length)
				{
					sqlTransaction.Commit();
				}
			}
			finally
			{
				if (sqlTransaction != null)
				{
					((IDisposable)sqlTransaction).Dispose();
				}
			}
			if (sqlConnection.State != ConnectionState.Closed)
			{
				sqlConnection.Close();
			}
			flag = true;
		}
		flag1 = flag;
		return flag1;
	}

	public static int ExeSqlCommands(string[] sqlCommands, bool mustExist)
	{
		bool flag;
		int num;
		int num1 = 0;
		if ((int)sqlCommands.Length >= 1)
		{
			SqlConnection sqlConnection = new SqlConnection(DBA.strConnection);
			try
			{
				sqlConnection.Open();
			}
			catch
			{
				num = -1;
				return num;
			}
			int num2 = 0;
			int num3 = 0;
			SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();
			try
			{
				while (num2 < (int)sqlCommands.Length)
				{
					SqlCommand sqlCommand = new SqlCommand(sqlCommands[num2], sqlConnection)
					{
						Transaction = sqlTransaction
					};
					SqlCommand sqlCommand1 = sqlCommand;
					try
					{
						num3 = sqlCommand1.ExecuteNonQuery();
					}
					catch
					{
						num3 = -1;
					}
					if (num3 >= 0)
					{
						flag = (!mustExist ? true : num3 != 0);
					}
					else
					{
						flag = false;
					}
					if (!flag)
					{
						num1 = -2;
						sqlTransaction.Rollback();
						break;
					}
					else
					{
						num1 = num1 + num3;
						num2++;
					}
				}
				if (num2 >= (int)sqlCommands.Length)
				{
					sqlTransaction.Commit();
				}
			}
			finally
			{
				if (sqlTransaction != null)
				{
					((IDisposable)sqlTransaction).Dispose();
				}
			}
			if (sqlConnection.State != ConnectionState.Closed)
			{
				sqlConnection.Close();
			}
		}
		num = num1;
		return num;
	}

	public static int ExeSqlCommands(ArrayList sqlCommands, bool mustExist)
	{
		bool flag;
		int num;
		int num1 = 0;
		if (sqlCommands.Count >= 1)
		{
			SqlConnection sqlConnection = new SqlConnection(DBA.strConnection);
			try
			{
				sqlConnection.Open();
			}
			catch
			{
				num = -1;
				return num;
			}
			int num2 = 0;
			int num3 = 0;
			SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();
			try
			{
				while (num2 < sqlCommands.Count)
				{
					SqlCommand sqlCommand = new SqlCommand(sqlCommands[num2].ToString(), sqlConnection)
					{
						Transaction = sqlTransaction
					};
					SqlCommand sqlCommand1 = sqlCommand;
					try
					{
						num3 = sqlCommand1.ExecuteNonQuery();
					}
					catch
					{
						num3 = -1;
					}
					if (num3 >= 0)
					{
						flag = (!mustExist ? true : num3 != 0);
					}
					else
					{
						flag = false;
					}
					if (!flag)
					{
						num1 = -2;
						sqlTransaction.Rollback();
						break;
					}
					else
					{
						num1 = num1 + num3;
						num2++;
					}
				}
				if (num2 >= sqlCommands.Count)
				{
					sqlTransaction.Commit();
				}
			}
			finally
			{
				if (sqlTransaction != null)
				{
					((IDisposable)sqlTransaction).Dispose();
				}
			}
			if (sqlConnection.State != ConnectionState.Closed)
			{
				sqlConnection.Close();
			}
		}
		num = num1;
		return num;
	}

	public static DataTable GetDBToDataTable(string sqlCommand)
	{
		DataTable dataTable;
		SqlConnection sqlConnection = new SqlConnection(DBA.strConnection);
		SqlDataAdapter sqlDataAdapter = new SqlDataAdapter()
		{
			SelectCommand = new SqlCommand(sqlCommand, sqlConnection)
		};
		SqlDataAdapter sqlDataAdapter1 = sqlDataAdapter;
		try
		{
			sqlConnection.Open();
		}
		catch
		{
			dataTable = null;
			return dataTable;
		}
		DataTable dataTable1 = new DataTable();
		try
		{
			sqlDataAdapter1.Fill(dataTable1);
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			WebFun.ScriptMessage(string.Concat("SQL错误:", exception.Message), true);
		}
		sqlDataAdapter1.Dispose();
		sqlConnection.Close();
		sqlConnection.Dispose();
		dataTable = dataTable1;
		return dataTable;
	}

	public static DataRowCollection GetDBValue(string sqlCommand)
	{
		return DBA.GetDBToDataTable(sqlCommand).Rows;
	}

	public static ArrayList GetDBValue_1(string sqlCommand)
	{
		ArrayList arrayLists;
		ArrayList arrayLists1;
		SqlConnection sqlConnection = new SqlConnection(DBA.strConnection);
		SqlCommand sqlCommand1 = new SqlCommand(sqlCommand, sqlConnection);
		try
		{
			sqlConnection.Open();
		}
		catch
		{
			arrayLists = null;
			arrayLists1 = arrayLists;
			return arrayLists1;
		}
		SqlDataReader sqlDataReader = sqlCommand1.ExecuteReader();
		if (!sqlDataReader.HasRows)
		{
			sqlDataReader.Close();
			sqlConnection.Close();
			arrayLists = null;
		}
		else
		{
			ArrayList arrayLists2 = new ArrayList();
			if (sqlDataReader.Read())
			{
				for (int i = 0; i < sqlDataReader.FieldCount; i++)
				{
					arrayLists2.Add(sqlDataReader[i]);
				}
			}
			sqlDataReader.Close();
			sqlConnection.Close();
			arrayLists = arrayLists2;
		}
		arrayLists1 = arrayLists;
		return arrayLists1;
	}

	public static ArrayList GetDBValue_2(string sqlCommand)
	{
		ArrayList arrayLists;
		ArrayList arrayLists1;
		SqlConnection sqlConnection = new SqlConnection(DBA.strConnection);
		SqlCommand sqlCommand1 = new SqlCommand(sqlCommand, sqlConnection);
		try
		{
			sqlConnection.Open();
		}
		catch
		{
			arrayLists = null;
			arrayLists1 = arrayLists;
			return arrayLists1;
		}
		SqlDataReader sqlDataReader = sqlCommand1.ExecuteReader();
		if (!sqlDataReader.HasRows)
		{
			sqlDataReader.Close();
			sqlConnection.Close();
			arrayLists = null;
		}
		else
		{
			ArrayList arrayLists2 = new ArrayList();
			while (sqlDataReader.Read())
			{
				arrayLists2.Add(sqlDataReader[0]);
			}
			sqlDataReader.Close();
			sqlConnection.Close();
			arrayLists = arrayLists2;
		}
		arrayLists1 = arrayLists;
		return arrayLists1;
	}

	public static object GetDBValue_3(string sqlCommand)
	{
		object obj;
		SqlConnection sqlConnection = new SqlConnection(DBA.strConnection);
		SqlCommand sqlCommand1 = new SqlCommand(sqlCommand, sqlConnection);
		try
		{
			sqlConnection.Open();
		}
		catch
		{
			obj = null;
			return obj;
		}
		object obj2 = sqlCommand1.ExecuteScalar();
		sqlConnection.Close();
		obj = obj2;
		return obj;
	}

	public static DataSet GetNewList(string 表名, int 每页显示数, int 当前页, string 查询条件, string 表的主键, string 排序字段, int 排序方法, out int 总页数, out int 记录数)
	{
		DataSet dataSet = null;
		SqlConnection sqlConnection = new SqlConnection(DBA.strConnection);
		总页数 = 0;
		记录数 = 0;
		try
		{
			SqlParameter[] sqlParameterArray = new SqlParameter[] { SqlDBA.MakeInParam("@tblName", SqlDbType.NVarChar, 200, 表名), SqlDBA.MakeInParam("@pageSize", SqlDbType.Int, 10, 每页显示数), SqlDBA.MakeInParam("@page", SqlDbType.Int, 10, 当前页), SqlDBA.MakeInParam("@strCondition", SqlDbType.NVarChar, 1000, 查询条件), SqlDBA.MakeInParam("@ID", SqlDbType.NVarChar, 150, 表的主键), SqlDBA.MakeInParam("@fldSort", SqlDbType.NVarChar, 200, 排序字段), SqlDBA.MakeInParam("@Sort", SqlDbType.Bit, 10, 排序方法), SqlDBA.MakeOutParam("@pageCount", SqlDbType.Int, 4), SqlDBA.MakeOutParam("@Counts", SqlDbType.Int, 4) };
			SqlParameter[] sqlParameterArray1 = sqlParameterArray;
			SqlDBA.RunProc(sqlConnection, "proc_ListPageInt", sqlParameterArray1, out dataSet);
			总页数 = Convert.ToInt32(sqlParameterArray1[7].Value);
			记录数 = Convert.ToInt32(sqlParameterArray1[8].Value);
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			WebFun.ScriptMessage(string.Concat("SqlDBA发生错误，信息为：", exception.Message), true);
		}
		return dataSet;
	}
}