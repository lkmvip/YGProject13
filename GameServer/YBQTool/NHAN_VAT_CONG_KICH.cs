using System;

namespace ns10
{
	public class NHAN_VAT_CONG_KICH
	{
		private int int_0;

		private int int_1;

		private int int_2;

		public long long_0;

		private long long_1;

		public int CONG_KICH_LOAI_HINH
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

		public long LUC_CONG_KICH
		{
			get
			{
				return this.long_1;
			}
			set
			{
				this.long_1 = value;
			}
		}

		public int NHAN_VAT_ID
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

		public int VO_CONG_ID
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

		public NHAN_VAT_CONG_KICH(int NHAN_VAT_ID_, int VO_CONG_ID_, long LUC_CONG_KICH_, int CONG_KICH_LOAI_HINH_)
		{
			this.NHAN_VAT_ID = NHAN_VAT_ID_;
			this.VO_CONG_ID = VO_CONG_ID_;
			this.LUC_CONG_KICH = LUC_CONG_KICH_;
			this.CONG_KICH_LOAI_HINH = CONG_KICH_LOAI_HINH_;
		}
	}
}