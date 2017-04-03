namespace LoginServer
{
    using System;
    using System.Net;
    using System.Net.Sockets;
    using System.Runtime.InteropServices;
    using System.Text;

    public class NetState
    {
        public int int_0;
        public DateTime Ljtime = DateTime.Now;
        private IPAddress m_Address;
        private object m_AsyncLock = new object();
        private AsyncCallback m_OnReceive;
        private AsyncCallback m_OnSend;
        private byte[] m_RecvBuffer;
        private bool m_Running;
        private SendQueue m_SendQueue;
        public Socket m_Socket;
        private string m_ToString;
        public int packconn;
        public LoginServer.Player Player;
        public int WorldId;

        static NetState()
        {
            ZYXDNGuarder.Startup();
        }

        public NetState(Socket socket)
        {
            this.Ljtime = DateTime.Now;
            this.m_OnReceive = new AsyncCallback(this.c);
            this.m_OnSend = new AsyncCallback(this.b);
            this.m_Socket = socket;
            this.m_Running = false;
            this.m_SendQueue = new SendQueue();
            this.m_RecvBuffer = new byte[0x418];
            try
            {
                this.m_Address = ((IPEndPoint) this.m_Socket.RemoteEndPoint).Address;
                this.m_ToString = this.m_Address.ToString();
            }
            catch
            {
                this.m_Address = IPAddress.None;
                this.m_ToString = "(error)";
            }
            this.addWorldIdd();
            this.Player = new LoginServer.Player(this);
        }

        public void addWorldIdd()
        {
            try
            {
                lock (World.list)
                {
                    int key = 300;
                    while (key < 0x2710)
                    {
                        if (!World.list.ContainsKey(key))
                        {
                            goto Label_003E;
                        }
                        key++;
                    }
                    return;
                Label_003E:
                    this.WorldId = key;
                    World.list.Add(key, this);
                }
            }
            catch
            {
            }
        }

        private void b(IAsyncResult asyncResult)
        {
            Socket asyncState = (Socket) asyncResult.AsyncState;
            if (this.m_Socket == null)
            {
                this.Dispose();
            }
            else
            {
                try
                {
                    if (this.m_Running)
                    {
                        if (asyncState.EndSend(asyncResult) <= 0)
                        {
                            this.Dispose();
                        }
                        else
                        {
                            SendQueue.Gram gram;
                            lock (this.m_SendQueue)
                            {
                                gram = this.m_SendQueue.Dequeue();
                            }
                            if (gram != null)
                            {
                                try
                                {
                                    asyncState.BeginSend(gram.Buffer, 0, gram.Length, SocketFlags.None, this.m_OnSend, asyncState);
                                }
                                catch (Exception)
                                {
                                    this.Dispose();
                                }
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    this.Dispose();
                }
            }
        }

        private void c(IAsyncResult asyncResult)
        {
            if (this.m_Socket == null)
            {
                this.Dispose();
            }
            else
            {
                Socket asyncState = (Socket) asyncResult.AsyncState;
                try
                {
                    int length = 0;
                    try
                    {
                        length = asyncState.EndReceive(asyncResult);
                    }
                    catch (ArgumentNullException exception)
                    {
                        Form1.WriteLine(1, string.Concat(new object[] { "OnReceive()1出错", this.WorldId, "|", this.ToString(), " ", exception.Message }));
                        this.Dispose();
                    }
                    catch (ArgumentException exception2)
                    {
                        Form1.WriteLine(1, string.Concat(new object[] { "OnReceive()2出错", this.WorldId, "|", this.ToString(), " ", exception2.Message }));
                        this.Dispose();
                    }
                    catch (InvalidOperationException exception3)
                    {
                        Form1.WriteLine(1, string.Concat(new object[] { "OnReceive()3出错", this.WorldId, "|", this.ToString(), " ", exception3.Message }));
                        this.Dispose();
                    }
                    catch (SocketException)
                    {
                        this.Dispose();
                    }
                    catch (Exception exception4)
                    {
                        Form1.WriteLine(1, string.Concat(new object[] { "OnReceive()5出错", this.WorldId, "|", this.ToString(), " ", exception4.Message }));
                        this.Dispose();
                    }
                    if (length > 0)
                    {
                        byte[] recvBuffer = this.m_RecvBuffer;
                        this.ProcessDataReceived(recvBuffer, length);
                        byte[] array = new byte[Marshal.SizeOf(0) * 3];
                        BitConverter.GetBytes((uint) 1).CopyTo(array, 0);
                        BitConverter.GetBytes((uint) 0x4e20).CopyTo(array, Marshal.SizeOf(0));
                        BitConverter.GetBytes((uint) 0x4e20).CopyTo(array, (int) (Marshal.SizeOf(0) * 2));
                        this.method_0(array);
                    }
                    else
                    {
                        this.Dispose();
                    }
                }
                catch (Exception exception5)
                {
                    Form1.WriteLine(1, string.Concat(new object[] { "OnReceive()6出错", this.WorldId, "|", this.ToString(), " ", exception5.Message }));
                    this.Dispose();
                }
            }
        }

        public void delWorldIdd()
        {
            try
            {
                lock (World.list)
                {
                    World.list.Remove(this.WorldId);
                }
            }
            catch
            {
            }
        }

        public void Dispose()
        {
            try
            {
                if (!World.m_Disposed.Contains(this))
                {
                    if (this.m_Socket != null)
                    {
                        try
                        {
                            this.m_Socket.Shutdown(SocketShutdown.Both);
                        }
                        catch
                        {
                        }
                        try
                        {
                            this.m_Socket.Close();
                        }
                        catch
                        {
                        }
                    }
                    World.m_Disposed.Enqueue(this);
                    if (!this.m_SendQueue.IsEmpty)
                    {
                        lock (this.m_SendQueue)
                        {
                            this.m_SendQueue.Clear();
                        }
                    }
                    this.m_Socket = null;
                    this.m_RecvBuffer = null;
                    this.m_Running = false;
                    this.m_AsyncLock = null;
                }
            }
            catch (Exception exception)
            {
                Form1.WriteLine(1, string.Concat(new object[] { " Dispose(bool flush)出错", this.WorldId, "|", this.ToString(), " ", exception.Message }));
            }
        }

        private void method_0(byte[] inOptionValues)
        {
            try
            {
                this.m_Socket.IOControl(IOControlCode.KeepAliveValues, inOptionValues, null);
                this.m_Socket.BeginReceive(this.m_RecvBuffer, 0, this.m_RecvBuffer.Length, SocketFlags.None, this.m_OnReceive, this.m_Socket);
            }
            catch (Exception)
            {
                this.Dispose();
            }
        }

        public void method_1(string msg)
        {
            try
            {
                byte[] bytes = Encoding.Default.GetBytes(msg);
                this.Send(bytes, bytes.Length);
            }
            catch (Exception)
            {
            }
        }

        public void ProcessDataReceived(byte[] data, int length)
        {
            try
            {
                this.packconn++;
                if (this.packconn > 0xf4240)
                {
                    this.packconn = 0;
                }
                this.Player.ManagePacket(data, length);
            }
            catch (Exception exception)
            {
                Form1.WriteLine(1, string.Concat(new object[] { "ProcessDataReceived()出错", this.WorldId, "|", this.ToString(), " ", exception.Message }));
                this.Dispose();
            }
        }

        public void Send(byte[] toSendBuff, int len)
        {
            try
            {
                if (this.m_Socket != null)
                {
                    SendQueue.Gram gram;
                    lock (this.m_SendQueue)
                    {
                        gram = this.m_SendQueue.Enqueue(toSendBuff, len);
                    }
                    if (gram != null)
                    {
                        try
                        {
                            this.m_Socket.BeginSend(gram.Buffer, 0, gram.Length, SocketFlags.None, this.m_OnSend, this.m_Socket);
                        }
                        catch (Exception)
                        {
                            this.Dispose();
                        }
                    }
                }
            }
            catch (StackOverflowException exception)
            {
                Form1.WriteLine(1, string.Concat(new object[] { "Send()_StackOverflowException出错", this.WorldId, "|", this.ToString(), " ", exception.Message }));
                this.Dispose();
            }
            catch (SocketException exception2)
            {
                Form1.WriteLine(1, string.Concat(new object[] { "Send()_SocketException出错", this.WorldId, "|", this.ToString(), " ", exception2.Message }));
                this.Dispose();
            }
            catch (Exception exception3)
            {
                Form1.WriteLine(1, string.Concat(new object[] { "Send()_Exception出错", this.WorldId, "|", this.ToString(), " ", exception3.Message }));
                this.Dispose();
            }
        }

        public void Send2(byte[] packet, int length)
        {
            try
            {
                if (((this.m_Socket != null) && this.m_Running) && this.m_Socket.Connected)
                {
                    using (SocketAsyncEventArgs args = new SocketAsyncEventArgs())
                    {
                        args.Completed += new EventHandler<SocketAsyncEventArgs>(NetState.smethod_0);
                        args.SetBuffer(packet, 0, length);
                        args.UserToken = this;
                        this.m_Socket.SendAsync(args);
                    }
                }
            }
            catch (StackOverflowException)
            {
                this.Dispose();
            }
            catch (SocketException)
            {
                this.Dispose();
            }
            catch (Exception)
            {
                this.Dispose();
            }
        }

        private static void smethod_0(object sender, SocketAsyncEventArgs e)
        {
            object userToken = e.UserToken;
        }

        public void Start()
        {
            this.m_Running = true;
            if (this.m_Socket == null)
            {
                this.Dispose();
            }
            else
            {
                try
                {
                    byte[] array = new byte[Marshal.SizeOf(0) * 3];
                    BitConverter.GetBytes((uint) 1).CopyTo(array, 0);
                    BitConverter.GetBytes((uint) 0x4e20).CopyTo(array, Marshal.SizeOf(0));
                    BitConverter.GetBytes((uint) 0x4e20).CopyTo(array, (int) (Marshal.SizeOf(0) * 2));
                    this.method_0(array);
                }
                catch (Exception exception)
                {
                    Form1.WriteLine(1, string.Concat(new object[] { "Start()出错", this.WorldId, "|", this.ToString(), " ", exception.Message }));
                    this.Dispose();
                }
            }
        }

        public override string ToString() => 
            this.m_ToString;

        public bool Running =>
            this.m_Running;
    }
}

