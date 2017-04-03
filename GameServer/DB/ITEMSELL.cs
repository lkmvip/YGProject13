using System;

namespace ns13
{
	internal class ITEMSELL
	{
		private int int1;

		private string string_0;

		public int FLD_TYPE;

		public int FLD_SO_CAP_PHU_HON;

		public int FLD_TIEN_HOA;

		public int FLD_CO_HAY_KHONG_TROI_CHAT;

		public int FLD_DAYS;

		public int FLD_RETURN;

		public int FLD_NUMBER;

		public int FLD_MAGIC1;

		public int FLD_MAGIC2;

		public int FLD_MAGIC3;

		public int FLD_MAGIC4;

		public int FLD_MAGIC5;

		public int FLD_TRUNG_CAP_PHU_HON;

		public long FLD_PRICE;

		public string FLD_DESC;

		public string FLD_NAME
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

		public int FLD_PID
		{
			get
			{
				return this.int1;
			}
			set
			{
				this.int1 = value;
			}
		}

		public ITEMSELL()
		{
		}
	}
}