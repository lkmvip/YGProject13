namespace ns9
{
      using ns1;
      using ns10;
      using ns11;
      using ns12;
      using ns13;
      using ns2;
      using ns3;
      using ns4;
      using ns5;
      using ns6;
      using ns7;
      using ns8;
      using RxjhServer;
      using System;
      using System.Collections;
      using System.Collections.Generic;
      using System.Data;
      using System.Data.SqlClient;
      using System.Text;
      using System.Timers;

      public class PlayersBes: KHAI_BAO_KHI_CONG_CLASS
      {
            private double _FLD_Kungfu_Qigong_0;
            private double _FLD_Kungfu_Qigong_1;
            private double _FLD_Kungfu_Qigong_2;
            private double _FLD_Kungfu_Qigong_3;
            private double _FLD_Kungfu_Qigong_4;
            private double _FLD_Kungfu_Qigong_5;
            private double _FLD_Kungfu_Qigong_6;
            private double _FLD_Kungfu_Qigong_7;
            private double _FLD_Kungfu_Qigong_8;
            private double _FLD_Kungfu_Qigong_9;
            public ThreadSafeDictionary<int, Additional_Sate_Class> Add_Status_List;
            public Dictionary<int, string> allChars;
            public bool bool_0;
            public bool bool_1;
            public bool bool_11;
            public bool bool_12;
            public bool bool_2;
            public bool bool_3;
            public bool bool_5;
            public bool bool_6;
            public bool bool_7;
            public bool bool_8;
            public bool bool_9;
            public byte[] byte_0;
            public byte[] byte_1;
            private byte[] byte_2;
            private byte[] byte_3;
            private byte[] byte_4;
            private NetState class16_0;
            public QuestItem_Category[] class22_0;
            public VAT_PHAM_LOAI[] class23_0;
            public VAT_PHAM_LOAI[] class23_1;
            public VAT_PHAM_LOAI[] class23_4;
            public VAT_PHAM_LOAI[] class23_5;
            public TBL_XWWL_MAP class31_0;
            public Transactional class66_0 = new Transactional();
            public TBL_XWWL_KONGFU[,] class79_0 = new TBL_XWWL_KONGFU[4, 0x26];
            public NHAN_VAT_CLASS class84_0;
            public ConfigClass Config = new ConfigClass();
            public List<AttackClass> CONG_KICH_DANH_SACH;
            public DateTime dateTime_0;
            public DateTime dateTime_1;
            public DateTime dateTime_2;
            public DateTime dateTime_3;
            private DateTime dateTime_4;
            private DateTime dateTime_5;
            private DateTime dateTime_6;
            private DateTime dateTime_7;
            private DateTime dateTime_8;
            private decimal decimal_0;
            private decimal decimal_1;
            public Dictionary<int, PET_CLASS> dictionary_1;
            public Dictionary<int, NHIEM_VU_CLASS> dictionary_2;
            public Dictionary<int, PUBLIC_DUOC_PHAM_LOAI> dictionary_3;
            public double double_113;
            public double double_114;
            public double double_115;
            public double double_116;
            private double double_117;
            private double double_118;
            private double double_119;
            private double double_120;
            private double double_121;
            private double double_122;
            private double double_123;
            private double double_124;
            private double double_125;
            private double double_126;
            public double double_127;
            private double double_128;
            private double double_129;
            private double double_130;
            private double double_131;
            private double double_132;
            private double double_133;
            private double double_134;
            private double double_135;
            private double double_136;
            private double double_137;
            private double double_138;
            private double double_139;
            private double double_140;
            private double double_141;
            private double double_142;
            private double double_143;
            private double double_144;
            private double double_145;
            private double double_146;
            private double double_147;
            private double double_148;
            private double double_149;
            private double double_150;
            private double double_151;
            private double double_152;
            private double double_153;
            private double double_154;
            private double double_155;
            private double double_156;
            private double double_157;
            private double double_158;
            private double double_159;
            private double double_160;
            private double double_161;
            private double double_162;
            private double double_163;
            private double double_164;
            private double double_165;
            private double double_166;
            private double double_167;
            private double double_168;
            private double double_169;
            private double double_170;
            private double double_171;
            private double double_172;
            private double double_173;
            private double double_174;
            private double double_175;
            private double double_176;
            private double double_177;
            private double double_178;
            private double double_179;
            private double double_180;
            private double double_181;
            private double double_182;
            private double double_183;
            private double double_184;
            private double double_185;
            private double double_186;
            private double double_187;
            private double double_188;
            private double double_189;
            private double double_190;
            private double double_191;
            private double double_192;
            private double double_193;
            private double double_194;
            private double double_195;
            private double double_196;
            private double double_197;
            private double double_198;
            private double double_199;
            private double double_200;
            private double double_201;
            private double double_202;
            public double double_203;
            private double double_204;
            private double double_205;
            public bool Exiting;
            public float float_0 = 127f;
            private float float_1;
            private float float_2;
            private float float_3;
            private int get_wx;
            public Hashtable hashtable_0;
            public int int_0;
            public int int_1;
            public int int_10 = 1;
            private int int_100;
            private int int_101;
            private int int_102;
            private int int_103;
            private int int_104;
            private int int_105;
            private int int_106;
            private int int_107;
            private int int_108;
            public int int_109;
            public int int_11;
            public int int_110;
            public int int_111;
            public int int_112;
            public int int_113;
            public int int_114;
            public int int_115;
            public int int_12;
            public int int_13;
            public int int_14;
            public int int_15;
            public int int_16;
            public int int_17;
            private int int_18;
            public int int_19;
            public int int_2;
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
            public int int_3;
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
            public int int_4;
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
            public int int_6;
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
            public int int_7;
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
            public int int_8;
            private int int_80;
            private int int_81;
            private int int_82;
            private int int_83;
            private int int_84;
            private int int_85;
            private int int_86;
            private int int_87;
            private int int_88;
            private int int_89;
            public int int_9;
            private int int_90;
            private int int_91;
            private int int_92;
            private int int_93;
            private int int_94;
            private int int_95;
            private int int_96;
            private int int_97;
            private int int_98;
            private int int_99;
            public HcItimesClass ItmeClass;
            public List<Players> list_0 = new List<Players>();
            public List<int> list_1 = new List<int>();
            public List<int> list_2 = new List<int>();
            public List<int> list_3 = new List<int>();
            public List<TBL_XWWL_KONGFU> list_5;
            private long long_0;
            private long long_1;
            private long long_10;
            private long long_11;
            private long long_12;
            private long long_13;
            private long long_14;
            private long long_15;
            private long long_2;
            private long long_3;
            private long long_4;
            private long long_5;
            private long long_6;
            private long long_7;
            private long long_8;
            private long long_9;
            public PET_CLASS NHAN_VAT_LINH_THU;
            private object object_0 = new object();
            private object object_1 = new object();
            private object object_2 = new object();
            public bool OpenWarehouse;
            public PersonalShopClass PlayerShop;
            public QigongClass[] Qigong;
            private string string_0 = string.Empty;
            private string string_1 = string.Empty;
            private string string_2 = string.Empty;
            private string string_3;
            private string string_4;
            private string string_5;
            private string string_6;
            private string[] string_7;
            private string string_8;
            private string string_9;
            public SortedDictionary<int, THANG_THIEN_KHI_CONG_LOAI> THANG_THIEN_KHI_CONG;
            public ThreadSafeDictionary<int, TBL_XWWL_NPC> threadSafeDictionary_0;
            public ThreadSafeDictionary<double, MAT_DAT_ITEM_LOAI> threadSafeDictionary_1;
            public ThreadSafeDictionary<int, THEM_VAO_TRANG_THAI_NEW> threadSafeDictionary_3;
            public ThreadSafeDictionary<int, DI_THUONG_TRANG_THAI_NEW> threadSafeDictionary_4;
            public Timer timer_0 = new Timer(6000.0);
            public int TO_DOI_ID;
            public VAT_PHAM_LOAI[] TRANG_BI_LAN_BAO_VAY;
            public VAT_PHAM_LOAI[] TRANG_BI_LAN_CHOC_THUNG_TRANG_BI;

            public PlayersBes(NetState client)
            {
                  this.Client = client;
                  this.threadSafeDictionary_0 = new ThreadSafeDictionary<int, TBL_XWWL_NPC>();
                  this.threadSafeDictionary_1 = new ThreadSafeDictionary<double, MAT_DAT_ITEM_LOAI>();
                  this.dictionary_3 = new Dictionary<int, PUBLIC_DUOC_PHAM_LOAI>();
                  this.Add_Status_List = new ThreadSafeDictionary<int, Additional_Sate_Class>();
                  this.threadSafeDictionary_3 = new ThreadSafeDictionary<int, THEM_VAO_TRANG_THAI_NEW>();
                  this.threadSafeDictionary_4 = new ThreadSafeDictionary<int, DI_THUONG_TRANG_THAI_NEW>();
                  this.hashtable_0 = new Hashtable();
                  this.CONG_KICH_DANH_SACH = new List<AttackClass>();
                  this.list_5 = new List<TBL_XWWL_KONGFU>();
                  this.class79_0 = new TBL_XWWL_KONGFU[4, 0x26];
                  this.TRANG_BI_LAN_BAO_VAY = new VAT_PHAM_LOAI[0x42];
                  this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI = new VAT_PHAM_LOAI[15];
                  this.class23_4 = new VAT_PHAM_LOAI[15];
                  this.class23_5 = new VAT_PHAM_LOAI[15];
                  this.Qigong = new QigongClass[15];
                  this.dictionary_2 = new Dictionary<int, NHIEM_VU_CLASS>();
                  this.class23_0 = new VAT_PHAM_LOAI[60];
                  this.class23_1 = new VAT_PHAM_LOAI[60];
                  this.class22_0 = new QuestItem_Category[0x24];
                  this.THANG_THIEN_KHI_CONG = new SortedDictionary<int, THANG_THIEN_KHI_CONG_LOAI>();
                  this.dictionary_1 = new Dictionary<int, PET_CLASS>();
            }

            public void ADD_FLD_trang_bi_them_vao_Phong_cu_Cuong_hoa(int int_116)
            {
                  using (new Lock(this.object_2, "addFLD_装备_追加_防具_强化"))
                  {
                        this.FLD_trang_bi_them_vao_Phong_cu_Cuong_hoa += int_116;
                  }
            }

            public void ADD_FLD_trang_bi_them_vao_vu_khi_cuong_hoa(int int_116)
            {
                  using (new Lock(this.object_2, "addFLD_装备_追加_武器_强化"))
                  {
                        this.FLD_trang_bi_them_vao_vu_khi_cuong_hoa += int_116;
                  }
            }

            public void addFLD_ATT_Percentage(decimal decimal_2)
            {
                  using (new Lock(this.object_2, "addFLD_追加百分比_攻击"))
                  {
                        this.FLD_them_vao_ti_le_phan_tram_cong_kich += decimal_2;
                  }
            }

            public void addFLD_DEF_Percentage(decimal decimal_2)
            {
                  using (new Lock(this.object_2, "addFLD_追加百分比_防御"))
                  {
                        this.FLD_them_vao_ti_le_phan_tram_phong_ngu += decimal_2;
                  }
            }

            public void BANG_PHAI_TRUYEN_TONG_PHU_NHAC_NHO(int int_116)
            {
                  byte[] dst = Converter.hexStringToByte("AA55230001D001121614000106000078DC143C010000000100000009943577000000000000A65455AA");
                  Buffer.BlockCopy(BitConverter.GetBytes(int_116), 0, dst, 0x13, 2);
                  Buffer.BlockCopy(BitConverter.GetBytes(this.UserSessionID), 0, dst, 5, 2);
                  if (this.Client != null)
                  {
                        this.Client.Send(dst, dst.Length);
                  }
            }

            public void BasicCharacterData()
            {
                  int num3;
                  int num = World.Nhan_vat_dang_cap_cao_nhat;
                  if (this.Player_FLD_LEVEL > num)
                  {
                        this.Player_FLD_LEVEL = num;
                  }
                  this.NHAN_VAT_LON_NHAT_KINH_NGHIEM = (long)World.lever[this.Player_FLD_LEVEL];
                  int num2 = this.Player_FLD_LEVEL;
                  while (this.NHAN_VAT_KINH_NGHIEM >= this.NHAN_VAT_LON_NHAT_KINH_NGHIEM)
                  {
                        if (this.Player_FLD_LEVEL >= World.Nhan_vat_dang_cap_cao_nhat)
                        {
                              break;
                        }
                        if (this.Client == null)
                        {
                              return;
                        }
                        if (!this.Client.Running)
                        {
                              return;
                        }
                        num3 = this.Player_FLD_LEVEL;
                        this.Player_FLD_LEVEL = num3 + 1;
                        this.NHAN_VAT_LON_NHAT_KINH_NGHIEM = (long)World.lever[this.Player_FLD_LEVEL];
                        if (World.Co_hay_khong_mo_ra_Dang_cap_khen_thuong == 1)
                        {
                              foreach (DANG_CAP_KHEN_THUONG dang_cap_khen_thuong in World.dictionary_16.Values)
                              {
                                    if (this.Player_FLD_LEVEL == dang_cap_khen_thuong.CAP_BAC)
                                    {
                                          Players players = World.smethod_1(this.UserSessionID);
                                          if (this.Chuyen_sinh_so_lan >= World.Chuyen_sinh_so_lan_linh_thuong_khong_che)
                                          {
                                                this.GameMessage(World.Chuyen_sinh_so_lan_linh_thuong_khong_che + "Rewards can not receive grades after reincarnation", 20, "friendly reminder");
                                          }
                                          else if (players != null)
                                          {
                                                players.TRUNG_SINH_LEVEL_KHEN_THUONG();
                                          }
                                    }
                              }
                        }
                  }
                  if ((this.Player_FLD_LEVEL - num2) > 0)
                  {
                        this.Upgrade_Tip(0);
                        int num4 = this.Player_FLD_LEVEL - num2;
                        if (num4 > 0)
                        {
                              for (int i = 0; i < num4; i++)
                              {
                                    if (this.Player_FLD_LEVEL <= 0x22)
                                    {
                                          num3 = this.Player_Qigong_point;
                                          this.Player_Qigong_point = num3 + 1;
                                    }
                                    else
                                    {
                                          this.Player_Qigong_point += 2;
                                    }
                              }
                        }
                  }
                  this.NHAN_VAT_LON_NHAT_SP = 100 + (this.Player_FLD_LEVEL * 10);
                  this.int_56 = 500 + (20 * this.Player_FLD_LEVEL);
                  this.Nhan_vat_co_ban_lon_nhat_HP = 0;
                  this.Nhan_vat_co_ban_lon_nhat_MP = 0;
                  this.FLD_TIM = 0;
                  this.FLD_SINH_MENH = 0;
                  this.FLD_TRUNG_MUC_TIEU = 0;
                  this.FLD_NE_TRANH = 0;
                  this.FLD_SUC_MANH = 0;
                  this.FLD_THAN_THE = 0;
                  this.FLD_ATTACK = 0;
                  this.FLD_PHONG_NGU = 0;
                  switch (this.Player_Job)
                  {
                        case 1:
                              this.Nhan_vat_co_ban_lon_nhat_HP = 0x85 + (this.Player_FLD_LEVEL * 12);
                              this.Nhan_vat_co_ban_lon_nhat_MP = 0x72 + (this.Player_FLD_LEVEL * 2);
                              this.FLD_TIM = 7 + this.Player_FLD_LEVEL;
                              this.FLD_SINH_MENH = 8 + this.Player_FLD_LEVEL;
                              this.FLD_TRUNG_MUC_TIEU = 8 + this.Player_FLD_LEVEL;
                              this.FLD_NE_TRANH = 8 + this.Player_FLD_LEVEL;
                              this.FLD_SUC_MANH = 0x10;
                              this.FLD_THAN_THE = 9;
                              this.FLD_ATTACK = 9;
                              this.FLD_PHONG_NGU = 0x10;
                              for (int j = 2; j <= this.Player_FLD_LEVEL; j++)
                              {
                                    if ((j % 2) == 0)
                                    {
                                          this.FLD_SUC_MANH += 2;
                                          this.FLD_THAN_THE += 2;
                                          this.FLD_ATTACK += 2;
                                          this.FLD_PHONG_NGU += 2;
                                    }
                                    else
                                    {
                                          num3 = this.FLD_SUC_MANH;
                                          this.FLD_SUC_MANH = num3 + 1;
                                          num3 = this.FLD_THAN_THE;
                                          this.FLD_THAN_THE = num3 + 1;
                                          num3 = this.FLD_ATTACK;
                                          this.FLD_ATTACK = num3 + 1;
                                          num3 = this.FLD_PHONG_NGU;
                                          this.FLD_PHONG_NGU = num3 + 1;
                                    }
                              }
                              break;

                        case 2:
                              this.Nhan_vat_co_ban_lon_nhat_HP = 0x79 + (this.Player_FLD_LEVEL * 12);
                              this.Nhan_vat_co_ban_lon_nhat_MP = 0x74 + (this.Player_FLD_LEVEL * 2);
                              this.FLD_TIM = 9;
                              this.FLD_SINH_MENH = 7 + (this.Player_FLD_LEVEL * 2);
                              this.FLD_TRUNG_MUC_TIEU = 8 + (this.Player_FLD_LEVEL * 2);
                              this.FLD_NE_TRANH = 8 + (this.Player_FLD_LEVEL * 2);
                              this.FLD_SUC_MANH = 10 + this.Player_FLD_LEVEL;
                              this.FLD_THAN_THE = 9 + (this.Player_FLD_LEVEL * 2);
                              this.FLD_ATTACK = 9 + (this.Player_FLD_LEVEL * 2);
                              this.FLD_PHONG_NGU = 10 + this.Player_FLD_LEVEL;
                              for (int k = 2; k <= this.Player_FLD_LEVEL; k++)
                              {
                                    if ((k % 2) == 0)
                                    {
                                          num3 = this.FLD_TIM;
                                          this.FLD_TIM = num3 + 1;
                                    }
                                    else
                                    {
                                          this.FLD_TIM += 2;
                                    }
                              }
                              break;

                        case 3:
                              this.Nhan_vat_co_ban_lon_nhat_HP = 0x79 + (this.Player_FLD_LEVEL * 12);
                              this.Nhan_vat_co_ban_lon_nhat_MP = 0x74 + (this.Player_FLD_LEVEL * 2);
                              this.FLD_TIM = 8 + this.Player_FLD_LEVEL;
                              this.FLD_SINH_MENH = 6 + this.Player_FLD_LEVEL;
                              this.FLD_TRUNG_MUC_TIEU = 6 + this.Player_FLD_LEVEL;
                              this.FLD_NE_TRANH = 6 + this.Player_FLD_LEVEL;
                              this.FLD_SUC_MANH = 10 + this.Player_FLD_LEVEL;
                              this.FLD_THAN_THE = 10 + (this.Player_FLD_LEVEL * 3);
                              this.FLD_ATTACK = 10 + (this.Player_FLD_LEVEL * 3);
                              this.FLD_PHONG_NGU = 10 + this.Player_FLD_LEVEL;
                              break;

                        case 4:
                              this.Nhan_vat_co_ban_lon_nhat_HP = 0x79 + (this.Player_FLD_LEVEL * 12);
                              this.Nhan_vat_co_ban_lon_nhat_MP = 0x74 + (this.Player_FLD_LEVEL * 2);
                              this.FLD_TIM = 7 + (this.Player_FLD_LEVEL * 2);
                              this.FLD_SINH_MENH = 9 + (this.Player_FLD_LEVEL * 3);
                              this.FLD_TRUNG_MUC_TIEU = 9 + (this.Player_FLD_LEVEL * 3);
                              this.FLD_NE_TRANH = 9 + (this.Player_FLD_LEVEL * 3);
                              this.FLD_SUC_MANH = 7 + this.Player_FLD_LEVEL;
                              this.FLD_THAN_THE = 10;
                              this.FLD_ATTACK = 11;
                              this.FLD_PHONG_NGU = 8 + this.Player_FLD_LEVEL;
                              for (int m = 2; m <= this.Player_FLD_LEVEL; m++)
                              {
                                    if ((m % 2) == 0)
                                    {
                                          this.FLD_THAN_THE += 2;
                                          this.FLD_ATTACK += 2;
                                    }
                                    else
                                    {
                                          this.FLD_THAN_THE += 3;
                                          this.FLD_ATTACK += 3;
                                    }
                              }
                              break;

                        case 5:
                              this.Nhan_vat_co_ban_lon_nhat_HP = 0x81 + (this.Player_FLD_LEVEL * 7);
                              this.Nhan_vat_co_ban_lon_nhat_MP = 130 + (this.Player_FLD_LEVEL * 6);
                              this.FLD_TIM = 15 + (this.Player_FLD_LEVEL * 3);
                              this.FLD_SINH_MENH = 6 + this.Player_FLD_LEVEL;
                              this.FLD_TRUNG_MUC_TIEU = 6 + this.Player_FLD_LEVEL;
                              this.FLD_NE_TRANH = 6 + this.Player_FLD_LEVEL;
                              this.FLD_SUC_MANH = 7 + (this.Player_FLD_LEVEL * 2);
                              this.FLD_THAN_THE = 5 + (this.Player_FLD_LEVEL * 2);
                              this.FLD_ATTACK = 5 + (this.Player_FLD_LEVEL * 2);
                              this.FLD_PHONG_NGU = 7 + (this.Player_FLD_LEVEL * 2);
                              break;

                        case 6:
                              this.Nhan_vat_co_ban_lon_nhat_HP = 0x7b + (this.Player_FLD_LEVEL * 10);
                              this.Nhan_vat_co_ban_lon_nhat_MP = 110 + (this.Player_FLD_LEVEL * 4);
                              this.FLD_TIM = 7 + (this.Player_FLD_LEVEL * 2);
                              this.FLD_SINH_MENH = 9 + (this.Player_FLD_LEVEL * 3);
                              this.FLD_TRUNG_MUC_TIEU = 3 + this.Player_FLD_LEVEL;
                              this.FLD_NE_TRANH = 6 + (this.Player_FLD_LEVEL * 2);
                              this.FLD_SUC_MANH = 7 + (this.Player_FLD_LEVEL * 2);
                              this.FLD_THAN_THE = 9;
                              this.FLD_ATTACK = 10;
                              this.FLD_PHONG_NGU = 8 + this.Player_FLD_LEVEL;
                              for (int n = 2; n <= this.Player_FLD_LEVEL; n++)
                              {
                                    if ((n % 2) == 0)
                                    {
                                          num3 = this.FLD_THAN_THE;
                                          this.FLD_THAN_THE = num3 + 1;
                                          this.FLD_ATTACK += 2;
                                    }
                                    else
                                    {
                                          this.FLD_THAN_THE += 2;
                                          this.FLD_ATTACK += 3;
                                    }
                              }
                              break;

                        case 7:
                              this.Nhan_vat_co_ban_lon_nhat_HP = 0x81 + (this.Player_FLD_LEVEL * 7);
                              this.Nhan_vat_co_ban_lon_nhat_MP = 130 + (this.Player_FLD_LEVEL * 6);
                              this.FLD_TIM = 15 + (this.Player_FLD_LEVEL * 3);
                              this.FLD_SINH_MENH = 6 + this.Player_FLD_LEVEL;
                              this.FLD_TRUNG_MUC_TIEU = 6 + this.Player_FLD_LEVEL;
                              this.FLD_NE_TRANH = 6 + this.Player_FLD_LEVEL;
                              this.FLD_SUC_MANH = 6 + this.Player_FLD_LEVEL;
                              this.FLD_THAN_THE = 6 + (this.Player_FLD_LEVEL * 2);
                              this.FLD_ATTACK = 5 + (this.Player_FLD_LEVEL * 2);
                              this.FLD_PHONG_NGU = 6 + (this.Player_FLD_LEVEL * 2);
                              break;

                        case 8:
                              this.Nhan_vat_co_ban_lon_nhat_HP = 0x85 + (this.Player_FLD_LEVEL * 12);
                              this.Nhan_vat_co_ban_lon_nhat_MP = 0x72 + (this.Player_FLD_LEVEL * 2);
                              this.FLD_TIM = 7 + this.Player_FLD_LEVEL;
                              this.FLD_SINH_MENH = 8 + this.Player_FLD_LEVEL;
                              this.FLD_TRUNG_MUC_TIEU = 8 + this.Player_FLD_LEVEL;
                              this.FLD_NE_TRANH = 8 + this.Player_FLD_LEVEL;
                              this.FLD_SUC_MANH = 0x10;
                              this.FLD_THAN_THE = 9;
                              this.FLD_ATTACK = 9;
                              this.FLD_PHONG_NGU = 0x10;
                              for (int num10 = 2; num10 <= this.Player_FLD_LEVEL; num10++)
                              {
                                    if ((num10 % 2) == 0)
                                    {
                                          this.FLD_SUC_MANH += 2;
                                          this.FLD_THAN_THE += 2;
                                          this.FLD_ATTACK += 2;
                                          this.FLD_PHONG_NGU += 2;
                                    }
                                    else
                                    {
                                          num3 = this.FLD_SUC_MANH;
                                          this.FLD_SUC_MANH = num3 + 1;
                                          num3 = this.FLD_THAN_THE;
                                          this.FLD_THAN_THE = num3 + 1;
                                          num3 = this.FLD_ATTACK;
                                          this.FLD_ATTACK = num3 + 1;
                                          num3 = this.FLD_PHONG_NGU;
                                          this.FLD_PHONG_NGU = num3 + 1;
                                    }
                              }
                              break;

                        case 9:
                              this.Nhan_vat_co_ban_lon_nhat_HP = 0x79 + (this.Player_FLD_LEVEL * 12);
                              this.Nhan_vat_co_ban_lon_nhat_MP = 0x74 + (this.Player_FLD_LEVEL * 2);
                              this.FLD_TIM = 9;
                              this.FLD_SINH_MENH = 7 + (this.Player_FLD_LEVEL * 2);
                              this.FLD_TRUNG_MUC_TIEU = 8 + (this.Player_FLD_LEVEL * 2);
                              this.FLD_NE_TRANH = 8 + (this.Player_FLD_LEVEL * 2);
                              this.FLD_SUC_MANH = 10 + this.Player_FLD_LEVEL;
                              this.FLD_THAN_THE = 9 + (this.Player_FLD_LEVEL * 2);
                              this.FLD_ATTACK = 9 + (this.Player_FLD_LEVEL * 2);
                              this.FLD_PHONG_NGU = 10 + this.Player_FLD_LEVEL;
                              for (int num11 = 2; num11 <= this.Player_FLD_LEVEL; num11++)
                              {
                                    if ((num11 % 2) == 0)
                                    {
                                          num3 = this.FLD_TIM;
                                          this.FLD_TIM = num3 + 1;
                                    }
                                    else
                                    {
                                          this.FLD_TIM += 2;
                                    }
                              }
                              break;

                        case 10:
                              this.Nhan_vat_co_ban_lon_nhat_HP = 0x91 + (this.Player_FLD_LEVEL * 12);
                              this.Nhan_vat_co_ban_lon_nhat_MP = 0x72 + (this.Player_FLD_LEVEL * 2);
                              this.FLD_TIM = 7;
                              this.FLD_SINH_MENH = 7 + (this.Player_FLD_LEVEL * 2);
                              this.FLD_TRUNG_MUC_TIEU = 8 + (this.Player_FLD_LEVEL * 2);
                              this.FLD_NE_TRANH = 8 + (this.Player_FLD_LEVEL * 2);
                              this.FLD_SUC_MANH = 10 + this.Player_FLD_LEVEL;
                              this.FLD_THAN_THE = 9 + (this.Player_FLD_LEVEL * 2);
                              this.FLD_ATTACK = 9 + (this.Player_FLD_LEVEL * 2);
                              this.FLD_PHONG_NGU = 0x10 + this.Player_FLD_LEVEL;
                              for (int num12 = 2; num12 <= this.Player_FLD_LEVEL; num12++)
                              {
                                    if ((num12 % 2) == 0)
                                    {
                                          num3 = this.FLD_TIM;
                                          this.FLD_TIM = num3 + 1;
                                    }
                                    else
                                    {
                                          this.FLD_TIM += 2;
                                    }
                              }
                              break;
                  }
                  this.CHUYEN_CHUC_TANG_CUONG_THUOC_TINH(this.Player_FLD_JOB_LEVEL);
                  this.TINH_TOAN_NHAN_VAT_TRANG_BI_SO_LIEU();
                  this.Production_Level();
            }

            public void BuyItem_Tip(int int_116)
            {
                  PacketData data = new PacketData();
                  data.Write4(5);
                  data.Write4(int_116);
                  if (this.Client != null)
                  {
                        this.Client.method_5(data, 0x9300, this.UserSessionID, 0);
                  }
            }

            public void Calculate_Basic_Char_Data_3()
            {
                  int num = this.Player_FLD_LEVEL;
                  int num2 = this.Player_FLD_LEVEL;
                  long num3 = this.NHAN_VAT_KINH_NGHIEM;
                  long num4 = this.NHAN_VAT_LON_NHAT_KINH_NGHIEM;
                  this.NHAN_VAT_LON_NHAT_KINH_NGHIEM = (long)World.lever[this.Player_FLD_LEVEL];
                  for (int i = 0; num3 >= num4; i++)
                  {
                        if (this.Player_FLD_LEVEL >= World.Nhan_vat_dang_cap_cao_nhat)
                        {
                              break;
                        }
                        if (i > 270)
                        {
                              return;
                        }
                        if (!this.Client.Running)
                        {
                              return;
                        }
                        num2++;
                        num4 = (long)World.lever[num2];
                  }
                  if ((num2 - num) > 0)
                  {
                        this.BasicCharacterData();
                        Players players = World.smethod_1(this.UserSessionID);
                        if (players != null)
                        {
                              players.UpdateHP_MP_SP();
                              players.UpdatePowersAndStatus();
                        }
                  }
            }

            public void CAP_NHAT_BIEU_HIEN_LINH_THU_SO_LIEU(Players class15_0)
            {
                  try
                  {
                        byte[] dst = Converter.hexStringToByte("AA55680001549C6400580001000000549C0000BDDCBDDC000000000000000000000000000000003203040000000000FA590544000070417F86C64465000000E69EA42770920F24000000008425A627000100009CBBFF43D322BDC370F9CD440000000000000000000000000055AA");
                        Buffer.BlockCopy(BitConverter.GetBytes(class15_0.NHAN_VAT_LINH_THU_TOAN_BO_TRANG_PHUC_ID), 0, dst, 15, 2);
                        byte[] bytes = Encoding.Default.GetBytes(class15_0.NHAN_VAT_LINH_THU.Name);
                        Buffer.BlockCopy(bytes, 0, dst, 0x13, bytes.Length);
                        Buffer.BlockCopy(BitConverter.GetBytes(class15_0.NHAN_VAT_LINH_THU.FLD_LEVEL), 0, dst, 0x27, 1);
                        Buffer.BlockCopy(BitConverter.GetBytes(class15_0.NHAN_VAT_LINH_THU.FLD_JOB_LEVEL), 0, dst, 40, 1);
                        Buffer.BlockCopy(BitConverter.GetBytes(class15_0.NHAN_VAT_LINH_THU.FLD_JOB), 0, dst, 0x29, 1);
                        Buffer.BlockCopy(BitConverter.GetBytes(class15_0.NHAN_VAT_LINH_THU.Bs), 0, dst, 0x2b, 1);
                        Buffer.BlockCopy(BitConverter.GetBytes(class15_0.NHAN_VAT_LINH_THU.NHAN_VAT_TOA_DO_X), 0, dst, 0x2f, 4);
                        Buffer.BlockCopy(BitConverter.GetBytes(class15_0.NHAN_VAT_LINH_THU.NHAN_VAT_TOA_DO_Z), 0, dst, 0x33, 4);
                        Buffer.BlockCopy(BitConverter.GetBytes(class15_0.NHAN_VAT_LINH_THU.NHAN_VAT_TOA_DO_Y), 0, dst, 0x37, 4);
                        Buffer.BlockCopy(BitConverter.GetBytes(class15_0.NHAN_VAT_LINH_THU.NHAN_VAT_TOA_DO_MAP), 0, dst, 0x3b, 2);
                        Buffer.BlockCopy(BitConverter.GetBytes(class15_0.NHAN_VAT_LINH_THU.NHAN_VAT_TOA_DO_X), 0, dst, 0x53, 4);
                        Buffer.BlockCopy(BitConverter.GetBytes(class15_0.NHAN_VAT_LINH_THU.NHAN_VAT_TOA_DO_Y), 0, dst, 0x5b, 4);
                        Buffer.BlockCopy(BitConverter.GetBytes(class15_0.NHAN_VAT_LINH_THU_TOAN_BO_TRANG_PHUC_ID), 0, dst, 5, 2);
                        int index = 0;
                        while (true)
                        {
                              if (index >= 4)
                              {
                                    break;
                              }
                              try
                              {
                                    byte[] buffer1 = class15_0.NHAN_VAT_LINH_THU.class23_1[index].VAT_PHAM_ID;
                              }
                              catch
                              {
                              }
                              index++;
                        }
                        if (this.Client != null)
                        {
                              this.Client.method_8(dst, dst.Length);
                        }
                  }
                  catch
                  {
                  }
            }

            public void CAP_NHAT_CA_NHAN_CUA_HANG_SO_LIEU(Players class15_0)
            {
                  if (class15_0.PlayerShop.PersonStore_Open)
                  {
                        PacketData data = new PacketData();
                        data.Write4(1);
                        data.Write4(class15_0.UserSessionID);
                        data.Write4(class15_0.UserSessionID);
                        data.Write2((byte)class15_0.PlayerShop.CUA_HANG_TEN.Length);
                        data.method_10(class15_0.PlayerShop.CUA_HANG_TEN, 0, class15_0.PlayerShop.CUA_HANG_TEN.Length);
                        if (this.Client != null)
                        {
                              if (class15_0.PlayerShop.int_0 == 1)
                              {
                                    this.Client.method_4(data, 0xca00, this.UserSessionID);
                              }
                              else if (class15_0.PlayerShop.int_0 == 2)
                              {
                                    this.Client.method_4(data, 0xa1c, this.UserSessionID);
                              }
                        }
                  }
            }

            public PacketData CAP_NHAT_THAY_DOI_NHAN_VAT_SO_LIEU(Players class15_0)
            {
                  PacketData data = new PacketData();
                  try
                  {
                        if (class15_0 == null)
                        {
                              return null;
                        }
                        if (class15_0.Client == null)
                        {
                              return null;
                        }
                        data.Write4(1);
                        data.Write4(class15_0.UserSessionID);
                        data.method_16(class15_0.UserName);
                        data.method_2(0);
                        data.Write4(class15_0.Bang_phai_Id);
                        data.method_16(class15_0.GuildName);
                        data.method_2(class15_0.Bang_phai_nhan_vat_thu_bac);
                        if (class15_0.Bang_phai_mon_huy != null)
                        {
                              data.Write2(World.Server_Group_ID);
                        }
                        else
                        {
                              data.Write2(0);
                        }
                        data.method_2(class15_0.Player_Zx);
                        data.method_2(class15_0.Player_FLD_LEVEL);
                        data.method_2(class15_0.Player_FLD_JOB_LEVEL);
                        data.method_2(class15_0.Player_Job);
                        data.method_2(1);
                        data.method_2(0);
                        data.Write2(class15_0.class84_0.MAU_TOC);
                        data.Write2(class15_0.class84_0.KIEU_TOC);
                        data.method_2(1);
                        data.method_2(0);
                        data.method_2(0);
                        data.method_2(class15_0.class84_0.GIOI_TINH);
                        data.method_1(class15_0.CharacterCoords_X);
                        data.method_1(class15_0.CharacterCoords_Z);
                        data.method_1(class15_0.CharacterCoords_Y);
                        data.Write4(class15_0.CharacterCoords_Map);
                        data.Write4(BitConverter.ToInt32(class15_0.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[0].VAT_PHAM_ID, 0));
                        data.Write4(0);
                        data.Write4(BitConverter.ToInt32(class15_0.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[1].VAT_PHAM_ID, 0));
                        data.Write4(0);
                        data.Write4(BitConverter.ToInt32(class15_0.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[4].VAT_PHAM_ID, 0));
                        data.Write4(0);
                        data.Write4(BitConverter.ToInt32(class15_0.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[2].VAT_PHAM_ID, 0));
                        data.Write4(0);
                        data.Write4(BitConverter.ToInt32(class15_0.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[3].VAT_PHAM_ID, 0));
                        data.Write4(0);
                        data.Write4(BitConverter.ToInt32(class15_0.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[5].VAT_PHAM_ID, 0));
                        data.Write4(0);
                        data.Write4(class15_0.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[3].FLD_cuong_hoa_so_luong);
                        data.Write4(0);
                        data.Write4(0);
                        data.Write4(0);
                        data.Write4(0);
                        data.Write4(BitConverter.ToInt32(class15_0.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[11].VAT_PHAM_ID, 0));
                        data.Write4(0);
                        int num = ConfigClass.smethod_0(class15_0.Config);
                        if ((class15_0.Add_Status_List != null) && class15_0.Add_Status_List.ContainsKey(0xaae6e))
                        {
                              num += 8;
                        }
                        else if (class15_0.Config.原著衣服 == 0)
                        {
                              num -= 0x40;
                        }
                        data.method_2(num);
                        if (class15_0.Player_Job == 7)
                        {
                              if (class15_0.Add_Status_List != null)
                              {
                                    if (class15_0.Add_Status_List.ContainsKey(0xdbd31))
                                    {
                                          data.method_2(0x12);
                                    }
                                    else if (class15_0.Add_Status_List.ContainsKey(0xdbd32))
                                    {
                                          data.method_2(0x22);
                                    }
                                    else if (class15_0.Add_Status_List.ContainsKey(0xdbd33))
                                    {
                                          data.method_2(0x42);
                                    }
                                    else if (class15_0.Config.Vo_Huan_mo_ra != 0)
                                    {
                                          data.method_2(1);
                                    }
                                    else
                                    {
                                          data.method_2(0);
                                    }
                              }
                              else if (class15_0.Config.Vo_Huan_mo_ra != 0)
                              {
                                    data.method_2(1);
                              }
                              else
                              {
                                    data.method_2(0);
                              }
                        }
                        else if (class15_0.Config.Vo_Huan_mo_ra != 0)
                        {
                              data.method_2(1);
                        }
                        else
                        {
                              data.method_2(0);
                        }
                        data.Write2(0);
                        data.method_1(class15_0.CharacterCoords_X);
                        data.method_1(class15_0.CharacterCoords_Z);
                        data.method_1(class15_0.CharacterCoords_Y);
                        data.Write4(0);
                        data.Write4(0);
                        if (class15_0.NHAN_VAT_LINH_THU != null)
                        {
                              if (class15_0.NHAN_VAT_LINH_THU.CUOI_THU == 1)
                              {
                                    data.Write4(3);
                              }
                              else
                              {
                                    data.Write4(0);
                              }
                        }
                        else
                        {
                              data.Write4(0xff);
                        }
                        data.Write4(BitConverter.ToInt32(class15_0.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[13].VAT_PHAM_ID, 0));
                        data.Write4(0);
                        data.Write4(0);
                        data.Write2(class15_0.BANG_PHAI_TRANG_PHUC_KI_TU);
                        data.Write2(class15_0.BANG_PHAI_MON_PHUC_MAU_SAC);
                        data.Write4(class15_0.Player_WuXun);
                        if (class15_0.CharacterCoords_Map == 0x321)
                        {
                              data.Write4(0);
                        }
                        else
                        {
                              data.Write4(class15_0.NHAN_VAT_THIEN_AC);
                        }
                        data.Write2(0);
                        data.Write2(class15_0.PlayerPKMode);
                        if (class15_0.Add_Status_List != null)
                        {
                              if (class15_0.Add_Status_List.ContainsKey(0x3c14dcb7))
                              {
                                    data.Write4(2);
                              }
                              else if (class15_0.Add_Status_List.ContainsKey(0x3c14dc9c))
                              {
                                    data.Write4(1);
                              }
                              else if (class15_0.Add_Status_List.ContainsKey(0x3c14dcc3))
                              {
                                    data.Write4(4);
                              }
                              else if (class15_0.Add_Status_List.ContainsKey(0x3c14dcbb))
                              {
                                    data.Write4(3);
                              }
                              else
                              {
                                    data.Write4(0);
                              }
                        }
                        else
                        {
                              data.Write4(0);
                        }
                        data.Write4(class15_0.int_9);
                        if (class15_0.Add_Status_List != null)
                        {
                              if (class15_0.Add_Status_List.ContainsKey(0x3c14dcbc))
                              {
                                    data.Write4(1);
                              }
                              else if (class15_0.Add_Status_List.ContainsKey(0x3c14dcfc))
                              {
                                    data.Write4(20);
                              }
                              else if (class15_0.Add_Status_List.ContainsKey(0x3c14dcf5))
                              {
                                    data.Write4(8);
                              }
                              else if (class15_0.Add_Status_List.ContainsKey(0x3c14dce8))
                              {
                                    data.Write4(6);
                              }
                              else
                              {
                                    data.Write4(0);
                              }
                        }
                        else
                        {
                              data.Write4(0);
                        }
                        data.method_10(class15_0.NHAN_VAT_TEN_MAU, 0, 0x30);
                        data.Write4(0);
                        if (class15_0.Config.蔬菜武器开关 == 1)
                        {
                              if (class15_0.Add_Status_List != null)
                              {
                                    if ((!class15_0.Add_Status_List.ContainsKey(0x3c14dcf0) && !class15_0.Add_Status_List.ContainsKey(0x3c14dcf1)) && !class15_0.Add_Status_List.ContainsKey(0x3c14dcf2))
                                    {
                                          if (!class15_0.Add_Status_List.ContainsKey(0x3c14dcfa) && !class15_0.Add_Status_List.ContainsKey(0x3c14dcfb))
                                          {
                                                if (!class15_0.Add_Status_List.ContainsKey(0x3c14dd30) && !class15_0.Add_Status_List.ContainsKey(0x3c14dd31))
                                                {
                                                      if (!class15_0.Add_Status_List.ContainsKey(0x3c14dd32) && !class15_0.Add_Status_List.ContainsKey(0x3c14dd33))
                                                      {
                                                            if (!class15_0.Add_Status_List.ContainsKey(0x3c14dd45) && !class15_0.Add_Status_List.ContainsKey(0x3c14dd46))
                                                            {
                                                                  data.Write4(0);
                                                            }
                                                            else
                                                            {
                                                                  data.Write4(4);
                                                            }
                                                      }
                                                      else
                                                      {
                                                            data.Write4(3);
                                                      }
                                                }
                                                else
                                                {
                                                      data.Write4(3);
                                                }
                                          }
                                          else
                                          {
                                                data.Write4(2);
                                          }
                                    }
                                    else
                                    {
                                          data.Write4(1);
                                    }
                              }
                              else
                              {
                                    data.Write4(0);
                              }
                        }
                        else
                        {
                              data.Write4(0);
                        }
                        if (World.Tinh_nhan_mo_ra == 1)
                        {
                              if (class15_0.FLD_TINH_NHAN != "")
                              {
                                    data.method_2(1);
                                    data.method_16(class15_0.FLD_TINH_NHAN);
                                    data.method_2(3);
                              }
                              else
                              {
                                    data.method_2(0);
                                    data.method_16("");
                                    data.method_2(0);
                              }
                        }
                        else
                        {
                              data.method_2(0);
                              data.method_16("");
                              data.method_2(0);
                        }
                        data.method_2(0);
                        data.method_2(0);
                        data.method_2(0);
                        data.method_2(0);
                        data.method_2(class15_0.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[3].FLD_FJ_tien_hoa);
                        data.method_2(class15_0.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[3].FLD_thuoc_tinh_loai_hinh);
                        data.method_2(class15_0.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[3].FLD_thuoc_tinh_so_luong);
                        if ((class15_0.Chuyen_sinh_so_lan > 0) && (class15_0.CharacterCoords_Map != 0x321))
                        {
                              data.Write2(1);
                        }
                        else if ((class15_0.CharacterCoords_Map == 0x321) && (class15_0.Evil_mode == 1))
                        {
                              data.Write2(1);
                        }
                        else
                        {
                              data.Write2(0);
                        }
                        data.Write2(class15_0.class84_0.GIOI_TINH);
                        data.Write2(class15_0.NHAN_VAT_VO_HUAN_GIAI_DOAN);
                        data.Write2(0);
                        if (class15_0.Add_Status_List != null)
                        {
                              if (class15_0.Add_Status_List.ContainsKey(0x3c14e12d))
                              {
                                    data.Write2(0xf1);
                                    data.Write2(1);
                              }
                              else if (class15_0.Add_Status_List.ContainsKey(0x3c14e0b0))
                              {
                                    data.Write2(0x8d);
                                    data.Write2(0x6f);
                              }
                              else
                              {
                                    data.Write2(0);
                                    data.Write2(0);
                              }
                        }
                        else
                        {
                              data.Write2(0);
                              data.Write2(0);
                        }
                        data.Write2(0);
                        if (class15_0.NHAN_VAT_LINH_THU != null)
                        {
                              data.Write2(1);
                              data.Write2(class15_0.NHAN_VAT_LINH_THU_TOAN_BO_TRANG_PHUC_ID);
                              data.method_15(class15_0.NHAN_VAT_LINH_THU.Name, 14);
                              data.Write2(0);
                              data.Write4(0);
                              data.method_2(class15_0.NHAN_VAT_LINH_THU.FLD_LEVEL);
                              data.method_2(class15_0.NHAN_VAT_LINH_THU.FLD_JOB_LEVEL);
                              data.Write2(class15_0.NHAN_VAT_LINH_THU.FLD_JOB);
                              data.Write2(class15_0.NHAN_VAT_LINH_THU.Bs);
                              if (class15_0.NHAN_VAT_LINH_THU.FLD_JOB_LEVEL == 1)
                              {
                                    data.Write4(class15_0.NHAN_VAT_LINH_THU.class79_0[1].FLD_PID);
                                    data.Write4(class15_0.NHAN_VAT_LINH_THU.class79_0[1].FLD_INDEX);
                              }
                              else if (class15_0.NHAN_VAT_LINH_THU.FLD_JOB_LEVEL == 2)
                              {
                                    data.Write4(class15_0.NHAN_VAT_LINH_THU.class79_0[2].FLD_PID);
                                    data.Write4(class15_0.NHAN_VAT_LINH_THU.class79_0[2].FLD_INDEX);
                              }
                              else if (class15_0.NHAN_VAT_LINH_THU.FLD_JOB_LEVEL == 3)
                              {
                                    data.Write4(class15_0.NHAN_VAT_LINH_THU.class79_0[3].FLD_PID);
                                    data.Write4(class15_0.NHAN_VAT_LINH_THU.class79_0[3].FLD_INDEX);
                              }
                              else
                              {
                                    data.Write4(0);
                                    data.Write4(0);
                              }
                              for (int i = 0; i < 5; i++)
                              {
                                    data.method_6(class15_0.NHAN_VAT_LINH_THU.class23_1[i].GetItem_ID);
                              }
                              data.method_0(new byte[0x10]);
                        }
                        else
                        {
                              data.method_0(new byte[0x4a]);
                        }
                        return data;
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, string.Concat(new object[] { "得到更新人物数据 出错", this.Client.int_3, "|", this.Client.ToString(), " ", Converter.smethod_24(data.method_17()), " ", exception }));
                        return null;
                  }
            }

            private void CHUYEN_CHUC_TANG_CUONG_THUOC_TINH(int int_116)
            {
                  if (int_116 != 0)
                  {
                        DINH_NGHIA_CHUYEN_CHUC_THUOC_TINH dinh_nghia_chuyen_chuc_thuoc_tinh = new DINH_NGHIA_CHUYEN_CHUC_THUOC_TINH().method_0(int_116);
                        this.FLD_ATTACK += dinh_nghia_chuyen_chuc_thuoc_tinh.FLD_AT;
                        this.FLD_PHONG_NGU += dinh_nghia_chuyen_chuc_thuoc_tinh.FLD_DF;
                        this.Nhan_vat_co_ban_lon_nhat_HP += dinh_nghia_chuyen_chuc_thuoc_tinh.FLD_HP;
                        this.Nhan_vat_co_ban_lon_nhat_MP += dinh_nghia_chuyen_chuc_thuoc_tinh.FLD_MP;
                  }
            }

            public void ClearQigqong()
            {
                  for (int i = 0; i < 12; i++)
                  {
                        this.Qigong[i] = new QigongClass(new byte[4]);
                  }
            }

            public void Decomposite_Tip(int int_116)
            {
                  PacketData data = new PacketData();
                  data.Write4(int_116);
                  if (this.Client != null)
                  {
                        this.Client.method_4(data, 0x3117, this.UserSessionID);
                  }
            }

            public void DLL_FLD_THEM_VAO_TI_LE_PHAN_TRAM_PHONG_NGU(decimal decimal_2)
            {
                  using (new Lock(this.object_2, "dllFLD_追加百分比_防御"))
                  {
                        this.FLD_them_vao_ti_le_phan_tram_phong_ngu -= decimal_2;
                  }
            }

            public void DLL_FLD_trang_bi_them_vao_vu_khi_cuong_hoa(int int_116)
            {
                  using (new Lock(this.object_2, "dllFLD_装备_追加_武器_强化"))
                  {
                        this.FLD_trang_bi_them_vao_vu_khi_cuong_hoa -= int_116;
                  }
            }

            public void dllFLD_ATT_Percentage(decimal decimal_2)
            {
                  using (new Lock(this.object_2, "dllFLD_追加百分比_攻击"))
                  {
                        this.FLD_them_vao_ti_le_phan_tram_cong_kich -= decimal_2;
                  }
            }

            public void dllFLD_TRANG_BI_THEM_VAO_PHONG_NGU_CUONG_HOA(int int_116)
            {
                  using (new Lock(this.object_2, "dllFLD_装备_追加_防具_强化"))
                  {
                        this.FLD_trang_bi_them_vao_Phong_cu_Cuong_hoa -= int_116;
                  }
            }

            public void DOC_DU_LIEU_PET(long long_16)
            {
                  try
                  {
                        DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM TBL_XWWL_Cw WHERE ItmeId ={long_16}");
                        if (dBToDataTable.Rows.Count > 0)
                        {
                              this.NHAN_VAT_LINH_THU = new PET_CLASS(long_16, this.Client, dBToDataTable);
                              this.NHAN_VAT_LINH_THU.int_17 = this.NHAN_VAT_LINH_THU_TOAN_BO_TRANG_PHUC_ID;
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, string.Concat(new object[] { "读出灵兽数据出错 [", this.Userid, "][", this.UserName, "][", long_16, "] ", exception.Message }));
                  }
            }

            public void DOC_SO_LIEU_BANG_PHAI()
            {
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "PlayersBes_读帮派数据()");
                  }
                  DataTable table = RxjhClass.EXE_LOAD_GUILD(this.UserName);
                  if (table != null)
                  {
                        this.Bang_phai_Id = (int)table.Rows[0]["Id"];
                        this.GuildName = table.Rows[0]["G_Name"].ToString();
                        this.Bang_phai_nhan_vat_thu_bac = (int)table.Rows[0]["leve"];
                        this.BANG_PHAI_TRANG_PHUC_KI_TU = (int)table.Rows[0]["Mon_trang_phuc_tu"];
                        this.BANG_PHAI_MON_PHUC_MAU_SAC = (int)table.Rows[0]["Mon_trang_phuc_mau_sac"];
                        try
                        {
                              if (table.Rows[0]["Mh"] != DBNull.Value)
                              {
                                    this.Bang_phai_mon_huy = (byte[])table.Rows[0]["Mh"];
                              }
                        }
                        catch (Exception)
                        {
                        }
                        table.Dispose();
                  }
                  else
                  {
                        this.Bang_phai_Id = 0;
                        this.GuildName = string.Empty;
                        this.Bang_phai_nhan_vat_thu_bac = 0;
                        this.Bang_phai_mon_huy = null;
                  }
            }

            public int DUOC_KIEN_HANG_RONG(Players class15_0)
            {
                  for (int i = 0; i < 0x42; i++)
                  {
                        if (BitConverter.ToInt32(class15_0.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[12].VAT_PHAM_ID, 0) != 0)
                        {
                              if (i == 12)
                              {
                                    i++;
                              }
                              if (BitConverter.ToInt32(class15_0.TRANG_BI_LAN_BAO_VAY[i].VAT_PHAM_ID, 0) == 0)
                              {
                                    return i;
                              }
                        }
                        else if (BitConverter.ToInt32(class15_0.TRANG_BI_LAN_BAO_VAY[i].VAT_PHAM_ID, 0) == 0)
                        {
                              return i;
                        }
                  }
                  return -1;
            }

            public int DUOC_KIEN_HANG_RONG_VI_TRI()
            {
                  for (int i = 0; i < 0x42; i++)
                  {
                        if (BitConverter.ToInt32(this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[12].VAT_PHAM_ID, 0) != 0)
                        {
                              if (i == 12)
                              {
                                    i++;
                              }
                              if (BitConverter.ToInt32(this.TRANG_BI_LAN_BAO_VAY[i].VAT_PHAM_ID, 0) == 0)
                              {
                                    return i;
                              }
                        }
                        else if (BitConverter.ToInt32(this.TRANG_BI_LAN_BAO_VAY[i].VAT_PHAM_ID, 0) == 0)
                        {
                              return i;
                        }
                  }
                  return -1;
            }

            public void EquipmentBasket_Wrapped()
            {
                  PacketData data = new PacketData();
                  data.Write4(0x101);
                  if (World.BackPack_Switch == 1)
                  {
                        data.Write4(2);
                  }
                  else
                  {
                        data.Write4(0);
                  }
                  for (int i = 0; i < 0x42; i++)
                  {
                        if (BitConverter.ToInt32(this.TRANG_BI_LAN_BAO_VAY[i].VAT_PHAM_SO_LUONG, 0) == 0)
                        {
                              this.TRANG_BI_LAN_BAO_VAY[i].Item_byte = new byte[0x49];
                        }
                        else
                        {
                              this.method_12("TRANG_BI_LAN_BAO_VAY", ref this.TRANG_BI_LAN_BAO_VAY[i]);
                        }
                        if (((this.TRANG_BI_LAN_BAO_VAY[i].FLD_FJ_trung_cap_phu_hon <= 0x16) && (this.TRANG_BI_LAN_BAO_VAY[i].FLD_FJ_trung_cap_phu_hon >= 0x15)) && (this.TRANG_BI_LAN_BAO_VAY[i].FLD_FJ_thuc_tinh > 0))
                        {
                              this.TRANG_BI_LAN_BAO_VAY[i].Item_trung_cap_phu_hon_them_vao_thuc_tinh = this.TRANG_BI_LAN_BAO_VAY[i].FLD_FJ_trung_cap_phu_hon - 20;
                        }
                        data.method_10(this.TRANG_BI_LAN_BAO_VAY[i].method_0(), 0, World.int_5);
                  }
                  if (this.Client != null)
                  {
                        this.Client.method_5(data, 0x7100, this.UserSessionID, 0);
                  }
            }

            ~PlayersBes()
            {
            }

            public void GameMessage(string string_10, int int_116, string string_11)
            {
                  Class53 class2;
                  Class53 class3;
                  if (World.dictionary_28.TryGetValue(string_10, out class2))
                  {
                        string_10 = class2.string_1;
                  }
                  if (World.dictionary_28.TryGetValue(string_11, out class3))
                  {
                        string_11 = class3.string_1;
                  }
                  byte[] dst = Converter.hexStringToByte("AA55A6000000006600970000C8CEBD000000000000000000000000000000000000003000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000055AA");
                  dst[11] = (byte)int_116;
                  byte[] bytes = Encoding.Default.GetBytes(string_11);
                  byte[] src = Encoding.Default.GetBytes(string_10);
                  Buffer.BlockCopy(bytes, 0, dst, 12, bytes.Length);
                  Buffer.BlockCopy(src, 0, dst, 0x23, src.Length);
                  Buffer.BlockCopy(BitConverter.GetBytes(0), 0, dst, 5, 2);
                  if (this.Client != null)
                  {
                        this.Client.Send(dst, dst.Length);
                  }
            }

            public byte[] GET_CA_NHAN_DUOC_PHAM_BYTE()
            {
                  int num = 0;
                  byte[] dst = new byte[320];
                  try
                  {
                        foreach (Additional_Sate_Class class2 in this.Add_Status_List.Values)
                        {
                              if (class2.FLD_RESIDE1 == 1)
                              {
                                    Buffer.BlockCopy(BitConverter.GetBytes(class2.FLD_PID), 0, dst, num * 8, 4);
                                    Buffer.BlockCopy(BitConverter.GetBytes(class2.FLD_sj), 0, dst, (num * 8) + 4, 4);
                                    num++;
                              }
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "保存的数据出错_Get个人药品byte[" + this.Userid + "]-[" + this.UserName + "]" + exception.Message);
                  }
                  return dst;
            }

            public byte[] GET_CA_NHAN_DUOC_PHAM_NEW_BYTE()
            {
                  int num = 0;
                  byte[] dst = new byte[240];
                  try
                  {
                        foreach (THEM_VAO_TRANG_THAI_NEW local1 in this.threadSafeDictionary_3.Values)
                        {
                              Buffer.BlockCopy(BitConverter.GetBytes(local1.FLD_PID), 0, dst, num * 0x10, 4);
                              Buffer.BlockCopy(BitConverter.GetBytes(local1.FLD_sj), 0, dst, (num * 0x10) + 4, 4);
                              Buffer.BlockCopy(BitConverter.GetBytes(local1.SO_LUONG), 0, dst, (num * 0x10) + 8, 4);
                              Buffer.BlockCopy(BitConverter.GetBytes(local1.SO_LUONG_LOAI_HINH), 0, dst, (num * 0x10) + 12, 4);
                              num++;
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "保存的数据出错_Get个人药品Newbyte[" + this.Userid + "]-[" + this.UserName + "]" + exception.Message);
                  }
                  return dst;
            }

            public byte[] GET_CA_NHAN_NHA_KHO_BYTE()
            {
                  byte[] dst = new byte[0x111c];
                  try
                  {
                        for (int i = 0; i < 60; i++)
                        {
                              try
                              {
                                    Buffer.BlockCopy(this.class23_0[i].Item_byte, 0, dst, i * 0x49, 0x49);
                              }
                              catch
                              {
                                    Buffer.BlockCopy(new byte[0x49], 0, dst, i * 0x49, 0x49);
                              }
                        }
                        return dst;
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "保存的数据出错_Get个人仓库byte[" + this.Userid + "]-[" + this.UserName + "]" + exception.Message);
                  }
                  return dst;
            }

            public Players Get_char_data(int int_116)
            {
                  Players players;
                  if (World.allConnectedChars.TryGetValue(int_116, out players))
                  {
                        return players;
                  }
                  return null;
            }

            public Players Get_Char_Data(string string_10)
            {
                  try
                  {
                        foreach (Players players in World.allConnectedChars.Values)
                        {
                              if (players.UserName == string_10)
                              {
                                    return players;
                              }
                        }
                        return null;
                  }
                  catch
                  {
                        return null;
                  }
            }

            public void Get_Money_Tip(uint uint_0)
            {
                  byte[] dst = Converter.hexStringToByte("AA55430000EA010D0034000100000000000000000000000094357700000000A701000000000000000000000000000000000000000000000000000000000000000000000000000055AA");
                  byte[] bytes = BitConverter.GetBytes(uint_0);
                  Buffer.BlockCopy(bytes, 0, dst, 0x1f, bytes.Length);
                  Buffer.BlockCopy(BitConverter.GetBytes(this.UserSessionID), 0, dst, 5, 2);
                  if (this.Client != null)
                  {
                        this.Client.Send(dst, dst.Length);
                  }
            }

            //퀘스트
            public byte[] GET_NHIEM_VU_BYTE()
            {
                  PacketData data = new PacketData();
                  try
                  {
                        foreach (NHIEM_VU_CLASS nhiem_vu_class in this.dictionary_2.Values)
                        {
                              data.Write2(nhiem_vu_class.NHIEM_VU_ID);
                              data.Write2(nhiem_vu_class.NHIEM_VU_GIAI_DOAN_ID);
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "保存的数据出错_Get任务byte[" + this.Userid + "]-[" + this.UserName + "]" + exception.Message);
                  }
                  return data.method_17();
            }

            public byte[] Get_THO_LINH_PHU_byte()
            {
                  byte[] dst = new byte[990];
                  try
                  {
                        foreach (DictionaryEntry entry in this.hashtable_0)
                        {
                              TBL_XWWL_MAP tbl_xwwl_map = (TBL_XWWL_MAP)entry.Value;
                              int key = (int)entry.Key;
                              if (key >= 10)
                              {
                                    Buffer.BlockCopy(Encoding.Default.GetBytes(tbl_xwwl_map.Rxjh_name), 0, dst, (key - 10) * 0x20, Encoding.Default.GetBytes(tbl_xwwl_map.Rxjh_name).Length);
                                    Buffer.BlockCopy(BitConverter.GetBytes(tbl_xwwl_map.Rxjh_Map), 0, dst, ((key - 10) * 0x20) + 15, 4);
                                    Buffer.BlockCopy(BitConverter.GetBytes(tbl_xwwl_map.Rxjh_X), 0, dst, ((key - 10) * 0x20) + 0x13, 4);
                                    Buffer.BlockCopy(BitConverter.GetBytes(tbl_xwwl_map.Rxjh_Y), 0, dst, ((key - 10) * 0x20) + 0x17, 4);
                                    Buffer.BlockCopy(BitConverter.GetBytes(tbl_xwwl_map.Rxjh_Z), 0, dst, ((key - 10) * 0x20) + 0x1b, 4);
                              }
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "保存的数据出错_Get土灵符byte[" + this.Userid + "]-[" + this.UserName + "]" + exception.Message);
                  }
                  return dst;
            }

            public byte[] GET_THOI_GIAN_TRUC_TUYEN() =>
                this.byte_2;

            public byte[] GET_TONG_HOP_KHO_VAT_PHAM_BYTE()
            {
                  byte[] dst = new byte[0x10];
                  try
                  {
                        int num = 0;
                        foreach (PUBLIC_DUOC_PHAM_LOAI local1 in this.dictionary_3.Values)
                        {
                              Buffer.BlockCopy(BitConverter.GetBytes(local1.DUOC_PHAM_ID), 0, dst, num * 8, 4);
                              Buffer.BlockCopy(BitConverter.GetBytes(local1.THOI_GIAN), 0, dst, (num * 8) + 4, 4);
                              num++;
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, string.Concat(new object[] { "保存的数据出错_Get综合仓库品byte[", this.Userid, "]-[", this.UserName, "][", this.dictionary_3.Count, "]", exception.Message }));
                  }
                  return dst;
            }

            public byte[] GET_TONG_HOP_NHA_KHO_BYTE()
            {
                  byte[] dst = new byte[0x111c];
                  try
                  {
                        for (int i = 0; i < 60; i++)
                        {
                              try
                              {
                                    Buffer.BlockCopy(this.class23_1[i].Item_byte, 0, dst, i * 0x49, 0x49);
                              }
                              catch
                              {
                                    Buffer.BlockCopy(new byte[0x49], 0, dst, i * 0x49, 0x49);
                              }
                        }
                        return dst;
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "保存的数据出错_Get综合仓库byte[" + this.Userid + "]-[" + this.UserName + "]" + exception.Message);
                  }
                  return dst;
            }

            public byte[] GetFLD_ITEMCodesbyte()
            {
                  byte[] dst = new byte[0x12d2];
                  try
                  {
                        for (int i = 0; i < 0x42; i++)
                        {
                              try
                              {
                                    Buffer.BlockCopy(this.TRANG_BI_LAN_BAO_VAY[i].Item_byte, 0, dst, i * 0x49, 0x49);
                              }
                              catch
                              {
                                    Buffer.BlockCopy(new byte[0x49], 0, dst, i * 0x49, 0x49);
                              }
                        }
                        return dst;
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "保存的数据出错_GetFLD_ITEMCodesbyte[" + this.Userid + "]-[" + this.UserName + "]" + exception.Message);
                  }
                  return dst;
            }

            public byte[] GetFLD_KONGFUCodesbyte()
            {
                  PacketData data = new PacketData();
                  try
                  {
                        for (int i = 0; i < 3; i++)
                        {
                              for (int j = 0; j < 0x26; j++)
                              {
                                    if (this.class79_0[i, j] != null)
                                    {
                                          data.Write4(this.class79_0[i, j].FLD_PID);
                                          data.Write2(this.class79_0[i, j].VO_CONG_THU_BAC);
                                    }
                              }
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "保存的数据出错_GetFLD_KONGFUCodesbyte[" + this.Userid + "]-[" + this.UserName + "]" + exception.Message);
                  }
                  return data.method_17();
            }

            private int GetQigongID(int KHI_CONG_ID)
            {
                  if (KHI_CONG_ID >= 10)
                  {
                        if (this.Player_Job == 8)
                        {
                              return (((this.Player_Job * 10) + 170) + 10);
                        }
                        if (this.Player_Job == 9)
                        {
                              return ((KHI_CONG_ID + (10 * this.Player_Job)) + 180);
                        }
                        if (this.Player_Job == 7)
                        {
                              return (((this.Player_Job * 10) + 100) + 10);
                        }
                        if (this.Player_Job == 6)
                        {
                              return (((this.Player_Job * 10) + 100) + 10);
                        }
                        if (this.Player_Job == 10)
                        {
                              return ((KHI_CONG_ID + (10 * this.Player_Job)) + 450);
                        }
                        return ((this.Player_Job * 10) + 100);
                  }
                  if (this.Player_Job == 8)
                  {
                        if (KHI_CONG_ID == 6)
                        {
                              return 0x10;
                        }
                        return ((KHI_CONG_ID + (10 * this.Player_Job)) + 170);
                  }
                  if (this.Player_Job == 9)
                  {
                        return ((KHI_CONG_ID + (10 * this.Player_Job)) + 180);
                  }
                  if (this.Player_Job == 7)
                  {
                        return ((KHI_CONG_ID + (10 * this.Player_Job)) + 10);
                  }
                  if (this.Player_Job == 6)
                  {
                        return ((KHI_CONG_ID + (10 * this.Player_Job)) + 10);
                  }
                  if (this.Player_Job == 10)
                  {
                        return ((KHI_CONG_ID + (10 * this.Player_Job)) + 450);
                  }
                  return (KHI_CONG_ID + (10 * this.Player_Job));
            }

            public byte[] GetQuestITEMCodesbyte()
            {
                  byte[] dst = new byte[0x120];
                  try
                  {
                        for (int i = 0; i < 0x24; i++)
                        {
                              try
                              {
                                    Buffer.BlockCopy(this.class22_0[i].byte_0, 0, dst, i * 8, 8);
                              }
                              catch
                              {
                                    Buffer.BlockCopy(new byte[8], 0, dst, i * 8, 8);
                              }
                        }
                        return dst;
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "保存的数据出错GetQuestITEMCodesbyte[" + this.Userid + "]-[" + this.UserName + "]" + exception.Message);
                  }
                  return dst;
            }

            public byte[] GetTHANG_THIEN_KHI_CONG_Codesbyte()
            {
                  PacketData data = new PacketData();
                  try
                  {
                        foreach (THANG_THIEN_KHI_CONG_LOAI thang_thien_khi_cong_loai in this.THANG_THIEN_KHI_CONG.Values)
                        {
                              data.Write2(thang_thien_khi_cong_loai.KHI_CONG_ID);
                              data.Write2(thang_thien_khi_cong_loai.KHI_CONG_SO_LUONG);
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "保存的数据出错_GetTHANG_THIEN_KHI_CONGodesbyte[" + this.Userid + "]-[" + this.UserName + "]" + exception.Message);
                  }
                  return data.method_17();
            }

            public byte[] GetTHANG_THIEN_VO_CONG_Codesbyte()
            {
                  PacketData data = new PacketData();
                  try
                  {
                        for (int i = 0; i < 0x20; i++)
                        {
                              if (this.class79_0[3, i] != null)
                              {
                                    data.Write4(this.class79_0[3, i].FLD_PID);
                                    data.Write4(this.class79_0[3, i].VO_CONG_THU_BAC);
                              }
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "保存的数据出错_Get升天Vo_CongCodesbyte[" + this.Userid + "]-[" + this.UserName + "]" + exception.Message);
                  }
                  return data.method_17();
            }

            public byte[] GetWEARITEMCodesbyte()
            {
                  byte[] dst = new byte[0x447];
                  try
                  {
                        for (int i = 0; i < 15; i++)
                        {
                              try
                              {
                                    Buffer.BlockCopy(this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_byte, 0, dst, i * 0x49, 0x49);
                              }
                              catch
                              {
                                    Buffer.BlockCopy(new byte[0x49], 0, dst, i * 0x49, 0x49);
                              }
                        }
                        return dst;
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "保存的数据出错_GetWEARITEMCodesbyte[" + this.Userid + "]-[" + this.UserName + "]" + exception.Message);
                  }
                  return dst;
            }

            public byte[] GetWEARITEMFZCodesbyte()
            {
                  byte[] dst = new byte[0x447];
                  try
                  {
                        for (int i = 0; i < 15; i++)
                        {
                              try
                              {
                                    Buffer.BlockCopy(this.class23_4[i].Item_byte, 0, dst, i * 0x49, 0x49);
                              }
                              catch
                              {
                                    Buffer.BlockCopy(new byte[0x49], 0, dst, i * 0x49, 0x49);
                              }
                        }
                        return dst;
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "保存的数据出错_GetWEARITEMFZCodesbyte[" + this.Userid + "]-[" + this.UserName + "]" + exception.Message);
                  }
                  return dst;
            }

            public byte[] GetWgCodesbyte()
            {
                  byte[] dst = new byte[20];
                  try
                  {
                        for (int i = 0; i < 12; i++)
                        {
                              byte[] buffer2;
                              try
                              {
                                    buffer2 = this.Qigong[i].气功_byte;
                              }
                              catch
                              {
                                    buffer2 = new byte[2];
                              }
                              Buffer.BlockCopy(buffer2, 0, dst, i, 1);
                        }
                        return dst;
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "保存的数据出错_GetWgCodesbyte[" + this.Userid + "]-[" + this.UserName + "]" + exception.Message);
                  }
                  return dst;
            }

            public void GUI_DI_MON_HUY(Players class15_0, Players class15_1)
            {
                  byte[] dst = Converter.hexStringToByte("AA551903010A00EB000A034200000001000100FF00FFFF00FF0000FF0000FFFF00FFFF00FFFF00FFFF00FFFF00FFFF00FFFFFF80FF00FFFFFF80FFFF80FFFF80FFFF80FF00FFFF00FF0000FF0000FF0000FFFF00FFFF00FFFF00FFFF00FFFF00FFFFFF80FF00FFFFFF80FFFF80FFFF80FFFF80FF00FFFF00FF0000FFFF00FF0000FFFF00FF0000FFFF00FFFF00FFFFFF80FF00FFFFFF80FFFF80FFFF80FF00FFFFFF80FF00FFFF00FF0000FFFF00FF0000FFFF00FF0000FFFF00FFFF00FFFFFF80FFFF80FFFF80FFFF80FF00FFFFFF80FFFF80FF00FFFF00FF0000FFFF00FF0000FF0000FF0000FFFF00FFFF00FFFFFF80FFFF80FFFF80FFFF80FF00FFFFFF80FFFF80FF00FFFF00FF0000FFFF00FFFF00FF0000FF0000FF0000FFFFFF80FFFF80FFFF80FFFF80FFFF80FFFF80FFFF80FF00FFFF00FFFF00FF0000FFFF00FFFF00FF0000FFFF00FF0000FFFFFF80FFFF80FF0000FFFF80FFFF80FFFF80FFFF80FF0000FF00FFFF0000FF0000FF0000FF0000FF0000FF0000FFFF80FFFF80FF0000FF0000FFFF80FFFF80FFFF80FF00FFFF00FFFF00FFFF00FFFF0000FF0000FF0000FF0000FFFF80FF0000FFFF80FF0000FF0000FFFF80FFFF80FFFF80FF0000FF0000FF0000FF0000FF0000FF0000FF0000FFFF80FF0000FF0000FFFF80FF0000FF0000FFFF80FFFF80FF0000FF0000FF0000FF00FFFF00FF0000FFFF00FFFFFF80FF00FFFF00FF0000FFFFFF80FF00FFFFFF80FFFF80FF0000FF0000FF00FFFF00FFFF0000FF0000FFFF80FFFF80FF0000FF0000FF0000FF0000FFFF80FFFF80FF0000FF0000FF0000FF0000FF0000FF0000FF00FFFF00FF0000FFFF00FFFF00FFFF00FFFF00FFFF00FFFFFF80FF00FFFF0000FF0000FF0000FF0000FF0000FF00FFFF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FFFF80FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF00FFFF00FFFF00FFFF00FFFF00FFFF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF00000000000000000000BC6F55AA");
                  Buffer.BlockCopy(class15_1.Bang_phai_mon_huy, 0, dst, 0x13, class15_1.Bang_phai_mon_huy.Length);
                  Buffer.BlockCopy(BitConverter.GetBytes(class15_0.UserSessionID), 0, dst, 5, 2);
                  Buffer.BlockCopy(BitConverter.GetBytes(class15_1.Bang_phai_Id), 0, dst, 11, 4);
                  Buffer.BlockCopy(BitConverter.GetBytes(World.Server_Group_ID), 0, dst, 0x11, 2);
                  class15_0.Client.Send(dst, dst.Length);
            }

            public void GUI_DI_MON_HUY_2(byte[] byte_5, int int_116)
            {
                  byte[] dst = Converter.hexStringToByte("AA551903010A00EB000A036A42020001000100FF00FFFF00FF0000FF0000FFFF00FFFF00FFFF00FFFF00FFFF00FFFF00FFFFFF80FF00FFFFFF80FFFF80FFFF80FFFF80FF00FFFF00FF0000FF0000FF0000FFFF00FFFF00FFFF00FFFF00FFFF00FFFFFF80FF00FFFFFF80FFFF80FFFF80FFFF80FF00FFFF00FF0000FFFF00FF0000FFFF00FF0000FFFF00FFFF00FFFFFF80FF00FFFFFF80FFFF80FFFF80FF00FFFFFF80FF00FFFF00FF0000FFFF00FF0000FFFF00FF0000FFFF00FFFF00FFFFFF80FFFF80FFFF80FFFF80FF00FFFFFF80FFFF80FF00FFFF00FF0000FFFF00FF0000FF0000FF0000FFFF00FFFF00FFFFFF80FFFF80FFFF80FFFF80FF00FFFFFF80FFFF80FF00FFFF00FF0000FFFF00FFFF00FF0000FF0000FF0000FFFFFF80FFFF80FFFF80FFFF80FFFF80FFFF80FFFF80FF00FFFF00FFFF00FF0000FFFF00FFFF00FF0000FFFF00FF0000FFFFFF80FFFF80FF0000FFFF80FFFF80FFFF80FFFF80FF0000FF00FFFF0000FF0000FF0000FF0000FF0000FF0000FFFF80FFFF80FF0000FF0000FFFF80FFFF80FFFF80FF00FFFF00FFFF00FFFF00FFFF0000FF0000FF0000FF0000FFFF80FF0000FFFF80FF0000FF0000FFFF80FFFF80FFFF80FF0000FF0000FF0000FF0000FF0000FF0000FF0000FFFF80FF0000FF0000FFFF80FF0000FF0000FFFF80FFFF80FF0000FF0000FF0000FF00FFFF00FF0000FFFF00FFFFFF80FF00FFFF00FF0000FFFFFF80FF00FFFFFF80FFFF80FF0000FF0000FF00FFFF00FFFF0000FF0000FFFF80FFFF80FF0000FF0000FF0000FF0000FFFF80FFFF80FF0000FF0000FF0000FF0000FF0000FF0000FF00FFFF00FF0000FFFF00FFFF00FFFF00FFFF00FFFF00FFFFFF80FF00FFFF0000FF0000FF0000FF0000FF0000FF00FFFF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FFFF80FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF00FFFF00FFFF00FFFF00FFFF00FFFF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF00000000000000000000BC6F55AA");
                  Buffer.BlockCopy(byte_5, 0, dst, 0x13, byte_5.Length);
                  Buffer.BlockCopy(BitConverter.GetBytes(int_116), 0, dst, 11, 4);
                  Buffer.BlockCopy(BitConverter.GetBytes(World.Server_Group_ID), 0, dst, 0x11, 2);
                  Buffer.BlockCopy(BitConverter.GetBytes(this.UserSessionID), 0, dst, 5, 2);
                  this.Client.Send(dst, dst.Length);
            }

            public void GUI_DI_NHIEM_VU_ITEM_DANH_SACH()
            {
                  try
                  {
                        using (PacketData data = new PacketData())
                        {
                              data.Write4(0x24);
                              for (int i = 0; i < 0x24; i++)
                              {
                                    data.Write4(0);
                                    data.Write4(0);
                                    data.Write4(this.class22_0[i].VAT_PHAM_ID);
                                    data.Write4(0);
                                    data.Write4(this.class22_0[i].VAT_PHAM_SO_LUONG);
                              }
                              if (this.Client != null)
                              {
                                    this.Client.method_4(data, 0x8100, this.UserSessionID);
                              }
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, string.Concat(new object[] { "GUI_DI_NHIEM_VU_ITEM_DANH_SACH出错![", this.Userid, "]-[", this.UserName, "]", exception }));
                  }
            }

            public void GUI_DI_THE_LUC_CHIEN_DONG_CUA_TIN_TUC()
            {
                  try
                  {
                        byte[] dst = Converter.hexStringToByte("AA551C0001A205BA000D0006132700000000000000000000000000000000AC4155AA");
                        Buffer.BlockCopy(BitConverter.GetBytes(this.UserSessionID), 0, dst, 5, 2);
                        if (this.Client != null)
                        {
                              this.Client.Send(dst, dst.Length);
                        }
                  }
                  catch
                  {
                  }
            }

            public void GUI_DI_THE_LUC_CHIEN_KET_THUC_TIN_TUC(int kssjint)
            {
                  try
                  {
                        byte[] dst = Converter.hexStringToByte("AA551B0001B902BA000C00041127031200000018000000000000000000822255AA");
                        if (kssjint == 1)
                        {
                              if (this.Player_Zx == 1)
                              {
                                    Buffer.BlockCopy(BitConverter.GetBytes(2), 0, dst, 14, 1);
                              }
                              else
                              {
                                    Buffer.BlockCopy(BitConverter.GetBytes(1), 0, dst, 14, 1);
                              }
                        }
                        else if (kssjint == 2)
                        {
                              if (this.Player_Zx == 1)
                              {
                                    Buffer.BlockCopy(BitConverter.GetBytes(1), 0, dst, 14, 1);
                              }
                              else
                              {
                                    Buffer.BlockCopy(BitConverter.GetBytes(2), 0, dst, 14, 1);
                              }
                        }
                        else if (kssjint == 3)
                        {
                              Buffer.BlockCopy(BitConverter.GetBytes(3), 0, dst, 14, 1);
                        }
                        Buffer.BlockCopy(BitConverter.GetBytes(this.UserSessionID), 0, dst, 5, 2);
                        Buffer.BlockCopy(BitConverter.GetBytes(World.THE_LUC_CHIEN_2_TIEN_TRINH), 0, dst, 11, 1);
                        Buffer.BlockCopy(BitConverter.GetBytes(World.THE_LUC_CHIEN_2_CHINH_PHAI_DIEM_SO), 0, dst, 15, 4);
                        Buffer.BlockCopy(BitConverter.GetBytes(World.THE_LUC_CHIEN_2_TA_PHAI_DIEM_SO), 0, dst, 0x13, 4);
                        if (this.Client != null)
                        {
                              this.Client.Send(dst, dst.Length);
                        }
                  }
                  catch
                  {
                  }
            }

            public void GUI_DI_THE_LUC_CHIEN_MOI_THAM_GIA()
            {
                  byte[] dst = Converter.hexStringToByte("AA552F00012C0113222000010001000B00000001000000020000000500000005000000340E000000000000000000000000BD8455AA");
                  Buffer.BlockCopy(BitConverter.GetBytes(2), 0, dst, 0x17, 1);
                  if (this.Client != null)
                  {
                        this.Client.Send(dst, dst.Length);
                  }
            }

            public void GUI_DI_THE_LUC_CHIEN_MOI_THAM_GIA_2()
            {
                  byte[] dst = Converter.hexStringToByte("AA552F00010F2713222000010001000B00000001000000030000000500000005000000620F000000000000000000000000BD8455AA");
                  Buffer.BlockCopy(BitConverter.GetBytes(this.UserSessionID), 0, dst, 5, 2);
                  Buffer.BlockCopy(BitConverter.GetBytes(World.THE_LUC_CHIEN_2_CHINH_PHAI_DIEM_SO), 0, dst, 0x23, 4);
                  Buffer.BlockCopy(BitConverter.GetBytes(World.THE_LUC_CHIEN_2_TA_PHAI_DIEM_SO), 0, dst, 0x27, 4);
                  Buffer.BlockCopy(BitConverter.GetBytes(3), 0, dst, 0x17, 1);
                  if (this.Client != null)
                  {
                        this.Client.Send(dst, dst.Length);
                  }
            }

            public void GUI_DI_THE_LUC_CHIEN_NHANH_CHONG_BAT_DAU_TIN_TUC(int int_116)
            {
                  try
                  {
                        byte[] dst = Converter.hexStringToByte("AA551D00002D01BA000D00020000100E000000000000000000000000000000000055AA");
                        Buffer.BlockCopy(BitConverter.GetBytes(int_116), 0, dst, 14, 2);
                        Buffer.BlockCopy(BitConverter.GetBytes(this.UserSessionID), 0, dst, 5, 2);
                        Buffer.BlockCopy(BitConverter.GetBytes(World.THE_LUC_CHIEN_2_TIEN_TRINH), 0, dst, 11, 1);
                        Buffer.BlockCopy(BitConverter.GetBytes(World.THE_LUC_CHIEN_2_CHINH_PHAI_DIEM_SO), 0, dst, 0x10, 4);
                        Buffer.BlockCopy(BitConverter.GetBytes(World.THE_LUC_CHIEN_2_TA_PHAI_DIEM_SO), 0, dst, 20, 4);
                        if (this.Client != null)
                        {
                              this.Client.Send(dst, dst.Length);
                        }
                  }
                  catch
                  {
                  }
            }

            public void GUI_DI_THE_LUC_CHIEN_QUET_DIEM_MOI()
            {
                  byte[] dst = Converter.hexStringToByte("AA552F00010F271322200001000100060000000200000003000000EE010000E2010000FB040000CD030000000000000000E65D55AA");
                  Buffer.BlockCopy(BitConverter.GetBytes(this.UserSessionID), 0, dst, 5, 2);
                  Buffer.BlockCopy(BitConverter.GetBytes(World.THE_LUC_CHIEN_2_CHINH_PHAI_DIEM_SO), 0, dst, 0x1b, 4);
                  Buffer.BlockCopy(BitConverter.GetBytes(World.THE_LUC_CHIEN_2_TA_PHAI_DIEM_SO), 0, dst, 0x1f, 4);
                  Buffer.BlockCopy(BitConverter.GetBytes(World.THE_LUC_CHIEN_2_CHINH_PHAI_SO_NGUOI), 0, dst, 0x23, 4);
                  Buffer.BlockCopy(BitConverter.GetBytes(World.THE_LUC_CHIEN_TA_PHAI_SO_NGUOI), 0, dst, 0x27, 4);
                  if (this.Client != null)
                  {
                        this.Client.Send(dst, dst.Length);
                  }
            }

            public void GUI_DI_THE_LUC_CHIEN_TIN_TUC()
            {
                  try
                  {
                        byte[] dst = Converter.hexStringToByte("AA551C0001A205BA000D000303271806FFFF0000FFFF000000000000000059DF55AA");
                        Buffer.BlockCopy(BitConverter.GetBytes(World.THE_LUC_CHIEN_2_TIEN_TRINH), 0, dst, 11, 1);
                        Buffer.BlockCopy(BitConverter.GetBytes(World.THE_LUC_CHIEN_2_THOI_GIAN), 0, dst, 14, 2);
                        Buffer.BlockCopy(BitConverter.GetBytes(World.THE_LUC_CHIEN_2_CHINH_PHAI_DIEM_SO), 0, dst, 0x10, 4);
                        Buffer.BlockCopy(BitConverter.GetBytes(World.THE_LUC_CHIEN_2_TA_PHAI_DIEM_SO), 0, dst, 20, 4);
                        Buffer.BlockCopy(BitConverter.GetBytes(this.UserSessionID), 0, dst, 5, 2);
                        if (this.Client != null)
                        {
                              this.Client.Send(dst, dst.Length);
                        }
                  }
                  catch
                  {
                  }
            }

            public void GUI_DI_THE_LUC_CHIEN_TIN_TUC_2()
            {
                  try
                  {
                        byte[] dst = Converter.hexStringToByte("AA551C0001A205BA000D000303271806FFFF0000FFFF000000000000000059DF55AA");
                        Buffer.BlockCopy(BitConverter.GetBytes(2), 0, dst, 11, 1);
                        Buffer.BlockCopy(BitConverter.GetBytes(World.THE_LUC_CHIEN_2_THOI_GIAN), 0, dst, 14, 2);
                        Buffer.BlockCopy(BitConverter.GetBytes(World.THE_LUC_CHIEN_2_CHINH_PHAI_DIEM_SO), 0, dst, 0x10, 4);
                        Buffer.BlockCopy(BitConverter.GetBytes(World.THE_LUC_CHIEN_2_TA_PHAI_DIEM_SO), 0, dst, 20, 4);
                        Buffer.BlockCopy(BitConverter.GetBytes(this.UserSessionID), 0, dst, 5, 2);
                        if (this.Client != null)
                        {
                              this.Client.Send(dst, dst.Length);
                        }
                  }
                  catch
                  {
                  }
            }

            public void GUI_DI_TO_DOI_TIN_TUC_SO_LIEU(byte[] byte_5, int int_116, Dictionary<int, Players> dictionary_4)
            {
                  try
                  {
                        foreach (Players players in dictionary_4.Values)
                        {
                              if (World.allConnectedChars.ContainsKey(players.UserSessionID) && (players.Client != null))
                              {
                                    players.Client.Send(byte_5, int_116);
                              }
                        }
                  }
                  catch
                  {
                  }
            }

            public void GUI_DI_TRUYEN_AM_TIN_TUC(Players class15_0, string string_10, int int_116)
            {
                  try
                  {
                        byte[] dst = Converter.hexStringToByte("AA55A6000000006600970000C8CEBDDC0000000000000000000000000000000000003000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000055AA");
                        dst[11] = (byte)int_116;
                        byte[] bytes = Encoding.Default.GetBytes(this.UserName);
                        byte[] src = Encoding.Default.GetBytes(string_10);
                        Buffer.BlockCopy(src, 0, dst, 0x23, src.Length);
                        Buffer.BlockCopy(bytes, 0, dst, 12, bytes.Length);
                        Buffer.BlockCopy(BitConverter.GetBytes(this.UserSessionID), 0, dst, 5, 2);
                        if (class15_0.Client != null)
                        {
                              class15_0.Client.Send(dst, dst.Length);
                        }
                  }
                  catch
                  {
                  }
            }

            public void GUI_DI_TRUYEN_AM_TIN_TUC_SO_LIEU(byte[] byte_5, int int_116, string string_10, string string_11, int int_117)
            {
                  try
                  {
                        using (IEnumerator<Players> enumerator = World.allConnectedChars.Values.GetEnumerator())
                        {
                              Players current;
                              while (enumerator.MoveNext())
                              {
                                    current = enumerator.Current;
                                    if (current.UserName == string_10)
                                    {
                                          goto Label_0031;
                                    }
                              }
                              return;
                              Label_0031:
                              if (current.Config.传音 == 0)
                              {
                                    this.GameMessage("Doi phuong thiet lap khong cho phep truyen am !", 9, "System");
                              }
                              else
                              {
                                    if (this.Client != null)
                                    {
                                          this.Client.Send(byte_5, int_116);
                                    }
                                    this.GUI_DI_TRUYEN_AM_TIN_TUC(current, string_11, int_117);
                              }
                        }
                  }
                  catch
                  {
                  }
            }

            public void Increase_HP(int HP)
            {
                  if ((this.threadSafeDictionary_4 != null) && this.threadSafeDictionary_4.ContainsKey(3))
                  {
                        HP -= (int)(HP * 0.2);
                  }
                  if (this.Player_Job == 3)
                  {
                        HP = (int)(HP * (1.0 + base.Thuong_khach_Van_khi_lieu_thuong));
                  }
                  if ((this.Player_Job != 3) && (this.Player_FLD_JOB_LEVEL >= 6))
                  {
                        HP = (int)(HP * (1.0 + base.Thang_thien_1_khi_cong_Van_khi_lieu_thuong));
                  }
                  if ((this.NHAN_VAT_HP + HP) < this.NHAN_VAT_LON_NHAT_HP)
                  {
                        this.NHAN_VAT_HP += HP;
                  }
                  else
                  {
                        this.NHAN_VAT_HP = this.NHAN_VAT_LON_NHAT_HP;
                  }
            }

            public void InitialQigqong()
            {
                  PacketData data = new PacketData();
                  data.Write2(100);
                  data.Write2(0x3b6d);
                  data.Write4(0);
                  data.Write2(60);
                  data.Write2(0xe74);
                  data.Write2(0);
                  for (int i = 0; i < 15; i++)
                  {
                        if (i < 11)
                        {
                              data.Write2(this.Qigong[i].int_0);
                              if (this.Qigong[i].int_0 != 0)
                              {
                                    if (this.Qigong[i].气功量 != 0)
                                    {
                                          data.Write2(((this.Qigong[i].气功量 + this.FLD_trang_bi_them_vao_Khi_cong) + this.FLD_nhan_vat_them_vao_khi_cong) + this.FLD_Vo_huan_them_vao_khi_cong);
                                    }
                                    else
                                    {
                                          data.Write2(0);
                                    }
                              }
                              else
                              {
                                    data.Write2(0);
                              }
                        }
                        else
                        {
                              data.Write4(0);
                        }
                  }
                  data.Write2(0);
                  data.Write2(0xfff0);
                  data.Write2(7);
                  data.Write4(0);
                  if (this.Client != null)
                  {
                        this.Client.method_5(data, 0x6c00, this.UserSessionID, 0);
                  }
            }

            public void ITEM_SU_DUNG_NGAN_NAM_TUYEN_NHAN_SAM(int int_116, int int_117)
            {
                  try
                  {
                        if ((this.threadSafeDictionary_4 != null) && this.threadSafeDictionary_4.ContainsKey(3))
                        {
                              int_117 *= 2;
                        }
                        byte[] dst = Converter.hexStringToByte("AA552C00002C013B001C000105000065CA9A3B000000000100000009000000000000000000000000000000000000000055AA");
                        byte[] buffer2 = new byte[4];
                        Buffer.BlockCopy(this.TRANG_BI_LAN_BAO_VAY[int_116].Item_byte, 20, buffer2, 0, 4);
                        int num = (BitConverter.ToInt32(buffer2, 0) - 0x77ce2a80) - int_117;
                        Buffer.BlockCopy(BitConverter.GetBytes(int_116), 0, dst, 12, 2);
                        Buffer.BlockCopy(this.TRANG_BI_LAN_BAO_VAY[int_116].VAT_PHAM_ID, 0, dst, 15, 4);
                        if (num <= 0)
                        {
                              if (BitConverter.ToInt32(this.TRANG_BI_LAN_BAO_VAY[int_116].VAT_PHAM_SO_LUONG, 0) <= 1)
                              {
                                    Buffer.BlockCopy(BitConverter.GetBytes(0), 0, dst, 0x1b, 4);
                                    Buffer.BlockCopy(BitConverter.GetBytes(0x77ce2a80), 0, dst, 0x1f, 4);
                                    this.TRANG_BI_LAN_BAO_VAY[int_116].Item_byte = new byte[0x49];
                              }
                              else
                              {
                                    int num2 = BitConverter.ToInt32(this.TRANG_BI_LAN_BAO_VAY[int_116].VAT_PHAM_SO_LUONG, 0) - 1;
                                    this.TRANG_BI_LAN_BAO_VAY[int_116].VAT_PHAM_SO_LUONG = BitConverter.GetBytes(num2);
                                    Buffer.BlockCopy(BitConverter.GetBytes(0x77d75240), 0, this.TRANG_BI_LAN_BAO_VAY[int_116].Item_byte, 20, 4);
                                    Buffer.BlockCopy(this.TRANG_BI_LAN_BAO_VAY[int_116].VAT_PHAM_SO_LUONG, 0, dst, 0x1b, 4);
                                    Buffer.BlockCopy(BitConverter.GetBytes(0x77d75240), 0, dst, 0x1f, 4);
                              }
                        }
                        else
                        {
                              Buffer.BlockCopy(BitConverter.GetBytes((int)(num + 0x77ce2a80)), 0, this.TRANG_BI_LAN_BAO_VAY[int_116].Item_byte, 20, 4);
                              Buffer.BlockCopy(this.TRANG_BI_LAN_BAO_VAY[int_116].VAT_PHAM_SO_LUONG, 0, dst, 0x1b, 4);
                              Buffer.BlockCopy(BitConverter.GetBytes((int)(num + 0x77ce2a80)), 0, dst, 0x1f, 4);
                        }
                        Buffer.BlockCopy(BitConverter.GetBytes(this.UserSessionID), 0, dst, 5, 2);
                        if (this.Client != null)
                        {
                              this.Client.Send(dst, dst.Length);
                        }
                  }
                  catch
                  {
                  }
            }

            public void ITEM_SU_DUNG_NHAN(int int_116, int int_117, int int_118)
            {
                  PacketData data = new PacketData();
                  data.method_2(1);
                  data.Write2(int_116);
                  data.method_2(0);
                  data.Write4(BitConverter.ToInt32(this.TRANG_BI_LAN_BAO_VAY[int_116].VAT_PHAM_ID, 0));
                  data.Write4(0);
                  data.Write2(int_118);
                  data.Write2(0);
                  data.Write4(int_117);
                  if (this.Client != null)
                  {
                        this.Client.method_4(data, 0x3b00, this.UserSessionID);
                  }
            }

            public void ITEM_SU_DUNG_VO_SONG_NGAN_NAM_TUYEN_NHAN_SAM(int int_116, int int_117)
            {
                  try
                  {
                        double num;
                        if ((this.threadSafeDictionary_4 != null) && this.threadSafeDictionary_4.ContainsKey(3))
                        {
                              int_117 *= 2;
                        }
                        byte[] dst = Converter.hexStringToByte("AA552C00002C013B001C000105000065CA9A3B000000000100000009000000000000000000000000000000000000000055AA");
                        byte[] buffer2 = new byte[4];
                        Buffer.BlockCopy(this.TRANG_BI_LAN_BAO_VAY[int_116].Item_byte, 20, buffer2, 0, 4);
                        if (this.TRANG_BI_LAN_BAO_VAY[int_116].GetItem_ID == 0x3c14dc4dL)
                        {
                              num = ((((BitConverter.ToInt32(buffer2, 0) - 0x42294180) / 100) * this.NHAN_VAT_LON_NHAT_HP) - int_117) / ((double)(0x3e8L * this.NHAN_VAT_LON_NHAT_HP));
                        }
                        else
                        {
                              num = ((((BitConverter.ToInt32(buffer2, 0) - 0x42294180) / 100) * this.NHAN_VAT_LON_NHAT_MP) - int_117) / ((double)(0x3e8 * this.NHAN_VAT_LON_NHAT_MP));
                        }
                        int num2 = (int)(num * 100000.0);
                        Buffer.BlockCopy(BitConverter.GetBytes(int_116), 0, dst, 12, 2);
                        Buffer.BlockCopy(this.TRANG_BI_LAN_BAO_VAY[int_116].VAT_PHAM_ID, 0, dst, 15, 4);
                        if (num2 <= 0)
                        {
                              if (BitConverter.ToInt32(this.TRANG_BI_LAN_BAO_VAY[int_116].VAT_PHAM_SO_LUONG, 0) <= 1)
                              {
                                    Buffer.BlockCopy(BitConverter.GetBytes(0), 0, dst, 0x1b, 4);
                                    Buffer.BlockCopy(BitConverter.GetBytes(0x42294180), 0, dst, 0x1f, 4);
                                    this.TRANG_BI_LAN_BAO_VAY[int_116].Item_byte = new byte[0x49];
                              }
                              else
                              {
                                    int num3 = BitConverter.ToInt32(this.TRANG_BI_LAN_BAO_VAY[int_116].VAT_PHAM_SO_LUONG, 0) - 1;
                                    this.TRANG_BI_LAN_BAO_VAY[int_116].VAT_PHAM_SO_LUONG = BitConverter.GetBytes(num3);
                                    Buffer.BlockCopy(BitConverter.GetBytes(0x422ac820), 0, this.TRANG_BI_LAN_BAO_VAY[int_116].Item_byte, 20, 4);
                                    Buffer.BlockCopy(this.TRANG_BI_LAN_BAO_VAY[int_116].VAT_PHAM_SO_LUONG, 0, dst, 0x1b, 4);
                                    Buffer.BlockCopy(BitConverter.GetBytes(0x422ac820), 0, dst, 0x1f, 4);
                              }
                        }
                        else
                        {
                              Buffer.BlockCopy(BitConverter.GetBytes((int)(num2 + 0x42294180)), 0, this.TRANG_BI_LAN_BAO_VAY[int_116].Item_byte, 20, 4);
                              Buffer.BlockCopy(this.TRANG_BI_LAN_BAO_VAY[int_116].VAT_PHAM_SO_LUONG, 0, dst, 0x1b, 4);
                              Buffer.BlockCopy(BitConverter.GetBytes((int)(num2 + 0x42294180)), 0, dst, 0x1f, 4);
                        }
                        Buffer.BlockCopy(BitConverter.GetBytes(this.UserSessionID), 0, dst, 5, 2);
                        if (this.Client != null)
                        {
                              this.Client.Send(dst, dst.Length);
                        }
                  }
                  catch
                  {
                  }
            }

            public void KIEM_SOAT_CASH_SO_LIEU(int int_116, int int_117)
            {
                  if ((World.CASH_do_luong == 1) && (this.FLD_RXPIONT < 0L))
                  {
                        Form1.WriteLine(100, string.Concat(new object[] { "元宝数据异常[", this.Userid, "]-[", this.UserName, "] [", this.FLD_RXPIONT, "]" }));
                        DBA.smethod_7($"UPDATE TBL_ACCOUNT SET FLD_ZT=1 WHERE FLD_ID='{this.Userid}'", "rxjhaccount");
                        this.FLD_RXPIONT = 0L;
                        this.UPDATE_RXPIONT();
                        Form1.WriteLine(100, "非法修改元宝封号[" + this.Userid + "][" + this.UserName + "]");
                        this.System_Announcement("因为[" + this.UserName + "]违反了游戏规则,账号永久封停,请大家引以为鉴");
                        this.GameMessage("Because you violated the rules of the game, gold data anomalies, permanent Feng Ting account, if in doubt please contact management", 9, "System");
                        if (this.Client != null)
                        {
                              this.Client.Dispose();
                        }
                  }
                  else if ((World.CASH_do_luong == 2) && (this.FLD_RXPIONT < 0L))
                  {
                        Form1.WriteLine(100, string.Concat(new object[] { "元宝数据异常[", this.Userid, "]-[", this.UserName, "] [", this.FLD_RXPIONT, "]" }));
                        this.FLD_RXPIONT = 0L;
                        Form1.WriteLine(100, string.Concat(new object[] { "元宝数据清零[", this.Userid, "]-[", this.UserName, "] [", this.FLD_RXPIONT, "]" }));
                        this.UPDATE_RXPIONT();
                        this.System_Announcement("因为[" + this.UserName + "]违反了游戏规则,元宝数据异常,元宝全部清零,请大家引以为鉴");
                        this.GameMessage("Because you violated the rules of the game, gold data anomalies, gold are all clear, if in doubt please contact management", 9, "System");
                        if (this.Client != null)
                        {
                              this.Client.Dispose();
                        }
                  }
                  else if (int_117 == 0)
                  {
                        this.FLD_RXPIONT -= int_116;
                        if (this.FLD_RXPIONT < 0L)
                        {
                              this.FLD_RXPIONT = 0L;
                        }
                  }
                  else
                  {
                        this.FLD_RXPIONT += int_116;
                        if (this.FLD_RXPIONT > World.Nhan_vat_lon_nhat_CASH_so_luong)
                        {
                              this.FLD_RXPIONT = World.Nhan_vat_lon_nhat_CASH_so_luong;
                        }
                  }
            }

            public bool KIEM_TRA_ITEM_HE_THONG(ITEMSX ITEM_HE_THONG)
            {
                  if (ITEM_HE_THONG.Prop_Type != 0)
                  {
                        if (ITEM_HE_THONG.Prop_Type == 1)
                        {
                              if ((World.Item_cao_nhat_Cong_kich_gia_tri != 0) && (ITEM_HE_THONG.Number_Prop >= World.Item_cao_nhat_Cong_kich_gia_tri))
                              {
                                    return true;
                              }
                        }
                        else if (ITEM_HE_THONG.Prop_Type == 2)
                        {
                              if ((World.Item_cao_nhat_Phong_ngu_gia_tri != 0) && (ITEM_HE_THONG.Number_Prop >= World.Item_cao_nhat_Phong_ngu_gia_tri))
                              {
                                    return true;
                              }
                        }
                        else if (ITEM_HE_THONG.Prop_Type == 3)
                        {
                              if ((World.Item_cao_nhat_Sinh_menh_gia_tri != 0) && (ITEM_HE_THONG.Number_Prop >= World.Item_cao_nhat_Sinh_menh_gia_tri))
                              {
                                    return true;
                              }
                        }
                        else if (ITEM_HE_THONG.Prop_Type == 4)
                        {
                              if ((World.Item_cao_nhat_Noi_cong_gia_tri != 0) && (ITEM_HE_THONG.Number_Prop >= World.Item_cao_nhat_Noi_cong_gia_tri))
                              {
                                    return true;
                              }
                        }
                        else if (ITEM_HE_THONG.Prop_Type == 5)
                        {
                              if ((World.Item_cao_nhat_Trung_muc_tieu_gia_tri != 0) && (ITEM_HE_THONG.Number_Prop >= World.Item_cao_nhat_Trung_muc_tieu_gia_tri))
                              {
                                    return true;
                              }
                        }
                        else if (ITEM_HE_THONG.Prop_Type == 6)
                        {
                              if ((World.Item_cao_nhat_Ne_tranh_gia_tri != 0) && (ITEM_HE_THONG.Number_Prop >= World.Item_cao_nhat_Ne_tranh_gia_tri))
                              {
                                    return true;
                              }
                        }
                        else if (ITEM_HE_THONG.Prop_Type == 7)
                        {
                              if ((World.Item_cao_nhat_vo_cong_gia_tri != 0) && (ITEM_HE_THONG.Number_Prop >= World.Item_cao_nhat_vo_cong_gia_tri))
                              {
                                    return true;
                              }
                        }
                        else if (ITEM_HE_THONG.Prop_Type == 8)
                        {
                              if ((World.Item_cao_nhat_khi_cong_gia_tri != 0) && (ITEM_HE_THONG.Number_Prop >= World.Item_cao_nhat_khi_cong_gia_tri))
                              {
                                    return true;
                              }
                        }
                        else if (((ITEM_HE_THONG.Prop_Type == 9) && (World.Item_cao_nhat_hop_thanh_gia_tri != 0)) && (ITEM_HE_THONG.Number_Prop >= World.Item_cao_nhat_hop_thanh_gia_tri))
                        {
                              return true;
                        }
                  }
                  return false;
            }

            public void LAN_DAU_DOI_THOAI_DA_TRANG_BI_VAT_PHAM()
            {
                  try
                  {
                        PacketData data = new PacketData();
                        data.Write4(1);
                        data.Write4(this.UserSessionID);
                        data.method_16(this.UserName);
                        if (this.Bang_phai_Id != 0)
                        {
                              data.Write4(this.Bang_phai_Id);
                              data.method_16(this.GuildName);
                              data.method_2(this.Bang_phai_nhan_vat_thu_bac);
                              if (this.Bang_phai_mon_huy != null)
                              {
                                    data.method_2(World.Server_Group_ID);
                              }
                              else
                              {
                                    data.method_2(0);
                              }
                        }
                        else
                        {
                              data.method_0(new byte[0x15]);
                        }
                        data.Write2(0);
                        data.Write2(this.Player_Zx);
                        data.Write2(this.Player_FLD_LEVEL);
                        data.Write2(this.Player_FLD_JOB_LEVEL);
                        data.Write2(this.Player_Job);
                        data.Write2(this.class84_0.MAU_TOC);
                        data.Write2(this.class84_0.KIEU_TOC);
                        data.Write2(this.class84_0.GIOI_TINH);
                        data.method_1(this.CharacterCoords_X);
                        data.method_1(this.CharacterCoords_Z);
                        data.method_1(this.CharacterCoords_Y);
                        data.Write4(this.CharacterCoords_Map);
                        data.Write4(0);
                        data.Write4(0);
                        data.Write4(0);
                        data.method_10(this.NHAN_VAT_TEN_MAU, 0, 0x30);
                        data.Write4(0);
                        for (int i = 0; i < 15; i++)
                        {
                              if (BitConverter.ToInt32(this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].VAT_PHAM_SO_LUONG, 0) == 0)
                              {
                                    this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_byte = new byte[0x49];
                              }
                              else
                              {
                                    this.method_12("TRANG_BI_LAN_CHOC_THUNG_TRANG_BI", ref this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i]);
                              }
                              if (((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon <= 0x16) && (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon >= 0x15)) && (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_thuc_tinh > 0))
                              {
                                    this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_trung_cap_phu_hon_them_vao_thuc_tinh = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon - 20;
                              }
                              data.method_10(this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].method_0(), 0, World.int_5);
                        }
                        for (int j = 0; j < 15; j++)
                        {
                              if (BitConverter.ToInt32(this.class23_4[j].VAT_PHAM_SO_LUONG, 0) == 0)
                              {
                                    this.class23_4[j].Item_byte = new byte[0x49];
                              }
                              else
                              {
                                    this.method_12("辅助TRANG_BI_LAN_CHOC_THUNG_TRANG_BI", ref this.class23_4[j]);
                              }
                              data.method_10(this.class23_4[j].method_0(), 0, World.int_5);
                        }
                        if (this.Client != null)
                        {
                              this.Client.method_5(data, 0xa000, this.UserSessionID, 0);
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "LAN_DAU_DOI_THOAI_DA_TRANG_BI_VAT_PHAM出错[" + this.Userid + "]-[" + this.UserName + "]" + exception.Message);
                  }
            }

            public void LUU_KHO_CAN_NHAN_QUA_TRINH()
            {
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "PlayersBes_保存个人仓库存储过程()");
                  }
                  try
                  {
                        SqlParameter[] parameterArray = new SqlParameter[] { SqlDBA.MakeInParam("@id", SqlDbType.VarChar, 20, this.Userid), SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 20, this.UserName), SqlDBA.MakeInParam("@money", SqlDbType.VarChar, 0, this.CA_NHAN_NHA_KHO_TIEN_SO_LUONG), SqlDBA.MakeInParam("@strItem", SqlDbType.VarBinary, 0x111c, this.GET_CA_NHAN_NHA_KHO_BYTE()) };
                        DbPool_Class class2 = new DbPool_Class
                        {
                              Conn = DBA.smethod_3(null),
                              Prams = parameterArray,
                              Sql = "XWWL_UPDATE_USER_Warehouse"
                        };
                        World.queue_1.Enqueue(class2);
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "保存个人仓库数据出错[" + this.Userid + "]-[" + this.UserName + "]" + exception.Message);
                  }
            }

            public void LUU_KHO_CHUNG_QUA_TRINH()
            {
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "PlayersBes_保存综合仓库存储过程()");
                  }
                  try
                  {
                        SqlParameter[] parameterArray = new SqlParameter[] { SqlDBA.MakeInParam("@id", SqlDbType.VarChar, 20, this.Userid), SqlDBA.MakeInParam("@money", SqlDbType.VarChar, 0, this.TONG_HOP_NHA_KHO_TIEN_SO), SqlDBA.MakeInParam("@strItem", SqlDbType.VarBinary, 0x111c, this.GET_TONG_HOP_NHA_KHO_BYTE()), SqlDBA.MakeInParam("@strItime", SqlDbType.VarBinary, 50, this.GET_TONG_HOP_KHO_VAT_PHAM_BYTE()), SqlDBA.MakeInParam("@zbver", SqlDbType.Int, 0, this.int_3) };
                        DbPool_Class class2 = new DbPool_Class
                        {
                              Conn = DBA.smethod_3(null),
                              Prams = parameterArray,
                              Sql = "XWWL_UPDATE_ID_Warehouse"
                        };
                        World.queue_1.Enqueue(class2);
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "保存个人仓库数据出错[" + this.Userid + "]-[" + this.UserName + "]" + exception.Message);
                  }
            }

            public void LUU_NHAN_VAT_SO_LIEU()
            {
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "PlayersBes_CAP_NHAT_NHAN_VAT_SO_LIEU()");
                  }
                  try
                  {
                        if (this.UserName != "")
                        {
                              this.Save_Char_data_Stored();
                              this.LUU_KHO_CAN_NHAN_QUA_TRINH();
                              this.LUU_KHO_CHUNG_QUA_TRINH();
                              if (this.Bang_phai_Id != 0)
                              {
                                    StringBuilder builder = new StringBuilder();
                                    builder.AppendFormat("UPDATE TBL_XWWL_GuildMember SET FLD_LEVEL = @zw WHERE Name = @Username", new object[0]);
                                    SqlParameter[] parameterArray = new SqlParameter[] { SqlDBA.MakeInParam("@zw", SqlDbType.Int, 0, this.Player_FLD_LEVEL), SqlDBA.MakeInParam("@Username", SqlDbType.VarChar, 30, this.UserName) };
                                    if (DBA.smethod_4(builder.ToString(), parameterArray) == -1)
                                    {
                                          Form1.WriteLine(3, "保存人物帮派等级数据出错[" + this.Userid + "]-[" + this.UserName + "]");
                                    }
                              }
                              this.bool_0 = true;
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "保存的数据出错[" + this.Userid + "]-[" + this.UserName + "]" + exception.Message);
                  }
            }

            public void LUU_THANH_VIEN_SO_LIEU()
            {
                  StringBuilder builder1 = new StringBuilder();
                  builder1.AppendFormat("UPDATE TBL_ACCOUNT SET FLD_VIP={1},FLD_VIPTIM='{2}' WHERE FLD_ID='{0}'", this.Userid, 1, this.FLD_VIPTIM);
                  if (DBA.smethod_7(builder1.ToString(), "rxjhaccount") == -1)
                  {
                        Form1.WriteLine(1, "保存ID 会员 数据出错[" + this.Userid + "]-[" + this.UserName + "]");
                  }
            }

            public void LUU_THANH_VIEN_System()
            {
                  StringBuilder builder1 = new StringBuilder();
                  builder1.AppendFormat("UPDATE TBL_ACCOUNT SET FLD_QCVIP={1},FLD_QCVIPTIM='{2}' WHERE FLD_ID='{0}'", this.Userid, 1, this.FLD_QCVIPTIM);
                  if (DBA.smethod_7(builder1.ToString(), "rxjhaccount") == -1)
                  {
                        Form1.WriteLine(1, "Gift Code Error[" + this.Userid + "]-[" + this.UserName + "]");
                  }
            }

            public void MAT_DAT_ITEM_BIEN_MAT(long long_16)
            {
                  try
                  {
                        PacketData data = new PacketData();
                        data.method_8(long_16);
                        if (this.Client != null)
                        {
                              this.Client.method_4(data, 0x7300, this.UserSessionID);
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, string.Concat(new object[] { "地面VAT_PHAM消失数据 出错", this.Client.int_3, "|", this.Client.ToString(), " ", exception }));
                  }
            }

            public void MAT_DAT_ITEM_TANG_CUONG(Dictionary<long, MAT_DAT_ITEM_LOAI> dictionary_4)
            {
                  try
                  {
                        if ((dictionary_4 != null) && (dictionary_4.Count > 0))
                        {
                              using (PacketData data = new PacketData())
                              {
                                    data.Write4(dictionary_4.Count);
                                    foreach (MAT_DAT_ITEM_LOAI mat_dat_item_loai in dictionary_4.Values)
                                    {
                                          data.method_10(mat_dat_item_loai.VATPHAM_byte, 0, 12);
                                          data.Write4(0);
                                          data.method_10(mat_dat_item_loai.VATPHAM_byte, 12, 4);
                                          data.method_1(mat_dat_item_loai.Rxjh_X);
                                          data.method_1(15f);
                                          data.method_1(mat_dat_item_loai.Rxjh_Y);
                                          data.method_10(mat_dat_item_loai.VATPHAM_byte, 0x10, 0x38);
                                    }
                                    if (this.Client != null)
                                    {
                                          this.Client.method_4(data, 0x7200, this.UserSessionID);
                                    }
                              }
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, string.Concat(new object[] { "地面VAT_PHAM增加数据 出错", this.Client.int_3, "|", this.Client.ToString(), " ", exception }));
                  }
            }

            public void MAT_DAT_ITEM_TANG_CUONG(byte[] item, float float_4, float float_5, float float_6)
            {
                  try
                  {
                        PacketData data = new PacketData();
                        data.Write4(1);
                        data.method_10(item, 0, 0x10);
                        data.method_1(float_4);
                        data.method_1(15f);
                        data.method_1(float_5);
                        data.method_10(item, 0x10, 0x38);
                        if (this.Client != null)
                        {
                              this.Client.method_4(data, 0x7200, 0x270f);
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, string.Concat(new object[] { "地面VAT_PHAM增加数据113 出错", this.Client.int_3, "|", this.Client.ToString(), " ", exception }));
                  }
            }

            public VAT_PHAM_LOAI method_108(int int_116, int int_117)
            {
                  foreach (VAT_PHAM_LOAI vat_pham_loai in this.TRANG_BI_LAN_BAO_VAY)
                  {
                        if (((int_117 != 0) && (vat_pham_loai.GetItem_ID == int_116)) && (vat_pham_loai.FLD_MAGIC0 == int_117))
                        {
                              return vat_pham_loai;
                        }
                  }
                  return null;
            }

            public void method_119(int int_116)
            {
                  byte[] dst = Converter.hexStringToByte("AA551700002C01CF000700010F210500000100000000000000000055AA");
                  Buffer.BlockCopy(BitConverter.GetBytes(int_116), 0, dst, 12, 1);
                  Buffer.BlockCopy(BitConverter.GetBytes(this.UserSessionID), 0, dst, 5, 2);
                  if (this.Client != null)
                  {
                        this.Client.Send(dst, dst.Length);
                  }
            }

            public void method_12(string string_10, ref VAT_PHAM_LOAI class23_6)
            {
                  if (World.Kiem_tra_phi_phap_Item == 1)
                  {
                        if (World.Kiem_tra_Troi_chat_phi_phap_Item || !class23_6.Item_troi_chat)
                        {
                              if ((class23_6.Thuoc_tinh_1.Prop_Type == 0) || !this.KIEM_TRA_ITEM_HE_THONG(class23_6.Thuoc_tinh_1))
                              {
                                    if ((class23_6.Thuoc_tinh_2.Prop_Type == 0) || !this.KIEM_TRA_ITEM_HE_THONG(class23_6.Thuoc_tinh_2))
                                    {
                                          if ((class23_6.Thuoc_tinh_3.Prop_Type == 0) || !this.KIEM_TRA_ITEM_HE_THONG(class23_6.Thuoc_tinh_3))
                                          {
                                                if ((class23_6.Thuoc_tinh_4.Prop_Type != 0) && this.KIEM_TRA_ITEM_HE_THONG(class23_6.Thuoc_tinh_4))
                                                {
                                                      Form1.WriteLine(0x4d, string.Concat(new object[] {
                                        "非法VAT_PHAM ", string_10, " [", this.Userid, "]-[", this.UserName, "] VI_TRI[", class23_6.VAT_PHAM_VI_TRI, "] 编号[", BitConverter.ToInt32(class23_6.Item_toan_bo_ID, 0), "] VAT_PHAM名称[", class23_6.method_13(), "] VAT_PHAM_SO_LUONG[", BitConverter.ToInt32(class23_6.VAT_PHAM_SO_LUONG, 0), "] 属性:[", class23_6.FLD_MAGIC0,
                                        ",", class23_6.FLD_MAGIC1, ",", class23_6.FLD_MAGIC2, ",", class23_6.FLD_MAGIC3, ",", class23_6.FLD_MAGIC4, "]"
                                    }));
                                                      if (World.Kiem_tra_phi_phap_Item_thao_tac == 1)
                                                      {
                                                            class23_6.Item_byte = new byte[0x49];
                                                      }
                                                      else if (World.Kiem_tra_phi_phap_Item_thao_tac == 2)
                                                      {
                                                            DBA.smethod_7($"UPDATE TBL_ACCOUNT SET FLD_ZT=1 WHERE FLD_ID='{this.Userid}'", "rxjhaccount");
                                                            if (this.Client != null)
                                                            {
                                                                  this.Client.Dispose();
                                                            }
                                                      }
                                                }
                                          }
                                          else
                                          {
                                                Form1.WriteLine(0x4d, string.Concat(new object[] {
                                    "非法VAT_PHAM ", string_10, " [", this.Userid, "]-[", this.UserName, "] VI_TRI[", class23_6.VAT_PHAM_VI_TRI, "] 编号[", BitConverter.ToInt32(class23_6.Item_toan_bo_ID, 0), "] VAT_PHAM名称[", class23_6.method_13(), "] VAT_PHAM_SO_LUONG[", BitConverter.ToInt32(class23_6.VAT_PHAM_SO_LUONG, 0), "] 属性:[", class23_6.FLD_MAGIC0,
                                    ",", class23_6.FLD_MAGIC1, ",", class23_6.FLD_MAGIC2, ",", class23_6.FLD_MAGIC3, ",", class23_6.FLD_MAGIC4, "]"
                                }));
                                                if (World.Kiem_tra_phi_phap_Item_thao_tac == 1)
                                                {
                                                      class23_6.Item_byte = new byte[0x49];
                                                }
                                                else if (World.Kiem_tra_phi_phap_Item_thao_tac == 2)
                                                {
                                                      DBA.smethod_7($"UPDATE TBL_ACCOUNT SET FLD_ZT=1 WHERE FLD_ID='{this.Userid}'", "rxjhaccount");
                                                      if (this.Client != null)
                                                      {
                                                            this.Client.Dispose();
                                                      }
                                                }
                                          }
                                    }
                                    else
                                    {
                                          Form1.WriteLine(0x4d, string.Concat(new object[] {
                                "非法VAT_PHAM ", string_10, " [", this.Userid, "]-[", this.UserName, "] VI_TRI[", class23_6.VAT_PHAM_VI_TRI, "] 编号[", BitConverter.ToInt32(class23_6.Item_toan_bo_ID, 0), "] VAT_PHAM名称[", class23_6.method_13(), "] VAT_PHAM_SO_LUONG[", BitConverter.ToInt32(class23_6.VAT_PHAM_SO_LUONG, 0), "] 属性:[", class23_6.FLD_MAGIC0,
                                ",", class23_6.FLD_MAGIC1, ",", class23_6.FLD_MAGIC2, ",", class23_6.FLD_MAGIC3, ",", class23_6.FLD_MAGIC4, "]"
                            }));
                                          if (World.Kiem_tra_phi_phap_Item_thao_tac == 1)
                                          {
                                                class23_6.Item_byte = new byte[0x49];
                                          }
                                          else if (World.Kiem_tra_phi_phap_Item_thao_tac == 2)
                                          {
                                                DBA.smethod_7($"UPDATE TBL_ACCOUNT SET FLD_ZT=1 WHERE FLD_ID='{this.Userid}'", "rxjhaccount");
                                                if (this.Client != null)
                                                {
                                                      this.Client.Dispose();
                                                }
                                          }
                                    }
                              }
                              else
                              {
                                    Form1.WriteLine(0x4d, string.Concat(new object[] {
                            "非法VAT_PHAM ", string_10, " [", this.Userid, "]-[", this.UserName, "] VI_TRI[", class23_6.VAT_PHAM_VI_TRI, "] 编号[", BitConverter.ToInt32(class23_6.Item_toan_bo_ID, 0), "] VAT_PHAM名称[", class23_6.method_13(), "] VAT_PHAM_SO_LUONG[", BitConverter.ToInt32(class23_6.VAT_PHAM_SO_LUONG, 0), "] 属性:[", class23_6.FLD_MAGIC0,
                            ",", class23_6.FLD_MAGIC1, ",", class23_6.FLD_MAGIC2, ",", class23_6.FLD_MAGIC3, ",", class23_6.FLD_MAGIC4, "]"
                        }));
                                    if (World.Kiem_tra_phi_phap_Item_thao_tac == 1)
                                    {
                                          class23_6.Item_byte = new byte[0x49];
                                    }
                                    else if (World.Kiem_tra_phi_phap_Item_thao_tac == 2)
                                    {
                                          DBA.smethod_7($"UPDATE TBL_ACCOUNT SET FLD_ZT=1 WHERE FLD_ID='{this.Userid}'", "rxjhaccount");
                                          if (this.Client != null)
                                          {
                                                this.Client.Dispose();
                                          }
                                    }
                              }
                        }
                  }
                  else if (World.Kiem_tra_phi_phap_Item == 2)
                  {
                        TRANG_BI_DO_LUONG trang_bi_do_luong;
                        class23_6.method_15();
                        if (World.dictionary_1.TryGetValue(class23_6.FLD_RESIDE2, out trang_bi_do_luong) && this.method_13(class23_6, trang_bi_do_luong))
                        {
                              string str = $"SELECT count(*) FROM Itme_Log WHERE ItmeId={BitConverter.ToInt32(class23_6.Item_toan_bo_ID, 0)}";
                              int num = 0;
                              try
                              {
                                    num = (int)DBA.smethod_18(str, "WebDb");
                              }
                              catch (Exception)
                              {
                                    num = -1;
                              }
                              if (num == 0)
                              {
                                    Form1.WriteLine(0x4d, string.Concat(new object[] {
                            "非法VAT_PHAM ", string_10, " [", this.Userid, "]-[", this.UserName, "] VI_TRI[", class23_6.VAT_PHAM_VI_TRI, "] 编号[", BitConverter.ToInt32(class23_6.Item_toan_bo_ID, 0), "] VAT_PHAM名称[", class23_6.method_13(), "] VAT_PHAM_SO_LUONG[", BitConverter.ToInt32(class23_6.VAT_PHAM_SO_LUONG, 0), "] 属性:[", class23_6.FLD_MAGIC0,
                            ",", class23_6.FLD_MAGIC1, ",", class23_6.FLD_MAGIC2, ",", class23_6.FLD_MAGIC3, ",", class23_6.FLD_MAGIC4, "] 绑定[", class23_6.Item_troi_chat.ToString(), "] 魂[", class23_6.FLD_FJ_thuc_tinh.ToString(), "] 进化[", class23_6.FLD_FJ_tien_hoa.ToString(), "]"
                        }));
                                    if (World.Kiem_tra_phi_phap_Item_thao_tac == 1)
                                    {
                                          class23_6.Item_byte = new byte[0x49];
                                    }
                                    else if (World.Kiem_tra_phi_phap_Item_thao_tac == 2)
                                    {
                                          DBA.smethod_7($"UPDATE TBL_ACCOUNT SET FLD_ZT=1 WHERE FLD_ID='{this.Userid}'", "rxjhaccount");
                                          if (this.Client != null)
                                          {
                                                this.Client.Dispose();
                                          }
                                    }
                              }
                        }
                  }
            }

            public bool method_13(VAT_PHAM_LOAI class23_6, TRANG_BI_DO_LUONG class45_0) =>
                (((class45_0.ITEM_CAO_NHAT_CONG_KICH_GIA_TRI != 0) && (class23_6.Item_thuoc_tinh_Luc_cong_kich_tang_cuong >= class45_0.ITEM_CAO_NHAT_CONG_KICH_GIA_TRI)) || (((class45_0.ITEM_CAO_NHAT_PHONG_NGU_GIA_TRI != 0) && ((class23_6.Item_thuoc_tinh_Suc_phong_ngu_tang_cuong + class23_6.Item_suc_phong_ngu) >= class45_0.ITEM_CAO_NHAT_PHONG_NGU_GIA_TRI)) || (((class45_0.ITEM_CAO_NHAT_SINH_MENH_GIA_TRI != 0) && (class23_6.Item_thuoc_tinh_sinh_menh_tang_cuong >= class45_0.ITEM_CAO_NHAT_SINH_MENH_GIA_TRI)) || (((class45_0.ITEM_CAO_NHAT_NOI_CONG_GIA_TRI != 0) && (class23_6.Item_thuoc_tinh_Noi_cong_suc_manh_tang_cuong >= class45_0.ITEM_CAO_NHAT_NOI_CONG_GIA_TRI)) || (((class45_0.ITEM_CAO_NHAT_TRUNG_MUC_TIEU_GIA_TRI != 0) && (class23_6.Item_thuoc_tinh_Ti_le_trung_muc_tieu_tang_cuong >= class45_0.ITEM_CAO_NHAT_TRUNG_MUC_TIEU_GIA_TRI)) || (((class45_0.ITEM_CAO_NHAT_NE_TRANH_GIA_TRI != 0) && (class23_6.Item_thuoc_tinh_ne_tranh_xac_xuat_tang_cuong >= class45_0.ITEM_CAO_NHAT_NE_TRANH_GIA_TRI)) || (((class45_0.ITEM_CAO_NHAT_VO_CONG_GIA_TRI != 0) && (class23_6.Item_thuoc_tinh_Luc_cong_kich_vo_cong >= class45_0.ITEM_CAO_NHAT_VO_CONG_GIA_TRI)) || ((class45_0.ITEM_CAO_NHAT_KHI_CONG_GIA_TRI != 0) && (class23_6.Item_thuoc_tinh_toan_bo_khi_cong_thu_bac_tang_cuong >= class45_0.ITEM_CAO_NHAT_KHI_CONG_GIA_TRI)))))))));

            public void method_132(int int_116)
            {
                  byte[] dst = Converter.hexStringToByte("AA552F00010F2713222000080001000100000001000000360E0000000000000000000000000000000000000000000000007D5C55AA");
                  Buffer.BlockCopy(BitConverter.GetBytes(this.UserSessionID), 0, dst, 5, 2);
                  Buffer.BlockCopy(BitConverter.GetBytes(int_116), 0, dst, 0x17, 1);
                  if (this.Client != null)
                  {
                        this.Client.Send(dst, dst.Length);
                  }
            }

            public void method_133(int int_116)
            {
                  try
                  {
                        byte[] dst = Converter.hexStringToByte("AA552F00010F2713222000090001000B000000010000000C0000002101000000000000000000000000000000000000000002EE55AA");
                        Buffer.BlockCopy(BitConverter.GetBytes(int_116), 0, dst, 0x1b, 2);
                        Buffer.BlockCopy(BitConverter.GetBytes(this.UserSessionID), 0, dst, 5, 2);
                        if (this.Client != null)
                        {
                              this.Client.Send(dst, dst.Length);
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "发送势力战开始倒计时出错" + exception.Message);
                  }
            }

            public void method_134(int int_116, int int_117)
            {
                  byte[] dst = Converter.hexStringToByte("AA552700012C013D001800DE9006000000000000000000000000000000000000000000000000000000000055AA");
                  Buffer.BlockCopy(BitConverter.GetBytes(int_116), 0, dst, 11, 4);
                  Buffer.BlockCopy(BitConverter.GetBytes(int_117), 0, dst, 15, 1);
                  Buffer.BlockCopy(BitConverter.GetBytes(this.UserSessionID), 0, dst, 5, 2);
                  if (this.Client != null)
                  {
                        this.Client.Send(dst, dst.Length);
                  }
            }

            public void methods_2()
            {
                  this.dictionary_2 = new Dictionary<int, NHIEM_VU_CLASS>();
            }

            public bool method_22(long long_16, int int_116)
            {
                  if (int_116 == 1)
                  {
                        if ((((long_16 != 0x5fa80b5L) && (long_16 != 0xbf061b5L)) && ((long_16 != 0x11e642b5L) && (long_16 != 0x17dc23b5L))) && (((long_16 != 0x1dd204b5L) && (long_16 != 0x29bdc6b5L)) && ((long_16 != 0x2fb3a7b5L) && (long_16 != 0x5fa80ddL))))
                        {
                              return (long_16 == 0xbf061ddL);
                        }
                        return true;
                  }
                  if (int_116 == 2)
                  {
                        if ((((long_16 != 0x5fd8df5L) && (long_16 != 0xbf36ef5L)) && ((long_16 != 0x11e94ff5L) && (long_16 != 0x17df30f5L))) && (((long_16 != 0x1dd511f5L) && (long_16 != 0x29c0d3f5L)) && ((long_16 != 0x2fb6b4f5L) && (long_16 != 0x5fd8e1dL))))
                        {
                              return (long_16 == 0xbf36f1dL);
                        }
                        return true;
                  }
                  if (int_116 == 4)
                  {
                        if ((((long_16 != 0x5f8ef6cL) && (long_16 != 0xbeed06cL)) && ((long_16 != 0x11e4b16cL) && (long_16 != 0x17da926cL))) && (((long_16 != 0x1dd0736cL) && (long_16 != 0x29bc356cL)) && ((long_16 != 0x2fb2166cL) && (long_16 != 0x5f8ef94L))))
                        {
                              return (long_16 == 0xbeed094L);
                        }
                        return true;
                  }
                  if (int_116 == 5)
                  {
                        if ((((long_16 != 0x60221d5L) && (long_16 != 0xbf802d5L)) && ((long_16 != 0x11ede3d5L) && (long_16 != 0x17e3c4d5L))) && (((long_16 != 0x1dd9a5d5L) && (long_16 != 0x29c567d5L)) && ((long_16 != 0x2fbb48d5L) && (long_16 != 0x60221fdL))))
                        {
                              return (long_16 == 0xbf802fdL);
                        }
                        return true;
                  }
                  if (int_116 != 6)
                  {
                        return false;
                  }
                  if ((((long_16 != 0x5fc0756L) && (long_16 != 0xbf1e856L)) && ((long_16 != 0x11e7c956L) && (long_16 != 0x17ddaa56L))) && (((long_16 != 0x1dd38b56L) && (long_16 != 0x29bf4d56L)) && ((long_16 != 0x2fb52e56L) && (long_16 != 0x5fc077eL))))
                  {
                        return (long_16 == 0xbf1e87eL);
                  }
                  return true;
            }

            public bool method_23(long long_16, int int_116)
            {
                  if (int_116 == 1)
                  {
                        if ((((long_16 != 0x5fa80b6L) && (long_16 != 0xbf061b6L)) && ((long_16 != 0x11e642b6L) && (long_16 != 0x17dc23b6L))) && (((long_16 != 0x1dd204b6L) && (long_16 != 0x29bdc6b6L)) && ((long_16 != 0x2fb3a7b6L) && (long_16 != 0x5fa80deL))))
                        {
                              return (long_16 == 0xbf061deL);
                        }
                        return true;
                  }
                  if (int_116 == 2)
                  {
                        if ((((long_16 != 0x5fd8df6L) && (long_16 != 0xbf36ef6L)) && ((long_16 != 0x11e94ff6L) && (long_16 != 0x17df30f6L))) && (((long_16 != 0x1dd511f6L) && (long_16 != 0x29c0d3f6L)) && ((long_16 != 0x2fb6b4f6L) && (long_16 != 0x5fd8e1eL))))
                        {
                              return (long_16 == 0xbf36f1eL);
                        }
                        return true;
                  }
                  if (int_116 == 4)
                  {
                        if ((((long_16 != 0x5f8ef76L) && (long_16 != 0xbeed076L)) && ((long_16 != 0x127d47f6L) && (long_16 != 0x17da9276L))) && (((long_16 != 0x1dd07376L) && (long_16 != 0x29bc3576L)) && ((long_16 != 0x2fb21676L) && (long_16 != 0x5f8ef9eL))))
                        {
                              return (long_16 == 0xbeed09eL);
                        }
                        return true;
                  }
                  if (int_116 == 5)
                  {
                        if ((((long_16 != 0x60221d6L) && (long_16 != 0xbf802d6L)) && ((long_16 != 0x11ede3d6L) && (long_16 != 0x17e3c4d6L))) && (((long_16 != 0x1dd9a5d6L) && (long_16 != 0x29c567d6L)) && ((long_16 != 0x2fbb48d6L) && (long_16 != 0x60221feL))))
                        {
                              return (long_16 == 0xbf802feL);
                        }
                        return true;
                  }
                  if (int_116 != 6)
                  {
                        return false;
                  }
                  if ((((long_16 != 0x5fc0757L) && (long_16 != 0xbf1e857L)) && ((long_16 != 0x11e7c957L) && (long_16 != 0x17ddaa57L))) && (((long_16 != 0x1dd38b57L) && (long_16 != 0x29bf4d57L)) && ((long_16 != 0x2fb52e57L) && (long_16 != 0x5fc077fL))))
                  {
                        return (long_16 == 0xbf1e87fL);
                  }
                  return true;
            }

            public bool method_24(long long_16, int int_116)
            {
                  if (int_116 == 1)
                  {
                        if ((((long_16 != 0x5fa80b7L) && (long_16 != 0xbf061b7L)) && ((long_16 != 0x11e642b7L) && (long_16 != 0x17dc23b7L))) && (((long_16 != 0x1dd204b7L) && (long_16 != 0x29bdc6b7L)) && ((long_16 != 0x2fb3a7b7L) && (long_16 != 0x5fa80dfL))))
                        {
                              return (long_16 == 0xbf061dfL);
                        }
                        return true;
                  }
                  if (int_116 == 2)
                  {
                        if ((((long_16 != 0x5fd8df7L) && (long_16 != 0xbf36ef7L)) && ((long_16 != 0x11e94ff7L) && (long_16 != 0x17df30f7L))) && (((long_16 != 0x1dd511f7L) && (long_16 != 0x29c0d3f7L)) && ((long_16 != 0x2fb6b4f7L) && (long_16 != 0x5fd8e1fL))))
                        {
                              return (long_16 == 0xbf36f1fL);
                        }
                        return true;
                  }
                  if (int_116 == 4)
                  {
                        if ((((long_16 != 0x5f8ef80L) && (long_16 != 0xbeed080L)) && ((long_16 != 0x127d4800L) && (long_16 != 0x17da9280L))) && (((long_16 != 0x1dd07380L) && (long_16 != 0x29bc3580L)) && ((long_16 != 0x2fb21680L) && (long_16 != 0x5f8efa8L))))
                        {
                              return (long_16 == 0xbeed0a8L);
                        }
                        return true;
                  }
                  if (int_116 == 5)
                  {
                        if ((((long_16 != 0x60221d7L) && (long_16 != 0xbf802d7L)) && ((long_16 != 0x11ede3d7L) && (long_16 != 0x17e3c4d7L))) && (((long_16 != 0x1dd9a5d7L) && (long_16 != 0x29c567d7L)) && ((long_16 != 0x2fbb48d7L) && (long_16 != 0x60221ffL))))
                        {
                              return (long_16 == 0xbf802ffL);
                        }
                        return true;
                  }
                  if (int_116 != 6)
                  {
                        return false;
                  }
                  if ((((long_16 != 0x5fc0758L) && (long_16 != 0xbf1e858L)) && ((long_16 != 0x11e7c958L) && (long_16 != 0x17ddaa58L))) && (((long_16 != 0x1dd38b58L) && (long_16 != 0x29bf4d58L)) && ((long_16 != 0x2fb52e58L) && (long_16 != 0x5fc0780L))))
                  {
                        return (long_16 == 0xbf1e880L);
                  }
                  return true;
            }

            public bool method_25(long long_16, int int_116)
            {
                  if (int_116 == 1)
                  {
                        if ((((long_16 != 0x5fa80b8L) && (long_16 != 0xbf061b8L)) && ((long_16 != 0x11e642b8L) && (long_16 != 0x17dc23b8L))) && (((long_16 != 0x1dd204b8L) && (long_16 != 0x29bdc6b8L)) && ((long_16 != 0x2fb3a7b8L) && (long_16 != 0x5fa80e0L))))
                        {
                              return (long_16 == 0xbf061e0L);
                        }
                        return true;
                  }
                  if (int_116 == 2)
                  {
                        if ((((long_16 != 0x5fd8df8L) && (long_16 != 0xbf36ef8L)) && ((long_16 != 0x11e94ff8L) && (long_16 != 0x17df30f8L))) && (((long_16 != 0x1dd511f8L) && (long_16 != 0x29c0d3f8L)) && ((long_16 != 0x2fb6b4f8L) && (long_16 != 0x5fd8e20L))))
                        {
                              return (long_16 == 0xbf36f20L);
                        }
                        return true;
                  }
                  if (int_116 == 4)
                  {
                        if ((((long_16 != 0x5f8ef81L) && (long_16 != 0xbeed081L)) && ((long_16 != 0x11e4b181L) && (long_16 != 0x17da9281L))) && (((long_16 != 0x1dd07381L) && (long_16 != 0x29bc3581L)) && ((long_16 != 0x2fb21681L) && (long_16 != 0x5f8efa9L))))
                        {
                              return (long_16 == 0xbeed0a9L);
                        }
                        return true;
                  }
                  if (int_116 == 5)
                  {
                        if ((((long_16 != 0x60221d8L) && (long_16 != 0xbf802d8L)) && ((long_16 != 0x11ede3d8L) && (long_16 != 0x17e3c4d8L))) && (((long_16 != 0x1dd9a5d8L) && (long_16 != 0x29c567d8L)) && ((long_16 != 0x2fbb48d8L) && (long_16 != 0x6022200L))))
                        {
                              return (long_16 == 0xbf80300L);
                        }
                        return true;
                  }
                  if (int_116 != 6)
                  {
                        return false;
                  }
                  if ((((long_16 != 0x5fc0759L) && (long_16 != 0xbf1e859L)) && ((long_16 != 0x11e7c959L) && (long_16 != 0x17ddaa59L))) && (((long_16 != 0x1dd38b59L) && (long_16 != 0x29bf4d59L)) && ((long_16 != 0x2fb52e59L) && (long_16 != 0x5fc0781L))))
                  {
                        return (long_16 == 0xbf1e881L);
                  }
                  return true;
            }

            public void method_26()
            {
            }

            public void method_41(int int_116, string string_10)
            {
                  byte[] dst = Converter.hexStringToByte("AA555700019D024A1048000FD00000000000000000000000000000001110500000000204E0000010000000000000000000000003230313330363031313100000000000000000000000000000000000000000000000000000000E6DB55AA");
                  Buffer.BlockCopy(BitConverter.GetBytes(int_116), 0, dst, 0x1b, 1);
                  Buffer.BlockCopy(BitConverter.GetBytes(this.Player_FLD_LEVEL), 0, dst, 0x1c, 1);
                  Buffer.BlockCopy(BitConverter.GetBytes(1), 0, dst, 0x1d, 1);
                  Buffer.BlockCopy(BitConverter.GetBytes(0xde), 0, dst, 0x20, 4);
                  byte[] bytes = Encoding.Default.GetBytes(string_10);
                  Buffer.BlockCopy(bytes, 0, dst, 12, bytes.Length);
                  for (int i = 0; i < 3; i++)
                  {
                        Buffer.BlockCopy(BitConverter.GetBytes(int.Parse(this.SU_DO_VO_CONG_DONG_NHAT[i])), 0, dst, 0x27 + (i * 4), 4);
                  }
                  Buffer.BlockCopy(BitConverter.GetBytes(this.UserSessionID), 0, dst, 5, 2);
                  if (this.Client != null)
                  {
                        this.Client.method_8(dst, dst.Length);
                  }
            }

            public void method_42(int int_116, string string_10, int int_117, int int_118)
            {
                  byte[] dst = Converter.hexStringToByte("AA554E00009D054B104800000F000000000000000000000000000000028701000000000000000079850C007A850C007B850C00323031333131303132320020202020202020202020202020202000202020202055AA");
                  Buffer.BlockCopy(BitConverter.GetBytes(int_117), 0, dst, 11, 1);
                  Buffer.BlockCopy(BitConverter.GetBytes(int_116), 0, dst, 0x1c, 1);
                  Buffer.BlockCopy(BitConverter.GetBytes(int_118), 0, dst, 0x1d, 1);
                  Buffer.BlockCopy(BitConverter.GetBytes(1), 0, dst, 30, 1);
                  byte[] bytes = Encoding.Default.GetBytes(string_10);
                  Buffer.BlockCopy(bytes, 0, dst, 13, bytes.Length);
                  for (int i = 0; i < 3; i++)
                  {
                        Buffer.BlockCopy(BitConverter.GetBytes(int.Parse(this.SU_DO_VO_CONG_DONG_NHAT[i])), 0, dst, 0x27 + (i * 4), 4);
                  }
                  Buffer.BlockCopy(BitConverter.GetBytes(this.UserSessionID), 0, dst, 5, 2);
                  if (this.Client != null)
                  {
                        this.Client.method_8(dst, dst.Length);
                  }
            }

            public void method_47(long long_16, int int_116)
            {
                  if ((World.CASH_do_luong == 1) && (this.FLD_RXPIONT < 0L))
                  {
                        Form1.WriteLine(100, string.Concat(new object[] { "元宝数据异常[", this.Userid, "]-[", this.UserName, "] [", this.FLD_RXPIONT, "]" }));
                        DBA.smethod_7($"UPDATE TBL_ACCOUNT SET FLD_ZT=1 WHERE FLD_ID='{this.Userid}'", "rxjhaccount");
                        this.FLD_RXPIONT = 0L;
                        this.UPDATE_RXPIONT();
                        Form1.WriteLine(100, "非法修改元宝封号[" + this.Userid + "][" + this.UserName + "]");
                        this.System_Announcement("因为[" + this.UserName + "]违反了游戏规则,账号永久封停,请大家引以为鉴");
                        this.GameMessage("Because you violated the rules of the game, gold data anomalies, permanent Feng Ting account, if in doubt please contact management", 9, "System");
                        if (this.Client != null)
                        {
                              this.Client.Dispose();
                        }
                  }
                  else if ((World.CASH_do_luong == 2) && (this.FLD_RXPIONT < 0L))
                  {
                        Form1.WriteLine(100, string.Concat(new object[] { "元宝数据异常[", this.Userid, "]-[", this.UserName, "] [", this.FLD_RXPIONT, "]" }));
                        this.FLD_RXPIONT = 0L;
                        Form1.WriteLine(100, string.Concat(new object[] { "元宝数据清零[", this.Userid, "]-[", this.UserName, "] [", this.FLD_RXPIONT, "]" }));
                        this.UPDATE_RXPIONT();
                        this.System_Announcement("因为[" + this.UserName + "]违反了游戏规则,元宝数据异常,元宝全部清零,请大家引以为鉴");
                        this.GameMessage("Because you violated the rules of the game, gold data anomalies, gold are all clear, if in doubt please contact management", 9, "System");
                        if (this.Client != null)
                        {
                              this.Client.Dispose();
                        }
                  }
                  else if (int_116 == 0)
                  {
                        this.FLD_RXPIONT -= long_16;
                        if (this.FLD_RXPIONT < 0L)
                        {
                              this.FLD_RXPIONT = 0L;
                        }
                  }
                  else
                  {
                        this.FLD_RXPIONT += long_16;
                        if (this.FLD_RXPIONT > World.Nhan_vat_lon_nhat_CASH_so_luong)
                        {
                              this.FLD_RXPIONT = World.Nhan_vat_lon_nhat_CASH_so_luong;
                        }
                  }
            }

            public void method_48(long long_16, int int_116)
            {
                  if ((World.CASH_do_luong == 1) && (this.FLD_RXPIONTX < 0L))
                  {
                        Form1.WriteLine(100, string.Concat(new object[] { "积分数据异常[", this.Userid, "]-[", this.UserName, "] [", this.FLD_RXPIONTX, "]" }));
                        DBA.smethod_7($"UPDATE TBL_ACCOUNT SET FLD_ZT=1 WHERE FLD_ID='{this.Userid}'", "rxjhaccount");
                        this.FLD_RXPIONTX = 0L;
                        this.UPDATE_RXPIONT();
                        Form1.WriteLine(100, "非法修改积分封号[" + this.Userid + "][" + this.UserName + "]");
                        this.System_Announcement("因为[" + this.UserName + "]违反了游戏规则,账号永久封停,请大家引以为鉴");
                        this.GameMessage("Because you violated the rules of the game, scoring data anomalies, permanent Feng Ting account, if in doubt please contact management", 9, "System");
                        if (this.Client != null)
                        {
                              this.Client.Dispose();
                        }
                  }
                  else if ((World.CASH_do_luong == 2) && (this.FLD_RXPIONTX < 0L))
                  {
                        Form1.WriteLine(100, string.Concat(new object[] { "积分数据异常[", this.Userid, "]-[", this.UserName, "] [", this.FLD_RXPIONTX, "]" }));
                        this.FLD_RXPIONTX = 0L;
                        Form1.WriteLine(100, string.Concat(new object[] { "积分数据清零[", this.Userid, "]-[", this.UserName, "] [", this.FLD_RXPIONTX, "]" }));
                        this.UPDATE_RXPIONT();
                        this.System_Announcement("因为[" + this.UserName + "]违反了游戏规则,积分数据异常,元宝全部清零,请大家引以为鉴");
                        this.GameMessage("Boi vi ngai trai voi quy tac tro choi diem so lieu di thuong diem toan bo thanh linh nhu co nghi van xin lien lac quan ly", 9, "System");
                        if (this.Client != null)
                        {
                              this.Client.Dispose();
                        }
                  }
                  else if (int_116 == 0)
                  {
                        this.FLD_RXPIONTX -= long_16;
                        if (this.FLD_RXPIONTX < 0L)
                        {
                              this.FLD_RXPIONTX = 0L;
                        }
                  }
                  else
                  {
                        this.FLD_RXPIONTX += long_16;
                        if (this.FLD_RXPIONTX > World.Nhan_vat_lon_nhat_CASH_so_luong)
                        {
                              this.FLD_RXPIONTX = World.Nhan_vat_lon_nhat_CASH_so_luong;
                        }
                  }
            }

            public void method_82(int int_116, int int_117, int int_118)
            {
                  BitConverter.GetBytes(int_116);
                  byte[] bytes = BitConverter.GetBytes(int_117);
                  byte[] buffer2 = this.TRANG_BI_LAN_BAO_VAY[int_116].VAT_PHAM_ID;
                  if (BitConverter.ToInt32(this.TRANG_BI_LAN_BAO_VAY[int_116].VAT_PHAM_SO_LUONG, 0) <= int_117)
                  {
                        this.TRANG_BI_LAN_BAO_VAY[int_116].Item_byte = new byte[0x49];
                        bytes = BitConverter.GetBytes(0);
                  }
                  else
                  {
                        bytes = BitConverter.GetBytes((int)(BitConverter.ToInt32(this.TRANG_BI_LAN_BAO_VAY[int_116].VAT_PHAM_SO_LUONG, 0) - int_117));
                        this.TRANG_BI_LAN_BAO_VAY[int_116].VAT_PHAM_SO_LUONG = bytes;
                  }
                  PacketData data = new PacketData();
                  data.method_3(1);
                  data.method_3(int_116);
                  data.Write2(0);
                  data.method_8((long)BitConverter.ToInt32(buffer2, 0));
                  if (int_118 == 1)
                  {
                        if (int_117 == 0)
                        {
                              data.Write4(this.TRANG_BI_LAN_BAO_VAY[int_116].Get_VAT_PHAM_SO_LUONG);
                        }
                        else
                        {
                              data.Write4(int_117);
                        }
                  }
                  else if (int_118 == 0)
                  {
                        if (int_117 == 0)
                        {
                              data.Write4(0x2c);
                        }
                        else
                        {
                              data.Write4(0x2c);
                        }
                  }
                  data.Write4(this.TRANG_BI_LAN_BAO_VAY[int_116].Get_VAT_PHAM_SO_LUONG);
                  if (this.TRANG_BI_LAN_BAO_VAY[int_116].GetItem_ID == 0x19f105L)
                  {
                        data.Write4(0x6f);
                  }
                  else
                  {
                        data.Write4(0);
                  }
                  data.Write4(0);
                  if (this.Client != null)
                  {
                        this.Client.method_4(data, 0x3b00, this.UserSessionID);
                  }
            }

            public void method_84(int int_116, int int_117, int int_118)
            {
                  PacketData data = new PacketData();
                  data.method_2(1);
                  data.Write2(int_116);
                  data.method_2(0);
                  data.Write4(BitConverter.ToInt32(this.TRANG_BI_LAN_BAO_VAY[int_116].VAT_PHAM_ID, 0));
                  data.Write4(0);
                  data.Write2(int_118);
                  data.Write2(0);
                  data.Write4(int_117);
                  if (this.Client != null)
                  {
                        this.Client.method_4(data, 0x3b00, this.UserSessionID);
                  }
            }

            public void method_91(Players class15_0, Players class15_1)
            {
                  using (PacketData data = new PacketData())
                  {
                        data.Write4(1);
                        data.Write4(class15_1.NHAN_VAT_LINH_THU.int_17);
                        if (class15_0.Client != null)
                        {
                              class15_0.Client.method_5(data, 0x6300, class15_0.UserSessionID, 0);
                        }
                        class15_0.vmethod_2(data, 0x6300, class15_0.UserSessionID, 0);
                  }
            }

            public void method_92(Players class15_0, Players class15_1)
            {
                  using (PacketData data = new PacketData())
                  {
                        data.Write4(1);
                        data.Write4(class15_1.NHAN_VAT_LINH_THU.int_17);
                        if (class15_0.Client != null)
                        {
                              class15_0.Client.method_5(data, 0x6300, class15_0.UserSessionID, 0);
                        }
                  }
            }

            public void method_93(Players class15_0, Players class15_1)
            {
                  try
                  {
                        using (PacketData data = new PacketData())
                        {
                              data.Write4(1);
                              data.Write4(class15_1.UserSessionID);
                              if (class15_0.Client != null)
                              {
                                    class15_0.Client.method_5(data, 0x6300, class15_0.UserSessionID, 0);
                              }
                        }
                        if (class15_1.NHAN_VAT_LINH_THU != null)
                        {
                              this.method_92(class15_0, class15_1);
                        }
                  }
                  catch
                  {
                  }
            }

            public void New_Medicine_Tip()
            {
                  PacketData data = new PacketData();
                  data.Write4(0x401);
                  data.method_8(0x3c14dc5dL);
                  data.Write4(3);
                  data.Write4(1);
                  data.Write4(0x7735940c);
                  data.Write4(0);
                  if (this.Client != null)
                  {
                        this.Client.method_4(data, 0x3b00, this.UserSessionID);
                  }
            }

            public VAT_PHAM_LOAI NHAN_DUOC_NHAN_VAT_THEM_VAO_KHO_CHUNG_LOAI_HINH(int id, int int_117)
            {
                  if (int_117 == 3)
                  {
                        foreach (VAT_PHAM_LOAI vat_pham_loai in this.class23_0)
                        {
                              if (BitConverter.ToInt32(vat_pham_loai.VAT_PHAM_ID, 0) == id)
                              {
                                    return vat_pham_loai;
                              }
                        }
                  }
                  else
                  {
                        foreach (VAT_PHAM_LOAI vat_pham_loai2 in this.class23_1)
                        {
                              if (BitConverter.ToInt32(vat_pham_loai2.VAT_PHAM_ID, 0) == id)
                              {
                                    return vat_pham_loai2;
                              }
                        }
                  }
                  return null;
            }

            public VAT_PHAM_LOAI NHAN_NHAN_VAT_ITEM_LOAI_HINH(int int_116)
            {
                  foreach (VAT_PHAM_LOAI vat_pham_loai in this.TRANG_BI_LAN_BAO_VAY)
                  {
                        if (vat_pham_loai.GetItem_ID == int_116)
                        {
                              return vat_pham_loai;
                        }
                  }
                  return null;
            }

            public VAT_PHAM_LOAI NHAN_NHAN_VAT_ITEM_TOAN_BO_ID(Players class15_0, long long_16)
            {
                  foreach (VAT_PHAM_LOAI vat_pham_loai in class15_0.TRANG_BI_LAN_BAO_VAY)
                  {
                        if (vat_pham_loai.GetItem_toan_bo_ID == long_16)
                        {
                              return vat_pham_loai;
                        }
                  }
                  return null;
            }

            public List<int> NHAN_TUI_TRONG_NHOM(int int_116)
            {
                  int num = 0;
                  List<int> list = new List<int>();
                  for (int i = 0; i < 0x42; i++)
                  {
                        if (BitConverter.ToInt32(this.TRANG_BI_LAN_BAO_VAY[i].VAT_PHAM_ID, 0) == 0)
                        {
                              num++;
                              list.Add(i);
                              if (num >= int_116)
                              {
                                    return list;
                              }
                        }
                  }
                  return list;
            }

            public int NHAN_TUI_TRONG_SO_LUONG()
            {
                  int num = 0;
                  for (int i = 0; i < 0x42; i++)
                  {
                        if (BitConverter.ToInt32(this.TRANG_BI_LAN_BAO_VAY[i].VAT_PHAM_ID, 0) == 0)
                        {
                              num++;
                        }
                  }
                  return num;
            }

            public void NOI_CONG_KHONG_DU_NHAC_NHO()
            {
                  byte[] dst = Converter.hexStringToByte("AA5517000000003D0008000E2C090002000000000000000000000055AA");
                  Buffer.BlockCopy(BitConverter.GetBytes(this.UserSessionID), 0, dst, 5, 2);
                  if (this.Client != null)
                  {
                        this.Client.Send(dst, dst.Length);
                  }
            }

            public bool PHAN_DOAN_TRANG_BI(long pid, int int_116)
            {
                  if (int_116 == 1)
                  {
                        if (pid != 0x6df5a89L)
                        {
                              if (pid == 0x6df5e71L)
                              {
                                    return true;
                              }
                              if (pid == 0x777f109L)
                              {
                                    return true;
                              }
                              if (pid == 0x777f4f1L)
                              {
                                    return true;
                              }
                              if (pid == 0xcd53b89L)
                              {
                                    return true;
                              }
                              if (pid == 0xcd53f71L)
                              {
                                    return true;
                              }
                              if (pid == 0xd6dd209L)
                              {
                                    return true;
                              }
                              if (pid == 0xd6dd5f1L)
                              {
                                    return true;
                              }
                              if (pid == 0x12cb1c89L)
                              {
                                    return true;
                              }
                              if (pid == 0x12cb2071L)
                              {
                                    return true;
                              }
                              if (pid == 0x1363b309L)
                              {
                                    return true;
                              }
                              if (pid == 0x1363b6f1L)
                              {
                                    return true;
                              }
                              if (pid == 0x18c0fd89L)
                              {
                                    return true;
                              }
                              if (pid == 0x18c10171L)
                              {
                                    return true;
                              }
                              if (pid == 0x19599409L)
                              {
                                    return true;
                              }
                              if (pid == 0x195997f1L)
                              {
                                    return true;
                              }
                              if (pid == 0x1eb6de89L)
                              {
                                    return true;
                              }
                              if (pid == 0x1eb6e271L)
                              {
                                    return true;
                              }
                              if (pid == 0x1f4f7509L)
                              {
                                    return true;
                              }
                              if (pid == 0x1f4f78f1L)
                              {
                                    return true;
                              }
                              if (pid == 0x2aa2a089L)
                              {
                                    return true;
                              }
                              if (pid == 0x2aa2a471L)
                              {
                                    return true;
                              }
                              if (pid == 0x2b3b3709L)
                              {
                                    return true;
                              }
                              if (pid == 0x2b3b3af1L)
                              {
                                    return true;
                              }
                              if (pid == 0x30988189L)
                              {
                                    return true;
                              }
                              if (pid == 0x30988571L)
                              {
                                    return true;
                              }
                              if (pid != 0x31311809L)
                              {
                                    return (pid == 0x31311bf1L);
                              }
                        }
                        return true;
                  }
                  if (int_116 == 2)
                  {
                        if (pid != 0x2b3e4831L)
                        {
                              if (pid == 0x2b3e4449L)
                              {
                                    return true;
                              }
                              if (pid == 0x2aa5b1b1L)
                              {
                                    return true;
                              }
                              if (pid == 0x2aa5adc9L)
                              {
                                    return true;
                              }
                              if (pid == 0x1f528631L)
                              {
                                    return true;
                              }
                              if (pid == 0x1f528249L)
                              {
                                    return true;
                              }
                              if (pid == 0x1eb9efb1L)
                              {
                                    return true;
                              }
                              if (pid == 0x1eb9ebc9L)
                              {
                                    return true;
                              }
                              if (pid == 0x195ca531L)
                              {
                                    return true;
                              }
                              if (pid == 0x195ca149L)
                              {
                                    return true;
                              }
                              if (pid == 0x18c40eb1L)
                              {
                                    return true;
                              }
                              if (pid == 0x18c40ac9L)
                              {
                                    return true;
                              }
                              if (pid == 0x1366c431L)
                              {
                                    return true;
                              }
                              if (pid == 0x1366c049L)
                              {
                                    return true;
                              }
                              if (pid == 0x12ce2db1L)
                              {
                                    return true;
                              }
                              if (pid == 0x12ce29c9L)
                              {
                                    return true;
                              }
                              if (pid == 0xd70e331L)
                              {
                                    return true;
                              }
                              if (pid == 0xd70df49L)
                              {
                                    return true;
                              }
                              if (pid == 0xcd84cb1L)
                              {
                                    return true;
                              }
                              if (pid == 0xcd848c9L)
                              {
                                    return true;
                              }
                              if (pid == 0x77b0231L)
                              {
                                    return true;
                              }
                              if (pid == 0x77afe49L)
                              {
                                    return true;
                              }
                              if (pid == 0x6e26bb1L)
                              {
                                    return true;
                              }
                              if (pid == 0x6e267c9L)
                              {
                                    return true;
                              }
                              if (pid == 0x309b8ec9L)
                              {
                                    return true;
                              }
                              if (pid == 0x309b92b1L)
                              {
                                    return true;
                              }
                              if (pid != 0x31342549L)
                              {
                                    return (pid == 0x31342931L);
                              }
                        }
                        return true;
                  }
                  if (int_116 == 5)
                  {
                        if (pid != 0x6e6fba9L)
                        {
                              if (pid == 0x6e6ff91L)
                              {
                                    return true;
                              }
                              if (pid == 0x77f9229L)
                              {
                                    return true;
                              }
                              if (pid == 0x77f9611L)
                              {
                                    return true;
                              }
                              if (pid == 0xcdcdca9L)
                              {
                                    return true;
                              }
                              if (pid == 0xcdce091L)
                              {
                                    return true;
                              }
                              if (pid == 0xd757329L)
                              {
                                    return true;
                              }
                              if (pid == 0xd757711L)
                              {
                                    return true;
                              }
                              if (pid == 0x12d2bda9L)
                              {
                                    return true;
                              }
                              if (pid == 0x12d2c191L)
                              {
                                    return true;
                              }
                              if (pid == 0x136b5429L)
                              {
                                    return true;
                              }
                              if (pid == 0x136b5811L)
                              {
                                    return true;
                              }
                              if (pid == 0x18c89ea9L)
                              {
                                    return true;
                              }
                              if (pid == 0x18c8a291L)
                              {
                                    return true;
                              }
                              if (pid == 0x19613529L)
                              {
                                    return true;
                              }
                              if (pid == 0x19613911L)
                              {
                                    return true;
                              }
                              if (pid == 0x1ebe7fa9L)
                              {
                                    return true;
                              }
                              if (pid == 0x1ebe8391L)
                              {
                                    return true;
                              }
                              if (pid == 0x1f571629L)
                              {
                                    return true;
                              }
                              if (pid == 0x1f571a11L)
                              {
                                    return true;
                              }
                              if (pid == 0x2aaa41a9L)
                              {
                                    return true;
                              }
                              if (pid == 0x2aaa4591L)
                              {
                                    return true;
                              }
                              if (pid == 0x2b42d829L)
                              {
                                    return true;
                              }
                              if (pid == 0x2b42dc11L)
                              {
                                    return true;
                              }
                              if (pid == 0x30a022a9L)
                              {
                                    return true;
                              }
                              if (pid == 0x30a02691L)
                              {
                                    return true;
                              }
                              if (pid != 0x3138b929L)
                              {
                                    return (pid == 0x3138bd11L);
                              }
                        }
                        return true;
                  }
                  if (int_116 != 6)
                  {
                        return false;
                  }
                  if (pid != 0x6e0e129L)
                  {
                        if (pid == 0x6e0e511L)
                        {
                              return true;
                        }
                        if (pid == 0x77977a9L)
                        {
                              return true;
                        }
                        if (pid == 0x7797b91L)
                        {
                              return true;
                        }
                        if (pid == 0xcd6c229L)
                        {
                              return true;
                        }
                        if (pid == 0xcd6c611L)
                        {
                              return true;
                        }
                        if (pid == 0xd6f58a9L)
                        {
                              return true;
                        }
                        if (pid == 0xd6f5c91L)
                        {
                              return true;
                        }
                        if (pid == 0x12cca329L)
                        {
                              return true;
                        }
                        if (pid == 0x12cca711L)
                        {
                              return true;
                        }
                        if (pid == 0x136539a9L)
                        {
                              return true;
                        }
                        if (pid == 0x13653d91L)
                        {
                              return true;
                        }
                        if (pid == 0x18c28429L)
                        {
                              return true;
                        }
                        if (pid == 0x18c28811L)
                        {
                              return true;
                        }
                        if (pid == 0x195b1aa9L)
                        {
                              return true;
                        }
                        if (pid == 0x195b1e91L)
                        {
                              return true;
                        }
                        if (pid == 0x1eb86529L)
                        {
                              return true;
                        }
                        if (pid == 0x1eb86911L)
                        {
                              return true;
                        }
                        if (pid == 0x1f50fba9L)
                        {
                              return true;
                        }
                        if (pid == 0x1f50ff91L)
                        {
                              return true;
                        }
                        if (pid == 0x2aa42729L)
                        {
                              return true;
                        }
                        if (pid == 0x2aa42b11L)
                        {
                              return true;
                        }
                        if (pid == 0x2b3cbda9L)
                        {
                              return true;
                        }
                        if (pid == 0x2b3cc191L)
                        {
                              return true;
                        }
                        if (pid == 0x309a0829L)
                        {
                              return true;
                        }
                        if (pid == 0x309a0c11L)
                        {
                              return true;
                        }
                        if (pid != 0x31329ea9L)
                        {
                              return (pid == 0x3132a291L);
                        }
                  }
                  return true;
            }

            public void PickItem_Tip(int int_116, long long_16)
            {
                  PacketData data = new PacketData();
                  data.Write4(int_116);
                  data.method_8(long_16);
                  if (this.Client != null)
                  {
                        this.Client.method_5(data, 0xd00, this.UserSessionID, 0);
                  }
            }

            public void Plus_Magic(int MANA)
            {
                  if ((this.threadSafeDictionary_4 != null) && this.threadSafeDictionary_4.ContainsKey(3))
                  {
                        MANA -= (int)(MANA * 0.2);
                  }
                  if (this.Player_Job == 5)
                  {
                        MANA = (int)(MANA * (1.0 + base.Y_van_khi_lieu_tam));
                  }
                  if ((this.Player_Job != 5) && (this.Player_FLD_JOB_LEVEL >= 6))
                  {
                        MANA = (int)(MANA * (1.0 + base.Thang_thien_1_khi_cong_Van_khi_hanh_tam));
                  }
                  if ((this.NHAN_VAT_MP + MANA) < this.NHAN_VAT_LON_NHAT_MP)
                  {
                        this.NHAN_VAT_MP += MANA;
                  }
                  else
                  {
                        this.NHAN_VAT_MP = this.NHAN_VAT_LON_NHAT_MP;
                  }
            }

            public void Production_Level()
            {
                  int num = this.FLD_CHE_TAO_THU_BAC;
                  if (this.FLD_CHE_TAO_DO_THUAN_THUC >= 800)
                  {
                        this.FLD_CHE_TAO_THU_BAC = 8;
                  }
                  else if (this.FLD_CHE_TAO_DO_THUAN_THUC >= 750)
                  {
                        this.FLD_CHE_TAO_THU_BAC = 7;
                  }
                  else if (this.FLD_CHE_TAO_DO_THUAN_THUC >= 700)
                  {
                        this.FLD_CHE_TAO_THU_BAC = 6;
                  }
                  else if (this.FLD_CHE_TAO_DO_THUAN_THUC >= 650)
                  {
                        this.FLD_CHE_TAO_THU_BAC = 5;
                  }
                  if (this.FLD_CHE_TAO_DO_THUAN_THUC >= 600)
                  {
                        this.FLD_CHE_TAO_THU_BAC = 4;
                  }
                  else if (this.FLD_CHE_TAO_DO_THUAN_THUC >= 300)
                  {
                        this.FLD_CHE_TAO_THU_BAC = 3;
                  }
                  else if (this.FLD_CHE_TAO_DO_THUAN_THUC >= 100)
                  {
                        this.FLD_CHE_TAO_THU_BAC = 2;
                  }
                  else
                  {
                        this.FLD_CHE_TAO_THU_BAC = 1;
                  }
                  if (this.FLD_CHE_TAO_THU_BAC > num)
                  {
                        this.Update_Production_System();
                  }
            }

            public void LoadQuestData(string userid, int index)
            {
                  string str = string.Format("select * from [TBL_XWWL_Char] where FLD_ID=@Userid and FLD_INDEX=@index", new object[0]);
                  SqlParameter[] parameterArray = new SqlParameter[] { SqlDBA.MakeInParam("@Userid", SqlDbType.VarChar, 30, userid), SqlDBA.MakeInParam("@index", SqlDbType.Int, 30, index) };
                  DataTable table = DBA.smethod_9(str, parameterArray);

                  byte[] buffer4 = (byte[])table.Rows[0]["FLD_QUEST"];
                  Form1.WriteLine(1, "Players READ_CHAR_DATA FLD_QUEST Data: [" + BitConverter.ToString(buffer4).Replace("-", "") + "]");
                  int num16 = 0;
                  while (true)
                  {
                        if (num16 >= 100)
                        {
                              break;
                        }
                        byte[] buffer31 = new byte[4];
                        try
                        {
                              if (buffer4.Length < ((num16 * 4) + 4))
                              {
                                    break;
                              }
                              Buffer.BlockCopy(buffer4, num16 * 4, buffer31, 0, 4);
                              NHIEM_VU_CLASS nhiem_vu_class = new NHIEM_VU_CLASS(buffer31);
                              if ((nhiem_vu_class.NHIEM_VU_ID != 0) && !this.dictionary_2.ContainsKey(nhiem_vu_class.NHIEM_VU_ID))
                              {
                                    this.dictionary_2.Add(nhiem_vu_class.NHIEM_VU_ID, nhiem_vu_class);
                              }
                        }
                        catch (Exception exception21)
                        {
                              Console.WriteLine(exception21);
                        }
                        num16++;
                  }
            }
            //캐릭터 정보 로드
            public void READ_CHAR_DATA()
            {
                  try
                  {
                        DateTime time;
                        byte[] buffer;
                        int num;
                        int num2;
                        byte[] buffer2;
                        int num3;
                        byte[] buffer3;
                        int num4;
                        byte[] buffer4;
                        int num5;
                        int num6;
                        byte[] buffer9;
                        if (World.jlMsg == 1)
                        {
                              Form1.WriteLine(0, "PlayersBes_读出人物数据()");
                        }
                        this.THIET_LAP_TI_LE_MAC_DINH();
                        string str = string.Format("select * from [TBL_XWWL_Char] where FLD_ID=@Userid and FLD_NAME =@Username", new object[0]);
                        SqlParameter[] parameterArray = new SqlParameter[] { SqlDBA.MakeInParam("@Userid", SqlDbType.VarChar, 30, this.Userid), SqlDBA.MakeInParam("@Username", SqlDbType.VarChar, 30, this.UserName) };
                        DataTable table = DBA.smethod_9(str, parameterArray);
                        if ((table.Rows.Count == 0) && (this.Client != null))
                        {
                              this.Client.Dispose();
                        }
                        this.int_4 = (int)table.Rows[0]["FLD_J9"];
                        this.NHAN_VAT_VI_TRI = (int)table.Rows[0]["FLD_INDEX"];
                        this.int_29 = (int)table.Rows[0]["FLD_FIGHT_EXP"];
                        this.long_0 = long.Parse(table.Rows[0]["FLD_EXP"].ToString());
                        try
                        {
                              this.long_2 = long.Parse(table.Rows[0]["FLD_MONEY"].ToString());
                        }
                        catch
                        {
                              this.long_2 = 0L;
                        }
                        //
                        LoadQuestData(this.Userid, this.NHAN_VAT_VI_TRI);
                        this.int_45 = (int)table.Rows[0]["FLD_POINT"];
                        this.int_46 = (int)table.Rows[0]["FLD_ZX"];
                        this.int_47 = (int)table.Rows[0]["FLD_LEVEL"];
                        this.int_51 = (int)table.Rows[0]["FLD_JOB"];
                        this.int_52 = (int)table.Rows[0]["FLD_JOB_LEVEL"];
                        this.class84_0 = new NHAN_VAT_CLASS((byte[])table.Rows[0]["FLD_FACE"]);
                        this.byte_4 = (byte[])table.Rows[0]["FLD_NAMETYPE"];
                        this.int_53 = this.class84_0.GIOI_TINH;
                        this.long_3 = (int)table.Rows[0]["FLD_HP"];
                        this.int_38 = (int)table.Rows[0]["FLD_MP"];
                        this.int_43 = (int)table.Rows[0]["FLD_SP"];
                        this.FLD_CHE_TAO_LOAI_HINH = (int)table.Rows[0]["FLD_ZzType"];
                        this.FLD_CHE_TAO_DO_THUAN_THUC = (int)table.Rows[0]["FLD_ZzSl"];
                        this.float_1 = float.Parse(table.Rows[0]["FLD_X"].ToString());
                        this.float_2 = float.Parse(table.Rows[0]["FLD_Y"].ToString());
                        this.float_3 = float.Parse(table.Rows[0]["FLD_Z"].ToString());
                        this.int_2 = (int)table.Rows[0]["FLD_ZBVER"];
                        this.int_54 = (int)table.Rows[0]["FLD_MENOW"];
                        if (((this.int_53 < 1) || (this.int_53 > 2)) && (this.Client != null))
                        {
                              this.Client.Dispose();
                        }
                        this.class31_0 = new TBL_XWWL_MAP(this.CharacterCoords_X, this.CharacterCoords_Y, this.CharacterCoords_Z, this.CharacterCoords_Map);
                        this.Player_WuXun = (int)table.Rows[0]["FLD_WX"];
                        this.Player_MaxWx = (int)table.Rows[0]["FLD_GETWX"];
                        this.NHAN_VAT_THIEN_AC = (int)table.Rows[0]["FLD_SE"];
                        this.NHAN_VAT_KHINH_CONG = (int)table.Rows[0]["FLD_JQ"];
                        this.FLD_TINH_NHAN = table.Rows[0]["FLD_QlNAME"].ToString();
                        this.FLD_TINH_NHAN_NHAN_CUOI = table.Rows[0]["FLD_QlJZNAME"].ToString();
                        this.FLD_TINH_NHAN_CAP_DO_YEU = (int)table.Rows[0]["FLD_QlDu"];
                        string str2 = string.Format("select * from [TBL_XWWL_Char] where FLD_NAME =@Username", new object[0]);
                        if (this.FLD_TINH_NHAN != "")
                        {
                              SqlParameter[] parameterArray2 = new SqlParameter[] { SqlDBA.MakeInParam("@Username", SqlDbType.VarChar, 30, this.FLD_TINH_NHAN) };
                              DataTable table1 = DBA.smethod_9(str2, parameterArray2);
                              if (table1.Rows.Count == 0)
                              {
                                    this.FLD_TINH_NHAN = "";
                                    this.FLD_TINH_NHAN_CAP_DO_YEU = 0;
                              }
                              table1.Dispose();
                        }
                        try
                        {
                              this.dateTime_8 = DateTime.Parse(table.Rows[0]["Vo_huan_cap_8_doan_thoi_gian"].ToString());
                              this.int_65 = (int)table.Rows[0]["Vo_huan_cap_8_co_hay_khong_mo_ra"];
                              this.int_15 = (int)table.Rows[0]["FLD_thang_thien_vo_cong_diem"];
                              this.int_14 = (int)table.Rows[0]["FLD_thang_thien_kinh_nghiem"];
                        }
                        catch
                        {
                              this.int_14 = 0;
                        }
                        if (this.Player_ExpErience < 0)
                        {
                              this.Player_ExpErience = 0x989680;
                        }
                        if (this.Player_Qigong_point < 0)
                        {
                              this.Player_Qigong_point = 0;
                        }
                        try
                        {
                              if (table.Rows[0]["Truc_tuyen_thoi_gian"] != DBNull.Value)
                              {
                                    byte[] buffer26 = (byte[])table.Rows[0]["Truc_tuyen_thoi_gian"];
                                    Buffer.BlockCopy(buffer26, 0, this.byte_2, 0, buffer26.Length);
                              }
                              this.long_8 = (int)table.Rows[0]["FLD_ADD_HP"];
                              this.long_9 = long.Parse(table.Rows[0]["FLD_ADD_AT"].ToString());
                              this.long_10 = long.Parse(table.Rows[0]["FLD_ADD_DF"].ToString());
                              this.int_83 = (int)table.Rows[0]["FLD_ADD_HB"];
                              this.int_82 = (int)table.Rows[0]["FLD_ADD_MP"];
                              this.int_84 = (int)table.Rows[0]["FLD_ADD_MZ"];
                              this.int_85 = (int)table.Rows[0]["FLD_ZS"];
                              this.long_13 = long.Parse(table.Rows[0]["FLD_VIPDJ"].ToString());
                              this.string_9 = table.Rows[0]["FLD_FQID"].ToString();
                              this.long_12 = long.Parse(table.Rows[0]["Giet_nguoi_so_lan"].ToString());
                              this.long_11 = long.Parse(table.Rows[0]["Bi_giet_so_lan"].ToString());
                              if ((this.NHAN_VAT_PHAN_KHU_ID == "") || (this.NHAN_VAT_PHAN_KHU_ID != this.PHAN_KHU_ID))
                              {
                                    DBA.smethod_7($"UPDATE  [TBL_XWWL_Char] SET FLD_FQID='{this.PHAN_KHU_ID}' WHERE FLD_ID='{this.Userid}'", "rxjhgame");
                              }
                        }
                        catch
                        {
                        }
                        int num7 = 0;
                        if (table.Rows[0]["FLD_thang_thien_khi_cong"] == DBNull.Value)
                        {
                              goto Label_0BCC;
                        }
                        byte[] src = (byte[])table.Rows[0]["FLD_thang_thien_khi_cong"];
                        if (this.Player_FLD_JOB_LEVEL < 6)
                        {
                              goto Label_0BCC;
                        }
                        int num8 = 0;
                        Label_0896:
                        if (num8 >= 15)
                        {
                              goto Label_0BCC;
                        }
                        byte[] dst = new byte[4];
                        try
                        {
                              KHI_CONG_THANG_THIEN khi_cong_thang_thien;
                              if (src.Length < ((num8 * 4) + 4))
                              {
                                    goto Label_0BCC;
                              }
                              Buffer.BlockCopy(src, num8 * 4, dst, 0, 4);
                              THANG_THIEN_KHI_CONG_LOAI thang_thien_khi_cong_loai = new THANG_THIEN_KHI_CONG_LOAI(dst);
                              if (World.dictionary_6.TryGetValue(thang_thien_khi_cong_loai.KHI_CONG_ID, out khi_cong_thang_thien))
                              {
                                    switch (this.Player_Job)
                                    {
                                          case 1:
                                                goto Label_0926;

                                          case 2:
                                                goto Label_0969;

                                          case 3:
                                                goto Label_09AC;

                                          case 4:
                                                goto Label_09EF;

                                          case 5:
                                                goto Label_0A32;

                                          case 6:
                                                goto Label_0A75;

                                          case 7:
                                                goto Label_0AB8;

                                          case 8:
                                                goto Label_0AFB;

                                          case 9:
                                                goto Label_0B3E;

                                          case 10:
                                                if ((khi_cong_thang_thien.NHAN_VAT_NGHE_NGHIEP_10 == 1) && !this.THANG_THIEN_KHI_CONG.ContainsKey(thang_thien_khi_cong_loai.KHI_CONG_ID))
                                                {
                                                      this.THANG_THIEN_KHI_CONG.Add(thang_thien_khi_cong_loai.KHI_CONG_ID, thang_thien_khi_cong_loai);
                                                      num7 += thang_thien_khi_cong_loai.KHI_CONG_SO_LUONG;
                                                }
                                                break;
                                    }
                              }
                              goto Label_0BC1;
                              Label_0926:
                              if ((khi_cong_thang_thien.NHAN_VAT_NGHE_NGHIEP_1 == 1) && !this.THANG_THIEN_KHI_CONG.ContainsKey(thang_thien_khi_cong_loai.KHI_CONG_ID))
                              {
                                    this.THANG_THIEN_KHI_CONG.Add(thang_thien_khi_cong_loai.KHI_CONG_ID, thang_thien_khi_cong_loai);
                                    num7 += thang_thien_khi_cong_loai.KHI_CONG_SO_LUONG;
                              }
                              goto Label_0BC1;
                              Label_0969:
                              if ((khi_cong_thang_thien.NHAN_VAT_NGHE_NGHIEP_2 == 1) && !this.THANG_THIEN_KHI_CONG.ContainsKey(thang_thien_khi_cong_loai.KHI_CONG_ID))
                              {
                                    this.THANG_THIEN_KHI_CONG.Add(thang_thien_khi_cong_loai.KHI_CONG_ID, thang_thien_khi_cong_loai);
                                    num7 += thang_thien_khi_cong_loai.KHI_CONG_SO_LUONG;
                              }
                              goto Label_0BC1;
                              Label_09AC:
                              if ((khi_cong_thang_thien.NHAN_VAT_NGHE_NGHIEP_3 == 1) && !this.THANG_THIEN_KHI_CONG.ContainsKey(thang_thien_khi_cong_loai.KHI_CONG_ID))
                              {
                                    this.THANG_THIEN_KHI_CONG.Add(thang_thien_khi_cong_loai.KHI_CONG_ID, thang_thien_khi_cong_loai);
                                    num7 += thang_thien_khi_cong_loai.KHI_CONG_SO_LUONG;
                              }
                              goto Label_0BC1;
                              Label_09EF:
                              if ((khi_cong_thang_thien.NHAN_VAT_NGHE_NGHIEP_4 == 1) && !this.THANG_THIEN_KHI_CONG.ContainsKey(thang_thien_khi_cong_loai.KHI_CONG_ID))
                              {
                                    this.THANG_THIEN_KHI_CONG.Add(thang_thien_khi_cong_loai.KHI_CONG_ID, thang_thien_khi_cong_loai);
                                    num7 += thang_thien_khi_cong_loai.KHI_CONG_SO_LUONG;
                              }
                              goto Label_0BC1;
                              Label_0A32:
                              if ((khi_cong_thang_thien.NHAN_VAT_NGHE_NGHIEP_5 == 1) && !this.THANG_THIEN_KHI_CONG.ContainsKey(thang_thien_khi_cong_loai.KHI_CONG_ID))
                              {
                                    this.THANG_THIEN_KHI_CONG.Add(thang_thien_khi_cong_loai.KHI_CONG_ID, thang_thien_khi_cong_loai);
                                    num7 += thang_thien_khi_cong_loai.KHI_CONG_SO_LUONG;
                              }
                              goto Label_0BC1;
                              Label_0A75:
                              if ((khi_cong_thang_thien.NHAN_VAT_NGHE_NGHIEP_6 == 1) && !this.THANG_THIEN_KHI_CONG.ContainsKey(thang_thien_khi_cong_loai.KHI_CONG_ID))
                              {
                                    this.THANG_THIEN_KHI_CONG.Add(thang_thien_khi_cong_loai.KHI_CONG_ID, thang_thien_khi_cong_loai);
                                    num7 += thang_thien_khi_cong_loai.KHI_CONG_SO_LUONG;
                              }
                              goto Label_0BC1;
                              Label_0AB8:
                              if ((khi_cong_thang_thien.NHAN_VAT_NGHE_NGHIEP_7 == 1) && !this.THANG_THIEN_KHI_CONG.ContainsKey(thang_thien_khi_cong_loai.KHI_CONG_ID))
                              {
                                    this.THANG_THIEN_KHI_CONG.Add(thang_thien_khi_cong_loai.KHI_CONG_ID, thang_thien_khi_cong_loai);
                                    num7 += thang_thien_khi_cong_loai.KHI_CONG_SO_LUONG;
                              }
                              goto Label_0BC1;
                              Label_0AFB:
                              if ((khi_cong_thang_thien.NHAN_VAT_NGHE_NGHIEP_8 == 1) && !this.THANG_THIEN_KHI_CONG.ContainsKey(thang_thien_khi_cong_loai.KHI_CONG_ID))
                              {
                                    this.THANG_THIEN_KHI_CONG.Add(thang_thien_khi_cong_loai.KHI_CONG_ID, thang_thien_khi_cong_loai);
                                    num7 += thang_thien_khi_cong_loai.KHI_CONG_SO_LUONG;
                              }
                              goto Label_0BC1;
                              Label_0B3E:
                              if ((khi_cong_thang_thien.NHAN_VAT_NGHE_NGHIEP_9 == 1) && !this.THANG_THIEN_KHI_CONG.ContainsKey(thang_thien_khi_cong_loai.KHI_CONG_ID))
                              {
                                    this.THANG_THIEN_KHI_CONG.Add(thang_thien_khi_cong_loai.KHI_CONG_ID, thang_thien_khi_cong_loai);
                                    num7 += thang_thien_khi_cong_loai.KHI_CONG_SO_LUONG;
                              }
                        }
                        catch (Exception)
                        {
                        }
                        Label_0BC1:
                        num8++;
                        goto Label_0896;
                        Label_0BCC:
                        buffer = new byte[20];
                        byte[] buffer7 = (byte[])table.Rows[0]["FLD_SKILLS"];
                        Buffer.BlockCopy(buffer7, 0, buffer, 0, buffer7.Length);
                        int srcOffset = 0;
                        Label_0C03:
                        if (srcOffset >= 15)
                        {
                              goto Label_0E62;
                        }
                        byte[] buffer8 = new byte[2];
                        try
                        {
                              if (buffer.Length > (srcOffset + 1))
                              {
                                    Buffer.BlockCopy(buffer, srcOffset, buffer8, 0, 1);
                              }
                              goto Label_0E2C;
                        }
                        catch (Exception)
                        {
                              goto Label_0E2C;
                        }
                        Label_0C34:
                        if (srcOffset < 11)
                        {
                              this.Qigong[srcOffset].int_0 = this.GetQigongID(srcOffset);
                        }
                        goto Label_0E21;
                        Label_0C58:
                        if (this.Player_FLD_LEVEL >= 10)
                        {
                              this.Qigong[srcOffset].int_0 = this.GetQigongID(srcOffset);
                              if (this.Qigong[srcOffset].气功量 == 0xff)
                              {
                                    this.Qigong[srcOffset].气功量 = 0;
                              }
                        }
                        goto Label_0E21;
                        Label_0CA7:
                        if (this.Player_FLD_LEVEL >= 0x23)
                        {
                              this.Qigong[srcOffset].int_0 = this.GetQigongID(srcOffset);
                              if (this.Qigong[srcOffset].气功量 == 0xff)
                              {
                                    this.Qigong[srcOffset].气功量 = 0;
                              }
                        }
                        goto Label_0E21;
                        Label_0CF6:
                        if (this.Player_FLD_LEVEL >= 60)
                        {
                              this.Qigong[srcOffset].int_0 = this.GetQigongID(srcOffset);
                              if (this.Qigong[srcOffset].气功量 == 0xff)
                              {
                                    this.Qigong[srcOffset].气功量 = 0;
                              }
                        }
                        goto Label_0E21;
                        Label_0D45:
                        if (this.Player_FLD_LEVEL >= 80)
                        {
                              this.Qigong[srcOffset].int_0 = this.GetQigongID(srcOffset);
                              if (this.Qigong[srcOffset].气功量 == 0xff)
                              {
                                    this.Qigong[srcOffset].气功量 = 0;
                              }
                        }
                        goto Label_0E21;
                        Label_0D94:
                        if (this.Player_FLD_LEVEL >= 90)
                        {
                              this.Qigong[srcOffset].int_0 = this.GetQigongID(srcOffset);
                              if (this.Qigong[srcOffset].气功量 == 0xff)
                              {
                                    this.Qigong[srcOffset].气功量 = 0;
                              }
                        }
                        goto Label_0E21;
                        Label_0DDD:
                        if (this.Player_FLD_LEVEL >= 100)
                        {
                              this.Qigong[srcOffset].int_0 = this.GetQigongID(srcOffset);
                              if (this.Qigong[srcOffset].气功量 == 0xff)
                              {
                                    this.Qigong[srcOffset].气功量 = 0;
                              }
                        }
                        Label_0E21:
                        srcOffset++;
                        goto Label_0C03;
                        Label_0E2C:
                        this.Qigong[srcOffset] = new QigongClass(buffer8);
                        switch (srcOffset)
                        {
                              case 5:
                                    goto Label_0C58;

                              case 6:
                                    goto Label_0CA7;

                              case 7:
                                    goto Label_0CF6;

                              case 8:
                                    goto Label_0D45;

                              case 9:
                                    goto Label_0D94;

                              case 10:
                                    goto Label_0DDD;

                              default:
                                    goto Label_0C34;
                        }
                        Label_0E62:
                        num = 0;
                        int num10 = 0;
                        for (int i = 0; i < 11; i++)
                        {
                              byte[] buffer1 = this.Qigong[i].气功_byte;
                              int num22 = BitConverter.ToInt16(buffer1, 0);
                              if (buffer1[0] != 0xff)
                              {
                                    num += num22;
                              }
                        }
                        if (this.Player_FLD_LEVEL > 0x22)
                        {
                              num10 = 0x22;
                              int num23 = this.Player_FLD_LEVEL - 0x23;
                              num10 = 0x22 + (num23 * 2);
                        }
                        else
                        {
                              num10 = this.Player_FLD_LEVEL - 1;
                        }
                        if (((num + this.Player_Qigong_point) + num7) != num10)
                        {
                              if ((num + num7) > (num10 - this.Player_Qigong_point))
                              {
                                    this.Player_Qigong_point = num10;
                                    for (int j = 0; j < 12; j++)
                                    {
                                          if (BitConverter.ToInt16(this.Qigong[j].气功_byte, 0) != 0xff)
                                          {
                                                this.Qigong[j].气功_byte = new byte[2];
                                          }
                                    }
                                    using (SortedDictionary<int, THANG_THIEN_KHI_CONG_LOAI>.ValueCollection.Enumerator enumerator = this.THANG_THIEN_KHI_CONG.Values.GetEnumerator())
                                    {
                                          while (enumerator.MoveNext())
                                          {
                                                enumerator.Current.KHI_CONG_SO_LUONG = 0;
                                          }
                                          goto Label_0F7E;
                                    }
                              }
                              this.Player_Qigong_point = (num10 - num) - num7;
                        }
                        Label_0F7E:
                        buffer9 = (byte[])table.Rows[0]["FLD_KONGFU"];
                        int num11 = 0;
                        while (true)
                        {
                              if (num11 >= 0x54)
                              {
                                    break;
                              }
                              byte[] buffer27 = new byte[4];
                              byte[] buffer28 = new byte[2];
                              try
                              {
                                    if (buffer9.Length < ((num11 * 6) + 4))
                                    {
                                          break;
                                    }
                                    Buffer.BlockCopy(buffer9, num11 * 6, buffer27, 0, 4);
                                    Buffer.BlockCopy(buffer9, (num11 * 6) + 4, buffer28, 0, 2);
                                    int num25 = BitConverter.ToInt32(buffer27, 0);
                                    int num26 = BitConverter.ToInt16(buffer28, 0);
                                    if (num25 != 0)
                                    {
                                          TBL_XWWL_KONGFU tbl_xwwl_kongfu = new TBL_XWWL_KONGFU(num25);
                                          if ((((tbl_xwwl_kongfu.FLD_JOB == 0) || (this.Player_Job == tbl_xwwl_kongfu.FLD_JOB)) && ((tbl_xwwl_kongfu.FLD_ZX == 0) || (this.Player_Zx == tbl_xwwl_kongfu.FLD_ZX))) && ((this.Player_FLD_JOB_LEVEL >= tbl_xwwl_kongfu.FLD_JOBLEVEL) && (this.Player_FLD_LEVEL >= tbl_xwwl_kongfu.FLD_LEVEL)))
                                          {
                                                this.class79_0[tbl_xwwl_kongfu.FLD_VO_CONG_LOAI_HINH, tbl_xwwl_kongfu.FLD_INDEX] = tbl_xwwl_kongfu;
                                                if (num26 != 0)
                                                {
                                                      if (num26 > tbl_xwwl_kongfu.FLD_VO_CONG_CAO_NHAT_DANG_CAP)
                                                      {
                                                            num26 = tbl_xwwl_kongfu.FLD_VO_CONG_CAO_NHAT_DANG_CAP;
                                                      }
                                                      tbl_xwwl_kongfu.VO_CONG_THU_BAC = num26;
                                                }
                                          }
                                    }
                              }
                              catch (Exception exception)
                              {
                                    Console.WriteLine("读出Vo_Cong出错 " + exception);
                              }
                              num11++;
                        }
                        if (((this.Player_FLD_JOB_LEVEL >= 5) && (this.Player_Job != 8)) && (this.Player_Job != 9))
                        {
                              if (this.class79_0[0, 0x19] == null)
                              {
                                    this.Client.Player.method_412(0, 0x19);
                              }
                              if (this.class79_0[0, 0x1a] == null)
                              {
                                    this.Client.Player.method_412(0, 0x1a);
                              }
                              if (this.class79_0[0, 0x1b] == null)
                              {
                                    this.Client.Player.method_412(0, 0x1b);
                              }
                        }
                        if ((this.Player_FLD_JOB_LEVEL >= 6) && (this.Player_Job == 8))
                        {
                              if (this.class79_0[0, 0x1f] == null)
                              {
                                    this.Client.Player.method_412(0, 0x1f);
                              }
                              if (this.class79_0[0, 0x20] == null)
                              {
                                    this.Client.Player.method_412(0, 0x20);
                              }
                              if (this.class79_0[0, 0x21] == null)
                              {
                                    this.Client.Player.method_412(0, 0x21);
                              }
                              if (this.class79_0[0, 0x22] == null)
                              {
                                    this.Client.Player.method_412(0, 0x22);
                              }
                              if (this.class79_0[0, 0x23] == null)
                              {
                                    this.Client.Player.method_412(0, 0x23);
                              }
                        }
                        if (this.class79_0[1, 2] != null)
                        {
                              this.NHAN_VAT_KHINH_CONG = 2;
                        }
                        else if (this.class79_0[1, 1] != null)
                        {
                              this.NHAN_VAT_KHINH_CONG = 1;
                        }
                        if (table.Rows[0]["FLD_thang_thien_vo_cong"] != DBNull.Value)
                        {
                              byte[] buffer29 = (byte[])table.Rows[0]["FLD_thang_thien_vo_cong"];
                              for (int k = 0; k < 0x12; k++)
                              {
                                    if (buffer29.Length < ((k * 8) + 8))
                                    {
                                          break;
                                    }
                                    int num28 = BitConverter.ToInt32(buffer29, k * 8);
                                    int num29 = BitConverter.ToInt32(buffer29, (k * 8) + 4);
                                    if (num29 > 10)
                                    {
                                          num29 = 10;
                                    }
                                    TBL_XWWL_KONGFU tbl_xwwl_kongfu2 = new TBL_XWWL_KONGFU(num28)
                                    {
                                          VO_CONG_THU_BAC = num29
                                    };
                                    if ((((tbl_xwwl_kongfu2.FLD_JOB == 0) || (this.Player_Job == tbl_xwwl_kongfu2.FLD_JOB)) && ((tbl_xwwl_kongfu2.FLD_ZX == 0) || (this.Player_Zx == tbl_xwwl_kongfu2.FLD_ZX))) && ((this.Player_FLD_JOB_LEVEL >= tbl_xwwl_kongfu2.FLD_JOBLEVEL) && (this.Player_FLD_LEVEL >= tbl_xwwl_kongfu2.FLD_LEVEL)))
                                    {
                                          this.class79_0[tbl_xwwl_kongfu2.FLD_VO_CONG_LOAI_HINH, tbl_xwwl_kongfu2.FLD_INDEX] = tbl_xwwl_kongfu2;
                                    }
                              }
                        }
                        byte[] buffer10 = (byte[])table.Rows[0]["FLD_QITEM"];
                        int index = 0;
                        while (true)
                        {
                              if (index >= 0x24)
                              {
                                    break;
                              }
                              byte[] buffer30 = new byte[8];
                              if (buffer10.Length >= ((index * 8) + 8))
                              {
                                    try
                                    {
                                          Buffer.BlockCopy(buffer10, index * 8, buffer30, 0, 8);
                                    }
                                    catch (Exception exception2)
                                    {
                                          Console.WriteLine(index + " " + exception2);
                                    }
                              }
                              this.class22_0[index] = new QuestItem_Category(buffer30);
                              index++;
                        }
                        byte[] buffer11 = (byte[])table.Rows[0]["FLD_ITEM"];
                        int num13 = 0;
                        Label_13D9:
                        if (num13 >= 0x42)
                        {
                              goto Label_1A78;
                        }
                        byte[] buffer12 = new byte[0x49];
                        if (buffer11.Length < ((num13 * 0x49) + 0x49))
                        {
                              goto Label_1A30;
                        }
                        try
                        {
                              Buffer.BlockCopy(buffer11, num13 * 0x49, buffer12, 0, 0x49);
                              goto Label_1A30;
                        }
                        catch (Exception exception3)
                        {
                              Console.WriteLine(num13 + " " + exception3);
                              goto Label_1A30;
                        }
                        Label_1432:
                        time = new DateTime(0x7b2, 1, 1, 8, 0, 0);
                        if (DateTime.Now.Subtract(time.AddSeconds((double)num2)).TotalSeconds >= 0.0)
                        {
                              this.GameMessage("Backpack expired items[" + this.TRANG_BI_LAN_BAO_VAY[num13].method_13() + "]The system has been removed!", 9, "System");
                              this.TRANG_BI_LAN_BAO_VAY[num13].Item_byte = new byte[0x49];
                        }
                        Label_14AD:
                        if (World.AllItmelog == 1)
                        {
                              try
                              {
                                    if (((this.TRANG_BI_LAN_BAO_VAY[num13].method_12() == 1) && (this.TRANG_BI_LAN_BAO_VAY[num13].method_12() == 2)) && ((this.TRANG_BI_LAN_BAO_VAY[num13].method_12() == 5) && (this.TRANG_BI_LAN_BAO_VAY[num13].method_12() == 6)))
                                    {
                                          if (((this.TRANG_BI_LAN_BAO_VAY[num13].Thuoc_tinh_1.Prop_Type == 7) || (this.TRANG_BI_LAN_BAO_VAY[num13].Thuoc_tinh_2.Prop_Type == 7)) || ((this.TRANG_BI_LAN_BAO_VAY[num13].Thuoc_tinh_3.Prop_Type == 7) || (this.TRANG_BI_LAN_BAO_VAY[num13].Thuoc_tinh_4.Prop_Type == 7)))
                                          {
                                                Form1.WriteLine(6, string.Concat(new object[] {
                                    "发现WG防VAT_PHAM TRANG_BI_LAN_CHOC_THUNG_TRANG_BI [", this.Userid, "]-[", this.UserName, "] VI_TRI[", num13, "] 编号[", BitConverter.ToInt32(this.TRANG_BI_LAN_BAO_VAY[num13].Item_toan_bo_ID, 0), "] VAT_PHAM名称[", this.TRANG_BI_LAN_BAO_VAY[num13].method_13(), "] VAT_PHAM_SO_LUONG[", BitConverter.ToInt32(this.TRANG_BI_LAN_BAO_VAY[num13].VAT_PHAM_SO_LUONG, 0), "] 属性:[", this.TRANG_BI_LAN_BAO_VAY[num13].FLD_MAGIC0, ",", this.TRANG_BI_LAN_BAO_VAY[num13].FLD_MAGIC1,
                                    ",", this.TRANG_BI_LAN_BAO_VAY[num13].FLD_MAGIC2, ",", this.TRANG_BI_LAN_BAO_VAY[num13].FLD_MAGIC3, ",", this.TRANG_BI_LAN_BAO_VAY[num13].FLD_MAGIC4, "]"
                                }));
                                                this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num13].Item_byte = new byte[0x49];
                                          }
                                    }
                                    else if ((this.TRANG_BI_LAN_BAO_VAY[num13].method_12() == 12) && (((this.TRANG_BI_LAN_BAO_VAY[num13].Thuoc_tinh_1.Prop_Type == 7) || (this.TRANG_BI_LAN_BAO_VAY[num13].Thuoc_tinh_2.Prop_Type == 7)) || ((this.TRANG_BI_LAN_BAO_VAY[num13].Thuoc_tinh_3.Prop_Type == 7) || (this.TRANG_BI_LAN_BAO_VAY[num13].Thuoc_tinh_4.Prop_Type == 7))))
                                    {
                                          Form1.WriteLine(6, string.Concat(new object[] {
                                "发现WG防VAT_PHAM TRANG_BI_LAN_CHOC_THUNG_TRANG_BI [", this.Userid, "]-[", this.UserName, "] VI_TRI[", num13, "] 编号[", BitConverter.ToInt32(this.TRANG_BI_LAN_BAO_VAY[num13].Item_toan_bo_ID, 0), "] VAT_PHAM名称[", this.TRANG_BI_LAN_BAO_VAY[num13].method_13(), "] VAT_PHAM_SO_LUONG[", BitConverter.ToInt32(this.TRANG_BI_LAN_BAO_VAY[num13].VAT_PHAM_SO_LUONG, 0), "] 属性:[", this.TRANG_BI_LAN_BAO_VAY[num13].FLD_MAGIC0, ",", this.TRANG_BI_LAN_BAO_VAY[num13].FLD_MAGIC1,
                                ",", this.TRANG_BI_LAN_BAO_VAY[num13].FLD_MAGIC2, ",", this.TRANG_BI_LAN_BAO_VAY[num13].FLD_MAGIC3, ",", this.TRANG_BI_LAN_BAO_VAY[num13].FLD_MAGIC4, "]"
                            }));
                                          this.TRANG_BI_LAN_BAO_VAY[num13].Item_byte = new byte[0x49];
                                    }
                              }
                              catch (Exception exception4)
                              {
                                    Form1.WriteLine(1, string.Concat(new object[] {
                            "查VAT_PHAM错误    TRANG_BI_LAN_BAO_VAY 错误[", this.Userid, "]-[", this.UserName, "] VI_TRI[", num13, "] 编号[", BitConverter.ToInt32(this.TRANG_BI_LAN_BAO_VAY[num13].Item_toan_bo_ID, 0), "] VAT_PHAM名称[", this.TRANG_BI_LAN_BAO_VAY[num13].method_13(), "] VAT_PHAM_SO_LUONG[", BitConverter.ToInt32(this.TRANG_BI_LAN_BAO_VAY[num13].VAT_PHAM_SO_LUONG, 0), "] 属性:[", this.TRANG_BI_LAN_BAO_VAY[num13].FLD_MAGIC0, ",", this.TRANG_BI_LAN_BAO_VAY[num13].FLD_MAGIC1,
                            ",", this.TRANG_BI_LAN_BAO_VAY[num13].FLD_MAGIC2, ",", this.TRANG_BI_LAN_BAO_VAY[num13].FLD_MAGIC3, ",", this.TRANG_BI_LAN_BAO_VAY[num13].FLD_MAGIC4, "]", exception4
                        }));
                              }
                        }
                        this.int_55 += this.TRANG_BI_LAN_BAO_VAY[num13].VAT_PHAM_TONG_TRONG_LUONG;
                        num13++;
                        goto Label_13D9;
                        Label_1A30:
                        this.TRANG_BI_LAN_BAO_VAY[num13] = new VAT_PHAM_LOAI(buffer12, num13);
                        byte[] buffer13 = new byte[4];
                        Buffer.BlockCopy(this.TRANG_BI_LAN_BAO_VAY[num13].Item_byte, 0x38, buffer13, 0, 4);
                        num2 = BitConverter.ToInt32(buffer13, 0);
                        if (num2 > 0)
                        {
                              goto Label_1432;
                        }
                        goto Label_14AD;
                        Label_1A78:
                        buffer2 = (byte[])table.Rows[0]["FLD_WEARITEM"];
                        int num14 = 0;
                        Label_1A99:
                        if (num14 >= 15)
                        {
                              goto Label_2132;
                        }
                        byte[] buffer14 = new byte[0x49];
                        if (buffer2.Length < ((num14 * 0x49) + 0x49))
                        {
                              goto Label_20D6;
                        }
                        try
                        {
                              Buffer.BlockCopy(buffer2, num14 * 0x49, buffer14, 0, 0x49);
                              goto Label_20D6;
                        }
                        catch (Exception exception5)
                        {
                              Console.WriteLine(num14 + " " + exception5);
                              goto Label_20D6;
                        }
                        Label_1AF2:
                        time = new DateTime(0x7b2, 1, 1, 8, 0, 0);
                        if (DateTime.Now.Subtract(time.AddSeconds((double)num3)).TotalSeconds >= 0.0)
                        {
                              this.GameMessage("Items have wear and equipment bar has expired[" + this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].method_13() + "],The system has been deleted!", 9, "System");
                              this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].Item_byte = new byte[0x49];
                        }
                        Label_1B6E:
                        if (World.AllItmelog == 1)
                        {
                              try
                              {
                                    if (((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].method_12() == 1) && (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].method_12() == 2)) && ((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].method_12() == 5) && (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].method_12() == 6)))
                                    {
                                          if (((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].Thuoc_tinh_1.Prop_Type == 7) || (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].Thuoc_tinh_2.Prop_Type == 7)) || ((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].Thuoc_tinh_3.Prop_Type == 7) || (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].Thuoc_tinh_4.Prop_Type == 7)))
                                          {
                                                Form1.WriteLine(6, string.Concat(new object[] {
                                    "发现WG防VAT_PHAM TRANG_BI_LAN_CHOC_THUNG_TRANG_BI [", this.Userid, "]-[", this.UserName, "] VI_TRI[", num14, "] 编号[", BitConverter.ToInt32(this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].Item_toan_bo_ID, 0), "] VAT_PHAM名称[", this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].method_13(), "] VAT_PHAM_SO_LUONG[", BitConverter.ToInt32(this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].VAT_PHAM_SO_LUONG, 0), "] 属性:[", this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].FLD_MAGIC0, ",", this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].FLD_MAGIC1,
                                    ",", this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].FLD_MAGIC2, ",", this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].FLD_MAGIC3, ",", this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].FLD_MAGIC4, "]"
                                }));
                                                this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].Item_byte = new byte[0x49];
                                          }
                                    }
                                    else if ((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].method_12() == 12) && (((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].Thuoc_tinh_1.Prop_Type == 7) || (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].Thuoc_tinh_2.Prop_Type == 7)) || ((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].Thuoc_tinh_3.Prop_Type == 7) || (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].Thuoc_tinh_4.Prop_Type == 7))))
                                    {
                                          Form1.WriteLine(6, string.Concat(new object[] {
                                "发现WG防VAT_PHAM TRANG_BI_LAN_CHOC_THUNG_TRANG_BI [", this.Userid, "]-[", this.UserName, "] VI_TRI[", num14, "] 编号[", BitConverter.ToInt32(this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].Item_toan_bo_ID, 0), "] VAT_PHAM名称[", this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].method_13(), "] VAT_PHAM_SO_LUONG[", BitConverter.ToInt32(this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].VAT_PHAM_SO_LUONG, 0), "] 属性:[", this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].FLD_MAGIC0, ",", this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].FLD_MAGIC1,
                                ",", this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].FLD_MAGIC2, ",", this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].FLD_MAGIC3, ",", this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].FLD_MAGIC4, "]"
                            }));
                                          this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].Item_byte = new byte[0x49];
                                    }
                              }
                              catch (Exception exception6)
                              {
                                    Form1.WriteLine(1, string.Concat(new object[] {
                            "查VAT_PHAM错误    TRANG_BI_LAN_BAO_VAY 错误 [", this.Userid, "]-[", this.UserName, "] VI_TRI[", num14, "] 编号[", BitConverter.ToInt32(this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].Item_toan_bo_ID, 0), "] VAT_PHAM名称[", this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].method_13(), "] VAT_PHAM_SO_LUONG[", BitConverter.ToInt32(this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].VAT_PHAM_SO_LUONG, 0), "] 属性:[", this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].FLD_MAGIC0, ",", this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].FLD_MAGIC1,
                            ",", this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].FLD_MAGIC2, ",", this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].FLD_MAGIC3, ",", this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].FLD_MAGIC4, "]", exception6
                        }));
                              }
                        }
                        num14++;
                        goto Label_1A99;
                        Label_20D6:
                        this.class23_5[num14] = new VAT_PHAM_LOAI(buffer14, num14);
                        this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14] = new VAT_PHAM_LOAI(buffer14, num14);
                        byte[] buffer15 = new byte[4];
                        Buffer.BlockCopy(this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[num14].Item_byte, 0x38, buffer15, 0, 4);
                        num3 = BitConverter.ToInt32(buffer15, 0);
                        if (num3 > 0)
                        {
                              goto Label_1AF2;
                        }
                        goto Label_1B6E;
                        Label_2132:
                        buffer3 = (byte[])table.Rows[0]["FLD_WEARITEMFZ"];
                        int num15 = 0;
                        Label_2153:
                        if (num15 >= 15)
                        {
                              goto Label_27DA;
                        }
                        byte[] buffer16 = new byte[0x49];
                        if (buffer3.Length < ((num15 * 0x49) + 0x49))
                        {
                              goto Label_2790;
                        }
                        try
                        {
                              Buffer.BlockCopy(buffer3, num15 * 0x49, buffer16, 0, 0x49);
                              goto Label_2790;
                        }
                        catch (Exception exception7)
                        {
                              Console.WriteLine(num15 + " " + exception7);
                              goto Label_2790;
                        }
                        Label_21AC:
                        time = new DateTime(0x7b2, 1, 1, 8, 0, 0);
                        if (DateTime.Now.Subtract(time.AddSeconds((double)num4)).TotalSeconds >= 0.0)
                        {
                              this.GameMessage("Items have wear and equipment bar has expired[" + this.class23_4[num15].method_13() + "],System has been deleted!", 9, "System");
                              this.class23_4[num15].Item_byte = new byte[0x49];
                        }
                        Label_2228:
                        if (World.AllItmelog == 1)
                        {
                              try
                              {
                                    if (((this.class23_4[num15].method_12() == 1) && (this.class23_4[num15].method_12() == 2)) && ((this.class23_4[num15].method_12() == 5) && (this.class23_4[num15].method_12() == 6)))
                                    {
                                          if (((this.class23_4[num15].Thuoc_tinh_1.Prop_Type == 7) || (this.class23_4[num15].Thuoc_tinh_2.Prop_Type == 7)) || ((this.class23_4[num15].Thuoc_tinh_3.Prop_Type == 7) || (this.class23_4[num15].Thuoc_tinh_4.Prop_Type == 7)))
                                          {
                                                Form1.WriteLine(6, string.Concat(new object[] {
                                    "发现WG防VAT_PHAM TRANG_BI_LAN_CHOC_THUNG_TRANG_BI [", this.Userid, "]-[", this.UserName, "] VI_TRI[", num15, "] 编号[", BitConverter.ToInt32(this.class23_4[num15].Item_toan_bo_ID, 0), "] VAT_PHAM名称[", this.class23_4[num15].method_13(), "] VAT_PHAM_SO_LUONG[", BitConverter.ToInt32(this.class23_4[num15].VAT_PHAM_SO_LUONG, 0), "] 属性:[", this.class23_4[num15].FLD_MAGIC0, ",", this.class23_4[num15].FLD_MAGIC1,
                                    ",", this.class23_4[num15].FLD_MAGIC2, ",", this.class23_4[num15].FLD_MAGIC3, ",", this.class23_4[num15].FLD_MAGIC4, "]"
                                }));
                                                this.class23_4[num15].Item_byte = new byte[0x49];
                                          }
                                    }
                                    else if ((this.class23_4[num15].method_12() == 12) && (((this.class23_4[num15].Thuoc_tinh_1.Prop_Type == 7) || (this.class23_4[num15].Thuoc_tinh_2.Prop_Type == 7)) || ((this.class23_4[num15].Thuoc_tinh_3.Prop_Type == 7) || (this.class23_4[num15].Thuoc_tinh_4.Prop_Type == 7))))
                                    {
                                          Form1.WriteLine(6, string.Concat(new object[] {
                                "发现WG防VAT_PHAM TRANG_BI_LAN_CHOC_THUNG_TRANG_BI [", this.Userid, "]-[", this.UserName, "] VI_TRI[", num15, "] 编号[", BitConverter.ToInt32(this.class23_4[num15].Item_toan_bo_ID, 0), "] VAT_PHAM名称[", this.class23_4[num15].method_13(), "] VAT_PHAM_SO_LUONG[", BitConverter.ToInt32(this.class23_4[num15].VAT_PHAM_SO_LUONG, 0), "] 属性:[", this.class23_4[num15].FLD_MAGIC0, ",", this.class23_4[num15].FLD_MAGIC1,
                                ",", this.class23_4[num15].FLD_MAGIC2, ",", this.class23_4[num15].FLD_MAGIC3, ",", this.class23_4[num15].FLD_MAGIC4, "]"
                            }));
                                          this.class23_4[num15].Item_byte = new byte[0x49];
                                    }
                              }
                              catch (Exception exception8)
                              {
                                    Form1.WriteLine(1, string.Concat(new object[] {
                            "查VAT_PHAM错误    TRANG_BI_LAN_BAO_VAY 错误 [", this.Userid, "]-[", this.UserName, "] VI_TRI[", num15, "] 编号[", BitConverter.ToInt32(this.class23_4[num15].Item_toan_bo_ID, 0), "] VAT_PHAM名称[", this.class23_4[num15].method_13(), "] VAT_PHAM_SO_LUONG[", BitConverter.ToInt32(this.class23_4[num15].VAT_PHAM_SO_LUONG, 0), "] 属性:[", this.class23_4[num15].FLD_MAGIC0, ",", this.class23_4[num15].FLD_MAGIC1,
                            ",", this.class23_4[num15].FLD_MAGIC2, ",", this.class23_4[num15].FLD_MAGIC3, ",", this.class23_4[num15].FLD_MAGIC4, "]", exception8
                        }));
                              }
                        }
                        num15++;
                        goto Label_2153;
                        Label_2790:
                        this.class23_4[num15] = new VAT_PHAM_LOAI(buffer16, num15);
                        byte[] buffer17 = new byte[4];
                        Buffer.BlockCopy(this.class23_4[num15].Item_byte, 0x38, buffer17, 0, 4);
                        num4 = BitConverter.ToInt32(buffer17, 0);
                        if (num4 > 0)
                        {
                              goto Label_21AC;
                        }
                        goto Label_2228;
                        Label_27DA: //퀘스트 정보 로드
                        //LoadQuestData(this.Userid, this.NHAN_VAT_VI_TRI);
                        /*
                        buffer4 = (byte[])table.Rows[0]["FLD_QUEST"];
                        Form1.WriteLine(1, "Players READ_CHAR_DATA FLD_QUEST Data: [" + BitConverter.ToString(buffer4).Replace("-", "") + "]");
                        int num16 = 0;
                        while (true)
                        {
                              if (num16 >= 100)
                              {
                                    break;
                              }
                              byte[] buffer31 = new byte[4];
                              try
                              {
                                    if (buffer4.Length < ((num16 * 4) + 4))
                                    {
                                          break;
                                    }
                                    Buffer.BlockCopy(buffer4, num16 * 4, buffer31, 0, 4);
                                    NHIEM_VU_CLASS nhiem_vu_class = new NHIEM_VU_CLASS(buffer31);
                                    if ((nhiem_vu_class.NHIEM_VU_ID != 0) && !this.dictionary_2.ContainsKey(nhiem_vu_class.NHIEM_VU_ID))
                                    {
                                          this.dictionary_2.Add(nhiem_vu_class.NHIEM_VU_ID, nhiem_vu_class);
                                    }
                              }
                              catch (Exception exception21)
                              {
                                    Console.WriteLine(exception21);
                              }
                              num16++;
                        }
                        */
                        DataTable table2 = RxjhClass.SELECT_TBL_XWWL_Warehouse(this.Userid, this.UserName);
                        if ((table2 == null) && (this.Client != null))
                        {
                              this.Client.Dispose();
                        }
                        byte[] buffer18 = (byte[])table2.Rows[0]["FLD_ITEM"];
                        try
                        {
                              this.CA_NHAN_NHA_KHO_TIEN_SO_LUONG = long.Parse(table2.Rows[0]["FLD_MONEY"].ToString());
                        }
                        catch
                        {
                              this.CA_NHAN_NHA_KHO_TIEN_SO_LUONG = 0L;
                        }
                        int num17 = 0;
                        Label_28F0:
                        if (num17 >= 60)
                        {
                              goto Label_2F62;
                        }
                        byte[] buffer19 = new byte[0x49];
                        if (buffer18.Length < ((num17 * 0x49) + 0x49))
                        {
                              goto Label_2F18;
                        }
                        try
                        {
                              Buffer.BlockCopy(buffer18, num17 * 0x49, buffer19, 0, 0x49);
                              goto Label_2F18;
                        }
                        catch (Exception exception22)
                        {
                              Console.WriteLine(exception22);
                              goto Label_2F18;
                        }
                        Label_2934:
                        time = new DateTime(0x7b2, 1, 1, 8, 0, 0);
                        if (DateTime.Now.Subtract(time.AddSeconds((double)num5)).TotalSeconds >= 0.0)
                        {
                              this.GameMessage("Personal warehouse expired items[" + this.class23_0[num17].method_13() + "],System has been deleted!", 9, "System");
                              this.class23_0[num17].Item_byte = new byte[0x49];
                        }
                        Label_29B0:
                        if (World.AllItmelog == 1)
                        {
                              try
                              {
                                    if (((this.class23_0[num17].method_12() == 1) && (this.class23_0[num17].method_12() == 2)) && ((this.class23_0[num17].method_12() == 5) && (this.class23_0[num17].method_12() == 6)))
                                    {
                                          if (((this.class23_0[num17].Thuoc_tinh_1.Prop_Type == 7) || (this.class23_0[num17].Thuoc_tinh_2.Prop_Type == 7)) || ((this.class23_0[num17].Thuoc_tinh_3.Prop_Type == 7) || (this.class23_0[num17].Thuoc_tinh_4.Prop_Type == 7)))
                                          {
                                                Form1.WriteLine(6, string.Concat(new object[] {
                                    "发现WG防VAT_PHAM TRANG_BI_LAN_CHOC_THUNG_TRANG_BI [", this.Userid, "]-[", this.UserName, "] VI_TRI[", num17, "] 编号[", BitConverter.ToInt32(this.class23_0[num17].Item_toan_bo_ID, 0), "] VAT_PHAM名称[", this.class23_0[num17].method_13(), "] VAT_PHAM_SO_LUONG[", BitConverter.ToInt32(this.class23_0[num17].VAT_PHAM_SO_LUONG, 0), "] 属性:[", this.class23_0[num17].FLD_MAGIC0, ",", this.class23_0[num17].FLD_MAGIC1,
                                    ",", this.class23_0[num17].FLD_MAGIC2, ",", this.class23_0[num17].FLD_MAGIC3, ",", this.class23_0[num17].FLD_MAGIC4, "]"
                                }));
                                                this.class23_0[num17].Item_byte = new byte[0x49];
                                          }
                                    }
                                    else if ((this.class23_0[num17].method_12() == 12) && (((this.class23_0[num17].Thuoc_tinh_1.Prop_Type == 7) || (this.class23_0[num17].Thuoc_tinh_2.Prop_Type == 7)) || ((this.class23_0[num17].Thuoc_tinh_3.Prop_Type == 7) || (this.class23_0[num17].Thuoc_tinh_4.Prop_Type == 7))))
                                    {
                                          Form1.WriteLine(6, string.Concat(new object[] {
                                "发现WG防VAT_PHAM TRANG_BI_LAN_CHOC_THUNG_TRANG_BI [", this.Userid, "]-[", this.UserName, "] VI_TRI[", num14, "] 编号[", BitConverter.ToInt32(this.class23_0[num17].Item_toan_bo_ID, 0), "] VAT_PHAM名称[", this.class23_0[num17].method_13(), "] VAT_PHAM_SO_LUONG[", BitConverter.ToInt32(this.class23_0[num17].VAT_PHAM_SO_LUONG, 0), "] 属性:[", this.class23_0[num17].FLD_MAGIC0, ",", this.class23_0[num17].FLD_MAGIC1,
                                ",", this.class23_0[num17].FLD_MAGIC2, ",", this.class23_0[num17].FLD_MAGIC3, ",", this.class23_0[num17].FLD_MAGIC4, "]"
                            }));
                                          this.class23_0[num17].Item_byte = new byte[0x49];
                                    }
                              }
                              catch (Exception exception9)
                              {
                                    Form1.WriteLine(1, string.Concat(new object[] {
                            "查VAT_PHAM错误    个人仓库 错误  [", this.Userid, "]-[", this.UserName, "] VI_TRI[", num17, "] 编号[", BitConverter.ToInt32(this.class23_0[num17].Item_toan_bo_ID, 0), "] VAT_PHAM名称[", this.class23_0[num17].method_13(), "] VAT_PHAM_SO_LUONG[", BitConverter.ToInt32(this.class23_0[num17].VAT_PHAM_SO_LUONG, 0), "] 属性:[", this.class23_0[num17].FLD_MAGIC0, ",", this.class23_0[num17].FLD_MAGIC1,
                            ",", this.class23_0[num17].FLD_MAGIC2, ",", this.class23_0[num17].FLD_MAGIC3, ",", this.class23_0[num17].FLD_MAGIC4, "]", exception9
                        }));
                              }
                        }
                        num17++;
                        goto Label_28F0;
                        Label_2F18:
                        this.class23_0[num17] = new VAT_PHAM_LOAI(buffer19, num17);
                        byte[] buffer20 = new byte[4];
                        Buffer.BlockCopy(this.class23_0[num17].Item_byte, 0x38, buffer20, 0, 4);
                        num5 = BitConverter.ToInt32(buffer20, 0);
                        if (num5 > 0)
                        {
                              goto Label_2934;
                        }
                        goto Label_29B0;
                        Label_2F62:
                        table2.Dispose();
                        DataTable table3 = RxjhClass.SELECT_TBL_XWWL_PublicWarehouse(this.Userid);
                        if ((table3 == null) && (this.Client != null))
                        {
                              this.Client.Dispose();
                        }
                        byte[] buffer21 = (byte[])table3.Rows[0]["FLD_ITEM"];
                        this.int_3 = (int)table3.Rows[0]["FLD_ZBVER"];
                        try
                        {
                              this.TONG_HOP_NHA_KHO_TIEN_SO = long.Parse(table3.Rows[0]["FLD_MONEY"].ToString());
                        }
                        catch
                        {
                              this.TONG_HOP_NHA_KHO_TIEN_SO = 0L;
                        }
                        int num18 = 0;
                        Label_3004:
                        if (num18 >= 60)
                        {
                              goto Label_3676;
                        }
                        byte[] buffer22 = new byte[0x49];
                        if (buffer21.Length < ((num18 * 0x49) + 0x49))
                        {
                              goto Label_362C;
                        }
                        try
                        {
                              Buffer.BlockCopy(buffer21, num18 * 0x49, buffer22, 0, 0x49);
                              goto Label_362C;
                        }
                        catch (Exception exception24)
                        {
                              Console.WriteLine(exception24);
                              goto Label_362C;
                        }
                        Label_3048:
                        time = new DateTime(0x7b2, 1, 1, 8, 0, 0);
                        if (DateTime.Now.Subtract(time.AddSeconds((double)num6)).TotalSeconds >= 0.0)
                        {
                              this.GameMessage("Public warehouse goods expired[" + this.class23_1[num18].method_13() + "],System has been deleted!", 9, "System");
                              this.class23_1[num18].Item_byte = new byte[0x49];
                        }
                        Label_30C4:
                        if (World.AllItmelog == 1)
                        {
                              try
                              {
                                    if (((this.class23_1[num18].method_12() == 1) && (this.class23_1[num18].method_12() == 2)) && ((this.class23_1[num18].method_12() == 5) && (this.class23_1[num18].method_12() == 6)))
                                    {
                                          if (((this.class23_1[num18].Thuoc_tinh_1.Prop_Type == 7) || (this.class23_1[num18].Thuoc_tinh_2.Prop_Type == 7)) || ((this.class23_1[num18].Thuoc_tinh_3.Prop_Type == 7) || (this.class23_1[num18].Thuoc_tinh_4.Prop_Type == 7)))
                                          {
                                                Form1.WriteLine(6, string.Concat(new object[] {
                                    "发现WG防VAT_PHAM TRANG_BI_LAN_CHOC_THUNG_TRANG_BI [", this.Userid, "]-[", this.UserName, "] VI_TRI[", num18, "] 编号[", BitConverter.ToInt32(this.class23_1[num18].Item_toan_bo_ID, 0), "] VAT_PHAM名称[", this.class23_1[num18].method_13(), "] VAT_PHAM_SO_LUONG[", BitConverter.ToInt32(this.class23_1[num18].VAT_PHAM_SO_LUONG, 0), "] 属性:[", this.class23_1[num18].FLD_MAGIC0, ",", this.class23_1[num18].FLD_MAGIC1,
                                    ",", this.class23_1[num18].FLD_MAGIC2, ",", this.class23_1[num18].FLD_MAGIC3, ",", this.class23_1[num18].FLD_MAGIC4, "]"
                                }));
                                                this.class23_1[num18].Item_byte = new byte[0x49];
                                          }
                                    }
                                    else if ((this.class23_1[num18].method_12() == 12) && (((this.class23_1[num18].Thuoc_tinh_1.Prop_Type == 7) || (this.class23_1[num18].Thuoc_tinh_2.Prop_Type == 7)) || ((this.class23_1[num18].Thuoc_tinh_3.Prop_Type == 7) || (this.class23_1[num18].Thuoc_tinh_4.Prop_Type == 7))))
                                    {
                                          Form1.WriteLine(6, string.Concat(new object[] {
                                "发现WG防VAT_PHAM TRANG_BI_LAN_CHOC_THUNG_TRANG_BI [", this.Userid, "]-[", this.UserName, "] VI_TRI[", num18, "] 编号[", BitConverter.ToInt32(this.class23_1[num18].Item_toan_bo_ID, 0), "] VAT_PHAM名称[", this.class23_1[num18].method_13(), "] VAT_PHAM_SO_LUONG[", BitConverter.ToInt32(this.class23_1[num18].VAT_PHAM_SO_LUONG, 0), "] 属性:[", this.class23_1[num18].FLD_MAGIC0, ",", this.class23_1[num18].FLD_MAGIC1,
                                ",", this.class23_1[num18].FLD_MAGIC2, ",", this.class23_1[num18].FLD_MAGIC3, ",", this.class23_1[num14].FLD_MAGIC4, "]"
                            }));
                                          this.class23_1[num18].Item_byte = new byte[0x49];
                                    }
                              }
                              catch (Exception exception10)
                              {
                                    Form1.WriteLine(1, string.Concat(new object[] {
                            "查VAT_PHAM错误    个人仓库 错误 [", this.Userid, "]-[", this.UserName, "] VI_TRI[", num18, "] 编号[", BitConverter.ToInt32(this.class23_1[num18].Item_toan_bo_ID, 0), "] VAT_PHAM名称[", this.class23_1[num18].method_13(), "] VAT_PHAM_SO_LUONG[", BitConverter.ToInt32(this.class23_1[num18].VAT_PHAM_SO_LUONG, 0), "] 属性:[", this.class23_1[num18].FLD_MAGIC0, ",", this.class23_1[num18].FLD_MAGIC1,
                            ",", this.class23_1[num18].FLD_MAGIC2, ",", this.class23_1[num18].FLD_MAGIC3, ",", this.class23_1[num18].FLD_MAGIC4, "]", exception10
                        }));
                              }
                        }
                        num18++;
                        goto Label_3004;
                        Label_362C:
                        this.class23_1[num18] = new VAT_PHAM_LOAI(buffer22, num18);
                        byte[] buffer23 = new byte[4];
                        Buffer.BlockCopy(this.class23_1[num18].Item_byte, 0x38, buffer23, 0, 4);
                        num6 = BitConverter.ToInt32(buffer23, 0);
                        if (num6 > 0)
                        {
                              goto Label_3048;
                        }
                        goto Label_30C4;
                        Label_3676:
                        table3.Dispose();
                        this.byte_0 = null;
                        if (!table.Rows[0]["FLD_CTIME"].Equals(null))
                        {
                              this.byte_0 = (byte[])table.Rows[0]["FLD_CTIME"];
                        }
                        if (!table.Rows[0]["FLD_CTIMENEW"].Equals(null))
                        {
                              this.byte_1 = (byte[])table.Rows[0]["FLD_CTIMENEW"];
                        }
                        byte[] buffer24 = new byte[0x10];
                        Buffer.BlockCopy((byte[])table3.Rows[0]["FLD_ITIME"], 0, buffer24, 0, 0x10);
                        int num19 = 0;
                        while (true)
                        {
                              if (num19 >= 2)
                              {
                                    break;
                              }
                              try
                              {
                                    byte[] buffer32 = new byte[4];
                                    byte[] buffer33 = new byte[4];
                                    Buffer.BlockCopy(buffer24, num19 * 8, buffer32, 0, 4);
                                    Buffer.BlockCopy(buffer24, (num19 * 8) + 4, buffer33, 0, 4);
                                    DateTime time3 = new DateTime(0x7b2, 1, 1, 8, 0, 0);
                                    time3 = time3.AddSeconds((double)BitConverter.ToInt32(buffer33, 0));
                                    if ((time3 < DateTime.Now) || (BitConverter.ToInt32(buffer32, 0) <= 0))
                                    {
                                          break;
                                    }
                                    if (!this.dictionary_3.ContainsKey(BitConverter.ToInt32(buffer32, 0)))
                                    {
                                          PUBLIC_DUOC_PHAM_LOAI public_duoc_pham_loai = new PUBLIC_DUOC_PHAM_LOAI
                                          {
                                                DUOC_PHAM_ID = BitConverter.ToInt32(buffer32, 0),
                                                THOI_GIAN = BitConverter.ToInt32(buffer33, 0)
                                          };
                                          this.dictionary_3.Add(public_duoc_pham_loai.DUOC_PHAM_ID, public_duoc_pham_loai);
                                    }
                              }
                              catch (Exception exception26)
                              {
                                    Console.WriteLine(exception26);
                              }
                              num19++;
                        }
                        byte[] buffer25 = null;
                        if (table.Rows[0]["FLD_DOORS"] != null)
                        {
                              buffer25 = (byte[])table.Rows[0]["FLD_DOORS"];
                        }
                        this.hashtable_0.Clear();
                        if (buffer25.Length >= 0x80)
                        {
                              for (int m = 0; m < 30; m++)
                              {
                                    try
                                    {
                                          byte[] buffer34 = new byte[4];
                                          byte[] buffer35 = new byte[4];
                                          byte[] buffer36 = new byte[4];
                                          byte[] buffer37 = new byte[4];
                                          byte[] buffer38 = new byte[14];
                                          Buffer.BlockCopy(buffer25, (m * 0x20) + 15, buffer37, 0, 4);
                                          Buffer.BlockCopy(buffer25, (m * 0x20) + 0x13, buffer34, 0, 4);
                                          Buffer.BlockCopy(buffer25, (m * 0x20) + 0x17, buffer35, 0, 4);
                                          Buffer.BlockCopy(buffer25, (m * 0x20) + 0x1b, buffer36, 0, 4);
                                          Buffer.BlockCopy(buffer25, m * 0x20, buffer38, 0, 14);
                                          string str3 = Encoding.Default.GetString(buffer38);
                                          if (((BitConverter.ToSingle(buffer34, 0) != 0f) || (BitConverter.ToSingle(buffer35, 0) != 0f)) || (BitConverter.ToInt32(buffer37, 0) != 0))
                                          {
                                                TBL_XWWL_MAP tbl_xwwl_map = new TBL_XWWL_MAP(BitConverter.ToSingle(buffer34, 0), BitConverter.ToSingle(buffer35, 0), BitConverter.ToSingle(buffer36, 0), BitConverter.ToInt32(buffer37, 0))
                                                {
                                                      Rxjh_name = str3
                                                };
                                                if (this.hashtable_0.ContainsKey(10 + m))
                                                {
                                                      this.hashtable_0.Remove(10 + m);
                                                }
                                                this.hashtable_0.Add(10 + m, tbl_xwwl_map);
                                          }
                                    }
                                    catch (Exception)
                                    {
                                    }
                              }
                        }
                        DataTable table4 = RxjhClass.EXE_LOAD_GUILD(this.UserName);
                        if (table4 != null)
                        {
                              this.Bang_phai_Id = (int)table4.Rows[0]["Id"];
                              this.GuildName = table4.Rows[0]["G_Name"].ToString();
                              this.Bang_phai_nhan_vat_thu_bac = (int)table4.Rows[0]["leve"];
                              this.BANG_PHAI_TRANG_PHUC_KI_TU = (int)table4.Rows[0]["Mon_trang_phuc_tu"];
                              this.BANG_PHAI_MON_PHUC_MAU_SAC = (int)table4.Rows[0]["Mon_trang_phuc_mau_sac"];
                              try
                              {
                                    if (table4.Rows[0]["Mh"] != DBNull.Value)
                                    {
                                          this.Bang_phai_mon_huy = (byte[])table4.Rows[0]["Mh"];
                                    }
                              }
                              catch (Exception exception28)
                              {
                                    Console.WriteLine(exception28);
                              }
                              table4.Dispose();
                        }
                        this.BasicCharacterData();
                        table.Dispose();
                        this.int_2 = 1;
                        this.int_3 = 1;
                  }
                  catch (Exception exception11)
                  {
                        Form1.WriteLine(2, "读出人物数据出错 " + this.Userid + "  " + exception11.Message);
                        this.Client.Dispose();
                  }
            }

            public void Reinforced_Announce(int int_116, string string_10, int int_117, int int_118)
            {
                  try
                  {
                        TBL_XWWL_ITEM tbl_xwwl_item = new TBL_XWWL_ITEM();
                        tbl_xwwl_item = TBL_XWWL_ITEM.smethod_3(int_116);
                        if ((tbl_xwwl_item == null) || (tbl_xwwl_item.FLD_LEVEL >= 100))
                        {
                              byte[] dst = Converter.hexStringToByte("AA555F0001150300505000010000000200000000000000090000007117000016A50700000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000020000000000000064FE55AA");
                              Buffer.BlockCopy(BitConverter.GetBytes(int_117), 0, dst, 0x17, 1);
                              Buffer.BlockCopy(BitConverter.GetBytes(int_116), 0, dst, 0x1f, 4);
                              byte[] bytes = Encoding.Default.GetBytes(string_10);
                              Buffer.BlockCopy(bytes, 0, dst, 0x27, bytes.Length);
                              Buffer.BlockCopy(BitConverter.GetBytes(this.UserSessionID), 0, dst, 5, 2);
                              Buffer.BlockCopy(BitConverter.GetBytes(int_118), 0, dst, 0x59, 1);
                              if (this.Client != null)
                              {
                                    this.Client.Send(dst, dst.Length);
                              }
                        }
                  }
                  catch
                  {
                  }
            }

            //캐릭터 정보 저장
            public void Save_Char_data_Stored()
            {
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "PlayersBes_保存人物数据存储过程()");
                  }
                  try
                  {
                        SqlParameter[] parameterArray = new SqlParameter[] {
                    SqlDBA.MakeInParam("@id", SqlDbType.VarChar, 20, this.Userid), SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 20, this.UserName), SqlDBA.MakeInParam("@level", SqlDbType.Int, 0, this.Player_FLD_LEVEL), SqlDBA.MakeInParam("@strFace", SqlDbType.VarBinary, 10, this.class84_0.byte_0), SqlDBA.MakeInParam("@job", SqlDbType.Int, 0, this.Player_Job), SqlDBA.MakeInParam("@exp", SqlDbType.VarChar, 50, this.NHAN_VAT_KINH_NGHIEM), SqlDBA.MakeInParam("@zx", SqlDbType.Int, 0, this.Player_Zx), SqlDBA.MakeInParam("@job_level", SqlDbType.Int, 0, this.Player_FLD_JOB_LEVEL), SqlDBA.MakeInParam("@x", SqlDbType.Float, 0, this.CharacterCoords_X), SqlDBA.MakeInParam("@y", SqlDbType.Float, 0, this.CharacterCoords_Y), SqlDBA.MakeInParam("@z", SqlDbType.Float, 0, this.CharacterCoords_Z), SqlDBA.MakeInParam("@menow", SqlDbType.Int, 0, this.CharacterCoords_Map), SqlDBA.MakeInParam("@money", SqlDbType.VarChar, 0, this.Player_Money), SqlDBA.MakeInParam("@hp", SqlDbType.Int, 0, this.NHAN_VAT_HP), SqlDBA.MakeInParam("@mp", SqlDbType.Int, 0, this.NHAN_VAT_MP), SqlDBA.MakeInParam("@sp", SqlDbType.Int, 0, this.NHAN_VAT_SP),
                    SqlDBA.MakeInParam("@wx", SqlDbType.Int, 0, this.Player_WuXun), SqlDBA.MakeInParam("@se", SqlDbType.Int, 0, this.NHAN_VAT_THIEN_AC), SqlDBA.MakeInParam("@point", SqlDbType.VarChar, 0, this.Player_Qigong_point), SqlDBA.MakeInParam("@strSkills", SqlDbType.VarBinary, 20, this.GetWgCodesbyte()), SqlDBA.MakeInParam("@strWearitem", SqlDbType.VarBinary, 0x447, this.GetWEARITEMCodesbyte()), SqlDBA.MakeInParam("@strWearitemfz", SqlDbType.VarBinary, 0x447, this.GetWEARITEMFZCodesbyte()), SqlDBA.MakeInParam("@strItem", SqlDbType.VarBinary, 0x12d2, this.GetFLD_ITEMCodesbyte()), SqlDBA.MakeInParam("@strQusetItem", SqlDbType.VarBinary, 300, this.GetQuestITEMCodesbyte()), SqlDBA.MakeInParam("@strKongfu", SqlDbType.VarBinary, 0x57c, this.GetFLD_KONGFUCodesbyte()), SqlDBA.MakeInParam("@strCtime", SqlDbType.VarBinary, 320, this.GET_CA_NHAN_DUOC_PHAM_BYTE()), SqlDBA.MakeInParam("@strDoors", SqlDbType.VarBinary, 0x4b0, this.Get_THO_LINH_PHU_byte()), SqlDBA.MakeInParam("@strQuest", SqlDbType.VarBinary, 400, this.GET_NHIEM_VU_BYTE()), SqlDBA.MakeInParam("@fight_exp", SqlDbType.Int, 0, this.Player_ExpErience), SqlDBA.MakeInParam("@rwqg", SqlDbType.Int, 0, this.NHAN_VAT_KHINH_CONG), SqlDBA.MakeInParam("@NameType", SqlDbType.VarBinary, 0x30, this.NHAN_VAT_TEN_MAU), SqlDBA.MakeInParam("@zbver", SqlDbType.Int, 0, this.int_2),
                    SqlDBA.MakeInParam("@zzlx", SqlDbType.Int, 0, this.FLD_CHE_TAO_LOAI_HINH), SqlDBA.MakeInParam("@zzsld", SqlDbType.Int, 0, this.FLD_CHE_TAO_DO_THUAN_THUC), SqlDBA.MakeInParam("@strCtimeNew", SqlDbType.VarBinary, 240, this.GET_CA_NHAN_DUOC_PHAM_NEW_BYTE()), SqlDBA.MakeInParam("@qlname", SqlDbType.VarChar, 0, this.FLD_TINH_NHAN), SqlDBA.MakeInParam("@qljzname", SqlDbType.VarChar, 0, this.FLD_TINH_NHAN_NHAN_CUOI), SqlDBA.MakeInParam("@qlaqd", SqlDbType.Int, 50, this.FLD_TINH_NHAN_CAP_DO_YEU), SqlDBA.MakeInParam("@strStSkills", SqlDbType.VarBinary, 0x40, this.GetTHANG_THIEN_KHI_CONG_Codesbyte()), SqlDBA.MakeInParam("@strStKongfu", SqlDbType.VarBinary, 0x60, this.GetTHANG_THIEN_VO_CONG_Codesbyte()), SqlDBA.MakeInParam("@stlilian", SqlDbType.Int, 0, this.int_14), SqlDBA.MakeInParam("@stwugongdian", SqlDbType.Int, 0, this.int_15), SqlDBA.MakeInParam("@addhp", SqlDbType.Int, 0, this.Khen_thuong_them_vao_sinh_menh), SqlDBA.MakeInParam("@addat", SqlDbType.VarChar, 0, this.Khen_thuong_them_vao_cong_kich), SqlDBA.MakeInParam("@adddf", SqlDbType.VarChar, 0, this.Khen_thuong_them_vao_phong_ngu), SqlDBA.MakeInParam("@addhb", SqlDbType.Int, 0, this.Khen_thuong_them_vao_ne_tranh), SqlDBA.MakeInParam("@addmp", SqlDbType.Int, 0, this.Khen_thuong_them_vao_noi_cong), SqlDBA.MakeInParam("@addmz", SqlDbType.Int, 0, this.Khen_thuong_them_vao_trung_muc_tieu),
                    SqlDBA.MakeInParam("@getwx", SqlDbType.Int, 0, this.Player_MaxWx), SqlDBA.MakeInParam("@zs", SqlDbType.Int, 0, this.Chuyen_sinh_so_lan), SqlDBA.MakeInParam("@bscs", SqlDbType.BigInt, 0, this.BI_GIET_SO_LAN), SqlDBA.MakeInParam("@srcs", SqlDbType.BigInt, 0, this.GIET_NGUOI_SO_LAN), SqlDBA.MakeInParam("@getvipdj", SqlDbType.BigInt, 0, this.Thanh_vien_thu_bac), SqlDBA.MakeInParam("@Wxsj", SqlDbType.SmallDateTime, 0, this.VO_HUAN_CAP_8_DOAN_THOI_GIAN), SqlDBA.MakeInParam("@Wxsfkq", SqlDbType.Int, 0, this.VO_HUAN_CAP_8_CO_HAY_KHONG_MO_RA), SqlDBA.MakeInParam("@Truc_tuyen_thoi_gian", SqlDbType.VarBinary, 200, this.GET_THOI_GIAN_TRUC_TUYEN())
                };
                        DbPool_Class class2 = new DbPool_Class
                        {
                              Conn = DBA.smethod_3(null),
                              Prams = parameterArray,
                              Sql = "XWWL_UPDATE_USER_DATA_NEW"
                        };
                        World.queue_1.Enqueue(class2);
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "保存人物数据出错[" + this.Userid + "]-[" + this.UserName + "]" + exception.Message);
                  }
            }

            public void SendCountdown(int int_116, int int_117, int int_118)
            {
                  using (PacketData data = new PacketData())
                  {
                        data.Write4(int_117);
                        data.Write2(1);
                        if (int_116 == 14)
                        {
                              data.Write2(70);
                        }
                        else if ((int_116 == 3) && (int_118 == 11))
                        {
                              data.Write2(int_118);
                        }
                        else
                        {
                              data.Write2(70);
                        }
                        data.Write4(0);
                        if ((int_116 == 1) && (int_118 == 2))
                        {
                              data.Write4(2);
                        }
                        else if ((int_116 == 1) && (int_118 != 2))
                        {
                              data.Write4(1);
                        }
                        else
                        {
                              data.Write4(int_116);
                        }
                        if ((int_116 == 3) && (int_118 == 11))
                        {
                              data.Write4(World.THE_LUC_CHIEN_2_CHINH_PHAI_DIEM_SO);
                              data.Write4(World.THE_LUC_CHIEN_2_TA_PHAI_DIEM_SO);
                              data.Write4(World.THE_LUC_CHIEN_2_CHINH_PHAI_SO_NGUOI);
                              data.Write4(World.THE_LUC_CHIEN_TA_PHAI_SO_NGUOI);
                        }
                        else if ((int_116 == 1) && (int_118 == 2))
                        {
                              data.Write4(8);
                              data.Write4(8);
                              data.Write4(0xe34);
                              data.Write4(0);
                        }
                        else if ((int_116 == 1) && (int_118 != 2))
                        {
                              data.Write4(8);
                              data.Write4(8);
                              data.Write4(0xe33);
                              data.Write4(0);
                        }
                        else
                        {
                              data.Write4(int_118);
                              data.Write4(0);
                              data.Write4(0);
                              data.Write4(0);
                        }
                        data.Write4(0);
                        data.Write2(0);
                        if (this.Client != null)
                        {
                              this.Client.method_5(data, 0x1322, this.UserSessionID, 0);
                        }
                  }
            }

            public void SendCountdown2(int kssjint)
            {
                  try
                  {
                        byte[] dst = Converter.hexStringToByte("AA552F00010F2713222000090001000B000000010000000C0000002101000000000000000000000000000000000000000002EE55AA");
                        Buffer.BlockCopy(BitConverter.GetBytes(kssjint), 0, dst, 0x1b, 2);
                        Buffer.BlockCopy(BitConverter.GetBytes(this.UserSessionID), 0, dst, 5, 2);
                        if (this.Client != null)
                        {
                              this.Client.Send(dst, dst.Length);
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "发送势力战开始倒计时出错" + exception.Message);
                  }
            }

            public void Show_Char(int int_116, int int_117)
            {
                  try
                  {
                        using (PacketData data = new PacketData())
                        {
                              data.Write4(int_116);
                              data.Write4(int_117);
                              data.Write4(0);
                              if (this.Client != null)
                              {
                                    this.Client.method_5(data, 0x8900, this.UserSessionID, 1);
                                    this.vmethod_2(data, 0x8900, this.UserSessionID, 1);
                              }
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "xsz出错!" + exception.Message);
                  }
            }

            public void sjts()
            {
                  byte[] dst = Converter.hexStringToByte("AA552F00010F2713222000020001000A000000010000000E00000001000000010000000000000000000000000000000000604C55AA");
                  Buffer.BlockCopy(BitConverter.GetBytes(this.UserSessionID), 0, dst, 5, 2);
                  if (this.Client != null)
                  {
                        this.Client.Send(dst, dst.Length);
                  }
            }

            public void System_Announcement(string string_10)
            {
                  Class53 class2;
                  if (World.dictionary_28.TryGetValue(string_10, out class2))
                  {
                        string_10 = class2.string_1;
                  }
                  byte[] dst = Converter.hexStringToByte("AA55A600000F2766009700082020202020302020202020203130202020202020304DB1BE000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000055AA");
                  byte[] bytes = Encoding.Default.GetBytes(string_10);
                  Buffer.BlockCopy(bytes, 0, dst, 0x23, bytes.Length);
                  if (this.Client != null)
                  {
                        this.Client.Send(dst, dst.Length);
                  }
            }

            public void SystemScrollingMsg(string string_10)
            {
                  Class53 class2;
                  if (World.dictionary_28.TryGetValue(string_10, out class2))
                  {
                        string_10 = class2.string_1;
                  }
                  byte[] dst = Converter.hexStringToByte("AA554E00000F27B018480001000000941100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000055AA");
                  byte[] bytes = Encoding.Default.GetBytes(string_10);
                  Buffer.BlockCopy(bytes, 0, dst, 15, bytes.Length);
                  if (this.Client != null)
                  {
                        this.Client.method_8(dst, dst.Length);
                  }
            }

            public void THAY_DOI_TRANG_BI_VI_TRI(int int_116, int int_117, int int_118, int int_119, byte[] byte_5, int int_120)
            {
                  try
                  {
                        byte[] dst = Converter.hexStringToByte("AA557B00012C011B006C00010000003B043C05000000000000000000000000000000000000000000000000000000003C053B046401000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000055AA");
                        byte[] bytes = BitConverter.GetBytes(int_117);
                        byte[] src = BitConverter.GetBytes(int_118);
                        byte[] buffer4 = BitConverter.GetBytes(int_119);
                        byte[] buffer1 = BitConverter.GetBytes(int_116);
                        Buffer.BlockCopy(buffer1, 0, dst, 15, 1);
                        Buffer.BlockCopy(bytes, 0, dst, 0x10, 1);
                        Buffer.BlockCopy(src, 0, dst, 0x11, 1);
                        Buffer.BlockCopy(buffer4, 0, dst, 0x12, 1);
                        Buffer.BlockCopy(BitConverter.GetBytes(int_120), 0, dst, 0x13, 2);
                        Buffer.BlockCopy(byte_5, 0, dst, 0x17, 0x10);
                        Buffer.BlockCopy(BitConverter.GetBytes(int_120), 0, dst, 0x27, 2);
                        Buffer.BlockCopy(buffer1, 0, dst, 0x31, 1);
                        Buffer.BlockCopy(bytes, 0, dst, 50, 1);
                        Buffer.BlockCopy(src, 0, dst, 0x2f, 1);
                        Buffer.BlockCopy(buffer4, 0, dst, 0x30, 1);
                        Buffer.BlockCopy(BitConverter.GetBytes(this.UserSessionID), 0, dst, 5, 2);
                        if (this.Client != null)
                        {
                              this.Client.Send(dst, dst.Length);
                        }
                  }
                  catch
                  {
                  }
            }

            public void THEM_ITEM_3(byte[] byte_5, byte[] byte_6, int int_116, byte[] byte_7, byte[] byte_8)
            {
                  try
                  {
                        TBL_XWWL_ITEM tbl_xwwl_item;
                        if (World.Itme.TryGetValue(BitConverter.ToInt32(byte_6, 0), out tbl_xwwl_item))
                        {
                              byte[] dst = Converter.hexStringToByte("AA556B0001940223005C00010000008716E567818320060208AF2F000000000100000000000000010F020F00020000470D030000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000C3E755AA");
                              byte[] buffer2 = new byte[0x49];
                              if (tbl_xwwl_item.FLD_SIDE != 0)
                              {
                                    VAT_PHAM_LOAI vat_pham_loai = this.NHAN_NHAN_VAT_ITEM_LOAI_HINH(BitConverter.ToInt32(byte_6, 0));
                                    if (vat_pham_loai != null)
                                    {
                                          int_116 = vat_pham_loai.VAT_PHAM_VI_TRI;
                                          byte_5 = vat_pham_loai.Item_toan_bo_ID;
                                          byte_7 = BitConverter.GetBytes((int)(BitConverter.ToInt32(vat_pham_loai.VAT_PHAM_SO_LUONG, 0) + BitConverter.ToInt32(byte_7, 0)));
                                    }
                              }
                              else
                              {
                                    byte_7 = BitConverter.GetBytes(1);
                              }
                              Buffer.BlockCopy(byte_5, 0, buffer2, 0, 8);
                              Buffer.BlockCopy(byte_6, 0, buffer2, 8, 4);
                              Buffer.BlockCopy(byte_7, 0, buffer2, 12, 4);
                              Buffer.BlockCopy(byte_8, 0, buffer2, 0x10, byte_8.Length);
                              Buffer.BlockCopy(BitConverter.GetBytes(int_116), 0, dst, 40, 2);
                              Buffer.BlockCopy(buffer2, 0, dst, 15, 12);
                              Buffer.BlockCopy(buffer2, 12, dst, 0x1f, 4);
                              Buffer.BlockCopy(buffer2, 0x10, dst, 0x2f, byte_8.Length);
                              this.TRANG_BI_LAN_BAO_VAY[int_116].Item_byte = buffer2;
                              Buffer.BlockCopy(BitConverter.GetBytes(this.UserSessionID), 0, dst, 5, 2);
                              if (this.Client != null)
                              {
                                    this.Client.Send(dst, dst.Length);
                              }
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, string.Concat(new object[] { "TANG_CUONG_VAT_PHAM出错2 [", this.Userid, "][", this.UserName, "] VI_TRI[", int_116, "] 数量[", BitConverter.ToInt32(byte_7, 0), "]", exception.Message }));
                  }
            }

            public void THIET_LAP_TI_LE_MAC_DINH()
            {
                  this.int_17 = 0;
                  this.double_113 = 0.0;
                  this.int_7 = 0;
                  this.Bow_quan_cong_skill_ID = 0;
                  this.Equipmen_bags_whether_to_open = 0;
                  this.int_2 = 1;
                  this.int_3 = 1;
                  this.dateTime_0 = DateTime.Now;
                  this.dateTime_1 = DateTime.Now;
                  this.dateTime_2 = DateTime.Now;
                  this.dateTime_3 = DateTime.Now;
                  this.dictionary_1.Clear();
                  this.THANG_THIEN_KHI_CONG.Clear();
                  this.class79_0 = new TBL_XWWL_KONGFU[4, 0x26];
                  this.dictionary_3 = new Dictionary<int, PUBLIC_DUOC_PHAM_LOAI>();
                  this.dictionary_2 = new Dictionary<int, NHIEM_VU_CLASS>();
                  this.byte_2 = new byte[200];
                  this.Exiting = false;
                  this.bool_0 = false;
                  this.bool_6 = false;
                  this.bool_7 = false;
                  this.bool_8 = false;
                  this.bool_9 = false;
                  this.Phu_the_vo_cong_luc_cong_kich = 0;
                  this.Phu_the_vo_cong_luc_cong_kich_MP = 0;
                  this.Nhan_vat_them_vao_lon_nhat_HP = 0;
                  this.Nhan_vat_them_vao_lon_nhat_MP = 0;
                  this.Nhan_vat_co_ban_lon_nhat_HP = 0;
                  this.FLD_trang_bi_them_vao_HP = 0;
                  this.Nhan_vat_khi_cong_them_vao_HP = 0;
                  this.Nhan_vat_co_ban_lon_nhat_MP = 0;
                  this.FLD_trang_bi_them_vao_MP = 0;
                  this.Nhan_vat_khi_cong_them_vao_MP = 0;
                  this.Bang_phai_mon_huy = null;
                  this.Bang_phai_nhan_vat_thu_bac = 0;
                  this.GuildName = string.Empty;
                  this.Bang_phai_Id = 0;
                  this.Evil_mode = 0;
                  this.FLD_them_vao_ti_le_phan_tram_cong_kich = 0.0M;
                  this.FLD_them_vao_ti_le_phan_tram_phong_ngu = 0.0M;
                  this.FLD_them_vao_ti_le_phan_tram_sinh_menh = 0.0;
                  this.FLD_them_vao_ti_le_phan_tram_ne_tranh = 0.0;
                  this.FLD_them_vao_ti_le_phan_tram_HP_han_muc_toi_da = 0.0;
                  this.FLD_them_vao_ti_le_phan_tram_MP_han_muc_toi_da = 0.0;
                  this.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram = 0.0;
                  this.FLD_nhan_vat_vo_cong_suc_phong_ngu_tang_cuong_ti_le_phan_tram = 0.0;
                  this.FLD_nhan_vat_them_vao_cong_kich = 0;
                  this.FLD_nhan_vat_them_vao_phong_ngu = 0;
                  this.FLD_nhan_vat_them_vao_sinh_menh = 0;
                  this.FLD_nhan_vat_them_vao_ne_tranh = 0;
                  this.FLD_nhan_vat_them_vao_khi_cong = 0;
                  this.FLD_nhan_vat_them_vao_hop_thanh_ty_le_thanh_cong_ti_le_phan_tram = 0.0;
                  this.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram = 0.0;
                  this.Nhiet_huyet_phu_them_vao_kinh_nghiem_ti_le_phan_tram = 0.0;
                  this.FLD_nhan_vat_them_vao_kinh_nghiem_hoc_vo_cong_ti_le_phan_tram = 0.0;
                  this.FLD_nhan_vat_them_vao_gold_ti_le_phan_tram = 0.0;
                  this.FLD_nhan_vat_them_vao_item_roi_xuong_xac_suat_ti_le_phan_tram = 0.0;
                  this.FLD_trang_bi_them_vao_thich_khach_kinh_kha_chi_no = 0.0;
                  this.FLD_trang_bi_them_vao_thich_khach_Lien_tieu_dai_da = 0.0;
                  this.FLD_trang_bi_them_vao_dao_khach_Am_anh_tuyet_sat = 0.0;
                  this.FLD_trang_bi_them_vao_dao_khach_Luc_phach_hoa_son = 0.0;
                  this.FLD_trang_bi_them_vao_cung_thu_Bach_bo_xuyen_duong = 0.0;
                  this.FLD_trang_bi_them_vao_cung_thu_Due_loi_chi_tien = 0.0;
                  this.FLD_trang_bi_them_vao_thuong_khach_Cuong_than_giang_the = 0.0;
                  this.FLD_trang_bi_them_vao_kiem_khach_No_hai_cuong_lan = 0.0;
                  this.FLD_trang_bi_them_vao_kiem_khach_Truong_hong_quan_nhat = 0.0;
                  this.FLD_trang_bi_them_vao_thuong_khach_Kim_chung_trao_khi = 0.0;
                  this.FLD_trang_bi_them_vao_cam_su_Loan_phuong_hoa_minh = 0.0;
                  this.FLD_trang_bi_them_vao_Cam_su_Cam_thanh_qua_nguyet = 0.0;
                  this.FLD_trang_bi_them_vao_y_the_huyet_boi_tang = 0.0;
                  this.FLD_trang_bi_them_vao_y_thien_huu_khi = 0.0;
                  this.FLD_trang_bi_them_vao_dao_khach_Nhiep_hon_nhat_kich = 0.0;
                  this.FLD_trang_bi_them_vao_dao_khach_Lien_hoan_phi_vu = 0.0;
                  this.FLD_trang_bi_them_vao_dao_khach_Tat_sat_nhat_kich = 0.0;
                  this.FLD_trang_bi_them_vao_dao_khach_Cuong_phong_van_pha = 0.0;
                  this.FLD_trang_bi_them_vao_dao_khach_Tu_luong_thien_can = 0.0;
                  this.FLD_trang_bi_them_vao_dao_khach_Chan_vu_tuyet_kich = 0.0;
                  this.FLD_trang_bi_them_vao_dao_khach_On_nhu_thai_son = 0.0;
                  this.FLD_trang_bi_them_vao_dao_khach_Phach_khi_pha_giap = 0.0;
                  this.FLD_trang_bi_them_vao_kiem_khach_Bach_bien_than_hanh = 0.0;
                  this.FLD_trang_bi_them_vao_kiem_khach_Lien_hoan_phi_vu = 0.0;
                  this.FLD_trang_bi_them_vao_kiem_khach_Tat_sat_nhat_kich = 0.0;
                  this.FLD_trang_bi_them_vao_kiem_khach_Cuong_phong_van_pha = 0.0;
                  this.FLD_trang_bi_them_vao_kiem_khach_Ho_than_cuong_khi = 0.0;
                  this.FLD_trang_bi_them_vao_kiem_khach_Di_hoa_tiep_moc = 0.0;
                  this.FLD_trang_bi_them_vao_kiem_khach_Hoi_lieu_than_phap = 0.0;
                  this.FLD_trang_bi_them_vao_kiem_khach_Trung_quan_nhat_no = 0.0;
                  this.FLD_trang_bi_them_vao_thuong_khach_Van_khi_lieu_thuong = 0.0;
                  this.FLD_trang_bi_them_vao_thuong_khach_Lien_hoan_phi_vu = 0.0;
                  this.FLD_trang_bi_them_vao_thuong_khach_Tat_sat_nhat_kich = 0.0;
                  this.FLD_trang_bi_them_vao_thuong_khach_Cuong_phong_van_pha = 0.0;
                  this.FLD_trang_bi_them_vao_thuong_khach_Hoanh_luyen_thai_bao = 0.0;
                  this.FLD_trang_bi_them_vao_thuong_khach_Can_khon_na_di = 0.0;
                  this.FLD_trang_bi_them_vao_thuong_khach_Linh_giap_ho_than = 0.0;
                  this.FLD_trang_bi_them_vao_thuong_khach_Chuyen_thu_vi_cong = 0.0;
                  this.FLD_trang_bi_them_vao_cung_thu_Liep_ung_chi_nhan = 0.0;
                  this.FLD_trang_bi_them_vao_cung_thu_Ngung_than_tu_khi = 0.0;
                  this.FLD_trang_bi_them_vao_cung_thu_Tat_sat_nhat_kich = 0.0;
                  this.FLD_trang_bi_them_vao_cung_thu_Cuong_phong_van_pha = 0.0;
                  this.FLD_trang_bi_them_vao_cung_thu_Chinh_ban_boi_nguyen = 0.0;
                  this.FLD_trang_bi_them_vao_cung_thu_Tam_than_ngung_tu = 0.0;
                  this.FLD_trang_bi_them_vao_cung_thu_Luu_tinh_tam_thi = 0.0;
                  this.FLD_trang_bi_them_vao_cung_thu_Vo_minh_am_thi = 0.0;
                  this.FLD_trang_bi_them_vao_y_van_may_hanh_tam = 0.0;
                  this.FLD_trang_bi_them_vao_y_thai_cuc_tam_phap = 0.0;
                  this.FLD_trang_bi_them_vao_y_tay_tuy_dich_kinh = 0.0;
                  this.FLD_trang_bi_them_vao_y_dieu_thu_hoi_xuan = 0.0;
                  this.FLD_trang_bi_them_vao_y_truong_cong_kich = 0.0;
                  this.FLD_trang_bi_them_vao_y_hap_tinh_dai_phap = 0.0;
                  this.FLD_trang_bi_them_vao_y_Than_Nong_tien_thuat = 0.0;
                  this.FLD_trang_bi_them_vao_y_cuu_thien_chan_khi = 0.0;
                  this.FLD_trang_bi_them_vao_thich_khach_Tam_hoa_tu_dinh = 0.0;
                  this.FLD_trang_bi_them_vao_thich_khach_Lien_hoan_phi_vu = 0.0;
                  this.FLD_trang_bi_them_vao_thich_khach_Tat_sat_nhat_kich = 0.0;
                  this.FLD_trang_bi_them_vao_thich_khach_Tam_than_ngung_tu = 0.0;
                  this.FLD_trang_bi_them_vao_thich_khach_Tri_menh_tuyet_thu = 0.0;
                  this.FLD_trang_bi_them_vao_thich_khach_Tien_phat_che_nhan = 0.0;
                  this.FLD_trang_bi_them_vao_thich_khach_Thien_chu_van_thu = 0.0;
                  this.FLD_trang_bi_them_vao_thich_khach_Kiem_nhan_loan_vu = 0.0;
                  this.FLD_trang_bi_them_vao_Cam_su_chien_ma_bon_dang = 0.0;
                  this.FLD_trang_bi_them_vao_cam_su_Thu_giang_da_bac = 0.0;
                  this.FLD_trang_bi_them_vao_Cam_su_thanh_tam_pho_thien = 0.0;
                  this.FLD_trang_bi_them_vao_cam_su_Duong_quan_tam_diep = 0.0;
                  this.FLD_trang_bi_them_vao_cam_su_Han_cung_thu_nguyet = 0.0;
                  this.FLD_trang_bi_them_vao_Cam_su_Tam_khuc_hoa_minh = 0.0;
                  this.FLD_trang_bi_them_vao_Cam_su_Nhat_am_xuat_kich = 0.0;
                  this.FLD_trang_bi_them_vao_Cam_su_Sat_am_cam_khuc = 0.0;
                  this.FLD_trang_bi_them_vao_hop_thanh_ty_le_thanh_cong_ti_le_phan_tram = 0.0;
                  this.FLD_trang_bi_them_vao_thu_duoc_tro_choi_te_ti_le_phan_tram = 0.0;
                  this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram = 0.0;
                  this.FLD_trang_bi_suc_phong_ngu_vo_cong_tang_cuong_ti_le_phan_tram = 0.0;
                  this.FLD_trang_bi_them_vao_cong_kich = 0L;
                  this.FLD_trang_bi_them_vao_phong_ngu = 0L;
                  this.FLD_trang_bi_them_vao_trung_muc_tieu = 0;
                  this.FLD_trang_bi_them_vao_ne_tranh = 0;
                  this.FLD_trang_bi_them_vao_Khi_cong = 0;
                  this.FLD_trang_bi_them_vao_Phong_cu_Cuong_hoa = 0;
                  this.FLD_trang_bi_them_vao_vu_khi_cuong_hoa = 0;
                  this.FLD_trang_bi_them_vao_kinh_nghiem_ti_le_phan_tram = 0.0;
                  this.FLD_trang_bi_them_vao_trai_tim = 0;
                  this.FLD_trang_bi_them_vao_than_the = 0;
                  this.FLD_trang_bi_them_vao_Suc_manh = 0;
                  this.FLD_trang_bi_them_vao_sinh_menh = 0;
                  this.FLD_trang_bi_them_vao_Thuc_tinh = 0;
                  base.Man_nguyet_cuong_phong = 0.0;
                  base.Liet_nhat_viem_viem = 0.0;
                  base.Vong_mai_thiem_tan = 0.0;
                  base.Thang_thien_1_khi_cong_Chinh_ban_boi_nguyen = 0.0;
                  base.Thang_thien_1_khi_cong_Cuong_phong_thien_y = 0.0;
                  base.Thang_thien_1_khi_cong_Luc_phach_hoa_son = 0.0;
                  base.Thang_thien_1_khi_cong_Van_khi_hanh_tam = 0.0;
                  base.Thang_thien_1_khi_cong_Van_khi_lieu_thuong = 0.0;
                  base.Thang_thien_1_khi_cong_Bach_bien_than_hanh = 0.0;
                  base.Thang_thien_1_khi_cong_Kim_chung_cuong_khi = 0.0;
                  base.Thang_thien_1_khi_cong_Truong_hong_quan_nhat = 0.0;
                  base.Cung_thu_thang_thien_2_khi_cong_Thien_quan_ap_da = 0.0;
                  base.Toi_thieu_cong_kich = 0.0;
                  base.Danh_Lien_Hoan_ty_le = 0.0;
                  base.Phan_am_pha_kinh_thuong_ton = 0.0;
                  base.Quai_vat_vo_cong_them_vao = 0.0;
                  base.Tri_menh_nhat_kich_ty_le = 0.0;
                  base.Cung_ten_Tri_menh_nhat_kich_ty_le = 0.0;
                  base.Phan_sat_thuong_ty_le = 0.0;
                  base.Pha_giap_ty_le = 0.0;
                  base.Vo_cong_chi_mang_ti_le = 0.0;
                  base.Dao_khach_Am_anh_tuyet_sat = 0.0;
                  base.Han_bao_quan_Thien_ma_cuong_huyet = 0.0;
                  base.Han_bao_quan_Thien_ma_cuong_huyet_2 = 0.0;
                  base.Dao_khach_Quan_cong_uy_luc = 0.0;
                  base.Thang_thien_4_khi_cong_Hong_nguyet_cuong_phong = 0.0;
                  base.Huyen_ti_chan_mach = 0.0;
                  base.Thang_thien_4_khi_cong_Doc_xa_xuat_dong = 0.0;
                  base.Dao_khach_thang_thien_1_khi_cong_Don_xuat_nghich_canh = 0.0;
                  base.Dao_khach_thang_thien_3_khi_cong_Pham_am_pha_kinh = 0.0;
                  base.Bach_bien_than_hanh = 0.0;
                  base.Kiem_khach_Ho_than_cuong_khi = 0.0;
                  base.Kiem_khach_Di_hoa_tiep_moc = 0.0;
                  base.Kiem_khach_Hoi_lieu_than_phap = 0.0;
                  base.SAT_THUONG_VO_CONG_TANG = 0.0;
                  base.Kiem_khach_No_hai_cuong_lan = 0.0;
                  base.Kiem_khach_Trung_quan_nhat_no = 0.0;
                  base.Kiem_khach_Vo_kien_bat_toi = 0.0;
                  base.Kiem_khach_thang_thien_1_khi_cong_Thua_thang_truy_kich = 0.0;
                  base.Kiem_khach_thang_thien_3_khi_cong_Hoa_phuong_lam_trieu = 0.0;
                  base.Han_bao_quan_Thien_ma_ho_the = 0.0;
                  base.HBQ_Thien_ma_thoat_cot_ty_le = 0.0;
                  base.Han_bao_quan_Hanh_phong_long_vu = 0.0;
                  base.Truong_hong_quan_thien = 0.0;
                  base.Ai_hong_bien_da = 0.0;
                  base.Thuong_khach_Van_khi_lieu_thuong = 0.0;
                  base.Thuong_khach_Linh_giap_ho_than = 0.0;
                  base.Thuong_khach_Can_khon_na_di = 0.0;
                  base.Thuong_khach_Cuong_than_hang_the = 0.0;
                  base.Thuong_khach_Chuyen_cong_vi_thu = 0.0;
                  base.Thuong_khach_Mat_nhat_cuong_vu = 0.0;
                  base.Thuong_khach_thang_thien_1_khi_cong_Pha_giap_thu_hon = 0.0;
                  base.Thuong_khach_thang_thien_2_khi_cong_Di_thoi_vi_tien = 0.0;
                  base.Thuong_khach_thang_thien_3_khi_cong_No_y_chi_hong = 0.0;
                  base.Cung_thu_Due_loi_chi_tien = 0.0;
                  base.Cung_thu_Luu_tinh_tam_thi = 0.0;
                  base.Cung_thu_Vo_minh_am_thi = 0.0;
                  base.Cung_thu_Tri_menh_tuyet_sat = 0.0;
                  base.Cung_thu_Tam_than_ngung_tu = 0.0;
                  base.Cung_thu_Ngung_than_tu_khi = 0.0;
                  base.Hoi_luu_chan_khi = 0.0;
                  base.Tuc_gian_chi_hong_Them_vao_thuong_ton = 0.0;
                  base.Cung_thu_thang_thien_1_khi_cong_Tuyet_anh_xa_hon = 0.0;
                  base.Cung_thu_thang_thien_3_khi_cong_Thien_ngoai_tam_thi = 0.0;
                  base.Y_van_khi_lieu_tam = 0.0;
                  base.Y_truong_cong_kich_luc = 0.0;
                  base.Y_hap_tinh_dai_phap = 0.0;
                  base.Y_thai_cuc_tam_phap = 0.0;
                  base.Y_van_vat_hoi_xuan = 0.0;
                  base.Y_cuu_thien_chan_khi = 0.0;
                  base.Y_ho_than_khi_giap = 0.0;
                  base.Y_thang_thien_1_khi_cong_Cuong_y_ho_the = 0.0;
                  base.Y_thang_thien_2_khi_cong_vo_trung_sinh_huu = 0.0;
                  base.Y_thang_thien_3_khi_cong_Minh_kinh_chi_thuy = 0.0;
                  base.Thich_khach_Kinh_kha_chi_no = 0.0;
                  base.Thich_khach_Tam_hoa_tu_dinh = 0.0;
                  base.Thich_khach_Lien_hoan_phi_vu = 0.0;
                  base.Thich_khach_Tat_sat_nhat_kich = 0.0;
                  base.Thich_khach_Tam_than_ngung_tu = 0.0;
                  base.Thich_khach_Tri_thu_tuyet_menh = 0.0;
                  base.Thich_khach_Tien_phat_che_nhan = 0.0;
                  base.Thich_khach_Thien_chu_van_thu = 0.0;
                  base.Thich_khach_Lien_tieu_dai_da = 0.0;
                  base.Thich_khach_Kiem_nhan_loan_vu = 0.0;
                  base.Thich_khach_Vo_tinh_da_kich = 0.0;
                  base.Thich_khach_thang_thien_2_khi_cong_Thuan_thuy_thoi_chu = 0.0;
                  base.Thich_khach_thang_thien_1_khi_cong_Da_ma_trien_than = 0.0;
                  base.Thich_khach_thang_thien_3_khi_cong_Di_no_hoan_no = 0.0;
                  base.Cam_su_Tam_khuc_hoa_minh = 0.0;
                  base.Cam_su_Han_cung_thu_nguyet = 0.0;
                  base.Cam_su_Loan_phuong_hoa_minh = 0.0;
                  base.Cam_su_kich_luc_cong_thanh = 0.0;
                  base.Cam_su_Nhat_am_xuat_kich = 0.0;
                  base.Cam_su_Thanh_tam_pho_thien = 0.0;
                  base.Cam_su_Thu_giang_da_bac = 0.0;
                  base.Cam_su_Sat_menh_cam_thanh = 0.0;
                  base.Cam_su_Duong_quan_tam_diep = 0.0;
                  base.Cam_su_Sat_am_cam_khuc = 0.0;
                  base.Cam_su_Cam_thanh_qua_nguyet = 0.0;
                  base.Cam_su_Chien_ma_bon_dang = 0.0;
                  base.Cam_su_Tam_hoa_huyen_phat_dong_xac_suat = 0.0;
                  base.Cam_su_thang_thien_1_khi_cong_Phi_hoa_diem_thuy = 0.0;
                  base.Cam_su_thang_thien_2_khi_cong_Tam_dam_anh_nguyet = 0.0;
                  base.Cam_su_thang_thien_3_khi_cong_Tu_da_thu_ca = 0.0;
                  this.double_115 = 0.0;
                  this.double_116 = 0.0;
                  this.FLD_cong_kich_toc_do = 100;
                  this.int_9 = 0;
                  this.int_11 = 0;
                  this.double_114 = 0.0;
                  this.int_12 = 0;
                  this.int_15 = 0;
                  this.int_14 = 0;
                  this.int_13 = 0;
                  this.Thuong_ha_dieu_tinh_toan = 0;
                  this.Duoi_ha_dieu_tinh_toan = 0;
                  this.Ngoc_lien_hoan_ke_so = 0;
                  this.Vo_Huan_them_vao_HP = 0;
                  this.Vo_Huan_them_vao_MP = 0;
                  this.FLD_Vo_cong_cong_kich = 0;
                  this.FLD_Vo_cong_phong_ngu = 0;
                  this.FLD_Vo_huan_them_vao_khi_cong = 0;
                  this.Khen_thuong_them_vao_sinh_menh = 0L;
                  this.Khen_thuong_them_vao_cong_kich = 0L;
                  this.Khen_thuong_them_vao_ne_tranh = 0;
                  this.Khen_thuong_them_vao_trung_muc_tieu = 0;
                  this.Khen_thuong_them_vao_noi_cong = 0;
                  this.Khen_thuong_them_vao_phong_ngu = 0L;
                  this.Chuyen_sinh_so_lan = 0;
                  this.Thanh_vien_thu_bac = 0L;
                  this.Config.Vo_Huan_mo_ra = 0;
                  this.int_16 = 0;
                  this.int_8 = 0;
                  this.FLD_trang_bi_them_vao_quyen_su_cuong_than_giang_the = 0.0;
                  this.FLD_trang_bi_them_vao_quyen_su_van_may_chua_thuong = 0.0;
                  this.FLD_trang_bi_them_vao_quyen_su_suc_manh_phach_Hoa_Son = 0.0;
                  this.FLD_trang_bi_them_vao_quyen_su_cuong_phong_van_pha = 0.0;
                  this.FLD_trang_bi_them_vao_quyen_su_kim_cuong_bat_hoai = 0.0;
                  this.FLD_trang_bi_them_vao_quyen_su_doi_cong_lam_thu = 0.0;
                  this.FLD_trang_bi_them_vao_quyen_su_bang_hoa_mot_the = 0.0;
                  this.FLD_trang_bi_them_vao_quyen_su_hieu_y_mot_don = 0.0;
                  this.FLD_trang_bi_them_vao_quyen_su_linh_giap_ho_than = 0.0;
                  this.FLD_trang_bi_them_vao_quyen_su_mai_xu_thanh_cham = 0.0;
                  base.Quyen_cuong_than_giang_the = 0.0;
                  base.Quyen_van_may_chua_thuong = 0.0;
                  base.Quyen_luc_phach_Hoa_Son = 0.0;
                  base.Quyen_cuong_phong_van_pha = 0.0;
                  base.Quyen_kim_cuong_bat_hoai = 0.0;
                  base.Quyen_doi_cong_lam_thu = 0.0;
                  base.Quyen_bang_hoa_mot_the = 0.0;
                  base.Quyen_hieu_y_mot_don = 0.0;
                  base.Quyen_linh_giap_ho_than = 0.0;
                  base.Quyen_mai_xu_thanh_cham = 0.0;
                  base.Quyen_thang_thien_1_khi_cong_doat_menh_lien_hoan = 0.0;
                  base.Quyen_thang_thien_2_khi_cong_chop_mat = 0.0;
                  base.Quyen_thang_thien_3_khi_cong_da_tot_muon_tot_hon = 0.0;
                  base.Quyen_thang_thien_4_khi_cong_hong_nguyet_cuong_phong = 0.0;
                  base.Quyen_thang_thien_4_khi_cong_ran_doc_xuat_dong = 0.0;
            }

            public void TINH_TOAN_NHAN_VAT_TRANG_BI_SO_LIEU()
            {
                  using (new Lock(this.object_2, "计算人物装备数据"))
                  {
                        int num = 0;
                        int num2 = 0;
                        int num3 = 0;
                        int num4 = 0;
                        int num5 = 0;
                        int num6 = 0;
                        int num7 = 0;
                        this.FLD_trang_bi_them_vao_dao_khach_Am_anh_tuyet_sat = 0.0;
                        this.FLD_trang_bi_them_vao_dao_khach_Luc_phach_hoa_son = 0.0;
                        this.FLD_trang_bi_them_vao_dao_khach_Phach_khi_pha_giap = 0.0;
                        this.FLD_trang_bi_them_vao_dao_khach_Tat_sat_nhat_kich = 0.0;
                        this.FLD_trang_bi_them_vao_dao_khach_Cuong_phong_van_pha = 0.0;
                        this.FLD_trang_bi_them_vao_dao_khach_Lien_hoan_phi_vu = 0.0;
                        this.FLD_trang_bi_them_vao_dao_khach_Nhiep_hon_nhat_kich = 0.0;
                        this.FLD_trang_bi_them_vao_dao_khach_Tu_luong_thien_can = 0.0;
                        this.FLD_trang_bi_them_vao_dao_khach_On_nhu_thai_son = 0.0;
                        this.FLD_trang_bi_them_vao_dao_khach_Chan_vu_tuyet_kich = 0.0;
                        this.FLD_trang_bi_them_vao_kiem_khach_No_hai_cuong_lan = 0.0;
                        this.FLD_trang_bi_them_vao_kiem_khach_Truong_hong_quan_nhat = 0.0;
                        this.FLD_trang_bi_them_vao_kiem_khach_Bach_bien_than_hanh = 0.0;
                        this.FLD_trang_bi_them_vao_kiem_khach_Lien_hoan_phi_vu = 0.0;
                        this.FLD_trang_bi_them_vao_kiem_khach_Tat_sat_nhat_kich = 0.0;
                        this.FLD_trang_bi_them_vao_kiem_khach_Cuong_phong_van_pha = 0.0;
                        this.FLD_trang_bi_them_vao_kiem_khach_Ho_than_cuong_khi = 0.0;
                        this.FLD_trang_bi_them_vao_kiem_khach_Di_hoa_tiep_moc = 0.0;
                        this.FLD_trang_bi_them_vao_kiem_khach_Hoi_lieu_than_phap = 0.0;
                        this.FLD_trang_bi_them_vao_kiem_khach_Trung_quan_nhat_no = 0.0;
                        this.FLD_trang_bi_them_vao_thuong_khach_Cuong_than_giang_the = 0.0;
                        this.FLD_trang_bi_them_vao_thuong_khach_Kim_chung_trao_khi = 0.0;
                        this.FLD_trang_bi_them_vao_thuong_khach_Van_khi_lieu_thuong = 0.0;
                        this.FLD_trang_bi_them_vao_thuong_khach_Lien_hoan_phi_vu = 0.0;
                        this.FLD_trang_bi_them_vao_thuong_khach_Tat_sat_nhat_kich = 0.0;
                        this.FLD_trang_bi_them_vao_thuong_khach_Cuong_phong_van_pha = 0.0;
                        this.FLD_trang_bi_them_vao_thuong_khach_Hoanh_luyen_thai_bao = 0.0;
                        this.FLD_trang_bi_them_vao_thuong_khach_Can_khon_na_di = 0.0;
                        this.FLD_trang_bi_them_vao_thuong_khach_Linh_giap_ho_than = 0.0;
                        this.FLD_trang_bi_them_vao_thuong_khach_Chuyen_thu_vi_cong = 0.0;
                        this.FLD_trang_bi_them_vao_cung_thu_Bach_bo_xuyen_duong = 0.0;
                        this.FLD_trang_bi_them_vao_cung_thu_Due_loi_chi_tien = 0.0;
                        this.FLD_trang_bi_them_vao_cung_thu_Liep_ung_chi_nhan = 0.0;
                        this.FLD_trang_bi_them_vao_cung_thu_Ngung_than_tu_khi = 0.0;
                        this.FLD_trang_bi_them_vao_cung_thu_Tat_sat_nhat_kich = 0.0;
                        this.FLD_trang_bi_them_vao_cung_thu_Cuong_phong_van_pha = 0.0;
                        this.FLD_trang_bi_them_vao_cung_thu_Chinh_ban_boi_nguyen = 0.0;
                        this.FLD_trang_bi_them_vao_cung_thu_Tam_than_ngung_tu = 0.0;
                        this.FLD_trang_bi_them_vao_cung_thu_Luu_tinh_tam_thi = 0.0;
                        this.FLD_trang_bi_them_vao_cung_thu_Vo_minh_am_thi = 0.0;
                        this.FLD_trang_bi_them_vao_y_the_huyet_boi_tang = 0.0;
                        this.FLD_trang_bi_them_vao_y_thien_huu_khi = 0.0;
                        this.FLD_trang_bi_them_vao_y_van_may_hanh_tam = 0.0;
                        this.FLD_trang_bi_them_vao_y_thai_cuc_tam_phap = 0.0;
                        this.FLD_trang_bi_them_vao_y_tay_tuy_dich_kinh = 0.0;
                        this.FLD_trang_bi_them_vao_y_dieu_thu_hoi_xuan = 0.0;
                        this.FLD_trang_bi_them_vao_y_truong_cong_kich = 0.0;
                        this.FLD_trang_bi_them_vao_y_hap_tinh_dai_phap = 0.0;
                        this.FLD_trang_bi_them_vao_y_Than_Nong_tien_thuat = 0.0;
                        this.FLD_trang_bi_them_vao_y_cuu_thien_chan_khi = 0.0;
                        this.FLD_trang_bi_them_vao_thich_khach_kinh_kha_chi_no = 0.0;
                        this.FLD_trang_bi_them_vao_thich_khach_Lien_tieu_dai_da = 0.0;
                        this.FLD_trang_bi_them_vao_thich_khach_Tam_hoa_tu_dinh = 0.0;
                        this.FLD_trang_bi_them_vao_thich_khach_Lien_hoan_phi_vu = 0.0;
                        this.FLD_trang_bi_them_vao_thich_khach_Tat_sat_nhat_kich = 0.0;
                        this.FLD_trang_bi_them_vao_thich_khach_Tam_than_ngung_tu = 0.0;
                        this.FLD_trang_bi_them_vao_thich_khach_Tri_menh_tuyet_thu = 0.0;
                        this.FLD_trang_bi_them_vao_thich_khach_Tien_phat_che_nhan = 0.0;
                        this.FLD_trang_bi_them_vao_thich_khach_Thien_chu_van_thu = 0.0;
                        this.FLD_trang_bi_them_vao_thich_khach_Kiem_nhan_loan_vu = 0.0;
                        this.FLD_trang_bi_them_vao_cam_su_Loan_phuong_hoa_minh = 0.0;
                        this.FLD_trang_bi_them_vao_Cam_su_Cam_thanh_qua_nguyet = 0.0;
                        this.FLD_trang_bi_them_vao_Cam_su_chien_ma_bon_dang = 0.0;
                        this.FLD_trang_bi_them_vao_cam_su_Thu_giang_da_bac = 0.0;
                        this.FLD_trang_bi_them_vao_Cam_su_thanh_tam_pho_thien = 0.0;
                        this.FLD_trang_bi_them_vao_cam_su_Duong_quan_tam_diep = 0.0;
                        this.FLD_trang_bi_them_vao_cam_su_Han_cung_thu_nguyet = 0.0;
                        this.FLD_trang_bi_them_vao_Cam_su_Tam_khuc_hoa_minh = 0.0;
                        this.FLD_trang_bi_them_vao_Cam_su_Nhat_am_xuat_kich = 0.0;
                        this.FLD_trang_bi_them_vao_Cam_su_Sat_am_cam_khuc = 0.0;
                        this.FLD_trang_bi_them_vao_hop_thanh_ty_le_thanh_cong_ti_le_phan_tram = 0.0;
                        this.FLD_trang_bi_them_vao_thu_duoc_tro_choi_te_ti_le_phan_tram = 0.0;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram = 0.0;
                        this.FLD_trang_bi_them_vao_quyen_su_cuong_than_giang_the = 0.0;
                        this.FLD_trang_bi_them_vao_quyen_su_van_may_chua_thuong = 0.0;
                        this.FLD_trang_bi_them_vao_quyen_su_suc_manh_phach_Hoa_Son = 0.0;
                        this.FLD_trang_bi_them_vao_quyen_su_cuong_phong_van_pha = 0.0;
                        this.FLD_trang_bi_them_vao_quyen_su_kim_cuong_bat_hoai = 0.0;
                        this.FLD_trang_bi_them_vao_quyen_su_doi_cong_lam_thu = 0.0;
                        this.FLD_trang_bi_them_vao_quyen_su_bang_hoa_mot_the = 0.0;
                        this.FLD_trang_bi_them_vao_quyen_su_hieu_y_mot_don = 0.0;
                        this.FLD_trang_bi_them_vao_quyen_su_linh_giap_ho_than = 0.0;
                        this.FLD_trang_bi_them_vao_quyen_su_mai_xu_thanh_cham = 0.0;
                        this.FLD_trang_bi_suc_phong_ngu_vo_cong_tang_cuong_ti_le_phan_tram = 0.0;
                        this.FLD_trang_bi_them_vao_cong_kich = 0L;
                        this.FLD_trang_bi_them_vao_phong_ngu = 0L;
                        this.FLD_trang_bi_them_vao_trung_muc_tieu = 0;
                        this.FLD_trang_bi_them_vao_ne_tranh = 0;
                        this.FLD_trang_bi_them_vao_Khi_cong = 0;
                        this.FLD_trang_bi_them_vao_kinh_nghiem_ti_le_phan_tram = 0.0;
                        this.int_109 = 0;
                        this.int_110 = 0;
                        this.int_111 = 0;
                        this.int_112 = 0;
                        this.int_113 = 0;
                        this.int_114 = 0;
                        this.int_115 = 0;
                        this.FLD_trang_bi_them_vao_trai_tim = 0;
                        this.FLD_trang_bi_them_vao_than_the = 0;
                        this.FLD_trang_bi_them_vao_Suc_manh = 0;
                        this.FLD_trang_bi_them_vao_sinh_menh = 0;
                        this.FLD_trang_bi_them_vao_Thuc_tinh = 0;
                        this.FLD_trang_bi_them_vao_HP = 0;
                        this.FLD_trang_bi_them_vao_MP = 0;
                        for (int i = 0; i < 15; i++)
                        {
                              if (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0)
                              {
                                    continue;
                              }
                              this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].method_15();
                              this.FLD_trang_bi_them_vao_cong_kich += (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_luc_cong_kich + this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_luc_cong_kich_MAX) / 2L;
                              this.FLD_trang_bi_them_vao_phong_ngu += this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_suc_phong_ngu;
                              this.FLD_trang_bi_them_vao_trung_muc_tieu += this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_Ti_le_trung_muc_tieu_tang_cuong;
                              this.FLD_trang_bi_them_vao_ne_tranh += this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_ne_tranh_xac_xuat_tang_cuong;
                              double num9 = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_Luc_cong_kich_vo_cong;
                              double num10 = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_suc_phong_ngu_vo_cong_tang_cuong;
                              if (World.Vo_cong_phong_ngu_hinh_thuc == 1)
                              {
                                    num10 /= 6.0;
                              }
                              this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += num9 / ((double)World.Vo_cong_Cong_kich_suc_manh_khong_che);
                              this.FLD_trang_bi_suc_phong_ngu_vo_cong_tang_cuong_ti_le_phan_tram += num10 / ((double)World.Vo_cong_Phong_ngu_suc_manh_khong_che);
                              this.FLD_trang_bi_them_vao_Khi_cong += this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_toan_bo_khi_cong_thu_bac_tang_cuong;
                              this.FLD_trang_bi_them_vao_HP += this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_sinh_menh_tang_cuong;
                              this.FLD_trang_bi_them_vao_MP += this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_Noi_cong_suc_manh_tang_cuong;
                              this.FLD_trang_bi_them_vao_hop_thanh_ty_le_thanh_cong_ti_le_phan_tram += this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_thang_cap_ty_le_thanh_cong / 100.0;
                              this.FLD_trang_bi_them_vao_thu_duoc_tro_choi_te_ti_le_phan_tram += this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_thu_duoc_tien_tai_tang_cuong / 100.0;
                              this.FLD_trang_bi_them_vao_kinh_nghiem_ti_le_phan_tram += this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_kinh_nghiem_thu_duoc_gia_tang / 100.0;
                              if ((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon <= 0x16) && (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon >= 0x15))
                              {
                                    if (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_thuc_tinh > 0)
                                    {
                                          this.FLD_trang_bi_them_vao_Thuc_tinh = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon - 20;
                                    }
                              }
                              else if ((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon <= 20) && (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon >= 0x10))
                              {
                                    this.FLD_trang_bi_them_vao_sinh_menh = ((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon - 15) / 100) * this.FLD_SINH_MENH;
                              }
                              else if ((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon <= 15) && (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon >= 11))
                              {
                                    this.FLD_trang_bi_them_vao_Suc_manh = ((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon - 10) / 100) * this.FLD_SUC_MANH;
                              }
                              else if ((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon <= 10) && (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon >= 6))
                              {
                                    this.FLD_trang_bi_them_vao_than_the = ((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon - 5) / 100) * this.FLD_THAN_THE;
                              }
                              else if ((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon <= 5) && (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon >= 1))
                              {
                                    this.FLD_trang_bi_them_vao_trai_tim = (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon / 100) * this.FLD_TIM;
                              }
                              if (((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_RESIDE2 == 1) || (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_RESIDE2 == 2)) || ((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_RESIDE2 == 5) || (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_RESIDE2 == 6)))
                              {
                                    if (this.PHAN_DOAN_TRANG_BI(this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID, this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_RESIDE2))
                                    {
                                          num++;
                                    }
                                    if (this.method_22(this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID, this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_RESIDE2))
                                    {
                                          num3++;
                                    }
                                    if (this.method_23(this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID, this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_RESIDE2))
                                    {
                                          num5++;
                                    }
                                    if (this.method_24(this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID, this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_RESIDE2))
                                    {
                                          num6++;
                                    }
                                    if (this.method_25(this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID, this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_RESIDE2))
                                    {
                                          num7++;
                                    }
                                    if (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_RESIDE2 == 1)
                                    {
                                          switch (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].ItemPropertyType)
                                          {
                                                case 3:
                                                      this.FLD_trang_bi_them_vao_ne_tranh += (int)(this.FLD_NE_TRANH * (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].ItemPropertyNumber * 0.01));
                                                      break;

                                                case 4:
                                                      this.FLD_trang_bi_suc_phong_ngu_vo_cong_tang_cuong_ti_le_phan_tram += this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].ItemPropertyNumber * 0.005;
                                                      break;

                                                case 5:
                                                      this.FLD_trang_bi_them_vao_phong_ngu += this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].ItemPropertyNumber * 3;
                                                      break;
                                          }
                                    }
                                    this.FLD_trang_bi_them_vao_phong_ngu += this.FLD_trang_bi_them_vao_Phong_cu_Cuong_hoa * 12;
                                    if (this.FLD_trang_bi_them_vao_Thuc_tinh >= 0)
                                    {
                                          this.FLD_trang_bi_them_vao_phong_ngu += (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_thuc_tinh + this.FLD_trang_bi_them_vao_Thuc_tinh) * World.Quan_ao_phu_hon_tang_cuong_Thuoc_tinh_So_luong;
                                    }
                                    if (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_cuong_hoa_so_luong >= 12)
                                    {
                                          this.FLD_trang_bi_them_vao_HP += 200;
                                    }
                              }
                              if (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_RESIDE2 == 4)
                              {
                                    if (this.method_22(this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID, this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_RESIDE2))
                                    {
                                          num3++;
                                    }
                                    if (this.method_23(this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID, this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_RESIDE2))
                                    {
                                          num5++;
                                    }
                                    if (this.method_24(this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID, this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_RESIDE2))
                                    {
                                          num6++;
                                    }
                                    if (this.method_25(this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID, this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_RESIDE2))
                                    {
                                          num7++;
                                    }
                                    if (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].ItemPropertyType == 6)
                                    {
                                          this.FLD_trang_bi_them_vao_cong_kich += this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].ItemPropertyNumber * 3;
                                    }
                                    if ((((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0x6083081L) || (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0xbfe1181L)) || ((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0x11f3f281L) || (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0x17e9d381L))) || (((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0x1ddfb481L) || (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0x29cb7681L)) || ((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0x2fc15781L) || (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0x35b73881L))))
                                    {
                                          this.FLD_trang_bi_them_vao_Khi_cong += 3;
                                          this.FLD_trang_bi_them_vao_kinh_nghiem_ti_le_phan_tram += 0.15;
                                    }
                                    if (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_cuong_hoa_so_luong >= 12)
                                    {
                                          this.FLD_trang_bi_them_vao_Khi_cong += 3;
                                    }
                                    if (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_cuong_hoa_so_luong == 11)
                                    {
                                          this.FLD_trang_bi_them_vao_Khi_cong += 2;
                                    }
                                    this.FLD_trang_bi_them_vao_trung_muc_tieu += 50;
                                    this.FLD_trang_bi_them_vao_cong_kich += this.FLD_trang_bi_them_vao_vu_khi_cuong_hoa * 12;
                                    if (this.FLD_trang_bi_them_vao_Thuc_tinh >= 0)
                                    {
                                          this.FLD_trang_bi_them_vao_cong_kich += (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_thuc_tinh + this.FLD_trang_bi_them_vao_Thuc_tinh) * World.Vu_khi_phu_hon_tang_cuong_thuoc_tinh_so_luong;
                                    }
                              }
                              if (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_RESIDE2 == 7)
                              {
                                    this.FLD_trang_bi_them_vao_phong_ngu += this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_cuong_hoa_so_luong * World.Day_chuyen_gia_cong_1_giai_doan_tang_cuong_phong_ngu;
                                    if (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0x186b6L)
                                    {
                                          num2++;
                                    }
                              }
                              if (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_RESIDE2 == 8)
                              {
                                    this.FLD_trang_bi_them_vao_HP += this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_cuong_hoa_so_luong * World.Vong_tai_gia_cong_1_giai_doan_tang_cuong_sinh_menh;
                                    if ((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0x19a7924L) || (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0x101e2a4L))
                                    {
                                          num4++;
                                    }
                                    if (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0x11L)
                                    {
                                          num2++;
                                    }
                              }
                              if (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_RESIDE2 == 10)
                              {
                                    this.FLD_trang_bi_them_vao_cong_kich += this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_cuong_hoa_so_luong * World.Nhan_gia_cong_1_giai_doan_tang_cuong_cong_kich;
                                    if ((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0x19a7924L) || (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0x101e2a4L))
                                    {
                                          num4++;
                                    }
                                    if (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0xaae77L)
                                    {
                                          num2++;
                                    }
                              }
                              if ((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_RESIDE2 == 12) || (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_RESIDE2 == 14))
                              {
                                    if ((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0x19a7924L) || (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0x101e2a4L))
                                    {
                                          num4++;
                                    }
                                    switch (this.Player_Job)
                                    {
                                          case 1:
                                          case 8:
                                                this.FLD_trang_bi_them_vao_dao_khach_Am_anh_tuyet_sat = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_dao_khach_Am_anh_tuyet_sat;
                                                this.FLD_trang_bi_them_vao_dao_khach_Luc_phach_hoa_son = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_dao_khach_Luc_phach_hoa_son;
                                                this.FLD_trang_bi_them_vao_dao_khach_Phach_khi_pha_giap = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_dao_khach_Phach_khi_pha_giap;
                                                this.FLD_trang_bi_them_vao_dao_khach_Tat_sat_nhat_kich = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_dao_khach_Tat_sat_nhat_kich;
                                                this.FLD_trang_bi_them_vao_dao_khach_Cuong_phong_van_pha = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_dao_khach_Cuong_phong_van_pha;
                                                this.FLD_trang_bi_them_vao_dao_khach_Lien_hoan_phi_vu = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_dao_khach_Lien_hoan_phi_vu;
                                                this.FLD_trang_bi_them_vao_dao_khach_Nhiep_hon_nhat_kich = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_dao_khach_Nhiep_hon_nhat_kich;
                                                this.FLD_trang_bi_them_vao_dao_khach_Tu_luong_thien_can = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_dao_khach_Tu_luong_thien_can;
                                                this.FLD_trang_bi_them_vao_dao_khach_On_nhu_thai_son = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_dao_khach_On_nhu_thai_son;
                                                this.FLD_trang_bi_them_vao_dao_khach_Chan_vu_tuyet_kich = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_dao_khach_Chan_vu_tuyet_kich;
                                                break;

                                          case 2:
                                          case 9:
                                                this.FLD_trang_bi_them_vao_kiem_khach_No_hai_cuong_lan = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_kiem_khach_No_hai_cuong_lan;
                                                this.FLD_trang_bi_them_vao_kiem_khach_Truong_hong_quan_nhat = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_kiem_khach_Truong_hong_quan_nhat;
                                                this.FLD_trang_bi_them_vao_kiem_khach_Bach_bien_than_hanh = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_kiem_khach_Bach_bien_than_hanh;
                                                this.FLD_trang_bi_them_vao_kiem_khach_Lien_hoan_phi_vu = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_kiem_khach_Lien_hoan_phi_vu;
                                                this.FLD_trang_bi_them_vao_kiem_khach_Tat_sat_nhat_kich = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_kiem_khach_Tat_sat_nhat_kich;
                                                this.FLD_trang_bi_them_vao_kiem_khach_Cuong_phong_van_pha = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_kiem_khach_Cuong_phong_van_pha;
                                                this.FLD_trang_bi_them_vao_kiem_khach_Ho_than_cuong_khi = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_kiem_khach_Ho_than_cuong_khi;
                                                this.FLD_trang_bi_them_vao_kiem_khach_Di_hoa_tiep_moc = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_kiem_khach_Di_hoa_tiep_moc;
                                                this.FLD_trang_bi_them_vao_kiem_khach_Hoi_lieu_than_phap = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_kiem_khach_Hoi_lieu_than_phap;
                                                this.FLD_trang_bi_them_vao_kiem_khach_Trung_quan_nhat_no = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_kiem_khach_Trung_quan_nhat_no;
                                                break;

                                          case 3:
                                                this.FLD_trang_bi_them_vao_thuong_khach_Cuong_than_giang_the = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_thuong_khach_Cuong_than_hang_the;
                                                this.FLD_trang_bi_them_vao_thuong_khach_Kim_chung_trao_khi = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_thuong_khach_Kim_chung_trao_khi;
                                                this.FLD_trang_bi_them_vao_thuong_khach_Van_khi_lieu_thuong = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_thuong_khach_Van_khi_lieu_thuong;
                                                this.FLD_trang_bi_them_vao_thuong_khach_Lien_hoan_phi_vu = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_thuong_khach_Lien_hoan_phi_vu;
                                                this.FLD_trang_bi_them_vao_thuong_khach_Tat_sat_nhat_kich = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_thuong_khach_Tat_sat_nhat_kich;
                                                this.FLD_trang_bi_them_vao_thuong_khach_Cuong_phong_van_pha = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_thuong_khach_Cuong_phong_van_pha;
                                                this.FLD_trang_bi_them_vao_thuong_khach_Hoanh_luyen_thai_bao = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_thuong_khach_Hoanh_luyen_thai_bao;
                                                this.FLD_trang_bi_them_vao_thuong_khach_Can_khon_na_di = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_thuong_khach_Can_khon_na_di;
                                                this.FLD_trang_bi_them_vao_thuong_khach_Linh_giap_ho_than = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_thuong_khach_Linh_giap_ho_than;
                                                this.FLD_trang_bi_them_vao_thuong_khach_Chuyen_thu_vi_cong = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_thuong_khach_Chuyen_thu_vi_cong;
                                                break;

                                          case 4:
                                                this.FLD_trang_bi_them_vao_cung_thu_Bach_bo_xuyen_duong = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_cung_thu_Bach_bo_xuyen_duong;
                                                this.FLD_trang_bi_them_vao_cung_thu_Due_loi_chi_tien = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_cung_thu_Due_loi_chi_tien;
                                                this.FLD_trang_bi_them_vao_cung_thu_Liep_ung_chi_nhan = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_cung_thu_Liep_ung_chi_nhan;
                                                this.FLD_trang_bi_them_vao_cung_thu_Ngung_than_tu_khi = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_cung_thu_Ngung_than_tu_khi;
                                                this.FLD_trang_bi_them_vao_cung_thu_Tat_sat_nhat_kich = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_cung_thu_Tat_sat_nhat_kich;
                                                this.FLD_trang_bi_them_vao_cung_thu_Cuong_phong_van_pha = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_cung_thu_Cuong_phong_van_pha;
                                                this.FLD_trang_bi_them_vao_cung_thu_Chinh_ban_boi_nguyen = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_cung_thu_Chinh_ban_boi_nguyen;
                                                this.FLD_trang_bi_them_vao_cung_thu_Tam_than_ngung_tu = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_cung_thu_Tam_than_ngung_tu;
                                                this.FLD_trang_bi_them_vao_cung_thu_Luu_tinh_tam_thi = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_cung_thu_Luu_tinh_tam_thi;
                                                this.FLD_trang_bi_them_vao_cung_thu_Vo_minh_am_thi = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_cung_thu_Vo_minh_am_thi;
                                                break;

                                          case 5:
                                                this.FLD_trang_bi_them_vao_y_the_huyet_boi_tang = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_Y_the_huyet_boi_tang;
                                                this.FLD_trang_bi_them_vao_y_thien_huu_khi = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_Y_thien_huu_khi;
                                                this.FLD_trang_bi_them_vao_y_van_may_hanh_tam = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_Y_van_khi_hanh_tam;
                                                this.FLD_trang_bi_them_vao_y_thai_cuc_tam_phap = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_Y_thai_cuc_tam_phap;
                                                this.FLD_trang_bi_them_vao_y_tay_tuy_dich_kinh = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_Y_tay_tuy_dich_kinh;
                                                this.FLD_trang_bi_them_vao_y_dieu_thu_hoi_xuan = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_y_Dieu_thu_hoi_xuan;
                                                this.FLD_trang_bi_them_vao_y_truong_cong_kich = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_Y_Truong_cong_cong_kich;
                                                this.FLD_trang_bi_them_vao_y_hap_tinh_dai_phap = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_Y_hap_tinh_dai_phap;
                                                this.FLD_trang_bi_them_vao_y_Than_Nong_tien_thuat = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_y_Than_Nong_tien_thuat;
                                                this.FLD_trang_bi_them_vao_y_cuu_thien_chan_khi = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_Y_Cuu_thien_chan_khi;
                                                break;

                                          case 6:
                                                this.FLD_trang_bi_them_vao_thich_khach_kinh_kha_chi_no = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_thich_khach_Kinh_kha_chi_no;
                                                this.FLD_trang_bi_them_vao_thich_khach_Lien_tieu_dai_da = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_thich_khach_Lien_tieu_dai_da;
                                                this.FLD_trang_bi_them_vao_thich_khach_Tam_hoa_tu_dinh = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_thich_khach_Tam_hoa_tu_dinh;
                                                this.FLD_trang_bi_them_vao_thich_khach_Lien_hoan_phi_vu = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_thich_khach_Lien_hoan_phi_vu;
                                                this.FLD_trang_bi_them_vao_thich_khach_Tat_sat_nhat_kich = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_thich_khach_Tat_sat_nhat_kich;
                                                this.FLD_trang_bi_them_vao_thich_khach_Tam_than_ngung_tu = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_thich_khach_Tam_than_ngung_tu;
                                                this.FLD_trang_bi_them_vao_thich_khach_Tri_menh_tuyet_thu = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_dao_khach_Tri_menh_tuyet_thu;
                                                this.FLD_trang_bi_them_vao_thich_khach_Tien_phat_che_nhan = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_thich_khach_Tien_phat_che_nhan;
                                                this.FLD_trang_bi_them_vao_thich_khach_Thien_chu_van_thu = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_thich_khach_Thien_chu_van_thu;
                                                this.FLD_trang_bi_them_vao_thich_khach_Kiem_nhan_loan_vu = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_thich_khach_Kiem_nhan_loan_vu;
                                                break;

                                          case 7:
                                                this.FLD_trang_bi_them_vao_cam_su_Loan_phuong_hoa_minh = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_cam_su_Loan_phuong_hoa_minh;
                                                this.FLD_trang_bi_them_vao_Cam_su_Cam_thanh_qua_nguyet = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_Cam_su_Cam_thanh_qua_nguyet;
                                                this.FLD_trang_bi_them_vao_Cam_su_chien_ma_bon_dang = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_cam_su_Chien_ma_bon_dang;
                                                this.FLD_trang_bi_them_vao_cam_su_Thu_giang_da_bac = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_cam_su_Thu_giang_da_bac;
                                                this.FLD_trang_bi_them_vao_Cam_su_thanh_tam_pho_thien = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_cam_su_Thanh_tam_pho_thien;
                                                this.FLD_trang_bi_them_vao_cam_su_Duong_quan_tam_diep = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_cam_su_Duong_quan_tam_diep;
                                                this.FLD_trang_bi_them_vao_cam_su_Han_cung_thu_nguyet = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_cam_su_Han_cung_thu_nguyet;
                                                this.FLD_trang_bi_them_vao_Cam_su_Tam_khuc_hoa_minh = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_Cam_su_Tam_khuc_hoa_minh;
                                                this.FLD_trang_bi_them_vao_Cam_su_Nhat_am_xuat_kich = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_Cam_su_Nhat_am_xuat_kich;
                                                this.FLD_trang_bi_them_vao_Cam_su_Sat_am_cam_khuc = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_Cam_su_Sat_am_cam_khuc;
                                                break;

                                          case 10:
                                                this.FLD_trang_bi_them_vao_quyen_su_cuong_than_giang_the = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_Quyen_cuong_than_giang_the;
                                                this.FLD_trang_bi_them_vao_quyen_su_van_may_chua_thuong = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_Quyen_van_may_chua_thuong;
                                                this.FLD_trang_bi_them_vao_quyen_su_suc_manh_phach_Hoa_Son = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_Quyen_luc_phach_Hoa_Son;
                                                this.FLD_trang_bi_them_vao_quyen_su_cuong_phong_van_pha = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_Quyen_cuong_phong_van_pha;
                                                this.FLD_trang_bi_them_vao_quyen_su_kim_cuong_bat_hoai = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_Quyen_kim_cuong_bat_hoai;
                                                this.FLD_trang_bi_them_vao_quyen_su_doi_cong_lam_thu = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_Quyen_doi_cong_lam_thu;
                                                this.FLD_trang_bi_them_vao_quyen_su_bang_hoa_mot_the = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_Quyen_bang_hoa_mot_the;
                                                this.FLD_trang_bi_them_vao_quyen_su_hieu_y_mot_don = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_Quyen_hieu_y_mot_don;
                                                this.FLD_trang_bi_them_vao_quyen_su_linh_giap_ho_than = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_Quyen_linh_giap_ho_than;
                                                this.FLD_trang_bi_them_vao_quyen_su_mai_xu_thanh_cham = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].Item_thuoc_tinh_them_vao_Quyen_mai_xu_thanh_cham;
                                                break;
                                    }
                                    if ((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0x101e249L) || (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0x19a78c9L))
                                    {
                                          this.FLD_trang_bi_them_vao_cong_kich += (this.FLD_trang_bi_them_vao_cong_kich * 8L) / 100L;
                                          this.FLD_trang_bi_them_vao_phong_ngu += 15L;
                                    }
                                    if ((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0x101e24aL) || (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0x19a78caL))
                                    {
                                          this.FLD_trang_bi_them_vao_cong_kich += (this.FLD_trang_bi_them_vao_cong_kich * 9L) / 100L;
                                          this.FLD_trang_bi_them_vao_phong_ngu += 0x12L;
                                    }
                                    if ((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0x101e24bL) || (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0x19a78cbL))
                                    {
                                          this.FLD_trang_bi_them_vao_cong_kich += (this.FLD_trang_bi_them_vao_cong_kich * 10L) / 100L;
                                          this.FLD_trang_bi_them_vao_phong_ngu += 0x15L;
                                    }
                                    if ((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0x101e24cL) || (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0x19a78ccL))
                                    {
                                          this.FLD_trang_bi_them_vao_cong_kich += (this.FLD_trang_bi_them_vao_cong_kich * 11L) / 100L;
                                          this.FLD_trang_bi_them_vao_phong_ngu += 0x18L;
                                    }
                                    if ((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0x101e24dL) || (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0x19a78cdL))
                                    {
                                          this.FLD_trang_bi_them_vao_cong_kich += (this.FLD_trang_bi_them_vao_cong_kich * 12L) / 100L;
                                          this.FLD_trang_bi_them_vao_phong_ngu += 0x1bL;
                                    }
                                    if ((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0x101e253L) || (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0x19a78d3L))
                                    {
                                          this.FLD_trang_bi_them_vao_cong_kich += (this.FLD_trang_bi_them_vao_cong_kich * 8L) / 100L;
                                          this.FLD_trang_bi_them_vao_phong_ngu += 15L;
                                    }
                                    if ((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0x101e254L) || (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0x19a78d4L))
                                    {
                                          this.FLD_trang_bi_them_vao_cong_kich += (this.FLD_trang_bi_them_vao_cong_kich * 9L) / 100L;
                                          this.FLD_trang_bi_them_vao_phong_ngu += 0x12L;
                                    }
                                    if ((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0x101e255L) || (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0x19a78d5L))
                                    {
                                          this.FLD_trang_bi_them_vao_cong_kich += (this.FLD_trang_bi_them_vao_cong_kich * 10L) / 100L;
                                          this.FLD_trang_bi_them_vao_phong_ngu += 0x15L;
                                    }
                                    if ((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0x101e256L) || (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0x19a78d6L))
                                    {
                                          this.FLD_trang_bi_them_vao_cong_kich += (this.FLD_trang_bi_them_vao_cong_kich * 11L) / 100L;
                                          this.FLD_trang_bi_them_vao_phong_ngu += 0x18L;
                                    }
                                    if ((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0x101e257L) || (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == 0x19a78d7L))
                                    {
                                          this.FLD_trang_bi_them_vao_cong_kich += (this.FLD_trang_bi_them_vao_cong_kich * 11L) / 100L;
                                          this.FLD_trang_bi_them_vao_phong_ngu += 0x18L;
                                    }
                                    if ((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == World.Costume1) || (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].GetItem_ID == World.Costume2))
                                    {
                                          this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                                          this.FLD_trang_bi_them_vao_HP += 500;
                                          this.FLD_trang_bi_them_vao_MP += 300;
                                          this.FLD_trang_bi_them_vao_Khi_cong += 3;
                                          this.FLD_trang_bi_them_vao_kinh_nghiem_ti_le_phan_tram += 0.2;
                                          this.FLD_trang_bi_them_vao_cong_kich += (this.FLD_trang_bi_them_vao_cong_kich * 5L) / 100L;
                                          this.FLD_trang_bi_them_vao_phong_ngu += (this.FLD_trang_bi_them_vao_phong_ngu * 10L) / 100L;
                                    }
                              }
                              if ((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon <= 0x33) && (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon >= 0x2f))
                              {
                                    this.int_115 = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon - 0x2e;
                              }
                              else if ((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon <= 0x2e) && (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon >= 0x2a))
                              {
                                    this.int_114 = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon - 0x29;
                              }
                              else if ((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon <= 0x29) && (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon >= 0x25))
                              {
                                    this.int_113 = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon - 0x24;
                              }
                              else if ((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon <= 0x24) && (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon >= 0x22))
                              {
                                    this.int_112 = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon - 0x21;
                              }
                              else if ((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon <= 0x21) && (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon >= 0x1f))
                              {
                                    this.int_111 = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon - 30;
                              }
                              else if ((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon <= 30) && (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon >= 0x1c))
                              {
                                    this.int_110 = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon - 0x1b;
                              }
                              else if ((this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon <= 0x1b) && (this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon >= 0x17))
                              {
                                    this.int_109 = this.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[i].FLD_FJ_trung_cap_phu_hon - 0x16;
                              }
                        }
                        switch (num2)
                        {
                              case 2:
                                    this.FLD_trang_bi_them_vao_phong_ngu += 20L;
                                    break;

                              case 3:
                                    this.FLD_trang_bi_them_vao_phong_ngu += 20L;
                                    this.FLD_NHAN_VAT_KHI_CONG_LUC_PHONG_NGU_VO_CONG_TANG_CUONG_TI_LE_PHAN_TRAM += 0.02;
                                    break;

                              case 4:
                                    this.FLD_trang_bi_them_vao_phong_ngu += 20L;
                                    this.FLD_NHAN_VAT_KHI_CONG_LUC_PHONG_NGU_VO_CONG_TANG_CUONG_TI_LE_PHAN_TRAM += 0.02;
                                    this.FLD_NHAN_VAT_KHI_CONG_LUC_CONG_KICH_VO_CONG_TANG_CUONG_TI_LE_PHAN_TRAM += 0.05;
                                    break;

                              case 5:
                                    this.FLD_trang_bi_them_vao_phong_ngu += 20L;
                                    this.FLD_trang_bi_them_vao_cong_kich += 20L;
                                    this.FLD_trang_bi_them_vao_HP += 200;
                                    this.FLD_NHAN_VAT_KHI_CONG_LUC_PHONG_NGU_VO_CONG_TANG_CUONG_TI_LE_PHAN_TRAM += 0.02;
                                    this.FLD_NHAN_VAT_KHI_CONG_LUC_CONG_KICH_VO_CONG_TANG_CUONG_TI_LE_PHAN_TRAM += 0.05;
                                    break;
                        }
                        if (num4 == 3)
                        {
                              this.FLD_trang_bi_them_vao_HP += 80;
                              this.FLD_trang_bi_them_vao_cong_kich += 10L;
                              this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.09;
                        }
                        if (num >= 2)
                        {
                              switch (this.Player_Job)
                              {
                                    case 1:
                                    case 8:
                                          switch (num)
                                          {
                                                case 2:
                                                      goto Label_2471;

                                                case 3:
                                                      goto Label_2486;

                                                case 4:
                                                      goto Label_24B1;

                                                case 5:
                                                      goto Label_24EB;
                                          }
                                          break;

                                    case 2:
                                          switch (num)
                                          {
                                                case 2:
                                                      goto Label_1E19;

                                                case 3:
                                                      goto Label_1E3D;

                                                case 4:
                                                      goto Label_1E77;

                                                case 5:
                                                      goto Label_1EC3;
                                          }
                                          break;

                                    case 3:
                                          switch (num)
                                          {
                                                case 2:
                                                      goto Label_1F25;

                                                case 3:
                                                      goto Label_1F4A;

                                                case 4:
                                                      goto Label_1F85;

                                                case 5:
                                                      goto Label_1FD2;
                                          }
                                          break;

                                    case 4:
                                          switch (num)
                                          {
                                                case 2:
                                                      goto Label_2035;

                                                case 3:
                                                      goto Label_2059;

                                                case 4:
                                                      goto Label_2093;

                                                case 5:
                                                      goto Label_20DF;
                                          }
                                          break;

                                    case 5:
                                          switch (num)
                                          {
                                                case 2:
                                                      goto Label_2141;

                                                case 3:
                                                      goto Label_2165;

                                                case 4:
                                                      goto Label_219F;

                                                case 5:
                                                      goto Label_21EB;
                                          }
                                          break;

                                    case 6:
                                          switch (num)
                                          {
                                                case 2:
                                                      goto Label_224D;

                                                case 3:
                                                      goto Label_2271;

                                                case 4:
                                                      goto Label_22AB;

                                                case 5:
                                                      goto Label_22F7;
                                          }
                                          break;

                                    case 7:
                                          switch (num)
                                          {
                                                case 2:
                                                      goto Label_2359;

                                                case 3:
                                                      goto Label_2380;

                                                case 4:
                                                      goto Label_23BD;

                                                case 5:
                                                      goto Label_240C;
                                          }
                                          break;
                              }
                        }
                        goto Label_2539;
                        Label_1E19:
                        this.FLD_trang_bi_them_vao_phong_ngu += 10L;
                        this.FLD_trang_bi_them_vao_ne_tranh += 20;
                        goto Label_2539;
                        Label_1E3D:
                        this.FLD_trang_bi_them_vao_phong_ngu += 10L;
                        this.FLD_trang_bi_them_vao_ne_tranh += 20;
                        this.FLD_trang_bi_them_vao_kiem_khach_Truong_hong_quan_nhat += 2.0;
                        goto Label_2539;
                        Label_1E77:
                        this.FLD_trang_bi_them_vao_phong_ngu += 10L;
                        this.FLD_trang_bi_them_vao_ne_tranh += 20;
                        this.FLD_trang_bi_them_vao_kiem_khach_Truong_hong_quan_nhat += 2.0;
                        int num11 = this.FLD_trang_bi_them_vao_Khi_cong;
                        this.FLD_trang_bi_them_vao_Khi_cong = num11 + 1;
                        goto Label_2539;
                        Label_1EC3:
                        this.FLD_trang_bi_them_vao_phong_ngu += 10L;
                        this.FLD_trang_bi_them_vao_ne_tranh += 20;
                        this.FLD_trang_bi_them_vao_kiem_khach_Truong_hong_quan_nhat += 2.0;
                        num11 = this.FLD_trang_bi_them_vao_Khi_cong;
                        this.FLD_trang_bi_them_vao_Khi_cong = num11 + 1;
                        this.FLD_trang_bi_them_vao_kiem_khach_No_hai_cuong_lan += 2.0;
                        goto Label_2539;
                        Label_1F25:
                        this.FLD_trang_bi_them_vao_cong_kich += 10L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 20L;
                        goto Label_2539;
                        Label_1F4A:
                        this.FLD_trang_bi_them_vao_cong_kich += 10L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 20L;
                        this.FLD_trang_bi_them_vao_thuong_khach_Kim_chung_trao_khi += 2.0;
                        goto Label_2539;
                        Label_1F85:
                        this.FLD_trang_bi_them_vao_cong_kich += 10L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 20L;
                        this.FLD_trang_bi_them_vao_thuong_khach_Kim_chung_trao_khi += 2.0;
                        num11 = this.FLD_trang_bi_them_vao_Khi_cong;
                        this.FLD_trang_bi_them_vao_Khi_cong = num11 + 1;
                        goto Label_2539;
                        Label_1FD2:
                        this.FLD_trang_bi_them_vao_cong_kich += 10L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 20L;
                        this.FLD_trang_bi_them_vao_thuong_khach_Kim_chung_trao_khi += 2.0;
                        num11 = this.FLD_trang_bi_them_vao_Khi_cong;
                        this.FLD_trang_bi_them_vao_Khi_cong = num11 + 1;
                        this.FLD_trang_bi_them_vao_thuong_khach_Cuong_than_giang_the += 2.0;
                        goto Label_2539;
                        Label_2035:
                        this.FLD_trang_bi_them_vao_phong_ngu += 10L;
                        this.FLD_trang_bi_them_vao_trung_muc_tieu += 20;
                        goto Label_2539;
                        Label_2059:
                        this.FLD_trang_bi_them_vao_phong_ngu += 10L;
                        this.FLD_trang_bi_them_vao_trung_muc_tieu += 20;
                        this.FLD_trang_bi_them_vao_cung_thu_Bach_bo_xuyen_duong += 2.0;
                        goto Label_2539;
                        Label_2093:
                        this.FLD_trang_bi_them_vao_phong_ngu += 10L;
                        this.FLD_trang_bi_them_vao_trung_muc_tieu += 20;
                        this.FLD_trang_bi_them_vao_cung_thu_Bach_bo_xuyen_duong += 2.0;
                        num11 = this.FLD_trang_bi_them_vao_Khi_cong;
                        this.FLD_trang_bi_them_vao_Khi_cong = num11 + 1;
                        goto Label_2539;
                        Label_20DF:
                        this.FLD_trang_bi_them_vao_phong_ngu += 10L;
                        this.FLD_trang_bi_them_vao_trung_muc_tieu += 20;
                        this.FLD_trang_bi_them_vao_cung_thu_Bach_bo_xuyen_duong += 2.0;
                        num11 = this.FLD_trang_bi_them_vao_Khi_cong;
                        this.FLD_trang_bi_them_vao_Khi_cong = num11 + 1;
                        this.FLD_trang_bi_them_vao_cung_thu_Due_loi_chi_tien += 2.0;
                        goto Label_2539;
                        Label_2141:
                        this.FLD_trang_bi_them_vao_HP += 100;
                        this.FLD_trang_bi_them_vao_phong_ngu += 10L;
                        goto Label_2539;
                        Label_2165:
                        this.FLD_trang_bi_them_vao_HP += 100;
                        this.FLD_trang_bi_them_vao_phong_ngu += 10L;
                        this.FLD_trang_bi_them_vao_y_the_huyet_boi_tang += 2.0;
                        goto Label_2539;
                        Label_219F:
                        this.FLD_trang_bi_them_vao_HP += 100;
                        this.FLD_trang_bi_them_vao_phong_ngu += 10L;
                        this.FLD_trang_bi_them_vao_y_the_huyet_boi_tang += 2.0;
                        num11 = this.FLD_trang_bi_them_vao_Khi_cong;
                        this.FLD_trang_bi_them_vao_Khi_cong = num11 + 1;
                        goto Label_2539;
                        Label_21EB:
                        this.FLD_trang_bi_them_vao_HP += 100;
                        this.FLD_trang_bi_them_vao_phong_ngu += 10L;
                        this.FLD_trang_bi_them_vao_y_the_huyet_boi_tang += 2.0;
                        num11 = this.FLD_trang_bi_them_vao_Khi_cong;
                        this.FLD_trang_bi_them_vao_Khi_cong = num11 + 1;
                        this.FLD_trang_bi_them_vao_y_thien_huu_khi += 2.0;
                        goto Label_2539;
                        Label_224D:
                        this.FLD_trang_bi_them_vao_cong_kich += 10L;
                        this.FLD_trang_bi_them_vao_ne_tranh += 20;
                        goto Label_2539;
                        Label_2271:
                        this.FLD_trang_bi_them_vao_cong_kich += 10L;
                        this.FLD_trang_bi_them_vao_ne_tranh += 20;
                        this.FLD_trang_bi_them_vao_thich_khach_kinh_kha_chi_no += 2.0;
                        goto Label_2539;
                        Label_22AB:
                        this.FLD_trang_bi_them_vao_cong_kich += 10L;
                        this.FLD_trang_bi_them_vao_ne_tranh += 20;
                        this.FLD_trang_bi_them_vao_thich_khach_kinh_kha_chi_no += 2.0;
                        num11 = this.FLD_trang_bi_them_vao_Khi_cong;
                        this.FLD_trang_bi_them_vao_Khi_cong = num11 + 1;
                        goto Label_2539;
                        Label_22F7:
                        this.FLD_trang_bi_them_vao_cong_kich += 10L;
                        this.FLD_trang_bi_them_vao_ne_tranh += 20;
                        this.FLD_trang_bi_them_vao_thich_khach_kinh_kha_chi_no += 2.0;
                        num11 = this.FLD_trang_bi_them_vao_Khi_cong;
                        this.FLD_trang_bi_them_vao_Khi_cong = num11 + 1;
                        this.FLD_trang_bi_them_vao_thich_khach_Lien_tieu_dai_da += 2.0;
                        goto Label_2539;
                        Label_2359:
                        this.FLD_trang_bi_them_vao_cong_kich += 10L;
                        this.FLD_trang_bi_them_vao_MP += 200;
                        goto Label_2539;
                        Label_2380:
                        this.FLD_trang_bi_them_vao_cong_kich += 10L;
                        this.FLD_trang_bi_them_vao_MP += 200;
                        this.FLD_trang_bi_them_vao_Cam_su_Cam_thanh_qua_nguyet += 2.0;
                        goto Label_2539;
                        Label_23BD:
                        this.FLD_trang_bi_them_vao_cong_kich += 10L;
                        this.FLD_trang_bi_them_vao_MP += 200;
                        this.FLD_trang_bi_them_vao_Cam_su_Cam_thanh_qua_nguyet += 2.0;
                        num11 = this.FLD_trang_bi_them_vao_Khi_cong;
                        this.FLD_trang_bi_them_vao_Khi_cong = num11 + 1;
                        goto Label_2539;
                        Label_240C:
                        this.FLD_trang_bi_them_vao_cong_kich += 10L;
                        this.FLD_trang_bi_them_vao_MP += 200;
                        this.FLD_trang_bi_them_vao_Cam_su_Cam_thanh_qua_nguyet += 2.0;
                        num11 = this.FLD_trang_bi_them_vao_Khi_cong;
                        this.FLD_trang_bi_them_vao_Khi_cong = num11 + 1;
                        this.FLD_trang_bi_them_vao_cam_su_Loan_phuong_hoa_minh += 2.0;
                        goto Label_2539;
                        Label_2471:
                        this.FLD_trang_bi_them_vao_phong_ngu += 20L;
                        goto Label_2539;
                        Label_2486:
                        this.FLD_trang_bi_them_vao_phong_ngu += 20L;
                        this.FLD_trang_bi_them_vao_dao_khach_Luc_phach_hoa_son += 2.0;
                        goto Label_2539;
                        Label_24B1:
                        this.FLD_trang_bi_them_vao_phong_ngu += 20L;
                        this.FLD_trang_bi_them_vao_dao_khach_Luc_phach_hoa_son += 2.0;
                        num11 = this.FLD_trang_bi_them_vao_Khi_cong;
                        this.FLD_trang_bi_them_vao_Khi_cong = num11 + 1;
                        goto Label_2539;
                        Label_24EB:
                        this.FLD_trang_bi_them_vao_phong_ngu += 20L;
                        this.FLD_trang_bi_them_vao_dao_khach_Luc_phach_hoa_son += 2.0;
                        num11 = this.FLD_trang_bi_them_vao_Khi_cong;
                        this.FLD_trang_bi_them_vao_Khi_cong = num11 + 1;
                        this.FLD_trang_bi_them_vao_dao_khach_Am_anh_tuyet_sat += 2.0;
                        Label_2539:
                        if (num3 >= 2)
                        {
                              switch (this.Player_Job)
                              {
                                    case 1:
                                    case 5:
                                          switch (num3)
                                          {
                                                case 2:
                                                      goto Label_25FE;

                                                case 3:
                                                      goto Label_2612;

                                                case 4:
                                                      goto Label_2627;

                                                case 5:
                                                      goto Label_2662;

                                                case 6:
                                                      goto Label_26AF;
                                          }
                                          break;

                                    case 2:
                                    case 3:
                                    case 7:
                                          switch (num3)
                                          {
                                                case 2:
                                                      goto Label_27FA;

                                                case 3:
                                                      goto Label_280E;

                                                case 4:
                                                      goto Label_2823;

                                                case 5:
                                                      goto Label_285E;

                                                case 6:
                                                      goto Label_28AB;
                                          }
                                          break;

                                    case 4:
                                    case 6:
                                          switch (num3)
                                          {
                                                case 2:
                                                      goto Label_26FC;

                                                case 3:
                                                      goto Label_2710;

                                                case 4:
                                                      goto Label_2725;

                                                case 5:
                                                      goto Label_2760;

                                                case 6:
                                                      goto Label_27AD;
                                          }
                                          break;

                                    case 8:
                                    case 9:
                                          switch (num3)
                                          {
                                                case 2:
                                                      goto Label_28F8;

                                                case 3:
                                                      goto Label_290C;

                                                case 4:
                                                      goto Label_2921;

                                                case 5:
                                                      goto Label_295C;

                                                case 6:
                                                      goto Label_29A3;
                                          }
                                          break;
                              }
                        }
                        goto Label_29E8;
                        Label_25FE:
                        this.FLD_trang_bi_them_vao_cong_kich += 5L;
                        goto Label_29E8;
                        Label_2612:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        goto Label_29E8;
                        Label_2627:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 10L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        goto Label_29E8;
                        Label_2662:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 10L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        this.FLD_trang_bi_them_vao_HP += 300;
                        goto Label_29E8;
                        Label_26AF:
                        this.FLD_trang_bi_them_vao_cong_kich += 0x4bL;
                        this.FLD_trang_bi_them_vao_phong_ngu += 10L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        this.FLD_trang_bi_them_vao_HP += 300;
                        goto Label_29E8;
                        Label_26FC:
                        this.FLD_trang_bi_them_vao_cong_kich += 5L;
                        goto Label_29E8;
                        Label_2710:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        goto Label_29E8;
                        Label_2725:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 10L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        goto Label_29E8;
                        Label_2760:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 10L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        this.FLD_trang_bi_them_vao_HP += 300;
                        goto Label_29E8;
                        Label_27AD:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 10L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.3;
                        this.FLD_trang_bi_them_vao_HP += 300;
                        goto Label_29E8;
                        Label_27FA:
                        this.FLD_trang_bi_them_vao_cong_kich += 5L;
                        goto Label_29E8;
                        Label_280E:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        goto Label_29E8;
                        Label_2823:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 10L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        goto Label_29E8;
                        Label_285E:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 10L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        this.FLD_trang_bi_them_vao_HP += 300;
                        goto Label_29E8;
                        Label_28AB:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 60L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        this.FLD_trang_bi_them_vao_HP += 300;
                        goto Label_29E8;
                        Label_28F8:
                        this.FLD_trang_bi_them_vao_cong_kich += 5L;
                        goto Label_29E8;
                        Label_290C:
                        this.FLD_trang_bi_them_vao_cong_kich += 12L;
                        goto Label_29E8;
                        Label_2921:
                        this.FLD_trang_bi_them_vao_cong_kich += 12L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 20L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        goto Label_29E8;
                        Label_295C:
                        this.FLD_trang_bi_them_vao_cong_kich += 12L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 20L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        this.FLD_trang_bi_them_vao_HP += 50;
                        goto Label_29E8;
                        Label_29A3:
                        this.FLD_trang_bi_them_vao_cong_kich += 0x4bL;
                        this.FLD_trang_bi_them_vao_phong_ngu += 20L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        this.FLD_trang_bi_them_vao_HP += 50;
                        Label_29E8:
                        if (num5 >= 2)
                        {
                              switch (this.Player_Job)
                              {
                                    case 1:
                                    case 2:
                                    case 3:
                                          switch (num5)
                                          {
                                                case 2:
                                                      goto Label_2AD4;

                                                case 3:
                                                      goto Label_2AE8;

                                                case 4:
                                                      goto Label_2AFD;

                                                case 5:
                                                      goto Label_2B38;

                                                case 6:
                                                      goto Label_2B85;
                                          }
                                          break;

                                    case 4:
                                    case 6:
                                          switch (num5)
                                          {
                                                case 2:
                                                      goto Label_2CF4;

                                                case 3:
                                                      goto Label_2D08;

                                                case 4:
                                                      goto Label_2D1D;

                                                case 5:
                                                      goto Label_2D42;

                                                case 6:
                                                      goto Label_2D79;
                                          }
                                          break;

                                    case 5:
                                          switch (num5)
                                          {
                                                case 2:
                                                      goto Label_2BD2;

                                                case 3:
                                                      goto Label_2BE6;

                                                case 4:
                                                      goto Label_2BFB;

                                                case 5:
                                                      goto Label_2C36;

                                                case 6:
                                                      goto Label_2C95;
                                          }
                                          break;

                                    case 7:
                                          switch (num5)
                                          {
                                                case 2:
                                                      goto Label_2DC6;

                                                case 3:
                                                      goto Label_2DDA;

                                                case 4:
                                                      goto Label_2DEF;

                                                case 5:
                                                      goto Label_2E2A;

                                                case 6:
                                                      goto Label_2E89;
                                          }
                                          break;

                                    case 8:
                                    case 9:
                                          switch (num5)
                                          {
                                                case 2:
                                                      goto Label_2EE8;

                                                case 3:
                                                      goto Label_2EFC;

                                                case 4:
                                                      goto Label_2F11;

                                                case 5:
                                                      goto Label_2F4C;

                                                case 6:
                                                      goto Label_2F93;
                                          }
                                          break;
                              }
                        }
                        goto Label_2FD8;
                        Label_2AD4:
                        this.FLD_trang_bi_them_vao_cong_kich += 5L;
                        goto Label_2FD8;
                        Label_2AE8:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        goto Label_2FD8;
                        Label_2AFD:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 30L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        goto Label_2FD8;
                        Label_2B38:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 30L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        this.FLD_trang_bi_them_vao_HP += 400;
                        goto Label_2FD8;
                        Label_2B85:
                        this.FLD_trang_bi_them_vao_cong_kich += 0x19L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 60L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        this.FLD_trang_bi_them_vao_HP += 400;
                        goto Label_2FD8;
                        Label_2BD2:
                        this.FLD_trang_bi_them_vao_cong_kich += 5L;
                        goto Label_2FD8;
                        Label_2BE6:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        goto Label_2FD8;
                        Label_2BFB:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 30L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        goto Label_2FD8;
                        Label_2C36:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 30L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        this.FLD_trang_bi_them_vao_HP += 300;
                        this.FLD_trang_bi_them_vao_MP += 0x3e8;
                        goto Label_2FD8;
                        Label_2C95:
                        this.FLD_trang_bi_them_vao_cong_kich += 0x4bL;
                        this.FLD_trang_bi_them_vao_phong_ngu += 30L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        this.FLD_trang_bi_them_vao_HP += 300;
                        this.FLD_trang_bi_them_vao_MP += 0x3e8;
                        goto Label_2FD8;
                        Label_2CF4:
                        this.FLD_trang_bi_them_vao_cong_kich += 5L;
                        goto Label_2FD8;
                        Label_2D08:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        goto Label_2FD8;
                        Label_2D1D:
                        this.FLD_trang_bi_them_vao_cong_kich += 0x23L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 30L;
                        goto Label_2FD8;
                        Label_2D42:
                        this.FLD_trang_bi_them_vao_cong_kich += 0x23L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 30L;
                        this.FLD_trang_bi_them_vao_HP += 400;
                        goto Label_2FD8;
                        Label_2D79:
                        this.FLD_trang_bi_them_vao_cong_kich += 0x2dL;
                        this.FLD_trang_bi_them_vao_phong_ngu += 30L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.2;
                        this.FLD_trang_bi_them_vao_HP += 400;
                        goto Label_2FD8;
                        Label_2DC6:
                        this.FLD_trang_bi_them_vao_cong_kich += 5L;
                        goto Label_2FD8;
                        Label_2DDA:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        goto Label_2FD8;
                        Label_2DEF:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 30L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        goto Label_2FD8;
                        Label_2E2A:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 30L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        this.FLD_trang_bi_them_vao_HP += 300;
                        this.FLD_trang_bi_them_vao_MP += 0x3e8;
                        goto Label_2FD8;
                        Label_2E89:
                        this.FLD_trang_bi_them_vao_cong_kich += 0x19L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 80L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        this.FLD_trang_bi_them_vao_HP += 300;
                        this.FLD_trang_bi_them_vao_MP += 0x3e8;
                        goto Label_2FD8;
                        Label_2EE8:
                        this.FLD_trang_bi_them_vao_cong_kich += 5L;
                        goto Label_2FD8;
                        Label_2EFC:
                        this.FLD_trang_bi_them_vao_cong_kich += 12L;
                        goto Label_2FD8;
                        Label_2F11:
                        this.FLD_trang_bi_them_vao_cong_kich += 12L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 30L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        goto Label_2FD8;
                        Label_2F4C:
                        this.FLD_trang_bi_them_vao_cong_kich += 12L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 30L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        this.FLD_trang_bi_them_vao_HP += 100;
                        goto Label_2FD8;
                        Label_2F93:
                        this.FLD_trang_bi_them_vao_cong_kich += 0x4bL;
                        this.FLD_trang_bi_them_vao_phong_ngu += 30L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        this.FLD_trang_bi_them_vao_HP += 100;
                        Label_2FD8:
                        if (num6 >= 2)
                        {
                              switch (this.Player_Job)
                              {
                                    case 1:
                                          switch (num6)
                                          {
                                                case 2:
                                                      goto Label_3108;

                                                case 3:
                                                      goto Label_311C;

                                                case 4:
                                                      goto Label_3131;

                                                case 5:
                                                      goto Label_316C;

                                                case 6:
                                                      goto Label_31B9;
                                          }
                                          break;

                                    case 2:
                                    case 3:
                                          switch (num6)
                                          {
                                                case 2:
                                                      goto Label_3206;

                                                case 3:
                                                      goto Label_321A;

                                                case 4:
                                                      goto Label_322F;

                                                case 5:
                                                      goto Label_326A;

                                                case 6:
                                                      goto Label_32B7;
                                          }
                                          break;

                                    case 4:
                                          switch (num6)
                                          {
                                                case 2:
                                                      goto Label_3304;

                                                case 3:
                                                      goto Label_3318;

                                                case 4:
                                                      goto Label_332D;

                                                case 5:
                                                      goto Label_3352;

                                                case 6:
                                                      goto Label_3389;
                                          }
                                          break;

                                    case 5:
                                          switch (num6)
                                          {
                                                case 2:
                                                      goto Label_33D6;

                                                case 3:
                                                      goto Label_33EA;

                                                case 4:
                                                      goto Label_33FF;

                                                case 5:
                                                      goto Label_343A;

                                                case 6:
                                                      goto Label_3499;
                                          }
                                          break;

                                    case 6:
                                          switch (num6)
                                          {
                                                case 2:
                                                      goto Label_34F8;

                                                case 3:
                                                      goto Label_350C;

                                                case 4:
                                                      goto Label_3521;

                                                case 5:
                                                      goto Label_3546;

                                                case 6:
                                                      goto Label_357D;
                                          }
                                          break;

                                    case 7:
                                          switch (num6)
                                          {
                                                case 2:
                                                      goto Label_35CA;

                                                case 3:
                                                      goto Label_35DE;

                                                case 4:
                                                      goto Label_35F3;

                                                case 5:
                                                      goto Label_362E;

                                                case 6:
                                                      goto Label_368D;
                                          }
                                          break;

                                    case 8:
                                    case 9:
                                          switch (num6)
                                          {
                                                case 2:
                                                      goto Label_36EC;

                                                case 3:
                                                      goto Label_3700;

                                                case 4:
                                                      goto Label_3715;

                                                case 5:
                                                      goto Label_3750;

                                                case 6:
                                                      goto Label_379A;
                                          }
                                          break;
                              }
                        }
                        goto Label_37E2;
                        Label_3108:
                        this.FLD_trang_bi_them_vao_cong_kich += 5L;
                        goto Label_37E2;
                        Label_311C:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        goto Label_37E2;
                        Label_3131:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 40L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        goto Label_37E2;
                        Label_316C:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 40L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        this.FLD_trang_bi_them_vao_HP += 500;
                        goto Label_37E2;
                        Label_31B9:
                        this.FLD_trang_bi_them_vao_cong_kich += 0x4bL;
                        this.FLD_trang_bi_them_vao_phong_ngu += 40L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        this.FLD_trang_bi_them_vao_HP += 500;
                        goto Label_37E2;
                        Label_3206:
                        this.FLD_trang_bi_them_vao_cong_kich += 5L;
                        goto Label_37E2;
                        Label_321A:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        goto Label_37E2;
                        Label_322F:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 40L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        goto Label_37E2;
                        Label_326A:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 40L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        this.FLD_trang_bi_them_vao_HP += 500;
                        goto Label_37E2;
                        Label_32B7:
                        this.FLD_trang_bi_them_vao_cong_kich += 0x19L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 90L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        this.FLD_trang_bi_them_vao_HP += 500;
                        goto Label_37E2;
                        Label_3304:
                        this.FLD_trang_bi_them_vao_cong_kich += 5L;
                        goto Label_37E2;
                        Label_3318:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        goto Label_37E2;
                        Label_332D:
                        this.FLD_trang_bi_them_vao_cong_kich += 0x23L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 40L;
                        goto Label_37E2;
                        Label_3352:
                        this.FLD_trang_bi_them_vao_cong_kich += 0x23L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 40L;
                        this.FLD_trang_bi_them_vao_HP += 500;
                        goto Label_37E2;
                        Label_3389:
                        this.FLD_trang_bi_them_vao_cong_kich += 0x2dL;
                        this.FLD_trang_bi_them_vao_phong_ngu += 40L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.2;
                        this.FLD_trang_bi_them_vao_HP += 500;
                        goto Label_37E2;
                        Label_33D6:
                        this.FLD_trang_bi_them_vao_cong_kich += 5L;
                        goto Label_37E2;
                        Label_33EA:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        goto Label_37E2;
                        Label_33FF:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 40L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        goto Label_37E2;
                        Label_343A:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 40L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        this.FLD_trang_bi_them_vao_HP += 400;
                        this.FLD_trang_bi_them_vao_MP += 0x3e8;
                        goto Label_37E2;
                        Label_3499:
                        this.FLD_trang_bi_them_vao_cong_kich += 0x4bL;
                        this.FLD_trang_bi_them_vao_phong_ngu += 40L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        this.FLD_trang_bi_them_vao_HP += 400;
                        this.FLD_trang_bi_them_vao_MP += 0x3e8;
                        goto Label_37E2;
                        Label_34F8:
                        this.FLD_trang_bi_them_vao_cong_kich += 5L;
                        goto Label_37E2;
                        Label_350C:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        goto Label_37E2;
                        Label_3521:
                        this.FLD_trang_bi_them_vao_cong_kich += 0x23L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 40L;
                        goto Label_37E2;
                        Label_3546:
                        this.FLD_trang_bi_them_vao_cong_kich += 0x23L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 40L;
                        this.FLD_trang_bi_them_vao_HP += 500;
                        goto Label_37E2;
                        Label_357D:
                        this.FLD_trang_bi_them_vao_cong_kich += 0x2dL;
                        this.FLD_trang_bi_them_vao_phong_ngu += 90L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.2;
                        this.FLD_trang_bi_them_vao_HP += 500;
                        goto Label_37E2;
                        Label_35CA:
                        this.FLD_trang_bi_them_vao_cong_kich += 5L;
                        goto Label_37E2;
                        Label_35DE:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        goto Label_37E2;
                        Label_35F3:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 40L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        goto Label_37E2;
                        Label_362E:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 40L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        this.FLD_trang_bi_them_vao_HP += 400;
                        this.FLD_trang_bi_them_vao_MP += 0x3e8;
                        goto Label_37E2;
                        Label_368D:
                        this.FLD_trang_bi_them_vao_cong_kich += 0x19L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 90L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        this.FLD_trang_bi_them_vao_HP += 400;
                        this.FLD_trang_bi_them_vao_MP += 0x3e8;
                        goto Label_37E2;
                        Label_36EC:
                        this.FLD_trang_bi_them_vao_cong_kich += 5L;
                        goto Label_37E2;
                        Label_3700:
                        this.FLD_trang_bi_them_vao_cong_kich += 12L;
                        goto Label_37E2;
                        Label_3715:
                        this.FLD_trang_bi_them_vao_cong_kich += 12L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 40L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        goto Label_37E2;
                        Label_3750:
                        this.FLD_trang_bi_them_vao_cong_kich += 12L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 40L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        this.FLD_trang_bi_them_vao_HP += 150;
                        goto Label_37E2;
                        Label_379A:
                        this.FLD_trang_bi_them_vao_cong_kich += 0x4bL;
                        this.FLD_trang_bi_them_vao_phong_ngu += 40L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        this.FLD_trang_bi_them_vao_HP += 150;
                        Label_37E2:
                        if (num7 >= 2)
                        {
                              switch (this.Player_Job)
                              {
                                    case 1:
                                          switch (num7)
                                          {
                                                case 2:
                                                      goto Label_3912;

                                                case 3:
                                                      goto Label_3926;

                                                case 4:
                                                      goto Label_393B;

                                                case 5:
                                                      goto Label_3976;

                                                case 6:
                                                      goto Label_39C3;
                                          }
                                          break;

                                    case 2:
                                    case 3:
                                          switch (num7)
                                          {
                                                case 2:
                                                      goto Label_3A10;

                                                case 3:
                                                      goto Label_3A24;

                                                case 4:
                                                      goto Label_3A39;

                                                case 5:
                                                      goto Label_3A74;

                                                case 6:
                                                      goto Label_3AC1;
                                          }
                                          break;

                                    case 4:
                                          switch (num7)
                                          {
                                                case 2:
                                                      goto Label_3B0E;

                                                case 3:
                                                      goto Label_3B22;

                                                case 4:
                                                      goto Label_3B37;

                                                case 5:
                                                      goto Label_3B5C;

                                                case 6:
                                                      goto Label_3B93;
                                          }
                                          break;

                                    case 5:
                                          switch (num7)
                                          {
                                                case 2:
                                                      goto Label_3BE0;

                                                case 3:
                                                      goto Label_3BF4;

                                                case 4:
                                                      goto Label_3C09;

                                                case 5:
                                                      goto Label_3C44;

                                                case 6:
                                                      goto Label_3CA3;
                                          }
                                          break;

                                    case 6:
                                          switch (num7)
                                          {
                                                case 2:
                                                      goto Label_3D02;

                                                case 3:
                                                      goto Label_3D16;

                                                case 4:
                                                      goto Label_3D2B;

                                                case 5:
                                                      goto Label_3D50;

                                                case 6:
                                                      goto Label_3D87;
                                          }
                                          break;

                                    case 7:
                                          switch (num7)
                                          {
                                                case 2:
                                                      goto Label_3DD4;

                                                case 3:
                                                      goto Label_3DE8;

                                                case 4:
                                                      goto Label_3DFD;

                                                case 5:
                                                      goto Label_3E38;

                                                case 6:
                                                      goto Label_3E97;
                                          }
                                          break;

                                    case 8:
                                    case 9:
                                          switch (num7)
                                          {
                                                case 2:
                                                      this.FLD_trang_bi_them_vao_cong_kich += 5L;
                                                      break;

                                                case 3:
                                                      this.FLD_trang_bi_them_vao_cong_kich += 12L;
                                                      break;

                                                case 4:
                                                      this.FLD_trang_bi_them_vao_cong_kich += 12L;
                                                      this.FLD_trang_bi_them_vao_phong_ngu += 40L;
                                                      this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                                                      break;

                                                case 5:
                                                      this.FLD_trang_bi_them_vao_cong_kich += 12L;
                                                      this.FLD_trang_bi_them_vao_phong_ngu += 40L;
                                                      this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                                                      this.FLD_trang_bi_them_vao_HP += 150;
                                                      break;

                                                case 6:
                                                      if (this.Player_Job != 8)
                                                      {
                                                            goto Label_3FFA;
                                                      }
                                                      this.FLD_trang_bi_them_vao_cong_kich += 0x4bL;
                                                      this.FLD_trang_bi_them_vao_phong_ngu += 40L;
                                                      this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                                                      this.FLD_trang_bi_them_vao_HP += 150;
                                                      break;
                                          }
                                          break;
                              }
                        }
                        goto Label_404E;
                        Label_3912:
                        this.FLD_trang_bi_them_vao_cong_kich += 5L;
                        goto Label_404E;
                        Label_3926:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        goto Label_404E;
                        Label_393B:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 40L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        goto Label_404E;
                        Label_3976:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 40L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        this.FLD_trang_bi_them_vao_HP += 500;
                        goto Label_404E;
                        Label_39C3:
                        this.FLD_trang_bi_them_vao_cong_kich += 0x4bL;
                        this.FLD_trang_bi_them_vao_phong_ngu += 40L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        this.FLD_trang_bi_them_vao_HP += 500;
                        goto Label_404E;
                        Label_3A10:
                        this.FLD_trang_bi_them_vao_cong_kich += 5L;
                        goto Label_404E;
                        Label_3A24:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        goto Label_404E;
                        Label_3A39:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 40L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        goto Label_404E;
                        Label_3A74:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 40L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        this.FLD_trang_bi_them_vao_HP += 500;
                        goto Label_404E;
                        Label_3AC1:
                        this.FLD_trang_bi_them_vao_cong_kich += 0x19L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 90L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        this.FLD_trang_bi_them_vao_HP += 500;
                        goto Label_404E;
                        Label_3B0E:
                        this.FLD_trang_bi_them_vao_cong_kich += 5L;
                        goto Label_404E;
                        Label_3B22:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        goto Label_404E;
                        Label_3B37:
                        this.FLD_trang_bi_them_vao_cong_kich += 0x23L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 40L;
                        goto Label_404E;
                        Label_3B5C:
                        this.FLD_trang_bi_them_vao_cong_kich += 0x23L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 40L;
                        this.FLD_trang_bi_them_vao_HP += 500;
                        goto Label_404E;
                        Label_3B93:
                        this.FLD_trang_bi_them_vao_cong_kich += 0x2dL;
                        this.FLD_trang_bi_them_vao_phong_ngu += 40L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.2;
                        this.FLD_trang_bi_them_vao_HP += 500;
                        goto Label_404E;
                        Label_3BE0:
                        this.FLD_trang_bi_them_vao_cong_kich += 5L;
                        goto Label_404E;
                        Label_3BF4:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        goto Label_404E;
                        Label_3C09:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 40L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        goto Label_404E;
                        Label_3C44:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 40L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        this.FLD_trang_bi_them_vao_HP += 400;
                        this.FLD_trang_bi_them_vao_MP += 0x3e8;
                        goto Label_404E;
                        Label_3CA3:
                        this.FLD_trang_bi_them_vao_cong_kich += 0x4bL;
                        this.FLD_trang_bi_them_vao_phong_ngu += 40L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        this.FLD_trang_bi_them_vao_HP += 400;
                        this.FLD_trang_bi_them_vao_MP += 0x3e8;
                        goto Label_404E;
                        Label_3D02:
                        this.FLD_trang_bi_them_vao_cong_kich += 5L;
                        goto Label_404E;
                        Label_3D16:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        goto Label_404E;
                        Label_3D2B:
                        this.FLD_trang_bi_them_vao_cong_kich += 0x23L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 40L;
                        goto Label_404E;
                        Label_3D50:
                        this.FLD_trang_bi_them_vao_cong_kich += 0x23L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 40L;
                        this.FLD_trang_bi_them_vao_HP += 500;
                        goto Label_404E;
                        Label_3D87:
                        this.FLD_trang_bi_them_vao_cong_kich += 0x2dL;
                        this.FLD_trang_bi_them_vao_phong_ngu += 90L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.2;
                        this.FLD_trang_bi_them_vao_HP += 500;
                        goto Label_404E;
                        Label_3DD4:
                        this.FLD_trang_bi_them_vao_cong_kich += 5L;
                        goto Label_404E;
                        Label_3DE8:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        goto Label_404E;
                        Label_3DFD:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 40L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        goto Label_404E;
                        Label_3E38:
                        this.FLD_trang_bi_them_vao_cong_kich += 15L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 40L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        this.FLD_trang_bi_them_vao_HP += 400;
                        this.FLD_trang_bi_them_vao_MP += 0x3e8;
                        goto Label_404E;
                        Label_3E97:
                        this.FLD_trang_bi_them_vao_cong_kich += 0x19L;
                        this.FLD_trang_bi_them_vao_phong_ngu += 90L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        this.FLD_trang_bi_them_vao_HP += 400;
                        this.FLD_trang_bi_them_vao_MP += 0x3e8;
                        goto Label_404E;
                        Label_3FFA:
                        this.FLD_trang_bi_them_vao_cong_kich += 0x4bL;
                        this.FLD_trang_bi_them_vao_phong_ngu += 90L;
                        this.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram += 0.1;
                        this.FLD_trang_bi_them_vao_HP += 150;
                  }
                  Label_404E:
                  this.Update_Qigong();
            }

            public void TINH_TOAN_VO_CHONG_LUC_CONG_KICH_SO_LIEU()
            {
                  if (this.class79_0[2, 0x10] != null)
                  {
                        List<int> list = new List<int>();
                        List<int> list2 = new List<int>();
                        for (int i = 0; i < 0x20; i++)
                        {
                              if (this.class79_0[3, i] != null)
                              {
                                    int item = this.class79_0[3, i].FLD_AT + (((this.class79_0[3, i].VO_CONG_THU_BAC - 1) * this.class79_0[3, i].FLD_MOI_CAP_THEM_NGUY_HAI) / World.Thang_thien_skill_Dang_cap_bo_tro);
                                    if (item > 0)
                                    {
                                          list.Add(item);
                                          int num3 = this.class79_0[3, i].FLD_MP + ((this.class79_0[3, i].VO_CONG_THU_BAC - 1) * this.class79_0[3, i].FLD_MOI_CAP_THEM_MP);
                                          list2.Add(num3);
                                    }
                              }
                        }
                        for (int j = 0; j < 0x20; j++)
                        {
                              if (this.class79_0[0, j] != null)
                              {
                                    int num5 = this.class79_0[0, j].FLD_AT + (((this.class79_0[0, j].VO_CONG_THU_BAC - 1) * this.class79_0[0, j].FLD_MOI_CAP_THEM_NGUY_HAI) / World.Thang_thien_skill_Dang_cap_bo_tro);
                                    if (num5 > 0)
                                    {
                                          list.Add(num5);
                                          list2.Add(this.class79_0[0, j].FLD_MP);
                                    }
                              }
                        }
                        int[] keys = list.ToArray();
                        int[] items = list2.ToArray();
                        Array.Sort<int, int>(keys, items);
                        if (keys.Length != 0)
                        {
                              this.Phu_the_vo_cong_luc_cong_kich = keys[keys.Length - 1];
                              this.Phu_the_vo_cong_luc_cong_kich_MP = items[items.Length - 1];
                        }
                  }
            }

            public void TO_DOI_TRUYEN_TONG_PHU_NHAC_NHO(int int_116)
            {
                  byte[] dst = Converter.hexStringToByte("AA55230001D001121614000106000078DC143C010000000100000009943577000000000000A65455AA");
                  Buffer.BlockCopy(BitConverter.GetBytes(int_116), 0, dst, 0x13, 2);
                  Buffer.BlockCopy(BitConverter.GetBytes(this.UserSessionID), 0, dst, 5, 2);
                  if (this.Client != null)
                  {
                        this.Client.Send(dst, dst.Length);
                  }
            }

            public VAT_PHAM_LOAI UNKNOWN_105(int int_116, int int_117, int int_118)
            {
                  if (int_117 == 3)
                  {
                        foreach (VAT_PHAM_LOAI vat_pham_loai in this.class23_0)
                        {
                              if ((BitConverter.ToInt32(vat_pham_loai.VAT_PHAM_ID, 0) == int_116) && (vat_pham_loai.FLD_MAGIC0 == int_118))
                              {
                                    return vat_pham_loai;
                              }
                        }
                  }
                  else
                  {
                        foreach (VAT_PHAM_LOAI vat_pham_loai2 in this.class23_1)
                        {
                              if ((BitConverter.ToInt32(vat_pham_loai2.VAT_PHAM_ID, 0) == int_116) && (vat_pham_loai2.FLD_MAGIC0 == int_118))
                              {
                                    return vat_pham_loai2;
                              }
                        }
                  }
                  return null;
            }

            public VAT_PHAM_LOAI UNKNOWN_107(Players class15_0, long long_16, int int_116)
            {
                  foreach (VAT_PHAM_LOAI vat_pham_loai in class15_0.TRANG_BI_LAN_BAO_VAY)
                  {
                        if ((vat_pham_loai.GetItem_toan_bo_ID == long_16) && (vat_pham_loai.FLD_MAGIC0 == int_116))
                        {
                              return vat_pham_loai;
                        }
                  }
                  return null;
            }

            public void UNKNOWN_97(string string_10, byte[] byte_5, int int_116)
            {
                  try
                  {
                        foreach (Players players in World.allConnectedChars.Values)
                        {
                              if ((players.GuildName == string_10) && (players.Client != null))
                              {
                                    players.Client.Send(byte_5, int_116);
                              }
                        }
                  }
                  catch
                  {
                  }
            }

            public void Update_Attack_Speed()
            {
                  using (PacketData data = new PacketData())
                  {
                        data.Write4(6);
                        data.method_2(0x88);
                        data.method_2(1);
                        data.method_2(0x58);
                        data.method_2(0);
                        data.Write4(this.FLD_cong_kich_toc_do);
                        if (this.Client != null)
                        {
                              this.Client.method_5(data, 0x620, this.UserSessionID, 0);
                        }
                        this.vmethod_2(data, 0x620, this.UserSessionID, 0);
                  }
            }

            public void Update_Data_Boardcast()
            {
                  try
                  {
                        PacketData data = this.CAP_NHAT_THAY_DOI_NHAN_VAT_SO_LIEU(this.Client.Player);
                        if (data != null)
                        {
                              this.vmethod_2(data, 0x6400, this.UserSessionID, 0);
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, string.Concat(new object[] { "更新广播人物数据 出错", this.Client.int_3, "|", this.Client.ToString(), " ", exception }));
                  }
            }

            public void Update_Figure_Data(Players class15_0)
            {
                  try
                  {
                        if (class15_0.Client != null)
                        {
                              PacketData data = this.CAP_NHAT_THAY_DOI_NHAN_VAT_SO_LIEU(class15_0);
                              if ((data != null) && (this.Client != null))
                              {
                                    this.Client.method_5(data, 0x6400, class15_0.UserSessionID, 0);
                              }
                              if (data.Length < 0xe0)
                              {
                                    string str = Converter.smethod_24(data.method_17());
                                    Console.WriteLine(data.Length + " " + str);
                                    Form1.WriteLine(100, string.Concat(new object[] { "更新人物数据", data.Length, " ", str }));
                              }
                              if (class15_0.PlayerShop != null)
                              {
                                    this.CAP_NHAT_CA_NHAN_CUA_HANG_SO_LIEU(class15_0);
                              }
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, string.Concat(new object[] { "更新人物数据 出错", this.Client.int_3, "|", this.Client.ToString(), " ", exception }));
                  }
            }

            public void Update_Production_System()
            {
                  List<int> list = CHE_TAO_ITEM_DANH_SACH.Get_CHE_TAO_ITEM_LOAI_DANH_SACH(this.FLD_CHE_TAO_LOAI_HINH, this.FLD_CHE_TAO_THU_BAC);
                  if ((list != null) && (list.Count > 0))
                  {
                        PacketData data = new PacketData();
                        data.Write2(list.Count);
                        foreach (int num in list)
                        {
                              data.method_8((long)num);
                              data.Write4(0x2710);
                              data.Write2(0);
                              data.Write2(1);
                              data.Write4(0);
                        }
                        if (this.Client != null)
                        {
                              this.Client.method_4(data, 0x3317, this.UserSessionID);
                        }
                  }
            }

            public void Update_Qigong()
            {
                  using (new Lock(this.object_2, "更新气功"))
                  {
                        this.Nhan_vat_khi_cong_them_vao_HP = 0;
                        this.Nhan_vat_khi_cong_them_vao_MP = 0;
                        this.FLD_QigqongAttack = 0;
                        this.FLD_NHAN_VAT_KHI_CONG_PHONG_NGU = 0;
                        this.FLD_NHAN_VAT_KHI_CONG_TRUNG_MUC_TIEU = 0;
                        this.FLD_NHAN_VAT_KHI_CONG_NE_TRANH = 0;
                        this.FLD_NHAN_VAT_KHI_CONG_LUC_CONG_KICH_VO_CONG_TANG_CUONG_TI_LE_PHAN_TRAM = 0.0;
                        this.FLD_NHAN_VAT_KHI_CONG_LUC_PHONG_NGU_VO_CONG_TANG_CUONG_TI_LE_PHAN_TRAM = 0.0;
                        if (World.KHI_CONG_CO_TAC_DUNG == 1)
                        {
                              for (int i = 0; i < 11; i++)
                              {
                                    byte[] buffer = this.Qigong[i].气功_byte;
                                    if ((buffer[0] == 0xff) || (BitConverter.ToInt16(buffer, 0) <= 0))
                                    {
                                          continue;
                                    }
                                    double num2 = ((BitConverter.ToInt16(buffer, 0) + this.FLD_trang_bi_them_vao_Khi_cong) + this.FLD_nhan_vat_them_vao_khi_cong) + this.FLD_Vo_huan_them_vao_khi_cong;
                                    switch (this.Player_Job)
                                    {
                                          case 1:
                                          case 8:
                                                switch (i)
                                                {
                                                      case 0:
                                                            goto Label_05CF;

                                                      case 1:
                                                            goto Label_05DD;

                                                      case 2:
                                                            goto Label_05EB;

                                                      case 3:
                                                            goto Label_05F9;

                                                      case 4:
                                                            goto Label_0607;

                                                      case 5:
                                                            goto Label_0615;

                                                      case 6:
                                                            goto Label_0623;

                                                      case 7:
                                                            goto Label_0631;

                                                      case 8:
                                                            goto Label_063F;

                                                      case 9:
                                                            goto Label_064A;
                                                }
                                                goto Label_06C1;

                                          case 2:
                                          case 9:
                                                switch (i)
                                                {
                                                      case 0:
                                                            goto Label_0655;

                                                      case 1:
                                                            goto Label_0660;

                                                      case 2:
                                                            goto Label_066B;

                                                      case 3:
                                                            goto Label_0676;

                                                      case 4:
                                                            goto Label_0681;

                                                      case 5:
                                                            goto Label_068C;

                                                      case 6:
                                                            goto Label_0697;

                                                      case 7:
                                                            goto Label_06A2;

                                                      case 8:
                                                            goto Label_06AD;

                                                      case 9:
                                                            goto Label_06B8;
                                                }
                                                goto Label_06C1;

                                          case 3:
                                                switch (i)
                                                {
                                                      case 1:
                                                            goto Label_0321;

                                                      case 2:
                                                            goto Label_032F;

                                                      case 3:
                                                            goto Label_033D;

                                                      case 4:
                                                            goto Label_034B;

                                                      case 5:
                                                            goto Label_0359;

                                                      case 6:
                                                            goto Label_0367;

                                                      case 7:
                                                            goto Label_0375;

                                                      case 8:
                                                            goto Label_0383;

                                                      case 9:
                                                            goto Label_0391;
                                                }
                                                goto Label_06C1;

                                          case 4:
                                                switch (i)
                                                {
                                                      case 0:
                                                            goto Label_039F;

                                                      case 1:
                                                            goto Label_03AD;

                                                      case 2:
                                                            goto Label_03BB;

                                                      case 3:
                                                            goto Label_03C9;

                                                      case 4:
                                                            goto Label_03D7;

                                                      case 5:
                                                            goto Label_03E5;

                                                      case 6:
                                                            goto Label_03F3;

                                                      case 7:
                                                            goto Label_0401;

                                                      case 8:
                                                            goto Label_040F;

                                                      case 9:
                                                            goto Label_041D;
                                                }
                                                goto Label_06C1;

                                          case 5:
                                                switch (i)
                                                {
                                                      case 0:
                                                            goto Label_042B;

                                                      case 1:
                                                            goto Label_0439;

                                                      case 2:
                                                            goto Label_0447;

                                                      case 3:
                                                            goto Label_0455;

                                                      case 4:
                                                            goto Label_0463;

                                                      case 5:
                                                            goto Label_0471;

                                                      case 6:
                                                            goto Label_047F;

                                                      case 7:
                                                            goto Label_048D;

                                                      case 8:
                                                            goto Label_049B;

                                                      case 9:
                                                            goto Label_04A9;
                                                }
                                                goto Label_06C1;

                                          case 6:
                                                switch (i)
                                                {
                                                      case 0:
                                                            goto Label_04B7;

                                                      case 1:
                                                            goto Label_04C5;

                                                      case 2:
                                                            goto Label_04D3;

                                                      case 3:
                                                            goto Label_04E1;

                                                      case 4:
                                                            goto Label_04EF;

                                                      case 5:
                                                            goto Label_04FD;

                                                      case 6:
                                                            goto Label_050B;

                                                      case 7:
                                                            goto Label_0519;

                                                      case 8:
                                                            goto Label_0527;

                                                      case 9:
                                                            goto Label_0535;
                                                }
                                                goto Label_06C1;

                                          case 7:
                                                switch (i)
                                                {
                                                      case 0:
                                                            goto Label_0543;

                                                      case 1:
                                                            goto Label_0551;

                                                      case 2:
                                                            goto Label_055F;

                                                      case 3:
                                                            goto Label_056D;

                                                      case 4:
                                                            goto Label_057B;

                                                      case 5:
                                                            goto Label_0589;

                                                      case 6:
                                                            goto Label_0597;

                                                      case 7:
                                                            goto Label_05A5;

                                                      case 8:
                                                            goto Label_05B3;

                                                      case 9:
                                                            goto Label_05C1;
                                                }
                                                goto Label_06C1;

                                          case 10:
                                                switch (i)
                                                {
                                                      case 0:
                                                            goto Label_0295;

                                                      case 1:
                                                            goto Label_02A3;

                                                      case 2:
                                                            goto Label_02B1;

                                                      case 3:
                                                            goto Label_02BF;

                                                      case 4:
                                                            goto Label_02CD;

                                                      case 5:
                                                            goto Label_02DB;

                                                      case 6:
                                                            goto Label_02E9;

                                                      case 7:
                                                            goto Label_02F7;

                                                      case 8:
                                                            goto Label_0305;

                                                      case 9:
                                                            goto Label_0313;
                                                }
                                                goto Label_06C1;

                                          default:
                                                goto Label_06C1;
                                    }
                                    num2 += this.FLD_trang_bi_them_vao_thuong_khach_Kim_chung_trao_khi;
                                    goto Label_06C1;
                                    Label_0295:
                                    num2 += this.FLD_trang_bi_them_vao_quyen_su_cuong_than_giang_the;
                                    goto Label_06C1;
                                    Label_02A3:
                                    num2 += this.FLD_trang_bi_them_vao_quyen_su_van_may_chua_thuong;
                                    goto Label_06C1;
                                    Label_02B1:
                                    num2 += this.FLD_trang_bi_them_vao_quyen_su_suc_manh_phach_Hoa_Son;
                                    goto Label_06C1;
                                    Label_02BF:
                                    num2 += this.FLD_trang_bi_them_vao_quyen_su_cuong_phong_van_pha;
                                    goto Label_06C1;
                                    Label_02CD:
                                    num2 += this.FLD_trang_bi_them_vao_quyen_su_kim_cuong_bat_hoai;
                                    goto Label_06C1;
                                    Label_02DB:
                                    num2 += this.FLD_trang_bi_them_vao_quyen_su_doi_cong_lam_thu;
                                    goto Label_06C1;
                                    Label_02E9:
                                    num2 += this.FLD_trang_bi_them_vao_quyen_su_bang_hoa_mot_the;
                                    goto Label_06C1;
                                    Label_02F7:
                                    num2 += this.FLD_trang_bi_them_vao_quyen_su_hieu_y_mot_don;
                                    goto Label_06C1;
                                    Label_0305:
                                    num2 += this.FLD_trang_bi_them_vao_quyen_su_linh_giap_ho_than;
                                    goto Label_06C1;
                                    Label_0313:
                                    num2 += this.FLD_trang_bi_them_vao_quyen_su_mai_xu_thanh_cham;
                                    goto Label_06C1;
                                    Label_0321:
                                    num2 += this.FLD_trang_bi_them_vao_thuong_khach_Van_khi_lieu_thuong;
                                    goto Label_06C1;
                                    Label_032F:
                                    num2 += this.FLD_trang_bi_them_vao_thuong_khach_Lien_hoan_phi_vu;
                                    goto Label_06C1;
                                    Label_033D:
                                    num2 += this.FLD_trang_bi_them_vao_thuong_khach_Tat_sat_nhat_kich;
                                    goto Label_06C1;
                                    Label_034B:
                                    num2 += this.FLD_trang_bi_them_vao_thuong_khach_Cuong_phong_van_pha;
                                    goto Label_06C1;
                                    Label_0359:
                                    num2 += this.FLD_trang_bi_them_vao_thuong_khach_Hoanh_luyen_thai_bao;
                                    goto Label_06C1;
                                    Label_0367:
                                    num2 += this.FLD_trang_bi_them_vao_thuong_khach_Can_khon_na_di;
                                    goto Label_06C1;
                                    Label_0375:
                                    num2 += this.FLD_trang_bi_them_vao_thuong_khach_Linh_giap_ho_than;
                                    goto Label_06C1;
                                    Label_0383:
                                    num2 += this.FLD_trang_bi_them_vao_thuong_khach_Cuong_than_giang_the;
                                    goto Label_06C1;
                                    Label_0391:
                                    num2 += this.FLD_trang_bi_them_vao_thuong_khach_Chuyen_thu_vi_cong;
                                    goto Label_06C1;
                                    Label_039F:
                                    num2 += this.FLD_trang_bi_them_vao_cung_thu_Bach_bo_xuyen_duong;
                                    goto Label_06C1;
                                    Label_03AD:
                                    num2 += this.FLD_trang_bi_them_vao_cung_thu_Liep_ung_chi_nhan;
                                    goto Label_06C1;
                                    Label_03BB:
                                    num2 += this.FLD_trang_bi_them_vao_cung_thu_Ngung_than_tu_khi;
                                    goto Label_06C1;
                                    Label_03C9:
                                    num2 += this.FLD_trang_bi_them_vao_cung_thu_Tat_sat_nhat_kich;
                                    goto Label_06C1;
                                    Label_03D7:
                                    num2 += this.FLD_trang_bi_them_vao_cung_thu_Cuong_phong_van_pha;
                                    goto Label_06C1;
                                    Label_03E5:
                                    num2 += this.FLD_trang_bi_them_vao_cung_thu_Chinh_ban_boi_nguyen;
                                    goto Label_06C1;
                                    Label_03F3:
                                    num2 += this.FLD_trang_bi_them_vao_cung_thu_Tam_than_ngung_tu;
                                    goto Label_06C1;
                                    Label_0401:
                                    num2 += this.FLD_trang_bi_them_vao_cung_thu_Luu_tinh_tam_thi;
                                    goto Label_06C1;
                                    Label_040F:
                                    num2 += this.FLD_trang_bi_them_vao_cung_thu_Due_loi_chi_tien;
                                    goto Label_06C1;
                                    Label_041D:
                                    num2 += this.FLD_trang_bi_them_vao_cung_thu_Vo_minh_am_thi;
                                    goto Label_06C1;
                                    Label_042B:
                                    num2 += this.FLD_trang_bi_them_vao_y_van_may_hanh_tam;
                                    goto Label_06C1;
                                    Label_0439:
                                    num2 += this.FLD_trang_bi_them_vao_y_thai_cuc_tam_phap;
                                    goto Label_06C1;
                                    Label_0447:
                                    num2 += this.FLD_trang_bi_them_vao_y_the_huyet_boi_tang;
                                    goto Label_06C1;
                                    Label_0455:
                                    num2 += this.FLD_trang_bi_them_vao_y_tay_tuy_dich_kinh;
                                    goto Label_06C1;
                                    Label_0463:
                                    num2 += this.FLD_trang_bi_them_vao_y_dieu_thu_hoi_xuan;
                                    goto Label_06C1;
                                    Label_0471:
                                    num2 += this.FLD_trang_bi_them_vao_y_truong_cong_kich;
                                    goto Label_06C1;
                                    Label_047F:
                                    num2 += this.FLD_trang_bi_them_vao_y_hap_tinh_dai_phap;
                                    goto Label_06C1;
                                    Label_048D:
                                    num2 += this.FLD_trang_bi_them_vao_y_Than_Nong_tien_thuat;
                                    goto Label_06C1;
                                    Label_049B:
                                    num2 += this.FLD_trang_bi_them_vao_y_thien_huu_khi;
                                    goto Label_06C1;
                                    Label_04A9:
                                    num2 += this.FLD_trang_bi_them_vao_y_cuu_thien_chan_khi;
                                    goto Label_06C1;
                                    Label_04B7:
                                    num2 += this.FLD_trang_bi_them_vao_thich_khach_kinh_kha_chi_no;
                                    goto Label_06C1;
                                    Label_04C5:
                                    num2 += this.FLD_trang_bi_them_vao_thich_khach_Tam_hoa_tu_dinh;
                                    goto Label_06C1;
                                    Label_04D3:
                                    num2 += this.FLD_trang_bi_them_vao_thich_khach_Lien_hoan_phi_vu;
                                    goto Label_06C1;
                                    Label_04E1:
                                    num2 += this.FLD_trang_bi_them_vao_thich_khach_Tat_sat_nhat_kich;
                                    goto Label_06C1;
                                    Label_04EF:
                                    num2 += this.FLD_trang_bi_them_vao_thich_khach_Tam_than_ngung_tu;
                                    goto Label_06C1;
                                    Label_04FD:
                                    num2 += this.FLD_trang_bi_them_vao_thich_khach_Tri_menh_tuyet_thu;
                                    goto Label_06C1;
                                    Label_050B:
                                    num2 += this.FLD_trang_bi_them_vao_thich_khach_Tien_phat_che_nhan;
                                    goto Label_06C1;
                                    Label_0519:
                                    num2 += this.FLD_trang_bi_them_vao_thich_khach_Thien_chu_van_thu;
                                    goto Label_06C1;
                                    Label_0527:
                                    num2 += this.FLD_trang_bi_them_vao_thich_khach_Lien_tieu_dai_da;
                                    goto Label_06C1;
                                    Label_0535:
                                    num2 += this.FLD_trang_bi_them_vao_thich_khach_Kiem_nhan_loan_vu;
                                    goto Label_06C1;
                                    Label_0543:
                                    num2 += this.FLD_trang_bi_them_vao_Cam_su_chien_ma_bon_dang;
                                    goto Label_06C1;
                                    Label_0551:
                                    num2 += this.FLD_trang_bi_them_vao_cam_su_Thu_giang_da_bac;
                                    goto Label_06C1;
                                    Label_055F:
                                    num2 += this.FLD_trang_bi_them_vao_Cam_su_thanh_tam_pho_thien;
                                    goto Label_06C1;
                                    Label_056D:
                                    num2 += this.FLD_trang_bi_them_vao_cam_su_Duong_quan_tam_diep;
                                    goto Label_06C1;
                                    Label_057B:
                                    num2 += this.FLD_trang_bi_them_vao_cam_su_Han_cung_thu_nguyet;
                                    goto Label_06C1;
                                    Label_0589:
                                    num2 += this.FLD_trang_bi_them_vao_Cam_su_Tam_khuc_hoa_minh;
                                    goto Label_06C1;
                                    Label_0597:
                                    num2 += this.FLD_trang_bi_them_vao_Cam_su_Cam_thanh_qua_nguyet;
                                    goto Label_06C1;
                                    Label_05A5:
                                    num2 += this.FLD_trang_bi_them_vao_Cam_su_Nhat_am_xuat_kich;
                                    goto Label_06C1;
                                    Label_05B3:
                                    num2 += this.FLD_trang_bi_them_vao_cam_su_Loan_phuong_hoa_minh;
                                    goto Label_06C1;
                                    Label_05C1:
                                    num2 += this.FLD_trang_bi_them_vao_Cam_su_Sat_am_cam_khuc;
                                    goto Label_06C1;
                                    Label_05CF:
                                    num2 += this.FLD_trang_bi_them_vao_dao_khach_Luc_phach_hoa_son;
                                    goto Label_06C1;
                                    Label_05DD:
                                    num2 += this.FLD_trang_bi_them_vao_dao_khach_Nhiep_hon_nhat_kich;
                                    goto Label_06C1;
                                    Label_05EB:
                                    num2 += this.FLD_trang_bi_them_vao_dao_khach_Lien_hoan_phi_vu;
                                    goto Label_06C1;
                                    Label_05F9:
                                    num2 += this.FLD_trang_bi_them_vao_dao_khach_Tat_sat_nhat_kich;
                                    goto Label_06C1;
                                    Label_0607:
                                    num2 += this.FLD_trang_bi_them_vao_dao_khach_Cuong_phong_van_pha;
                                    goto Label_06C1;
                                    Label_0615:
                                    num2 += this.FLD_trang_bi_them_vao_dao_khach_Tu_luong_thien_can;
                                    goto Label_06C1;
                                    Label_0623:
                                    num2 += this.FLD_trang_bi_them_vao_dao_khach_Phach_khi_pha_giap;
                                    goto Label_06C1;
                                    Label_0631:
                                    num2 += this.FLD_trang_bi_them_vao_dao_khach_Chan_vu_tuyet_kich;
                                    goto Label_06C1;
                                    Label_063F:
                                    num2 += this.FLD_trang_bi_them_vao_dao_khach_Am_anh_tuyet_sat;
                                    goto Label_06C1;
                                    Label_064A:
                                    num2 += this.FLD_trang_bi_them_vao_dao_khach_On_nhu_thai_son;
                                    goto Label_06C1;
                                    Label_0655:
                                    num2 += this.FLD_trang_bi_them_vao_kiem_khach_Truong_hong_quan_nhat;
                                    goto Label_06C1;
                                    Label_0660:
                                    num2 += this.FLD_trang_bi_them_vao_kiem_khach_Bach_bien_than_hanh;
                                    goto Label_06C1;
                                    Label_066B:
                                    num2 += this.FLD_trang_bi_them_vao_kiem_khach_Lien_hoan_phi_vu;
                                    goto Label_06C1;
                                    Label_0676:
                                    num2 += this.FLD_trang_bi_them_vao_kiem_khach_Tat_sat_nhat_kich;
                                    goto Label_06C1;
                                    Label_0681:
                                    num2 += this.FLD_trang_bi_them_vao_kiem_khach_Cuong_phong_van_pha;
                                    goto Label_06C1;
                                    Label_068C:
                                    num2 += this.FLD_trang_bi_them_vao_kiem_khach_Ho_than_cuong_khi;
                                    goto Label_06C1;
                                    Label_0697:
                                    num2 += this.FLD_trang_bi_them_vao_kiem_khach_Di_hoa_tiep_moc;
                                    goto Label_06C1;
                                    Label_06A2:
                                    num2 += this.FLD_trang_bi_them_vao_kiem_khach_Hoi_lieu_than_phap;
                                    goto Label_06C1;
                                    Label_06AD:
                                    num2 += this.FLD_trang_bi_them_vao_kiem_khach_No_hai_cuong_lan;
                                    goto Label_06C1;
                                    Label_06B8:
                                    num2 += this.FLD_trang_bi_them_vao_kiem_khach_Trung_quan_nhat_no;
                                    Label_06C1:
                                    num2 *= World.KHI_CONG_TI_LE_PHAN_TRAM;
                                    if ((World.SO_KHI_CONG_TANG_TOI_DA != 0) && (num2 > World.SO_KHI_CONG_TANG_TOI_DA))
                                    {
                                          num2 = World.SO_KHI_CONG_TANG_TOI_DA;
                                    }
                                    switch (this.Player_Job)
                                    {
                                          case 1:
                                                {
                                                      switch (i)
                                                      {
                                                            case 1:
                                                                  goto Label_0A27;

                                                            case 2:
                                                                  goto Label_0A50;

                                                            case 3:
                                                                  goto Label_0A66;

                                                            case 5:
                                                                  goto Label_0A7C;

                                                            case 6:
                                                                  goto Label_0A92;

                                                            case 7:
                                                                  goto Label_0AA8;

                                                            case 8:
                                                                  goto Label_0AB4;

                                                            case 9:
                                                                  goto Label_0AD4;

                                                            case 10:
                                                                  goto Label_0B05;
                                                      }
                                                      continue;
                                                }
                                          case 2:
                                                {
                                                      switch (i)
                                                      {
                                                            case 0:
                                                                  goto Label_0B1B;

                                                            case 1:
                                                                  goto Label_0B28;

                                                            case 2:
                                                                  goto Label_0B50;

                                                            case 3:
                                                                  goto Label_0B66;

                                                            case 5:
                                                                  goto Label_0B7C;

                                                            case 6:
                                                                  goto Label_0B92;

                                                            case 7:
                                                                  goto Label_0BA8;

                                                            case 8:
                                                                  goto Label_0BC7;

                                                            case 9:
                                                                  goto Label_0BE7;

                                                            case 10:
                                                                  goto Label_0C07;
                                                      }
                                                      continue;
                                                }
                                          case 3:
                                                {
                                                      switch (i)
                                                      {
                                                            case 0:
                                                                  goto Label_0C23;

                                                            case 1:
                                                                  goto Label_0C30;

                                                            case 2:
                                                                  goto Label_0C46;

                                                            case 3:
                                                                  goto Label_0C5C;

                                                            case 5:
                                                                  goto Label_0C72;

                                                            case 6:
                                                                  goto Label_0C89;

                                                            case 7:
                                                                  goto Label_0CBC;

                                                            case 8:
                                                                  goto Label_0CD2;

                                                            case 9:
                                                                  goto Label_0CE8;

                                                            case 10:
                                                                  goto Label_0D08;
                                                      }
                                                      continue;
                                                }
                                          case 4:
                                                {
                                                      switch (i)
                                                      {
                                                            case 0:
                                                                  goto Label_0D28;

                                                            case 2:
                                                                  goto Label_0D3F;

                                                            case 3:
                                                                  goto Label_0D55;

                                                            case 5:
                                                                  goto Label_0D6B;

                                                            case 6:
                                                                  goto Label_0D82;

                                                            case 7:
                                                                  goto Label_0D98;

                                                            case 8:
                                                                  goto Label_0DAE;

                                                            case 9:
                                                                  goto Label_0DBA;

                                                            case 10:
                                                                  goto Label_0DC6;
                                                      }
                                                      continue;
                                                }
                                          case 5:
                                                {
                                                      switch (i)
                                                      {
                                                            case 0:
                                                                  goto Label_0DDC;

                                                            case 2:
                                                                  goto Label_0DF2;

                                                            case 3:
                                                                  goto Label_0E11;

                                                            case 5:
                                                                  goto Label_0E30;

                                                            case 6:
                                                                  goto Label_0E46;

                                                            case 7:
                                                                  goto Label_0E5C;

                                                            case 8:
                                                                  goto Label_0E68;

                                                            case 9:
                                                                  goto Label_0E86;

                                                            case 10:
                                                                  goto Label_0E9C;
                                                      }
                                                      continue;
                                                }
                                          case 6:
                                                {
                                                      switch (i)
                                                      {
                                                            case 0:
                                                                  goto Label_0EA8;

                                                            case 1:
                                                                  goto Label_0ECF;

                                                            case 2:
                                                                  goto Label_0EFA;

                                                            case 3:
                                                                  goto Label_0F1F;

                                                            case 4:
                                                                  goto Label_0F44;

                                                            case 5:
                                                                  goto Label_0F69;

                                                            case 6:
                                                                  goto Label_0F7F;

                                                            case 7:
                                                                  goto Label_0FA4;

                                                            case 8:
                                                                  goto Label_0FB0;

                                                            case 9:
                                                                  goto Label_0FC6;

                                                            case 10:
                                                                  goto Label_0FDC;
                                                      }
                                                      continue;
                                                }
                                          case 7:
                                                {
                                                      switch (i)
                                                      {
                                                            case 0:
                                                                  goto Label_1001;

                                                            case 1:
                                                                  goto Label_100E;

                                                            case 2:
                                                                  goto Label_1025;

                                                            case 3:
                                                                  goto Label_1044;

                                                            case 4:
                                                                  goto Label_105B;

                                                            case 5:
                                                                  goto Label_1071;

                                                            case 6:
                                                                  goto Label_107D;

                                                            case 7:
                                                                  goto Label_1089;

                                                            case 8:
                                                                  goto Label_10A9;

                                                            case 9:
                                                                  goto Label_10D0;

                                                            case 10:
                                                                  goto Label_10DC;
                                                      }
                                                      continue;
                                                }
                                          case 8:
                                                {
                                                      switch (i)
                                                      {
                                                            case 0:
                                                                  goto Label_10E8;

                                                            case 1:
                                                                  goto Label_1106;

                                                            case 2:
                                                                  goto Label_112F;

                                                            case 3:
                                                                  goto Label_1156;

                                                            case 4:
                                                            case 5:
                                                                  goto Label_116C;

                                                            case 6:
                                                                  goto Label_1182;

                                                            case 7:
                                                                  goto Label_1198;

                                                            case 8:
                                                                  goto Label_11A4;

                                                            case 10:
                                                                  goto Label_11C4;
                                                      }
                                                      continue;
                                                }
                                          case 9:
                                                {
                                                      switch (i)
                                                      {
                                                            case 0:
                                                                  goto Label_11DA;

                                                            case 1:
                                                                  goto Label_11E7;

                                                            case 2:
                                                                  goto Label_120F;

                                                            case 3:
                                                                  goto Label_1225;

                                                            case 5:
                                                                  goto Label_1238;

                                                            case 6:
                                                                  goto Label_124B;

                                                            case 8:
                                                                  goto Label_125E;

                                                            case 9:
                                                                  goto Label_127A;

                                                            case 10:
                                                                  goto Label_1297;
                                                      }
                                                      continue;
                                                }
                                          case 10:
                                                {
                                                      switch (i)
                                                      {
                                                            case 0:
                                                                  goto Label_0962;

                                                            case 1:
                                                            case 2:
                                                                  goto Label_0978;

                                                            case 3:
                                                                  goto Label_0985;

                                                            case 4:
                                                                  goto Label_099B;

                                                            case 5:
                                                                  goto Label_09A7;

                                                            case 6:
                                                                  goto Label_09B3;

                                                            case 7:
                                                                  goto Label_09CB;

                                                            case 8:
                                                                  goto Label_09D7;

                                                            case 9:
                                                                  goto Label_09EF;

                                                            case 10:
                                                                  goto Label_0A07;
                                                      }
                                                      continue;
                                                }
                                          default:
                                                {
                                                      continue;
                                                }
                                    }
                                    base.Toi_thieu_cong_kich = num2 * 0.01;
                                    this.FLD_QigqongAttack = (int)num2;
                                    continue;
                                    Label_0962:
                                    base.Quyen_cuong_than_giang_the = 0.001 * num2;
                                    continue;
                                    Label_0978:
                                    this.FLD_QigqongAttack = (int)num2;
                                    continue;
                                    Label_0985:
                                    base.Quyen_cuong_phong_van_pha = num2 * 3.0;
                                    continue;
                                    Label_099B:
                                    base.Quyen_kim_cuong_bat_hoai = num2;
                                    continue;
                                    Label_09A7:
                                    base.Quyen_doi_cong_lam_thu = num2;
                                    continue;
                                    Label_09B3:
                                    this.FLD_NHAN_VAT_KHI_CONG_LUC_CONG_KICH_VO_CONG_TANG_CUONG_TI_LE_PHAN_TRAM = 0.03 * ((int)num2);
                                    continue;
                                    Label_09CB:
                                    base.Quyen_hieu_y_mot_don = num2;
                                    continue;
                                    Label_09D7:
                                    this.FLD_NHAN_VAT_KHI_CONG_LUC_PHONG_NGU_VO_CONG_TANG_CUONG_TI_LE_PHAN_TRAM = 0.03 * ((int)num2);
                                    continue;
                                    Label_09EF:
                                    this.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram = 0.05 * ((int)num2);
                                    continue;
                                    Label_0A07:
                                    base.Quyen_mai_xu_thanh_cham = 2.0 + (0.2 * num2);
                                    continue;
                                    Label_0A27:
                                    this.FLD_NHAN_VAT_KHI_CONG_TRUNG_MUC_TIEU = (int)(this.FLD_TRUNG_MUC_TIEU * (0.1 + (0.01 * num2)));
                                    continue;
                                    Label_0A50:
                                    base.Danh_Lien_Hoan_ty_le = 10.0 + num2;
                                    continue;
                                    Label_0A66:
                                    base.Phan_am_pha_kinh_thuong_ton = 0.05 * num2;
                                    continue;
                                    Label_0A7C:
                                    base.Phan_sat_thuong_ty_le = 10.0 + num2;
                                    continue;
                                    Label_0A92:
                                    base.Pha_giap_ty_le = 5.0 + num2;
                                    continue;
                                    Label_0AA8:
                                    base.Vo_cong_chi_mang_ti_le = num2;
                                    continue;
                                    Label_0AB4:
                                    base.Dao_khach_Am_anh_tuyet_sat = 5.0 + (0.5 * num2);
                                    continue;
                                    Label_0AD4:
                                    this.FLD_NHAN_VAT_KHI_CONG_PHONG_NGU = (int)(this.FLD_PHONG_NGU * (0.003 * num2));
                                    this.Nhan_vat_khi_cong_them_vao_HP = (int)(2.0 * num2);
                                    continue;
                                    Label_0B05:
                                    base.Dao_khach_Quan_cong_uy_luc = 0.001 * num2;
                                    continue;
                                    Label_0B1B:
                                    this.FLD_QigqongAttack = (int)num2;
                                    continue;
                                    Label_0B28:
                                    this.FLD_NHAN_VAT_KHI_CONG_NE_TRANH = (int)num2;
                                    base.Bach_bien_than_hanh = 0.1 + (0.01 * num2);
                                    continue;
                                    Label_0B50:
                                    base.Danh_Lien_Hoan_ty_le = 10.0 + num2;
                                    continue;
                                    Label_0B66:
                                    base.Quai_vat_vo_cong_them_vao = 0.03 * num2;
                                    continue;
                                    Label_0B7C:
                                    base.Kiem_khach_Ho_than_cuong_khi = 10.0 + num2;
                                    continue;
                                    Label_0B92:
                                    base.Kiem_khach_Di_hoa_tiep_moc = 0.4 * num2;
                                    continue;
                                    Label_0BA8:
                                    base.SAT_THUONG_VO_CONG_TANG = World.KIEM_KHACH_HOI_LIEU_THAN_PHAP_VO_CONG_UY_LUC * num2;
                                    base.Kiem_khach_Hoi_lieu_than_phap = num2 * World.KIEM_KHACH_HOI_LIEU_THAN_PHAP_NE_TRANH_TY_LE;
                                    continue;
                                    Label_0BC7:
                                    base.Kiem_khach_No_hai_cuong_lan = 5.0 + (0.5 * num2);
                                    continue;
                                    Label_0BE7:
                                    base.Kiem_khach_Trung_quan_nhat_no = 5.0 + (0.5 * num2);
                                    continue;
                                    Label_0C07:
                                    base.Kiem_khach_Vo_kien_bat_toi = (0.2 * num2) + World.VO_KIEN_BAT_TOI_TY_LE_TANG_CUONG;
                                    continue;
                                    Label_0C23:
                                    this.FLD_NHAN_VAT_KHI_CONG_PHONG_NGU = (int)num2;
                                    continue;
                                    Label_0C30:
                                    base.Thuong_khach_Van_khi_lieu_thuong = 0.01 * num2;
                                    continue;
                                    Label_0C46:
                                    base.Danh_Lien_Hoan_ty_le = 10.0 + num2;
                                    continue;
                                    Label_0C5C:
                                    base.Tuc_gian_chi_hong_Them_vao_thuong_ton = 0.01 * num2;
                                    continue;
                                    Label_0C72:
                                    this.Nhan_vat_khi_cong_them_vao_HP = (int)(8.0 * num2);
                                    continue;
                                    Label_0C89:
                                    base.Thuong_khach_Can_khon_na_di = World.THUONG_KHACH_CAN_KHON_NA_DI_VO_CONG_UY_LUC * num2;
                                    this.FLD_NHAN_VAT_KHI_CONG_PHONG_NGU += (int)(this.FLD_PHONG_NGU * (0.005 * num2));
                                    continue;
                                    Label_0CBC:
                                    this.FLD_NHAN_VAT_KHI_CONG_LUC_PHONG_NGU_VO_CONG_TANG_CUONG_TI_LE_PHAN_TRAM = 0.03 * num2;
                                    continue;
                                    Label_0CD2:
                                    base.Thuong_khach_Cuong_than_hang_the = 0.005 * num2;
                                    continue;
                                    Label_0CE8:
                                    base.Thuong_khach_Chuyen_cong_vi_thu = 5.0 + (0.5 * num2);
                                    continue;
                                    Label_0D08:
                                    base.Thuong_khach_Mat_nhat_cuong_vu = 5.0 + (0.5 * num2);
                                    continue;
                                    Label_0D28:
                                    this.FLD_NHAN_VAT_KHI_CONG_TRUNG_MUC_TIEU = (int)(2.0 * num2);
                                    continue;
                                    Label_0D3F:
                                    base.Cung_thu_Ngung_than_tu_khi = num2 * 0.01;
                                    continue;
                                    Label_0D55:
                                    base.Hoi_luu_chan_khi = num2 * 15.0;
                                    continue;
                                    Label_0D6B:
                                    this.Nhan_vat_khi_cong_them_vao_HP = (int)(8.0 * num2);
                                    continue;
                                    Label_0D82:
                                    base.Cung_thu_Tam_than_ngung_tu = num2 + 10.0;
                                    continue;
                                    Label_0D98:
                                    base.Cung_thu_Luu_tinh_tam_thi = 10.0 + num2;
                                    continue;
                                    Label_0DAE:
                                    base.Cung_thu_Due_loi_chi_tien = num2;
                                    continue;
                                    Label_0DBA:
                                    base.Cung_thu_Vo_minh_am_thi = num2;
                                    continue;
                                    Label_0DC6:
                                    base.Cung_thu_Tri_menh_tuyet_sat = 10.0 + num2;
                                    continue;
                                    Label_0DDC:
                                    base.Y_van_khi_lieu_tam = 0.02 * num2;
                                    continue;
                                    Label_0DF2:
                                    this.Nhan_vat_khi_cong_them_vao_HP = (int)(this.Nhan_vat_co_ban_lon_nhat_HP * (0.01 * num2));
                                    continue;
                                    Label_0E11:
                                    this.Nhan_vat_khi_cong_them_vao_MP = (int)(this.Nhan_vat_co_ban_lon_nhat_MP * (0.01 * num2));
                                    continue;
                                    Label_0E30:
                                    base.Y_truong_cong_kich_luc = 0.01 * num2;
                                    continue;
                                    Label_0E46:
                                    base.Y_hap_tinh_dai_phap = 0.03 * num2;
                                    continue;
                                    Label_0E5C:
                                    base.Vo_cong_chi_mang_ti_le = num2;
                                    continue;
                                    Label_0E68:
                                    base.Y_ho_than_khi_giap = (num2 * 0.005) * this.FLD_BasicCharAttack;
                                    continue;
                                    Label_0E86:
                                    base.Y_cuu_thien_chan_khi = 0.01 * num2;
                                    continue;
                                    Label_0E9C:
                                    base.Y_van_vat_hoi_xuan = num2;
                                    continue;
                                    Label_0EA8:
                                    base.Thich_khach_Kinh_kha_chi_no = num2 * 0.01;
                                    base.Toi_thieu_cong_kich = num2 * 0.01;
                                    continue;
                                    Label_0ECF:
                                    if (num2 > 0.0)
                                    {
                                          base.Thich_khach_Tam_hoa_tu_dinh = (10.0 + num2) * World.THICH_KHACH_TAM_HOA_TU_DINH_TY_LE_TANG_CUONG;
                                    }
                                    continue;
                                    Label_0EFA:
                                    if (num2 > 0.0)
                                    {
                                          base.Thich_khach_Lien_hoan_phi_vu = 10.0 + num2;
                                    }
                                    continue;
                                    Label_0F1F:
                                    if (num2 > 0.0)
                                    {
                                          base.Thich_khach_Tat_sat_nhat_kich = 10.0 + num2;
                                    }
                                    continue;
                                    Label_0F44:
                                    if (num2 > 0.0)
                                    {
                                          base.Thich_khach_Tam_than_ngung_tu = 10.0 + num2;
                                    }
                                    continue;
                                    Label_0F69:
                                    base.Thich_khach_Tri_thu_tuyet_menh = 0.012 * num2;
                                    continue;
                                    Label_0F7F:
                                    if (num2 > 0.0)
                                    {
                                          base.Thich_khach_Tien_phat_che_nhan = 20.0 + num2;
                                    }
                                    continue;
                                    Label_0FA4:
                                    base.Thich_khach_Thien_chu_van_thu = num2;
                                    continue;
                                    Label_0FB0:
                                    base.Thich_khach_Lien_tieu_dai_da = num2 * 0.01;
                                    continue;
                                    Label_0FC6:
                                    base.Thich_khach_Kiem_nhan_loan_vu = 3.0 * num2;
                                    continue;
                                    Label_0FDC:
                                    if (num2 > 0.0)
                                    {
                                          base.Thich_khach_Vo_tinh_da_kich = 10.0 + num2;
                                    }
                                    continue;
                                    Label_1001:
                                    this.FLD_QigqongAttack = (int)num2;
                                    continue;
                                    Label_100E:
                                    this.Nhan_vat_khi_cong_them_vao_HP = (int)(16.0 * num2);
                                    continue;
                                    Label_1025:
                                    this.Nhan_vat_khi_cong_them_vao_MP = (int)(this.Nhan_vat_co_ban_lon_nhat_MP * (num2 * 0.01));
                                    continue;
                                    Label_1044:
                                    this.FLD_NHAN_VAT_KHI_CONG_PHONG_NGU = (int)(5.0 * num2);
                                    continue;
                                    Label_105B:
                                    base.SAT_THUONG_VO_CONG_TANG = 0.005 * num2;
                                    continue;
                                    Label_1071:
                                    base.Cam_su_Tam_khuc_hoa_minh = num2;
                                    continue;
                                    Label_107D:
                                    base.Cam_su_Cam_thanh_qua_nguyet = num2;
                                    continue;
                                    Label_1089:
                                    base.Cam_su_Nhat_am_xuat_kich = (10.0 + num2) * 0.002;
                                    continue;
                                    Label_10A9:
                                    base.Cam_su_Loan_phuong_hoa_minh = num2 * 0.005;
                                    base.Cam_su_kich_luc_cong_thanh = num2 * 0.005;
                                    continue;
                                    Label_10D0:
                                    base.Cam_su_Sat_am_cam_khuc = num2;
                                    continue;
                                    Label_10DC:
                                    base.Cam_su_Sat_menh_cam_thanh = num2;
                                    continue;
                                    Label_10E8:
                                    base.Toi_thieu_cong_kich = num2 * 0.01;
                                    this.FLD_QigqongAttack = (int)num2;
                                    continue;
                                    Label_1106:
                                    this.FLD_NHAN_VAT_KHI_CONG_TRUNG_MUC_TIEU = (int)(this.FLD_TRUNG_MUC_TIEU * (0.1 + (0.01 * num2)));
                                    continue;
                                    Label_112F:
                                    base.Han_bao_quan_Thien_ma_cuong_huyet = 10.0 + num2;
                                    base.Han_bao_quan_Thien_ma_cuong_huyet_2 = 9.0 + num2;
                                    continue;
                                    Label_1156:
                                    base.Tri_menh_nhat_kich_ty_le = 10.0 + num2;
                                    continue;
                                    Label_116C:
                                    base.HBQ_Thien_ma_thoat_cot_ty_le = 0.005 * num2;
                                    continue;
                                    Label_1182:
                                    base.Pha_giap_ty_le = 5.0 + num2;
                                    continue;
                                    Label_1198:
                                    base.Vo_cong_chi_mang_ti_le = num2;
                                    continue;
                                    Label_11A4:
                                    base.Dao_khach_Am_anh_tuyet_sat = 5.0 + (0.5 * num2);
                                    continue;
                                    Label_11C4:
                                    base.Dao_khach_Quan_cong_uy_luc = 0.001 * num2;
                                    continue;
                                    Label_11DA:
                                    this.FLD_QigqongAttack = (int)num2;
                                    continue;
                                    Label_11E7:
                                    this.FLD_NHAN_VAT_KHI_CONG_NE_TRANH = (int)num2;
                                    base.Bach_bien_than_hanh = 0.1 + (num2 * 0.01);
                                    continue;
                                    Label_120F:
                                    base.Danh_Lien_Hoan_ty_le = 10.0 + num2;
                                    continue;
                                    Label_1225:
                                    base.Tri_menh_nhat_kich_ty_le = 10.0 + num2;
                                    continue;
                                    Label_1238:
                                    base.Kiem_khach_Ho_than_cuong_khi = 10.0 + num2;
                                    continue;
                                    Label_124B:
                                    base.Kiem_khach_Di_hoa_tiep_moc = 0.4 * num2;
                                    continue;
                                    Label_125E:
                                    base.SAT_THUONG_VO_CONG_TANG = World.KIEM_KHACH_HOI_LIEU_THAN_PHAP_VO_CONG_UY_LUC * num2;
                                    base.Kiem_khach_Hoi_lieu_than_phap = num2 * World.KIEM_KHACH_HOI_LIEU_THAN_PHAP_NE_TRANH_TY_LE;
                                    continue;
                                    Label_127A:
                                    base.Kiem_khach_No_hai_cuong_lan = 5.0 + (0.5 * num2);
                                    continue;
                                    Label_1297:
                                    base.Kiem_khach_Trung_quan_nhat_no = 5.0 + (0.5 * num2);
                              }
                              foreach (THANG_THIEN_KHI_CONG_LOAI thang_thien_khi_cong_loai in this.THANG_THIEN_KHI_CONG.Values)
                              {
                                    int num3;
                                    double num4;
                                    if (thang_thien_khi_cong_loai.KHI_CONG_SO_LUONG != 0)
                                    {
                                          num4 = ((thang_thien_khi_cong_loai.KHI_CONG_SO_LUONG + this.FLD_trang_bi_them_vao_Khi_cong) + this.FLD_nhan_vat_them_vao_khi_cong) + this.FLD_Vo_huan_them_vao_khi_cong;
                                          num4 *= World.KHI_CONG_TI_LE_PHAN_TRAM;
                                          if ((World.SO_KHI_CONG_TANG_TOI_DA != 0) && (num4 > World.SO_KHI_CONG_TANG_TOI_DA))
                                          {
                                                num4 = World.SO_KHI_CONG_TANG_TOI_DA;
                                          }
                                          switch (this.Player_Job)
                                          {
                                                case 1:
                                                      num3 = thang_thien_khi_cong_loai.KHI_CONG_ID;
                                                      switch (num3)
                                                      {
                                                            case 310:
                                                                  goto Label_1849;

                                                            case 0x137:
                                                                  goto Label_1856;

                                                            case 0x138:
                                                                  goto Label_1863;

                                                            case 0x139:
                                                                  goto Label_1870;

                                                            case 0x13a:
                                                                  goto Label_1886;

                                                            case 0x17d:
                                                                  goto Label_17B2;

                                                            case 0x17e:
                                                                  goto Label_17D9;

                                                            case 0x17f:
                                                                  goto Label_17EE;

                                                            case 0x180:
                                                                  goto Label_1805;

                                                            case 0x181:
                                                                  goto Label_1824;

                                                            case 0x182:
                                                                  goto Label_183B;
                                                      }
                                                      break;

                                                case 2:
                                                      num3 = thang_thien_khi_cong_loai.KHI_CONG_ID;
                                                      switch (num3)
                                                      {
                                                            case 320:
                                                                  goto Label_1925;

                                                            case 0x141:
                                                                  goto Label_1938;

                                                            case 0x142:
                                                                  goto Label_194F;

                                                            case 0x143:
                                                                  goto Label_195C;

                                                            case 0x144:
                                                                  goto Label_1972;

                                                            case 380:
                                                                  goto Label_189C;

                                                            case 0x17e:
                                                                  goto Label_18C3;

                                                            case 0x17f:
                                                                  goto Label_18D8;

                                                            case 0x180:
                                                                  goto Label_18EF;

                                                            case 0x181:
                                                                  goto Label_190E;
                                                      }
                                                      break;

                                                case 3:
                                                      num3 = thang_thien_khi_cong_loai.KHI_CONG_ID;
                                                      switch (num3)
                                                      {
                                                            case 330:
                                                                  goto Label_1A1A;

                                                            case 0x14b:
                                                                  goto Label_1A27;

                                                            case 0x14c:
                                                                  goto Label_1A34;

                                                            case 0x14d:
                                                                  goto Label_1A41;

                                                            case 0x14e:
                                                                  goto Label_1A57;

                                                            case 380:
                                                                  goto Label_1988;

                                                            case 0x17d:
                                                                  goto Label_19AF;

                                                            case 0x17f:
                                                                  goto Label_19D6;

                                                            case 0x180:
                                                                  goto Label_19ED;

                                                            case 0x182:
                                                                  goto Label_1A0C;
                                                      }
                                                      break;

                                                case 4:
                                                      num3 = thang_thien_khi_cong_loai.KHI_CONG_ID;
                                                      switch (num3)
                                                      {
                                                            case 340:
                                                                  goto Label_1B0F;

                                                            case 0x155:
                                                                  goto Label_1B26;

                                                            case 0x156:
                                                                  goto Label_1B71;

                                                            case 0x157:
                                                                  goto Label_1B7E;

                                                            case 0x158:
                                                                  goto Label_1B8B;

                                                            case 0x17d:
                                                                  goto Label_1A6D;

                                                            case 0x17e:
                                                                  goto Label_1A94;

                                                            case 0x17f:
                                                                  goto Label_1AA9;

                                                            case 0x180:
                                                                  goto Label_1AC0;

                                                            case 0x181:
                                                                  goto Label_1ADF;

                                                            case 0x182:
                                                                  goto Label_1AF6;
                                                      }
                                                      break;

                                                case 5:
                                                      num3 = thang_thien_khi_cong_loai.KHI_CONG_ID;
                                                      switch (num3)
                                                      {
                                                            case 350:
                                                                  goto Label_1C45;

                                                            case 0x15f:
                                                                  goto Label_1C52;

                                                            case 0x160:
                                                                  goto Label_1C5F;

                                                            case 0x161:
                                                                  goto Label_1C6C;

                                                            case 0x162:
                                                                  goto Label_1C79;

                                                            case 380:
                                                                  goto Label_1B98;

                                                            case 0x17d:
                                                                  goto Label_1BBF;

                                                            case 0x17e:
                                                                  goto Label_1BE6;

                                                            case 0x180:
                                                                  goto Label_1BF4;

                                                            case 0x181:
                                                                  goto Label_1C13;

                                                            case 0x182:
                                                                  goto Label_1C2A;

                                                            case 0x183:
                                                                  goto Label_1C38;
                                                      }
                                                      break;

                                                case 6:
                                                      switch (thang_thien_khi_cong_loai.KHI_CONG_ID)
                                                      {
                                                            case 370:
                                                                  goto Label_1C90;

                                                            case 0x173:
                                                                  goto Label_1C9D;

                                                            case 0x174:
                                                                  goto Label_1CAA;

                                                            case 0x175:
                                                                  goto Label_1CB7;

                                                            case 0x176:
                                                                  goto Label_1CC4;

                                                            case 0x17d:
                                                                  goto Label_1CD1;

                                                            case 0x17e:
                                                                  goto Label_1CF8;

                                                            case 0x17f:
                                                                  goto Label_1D06;

                                                            case 0x180:
                                                                  goto Label_1D1D;

                                                            case 0x181:
                                                                  goto Label_1D35;
                                                      }
                                                      break;

                                                case 7:
                                                      switch (thang_thien_khi_cong_loai.KHI_CONG_ID)
                                                      {
                                                            case 380:
                                                                  goto Label_1D4C;

                                                            case 0x17d:
                                                                  goto Label_1D73;

                                                            case 0x17e:
                                                                  goto Label_1D9A;

                                                            case 0x17f:
                                                                  goto Label_1DAF;

                                                            case 0x180:
                                                                  goto Label_1DC6;

                                                            case 0x181:
                                                                  goto Label_1DDE;

                                                            case 0x182:
                                                                  goto Label_1DF5;

                                                            case 390:
                                                                  goto Label_1E03;

                                                            case 0x187:
                                                                  goto Label_1E10;

                                                            case 0x188:
                                                                  goto Label_1E1D;

                                                            case 0x189:
                                                                  goto Label_1E2A;

                                                            case 0x18a:
                                                                  goto Label_1E40;
                                                      }
                                                      break;

                                                case 8:
                                                      num3 = thang_thien_khi_cong_loai.KHI_CONG_ID;
                                                      switch (num3)
                                                      {
                                                            case 0x17d:
                                                                  goto Label_1E94;

                                                            case 0x17e:
                                                                  goto Label_1EBB;

                                                            case 0x17f:
                                                                  goto Label_1EC9;

                                                            case 0x180:
                                                                  goto Label_1EE0;

                                                            case 0x181:
                                                                  goto Label_1EF8;

                                                            case 600:
                                                                  goto Label_1E58;

                                                            case 0x259:
                                                                  goto Label_1E67;

                                                            case 0x25b:
                                                                  goto Label_1E76;

                                                            case 0x25c:
                                                                  goto Label_1E85;
                                                      }
                                                      break;

                                                case 9:
                                                      num3 = thang_thien_khi_cong_loai.KHI_CONG_ID;
                                                      if (num3 > 0x181)
                                                      {
                                                            goto Label_1671;
                                                      }
                                                      switch (num3)
                                                      {
                                                            case 320:
                                                                  goto Label_1FAA;

                                                            case 0x141:
                                                                  goto Label_1FBA;

                                                            case 0x142:
                                                                  goto Label_1FCE;

                                                            case 380:
                                                                  goto Label_1F2D;

                                                            case 0x17e:
                                                                  goto Label_1F54;

                                                            case 0x17f:
                                                                  goto Label_1F66;

                                                            case 0x180:
                                                                  goto Label_1F7A;

                                                            case 0x181:
                                                                  goto Label_1F96;
                                                      }
                                                      break;

                                                case 10:
                                                      num3 = thang_thien_khi_cong_loai.KHI_CONG_ID;
                                                      switch (num3)
                                                      {
                                                            case 380:
                                                                  goto Label_1727;

                                                            case 0x17d:
                                                                  goto Label_174E;

                                                            case 0x17f:
                                                                  goto Label_1775;

                                                            case 0x180:
                                                                  goto Label_178C;

                                                            case 0x182:
                                                                  goto Label_17A4;

                                                            case 0x231:
                                                                  goto Label_16E6;

                                                            case 0x232:
                                                                  goto Label_16F3;

                                                            case 0x233:
                                                                  goto Label_1700;

                                                            case 0x234:
                                                                  goto Label_170D;

                                                            case 0x235:
                                                                  goto Label_171A;
                                                      }
                                                      break;
                                          }
                                    }
                                    continue;
                                    Label_1671:
                                    switch (num3)
                                    {
                                          case 0x2bd:
                                                {
                                                      base.Truong_hong_quan_thien = (int)num4;
                                                      continue;
                                                }
                                          case 0x2be:
                                                {
                                                      base.Ai_hong_bien_da = (int)num4;
                                                      continue;
                                                }
                                          default:
                                                {
                                                      continue;
                                                }
                                    }
                                    Label_16E6:
                                    base.Quyen_thang_thien_1_khi_cong_doat_menh_lien_hoan = num4;
                                    continue;
                                    Label_16F3:
                                    base.Quyen_thang_thien_2_khi_cong_chop_mat = num4;
                                    continue;
                                    Label_1700:
                                    base.Quyen_thang_thien_3_khi_cong_da_tot_muon_tot_hon = num4;
                                    continue;
                                    Label_170D:
                                    base.Quyen_thang_thien_4_khi_cong_hong_nguyet_cuong_phong = num4;
                                    continue;
                                    Label_171A:
                                    base.Quyen_thang_thien_4_khi_cong_ran_doc_xuat_dong = num4;
                                    continue;
                                    Label_1727:
                                    this.FLD_QigqongAttack += (int)(this.FLD_ATTACK * (0.06 * num4));
                                    continue;
                                    Label_174E:
                                    this.FLD_QigqongAttack += (int)(this.FLD_ATTACK * (0.06 * num4));
                                    continue;
                                    Label_1775:
                                    base.Thang_thien_1_khi_cong_Van_khi_hanh_tam = 0.02 * num4;
                                    continue;
                                    Label_178C:
                                    this.Nhan_vat_khi_cong_them_vao_HP = (int)(8.0 * num4);
                                    continue;
                                    Label_17A4:
                                    this.FLD_NHAN_VAT_KHI_CONG_NE_TRANH = (int)num4;
                                    continue;
                                    Label_17B2:
                                    this.FLD_QigqongAttack += (int)(this.FLD_ATTACK * (0.06 * num4));
                                    continue;
                                    Label_17D9:
                                    this.FLD_NHAN_VAT_KHI_CONG_PHONG_NGU += (int)num4;
                                    continue;
                                    Label_17EE:
                                    base.Thang_thien_1_khi_cong_Van_khi_hanh_tam = 0.04 * num4;
                                    continue;
                                    Label_1805:
                                    this.Nhan_vat_khi_cong_them_vao_HP += (int)(8.0 * num4);
                                    continue;
                                    Label_1824:
                                    base.Thang_thien_1_khi_cong_Van_khi_lieu_thuong = 0.11 * num4;
                                    continue;
                                    Label_183B:
                                    this.FLD_NHAN_VAT_KHI_CONG_NE_TRANH = (int)num4;
                                    continue;
                                    Label_1849:
                                    base.Dao_khach_thang_thien_1_khi_cong_Don_xuat_nghich_canh = num4;
                                    continue;
                                    Label_1856:
                                    base.Dao_khach_thang_thien_2_khi_cong_Cung_duong_mat_lo = num4;
                                    continue;
                                    Label_1863:
                                    base.Dao_khach_thang_thien_3_khi_cong_Pham_am_pha_kinh = num4;
                                    continue;
                                    Label_1870:
                                    base.Thang_thien_4_khi_cong_Hong_nguyet_cuong_phong += (int)num4;
                                    continue;
                                    Label_1886:
                                    base.Thang_thien_4_khi_cong_Doc_xa_xuat_dong += (int)num4;
                                    continue;
                                    Label_189C:
                                    this.FLD_QigqongAttack += (int)(this.FLD_ATTACK * (0.06 * num4));
                                    continue;
                                    Label_18C3:
                                    this.FLD_NHAN_VAT_KHI_CONG_PHONG_NGU += (int)num4;
                                    continue;
                                    Label_18D8:
                                    base.Thang_thien_1_khi_cong_Van_khi_hanh_tam = 0.04 * num4;
                                    continue;
                                    Label_18EF:
                                    this.Nhan_vat_khi_cong_them_vao_HP += (int)(8.0 * num4);
                                    continue;
                                    Label_190E:
                                    base.Thang_thien_1_khi_cong_Van_khi_lieu_thuong = 0.11 * num4;
                                    continue;
                                    Label_1925:
                                    base.Kiem_khach_thang_thien_1_khi_cong_Thua_thang_truy_kich = num4 + World.THUA_THANG_TRUY_KICH_TY_LE_TANG_CUONG;
                                    continue;
                                    Label_1938:
                                    base.Kiem_Khach_thang_thien_2_khi_cong_Thien_dia_dong_tho = num4 * 0.05;
                                    continue;
                                    Label_194F:
                                    base.Kiem_khach_thang_thien_3_khi_cong_Hoa_phuong_lam_trieu = num4;
                                    continue;
                                    Label_195C:
                                    base.Thang_thien_4_khi_cong_Hong_nguyet_cuong_phong += (int)num4;
                                    continue;
                                    Label_1972:
                                    base.Thang_thien_4_khi_cong_Doc_xa_xuat_dong += (int)num4;
                                    continue;
                                    Label_1988:
                                    this.FLD_QigqongAttack += (int)(this.FLD_ATTACK * (0.06 * num4));
                                    continue;
                                    Label_19AF:
                                    this.FLD_QigqongAttack += (int)(this.FLD_ATTACK * (0.06 * num4));
                                    continue;
                                    Label_19D6:
                                    base.Thang_thien_1_khi_cong_Van_khi_hanh_tam = 0.04 * num4;
                                    continue;
                                    Label_19ED:
                                    this.Nhan_vat_khi_cong_them_vao_HP += (int)(8.0 * num4);
                                    continue;
                                    Label_1A0C:
                                    this.FLD_NHAN_VAT_KHI_CONG_NE_TRANH = (int)num4;
                                    continue;
                                    Label_1A1A:
                                    base.Thuong_khach_thang_thien_1_khi_cong_Pha_giap_thu_hon = num4;
                                    continue;
                                    Label_1A27:
                                    base.Thuong_khach_thang_thien_2_khi_cong_Di_thoi_vi_tien = num4;
                                    continue;
                                    Label_1A34:
                                    base.Thuong_khach_thang_thien_3_khi_cong_No_y_chi_hong = num4;
                                    continue;
                                    Label_1A41:
                                    base.Thang_thien_4_khi_cong_Hong_nguyet_cuong_phong += (int)num4;
                                    continue;
                                    Label_1A57:
                                    base.Thang_thien_4_khi_cong_Doc_xa_xuat_dong += (int)num4;
                                    continue;
                                    Label_1A6D:
                                    this.FLD_QigqongAttack += (int)(this.FLD_ATTACK * (0.06 * num4));
                                    continue;
                                    Label_1A94:
                                    this.FLD_NHAN_VAT_KHI_CONG_PHONG_NGU += (int)num4;
                                    continue;
                                    Label_1AA9:
                                    base.Thang_thien_1_khi_cong_Van_khi_hanh_tam = 0.04 * num4;
                                    continue;
                                    Label_1AC0:
                                    this.Nhan_vat_khi_cong_them_vao_HP += (int)(8.0 * num4);
                                    continue;
                                    Label_1ADF:
                                    base.Thang_thien_1_khi_cong_Van_khi_lieu_thuong = 0.11 * num4;
                                    continue;
                                    Label_1AF6:
                                    base.Thang_thien_1_khi_cong_Bach_bien_than_hanh = num4;
                                    this.FLD_NHAN_VAT_KHI_CONG_NE_TRANH = ((int)num4) + 10;
                                    continue;
                                    Label_1B0F:
                                    base.Cung_thu_thang_thien_1_khi_cong_Tuyet_anh_xa_hon = num4 + 10.0;
                                    continue;
                                    Label_1B26:
                                    base.Cung_thu_thang_thien_2_khi_cong_Thien_quan_ap_da = num4 * 5.0;
                                    this.FLD_NHAN_VAT_KHI_CONG_PHONG_NGU += ((int)num4) * 5;
                                    this.NHAN_VAT_MANG_NANG_TONG_TRONG_LUONG += (int)((this.NHAN_VAT_MANG_NANG_TONG_TRONG_LUONG * num4) * 0.003);
                                    continue;
                                    Label_1B71:
                                    base.Cung_thu_thang_thien_3_khi_cong_Thien_ngoai_tam_thi = num4;
                                    continue;
                                    Label_1B7E:
                                    base.Man_nguyet_cuong_phong = num4;
                                    continue;
                                    Label_1B8B:
                                    base.Liet_nhat_viem_viem = num4;
                                    continue;
                                    Label_1B98:
                                    this.FLD_QigqongAttack += (int)(this.FLD_ATTACK * (0.06 * num4));
                                    continue;
                                    Label_1BBF:
                                    this.FLD_QigqongAttack += (int)(this.FLD_ATTACK * (0.06 * num4));
                                    continue;
                                    Label_1BE6:
                                    this.FLD_NHAN_VAT_KHI_CONG_PHONG_NGU = (int)num4;
                                    continue;
                                    Label_1BF4:
                                    this.Nhan_vat_khi_cong_them_vao_HP += (int)(8.0 * num4);
                                    continue;
                                    Label_1C13:
                                    base.Thang_thien_1_khi_cong_Van_khi_lieu_thuong = 0.11 * num4;
                                    continue;
                                    Label_1C2A:
                                    this.FLD_NHAN_VAT_KHI_CONG_NE_TRANH = (int)num4;
                                    continue;
                                    Label_1C38:
                                    base.Thang_thien_1_khi_cong_Cuong_phong_thien_y = num4;
                                    continue;
                                    Label_1C45:
                                    base.Y_thang_thien_1_khi_cong_Cuong_y_ho_the = num4;
                                    continue;
                                    Label_1C52:
                                    base.Y_thang_thien_2_khi_cong_vo_trung_sinh_huu = num4;
                                    continue;
                                    Label_1C5F:
                                    base.Y_thang_thien_3_khi_cong_Minh_kinh_chi_thuy = num4;
                                    continue;
                                    Label_1C6C:
                                    base.Man_nguyet_cuong_phong = num4;
                                    continue;
                                    Label_1C79:
                                    base.Vong_mai_thiem_tan = num4 * 5.0;
                                    continue;
                                    Label_1C90:
                                    base.Thich_khach_thang_thien_1_khi_cong_Da_ma_trien_than = num4;
                                    continue;
                                    Label_1C9D:
                                    base.Thich_khach_thang_thien_2_khi_cong_Thuan_thuy_thoi_chu = num4;
                                    continue;
                                    Label_1CAA:
                                    base.Thich_khach_thang_thien_3_khi_cong_Di_no_hoan_no = num4;
                                    continue;
                                    Label_1CB7:
                                    base.Man_nguyet_cuong_phong = num4;
                                    continue;
                                    Label_1CC4:
                                    base.Liet_nhat_viem_viem = num4;
                                    continue;
                                    Label_1CD1:
                                    this.FLD_QigqongAttack += (int)(this.FLD_ATTACK * (0.06 * num4));
                                    continue;
                                    Label_1CF8:
                                    this.FLD_NHAN_VAT_KHI_CONG_PHONG_NGU = (int)num4;
                                    continue;
                                    Label_1D06:
                                    base.Thang_thien_1_khi_cong_Van_khi_hanh_tam = 0.04 * num4;
                                    continue;
                                    Label_1D1D:
                                    this.Nhan_vat_khi_cong_them_vao_HP = (int)(8.0 * num4);
                                    continue;
                                    Label_1D35:
                                    base.Thang_thien_1_khi_cong_Van_khi_lieu_thuong = 0.11 * num4;
                                    continue;
                                    Label_1D4C:
                                    this.FLD_QigqongAttack += (int)(this.FLD_ATTACK * (0.06 * num4));
                                    continue;
                                    Label_1D73:
                                    this.FLD_QigqongAttack += (int)(this.FLD_ATTACK * (0.06 * num4));
                                    continue;
                                    Label_1D9A:
                                    this.FLD_NHAN_VAT_KHI_CONG_PHONG_NGU += (int)num4;
                                    continue;
                                    Label_1DAF:
                                    base.Thang_thien_1_khi_cong_Van_khi_hanh_tam = 0.02 * num4;
                                    continue;
                                    Label_1DC6:
                                    this.Nhan_vat_khi_cong_them_vao_HP = (int)(8.0 * num4);
                                    continue;
                                    Label_1DDE:
                                    base.Thang_thien_1_khi_cong_Van_khi_lieu_thuong = 0.01 * num4;
                                    continue;
                                    Label_1DF5:
                                    this.FLD_NHAN_VAT_KHI_CONG_NE_TRANH = (int)num4;
                                    continue;
                                    Label_1E03:
                                    base.Cam_su_thang_thien_1_khi_cong_Phi_hoa_diem_thuy = num4;
                                    continue;
                                    Label_1E10:
                                    base.Cam_su_thang_thien_2_khi_cong_Tam_dam_anh_nguyet = num4;
                                    continue;
                                    Label_1E1D:
                                    base.Cam_su_thang_thien_3_khi_cong_Tu_da_thu_ca = num4;
                                    continue;
                                    Label_1E2A:
                                    base.Thang_thien_4_khi_cong_Hong_nguyet_cuong_phong += (int)num4;
                                    continue;
                                    Label_1E40:
                                    base.Huyen_ti_chan_mach += ((int)num4) * 5;
                                    continue;
                                    Label_1E58:
                                    base.Han_bao_quan_Hanh_phong_long_vu = (int)num4;
                                    continue;
                                    Label_1E67:
                                    base.Han_bao_quan_Thien_ma_ho_the = (int)num4;
                                    continue;
                                    Label_1E76:
                                    base.Truong_hong_quan_thien = (int)num4;
                                    continue;
                                    Label_1E85:
                                    base.Ai_hong_bien_da = (int)num4;
                                    continue;
                                    Label_1E94:
                                    this.FLD_QigqongAttack += (int)(this.FLD_ATTACK * (0.06 * num4));
                                    continue;
                                    Label_1EBB:
                                    this.FLD_NHAN_VAT_KHI_CONG_PHONG_NGU = (int)num4;
                                    continue;
                                    Label_1EC9:
                                    base.Thang_thien_1_khi_cong_Van_khi_hanh_tam = 0.04 * num4;
                                    continue;
                                    Label_1EE0:
                                    this.Nhan_vat_khi_cong_them_vao_HP = (int)(8.0 * num4);
                                    continue;
                                    Label_1EF8:
                                    base.Thang_thien_1_khi_cong_Van_khi_lieu_thuong = 0.11 * num4;
                                    continue;
                                    Label_1F2D:
                                    this.FLD_QigqongAttack += (int)(this.FLD_ATTACK * (0.06 * num4));
                                    continue;
                                    Label_1F54:
                                    this.FLD_NHAN_VAT_KHI_CONG_PHONG_NGU += (int)num4;
                                    continue;
                                    Label_1F66:
                                    base.Thang_thien_1_khi_cong_Van_khi_hanh_tam = 0.04 * num4;
                                    continue;
                                    Label_1F7A:
                                    this.Nhan_vat_khi_cong_them_vao_HP += (int)(8.0 * num4);
                                    continue;
                                    Label_1F96:
                                    base.Thang_thien_1_khi_cong_Van_khi_lieu_thuong = 0.11 * num4;
                                    continue;
                                    Label_1FAA:
                                    base.Kiem_khach_thang_thien_1_khi_cong_Thua_thang_truy_kich = num4 + World.THUA_THANG_TRUY_KICH_TY_LE_TANG_CUONG;
                                    continue;
                                    Label_1FBA:
                                    base.Kiem_Khach_thang_thien_2_khi_cong_Thien_dia_dong_tho = num4 * 0.005;
                                    continue;
                                    Label_1FCE:
                                    base.Kiem_khach_thang_thien_3_khi_cong_Hoa_phuong_lam_trieu = num4;
                              }
                        }
                  }
            }

            public void UPDATE_RXPIONT()
            {
                  try
                  {
                        SqlParameter[] parameterArray = new SqlParameter[] { SqlDBA.MakeInParam("@id", SqlDbType.VarChar, 20, this.Userid), SqlDBA.MakeInParam("@rxpiont", SqlDbType.BigInt, 0, this.FLD_RXPIONT), SqlDBA.MakeInParam("@rxpiontx", SqlDbType.BigInt, 0, this.FLD_RXPIONTX) };
                        DbPool_Class class2 = new DbPool_Class
                        {
                              Conn = DBA.smethod_3("rxjhaccount"),
                              Prams = parameterArray,
                              Sql = "XWWL_UPDATE_RXOIONT"
                        };
                        World.queue_1.Enqueue(class2);
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "保存ID 元宝 数据出错[" + this.Userid + "]-[" + this.UserName + "]" + exception.Message);
                  }
            }

            public void UPDATE_TINH_NHAN_HE_THONG(int int_116, string string_10, string string_11)
            {
                  byte[] dst = Converter.hexStringToByte("AA558F0000A6007C17800001000000714C7E0000000000C4687E0000000000BDD600000000000000000000000000B7709C000000000000AC89014D00000000AC89014D040000002330000002D0A9B77406000000000000A59D0300CB1C0A4D00000000010000000000000000000000000000000000000000000000000000000000000000000000001F86A3000000000000568055AA");
                  Buffer.BlockCopy(BitConverter.GetBytes(int_116), 0, dst, 11, 2);
                  byte[] bytes = Encoding.Default.GetBytes(string_10);
                  Buffer.BlockCopy(bytes, 0, dst, 0x1f, bytes.Length);
                  Buffer.BlockCopy(BitConverter.GetBytes(1), 0, dst, 0x43, 4);
                  Buffer.BlockCopy(BitConverter.GetBytes(0x9999), 0, dst, 0x47, 4);
                  DateTime time = new DateTime(0x7b2, 1, 1, 8, 0, 0);
                  Buffer.BlockCopy(BitConverter.GetBytes((int)DateTime.Now.AddDays(30.0).Subtract(time).TotalSeconds), 0, dst, 0x5b, 4);
                  if (string_11 != "")
                  {
                        byte[] src = Encoding.Default.GetBytes(string_11);
                        Buffer.BlockCopy(src, 0, dst, 0x67, src.Length);
                  }
                  else
                  {
                        byte[] buffer4 = Encoding.Default.GetBytes("天生一对");
                        Buffer.BlockCopy(buffer4, 0, dst, 0x67, buffer4.Length);
                  }
                  Buffer.BlockCopy(BitConverter.GetBytes(this.UserSessionID), 0, dst, 5, 2);
                  if (this.Client != null)
                  {
                        this.Client.method_8(dst, dst.Length);
                  }
            }

            public void UPDATE_Wuxun_Effect()
            {
                  Players players;
                  this.FLD_Vo_cong_cong_kich = 0;
                  this.FLD_Vo_cong_phong_ngu = 0;
                  this.Vo_Huan_them_vao_HP = 0;
                  this.Vo_Huan_them_vao_MP = 0;
                  this.FLD_Vo_huan_them_vao_khi_cong = 0;
                  if (this.Config.Vo_Huan_mo_ra != 0)
                  {
                        switch (this.NHAN_VAT_VO_HUAN_GIAI_DOAN)
                        {
                              case 1:
                                    this.FLD_Vo_cong_cong_kich = int.Parse(World.Vo_huan_giai_doan_1[0]);
                                    this.FLD_Vo_cong_phong_ngu = int.Parse(World.Vo_huan_giai_doan_1[1]);
                                    this.Vo_Huan_them_vao_HP = int.Parse(World.Vo_huan_giai_doan_1[2]);
                                    this.Vo_Huan_them_vao_MP = int.Parse(World.Vo_huan_giai_doan_1[3]);
                                    this.FLD_Vo_huan_them_vao_khi_cong = int.Parse(World.Vo_huan_giai_doan_1[4]);
                                    goto Label_036B;

                              case 2:
                                    this.FLD_Vo_cong_cong_kich = int.Parse(World.Vo_huan_giai_doan_2[0]);
                                    this.FLD_Vo_cong_phong_ngu = int.Parse(World.Vo_huan_giai_doan_2[1]);
                                    this.Vo_Huan_them_vao_HP = int.Parse(World.Vo_huan_giai_doan_2[2]);
                                    this.Vo_Huan_them_vao_MP = int.Parse(World.Vo_huan_giai_doan_2[3]);
                                    this.FLD_Vo_huan_them_vao_khi_cong = int.Parse(World.Vo_huan_giai_doan_2[4]);
                                    goto Label_036B;

                              case 3:
                                    this.FLD_Vo_cong_cong_kich = int.Parse(World.Vo_huan_giai_doan_3[0]);
                                    this.FLD_Vo_cong_phong_ngu = int.Parse(World.Vo_huan_giai_doan_3[1]);
                                    this.Vo_Huan_them_vao_HP = int.Parse(World.Vo_huan_giai_doan_3[2]);
                                    this.Vo_Huan_them_vao_MP = int.Parse(World.Vo_huan_giai_doan_3[3]);
                                    this.FLD_Vo_huan_them_vao_khi_cong = int.Parse(World.Vo_huan_giai_doan_3[4]);
                                    goto Label_036B;

                              case 4:
                                    this.FLD_Vo_cong_cong_kich = int.Parse(World.Vo_huan_giai_doan_4[0]);
                                    this.FLD_Vo_cong_phong_ngu = int.Parse(World.Vo_huan_giai_doan_4[1]);
                                    this.Vo_Huan_them_vao_HP = int.Parse(World.Vo_huan_giai_doan_4[2]);
                                    this.Vo_Huan_them_vao_MP = int.Parse(World.Vo_huan_giai_doan_4[3]);
                                    this.FLD_Vo_huan_them_vao_khi_cong = int.Parse(World.Vo_huan_giai_doan_4[4]);
                                    goto Label_036B;

                              case 5:
                                    this.FLD_Vo_cong_cong_kich = int.Parse(World.Vo_huan_giai_doan_5[0]);
                                    this.FLD_Vo_cong_phong_ngu = int.Parse(World.Vo_huan_giai_doan_5[1]);
                                    this.Vo_Huan_them_vao_HP = int.Parse(World.Vo_huan_giai_doan_5[2]);
                                    this.Vo_Huan_them_vao_MP = int.Parse(World.Vo_huan_giai_doan_5[3]);
                                    this.FLD_Vo_huan_them_vao_khi_cong = int.Parse(World.Vo_huan_giai_doan_5[4]);
                                    goto Label_036B;

                              case 6:
                                    this.FLD_Vo_cong_cong_kich = int.Parse(World.Vo_huan_giai_doan_6[0]);
                                    this.FLD_Vo_cong_phong_ngu = int.Parse(World.Vo_huan_giai_doan_6[1]);
                                    this.Vo_Huan_them_vao_HP = int.Parse(World.Vo_huan_giai_doan_6[2]);
                                    this.Vo_Huan_them_vao_MP = int.Parse(World.Vo_huan_giai_doan_6[3]);
                                    this.FLD_Vo_huan_them_vao_khi_cong = int.Parse(World.Vo_huan_giai_doan_6[4]);
                                    goto Label_036B;

                              case 7:
                                    this.FLD_Vo_cong_cong_kich = int.Parse(World.Vo_huan_giai_doan_7[0]);
                                    this.FLD_Vo_cong_phong_ngu = int.Parse(World.Vo_huan_giai_doan_7[1]);
                                    this.Vo_Huan_them_vao_HP = int.Parse(World.Vo_huan_giai_doan_7[2]);
                                    this.Vo_Huan_them_vao_MP = int.Parse(World.Vo_huan_giai_doan_7[3]);
                                    this.FLD_Vo_huan_them_vao_khi_cong = int.Parse(World.Vo_huan_giai_doan_7[4]);
                                    goto Label_036B;

                              case 8:
                                    this.FLD_Vo_cong_cong_kich = int.Parse(World.Vo_huan_giai_doan_8[0]);
                                    this.FLD_Vo_cong_phong_ngu = int.Parse(World.Vo_huan_giai_doan_8[1]);
                                    this.Vo_Huan_them_vao_HP = int.Parse(World.Vo_huan_giai_doan_8[2]);
                                    this.Vo_Huan_them_vao_MP = int.Parse(World.Vo_huan_giai_doan_8[3]);
                                    this.FLD_Vo_huan_them_vao_khi_cong = int.Parse(World.Vo_huan_giai_doan_8[4]);
                                    goto Label_036B;
                        }
                        this.GameMessage("Wu Xun BUFF disappear", 50, "");
                  }
                  Label_036B:
                  players = World.smethod_1(this.UserSessionID);
                  if (players != null)
                  {
                        players.UpdateHP_MP_SP();
                  }
            }

            public void UpdateExperience()
            {
                  double num = Convert.ToInt64(World.lever[this.Player_FLD_LEVEL]) - Convert.ToInt64(World.lever[this.Player_FLD_LEVEL - 1]);
                  double num2 = this.NHAN_VAT_KINH_NGHIEM - Convert.ToInt64(World.lever[this.Player_FLD_LEVEL - 1]);
                  if (num2 < 1.0)
                  {
                        this.NHAN_VAT_KINH_NGHIEM = Convert.ToInt64(World.lever[this.Player_FLD_LEVEL - 1]);
                        num2 = 0.0;
                  }
                  PacketData data = new PacketData();
                  data.method_8((long)num2);
                  data.method_8((long)num);
                  data.Write4(10);
                  if (this.Player_ExpErience < 0)
                  {
                        data.Write4(0);
                  }
                  else
                  {
                        data.Write4(this.Player_ExpErience);
                  }
                  data.Write2(this.FLD_CHE_TAO_LOAI_HINH);
                  data.Write2(this.FLD_CHE_TAO_THU_BAC);
                  data.Write4(this.FLD_CHE_TAO_DO_THUAN_THUC);
                  if (this.Player_FLD_JOB_LEVEL >= 6)
                  {
                        this.int_14 += this.int_13;
                        if (this.int_14 >= 0x2faf080)
                        {
                              int num3 = this.DUOC_KIEN_HANG_RONG_VI_TRI();
                              if (num3 != -1)
                              {
                                    this.int_14 -= 0x2faf080;
                                    byte[] bytes = BitConverter.GetBytes(RxjhClass.GetDBItmeId());
                                    byte[] buffer2 = new byte[0x38];
                                    this.THEM_ITEM_3(bytes, BitConverter.GetBytes(0x3b9accca), num3, BitConverter.GetBytes(1), buffer2);
                              }
                              else
                              {
                                    this.GameMessage("Khong co cho trong !", 9, "System");
                              }
                        }
                        data.Write4(this.int_14);
                        data.Write4(this.int_13);
                        data.Write4(0);
                        data.Write4(0);
                  }
                  else
                  {
                        data.Write4(0);
                        data.Write4(0);
                        data.Write4(0);
                        data.Write4(0);
                  }
                  data.Write4(0);
                  this.int_13 = 0;
                  if (this.Client != null)
                  {
                        this.Client.method_5(data, 0x6a00, this.UserSessionID, 0);
                  }
            }

            public void UpdateMoneyAndWeight()
            {
                  this.int_55 = 0;
                  for (int i = 0; i < 0x24; i++)
                  {
                        this.int_55 += this.TRANG_BI_LAN_BAO_VAY[i].VAT_PHAM_TONG_TRONG_LUONG;
                  }
                  PacketData data = new PacketData();
                  data.method_8(this.Player_Money);
                  data.Write4(this.NHAN_VAT_MANG_NANG);
                  data.Write4(this.NHAN_VAT_MANG_NANG_TONG_TRONG_LUONG);
                  if (this.Client != null)
                  {
                        this.Client.method_5(data, 0x7c00, this.UserSessionID, 0);
                  }
            }

            public void UpdatePowersAndStatus()
            {
                  if ((this.Player_WuXun > World.dictionary_9[7]) && (DateTime.Now < this.VO_HUAN_CAP_8_DOAN_THOI_GIAN))
                  {
                        this.NHAN_VAT_VO_HUAN_GIAI_DOAN = 8;
                  }
                  else if (this.Player_WuXun > World.dictionary_9[6])
                  {
                        this.NHAN_VAT_VO_HUAN_GIAI_DOAN = 7;
                  }
                  else if (this.Player_WuXun > World.dictionary_9[5])
                  {
                        this.NHAN_VAT_VO_HUAN_GIAI_DOAN = 6;
                  }
                  else if (this.Player_WuXun > World.dictionary_9[4])
                  {
                        this.NHAN_VAT_VO_HUAN_GIAI_DOAN = 5;
                  }
                  else if (this.Player_WuXun > World.dictionary_9[3])
                  {
                        this.NHAN_VAT_VO_HUAN_GIAI_DOAN = 4;
                  }
                  else if (this.Player_WuXun > World.dictionary_9[2])
                  {
                        this.NHAN_VAT_VO_HUAN_GIAI_DOAN = 3;
                  }
                  else if (this.Player_WuXun > World.dictionary_9[1])
                  {
                        this.NHAN_VAT_VO_HUAN_GIAI_DOAN = 2;
                  }
                  else if (this.Player_WuXun > World.dictionary_9[0])
                  {
                        this.NHAN_VAT_VO_HUAN_GIAI_DOAN = 1;
                  }
                  try
                  {
                        this.UPDATE_Wuxun_Effect();
                        PacketData data = new PacketData();
                        data.Write2(this.Player_FLD_LEVEL);
                        data.Write2(this.FLD_TIM + this.FLD_trang_bi_them_vao_trai_tim);
                        data.Write2(this.FLD_SUC_MANH + this.FLD_trang_bi_them_vao_Suc_manh);
                        data.Write2(this.FLD_THAN_THE + this.FLD_trang_bi_them_vao_than_the);
                        data.Write2(this.FLD_SINH_MENH + this.FLD_trang_bi_them_vao_sinh_menh);
                        data.Write2(0);
                        data.Write2((int)this.FLD_BasicCharAttack);
                        data.Write2((int)this.FLD_BasicCharDefense);
                        data.Write2(this.FLD_NHAN_VAT_CO_BAN_TRUNG_MUC_TIEU);
                        data.Write2(this.FLD_NHAN_VAT_CO_BAN_NE_TRANH);
                        data.Write2(this.Player_Qigong_point);
                        for (int i = 0; i < 15; i++)
                        {
                              if (i >= 11)
                              {
                                    goto Label_0A64;
                              }
                              data.Write2(this.Qigong[i].int_0);
                              if (this.Qigong[i].int_0 == 0)
                              {
                                    goto Label_0A5B;
                              }
                              if (this.Qigong[i].气功量 == 0)
                              {
                                    goto Label_0A52;
                              }
                              int num2 = ((this.Qigong[i].气功量 + this.FLD_trang_bi_them_vao_Khi_cong) + this.FLD_nhan_vat_them_vao_khi_cong) + this.FLD_Vo_huan_them_vao_khi_cong;
                              switch (this.Player_Job)
                              {
                                    case 1:
                                    case 8:
                                          {
                                                switch (i)
                                                {
                                                      case 0:
                                                            goto Label_08D7;

                                                      case 1:
                                                            goto Label_08EB;

                                                      case 2:
                                                            goto Label_08FF;

                                                      case 3:
                                                            goto Label_0913;

                                                      case 4:
                                                            goto Label_0927;

                                                      case 5:
                                                            goto Label_093B;

                                                      case 6:
                                                            goto Label_094F;

                                                      case 7:
                                                            goto Label_0963;

                                                      case 8:
                                                            goto Label_0977;

                                                      case 9:
                                                            goto Label_098B;
                                                }
                                                data.Write2(num2);
                                                continue;
                                          }
                                    case 2:
                                    case 9:
                                          {
                                                switch (i)
                                                {
                                                      case 0:
                                                            goto Label_099F;

                                                      case 1:
                                                            goto Label_09B3;

                                                      case 2:
                                                            goto Label_09C7;

                                                      case 3:
                                                            goto Label_09DB;

                                                      case 4:
                                                            goto Label_09EC;

                                                      case 5:
                                                            goto Label_09FD;

                                                      case 6:
                                                            goto Label_0A0E;

                                                      case 7:
                                                            goto Label_0A1F;

                                                      case 8:
                                                            goto Label_0A30;

                                                      case 9:
                                                            goto Label_0A41;
                                                }
                                                data.Write2(num2);
                                                continue;
                                          }
                                    case 3:
                                          switch (i)
                                          {
                                                case 1:
                                                      goto Label_0503;

                                                case 2:
                                                      goto Label_0517;

                                                case 3:
                                                      goto Label_052B;

                                                case 4:
                                                      goto Label_053F;

                                                case 5:
                                                      goto Label_0553;

                                                case 6:
                                                      goto Label_0567;

                                                case 7:
                                                      goto Label_057B;

                                                case 8:
                                                      goto Label_058F;

                                                case 9:
                                                      goto Label_05A3;
                                          }
                                          goto Label_0308;

                                    case 4:
                                          {
                                                switch (i)
                                                {
                                                      case 0:
                                                            goto Label_05B7;

                                                      case 1:
                                                            goto Label_05CB;

                                                      case 2:
                                                            goto Label_05DF;

                                                      case 3:
                                                            goto Label_05F3;

                                                      case 4:
                                                            goto Label_0607;

                                                      case 5:
                                                            goto Label_061B;

                                                      case 6:
                                                            goto Label_062F;

                                                      case 7:
                                                            goto Label_0643;

                                                      case 8:
                                                            goto Label_0657;

                                                      case 9:
                                                            goto Label_066B;
                                                }
                                                data.Write2(num2);
                                                continue;
                                          }
                                    case 5:
                                          {
                                                switch (i)
                                                {
                                                      case 0:
                                                            goto Label_067F;

                                                      case 1:
                                                            goto Label_0693;

                                                      case 2:
                                                            goto Label_06A7;

                                                      case 3:
                                                            goto Label_06BB;

                                                      case 4:
                                                            goto Label_06CF;

                                                      case 5:
                                                            goto Label_06E3;

                                                      case 6:
                                                            goto Label_06F7;

                                                      case 7:
                                                            goto Label_070B;

                                                      case 8:
                                                            goto Label_071F;

                                                      case 9:
                                                            goto Label_0733;
                                                }
                                                data.Write2(num2);
                                                continue;
                                          }
                                    case 6:
                                          {
                                                switch (i)
                                                {
                                                      case 0:
                                                            goto Label_0747;

                                                      case 1:
                                                            goto Label_075B;

                                                      case 2:
                                                            goto Label_076F;

                                                      case 3:
                                                            goto Label_0783;

                                                      case 4:
                                                            goto Label_0797;

                                                      case 5:
                                                            goto Label_07AB;

                                                      case 6:
                                                            goto Label_07BF;

                                                      case 7:
                                                            goto Label_07D3;

                                                      case 8:
                                                            goto Label_07E7;

                                                      case 9:
                                                            goto Label_07FB;
                                                }
                                                data.Write2(num2);
                                                continue;
                                          }
                                    case 7:
                                          {
                                                switch (i)
                                                {
                                                      case 0:
                                                            goto Label_080F;

                                                      case 1:
                                                            goto Label_0823;

                                                      case 2:
                                                            goto Label_0837;

                                                      case 3:
                                                            goto Label_084B;

                                                      case 4:
                                                            goto Label_085F;

                                                      case 5:
                                                            goto Label_0873;

                                                      case 6:
                                                            goto Label_0887;

                                                      case 7:
                                                            goto Label_089B;

                                                      case 8:
                                                            goto Label_08AF;

                                                      case 9:
                                                            goto Label_08C3;
                                                }
                                                data.Write2(num2);
                                                continue;
                                          }
                                    case 10:
                                          switch (i)
                                          {
                                                case 0:
                                                      goto Label_042F;

                                                case 1:
                                                      goto Label_0443;

                                                case 2:
                                                      goto Label_0457;

                                                case 3:
                                                      goto Label_046B;

                                                case 4:
                                                      goto Label_047F;

                                                case 5:
                                                      goto Label_0493;

                                                case 6:
                                                      goto Label_04A7;

                                                case 7:
                                                      goto Label_04BB;

                                                case 8:
                                                      goto Label_04CF;

                                                case 9:
                                                      goto Label_04E3;
                                          }
                                          goto Label_04F7;

                                    default:
                                          {
                                                continue;
                                          }
                              }
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_thuong_khach_Kim_chung_trao_khi));
                              continue;
                              Label_0308:
                              data.Write2(num2);
                              continue;
                              Label_042F:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_quyen_su_cuong_than_giang_the));
                              continue;
                              Label_0443:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_quyen_su_van_may_chua_thuong));
                              continue;
                              Label_0457:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_quyen_su_suc_manh_phach_Hoa_Son));
                              continue;
                              Label_046B:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_quyen_su_cuong_phong_van_pha));
                              continue;
                              Label_047F:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_quyen_su_kim_cuong_bat_hoai));
                              continue;
                              Label_0493:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_quyen_su_doi_cong_lam_thu));
                              continue;
                              Label_04A7:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_quyen_su_bang_hoa_mot_the));
                              continue;
                              Label_04BB:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_quyen_su_hieu_y_mot_don));
                              continue;
                              Label_04CF:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_quyen_su_linh_giap_ho_than));
                              continue;
                              Label_04E3:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_quyen_su_mai_xu_thanh_cham));
                              continue;
                              Label_04F7:
                              data.Write2(num2);
                              continue;
                              Label_0503:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_thuong_khach_Van_khi_lieu_thuong));
                              continue;
                              Label_0517:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_thuong_khach_Lien_hoan_phi_vu));
                              continue;
                              Label_052B:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_thuong_khach_Tat_sat_nhat_kich));
                              continue;
                              Label_053F:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_thuong_khach_Cuong_phong_van_pha));
                              continue;
                              Label_0553:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_thuong_khach_Hoanh_luyen_thai_bao));
                              continue;
                              Label_0567:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_thuong_khach_Can_khon_na_di));
                              continue;
                              Label_057B:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_thuong_khach_Linh_giap_ho_than));
                              continue;
                              Label_058F:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_thuong_khach_Cuong_than_giang_the));
                              continue;
                              Label_05A3:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_thuong_khach_Chuyen_thu_vi_cong));
                              continue;
                              Label_05B7:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_cung_thu_Bach_bo_xuyen_duong));
                              continue;
                              Label_05CB:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_cung_thu_Liep_ung_chi_nhan));
                              continue;
                              Label_05DF:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_cung_thu_Ngung_than_tu_khi));
                              continue;
                              Label_05F3:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_cung_thu_Tat_sat_nhat_kich));
                              continue;
                              Label_0607:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_cung_thu_Cuong_phong_van_pha));
                              continue;
                              Label_061B:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_cung_thu_Chinh_ban_boi_nguyen));
                              continue;
                              Label_062F:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_cung_thu_Tam_than_ngung_tu));
                              continue;
                              Label_0643:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_cung_thu_Luu_tinh_tam_thi));
                              continue;
                              Label_0657:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_cung_thu_Due_loi_chi_tien));
                              continue;
                              Label_066B:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_cung_thu_Vo_minh_am_thi));
                              continue;
                              Label_067F:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_y_van_may_hanh_tam));
                              continue;
                              Label_0693:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_y_thai_cuc_tam_phap));
                              continue;
                              Label_06A7:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_y_the_huyet_boi_tang));
                              continue;
                              Label_06BB:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_y_tay_tuy_dich_kinh));
                              continue;
                              Label_06CF:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_y_dieu_thu_hoi_xuan));
                              continue;
                              Label_06E3:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_y_truong_cong_kich));
                              continue;
                              Label_06F7:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_y_hap_tinh_dai_phap));
                              continue;
                              Label_070B:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_y_Than_Nong_tien_thuat));
                              continue;
                              Label_071F:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_y_thien_huu_khi));
                              continue;
                              Label_0733:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_y_cuu_thien_chan_khi));
                              continue;
                              Label_0747:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_thich_khach_kinh_kha_chi_no));
                              continue;
                              Label_075B:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_thich_khach_Tam_hoa_tu_dinh));
                              continue;
                              Label_076F:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_thich_khach_Lien_hoan_phi_vu));
                              continue;
                              Label_0783:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_thich_khach_Tat_sat_nhat_kich));
                              continue;
                              Label_0797:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_thich_khach_Tam_than_ngung_tu));
                              continue;
                              Label_07AB:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_thich_khach_Tri_menh_tuyet_thu));
                              continue;
                              Label_07BF:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_thich_khach_Tien_phat_che_nhan));
                              continue;
                              Label_07D3:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_thich_khach_Thien_chu_van_thu));
                              continue;
                              Label_07E7:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_thich_khach_Lien_tieu_dai_da));
                              continue;
                              Label_07FB:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_thich_khach_Kiem_nhan_loan_vu));
                              continue;
                              Label_080F:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_Cam_su_chien_ma_bon_dang));
                              continue;
                              Label_0823:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_cam_su_Thu_giang_da_bac));
                              continue;
                              Label_0837:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_Cam_su_thanh_tam_pho_thien));
                              continue;
                              Label_084B:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_cam_su_Duong_quan_tam_diep));
                              continue;
                              Label_085F:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_cam_su_Han_cung_thu_nguyet));
                              continue;
                              Label_0873:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_Cam_su_Tam_khuc_hoa_minh));
                              continue;
                              Label_0887:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_Cam_su_Cam_thanh_qua_nguyet));
                              continue;
                              Label_089B:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_Cam_su_Nhat_am_xuat_kich));
                              continue;
                              Label_08AF:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_cam_su_Loan_phuong_hoa_minh));
                              continue;
                              Label_08C3:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_Cam_su_Sat_am_cam_khuc));
                              continue;
                              Label_08D7:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_dao_khach_Luc_phach_hoa_son));
                              continue;
                              Label_08EB:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_dao_khach_Nhiep_hon_nhat_kich));
                              continue;
                              Label_08FF:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_dao_khach_Lien_hoan_phi_vu));
                              continue;
                              Label_0913:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_dao_khach_Tat_sat_nhat_kich));
                              continue;
                              Label_0927:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_dao_khach_Cuong_phong_van_pha));
                              continue;
                              Label_093B:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_dao_khach_Tu_luong_thien_can));
                              continue;
                              Label_094F:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_dao_khach_Phach_khi_pha_giap));
                              continue;
                              Label_0963:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_dao_khach_Chan_vu_tuyet_kich));
                              continue;
                              Label_0977:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_dao_khach_Am_anh_tuyet_sat));
                              continue;
                              Label_098B:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_dao_khach_On_nhu_thai_son));
                              continue;
                              Label_099F:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_kiem_khach_Truong_hong_quan_nhat));
                              continue;
                              Label_09B3:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_kiem_khach_Bach_bien_than_hanh));
                              continue;
                              Label_09C7:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_kiem_khach_Lien_hoan_phi_vu));
                              continue;
                              Label_09DB:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_kiem_khach_Tat_sat_nhat_kich));
                              continue;
                              Label_09EC:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_kiem_khach_Cuong_phong_van_pha));
                              continue;
                              Label_09FD:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_kiem_khach_Ho_than_cuong_khi));
                              continue;
                              Label_0A0E:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_kiem_khach_Di_hoa_tiep_moc));
                              continue;
                              Label_0A1F:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_kiem_khach_Hoi_lieu_than_phap));
                              continue;
                              Label_0A30:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_kiem_khach_No_hai_cuong_lan));
                              continue;
                              Label_0A41:
                              data.Write2(num2 + ((int)this.FLD_trang_bi_them_vao_kiem_khach_Trung_quan_nhat_no));
                              continue;
                              Label_0A52:
                              data.Write2(0);
                              continue;
                              Label_0A5B:
                              data.Write2(0);
                              continue;
                              Label_0A64:
                              data.Write4(0);
                        }
                        data.Write2(0);
                        if (this.Player_Job == 8)
                        {
                              for (int num4 = 0; num4 < 30; num4++)
                              {
                                    if (this.class79_0[0, num4] != null)
                                    {
                                          data.Write4(this.class79_0[0, num4].FLD_PID);
                                    }
                                    else
                                    {
                                          data.Write4(0);
                                    }
                              }
                              for (int num5 = 0; num5 < 12; num5++)
                              {
                                    if (this.class79_0[1, num5] != null)
                                    {
                                          data.Write4(this.class79_0[1, num5].FLD_PID);
                                    }
                                    else
                                    {
                                          data.Write4(0);
                                    }
                              }
                              for (int num6 = 0x1f; num6 < 0x25; num6++)
                              {
                                    if (this.class79_0[0, num6] != null)
                                    {
                                          data.Write4(this.class79_0[0, num6].FLD_PID);
                                    }
                                    else
                                    {
                                          data.Write4(0);
                                    }
                              }
                              data.method_10(new byte[0x70], 0, 0x70);
                              for (int num7 = 0; num7 < 30; num7++)
                              {
                                    if (this.class79_0[0, num7] != null)
                                    {
                                          data.Write2(this.class79_0[0, num7].VO_CONG_THU_BAC);
                                    }
                                    else
                                    {
                                          data.Write2(0);
                                    }
                              }
                              for (int num8 = 0; num8 < 12; num8++)
                              {
                                    if (this.class79_0[1, num8] != null)
                                    {
                                          data.Write2(this.class79_0[1, num8].VO_CONG_THU_BAC);
                                    }
                                    else
                                    {
                                          data.Write2(0);
                                    }
                              }
                              for (int num9 = 0x1f; num9 < 0x25; num9++)
                              {
                                    if (this.class79_0[0, num9] != null)
                                    {
                                          data.Write2(this.class79_0[0, num9].VO_CONG_THU_BAC);
                                    }
                                    else
                                    {
                                          data.Write2(0);
                                    }
                              }
                              for (int num10 = 0; num10 < 0x1c; num10++)
                              {
                                    data.Write2(0);
                              }
                              for (int num11 = 0; num11 < 30; num11++)
                              {
                                    if (this.class79_0[0, num11] != null)
                                    {
                                          data.Write2(this.class79_0[0, num11].FLD_VO_CONG_CAO_NHAT_DANG_CAP);
                                    }
                                    else
                                    {
                                          data.Write2(0);
                                    }
                              }
                              for (int num12 = 0; num12 < 12; num12++)
                              {
                                    if (this.class79_0[1, num12] != null)
                                    {
                                          data.Write2(this.class79_0[1, num12].FLD_VO_CONG_CAO_NHAT_DANG_CAP);
                                    }
                                    else
                                    {
                                          data.Write2(0);
                                    }
                              }
                              for (int num13 = 0x1f; num13 < 0x25; num13++)
                              {
                                    if (this.class79_0[0, num13] != null)
                                    {
                                          data.Write2(this.class79_0[0, num13].FLD_VO_CONG_CAO_NHAT_DANG_CAP);
                                    }
                                    else
                                    {
                                          data.Write2(0);
                                    }
                              }
                              for (int num14 = 0; num14 < 0x1c; num14++)
                              {
                                    data.Write2(0);
                              }
                        }
                        else if (this.Player_Job == 9)
                        {
                              for (int num15 = 0; num15 < 0x19; num15++)
                              {
                                    if (this.class79_0[0, num15] != null)
                                    {
                                          data.Write4(this.class79_0[0, num15].FLD_PID);
                                    }
                                    else
                                    {
                                          data.Write4(0);
                                    }
                              }
                              for (int num16 = 0; num16 < 8; num16++)
                              {
                                    data.Write4(0);
                              }
                              for (int num17 = 0; num17 < 8; num17++)
                              {
                                    if (this.class79_0[1, num17] != null)
                                    {
                                          data.Write4(this.class79_0[1, num17].FLD_PID);
                                    }
                                    else
                                    {
                                          data.Write4(0);
                                    }
                              }
                              for (int num18 = 0x19; num18 < 0x25; num18++)
                              {
                                    if (this.class79_0[0, num18] != null)
                                    {
                                          data.Write4(this.class79_0[0, num18].FLD_PID);
                                    }
                                    else
                                    {
                                          data.Write4(0);
                                    }
                              }
                              for (int num19 = 0; num19 < 8; num19++)
                              {
                                    data.Write4(0);
                              }
                              for (int num20 = 0; num20 < 12; num20++)
                              {
                                    if (this.class79_0[2, num20] != null)
                                    {
                                          data.Write4(this.class79_0[2, num20].FLD_PID);
                                    }
                                    else
                                    {
                                          data.Write4(0);
                                    }
                              }
                              for (int num21 = 0; num21 < 3; num21++)
                              {
                                    data.Write4(0);
                              }
                              for (int num22 = 0; num22 < 0x19; num22++)
                              {
                                    if (this.class79_0[0, num22] != null)
                                    {
                                          data.Write2(this.class79_0[0, num22].VO_CONG_THU_BAC);
                                    }
                                    else
                                    {
                                          data.Write2(0);
                                    }
                              }
                              for (int num23 = 0; num23 < 8; num23++)
                              {
                                    data.Write2(0);
                              }
                              for (int num24 = 0; num24 < 3; num24++)
                              {
                                    data.Write2(1);
                              }
                              data.Write2(0);
                              data.Write2(1);
                              for (int num25 = 0; num25 < 3; num25++)
                              {
                                    data.Write2(0);
                              }
                              for (int num26 = 0x19; num26 < 0x25; num26++)
                              {
                                    if (this.class79_0[0, num26] != null)
                                    {
                                          data.Write2(this.class79_0[0, num26].VO_CONG_THU_BAC);
                                    }
                                    else
                                    {
                                          data.Write2(0);
                                    }
                              }
                              for (int num27 = 0; num27 < 8; num27++)
                              {
                                    data.Write2(0);
                              }
                              for (int num28 = 0; num28 < 12; num28++)
                              {
                                    data.Write2(0);
                              }
                              for (int num29 = 0; num29 < 3; num29++)
                              {
                                    data.Write2(0);
                              }
                              for (int num30 = 0; num30 < 0x19; num30++)
                              {
                                    if (this.class79_0[0, num30] != null)
                                    {
                                          data.Write2(this.class79_0[0, num30].FLD_VO_CONG_CAO_NHAT_DANG_CAP);
                                    }
                                    else
                                    {
                                          data.Write2(0);
                                    }
                              }
                              for (int num31 = 0; num31 < 8; num31++)
                              {
                                    data.Write2(0);
                              }
                              for (int num32 = 0; num32 < 3; num32++)
                              {
                                    data.Write2(1);
                              }
                              data.Write2(1);
                              data.Write2(1);
                              for (int num33 = 0; num33 < 3; num33++)
                              {
                                    data.Write2(0);
                              }
                              for (int num34 = 0x19; num34 < 0x25; num34++)
                              {
                                    if (this.class79_0[0, num34] != null)
                                    {
                                          data.Write2(this.class79_0[0, num34].FLD_VO_CONG_CAO_NHAT_DANG_CAP);
                                    }
                                    else
                                    {
                                          data.Write2(0);
                                    }
                              }
                              for (int num35 = 0; num35 < 8; num35++)
                              {
                                    data.Write2(0);
                              }
                              for (int num36 = 0; num36 < 12; num36++)
                              {
                                    data.Write2(0);
                              }
                              for (int num37 = 0; num37 < 3; num37++)
                              {
                                    data.Write2(0);
                              }
                        }
                        else
                        {
                              for (int num38 = 0; num38 < 0x20; num38++)
                              {
                                    if (this.class79_0[0, num38] != null)
                                    {
                                          data.Write4(this.class79_0[0, num38].FLD_PID);
                                    }
                                    else
                                    {
                                          data.Write4(0);
                                    }
                              }
                              for (int num39 = 0; num39 < 0x1c; num39++)
                              {
                                    if (this.class79_0[1, num39] != null)
                                    {
                                          data.Write4(this.class79_0[1, num39].FLD_PID);
                                    }
                                    else
                                    {
                                          data.Write4(0);
                                    }
                              }
                              data.method_10(new byte[0x170], 0, 0x170);
                        }
                        for (int j = 0x10; j < 0x12; j++)
                        {
                              if (this.class79_0[2, j] != null)
                              {
                                    data.Write4(this.class79_0[2, j].FLD_PID);
                              }
                              else
                              {
                                    data.Write4(0);
                              }
                        }
                        if (World.Vo_cong_phong_ngu_hinh_thuc != 0)
                        {
                              data.Write4((int)(((this.FLD_trang_bi_suc_phong_ngu_vo_cong_tang_cuong_ti_le_phan_tram * World.Vo_cong_Phong_ngu_suc_manh_khong_che) * (((1.0 + this.FLD_nhan_vat_vo_cong_suc_phong_ngu_tang_cuong_ti_le_phan_tram) + this.FLD_NHAN_VAT_KHI_CONG_LUC_PHONG_NGU_VO_CONG_TANG_CUONG_TI_LE_PHAN_TRAM) + this.SU_DO_THEM_VAO_SUC_PHONG_NGU_VO_CONG)) * 6.0));
                        }
                        else
                        {
                              data.Write4((int)((this.FLD_trang_bi_suc_phong_ngu_vo_cong_tang_cuong_ti_le_phan_tram * World.Vo_cong_Phong_ngu_suc_manh_khong_che) * (((1.0 + this.FLD_nhan_vat_vo_cong_suc_phong_ngu_tang_cuong_ti_le_phan_tram) + this.FLD_NHAN_VAT_KHI_CONG_LUC_PHONG_NGU_VO_CONG_TANG_CUONG_TI_LE_PHAN_TRAM) + this.SU_DO_THEM_VAO_SUC_PHONG_NGU_VO_CONG)));
                        }
                        data.Write4(this.Player_WuXun);
                        data.Write4(this.NHAN_VAT_THIEN_AC);
                        data.Write4(1);
                        data.Write4(this.FLD_cong_kich_toc_do);
                        data.Write2(1);
                        foreach (THANG_THIEN_KHI_CONG_LOAI thang_thien_khi_cong_loai in this.THANG_THIEN_KHI_CONG.Values)
                        {
                              data.Write2(thang_thien_khi_cong_loai.KHI_CONG_ID);
                              if (thang_thien_khi_cong_loai.KHI_CONG_SO_LUONG != 0)
                              {
                                    data.Write2(((thang_thien_khi_cong_loai.KHI_CONG_SO_LUONG + this.FLD_trang_bi_them_vao_Khi_cong) + this.FLD_nhan_vat_them_vao_khi_cong) + this.FLD_Vo_huan_them_vao_khi_cong);
                              }
                              else
                              {
                                    data.Write2(0);
                              }
                        }
                        for (int k = 0; k < (15 - this.THANG_THIEN_KHI_CONG.Count); k++)
                        {
                              data.Write2(0);
                              data.Write2(0);
                        }
                        data.Write2(0);
                        for (int m = 0; m < 0x15; m++)
                        {
                              if (this.class79_0[3, m] != null)
                              {
                                    data.Write4(this.class79_0[3, m].FLD_PID);
                                    data.Write4(this.class79_0[3, m].VO_CONG_THU_BAC);
                              }
                              else
                              {
                                    data.Write4(0);
                                    data.Write4(0);
                              }
                        }
                        data.Write4(this.int_15);
                        for (int n = 0; n < 15; n++)
                        {
                              if (n < 11)
                              {
                                    if (this.Qigong[n].int_0 != 0)
                                    {
                                          data.method_2((byte)this.Qigong[n].气功量);
                                    }
                                    else
                                    {
                                          data.method_2(0);
                                    }
                              }
                              else
                              {
                                    data.method_2(0);
                              }
                        }
                        foreach (THANG_THIEN_KHI_CONG_LOAI thang_thien_khi_cong_loai2 in this.THANG_THIEN_KHI_CONG.Values)
                        {
                              data.method_2((byte)thang_thien_khi_cong_loai2.KHI_CONG_SO_LUONG);
                        }
                        for (int num44 = 0; num44 < (15 - this.THANG_THIEN_KHI_CONG.Count); num44++)
                        {
                              data.method_2(0);
                        }
                        data.Write2(0);
                        data.Write4(200);
                        data.Write4(100);
                        data.Write4(0);
                        data.Write2(0);
                        data.Write2(0x3e8);
                        data.Write2(0);
                        data.Write2(0);
                        if (this.Client != null)
                        {
                              this.Client.method_5(data, 0x6b00, this.UserSessionID, 0);
                        }
                  }
                  catch (Exception exception)
                  {
                        Console.WriteLine(exception);
                        Form1.WriteLine(1, "CAP_NHAT_VO_CONG_VA_TRANG_THAI出错[" + this.Userid + "]-[" + this.UserName + "] " + exception.Message);
                  }
            }

            public void Upgrade_Tip(int int_116)
            {
                  byte[] dst = Converter.hexStringToByte("AA551100000000770002000701000000000000000055AA");
                  byte[] bytes = BitConverter.GetBytes(this.Player_FLD_LEVEL);
                  byte[] src = BitConverter.GetBytes(int_116);
                  Buffer.BlockCopy(bytes, 0, dst, 11, bytes.Length);
                  Buffer.BlockCopy(src, 0, dst, 12, src.Length);
                  Buffer.BlockCopy(BitConverter.GetBytes(this.UserSessionID), 0, dst, 5, 2);
                  if (this.Client != null)
                  {
                        this.Client.Send(dst, dst.Length);
                  }
                  this.vmethod_0(dst, dst.Length);
            }

            public void UseItem(int int_116, int int_117)
            {
                  BitConverter.GetBytes(int_116);
                  byte[] bytes = BitConverter.GetBytes(int_117);
                  byte[] buffer1 = this.TRANG_BI_LAN_BAO_VAY[int_116].VAT_PHAM_ID;
                  if (BitConverter.ToInt32(this.TRANG_BI_LAN_BAO_VAY[int_116].VAT_PHAM_SO_LUONG, 0) <= int_117)
                  {
                        this.TRANG_BI_LAN_BAO_VAY[int_116].Item_byte = new byte[0x49];
                        bytes = BitConverter.GetBytes(0);
                  }
                  else
                  {
                        bytes = BitConverter.GetBytes((int)(BitConverter.ToInt32(this.TRANG_BI_LAN_BAO_VAY[int_116].VAT_PHAM_SO_LUONG, 0) - int_117));
                        this.TRANG_BI_LAN_BAO_VAY[int_116].VAT_PHAM_SO_LUONG = bytes;
                  }
                  PacketData data = new PacketData();
                  data.method_3(1);
                  data.method_3(int_116);
                  data.Write2(0);
                  data.method_8(this.TRANG_BI_LAN_BAO_VAY[int_116].GetItem_ID);
                  if (int_117 == 0)
                  {
                        data.Write4(this.TRANG_BI_LAN_BAO_VAY[int_116].Get_VAT_PHAM_SO_LUONG);
                  }
                  else
                  {
                        data.Write4(int_117);
                  }
                  data.Write4(this.TRANG_BI_LAN_BAO_VAY[int_116].Get_VAT_PHAM_SO_LUONG);
                  if (this.TRANG_BI_LAN_BAO_VAY[int_116].GetItem_ID == 0x19f105L)
                  {
                        data.Write4(0x6f);
                  }
                  else
                  {
                        data.Write4(0);
                  }
                  data.Write4(0);
                  if (this.Client != null)
                  {
                        this.Client.method_4(data, 0x3b00, this.UserSessionID);
                  }
            }

            public void UseItem2(int int_116, int int_117)
            {
                  BitConverter.GetBytes(int_116);
                  byte[] bytes = BitConverter.GetBytes(int_117);
                  byte[] buffer1 = this.TRANG_BI_LAN_BAO_VAY[int_116].VAT_PHAM_ID;
                  if (BitConverter.ToInt32(this.TRANG_BI_LAN_BAO_VAY[int_116].VAT_PHAM_SO_LUONG, 0) <= int_117)
                  {
                        this.TRANG_BI_LAN_BAO_VAY[int_116].Item_byte = new byte[0x49];
                        bytes = BitConverter.GetBytes(0);
                  }
                  else
                  {
                        bytes = BitConverter.GetBytes((int)(BitConverter.ToInt32(this.TRANG_BI_LAN_BAO_VAY[int_116].VAT_PHAM_SO_LUONG, 0) - int_117));
                        this.TRANG_BI_LAN_BAO_VAY[int_116].VAT_PHAM_SO_LUONG = bytes;
                  }
                  PacketData data = new PacketData();
                  data.method_3(1);
                  data.method_3(int_116);
                  data.Write2(0);
                  data.method_8(this.TRANG_BI_LAN_BAO_VAY[int_116].GetItem_ID);
                  if (int_117 == 0)
                  {
                        data.Write4(this.TRANG_BI_LAN_BAO_VAY[int_116].Get_VAT_PHAM_SO_LUONG);
                  }
                  else
                  {
                        data.Write4(int_117);
                  }
                  data.Write4(this.TRANG_BI_LAN_BAO_VAY[int_116].Get_VAT_PHAM_SO_LUONG);
                  if (this.TRANG_BI_LAN_BAO_VAY[int_116].GetItem_ID == 0x19f105L)
                  {
                        data.Write4(0x6f);
                  }
                  else
                  {
                        data.Write4(0);
                  }
                  data.Write4(0);
                  if (this.Client != null)
                  {
                        this.Client.method_4(data, 0x3b00, this.UserSessionID);
                  }
            }

            public virtual void vmethod_0(byte[] byte_5, int int_116)
            {
            }

            public virtual void vmethod_1(PacketData class143_0, int int_116, int int_117)
            {
            }

            public virtual void vmethod_2(PacketData class143_0, int int_116, int int_117, int int_118)
            {
            }

            public int Bang_phai_Id
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

            public byte[] Bang_phai_mon_huy
            {
                  get
                  {
                        return this.byte_3;
                  }
                  set
                  {
                        this.byte_3 = value;
                  }
            }

            public int BANG_PHAI_MON_PHUC_MAU_SAC
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

            public int Bang_phai_nhan_vat_thu_bac
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

            public int BANG_PHAI_TRANG_PHUC_KI_TU
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

            public long BI_GIET_SO_LAN
            {
                  get
                  {
                        return this.long_11;
                  }
                  set
                  {
                        this.long_11 = value;
                  }
            }

            public int Bow_quan_cong_skill_ID
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

            public long CA_NHAN_NHA_KHO_TIEN_SO_LUONG
            {
                  get
                  {
                        return this.long_4;
                  }
                  set
                  {
                        this.long_4 = value;
                  }
            }

            public int CharacterCoords_Map
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

            public float CharacterCoords_X
            {
                  get
                  {
                        return this.float_1;
                  }
                  set
                  {
                        this.float_1 = value;
                  }
            }

            public float CharacterCoords_Y
            {
                  get
                  {
                        return this.float_2;
                  }
                  set
                  {
                        this.float_2 = value;
                  }
            }

            public float CharacterCoords_Z
            {
                  get
                  {
                        return this.float_3;
                  }
                  set
                  {
                        this.float_3 = value;
                  }
            }

            public int Chuyen_sinh_so_lan
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

            public NetState Client
            {
                  get
                  {
                        if (World.jlMsg == 1)
                        {
                              Form1.WriteLine(0, "PlayersBes_get Client()");
                        }
                        return this.class16_0;
                  }
                  set
                  {
                        this.class16_0 = value;
                  }
            }

            public int DANH_DAU_SO_LAN
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

            public DateTime DANH_DAU_THOI_GIAN
            {
                  get
                  {
                        return this.dateTime_6;
                  }
                  set
                  {
                        this.dateTime_6 = value;
                  }
            }

            public int Duoi_ha_dieu_tinh_toan
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

            public int Equipmen_bags_whether_to_open
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

            public int Evil_mode
            {
                  get
                  {
                        return this.int_92;
                  }
                  set
                  {
                        this.int_92 = value;
                  }
            }

            public int FLD_ATTACK
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

            public long FLD_BasicCharAttack
            {
                  get
                  {
                        return ((long)((((((this.FLD_ATTACK + this.FLD_trang_bi_them_vao_cong_kich) + this.FLD_nhan_vat_them_vao_cong_kich) + this.FLD_QigqongAttack) + this.Khen_thuong_them_vao_cong_kich) + this.FLD_Vo_cong_cong_kich) * (1.0 + ((double)this.FLD_them_vao_ti_le_phan_tram_cong_kich))));
                  }
            }

            public long FLD_BasicCharDefense
            {
                  get
                  {
                        return ((long)(((((((this.FLD_PHONG_NGU + this.FLD_trang_bi_them_vao_phong_ngu) + this.FLD_nhan_vat_them_vao_phong_ngu) + this.FLD_NHAN_VAT_KHI_CONG_PHONG_NGU) * (1.0 + ((double)this.FLD_them_vao_ti_le_phan_tram_phong_ngu))) + this.Khen_thuong_them_vao_phong_ngu) + this.FLD_Vo_cong_phong_ngu) + base.Y_ho_than_khi_giap));
                  }
            }

            public int FLD_CHE_TAO_DO_THUAN_THUC
            {
                  get
                  {
                        return this.int_69;
                  }
                  set
                  {
                        if (value >= 600)
                        {
                              this.int_69 = 600;
                        }
                        else
                        {
                              this.int_69 = value;
                        }
                  }
            }

            public int FLD_CHE_TAO_LOAI_HINH
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

            public int FLD_CHE_TAO_THU_BAC
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

            public int FLD_cong_kich_toc_do
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

            public string FLD_DO_DE_HO_TEN_DONG_NHAT
            {
                  get
                  {
                        return this.string_6;
                  }
                  set
                  {
                        this.string_6 = value;
                  }
            }

            public int FLD_NE_TRANH
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

            public int FLD_NHAN_VAT_CO_BAN_NE_TRANH =>
                (((int)((((this.FLD_NE_TRANH + this.FLD_trang_bi_them_vao_ne_tranh) + this.FLD_nhan_vat_them_vao_ne_tranh) + this.FLD_NHAN_VAT_KHI_CONG_NE_TRANH) * (1.0 + this.FLD_them_vao_ti_le_phan_tram_ne_tranh))) + this.Khen_thuong_them_vao_ne_tranh);

            public int FLD_NHAN_VAT_CO_BAN_TRUNG_MUC_TIEU =>
                (((int)((((this.FLD_TRUNG_MUC_TIEU + this.FLD_trang_bi_them_vao_trung_muc_tieu) + this.FLD_nhan_vat_them_vao_sinh_menh) + this.FLD_NHAN_VAT_KHI_CONG_TRUNG_MUC_TIEU) * (1.0 + this.FLD_them_vao_ti_le_phan_tram_sinh_menh))) + this.Khen_thuong_them_vao_trung_muc_tieu);

            public double FLD_NHAN_VAT_KHI_CONG_LUC_CONG_KICH_VO_CONG_TANG_CUONG_TI_LE_PHAN_TRAM
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

            public double FLD_NHAN_VAT_KHI_CONG_LUC_PHONG_NGU_VO_CONG_TANG_CUONG_TI_LE_PHAN_TRAM
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

            public int FLD_NHAN_VAT_KHI_CONG_NE_TRANH
            {
                  get
                  {
                        return this.int_89;
                  }
                  set
                  {
                        this.int_89 = value;
                  }
            }

            public int FLD_NHAN_VAT_KHI_CONG_PHONG_NGU
            {
                  get
                  {
                        return this.int_88;
                  }
                  set
                  {
                        this.int_88 = value;
                  }
            }

            public int FLD_NHAN_VAT_KHI_CONG_TRUNG_MUC_TIEU
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

            public int FLD_nhan_vat_them_vao_cong_kich
            {
                  get
                  {
                        return this.int_90;
                  }
                  set
                  {
                        this.int_90 = value;
                  }
            }

            public double FLD_nhan_vat_them_vao_gold_ti_le_phan_tram
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

            public double FLD_nhan_vat_them_vao_hop_thanh_ty_le_thanh_cong_ti_le_phan_tram
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

            public double FLD_nhan_vat_them_vao_item_roi_xuong_xac_suat_ti_le_phan_tram
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

            public int FLD_nhan_vat_them_vao_khi_cong
            {
                  get
                  {
                        return this.int_95;
                  }
                  set
                  {
                        this.int_95 = value;
                  }
            }

            public double FLD_nhan_vat_them_vao_kinh_nghiem_hoc_vo_cong_ti_le_phan_tram
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

            public double FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram
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

            public int FLD_nhan_vat_them_vao_ne_tranh
            {
                  get
                  {
                        return this.int_94;
                  }
                  set
                  {
                        this.int_94 = value;
                  }
            }

            public int FLD_nhan_vat_them_vao_phong_ngu
            {
                  get
                  {
                        return this.int_91;
                  }
                  set
                  {
                        this.int_91 = value;
                  }
            }

            public int FLD_nhan_vat_them_vao_sinh_menh
            {
                  get
                  {
                        return this.int_93;
                  }
                  set
                  {
                        this.int_93 = value;
                  }
            }

            public double FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram
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

            public double FLD_nhan_vat_vo_cong_suc_phong_ngu_tang_cuong_ti_le_phan_tram
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

            public int FLD_PHONG_NGU
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

            public int FLD_QCVIP
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

            public DateTime FLD_QCVIPTIM
            {
                  get
                  {
                        return this.dateTime_5;
                  }
                  set
                  {
                        this.dateTime_5 = value;
                  }
            }

            public int FLD_QigqongAttack
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

            public long FLD_RXPIONT
            {
                  get
                  {
                        return this.long_6;
                  }
                  set
                  {
                        this.long_6 = value;
                  }
            }

            public long FLD_RXPIONTX
            {
                  get
                  {
                        return this.long_7;
                  }
                  set
                  {
                        this.long_7 = value;
                  }
            }

            public int FLD_SINH_MENH
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

            public string FLD_SU_PHU_HO_TEN
            {
                  get
                  {
                        return this.string_5;
                  }
                  set
                  {
                        this.string_5 = value;
                  }
            }

            public int FLD_SUC_MANH
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

            public int FLD_THAN_THE
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

            public decimal FLD_them_vao_ti_le_phan_tram_cong_kich
            {
                  get
                  {
                        if (this.decimal_0 < decimal.Zero)
                        {
                              this.decimal_0 = new decimal();
                        }
                        return this.decimal_0;
                  }
                  set
                  {
                        this.decimal_0 = value;
                  }
            }

            public double FLD_them_vao_ti_le_phan_tram_HP_han_muc_toi_da
            {
                  get
                  {
                        return this.double_119;
                  }
                  set
                  {
                        this.double_119 = value;
                  }
            }

            public double FLD_them_vao_ti_le_phan_tram_MP_han_muc_toi_da
            {
                  get
                  {
                        return this.double_120;
                  }
                  set
                  {
                        this.double_120 = value;
                  }
            }

            public double FLD_them_vao_ti_le_phan_tram_ne_tranh
            {
                  get
                  {
                        return this.double_118;
                  }
                  set
                  {
                        this.double_118 = value;
                  }
            }

            public decimal FLD_them_vao_ti_le_phan_tram_phong_ngu
            {
                  get
                  {
                        if (this.decimal_1 < decimal.Zero)
                        {
                              this.decimal_1 = new decimal();
                        }
                        return this.decimal_1;
                  }
                  set
                  {
                        this.decimal_1 = value;
                  }
            }

            public double FLD_them_vao_ti_le_phan_tram_sinh_menh
            {
                  get
                  {
                        return this.double_117;
                  }
                  set
                  {
                        this.double_117 = value;
                  }
            }

            public int FLD_TIM
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

            public string FLD_TINH_NHAN
            {
                  get
                  {
                        return this.string_4;
                  }
                  set
                  {
                        this.string_4 = value;
                  }
            }

            public int FLD_TINH_NHAN_CAP_DO_YEU
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

            public string FLD_TINH_NHAN_NHAN_CUOI
            {
                  get
                  {
                        return this.string_8;
                  }
                  set
                  {
                        this.string_8 = value;
                  }
            }

            public double FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram
            {
                  get
                  {
                        return this.double_204;
                  }
                  set
                  {
                        this.double_204 = value;
                  }
            }

            public double FLD_trang_bi_suc_phong_ngu_vo_cong_tang_cuong_ti_le_phan_tram
            {
                  get
                  {
                        return this.double_205;
                  }
                  set
                  {
                        this.double_205 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_Cam_su_Cam_thanh_qua_nguyet
            {
                  get
                  {
                        return this.double_193;
                  }
                  set
                  {
                        this.double_193 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_Cam_su_chien_ma_bon_dang
            {
                  get
                  {
                        return this.double_194;
                  }
                  set
                  {
                        this.double_194 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_cam_su_Duong_quan_tam_diep
            {
                  get
                  {
                        return this.double_197;
                  }
                  set
                  {
                        this.double_197 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_cam_su_Han_cung_thu_nguyet
            {
                  get
                  {
                        return this.double_198;
                  }
                  set
                  {
                        this.double_198 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_cam_su_Loan_phuong_hoa_minh
            {
                  get
                  {
                        return this.double_202;
                  }
                  set
                  {
                        this.double_202 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_Cam_su_Nhat_am_xuat_kich
            {
                  get
                  {
                        return this.double_200;
                  }
                  set
                  {
                        this.double_200 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_Cam_su_Sat_am_cam_khuc
            {
                  get
                  {
                        return this.double_201;
                  }
                  set
                  {
                        this.double_201 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_Cam_su_Tam_khuc_hoa_minh
            {
                  get
                  {
                        return this.double_199;
                  }
                  set
                  {
                        this.double_199 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_Cam_su_thanh_tam_pho_thien
            {
                  get
                  {
                        return this.double_196;
                  }
                  set
                  {
                        this.double_196 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_cam_su_Thu_giang_da_bac
            {
                  get
                  {
                        return this.double_195;
                  }
                  set
                  {
                        this.double_195 = value;
                  }
            }

            public long FLD_trang_bi_them_vao_cong_kich
            {
                  get
                  {
                        return this.long_14;
                  }
                  set
                  {
                        this.long_14 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_cung_thu_Bach_bo_xuyen_duong
            {
                  get
                  {
                        return this.double_163;
                  }
                  set
                  {
                        this.double_163 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_cung_thu_Chinh_ban_boi_nguyen
            {
                  get
                  {
                        return this.double_168;
                  }
                  set
                  {
                        this.double_168 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_cung_thu_Cuong_phong_van_pha
            {
                  get
                  {
                        return this.double_167;
                  }
                  set
                  {
                        this.double_167 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_cung_thu_Due_loi_chi_tien
            {
                  get
                  {
                        return this.double_172;
                  }
                  set
                  {
                        this.double_172 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_cung_thu_Liep_ung_chi_nhan
            {
                  get
                  {
                        return this.double_164;
                  }
                  set
                  {
                        this.double_164 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_cung_thu_Luu_tinh_tam_thi
            {
                  get
                  {
                        return this.double_170;
                  }
                  set
                  {
                        this.double_170 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_cung_thu_Ngung_than_tu_khi
            {
                  get
                  {
                        return this.double_165;
                  }
                  set
                  {
                        this.double_165 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_cung_thu_Tam_than_ngung_tu
            {
                  get
                  {
                        return this.double_169;
                  }
                  set
                  {
                        this.double_169 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_cung_thu_Tat_sat_nhat_kich
            {
                  get
                  {
                        return this.double_166;
                  }
                  set
                  {
                        this.double_166 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_cung_thu_Vo_minh_am_thi
            {
                  get
                  {
                        return this.double_171;
                  }
                  set
                  {
                        this.double_171 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_dao_khach_Am_anh_tuyet_sat
            {
                  get
                  {
                        return this.double_142;
                  }
                  set
                  {
                        this.double_142 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_dao_khach_Chan_vu_tuyet_kich
            {
                  get
                  {
                        return this.double_139;
                  }

                  set
                  {
                        this.double_139 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_dao_khach_Cuong_phong_van_pha
            {
                  get
                  {
                        return this.double_137;
                  }
                  set
                  {
                        this.double_137 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_dao_khach_Lien_hoan_phi_vu
            {
                  get
                  {
                        return this.double_135;
                  }
                  set
                  {
                        this.double_135 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_dao_khach_Luc_phach_hoa_son
            {
                  get
                  {
                        return this.double_133;
                  }
                  set
                  {
                        this.double_133 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_dao_khach_Nhiep_hon_nhat_kich
            {
                  get
                  {
                        return this.double_134;
                  }
                  set
                  {
                        this.double_134 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_dao_khach_On_nhu_thai_son
            {
                  get
                  {
                        return this.double_140;
                  }
                  set
                  {
                        this.double_140 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_dao_khach_Phach_khi_pha_giap
            {
                  get
                  {
                        return this.double_141;
                  }
                  set
                  {
                        this.double_141 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_dao_khach_Tat_sat_nhat_kich
            {
                  get
                  {
                        return this.double_136;
                  }
                  set
                  {
                        this.double_136 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_dao_khach_Tu_luong_thien_can
            {
                  get
                  {
                        return this.double_138;
                  }
                  set
                  {
                        this.double_138 = value;
                  }
            }

            public int FLD_TRANG_BI_THEM_VAO_GAY_TON_THUONG
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

            public double FLD_trang_bi_them_vao_hop_thanh_ty_le_thanh_cong_ti_le_phan_tram
            {
                  get
                  {
                        return this.double_131;
                  }
                  set
                  {
                        this.double_131 = value;
                  }
            }

            public int FLD_trang_bi_them_vao_HP
            {
                  get
                  {
                        return this.int_107;
                  }
                  set
                  {
                        this.int_107 = value;
                  }
            }

            public int FLD_trang_bi_them_vao_Khi_cong
            {
                  get
                  {
                        return this.int_106;
                  }
                  set
                  {
                        this.int_106 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_kiem_khach_Bach_bien_than_hanh
            {
                  get
                  {
                        return this.double_144;
                  }
                  set
                  {
                        this.double_144 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_kiem_khach_Cuong_phong_van_pha
            {
                  get
                  {
                        return this.double_147;
                  }
                  set
                  {
                        this.double_147 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_kiem_khach_Di_hoa_tiep_moc
            {
                  get
                  {
                        return this.double_149;
                  }
                  set
                  {
                        this.double_149 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_kiem_khach_Ho_than_cuong_khi
            {
                  get
                  {
                        return this.double_148;
                  }
                  set
                  {
                        this.double_148 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_kiem_khach_Hoi_lieu_than_phap
            {
                  get
                  {
                        return this.double_150;
                  }
                  set
                  {
                        this.double_150 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_kiem_khach_Lien_hoan_phi_vu
            {
                  get
                  {
                        return this.double_145;
                  }
                  set
                  {
                        this.double_145 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_kiem_khach_No_hai_cuong_lan
            {
                  get
                  {
                        return this.double_152;
                  }
                  set
                  {
                        this.double_152 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_kiem_khach_Tat_sat_nhat_kich
            {
                  get
                  {
                        return this.double_146;
                  }
                  set
                  {
                        this.double_146 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_kiem_khach_Trung_quan_nhat_no
            {
                  get
                  {
                        return this.double_151;
                  }
                  set
                  {
                        this.double_151 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_kiem_khach_Truong_hong_quan_nhat
            {
                  get
                  {
                        return this.double_143;
                  }
                  set
                  {
                        this.double_143 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_kinh_nghiem_ti_le_phan_tram
            {
                  get
                  {
                        return this.double_203;
                  }
                  set
                  {
                        this.double_203 = value;
                  }
            }

            public int FLD_trang_bi_them_vao_MP
            {
                  get
                  {
                        return this.int_108;
                  }
                  set
                  {
                        this.int_108 = value;
                  }
            }

            public int FLD_trang_bi_them_vao_ne_tranh
            {
                  get
                  {
                        return this.int_105;
                  }
                  set
                  {
                        this.int_105 = value;
                  }
            }

            public int FLD_trang_bi_them_vao_Phong_cu_Cuong_hoa
            {
                  get
                  {
                        if (this.int_103 < 0)
                        {
                              this.int_103 = 0;
                        }
                        return this.int_103;
                  }
                  set
                  {
                        this.int_103 = value;
                  }
            }

            public long FLD_trang_bi_them_vao_phong_ngu
            {
                  get
                  {
                        return this.long_15;
                  }
                  set
                  {
                        this.long_15 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_quyen_su_bang_hoa_mot_the
            {
                  get
                  {
                        return this._FLD_Kungfu_Qigong_6;
                  }
                  set
                  {
                        this._FLD_Kungfu_Qigong_6 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_quyen_su_cuong_phong_van_pha
            {
                  get
                  {
                        return this._FLD_Kungfu_Qigong_3;
                  }
                  set
                  {
                        this._FLD_Kungfu_Qigong_3 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_quyen_su_cuong_than_giang_the
            {
                  get
                  {
                        return this._FLD_Kungfu_Qigong_0;
                  }
                  set
                  {
                        this._FLD_Kungfu_Qigong_0 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_quyen_su_doi_cong_lam_thu
            {
                  get
                  {
                        return this._FLD_Kungfu_Qigong_5;
                  }
                  set
                  {
                        this._FLD_Kungfu_Qigong_5 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_quyen_su_hieu_y_mot_don
            {
                  get
                  {
                        return this._FLD_Kungfu_Qigong_7;
                  }
                  set
                  {
                        this._FLD_Kungfu_Qigong_7 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_quyen_su_kim_cuong_bat_hoai
            {
                  get
                  {
                        return this._FLD_Kungfu_Qigong_4;
                  }
                  set
                  {
                        this._FLD_Kungfu_Qigong_4 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_quyen_su_linh_giap_ho_than
            {
                  get
                  {
                        return this._FLD_Kungfu_Qigong_8;
                  }
                  set
                  {
                        this._FLD_Kungfu_Qigong_8 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_quyen_su_mai_xu_thanh_cham
            {
                  get
                  {
                        return this._FLD_Kungfu_Qigong_9;
                  }
                  set
                  {
                        this._FLD_Kungfu_Qigong_9 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_quyen_su_suc_manh_phach_Hoa_Son
            {
                  get
                  {
                        return this._FLD_Kungfu_Qigong_2;
                  }
                  set
                  {
                        this._FLD_Kungfu_Qigong_2 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_quyen_su_van_may_chua_thuong
            {
                  get
                  {
                        return this._FLD_Kungfu_Qigong_1;
                  }
                  set
                  {
                        this._FLD_Kungfu_Qigong_1 = value;
                  }
            }

            public int FLD_trang_bi_them_vao_sinh_menh
            {
                  get
                  {
                        return this.int_98;
                  }
                  set
                  {
                        this.int_98 = value;
                  }
            }

            public int FLD_trang_bi_them_vao_Suc_manh
            {
                  get
                  {
                        return this.int_97;
                  }
                  set
                  {
                        this.int_97 = value;
                  }
            }

            public int FLD_trang_bi_them_vao_than_the
            {
                  get
                  {
                        return this.int_101;
                  }
                  set
                  {
                        this.int_101 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_thich_khach_Kiem_nhan_loan_vu
            {
                  get
                  {
                        return this.double_191;
                  }
                  set
                  {
                        this.double_191 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_thich_khach_kinh_kha_chi_no
            {
                  get
                  {
                        return this.double_183;
                  }
                  set
                  {
                        this.double_183 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_thich_khach_Lien_hoan_phi_vu
            {
                  get
                  {
                        return this.double_185;
                  }
                  set
                  {
                        this.double_185 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_thich_khach_Lien_tieu_dai_da
            {
                  get
                  {
                        return this.double_192;
                  }
                  set
                  {
                        this.double_192 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_thich_khach_Tam_hoa_tu_dinh
            {
                  get
                  {
                        return this.double_184;
                  }
                  set
                  {
                        this.double_184 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_thich_khach_Tam_than_ngung_tu
            {
                  get
                  {
                        return this.double_187;
                  }
                  set
                  {
                        this.double_187 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_thich_khach_Tat_sat_nhat_kich
            {
                  get
                  {
                        return this.double_186;
                  }
                  set
                  {
                        this.double_186 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_thich_khach_Thien_chu_van_thu
            {
                  get
                  {
                        return this.double_190;
                  }
                  set
                  {
                        this.double_190 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_thich_khach_Tien_phat_che_nhan
            {
                  get
                  {
                        return this.double_189;
                  }
                  set
                  {
                        this.double_189 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_thich_khach_Tri_menh_tuyet_thu
            {
                  get
                  {
                        return this.double_188;
                  }
                  set
                  {
                        this.double_188 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_thu_duoc_tro_choi_te_ti_le_phan_tram
            {
                  get
                  {
                        return this.double_132;
                  }
                  set
                  {
                        this.double_132 = value;
                  }
            }

            public int FLD_trang_bi_them_vao_Thuc_tinh
            {
                  get
                  {
                        return this.int_99;
                  }
                  set
                  {
                        this.int_99 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_thuong_khach_Can_khon_na_di
            {
                  get
                  {
                        return this.double_159;
                  }
                  set
                  {
                        this.double_159 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_thuong_khach_Chuyen_thu_vi_cong
            {
                  get
                  {
                        return this.double_161;
                  }
                  set
                  {
                        this.double_161 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_thuong_khach_Cuong_phong_van_pha
            {
                  get
                  {
                        return this.double_157;
                  }
                  set
                  {
                        this.double_157 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_thuong_khach_Cuong_than_giang_the
            {
                  get
                  {
                        return this.double_162;
                  }
                  set
                  {
                        this.double_162 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_thuong_khach_Hoanh_luyen_thai_bao
            {
                  get
                  {
                        return this.double_158;
                  }
                  set
                  {
                        this.double_158 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_thuong_khach_Kim_chung_trao_khi
            {
                  get
                  {
                        return this.double_153;
                  }
                  set
                  {
                        this.double_153 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_thuong_khach_Lien_hoan_phi_vu
            {
                  get
                  {
                        return this.double_155;
                  }
                  set
                  {
                        this.double_155 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_thuong_khach_Linh_giap_ho_than
            {
                  get
                  {
                        return this.double_160;
                  }
                  set
                  {
                        this.double_160 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_thuong_khach_Tat_sat_nhat_kich
            {
                  get
                  {
                        return this.double_156;
                  }
                  set
                  {
                        this.double_156 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_thuong_khach_Van_khi_lieu_thuong
            {
                  get
                  {
                        return this.double_154;
                  }
                  set
                  {
                        this.double_154 = value;
                  }
            }

            public int FLD_trang_bi_them_vao_trai_tim
            {
                  get
                  {
                        return this.int_100;
                  }
                  set
                  {
                        this.int_100 = value;
                  }
            }

            public int FLD_trang_bi_them_vao_trung_muc_tieu
            {
                  get
                  {
                        return this.int_104;
                  }
                  set
                  {
                        this.int_104 = value;
                  }
            }

            public int FLD_trang_bi_them_vao_vu_khi_cuong_hoa
            {
                  get
                  {
                        if (this.int_102 < 0)
                        {
                              this.int_102 = 0;
                        }
                        return this.int_102;
                  }
                  set
                  {
                        this.int_102 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_y_cuu_thien_chan_khi
            {
                  get
                  {
                        return this.double_180;
                  }
                  set
                  {
                        this.double_180 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_y_dieu_thu_hoi_xuan
            {
                  get
                  {
                        return this.double_176;
                  }
                  set
                  {
                        this.double_176 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_y_hap_tinh_dai_phap
            {
                  get
                  {
                        return this.double_178;
                  }
                  set
                  {
                        this.double_178 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_y_tay_tuy_dich_kinh
            {
                  get
                  {
                        return this.double_175;
                  }
                  set
                  {
                        this.double_175 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_y_thai_cuc_tam_phap
            {
                  get
                  {
                        return this.double_174;
                  }
                  set
                  {
                        this.double_174 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_y_Than_Nong_tien_thuat
            {
                  get
                  {
                        return this.double_179;
                  }
                  set
                  {
                        this.double_179 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_y_the_huyet_boi_tang
            {
                  get
                  {
                        return this.double_181;
                  }
                  set
                  {
                        this.double_181 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_y_thien_huu_khi
            {
                  get
                  {
                        return this.double_182;
                  }
                  set
                  {
                        this.double_182 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_y_truong_cong_kich
            {
                  get
                  {
                        return this.double_177;
                  }
                  set
                  {
                        this.double_177 = value;
                  }
            }

            public double FLD_trang_bi_them_vao_y_van_may_hanh_tam
            {
                  get
                  {
                        return this.double_173;
                  }
                  set
                  {
                        this.double_173 = value;
                  }
            }

            public int FLD_TRUNG_MUC_TIEU
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

            public int FLD_VIP
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

            public DateTime FLD_VIPTIM
            {
                  get
                  {
                        return this.dateTime_7;
                  }
                  set
                  {
                        this.dateTime_7 = value;
                  }
            }

            public int FLD_Vo_cong_cong_kich
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

            public int FLD_Vo_cong_phong_ngu
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

            public int FLD_Vo_huan_them_vao_khi_cong
            {
                  get
                  {
                        return this.int_96;
                  }
                  set
                  {
                        this.int_96 = value;
                  }
            }

            public int FLD_WCVIP
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

            public DateTime FLD_WCVIPTIM
            {
                  get
                  {
                        return this.dateTime_4;
                  }
                  set
                  {
                        this.dateTime_4 = value;
                  }
            }

            public long GIET_NGUOI_SO_LAN
            {
                  get
                  {
                        return this.long_12;
                  }
                  set
                  {
                        this.long_12 = value;
                  }
            }

            public string GuildName
            {
                  get
                  {
                        return this.string_2;
                  }
                  set
                  {
                        this.string_2 = value;
                  }
            }

            public long Khen_thuong_them_vao_cong_kich
            {
                  get
                  {
                        return this.long_9;
                  }
                  set
                  {
                        this.long_9 = value;
                  }
            }

            public int Khen_thuong_them_vao_ne_tranh
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

            public int Khen_thuong_them_vao_noi_cong
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

            public long Khen_thuong_them_vao_phong_ngu
            {
                  get
                  {
                        return this.long_10;
                  }
                  set
                  {
                        this.long_10 = value;
                  }
            }

            public long Khen_thuong_them_vao_sinh_menh
            {
                  get
                  {
                        return this.long_8;
                  }
                  set
                  {
                        this.long_8 = value;
                  }
            }

            public int Khen_thuong_them_vao_trung_muc_tieu
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

            public int Ngoc_lien_hoan_ke_so
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

            public int Nhan_vat_co_ban_lon_nhat_HP
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

            public int Nhan_vat_co_ban_lon_nhat_MP
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

            public long NHAN_VAT_HP
            {
                  get
                  {
                        return this.long_3;
                  }
                  set
                  {
                        this.long_3 = value;
                  }
            }

            public int Nhan_vat_khi_cong_them_vao_HP
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

            public int Nhan_vat_khi_cong_them_vao_MP
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

            public int NHAN_VAT_KHINH_CONG
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

            public long NHAN_VAT_KINH_NGHIEM
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

            public int NHAN_VAT_LINH_THU_TOAN_BO_TRANG_PHUC_ID
            {
                  get
                  {
                        return ((this.UserSessionID * 2) + 0x9c40);
                  }
            }

            public long NHAN_VAT_LON_NHAT_HP
            {
                  get
                  {
                        return ((long)((((int)(((((this.Nhan_vat_co_ban_lon_nhat_HP + this.FLD_trang_bi_them_vao_HP) + this.Nhan_vat_khi_cong_them_vao_HP) + this.Nhan_vat_them_vao_lon_nhat_HP) * (1.0 + this.FLD_them_vao_ti_le_phan_tram_HP_han_muc_toi_da)) + this.Khen_thuong_them_vao_sinh_menh)) + this.Vo_Huan_them_vao_HP) + this.SU_DO_THEM_VAO_VO_CONG_SINH_MENH));
                  }
            }

            public long NHAN_VAT_LON_NHAT_KINH_NGHIEM
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

            public int NHAN_VAT_LON_NHAT_MP
            {
                  get
                  {
                        return ((((int)((((this.Nhan_vat_co_ban_lon_nhat_MP + this.FLD_trang_bi_them_vao_MP) + this.Nhan_vat_khi_cong_them_vao_MP) + this.Nhan_vat_them_vao_lon_nhat_MP) * (1.0 + this.FLD_them_vao_ti_le_phan_tram_MP_han_muc_toi_da))) + this.Khen_thuong_them_vao_noi_cong) + this.Vo_Huan_them_vao_MP);
                  }
            }

            public int NHAN_VAT_LON_NHAT_SP
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

            public int NHAN_VAT_MANG_NANG
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

            public int NHAN_VAT_MANG_NANG_TONG_TRONG_LUONG
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

            public int NHAN_VAT_MP
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

            public string NHAN_VAT_PHAN_KHU_ID
            {
                  get
                  {
                        return this.string_9;
                  }
                  set
                  {
                        this.string_9 = value;
                  }
            }

            public int NHAN_VAT_SP
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

            public byte[] NHAN_VAT_TEN_MAU
            {
                  get
                  {
                        return this.byte_4;
                  }
                  set
                  {
                        this.byte_4 = value;
                  }
            }

            public double NHAN_VAT_THEM_VAO_KINH_NGHIEM_TI_LE_PHAN_TRAM =>
                ((this.FLD_trang_bi_them_vao_kinh_nghiem_ti_le_phan_tram + this.FLD_Nhan_vat_them_vao_kinh_nghiem_ti_le_phan_tram) + this.Nhiet_huyet_phu_them_vao_kinh_nghiem_ti_le_phan_tram);

            public int Nhan_vat_them_vao_lon_nhat_HP
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

            public int Nhan_vat_them_vao_lon_nhat_MP
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

            public int NHAN_VAT_THIEN_AC
            {
                  get
                  {
                        return this.int_50;
                  }
                  set
                  {
                        if ((this.int_50 + value) > 0)
                        {
                              this.int_50 = 0;
                        }
                        else if ((this.int_50 - value) < -30000)
                        {
                              this.int_50 = -30000;
                        }
                        else
                        {
                              this.int_50 = value;
                        }
                  }
            }

            public int NHAN_VAT_VI_TRI
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

            public int NHAN_VAT_VO_HUAN_GIAI_DOAN
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

            public double Nhiet_huyet_phu_them_vao_kinh_nghiem_ti_le_phan_tram
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

            public string PHAN_KHU_ID
            {
                  get
                  {
                        return this.string_3;
                  }
                  set
                  {
                        this.string_3 = value;
                  }
            }

            public int Phu_the_vo_cong_luc_cong_kich
            {
                  get
                  {
                        if (this.bool_12)
                        {
                              return (this.int_18 + ((int)(this.int_18 * 0.1)));
                        }
                        return this.int_18;
                  }
                  set
                  {
                        this.int_18 = value;
                  }
            }

            public int Phu_the_vo_cong_luc_cong_kich_MP
            {
                  get
                  {
                        if (this.bool_12)
                        {
                              return (this.int_19 + ((int)(this.int_19 * 0.1)));
                        }
                        return this.int_19;
                  }
                  set
                  {
                        this.int_19 = value;
                  }
            }

            public int Player_ExpErience
            {
                  get
                  {
                        return this.int_29;
                  }
                  set
                  {
                        if (this.int_29 <= 0)
                        {
                              this.int_29 = 0x3b9ac9ff;
                        }
                        else
                        {
                              this.int_29 = value;
                        }
                  }
            }

            public int Player_Job
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

            public int Player_FLD_JOB_LEVEL
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

            public int Player_FLD_LEVEL
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

            public int Player_MaxWx
            {
                  get
                  {
                        return this.get_wx;
                  }
                  set
                  {
                        this.get_wx = value;
                  }
            }

            public long Player_Money
            {
                  get
                  {
                        return this.long_2;
                  }
                  set
                  {
                        if (value < 0L)
                        {
                              this.long_2 = 0L;
                        }
                        else
                        {
                              this.long_2 = value;
                        }
                  }
            }

            public int Player_Qigong_point
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

            public int Player_Sex
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

            public int Player_WuXun
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

            public int Player_Zx
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

            public bool PlayerIsDead
            {
                  get
                  {
                        if (this.NHAN_VAT_HP <= 0L)
                        {
                              this.bool_11 = false;
                        }
                        return this.bool_11;
                  }
                  set
                  {
                        this.bool_11 = value;
                  }
            }

            public int PlayerPKMode
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

            public int Rxjh_WX
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

            public int SU_DO_THEM_VAO_LUC_CONG_KICH
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

            public int SU_DO_THEM_VAO_PHONG_NGU
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

            public int SU_DO_THEM_VAO_SUC_PHONG_NGU_VO_CONG
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

            public int SU_DO_THEM_VAO_VO_CONG_SINH_MENH
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

            public string[] SU_DO_VO_CONG_DONG_NHAT
            {
                  get
                  {
                        return this.string_7;
                  }
                  set
                  {
                        this.string_7 = value;
                  }
            }

            public long Thanh_vien_thu_bac
            {
                  get
                  {
                        return this.long_13;
                  }
                  set
                  {
                        this.long_13 = value;
                  }
            }

            public int Thuong_ha_dieu_tinh_toan
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

            public long TONG_HOP_NHA_KHO_TIEN_SO
            {
                  get
                  {
                        return this.long_5;
                  }
                  set
                  {
                        this.long_5 = value;
                  }
            }

            public int TONG_QUAT_TUYEN_THOI_GIAN
            {
                  get
                  {
                        return BitConverter.ToInt32(this.byte_2, 0);
                  }
                  set
                  {
                        Buffer.BlockCopy(BitConverter.GetBytes(value), 0, this.byte_2, 0, 4);
                  }
            }

            public string Userid
            {
                  get
                  {
                        return this.string_0;
                  }
                  set
                  {
                        this.string_0 = value;
                  }
            }

            public string UserName
            {
                  get
                  {
                        return this.string_1;
                  }
                  set
                  {
                        this.string_1 = value;
                  }
            }

            public int UserSessionID
            {
                  get
                  {
                        return this.Client.int_3;
                  }
            }

            public int VO_HUAN_CAP_8_CO_HAY_KHONG_MO_RA
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

            public DateTime VO_HUAN_CAP_8_DOAN_THOI_GIAN
            {
                  get
                  {
                        return this.dateTime_8;
                  }
                  set
                  {
                        this.dateTime_8 = value;
                  }
            }

            public int Vo_Huan_them_vao_HP
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

            public int Vo_Huan_them_vao_MP
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
      }
}

