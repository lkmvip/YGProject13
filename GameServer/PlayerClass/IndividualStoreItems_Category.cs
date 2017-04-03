using ns9;
using System;

namespace ns2
{
	public class IndividualStoreItems_Category : IDisposable
	{
		private VAT_PHAM_LOAI class23_0;

		private int int_0;

		public VAT_PHAM_LOAI VAT_PHAM
		{
			get
			{
				return this.class23_0;
			}
			set
			{
				this.class23_0 = value;
			}
		}

		public int VAT_PHAM_SO_LUONG
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

		public IndividualStoreItems_Category()
		{
		}

		void System.IDisposable.Dispose()
		{
			this.VAT_PHAM = null;
		}
	}
}