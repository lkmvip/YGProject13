namespace ns3
{
      using Newtonsoft.Json;
      using ns0;
      using ns1;
      using ns10;
      using ns11;
      using ns12;
      using ns13;
      using ns2;
      using ns4;
      using ns5;
      using ns6;
      using ns7;
      using ns8;
      using ns9;
      using RxjhServer;
      using System;
      using System.Collections;
      using System.Collections.Generic;
      using System.Data;
      using System.Data.SqlClient;
      using System.IO;
      using System.Net;
      using System.Security.Cryptography;
      using System.Text;
      using System.Threading;
      using System.Windows.Forms;

      internal class World
      {
            public static string Account_authentication_server_IP;
            public static int Account_authentication_server_port;
            public static string Additional_state;
            public static int After_deducting_money_deducted_points;
            public static int After_deducting_the_gold_buckle_score;
            public static ThreadSafeDictionary<int, Players> allConnectedChars;
            public static int AllItmelog;
            public static int An_toan_hinh_thuc_tieu_hao_CASH;
            public static int Ao_Bang_to_hop_tieu_hao_Loai_hinh;
            public static int Ao_Bang_to_hop_tieu_hao_so_luong;
            public static double Ao_choang_cuong_hoa_1_giai_doan_xac_suat;
            public static double Ao_choang_cuong_hoa_2_giai_doan_xac_suat;
            public static double Ao_choang_cuong_hoa_3_giai_doan_xac_suat;
            public static double Ao_choang_cuong_hoa_4_giai_doan_xac_suat;
            public static double Ao_choang_cuong_hoa_5_giai_doan_xac_suat;
            public static double Ao_choang_cuong_hoa_6_giai_doan_xac_suat;
            public static double Ao_choang_cuong_hoa_7_giai_doan_xac_suat;
            public static int Ao_choang_cuong_hoa_tieu_hao_Loai_hinh;
            public static string Ao_choang_cuong_hoa_tong_xac_suat;
            public static int Ao_choang_phan_giai_tieu_hao_Loai_hinh;
            public static int Ao_choang_to_hop_tieu_hao_Loai_hinh;
            public static string Application_help_combat_several_gold_bullions;
            public static int AtPort;
            public static string ATUM;
            public static int AutGC;
            public static bool Automatically_open_connection;
            public static int Babolat_Club_server_port;
            public static int BACH_BAO_CAC_BANG_PHACH_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP;
            public static string[] BACH_BAO_CAC_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU;
            public static string[] BACH_BAO_CAC_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG;
            public static string BACH_BAO_CAC_CAO_CAP_KY_NGOC_THACH;
            public static string Bach_bao_cac_dia_chi;
            public static string BACH_BAO_CAC_HAN_NGOC_THACH;
            public static string BACH_BAO_CAC_KIM_CUONG_THACH;
            public static int BACH_BAO_CAC_NGUNG_SUONG_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP;
            public static string[] BACH_BAO_CAC_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU;
            public static string[] BACH_BAO_CAC_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG;
            public static string BACH_BAO_CAC_NHIET_HUYET_THACH;
            public static string BACH_BAO_CAC_SO_CAP_KY_NGOC_THACH;
            public static string BACH_BAO_CAC_THAN_BI_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG;
            public static string BACH_BAO_CAC_THAN_BI_KIM_CUONG_THACH_TRUY_THUONG;
            public static int BACH_BAO_CAC_THUOC_TINH_THACH;
            public static string BACH_BAO_CAC_TRUNG_CAP_KY_NGOC_THACH;
            public static string[] BACH_BAO_CAN_KHON_KIM_CUONG_THACH_CONG_KICH;
            public static string[] BACH_BAO_CAN_KHON_KIM_CUONG_THACH_CONG_KICH_VO_CONG;
            public static int BACH_BAO_CAN_KHON_KIM_CUONG_THACH_LOAI_HINH_THIET_LAP;
            public static string[] BACH_BAO_HON_NGUYEN_KIM_CUONG_THACH_CONG_KICH;
            public static int BACH_BAO_HON_NGUYEN_KIM_CUONG_THACH_LOAI_HINH_THIET_LAP;
            public static string[] BACH_BAO_HON_NGUYEN_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG;
            public static string BACK;
            public static string Backpack_delete_items;
            public static int BackPack_Switch;
            public static string Ban_do_khoa_chat;
            public static string Bang_chien_nhan_so_khong_che;
            public static int Bang_chien_thoi_gian_chien_dau;
            public static string Bat_dau_the_luc_chien;
            public static int Boi_toan_tieu_hao_CASH;
            
            public static bool bool_0;
            public static bool bool_1;
            public static bool bool_10;
            public static bool bool_2;
            public static bool bool_5;
            public static string BOSS_hoang_da_thiet_lap;
            public static string BOSS_hoang_da_thiet_lap2;
            public static int BOSS_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP;
            public static string[] BOSS_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU;
            public static string[] BOSS_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG;
            public static string BOSS_QUAI_DROP_CAN_KHON_KIM_CUONG_THACH;
            public static string BOSS_QUAI_DROP_HAN_NGOC_THACH;
            public static string BOSS_QUAI_DROP_HON_NGUYEN_KIM_CUONG_THACH;
            public static string BOSS_QUAI_DROP_KIM_CUONG_THACH;
            public static int BOSS_QUAI_DROP_NGUNG_SUONG_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP;
            public static string[] BOSS_QUAI_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU;
            public static string[] BOSS_QUAI_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG;
            public static string BOSS_QUAI_DROP_NHIET_HUYET_THACH;
            public static string BOSS_QUAI_DROP_THAN_BI_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG;
            public static string BOSS_QUAI_DROP_THAN_BI_KIM_CUONG_THACH_TRUY_THUONG;
            public static int BOSS_QUAI_DROP_THUOC_TINH_THACH;
            public static THIET_LAP_BOSS_CLASS2 boss2;
            public static string Brush_experience;
            public static string Brush_strange;
            public static string Brush_Wu_Xun;
            public static int Ca_nhan_khieu_chien_co_hay_khong_mo_ra;
            public static int Cach_tuyen_Treo_thiet_bi_ban_do;
            public static string Cach_tuyen_Treo_thiet_bi_can_thiet_item_ID;
            public static string Cach_Tuyen_Treo_thiet_bi_khen_thuong;
            public static int Cach_Tuyen_Treo_thiet_bi_khen_thuong_co_hay_khong_mo_ra;
            public static int Cach_Tuyen_Treo_thiet_bi_khen_thuong_gui_di_Thoi_gian_khoang_cach;
            public static int Cach_Tuyen_Treo_thiet_bi_khen_thuong_han_che_thap_nhat_Dang_cap;
            public static string Cach_tuyen_Treo_thiet_bi_menh_lenh;
            public static string Cach_tuyen_Treo_thiet_bi_Nhac_nho_noi_dung;
            public static int Cach_tuyen_Treo_thiet_Dang_cap;
            public static string Cach_Tuyen_VIP_Treo_thiet_bi_khen_thuong;
            public static string Cam_PK_ban_do;
            public static string Cancel_help_combat_several_gold_bullions;
            public static int CAO_THU_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP;
            public static string[] CAO_THU_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU;
            public static string[] CAO_THU_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG;
            public static string CAO_THU_QUAI_DROP_CAN_KHON_KIM_CUONG_THACH;
            public static string CAO_THU_QUAI_DROP_HAN_NGOC_THACH;
            public static string CAO_THU_QUAI_DROP_HON_NGUYEN_KIM_CUONG_THACH;
            public static string CAO_THU_QUAI_DROP_KIM_CUONG_THACH;
            public static int CAO_THU_QUAI_DROP_NGUNG_SUONG_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP;
            public static string[] CAO_THU_QUAI_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU;
            public static string[] CAO_THU_QUAI_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG;
            public static string CAO_THU_QUAI_DROP_NHIET_HUYET_THACH;
            public static string CAO_THU_QUAI_DROP_THAN_BI_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG;
            public static string CAO_THU_QUAI_DROP_THAN_BI_KIM_CUONG_THACH_TRUY_THUONG;
            public static int CAO_THU_QUAI_DROP_THUOC_TINH_THACH;
            public static int CASH_do_luong;
            public static int CASH_hop_thanh;
            public static string Cau_hon_menh_lenh;
            public static string CH;
            public static string Chap_nhan_khieu_chien_la_to_noi_dung_1;
            public static string Chap_nhan_khieu_chien_la_to_noi_dung_2;
            public static string Chap_nhan_khieu_chien_la_to_noi_dung_3;
            public static int Cho_phep_item_ban_ra_lon_nhat_CASH_so_luong;
            public static int Cho_phep_mo_nhieu_So_luong;
            public static int Chuyen_sinh_can_level;
            public static int Chuyen_sinh_can_may_vong;
            public static int Chuyen_sinh_giam_xuong_level;
            public static int Chuyen_sinh_ha_xuong_may_vong;
            public static string Chuyen_sinh_khen_thuong_Item;
            public static int Chuyen_sinh_khen_thuong_loai_hinh;
            public static int Chuyen_sinh_khen_thuong_so_luong;
            public static string Chuyen_sinh_khen_thuong_Thuoc_tinh;
            public static int Chuyen_sinh_khen_thuong_trang_phuc;
            public static string Chuyen_sinh_menh_lenh;
            public static int Chuyen_sinh_so_lan_linh_thuong_khong_che;
            public static int Chuyen_sinh_thong_cao;
            public static string Chuyen_sinh_thong_cao_noi_dung;
            public static BANG_CHIEN_THIET_LAP class11_0;
            public static KHIEU_CHIEN_THIET_LAP_2 class12_0;
            public static Connect class20_0;
            public static KHIEU_CHIEN class61_0;
            public static THIET_LAP_BOSS_CLASS class76_0;
            public static bool Close_connection;
            public static int Co_hay_khong_bat_dau_dung_cach_tuyen_Treo_thiet_bi_nhac_nho;
            public static int Co_hay_khong_bat_dau_dung_di_thuong_xuat_huyet;
            public static int Co_hay_khong_bat_dau_dung_thanh_vien_thang_cap;
            public static int Co_hay_khong_ma_hoa;
            public static int Co_hay_khong_mo_ra_an_toan_hinh_thuc;
            public static int Co_hay_khong_mo_ra_ao_choang_cuong_hoa;
            public static int Co_hay_khong_mo_ra_cach_tuyen_Treo_thiet_bi;
            public static int Co_hay_khong_mo_ra_CASH_cua_hang;
            public static int Co_hay_khong_mo_ra_chuyen_sinh_so_lan_khen_thuong;
            public static int Co_hay_khong_mo_ra_cua_hang_CASH;
            public static int Co_hay_khong_mo_ra_Dang_cap_khen_thuong;
            public static int Co_hay_khong_mo_ra_o_tuyen_thoi_gian_khen_thuong;
            public static int Co_hay_khong_mo_ra_Vo_huan_he_thong;
            public static int Cong_kich_Xac_nhan_hinh_thuc;
            public static string Copy_Item;
            public static int Costume1;
            public static int Costume2;
            public static int CUA_HANG_BANG_PHACH_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP;
            public static string[] CUA_HANG_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU;
            public static string[] CUA_HANG_BANG_PHACH_HAN_NGOC_THACH_VO_CONG_PHONG_NGU;
            public static string CUA_HANG_CAN_KHON_KIM_CUONG_THACH;
            public static string CUA_HANG_HAN_NGOC_THACH;
            public static string CUA_HANG_HON_NGUYEN_KIM_CUONG_THACH;
            public static string CUA_HANG_KIM_CUONG_THACH;
            public static int CUA_HANG_NGUNG_SUONG_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP;
            public static string[] CUA_HANG_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU;
            public static string[] CUA_HANG_NGUNG_SUONG_HAN_NGOC_THACH_VO_CONG_PHONG_NGU;
            public static string CUA_HANG_NHIET_HUYET_THACH;
            public static string CUA_HANG_THAN_BI_KIM_CUONG_THACH_TRUY_THUONG;
            public static string CUA_HANG_THAN_BI_KIM_CUONG_THACH_VO_CONG;
            public static int CUA_HANG_THUOC_TINH_THACH;
            public static double CUNG_THU_TRI_MENH_TUYET_SAT_TY_LE;
            public static double CUNG_THU_VO_MINH_AM_THI_TY_LE;
            public static int Cuong_hoa_tieu_hao_So_luong;
            public static string Cuong_hoa_xac_xuat_khong_che;
            public static string Da_Luc_cong_kich_Vo_cong_hop_thanh_xac_xuat_khong_che;
            public static string Da_Suc_phong_ngu_hop_thanh_xac_xuat_khong_che;
            public static string Da_Vo_cong_phong_ngu_hop_thanh_xac_xuat_khong_che;
            public static int DAI_PHU_HOI_KHI_LIEU_THUONG_THEM_HP;
            public static int DAI_PHU_TU_KHI_LIEU_THUONG_THEM_HP;
            public static int DAI_PHU_VAN_KHI_LIEU_THUONG_THEM_HP;
            public static int Dang_ky_mon_phai_can_Dang_cap;
            public static string Dang_ky_mon_phai_can_thiet_Item_ID;
            public static int Dang_ky_mon_phai_can_tien_bac;
            public static int DANG_NHAP_GHI_CHEP;
            public static int Danh_quai_khoang_cach_khong_che_co_hay_khong_mo_ra;
            private static DateTime dateTime_0;
            public static int Day_chuyen_gia_cong_1_giai_doan_tang_cuong_phong_ngu;
            public static string DEL1;
            public static string DELBAD;
            public static string Di_dong_menh_lenh;
            public static Dictionary<int, ITEMSELL> dictionary_0;
            public static Dictionary<int, TRANG_BI_DO_LUONG> dictionary_1;
            public static Dictionary<int, TBL_XWWL_Gg> dictionary_10;
            public static Dictionary<int, TBL_XWWL_NPC> dictionary_11;
            public static Dictionary<int, MapClass> dictionary_12;
            public static Dictionary<int, TBL_XWWL_MONSTER> dictionary_13;
            public static Dictionary<int, DINH_NGHIA_CHUYEN_CHUC_THUOC_TINH> dictionary_15;
            public static Dictionary<int, DANG_CAP_KHEN_THUONG> dictionary_16;
            public static Dictionary<int, HE_THONG_CHAM_CONG_KHEN_THUONG_CLASS> dictionary_17;
            public static Dictionary<int, TRUC_TUYEN_THOI_GIAN_KHEN_THUONG> dictionary_18;
            public static Dictionary<int, CHUYEN_SINH_SO_LAN_KHEN_THUONG> dictionary_19;
            public static Dictionary<string, VUOT_AI_BAN_DO> dictionary_2;
            public static Dictionary<int, ITEM_TRAO_DOI> dictionary_20;
            public static Dictionary<int, GIET_NGUOI_NHAC_NHO> dictionary_21;
            public static Dictionary<int, TO_DOI_LOAI> dictionary_24;
            public static Dictionary<int, BANG_CHIEN_STRING> dictionary_25;
            public static Dictionary<int, TRANG_PHUC_DANH_SACH> dictionary_26;
            public static Dictionary<int, Class67> dictionary_27;
            public static Dictionary<string, Class53> dictionary_28;
            public static Dictionary<int, CHE_TAO_ITEM_DANH_SACH> dictionary_29;
            public static Dictionary<int, BoxtoGoldClass> dictionary_3;
            public static Dictionary<int, DA_THUOC_TINH_HIEU_QUA> dictionary_4;
            public static Dictionary<int, KHI_CONG_THANG_THIEN> dictionary_6;
            public static Dictionary<string, DBClass> dictionary_7;
            public static Dictionary<int, double> dictionary_9;
            public static bool Disconnect;
            public static int Do_bo_thiet_bi_hinh_thuc;
            public static double double_0;
            public static double double_1;
            public static double double_10;
            public static double double_2;
            public static double double_3;
            public static double double_8;
            public static double double_9;
            public static string Drop_Nhac_nho_noi_dung;
            public static string Duoc_pham_A;
            public static string Duoc_pham_B;
            public static string Duoc_pham_C;
            public static string Duoc_pham_D;
            public static string Duoc_pham_E;
            public static string Duoc_pham_F;
            public static string Duoc_pham_G;
            public static string Duoc_pham_H;
            public static double Empty_distance;
            public static string Enter_Bulletin;
            public static int Equipment_plus_unlock_switch;
            public static EventClass eve;
            public static Dictionary<string, EventTopClass> EventTop;
            public static int ForceOfWar_Switch;
            public static int Gain_experience_level_difference;
            public static int Game_landing_port_maximum_number_of_connections;
            public static int Game_server_port;
            public static int GangWar_Switch;
            public static int Ghi_chep_bao_ton_Thang_thien;
            public static int Gia_toc_khi_do_luong_Thoi_gian_tieu_diet;
            public static int Giang_ho_bao_tuong_cuong_hoa_giai_doan;
            public static string Gui_di_khieu_chien_thu_tuc_menh_lenh;
            public static int Gui_di_khieu_chien_thu_tuc_menh_lenh_can_CASH;
            public static int Han_che_chuyen_sinh_so_lan;
            public static double Han_che_PK_tam_khoang_cach;
            public static int Hap_hon_mo_ra;
            public static string Hap_hon_tuy_theo_so_luong;
            public static int Hap_hon_xac_suat;
            public static string He_thong_thu_ve_So_luong;
            public static double Hop_thanh_xac_xuat;
            public static string Hop_thanh_xac_xuat_khong_che;
            public static int int_105;
            public static int int_122;
            public static int int_127;
            public static int int_128;
            public static int int_129;
            public static int int_132;
            public static int int_196;
            public static int int_209;
            public static int int_213;
            public static int int_39;
            public static int int_40;
            public static int int_41;
            public static int int_42;
            public static int int_5;
            public static int int_86;
            public static int int_87;
            public static bool IP_closure;
            public static string Issued_notice;
            public static int Item_cao_nhat_Cong_kich_gia_tri;
            public static int Item_cao_nhat_hop_thanh_gia_tri;
            public static int Item_cao_nhat_khi_cong_gia_tri;
            public static int Item_cao_nhat_Ne_tranh_gia_tri;
            public static int Item_cao_nhat_Noi_cong_gia_tri;
            public static int Item_cao_nhat_Phong_ngu_gia_tri;
            public static int Item_cao_nhat_Sinh_menh_gia_tri;
            public static int Item_cao_nhat_Trung_muc_tieu_gia_tri;
            public static int Item_cao_nhat_vo_cong_gia_tri;
            public static int Item_Exchange_LUA_script_is_open;
            public static int ITEM_GHI_CHEP;
            public static string Item_khoa_chat;
            public static Dictionary<int, TBL_XWWL_ITEM> Itme;
            public static int jlMsg;
            public static int Job_Level;
            public static bool Join_filter_list;
            public static string Key;
            public static string Key2;
            public static int KHEN_THUONG_BANG_PHACH_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP;
            public static string[] KHEN_THUONG_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU;
            public static string[] KHEN_THUONG_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG;
            public static string KHEN_THUONG_CAN_KHON_KIM_CUONG_THACH;
            public static string KHEN_THUONG_HAN_NGOC_THACH;
            public static string KHEN_THUONG_HON_NGUYEN_KIM_CUONG_THACH;
            public static string KHEN_THUONG_KIM_CUONG_THACH;
            public static int KHEN_THUONG_NGUNG_SUONG_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP;
            public static string[] KHEN_THUONG_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU;
            public static string[] KHEN_THUONG_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG;
            public static string KHEN_THUONG_NHIET_HUYET_THACH;
            public static string KHEN_THUONG_THAN_BI_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG;
            public static string KHEN_THUONG_THAN_BI_KIM_CUONG_THACH_TRUY_THUONG;
            public static int KHEN_THUONG_THUOC_TINH_THACH;
            public static int KHI_CONG_CO_TAC_DUNG;
            public static double KHI_CONG_TI_LE_PHAN_TRAM;
            public static int Khieu_chien_ban_do_so_hieu;
            public static int Khieu_chien_ban_do_toa_do_X;
            public static int Khieu_chien_ban_do_toa_do_Y;
            public static int Khieu_chien_he_thong_thu_ve_CASH_So_luong;
            public static string Khieu_chien_la_to_noi_dung_1;
            public static string Khieu_chien_la_to_noi_dung_2;
            public static string Khieu_chien_la_to_noi_dung_3;
            public static string Khieu_chien_tham_gia_menh_lenh;
            public static int Khieu_chien_xin_can_thiet_CASH_So_luong;
            public static int Khu_an_toan_ban_do;
            public static int Khu_an_toan_mo_ra;
            public static float Khu_an_toan_X_toa_do;
            public static float Khu_an_toan_Y_toa_do;
            public static string Kicking;
            public static double KIEM_KHACH_HOI_LIEU_THAN_PHAP_NE_TRANH_TY_LE;
            public static double KIEM_KHACH_HOI_LIEU_THAN_PHAP_VO_CONG_UY_LUC;
            public static int Kiem_tra_phi_phap_Item;
            public static int Kiem_tra_phi_phap_Item_thao_tac;
            public static string Kiem_tra_thoi_gian_menh_lenh;
            public static string Kiem_tra_tin_tuc_menh_lenh;
            public static int Kiem_tra_trang_bi_Cap_bac_han_che;
            public static int Kiem_tra_trang_bi_mo_ra;
            public static bool Kiem_tra_Troi_chat_phi_phap_Item;
            public static int Kinh_nghiem_boi_so;
            public static int Ky_nang_boi_so;
            public static long Lan_theo_player_can_CASH_so_luong;
            public static Dictionary<int, double> lever;
            public static List<Players> list_0;
            public static List<TRANG_PHUC_THUOC_TINH> list_1;
            public static List<TBL_XWWL_DROP> list_10;
            public static List<TBL_XWWL_DROP> list_11;
            public static List<TBL_XWWL_OPEN> list_12;
            public static List<TBL_XWWL_VOME> list_13;
            public static List<TBL_XWWL_MAP> list_14;
            public static List<TBL_XWWL_MAP> list_15;
            public static List<object> list_16;
            public static List<IPAddress> list_17;
            public static List<Players> list_2;
            public static List<Players> list_3;
            public static List<TBL_XWWL_SELL> list_4;
            public static List<XWWL_JC> list_5;
            public static List<XWWL_kill> list_6;
            public static List<TBL_XWWL_NPC_DROP> list_7;
            public static List<TBL_XWWL_DROP> list_8;
            public static List<TBL_XWWL_DROP> list_9;
            public static List<ITEMSELL> ListItme;
            public static int Log;
            public static int Login_tang_le_bao_co_hay_khong_mo_ra;
            public static int Login_tang_le_bao_trang_phuc;
            public static int Login_thuoc_tinh_nhac_nho_mo_ra;
            public static long long_3;
            public static int Long_line_mode_is_turned_on;
            public static string Ly_hon_menh_lenh;
            public static int Maximum_Online;
            public static int Minimum_Admission_Fee;
            public static int MO_HOM_BANG_PHACH_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP;
            public static string[] MO_HOM_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU;
            public static string[] MO_HOM_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG;
            public static string[] MO_HOM_CAN_KHON_KIM_CUONG_THACH_CONG_KICH;
            public static int MO_HOM_CAN_KHON_KIM_CUONG_THACH_LOAI_HINH_THIET_LAP;
            public static string[] MO_HOM_CAN_KHON_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG;
            public static string MO_HOM_HAN_NGOC_THACH;
            public static string[] MO_HOM_HON_NGUYEN_DA_KIM_CUONG_LUC_CONG_KICH_VO_CONG;
            public static string[] MO_HOM_HON_NGUYEN_KIM_CUONG_THACH_CONG_KICH;
            public static int MO_HOM_HON_NGUYEN_KIM_CUONG_THACH_LOAI_HINH_THIET_LAP;
            public static string MO_HOM_KIM_CUONG_THACH;
            public static int MO_HOM_NGUNG_SUONG_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP;
            public static string[] MO_HOM_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU;
            public static string[] MO_HOM_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG;
            public static string MO_HOM_NHIET_HUYET_THACH;
            public static string MO_HOM_THAN_BI_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG;
            public static string MO_HOM_THAN_BI_KIM_CUONG_THACH_TRUY_THUONG;
            public static int MO_HOM_THUOC_TINH_THACH;
            public static string Mo_hop_ra_CASH;
            public static string Mobile_Carrier;
            public static int MOI_LAN_TAI_TAO_TIEU_HAO_THIET_LAP;
            public static int MOI_LAN_TIEU_HAO_SO_LUONG;
            public static string Mot_minh_dau_mo_ra_menh_lenh;
            public static int Multicolored_speak_Range;
            public static string Ngoi_tu_giet_nguoi_thong_cao;
            public static int Ngoi_tu_he_thong_co_hay_khong_mo_ra;
            public static int Ngoi_tu_khoi_phuc_thien_ac_diem_so;
            public static string Ngoi_tu_tha_ra_thong_cao;
            public static int Ngoi_tu_thien_ac;
            public static int Ngoi_tu_thien_ac_khoi_phuc_thoi_gian;
            public static string Ngoi_tu_tro_ve_thanh_toa_do;
            public static string Nguc_giam_ban_do;
            public static string Nguoi_moi_login_khen_thuong;
            public static int Nguoi_moi_login_khen_thuong_co_hay_khong_mo_ra;
            public static int Nhac_si_login_Dang_cap;
            public static int Nhan_gia_cong_1_giai_doan_tang_cuong_cong_kich;
            public static int Nhan_khac_chu_can_vang;
            public static int Nhan_vat_dang_cap_cao_nhat;
            public static int Nhan_vat_gan_nguoi_nghe_nghiep_cong_kich_khoang_cach;
            public static long Nhan_vat_level_cao_nhat;
            public static long Nhan_vat_lon_nhat_CASH_so_luong;
            public static int Nhan_vat_trinh_dien_nghe_nghiep_Cong_kich_khoang_cach;
            public static int Number_lock_ingot;
            public static string Number_of_points_gold_coins_to_help_draw;
            public static string Openbox_nhac_nho_noi_dung;
            public static int OpenWarTime_Hour;
            public static int OpenWarTime_Min;
            public static int OpenWarTime_Sec;
            public static int Packet_title;
            public static int Phan_giai_tieu_hao_So_luong;
            public static string Phan_khu_danh_so;
            public static int Phan_mem_hack_PK_switch;
            public static int Phat_ngon_dang_cap;
            public static int Phien_ban_nghiem_chung_Thoi_gian;
            public static string Phong_ngu_truy_sat_can_thiet_Item_ID;
            public static double Phu_hon_hop_thanh_xac_xuat_tang_cuong;
            public static string Phu_hon_menh_lenh;
            public static int Phu_the_skill_tu_luyen_Dang_cap;
            public static int PK_Dang_cap_chenh_lech;
            public static string[] PK_he_thong_han_che_ban_do;
            public static int PK_khoang_cach_khong_che_co_hay_khong_mo_ra;
            public static int PK_mat_CASH;
            public static int PK_mat_CASH_he_thong_thu_ve_so_luong;
            public static int PK_mat_level;
            public static int PK_out_equipment;
            public static int PK_out_equipment_chance;
            public static int PK_out_equipment_good_and_evil;
            public static int PKSwitch;
            public static string Player_lan_theo_menh_lenh;
            public static int Poets_mode_is_turned_on;
            public static string POINT;
            public static int QUAI_BINH_THUONG_DROP_BANG_PHACH_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP;
            public static string[] QUAI_BINH_THUONG_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU;
            public static string[] QUAI_BINH_THUONG_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG;
            public static string QUAI_BINH_THUONG_DROP_CAN_KHON_KIM_CUONG_THACH;
            public static string QUAI_BINH_THUONG_DROP_HAN_NGOC_THACH;
            public static string QUAI_BINH_THUONG_DROP_HON_NGUYEN_KIM_CUONG_THACH;
            public static string QUAI_BINH_THUONG_DROP_KIM_CUONG_THACH;
            public static int QUAI_BINH_THUONG_DROP_NGUNG_SUONG_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP;
            public static string[] QUAI_BINH_THUONG_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU;
            public static string[] QUAI_BINH_THUONG_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG;
            public static string QUAI_BINH_THUONG_DROP_NHIET_HUYET_THACH;
            public static string QUAI_BINH_THUONG_DROP_THAN_BI_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG;
            public static string QUAI_BINH_THUONG_DROP_THAN_BI_KIM_CUONG_THACH_TRUY_THUONG;
            public static int QUAI_BINH_THUONG_DROP_THUOC_TINH_THACH;
            public static int Quai_vat_gan_nguoi_nghe_nghiep_Cong_kich_khoang_cach;
            public static int Quai_vat_trinh_dien_nghe_nghiep_Cong_kich_khoang_cach;
            public static int DestroyMonsterScriptUSE;
            public static int Quan_ao_phu_hon_tang_cuong_Thuoc_tinh_So_luong;
            public static Queue queue_0;
            public static Queue queue_1;
            public static Queue queue_2;
            public static string Replace_Text_Filter;
            public static string REPRAN;
            public static double Restrictions_meditation_distance;
            public static int Retro_mode_is_enabled;
            public static string REZIAN;
            public static int Script;
            public static ScriptClass scriptClass_0;
            public static string Self_help_command_card;
            public static int Server_Group_ID;
            public static int Server_ID;
            public static string Server_Name_2;
            public static string ServerName;
            public static string Shuaqian;
            public static double Site_commission_percentage;
            public static float Site_valid_range;
            public static string SMS_channel_number;
            public static string SMS_payments_whether_to_open;
            public static string SMS_server_WEBID;
            public static string SMS_service_number;
            public static int SO_KHI_CONG_TANG_TOI_DA;
            public static string SqlJl;
            public static string Stealth;
            public static string string_0;
            public static string string_145;
            public static string string_42;
            public static int Sung_vat_Cong_kich_suc_manh_boi_so;
            public static string TAI_TAO_HAN_NGOC_THACH_NE_TRANH;
            public static string TAI_TAO_HAN_NGOC_THACH_NOI_CONG;
            public static string TAI_TAO_HAN_NGOC_THACH_PHONG_NGU;
            public static string TAI_TAO_HAN_NGOC_THACH_PHONG_NGU_VO_CONG;
            public static string TAI_TAO_HAN_NGOC_THACH_SINH_MENH;
            public static string TAI_TAO_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG;
            public static string TAI_TAO_KIM_CUONG_THACH_SINH_MENH;
            public static string TAI_TAO_KIM_CUONG_THACH_TAN_CONG;
            public static string TAI_TAO_KIM_CUONG_THACH_TRUNG_MUC_TIEU;
            public static string TAI_TAO_KIM_CUONG_THACH_TRUY_THUONG;
            public static string Tam_the_lam_dam_Nhac_nho_noi_dung;
            public static string Tam_the_mau_cam_Nhac_nho_noi_dung;
            public static string Tam_the_mau_do_nhac_nho_noi_dung;
            public static string Tam_the_mau_do_tham_Nhac_nho_noi_dung;
            public static string Tam_the_mau_tim_Nhac_nho_noi_dung;
            public static string Tam_the_mau_tim_nhat_Nhac_nho_noi_dung;
            public static string Tam_the_mau_xanh_lam_Nhac_nho_noi_dung;
            public static string Tam_the_mau_xanh_luc_Nhac_nho_noi_dung;
            public static string[] Tang_cuong_cong_kich_duoc_pham;
            public static string[] Tang_cuong_phong_ngu_duoc_pham;
            public static string[] Tang_cuong_sinh_menh_duoc_pham;
            public static Dictionary<int, TBL_XWWL_KONGFU> TBL_KONGFU;
            public static string Thang_cap_thanh_vien_can_Thuoc_tinh;
            public static string Thang_cap_thanh_vien_menh_lenh;
            public static double Thang_thien_kinh_nghiem_boi_so;
            public static int Thang_thien_skill_Dang_cap_bo_tro;
            public static string Thanh_ly_ba_lo_menh_lenh;
            public static string Thanh_ly_troi_chat_ba_lo_menh_lenh;
            public static int THE_LUC_CHIEN_2_CHINH_PHAI_DIEM_SO;
            public static int THE_LUC_CHIEN_2_CHINH_PHAI_SO_NGUOI;
            public static int THE_LUC_CHIEN_2_TA_PHAI_DIEM_SO;
            public static int THE_LUC_CHIEN_2_THOI_GIAN;
            public static int THE_LUC_CHIEN_2_TIEN_TRINH;
            public static string The_luc_chien_khen_thuong_Item;
            public static int The_luc_chien_khen_thuong_Loai_hinh;
            public static string The_luc_chien_khen_thuong_Thuoc_tinh;
            public static int The_luc_chien_khen_thuong_trang_phuc;
            public static int THE_LUC_CHIEN_TA_PHAI_SO_NGUOI;
            public static string The_luc_chien_tro_ve_Thanh_toa_do;
            public static int The_maximum_number_of_Idiom;
            public static int The_number_of_players_allowed_to_bet;
            public static int The_rate_of_violence;
            public static double THICH_KHACH_LIEN_HOAN_PHI_VU_UY_LUC;
            public static double THICH_KHACH_TAM_HOA_TU_DINH_TY_LE_TANG_CUONG;
            public static double THICH_KHACH_TAM_THAN_NGUNG_TU_UY_LUC;
            public static double THICH_KHACH_TAT_SAT_NHAT_KICH_UY_LUC;
            public static double THIEN_HUU_CHI_KHI_TI_LE_PHAN_TRAM;
            public static int thietlappvp;
            public static int Thoi_gian_an_toan_bat_dau;
            public static int Thoi_gian_an_toan_ket_thuc;
            public static int Thoi_gian_Duoc_pham_mo_ra;
            public static ThreadSafeDictionary<int, NetState> threadSafeDictionary_0;
            public static ThreadSafeDictionary<int, ClientIpAddress> threadSafeDictionary_2;
            public static ThreadSafeDictionary<long, MAT_DAT_ITEM_LOAI> threadSafeDictionary_3;
            public static int Thu_cong_phu_hon_giai_doan_cao_nhat;
            public static double THUA_THANG_TRUY_KICH_TY_LE_TANG_CUONG;
            public static int Thuoc_tinh_mo_rong_co_hay_khong_mo_ra;
            public static double THUONG_KHACH_CAN_KHON_NA_DI_VO_CONG_UY_LUC;
            public static int Tien_boi_so;
            public static int TimeSystemSwitch;
            public static int Tinh_nhan_mo_ra;
            public static string Title;
            public static int To_doi_Cap_bac_han_che;
            public static string To_help_fight_winning_gold_ingot_number;
            public static int To_hop_tieu_hao_so_luong;
            public static int Toc_do_do_luong_mo_ra;
            public static int Toc_do_do_luong_thao_tac;
            public static string Track;
            public static int trang_bi_Vo_huan_sua_chua_tieu_hao_Vo_huan_so_luong;
            public static int Trang_phuc_gui_di_mo_ra;
            public static string Treo_thiet_bi_khen_thuong;
            public static int Treo_thiet_bi_khen_thuong_co_hay_khong_mo_ra;
            public static int Treo_thiet_bi_khen_thuong_gui_di_Thoi_gian_khoang_cach;
            public static int Treo_thiet_bi_khen_thuong_han_che_thap_nhat_Dang_cap;
            public static int Tro_choi_do_bo_cang_lon_nhat_lien_tiep_Thoi_gian_so;
            public static string Trusted_Connection_IP;
            public static int Truy_sat_he_thong_co_hay_khong_mo_ra;
            public static int Tu_dong_lien_tiep_Thoi_gian;
            public static int Tu_dong_luu_tru;
            public static string Tu_vong_giam_thieu_Vo_huan_So_luong;
            public static int Tu_vong_kinh_nghiem_roi_xuong_co_hay_khong_mo_ra;
            public static string Tu_vong_tro_ve_thanh_Ban_do_Toa_do;
            public static string TUMMA;
            public static int Unlock_ingot_number;
            public static string UPGRADE;
            public static int Version_switch;
            public static string VIP_ban_do;
            public static double VIP_Hop_thanh_xac_xuat;
            public static double VIP_Kinh_nghiem_boi_so_ti_le_phan_tram;
            public static double VIP_ky_nang_boi_so_ti_le_phan_tram;
            public static int vip_line;
            public static int Vip_Login_thong_cao;
            public static string Vip_Login_thong_cao_noi_dung;
            public static string VIP_Treo_thiet_bi_khen_thuong;
            public static int Vo_cong_Cong_kich_suc_manh_khong_che;
            public static int Vo_cong_phong_ngu_hinh_thuc;
            public static int Vo_cong_Phong_ngu_suc_manh_khong_che;
            public static int Vo_huan_bao_ve_Dang_cap;
            public static string[] Vo_huan_giai_doan_1;
            public static string[] Vo_huan_giai_doan_2;
            public static string[] Vo_huan_giai_doan_3;
            public static string[] Vo_huan_giai_doan_4;
            public static string[] Vo_huan_giai_doan_5;
            public static string[] Vo_huan_giai_doan_6;
            public static string[] Vo_huan_giai_doan_7;
            public static string[] Vo_huan_giai_doan_8;
            public static int Vo_huan_gioi_han_nhan_duoc;
            public static double VO_KIEN_BAT_TOI_TY_LE_TANG_CUONG;
            public static int Vong_tai_gia_cong_1_giai_doan_tang_cuong_sinh_menh;
            public static int Vu_khi_phu_hon_tang_cuong_thuoc_tinh_so_luong;
            public static string Vuot_cua_ai_ban_do;
            public static Dictionary<int, TO_DOI_CLASS> W_TO_DOI;
            public static int Whether_to_open_the_field_for_practice_ingot_bet;
            public static int WorldTime;

            static World()
            {
                  ZYDNGuard();
            }

            public World()
            {
                  TimerClass.smethod_5(TimeSpan.FromMilliseconds(1000.0), TimeSpan.FromMilliseconds(1000.0), new Delegate10(this.WorldTimeEvent));
            }
           
            public static void delNpc(int int_229, int int_230)
            {
                  try
                  {
                        List<TBL_XWWL_NPC> list = new List<TBL_XWWL_NPC>();
                        foreach (TBL_XWWL_NPC tbl_xwwl_npc in MapClass.GetnpcTemplate(int_229).Values)
                        {
                              if (tbl_xwwl_npc.FLD_PID == int_230)
                              {
                                    list.Add(tbl_xwwl_npc);
                              }
                        }
                        using (List<TBL_XWWL_NPC>.Enumerator enumerator2 = list.GetEnumerator())
                        {
                              while (enumerator2.MoveNext())
                              {
                                    enumerator2.Current.Dispose();
                              }
                        }
                        list.Clear();
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(2, string.Concat(new object[] { "删除怪 [", int_230, "]出错：", exception }));
                  }
            }

            
            public void LOAD_CHUYEN_SINH_SO_LAN_KHEN_THUONG()
            {
                  DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT * FROM CHUYEN_SINH_SO_LAN_KHEN_THUONG", new object[0]), "PublicDb");
                  if (dBToDataTable != null)
                  {
                        if (dBToDataTable.Rows.Count == 0)
                        {
                              Form1.WriteLine(1, "Note: Rebirth system reward table is empty");
                        }
                        else
                        {
                              dictionary_19.Clear();
                              for (int i = 0; i < dBToDataTable.Rows.Count; i++)
                              {
                                    CHUYEN_SINH_SO_LAN_KHEN_THUONG chuyen_sinh_so_lan_khen_thuong = new CHUYEN_SINH_SO_LAN_KHEN_THUONG
                                    {
                                          CHUYEN_SINH_SO_LAN = (int)dBToDataTable.Rows[i]["CHUYEN_SINH_SO_LAN"],
                                          VO_HUAN = (int)dBToDataTable.Rows[i]["VO_HUAN"],
                                          CASH = (int)dBToDataTable.Rows[i]["CASH"],
                                          SINH_MENH = (int)dBToDataTable.Rows[i]["SINH_MENH"],
                                          CONG_KICH = (int)dBToDataTable.Rows[i]["CONG_KICH"],
                                          PHONG_NGU = (int)dBToDataTable.Rows[i]["PHONG_NGU"],
                                          NE_TRANH = (int)dBToDataTable.Rows[i]["NE_TRANH"],
                                          TRUNG_MUC_TIEU = (int)dBToDataTable.Rows[i]["TRUNG_MUC_TIEU"],
                                          NOI_CONG = (int)dBToDataTable.Rows[i]["NOI_CONG"],
                                          TRANG_PHUC_ID = (int)dBToDataTable.Rows[i]["TRANG_PHUC_ID"],
                                          TIEN_BAC = dBToDataTable.Rows[i]["TIEN_BAC"].ToString(),
                                          GOI_VIP_ITEM = dBToDataTable.Rows[i]["GOI_VIP_ITEM"].ToString(),
                                          THANH_VIEN_THANG_THIEN = (int)dBToDataTable.Rows[i]["THANH_VIEN_THANG_THIEN"]
                                    };
                                    dictionary_19.Add(i, chuyen_sinh_so_lan_khen_thuong);
                              }
                              Form1.WriteLine(2, "Loaded rebirth rewards: " + dBToDataTable.Rows.Count);
                        }
                        dBToDataTable.Dispose();
                  }
            }

            public void LOAD_DANG_CAP_KHEN_THUONG()
            {
                  DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT * FROM DANG_CAP_KHEN_THUONG", new object[0]), "PublicDb");
                  if (dBToDataTable != null)
                  {
                        if (dBToDataTable.Rows.Count == 0)
                        {
                              Form1.WriteLine(1, "Note: Class bonus table has been left empty");
                        }
                        else
                        {
                              dictionary_16.Clear();
                              for (int i = 0; i < dBToDataTable.Rows.Count; i++)
                              {
                                    DANG_CAP_KHEN_THUONG dang_cap_khen_thuong = new DANG_CAP_KHEN_THUONG
                                    {
                                          CAP_BAC = (int)dBToDataTable.Rows[i]["CAP_BAC"],
                                          VO_HUAN = (int)dBToDataTable.Rows[i]["VO_HUAN"],
                                          CASH = (int)dBToDataTable.Rows[i]["CASH"],
                                          SINH_MENH = (int)dBToDataTable.Rows[i]["SINH_MENH"],
                                          CONG_KICH = (int)dBToDataTable.Rows[i]["CONG_KICH"],
                                          PHONG_NGU = (int)dBToDataTable.Rows[i]["PHONG_NGU"],
                                          NE_TRANH = (int)dBToDataTable.Rows[i]["NE_TRANH"],
                                          TRUNG_MUC_TIEU = (int)dBToDataTable.Rows[i]["TRUNG_MUC_TIEU"],
                                          NOI_CONG = (int)dBToDataTable.Rows[i]["NOI_CONG"],
                                          TRANG_PHUC_ID = (int)dBToDataTable.Rows[i]["TRANG_PHUC_ID"],
                                          TIEN_BAC = dBToDataTable.Rows[i]["TIEN_BAC"].ToString(),
                                          GOI_VIP_VAT_PHAM_1 = dBToDataTable.Rows[i]["GOI_VIP_VAT_PHAM_1"].ToString(),
                                          GOI_VIP_VAT_PHAM_2 = dBToDataTable.Rows[i]["GOI_VIP_VAT_PHAM_2"].ToString(),
                                          THANH_VIEN_THU_BAC = (int)dBToDataTable.Rows[i]["THANH_VIEN_THU_BAC"],
                                          THANH_VIEN_THANG_THIEN = (int)dBToDataTable.Rows[i]["THANH_VIEN_THANG_THIEN"]
                                    };
                                    dictionary_16.Add(i, dang_cap_khen_thuong);
                              }
                              Form1.WriteLine(2, "Loaded class bonuses: " + dBToDataTable.Rows.Count);
                        }
                        dBToDataTable.Dispose();
                  }
            }

            public void LOAD_DINH_NGHIA_CHUYEN_CHUC_THUOC_TINH()
            {
                  DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT * FROM DINH_NGHIA_CHUYEN_CHUC_THUOC_TINH", new object[0]), "PublicDb");
                  if (dBToDataTable != null)
                  {
                        if (dBToDataTable.Rows.Count == 0)
                        {
                              Form1.WriteLine(1, "Note: No promotion bonuses have been added.");
                        }
                        else
                        {
                              dictionary_15.Clear();
                              for (int i = 0; i < dBToDataTable.Rows.Count; i++)
                              {
                                    DINH_NGHIA_CHUYEN_CHUC_THUOC_TINH dinh_nghia_chuyen_chuc_thuoc_tinh = new DINH_NGHIA_CHUYEN_CHUC_THUOC_TINH
                                    {
                                          FLD_JOB_LEVEL = (int)dBToDataTable.Rows[i]["FLD_JOB_LEVEL"],
                                          FLD_AT = (int)dBToDataTable.Rows[i]["FLD_AT"],
                                          FLD_DF = (int)dBToDataTable.Rows[i]["FLD_DF"],
                                          FLD_HP = (int)dBToDataTable.Rows[i]["FLD_HP"],
                                          FLD_MP = (int)dBToDataTable.Rows[i]["FLD_MP"]
                                    };
                                    dictionary_15.Add(i, dinh_nghia_chuyen_chuc_thuoc_tinh);
                              }
                              Form1.WriteLine(2, "Loaded promotion bonuses: " + dBToDataTable.Rows.Count);
                        }
                        dBToDataTable.Dispose();
                  }
            }

            public void LOAD_ITEM_TRAO_DOI()
            {
                  DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT * FROM ITEM_TRAO_DOI", new object[0]), "PublicDb");
                  if (dBToDataTable != null)
                  {
                        if (dBToDataTable.Rows.Count == 0)
                        {
                              Form1.WriteLine(1, "Note: Item Exchange table is empty");
                        }
                        else
                        {
                              dictionary_20.Clear();
                              for (int i = 0; i < dBToDataTable.Rows.Count; i++)
                              {
                                    ITEM_TRAO_DOI item_trao_doi = new ITEM_TRAO_DOI
                                    {
                                          CAN_ITEM = dBToDataTable.Rows[i]["CAN_ITEM"].ToString(),
                                          VO_HUAN = (int)dBToDataTable.Rows[i]["VO_HUAN"],
                                          CASH = (int)dBToDataTable.Rows[i]["CASH"],
                                          SINH_MENH = (int)dBToDataTable.Rows[i]["SINH_MENH"],
                                          CONG_KICH = (int)dBToDataTable.Rows[i]["CONG_KICH"],
                                          PHONG_NGU = (int)dBToDataTable.Rows[i]["PHONG_NGU"],
                                          NE_TRANH = (int)dBToDataTable.Rows[i]["NE_TRANH"],
                                          TRUNG_MUC_TIEU = (int)dBToDataTable.Rows[i]["TRUNG_MUC_TIEU"],
                                          NOI_CONG = (int)dBToDataTable.Rows[i]["NOI_CONG"],
                                          TRANG_PHUC_ID = (int)dBToDataTable.Rows[i]["TRANG_PHUC_ID"],
                                          TIEN_BAC = dBToDataTable.Rows[i]["TIEN_BAC"].ToString(),
                                          GOI_VIP_ITEM = dBToDataTable.Rows[i]["GOI_VIP_ITEM"].ToString(),
                                          THUYET_MINH = dBToDataTable.Rows[i]["THUYET_MINH"].ToString()
                                    };
                                    dictionary_20.Add(i, item_trao_doi);
                              }
                              Form1.WriteLine(2, "Loaded item exchanges: " + dBToDataTable.Rows.Count);
                        }
                        dBToDataTable.Dispose();
                  }
            }

            public void LOAD_TRUC_TUYEN_THOI_GIAN_KHEN_THUONG()
            {
                  DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT * FROM TRUC_TUYEN_THOI_GIAN_KHEN_THUONG", new object[0]), "PublicDb");
                  if (dBToDataTable != null)
                  {
                        if (dBToDataTable.Rows.Count == 0)
                        {
                              Form1.WriteLine(1, "Note: Online time bonus system rewards are empty");
                        }
                        else
                        {
                              dictionary_18.Clear();
                              for (int i = 0; i < dBToDataTable.Rows.Count; i++)
                              {
                                    TRUC_TUYEN_THOI_GIAN_KHEN_THUONG truc_tuyen_thoi_gian_khen_thuong = new TRUC_TUYEN_THOI_GIAN_KHEN_THUONG
                                    {
                                          THOI_GIAN_PHUT = (int)dBToDataTable.Rows[i]["THOI_GIAN_PHUT"],
                                          VO_HUAN = (int)dBToDataTable.Rows[i]["VO_HUAN"],
                                          CASH = (int)dBToDataTable.Rows[i]["CASH"],
                                          SINH_MENH = (int)dBToDataTable.Rows[i]["SINH_MENH"],
                                          CONG_KICH = (int)dBToDataTable.Rows[i]["CONG_KICH"],
                                          PHONG_NGU = (int)dBToDataTable.Rows[i]["PHONG_NGU"],
                                          NE_TRANH = (int)dBToDataTable.Rows[i]["NE_TRANH"],
                                          TRUNG_MUC_TIEU = (int)dBToDataTable.Rows[i]["TRUNG_MUC_TIEU"],
                                          NOI_CONG = (int)dBToDataTable.Rows[i]["NOI_CONG"],
                                          TRANG_PHUC_ID = (int)dBToDataTable.Rows[i]["TRANG_PHUC_ID"],
                                          TIEN_BAC = dBToDataTable.Rows[i]["TIEN_BAC"].ToString(),
                                          GOI_VIP_ITEM = dBToDataTable.Rows[i]["GOI_VIP_ITEM"].ToString()
                                    };
                                    dictionary_18.Add(i, truc_tuyen_thoi_gian_khen_thuong);
                              }
                              Form1.WriteLine(2, "Loaded online time bonuses: " + dBToDataTable.Rows.Count);
                        }
                        dBToDataTable.Dispose();
                  }
            }

            public void method_10()
            {
                  try
                  {
                        dictionary_2.Clear();
                        char[] separator = new char[] { ';' };
                        string[] strArray = Vuot_cua_ai_ban_do.Split(separator);
                        if (strArray.Length > 1)
                        {
                              for (int i = 0; i < strArray.Length; i++)
                              {
                                    char[] chArray2 = new char[] { ',' };
                                    string[] strArray2 = strArray[i].Split(chArray2);
                                    if ((strArray2.Length > 1) && !dictionary_2.ContainsKey(strArray2[0]))
                                    {
                                          VUOT_AI_BAN_DO vuot_ai_ban_do = new VUOT_AI_BAN_DO
                                          {
                                                TEN_BAN_DO = strArray2[0],
                                                ItmeID = int.Parse(strArray2[1])
                                          };
                                          dictionary_2.Add(vuot_ai_ban_do.TEN_BAN_DO, vuot_ai_ban_do);
                                    }
                              }
                        }
                        Form1.WriteLine(2, "The logger plugin is loaded successfully");
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "The logger plugin is loaded successfully" + exception.Message);
                  }
            }

            public void method_11()
            {
                  TBL_XWWL_MAP item = new TBL_XWWL_MAP
                  {
                        Rxjh_name = "Securityzone",
                        Rxjh_Map = Khu_an_toan_ban_do,
                        Rxjh_X = Khu_an_toan_X_toa_do,
                        Rxjh_Y = Khu_an_toan_Y_toa_do,
                        Rxjh_Z = 15f
                  };
                  list_14.Add(item);
                  Form1.WriteLine(2, "Security zone loading success");
            }

            public void method_14()
            {
                  if (Kiem_tra_phi_phap_Item == 2)
                  {
                        DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT * FROM TRANG_BI_DO_LUONG", new object[0]), "PublicDb");
                        if (dBToDataTable != null)
                        {
                              if (dBToDataTable.Rows.Count != 0)
                              {
                                    dictionary_1.Clear();
                                    for (int i = 0; i < dBToDataTable.Rows.Count; i++)
                                    {
                                          TRANG_BI_DO_LUONG trang_bi_do_luong = new TRANG_BI_DO_LUONG
                                          {
                                                ITEM_CAO_NHAT_CONG_KICH_GIA_TRI = (int)dBToDataTable.Rows[i]["ITEM_CAO_NHAT_CONG_KICH_GIA_TRI"],
                                                ITEM_CAO_NHAT_PHONG_NGU_GIA_TRI = (int)dBToDataTable.Rows[i]["ITEM_CAO_NHAT_PHONG_NGU_GIA_TRI"],
                                                ITEM_CAO_NHAT_SINH_MENH_GIA_TRI = (int)dBToDataTable.Rows[i]["ITEM_CAO_NHAT_SINH_MENH_GIA_TRI"],
                                                ITEM_CAO_NHAT_NOI_CONG_GIA_TRI = (int)dBToDataTable.Rows[i]["ITEM_CAO_NHAT_NOI_CONG_GIA_TRI"],
                                                ITEM_CAO_NHAT_TRUNG_MUC_TIEU_GIA_TRI = (int)dBToDataTable.Rows[i]["ITEM_CAO_NHAT_TRUNG_MUC_TIEU_GIA_TRI"],
                                                ITEM_CAO_NHAT_NE_TRANH_GIA_TRI = (int)dBToDataTable.Rows[i]["ITEM_CAO_NHAT_NE_TRANH_GIA_TRI"],
                                                ITEM_CAO_NHAT_VO_CONG_GIA_TRI = (int)dBToDataTable.Rows[i]["ITEM_CAO_NHAT_VO_CONG_GIA_TRI"],
                                                ITEM_CAO_NHAT_KHI_CONG_GIA_TRI = (int)dBToDataTable.Rows[i]["ITEM_CAO_NHAT_KHI_CONG_GIA_TRI"],
                                                ITEM_CAO_NHAT_PHU_HON_GIA_TRI = (int)dBToDataTable.Rows[i]["ITEM_CAO_NHAT_PHU_HON_GIA_TRI"]
                                          };
                                          dictionary_1.Add((int)dBToDataTable.Rows[i]["ITEM_LOAI_HINH"], trang_bi_do_luong);
                                    }
                                    Form1.WriteLine(2, "Loading equipment test data Complete: " + dBToDataTable.Rows.Count);
                              }
                              dBToDataTable.Dispose();
                        }
                  }
            }

            public void method_15()
            {
                  DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT * FROM XWWL_kill", new object[0]), "PublicDb");
                  if (dBToDataTable != null)
                  {
                        if (dBToDataTable.Rows.Count == 0)
                        {
                              Form1.WriteLine(1, "Error loading filter----There is no announcement of data");
                        }
                        else
                        {
                              list_6.Clear();
                              for (int i = 0; i < dBToDataTable.Rows.Count; i++)
                              {
                                    XWWL_kill item = new XWWL_kill
                                    {
                                          Txt = dBToDataTable.Rows[i]["txt"].ToString(),
                                          Sffh = (int)dBToDataTable.Rows[i]["sffh"]
                                    };
                                    list_6.Add(item);
                              }
                              Form1.WriteLine(2, "Filtering data loading Complete: " + dBToDataTable.Rows.Count);
                        }
                        dBToDataTable.Dispose();
                  }
            }

            public void method_17()
            {
                  DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT * FROM XWWL_JC", new object[0]), "PublicDb");
                  if (dBToDataTable != null)
                  {
                        if (dBToDataTable.Rows.Count == 0)
                        {
                              Form1.WriteLine(1, "Check the items loaded error----No inspection item data");
                        }
                        else
                        {
                              list_5.Clear();
                              for (int i = 0; i < dBToDataTable.Rows.Count; i++)
                              {
                                    XWWL_JC item = new XWWL_JC
                                    {
                                          FLD_PID = (int)dBToDataTable.Rows[i]["FLD_PID"],
                                          FLD_TYPE = (int)dBToDataTable.Rows[i]["FLD_TYPE"],
                                          FLD_MAGIC1 = (int)dBToDataTable.Rows[i]["FLD_MAGIC1"],
                                          FLD_MAGIC1_1 = dBToDataTable.Rows[i]["FLD_MAGIC1_1"].ToString(),
                                          FLD_MAGIC2 = (int)dBToDataTable.Rows[i]["FLD_MAGIC2"],
                                          FLD_MAGIC2_2 = dBToDataTable.Rows[i]["FLD_MAGIC2_2"].ToString(),
                                          FLD_MAGIC3 = (int)dBToDataTable.Rows[i]["FLD_MAGIC3"],
                                          FLD_MAGIC3_3 = dBToDataTable.Rows[i]["FLD_MAGIC3_3"].ToString(),
                                          FLD_MAGIC4 = (int)dBToDataTable.Rows[i]["FLD_MAGIC4"],
                                          FLD_MAGIC4_4 = dBToDataTable.Rows[i]["FLD_MAGIC4_4"].ToString(),
                                          FLD_MAGIC5 = (int)dBToDataTable.Rows[i]["FLD_MAGIC5"],
                                          FLD_MAGIC5_5 = dBToDataTable.Rows[i]["FLD_MAGIC5_5"].ToString()
                                    };
                                    list_5.Add(item);
                              }
                              Form1.WriteLine(2, "Check item data loading Complete: " + dBToDataTable.Rows.Count);
                        }
                        dBToDataTable.Dispose();
                  }
            }

            public void method_19()
            {
                  DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT * FROM DA_THUOC_TINH_HIEU_QUA", new object[0]), "PublicDb");
                  if (dBToDataTable != null)
                  {
                        if (dBToDataTable.Rows.Count == 0)
                        {
                              Form1.WriteLine(1, "Error loading effect stone property----No stone property performance data");
                        }
                        else
                        {
                              dictionary_4.Clear();
                              for (int i = 0; i < dBToDataTable.Rows.Count; i++)
                              {
                                    DA_THUOC_TINH_HIEU_QUA da_thuoc_tinh_hieu_qua = new DA_THUOC_TINH_HIEU_QUA
                                    {
                                          FLD_ID = (int)dBToDataTable.Rows[i]["FLD_ID"],
                                          FLD_TI_LE_PHAN_TRAM = (int)dBToDataTable.Rows[i]["FLD_TI_LE_PHAN_TRAM"]
                                    };
                                    dictionary_4.Add(i, da_thuoc_tinh_hieu_qua);
                              }
                              Form1.WriteLine(2, "Stone property performance data loading Complete: " + dBToDataTable.Rows.Count);
                        }
                        dBToDataTable.Dispose();
                  }
            }

            public void method_29()
            {
                  DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT * FROM GIET_NGUOI_NHAC_NHO", new object[0]), "PublicDb");
                  if (dBToDataTable != null)
                  {
                        if (dBToDataTable.Rows.Count == 0)
                        {
                              Form1.WriteLine(1, "Loading murder prompt an error----No murder prompted data");
                        }
                        else
                        {
                              dictionary_21.Clear();
                              for (int i = 0; i < dBToDataTable.Rows.Count; i++)
                              {
                                    GIET_NGUOI_NHAC_NHO giet_nguoi_nhac_nho = new GIET_NGUOI_NHAC_NHO
                                    {
                                          GIET_NGUOI_SO_LAN_NHO_NHAT = (int)dBToDataTable.Rows[i]["GIET_NGUOI_SO_LAN_NHO_NHAT"],
                                          GIET_NGUOI_SO_LAN_LON_NHAT = (int)dBToDataTable.Rows[i]["GIET_NGUOI_SO_LAN_LON_NHAT"],
                                          DANG_NHAP_NHAC_NHO = dBToDataTable.Rows[i]["LOGIN_NHAC_NHO"].ToString()
                                    };
                                    dictionary_21.Add(i, giet_nguoi_nhac_nho);
                              }
                              Form1.WriteLine(2, "Loading data murder prompt completion: " + dBToDataTable.Rows.Count);
                        }
                        dBToDataTable.Dispose();
                  }
            }

            public void method_7()
            {
                  try
                  {
                        dictionary_28.Clear();
                        string[] strArray = File.ReadAllLines(Application.StartupPath + @"\translation.lua", Encoding.Default);
                        for (int i = 0; i < strArray.Length; i++)
                        {
                              char[] separator = new char[] { '*' };
                              string[] strArray2 = strArray[i].Split(separator);
                              if (!dictionary_28.ContainsKey(strArray2[0]))
                              {
                                    Class53 class2 = new Class53
                                    {
                                          string_0 = strArray2[0],
                                          string_1 = strArray2[1]
                                    };
                                    dictionary_28.Add(strArray2[0], class2);
                              }
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "Error loading text replacement---" + exception.Message);
                  }
            }

            public void method_9()
            {
                  try
                  {
                        dictionary_3.Clear();
                        char[] separator = new char[] { ';' };
                        string[] strArray = Mo_hop_ra_CASH.Split(separator);
                        if (strArray.Length > 1)
                        {
                              for (int i = 0; i < strArray.Length; i++)
                              {
                                    char[] chArray2 = new char[] { ',' };
                                    string[] strArray2 = strArray[i].Split(chArray2);
                                    if ((strArray2.Length > 1) && !dictionary_3.ContainsKey(int.Parse(strArray2[0])))
                                    {
                                          BoxtoGoldClass class2 = new BoxtoGoldClass
                                          {
                                                ItmeID = int.Parse(strArray2[0]),
                                                NGUYEN_BAO = int.Parse(strArray2[1])
                                          };
                                          dictionary_3.Add(class2.ItmeID, class2);
                                    }
                              }
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "加载箱子送元宝出错---" + exception.Message);
                  }
            }

            public static void ProcessDisposedQueue()
            {
                  int num = 0;
                  try
                  {
                        if (jlMsg == 1)
                        {
                              Form1.WriteLine(0, "ProcessDisposedQueue111()");
                        }
                        int num2 = 0;
                        while (num2 < 200)
                        {
                              if (queue_0.Count <= 0)
                              {
                                    return;
                              }
                              if (jlMsg == 1)
                              {
                                    Form1.WriteLine(0, "ProcessDisposedQueue");
                              }
                              num2++;
                              NetState state = (NetState)queue_0.Dequeue();
                              try
                              {
                                    num = 1;
                                    if (state != null)
                                    {
                                          Form1.WriteLine(3, string.Concat(new object[] { "退出[", state.int_3, "]-[", state.ToString(), "]" }));
                                          num = 2;
                                          if (state.bool_0)
                                          {
                                                state.method_25();
                                          }
                                          num = 3;
                                          if (state.Player != null)
                                          {
                                                num = 4;
                                                state.Player.Players_Logout();
                                                num = 5;
                                                state.Player.Dispose();
                                          }
                                          num = 6;
                                          if (allConnectedChars.ContainsKey(state.int_3))
                                          {
                                                num = 7;
                                                allConnectedChars.Remove(state.int_3);
                                          }
                                          num = 8;
                                          state.Player = null;
                                          num = 9;
                                          state.delWorldID();
                                          num = 10;
                                          state = null;
                                    }
                                    else
                                    {
                                          Form1.WriteLine(1, "ns is null");
                                    }
                                    continue;
                              }
                              catch (Exception exception)
                              {
                                    Form1.WriteLine(1, string.Concat(new object[] { "ProcessDisposedQueue()出错 ", num, "  ", exception.Message }));
                                    continue;
                              }
                        }
                  }
                  catch (Exception exception2)
                  {
                        Form1.WriteLine(1, string.Concat(new object[] { "ProcessDisposedQueue()出错2 ", num, " 数据队列:", queue_0.Count, "  ", exception2.Message }));
                  }
            }

            public static void ProcessSqlQueue()
            {
                  try
                  {
                        if (jlMsg == 1)
                        {
                              Form1.WriteLine(0, "ProcessSqlQueue111()");
                        }
                        while (queue_1.Count > 0)
                        {
                              if (jlMsg == 1)
                              {
                                    Form1.WriteLine(0, "ProcessSqlQueue");
                              }
                              DbPool_Class class2 = (DbPool_Class)queue_1.Dequeue();
                              try
                              {
                                    if (DbPool_Class.smethod_0(class2.Conn, class2.Sql, class2.Prams, class2.Type) == -1)
                                    {
                                          queue_1.Enqueue(class2);
                                          Form1.WriteLine(1, "ProcessSqlQueue()2 数据库连接出错 " + queue_1.Count);
                                          Thread.Sleep(500);
                                    }
                                    continue;
                              }
                              catch (Exception exception)
                              {
                                    Form1.WriteLine(1, "ProcessSqlQueue()1出错 " + exception);
                                    Thread.Sleep(1);
                                    continue;
                              }
                        }
                  }
                  catch (Exception exception2)
                  {
                        Form1.WriteLine(1, "ProcessSqlQueue()出错 " + exception2);
                  }
            }

            public static void SendMsg(string string_218)
            {
                  using (IEnumerator<Players> enumerator = allConnectedChars.Values.GetEnumerator())
                  {
                        while (enumerator.MoveNext())
                        {
                              enumerator.Current.System_Announcement(string_218);
                        }
                  }
            }

            public void Set_CHE_TAO_VAT_PHAM()
            {
                  DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT * FROM CHE_TAO_ITEM_DANH_SACH ORDER BY ITEM_ID", new object[0]), "PublicDb");
                  if (dBToDataTable != null)
                  {
                        if (dBToDataTable.Rows.Count == 0)
                        {
                              Form1.WriteLine(1, "Note: Item list table is empty");
                        }
                        else
                        {
                              dictionary_29.Clear();
                              int num = 0;
                              while (true)
                              {
                                    if (num >= dBToDataTable.Rows.Count)
                                    {
                                          break;
                                    }
                                    CHE_TAO_ITEM_DANH_SACH che_tao_item_danh_sach = new CHE_TAO_ITEM_DANH_SACH();
                                    try
                                    {
                                          che_tao_item_danh_sach.ITEM_ID = (int)dBToDataTable.Rows[num]["ITEM_ID"];
                                          che_tao_item_danh_sach.ITEM_TEN = dBToDataTable.Rows[num]["ITEM_TEN"].ToString();
                                          che_tao_item_danh_sach.ITEM_SO_LUONG = (int)dBToDataTable.Rows[num]["ITEM_SO_LUONG"];
                                          che_tao_item_danh_sach.CHE_TAO_LOAI_HINH = (int)dBToDataTable.Rows[num]["CHE_TAO_LOAI_HINH"];
                                          che_tao_item_danh_sach.CHE_TAO_DANG_CAP = (int)dBToDataTable.Rows[num]["CHE_TAO_DANG_CAP"];
                                          string str = dBToDataTable.Rows[num]["CAN_ITEM"].ToString();
                                          che_tao_item_danh_sach.CAN_ITEM = JsonConvert.DeserializeObject<List<CHE_TAC_CAN_ITEM_LOAI>>(str);
                                          if (!dictionary_29.ContainsKey(che_tao_item_danh_sach.ITEM_ID))
                                          {
                                                dictionary_29.Add(che_tao_item_danh_sach.ITEM_ID, che_tao_item_danh_sach);
                                          }
                                    }
                                    catch (Exception exception)
                                    {
                                          Form1.WriteLine(1, string.Concat(new object[] { "加载制作VAT_PHAM 错误", che_tao_item_danh_sach.ITEM_ID, "  ", exception.Message }));
                                    }
                                    num++;
                              }
                              Form1.WriteLine(2, "Load the production of goods: " + dBToDataTable.Rows.Count);
                        }
                  }
            }

            public void Set_GSDrop()
            {
                  DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT * FROM TBL_XWWL_DROP_GS ORDER BY FLD_LEVEL1, FLD_LEVEL2", new object[0]), "PublicDb");
                  if (dBToDataTable != null)
                  {
                        if (dBToDataTable.Rows.Count == 0)
                        {
                              Form1.WriteLine(1, "Note: Supreme mob drops have been left empty");
                        }
                        else
                        {
                              list_10.Clear();
                              int num = 0;
                              while (true)
                              {
                                    if (num >= dBToDataTable.Rows.Count)
                                    {
                                          break;
                                    }
                                    TBL_XWWL_DROP item = new TBL_XWWL_DROP();
                                    try
                                    {
                                          item.FLD_LEVEL1 = (int)dBToDataTable.Rows[num]["FLD_LEVEL1"];
                                          item.FLD_LEVEL2 = (int)dBToDataTable.Rows[num]["FLD_LEVEL2"];
                                          item.FLD_PID = (int)dBToDataTable.Rows[num]["FLD_PID"];
                                          item.FLD_PP = (int)dBToDataTable.Rows[num]["FLD_PP"];
                                          item.FLD_NAME = dBToDataTable.Rows[num]["FLD_NAME"].ToString();
                                          item.FLD_MAGIC0 = (int)dBToDataTable.Rows[num]["FLD_MAGIC0"];
                                          item.FLD_MAGIC1 = (int)dBToDataTable.Rows[num]["FLD_MAGIC1"];
                                          item.FLD_MAGIC2 = (int)dBToDataTable.Rows[num]["FLD_MAGIC2"];
                                          item.FLD_MAGIC3 = (int)dBToDataTable.Rows[num]["FLD_MAGIC3"];
                                          item.FLD_MAGIC4 = (int)dBToDataTable.Rows[num]["FLD_MAGIC4"];
                                          item.int_4 = (int)dBToDataTable.Rows[num]["FLD_MAGIC0"];
                                          item.int_5 = (int)dBToDataTable.Rows[num]["FLD_MAGIC1"];
                                          item.int_6 = (int)dBToDataTable.Rows[num]["FLD_MAGIC2"];
                                          item.int_7 = (int)dBToDataTable.Rows[num]["FLD_MAGIC3"];
                                          item.int_8 = (int)dBToDataTable.Rows[num]["FLD_MAGIC4"];
                                          item.CO_HAY_KHONG_MO_RA_THONG_BAO = (int)dBToDataTable.Rows[num]["CO_HAY_KHONG_MO_RA_THONG_BAO"];
                                          try
                                          {
                                                if ((dBToDataTable.Rows[0]["FLD_SUNX"] != DBNull.Value) && (dBToDataTable.Rows[num]["FLD_SUNX"].ToString() != ""))
                                                {
                                                      string str = dBToDataTable.Rows[num]["FLD_SUNX"].ToString();
                                                      item.list_0 = JsonConvert.DeserializeObject<List<Class95>>(str);
                                                }
                                          }
                                          catch
                                          {
                                          }
                                          list_10.Add(item);
                                    }
                                    catch (Exception exception)
                                    {
                                          Form1.WriteLine(1, "Loading drop items error" + item.FLD_NAME + "  " + exception.Message);
                                    }
                                    num++;
                              }
                              Form1.WriteLine(2, "Loaded Supreme Mob Drops: " + dBToDataTable.Rows.Count);
                        }
                        dBToDataTable.Dispose();
                  }
            }

            public void Set_THONG_BAO()
            {
                  DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT * FROM TBL_XWWL_Gg", new object[0]), "PublicDb");
                  if (dBToDataTable != null)
                  {
                        if (dBToDataTable.Rows.Count == 0)
                        {
                              Form1.WriteLine(1, "Error loading Bulletin----There is no announcement of data");
                        }
                        else
                        {
                              dictionary_10.Clear();
                              for (int i = 0; i < dBToDataTable.Rows.Count; i++)
                              {
                                    TBL_XWWL_Gg gg = new TBL_XWWL_Gg
                                    {
                                          msg = dBToDataTable.Rows[i]["txt"].ToString(),
                                          type = (int)dBToDataTable.Rows[i]["type"]
                                    };
                                    dictionary_10.Add(i, gg);
                              }
                              Form1.WriteLine(2, "Announcement data loading Complete: " + dBToDataTable.Rows.Count);
                        }
                        dBToDataTable.Dispose();
                  }
            }

            public void SetAssumptionQigong()
            {
                  DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT * FROM KHI_CONG_THANG_THIEN ORDER BY KHI_CONG_ID", new object[0]), "PublicDb");
                  if (dBToDataTable != null)
                  {
                        if (dBToDataTable.Rows.Count == 0)
                        {
                              Form1.WriteLine(1, "Note: Acension ability table has been left empty");
                        }
                        else
                        {
                              dictionary_6.Clear();
                              for (int i = 0; i < dBToDataTable.Rows.Count; i++)
                              {
                                    KHI_CONG_THANG_THIEN khi_cong_thang_thien = new KHI_CONG_THANG_THIEN
                                    {
                                          KHI_CONG_ID = (int)dBToDataTable.Rows[i]["KHI_CONG_ID"],
                                          ITEM_ID = (int)dBToDataTable.Rows[i]["ITEM_ID"],
                                          NHAN_VAT_NGHE_NGHIEP_1 = (int)dBToDataTable.Rows[i]["NHAN_VAT_NGHE_NGHIEP_1"],
                                          NHAN_VAT_NGHE_NGHIEP_2 = (int)dBToDataTable.Rows[i]["NHAN_VAT_NGHE_NGHIEP_2"],
                                          NHAN_VAT_NGHE_NGHIEP_3 = (int)dBToDataTable.Rows[i]["NHAN_VAT_NGHE_NGHIEP_3"],
                                          NHAN_VAT_NGHE_NGHIEP_4 = (int)dBToDataTable.Rows[i]["NHAN_VAT_NGHE_NGHIEP_4"],
                                          NHAN_VAT_NGHE_NGHIEP_5 = (int)dBToDataTable.Rows[i]["NHAN_VAT_NGHE_NGHIEP_5"],
                                          NHAN_VAT_NGHE_NGHIEP_6 = (int)dBToDataTable.Rows[i]["NHAN_VAT_NGHE_NGHIEP_6"],
                                          NHAN_VAT_NGHE_NGHIEP_7 = (int)dBToDataTable.Rows[i]["NHAN_VAT_NGHE_NGHIEP_7"],
                                          NHAN_VAT_NGHE_NGHIEP_8 = (int)dBToDataTable.Rows[i]["NHAN_VAT_NGHE_NGHIEP_8"],
                                          NHAN_VAT_NGHE_NGHIEP_9 = (int)dBToDataTable.Rows[i]["NHAN_VAT_NGHE_NGHIEP_9"],
                                          NHAN_VAT_NGHE_NGHIEP_10 = (int)dBToDataTable.Rows[i]["NHAN_VAT_NGHE_NGHIEP_10"]
                                    };
                                    dictionary_6.Add(khi_cong_thang_thien.KHI_CONG_ID, khi_cong_thang_thien);
                              }
                              Form1.WriteLine(2, "Loaded Assumption Qigong: " + dBToDataTable.Rows.Count);
                        }
                        dBToDataTable.Dispose();
                  }
            }

            public void SetBossDrop()
            {
                  DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT * FROM TBL_XWWL_BossDROP ORDER BY FLD_LEVEL1, FLD_LEVEL2", new object[0]), "PublicDb");
                  if (dBToDataTable != null)
                  {
                        if (dBToDataTable.Rows.Count == 0)
                        {
                              Form1.WriteLine(1, "Note: Boss drop table has been left empty");
                        }
                        else
                        {
                              list_11.Clear();
                              int num = 0;
                              while (true)
                              {
                                    if (num >= dBToDataTable.Rows.Count)
                                    {
                                          break;
                                    }
                                    TBL_XWWL_DROP item = new TBL_XWWL_DROP();
                                    try
                                    {
                                          item.FLD_LEVEL1 = (int)dBToDataTable.Rows[num]["FLD_LEVEL1"];
                                          item.FLD_LEVEL2 = (int)dBToDataTable.Rows[num]["FLD_LEVEL2"];
                                          item.FLD_PID = (int)dBToDataTable.Rows[num]["FLD_PID"];
                                          item.FLD_PP = (int)dBToDataTable.Rows[num]["FLD_PP"];
                                          item.FLD_NAME = dBToDataTable.Rows[num]["FLD_NAME"].ToString();
                                          item.FLD_MAGIC0 = (int)dBToDataTable.Rows[num]["FLD_MAGIC0"];
                                          item.FLD_MAGIC1 = (int)dBToDataTable.Rows[num]["FLD_MAGIC1"];
                                          item.FLD_MAGIC2 = (int)dBToDataTable.Rows[num]["FLD_MAGIC2"];
                                          item.FLD_MAGIC3 = (int)dBToDataTable.Rows[num]["FLD_MAGIC3"];
                                          item.FLD_MAGIC4 = (int)dBToDataTable.Rows[num]["FLD_MAGIC4"];
                                          item.int_4 = (int)dBToDataTable.Rows[num]["FLD_MAGIC0"];
                                          item.int_5 = (int)dBToDataTable.Rows[num]["FLD_MAGIC1"];
                                          item.int_6 = (int)dBToDataTable.Rows[num]["FLD_MAGIC2"];
                                          item.int_7 = (int)dBToDataTable.Rows[num]["FLD_MAGIC3"];
                                          item.int_8 = (int)dBToDataTable.Rows[num]["FLD_MAGIC4"];
                                          item.CO_HAY_KHONG_MO_RA_THONG_BAO = (int)dBToDataTable.Rows[num]["CO_HAY_KHONG_MO_RA_THONG_BAO"];
                                          try
                                          {
                                                if ((dBToDataTable.Rows[0]["FLD_SUNX"] != DBNull.Value) && (dBToDataTable.Rows[num]["FLD_SUNX"].ToString() != ""))
                                                {
                                                      string str = dBToDataTable.Rows[num]["FLD_SUNX"].ToString();
                                                      item.list_0 = JsonConvert.DeserializeObject<List<Class95>>(str);
                                                }
                                          }
                                          catch
                                          {
                                          }
                                          list_11.Add(item);
                                    }
                                    catch (Exception exception)
                                    {
                                          Form1.WriteLine(1, "Loading BOSS drop items Error" + item.FLD_NAME + "  " + exception.Message);
                                    }
                                    num++;
                              }
                              Form1.WriteLine(2, "Loaded boss drop Items: " + dBToDataTable.Rows.Count);
                        }
                        dBToDataTable.Dispose();
                  }
            }

            public void SetConfig()
            {
                  try
                  {
                        Config.Path = Application.StartupPath + @"\GameConfiguration.ini";
                        Game_landing_port_maximum_number_of_connections = (Config.IniReadValue("GameServer", "Game_landing_port_maximum_number_of_connections") == "") ? Game_landing_port_maximum_number_of_connections : int.Parse(Config.IniReadValue("GameServer", "Game_landing_port_maximum_number_of_connections"));
                        Tro_choi_do_bo_cang_lon_nhat_lien_tiep_Thoi_gian_so = (Config.IniReadValue("GameServer", "Tro_choi_do_bo_cang_lon_nhat_lien_tiep_Thoi_gian_so") == "") ? Tro_choi_do_bo_cang_lon_nhat_lien_tiep_Thoi_gian_so : int.Parse(Config.IniReadValue("GameServer", "Tro_choi_do_bo_cang_lon_nhat_lien_tiep_Thoi_gian_so"));
                        Tu_dong_lien_tiep_Thoi_gian = (Config.IniReadValue("GameServer", "Tu_dong_lien_tiep_Thoi_gian") == "") ? Tu_dong_lien_tiep_Thoi_gian : int.Parse(Config.IniReadValue("GameServer", "Tu_dong_lien_tiep_Thoi_gian"));
                        IP_closure = Config.IniReadValue("GameServer", "IP_closure").Trim().ToLower() == "true";
                        AtPort = (Config.IniReadValue("GameServer", "AtPort").Trim() == "") ? AtPort : int.Parse(Config.IniReadValue("GameServer", "AtPort").Trim());
                        Automatically_open_connection = Config.IniReadValue("GameServer", "Automatically_open_connection").Trim().ToLower() == "true";
                        Disconnect = Config.IniReadValue("GameServer", "Disconnect").Trim().ToLower() == "true";
                        Join_filter_list = Config.IniReadValue("GameServer", "Join_filter_list").Trim().ToLower() == "true";
                        Close_connection = Config.IniReadValue("GameServer", "Close_connection").Trim().ToLower() == "true";
                        Key = Config.IniReadValue("GameServer", "Key").Trim();
                        Key2 = Config.IniReadValue("GameServer", "Key2").Trim();
                        Kinh_nghiem_boi_so = (Config.IniReadValue("GameServer", "Kinh_nghiem_boi_so").Trim() == "") ? Kinh_nghiem_boi_so : int.Parse(Config.IniReadValue("GameServer", "Kinh_nghiem_boi_so").Trim());
                        VIP_Kinh_nghiem_boi_so_ti_le_phan_tram = (Config.IniReadValue("GameServer", "VIP_Kinh_nghiem_boi_so_ti_le_phan_tram") == "") ? VIP_Kinh_nghiem_boi_so_ti_le_phan_tram : double.Parse(Config.IniReadValue("GameServer", "VIP_Kinh_nghiem_boi_so_ti_le_phan_tram"));
                        VIP_ky_nang_boi_so_ti_le_phan_tram = (Config.IniReadValue("GameServer", "VIP_ky_nang_boi_so_ti_le_phan_tram") == "") ? VIP_ky_nang_boi_so_ti_le_phan_tram : double.Parse(Config.IniReadValue("GameServer", "VIP_ky_nang_boi_so_ti_le_phan_tram"));
                        Tien_boi_so = (Config.IniReadValue("GameServer", "Tien_boi_so").Trim() == "") ? Tien_boi_so : int.Parse(Config.IniReadValue("GameServer", "Tien_boi_so").Trim());
                        Hap_hon_mo_ra = (Config.IniReadValue("GameServer", "Hap_hon_mo_ra").Trim() == "") ? Hap_hon_mo_ra : int.Parse(Config.IniReadValue("GameServer", "Hap_hon_mo_ra").Trim());
                        Hap_hon_tuy_theo_so_luong = Config.IniReadValue("GameServer", "Hap_hon_tuy_theo_so_luong").Trim();
                        Hap_hon_xac_suat = (Config.IniReadValue("GameServer", "Hap_hon_xac_suat").Trim() == "") ? Hap_hon_xac_suat : int.Parse(Config.IniReadValue("GameServer", "Hap_hon_xac_suat").Trim());
                        To_doi_Cap_bac_han_che = (Config.IniReadValue("GameServer", "To_doi_Cap_bac_han_che").Trim() == "") ? To_doi_Cap_bac_han_che : int.Parse(Config.IniReadValue("GameServer", "To_doi_Cap_bac_han_che").Trim());
                        Kiem_tra_trang_bi_Cap_bac_han_che = (Config.IniReadValue("GameServer", "Kiem_tra_trang_bi_Cap_bac_han_che").Trim() == "") ? Kiem_tra_trang_bi_Cap_bac_han_che : int.Parse(Config.IniReadValue("GameServer", "Kiem_tra_trang_bi_Cap_bac_han_che").Trim());
                        Ky_nang_boi_so = (Config.IniReadValue("GameServer", "Ky_nang_boi_so").Trim() == "") ? Ky_nang_boi_so : int.Parse(Config.IniReadValue("GameServer", "Ky_nang_boi_so").Trim());
                        Thang_thien_kinh_nghiem_boi_so = (Config.IniReadValue("GameServer", "Thang_thien_kinh_nghiem_boi_so").Trim() == "") ? Thang_thien_kinh_nghiem_boi_so : double.Parse(Config.IniReadValue("GameServer", "Thang_thien_kinh_nghiem_boi_so").Trim());
                        The_rate_of_violence = (Config.IniReadValue("GameServer", "The_rate_of_violence").Trim() == "") ? The_rate_of_violence : int.Parse(Config.IniReadValue("GameServer", "The_rate_of_violence").Trim());
                        Maximum_Online = (Config.IniReadValue("GameServer", "Maximum_Online").Trim() == "") ? Maximum_Online : int.Parse(Config.IniReadValue("GameServer", "Maximum_Online").Trim());
                        Server_Group_ID = (Config.IniReadValue("GameServer", "Server_Group_ID").Trim() == "") ? Server_Group_ID : int.Parse(Config.IniReadValue("GameServer", "Server_Group_ID").Trim());
                        Server_ID = (Config.IniReadValue("GameServer", "Server_ID").Trim() == "") ? Server_ID : int.Parse(Config.IniReadValue("GameServer", "Server_ID").Trim());
                        Game_server_port = (Config.IniReadValue("GameServer", "Game_server_port").Trim() == "") ? Game_server_port : int.Parse(Config.IniReadValue("GameServer", "Game_server_port").Trim());
                        Version_switch = (Config.IniReadValue("GameServer", "Version_switch").Trim() == "") ? Version_switch : int.Parse(Config.IniReadValue("GameServer", "Version_switch").Trim());
                        Babolat_Club_server_port = (Config.IniReadValue("GameServer", "Babolat_Club_server_port").Trim() == "") ? Babolat_Club_server_port : int.Parse(Config.IniReadValue("GameServer", "Babolat_Club_server_port").Trim());
                        Account_authentication_server_port = (Config.IniReadValue("GameServer", "Account_authentication_server_port").Trim() == "") ? Account_authentication_server_port : int.Parse(Config.IniReadValue("GameServer", "Account_authentication_server_port").Trim());
                        Account_authentication_server_IP = Config.IniReadValue("GameServer", "Account_authentication_server_IP").Trim();
                        Enter_Bulletin = Config.IniReadValue("GameServer", "Enter_Bulletin").Trim();
                        Bach_bao_cac_dia_chi = Config.IniReadValue("GameServer", "Bach_bao_cac_dia_chi").Trim();
                        Server_Name_2 = Config.IniReadValue("GameServer", "Server_Name").Trim();
                        Replace_Text_Filter = Config.IniReadValue("GameServer", "Replace_Text_Filter").Trim();
                        vip_line = (Config.IniReadValue("GameServer", "vip_line").Trim() == "") ? 0 : int.Parse(Config.IniReadValue("GameServer", "vip_line").Trim());
                        PKSwitch = int.Parse(Config.IniReadValue("GameServer", "PK_switch").Trim());
                        PK_out_equipment = int.Parse(Config.IniReadValue("GameServer", "PK_out_equipment").Trim());
                        PK_out_equipment_good_and_evil = int.Parse(Config.IniReadValue("GameServer", "PK_out_equipment_good_and_evil").Trim());
                        PK_out_equipment_chance = int.Parse(Config.IniReadValue("GameServer", "PK_out_equipment_chance").Trim());
                        Giang_ho_bao_tuong_cuong_hoa_giai_doan = int.Parse(Config.IniReadValue("GameServer", "Giang_ho_bao_tuong_cuong_hoa_giai_doan").Trim());
                        Phat_ngon_dang_cap = (Config.IniReadValue("GameServer", "Phat_ngon_dang_cap").Trim() == "") ? 0 : int.Parse(Config.IniReadValue("GameServer", "Phat_ngon_dang_cap").Trim());
                        Thu_cong_phu_hon_giai_doan_cao_nhat = int.Parse(Config.IniReadValue("GameServer", "Thu_cong_phu_hon_giai_doan_cao_nhat").Trim());
                        ForceOfWar_Switch = int.Parse(Config.IniReadValue("GameServer", "The_luc_chien_co_hay_khong_mo_ra").Trim());
                        OpenWarTime_Hour = int.Parse(Config.IniReadValue("GameServer", "The_luc_chien_mo_ra_gio").Trim());
                        OpenWarTime_Min = int.Parse(Config.IniReadValue("GameServer", "The_luc_chien_mo_ra_phut").Trim());
                        OpenWarTime_Sec = int.Parse(Config.IniReadValue("GameServer", "The_luc_chien_mo_ra_giay").Trim());
                        SMS_payments_whether_to_open = Config.IniReadValue("GameServer", "SMS_payments_whether_to_open").Trim();
                        SMS_server_WEBID = Config.IniReadValue("GameServer", "SMS_server_WEBID").Trim();
                        SMS_service_number = Config.IniReadValue("GameServer", "SMS_service_number").Trim();
                        SMS_channel_number = Config.IniReadValue("GameServer", "SMS_channel_number").Trim();
                        AutGC = (Config.IniReadValue("GameServer", "AutGC").Trim() == "") ? AutGC : int.Parse(Config.IniReadValue("GameServer", "AutGC").Trim());
                        Packet_title = (Config.IniReadValue("GameServer", "Packet_title").Trim() == "") ? 0 : int.Parse(Config.IniReadValue("GameServer", "Packet_title").Trim());
                        Script = (Config.IniReadValue("GameServer", "Script").Trim() == "") ? Script : int.Parse(Config.IniReadValue("GameServer", "Script").Trim());
                        The_maximum_number_of_Idiom = (Config.IniReadValue("GameServer", "The_maximum_number_of_Idiom") == "") ? 50 : int.Parse(Config.IniReadValue("GameServer", "The_maximum_number_of_Idiom"));
                        Da_Vo_cong_phong_ngu_hop_thanh_xac_xuat_khong_che = Config.IniReadValue("GameServer", "Da_Vo_cong_phong_ngu_hop_thanh_xac_xuat_khong_che").Trim();
                        Da_Suc_phong_ngu_hop_thanh_xac_xuat_khong_che = Config.IniReadValue("GameServer", "Da_Suc_phong_ngu_hop_thanh_xac_xuat_khong_che").Trim();
                        Da_Luc_cong_kich_Vo_cong_hop_thanh_xac_xuat_khong_che = Config.IniReadValue("GameServer", "Da_Luc_cong_kich_Vo_cong_hop_thanh_xac_xuat_khong_che").Trim();
                        Cuong_hoa_xac_xuat_khong_che = Config.IniReadValue("GameServer", "Cuong_hoa_xac_xuat_khong_che").Trim();
                        Hop_thanh_xac_xuat_khong_che = Config.IniReadValue("GameServer", "Hop_thanh_xac_xuat_khong_che").Trim();
                        Hop_thanh_xac_xuat = (Config.IniReadValue("GameServer", "Hop_thanh_xac_xuat") == "") ? Hop_thanh_xac_xuat : double.Parse(Config.IniReadValue("GameServer", "Hop_thanh_xac_xuat"));
                        CASH_hop_thanh = (Config.IniReadValue("GameServer", "CASH_hop_thanh").Trim() == "") ? CASH_hop_thanh : int.Parse(Config.IniReadValue("GameServer", "CASH_hop_thanh").Trim());
                        Number_lock_ingot = (Config.IniReadValue("GameServer", "Number_lock_ingot").Trim() == "") ? Number_lock_ingot : int.Parse(Config.IniReadValue("GameServer", "Number_lock_ingot").Trim());
                        Unlock_ingot_number = (Config.IniReadValue("GameServer", "Unlock_ingot_number").Trim() == "") ? Unlock_ingot_number : int.Parse(Config.IniReadValue("GameServer", "Unlock_ingot_number").Trim());
                        Co_hay_khong_ma_hoa = (Config.IniReadValue("GameServer", "Co_hay_khong_ma_hoa").Trim() == "") ? Co_hay_khong_ma_hoa : int.Parse(Config.IniReadValue("GameServer", "Co_hay_khong_ma_hoa").Trim());
                        Phien_ban_nghiem_chung_Thoi_gian = (Config.IniReadValue("GameServer", "Phien_ban_nghiem_chung_Thoi_gian").Trim() == "") ? Phien_ban_nghiem_chung_Thoi_gian : int.Parse(Config.IniReadValue("GameServer", "Phien_ban_nghiem_chung_Thoi_gian").Trim());
                        Mo_hop_ra_CASH = Config.IniReadValue("GameServer", "Mo_hop_ra_CASH").Trim();
                        Vip_Login_thong_cao = (Config.IniReadValue("GameServer", "Vip_Login_thong_cao").Trim() == "") ? Vip_Login_thong_cao : int.Parse(Config.IniReadValue("GameServer", "Vip_Login_thong_cao").Trim());
                        Dang_ky_mon_phai_can_Dang_cap = (Config.IniReadValue("GameServer", "Dang_ky_mon_phai_can_Dang_cap").Trim() == "") ? Dang_ky_mon_phai_can_Dang_cap : int.Parse(Config.IniReadValue("GameServer", "Dang_ky_mon_phai_can_Dang_cap").Trim());
                        Dang_ky_mon_phai_can_tien_bac = (Config.IniReadValue("GameServer", "Dang_ky_mon_phai_can_tien_bac").Trim() == "") ? Dang_ky_mon_phai_can_tien_bac : int.Parse(Config.IniReadValue("GameServer", "Dang_ky_mon_phai_can_tien_bac").Trim());
                        Dang_ky_mon_phai_can_thiet_Item_ID = Config.IniReadValue("GameServer", "Dang_ky_mon_phai_can_thiet_Item_ID").Trim();
                        Khu_an_toan_mo_ra = (Config.IniReadValue("GameServer", "Khu_an_toan_mo_ra").Trim() == "") ? Khu_an_toan_mo_ra : int.Parse(Config.IniReadValue("GameServer", "Khu_an_toan_mo_ra").Trim());
                        Vip_Login_thong_cao_noi_dung = (Config.IniReadValue("GameServer", "Vip_Login_thong_cao_noi_dung").Trim() == "") ? Vip_Login_thong_cao_noi_dung : Config.IniReadValue("GameServer", "Vip_Login_thong_cao_noi_dung").Trim();
                        VIP_ban_do = Config.IniReadValue("GameServer", "VIP_ban_do").Trim();
                        BackPack_Switch = (Config.IniReadValue("GameServer", "Ba_lo_mo_rong_mo_ra").Trim() == "") ? BackPack_Switch : int.Parse(Config.IniReadValue("GameServer", "Ba_lo_mo_rong_mo_ra").Trim());
                        Vuot_cua_ai_ban_do = Config.IniReadValue("GameServer", "Vuot_cua_ai_ban_do").Trim();
                        VIP_Hop_thanh_xac_xuat = (Config.IniReadValue("GameServer", "VIP_Hop_thanh_xac_xuat") == "") ? VIP_Hop_thanh_xac_xuat : double.Parse(Config.IniReadValue("GameServer", "VIP_Hop_thanh_xac_xuat"));
                        Phu_hon_hop_thanh_xac_xuat_tang_cuong = (Config.IniReadValue("GameServer", "Phu_hon_hop_thanh_xac_xuat_tang_cuong") == "") ? Phu_hon_hop_thanh_xac_xuat_tang_cuong : double.Parse(Config.IniReadValue("GameServer", "Phu_hon_hop_thanh_xac_xuat_tang_cuong"));
                        Co_hay_khong_mo_ra_chuyen_sinh_so_lan_khen_thuong = int.Parse(Config.IniReadValue("GameServer", "Co_hay_khong_mo_ra_chuyen_sinh_so_lan_khen_thuong").Trim());
                        Han_che_chuyen_sinh_so_lan = int.Parse(Config.IniReadValue("GameServer", "Han_che_chuyen_sinh_so_lan").Trim());
                        Chuyen_sinh_can_may_vong = int.Parse(Config.IniReadValue("GameServer", "Chuyen_sinh_can_may_vong").Trim());
                        Chuyen_sinh_ha_xuong_may_vong = int.Parse(Config.IniReadValue("GameServer", "Chuyen_sinh_ha_xuong_may_vong").Trim());
                        Chuyen_sinh_can_level = int.Parse(Config.IniReadValue("GameServer", "Chuyen_sinh_can_level").Trim());
                        Chuyen_sinh_giam_xuong_level = int.Parse(Config.IniReadValue("GameServer", "Chuyen_sinh_giam_xuong_level").Trim());
                        Chuyen_sinh_khen_thuong_loai_hinh = int.Parse(Config.IniReadValue("GameServer", "Chuyen_sinh_khen_thuong_loai_hinh").Trim());
                        Chuyen_sinh_khen_thuong_so_luong = int.Parse(Config.IniReadValue("GameServer", "Chuyen_sinh_khen_thuong_so_luong").Trim());
                        Chuyen_sinh_khen_thuong_Thuoc_tinh = Config.IniReadValue("GameServer", "Chuyen_sinh_khen_thuong_Thuoc_tinh").Trim();
                        Chuyen_sinh_khen_thuong_Item = Config.IniReadValue("GameServer", "Chuyen_sinh_khen_thuong_Item").Trim();
                        Chuyen_sinh_khen_thuong_trang_phuc = int.Parse(Config.IniReadValue("GameServer", "Chuyen_sinh_khen_thuong_trang_phuc").Trim());
                        Chuyen_sinh_thong_cao = int.Parse(Config.IniReadValue("GameServer", "Chuyen_sinh_thong_cao").Trim());
                        Chuyen_sinh_thong_cao_noi_dung = Config.IniReadValue("GameServer", "Chuyen_sinh_thong_cao_noi_dung").Trim();
                        Tu_vong_kinh_nghiem_roi_xuong_co_hay_khong_mo_ra = int.Parse(Config.IniReadValue("GameServer", "Tu_vong_kinh_nghiem_roi_xuong_co_hay_khong_mo_ra").Trim());
                        Co_hay_khong_mo_ra_Vo_huan_he_thong = int.Parse(Config.IniReadValue("GameServer", "Co_hay_khong_mo_ra_Vo_huan_he_thong").Trim());
                        Vo_huan_gioi_han_nhan_duoc = (Config.IniReadValue("GameServer", "Vo_huan_gioi_han_nhan_duoc") == "") ? Vo_huan_gioi_han_nhan_duoc : int.Parse(Config.IniReadValue("GameServer", "Vo_huan_gioi_han_nhan_duoc"));
                        Co_hay_khong_bat_dau_dung_di_thuong_xuat_huyet = int.Parse(Config.IniReadValue("GameServer", "Co_hay_khong_bat_dau_dung_di_thuong_xuat_huyet").Trim());
                        PK_Dang_cap_chenh_lech = int.Parse(Config.IniReadValue("GameServer", "PK_Dang_cap_chenh_lech").Trim());
                        PK_khoang_cach_khong_che_co_hay_khong_mo_ra = int.Parse(Config.IniReadValue("GameServer", "PK_khoang_cach_khong_che_co_hay_khong_mo_ra").Trim());
                        Nhan_vat_trinh_dien_nghe_nghiep_Cong_kich_khoang_cach = int.Parse(Config.IniReadValue("GameServer", "Nhan_vat_trinh_dien_nghe_nghiep_Cong_kich_khoang_cach").Trim());
                        Nhan_vat_gan_nguoi_nghe_nghiep_cong_kich_khoang_cach = int.Parse(Config.IniReadValue("GameServer", "Nhan_vat_gan_nguoi_nghe_nghiep_cong_kich_khoang_cach").Trim());
                        Danh_quai_khoang_cach_khong_che_co_hay_khong_mo_ra = int.Parse(Config.IniReadValue("GameServer", "Danh_quai_khoang_cach_khong_che_co_hay_khong_mo_ra").Trim());
                        Quai_vat_trinh_dien_nghe_nghiep_Cong_kich_khoang_cach = int.Parse(Config.IniReadValue("GameServer", "Quai_vat_trinh_dien_nghe_nghiep_Cong_kich_khoang_cach").Trim());
                        Quai_vat_gan_nguoi_nghe_nghiep_Cong_kich_khoang_cach = int.Parse(Config.IniReadValue("GameServer", "Quai_vat_gan_nguoi_nghe_nghiep_Cong_kich_khoang_cach").Trim());
                        Truy_sat_he_thong_co_hay_khong_mo_ra = (Config.IniReadValue("GameServer", "Truy_sat_he_thong_co_hay_khong_mo_ra").Trim() == "") ? Truy_sat_he_thong_co_hay_khong_mo_ra : int.Parse(Config.IniReadValue("GameServer", "Truy_sat_he_thong_co_hay_khong_mo_ra").Trim());
                        Player_lan_theo_menh_lenh = Config.IniReadValue("GameServer", "Player_lan_theo_menh_lenh").Trim();
                        Lan_theo_player_can_CASH_so_luong = (Config.IniReadValue("GameServer", "Lan_theo_player_can_CASH_so_luong").Trim() == "") ? 0L : long.Parse(Config.IniReadValue("GameServer", "Lan_theo_player_can_CASH_so_luong").Trim());
                        Phong_ngu_truy_sat_can_thiet_Item_ID = Config.IniReadValue("GameServer", "Phong_ngu_truy_sat_can_thiet_Item_ID").Trim();
                        Nhan_khac_chu_can_vang = (Config.IniReadValue("GameServer", "Nhan_khac_chu_can_vang").Trim() == "") ? Nhan_khac_chu_can_vang : int.Parse(Config.IniReadValue("GameServer", "Nhan_khac_chu_can_vang").Trim());
                        Vo_huan_bao_ve_Dang_cap = int.Parse(Config.IniReadValue("GameServer", "Vo_huan_bao_ve_Dang_cap").Trim());
                        Tu_vong_giam_thieu_Vo_huan_So_luong = Config.IniReadValue("GameServer", "Tu_vong_giam_thieu_Vo_huan_So_luong").Trim();
                        He_thong_thu_ve_So_luong = Config.IniReadValue("GameServer", "He_thong_thu_ve_So_luong").Trim();
                        char[] separator = new char[] { ';' };
                        Vo_huan_giai_doan_1 = Config.IniReadValue("GameServer", "Vo_huan_giai_doan_1").Trim().Split(separator);
                        char[] chArray2 = new char[] { ';' };
                        Vo_huan_giai_doan_2 = Config.IniReadValue("GameServer", "Vo_huan_giai_doan_2").Trim().Split(chArray2);
                        char[] chArray3 = new char[] { ';' };
                        Vo_huan_giai_doan_3 = Config.IniReadValue("GameServer", "Vo_huan_giai_doan_3").Trim().Split(chArray3);
                        char[] chArray4 = new char[] { ';' };
                        Vo_huan_giai_doan_4 = Config.IniReadValue("GameServer", "Vo_huan_giai_doan_4").Trim().Split(chArray4);
                        char[] chArray5 = new char[] { ';' };
                        Vo_huan_giai_doan_5 = Config.IniReadValue("GameServer", "Vo_huan_giai_doan_5").Trim().Split(chArray5);
                        char[] chArray6 = new char[] { ';' };
                        Vo_huan_giai_doan_6 = Config.IniReadValue("GameServer", "Vo_huan_giai_doan_6").Trim().Split(chArray6);
                        char[] chArray7 = new char[] { ';' };
                        Vo_huan_giai_doan_7 = Config.IniReadValue("GameServer", "Vo_huan_giai_doan_7").Trim().Split(chArray7);
                        char[] chArray8 = new char[] { ';' };
                        Vo_huan_giai_doan_8 = Config.IniReadValue("GameServer", "Vo_huan_giai_doan_8").Trim().Split(chArray8);
                        char[] chArray9 = new char[] { ';' };
                        Tang_cuong_phong_ngu_duoc_pham = Config.IniReadValue("GameServer", "Tang_cuong_phong_ngu_duoc_pham").Trim().Split(chArray9);
                        char[] chArray10 = new char[] { ';' };
                        Tang_cuong_cong_kich_duoc_pham = Config.IniReadValue("GameServer", "Tang_cuong_cong_kich_duoc_pham").Trim().Split(chArray10);
                        char[] chArray11 = new char[] { ';' };
                        Tang_cuong_sinh_menh_duoc_pham = Config.IniReadValue("GameServer", "Tang_cuong_sinh_menh_duoc_pham").Trim().Split(chArray11);
                        Thuoc_tinh_mo_rong_co_hay_khong_mo_ra = int.Parse(Config.IniReadValue("GameServer", "Thuoc_tinh_mo_rong_co_hay_khong_mo_ra").Trim());
                        Chuyen_sinh_so_lan_linh_thuong_khong_che = int.Parse(Config.IniReadValue("GameServer", "Chuyen_sinh_so_lan_linh_thuong_khong_che").Trim());
                        Co_hay_khong_mo_ra_Dang_cap_khen_thuong = int.Parse(Config.IniReadValue("GameServer", "Co_hay_khong_mo_ra_Dang_cap_khen_thuong").Trim());
                        Kiem_tra_phi_phap_Item = (Config.IniReadValue("GameServer", "Kiem_tra_phi_phap_Item").Trim() == "") ? Kiem_tra_phi_phap_Item : int.Parse(Config.IniReadValue("GameServer", "Kiem_tra_phi_phap_Item").Trim());
                        Kiem_tra_Troi_chat_phi_phap_Item = (Config.IniReadValue("GameServer", "Kiem_tra_Troi_chat_phi_phap_Item").Trim() == "") ? Kiem_tra_Troi_chat_phi_phap_Item : (Config.IniReadValue("GameServer", "Kiem_tra_Troi_chat_phi_phap_Item").Trim() == "1");
                        Kiem_tra_phi_phap_Item_thao_tac = (Config.IniReadValue("GameServer", "Kiem_tra_phi_phap_Item_thao_tac").Trim() == "") ? Kiem_tra_phi_phap_Item_thao_tac : int.Parse(Config.IniReadValue("GameServer", "Kiem_tra_phi_phap_Item_thao_tac").Trim());
                        Item_cao_nhat_Cong_kich_gia_tri = (Config.IniReadValue("GameServer", "Item_cao_nhat_Cong_kich_gia_tri").Trim() == "") ? Item_cao_nhat_Cong_kich_gia_tri : int.Parse(Config.IniReadValue("GameServer", "Item_cao_nhat_Cong_kich_gia_tri").Trim());
                        Item_cao_nhat_Phong_ngu_gia_tri = (Config.IniReadValue("GameServer", "Item_cao_nhat_Phong_ngu_gia_tri").Trim() == "") ? Item_cao_nhat_Phong_ngu_gia_tri : int.Parse(Config.IniReadValue("GameServer", "Item_cao_nhat_Phong_ngu_gia_tri").Trim());
                        Item_cao_nhat_Sinh_menh_gia_tri = (Config.IniReadValue("GameServer", "Item_cao_nhat_Sinh_menh_gia_tri").Trim() == "") ? Item_cao_nhat_Sinh_menh_gia_tri : int.Parse(Config.IniReadValue("GameServer", "Item_cao_nhat_Sinh_menh_gia_tri").Trim());
                        Item_cao_nhat_Noi_cong_gia_tri = (Config.IniReadValue("GameServer", "Item_cao_nhat_Noi_cong_gia_tri").Trim() == "") ? Item_cao_nhat_Noi_cong_gia_tri : int.Parse(Config.IniReadValue("GameServer", "Item_cao_nhat_Noi_cong_gia_tri").Trim());
                        Item_cao_nhat_Trung_muc_tieu_gia_tri = (Config.IniReadValue("GameServer", "Item_cao_nhat_Trung_muc_tieu_gia_tri").Trim() == "") ? Item_cao_nhat_Trung_muc_tieu_gia_tri : int.Parse(Config.IniReadValue("GameServer", "Item_cao_nhat_Trung_muc_tieu_gia_tri").Trim());
                        Item_cao_nhat_Ne_tranh_gia_tri = (Config.IniReadValue("GameServer", "Item_cao_nhat_Ne_tranh_gia_tri").Trim() == "") ? Item_cao_nhat_Ne_tranh_gia_tri : int.Parse(Config.IniReadValue("GameServer", "Item_cao_nhat_Ne_tranh_gia_tri").Trim());
                        Item_cao_nhat_vo_cong_gia_tri = (Config.IniReadValue("GameServer", "Item_cao_nhat_vo_cong_gia_tri").Trim() == "") ? Item_cao_nhat_vo_cong_gia_tri : int.Parse(Config.IniReadValue("GameServer", "Item_cao_nhat_vo_cong_gia_tri").Trim());
                        Item_cao_nhat_khi_cong_gia_tri = (Config.IniReadValue("GameServer", "Item_cao_nhat_khi_cong_gia_tri").Trim() == "") ? Item_cao_nhat_khi_cong_gia_tri : int.Parse(Config.IniReadValue("GameServer", "Item_cao_nhat_khi_cong_gia_tri").Trim());
                        Item_cao_nhat_hop_thanh_gia_tri = (Config.IniReadValue("GameServer", "Item_cao_nhat_hop_thanh_gia_tri").Trim() == "") ? Item_cao_nhat_hop_thanh_gia_tri : int.Parse(Config.IniReadValue("GameServer", "Item_cao_nhat_hop_thanh_gia_tri").Trim());
                        The_luc_chien_khen_thuong_Loai_hinh = int.Parse(Config.IniReadValue("GameServer", "The_luc_chien_khen_thuong_Loai_hinh").Trim());
                        The_luc_chien_khen_thuong_Thuoc_tinh = Config.IniReadValue("GameServer", "The_luc_chien_khen_thuong_Thuoc_tinh").Trim();
                        The_luc_chien_khen_thuong_Item = Config.IniReadValue("GameServer", "The_luc_chien_khen_thuong_Item").Trim();
                        The_luc_chien_khen_thuong_trang_phuc = int.Parse(Config.IniReadValue("GameServer", "The_luc_chien_khen_thuong_trang_phuc").Trim());
                        Login_tang_le_bao_co_hay_khong_mo_ra = int.Parse(Config.IniReadValue("GameServer", "Login_tang_le_bao_co_hay_khong_mo_ra").Trim());
                        Login_tang_le_bao_trang_phuc = int.Parse(Config.IniReadValue("GameServer", "Login_tang_le_bao_trang_phuc").Trim());
                        Nguoi_moi_login_khen_thuong_co_hay_khong_mo_ra = int.Parse(Config.IniReadValue("GameServer", "Nguoi_moi_login_khen_thuong_co_hay_khong_mo_ra").Trim());
                        Nguoi_moi_login_khen_thuong = Config.IniReadValue("GameServer", "Nguoi_moi_login_khen_thuong").Trim();
                        Co_hay_khong_bat_dau_dung_thanh_vien_thang_cap = int.Parse(Config.IniReadValue("GameServer", "Co_hay_khong_bat_dau_dung_thanh_vien_thang_cap").Trim());
                        Phan_khu_danh_so = Config.IniReadValue("GameServer", "Phan_khu_danh_so").Trim();
                        Vu_khi_phu_hon_tang_cuong_thuoc_tinh_so_luong = int.Parse(Config.IniReadValue("GameServer", "Vu_khi_phu_hon_tang_cuong_thuoc_tinh_so_luong").Trim());
                        Quan_ao_phu_hon_tang_cuong_Thuoc_tinh_So_luong = int.Parse(Config.IniReadValue("GameServer", "Quan_ao_phu_hon_tang_cuong_Thuoc_tinh_So_luong").Trim());
                        Vong_tai_gia_cong_1_giai_doan_tang_cuong_sinh_menh = int.Parse(Config.IniReadValue("GameServer", "Vong_tai_gia_cong_1_giai_doan_tang_cuong_sinh_menh").Trim());
                        Day_chuyen_gia_cong_1_giai_doan_tang_cuong_phong_ngu = int.Parse(Config.IniReadValue("GameServer", "Day_chuyen_gia_cong_1_giai_doan_tang_cuong_phong_ngu").Trim());
                        Nhan_gia_cong_1_giai_doan_tang_cuong_cong_kich = int.Parse(Config.IniReadValue("GameServer", "Nhan_gia_cong_1_giai_doan_tang_cuong_cong_kich").Trim());
                        SqlJl = (Config.IniReadValue("GameServer", "SqlJl").Trim() == "") ? SqlJl : Config.IniReadValue("GameServer", "SqlJl").Trim();
                        Tu_dong_luu_tru = (Config.IniReadValue("GameServer", "Tu_dong_luu_tru").Trim() == "") ? Tu_dong_luu_tru : int.Parse(Config.IniReadValue("GameServer", "Tu_dong_luu_tru").Trim());
                        ITEM_GHI_CHEP = (Config.IniReadValue("GameServer", "ITEM_GHI_CHEP").Trim() == "") ? ITEM_GHI_CHEP : int.Parse(Config.IniReadValue("GameServer", "ITEM_GHI_CHEP").Trim());
                        Costume1 = (Config.IniReadValue("GameServer", "Costume1").Trim() == "") ? Costume1 : int.Parse(Config.IniReadValue("GameServer", "Costume1").Trim());
                        Costume2 = (Config.IniReadValue("GameServer", "Costume2").Trim() == "") ? Costume2 : int.Parse(Config.IniReadValue("GameServer", "Costume2").Trim());
                        DANG_NHAP_GHI_CHEP = (Config.IniReadValue("GameServer", "DANG_NHAP_GHI_CHEP").Trim() == "") ? DANG_NHAP_GHI_CHEP : int.Parse(Config.IniReadValue("GameServer", "DANG_NHAP_GHI_CHEP").Trim());
                        Ghi_chep_bao_ton_Thang_thien = (Config.IniReadValue("GameServer", "Ghi_chep_bao_ton_Thang_thien").Trim() == "") ? Ghi_chep_bao_ton_Thang_thien : int.Parse(Config.IniReadValue("GameServer", "Ghi_chep_bao_ton_Thang_thien").Trim());
                        CASH_do_luong = (Config.IniReadValue("GameServer", "CASH_do_luong").Trim() == "") ? CASH_do_luong : int.Parse(Config.IniReadValue("GameServer", "CASH_do_luong").Trim());
                        Tinh_nhan_mo_ra = (Config.IniReadValue("GameServer", "Tinh_nhan_mo_ra").Trim() == "") ? 0 : int.Parse(Config.IniReadValue("GameServer", "Tinh_nhan_mo_ra").Trim());
                        Phan_mem_hack_PK_switch = (Config.IniReadValue("GameServer", "Phan_mem_hack_PK_switch").Trim() == "") ? 0 : int.Parse(Config.IniReadValue("GameServer", "Phan_mem_hack_PK_switch").Trim());
                        Thang_thien_skill_Dang_cap_bo_tro = (Config.IniReadValue("GameServer", "Thang_thien_skill_Dang_cap_bo_tro").Trim() == "") ? 1 : int.Parse(Config.IniReadValue("GameServer", "Thang_thien_skill_Dang_cap_bo_tro").Trim());
                        Job_Level = (Config.IniReadValue("GameServer", "Tham_gia_the_luc_tram_chuyen_chuc_So_lan").Trim() == "") ? Job_Level : int.Parse(Config.IniReadValue("GameServer", "Tham_gia_the_luc_tram_chuyen_chuc_So_lan").Trim());
                        Phu_the_skill_tu_luyen_Dang_cap = (Config.IniReadValue("GameServer", "Phu_the_skill_tu_luyen_Dang_cap").Trim() == "") ? Phu_the_skill_tu_luyen_Dang_cap : int.Parse(Config.IniReadValue("GameServer", "Phu_the_skill_tu_luyen_Dang_cap").Trim());
                        Do_bo_thiet_bi_hinh_thuc = int.Parse(Config.IniReadValue("GameServer", "Do_bo_thiet_bi_hinh_thuc").Trim());
                        Cong_kich_Xac_nhan_hinh_thuc = (Config.IniReadValue("GameServer", "Cong_kich_Xac_nhan_hinh_thuc").Trim() == "") ? Cong_kich_Xac_nhan_hinh_thuc : int.Parse(Config.IniReadValue("GameServer", "Cong_kich_Xac_nhan_hinh_thuc").Trim());
                        Co_hay_khong_mo_ra_CASH_cua_hang = int.Parse(Config.IniReadValue("GameServer", "Co_hay_khong_mo_ra_CASH_cua_hang").Trim());
                        Kiem_tra_trang_bi_mo_ra = int.Parse(Config.IniReadValue("GameServer", "Kiem_tra_trang_bi_mo_ra").Trim());
                        Vo_cong_phong_ngu_hinh_thuc = (Config.IniReadValue("GameServer", "Vo_cong_phong_ngu_hinh_thuc").Trim() == "") ? Vo_cong_phong_ngu_hinh_thuc : int.Parse(Config.IniReadValue("GameServer", "Vo_cong_phong_ngu_hinh_thuc").Trim());
                        Vo_cong_Cong_kich_suc_manh_khong_che = int.Parse(Config.IniReadValue("GameServer", "Vo_cong_Cong_kich_suc_manh_khong_che").Trim());
                        Vo_cong_Phong_ngu_suc_manh_khong_che = int.Parse(Config.IniReadValue("GameServer", "Vo_cong_Phong_ngu_suc_manh_khong_che").Trim());
                        Toc_do_do_luong_mo_ra = (Config.IniReadValue("GameServer", "Toc_do_do_luong_mo_ra").Trim() == "") ? 0 : int.Parse(Config.IniReadValue("GameServer", "Toc_do_do_luong_mo_ra").Trim());
                        Toc_do_do_luong_thao_tac = (Config.IniReadValue("GameServer", "Toc_do_do_luong_thao_tac").Trim() == "") ? 0 : int.Parse(Config.IniReadValue("GameServer", "Toc_do_do_luong_thao_tac").Trim());
                        Gia_toc_khi_do_luong_Thoi_gian_tieu_diet = (Config.IniReadValue("GameServer", "Gia_toc_khi_do_luong_Thoi_gian_tieu_diet").Trim() == "") ? 0 : int.Parse(Config.IniReadValue("GameServer", "Gia_toc_khi_do_luong_Thoi_gian_tieu_diet").Trim());
                        Di_dong_menh_lenh = Config.IniReadValue("GameServer", "Di_dong_menh_lenh").Trim();
                        Kiem_tra_tin_tuc_menh_lenh = Config.IniReadValue("GameServer", "Kiem_tra_tin_tuc_menh_lenh").Trim();
                        Thang_cap_thanh_vien_menh_lenh = Config.IniReadValue("GameServer", "Thang_cap_thanh_vien_menh_lenh").Trim();
                        Cau_hon_menh_lenh = Config.IniReadValue("GameServer", "Cau_hon_menh_lenh").Trim();
                        Chuyen_sinh_menh_lenh = Config.IniReadValue("GameServer", "Chuyen_sinh_menh_lenh").Trim();
                        Thanh_ly_ba_lo_menh_lenh = Config.IniReadValue("GameServer", "Thanh_ly_ba_lo_menh_lenh").Trim();
                        Thanh_ly_troi_chat_ba_lo_menh_lenh = Config.IniReadValue("GameServer", "Thanh_ly_troi_chat_ba_lo_menh_lenh").Trim();
                        Phu_hon_menh_lenh = Config.IniReadValue("GameServer", "Phu_hon_menh_lenh").Trim();
                        Ly_hon_menh_lenh = Config.IniReadValue("GameServer", "Ly_hon_menh_lenh").Trim();
                        Kiem_tra_thoi_gian_menh_lenh = Config.IniReadValue("GameServer", "Kiem_tra_thoi_gian_menh_lenh").Trim();
                        Self_help_command_card = Config.IniReadValue("GameServer", "Self_help_command_card").Trim();
                        Issued_notice = Config.IniReadValue("GameServer", "Issued_notice").Trim();
                        Mobile_Carrier = Config.IniReadValue("GameServer", "Mobile_Carrier").Trim();
                        Copy_Item = Config.IniReadValue("GameServer", "Copy_Item").Trim();
                        Additional_state = Config.IniReadValue("GameServer", "Additional_state").Trim();
                        Bat_dau_the_luc_chien = Config.IniReadValue("GameServer", "Bat_dau_the_luc_chien").Trim();
                        Shuaqian = Config.IniReadValue("GameServer", "Shuaqian").Trim();
                        Brush_Wu_Xun = Config.IniReadValue("GameServer", "Brush_Wu_Xun").Trim();
                        Brush_experience = Config.IniReadValue("GameServer", "Brush_experience").Trim();
                        Backpack_delete_items = Config.IniReadValue("GameServer", "Backpack_delete_items").Trim();
                        Stealth = Config.IniReadValue("GameServer", "Stealth").Trim();
                        Brush_strange = Config.IniReadValue("GameServer", "Brush_strange").Trim();
                        Kicking = Config.IniReadValue("GameServer", "Kicking").Trim();
                        Title = Config.IniReadValue("GameServer", "Title").Trim();
                        Track = Config.IniReadValue("GameServer", "Track").Trim();
                        Mot_minh_dau_mo_ra_menh_lenh = Config.IniReadValue("GameServer", "Mot_minh_dau_mo_ra_menh_lenh").Trim();
                        Khieu_chien_tham_gia_menh_lenh = Config.IniReadValue("GameServer", "Khieu_chien_tham_gia_menh_lenh").Trim();
                        Gui_di_khieu_chien_thu_tuc_menh_lenh = Config.IniReadValue("GameServer", "Gui_di_khieu_chien_thu_tuc_menh_lenh").Trim();
                        Khieu_chien_he_thong_thu_ve_CASH_So_luong = int.Parse(Config.IniReadValue("GameServer", "Khieu_chien_he_thong_thu_ve_CASH_So_luong").Trim());
                        Khieu_chien_xin_can_thiet_CASH_So_luong = int.Parse(Config.IniReadValue("GameServer", "Khieu_chien_xin_can_thiet_CASH_So_luong").Trim());
                        Gui_di_khieu_chien_thu_tuc_menh_lenh_can_CASH = int.Parse(Config.IniReadValue("GameServer", "Gui_di_khieu_chien_thu_tuc_menh_lenh_can_CASH").Trim());
                        Khieu_chien_ban_do_toa_do_X = int.Parse(Config.IniReadValue("GameServer", "Khieu_chien_ban_do_toa_do_X").Trim());
                        Khieu_chien_ban_do_toa_do_Y = int.Parse(Config.IniReadValue("GameServer", "Khieu_chien_ban_do_toa_do_Y").Trim());
                        Ca_nhan_khieu_chien_co_hay_khong_mo_ra = (Config.IniReadValue("GameServer", "Ca_nhan_khieu_chien_co_hay_khong_mo_ra").Trim() == "") ? Ca_nhan_khieu_chien_co_hay_khong_mo_ra : int.Parse(Config.IniReadValue("GameServer", "Ca_nhan_khieu_chien_co_hay_khong_mo_ra").Trim());
                        Khieu_chien_ban_do_so_hieu = (Config.IniReadValue("GameServer", "Khieu_chien_ban_do_so_hieu").Trim() == "") ? Khieu_chien_ban_do_so_hieu : int.Parse(Config.IniReadValue("GameServer", "Khieu_chien_ban_do_so_hieu").Trim());
                        Khieu_chien_la_to_noi_dung_1 = Config.IniReadValue("GameServer", "Khieu_chien_la_to_noi_dung_1").Trim();
                        Khieu_chien_la_to_noi_dung_2 = Config.IniReadValue("GameServer", "Khieu_chien_la_to_noi_dung_2").Trim();
                        Khieu_chien_la_to_noi_dung_3 = Config.IniReadValue("GameServer", "Khieu_chien_la_to_noi_dung_3").Trim();
                        Chap_nhan_khieu_chien_la_to_noi_dung_1 = Config.IniReadValue("GameServer", "Chap_nhan_khieu_chien_la_to_noi_dung_1").Trim();
                        Chap_nhan_khieu_chien_la_to_noi_dung_2 = Config.IniReadValue("GameServer", "Chap_nhan_khieu_chien_la_to_noi_dung_2").Trim();
                        Chap_nhan_khieu_chien_la_to_noi_dung_3 = Config.IniReadValue("GameServer", "Chap_nhan_khieu_chien_la_to_noi_dung_3").Trim();
                        Equipment_plus_unlock_switch = int.Parse(Config.IniReadValue("GameServer", "Equipment_plus_unlock_switch").Trim());
                        Boi_toan_tieu_hao_CASH = int.Parse(Config.IniReadValue("GameServer", "Boi_toan_tieu_hao_CASH").Trim());
                        Long_line_mode_is_turned_on = int.Parse(Config.IniReadValue("GameServer", "Long_line_mode_is_turned_on").Trim());
                        Poets_mode_is_turned_on = int.Parse(Config.IniReadValue("GameServer", "Poets_mode_is_turned_on").Trim());
                        Retro_mode_is_enabled = int.Parse(Config.IniReadValue("GameServer", "Retro_mode_is_enabled").Trim());
                        Gain_experience_level_difference = int.Parse(Config.IniReadValue("GameServer", "Gain_experience_level_difference").Trim());
                        Han_che_PK_tam_khoang_cach = double.Parse(Config.IniReadValue("GameServer", "Han_che_PK_tam_khoang_cach").Trim());
                        Restrictions_meditation_distance = double.Parse(Config.IniReadValue("GameServer", "Restrictions_meditation_distance").Trim());
                        Empty_distance = double.Parse(Config.IniReadValue("GameServer", "Empty_distance").Trim());
                        GangWar_Switch = int.Parse(Config.IniReadValue("GameServer", "Bang_chien_mo_ra").Trim());
                        Bang_chien_thoi_gian_chien_dau = int.Parse(Config.IniReadValue("GameServer", "Bang_chien_thoi_gian_chien_dau").Trim());
                        To_help_fight_winning_gold_ingot_number = Config.IniReadValue("GameServer", "To_help_fight_winning_gold_ingot_number").Trim();
                        Number_of_points_gold_coins_to_help_draw = Config.IniReadValue("GameServer", "Number_of_points_gold_coins_to_help_draw").Trim();
                        Cancel_help_combat_several_gold_bullions = Config.IniReadValue("GameServer", "Cancel_help_combat_several_gold_bullions").Trim();
                        Application_help_combat_several_gold_bullions = Config.IniReadValue("GameServer", "Application_help_combat_several_gold_bullions").Trim();
                        Bang_chien_nhan_so_khong_che = Config.IniReadValue("GameServer", "Bang_chien_nhan_so_khong_che").Trim();
                        Sung_vat_Cong_kich_suc_manh_boi_so = int.Parse(Config.IniReadValue("GameServer", "Sung_vat_Cong_kich_suc_manh_boi_so").Trim());
                        BOSS_hoang_da_thiet_lap = Config.IniReadValue("GameServer", "BOSS_hoang_da_thiet_lap").Trim();
                        BOSS_hoang_da_thiet_lap2 = Config.IniReadValue("GameServer", "BOSS_hoang_da_thiet_lap2").Trim();
                        Thang_cap_thanh_vien_can_Thuoc_tinh = Config.IniReadValue("GameServer", "Thang_cap_thanh_vien_can_Thuoc_tinh").Trim();
                        Nhan_vat_level_cao_nhat = (Config.IniReadValue("GameServer", "Nhan_vat_level_cao_nhat").Trim() == "") ? 0L : long.Parse(Config.IniReadValue("GameServer", "Nhan_vat_level_cao_nhat").Trim());
                        Nhan_vat_lon_nhat_CASH_so_luong = (Config.IniReadValue("GameServer", "Nhan_vat_lon_nhat_CASH_so_luong").Trim() == "") ? 0x77359400L : long.Parse(Config.IniReadValue("GameServer", "Nhan_vat_lon_nhat_CASH_so_luong").Trim());
                        Item_khoa_chat = Config.IniReadValue("GameServer", "Item_khoa_chat").Trim();
                        Ban_do_khoa_chat = Config.IniReadValue("GameServer", "Ban_do_khoa_chat").Trim();
                        DestroyMonsterScriptUSE = (Config.IniReadValue("GameServer", "DestroyMonsterScriptUSE").Trim() == "") ? DestroyMonsterScriptUSE : int.Parse(Config.IniReadValue("GameServer", "DestroyMonsterScriptUSE").Trim());
                        Drop_Nhac_nho_noi_dung = Config.IniReadValue("GameServer", "Drop_Nhac_nho_noi_dung").Trim();
                        Openbox_nhac_nho_noi_dung = Config.IniReadValue("GameServer", "Openbox_nhac_nho_noi_dung").Trim();
                        Tam_the_mau_do_nhac_nho_noi_dung = Config.IniReadValue("GameServer", "Tam_the_mau_do_nhac_nho_noi_dung").Trim();
                        Tam_the_mau_do_tham_Nhac_nho_noi_dung = Config.IniReadValue("GameServer", "Tam_the_mau_do_tham_Nhac_nho_noi_dung").Trim();
                        Tam_the_mau_cam_Nhac_nho_noi_dung = Config.IniReadValue("GameServer", "Tam_the_mau_cam_Nhac_nho_noi_dung").Trim();
                        Tam_the_mau_xanh_luc_Nhac_nho_noi_dung = Config.IniReadValue("GameServer", "Tam_the_mau_xanh_luc_Nhac_nho_noi_dung").Trim();
                        Tam_the_mau_xanh_lam_Nhac_nho_noi_dung = Config.IniReadValue("GameServer", "Tam_the_mau_xanh_lam_Nhac_nho_noi_dung").Trim();
                        Tam_the_lam_dam_Nhac_nho_noi_dung = Config.IniReadValue("GameServer", "Tam_the_lam_dam_Nhac_nho_noi_dung").Trim();
                        Tam_the_mau_tim_Nhac_nho_noi_dung = Config.IniReadValue("GameServer", "Tam_the_mau_tim_Nhac_nho_noi_dung").Trim();
                        Tam_the_mau_tim_nhat_Nhac_nho_noi_dung = Config.IniReadValue("GameServer", "Tam_the_mau_tim_nhat_Nhac_nho_noi_dung").Trim();
                        Multicolored_speak_Range = (Config.IniReadValue("GameServer", "Multicolored_speak_Range").Trim() == "") ? Multicolored_speak_Range : int.Parse(Config.IniReadValue("GameServer", "Multicolored_speak_Range").Trim());
                        Thoi_gian_Duoc_pham_mo_ra = int.Parse(Config.IniReadValue("GameServer", "Thoi_gian_Duoc_pham_mo_ra").Trim());
                        Duoc_pham_A = Config.IniReadValue("GameServer", "Duoc_pham_A").Trim();
                        Duoc_pham_B = Config.IniReadValue("GameServer", "Duoc_pham_B").Trim();
                        Duoc_pham_C = Config.IniReadValue("GameServer", "Duoc_pham_C").Trim();
                        Duoc_pham_D = Config.IniReadValue("GameServer", "Duoc_pham_D").Trim();
                        Duoc_pham_E = Config.IniReadValue("GameServer", "Duoc_pham_E").Trim();
                        Duoc_pham_F = Config.IniReadValue("GameServer", "Duoc_pham_F").Trim();
                        Duoc_pham_G = Config.IniReadValue("GameServer", "Duoc_pham_G").Trim();
                        Duoc_pham_H = Config.IniReadValue("GameServer", "Duoc_pham_H").Trim();
                        string[] textArray1 = new string[] { Duoc_pham_A, "|", Duoc_pham_B, "|", Duoc_pham_C, "|", Duoc_pham_D, "|", Duoc_pham_E, "|", Duoc_pham_F, "|", Duoc_pham_G, "|", Duoc_pham_H };
                        char[] chArray12 = new char[] { '|' };
                        string[] strArray = string.Concat(textArray1).Split(chArray12);
                        dictionary_27.Clear();
                        Class67 class2 = new Class67();
                        for (int i = 0; i < strArray.Length; i++)
                        {
                              char[] chArray13 = new char[] { ',' };
                              string[] strArray2 = strArray[i].Split(chArray13);
                              if (strArray2.Length > 1)
                              {
                                    class2 = new Class67
                                    {
                                          int_0 = int.Parse(strArray2[0]),
                                          int_1 = int.Parse(strArray2[1]),
                                          int_2 = int.Parse(strArray2[2]),
                                          int_3 = int.Parse(strArray2[3]),
                                          int_4 = int.Parse(strArray2[4])
                                    };
                                    dictionary_27.Add(int.Parse(strArray2[0]), class2);
                              }
                        }
                        Nhan_vat_dang_cap_cao_nhat = int.Parse(Config.IniReadValue("GameServer", "Nhan_vat_dang_cap_cao_nhat").Trim());
                        Item_Exchange_LUA_script_is_open = int.Parse(Config.IniReadValue("GameServer", "Item_Exchange_LUA_script_is_open").Trim());
                        Trang_phuc_gui_di_mo_ra = int.Parse(Config.IniReadValue("GameServer", "Trang_phuc_gui_di_mo_ra").Trim());
                        Login_thuoc_tinh_nhac_nho_mo_ra = int.Parse(Config.IniReadValue("GameServer", "Login_thuoc_tinh_nhac_nho_mo_ra").Trim());
                        Nhac_si_login_Dang_cap = int.Parse(Config.IniReadValue("GameServer", "Nhac_si_login_Dang_cap").Trim());
                        Khu_an_toan_ban_do = int.Parse(Config.IniReadValue("GameServer", "Khu_an_toan_ban_do").Trim());
                        Khu_an_toan_X_toa_do = float.Parse(Config.IniReadValue("GameServer", "Khu_an_toan_X_toa_do").Trim());
                        Khu_an_toan_Y_toa_do = float.Parse(Config.IniReadValue("GameServer", "Khu_an_toan_Y_toa_do").Trim());
                        char[] chArray14 = new char[] { ';' };
                        PK_he_thong_han_che_ban_do = Config.IniReadValue("GameServer", "PK_he_thong_han_che_ban_do").Trim().Split(chArray14);
                        PK_mat_level = int.Parse(Config.IniReadValue("GameServer", "PK_mat_level").Trim());
                        PK_mat_CASH = int.Parse(Config.IniReadValue("GameServer", "PK_mat_CASH").Trim());
                        PK_mat_CASH_he_thong_thu_ve_so_luong = int.Parse(Config.IniReadValue("GameServer", "PK_mat_CASH_he_thong_thu_ve_so_luong").Trim());
                        TimeSystemSwitch = int.Parse(Config.IniReadValue("GameServer", "Thoi_gian_he_thong_mo_ra").Trim());
                        trang_bi_Vo_huan_sua_chua_tieu_hao_Vo_huan_so_luong = int.Parse(Config.IniReadValue("GameServer", "trang_bi_Vo_huan_sua_chua_tieu_hao_Vo_huan_so_luong").Trim());
                        Cam_PK_ban_do = Config.IniReadValue("GameServer", "Cam_PK_ban_do").Trim();
                        Ao_choang_cuong_hoa_tieu_hao_Loai_hinh = (Config.IniReadValue("GameServer", "Ao_choang_cuong_hoa_tieu_hao_Loai_hinh").Trim() == "") ? 0 : int.Parse(Config.IniReadValue("GameServer", "Ao_choang_cuong_hoa_tieu_hao_Loai_hinh").Trim());
                        Cuong_hoa_tieu_hao_So_luong = (Config.IniReadValue("GameServer", "Cuong_hoa_tieu_hao_So_luong").Trim() == "") ? 0 : int.Parse(Config.IniReadValue("GameServer", "Cuong_hoa_tieu_hao_So_luong").Trim());
                        Ao_choang_phan_giai_tieu_hao_Loai_hinh = (Config.IniReadValue("GameServer", "Ao_choang_phan_giai_tieu_hao_Loai_hinh").Trim() == "") ? 0 : int.Parse(Config.IniReadValue("GameServer", "Ao_choang_phan_giai_tieu_hao_Loai_hinh").Trim());
                        Phan_giai_tieu_hao_So_luong = (Config.IniReadValue("GameServer", "Phan_giai_tieu_hao_So_luong").Trim() == "") ? 0 : int.Parse(Config.IniReadValue("GameServer", "Phan_giai_tieu_hao_So_luong").Trim());
                        Ao_choang_to_hop_tieu_hao_Loai_hinh = (Config.IniReadValue("GameServer", "Ao_choang_to_hop_tieu_hao_Loai_hinh").Trim() == "") ? 0 : int.Parse(Config.IniReadValue("GameServer", "Ao_choang_to_hop_tieu_hao_Loai_hinh").Trim());
                        To_hop_tieu_hao_so_luong = (Config.IniReadValue("GameServer", "To_hop_tieu_hao_so_luong").Trim() == "") ? 0 : int.Parse(Config.IniReadValue("GameServer", "To_hop_tieu_hao_so_luong").Trim());
                        Co_hay_khong_mo_ra_ao_choang_cuong_hoa = (Config.IniReadValue("GameServer", "Co_hay_khong_mo_ra_ao_choang_cuong_hoa").Trim() == "") ? Co_hay_khong_mo_ra_ao_choang_cuong_hoa : int.Parse(Config.IniReadValue("GameServer", "Co_hay_khong_mo_ra_ao_choang_cuong_hoa").Trim());
                        Ao_choang_cuong_hoa_tong_xac_suat = Config.IniReadValue("GameServer", "Ao_choang_cuong_hoa_tong_xac_suat").Trim();
                        Ao_choang_cuong_hoa_1_giai_doan_xac_suat = (Config.IniReadValue("GameServer", "Ao_choang_cuong_hoa_1_giai_doan_xac_suat") == "") ? Ao_choang_cuong_hoa_1_giai_doan_xac_suat : double.Parse(Config.IniReadValue("GameServer", "Ao_choang_cuong_hoa_1_giai_doan_xac_suat"));
                        Ao_choang_cuong_hoa_2_giai_doan_xac_suat = (Config.IniReadValue("GameServer", "Ao_choang_cuong_hoa_2_giai_doan_xac_suat") == "") ? Ao_choang_cuong_hoa_2_giai_doan_xac_suat : double.Parse(Config.IniReadValue("GameServer", "Ao_choang_cuong_hoa_2_giai_doan_xac_suat"));
                        Ao_choang_cuong_hoa_3_giai_doan_xac_suat = (Config.IniReadValue("GameServer", "Ao_choang_cuong_hoa_3_giai_doan_xac_suat") == "") ? Ao_choang_cuong_hoa_3_giai_doan_xac_suat : double.Parse(Config.IniReadValue("GameServer", "Ao_choang_cuong_hoa_3_giai_doan_xac_suat"));
                        Ao_choang_cuong_hoa_4_giai_doan_xac_suat = (Config.IniReadValue("GameServer", "Ao_choang_cuong_hoa_4_giai_doan_xac_suat") == "") ? Ao_choang_cuong_hoa_4_giai_doan_xac_suat : double.Parse(Config.IniReadValue("GameServer", "Ao_choang_cuong_hoa_4_giai_doan_xac_suat"));
                        Ao_choang_cuong_hoa_5_giai_doan_xac_suat = (Config.IniReadValue("GameServer", "Ao_choang_cuong_hoa_5_giai_doan_xac_suat") == "") ? Ao_choang_cuong_hoa_5_giai_doan_xac_suat : double.Parse(Config.IniReadValue("GameServer", "Ao_choang_cuong_hoa_5_giai_doan_xac_suat"));
                        Ao_choang_cuong_hoa_6_giai_doan_xac_suat = (Config.IniReadValue("GameServer", "Ao_choang_cuong_hoa_6_giai_doan_xac_suat") == "") ? Ao_choang_cuong_hoa_6_giai_doan_xac_suat : double.Parse(Config.IniReadValue("GameServer", "Ao_choang_cuong_hoa_6_giai_doan_xac_suat"));
                        Ao_choang_cuong_hoa_7_giai_doan_xac_suat = (Config.IniReadValue("GameServer", "Ao_choang_cuong_hoa_7_giai_doan_xac_suat") == "") ? Ao_choang_cuong_hoa_7_giai_doan_xac_suat : double.Parse(Config.IniReadValue("GameServer", "Ao_choang_cuong_hoa_7_giai_doan_xac_suat"));
                        Co_hay_khong_mo_ra_cua_hang_CASH = (Config.IniReadValue("GameServer", "Co_hay_khong_mo_ra_cua_hang_CASH").Trim() == "") ? Co_hay_khong_mo_ra_cua_hang_CASH : int.Parse(Config.IniReadValue("GameServer", "Co_hay_khong_mo_ra_cua_hang_CASH").Trim());
                        Cho_phep_item_ban_ra_lon_nhat_CASH_so_luong = (Config.IniReadValue("GameServer", "Cho_phep_item_ban_ra_lon_nhat_CASH_so_luong").Trim() == "") ? Cho_phep_item_ban_ra_lon_nhat_CASH_so_luong : int.Parse(Config.IniReadValue("GameServer", "Cho_phep_item_ban_ra_lon_nhat_CASH_so_luong").Trim());
                        Ao_Bang_to_hop_tieu_hao_Loai_hinh = (Config.IniReadValue("GameServer", "Ao_Bang_to_hop_tieu_hao_Loai_hinh").Trim() == "") ? 0 : int.Parse(Config.IniReadValue("GameServer", "Ao_Bang_to_hop_tieu_hao_Loai_hinh").Trim());
                        Ao_Bang_to_hop_tieu_hao_so_luong = (Config.IniReadValue("GameServer", "Ao_Bang_to_hop_tieu_hao_so_luong").Trim() == "") ? 0 : int.Parse(Config.IniReadValue("GameServer", "Ao_Bang_to_hop_tieu_hao_so_luong").Trim());
                        Ngoi_tu_he_thong_co_hay_khong_mo_ra = int.Parse(Config.IniReadValue("GameServer", "Ngoi_tu_he_thong_co_hay_khong_mo_ra").Trim());
                        Nguc_giam_ban_do = Config.IniReadValue("GameServer", "Nguc_giam_ban_do").Trim();
                        Ngoi_tu_thien_ac = int.Parse(Config.IniReadValue("GameServer", "Ngoi_tu_thien_ac").Trim());
                        Ngoi_tu_thien_ac_khoi_phuc_thoi_gian = int.Parse(Config.IniReadValue("GameServer", "Ngoi_tu_thien_ac_khoi_phuc_thoi_gian").Trim());
                        Ngoi_tu_khoi_phuc_thien_ac_diem_so = int.Parse(Config.IniReadValue("GameServer", "Ngoi_tu_khoi_phuc_thien_ac_diem_so").Trim());
                        Tu_vong_tro_ve_thanh_Ban_do_Toa_do = Config.IniReadValue("GameServer", "Tu_vong_tro_ve_thanh_Ban_do_Toa_do").Trim();
                        The_luc_chien_tro_ve_Thanh_toa_do = Config.IniReadValue("GameServer", "The_luc_chien_tro_ve_Thanh_toa_do").Trim();
                        Ngoi_tu_tro_ve_thanh_toa_do = Config.IniReadValue("GameServer", "Ngoi_tu_tro_ve_thanh_toa_do").Trim();
                        Ngoi_tu_tha_ra_thong_cao = (Config.IniReadValue("GameServer", "Ngoi_tu_tha_ra_thong_cao").Trim() == "") ? Ngoi_tu_tha_ra_thong_cao : Config.IniReadValue("GameServer", "Ngoi_tu_tha_ra_thong_cao").Trim();
                        Ngoi_tu_giet_nguoi_thong_cao = (Config.IniReadValue("GameServer", "Ngoi_tu_giet_nguoi_thong_cao").Trim() == "") ? Ngoi_tu_giet_nguoi_thong_cao : Config.IniReadValue("GameServer", "Ngoi_tu_giet_nguoi_thong_cao").Trim();
                        Trusted_Connection_IP = Config.IniReadValue("GameServer", "Trusted_Connection_IP").Trim();
                        Cho_phep_mo_nhieu_So_luong = (Config.IniReadValue("GameServer", "Cho_phep_mo_nhieu_So_luong").Trim() == "") ? Cho_phep_mo_nhieu_So_luong : int.Parse(Config.IniReadValue("GameServer", "Cho_phep_mo_nhieu_So_luong").Trim());
                        Co_hay_khong_mo_ra_an_toan_hinh_thuc = (Config.IniReadValue("GameServer", "Co_hay_khong_mo_ra_an_toan_hinh_thuc").Trim() == "") ? Co_hay_khong_mo_ra_an_toan_hinh_thuc : int.Parse(Config.IniReadValue("GameServer", "Co_hay_khong_mo_ra_an_toan_hinh_thuc").Trim());
                        An_toan_hinh_thuc_tieu_hao_CASH = (Config.IniReadValue("GameServer", "An_toan_hinh_thuc_tieu_hao_CASH").Trim() == "") ? An_toan_hinh_thuc_tieu_hao_CASH : int.Parse(Config.IniReadValue("GameServer", "An_toan_hinh_thuc_tieu_hao_CASH").Trim());
                        Thoi_gian_an_toan_bat_dau = (Config.IniReadValue("GameServer", "Thoi_gian_an_toan_bat_dau").Trim() == "") ? Thoi_gian_an_toan_bat_dau : int.Parse(Config.IniReadValue("GameServer", "Thoi_gian_an_toan_bat_dau").Trim());
                        Thoi_gian_an_toan_ket_thuc = (Config.IniReadValue("GameServer", "Thoi_gian_an_toan_ket_thuc").Trim() == "") ? Thoi_gian_an_toan_ket_thuc : int.Parse(Config.IniReadValue("GameServer", "Thoi_gian_an_toan_ket_thuc").Trim());
                        this.method_7();
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(100, "Game profile configuration .ini configuration errors, compared to the update files:" + exception.Message);                       
                  }
            }

            public void SetConfig2()
            {
                  try
                  {
                        Config.Pathqg = Application.StartupPath + @"\QigongConfiguration.ini";
                        THIEN_HUU_CHI_KHI_TI_LE_PHAN_TRAM = (Config.smethod_2("QigongConfiguration", "THIEN_HUU_CHI_KHI_TI_LE_PHAN_TRAM").Trim() == "") ? THIEN_HUU_CHI_KHI_TI_LE_PHAN_TRAM : double.Parse(Config.smethod_2("QigongConfiguration", "THIEN_HUU_CHI_KHI_TI_LE_PHAN_TRAM").Trim());
                        KHI_CONG_TI_LE_PHAN_TRAM = (Config.smethod_2("QigongConfiguration", "KHI_CONG_TI_LE_PHAN_TRAM").Trim() == "") ? KHI_CONG_TI_LE_PHAN_TRAM : double.Parse(Config.smethod_2("QigongConfiguration", "KHI_CONG_TI_LE_PHAN_TRAM").Trim());
                        SO_KHI_CONG_TANG_TOI_DA = (Config.smethod_2("QigongConfiguration", "SO_KHI_CONG_TANG_TOI_DA").Trim() == "") ? SO_KHI_CONG_TANG_TOI_DA : int.Parse(Config.smethod_2("QigongConfiguration", "SO_KHI_CONG_TANG_TOI_DA").Trim());
                        DAI_PHU_HOI_KHI_LIEU_THUONG_THEM_HP = int.Parse(Config.smethod_2("QigongConfiguration", "DAI_PHU_HOI_KHI_LIEU_THUONG_THEM_HP").Trim());
                        DAI_PHU_VAN_KHI_LIEU_THUONG_THEM_HP = int.Parse(Config.smethod_2("QigongConfiguration", "DAI_PHU_VAN_KHI_LIEU_THUONG_THEM_HP").Trim());
                        DAI_PHU_TU_KHI_LIEU_THUONG_THEM_HP = int.Parse(Config.smethod_2("QigongConfiguration", "DAI_PHU_TU_KHI_LIEU_THUONG_THEM_HP").Trim());
                        THICH_KHACH_LIEN_HOAN_PHI_VU_UY_LUC = (Config.IniReadValue("GameServer", "THICH_KHACH_LIEN_HOAN_PHI_VU_UY_LUC").Trim() == "") ? THICH_KHACH_LIEN_HOAN_PHI_VU_UY_LUC : double.Parse(Config.IniReadValue("GameServer", "THICH_KHACH_LIEN_HOAN_PHI_VU_UY_LUC").Trim());
                        THICH_KHACH_TAM_HOA_TU_DINH_TY_LE_TANG_CUONG = (Config.smethod_2("QigongConfiguration", "THICH_KHACH_TAM_HOA_TU_DINH_TY_LE_TANG_CUONG").Trim() == "") ? THICH_KHACH_TAM_HOA_TU_DINH_TY_LE_TANG_CUONG : double.Parse(Config.smethod_2("QigongConfiguration", "THICH_KHACH_TAM_HOA_TU_DINH_TY_LE_TANG_CUONG").Trim());
                        THUONG_KHACH_CAN_KHON_NA_DI_VO_CONG_UY_LUC = (Config.smethod_2("QigongConfiguration", "THUONG_KHACH_CAN_KHON_NA_DI_VO_CONG_UY_LUC").Trim() == "") ? THUONG_KHACH_CAN_KHON_NA_DI_VO_CONG_UY_LUC : double.Parse(Config.smethod_2("QigongConfiguration", "THUONG_KHACH_CAN_KHON_NA_DI_VO_CONG_UY_LUC").Trim());
                        KIEM_KHACH_HOI_LIEU_THAN_PHAP_NE_TRANH_TY_LE = (Config.smethod_2("QigongConfiguration", "KIEM_KHACH_HOI_LIEU_THAN_PHAP_NE_TRANH_TY_LE").Trim() == "") ? KIEM_KHACH_HOI_LIEU_THAN_PHAP_NE_TRANH_TY_LE : double.Parse(Config.smethod_2("QigongConfiguration", "KIEM_KHACH_HOI_LIEU_THAN_PHAP_NE_TRANH_TY_LE").Trim());
                        KIEM_KHACH_HOI_LIEU_THAN_PHAP_VO_CONG_UY_LUC = (Config.smethod_2("QigongConfiguration", "KIEM_KHACH_HOI_LIEU_THAN_PHAP_VO_CONG_UY_LUC").Trim() == "") ? KIEM_KHACH_HOI_LIEU_THAN_PHAP_VO_CONG_UY_LUC : double.Parse(Config.smethod_2("QigongConfiguration", "KIEM_KHACH_HOI_LIEU_THAN_PHAP_VO_CONG_UY_LUC").Trim());
                        THICH_KHACH_TAM_THAN_NGUNG_TU_UY_LUC = (Config.smethod_2("QigongConfiguration", "THICH_KHACH_TAM_THAN_NGUNG_TU_UY_LUC").Trim() == "") ? THICH_KHACH_TAM_THAN_NGUNG_TU_UY_LUC : double.Parse(Config.smethod_2("QigongConfiguration", "THICH_KHACH_TAM_THAN_NGUNG_TU_UY_LUC").Trim());
                        THICH_KHACH_TAT_SAT_NHAT_KICH_UY_LUC = (Config.smethod_2("QigongConfiguration", "THICH_KHACH_TAT_SAT_NHAT_KICH_UY_LUC").Trim() == "") ? THICH_KHACH_TAT_SAT_NHAT_KICH_UY_LUC : double.Parse(Config.smethod_2("QigongConfiguration", "THICH_KHACH_TAT_SAT_NHAT_KICH_UY_LUC").Trim());
                        CUNG_THU_VO_MINH_AM_THI_TY_LE = (Config.smethod_2("QigongConfiguration", "CUNG_THU_VO_MINH_AM_THI_TY_LE").Trim() == "") ? CUNG_THU_VO_MINH_AM_THI_TY_LE : double.Parse(Config.smethod_2("QigongConfiguration", "CUNG_THU_VO_MINH_AM_THI_TY_LE").Trim());
                        CUNG_THU_TRI_MENH_TUYET_SAT_TY_LE = (Config.smethod_2("QigongConfiguration", "CUNG_THU_TRI_MENH_TUYET_SAT_TY_LE").Trim() == "") ? CUNG_THU_TRI_MENH_TUYET_SAT_TY_LE : double.Parse(Config.smethod_2("QigongConfiguration", "CUNG_THU_TRI_MENH_TUYET_SAT_TY_LE").Trim());
                        KHI_CONG_CO_TAC_DUNG = (Config.smethod_2("QigongConfiguration", "KHI_CONG_CO_TAC_DUNG").Trim() == "") ? KHI_CONG_CO_TAC_DUNG : int.Parse(Config.smethod_2("QigongConfiguration", "KHI_CONG_CO_TAC_DUNG").Trim());
                        VO_KIEN_BAT_TOI_TY_LE_TANG_CUONG = (Config.smethod_2("QigongConfiguration", "VO_KIEN_BAT_TOI_TY_LE_TANG_CUONG").Trim() == "") ? VO_KIEN_BAT_TOI_TY_LE_TANG_CUONG : double.Parse(Config.smethod_2("QigongConfiguration", "VO_KIEN_BAT_TOI_TY_LE_TANG_CUONG").Trim());
                        THUA_THANG_TRUY_KICH_TY_LE_TANG_CUONG = (Config.smethod_2("QigongConfiguration", "THUA_THANG_TRUY_KICH_TY_LE_TANG_CUONG").Trim() == "") ? THUA_THANG_TRUY_KICH_TY_LE_TANG_CUONG : double.Parse(Config.smethod_2("QigongConfiguration", "THUA_THANG_TRUY_KICH_TY_LE_TANG_CUONG").Trim());
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(100, "Qigong profile .ini configuration error, carefully review the update file:" + exception.Message);                        
                  }
            }

            public void SetConfig3()
            {
                  try
                  {
                        Config.Pathst = Application.StartupPath + @"\StoneConfiguration.ini";
                        CUA_HANG_KIM_CUONG_THACH = Config.smethod_3("StoneConfiguration", "CUA_HANG_KIM_CUONG_THACH").Trim();
                        CUA_HANG_HAN_NGOC_THACH = Config.smethod_3("StoneConfiguration", "CUA_HANG_HAN_NGOC_THACH").Trim();
                        CUA_HANG_NHIET_HUYET_THACH = Config.smethod_3("StoneConfiguration", "CUA_HANG_NHIET_HUYET_THACH").Trim();
                        CUA_HANG_HON_NGUYEN_KIM_CUONG_THACH = Config.smethod_3("StoneConfiguration", "CUA_HANG_HON_NGUYEN_KIM_CUONG_THACH").Trim();
                        char[] separator = new char[] { ';' };
                        CUA_HANG_BANG_PHACH_HAN_NGOC_THACH_VO_CONG_PHONG_NGU = Config.smethod_3("StoneConfiguration", "CUA_HANG_BANG_PHACH_HAN_NGOC_THACH_VO_CONG_PHONG_NGU").Trim().Split(separator);
                        char[] chArray2 = new char[] { ';' };
                        CUA_HANG_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU = Config.smethod_3("StoneConfiguration", "CUA_HANG_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU").Trim().Split(chArray2);
                        CUA_HANG_THAN_BI_KIM_CUONG_THACH_TRUY_THUONG = Config.smethod_3("StoneConfiguration", "CUA_HANG_THAN_BI_KIM_CUONG_THACH_TRUY_THUONG").Trim();
                        CUA_HANG_THAN_BI_KIM_CUONG_THACH_VO_CONG = Config.smethod_3("StoneConfiguration", "CUA_HANG_THAN_BI_KIM_CUONG_THACH_VO_CONG").Trim();
                        CUA_HANG_BANG_PHACH_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP = (Config.smethod_3("StoneConfiguration", "CUA_HANG_BANG_PHACH_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP").Trim() == "") ? 0 : int.Parse(Config.smethod_3("StoneConfiguration", "CUA_HANG_BANG_PHACH_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP").Trim());
                        CUA_HANG_THUOC_TINH_THACH = (Config.smethod_3("StoneConfiguration", "CUA_HANG_THUOC_TINH_THACH").Trim() == "") ? 0 : int.Parse(Config.smethod_3("StoneConfiguration", "CUA_HANG_THUOC_TINH_THACH").Trim());
                        CUA_HANG_CAN_KHON_KIM_CUONG_THACH = Config.smethod_3("StoneConfiguration", "CUA_HANG_CAN_KHON_KIM_CUONG_THACH").Trim();
                        CUA_HANG_NGUNG_SUONG_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP = (Config.smethod_3("StoneConfiguration", "CUA_HANG_NGUNG_SUONG_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP").Trim() == "") ? 0 : int.Parse(Config.smethod_3("StoneConfiguration", "CUA_HANG_NGUNG_SUONG_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP").Trim());
                        char[] chArray3 = new char[] { ';' };
                        CUA_HANG_NGUNG_SUONG_HAN_NGOC_THACH_VO_CONG_PHONG_NGU = Config.smethod_3("StoneConfiguration", "CUA_HANG_NGUNG_SUONG_HAN_NGOC_THACH_VO_CONG_PHONG_NGU").Trim().Split(chArray3);
                        char[] chArray4 = new char[] { ';' };
                        CUA_HANG_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU = Config.smethod_3("StoneConfiguration", "CUA_HANG_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU").Trim().Split(chArray4);
                        BACH_BAO_CAC_KIM_CUONG_THACH = Config.smethod_3("StoneConfiguration", "BACH_BAO_CAC_KIM_CUONG_THACH").Trim();
                        BACH_BAO_CAC_HAN_NGOC_THACH = Config.smethod_3("StoneConfiguration", "BACH_BAO_CAC_HAN_NGOC_THACH").Trim();
                        BACH_BAO_CAC_NHIET_HUYET_THACH = Config.smethod_3("StoneConfiguration", "BACH_BAO_CAC_NHIET_HUYET_THACH").Trim();
                        char[] chArray5 = new char[] { ';' };
                        BACH_BAO_HON_NGUYEN_KIM_CUONG_THACH_CONG_KICH = Config.smethod_3("StoneConfiguration", "BACH_BAO_HON_NGUYEN_KIM_CUONG_THACH_CONG_KICH").Trim().Split(chArray5);
                        char[] chArray6 = new char[] { ';' };
                        BACH_BAO_HON_NGUYEN_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG = Config.smethod_3("StoneConfiguration", "BACH_BAO_HON_NGUYEN_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG").Trim().Split(chArray6);
                        BACH_BAO_HON_NGUYEN_KIM_CUONG_THACH_LOAI_HINH_THIET_LAP = (Config.smethod_3("StoneConfiguration", "BACH_BAO_HON_NGUYEN_KIM_CUONG_THACH_LOAI_HINH_THIET_LAP").Trim() == "") ? 0 : int.Parse(Config.smethod_3("StoneConfiguration", "BACH_BAO_HON_NGUYEN_KIM_CUONG_THACH_LOAI_HINH_THIET_LAP").Trim());
                        char[] chArray7 = new char[] { ';' };
                        BACH_BAO_CAC_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG = Config.smethod_3("StoneConfiguration", "BACH_BAO_CAC_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG").Trim().Split(chArray7);
                        char[] chArray8 = new char[] { ';' };
                        BACH_BAO_CAC_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU = Config.smethod_3("StoneConfiguration", "BACH_BAO_CAC_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU").Trim().Split(chArray8);
                        BACH_BAO_CAC_THAN_BI_KIM_CUONG_THACH_TRUY_THUONG = Config.smethod_3("StoneConfiguration", "BACH_BAO_CAC_THAN_BI_KIM_CUONG_THACH_TRUY_THUONG").Trim();
                        BACH_BAO_CAC_THAN_BI_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG = Config.smethod_3("StoneConfiguration", "BACH_BAO_CAC_THAN_BI_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG").Trim();
                        BACH_BAO_CAC_BANG_PHACH_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP = (Config.smethod_3("StoneConfiguration", "BACH_BAO_CAC_BANG_PHACH_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP").Trim() == "") ? 0 : int.Parse(Config.smethod_3("StoneConfiguration", "BACH_BAO_CAC_BANG_PHACH_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP").Trim());
                        BACH_BAO_CAC_THUOC_TINH_THACH = (Config.smethod_3("StoneConfiguration", "BACH_BAO_CAC_THUOC_TINH_THACH").Trim() == "") ? 0 : int.Parse(Config.smethod_3("StoneConfiguration", "BACH_BAO_CAC_THUOC_TINH_THACH").Trim());
                        BACH_BAO_CAC_NGUNG_SUONG_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP = (Config.smethod_3("StoneConfiguration", "BACH_BAO_CAC_NGUNG_SUONG_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP").Trim() == "") ? 0 : int.Parse(Config.smethod_3("StoneConfiguration", "BACH_BAO_CAC_NGUNG_SUONG_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP").Trim());
                        char[] chArray9 = new char[] { ';' };
                        BACH_BAO_CAC_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG = Config.smethod_3("StoneConfiguration", "BACH_BAO_CAC_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG").Trim().Split(chArray9);
                        char[] chArray10 = new char[] { ';' };
                        BACH_BAO_CAC_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU = Config.smethod_3("StoneConfiguration", "BACH_BAO_CAC_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU").Trim().Trim().Split(chArray10);
                        BACH_BAO_CAC_SO_CAP_KY_NGOC_THACH = Config.smethod_3("StoneConfiguration", "BACH_BAO_CAC_SO_CAP_KY_NGOC_THACH").Trim();
                        BACH_BAO_CAC_TRUNG_CAP_KY_NGOC_THACH = Config.smethod_3("StoneConfiguration", "BACH_BAO_CAC_TRUNG_CAP_KY_NGOC_THACH").Trim();
                        BACH_BAO_CAC_CAO_CAP_KY_NGOC_THACH = Config.smethod_3("StoneConfiguration", "BACH_BAO_CAC_CAO_CAP_KY_NGOC_THACH").Trim();
                        char[] chArray11 = new char[] { ';' };
                        BACH_BAO_CAN_KHON_KIM_CUONG_THACH_CONG_KICH = Config.smethod_3("StoneConfiguration", "BACH_BAO_CAN_KHON_KIM_CUONG_THACH_CONG_KICH").Trim().Split(chArray11);
                        char[] chArray12 = new char[] { ';' };
                        BACH_BAO_CAN_KHON_KIM_CUONG_THACH_CONG_KICH_VO_CONG = Config.smethod_3("StoneConfiguration", "BACH_BAO_CAN_KHON_KIM_CUONG_THACH_CONG_KICH_VO_CONG").Trim().Split(chArray12);
                        BACH_BAO_CAN_KHON_KIM_CUONG_THACH_LOAI_HINH_THIET_LAP = (Config.smethod_3("StoneConfiguration", "BACH_BAO_CAN_KHON_KIM_CUONG_THACH_LOAI_HINH_THIET_LAP").Trim() == "") ? 0 : int.Parse(Config.smethod_3("StoneConfiguration", "BACH_BAO_CAN_KHON_KIM_CUONG_THACH_LOAI_HINH_THIET_LAP").Trim());
                        MO_HOM_KIM_CUONG_THACH = Config.smethod_3("StoneConfiguration", "MO_HOM_KIM_CUONG_THACH").Trim();
                        MO_HOM_HAN_NGOC_THACH = Config.smethod_3("StoneConfiguration", "MO_HOM_HAN_NGOC_THACH").Trim();
                        MO_HOM_NHIET_HUYET_THACH = Config.smethod_3("StoneConfiguration", "MO_HOM_NHIET_HUYET_THACH").Trim();
                        MO_HOM_HON_NGUYEN_KIM_CUONG_THACH_LOAI_HINH_THIET_LAP = (Config.smethod_3("StoneConfiguration", "MO_HOM_HON_NGUYEN_KIM_CUONG_THACH_LOAI_HINH_THIET_LAP").Trim() == "") ? 0 : int.Parse(Config.smethod_3("StoneConfiguration", "MO_HOM_HON_NGUYEN_KIM_CUONG_THACH_LOAI_HINH_THIET_LAP").Trim());
                        char[] chArray13 = new char[] { ';' };
                        MO_HOM_HON_NGUYEN_DA_KIM_CUONG_LUC_CONG_KICH_VO_CONG = Config.smethod_3("StoneConfiguration", "MO_HOM_HON_NGUYEN_DA_KIM_CUONG_LUC_CONG_KICH_VO_CONG").Trim().Split(chArray13);
                        char[] chArray14 = new char[] { ';' };
                        MO_HOM_HON_NGUYEN_KIM_CUONG_THACH_CONG_KICH = Config.smethod_3("StoneConfiguration", "MO_HOM_HON_NGUYEN_KIM_CUONG_THACH_CONG_KICH").Trim().Split(chArray14);
                        char[] chArray15 = new char[] { ';' };
                        MO_HOM_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG = Config.smethod_3("StoneConfiguration", "MO_HOM_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG").Trim().Trim().Split(chArray15);
                        char[] chArray16 = new char[] { ';' };
                        MO_HOM_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU = Config.smethod_3("StoneConfiguration", "MO_HOM_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU").Trim().Trim().Split(chArray16);
                        MO_HOM_BANG_PHACH_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP = (Config.smethod_3("StoneConfiguration", "MO_HOM_BANG_PHACH_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP").Trim() == "") ? 0 : int.Parse(Config.smethod_3("StoneConfiguration", "MO_HOM_BANG_PHACH_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP").Trim());
                        MO_HOM_THUOC_TINH_THACH = (Config.smethod_3("StoneConfiguration", "MO_HOM_THUOC_TINH_THACH").Trim() == "") ? 0 : int.Parse(Config.smethod_3("StoneConfiguration", "MO_HOM_THUOC_TINH_THACH").Trim());
                        char[] chArray17 = new char[] { ';' };
                        MO_HOM_CAN_KHON_KIM_CUONG_THACH_CONG_KICH = Config.smethod_3("StoneConfiguration", "MO_HOM_CAN_KHON_KIM_CUONG_THACH_CONG_KICH").Trim().Trim().Split(chArray17);
                        char[] chArray18 = new char[] { ';' };
                        MO_HOM_CAN_KHON_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG = Config.smethod_3("StoneConfiguration", "MO_HOM_CAN_KHON_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG").Trim().Trim().Split(chArray18);
                        MO_HOM_CAN_KHON_KIM_CUONG_THACH_LOAI_HINH_THIET_LAP = (Config.smethod_3("StoneConfiguration", "MO_HOM_CAN_KHON_KIM_CUONG_THACH_LOAI_HINH_THIET_LAP").Trim() == "") ? 0 : int.Parse(Config.smethod_3("StoneConfiguration", "MO_HOM_CAN_KHON_KIM_CUONG_THACH_LOAI_HINH_THIET_LAP").Trim());
                        MO_HOM_NGUNG_SUONG_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP = (Config.smethod_3("StoneConfiguration", "MO_HOM_NGUNG_SUONG_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP").Trim() == "") ? 0 : int.Parse(Config.smethod_3("StoneConfiguration", "MO_HOM_NGUNG_SUONG_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP").Trim());
                        char[] chArray19 = new char[] { ';' };
                        MO_HOM_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG = Config.smethod_3("StoneConfiguration", "MO_HOM_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG").Trim().Split(chArray19);
                        char[] chArray20 = new char[] { ';' };
                        MO_HOM_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU = Config.smethod_3("StoneConfiguration", "MO_HOM_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU").Trim().Trim().Split(chArray20);
                        MO_HOM_THAN_BI_KIM_CUONG_THACH_TRUY_THUONG = Config.smethod_3("StoneConfiguration", "MO_HOM_THAN_BI_KIM_CUONG_THACH_TRUY_THUONG").Trim();
                        MO_HOM_THAN_BI_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG = Config.smethod_3("StoneConfiguration", "MO_HOM_THAN_BI_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG").Trim();
                        KHEN_THUONG_KIM_CUONG_THACH = Config.smethod_3("StoneConfiguration", "KHEN_THUONG_KIM_CUONG_THACH").Trim();
                        KHEN_THUONG_HAN_NGOC_THACH = Config.smethod_3("StoneConfiguration", "KHEN_THUONG_HAN_NGOC_THACH").Trim();
                        KHEN_THUONG_NHIET_HUYET_THACH = Config.smethod_3("StoneConfiguration", "KHEN_THUONG_NHIET_HUYET_THACH").Trim();
                        KHEN_THUONG_HON_NGUYEN_KIM_CUONG_THACH = Config.smethod_3("StoneConfiguration", "KHEN_THUONG_HON_NGUYEN_KIM_CUONG_THACH").Trim();
                        char[] chArray21 = new char[] { ';' };
                        KHEN_THUONG_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG = Config.smethod_3("StoneConfiguration", "KHEN_THUONG_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG").Trim().Split(chArray21);
                        char[] chArray22 = new char[] { ';' };
                        KHEN_THUONG_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU = Config.smethod_3("StoneConfiguration", "KHEN_THUONG_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU").Trim().Trim().Split(chArray22);
                        KHEN_THUONG_THAN_BI_KIM_CUONG_THACH_TRUY_THUONG = Config.smethod_3("StoneConfiguration", "KHEN_THUONG_THAN_BI_KIM_CUONG_THACH_TRUY_THUONG").Trim();
                        KHEN_THUONG_THAN_BI_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG = Config.smethod_3("StoneConfiguration", "KHEN_THUONG_THAN_BI_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG").Trim();
                        KHEN_THUONG_BANG_PHACH_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP = (Config.smethod_3("StoneConfiguration", "KHEN_THUONG_BANG_PHACH_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP").Trim() == "") ? 0 : int.Parse(Config.smethod_3("StoneConfiguration", "KHEN_THUONG_BANG_PHACH_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP").Trim());
                        KHEN_THUONG_THUOC_TINH_THACH = (Config.smethod_3("StoneConfiguration", "KHEN_THUONG_THUOC_TINH_THACH").Trim() == "") ? 0 : int.Parse(Config.smethod_3("StoneConfiguration", "KHEN_THUONG_THUOC_TINH_THACH").Trim());
                        KHEN_THUONG_CAN_KHON_KIM_CUONG_THACH = Config.smethod_3("StoneConfiguration", "KHEN_THUONG_CAN_KHON_KIM_CUONG_THACH").Trim();
                        KHEN_THUONG_NGUNG_SUONG_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP = (Config.smethod_3("StoneConfiguration", "KHEN_THUONG_NGUNG_SUONG_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP").Trim() == "") ? 0 : int.Parse(Config.smethod_3("StoneConfiguration", "KHEN_THUONG_NGUNG_SUONG_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP").Trim());
                        char[] chArray23 = new char[] { ';' };
                        KHEN_THUONG_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG = Config.smethod_3("StoneConfiguration", "KHEN_THUONG_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG").Trim().Split(chArray23);
                        char[] chArray24 = new char[] { ';' };
                        KHEN_THUONG_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU = Config.smethod_3("StoneConfiguration", "KHEN_THUONG_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU").Trim().Split(chArray24);
                        QUAI_BINH_THUONG_DROP_KIM_CUONG_THACH = Config.smethod_3("StoneConfiguration", "QUAI_BINH_THUONG_DROP_KIM_CUONG_THACH").Trim();
                        QUAI_BINH_THUONG_DROP_HAN_NGOC_THACH = Config.smethod_3("StoneConfiguration", "QUAI_BINH_THUONG_DROP_HAN_NGOC_THACH").Trim();
                        QUAI_BINH_THUONG_DROP_NHIET_HUYET_THACH = Config.smethod_3("StoneConfiguration", "QUAI_BINH_THUONG_DROP_NHIET_HUYET_THACH").Trim();
                        QUAI_BINH_THUONG_DROP_HON_NGUYEN_KIM_CUONG_THACH = Config.smethod_3("StoneConfiguration", "QUAI_BINH_THUONG_DROP_HON_NGUYEN_KIM_CUONG_THACH").Trim();
                        char[] chArray25 = new char[] { ';' };
                        QUAI_BINH_THUONG_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG = Config.smethod_3("StoneConfiguration", "QUAI_BINH_THUONG_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG").Trim().Split(chArray25);
                        char[] chArray26 = new char[] { ';' };
                        QUAI_BINH_THUONG_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU = Config.smethod_3("StoneConfiguration", "QUAI_BINH_THUONG_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU").Trim().Split(chArray26);
                        QUAI_BINH_THUONG_DROP_THAN_BI_KIM_CUONG_THACH_TRUY_THUONG = Config.smethod_3("StoneConfiguration", "QUAI_BINH_THUONG_DROP_THAN_BI_KIM_CUONG_THACH_TRUY_THUONG").Trim();
                        QUAI_BINH_THUONG_DROP_THAN_BI_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG = Config.smethod_3("StoneConfiguration", "QUAI_BINH_THUONG_DROP_THAN_BI_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG").Trim();
                        QUAI_BINH_THUONG_DROP_BANG_PHACH_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP = (Config.smethod_3("StoneConfiguration", "QUAI_BINH_THUONG_DROP_BANG_PHACH_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP").Trim() == "") ? 0 : int.Parse(Config.smethod_3("StoneConfiguration", "QUAI_BINH_THUONG_DROP_BANG_PHACH_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP").Trim());
                        QUAI_BINH_THUONG_DROP_THUOC_TINH_THACH = (Config.smethod_3("StoneConfiguration", "QUAI_BINH_THUONG_DROP_THUOC_TINH_THACH").Trim() == "") ? 0 : int.Parse(Config.smethod_3("StoneConfiguration", "QUAI_BINH_THUONG_DROP_THUOC_TINH_THACH").Trim());
                        QUAI_BINH_THUONG_DROP_CAN_KHON_KIM_CUONG_THACH = Config.smethod_3("StoneConfiguration", "QUAI_BINH_THUONG_DROP_CAN_KHON_KIM_CUONG_THACH").Trim();
                        QUAI_BINH_THUONG_DROP_NGUNG_SUONG_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP = (Config.smethod_3("StoneConfiguration", "QUAI_BINH_THUONG_DROP_NGUNG_SUONG_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP").Trim() == "") ? 0 : int.Parse(Config.smethod_3("StoneConfiguration", "QUAI_BINH_THUONG_DROP_NGUNG_SUONG_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP").Trim());
                        char[] chArray27 = new char[] { ';' };
                        QUAI_BINH_THUONG_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG = Config.smethod_3("StoneConfiguration", "QUAI_BINH_THUONG_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG").Trim().Split(chArray27);
                        char[] chArray28 = new char[] { ';' };
                        QUAI_BINH_THUONG_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU = Config.smethod_3("StoneConfiguration", "QUAI_BINH_THUONG_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU").Trim().Split(chArray28);
                        BOSS_QUAI_DROP_KIM_CUONG_THACH = Config.smethod_3("StoneConfiguration", "BOSS_QUAI_DROP_KIM_CUONG_THACH").Trim();
                        BOSS_QUAI_DROP_HAN_NGOC_THACH = Config.smethod_3("StoneConfiguration", "BOSS_QUAI_DROP_HAN_NGOC_THACH").Trim();
                        BOSS_QUAI_DROP_NHIET_HUYET_THACH = Config.smethod_3("StoneConfiguration", "BOSS_QUAI_DROP_NHIET_HUYET_THACH").Trim();
                        BOSS_QUAI_DROP_HON_NGUYEN_KIM_CUONG_THACH = Config.smethod_3("StoneConfiguration", "BOSS_QUAI_DROP_HON_NGUYEN_KIM_CUONG_THACH").Trim();
                        char[] chArray29 = new char[] { ';' };
                        BOSS_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG = Config.smethod_3("StoneConfiguration", "BOSS_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG").Trim().Split(chArray29);
                        char[] chArray30 = new char[] { ';' };
                        BOSS_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU = Config.smethod_3("StoneConfiguration", "BOSS_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU").Trim().Split(chArray30);
                        BOSS_QUAI_DROP_THAN_BI_KIM_CUONG_THACH_TRUY_THUONG = Config.smethod_3("StoneConfiguration", "BOSS_QUAI_DROP_THAN_BI_KIM_CUONG_THACH_TRUY_THUONG").Trim();
                        BOSS_QUAI_DROP_THAN_BI_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG = Config.smethod_3("StoneConfiguration", "BOSS_QUAI_DROP_THAN_BI_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG").Trim();
                        BOSS_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP = (Config.smethod_3("StoneConfiguration", "BOSS_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP").Trim() == "") ? 0 : int.Parse(Config.smethod_3("StoneConfiguration", "BOSS_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP").Trim());
                        BOSS_QUAI_DROP_THUOC_TINH_THACH = (Config.smethod_3("StoneConfiguration", "BOSS_QUAI_DROP_THUOC_TINH_THACH").Trim() == "") ? 0 : int.Parse(Config.smethod_3("StoneConfiguration", "BOSS_QUAI_DROP_THUOC_TINH_THACH").Trim());
                        BOSS_QUAI_DROP_CAN_KHON_KIM_CUONG_THACH = Config.smethod_3("StoneConfiguration", "BOSS_QUAI_DROP_CAN_KHON_KIM_CUONG_THACH").Trim();
                        BOSS_QUAI_DROP_NGUNG_SUONG_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP = (Config.smethod_3("StoneConfiguration", "BOSS_QUAI_DROP_NGUNG_SUONG_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP").Trim() == "") ? 0 : int.Parse(Config.smethod_3("StoneConfiguration", "BOSS_QUAI_DROP_NGUNG_SUONG_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP").Trim());
                        char[] chArray31 = new char[] { ';' };
                        BOSS_QUAI_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG = Config.smethod_3("StoneConfiguration", "BOSS_QUAI_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG").Trim().Split(chArray31);
                        char[] chArray32 = new char[] { ';' };
                        BOSS_QUAI_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU = Config.smethod_3("StoneConfiguration", "BOSS_QUAI_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU").Trim().Split(chArray32);
                        CAO_THU_QUAI_DROP_KIM_CUONG_THACH = Config.smethod_3("StoneConfiguration", "CAO_THU_QUAI_DROP_KIM_CUONG_THACH").Trim();
                        CAO_THU_QUAI_DROP_HAN_NGOC_THACH = Config.smethod_3("StoneConfiguration", "CAO_THU_QUAI_DROP_HAN_NGOC_THACH").Trim();
                        CAO_THU_QUAI_DROP_NHIET_HUYET_THACH = Config.smethod_3("StoneConfiguration", "CAO_THU_QUAI_DROP_NHIET_HUYET_THACH").Trim();
                        CAO_THU_QUAI_DROP_HON_NGUYEN_KIM_CUONG_THACH = Config.smethod_3("StoneConfiguration", "CAO_THU_QUAI_DROP_HON_NGUYEN_KIM_CUONG_THACH").Trim();
                        char[] chArray33 = new char[] { ';' };
                        CAO_THU_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG = Config.smethod_3("StoneConfiguration", "CAO_THU_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG").Trim().Split(chArray33);
                        char[] chArray34 = new char[] { ';' };
                        CAO_THU_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU = Config.smethod_3("StoneConfiguration", "CAO_THU_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU").Trim().Split(chArray34);
                        CAO_THU_QUAI_DROP_THAN_BI_KIM_CUONG_THACH_TRUY_THUONG = Config.smethod_3("StoneConfiguration", "CAO_THU_QUAI_DROP_THAN_BI_KIM_CUONG_THACH_TRUY_THUONG").Trim();
                        CAO_THU_QUAI_DROP_THAN_BI_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG = Config.smethod_3("StoneConfiguration", "CAO_THU_QUAI_DROP_THAN_BI_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG").Trim();
                        CAO_THU_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP = (Config.smethod_3("StoneConfiguration", "CAO_THU_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP").Trim() == "") ? 0 : int.Parse(Config.smethod_3("StoneConfiguration", "CAO_THU_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP").Trim());
                        CAO_THU_QUAI_DROP_THUOC_TINH_THACH = (Config.smethod_3("StoneConfiguration", "CAO_THU_QUAI_DROP_THUOC_TINH_THACH").Trim() == "") ? 0 : int.Parse(Config.smethod_3("StoneConfiguration", "CAO_THU_QUAI_DROP_THUOC_TINH_THACH").Trim());
                        CAO_THU_QUAI_DROP_CAN_KHON_KIM_CUONG_THACH = Config.smethod_3("StoneConfiguration", "CAO_THU_QUAI_DROP_CAN_KHON_KIM_CUONG_THACH").Trim();
                        CAO_THU_QUAI_DROP_NGUNG_SUONG_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP = (Config.smethod_3("StoneConfiguration", "CAO_THU_QUAI_DROP_NGUNG_SUONG_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP").Trim() == "") ? 0 : int.Parse(Config.smethod_3("StoneConfiguration", "CAO_THU_QUAI_DROP_NGUNG_SUONG_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP").Trim());
                        char[] chArray35 = new char[] { ';' };
                        CAO_THU_QUAI_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG = Config.smethod_3("StoneConfiguration", "CAO_THU_QUAI_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG").Trim().Split(chArray35);
                        char[] chArray36 = new char[] { ';' };
                        CAO_THU_QUAI_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU = Config.smethod_3("StoneConfiguration", "CAO_THU_QUAI_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU").Trim().Split(chArray36);
                        TAI_TAO_KIM_CUONG_THACH_TAN_CONG = Config.smethod_3("StoneConfiguration", "TAI_TAO_KIM_CUONG_THACH_TAN_CONG").Trim();
                        TAI_TAO_KIM_CUONG_THACH_TRUY_THUONG = Config.smethod_3("StoneConfiguration", "TAI_TAO_KIM_CUONG_THACH_TRUY_THUONG").Trim();
                        TAI_TAO_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG = Config.smethod_3("StoneConfiguration", "TAI_TAO_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG").Trim();
                        TAI_TAO_KIM_CUONG_THACH_TRUNG_MUC_TIEU = Config.smethod_3("StoneConfiguration", "TAI_TAO_KIM_CUONG_THACH_TRUNG_MUC_TIEU").Trim();
                        TAI_TAO_KIM_CUONG_THACH_SINH_MENH = Config.smethod_3("StoneConfiguration", "TAI_TAO_KIM_CUONG_THACH_SINH_MENH").Trim();
                        TAI_TAO_HAN_NGOC_THACH_PHONG_NGU = Config.smethod_3("StoneConfiguration", "TAI_TAO_HAN_NGOC_THACH_PHONG_NGU").Trim();
                        TAI_TAO_HAN_NGOC_THACH_NE_TRANH = Config.smethod_3("StoneConfiguration", "TAI_TAO_HAN_NGOC_THACH_NE_TRANH").Trim();
                        TAI_TAO_HAN_NGOC_THACH_SINH_MENH = Config.smethod_3("StoneConfiguration", "TAI_TAO_HAN_NGOC_THACH_SINH_MENH").Trim();
                        TAI_TAO_HAN_NGOC_THACH_NOI_CONG = Config.smethod_3("StoneConfiguration", "TAI_TAO_HAN_NGOC_THACH_NOI_CONG").Trim();
                        TAI_TAO_HAN_NGOC_THACH_PHONG_NGU_VO_CONG = Config.smethod_3("StoneConfiguration", "TAI_TAO_HAN_NGOC_THACH_PHONG_NGU_VO_CONG").Trim();
                        MOI_LAN_TAI_TAO_TIEU_HAO_THIET_LAP = (Config.smethod_3("StoneConfiguration", "MOI_LAN_TAI_TAO_TIEU_HAO_THIET_LAP").Trim() == "") ? 0 : int.Parse(Config.smethod_3("StoneConfiguration", "MOI_LAN_TAI_TAO_TIEU_HAO_THIET_LAP").Trim());
                        MOI_LAN_TIEU_HAO_SO_LUONG = (Config.smethod_3("StoneConfiguration", "MOI_LAN_TIEU_HAO_SO_LUONG").Trim() == "") ? 0 : int.Parse(Config.smethod_3("StoneConfiguration", "MOI_LAN_TIEU_HAO_SO_LUONG").Trim());
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(100, "Profiles stone property configuration .ini configuration error, carefully review the update file:" + exception.Message);                       
                  }
            }

            public void SetConfig4()
            {
                  try
                  {
                        Config.Pathgj = Application.StartupPath + @"\HookConfiguration.ini";
                        Co_hay_khong_mo_ra_o_tuyen_thoi_gian_khen_thuong = int.Parse(Config.smethod_4("HookConfiguration", "Co_hay_khong_mo_ra_o_tuyen_thoi_gian_khen_thuong").Trim());
                        Treo_thiet_bi_khen_thuong_co_hay_khong_mo_ra = int.Parse(Config.smethod_4("HookConfiguration", "Treo_thiet_bi_khen_thuong_co_hay_khong_mo_ra").Trim());
                        Treo_thiet_bi_khen_thuong_gui_di_Thoi_gian_khoang_cach = int.Parse(Config.smethod_4("HookConfiguration", "Treo_thiet_bi_khen_thuong_gui_di_Thoi_gian_khoang_cach").Trim());
                        Treo_thiet_bi_khen_thuong_han_che_thap_nhat_Dang_cap = int.Parse(Config.smethod_4("HookConfiguration", "Treo_thiet_bi_khen_thuong_han_che_thap_nhat_Dang_cap").Trim());
                        Treo_thiet_bi_khen_thuong = Config.smethod_4("HookConfiguration", "Treo_thiet_bi_khen_thuong").Trim();
                        VIP_Treo_thiet_bi_khen_thuong = Config.smethod_4("HookConfiguration", "VIP_Treo_thiet_bi_khen_thuong").Trim();
                        Cach_tuyen_Treo_thiet_bi_menh_lenh = Config.smethod_4("HookConfiguration", "Cach_tuyen_Treo_thiet_bi_menh_lenh").Trim();
                        Co_hay_khong_bat_dau_dung_cach_tuyen_Treo_thiet_bi_nhac_nho = int.Parse(Config.smethod_4("HookConfiguration", "Co_hay_khong_bat_dau_dung_cach_tuyen_Treo_thiet_bi_nhac_nho").Trim());
                        Cach_Tuyen_Treo_thiet_bi_khen_thuong_co_hay_khong_mo_ra = int.Parse(Config.smethod_4("HookConfiguration", "Cach_Tuyen_Treo_thiet_bi_khen_thuong_co_hay_khong_mo_ra").Trim());
                        Cach_Tuyen_Treo_thiet_bi_khen_thuong_gui_di_Thoi_gian_khoang_cach = int.Parse(Config.smethod_4("HookConfiguration", "Cach_Tuyen_Treo_thiet_bi_khen_thuong_gui_di_Thoi_gian_khoang_cach").Trim());
                        Cach_Tuyen_Treo_thiet_bi_khen_thuong_han_che_thap_nhat_Dang_cap = int.Parse(Config.smethod_4("HookConfiguration", "Cach_Tuyen_Treo_thiet_bi_khen_thuong_han_che_thap_nhat_Dang_cap").Trim());
                        Cach_Tuyen_Treo_thiet_bi_khen_thuong = Config.smethod_4("HookConfiguration", "Cach_Tuyen_Treo_thiet_bi_khen_thuong").Trim();
                        Cach_Tuyen_VIP_Treo_thiet_bi_khen_thuong = Config.smethod_4("HookConfiguration", "Cach_Tuyen_VIP_Treo_thiet_bi_khen_thuong").Trim();
                        Cach_tuyen_Treo_thiet_bi_can_thiet_item_ID = Config.smethod_4("HookConfiguration", "Cach_tuyen_Treo_thiet_bi_can_thiet_item_ID").Trim();
                        Cach_tuyen_Treo_thiet_bi_Nhac_nho_noi_dung = Config.smethod_4("HookConfiguration", "Cach_tuyen_Treo_thiet_bi_Nhac_nho_noi_dung").Trim();
                        Co_hay_khong_mo_ra_cach_tuyen_Treo_thiet_bi = (Config.smethod_4("HookConfiguration", "Co_hay_khong_mo_ra_cach_tuyen_Treo_thiet_bi").Trim() == "") ? Co_hay_khong_mo_ra_cach_tuyen_Treo_thiet_bi : int.Parse(Config.smethod_4("HookConfiguration", "Co_hay_khong_mo_ra_cach_tuyen_Treo_thiet_bi").Trim());
                        Cach_tuyen_Treo_thiet_bi_ban_do = (Config.smethod_4("HookConfiguration", "Cach_tuyen_Treo_thiet_bi_ban_do").Trim() == "") ? Cach_tuyen_Treo_thiet_bi_ban_do : int.Parse(Config.smethod_4("HookConfiguration", "Cach_tuyen_Treo_thiet_bi_ban_do").Trim());
                        Cach_tuyen_Treo_thiet_Dang_cap = (Config.smethod_4("HookConfiguration", "Cach_tuyen_Treo_thiet_Dang_cap").Trim() == "") ? Cach_tuyen_Treo_thiet_Dang_cap : int.Parse(Config.smethod_4("HookConfiguration", "Cach_tuyen_Treo_thiet_Dang_cap").Trim());
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(100, "Profile hook configuration .ini configuration error, carefully review the update file:" + exception.Message);                        
                  }
            }

            public void SetConfigDB()
            {
                  DBClass class3 = new DBClass
                  {
                        ServerDb = "rxjhaccount",
                        SqlConnect = $"Data Source={Config.IniReadValue("rxjhaccount", "Server").Trim()};uid={Config.IniReadValue("rxjhaccount", "UserName").Trim()};pwd={Config.IniReadValue("rxjhaccount", "PassWord").Trim()};database={Config.IniReadValue("rxjhaccount", "DataName").Trim()};Packet Size=4096;Pooling=true;Max Pool Size=512;Min Pool Size=1"
                  };
                  DBClass class2 = class3;
                  dictionary_7.Add("rxjhaccount", class2);
                  class3 = new DBClass
                  {
                        ServerDb = "baibao",
                        SqlConnect = $"Data Source={Config.IniReadValue("baibao", "Server").Trim()};uid={Config.IniReadValue("baibao", "UserName").Trim()};pwd={Config.IniReadValue("baibao", "PassWord").Trim()};database={Config.IniReadValue("baibao", "DataName").Trim()};Packet Size=4096;Pooling=true;Max Pool Size=512;Min Pool Size=1"
                  };
                  class2 = class3;
                  dictionary_7.Add("baibao", class2);
                  class3 = new DBClass
                  {
                        ServerDb = "GameServer",
                        SqlConnect = $"Data Source={Config.IniReadValue("GameServer", "Server").Trim()};uid={Config.IniReadValue("GameServer", "UserName").Trim()};pwd={Config.IniReadValue("GameServer", "PassWord").Trim()};database={Config.IniReadValue("GameServer", "DataName").Trim()};Packet Size=4096;Pooling=true;Max Pool Size=512;Min Pool Size=1"
                  };
                  class2 = class3;
                  dictionary_7.Add("GameServer", class2);
                  class3 = new DBClass
                  {
                        ServerDb = "PublicDb",
                        SqlConnect = $"Data Source={Config.IniReadValue("PublicDb", "Server").Trim()};uid={Config.IniReadValue("PublicDb", "UserName").Trim()};pwd={Config.IniReadValue("PublicDb", "PassWord").Trim()};database={Config.IniReadValue("PublicDb", "DataName").Trim()};Packet Size=4096;Pooling=true;Max Pool Size=512;Min Pool Size=1"
                  };
                  class2 = class3;
                  dictionary_7.Add("PublicDb", class2);
                  if (Kiem_tra_phi_phap_Item == 2)
                  {
                        class3 = new DBClass
                        {
                              ServerDb = "WebDb",
                              SqlConnect = $"Data Source={Config.IniReadValue("WebDb", "Server").Trim()};uid={Config.IniReadValue("WebDb", "UserName").Trim()};pwd={Config.IniReadValue("WebDb", "PassWord").Trim()};database={Config.IniReadValue("WebDb", "DataName").Trim()};Packet Size=4096;Pooling=true;Max Pool Size=512;Min Pool Size=1"
                        };
                        class2 = class3;
                        dictionary_7.Add("WebDb", class2);
                  }
            }

            public void SetDrop()
            {
                  try
                  {
                        DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT * FROM TBL_XWWL_DROP ORDER BY FLD_LEVEL1, FLD_LEVEL2", new object[0]), "PublicDb");
                        if (dBToDataTable != null)
                        {
                              if (dBToDataTable.Rows.Count == 0)
                              {
                                    Form1.WriteLine(1, "Note: Drop table has been left empty");
                              }
                              else
                              {
                                    list_8.Clear();
                                    int num = 0;
                                    while (true)
                                    {
                                          if (num >= dBToDataTable.Rows.Count)
                                          {
                                                break;
                                          }
                                          TBL_XWWL_DROP item = new TBL_XWWL_DROP();
                                          try
                                          {
                                                item.FLD_LEVEL1 = (int)dBToDataTable.Rows[num]["FLD_LEVEL1"];
                                                item.FLD_LEVEL2 = (int)dBToDataTable.Rows[num]["FLD_LEVEL2"];
                                                item.FLD_PID = (int)dBToDataTable.Rows[num]["FLD_PID"];
                                                item.FLD_PP = (int)dBToDataTable.Rows[num]["FLD_PP"];
                                                item.FLD_NAME = dBToDataTable.Rows[num]["FLD_NAME"].ToString();
                                                item.FLD_MAGIC0 = (int)dBToDataTable.Rows[num]["FLD_MAGIC0"];
                                                item.FLD_MAGIC1 = (int)dBToDataTable.Rows[num]["FLD_MAGIC1"];
                                                item.FLD_MAGIC2 = (int)dBToDataTable.Rows[num]["FLD_MAGIC2"];
                                                item.FLD_MAGIC3 = (int)dBToDataTable.Rows[num]["FLD_MAGIC3"];
                                                item.FLD_MAGIC4 = (int)dBToDataTable.Rows[num]["FLD_MAGIC4"];
                                                item.int_4 = (int)dBToDataTable.Rows[num]["FLD_MAGIC0"];
                                                item.int_5 = (int)dBToDataTable.Rows[num]["FLD_MAGIC1"];
                                                item.int_6 = (int)dBToDataTable.Rows[num]["FLD_MAGIC2"];
                                                item.int_7 = (int)dBToDataTable.Rows[num]["FLD_MAGIC3"];
                                                item.int_8 = (int)dBToDataTable.Rows[num]["FLD_MAGIC4"];
                                                item.CO_HAY_KHONG_MO_RA_THONG_BAO = (int)dBToDataTable.Rows[num]["CO_HAY_KHONG_MO_RA_THONG_BAO"];
                                                try
                                                {
                                                      if ((dBToDataTable.Rows[0]["FLD_SUNX"] != DBNull.Value) && (dBToDataTable.Rows[num]["FLD_SUNX"].ToString() != ""))
                                                      {
                                                            string str = dBToDataTable.Rows[num]["FLD_SUNX"].ToString();
                                                            item.list_0 = JsonConvert.DeserializeObject<List<Class95>>(str);
                                                      }
                                                }
                                                catch
                                                {
                                                }
                                                list_8.Add(item);
                                          }
                                          catch (Exception exception)
                                          {
                                                Form1.WriteLine(1, "Load drop items Error" + item.FLD_NAME + "  " + exception.Message);
                                          }
                                          num++;
                                    }
                                    Form1.WriteLine(2, "Loaded drops: " + dBToDataTable.Rows.Count);
                              }
                              dBToDataTable.Dispose();
                        }
                  }
                  catch (Exception exception2)
                  {
                        Form1.WriteLine(1, "Drop table error: " + exception2.Message);
                  }
            }

            public void SetItemShop()
            {
                  DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT * FROM ITEMSELL", new object[0]), "baibao");
                  if (dBToDataTable != null)
                  {
                        if (dBToDataTable.Rows.Count == 0)
                        {
                              Form1.WriteLine(1, "Note: BBG/Webshop has been left empty");
                        }
                        else
                        {
                              dictionary_0.Clear();
                              for (int i = 0; i < dBToDataTable.Rows.Count; i++)
                              {
                                    ITEMSELL itemsell = new ITEMSELL
                                    {
                                          FLD_PID = (int)dBToDataTable.Rows[i]["FLD_PID"],
                                          FLD_NAME = dBToDataTable.Rows[i]["FLD_NAME"].ToString(),
                                          FLD_PRICE = long.Parse(dBToDataTable.Rows[i]["FLD_PRICE"].ToString()),
                                          FLD_DESC = dBToDataTable.Rows[i]["FLD_DESC"].ToString(),
                                          FLD_TYPE = (int)dBToDataTable.Rows[i]["FLD_TYPE"],
                                          FLD_RETURN = (int)dBToDataTable.Rows[i]["FLD_RETURN"],
                                          FLD_NUMBER = (int)dBToDataTable.Rows[i]["FLD_NUMBER"],
                                          FLD_MAGIC1 = (int)dBToDataTable.Rows[i]["FLD_MAGIC1"],
                                          FLD_MAGIC2 = (int)dBToDataTable.Rows[i]["FLD_MAGIC2"],
                                          FLD_MAGIC3 = (int)dBToDataTable.Rows[i]["FLD_MAGIC3"],
                                          FLD_MAGIC4 = (int)dBToDataTable.Rows[i]["FLD_MAGIC4"],
                                          FLD_MAGIC5 = (int)dBToDataTable.Rows[i]["FLD_MAGIC5"],
                                          FLD_SO_CAP_PHU_HON = (int)dBToDataTable.Rows[i]["FLD_SO_CAP_PHU_HON"],
                                          FLD_TRUNG_CAP_PHU_HON = (int)dBToDataTable.Rows[i]["FLD_TRUNG_CAP_PHU_HON"],
                                          FLD_TIEN_HOA = (int)dBToDataTable.Rows[i]["FLD_TIEN_HOA"],
                                          FLD_CO_HAY_KHONG_TROI_CHAT = (int)dBToDataTable.Rows[i]["FLD_CO_HAY_KHONG_TROI_CHAT"],
                                          FLD_DAYS = (int)dBToDataTable.Rows[i]["FLD_DAYS"]
                                    };
                                    dictionary_0.Add(itemsell.FLD_PID, itemsell);
                              }
                              Form1.WriteLine(2, "Loaded web shop items: " + dBToDataTable.Rows.Count);
                        }
                        dBToDataTable.Dispose();
                  }
            }

            public void SetItme()
            {
                  DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT * FROM TBL_XWWL_ITEM", new object[0]), "PublicDb");
                  if (dBToDataTable != null)
                  {
                        if (dBToDataTable.Rows.Count == 0)
                        {
                              Form1.WriteLine(1, "Note: Item table has been left empty");
                        }
                        else
                        {
                              Itme.Clear();
                              for (int i = 0; i < dBToDataTable.Rows.Count; i++)
                              {
                                    TBL_XWWL_ITEM tbl_xwwl_item = new TBL_XWWL_ITEM
                                    {
                                          FLD_AT = long.Parse(dBToDataTable.Rows[i]["FLD_AT1"].ToString()),
                                          FLD_AT_Max = long.Parse(dBToDataTable.Rows[i]["FLD_AT2"].ToString()),
                                          FLD_DF = long.Parse(dBToDataTable.Rows[i]["FLD_DF"].ToString()),
                                          FLD_RESIDE1 = (int)dBToDataTable.Rows[i]["FLD_RESIDE1"],
                                          FLD_RESIDE2 = (int)dBToDataTable.Rows[i]["FLD_RESIDE2"],
                                          FLD_JOB_LEVEL = (int)dBToDataTable.Rows[i]["FLD_JOB_LEVEL"],
                                          FLD_LEVEL = (int)dBToDataTable.Rows[i]["FLD_LEVEL"],
                                          FLD_MONEY = (int)dBToDataTable.Rows[i]["FLD_MONEY"],
                                          FLD_PID = int.Parse(dBToDataTable.Rows[i]["FLD_PID"].ToString()),
                                          FLD_SEX = (int)dBToDataTable.Rows[i]["FLD_SEX"],
                                          FLD_WEIGHT = (int)dBToDataTable.Rows[i]["FLD_WEIGHT"],
                                          FLD_ZX = (int)dBToDataTable.Rows[i]["FLD_ZX"],
                                          FLD_SIDE = (int)dBToDataTable.Rows[i]["FLD_SIDE"],
                                          FLD_MAGIC0 = (int)dBToDataTable.Rows[i]["FLD_MAGIC1"],
                                          FLD_MAGIC1 = (int)dBToDataTable.Rows[i]["FLD_MAGIC2"],
                                          FLD_MAGIC2 = (int)dBToDataTable.Rows[i]["FLD_MAGIC3"],
                                          FLD_MAGIC3 = (int)dBToDataTable.Rows[i]["FLD_MAGIC4"],
                                          FLD_MAGIC4 = (int)dBToDataTable.Rows[i]["FLD_MAGIC5"],
                                          FLD_XW = (int)dBToDataTable.Rows[i]["FLD_WX"],
                                          FLD_XWJD = (int)dBToDataTable.Rows[i]["FLD_WXJD"],
                                          FLD_TYPE = (int)dBToDataTable.Rows[i]["FLD_TYPE"],
                                          FLD_QUESTITEM = (int)dBToDataTable.Rows[i]["FLD_QUESTITEM"],
                                          FLD_CJL = (int)dBToDataTable.Rows[i]["FLD_CJL"],
                                          ItmeNAME = dBToDataTable.Rows[i]["FLD_NAME"].ToString(),
                                          MA_SO_MUA_ITME = dBToDataTable.Rows[i]["TEN_VAT_PHAM"].ToString(),
                                          GIA_MUA = (int)dBToDataTable.Rows[i]["GIA_MUA"],
                                          SO_VAT_PHAM = (int)dBToDataTable.Rows[i]["SO_VAT_PHAM"]
                                    };
                                    Itme.Add(tbl_xwwl_item.FLD_PID, tbl_xwwl_item);
                              }
                              Form1.WriteLine(2, "Loaded Items:" + dBToDataTable.Rows.Count);
                        }
                        dBToDataTable.Dispose();
                  }
            }

            public void SetJl()
            {
                  DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT * FROM TBL_XWWL_Jl", new object[0]), "PublicDb");
                  if (dBToDataTable != null)
                  {
                        if (dBToDataTable.Rows.Count == 0)
                        {
                              Form1.WriteLine(1, "Note: Rewards table has been left empty");
                        }
                        else
                        {
                              list_9.Clear();
                              for (int i = 0; i < dBToDataTable.Rows.Count; i++)
                              {
                                    TBL_XWWL_DROP item = new TBL_XWWL_DROP
                                    {
                                          FLD_LEVEL1 = (int)dBToDataTable.Rows[i]["FLD_LEVEL1"],
                                          FLD_LEVEL2 = (int)dBToDataTable.Rows[i]["FLD_LEVEL2"],
                                          FLD_PID = (int)dBToDataTable.Rows[i]["FLD_PID"],
                                          FLD_PP = (int)dBToDataTable.Rows[i]["FLD_PP"],
                                          FLD_NAME = dBToDataTable.Rows[i]["FLD_NAME"].ToString(),
                                          FLD_MAGIC0 = (int)dBToDataTable.Rows[i]["FLD_MAGIC0"],
                                          FLD_MAGIC1 = (int)dBToDataTable.Rows[i]["FLD_MAGIC1"],
                                          FLD_MAGIC2 = (int)dBToDataTable.Rows[i]["FLD_MAGIC2"],
                                          FLD_MAGIC3 = (int)dBToDataTable.Rows[i]["FLD_MAGIC3"],
                                          FLD_MAGIC4 = (int)dBToDataTable.Rows[i]["FLD_MAGIC4"],
                                          int_4 = (int)dBToDataTable.Rows[i]["FLD_MAGIC0"],
                                          int_5 = (int)dBToDataTable.Rows[i]["FLD_MAGIC1"],
                                          int_6 = (int)dBToDataTable.Rows[i]["FLD_MAGIC2"],
                                          int_7 = (int)dBToDataTable.Rows[i]["FLD_MAGIC3"],
                                          int_8 = (int)dBToDataTable.Rows[i]["FLD_MAGIC4"]
                                    };
                                    list_9.Add(item);
                              }
                              Form1.WriteLine(2, "Loaded reward items: " + dBToDataTable.Rows.Count);
                        }
                        dBToDataTable.Dispose();
                  }
            }

            public void SetKONGFU()
            {
                  DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT * FROM TBL_XWWL_KONGFU", new object[0]), "PublicDb");
                  if (dBToDataTable != null)
                  {
                        if (dBToDataTable.Rows.Count == 0)
                        {
                              Form1.WriteLine(1, "Note: Skill table has been left empty");
                        }
                        else
                        {
                              TBL_KONGFU.Clear();
                              for (int i = 0; i < dBToDataTable.Rows.Count; i++)
                              {
                                    TBL_XWWL_KONGFU tbl_xwwl_kongfu = new TBL_XWWL_KONGFU
                                    {
                                          FLD_AT = (int)dBToDataTable.Rows[i]["FLD_AT"],
                                          FLD_EFFERT = (int)dBToDataTable.Rows[i]["FLD_EFFERT"],
                                          FLD_INDEX = (int)dBToDataTable.Rows[i]["FLD_INDEX"],
                                          FLD_JOB = (int)dBToDataTable.Rows[i]["FLD_JOB"],
                                          FLD_JOBLEVEL = (int)dBToDataTable.Rows[i]["FLD_JOBLEVEL"],
                                          FLD_LEVEL = (int)dBToDataTable.Rows[i]["FLD_LEVEL"],
                                          FLD_MP = (int)dBToDataTable.Rows[i]["FLD_MP"],
                                          FLD_NEEDEXP = (int)dBToDataTable.Rows[i]["FLD_NEEDEXP"],
                                          FLD_PID = (int)dBToDataTable.Rows[i]["FLD_PID"],
                                          FLD_TYPE = (int)dBToDataTable.Rows[i]["FLD_TYPE"],
                                          FLD_ZX = (int)dBToDataTable.Rows[i]["FLD_ZX"],
                                          FLD_CONG_KICH_SO_LUONG = (int)dBToDataTable.Rows[i]["FLD_CONG_KICH_SO_LUONG"],
                                          FLD_VO_CONG_LOAI_HINH = (int)dBToDataTable.Rows[i]["FLD_VO_CONG_LOAI_HINH"],
                                          FLD_MOI_CAP_THEM_MP = (int)dBToDataTable.Rows[i]["FLD_MOI_CAP_THEM_MP"],
                                          FLD_CDTIME = (int)dBToDataTable.Rows[i]["FLD_CDTIME"],
                                          FLD_MOI_CAP_THEM_KINH_NGHIEM = (int)dBToDataTable.Rows[i]["FLD_MOI_CAP_THEM_KINH_NGHIEM"],
                                          FLD_MOI_CAP_THEM_NGUY_HAI = (int)dBToDataTable.Rows[i]["FLD_MOI_CAP_THEM_NGUY_HAI"],
                                          FLD_MOI_CAP_VO_CONG_DIEM_SO = (int)dBToDataTable.Rows[i]["FLD_MOI_CAP_VO_CONG_DIEM_SO"],
                                          FLD_TIME = (int)dBToDataTable.Rows[i]["FLD_TIME"],
                                          FLD_VO_CONG_CAO_NHAT_DANG_CAP = (int)dBToDataTable.Rows[i]["FLD_VO_CONG_CAO_NHAT_DANG_CAP"],
                                          FLD_MOI_CAP_THEM_DANG_CAP = (int)dBToDataTable.Rows[i]["FLD_MOI_CAP_THEM_DANG_CAP"],
                                          FLD_CDSKILL = DateTime.Parse(dBToDataTable.Rows[0]["FLD_CDSKILL"].ToString())
                                    };
                                    TBL_KONGFU.Add(tbl_xwwl_kongfu.FLD_PID, tbl_xwwl_kongfu);
                              }
                              Form1.WriteLine(2, "Loading data Complete martial arts: " + dBToDataTable.Rows.Count);
                        }
                        dBToDataTable.Dispose();
                  }
            }
            public void SetLever()
            {
                  lever.Clear();
                  for (int i = 0; i < 0x100; i++)
                  {
                        if (i == 0)
                        {
                              lever.Add(0, 100.0);
                        }
                        else if (i <= 20)
                        {
                              lever.Add(i, lever[i - 1] * 1.3);
                        }
                        else if ((i > 20) && (i <= 40))
                        {
                              lever.Add(i, lever[i - 1] * 1.2);
                        }
                        else if ((i > 40) && (i <= 80))
                        {
                              lever.Add(i, lever[i - 1] * 1.17);
                        }
                        else if (i > 80)
                        {
                              lever.Add(i, lever[i - 1] * 1.1);
                        }
                  }
                  Form1.WriteLine(2, "Experience table has been loaded successfully.");
            }

            public void SetMAP()
            {
                  DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT * FROM TBL_XWWL_MAP WHERE (X IS NOT NULL)", new object[0]), "PublicDb");
                  if (dBToDataTable != null)
                  {
                        if (dBToDataTable.Rows.Count == 0)
                        {
                              Form1.WriteLine(1, "Load custom mobile error----No mobile data");
                        }
                        else
                        {
                              list_15.Clear();
                              for (int i = 0; i < dBToDataTable.Rows.Count; i++)
                              {
                                    TBL_XWWL_MAP item = new TBL_XWWL_MAP
                                    {
                                          Rxjh_name = dBToDataTable.Rows[i]["FLD_NAME"].ToString(),
                                          Rxjh_Map = (int)dBToDataTable.Rows[i]["FLD_MID"],
                                          Rxjh_X = float.Parse(dBToDataTable.Rows[i]["X"].ToString()),
                                          Rxjh_Y = float.Parse(dBToDataTable.Rows[i]["Y"].ToString()),
                                          Rxjh_Z = 15f,
                                          Rxjh_LEVEL = (int)dBToDataTable.Rows[i]["FLD_LEVEL"]
                                    };
                                    list_15.Add(item);
                              }
                              Form1.WriteLine(2, "Load Custom mobile data Complete: " + dBToDataTable.Rows.Count);
                        }
                        dBToDataTable.Dispose();
                  }
            }

            public void SetMonSter()
            {
                  DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT * FROM TBL_XWWL_MONSTER", new object[0]), "PublicDb");
                  if (dBToDataTable != null)
                  {
                        if (dBToDataTable.Rows.Count == 0)
                        {
                              Form1.WriteLine(1, "Note: Monster data has been left empty");
                        }
                        else
                        {
                              dictionary_13.Clear();
                              int num = 0;
                              while (true)
                              {
                                    if (num >= dBToDataTable.Rows.Count)
                                    {
                                          break;
                                    }
                                    try
                                    {
                                          TBL_XWWL_MONSTER tbl_xwwl_monster = new TBL_XWWL_MONSTER
                                          {
                                                FLD_PID = (int)dBToDataTable.Rows[num]["FLD_PID"],
                                                FLD_AT = (int)dBToDataTable.Rows[num]["FLD_AT"],
                                                FLD_AUTO = (int)dBToDataTable.Rows[num]["FLD_AUTO"],
                                                FLD_BOSS = (int)dBToDataTable.Rows[num]["FLD_BOSS"],
                                                FLD_DF = (int)dBToDataTable.Rows[num]["FLD_DF"],
                                                Level = (int)dBToDataTable.Rows[num]["FLD_LEVEL"],
                                                Name = dBToDataTable.Rows[num]["FLD_NAME"].ToString(),
                                                Rxjh_Exp = (int)dBToDataTable.Rows[num]["FLD_EXP"],
                                                Rxjh_HP = (int)dBToDataTable.Rows[num]["FLD_HP"]
                                          };
                                          dictionary_13.Add(tbl_xwwl_monster.FLD_PID, tbl_xwwl_monster);
                                    }
                                    catch (Exception exception)
                                    {
                                          Form1.WriteLine(1, "Monster load dataError " + exception);
                                    }
                                    num++;
                              }
                              Form1.WriteLine(2, "Loaded monsters: " + dBToDataTable.Rows.Count);
                        }
                        dBToDataTable.Dispose();
                  }
            }

            public void SetMover()
            {
                  DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT * FROM TBL_XWWL_VOME", new object[0]), "PublicDb");
                  if (dBToDataTable != null)
                  {
                        if (dBToDataTable.Rows.Count == 0)
                        {
                              Form1.WriteLine(1, "Note: Map transfering has been left empty.");
                        }
                        else
                        {
                              list_13.Clear();
                              for (int i = 0; i < dBToDataTable.Rows.Count; i++)
                              {
                                    TBL_XWWL_VOME item = new TBL_XWWL_VOME
                                    {
                                          MAP = (int)dBToDataTable.Rows[i]["MAP"],
                                          X = float.Parse(dBToDataTable.Rows[i]["X"].ToString()),
                                          Y = float.Parse(dBToDataTable.Rows[i]["Y"].ToString()),
                                          Z = float.Parse(dBToDataTable.Rows[i]["Z"].ToString()),
                                          ToMAP = (int)dBToDataTable.Rows[i]["ToMAP"],
                                          ToX = float.Parse(dBToDataTable.Rows[i]["ToX"].ToString()),
                                          ToY = float.Parse(dBToDataTable.Rows[i]["ToY"].ToString()),
                                          ToZ = float.Parse(dBToDataTable.Rows[i]["ToZ"].ToString())
                                    };
                                    list_13.Add(item);
                              }
                              Form1.WriteLine(2, "Mobile data loading Complete: " + dBToDataTable.Rows.Count);
                        }
                        dBToDataTable.Dispose();
                  }
            }

            public void SetNpc()
            {
                  DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT * FROM TBL_XWWL_NPC", new object[0]), "PublicDb");
                  if (dBToDataTable != null)
                  {
                        if (dBToDataTable.Rows.Count == 0)
                        {
                              Form1.WriteLine(1, "Note: NPC Spawn table seems to be empty");
                        }
                        else
                        {
                              dictionary_12.Clear();
                              int num = 0;
                              while (true)
                              {
                                    if (num >= dBToDataTable.Rows.Count)
                                    {
                                          break;
                                    }
                                    try
                                    {
                                          MapClass class2;
                                          TBL_XWWL_NPC tbl_xwwl_npc = new TBL_XWWL_NPC
                                          {
                                                FLD_PID = (int)dBToDataTable.Rows[num]["FLD_PID"],
                                                Name = dBToDataTable.Rows[num]["FLD_NAME"].ToString(),
                                                Level = (int)dBToDataTable.Rows[num]["FLD_LEVEL"],
                                                Rxjh_Exp = (int)dBToDataTable.Rows[num]["FLD_EXP"],
                                                Rxjh_X = float.Parse(dBToDataTable.Rows[num]["FLD_X"].ToString()),
                                                Rxjh_Y = float.Parse(dBToDataTable.Rows[num]["FLD_Y"].ToString()),
                                                Rxjh_Z = float.Parse(dBToDataTable.Rows[num]["FLD_Z"].ToString()),
                                                Rxjh_cs_X = float.Parse(dBToDataTable.Rows[num]["FLD_X"].ToString()),
                                                Rxjh_cs_Y = float.Parse(dBToDataTable.Rows[num]["FLD_Y"].ToString()),
                                                Rxjh_cs_Z = float.Parse(dBToDataTable.Rows[num]["FLD_Z"].ToString()),
                                                IsNpc = (int)dBToDataTable.Rows[num]["FLD_NPC"],
                                                FLD_FACE1 = float.Parse(dBToDataTable.Rows[num]["FLD_FACE0"].ToString()),
                                                FLD_FACE2 = float.Parse(dBToDataTable.Rows[num]["FLD_FACE"].ToString()),
                                                Rxjh_Map = (int)dBToDataTable.Rows[num]["FLD_MID"],
                                                Max_Rxjh_HP = (int)dBToDataTable.Rows[num]["FLD_HP"],
                                                Rxjh_HP = (int)dBToDataTable.Rows[num]["FLD_HP"],
                                                FLD_AT = (int)dBToDataTable.Rows[num]["FLD_AT"],
                                                FLD_DF = (int)dBToDataTable.Rows[num]["FLD_DF"],
                                                FLD_AUTO = (int)dBToDataTable.Rows[num]["FLD_AUTO"],
                                                FLD_BOSS = (int)dBToDataTable.Rows[num]["FLD_BOSS"],
                                                FLD_NEWTIME = (int)dBToDataTable.Rows[num]["FLD_NEWTIME"]
                                          };
                                          if (dictionary_12.TryGetValue(tbl_xwwl_npc.Rxjh_Map, out class2))
                                          {
                                                class2.method_1(tbl_xwwl_npc);
                                          }
                                          else
                                          {
                                                class2 = new MapClass
                                                {
                                                      MapID = tbl_xwwl_npc.Rxjh_Map
                                                };
                                                class2.method_1(tbl_xwwl_npc);
                                                dictionary_12.Add(class2.MapID, class2);
                                          }
                                    }
                                    catch (Exception exception)
                                    {
                                          Form1.WriteLine(1, "NPC loading data error：" + exception);
                                    }
                                    num++;
                              }
                              Form1.WriteLine(2, "Loaded NPCs: " + dBToDataTable.Rows.Count);
                        }
                        dBToDataTable.Dispose();
                  }
            }

            public void SetNPC_Sell()
            {
                  DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT * FROM TBL_XWWL_SELL ORDER BY FLD_INDEX", new object[0]), "PublicDb");
                  if (dBToDataTable != null)
                  {
                        if (dBToDataTable.Rows.Count == 0)
                        {
                              Form1.WriteLine(1, "Note: NPC Sell table is empty");
                        }
                        else
                        {
                              list_4.Clear();
                              for (int i = 0; i < dBToDataTable.Rows.Count; i++)
                              {
                                    TBL_XWWL_SELL item = new TBL_XWWL_SELL
                                    {
                                          FLD_NID = int.Parse(dBToDataTable.Rows[i]["FLD_NID"].ToString()),
                                          FLD_INDEX = (int)dBToDataTable.Rows[i]["FLD_INDEX"],
                                          FLD_PID = int.Parse(dBToDataTable.Rows[i]["FLD_PID"].ToString()),
                                          FLD_MAGIC0 = (int)dBToDataTable.Rows[i]["FLD_MAGIC0"],
                                          FLD_MAGIC1 = (int)dBToDataTable.Rows[i]["FLD_MAGIC1"],
                                          FLD_MAGIC2 = (int)dBToDataTable.Rows[i]["FLD_MAGIC2"],
                                          FLD_MAGIC3 = (int)dBToDataTable.Rows[i]["FLD_MAGIC3"],
                                          FLD_MAGIC4 = (int)dBToDataTable.Rows[i]["FLD_MAGIC4"],
                                          FLD_CJL = (int)dBToDataTable.Rows[i]["FLD_CJL"],
                                          CAN_VO_HUAN = (int)dBToDataTable.Rows[i]["CAN_VO_HUAN"]
                                    };
                                    list_4.Add(item);
                              }
                              Form1.WriteLine(2, "Loaded NPC Shop items: " + dBToDataTable.Rows.Count);
                        }
                        dBToDataTable.Dispose();
                  }
            }

            public void SetNpcDrop()
            {
                  DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT * FROM TBL_XWWL_NPC_DROP", new object[0]), "PublicDb");
                  if (dBToDataTable != null)
                  {
                        if (dBToDataTable.Rows.Count == 0)
                        {
                              Form1.WriteLine(1, "Note: NPC Drop table seems to be empty");
                        }
                        else
                        {
                              list_7.Clear();
                              for (int i = 0; i < dBToDataTable.Rows.Count; i++)
                              {
                                    TBL_XWWL_NPC_DROP item = new TBL_XWWL_NPC_DROP
                                    {
                                          FLD_LEVEL1 = (int)dBToDataTable.Rows[i]["FLD_LEVEL1"],
                                          FLD_LEVEL2 = (int)dBToDataTable.Rows[i]["FLD_LEVEL2"],
                                          FLD_NPC_PID = (int)dBToDataTable.Rows[i]["FLD_NPC_PID"],
                                          FLD_ITME_PID = (int)dBToDataTable.Rows[i]["FLD_ITME_PID"],
                                          FLD_NAME = dBToDataTable.Rows[i]["FLD_NAME"].ToString(),
                                          FLD_MAGIC0 = (int)dBToDataTable.Rows[i]["FLD_MAGIC0"],
                                          FLD_MAGIC1 = (int)dBToDataTable.Rows[i]["FLD_MAGIC1"],
                                          FLD_MAGIC2 = (int)dBToDataTable.Rows[i]["FLD_MAGIC2"],
                                          FLD_MAGIC3 = (int)dBToDataTable.Rows[i]["FLD_MAGIC3"],
                                          FLD_MAGIC4 = (int)dBToDataTable.Rows[i]["FLD_MAGIC4"]
                                    };
                                    list_7.Add(item);
                              }
                              Form1.WriteLine(2, "Loaded NPC Drops: " + dBToDataTable.Rows.Count);
                        }
                        dBToDataTable.Dispose();
                  }
            }

            public void SetOpen()
            {
                  DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT * FROM TBL_XWWL_OPEN", new object[0]), "PublicDb");
                  if (dBToDataTable != null)
                  {
                        if (dBToDataTable.Rows.Count == 0)
                        {
                              Form1.WriteLine(1, "Note: Chest/Box openings table has been left empty");
                        }
                        else
                        {
                              list_12.Clear();
                              for (int i = 0; i < dBToDataTable.Rows.Count; i++)
                              {
                                    TBL_XWWL_OPEN item = new TBL_XWWL_OPEN
                                    {
                                          FLD_PID = (int)dBToDataTable.Rows[i]["FLD_PID"],
                                          FLD_PIDX = (int)dBToDataTable.Rows[i]["FLD_PIDX"],
                                          FLD_NUMBER = (int)dBToDataTable.Rows[i]["FLD_NUMBER"],
                                          FLD_PP = (int)dBToDataTable.Rows[i]["FLD_PP"],
                                          FLD_NAME = dBToDataTable.Rows[i]["FLD_NAME"].ToString(),
                                          FLD_NAMEX = dBToDataTable.Rows[i]["FLD_NAMEX"].ToString(),
                                          FLD_MAGIC0 = (int)dBToDataTable.Rows[i]["FLD_MAGIC1"],
                                          FLD_MAGIC1 = (int)dBToDataTable.Rows[i]["FLD_MAGIC2"],
                                          FLD_MAGIC2 = (int)dBToDataTable.Rows[i]["FLD_MAGIC3"],
                                          FLD_MAGIC3 = (int)dBToDataTable.Rows[i]["FLD_MAGIC4"],
                                          FLD_MAGIC4 = (int)dBToDataTable.Rows[i]["FLD_MAGIC5"],
                                          FLD_SO_CAP_PHU_HON = (int)dBToDataTable.Rows[i]["FLD_SO_CAP_PHU_HON"],
                                          FLD_TRUNG_CAP_PHU_HON = (int)dBToDataTable.Rows[i]["FLD_TRUNG_CAP_PHU_HON"],
                                          FLD_TIEN_HOA = (int)dBToDataTable.Rows[i]["FLD_TIEN_HOA"],
                                          FLD_CO_HAY_KHONG_TROI_CHAT = (int)dBToDataTable.Rows[i]["FLD_CO_HAY_KHONG_TROI_CHAT"],
                                          SU_DUNG_THANG_THIEN = (int)dBToDataTable.Rows[i]["SU_DUNG_THANG_THIEN"],
                                          CO_HAY_KHONG_MO_RA_THONG_BAO = (int)dBToDataTable.Rows[i]["CO_HAY_KHONG_MO_RA_THONG_BAO"]
                                    };
                                    list_12.Add(item);
                              }
                              Form1.WriteLine(2, "Loaded chest/box opening items: " + dBToDataTable.Rows.Count);
                        }
                        dBToDataTable.Dispose();
                  }
            }

            public void SetScript()
            {
                  scriptClass_0 = new ScriptClass();
            }

            public void SetTZ()
            {
                  DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT * FROM TRANG_PHUC_THUOC_TINH", new object[0]), "PublicDb");
                  if (dBToDataTable != null)
                  {
                        if (dBToDataTable.Rows.Count == 0)
                        {
                              Form1.WriteLine(1, "Error loading package----Set no data");
                        }
                        else
                        {
                              list_1.Clear();
                              for (int i = 0; i < dBToDataTable.Rows.Count; i++)
                              {
                                    TRANG_PHUC_THUOC_TINH item = new TRANG_PHUC_THUOC_TINH
                                    {
                                          Gia_ca = (int)dBToDataTable.Rows[i]["Gia_ca"],
                                          Dang_cap = (int)dBToDataTable.Rows[i]["Dang_cap"],
                                          Loai_hinh = (int)dBToDataTable.Rows[i]["Loai_hinh"],
                                          magic0 = (int)dBToDataTable.Rows[i]["FLD_MAGIC0"],
                                          magic1 = (int)dBToDataTable.Rows[i]["FLD_MAGIC1"],
                                          magic2 = (int)dBToDataTable.Rows[i]["FLD_MAGIC2"],
                                          magic3 = (int)dBToDataTable.Rows[i]["FLD_MAGIC3"],
                                          magic4 = (int)dBToDataTable.Rows[i]["FLD_MAGIC4"],
                                          FLD_Trung_cap_hon = (int)dBToDataTable.Rows[i]["FLD_Trung_cap_hon"],
                                          FLD_Thuc_tinh = (int)dBToDataTable.Rows[i]["FLD_Thuc_tinh"],
                                          FLD_Tien_hoa = (int)dBToDataTable.Rows[i]["FLD_Tien_hoa"],
                                          FLD_Troi_chat = (int)dBToDataTable.Rows[i]["FLD_Troi_chat"]
                                    };
                                    list_1.Add(item);
                              }
                              Form1.WriteLine(2, "Load package Complete: " + dBToDataTable.Rows.Count);
                        }
                        dBToDataTable.Dispose();
                  }
            }

            public void SetTZlist()
            {
                  DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT * FROM TRANG_PHUC_DANH_SACH", new object[0]), "PublicDb");
                  if (dBToDataTable != null)
                  {
                        if (dBToDataTable.Rows.Count == 0)
                        {
                              Form1.WriteLine(1, "Error loading package list ---- package No dat");
                        }
                        else
                        {
                              dictionary_26.Clear();
                              for (int i = 0; i < dBToDataTable.Rows.Count; i++)
                              {
                                    TRANG_PHUC_DANH_SACH trang_phuc_danh_sach = new TRANG_PHUC_DANH_SACH
                                    {
                                          PID = (int)dBToDataTable.Rows[i]["PID"],
                                          GIA_CA = (int)dBToDataTable.Rows[i]["GIA_CA"],
                                          NU_AO_CHOANG_KIEU_DANG = (int)dBToDataTable.Rows[i]["NU_AO_CHOANG_KIEU_DANG"],
                                          NAM_AO_CHOANG_KIEU_DANG = (int)dBToDataTable.Rows[i]["NAM_AO_CHOANG_KIEU_DANG"],
                                          TANG_CUONG_DANG_CAP = (int)dBToDataTable.Rows[i]["TANG_CUONG_DANG_CAP"],
                                          TANG_CUONG_CONG_KICH = (int)dBToDataTable.Rows[i]["TANG_CUONG_CONG_KICH"],
                                          TANG_CUONG_PHONG_NGU = (int)dBToDataTable.Rows[i]["TANG_CUONG_PHONG_NGU"],
                                          TANG_CUONG_SINH_MENH = (int)dBToDataTable.Rows[i]["TANG_CUONG_SINH_MENH"],
                                          TANG_CUONG_PHEP_THUAT = (int)dBToDataTable.Rows[i]["TANG_CUONG_PHEP_THUAT"],
                                          TANG_CUONG_VO_HUAN = (int)dBToDataTable.Rows[i]["TANG_CUONG_VO_HUAN"],
                                          BIEU_TANG_CASH = (int)dBToDataTable.Rows[i]["BIEU_TANG_CASH"],
                                          THANH_VIEN_THOI_GIAN = (int)dBToDataTable.Rows[i]["THANH_VIEN_THOI_GIAN"],
                                          THANH_VIEN_THU_BAC = (int)dBToDataTable.Rows[i]["THANH_VIEN_THU_BAC"],
                                          CO_HAY_KHONG_THONG_CAO = (int)dBToDataTable.Rows[i]["CO_HAY_KHONG_THONG_CAO"],
                                          THONG_BAO_NOI_DUNG = dBToDataTable.Rows[i]["THONG_BAO_NOI_DUNG"].ToString()
                                    };
                                    dictionary_26.Add((int)dBToDataTable.Rows[i]["PID"], trang_phuc_danh_sach);
                              }
                              Form1.WriteLine(2, "Package list data loading Complete: " + dBToDataTable.Rows.Count);
                        }
                        dBToDataTable.Dispose();
                  }
            }

            public void SetWxLever()
            {
                  dictionary_9.Clear();
                  dictionary_9.Add(0, 0.0);
                  dictionary_9.Add(1, 1000.0);
                  dictionary_9.Add(2, 15000.0);
                  dictionary_9.Add(3, 50000.0);
                  dictionary_9.Add(4, 100000.0);
                  dictionary_9.Add(5, 599999.0);
                  dictionary_9.Add(6, 1199999.0);
                  dictionary_9.Add(7, 1200000.0);
                  dictionary_9.Add(8, 1500000.0);
                  Form1.WriteLine(2, "Loaded honor system levels");
            }

            public static Players smethod_0(string string_218)
            {
                  foreach (Players players in allConnectedChars.Values)
                  {
                        if (players.Userid == string_218)
                        {
                              return players;
                        }
                  }
                  return null;
            }

            public static Players smethod_1(int int_229)
            {
                  Players players;
                  if (allConnectedChars.TryGetValue(int_229, out players))
                  {
                        return players;
                  }
                  return null;
            }

            public static int smethod_10(TO_DOI_LOAI class75_0)
            {
                  int_40++;
                  dictionary_24.Add(int_40, class75_0);
                  return int_40;
            }

            private static void smethod_11()
            {
            }

            public static ITEMSELL smethod_12(int int_229)
            {
                  foreach (ITEMSELL itemsell in dictionary_0.Values)
                  {
                        if (itemsell.FLD_PID == int_229)
                        {
                              return itemsell;
                        }
                  }
                  return null;
            }

            public static bool smethod_13()
            {
                  using (SqlConnection connection = new SqlConnection(DBA.smethod_3("rxjhaccount")))
                  {
                        try
                        {
                              connection.Open();
                        }
                        catch
                        {
                              Form1.WriteLine(1, "数据库rxjhaccount配置错误，无法连接");
                              return false;
                        }
                        finally
                        {
                              connection.Close();
                        }
                  }
                  using (SqlConnection connection2 = new SqlConnection(DBA.smethod_3("baibao")))
                  {
                        try
                        {
                              connection2.Open();
                        }
                        catch
                        {
                              Form1.WriteLine(1, "数据库bbg配置错误，无法连接");
                              return false;
                        }
                        finally
                        {
                              connection2.Close();
                        }
                  }
                  using (SqlConnection connection3 = new SqlConnection(DBA.smethod_3("GameServer")))
                  {
                        try
                        {
                              connection3.Open();
                        }
                        catch
                        {
                              Form1.WriteLine(1, "数据库rxjhgame配置错误，无法连接");
                              return false;
                        }
                        finally
                        {
                              connection3.Close();
                        }
                  }
                  using (SqlConnection connection4 = new SqlConnection(DBA.smethod_3("PublicDb")))
                  {
                        try
                        {
                              connection4.Open();
                        }
                        catch
                        {
                              Form1.WriteLine(1, "数据库PublicDb配置错误，无法连接");
                              return false;
                        }
                        finally
                        {
                              connection4.Close();
                        }
                  }
                  return true;
            }

            public static int smethod_14(int int_229)
            {
                  if (int_229 <= 0x2faf080d)
                  {
                        switch (int_229)
                        {
                              case 0x2faf080b:
                              case 0x2faf0801:
                                    return 0x2faf0801;

                              case 0x2faf080c:
                              case 0x2faf0802:
                                    return 0x2faf0802;

                              case 0x2faf080d:
                                    return 0x2faf080d;
                        }
                        return int_229;
                  }
                  switch (int_229)
                  {
                        case 0x2faf0817:
                              return 0x2faf0817;

                        case 0x2faf0818:
                              return 0x2faf0818;

                        case 0x2faf0819:
                        case 0x2faf081a:
                              return 0x2faf0801;

                        case 0x2faf081b:
                              return 0x2faf081c;

                        case 0x2faf083d:
                              return 0x2faf083d;

                        case 0x2faf083e:
                              return 0x2faf083e;
                  }
                  return int_229;
            }

            public static int smethod_15()
            {
                  byte[] data = new byte[4];
                  new RNGCryptoServiceProvider().GetBytes(data);
                  return BitConverter.ToInt32(data, 0);
            }

            public static int smethod_16(int int_229, int int_230)
            {
                  int num;
                  int num2;
                  string str;
                  string str2;
                  string[] strArray2;
                  string[] strArray8;
                  Random random = new Random(smethod_15());
                  int num3 = int_229;
                  if (num3 <= 0x2faf080d)
                  {
                        if (num3 != 0x2faf0801)
                        {
                              switch (num3)
                              {
                                    case 0x2faf080b:
                                          goto Label_13D5;

                                    case 0x2faf080c:
                                    case 0x2faf0802:
                                          {
                                                string[] strArray9 = null;
                                                switch (int_230)
                                                {
                                                      case 1:
                                                            {
                                                                  char[] separator = new char[] { ';' };
                                                                  strArray9 = CUA_HANG_HAN_NGOC_THACH.Split(separator);
                                                                  break;
                                                            }
                                                      case 2:
                                                            {
                                                                  char[] chArray33 = new char[] { ';' };
                                                                  strArray9 = BACH_BAO_CAC_HAN_NGOC_THACH.Split(chArray33);
                                                                  break;
                                                            }
                                                      case 3:
                                                            {
                                                                  char[] chArray34 = new char[] { ';' };
                                                                  strArray9 = QUAI_BINH_THUONG_DROP_HAN_NGOC_THACH.Split(chArray34);
                                                                  break;
                                                            }
                                                      case 4:
                                                            {
                                                                  char[] chArray35 = new char[] { ';' };
                                                                  strArray9 = BOSS_QUAI_DROP_HAN_NGOC_THACH.Split(chArray35);
                                                                  break;
                                                            }
                                                      case 5:
                                                            {
                                                                  char[] chArray36 = new char[] { ';' };
                                                                  strArray9 = KHEN_THUONG_HAN_NGOC_THACH.Split(chArray36);
                                                                  break;
                                                            }
                                                      case 6:
                                                            {
                                                                  char[] chArray37 = new char[] { ';' };
                                                                  strArray9 = MO_HOM_HAN_NGOC_THACH.Split(chArray37);
                                                                  break;
                                                            }
                                                      case 7:
                                                            {
                                                                  char[] chArray38 = new char[] { ';' };
                                                                  strArray9 = CAO_THU_QUAI_DROP_HAN_NGOC_THACH.Split(chArray38);
                                                                  break;
                                                            }
                                                }
                                                return random.Next(Convert.ToInt32(strArray9[0]), Convert.ToInt32(strArray9[1]));
                                          }
                                    case 0x2faf080d:
                                          {
                                                num = 8;
                                                num2 = 0;
                                                str = "0000";
                                                string[] strArray = null;
                                                switch (int_230)
                                                {
                                                      case 1:
                                                            {
                                                                  char[] chArray39 = new char[] { ';' };
                                                                  strArray = CUA_HANG_NHIET_HUYET_THACH.Split(chArray39);
                                                                  break;
                                                            }
                                                      case 2:
                                                            {
                                                                  char[] chArray40 = new char[] { ';' };
                                                                  strArray = BACH_BAO_CAC_NHIET_HUYET_THACH.Split(chArray40);
                                                                  break;
                                                            }
                                                      case 3:
                                                            {
                                                                  char[] chArray41 = new char[] { ';' };
                                                                  strArray = QUAI_BINH_THUONG_DROP_NHIET_HUYET_THACH.Split(chArray41);
                                                                  break;
                                                            }
                                                      case 4:
                                                            {
                                                                  char[] chArray42 = new char[] { ';' };
                                                                  strArray = BOSS_QUAI_DROP_NHIET_HUYET_THACH.Split(chArray42);
                                                                  break;
                                                            }
                                                      case 5:
                                                            {
                                                                  char[] chArray43 = new char[] { ';' };
                                                                  strArray = KHEN_THUONG_NHIET_HUYET_THACH.Split(chArray43);
                                                                  break;
                                                            }
                                                      case 6:
                                                            {
                                                                  char[] chArray44 = new char[] { ';' };
                                                                  strArray = MO_HOM_NHIET_HUYET_THACH.Split(chArray44);
                                                                  break;
                                                            }
                                                      case 7:
                                                            {
                                                                  char[] chArray45 = new char[] { ';' };
                                                                  strArray = CAO_THU_QUAI_DROP_NHIET_HUYET_THACH.Split(chArray45);
                                                                  break;
                                                            }
                                                }
                                                if (strArray[0] == "Q")
                                                {
                                                      num = 8;
                                                      num2 = random.Next(Convert.ToInt32(strArray[1]), Convert.ToInt32(strArray[2]));
                                                }
                                                else if (strArray[0] == "M")
                                                {
                                                      if (random.Next(1, 100) > 50)
                                                      {
                                                            num = 8;
                                                            num2 = random.Next(Convert.ToInt32(strArray[1]), Convert.ToInt32(strArray[2]));
                                                      }
                                                      else
                                                      {
                                                            num = 9;
                                                            num2 = random.Next(Convert.ToInt32(strArray[1]), Convert.ToInt32(strArray[2]));
                                                      }
                                                }
                                                else
                                                {
                                                      int num6 = random.Next(0, 120);
                                                      if ((num6 >= 0) && (num6 <= 70))
                                                      {
                                                            num = 8;
                                                      }
                                                      else
                                                      {
                                                            if ((num6 > 70) && (num6 <= 0x55))
                                                            {
                                                                  num = 9;
                                                                  num2 = random.Next(Convert.ToInt32(strArray[1]), Convert.ToInt32(strArray[2]));
                                                                  goto Label_17BF;
                                                            }
                                                            if ((num6 > 0x55) && (num6 <= 0x69))
                                                            {
                                                                  num = 12;
                                                                  num2 = 10;
                                                                  goto Label_17BF;
                                                            }
                                                            num = 8;
                                                      }
                                                      str = "0" + random.Next(10, 0x59).ToString() + "0";
                                                      num2 = random.Next(Convert.ToInt32(strArray[1]), Convert.ToInt32(strArray[2]));
                                                }
                                                goto Label_17BF;
                                          }
                              }
                              goto Label_17FC;
                        }
                        goto Label_13D5;
                  }
                  switch (num3)
                  {
                        case 0x2faf0817:
                              strArray2 = null;
                              switch (int_230)
                              {
                                    case 1:
                                          {
                                                char[] chArray1 = new char[] { ';' };
                                                strArray2 = CUA_HANG_HON_NGUYEN_KIM_CUONG_THACH.Split(chArray1);
                                                goto Label_026A;
                                          }
                                    case 2:
                                          switch (BACH_BAO_HON_NGUYEN_KIM_CUONG_THACH_LOAI_HINH_THIET_LAP)
                                          {
                                                case 0:
                                                      if (random.Next(1, 100) > 50)
                                                      {
                                                            return random.Next(Convert.ToInt32(BACH_BAO_HON_NGUYEN_KIM_CUONG_THACH_CONG_KICH[0]), Convert.ToInt32(BACH_BAO_HON_NGUYEN_KIM_CUONG_THACH_CONG_KICH[1]));
                                                      }
                                                      return random.Next(Convert.ToInt32(BACH_BAO_HON_NGUYEN_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG[0]), Convert.ToInt32(BACH_BAO_HON_NGUYEN_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG[1]));

                                                case 1:
                                                      return random.Next(Convert.ToInt32(BACH_BAO_HON_NGUYEN_KIM_CUONG_THACH_CONG_KICH[0]), Convert.ToInt32(BACH_BAO_HON_NGUYEN_KIM_CUONG_THACH_CONG_KICH[1]));

                                                case 2:
                                                      return random.Next(Convert.ToInt32(BACH_BAO_HON_NGUYEN_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG[0]), Convert.ToInt32(BACH_BAO_HON_NGUYEN_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG[1]));
                                          }
                                          goto Label_026A;

                                    case 3:
                                          {
                                                char[] chArray2 = new char[] { ';' };
                                                strArray2 = QUAI_BINH_THUONG_DROP_HON_NGUYEN_KIM_CUONG_THACH.Split(chArray2);
                                                goto Label_026A;
                                          }
                                    case 4:
                                          {
                                                char[] chArray3 = new char[] { ';' };
                                                strArray2 = BOSS_QUAI_DROP_HON_NGUYEN_KIM_CUONG_THACH.Split(chArray3);
                                                goto Label_026A;
                                          }
                                    case 5:
                                          {
                                                char[] chArray4 = new char[] { ';' };
                                                strArray2 = KHEN_THUONG_HON_NGUYEN_KIM_CUONG_THACH.Split(chArray4);
                                                goto Label_026A;
                                          }
                                    case 6:
                                          switch (MO_HOM_HON_NGUYEN_KIM_CUONG_THACH_LOAI_HINH_THIET_LAP)
                                          {
                                                case 0:
                                                      if (random.Next(1, 100) > 50)
                                                      {
                                                            return random.Next(Convert.ToInt32(MO_HOM_HON_NGUYEN_KIM_CUONG_THACH_CONG_KICH[0]), Convert.ToInt32(MO_HOM_HON_NGUYEN_KIM_CUONG_THACH_CONG_KICH[1]));
                                                      }
                                                      return random.Next(Convert.ToInt32(MO_HOM_HON_NGUYEN_DA_KIM_CUONG_LUC_CONG_KICH_VO_CONG[0]), Convert.ToInt32(MO_HOM_HON_NGUYEN_DA_KIM_CUONG_LUC_CONG_KICH_VO_CONG[1]));

                                                case 1:
                                                      return random.Next(Convert.ToInt32(MO_HOM_HON_NGUYEN_KIM_CUONG_THACH_CONG_KICH[0]), Convert.ToInt32(MO_HOM_HON_NGUYEN_KIM_CUONG_THACH_CONG_KICH[1]));

                                                case 2:
                                                      return random.Next(Convert.ToInt32(MO_HOM_HON_NGUYEN_DA_KIM_CUONG_LUC_CONG_KICH_VO_CONG[0]), Convert.ToInt32(MO_HOM_HON_NGUYEN_DA_KIM_CUONG_LUC_CONG_KICH_VO_CONG[1]));
                                          }
                                          goto Label_026A;

                                    case 7:
                                          {
                                                char[] chArray5 = new char[] { ';' };
                                                strArray2 = CAO_THU_QUAI_DROP_HON_NGUYEN_KIM_CUONG_THACH.Split(chArray5);
                                                goto Label_026A;
                                          }
                              }
                              break;

                        case 0x2faf0818:
                              switch (int_230)
                              {
                                    case 1:
                                          switch (CUA_HANG_BANG_PHACH_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP)
                                          {
                                                case 0:
                                                      if (random.Next(1, 100) > 50)
                                                      {
                                                            return random.Next(Convert.ToInt32(CUA_HANG_BANG_PHACH_HAN_NGOC_THACH_VO_CONG_PHONG_NGU[0]), Convert.ToInt32(CUA_HANG_BANG_PHACH_HAN_NGOC_THACH_VO_CONG_PHONG_NGU[1]));
                                                      }
                                                      return random.Next(Convert.ToInt32(CUA_HANG_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU[0]), Convert.ToInt32(CUA_HANG_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU[1]));

                                                case 1:
                                                      return random.Next(Convert.ToInt32(CUA_HANG_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU[0]), Convert.ToInt32(CUA_HANG_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU[1]));

                                                case 2:
                                                      return random.Next(Convert.ToInt32(CUA_HANG_BANG_PHACH_HAN_NGOC_THACH_VO_CONG_PHONG_NGU[0]), Convert.ToInt32(CUA_HANG_BANG_PHACH_HAN_NGOC_THACH_VO_CONG_PHONG_NGU[1]));
                                          }
                                          break;

                                    case 2:
                                          switch (BACH_BAO_CAC_BANG_PHACH_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP)
                                          {
                                                case 0:
                                                      if (random.Next(1, 100) > 50)
                                                      {
                                                            return random.Next(Convert.ToInt32(BACH_BAO_CAC_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[0]), Convert.ToInt32(BACH_BAO_CAC_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[1]));
                                                      }
                                                      return random.Next(Convert.ToInt32(BACH_BAO_CAC_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU[0]), Convert.ToInt32(BACH_BAO_CAC_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU[1]));

                                                case 1:
                                                      return random.Next(Convert.ToInt32(BACH_BAO_CAC_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU[0]), Convert.ToInt32(BACH_BAO_CAC_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU[1]));

                                                case 2:
                                                      return random.Next(Convert.ToInt32(BACH_BAO_CAC_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[0]), Convert.ToInt32(BACH_BAO_CAC_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[1]));
                                          }
                                          break;

                                    case 3:
                                          switch (QUAI_BINH_THUONG_DROP_BANG_PHACH_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP)
                                          {
                                                case 0:
                                                      if (random.Next(1, 100) > 50)
                                                      {
                                                            return random.Next(Convert.ToInt32(QUAI_BINH_THUONG_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[0]), Convert.ToInt32(QUAI_BINH_THUONG_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[1]));
                                                      }
                                                      return random.Next(Convert.ToInt32(QUAI_BINH_THUONG_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU[0]), Convert.ToInt32(QUAI_BINH_THUONG_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU[1]));

                                                case 1:
                                                      return random.Next(Convert.ToInt32(QUAI_BINH_THUONG_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU[0]), Convert.ToInt32(QUAI_BINH_THUONG_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU[1]));

                                                case 2:
                                                      return random.Next(Convert.ToInt32(QUAI_BINH_THUONG_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[0]), Convert.ToInt32(QUAI_BINH_THUONG_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[1]));
                                          }
                                          break;

                                    case 4:
                                          switch (BOSS_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP)
                                          {
                                                case 0:
                                                      if (random.Next(1, 100) > 50)
                                                      {
                                                            return random.Next(Convert.ToInt32(BOSS_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[0]), Convert.ToInt32(BOSS_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[1]));
                                                      }
                                                      return random.Next(Convert.ToInt32(BOSS_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU[0]), Convert.ToInt32(BOSS_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU[1]));

                                                case 1:
                                                      return random.Next(Convert.ToInt32(BOSS_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU[0]), Convert.ToInt32(BOSS_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU[1]));

                                                case 2:
                                                      return random.Next(Convert.ToInt32(BOSS_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[0]), Convert.ToInt32(BOSS_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[1]));
                                          }
                                          break;

                                    case 5:
                                          switch (KHEN_THUONG_BANG_PHACH_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP)
                                          {
                                                case 0:
                                                      if (random.Next(1, 100) > 50)
                                                      {
                                                            return random.Next(Convert.ToInt32(KHEN_THUONG_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[0]), Convert.ToInt32(KHEN_THUONG_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[1]));
                                                      }
                                                      return random.Next(Convert.ToInt32(KHEN_THUONG_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU[0]), Convert.ToInt32(KHEN_THUONG_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU[1]));

                                                case 1:
                                                      return random.Next(Convert.ToInt32(KHEN_THUONG_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU[0]), Convert.ToInt32(KHEN_THUONG_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU[1]));

                                                case 2:
                                                      return random.Next(Convert.ToInt32(KHEN_THUONG_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[0]), Convert.ToInt32(KHEN_THUONG_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[1]));
                                          }
                                          break;

                                    case 6:
                                          switch (MO_HOM_BANG_PHACH_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP)
                                          {
                                                case 0:
                                                      if (random.Next(1, 100) > 50)
                                                      {
                                                            return random.Next(Convert.ToInt32(MO_HOM_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[0]), Convert.ToInt32(MO_HOM_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[1]));
                                                      }
                                                      return random.Next(Convert.ToInt32(MO_HOM_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU[0]), Convert.ToInt32(MO_HOM_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU[1]));

                                                case 1:
                                                      return random.Next(Convert.ToInt32(MO_HOM_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU[0]), Convert.ToInt32(MO_HOM_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU[1]));

                                                case 2:
                                                      return random.Next(Convert.ToInt32(MO_HOM_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[0]), Convert.ToInt32(MO_HOM_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[1]));
                                          }
                                          break;

                                    case 7:
                                          switch (CAO_THU_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP)
                                          {
                                                case 0:
                                                      if (random.Next(1, 100) > 50)
                                                      {
                                                            return random.Next(Convert.ToInt32(CAO_THU_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[0]), Convert.ToInt32(CAO_THU_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[1]));
                                                      }
                                                      return random.Next(Convert.ToInt32(CAO_THU_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU[0]), Convert.ToInt32(CAO_THU_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU[1]));

                                                case 1:
                                                      return random.Next(Convert.ToInt32(CAO_THU_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU[0]), Convert.ToInt32(CAO_THU_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU[1]));

                                                case 2:
                                                      return random.Next(Convert.ToInt32(CAO_THU_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[0]), Convert.ToInt32(CAO_THU_QUAI_DROP_BANG_PHACH_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[1]));
                                          }
                                          break;
                              }
                              return 0;

                        case 0x2faf0819:
                              {
                                    string[] strArray3 = null;
                                    switch (int_230)
                                    {
                                          case 1:
                                                {
                                                      char[] chArray6 = new char[] { ';' };
                                                      strArray3 = CUA_HANG_THAN_BI_KIM_CUONG_THACH_TRUY_THUONG.Split(chArray6);
                                                      break;
                                                }
                                          case 2:
                                                {
                                                      char[] chArray7 = new char[] { ';' };
                                                      strArray3 = BACH_BAO_CAC_THAN_BI_KIM_CUONG_THACH_TRUY_THUONG.Split(chArray7);
                                                      break;
                                                }
                                          case 3:
                                                {
                                                      char[] chArray8 = new char[] { ';' };
                                                      strArray3 = QUAI_BINH_THUONG_DROP_THAN_BI_KIM_CUONG_THACH_TRUY_THUONG.Split(chArray8);
                                                      break;
                                                }
                                          case 4:
                                                {
                                                      char[] chArray9 = new char[] { ';' };
                                                      strArray3 = BOSS_QUAI_DROP_THAN_BI_KIM_CUONG_THACH_TRUY_THUONG.Split(chArray9);
                                                      break;
                                                }
                                          case 5:
                                                {
                                                      char[] chArray10 = new char[] { ';' };
                                                      strArray3 = KHEN_THUONG_THAN_BI_KIM_CUONG_THACH_TRUY_THUONG.Split(chArray10);
                                                      break;
                                                }
                                          case 6:
                                                {
                                                      char[] chArray11 = new char[] { ';' };
                                                      strArray3 = MO_HOM_THAN_BI_KIM_CUONG_THACH_TRUY_THUONG.Split(chArray11);
                                                      break;
                                                }
                                          case 7:
                                                {
                                                      char[] chArray12 = new char[] { ';' };
                                                      strArray3 = CAO_THU_QUAI_DROP_THAN_BI_KIM_CUONG_THACH_TRUY_THUONG.Split(chArray12);
                                                      break;
                                                }
                                    }
                                    return random.Next(Convert.ToInt32(strArray3[0]), Convert.ToInt32(strArray3[1]));
                              }
                        case 0x2faf081a:
                              {
                                    string[] strArray4 = null;
                                    switch (int_230)
                                    {
                                          case 1:
                                                {
                                                      char[] chArray13 = new char[] { ';' };
                                                      strArray4 = CUA_HANG_THAN_BI_KIM_CUONG_THACH_VO_CONG.Split(chArray13);
                                                      break;
                                                }
                                          case 2:
                                                {
                                                      char[] chArray14 = new char[] { ';' };
                                                      strArray4 = BACH_BAO_CAC_THAN_BI_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG.Split(chArray14);
                                                      break;
                                                }
                                          case 3:
                                                {
                                                      char[] chArray15 = new char[] { ';' };
                                                      strArray4 = QUAI_BINH_THUONG_DROP_THAN_BI_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG.Split(chArray15);
                                                      break;
                                                }
                                          case 4:
                                                {
                                                      char[] chArray16 = new char[] { ';' };
                                                      strArray4 = BOSS_QUAI_DROP_THAN_BI_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG.Split(chArray16);
                                                      break;
                                                }
                                          case 5:
                                                {
                                                      char[] chArray17 = new char[] { ';' };
                                                      strArray4 = KHEN_THUONG_THAN_BI_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG.Split(chArray17);
                                                      break;
                                                }
                                          case 6:
                                                {
                                                      char[] chArray18 = new char[] { ';' };
                                                      strArray4 = MO_HOM_THAN_BI_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG.Split(chArray18);
                                                      break;
                                                }
                                          case 7:
                                                {
                                                      char[] chArray19 = new char[] { ';' };
                                                      strArray4 = CAO_THU_QUAI_DROP_THAN_BI_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG.Split(chArray19);
                                                      break;
                                                }
                                    }
                                    return random.Next(Convert.ToInt32(strArray4[0]), Convert.ToInt32(strArray4[1]));
                              }
                        case 0x2faf081b:
                        case 0x2faf081c:
                              {
                                    int num5 = 0;
                                    switch (int_230)
                                    {
                                          case 1:
                                                switch (CUA_HANG_THUOC_TINH_THACH)
                                                {
                                                      case 0:
                                                            num5 = random.Next(1, 7);
                                                            break;

                                                      case 1:
                                                            num5 = 1;
                                                            break;

                                                      case 2:
                                                            num5 = 2;
                                                            break;

                                                      case 3:
                                                            num5 = 3;
                                                            break;

                                                      case 4:
                                                            num5 = 4;
                                                            break;

                                                      case 5:
                                                            num5 = 5;
                                                            break;

                                                      case 6:
                                                            num5 = 6;
                                                            break;

                                                      case 7:
                                                            num5 = 7;
                                                            break;
                                                }
                                                break;

                                          case 2:
                                                switch (BACH_BAO_CAC_THUOC_TINH_THACH)
                                                {
                                                      case 0:
                                                            num5 = random.Next(1, 7);
                                                            break;

                                                      case 1:
                                                            num5 = 1;
                                                            break;

                                                      case 2:
                                                            num5 = 2;
                                                            break;

                                                      case 3:
                                                            num5 = 3;
                                                            break;

                                                      case 4:
                                                            num5 = 4;
                                                            break;

                                                      case 5:
                                                            num5 = 5;
                                                            break;

                                                      case 6:
                                                            num5 = 6;
                                                            break;

                                                      case 7:
                                                            num5 = 7;
                                                            break;
                                                }
                                                num5 = random.Next(1, 7);
                                                break;

                                          case 3:
                                                switch (QUAI_BINH_THUONG_DROP_THUOC_TINH_THACH)
                                                {
                                                      case 0:
                                                            num5 = random.Next(1, 7);
                                                            break;

                                                      case 1:
                                                            num5 = 1;
                                                            break;

                                                      case 2:
                                                            num5 = 2;
                                                            break;

                                                      case 3:
                                                            num5 = 3;
                                                            break;

                                                      case 4:
                                                            num5 = 4;
                                                            break;

                                                      case 5:
                                                            num5 = 5;
                                                            break;

                                                      case 6:
                                                            num5 = 6;
                                                            break;

                                                      case 7:
                                                            num5 = 7;
                                                            break;
                                                }
                                                num5 = random.Next(1, 7);
                                                break;

                                          case 4:
                                                switch (BOSS_QUAI_DROP_THUOC_TINH_THACH)
                                                {
                                                      case 0:
                                                            num5 = random.Next(1, 7);
                                                            break;

                                                      case 1:
                                                            num5 = 1;
                                                            break;

                                                      case 2:
                                                            num5 = 2;
                                                            break;

                                                      case 3:
                                                            num5 = 3;
                                                            break;

                                                      case 4:
                                                            num5 = 4;
                                                            break;

                                                      case 5:
                                                            num5 = 5;
                                                            break;

                                                      case 6:
                                                            num5 = 6;
                                                            break;

                                                      case 7:
                                                            num5 = 7;
                                                            break;
                                                }
                                                num5 = random.Next(1, 7);
                                                break;

                                          case 5:
                                                switch (KHEN_THUONG_THUOC_TINH_THACH)
                                                {
                                                      case 0:
                                                            num5 = random.Next(1, 7);
                                                            break;

                                                      case 1:
                                                            num5 = 1;
                                                            break;

                                                      case 2:
                                                            num5 = 2;
                                                            break;

                                                      case 3:
                                                            num5 = 3;
                                                            break;

                                                      case 4:
                                                            num5 = 4;
                                                            break;

                                                      case 5:
                                                            num5 = 5;
                                                            break;

                                                      case 6:
                                                            num5 = 6;
                                                            break;

                                                      case 7:
                                                            num5 = 7;
                                                            break;
                                                }
                                                num5 = random.Next(1, 7);
                                                break;

                                          case 6:
                                                switch (MO_HOM_THUOC_TINH_THACH)
                                                {
                                                      case 0:
                                                            num5 = random.Next(1, 7);
                                                            break;

                                                      case 1:
                                                            num5 = 1;
                                                            break;

                                                      case 2:
                                                            num5 = 2;
                                                            break;

                                                      case 3:
                                                            num5 = 3;
                                                            break;

                                                      case 4:
                                                            num5 = 4;
                                                            break;

                                                      case 5:
                                                            num5 = 5;
                                                            break;

                                                      case 6:
                                                            num5 = 6;
                                                            break;

                                                      case 7:
                                                            num5 = 7;
                                                            break;
                                                }
                                                break;

                                          case 7:
                                                switch (CAO_THU_QUAI_DROP_THUOC_TINH_THACH)
                                                {
                                                      case 0:
                                                            num5 = random.Next(1, 7);
                                                            break;

                                                      case 1:
                                                            num5 = 1;
                                                            break;

                                                      case 2:
                                                            num5 = 2;
                                                            break;

                                                      case 3:
                                                            num5 = 3;
                                                            break;

                                                      case 4:
                                                            num5 = 4;
                                                            break;

                                                      case 5:
                                                            num5 = 5;
                                                            break;

                                                      case 6:
                                                            num5 = 6;
                                                            break;

                                                      case 7:
                                                            num5 = 7;
                                                            break;
                                                }
                                                break;
                                    }
                                    return int.Parse("200" + num5.ToString() + "000");
                              }
                        case 0x2faf083d:
                              {
                                    string[] strArray5 = null;
                                    switch (int_230)
                                    {
                                          case 1:
                                                {
                                                      char[] chArray20 = new char[] { ';' };
                                                      strArray5 = CUA_HANG_CAN_KHON_KIM_CUONG_THACH.Split(chArray20);
                                                      break;
                                                }
                                          case 2:
                                                switch (BACH_BAO_CAN_KHON_KIM_CUONG_THACH_LOAI_HINH_THIET_LAP)
                                                {
                                                      case 0:
                                                            if (random.Next(1, 100) <= 50)
                                                            {
                                                                  return random.Next(Convert.ToInt32(BACH_BAO_CAN_KHON_KIM_CUONG_THACH_CONG_KICH_VO_CONG[0]), Convert.ToInt32(BACH_BAO_CAN_KHON_KIM_CUONG_THACH_CONG_KICH_VO_CONG[1]));
                                                            }
                                                            return random.Next(Convert.ToInt32(BACH_BAO_CAN_KHON_KIM_CUONG_THACH_CONG_KICH[0]), Convert.ToInt32(BACH_BAO_CAN_KHON_KIM_CUONG_THACH_CONG_KICH[1]));

                                                      case 1:
                                                            return random.Next(Convert.ToInt32(BACH_BAO_CAN_KHON_KIM_CUONG_THACH_CONG_KICH[0]), Convert.ToInt32(BACH_BAO_CAN_KHON_KIM_CUONG_THACH_CONG_KICH[1]));

                                                      case 2:
                                                            return random.Next(Convert.ToInt32(BACH_BAO_CAN_KHON_KIM_CUONG_THACH_CONG_KICH_VO_CONG[0]), Convert.ToInt32(BACH_BAO_CAN_KHON_KIM_CUONG_THACH_CONG_KICH_VO_CONG[1]));
                                                }
                                                break;

                                          case 3:
                                                {
                                                      char[] chArray21 = new char[] { ';' };
                                                      strArray5 = QUAI_BINH_THUONG_DROP_CAN_KHON_KIM_CUONG_THACH.Split(chArray21);
                                                      break;
                                                }
                                          case 4:
                                                {
                                                      char[] chArray22 = new char[] { ';' };
                                                      strArray5 = BOSS_QUAI_DROP_CAN_KHON_KIM_CUONG_THACH.Split(chArray22);
                                                      break;
                                                }
                                          case 5:
                                                {
                                                      char[] chArray23 = new char[] { ';' };
                                                      strArray5 = KHEN_THUONG_CAN_KHON_KIM_CUONG_THACH.Split(chArray23);
                                                      break;
                                                }
                                          case 6:
                                                switch (MO_HOM_CAN_KHON_KIM_CUONG_THACH_LOAI_HINH_THIET_LAP)
                                                {
                                                      case 0:
                                                            if (random.Next(1, 100) <= 50)
                                                            {
                                                                  return random.Next(Convert.ToInt32(MO_HOM_CAN_KHON_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG[0]), Convert.ToInt32(MO_HOM_CAN_KHON_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG[1]));
                                                            }
                                                            return random.Next(Convert.ToInt32(MO_HOM_CAN_KHON_KIM_CUONG_THACH_CONG_KICH[0]), Convert.ToInt32(MO_HOM_CAN_KHON_KIM_CUONG_THACH_CONG_KICH[1]));

                                                      case 1:
                                                            return random.Next(Convert.ToInt32(MO_HOM_CAN_KHON_KIM_CUONG_THACH_CONG_KICH[0]), Convert.ToInt32(MO_HOM_CAN_KHON_KIM_CUONG_THACH_CONG_KICH[1]));

                                                      case 2:
                                                            return random.Next(Convert.ToInt32(MO_HOM_CAN_KHON_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG[0]), Convert.ToInt32(MO_HOM_CAN_KHON_KIM_CUONG_THACH_LUC_CONG_KICH_VO_CONG[1]));
                                                }
                                                break;

                                          case 7:
                                                {
                                                      char[] chArray24 = new char[] { ';' };
                                                      strArray5 = CAO_THU_QUAI_DROP_CAN_KHON_KIM_CUONG_THACH.Split(chArray24);
                                                      break;
                                                }
                                    }
                                    return random.Next(Convert.ToInt32(strArray5[0]), Convert.ToInt32(strArray5[1]));
                              }
                        case 0x2faf083e:
                              {
                                    string[] strArray6 = null;
                                    string[] strArray7 = null;
                                    if (int_230 == 1)
                                    {
                                          switch (CUA_HANG_NGUNG_SUONG_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP)
                                          {
                                                case 0:
                                                      if (random.Next(1, 100) <= 50)
                                                      {
                                                            return random.Next(Convert.ToInt32(CUA_HANG_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU[0]), Convert.ToInt32(CUA_HANG_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU[1]));
                                                      }
                                                      return random.Next(Convert.ToInt32(CUA_HANG_NGUNG_SUONG_HAN_NGOC_THACH_VO_CONG_PHONG_NGU[0]), Convert.ToInt32(CUA_HANG_NGUNG_SUONG_HAN_NGOC_THACH_VO_CONG_PHONG_NGU[1]));

                                                case 1:
                                                      return random.Next(Convert.ToInt32(CUA_HANG_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU[0]), Convert.ToInt32(CUA_HANG_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU[1]));

                                                case 2:
                                                      return random.Next(Convert.ToInt32(CUA_HANG_NGUNG_SUONG_HAN_NGOC_THACH_VO_CONG_PHONG_NGU[0]), Convert.ToInt32(CUA_HANG_NGUNG_SUONG_HAN_NGOC_THACH_VO_CONG_PHONG_NGU[1]));
                                          }
                                    }
                                    else if (int_230 != 2)
                                    {
                                          if (int_230 == 3)
                                          {
                                                switch (QUAI_BINH_THUONG_DROP_NGUNG_SUONG_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP)
                                                {
                                                      case 0:
                                                            if (random.Next(1, 100) > 50)
                                                            {
                                                                  return random.Next(Convert.ToInt32(QUAI_BINH_THUONG_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[0]), Convert.ToInt32(QUAI_BINH_THUONG_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[1]));
                                                            }
                                                            return random.Next(Convert.ToInt32(QUAI_BINH_THUONG_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU[0]), Convert.ToInt32(QUAI_BINH_THUONG_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU[1]));

                                                      case 1:
                                                            return random.Next(Convert.ToInt32(QUAI_BINH_THUONG_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU[0]), Convert.ToInt32(QUAI_BINH_THUONG_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU[1]));

                                                      case 2:
                                                            return random.Next(Convert.ToInt32(QUAI_BINH_THUONG_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[0]), Convert.ToInt32(QUAI_BINH_THUONG_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[1]));
                                                }
                                          }
                                          else if (int_230 == 4)
                                          {
                                                switch (BOSS_QUAI_DROP_NGUNG_SUONG_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP)
                                                {
                                                      case 0:
                                                            if (random.Next(1, 100) > 50)
                                                            {
                                                                  return random.Next(Convert.ToInt32(BOSS_QUAI_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[0]), Convert.ToInt32(BOSS_QUAI_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[1]));
                                                            }
                                                            return random.Next(Convert.ToInt32(BOSS_QUAI_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU[0]), Convert.ToInt32(BOSS_QUAI_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU[1]));

                                                      case 1:
                                                            return random.Next(Convert.ToInt32(BOSS_QUAI_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU[0]), Convert.ToInt32(BOSS_QUAI_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU[1]));

                                                      case 2:
                                                            return random.Next(Convert.ToInt32(BOSS_QUAI_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[0]), Convert.ToInt32(BOSS_QUAI_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[1]));
                                                }
                                          }
                                          else if (int_230 == 5)
                                          {
                                                switch (KHEN_THUONG_NGUNG_SUONG_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP)
                                                {
                                                      case 0:
                                                            if (random.Next(1, 100) > 50)
                                                            {
                                                                  return random.Next(Convert.ToInt32(strArray7[0]), Convert.ToInt32(strArray7[1]));
                                                            }
                                                            return random.Next(Convert.ToInt32(KHEN_THUONG_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU[0]), Convert.ToInt32(KHEN_THUONG_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU[1]));

                                                      case 1:
                                                            return random.Next(Convert.ToInt32(KHEN_THUONG_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU[0]), Convert.ToInt32(KHEN_THUONG_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU[1]));

                                                      case 2:
                                                            return random.Next(Convert.ToInt32(strArray7[0]), Convert.ToInt32(strArray7[1]));
                                                }
                                          }
                                          else if (int_230 == 6)
                                          {
                                                switch (MO_HOM_NGUNG_SUONG_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP)
                                                {
                                                      case 0:
                                                            if (random.Next(1, 100) > 50)
                                                            {
                                                                  return random.Next(Convert.ToInt32(MO_HOM_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[0]), Convert.ToInt32(MO_HOM_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[1]));
                                                            }
                                                            return random.Next(Convert.ToInt32(MO_HOM_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU[0]), Convert.ToInt32(MO_HOM_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU[1]));

                                                      case 1:
                                                            return random.Next(Convert.ToInt32(MO_HOM_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU[0]), Convert.ToInt32(MO_HOM_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU[1]));

                                                      case 2:
                                                            return random.Next(Convert.ToInt32(MO_HOM_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[0]), Convert.ToInt32(MO_HOM_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[1]));
                                                }
                                          }
                                          else if (int_230 == 7)
                                          {
                                                switch (CAO_THU_QUAI_DROP_NGUNG_SUONG_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP)
                                                {
                                                      case 0:
                                                            if (random.Next(1, 100) > 50)
                                                            {
                                                                  return random.Next(Convert.ToInt32(CAO_THU_QUAI_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[0]), Convert.ToInt32(CAO_THU_QUAI_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[1]));
                                                            }
                                                            return random.Next(Convert.ToInt32(CAO_THU_QUAI_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU[0]), Convert.ToInt32(CAO_THU_QUAI_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU[1]));

                                                      case 1:
                                                            return random.Next(Convert.ToInt32(strArray6[0]), Convert.ToInt32(strArray6[1]));

                                                      case 2:
                                                            return random.Next(Convert.ToInt32(CAO_THU_QUAI_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[0]), Convert.ToInt32(CAO_THU_QUAI_DROP_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[1]));
                                                }
                                          }
                                    }
                                    else
                                    {
                                          switch (BACH_BAO_CAC_NGUNG_SUONG_HAN_NGOC_THACH_LOAI_HINH_THIET_LAP)
                                          {
                                                case 0:
                                                      if (random.Next(1, 100) > 50)
                                                      {
                                                            return random.Next(Convert.ToInt32(BACH_BAO_CAC_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[0]), Convert.ToInt32(BACH_BAO_CAC_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[1]));
                                                      }
                                                      return random.Next(Convert.ToInt32(BACH_BAO_CAC_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU[0]), Convert.ToInt32(BACH_BAO_CAC_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU[1]));

                                                case 1:
                                                      return random.Next(Convert.ToInt32(BACH_BAO_CAC_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU[0]), Convert.ToInt32(BACH_BAO_CAC_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU[1]));

                                                case 2:
                                                      return random.Next(Convert.ToInt32(BACH_BAO_CAC_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[0]), Convert.ToInt32(BACH_BAO_CAC_NGUNG_SUONG_HAN_NGOC_THACH_PHONG_NGU_VO_CONG[1]));
                                          }
                                    }
                                    return 0;
                              }
                        default:
                              goto Label_17FC;
                  }
                  Label_026A:
                  return random.Next(Convert.ToInt32(strArray2[0]), Convert.ToInt32(strArray2[1]));
                  Label_13D5:
                  strArray8 = null;
                  switch (int_230)
                  {
                        case 1:
                              {
                                    char[] chArray25 = new char[] { ';' };
                                    strArray8 = CUA_HANG_KIM_CUONG_THACH.Split(chArray25);
                                    break;
                              }
                        case 2:
                              {
                                    char[] chArray26 = new char[] { ';' };
                                    strArray8 = BACH_BAO_CAC_KIM_CUONG_THACH.Split(chArray26);
                                    break;
                              }
                        case 3:
                              {
                                    char[] chArray27 = new char[] { ';' };
                                    strArray8 = QUAI_BINH_THUONG_DROP_KIM_CUONG_THACH.Split(chArray27);
                                    break;
                              }
                        case 4:
                              {
                                    char[] chArray28 = new char[] { ';' };
                                    strArray8 = BOSS_QUAI_DROP_KIM_CUONG_THACH.Split(chArray28);
                                    break;
                              }
                        case 5:
                              {
                                    char[] chArray29 = new char[] { ';' };
                                    strArray8 = KHEN_THUONG_KIM_CUONG_THACH.Split(chArray29);
                                    break;
                              }
                        case 6:
                              {
                                    char[] chArray30 = new char[] { ';' };
                                    strArray8 = MO_HOM_KIM_CUONG_THACH.Split(chArray30);
                                    break;
                              }
                        case 7:
                              {
                                    char[] chArray31 = new char[] { ';' };
                                    strArray8 = CAO_THU_QUAI_DROP_KIM_CUONG_THACH.Split(chArray31);
                                    break;
                              }
                  }
                  return random.Next(Convert.ToInt32(strArray8[0]), Convert.ToInt32(strArray8[1]));
                  Label_17BF:
                  if (num == 12)
                  {
                        str2 = num.ToString() + "000" + num2;
                  }
                  else
                  {
                        str2 = num.ToString() + str + num2;
                  }
                  return int.Parse(str2);
                  Label_17FC:
                  return 0;
            }

            public static bool smethod_18(int int_229)
            {
                  char[] separator = new char[] { ',' };
                  string[] strArray = Item_khoa_chat.Split(separator);
                  for (int i = 0; i < strArray.Length; i++)
                  {
                        if (strArray[i] == int_229.ToString())
                        {
                              return true;
                        }
                  }
                  return false;
            }
            public static int smethod_19(int int_229, float float_2, float float_3, int int_230)
            {
                  try
                  {
                        TBL_XWWL_MONSTER tbl_xwwl_monster;
                        if (dictionary_13.TryGetValue(int_229, out tbl_xwwl_monster))
                        {
                              MapClass class2;
                              TBL_XWWL_NPC tbl_xwwl_npc = new TBL_XWWL_NPC
                              {
                                    FLD_PID = tbl_xwwl_monster.FLD_PID,
                                    Name = tbl_xwwl_monster.Name,
                                    Level = tbl_xwwl_monster.Level,
                                    Rxjh_Exp = tbl_xwwl_monster.Rxjh_Exp,
                                    Rxjh_X = float_2,
                                    Rxjh_Y = float_3,
                                    Rxjh_Z = 15f,
                                    Rxjh_cs_X = float_2,
                                    Rxjh_cs_Y = float_3,
                                    Rxjh_cs_Z = 15f,
                                    Rxjh_Map = int_230,
                                    IsNpc = 0,
                                    FLD_FACE1 = 0f,
                                    FLD_FACE2 = 0f,
                                    Max_Rxjh_HP = tbl_xwwl_monster.Rxjh_HP,
                                    Rxjh_HP = tbl_xwwl_monster.Rxjh_HP,
                                    FLD_AT = tbl_xwwl_monster.FLD_AT,
                                    FLD_DF = tbl_xwwl_monster.FLD_DF,
                                    FLD_AUTO = tbl_xwwl_monster.FLD_AUTO,
                                    FLD_BOSS = tbl_xwwl_monster.FLD_BOSS,
                                    一次性怪 = true
                              };
                              if (dictionary_12.TryGetValue(tbl_xwwl_npc.Rxjh_Map, out class2))
                              {
                                    class2.method_1(tbl_xwwl_npc);
                              }
                              else
                              {
                                    class2 = new MapClass
                                    {
                                          MapID = tbl_xwwl_npc.Rxjh_Map
                                    };
                                    class2.method_1(tbl_xwwl_npc);
                                    dictionary_12.Add(class2.MapID, class2);
                              }
                              tbl_xwwl_npc.method_5();
                              Thread.Sleep(1);
                              return tbl_xwwl_npc.FLD_INDEX;
                        }
                        return 0;
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(2, string.Concat(new object[] { "增加BOSS攻城怪 [", int_229, "]出错：", exception }));
                        return 0;
                  }
            }

            public static Players smethod_2(string string_218)
            {
                  foreach (Players players in allConnectedChars.Values)
                  {
                        if (players.UserName == string_218)
                        {
                              return players;
                        }
                  }
                  return null;
            }

            public static void smethod_20(int int_229, float float_2, float float_3, int int_230)
            {
                  try
                  {
                        TBL_XWWL_MONSTER tbl_xwwl_monster;
                        if (dictionary_13.TryGetValue(int_229, out tbl_xwwl_monster))
                        {
                              MapClass class2;
                              TBL_XWWL_NPC tbl_xwwl_npc = new TBL_XWWL_NPC
                              {
                                    FLD_PID = tbl_xwwl_monster.FLD_PID,
                                    Name = tbl_xwwl_monster.Name,
                                    Level = tbl_xwwl_monster.Level,
                                    Rxjh_Exp = tbl_xwwl_monster.Rxjh_Exp,
                                    Rxjh_X = float_2,
                                    Rxjh_Y = float_3,
                                    Rxjh_Z = 15f,
                                    Rxjh_cs_X = float_2,
                                    Rxjh_cs_Y = float_3,
                                    Rxjh_cs_Z = 15f,
                                    Rxjh_Map = int_230,
                                    IsNpc = 0,
                                    FLD_FACE1 = 0f,
                                    FLD_FACE2 = 0f,
                                    Max_Rxjh_HP = tbl_xwwl_monster.Rxjh_HP,
                                    Rxjh_HP = tbl_xwwl_monster.Rxjh_HP,
                                    FLD_AT = tbl_xwwl_monster.FLD_AT,
                                    FLD_DF = tbl_xwwl_monster.FLD_DF,
                                    FLD_AUTO = tbl_xwwl_monster.FLD_AUTO,
                                    FLD_BOSS = tbl_xwwl_monster.FLD_BOSS,
                                    一次性怪 = true
                              };
                              if (dictionary_12.TryGetValue(tbl_xwwl_npc.Rxjh_Map, out class2))
                              {
                                    class2.method_1(tbl_xwwl_npc);
                              }
                              else
                              {
                                    class2 = new MapClass
                                    {
                                          MapID = tbl_xwwl_npc.Rxjh_Map
                                    };
                                    class2.method_1(tbl_xwwl_npc);
                                    dictionary_12.Add(class2.MapID, class2);
                              }
                              tbl_xwwl_npc.method_5();
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(2, string.Concat(new object[] { "增加怪 [", int_229, "]出错：", exception }));
                  }
            }

            public static void smethod_21(int int_229, float float_2, float float_3, int int_230, int int_231, int int_232, bool bool_11, int int_233)
            {
                  try
                  {
                        TBL_XWWL_MONSTER tbl_xwwl_monster;
                        if (dictionary_13.TryGetValue(int_229, out tbl_xwwl_monster))
                        {
                              MapClass class2;
                              TBL_XWWL_NPC tbl_xwwl_npc = new TBL_XWWL_NPC
                              {
                                    FLD_PID = tbl_xwwl_monster.FLD_PID,
                                    Name = tbl_xwwl_monster.Name,
                                    Level = tbl_xwwl_monster.Level,
                                    Rxjh_Exp = tbl_xwwl_monster.Rxjh_Exp,
                                    Rxjh_X = float_2,
                                    Rxjh_Y = float_3,
                                    Rxjh_Z = 15f,
                                    Rxjh_cs_X = float_2,
                                    Rxjh_cs_Y = float_3,
                                    Rxjh_cs_Z = 15f,
                                    Rxjh_Map = int_230,
                                    IsNpc = 0,
                                    FLD_FACE1 = int_231,
                                    FLD_FACE2 = int_232,
                                    Max_Rxjh_HP = tbl_xwwl_monster.Rxjh_HP,
                                    Rxjh_HP = tbl_xwwl_monster.Rxjh_HP,
                                    FLD_AT = tbl_xwwl_monster.FLD_AT,
                                    FLD_DF = tbl_xwwl_monster.FLD_DF,
                                    FLD_AUTO = tbl_xwwl_monster.FLD_AUTO,
                                    FLD_BOSS = tbl_xwwl_monster.FLD_BOSS,
                                    一次性怪 = bool_11,
                                    FLD_NEWTIME = int_233
                              };
                              if (dictionary_12.TryGetValue(tbl_xwwl_npc.Rxjh_Map, out class2))
                              {
                                    class2.method_1(tbl_xwwl_npc);
                              }
                              else
                              {
                                    class2 = new MapClass
                                    {
                                          MapID = tbl_xwwl_npc.Rxjh_Map
                                    };
                                    class2.method_1(tbl_xwwl_npc);
                                    dictionary_12.Add(class2.MapID, class2);
                              }
                              tbl_xwwl_npc.method_5();
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(2, string.Concat(new object[] { "增加怪 [", int_229, "]出错：", exception }));
                  }
            }

            public static void smethod_22(int int_229, float float_2, float float_3, int int_230)
            {
                  try
                  {
                        TBL_XWWL_MONSTER tbl_xwwl_monster;
                        if (dictionary_13.TryGetValue(int_229, out tbl_xwwl_monster))
                        {
                              MapClass class2;
                              TBL_XWWL_NPC tbl_xwwl_npc = new TBL_XWWL_NPC
                              {
                                    FLD_PID = tbl_xwwl_monster.FLD_PID,
                                    Name = tbl_xwwl_monster.Name,
                                    Level = tbl_xwwl_monster.Level,
                                    Rxjh_Exp = tbl_xwwl_monster.Rxjh_Exp,
                                    Rxjh_X = float_2,
                                    Rxjh_Y = float_3,
                                    Rxjh_Z = 15f,
                                    Rxjh_cs_X = float_2,
                                    Rxjh_cs_Y = float_3,
                                    Rxjh_cs_Z = 15f,
                                    Rxjh_Map = int_230,
                                    IsNpc = 0,
                                    FLD_FACE1 = 0f,
                                    FLD_FACE2 = 0f,
                                    Max_Rxjh_HP = tbl_xwwl_monster.Rxjh_HP,
                                    Rxjh_HP = tbl_xwwl_monster.Rxjh_HP,
                                    FLD_AT = tbl_xwwl_monster.FLD_AT,
                                    FLD_DF = tbl_xwwl_monster.FLD_DF,
                                    FLD_AUTO = tbl_xwwl_monster.FLD_AUTO,
                                    FLD_BOSS = tbl_xwwl_monster.FLD_BOSS
                              };
                              if (dictionary_12.TryGetValue(tbl_xwwl_npc.Rxjh_Map, out class2))
                              {
                                    class2.method_1(tbl_xwwl_npc);
                              }
                              else
                              {
                                    class2 = new MapClass
                                    {
                                          MapID = tbl_xwwl_npc.Rxjh_Map
                                    };
                                    class2.method_1(tbl_xwwl_npc);
                                    dictionary_12.Add(class2.MapID, class2);
                              }
                              tbl_xwwl_npc.method_5();
                              DBA.smethod_7($"INSERT INTO TBL_XWWL_NPC(FLD_PID,FLD_X,FLD_Y,FLD_Z,FLD_FACE0,FLD_FACE,FLD_MID,FLD_NAME,FLD_HP,FLD_AT,FLD_DF,FLD_NPC,FLD_NEWTIME,FLD_LEVEL,FLD_EXP,FLD_AUTO,FLD_BOSS)VALUES ({tbl_xwwl_npc.FLD_PID},{float_2},{float_3},{15},{0},{0},{tbl_xwwl_npc.Rxjh_Map},'{tbl_xwwl_npc.Name}',{tbl_xwwl_npc.Max_Rxjh_HP},{tbl_xwwl_npc.FLD_AT},{tbl_xwwl_npc.FLD_DF},{0},{10},{tbl_xwwl_npc.Level},{tbl_xwwl_npc.Rxjh_Exp},{tbl_xwwl_npc.FLD_AUTO},{tbl_xwwl_npc.FLD_BOSS})", "PublicDb");
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(2, string.Concat(new object[] { "增加怪 [", int_229, "]出错：", exception }));
                  }
            }

            public static string smethod_25(string string_218, int int_229)
            {
                  if (string_218 == null)
                  {
                        return null;
                  }
                  if (string_218.Equals(""))
                  {
                        return "";
                  }
                  string str = "";
                  if (int_229 == 2)
                  {
                        int length = string_218.Length;
                        str = "";
                        int num2 = Convert.ToInt32(string_218.ToCharArray(0, 1)[0]) % 10;
                        for (int i = 2; i < length; i += 2)
                        {
                              string str2;
                              int num4 = Convert.ToInt32(string_218.ToCharArray(i, 1)[0]);
                              if ((Convert.ToInt32(string_218.ToCharArray(i - 1, 1)[0]) % 2) == 0)
                              {
                                    char ch = (char)((num4 + ((i - 1) / 2)) + num2);
                                    str2 = ch.ToString();
                              }
                              else
                              {
                                    str2 = ((char)((num4 - ((i - 1) / 2)) - num2)).ToString();
                              }
                              str = str + str2;
                        }
                  }
                  return str;
            }

            public static void smethod_4(string string_218)
            {
                  using (IEnumerator<Players> enumerator = allConnectedChars.Values.GetEnumerator())
                  {
                        while (enumerator.MoveNext())
                        {
                              Players current = enumerator.Current;
                        }
                  }
            }

            public static void smethod_5(int int_229, string string_218, int int_230, int int_231)
            {
                  using (IEnumerator<Players> enumerator = allConnectedChars.Values.GetEnumerator())
                  {
                        while (enumerator.MoveNext())
                        {
                              enumerator.Current.Reinforced_Announce(int_229, string_218, int_230, int_231);
                        }
                  }
            }

            public static void smethod_6()
            {
                  if (queue_2.Count > 0)
                  {
                        if (jlMsg == 1)
                        {
                              Form1.WriteLine(0, "Process狮子吼Queue()");
                        }
                        SU_TU_HONG_CLASS su_tu_hong_class = (SU_TU_HONG_CLASS)queue_2.Dequeue();
                        smethod_7(su_tu_hong_class.FLD_INDEX, su_tu_hong_class.UserName, su_tu_hong_class.TxtId, su_tu_hong_class.Txt);
                  }
            }

            public static void smethod_7(int int_229, string string_218, int int_230, string string_219)
            {
                  try
                  {
                        byte[] dst = Converter.hexStringToByte("AA55A6000000006600970000C8CEBDDC0000000000000000000000000000000000003000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000055AA");
                        dst[11] = 14;
                        byte[] bytes = Encoding.Default.GetBytes(string_218);
                        byte[] src = Encoding.Default.GetBytes(string_219);
                        Buffer.BlockCopy(src, 0, dst, 0x23, src.Length);
                        Buffer.BlockCopy(bytes, 0, dst, 12, bytes.Length);
                        Buffer.BlockCopy(BitConverter.GetBytes(int_229), 0, dst, 5, 2);
                        dst[0x22] = (byte)int_230;
                        foreach (Players players in allConnectedChars.Values)
                        {
                              if (players.Client != null)
                              {
                                    players.Client.Send(dst, dst.Length);
                              }
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, string.Concat(new object[] { "World发送狮子吼消息广播数据出错![", int_229, "]-[", string_218, "]-[", string_219, "]", exception.Message }));
                  }
            }

            public static void smethod_8(int int_229, string string_218, int int_230, string string_219, int int_231, int int_232)
            {
                  try
                  {
                        byte[] dst = Converter.hexStringToByte("AA55B300012C016600A400CC00000000000000000000000000000000000000000000310000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000055AA");
                        dst[11] = 0xcc;
                        Buffer.BlockCopy(BitConverter.GetBytes(int_231), 0, dst, 0xa7, 4);
                        Buffer.BlockCopy(BitConverter.GetBytes(int_232), 0, dst, 0xab, 4);
                        byte[] bytes = Encoding.Default.GetBytes(string_218);
                        byte[] src = Encoding.Default.GetBytes(string_219);
                        Buffer.BlockCopy(src, 0, dst, 0x23, src.Length);
                        Buffer.BlockCopy(bytes, 0, dst, 12, bytes.Length);
                        Buffer.BlockCopy(BitConverter.GetBytes(int_229), 0, dst, 5, 2);
                        dst[0x22] = (byte)int_230;
                        foreach (Players players in allConnectedChars.Values)
                        {
                              if (players.Client != null)
                              {
                                    players.Client.Send(dst, dst.Length);
                              }
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, string.Concat(new object[] { "World发送狮子吼消息广播数据出错![", int_229, "]-[", string_218, "]-[", string_219, "]", exception.Message }));
                  }
            }

            public static int smethod_9(TO_DOI_CLASS class25_0)
            {
                  int_39++;
                  W_TO_DOI.Add(int_39, class25_0);
                  return int_39;
            }

            private void WorldTimeEvent()
            {
                  if (jlMsg == 1)
                  {
                        Form1.WriteLine(0, "世界时间事件()");
                  }
                  if (TimeSystemSwitch != 0)
                  {
                        IEnumerator<Players> enumerator;
                        if (((DateTime.Now.Hour == 0) && (DateTime.Now.Second == 0)) && (DateTime.Now.Minute == 0))
                        {
                              using (enumerator = allConnectedChars.Values.GetEnumerator())
                              {
                                    while (enumerator.MoveNext())
                                    {
                                          enumerator.Current.ServerTime();
                                    }
                                    goto Label_08A1;
                              }
                        }
                        if (((DateTime.Now.Hour == 1) && (DateTime.Now.Second == 0)) && (DateTime.Now.Minute == 0))
                        {
                              using (enumerator = allConnectedChars.Values.GetEnumerator())
                              {
                                    while (enumerator.MoveNext())
                                    {
                                          enumerator.Current.ServerTime();
                                    }
                                    goto Label_08A1;
                              }
                        }
                        if (((DateTime.Now.Hour >= 2) && (DateTime.Now.Hour <= 4)) && ((DateTime.Now.Second == 0) && (DateTime.Now.Minute == 0)))
                        {
                              using (enumerator = allConnectedChars.Values.GetEnumerator())
                              {
                                    while (enumerator.MoveNext())
                                    {
                                          enumerator.Current.ServerTime();
                                    }
                                    goto Label_08A1;
                              }
                        }
                        if (((DateTime.Now.Hour == 5) && (DateTime.Now.Second == 0)) && (DateTime.Now.Minute == 0))
                        {
                              using (enumerator = allConnectedChars.Values.GetEnumerator())
                              {
                                    while (enumerator.MoveNext())
                                    {
                                          enumerator.Current.ServerTime();
                                    }
                                    goto Label_08A1;
                              }
                        }
                        if (((DateTime.Now.Hour == 6) && (DateTime.Now.Second == 0)) && (DateTime.Now.Minute == 0))
                        {
                              using (enumerator = allConnectedChars.Values.GetEnumerator())
                              {
                                    while (enumerator.MoveNext())
                                    {
                                          enumerator.Current.ServerTime();
                                    }
                                    goto Label_08A1;
                              }
                        }
                        if (((DateTime.Now.Hour == 7) && (DateTime.Now.Second == 0)) && (DateTime.Now.Minute == 0))
                        {
                              using (enumerator = allConnectedChars.Values.GetEnumerator())
                              {
                                    while (enumerator.MoveNext())
                                    {
                                          enumerator.Current.ServerTime();
                                    }
                                    goto Label_08A1;
                              }
                        }
                        if (((DateTime.Now.Hour == 8) && (DateTime.Now.Second == 0)) && (DateTime.Now.Minute == 0))
                        {
                              using (enumerator = allConnectedChars.Values.GetEnumerator())
                              {
                                    while (enumerator.MoveNext())
                                    {
                                          enumerator.Current.ServerTime();
                                    }
                                    goto Label_08A1;
                              }
                        }
                        if (((DateTime.Now.Hour == 9) && (DateTime.Now.Second == 0)) && (DateTime.Now.Minute == 0))
                        {
                              using (enumerator = allConnectedChars.Values.GetEnumerator())
                              {
                                    while (enumerator.MoveNext())
                                    {
                                          enumerator.Current.ServerTime();
                                    }
                                    goto Label_08A1;
                              }
                        }
                        if (((DateTime.Now.Hour == 10) && (DateTime.Now.Second == 0)) && (DateTime.Now.Minute == 0))
                        {
                              using (enumerator = allConnectedChars.Values.GetEnumerator())
                              {
                                    while (enumerator.MoveNext())
                                    {
                                          enumerator.Current.ServerTime();
                                    }
                                    goto Label_08A1;
                              }
                        }
                        if (((DateTime.Now.Hour == 11) && (DateTime.Now.Second == 0)) && (DateTime.Now.Minute == 0))
                        {
                              using (enumerator = allConnectedChars.Values.GetEnumerator())
                              {
                                    while (enumerator.MoveNext())
                                    {
                                          enumerator.Current.ServerTime();
                                    }
                                    goto Label_08A1;
                              }
                        }
                        if (((DateTime.Now.Hour == 12) && (DateTime.Now.Second == 0)) && (DateTime.Now.Minute == 0))
                        {
                              using (enumerator = allConnectedChars.Values.GetEnumerator())
                              {
                                    while (enumerator.MoveNext())
                                    {
                                          enumerator.Current.ServerTime();
                                    }
                                    goto Label_08A1;
                              }
                        }
                        if (((DateTime.Now.Hour == 13) && (DateTime.Now.Second == 0)) && (DateTime.Now.Minute == 0))
                        {
                              using (enumerator = allConnectedChars.Values.GetEnumerator())
                              {
                                    while (enumerator.MoveNext())
                                    {
                                          enumerator.Current.ServerTime();
                                    }
                                    goto Label_08A1;
                              }
                        }
                        if (((DateTime.Now.Hour == 14) && (DateTime.Now.Second == 0)) && (DateTime.Now.Minute == 0))
                        {
                              using (enumerator = allConnectedChars.Values.GetEnumerator())
                              {
                                    while (enumerator.MoveNext())
                                    {
                                          enumerator.Current.ServerTime();
                                    }
                                    goto Label_08A1;
                              }
                        }
                        if (((DateTime.Now.Hour == 15) && (DateTime.Now.Second == 0)) && (DateTime.Now.Minute == 0))
                        {
                              using (enumerator = allConnectedChars.Values.GetEnumerator())
                              {
                                    while (enumerator.MoveNext())
                                    {
                                          enumerator.Current.ServerTime();
                                    }
                                    goto Label_08A1;
                              }
                        }
                        if (((DateTime.Now.Hour == 0x10) && (DateTime.Now.Second == 0)) && (DateTime.Now.Minute == 0))
                        {
                              using (enumerator = allConnectedChars.Values.GetEnumerator())
                              {
                                    while (enumerator.MoveNext())
                                    {
                                          enumerator.Current.ServerTime();
                                    }
                                    goto Label_08A1;
                              }
                        }
                        if (((DateTime.Now.Hour == 0x11) && (DateTime.Now.Second == 0)) && (DateTime.Now.Minute == 0))
                        {
                              using (enumerator = allConnectedChars.Values.GetEnumerator())
                              {
                                    while (enumerator.MoveNext())
                                    {
                                          enumerator.Current.ServerTime();
                                    }
                                    goto Label_08A1;
                              }
                        }
                        if (((DateTime.Now.Hour == 0x12) && (DateTime.Now.Second == 0)) && (DateTime.Now.Minute == 0))
                        {
                              using (enumerator = allConnectedChars.Values.GetEnumerator())
                              {
                                    while (enumerator.MoveNext())
                                    {
                                          enumerator.Current.ServerTime();
                                    }
                                    goto Label_08A1;
                              }
                        }
                        if (((DateTime.Now.Hour == 0x13) && (DateTime.Now.Second == 0)) && (DateTime.Now.Minute == 0))
                        {
                              using (enumerator = allConnectedChars.Values.GetEnumerator())
                              {
                                    while (enumerator.MoveNext())
                                    {
                                          enumerator.Current.ServerTime();
                                    }
                                    goto Label_08A1;
                              }
                        }
                        if (((DateTime.Now.Hour == 20) && (DateTime.Now.Second == 0)) && (DateTime.Now.Minute == 0))
                        {
                              using (enumerator = allConnectedChars.Values.GetEnumerator())
                              {
                                    while (enumerator.MoveNext())
                                    {
                                          enumerator.Current.ServerTime();
                                    }
                                    goto Label_08A1;
                              }
                        }
                        if (((DateTime.Now.Hour == 0x15) && (DateTime.Now.Second == 0)) && (DateTime.Now.Minute == 0))
                        {
                              using (enumerator = allConnectedChars.Values.GetEnumerator())
                              {
                                    while (enumerator.MoveNext())
                                    {
                                          enumerator.Current.ServerTime();
                                    }
                                    goto Label_08A1;
                              }
                        }
                        if (((DateTime.Now.Hour == 0x16) && (DateTime.Now.Second == 0)) && (DateTime.Now.Minute == 0))
                        {
                              using (enumerator = allConnectedChars.Values.GetEnumerator())
                              {
                                    while (enumerator.MoveNext())
                                    {
                                          enumerator.Current.ServerTime();
                                    }
                                    goto Label_08A1;
                              }
                        }
                        if (((DateTime.Now.Hour == 0x17) && (DateTime.Now.Second == 0)) && (DateTime.Now.Minute == 0))
                        {
                              using (enumerator = allConnectedChars.Values.GetEnumerator())
                              {
                                    while (enumerator.MoveNext())
                                    {
                                          enumerator.Current.ServerTime();
                                    }
                              }
                        }
                  }
                  Label_08A1:
                  foreach (Players players in allConnectedChars.Values)
                  {
                        if ((players.VO_HUAN_CAP_8_DOAN_THOI_GIAN <= DateTime.Now) && (players.VO_HUAN_CAP_8_CO_HAY_KHONG_MO_RA == 1))
                        {
                              players.UpdatePowersAndStatus();
                              players.TINH_TOAN_VO_HUAN_CAP_8(0);
                              players.Update_Figure_Data(players);
                              players.Update_Data_Boardcast();
                        }
                  }
                  if (DateTime.Now.Hour == 0x17)
                  {
                        foreach (Players players2 in allConnectedChars.Values)
                        {
                              if (players2.Player_MaxWx >= 0)
                              {
                                    players2.Player_MaxWx = 0;
                                    players2.UpdatePowersAndStatus();
                                    players2.LUU_NHAN_VAT_SO_LIEU();
                              }
                              DBA.smethod_7(string.Format("UPDATE TBL_XWWL_CHAR SET FLD_GETWX = 0 WHERE FLD_GETWX >= 0", players2.Player_MaxWx), "rxjhgame");
                        }
                  }
                  if ((((ForceOfWar_Switch == 1) && (DateTime.Now.Hour == OpenWarTime_Hour)) && ((DateTime.Now.Minute == OpenWarTime_Min) && (DateTime.Now.Second == OpenWarTime_Sec))) && (eve == null))
                  {
                        eve = new EventClass();
                        foreach (Players players3 in allConnectedChars.Values)
                        {
                              if (players3.Player_FLD_JOB_LEVEL >= 2)
                              {
                                    players3.SendCountdown(1, 1, 0);
                              }
                        }
                  }
                  foreach (BANG_CHIEN_STRING bang_chien_string in dictionary_25.Values)
                  {
                        using (Dictionary<int, BANG_CHIEN_STRING>.ValueCollection.Enumerator enumerator3 = dictionary_25.Values.GetEnumerator())
                        {
                              object[] objArray1;
                              BANG_CHIEN_STRING current;
                              while (enumerator3.MoveNext())
                              {
                                    current = enumerator3.Current;
                                    if (((bang_chien_string.int_0 != current.int_0) && (bang_chien_string.int_1 == current.int_1)) && (class11_0 == null))
                                    {
                                          goto Label_0A87;
                                    }
                              }
                              continue;
                              Label_0A87:
                              objArray1 = new object[] { "申请成功 ", bang_chien_string.int_0, "和", current.int_0 };
                              Console.WriteLine(string.Concat(objArray1));
                              Form1.WriteLine(0x58, string.Concat(new object[] {
                        "帮战配对成功 地图ID", bang_chien_string.int_1, " 帮派ID:", bang_chien_string.int_0, " 帮派名字:", bang_chien_string.string_0, " 帮主:", bang_chien_string.string_1, " 人数:", bang_chien_string.dictionary_0.Count, " ------ 帮派ID:", current.int_0, " 帮派名字:", current.string_0, " 帮主:", current.string_1,
                        "人数:", current.dictionary_0.Count
                    }));
                              class11_0 = new BANG_CHIEN_THIET_LAP(bang_chien_string, current);
                              dictionary_25.Remove(bang_chien_string.int_0);
                              dictionary_25.Remove(current.int_0);
                              break;
                        }
                  }
            }

            private static void ZYDNGuard()
            {
                  Nhan_vat_dang_cap_cao_nhat = 0xff;
                  Khu_an_toan_ban_do = 0x65;
                  Khu_an_toan_X_toa_do = 500f;
                  Khu_an_toan_Y_toa_do = 1550f;
                  double_0 = 5.0;
                  double_1 = 0.0;
                  string_0 = "";
                  bool_0 = false;
                  Key = "192.168.0.4";
                  Key2 = "192.168.0.4";
                  AllItmelog = 1;
                  bool_1 = true;
                  bool_2 = false;
                  dictionary_0 = new Dictionary<int, ITEMSELL>();
                  dictionary_1 = new Dictionary<int, TRANG_BI_DO_LUONG>();
                  dictionary_2 = new Dictionary<string, VUOT_AI_BAN_DO>();
                  dictionary_3 = new Dictionary<int, BoxtoGoldClass>();
                  dictionary_4 = new Dictionary<int, DA_THUOC_TINH_HIEU_QUA>();
                  threadSafeDictionary_0 = new ThreadSafeDictionary<int, NetState>();
                  EventTop = new Dictionary<string, EventTopClass>();
                  allConnectedChars = new ThreadSafeDictionary<int, Players>();
                  dictionary_6 = new Dictionary<int, KHI_CONG_THANG_THIEN>();
                  dictionary_7 = new Dictionary<string, DBClass>();
                  threadSafeDictionary_2 = new ThreadSafeDictionary<int, ClientIpAddress>();
                  queue_0 = Queue.Synchronized(new Queue());
                  queue_1 = Queue.Synchronized(new Queue());
                  dictionary_12 = new Dictionary<int, MapClass>();
                  dictionary_15 = new Dictionary<int, DINH_NGHIA_CHUYEN_CHUC_THUOC_TINH>();
                  dictionary_16 = new Dictionary<int, DANG_CAP_KHEN_THUONG>();
                  dictionary_17 = new Dictionary<int, HE_THONG_CHAM_CONG_KHEN_THUONG_CLASS>();
                  dictionary_18 = new Dictionary<int, TRUC_TUYEN_THOI_GIAN_KHEN_THUONG>();
                  dictionary_19 = new Dictionary<int, CHUYEN_SINH_SO_LAN_KHEN_THUONG>();
                  dictionary_20 = new Dictionary<int, ITEM_TRAO_DOI>();
                  dictionary_21 = new Dictionary<int, GIET_NGUOI_NHAC_NHO>();
                  dictionary_25 = new Dictionary<int, BANG_CHIEN_STRING>();
                  list_0 = new List<Players>();
                  dictionary_27 = new Dictionary<int, Class67>();
                  list_9 = new List<TBL_XWWL_DROP>();
                  Script = 0;
                  Tinh_nhan_mo_ra = 0;
                  int_5 = 0x58;
                  Thang_thien_skill_Dang_cap_bo_tro = 3;
                  Job_Level = 2;
                  Phu_the_skill_tu_luyen_Dang_cap = 80;
                  Phan_mem_hack_PK_switch = 0;
                  Costume1 = 0;
                  Costume2 = 0;
                  AutGC = 0;
                  double_2 = 0.0;
                  double_3 = 0.0;
                  list_16 = new List<object>();
                  dateTime_0 = DateTime.Now;
                  Game_landing_port_maximum_number_of_connections = 20;
                  Tro_choi_do_bo_cang_lon_nhat_lien_tiep_Thoi_gian_so = 0x3e8;
                  Kiem_tra_phi_phap_Item = 0;
                  Kiem_tra_phi_phap_Item_thao_tac = 3;
                  Kiem_tra_Troi_chat_phi_phap_Item = false;
                  Item_cao_nhat_Cong_kich_gia_tri = 0;
                  Item_cao_nhat_Phong_ngu_gia_tri = 0;
                  Item_cao_nhat_Sinh_menh_gia_tri = 0;
                  Item_cao_nhat_Noi_cong_gia_tri = 0;
                  Item_cao_nhat_Trung_muc_tieu_gia_tri = 0;
                  Item_cao_nhat_Ne_tranh_gia_tri = 0;
                  Item_cao_nhat_vo_cong_gia_tri = 0;
                  Item_cao_nhat_khi_cong_gia_tri = 0;
                  Item_cao_nhat_hop_thanh_gia_tri = 0;
                  Login_thuoc_tinh_nhac_nho_mo_ra = 0;
                  Trang_phuc_gui_di_mo_ra = 0;
                  Phat_ngon_dang_cap = 0;
                  DANG_NHAP_GHI_CHEP = 0;
                  Ghi_chep_bao_ton_Thang_thien = 30;
                  IP_closure = true;
                  list_17 = new List<IPAddress>();
                  Tu_dong_lien_tiep_Thoi_gian = 10;
                  Phien_ban_nghiem_chung_Thoi_gian = 0x2710;
                  bool_5 = false;
                  Automatically_open_connection = true;
                  Disconnect = true;
                  Join_filter_list = true;
                  Close_connection = true;
                  WorldTime = 0;
                  TimeSystemSwitch = 1;
                  trang_bi_Vo_huan_sua_chua_tieu_hao_Vo_huan_so_luong = 0;
                  int_39 = 1;
                  int_40 = 1;
                  int_41 = 3;
                  int_42 = 0;
                  jlMsg = 0;
                  bool_10 = false;
                  THE_LUC_CHIEN_2_TIEN_TRINH = 0;
                  THE_LUC_CHIEN_2_THOI_GIAN = 0;
                  THE_LUC_CHIEN_2_CHINH_PHAI_DIEM_SO = 0;
                  THE_LUC_CHIEN_2_TA_PHAI_DIEM_SO = 0;
                  THE_LUC_CHIEN_2_CHINH_PHAI_SO_NGUOI = 0;
                  THE_LUC_CHIEN_TA_PHAI_SO_NGUOI = 0;
                  ForceOfWar_Switch = 0;
                  OpenWarTime_Hour = 0;
                  OpenWarTime_Min = 0;
                  OpenWarTime_Sec = 0;
                  Co_hay_khong_bat_dau_dung_di_thuong_xuat_huyet = 0;
                  DestroyMonsterScriptUSE = 0;
                  AtPort = 0xdaac;
                  SMS_payments_whether_to_open = "0";
                  SMS_server_WEBID = "0";
                  SMS_service_number = "0";
                  SMS_channel_number = "0";
                  Dang_ky_mon_phai_can_Dang_cap = 60;
                  Dang_ky_mon_phai_can_tien_bac = 0xf4240;
                  Dang_ky_mon_phai_can_thiet_Item_ID = "";
                  Cach_tuyen_Treo_thiet_bi_can_thiet_item_ID = "";
                  Nhan_khac_chu_can_vang = 0x989680;
                  Phong_ngu_truy_sat_can_thiet_Item_ID = "";
                  Lan_theo_player_can_CASH_so_luong = 0x186a0L;
                  Truy_sat_he_thong_co_hay_khong_mo_ra = 0;
                  Player_lan_theo_menh_lenh = "!追杀";
                  Number_lock_ingot = 0;
                  Unlock_ingot_number = 0;
                  CASH_hop_thanh = 5;
                  int_86 = 20;
                  int_87 = 5;
                  KHI_CONG_TI_LE_PHAN_TRAM = 1.0;
                  THIEN_HUU_CHI_KHI_TI_LE_PHAN_TRAM = 1.0;
                  VO_KIEN_BAT_TOI_TY_LE_TANG_CUONG = 0.0;
                  THUA_THANG_TRUY_KICH_TY_LE_TANG_CUONG = 0.0;
                  SO_KHI_CONG_TANG_TOI_DA = 0;
                  long_3 = 0x2540be400L;
                  Co_hay_khong_mo_ra_cua_hang_CASH = 0;
                  Cho_phep_item_ban_ra_lon_nhat_CASH_so_luong = 0x186a0;
                  double_8 = 0.0;
                  double_9 = 0.0;
                  double_10 = 0.0;
                  VIP_Kinh_nghiem_boi_so_ti_le_phan_tram = 0.3;
                  VIP_ky_nang_boi_so_ti_le_phan_tram = 0.3;
                  Kinh_nghiem_boi_so = 100;
                  Hap_hon_xac_suat = 70;
                  Hap_hon_mo_ra = 0;
                  Hap_hon_tuy_theo_so_luong = "1;3";
                  To_doi_Cap_bac_han_che = 0;
                  Kiem_tra_trang_bi_Cap_bac_han_che = 0;
                  Tien_boi_so = 580;
                  Ky_nang_boi_so = 80;
                  Thang_thien_kinh_nghiem_boi_so = 80.0;
                  The_rate_of_violence = 800;
                  Hop_thanh_xac_xuat_khong_che = "0;100";
                  Da_Luc_cong_kich_Vo_cong_hop_thanh_xac_xuat_khong_che = "0;100";
                  Cuong_hoa_xac_xuat_khong_che = "60;160";
                  Da_Vo_cong_phong_ngu_hop_thanh_xac_xuat_khong_che = "0;100";
                  Da_Suc_phong_ngu_hop_thanh_xac_xuat_khong_che = "0;100";
                  KIEM_KHACH_HOI_LIEU_THAN_PHAP_NE_TRANH_TY_LE = 0.001;
                  KIEM_KHACH_HOI_LIEU_THAN_PHAP_VO_CONG_UY_LUC = 0.006;
                  THICH_KHACH_TAM_HOA_TU_DINH_TY_LE_TANG_CUONG = 0.001;
                  THICH_KHACH_LIEN_HOAN_PHI_VU_UY_LUC = 1.2;
                  THUONG_KHACH_CAN_KHON_NA_DI_VO_CONG_UY_LUC = 0.01;
                  THICH_KHACH_TAT_SAT_NHAT_KICH_UY_LUC = 1.2;
                  THICH_KHACH_TAM_THAN_NGUNG_TU_UY_LUC = 1.3;
                  CUNG_THU_VO_MINH_AM_THI_TY_LE = 0.0;
                  CUNG_THU_TRI_MENH_TUYET_SAT_TY_LE = 0.0;
                  Hop_thanh_xac_xuat = 0.0;
                  VIP_Hop_thanh_xac_xuat = 0.0;
                  Phu_hon_hop_thanh_xac_xuat_tang_cuong = 0.0;
                  Bach_bao_cac_dia_chi = "http://bbg.xwwl.net/login.aspx?server=1";
                  string_42 = "127.0.0.1";
                  Babolat_Club_server_port = 0x2329;
                  Ao_choang_cuong_hoa_tong_xac_suat = "20;180";
                  Ao_choang_cuong_hoa_1_giai_doan_xac_suat = 1.1;
                  Ao_choang_cuong_hoa_2_giai_doan_xac_suat = 1.1;
                  Ao_choang_cuong_hoa_3_giai_doan_xac_suat = 1.1;
                  Ao_choang_cuong_hoa_4_giai_doan_xac_suat = 1.1;
                  Ao_choang_cuong_hoa_5_giai_doan_xac_suat = 1.1;
                  Ao_choang_cuong_hoa_6_giai_doan_xac_suat = 1.1;
                  Ao_choang_cuong_hoa_7_giai_doan_xac_suat = 1.1;
                  Account_authentication_server_IP = "127.0.0.1";
                  Account_authentication_server_port = 0xdaa2;
                  Game_server_port = 0x32c9;
                  int_105 = 0x32c9;
                  Version_switch = 0;
                  KHI_CONG_CO_TAC_DUNG = 1;
                  Co_hay_khong_mo_ra_ao_choang_cuong_hoa = 0;
                  vip_line = 0;
                  Khu_an_toan_mo_ra = 1;
                  Maximum_Online = 100;
                  Server_Group_ID = 1;
                  Server_ID = 0;
                  ServerName = "YULGANG.VN";
                  Server_Name_2 = "热血江湖";
                  Enter_Bulletin = "欢迎光临创新意江湖，本江湖网址http://rxjh.xwwl.net,打 !help 查看自定义命令";
                  Mo_hop_ra_CASH = "";
                  Replace_Text_Filter = "热血江湖";
                  Chuyen_sinh_menh_lenh = "!转生";
                  Cau_hon_menh_lenh = "!求婚";
                  Ly_hon_menh_lenh = "!离婚";
                  TUMMA = "!TUMMA";
                  ATUM = "!ATUM";
                  DELBAD = "!aichotaoluongthien";
                  POINT = "!POINT";
                  BACK = "!BACK";
                  DEL1 = "!DEL1";
                  REPRAN = "!REPRAN";
                  CH = "!CH";
                  UPGRADE = "!UPGRADE";
                  REZIAN = "!REZIAN";
                  Kiem_tra_thoi_gian_menh_lenh = "!在线时间";
                  Phu_hon_menh_lenh = "!附魂";
                  Thanh_ly_ba_lo_menh_lenh = "!清理背包";
                  Self_help_command_card = "!卡号自救";
                  Thanh_ly_troi_chat_ba_lo_menh_lenh = "!清理绑定背包";
                  Kiem_tra_tin_tuc_menh_lenh = "!信息";
                  Thang_cap_thanh_vien_menh_lenh = "!升级会员";
                  Di_dong_menh_lenh = "!移动";
                  Co_hay_khong_mo_ra_cach_tuyen_Treo_thiet_bi = 0;
                  Cach_tuyen_Treo_thiet_bi_ban_do = 0x65;
                  Cach_tuyen_Treo_thiet_Dang_cap = 100;
                  Cach_tuyen_Treo_thiet_bi_menh_lenh = "!离线挂机";
                  Co_hay_khong_mo_ra_an_toan_hinh_thuc = 0;
                  Thoi_gian_an_toan_bat_dau = 0;
                  Thoi_gian_an_toan_ket_thuc = 0;
                  An_toan_hinh_thuc_tieu_hao_CASH = 0;
                  Mot_minh_dau_mo_ra_menh_lenh = "!单挑去";
                  Khieu_chien_tham_gia_menh_lenh = "!整你去";
                  Gui_di_khieu_chien_thu_tuc_menh_lenh = "!挑战信息";
                  Gui_di_khieu_chien_thu_tuc_menh_lenh_can_CASH = 0;
                  Khieu_chien_ban_do_toa_do_X = 0;
                  Khieu_chien_ban_do_toa_do_Y = 0;
                  Khieu_chien_ban_do_so_hieu = 0;
                  Ca_nhan_khieu_chien_co_hay_khong_mo_ra = 0;
                  Khieu_chien_xin_can_thiet_CASH_So_luong = 0;
                  Khieu_chien_he_thong_thu_ve_CASH_So_luong = 0;
                  Khieu_chien_la_to_noi_dung_1 = "{0}发起挑衅";
                  Khieu_chien_la_to_noi_dung_2 = "{0}发起挑衅";
                  Khieu_chien_la_to_noi_dung_3 = "{0}发起挑衅";
                  Chap_nhan_khieu_chien_la_to_noi_dung_1 = "{0}发起挑衅";
                  Chap_nhan_khieu_chien_la_to_noi_dung_2 = "{0}发起挑衅";
                  Chap_nhan_khieu_chien_la_to_noi_dung_3 = "{0}发起挑衅";
                  int_129 = 0;
                  queue_2 = Queue.Synchronized(new Queue());
                  The_maximum_number_of_Idiom = 100;
                  Co_hay_khong_ma_hoa = 1;
                  int_132 = 0;
                  BackPack_Switch = 0;
                  Vo_cong_Phong_ngu_suc_manh_khong_che = 100;
                  Vo_cong_Cong_kich_suc_manh_khong_che = 100;
                  PK_khoang_cach_khong_che_co_hay_khong_mo_ra = 1;
                  Nhan_vat_trinh_dien_nghe_nghiep_Cong_kich_khoang_cach = 80;
                  Nhan_vat_gan_nguoi_nghe_nghiep_cong_kich_khoang_cach = 50;
                  Danh_quai_khoang_cach_khong_che_co_hay_khong_mo_ra = 1;
                  Quai_vat_trinh_dien_nghe_nghiep_Cong_kich_khoang_cach = 80;
                  Quai_vat_gan_nguoi_nghe_nghiep_Cong_kich_khoang_cach = 50;
                  PK_Dang_cap_chenh_lech = 15;
                  Co_hay_khong_mo_ra_Vo_huan_he_thong = 0;
                  Vo_huan_gioi_han_nhan_duoc = 0x4e20;
                  Tu_vong_kinh_nghiem_roi_xuong_co_hay_khong_mo_ra = 0;
                  Vo_huan_bao_ve_Dang_cap = 80;
                  Tu_vong_giam_thieu_Vo_huan_So_luong = "0;0;0;0;0;0";
                  He_thong_thu_ve_So_luong = "0;0;0;0;0;0";
                  Han_che_PK_tam_khoang_cach = 40.0;
                  Restrictions_meditation_distance = 60.0;
                  Empty_distance = 60.0;
                  Packet_title = 0;
                  PKSwitch = 0;
                  Boi_toan_tieu_hao_CASH = 50;
                  Vip_Login_thong_cao = 0;
                  Vip_Login_thong_cao_noi_dung = "尊贵的VIP玩家{0}上线了！大家欢迎！";
                  Ngoi_tu_giet_nguoi_thong_cao = "{0}杀人啦！";
                  Ngoi_tu_tha_ra_thong_cao = "{0}刑满释放了！";
                  Trusted_Connection_IP = "";
                  Cho_phep_mo_nhieu_So_luong = 2;
                  VIP_ban_do = "";
                  Vuot_cua_ai_ban_do = "";
                  SqlJl = "";
                  CASH_do_luong = 0;
                  int_196 = 0x24;
                  Tu_dong_luu_tru = 1;
                  Cong_kich_Xac_nhan_hinh_thuc = 0;
                  Vo_cong_phong_ngu_hinh_thuc = 0;
                  int_209 = 3;
                  Toc_do_do_luong_thao_tac = 0;
                  Toc_do_do_luong_mo_ra = 0;
                  Gia_toc_khi_do_luong_Thoi_gian_tieu_diet = 0x1388;
                  int_213 = 0xea60;
                  Sung_vat_Cong_kich_suc_manh_boi_so = 2;
                  Item_Exchange_LUA_script_is_open = 0;
                  dictionary_28 = new Dictionary<string, Class53>();
                  dictionary_29 = new Dictionary<int, CHE_TAO_ITEM_DANH_SACH>();
                  thietlappvp = 0;
                  try
                  {
                        dictionary_26 = new Dictionary<int, TRANG_PHUC_DANH_SACH>();
                        list_1 = new List<TRANG_PHUC_THUOC_TINH>();
                        list_6 = new List<XWWL_kill>();
                        W_TO_DOI = new Dictionary<int, TO_DOI_CLASS>();
                        dictionary_24 = new Dictionary<int, TO_DOI_LOAI>();
                        dictionary_4 = new Dictionary<int, DA_THUOC_TINH_HIEU_QUA>();
                        dictionary_10 = new Dictionary<int, TBL_XWWL_Gg>();
                        lever = new Dictionary<int, double>();
                        dictionary_9 = new Dictionary<int, double>();
                        Itme = new Dictionary<int, TBL_XWWL_ITEM>();
                        dictionary_16 = new Dictionary<int, DANG_CAP_KHEN_THUONG>();
                        dictionary_17 = new Dictionary<int, HE_THONG_CHAM_CONG_KHEN_THUONG_CLASS>();
                        dictionary_18 = new Dictionary<int, TRUC_TUYEN_THOI_GIAN_KHEN_THUONG>();
                        dictionary_19 = new Dictionary<int, CHUYEN_SINH_SO_LAN_KHEN_THUONG>();
                        dictionary_21 = new Dictionary<int, GIET_NGUOI_NHAC_NHO>();
                        dictionary_20 = new Dictionary<int, ITEM_TRAO_DOI>();
                        dictionary_15 = new Dictionary<int, DINH_NGHIA_CHUYEN_CHUC_THUOC_TINH>();
                        threadSafeDictionary_3 = new ThreadSafeDictionary<long, MAT_DAT_ITEM_LOAI>();
                        TBL_KONGFU = new Dictionary<int, TBL_XWWL_KONGFU>();
                        dictionary_13 = new Dictionary<int, TBL_XWWL_MONSTER>();
                        list_5 = new List<XWWL_JC>();
                        list_11 = new List<TBL_XWWL_DROP>();
                        list_7 = new List<TBL_XWWL_NPC_DROP>();
                        list_8 = new List<TBL_XWWL_DROP>();
                        list_10 = new List<TBL_XWWL_DROP>();
                        list_12 = new List<TBL_XWWL_OPEN>();
                        list_4 = new List<TBL_XWWL_SELL>();
                        list_13 = new List<TBL_XWWL_VOME>();
                        list_15 = new List<TBL_XWWL_MAP>();
                        list_14 = new List<TBL_XWWL_MAP>();
                        list_2 = new List<Players>();
                        list_3 = new List<Players>();                        
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(100, "系统错误:World" + exception);
                  }
            }
      }
}

