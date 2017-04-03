using ns13;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace ns7
{
	internal class SqlDBA
	{
		public SqlDBA()
		{
		}

		public static SqlParameter MakeInParam(string string_0, SqlDbType sqlDbType_0, int int_0, object object_0)
		{
			return SqlDBA.smethod_10(string_0, sqlDbType_0, int_0, ParameterDirection.Input, object_0);
		}

		public static int RunProc(SqlConnection sqlConnection_0, string string_0, SqlParameter[] sqlParameter_0)
		{
			int num;
			try
			{
				sqlConnection_0.Open();
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				Form1.WriteLine(100, string.Concat("SqlDBA数据层_错误1", exception.Message));
				num = -1;
				return num;
			}
			SqlCommand sqlCommand = SqlDBA.smethod_6(sqlConnection_0, string_0, sqlParameter_0);
			try
			{
				try
				{
					sqlCommand.ExecuteNonQuery();
					return (int)sqlCommand.Parameters["ReturnValue"].Value;
				}
				catch (Exception exception3)
				{
					Exception exception2 = exception3;
					Form1.WriteLine(100, string.Concat("SqlDBA数据层_错误2", exception2.Message));
					sqlCommand.Parameters.Clear();
					num = -1;
				}
			}
			finally
			{
				sqlConnection_0.Close();
				sqlConnection_0.Dispose();
			}
			return num;
		}

		public static int smethod_1(SqlConnection sqlConnection_0, string string_0, SqlParameter[] sqlParameter_0)
		{
			int num;
			int num1 = -1;
			try
			{
				sqlConnection_0.Open();
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				Form1.WriteLine(100, string.Concat("SqlDBA数据层_错误3", exception.Message));
				num = num1;
				return num;
			}
			SqlCommand sqlCommand = SqlDBA.smethod_7(sqlConnection_0, string_0, sqlParameter_0);
			try
			{
				try
				{
					num1 = sqlCommand.ExecuteNonQuery();
					return num1;
				}
				catch (Exception exception3)
				{
					Exception exception2 = exception3;
					Form1.WriteLine(100, string.Concat("SqlDBA数据层_错误4", exception2.Message));
					sqlCommand.Parameters.Clear();
					num = num1;
				}
			}
			finally
			{
				sqlConnection_0.Close();
				sqlConnection_0.Dispose();
			}
			return num;
		}

		public static SqlParameter smethod_10(string string_0, SqlDbType sqlDbType_0, int int_0, ParameterDirection parameterDirection_0, object object_0)
		{
			SqlParameter parameterDirection0;
			parameterDirection0 = (int_0 <= 0 ? new SqlParameter(string_0, sqlDbType_0) : new SqlParameter(string_0, sqlDbType_0, int_0));
			parameterDirection0.Direction = parameterDirection_0;
			if (parameterDirection_0 != ParameterDirection.Output || object_0 != null)
			{
				parameterDirection0.Value = object_0;
			}
			return parameterDirection0;
		}

		public static void smethod_2(SqlConnection sqlConnection_0, string string_0, out SqlDataReader sqlDataReader_0)
		{
			sqlDataReader_0 = SqlDBA.smethod_6(sqlConnection_0, string_0, null).ExecuteReader(CommandBehavior.CloseConnection);
		}

		public static void smethod_3(SqlConnection sqlConnection_0, string string_0, SqlParameter[] sqlParameter_0, out SqlDataReader sqlDataReader_0)
		{
			sqlDataReader_0 = SqlDBA.smethod_6(sqlConnection_0, string_0, sqlParameter_0).ExecuteReader(CommandBehavior.CloseConnection);
		}

		public static void smethod_4(SqlConnection sqlConnection_0, string string_0, SqlParameter[] sqlParameter_0, out DataSet dataSet_0)
		{
			SqlCommand sqlCommand = SqlDBA.smethod_6(sqlConnection_0, string_0, sqlParameter_0);
			using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
			{
				DataSet dataSet = new DataSet();
				sqlDataAdapter.Fill(dataSet);
				sqlCommand.Parameters.Clear();
				sqlConnection_0.Close();
				sqlConnection_0.Dispose();
				dataSet_0 = dataSet;
				sqlDataAdapter.Dispose();
			}
		}

		public static DataTable smethod_5(SqlConnection sqlConnection_0, string string_0, SqlParameter[] sqlParameter_0)
		{
			DataTable dataTable = new DataTable();
			SqlCommand sqlCommand = SqlDBA.smethod_6(sqlConnection_0, string_0, sqlParameter_0);
			using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
			{
				try
				{
					sqlDataAdapter.Fill(dataTable);
				}
				catch (Exception exception)
				{
				}
				sqlCommand.Parameters.Clear();
				sqlDataAdapter.Dispose();
				sqlConnection_0.Close();
				sqlConnection_0.Dispose();
			}
			return dataTable;
		}

		public static SqlCommand smethod_6(SqlConnection sqlConnection_0, string string_0, SqlParameter[] sqlParameter_0)
		{
			SqlCommand sqlCommand = new SqlCommand(string_0, sqlConnection_0)
			{
				CommandType = CommandType.StoredProcedure,
				CommandTimeout = 180
			};
			if (sqlParameter_0 != null)
			{
				SqlParameter[] sqlParameter0 = sqlParameter_0;
				for (int i = 0; i < (int)sqlParameter0.Length; i++)
				{
					SqlParameter sqlParameter = sqlParameter0[i];
					sqlCommand.Parameters.Add(sqlParameter);
				}
			}
			sqlCommand.Parameters.Add(new SqlParameter("ReturnValue", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, 0, 0, string.Empty, DataRowVersion.Default, null));
			return sqlCommand;
		}

		public static SqlCommand smethod_7(SqlConnection sqlConnection_0, string string_0, SqlParameter[] sqlParameter_0)
		{
			SqlCommand sqlCommand = new SqlCommand(string_0, sqlConnection_0)
			{
				CommandType = CommandType.Text,
				CommandTimeout = 180
			};
			if (sqlParameter_0 != null)
			{
				SqlParameter[] sqlParameter0 = sqlParameter_0;
				for (int i = 0; i < (int)sqlParameter0.Length; i++)
				{
					SqlParameter sqlParameter = sqlParameter0[i];
					sqlCommand.Parameters.Add(sqlParameter);
				}
			}
			sqlCommand.Parameters.Add(new SqlParameter("ReturnValue", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, 0, 0, string.Empty, DataRowVersion.Default, null));
			return sqlCommand;
		}

		public static SqlParameter smethod_9(string string_0, SqlDbType sqlDbType_0, int int_0)
		{
			return SqlDBA.smethod_10(string_0, sqlDbType_0, int_0, ParameterDirection.Output, null);
		}
	}
}