using ns3;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ns0
{
	internal class TBL_XWWL_OPEN
	{
		private int int_0;

		private int int_1;

		private int int_10;

		private int int_11;

		private int int_12;

		private int int_13;

		private int int_14;

		private int int_2;

		private int int_3;

		private int int_4;

		private int int_5;

		private int int_6;

		private int int_7;

		private int int_8;

		private int int_9;

		private string string_0;

		private string string_1;

		public int CO_HAY_KHONG_MO_RA_THONG_BAO
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

		public int FLD_CO_HAY_KHONG_TROI_CHAT
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

		public int FLD_MAGIC0
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

		public int FLD_MAGIC1
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

		public int FLD_MAGIC2
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

		public int FLD_MAGIC3
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

		public int FLD_MAGIC4
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

		public string FLD_NAME
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

		public string FLD_NAMEX
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

		public int FLD_NUMBER
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

		public int FLD_PID
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

		public int FLD_PIDX
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

		public int FLD_PP
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

		public int FLD_SO_CAP_PHU_HON
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

		public int FLD_TIEN_HOA
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

		public int FLD_TRUNG_CAP_PHU_HON
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

		public int SU_DUNG_THANG_THIEN
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

		public TBL_XWWL_OPEN()
		{
		}

		public static TBL_XWWL_OPEN GetOpen(int int_15)
		{
			ArrayList arrayLists = new ArrayList();
			Random random = new Random(World.smethod_15());
			int num = random.Next(1, 500);
			foreach (TBL_XWWL_OPEN list12 in World.list_12)
			{
				if (list12.FLD_PID != int_15 || list12.FLD_PP < num)
				{
					continue;
				}
				arrayLists.Add(list12);
			}
			if (arrayLists.Count == 0)
			{
				return null;
			}
			int num1 = random.Next(0, arrayLists.Count);
			return (TBL_XWWL_OPEN)arrayLists[num1];
		}
	}
}