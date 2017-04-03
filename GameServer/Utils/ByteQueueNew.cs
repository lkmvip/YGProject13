using ns12;
using System;
using System.IO;

namespace ns1
{
	internal class ByteQueueNew : IDisposable
	{
		private byte[] byte_0;

		private int int_0;

		private int int_1;

		private int int_2;

		public int Capacity
		{
			get
			{
				return this.int_0;
			}
		}

		public int Index
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

		public int Length
		{
			get
			{
				return this.int_1;
			}
		}

		public ByteQueueNew()
		{
			this.byte_0 = new byte[this.int_0];
		}

		public void method_0(byte[] byte_1)
		{
			this.method_2(byte_1, 0, (int)byte_1.Length);
		}

		public byte[] method_1(int int_3)
		{
			byte[] numArray = new byte[int_3];
			this.method_2(numArray, 0, int_3);
			return numArray;
		}

		public bool method_10(ref byte[] byte_1)
		{
			if (this.int_2 + (int)byte_1.Length > this.int_1)
			{
				return false;
			}
			Buffer.BlockCopy(this.byte_0, this.int_2, byte_1, 0, (int)byte_1.Length);
			this.int_2 = this.int_2 + (int)byte_1.Length;
			return true;
		}

		public bool method_11(ref byte[] byte_1)
		{
			int num = 0;
			if (!this.method_7(ref num))
			{
				return false;
			}
			byte[] numArray = new byte[num];
			if (this.int_2 + (int)numArray.Length > this.int_1)
			{
				return false;
			}
			Buffer.BlockCopy(this.byte_0, this.int_2, numArray, 0, (int)numArray.Length);
			this.int_2 = this.int_2 + (int)numArray.Length;
			return true;
		}

		public bool method_12(ref byte[] byte_1)
		{
			int num = 0;
			if (!this.method_6(ref num))
			{
				return false;
			}
			byte[] numArray = new byte[num];
			if (this.int_2 + (int)numArray.Length > this.int_1)
			{
				return false;
			}
			Buffer.BlockCopy(this.byte_0, this.int_2, numArray, 0, (int)numArray.Length);
			this.int_2 = this.int_2 + (int)numArray.Length;
			return true;
		}

		public void method_13(byte[] byte_1)
		{
			this.method_15(byte_1, 0, (int)byte_1.Length);
		}

		public void method_14(Stream stream_0, int int_3)
		{
			byte[] numArray = new byte[int_3];
			int_3 = stream_0.Read(numArray, 0, int_3);
			this.method_15(numArray, 0, int_3);
		}

		public void method_15(byte[] byte_1, int int_3, int int_4)
		{
			this.method_16(this.int_1 + int_4);
			Buffer.BlockCopy(byte_1, int_3, this.byte_0, this.int_1, int_4);
			this.int_1 = this.int_1 + int_4;
		}

		private void method_16(int int_3)
		{
			if (int_3 > this.int_0)
			{
				byte[] byte0 = this.byte_0;
				this.int_0 = int_3 + 2047 & -2048;
				this.byte_0 = new byte[this.int_0];
				Buffer.BlockCopy((Array)byte0, 0, this.byte_0, 0, this.int_1);
			}
		}

		public void method_17(byte[] byte_1)
		{
			this.method_19(byte_1, 0, (int)byte_1.Length);
		}

		public byte[] method_18(int int_3)
		{
			byte[] numArray = new byte[int_3];
			this.method_19(numArray, 0, int_3);
			return numArray;
		}

		public void method_19(byte[] byte_1, int int_3, int int_4)
		{
			Buffer.BlockCopy(this.byte_0, 0, byte_1, int_3, int_4);
		}

		public void method_2(byte[] byte_1, int int_3, int int_4)
		{
			Buffer.BlockCopy(this.byte_0, 0, byte_1, int_3, int_4);
			this.int_1 = this.int_1 - int_4;
			int int4 = int_4;
			for (int i = 0; i < this.int_1; i++)
			{
				this.byte_0[i] = this.byte_0[int4];
				int4++;
			}
			this.int_2 = 0;
		}

		public double method_20()
		{
			if (this.int_2 + 8 > this.int_1)
			{
				throw new Exception0();
			}
			double num = BitConverter.ToDouble(this.byte_0, this.int_2);
			this.int_2 = this.int_2 + 8;
			return num;
		}

