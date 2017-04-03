namespace ns5
{
      using System;
      using System.Text;

      internal class RC6
      {
            public Encoding encoding_0;
            private const int int_0 = 0x20;
            private const int int_1 = 20;
            private const int int_2 = 4;
            private int int_3;
            private string string_0;
            public string string_1;
            private uint[] uint_0;
            private uint[] uint_1;

            public RC6()
            {
                  this.encoding_0 = Encoding.Unicode;
                  this.IV = 0x10;
                  this.uint_0 = new uint[8 * this.int_3];
            }

            public RC6(int iv)
            {
                  this.encoding_0 = Encoding.Unicode;
                  this.IV = iv;
                  this.uint_0 = new uint[8 * this.int_3];
            }

            private void a()
            {
                  uint num;
                  int num2;
                  uint num3 = 0xb7e15163;
                  uint num4 = 0x9e3779b9;
                  uint num5 = num = 0;
                  int index = num2 = 0;
                  char[] chArray = this.method_3();
                  this.uint_1 = new uint[this.int_3 / 4];
                  for (num2 = 0; num2 < this.int_3; num2++)
                  {
                        uint num8 = (uint)((chArray[num2] & 0xff) << (8 * (num2 % 4)));
                        this.uint_1[num2 / 4] += num8;
                  }
                  this.uint_0[0] = num3;
                  for (num2 = 1; num2 < ((2 * this.int_3) + 4); num2++)
                  {
                        this.uint_0[num2] = this.uint_0[num2 - 1] + num4;
                  }
                  int num7 = 3 * Math.Max(this.uint_1.Length, (2 * this.int_3) + 4);
                  num2 = 0;
                  index = 0;
                  while (num7 > 0)
                  {
                        num5 = this.method_0((this.uint_0[index] + num5) + num, 3, 0x20);
                        this.uint_0[index] = (byte)num5;
                        num += num5;
                        this.uint_1[num2] = this.method_0((this.uint_1[num2] + num5) + num, num5 + num, 0x20);
                        index = (index + 1) % ((2 * this.int_3) + 4);
                        num2 = (num2 + 1) % this.uint_1.Length;
                        num7--;
                  }
            }

            public uint method_0(uint uint_2, uint uint_3, int int_4) =>
                ((uint_2 << ((int)((ulong)(uint_3 & 0xff)))) | (uint_2 >> (int_4 - ((int)((ulong)(uint_3 & 0xff))))));

            public uint method_1(uint uint_2, uint uint_3, int int_4) =>
                ((uint_2 >> ((int)((ulong)(uint_3 & 0xff)))) | (uint_2 << (int_4 - ((int)((ulong)(uint_3 & 0xff))))));

            public int method_2()
            {
                  if (this.int_3 < 0x10)
                  {
                        this.int_3 = 0x10;
                  }
                  if (this.int_3 > 0x20)
                  {
                        this.int_3 = 0x20;
                  }
                  return this.int_3;
            }

            private char[] method_3()
            {
                  string s = this.string_0;
                  s = ((s.Length % this.int_3) != 0) ? s.PadRight(s.Length + (this.int_3 - (s.Length % this.int_3)), '\0') : s;
                  byte[] bytes = Encoding.Convert(Encoding.Unicode, Encoding.ASCII, Encoding.Unicode.GetBytes(s));
                  char[] chars = new char[Encoding.ASCII.GetCharCount(bytes, 0, bytes.Length)];
                  Encoding.ASCII.GetChars(bytes, 0, bytes.Length, chars, 0);
                  return chars;
            }

            public string method_4(string string_2, string string_3)
            {
                  uint num;
                  uint num2;
                  uint num3;
                  uint num4;
                  string_2 = ((string_2.Length % 0x20) != 0) ? string_2.PadRight(string_2.Length + (0x20 - (string_2.Length % 0x20)), '\0') : string_2;
                  this.KEY = string_3;
                  this.a();
                  uint num5 = num4 = 0;
                  uint num6 = num = num2 = num3 = 0;
                  byte[] bytes = Encoding.Unicode.GetBytes(string_2);
                  char[] chars = new char[Encoding.ASCII.GetCharCount(bytes, 0, bytes.Length)];
                  Encoding.ASCII.GetChars(bytes, 0, bytes.Length, chars, 0);
                  byte[] buffer2 = new byte[bytes.Length];
                  for (int i = 0; i < 4; i++)
                  {
                        num6 += (uint)((bytes[2 * i] & 0xff) << (8 * i));
                        num += (uint)((bytes[(2 * i) + 8] & 0xff) << (8 * i));
                        num2 += (uint)((bytes[(2 * i) + 0x10] & 0xff) << (8 * i));
                        num3 += (uint)((bytes[(2 * i) + 0x18] & 0xff) << (8 * i));
                  }
                  num += this.uint_0[0];
                  num3 += this.uint_0[1];
                  for (int j = 1; j <= this.int_3; j++)
                  {
                        num4 = this.method_0(num3 * ((2 * num3) + 1), 5, 0x20);
                        num5 = this.method_0(num * ((2 * num) + 1), 5, 0x20);
                        num6 = this.method_0(num6 ^ num5, num4, 0x20) + this.uint_0[2 * j];
                        num2 = this.method_0(num2 ^ num4, num5, 0x20) + this.uint_0[(2 * j) + 1];
                        num6 = num;
                        num = num2;
                        num2 = num3;
                        num3 = num6;
                  }
                  uint[] numArray = new uint[4];
                  num6 += this.uint_0[0x2a];
                  num2 += this.uint_0[0x2b];
                  numArray[0] = num6;
                  numArray[1] = num;
                  numArray[2] = num2;
                  numArray[3] = num3;
                  for (int k = 0; k < 4; k++)
                  {
                        buffer2[2 * k] = (byte)((numArray[0] >> (8 * k)) & 0xff);
                        buffer2[(2 * k) + 8] = (byte)((numArray[1] >> (8 * k)) & 0xff);
                        buffer2[(2 * k) + 0x10] = (byte)((numArray[2] >> (8 * k)) & 0xff);
                        buffer2[(2 * k) + 0x18] = (byte)((numArray[3] >> (8 * k)) & 0xff);
                  }
                  char[] chArray2 = new char[buffer2.Length];
                  Encoding.Unicode.GetChars(buffer2, 0, buffer2.Length, chArray2, 0);
                  this.string_1 = new string(chArray2, 0, chArray2.Length);
                  this.encoding_0.GetBytes(this.string_1);
                  return this.string_1;
            }

            public string method_5(string string_2, string string_3)
            {
                  uint num;
                  uint num2;
                  uint num3;
                  uint num4;
                  string_2 = ((string_2.Length % 0x20) != 0) ? string_2.PadRight(string_2.Length + (0x20 - (string_2.Length % 0x20)), '\0') : string_2;
                  this.KEY = string_3;
                  this.a();
                  uint num5 = num4 = 0;
                  uint num6 = num = num2 = num3 = 0;
                  byte[] bytes = this.encoding_0.GetBytes(string_2);
                  byte[] buffer2 = new byte[bytes.Length];
                  for (int i = 0; i < 4; i++)
                  {
                        num6 += (uint)((bytes[2 * i] & 0xff) << (8 * i));
                        num += (uint)((bytes[(2 * i) + 8] & 0xff) << (8 * i));
                        num2 += (uint)((bytes[(2 * i) + 0x10] & 0xff) << (8 * i));
                        num3 += (uint)((bytes[(2 * i) + 0x18] & 0xff) << (8 * i));
                  }
                  num2 -= this.uint_0[0x2b];
                  num6 -= this.uint_0[0x2a];
                  for (int j = 1; j <= this.int_3; j++)
                  {
                        num3 = num2;
                        num2 = num;
                        num = num6;
                        num6 = num3;
                        num4 = this.method_0(num3 * ((2 * num3) + 1), 5, 0x20);
                        num5 = this.method_0(num * ((2 * num) + 1), 5, 0x20);
                        num2 = this.method_1(num2 - this.uint_0[(2 * (this.int_3 - j)) + 3], num5, 0x20) ^ num4;
                        num6 = this.method_1(num6 - this.uint_0[(2 * (this.int_3 - j)) + 2], num4, 0x20) ^ num5;
                  }
                  num3 -= this.uint_0[1];
                  num -= this.uint_0[0];
                  for (int k = 0; k < 4; k++)
                  {
                        buffer2[2 * k] = (byte)((num6 >> (8 * k)) & 0xff);
                        buffer2[(2 * k) + 8] = (byte)((num >> (8 * k)) & 0xff);
                        buffer2[(2 * k) + 0x10] = (byte)((num2 >> (8 * k)) & 0xff);
                        buffer2[(2 * k) + 0x18] = (byte)((num3 >> (8 * k)) & 0xff);
                  }
                  char[] chars = new char[this.encoding_0.GetCharCount(buffer2, 0, buffer2.Length)];
                  this.encoding_0.GetChars(buffer2, 0, buffer2.Length, chars, 0);
                  this.string_1 = new string(chars, 0, chars.Length);
                  this.encoding_0.GetBytes(this.string_1);
                  return this.string_1;
            }

            public int IV
            {
                  get
                  {
                        return this.int_3;
                  }
                  set
                  {
                        this.int_3 = value;
                  }
            }

            public string KEY
            {
                  get
                  {
                        return this.string_0;
                  }
                  set
                  {
                        this.string_0 = value;
                  }
            }
      }
}

