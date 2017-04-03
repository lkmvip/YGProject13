using ns3;
using System;
using System.Collections.Generic;

namespace ns0
{
	internal class TBL_XWWL_SELL
	{
		private int int_0;

		private int int_1;

		private int int_2;

		private int int_3;

		private int int_4;

		private int int_5;

		private int int_6;

		private int int_7;

		private int int_8;

		private int int_9;

		public int CAN_VO_HUAN
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

		public int FLD_CJL
		{
			get
			{
				return this.int_8;
			}
			set
			{
				if (this.int_8 <= 0)
				{
					this.int_8 = 1000;
				}
			}
		}

		public int FLD_INDEX
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

		public int FLD_MAGIC0
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

		public int FLD_MAGIC1
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

		public int FLD_MAGIC2
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

		public int FLD_MAGIC3
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

		public int FLD_MAGIC4
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

		public int FLD_MAGICZh
		{
			get
			{
				int num = 0;
				if (this.int_4 != 0)
				{
					num++;
				}
				if (this.int_5 != 0)
				{
					num++;
				}
				if (this.int_6 != 0)
				{
					num++;
				}
				if (this.int_7 != 0)
				{
					num++;
				}
				return num;
			}
		}

		public int FLD_NID
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

		public TBL_XWWL_SELL()
		{
		}

		public static TBL_XWWL_SELL Getwp(int int_10)
		{
			TBL_XWWL_SELL tBLXWWLSELL;
			List<TBL_XWWL_SELL>.Enumerator enumerator = World.list_4.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					TBL_XWWL_SELL current = enumerator.Current;
					if (current.FLD_PID != int_10)
					{
						continue;
					}
					tBLXWWLSELL = current;
					return tBLXWWLSELL;
				}
				return null;
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			return tBLXWWLSELL;
		}

		public static List<TBL_XWWL_SELL> smethod_0(int int_10)
		{
			List<TBL_XWWL_SELL> tBLXWWLSELLs = new List<TBL_XWWL_SELL>();
			foreach (TBL_XWWL_SELL list4 in World.list_4)
			{
				if (list4.FLD_NID != int_10)
				{
					continue;
				}
				tBLXWWLSELLs.Add(list4);
			}
			return tBLXWWLSELLs;
		}

		public static int smethod_2(int int_10)
		{
			int num = 0;
			foreach (TBL_XWWL_SELL list4 in World.list_4)
			{
				if (list4.FLD_NID != int_10)
				{
					continue;
				}
				num++;
			}
			return num;
		}
	}
}