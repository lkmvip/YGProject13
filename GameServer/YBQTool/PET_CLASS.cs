using ns1;
using ns11;
using ns13;
using ns2;
using ns3;
using ns7;
using ns9;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ns10
{
	public class PET_CLASS : IDisposable
	{
		public Players class15_0;

		private NetState class16_0;

		public VAT_PHAM_LOAI[] class23_0;

		public VAT_PHAM_LOAI[] class23_1;

		public TBL_XWWL_KONGFU[] class79_0;

		private float float_0;

		private float float_1;

		private float float_2;

		private int int_0;

		private int int_1;

		private int int_10;

		private int int_11;

		private int int_12;

		private int int_13;

		private int int_14;

		private int int_15;

		private int int_16;

		public int int_17;

		private int int_2;

		private int int_3;

		private int int_4;

		private int int_5;

		private int int_6;

		private int int_7;

		private int int_8;

		private int int_9;

		private long long_0;

		private long long_1;

		private long long_2;

		private long long_3;

		private string string_0;

		private string string_1;

		public int Bs
		{
			get
			{
				return this.int_1;
			}
			set
			{
				this.int_1 = value;
			}
		}

		public int CUOI_THU
		{
			get
			{
				return this.int_16;
			}
			set
			{
				this.int_16 = value;
			}
		}

		public int FLD_CONG_KICH
		{
			get
			{
				return this.int_12;
			}
			set
			{
				this.int_12 = value;
			}
		}

		public long FLD_EXP
		{
			get
			{
				return this.long_1;
			}
			set
			{
				this.long_1 = value;
			}
		}

		public long FLD_EXP_MAX
		{
			get
			{
				return this.long_3;
			}
			set
			{
				this.long_3 = value;
			}
		}

		public int FLD_HP
		{
			get
			{
				return this.int_6;
			}
			set
			{
				this.int_6 = value;
			}
		}

		public int FLD_HP_MAX
		{
			get
			{
				return this.int_7;
			}
			set
			{
				this.int_7 = value;
			}
		}

		public int FLD_JOB
		{
			get
			{
				return this.int_4;
			}
			set
			{
				this.int_4 = value;
			}
		}

		public int FLD_JOB_LEVEL
		{
			get
			{
				return this.int_5;
			}
			set
			{
				this.int_5 = value;
			}
		}

		public int FLD_LEVEL
		{
			get
			{
				return this.int_3;
			}
			set
			{
				this.int_3 = value;
			}
		}

		public int FLD_MANG_NANG
		{
			get
			{
				return this.int_10;
			}
			set
			{
				this.int_10 = value;
			}
		}

		public int FLD_MANG_NANG_MAX
		{
			get
			{
				return this.int_11;
			}
			set
			{
				this.int_11 = value;
			}
		}

		public int FLD_MP
		{
			get
			{
				return this.int_8;
			}
			set
			{
				this.int_8 = value;
			}
		}

		public int FLD_MP_MAX
		{
			get
			{
				return this.int_9;
			}
			set
			{
				this.int_9 = value;
			}
		}

		public int FLD_NE_TRANH
		{
			get
			{
				return this.int_15;
			}
			set
			{
				this.int_15 = value;
			}
		}

		public int FLD_PHONG_NGU
		{
			get
			{
				return this.int_13;
			}
			set
			{
				this.int_13 = value;
			}
		}

		public int FLD_TRUNG_MUC_TIEU
		{
			get
			{
				return this.int_14;
			}
			set
			{
				this.int_14 = value;
			}
		}

		public int FLD_ZCD
		{
			get
			{
				return this.int_2;
			}
			set
			{
				this.int_2 = value;
			}
		}

		public long Id
		{
			get
			{
				return this.long_0;
			}
			set
			{
				this.long_0 = value;
			}
		}

		public long LON_NHAT_KINH_NGHIEM
		{
			get
			{
				return this.long_2;
			}
			set
			{
				this.long_2 = value;
			}
		}

		public string Name
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

		public int NHAN_VAT_TOA_DO_MAP
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

		public float NHAN_VAT_TOA_DO_X
		{
			get
			{
				return this.float_0;
			}
			set
			{
				this.float_0 = value;
			}
		}

		public float NHAN_VAT_TOA_DO_Y
		{
			get
			{
				return this.float_1;
			}
			set
			{
				this.float_1 = value;
			}
		}

		public float NHAN_VAT_TOA_DO_Z
		{
			get
			{
				return this.float_2;
			}
			set
			{
				this.float_2 = value;
			}
		}

		public string ZrName
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

		public PET_CLASS(long id, NetState clien, DataTable table2)
		{
			DateTime dateTime;
			this.class16_0 = clien;
			this.long_0 = id;
			this.ZrName = table2.Rows[0]["ZrName"].ToString();
			this.Name = table2.Rows[0]["Name"].ToString();
			this.FLD_ZCD = (int)table2.Rows[0]["FLD_ZCD"];
			this.FLD_EXP = long.Parse(table2.Rows[0]["FLD_EXP"].ToString());
			this.FLD_LEVEL = (int)table2.Rows[0]["FLD_LEVEL"];
			this.FLD_JOB = (int)table2.Rows[0]["FLD_JOB"];
			this.FLD_JOB_LEVEL = (int)table2.Rows[0]["FLD_JOB_LEVEL"];
			this.FLD_HP = (int)table2.Rows[0]["FLD_HP"];
			this.FLD_HP_MAX = (int)table2.Rows[0]["FLD_HP"];
			this.FLD_MP = (int)table2.Rows[0]["FLD_MP"];
			this.FLD_MP_MAX = (int)table2.Rows[0]["FLD_MP"];
			this.Bs = (int)table2.Rows[0]["FLD_BS"];
			this.FLD_EXP_MAX = (long)100000;
			this.FLD_CONG_KICH = 10;
			this.FLD_PHONG_NGU = 10;
			this.FLD_TRUNG_MUC_TIEU = 10;
			this.FLD_NE_TRANH = 10;
			this.FLD_MANG_NANG = 0;
			this.FLD_MANG_NANG_MAX = 100;
			this.class23_0 = new VAT_PHAM_LOAI[16];
			this.class23_1 = new VAT_PHAM_LOAI[5];
			this.class79_0 = new TBL_XWWL_KONGFU[33];
			byte[] item = (byte[])table2.Rows[0]["FLD_ITEM"];
			for (int i = 0; i < 16; i++)
			{
				byte[] numArray = new byte[73];
				try
				{
					Buffer.BlockCopy(item, i * 73, numArray, 0, 73);
				}
				catch (Exception exception)
				{
					Console.WriteLine(exception);
				}
				this.class23_0[i] = new VAT_PHAM_LOAI(numArray, i);
				this.int_10 = this.int_10 + this.class23_0[i].VAT_PHAM_TONG_TRONG_LUONG;
				byte[] numArray1 = new byte[4];
				Buffer.BlockCopy(this.class23_0[i].Item_byte, 56, numArray1, 0, 4);
				int num = BitConverter.ToInt32(numArray1, 0);
				if (num > 0)
				{
					dateTime = new DateTime(1970, 1, 1, 8, 0, 0);
					if (DateTime.Now.Subtract(dateTime.AddSeconds((double)num)).TotalSeconds >= 0)
					{
						clien.Player.GameMessage(string.Concat("Backpack expired items[", this.class23_0[i].method_13(), "],The system has been deleted!"), 9, "System");
						this.class23_0[i].Item_byte = new byte[73];
					}
				}
			}
			byte[] item1 = (byte[])table2.Rows[0]["FLD_WEARITEM"];
			for (int j = 0; j < 5; j++)
			{
				byte[] numArray2 = new byte[73];
				try
				{
					Buffer.BlockCopy(item1, j * 73, numArray2, 0, 73);
				}
				catch (Exception exception1)
				{
					Console.WriteLine(exception1);
				}
				this.class23_1[j] = new VAT_PHAM_LOAI(numArray2, j);
				this.int_10 = this.int_10 + this.class23_1[j].VAT_PHAM_TONG_TRONG_LUONG;
				byte[] numArray3 = new byte[4];
				Buffer.BlockCopy(this.class23_1[j].Item_byte, 56, numArray3, 0, 4);
				int num1 = BitConverter.ToInt32(numArray3, 0);
				if (num1 > 0)
				{
					dateTime = new DateTime(1970, 1, 1, 8, 0, 0);
					if (DateTime.Now.Subtract(dateTime.AddSeconds((double)num1)).TotalSeconds >= 0)
					{
						clien.Player.GameMessage(string.Concat("Backpack expired items[", this.class23_1[j].method_13(), "],The system has been deleted!"), 9, "System");
						this.class23_1[j].Item_byte = new byte[73];
					}
				}
			}
			byte[] item2 = (byte[])table2.Rows[0]["FLD_KONGFU"];
			for (int k = 0; k < 32; k++)
			{
				byte[] numArray4 = new byte[4];
				try
				{
					Buffer.BlockCopy(item2, k * 4, numArray4, 0, 4);
				}
				catch (Exception exception2)
				{
					Console.WriteLine(exception2);
				}
				this.class79_0[k] = new TBL_XWWL_KONGFU(BitConverter.ToInt32(numArray4, 0));
			}
			this.method_0();
		}

		public void CallPet(int int_31)
		{
			this.int_1 = int_31;
		}

		public void Dispose()
		{
			this.class15_0 = null;
			this.class16_0 = null;
		}

		~PET_CLASS()
		{
		}

		public void method_0()
		{
			if (this.FLD_LEVEL > 99)
			{
				this.FLD_LEVEL = 99;
			}
			this.LON_NHAT_KINH_NGHIEM = (long)World.lever[this.FLD_LEVEL];
			int fLDLEVEL = this.FLD_LEVEL;
			while (this.FLD_EXP >= this.LON_NHAT_KINH_NGHIEM && this.FLD_LEVEL < 99)
			{
				if (this.class16_0 == null)
				{
					return;
				}
				if (!this.class16_0.Running)
				{
					return;
				}
				this.FLD_LEVEL = this.FLD_LEVEL + 1;
				this.LON_NHAT_KINH_NGHIEM = (long)World.lever[this.FLD_LEVEL];
			}
			if (this.FLD_LEVEL - fLDLEVEL > 0)
			{
				this.class16_0.Player.Method_Linh_Thu_Level();
			}
			this.FLD_MANG_NANG_MAX = 500 + 20 * this.FLD_LEVEL;
			switch (this.int_4)
			{
				case 1:
				{
					this.int_7 = 133 + this.FLD_LEVEL * 12;
					this.int_9 = 114 + this.FLD_LEVEL * 2;
					this.FLD_TRUNG_MUC_TIEU = 8 + this.FLD_LEVEL;
					this.FLD_NE_TRANH = 8 + this.FLD_LEVEL;
					this.FLD_CONG_KICH = 9;
					this.FLD_PHONG_NGU = 16;
					for (int i = 2; i <= this.FLD_LEVEL; i++)
					{
						if (i % 2 != 0)
						{
							this.FLD_CONG_KICH = this.FLD_CONG_KICH + 1;
							this.FLD_PHONG_NGU = this.FLD_PHONG_NGU + 1;
						}
						else
						{
							this.FLD_CONG_KICH = this.FLD_CONG_KICH + 2;
							this.FLD_PHONG_NGU = this.FLD_PHONG_NGU + 2;
						}
					}
					break;
				}
				case 2:
				{
					this.int_7 = 133 + this.FLD_LEVEL * 12;
					this.int_9 = 114 + this.FLD_LEVEL * 2;
					this.FLD_TRUNG_MUC_TIEU = 8 + this.FLD_LEVEL;
					this.FLD_NE_TRANH = 8 + this.FLD_LEVEL;
					this.FLD_CONG_KICH = 9;
					this.FLD_PHONG_NGU = 16;
					for (int j = 2; j <= this.FLD_LEVEL; j++)
					{
						if (j % 2 != 0)
						{
							this.FLD_CONG_KICH = this.FLD_CONG_KICH + 1;
							this.FLD_PHONG_NGU = this.FLD_PHONG_NGU + 1;
						}
						else
						{
							this.FLD_CONG_KICH = this.FLD_CONG_KICH + 2;
							this.FLD_PHONG_NGU = this.FLD_PHONG_NGU + 2;
						}
					}
					break;
				}
				case 3:
				{
					this.int_7 = 133 + this.FLD_LEVEL * 12;
					this.int_9 = 114 + this.FLD_LEVEL * 2;
					this.FLD_TRUNG_MUC_TIEU = 8 + this.FLD_LEVEL;
					this.FLD_NE_TRANH = 8 + this.FLD_LEVEL;
					this.FLD_CONG_KICH = 9;
					this.FLD_PHONG_NGU = 16;
					for (int k = 2; k <= this.FLD_LEVEL; k++)
					{
						if (k % 2 != 0)
						{
							this.FLD_CONG_KICH = this.FLD_CONG_KICH + 1;
							this.FLD_PHONG_NGU = this.FLD_PHONG_NGU + 1;
						}
						else
						{
							this.FLD_CONG_KICH = this.FLD_CONG_KICH + 2;
							this.FLD_PHONG_NGU = this.FLD_PHONG_NGU + 2;
						}
					}
					break;
				}
				case 4:
				{
					this.int_7 = 133 + this.FLD_LEVEL * 12;
					this.int_9 = 114 + this.FLD_LEVEL * 2;
					this.FLD_TRUNG_MUC_TIEU = 8 + this.FLD_LEVEL;
					this.FLD_NE_TRANH = 8 + this.FLD_LEVEL;
					this.FLD_CONG_KICH = 9;
					this.FLD_PHONG_NGU = 16;
					for (int l = 2; l <= this.FLD_LEVEL; l++)
					{
						if (l % 2 != 0)
						{
							this.FLD_CONG_KICH = this.FLD_CONG_KICH + 1;
							this.FLD_PHONG_NGU = this.FLD_PHONG_NGU + 1;
						}
						else
						{
							this.FLD_CONG_KICH = this.FLD_CONG_KICH + 2;
							this.FLD_PHONG_NGU = this.FLD_PHONG_NGU + 2;
						}
					}
					break;
				}
				case 5:
				{
					this.int_7 = 133 + this.FLD_LEVEL * 12;
					this.int_9 = 114 + this.FLD_LEVEL * 2;
					this.FLD_TRUNG_MUC_TIEU = 8 + this.FLD_LEVEL;
					this.FLD_NE_TRANH = 8 + this.FLD_LEVEL;
					this.FLD_CONG_KICH = 9;
					this.FLD_PHONG_NGU = 16;
					for (int m = 2; m <= this.FLD_LEVEL; m++)
					{
						if (m % 2 != 0)
						{
							this.FLD_CONG_KICH = this.FLD_CONG_KICH + 1;
							this.FLD_PHONG_NGU = this.FLD_PHONG_NGU + 1;
						}
						else
						{
							this.FLD_CONG_KICH = this.FLD_CONG_KICH + 2;
							this.FLD_PHONG_NGU = this.FLD_PHONG_NGU + 2;
						}
					}
					break;
				}
			}
			switch (this.int_5)
			{
				case 1:
				{
					this.FLD_CONG_KICH = this.FLD_CONG_KICH + 5;
					this.FLD_PHONG_NGU = this.FLD_PHONG_NGU + 5;
					this.int_7 = this.int_7 + 85;
					this.int_9 = this.int_9 + 50;
					break;
				}
				case 2:
				{
					this.FLD_CONG_KICH = this.FLD_CONG_KICH + 15;
					this.FLD_PHONG_NGU = this.FLD_PHONG_NGU + 15;
					this.int_7 = this.int_7 + 200;
					this.int_9 = this.int_9 + 150;
					break;
				}
				case 3:
				{
					this.FLD_CONG_KICH = this.FLD_CONG_KICH + 35;
					this.FLD_PHONG_NGU = this.FLD_PHONG_NGU + 35;
					this.int_7 = this.int_7 + 400;
					this.int_9 = this.int_9 + 350;
					break;
				}
			}
			this.FLD_HP = this.int_7;
			this.FLD_MP = this.int_9;
		}

		public void method_1()
		{
			SqlParameter[] sqlParameterArray = new SqlParameter[] { SqlDBA.MakeInParam("@id", SqlDbType.VarChar, 20, this.long_0.ToString()), SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 20, this.Name), SqlDBA.MakeInParam("@level", SqlDbType.Int, 0, this.FLD_LEVEL), SqlDBA.MakeInParam("@zcd", SqlDbType.Int, 10, this.FLD_ZCD), SqlDBA.MakeInParam("@job", SqlDbType.Int, 0, this.FLD_JOB), SqlDBA.MakeInParam("@job_level", SqlDbType.Int, 0, this.FLD_JOB_LEVEL), null, null, null, null, null, null, null };
			long fLDEXP = this.FLD_EXP;
			sqlParameterArray[6] = SqlDBA.MakeInParam("@exp", SqlDbType.VarChar, 50, fLDEXP.ToString());
			sqlParameterArray[7] = SqlDBA.MakeInParam("@hp", SqlDbType.Int, 0, this.FLD_HP);
			sqlParameterArray[8] = SqlDBA.MakeInParam("@mp", SqlDbType.Int, 0, this.FLD_MP);
			sqlParameterArray[9] = SqlDBA.MakeInParam("@strWearitem", SqlDbType.VarBinary, 365, this.method_2());
			sqlParameterArray[10] = SqlDBA.MakeInParam("@strItem", SqlDbType.VarBinary, 1168, this.method_3());
			sqlParameterArray[11] = SqlDBA.MakeInParam("@strKongfu", SqlDbType.VarBinary, 128, this.method_4());
			sqlParameterArray[12] = SqlDBA.MakeInParam("@bs", SqlDbType.Int, 0, this.Bs);
			SqlParameter[] sqlParameterArray1 = sqlParameterArray;
			DbPool_Class dbPoolClass = new DbPool_Class()
			{
				Conn = DBA.smethod_3(null),
				Prams = sqlParameterArray1,
				Sql = "XWWL_UPDATE_Cw_DATA"
			};
			World.queue_1.Enqueue(dbPoolClass);
		}

		public byte[] method_2()
		{
			byte[] numArray = new byte[365];
			for (int i = 0; i < 5; i++)
			{
				try
				{
					Buffer.BlockCopy(this.class23_1[i].Item_byte, 0, numArray, i * 73, 73);
				}
				catch
				{
					Buffer.BlockCopy(new byte[73], 0, numArray, i * 73, 73);
				}
			}
			return numArray;
		}

		public byte[] method_3()
		{
			byte[] numArray;
			byte[] numArray1 = new byte[1168];
			try
			{
				for (int i = 0; i < 16; i++)
				{
					try
					{
						Buffer.BlockCopy(this.class23_0[i].Item_byte, 0, numArray1, i * 73, 73);
					}
					catch
					{
						Buffer.BlockCopy(new byte[73], 0, numArray1, i * 73, 73);
					}
				}
				numArray = numArray1;
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				Form1.WriteLine(1, string.Concat("Saved pet equipment error", exception.Message));
				return numArray1;
			}
			return numArray;
		}

		public byte[] method_4()
		{
			byte[] voCongIDByte;
			byte[] numArray = new byte[128];
			for (int i = 0; i < 32; i++)
			{
				try
				{
					voCongIDByte = this.class79_0[i].Vo_CongID_byte;
				}
				catch
				{
					voCongIDByte = new byte[4];
				}
				Buffer.BlockCopy(voCongIDByte, 0, numArray, i * 4, 4);
			}
			return numArray;
		}
	}
}