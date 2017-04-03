using ns3;
using ns6;
using ns9;
using System;
using System.Collections.Generic;

namespace ns11
{
	public class TBL_XWWL_KONGFU : IDisposable
	{
		private int int_0;

		private int int_1;

		private int int_10;

		public int FLD_TYPE;

		private int int_12;

		private int int_13;

		private int int_14;

		private int int_15;

		public int FLD_MOI_CAP_THEM_MP;

		public int FLD_MOI_CAP_THEM_KINH_NGHIEM;

		public int FLD_MOI_CAP_THEM_DANG_CAP;

		public int FLD_MOI_CAP_THEM_NGUY_HAI;

		private int int_2;

		public int FLD_MOI_CAP_VO_CONG_DIEM_SO;

		private int int_3;

		private int int_4;

		private int int_5;

		private int int_6;

		private int int_7;

		private int int_8;

		private int int_9;

		private int int_16;

		public DateTime Deleyskill;

		public int FLD_AT
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

		public DateTime FLD_CDSKILL
		{
			get
			{
				return this.Deleyskill;
			}
			set
			{
				this.Deleyskill = value;
			}
		}

		public int FLD_CDTIME
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

		public int FLD_CONG_KICH_SO_LUONG
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

		public int FLD_EFFERT
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

		public int FLD_INDEX
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

		public int FLD_JOB
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

		public int FLD_JOBLEVEL
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

		public int FLD_LEVEL
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

		public int FLD_MP
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

		public int FLD_NEEDEXP
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

		public int FLD_PID
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

		public int FLD_TIME
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

		public int FLD_VO_CONG_CAO_NHAT_DANG_CAP
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

		public int FLD_VO_CONG_LOAI_HINH
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

		public int FLD_ZX
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

		public int VO_CONG_THU_BAC
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

		public byte[] Vo_CongID_byte
		{
			get
			{
				return BitConverter.GetBytes(this.FLD_PID);
			}
		}

		public TBL_XWWL_KONGFU()
		{
		}

		public TBL_XWWL_KONGFU(int FLD_PID_)
		{
			this.FLD_PID = FLD_PID_;
			this.method_0(this.FLD_PID);
		}

		public static void Learn_Martial_Book(Players class15_0, int int_21, int int_22)
		{
			TBL_XWWL_KONGFU tBLXWWLKONGFU = TBL_XWWL_KONGFU.smethod_0(class15_0.Player_Zx, class15_0.Player_Job, int_21, int_22);
			if (tBLXWWLKONGFU != null && class15_0.Player_ExpErience >= tBLXWWLKONGFU.FLD_NEEDEXP && (tBLXWWLKONGFU.FLD_ZX == 0 || class15_0.Player_Zx == tBLXWWLKONGFU.FLD_ZX) && (tBLXWWLKONGFU.FLD_JOB == 0 || class15_0.Player_Job == tBLXWWLKONGFU.FLD_JOB) && (tBLXWWLKONGFU.FLD_JOBLEVEL == 0 || class15_0.Player_FLD_JOB_LEVEL >= tBLXWWLKONGFU.FLD_JOBLEVEL) && (tBLXWWLKONGFU.FLD_LEVEL == 0 || class15_0.Player_FLD_LEVEL >= tBLXWWLKONGFU.FLD_LEVEL))
			{
				class15_0.class79_0[tBLXWWLKONGFU.FLD_VO_CONG_LOAI_HINH, tBLXWWLKONGFU.FLD_INDEX] = new TBL_XWWL_KONGFU(tBLXWWLKONGFU.FLD_PID);
				class15_0.class79_0[tBLXWWLKONGFU.FLD_VO_CONG_LOAI_HINH, tBLXWWLKONGFU.FLD_INDEX].VO_CONG_THU_BAC = 1;
				class15_0.CAP_NHAT_KY_NANG_MOI_LAM_DONG_BANG(tBLXWWLKONGFU.FLD_PID);
			}
		}

