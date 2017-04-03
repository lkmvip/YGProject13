using ns1;
using ns13;
using ns3;
using ns6;
using ns8;
using RxjhServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Timers;

namespace ns9
{
	internal class THIET_LAP_BOSS_CLASS2 : IDisposable
	{
		private DateTime dateTime_0;

		private static List<int> list_0;

		private string[] string_0 = World.BOSS_hoang_da_thiet_lap2.Split(new char[] { ';' });

		private Timer timer_0;

		private Timer timer_1;

		private Timer timer_2;

		static THIET_LAP_BOSS_CLASS2()
		{
			THIET_LAP_BOSS_CLASS2.ZYDNGuard();
		}

		public THIET_LAP_BOSS_CLASS2()
		{
			THIET_LAP_BOSS_CLASS2.list_0.Clear();
			this.dateTime_0 = DateTime.Now.AddMinutes(5);
			this.timer_0 = new Timer(60000);
			this.timer_0.Elapsed += new ElapsedEventHandler(this.timer_0_Elapsed);
			this.timer_0.Enabled = true;
			this.timer_0.AutoReset = true;
			this.timer_0_Elapsed(null, null);
			this.timer_1 = new Timer(300000);
			this.timer_1.Elapsed += new ElapsedEventHandler(this.timer_1_Elapsed);
			this.timer_1.Enabled = true;
		}

		public void Dispose()
		{
			THIET_LAP_BOSS_CLASS2.list_0.Clear();
			if (this.timer_0 != null)
			{
				this.timer_0.Enabled = false;
				this.timer_0.Close();
				this.timer_0.Dispose();
			}
			if (this.timer_1 != null)
			{
				this.timer_1.Enabled = false;
				this.timer_1.Close();
				this.timer_1.Dispose();
			}
			if (this.timer_2 != null)
			{
				this.timer_2.Enabled = false;
				this.timer_2.Close();
				this.timer_2.Dispose();
			}
			World.class76_0 = null;
		}

		public void method_0(int int_0, float float_0, float float_1, int int_1)
		{
			int num = World.smethod_19(int_0, float_0, float_1, int_1);
			THIET_LAP_BOSS_CLASS2.list_0.Add(num);
		}

		public void timer_0_Elapsed(object sender, ElapsedEventArgs e)
		{
			try
			{
				TimeSpan timeSpan = this.dateTime_0.Subtract(DateTime.Now);
				int totalSeconds = (int)timeSpan.TotalSeconds;
				if (totalSeconds != 0)
				{
					foreach (Players value in World.allConnectedChars.Values)
					{
						value.MOVE_NEW(0f, 0f, 15f, 1201);
						value.SendCountdown(12, 9, totalSeconds);
						value.GameMessage(string.Concat("BOSS invasion army from Hyun Bo faction left", totalSeconds / 60, "Please minute heroes ready to rumble ready"), 10, "System Broadcast");
						World.SendMsg(string.Concat("BOSS invasion army from Hyun Bo faction left", totalSeconds / 60, "Please minute heroes ready to rumble ready"));
					}
				}
			}
			catch (Exception exception)
			{
				Form1.WriteLine(1, string.Concat("BOSS siege time ends Event 1 error：", exception));
			}
		}

