using System;

namespace ns8
{
	public class NHAN_VAT_CLASS
	{
		public byte[] byte_0;

		public byte AM_THANH
		{
			get
			{
				return this.byte_0[4];
			}
			set
			{
				this.byte_0[4] = value;
			}
		}

		public byte GIOI_TINH
		{
			get
			{
				return this.byte_0[5];
			}
			set
			{
				this.byte_0[5] = value;
			}
		}

		public byte KHUON_MAT_LOAI_HINH
		{
			get
			{
				return this.byte_0[0];
			}
			set
			{
				this.byte_0[0] = value;
			}
		}

		public byte KIEU_TOC
		{
			get
			{
				return this.byte_0[3];
			}
			set
			{
				this.byte_0[3] = value;
			}
		}

		public short MAU_TOC
		{
			get
			{
				return BitConverter.ToInt16(this.byte_0, 1);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, this.byte_0, 1, 2);
			}
		}

		public NHAN_VAT_CLASS(byte[] NHAN_VAT_byte_)
		{
			this.byte_0 = NHAN_VAT_byte_;
		}
	}
}