		public static void Learn_Martial_Gen_1(Players class15_0, TBL_XWWL_ITEM class7_0, int int_21)
		{
			if (class7_0.FLD_LEVEL > class15_0.Player_FLD_LEVEL)
			{
				class15_0.GameMessage("Nhan vat khong du level de hoc vo cong nay!", 9, "Msg");
				return;
			}
			if (class7_0.FLD_ZX != 0 && class7_0.FLD_ZX != class15_0.Player_Zx)
			{
				class15_0.GameMessage("The luc khong dong nhat khong the hoc vo cong!", 9, "Msg");
				return;
			}
			if (class7_0.FLD_RESIDE1 != 0 && class7_0.FLD_RESIDE1 != class15_0.Player_Job)
			{
				class15_0.GameMessage("Khong the hoc vo cong cua nhan vat khac!", 9, "Msg");
				return;
			}
			if (class7_0.FLD_JOB_LEVEL != 0 && class7_0.FLD_JOB_LEVEL > class15_0.Player_FLD_JOB_LEVEL)
			{
				class15_0.GameMessage("Nhan vat chua du danh vong de hoc vo cong!", 9, "Msg");
				return;
			}
			if (class15_0.Player_Money < (long)500000000)
			{
				class15_0.GameMessage("Nhan vat khong du tien de hoc vo cong!", 9, "Msg");
				return;
			}
			if (class15_0.Player_ExpErience < 5000000)
			{
				class15_0.GameMessage("Nhan vat khong du diem ky nang de hoc vo cong!", 9, "Msg");
				return;
			}
			TBL_XWWL_KONGFU.Learn_Martial_Book(class15_0, 3, 1);
			TBL_XWWL_KONGFU.Learn_Martial_Book(class15_0, 3, 2);
			class15_0.UseItem(int_21, 1);
			Players class150 = class15_0;
			class150.Player_ExpErience = class150.Player_ExpErience - 5000000;
			Players playerMoney = class15_0;
			playerMoney.Player_Money = playerMoney.Player_Money - (long)500000000;
			class15_0.Learn_Skill_Tip(1);
			class15_0.UpdatePowersAndStatus();
			class15_0.UpdateExperience();
			class15_0.UpdateMoneyAndWeight();
		}

		public static void Learn_Martial_Gen_2(Players class15_0, TBL_XWWL_ITEM class7_0, int int_21)
		{
			if (class7_0.FLD_LEVEL > class15_0.Player_FLD_LEVEL)
			{
				class15_0.GameMessage("Nhan vat khong du level de hoc vo cong nay!", 9, "Msg");
				return;
			}
			if (class7_0.FLD_ZX != 0 && class7_0.FLD_ZX != class15_0.Player_Zx)
			{
				class15_0.GameMessage("The luc khong dong nhat khong the hoc vo cong!", 9, "Msg");
				return;
			}
			if (class7_0.FLD_RESIDE1 != 0 && class7_0.FLD_RESIDE1 != class15_0.Player_Job)
			{
				class15_0.GameMessage("Khong the hoc vo cong cua nhan vat khac!", 9, "Msg");
				return;
			}
			if (class7_0.FLD_JOB_LEVEL != 0 && class7_0.FLD_JOB_LEVEL > class15_0.Player_FLD_JOB_LEVEL)
			{
				class15_0.GameMessage("Nhan vat chua du danh vong de hoc vo cong!", 9, "Msg");
				return;
			}
			if (class15_0.Player_Money < (long)1000000000)
			{
				class15_0.GameMessage("Nhan vat khong du tien de hoc vo cong!", 9, "Msg");
				return;
			}
			if (class15_0.Player_ExpErience < 10000000)
			{
				class15_0.GameMessage("Nhan vat khong du diem ky nang de hoc vo cong!", 9, "Msg");
				return;
			}
			TBL_XWWL_KONGFU.Learn_Martial_Book(class15_0, 3, 4);
			TBL_XWWL_KONGFU.Learn_Martial_Book(class15_0, 3, 5);
			class15_0.UseItem(int_21, 1);
			Players class150 = class15_0;
			class150.Player_ExpErience = class150.Player_ExpErience - 10000000;
			Players playerMoney = class15_0;
			playerMoney.Player_Money = playerMoney.Player_Money - (long)1000000000;
			class15_0.Learn_Skill_Tip(1);
			class15_0.UpdatePowersAndStatus();
			class15_0.UpdateExperience();
			class15_0.UpdateMoneyAndWeight();
		}

