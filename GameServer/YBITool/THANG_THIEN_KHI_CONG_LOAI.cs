using System;

namespace ns3
{
	public class THANG_THIEN_KHI_CONG_LOAI
	{
		private byte[] byte_0;

		public byte[] KHI_CONG_byte
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

		public int KHI_CONG_ID
		{
			get
			{
				return BitConverter.ToInt16(this.KHI_CONG_byte, 0);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, this.KHI_CONG_byte, 0, 2);
			}
		}

		public int KHI_CONG_SO_LUONG
		{
			get
			{
				return BitConverter.ToInt16(this.KHI_CONG_byte, 2);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, this.KHI_CONG_byte, 2, 2);
			}
		}

		public THANG_THIEN_KHI_CONG_LOAI()
		{
			this.KHI_CONG_byte = new byte[4];
		}

		public THANG_THIEN_KHI_CONG_LOAI(byte[] KHI_CONG_byte_)
		{
			this.KHI_CONG_byte = KHI_CONG_byte_;
		}
	}
}