using System;
namespace RxjhTool
{
	public class PositionClass
	{
		private int _CoordsX;
		private int _CoordsY;
		private int _MapID;
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
