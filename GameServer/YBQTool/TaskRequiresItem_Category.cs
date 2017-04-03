using System;
using System.ComponentModel;

namespace ns2
{
	[DefaultProperty("物品ID")]
	internal class TaskRequiresItem_Category
	{
		private int int_0;

		private int int_1;

		private int int_2;

		private int int_3;

		private int int_4;

		[Category("基本")]
		[Description("坐标X")]
		public int CoordX
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

		[Category("基本")]
		[Description("坐标Y")]
		public int CoordY
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

		[Category("基本")]
		[Description("物品ID")]
		public int ItemID
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

		[Category("基本")]
		[Description("物品数量")]
		public int ItemQuantity
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

		[Category("基本")]
		[Description("地图ID")]
		public int MapID
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

		public TaskRequiresItem_Category()
		{
		}
	}
}