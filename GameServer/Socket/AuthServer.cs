using ns1;
using ns10;
using ns12;
using ns13;
using ns4;
using ns9;
using System;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ns6
{
	internal class AuthServer
	{
		public static ArrayList arrayList_0;

		private int int_0;

		public int int_1;

		public int int_2;

		private Socket socket_0;

		private string string_0;

		private Delegate6 delegate6_0;

		static AuthServer()
		{
			AuthServer.ZYDNGuard();
		}

		public AuthServer(string i, int pt)
		{
			this.string_0 = i;
			this.int_0 = pt;
			this.method_3();
		}

		private void a(object object_0, SockClienT class57_0)
		{
			if (this.delegate6_0 != null)
			{
				this.delegate6_0(object_0, class57_0);
			}
		}

		public void method_0()
		{
			this.socket_0.Close();
		}

		public void method_1()
		{
			while (AuthServer.arrayList_0.Count > 0)
			{
				((SockClienT)AuthServer.arrayList_0[0]).method_0();
			}
			try
			{
				this.socket_0.Shutdown(SocketShutdown.Both);
                        Form1.WriteLine(3, "Web Client Close");
                  }
			catch
			{
			}
			if (this.socket_0 != null)
			{
				this.socket_0.Close();
			}
		}

		public void method_2(SockClienT class57_0)
		{
			using (Lock @lock = new Lock(AuthServer.arrayList_0, "RemoveClient"))
			{
				AuthServer.arrayList_0.Remove(class57_0);
			}
		}

		public bool method_3()
		{
			bool flag;
			try
			{
				this.socket_0 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				this.socket_0.Bind(new IPEndPoint(IPAddress.Any, this.int_0));
				Form1.WriteLine(3, string.Concat(new object[] { "Began to monitor the treasure port ", this.int_0, " IP ", this.string_0.ToString() }));
				this.socket_0.Listen(10);
				AuthServer authServer = this;
				this.socket_0.BeginAccept(new AsyncCallback(authServer.vmethod_0), this.socket_0);
				flag = true;
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				Console.WriteLine("Failled to list on port {0}\n{1}", this.int_0, exception.Message);
				Form1.WriteLine(1, string.Concat(new object[] { "监听百宝端口出错 ", this.int_0, "   ", exception.Message }));
				this.socket_0 = null;
				return false;
			}
			return flag;
		}

		private void method_4(object object_0, SockClienT class57_0)
		{
			this.a(object_0, class57_0);
		}

		public virtual void vmethod_0(IAsyncResult iasyncResult_0)
		{
			try
			{
				Socket socket = this.socket_0.EndAccept(iasyncResult_0);
				if (socket != null)
				{
                              Form1.WriteLine(3, "Web Client Packet");
                              ClientConnection clientConnection = new ClientConnection(socket, new Delegate7(this.method_2));
					AuthServer.arrayList_0.Add(clientConnection);
					clientConnection.OnSockMessage += new Delegate6(this.method_4);
					clientConnection.method_3();
				}
			}
			catch (Exception exception)
			{
				Console.WriteLine("{0}", exception);
			}
			try
			{
				AuthServer authServer = this;
				this.socket_0.BeginAccept(new AsyncCallback(authServer.vmethod_0), this.socket_0);
			}
			catch
			{
				this.method_1();
			}
		}

		private static void ZYDNGuard()
		{
			AuthServer.arrayList_0 = new ArrayList();
		}

		public event Delegate6 OnSockMessage
		{
			add
			{
				Delegate6 delegate6;
				Delegate6 delegate60 = this.delegate6_0;
				do
				{
					delegate6 = delegate60;
					Delegate6 delegate61 = (Delegate6)Delegate.Combine(delegate6, value);
					delegate60 = Interlocked.CompareExchange<Delegate6>(ref this.delegate6_0, delegate61, delegate6);
				}
				while (delegate60 != delegate6);
			}
			remove
			{
				Delegate6 delegate6;
				Delegate6 delegate60 = this.delegate6_0;
				do
				{
					delegate6 = delegate60;
					Delegate6 delegate61 = (Delegate6)Delegate.Remove(delegate6, value);
					delegate60 = Interlocked.CompareExchange<Delegate6>(ref this.delegate6_0, delegate61, delegate6);
				}
				while (delegate60 != delegate6);
			}
		}
	}
}