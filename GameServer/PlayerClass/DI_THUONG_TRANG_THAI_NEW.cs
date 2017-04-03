using ns10;
using ns12;
using ns13;
using ns3;
using ns9;
using RxjhServer;
using System;
using System.ComponentModel;
using System.Timers;

namespace ns1
{
	public class DI_THUONG_TRANG_THAI_NEW : IDisposable
	{
		public Players class15_0;

		public TBL_XWWL_NPC class153_0;

		public DateTime dateTime_0;

		public double double_0;

		public int int_0;

		private int int_1;

		public Timer timer_0;

		public Timer timer_1;

		public int FLD_PID
		{
			get
			{
				return this.int_1;
			}
			set
			{
				this.int_1 = value;
			}
		}

		public DI_THUONG_TRANG_THAI_NEW(Players Play_, int THOI_GIAN, int DI_THUONG_ID, int DI_THUONG_SO_LUONG)
		{
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "DI_THUONG_TRANG_THAI_LOAI-NEW");
			}
			this.FLD_PID = DI_THUONG_ID;
			this.dateTime_0 = DateTime.Now;
			this.dateTime_0 = this.dateTime_0.AddMilliseconds((double)THOI_GIAN);
			this.class15_0 = Play_;
			this.timer_0 = new Timer((double)THOI_GIAN);
			this.timer_0.Elapsed += new ElapsedEventHandler(this.timer_0_Elapsed);
			this.timer_0.Enabled = true;
			this.timer_0.AutoReset = false;
			this.method_2(this.FLD_PID, 1, DI_THUONG_SO_LUONG, THOI_GIAN / 1000);
		}

		public DI_THUONG_TRANG_THAI_NEW(TBL_XWWL_NPC Play_, int _NpcPlayId, int THOI_GIAN, int DI_THUONG_ID, int DI_THUONG_SO_LUONG)
		{
			this.int_0 = _NpcPlayId;
			this.FLD_PID = DI_THUONG_ID;
			this.dateTime_0 = DateTime.Now;
			this.dateTime_0 = this.dateTime_0.AddMilliseconds((double)THOI_GIAN);
			this.class153_0 = Play_;
			this.timer_0 = new Timer((double)THOI_GIAN);
			this.timer_0.Elapsed += new ElapsedEventHandler(this.timer_0_Elapsed);
			this.timer_0.Enabled = true;
			this.timer_0.AutoReset = false;
			this.method_2(this.FLD_PID, 1, DI_THUONG_SO_LUONG, THOI_GIAN / 1000);
		}

		public void Dispose()
		{
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "DI_THUONG_TRANG_THAI_LOAI-Dispose");
			}
			if (this.timer_0 != null)
			{
				this.timer_0.Enabled = false;
				this.timer_0.Close();
				this.timer_0.Dispose();
				this.timer_0 = null;
			}
			if (this.timer_1 != null)
			{
				this.timer_1.Enabled = false;
				this.timer_1.Close();
				this.timer_1.Dispose();
				this.timer_1 = null;
			}
			this.class15_0 = null;
			this.class153_0 = null;
		}

		public void method_0(double double_1)
		{
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "DI_THUONG_TRANG_THAI_LOAI-DI_THUONG_TRANG_THAI_LOAI_XUAT_HUYET");
			}
			this.double_0 = double_1;
			this.timer_1 = new Timer(1000);
			this.timer_1.Elapsed += new ElapsedEventHandler(this.timer_1_Elapsed);
			this.timer_1.Enabled = true;
			this.timer_1.AutoReset = true;
		}

		public void method_1()
		{
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "DI_THUONG_TRANG_THAI_LOAI-THOI_GIAN_KET_THUC_SU_KIEN");
			}
			try
			{
				try
				{
					if (this.timer_0 != null)
					{
						this.timer_0.Enabled = false;
						this.timer_0.Close();
						this.timer_0.Dispose();
						this.timer_0 = null;
					}
					if (this.class153_0 != null)
					{
						if (this.FLD_PID == 9)
						{
							this.class153_0.FLD_DF = this.class153_0.FLD_DF;
						}
						if (this.class153_0.threadSafeDictionary_1 != null)
						{
							this.class153_0.threadSafeDictionary_1.Remove(this.FLD_PID);
						}
						this.Dispose();
					}
					else if (this.class15_0 != null)
					{
						int fLDPID = this.FLD_PID;
						if (fLDPID <= 2)
						{
							if (fLDPID == 1)
							{
								this.class15_0.addFLD_DEF_Percentage(new decimal(7, 0, 0, false, 2));
								this.class15_0.UpdatePowersAndStatus();
							}
							else if (fLDPID == 2)
							{
								this.class15_0.addFLD_ATT_Percentage(new decimal(7, 0, 0, false, 2));
								this.class15_0.UpdatePowersAndStatus();
							}
						}
						else if (fLDPID == 6)
						{
							Players class150 = this.class15_0;
							class150.FLD_them_vao_ti_le_phan_tram_HP_han_muc_toi_da = class150.FLD_them_vao_ti_le_phan_tram_HP_han_muc_toi_da + 0.15;
							this.class15_0.UpdateHP_MP_SP();
						}
						else if (fLDPID == 9)
						{
							this.class15_0.addFLD_DEF_Percentage(new decimal(7, 0, 0, false, 2));
							this.class15_0.UpdatePowersAndStatus();
						}
						if (this.class15_0.threadSafeDictionary_4 != null)
						{
							this.class15_0.threadSafeDictionary_4.Remove(this.FLD_PID);
						}
						this.method_2(this.FLD_PID, 0, 0, 0);
						this.Dispose();
					}
				}
				catch (Exception exception1)
				{
					Exception exception = exception1;
					Form1.WriteLine(1, string.Concat(new object[] { "DI_THUONG_TRANG_THAI_LOAI THOI_GIAN_KET_THUC_SU_KIEN ERROR：[", this.FLD_PID, "]", exception }));
				}
			}
			finally
			{
				this.Dispose();
			}
		}

		public void method_2(int int_2, int int_3, int int_4, int int_5)
		{
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "DI_THUONG_TRANG_THAI_LOAI-TRANG_THAI_HIEU_QUA");
			}
			byte[] num = Converter.hexStringToByte("AA554700003527401538008C0300002C0100000900000001000000000000006016A2496016A2492600000014000000000000008C030000E80300000900000001000000000000000000000055AA");
			Buffer.BlockCopy(BitConverter.GetBytes(int_2), 0, num, 19, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(int_2), 0, num, 59, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(int_3), 0, num, 23, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(int_3), 0, num, 63, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(int_5), 0, num, 39, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(int_4), 0, num, 43, 4);
			if (this.class15_0 == null)
			{
				if (this.class153_0 != null)
				{
					Buffer.BlockCopy(BitConverter.GetBytes(this.class153_0.FLD_INDEX), 0, num, 15, 2);
					Buffer.BlockCopy(BitConverter.GetBytes(this.class153_0.FLD_INDEX), 0, num, 5, 2);
					this.class153_0.method_37(num, (int)num.Length);
				}
				return;
			}
			Buffer.BlockCopy(BitConverter.GetBytes(this.class15_0.UserSessionID), 0, num, 15, 2);
			Buffer.BlockCopy(BitConverter.GetBytes(this.class15_0.UserSessionID), 0, num, 5, 2);
			if (this.class15_0.Client != null)
			{
				this.class15_0.Client.method_8(num, (int)num.Length);
			}
			this.class15_0.SendRangeOfPackets(num, (int)num.Length);
		}

		public void timer_0_Elapsed(object sender, ElapsedEventArgs e)
		{
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "THOI_GIAN_KET_THUC_SU_KIEN1");
			}
			this.method_1();
		}

		public void timer_1_Elapsed(object sender, ElapsedEventArgs e)
		{
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "yczt_Elapsed");
			}
			if (this.class15_0 == null)
			{
				if (this.class153_0 != null)
				{
					TBL_XWWL_NPC class1530 = this.class153_0;
					class1530.Rxjh_HP = class1530.Rxjh_HP - (long)((int)this.double_0);
					if (this.class153_0.Rxjh_HP <= 0L)
					{
                                    Form1.WriteLine(1, "DestroyMonsterScript DI_THUONG_TRANG_THAI_NEW timer_1_Elapsed");
                                    this.class153_0.DestroyMonsterScript(this.int_0);
						if (this.timer_1 != null)
						{
							this.timer_1.Enabled = false;
							this.timer_1.Close();
							this.timer_1.Dispose();
							this.timer_1 = null;
						}
					}
				}
				return;
			}
			Players class150 = this.class15_0;
			class150.NHAN_VAT_HP = class150.NHAN_VAT_HP - (long)((int)this.double_0);
			if ((this.class15_0.Player_Job == 2 || this.class15_0.Player_Job == 9) && (double)(new Random()).Next(0, 120) <= this.class15_0.Kiem_khach_thang_thien_3_khi_cong_Hoa_phuong_lam_trieu && this.class15_0.NHAN_VAT_HP <= (long)0)
			{
				this.class15_0.NHAN_VAT_HP = (long)10;
				this.class15_0.Show_Char(this.class15_0.UserSessionID, 322);
			}
			if (this.class15_0.NHAN_VAT_HP <= (long)0)
			{
				this.class15_0.Dead();
				if (this.timer_1 != null)
				{
					this.timer_1.Enabled = false;
					this.timer_1.Close();
					this.timer_1.Dispose();
					this.timer_1 = null;
				}
			}
			this.class15_0.UpdateHP_MP_SP();
		}
	}
}