namespace ns7
{
      using System;

      internal class BigInteger
      {
            private const int int_0 = 70;
            public static readonly int[] int_1;
            public int int_2;
            private uint[] uint_0;

            static BigInteger()
            {
                  ZYDNGuard();
            }

            public BigInteger()
            {
                  this.uint_0 = new uint[70];
                  this.int_2 = 1;
            }

            public BigInteger(BigInteger bi)
            {
                  this.uint_0 = new uint[70];
                  this.int_2 = bi.int_2;
                  for (int i = 0; i < this.int_2; i++)
                  {
                        this.uint_0[i] = bi.uint_0[i];
                  }
            }

            public BigInteger(long value)
            {
                  this.uint_0 = new uint[70];
                  long num = value;
                  this.int_2 = 0;
                  while (value != 0)
                  {
                        if (this.int_2 >= 70)
                        {
                              break;
                        }
                        this.uint_0[this.int_2] = (uint)(((ulong)value) & 0xffffffffL);
                        value = value >> 0x20;
                        this.int_2++;
                  }
                  if (num > 0L)
                  {
                        if ((value != 0) || ((this.uint_0[0x45] & 0x80000000) != 0))
                        {
                              throw new ArithmeticException("Positive overflow in constructor.");
                        }
                  }
                  else if ((num < 0L) && ((value != -1L) || ((this.uint_0[this.int_2 - 1] & 0x80000000) == 0)))
                  {
                        throw new ArithmeticException("Negative underflow in constructor.");
                  }
                  if (this.int_2 == 0)
                  {
                        this.int_2 = 1;
                  }
            }

            public BigInteger(ulong value)
            {
                  this.uint_0 = new uint[70];
                  this.int_2 = 0;
                  while (value != 0)
                  {
                        if (this.int_2 >= 70)
                        {
                              break;
                        }
                        this.uint_0[this.int_2] = (uint)(value & 0xffffffffL);
                        value = value >> 0x20;
                        this.int_2++;
                  }
                  if ((value != 0) || ((this.uint_0[0x45] & 0x80000000) != 0))
                  {
                        throw new ArithmeticException("Positive overflow in constructor.");
                  }
                  if (this.int_2 == 0)
                  {
                        this.int_2 = 1;
                  }
            }

            public BigInteger(byte[] inData)
            {
                  this.int_2 = inData.Length >> 2;
                  int num = inData.Length & 3;
                  if (num != 0)
                  {
                        this.int_2++;
                  }
                  if (this.int_2 > 70)
                  {
                        throw new ArithmeticException("Byte overflow in constructor.");
                  }
                  this.uint_0 = new uint[70];
                  int index = inData.Length - 1;
                  for (int i = 0; index >= 3; i++)
                  {
                        this.uint_0[i] = (uint)((((inData[index - 3] << 0x18) + (inData[index - 2] << 0x10)) + (inData[index - 1] << 8)) + inData[index]);
                        index -= 4;
                  }
                  switch (num)
                  {
                        case 1:
                              this.uint_0[this.int_2 - 1] = inData[0];
                              break;

                        case 2:
                              this.uint_0[this.int_2 - 1] = (uint)((inData[0] << 8) + inData[1]);
                              break;

                        case 3:
                              this.uint_0[this.int_2 - 1] = (uint)(((inData[0] << 0x10) + (inData[1] << 8)) + inData[2]);
                              break;
                  }
                  while (this.int_2 > 1)
                  {
                        if (this.uint_0[this.int_2 - 1] != 0)
                        {
                              break;
                        }
                        this.int_2--;
                  }
            }

            public BigInteger(uint[] inData)
            {
                  this.int_2 = inData.Length;
                  if (this.int_2 > 70)
                  {
                        throw new ArithmeticException("Byte overflow in constructor.");
                  }
                  this.uint_0 = new uint[70];
                  int index = this.int_2 - 1;
                  for (int i = 0; index >= 0; i++)
                  {
                        this.uint_0[i] = inData[index];
                        index--;
                  }
                  while (this.int_2 > 1)
                  {
                        if (this.uint_0[this.int_2 - 1] != 0)
                        {
                              break;
                        }
                        this.int_2--;
                  }
            }

            public BigInteger(string value, int radix)
            {
                  BigInteger integer = new BigInteger(1L);
                  BigInteger integer2 = new BigInteger();
                  value = value.ToUpper().Trim();
                  int num = 0;
                  if (value[0] == '-')
                  {
                        num = 1;
                  }
                  for (int i = value.Length - 1; i >= num; i--)
                  {
                        int num3 = value[i];
                        if ((num3 >= 0x30) && (num3 <= 0x39))
                        {
                              num3 -= 0x30;
                        }
                        else if ((num3 >= 0x41) && (num3 <= 90))
                        {
                              num3 = (num3 - 0x41) + 10;
                        }
                        else
                        {
                              num3 = 0x98967f;
                        }
                        if (num3 >= radix)
                        {
                              throw new ArithmeticException("Invalid string in constructor.");
                        }
                        if (value[0] == '-')
                        {
                              num3 = -num3;
                        }
                        integer2 = smethod_4(integer2, smethod_8(integer, smethod_2(num3)));
                        if ((i - 1) >= num)
                        {
                              integer = smethod_8(integer, smethod_2(radix));
                        }
                  }
                  if (value[0] == '-')
                  {
                        if ((integer2.uint_0[0x45] & 0x80000000) == 0)
                        {
                              throw new ArithmeticException("Negative underflow in constructor.");
                        }
                  }
                  else if ((integer2.uint_0[0x45] & 0x80000000) != 0)
                  {
                        throw new ArithmeticException("Positive overflow in constructor.");
                  }
                  this.uint_0 = new uint[70];
                  for (int j = 0; j < integer2.int_2; j++)
                  {
                        this.uint_0[j] = integer2.uint_0[j];
                  }
                  this.int_2 = integer2.int_2;
            }

            public BigInteger(byte[] inData, int inLen)
            {
                  this.int_2 = inLen >> 2;
                  int num = inLen & 3;
                  if (num != 0)
                  {
                        this.int_2++;
                  }
                  if ((this.int_2 > 70) || (inLen > inData.Length))
                  {
                        throw new ArithmeticException("Byte overflow in constructor.");
                  }
                  this.uint_0 = new uint[70];
                  int index = inLen - 1;
                  for (int i = 0; index >= 3; i++)
                  {
                        this.uint_0[i] = (uint)((((inData[index - 3] << 0x18) + (inData[index - 2] << 0x10)) + (inData[index - 1] << 8)) + inData[index]);
                        index -= 4;
                  }
                  switch (num)
                  {
                        case 1:
                              this.uint_0[this.int_2 - 1] = inData[0];
                              break;

                        case 2:
                              this.uint_0[this.int_2 - 1] = (uint)((inData[0] << 8) + inData[1]);
                              break;

                        case 3:
                              this.uint_0[this.int_2 - 1] = (uint)(((inData[0] << 0x10) + (inData[1] << 8)) + inData[2]);
                              break;
                  }
                  if (this.int_2 == 0)
                  {
                        this.int_2 = 1;
                  }
                  while (this.int_2 > 1)
                  {
                        if (this.uint_0[this.int_2 - 1] != 0)
                        {
                              break;
                        }
                        this.int_2--;
                  }
            }

            public override bool Equals(object obj)
            {
                  BigInteger integer = (BigInteger)obj;
                  if (this.int_2 != integer.int_2)
                  {
                        return false;
                  }
                  for (int i = 0; i < this.int_2; i++)
                  {
                        if (this.uint_0[i] != integer.uint_0[i])
                        {
                              return false;
                        }
                  }
                  return true;
            }

            public override int GetHashCode() =>
                this.ToString().GetHashCode();

            public BigInteger method_0(BigInteger class117_0)
            {
                  if (smethod_17(this, class117_0))
                  {
                        return new BigInteger(this);
                  }
                  return new BigInteger(class117_0);
            }

            public BigInteger method_1(BigInteger class117_0)
            {
                  if (smethod_18(this, class117_0))
                  {
                        return new BigInteger(this);
                  }
                  return new BigInteger(class117_0);
            }

            public bool method_10(int int_3)
            {
                  BigInteger integer;
                  if ((this.uint_0[0x45] & 0x80000000) != 0)
                  {
                        integer = smethod_14(this);
                  }
                  else
                  {
                        integer = this;
                  }
                  if (integer.int_2 == 1)
                  {
                        if ((integer.uint_0[0] == 0) || (integer.uint_0[0] == 1))
                        {
                              return false;
                        }
                        if ((integer.uint_0[0] == 2) || (integer.uint_0[0] == 3))
                        {
                              return true;
                        }
                  }
                  if ((integer.uint_0[0] & 1) == 0)
                  {
                        return false;
                  }
                  int num = integer.method_9();
                  BigInteger integer2 = new BigInteger();
                  BigInteger integer3 = smethod_6(integer, new BigInteger(1L));
                  Random random = new Random();
                  for (int i = 0; i < int_3; i++)
                  {
                        bool flag = false;
                        while (!flag)
                        {
                              int num4 = 0;
                              while (num4 < 2)
                              {
                                    num4 = (int)(random.NextDouble() * num);
                              }
                              integer2.method_8(num4, random);
                              int num5 = integer2.int_2;
                              if ((num5 > 1) || ((num5 == 1) && (integer2.uint_0[0] != 1)))
                              {
                                    flag = true;
                              }
                        }
                        BigInteger integer4 = integer2.method_7(integer);
                        if ((integer4.int_2 == 1) && (integer4.uint_0[0] != 1))
                        {
                              return false;
                        }
                        BigInteger integer5 = integer2.method_5(integer3, integer);
                        int num3 = integer5.int_2;
                        if ((num3 > 1) || ((num3 == 1) && (integer5.uint_0[0] != 1)))
                        {
                              return false;
                        }
                  }
                  return true;
            }

