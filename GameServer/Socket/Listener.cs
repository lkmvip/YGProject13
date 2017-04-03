using ns10;
using ns13;
using ns3;
using ns6;
using RxjhServer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

namespace ns2
{
	internal class Listener
	{
		private bool bool_0;

		private object object_0;

		private Queue<Socket> queue_0 = new Queue<Socket>();

		private Socket socket_0;

		public Listener(int port)
		{
			this.object_0 = ((ICollection)this.queue_0).SyncRoot;
			this.method_0(IPAddress.Any, port);
		}

		private void method_0(IPAddress ipaddress_0, int int_0)
		{
			IPAddress[] addressList = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
			IPEndPoint pEndPoint = new IPEndPoint(ipaddress_0, int_0);
			this.socket_0 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			try
			{
				this.socket_0.UseOnlyOverlappedIO = true;
				this.socket_0.LingerState.Enabled = false;
				this.socket_0.ExclusiveAddressUse = false;
				this.socket_0.Bind(pEndPoint);
				this.socket_0.Listen(10);
				World.bool_5 = true;
				using (SocketAsyncEventArgs socketAsyncEventArg = new SocketAsyncEventArgs())
				{
					socketAsyncEventArg.UserToken = this;
					socketAsyncEventArg.Completed += new EventHandler<SocketAsyncEventArgs>(Listener.smethod_0);
					this.socket_0.AcceptAsync(socketAsyncEventArg);
				}
				World.int_105 = int_0;
				Form1.WriteLine(3, string.Concat(new object[] { "Start listening port ", int_0, " IP ", addressList[0].ToString() }));
				if (World.class20_0 != null)
				{
					World.class20_0.method_4(string.Concat(new object[] { "更新服务器端口|", World.Server_ID, "|", int_0 }));
				}
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				Form1.WriteLine(1, string.Concat(new object[] { "开始监听端口 出错 ", int_0, " IP ", addressList[0].ToString(), " ", exception.Message }));
				Console.WriteLine("Listener bind exception:");
				Console.WriteLine(exception);
				try
				{
					this.socket_0.Shutdown(SocketShutdown.Both);
				}
				catch
				{
				}
				try
				{
					this.socket_0.Close();
				}
				catch
				{
				}
				DateTime now = DateTime.Now;
				int num = (new Random(now.Millisecond)).Next(10, 100);
				this.method_0(IPAddress.Any, int_0 + num);
			}
		}

		public void method_1()
		{
			try
			{
				World.bool_5 = false;
				Form1.WriteLine(1, "关闭监听端口");
				if (!this.bool_0)
				{
					this.bool_0 = true;
					if (this.socket_0 != null)
					{
						try
						{
							this.socket_0.Shutdown(SocketShutdown.Both);
						}
						catch
						{
						}
						try
						{
							this.socket_0.Close();
						}
						catch
						{
						}
						this.socket_0 = null;
					}
				}
			}
			catch
			{
			}
		}

		private static void smethod_0(object sender, SocketAsyncEventArgs e)
		{
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "AcceptAsyncComplete()");
			}
			Listener userToken = e.UserToken as Listener;
			try
			{
				try
				{
					if (World.IP_closure)
					{
						IPAddress address = ((IPEndPoint)e.AcceptSocket.RemoteEndPoint).Address;
						if (!World.list_17.Contains(address))
						{
							DateTime now = DateTime.Now;
							int num = 0;
							foreach (NetState value in World.threadSafeDictionary_0.Values)
							{
								if (value.ToString() != address.ToString())
								{
									continue;
								}
								now = value.dateTime_3;
								num++;
							}
							if (num > World.Game_landing_port_maximum_number_of_connections)
							{
								if ((int)DateTime.Now.Subtract(now).TotalMilliseconds < World.Tro_choi_do_bo_cang_lon_nhat_lien_tiep_Thoi_gian_so)
								{
									Form1.WriteLine(1, string.Concat("到达IP最大连接数", address.ToString()));
									if (World.Join_filter_list && !World.list_17.Contains(address))
									{
										World.list_17.Add(address);
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
										Queue queues = Queue.Synchronized(new Queue());
										foreach (NetState netState in World.threadSafeDictionary_0.Values)
										{
											if (netState.ToString() != address.ToString())
											{
												continue;
											}
											queues.Enqueue(netState);
										}
										while (queues.Count > 0)
										{
											if (World.jlMsg == 1)
											{
												Form1.WriteLine(0, "AcceptAsyncComplete");
											}
											((NetState)queues.Dequeue()).Dispose();
										}
										return;
									}
									catch
									{
										return;
									}
								}
								else
								{
									return;
								}
							}
							else if (e.AcceptSocket != null)
							{
								(new NetState(e.AcceptSocket)).method_2();
							}
						}
						else
						{
							if (World.Disconnect)
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
							if (!World.Close_connection)
							{
								using (SocketAsyncEventArgs socketAsyncEventArg = new SocketAsyncEventArgs())
								{
									socketAsyncEventArg.UserToken = userToken;
									socketAsyncEventArg.Completed += new EventHandler<SocketAsyncEventArgs>(Listener.smethod_0);
									userToken.socket_0.AcceptAsync(socketAsyncEventArg);
								}
							}
							else
							{
								try
								{
									userToken.method_1();
									return;
								}
								catch
								{
									return;
								}
							}
						}
					}
					else if (e.AcceptSocket != null)
					{
						(new NetState(e.AcceptSocket)).method_2();
					}
				}
				catch (Exception exception)
				{
				}
			}
			finally
			{
				try
				{
					using (SocketAsyncEventArgs socketAsyncEventArg1 = new SocketAsyncEventArgs())
					{
						socketAsyncEventArg1.UserToken = userToken;
						socketAsyncEventArg1.Completed += new EventHandler<SocketAsyncEventArgs>(Listener.smethod_0);
						userToken.socket_0.AcceptAsync(socketAsyncEventArg1);
					}
				}
				catch (Exception exception1)
				{
				}
			}
		}
	}
}