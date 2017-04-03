using ns10;
using System;
using System.IO;
using System.Text;

namespace ns1
{
	public class PacketReader
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

		public PacketReader(byte[] data, int size, bool fixedSize)
		{
			this.byte_0 = data;
			this.int_0 = size;
			this.int_1 = (fixedSize ? 1 : 3);
		}

		public void method_0(NetState class16_0)
		{
			try
			{
				using (StreamWriter streamWriter = new StreamWriter("Packets.log", true))
				{
					byte[] byte0 = this.byte_0;
					if (byte0.Length != 0)
					{
						streamWriter.WriteLine("Client: {0}: Unhandled 包ID 0x{1:X2}{2:X2} 包长{3} 时间{4}", new object[] { class16_0, byte0[8], byte0[7], (int)byte0.Length, DateTime.Now });
					}
					using (MemoryStream memoryStream = new MemoryStream(byte0))
					{
						Utility.smethod_0(streamWriter, memoryStream, (int)byte0.Length);
					}
					streamWriter.WriteLine();
					streamWriter.WriteLine();
				}
			}
			catch
			{
			}
		}

		public int method_1(int int_2, SeekOrigin seekOrigin_0)
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

		public bool method_10()
		{
			if (this.int_1 + 1 > this.int_0)
			{
				return false;
			}
			byte[] byte0 = this.byte_0;
			int int1 = this.int_1;
			this.int_1 = int1 + 1;
			return byte0[int1] != 0;
		}

		public string method_11()
		{
			StringBuilder stringBuilder = new StringBuilder();
			while (this.int_1 + 1 < this.int_0)
			{
				byte[] byte0 = this.byte_0;
				int int1 = this.int_1;
				this.int_1 = int1 + 1;
				byte num = byte0[int1];
				byte[] numArray = this.byte_0;
				int1 = this.int_1;
				this.int_1 = int1 + 1;
				int num1 = num | numArray[int1] << 8;
				if (num1 == 0)
				{
					break;
				}
				stringBuilder.Append((char)num1);
			}
			return stringBuilder.ToString();
		}

		public string method_12(int int_2)
		{
			int int1 = this.int_1 + (int_2 << 1);
			int num = int1;
			if (int1 > this.int_0)
			{
				int1 = this.int_0;
			}
			StringBuilder stringBuilder = new StringBuilder();
			while (this.int_1 + 1 < int1)
			{
				byte[] byte0 = this.byte_0;
				int int11 = this.int_1;
				this.int_1 = int11 + 1;
				byte num1 = byte0[int11];
				byte[] numArray = this.byte_0;
				int11 = this.int_1;
				this.int_1 = int11 + 1;
				int num2 = num1 | numArray[int11] << 8;
				if (num2 == 0)
				{
					break;
				}
				if (!this.method_16(num2))
				{
					continue;
				}
				stringBuilder.Append((char)num2);
			}
			this.int_1 = num;
			return stringBuilder.ToString();
		}

		public string method_13()
		{
			StringBuilder stringBuilder = new StringBuilder();
			while (this.int_1 + 1 < this.int_0)
			{
				byte[] byte0 = this.byte_0;
				int int1 = this.int_1;
				this.int_1 = int1 + 1;
				byte num = byte0[int1];
				byte[] numArray = this.byte_0;
				int1 = this.int_1;
				this.int_1 = int1 + 1;
				int num1 = num | numArray[int1] << 8;
				if (num1 == 0)
				{
					break;
				}
				if (!this.method_16(num1))
				{
					continue;
				}
				stringBuilder.Append((char)num1);
			}
			return stringBuilder.ToString();
		}

		public string method_14()
		{
			StringBuilder stringBuilder = new StringBuilder();
			while (this.int_1 + 1 < this.int_0)
			{
				byte[] byte0 = this.byte_0;
				int int1 = this.int_1;
				this.int_1 = int1 + 1;
				int num = byte0[int1] << 8;
				byte[] numArray = this.byte_0;
				int1 = this.int_1;
				this.int_1 = int1 + 1;
				int num1 = num | numArray[int1];
				if (num1 == 0)
				{
					break;
				}
				if (!this.method_16(num1))
				{
					continue;
				}
				stringBuilder.Append((char)num1);
			}
			return stringBuilder.ToString();
		}

