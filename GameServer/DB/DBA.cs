using ns11;
using ns13;
using ns3;
using ns7;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace ns2
{
	internal class DBA
	{
		public DBA()
		{
		}

		public static int ExeSqlCommand(string string_0)
		{
			int num;
			DBA.serlog(string_0);
			using (SqlConnection sqlConnection = new SqlConnection(DBA.smethod_3(null)))
			{
				using (SqlCommand sqlCommand = new SqlCommand(string_0, sqlConnection))
				{
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
						num1 = sqlCommand.ExecuteNonQuery();
					}
					catch (Exception exception)
					{
						DBA.smethod_2(string_0, null, exception);
					}
					sqlCommand.Dispose();
					sqlConnection.Close();
					sqlConnection.Dispose();
					return num1;
				}
			}
			return num;
		}

		public static DataTable GetDBToDataTable(string string_0, SqlParameter[] sqlParameter_0, string string_1)
		{
			DataTable dataTable;
			DBA.serlog(string_0, sqlParameter_0);
			using (SqlConnection sqlConnection = new SqlConnection(DBA.smethod_3(string_1)))
			{
				using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
				{
					SqlCommand sqlCommand = SqlDBA.smethod_7(sqlConnection, string_0, sqlParameter_0);
					SqlCommand sqlCommand1 = sqlCommand;
					sqlDataAdapter.SelectCommand = sqlCommand;
					using (sqlCommand1)
					{
						try
						{
							sqlConnection.Open();
						}
						catch (Exception exception1)
						{
							Exception exception = exception1;
							Form1.WriteLine(100, string.Concat("DBA数据层_错误", exception.Message, " ", string_0));
							dataTable = null;
							return dataTable;
						}
						DataTable dataTable1 = new DataTable();
						try
						{
							sqlDataAdapter.Fill(dataTable1);
						}
						catch (Exception exception2)
						{
							DBA.smethod_2(string_0, sqlParameter_0, exception2);
						}
						sqlDataAdapter.Dispose();
						sqlConnection.Close();
						sqlConnection.Dispose();
						return dataTable1;
					}
				}
			}
			return dataTable;
		}

		public static DataTable GetDBToDataTable(string string_0)
		{
			DataTable dataTable;
			DBA.serlog(string_0);
			using (SqlConnection sqlConnection = new SqlConnection(DBA.smethod_3(null)))
			{
				using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
				{
					SqlCommand sqlCommand = new SqlCommand(string_0, sqlConnection);
					SqlCommand sqlCommand1 = sqlCommand;
					sqlDataAdapter.SelectCommand = sqlCommand;
					using (sqlCommand1)
					{
						try
						{
							sqlConnection.Open();
						}
						catch (Exception exception1)
						{
							Exception exception = exception1;
							Form1.WriteLine(100, string.Concat("DBA数据层_错误", exception.Message, " ", string_0));
							dataTable = null;
							return dataTable;
						}
						DataTable dataTable1 = new DataTable();
						try
						{
							sqlDataAdapter.Fill(dataTable1);
						}
						catch (Exception exception2)
						{
							DBA.smethod_2(string_0, null, exception2);
						}
						sqlDataAdapter.Dispose();
						sqlConnection.Close();
						sqlConnection.Dispose();
						return dataTable1;
					}
				}
			}
			return dataTable;
		}

		public static DataTable GetDBToDataTable(string string_0, string string_1)
		{
			DataTable dataTable;
			DBA.serlog(string_0);
			using (SqlConnection sqlConnection = new SqlConnection(DBA.smethod_3(string_1)))
			{
				using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
				{
					SqlCommand sqlCommand = new SqlCommand(string_0, sqlConnection);
					SqlCommand sqlCommand1 = sqlCommand;
					sqlDataAdapter.SelectCommand = sqlCommand;
					using (sqlCommand1)
					{
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
							sqlDataAdapter.Fill(dataTable1);
						}
						catch (Exception exception)
						{
							DBA.smethod_2(string_0, null, exception);
						}
						sqlDataAdapter.Dispose();
						sqlConnection.Close();
						sqlConnection.Dispose();
						return dataTable1;
					}
				}
			}
			return dataTable;
		}

		public static object GetDBValue_3(string string_0)
		{
			object obj;
			DBA.serlog(string_0);
			object obj1 = null;
			using (SqlConnection sqlConnection = new SqlConnection(DBA.smethod_3(null)))
			{
				using (SqlCommand sqlCommand = new SqlCommand(string_0, sqlConnection))
				{
					try
					{
						sqlConnection.Open();
					}
					catch
					{
						obj = null;
						return obj;
					}
					try
					{
						obj1 = sqlCommand.ExecuteScalar();
					}
					catch (Exception exception1)
					{
						Exception exception = exception1;
						Form1.WriteLine(100, string.Concat("DBA数据层_错误", exception.Message, " ", string_0));
					}
					sqlCommand.Dispose();
					sqlConnection.Close();
					sqlConnection.Dispose();
					return obj1;
				}
			}
			return obj;
		}

		public static void serlog(string string_0)
		{
			string sqlJl = World.SqlJl;
			if (sqlJl != "")
			{
				string[] strArrays = sqlJl.Split(new char[] { '|' });
				for (int i = 0; i < (int)strArrays.Length; i++)
				{
					if (string_0.ToLower().IndexOf(strArrays[i].ToLower()) != -1)
					{
						Form1.WriteLine(99, string_0);
					}
				}
			}
		}

		public static void serlog(string string_0, SqlParameter[] sqlParameter_0)
		{
			string sqlJl = World.SqlJl;
			if (sqlJl != "")
			{
				string[] strArrays = sqlJl.Split(new char[] { '|' });
				for (int i = 0; i < (int)strArrays.Length; i++)
				{
					if (string_0.ToLower().IndexOf(strArrays[i].ToLower()) != -1)
					{
						Form1.WriteLine(99, string_0);
					}
				}
				for (int j = 0; j < (int)strArrays.Length; j++)
				{
					SqlParameter[] sqlParameter0 = sqlParameter_0;
					for (int k = 0; k < (int)sqlParameter0.Length; k++)
					{
						SqlParameter sqlParameter = sqlParameter0[k];
						if (sqlParameter.SqlValue.ToString().ToLower().IndexOf(strArrays[j].ToLower()) != -1)
						{
							Form1.WriteLine(99, string.Concat(string_0, " ", sqlParameter.SqlValue.ToString()));
						}
					}
				}
			}
		}

		public static DataRowCollection smethod_13(string string_0, string string_1)
		{
			return DBA.GetDBToDataTable(string_0).Rows;
		}

		public static ArrayList smethod_14(string string_0, string string_1)
		{
			ArrayList arrayLists;
			DBA.serlog(string_0);
			using (SqlConnection sqlConnection = new SqlConnection(DBA.smethod_3(null)))
			{
				using (SqlCommand sqlCommand = new SqlCommand(string_0, sqlConnection))
				{
					try
					{
						sqlConnection.Open();
					}
					catch
					{
						arrayLists = null;
						return arrayLists;
					}
					SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
					if (sqlDataReader.HasRows)
					{
						ArrayList arrayLists1 = new ArrayList();
						if (sqlDataReader.Read())
						{
							for (int i = 0; i < sqlDataReader.FieldCount; i++)
							{
								arrayLists1.Add(sqlDataReader[i]);
							}
						}
						sqlDataReader.Close();
						sqlDataReader.Dispose();
						sqlConnection.Close();
						sqlConnection.Dispose();
						return arrayLists1;
					}
					else
					{
						sqlDataReader.Close();
						sqlDataReader.Dispose();
						sqlConnection.Close();
						sqlConnection.Dispose();
						arrayLists = null;
					}
				}
			}
			return arrayLists;
		}

		public static ArrayList smethod_15(string string_0, string string_1)
		{
			ArrayList arrayLists;
			DBA.serlog(string_0);
			using (SqlConnection sqlConnection = new SqlConnection(DBA.smethod_3(null)))
			{
				using (SqlCommand sqlCommand = new SqlCommand(string_0, sqlConnection))
				{
					try
					{
						sqlConnection.Open();
					}
					catch
					{
						arrayLists = null;
						return arrayLists;
					}
					SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
					if (sqlDataReader.HasRows)
					{
						ArrayList arrayLists1 = new ArrayList();
						while (sqlDataReader.Read())
						{
							arrayLists1.Add(sqlDataReader[0]);
						}
						sqlDataReader.Close();
						sqlDataReader.Dispose();
						sqlConnection.Close();
						sqlConnection.Dispose();
						return arrayLists1;
					}
					else
					{
						sqlDataReader.Close();
						sqlDataReader.Dispose();
						sqlConnection.Close();
						sqlConnection.Dispose();
						arrayLists = null;
					}
				}
			}
			return arrayLists;
		}

		public static object smethod_17(string string_0, SqlParameter[] sqlParameter_0)
		{
			object obj;
			DBA.serlog(string_0, sqlParameter_0);
			object obj1 = null;
			using (SqlConnection sqlConnection = new SqlConnection(DBA.smethod_3(null)))
			{
				using (SqlCommand sqlCommand = SqlDBA.smethod_7(sqlConnection, string_0, sqlParameter_0))
				{
					try
					{
						sqlConnection.Open();
					}
					catch
					{
						obj = null;
						return obj;
					}
					try
					{
						obj1 = sqlCommand.ExecuteScalar();
					}
					catch (Exception exception1)
					{
						Exception exception = exception1;
						Form1.WriteLine(100, string.Concat("DBA数据层_错误", exception.Message, " ", string_0));
					}
					sqlCommand.Dispose();
					sqlConnection.Close();
					sqlConnection.Dispose();
					return obj1;
				}
			}
			return obj;
		}

		public static object smethod_18(string string_0, string string_1)
		{
			object obj;
			DBA.serlog(string_0);
			object obj1 = null;
			using (SqlConnection sqlConnection = new SqlConnection(DBA.smethod_3(string_1)))
			{
				using (SqlCommand sqlCommand = new SqlCommand(string_0, sqlConnection))
				{
					try
					{
						sqlConnection.Open();
					}
					catch
					{
						obj = null;
						return obj;
					}
					try
					{
						obj1 = sqlCommand.ExecuteScalar();
					}
					catch (Exception exception1)
					{
						Exception exception = exception1;
						Form1.WriteLine(100, string.Concat("DBA数据层_错误", exception.Message, " ", string_0));
					}
					sqlCommand.Dispose();
					sqlConnection.Close();
					sqlConnection.Dispose();
					return obj1;
				}
			}
			return obj;
		}

		public static void smethod_2(string string_0, SqlParameter[] sqlParameter_0, Exception exception_0)
		{
			Form1.WriteLine(100, "-----------DBA数据层_错误-----------");
			Form1.WriteLine(100, string_0);
			if (sqlParameter_0 != null)
			{
				SqlParameter[] sqlParameter0 = sqlParameter_0;
				for (int i = 0; i < (int)sqlParameter0.Length; i++)
				{
					SqlParameter sqlParameter = sqlParameter0[i];
					Form1.WriteLine(100, sqlParameter.SqlValue.ToString());
				}
			}
			Form1.WriteLine(100, exception_0.Message);
		}

		public static string smethod_3(string string_0)
		{
			DBClass dBClass;
			string sqlConnect;
			try
			{
				if (string_0 == null)
				{
					string_0 = "GameServer";
				}
				if (!World.dictionary_7.TryGetValue(string_0, out dBClass))
				{
					sqlConnect = null;
				}
				else
				{
					sqlConnect = dBClass.SqlConnect;
				}
			}
			catch
			{
				sqlConnect = null;
			}
			return sqlConnect;
		}

		public static int smethod_4(string string_0, SqlParameter[] sqlParameter_0)
		{
			int num;
			DBA.serlog(string_0, sqlParameter_0);
			using (SqlConnection sqlConnection = new SqlConnection(DBA.smethod_3(null)))
			{
				using (SqlCommand sqlCommand = SqlDBA.smethod_7(sqlConnection, string_0, sqlParameter_0))
				{
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
						num1 = sqlCommand.ExecuteNonQuery();
					}
					catch (Exception exception)
					{
						DBA.smethod_2(string_0, sqlParameter_0, exception);
					}
					sqlCommand.Dispose();
					sqlConnection.Close();
					sqlConnection.Dispose();
					return num1;
				}
			}
			return num;
		}

		public static int smethod_5(string string_0, SqlParameter[] sqlParameter_0, string string_1)
		{
			int num;
			DBA.serlog(string_0, sqlParameter_0);
			using (SqlConnection sqlConnection = new SqlConnection(DBA.smethod_3(string_1)))
			{
				using (SqlCommand sqlCommand = SqlDBA.smethod_7(sqlConnection, string_0, sqlParameter_0))
				{
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
						num1 = sqlCommand.ExecuteNonQuery();
					}
					catch (Exception exception)
					{
						DBA.smethod_2(string_0, sqlParameter_0, exception);
					}
					sqlCommand.Dispose();
					sqlConnection.Close();
					sqlConnection.Dispose();
					return num1;
				}
			}
			return num;
		}

		public static int smethod_7(string string_0, string string_1)
		{
			int num;
			DBA.serlog(string_0);
			using (SqlConnection sqlConnection = new SqlConnection(DBA.smethod_3(string_1)))
			{
				using (SqlCommand sqlCommand = new SqlCommand(string_0, sqlConnection))
				{
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
						num1 = sqlCommand.ExecuteNonQuery();
					}
					catch (Exception exception)
					{
						DBA.smethod_2(string_0, null, exception);
					}
					sqlCommand.Dispose();
					sqlConnection.Close();
					sqlConnection.Dispose();
					return num1;
				}
			}
			return num;
		}

		public static int smethod_8(string string_0, ref Exception exception_0, string string_1)
		{
			int num;
			DBA.serlog(string_0);
			using (SqlConnection sqlConnection = new SqlConnection(DBA.smethod_3(null)))
			{
				using (SqlCommand sqlCommand = new SqlCommand(string_0, sqlConnection))
				{
					try
					{
						sqlConnection.Open();
					}
					catch (Exception exception)
					{
						exception_0 = exception;
						num = -1;
						return num;
					}
					int num1 = sqlCommand.ExecuteNonQuery();
					sqlCommand.Dispose();
					sqlConnection.Close();
					sqlConnection.Dispose();
					return num1;
				}
			}
			return num;
		}

		public static DataTable smethod_9(string string_0, SqlParameter[] sqlParameter_0)
		{
			DataTable dataTable;
			DBA.serlog(string_0, sqlParameter_0);
			using (SqlConnection sqlConnection = new SqlConnection(DBA.smethod_3(null)))
			{
				using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
				{
					SqlCommand sqlCommand = SqlDBA.smethod_7(sqlConnection, string_0, sqlParameter_0);
					SqlCommand sqlCommand1 = sqlCommand;
					sqlDataAdapter.SelectCommand = sqlCommand;
					using (sqlCommand1)
					{
						try
						{
							sqlConnection.Open();
						}
						catch (Exception exception1)
						{
							Exception exception = exception1;
							Form1.WriteLine(100, string.Concat("DBA数据层_错误", exception.Message, " ", string_0));
							dataTable = null;
							return dataTable;
						}
						DataTable dataTable1 = new DataTable();
						try
						{
							sqlDataAdapter.Fill(dataTable1);
						}
						catch (Exception exception2)
						{
							DBA.smethod_2(string_0, sqlParameter_0, exception2);
						}
						sqlDataAdapter.Dispose();
						sqlConnection.Close();
						sqlConnection.Dispose();
						return dataTable1;
					}
				}
			}
			return dataTable;
		}
	}
}