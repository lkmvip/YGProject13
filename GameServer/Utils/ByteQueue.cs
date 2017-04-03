using System;

namespace ns7
{
	public class ByteQueue : IDisposable
	{
		public byte[] byte_0 = new byte[2048];

		private int int_0;

		private int int_1;

		private int int_2;

		public int Length
		{
			get
			{
				return this.int_2;
			}
		}

		public ByteQueue()
		{
		}

		public void Dispose()
		{
			this.byte_0 = null;
		}

		public void method_0()
		{
			this.int_0 = 0;
			this.int_1 = 0;
			this.int_2 = 0;
		}

		private void method_1(int int_3)
		{
			byte[] numArray = new byte[int_3];
			if (this.int_2 > 0)
			{
				if (this.int_0 >= this.int_1)
				{
					Buffer.BlockCopy(this.byte_0, this.int_0, numArray, 0, (int)this.byte_0.Length - this.int_0);
					Buffer.BlockCopy(this.byte_0, 0, numArray, (int)this.byte_0.Length - this.int_0, this.int_1);
				}
				else
				{
					Buffer.BlockCopy(this.byte_0, this.int_0, numArray, 0, this.int_2);
				}
			}
			this.int_0 = 0;
			this.int_1 = this.int_2;
			this.byte_0 = numArray;
		}

		public byte[] method_2()
		{
			byte[] numArray;
			byte[] numArray1 = new byte[2];
			try
			{
				Buffer.BlockCopy(this.byte_0, this.int_0 + 2, numArray1, 0, 2);
				numArray = numArray1;
			}
			catch (Exception exception)
			{
				numArray = numArray1;
			}
			return numArray;
		}

		public byte method_3()
		{
			if (this.int_2 < 1)
			{
				return (byte)255;
			}
			return this.byte_0[this.int_0];
		}

		public int method_4()
		{
			if (this.int_2 < 3)
			{
				return 0;
			}
			return this.byte_0[(this.int_0 + 1) % (int)this.byte_0.Length] << 8 | this.byte_0[(this.int_0 + 2) % (int)this.byte_0.Length];
		}

		public int method_5(byte[] byte_1, int int_3, int int_4)
		{
			if (int_4 > this.int_2)
			{
				int_4 = this.int_2;
			}
			if (int_4 == 0)
			{
				return 0;
			}
			if (this.int_0 >= this.int_1)
			{
				int length = (int)this.byte_0.Length - this.int_0;
				if (length < int_4)
				{
					Buffer.BlockCopy(this.byte_0, this.int_0, byte_1, int_3, length);
					Buffer.BlockCopy(this.byte_0, 0, byte_1, int_3 + length, int_4 - length);
				}
				else
				{
					Buffer.BlockCopy(this.byte_0, this.int_0, byte_1, int_3, int_4);
				}
			}
			else
			{
				Buffer.BlockCopy(this.byte_0, this.int_0, byte_1, int_3, int_4);
			}
			this.int_0 = (this.int_0 + int_4) % (int)this.byte_0.Length;
			this.int_2 = this.int_2 - int_4;
			if (this.int_2 == 0)
			{
				this.int_0 = 0;
				this.int_1 = 0;
			}
			return int_4;
		}

		public void method_6(byte[] byte_1, int int_3, int int_4)
		{
			if (this.int_2 + int_4 > (int)this.byte_0.Length)
			{
				this.method_1(this.int_2 + int_4 + 2047 & -2048);
			}
			if (this.int_0 >= this.int_1)
			{
				Buffer.BlockCopy(byte_1, int_3, this.byte_0, this.int_1, int_4);
			}
			else
			{
				int length = (int)this.byte_0.Length - this.int_1;
				if (length < int_4)
				{
					Buffer.BlockCopy(byte_1, int_3, this.byte_0, this.int_1, length);
					Buffer.BlockCopy(byte_1, int_3 + length, this.byte_0, 0, int_4 - length);
				}
				else
				{
					Buffer.BlockCopy(byte_1, int_3, this.byte_0, this.int_1, int_4);
				}
			}
			this.int_1 = (this.int_1 + int_4) % (int)this.byte_0.Length;
			this.int_2 = this.int_2 + int_4;
		}
	}
}