		public static void Learn_Martial_Gen_3(Players class15_0, TBL_XWWL_ITEM class7_0, int int_21)
		{
			if (class7_0.FLD_LEVEL > class15_0.Player_FLD_LEVEL)
			{
				class15_0.GameMessage("Nhan vat khong du level de hoc vo cong nay!", 9, "Msg");
				return;
			}
			if (class7_0.FLD_ZX != 0 && class7_0.FLD_ZX != class15_0.Player_Zx)
			{
				class15_0.GameMessage("The luc khong dong nhat khong the hoc vo cong!", 9, "Msg");
				return;
			}
			if (class7_0.FLD_RESIDE1 != 0 && class7_0.FLD_RESIDE1 != class15_0.Player_Job)
			{
				class15_0.GameMessage("Khong the hoc vo cong cua nhan vat khac!", 9, "Msg");
				return;
			}
			if (class7_0.FLD_JOB_LEVEL != 0 && class7_0.FLD_JOB_LEVEL > class15_0.Player_FLD_JOB_LEVEL)
			{
				class15_0.GameMessage("Nhan vat chua du danh vong de hoc vo cong!", 9, "Msg");
				return;
			}
			if (class15_0.Player_Money < (long)1500000000)
			{
				class15_0.GameMessage("Nhan vat khong du tien de hoc vo cong!", 9, "Msg");
				return;
			}
			if (class15_0.Player_ExpErience < 15000000)
			{
				class15_0.GameMessage("Nhan vat khong du diem ky nang de hoc vo cong!", 9, "Msg");
				return;
			}
			TBL_XWWL_KONGFU.Learn_Martial_Book(class15_0, 3, 7);
			TBL_XWWL_KONGFU.Learn_Martial_Book(class15_0, 3, 8);
			class15_0.UseItem(int_21, 1);
			Players class150 = class15_0;
			class150.Player_ExpErience = class150.Player_ExpErience - 15000000;
			Players playerMoney = class15_0;
			playerMoney.Player_Money = playerMoney.Player_Money - (long)1500000000;
			class15_0.Learn_Skill_Tip(1);
			class15_0.UpdatePowersAndStatus();
			class15_0.UpdateExperience();
			class15_0.UpdateMoneyAndWeight();
		}

		public static void Learn_Martial_Gen_4(Players class15_0, TBL_XWWL_ITEM class7_0, int int_21)
		{
			if (class7_0.FLD_LEVEL > class15_0.Player_FLD_LEVEL)
			{
				class15_0.GameMessage("Nhan vat khong du level de hoc vo cong nay!", 9, "Msg");
				return;
			}
			if (class7_0.FLD_ZX != 0 && class7_0.FLD_ZX != class15_0.Player_Zx)
			{
				class15_0.GameMessage("The luc khong dong nhat khong the hoc vo cong!", 9, "Msg");
				return;
			}
			if (class7_0.FLD_RESIDE1 != 0 && class7_0.FLD_RESIDE1 != class15_0.Player_Job)
			{
				class15_0.GameMessage("Khong the hoc vo cong cua nhan vat khac!", 9, "Msg");
				return;
			}
			if (class7_0.FLD_JOB_LEVEL != 0 && class7_0.FLD_JOB_LEVEL > class15_0.Player_FLD_JOB_LEVEL)
			{
				class15_0.GameMessage("Nhan vat chua du danh vong de hoc vo cong!", 9, "Msg");
				return;
			}
			if (class15_0.Player_Money < (long)2000000000)
			{
				class15_0.GameMessage("Nhan vat khong du tien de hoc vo cong!", 9, "Msg");
				return;
			}
			if (class15_0.Player_ExpErience < 20000000)
			{
				class15_0.GameMessage("Nhan vat khong du diem ky nang de hoc vo cong!", 9, "Msg");
				return;
			}
			TBL_XWWL_KONGFU.Learn_Martial_Book(class15_0, 3, 10);
			TBL_XWWL_KONGFU.Learn_Martial_Book(class15_0, 3, 11);
			class15_0.UseItem(int_21, 1);
			Players class150 = class15_0;
			class150.Player_ExpErience = class150.Player_ExpErience - 20000000;
			Players playerMoney = class15_0;
			playerMoney.Player_Money = playerMoney.Player_Money - (long)2000000000;
			class15_0.Learn_Skill_Tip(1);
			class15_0.UpdatePowersAndStatus();
			class15_0.UpdateExperience();
			class15_0.UpdateMoneyAndWeight();
		}

