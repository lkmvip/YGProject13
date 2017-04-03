using ns3;
using System;
using System.IO;
using System.Text;

namespace ns5
{
	public class PacketData : IDisposable
	{
		private byte[] byte_0;

		private int int_0;

		private MemoryStream memoryStream_0;

		private MemoryStream memoryStream_1;

		public int InfoType
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

		public int Length
		{
			get
			{
				return (int)(this.memoryStream_0.Length + (long)6);
			}
		}

		public PacketData()
		{
			this.byte_0 = new byte[8];
			this.memoryStream_0 = new MemoryStream();
		}

		public PacketData(int Type)
		{
			this.memoryStream_0 = new MemoryStream();
			this.byte_0 = new byte[8];
			this.Write2(Type);
		}

		public void method_0(byte[] byte_1)
		{
			this.memoryStream_0.Write(byte_1, 0, (int)byte_1.Length);
		}

		public void method_1(float float_0)
		{
			this.byte_0 = BitConverter.GetBytes(float_0);
			this.memoryStream_0.Write(this.byte_0, 0, 4);
		}

		public void method_10(byte[] byte_1, int int_1, int int_2)
		{
			this.memoryStream_0.Write(byte_1, int_1, int_2);
		}

		public void method_11(string string_0)
		{
			if (string_0 == null)
			{
				Console.WriteLine("Network: Attempted to WriteAsciiFixed() with null value");
				string_0 = string.Empty;
			}
			byte[] bytes = Encoding.Default.GetBytes(string_0);
			this.Write2((int)((int)bytes.Length));
			this.memoryStream_0.Write(bytes, 0, (int)bytes.Length);
		}

		public void method_12(string string_0)
		{
			if (string_0 == null)
			{
				string_0 = string.Empty;
			}
			byte[] bytes = Encoding.Default.GetBytes(string_0);
			this.method_2((int)bytes.Length);
			this.memoryStream_0.Write(bytes, 0, (int)bytes.Length);
		}

		public void method_13(string string_0)
		{
			if (string_0 == null)
			{
				string_0 = string.Empty;
			}
			byte[] bytes = Encoding.Default.GetBytes(string_0);
			this.Write2((int)bytes.Length);
			this.memoryStream_0.Write(bytes, 0, (int)bytes.Length);
		}

		public void method_14(string string_0)
		{
			if (string_0 == null)
			{
				string_0 = string.Empty;
			}
			byte[] bytes = Encoding.Default.GetBytes(string_0);
			this.Write4((int)bytes.Length);
			this.memoryStream_0.Write(bytes, 0, (int)bytes.Length);
		}

		public void method_15(string string_0, int int_1)
		{
			if (string_0 == null)
			{
				Console.WriteLine("Network: Attempted to WriteAsciiFixed() with null value");
				string_0 = string.Empty;
			}
			byte[] numArray = new byte[int_1];
			byte[] bytes = Encoding.Default.GetBytes(string_0);
			Buffer.BlockCopy(bytes, 0, numArray, 0, (int)bytes.Length);
			this.memoryStream_0.Write(numArray, 0, (int)numArray.Length);
		}

		public void method_16(string string_0)
		{
			if (string_0 == null)
			{
				string_0 = string.Empty;
			}
			byte[] bytes = Encoding.Default.GetBytes(string_0);
			byte[] numArray = new byte[15];
			if ((int)bytes.Length > 15)
			{
				Buffer.BlockCopy(bytes, 0, numArray, 0, 15);
			}
			else
			{
				Buffer.BlockCopy(bytes, 0, numArray, 0, (int)bytes.Length);
			}
			this.memoryStream_0.Write(numArray, 0, (int)numArray.Length);
		}

		public byte[] method_17()
		{
			return this.memoryStream_0.ToArray();
		}

		public byte[] method_18(int int_1, int int_2)
		{
			this.memoryStream_1 = new MemoryStream();
			this.byte_0[0] = (byte)int_2;
			this.byte_0[1] = (byte)(int_2 >> 8);
			this.memoryStream_1.Write(this.byte_0, 0, 2);
			this.byte_0[0] = (byte)(int_1 >> 8);
			this.byte_0[1] = (byte)int_1;
			this.memoryStream_1.Write(this.byte_0, 0, 2);
			this.byte_0[0] = (byte)this.memoryStream_0.Length;
			this.byte_0[1] = (byte)(this.memoryStream_0.Length >> 8);
			this.memoryStream_1.Write(this.byte_0, 0, 2);
			this.memoryStream_0.WriteTo(this.memoryStream_1);
			return this.memoryStream_1.ToArray();
		}

