namespace LoginServer
{
    using System;
    using System.Collections;
    using System.Net;
    using System.Net.Sockets;

    public class BbcServer
    {
        private IPAddress address;
        private AddressFamily addressFamily;
        public static ArrayList clients;
        private string ip;
        private Socket listenSocket;
        private int port;
        public int totalReceive = 0;
        public int totalSend = 0;

        static BbcServer()
        {
            ZYXDNGuarder.Startup();
            ZYDNGuard();
        }

        public BbcServer(string i, int pt)
        {
            this.ip = i;
            this.port = pt;
            IPEndPoint point = new IPEndPoint(IPAddress.Any, this.port);
            this.addressFamily = point.Address.AddressFamily;
            this.address = point.Address;
        }

        public void Dispose()
        {
            while (clients.Count > 0)
            {
                ((SockClient) clients[0]).Dispose();
            }
            try
            {
                this.listenSocket.Shutdown(SocketShutdown.Both);
            }
            catch
            {
            }
            if (this.listenSocket != null)
            {
                this.listenSocket.Close();
            }
        }

        public virtual void OnAccept(IAsyncResult ar)
        {
            try
            {
                Socket from = this.listenSocket.EndAccept(ar);
                if (from != null)
                {
                    PlayerHandler handler = new PlayerHandler(from, new RemoveClientDelegate(this.RemoveClient));
                    lock (clients.SyncRoot)
                    {
                        clients.Add(handler);
                    }
                    handler.Start();
                }
            }
            catch
            {
            }
            try
            {
                this.listenSocket.BeginAccept(new AsyncCallback(this.OnAccept), this.listenSocket);
            }
            catch
            {
                this.Dispose();
            }
        }

        public void RemoveClient(SockClient client)
        {
            (client as PlayerHandler).Logout();
            lock (clients.SyncRoot)
            {
                clients.Remove(client);
            }
        }

        public bool Start()
        {
            bool flag;
            try
            {
                this.listenSocket = new Socket(this.addressFamily, SocketType.Stream, ProtocolType.Tcp);
                this.listenSocket.UseOnlyOverlappedIO = true;
                this.listenSocket.LingerState.Enabled = false;
                this.listenSocket.ExclusiveAddressUse = false;
                this.listenSocket.Bind(new IPEndPoint(IPAddress.Any, this.port));
                Form1.WriteLine(3, string.Concat(new object[] { "开始监听端口:", this.port, " 地址:", this.address.ToString() }));
                this.listenSocket.Listen(100);
                this.listenSocket.BeginAccept(new AsyncCallback(this.OnAccept), this.listenSocket);
                return true;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Failled to list on port {0}\n{1}", this.port, exception.Message);
                this.listenSocket = null;
                flag = false;
            }
            return flag;
        }

        private static void ZYDNGuard()
        {
            clients = new ArrayList();
        }
    }
}