		public static void Learn_Skill_Hankwang1(Players class15_0, TBL_XWWL_ITEM class7_0, int int_21)
		{
			if (class7_0.FLD_LEVEL > class15_0.Player_FLD_LEVEL)
			{
				class15_0.GameMessage("Nhan vat khong du level de hoc vo cong nay!", 9, "Msg");
				return;
			}
			if (class7_0.FLD_ZX != 0 && class7_0.FLD_ZX != class15_0.Player_Zx)
			{
				class15_0.GameMessage("The luc khong dong nhat khong the hoc vo cong!", 9, "Msg");
				return;
			}
			if (class7_0.FLD_RESIDE1 != 0 && class7_0.FLD_RESIDE1 != class15_0.Player_Job)
			{
				class15_0.GameMessage("Khong the hoc vo cong cua nhan vat khac!", 9, "Msg");
				return;
			}
			if (class7_0.FLD_JOB_LEVEL != 0 && class7_0.FLD_JOB_LEVEL > class15_0.Player_FLD_JOB_LEVEL)
			{
				class15_0.GameMessage("Nhan vat chua du danh vong de hoc vo cong!", 9, "Msg");
				return;
			}
			if (class15_0.Player_Money < (long)500000000)
			{
				class15_0.GameMessage("Nhan vat khong du tien de hoc vo cong!", 9, "Msg");
				return;
			}
			if (class15_0.Player_ExpErience < 5000000)
			{
				class15_0.GameMessage("Nhan vat khong du diem ky nang de hoc vo cong!", 9, "Msg");
				return;
			}
			class15_0.method_412(3, 10);
			class15_0.method_412(3, 16);
			class15_0.method_412(3, 17);
			class15_0.method_412(3, 20);
			class15_0.UseItem(int_21, 1);
			Players class150 = class15_0;
			class150.Player_ExpErience = class150.Player_ExpErience - 5000000;
			Players playerMoney = class15_0;
			playerMoney.Player_Money = playerMoney.Player_Money - (long)500000000;
			class15_0.Learn_Skill_Tip(1);
			class15_0.UpdatePowersAndStatus();
			class15_0.UpdateExperience();
			class15_0.UpdateMoneyAndWeight();
		}

		public static void Learn_Skill_Hankwang2(Players class15_0, TBL_XWWL_ITEM class7_0, int int_21)
		{
			if (class7_0.FLD_LEVEL > class15_0.Player_FLD_LEVEL)
			{
				class15_0.GameMessage("Nhan vat khong du level de hoc vo cong nay!", 9, "Msg");
				return;
			}
			if (class7_0.FLD_ZX != 0 && class7_0.FLD_ZX != class15_0.Player_Zx)
			{
				class15_0.GameMessage("The luc khong dong nhat khong the hoc vo cong!", 9, "Msg");
				return;
			}
			if (class7_0.FLD_RESIDE1 != 0 && class7_0.FLD_RESIDE1 != class15_0.Player_Job)
			{
				class15_0.GameMessage("Khong the hoc vo cong cua nhan vat khac!", 9, "Msg");
				return;
			}
			if (class7_0.FLD_JOB_LEVEL != 0 && class7_0.FLD_JOB_LEVEL > class15_0.Player_FLD_JOB_LEVEL)
			{
				class15_0.GameMessage("Nhan vat chua du danh vong de hoc vo cong!", 9, "Msg");
				return;
			}
			if (class15_0.Player_Money < (long)1000000000)
			{
				class15_0.GameMessage("Nhan vat khong du tien de hoc vo cong!", 9, "Msg");
				return;
			}
			if (class15_0.Player_ExpErience < 10000000)
			{
				class15_0.GameMessage("Nhan vat khong du diem ky nang de hoc vo cong!", 9, "Msg");
				return;
			}
			TBL_XWWL_KONGFU.Learn_Martial_Book(class15_0, 3, 5);
			class15_0.method_412(3, 14);
			class15_0.method_412(3, 15);
			class15_0.UseItem(int_21, 1);
			Players class150 = class15_0;
			class150.Player_ExpErience = class150.Player_ExpErience - 10000000;
			Players playerMoney = class15_0;
			playerMoney.Player_Money = playerMoney.Player_Money - (long)1000000000;
			class15_0.Learn_Skill_Tip(1);
			class15_0.UpdatePowersAndStatus();
			class15_0.UpdateExperience();
			class15_0.UpdateMoneyAndWeight();
		}

