using ns13;
using ns3;
using ns7;
using System;
using System.Data.SqlClient;

namespace ns1
{
	internal class DbPool_Class
	{
		private int int_0;

		private SqlParameter[] sqlParameter_0;

		private string string_0;

		private string string_1;

		public string Conn
		{
			get
			{
				return this.string_0;
			}
			set
			{
				this.string_0 = value;
			}
		}

		public SqlParameter[] Prams
		{
			get
			{
				return this.sqlParameter_0;
			}
			set
			{
				this.sqlParameter_0 = value;
			}
		}

		public string Sql
		{
			get
			{
				return this.string_1;
			}
			set
			{
				this.string_1 = value;
			}
		}

		public int Type
		{
			get
			{
				return this.int_0;
			}
			set
			{
				this.int_0 = value;
			}
		}

		public DbPool_Class()
		{
		}

		public static int smethod_0(string string_2, string string_3, SqlParameter[] sqlParameter_1, int int_1)
		{
			int num;
			try
			{
				SqlConnection sqlConnection = new SqlConnection(string_2);
				if (int_1 == 1)
				{
					if (SqlDBA.smethod_1(sqlConnection, string_3, sqlParameter_1) != -1)
					{
						num = 0;
					}
					else
					{
						if (World.jlMsg == 1)
						{
							Form1.WriteLine(0, string_3);
						}
						num = -1;
					}
				}
				else if (SqlDBA.RunProc(sqlConnection, string_3, sqlParameter_1) != -1)
				{
					num = 0;
				}
				else
				{
					if (World.jlMsg == 1)
					{
						Form1.WriteLine(0, string_3);
					}
					num = -1;
				}
			}
			catch (Exception exception)
			{
				Form1.WriteLine(1, string.Concat("DbPoolClassRun出错", exception));
				num = -1;
			}
			return num;
		}
	}
}