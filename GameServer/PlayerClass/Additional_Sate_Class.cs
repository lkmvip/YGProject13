using ns1;
using ns3;
using ns9;
using RxjhServer;
using System;
using System.ComponentModel;
using System.Timers;

namespace ns13
{
      //버프타이머
      public class Additional_Sate_Class: IDisposable
      {
            public Players class15_0;

            public DateTime dateTime_0;

            private int int_0;

            private int int_1;

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

            public int FLD_RESIDE1
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

            public int FLD_sj
            {
                  get
                  {
                        return this.getsj();
                  }
            }

            public Additional_Sate_Class(Players Play_, int 时间, int VAT_PHAM_ID, int FLD_RESIDE1)
            {
                  this.FLD_PID = VAT_PHAM_ID;
                  this.FLD_RESIDE1 = FLD_RESIDE1;
                  this.dateTime_0 = DateTime.Now;
                  this.dateTime_0 = this.dateTime_0.AddMilliseconds((double)时间);
                  this.class15_0 = Play_;
                  this.timer_0 = new Timer((double)时间);
                  this.timer_0.Elapsed += new ElapsedEventHandler(this.timer_0_Elapsed);
                  this.timer_0.Enabled = true;
                  this.timer_0.AutoReset = false;
            }

            public void Dispose()
            {
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "追加状态类-Dispose");
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

            ~Additional_Sate_Class()
            {
                  if (this.timer_0 != null)
                  {
                        this.timer_0.Enabled = false;
                        this.timer_0.Close();
                        this.timer_0.Dispose();
                        this.timer_0 = null;
                  }
            }

            public int getsj()
            {
                  return (int)this.dateTime_0.Subtract(DateTime.Now).TotalMilliseconds;
            }

