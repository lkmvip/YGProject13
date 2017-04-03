using System;

namespace ns6
{
	public class QuestItem_Category
	{
		public byte[] byte_0;

		public int VAT_PHAM_ID
		{
			get
			{
				byte[] numArray = new byte[4];
				Buffer.BlockCopy(this.byte_0, 0, numArray, 0, 4);
				return BitConverter.ToInt32(numArray, 0);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, this.byte_0, 0, 4);
			}
		}

		public int VAT_PHAM_SO_LUONG
		{
			get
			{
				byte[] numArray = new byte[4];
				Buffer.BlockCopy(this.byte_0, 4, numArray, 0, 4);
				return BitConverter.ToInt32(numArray, 0);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, this.byte_0, 4, 4);
			}
		}

		public QuestItem_Category(byte[] VATPHAM_byte_)
		{
			this.byte_0 = VATPHAM_byte_;
		}
	}
}