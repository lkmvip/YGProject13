using LuaInterface;
using ns11;
using ns13;
using ns3;
using ns6;
using ns9;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace RxjhServer
{
	public class ScriptClass
	{
		public Lua pLuaVM;

		public LuaFunction MO_RA_VAT_PHAM_SU_KIEM;

		public LuaFunction QUAI_VAT_TU_VONG_SU_KIEN;

		public Dictionary<int, LuaFunction> QUAI_VAT_TU_VONG_DANH_SACH_SU_KIEN = new Dictionary<int, LuaFunction>();

		public string KICH_BAN_GOC_MUC_LUC = "script";

		public Dictionary<int, LuaFunction> NHIEM_VU_SU_KIEN_DANH_SACH = new Dictionary<int, LuaFunction>();

		public LuaFunction VAT_PHAM_TRAO_DOI_SU_KIEN;

            public LuaFunction MoveQuestMapScript;

            public ScriptClass()
		{
			this.DANG_KY_KICH_BAN_API();
			this.KICH_BAN_GOC_MUC_LUC = string.Concat(Application.StartupPath, "\\Script");
			this.GetUrlDirectory(this.KICH_BAN_GOC_MUC_LUC);
			Form1.WriteLine(2, "Quest Script Load Success");
			this.DANG_KY_SU_KIEN();
		}

		public void CAP_NHAT_HP_MP_HP(int UserWorldId)
		{
			Players player;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				player.UpdateHP_MP_SP();
			}
		}

		public void CAP_NHAT_KINH_NGHIEM_VA_KN_SKILL(int UserWorldId)
		{
			Players player;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
                        player.UpdateExperience();
			}
		}

            // 퀘스트 경험치 업데이트
            public void UpdateEXP(int UserWorldId, int exp)
            {
                  Players player;
                  if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
                  {
                        player.NHAN_VAT_KINH_NGHIEM = player.NHAN_VAT_KINH_NGHIEM + exp;
                        player.BasicCharacterData();
                        player.UpdateHP_MP_SP();
                        player.UpdatePowersAndStatus();
                        player.UpdateExperience();
                        player.UpdateMoneyAndWeight();
                        player.Update_Qigong();
                  }
            }

		public void CAP_NHAT_NHAN_VAT_SO_LIEU(int UserWorldId)
		{
			Players player;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				player.LUU_NHAN_VAT_SO_LIEU();
			}
		}

		public void CAP_NHAT_TIEN_BAC_VA_MANG_NANG(int UserWorldId)
		{
			Players player;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				player.UpdateMoneyAndWeight();
			}
		}

            public void UpdateMoneyScript(int UserWorldId, long _money)
            {
                  Players player;
                  if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
                  {
                        player.Player_Money = player.Player_Money + _money;
                        player.UpdateMoneyAndWeight();
                  }
            }

            public void CAP_NHAT_VO_CONG_VA_TRANG_THAI(int UserWorldId)
		{
			Players player;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				player.UpdatePowersAndStatus();
			}
		}

		public void DAM_HOA_LIEN_CHUYEN_CHUC(int UserWorldId)
		{
			Players player;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				player.HarinAddWeapon();
			}
		}

		public void DANG_KY_KICH_BAN_API()
		{
			try
			{
				this.pLuaVM = new Lua();
				this.pLuaVM.RegisterFunction("SendMissionMsg", this, this.GetType().GetMethod("NHIEM_VU_NHAC_NHO_SO_LIEU_GUI_DI")).ToString();
				this.pLuaVM.RegisterFunction("SendSysMsg", this, this.GetType().GetMethod("GOI_Y_HE_THONG"));
				this.pLuaVM.RegisterFunction("SendKongfuMsg", this, this.GetType().GetMethod("HOC_SKILL_NHAC_NHO"));
				this.pLuaVM.RegisterFunction("SendNoticeMsg", this, this.GetType().GetMethod("GUI_DI_THONG_BAO"));
				this.pLuaVM.RegisterFunction("AddQuest", this, this.GetType().GetMethod("THIET_LAP_NHIEM_VU_SO_LIEU"));
				this.pLuaVM.RegisterFunction("AddMission", this, this.GetType().GetMethod("THIET_LAP_NHIEM_VU_SO_LIEU"));
				this.pLuaVM.RegisterFunction("AddStKongfu", this, this.GetType().GetMethod("HOC_THANG_THIEN_VO_CONG_SACH"));
				this.pLuaVM.RegisterFunction("AddQigong", this, this.GetType().GetMethod("HOC_KHI_CONG_MOI"));
				this.pLuaVM.RegisterFunction("AddSkill", this, this.GetType().GetMethod("HOC_SKILL"));
				this.pLuaVM.RegisterFunction("AddSkillBook6", this, this.GetType().GetMethod("GUI_DI_CHUYEN_CHUC_6_SACH_SKILL"));
				this.pLuaVM.RegisterFunction("AddSkillBook7", this, this.GetType().GetMethod("GUI_DI_CHUYEN_CHUC_7_SACH_SKILL"));
				this.pLuaVM.RegisterFunction("AddSkillBook8", this, this.GetType().GetMethod("GUI_DI_CHUYEN_CHUC_8_SACH_SKILL"));
				this.pLuaVM.RegisterFunction("AddSkillBook9", this, this.GetType().GetMethod("GUI_DI_CHUYEN_CHUC_9_SACH_SKILL"));
				this.pLuaVM.RegisterFunction("AddItme", this, this.GetType().GetMethod("TANG_CUONG_VAT_PHAMScript"));
				this.pLuaVM.RegisterFunction("AddItmeProp", this, this.GetType().GetMethod("TANG_CUONG_VAT_PHAM_MANG_THUOC_TINH"));
				this.pLuaVM.RegisterFunction("AddItmePropts", this, this.GetType().GetMethod("TANG_CUONG_VAT_PHAM_MANG_THUOC_TINH_THANG_THIEN"));
				this.pLuaVM.RegisterFunction("DelItme", this, this.GetType().GetMethod("XOA_BO_VAT_PHAM"));
				this.pLuaVM.RegisterFunction("AddQuestItme", this, this.GetType().GetMethod("TANG_CUONG_NHIEM_VU_VAT_PHAM"));
				this.pLuaVM.RegisterFunction("DelQuestItme", this, this.GetType().GetMethod("XOA_NHIEM_VU_VAT_PHAM"));
				this.pLuaVM.RegisterFunction("GetWorldItme", this, this.GetType().GetMethod("GetWorldItme"));
				this.pLuaVM.RegisterFunction("GetPlayer", this, this.GetType().GetMethod("GetPlayerThis"));
				this.pLuaVM.RegisterFunction("GetQuestLevel", this, this.GetType().GetMethod("GET_NHIEM_VU_GIAI_DOAN"));
				this.pLuaVM.RegisterFunction("GetPackage", this, this.GetType().GetMethod("DUOC_KIEN_HANG_RONG_VI_TRI"));
				this.pLuaVM.RegisterFunction("GetPackages", this, this.GetType().GetMethod("DUOC_KIEN_HANG_RONG_VI_TRI_NHOM"));
				this.pLuaVM.RegisterFunction("GetPakItme", this, this.GetType().GetMethod("NHAN_DUOC_GOI_VAT_PHAM"));
				this.pLuaVM.RegisterFunction("GetPakItmesx", this, this.GetType().GetMethod("NHAN_DUOC_GOI_THUOC_TINH_VAT_PHAM"));
				this.pLuaVM.RegisterFunction("GetQuestItme", this, this.GetType().GetMethod("NHAN_DUOC_NHIEM_VU_VAT_PHAM"));
				this.pLuaVM.RegisterFunction("Hfgzhuanzhi", this, this.GetType().GetMethod("HAN_BAO_QUAN_CHUYEN_CHUC"));
				this.pLuaVM.RegisterFunction("Hfgwuqi", this, this.GetType().GetMethod("KIEM_TRA_HAN_BAO_QUAN_VU_KHI"));
				this.pLuaVM.RegisterFunction("Thlzhuanzhi", this, this.GetType().GetMethod("DAM_HOA_LIEN_CHUYEN_CHUC"));
				this.pLuaVM.RegisterFunction("Thlwuqi", this, this.GetType().GetMethod("KIEM_TRA_DAM_HOA_LIEN_VU_KHI"));
				this.pLuaVM.RegisterFunction("SetPlayerTransfer", this, this.GetType().GetMethod("NHAN_VAT_CHUYEN_NGHE_NGHIEP"));
				this.pLuaVM.RegisterFunction("SetQigong", this, this.GetType().GetMethod("HOC_KHI_CONG_MOI"));
				this.pLuaVM.RegisterFunction("SetPlayerLevel", this, this.GetType().GetMethod("THIET_LAP_NGUOI_CHOI_LEVEL"));
				this.pLuaVM.RegisterFunction("SetPlayerVIP", this, this.GetType().GetMethod("THIET_LAP_NHAN_VAT_THANH_VIEN"));
				this.pLuaVM.RegisterFunction("SetPlayerRxpiont", this, this.GetType().GetMethod("THIET_LAP_NHAN_VAT_NGUYEN_BAO"));
				this.pLuaVM.RegisterFunction("SetPlayerShuxing", this, this.GetType().GetMethod("THIET_LAP_NHAN_VAT_THUOC_TINH"));
				this.pLuaVM.RegisterFunction("SetPlayerVipdj", this, this.GetType().GetMethod("THIET_LAP_THANH_VIEN_THU_BAC"));
				this.pLuaVM.RegisterFunction("SetPlayerSE", this, this.GetType().GetMethod("THIET_LAP_NGUOI_CHOI_CHINH_TA"));
				this.pLuaVM.RegisterFunction("UpGongFu", this, this.GetType().GetMethod("CAP_NHAT_VO_CONG_VA_TRANG_THAI"));
				this.pLuaVM.RegisterFunction("UpJsjbsj", this, this.GetType().GetMethod("TINH_TOAN_NHAN_VAT_SO_LIEU_CO_BAN"));
				this.pLuaVM.RegisterFunction("UpHpMpSp", this, this.GetType().GetMethod("CAP_NHAT_HP_MP_HP"));
				this.pLuaVM.RegisterFunction("UpMoney", this, this.GetType().GetMethod("CAP_NHAT_TIEN_BAC_VA_MANG_NANG"));
                        this.pLuaVM.RegisterFunction("UpExp", this, this.GetType().GetMethod("CAP_NHAT_KINH_NGHIEM_VA_KN_SKILL"));
                        this.pLuaVM.RegisterFunction("UpYzbItme", this, this.GetType().GetMethod("LAN_DAU_DOI_THOAI_DA_TRANG_BI_VAT_PHAM"));
				this.pLuaVM.RegisterFunction("UpUseItme", this, this.GetType().GetMethod("VAT_PHAM_SU_DUNG"));
				this.pLuaVM.RegisterFunction("GetPakItemNum", this, this.GetType().GetMethod("NHAN_DUOC_GOI_VAT_PHAM_SO_LUONG"));
				this.pLuaVM.RegisterFunction("GetRxpiont", this, this.GetType().GetMethod("NHAN_DUOC_NGUYEN_BAO_SO_LIEU"));
                        this.pLuaVM.RegisterFunction("AddMoneyToCharacter", this, this.GetType().GetMethod("UpdateMoneyScript"));
                        this.pLuaVM.RegisterFunction("AddExpToCharacter", this, this.GetType().GetMethod("UpdateEXP"));
                        this.pLuaVM.RegisterFunction("MoveMap", this, this.GetType().GetMethod("MoveMapScript"));
                        this.pLuaVM.RegisterFunction("TEstMsg", this, this.GetType().GetMethod("TEstMsg"));
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				Form1.WriteLine(2, string.Concat("DANG_KY_KICH_BAN_API_LOI-", exception.Message));
			}
		}

		public void DANG_KY_SU_KIEN()
		{
			this.MO_RA_VAT_PHAM_SU_KIEM = this.pLuaVM.GetFunction("OpenItmeTrigGer");
			this.QUAI_VAT_TU_VONG_SU_KIEN = this.pLuaVM.GetFunction("DestroyMonster");
			this.VAT_PHAM_TRAO_DOI_SU_KIEN = this.pLuaVM.GetFunction("ExchangeItem");
                  MoveQuestMapScript = pLuaVM.GetFunction("MoveQuestMap");

            }

            public void MoveMapScript(int UserWorldId, int mapid, int x, int y, int z)
            {
                  Players player;
                  if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
                  {
                        player.Move(x, y, z, mapid);
                  }
            }


            public int DUOC_KIEN_HANG_RONG_VI_TRI(int UserWorldId)
		{
			Players player;
			if (!World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
                        return -1;
			}
			return player.DUOC_KIEN_HANG_RONG_VI_TRI();
		}

		public List<int> DUOC_KIEN_HANG_RONG_VI_TRI_NHOM(int UserWorldId, int SO_LUONG)
		{
			Players player;
			if (!World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				return new List<int>();
			}
			return player.NHAN_TUI_TRONG_NHOM(SO_LUONG);
		}

		public int GET_NHIEM_VU_GIAI_DOAN(int UserWorldId, int NHIEM_VU_ID)
		{
			Players player;
			if (!World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				return 0;
			}
			return player.GET_NHIEM_VU_GIAI_DOAN(NHIEM_VU_ID);
		}

		public Players GetPlayerThis(int UserWorldId)
		{
			Players player;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				return player;
			}
			return player;
		}

		public void GetUrlDirectory(string url)
		{
			if (Directory.Exists(url))
			{
				string[] files = Directory.GetFiles(url);
				for (int i = 0; i < (int)files.Length; i++)
				{
					string str = files[i];
					try
					{
						this.SetUrlFile(str);
					}
					catch (Exception exception)
					{
						Console.Write(exception);
					}
				}
				this.GetUrlDirectoryS(url);
			}
		}

		public void GetUrlDirectoryS(string url)
		{
			string[] directories = Directory.GetDirectories(url);
			for (int i = 0; i < (int)directories.Length; i++)
			{
				this.GetUrlDirectory(directories[i]);
			}
		}

		public TBL_XWWL_ITEM GetWorldItme(int VAT_PHAM_ID)
		{
			TBL_XWWL_ITEM tBLXWWLITEM;
			if (World.Itme.TryGetValue(VAT_PHAM_ID, out tBLXWWLITEM))
			{
				return tBLXWWLITEM;
			}
			return null;
		}

		public void GOI_Y_HE_THONG(int UserWorldId, string msg, int msgType, string name)
		{
			Players player;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				string str = string.Format(msg, player.UserName);
				player.GameMessage(str, msgType, name);
			}
		}

		public void GUI_DI_CHUYEN_CHUC_6_SACH_SKILL(int UserWorldId, int TRONG_RONG)
		{
			Players player;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				player.AddSkillBook6(TRONG_RONG);
			}
		}

		public void GUI_DI_CHUYEN_CHUC_7_SACH_SKILL(int UserWorldId, int TRONG_RONG)
		{
			Players player;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				player.AddSkillBook7(TRONG_RONG);
			}
		}

		public void GUI_DI_CHUYEN_CHUC_8_SACH_SKILL(int UserWorldId, int TRONG_RONG)
		{
			Players player;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				player.AddSkillBook8(TRONG_RONG);
			}
		}

		public void GUI_DI_CHUYEN_CHUC_9_SACH_SKILL(int UserWorldId, int TRONG_RONG)
		{
			Players player;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				player.AddSkillBook9(TRONG_RONG);
			}
		}

		public void GUI_DI_THONG_BAO(string txt, int ggid)
		{
			try
			{
				foreach (Players value in World.allConnectedChars.Values)
				{
					if (value == null)
					{
						continue;
					}
					string str = string.Format(txt, value.UserName);
					if (ggid != 0)
					{
						if (ggid == 1 || ggid != 2)
						{
							continue;
						}
						value.GameMessage(str, 10, "system message");
					}
					else
					{
						value.System_Announcement(str);
					}
				}
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				Form1.WriteLine(1, string.Concat("GUI_DI_THONG_BAO_LOI：", exception.Message));
			}
		}

		public void HAN_BAO_QUAN_CHUYEN_CHUC(int UserWorldId)
		{
			Players player;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				player.HankwangAddWeapon();
			}
		}

		public void HOC_KHI_CONG_MOI(int UserWorldId, int KHI_CONG_VI_TRI)
		{
			Players player;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				player.HOC_KHI_CONG_MOI(KHI_CONG_VI_TRI);
			}
		}

		public void HOC_SKILL(int UserWorldId, int FLD_VO_CONG_LOAI_HINH, int FLD_INDEX)
		{
			Players player;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				player.method_412(FLD_VO_CONG_LOAI_HINH, FLD_INDEX);
			}
		}

		public void HOC_SKILL_NHAC_NHO(int UserWorldId)
		{
			Players player;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				player.Learn_Skill_Tip(1);
			}
		}

		public void HOC_THANG_THIEN_VO_CONG_SACH(int UserWorldId, int FLD_VO_CONG_LOAI_HINH, int FLD_INDEX)
		{
			Players player;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				TBL_XWWL_KONGFU.Learn_Martial_Book(player, FLD_VO_CONG_LOAI_HINH, FLD_INDEX);
			}
		}

		public bool KIEM_TRA_DAM_HOA_LIEN_VU_KHI(int UserWorldId)
		{
			Players player;
			if (!World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				return true;
			}
			return player.THIET_LAP_DAM_HOA_LIEN_VU_KHI();
		}

		public bool KIEM_TRA_HAN_BAO_QUAN_VU_KHI(int UserWorldId)
		{
			Players player;
			if (!World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				return true;
			}
			return player.THIET_LAP_HAN_BAO_QUAN_VU_KHI();
		}

		public void LAN_DAU_DOI_THOAI_DA_TRANG_BI_VAT_PHAM(int UserWorldId)
		{
			Players player;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				player.LAN_DAU_DOI_THOAI_DA_TRANG_BI_VAT_PHAM();
			}
		}

		public int NHAN_DUOC_GOI_THUOC_TINH_VAT_PHAM(int UserWorldId, int VAT_PHAM_ID, int Thuoc_tinh_1, int Thuoc_tinh_2, int Thuoc_tinh_3, int Thuoc_tinh_4, int Attribute5, int Attribute6, int Attribute7, int Attribute8, int Attribute9)
		{
			Players player;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				for (int i = 0; i < 36; i++)
				{
					if (Attribute9 == 1)
					{
						if (BitConverter.ToInt32(player.TRANG_BI_LAN_BAO_VAY[i].VAT_PHAM_ID, 0) == VAT_PHAM_ID && player.TRANG_BI_LAN_BAO_VAY[i].FLD_MAGIC0 == Thuoc_tinh_1 && player.TRANG_BI_LAN_BAO_VAY[i].FLD_MAGIC1 == Thuoc_tinh_2 && player.TRANG_BI_LAN_BAO_VAY[i].FLD_MAGIC2 == Thuoc_tinh_3 && player.TRANG_BI_LAN_BAO_VAY[i].FLD_MAGIC3 == Thuoc_tinh_4 && player.TRANG_BI_LAN_BAO_VAY[i].FLD_MAGIC4 == Attribute5 && player.TRANG_BI_LAN_BAO_VAY[i].FLD_FJ_thuc_tinh == Attribute6 && player.TRANG_BI_LAN_BAO_VAY[i].FLD_FJ_trung_cap_phu_hon == Attribute7 && player.TRANG_BI_LAN_BAO_VAY[i].FLD_FJ_tien_hoa == Attribute8 && player.TRANG_BI_LAN_BAO_VAY[i].Item_troi_chat)
						{
							return i;
						}
					}
					else if (BitConverter.ToInt32(player.TRANG_BI_LAN_BAO_VAY[i].VAT_PHAM_ID, 0) == VAT_PHAM_ID && player.TRANG_BI_LAN_BAO_VAY[i].FLD_MAGIC0 == Thuoc_tinh_1 && player.TRANG_BI_LAN_BAO_VAY[i].FLD_MAGIC1 == Thuoc_tinh_2 && player.TRANG_BI_LAN_BAO_VAY[i].FLD_MAGIC2 == Thuoc_tinh_3 && player.TRANG_BI_LAN_BAO_VAY[i].FLD_MAGIC3 == Thuoc_tinh_4 && player.TRANG_BI_LAN_BAO_VAY[i].FLD_MAGIC4 == Attribute5 && player.TRANG_BI_LAN_BAO_VAY[i].FLD_FJ_thuc_tinh == Attribute6 && player.TRANG_BI_LAN_BAO_VAY[i].FLD_FJ_trung_cap_phu_hon == Attribute7 && player.TRANG_BI_LAN_BAO_VAY[i].FLD_FJ_tien_hoa == Attribute8 && !player.TRANG_BI_LAN_BAO_VAY[i].Item_troi_chat)
					{
						return i;
					}
				}
			}
			return -1;
		}

		public int NHAN_DUOC_GOI_VAT_PHAM(int UserWorldId, int VAT_PHAM_ID)
		{
			Players player;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				for (int i = 0; i < 36; i++)
				{
					if (BitConverter.ToInt32(player.TRANG_BI_LAN_BAO_VAY[i].VAT_PHAM_ID, 0) == VAT_PHAM_ID)
					{
						return i;
					}
				}
			}
			return -1;
		}

		public int NHAN_DUOC_GOI_VAT_PHAM_SO_LUONG(int UserWorldId, int VAT_PHAM_ID, int SO_LUONG)
		{
			Players player;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				for (int i = 0; i < 66; i++)
				{
					if (BitConverter.ToInt32(player.TRANG_BI_LAN_BAO_VAY[i].VAT_PHAM_ID, 0) == VAT_PHAM_ID && BitConverter.ToInt32(player.TRANG_BI_LAN_BAO_VAY[i].VAT_PHAM_SO_LUONG, 0) >= SO_LUONG)
					{
						return i;
					}
				}
			}
			return -1;
		}

		public long NHAN_DUOC_NGUYEN_BAO_SO_LIEU(int UserWorldId)
		{
			Players player;
			if (!World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				return (long)0;
			}
			player.KIEM_TRA_BACH_BAO_CAC_NGUYEN_BAO_SO_LUONG();
			return player.FLD_RXPIONT;
		}

		public bool NHAN_DUOC_NHIEM_VU_VAT_PHAM(int UserWorldId, int VAT_PHAM_ID, int SO_LUONG)
		{
			Players player;
			if (!World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				return false;
			}
			return player.KIEM_TRA_ITEM_NHIEM_VU(VAT_PHAM_ID, SO_LUONG);
		}

		public void NHAN_VAT_CHUYEN_NGHE_NGHIEP(int UserWorldId, int NHAN_VAT_CHINH_TA, int CHUYEN)
		{
			Players player;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				player.NHAN_VAT_CHUYEN_NGHE_NGHIEP(NHAN_VAT_CHINH_TA, CHUYEN);
			}
		}

		public void NHIEM_VU_NHAC_NHO_SO_LIEU_GUI_DI(int UserWorldId, int NHIEM_VU_ID, int THAO_TAC_ID, int NHIEM_VU_GIAI_DOAN_ID)
		{
			Players player;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				player.NHIEM_VU_NHAC_NHO_SO_LIEU_GUI_DI(NHIEM_VU_ID, THAO_TAC_ID, NHIEM_VU_GIAI_DOAN_ID);
			}
		}

		public void SetUrlFile(string Url)
		{
			if (Path.GetExtension(Url) == ".lua")
			{
				try
				{
					this.pLuaVM.DoFile(Url);
				}
				catch (Exception exception1)
				{
					Exception exception = exception1;
					Console.WriteLine(exception.Message);
					Form1.WriteLine(2, string.Concat("LuaScript Load error!!", exception.Message));
				}
			}
		}

		public void TANG_CUONG_NHIEM_VU_VAT_PHAM(int UserWorldId, int VAT_PHAM_ID, int SO_LUONG)
		{
			Players player;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				player.THIET_LAP_NHIEM_VU_VAT_PHAM(VAT_PHAM_ID, SO_LUONG);
			}
		}

		public void TANG_CUONG_VAT_PHAM_MANG_THUOC_TINH(int UserWorldId, int VAT_PHAM_ID, int VI_TRI, int SO_LUONG, int Item_thuoc_tinh0, int Item_thuoc_tinh1, int Item_thuoc_tinh2, int Item_thuoc_tinh3, int Item_thuoc_tinh4, int 初级附魂, int 中级附魂, int 进化, int 绑定)
		{
			Players player;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				player.TANG_CUONG_VAT_PHAM_MANG_THUOC_TINH(VAT_PHAM_ID, VI_TRI, SO_LUONG, Item_thuoc_tinh0, Item_thuoc_tinh1, Item_thuoc_tinh2, Item_thuoc_tinh3, Item_thuoc_tinh4, 初级附魂, 中级附魂, 进化, 绑定);
			}
		}

		public void TANG_CUONG_VAT_PHAM_MANG_THUOC_TINH_THANG_THIEN(int UserWorldId, int VAT_PHAM_ID, int VI_TRI, int 数量, int Item_thuoc_tinh0, int Item_thuoc_tinh1, int Item_thuoc_tinh2, int Item_thuoc_tinh3, int Item_thuoc_tinh4, int 初级附魂, int 中级附魂, int 进化, int 绑定, int 天数)
		{
			Players player;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				player.BACH_BAO_TANG_CUONG_ITEM_MANG_THUOC_TINH(VAT_PHAM_ID, VI_TRI, 数量, Item_thuoc_tinh0, Item_thuoc_tinh1, Item_thuoc_tinh2, Item_thuoc_tinh3, Item_thuoc_tinh4, 初级附魂, 中级附魂, 进化, 绑定, 天数);
			}
		}

		public void TANG_CUONG_VAT_PHAMScript(int UserWorldId, int VAT_PHAM_ID, int TRONG_RONG, int SO_LUONG)
		{
                  //퀘스트 보상 아이템
			Players player;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
                        if (VAT_PHAM_ID == 909000004)
                        {
                              // 냥
                              UpdateMoneyScript(UserWorldId, SO_LUONG);
                        }
                        else if (VAT_PHAM_ID == 909000001)
                        {
                              //경험치
                              UpdateEXP(UserWorldId, SO_LUONG);
                        }
                        else if(VAT_PHAM_ID == 909000002)
                        {
                              //기연
                              CAP_NHAT_KINH_NGHIEM_VA_KN_SKILL(UserWorldId);
                        }
                        else
                        {
                              //아이템
                              player.TANG_CUONG_ITEM_SCRIPT(VAT_PHAM_ID, TRONG_RONG, SO_LUONG);                              
                        }
			}
		}

		public void TEstMsg(object aa)
		{
			Console.WriteLine(aa);
		}

		public void THIET_LAP_NGUOI_CHOI_CHINH_TA(int UserWorldId, int CHINH_TA)
		{
			Players player;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				Players nHANVATTHIENAC = player;
				nHANVATTHIENAC.NHAN_VAT_THIEN_AC = nHANVATTHIENAC.NHAN_VAT_THIEN_AC + CHINH_TA;
			}
		}

		public void THIET_LAP_NGUOI_CHOI_LEVEL(int UserWorldId, int LEVEL)
		{
			Players lEVEL;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out lEVEL))
			{
				lEVEL.NHAN_VAT_KINH_NGHIEM = 0;
				lEVEL.Player_FLD_LEVEL = LEVEL;
				lEVEL.BasicCharacterData();
				lEVEL.UpdateHP_MP_SP();
				lEVEL.UpdatePowersAndStatus();
				lEVEL.UpdateExperience();
				lEVEL.UpdateMoneyAndWeight();
				lEVEL.Update_Qigong();
			}
		}

		public void THIET_LAP_NHAN_VAT_NGUYEN_BAO(int UserWorldId, long NGUYEN_BAO_SO, int THAO_TAC_LOAI_HINH)
		{
			Players player;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				player.method_47(NGUYEN_BAO_SO, THAO_TAC_LOAI_HINH);
				player.UPDATE_RXPIONT();
			}
		}

		public void THIET_LAP_NHAN_VAT_THANH_VIEN(int UserWorldId, int THANH_VIEN_THOI_GIAN)
		{
			Players player;
			DateTime now;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				if (player.FLD_VIP != 0)
				{
					DateTime dateTime = DateTime.Now;
					now = DateTime.Now;
					player.FLD_VIPTIM = now.AddMonths(THANH_VIEN_THOI_GIAN);
					now = player.FLD_VIPTIM;
					player.GameMessage(string.Concat("Continued success, your VIP expiration time is:", now.ToString("yyyy-MM-dd- hh:mm")), 9, "System");
				}
				else
				{
					DateTime now1 = DateTime.Now;
					now1 = DateTime.Now.AddMonths(THANH_VIEN_THOI_GIAN);
					player.FLD_VIP = 1;
					player.FLD_VIPTIM = now1;
					player.GameMessage("Congratulations, you get a month's VIP!", 9, "System");
					now = player.FLD_VIPTIM;
					player.GameMessage(string.Concat("Your VIP expiration time is:", now.ToString("yyyy-MM-dd hh:mm")), 9, "System");
				}
				player.LUU_THANH_VIEN_SO_LIEU();
			}
		}

		public void THIET_LAP_NHAN_VAT_THUOC_TINH(int UserWorldId, long CONG_KICH, long PHONG_NGU, long SINH_MENH)
		{
			Players player;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				string[] strArrays = World.Thang_cap_thanh_vien_can_Thuoc_tinh.Split(new char[] { ',' });
				if (player.Khen_thuong_them_vao_cong_kich < long.Parse(strArrays[0]))
				{
					Players khenThuongThemVaoCongKich = player;
					khenThuongThemVaoCongKich.Khen_thuong_them_vao_cong_kich = khenThuongThemVaoCongKich.Khen_thuong_them_vao_cong_kich + CONG_KICH;
				}
				if (player.Khen_thuong_them_vao_phong_ngu < long.Parse(strArrays[1]))
				{
					Players khenThuongThemVaoPhongNgu = player;
					khenThuongThemVaoPhongNgu.Khen_thuong_them_vao_phong_ngu = khenThuongThemVaoPhongNgu.Khen_thuong_them_vao_phong_ngu + PHONG_NGU;
				}
				Players khenThuongThemVaoSinhMenh = player;
				khenThuongThemVaoSinhMenh.Khen_thuong_them_vao_sinh_menh = khenThuongThemVaoSinhMenh.Khen_thuong_them_vao_sinh_menh + SINH_MENH;
				player.UpdatePowersAndStatus();
				player.UpdateHP_MP_SP();
			}
		}

		public void THIET_LAP_NHIEM_VU_SO_LIEU(int UserWorldId, int QuestId, int RwJdId)
		{
			Players player;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				player.THIET_LAP_NHIEM_VU_SO_LIEU(QuestId, RwJdId);
			}
		}

		public void THIET_LAP_THANH_VIEN_THU_BAC(int UserWorldId, long DANG_CAP)
		{
			Players nhanVatLevelCaoNhat;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out nhanVatLevelCaoNhat) && nhanVatLevelCaoNhat.Thanh_vien_thu_bac < World.Nhan_vat_level_cao_nhat)
			{
				if (nhanVatLevelCaoNhat.Thanh_vien_thu_bac + DANG_CAP <= World.Nhan_vat_level_cao_nhat)
				{
					Players thanhVienThuBac = nhanVatLevelCaoNhat;
					thanhVienThuBac.Thanh_vien_thu_bac = thanhVienThuBac.Thanh_vien_thu_bac + DANG_CAP;
				}
				else
				{
					nhanVatLevelCaoNhat.Thanh_vien_thu_bac = World.Nhan_vat_level_cao_nhat;
				}
				nhanVatLevelCaoNhat.LUU_NHAN_VAT_SO_LIEU();
			}
		}

		public void TINH_TOAN_NHAN_VAT_SO_LIEU_CO_BAN(int UserWorldId)
		{
			Players player;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				player.BasicCharacterData();
			}
		}

		public void VAT_PHAM_SU_DUNG(int UserWorldId, int VI_TRI, int SO_LUONG)
		{
			Players player;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				player.UseItem(VI_TRI, SO_LUONG);
			}
		}

		public void XOA_BO_VAT_PHAM(int UserWorldId, int VI_TRI, int SO_LUONG)
		{
			Players player;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				player.LAM_GIAM_DI_VAT_PHAM(VI_TRI, SO_LUONG);
			}
		}

		public void XOA_NHIEM_VU_VAT_PHAM(int UserWorldId, int VAT_PHAM_ID, int SO_LUONG)
		{
			Players player;
			if (World.allConnectedChars.TryGetValue(UserWorldId, out player))
			{
				player.XOA_VAT_PHAM_NHIEM_VU(VAT_PHAM_ID, SO_LUONG);
			}
		}
	}
}