using System;
using System.ComponentModel;
namespace RxjhTool
{
	[DefaultProperty("ItemID")]
	public class RequiredItems
	{
		private int _CoordsX;
		private int _CoordsY;
		private int _ItemAmmount;
		private int _ItemID;
		private int _MapID;
		[Category("Basic"), Description("CoordsX")]
		public int CoordsX
		{
			get
			{
				return this._CoordsX;
			}
			set
			{
				this._CoordsX = value;
			}
		}
		[Category("Basic"), Description("CoordsY")]
		public int CoordsY
		{
			get
			{
				return this._CoordsY;
			}
			set
			{
				this._CoordsY = value;
			}
		}
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
		[Category("Basic"), Description("MapID")]
		public int MapID
		{
			get
			{
				return this._MapID;
			}
			set
			{
				this._MapID = value;
			}
		}
	}
}
