using System;
using System.Collections;

namespace ns12
{
	public class ConfigClass
	{
		private int int_0;

		private int int_1;

		private int int_10;

		private int int_2;

		private int int_3;

		private int int_4;

		private int int_5;

		private int int_6;

		private int int_7;

		private int int_8;

		private int int_9;

		public int Pet_Exp
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

		public int Vo_Huan_mo_ra
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

		public int 告白开关
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

		public int 交易
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

		public int 头发开关
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

		public int 查装备
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

		public int 蔬菜武器开关
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

		public int 搜索开关
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

		public int 原著衣服
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

		public int 传音
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

		public int 组队
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

		public ConfigClass()
		{
		}

		public static int smethod_0(ConfigClass class73_0)
		{
			int num = 0;
			if (class73_0.头发开关 == 1)
			{
				ConfigClass.smethod_1(ref num, 7, true);
			}
			if (class73_0.原著衣服 == 1)
			{
				ConfigClass.smethod_1(ref num, 4, true);
				return num;
			}
			ConfigClass.smethod_1(ref num, 6, true);
			return num;
		}

		public static void smethod_1(ref int int_11, int int_12, bool bool_0)
		{
			BitArray bitArrays = new BitArray(new int[] { int_11 });
			bitArrays.Set(int_12, bool_0);
			int_11 = 0;
			for (int i = 0; i < bitArrays.Length; i++)
			{
				if (bitArrays.Get(i))
				{
					int_11 = int_11 | 1 << (i & 31);
				}
			}
		}
	}
}