		public static void Learn_Skill_Hankwang3(Players class15_0, TBL_XWWL_ITEM class7_0, int int_21)
		{
			if (class7_0.FLD_LEVEL > class15_0.Player_FLD_LEVEL)
			{
				class15_0.GameMessage("Nhan vat khong du level de hoc vo cong nay!", 9, "Msg");
				return;
			}
			if (class7_0.FLD_ZX != 0 && class7_0.FLD_ZX != class15_0.Player_Zx)
			{
				class15_0.GameMessage("The luc khong dong nhat khong the hoc vo cong!", 9, "Msg");
				return;
			}
			if (class7_0.FLD_RESIDE1 != 0 && class7_0.FLD_RESIDE1 != class15_0.Player_Job)
			{
				class15_0.GameMessage("Khong the hoc vo cong cua nhan vat khac!", 9, "Msg");
				return;
			}
			if (class7_0.FLD_JOB_LEVEL != 0 && class7_0.FLD_JOB_LEVEL > class15_0.Player_FLD_JOB_LEVEL)
			{
				class15_0.GameMessage("Nhan vat chua du danh vong de hoc vo cong!", 9, "Msg");
				return;
			}
			if (class15_0.Player_Money < (long)1500000000)
			{
				class15_0.GameMessage("Nhan vat khong du tien de hoc vo cong!", 9, "Msg");
				return;
			}
			if (class15_0.Player_ExpErience < 15000000)
			{
				class15_0.GameMessage("Nhan vat khong du diem ky nang de hoc vo cong!", 9, "Msg");
				return;
			}
			TBL_XWWL_KONGFU.Learn_Martial_Book(class15_0, 3, 9);
			class15_0.method_412(3, 18);
			class15_0.method_412(3, 19);
			class15_0.UseItem(int_21, 1);
			Players class150 = class15_0;
			class150.Player_ExpErience = class150.Player_ExpErience - 15000000;
			Players playerMoney = class15_0;
			playerMoney.Player_Money = playerMoney.Player_Money - (long)1500000000;
			class15_0.Learn_Skill_Tip(1);
			class15_0.UpdatePowersAndStatus();
			class15_0.UpdateExperience();
			class15_0.UpdateMoneyAndWeight();
		}

		public static void Learn_Skill_Hankwang4(Players class15_0, TBL_XWWL_ITEM class7_0, int int_21)
		{
			if (class7_0.FLD_LEVEL > class15_0.Player_FLD_LEVEL)
			{
				class15_0.GameMessage("Nhan vat khong du level de hoc vo cong nay!", 9, "Msg");
				return;
			}
			if (class7_0.FLD_ZX != 0 && class7_0.FLD_ZX != class15_0.Player_Zx)
			{
				class15_0.GameMessage("The luc khong dong nhat khong the hoc vo cong!", 9, "Msg");
				return;
			}
			if (class7_0.FLD_RESIDE1 != 0 && class7_0.FLD_RESIDE1 != class15_0.Player_Job)
			{
				class15_0.GameMessage("Khong the hoc vo cong cua nhan vat khac!", 9, "Msg");
				return;
			}
			if (class7_0.FLD_JOB_LEVEL != 0 && class7_0.FLD_JOB_LEVEL > class15_0.Player_FLD_JOB_LEVEL)
			{
				class15_0.GameMessage("Nhan vat chua du danh vong de hoc vo cong!", 9, "Msg");
				return;
			}
			if (class15_0.Player_Money < (long)2000000000)
			{
				class15_0.GameMessage("Nhan vat khong du tien de hoc vo cong!", 9, "Msg");
				return;
			}
			if (class15_0.Player_ExpErience < 20000000)
			{
				class15_0.GameMessage("Nhan vat khong du diem ky nang de hoc vo cong!", 9, "Msg");
				return;
			}
			TBL_XWWL_KONGFU.Learn_Martial_Book(class15_0, 3, 13);
			class15_0.UseItem(int_21, 1);
			Players class150 = class15_0;
			class150.Player_ExpErience = class150.Player_ExpErience - 20000000;
			Players playerMoney = class15_0;
			playerMoney.Player_Money = playerMoney.Player_Money - (long)2000000000;
			class15_0.Learn_Skill_Tip(1);
			class15_0.UpdatePowersAndStatus();
			class15_0.UpdateExperience();
			class15_0.UpdateMoneyAndWeight();
		}

