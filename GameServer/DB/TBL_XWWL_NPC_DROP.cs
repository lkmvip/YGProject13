using ns3;
using System;
using System.Collections.Generic;

namespace ns2
{
	public class TBL_XWWL_NPC_DROP
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

		private string string_0;

		public int FLD_ITME_PID
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

		public int FLD_LEVEL1
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

		public int FLD_LEVEL2
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

		public int FLD_NPC_PID
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

		public TBL_XWWL_NPC_DROP()
		{
		}

		public static List<TBL_XWWL_NPC_DROP> smethod_0(int int_9, int int_10)
		{
			List<TBL_XWWL_NPC_DROP> tBLXWWLNPCDROPs = new List<TBL_XWWL_NPC_DROP>();
			Random random = new Random();
			foreach (TBL_XWWL_NPC_DROP list7 in World.list_7)
			{
				if (list7.FLD_NPC_PID != int_9 || random.Next(0, list7.FLD_LEVEL2 + 1) > list7.FLD_LEVEL1)
				{
					continue;
				}
				tBLXWWLNPCDROPs.Add(list7);
			}
			if (tBLXWWLNPCDROPs.Count == 0)
			{
				return null;
			}
			return tBLXWWLNPCDROPs;
		}
	}
}