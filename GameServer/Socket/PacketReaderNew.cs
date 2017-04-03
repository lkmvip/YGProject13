using ns12;
using System;
using System.IO;
using System.Text;

namespace ns7
{
	internal class PacketReaderNew : IDisposable
	{
		private byte[] byte_0;

		private int int_0;

		private int int_1;

		public byte[] Buffer
		{
			get
			{
				return this.byte_0;
			}
		}

		public int Size
		{
			get
			{
				return this.int_0;
			}
		}

		public PacketReaderNew(byte[] data, int size, bool fixedSize)
		{
			this.byte_0 = data;
			this.int_0 = size;
			this.int_1 = (fixedSize ? 0 : 2);
		}

		~PacketReaderNew()
		{
			this.byte_0 = null;
		}

		public int method_0(int int_2, SeekOrigin seekOrigin_0)
		{
			switch (seekOrigin_0)
			{
				case SeekOrigin.Begin:
				{
					this.int_1 = int_2;
					break;
				}
				case SeekOrigin.Current:
				{
					this.int_1 = this.int_1 + int_2;
					break;
				}
				case SeekOrigin.End:
				{
					this.int_1 = this.int_0 - int_2;
					break;
				}
			}
			return this.int_1;
		}

		public double method_1()
		{
			if (this.int_1 + 8 > this.int_0)
			{
				throw new Exception0();
			}
			double num = BitConverter.ToDouble(this.byte_0, this.int_1);
			this.int_1 = this.int_1 + 8;
			return num;
		}

		public string method_10()
		{
			byte[] numArray = new byte[this.method_4()];
			if (this.int_1 + (int)numArray.Length > this.int_0)
			{
				throw new Exception0();
			}
			System.Buffer.BlockCopy(this.byte_0, this.int_1, numArray, 0, (int)numArray.Length);
			this.int_1 = this.int_1 + (int)numArray.Length;
			return Encoding.Default.GetString(numArray);
		}

		public string method_11()
		{
			byte[] numArray = new byte[this.method_2()];
			if (this.int_1 + (int)numArray.Length > this.int_0)
			{
				throw new Exception0();
			}
			System.Buffer.BlockCopy(this.byte_0, this.int_1, numArray, 0, (int)numArray.Length);
			this.int_1 = this.int_1 + (int)numArray.Length;
			return Encoding.Default.GetString(numArray);
		}

		public byte[] method_12()
		{
			byte[] numArray = new byte[this.method_4()];
			if (this.int_1 + (int)numArray.Length > this.int_0)
			{
				throw new Exception0();
			}
			System.Buffer.BlockCopy(this.byte_0, this.int_1, numArray, 0, (int)numArray.Length);
			this.int_1 = this.int_1 + (int)numArray.Length;
			return numArray;
		}

		public byte[] method_13()
		{
			byte[] numArray = new byte[this.method_4()];
			if (this.int_1 + (int)numArray.Length > this.int_0)
			{
				throw new Exception0();
			}
			System.Buffer.BlockCopy(this.byte_0, this.int_1, numArray, 0, (int)numArray.Length);
			this.int_1 = this.int_1 + (int)numArray.Length;
			return numArray;
		}

		public byte[] method_14()
		{
			if (this.int_0 <= this.int_1)
			{
				return null;
			}
			byte[] numArray = new byte[this.int_0 - this.int_1];
			System.Buffer.BlockCopy(this.byte_0, this.int_1, numArray, 0, (int)numArray.Length);
			return numArray;
		}

		public int method_2()
		{
			if (this.int_1 + 4 > this.int_0)
			{
				throw new Exception0();
			}
			int num = BitConverter.ToInt32(this.byte_0, this.int_1);
			this.int_1 = this.int_1 + 4;
			return num;
		}

		public int method_3()
		{
			if (this.int_1 + 4 > this.int_0)
			{
				throw new Exception0();
			}
			Array.Reverse(this.byte_0, this.int_1, 4);
			int num = BitConverter.ToInt32(this.byte_0, this.int_1);
			this.int_1 = this.int_1 + 4;
			return num;
		}

		public int method_4()
		{
			if (this.int_1 + 2 > this.int_0)
			{
				throw new Exception0();
			}
			short num = BitConverter.ToInt16(this.byte_0, this.int_1);
			this.int_1 = this.int_1 + 2;
			return num;
		}

		public int method_5()
		{
			if (this.int_1 + 2 > this.int_0)
			{
				throw new Exception0();
			}
			ushort num = BitConverter.ToUInt16(this.byte_0, this.int_1);
			this.int_1 = this.int_1 + 2;
			return num;
		}

		public int method_6()
		{
			if (this.int_1 + 1 > this.int_0)
			{
				throw new Exception0();
			}
			byte[] byte0 = this.byte_0;
			int int1 = this.int_1;
			this.int_1 = int1 + 1;
			return byte0[int1];
		}

		public bool method_7()
		{
			if (this.int_1 + 1 > this.int_0)
			{
				throw new Exception0();
			}
			byte[] byte0 = this.byte_0;
			int int1 = this.int_1;
			this.int_1 = int1 + 1;
			return BitConverter.ToBoolean(byte0, int1);
		}

		public float method_8()
		{
			if (this.int_1 + 4 > this.int_0)
			{
				throw new Exception0();
			}
			float single = BitConverter.ToSingle(this.byte_0, this.int_1);
			this.int_1 = this.int_1 + 4;
			return single;
		}

		public string method_9()
		{
			byte[] numArray = new byte[this.method_6()];
			if (this.int_1 + (int)numArray.Length > this.int_0)
			{
				throw new Exception0();
			}
			System.Buffer.BlockCopy(this.byte_0, this.int_1, numArray, 0, (int)numArray.Length);
			this.int_1 = this.int_1 + (int)numArray.Length;
			return Encoding.Default.GetString(numArray);
		}

		void System.IDisposable.Dispose()
		{
			this.byte_0 = null;
		}
	}
}