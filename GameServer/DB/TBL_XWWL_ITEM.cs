using ns3;
using System;
using System.Collections.Generic;

namespace ns6
{
	public class TBL_XWWL_ITEM
	{
		private int int_0;

		private int int_1;

		private int int_10;

		private int int_11;

		private int int_12;

		private int int_13;

		private int int_14;

		private int int_15;

		private int int_16;

		private int int_17;

		private int int_18;

		private int int_19;

		private int int_2;

		private int int_3;

		private int int_4;

		private int int_5;

		private int int_6;

		private int int_7;

		private int int_8;

		private int int_9;

		private int GIA_MUA_VAT_PHAM;

		private int SO_ID;

		private long long_0;

		private long long_1;

		private long long_2;

		private string string_0;

		private string string_maso2;

		public long FLD_AT
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

		public long FLD_AT_Max
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

		public int FLD_CJL
		{
			get
			{
				return this.int_1;
			}
			set
			{
				if (this.int_1 <= 0)
				{
					this.int_1 = 1000;
				}
			}
		}

		public long FLD_DF
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

		public int FLD_JOB_LEVEL
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

		public int FLD_LEVEL
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

		public int FLD_MAGIC0
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

		public int FLD_MAGIC1
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

		public int FLD_MAGIC2
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

		public int FLD_MAGIC3
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

		public int FLD_MAGIC4
		{
			get
			{
				return this.int_17;
			}
			set
			{
				this.int_17 = value;
			}
		}

		public int FLD_MONEY
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

		public int FLD_PID
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

		public int FLD_QUESTITEM
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

		public int FLD_RESIDE1
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

		public int FLD_RESIDE2
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

		public int FLD_SEX
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

		public int FLD_SIDE
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

		public int FLD_TYPE
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

		public int FLD_WEIGHT
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

		public int FLD_XW
		{
			get
			{
				return this.int_18;
			}
			set
			{
				this.int_18 = value;
			}
		}

		public int FLD_XWJD
		{
			get
			{
				return this.int_19;
			}
			set
			{
				this.int_19 = value;
			}
		}

		public int FLD_ZX
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

		public int GIA_MUA
		{
			get
			{
				return this.GIA_MUA_VAT_PHAM;
			}
			set
			{
				this.GIA_MUA_VAT_PHAM = value;
			}
		}

		public string ItmeNAME
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

		public string MA_SO_MUA_ITME
		{
			get
			{
				return this.string_maso2;
			}
			set
			{
				this.string_maso2 = value;
			}
		}

		public int SO_VAT_PHAM
		{
			get
			{
				return this.SO_ID;
			}
			set
			{
				this.SO_ID = value;
			}
		}

		public TBL_XWWL_ITEM()
		{
		}

		public static TBL_XWWL_ITEM BUY_COMMAND(string string_maso1)
		{
			TBL_XWWL_ITEM tBLXWWLITEM;
			Dictionary<int, TBL_XWWL_ITEM>.ValueCollection.Enumerator enumerator = World.Itme.Values.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					TBL_XWWL_ITEM current = enumerator.Current;
					if (current.MA_SO_MUA_ITME != string_maso1)
					{
						continue;
					}
					tBLXWWLITEM = current;
					return tBLXWWLITEM;
				}
				return null;
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			return tBLXWWLITEM;
		}

		public static TBL_XWWL_ITEM BUY_COMMAND2(int intmaso)
		{
			TBL_XWWL_ITEM tBLXWWLITEM;
			Dictionary<int, TBL_XWWL_ITEM>.ValueCollection.Enumerator enumerator = World.Itme.Values.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					TBL_XWWL_ITEM current = enumerator.Current;
					if (current.SO_VAT_PHAM != intmaso)
					{
						continue;
					}
					tBLXWWLITEM = current;
					return tBLXWWLITEM;
				}
				return null;
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			return tBLXWWLITEM;
		}

		public static TBL_XWWL_ITEM smethod_0(string string_1)
		{
			TBL_XWWL_ITEM tBLXWWLITEM;
			Dictionary<int, TBL_XWWL_ITEM>.ValueCollection.Enumerator enumerator = World.Itme.Values.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					TBL_XWWL_ITEM current = enumerator.Current;
					if (current.ItmeNAME != string_1)
					{
						continue;
					}
					tBLXWWLITEM = current;
					return tBLXWWLITEM;
				}
				return null;
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			return tBLXWWLITEM;
		}

		public static string smethod_1(int int_20)
		{
			TBL_XWWL_ITEM tBLXWWLITEM;
			if (!World.Itme.TryGetValue(int_20, out tBLXWWLITEM))
			{
				return "";
			}
			return tBLXWWLITEM.ItmeNAME;
		}

		public static TBL_XWWL_ITEM smethod_2(int int_20, int int_21, int int_22, int int_23, int int_24)
		{
			TBL_XWWL_ITEM tBLXWWLITEM;
			Dictionary<int, TBL_XWWL_ITEM>.ValueCollection.Enumerator enumerator = World.Itme.Values.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					TBL_XWWL_ITEM current = enumerator.Current;
					if (current.FLD_ZX != int_20 || current.FLD_LEVEL != int_21 || current.FLD_RESIDE1 != int_22 || current.FLD_SEX != int_23 || current.FLD_RESIDE2 != int_24)
					{
						continue;
					}
					tBLXWWLITEM = current;
					return tBLXWWLITEM;
				}
				return null;
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			return tBLXWWLITEM;
		}

		public static TBL_XWWL_ITEM smethod_3(int int_20)
		{
			TBL_XWWL_ITEM tBLXWWLITEM;
			if (World.Itme.TryGetValue(int_20, out tBLXWWLITEM))
			{
				return tBLXWWLITEM;
			}
			return null;
		}
	}
}