		public void timer_1_Elapsed(object sender, ElapsedEventArgs e)
		{
			this.timer_0.Enabled = false;
			this.timer_0.Close();
			this.timer_0.Dispose();
			this.timer_1.Enabled = false;
			this.timer_1.Close();
			this.timer_1.Dispose();
			this.timer_2 = new Timer((double)int.Parse(this.string_0[6]) * 60000);
			this.timer_2.Elapsed += new ElapsedEventHandler(this.timer_2_Elapsed);
			this.timer_2.Enabled = true;
			Random random = new Random(DateTime.Now.Millisecond);
			float single = 1f + (float)int.Parse(this.string_0[2]);
			float single1 = 1f + (float)int.Parse(this.string_0[3]);
			List<TBL_XWWL_MONSTER> tBLXWWLMONSTERs = new List<TBL_XWWL_MONSTER>();
			try
			{
				foreach (Players value in World.allConnectedChars.Values)
				{
					value.GameMessage(string.Concat("BOSS siege began. We have", int.Parse(this.string_0[6]), "Minutes to clean up the BOSS"), 10, "System Broadcast");
				}
			}
			catch (Exception exception)
			{
				Form1.WriteLine(1, string.Concat("BOSS攻城战 THOI_GIAN_KET_THUC_SU_KIEN1 出错：", exception));
			}
			foreach (TBL_XWWL_MONSTER tBLXWWLMONSTER in World.dictionary_13.Values)
			{
				if (tBLXWWLMONSTER.FLD_BOSS != int.Parse(this.string_0[10]))
				{
					continue;
				}
				tBLXWWLMONSTERs.Add(tBLXWWLMONSTER);
			}
			for (int i = 0; i < int.Parse(this.string_0[7]); i++)
			{
				int num = random.Next(0, 2);
				double num1 = (double)random.Next(0, int.Parse(this.string_0[8]));
				double num2 = (double)random.Next(0, int.Parse(this.string_0[9]));
				int num3 = random.Next(0, tBLXWWLMONSTERs.Count);
				int fLDPID = tBLXWWLMONSTERs[num3].FLD_PID;
				float single2 = single + (float)num1;
				float single3 = single1 + (float)num2;
				float single4 = single - (float)num1;
				float single5 = single1 - (float)num2;
				if (num != 0)
				{
					this.method_0(fLDPID, single4, single5, int.Parse(this.string_0[1]));
				}
				else
				{
					this.method_0(fLDPID, single2, single3, int.Parse(this.string_0[1]));
				}
			}
		}

		public void timer_2_Elapsed(object sender, ElapsedEventArgs e)
		{
			this.timer_2.Enabled = false;
			this.timer_2.Close();
			this.timer_2.Dispose();
			int num = 0;
			try
			{
				foreach (int list0 in THIET_LAP_BOSS_CLASS2.list_0)
				{
					foreach (TBL_XWWL_NPC value in MapClass.GetnpcTemplate(int.Parse(this.string_0[1])).Values)
					{
						if (value.FLD_INDEX != list0)
						{
							continue;
						}
						num++;
					}
				}
			}
			catch (Exception exception)
			{
				Form1.WriteLine(1, string.Concat("计算BOSS攻城的怪物所剩数量出错：", exception));
			}
			if (num <= 0)
			{
				try
				{
					foreach (Players player in World.allConnectedChars.Values)
					{
						player.System_Announcement(string.Concat("[", TBL_XWWL_MAP.smethod_0(int.Parse(this.string_0[1])), "]保卫战中获得胜利"));
					}
				}
				catch (Exception exception1)
				{
					Form1.WriteLine(1, string.Concat("THOI_GIAN_KET_THUC_SU_KIEN3 说话2 出错：", exception1));
				}
			}
			else
			{
				try
				{
					foreach (Players value1 in World.allConnectedChars.Values)
					{
						value1.System_Announcement(string.Concat("非常遗憾，怪物们已经占领[", TBL_XWWL_MAP.smethod_0(int.Parse(this.string_0[1])), "]你们的安全正在受到威胁，请在下一次战斗中务必把可恶的怪物消灭掉"));
					}
					this.Dispose();
				}
				catch (Exception exception2)
				{
					Form1.WriteLine(1, string.Concat("THOI_GIAN_KET_THUC_SU_KIEN3 说话 出错：", exception2));
					this.Dispose();
				}
			}
		}

		private static void ZYDNGuard()
		{
			THIET_LAP_BOSS_CLASS2.list_0 = new List<int>();
		}
	}
}