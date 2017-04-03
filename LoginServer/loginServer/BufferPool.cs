namespace LoginServer
{
      using System;
      using System.Collections.Generic;
      using System.Runtime.InteropServices;

      internal class BufferPool
      {
            private int m_BufferSize;
            private Queue<byte[]> m_FreeBuffers;
            private int m_InitialCapacity;
            private int m_Misses;
            private string m_Name;
            private static List<BufferPool> m_Pools;

            static BufferPool()
            {
                  ZYXDNGuarder.Startup();
                  ZYDNGuard();
            }

            public BufferPool(string name, int initialCapacity, int bufferSize)
            {
                  this.m_Name = name;
                  this.m_InitialCapacity = initialCapacity;
                  this.m_BufferSize = bufferSize;
                  this.m_FreeBuffers = new Queue<byte[]>(initialCapacity);
                  for (int i = 0; i < initialCapacity; i++)
                  {
                        this.m_FreeBuffers.Enqueue(new byte[bufferSize]);
                  }
                  lock (m_Pools)
                  {
                        m_Pools.Add(this);
                  }
            }

            public byte[] AcquireBuffer()
            {
                  lock (this)
                  {
                        if (this.m_FreeBuffers.Count <= 0)
                        {
                              this.m_Misses++;
                              for (int i = 0; i < this.m_InitialCapacity; i++)
                              {
                                    this.m_FreeBuffers.Enqueue(new byte[this.m_BufferSize]);
                              }
                        }
                        return this.m_FreeBuffers.Dequeue();
                  }
            }

            public void Free()
            {
                  lock (m_Pools)
                  {
                        m_Pools.Remove(this);
                  }
            }

            public void GetInfo(out string name, out int freeCount, out int initialCapacity, out int currentCapacity, out int bufferSize, out int misses)
            {
                  lock (this)
                  {
                        name = this.m_Name;
                        freeCount = this.m_FreeBuffers.Count;
                        initialCapacity = this.m_InitialCapacity;
                        currentCapacity = this.m_InitialCapacity * (1 + this.m_Misses);
                        bufferSize = this.m_BufferSize;
                        misses = this.m_Misses;
                  }
            }

            public void ReleaseBuffer(byte[] buffer)
            {
                  if (buffer != null)
                  {
                        lock (this)
                        {
                              this.m_FreeBuffers.Enqueue(buffer);
                        }
                  }
            }

            private static void ZYDNGuard()
            {
                  m_Pools = new List<BufferPool>();
            }

            public static List<BufferPool> Pools
            {
                  get
                  {
                        return m_Pools;
                  }
                  set
                  {
                        m_Pools = value;
                  }
            }
      }
}