            public bool method_11(int int_3)
            {
                  BigInteger integer;
                  if ((this.uint_0[0x45] & 0x80000000) != 0)
                  {
                        integer = smethod_14(this);
                  }
                  else
                  {
                        integer = this;
                  }
                  if (integer.int_2 == 1)
                  {
                        if ((integer.uint_0[0] == 0) || (integer.uint_0[0] == 1))
                        {
                              return false;
                        }
                        if ((integer.uint_0[0] == 2) || (integer.uint_0[0] == 3))
                        {
                              return true;
                        }
                  }
                  if ((integer.uint_0[0] & 1) == 0)
                  {
                        return false;
                  }
                  BigInteger integer2 = smethod_6(integer, new BigInteger(1L));
                  int num = 0;
                  for (int i = 0; i < integer2.int_2; i++)
                  {
                        uint num4 = 1;
                        for (int k = 0; k < 0x20; k++)
                        {
                              if ((integer2.uint_0[i] & num4) != 0)
                              {
                                    goto Label_00A5;
                              }
                              num4 = num4 << 1;
                              num++;
                        }
                        continue;
                        Label_00A5:
                        i = integer2.int_2;
                  }
                  BigInteger integer3 = smethod_11(integer2, num);
                  int num2 = integer.method_9();
                  BigInteger integer4 = new BigInteger();
                  Random random = new Random();
                  for (int j = 0; j < int_3; j++)
                  {
                        bool flag = false;
                        while (!flag)
                        {
                              int num8 = 0;
                              while (num8 < 2)
                              {
                                    num8 = (int)(random.NextDouble() * num2);
                              }
                              integer4.method_8(num8, random);
                              int num9 = integer4.int_2;
                              if ((num9 > 1) || ((num9 == 1) && (integer4.uint_0[0] != 1)))
                              {
                                    flag = true;
                              }
                        }
                        BigInteger integer5 = integer4.method_7(integer);
                        if ((integer5.int_2 == 1) && (integer5.uint_0[0] != 1))
                        {
                              return false;
                        }
                        BigInteger integer6 = integer4.method_5(integer3, integer);
                        bool flag2 = false;
                        if ((integer6.int_2 == 1) && (integer6.uint_0[0] == 1))
                        {
                              flag2 = true;
                        }
                        for (int m = 0; !flag2; m++)
                        {
                              if (m >= num)
                              {
                                    break;
                              }
                              if (smethod_15(integer6, integer2))
                              {
                                    goto Label_01AB;
                              }
                              integer6 = smethod_24(smethod_8(integer6, integer6), integer);
                        }
                        goto Label_01AE;
                        Label_01AB:
                        flag2 = true;
                        Label_01AE:
                        if (!flag2)
                        {
                              return false;
                        }
                  }
                  return true;
            }

            public bool method_12(int int_3)
            {
                  BigInteger integer;
                  if ((this.uint_0[0x45] & 0x80000000) != 0)
                  {
                        integer = smethod_14(this);
                  }
                  else
                  {
                        integer = this;
                  }
                  if (integer.int_2 == 1)
                  {
                        if ((integer.uint_0[0] == 0) || (integer.uint_0[0] == 1))
                        {
                              return false;
                        }
                        if ((integer.uint_0[0] == 2) || (integer.uint_0[0] == 3))
                        {
                              return true;
                        }
                  }
                  if ((integer.uint_0[0] & 1) == 0)
                  {
                        return false;
                  }
                  int num = integer.method_9();
                  BigInteger integer2 = new BigInteger();
                  BigInteger integer3 = smethod_6(integer, smethod_2(1));
                  BigInteger integer4 = smethod_11(integer3, 1);
                  Random random = new Random();
                  for (int i = 0; i < int_3; i++)
                  {
                        bool flag = false;
                        while (!flag)
                        {
                              int num3 = 0;
                              while (num3 < 2)
                              {
                                    num3 = (int)(random.NextDouble() * num);
                              }
                              integer2.method_8(num3, random);
                              int num4 = integer2.int_2;
                              if ((num4 > 1) || ((num4 == 1) && (integer2.uint_0[0] != 1)))
                              {
                                    flag = true;
                              }
                        }
                        BigInteger integer5 = integer2.method_7(integer);
                        if ((integer5.int_2 == 1) && (integer5.uint_0[0] != 1))
                        {
                              return false;
                        }
                        BigInteger integer6 = integer2.method_5(integer4, integer);
                        if (smethod_15(integer6, integer3))
                        {
                              integer6 = smethod_2(-1);
                        }
                        BigInteger integer7 = smethod_2(smethod_28(integer2, integer));
                        if (smethod_16(integer6, integer7))
                        {
                              return false;
                        }
                  }
                  return true;
            }

            public bool method_13()
            {
                  BigInteger integer;
                  if ((this.uint_0[0x45] & 0x80000000) != 0)
                  {
                        integer = smethod_14(this);
                  }
                  else
                  {
                        integer = this;
                  }
                  if (integer.int_2 == 1)
                  {
                        if ((integer.uint_0[0] == 0) || (integer.uint_0[0] == 1))
                        {
                              return false;
                        }
                        if ((integer.uint_0[0] == 2) || (integer.uint_0[0] == 3))
                        {
                              return true;
                        }
                  }
                  if ((integer.uint_0[0] & 1) == 0)
                  {
                        return false;
                  }
                  return this.method_14(integer);
            }

            private bool method_14(BigInteger class117_0)
            {
                  long num = 5L;
                  long num2 = -1L;
                  long num3 = 0L;
                  bool flag = false;
                  while (!flag)
                  {
                        int num7 = smethod_28(smethod_0(num), class117_0);
                        if (num7 == -1)
                        {
                              flag = true;
                        }
                        else
                        {
                              if ((num7 == 0) && smethod_18(smethod_0(Math.Abs(num)), class117_0))
                              {
                                    return false;
                              }
                              if (num3 == 20L)
                              {
                                    BigInteger integer1 = class117_0.method_24();
                                    if (smethod_15(smethod_8(integer1, integer1), class117_0))
                                    {
                                          return false;
                                    }
                              }
                              num = (Math.Abs(num) + 2L) * num2;
                              num2 = -num2;
                        }
                        num3 += 1L;
                  }
                  long num4 = (1L - num) >> 2;
                  BigInteger integer = smethod_4(class117_0, smethod_2(1));
                  int num5 = 0;
                  for (int i = 0; i < integer.int_2; i++)
                  {
                        uint num9 = 1;
                        for (int k = 0; k < 0x20; k++)
                        {
                              if ((integer.uint_0[i] & num9) != 0)
                              {
                                    goto Label_00BF;
                              }
                              num9 = num9 << 1;
                              num5++;
                        }
                        continue;
                        Label_00BF:
                        i = integer.int_2;
                  }
                  BigInteger integer2 = smethod_11(integer, num5);
                  BigInteger integer3 = new BigInteger();
                  int index = class117_0.int_2 << 1;
                  integer3.uint_0[index] = 1;
                  integer3.int_2 = index + 1;
                  integer3 = smethod_23(integer3, class117_0);
                  BigInteger[] integerArray = smethod_31(smethod_2(1), smethod_0(num4), integer2, class117_0, integer3, 0);
                  bool flag2 = false;
                  if (((integerArray[0].int_2 == 1) && (integerArray[0].uint_0[0] == 0)) || ((integerArray[1].int_2 == 1) && (integerArray[1].uint_0[0] == 0)))
                  {
                        flag2 = true;
                  }
                  for (int j = 1; j < num5; j++)
                  {
                        if (!flag2)
                        {
                              integerArray[1] = class117_0.method_6(smethod_8(integerArray[1], integerArray[1]), class117_0, integer3);
                              integerArray[1] = smethod_24(smethod_6(integerArray[1], smethod_9(integerArray[2], 1)), class117_0);
                              if ((integerArray[1].int_2 == 1) && (integerArray[1].uint_0[0] == 0))
                              {
                                    flag2 = true;
                              }
                        }
                        integerArray[2] = class117_0.method_6(smethod_8(integerArray[2], integerArray[2]), class117_0, integer3);
                  }
                  if (flag2)
                  {
                        BigInteger integer4 = class117_0.method_7(smethod_0(num4));
                        if ((integer4.int_2 != 1) || (integer4.uint_0[0] != 1))
                        {
                              return flag2;
                        }
                        if ((integerArray[2].uint_0[0x45] & 0x80000000) != 0)
                        {
                              BigInteger[] integerArray2;
                              (integerArray2 = integerArray)[2] = smethod_4(integerArray2[2], class117_0);
                        }
                        BigInteger integer5 = smethod_24(smethod_0(num4 * smethod_28(smethod_0(num4), class117_0)), class117_0);
                        if ((integer5.uint_0[0x45] & 0x80000000) != 0)
                        {
                              integer5 = smethod_4(integer5, class117_0);
                        }
                        if (smethod_16(integerArray[2], integer5))
                        {
                              flag2 = false;
                        }
                  }
                  return flag2;
            }

            public bool method_15(int int_3)
            {
                  BigInteger integer;
                  if ((this.uint_0[0x45] & 0x80000000) != 0)
                  {
                        integer = smethod_14(this);
                  }
                  else
                  {
                        integer = this;
                  }
                  for (int i = 0; i < int_1.Length; i++)
                  {
                        BigInteger integer2 = smethod_2(int_1[i]);
                        if (smethod_19(integer2, integer))
                        {
                              break;
                        }
                        if (smethod_24(integer, integer2).method_17() == 0)
                        {
                              return false;
                        }
                  }
                  return integer.method_11(int_3);
            }

