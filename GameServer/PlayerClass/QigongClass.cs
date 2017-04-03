using System;

namespace ns13
{
	public class QigongClass
	{
		private byte[] byte_0;

		public int int_0;

		public byte[] 气功_byte
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

		public int 气功量
		{
			get
			{
				return BitConverter.ToInt16(this.气功_byte, 0);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, this.气功_byte, 0, 2);
			}
		}

		public QigongClass()
		{
		}

		public QigongClass(byte[] 气功_byte_)
		{
			this.气功_byte = 气功_byte_;
		}
	}
}