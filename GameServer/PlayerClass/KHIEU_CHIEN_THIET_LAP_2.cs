using ns13;
using ns3;
using ns9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Timers;

namespace ns2
{
	internal class KHIEU_CHIEN_THIET_LAP_2 : IDisposable
	{
		private DateTime dateTime_0 = DateTime.Now.AddMinutes(5);

		private Timer timer_0 = new Timer(60000);

		public KHIEU_CHIEN_THIET_LAP_2()
		{
			this.timer_0.Elapsed += new ElapsedEventHandler(this.timer_0_Elapsed);
			this.timer_0.Enabled = true;
			this.timer_0.AutoReset = true;
		}

		public void Dispose()
		{
			World.list_2.Clear();
			if (this.timer_0 != null)
			{
				this.timer_0.Enabled = false;
				this.timer_0.Close();
				this.timer_0.Dispose();
			}
			World.class12_0 = null;
		}

		public void timer_0_Elapsed(object sender, ElapsedEventArgs e)
		{
			try
			{
				TimeSpan timeSpan = this.dateTime_0.Subtract(DateTime.Now);
				int totalSeconds = (int)timeSpan.TotalSeconds;
				if (totalSeconds == 0)
				{
					foreach (Players list2 in World.list_2)
					{
						if (list2.CharacterCoords_Map != World.Khieu_chien_ban_do_so_hieu)
						{
							continue;
						}
						list2.GameMessage("In the game is not completed within the specified time will be charged registration fees other gold return", 10, "End Challenge");
						list2.method_47((long)(World.Khieu_chien_xin_can_thiet_CASH_So_luong - World.Khieu_chien_he_thong_thu_ve_CASH_So_luong), 1);
						list2.UPDATE_RXPIONT();
						string[] strArrays = World.Tu_vong_tro_ve_thanh_Ban_do_Toa_do.Trim().Split(new char[] { ',' });
						list2.MOVE_NEW((float)int.Parse(strArrays[1]), (float)int.Parse(strArrays[2]), 15f, int.Parse(strArrays[0]));
					}
					foreach (Players player in World.list_2)
					{
						player.GameMessage("Now no one is using the arena, athletics friends do not miss it", 10, "friendly reminder");
					}
					this.Dispose();
				}
				else
				{
					foreach (Players list21 in World.list_2)
					{
						list21.GameMessage(string.Concat("From the left end of the game", totalSeconds / 60, "Minutes. Please quickly resolve the fighting"), 10, "friendly reminder");
					}
				}
			}
			catch (Exception exception)
			{
				Form1.WriteLine(1, string.Concat("KET_THUC THOI_GIAN_KET_THUC_SU_KIEN1 LOI：", exception));
			}
		}
	}
}