		public void method_2(int int_1)
		{
			this.memoryStream_0.WriteByte((byte)(int_1 & 255));
		}

		public byte[] method_20(int int_1, int int_2, byte byte_1)
		{
			this.memoryStream_1 = new MemoryStream();
			this.memoryStream_1.WriteByte(170);
			this.memoryStream_1.WriteByte(85);
			this.byte_0[0] = (byte)(this.memoryStream_0.Length + (long)15);
			this.byte_0[1] = (byte)(this.memoryStream_0.Length + (long)15 >> 8);
			this.memoryStream_1.Write(this.byte_0, 0, 2);
			this.memoryStream_1.WriteByte(byte_1);
			this.byte_0[0] = (byte)int_2;
			this.byte_0[1] = (byte)(int_2 >> 8);
			this.memoryStream_1.Write(this.byte_0, 0, 2);
			this.byte_0[0] = (byte)(int_1 >> 8);
			this.byte_0[1] = (byte)int_1;
			this.memoryStream_1.Write(this.byte_0, 0, 2);
			this.byte_0[0] = (byte)this.memoryStream_0.Length;
			this.byte_0[1] = (byte)(this.memoryStream_0.Length >> 8);
			this.memoryStream_1.Write(this.byte_0, 0, 2);
			this.memoryStream_0.WriteTo(this.memoryStream_1);
			this.memoryStream_1.Write(new byte[8], 0, 8);
			this.memoryStream_0.WriteTo(this.memoryStream_1);
			this.memoryStream_1.WriteByte(85);
			this.memoryStream_1.WriteByte(170);
			return this.memoryStream_1.ToArray();
		}

		public void method_3(int int_1)
		{
			this.memoryStream_0.WriteByte((byte)(int_1 & 255));
		}

		public void method_6(long long_0)
		{
			this.byte_0[0] = (byte)long_0;
			this.byte_0[1] = (byte)(long_0 >> 8);
			this.byte_0[2] = (byte)(long_0 >> 16);
			this.byte_0[3] = (byte)(long_0 >> 24);
			this.memoryStream_0.Write(this.byte_0, 0, 4);
		}

		public void method_7(uint uint_0)
		{
			this.byte_0[0] = (byte)uint_0;
			this.byte_0[1] = (byte)(uint_0 >> 8);
			this.byte_0[2] = (byte)(uint_0 >> 16);
			this.byte_0[3] = (byte)(uint_0 >> 24);
			this.memoryStream_0.Write(this.byte_0, 0, 4);
		}

		public void method_8(long long_0)
		{
			this.byte_0[0] = (byte)long_0;
			this.byte_0[1] = (byte)(long_0 >> 8);
			this.byte_0[2] = (byte)(long_0 >> 16);
			this.byte_0[3] = (byte)(long_0 >> 24);
			this.byte_0[4] = (byte)(long_0 >> 32);
			this.byte_0[5] = (byte)(long_0 >> 40);
			this.byte_0[6] = (byte)(long_0 >> 48);
			this.byte_0[7] = (byte)(long_0 >> 56);
			this.memoryStream_0.Write(this.byte_0, 0, 8);
		}

		public void method_9(long long_0)
		{
			this.byte_0[0] = (byte)long_0;
			this.byte_0[1] = (byte)(long_0 >> 8);
			this.byte_0[2] = (byte)(long_0 >> 16);
			this.byte_0[3] = (byte)(long_0 >> 24);
			this.byte_0[4] = (byte)(long_0 >> 32);
			this.byte_0[5] = (byte)(long_0 >> 40);
			this.byte_0[6] = (byte)(long_0 >> 48);
			this.byte_0[7] = (byte)(long_0 >> 56);
			this.memoryStream_0.Write(this.byte_0, 0, 8);
		}

		void System.IDisposable.Dispose()
		{
			this.memoryStream_0 = null;
			this.memoryStream_1 = null;
		}

		public void Write2(int int_1)
		{
			this.byte_0[0] = (byte)int_1;
			this.byte_0[1] = (byte)(int_1 >> 8);
			this.memoryStream_0.Write(this.byte_0, 0, 2);
		}

		public void Write4(int int_1)
		{
			this.byte_0[0] = (byte)int_1;
			this.byte_0[1] = (byte)(int_1 >> 8);
			this.byte_0[2] = (byte)(int_1 >> 16);
			this.byte_0[3] = (byte)(int_1 >> 24);
			this.memoryStream_0.Write(this.byte_0, 0, 4);
		}
	}
}