		public string method_15()
		{
			StringBuilder stringBuilder = new StringBuilder();
			while (this.int_1 + 1 < this.int_0)
			{
				byte[] byte0 = this.byte_0;
				int int1 = this.int_1;
				this.int_1 = int1 + 1;
				int num = byte0[int1] << 8;
				byte[] numArray = this.byte_0;
				int1 = this.int_1;
				this.int_1 = int1 + 1;
				int num1 = num | numArray[int1];
				if (num1 == 0)
				{
					break;
				}
				stringBuilder.Append((char)num1);
			}
			return stringBuilder.ToString();
		}

		public bool method_16(int int_2)
		{
			if (int_2 < 32)
			{
				return false;
			}
			return int_2 < 65534;
		}

		public string method_17(int int_2)
		{
			if (this.int_1 >= this.int_0)
			{
				this.int_1 = this.int_1 + int_2;
				return string.Empty;
			}
			int int1 = this.int_1 + int_2;
			if (int1 > this.int_0)
			{
				int1 = this.int_0;
			}
			int num = 0;
			int int11 = this.int_1;
			int num1 = this.int_1;
			while (int11 < int1)
			{
				int num2 = int11;
				int11 = num2 + 1;
				if (this.byte_0[num2] == 0)
				{
					break;
				}
				num++;
			}
			int11 = 0;
			byte[] numArray = new byte[num];
			int num3 = 0;
			while (this.int_1 < int1)
			{
				byte[] byte0 = this.byte_0;
				int int12 = this.int_1;
				this.int_1 = int12 + 1;
				num3 = byte0[int12];
				if (num3 == 0)
				{
					break;
				}
				int num4 = int11;
				int11 = num4 + 1;
				numArray[num4] = (byte)num3;
			}
			string str = Utility.UTF8.GetString(numArray);
			bool flag = true;
			for (int i = 0; flag && i < str.Length; i++)
			{
				flag = this.method_16(str[i]);
			}
			this.int_1 = num1 + int_2;
			if (flag)
			{
				return str;
			}
			StringBuilder stringBuilder = new StringBuilder(str.Length);
			for (int j = 0; j < str.Length; j++)
			{
				if (this.method_16(str[j]))
				{
					stringBuilder.Append(str[j]);
				}
			}
			return stringBuilder.ToString();
		}

		public string method_18()
		{
			if (this.int_1 >= this.int_0)
			{
				return string.Empty;
			}
			int num = 0;
			int int1 = this.int_1;
			while (int1 < this.int_0)
			{
				int num1 = int1;
				int1 = num1 + 1;
				if (this.byte_0[num1] == 0)
				{
					break;
				}
				num++;
			}
			int1 = 0;
			byte[] numArray = new byte[num];
			int num2 = 0;
			while (this.int_1 < this.int_0)
			{
				byte[] byte0 = this.byte_0;
				int int11 = this.int_1;
				this.int_1 = int11 + 1;
				num2 = byte0[int11];
				if (num2 == 0)
				{
					break;
				}
				int num3 = int1;
				int1 = num3 + 1;
				numArray[num3] = (byte)num2;
			}
			string str = Utility.UTF8.GetString(numArray);
			bool flag = true;
			for (int i = 0; flag && i < str.Length; i++)
			{
				flag = this.method_16(str[i]);
			}
			if (flag)
			{
				return str;
			}
			StringBuilder stringBuilder = new StringBuilder(str.Length);
			for (int j = 0; j < str.Length; j++)
			{
				if (this.method_16(str[j]))
				{
					stringBuilder.Append(str[j]);
				}
			}
			return stringBuilder.ToString();
		}

