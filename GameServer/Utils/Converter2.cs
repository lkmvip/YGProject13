using ns12;
using System;

namespace ns0
{
	[Attribute4]
	internal static class Converter2
	{
		[Attribute4]
		public static long smethod_0(Random random_0, long long_0, long long_1)
		{
			byte[] bytes = BitConverter.GetBytes(long_0);
			int num = BitConverter.ToInt32(bytes, 4);
			int num1 = BitConverter.ToInt32(new byte[] { bytes[0], bytes[1], bytes[2], bytes[3] }, 0);
			byte[] numArray = BitConverter.GetBytes(long_1);
			int num2 = BitConverter.ToInt32(numArray, 4);
			int num3 = BitConverter.ToInt32(new byte[] { numArray[0], numArray[1], numArray[2], numArray[3] }, 0);
			if (random_0 == null)
			{
				random_0 = new Random();
			}
			int num4 = random_0.Next(num, num2);
			int num5 = 0;
			num5 = (num4 != num ? random_0.Next(0, 2147483647) : random_0.Next(Math.Min(num1, num3), Math.Max(num1, num3)));
			byte[] bytes1 = BitConverter.GetBytes(num5);
			byte[] numArray1 = BitConverter.GetBytes(num4);
			byte[] numArray2 = new byte[8];
			for (int i = 0; i < (int)bytes1.Length; i++)
			{
				numArray2[i] = bytes1[i];
				numArray2[i + 4] = numArray1[i];
			}
			return BitConverter.ToInt64(numArray2, 0);
		}
	}
}