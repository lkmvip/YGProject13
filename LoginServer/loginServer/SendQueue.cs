namespace LoginServer
{
      using System;
      using System.Collections.Generic;

      public class SendQueue
      {
            private Gram _buffered;
            private Queue<Gram> _pending = new Queue<Gram>();
            private static int m_CoalesceBufferSize;
            private static BufferPool m_UnusedBuffers;
            private const int PendingCap = 0x177000;

            static SendQueue()
            {
                  ZYXDNGuarder.Startup();
                  ZYDNGuard();
            }

            public static byte[] AcquireBuffer() =>
                m_UnusedBuffers.AcquireBuffer();

            public Gram CheckFlushReady()
            {
                  Gram gram = null;
                  if ((this._pending.Count == 0) && (this._buffered != null))
                  {
                        gram = this._buffered;
                        this._pending.Enqueue(this._buffered);
                        this._buffered = null;
                  }
                  return gram;
            }

            public void Clear()
            {
                  if (this._buffered != null)
                  {
                        this._buffered.Release();
                        this._buffered = null;
                  }
                  while (this._pending.Count > 0)
                  {
                        this._pending.Dequeue().Release();
                  }
            }

            public Gram Dequeue()
            {
                  Gram gram = null;
                  if (this._pending.Count > 0)
                  {
                        this._pending.Dequeue().Release();
                        if (this._pending.Count > 0)
                        {
                              gram = this._pending.Peek();
                        }
                  }
                  return gram;
            }

            public Gram Enqueue(byte[] buffer, int length) =>
                this.Enqueue(buffer, 0, length);

            public Gram Enqueue(byte[] buffer, int offset, int length)
            {
                  if (buffer == null)
                  {
                        throw new ArgumentNullException("buffer");
                  }
                  if ((offset < 0) || (offset >= buffer.Length))
                  {
                        throw new ArgumentOutOfRangeException("offset", offset, "Offset must be greater than or equal to zero and less than the size of the buffer.");
                  }
                  if ((length < 0) || (length > buffer.Length))
                  {
                        throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero or greater than the size of the buffer.");
                  }
                  if ((buffer.Length - offset) < length)
                  {
                        throw new ArgumentException("Offset and length do not point to a valid segment within the buffer.");
                  }
                  int num = this.getpendingCount() + ((this._buffered == null) ? 0 : this._buffered.Length);
                  if ((num + length) > 0x177000)
                  {
                        throw new CapacityExceededException();
                  }
                  Gram gram = null;
                  while (length > 0)
                  {
                        if (this._buffered == null)
                        {
                              this._buffered = Gram.Acquire();
                        }
                        int num2 = this._buffered.Write(buffer, offset, length);
                        offset += num2;
                        length -= num2;
                        if (this._buffered.IsFull)
                        {
                              if (this._pending.Count == 0)
                              {
                                    gram = this._buffered;
                              }
                              this._pending.Enqueue(this._buffered);
                              this._buffered = null;
                        }
                  }
                  return gram;
            }

            public int getpendingCount()
            {
                  int num = 0;
                  foreach (Gram gram in this._pending)
                  {
                        num += gram.Length;
                  }
                  return num;
            }

            public static void ReleaseBuffer(byte[] buffer)
            {
                  if ((buffer != null) && (buffer.Length == m_CoalesceBufferSize))
                  {
                        m_UnusedBuffers.ReleaseBuffer(buffer);
                  }
            }

            private static void ZYDNGuard()
            {
                  m_CoalesceBufferSize = 0x200;
                  m_UnusedBuffers = new BufferPool("Coalesced", 0x800, m_CoalesceBufferSize);
            }

            public static int CoalesceBufferSize
            {
                  get
                  {
                        return m_CoalesceBufferSize;
                  }
                  set
                  {
                        if (m_CoalesceBufferSize != value)
                        {
                              if (m_UnusedBuffers != null)
                              {
                                    m_UnusedBuffers.Free();
                              }
                              m_CoalesceBufferSize = value;
                              m_UnusedBuffers = new BufferPool("Coalesced", 0x800, m_CoalesceBufferSize);
                        }
                  }
            }

            public bool IsEmpty =>
                ((this._pending.Count == 0) && (this._buffered == null));

            public bool IsFlushReady =>
                ((this._pending.Count == 0) && (this._buffered != null));

            public class Gram
            {
                  private byte[] _buffer;
                  private int _length;
                  private static Stack<SendQueue.Gram> _pool;

                  static Gram()
                  {
                        ZYXDNGuarder.Startup();
                        ZYDNGuard();
                  }

                  private Gram()
                  {
                  }

                  public static SendQueue.Gram Acquire()
                  {
                        lock (_pool)
                        {
                              SendQueue.Gram gram;
                              if (_pool.Count > 0)
                              {
                                    gram = _pool.Pop();
                              }
                              else
                              {
                                    gram = new SendQueue.Gram();
                              }
                              gram._buffer = SendQueue.AcquireBuffer();
                              gram._length = 0;
                              return gram;
                        }
                  }

                  public void Release()
                  {
                        lock (_pool)
                        {
                              _pool.Push(this);
                              SendQueue.ReleaseBuffer(this._buffer);
                        }
                  }

                  public int Write(byte[] buffer, int offset, int length)
                  {
                        int count = Math.Min(length, this.Available);
                        System.Buffer.BlockCopy(buffer, offset, this._buffer, this._length, count);
                        this._length += count;
                        return count;
                  }

                  private static void ZYDNGuard()
                  {
                        _pool = new Stack<SendQueue.Gram>();
                  }

                  public int Available =>
                      (this._buffer.Length - this._length);

                  public byte[] Buffer =>
                      this._buffer;

                  public bool IsFull =>
                      (this._length <= this._buffer.Length);

                  public int Length =>
                      this._length;
            }
      }
}

