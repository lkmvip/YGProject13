using ns3;
using ns7;
using System;
using System.Collections.Generic;

namespace ns13
{
	public class TBL_XWWL_DROP
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

		public int int_4;

		public int int_5;

		public int int_6;

		public int int_7;

		public int int_8;

		private int int_9;

		public List<Class95> list_0 = new List<Class95>();

		private string string_0;

		public int CO_HAY_KHONG_MO_RA_THONG_BAO
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

		public int FLD_LEVEL1
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

		public int FLD_LEVEL2
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
				return this.int_10;
			}
			set
			{
				this.int_10 = value;
			}
		}

		public int FLD_MAGIC1
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

		public int FLD_MAGIC2
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

		public int FLD_MAGIC3
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

		public int FLD_MAGIC4
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

		public TBL_XWWL_DROP()
		{
		}

		public static List<TBL_XWWL_DROP> smethod_0(int int_15)
		{
			List<TBL_XWWL_DROP> tBLXWWLDROPs = new List<TBL_XWWL_DROP>();
			List<TBL_XWWL_DROP> tBLXWWLDROPs1 = new List<TBL_XWWL_DROP>();
			Random random = new Random(World.smethod_15());
			int num = random.Next(0, 100);
			foreach (TBL_XWWL_DROP list9 in World.list_9)
			{
				if (list9.FLD_LEVEL1 > int_15 || list9.FLD_LEVEL2 < int_15 || list9.FLD_PP < num)
				{
					continue;
				}
				tBLXWWLDROPs.Add(list9);
			}
			if (tBLXWWLDROPs.Count == 0)
			{
				return null;
			}
			int num1 = 1;
			int num2 = 0;
			foreach (TBL_XWWL_DROP tBLXWWLDROP in tBLXWWLDROPs)
			{
				if (num2 < num1)
				{
					int num3 = random.Next(0, tBLXWWLDROPs.Count);
					tBLXWWLDROPs1.Add(tBLXWWLDROPs[num3]);
					num2++;
				}
				else
				{
					if (tBLXWWLDROPs1.Count == 0)
					{
						return null;
					}
					return tBLXWWLDROPs1;
				}
			}
			if (tBLXWWLDROPs1.Count == 0)
			{
				return null;
			}
			return tBLXWWLDROPs1;
		}

		public static List<TBL_XWWL_DROP> smethod_1(int int_15)
		{
			List<TBL_XWWL_DROP> tBLXWWLDROPs = new List<TBL_XWWL_DROP>();
			List<TBL_XWWL_DROP> tBLXWWLDROPs1 = new List<TBL_XWWL_DROP>();
			Random random = new Random(World.smethod_15());
			int num = random.Next(0, 8000);
			foreach (TBL_XWWL_DROP list11 in World.list_11)
			{
				if (list11.FLD_LEVEL1 > int_15 || list11.FLD_LEVEL2 < int_15 || list11.FLD_PP + World.The_rate_of_violence / 6 < num)
				{
					continue;
				}
				tBLXWWLDROPs.Add(list11);
			}
			if (tBLXWWLDROPs.Count == 0)
			{
				return null;
			}
			int num1 = random.Next(3, 10);
			int num2 = 0;
			foreach (TBL_XWWL_DROP tBLXWWLDROP in tBLXWWLDROPs)
			{
				if (num2 < num1)
				{
					int num3 = random.Next(0, tBLXWWLDROPs.Count);
					tBLXWWLDROPs1.Add(tBLXWWLDROPs[num3]);
					num2++;
				}
				else
				{
					if (tBLXWWLDROPs1.Count == 0)
					{
						return null;
					}
					return tBLXWWLDROPs1;
				}
			}
			if (tBLXWWLDROPs1.Count == 0)
			{
				return null;
			}
			return tBLXWWLDROPs1;
		}

		public static List<TBL_XWWL_DROP> smethod_2(int int_15, int int_16, int int_17)
		{
			List<TBL_XWWL_DROP> tBLXWWLDROPs = new List<TBL_XWWL_DROP>();
			List<TBL_XWWL_DROP> tBLXWWLDROPs1 = new List<TBL_XWWL_DROP>();
			Random random = new Random(World.smethod_15());
			int num = random.Next(0, 8000);
			foreach (TBL_XWWL_DROP list10 in World.list_10)
			{
				if (list10.FLD_LEVEL1 > int_15 || list10.FLD_LEVEL2 < int_15 || list10.FLD_PP < num)
				{
					continue;
				}
				tBLXWWLDROPs.Add(list10);
			}
			if (tBLXWWLDROPs.Count == 0)
			{
				return null;
			}
			int num1 = random.Next(int_16, int_17);
			int num2 = 0;
			foreach (TBL_XWWL_DROP tBLXWWLDROP in tBLXWWLDROPs)
			{
				if (num2 < num1)
				{
					int num3 = random.Next(0, tBLXWWLDROPs.Count);
					tBLXWWLDROPs1.Add(tBLXWWLDROPs[num3]);
					num2++;
				}
				else
				{
					if (tBLXWWLDROPs1.Count == 0)
					{
						return null;
					}
					return tBLXWWLDROPs1;
				}
			}
			if (tBLXWWLDROPs1.Count == 0)
			{
				return null;
			}
			return tBLXWWLDROPs1;
		}

		public static TBL_XWWL_DROP smethod_3(int int_15)
		{
			List<TBL_XWWL_DROP> tBLXWWLDROPs = new List<TBL_XWWL_DROP>();
			Random random = new Random(World.smethod_15());
			int num = random.Next(0, 8000);
			foreach (TBL_XWWL_DROP list8 in World.list_8)
			{
				if (list8.FLD_LEVEL1 > int_15 || list8.FLD_LEVEL2 < int_15 || list8.FLD_PP + 10 < num)
				{
					continue;
				}
				tBLXWWLDROPs.Add(list8);
			}
			if (tBLXWWLDROPs.Count == 0)
			{
				return null;
			}
			return tBLXWWLDROPs[random.Next(0, tBLXWWLDROPs.Count)];
		}

		public static TBL_XWWL_DROP smethod_4(int int_15)
		{
			List<TBL_XWWL_DROP> tBLXWWLDROPs = new List<TBL_XWWL_DROP>();
			Random random = new Random(World.smethod_15());
			int num = random.Next(0, 8000);
			foreach (TBL_XWWL_DROP list8 in World.list_8)
			{
				if (list8.FLD_LEVEL1 > int_15 || list8.FLD_LEVEL2 < int_15 || list8.FLD_PP + 110 < num)
				{
					continue;
				}
				tBLXWWLDROPs.Add(list8);
			}
			if (tBLXWWLDROPs.Count == 0)
			{
				return null;
			}
			return tBLXWWLDROPs[random.Next(0, tBLXWWLDROPs.Count)];
		}
	}
}