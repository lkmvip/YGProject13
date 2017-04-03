using ns13;
using ns9;
using RxjhServer;
using System;
using System.ComponentModel;
using System.Timers;

namespace ns3
{
	public class THEM_VAO_TRANG_THAI_NEW : IDisposable
	{
		public Players class15_0;

		public DateTime dateTime_0;

		private int int_0;

		private int int_1;

		private int int_2;

		public Timer timer_0;

		public int FLD_PID
		{
			get
			{
				return this.int_0;
			}
			set
			{
				this.int_0 = value;
			}
		}

		public int FLD_sj
		{
			get
			{
				return this.method_0();
			}
		}

		public int SO_LUONG
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

		public int SO_LUONG_LOAI_HINH
		{
			get
			{
				return this.int_2;
			}
			set
			{
				this.int_2 = value;
			}
		}

		public THEM_VAO_TRANG_THAI_NEW(Players Play_, int VAT_PHAM_ID, int THOI_GIAN, int SO_LUONG, int SO_LUONG_LOAI_HINH)
		{
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "追加状态New类-NEW");
			}
			this.FLD_PID = VAT_PHAM_ID;
			this.SO_LUONG = SO_LUONG;
			this.SO_LUONG_LOAI_HINH = SO_LUONG_LOAI_HINH;
			this.dateTime_0 = DateTime.Now;
			this.dateTime_0 = this.dateTime_0.AddMilliseconds((double)THOI_GIAN);
			this.class15_0 = Play_;
			this.timer_0 = new Timer((double)THOI_GIAN);
			this.timer_0.Elapsed += new ElapsedEventHandler(this.timer_0_Elapsed);
			this.timer_0.Enabled = true;
			this.timer_0.AutoReset = false;
		}

		public void Dispose()
		{
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "追加状态New类-Dispose");
			}
			if (this.timer_0 != null)
			{
				this.timer_0.Enabled = false;
				this.timer_0.Close();
				this.timer_0.Dispose();
				this.timer_0 = null;
			}
			this.class15_0 = null;
		}

		public int method_0()
		{
			return (int)this.dateTime_0.Subtract(DateTime.Now).TotalMilliseconds;
		}

		public void method_1()
		{
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "追加状态New类-THOI_GIAN_KET_THUC_SU_KIEN()");
			}
			if (this.timer_0 != null)
			{
				this.timer_0.Enabled = false;
				this.timer_0.Close();
				this.timer_0.Dispose();
				this.timer_0 = null;
			}
			if (this.class15_0 == null)
			{
				this.Dispose();
				return;
			}
			try
			{
				try
				{
					switch (this.FLD_PID)
					{
						case 1:
						{
							if (this.SO_LUONG_LOAI_HINH != 2)
							{
								if (this.SO_LUONG_LOAI_HINH != 1)
								{
									goto case 13;
								}
								Players class150 = this.class15_0;
								class150.FLD_nhan_vat_them_vao_cong_kich = class150.FLD_nhan_vat_them_vao_cong_kich - this.SO_LUONG;
								goto case 13;
							}
							else
							{
								Players fLDThemVaoTiLePhanTramCongKich = this.class15_0;
								fLDThemVaoTiLePhanTramCongKich.FLD_them_vao_ti_le_phan_tram_cong_kich = fLDThemVaoTiLePhanTramCongKich.FLD_them_vao_ti_le_phan_tram_cong_kich - (new decimal(1, 0, 0, false, 2) * this.SO_LUONG);
								goto case 13;
							}
						}
						case 2:
						{
							if (this.SO_LUONG_LOAI_HINH != 2)
							{
								if (this.SO_LUONG_LOAI_HINH != 1)
								{
									goto case 13;
								}
								Players fLDNhanVatThemVaoPhongNgu = this.class15_0;
								fLDNhanVatThemVaoPhongNgu.FLD_nhan_vat_them_vao_phong_ngu = fLDNhanVatThemVaoPhongNgu.FLD_nhan_vat_them_vao_phong_ngu - this.SO_LUONG;
								goto case 13;
							}
							else
							{
								Players fLDThemVaoTiLePhanTramPhongNgu = this.class15_0;
								fLDThemVaoTiLePhanTramPhongNgu.FLD_them_vao_ti_le_phan_tram_phong_ngu = fLDThemVaoTiLePhanTramPhongNgu.FLD_them_vao_ti_le_phan_tram_phong_ngu - (new decimal(1, 0, 0, false, 2) * this.SO_LUONG);
								goto case 13;
							}
						}
						case 3:
						{
							if (this.SO_LUONG_LOAI_HINH == 2)
							{
								Players fLDThemVaoTiLePhanTramHPHanMucToiDa = this.class15_0;
								fLDThemVaoTiLePhanTramHPHanMucToiDa.FLD_them_vao_ti_le_phan_tram_HP_han_muc_toi_da = fLDThemVaoTiLePhanTramHPHanMucToiDa.FLD_them_vao_ti_le_phan_tram_HP_han_muc_toi_da - 0.01 * (double)this.SO_LUONG;
							}
							else if (this.SO_LUONG_LOAI_HINH == 1)
							{
								Players nhanVatThemVaoLonNhatHP = this.class15_0;
								nhanVatThemVaoLonNhatHP.Nhan_vat_them_vao_lon_nhat_HP = nhanVatThemVaoLonNhatHP.Nhan_vat_them_vao_lon_nhat_HP - this.SO_LUONG;
							}
							if (this.class15_0.NHAN_VAT_HP <= this.class15_0.NHAN_VAT_LON_NHAT_HP)
							{
								goto case 13;
							}
							this.class15_0.NHAN_VAT_HP = this.class15_0.NHAN_VAT_LON_NHAT_HP;
							goto case 13;
						}
						case 4:
						{
							if (this.SO_LUONG_LOAI_HINH == 2)
							{
								Players fLDThemVaoTiLePhanTramMPHanMucToiDa = this.class15_0;
								fLDThemVaoTiLePhanTramMPHanMucToiDa.FLD_them_vao_ti_le_phan_tram_MP_han_muc_toi_da = fLDThemVaoTiLePhanTramMPHanMucToiDa.FLD_them_vao_ti_le_phan_tram_MP_han_muc_toi_da - 0.01 * (double)this.SO_LUONG;
							}
							else if (this.SO_LUONG_LOAI_HINH == 1)
							{
								Players nhanVatThemVaoLonNhatMP = this.class15_0;
								nhanVatThemVaoLonNhatMP.Nhan_vat_them_vao_lon_nhat_MP = nhanVatThemVaoLonNhatMP.Nhan_vat_them_vao_lon_nhat_MP - this.SO_LUONG;
							}
							if (this.class15_0.NHAN_VAT_MP <= this.class15_0.NHAN_VAT_LON_NHAT_MP)
							{
								goto case 13;
							}
							this.class15_0.NHAN_VAT_MP = this.class15_0.NHAN_VAT_LON_NHAT_MP;
							goto case 13;
						}
						case 5:
						{
							if (this.SO_LUONG_LOAI_HINH != 2)
							{
								if (this.SO_LUONG_LOAI_HINH != 1)
								{
									goto case 13;
								}
								Players fLDNhanVatThemVaoSinhMenh = this.class15_0;
								fLDNhanVatThemVaoSinhMenh.FLD_nhan_vat_them_vao_sinh_menh = fLDNhanVatThemVaoSinhMenh.FLD_nhan_vat_them_vao_sinh_menh - this.SO_LUONG;
								goto case 13;
							}
							else
							{
								Players fLDThemVaoTiLePhanTramSinhMenh = this.class15_0;
								fLDThemVaoTiLePhanTramSinhMenh.FLD_them_vao_ti_le_phan_tram_sinh_menh = fLDThemVaoTiLePhanTramSinhMenh.FLD_them_vao_ti_le_phan_tram_sinh_menh - 0.01 * (double)this.SO_LUONG;
								goto case 13;
							}
						}
						case 6:
						{
							if (this.SO_LUONG_LOAI_HINH != 2)
							{
								if (this.SO_LUONG_LOAI_HINH != 1)
								{
									goto case 13;
								}
								Players fLDNhanVatThemVaoNeTranh = this.class15_0;
								fLDNhanVatThemVaoNeTranh.FLD_nhan_vat_them_vao_ne_tranh = fLDNhanVatThemVaoNeTranh.FLD_nhan_vat_them_vao_ne_tranh - this.SO_LUONG;
								goto case 13;
							}
							else
							{
								Players fLDThemVaoTiLePhanTramNeTranh = this.class15_0;
								fLDThemVaoTiLePhanTramNeTranh.FLD_them_vao_ti_le_phan_tram_ne_tranh = fLDThemVaoTiLePhanTramNeTranh.FLD_them_vao_ti_le_phan_tram_ne_tranh - 0.01 * (double)this.SO_LUONG;
								goto case 13;
							}
						}
						case 7:
						{
							if (this.SO_LUONG_LOAI_HINH != 2)
							{
								goto case 13;
							}
							Players fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram = this.class15_0;
							fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram = fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram - 0.01 * (double)this.SO_LUONG;
							goto case 13;
						}
						case 8:
						{
							if (this.SO_LUONG_LOAI_HINH != 2)
							{
								goto case 13;
							}
							Players fLDNhanVatVoCongSucPhongNguTangCuongTiLePhanTram = this.class15_0;
							fLDNhanVatVoCongSucPhongNguTangCuongTiLePhanTram.FLD_nhan_vat_vo_cong_suc_phong_ngu_tang_cuong_ti_le_phan_tram = fLDNhanVatVoCongSucPhongNguTangCuongTiLePhanTram.FLD_nhan_vat_vo_cong_suc_phong_ngu_tang_cuong_ti_le_phan_tram - 0.01 * (double)this.SO_LUONG;
							goto case 13;
						}
						case 9:
						case 11:
						case 12:
						case 13:
						{
							if (this.class15_0.threadSafeDictionary_3 != null)
							{
								this.class15_0.threadSafeDictionary_3.Remove(this.FLD_PID);
							}
							this.class15_0.UNKNOWN_441(this.FLD_PID, 0, this.FLD_sj, this.SO_LUONG, this.SO_LUONG_LOAI_HINH);
							this.class15_0.TINH_TOAN_NHAN_VAT_TRANG_BI_SO_LIEU();
							this.class15_0.UpdatePowersAndStatus();
							this.class15_0.UpdateHP_MP_SP();
							this.class15_0.Update_Data_Boardcast();
							this.class15_0.Update_Figure_Data(this.class15_0);
							this.Dispose();
							break;
						}
						case 10:
						{
							if (this.SO_LUONG_LOAI_HINH != 2)
							{
								goto case 13;
							}
							Players fLDNhanVatThemVaoHopThanhTyLeThanhCongTiLePhanTram = this.class15_0;
							fLDNhanVatThemVaoHopThanhTyLeThanhCongTiLePhanTram.FLD_nhan_vat_them_vao_hop_thanh_ty_le_thanh_cong_ti_le_phan_tram = fLDNhanVatThemVaoHopThanhTyLeThanhCongTiLePhanTram.FLD_nhan_vat_them_vao_hop_thanh_ty_le_thanh_cong_ti_le_phan_tram - 0.01 * (double)this.SO_LUONG;
							goto case 13;
						}
						case 14:
						{
							Players fLDNhanVatThemVaoKhiCong = this.class15_0;
							fLDNhanVatThemVaoKhiCong.FLD_nhan_vat_them_vao_khi_cong = fLDNhanVatThemVaoKhiCong.FLD_nhan_vat_them_vao_khi_cong - this.SO_LUONG;
							goto case 13;
						}
						default:
						{
							goto case 13;
						}
					}
				}
				catch (Exception exception1)
				{
					Exception exception = exception1;
					Form1.WriteLine(1, string.Concat(new object[] { "追加状态New类 THOI_GIAN_KET_THUC_SU_KIEN 出错：[", this.FLD_PID, "]", exception }));
				}
			}
			finally
			{
				this.Dispose();
			}
		}

		public void timer_0_Elapsed(object sender, ElapsedEventArgs e)
		{
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "追加状态New类-THOI_GIAN_KET_THUC_SU_KIEN2");
			}
			this.method_1();
		}
	}
}