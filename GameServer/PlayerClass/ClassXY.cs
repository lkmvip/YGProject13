using System;

namespace ns2
{
	public class ClassXY
	{
		private int int_0;

		private int int_1;

		public int x
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

		public int y
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

		public ClassXY(int x, int y)
		{
			this.x = x;
			this.y = y;
		}
	}
}