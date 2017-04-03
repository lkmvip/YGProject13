using ns10;
using ns13;
using ns3;
using ns5;
using ns8;
using ns9;
using RxjhServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Timers;

namespace ns6
{
	internal class Connect
	{
		private byte[] byte_0 = new byte[102400];

		private Socket socket_0;

		private System.Timers.Timer timer_0 = new System.Timers.Timer(5000);

		public Connect()
		{
			this.timer_0.Elapsed += new ElapsedEventHandler(this.timer_0_Elapsed);
			this.timer_0.AutoReset = true;
			this.timer_0.Enabled = true;
		}

		public void method_0()
		{
			try
			{
				IPEndPoint pEndPoint = new IPEndPoint(IPAddress.Parse(World.Account_authentication_server_IP), World.Account_authentication_server_port);
				this.socket_0 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
				{
					UseOnlyOverlappedIO = true
				};
				this.socket_0.LingerState.Enabled = false;
				this.socket_0.ExclusiveAddressUse = false;
				this.socket_0.BeginConnect(pEndPoint, new AsyncCallback(this.method_3), this.socket_0);
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				Form1.WriteLine(2, string.Concat(new object[] { "连接帐号验证服务器出错 ", World.Account_authentication_server_port, " IP ", World.Account_authentication_server_IP.ToString(), " ", exception.Message }));
			}
		}

		public void method_1()
		{
			if (this.timer_0 != null)
			{
				this.timer_0.Enabled = false;
				this.timer_0.Close();
				this.timer_0.Dispose();
			}
			try
			{
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

		public void method_10(int int_0)
		{
			NetState netState;
			try
			{
				if (World.threadSafeDictionary_0.TryGetValue(int_0, out netState))
				{
					Form1.WriteLine(3, string.Concat(new string[] { "用户踢出 [", netState.Player.Userid, "]-[", netState.Player.UserName, "]", netState.ToString() }));
					netState.Dispose();
				}
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				Form1.WriteLine(1, string.Concat(new object[] { "验证服务器用户踢出出错：", int_0, " ", exception.Message }));
			}
		}

		public void method_2()
		{
			try
			{
				StringBuilder stringBuilder = new StringBuilder();
				foreach (NetState value in World.threadSafeDictionary_0.Values)
				{
					stringBuilder.Append(value.Player.Userid);
					stringBuilder.Append("-");
					stringBuilder.Append(value.ToString());
					stringBuilder.Append(",");
				}
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Remove(stringBuilder.Length - 1, 1);
				}
				World.class20_0.method_4(string.Concat("复查用户登陆|", stringBuilder));
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				Form1.WriteLine(1, string.Concat("复查用户登陆 错误", exception.Message));
			}
		}

		private void method_3(IAsyncResult iasyncResult_0)
		{
			try
			{
				((Socket)iasyncResult_0.AsyncState).EndConnect(iasyncResult_0);
				try
				{
					this.method_4(string.Concat(new object[] { "服务器连接登陆|", World.Server_ID, "|", World.Maximum_Online, "|", CRC32.smethod_1() }));
					Form1.WriteLine(2, string.Concat(new object[] { "The account server is connected successfully  [Port] ", World.Account_authentication_server_port, " IP ", World.Account_authentication_server_IP }));
					Connect connect = this;
					this.socket_0.BeginReceive(this.byte_0, 0, (int)this.byte_0.Length, SocketFlags.None, new AsyncCallback(connect.vmethod_0), this);
					Thread.Sleep(500);
					this.method_4(string.Concat(new object[] { "更新服务器端口|", World.Server_ID, "|", World.int_105 }));
					this.method_2();
				}
				catch (Exception exception1)
				{
					Exception exception = exception1;
					Form1.WriteLine(1, string.Concat("验证服务器ConnectCallback出错：", exception.Message));
				}
			}
			catch (Exception exception3)
			{
				Exception exception2 = exception3;
				Form1.WriteLine(1, string.Concat("帐号服务器连接出错：", exception2.Message));
			}
		}

		public void method_4(string string_0)
		{
			try
			{
				if (this.socket_0 != null && this.socket_0.Connected)
				{
					byte[] bytes = Encoding.Default.GetBytes(string_0);
					this.vmethod_1(bytes, (int)bytes.Length);
				}
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				Form1.WriteLine(1, string.Concat("验证服务器发送出错：", string_0, exception.Message));
			}
		}

		public void method_5(IAsyncResult iasyncResult_0)
		{
			try
			{
				this.socket_0.EndSend(iasyncResult_0);
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				Form1.WriteLine(1, string.Concat("帐号服务器 发送出错：", exception.Message));
			}
		}

		public void method_6(byte[] byte_1, int int_0)
		{
			try
			{
				int num = 0;
				if (170 != byte_1[0] || 102 != byte_1[1])
				{
					Form1.WriteLine(1, string.Concat(new object[] { "错包：", byte_1[0], " ", byte_1[1] }));
				}
				else
				{
					byte[] numArray = new byte[4];
					Buffer.BlockCopy(byte_1, 2, numArray, 0, 4);
					int num1 = BitConverter.ToInt32(numArray, 0);
					if (int_0 >= num1 + 6)
					{
						while (true)
						{
							if (World.jlMsg == 1)
							{
								Form1.WriteLine(0, "ProcessDataReceived");
							}
							byte[] numArray1 = new byte[num1];
							Buffer.BlockCopy(byte_1, num + 6, numArray1, 0, num1);
							num = num + num1 + 6;
							this.method_7(numArray1, num1);
							if (num >= int_0 || byte_1[num] != 170 || byte_1[num + 1] != 102)
							{
								break;
							}
							Buffer.BlockCopy(byte_1, num + 2, numArray, 0, 4);
							num1 = BitConverter.ToInt16(numArray, 0);
						}
					}
				}
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				Form1.WriteLine(1, string.Concat("出错：", exception.Message));
				Console.WriteLine(exception.Message);
				Console.WriteLine(exception.Source);
				Console.WriteLine(exception.StackTrace);
			}
		}

		public void method_7(byte[] byte_1, int int_0)
		{
			NetState netState;
			string str = Encoding.Default.GetString(byte_1);
                  Form1.WriteLine(1, string.Concat("Connect method_7： ", BitConverter.ToString(byte_1).Replace("-","")));
                  Form1.WriteLine(1, string.Concat("Connect method_7： ", str ));
                  try
			{
				string[] strArrays = str.Split(new char[] { '|' });
				string str1 = strArrays[0];
				if (str1 != null)
				{
					if (str1 == "用户登陆")
					{
						this.method_8(int.Parse(strArrays[2]), strArrays[1], strArrays[3], int.Parse(strArrays[4]));
					}
					else if (str1 == "用户踢出")
					{
						if (strArrays[1] != "")
						{
							this.method_10(int.Parse(strArrays[1]));
						}
					}
					else if (str1 == "发送公告")
					{
						this.method_9(int.Parse(strArrays[1]), strArrays[2]);
					}
					else if (str1 == "狮子吼")
					{
						if (strArrays[1] == "OK")
						{
							World.smethod_8(int.Parse(strArrays[2]), strArrays[3], int.Parse(strArrays[4]), strArrays[5], int.Parse(strArrays[6]), int.Parse(strArrays[7]));
						}
						else if (World.threadSafeDictionary_0.TryGetValue(int.Parse(strArrays[2]), out netState))
						{
							netState.Player.GameMessage("狮子吼列队以满请等待.....", 9, "System");
						}
					}
				}
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				Form1.WriteLine(1, string.Concat("验证服务器接收出错：", str, exception.Message));
			}
		}

		public void method_8(int int_0, string string_0, string string_1, int int_1)
		{
			NetState netState;
			try
			{
				if (World.threadSafeDictionary_0.TryGetValue(int_0, out netState))
				{
					netState.Player.LIEN_TIEP_DO_BO_2(string_0, string_1, int_1);
				}
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				Form1.WriteLine(1, string.Concat("验证服务器用户登陆出错：", exception.Message));
			}
		}

		public void method_9(int int_0, string string_0)
		{
			try
			{
				foreach (Players value in World.allConnectedChars.Values)
				{
					if (value == null)
					{
						continue;
					}
					if (int_0 != 0)
					{
						if (int_0 == 1 || int_0 != 2)
						{
							continue;
						}
						value.GameMessage(string_0, 10, "system message");
					}
					else
					{
						value.System_Announcement(string_0);
					}
				}
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				Form1.WriteLine(1, string.Concat("发送公告出错：", exception.Message));
			}
		}

		private void timer_0_Elapsed(object sender, ElapsedEventArgs e)
		{
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "自动连接事件");
			}
			if (!this.socket_0.Connected)
			{
				this.method_0();
			}
		}

