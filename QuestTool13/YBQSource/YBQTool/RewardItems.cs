using System;
using System.ComponentModel;
namespace RxjhTool
{
	[DefaultProperty("ItemID")]
	public class 任务RewardItems类
	{
		private int _ItemAmmount;
		private int _ItemID;
		[Category("Basic"), Description("ItemAmmount")]
		public int ItemAmmount
		{
			get
			{
				return this._ItemAmmount;
			}
			set
			{
				this._ItemAmmount = value;
			}
		}
		[Category("Basic"), Description("ItemID")]
		public int ItemID
		{
			get
			{
				return this._ItemID;
			}
			set
			{
				this._ItemID = value;
			}
		}
	}
}