            public bool method_16()
            {
                  BigInteger integer;
                  if ((this.uint_0[0x45] & 0x80000000) != 0)
                  {
                        integer = smethod_14(this);
                  }
                  else
                  {
                        integer = this;
                  }
                  if (integer.int_2 == 1)
                  {
                        if ((integer.uint_0[0] == 0) || (integer.uint_0[0] == 1))
                        {
                              return false;
                        }
                        if ((integer.uint_0[0] == 2) || (integer.uint_0[0] == 3))
                        {
                              return true;
                        }
                  }
                  if ((integer.uint_0[0] & 1) == 0)
                  {
                        return false;
                  }
                  for (int i = 0; i < int_1.Length; i++)
                  {
                        BigInteger integer5 = smethod_2(int_1[i]);
                        if (smethod_19(integer5, integer))
                        {
                              break;
                        }
                        if (smethod_24(integer, integer5).method_17() == 0)
                        {
                              return false;
                        }
                  }
                  BigInteger integer2 = smethod_6(integer, new BigInteger(1L));
                  int num = 0;
                  for (int j = 0; j < integer2.int_2; j++)
                  {
                        uint num5 = 1;
                        for (int k = 0; k < 0x20; k++)
                        {
                              if ((integer2.uint_0[j] & num5) != 0)
                              {
                                    goto Label_00E5;
                              }
                              num5 = num5 << 1;
                              num++;
                        }
                        continue;
                        Label_00E5:
                        j = integer2.int_2;
                  }
                  BigInteger integer3 = smethod_11(integer2, num);
                  integer.method_9();
                  BigInteger integer4 = smethod_2(2).method_5(integer3, integer);
                  bool flag = false;
                  if ((integer4.int_2 == 1) && (integer4.uint_0[0] == 1))
                  {
                        flag = true;
                  }
                  int num2 = 0;
                  while (true)
                  {
                        if (flag || (num2 >= num))
                        {
                              break;
                        }
                        if (smethod_15(integer4, integer2))
                        {
                              flag = true;
                              break;
                        }
                        integer4 = smethod_24(smethod_8(integer4, integer4), integer);
                        num2++;
                  }
                  if (flag)
                  {
                        flag = this.method_14(integer);
                  }
                  return flag;
            }

            public int method_17() =>
                ((int)this.uint_0[0]);

            public long method_18()
            {
                  long num = 0L;
                  num = this.uint_0[0];
                  try
                  {
                        num |= this.uint_0[1];
                  }
                  catch (Exception)
                  {
                        if ((this.uint_0[0] & 0x80000000) != 0)
                        {
                              num = this.uint_0[0];
                        }
                  }
                  return num;
            }

            public BigInteger method_19(int int_3, Random random_0)
            {
                  bool flag = false;
                  BigInteger integer = new BigInteger();
                  while (!flag)
                  {
                        integer.method_8(int_3, random_0);
                        BigInteger integer2 = integer.method_7(this);
                        if ((integer2.int_2 == 1) && (integer2.uint_0[0] == 1))
                        {
                              flag = true;
                        }
                  }
                  return integer;
            }

            public BigInteger method_2()
            {
                  if ((this.uint_0[0x45] & 0x80000000) != 0)
                  {
                        return smethod_14(this);
                  }
                  return new BigInteger(this);
            }

            public BigInteger method_20(BigInteger class117_0)
            {
                  BigInteger[] integerArray = new BigInteger[] { smethod_2(0), smethod_2(1) };
                  BigInteger[] integerArray2 = new BigInteger[2];
                  BigInteger[] integerArray3 = new BigInteger[] { smethod_2(0), smethod_2(0) };
                  int num = 0;
                  BigInteger integer = class117_0;
                  BigInteger integer2 = this;
                  while ((integer2.int_2 > 1) || ((integer2.int_2 == 1) && (integer2.uint_0[0] != 0)))
                  {
                        BigInteger integer4 = new BigInteger();
                        BigInteger integer5 = new BigInteger();
                        if (num > 1)
                        {
                              BigInteger integer6 = smethod_24(smethod_6(integerArray[0], smethod_8(integerArray[1], integerArray2[0])), class117_0);
                              integerArray[0] = integerArray[1];
                              integerArray[1] = integer6;
                        }
                        if (integer2.int_2 == 1)
                        {
                              smethod_22(integer, integer2, integer4, integer5);
                        }
                        else
                        {
                              smethod_21(integer, integer2, integer4, integer5);
                        }
                        integerArray2[0] = integerArray2[1];
                        integerArray3[0] = integerArray3[1];
                        integerArray2[1] = integer4;
                        integerArray3[1] = integer5;
                        integer = integer2;
                        integer2 = integer5;
                        num++;
                  }
                  if ((integerArray3[0].int_2 > 1) || ((integerArray3[0].int_2 == 1) && (integerArray3[0].uint_0[0] != 1)))
                  {
                        throw new ArithmeticException("No inverse!");
                  }
                  BigInteger integer3 = smethod_24(smethod_6(integerArray[0], smethod_8(integerArray[1], integerArray2[0])), class117_0);
                  if ((integer3.uint_0[0x45] & 0x80000000) != 0)
                  {
                        integer3 = smethod_4(integer3, class117_0);
                  }
                  return integer3;
            }

            public byte[] method_21()
            {
                  int num1 = this.method_9();
                  int num = num1 >> 3;
                  if ((num1 & 7) != 0)
                  {
                        num++;
                  }
                  byte[] buffer = new byte[num];
                  int index = 0;
                  uint num3 = this.uint_0[this.int_2 - 1];
                  uint num4 = (num3 >> 0x18) & 0xff;
                  if (num4 != 0)
                  {
                        buffer[index++] = (byte)num4;
                  }
                  num4 = (num3 >> 0x10) & 0xff;
                  if (num4 != 0)
                  {
                        buffer[index++] = (byte)num4;
                  }
                  num4 = (num3 >> 8) & 0xff;
                  if (num4 != 0)
                  {
                        buffer[index++] = (byte)num4;
                  }
                  num4 = num3 & 0xff;
                  if (num4 != 0)
                  {
                        buffer[index++] = (byte)num4;
                  }
                  int num5 = this.int_2 - 2;
                  while (num5 >= 0)
                  {
                        num3 = this.uint_0[num5];
                        buffer[index + 3] = (byte)(num3 & 0xff);
                        num3 = num3 >> 8;
                        buffer[index + 2] = (byte)(num3 & 0xff);
                        num3 = num3 >> 8;
                        buffer[index + 1] = (byte)(num3 & 0xff);
                        num3 = num3 >> 8;
                        buffer[index] = (byte)(num3 & 0xff);
                        num5--;
                        index += 4;
                  }
                  return buffer;
            }

            public void method_22(uint uint_1)
            {
                  uint index = uint_1 >> 5;
                  byte num2 = (byte)(uint_1 & 0x1f);
                  uint num3 = ((uint)1) << num2;
                  this.uint_0[index] |= num3;
                  if (index >= this.int_2)
                  {
                        this.int_2 = ((int)index) + 1;
                  }
            }

            public void method_23(uint uint_1)
            {
                  uint index = uint_1 >> 5;
                  if (index < this.int_2)
                  {
                        byte num2 = (byte)(uint_1 & 0x1f);
                        uint num3 = ((uint)1) << num2;
                        uint num4 = uint.MaxValue ^ num3;
                        this.uint_0[index] &= num4;
                        if ((this.int_2 > 1) && (this.uint_0[this.int_2 - 1] == 0))
                        {
                              this.int_2--;
                        }
                  }
            }

            public BigInteger method_24()
            {
                  uint num;
                  uint num2 = (uint)this.method_9();
                  if ((num2 & 1) != 0)
                  {
                        num2 = (num2 >> 1) + 1;
                  }
                  else
                  {
                        num2 = num2 >> 1;
                  }
                  uint num3 = num2 >> 5;
                  byte num4 = (byte)(num2 & 0x1f);
                  BigInteger integer = new BigInteger();
                  if (num4 == 0)
                  {
                        num = 0x80000000;
                  }
                  else
                  {
                        num = ((uint)1) << num4;
                        num3++;
                  }
                  integer.int_2 = (int)num3;
                  for (int i = ((int)num3) - 1; i >= 0; i--)
                  {
                        while (num != 0)
                        {
                              integer.uint_0[i] ^= num;
                              if (smethod_17(smethod_8(integer, integer), this))
                              {
                                    integer.uint_0[i] ^= num;
                              }
                              num = num >> 1;
                        }
                        num = 0x80000000;
                  }
                  return integer;
            }

            public string method_3(int int_3)
            {
                  if ((int_3 < 2) || (int_3 > 0x24))
                  {
                        throw new ArgumentException("Radix must be >= 2 and <= 36");
                  }
                  string str = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                  string str2 = "";
                  BigInteger integer = this;
                  bool flag = false;
                  if ((integer.uint_0[0x45] & 0x80000000) != 0)
                  {
                        flag = true;
                        try
                        {
                              integer = smethod_14(integer);
                        }
                        catch (Exception)
                        {
                        }
                  }
                  BigInteger integer2 = new BigInteger();
                  BigInteger integer3 = new BigInteger();
                  BigInteger integer4 = new BigInteger((long)int_3);
                  if ((integer.int_2 == 1) && (integer.uint_0[0] == 0))
                  {
                        return "0";
                  }
                  while ((integer.int_2 > 1) || ((integer.int_2 == 1) && (integer.uint_0[0] != 0)))
                  {
                        smethod_22(integer, integer4, integer2, integer3);
                        if (integer3.uint_0[0] < 10)
                        {
                              str2 = integer3.uint_0[0] + str2;
                        }
                        else
                        {
                              str2 = str[((int)integer3.uint_0[0]) - 10].ToString() + str2;
                        }
                        integer = integer2;
                  }
                  if (flag)
                  {
                        str2 = "-" + str2;
                  }
                  return str2;
            }

            public string method_4()
            {
                  string str = this.uint_0[this.int_2 - 1].ToString("X");
                  for (int i = this.int_2 - 2; i >= 0; i--)
                  {
                        str = str + this.uint_0[i].ToString("X8");
                  }
                  return str;
            }

