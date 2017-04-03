using ns13;
using ns2;
using ns3;
using ns9;
using RxjhServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading;
using System.Timers;

namespace ns10
{
	public class EventClass : IDisposable
	{
		private DateTime kssj;

		private DateTime kssjgj;

		private int kssjint;

		private int THE_LUC_CHIEN_sj;

		private System.Timers.Timer THOI_GIAN_1;

		private System.Timers.Timer THOI_GIAN_2;

		private System.Timers.Timer THOI_GIAN_3;

		private System.Timers.Timer THOI_GIAN_4;

		private System.Timers.Timer THOI_GIAN_5;

		public EventClass()
		{
			try
			{
				if (World.jlMsg == 1)
				{
					Form1.WriteLine(0, "EventClass-");
				}
				World.EventTop.Clear();
				this.kssj = DateTime.Now.AddMinutes(3);
				World.THE_LUC_CHIEN_2_TIEN_TRINH = 1;
				World.THE_LUC_CHIEN_2_CHINH_PHAI_DIEM_SO = 0;
				World.THE_LUC_CHIEN_2_TA_PHAI_DIEM_SO = 0;
				this.THOI_GIAN_1 = new System.Timers.Timer(60000);
				this.THOI_GIAN_1.Elapsed += new ElapsedEventHandler(this.THOI_GIAN_KET_THUC_SU_KIEN1);
				this.THOI_GIAN_1.Enabled = true;
				this.THOI_GIAN_1.AutoReset = true;
				this.THOI_GIAN_KET_THUC_SU_KIEN1(null, null);
			}
			catch (Exception exception)
			{
				Form1.WriteLine(1, string.Concat("势力战 EventClass 出错：", exception));
			}
		}

