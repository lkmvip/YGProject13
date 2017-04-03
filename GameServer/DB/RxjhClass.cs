using ns1;
using ns12;
using ns2;
using ns3;
using ns6;
using ns7;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace ns9
{
	internal class RxjhClass
	{
		private static ItmesIDClass ItmeId;

		static RxjhClass()
		{
			RxjhClass.ZYDNGuard();
		}

		public RxjhClass()
		{
		}

		public static void DELETE_BANG_CHIEN_DAT_CUOC_DATA(string string_0, string string_1, int int_0, int int_1)
		{
			DBA.ExeSqlCommand(string.Format("DELETE FROM BANG_CHIEN_TIEN_DAT_CUOC WHERE UserId = '{0}' and UserName='{1}' and UserName='{2}'", string_0, string_1, int_0));
			if (int_1 == 1)
			{
				DBA.ExeSqlCommand(string.Format("UPDATE TBL_XWWL_Guild SET Thang=Thang+1 WHERE ID='{0}'", int_0));
				RxjhClass.INSERT_BACH_BAO_GHI_CHEP(string_0, string_1, 0, "Bang chien thang loi duoc", 1, 50);
				return;
			}
			if (int_1 != -1)
			{
				if (int_1 == 0)
				{
					DBA.ExeSqlCommand(string.Format("UPDATE TBL_XWWL_Guild SET Hoa=Hoa+1 WHERE ID='{0}'", int_0));
				}
				return;
			}
			DBA.ExeSqlCommand(string.Format("UPDATE TBL_XWWL_Guild SET Bai=Bai+1 WHERE ID='{0}'", int_0));
			RxjhClass.INSERT_BACH_BAO_GHI_CHEP(string_0, string_1, 0, "Bang chien that bai thua tran", 1, 50);
		}

		public static DataTable EXE_LOAD_GUILD(string string_0)
		{
			string str = string.Format("EXEC XWWL_LOAD_Guild @name", new object[0]);
			DataTable dataTable = DBA.smethod_9(str, new SqlParameter[] { SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, string_0) });
			if (dataTable == null)
			{
				return null;
			}
			if (dataTable.Rows.Count == 0)
			{
				return null;
			}
			return dataTable;
		}

		public static int EXE_XWWL_INT_Guild_DATA_New(string string_0, string string_1, int int_0)
		{
			string str = string.Format("EXEC XWWL_INT_Guild_DATA_New @name, @bpname,@leve", new object[0]);
			return (int)DBA.smethod_17(str, new SqlParameter[] { SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, string_0), SqlDBA.MakeInParam("@bpname", SqlDbType.VarChar, 30, string_1), SqlDBA.MakeInParam("@leve", SqlDbType.Int, 0, int_0) });
		}

		public static int EXE_XWWL_JR_Guild_DATA_New(string string_0, string string_1, int int_0)
		{
			string str = string.Format("EXEC XWWL_JR_Guild_DATA_New @name, @bpname,@leve", string_0, string_1, int_0);
			return (int)DBA.smethod_17(str, new SqlParameter[] { SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, string_0), SqlDBA.MakeInParam("@bpname", SqlDbType.VarChar, 30, string_1), SqlDBA.MakeInParam("@leve", SqlDbType.Int, 0, int_0) });
		}

		public static int EXE_XWWL_Out_Guild_DATA(string string_0)
		{
			string str = string.Format("EXEC XWWL_Out_Guild_DATA @name", new object[0]);
			return (int)DBA.smethod_17(str, new SqlParameter[] { SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, string_0) });
		}

		public static int EXE_XWWL_OutBz_Guild_DATA(string string_0, string string_1)
		{
			string str = string.Format("EXEC XWWL_OutBz_Guild_DATA @name, @bpname", new object[0]);
			return (int)DBA.smethod_17(str, new SqlParameter[] { SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, string_0), SqlDBA.MakeInParam("@bpname", SqlDbType.VarChar, 30, string_1) });
		}

		public static int EXE_XWWL_SELECT_Guild_DATA(string string_0)
		{
			string str = string.Format("EXEC XWWL_SELECT_Guild_DATA @bpnamea", new object[0]);
			return (int)DBA.smethod_17(str, new SqlParameter[] { SqlDBA.MakeInParam("@bpnamea", SqlDbType.VarChar, 30, string_0) });
		}

		public static long GetDBItmeId()
		{
			return RxjhClass.ItmeId.AcquireBuffer();
		}

		public static void INSERT_BACH_BAO_GHI_CHEP(string string_0, string string_1, double double_0, string string_2, int int_0, int int_1)
		{
			DBA.ExeSqlCommand(string.Format("INSERT INTO BACH_BAO_GHI_CHEP (UserId,UserName,Item_ID,Item_ten,Item_so_luong,So_luong_cash) VALUES ('{0}','{1}','{2}','{3}',{4},{5})", new object[] { string_0, string_1, double_0, string_2, int_0, int_1 }));
		}

		public static void INSERT_BACH_BAO_GHI_CHEP_2(string string_0, string string_1, double double_0, string string_2, int int_0, long long_0)
		{
			DBA.ExeSqlCommand(string.Format("INSERT INTO BACH_BAO_GHI_CHEP (UserId,UserName,Item_ID,Item_ten,Item_so_luong,So_luong_cash) VALUES ('{0}','{1}','{2}','{3}',{4},{5})", new object[] { string_0, string_1, double_0, string_2, int_0, long_0 }));
		}

		public static void INSERT_BANG_CHIEN_TIEN_DAT_CUOC(string string_0, string string_1, int int_0, int int_1)
		{
			DBA.ExeSqlCommand(string.Format("INSERT INTO BANG_CHIEN_TIEN_DAT_CUOC (UserId,UserName,Bang_phai_ID,So_luong_cash) VALUES ('{0}','{1}',{2},{3})", new object[] { string_0, string_1, int_0, int_1 }));
		}

		public static void INSERT_DANG_NHAP_GHI_CHEP(string string_0, string string_1, string string_2, string string_3)
		{
			if (World.DANG_NHAP_GHI_CHEP == 1)
			{
				string str = string.Format("INSERT INTO DANG_NHAP_GHI_CHEP (UserId,UserName,UserIp,Loai_hinh) VALUES (@UserId,@UserName,@UserIp,@Loai_hinh)", new object[0]);
				SqlParameter[] sqlParameterArray = new SqlParameter[] { SqlDBA.MakeInParam("@UserId", SqlDbType.VarChar, 30, string_0), SqlDBA.MakeInParam("@UserName", SqlDbType.VarChar, 30, string_1), SqlDBA.MakeInParam("@UserIp", SqlDbType.VarChar, 30, string_2), SqlDBA.MakeInParam("@Loai_hinh", SqlDbType.VarChar, 30, string_3) };
				DbPool_Class dbPoolClass = new DbPool_Class()
				{
					Conn = DBA.smethod_3(null),
					Prams = sqlParameterArray,
					Sql = str,
					Type = 1
				};
				World.queue_1.Enqueue(dbPoolClass);
			}
		}

		public static void INSERT_ITEM_GHI_CHEP(string string_0, string string_1, string string_2, string string_3, double double_0, int int_0, string string_4, int int_1, string string_5, int int_2, string string_6)
		{
			if (World.ITEM_GHI_CHEP == 1)
			{
				string str = string.Format("INSERT INTO ITEM_GHI_CHEP (UserId,UserName,ToUserId,ToUserName,Toan_bo_ID,Item_ID,Item_ten,Item_so_luong,Item_thuoc_tinh,So_tien,Loai_hinh) VALUES (@UserId,@UserName,@ToUserId,@ToUserName,@Toan_bo_ID,@Item_ID,@Item_ten,@Item_so_luong,@Item_thuoc_tinh,@So_tien,@Loai_hinh)", new object[0]);
				SqlParameter[] sqlParameterArray = new SqlParameter[] { SqlDBA.MakeInParam("@UserId", SqlDbType.VarChar, 30, string_0), SqlDBA.MakeInParam("@UserName", SqlDbType.VarChar, 30, string_1), SqlDBA.MakeInParam("@ToUserId", SqlDbType.VarChar, 30, string_2), SqlDBA.MakeInParam("@ToUserName", SqlDbType.VarChar, 30, string_3), SqlDBA.MakeInParam("@Toan_bo_ID", SqlDbType.VarChar, 30, double_0), SqlDBA.MakeInParam("@Item_ID", SqlDbType.VarChar, 30, int_0), SqlDBA.MakeInParam("@Item_ten", SqlDbType.VarChar, 30, string_4), SqlDBA.MakeInParam("@Item_so_luong", SqlDbType.Int, 4, int_1), SqlDBA.MakeInParam("@Item_thuoc_tinh", SqlDbType.VarChar, 100, string_5), SqlDBA.MakeInParam("@So_tien", SqlDbType.Int, 4, int_2), SqlDBA.MakeInParam("@Loai_hinh", SqlDbType.VarChar, 10, string_6) };
				DbPool_Class dbPoolClass = new DbPool_Class()
				{
					Conn = DBA.smethod_3(null),
					Prams = sqlParameterArray,
					Sql = str,
					Type = 1
				};
				World.queue_1.Enqueue(dbPoolClass);
			}
		}

		public static void INSERT_MsgLog(string string_0, string string_1, string string_2, string string_3, int int_0)
		{
			DBA.ExeSqlCommand(string.Format("INSERT INTO MsgLog (userid,username,ToUserName,msg,msgType) VALUES ('{0}','{1}','{2}','{3}',{4})", new object[] { string_0, string_1, string_2, string_3, int_0 }));
		}

		public static string md5(string string_0)
		{
			return BitConverter.ToString((new MD5CryptoServiceProvider()).ComputeHash(Encoding.ASCII.GetBytes(string_0))).Replace("-", "").ToLower();
		}

		public static DataTable SELECT_ALL_TBL_XWWL_GuildMember(string string_0)
		{
			string str = string.Format("SELECT * FROM TBL_XWWL_GuildMember WHERE G_Name =@name", new object[0]);
			DataTable dataTable = DBA.smethod_9(str, new SqlParameter[] { SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, string_0) });
			if (dataTable == null)
			{
				return null;
			}
			if (dataTable.Rows.Count == 0)
			{
				return null;
			}
			return dataTable;
		}

		public static int SELECT_FLD_NAME(string string_0)
		{
			string str = string.Format("SELECT FLD_NAME FROM TBL_XWWL_Char WHERE FLD_NAME=@name", new object[0]);
			DataTable dataTable = DBA.smethod_9(str, new SqlParameter[] { SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, string_0) });
			if (dataTable != null)
			{
				if (dataTable.Rows.Count == 0)
				{
					dataTable.Dispose();
					return 1;
				}
				dataTable.Dispose();
			}
			return -1;
		}

		public static DataTable SELECT_GUILDNAME(string string_0)
		{
			string str = string.Format("SELECT * FROM TBL_XWWL_Guild WHERE G_Name = @name", new object[0]);
			DataTable dataTable = DBA.smethod_9(str, new SqlParameter[] { SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, string_0) });
			if (dataTable == null)
			{
				return null;
			}
			if (dataTable.Rows.Count == 0)
			{
				return null;
			}
			return dataTable;
		}

		public static byte[] Select_Mon_Huy(int int_0)
		{
			byte[] numArray;
			try
			{
				DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT * FROM TBL_XWWL_Guild WHERE ID = {0}", int_0));
				if (dBToDataTable.Rows.Count != 0)
				{
					if (dBToDataTable.Rows[0]["Mon_huy"].GetType().ToString() != "System.DBNull")
					{
						byte[] item = (byte[])dBToDataTable.Rows[0]["Mon_huy"];
						if (item != null)
						{
							numArray = item;
							return numArray;
						}
					}
					else
					{
						numArray = null;
						return numArray;
					}
				}
				numArray = null;
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception);
				numArray = null;
			}
			return numArray;
		}

		public static int SELECT_TBL_XWWL_Cw(string string_0, string string_1, int int_0, long long_0)
		{
			string str = string.Format("SELECT Name FROM TBL_XWWL_Cw WHERE Name=@name", string_0);
			DataTable dataTable = DBA.smethod_9(str, new SqlParameter[] { SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, string_0) });
			if (dataTable != null)
			{
				if (dataTable.Rows.Count == 0)
				{
					dataTable.Dispose();
					string str1 = string.Format("EXEC XWWL_INT_Cw_DATA @zrname,@name,@id,@type,@zb1,@zb2", new object[] { string_1, string_0, long_0, int_0, Converter.smethod_24(new byte[292]), Converter.smethod_24(new byte[1168]) });
					if (DBA.smethod_4(str1, new SqlParameter[] { SqlDBA.MakeInParam("@zrname", SqlDbType.VarChar, 30, string_1), SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, string_0), SqlDBA.MakeInParam("@id", SqlDbType.Int, 0, long_0), SqlDBA.MakeInParam("@type", SqlDbType.Int, 0, int_0), SqlDBA.MakeInParam("@zb1", SqlDbType.VarBinary, 292, new byte[292]), SqlDBA.MakeInParam("@zb2", SqlDbType.VarBinary, 1168, new byte[1168]) }) != -1)
					{
						return 1;
					}
					return -1;
				}
				dataTable.Dispose();
			}
			return -1;
		}

		public static DataTable SELECT_TBL_XWWL_PublicWarehouse(string string_0)
		{
			string str = string.Format("select * from [TBL_XWWL_PublicWarehouse] where FLD_ID=@Userid", new object[0]);
			DataTable dataTable = DBA.smethod_9(str, new SqlParameter[] { SqlDBA.MakeInParam("@Userid", SqlDbType.VarChar, 30, string_0) });
			if (dataTable == null)
			{
				return null;
			}
			if (dataTable.Rows.Count != 0)
			{
				return dataTable;
			}
			Converter.smethod_25(new byte[4380]);
			Converter.smethod_25(new byte[50]);
			string str1 = string.Format("EXEC XWWL_CREATE_ID_BANK @Userid,@aaa,@ck,@ck1", new object[0]);
			DBA.smethod_4(str1, new SqlParameter[] { SqlDBA.MakeInParam("@Userid", SqlDbType.VarChar, 30, string_0), SqlDBA.MakeInParam("@aaa", SqlDbType.Int, 0, 0), SqlDBA.MakeInParam("@ck", SqlDbType.VarBinary, 4380, new byte[4380]), SqlDBA.MakeInParam("@ck1", SqlDbType.VarBinary, 50, new byte[50]) });
			string str2 = string.Format("select * from [TBL_XWWL_PublicWarehouse] where FLD_ID='{0}'", string_0);
			DataTable dataTable1 = DBA.smethod_9(str2, new SqlParameter[] { SqlDBA.MakeInParam("@Userid", SqlDbType.VarChar, 30, string_0) });
			if (dataTable1 == null)
			{
				return null;
			}
			if (dataTable1.Rows.Count == 0)
			{
				return null;
			}
			return dataTable1;
		}

		public static DataTable SELECT_TBL_XWWL_Warehouse(string string_0, string string_1)
		{
			string str = string.Format("select * from [TBL_XWWL_Warehouse] where FLD_ID=@Userid and FLD_NAME =@Username", new object[0]);
			DataTable dataTable = DBA.smethod_9(str, new SqlParameter[] { SqlDBA.MakeInParam("@Userid", SqlDbType.VarChar, 30, string_0), SqlDBA.MakeInParam("@Username", SqlDbType.VarChar, 30, string_1) });
			if (dataTable == null)
			{
				return null;
			}
			if (dataTable.Rows.Count != 0)
			{
				return dataTable;
			}
			string str1 = string.Format("EXEC XWWL_CREATE_USER_BANK @Userid,@Username,@aa,@zb", new object[0]);
			DBA.smethod_4(str1, new SqlParameter[] { SqlDBA.MakeInParam("@Userid", SqlDbType.VarChar, 30, string_0), SqlDBA.MakeInParam("@Username", SqlDbType.VarChar, 30, string_1), SqlDBA.MakeInParam("@aa", SqlDbType.Int, 0, 0), SqlDBA.MakeInParam("@zb", SqlDbType.VarBinary, 4380, new byte[4380]) });
			string str2 = string.Format("select * from [TBL_XWWL_Warehouse] where FLD_ID=@Userid and FLD_NAME =@Username", new object[0]);
			DataTable dataTable1 = DBA.smethod_9(str2, new SqlParameter[] { SqlDBA.MakeInParam("@Userid", SqlDbType.VarChar, 30, string_0), SqlDBA.MakeInParam("@Username", SqlDbType.VarChar, 30, string_1) });
			if (dataTable1 == null)
			{
				return null;
			}
			if (dataTable1.Rows.Count == 0)
			{
				return null;
			}
			return dataTable1;
		}

		public static DataTable SELECT_XWWL_SLRYTop(string string_0, string string_1, string string_2, int int_0)
		{
			string str = string.Format("SELECT * FROM TBL_XWWL_SLRYTop WHERE Nick_name = @name", new object[0]);
			DataTable dataTable = DBA.smethod_9(str, new SqlParameter[] { SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, string_0) });
			if (dataTable == null)
			{
				return null;
			}
			if (dataTable.Rows.Count == 0)
			{
				return null;
			}
			return dataTable;
		}

		public static int SetUserName(string string_0, string string_1, int int_0, byte[] byte_0, string string_2)
		{
			byte[] numArray = new byte[73];
			byte[] numArray1 = new byte[1095];
			byte[] numArray2 = new byte[2628];
			byte[] bytes = BitConverter.GetBytes(RxjhClass.GetDBItmeId());
			byte[] bytes1 = new byte[4];
			byte[] bytes2 = new byte[4];
			bytes2 = BitConverter.GetBytes(1);
			switch (int_0)
			{
				case 1:
				{
					bytes1 = BitConverter.GetBytes(100200002);
					break;
				}
				case 2:
				{
					bytes1 = BitConverter.GetBytes(200200002);
					break;
				}
				case 3:
				{
					bytes1 = BitConverter.GetBytes(300200002);
					break;
				}
				case 4:
				{
					bytes1 = BitConverter.GetBytes(400200002);
					break;
				}
				case 5:
				{
					bytes1 = BitConverter.GetBytes(500200002);
					break;
				}
				case 6:
				{
					bytes1 = BitConverter.GetBytes(700200002);
					break;
				}
				case 7:
				{
					bytes1 = BitConverter.GetBytes(800200001);
					break;
				}
				case 8:
				{
					bytes1 = BitConverter.GetBytes(100204001);
					break;
				}
				case 9:
				{
					bytes1 = BitConverter.GetBytes(200204001);
					break;
				}
				case 10:
				{
					bytes1 = BitConverter.GetBytes(900200001);
					break;
				}
			}
			Buffer.BlockCopy(bytes, 0, numArray, 0, 4);
			Buffer.BlockCopy(bytes1, 0, numArray, 8, 4);
			Buffer.BlockCopy(bytes2, 0, numArray, 12, 4);
			Buffer.BlockCopy(numArray, 0, numArray2, 0, 73);
			if (World.Login_tang_le_bao_co_hay_khong_mo_ra == 1)
			{
				byte[] numArray3 = new byte[73];
				byte[] bytes3 = BitConverter.GetBytes(RxjhClass.GetDBItmeId());
				byte[] bytes4 = BitConverter.GetBytes(World.Login_tang_le_bao_trang_phuc);
				Buffer.BlockCopy((Array)bytes3, 0, numArray3, 0, 4);
				Buffer.BlockCopy(bytes4, 0, numArray3, 8, 4);
				Buffer.BlockCopy(bytes2, 0, numArray3, 12, 4);
				Buffer.BlockCopy(numArray3, 0, numArray2, 73, 73);
			}
			int num = 0;
			int num1 = 0;
			while (num1 < 4)
			{
				string str = string.Format("Select FLD_INDEX FROM TBL_XWWL_Char Where FLD_ID=@FLD_ID and FLD_INDEX=@INDEX", new object[0]);
				DataTable dataTable = DBA.smethod_9(str, new SqlParameter[] { SqlDBA.MakeInParam("@INDEX", SqlDbType.Int, 0, num1), SqlDBA.MakeInParam("@FLD_ID", SqlDbType.VarChar, 30, string_0) });
				if (dataTable.Rows.Count != 0)
				{
					dataTable.Dispose();
					num1++;
				}
				else
				{
					num = num1;
					dataTable.Dispose();
					break;
				}
			}
			string str1 = string.Format("Select FLD_INDEX FROM TBL_XWWL_Char Where FLD_ID=@FLD_ID", new object[0]);
			DataTable dataTable1 = DBA.smethod_9(str1, new SqlParameter[] { SqlDBA.MakeInParam("@FLD_ID", SqlDbType.VarChar, 30, string_0) });
			if (dataTable1.Rows.Count >= 4)
			{
				dataTable1.Dispose();
				return -1;
			}
			dataTable1.Dispose();
			string str2 = string.Format("EXEC XWWL_INT_USER_DATA @FLD_ID,@name,@fqid,@rwid,@zy,@coue,@xrwhex,@xrwhex2", new object[0]);
			if (DBA.smethod_4(str2, new SqlParameter[] { SqlDBA.MakeInParam("@FLD_ID", SqlDbType.VarChar, 30, string_0), SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, string_1), SqlDBA.MakeInParam("@fqid", SqlDbType.VarChar, 20, string_2), SqlDBA.MakeInParam("@rwid", SqlDbType.Int, 0, num), SqlDBA.MakeInParam("@zy", SqlDbType.Int, 0, int_0), SqlDBA.MakeInParam("@coue", SqlDbType.VarBinary, 10, byte_0), SqlDBA.MakeInParam("@xrwhex", SqlDbType.VarBinary, (int)numArray1.Length, numArray1), SqlDBA.MakeInParam("@xrwhex2", SqlDbType.VarBinary, (int)numArray2.Length, numArray2) }) != -1)
			{
				return 1;
			}
			return -1;
		}

		public static void UPDATE_GUILD_TRANG_PHUC(int int_0, int int_1, int int_2)
		{
			DBA.ExeSqlCommand(string.Format("UPDATE TBL_XWWL_Guild SET Mon_trang_phuc_tu={1},Mon_trang_phuc_mau_sac={2} WHERE ID='{0}'", int_0, int_1, int_2));
		}

		public static void Update_GuildMember_Leve(int int_0, string string_0)
		{
			string str = string.Format("UPDATE TBL_XWWL_GuildMember SET Leve=@zw WHERE Name=@Username", new object[0]);
			DBA.smethod_4(str, new SqlParameter[] { SqlDBA.MakeInParam("@zw", SqlDbType.Int, 0, int_0), SqlDBA.MakeInParam("@Username", SqlDbType.VarChar, 30, string_0) });
		}

		public static void Update_Mon_Huy(int int_0, byte[] byte_0)
		{
			DBA.ExeSqlCommand(string.Format("UPDATE TBL_XWWL_Guild SET Mon_huy={1} WHERE ID='{0}'", int_0, Converter.smethod_25(byte_0)));
		}

		private static void ZYDNGuard()
		{
			RxjhClass.ItmeId = new ItmesIDClass();
		}
	}
}