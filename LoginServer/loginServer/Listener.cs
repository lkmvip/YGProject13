namespace LoginServer
{
    using LoginServer.DbClss;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Sockets;

    internal class Listener
    {
        private Queue<Socket> m_Accepted = new Queue<Socket>();
        private object m_AcceptedSyncRoot;
        private bool m_Disposed = false;
        private static Socket[] m_EmptySockets;
        private Socket m_Listener;

        static Listener()
        {
            ZYXDNGuarder.Startup();
            ZYDNGuard();
        }

        public Listener(int port)
        {
            this.m_AcceptedSyncRoot = ((ICollection) this.m_Accepted).SyncRoot;
            this.method_0(IPAddress.Any, port);
        }

        public void Dispose()
        {
            if (!this.m_Disposed)
            {
                World.bool_0 = false;
                Form1.WriteLine(1, "关闭监听端口");
                this.m_Disposed = true;
                if (this.m_Listener != null)
                {
                    try
                    {
                        this.m_Listener.Shutdown(SocketShutdown.Both);
                    }
                    catch
                    {
                    }
                    try
                    {
                        this.m_Listener.Close();
                    }
                    catch
                    {
                    }
                    this.m_Listener = null;
                }
            }
        }

        private void method_0(IPAddress ip, int port)
        {
            IPEndPoint localEP = new IPEndPoint(ip, port);
            this.m_Listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                this.m_Listener.Bind(localEP);
                this.m_Listener.Listen(0x2710);
                World.bool_0 = true;
                using (SocketAsyncEventArgs args = new SocketAsyncEventArgs())
                {
                    args.UserToken = this;
                    args.Completed += new EventHandler<SocketAsyncEventArgs>(Listener.smethod_0);
                    this.m_Listener.AcceptAsync(args);
                }
                Form1.WriteLine(3, string.Concat(new object[] { "开始监听端口:", port, " 地址:", ip.ToString() }));
            }
            catch (Exception exception)
            {
                Console.WriteLine("Listener bind exception:");
                Console.WriteLine(exception);
                try
                {
                    this.m_Listener.Shutdown(SocketShutdown.Both);
                }
                catch
                {
                }
                try
                {
                    this.m_Listener.Close();
                }
                catch
                {
                }
            }
        }

        private static void smethod_0(object sender, SocketAsyncEventArgs e)
        {
            Listener userToken = e.UserToken as Listener;
            try
            {
                string str;
                DateTime ljtime;
                if (World.int_6 != 1)
                {
                    goto Label_047A;
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
                            userToken.Dispose();
                            return;
                        }
                        catch
                        {
                            return;
                        }
                    }
                    using (SocketAsyncEventArgs args = new SocketAsyncEventArgs())
                    {
                        args.UserToken = userToken;
                        args.Completed += new EventHandler<SocketAsyncEventArgs>(Listener.smethod_0);
                        userToken.m_Listener.AcceptAsync(args);
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
                                goto Label_01F0;
                            }
                        }
                    }
                }
                goto Label_028A;
            Label_01F0:
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
                    args2.UserToken = userToken;
                    args2.Completed += new EventHandler<SocketAsyncEventArgs>(Listener.smethod_0);
                    userToken.m_Listener.AcceptAsync(args2);
                }
                return;
            Label_028A:
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
            Label_047A:
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
                        args3.UserToken = userToken;
                        args3.Completed += new EventHandler<SocketAsyncEventArgs>(Listener.smethod_0);
                        userToken.m_Listener.AcceptAsync(args3);
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private static void ZYDNGuard()
        {
            m_EmptySockets = new Socket[0];
        }
    }
}

