namespace ns6
{
      using System;
      using System.Collections.Generic;
      using System.Runtime.InteropServices;

      internal class BufferPool
      {
            private int int_0;
            private int int_1;
            private int int_2;
            private static List<BufferPool> list_0;
            private Queue<byte[]> queue_0;
            private string string_0;

            static BufferPool()
            {
                  ZYDNGuard();
            }

            public BufferPool(string name, int initialCapacity, int bufferSize)
            {
                  this.string_0 = name;
                  this.int_0 = initialCapacity;
                  this.int_1 = bufferSize;
                  this.queue_0 = new Queue<byte[]>(initialCapacity);
                  for (int i = 0; i < initialCapacity; i++)
                  {
                        this.queue_0.Enqueue(new byte[bufferSize]);
                  }
                  List<BufferPool> list = list_0;
                  lock (list)
                  {
                        list_0.Add(this);
                  }
            }

            public void method_0(out string string_1, out int int_3, out int int_4, out int int_5, out int int_6, out int int_7)
            {
                  BufferPool pool = this;
                  lock (pool)
                  {
                        string_1 = this.string_0;
                        int_3 = this.queue_0.Count;
                        int_4 = this.int_0;
                        int_5 = this.int_0 * (1 + this.int_2);
                        int_6 = this.int_1;
                        int_7 = this.int_2;
                  }
            }

            public byte[] method_1()
            {
                  BufferPool pool = this;
                  lock (pool)
                  {
                        if (this.queue_0.Count <= 0)
                        {
                              this.int_2++;
                              for (int i = 0; i < this.int_0; i++)
                              {
                                    this.queue_0.Enqueue(new byte[this.int_1]);
                              }
                        }
                        return this.queue_0.Dequeue();
                  }
            }

            public void method_2(byte[] byte_0)
            {
                  if (byte_0 != null)
                  {
                        BufferPool pool = this;
                        lock (pool)
                        {
                              this.queue_0.Enqueue(byte_0);
                        }
                  }
            }

            public void method_3()
            {
                  List<BufferPool> list = list_0;
                  lock (list)
                  {
                        list_0.Remove(this);
                  }
            }

            private static void ZYDNGuard()
            {
                  list_0 = new List<BufferPool>();
            }

            public static List<BufferPool> Pools
            {
                  get
                  {
                        return list_0;
                  }
                  set
                  {
                        list_0 = value;
                  }
            }
      }
}