            public BigInteger method_5(BigInteger class117_0, BigInteger class117_1)
            {
                  BigInteger integer;
                  if ((class117_0.uint_0[0x45] & 0x80000000) != 0)
                  {
                        throw new ArithmeticException("Positive exponents only.");
                  }
                  BigInteger integer2 = smethod_2(1);
                  bool flag = false;
                  if ((this.uint_0[0x45] & 0x80000000) != 0)
                  {
                        integer = smethod_24(smethod_14(this), class117_1);
                        flag = true;
                  }
                  else
                  {
                        integer = smethod_24(this, class117_1);
                  }
                  if ((class117_1.uint_0[0x45] & 0x80000000) != 0)
                  {
                        class117_1 = smethod_14(class117_1);
                  }
                  BigInteger integer3 = new BigInteger();
                  int index = class117_1.int_2 << 1;
                  integer3.uint_0[index] = 1;
                  integer3.int_2 = index + 1;
                  integer3 = smethod_23(integer3, class117_1);
                  int num2 = class117_0.method_9();
                  int num3 = 0;
                  for (int i = 0; i < class117_0.int_2; i++)
                  {
                        uint num5 = 1;
                        for (int j = 0; j < 0x20; j++)
                        {
                              if ((class117_0.uint_0[i] & num5) != 0)
                              {
                                    integer2 = this.method_6(smethod_8(integer2, integer), class117_1, integer3);
                              }
                              num5 = num5 << 1;
                              integer = this.method_6(smethod_8(integer, integer), class117_1, integer3);
                              if ((integer.int_2 == 1) && (integer.uint_0[0] == 1))
                              {
                                    if (flag && ((class117_0.uint_0[0] & 1) != 0))
                                    {
                                          return smethod_14(integer2);
                                    }
                                    return integer2;
                              }
                              num3++;
                              if (num3 == num2)
                              {
                                    break;
                              }
                        }
                  }
                  if (flag && ((class117_0.uint_0[0] & 1) != 0))
                  {
                        return smethod_14(integer2);
                  }
                  return integer2;
            }

            private BigInteger method_6(BigInteger class117_0, BigInteger class117_1, BigInteger class117_2)
            {
                  int num = 0;
                  int num2 = class117_1.int_2++ - 1;
                  BigInteger integer = new BigInteger();
                  int index = num2;
                  for (int i = 0; index < class117_0.int_2; i++)
                  {
                        integer.uint_0[i] = class117_0.uint_0[index];
                        index++;
                  }
                  integer.int_2 = class117_0.int_2 - num2;
                  if (integer.int_2 <= 0)
                  {
                        integer.int_2 = 1;
                  }
                  BigInteger integer2 = smethod_8(integer, class117_2);
                  BigInteger integer3 = new BigInteger();
                  int num4 = num;
                  for (int j = 0; num4 < integer2.int_2; j++)
                  {
                        integer3.uint_0[j] = integer2.uint_0[num4];
                        num4++;
                  }
                  integer3.int_2 = integer2.int_2 - num;
                  if (integer3.int_2 <= 0)
                  {
                        integer3.int_2 = 1;
                  }
                  BigInteger integer4 = new BigInteger();
                  int num5 = (class117_0.int_2 > num) ? num : class117_0.int_2;
                  for (int k = 0; k < num5; k++)
                  {
                        integer4.uint_0[k] = class117_0.uint_0[k];
                  }
                  integer4.int_2 = num5;
                  BigInteger integer5 = new BigInteger();
                  for (int m = 0; m < integer3.int_2; m++)
                  {
                        if (integer3.uint_0[m] == 0)
                        {
                              continue;
                        }
                        ulong num10 = 0L;
                        int num11 = m;
                        int num12 = 0;
                        while (num12 < class117_1.int_2)
                        {
                              if (num11 >= num)
                              {
                                    break;
                              }
                              ulong num13 = ((integer3.uint_0[m] * class117_1.uint_0[num12]) + integer5.uint_0[num11]) + num10;
                              integer5.uint_0[num11] = (uint)(num13 & 0xffffffffL);
                              num10 = num13 >> 0x20;
                              num12++;
                              num11++;
                        }
                        if (num11 < num)
                        {
                              integer5.uint_0[num11] = (uint)num10;
                        }
                  }
                  integer5.int_2 = num;
                  while (integer5.int_2 > 1)
                  {
                        if (integer5.uint_0[integer5.int_2 - 1] != 0)
                        {
                              break;
                        }
                        integer5.int_2--;
                  }
                  integer4 = smethod_6(integer4, integer5);
                  if ((integer4.uint_0[0x45] & 0x80000000) != 0)
                  {
                        BigInteger integer6 = new BigInteger();
                        integer6.uint_0[num] = 1;
                        integer6.int_2 = num + 1;
                        integer4 = smethod_4(integer4, integer6);
                  }
                  while (smethod_19(integer4, class117_1))
                  {
                        integer4 = smethod_6(integer4, class117_1);
                  }
                  return integer4;
            }

            public BigInteger method_7(BigInteger class117_0)
            {
                  BigInteger integer;
                  BigInteger integer2;
                  if ((this.uint_0[0x45] & 0x80000000) != 0)
                  {
                        integer = smethod_14(this);
                  }
                  else
                  {
                        integer = this;
                  }
                  if ((class117_0.uint_0[0x45] & 0x80000000) != 0)
                  {
                        integer2 = smethod_14(class117_0);
                  }
                  else
                  {
                        integer2 = class117_0;
                  }
                  BigInteger integer3 = integer2;
                  while ((integer.int_2 > 1) || ((integer.int_2 == 1) && (integer.uint_0[0] != 0)))
                  {
                        integer3 = integer;
                        integer = smethod_24(integer2, integer);
                        integer2 = integer3;
                  }
                  return integer3;
            }

            public void method_8(int int_3, Random random_0)
            {
                  int num = int_3 >> 5;
                  int num2 = int_3 & 0x1f;
                  if (num2 != 0)
                  {
                        num++;
                  }
                  if (num > 70)
                  {
                        throw new ArithmeticException("Number of required bits > maxLength.");
                  }
                  for (int i = 0; i < num; i++)
                  {
                        this.uint_0[i] = (uint)(random_0.NextDouble() * 4294967296);
                  }
                  for (int j = num; j < 70; j++)
                  {
                        this.uint_0[j] = 0;
                  }
                  if (num2 != 0)
                  {
                        uint num5 = ((uint)1) << (num2 - 1);
                        this.uint_0[num - 1] |= num5;
                        num5 = ((uint)(0)) >> (0x20 - num2);
                        this.uint_0[num - 1] &= num5;
                  }
                  else
                  {
                        this.uint_0[num - 1] |= 0x80000000;
                  }
                  this.int_2 = num;
                  if (this.int_2 == 0)
                  {
                        this.int_2 = 1;
                  }
            }

            public int method_9()
            {
                  while (this.int_2 > 1)
                  {
                        if (this.uint_0[this.int_2 - 1] != 0)
                        {
                              break;
                        }
                        this.int_2--;
                  }
                  uint num = this.uint_0[this.int_2 - 1];
                  uint num2 = 0x80000000;
                  int num3 = 0x20;
                  while (num3 > 0)
                  {
                        if ((num & num2) != 0)
                        {
                              break;
                        }
                        num3--;
                        num2 = num2 >> 1;
                  }
                  return (num3 + ((this.int_2 - 1) << 5));
            }

            public static BigInteger smethod_0(long long_0) =>
                new BigInteger(long_0);

            public static BigInteger smethod_1(ulong ulong_0) =>
                new BigInteger(ulong_0);

            private static int smethod_10(uint[] uint_1, int int_3)
            {
                  int num = 0x20;
                  int length = uint_1.Length;
                  while (length > 1)
                  {
                        if (uint_1[length - 1] != 0)
                        {
                              break;
                        }
                        length--;
                  }
                  for (int i = int_3; i > 0; i -= num)
                  {
                        if (i < num)
                        {
                              num = i;
                        }
                        ulong num4 = 0L;
                        for (int j = 0; j < length; j++)
                        {
                              ulong num6 = uint_1[j] << num;
                              num6 |= num4;
                              uint_1[j] = (uint)(num6 & 0xffffffffL);
                              num4 = num6 >> 0x20;
                        }
                        if ((num4 != 0) && ((length + 1) <= uint_1.Length))
                        {
                              uint_1[length] = (uint)num4;
                              length++;
                        }
                  }
                  return length;
            }

            public static BigInteger smethod_11(BigInteger class117_0, int int_3)
            {
                  BigInteger integer = new BigInteger();
                  integer = new BigInteger(class117_0)
                  {
                        int_2 = smethod_12(integer.uint_0, int_3)
                  };
                  if ((class117_0.uint_0[0x45] & 0x80000000) != 0)
                  {
                        for (int i = 0x45; i >= integer.int_2; i--)
                        {
                              integer.uint_0[i] = uint.MaxValue;
                        }
                        uint num = 0x80000000;
                        for (int j = 0; j < 0x20; j++)
                        {
                              if ((integer.uint_0[integer.int_2 - 1] & num) != 0)
                              {
                                    break;
                              }
                              integer.uint_0[integer.int_2 - 1] |= num;
                              num = num >> 1;
                        }
                        integer.int_2 = 70;
                  }
                  return integer;
            }

            private static int smethod_12(uint[] uint_1, int int_3)
            {
                  int num = 0x20;
                  int num2 = 0;
                  int length = uint_1.Length;
                  while (length > 1)
                  {
                        if (uint_1[length - 1] != 0)
                        {
                              break;
                        }
                        length--;
                  }
                  for (int i = int_3; i > 0; i -= num)
                  {
                        if (i < num)
                        {
                              num = i;
                              num2 = 0x20 - num;
                        }
                        ulong num5 = 0L;
                        for (int j = length - 1; j >= 0; j--)
                        {
                              ulong num7 = uint_1[j] >> num;
                              num7 |= num5;
                              num5 = uint_1[j] << num2;
                              uint_1[j] = (uint)num7;
                        }
                  }
                  while (length > 1)
                  {
                        if (uint_1[length - 1] != 0)
                        {
                              return length;
                        }
                        length--;
                  }
                  return length;
            }

