using ns13;
using ns9;
using RxjhServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Timers;

namespace ns3
{
	internal class KHIEU_CHIEN : IDisposable
	{
		private DateTime dateTime_0 = DateTime.Now.AddMinutes(5);

		private Timer timer_0 = new Timer(60000);

		public KHIEU_CHIEN()
		{
			this.timer_0.Elapsed += new ElapsedEventHandler(this.timer_0_Elapsed);
			this.timer_0.Enabled = true;
			this.timer_0.AutoReset = true;
		}

		public void Dispose()
		{
			World.list_3.Clear();
			if (this.timer_0 != null)
			{
				this.timer_0.Enabled = false;
				this.timer_0.Close();
				this.timer_0.Dispose();
			}
			World.class61_0 = null;
		}

		public void timer_0_Elapsed(object sender, ElapsedEventArgs e)
		{
			try
			{
				if ((int)this.dateTime_0.Subtract(DateTime.Now).TotalSeconds != 0)
				{
					foreach (Players list3 in World.list_3)
					{
						TimeSpan timeSpan = this.dateTime_0.Subtract(DateTime.Now);
						int totalSeconds = (int)timeSpan.TotalSeconds;
						foreach (Players value in World.allConnectedChars.Values)
						{
							value.SendCountdown(12, 9, totalSeconds);
							int num = (new Random(World.smethod_15())).Next(1, 4);
							string str = string.Format(World.Khieu_chien_la_to_noi_dung_1, list3.UserName);
							string str1 = string.Format(World.Khieu_chien_la_to_noi_dung_1, list3.UserName);
							string str2 = string.Format(World.Khieu_chien_la_to_noi_dung_1, list3.UserName);
							switch (num)
							{
								case 1:
								{
									value.GameMessage(str ?? "", 23, "accept the challenge");
									continue;
								}
								case 2:
								{
									value.GameMessage(str1 ?? "", 24, "accept the challenge");
									continue;
								}
								case 3:
								{
									value.GameMessage(str2 ?? "", 26, "accept the challenge");
									continue;
								}
							}
							value.GameMessage(str2 ?? "", 26, "accept the challenge");
						}
					}
				}
				else
				{
					foreach (Players player in World.list_3)
					{
						if (player.CharacterCoords_Map != World.Khieu_chien_ban_do_so_hieu)
						{
							continue;
						}
						player.GameMessage("No people participating within the specified time to return your gold", 10, "End Challenge");
						player.method_47((long)World.Khieu_chien_xin_can_thiet_CASH_So_luong, 1);
						player.UPDATE_RXPIONT();
						string[] strArrays = World.Tu_vong_tro_ve_thanh_Ban_do_Toa_do.Trim().Split(new char[] { ',' });
						player.MOVE_NEW((float)int.Parse(strArrays[1]), (float)int.Parse(strArrays[2]), 15f, int.Parse(strArrays[0]));
					}
					this.Dispose();
				}
			}
			catch (Exception exception)
			{
				Form1.WriteLine(1, string.Concat("KET_THUC THOI_GIAN_KET_THUC_SU_KIEN1 LOI：", exception));
			}
		}
	}
}