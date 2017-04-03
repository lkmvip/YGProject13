using ns1;
using ns12;
using ns9;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ns4
{
	internal class SockClienT
	{
		private bool bool_0;

		private byte[] byte_0 = new byte[1500];

		private Delegate7 delegate7_0;

		private Delegate6 delegate6_0;

		private MemoryStream memoryStream_0 = new MemoryStream();

		public Socket socket_0;

		public bool Disposed
		{
			get
			{
				return this.bool_0;
			}
		}

		public IPAddress IP
		{
			get
			{
				IPAddress address;
				try
				{
					if (!this.bool_0)
					{
						address = ((IPEndPoint)this.socket_0.RemoteEndPoint).Address;
					}
					else
					{
						address = null;
					}
				}
				catch
				{
					this.method_0();
					return null;
				}
				return address;
			}
		}

		public SockClienT(Socket from, Delegate7 rftsl)
		{
			this.delegate7_0 = rftsl;
			this.socket_0 = from;
		}

		public void method_0()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				try
				{
					if (this.delegate7_0 != null)
					{
						this.delegate7_0(this);
					}
					this.socket_0.Shutdown(SocketShutdown.Both);
				}
				catch
				{
				}
				if (this.socket_0 != null)
				{
					this.socket_0.Close();
				}
				this.socket_0 = null;
			}
		}

		public void method_1(IAsyncResult iasyncResult_0)
		{
			try
			{
				if (!this.bool_0)
				{
					this.socket_0.EndSend(iasyncResult_0);
					SockClienT sockClienT = this;
					this.socket_0.BeginReceive((iasyncResult_0.AsyncState as SockClienT).byte_0, 0, (int)(iasyncResult_0.AsyncState as SockClienT).byte_0.Length, SocketFlags.None, new AsyncCallback(sockClienT.vmethod_0), iasyncResult_0.AsyncState);
				}
			}
			catch
			{
				this.method_0();
			}
		}

		public void method_2(IAsyncResult iasyncResult_0)
		{
			try
			{
				if (!this.bool_0)
				{
					this.socket_0.EndSend(iasyncResult_0);
				}
			}
			catch (Exception exception)
			{
				this.method_0();
			}
		}

		public void method_3()
		{
			SockClienT sockClienT = this;
			this.socket_0.BeginReceive(this.byte_0, 0, (int)this.byte_0.Length, SocketFlags.None, new AsyncCallback(sockClienT.vmethod_0), this);
		}

		public void method_4(string string_0)
		{
			if (this.delegate6_0 != null)
			{
				this.delegate6_0(string_0, this);
			}
		}

		public virtual void vmethod_0(IAsyncResult iasyncResult_0)
		{
			try
			{
				if (!this.bool_0)
				{
					int num = this.socket_0.EndReceive(iasyncResult_0);
					if (num > 0)
					{
						this.vmethod_1(this.byte_0, num);
						this.method_0();
					}
					else
					{
						this.method_0();
					}
				}
			}
			catch (Exception exception)
			{
				this.method_0();
			}
		}

		public virtual void vmethod_1(byte[] byte_1, int int_0)
		{
		}

		public virtual void vmethod_2(string string_0)
		{
			byte[] bytes = Encoding.Default.GetBytes(string_0);
			this.vmethod_4(bytes, (int)bytes.Length);
		}

		public virtual void vmethod_3(string string_0)
		{
			try
			{
				int num = 0;
				if (!this.bool_0)
				{
					byte[] numArray = new byte[string_0.Length];
					Converter.smethod_9(string_0, numArray, ref num);
					this.socket_0.BeginSend(numArray, 0, num, SocketFlags.None, new AsyncCallback(this.method_2), this);
				}
			}
			catch (Exception exception)
			{
				this.method_0();
			}
		}

		public virtual void vmethod_4(byte[] byte_1, int int_0)
		{
			try
			{
				if (!this.bool_0)
				{
					byte[] numArray = new byte[int_0 + 6];
					numArray[0] = 170;
					numArray[1] = 102;
					Buffer.BlockCopy(BitConverter.GetBytes(int_0), 0, numArray, 2, 4);
					Buffer.BlockCopy(byte_1, 0, numArray, 6, int_0);
					this.socket_0.BeginSend(numArray, 0, (int)numArray.Length, SocketFlags.None, new AsyncCallback(this.method_2), this);
				}
			}
			catch (Exception exception)
			{
				this.method_0();
			}
		}

		public virtual void vmethod_5(char[] char_0, int int_0)
		{
			try
			{
				if (!this.bool_0)
				{
					byte[] numArray = new byte[int_0];
					Buffer.BlockCopy(char_0, 0, numArray, 0, int_0);
					this.socket_0.BeginSend(numArray, 0, int_0, SocketFlags.None, new AsyncCallback(this.method_2), this);
				}
			}
			catch (Exception exception)
			{
				this.method_0();
			}
		}

		public virtual void vmethod_6(byte[] byte_1, int int_0, int int_1)
		{
			try
			{
				if (!this.bool_0)
				{
					byte[] numArray = new byte[int_1];
					Buffer.BlockCopy(byte_1, int_0, numArray, 0, int_1);
					if (!this.bool_0)
					{
						this.socket_0.BeginSend(numArray, 0, int_1, SocketFlags.None, new AsyncCallback(this.method_2), this);
					}
				}
			}
			catch (Exception exception)
			{
				this.method_0();
			}
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