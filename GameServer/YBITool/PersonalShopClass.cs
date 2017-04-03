using ns6;
using RxjhServer;
using System;

namespace ns3
{
	public class PersonalShopClass : IDisposable
	{
		private bool bool_0;

		private bool bool_1;

		private byte[] byte_0;

		public Players class15_0;

		public int int_0;

		private ThreadSafeDictionary<long, CA_NHAN_CUA_HANG_ITEM_LOAI> threadSafeDictionary_0 = new ThreadSafeDictionary<long, CA_NHAN_CUA_HANG_ITEM_LOAI>();

		public bool CA_NHAN_CUA_HANG_CO_HAY_KHONG_SU_DUNG_BEN_TRONG
		{
			get
			{
				return this.bool_1;
			}
			set
			{
				this.bool_1 = value;
			}
		}

		public ThreadSafeDictionary<long, CA_NHAN_CUA_HANG_ITEM_LOAI> CUA_HANG_ITEM_DANH_SACH
		{
			get
			{
				return this.threadSafeDictionary_0;
			}
			set
			{
				this.threadSafeDictionary_0 = value;
			}
		}

		public byte[] CUA_HANG_TEN
		{
			get
			{
				return this.byte_0;
			}
			set
			{
				this.byte_0 = value;
			}
		}

		public bool PersonStore_Open
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				this.bool_0 = value;
			}
		}

		public PersonalShopClass()
		{
		}

		public void Dispose()
		{
			if (this.CUA_HANG_ITEM_DANH_SACH != null)
			{
				this.CUA_HANG_ITEM_DANH_SACH.Clear();
				this.CUA_HANG_ITEM_DANH_SACH.Dispose();
				this.CUA_HANG_ITEM_DANH_SACH = null;
			}
			this.CUA_HANG_TEN = null;
			this.class15_0 = null;
		}

		~PersonalShopClass()
		{
		}
	}
}