		public string method_19()
		{
			if (this.int_1 >= this.int_0)
			{
				return string.Empty;
			}
			int num = 0;
			int int1 = this.int_1;
			while (int1 < this.int_0)
			{
				int num1 = int1;
				int1 = num1 + 1;
				if (this.byte_0[num1] == 0)
				{
					break;
				}
				num++;
			}
			int1 = 0;
			byte[] numArray = new byte[num];
			int num2 = 0;
			while (this.int_1 < this.int_0)
			{
				byte[] byte0 = this.byte_0;
				int int11 = this.int_1;
				this.int_1 = int11 + 1;
				num2 = byte0[int11];
				if (num2 == 0)
				{
					break;
				}
				int num3 = int1;
				int1 = num3 + 1;
				numArray[num3] = (byte)num2;
			}
			return Utility.UTF8.GetString(numArray);
		}

		public int method_2()
		{
			if (this.int_1 + 4 > this.int_0)
			{
				return 0;
			}
			byte[] byte0 = this.byte_0;
			int int1 = this.int_1;
			this.int_1 = int1 + 1;
			byte num = byte0[int1];
			byte[] numArray = this.byte_0;
			int1 = this.int_1;
			this.int_1 = int1 + 1;
			int num1 = num | numArray[int1] << 8;
			byte[] byte01 = this.byte_0;
			int1 = this.int_1;
			this.int_1 = int1 + 1;
			int num2 = num1 | byte01[int1] << 16;
			byte[] numArray1 = this.byte_0;
			int1 = this.int_1;
			this.int_1 = int1 + 1;
			return num2 | numArray1[int1] << 24;
		}

		public string method_20()
		{
			StringBuilder stringBuilder = new StringBuilder();
			while (this.int_1 < this.int_0)
			{
				byte[] byte0 = this.byte_0;
				int int1 = this.int_1;
				this.int_1 = int1 + 1;
				int num = byte0[int1];
				if (num == 0)
				{
					break;
				}
				stringBuilder.Append((char)num);
			}
			return stringBuilder.ToString();
		}

		public string method_21()
		{
			StringBuilder stringBuilder = new StringBuilder();
			while (this.int_1 < this.int_0)
			{
				byte[] byte0 = this.byte_0;
				int int1 = this.int_1;
				this.int_1 = int1 + 1;
				int num = byte0[int1];
				if (num == 0)
				{
					break;
				}
				if (!this.method_16(num))
				{
					continue;
				}
				stringBuilder.Append((char)num);
			}
			return stringBuilder.ToString();
		}

		public string method_22(int int_2)
		{
			int int1 = this.int_1 + (int_2 << 1);
			int num = int1;
			if (int1 > this.int_0)
			{
				int1 = this.int_0;
			}
			StringBuilder stringBuilder = new StringBuilder();
			while (this.int_1 + 1 < int1)
			{
				byte[] byte0 = this.byte_0;
				int int11 = this.int_1;
				this.int_1 = int11 + 1;
				int num1 = byte0[int11] << 8;
				byte[] numArray = this.byte_0;
				int11 = this.int_1;
				this.int_1 = int11 + 1;
				int num2 = num1 | numArray[int11];
				if (num2 == 0)
				{
					break;
				}
				if (!this.method_16(num2))
				{
					continue;
				}
				stringBuilder.Append((char)num2);
			}
			this.int_1 = num;
			return stringBuilder.ToString();
		}

		public string method_23(int int_2)
		{
			int int1 = this.int_1 + (int_2 << 1);
			int num = int1;
			if (int1 > this.int_0)
			{
				int1 = this.int_0;
			}
			StringBuilder stringBuilder = new StringBuilder();
			while (this.int_1 + 1 < int1)
			{
				byte[] byte0 = this.byte_0;
				int int11 = this.int_1;
				this.int_1 = int11 + 1;
				int num1 = byte0[int11] << 8;
				byte[] numArray = this.byte_0;
				int11 = this.int_1;
				this.int_1 = int11 + 1;
				int num2 = num1 | numArray[int11];
				if (num2 == 0)
				{
					break;
				}
				stringBuilder.Append((char)num2);
			}
			this.int_1 = num;
			return stringBuilder.ToString();
		}