		public static void Learn_Skill_Harin3(Players class15_0, TBL_XWWL_ITEM class7_0, int int_21)
		{
			if (class7_0.FLD_LEVEL > class15_0.Player_FLD_LEVEL)
			{
				class15_0.GameMessage("Nhan vat khong du level de hoc vo cong nay!", 9, "Msg");
				return;
			}
			if (class7_0.FLD_ZX != 0 && class7_0.FLD_ZX != class15_0.Player_Zx)
			{
				class15_0.GameMessage("The luc khong dong nhat khong the hoc vo cong!", 9, "Msg");
				return;
			}
			if (class7_0.FLD_RESIDE1 != 0 && class7_0.FLD_RESIDE1 != class15_0.Player_Job)
			{
				class15_0.GameMessage("Khong the hoc vo cong cua nhan vat khac!", 9, "Msg");
				return;
			}
			if (class7_0.FLD_JOB_LEVEL != 0 && class7_0.FLD_JOB_LEVEL > class15_0.Player_FLD_JOB_LEVEL)
			{
				class15_0.GameMessage("Nhan vat chua du danh vong de hoc vo cong!", 9, "Msg");
				return;
			}
			if (class15_0.Player_Money < (long)1500000000)
			{
				class15_0.GameMessage("Nhan vat khong du tien de hoc vo cong!", 9, "Msg");
				return;
			}
			if (class15_0.Player_ExpErience < 15000000)
			{
				class15_0.GameMessage("Nhan vat khong du diem ky nang de hoc vo cong!", 9, "Msg");
				return;
			}
			TBL_XWWL_KONGFU.Learn_Martial_Book(class15_0, 3, 16);
			TBL_XWWL_KONGFU.Learn_Martial_Book(class15_0, 3, 17);
			class15_0.UseItem(int_21, 1);
			Players class150 = class15_0;
			class150.Player_ExpErience = class150.Player_ExpErience - 15000000;
			Players playerMoney = class15_0;
			playerMoney.Player_Money = playerMoney.Player_Money - (long)1500000000;
			class15_0.Learn_Skill_Tip(1);
			class15_0.UpdatePowersAndStatus();
			class15_0.UpdateExperience();
			class15_0.UpdateMoneyAndWeight();
		}

		public static void Learn_Skill_Harin4(Players class15_0, TBL_XWWL_ITEM class7_0, int int_21)
		{
			if (class7_0.FLD_LEVEL > class15_0.Player_FLD_LEVEL)
			{
				class15_0.GameMessage("Nhan vat khong du level de hoc vo cong nay!", 9, "Msg");
				return;
			}
			if (class7_0.FLD_ZX != 0 && class7_0.FLD_ZX != class15_0.Player_Zx)
			{
				class15_0.GameMessage("The luc khong dong nhat khong the hoc vo cong!", 9, "Msg");
				return;
			}
			if (class7_0.FLD_RESIDE1 != 0 && class7_0.FLD_RESIDE1 != class15_0.Player_Job)
			{
				class15_0.GameMessage("Khong the hoc vo cong cua nhan vat khac!", 9, "Msg");
				return;
			}
			if (class7_0.FLD_JOB_LEVEL != 0 && class7_0.FLD_JOB_LEVEL > class15_0.Player_FLD_JOB_LEVEL)
			{
				class15_0.GameMessage("Nhan vat chua du danh vong de hoc vo cong!", 9, "Msg");
				return;
			}
			if (class15_0.Player_Money < (long)2000000000)
			{
				class15_0.GameMessage("Nhan vat khong du tien de hoc vo cong!", 9, "Msg");
				return;
			}
			if (class15_0.Player_ExpErience < 20000000)
			{
				class15_0.GameMessage("Nhan vat khong du diem ky nang de hoc vo cong!", 9, "Msg");
				return;
			}
			TBL_XWWL_KONGFU.Learn_Martial_Book(class15_0, 3, 18);
			TBL_XWWL_KONGFU.Learn_Martial_Book(class15_0, 3, 19);
			class15_0.UseItem(int_21, 1);
			Players class150 = class15_0;
			class150.Player_ExpErience = class150.Player_ExpErience - 20000000;
			Players playerMoney = class15_0;
			playerMoney.Player_Money = playerMoney.Player_Money - (long)2000000000;
			class15_0.Learn_Skill_Tip(1);
			class15_0.UpdatePowersAndStatus();
			class15_0.UpdateExperience();
			class15_0.UpdateMoneyAndWeight();
		}