		public int method_21()
		{
			if (this.int_2 + 4 > this.int_1)
			{
				throw new Exception0();
			}
			int num = BitConverter.ToInt32(this.byte_0, this.int_2);
			this.int_2 = this.int_2 + 4;
			return num;
		}

		public int method_22()
		{
			if (this.int_2 + 2 > this.int_1)
			{
				throw new Exception0();
			}
			short num = BitConverter.ToInt16(this.byte_0, this.int_2);
			this.int_2 = this.int_2 + 2;
			return num;
		}

		public int method_23()
		{
			if (this.int_2 + 1 > this.int_1)
			{
				throw new Exception0();
			}
			byte[] byte0 = this.byte_0;
			int int2 = this.int_2;
			this.int_2 = int2 + 1;
			return byte0[int2];
		}

		public bool method_24()
		{
			if (this.int_2 + 1 > this.int_1)
			{
				throw new Exception0();
			}
			byte[] byte0 = this.byte_0;
			int int2 = this.int_2;
			this.int_2 = int2 + 1;
			return BitConverter.ToBoolean(byte0, int2);
		}

		public float method_25()
		{
			if (this.int_2 + 4 > this.int_1)
			{
				throw new Exception0();
			}
			float single = BitConverter.ToSingle(this.byte_0, this.int_2);
			this.int_2 = this.int_2 + 4;
			return single;
		}

		public byte[] method_26()
		{
			byte[] numArray = new byte[this.method_23()];
			if (this.int_2 + (int)numArray.Length > this.int_1)
			{
				throw new Exception0();
			}
			Buffer.BlockCopy(this.byte_0, this.int_2, numArray, 0, (int)numArray.Length);
			this.int_2 = this.int_2 + (int)numArray.Length;
			return numArray;
		}

		public byte[] method_27()
		{
			byte[] numArray = new byte[this.method_22()];
			if (this.int_2 + (int)numArray.Length > this.int_1)
			{
				throw new Exception0();
			}
			Buffer.BlockCopy(this.byte_0, this.int_2, numArray, 0, (int)numArray.Length);
			this.int_2 = this.int_2 + (int)numArray.Length;
			return numArray;
		}

		public byte[] method_3()
		{
			if (this.int_1 < 4)
			{
				return null;
			}
			int num = BitConverter.ToInt32(this.byte_0, 0);
			if (num + 4 > this.int_1)
			{
				return null;
			}
			byte[] numArray = new byte[num + 4];
			this.method_0(numArray);
			return numArray;
		}

		public bool method_4(ref double double_0)
		{
			if (this.int_2 + 8 > this.int_1)
			{
				return false;
			}
			double_0 = BitConverter.ToDouble(this.byte_0, this.int_2);
			this.int_2 = this.int_2 + 8;
			return true;
		}

		public bool method_5(ref int int_3)
		{
			if (this.int_2 + 4 > this.int_1)
			{
				return false;
			}
			int_3 = BitConverter.ToInt32(this.byte_0, this.int_2);
			this.int_2 = this.int_2 + 4;
			return true;
		}

		public bool method_6(ref int int_3)
		{
			if (this.int_2 + 2 > this.int_1)
			{
				return false;
			}
			int_3 = BitConverter.ToInt16(this.byte_0, this.int_2);
			this.int_2 = this.int_2 + 2;
			return true;
		}

		public bool method_7(ref int int_3)
		{
			if (this.int_2 + 1 > this.int_1)
			{
				return false;
			}
			byte[] byte0 = this.byte_0;
			int int2 = this.int_2;
			this.int_2 = int2 + 1;
			int_3 = byte0[int2];
			return true;
		}

		public bool method_8(ref bool bool_0)
		{
			if (this.int_2 + 1 > this.int_1)
			{
				return false;
			}
			byte[] byte0 = this.byte_0;
			int int2 = this.int_2;
			this.int_2 = int2 + 1;
			bool_0 = BitConverter.ToBoolean(byte0, int2);
			return true;
		}

		public bool method_9(ref float float_0)
		{
			if (this.int_2 + 4 > this.int_1)
			{
				return false;
			}
			float_0 = BitConverter.ToSingle(this.byte_0, this.int_2);
			this.int_2 = this.int_2 + 4;
			return true;
		}

		void System.IDisposable.Dispose()
		{
			this.byte_0 = null;
		}
	}
}