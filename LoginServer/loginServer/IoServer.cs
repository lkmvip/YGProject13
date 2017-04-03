namespace LoginServer
{
    using LoginServer.DbClss;
    using System;
    using System.Collections;
    using System.Net;
    using System.Net.Sockets;
    using System.Threading;

    internal sealed class IoServer
    {
        private int bufferSize;
        private IoContextPool ioContextPool;
        private Socket listenSocket;
        private static Mutex mutex;
        private int numConnectedSockets = 0;
        private int numConnections;

        static IoServer()
        {
            ZYXDNGuarder.Startup();
            ZYDNGuard();
        }

        internal IoServer(int numConnections, int bufferSize)
        {
            this.numConnections = numConnections;
            this.bufferSize = bufferSize;
            this.ioContextPool = new IoContextPool(numConnections);
            for (int i = 0; i < this.numConnections; i++)
            {
                SocketAsyncEventArgs arg = new SocketAsyncEventArgs();
                arg.Completed += new EventHandler<SocketAsyncEventArgs>(this.method_0);
                arg.SetBuffer(new byte[this.bufferSize], 0, this.bufferSize);
                this.ioContextPool.method_0(arg);
            }
        }

        internal void a(int port)
        {
            IPAddress[] addressList = Dns.GetHostEntry(Environment.MachineName).AddressList;
            IPEndPoint localEP = new IPEndPoint(IPAddress.Any, port);
            this.listenSocket = new Socket(localEP.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            this.listenSocket.ReceiveBufferSize = this.bufferSize;
            this.listenSocket.SendBufferSize = this.bufferSize;
            if (localEP.AddressFamily == AddressFamily.InterNetworkV6)
            {
                this.listenSocket.SetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.PacketInformation | SocketOptionName.KeepAlive, false);
                this.listenSocket.Bind(new IPEndPoint(IPAddress.IPv6Any, localEP.Port));
            }
            else
            {
                this.listenSocket.Bind(localEP);
            }
            this.listenSocket.Listen(this.numConnections);
            using (SocketAsyncEventArgs args = new SocketAsyncEventArgs())
            {
                args.UserToken = this;
                args.Completed += new EventHandler<SocketAsyncEventArgs>(this.method_6);
                this.listenSocket.AcceptAsync(args);
            }
            mutex.WaitOne();
            Form1.WriteLine(3, "开始监听端口:" + port);
            World.bool_0 = true;
        }

        internal void b()
        {
            this.listenSocket.Close();
            mutex.ReleaseMutex();
            World.bool_0 = false;
            Form1.WriteLine(1, "关闭监听端口");
        }

        private void method_0(object sender, SocketAsyncEventArgs e)
        {
            SocketAsyncOperation lastOperation = e.LastOperation;
            if (lastOperation != SocketAsyncOperation.Receive)
            {
                if (lastOperation != SocketAsyncOperation.Send)
                {
                    Form1.WriteLine(1, "The last operation completed on the socket was not a receive or send");
                }
                else
                {
                    this.method_2(e);
                }
            }
            else
            {
                this.method_1(e);
            }
        }

        private void method_1(SocketAsyncEventArgs e)
        {
            if (e.BytesTransferred > 0)
            {
                if (e.SocketError != SocketError.Success)
                {
                    this.method_3(e);
                }
                else
                {
                    Socket userToken = (Socket) e.UserToken;
                    if (userToken.Available != 0)
                    {
                        if (!userToken.ReceiveAsync(e))
                        {
                            this.method_1(e);
                        }
                    }
                    else
                    {
                        Array.Copy(e.Buffer, 0, e.Buffer, e.BytesTransferred, e.BytesTransferred);
                        e.SetBuffer(e.Offset, e.BytesTransferred * 2);
                        if (!userToken.SendAsync(e))
                        {
                            this.method_2(e);
                        }
                    }
                }
            }
            else
            {
                this.method_4(e);
            }
        }

        private void method_2(SocketAsyncEventArgs e)
        {
            if (e.SocketError == SocketError.Success)
            {
                Socket userToken = (Socket) e.UserToken;
                e.SetBuffer(0, this.bufferSize);
                if (!userToken.ReceiveAsync(e))
                {
                    this.method_1(e);
                }
            }
            else
            {
                this.method_3(e);
            }
        }

        private void method_3(SocketAsyncEventArgs e)
        {
            Socket userToken = e.UserToken as Socket;
            EndPoint localEndPoint = userToken.LocalEndPoint;
            this.method_5(userToken, e);
        }

        private void method_4(SocketAsyncEventArgs e)
        {
            Socket userToken = e.UserToken as Socket;
            this.method_5(userToken, e);
        }

        private void method_5(Socket s, SocketAsyncEventArgs e)
        {
            Interlocked.Decrement(ref this.numConnectedSockets);
            this.ioContextPool.method_2(e);
            try
            {
                s.Shutdown(SocketShutdown.Send);
            }
            catch (Exception)
            {
            }
            finally
            {
                s.Close();
            }
        }

        private void method_6(object sender, SocketAsyncEventArgs e)
        {
            Socket acceptSocket = e.AcceptSocket;
            Form1.WriteLine(3, "LS当前状态" + this.numConnectedSockets);
            try
            {
                if (this.ioContextPool.method_1() == null)
                {
                    acceptSocket.Close();
                }
                this.method_7(e);
            }
            catch
            {
                acceptSocket.Close();
            }
        }

        private void method_7(SocketAsyncEventArgs e)
        {
            Form1.WriteLine(3, "LS客户正常进入");
            IoServer userToken = e.UserToken as IoServer;
            try
            {
                string str;
                DateTime ljtime;
                if (World.int_6 != 1)
                {
                    goto Label_0486;
                }
                IPAddress item = ((IPEndPoint) e.AcceptSocket.RemoteEndPoint).Address;
                if (World.BipList.Contains(item))
                {
                    if (World.bool_1)
                    {
                        try
                        {
                            e.AcceptSocket.Shutdown(SocketShutdown.Both);
                        }
                        catch
                        {
                        }
                        try
                        {
                            e.AcceptSocket.Close();
                        }
                        catch
                        {
                        }
                    }
                    if (World.bool_3)
                    {
                        try
                        {
                            userToken.b();
                            return;
                        }
                        catch
                        {
                            return;
                        }
                    }
                    using (SocketAsyncEventArgs args = new SocketAsyncEventArgs())
                    {
                        args.UserToken = this;
                        args.Completed += new EventHandler<SocketAsyncEventArgs>(this.method_6);
                        this.listenSocket.AcceptAsync(args);
                    }
                    return;
                }
                if (World.string_3 != "")
                {
                    str = RxjhClass.GetUserIpadds(item.ToString()).Replace(" ", "").Trim();
                    bool flag = false;
                    string[] strArray = World.string_3.Split(new char[] { ',' });
                    for (int i = 0; i < strArray.Length; i++)
                    {
                        if (str.IndexOf(strArray[i]) != -1)
                        {
                            string[] strArray2 = World.string_7.Split(new char[] { ',' });
                            for (int j = 0; j < strArray2.Length; j++)
                            {
                                if (str.IndexOf(strArray2[j]) != -1)
                                {
                                    flag = true;
                                }
                            }
                            if (!flag)
                            {
                                goto Label_01FC;
                            }
                        }
                    }
                }
                goto Label_0296;
            Label_01FC:
                try
                {
                    e.AcceptSocket.Shutdown(SocketShutdown.Both);
                }
                catch
                {
                }
                try
                {
                    e.AcceptSocket.Close();
                }
                catch
                {
                }
                Form1.WriteLine(1, "用户登陆[" + item.ToString() + "]被封 " + str);
                using (SocketAsyncEventArgs args2 = new SocketAsyncEventArgs())
                {
                    args2.UserToken = this;
                    args2.Completed += new EventHandler<SocketAsyncEventArgs>(this.method_6);
                    this.listenSocket.AcceptAsync(args2);
                }
                return;
            Label_0296:
                ljtime = DateTime.Now;
                int num3 = 0;
                foreach (NetState state in World.list.Values)
                {
                    if (state.ToString() == item.ToString())
                    {
                        ljtime = state.Ljtime;
                        num3++;
                    }
                }
                if (num3 > World.int_4)
                {
                    int totalMilliseconds = (int) DateTime.Now.Subtract(ljtime).TotalMilliseconds;
                    if (totalMilliseconds >= World.int_5)
                    {
                        return;
                    }
                    Form1.WriteLine(1, "到达IP最大连接数" + item.ToString());
                    if (!(!World.bool_2 || World.BipList.Contains(item)))
                    {
                        World.BipList.Add(item);
                    }
                    try
                    {
                        e.AcceptSocket.Shutdown(SocketShutdown.Both);
                    }
                    catch
                    {
                    }
                    try
                    {
                        e.AcceptSocket.Close();
                    }
                    catch
                    {
                    }
                    try
                    {
                        System.Collections.Queue queue = System.Collections.Queue.Synchronized(new System.Collections.Queue());
                        foreach (NetState state2 in World.list.Values)
                        {
                            if (state2.ToString() == item.ToString())
                            {
                                queue.Enqueue(state2);
                            }
                        }
                        while (queue.Count > 0)
                        {
                            ((NetState) queue.Dequeue()).Dispose();
                        }
                        return;
                    }
                    catch
                    {
                        return;
                    }
                }
                if (e.AcceptSocket != null)
                {
                    new NetState(e.AcceptSocket).Start();
                }
                return;
            Label_0486:
                if (e.AcceptSocket != null)
                {
                    new NetState(e.AcceptSocket).Start();
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                try
                {
                    using (SocketAsyncEventArgs args3 = new SocketAsyncEventArgs())
                    {
                        args3.UserToken = this;
                        args3.Completed += new EventHandler<SocketAsyncEventArgs>(this.method_6);
                        this.listenSocket.AcceptAsync(args3);
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private void method_8(SocketAsyncEventArgs acceptEventArg)
        {
            acceptEventArg = new SocketAsyncEventArgs();
            acceptEventArg.UserToken = this;
            acceptEventArg.Completed += new EventHandler<SocketAsyncEventArgs>(this.method_6);
            if (!this.listenSocket.AcceptAsync(acceptEventArg))
            {
                this.method_7(acceptEventArg);
            }
        }

        private static void ZYDNGuard()
        {
            mutex = new Mutex();
        }
    }
}