            public static BigInteger smethod_13(BigInteger class117_0)
            {
                  BigInteger integer = new BigInteger(class117_0);
                  for (int i = 0; i < 70; i++)
                  {
                        integer.uint_0[i] = ~class117_0.uint_0[i];
                  }
                  integer.int_2 = 70;
                  while (integer.int_2 > 1)
                  {
                        if (integer.uint_0[integer.int_2 - 1] != 0)
                        {
                              return integer;
                        }
                        integer.int_2--;
                  }
                  return integer;
            }

            public static BigInteger smethod_14(BigInteger class117_0)
            {
                  if ((class117_0.int_2 == 1) && (class117_0.uint_0[0] == 0))
                  {
                        return new BigInteger();
                  }
                  BigInteger integer = new BigInteger(class117_0);
                  for (int i = 0; i < 70; i++)
                  {
                        integer.uint_0[i] = ~class117_0.uint_0[i];
                  }
                  long num = 1L;
                  for (int j = 0; num != 0; j++)
                  {
                        if (j >= 70)
                        {
                              break;
                        }
                        long num4 = integer.uint_0[j];
                        num4 += 1L;
                        integer.uint_0[j] = (uint)(((ulong)num4) & 0xffffffffL);
                        num = num4 >> 0x20;
                  }
                  if ((class117_0.uint_0[0x45] & 0x80000000) == (integer.uint_0[0x45] & 0x80000000))
                  {
                        throw new ArithmeticException("Overflow in negation.\n");
                  }
                  integer.int_2 = 70;
                  while (integer.int_2 > 1)
                  {
                        if (integer.uint_0[integer.int_2 - 1] != 0)
                        {
                              return integer;
                        }
                        integer.int_2--;
                  }
                  return integer;
            }

            public static bool smethod_15(BigInteger class117_0, BigInteger class117_1) =>
                class117_0.Equals(class117_1);

            public static bool smethod_16(BigInteger class117_0, BigInteger class117_1) =>
                !class117_0.Equals(class117_1);

            public static bool smethod_17(BigInteger class117_0, BigInteger class117_1)
            {
                  int index = 0x45;
                  if (((class117_0.uint_0[0x45] & 0x80000000) != 0) && ((class117_1.uint_0[index] & 0x80000000) == 0))
                  {
                        return false;
                  }
                  if (((class117_0.uint_0[index] & 0x80000000) == 0) && ((class117_1.uint_0[index] & 0x80000000) != 0))
                  {
                        return true;
                  }
                  index = ((class117_0.int_2 > class117_1.int_2) ? class117_0.int_2 : class117_1.int_2) - 1;
                  while (index >= 0)
                  {
                        if (class117_0.uint_0[index] != class117_1.uint_0[index])
                        {
                              break;
                        }
                        index--;
                  }
                  if (index < 0)
                  {
                        return false;
                  }
                  return (class117_0.uint_0[index] > class117_1.uint_0[index]);
            }

            public static bool smethod_18(BigInteger class117_0, BigInteger class117_1)
            {
                  int index = 0x45;
                  if (((class117_0.uint_0[0x45] & 0x80000000) != 0) && ((class117_1.uint_0[index] & 0x80000000) == 0))
                  {
                        return true;
                  }
                  if (((class117_0.uint_0[index] & 0x80000000) == 0) && ((class117_1.uint_0[index] & 0x80000000) != 0))
                  {
                        return false;
                  }
                  index = ((class117_0.int_2 > class117_1.int_2) ? class117_0.int_2 : class117_1.int_2) - 1;
                  while (index >= 0)
                  {
                        if (class117_0.uint_0[index] != class117_1.uint_0[index])
                        {
                              break;
                        }
                        index--;
                  }
                  if (index < 0)
                  {
                        return false;
                  }
                  return (class117_0.uint_0[index] < class117_1.uint_0[index]);
            }

            public static bool smethod_19(BigInteger class117_0, BigInteger class117_1)
            {
                  if (!smethod_15(class117_0, class117_1))
                  {
                        return smethod_17(class117_0, class117_1);
                  }
                  return true;
            }

            public static BigInteger smethod_2(int int_3) =>
                new BigInteger((long)int_3);

            public static bool smethod_20(BigInteger class117_0, BigInteger class117_1)
            {
                  if (!smethod_15(class117_0, class117_1))
                  {
                        return smethod_18(class117_0, class117_1);
                  }
                  return true;
            }

            private static void smethod_21(BigInteger class117_0, BigInteger class117_1, BigInteger class117_2, BigInteger class117_3)
            {
                  uint[] numArray = new uint[70];
                  int num = class117_0.int_2 + 1;
                  uint[] numArray2 = new uint[num];
                  uint num2 = 0x80000000;
                  uint num3 = class117_1.uint_0[class117_1.int_2 - 1];
                  int num4 = 0;
                  int num5 = 0;
                  while (num2 != 0)
                  {
                        if ((num3 & num2) != 0)
                        {
                              break;
                        }
                        num4++;
                        num2 = num2 >> 1;
                  }
                  for (int i = 0; i < class117_0.int_2; i++)
                  {
                        numArray2[i] = class117_0.uint_0[i];
                  }
                  smethod_10(numArray2, num4);
                  class117_1 = smethod_9(class117_1, num4);
                  int num6 = num - class117_1.int_2;
                  int index = num - 1;
                  ulong num8 = class117_1.uint_0[class117_1.int_2 - 1];
                  ulong num9 = class117_1.uint_0[class117_1.int_2 - 2];
                  int num10 = class117_1.int_2 + 1;
                  uint[] inData = new uint[num10];
                  while (num6 > 0)
                  {
                        ulong num1 = numArray2[index] + numArray2[index - 1];
                        ulong num14 = num1 / num8;
                        ulong num15 = num1 % num8;
                        bool flag = false;
                        while (!flag)
                        {
                              flag = true;
                              if ((num14 == 0x100000000L) || ((num14 * num9) > ((num15 << 0x20) + numArray2[index - 2])))
                              {
                                    num14 -= (ulong)1L;
                                    num15 += num8;
                                    if (num15 < 0x100000000L)
                                    {
                                          flag = false;
                                    }
                              }
                        }
                        for (int j = 0; j < num10; j++)
                        {
                              inData[j] = numArray2[index - j];
                        }
                        BigInteger integer = new BigInteger(inData);
                        BigInteger integer2 = smethod_8(class117_1, smethod_0((long)num14));
                        while (smethod_17(integer2, integer))
                        {
                              num14 -= (ulong)1L;
                              integer2 = smethod_6(integer2, class117_1);
                        }
                        BigInteger integer3 = smethod_6(integer, integer2);
                        for (int k = 0; k < num10; k++)
                        {
                              numArray2[index - k] = integer3.uint_0[class117_1.int_2 - k];
                        }
                        numArray[num5++] = (uint)num14;
                        index--;
                        num6--;
                  }
                  class117_2.int_2 = num5;
                  int num11 = 0;
                  int num12 = class117_2.int_2 - 1;
                  while (num12 >= 0)
                  {
                        class117_2.uint_0[num11] = numArray[num12];
                        num12--;
                        num11++;
                  }
                  while (num11 < 70)
                  {
                        class117_2.uint_0[num11] = 0;
                        num11++;
                  }
                  while (class117_2.int_2 > 1)
                  {
                        if (class117_2.uint_0[class117_2.int_2 - 1] != 0)
                        {
                              break;
                        }
                        class117_2.int_2--;
                  }
                  if (class117_2.int_2 == 0)
                  {
                        class117_2.int_2 = 1;
                  }
                  class117_3.int_2 = smethod_12(numArray2, num4);
                  num11 = 0;
                  while (num11 < class117_3.int_2)
                  {
                        class117_3.uint_0[num11] = numArray2[num11];
                        num11++;
                  }
                  while (num11 < 70)
                  {
                        class117_3.uint_0[num11] = 0;
                        num11++;
                  }
            }

            private static void smethod_22(BigInteger class117_0, BigInteger class117_1, BigInteger class117_2, BigInteger class117_3)
            {
                  uint[] numArray = new uint[70];
                  int num = 0;
                  for (int i = 0; i < 70; i++)
                  {
                        class117_3.uint_0[i] = class117_0.uint_0[i];
                  }
                  class117_3.int_2 = class117_0.int_2;
                  while (class117_3.int_2 > 1)
                  {
                        if (class117_3.uint_0[class117_3.int_2 - 1] != 0)
                        {
                              break;
                        }
                        class117_3.int_2--;
                  }
                  ulong num2 = class117_1.uint_0[0];
                  int index = class117_3.int_2 - 1;
                  ulong num4 = class117_3.uint_0[index];
                  if (num4 >= num2)
                  {
                        ulong num8 = num4 / num2;
                        numArray[num++] = (uint)num8;
                        class117_3.uint_0[index] = (uint)(num4 % num2);
                  }
                  index--;
                  while (index >= 0)
                  {
                        num4 = class117_3.uint_0[index + 1] + class117_3.uint_0[index];
                        ulong num9 = num4 / num2;
                        numArray[num++] = (uint)num9;
                        class117_3.uint_0[index + 1] = 0;
                        class117_3.uint_0[index--] = (uint)(num4 % num2);
                  }
                  class117_2.int_2 = num;
                  int num5 = 0;
                  int num6 = class117_2.int_2 - 1;
                  while (num6 >= 0)
                  {
                        class117_2.uint_0[num5] = numArray[num6];
                        num6--;
                        num5++;
                  }
                  while (num5 < 70)
                  {
                        class117_2.uint_0[num5] = 0;
                        num5++;
                  }
                  while (class117_2.int_2 > 1)
                  {
                        if (class117_2.uint_0[class117_2.int_2 - 1] != 0)
                        {
                              break;
                        }
                        class117_2.int_2--;
                  }
                  if (class117_2.int_2 == 0)
                  {
                        class117_2.int_2 = 1;
                  }
                  while (class117_3.int_2 > 1)
                  {
                        if (class117_3.uint_0[class117_3.int_2 - 1] != 0)
                        {
                              break;
                        }
                        class117_3.int_2--;
                  }
            }

