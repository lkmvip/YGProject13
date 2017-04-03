using System;

namespace ns12
{
	public class NHIEM_VU_CLASS
	{
		private byte[] byte_0;

		public byte[] NHIEM_VU_BYTE
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

		public int NHIEM_VU_GIAI_DOAN_ID
		{
			get
			{
				byte[] numArray = new byte[2];
				Buffer.BlockCopy(this.byte_0, 2, numArray, 0, 2);
				return BitConverter.ToInt16(numArray, 0);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, this.byte_0, 2, 2);
			}
		}

		public int NHIEM_VU_ID
		{
			get
			{
				byte[] numArray = new byte[2];
				Buffer.BlockCopy(this.byte_0, 0, numArray, 0, 2);
				return BitConverter.ToInt16(numArray, 0);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, this.byte_0, 0, 2);
			}
		}

		public NHIEM_VU_CLASS()
		{
			this.NHIEM_VU_BYTE = new byte[4];
		}

		public NHIEM_VU_CLASS(byte[] NHIEM_VU_byte_)
		{
			this.NHIEM_VU_BYTE = NHIEM_VU_byte_;
		}
	}
}