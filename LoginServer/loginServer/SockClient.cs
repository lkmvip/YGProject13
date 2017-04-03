namespace LoginServer
{
    using System;
    using System.Net;
    using System.Net.Sockets;
    using System.Runtime.InteropServices;
    using System.Text;

    public class SockClient : IDisposable
    {
        public Socket clientSocket;
        private byte[] dataReceive = new byte[0x19000];
        private bool disposed = false;
        private RemoveClientDelegate removeFromTheServerList;

        static SockClient()
        {
            ZYXDNGuarder.Startup();
        }

        public SockClient(Socket from, RemoveClientDelegate rftsl)
        {
            this.removeFromTheServerList = rftsl;
            this.clientSocket = from;
        }

        public virtual byte[] DataReceived2(byte[] data, int length) => 
            null;

        public void Dispose()
        {
            if (!this.disposed)
            {
                this.disposed = true;
                try
                {
                    this.clientSocket.Shutdown(SocketShutdown.Both);
                }
                catch
                {
                }
                if (this.clientSocket != null)
                {
                    this.clientSocket.Close();
                }
                this.clientSocket = null;
                if (this.removeFromTheServerList != null)
                {
                    this.removeFromTheServerList(this);
                }
            }
        }

        public virtual void OnReceiveData(IAsyncResult ar)
        {
            try
            {
                if (!this.disposed)
                {
                    int length = this.clientSocket.EndReceive(ar);
                    if (length <= 0)
                    {
                        this.Dispose();
                    }
                    else
                    {
                        byte[] buffer;
                        if (World.aaaaaa == 1)
                        {
                            buffer = this.ProcessDataReceived(this.dataReceive, length);
                        }
                        else
                        {
                            buffer = this.DataReceived2(this.dataReceive, length);
                        }
                        if (buffer != null)
                        {
                            this.clientSocket.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(this.OnSended), this);
                        }
                        else
                        {
                            this.clientSocket.BeginReceive(this.dataReceive, 0, this.dataReceive.Length, SocketFlags.None, new AsyncCallback(this.OnReceiveData), this);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("{0}", exception.Message);
                this.Dispose();
            }
        }

        public void OnSended(IAsyncResult ar)
        {
            try
            {
                if (!this.disposed)
                {
                    this.clientSocket.EndSend(ar);
                    this.clientSocket.BeginReceive((ar.AsyncState as SockClient).dataReceive, 0, (ar.AsyncState as SockClient).dataReceive.Length, SocketFlags.None, new AsyncCallback(this.OnReceiveData), ar.AsyncState);
                }
            }
            catch
            {
            }
        }

        public void OnSended2(IAsyncResult ar)
        {
            try
            {
                if (!this.disposed)
                {
                    this.clientSocket.EndSend(ar);
                }
            }
            catch (Exception)
            {
            }
        }

        public virtual byte[] ProcessDataReceived(byte[] data, int length) => 
            null;

        public virtual void Send(byte[] toSendBuff, int len)
        {
            try
            {
                if (!this.disposed)
                {
                    byte[] dst = new byte[len];
                    Buffer.BlockCopy(toSendBuff, 0, dst, 0, len);
                    this.clientSocket.BeginSend(dst, 0, len, SocketFlags.None, new AsyncCallback(this.OnSended2), this);
                }
            }
            catch (Exception)
            {
            }
        }

        public virtual void Send(char[] toSendBuff, int len)
        {
            try
            {
                if (!this.disposed)
                {
                    byte[] dst = new byte[len];
                    Buffer.BlockCopy(toSendBuff, 0, dst, 0, len);
                    this.clientSocket.BeginSend(dst, 0, len, SocketFlags.None, new AsyncCallback(this.OnSended2), this);
                }
            }
            catch (Exception)
            {
            }
        }

        public virtual void Send(byte[] toSendBuff, int offset, int len)
        {
            try
            {
                if (!this.disposed)
                {
                    byte[] dst = new byte[len];
                    Buffer.BlockCopy(toSendBuff, offset, dst, 0, len);
                    if (!this.disposed)
                    {
                        this.clientSocket.BeginSend(dst, 0, len, SocketFlags.None, new AsyncCallback(this.OnSended2), this);
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        [DllImport("PkEnBk.dll", CharSet=CharSet.Ansi)]
        public static extern uint send_en(Socket s, string astr1, int len, int flags);
        public virtual void Sendbyte(byte[] toSendBuff, int len)
        {
            try
            {
                byte[] dst = new byte[len + 6];
                dst[0] = 170;
                dst[1] = 0x66;
                Buffer.BlockCopy(BitConverter.GetBytes(len), 0, dst, 2, 4);
                Buffer.BlockCopy(toSendBuff, 0, dst, 6, len);
                if (this.clientSocket != null)
                {
                    this.clientSocket.BeginSend(dst, 0, len + 6, SocketFlags.None, new AsyncCallback(this.OnSended2), this);
                }
            }
            catch (SocketException exception)
            {
                Form1.WriteLine(1, "帐号服务器 发送攻击确认包出错：" + exception.Message);
            }
        }

        public virtual void Sendd(string str)
        {
            byte[] bytes = Encoding.Default.GetBytes(str);
            this.vmethod_0(bytes, bytes.Length);
        }

        public void Start()
        {
            this.clientSocket.BeginReceive(this.dataReceive, 0, this.dataReceive.Length, SocketFlags.None, new AsyncCallback(this.OnReceiveData), this);
        }

        public virtual void vmethod_0(byte[] toSendBuff, int len)
        {
            try
            {
                if (World.aaaaaa == 1)
                {
                    byte[] dst = new byte[len + 6];
                    dst[0] = 170;
                    dst[1] = 0x66;
                    Buffer.BlockCopy(BitConverter.GetBytes(len), 0, dst, 2, 4);
                    Buffer.BlockCopy(toSendBuff, 0, dst, 6, len);
                    this.clientSocket.BeginSend(dst, 0, len + 6, SocketFlags.None, new AsyncCallback(this.OnSended2), this);
                }
                else
                {
                    byte[] buffer2 = new byte[len];
                    Buffer.BlockCopy(toSendBuff, 0, buffer2, 0, len);
                    this.clientSocket.BeginSend(buffer2, 0, len, SocketFlags.None, new AsyncCallback(this.OnSended2), this);
                }
            }
            catch (SocketException exception)
            {
                Form1.WriteLine(1, "帐号服务器 发送出错：" + exception.Message);
            }
            catch (Exception exception2)
            {
                Form1.WriteLine(1, "帐号服务器 发送出错：" + exception2.Message);
            }
        }

        public IPAddress IP
        {
            get
            {
                try
                {
                    if (this.disposed)
                    {
                        return null;
                    }
                    return ((IPEndPoint) this.clientSocket.RemoteEndPoint).Address;
                }
                catch
                {
                    this.Dispose();
                }
                return null;
            }
        }
    }
}

