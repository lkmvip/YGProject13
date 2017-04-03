using ns3;
using System;
using System.Collections.Generic;

namespace ns8
{
	internal class TBL_XWWL_MONSTER
	{
		private double double_0;

		private double double_1;

		private int int_0;

		private int int_1;

		private int int_2;

		private int int_3;

		private int int_4;

		private int int_5;

		private string string_0;

		public double FLD_AT
		{
			get
			{
				return this.double_0;
			}
			set
			{
				this.double_0 = value;
			}
		}

		public int FLD_AUTO
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

		public int FLD_BOSS
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

		public double FLD_DF
		{
			get
			{
				return this.double_1;
			}
			set
			{
				this.double_1 = value;
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

		public int Level
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

		public string Name
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

		public int Rxjh_Exp
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

		public int Rxjh_HP
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

		public TBL_XWWL_MONSTER()
		{
		}

		public static string smethod_0(int int_6)
		{
			TBL_XWWL_MONSTER tBLXWWLMONSTER;
			if (!World.dictionary_13.TryGetValue(int_6, out tBLXWWLMONSTER))
			{
				return "";
			}
			return tBLXWWLMONSTER.Name;
		}
	}
}