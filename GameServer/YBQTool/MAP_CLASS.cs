using System;

namespace ns1
{
	public class MAP_CLASS
	{
		private int int_0;

		private int int_1;

		private int int_2;

		public int CoordX
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

		public int CoordY
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

		public int MapID
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

		public MAP_CLASS()
		{
		}
	}
}