		public string method_24(int int_2)
		{
			int int1 = this.int_1 + int_2;
			int num = int1;
			if (int1 > this.int_0)
			{
				int1 = this.int_0;
			}
			StringBuilder stringBuilder = new StringBuilder();
			while (this.int_1 < int1)
			{
				byte[] byte0 = this.byte_0;
				int int11 = this.int_1;
				this.int_1 = int11 + 1;
				int num1 = byte0[int11];
				if (num1 == 0)
				{
					break;
				}
				if (!this.method_16(num1))
				{
					continue;
				}
				stringBuilder.Append((char)num1);
			}
			this.int_1 = num;
			return stringBuilder.ToString();
		}

		public string method_25(int int_2)
		{
			int int1 = this.int_1 + int_2;
			int num = int1;
			if (int1 > this.int_0)
			{
				int1 = this.int_0;
			}
			StringBuilder stringBuilder = new StringBuilder();
			while (this.int_1 < int1)
			{
				byte[] byte0 = this.byte_0;
				int int11 = this.int_1;
				this.int_1 = int11 + 1;
				int num1 = byte0[int11];
				if (num1 == 0)
				{
					break;
				}
				stringBuilder.Append((char)num1);
			}
			this.int_1 = num;
			return stringBuilder.ToString();
		}

		public int method_3()
		{
			if (this.int_1 + 2 > this.int_0)
			{
				return 0;
			}
			byte[] byte0 = this.byte_0;
			int int1 = this.int_1;
			this.int_1 = int1 + 1;
			byte num = byte0[int1];
			byte[] numArray = this.byte_0;
			int1 = this.int_1;
			this.int_1 = int1 + 1;
			return num | numArray[int1] << 8;
		}

		public float method_5()
		{
			if (this.int_1 + 4 > this.int_0)
			{
				return 0f;
			}
			float single = BitConverter.ToSingle(this.byte_0, this.int_1);
			this.int_1 = this.int_1 + 4;
			return single;
		}

		public uint method_6()
		{
			if (this.int_1 + 4 > this.int_0)
			{
				return (uint)0;
			}
			byte[] byte0 = this.byte_0;
			int int1 = this.int_1;
			this.int_1 = int1 + 1;
			byte num = byte0[int1];
			byte[] numArray = this.byte_0;
			int1 = this.int_1;
			this.int_1 = int1 + 1;
			int num1 = num | numArray[int1] << 8;
			byte[] byte01 = this.byte_0;
			int1 = this.int_1;
			this.int_1 = int1 + 1;
			int num2 = num1 | byte01[int1] << 16;
			byte[] numArray1 = this.byte_0;
			int1 = this.int_1;
			this.int_1 = int1 + 1;
			return (uint)(num2 | numArray1[int1] << 24);
		}

		public ushort method_7()
		{
			if (this.int_1 + 2 > this.int_0)
			{
				return (ushort)0;
			}
			byte[] byte0 = this.byte_0;
			int int1 = this.int_1;
			this.int_1 = int1 + 1;
			byte num = byte0[int1];
			byte[] numArray = this.byte_0;
			int1 = this.int_1;
			this.int_1 = int1 + 1;
			return (ushort)(num | numArray[int1] << 8);
		}

		public byte method_8()
		{
			if (this.int_1 + 1 > this.int_0)
			{
				return (byte)0;
			}
			byte[] byte0 = this.byte_0;
			int int1 = this.int_1;
			this.int_1 = int1 + 1;
			return byte0[int1];
		}

		public sbyte method_9()
		{
			if (this.int_1 + 1 > this.int_0)
			{
				return 0;
			}
			byte[] byte0 = this.byte_0;
			int int1 = this.int_1;
			this.int_1 = int1 + 1;
			return (sbyte)byte0[int1];
		}

		public int ReadInt8()
		{
			if (this.int_1 + 1 > this.int_0)
			{
				return 0;
			}
			byte[] byte0 = this.byte_0;
			int int1 = this.int_1;
			this.int_1 = int1 + 1;
			return byte0[int1];
		}
	}
}