            public void THOI_GIAN_KET_THUC_SU_KIEN()
            {
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "追加状态类-THOI_GIAN_KET_THUC_SU_KIEN()");
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
                              int fLDPID = this.FLD_PID;
                              if (fLDPID <= 900403)
                              {
                                    if (fLDPID <= 601103)
                                    {
                                          if (fLDPID > 401401)
                                          {
                                                if (fLDPID <= 501501)
                                                {
                                                      switch (fLDPID)
                                                      {
                                                            case 501301:
                                                                  {
                                                                        this.class15_0.dllFLD_ATT_Percentage(new decimal(1, 0, 0, false, 1));
                                                                        this.class15_0.UpdatePowersAndStatus();
                                                                        break;
                                                                  }
                                                            case 501302:
                                                                  {
                                                                        this.class15_0.DLL_FLD_THEM_VAO_TI_LE_PHAN_TRAM_PHONG_NGU(new decimal(5, 0, 0, false, 2));
                                                                        this.class15_0.UpdatePowersAndStatus();
                                                                        break;
                                                                  }
                                                            case 501303:
                                                                  {
                                                                        this.class15_0.DLL_FLD_THEM_VAO_TI_LE_PHAN_TRAM_PHONG_NGU(new decimal(15, 0, 0, false, 2));
                                                                        this.class15_0.UpdatePowersAndStatus();
                                                                        break;
                                                                  }
                                                            default:
                                                                  {
                                                                        switch (fLDPID)
                                                                        {
                                                                              case 501401:
                                                                                    {
                                                                                          Players class150 = this.class15_0;
                                                                                          class150.FLD_them_vao_ti_le_phan_tram_sinh_menh = class150.FLD_them_vao_ti_le_phan_tram_sinh_menh - 0.1;
                                                                                          this.class15_0.UpdatePowersAndStatus();
                                                                                          break;
                                                                                    }
                                                                              case 501402:
                                                                                    {
                                                                                          Players fLDThemVaoTiLePhanTramNeTranh = this.class15_0;
                                                                                          fLDThemVaoTiLePhanTramNeTranh.FLD_them_vao_ti_le_phan_tram_ne_tranh = fLDThemVaoTiLePhanTramNeTranh.FLD_them_vao_ti_le_phan_tram_ne_tranh - 0.1;
                                                                                          this.class15_0.UpdatePowersAndStatus();
                                                                                          break;
                                                                                    }
                                                                              case 501403:
                                                                                    {
                                                                                          Players fLDThemVaoTiLePhanTramHPHanMucToiDa = this.class15_0;
                                                                                          fLDThemVaoTiLePhanTramHPHanMucToiDa.FLD_them_vao_ti_le_phan_tram_HP_han_muc_toi_da = fLDThemVaoTiLePhanTramHPHanMucToiDa.FLD_them_vao_ti_le_phan_tram_HP_han_muc_toi_da - 0.1;
                                                                                          if (this.class15_0.NHAN_VAT_HP > this.class15_0.NHAN_VAT_LON_NHAT_HP)
                                                                                          {
                                                                                                this.class15_0.NHAN_VAT_HP = this.class15_0.NHAN_VAT_LON_NHAT_HP;
                                                                                          }
                                                                                          this.class15_0.UpdateHP_MP_SP();
                                                                                          break;
                                                                                    }
                                                                              default:
                                                                                    {
                                                                                          if (fLDPID == 501501)
                                                                                          {
                                                                                                this.class15_0.dllFLD_ATT_Percentage(new decimal(1, 0, 0, false, 1));
                                                                                                this.class15_0.UpdatePowersAndStatus();
                                                                                          }
                                                                                          break;
                                                                                    }
                                                                        }
                                                                        break;
                                                                  }
                                                      }
                                                }
                                                else if (fLDPID <= 501603)
                                                {
                                                      if (fLDPID == 501502)
                                                      {
                                                            this.class15_0.DLL_FLD_THEM_VAO_TI_LE_PHAN_TRAM_PHONG_NGU(new decimal(15, 0, 0, false, 2));
                                                            this.class15_0.UpdatePowersAndStatus();
                                                      }
                                                      else
                                                      {
                                                            switch (fLDPID)
                                                            {
                                                                  case 501601:
                                                                        {
                                                                              Players player = this.class15_0;
                                                                              player.FLD_them_vao_ti_le_phan_tram_HP_han_muc_toi_da = player.FLD_them_vao_ti_le_phan_tram_HP_han_muc_toi_da - 0.1;
                                                                              if (this.class15_0.NHAN_VAT_HP > this.class15_0.NHAN_VAT_LON_NHAT_HP)
                                                                              {
                                                                                    this.class15_0.NHAN_VAT_HP = this.class15_0.NHAN_VAT_LON_NHAT_HP;
                                                                              }
                                                                              this.class15_0.UpdateHP_MP_SP();
                                                                              break;
                                                                        }
                                                                  case 501602:
                                                                        {
                                                                              Players fLDThemVaoTiLePhanTramSinhMenh = this.class15_0;
                                                                              fLDThemVaoTiLePhanTramSinhMenh.FLD_them_vao_ti_le_phan_tram_sinh_menh = fLDThemVaoTiLePhanTramSinhMenh.FLD_them_vao_ti_le_phan_tram_sinh_menh - 0.1;
                                                                              this.class15_0.UpdatePowersAndStatus();
                                                                              break;
                                                                        }
                                                                  case 501603:
                                                                        {
                                                                              Players class1501 = this.class15_0;
                                                                              class1501.FLD_them_vao_ti_le_phan_tram_ne_tranh = class1501.FLD_them_vao_ti_le_phan_tram_ne_tranh - 0.1;
                                                                              this.class15_0.UpdatePowersAndStatus();
                                                                              break;
                                                                        }
                                                            }
                                                      }
                                                }
                                                else if (fLDPID == 501701)
                                                {
                                                      Players nhanVatThemVaoLonNhatHP = this.class15_0;
                                                      nhanVatThemVaoLonNhatHP.Nhan_vat_them_vao_lon_nhat_HP = nhanVatThemVaoLonNhatHP.Nhan_vat_them_vao_lon_nhat_HP - 1000;
                                                      this.class15_0.UpdateHP_MP_SP();
                                                }
                                                else
                                                {
                                                      switch (fLDPID)
                                                      {
                                                            case 601101:
                                                                  {
                                                                        this.class15_0.method_438(BitConverter.GetBytes(this.FLD_PID), 1);
                                                                        this.class15_0.int_10 = 1;
                                                                        break;
                                                                  }
                                                            case 601102:
                                                                  {
                                                                        this.class15_0.method_438(BitConverter.GetBytes(this.FLD_PID), 1);
                                                                        this.class15_0.int_10 = 1;
                                                                        break;
                                                                  }
                                                            case 601103:
                                                                  {
                                                                        this.class15_0.method_438(BitConverter.GetBytes(this.FLD_PID), 1);
                                                                        this.class15_0.int_10 = 1;
                                                                        break;
                                                                  }
                                                      }
                                                }
                                          }
                                          else if (fLDPID > 401202)
                                          {
                                                if (fLDPID == 401203)
                                                {
                                                      Players fLDNhanVatThemVaoSinhMenh = this.class15_0;
                                                      fLDNhanVatThemVaoSinhMenh.FLD_nhan_vat_them_vao_sinh_menh = fLDNhanVatThemVaoSinhMenh.FLD_nhan_vat_them_vao_sinh_menh + 20;
                                                      Players fLDNhanVatThemVaoNeTranh = this.class15_0;
                                                      fLDNhanVatThemVaoNeTranh.FLD_nhan_vat_them_vao_ne_tranh = fLDNhanVatThemVaoNeTranh.FLD_nhan_vat_them_vao_ne_tranh - 40;
                                                      this.class15_0.UpdatePowersAndStatus();
                                                }
                                                else
                                                {
                                                      switch (fLDPID)
                                                      {
                                                            case 401301:
                                                                  {
                                                                        Players fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram = this.class15_0;
                                                                        fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram = fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram - 0.1;
                                                                        break;
                                                                  }
                                                            case 401302:
                                                                  {
                                                                        Players fLDNhanVatVoCongSucPhongNguTangCuongTiLePhanTram = this.class15_0;
                                                                        fLDNhanVatVoCongSucPhongNguTangCuongTiLePhanTram.FLD_nhan_vat_vo_cong_suc_phong_ngu_tang_cuong_ti_le_phan_tram = fLDNhanVatVoCongSucPhongNguTangCuongTiLePhanTram.FLD_nhan_vat_vo_cong_suc_phong_ngu_tang_cuong_ti_le_phan_tram - 0.1;
                                                                        break;
                                                                  }
                                                            case 401303:
                                                                  {
                                                                        Players cungTenTriMenhNhatKichTyLe = this.class15_0;
                                                                        cungTenTriMenhNhatKichTyLe.Cung_ten_Tri_menh_nhat_kich_ty_le = cungTenTriMenhNhatKichTyLe.Cung_ten_Tri_menh_nhat_kich_ty_le - 5;
                                                                        break;
                                                                  }
                                                            default:
                                                                  {
                                                                        if (fLDPID == 401401)
                                                                        {
                                                                              Players fLDThemVaoTiLePhanTramSinhMenh1 = this.class15_0;
                                                                              fLDThemVaoTiLePhanTramSinhMenh1.FLD_them_vao_ti_le_phan_tram_sinh_menh = fLDThemVaoTiLePhanTramSinhMenh1.FLD_them_vao_ti_le_phan_tram_sinh_menh - 0.4;
                                                                              Players fLDThemVaoTiLePhanTramHPHanMucToiDa1 = this.class15_0;
                                                                              fLDThemVaoTiLePhanTramHPHanMucToiDa1.FLD_them_vao_ti_le_phan_tram_HP_han_muc_toi_da = fLDThemVaoTiLePhanTramHPHanMucToiDa1.FLD_them_vao_ti_le_phan_tram_HP_han_muc_toi_da - 0.1;
                                                                              if (this.class15_0.NHAN_VAT_HP > this.class15_0.NHAN_VAT_LON_NHAT_HP)
                                                                              {
                                                                                    this.class15_0.NHAN_VAT_HP = this.class15_0.NHAN_VAT_LON_NHAT_HP;
                                                                              }
                                                                              this.class15_0.UpdateHP_MP_SP();
                                                                              break;
                                                                        }
                                                                        else
                                                                        {
                                                                              break;
                                                                        }
                                                                  }
                                                      }
                                                }
                                          }
                                          else if (fLDPID == 201201)
                                          {
                                                this.class15_0.dllFLD_ATT_Percentage(new decimal(2, 0, 0, false, 1));
                                                Players player1 = this.class15_0;
                                                player1.FLD_them_vao_ti_le_phan_tram_HP_han_muc_toi_da = player1.FLD_them_vao_ti_le_phan_tram_HP_han_muc_toi_da - 0.05;
                                                if (this.class15_0.NHAN_VAT_HP > this.class15_0.NHAN_VAT_LON_NHAT_HP)
                                                {
                                                      this.class15_0.NHAN_VAT_HP = this.class15_0.NHAN_VAT_LON_NHAT_HP;
                                                }
                                                this.class15_0.UpdatePowersAndStatus();
                                          }
                                          else if (fLDPID == 301201)
                                          {
                                                this.class15_0.dllFLD_ATT_Percentage(new decimal(1, 0, 0, false, 1));
                                                Players class1502 = this.class15_0;
                                                class1502.FLD_them_vao_ti_le_phan_tram_HP_han_muc_toi_da = class1502.FLD_them_vao_ti_le_phan_tram_HP_han_muc_toi_da - 0.05;
                                                if (this.class15_0.NHAN_VAT_HP > this.class15_0.NHAN_VAT_LON_NHAT_HP)
                                                {
                                                      this.class15_0.NHAN_VAT_HP = this.class15_0.NHAN_VAT_LON_NHAT_HP;
                                                }
                                                this.class15_0.UpdateHP_MP_SP();
                                                this.class15_0.UpdatePowersAndStatus();
                                          }
                                          else if (fLDPID == 401202)
                                          {
                                                Players fLDNhanVatThemVaoSinhMenh1 = this.class15_0;
                                                fLDNhanVatThemVaoSinhMenh1.FLD_nhan_vat_them_vao_sinh_menh = fLDNhanVatThemVaoSinhMenh1.FLD_nhan_vat_them_vao_sinh_menh - 40;
                                                Players fLDNhanVatThemVaoNeTranh1 = this.class15_0;
                                                fLDNhanVatThemVaoNeTranh1.FLD_nhan_vat_them_vao_ne_tranh = fLDNhanVatThemVaoNeTranh1.FLD_nhan_vat_them_vao_ne_tranh + 20;
                                                this.class15_0.UpdatePowersAndStatus();
                                          }
                                    }
                                    else if (fLDPID > 700310)
                                    {
                                          if (fLDPID <= 700603)
                                          {
                                                if (fLDPID == 700350)
                                                {
                                                      this.class15_0.DLL_FLD_THEM_VAO_TI_LE_PHAN_TRAM_PHONG_NGU(new decimal(2, 0, 0, false, 1));
                                                      this.class15_0.UpdatePowersAndStatus();
                                                }
                                                else
                                                {
                                                      switch (fLDPID)
                                                      {
                                                            case 700401:
                                                                  {
                                                                        this.class15_0.DI_CHUYEN_TRANG_THAI_NHAN_VAT_LINH_THU(BitConverter.GetBytes(this.FLD_PID), 1);
                                                                        this.class15_0.TRANG_THAI_HIEU_QUA_NHAN_VAT_LINH_THU(BitConverter.GetBytes(this.FLD_PID), 0, 0);
                                                                        break;
                                                                  }
                                                            case 700402:
                                                                  {
                                                                        this.class15_0.DI_CHUYEN_TRANG_THAI_NHAN_VAT_LINH_THU(BitConverter.GetBytes(this.FLD_PID), 1);
                                                                        this.class15_0.TRANG_THAI_HIEU_QUA_NHAN_VAT_LINH_THU(BitConverter.GetBytes(this.FLD_PID), 0, 0);
                                                                        break;
                                                                  }
                                                            case 700403:
                                                                  {
                                                                        this.class15_0.DI_CHUYEN_TRANG_THAI_NHAN_VAT_LINH_THU(BitConverter.GetBytes(this.FLD_PID), 1);
                                                                        this.class15_0.TRANG_THAI_HIEU_QUA_NHAN_VAT_LINH_THU(BitConverter.GetBytes(this.FLD_PID), 0, 0);
                                                                        break;
                                                                  }
                                                            default:
                                                                  {
                                                                        if (fLDPID == 700603)
                                                                        {
                                                                              Players fLDNhanVatThemVaoCongKich = this.class15_0;
                                                                              fLDNhanVatThemVaoCongKich.FLD_nhan_vat_them_vao_cong_kich = fLDNhanVatThemVaoCongKich.FLD_nhan_vat_them_vao_cong_kich - 100;
                                                                              Players fLDNhanVatThemVaoPhongNgu = this.class15_0;
                                                                              fLDNhanVatThemVaoPhongNgu.FLD_nhan_vat_them_vao_phong_ngu = fLDNhanVatThemVaoPhongNgu.FLD_nhan_vat_them_vao_phong_ngu - 100;
                                                                              Players nhanVatThemVaoLonNhatHP1 = this.class15_0;
                                                                              nhanVatThemVaoLonNhatHP1.Nhan_vat_them_vao_lon_nhat_HP = nhanVatThemVaoLonNhatHP1.Nhan_vat_them_vao_lon_nhat_HP - 1000;
                                                                              Players nhanVatThemVaoLonNhatMP = this.class15_0;
                                                                              nhanVatThemVaoLonNhatMP.Nhan_vat_them_vao_lon_nhat_MP = nhanVatThemVaoLonNhatMP.Nhan_vat_them_vao_lon_nhat_MP - 1000;
                                                                              this.class15_0.UpdateHP_MP_SP();
                                                                              this.class15_0.UpdatePowersAndStatus();
                                                                              break;
                                                                        }
                                                                        else
                                                                        {
                                                                              break;
                                                                        }
                                                                  }
                                                      }
                                                }
                                          }
                                          else if (fLDPID == 801201)
                                          {
                                                this.class15_0.FLD_cong_kich_toc_do = 100;
                                                this.class15_0.UpdatePowersAndStatus();
                                                this.class15_0.Update_Attack_Speed();
                                          }
                                          else if (fLDPID == 801302)
                                          {
                                                this.class15_0.addFLD_DEF_Percentage(new decimal(2, 0, 0, false, 1));
                                                Players fLDThemVaoTiLePhanTramNeTranh1 = this.class15_0;
                                                fLDThemVaoTiLePhanTramNeTranh1.FLD_them_vao_ti_le_phan_tram_ne_tranh = fLDThemVaoTiLePhanTramNeTranh1.FLD_them_vao_ti_le_phan_tram_ne_tranh - 1;
                                                this.class15_0.UpdatePowersAndStatus();
                                                this.class15_0.Update_Attack_Speed();
                                          }
                                          else
                                          {
                                                switch (fLDPID)
                                                {
                                                      case 900401:
                                                            {
                                                                  if (this.class15_0.Add_Status_List != null)
                                                                  {
                                                                        this.class15_0.Add_Status_List.imethod_1(this.FLD_PID);
                                                                  }
                                                                  this.class15_0.UpdatePowersAndStatus();
                                                                  this.class15_0.Update_Figure_Data(this.class15_0);
                                                                  this.class15_0.Update_Data_Boardcast();
                                                                  break;
                                                            }
                                                      case 900402:
                                                            {
                                                                  if (this.class15_0.Add_Status_List != null)
                                                                  {
                                                                        this.class15_0.Add_Status_List.imethod_1(this.FLD_PID);
                                                                  }
                                                                  this.class15_0.UpdatePowersAndStatus();
                                                                  this.class15_0.Update_Figure_Data(this.class15_0);
                                                                  this.class15_0.Update_Data_Boardcast();
                                                                  break;
                                                            }
                                                      case 900403:
                                                            {
                                                                  if (this.class15_0.Add_Status_List != null)
                                                                  {
                                                                        this.class15_0.Add_Status_List.imethod_1(this.FLD_PID);
                                                                  }
                                                                  this.class15_0.UpdatePowersAndStatus();
                                                                  this.class15_0.Update_Figure_Data(this.class15_0);
                                                                  this.class15_0.Update_Data_Boardcast();
                                                                  break;
                                                            }
                                                }
                                          }
                                    }
                                    else if (fLDPID <= 700014)
                                    {
                                          if (fLDPID == 601201)
                                          {
                                                this.class15_0.dllFLD_TRANG_BI_THEM_VAO_PHONG_NGU_CUONG_HOA(1);
                                                this.class15_0.TINH_TOAN_NHAN_VAT_TRANG_BI_SO_LIEU();
                                                this.class15_0.UpdatePowersAndStatus();
                                          }
                                          else if (fLDPID == 601202)
                                          {
                                                this.class15_0.DLL_FLD_trang_bi_them_vao_vu_khi_cuong_hoa(1);
                                                this.class15_0.TINH_TOAN_NHAN_VAT_TRANG_BI_SO_LIEU();
                                                this.class15_0.UpdatePowersAndStatus();
                                          }
                                          else if (fLDPID == 700014)
                                          {
                                                if (this.class15_0.Player_Job != 3)
                                                {
                                                      this.class15_0.dllFLD_ATT_Percentage(new decimal(25, 0, 0, false, 2));
                                                      this.class15_0.DLL_FLD_THEM_VAO_TI_LE_PHAN_TRAM_PHONG_NGU(new decimal(25, 0, 0, false, 2));
                                                }
                                                else
                                                {
                                                      this.class15_0.dllFLD_ATT_Percentage(new decimal(29, 0, 0, false, 2));
                                                      this.class15_0.DLL_FLD_THEM_VAO_TI_LE_PHAN_TRAM_PHONG_NGU(new decimal(29, 0, 0, false, 2));
                                                }
                                                if (this.class15_0.Add_Status_List != null)
                                                {
                                                      this.class15_0.Add_Status_List.imethod_1(this.FLD_PID);
                                                }
                                                this.class15_0.UpdatePowersAndStatus();
                                                this.class15_0.Update_Figure_Data(this.class15_0);
                                                this.class15_0.Update_Data_Boardcast();
                                          }
                                    }
                                    else if (fLDPID == 700047)
                                    {
                                          this.class15_0.UpdatePowersAndStatus();
                                    }
                                    else if (fLDPID == 700200)
                                    {
                                          this.class15_0.dllFLD_ATT_Percentage(new decimal(2, 0, 0, false, 1));
                                          this.class15_0.DLL_FLD_THEM_VAO_TI_LE_PHAN_TRAM_PHONG_NGU(new decimal(2, 0, 0, false, 1));
                                          this.class15_0.UpdatePowersAndStatus();
                                    }
                                    else if (fLDPID == 700310)
                                    {
                                          Players fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram1 = this.class15_0;
                                          fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram1.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram = fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram1.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram - 0.3;
                                          this.class15_0.DLL_FLD_THEM_VAO_TI_LE_PHAN_TRAM_PHONG_NGU(new decimal(1, 0, 0, false, 1));
                                          this.class15_0.UpdatePowersAndStatus();
                                    }
                              }
                              else if (fLDPID <= 1000000961)
                              {
                                    if (fLDPID <= 1000000720)
                                    {
                                          if (fLDPID > 1001102)
                                          {
                                                if (fLDPID > 2001301)
                                                {
                                                      switch (fLDPID)
                                                      {
                                                            case 8000002:
                                                                  {
                                                                        //운기조식
                                                                        if (this.class15_0.NHAN_VAT_HP < this.class15_0.NHAN_VAT_LON_NHAT_HP)
                                                                        {
                                                                              Form1.WriteLine(1, string.Format("운기조식 HP"));
                                                                        }
                                                                        if (this.class15_0.NHAN_VAT_MP < this.class15_0.NHAN_VAT_LON_NHAT_MP)
                                                                        {
                                                                              Form1.WriteLine(1, string.Format("운기조식 MP"));
                                                                        }
                                                                        break;
                                                                  }
                                                            case 1000000408:
                                                                  {
                                                                        this.class15_0.dllFLD_ATT_Percentage(new decimal(1, 0, 0, false, 1));
                                                                        break;
                                                                  }
                                                            case 1000000409:
                                                                  {
                                                                        Players nhanVatThemVaoLonNhatHP2 = this.class15_0;
                                                                        nhanVatThemVaoLonNhatHP2.Nhan_vat_them_vao_lon_nhat_HP = nhanVatThemVaoLonNhatHP2.Nhan_vat_them_vao_lon_nhat_HP - 500;
                                                                        if (this.class15_0.NHAN_VAT_HP <= this.class15_0.NHAN_VAT_LON_NHAT_HP)
                                                                        {
                                                                              break;
                                                                        }
                                                                        this.class15_0.NHAN_VAT_HP = this.class15_0.NHAN_VAT_LON_NHAT_HP;
                                                                        break;
                                                                  }
                                                            case 1000000410:
                                                                  {
                                                                        Players nhanVatThemVaoLonNhatMP1 = this.class15_0;
                                                                        nhanVatThemVaoLonNhatMP1.Nhan_vat_them_vao_lon_nhat_MP = nhanVatThemVaoLonNhatMP1.Nhan_vat_them_vao_lon_nhat_MP - 500;
                                                                        if (this.class15_0.NHAN_VAT_MP <= this.class15_0.NHAN_VAT_LON_NHAT_MP)
                                                                        {
                                                                              break;
                                                                        }
                                                                        this.class15_0.NHAN_VAT_MP = this.class15_0.NHAN_VAT_LON_NHAT_MP;
                                                                        break;
                                                                  }
                                                            case 1000000411:
                                                                  {
                                                                        this.class15_0.DLL_FLD_THEM_VAO_TI_LE_PHAN_TRAM_PHONG_NGU(new decimal(1, 0, 0, false, 1));
                                                                        break;
                                                                  }
                                                            case 1000000412:
                                                                  {
                                                                        this.class15_0.dllFLD_ATT_Percentage(new decimal(5, 0, 0, false, 2));
                                                                        break;
                                                                  }
                                                            case 1000000413:
                                                                  {
                                                                        this.class15_0.DLL_FLD_THEM_VAO_TI_LE_PHAN_TRAM_PHONG_NGU(new decimal(5, 0, 0, false, 2));
                                                                        break;
                                                                  }
                                                            case 1000000414:
                                                                  {
                                                                        Players fLDThemVaoTiLePhanTramNeTranh2 = this.class15_0;
                                                                        fLDThemVaoTiLePhanTramNeTranh2.FLD_them_vao_ti_le_phan_tram_ne_tranh = fLDThemVaoTiLePhanTramNeTranh2.FLD_them_vao_ti_le_phan_tram_ne_tranh - 0.05;
                                                                        break;
                                                                  }
                                                            default:
                                                                  {
                                                                        switch (fLDPID)
                                                                        {
                                                                              case 1000000717:
                                                                                    {
                                                                                          Players fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram2 = this.class15_0;
                                                                                          fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram2.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram = fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram2.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram - 0.1;
                                                                                          this.class15_0.UpdatePowersAndStatus();
                                                                                          break;
                                                                                    }
                                                                              case 1000000718:
                                                                                    {
                                                                                          Players player2 = this.class15_0;
                                                                                          player2.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram = player2.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram - 0.12;
                                                                                          this.class15_0.UpdatePowersAndStatus();
                                                                                          break;
                                                                                    }
                                                                              case 1000000719:
                                                                                    {
                                                                                          Players class1503 = this.class15_0;
                                                                                          class1503.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram = class1503.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram - 0.14;
                                                                                          this.class15_0.UpdatePowersAndStatus();
                                                                                          break;
                                                                                    }
                                                                              case 1000000720:
                                                                                    {
                                                                                          Players fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram3 = this.class15_0;
                                                                                          fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram3.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram = fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram3.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram - 0.16;
                                                                                          this.class15_0.UpdatePowersAndStatus();
                                                                                          break;
                                                                                    }
                                                                        }
                                                                        break;
                                                                  }
                                                      }
                                                }
                                                else
                                                {
                                                      switch (fLDPID)
                                                      {
                                                            case 1001301:
                                                                  {
                                                                        Players player3 = this.class15_0;
                                                                        player3.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram = player3.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram - 0.05;
                                                                        this.class15_0.UpdatePowersAndStatus();
                                                                        break;
                                                                  }
                                                            case 1001302:
                                                                  {
                                                                        Players class1504 = this.class15_0;
                                                                        class1504.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram = class1504.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram - 0.1;
                                                                        this.class15_0.UpdatePowersAndStatus();
                                                                        break;
                                                                  }
                                                            case 1001303:
                                                                  {
                                                                        Players fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram4 = this.class15_0;
                                                                        fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram4.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram = fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram4.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram - 0.15;
                                                                        this.class15_0.UpdatePowersAndStatus();
                                                                        break;
                                                                  }
                                                            default:
                                                                  {
                                                                        if (fLDPID == 2001301)
                                                                        {
                                                                              this.class15_0.dllFLD_ATT_Percentage(new decimal(3, 0, 0, false, 2));
                                                                              Players fLDThemVaoTiLePhanTramHPHanMucToiDa2 = this.class15_0;
                                                                              fLDThemVaoTiLePhanTramHPHanMucToiDa2.FLD_them_vao_ti_le_phan_tram_HP_han_muc_toi_da = fLDThemVaoTiLePhanTramHPHanMucToiDa2.FLD_them_vao_ti_le_phan_tram_HP_han_muc_toi_da - 0.05;
                                                                              if (this.class15_0.NHAN_VAT_HP > this.class15_0.NHAN_VAT_LON_NHAT_HP)
                                                                              {
                                                                                    this.class15_0.NHAN_VAT_HP = this.class15_0.NHAN_VAT_LON_NHAT_HP;
                                                                              }
                                                                              this.class15_0.UpdatePowersAndStatus();
                                                                              break;
                                                                        }
                                                                        else
                                                                        {
                                                                              break;
                                                                        }
                                                                  }
                                                      }
                                                }
                                          }
                                          else if (fLDPID == 901501)
                                          {
                                                this.class15_0.DLL_FLD_THEM_VAO_TI_LE_PHAN_TRAM_PHONG_NGU(new decimal(1, 0, 0, false, 1));
                                                this.class15_0.UpdatePowersAndStatus();
                                          }
                                          else if (fLDPID == 1001101)
                                          {
                                                this.class15_0.method_438(BitConverter.GetBytes(this.FLD_PID), 1);
                                                this.class15_0.int_10 = 1;
                                          }
                                          else if (fLDPID == 1001102)
                                          {
                                                this.class15_0.method_438(BitConverter.GetBytes(this.FLD_PID), 1);
                                                this.class15_0.int_10 = 1;
                                          }
                                    }
                                    else if (fLDPID <= 1000000815)
                                    {
                                          if (fLDPID == 1000000775)
                                          {
                                                Players fLDNhanVatThemVaoPhongNgu1 = this.class15_0;
                                                fLDNhanVatThemVaoPhongNgu1.FLD_nhan_vat_them_vao_phong_ngu = fLDNhanVatThemVaoPhongNgu1.FLD_nhan_vat_them_vao_phong_ngu - 20;
                                                this.class15_0.UpdatePowersAndStatus();
                                          }
                                          else if (fLDPID == 1000000776)
                                          {
                                                Players player4 = this.class15_0;
                                                player4.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram = player4.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram - 0.05;
                                                Players fLDNhanVatVoCongSucPhongNguTangCuongTiLePhanTram1 = this.class15_0;
                                                fLDNhanVatVoCongSucPhongNguTangCuongTiLePhanTram1.FLD_nhan_vat_vo_cong_suc_phong_ngu_tang_cuong_ti_le_phan_tram = fLDNhanVatVoCongSucPhongNguTangCuongTiLePhanTram1.FLD_nhan_vat_vo_cong_suc_phong_ngu_tang_cuong_ti_le_phan_tram - 0.1;
                                                this.class15_0.UpdatePowersAndStatus();
                                          }
                                          else if (fLDPID == 1000000815)
                                          {
                                                Players fLDNhanVatThemVaoCongKich1 = this.class15_0;
                                                fLDNhanVatThemVaoCongKich1.FLD_nhan_vat_them_vao_cong_kich = fLDNhanVatThemVaoCongKich1.FLD_nhan_vat_them_vao_cong_kich - int.Parse(World.Tang_cuong_cong_kich_duoc_pham[1]);
                                                this.class15_0.UpdatePowersAndStatus();
                                          }
                                    }
                                    else if (fLDPID > 1000000830)
                                    {
                                          switch (fLDPID)
                                          {
                                                case 1000000891:
                                                case 1000000892:
                                                case 1000000893:
                                                      {
                                                            Players nhanVatThemVaoLonNhatHP3 = this.class15_0;
                                                            nhanVatThemVaoLonNhatHP3.Nhan_vat_them_vao_lon_nhat_HP = nhanVatThemVaoLonNhatHP3.Nhan_vat_them_vao_lon_nhat_HP - 150;
                                                            if (this.class15_0.NHAN_VAT_HP > this.class15_0.NHAN_VAT_LON_NHAT_HP)
                                                            {
                                                                  this.class15_0.NHAN_VAT_HP = this.class15_0.NHAN_VAT_LON_NHAT_HP;
                                                            }
                                                            Players fLDNhanVatThemVaoCongKich2 = this.class15_0;
                                                            fLDNhanVatThemVaoCongKich2.FLD_nhan_vat_them_vao_cong_kich = fLDNhanVatThemVaoCongKich2.FLD_nhan_vat_them_vao_cong_kich - 15;
                                                            Players fLDNhanVatThemVaoPhongNgu2 = this.class15_0;
                                                            fLDNhanVatThemVaoPhongNgu2.FLD_nhan_vat_them_vao_phong_ngu = fLDNhanVatThemVaoPhongNgu2.FLD_nhan_vat_them_vao_phong_ngu - 15;
                                                            Players fLDNhanVatThemVaoKhiCong = this.class15_0;
                                                            fLDNhanVatThemVaoKhiCong.FLD_nhan_vat_them_vao_khi_cong = fLDNhanVatThemVaoKhiCong.FLD_nhan_vat_them_vao_khi_cong - 1;
                                                            Players fLDNhanVatThemVaoKinhNghiemTiLePhanTram = this.class15_0;
                                                            fLDNhanVatThemVaoKinhNghiemTiLePhanTram.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = fLDNhanVatThemVaoKinhNghiemTiLePhanTram.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram - 0.05;
                                                            if (this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram < 0)
                                                            {
                                                                  this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = 0;
                                                            }
                                                            this.class15_0.UpdatePowersAndStatus();
                                                            break;
                                                      }
                                                default:
                                                      {
                                                            switch (fLDPID)
                                                            {
                                                                  case 1000000959:
                                                                        {
                                                                              Players class1505 = this.class15_0;
                                                                              class1505.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram = class1505.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram - 0.19;
                                                                              this.class15_0.UpdatePowersAndStatus();
                                                                              break;
                                                                        }
                                                                  case 1000000960:
                                                                        {
                                                                              Players fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram5 = this.class15_0;
                                                                              fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram5.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram = fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram5.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram - 0.22;
                                                                              this.class15_0.UpdatePowersAndStatus();
                                                                              break;
                                                                        }
                                                                  case 1000000961:
                                                                        {
                                                                              Players player5 = this.class15_0;
                                                                              player5.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram = player5.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram - 0.25;
                                                                              this.class15_0.UpdatePowersAndStatus();
                                                                              break;
                                                                        }
                                                            }
                                                            break;
                                                      }
                                          }
                                    }
                                    else if (fLDPID == 1000000816)
                                    {
                                          Players fLDNhanVatThemVaoPhongNgu3 = this.class15_0;
                                          fLDNhanVatThemVaoPhongNgu3.FLD_nhan_vat_them_vao_phong_ngu = fLDNhanVatThemVaoPhongNgu3.FLD_nhan_vat_them_vao_phong_ngu - int.Parse(World.Tang_cuong_phong_ngu_duoc_pham[1]);
                                          this.class15_0.UpdatePowersAndStatus();
                                    }
                                    else if (fLDPID == 1000000830)
                                    {
                                          Players nhanVatThemVaoLonNhatHP4 = this.class15_0;
                                          nhanVatThemVaoLonNhatHP4.Nhan_vat_them_vao_lon_nhat_HP = nhanVatThemVaoLonNhatHP4.Nhan_vat_them_vao_lon_nhat_HP - int.Parse(World.Tang_cuong_sinh_menh_duoc_pham[1]);
                                          if (this.class15_0.NHAN_VAT_HP > this.class15_0.NHAN_VAT_LON_NHAT_HP)
                                          {
                                                this.class15_0.NHAN_VAT_HP = this.class15_0.NHAN_VAT_LON_NHAT_HP;
                                          }
                                          this.class15_0.UpdateHP_MP_SP();
                                          this.class15_0.UpdatePowersAndStatus();
                                    }
                              }
                              else if (fLDPID <= 1008000188)
                              {
                                    if (fLDPID <= 1008000053)
                                    {
                                          switch (fLDPID)
                                          {
                                                case 1007000005:
                                                      {
                                                            Players nhanVatThemVaoLonNhatHP5 = this.class15_0;
                                                            nhanVatThemVaoLonNhatHP5.Nhan_vat_them_vao_lon_nhat_HP = nhanVatThemVaoLonNhatHP5.Nhan_vat_them_vao_lon_nhat_HP - 300;
                                                            if (this.class15_0.NHAN_VAT_HP > this.class15_0.NHAN_VAT_LON_NHAT_HP)
                                                            {
                                                                  this.class15_0.NHAN_VAT_HP = this.class15_0.NHAN_VAT_LON_NHAT_HP;
                                                            }
                                                            this.class15_0.UpdateHP_MP_SP();
                                                            break;
                                                      }
                                                case 1007000006:
                                                      {
                                                            Players class1506 = this.class15_0;
                                                            class1506.Nhan_vat_them_vao_lon_nhat_HP = class1506.Nhan_vat_them_vao_lon_nhat_HP - 500;
                                                            if (this.class15_0.NHAN_VAT_HP > this.class15_0.NHAN_VAT_LON_NHAT_HP)
                                                            {
                                                                  this.class15_0.NHAN_VAT_HP = this.class15_0.NHAN_VAT_LON_NHAT_HP;
                                                            }
                                                            this.class15_0.UpdateHP_MP_SP();
                                                            break;
                                                      }
                                                case 1007000007:
                                                      {
                                                            Players nhanVatThemVaoLonNhatHP6 = this.class15_0;
                                                            nhanVatThemVaoLonNhatHP6.Nhan_vat_them_vao_lon_nhat_HP = nhanVatThemVaoLonNhatHP6.Nhan_vat_them_vao_lon_nhat_HP - 700;
                                                            if (this.class15_0.NHAN_VAT_HP > this.class15_0.NHAN_VAT_LON_NHAT_HP)
                                                            {
                                                                  this.class15_0.NHAN_VAT_HP = this.class15_0.NHAN_VAT_LON_NHAT_HP;
                                                            }
                                                            this.class15_0.UpdateHP_MP_SP();
                                                            break;
                                                      }
                                                default:
                                                      {
                                                            switch (fLDPID)
                                                            {
                                                                  case 1008000016:
                                                                        {
                                                                              this.class15_0.dllFLD_ATT_Percentage(new decimal(1, 0, 0, false, 1));
                                                                              this.class15_0.UpdatePowersAndStatus();
                                                                              break;
                                                                        }
                                                                  case 1008000017:
                                                                        {
                                                                              this.class15_0.DLL_FLD_THEM_VAO_TI_LE_PHAN_TRAM_PHONG_NGU(new decimal(1, 0, 0, false, 1));
                                                                              this.class15_0.UpdatePowersAndStatus();
                                                                              break;
                                                                        }
                                                                  case 1008000018:
                                                                        {
                                                                              this.class15_0.DLL_FLD_trang_bi_them_vao_vu_khi_cuong_hoa(2);
                                                                              this.class15_0.TINH_TOAN_NHAN_VAT_TRANG_BI_SO_LIEU();
                                                                              this.class15_0.UpdatePowersAndStatus();
                                                                              break;
                                                                        }
                                                                  case 1008000019:
                                                                        {
                                                                              this.class15_0.dllFLD_TRANG_BI_THEM_VAO_PHONG_NGU_CUONG_HOA(1);
                                                                              this.class15_0.TINH_TOAN_NHAN_VAT_TRANG_BI_SO_LIEU();
                                                                              this.class15_0.UpdatePowersAndStatus();
                                                                              break;
                                                                        }
                                                                  default:
                                                                        {
                                                                              if (fLDPID == 1008000053)
                                                                              {
                                                                                    Players fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram6 = this.class15_0;
                                                                                    fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram6.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram = fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram6.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram - 0.05;
                                                                                    this.class15_0.UpdatePowersAndStatus();
                                                                              }
                                                                              break;
                                                                        }
                                                            }
                                                            break;
                                                      }
                                          }
                                    }
                                    else if (fLDPID > 1008000156)
                                    {
                                          if (fLDPID == 1008000160)
                                          {
                                                this.class15_0.UpdatePowersAndStatus();
                                                this.class15_0.int_16 = 0;
                                          }
                                          else
                                          {
                                                switch (fLDPID)
                                                {
                                                      case 1008000183:
                                                            {
                                                                  Players player6 = this.class15_0;
                                                                  player6.Nhan_vat_them_vao_lon_nhat_HP = player6.Nhan_vat_them_vao_lon_nhat_HP - 300;
                                                                  if (this.class15_0.NHAN_VAT_HP > this.class15_0.NHAN_VAT_LON_NHAT_HP)
                                                                  {
                                                                        this.class15_0.NHAN_VAT_HP = this.class15_0.NHAN_VAT_LON_NHAT_HP;
                                                                  }
                                                                  this.class15_0.DLL_FLD_THEM_VAO_TI_LE_PHAN_TRAM_PHONG_NGU(new decimal(5, 0, 0, false, 2));
                                                                  if (this.class15_0.Add_Status_List != null)
                                                                  {
                                                                        this.class15_0.Add_Status_List.imethod_1(this.FLD_PID);
                                                                  }
                                                                  this.class15_0.Update_Data_Boardcast();
                                                                  this.class15_0.Update_Figure_Data(this.class15_0);
                                                                  this.class15_0.UpdateHP_MP_SP();
                                                                  this.class15_0.UpdatePowersAndStatus();
                                                                  break;
                                                            }
                                                      case 1008000185:
                                                            {
                                                                  Players class1507 = this.class15_0;
                                                                  class1507.Nhan_vat_them_vao_lon_nhat_HP = class1507.Nhan_vat_them_vao_lon_nhat_HP - 700;
                                                                  if (this.class15_0.NHAN_VAT_HP > this.class15_0.NHAN_VAT_LON_NHAT_HP)
                                                                  {
                                                                        this.class15_0.NHAN_VAT_HP = this.class15_0.NHAN_VAT_LON_NHAT_HP;
                                                                  }
                                                                  Players fLDNhanVatThemVaoKinhNghiemTiLePhanTram1 = this.class15_0;
                                                                  fLDNhanVatThemVaoKinhNghiemTiLePhanTram1.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = fLDNhanVatThemVaoKinhNghiemTiLePhanTram1.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram - 0.4;
                                                                  if (this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram < 0)
                                                                  {
                                                                        this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = 0;
                                                                  }
                                                                  Players fLDNhanVatThemVaoKinhNghiemHocVoCongTiLePhanTram = this.class15_0;
                                                                  fLDNhanVatThemVaoKinhNghiemHocVoCongTiLePhanTram.FLD_nhan_vat_them_vao_kinh_nghiem_hoc_vo_cong_ti_le_phan_tram = fLDNhanVatThemVaoKinhNghiemHocVoCongTiLePhanTram.FLD_nhan_vat_them_vao_kinh_nghiem_hoc_vo_cong_ti_le_phan_tram - 2;
                                                                  this.class15_0.DLL_FLD_THEM_VAO_TI_LE_PHAN_TRAM_PHONG_NGU(new decimal(1, 0, 0, false, 1));
                                                                  this.class15_0.dllFLD_TRANG_BI_THEM_VAO_PHONG_NGU_CUONG_HOA(1);
                                                                  this.class15_0.DLL_FLD_trang_bi_them_vao_vu_khi_cuong_hoa(2);
                                                                  this.class15_0.UpdateHP_MP_SP();
                                                                  this.class15_0.UpdatePowersAndStatus();
                                                                  this.class15_0.TINH_TOAN_NHAN_VAT_TRANG_BI_SO_LIEU();
                                                                  break;
                                                            }
                                                      case 1008000187:
                                                            {
                                                                  Players nhanVatThemVaoLonNhatHP7 = this.class15_0;
                                                                  nhanVatThemVaoLonNhatHP7.Nhan_vat_them_vao_lon_nhat_HP = nhanVatThemVaoLonNhatHP7.Nhan_vat_them_vao_lon_nhat_HP - 300;
                                                                  if (this.class15_0.NHAN_VAT_HP > this.class15_0.NHAN_VAT_LON_NHAT_HP)
                                                                  {
                                                                        this.class15_0.NHAN_VAT_HP = this.class15_0.NHAN_VAT_LON_NHAT_HP;
                                                                  }
                                                                  Players fLDNhanVatThemVaoKhiCong1 = this.class15_0;
                                                                  fLDNhanVatThemVaoKhiCong1.FLD_nhan_vat_them_vao_khi_cong = fLDNhanVatThemVaoKhiCong1.FLD_nhan_vat_them_vao_khi_cong - 1;
                                                                  if (this.class15_0.Add_Status_List != null)
                                                                  {
                                                                        this.class15_0.Add_Status_List.imethod_1(this.FLD_PID);
                                                                  }
                                                                  this.class15_0.Update_Data_Boardcast();
                                                                  this.class15_0.Update_Figure_Data(this.class15_0);
                                                                  this.class15_0.UpdateHP_MP_SP();
                                                                  this.class15_0.UpdatePowersAndStatus();
                                                                  break;
                                                            }
                                                      case 1008000188:
                                                            {
                                                                  this.class15_0.dllFLD_ATT_Percentage(new decimal(15, 0, 0, false, 2));
                                                                  this.class15_0.DLL_FLD_THEM_VAO_TI_LE_PHAN_TRAM_PHONG_NGU(new decimal(15, 0, 0, false, 2));
                                                                  Players player7 = this.class15_0;
                                                                  player7.Nhan_vat_them_vao_lon_nhat_HP = player7.Nhan_vat_them_vao_lon_nhat_HP - 300;
                                                                  if (this.class15_0.NHAN_VAT_HP > this.class15_0.NHAN_VAT_LON_NHAT_HP)
                                                                  {
                                                                        this.class15_0.NHAN_VAT_HP = this.class15_0.NHAN_VAT_LON_NHAT_HP;
                                                                  }
                                                                  Players nhanVatThemVaoLonNhatMP2 = this.class15_0;
                                                                  nhanVatThemVaoLonNhatMP2.Nhan_vat_them_vao_lon_nhat_MP = nhanVatThemVaoLonNhatMP2.Nhan_vat_them_vao_lon_nhat_MP - 300;
                                                                  if (this.class15_0.NHAN_VAT_MP > this.class15_0.NHAN_VAT_LON_NHAT_MP)
                                                                  {
                                                                        this.class15_0.NHAN_VAT_MP = this.class15_0.NHAN_VAT_LON_NHAT_MP;
                                                                  }
                                                                  Players fLDNhanVatThemVaoKinhNghiemTiLePhanTram2 = this.class15_0;
                                                                  fLDNhanVatThemVaoKinhNghiemTiLePhanTram2.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = fLDNhanVatThemVaoKinhNghiemTiLePhanTram2.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram - 0.1;
                                                                  if (this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram < 0)
                                                                  {
                                                                        this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = 0;
                                                                  }
                                                                  if (this.class15_0.Add_Status_List != null)
                                                                  {
                                                                        this.class15_0.Add_Status_List.imethod_1(this.FLD_PID);
                                                                  }
                                                                  this.class15_0.UpdatePowersAndStatus();
                                                                  this.class15_0.UpdateHP_MP_SP();
                                                                  this.class15_0.Update_Data_Boardcast();
                                                                  this.class15_0.Update_Figure_Data(this.class15_0);
                                                                  break;
                                                            }
                                                }
                                          }
                                    }
                                    else if (fLDPID == 1008000054)
                                    {
                                          Players fLDNhanVatVoCongSucPhongNguTangCuongTiLePhanTram2 = this.class15_0;
                                          fLDNhanVatVoCongSucPhongNguTangCuongTiLePhanTram2.FLD_nhan_vat_vo_cong_suc_phong_ngu_tang_cuong_ti_le_phan_tram = fLDNhanVatVoCongSucPhongNguTangCuongTiLePhanTram2.FLD_nhan_vat_vo_cong_suc_phong_ngu_tang_cuong_ti_le_phan_tram - 0.1;
                                          this.class15_0.UpdatePowersAndStatus();
                                    }
                                    else if (fLDPID == 1008000156)
                                    {
                                          Players class1508 = this.class15_0;
                                          class1508.Nhan_vat_them_vao_lon_nhat_HP = class1508.Nhan_vat_them_vao_lon_nhat_HP - 300;
                                          if (this.class15_0.NHAN_VAT_HP > this.class15_0.NHAN_VAT_LON_NHAT_HP)
                                          {
                                                this.class15_0.NHAN_VAT_HP = this.class15_0.NHAN_VAT_LON_NHAT_HP;
                                          }
                                          if (this.class15_0.Add_Status_List != null)
                                          {
                                                this.class15_0.Add_Status_List.imethod_1(this.FLD_PID);
                                          }
                                          this.class15_0.Update_Data_Boardcast();
                                          this.class15_0.Update_Figure_Data(this.class15_0);
                                          this.class15_0.UpdateHP_MP_SP();
                                    }
                              }
                              else if (fLDPID <= 1008000326)
                              {
                                    if (fLDPID > 1008000252)
                                    {
                                          switch (fLDPID)
                                          {
                                                case 1008000304:
                                                      {
                                                            Players fLDNhanVatThemVaoKinhNghiemTiLePhanTram3 = this.class15_0;
                                                            fLDNhanVatThemVaoKinhNghiemTiLePhanTram3.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = fLDNhanVatThemVaoKinhNghiemTiLePhanTram3.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram - 0.05;
                                                            if (this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram < 0)
                                                            {
                                                                  this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = 0;
                                                            }
                                                            Players fLDNhanVatThemVaoCongKich3 = this.class15_0;
                                                            fLDNhanVatThemVaoCongKich3.FLD_nhan_vat_them_vao_cong_kich = fLDNhanVatThemVaoCongKich3.FLD_nhan_vat_them_vao_cong_kich - 30;
                                                            Players fLDNhanVatThemVaoPhongNgu4 = this.class15_0;
                                                            fLDNhanVatThemVaoPhongNgu4.FLD_nhan_vat_them_vao_phong_ngu = fLDNhanVatThemVaoPhongNgu4.FLD_nhan_vat_them_vao_phong_ngu - 30;
                                                            Players fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram7 = this.class15_0;
                                                            fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram7.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram = fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram7.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram - 0.03;
                                                            this.class15_0.bool_6 = false;
                                                            if (this.class15_0.Add_Status_List != null)
                                                            {
                                                                  this.class15_0.Add_Status_List.imethod_1(this.FLD_PID);
                                                            }
                                                            this.class15_0.UpdatePowersAndStatus();
                                                            this.class15_0.Update_Data_Boardcast();
                                                            this.class15_0.Update_Figure_Data(this.class15_0);
                                                            this.class15_0.Update_Equipment_Effectiveness();
                                                            break;
                                                      }
                                                case 1008000305:
                                                      {
                                                            Players fLDNhanVatThemVaoKinhNghiemTiLePhanTram4 = this.class15_0;
                                                            fLDNhanVatThemVaoKinhNghiemTiLePhanTram4.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = fLDNhanVatThemVaoKinhNghiemTiLePhanTram4.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram - 0.05;
                                                            if (this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram < 0)
                                                            {
                                                                  this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = 0;
                                                            }
                                                            Players fLDNhanVatThemVaoCongKich4 = this.class15_0;
                                                            fLDNhanVatThemVaoCongKich4.FLD_nhan_vat_them_vao_cong_kich = fLDNhanVatThemVaoCongKich4.FLD_nhan_vat_them_vao_cong_kich - 30;
                                                            Players fLDNhanVatThemVaoPhongNgu5 = this.class15_0;
                                                            fLDNhanVatThemVaoPhongNgu5.FLD_nhan_vat_them_vao_phong_ngu = fLDNhanVatThemVaoPhongNgu5.FLD_nhan_vat_them_vao_phong_ngu - 30;
                                                            Players fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram8 = this.class15_0;
                                                            fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram8.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram = fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram8.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram - 0.03;
                                                            this.class15_0.bool_6 = false;
                                                            if (this.class15_0.Add_Status_List != null)
                                                            {
                                                                  this.class15_0.Add_Status_List.imethod_1(this.FLD_PID);
                                                            }
                                                            this.class15_0.UpdatePowersAndStatus();
                                                            this.class15_0.Update_Data_Boardcast();
                                                            this.class15_0.Update_Figure_Data(this.class15_0);
                                                            this.class15_0.Update_Equipment_Effectiveness();
                                                            break;
                                                      }
                                                case 1008000306:
                                                      {
                                                            Players fLDNhanVatThemVaoKinhNghiemTiLePhanTram5 = this.class15_0;
                                                            fLDNhanVatThemVaoKinhNghiemTiLePhanTram5.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = fLDNhanVatThemVaoKinhNghiemTiLePhanTram5.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram - 0.1;
                                                            if (this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram < 0)
                                                            {
                                                                  this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = 0;
                                                            }
                                                            Players fLDNhanVatThemVaoCongKich5 = this.class15_0;
                                                            fLDNhanVatThemVaoCongKich5.FLD_nhan_vat_them_vao_cong_kich = fLDNhanVatThemVaoCongKich5.FLD_nhan_vat_them_vao_cong_kich - 40;
                                                            Players fLDNhanVatThemVaoPhongNgu6 = this.class15_0;
                                                            fLDNhanVatThemVaoPhongNgu6.FLD_nhan_vat_them_vao_phong_ngu = fLDNhanVatThemVaoPhongNgu6.FLD_nhan_vat_them_vao_phong_ngu - 40;
                                                            Players player8 = this.class15_0;
                                                            player8.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram = player8.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram - 0.05;
                                                            this.class15_0.bool_6 = false;
                                                            if (this.class15_0.Add_Status_List != null)
                                                            {
                                                                  this.class15_0.Add_Status_List.imethod_1(this.FLD_PID);
                                                            }
                                                            this.class15_0.UpdatePowersAndStatus();
                                                            this.class15_0.Update_Data_Boardcast();
                                                            this.class15_0.Update_Figure_Data(this.class15_0);
                                                            this.class15_0.Update_Equipment_Effectiveness();
                                                            break;
                                                      }
                                                case 1008000307:
                                                      {
                                                            Players fLDNhanVatThemVaoKinhNghiemTiLePhanTram6 = this.class15_0;
                                                            fLDNhanVatThemVaoKinhNghiemTiLePhanTram6.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = fLDNhanVatThemVaoKinhNghiemTiLePhanTram6.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram - 0.1;
                                                            if (this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram < 0)
                                                            {
                                                                  this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = 0;
                                                            }
                                                            Players fLDNhanVatThemVaoCongKich6 = this.class15_0;
                                                            fLDNhanVatThemVaoCongKich6.FLD_nhan_vat_them_vao_cong_kich = fLDNhanVatThemVaoCongKich6.FLD_nhan_vat_them_vao_cong_kich - 40;
                                                            Players fLDNhanVatThemVaoPhongNgu7 = this.class15_0;
                                                            fLDNhanVatThemVaoPhongNgu7.FLD_nhan_vat_them_vao_phong_ngu = fLDNhanVatThemVaoPhongNgu7.FLD_nhan_vat_them_vao_phong_ngu - 40;
                                                            Players class1509 = this.class15_0;
                                                            class1509.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram = class1509.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram - 0.05;
                                                            this.class15_0.bool_6 = false;
                                                            if (this.class15_0.Add_Status_List != null)
                                                            {
                                                                  this.class15_0.Add_Status_List.imethod_1(this.FLD_PID);
                                                            }
                                                            this.class15_0.UpdatePowersAndStatus();
                                                            this.class15_0.Update_Data_Boardcast();
                                                            this.class15_0.Update_Figure_Data(this.class15_0);
                                                            this.class15_0.Update_Equipment_Effectiveness();
                                                            break;
                                                      }
                                                default:
                                                      {
                                                            switch (fLDPID)
                                                            {
                                                                  case 1008000321:
                                                                        {
                                                                              this.class15_0.UpdatePowersAndStatus();
                                                                              this.class15_0.int_16 = 0;
                                                                              break;
                                                                        }
                                                                  case 1008000322:
                                                                        {
                                                                              this.class15_0.UpdatePowersAndStatus();
                                                                              this.class15_0.int_16 = 0;
                                                                              break;
                                                                        }
                                                                  case 1008000323:
                                                                        {
                                                                              Players fLDNhanVatThemVaoKinhNghiemTiLePhanTram7 = this.class15_0;
                                                                              fLDNhanVatThemVaoKinhNghiemTiLePhanTram7.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = fLDNhanVatThemVaoKinhNghiemTiLePhanTram7.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram - 1;
                                                                              if (this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram < 0)
                                                                              {
                                                                                    this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = 0;
                                                                              }
                                                                              this.class15_0.UpdatePowersAndStatus();
                                                                              break;
                                                                        }
                                                                  case 1008000324:
                                                                        {
                                                                              Players fLDNhanVatThemVaoKinhNghiemTiLePhanTram8 = this.class15_0;
                                                                              fLDNhanVatThemVaoKinhNghiemTiLePhanTram8.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = fLDNhanVatThemVaoKinhNghiemTiLePhanTram8.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram - 1;
                                                                              if (this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram < 0)
                                                                              {
                                                                                    this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = 0;
                                                                              }
                                                                              this.class15_0.UpdatePowersAndStatus();
                                                                              break;
                                                                        }
                                                                  case 1008000325:
                                                                        {
                                                                              Players fLDNhanVatThemVaoKinhNghiemTiLePhanTram9 = this.class15_0;
                                                                              fLDNhanVatThemVaoKinhNghiemTiLePhanTram9.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = fLDNhanVatThemVaoKinhNghiemTiLePhanTram9.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram - 0.1;
                                                                              if (this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram < 0)
                                                                              {
                                                                                    this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = 0;
                                                                              }
                                                                              Players fLDNhanVatThemVaoCongKich7 = this.class15_0;
                                                                              fLDNhanVatThemVaoCongKich7.FLD_nhan_vat_them_vao_cong_kich = fLDNhanVatThemVaoCongKich7.FLD_nhan_vat_them_vao_cong_kich - 40;
                                                                              Players fLDNhanVatThemVaoPhongNgu8 = this.class15_0;
                                                                              fLDNhanVatThemVaoPhongNgu8.FLD_nhan_vat_them_vao_phong_ngu = fLDNhanVatThemVaoPhongNgu8.FLD_nhan_vat_them_vao_phong_ngu - 40;
                                                                              Players fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram9 = this.class15_0;
                                                                              fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram9.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram = fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram9.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram - 0.05;
                                                                              Players nhanVatThemVaoLonNhatHP8 = this.class15_0;
                                                                              nhanVatThemVaoLonNhatHP8.Nhan_vat_them_vao_lon_nhat_HP = nhanVatThemVaoLonNhatHP8.Nhan_vat_them_vao_lon_nhat_HP - 300;
                                                                              if (this.class15_0.NHAN_VAT_HP > this.class15_0.NHAN_VAT_LON_NHAT_HP)
                                                                              {
                                                                                    this.class15_0.NHAN_VAT_HP = this.class15_0.NHAN_VAT_LON_NHAT_HP;
                                                                              }
                                                                              if (this.class15_0.Add_Status_List != null)
                                                                              {
                                                                                    this.class15_0.Add_Status_List.imethod_1(this.FLD_PID);
                                                                              }
                                                                              this.class15_0.bool_6 = false;
                                                                              this.class15_0.UpdateHP_MP_SP();
                                                                              this.class15_0.UpdatePowersAndStatus();
                                                                              this.class15_0.Update_Data_Boardcast();
                                                                              this.class15_0.Update_Figure_Data(this.class15_0);
                                                                              this.class15_0.Update_Equipment_Effectiveness();
                                                                              break;
                                                                        }
                                                                  case 1008000326:
                                                                        {
                                                                              Players player9 = this.class15_0;
                                                                              player9.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = player9.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram - 0.1;
                                                                              if (this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram < 0)
                                                                              {
                                                                                    this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = 0;
                                                                              }
                                                                              Players fLDNhanVatThemVaoCongKich8 = this.class15_0;
                                                                              fLDNhanVatThemVaoCongKich8.FLD_nhan_vat_them_vao_cong_kich = fLDNhanVatThemVaoCongKich8.FLD_nhan_vat_them_vao_cong_kich - 40;
                                                                              Players fLDNhanVatThemVaoPhongNgu9 = this.class15_0;
                                                                              fLDNhanVatThemVaoPhongNgu9.FLD_nhan_vat_them_vao_phong_ngu = fLDNhanVatThemVaoPhongNgu9.FLD_nhan_vat_them_vao_phong_ngu - 40;
                                                                              Players class15010 = this.class15_0;
                                                                              class15010.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram = class15010.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram - 0.05;
                                                                              Players nhanVatThemVaoLonNhatHP9 = this.class15_0;
                                                                              nhanVatThemVaoLonNhatHP9.Nhan_vat_them_vao_lon_nhat_HP = nhanVatThemVaoLonNhatHP9.Nhan_vat_them_vao_lon_nhat_HP - 300;
                                                                              if (this.class15_0.NHAN_VAT_HP > this.class15_0.NHAN_VAT_LON_NHAT_HP)
                                                                              {
                                                                                    this.class15_0.NHAN_VAT_HP = this.class15_0.NHAN_VAT_LON_NHAT_HP;
                                                                              }
                                                                              this.class15_0.bool_6 = false;
                                                                              if (this.class15_0.Add_Status_List != null)
                                                                              {
                                                                                    this.class15_0.Add_Status_List.imethod_1(this.FLD_PID);
                                                                              }
                                                                              this.class15_0.UpdateHP_MP_SP();
                                                                              this.class15_0.UpdatePowersAndStatus();
                                                                              this.class15_0.Update_Data_Boardcast();
                                                                              this.class15_0.Update_Figure_Data(this.class15_0);
                                                                              this.class15_0.Update_Equipment_Effectiveness();
                                                                              break;
                                                                        }
                                                            }
                                                            break;
                                                      }
                                          }
                                    }
                                    else
                                    {
                                          switch (fLDPID)
                                          {
                                                case 1008000194:
                                                      {
                                                            Players nhanVatThemVaoLonNhatHP10 = this.class15_0;
                                                            nhanVatThemVaoLonNhatHP10.Nhan_vat_them_vao_lon_nhat_HP = nhanVatThemVaoLonNhatHP10.Nhan_vat_them_vao_lon_nhat_HP - 1000;
                                                            if (this.class15_0.NHAN_VAT_HP > this.class15_0.NHAN_VAT_LON_NHAT_HP)
                                                            {
                                                                  this.class15_0.NHAN_VAT_HP = this.class15_0.NHAN_VAT_LON_NHAT_HP;
                                                            }
                                                            this.class15_0.dllFLD_ATT_Percentage(new decimal(15, 0, 0, false, 2));
                                                            this.class15_0.DLL_FLD_THEM_VAO_TI_LE_PHAN_TRAM_PHONG_NGU(new decimal(15, 0, 0, false, 2));
                                                            Players fLDNhanVatThemVaoKinhNghiemTiLePhanTram10 = this.class15_0;
                                                            fLDNhanVatThemVaoKinhNghiemTiLePhanTram10.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = fLDNhanVatThemVaoKinhNghiemTiLePhanTram10.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram - 0.4;
                                                            if (this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram < 0)
                                                            {
                                                                  this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = 0;
                                                            }
                                                            Players fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram10 = this.class15_0;
                                                            fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram10.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram = fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram10.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram - 0.1;
                                                            Players fLDNhanVatVoCongSucPhongNguTangCuongTiLePhanTram3 = this.class15_0;
                                                            fLDNhanVatVoCongSucPhongNguTangCuongTiLePhanTram3.FLD_nhan_vat_vo_cong_suc_phong_ngu_tang_cuong_ti_le_phan_tram = fLDNhanVatVoCongSucPhongNguTangCuongTiLePhanTram3.FLD_nhan_vat_vo_cong_suc_phong_ngu_tang_cuong_ti_le_phan_tram - 0.1;
                                                            this.class15_0.UpdatePowersAndStatus();
                                                            this.class15_0.UpdateHP_MP_SP();
                                                            break;
                                                      }
                                                case 1008000195:
                                                      {
                                                            Players player10 = this.class15_0;
                                                            player10.Nhan_vat_them_vao_lon_nhat_HP = player10.Nhan_vat_them_vao_lon_nhat_HP - 300;
                                                            if (this.class15_0.NHAN_VAT_HP > this.class15_0.NHAN_VAT_LON_NHAT_HP)
                                                            {
                                                                  this.class15_0.NHAN_VAT_HP = this.class15_0.NHAN_VAT_LON_NHAT_HP;
                                                            }
                                                            Players fLDNhanVatThemVaoKhiCong2 = this.class15_0;
                                                            fLDNhanVatThemVaoKhiCong2.FLD_nhan_vat_them_vao_khi_cong = fLDNhanVatThemVaoKhiCong2.FLD_nhan_vat_them_vao_khi_cong - 1;
                                                            this.class15_0.DLL_FLD_THEM_VAO_TI_LE_PHAN_TRAM_PHONG_NGU(new decimal(5, 0, 0, false, 2));
                                                            this.class15_0.Update_Data_Boardcast();
                                                            this.class15_0.Update_Figure_Data(this.class15_0);
                                                            this.class15_0.UpdateHP_MP_SP();
                                                            this.class15_0.UpdatePowersAndStatus();
                                                            break;
                                                      }
                                                case 1008000196:
                                                      {
                                                            break;
                                                      }
                                                case 1008000197:
                                                      {
                                                            Players class15011 = this.class15_0;
                                                            class15011.Nhan_vat_them_vao_lon_nhat_HP = class15011.Nhan_vat_them_vao_lon_nhat_HP - 700;
                                                            if (this.class15_0.NHAN_VAT_HP > this.class15_0.NHAN_VAT_LON_NHAT_HP)
                                                            {
                                                                  this.class15_0.NHAN_VAT_HP = this.class15_0.NHAN_VAT_LON_NHAT_HP;
                                                            }
                                                            this.class15_0.DLL_FLD_THEM_VAO_TI_LE_PHAN_TRAM_PHONG_NGU(new decimal(1, 0, 0, false, 1));
                                                            this.class15_0.dllFLD_ATT_Percentage(new decimal(1, 0, 0, false, 1));
                                                            Players fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram11 = this.class15_0;
                                                            fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram11.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram = fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram11.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram - 0.05;
                                                            Players fLDNhanVatVoCongSucPhongNguTangCuongTiLePhanTram4 = this.class15_0;
                                                            fLDNhanVatVoCongSucPhongNguTangCuongTiLePhanTram4.FLD_nhan_vat_vo_cong_suc_phong_ngu_tang_cuong_ti_le_phan_tram = fLDNhanVatVoCongSucPhongNguTangCuongTiLePhanTram4.FLD_nhan_vat_vo_cong_suc_phong_ngu_tang_cuong_ti_le_phan_tram - 0.1;
                                                            this.class15_0.DLL_FLD_trang_bi_them_vao_vu_khi_cuong_hoa(2);
                                                            this.class15_0.dllFLD_TRANG_BI_THEM_VAO_PHONG_NGU_CUONG_HOA(1);
                                                            if (this.class15_0.Add_Status_List != null)
                                                            {
                                                                  this.class15_0.Add_Status_List.imethod_1(this.FLD_PID);
                                                            }
                                                            this.class15_0.Update_Data_Boardcast();
                                                            this.class15_0.Update_Figure_Data(this.class15_0);
                                                            this.class15_0.UpdateHP_MP_SP();
                                                            this.class15_0.TINH_TOAN_NHAN_VAT_TRANG_BI_SO_LIEU();
                                                            this.class15_0.UpdatePowersAndStatus();
                                                            break;
                                                      }
                                                default:
                                                      {
                                                            switch (fLDPID)
                                                            {
                                                                  case 1008000232:
                                                                        {
                                                                              Players nhanVatThemVaoLonNhatHP11 = this.class15_0;
                                                                              nhanVatThemVaoLonNhatHP11.Nhan_vat_them_vao_lon_nhat_HP = nhanVatThemVaoLonNhatHP11.Nhan_vat_them_vao_lon_nhat_HP - 100;
                                                                              if (this.class15_0.NHAN_VAT_HP > this.class15_0.NHAN_VAT_LON_NHAT_HP)
                                                                              {
                                                                                    this.class15_0.NHAN_VAT_HP = this.class15_0.NHAN_VAT_LON_NHAT_HP;
                                                                              }
                                                                              Players fLDNhanVatThemVaoKinhNghiemTiLePhanTram11 = this.class15_0;
                                                                              fLDNhanVatThemVaoKinhNghiemTiLePhanTram11.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = fLDNhanVatThemVaoKinhNghiemTiLePhanTram11.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram - 0.2;
                                                                              if (this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram < 0)
                                                                              {
                                                                                    this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = 0;
                                                                              }
                                                                              Players fLDNhanVatThemVaoGoldTiLePhanTram = this.class15_0;
                                                                              fLDNhanVatThemVaoGoldTiLePhanTram.FLD_nhan_vat_them_vao_gold_ti_le_phan_tram = fLDNhanVatThemVaoGoldTiLePhanTram.FLD_nhan_vat_them_vao_gold_ti_le_phan_tram - 0.4;
                                                                              Players fLDNhanVatThemVaoItemRoiXuongXacSuatTiLePhanTram = this.class15_0;
                                                                              fLDNhanVatThemVaoItemRoiXuongXacSuatTiLePhanTram.FLD_nhan_vat_them_vao_item_roi_xuong_xac_suat_ti_le_phan_tram = fLDNhanVatThemVaoItemRoiXuongXacSuatTiLePhanTram.FLD_nhan_vat_them_vao_item_roi_xuong_xac_suat_ti_le_phan_tram - 0.2;
                                                                              this.class15_0.UpdatePowersAndStatus();
                                                                              this.class15_0.UpdateHP_MP_SP();
                                                                              break;
                                                                        }
                                                                  case 1008000239:
                                                                        {
                                                                              Players player11 = this.class15_0;
                                                                              player11.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = player11.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram - 1;
                                                                              if (this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram < 0)
                                                                              {
                                                                                    this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = 0;
                                                                              }
                                                                              this.class15_0.UpdatePowersAndStatus();
                                                                              break;
                                                                        }
                                                                  case 1008000240:
                                                                        {
                                                                              Players class15012 = this.class15_0;
                                                                              class15012.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = class15012.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram - 0.05;
                                                                              if (this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram < 0)
                                                                              {
                                                                                    this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = 0;
                                                                              }
                                                                              Players fLDNhanVatThemVaoCongKich9 = this.class15_0;
                                                                              fLDNhanVatThemVaoCongKich9.FLD_nhan_vat_them_vao_cong_kich = fLDNhanVatThemVaoCongKich9.FLD_nhan_vat_them_vao_cong_kich - 30;
                                                                              Players fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram12 = this.class15_0;
                                                                              fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram12.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram = fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram12.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram - 0.03;
                                                                              if (this.class15_0.Add_Status_List != null)
                                                                              {
                                                                                    this.class15_0.Add_Status_List.imethod_1(this.FLD_PID);
                                                                              }
                                                                              this.class15_0.bool_6 = false;
                                                                              this.class15_0.UpdatePowersAndStatus();
                                                                              this.class15_0.Update_Data_Boardcast();
                                                                              this.class15_0.Update_Figure_Data(this.class15_0);
                                                                              this.class15_0.Update_Equipment_Effectiveness();
                                                                              break;
                                                                        }
                                                                  case 1008000241:
                                                                        {
                                                                              Players fLDNhanVatThemVaoKinhNghiemTiLePhanTram12 = this.class15_0;
                                                                              fLDNhanVatThemVaoKinhNghiemTiLePhanTram12.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = fLDNhanVatThemVaoKinhNghiemTiLePhanTram12.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram - 0.05;
                                                                              if (this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram < 0)
                                                                              {
                                                                                    this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = 0;
                                                                              }
                                                                              Players fLDNhanVatThemVaoCongKich10 = this.class15_0;
                                                                              fLDNhanVatThemVaoCongKich10.FLD_nhan_vat_them_vao_cong_kich = fLDNhanVatThemVaoCongKich10.FLD_nhan_vat_them_vao_cong_kich - 30;
                                                                              Players player12 = this.class15_0;
                                                                              player12.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram = player12.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram - 0.03;
                                                                              if (this.class15_0.Add_Status_List != null)
                                                                              {
                                                                                    this.class15_0.Add_Status_List.imethod_1(this.FLD_PID);
                                                                              }
                                                                              this.class15_0.bool_6 = false;
                                                                              this.class15_0.UpdatePowersAndStatus();
                                                                              this.class15_0.Update_Data_Boardcast();
                                                                              this.class15_0.Update_Figure_Data(this.class15_0);
                                                                              this.class15_0.Update_Equipment_Effectiveness();
                                                                              break;
                                                                        }
                                                                  case 1008000242:
                                                                        {
                                                                              Players class15013 = this.class15_0;
                                                                              class15013.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = class15013.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram - 0.05;
                                                                              if (this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram < 0)
                                                                              {
                                                                                    this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = 0;
                                                                              }
                                                                              Players fLDNhanVatThemVaoCongKich11 = this.class15_0;
                                                                              fLDNhanVatThemVaoCongKich11.FLD_nhan_vat_them_vao_cong_kich = fLDNhanVatThemVaoCongKich11.FLD_nhan_vat_them_vao_cong_kich - 30;
                                                                              Players fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram13 = this.class15_0;
                                                                              fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram13.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram = fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram13.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram - 0.03;
                                                                              this.class15_0.bool_6 = false;
                                                                              if (this.class15_0.Add_Status_List != null)
                                                                              {
                                                                                    this.class15_0.Add_Status_List.imethod_1(this.FLD_PID);
                                                                              }
                                                                              this.class15_0.UpdatePowersAndStatus();
                                                                              this.class15_0.Update_Data_Boardcast();
                                                                              this.class15_0.Update_Figure_Data(this.class15_0);
                                                                              this.class15_0.Update_Equipment_Effectiveness();
                                                                              break;
                                                                        }
                                                                  case 1008000243:
                                                                        {
                                                                              this.class15_0.dllFLD_ATT_Percentage(new decimal(2, 0, 0, false, 1));
                                                                              this.class15_0.DLL_FLD_THEM_VAO_TI_LE_PHAN_TRAM_PHONG_NGU(new decimal(2, 0, 0, false, 1));
                                                                              Players nhanVatThemVaoLonNhatHP12 = this.class15_0;
                                                                              nhanVatThemVaoLonNhatHP12.Nhan_vat_them_vao_lon_nhat_HP = nhanVatThemVaoLonNhatHP12.Nhan_vat_them_vao_lon_nhat_HP - 200;
                                                                              if (this.class15_0.NHAN_VAT_HP > this.class15_0.NHAN_VAT_LON_NHAT_HP)
                                                                              {
                                                                                    this.class15_0.NHAN_VAT_HP = this.class15_0.NHAN_VAT_LON_NHAT_HP;
                                                                              }
                                                                              Players fLDNhanVatThemVaoKinhNghiemTiLePhanTram13 = this.class15_0;
                                                                              fLDNhanVatThemVaoKinhNghiemTiLePhanTram13.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = fLDNhanVatThemVaoKinhNghiemTiLePhanTram13.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram - 0.15;
                                                                              if (this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram < 0)
                                                                              {
                                                                                    this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = 0;
                                                                              }
                                                                              Players player13 = this.class15_0;
                                                                              player13.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram = player13.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram - 0.05;
                                                                              this.class15_0.UpdateHP_MP_SP();
                                                                              this.class15_0.UpdatePowersAndStatus();
                                                                              break;
                                                                        }
                                                                  case 1008000245:
                                                                        {
                                                                              Players class15014 = this.class15_0;
                                                                              class15014.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram = class15014.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram - 0.1;
                                                                              Players fLDThemVaoTiLePhanTramNeTranh3 = this.class15_0;
                                                                              fLDThemVaoTiLePhanTramNeTranh3.FLD_them_vao_ti_le_phan_tram_ne_tranh = fLDThemVaoTiLePhanTramNeTranh3.FLD_them_vao_ti_le_phan_tram_ne_tranh - 0.05;
                                                                              Players nhanVatThemVaoLonNhatHP13 = this.class15_0;
                                                                              nhanVatThemVaoLonNhatHP13.Nhan_vat_them_vao_lon_nhat_HP = nhanVatThemVaoLonNhatHP13.Nhan_vat_them_vao_lon_nhat_HP - 100;
                                                                              if (this.class15_0.NHAN_VAT_HP > this.class15_0.NHAN_VAT_LON_NHAT_HP)
                                                                              {
                                                                                    this.class15_0.NHAN_VAT_HP = this.class15_0.NHAN_VAT_LON_NHAT_HP;
                                                                              }
                                                                              if (this.class15_0.Add_Status_List != null)
                                                                              {
                                                                                    this.class15_0.Add_Status_List.imethod_1(this.FLD_PID);
                                                                              }
                                                                              this.class15_0.Update_Data_Boardcast();
                                                                              this.class15_0.Update_Figure_Data(this.class15_0);
                                                                              this.class15_0.UpdateHP_MP_SP();
                                                                              this.class15_0.UpdatePowersAndStatus();
                                                                              break;
                                                                        }
                                                                  case 1008000248:
                                                                        {
                                                                              Players fLDNhanVatThemVaoKinhNghiemTiLePhanTram14 = this.class15_0;
                                                                              fLDNhanVatThemVaoKinhNghiemTiLePhanTram14.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = fLDNhanVatThemVaoKinhNghiemTiLePhanTram14.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram - 1;
                                                                              if (this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram < 0)
                                                                              {
                                                                                    this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = 0;
                                                                              }
                                                                              Players fLDNhanVatThemVaoKinhNghiemHocVoCongTiLePhanTram1 = this.class15_0;
                                                                              fLDNhanVatThemVaoKinhNghiemHocVoCongTiLePhanTram1.FLD_nhan_vat_them_vao_kinh_nghiem_hoc_vo_cong_ti_le_phan_tram = fLDNhanVatThemVaoKinhNghiemHocVoCongTiLePhanTram1.FLD_nhan_vat_them_vao_kinh_nghiem_hoc_vo_cong_ti_le_phan_tram - 1;
                                                                              Players fLDNhanVatThemVaoGoldTiLePhanTram1 = this.class15_0;
                                                                              fLDNhanVatThemVaoGoldTiLePhanTram1.FLD_nhan_vat_them_vao_gold_ti_le_phan_tram = fLDNhanVatThemVaoGoldTiLePhanTram1.FLD_nhan_vat_them_vao_gold_ti_le_phan_tram - 1;
                                                                              Players fLDNhanVatThemVaoItemRoiXuongXacSuatTiLePhanTram1 = this.class15_0;
                                                                              fLDNhanVatThemVaoItemRoiXuongXacSuatTiLePhanTram1.FLD_nhan_vat_them_vao_item_roi_xuong_xac_suat_ti_le_phan_tram = fLDNhanVatThemVaoItemRoiXuongXacSuatTiLePhanTram1.FLD_nhan_vat_them_vao_item_roi_xuong_xac_suat_ti_le_phan_tram - 1;
                                                                              this.class15_0.UpdatePowersAndStatus();
                                                                              break;
                                                                        }
                                                                  case 1008000250:
                                                                        {
                                                                              Players player14 = this.class15_0;
                                                                              player14.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = player14.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram - 0.05;
                                                                              if (this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram < 0)
                                                                              {
                                                                                    this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = 0;
                                                                              }
                                                                              Players fLDNhanVatThemVaoCongKich12 = this.class15_0;
                                                                              fLDNhanVatThemVaoCongKich12.FLD_nhan_vat_them_vao_cong_kich = fLDNhanVatThemVaoCongKich12.FLD_nhan_vat_them_vao_cong_kich - 30;
                                                                              Players fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram14 = this.class15_0;
                                                                              fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram14.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram = fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram14.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram - 0.03;
                                                                              this.class15_0.bool_6 = false;
                                                                              if (this.class15_0.Add_Status_List != null)
                                                                              {
                                                                                    this.class15_0.Add_Status_List.imethod_1(this.FLD_PID);
                                                                              }
                                                                              this.class15_0.UpdatePowersAndStatus();
                                                                              this.class15_0.Update_Data_Boardcast();
                                                                              this.class15_0.Update_Figure_Data(this.class15_0);
                                                                              this.class15_0.Update_Equipment_Effectiveness();
                                                                              break;
                                                                        }
                                                                  case 1008000251:
                                                                        {
                                                                              Players class15015 = this.class15_0;
                                                                              class15015.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = class15015.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram - 0.05;
                                                                              if (this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram < 0)
                                                                              {
                                                                                    this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = 0;
                                                                              }
                                                                              Players fLDNhanVatThemVaoCongKich13 = this.class15_0;
                                                                              fLDNhanVatThemVaoCongKich13.FLD_nhan_vat_them_vao_cong_kich = fLDNhanVatThemVaoCongKich13.FLD_nhan_vat_them_vao_cong_kich - 30;
                                                                              Players fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram15 = this.class15_0;
                                                                              fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram15.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram = fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram15.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram - 0.03;
                                                                              this.class15_0.bool_6 = false;
                                                                              if (this.class15_0.Add_Status_List != null)
                                                                              {
                                                                                    this.class15_0.Add_Status_List.imethod_1(this.FLD_PID);
                                                                              }
                                                                              this.class15_0.UpdatePowersAndStatus();
                                                                              this.class15_0.Update_Data_Boardcast();
                                                                              this.class15_0.Update_Figure_Data(this.class15_0);
                                                                              this.class15_0.Update_Equipment_Effectiveness();
                                                                              break;
                                                                        }
                                                                  case 1008000252:
                                                                        {
                                                                              Players player15 = this.class15_0;
                                                                              player15.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram = player15.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram - 0.2;
                                                                              Players fLDNhanVatThemVaoPhongNgu10 = this.class15_0;
                                                                              fLDNhanVatThemVaoPhongNgu10.FLD_nhan_vat_them_vao_phong_ngu = fLDNhanVatThemVaoPhongNgu10.FLD_nhan_vat_them_vao_phong_ngu - 1;
                                                                              Players fLDNhanVatVoCongSucPhongNguTangCuongTiLePhanTram5 = this.class15_0;
                                                                              fLDNhanVatVoCongSucPhongNguTangCuongTiLePhanTram5.FLD_nhan_vat_vo_cong_suc_phong_ngu_tang_cuong_ti_le_phan_tram = fLDNhanVatVoCongSucPhongNguTangCuongTiLePhanTram5.FLD_nhan_vat_vo_cong_suc_phong_ngu_tang_cuong_ti_le_phan_tram - 0.01;
                                                                              Players fLDNhanVatThemVaoNeTranh2 = this.class15_0;
                                                                              fLDNhanVatThemVaoNeTranh2.FLD_nhan_vat_them_vao_ne_tranh = fLDNhanVatThemVaoNeTranh2.FLD_nhan_vat_them_vao_ne_tranh - 1;
                                                                              Players nhanVatThemVaoLonNhatHP14 = this.class15_0;
                                                                              nhanVatThemVaoLonNhatHP14.Nhan_vat_them_vao_lon_nhat_HP = nhanVatThemVaoLonNhatHP14.Nhan_vat_them_vao_lon_nhat_HP - 1;
                                                                              if (this.class15_0.NHAN_VAT_HP > this.class15_0.NHAN_VAT_LON_NHAT_HP)
                                                                              {
                                                                                    this.class15_0.NHAN_VAT_HP = this.class15_0.NHAN_VAT_LON_NHAT_HP;
                                                                              }
                                                                              if (this.class15_0.Add_Status_List != null)
                                                                              {
                                                                                    this.class15_0.Add_Status_List.imethod_1(this.FLD_PID);
                                                                              }
                                                                              this.class15_0.Update_Data_Boardcast();
                                                                              this.class15_0.Update_Figure_Data(this.class15_0);
                                                                              this.class15_0.UpdateHP_MP_SP();
                                                                              this.class15_0.UpdatePowersAndStatus();
                                                                              break;
                                                                        }
                                                            }
                                                            break;
                                                      }
                                          }
                                    }
                              }
                              else if (fLDPID <= 1008000363)
                              {
                                    if (fLDPID == 1008000362)
                                    {
                                          Players fLDNhanVatThemVaoKinhNghiemTiLePhanTram15 = this.class15_0;
                                          fLDNhanVatThemVaoKinhNghiemTiLePhanTram15.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = fLDNhanVatThemVaoKinhNghiemTiLePhanTram15.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram - 1.5;
                                          if (this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram < 0)
                                          {
                                                this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = 0;
                                          }
                                          this.class15_0.UpdatePowersAndStatus();
                                    }
                                    else if (fLDPID == 1008000363)
                                    {
                                          Players class15016 = this.class15_0;
                                          class15016.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = class15016.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram - 1.5;
                                          if (this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram < 0)
                                          {
                                                this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = 0;
                                          }
                                          this.class15_0.UpdatePowersAndStatus();
                                    }
                              }
                              else if (fLDPID == 1008001111)
                              {
                                    Players fLDNhanVatThemVaoKinhNghiemTiLePhanTram16 = this.class15_0;
                                    fLDNhanVatThemVaoKinhNghiemTiLePhanTram16.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = fLDNhanVatThemVaoKinhNghiemTiLePhanTram16.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram - 0.4;
                                    if (this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram < 0)
                                    {
                                          this.class15_0.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = 0;
                                    }
                                    Players fLDNhanVatThemVaoCongKich14 = this.class15_0;
                                    fLDNhanVatThemVaoCongKich14.FLD_nhan_vat_them_vao_cong_kich = fLDNhanVatThemVaoCongKich14.FLD_nhan_vat_them_vao_cong_kich - 50;
                                    Players fLDNhanVatThemVaoPhongNgu11 = this.class15_0;
                                    fLDNhanVatThemVaoPhongNgu11.FLD_nhan_vat_them_vao_phong_ngu = fLDNhanVatThemVaoPhongNgu11.FLD_nhan_vat_them_vao_phong_ngu - 100;
                                    Players fLDNhanVatThemVaoSinhMenh2 = this.class15_0;
                                    fLDNhanVatThemVaoSinhMenh2.FLD_nhan_vat_them_vao_sinh_menh = fLDNhanVatThemVaoSinhMenh2.FLD_nhan_vat_them_vao_sinh_menh - 500;
                                    Players nhanVatThemVaoLonNhatMP3 = this.class15_0;
                                    nhanVatThemVaoLonNhatMP3.Nhan_vat_them_vao_lon_nhat_MP = nhanVatThemVaoLonNhatMP3.Nhan_vat_them_vao_lon_nhat_MP - 500;
                                    Players fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram16 = this.class15_0;
                                    fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram16.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram = fLDNhanVatVoCongLucCongKichTangCuongTiLePhanTram16.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram - 0.1;
                                    this.class15_0.bool_6 = false;
                                    if (this.class15_0.Add_Status_List != null)
                                    {
                                          this.class15_0.Add_Status_List.imethod_1(this.FLD_PID);
                                    }
                                    this.class15_0.UpdatePowersAndStatus();
                                    this.class15_0.Update_Data_Boardcast();
                                    this.class15_0.Update_Figure_Data(this.class15_0);
                                    this.class15_0.Update_Equipment_Effectiveness();
                              }
                              else if (fLDPID == 1008001112)
                              {
                                    Players fLDNhanVatThemVaoCongKich15 = this.class15_0;
                                    fLDNhanVatThemVaoCongKich15.FLD_nhan_vat_them_vao_cong_kich = fLDNhanVatThemVaoCongKich15.FLD_nhan_vat_them_vao_cong_kich - 100;
                                    Players fLDNhanVatThemVaoPhongNgu12 = this.class15_0;
                                    fLDNhanVatThemVaoPhongNgu12.FLD_nhan_vat_them_vao_phong_ngu = fLDNhanVatThemVaoPhongNgu12.FLD_nhan_vat_them_vao_phong_ngu - 50;
                                    Players fLDNhanVatThemVaoSinhMenh3 = this.class15_0;
                                    fLDNhanVatThemVaoSinhMenh3.FLD_nhan_vat_them_vao_sinh_menh = fLDNhanVatThemVaoSinhMenh3.FLD_nhan_vat_them_vao_sinh_menh - 800;
                                    Players player16 = this.class15_0;
                                    player16.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram = player16.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram - 0.1;
                                    Players fLDNhanVatVoCongSucPhongNguTangCuongTiLePhanTram6 = this.class15_0;
                                    fLDNhanVatVoCongSucPhongNguTangCuongTiLePhanTram6.FLD_nhan_vat_vo_cong_suc_phong_ngu_tang_cuong_ti_le_phan_tram = fLDNhanVatVoCongSucPhongNguTangCuongTiLePhanTram6.FLD_nhan_vat_vo_cong_suc_phong_ngu_tang_cuong_ti_le_phan_tram - 0.1;
                                    Players fLDNhanVatThemVaoNeTranh3 = this.class15_0;
                                    fLDNhanVatThemVaoNeTranh3.FLD_nhan_vat_them_vao_ne_tranh = fLDNhanVatThemVaoNeTranh3.FLD_nhan_vat_them_vao_ne_tranh - 10;
                                    this.class15_0.bool_6 = false;
                                    if (this.class15_0.Add_Status_List != null)
                                    {
                                          this.class15_0.Add_Status_List.imethod_1(this.FLD_PID);
                                    }
                                    this.class15_0.UpdatePowersAndStatus();
                                    this.class15_0.Update_Data_Boardcast();
                                    this.class15_0.Update_Figure_Data(this.class15_0);
                                    this.class15_0.Update_Equipment_Effectiveness();
                              }
                              if (this.class15_0.Add_Status_List != null)
                              {
                                    this.class15_0.Add_Status_List.imethod_1(this.FLD_PID);
                              }
                              this.class15_0.Status_Effect(BitConverter.GetBytes(this.FLD_PID), 0, 0);
                              this.Dispose();
                        }
                        catch (Exception exception1)
                        {
                              Exception exception = exception1;
                              Form1.WriteLine(1, string.Concat(new object[] { "追加状态类 THOI_GIAN_KET_THUC_SU_KIEN 出错：[", this.FLD_PID, "]", exception }));
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
                        Form1.WriteLine(0, "追加状态类-THOI_GIAN_KET_THUC_SU_KIEN2");
                  }
                  this.THOI_GIAN_KET_THUC_SU_KIEN();
            }
      }
}