		public virtual void vmethod_0(IAsyncResult iasyncResult_0)
		{
			try
			{
				int num = this.socket_0.EndReceive(iasyncResult_0);
				if (num > 0)
				{
					this.method_6(this.byte_0, num);
					Connect connect = this;
					this.socket_0.BeginReceive(this.byte_0, 0, (int)this.byte_0.Length, SocketFlags.None, new AsyncCallback(connect.vmethod_0), this);
				}
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				Form1.WriteLine(1, string.Concat("帐号服务器 接收出错：", exception.Message));
			}
		}

		public virtual void vmethod_1(byte[] byte_1, int int_0)
		{
			try
			{
				byte[] numArray = new byte[int_0 + 6];
				numArray[0] = 170;
				numArray[1] = 102;
				Buffer.BlockCopy(BitConverter.GetBytes(int_0), 0, numArray, 2, 4);
				Buffer.BlockCopy(byte_1, 0, numArray, 6, int_0);
				this.socket_0.BeginSend(numArray, 0, int_0 + 6, SocketFlags.None, new AsyncCallback(this.method_5), this);
			}
			catch (SocketException socketException1)
			{
				SocketException socketException = socketException1;
				Form1.WriteLine(1, string.Concat("帐号服务器 发送出错：", socketException.Message));
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				Form1.WriteLine(1, string.Concat("帐号服务器 发送出错：", exception.Message));
			}
		}
	}
}