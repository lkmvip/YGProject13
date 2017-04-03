namespace ns9
{
      using ns11;
      using ns12;
      using ns13;
      using ns2;
      using ns3;
      using ns5;
      using ns6;
      using ns8;
      using System;
      using System.Collections.Generic;

      public class VAT_PHAM_LOAI: IDisposable
      {
            Dictionary<string, int> dictionary_0;
            public bool bool_0;
            private bool bool_1;
            private byte[] byte_0;
            private ITEMSX class8_0;
            private ITEMSX class8_1;
            private ITEMSX class8_2;
            private ITEMSX class8_3;
            private double double_0;
            private double double_1;
            private double double_121;
            private double double_122;
            private double double_123;
            private double double_124;
            private double double_125;
            private double double_126;
            private double double_127;
            private double double_128;
            private double double_129;
            private double double_130;
            private double double_2;
            private double double_3;
            private int int_0;
            private int int_1;
            private int int_10;
            private int int_11;
            private int int_12;
            private int int_13;
            private int int_14;
            private int int_15;
            private int int_16;
            private int int_17;
            private int int_18;
            private int int_19;
            private int int_2;
            private int int_20;
            private int int_21;
            private int int_22;
            private int int_23;
            private int int_24;
            private int int_25;
            private int int_26;
            private int int_27;
            private int int_28;
            private int int_29;
            private int int_3;
            private int int_30;
            private int int_31;
            private int int_32;
            private int int_33;
            private int int_34;
            private int int_35;
            private int int_36;
            private int int_37;
            private int int_38;
            private int int_39;
            private int int_4;
            private int int_40;
            private int int_41;
            private int int_42;
            private int int_43;
            private int int_44;
            private int int_45;
            private int int_46;
            private int int_47;
            private int int_48;
            private int int_49;
            private int int_5;
            private int int_50;
            private int int_51;
            private int int_52;
            private int int_53;
            private int int_54;
            private int int_55;
            private int int_56;
            private int int_57;
            private int int_58;
            private int int_59;
            private int int_6;
            private int int_60;
            private int int_61;
            private int int_62;
            private int int_63;
            private int int_64;
            private int int_65;
            private int int_66;
            private int int_67;
            private int int_68;
            private int int_69;
            private int int_7;
            private int int_70;
            private int int_71;
            private int int_72;
            private int int_73;
            private int int_74;
            private int int_75;
            private int int_76;
            private int int_77;
            private int int_78;
            private int int_79;
            private int int_8;
            private int int_80;
            private int int_81;
            private int int_82;
            private int int_83;
            private int int_84;
            private int int_85;
            private int int_86;
            private int int_87;
            private int int_9;
            private long long_0;
            private long long_1;
            private long long_2;
            private string string_0;

            public VAT_PHAM_LOAI()
            {
            }

            public VAT_PHAM_LOAI(byte[] Item_byte_)
            {
                  this.Item_byte = Item_byte_;
            }

            public VAT_PHAM_LOAI(byte[] Item_byte_, int VI_TRI)
            {
                  this.Item_byte = Item_byte_;
                  this.VAT_PHAM_VI_TRI = VI_TRI;
            }

            private void HOAN_THANH_CO_BAN_THUOC_TINH(string ysqh)
            {
                  try
                  {
                        string str;
                        switch (ysqh.Length)
                        {
                              case 8:
                                    str = ysqh.Substring(0, 1);
                                    break;

                              case 9:
                                    str = ysqh.Substring(0, 2);
                                    break;

                              default:
                                    return;
                        }
                        int num = 0;
                        DA_THUOC_TINH_HIEU_QUA da_thuoc_tinh_hieu_qua = new DA_THUOC_TINH_HIEU_QUA();
                        if (World.Thuoc_tinh_mo_rong_co_hay_khong_mo_ra == 0)
                        {
                              if (str == "8")
                              {
                                    num = int.Parse(ysqh.Substring(ysqh.Length - 2, 2));
                              }
                              else
                              {
                                    num = int.Parse(ysqh.Substring(ysqh.Length - 3, 3));
                              }
                        }
                        else if (str == "8")
                        {
                              num = int.Parse(ysqh.Substring(ysqh.Length - 2, 2));
                        }
                        else if (((str != "9") && (str != "12")) && ((str != "13") && (str != "15")))
                        {
                              num = int.Parse(ysqh) - (int.Parse(str) * 0x989680);
                        }
                        else
                        {
                              num = int.Parse(ysqh.Substring(ysqh.Length - 3, 3));
                        }
                        num = (int)(num * (1.0 + (da_thuoc_tinh_hieu_qua.method_0(int.Parse(str) * 0x186a0) * 0.01)));
                        switch (int.Parse(str))
                        {
                              case 1:
                                    this.Item_thuoc_tinh_Luc_cong_kich_tang_cuong += num;
                                    this.Item_luc_cong_kich += num;
                                    this.Item_luc_cong_kich_MAX += num;
                                    return;

                              case 2:
                                    this.Item_thuoc_tinh_Suc_phong_ngu_tang_cuong += num;
                                    this.Item_suc_phong_ngu += num;
                                    return;

                              case 3:
                                    this.Item_thuoc_tinh_sinh_menh_tang_cuong += num;
                                    return;

                              case 4:
                                    this.Item_thuoc_tinh_Noi_cong_suc_manh_tang_cuong += num;
                                    return;

                              case 5:
                                    this.Item_thuoc_tinh_Ti_le_trung_muc_tieu_tang_cuong += num;
                                    return;

                              case 6:
                                    this.Item_thuoc_tinh_ne_tranh_xac_xuat_tang_cuong += num;
                                    return;

                              case 7:
                                    this.Item_thuoc_tinh_Luc_cong_kich_vo_cong += num;
                                    return;

                              case 8:
                                    {
                                          string str2;
                                          string str3 = ysqh.Substring(4, 2);
                                          if ((str3 != null) && ((str2 = str3) != null))
                                          {
                                                int num3;
                                                if (dictionary_0 == null)
                                                {
                                                      Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x51) {
                                    {
                                        "00",
                                        0
                                    },
                                    {
                                        "10",
                                        1
                                    },
                                    {
                                        "11",
                                        2
                                    },
                                    {
                                        "12",
                                        3
                                    },
                                    {
                                        "13",
                                        4
                                    },
                                    {
                                        "14",
                                        5
                                    },
                                    {
                                        "15",
                                        6
                                    },
                                    {
                                        "16",
                                        7
                                    },
                                    {
                                        "17",
                                        8
                                    },
                                    {
                                        "18",
                                        9
                                    },
                                    {
                                        "19",
                                        10
                                    },
                                    {
                                        "20",
                                        11
                                    },
                                    {
                                        "21",
                                        12
                                    },
                                    {
                                        "22",
                                        13
                                    },
                                    {
                                        "23",
                                        14
                                    },
                                    {
                                        "24",
                                        15
                                    },
                                    {
                                        "25",
                                        0x10
                                    },
                                    {
                                        "26",
                                        0x11
                                    },
                                    {
                                        "27",
                                        0x12
                                    },
                                    {
                                        "28",
                                        0x13
                                    },
                                    {
                                        "29",
                                        20
                                    },
                                    {
                                        "30",
                                        0x15
                                    },
                                    {
                                        "31",
                                        0x16
                                    },
                                    {
                                        "32",
                                        0x17
                                    },
                                    {
                                        "33",
                                        0x18
                                    },
                                    {
                                        "34",
                                        0x19
                                    },
                                    {
                                        "35",
                                        0x1a
                                    },
                                    {
                                        "36",
                                        0x1b
                                    },
                                    {
                                        "37",
                                        0x1c
                                    },
                                    {
                                        "38",
                                        0x1d
                                    },
                                    {
                                        "39",
                                        30
                                    },
                                    {
                                        "40",
                                        0x1f
                                    },
                                    {
                                        "41",
                                        0x20
                                    },
                                    {
                                        "42",
                                        0x21
                                    },
                                    {
                                        "43",
                                        0x22
                                    },
                                    {
                                        "44",
                                        0x23
                                    },
                                    {
                                        "45",
                                        0x24
                                    },
                                    {
                                        "46",
                                        0x25
                                    },
                                    {
                                        "47",
                                        0x26
                                    },
                                    {
                                        "48",
                                        0x27
                                    },
                                    {
                                        "49",
                                        40
                                    },
                                    {
                                        "50",
                                        0x29
                                    },
                                    {
                                        "51",
                                        0x2a
                                    },
                                    {
                                        "52",
                                        0x2b
                                    },
                                    {
                                        "53",
                                        0x2c
                                    },
                                    {
                                        "54",
                                        0x2d
                                    },
                                    {
                                        "55",
                                        0x2e
                                    },
                                    {
                                        "56",
                                        0x2f
                                    },
                                    {
                                        "57",
                                        0x30
                                    },
                                    {
                                        "58",
                                        0x31
                                    },
                                    {
                                        "59",
                                        50
                                    },
                                    {
                                        "60",
                                        0x33
                                    },
                                    {
                                        "61",
                                        0x34
                                    },
                                    {
                                        "62",
                                        0x35
                                    },
                                    {
                                        "63",
                                        0x36
                                    },
                                    {
                                        "64",
                                        0x37
                                    },
                                    {
                                        "65",
                                        0x38
                                    },
                                    {
                                        "66",
                                        0x39
                                    },
                                    {
                                        "67",
                                        0x3a
                                    },
                                    {
                                        "68",
                                        0x3b
                                    },
                                    {
                                        "69",
                                        60
                                    },
                                    {
                                        "70",
                                        0x3d
                                    },
                                    {
                                        "71",
                                        0x3e
                                    },
                                    {
                                        "72",
                                        0x3f
                                    },
                                    {
                                        "73",
                                        0x40
                                    },
                                    {
                                        "74",
                                        0x41
                                    },
                                    {
                                        "75",
                                        0x42
                                    },
                                    {
                                        "76",
                                        0x43
                                    },
                                    {
                                        "77",
                                        0x44
                                    },
                                    {
                                        "78",
                                        0x45
                                    },
                                    {
                                        "79",
                                        70
                                    },
                                    {
                                        "80",
                                        0x47
                                    },
                                    {
                                        "81",
                                        0x48
                                    },
                                    {
                                        "82",
                                        0x49
                                    },
                                    {
                                        "83",
                                        0x4a
                                    },
                                    {
                                        "84",
                                        0x4b
                                    },
                                    {
                                        "85",
                                        0x4c
                                    },
                                    {
                                        "86",
                                        0x4d
                                    },
                                    {
                                        "87",
                                        0x4e
                                    },
                                    {
                                        "88",
                                        0x4f
                                    },
                                    {
                                        "89",
                                        80
                                    }
                                };
                                                      dictionary_0 = dictionary1;
                                                }
                                                if (dictionary_0.TryGetValue(str2, out num3))
                                                {
                                                      switch (num3)
                                                      {
                                                            case 0:
                                                                  this.Item_thuoc_tinh_toan_bo_khi_cong_thu_bac_tang_cuong += num;
                                                                  break;

                                                            case 1:
                                                                  this.Item_thuoc_tinh_them_vao_dao_khach_Luc_phach_hoa_son += num;
                                                                  break;

                                                            case 2:
                                                                  this.Item_thuoc_tinh_them_vao_dao_khach_Nhiep_hon_nhat_kich += num;
                                                                  break;

                                                            case 3:
                                                                  this.Item_thuoc_tinh_them_vao_dao_khach_Lien_hoan_phi_vu += num;
                                                                  this.Item_thuoc_tinh_them_vao_kiem_khach_Lien_hoan_phi_vu += num;
                                                                  this.Item_thuoc_tinh_them_vao_thuong_khach_Lien_hoan_phi_vu += num;
                                                                  this.Item_thuoc_tinh_them_vao_thich_khach_Lien_hoan_phi_vu += num;
                                                                  break;

                                                            case 4:
                                                                  this.Item_thuoc_tinh_them_vao_dao_khach_Tat_sat_nhat_kich += num;
                                                                  this.Item_thuoc_tinh_them_vao_kiem_khach_Tat_sat_nhat_kich += num;
                                                                  this.Item_thuoc_tinh_them_vao_thuong_khach_Tat_sat_nhat_kich += num;
                                                                  this.Item_thuoc_tinh_them_vao_cung_thu_Tat_sat_nhat_kich += num;
                                                                  this.Item_thuoc_tinh_them_vao_thich_khach_Tat_sat_nhat_kich += num;
                                                                  break;

                                                            case 5:
                                                                  this.Item_thuoc_tinh_them_vao_dao_khach_Cuong_phong_van_pha += num;
                                                                  this.Item_thuoc_tinh_them_vao_kiem_khach_Cuong_phong_van_pha += num;
                                                                  this.Item_thuoc_tinh_them_vao_thuong_khach_Cuong_phong_van_pha += num;
                                                                  this.Item_thuoc_tinh_them_vao_cung_thu_Cuong_phong_van_pha += num;
                                                                  break;

                                                            case 6:
                                                                  this.Item_thuoc_tinh_them_vao_dao_khach_Tu_luong_thien_can += num;
                                                                  break;

                                                            case 7:
                                                                  this.Item_thuoc_tinh_them_vao_dao_khach_Phach_khi_pha_giap += num;
                                                                  break;

                                                            case 8:
                                                                  this.Item_thuoc_tinh_them_vao_dao_khach_Chan_vu_tuyet_kich += num;
                                                                  break;

                                                            case 9:
                                                                  this.Item_thuoc_tinh_them_vao_dao_khach_Am_anh_tuyet_sat += num;
                                                                  break;

                                                            case 10:
                                                                  this.Item_thuoc_tinh_them_vao_dao_khach_On_nhu_thai_son += num;
                                                                  break;

                                                            case 11:
                                                                  this.Item_thuoc_tinh_them_vao_kiem_khach_Truong_hong_quan_nhat += num;
                                                                  break;

                                                            case 12:
                                                                  this.Item_thuoc_tinh_them_vao_kiem_khach_Bach_bien_than_hanh += num;
                                                                  break;

                                                            case 13:
                                                                  this.Item_thuoc_tinh_them_vao_dao_khach_Lien_hoan_phi_vu += num;
                                                                  this.Item_thuoc_tinh_them_vao_kiem_khach_Lien_hoan_phi_vu += num;
                                                                  this.Item_thuoc_tinh_them_vao_thuong_khach_Lien_hoan_phi_vu += num;
                                                                  this.Item_thuoc_tinh_them_vao_thich_khach_Lien_hoan_phi_vu += num;
                                                                  break;

                                                            case 14:
                                                                  this.Item_thuoc_tinh_them_vao_dao_khach_Tat_sat_nhat_kich += num;
                                                                  this.Item_thuoc_tinh_them_vao_kiem_khach_Tat_sat_nhat_kich += num;
                                                                  this.Item_thuoc_tinh_them_vao_thuong_khach_Tat_sat_nhat_kich += num;
                                                                  this.Item_thuoc_tinh_them_vao_cung_thu_Tat_sat_nhat_kich += num;
                                                                  this.Item_thuoc_tinh_them_vao_thich_khach_Tat_sat_nhat_kich += num;
                                                                  break;

                                                            case 15:
                                                                  this.Item_thuoc_tinh_them_vao_dao_khach_Cuong_phong_van_pha += num;
                                                                  this.Item_thuoc_tinh_them_vao_kiem_khach_Cuong_phong_van_pha += num;
                                                                  this.Item_thuoc_tinh_them_vao_thuong_khach_Cuong_phong_van_pha += num;
                                                                  this.Item_thuoc_tinh_them_vao_cung_thu_Cuong_phong_van_pha += num;
                                                                  break;

                                                            case 0x10:
                                                                  this.Item_thuoc_tinh_them_vao_kiem_khach_Ho_than_cuong_khi += num;
                                                                  break;

                                                            case 0x11:
                                                                  this.Item_thuoc_tinh_them_vao_kiem_khach_Di_hoa_tiep_moc += num;
                                                                  break;

                                                            case 0x12:
                                                                  this.Item_thuoc_tinh_them_vao_kiem_khach_Hoi_lieu_than_phap += num;
                                                                  break;

                                                            case 0x13:
                                                                  this.Item_thuoc_tinh_them_vao_kiem_khach_No_hai_cuong_lan += num;
                                                                  break;

                                                            case 20:
                                                                  this.Item_thuoc_tinh_them_vao_kiem_khach_Trung_quan_nhat_no += num;
                                                                  break;

                                                            case 0x15:
                                                                  this.Item_thuoc_tinh_them_vao_thuong_khach_Kim_chung_trao_khi += num;
                                                                  break;

                                                            case 0x16:
                                                                  this.Item_thuoc_tinh_them_vao_thuong_khach_Van_khi_lieu_thuong += num;
                                                                  break;

                                                            case 0x17:
                                                                  this.Item_thuoc_tinh_them_vao_dao_khach_Lien_hoan_phi_vu += num;
                                                                  this.Item_thuoc_tinh_them_vao_kiem_khach_Lien_hoan_phi_vu += num;
                                                                  this.Item_thuoc_tinh_them_vao_thuong_khach_Lien_hoan_phi_vu += num;
                                                                  this.Item_thuoc_tinh_them_vao_thich_khach_Lien_hoan_phi_vu += num;
                                                                  break;

                                                            case 0x18:
                                                                  this.Item_thuoc_tinh_them_vao_dao_khach_Tat_sat_nhat_kich += num;
                                                                  this.Item_thuoc_tinh_them_vao_kiem_khach_Tat_sat_nhat_kich += num;
                                                                  this.Item_thuoc_tinh_them_vao_thuong_khach_Tat_sat_nhat_kich += num;
                                                                  this.Item_thuoc_tinh_them_vao_cung_thu_Tat_sat_nhat_kich += num;
                                                                  this.Item_thuoc_tinh_them_vao_thich_khach_Tat_sat_nhat_kich += num;
                                                                  break;

                                                            case 0x19:
                                                                  this.Item_thuoc_tinh_them_vao_dao_khach_Cuong_phong_van_pha += num;
                                                                  this.Item_thuoc_tinh_them_vao_kiem_khach_Cuong_phong_van_pha += num;
                                                                  this.Item_thuoc_tinh_them_vao_thuong_khach_Cuong_phong_van_pha += num;
                                                                  this.Item_thuoc_tinh_them_vao_cung_thu_Cuong_phong_van_pha += num;
                                                                  break;

                                                            case 0x1a:
                                                                  this.Item_thuoc_tinh_them_vao_thuong_khach_Hoanh_luyen_thai_bao += num;
                                                                  break;

                                                            case 0x1b:
                                                                  this.Item_thuoc_tinh_them_vao_thuong_khach_Can_khon_na_di += num;
                                                                  break;

                                                            case 0x1c:
                                                                  this.Item_thuoc_tinh_them_vao_thuong_khach_Linh_giap_ho_than += num;
                                                                  break;

                                                            case 0x1d:
                                                                  this.Item_thuoc_tinh_them_vao_thuong_khach_Cuong_than_hang_the += num;
                                                                  break;

                                                            case 30:
                                                                  this.Item_thuoc_tinh_them_vao_thuong_khach_Chuyen_thu_vi_cong += num;
                                                                  break;

                                                            case 0x1f:
                                                                  this.Item_thuoc_tinh_them_vao_cung_thu_Bach_bo_xuyen_duong += num;
                                                                  break;

                                                            case 0x20:
                                                                  this.Item_thuoc_tinh_them_vao_cung_thu_Liep_ung_chi_nhan += num;
                                                                  break;

                                                            case 0x21:
                                                                  this.Item_thuoc_tinh_them_vao_cung_thu_Ngung_than_tu_khi += num;
                                                                  break;

                                                            case 0x22:
                                                                  this.Item_thuoc_tinh_them_vao_dao_khach_Tat_sat_nhat_kich += num;
                                                                  this.Item_thuoc_tinh_them_vao_kiem_khach_Tat_sat_nhat_kich += num;
                                                                  this.Item_thuoc_tinh_them_vao_thuong_khach_Tat_sat_nhat_kich += num;
                                                                  this.Item_thuoc_tinh_them_vao_cung_thu_Tat_sat_nhat_kich += num;
                                                                  this.Item_thuoc_tinh_them_vao_thich_khach_Tat_sat_nhat_kich += num;
                                                                  break;

                                                            case 0x23:
                                                                  this.Item_thuoc_tinh_them_vao_dao_khach_Cuong_phong_van_pha += num;
                                                                  this.Item_thuoc_tinh_them_vao_kiem_khach_Cuong_phong_van_pha += num;
                                                                  this.Item_thuoc_tinh_them_vao_thuong_khach_Cuong_phong_van_pha += num;
                                                                  this.Item_thuoc_tinh_them_vao_cung_thu_Cuong_phong_van_pha += num;
                                                                  break;

                                                            case 0x24:
                                                                  this.Item_thuoc_tinh_them_vao_cung_thu_Chinh_ban_boi_nguyen += num;
                                                                  break;

                                                            case 0x25:
                                                                  this.Item_thuoc_tinh_them_vao_thich_khach_Tam_than_ngung_tu += num;
                                                                  this.Item_thuoc_tinh_them_vao_cung_thu_Tam_than_ngung_tu += num;
                                                                  break;

                                                            case 0x26:
                                                                  this.Item_thuoc_tinh_them_vao_cung_thu_Luu_tinh_tam_thi += num;
                                                                  break;

                                                            case 0x27:
                                                                  this.Item_thuoc_tinh_them_vao_cung_thu_Due_loi_chi_tien += num;
                                                                  break;

                                                            case 40:
                                                                  this.Item_thuoc_tinh_them_vao_cung_thu_Vo_minh_am_thi += num;
                                                                  break;

                                                            case 0x29:
                                                                  this.Item_thuoc_tinh_them_vao_Y_van_khi_hanh_tam += num;
                                                                  break;

                                                            case 0x2a:
                                                                  this.Item_thuoc_tinh_them_vao_Y_thai_cuc_tam_phap += num;
                                                                  break;

                                                            case 0x2b:
                                                                  this.Item_thuoc_tinh_them_vao_Y_the_huyet_boi_tang += num;
                                                                  break;

                                                            case 0x2c:
                                                                  this.Item_thuoc_tinh_them_vao_Y_tay_tuy_dich_kinh += num;
                                                                  break;

                                                            case 0x2d:
                                                                  this.Item_thuoc_tinh_them_vao_y_Dieu_thu_hoi_xuan += num;
                                                                  break;

                                                            case 0x2e:
                                                                  this.Item_thuoc_tinh_them_vao_Y_Truong_cong_cong_kich += num;
                                                                  break;

                                                            case 0x2f:
                                                                  this.Item_thuoc_tinh_them_vao_Y_hap_tinh_dai_phap += num;
                                                                  break;

                                                            case 0x30:
                                                                  this.Item_thuoc_tinh_them_vao_y_Than_Nong_tien_thuat += num;
                                                                  break;

                                                            case 0x31:
                                                                  this.Item_thuoc_tinh_them_vao_Y_thien_huu_khi += num;
                                                                  break;

                                                            case 50:
                                                                  this.Item_thuoc_tinh_them_vao_Y_Cuu_thien_chan_khi += num;
                                                                  break;

                                                            case 0x33:
                                                                  this.Item_thuoc_tinh_them_vao_kiem_khach_Truong_hong_quan_nhat += num;
                                                                  this.Item_thuoc_tinh_them_vao_dao_khach_Luc_phach_hoa_son += num;
                                                                  break;

                                                            case 0x34:
                                                                  this.Item_thuoc_tinh_them_vao_dao_khach_Nhiep_hon_nhat_kich += num;
                                                                  break;

                                                            case 0x35:
                                                                  this.Item_thuoc_tinh_them_vao_dao_khach_Lien_hoan_phi_vu += num;
                                                                  this.Item_thuoc_tinh_them_vao_kiem_khach_Lien_hoan_phi_vu += num;
                                                                  this.Item_thuoc_tinh_them_vao_thuong_khach_Lien_hoan_phi_vu += num;
                                                                  this.Item_thuoc_tinh_them_vao_thich_khach_Lien_hoan_phi_vu += num;
                                                                  break;

                                                            case 0x36:
                                                                  this.Item_thuoc_tinh_them_vao_dao_khach_Tat_sat_nhat_kich += num;
                                                                  this.Item_thuoc_tinh_them_vao_kiem_khach_Tat_sat_nhat_kich += num;
                                                                  this.Item_thuoc_tinh_them_vao_thuong_khach_Tat_sat_nhat_kich += num;
                                                                  this.Item_thuoc_tinh_them_vao_cung_thu_Tat_sat_nhat_kich += num;
                                                                  this.Item_thuoc_tinh_them_vao_thich_khach_Tat_sat_nhat_kich += num;
                                                                  break;

                                                            case 0x37:
                                                                  this.Item_thuoc_tinh_them_vao_dao_khach_Cuong_phong_van_pha += num;
                                                                  this.Item_thuoc_tinh_them_vao_kiem_khach_Cuong_phong_van_pha += num;
                                                                  this.Item_thuoc_tinh_them_vao_thuong_khach_Cuong_phong_van_pha += num;
                                                                  this.Item_thuoc_tinh_them_vao_cung_thu_Cuong_phong_van_pha += num;
                                                                  break;

                                                            case 0x38:
                                                                  this.Item_thuoc_tinh_them_vao_thich_khach_Tam_than_ngung_tu += num;
                                                                  this.Item_thuoc_tinh_them_vao_cung_thu_Tam_than_ngung_tu += num;
                                                                  break;

                                                            case 0x39:
                                                                  this.Item_thuoc_tinh_them_vao_dao_khach_Phach_khi_pha_giap += num;
                                                                  break;

                                                            case 0x3a:
                                                                  this.Item_thuoc_tinh_them_vao_dao_khach_Chan_vu_tuyet_kich += num;
                                                                  break;

                                                            case 0x3b:
                                                                  this.Item_thuoc_tinh_them_vao_dao_khach_Am_anh_tuyet_sat += num;
                                                                  break;

                                                            case 60:
                                                                  this.Item_thuoc_tinh_them_vao_dao_khach_On_nhu_thai_son += num;
                                                                  break;

                                                            case 0x3d:
                                                                  this.Item_thuoc_tinh_them_vao_thich_khach_Kinh_kha_chi_no += num;
                                                                  break;

                                                            case 0x3e:
                                                                  this.Item_thuoc_tinh_them_vao_thich_khach_Tam_hoa_tu_dinh += num;
                                                                  break;

                                                            case 0x3f:
                                                                  this.Item_thuoc_tinh_them_vao_dao_khach_Lien_hoan_phi_vu += num;
                                                                  this.Item_thuoc_tinh_them_vao_kiem_khach_Lien_hoan_phi_vu += num;
                                                                  this.Item_thuoc_tinh_them_vao_thuong_khach_Lien_hoan_phi_vu += num;
                                                                  this.Item_thuoc_tinh_them_vao_thich_khach_Lien_hoan_phi_vu += num;
                                                                  break;

                                                            case 0x40:
                                                                  this.Item_thuoc_tinh_them_vao_dao_khach_Tat_sat_nhat_kich += num;
                                                                  this.Item_thuoc_tinh_them_vao_kiem_khach_Tat_sat_nhat_kich += num;
                                                                  this.Item_thuoc_tinh_them_vao_thuong_khach_Tat_sat_nhat_kich += num;
                                                                  this.Item_thuoc_tinh_them_vao_cung_thu_Tat_sat_nhat_kich += num;
                                                                  this.Item_thuoc_tinh_them_vao_thich_khach_Tat_sat_nhat_kich += num;
                                                                  break;

                                                            case 0x41:
                                                                  this.Item_thuoc_tinh_them_vao_thich_khach_Tam_than_ngung_tu += num;
                                                                  this.Item_thuoc_tinh_them_vao_cung_thu_Tam_than_ngung_tu += num;
                                                                  break;

                                                            case 0x42:
                                                                  this.Item_thuoc_tinh_them_vao_dao_khach_Tri_menh_tuyet_thu += num;
                                                                  break;

                                                            case 0x43:
                                                                  this.Item_thuoc_tinh_them_vao_thich_khach_Tien_phat_che_nhan += num;
                                                                  break;

                                                            case 0x44:
                                                                  this.Item_thuoc_tinh_them_vao_thich_khach_Thien_chu_van_thu += num;
                                                                  break;

                                                            case 0x45:
                                                                  this.Item_thuoc_tinh_them_vao_thich_khach_Lien_tieu_dai_da += num;
                                                                  break;

                                                            case 70:
                                                                  this.Item_thuoc_tinh_them_vao_thich_khach_Kiem_nhan_loan_vu += num;
                                                                  break;

                                                            case 0x47:
                                                                  this.Item_thuoc_tinh_them_vao_cam_su_Chien_ma_bon_dang += num;
                                                                  break;

                                                            case 0x48:
                                                                  this.Item_thuoc_tinh_them_vao_cam_su_Thu_giang_da_bac += num;
                                                                  break;

                                                            case 0x49:
                                                                  this.Item_thuoc_tinh_them_vao_cam_su_Thanh_tam_pho_thien += num;
                                                                  break;

                                                            case 0x4a:
                                                                  this.Item_thuoc_tinh_them_vao_cam_su_Duong_quan_tam_diep += num;
                                                                  break;

                                                            case 0x4b:
                                                                  this.Item_thuoc_tinh_them_vao_cam_su_Han_cung_thu_nguyet += num;
                                                                  break;

                                                            case 0x4c:
                                                                  this.Item_thuoc_tinh_them_vao_Cam_su_Tam_khuc_hoa_minh += num;
                                                                  break;

                                                            case 0x4d:
                                                                  this.Item_thuoc_tinh_them_vao_Cam_su_Cam_thanh_qua_nguyet += num;
                                                                  break;

                                                            case 0x4e:
                                                                  this.Item_thuoc_tinh_them_vao_Cam_su_Nhat_am_xuat_kich += num;
                                                                  break;

                                                            case 0x4f:
                                                                  this.Item_thuoc_tinh_them_vao_cam_su_Loan_phuong_hoa_minh += num;
                                                                  break;

                                                            case 80:
                                                                  this.Item_thuoc_tinh_them_vao_Cam_su_Sat_am_cam_khuc += num;
                                                                  break;
                                                      }
                                                }
                                          }
                                          return;
                                    }
                              case 9:
                                    this.Item_thuoc_tinh_thang_cap_ty_le_thanh_cong += num;
                                    return;

                              case 10:
                                    this.Item_thuoc_tinh_them_vao_muc_ton_thuong += num;
                                    return;

                              case 11:
                                    this.Item_thuoc_tinh_suc_phong_ngu_vo_cong_tang_cuong += num;
                                    return;

                              case 12:
                                    this.Item_thuoc_tinh_thu_duoc_tien_tai_tang_cuong += num;
                                    return;

                              case 13:
                                    this.Item_thuoc_tinh_Tu_vong_ton_that_kinh_nghiem_giam_thieu += num;
                                    return;

                              case 14:
                                    return;

                              case 15:
                                    this.Item_thuoc_tinh_kinh_nghiem_thu_duoc_gia_tang += num;
                                    break;

                              default:
                                    return;
                        }
                        this.Item_thuoc_tinh_kinh_nghiem_thu_duoc_gia_tang += num;
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "HOAN_THANH_CO_BAN_THUOC_TINH 出错：" + exception);
                  }
            }

            public void HOAN_THANH_VAT_PHAM_CO_BAN_LUC_CONG_KICH()
            {
                  try
                  {
                        if (BitConverter.ToInt32(this.VAT_PHAM_ID, 0) != 0)
                        {
                              TBL_XWWL_ITEM tbl_xwwl_item = World.Itme[BitConverter.ToInt32(this.VAT_PHAM_ID, 0)];
                              this.FLD_RESIDE2 = tbl_xwwl_item.FLD_RESIDE2;
                              if (this.FLD_FJ_tien_hoa == 0)
                              {
                                    this.Item_luc_cong_kich = tbl_xwwl_item.FLD_AT;
                                    this.Item_luc_cong_kich_MAX = tbl_xwwl_item.FLD_AT_Max;
                                    this.Item_suc_phong_ngu = tbl_xwwl_item.FLD_DF;
                              }
                              else if (this.FLD_FJ_tien_hoa == 1)
                              {
                                    this.Item_luc_cong_kich = tbl_xwwl_item.FLD_AT + ((long)(tbl_xwwl_item.FLD_AT * 0.05));
                                    this.Item_luc_cong_kich_MAX = tbl_xwwl_item.FLD_AT_Max + ((long)(tbl_xwwl_item.FLD_AT_Max * 0.05));
                                    this.Item_suc_phong_ngu = tbl_xwwl_item.FLD_DF + ((long)(tbl_xwwl_item.FLD_DF * 0.05));
                              }
                              else if (this.FLD_FJ_tien_hoa == 2)
                              {
                                    this.Item_luc_cong_kich = tbl_xwwl_item.FLD_AT + ((long)(tbl_xwwl_item.FLD_AT * 0.08));
                                    this.Item_luc_cong_kich_MAX = tbl_xwwl_item.FLD_AT_Max + ((long)(tbl_xwwl_item.FLD_AT_Max * 0.08));
                                    this.Item_suc_phong_ngu = tbl_xwwl_item.FLD_DF + ((long)(tbl_xwwl_item.FLD_DF * 0.08));
                              }
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "HOAN_THANH_VAT_PHAM_CO_BAN_LUC_CONG_KICH 出错：" + exception);
                  }
            }

            public byte[] method_0()
            {
                  PacketData data = new PacketData();
                  data.method_9(this.GetItem_toan_bo_ID);
                  if (this.Item_troi_chat)
                  {
                        data.method_9(this.GetItem_ID + 0x4e20L);
                  }
                  else
                  {
                        data.method_9(this.GetItem_ID);
                  }
                  data.Write4(this.Get_VAT_PHAM_SO_LUONG);
                  data.Write4(this.FLD_MAGIC0);
                  data.Write4(this.FLD_MAGIC1);
                  data.Write4(this.FLD_MAGIC2);
                  data.Write4(this.FLD_MAGIC3);
                  data.Write4(this.FLD_MAGIC4);
                  data.Write2(this.FLD_FJ_MAGIC0);
                  data.Write2(this.FLD_FJ_MAGIC1);
                  data.Write2(this.FLD_FJ_trung_cap_phu_hon);
                  data.Write2(this.FLD_FJ_MAGIC2);
                  data.Write2(this.FLD_FJ_MAGIC3);
                  data.Write2(this.FLD_FJ_MAGIC4);
                  data.Write2(this.FLD_FJ_MAGIC5);
                  data.Write2(0);
                  data.Write4(this.FLD_FJ_KSSJ);
                  data.Write4(this.FLD_FJ_JSSJ);
                  if (this.FLD_keo_dai_suc_manh != 0)
                  {
                        data.Write2(this.FLD_keo_dai_suc_manh);
                  }
                  else
                  {
                        data.Write2(0);
                  }
                  data.Write4(this.FLD_FJ_thuc_tinh + this.Item_trung_cap_phu_hon_them_vao_thuc_tinh);
                  data.Write2(0);
                  data.Write2(this.FLD_FJ_tien_hoa);
                  data.Write4(0);
                  data.Write4(0);
                  data.Write4(0);
                  data.Write2(0);
                  return data.method_17();
            }

            public string method_1()
            {
                  try
                  {
                        return Converter.smethod_24(this.Item_byte);
                  }
                  catch
                  {
                        return "";
                  }
            }

            public void method_10(byte[] byte_1)
            {
                  Buffer.BlockCopy(byte_1, 0, this.Item_byte, 0x10, 4);
            }

            public int method_11()
            {
                  int num = BitConverter.ToInt32(this.method_6(), 0);
                  return World.Itme[num].FLD_SIDE;
            }

            public int method_12()
            {
                  TBL_XWWL_ITEM tbl_xwwl_item;
                  byte[] buffer = this.method_6();
                  if (World.Itme.TryGetValue(BitConverter.ToInt32(buffer, 0), out tbl_xwwl_item))
                  {
                        return tbl_xwwl_item.FLD_RESIDE2;
                  }
                  return 0;
            }

            public string method_13()
            {
                  TBL_XWWL_ITEM tbl_xwwl_item;
                  if (World.Itme.TryGetValue(BitConverter.ToInt32(this.VAT_PHAM_ID, 0), out tbl_xwwl_item))
                  {
                        return tbl_xwwl_item.ItmeNAME;
                  }
                  return "";
            }

            private void method_14()
            {
                  this.Item_luc_cong_kich = 0L;
                  this.Item_luc_cong_kich_MAX = 0L;
                  this.Item_thuoc_tinh_Luc_cong_kich_tang_cuong = 0;
                  this.Item_suc_phong_ngu = 0L;
                  this.Item_thuoc_tinh_Suc_phong_ngu_tang_cuong = 0;
                  this.Item_thuoc_tinh_sinh_menh_tang_cuong = 0;
                  this.Item_thuoc_tinh_hanh_ly_mang_nang = 0.0;
                  this.Item_thuoc_tinh_Noi_cong_suc_manh_tang_cuong = 0;
                  this.Item_thuoc_tinh_Ti_le_trung_muc_tieu_tang_cuong = 0;
                  this.Item_thuoc_tinh_ne_tranh_xac_xuat_tang_cuong = 0;
                  this.Item_thuoc_tinh_Luc_cong_kich_vo_cong = 0;
                  this.Item_thuoc_tinh_toan_bo_khi_cong_thu_bac_tang_cuong = 0;
                  this.Item_thuoc_tinh_thang_cap_ty_le_thanh_cong = 0.0;
                  this.Item_thuoc_tinh_them_vao_muc_ton_thuong = 0;
                  this.Item_thuoc_tinh_suc_phong_ngu_vo_cong_tang_cuong = 0;
                  this.Item_thuoc_tinh_thu_duoc_tien_tai_tang_cuong = 0.0;
                  this.Item_thuoc_tinh_Tu_vong_ton_that_kinh_nghiem_giam_thieu = 0;
                  this.Item_thuoc_tinh_kinh_nghiem_thu_duoc_gia_tang = 0.0;
                  this.Item_trung_cap_phu_hon_them_vao_thuc_tinh = 0;
                  this.FLD_RESIDE2 = 0;
                  this.Item_thuoc_tinh_them_vao_Y_Truong_cong_cong_kich = 0;
                  this.Item_thuoc_tinh_them_vao_Y_van_khi_hanh_tam = 0;
                  this.Item_thuoc_tinh_them_vao_Y_tay_tuy_dich_kinh = 0;
                  this.Item_thuoc_tinh_them_vao_Y_hap_tinh_dai_phap = 0;
                  this.Item_thuoc_tinh_them_vao_Y_thien_huu_khi = 0;
                  this.Item_thuoc_tinh_them_vao_Y_the_huyet_boi_tang = 0;
                  this.Item_thuoc_tinh_them_vao_Y_thai_cuc_tam_phap = 0;
                  this.Item_thuoc_tinh_them_vao_y_Than_Nong_tien_thuat = 0;
                  this.Item_thuoc_tinh_them_vao_y_Dieu_thu_hoi_xuan = 0;
                  this.Item_thuoc_tinh_them_vao_Y_Cuu_thien_chan_khi = 0;
                  this.Item_thuoc_tinh_them_vao_cam_su_Chien_ma_bon_dang = 0;
                  this.Item_thuoc_tinh_them_vao_Cam_su_Cam_thanh_qua_nguyet = 0;
                  this.Item_thuoc_tinh_them_vao_Cam_su_Sat_am_cam_khuc = 0;
                  this.Item_thuoc_tinh_them_vao_cam_su_Duong_quan_tam_diep = 0;
                  this.Item_thuoc_tinh_them_vao_cam_su_Thu_giang_da_bac = 0;
                  this.Item_thuoc_tinh_them_vao_cam_su_Thanh_tam_pho_thien = 0;
                  this.Item_thuoc_tinh_them_vao_Cam_su_Nhat_am_xuat_kich = 0;
                  this.Item_thuoc_tinh_them_vao_cam_su_Loan_phuong_hoa_minh = 0;
                  this.Item_thuoc_tinh_them_vao_cam_su_Han_cung_thu_nguyet = 0;
                  this.Item_thuoc_tinh_them_vao_Cam_su_Tam_khuc_hoa_minh = 0;
                  this.Item_thuoc_tinh_them_vao_thuong_khach_Chuyen_thu_vi_cong = 0;
                  this.Item_thuoc_tinh_them_vao_thuong_khach_Van_khi_lieu_thuong = 0;
                  this.Item_thuoc_tinh_them_vao_thuong_khach_Can_khon_na_di = 0;
                  this.Item_thuoc_tinh_them_vao_thuong_khach_Linh_giap_ho_than = 0;
                  this.Item_thuoc_tinh_them_vao_thuong_khach_Lien_hoan_phi_vu = 0;
                  this.Item_thuoc_tinh_them_vao_thuong_khach_Cuong_than_hang_the = 0;
                  this.Item_thuoc_tinh_them_vao_thuong_khach_Cuong_phong_van_pha = 0;
                  this.Item_thuoc_tinh_them_vao_thuong_khach_Kim_chung_trao_khi = 0;
                  this.Item_thuoc_tinh_them_vao_thuong_khach_Hoanh_luyen_thai_bao = 0;
                  this.Item_thuoc_tinh_them_vao_thuong_khach_Tat_sat_nhat_kich = 0;
                  this.Item_thuoc_tinh_them_vao_kiem_khach_Truong_hong_quan_nhat = 0;
                  this.Item_thuoc_tinh_them_vao_kiem_khach_Di_hoa_tiep_moc = 0;
                  this.Item_thuoc_tinh_them_vao_kiem_khach_No_hai_cuong_lan = 0;
                  this.Item_thuoc_tinh_them_vao_kiem_khach_Lien_hoan_phi_vu = 0;
                  this.Item_thuoc_tinh_them_vao_kiem_khach_Cuong_phong_van_pha = 0;
                  this.Item_thuoc_tinh_them_vao_kiem_khach_Hoi_lieu_than_phap = 0;
                  this.Item_thuoc_tinh_them_vao_kiem_khach_Ho_than_cuong_khi = 0;
                  this.Item_thuoc_tinh_them_vao_kiem_khach_Trung_quan_nhat_no = 0;
                  this.Item_thuoc_tinh_them_vao_kiem_khach_Tat_sat_nhat_kich = 0;
                  this.Item_thuoc_tinh_them_vao_kiem_khach_Bach_bien_than_hanh = 0;
                  this.Item_thuoc_tinh_them_vao_cung_thu_Chinh_ban_boi_nguyen = 0;
                  this.Item_thuoc_tinh_them_vao_cung_thu_Tam_than_ngung_tu = 0;
                  this.Item_thuoc_tinh_them_vao_cung_thu_Vo_minh_am_thi = 0;
                  this.Item_thuoc_tinh_them_vao_cung_thu_Due_loi_chi_tien = 0;
                  this.Item_thuoc_tinh_them_vao_cung_thu_Ngung_than_tu_khi = 0;
                  this.Item_thuoc_tinh_them_vao_cung_thu_Luu_tinh_tam_thi = 0;
                  this.Item_thuoc_tinh_them_vao_cung_thu_Liep_ung_chi_nhan = 0;
                  this.Item_thuoc_tinh_them_vao_cung_thu_Cuong_phong_van_pha = 0;
                  this.Item_thuoc_tinh_them_vao_cung_thu_Tat_sat_nhat_kich = 0;
                  this.Item_thuoc_tinh_them_vao_cung_thu_Bach_bo_xuyen_duong = 0;
                  this.Item_thuoc_tinh_them_vao_dao_khach_Chan_vu_tuyet_kich = 0;
                  this.Item_thuoc_tinh_them_vao_dao_khach_On_nhu_thai_son = 0;
                  this.Item_thuoc_tinh_them_vao_dao_khach_Tu_luong_thien_can = 0;
                  this.Item_thuoc_tinh_them_vao_dao_khach_Nhiep_hon_nhat_kich = 0;
                  this.Item_thuoc_tinh_them_vao_dao_khach_Lien_hoan_phi_vu = 0;
                  this.Item_thuoc_tinh_them_vao_dao_khach_Luc_phach_hoa_son = 0;
                  this.Item_thuoc_tinh_them_vao_dao_khach_Cuong_phong_van_pha = 0;
                  this.Item_thuoc_tinh_them_vao_dao_khach_Tat_sat_nhat_kich = 0;
                  this.Item_thuoc_tinh_them_vao_dao_khach_Phach_khi_pha_giap = 0;
                  this.Item_thuoc_tinh_them_vao_dao_khach_Am_anh_tuyet_sat = 0;
                  this.Item_thuoc_tinh_them_vao_dao_khach_Tri_menh_tuyet_thu = 0;
                  this.Item_thuoc_tinh_them_vao_thich_khach_Tam_than_ngung_tu = 0;
                  this.Item_thuoc_tinh_them_vao_thich_khach_Tien_phat_che_nhan = 0;
                  this.Item_thuoc_tinh_them_vao_thich_khach_Tam_hoa_tu_dinh = 0;
                  this.Item_thuoc_tinh_them_vao_thich_khach_Thien_chu_van_thu = 0;
                  this.Item_thuoc_tinh_them_vao_thich_khach_Lien_tieu_dai_da = 0;
                  this.Item_thuoc_tinh_them_vao_thich_khach_Lien_hoan_phi_vu = 0;
                  this.Item_thuoc_tinh_them_vao_thich_khach_Kinh_kha_chi_no = 0;
                  this.Item_thuoc_tinh_them_vao_thich_khach_Kiem_nhan_loan_vu = 0;
                  this.Item_thuoc_tinh_them_vao_thich_khach_Tat_sat_nhat_kich = 0;
            }

            public void method_15()
            {
                  try
                  {
                        this.method_14();
                        if (BitConverter.ToInt32(this.VAT_PHAM_ID, 0) != 0)
                        {
                              this.HOAN_THANH_VAT_PHAM_CO_BAN_LUC_CONG_KICH();
                              byte[] dst = new byte[4];
                              Buffer.BlockCopy(this.Item_byte, 0x10, dst, 0, 4);
                              this.method_18(BitConverter.ToInt32(dst, 0).ToString());
                              for (int i = 0; i < 4; i++)
                              {
                                    byte[] buffer2 = new byte[4];
                                    Buffer.BlockCopy(this.Item_byte, 20 + (i * 4), buffer2, 0, 4);
                                    this.HOAN_THANH_CO_BAN_THUOC_TINH(BitConverter.ToInt32(buffer2, 0).ToString());
                              }
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "得到Item_thuoc_tinh方法 出错：" + exception);
                  }
            }

            private void method_18(string string_1)
            {
                  try
                  {
                        TBL_XWWL_ITEM tbl_xwwl_item;
                        int num;
                        switch (string_1.Length)
                        {
                              case 8:
                                    this.VAT_PHAM_THUOC_TINH_CUONG_HOA_LOAI_HINH = int.Parse(string_1.Substring(string_1.Length - 8, 1));
                                    this.VAT_PHAM_THUOC_TINH_TANG_CUONG = int.Parse(string_1.Substring(string_1.Length - 2, 2));
                                    if (this.VAT_PHAM_THUOC_TINH_CUONG_HOA_LOAI_HINH != 1)
                                    {
                                          goto Label_0422;
                                    }
                                    if (((this.FLD_RESIDE2 == 7) || (this.FLD_RESIDE2 == 8)) || (this.FLD_RESIDE2 == 10))
                                    {
                                          goto Label_0234;
                                    }
                                    break;

                              case 9:
                                    return;

                              case 10:
                                    this.ItemPropertyType = int.Parse(string_1.Substring(string_1.Length - 4, 1));
                                    this.ItemPropertyNumber = int.Parse(string_1.Substring(string_1.Length - 3, 1)) + 1;
                                    this.VAT_PHAM_THUOC_TINH_CUONG_HOA_LOAI_HINH = int.Parse(string_1.Substring(string_1.Length - 8, 1));
                                    this.VAT_PHAM_THUOC_TINH_TANG_CUONG = int.Parse(string_1.Substring(string_1.Length - 2, 2));
                                    if (this.VAT_PHAM_THUOC_TINH_CUONG_HOA_LOAI_HINH != 1)
                                    {
                                          goto Label_0D80;
                                    }
                                    this.Item_luc_cong_kich += this.VAT_PHAM_THUOC_TINH_TANG_CUONG * 6;
                                    this.Item_luc_cong_kich_MAX += this.VAT_PHAM_THUOC_TINH_TANG_CUONG * 6;
                                    if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG > 5)
                                    {
                                          this.Item_luc_cong_kich += (this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 5) * 2;
                                          this.Item_luc_cong_kich_MAX += (this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 5) * 2;
                                    }
                                    if ((this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 10) && (this.FLD_RESIDE2 == 4))
                                    {
                                          num = this.Item_thuoc_tinh_toan_bo_khi_cong_thu_bac_tang_cuong;
                                          this.Item_thuoc_tinh_toan_bo_khi_cong_thu_bac_tang_cuong = num + 1;
                                    }
                                    else if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 15)
                                    {
                                          int num1 = this.FLD_RESIDE2;
                                    }
                                    return;

                              default:
                                    return;
                        }
                        this.Item_luc_cong_kich += this.VAT_PHAM_THUOC_TINH_TANG_CUONG * 6;
                        this.Item_luc_cong_kich_MAX += this.VAT_PHAM_THUOC_TINH_TANG_CUONG * 6;
                        if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG > 5)
                        {
                              this.Item_luc_cong_kich += (this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 5) * 2;
                              this.Item_luc_cong_kich_MAX += (this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 5) * 2;
                        }
                        if ((this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 10) && (this.FLD_RESIDE2 == 4))
                        {
                              num = this.Item_thuoc_tinh_toan_bo_khi_cong_thu_bac_tang_cuong;
                              this.Item_thuoc_tinh_toan_bo_khi_cong_thu_bac_tang_cuong = num + 1;
                        }
                        return;
                        Label_0234:
                        if (World.Itme.TryGetValue(BitConverter.ToInt32(this.VAT_PHAM_ID, 0), out tbl_xwwl_item))
                        {
                              if (tbl_xwwl_item.FLD_LEVEL >= 100)
                              {
                                    if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG < 4)
                                    {
                                          this.Item_luc_cong_kich += this.VAT_PHAM_THUOC_TINH_TANG_CUONG * 5;
                                          this.Item_luc_cong_kich_MAX += this.VAT_PHAM_THUOC_TINH_TANG_CUONG * 5;
                                    }
                                    else
                                    {
                                          this.Item_luc_cong_kich += 15L;
                                          this.Item_luc_cong_kich_MAX += 15L;
                                          this.Item_luc_cong_kich += (this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 3) * 9;
                                          this.Item_luc_cong_kich_MAX += (this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 3) * 9;
                                    }
                              }
                              else if (tbl_xwwl_item.FLD_LEVEL >= 80)
                              {
                                    if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG < 4)
                                    {
                                          this.Item_luc_cong_kich += this.VAT_PHAM_THUOC_TINH_TANG_CUONG * 3;
                                          this.Item_luc_cong_kich_MAX += this.VAT_PHAM_THUOC_TINH_TANG_CUONG * 3;
                                    }
                                    else
                                    {
                                          this.Item_luc_cong_kich += 9L;
                                          this.Item_luc_cong_kich_MAX += 9L;
                                          this.Item_luc_cong_kich += (this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 3) * 5;
                                          this.Item_luc_cong_kich_MAX += (this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 3) * 5;
                                    }
                              }
                              else if (tbl_xwwl_item.FLD_LEVEL >= 60)
                              {
                                    if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG < 4)
                                    {
                                          this.Item_luc_cong_kich += this.VAT_PHAM_THUOC_TINH_TANG_CUONG * 2;
                                          this.Item_luc_cong_kich_MAX += this.VAT_PHAM_THUOC_TINH_TANG_CUONG * 2;
                                    }
                                    else
                                    {
                                          this.Item_luc_cong_kich += 6L;
                                          this.Item_luc_cong_kich_MAX += 6L;
                                          this.Item_luc_cong_kich += (this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 3) * 3;
                                          this.Item_luc_cong_kich_MAX += (this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 3) * 3;
                                    }
                              }
                        }
                        return;
                        Label_0422:
                        if (this.VAT_PHAM_THUOC_TINH_CUONG_HOA_LOAI_HINH == 2)
                        {
                              if (((this.FLD_RESIDE2 != 7) && (this.FLD_RESIDE2 != 8)) && (this.FLD_RESIDE2 != 10))
                              {
                                    if (this.FLD_RESIDE2 == 1)
                                    {
                                          TBL_XWWL_ITEM tbl_xwwl_item2;
                                          if (World.Itme.TryGetValue(BitConverter.ToInt32(this.VAT_PHAM_ID, 0), out tbl_xwwl_item2))
                                          {
                                                if (tbl_xwwl_item2.FLD_LEVEL <= 50)
                                                {
                                                      if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG != 0)
                                                      {
                                                            if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 1)
                                                            {
                                                                  this.Item_suc_phong_ngu += 3L;
                                                            }
                                                            else if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 2)
                                                            {
                                                                  this.Item_suc_phong_ngu += 9L;
                                                            }
                                                            else if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 3)
                                                            {
                                                                  this.Item_suc_phong_ngu += 0x12L;
                                                            }
                                                            else if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 4)
                                                            {
                                                                  this.Item_suc_phong_ngu += 30L;
                                                            }
                                                            else if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 5)
                                                            {
                                                                  this.Item_suc_phong_ngu += 0x2dL;
                                                            }
                                                            else if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 6)
                                                            {
                                                                  this.Item_suc_phong_ngu += 0x3fL;
                                                                  this.Item_thuoc_tinh_sinh_menh_tang_cuong += (this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 5) * 5;
                                                            }
                                                            else if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 7)
                                                            {
                                                                  this.Item_suc_phong_ngu += 0x54L;
                                                                  this.Item_thuoc_tinh_sinh_menh_tang_cuong += (this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 5) * 5;
                                                            }
                                                            else if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 8)
                                                            {
                                                                  this.Item_suc_phong_ngu += 0x6cL;
                                                                  this.Item_thuoc_tinh_sinh_menh_tang_cuong += (this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 5) * 5;
                                                            }
                                                            else if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 9)
                                                            {
                                                                  this.Item_suc_phong_ngu += 0x87L;
                                                                  this.Item_thuoc_tinh_sinh_menh_tang_cuong += (this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 5) * 5;
                                                            }
                                                            else if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 10)
                                                            {
                                                                  this.Item_suc_phong_ngu += 0xa5L;
                                                                  this.Item_thuoc_tinh_sinh_menh_tang_cuong += ((this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 5) * 5) + 5;
                                                            }
                                                            else
                                                            {
                                                                  this.Item_thuoc_tinh_sinh_menh_tang_cuong += ((this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 5) * 5) + 5;
                                                                  this.Item_suc_phong_ngu += 0xa5 + (this.VAT_PHAM_THUOC_TINH_TANG_CUONG * 3);
                                                            }
                                                      }
                                                }
                                                else if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG != 0)
                                                {
                                                      if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 1)
                                                      {
                                                            this.Item_suc_phong_ngu += 4L;
                                                      }
                                                      else if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 2)
                                                      {
                                                            this.Item_suc_phong_ngu += 12L;
                                                      }
                                                      else if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 3)
                                                      {
                                                            this.Item_suc_phong_ngu += 0x18L;
                                                      }
                                                      else if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 4)
                                                      {
                                                            this.Item_suc_phong_ngu += 40L;
                                                      }
                                                      else if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 5)
                                                      {
                                                            this.Item_suc_phong_ngu += 60L;
                                                      }
                                                      else if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 6)
                                                      {
                                                            this.Item_thuoc_tinh_sinh_menh_tang_cuong += (this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 5) * 5;
                                                            this.Item_suc_phong_ngu += 0x54L;
                                                      }
                                                      else if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 7)
                                                      {
                                                            this.Item_thuoc_tinh_sinh_menh_tang_cuong += (this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 5) * 5;
                                                            this.Item_suc_phong_ngu += 0x70L;
                                                      }
                                                      else if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 8)
                                                      {
                                                            this.Item_thuoc_tinh_sinh_menh_tang_cuong += (this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 5) * 5;
                                                            this.Item_suc_phong_ngu += 0x90L;
                                                      }
                                                      else if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 9)
                                                      {
                                                            this.Item_thuoc_tinh_sinh_menh_tang_cuong += (this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 5) * 5;
                                                            this.Item_suc_phong_ngu += 180L;
                                                      }
                                                      else if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 10)
                                                      {
                                                            this.Item_thuoc_tinh_sinh_menh_tang_cuong += ((this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 5) * 5) + 5;
                                                            this.Item_suc_phong_ngu += 230L;
                                                      }
                                                      else
                                                      {
                                                            this.Item_thuoc_tinh_sinh_menh_tang_cuong += ((this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 5) * 5) + 5;
                                                            this.Item_suc_phong_ngu += 230 + (this.VAT_PHAM_THUOC_TINH_TANG_CUONG * 3);
                                                      }
                                                }
                                          }
                                    }
                                    else if (this.FLD_RESIDE2 == 6)
                                    {
                                          TBL_XWWL_ITEM tbl_xwwl_item3;
                                          if (World.Itme.TryGetValue(BitConverter.ToInt32(this.VAT_PHAM_ID, 0), out tbl_xwwl_item3) && (this.VAT_PHAM_THUOC_TINH_TANG_CUONG != 0))
                                          {
                                                if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 6)
                                                {
                                                      this.Item_suc_phong_ngu += this.VAT_PHAM_THUOC_TINH_TANG_CUONG * 3;
                                                }
                                                else if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 7)
                                                {
                                                      this.Item_suc_phong_ngu += this.VAT_PHAM_THUOC_TINH_TANG_CUONG * 3;
                                                      this.Item_thuoc_tinh_sinh_menh_tang_cuong += 80;
                                                }
                                                else if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 8)
                                                {
                                                      this.Item_suc_phong_ngu += this.VAT_PHAM_THUOC_TINH_TANG_CUONG * 3;
                                                      this.Item_thuoc_tinh_sinh_menh_tang_cuong += 140;
                                                }
                                                else if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 9)
                                                {
                                                      this.Item_suc_phong_ngu += this.VAT_PHAM_THUOC_TINH_TANG_CUONG * 3;
                                                      this.Item_thuoc_tinh_sinh_menh_tang_cuong += 200;
                                                }
                                                else if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 10)
                                                {
                                                      this.Item_suc_phong_ngu += this.VAT_PHAM_THUOC_TINH_TANG_CUONG * 3;
                                                      this.Item_thuoc_tinh_sinh_menh_tang_cuong += 300;
                                                }
                                                else if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG >= 13)
                                                {
                                                      this.Item_suc_phong_ngu += this.VAT_PHAM_THUOC_TINH_TANG_CUONG * 3;
                                                      this.Item_thuoc_tinh_sinh_menh_tang_cuong += 500;
                                                }
                                                else if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG > 10)
                                                {
                                                      this.Item_thuoc_tinh_sinh_menh_tang_cuong += 300;
                                                      this.Item_suc_phong_ngu += this.VAT_PHAM_THUOC_TINH_TANG_CUONG * 3;
                                                }
                                          }
                                    }
                                    else if (this.FLD_RESIDE2 == 2)
                                    {
                                          TBL_XWWL_ITEM tbl_xwwl_item4;
                                          if ((World.Itme.TryGetValue(BitConverter.ToInt32(this.VAT_PHAM_ID, 0), out tbl_xwwl_item4) && (this.VAT_PHAM_THUOC_TINH_TANG_CUONG != 0)) && (this.VAT_PHAM_THUOC_TINH_TANG_CUONG >= 13))
                                          {
                                                this.Item_thuoc_tinh_sinh_menh_tang_cuong += 200;
                                          }
                                    }
                                    else if (this.FLD_RESIDE2 == 5)
                                    {
                                          TBL_XWWL_ITEM tbl_xwwl_item5;
                                          if ((World.Itme.TryGetValue(BitConverter.ToInt32(this.VAT_PHAM_ID, 0), out tbl_xwwl_item5) && (this.VAT_PHAM_THUOC_TINH_TANG_CUONG != 0)) && (this.VAT_PHAM_THUOC_TINH_TANG_CUONG >= 13))
                                          {
                                                this.Item_thuoc_tinh_sinh_menh_tang_cuong += 200;
                                          }
                                    }
                                    else
                                    {
                                          this.Item_suc_phong_ngu += this.VAT_PHAM_THUOC_TINH_TANG_CUONG * 3;
                                    }
                              }
                              else
                              {
                                    TBL_XWWL_ITEM tbl_xwwl_item6;
                                    if (World.Itme.TryGetValue(BitConverter.ToInt32(this.VAT_PHAM_ID, 0), out tbl_xwwl_item6))
                                    {
                                          if (tbl_xwwl_item6.FLD_LEVEL >= 100)
                                          {
                                                if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG < 4)
                                                {
                                                      this.Item_suc_phong_ngu += this.VAT_PHAM_THUOC_TINH_TANG_CUONG * 5;
                                                }
                                                else
                                                {
                                                      this.Item_suc_phong_ngu += 15L;
                                                      this.Item_suc_phong_ngu += (this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 3) * 9;
                                                }
                                          }
                                          else if (tbl_xwwl_item6.FLD_LEVEL >= 80)
                                          {
                                                if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG < 4)
                                                {
                                                      this.Item_suc_phong_ngu += this.VAT_PHAM_THUOC_TINH_TANG_CUONG * 3;
                                                }
                                                else
                                                {
                                                      this.Item_suc_phong_ngu += 9L;
                                                      this.Item_suc_phong_ngu += (this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 3) * 5;
                                                }
                                          }
                                          else if (tbl_xwwl_item6.FLD_LEVEL >= 60)
                                          {
                                                if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG < 4)
                                                {
                                                      this.Item_suc_phong_ngu += this.VAT_PHAM_THUOC_TINH_TANG_CUONG * 2;
                                                }
                                                else
                                                {
                                                      this.Item_suc_phong_ngu += 6L;
                                                      this.Item_suc_phong_ngu += (this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 3) * 3;
                                                }
                                          }
                                    }
                              }
                        }
                        else if (this.VAT_PHAM_THUOC_TINH_CUONG_HOA_LOAI_HINH == 3)
                        {
                              TBL_XWWL_ITEM tbl_xwwl_item7;
                              if ((((this.FLD_RESIDE2 == 7) || (this.FLD_RESIDE2 == 8)) || (this.FLD_RESIDE2 == 10)) && World.Itme.TryGetValue(BitConverter.ToInt32(this.VAT_PHAM_ID, 0), out tbl_xwwl_item7))
                              {
                                    if (tbl_xwwl_item7.FLD_LEVEL >= 100)
                                    {
                                          this.Item_thuoc_tinh_sinh_menh_tang_cuong += this.VAT_PHAM_THUOC_TINH_TANG_CUONG * 40;
                                    }
                                    else if (tbl_xwwl_item7.FLD_LEVEL >= 80)
                                    {
                                          this.Item_thuoc_tinh_sinh_menh_tang_cuong += this.VAT_PHAM_THUOC_TINH_TANG_CUONG * 15;
                                    }
                                    else if (tbl_xwwl_item7.FLD_LEVEL >= 60)
                                    {
                                          this.Item_thuoc_tinh_sinh_menh_tang_cuong += this.VAT_PHAM_THUOC_TINH_TANG_CUONG * 5;
                                    }
                              }
                        }
                        else if ((this.VAT_PHAM_THUOC_TINH_CUONG_HOA_LOAI_HINH == 4) && (this.FLD_RESIDE2 == 12))
                        {
                              this.Item_thuoc_tinh_hanh_ly_mang_nang += this.VAT_PHAM_THUOC_TINH_TANG_CUONG * 0.01;
                              this.Item_suc_phong_ngu += (int)(4.0 + (this.VAT_PHAM_THUOC_TINH_TANG_CUONG * 0.5));
                              this.Item_luc_cong_kich += (int)(4.0 + (this.VAT_PHAM_THUOC_TINH_TANG_CUONG * 0.5));
                              if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG > 1)
                              {
                                    this.Item_thuoc_tinh_sinh_menh_tang_cuong += this.VAT_PHAM_THUOC_TINH_TANG_CUONG * 5;
                              }
                              this.Item_thuoc_tinh_thu_duoc_tien_tai_tang_cuong += 10 + this.VAT_PHAM_THUOC_TINH_TANG_CUONG;
                        }
                        return;
                        Label_0D80:
                        if (this.VAT_PHAM_THUOC_TINH_CUONG_HOA_LOAI_HINH == 2)
                        {
                              if (this.FLD_RESIDE2 == 1)
                              {
                                    TBL_XWWL_ITEM tbl_xwwl_item8;
                                    if (World.Itme.TryGetValue(BitConverter.ToInt32(this.VAT_PHAM_ID, 0), out tbl_xwwl_item8))
                                    {
                                          if (tbl_xwwl_item8.FLD_LEVEL <= 50)
                                          {
                                                if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG != 0)
                                                {
                                                      if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 1)
                                                      {
                                                            this.Item_suc_phong_ngu += 3L;
                                                            return;
                                                      }
                                                      if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 2)
                                                      {
                                                            this.Item_suc_phong_ngu += 9L;
                                                            return;
                                                      }
                                                      if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 3)
                                                      {
                                                            this.Item_suc_phong_ngu += 0x12L;
                                                            return;
                                                      }
                                                      if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 4)
                                                      {
                                                            this.Item_suc_phong_ngu += 30L;
                                                            return;
                                                      }
                                                      if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 5)
                                                      {
                                                            this.Item_suc_phong_ngu += 0x2dL;
                                                            return;
                                                      }
                                                      if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 6)
                                                      {
                                                            this.Item_suc_phong_ngu += 0x3fL;
                                                            this.Item_thuoc_tinh_sinh_menh_tang_cuong += (this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 5) * 5;
                                                            return;
                                                      }
                                                      if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 7)
                                                      {
                                                            this.Item_suc_phong_ngu += 0x54L;
                                                            this.Item_thuoc_tinh_sinh_menh_tang_cuong += (this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 5) * 5;
                                                            return;
                                                      }
                                                      if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 8)
                                                      {
                                                            this.Item_suc_phong_ngu += 0x6cL;
                                                            this.Item_thuoc_tinh_sinh_menh_tang_cuong += (this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 5) * 5;
                                                            return;
                                                      }
                                                      if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 9)
                                                      {
                                                            this.Item_suc_phong_ngu += 0x87L;
                                                            this.Item_thuoc_tinh_sinh_menh_tang_cuong += (this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 5) * 5;
                                                      }
                                                      else if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 10)
                                                      {
                                                            this.Item_suc_phong_ngu += 0xa5L;
                                                            this.Item_thuoc_tinh_sinh_menh_tang_cuong += ((this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 5) * 5) + 5;
                                                      }
                                                      else
                                                      {
                                                            this.Item_thuoc_tinh_sinh_menh_tang_cuong += ((this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 5) * 5) + 5;
                                                            this.Item_suc_phong_ngu += 0xa5 + (this.VAT_PHAM_THUOC_TINH_TANG_CUONG * 3);
                                                      }
                                                }
                                          }
                                          else if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG != 0)
                                          {
                                                if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 1)
                                                {
                                                      this.Item_suc_phong_ngu += 4L;
                                                      return;
                                                }
                                                if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 2)
                                                {
                                                      this.Item_suc_phong_ngu += 12L;
                                                      return;
                                                }
                                                if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 3)
                                                {
                                                      this.Item_suc_phong_ngu += 0x18L;
                                                      return;
                                                }
                                                if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 4)
                                                {
                                                      this.Item_suc_phong_ngu += 40L;
                                                      return;
                                                }
                                                if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 5)
                                                {
                                                      this.Item_suc_phong_ngu += 60L;
                                                      return;
                                                }
                                                if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 6)
                                                {
                                                      this.Item_thuoc_tinh_sinh_menh_tang_cuong += (this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 5) * 5;
                                                      this.Item_suc_phong_ngu += 0x54L;
                                                      return;
                                                }
                                                if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 7)
                                                {
                                                      this.Item_thuoc_tinh_sinh_menh_tang_cuong += (this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 5) * 5;
                                                      this.Item_suc_phong_ngu += 0x70L;
                                                      return;
                                                }
                                                if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 8)
                                                {
                                                      this.Item_thuoc_tinh_sinh_menh_tang_cuong += (this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 5) * 5;
                                                      this.Item_suc_phong_ngu += 0x90L;
                                                      return;
                                                }
                                                if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 9)
                                                {
                                                      this.Item_thuoc_tinh_sinh_menh_tang_cuong += (this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 5) * 5;
                                                      this.Item_suc_phong_ngu += 180L;
                                                      return;
                                                }
                                                if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG == 10)
                                                {
                                                      this.Item_thuoc_tinh_sinh_menh_tang_cuong += ((this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 5) * 5) + 5;
                                                      this.Item_suc_phong_ngu += 230L;
                                                }
                                                else if (this.VAT_PHAM_THUOC_TINH_TANG_CUONG >= 15)
                                                {
                                                      this.Item_thuoc_tinh_sinh_menh_tang_cuong += (((this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 5) * 5) + 5) + 200;
                                                      this.Item_suc_phong_ngu += 390L;
                                                }
                                                else
                                                {
                                                      this.Item_thuoc_tinh_sinh_menh_tang_cuong += ((this.VAT_PHAM_THUOC_TINH_TANG_CUONG - 5) * 5) + 5;
                                                      this.Item_suc_phong_ngu += 230 + (this.VAT_PHAM_THUOC_TINH_TANG_CUONG * 3);
                                                }
                                          }
                                    }
                              }
                              else
                              {
                                    this.Item_suc_phong_ngu += this.VAT_PHAM_THUOC_TINH_TANG_CUONG * 3;
                              }
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "得到强化 出错：" + exception);
                  }
            }

            public int method_2()
            {
                  try
                  {
                        TBL_XWWL_ITEM tbl_xwwl_item;
                        if (World.Itme.TryGetValue(BitConverter.ToInt32(this.VAT_PHAM_ID, 0), out tbl_xwwl_item))
                        {
                              return tbl_xwwl_item.FLD_WEIGHT;
                        }
                        return 0;
                  }
                  catch
                  {
                        return 0;
                  }
            }

            public int method_3()
            {
                  try
                  {
                        TBL_XWWL_ITEM tbl_xwwl_item;
                        if (World.Itme.TryGetValue(BitConverter.ToInt32(this.VAT_PHAM_ID, 0), out tbl_xwwl_item))
                        {
                              return (tbl_xwwl_item.FLD_WEIGHT * BitConverter.ToInt32(this.VAT_PHAM_SO_LUONG, 0));
                        }
                        return 0;
                  }
                  catch
                  {
                        return 0;
                  }
            }

            public byte[] method_4()
            {
                  byte[] dst = new byte[0x38];
                  Buffer.BlockCopy(this.Item_byte, 0x10, dst, 0, 0x38);
                  return dst;
            }

            public byte[] method_5()
            {
                  byte[] dst = new byte[8];
                  Buffer.BlockCopy(this.Item_byte, 0, dst, 0, 8);
                  return dst;
            }

            public byte[] method_6()
            {
                  byte[] dst = new byte[4];
                  Buffer.BlockCopy(this.Item_byte, 8, dst, 0, 4);
                  return dst;
            }

            public byte[] method_7()
            {
                  byte[] dst = new byte[4];
                  Buffer.BlockCopy(this.Item_byte, 12, dst, 0, 4);
                  return dst;
            }

            public void method_8(byte[] byte_1)
            {
                  Buffer.BlockCopy(byte_1, 0, this.Item_byte, 12, 4);
            }

            public byte[] method_9()
            {
                  byte[] dst = new byte[4];
                  Buffer.BlockCopy(this.Item_byte, 0x10, dst, 0, 4);
                  return dst;
            }

            void IDisposable.Dispose()
            {
            }

            public int FLD_cuong_hoa_loai_hinh
            {
                  get
                  {
                        int num = this.FLD_MAGIC0;
                        if (num > 0)
                        {
                              string text1 = num.ToString();
                              return int.Parse(text1.Substring(text1.Length - 8, 1));
                        }
                        return 0;
                  }
            }

            public int FLD_cuong_hoa_so_luong
            {
                  get
                  {
                        int num = this.FLD_MAGIC0;
                        if (num > 0)
                        {
                              string text1 = num.ToString();
                              return int.Parse(text1.Substring(text1.Length - 2, 2));
                        }
                        return 0;
                  }
            }

            public int FLD_FJ_JSSJ
            {
                  get
                  {
                        byte[] dst = new byte[4];
                        Buffer.BlockCopy(this.Item_byte, 0x38, dst, 0, 4);
                        return BitConverter.ToInt32(dst, 0);
                  }
                  set
                  {
                        Buffer.BlockCopy(BitConverter.GetBytes(value), 0, this.Item_byte, 0x38, 4);
                  }
            }

            public int FLD_FJ_KSSJ
            {
                  get
                  {
                        byte[] dst = new byte[4];
                        Buffer.BlockCopy(this.Item_byte, 0x34, dst, 0, 4);
                        return BitConverter.ToInt32(dst, 0);
                  }
                  set
                  {
                        Buffer.BlockCopy(BitConverter.GetBytes(value), 0, this.Item_byte, 0x34, 4);
                  }
            }

            public int FLD_FJ_MAGIC0
            {
                  get
                  {
                        byte[] dst = new byte[2];
                        Buffer.BlockCopy(this.Item_byte, 0x24, dst, 0, 2);
                        return BitConverter.ToInt16(dst, 0);
                  }
                  set
                  {
                        Buffer.BlockCopy(BitConverter.GetBytes(value), 0, this.Item_byte, 0x24, 2);
                  }
            }

            public int FLD_FJ_MAGIC1
            {
                  get
                  {
                        byte[] dst = new byte[2];
                        Buffer.BlockCopy(this.Item_byte, 0x26, dst, 0, 2);
                        return BitConverter.ToInt16(dst, 0);
                  }
                  set
                  {
                        Buffer.BlockCopy(BitConverter.GetBytes(value), 0, this.Item_byte, 0x26, 2);
                  }
            }

            public int FLD_FJ_MAGIC2
            {
                  get
                  {
                        byte[] dst = new byte[2];
                        Buffer.BlockCopy(this.Item_byte, 0x2a, dst, 0, 2);
                        return BitConverter.ToInt16(dst, 0);
                  }
                  set
                  {
                        Buffer.BlockCopy(BitConverter.GetBytes(value), 0, this.Item_byte, 0x2a, 2);
                  }
            }

            public int FLD_FJ_MAGIC3
            {
                  get
                  {
                        byte[] dst = new byte[2];
                        Buffer.BlockCopy(this.Item_byte, 0x2c, dst, 0, 2);
                        return BitConverter.ToInt16(dst, 0);
                  }
                  set
                  {
                        Buffer.BlockCopy(BitConverter.GetBytes(value), 0, this.Item_byte, 0x2c, 2);
                  }
            }

            public int FLD_FJ_MAGIC4
            {
                  get
                  {
                        byte[] dst = new byte[2];
                        Buffer.BlockCopy(this.Item_byte, 0x2e, dst, 0, 2);
                        return BitConverter.ToInt16(dst, 0);
                  }
                  set
                  {
                        Buffer.BlockCopy(BitConverter.GetBytes(value), 0, this.Item_byte, 0x2e, 2);
                  }
            }

            public int FLD_FJ_MAGIC5
            {
                  get
                  {
                        byte[] dst = new byte[2];
                        Buffer.BlockCopy(this.Item_byte, 0x30, dst, 0, 2);
                        return BitConverter.ToInt16(dst, 0);
                  }
                  set
                  {
                        Buffer.BlockCopy(BitConverter.GetBytes(value), 0, this.Item_byte, 0x30, 2);
                  }
            }

            public int FLD_FJ_SDSJ
            {
                  get
                  {
                        byte[] dst = new byte[4];
                        Buffer.BlockCopy(this.Item_byte, 0x45, dst, 0, 4);
                        return BitConverter.ToInt32(dst, 0);
                  }
                  set
                  {
                        Buffer.BlockCopy(BitConverter.GetBytes(value), 0, this.Item_byte, 0x45, 4);
                  }
            }

            public int FLD_FJ_thuc_tinh
            {
                  get
                  {
                        byte[] dst = new byte[4];
                        Buffer.BlockCopy(this.Item_byte, 0x3e, dst, 0, 4);
                        return BitConverter.ToInt32(dst, 0);
                  }
                  set
                  {
                        Buffer.BlockCopy(BitConverter.GetBytes(value), 0, this.Item_byte, 0x3e, 4);
                  }
            }

            public int FLD_FJ_tien_hoa
            {
                  get
                  {
                        byte[] dst = new byte[4];
                        Buffer.BlockCopy(this.Item_byte, 0x44, dst, 0, 2);
                        return BitConverter.ToInt32(dst, 0);
                  }
                  set
                  {
                        Buffer.BlockCopy(BitConverter.GetBytes(value), 0, this.Item_byte, 0x44, 2);
                  }
            }

            public int FLD_FJ_trung_cap_phu_hon
            {
                  get
                  {
                        try
                        {
                              byte[] dst = new byte[2];
                              Buffer.BlockCopy(this.Item_byte, 40, dst, 0, 2);
                              return BitConverter.ToInt16(dst, 0);
                        }
                        catch (Exception exception)
                        {
                              Form1.WriteLine(1, string.Concat(new object[] { "FLD_FJ_trung_cap_phu_hon Get出错： [", this.method_1(), "]", exception }));
                              return 0;
                        }
                  }
                  set
                  {
                        try
                        {
                              if (value > 0)
                              {
                                    Buffer.BlockCopy(BitConverter.GetBytes(1), 0, this.Item_byte, 0x26, 2);
                              }
                              else if (value == 0)
                              {
                                    Buffer.BlockCopy(BitConverter.GetBytes(0), 0, this.Item_byte, 0x26, 2);
                              }
                              Buffer.BlockCopy(BitConverter.GetBytes(value), 0, this.Item_byte, 40, 2);
                        }
                        catch (Exception exception)
                        {
                              Form1.WriteLine(1, string.Concat(new object[] { "FLD_FJ_trung_cap_phu_hon Set出错： [", this.method_1(), "]", exception }));
                        }
                  }
            }

            public int FLD_keo_dai_suc_manh
            {
                  get
                  {
                        byte[] dst = new byte[2];
                        Buffer.BlockCopy(this.Item_byte, 60, dst, 0, 2);
                        return BitConverter.ToInt16(dst, 0);
                  }
                  set
                  {
                        Buffer.BlockCopy(BitConverter.GetBytes(value), 0, this.Item_byte, 60, 2);
                  }
            }

            public int FLD_MAGIC0
            {
                  get
                  {
                        byte[] dst = new byte[4];
                        Buffer.BlockCopy(this.Item_byte, 0x10, dst, 0, 4);
                        return BitConverter.ToInt32(dst, 0);
                  }
                  set
                  {
                        Buffer.BlockCopy(BitConverter.GetBytes(value), 0, this.Item_byte, 0x10, 2);
                  }
            }

            public int FLD_MAGIC1
            {
                  get
                  {
                        byte[] dst = new byte[4];
                        Buffer.BlockCopy(this.Item_byte, 20, dst, 0, 4);
                        return BitConverter.ToInt32(dst, 0);
                  }
                  set
                  {
                        Buffer.BlockCopy(BitConverter.GetBytes(value), 0, this.Item_byte, 20, 2);
                  }
            }

            public int FLD_MAGIC2
            {
                  get
                  {
                        byte[] dst = new byte[4];
                        Buffer.BlockCopy(this.Item_byte, 0x18, dst, 0, 4);
                        return BitConverter.ToInt32(dst, 0);
                  }
                  set
                  {
                        Buffer.BlockCopy(BitConverter.GetBytes(value), 0, this.Item_byte, 0x18, 2);
                  }
            }

            public int FLD_MAGIC3
            {
                  get
                  {
                        byte[] dst = new byte[4];
                        Buffer.BlockCopy(this.Item_byte, 0x1c, dst, 0, 4);
                        return BitConverter.ToInt32(dst, 0);
                  }
                  set
                  {
                        Buffer.BlockCopy(BitConverter.GetBytes(value), 0, this.Item_byte, 0x1c, 2);
                  }
            }

            public int FLD_MAGIC4
            {
                  get
                  {
                        byte[] dst = new byte[4];
                        Buffer.BlockCopy(this.Item_byte, 0x20, dst, 0, 4);
                        return BitConverter.ToInt32(dst, 0);
                  }
                  set
                  {
                        Buffer.BlockCopy(BitConverter.GetBytes(value), 0, this.Item_byte, 0x20, 2);
                  }
            }

            public int FLD_RESIDE2
            {
                  get
                  {
                        return this.int_17;
                  }
                  set
                  {
                        this.int_17 = value;
                  }
            }

            public int FLD_thuoc_tinh_loai_hinh
            {
                  get
                  {
                        int num = this.FLD_MAGIC0;
                        if ((num > 0) && (num > 0x3b9aca00))
                        {
                              string text1 = num.ToString();
                              return int.Parse(text1.Substring(text1.Length - 4, 1));
                        }
                        return 0;
                  }
            }

            public int FLD_thuoc_tinh_so_luong
            {
                  get
                  {
                        int num = this.FLD_MAGIC0;
                        if ((num > 0) && (num > 0x3b9aca00))
                        {
                              string text1 = num.ToString();
                              return int.Parse(text1.Substring(text1.Length - 3, 1));
                        }
                        return 0;
                  }
            }

            public int Get_VAT_PHAM_SO_LUONG =>
                BitConverter.ToInt32(this.Item_byte, 12);

            public long GetItem_ID =>
                ((long)BitConverter.ToInt32(this.Item_byte, 8));

            public long GetItem_toan_bo_ID =>
                BitConverter.ToInt64(this.Item_byte, 0);

            public byte[] Item_byte
            {
                  get
                  {
                        return this.byte_0;
                  }
                  set
                  {
                        this.bool_0 = false;
                        this.byte_0 = value;
                  }
            }

            public int Item_loai_hinh =>
                this.method_11();

            public long Item_luc_cong_kich
            {
                  get
                  {
                        return this.long_1;
                  }
                  set
                  {
                        this.long_1 = value;
                  }
            }

            public long Item_luc_cong_kich_MAX
            {
                  get
                  {
                        return this.long_2;
                  }
                  set
                  {
                        this.long_2 = value;
                  }
            }

            public int Item_mot_minh_trong_luong =>
                this.method_2();

            public string Item_string
            {
                  get
                  {
                        return this.method_1();
                  }
                  set
                  {
                        this.string_0 = value;
                  }
            }

            public long Item_suc_phong_ngu
            {
                  get
                  {
                        return this.long_0;
                  }
                  set
                  {
                        this.long_0 = value;
                  }
            }

            public byte[] Item_thuoc_tinh =>
                this.method_4();

            public double Item_thuoc_tinh_hanh_ly_mang_nang
            {
                  get
                  {
                        return this.double_0;
                  }
                  set
                  {
                        this.double_0 = value;
                  }
            }

            public double Item_thuoc_tinh_kinh_nghiem_thu_duoc_gia_tang
            {
                  get
                  {
                        return this.double_3;
                  }
                  set
                  {
                        this.double_3 = value;
                  }
            }

            public int Item_thuoc_tinh_Luc_cong_kich_tang_cuong
            {
                  get
                  {
                        return this.int_5;
                  }
                  set
                  {
                        this.int_5 = value;
                  }
            }

            public int Item_thuoc_tinh_Luc_cong_kich_vo_cong
            {
                  get
                  {
                        return this.int_11;
                  }
                  set
                  {
                        this.int_11 = value;
                  }
            }

            public int Item_thuoc_tinh_ne_tranh_xac_xuat_tang_cuong
            {
                  get
                  {
                        return this.int_10;
                  }
                  set
                  {
                        this.int_10 = value;
                  }
            }

            public int Item_thuoc_tinh_Noi_cong_suc_manh_tang_cuong
            {
                  get
                  {
                        return this.int_8;
                  }
                  set
                  {
                        this.int_8 = value;
                  }
            }

            public int Item_thuoc_tinh_sinh_menh_tang_cuong
            {
                  get
                  {
                        return this.int_7;
                  }
                  set
                  {
                        this.int_7 = value;
                  }
            }

            public int Item_thuoc_tinh_Suc_phong_ngu_tang_cuong
            {
                  get
                  {
                        return this.int_6;
                  }
                  set
                  {
                        this.int_6 = value;
                  }
            }

            public int Item_thuoc_tinh_suc_phong_ngu_vo_cong_tang_cuong
            {
                  get
                  {
                        return this.int_14;
                  }
                  set
                  {
                        this.int_14 = value;
                  }
            }

            public double Item_thuoc_tinh_thang_cap_ty_le_thanh_cong
            {
                  get
                  {
                        return this.double_1;
                  }
                  set
                  {
                        this.double_1 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_Cam_su_Cam_thanh_qua_nguyet
            {
                  get
                  {
                        return this.int_78;
                  }
                  set
                  {
                        this.int_78 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_cam_su_Chien_ma_bon_dang
            {
                  get
                  {
                        return this.int_79;
                  }
                  set
                  {
                        this.int_79 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_cam_su_Duong_quan_tam_diep
            {
                  get
                  {
                        return this.int_84;
                  }
                  set
                  {
                        this.int_84 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_cam_su_Han_cung_thu_nguyet
            {
                  get
                  {
                        return this.int_81;
                  }
                  set
                  {
                        this.int_81 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_cam_su_Loan_phuong_hoa_minh
            {
                  get
                  {
                        return this.int_87;
                  }
                  set
                  {
                        this.int_87 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_Cam_su_Nhat_am_xuat_kich
            {
                  get
                  {
                        return this.int_80;
                  }
                  set
                  {
                        this.int_80 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_Cam_su_Sat_am_cam_khuc
            {
                  get
                  {
                        return this.int_85;
                  }
                  set
                  {
                        this.int_85 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_Cam_su_Tam_khuc_hoa_minh
            {
                  get
                  {
                        return this.int_86;
                  }
                  set
                  {
                        this.int_86 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_cam_su_Thanh_tam_pho_thien
            {
                  get
                  {
                        return this.int_82;
                  }
                  set
                  {
                        this.int_82 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_cam_su_Thu_giang_da_bac
            {
                  get
                  {
                        return this.int_83;
                  }
                  set
                  {
                        this.int_83 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_cung_thu_Bach_bo_xuyen_duong
            {
                  get
                  {
                        return this.int_66;
                  }
                  set
                  {
                        this.int_66 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_cung_thu_Chinh_ban_boi_nguyen
            {
                  get
                  {
                        return this.int_62;
                  }
                  set
                  {
                        this.int_62 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_cung_thu_Cuong_phong_van_pha
            {
                  get
                  {
                        return this.int_64;
                  }
                  set
                  {
                        this.int_64 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_cung_thu_Due_loi_chi_tien
            {
                  get
                  {
                        return this.int_67;
                  }
                  set
                  {
                        this.int_67 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_cung_thu_Liep_ung_chi_nhan
            {
                  get
                  {
                        return this.int_65;
                  }
                  set
                  {
                        this.int_65 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_cung_thu_Luu_tinh_tam_thi
            {
                  get
                  {
                        return this.int_63;
                  }
                  set
                  {
                        this.int_63 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_cung_thu_Ngung_than_tu_khi
            {
                  get
                  {
                        return this.int_58;
                  }
                  set
                  {
                        this.int_58 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_cung_thu_Tam_than_ngung_tu
            {
                  get
                  {
                        return this.int_59;
                  }
                  set
                  {
                        this.int_59 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_cung_thu_Tat_sat_nhat_kich
            {
                  get
                  {
                        return this.int_60;
                  }
                  set
                  {
                        this.int_60 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_cung_thu_Vo_minh_am_thi
            {
                  get
                  {
                        return this.int_61;
                  }
                  set
                  {
                        this.int_61 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_dao_khach_Am_anh_tuyet_sat
            {
                  get
                  {
                        return this.int_22;
                  }
                  set
                  {
                        this.int_22 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_dao_khach_Chan_vu_tuyet_kich
            {
                  get
                  {
                        return this.int_24;
                  }
                  set
                  {
                        this.int_24 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_dao_khach_Cuong_phong_van_pha
            {
                  get
                  {
                        return this.int_23;
                  }
                  set
                  {
                        this.int_23 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_dao_khach_Lien_hoan_phi_vu
            {
                  get
                  {
                        return this.int_26;
                  }
                  set
                  {
                        this.int_26 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_dao_khach_Luc_phach_hoa_son
            {
                  get
                  {
                        return this.int_18;
                  }
                  set
                  {
                        this.int_18 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_dao_khach_Nhiep_hon_nhat_kich
            {
                  get
                  {
                        return this.int_21;
                  }
                  set
                  {
                        this.int_21 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_dao_khach_On_nhu_thai_son
            {
                  get
                  {
                        return this.int_25;
                  }
                  set
                  {
                        this.int_25 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_dao_khach_Phach_khi_pha_giap
            {
                  get
                  {
                        return this.int_27;
                  }
                  set
                  {
                        this.int_27 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_dao_khach_Tat_sat_nhat_kich
            {
                  get
                  {
                        return this.int_20;
                  }
                  set
                  {
                        this.int_20 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_dao_khach_Tri_menh_tuyet_thu
            {
                  get
                  {
                        return this.int_34;
                  }
                  set
                  {
                        this.int_34 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_dao_khach_Tu_luong_thien_can
            {
                  get
                  {
                        return this.int_19;
                  }
                  set
                  {
                        this.int_19 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_kiem_khach_Bach_bien_than_hanh
            {
                  get
                  {
                        return this.int_44;
                  }
                  set
                  {
                        this.int_44 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_kiem_khach_Cuong_phong_van_pha
            {
                  get
                  {
                        return this.int_43;
                  }
                  set
                  {
                        this.int_43 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_kiem_khach_Di_hoa_tiep_moc
            {
                  get
                  {
                        return this.int_45;
                  }
                  set
                  {
                        this.int_45 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_kiem_khach_Ho_than_cuong_khi
            {
                  get
                  {
                        return this.int_42;
                  }
                  set
                  {
                        this.int_42 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_kiem_khach_Hoi_lieu_than_phap
            {
                  get
                  {
                        return this.int_39;
                  }
                  set
                  {
                        this.int_39 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_kiem_khach_Lien_hoan_phi_vu
            {
                  get
                  {
                        return this.int_46;
                  }
                  set
                  {
                        this.int_46 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_kiem_khach_No_hai_cuong_lan
            {
                  get
                  {
                        return this.int_41;
                  }
                  set
                  {
                        this.int_41 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_kiem_khach_Tat_sat_nhat_kich
            {
                  get
                  {
                        return this.int_40;
                  }
                  set
                  {
                        this.int_40 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_kiem_khach_Trung_quan_nhat_no
            {
                  get
                  {
                        return this.int_38;
                  }
                  set
                  {
                        this.int_38 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_kiem_khach_Truong_hong_quan_nhat
            {
                  get
                  {
                        return this.int_47;
                  }
                  set
                  {
                        this.int_47 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_muc_ton_thuong
            {
                  get
                  {
                        return this.int_13;
                  }
                  set
                  {
                        this.int_13 = value;
                  }
            }

            public double Item_thuoc_tinh_them_vao_Quyen_bang_hoa_mot_the
            {
                  get
                  {
                        return this.double_127;
                  }
                  set
                  {
                        this.double_127 = value;
                  }
            }

            public double Item_thuoc_tinh_them_vao_Quyen_cuong_phong_van_pha
            {
                  get
                  {
                        return this.double_124;
                  }
                  set
                  {
                        this.double_124 = value;
                  }
            }

            public double Item_thuoc_tinh_them_vao_Quyen_cuong_than_giang_the
            {
                  get
                  {
                        return this.double_121;
                  }
                  set
                  {
                        this.double_121 = value;
                  }
            }

            public double Item_thuoc_tinh_them_vao_Quyen_doi_cong_lam_thu
            {
                  get
                  {
                        return this.double_126;
                  }
                  set
                  {
                        this.double_126 = value;
                  }
            }

            public double Item_thuoc_tinh_them_vao_Quyen_hieu_y_mot_don
            {
                  get
                  {
                        return this.double_128;
                  }
                  set
                  {
                        this.double_128 = value;
                  }
            }

            public double Item_thuoc_tinh_them_vao_Quyen_kim_cuong_bat_hoai
            {
                  get
                  {
                        return this.double_125;
                  }
                  set
                  {
                        this.double_125 = value;
                  }
            }

            public double Item_thuoc_tinh_them_vao_Quyen_linh_giap_ho_than
            {
                  get
                  {
                        return this.double_129;
                  }
                  set
                  {
                        this.double_129 = value;
                  }
            }

            public double Item_thuoc_tinh_them_vao_Quyen_luc_phach_Hoa_Son
            {
                  get
                  {
                        return this.double_123;
                  }
                  set
                  {
                        this.double_123 = value;
                  }
            }

            public double Item_thuoc_tinh_them_vao_Quyen_mai_xu_thanh_cham
            {
                  get
                  {
                        return this.double_130;
                  }
                  set
                  {
                        this.double_130 = value;
                  }
            }

            public double Item_thuoc_tinh_them_vao_Quyen_van_may_chua_thuong
            {
                  get
                  {
                        return this.double_122;
                  }
                  set
                  {
                        this.double_122 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_thich_khach_Kiem_nhan_loan_vu
            {
                  get
                  {
                        return this.int_30;
                  }
                  set
                  {
                        this.int_30 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_thich_khach_Kinh_kha_chi_no
            {
                  get
                  {
                        return this.int_35;
                  }
                  set
                  {
                        this.int_35 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_thich_khach_Lien_hoan_phi_vu
            {
                  get
                  {
                        return this.int_37;
                  }
                  set
                  {
                        this.int_37 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_thich_khach_Lien_tieu_dai_da
            {
                  get
                  {
                        return this.int_36;
                  }
                  set
                  {
                        this.int_36 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_thich_khach_Tam_hoa_tu_dinh
            {
                  get
                  {
                        return this.int_28;
                  }
                  set
                  {
                        this.int_28 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_thich_khach_Tam_than_ngung_tu
            {
                  get
                  {
                        return this.int_32;
                  }
                  set
                  {
                        this.int_32 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_thich_khach_Tat_sat_nhat_kich
            {
                  get
                  {
                        return this.int_33;
                  }
                  set
                  {
                        this.int_33 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_thich_khach_Thien_chu_van_thu
            {
                  get
                  {
                        return this.int_31;
                  }
                  set
                  {
                        this.int_31 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_thich_khach_Tien_phat_che_nhan
            {
                  get
                  {
                        return this.int_29;
                  }
                  set
                  {
                        this.int_29 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_thuong_khach_Can_khon_na_di
            {
                  get
                  {
                        return this.int_68;
                  }
                  set
                  {
                        this.int_68 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_thuong_khach_Chuyen_thu_vi_cong
            {
                  get
                  {
                        return this.int_74;
                  }
                  set
                  {
                        this.int_74 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_thuong_khach_Cuong_phong_van_pha
            {
                  get
                  {
                        return this.int_73;
                  }
                  set
                  {
                        this.int_73 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_thuong_khach_Cuong_than_hang_the
            {
                  get
                  {
                        return this.int_72;
                  }
                  set
                  {
                        this.int_72 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_thuong_khach_Hoanh_luyen_thai_bao
            {
                  get
                  {
                        return this.int_70;
                  }
                  set
                  {
                        this.int_70 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_thuong_khach_Kim_chung_trao_khi
            {
                  get
                  {
                        return this.int_77;
                  }
                  set
                  {
                        this.int_77 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_thuong_khach_Lien_hoan_phi_vu
            {
                  get
                  {
                        return this.int_76;
                  }
                  set
                  {
                        this.int_76 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_thuong_khach_Linh_giap_ho_than
            {
                  get
                  {
                        return this.int_71;
                  }
                  set
                  {
                        this.int_71 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_thuong_khach_Tat_sat_nhat_kich
            {
                  get
                  {
                        return this.int_69;
                  }
                  set
                  {
                        this.int_69 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_thuong_khach_Van_khi_lieu_thuong
            {
                  get
                  {
                        return this.int_75;
                  }
                  set
                  {
                        this.int_75 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_Y_Cuu_thien_chan_khi
            {
                  get
                  {
                        return this.int_48;
                  }
                  set
                  {
                        this.int_48 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_y_Dieu_thu_hoi_xuan
            {
                  get
                  {
                        return this.int_53;
                  }
                  set
                  {
                        this.int_53 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_Y_hap_tinh_dai_phap
            {
                  get
                  {
                        return this.int_50;
                  }
                  set
                  {
                        this.int_50 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_Y_tay_tuy_dich_kinh
            {
                  get
                  {
                        return this.int_54;
                  }
                  set
                  {
                        this.int_54 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_Y_thai_cuc_tam_phap
            {
                  get
                  {
                        return this.int_52;
                  }
                  set
                  {
                        this.int_52 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_y_Than_Nong_tien_thuat
            {
                  get
                  {
                        return this.int_55;
                  }
                  set
                  {
                        this.int_55 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_Y_the_huyet_boi_tang
            {
                  get
                  {
                        return this.int_49;
                  }
                  set
                  {
                        this.int_49 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_Y_thien_huu_khi
            {
                  get
                  {
                        return this.int_51;
                  }
                  set
                  {
                        this.int_51 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_Y_Truong_cong_cong_kich
            {
                  get
                  {
                        return this.int_57;
                  }
                  set
                  {
                        this.int_57 = value;
                  }
            }

            public int Item_thuoc_tinh_them_vao_Y_van_khi_hanh_tam
            {
                  get
                  {
                        return this.int_56;
                  }
                  set
                  {
                        this.int_56 = value;
                  }
            }

            public double Item_thuoc_tinh_thu_duoc_tien_tai_tang_cuong
            {
                  get
                  {
                        return this.double_2;
                  }
                  set
                  {
                        this.double_2 = value;
                  }
            }

            public int Item_thuoc_tinh_Ti_le_trung_muc_tieu_tang_cuong
            {
                  get
                  {
                        return this.int_9;
                  }
                  set
                  {
                        this.int_9 = value;
                  }
            }

            public int Item_thuoc_tinh_toan_bo_khi_cong_thu_bac_tang_cuong
            {
                  get
                  {
                        return this.int_12;
                  }
                  set
                  {
                        this.int_12 = value;
                  }
            }

            public int Item_thuoc_tinh_Tu_vong_ton_that_kinh_nghiem_giam_thieu
            {
                  get
                  {
                        return this.int_16;
                  }
                  set
                  {
                        this.int_16 = value;
                  }
            }

            public byte[] Item_toan_bo_ID =>
                this.method_5();

            public bool Item_troi_chat
            {
                  get
                  {
                        try
                        {
                              byte[] dst = new byte[2];
                              Buffer.BlockCopy(this.Item_byte, 0x48, dst, 0, 1);
                              return (BitConverter.ToInt16(dst, 0) > 0);
                        }
                        catch (Exception)
                        {
                              return false;
                        }
                  }
                  set
                  {
                        this.bool_1 = value;
                  }
            }

            public int Item_trung_cap_phu_hon_them_vao_thuc_tinh
            {
                  get
                  {
                        return this.int_15;
                  }
                  set
                  {
                        this.int_15 = value;
                  }
            }

            public int ItemPropertyNumber
            {
                  get
                  {
                        return this.int_4;
                  }
                  set
                  {
                        this.int_4 = value;
                  }
            }

            public int ItemPropertyType
            {
                  get
                  {
                        return this.int_3;
                  }
                  set
                  {
                        this.int_3 = value;
                  }
            }

            public byte[] LINH_THU_VAT_PHAM_SO_LUONG
            {
                  get
                  {
                        return this.method_9();
                  }
                  set
                  {
                        this.method_10(value);
                  }
            }

            public ITEMSX Thuoc_tinh_1
            {
                  get
                  {
                        byte[] dst = new byte[4];
                        Buffer.BlockCopy(this.Item_byte, 20, dst, 0, 4);
                        this.Thuoc_tinh_1 = new ITEMSX(dst);
                        return this.class8_0;
                  }
                  set
                  {
                        this.class8_0 = value;
                  }
            }

            public ITEMSX Thuoc_tinh_2
            {
                  get
                  {
                        byte[] dst = new byte[4];
                        Buffer.BlockCopy(this.Item_byte, 0x18, dst, 0, 4);
                        this.Thuoc_tinh_2 = new ITEMSX(dst);
                        return this.class8_1;
                  }
                  set
                  {
                        this.class8_1 = value;
                  }
            }

            public ITEMSX Thuoc_tinh_3
            {
                  get
                  {
                        byte[] dst = new byte[4];
                        Buffer.BlockCopy(this.Item_byte, 0x1c, dst, 0, 4);
                        this.Thuoc_tinh_3 = new ITEMSX(dst);
                        return this.class8_2;
                  }
                  set
                  {
                        this.class8_2 = value;
                  }
            }

            public ITEMSX Thuoc_tinh_4
            {
                  get
                  {
                        byte[] dst = new byte[4];
                        Buffer.BlockCopy(this.Item_byte, 0x20, dst, 0, 4);
                        this.Thuoc_tinh_4 = new ITEMSX(dst);
                        return this.class8_3;
                  }
                  set
                  {
                        this.class8_3 = value;
                  }
            }

            public byte[] VAT_PHAM_ID
            {
                  get
                  {
                        return this.method_6();
                  }
            }

            public byte[] VAT_PHAM_SO_LUONG
            {
                  get
                  {
                        return this.method_7();
                  }
                  set
                  {
                        this.method_8(value);
                  }
            }

            public int VAT_PHAM_THUOC_TINH_CUONG_HOA_LOAI_HINH
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

            public int VAT_PHAM_THUOC_TINH_TANG_CUONG
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

            public int VAT_PHAM_TONG_TRONG_LUONG
            {
                  get
                  {
                        return this.method_3();
                  }
            }

            public int VAT_PHAM_VI_TRI
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
      }
}

