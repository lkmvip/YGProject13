using ns2;
using ns4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;

namespace ns1
{
	internal class NPC_CLASS
	{
		private int int_0;

		private int int_1;

		private int int_2;

		private int int_3;

		public int int_4;

		private List<TaskRequiresItem_Category> list_0 = new List<TaskRequiresItem_Category>();

		private string string_0 = "";

		private string string_1 = "";

		public string string_10 = "";

		public string string_2 = "";

		public string string_3 = "";

		public string string_4 = "";

		public string string_5 = "";

		private string string_6 = "";

		public string string_7 = "";

		public string string_8 = "";

		public string string_9 = "";

		[Category("需要物品")]
		[Description("要完成当前阶段任务需要的物品")]
		[Editor(typeof(MyRewardItemsCollectionEditor), typeof(UITypeEditor))]
		public List<TaskRequiresItem_Category> NeededItem
		{
			get
			{
				return this.list_0;
			}
			set
			{
				this.list_0 = value;
			}
		}

		[Category("基本")]
		[Description("坐标X")]
		public int NpcCoordX
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

		[Category("基本")]
		[Description("坐标Y")]
		public int NpcCoordY
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
		[Description("NpcID")]
		public int NpcID
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
		[Description("地图ID")]
		public int NpcMapID
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

		[Category("提示内容")]
		[Description("坐标Y")]
		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		public string RequirementsMet
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

		[Category("提示内容")]
		[Description("坐标Y")]
		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		public string RequirementsNotMet
		{
			get
			{
				return this.string_6;
			}
			set
			{
				this.string_6 = value;
			}
		}

		[Category("阶段内容")]
		[Description("当前阶段提示内容")]
		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		public string StageText
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

		public NPC_CLASS()
		{
		}
	}
}