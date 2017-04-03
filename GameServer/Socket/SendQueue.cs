using ns3;
using ns5;
using ns6;
using System;
using System.Collections.Generic;
using System.Threading;

namespace ns13
{
      internal class SendQueue: IDisposable
      {
            private SendQueue.Class132 class132_0;

            private static BufferPool class71_0;

            private const int int_0 = 3072000;

            private static int int_1;

            private Queue<SendQueue.Class132> queue_0 = new Queue<SendQueue.Class132>();

            public static int CoalesceBufferSize
            {
                  get
                  {
                        return SendQueue.int_1;
                  }
                  set
                  {
                        if (SendQueue.int_1 != value)
                        {
                              if (SendQueue.class71_0 != null)
                              {
                                    SendQueue.class71_0.method_3();
                              }
                              SendQueue.int_1 = value;
                              SendQueue.class71_0 = new BufferPool("Coalesced", 2048, SendQueue.int_1);
                        }
                  }
            }

            public int GetpendingConn
            {
                  get
                  {
                        return this.queue_0.Count;
                  }
            }

            public bool IsEmpty
            {
                  get
                  {
                        if (this.queue_0.Count != 0)
                        {
                              return false;
                        }
                        return this.class132_0 == null;
                  }
            }

            public bool IsFlushReady
            {
                  get
                  {
                        if (this.queue_0.Count != 0)
                        {
                              return false;
                        }
                        return this.class132_0 != null;
                  }
            }

            static SendQueue()
            {
                  SendQueue.ZYDNGuard();
            }

            public SendQueue()
            {
            }

            public void Dispose()
            {
                  this.queue_0.Clear();
                  this.queue_0 = null;
                  this.class132_0 = null;
            }

            public SendQueue.Class132 method_0()
            {
                  SendQueue.Class132 class1320 = null;
                  if (this.queue_0.Count == 0 && this.class132_0 != null)
                  {
                        class1320 = this.class132_0;
                        this.queue_0.Enqueue(this.class132_0);
                        this.class132_0 = null;
                  }
                  return class1320;
            }

            public SendQueue.Class132 method_1()
            {
                  SendQueue.Class132 class132 = null;
                  if (this.queue_0.Count > 0)
                  {
                        this.queue_0.Dequeue().method_1();
                        if (this.queue_0.Count > 0)
                        {
                              class132 = this.queue_0.Peek();
                        }
                  }
                  return class132;
            }

            public SendQueue.Class132 method_2(byte[] byte_0, int int_2)
            {
                  return this.method_4(byte_0, 0, int_2);
            }

            public int method_3()
            {
                  int length = 0;
                  foreach (SendQueue.Class132 queue0 in this.queue_0)
                  {
                        length = length + queue0.Length;
                  }
                  return length;
            }

            public SendQueue.Class132 method_4(byte[] byte_0, int int_2, int int_3)
            {
                  if (byte_0 == null)
                  {
                        throw new ArgumentNullException("buffer");
                  }
                  if (int_2 < 0 || int_2 >= (int)byte_0.Length)
                  {
                        throw new ArgumentOutOfRangeException("offset", (object)int_2, "Offset must be greater than or equal to zero and less than the size of the buffer.");
                  }
                  if (int_3 < 0 || int_3 > (int)byte_0.Length)
                  {
                        throw new ArgumentOutOfRangeException("length", (object)int_3, "Length cannot be less than zero or greater than the size of the buffer.");
                  }
                  if ((int)byte_0.Length - int_2 < int_3)
                  {
                        throw new ArgumentException("Offset and length do not point to a valid segment within the buffer.");
                  }
                  if (this.queue_0.Count * SendQueue.int_1 + (this.class132_0 == null ? 0 : this.class132_0.Length) + int_3 > 3072000)
                  {
                        throw new Exception1();
                  }
                  SendQueue.Class132 class1320 = null;
                  while (int_3 > 0)
                  {
                        if (World.jlMsg == 1)
                        {
                              Form1.WriteLine(0, "Enqueue");
                        }
                        if (this.class132_0 == null)
                        {
                              this.class132_0 = SendQueue.Class132.smethod_0();
                        }
                        int num = this.class132_0.method_0(byte_0, int_2, int_3);
                        int_2 = int_2 + num;
                        int_3 = int_3 - num;
                        if (!this.class132_0.IsFull)
                        {
                              continue;
                        }
                        if (this.queue_0.Count == 0)
                        {
                              class1320 = this.class132_0;
                        }
                        this.queue_0.Enqueue(this.class132_0);
                        this.class132_0 = null;
                  }
                  return class1320;
            }

