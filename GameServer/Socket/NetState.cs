namespace ns10
{
      using Microsoft.Win32;
      using Microsoft.Win32.SafeHandles;
      using ns12;
      using ns13;
      using ns3;
      using ns4;
      using ns5;
      using ns6;
      using ns7;
      using System;
      using System.Collections;
      using System.IO;
      using System.Net;
      using System.Net.Sockets;
      using System.Runtime.InteropServices;
      using System.Text;
      using System.Threading;
      using System.Timers;

      public class NetState: IDisposable
      {
            private AsyncCallback asyncCallback_0;
            private AsyncCallback asyncCallback_1;
            public bool bool_0;
            public bool bool_1;
            public bool bool_2;
            private bool bool_3;
            private bool bool_4;
            public bool bool_5;
            private bool bool_6;
            private byte[] byte_0 = new byte[] {
            4, 0x3b, 0xc2, 0x7c, 0xec, 0xeb, 0x3f, 0x8b, 0x34, 0x83, 0x5b, 0x24, 0x43, 0xf8, 0x6a, 0x20,
            0xc1, 0xe7, 2, 0xe8, 0x5c, 0xed, 0xf1, 0xff, 0x59, 0x8b, 13, 8, 0x33, 0x41, 0, 0x89
        };
            private byte[] byte_1 = new byte[0x10000];
            private byte[] byte_2;
            public byte[] byte_3 = new byte[] { 0xc9, 0x27, 0x93, 1, 0xa2, 0x6c, 0x31, 0x97 };
            private SendQueue class131_0;
            private Players class15_0;
            private ByteQueue class27_0;
            private static BufferPool class71_0;
            public DateTime dateTime_0 = DateTime.Now;
            private DateTime dateTime_1 = DateTime.Now;
            private DateTime dateTime_2 = DateTime.Now;
            public DateTime dateTime_3 = DateTime.Now;
            private Enum0 enum0_0;
            private const int int_0 = 0x400;
            private const int int_1 = 0x3e8;
            public int int_2 = 0x7f75e316;
            public int int_3;
            public int int_6;
            private IPAddress ipaddress_0;
            private ManualResetEvent manualResetEvent_0 = new ManualResetEvent(false);
            private object object_0 = new object();
            private object object_1 = new object();
            private System.Collections.Queue queue_0 = System.Collections.Queue.Synchronized(new System.Collections.Queue());
            private Socket socket_0;
            private string string_0;
            public System.Timers.Timer timer_0;

            static NetState()
            {
                  ZYDNGuard();
            }

            public NetState(Socket socket)
            {
                  this.dateTime_3 = DateTime.Now;
                  this.socket_0 = socket;
                  this.bool_3 = false;
                  this.class131_0 = new SendQueue();
                  this.class27_0 = new ByteQueue();
                  this.byte_2 = class71_0.method_1();
                  try
                  {
                        this.ipaddress_0 = ((IPEndPoint)this.socket_0.RemoteEndPoint).Address;
                        this.string_0 = this.ipaddress_0.ToString();
                  }
                  catch
                  {
                        this.ipaddress_0 = IPAddress.None;
                        this.string_0 = "(error)";
                  }
                  this.int_3 = (int)socket.Handle;
                  this.Player = new Players(this);
                  this.addWorldID();
                  Form1.WriteLine(3, this.int_3 + " 连接 " + this.ToString());
                  this.offLineStatus = false;
                  this.timer_0 = new System.Timers.Timer((double)World.Phien_ban_nghiem_chung_Thoi_gian);
                  this.timer_0.Elapsed += new ElapsedEventHandler(this.disconnectionevent);
                  this.timer_0.AutoReset = true;
                  this.timer_0.Enabled = true;
            }

            private void disconnectionevent(object sender, ElapsedEventArgs e)
            {
                  if (!this.bool_5)
                  {
                        Form1.WriteLine(1, this.int_3 + " Automatic disconnection event " + this.ToString());
                        this.DisposeSocket(false);
                  }
                  if (this.timer_0 != null)
                  {
                        this.timer_0.Enabled = false;
                        this.timer_0.Close();
                        this.timer_0.Dispose();
                  }
            }

            [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern SafeFileHandle CreateIoCompletionPort(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, uint uint_0);
            public void Dispose()
            {
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "Dispose()");
                  }
                  this.DisposeSocket(true);
            }

            private void InternalBeginReceive(byte[] byte_4)
            {
                  try
                  {
                        if (World.jlMsg == 1)
                        {
                              Form1.WriteLine(0, "InternalBeginReceive()");
                        }
                        this.enum0_0 |= Enum0.flag_1;
                        this.socket_0.IOControl(IOControlCode.KeepAliveValues, byte_4, null);
                        this.socket_0.BeginReceive(this.byte_2, 0, this.byte_2.Length, SocketFlags.None, this.asyncCallback_0, this.socket_0);
                  }
                  catch (Exception)
                  {
                        this.DisposeSocket(false);
                  }
            }

            ~NetState()
            {
            }

            [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern bool GetQueuedCompletionStatus(SafeFileHandle safeFileHandle_0, out uint uint_0, out IntPtr intptr_0, out IntPtr intptr_1, uint uint_1);
            public void addWorldID()
            {
                  try
                  {
                        int key = 300;
                        while (key < 0x186a0)
                        {
                              if (!World.threadSafeDictionary_0.ContainsKey(key))
                              {
                                    goto Label_0023;
                              }
                              key++;
                        }
                        return;
                        Label_0023:
                        this.int_3 = key;
                        World.threadSafeDictionary_0.Add(key, this);
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, string.Concat(new object[] { "addWorldIdd()出错", this.int_3, "|", this.ToString(), " ", exception.Message }));
                  }
            }

            public void delWorldID()
            {
                  try
                  {
                        World.threadSafeDictionary_0.Remove(this.int_3);
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, string.Concat(new object[] { "delWorldIdd()出错", this.int_3, "|", this.ToString(), " ", exception.Message }));
                  }
            }

            private void method_10(byte[] byte_4, int int_7, int int_8)
            {
                  byte[] dst = new byte[int_7 + 0x11];
                  dst[0] = 170;
                  dst[1] = 0x55;
                  System.Buffer.BlockCopy(BitConverter.GetBytes((int)(int_7 + 11)), 0, dst, 2, 2);
                  System.Buffer.BlockCopy(BitConverter.GetBytes(int_8), 0, dst, 5, 2);
                  System.Buffer.BlockCopy(byte_4, 0, dst, 7, int_7);
                  dst[dst.Length - 2] = 0x55;
                  dst[dst.Length - 1] = 170;
                  this.Send(dst, dst.Length);
                  //Form1.WriteLine(1, "Send Quest Data4: (" + BitConverter.ToString(dst).Replace("-", "") + ")");
            }

            public void method_11(byte[] byte_4, int int_7)
            {
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "Send单包()");
                  }
                  if (((this.socket_0 != null) && this.bool_3) && this.socket_0.Connected)
                  {
                        byte[] dst = new byte[BitConverter.ToInt16(byte_4, 9) + 7];
                        System.Buffer.BlockCopy(byte_4, 5, dst, 0, dst.Length);
                        this.method_12(dst, dst.Length);
                  }
            }

            private void method_12(byte[] byte_4, int int_7)
            {
                  byte[] dst = new byte[int_7 + 15];
                  dst[0] = 170;
                  dst[1] = 0x55;
                  System.Buffer.BlockCopy(BitConverter.GetBytes((int)(int_7 + 9)), 0, dst, 2, 2);
                  System.Buffer.BlockCopy(byte_4, 0, dst, 5, int_7);
                  dst[dst.Length - 2] = 0x55;
                  dst[dst.Length - 1] = 170;
                  this.Send(dst, dst.Length);
            }

            private int method_13(byte[] byte_4, int int_7, out byte[] byte_5)
            {
                  byte_5 = new byte[(int_7 + (int_7 / 0x20)) + 1];
                  int num = 0;
                  int num2 = 0;
                  int index = 6;
                  int num4 = 5;
                  int num5 = 0;
                  int num6 = 0;
                  int num7 = 0;
                  try
                  {
                        goto Label_00E9;
                        Label_0025:
                        if ((index - num4) >= 0xff)
                        {
                              goto Label_00E3;
                        }
                        while (num5 < 0xff)
                        {
                              if (((num4 + num5) >= int_7) || ((index + num5) >= int_7))
                              {
                                    break;
                              }
                              if (byte_4[index + num5] != byte_4[num4 + num5])
                              {
                                    goto Label_0067;
                              }
                              num6++;
                              num5++;
                        }
                        goto Label_00A6;
                        Label_0067:
                        if (num6 >= 3)
                        {
                              if ((byte_4[index] == byte_4[num4 - 1]) && ((index - num4) < 0xfe))
                              {
                                    num7 = 1;
                              }
                              else
                              {
                                    this.method_14(index, num4, num5, num6, byte_4, ref num2, ref num, ref byte_5);
                                    index = num2;
                                    num4 = num2;
                                    num7 = 0;
                                    num6 = 0;
                              }
                        }
                        else
                        {
                              num6 = 0;
                        }
                        Label_00A6:
                        if ((num6 >= 3) && ((byte_4[index] != byte_4[num4 - 1]) || (num7 == 0)))
                        {
                              this.method_14(index, num4, num5, num6, byte_4, ref num2, ref num, ref byte_5);
                              index = num2;
                              num4 = num2;
                              num7 = 0;
                        }
                        num5 = 0;
                        num6 = 0;
                        num4--;
                        Label_00DC:
                        if (num4 > 1)
                        {
                              goto Label_0025;
                        }
                        Label_00E3:
                        num4 = index;
                        index++;
                        Label_00E9:
                        if (index <= int_7)
                        {
                              goto Label_00DC;
                        }
                        if (num2 >= int_7)
                        {
                              return num;
                        }
                        int num8 = int_7 - num2;
                        if (num8 > 0x20)
                        {
                              int num10 = 0;
                              byte[] dst = new byte[num8];
                              System.Buffer.BlockCopy(byte_4, num2, dst, 0, dst.Length);
                              byte[] src = this.method_16(dst, dst.Length, out num10);
                              if (num == 0)
                              {
                                    byte_5 = new byte[src.Length];
                              }
                              System.Buffer.BlockCopy(src, 0, byte_5, num, num10);
                              num += num10;
                              num2 += num8;
                              return num;
                        }
                        if (num8 > 0)
                        {
                              byte_5[num++] = (byte)((int_7 - num2) - 1);
                              System.Buffer.BlockCopy(byte_4, num2, byte_5, num, int_7 - num2);
                              num += int_7 - num2;
                              num2 += int_7 - num2;
                        }
                  }
                  catch (Exception exception1)
                  {
                        Console.WriteLine(exception1);
                  }
                  return num;
            }

            private void method_14(int int_7, int int_8, int int_9, int int_10, byte[] byte_4, ref int int_11, ref int int_12, ref byte[] byte_5)
            {
                  int num4;
                  int num = int_7 - int_11;
                  if (num > 0x20)
                  {
                        int count = 0;
                        byte[] dst = new byte[num];
                        System.Buffer.BlockCopy(byte_4, int_11, dst, 0, dst.Length);
                        System.Buffer.BlockCopy(this.method_16(dst, dst.Length, out count), 0, byte_5, int_12, count);
                        int_12 += count;
                        int_11 += num;
                  }
                  else if (num > 0)
                  {
                        num4 = int_12;
                        int_12 = num4 + 1;
                        byte_5[num4] = (byte)(num - 1);
                        System.Buffer.BlockCopy(byte_4, int_11, byte_5, int_12, int_7 - int_11);
                        int_12 += int_7 - int_11;
                        int_11 += int_7 - int_11;
                  }
                  int num2 = int_10 - 2;
                  if (num2 < 7)
                  {
                        num4 = int_12;
                        int_12 = num4 + 1;
                        byte_5[num4] = (byte)(num2 = num2 << 5);
                        int num5 = (int_7 - int_8) - 1;
                        num4 = int_12;
                        int_12 = num4 + 1;
                        byte_5[num4] = (byte)num5;
                  }
                  else
                  {
                        num4 = int_12;
                        int_12 = num4 + 1;
                        byte_5[num4] = 0xe0;
                        int num6 = (int_10 - 2) - 7;
                        num4 = int_12;
                        int_12 = num4 + 1;
                        byte_5[num4] = (byte)num6;
                        int num7 = (int_7 - int_8) - 1;
                        num4 = int_12;
                        int_12 = num4 + 1;
                        byte_5[num4] = (byte)num7;
                  }
                  int_11 += int_10;
            }

            private byte[] method_15(byte[] byte_4, int int_7, out int int_8)
            {
                  try
                  {
                        int num10;
                        byte[] dst = new byte[(int_7 + (int_7 / 0x20)) + 1];
                        int_8 = 0;
                        int srcOffset = 0;
                        int num2 = 10;
                        int num3 = 0;
                        bool flag = false;
                        for (int i = 0; i < byte_4.Length; i++)
                        {
                              for (int j = num2; j < i; j++)
                              {
                                    if ((i - j) > 0xff)
                                    {
                                          j = i - 0xff;
                                    }
                                    for (int k = 0; k < ((byte_4.Length - i) - 2); k++)
                                    {
                                          if ((k >= ((byte_4.Length - j) - 2)) || (k >= 0xff))
                                          {
                                                break;
                                          }
                                          if (byte_4[j + k] != byte_4[i + k])
                                          {
                                                goto Label_008C;
                                          }
                                          num3++;
                                    }
                                    goto Label_02F9;
                                    Label_008C:
                                    if (flag)
                                    {
                                          if (num3 >= 3)
                                          {
                                                if (i > srcOffset)
                                                {
                                                      int num8 = (i - srcOffset) - 1;
                                                      if (num8 > 0x1f)
                                                      {
                                                            int count = 0;
                                                            byte[] buffer2 = new byte[num8 + 1];
                                                            System.Buffer.BlockCopy(byte_4, srcOffset, buffer2, 0, buffer2.Length);
                                                            System.Buffer.BlockCopy(this.method_16(buffer2, buffer2.Length, out count), 0, dst, int_8, count);
                                                            int_8 += count;
                                                            srcOffset += num8 + 1;
                                                      }
                                                      else if (num8 >= 0)
                                                      {
                                                            num10 = int_8;
                                                            int_8 = num10 + 1;
                                                            dst[num10] = (byte)num8;
                                                            System.Buffer.BlockCopy(byte_4, srcOffset, dst, int_8, i - srcOffset);
                                                            int_8 += i - srcOffset;
                                                            srcOffset += i - srcOffset;
                                                      }
                                                }
                                                int num7 = num3 - 2;
                                                if (num7 < 7)
                                                {
                                                      num10 = int_8;
                                                      int_8 = num10 + 1;
                                                      dst[num10] = (byte)(num7 = num7 << 5);
                                                      int num11 = (srcOffset - 1) - j;
                                                      num10 = int_8;
                                                      int_8 = num10 + 1;
                                                      dst[num10] = (byte)num11;
                                                }
                                                else
                                                {
                                                      num10 = int_8;
                                                      int_8 = num10 + 1;
                                                      dst[num10] = 0xe0;
                                                      int num12 = (num3 - 2) - 7;
                                                      num10 = int_8;
                                                      int_8 = num10 + 1;
                                                      dst[num10] = (byte)num12;
                                                      int num13 = (srcOffset - j) - 1;
                                                      num10 = int_8;
                                                      int_8 = num10 + 1;
                                                      dst[num10] = (byte)num13;
                                                }
                                                srcOffset += num3;
                                                num2 = i / 2;
                                                if (num2 > 0xff)
                                                {
                                                      num2 = i - 0xff;
                                                }
                                                i = srcOffset;
                                                num3 = 0;
                                          }
                                          else
                                          {
                                                num3 = 0;
                                          }
                                    }
                                    else if (num3 >= 3)
                                    {
                                          int num14 = (i - srcOffset) - 1;
                                          if (num14 > 0x1f)
                                          {
                                                int num16 = 0;
                                                byte[] buffer3 = new byte[num14 + 1];
                                                System.Buffer.BlockCopy(byte_4, srcOffset, buffer3, 0, buffer3.Length);
                                                System.Buffer.BlockCopy(this.method_16(buffer3, buffer3.Length, out num16), 0, dst, int_8, num16);
                                                int_8 += num16;
                                                srcOffset += num14 + 1;
                                          }
                                          else if (num14 >= 0)
                                          {
                                                num10 = int_8;
                                                int_8 = num10 + 1;
                                                dst[num10] = (byte)((i - srcOffset) - 1);
                                                System.Buffer.BlockCopy(byte_4, srcOffset, dst, int_8, i - srcOffset);
                                                int_8 += i - srcOffset;
                                                srcOffset += i - srcOffset;
                                          }
                                          int num15 = num3 - 2;
                                          if (num15 < 7)
                                          {
                                                num10 = int_8;
                                                int_8 = num10 + 1;
                                                dst[num10] = (byte)(num15 = num15 << 5);
                                                int num17 = (srcOffset - 1) - j;
                                                num10 = int_8;
                                                int_8 = num10 + 1;
                                                dst[num10] = (byte)num17;
                                          }
                                          else
                                          {
                                                num10 = int_8;
                                                int_8 = num10 + 1;
                                                dst[num10] = 0xe0;
                                                int num18 = (num3 - 2) - 7;
                                                num10 = int_8;
                                                int_8 = num10 + 1;
                                                dst[num10] = (byte)num18;
                                                int num19 = (srcOffset - j) - 1;
                                                num10 = int_8;
                                                int_8 = num10 + 1;
                                                dst[num10] = (byte)num19;
                                          }
                                          srcOffset += num3;
                                          num2 = i / 2;
                                          i = srcOffset;
                                          flag = true;
                                          num3 = 0;
                                    }
                                    else
                                    {
                                          num3 = 0;
                                    }
                                    Label_02F9:
                                    if (num3 > 3)
                                    {
                                          if ((i - srcOffset) > 0)
                                          {
                                                num10 = int_8;
                                                int_8 = num10 + 1;
                                                dst[num10] = (byte)((i - srcOffset) - 1);
                                                System.Buffer.BlockCopy(byte_4, srcOffset, dst, int_8, i - srcOffset);
                                                int_8 += i - srcOffset;
                                                srcOffset += i - srcOffset;
                                          }
                                          int num20 = num3 - 2;
                                          if (num20 < 7)
                                          {
                                                num10 = int_8;
                                                int_8 = num10 + 1;
                                                dst[num10] = (byte)(num20 = num20 << 5);
                                                int num21 = (i - 1) - j;
                                                num10 = int_8;
                                                int_8 = num10 + 1;
                                                dst[num10] = (byte)num21;
                                          }
                                          else
                                          {
                                                num10 = int_8;
                                                int_8 = num10 + 1;
                                                dst[num10] = 0xe0;
                                                int num22 = (num3 - 2) - 7;
                                                num10 = int_8;
                                                int_8 = num10 + 1;
                                                dst[num10] = (byte)num22;
                                                int num23 = (srcOffset - j) - 1;
                                                num10 = int_8;
                                                int_8 = num10 + 1;
                                                dst[num10] = (byte)num23;
                                          }
                                          srcOffset += num3;
                                          num2 = i;
                                          i = srcOffset;
                                          num3 = 0;
                                    }
                                    else
                                    {
                                          num3 = 0;
                                    }
                              }
                        }
                        if (srcOffset <= (int_7 - 2))
                        {
                              num10 = int_8;
                              int_8 = num10 + 1;
                              dst[num10] = (byte)((int_7 - srcOffset) - 1);
                              System.Buffer.BlockCopy(byte_4, srcOffset, dst, int_8, int_7 - srcOffset);
                              int_8 += int_7 - srcOffset;
                              srcOffset += int_7 - srcOffset;
                        }
                        else
                        {
                              num10 = int_8;
                              int_8 = num10 + 1;
                              dst[num10] = 1;
                              num10 = int_8;
                              int_8 = num10 + 1;
                              dst[num10] = 0;
                              num10 = int_8;
                              int_8 = num10 + 1;
                              dst[num10] = 0;
                        }
                        return dst;
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, string.Concat(new object[] { "Send()SendDuopak2", this.int_3, "|", exception.Message }));
                        int_8 = int_7;
                        return byte_4;
                  }
            }

            private byte[] method_16(byte[] byte_4, int int_7, out int int_8)
            {
                  try
                  {
                        int num = 10;
                        int num2 = int_7 / 10;
                        while (((int_7 - (num2 * num)) > 0) && ((int_7 - (num2 * num)) < 2))
                        {
                              num++;
                              num2 = int_7 / num;
                        }
                        if ((int_7 % num) > 0)
                        {
                              num2++;
                        }
                        byte[] dst = new byte[int_7 + num2];
                        int srcOffset = 0;
                        int index = 0;
                        int count = num;
                        do
                        {
                              if ((srcOffset + count) >= int_7)
                              {
                                    count = int_7 - srcOffset;
                                    dst[index] = (byte)(count - 1);
                                    System.Buffer.BlockCopy(byte_4, srcOffset, dst, index + 1, count);
                                    srcOffset += count;
                                    index += count + 1;
                              }
                              else
                              {
                                    dst[index] = (byte)(count - 1);
                                    System.Buffer.BlockCopy(byte_4, srcOffset, dst, index + 1, count);
                                    srcOffset += count;
                                    index += count + 1;
                                    count = num;
                              }
                        }
                        while (srcOffset < int_7);
                        int_8 = index;
                        return dst;
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, string.Concat(new object[] { "Send()SendDuopak", this.int_3, "|", exception.Message }));
                        int_8 = int_7;
                        return byte_4;
                  }
            }

            public void method_18()
            {
                  if (this.socket_0 != null)
                  {
                        try
                        {
                              this.socket_0.Shutdown(SocketShutdown.Both);
                        }
                        catch (Exception exception1)
                        {
                              Console.WriteLine(exception1);
                        }
                        try
                        {
                              this.socket_0.Close();
                        }
                        catch (Exception exception2)
                        {
                              Console.WriteLine(exception2);
                        }
                        this.socket_0 = null;
                        this.bool_6 = true;
                        this.offLineStatus = true;
                  }
            }

            public void method_19(byte[] byte_4, int int_7)
            {
                  try
                  {
                        if (World.jlMsg == 1)
                        {
                              Form1.WriteLine(0, "ThreadProca");
                        }
                        if (((this.socket_0 != null) && this.bool_3) && this.socket_0.Connected)
                        {
                              try
                              {
                                    SendQueue.Class132 class2;
                                    using (new Lock(this.class131_0, "Send"))
                                    {
                                          class2 = this.class131_0.method_2(byte_4, int_7);
                                    }
                                    if (class2 != null)
                                    {
                                          try
                                          {
                                                this.socket_0.BeginSend(class2.Buffers, 0, class2.Length, SocketFlags.None, this.asyncCallback_1, this.socket_0);
                                          }
                                          catch (Exception)
                                          {
                                                this.DisposeSocket(false);
                                          }
                                    }
                              }
                              catch (Exception1)
                              {
                                    Form1.WriteLine(1, string.Concat(new object[] { "Send()_数据列队以满", this.int_3, "|", this.ToString() }));
                                    this.DisposeSocket(false);
                              }
                        }
                  }
                  catch (StackOverflowException)
                  {
                        this.DisposeSocket(false);
                  }
                  catch (SocketException)
                  {
                        this.DisposeSocket(false);
                  }
                  catch (Exception)
                  {
                        this.DisposeSocket(false);
                  }
            }

            public void method_2()
            {
                  this.asyncCallback_0 = new AsyncCallback(this.OnReceive);
                  this.asyncCallback_1 = new AsyncCallback(this.method_20);
                  this.bool_3 = true;
                  if (this.socket_0 == null)
                  {
                        this.DisposeSocket(false);
                  }
                  else
                  {
                        try
                        {
                              if ((this.enum0_0 & (Enum0.flag_0 | Enum0.flag_1)) == 0)
                              {
                                    byte[] array = new byte[Marshal.SizeOf(0) * 3];
                                    BitConverter.GetBytes((uint)1).CopyTo(array, 0);
                                    BitConverter.GetBytes((uint)0x4e20).CopyTo(array, Marshal.SizeOf(0));
                                    BitConverter.GetBytes((uint)0x4e20).CopyTo(array, (int)(Marshal.SizeOf(0) * 2));
                                    this.socket_0.UseOnlyOverlappedIO = true;
                                    this.InternalBeginReceive(array);
                              }
                        }
                        catch (Exception exception)
                        {
                              Form1.WriteLine(1, string.Concat(new object[] { "Start()出错", this.int_3, "|", this.ToString(), " ", exception.Message }));
                              this.DisposeSocket(false);
                        }
                  }
            }

            private void method_20(IAsyncResult iasyncResult_0)
            {
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "OnSend");
                  }
                  Socket asyncState = (Socket)iasyncResult_0.AsyncState;
                  if (this.socket_0 == null)
                  {
                        this.DisposeSocket(false);
                  }
                  else
                  {
                        try
                        {
                              if (this.socket_0.Connected && this.bool_3)
                              {
                                    int num = asyncState.EndSend(iasyncResult_0);
                                    World.double_8 += num;
                                    if (num <= 0)
                                    {
                                          this.DisposeSocket(false);
                                    }
                                    else
                                    {
                                          SendQueue.Class132 class2;
                                          using (new Lock(this.class131_0, "OnSend"))
                                          {
                                                class2 = this.class131_0.method_1();
                                          }
                                          if (class2 != null)
                                          {
                                                try
                                                {
                                                      asyncState.BeginSend(class2.Buffers, 0, class2.Length, SocketFlags.None, this.asyncCallback_1, asyncState);
                                                }
                                                catch (Exception)
                                                {
                                                      this.DisposeSocket(false);
                                                }
                                          }
                                    }
                              }
                        }
                        catch (Exception)
                        {
                              this.DisposeSocket(false);
                        }
                  }
            }

            private void OnReceive(IAsyncResult iasyncResult_0)
            {
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "OnReceive");
                  }
                  Socket asyncState = (Socket)iasyncResult_0.AsyncState;
                  try
                  {
                        int num = 0;
                        try
                        {
                              num = asyncState.EndReceive(iasyncResult_0);
                        }
                        catch (ArgumentNullException exception)
                        {
                              Form1.WriteLine(1, string.Concat(new object[] { "OnReceive()1出错", this.int_3, "|", this.ToString(), " ", exception.Message }));
                              this.DisposeSocket(false);
                        }
                        catch (ArgumentException exception2)
                        {
                              Form1.WriteLine(1, string.Concat(new object[] { "OnReceive()2出错", this.int_3, "|", this.ToString(), " ", exception2.Message }));
                              this.DisposeSocket(false);
                        }
                        catch (InvalidOperationException)
                        {
                              this.DisposeSocket(false);
                        }
                        catch (SocketException)
                        {
                              this.DisposeSocket(false);
                        }
                        catch (Exception exception3)
                        {
                              Form1.WriteLine(1, string.Concat(new object[] { "OnReceive()5出错", this.int_3, "|", this.ToString(), " ", exception3.Message }));
                              this.DisposeSocket(false);
                        }
                        if (num > 0)
                        {
                              World.double_10 += num;
                              byte[] buffer = this.byte_2;
                              using (new Lock(this.class27_0, "this.m_Buffer"))
                              {
                                    this.class27_0.method_6(buffer, 0, num);
                              }
                              this.HandleReceive(this);
                              if (this.bool_6)
                              {
                                    return;
                              }
                              this.enum0_0 &= ~Enum0.flag_1;
                              if ((this.enum0_0 & Enum0.flag_0) != 0)
                              {
                                    return;
                              }
                              try
                              {
                                    byte[] array = new byte[Marshal.SizeOf(0) * 3];
                                    BitConverter.GetBytes((uint)1).CopyTo(array, 0);
                                    BitConverter.GetBytes((uint)0x4e20).CopyTo(array, Marshal.SizeOf(0));
                                    BitConverter.GetBytes((uint)0x4e20).CopyTo(array, (int)(Marshal.SizeOf(0) * 2));
                                    this.InternalBeginReceive(array);
                                    return;
                              }
                              catch (Exception)
                              {
                                    this.DisposeSocket(false);
                                    return;
                              }
                        }
                        this.DisposeSocket(false);
                  }
                  catch (Exception exception4)
                  {
                        Form1.WriteLine(1, string.Concat(new object[] { "OnReceive()6出错", this.int_3, "|", this.ToString(), " ", exception4 }));
                        this.DisposeSocket(false);
                  }
            }

            private void ProcessDataReceived(byte[] byte_4, int int_7)
            {
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "ProcessDataReceived");
                  }
                  try
                  {
                        Form1.WriteLine(0, "NetState method_22 " + BitConverter.ToString(byte_4).Replace("-",""));

                        byte[] buffer;
                        int srcOffset = 0;
                        if ((170 != byte_4[0]) || (0x55 != byte_4[1]))
                        {
                              return;
                        }
                        byte[] dst = new byte[2];
                        System.Buffer.BlockCopy(byte_4, 2, dst, 0, 2);
                        int num2 = BitConverter.ToInt16(dst, 0);
                        goto Label_00F9;
                        Label_004A:
                        buffer = new byte[num2 + 6];
                        if (((srcOffset + num2) + 6) > int_7)
                        {
                              return;
                        }
                        System.Buffer.BlockCopy(byte_4, srcOffset, buffer, 0, num2 + 6);
                        srcOffset += num2 + 6;
                        if (World.Log == 1)
                        {
                              string str = Converter.smethod_24(buffer);
                              Form1.WriteLine(7, str);
                        }
                        if ((buffer[buffer.Length - 2] != 0x55) || (buffer[buffer.Length - 1] != 170))
                        {
                              return;
                        }
                        this.Player.ManagePacket(buffer, buffer.Length);
                        if (((srcOffset >= int_7) || (byte_4[srcOffset] != 170)) || (byte_4[srcOffset + 1] != 0x55))
                        {
                              return;
                        }
                        System.Buffer.BlockCopy(byte_4, srcOffset + 2, dst, 0, 2);
                        num2 = BitConverter.ToInt16(dst, 0);
                        Label_00F9:
                        while (World.jlMsg == 1)
                        {
                              Form1.WriteLine(0, "ProcessDataReceived");
                              break;
                        }
                        goto Label_004A;
                  }
                  catch (Exception exception)
                  {
                        byte[] buffer3 = new byte[int_7];
                        System.Buffer.BlockCopy(byte_4, 0, buffer3, 0, int_7);
                        string str2 = Converter.smethod_24(buffer3);
                        Form1.WriteLine(1, string.Concat(new object[] { "ProcessDataReceived()出错", this.int_3, "|", this.ToString(), " ", str2, "  ", exception.ToString() }));
                        this.DisposeSocket(false);
                  }
            }

            private void HandleReceive(NetState class16_0)
            {
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "HandleReceive");
                  }
                  try
                  {
                        if ((this.Buffer != null) && (this.Buffer.Length > 0))
                        {
                              using (new Lock(this.Buffer, "HandleReceive"))
                              {
                                    int length = this.Buffer.Length;
                                    while (length > 0)
                                    {
                                          if (!this.Running)
                                          {
                                                break;
                                          }
                                          if (World.jlMsg == 1)
                                          {
                                                Form1.WriteLine(0, "HandleReceive");
                                          }
                                          if (length <= 4)
                                          {
                                                break;
                                          }
                                          int num2 = BitConverter.ToInt16(this.Buffer.method_2(), 0);
                                          if (num2 <= 0)
                                          {
                                                goto Label_0178;
                                          }
                                          num2 += 6;
                                          if (length < num2)
                                          {
                                                goto Label_01A8;
                                          }
                                          byte[] buffer = new byte[num2];
                                          this.Buffer.method_5(buffer, 0, num2);
                                          length = this.Buffer.Length;
                                          if ((170 != buffer[0]) || (0x55 != buffer[1]))
                                          {
                                                goto Label_0198;
                                          }
                                          if ((buffer[num2 - 2] != 0x55) || (buffer[num2 - 1] != 170))
                                          {
                                                goto Label_0188;
                                          }
                                          if (World.Co_hay_khong_ma_hoa == 1)
                                          {
                                                if (World.Do_bo_thiet_bi_hinh_thuc == 1)
                                                {
                                                      this.method_24(ref buffer);
                                                }
                                                else if (World.Do_bo_thiet_bi_hinh_thuc == 0)
                                                {
                                                      byte[] dst = new byte[num2 - 6];
                                                      System.Buffer.BlockCopy(buffer, 4, dst, 0, dst.Length);
                                                      RxjhDeBuf.Decrypt(dst, dst.Length);
                                                      System.Buffer.BlockCopy(dst, 0, buffer, 4, dst.Length);
                                                }
                                          }
                                          if (World.Log == 1)
                                          {
                                                string str = Converter.smethod_24(buffer);
                                                Form1.WriteLine(7, str);
                                          }
                                          this.Player.ManagePacket(buffer, buffer.Length);
                                    }
                                    return;
                                    Label_0178:
                                    this.Buffer.method_0();
                                    return;
                                    Label_0188:
                                    this.Buffer.method_0();
                                    return;
                                    Label_0198:
                                    this.Buffer.method_0();
                                    return;
                                    Label_01A8:
                                    if ((170 != this.Buffer.byte_0[0]) && (0x55 != this.Buffer.byte_0[1]))
                                    {
                                          this.Buffer.method_0();
                                    }
                              }
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, string.Concat(new object[] { "HandleReceive()出错", this.int_3, "|", this.ToString(), " ", exception }));
                        this.DisposeSocket(false);
                  }
            }

            private void method_24(ref byte[] byte_4)
            {
                  byte num = 0;
                  for (int i = 0; i < (byte_4.Length - 6); i++)
                  {
                        byte_4[4 + i] = (byte)((byte_4[4 + i] ^ this.byte_3[i % 8]) ^ num);
                        num = byte_4[4 + i];
                  }
            }

            public void method_25()
            {
                  try
                  {
                        if (World.jlMsg == 1)
                        {
                              Form1.WriteLine(0, "ThreadProca");
                        }
                        if (this.Player != null)
                        {
                              World.class20_0.method_4(string.Concat(new object[] { "用户登出|", this.Player.Userid, "|", World.Server_ID }));
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, string.Concat(new object[] { "IDout()出错", this.int_3, "|", this.ToString(), " ", exception.Message }));
                  }
            }

            private bool method_26()
            {
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "ThreadProca");
                  }
                  if ((this.socket_0 != null) && this.class131_0.IsFlushReady)
                  {
                        SendQueue.Class132 class2;
                        SendQueue queue = this.class131_0;
                        lock (queue)
                        {
                              class2 = this.class131_0.method_0();
                        }
                        if (class2 != null)
                        {
                              bool flag;
                              try
                              {
                                    this.socket_0.BeginSend(class2.Buffers, 0, class2.Length, SocketFlags.None, this.asyncCallback_1, this.socket_0);
                                    flag = true;
                              }
                              catch (Exception)
                              {
                                    goto Label_007C;
                              }
                              return flag;
                        }
                  }
                  Label_007C:
                  return false;
            }

            private void DisposeSocket(bool bool_7)
            {
                  int num = 0;
                  try
                  {
                        if (World.jlMsg == 1)
                        {
                              Form1.WriteLine(0, "Dispose()");
                        }
                        this.offLineStatus = false;
                        num = 1;
                        this.bool_6 = true;
                        if (!World.queue_0.Contains(this))
                        {
                              num = 2;
                              this.bool_3 = false;
                              Form1.WriteLine(3, this.int_3 + " 断开 " + this.ToString());
                              num = 3;
                              if (this.class131_0 != null)
                              {
                                    num = 0x1f;
                                    if (!this.class131_0.IsEmpty)
                                    {
                                          num = 0x20;
                                          using (new Lock(this.class131_0, "Dispose()"))
                                          {
                                                num = 0x21;
                                                this.class131_0.method_5();
                                          }
                                    }
                                    num = 0x22;
                                    this.class131_0.Dispose();
                                    num = 0x23;
                                    this.class131_0 = null;
                              }
                              num = 4;
                              if (this.class27_0 != null)
                              {
                                    this.class27_0.Dispose();
                                    this.class27_0 = null;
                              }
                              num = 5;
                              if (this.socket_0 != null)
                              {
                                    try
                                    {
                                          this.socket_0.Shutdown(SocketShutdown.Both);
                                    }
                                    catch (Exception exception1)
                                    {
                                          Console.WriteLine(exception1);
                                    }
                                    try
                                    {
                                          this.socket_0.Close();
                                    }
                                    catch (Exception exception4)
                                    {
                                          Console.WriteLine(exception4);
                                    }
                                    this.socket_0 = null;
                              }
                              num = 6;
                              if (this.byte_2 != null)
                              {
                                    class71_0.method_2(this.byte_2);
                              }
                              this.byte_2 = null;
                              this.asyncCallback_0 = null;
                              this.asyncCallback_1 = null;
                              this.bool_3 = false;
                              this.queue_0 = null;
                              if (this.timer_0 != null)
                              {
                                    this.timer_0.Enabled = false;
                                    this.timer_0.Close();
                                    this.timer_0.Dispose();
                              }
                              num = 7;
                              World.queue_0.Enqueue(this);
                              if (World.threadSafeDictionary_0.ContainsKey(this.int_3))
                              {
                                    try
                                    {
                                          World.threadSafeDictionary_0.imethod_1(this.int_3);
                                    }
                                    catch (Exception exception)
                                    {
                                          Form1.WriteLine(1, string.Concat(new object[] { "移除断开玩家连接信息出错", this.int_3, "|", this.ToString(), " ", exception.Message }));
                                    }
                              }
                              if (World.threadSafeDictionary_2.ContainsKey(this.int_3))
                              {
                                    try
                                    {
                                          World.threadSafeDictionary_2.imethod_1(this.int_3);
                                    }
                                    catch (Exception exception2)
                                    {
                                          Form1.WriteLine(1, string.Concat(new object[] { "移除玩家多开列表项出错", this.int_3, "|", this.ToString(), " ", exception2.Message }));
                                    }
                              }
                        }
                  }
                  catch (Exception exception3)
                  {
                        Form1.WriteLine(1, string.Concat(new object[] { " Dispose(bool flush)出错", this.int_3, "|", this.ToString(), " [", num, "]", exception3.Message }));
                  }
            }

            public void method_3(byte[] byte_4, int int_7)
            {
                  if (((this.socket_0 != null) && this.bool_3) && this.socket_0.Connected)
                  {
                        Class17 class1 = new Class17();
                        GCHandle.Alloc(class1);
                        class1.class16_0 = this;
                        try
                        {
                              byte[] dst = new byte[BitConverter.ToInt16(byte_4, 9) + 6];
                              System.Buffer.BlockCopy(byte_4, 5, dst, 0, dst.Length);
                              this.queue_0.Enqueue(dst);
                        }
                        catch (Exception exception)
                        {
                              Form1.WriteLine(1, string.Concat(new object[] { "Send()_Send多包", this.int_3, "|", exception.Message }));
                        }
                  }
            }

            public void method_4(PacketData class143_0, int int_7, int int_8)
            {
                  try
                  {
                        byte[] buffer = class143_0.method_18(int_7, int_8);
                        this.method_9(buffer, buffer.Length, 1);
                        Form1.WriteLine(1, "Send Quest Data2: (" + BitConverter.ToString(buffer).Replace("-", "") + ")");

                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, string.Concat(new object[] { "Send()_Send多包知道错误", this.int_3, "主循环", int_7, "|", exception.Message }));
                  }
            }

            public void method_5(PacketData class143_0, int int_7, int int_8, byte byte_4)
            {
                  try
                  {
                        byte[] buffer = class143_0.method_20(int_7, int_8, byte_4);
                        this.method_8(buffer, buffer.Length);
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, string.Concat(new object[] { "Send()_Send多包知道错误", this.int_3, "主循环", int_7, "|", exception.Message }));
                  }
            }

            public void method_6(PacketData class143_0, int int_7, int int_8)
            {
                  try
                  {
                        byte[] buffer = class143_0.method_18(int_7, int_8);
                        this.method_11(buffer, buffer.Length);
                  }
                  catch (Exception)
                  {
                  }
            }

            public void method_7(string string_1)
            {
                  try
                  {
                        byte[] bytes = Encoding.Default.GetBytes(string_1);
                        this.method_19(bytes, bytes.Length);
                  }
                  catch (Exception)
                  {
                  }
            }

            public void method_8(byte[] byte_4, int int_7)
            {
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "Send多包()");
                  }
                  if ((this.socket_0 != null) && this.bool_3)
                  {
                        int num = 0;
                        try
                        {
                              num = 1;
                              byte[] dst = new byte[BitConverter.ToInt16(byte_4, 9) + 6];
                              num = 2;
                              System.Buffer.BlockCopy(byte_4, 5, dst, 0, dst.Length);
                              this.method_9(dst, dst.Length, 1);
                        }
                        catch (Exception exception)
                        {
                              string str = Converter.smethod_24(byte_4);
                              Form1.WriteLine(1, string.Concat(new object[] { "Send()_Send多包", this.int_3, "|", exception.Message, "错误地方", num, "封包", str }));
                        }
                  }
            }

            private void method_9(byte[] byte_4, int int_7, int int_8)
            {
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "Send多包加密()");
                  }
                  int num = 0;
                  try
                  {
                        byte[] buffer;
                        num = 1;
                        int num2 = this.method_13(byte_4, int_7, out buffer);
                        num = 2;
                        byte[] dst = new byte[num2 + 8];
                        num = 3;
                        System.Buffer.BlockCopy(BitConverter.GetBytes(0xc0), 0, dst, 0, 2);
                        num = 4;
                        System.Buffer.BlockCopy(BitConverter.GetBytes((int)(num2 + 4)), 0, dst, 2, 2);
                        num = 5;
                        System.Buffer.BlockCopy(BitConverter.GetBytes(num2), 0, dst, 4, 2);
                        num = 6;
                        System.Buffer.BlockCopy(BitConverter.GetBytes(int_7), 0, dst, 6, 2);
                        num = 7;
                        num = 8;
                        System.Buffer.BlockCopy(buffer, 0, dst, 8, num2);
                        num = 9;
                        this.method_10(dst, dst.Length, int_8);
                        //Form1.WriteLine(1, "Send Quest Data3: (" + BitConverter.ToString(dst).Replace("-", "") + ")");

                  }
                  catch (Exception exception)
                  {
                        byte[] buffer3;
                        int num3 = this.method_13(byte_4, int_7, out buffer3);
                        byte[] buffer4 = new byte[num3 + 8];
                        Form1.WriteLine(100, string.Concat(new object[] { "Send()_Send多包加密", this.int_3, "长度", int_7, "错误地方", num, "outlin", num3, "-newBuffer长度-", buffer4.Length, "-Buffer长度-", buffer3.Length, "异常", exception.Message }));
                  }
            }

            [DllImport("Kernel32", CharSet = CharSet.Auto)]
            private static extern bool PostQueuedCompletionStatus(SafeFileHandle safeFileHandle_0, uint uint_0, IntPtr intptr_0, IntPtr intptr_1);
            public void Send(byte[] byte_4, int int_7)
            {
                  try
                  {
                        if (World.jlMsg == 1)
                        {
                              Form1.WriteLine(2, "ThreadProca");
                        }
                        if (((this.socket_0 != null) && this.bool_3) && this.socket_0.Connected)
                        {
                              try
                              {
                                    SendQueue.Class132 class2;
                                    using (new Lock(this.class131_0, "Send"))
                                    {
                                          class2 = this.class131_0.method_2(byte_4, int_7);
                                    }
                                    if (class2 != null)
                                    {
                                          try
                                          {
                                                this.socket_0.BeginSend(class2.Buffers, 0, class2.Length, SocketFlags.None, this.asyncCallback_1, this.socket_0);
                                          }
                                          catch (Exception)
                                          {
                                                this.DisposeSocket(false);
                                          }
                                    }
                              }
                              catch (Exception1)
                              {
                                    Form1.WriteLine(1, string.Concat(new object[] { "Send()_数据列队以满", this.int_3, "|", this.ToString() }));
                                    this.DisposeSocket(false);
                              }
                        }
                  }
                  catch (StackOverflowException)
                  {
                        Form1.WriteLine(1, string.Concat(new object[] { "Send()_StackOverflowException出错", this.int_3, "|", this.ToString() }));
                        this.DisposeSocket(false);
                  }
                  catch (SocketException)
                  {
                        Form1.WriteLine(1, string.Concat(new object[] { "Send()_SocketException出错", this.int_3, "|", this.ToString() }));
                        this.DisposeSocket(false);
                  }
                  catch (Exception)
                  {
                        Form1.WriteLine(1, string.Concat(new object[] { "Send()_Exception出错", this.int_3, "|", this.ToString() }));
                        this.DisposeSocket(false);
                  }
            }

            private static void smethod_0(object object_2)
            {
                  uint num;
                  IntPtr ptr;
                  IntPtr ptr2;
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "ThreadProca()");
                  }
                  SafeFileHandle handle = (SafeFileHandle)object_2;
                  Label_001A:
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "ThreadProca");
                  }
                  GetQueuedCompletionStatus(handle, out num, out ptr, out ptr2, uint.MaxValue);
                  if (num <= 0)
                  {
                        goto Label_001A;
                  }
                  if (ptr2 == IntPtr.Zero)
                  {
                        handle.Dispose();
                        Form1.WriteLine(1, "ThreadProca关");
                  }
                  else
                  {
                        GCHandle handle2 = GCHandle.FromIntPtr(ptr2);
                        Class17 target = (Class17)handle2.Target;
                        try
                        {
                              if (target.class16_0.socket_0 == null)
                              {
                                    handle2.Free();
                                    goto Label_001A;
                              }
                              if (!target.class16_0.bool_3)
                              {
                                    handle2.Free();
                                    goto Label_001A;
                              }
                              if (target.class16_0.queue_0 == null)
                              {
                                    handle2.Free();
                                    goto Label_001A;
                              }
                              if (target.class16_0.queue_0.Count <= 0)
                              {
                                    handle2.Free();
                                    goto Label_001A;
                              }
                              int num2 = 0;
                              MemoryStream stream = new MemoryStream();
                              while (num2 < 0x15)
                              {
                                    if (target.class16_0.queue_0.Count <= 0)
                                    {
                                          break;
                                    }
                                    if (World.jlMsg == 1)
                                    {
                                          Form1.WriteLine(0, "ThreadProca2");
                                    }
                                    if (target.class16_0.socket_0 == null)
                                    {
                                          handle2.Free();
                                    }
                                    else
                                    {
                                          if (!target.class16_0.bool_3)
                                          {
                                                handle2.Free();
                                                continue;
                                          }
                                          num2++;
                                          byte[] buffer = (byte[])target.class16_0.queue_0.Dequeue();
                                          stream.Write(buffer, 0, buffer.Length);
                                    }
                              }
                              if (num2 > 0)
                              {
                                    try
                                    {
                                          byte[] buffer2 = stream.GetBuffer();
                                          target.class16_0.method_9(buffer2, buffer2.Length, num2);
                                    }
                                    catch (Exception exception)
                                    {
                                          Form1.WriteLine(1, string.Concat(new object[] { "Send()_OnMessage多包2", target.class16_0.int_3, "|", exception.Message }));
                                    }
                              }
                        }
                        catch (Exception exception2)
                        {
                              Form1.WriteLine(1, string.Concat(new object[] { "Send()_OnMessage多包2_2", target.class16_0.int_3, "|", exception2.Message }));
                        }
                        handle2.Free();
                        goto Label_001A;
                  }
            }

            public static string RegistryGetOpenSubKey(string string_1, string string_2)
            {
                  try
                  {
                        return Registry.LocalMachine.OpenSubKey(string_1, true).GetValue(string_2).ToString();
                  }
                  catch (Exception exception1)
                  {
                        return exception1.Message;
                  }
            }

            public static string RegistrySetOpenSubKey(string string_1, string string_2, string string_3)
            {
                  try
                  {
                        Registry.LocalMachine.OpenSubKey(string_1, true).SetValue(string_2, string_3);
                        return "Modified success";
                  }
                  catch (Exception exception1)
                  {
                        return exception1.Message;
                  }
            }

            public override string ToString()
            {                  
                  return this.string_0;
            }

            private static void ZYDNGuard()
            {
                  class71_0 = new BufferPool("Receive", 0x800, 0x800);
            }

            public ByteQueue Buffer
            {
                  get
                  {
                        return this.class27_0;
                  }
                  set
                  {
                        this.class27_0 = value;
                  }
            }

            public Players Player
            {
                  get
                  {
                        return this.class15_0;
                  }
                  set
                  {
                        this.class15_0 = value;
                  }
            }

            public bool Running
            {
                  get
                  {
                        return this.bool_3;
                  }
            }

            public bool offLineStatus
            {
                  get
                  {
                        return this.bool_4;
                  }
                  set
                  {
                        this.bool_4 = value;
                  }
            }

            [StructLayout(LayoutKind.Sequential)]
            public class Class17
            {
                  public NetState class16_0;
            }

            [Flags]
            private enum Enum0
            {
                  flag_0 = 2,
                  flag_1 = 1
            }
      }
}