            public static BigInteger smethod_23(BigInteger class117_0, BigInteger class117_1)
            {
                  BigInteger integer = new BigInteger();
                  BigInteger integer2 = new BigInteger();
                  int index = 0x45;
                  bool flag = false;
                  bool flag2 = false;
                  if ((class117_0.uint_0[0x45] & 0x80000000) != 0)
                  {
                        class117_0 = smethod_14(class117_0);
                        flag2 = true;
                  }
                  if ((class117_1.uint_0[index] & 0x80000000) != 0)
                  {
                        class117_1 = smethod_14(class117_1);
                        flag = true;
                  }
                  if (!smethod_18(class117_0, class117_1))
                  {
                        if (class117_1.int_2 == 1)
                        {
                              smethod_22(class117_0, class117_1, integer, integer2);
                        }
                        else
                        {
                              smethod_21(class117_0, class117_1, integer, integer2);
                        }
                        if (flag2 != flag)
                        {
                              return smethod_14(integer);
                        }
                  }
                  return integer;
            }

            public static BigInteger smethod_24(BigInteger class117_0, BigInteger class117_1)
            {
                  BigInteger integer = new BigInteger();
                  BigInteger integer2 = new BigInteger(class117_0);
                  int index = 0x45;
                  bool flag = false;
                  if ((class117_0.uint_0[0x45] & 0x80000000) != 0)
                  {
                        class117_0 = smethod_14(class117_0);
                        flag = true;
                  }
                  if ((class117_1.uint_0[index] & 0x80000000) != 0)
                  {
                        class117_1 = smethod_14(class117_1);
                  }
                  if (!smethod_18(class117_0, class117_1))
                  {
                        if (class117_1.int_2 == 1)
                        {
                              smethod_22(class117_0, class117_1, integer, integer2);
                        }
                        else
                        {
                              smethod_21(class117_0, class117_1, integer, integer2);
                        }
                        if (flag)
                        {
                              return smethod_14(integer2);
                        }
                  }
                  return integer2;
            }

            public static BigInteger smethod_25(BigInteger class117_0, BigInteger class117_1)
            {
                  BigInteger integer = new BigInteger();
                  int num = (class117_0.int_2 > class117_1.int_2) ? class117_0.int_2 : class117_1.int_2;
                  for (int i = 0; i < num; i++)
                  {
                        integer.uint_0[i] = class117_0.uint_0[i] & class117_1.uint_0[i];
                  }
                  integer.int_2 = 70;
                  while (integer.int_2 > 1)
                  {
                        if (integer.uint_0[integer.int_2 - 1] != 0)
                        {
                              return integer;
                        }
                        integer.int_2--;
                  }
                  return integer;
            }

            public static BigInteger smethod_26(BigInteger class117_0, BigInteger class117_1)
            {
                  BigInteger integer = new BigInteger();
                  int num = (class117_0.int_2 > class117_1.int_2) ? class117_0.int_2 : class117_1.int_2;
                  for (int i = 0; i < num; i++)
                  {
                        integer.uint_0[i] = class117_0.uint_0[i] | class117_1.uint_0[i];
                  }
                  integer.int_2 = 70;
                  while (integer.int_2 > 1)
                  {
                        if (integer.uint_0[integer.int_2 - 1] != 0)
                        {
                              return integer;
                        }
                        integer.int_2--;
                  }
                  return integer;
            }

            public static BigInteger smethod_27(BigInteger class117_0, BigInteger class117_1)
            {
                  BigInteger integer = new BigInteger();
                  int num = (class117_0.int_2 > class117_1.int_2) ? class117_0.int_2 : class117_1.int_2;
                  for (int i = 0; i < num; i++)
                  {
                        integer.uint_0[i] = class117_0.uint_0[i] ^ class117_1.uint_0[i];
                  }
                  integer.int_2 = 70;
                  while (integer.int_2 > 1)
                  {
                        if (integer.uint_0[integer.int_2 - 1] != 0)
                        {
                              return integer;
                        }
                        integer.int_2--;
                  }
                  return integer;
            }

            public static int smethod_28(BigInteger class117_0, BigInteger class117_1)
            {
                  if ((class117_1.uint_0[0] & 1) == 0)
                  {
                        throw new ArgumentException("Jacobi defined only for odd integers.");
                  }
                  if (smethod_19(class117_0, class117_1))
                  {
                        class117_0 = smethod_24(class117_0, class117_1);
                  }
                  if ((class117_0.int_2 == 1) && (class117_0.uint_0[0] == 0))
                  {
                        return 0;
                  }
                  if ((class117_0.int_2 == 1) && (class117_0.uint_0[0] == 1))
                  {
                        return 1;
                  }
                  if (smethod_18(class117_0, smethod_2(0)))
                  {
                        if ((smethod_6(class117_1, smethod_2(1)).uint_0[0] & 2) == 0)
                        {
                              return smethod_28(smethod_14(class117_0), class117_1);
                        }
                        return -smethod_28(smethod_14(class117_0), class117_1);
                  }
                  int num = 0;
                  for (int i = 0; i < class117_0.int_2; i++)
                  {
                        uint num4 = 1;
                        for (int j = 0; j < 0x20; j++)
                        {
                              if ((class117_0.uint_0[i] & num4) != 0)
                              {
                                    goto Label_00C7;
                              }
                              num4 = num4 << 1;
                              num++;
                        }
                        continue;
                        Label_00C7:
                        i = class117_0.int_2;
                  }
                  BigInteger integer = smethod_11(class117_0, num);
                  int num2 = 1;
                  if (((num & 1) != 0) && (((class117_1.uint_0[0] & 7) == 3) || ((class117_1.uint_0[0] & 7) == 5)))
                  {
                        num2 = -1;
                  }
                  if (((class117_1.uint_0[0] & 3) == 3) && ((integer.uint_0[0] & 3) == 3))
                  {
                        num2 = -num2;
                  }
                  if ((integer.int_2 == 1) && (integer.uint_0[0] == 1))
                  {
                        return num2;
                  }
                  return (num2 * smethod_28(smethod_24(class117_1, integer), integer));
            }

            public static BigInteger smethod_29(int int_3, int int_4, Random random_0)
            {
                  BigInteger integer = new BigInteger();
                  for (bool flag = false; !flag; flag = integer.method_15(int_4))
                  {
                        integer.method_8(int_3, random_0);
                        integer.uint_0[0] |= 1;
                  }
                  return integer;
            }

            public static BigInteger smethod_3(uint uint_1) =>
                new BigInteger((ulong)uint_1);

            public static BigInteger[] smethod_30(BigInteger class117_0, BigInteger class117_1, BigInteger class117_2, BigInteger class117_3)
            {
                  if ((class117_2.int_2 == 1) && (class117_2.uint_0[0] == 0))
                  {
                        return new BigInteger[] { smethod_2(0), smethod_24(smethod_2(2), class117_3), smethod_24(smethod_2(1), class117_3) };
                  }
                  BigInteger integer = new BigInteger();
                  int index = class117_3.int_2 << 1;
                  integer.uint_0[index] = 1;
                  integer.int_2 = index + 1;
                  integer = smethod_23(integer, class117_3);
                  int num2 = 0;
                  for (int i = 0; i < class117_2.int_2; i++)
                  {
                        uint num4 = 1;
                        for (int j = 0; j < 0x20; j++)
                        {
                              if ((class117_2.uint_0[i] & num4) != 0)
                              {
                                    goto Label_009F;
                              }
                              num4 = num4 << 1;
                              num2++;
                        }
                        continue;
                        Label_009F:
                        i = class117_2.int_2;
                  }
                  BigInteger integer2 = smethod_11(class117_2, num2);
                  return smethod_31(class117_0, class117_1, integer2, class117_3, integer, num2);
            }

