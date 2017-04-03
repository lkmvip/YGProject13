using ns10;
using ns12;
using ns13;
using ns2;
using ns3;
using ns9;
using RxjhServer;
using System;
using System.Collections.Generic;

namespace ns6
{
	internal class ItmesIDClass
	{
		private long long_0;

		private long long_1;

		private object object_0 = new object();

		public ItmesIDClass()
		{
			try
			{
				this.long_0 = (long)0;
				this.long_1 = (long)0;
				this.long_0 = long.Parse(DBA.GetDBValue_3("EXEC XWWL_GetItemSerial2 1000").ToString());
				this.long_1 = this.long_0 + (long)1000;
			}
			catch (Exception exception3)
			{
				Exception exception = exception3;
				Form1.WriteLine(100, string.Concat("全局ID出错", exception.Message));
				World.class20_0.method_1();
				List<Players> players = new List<Players>();
				foreach (Players value in World.allConnectedChars.Values)
				{
					players.Add(value);
				}
				foreach (Players player in players)
				{
					try
					{
						if (player.Client != null)
						{
							player.Client.Dispose();
						}
					}
					catch (Exception exception2)
					{
						Exception exception1 = exception2;
						Form1.WriteLine(1, string.Concat("CAP_NHAT_NHAN_VAT_SO_LIEU 错误", exception1.Message));
					}
				}
				players.Clear();
			}
		}

		public long AcquireBuffer()
		{
			long num;
			using (Lock @lock = new Lock(this.object_0, "AcquireBuffer"))
			{
				if (this.long_0 >= this.long_1)
				{
					this.long_0 = long.Parse(DBA.GetDBValue_3("EXEC XWWL_GetItemSerial2 1000").ToString());
					this.long_1 = this.long_0 + (long)1000;
					long long0 = this.long_0;
					long num1 = long0;
					this.long_0 = long0 + (long)1;
					num = num1;
				}
				else
				{
					long long01 = this.long_0;
					long num2 = long01;
					this.long_0 = long01 + (long)1;
					num = num2;
				}
			}
			return num;
		}
	}
}