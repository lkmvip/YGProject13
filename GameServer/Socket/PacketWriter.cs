using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace ns12
{
	internal class PacketWriter
	{
		private static byte[] byte_0;

		private int int_0;

		private MemoryStream memoryStream_0;

		private static Stack<PacketWriter> stack_0;

		public long Length
		{
			get
			{
				return this.memoryStream_0.Length;
			}
		}

		public long Position
		{
			get
			{
				return this.memoryStream_0.Position;
			}
			set
			{
				this.memoryStream_0.Position = value;
			}
		}

		public MemoryStream UnderlyingStream
		{
			get
			{
				return this.memoryStream_0;
			}
		}

		static PacketWriter()
		{
			PacketWriter.ZYDNGuard();
		}

		public PacketWriter() : this(32)
		{
		}

		public PacketWriter(int capacity)
		{
			this.memoryStream_0 = new MemoryStream(capacity);
			this.int_0 = capacity;
		}

		public void method_0(bool bool_0)
		{
			this.memoryStream_0.WriteByte((byte)((bool_0 ? 1 : 0)));
		}

		public void method_1(byte byte_1)
		{
			this.memoryStream_0.WriteByte(byte_1);
		}

		public void method_10(byte[] byte_1, int int_1, int int_2)
		{
			this.memoryStream_0.Write(byte_1, int_1, int_2);
		}

		public void method_11(string string_0, int int_1)
		{
			if (string_0 == null)
			{
				Console.WriteLine("Network: Attempted to WriteAsciiFixed() with null value");
				string_0 = string.Empty;
			}
			byte[] bytes = Encoding.ASCII.GetBytes(string_0);
			if ((int)bytes.Length >= int_1)
			{
				this.memoryStream_0.Write(bytes, 0, int_1);
				return;
			}
			this.memoryStream_0.Write(bytes, 0, (int)bytes.Length);
			this.method_18(int_1 - (int)bytes.Length);
		}

		public void method_12(string string_0)
		{
			if (string_0 == null)
			{
				Console.WriteLine("Network: Attempted to WriteAsciiNull() with null value");
				string_0 = string.Empty;
			}
			byte[] bytes = Encoding.ASCII.GetBytes(string_0);
			this.memoryStream_0.Write(bytes, 0, (int)bytes.Length);
			this.memoryStream_0.WriteByte(0);
		}

		public void method_13(string string_0)
		{
			if (string_0 == null)
			{
				Console.WriteLine("Network: Attempted to WriteLittleUniNull() with null value");
				string_0 = string.Empty;
			}
			byte[] bytes = Encoding.Unicode.GetBytes(string_0);
			this.memoryStream_0.Write(bytes, 0, (int)bytes.Length);
			PacketWriter.byte_0[0] = 0;
			PacketWriter.byte_0[1] = 0;
			this.memoryStream_0.Write(PacketWriter.byte_0, 0, 2);
		}

		public void method_14(string string_0, int int_1)
		{
			if (string_0 == null)
			{
				Console.WriteLine("Network: Attempted to WriteLittleUniFixed() with null value");
				string_0 = string.Empty;
			}
			int_1 = int_1 * 2;
			byte[] bytes = Encoding.Unicode.GetBytes(string_0);
			if ((int)bytes.Length >= int_1)
			{
				this.memoryStream_0.Write(bytes, 0, int_1);
				return;
			}
			this.memoryStream_0.Write(bytes, 0, (int)bytes.Length);
			this.method_18(int_1 - (int)bytes.Length);
		}

		public void method_15(string string_0)
		{
			if (string_0 == null)
			{
				Console.WriteLine("Network: Attempted to WriteBigUniNull() with null value");
				string_0 = string.Empty;
			}
			byte[] bytes = Encoding.BigEndianUnicode.GetBytes(string_0);
			this.memoryStream_0.Write(bytes, 0, (int)bytes.Length);
			PacketWriter.byte_0[0] = 0;
			PacketWriter.byte_0[1] = 0;
			this.memoryStream_0.Write(PacketWriter.byte_0, 0, 2);
		}

		public void method_16(string string_0, int int_1)
		{
			if (string_0 == null)
			{
				Console.WriteLine("Network: Attempted to WriteBigUniFixed() with null value");
				string_0 = string.Empty;
			}
			int_1 = int_1 * 2;
			byte[] bytes = Encoding.BigEndianUnicode.GetBytes(string_0);
			if ((int)bytes.Length >= int_1)
			{
				this.memoryStream_0.Write(bytes, 0, int_1);
				return;
			}
			this.memoryStream_0.Write(bytes, 0, (int)bytes.Length);
			this.method_18(int_1 - (int)bytes.Length);
		}

		public void method_17()
		{
			this.method_18(this.int_0 - (int)this.memoryStream_0.Length);
		}

		public void method_18(int int_1)
		{
			if (this.memoryStream_0.Position != this.memoryStream_0.Length)
			{
				this.memoryStream_0.Write(new byte[int_1], 0, int_1);
				return;
			}
			this.memoryStream_0.SetLength(this.memoryStream_0.Length + (long)int_1);
			this.memoryStream_0.Seek((long)0, SeekOrigin.End);
		}

		public long method_19(long long_0, SeekOrigin seekOrigin_0)
		{
			return this.memoryStream_0.Seek(long_0, seekOrigin_0);
		}

		public void method_2(sbyte sbyte_0)
		{
			this.memoryStream_0.WriteByte((byte)sbyte_0);
		}

		public byte[] method_20()
		{
			return this.memoryStream_0.ToArray();
		}

		public void method_3(short short_0)
		{
			PacketWriter.byte_0[0] = (byte)(short_0 >> 8);
			PacketWriter.byte_0[1] = (byte)short_0;
			this.memoryStream_0.Write(PacketWriter.byte_0, 0, 2);
		}

		public void method_4(int int_1)
		{
			this.memoryStream_0.WriteByte((byte)(int_1 & 255));
			this.memoryStream_0.WriteByte((byte)(int_1 >> 8 & 255));
			this.memoryStream_0.WriteByte((byte)(int_1 >> 16 & 255));
			this.memoryStream_0.WriteByte((byte)(int_1 >> 24 & 255));
		}

		public void method_5(int int_1)
		{
			this.memoryStream_0.WriteByte((byte)(int_1 & 255));
			this.memoryStream_0.WriteByte((byte)(int_1 >> 8 & 255));
		}

		public void method_6(int int_1)
		{
			this.memoryStream_0.WriteByte((byte)(int_1 & 255));
		}

		public void method_7(ushort ushort_0)
		{
			PacketWriter.byte_0[0] = (byte)(ushort_0 >> 8);
			PacketWriter.byte_0[1] = (byte)ushort_0;
			this.memoryStream_0.Write(PacketWriter.byte_0, 0, 2);
		}

		public void method_8(int int_1)
		{
			PacketWriter.byte_0[0] = (byte)(int_1 >> 24);
			PacketWriter.byte_0[1] = (byte)(int_1 >> 16);
			PacketWriter.byte_0[2] = (byte)(int_1 >> 8);
			PacketWriter.byte_0[3] = (byte)int_1;
			this.memoryStream_0.Write(PacketWriter.byte_0, 0, 4);
		}

		public void method_9(uint uint_0)
		{
			PacketWriter.byte_0[0] = (byte)(uint_0 >> 24);
			PacketWriter.byte_0[1] = (byte)(uint_0 >> 16);
			PacketWriter.byte_0[2] = (byte)(uint_0 >> 8);
			PacketWriter.byte_0[3] = (byte)uint_0;
			this.memoryStream_0.Write(PacketWriter.byte_0, 0, 4);
		}

		public static PacketWriter smethod_0()
		{
			return PacketWriter.smethod_1(32);
		}

		public static PacketWriter smethod_1(int int_1)
		{
			PacketWriter int1 = null;
			Stack<PacketWriter> stack0 = PacketWriter.stack_0;
			Monitor.Enter(stack0);
			try
			{
				if (PacketWriter.stack_0.Count > 0)
				{
					int1 = PacketWriter.stack_0.Pop();
					if (int1 != null)
					{
						int1.int_0 = int_1;
						int1.memoryStream_0.SetLength((long)0);
					}
				}
			}
			finally
			{
				Monitor.Exit(stack0);
			}
			if (int1 == null)
			{
				int1 = new PacketWriter(int_1);
			}
			return int1;
		}

		public static void smethod_2(PacketWriter class110_0)
		{
			Stack<PacketWriter> stack0 = PacketWriter.stack_0;
			Monitor.Enter(stack0);
			try
			{
				if (PacketWriter.stack_0.Contains(class110_0))
				{
					try
					{
						using (StreamWriter streamWriter = new StreamWriter("neterr.log"))
						{
							streamWriter.WriteLine("{0}\tInstance pool contains writer", DateTime.Now);
						}
					}
					catch
					{
						Console.WriteLine("net error");
					}
				}
				else
				{
					PacketWriter.stack_0.Push(class110_0);
				}
			}
			finally
			{
				Monitor.Exit(stack0);
			}
		}

		private static void ZYDNGuard()
		{
			PacketWriter.stack_0 = new Stack<PacketWriter>();
			PacketWriter.byte_0 = new byte[4];
		}
	}
}