            private static BigInteger[] smethod_31(BigInteger class117_0, BigInteger class117_1, BigInteger class117_2, BigInteger class117_3, BigInteger class117_4, int int_3)
            {
                  BigInteger[] integerArray = new BigInteger[3];
                  if ((class117_2.uint_0[0] & 1) == 0)
                  {
                        throw new ArgumentException("Argument k must be odd.");
                  }
                  int num = class117_2.method_9();
                  uint num2 = ((uint)1) << ((num & 0x1f) - 1);
                  BigInteger integer = smethod_24(smethod_2(2), class117_3);
                  BigInteger integer2 = smethod_24(smethod_2(1), class117_3);
                  BigInteger integer3 = smethod_24(class117_0, class117_3);
                  BigInteger integer4 = integer2;
                  bool flag = true;
                  for (int i = class117_2.int_2 - 1; i >= 0; i--)
                  {
                        while (num2 != 0)
                        {
                              if ((i == 0) && (num2 == 1))
                              {
                                    break;
                              }
                              if ((class117_2.uint_0[i] & num2) != 0)
                              {
                                    integer4 = smethod_24(smethod_8(integer4, integer3), class117_3);
                                    integer = smethod_24(smethod_6(smethod_8(integer, integer3), smethod_8(class117_0, integer2)), class117_3);
                                    integer3 = smethod_24(smethod_6(class117_3.method_6(smethod_8(integer3, integer3), class117_3, class117_4), smethod_9(smethod_8(integer2, class117_1), 1)), class117_3);
                                    if (flag)
                                    {
                                          flag = false;
                                    }
                                    else
                                    {
                                          integer2 = class117_3.method_6(smethod_8(integer2, integer2), class117_3, class117_4);
                                    }
                                    integer2 = smethod_24(smethod_8(integer2, class117_1), class117_3);
                              }
                              else
                              {
                                    integer4 = smethod_24(smethod_6(smethod_8(integer4, integer), integer2), class117_3);
                                    integer3 = smethod_24(smethod_6(smethod_8(integer, integer3), smethod_8(class117_0, integer2)), class117_3);
                                    integer = smethod_24(smethod_6(class117_3.method_6(smethod_8(integer, integer), class117_3, class117_4), smethod_9(integer2, 1)), class117_3);
                                    if (flag)
                                    {
                                          integer2 = smethod_24(class117_1, class117_3);
                                          flag = false;
                                    }
                                    else
                                    {
                                          integer2 = class117_3.method_6(smethod_8(integer2, integer2), class117_3, class117_4);
                                    }
                              }
                              num2 = num2 >> 1;
                        }
                        num2 = 0x80000000;
                  }
                  integer4 = smethod_24(smethod_6(smethod_8(integer4, integer), integer2), class117_3);
                  integer = smethod_24(smethod_6(smethod_8(integer, integer3), smethod_8(class117_0, integer2)), class117_3);
                  if (flag)
                  {
                        flag = false;
                  }
                  else
                  {
                        integer2 = class117_3.method_6(smethod_8(integer2, integer2), class117_3, class117_4);
                  }
                  integer2 = smethod_24(smethod_8(integer2, class117_1), class117_3);
                  for (int j = 0; j < int_3; j++)
                  {
                        integer4 = smethod_24(smethod_8(integer4, integer), class117_3);
                        integer = smethod_24(smethod_6(smethod_8(integer, integer), smethod_9(integer2, 1)), class117_3);
                        if (flag)
                        {
                              integer2 = smethod_24(class117_1, class117_3);
                              flag = false;
                        }
                        else
                        {
                              integer2 = class117_3.method_6(smethod_8(integer2, integer2), class117_3, class117_4);
                        }
                  }
                  integerArray[0] = integer4;
                  integerArray[1] = integer;
                  integerArray[2] = integer2;
                  return integerArray;
            }

            public static void smethod_32(int int_3)
            {
                  Random random = new Random();
                  byte[] inData = new byte[0x40];
                  byte[] buffer2 = new byte[0x40];
                  for (int i = 0; i < int_3; i++)
                  {
                        int inLen = 0;
                        while (inLen == 0)
                        {
                              inLen = (int)(random.NextDouble() * 65.0);
                        }
                        int num3 = 0;
                        while (num3 == 0)
                        {
                              num3 = (int)(random.NextDouble() * 65.0);
                        }
                        bool flag = false;
                        while (!flag)
                        {
                              for (int j = 0; j < 0x40; j++)
                              {
                                    if (j < inLen)
                                    {
                                          inData[j] = (byte)(random.NextDouble() * 256.0);
                                    }
                                    else
                                    {
                                          inData[j] = 0;
                                    }
                                    if (inData[j] != 0)
                                    {
                                          flag = true;
                                    }
                              }
                        }
                        flag = false;
                        while (!flag)
                        {
                              for (int k = 0; k < 0x40; k++)
                              {
                                    if (k < num3)
                                    {
                                          buffer2[k] = (byte)(random.NextDouble() * 256.0);
                                    }
                                    else
                                    {
                                          buffer2[k] = 0;
                                    }
                                    if (buffer2[k] != 0)
                                    {
                                          flag = true;
                                    }
                              }
                        }
                        while (inData[0] == 0)
                        {
                              inData[0] = (byte)(random.NextDouble() * 256.0);
                        }
                        while (buffer2[0] == 0)
                        {
                              buffer2[0] = (byte)(random.NextDouble() * 256.0);
                        }
                        Console.WriteLine(i);
                        BigInteger integer = new BigInteger(inData, inLen);
                        BigInteger integer2 = new BigInteger(buffer2, num3);
                        BigInteger integer3 = smethod_23(integer, integer2);
                        BigInteger integer4 = smethod_24(integer, integer2);
                        BigInteger integer5 = smethod_4(smethod_8(integer3, integer2), integer4);
                        if (smethod_16(integer5, integer))
                        {
                              Console.WriteLine("Error at " + i);
                              Console.WriteLine(integer + "\n");
                              Console.WriteLine(integer2 + "\n");
                              Console.WriteLine(integer3 + "\n");
                              Console.WriteLine(integer4 + "\n");
                              Console.WriteLine(integer5 + "\n");
                              return;
                        }
                  }
            }

            public static void smethod_33(int int_3)
            {
                  Random random = new Random(1);
                  byte[] inData = new byte[0x40];
                  BigInteger integer = new BigInteger("a932b948feed4fb2b692609bd22164fc9edb59fae7880cc1eaff7b3c9626b7e5b241c27a974833b2622ebe09beb451917663d47232488f23a117fc97720f1e7", 0x10);
                  BigInteger integer2 = new BigInteger("4adf2f7a89da93248509347d2ae506d683dd3a16357e859a980c4f77a4e2f7a01fae289f13a851df6e9db5adaa60bfd2b162bbbe31f7c8f828261a6839311929d2cef4f864dde65e556ce43c89bbbf9f1ac5511315847ce9cc8dc92470a747b8792d6a83b0092d2e5ebaf852c85cacf34278efa99160f2f8aa7ee7214de07b7", 0x10);
                  BigInteger integer3 = new BigInteger("e8e77781f36a7b3188d711c2190b560f205a52391b3479cdb99fa010745cbeba5f2adc08e1de6bf38398a0487c4a73610d94ec36f17f3f46ad75e17bc1adfec99839589f45f95ccc94cb2a5c500b477eb3323d8cfab0c8458c96f0147a45d27e45a4d11d54d77684f65d48f15fafcc1ba208e71e921b9bd9017c16a5231af7f", 0x10);
                  Console.WriteLine("e =\n" + integer.method_3(10));
                  Console.WriteLine("\nd =\n" + integer2.method_3(10));
                  Console.WriteLine("\nn =\n" + integer3.method_3(10) + "\n");
                  for (int i = 0; i < int_3; i++)
                  {
                        int inLen = 0;
                        while (inLen == 0)
                        {
                              inLen = (int)(random.NextDouble() * 65.0);
                        }
                        bool flag = false;
                        while (!flag)
                        {
                              for (int j = 0; j < 0x40; j++)
                              {
                                    if (j < inLen)
                                    {
                                          inData[j] = (byte)(random.NextDouble() * 256.0);
                                    }
                                    else
                                    {
                                          inData[j] = 0;
                                    }
                                    if (inData[j] != 0)
                                    {
                                          flag = true;
                                    }
                              }
                        }
                        while (inData[0] == 0)
                        {
                              inData[0] = (byte)(random.NextDouble() * 256.0);
                        }
                        Console.Write("Round = " + i);
                        BigInteger integer4 = new BigInteger(inData, inLen);
                        if (smethod_16(integer4.method_5(integer, integer3).method_5(integer2, integer3), integer4))
                        {
                              Console.WriteLine("\nError at round " + i);
                              Console.WriteLine(integer4 + "\n");
                              return;
                        }
                        Console.WriteLine(" <PASSED>.");
                  }
            }

            public static void smethod_34(int int_3)
            {
                  Random random = new Random();
                  byte[] inData = new byte[0x40];
                  byte[] buffer2 = new byte[] {
                0x85, 0x84, 100, 0xfd, 0x70, 0x6a, 0x9f, 240, 0x94, 12, 0x3e, 0x2c, 0x74, 0x34, 5, 0xc9,
                0x55, 0xb3, 0x85, 50, 0x98, 0x71, 0xf9, 0x41, 0x21, 0x5f, 2, 0x9e, 0xea, 0x56, 0x8d, 140,
                0x44, 0xcc, 0xee, 0xee, 0x3d, 0x2c, 0x9d, 0x2c, 0x12, 0x41, 30, 0xf1, 0xc5, 50, 0xc3, 170,
                0x31, 0x4a, 0x52, 0xd8, 0xe8, 0xaf, 0x42, 0xf4, 0x72, 0xa1, 0x2a, 13, 0x97, 0xb1, 0x31, 0xb3
            };
                  BigInteger integer = new BigInteger(buffer2);
                  BigInteger integer2 = new BigInteger(new byte[] {
                0x99, 0x98, 0xca, 0xb8, 0x5e, 0xd7, 0xe5, 220, 40, 0x5c, 0x6f, 14, 0x15, 9, 0x59, 110,
                0x84, 0xf3, 0x81, 0xcd, 0xde, 0x42, 220, 0x93, 0xc2, 0x7a, 0x62, 0xac, 0x6c, 0xaf, 0xde, 0x74,
                0xe3, 0xcb, 0x60, 0x20, 0x38, 0x9c, 0x21, 0xc3, 220, 200, 0xa2, 0x4d, 0xc6, 0x2a, 0x35, 0x7f,
                0xf3, 0xa9, 0xe8, 0x1d, 0x7b, 0x2c, 120, 250, 0xb8, 2, 0x55, 0x80, 0x9b, 0xc2, 0xa5, 0xcb
            });
                  BigInteger integer3 = smethod_8(smethod_6(integer, smethod_2(1)), smethod_6(integer2, smethod_2(1)));
                  BigInteger integer4 = smethod_8(integer, integer2);
                  for (int i = 0; i < int_3; i++)
                  {
                        BigInteger integer5 = integer3.method_19(0x200, random);
                        BigInteger integer6 = integer5.method_20(integer3);
                        Console.WriteLine("\ne =\n" + integer5.method_3(10));
                        Console.WriteLine("\nd =\n" + integer6.method_3(10));
                        Console.WriteLine("\nn =\n" + integer4.method_3(10) + "\n");
                        int inLen = 0;
                        while (inLen == 0)
                        {
                              inLen = (int)(random.NextDouble() * 65.0);
                        }
                        bool flag = false;
                        while (!flag)
                        {
                              for (int j = 0; j < 0x40; j++)
                              {
                                    if (j < inLen)
                                    {
                                          inData[j] = (byte)(random.NextDouble() * 256.0);
                                    }
                                    else
                                    {
                                          inData[j] = 0;
                                    }
                                    if (inData[j] != 0)
                                    {
                                          flag = true;
                                    }
                              }
                        }
                        while (inData[0] == 0)
                        {
                              inData[0] = (byte)(random.NextDouble() * 256.0);
                        }
                        Console.Write("Round = " + i);
                        BigInteger integer7 = new BigInteger(inData, inLen);
                        if (smethod_16(integer7.method_5(integer5, integer4).method_5(integer6, integer4), integer7))
                        {
                              Console.WriteLine("\nError at round " + i);
                              Console.WriteLine(integer7 + "\n");
                              return;
                        }
                        Console.WriteLine(" <PASSED>.");
                  }
            }