		public void method_0(int int_21)
		{
			TBL_XWWL_KONGFU tBLXWWLKONGFU;
			if (World.TBL_KONGFU.TryGetValue(int_21, out tBLXWWLKONGFU))
			{
				this.FLD_AT = tBLXWWLKONGFU.FLD_AT;
				this.FLD_EFFERT = tBLXWWLKONGFU.FLD_EFFERT;
				this.FLD_INDEX = tBLXWWLKONGFU.FLD_INDEX;
				this.FLD_JOB = tBLXWWLKONGFU.FLD_JOB;
				this.FLD_JOBLEVEL = tBLXWWLKONGFU.FLD_JOBLEVEL;
				this.FLD_LEVEL = tBLXWWLKONGFU.FLD_LEVEL;
				this.FLD_MP = tBLXWWLKONGFU.FLD_MP;
				this.FLD_NEEDEXP = tBLXWWLKONGFU.FLD_NEEDEXP;
				this.FLD_PID = tBLXWWLKONGFU.FLD_PID;
				this.FLD_TYPE = tBLXWWLKONGFU.FLD_TYPE;
				this.FLD_ZX = tBLXWWLKONGFU.FLD_ZX;
				this.FLD_CONG_KICH_SO_LUONG = tBLXWWLKONGFU.FLD_CONG_KICH_SO_LUONG;
				this.FLD_VO_CONG_LOAI_HINH = tBLXWWLKONGFU.FLD_VO_CONG_LOAI_HINH;
				this.FLD_MOI_CAP_THEM_MP = tBLXWWLKONGFU.FLD_MOI_CAP_THEM_MP;
				this.FLD_CDTIME = tBLXWWLKONGFU.FLD_CDTIME;
				this.FLD_MOI_CAP_THEM_KINH_NGHIEM = tBLXWWLKONGFU.FLD_MOI_CAP_THEM_KINH_NGHIEM;
				this.FLD_MOI_CAP_THEM_NGUY_HAI = tBLXWWLKONGFU.FLD_MOI_CAP_THEM_NGUY_HAI;
				this.FLD_MOI_CAP_VO_CONG_DIEM_SO = tBLXWWLKONGFU.FLD_MOI_CAP_VO_CONG_DIEM_SO;
				this.FLD_TIME = tBLXWWLKONGFU.FLD_TIME;
				this.FLD_VO_CONG_CAO_NHAT_DANG_CAP = tBLXWWLKONGFU.FLD_VO_CONG_CAO_NHAT_DANG_CAP;
				this.FLD_MOI_CAP_THEM_DANG_CAP = tBLXWWLKONGFU.FLD_MOI_CAP_THEM_DANG_CAP;
			}
		}

		public static TBL_XWWL_KONGFU smethod_0(int int_21, int int_22, int int_23, int int_24)
		{
			TBL_XWWL_KONGFU tBLXWWLKONGFU;
			Dictionary<int, TBL_XWWL_KONGFU>.ValueCollection.Enumerator enumerator = World.TBL_KONGFU.Values.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					TBL_XWWL_KONGFU current = enumerator.Current;
					if (current.FLD_ZX != 0)
					{
						if (current.FLD_ZX != int_21 || current.FLD_JOB != int_22 || current.FLD_INDEX != int_24 || current.FLD_VO_CONG_LOAI_HINH != int_23)
						{
							continue;
						}
						tBLXWWLKONGFU = current;
						return tBLXWWLKONGFU;
					}
					else
					{
						if (current.FLD_JOB != int_22 || current.FLD_INDEX != int_24 || current.FLD_VO_CONG_LOAI_HINH != int_23)
						{
							continue;
						}
						tBLXWWLKONGFU = current;
						return tBLXWWLKONGFU;
					}
				}
				return null;
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			return tBLXWWLKONGFU;
		}

