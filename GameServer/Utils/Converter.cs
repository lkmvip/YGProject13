using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ns12
{
	internal class Converter
	{
		public static Dictionary<string, byte[]> dictionary_0;

		static Converter()
		{
			Converter.ZYDNGuard();
		}

		public Converter()
		{
		}

		public static byte[] hexStringToByte(string string_0)
		{
			byte[] numArray;
			string str;
			str = (string_0.Length > 40 ? string_0.Remove(40, string_0.Length - 40) : string_0);
			if (!Converter.dictionary_0.TryGetValue(str, out numArray))
			{
				numArray = Converter.smethod_28(string_0);
				Converter.dictionary_0.Add(str, numArray);
			}
			byte[] numArray1 = new byte[(int)numArray.Length];
			numArray.CopyTo(numArray1, 0);
			return numArray1;
		}

		public static byte smethod_0(byte[] byte_0, ref int int_0)
		{
			int int0 = int_0;
			int_0 = int0 + 1;
			return byte_0[int0];
		}

		public static void smethod_1(byte byte_0, byte[] byte_1, ref int int_0)
		{
			int int0 = int_0;
			int_0 = int0 + 1;
			byte_1[int0] = byte_0;
		}

		public static void smethod_10(ushort ushort_0, byte[] byte_0, ref int int_0)
		{
			int int0 = int_0;
			int_0 = int0 + 1;
			byte_0[int0] = (byte)(ushort_0 & 255);
			int0 = int_0;
			int_0 = int0 + 1;
			byte_0[int0] = (byte)(ushort_0 >> 8 & 255);
		}

		public static void smethod_11(uint uint_0, byte[] byte_0, ref int int_0)
		{
			int int0 = int_0;
			int_0 = int0 + 1;
			byte_0[int0] = (byte)(uint_0 & 255);
			int0 = int_0;
			int_0 = int0 + 1;
			byte_0[int0] = (byte)(uint_0 >> 8 & 255);
			int0 = int_0;
			int_0 = int0 + 1;
			byte_0[int0] = (byte)(uint_0 >> 16 & 255);
			int0 = int_0;
			int_0 = int0 + 1;
			byte_0[int0] = (byte)(uint_0 >> 24 & 255);
		}

		public static void smethod_12(ulong ulong_0, byte[] byte_0, ref int int_0)
		{
			int int0 = int_0;
			int_0 = int0 + 1;
			byte_0[int0] = (byte)(ulong_0 & (long)255);
			int0 = int_0;
			int_0 = int0 + 1;
			byte_0[int0] = (byte)(ulong_0 >> 8 & (long)255);
			int0 = int_0;
			int_0 = int0 + 1;
			byte_0[int0] = (byte)(ulong_0 >> 16 & (long)255);
			int0 = int_0;
			int_0 = int0 + 1;
			byte_0[int0] = (byte)(ulong_0 >> 24 & (long)255);
			int0 = int_0;
			int_0 = int0 + 1;
			byte_0[int0] = (byte)(ulong_0 >> 32 & (long)255);
			int0 = int_0;
			int_0 = int0 + 1;
			byte_0[int0] = (byte)(ulong_0 >> 40 & (long)255);
			int0 = int_0;
			int_0 = int0 + 1;
			byte_0[int0] = (byte)(ulong_0 >> 48 & (long)255);
			int0 = int_0;
			int_0 = int0 + 1;
			byte_0[int0] = (byte)(ulong_0 >> 56 & (long)255);
		}

		public static void smethod_13(BitArray bitArray_0, byte[] byte_0, ref int int_0, int int_1)
		{
			bitArray_0.CopyTo(byte_0, int_0);
			int_0 = int_0 + int_1;
		}

		public static double smethod_14(byte[] byte_0, ref int int_0)
		{
			int_0 = int_0 + 8;
			return BitConverter.ToDouble(byte_0, int_0);
		}

		public static float smethod_15(byte[] byte_0, ref int int_0)
		{
			int_0 = int_0 + 4;
			return BitConverter.ToSingle(byte_0, int_0);
		}

		public static short smethod_16(byte[] byte_0, ref int int_0)
		{
			int_0 = int_0 + 2;
			return BitConverter.ToInt16(byte_0, int_0);
		}

		public static int smethod_17(byte[] byte_0, ref int int_0)
		{
			int_0 = int_0 + 4;
			return BitConverter.ToInt32(byte_0, int_0);
		}

		public static long smethod_18(byte[] byte_0, ref int int_0)
		{
			int_0 = int_0 + 8;
			return BitConverter.ToInt64(byte_0, int_0);
		}

		public static ushort smethod_19(byte[] byte_0, ref int int_0)
		{
			int_0 = int_0 + 2;
			return BitConverter.ToUInt16(byte_0, int_0);
		}

		public static void smethod_2(BitArray bitArray_0, byte[] byte_0, ref int int_0)
		{
			bitArray_0.CopyTo(byte_0, int_0);
			int_0 = int_0 + bitArray_0.Length / 8;
		}

		public static uint smethod_20(byte[] byte_0, ref int int_0)
		{
			int_0 = int_0 + 4;
			return BitConverter.ToUInt32(byte_0, int_0);
		}

		public static ulong smethod_21(byte[] byte_0, ref int int_0)
		{
			int_0 = int_0 + 8;
			return BitConverter.ToUInt64(byte_0, int_0);
		}

		public static void smethod_22(ulong ulong_0, byte[] byte_0, ref int int_0)
		{
			byte num = 0;
			byte[] ulong0 = new byte[8];
			int num1 = 0;
			for (int i = 0; i < 8; i++)
			{
				if ((ulong_0 >> (8 * i & 63) & (long)255) != 0)
				{
					num = (byte)(num + (byte)Math.Pow(2, (double)i));
					ulong0[num1] = (byte)(ulong_0 >> (8 * i & 63) & (long)255);
					num1++;
				}
			}
			int int0 = int_0;
			int_0 = int0 + 1;
			byte_0[int0] = num;
			Buffer.BlockCopy(ulong0, 0, byte_0, int_0, num1);
			int_0 = int_0 + num1;
		}

		public static ulong smethod_23(byte[] byte_0, int int_0)
		{
			int int0 = int_0;
			int_0 = int0 + 1;
			byte byte0 = byte_0[int0];
			byte[] numArray = new byte[8];
			for (int i = 0; i < 8; i++)
			{
				if ((byte)(byte0 >> (i & 31) & 1) == 0)
				{
					numArray[i] = 0;
				}
				else
				{
					int num = int_0;
					int_0 = num + 1;
					numArray[i] = byte_0[num];
				}
			}
			return BitConverter.ToUInt64(numArray, 0);
		}

		public static string smethod_24(byte[] byte_0)
		{
			StringBuilder stringBuilder = new StringBuilder((int)byte_0.Length * 2);
			byte[] byte0 = byte_0;
			for (int i = 0; i < (int)byte0.Length; i++)
			{
				byte num = byte0[i];
				stringBuilder.Append(num.ToString("X2"));
			}
			return stringBuilder.ToString();
		}

		public static string smethod_25(byte[] byte_0)
		{
			StringBuilder stringBuilder = new StringBuilder((int)byte_0.Length * 2);
			byte[] byte0 = byte_0;
			for (int i = 0; i < (int)byte0.Length; i++)
			{
				byte num = byte0[i];
				stringBuilder.Append(num.ToString("X2"));
			}
			return string.Concat("0x", stringBuilder.ToString());
		}

		public static string smethod_26(byte[] byte_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			byte[] byte0 = byte_0;
			for (int i = 0; i < (int)byte0.Length; i++)
			{
				byte num = byte0[i];
				stringBuilder.Append(Convert.ToString((short)num, 16).PadLeft(2, '0').ToUpper());
			}
			return stringBuilder.ToString();
		}

		public static byte[] smethod_28(string string_0)
		{
			byte[] numArray;
			try
			{
				int length = string_0.Length / 2;
				byte[] num = new byte[length];
				for (int i = 0; i < length; i++)
				{
					num[i] = Convert.ToByte(string_0.Substring(i * 2, 2), 16);
				}
				numArray = num;
			}
			catch (Exception exception)
			{
				numArray = new byte[string_0.Length];
			}
			return numArray;
		}

		private static byte smethod_29(char char_0)
		{
			return (byte)"0123456789ABCDEF".IndexOf(char_0);
		}

		public static void smethod_3(double double_0, byte[] byte_0, ref int int_0)
		{
			byte[] bytes = BitConverter.GetBytes(double_0);
			Buffer.BlockCopy(bytes, 0, byte_0, int_0, (int)bytes.Length);
			int_0 = int_0 + (int)bytes.Length;
		}

		public static int smethod_30(string string_0)
		{
			string str = string_0.Substring(4, 2);
			string str1 = string_0.Substring(2, 2);
			string str2 = string_0.Substring(0, 2);
			return int.Parse(string.Concat(str, str1, str2), NumberStyles.HexNumber);
		}

		public static int smethod_31(string string_0)
		{
			string str = string_0.Substring(6, 2);
			string str1 = string_0.Substring(4, 2);
			string str2 = string_0.Substring(2, 2);
			string str3 = string_0.Substring(0, 2);
			return int.Parse(string.Concat(str, str1, str2, str3), NumberStyles.HexNumber);
		}

		public static void smethod_4(short short_0, byte[] byte_0, ref int int_0)
		{
			int int0 = int_0;
			int_0 = int0 + 1;
			byte_0[int0] = (byte)(short_0 & 255);
			int0 = int_0;
			int_0 = int0 + 1;
			byte_0[int0] = (byte)(short_0 >> 8 & 255);
		}

		public static void smethod_5(int int_0, byte[] byte_0, ref int int_1)
		{
			int int1 = int_1;
			int_1 = int1 + 1;
			byte_0[int1] = (byte)(int_0 & 255);
			int1 = int_1;
			int_1 = int1 + 1;
			byte_0[int1] = (byte)(int_0 >> 8 & 255);
			int1 = int_1;
			int_1 = int1 + 1;
			byte_0[int1] = (byte)(int_0 >> 16 & 255);
			int1 = int_1;
			int_1 = int1 + 1;
			byte_0[int1] = (byte)(int_0 >> 24 & 255);
		}

		public static void smethod_6(long long_0, byte[] byte_0, ref int int_0)
		{
			Converter.smethod_12((ulong)long_0, byte_0, ref int_0);
		}

		public static void smethod_7(object object_0, byte[] byte_0, ref int int_0)
		{
			if (object_0 is int)
			{
				Converter.smethod_5((int)object_0, byte_0, ref int_0);
			}
			if (object_0 is uint)
			{
				Converter.smethod_11((uint)object_0, byte_0, ref int_0);
				return;
			}
			if (object_0 is ulong)
			{
				Converter.smethod_12((ulong)object_0, byte_0, ref int_0);
				return;
			}
			if (object_0 is long)
			{
				Converter.smethod_6((long)object_0, byte_0, ref int_0);
				return;
			}
			if (object_0 is ushort)
			{
				Converter.smethod_10((ushort)object_0, byte_0, ref int_0);
				return;
			}
			if (object_0 is short)
			{
				Converter.smethod_4((short)object_0, byte_0, ref int_0);
				return;
			}
			if (object_0 is byte)
			{
				Converter.smethod_1((byte)object_0, byte_0, ref int_0);
				return;
			}
			if (object_0 is string)
			{
				Converter.smethod_9((string)object_0, byte_0, ref int_0);
			}
		}

		public static void smethod_8(float float_0, byte[] byte_0, ref int int_0)
		{
			byte[] bytes = BitConverter.GetBytes(float_0);
			Buffer.BlockCopy(bytes, 0, byte_0, int_0, (int)bytes.Length);
			int_0 = int_0 + (int)bytes.Length;
		}

		public static void smethod_9(string string_0, byte[] byte_0, ref int int_0)
		{
			char[] charArray = string_0.ToCharArray();
			for (int i = 0; i < (int)charArray.Length; i++)
			{
				char chr = charArray[i];
				int int0 = int_0;
				int_0 = int0 + 1;
				byte_0[int0] = (byte)chr;
			}
		}

		private static void ZYDNGuard()
		{
			Converter.dictionary_0 = new Dictionary<string, byte[]>();
		}
	}
}