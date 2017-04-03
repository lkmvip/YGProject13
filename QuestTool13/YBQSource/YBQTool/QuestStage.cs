using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
namespace RxjhTool
{
	public class QuestStage
	{
		private int _NpcCoordsX;
		private int _NpcCoordsY;
		private int _NpcID;
		private int _NpcMapID;
		private string _QuestStage内容 = "";
		private List<RequiredItems> _RequiredItems = new List<RequiredItems>();
		private string _任务条件不符合提示1 = "";
		private string _任务条件符合提示1 = "";
		public int Npc未知1;
		public string 任务条件不符合提示2 = "";
		public string 任务条件不符合提示3 = "";
		public string 任务条件不符合提示4 = "";
		public string 任务条件不符合提示5 = "";
		public string 任务条件符合提示2 = "";
		public string 任务条件符合提示3 = "";
		public string 任务条件符合提示4 = "";
		public string 任务条件符合提示5 = "";
		[Category("Basic"), Description("CoordsX")]
		public int NpcCoordsX
		{
			get
			{
				return this._NpcCoordsX;
			}
			set
			{
				this._NpcCoordsX = value;
			}
		}
		[Category("Basic"), Description("CoordsY")]
		public int NpcCoordsY
		{
			get
			{
				return this._NpcCoordsY;
			}
			set
			{
				this._NpcCoordsY = value;
			}
		}
		[Category("Basic"), Description("NpcID")]
		public int NpcID
		{
			get
			{
				return this._NpcID;
			}
			set
			{
				this._NpcID = value;
			}
		}
		[Category("Basic"), Description("MapID")]
		public int NpcMapID
		{
			get
			{
				return this._NpcMapID;
			}
			set
			{
				this._NpcMapID = value;
			}
		}
		[Category("퀘스트 설명"), Description("当前阶段提示内容"), Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		public string QuestStage内容
		{
			get
			{
				return this._QuestStage内容;
			}
			set
			{
				this._QuestStage内容 = value;
			}
		}
		[Category("RequiredItems"), Description("RequiredItemsToFinishQuest"), Editor(typeof(MyRequiredItemsCollectionEditor), typeof(UITypeEditor))]
		public List<RequiredItems> RequiredItems
		{
			get
			{
				return this._RequiredItems;
			}
			set
			{
				this._RequiredItems = value;
			}
		}
		[Category("퀘스트 팁"), Description("CoordsY"), Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		public string 任务条件不符合提示1
		{
			get
			{
				return this._任务条件不符合提示1;
			}
			set
			{
				this._任务条件不符合提示1 = value;
			}
		}
		[Category("퀘스트 팁"), Description("CoordsY"), Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		public string 任务条件符合提示1
		{
			get
			{
				return this._任务条件符合提示1;
			}
			set
			{
				this._任务条件符合提示1 = value;
			}
		}
	}
}