		public static bool smethod_1(Players class15_0, int int_21)
		{
			TBL_XWWL_KONGFU tBLXWWLKONGFU;
			if (!World.TBL_KONGFU.TryGetValue(int_21, out tBLXWWLKONGFU))
			{
				return false;
			}
			if (tBLXWWLKONGFU == null)
			{
				return false;
			}
			return class15_0.class79_0[tBLXWWLKONGFU.FLD_VO_CONG_LOAI_HINH, tBLXWWLKONGFU.FLD_INDEX].FLD_PID == int_21;
		}

		public static void smethod_11(Players class15_0, int int_21, int int_22, int int_23)
		{
			TBL_XWWL_KONGFU tBLXWWLKONGFU = TBL_XWWL_KONGFU.smethod_0(class15_0.Player_Zx, class15_0.Player_Job, int_21, int_22);
			if (tBLXWWLKONGFU != null)
			{
				if (class15_0.Player_ExpErience < tBLXWWLKONGFU.FLD_NEEDEXP)
				{
					return;
				}
				if (tBLXWWLKONGFU.FLD_ZX != 0 && class15_0.Player_Zx != tBLXWWLKONGFU.FLD_ZX)
				{
					return;
				}
				if (tBLXWWLKONGFU.FLD_JOB != 0 && class15_0.Player_Job != tBLXWWLKONGFU.FLD_JOB)
				{
					return;
				}
				if (tBLXWWLKONGFU.FLD_JOBLEVEL != 0 && class15_0.Player_FLD_JOB_LEVEL < tBLXWWLKONGFU.FLD_JOBLEVEL)
				{
					return;
				}
				if (tBLXWWLKONGFU.FLD_VO_CONG_CAO_NHAT_DANG_CAP != 0)
				{
					class15_0.class79_0[tBLXWWLKONGFU.FLD_VO_CONG_LOAI_HINH, tBLXWWLKONGFU.FLD_INDEX].VO_CONG_THU_BAC = 1;
				}
				if (tBLXWWLKONGFU.FLD_LEVEL != 0 && class15_0.Player_FLD_LEVEL < tBLXWWLKONGFU.FLD_LEVEL)
				{
					return;
				}
				class15_0.UseItem(int_23, 1);
				class15_0.class79_0[tBLXWWLKONGFU.FLD_VO_CONG_LOAI_HINH, tBLXWWLKONGFU.FLD_INDEX] = new TBL_XWWL_KONGFU(tBLXWWLKONGFU.FLD_PID);
				class15_0.CAP_NHAT_KY_NANG_MOI_LAM_DONG_BANG(tBLXWWLKONGFU.FLD_PID);
				Players class150 = class15_0;
				class150.Player_ExpErience = class150.Player_ExpErience - tBLXWWLKONGFU.FLD_NEEDEXP;
				class15_0.Learn_Skill_Tip(1);
				class15_0.UpdatePowersAndStatus();
				class15_0.UpdateExperience();
			}
		}

		public static TBL_XWWL_KONGFU smethod_2(Players class15_0, int int_21, int int_22)
		{
			TBL_XWWL_KONGFU tBLXWWLKONGFU = null;
			Dictionary<int, TBL_XWWL_KONGFU>.ValueCollection.Enumerator enumerator = World.TBL_KONGFU.Values.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					TBL_XWWL_KONGFU current = enumerator.Current;
					if (current.FLD_JOB != class15_0.Player_Job || current.FLD_INDEX != int_22 || current.FLD_VO_CONG_LOAI_HINH != int_21)
					{
						continue;
					}
					tBLXWWLKONGFU = current;
                              break;
				}
				
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			return tBLXWWLKONGFU;
		}

		void System.IDisposable.Dispose()
		{
		}
	}
}