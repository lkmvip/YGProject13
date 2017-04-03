using System;
using System.IO;
using System.Text;

namespace ns10
{
	internal static class Utility
	{
		private static Encoding encoding_0;

		public static Encoding UTF8
		{
			get
			{
				if (Utility.encoding_0 == null)
				{
					Utility.encoding_0 = new UTF8Encoding(false, false);
				}
				return Utility.encoding_0;
			}
		}

		public static void smethod_0(TextWriter textWriter_0, Stream stream_0, int int_0)
		{
			textWriter_0.WriteLine("        0  1  2  3  4  5  6  7   8  9  A  B  C  D  E  F");
			textWriter_0.WriteLine("       -- -- -- -- -- -- -- --  -- -- -- -- -- -- -- --");
			int num = 0;
			int int0 = int_0 >> 4;
			int int01 = int_0 & 15;
			int num1 = 0;
			while (num1 < int0)
			{
				StringBuilder stringBuilder = new StringBuilder(49);
				StringBuilder stringBuilder1 = new StringBuilder(16);
				for (int i = 0; i < 16; i++)
				{
					int num2 = stream_0.ReadByte();
					stringBuilder.Append(num2.ToString("X2"));
					if (i == 7)
					{
						stringBuilder.Append("  ");
					}
					else
					{
						stringBuilder.Append(' ');
					}
					if (num2 < 32 || num2 >= 128)
					{
						stringBuilder1.Append('.');
					}
					else
					{
						stringBuilder1.Append((char)num2);
					}
				}
				textWriter_0.Write(num.ToString("X4"));
				textWriter_0.Write("   ");
				textWriter_0.Write(stringBuilder.ToString());
				textWriter_0.Write("  ");
				textWriter_0.WriteLine(stringBuilder1.ToString());
				num1++;
				num = num + 16;
			}
			if (int01 != 0)
			{
				StringBuilder stringBuilder2 = new StringBuilder(49);
				StringBuilder stringBuilder3 = new StringBuilder(int01);
				for (int j = 0; j < 16; j++)
				{
					if (j >= int01)
					{
						stringBuilder2.Append("   ");
					}
					else
					{
						int num3 = stream_0.ReadByte();
						stringBuilder2.Append(num3.ToString("X2"));
						if (j == 7)
						{
							stringBuilder2.Append("  ");
						}
						else
						{
							stringBuilder2.Append(' ');
						}
						if (num3 < 32 || num3 >= 128)
						{
							stringBuilder3.Append('.');
						}
						else
						{
							stringBuilder3.Append((char)num3);
						}
					}
				}
				textWriter_0.Write(num.ToString("X4"));
				textWriter_0.Write("   ");
				textWriter_0.Write(stringBuilder2.ToString());
				textWriter_0.Write("  ");
				textWriter_0.WriteLine(stringBuilder3.ToString());
			}
		}
	}
}