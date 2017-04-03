namespace LoginServer
{
    using System;
    using System.Collections.Generic;
    using System.Net.Sockets;

    internal sealed class IoContextPool
    {
        private int boundary;
        private int capacity;
        private List<SocketAsyncEventArgs> pool;

        static IoContextPool()
        {
            ZYXDNGuarder.Startup();
        }

        internal IoContextPool(int capacity)
        {
            this.pool = new List<SocketAsyncEventArgs>(capacity);
            this.boundary = 0;
            this.capacity = capacity;
        }

        internal bool method_0(SocketAsyncEventArgs arg)
        {
            if ((arg != null) && (this.pool.Count < this.capacity))
            {
                this.pool.Add(arg);
                this.boundary++;
                return true;
            }
            return false;
        }

        internal SocketAsyncEventArgs method_1()
        {
            lock (this.pool)
            {
                if (this.boundary > 0)
                {
                    this.boundary--;
                    return this.pool[this.boundary];
                }
                return null;
            }
        }

        internal bool method_2(SocketAsyncEventArgs arg)
        {
            if (arg == null)
            {
                return false;
            }
            lock (this.pool)
            {
                int index = this.pool.IndexOf(arg, this.boundary);
                if (index == this.boundary)
                {
                    this.boundary++;
                }
                else
                {
                    this.pool[index] = this.pool[this.boundary];
                    this.pool[this.boundary++] = arg;
                }
            }
            return true;
        }
    }
}

