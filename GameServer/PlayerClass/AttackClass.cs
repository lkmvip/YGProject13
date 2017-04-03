using ns10;
using System;
using System.Collections.Generic;

namespace ns4
{
	public class AttackClass : IDisposable
	{
		private int int_0;

		private int int_1;

		private int int_2;

		public List<NHAN_VAT_CONG_KICH> list_0;

		private long long_0;

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
				return this.long_0;
			}
			set
			{
				this.long_0 = value;
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

		public AttackClass(int NHAN_VAT_ID_, int VO_CONG_ID_, long LUC_CONG_KICH_, int CONG_KICH_LOAI_HINH_)
		{
			this.NHAN_VAT_ID = NHAN_VAT_ID_;
			this.VO_CONG_ID = VO_CONG_ID_;
			this.LUC_CONG_KICH = LUC_CONG_KICH_;
			this.CONG_KICH_LOAI_HINH = CONG_KICH_LOAI_HINH_;
		}

		public AttackClass(int NHAN_VAT_ID_, int VO_CONG_ID_, long LUC_CONG_KICH_, int CONG_KICH_LOAI_HINH_, int QUAN_CONG_1)
		{
			this.NHAN_VAT_ID = NHAN_VAT_ID_;
			this.VO_CONG_ID = VO_CONG_ID_;
			this.LUC_CONG_KICH = LUC_CONG_KICH_;
			this.CONG_KICH_LOAI_HINH = CONG_KICH_LOAI_HINH_;
			if (QUAN_CONG_1 == 4)
			{
				this.list_0 = new List<NHAN_VAT_CONG_KICH>();
			}
		}

		void System.IDisposable.Dispose()
		{
			if (this.list_0 != null)
			{
				this.list_0.Clear();
				this.list_0 = null;
			}
		}
	}
}