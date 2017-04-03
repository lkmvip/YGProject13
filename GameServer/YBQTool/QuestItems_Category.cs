using System;
using System.ComponentModel;

namespace ns4
{
	[DefaultProperty("物品ID")]
	internal class QuestItems_Category
	{
		private int int_0;

		private int int_1;

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

		public QuestItems_Category()
		{
		}
	}
}