		public void Dispose()
		{
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "EventClass-Dispose");
			}
			World.THE_LUC_CHIEN_2_TIEN_TRINH = 0;
			World.THE_LUC_CHIEN_2_THOI_GIAN = 0;
			World.THE_LUC_CHIEN_2_CHINH_PHAI_DIEM_SO = 0;
			World.THE_LUC_CHIEN_2_TA_PHAI_DIEM_SO = 0;
			if (this.THOI_GIAN_1 != null)
			{
				this.THOI_GIAN_1.Enabled = false;
				this.THOI_GIAN_1.Close();
				this.THOI_GIAN_1.Dispose();
			}
			if (this.THOI_GIAN_2 != null)
			{
				this.THOI_GIAN_2.Enabled = false;
				this.THOI_GIAN_2.Close();
				this.THOI_GIAN_2.Dispose();
			}
			if (this.THOI_GIAN_3 != null)
			{
				this.THOI_GIAN_3.Enabled = false;
				this.THOI_GIAN_3.Close();
				this.THOI_GIAN_3.Dispose();
			}
			if (this.THOI_GIAN_4 != null)
			{
				this.THOI_GIAN_4.Enabled = false;
				this.THOI_GIAN_4.Close();
				this.THOI_GIAN_4.Dispose();
			}
			foreach (Players value in World.allConnectedChars.Values)
			{
				if (value.CharacterCoords_Map != 801)
				{
					continue;
				}
				value.Move(420f, 1550f, 15f, 101);
			}
			World.list_0.Clear();
			World.eve = null;
			World.delNpc(801, 15137);
		}

		public void jl(string string_0)
		{
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "EventClass-jl");
			}
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("Select * from [EventTop] where THE_LUC='{0}' Order By GIET_NGUOI_SO Desc,TU_VONG_SO Asc", string_0));
			if (dBToDataTable != null && dBToDataTable.Rows.Count > 0)
			{
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					Players player = World.smethod_2(dBToDataTable.Rows[i]["NHAN_VAT_TEN"].ToString());
					if (player != null)
					{
						foreach (TBL_XWWL_DROP tBLXWWLDROP in TBL_XWWL_DROP.smethod_0(i * (100 / dBToDataTable.Rows.Count)))
						{
							if (tBLXWWLDROP == null)
							{
								continue;
							}
							int fLDPID = tBLXWWLDROP.FLD_PID;
							if (fLDPID > 800000002)
							{
								if (fLDPID == 800000013)
								{
									Random random = new Random();
									int num = random.Next(8, 10);
									string str = "0000";
									int num1 = 0;
									num1 = random.Next(1, 3);
									string str1 = string.Concat(num.ToString(), str, num1);
									tBLXWWLDROP.FLD_MAGIC0 = int.Parse(str1);
								}
								else
								{
									switch (fLDPID)
									{
										case 800000023:
										{
											tBLXWWLDROP.FLD_MAGIC0 = (new Random()).Next(700020, 700031);
											break;
										}
										case 800000024:
										{
											tBLXWWLDROP.FLD_MAGIC0 = (new Random()).Next(200018, 200026);
											break;
										}
										case 800000025:
										{
											tBLXWWLDROP.FLD_MAGIC0 = (new Random()).Next(1000005, 1000021);
											break;
										}
										case 800000026:
										{
											tBLXWWLDROP.FLD_MAGIC0 = (new Random()).Next(700015, 700026);
											break;
										}
										case 800000028:
										{
											int num2 = (new Random()).Next(1, 7);
											string str2 = "000";
											string str3 = string.Concat("200", num2.ToString(), str2);
											tBLXWWLDROP.FLD_MAGIC0 = int.Parse(str3);
											break;
										}
									}
								}
							}
							else if (fLDPID == 800000001)
							{
								tBLXWWLDROP.FLD_MAGIC0 = (new Random()).Next(100010, 100026);
							}
							else if (fLDPID == 800000002)
							{
								tBLXWWLDROP.FLD_MAGIC0 = (new Random()).Next(200010, 200021);
							}
							int num3 = player.DUOC_KIEN_HANG_RONG(player);
							if (num3 == -1)
							{
								continue;
							}
							byte[] bytes = BitConverter.GetBytes(tBLXWWLDROP.FLD_PID);
							byte[] numArray = BitConverter.GetBytes(1);
							byte[] numArray1 = new byte[56];
							byte[] bytes1 = BitConverter.GetBytes(RxjhClass.GetDBItmeId());
							Buffer.BlockCopy(BitConverter.GetBytes(tBLXWWLDROP.FLD_MAGIC0), 0, numArray1, 0, 4);
							Buffer.BlockCopy(BitConverter.GetBytes(tBLXWWLDROP.FLD_MAGIC1), 0, numArray1, 4, 4);
							Buffer.BlockCopy(BitConverter.GetBytes(tBLXWWLDROP.FLD_MAGIC2), 0, numArray1, 8, 4);
							Buffer.BlockCopy(BitConverter.GetBytes(tBLXWWLDROP.FLD_MAGIC3), 0, numArray1, 12, 4);
							Buffer.BlockCopy(BitConverter.GetBytes(tBLXWWLDROP.FLD_MAGIC4), 0, numArray1, 16, 4);
							player.TANG_CUONG_VAT_PHAM(bytes1, bytes, num3, numArray, numArray1);
						}
					}
				}
			}
		}

		public void outslz(int int_2)
		{
			EventTopClass eventTopClass;
			try
			{
				foreach (Players value in World.allConnectedChars.Values)
				{
					if (value.CharacterCoords_Map != 801)
					{
						continue;
					}
					if (!World.EventTop.TryGetValue(value.UserName, out eventTopClass))
					{
						value.Move(529f, 1528f, 15f, 101);
						value.sjts();
					}
					else
					{
						if (int_2 == 1 && eventTopClass.Kills < 1)
						{
							value.Move(420f, 1550f, 15f, 101);
							value.sjts();
						}
						if (int_2 != 2 || eventTopClass.Kills >= 2)
						{
							continue;
						}
						value.Move(420f, 1550f, 15f, 101);
						value.sjts();
					}
				}
			}
			catch
			{
			}
		}

		public void THOI_GIAN_KET_THUC_SU_KIEN1(object sender, ElapsedEventArgs e)
		{
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "EventClass_THOI_GIAN_KET_THUC_SU_KIEN1");
			}
			try
			{
				TimeSpan timeSpan = this.kssj.Subtract(DateTime.Now);
				int totalSeconds = (int)timeSpan.TotalSeconds;
				if (totalSeconds <= 0)
				{
					World.THE_LUC_CHIEN_2_TIEN_TRINH = 2;
					World.THE_LUC_CHIEN_2_CHINH_PHAI_DIEM_SO = 0;
					World.THE_LUC_CHIEN_2_TA_PHAI_DIEM_SO = 0;
					totalSeconds = 0;
				}
				this.kssjint = totalSeconds;
				foreach (Players value in World.allConnectedChars.Values)
				{
					if (value.CharacterCoords_Map != 801)
					{
						if (World.list_0.Contains(value) || value.Player_FLD_JOB_LEVEL < 2)
						{
							continue;
						}
						value.GUI_DI_THE_LUC_CHIEN_MOI_THAM_GIA_2();
					}
					else
					{
						value.GUI_DI_THE_LUC_CHIEN_NHANH_CHONG_BAT_DAU_TIN_TUC(this.kssjint);
						value.SendCountdown(12, 9, this.kssjint);
					}
				}
				if (this.kssjint <= 0)
				{
					this.THOI_GIAN_1.Enabled = false;
					this.THOI_GIAN_1.Close();
					this.THOI_GIAN_1.Dispose();
					World.THE_LUC_CHIEN_2_TIEN_TRINH = 3;
					this.kssjgj = DateTime.Now.AddMinutes(30);
					this.THOI_GIAN_2 = new System.Timers.Timer(10000);
					this.THOI_GIAN_2.Elapsed += new ElapsedEventHandler(this.THOI_GIAN_KET_THUC_SU_KIEN2);
					this.THOI_GIAN_2.Enabled = true;
					this.THOI_GIAN_2.AutoReset = true;
					int count = World.list_0.Count;
					int num = count / 2;
					if (count % 2 != 0)
					{
						for (int i = 0; i < count; i++)
						{
							if (i >= num + 1)
							{
								World.list_0[i].Player_Zx = 2;
								World.list_0[i].Move(-565f, 0f, 15f, 801);
								World.list_0[i].Update_Figure_Data(World.list_0[i]);
								World.list_0[i].Update_Data_Boardcast();
								World.list_0[i].GameMessage("Midway exit any case, unable to participate in re-entering. Mythical war, acquirer can brush BOSS, award prizes.", 10, "system message");
								World.THE_LUC_CHIEN_TA_PHAI_SO_NGUOI = World.THE_LUC_CHIEN_TA_PHAI_SO_NGUOI + 1;
							}
							else
							{
								World.list_0[i].Player_Zx = 1;
								World.list_0[i].Move(545f, 0f, 15f, 801);
								World.list_0[i].Update_Figure_Data(World.list_0[i]);
								World.list_0[i].Update_Data_Boardcast();
								World.list_0[i].GameMessage("Midway exit any case, unable to participate in re-entering. Mythical war, acquirer can brush BOSS, award prizes.", 10, "system message");
								World.THE_LUC_CHIEN_2_CHINH_PHAI_SO_NGUOI = World.THE_LUC_CHIEN_2_CHINH_PHAI_SO_NGUOI + 1;
							}
						}
					}
					else
					{
						for (int j = 0; j < count; j++)
						{
							if (j >= num)
							{
								World.list_0[j].Player_Zx = 2;
								World.list_0[j].Move(-565f, 0f, 15f, 801);
								World.list_0[j].Update_Figure_Data(World.list_0[j]);
								World.list_0[j].Update_Data_Boardcast();
								World.list_0[j].GameMessage("Midway exit any case, unable to participate in re-entering. Mythical war, acquirer can brush BOSS, award prizes.", 10, "system message");
								World.THE_LUC_CHIEN_TA_PHAI_SO_NGUOI = World.THE_LUC_CHIEN_TA_PHAI_SO_NGUOI + 1;
							}
							else
							{
								World.list_0[j].Player_Zx = 1;
								World.list_0[j].Move(545f, 0f, 15f, 801);
								World.list_0[j].Update_Figure_Data(World.list_0[j]);
								World.list_0[j].Update_Data_Boardcast();
								World.list_0[j].GameMessage("Midway exit any case, unable to participate in re-entering. Mythical war, acquirer can brush BOSS, award prizes.", 10, "system message");
								World.THE_LUC_CHIEN_2_CHINH_PHAI_SO_NGUOI = World.THE_LUC_CHIEN_2_CHINH_PHAI_SO_NGUOI + 1;
							}
						}
					}
				}
			}
			catch (Exception exception)
			{
				Form1.WriteLine(1, string.Concat("势力战 THOI_GIAN_KET_THUC_SU_KIEN1 出错：", exception));
			}
		}

		public void THOI_GIAN_KET_THUC_SU_KIEN2(object sender, ElapsedEventArgs e)
		{
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "EventClass_THOI_GIAN_KET_THUC_SU_KIEN2");
			}
			try
			{
				TimeSpan timeSpan = this.kssjgj.Subtract(DateTime.Now);
				int totalSeconds = (int)timeSpan.TotalSeconds;
				World.THE_LUC_CHIEN_2_THOI_GIAN = totalSeconds;
				foreach (Players value in World.allConnectedChars.Values)
				{
					if (value.CharacterCoords_Map != 801)
					{
						value.GUI_DI_THE_LUC_CHIEN_QUET_DIEM_MOI();
					}
					else
					{
						value.GUI_DI_THE_LUC_CHIEN_TIN_TUC();
						value.SendCountdown(3, 1, 11);
					}
				}
				if (totalSeconds <= 0)
				{
					this.THOI_GIAN_2.Enabled = false;
					this.THOI_GIAN_2.Close();
					this.THOI_GIAN_2.Dispose();
					World.THE_LUC_CHIEN_2_TIEN_TRINH = 4;
					this.THOI_GIAN_3 = new System.Timers.Timer(30000);
					this.THOI_GIAN_3.Elapsed += new ElapsedEventHandler(this.THOI_GIAN_KET_THUC_SU_KIEN3);
					this.THOI_GIAN_3.Enabled = true;
					this.THOI_GIAN_3.AutoReset = false;
				}
			}
			catch (Exception exception)
			{
				Form1.WriteLine(1, string.Concat("势力战 THOI_GIAN_KET_THUC_SU_KIEN2 出错：", exception));
			}
		}

		public void THOI_GIAN_KET_THUC_SU_KIEN3(object sender, ElapsedEventArgs e)
		{
			DateTime now;
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "EventClass_THOI_GIAN_KET_THUC_SU_KIEN3");
			}
			try
			{
				DBA.ExeSqlCommand(string.Concat("DELETE FROM EventTop where PHAN_KHU_TIN_TUC='", World.Phan_khu_danh_so, "'"));
				foreach (EventTopClass value in World.EventTop.Values)
				{
					DBA.ExeSqlCommand(string.Format("INSERT INTO EventTop (NHAN_VAT_TEN,BANG_PHAI,THE_LUC,DANG_CAP,GIET_NGUOI_SO,TU_VONG_SO,PHAN_KHU_TIN_TUC)values('{0}','{1}','{2}',{3},{4},{5},'{6}')", new object[] { value.string_0, value.string_1, value.THE_LUC, value.int_0, value.Kills, value.Dead, World.Phan_khu_danh_so }));
				}
				string empty = string.Empty;
				World.EventTop.Clear();
				if (World.THE_LUC_CHIEN_2_CHINH_PHAI_DIEM_SO > World.THE_LUC_CHIEN_2_TA_PHAI_DIEM_SO)
				{
					this.THE_LUC_CHIEN_sj = 1;
					World.SendMsg("Death loss of っ leave Iraq by Nan Yi Yi づ cut Bru village: the ignorant column");
				}
				else if (World.THE_LUC_CHIEN_2_CHINH_PHAI_DIEM_SO != World.THE_LUC_CHIEN_2_TA_PHAI_DIEM_SO)
				{
					this.THE_LUC_CHIEN_sj = 2;
					World.SendMsg("Death loss of っ Iraqi borrow clothes づ Yijianangua Bru village: through sister bright");
				}
				else
				{
					this.THE_LUC_CHIEN_sj = 3;
					World.SendMsg("Death loss of っ Iraqi borrow clothes づ Yijianangua Bru village: Suo Restraints");
				}
				foreach (Players player in World.allConnectedChars.Values)
				{
					if (player.CharacterCoords_Map == 801)
					{
						player.GUI_DI_THE_LUC_CHIEN_KET_THUC_TIN_TUC(this.THE_LUC_CHIEN_sj);
						if (player.Player_Zx == this.THE_LUC_CHIEN_sj)
						{
							if (World.The_luc_chien_khen_thuong_Loai_hinh == 1)
							{
								string[] strArrays = World.The_luc_chien_khen_thuong_Thuoc_tinh.Split(new char[] { ';' });
								string[] strArrays1 = World.Thang_cap_thanh_vien_can_Thuoc_tinh.Split(new char[] { ',' });
								if (int.Parse(strArrays[0]) != 0)
								{
									Players khenThuongThemVaoSinhMenh = player;
									khenThuongThemVaoSinhMenh.Khen_thuong_them_vao_sinh_menh = khenThuongThemVaoSinhMenh.Khen_thuong_them_vao_sinh_menh + long.Parse(strArrays[0]);
									player.GameMessage(string.Concat("life", long.Parse(strArrays[0])), 10, "Forces battle reward");
								}
								if (long.Parse(strArrays[1]) != 0 && player.Khen_thuong_them_vao_cong_kich < long.Parse(strArrays1[0]))
								{
									Players khenThuongThemVaoCongKich = player;
									khenThuongThemVaoCongKich.Khen_thuong_them_vao_cong_kich = khenThuongThemVaoCongKich.Khen_thuong_them_vao_cong_kich + long.Parse(strArrays[1]);
									player.GameMessage(string.Concat("attack", long.Parse(strArrays[1])), 10, "Forces battle reward");
								}
								if (long.Parse(strArrays[2]) != 0 && player.Khen_thuong_them_vao_phong_ngu < long.Parse(strArrays1[1]))
								{
									Players khenThuongThemVaoPhongNgu = player;
									khenThuongThemVaoPhongNgu.Khen_thuong_them_vao_phong_ngu = khenThuongThemVaoPhongNgu.Khen_thuong_them_vao_phong_ngu + long.Parse(strArrays[2]);
									player.GameMessage(string.Concat("defense", long.Parse(strArrays[2])), 10, "Forces battle reward");
								}
								if (int.Parse(strArrays[3]) != 0)
								{
									Players khenThuongThemVaoNeTranh = player;
									khenThuongThemVaoNeTranh.Khen_thuong_them_vao_ne_tranh = khenThuongThemVaoNeTranh.Khen_thuong_them_vao_ne_tranh + int.Parse(strArrays[3]);
									player.GameMessage(string.Concat("avoid", int.Parse(strArrays[3])), 10, "Forces battle reward");
								}
								if (int.Parse(strArrays[4]) != 0)
								{
									Players khenThuongThemVaoNoiCong = player;
									khenThuongThemVaoNoiCong.Khen_thuong_them_vao_noi_cong = khenThuongThemVaoNoiCong.Khen_thuong_them_vao_noi_cong + int.Parse(strArrays[4]);
									player.GameMessage(string.Concat("Neigong", int.Parse(strArrays[4])), 10, "Forces battle reward");
								}
								if (int.Parse(strArrays[5]) != 0)
								{
									Players khenThuongThemVaoTrungMucTieu = player;
									khenThuongThemVaoTrungMucTieu.Khen_thuong_them_vao_trung_muc_tieu = khenThuongThemVaoTrungMucTieu.Khen_thuong_them_vao_trung_muc_tieu + int.Parse(strArrays[5]);
									player.GameMessage(string.Concat("Hit", int.Parse(strArrays[5])), 10, "Forces battle reward");
								}
								if (int.Parse(strArrays[6]) != 0 && player.FLD_RXPIONT != World.Nhan_vat_lon_nhat_CASH_so_luong)
								{
									player.KIEM_TRA_BACH_BAO_CAC_NGUYEN_BAO_SO_LUONG();
									player.KIEM_SOAT_CASH_SO_LIEU(int.Parse(strArrays[6]), 1);
									player.GameMessage(string.Concat("Get", int.Parse(strArrays[6]), "Ingot!"), 10, "Forces battle reward");
									player.UPDATE_RXPIONT();
								}
								if (int.Parse(strArrays[7]) != 0)
								{
									Players playerWuXun = player;
									playerWuXun.Player_WuXun = playerWuXun.Player_WuXun + int.Parse(strArrays[7]);
									player.GameMessage(string.Concat("Nhan duoc diem vo huan:  ", int.Parse(strArrays[7])), 10, World.ServerName);
									player.UpdatePowersAndStatus();
								}
								if (int.Parse(strArrays[8]) != 0)
								{
									DateTime dateTime = DateTime.Now;
									now = DateTime.Now;
									dateTime = now.AddDays((double)int.Parse(strArrays[8]));
									player.FLD_VIP = 1;
									player.FLD_VIPTIM = dateTime;
									player.LUU_THANH_VIEN_SO_LIEU();
									player.GameMessage(string.Concat("Congratulations, you get", int.Parse(strArrays[8]), "Day membership, please check the small back!"), 10, "Reward fighting forces");
								}
							}
							else if (World.The_luc_chien_khen_thuong_Loai_hinh == 2)
							{
								int num = player.DUOC_KIEN_HANG_RONG(player);
								if (num == -1)
								{
									player.GameMessage("Please leave by empty backpack, send have AK IT!", 10, "Reward fighting forces");
									return;
								}
								else
								{
									byte[] bytes = BitConverter.GetBytes(RxjhClass.GetDBItmeId());
									byte[] numArray = new byte[56];
									player.TANG_CUONG_VAT_PHAM_1(bytes, BitConverter.GetBytes(World.The_luc_chien_khen_thuong_trang_phuc), num, BitConverter.GetBytes(1), numArray, false);
									player.GameMessage("Congratulations, you get a package, please check!", 10, "Reward fighting forces");
								}
							}
							else if (World.The_luc_chien_khen_thuong_Loai_hinh == 3)
							{
								string[] strArrays2 = World.The_luc_chien_khen_thuong_Item.Split(new char[] { ';' });
								int num1 = player.DUOC_KIEN_HANG_RONG(player);
								if (num1 == -1)
								{
									player.GameMessage("Please leave an empty backpack, send you a mysterious gift Oh!", 10, "Reward fighting forces");
									return;
								}
								else
								{
									player.BACH_BAO_TANG_CUONG_ITEM_MANG_THUOC_TINH(int.Parse(strArrays2[0]), num1, int.Parse(strArrays2[1]), int.Parse(strArrays2[2]), int.Parse(strArrays2[3]), int.Parse(strArrays2[4]), int.Parse(strArrays2[5]), int.Parse(strArrays2[6]), int.Parse(strArrays2[7]), int.Parse(strArrays2[8]), int.Parse(strArrays2[9]), int.Parse(strArrays2[10]), int.Parse(strArrays2[11]));
									player.GameMessage("Congratulations, you get a system of reward items, please check!", 10, "Reward fighting forces");
								}
							}
						}
					}
					player.SendCountdown(5, 2, 0);
				}
				World.THE_LUC_CHIEN_2_TIEN_TRINH = 5;
				now = DateTime.Now;
				this.kssjgj = now.AddMinutes(30);
				this.THOI_GIAN_3.Enabled = false;
				this.THOI_GIAN_3.Close();
				this.THOI_GIAN_3.Dispose();
				this.THOI_GIAN_4 = new System.Timers.Timer(60000);
				this.THOI_GIAN_4.Elapsed += new ElapsedEventHandler(this.THOI_GIAN_KET_THUC_SU_KIEN4);
				this.THOI_GIAN_4.Enabled = true;
				this.THOI_GIAN_4.AutoReset = true;
				this.THOI_GIAN_5 = new System.Timers.Timer(60000);
				this.THOI_GIAN_5.Elapsed += new ElapsedEventHandler(this.THOI_GIAN_KET_THUC_SU_KIEN5);
				this.THOI_GIAN_5.Enabled = true;
				this.THOI_GIAN_5.AutoReset = true;
			}
			catch (Exception exception)
			{
				Form1.WriteLine(1, string.Concat("势力战 THOI_GIAN_KET_THUC_SU_KIEN3 出错：", exception));
			}
		}

		public void THOI_GIAN_KET_THUC_SU_KIEN4(object sender, ElapsedEventArgs e)
		{
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "EventClass_THOI_GIAN_KET_THUC_SU_KIEN4");
			}
			try
			{
				TimeSpan timeSpan = this.kssjgj.Subtract(DateTime.Now);
				int totalSeconds = (int)timeSpan.TotalSeconds;
				World.THE_LUC_CHIEN_2_THOI_GIAN = totalSeconds;
				foreach (Players value in World.allConnectedChars.Values)
				{
					if (value.CharacterCoords_Map != 801 || value.Player_Zx == this.THE_LUC_CHIEN_sj)
					{
						continue;
					}
					value.Move(420f, 1550f, 15f, 101);
				}
				if (totalSeconds <= 0)
				{
					this.THOI_GIAN_4.Enabled = false;
					this.THOI_GIAN_4.Close();
					this.THOI_GIAN_4.Dispose();
					World.THE_LUC_CHIEN_2_TIEN_TRINH = 6;
					foreach (Players player in World.allConnectedChars.Values)
					{
						if (player.CharacterCoords_Map != 801)
						{
							continue;
						}
						string[] strArrays = World.The_luc_chien_tro_ve_Thanh_toa_do.Trim().Split(new char[] { ',' });
						player.Move((float)int.Parse(strArrays[1]), (float)int.Parse(strArrays[2]), 15f, int.Parse(strArrays[0]));
					}
					this.Dispose();
				}
			}
			catch (Exception exception)
			{
				Form1.WriteLine(1, string.Concat("势力战 THOI_GIAN_KET_THUC_SU_KIEN4 出错：", exception));
			}
		}

		public void THOI_GIAN_KET_THUC_SU_KIEN5(object sender, ElapsedEventArgs e)
		{
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "EventClass_THOI_GIAN_KET_THUC_SU_KIEN5");
			}
			try
			{
				this.THOI_GIAN_5.Enabled = false;
				this.THOI_GIAN_5.Close();
				this.THOI_GIAN_5.Dispose();
				World.smethod_20(15137, 0f, 0f, 801);
				Thread.Sleep(1000);
				World.smethod_20(15137, 10f, 0f, 801);
				Thread.Sleep(1000);
				World.smethod_20(15137, -10f, 0f, 801);
				Thread.Sleep(1000);
				World.smethod_20(15137, 15f, -5f, 801);
				Thread.Sleep(1000);
				World.smethod_20(15137, -15f, 5f, 801);
				Thread.Sleep(1000);
				World.smethod_20(15137, -12f, 10f, 801);
			}
			catch (Exception exception)
			{
				Form1.WriteLine(1, string.Concat("势力战 THOI_GIAN_KET_THUC_SU_KIEN5 出错：", exception));
			}
		}
	}
}