            public static void smethod_35(int int_3)
            {
                  Random random = new Random();
                  for (int i = 0; i < int_3; i++)
                  {
                        int num2 = 0;
                        while (num2 == 0)
                        {
                              num2 = (int)(random.NextDouble() * 1024.0);
                        }
                        Console.Write("Round = " + i);
                        BigInteger integer = new BigInteger();
                        integer.method_8(num2, random);
                        BigInteger integer2 = integer.method_24();
                        if (smethod_20(smethod_8(smethod_4(integer2, smethod_2(1)), smethod_4(integer2, smethod_2(1))), integer))
                        {
                              Console.WriteLine("\nError at round " + i);
                              Console.WriteLine(integer + "\n");
                              return;
                        }
                        Console.WriteLine(" <PASSED>.");
                  }
            }

            public static BigInteger smethod_4(BigInteger class117_0, BigInteger class117_1)
            {
                  BigInteger integer = new BigInteger
                  {
                        int_2 = (class117_0.int_2 > class117_1.int_2) ? class117_0.int_2 : class117_1.int_2
                  };
                  long num = 0L;
                  for (int i = 0; i < integer.int_2; i++)
                  {
                        long num4 = (class117_0.uint_0[i] + class117_1.uint_0[i]) + num;
                        num = num4 >> 0x20;
                        integer.uint_0[i] = (uint)(((ulong)num4) & 0xffffffffL);
                  }
                  if ((num != 0) && (integer.int_2 < 70))
                  {
                        integer.uint_0[integer.int_2] = (uint)num;
                        integer.int_2++;
                  }
                  while (integer.int_2 > 1)
                  {
                        if (integer.uint_0[integer.int_2 - 1] != 0)
                        {
                              break;
                        }
                        integer.int_2--;
                  }
                  int index = 0x45;
                  if (((class117_0.uint_0[0x45] & 0x80000000) == (class117_1.uint_0[0x45] & 0x80000000)) && ((integer.uint_0[index] & 0x80000000) != (class117_0.uint_0[index] & 0x80000000)))
                  {
                        throw new ArithmeticException();
                  }
                  return integer;
            }

            public static BigInteger smethod_5(BigInteger class117_0)
            {
                  BigInteger integer = new BigInteger(class117_0);
                  long num = 1L;
                  int index = 0;
                  while (num != 0)
                  {
                        if (index >= 70)
                        {
                              break;
                        }
                        long num4 = integer.uint_0[index];
                        num4 += 1L;
                        integer.uint_0[index] = (uint)(((ulong)num4) & 0xffffffffL);
                        num = num4 >> 0x20;
                        index++;
                  }
                  if (index <= integer.int_2)
                  {
                        while (integer.int_2 > 1)
                        {
                              if (integer.uint_0[integer.int_2 - 1] != 0)
                              {
                                    break;
                              }
                              integer.int_2--;
                        }
                  }
                  else
                  {
                        integer.int_2 = index;
                  }
                  int num3 = 0x45;
                  if (((class117_0.uint_0[0x45] & 0x80000000) == 0) && ((integer.uint_0[num3] & 0x80000000) != (class117_0.uint_0[num3] & 0x80000000)))
                  {
                        throw new ArithmeticException("Overflow in ++.");
                  }
                  return integer;
            }

            public static BigInteger smethod_6(BigInteger class117_0, BigInteger class117_1)
            {
                  BigInteger integer = new BigInteger
                  {
                        int_2 = (class117_0.int_2 > class117_1.int_2) ? class117_0.int_2 : class117_1.int_2
                  };
                  long num = 0L;
                  for (int i = 0; i < integer.int_2; i++)
                  {
                        long num4 = (class117_0.uint_0[i] - class117_1.uint_0[i]) - num;
                        integer.uint_0[i] = (uint)(((ulong)num4) & 0xffffffffL);
                        if (num4 < 0L)
                        {
                              num = 1L;
                        }
                        else
                        {
                              num = 0L;
                        }
                  }
                  if (num != 0)
                  {
                        for (int j = integer.int_2; j < 70; j++)
                        {
                              integer.uint_0[j] = uint.MaxValue;
                        }
                        integer.int_2 = 70;
                  }
                  while (integer.int_2 > 1)
                  {
                        if (integer.uint_0[integer.int_2 - 1] != 0)
                        {
                              break;
                        }
                        integer.int_2--;
                  }
                  int index = 0x45;
                  if (((class117_0.uint_0[0x45] & 0x80000000) != (class117_1.uint_0[0x45] & 0x80000000)) && ((integer.uint_0[index] & 0x80000000) != (class117_0.uint_0[index] & 0x80000000)))
                  {
                        throw new ArithmeticException();
                  }
                  return integer;
            }

            public static BigInteger smethod_7(BigInteger class117_0)
            {
                  BigInteger integer = new BigInteger(class117_0);
                  bool flag = true;
                  int index = 0;
                  while (flag)
                  {
                        if (index >= 70)
                        {
                              break;
                        }
                        long num3 = integer.uint_0[index];
                        num3 -= 1L;
                        integer.uint_0[index] = (uint)(((ulong)num3) & 0xffffffffL);
                        if (num3 >= 0L)
                        {
                              flag = false;
                        }
                        index++;
                  }
                  if (index > integer.int_2)
                  {
                        integer.int_2 = index;
                  }
                  while (integer.int_2 > 1)
                  {
                        if (integer.uint_0[integer.int_2 - 1] != 0)
                        {
                              break;
                        }
                        integer.int_2--;
                  }
                  int num2 = 0x45;
                  if (((class117_0.uint_0[0x45] & 0x80000000) != 0) && ((integer.uint_0[num2] & 0x80000000) != (class117_0.uint_0[num2] & 0x80000000)))
                  {
                        throw new ArithmeticException("Underflow in --.");
                  }
                  return integer;
            }

            public static BigInteger smethod_8(BigInteger class117_0, BigInteger class117_1)
            {
                  int index = 0x45;
                  bool flag = false;
                  bool flag2 = false;
                  try
                  {
                        if ((class117_0.uint_0[index] & 0x80000000) != 0)
                        {
                              flag = true;
                              class117_0 = smethod_14(class117_0);
                        }
                        if ((class117_1.uint_0[index] & 0x80000000) != 0)
                        {
                              flag2 = true;
                              class117_1 = smethod_14(class117_1);
                        }
                  }
                  catch (Exception)
                  {
                  }
                  BigInteger integer = new BigInteger();
                  try
                  {
                        for (int i = 0; i < class117_0.int_2; i++)
                        {
                              if (class117_0.uint_0[i] != 0)
                              {
                                    ulong num3 = 0L;
                                    int num4 = 0;
                                    for (int j = i; num4 < class117_1.int_2; j++)
                                    {
                                          ulong num6 = ((class117_0.uint_0[i] * class117_1.uint_0[num4]) + integer.uint_0[j]) + num3;
                                          integer.uint_0[j] = (uint)(num6 & 0xffffffffL);
                                          num3 = num6 >> 0x20;
                                          num4++;
                                    }
                                    if (num3 != 0)
                                    {
                                          integer.uint_0[i + class117_1.int_2] = (uint)num3;
                                    }
                              }
                        }
                  }
                  catch (Exception)
                  {
                        throw new ArithmeticException("Multiplication overflow.");
                  }
                  integer.int_2 = class117_0.int_2 + class117_1.int_2;
                  if (integer.int_2 > 70)
                  {
                        integer.int_2 = 70;
                  }
                  while (integer.int_2 > 1)
                  {
                        if (integer.uint_0[integer.int_2 - 1] != 0)
                        {
                              break;
                        }
                        integer.int_2--;
                  }
                  if ((integer.uint_0[index] & 0x80000000) == 0)
                  {
                        if (flag != flag2)
                        {
                              return smethod_14(integer);
                        }
                        return integer;
                  }
                  if ((flag != flag2) && (integer.uint_0[index] == 0x80000000))
                  {
                        if (integer.int_2 == 1)
                        {
                              return integer;
                        }
                        bool flag3 = true;
                        for (int k = 0; k < (integer.int_2 - 1); k++)
                        {
                              if (!flag3)
                              {
                                    break;
                              }
                              if (integer.uint_0[k] != 0)
                              {
                                    flag3 = false;
                              }
                        }
                        if (flag3)
                        {
                              return integer;
                        }
                  }
                  throw new ArithmeticException("Multiplication overflow.");
            }

            public static BigInteger smethod_9(BigInteger class117_0, int int_3)
            {
                  BigInteger integer = new BigInteger();
                  return new BigInteger(class117_0) { int_2 = smethod_10(integer.uint_0, int_3) };
            }

            public override string ToString() =>
                this.method_3(10);

            private static void ZYDNGuard()
            {
            }
      }
}