            public void method_5()
            {
                  if (this.class132_0 != null)
                  {
                        this.class132_0.method_1();
                        this.class132_0 = null;
                  }
                  while (this.queue_0.Count > 0)
                  {
                        if (World.jlMsg == 1)
                        {
                              Form1.WriteLine(0, "Clear");
                        }
                        this.queue_0.Dequeue().method_1();
                  }
            }

            public static byte[] smethod_0()
            {
                  return SendQueue.class71_0.method_1();
            }

            public static void smethod_1(byte[] byte_0)
            {
                  if (byte_0 != null && (int)byte_0.Length == SendQueue.int_1)
                  {
                        SendQueue.class71_0.method_2(byte_0);
                  }
            }

            private static void ZYDNGuard()
            {
                  SendQueue.int_1 = 1024;
                  SendQueue.class71_0 = new BufferPool("Coalesced", 2048, SendQueue.int_1);
            }

            public class Class132
            {
                  private byte[] byte_0;

                  private int int_0;

                  private static Stack<SendQueue.Class132> stack_0;

                  public int Available
                  {
                        get
                        {
                              return (int)this.byte_0.Length - this.int_0;
                        }
                  }

                  public byte[] Buffers
                  {
                        get
                        {
                              return this.byte_0;
                        }
                  }

                  public bool IsFull
                  {
                        get
                        {
                              return this.int_0 <= (int)this.byte_0.Length;
                        }
                  }

                  public int Length
                  {
                        get
                        {
                              return this.int_0;
                        }
                  }

                  static Class132()
                  {
                        SendQueue.Class132.ZYDNGuard();
                  }

                  private Class132()
                  {
                  }

                  public int method_0(byte[] byte_1, int int_1, int int_2)
                  {
                        int num = Math.Min(int_2, this.Available);
                        Buffer.BlockCopy(byte_1, int_1, this.byte_0, this.int_0, num);
                        this.int_0 = this.int_0 + num;
                        return num;
                  }

                  public void method_1()
                  {
                        Stack<SendQueue.Class132> stack0 = SendQueue.Class132.stack_0;
                        Monitor.Enter(stack0);
                        try
                        {
                              SendQueue.Class132.stack_0.Push(this);
                              SendQueue.smethod_1(this.byte_0);

                        }
                        finally
                        {
                              Monitor.Exit(stack0);
                        }
                  }

                  public static SendQueue.Class132 smethod_0()
                  {
                        SendQueue.Class132 class132;
                        SendQueue.Class132 class1321;
                        Stack<SendQueue.Class132> stack0 = SendQueue.Class132.stack_0;
                        Monitor.Enter(stack0);
                        try
                        {
                              class132 = (SendQueue.Class132.stack_0.Count <= 0 ? new SendQueue.Class132() : SendQueue.Class132.stack_0.Pop());
                              class132.byte_0 = SendQueue.smethod_0();
                              class132.int_0 = 0;
                              class1321 = class132;
                        }
                        finally
                        {
                              Monitor.Exit(stack0);
                        }
                        return class1321;
                  }

                  private static void ZYDNGuard()
                  {
                        SendQueue.Class132.stack_0 = new Stack<SendQueue.Class132>();
                  }
            }
      }
}