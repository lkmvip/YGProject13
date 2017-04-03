using ns10;
using ns12;
using ns13;
using ns3;
using ns9;
using System;
using System.Collections.Generic;

namespace ns4
{
	internal class MissionClass : IDisposable
	{
		private Players class15_0;

		public MissionClass(Players Playr)
		{
			this.class15_0 = Playr;
		}

		~MissionClass()
		{
		}

		public void method_0(byte[] byte_0, int int_0)
		{
			this.class15_0.Packet_Modify(byte_0, int_0);
			int num = BitConverter.ToUInt16(byte_0, 11);
			int num1 = BitConverter.ToUInt16(byte_0, 13);
			int num2 = BitConverter.ToInt16(byte_0, 15);
			if (num <= 73)
			{
				if (num > 18)
				{
					if (num == 45)
					{
						this.method_5(num, num1, num2);
						return;
					}
					if (num == 46)
					{
						this.method_6(num, num1, num2);
						return;
					}
					if (num == 73)
					{
						this.method_7(num, num1, num2);
						return;
					}
				}
				else
				{
					if (num == 11)
					{
						this.method_3(num, num1, num2);
						return;
					}
					if (num == 12)
					{
						this.method_4(num, num1, num2);
						return;
					}
					if (num == 18)
					{
						this.method_2(num, num1, num2);
						return;
					}
				}
			}
			else if (num > 300)
			{
				if (num == 301)
				{
					this.method_11(num, num1, num2);
					return;
				}
				if (num == 9202)
				{
					this.method_14(num, num1, num2);
					return;
				}
				if (num == 9998)
				{
					this.method_13(num, num1, num2);
					return;
				}
			}
			else
			{
				if (num == 74)
				{
					this.method_8(num, num1, num2);
					return;
				}
				if (num == 178)
				{
					this.method_9(num, num1, num2);
					return;
				}
				if (num == 300)
				{
					this.method_10(num, num1, num2);
					return;
				}
			}
			switch (num1)
			{
				case 1:
				{
					this.method_1(num, 11, num2);
					return;
				}
				case 2:
				case 4:
				{
					return;
				}
				case 3:
				{
					this.method_1(num, 31, num2);
					return;
				}
				case 5:
				{
					this.method_1(num, 51, num2);
					return;
				}
				default:
				{
					return;
				}
			}
		}

		public void method_1(int int_0, int int_1, int int_2)
		{
			byte[] num = Converter.hexStringToByte("AA55150001000084000600120033000000000000000000000055AA");
			Buffer.BlockCopy(BitConverter.GetBytes(int_0), 0, num, 11, 2);
			Buffer.BlockCopy(BitConverter.GetBytes(int_1), 0, num, 13, 2);
			Buffer.BlockCopy(BitConverter.GetBytes(int_2), 0, num, 15, 2);
			Buffer.BlockCopy(BitConverter.GetBytes(this.class15_0.UserSessionID), 0, num, 5, 2);
			if (this.class15_0.Client != null)
			{
				this.class15_0.Client.Send(num, (int)num.Length);
			}
		}

		public void method_10(int int_0, int int_1, int int_2)
		{
			if (int_1 == 1)
			{
				if (this.class15_0.Player_FLD_LEVEL < 115 || this.class15_0.Player_WuXun < 2000 || this.class15_0.Player_Money < (long)1000000000)
				{
					this.method_1(int_0, 10, int_2);
				}
				else
				{
					this.method_1(int_0, 11, int_2);
				}
			}
			if (int_1 == 2)
			{
				if (this.class15_0.Player_FLD_JOB_LEVEL >= 6)
				{
					return;
				}
				if (this.class15_0.Player_FLD_LEVEL < 115 || this.class15_0.Player_WuXun < 2000 || this.class15_0.Player_Money < (long)1000000000)
				{
					this.method_1(int_0, 10, int_2);
				}
				else
				{
					int num = this.class15_0.DUOC_KIEN_HANG_RONG(this.class15_0);
					if (num != -1)
					{
						this.class15_0.NHAN_VAT_CHUYEN_NGHE_NGHIEP(this.class15_0.Player_Zx, 6);
						this.method_1(int_0, 21, 1);
						this.method_12(int_0, 1);
						byte[] bytes = BitConverter.GetBytes(RxjhClass.GetDBItmeId());
						int num1 = 0;
						switch (this.class15_0.Player_Job)
						{
							case 1:
							{
								if (this.class15_0.Player_Zx == 1)
								{
									num1 = 1000000336;
									break;
								}
								else
								{
									num1 = 1000000342;
									break;
								}
							}
							case 2:
							{
								if (this.class15_0.Player_Zx == 1)
								{
									num1 = 1000000337;
									break;
								}
								else
								{
									num1 = 1000000343;
									break;
								}
							}
							case 3:
							{
								if (this.class15_0.Player_Zx == 1)
								{
									num1 = 1000000338;
									break;
								}
								else
								{
									num1 = 1000000344;
									break;
								}
							}
							case 4:
							{
								if (this.class15_0.Player_Zx == 1)
								{
									num1 = 1000000339;
									break;
								}
								else
								{
									num1 = 1000000345;
									break;
								}
							}
							case 5:
							{
								if (this.class15_0.Player_Zx == 1)
								{
									num1 = 1000000340;
									break;
								}
								else
								{
									num1 = 1000000346;
									break;
								}
							}
							case 6:
							{
								if (this.class15_0.Player_Zx == 1)
								{
									num1 = 1000000341;
									break;
								}
								else
								{
									num1 = 1000000347;
									break;
								}
							}
						}
						this.class15_0.TANG_CUONG_VAT_PHAM_2(bytes, BitConverter.GetBytes(num1), num, BitConverter.GetBytes(1), new byte[56]);
						this.class15_0.UpdatePowersAndStatus();
						this.class15_0.UpdateExperience();
						this.class15_0.LAN_DAU_DOI_THOAI_DA_TRANG_BI_VAT_PHAM();
						this.class15_0.UpdateMoneyAndWeight();
					}
					else
					{
						this.class15_0.GameMessage("Equipment bar no vacancy, please clean up", 9, "System");
						this.method_1(int_0, 31, int_2);
					}
				}
			}
			if (int_1 == 3)
			{
				this.method_1(int_0, 31, int_2);
			}
		}

		public void method_11(int int_0, int int_1, int int_2)
		{
			if (int_1 == 1)
			{
				if (this.class15_0.Player_FLD_LEVEL < 120 || this.class15_0.Player_Money < (long)1000000000)
				{
					this.method_1(int_0, 10, int_2);
				}
				else
				{
					this.method_1(int_0, 11, int_2);
				}
			}
			if (int_1 == 2)
			{
				if (this.class15_0.Player_FLD_JOB_LEVEL >= 7)
				{
					return;
				}
				if (this.class15_0.Player_FLD_LEVEL < 120 || this.class15_0.Player_Money < (long)1000000000)
				{
					this.method_1(int_0, 10, int_2);
				}
				else
				{
					int num = this.class15_0.DUOC_KIEN_HANG_RONG(this.class15_0);
					if (num != -1)
					{
						this.class15_0.NHAN_VAT_CHUYEN_NGHE_NGHIEP(this.class15_0.Player_Zx, 7);
						this.method_1(int_0, 21, 1);
						this.method_12(int_0, 1);
						byte[] bytes = BitConverter.GetBytes(RxjhClass.GetDBItmeId());
						int num1 = 0;
						switch (this.class15_0.Player_Job)
						{
							case 1:
							{
								if (this.class15_0.Player_Zx == 1)
								{
									num1 = 1000000388;
									break;
								}
								else
								{
									num1 = 1000000394;
									break;
								}
							}
							case 2:
							{
								if (this.class15_0.Player_Zx == 1)
								{
									num1 = 1000000389;
									break;
								}
								else
								{
									num1 = 1000000395;
									break;
								}
							}
							case 3:
							{
								if (this.class15_0.Player_Zx == 1)
								{
									num1 = 1000000390;
									break;
								}
								else
								{
									num1 = 1000000396;
									break;
								}
							}
							case 4:
							{
								if (this.class15_0.Player_Zx == 1)
								{
									num1 = 1000000391;
									break;
								}
								else
								{
									num1 = 1000000397;
									break;
								}
							}
							case 5:
							{
								if (this.class15_0.Player_Zx == 1)
								{
									num1 = 1000000392;
									break;
								}
								else
								{
									num1 = 1000000398;
									break;
								}
							}
							case 6:
							{
								if (this.class15_0.Player_Zx == 1)
								{
									num1 = 1000000393;
									break;
								}
								else
								{
									num1 = 1000000399;
									break;
								}
							}
						}
						this.class15_0.TANG_CUONG_VAT_PHAM_2(bytes, BitConverter.GetBytes(num1), num, BitConverter.GetBytes(1), new byte[56]);
						this.class15_0.UpdatePowersAndStatus();
						this.class15_0.UpdateExperience();
						this.class15_0.LAN_DAU_DOI_THOAI_DA_TRANG_BI_VAT_PHAM();
						this.class15_0.UpdateMoneyAndWeight();
					}
					else
					{
						this.class15_0.GameMessage("Equipment bar no vacancy, please clean up", 9, "System");
						this.method_1(int_0, 31, int_2);
					}
				}
			}
			if (int_1 == 3)
			{
				this.method_1(int_0, 31, int_2);
			}
		}

		public void method_12(int int_0, int int_1)
		{
			NHIEM_VU_CLASS int1;
			if (this.class15_0.dictionary_2.TryGetValue(int_0, out int1))
			{
				int1.NHIEM_VU_GIAI_DOAN_ID = int_1;
				return;
			}
			int1 = new NHIEM_VU_CLASS()
			{
				NHIEM_VU_ID = int_0,
				NHIEM_VU_GIAI_DOAN_ID = int_1
			};
			if (!this.class15_0.dictionary_2.ContainsKey(int_0))
			{
				this.class15_0.dictionary_2.Add(int_0, int1);
			}
		}

		public void method_13(int int_0, int int_1, int int_2)
		{
			if (int_2 != 0)
			{
				int num = this.class15_0.DUOC_KIEN_HANG_RONG(this.class15_0);
				if (num != -1)
				{
					byte[] bytes = BitConverter.GetBytes(RxjhClass.GetDBItmeId());
					this.class15_0.TANG_CUONG_VAT_PHAM_2(bytes, BitConverter.GetBytes(1700101), num, BitConverter.GetBytes(1), new byte[56]);
					this.method_1(int_0, 11, 2);
					this.method_12(int_0, 2);
					return;
				}
				this.method_1(int_0, 10, int_2);
			}
			else
			{
				if (int_1 == 1)
				{
					this.method_1(int_0, 11, int_2);
					return;
				}
				if (int_1 == 2)
				{
					this.method_1(int_0, 21, int_2);
					this.method_12(int_0, 1);
					return;
				}
				if (int_1 == 3)
				{
					this.method_1(int_0, 31, int_2);
					return;
				}
				if (int_1 == 5)
				{
					this.method_1(int_0, 51, int_2);
					return;
				}
			}
		}

		public void method_14(int int_0, int int_1, int int_2)
		{
			if (int_2 != 0)
			{
				int num = 0;
				int num1 = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				for (int i = 0; i < 36; i++)
				{
					if (BitConverter.ToInt32(this.class15_0.TRANG_BI_LAN_BAO_VAY[i].VAT_PHAM_ID, 0) == 1000000161)
					{
						num = 1;
					}
					else if (BitConverter.ToInt32(this.class15_0.TRANG_BI_LAN_BAO_VAY[i].VAT_PHAM_ID, 0) == 1000000162)
					{
						num1 = 1;
					}
					else if (BitConverter.ToInt32(this.class15_0.TRANG_BI_LAN_BAO_VAY[i].VAT_PHAM_ID, 0) == 1000000163)
					{
						num2 = 1;
					}
					else if (BitConverter.ToInt32(this.class15_0.TRANG_BI_LAN_BAO_VAY[i].VAT_PHAM_ID, 0) == 1000000164)
					{
						num3 = 1;
					}
					else if (BitConverter.ToInt32(this.class15_0.TRANG_BI_LAN_BAO_VAY[i].VAT_PHAM_ID, 0) == 1000000199)
					{
						num4 = 1;
					}
				}
				if (num == 0 || num1 == 0 || num2 == 0 || num3 == 0 || num4 == 0)
				{
					this.method_1(int_0, 12, int_2);
					return;
				}
				for (int j = 0; j < 36; j++)
				{
					if (BitConverter.ToInt32(this.class15_0.TRANG_BI_LAN_BAO_VAY[j].VAT_PHAM_ID, 0) == 1000000161)
					{
						this.class15_0.LAM_GIAM_DI_VAT_PHAM(j, 1);
					}
					else if (BitConverter.ToInt32(this.class15_0.TRANG_BI_LAN_BAO_VAY[j].VAT_PHAM_ID, 0) == 1000000162)
					{
						this.class15_0.LAM_GIAM_DI_VAT_PHAM(j, 1);
					}
					else if (BitConverter.ToInt32(this.class15_0.TRANG_BI_LAN_BAO_VAY[j].VAT_PHAM_ID, 0) == 1000000163)
					{
						this.class15_0.LAM_GIAM_DI_VAT_PHAM(j, 1);
					}
					else if (BitConverter.ToInt32(this.class15_0.TRANG_BI_LAN_BAO_VAY[j].VAT_PHAM_ID, 0) == 1000000164)
					{
						this.class15_0.LAM_GIAM_DI_VAT_PHAM(j, 1);
					}
					else if (BitConverter.ToInt32(this.class15_0.TRANG_BI_LAN_BAO_VAY[j].VAT_PHAM_ID, 0) == 1000000199)
					{
						this.class15_0.LAM_GIAM_DI_VAT_PHAM(j, 1);
					}
				}
				int num5 = this.class15_0.DUOC_KIEN_HANG_RONG(this.class15_0);
				byte[] bytes = BitConverter.GetBytes(RxjhClass.GetDBItmeId());
				this.class15_0.TANG_CUONG_VAT_PHAM(bytes, BitConverter.GetBytes(1000000365), num5, BitConverter.GetBytes(1), new byte[56]);
				this.method_1(int_0, 11, 2);
				this.method_12(int_0, 3);
			}
			else
			{
				if (int_1 == 1)
				{
					this.method_1(int_0, 11, int_2);
					return;
				}
				if (int_1 == 2)
				{
					this.method_1(int_0, 21, int_2);
					this.method_12(int_0, 1);
					return;
				}
				if (int_1 == 3)
				{
					this.method_1(int_0, 31, int_2);
					return;
				}
			}
		}

		public void method_2(int int_0, int int_1, int int_2)
		{
			if (int_1 == 1)
			{
				if (this.class15_0.Player_FLD_LEVEL < 10 || this.class15_0.Player_Qigong_point > 0)
				{
					this.method_1(int_0, 10, int_2);
				}
				else
				{
					this.method_1(int_0, 11, int_2);
				}
			}
			if (int_1 == 2)
			{
				if (this.class15_0.Player_FLD_JOB_LEVEL >= 1)
				{
					return;
				}
				if (this.class15_0.Player_FLD_LEVEL < 10 || this.class15_0.Player_Qigong_point > 0)
				{
					this.method_1(int_0, 10, int_2);
				}
				else
				{
					this.class15_0.NHAN_VAT_CHUYEN_NGHE_NGHIEP(0, 1);
					this.method_1(int_0, 21, 1);
					this.method_12(int_0, 1);
					if (BitConverter.ToInt16(this.class15_0.Qigong[5].气功_byte, 0) == 255)
					{
						this.class15_0.Qigong[5] = new QigongClass(new byte[2]);
					}
					this.class15_0.UpdatePowersAndStatus();
					Players class150 = this.class15_0;
					class150.Player_Money = class150.Player_Money + (long)20000000;
					this.class15_0.UpdateMoneyAndWeight();
				}
			}
			if (int_1 == 3)
			{
				this.method_1(int_0, 31, int_2);
			}
		}

		public void method_3(int int_0, int int_1, int int_2)
		{
			if (int_1 == 1)
			{
				if (this.class15_0.Player_FLD_LEVEL < 35 || this.class15_0.Player_Qigong_point > 0)
				{
					this.method_1(int_0, 10, int_2);
				}
				else
				{
					this.method_1(int_0, 11, int_2);
				}
			}
			if (int_1 == 2)
			{
				if (this.class15_0.Player_FLD_JOB_LEVEL >= 2)
				{
					return;
				}
				if (this.class15_0.Player_FLD_LEVEL < 35 || this.class15_0.Player_Qigong_point > 0)
				{
					this.method_1(int_0, 10, int_2);
				}
				else
				{
					this.class15_0.NHAN_VAT_CHUYEN_NGHE_NGHIEP(1, 2);
					this.method_1(int_0, 21, 1);
					this.method_12(int_0, 1);
					if (BitConverter.ToInt16(this.class15_0.Qigong[6].气功_byte, 0) == 255)
					{
						this.class15_0.Qigong[6] = new QigongClass(new byte[2]);
					}
					this.class15_0.UpdatePowersAndStatus();
					this.class15_0.LAN_DAU_DOI_THOAI_DA_TRANG_BI_VAT_PHAM();
					Players class150 = this.class15_0;
					class150.Player_Money = class150.Player_Money + (long)100000000;
					this.class15_0.UpdateMoneyAndWeight();
				}
			}
			if (int_1 == 3)
			{
				this.method_1(int_0, 31, int_2);
			}
		}

		public void method_4(int int_0, int int_1, int int_2)
		{
			if (int_1 == 1)
			{
				if (this.class15_0.Player_FLD_LEVEL < 35 || this.class15_0.Player_Qigong_point > 0)
				{
					this.method_1(int_0, 10, int_2);
				}
				else
				{
					this.method_1(int_0, 11, int_2);
				}
			}
			if (int_1 == 2)
			{
				if (this.class15_0.Player_FLD_JOB_LEVEL >= 2)
				{
					return;
				}
				if (this.class15_0.Player_FLD_LEVEL < 35 || this.class15_0.Player_Qigong_point > 0)
				{
					this.method_1(int_0, 10, int_2);
				}
				else
				{
					this.class15_0.NHAN_VAT_CHUYEN_NGHE_NGHIEP(2, 2);
					this.method_1(int_0, 21, 1);
					this.method_12(int_0, 1);
					if (BitConverter.ToInt16(this.class15_0.Qigong[6].气功_byte, 0) == 255)
					{
						this.class15_0.Qigong[6] = new QigongClass(new byte[2]);
					}
					this.class15_0.UpdatePowersAndStatus();
					this.class15_0.LAN_DAU_DOI_THOAI_DA_TRANG_BI_VAT_PHAM();
					Players class150 = this.class15_0;
					class150.Player_Money = class150.Player_Money + (long)100000000;
					this.class15_0.UpdateMoneyAndWeight();
				}
			}
			if (int_1 == 3)
			{
				this.method_1(int_0, 31, int_2);
			}
		}

		public void method_5(int int_0, int int_1, int int_2)
		{
			if (int_1 == 1)
			{
				if (this.class15_0.Player_FLD_LEVEL < 60 || this.class15_0.Player_Qigong_point > 0)
				{
					this.method_1(int_0, 10, int_2);
				}
				else
				{
					this.method_1(int_0, 11, int_2);
				}
			}
			if (int_1 == 2)
			{
				if (this.class15_0.Player_FLD_JOB_LEVEL >= 3)
				{
					return;
				}
				if (this.class15_0.Player_FLD_LEVEL < 60 || this.class15_0.Player_Qigong_point > 0)
				{
					this.method_1(int_0, 10, int_2);
				}
				else
				{
					this.class15_0.NHAN_VAT_CHUYEN_NGHE_NGHIEP(this.class15_0.Player_Zx, 3);
					this.method_1(int_0, 21, 1);
					this.method_12(int_0, 1);
					if (BitConverter.ToInt16(this.class15_0.Qigong[7].气功_byte, 0) == 255)
					{
						this.class15_0.Qigong[7] = new QigongClass(new byte[2]);
					}
					this.class15_0.UpdatePowersAndStatus();
					Players class150 = this.class15_0;
					class150.Player_Money = class150.Player_Money + (long)200000000;
					this.class15_0.UpdateMoneyAndWeight();
				}
			}
			if (int_1 == 3)
			{
				this.method_1(int_0, 31, int_2);
			}
		}

		public void method_6(int int_0, int int_1, int int_2)
		{
			if (int_1 == 1)
			{
				if (this.class15_0.Player_FLD_LEVEL < 60 || this.class15_0.Player_Qigong_point > 0)
				{
					this.method_1(int_0, 10, int_2);
				}
				else
				{
					this.method_1(int_0, 11, int_2);
				}
			}
			if (int_1 == 2)
			{
				if (this.class15_0.Player_FLD_JOB_LEVEL >= 3)
				{
					return;
				}
				if (this.class15_0.Player_FLD_LEVEL < 60 || this.class15_0.Player_Qigong_point > 0)
				{
					this.method_1(int_0, 10, int_2);
				}
				else
				{
					this.class15_0.NHAN_VAT_CHUYEN_NGHE_NGHIEP(this.class15_0.Player_Zx, 3);
					this.method_1(int_0, 21, 1);
					this.method_12(int_0, 1);
					if (BitConverter.ToInt16(this.class15_0.Qigong[7].气功_byte, 0) == 255)
					{
						this.class15_0.Qigong[7] = new QigongClass(new byte[2]);
					}
					this.class15_0.UpdatePowersAndStatus();
					Players class150 = this.class15_0;
					class150.Player_Money = class150.Player_Money + (long)200000000;
					this.class15_0.UpdateMoneyAndWeight();
				}
			}
			if (int_1 == 3)
			{
				this.method_1(int_0, 31, int_2);
			}
		}

		public void method_7(int int_0, int int_1, int int_2)
		{
			if (int_1 == 1)
			{
				if (this.class15_0.Player_FLD_LEVEL < 80 || this.class15_0.Player_Qigong_point > 0)
				{
					this.method_1(int_0, 10, int_2);
				}
				else
				{
					this.method_1(int_0, 11, int_2);
				}
			}
			if (int_1 == 2)
			{
				if (this.class15_0.Player_FLD_JOB_LEVEL >= 4)
				{
					return;
				}
				if (this.class15_0.Player_FLD_LEVEL < 80 || this.class15_0.Player_Qigong_point > 0)
				{
					this.method_1(int_0, 10, int_2);
				}
				else
				{
					this.class15_0.NHAN_VAT_CHUYEN_NGHE_NGHIEP(this.class15_0.Player_Zx, 4);
					this.method_1(int_0, 21, 1);
					this.method_12(int_0, 1);
					if (BitConverter.ToInt16(this.class15_0.Qigong[8].气功_byte, 0) == 255)
					{
						this.class15_0.Qigong[8] = new QigongClass(new byte[2]);
					}
					if (BitConverter.ToInt16(this.class15_0.Qigong[9].气功_byte, 0) == 255)
					{
						this.class15_0.Qigong[9] = new QigongClass(new byte[2]);
					}
					this.class15_0.UpdatePowersAndStatus();
					Players class150 = this.class15_0;
					class150.Player_Money = class150.Player_Money + (long)300000000;
					this.class15_0.UpdateMoneyAndWeight();
				}
			}
			if (int_1 == 3)
			{
				this.method_1(int_0, 31, int_2);
			}
		}

		public void method_8(int int_0, int int_1, int int_2)
		{
			if (int_1 == 1)
			{
				if (this.class15_0.Player_FLD_LEVEL < 80 || this.class15_0.Player_Qigong_point > 0)
				{
					this.method_1(int_0, 10, int_2);
				}
				else
				{
					this.method_1(int_0, 11, int_2);
				}
			}
			if (int_1 == 2)
			{
				if (this.class15_0.Player_FLD_JOB_LEVEL >= 4)
				{
					return;
				}
				if (this.class15_0.Player_FLD_LEVEL < 80 || this.class15_0.Player_Qigong_point > 0)
				{
					this.method_1(int_0, 10, int_2);
				}
				else
				{
					this.class15_0.NHAN_VAT_CHUYEN_NGHE_NGHIEP(this.class15_0.Player_Zx, 4);
					this.method_1(int_0, 21, 1);
					this.method_12(int_0, 1);
					if (BitConverter.ToInt16(this.class15_0.Qigong[8].气功_byte, 0) == 255)
					{
						this.class15_0.Qigong[8] = new QigongClass(new byte[2]);
					}
					if (BitConverter.ToInt16(this.class15_0.Qigong[9].气功_byte, 0) == 255)
					{
						this.class15_0.Qigong[9] = new QigongClass(new byte[2]);
					}
					this.class15_0.UpdatePowersAndStatus();
					Players class150 = this.class15_0;
					class150.Player_Money = class150.Player_Money + (long)300000000;
					this.class15_0.UpdateMoneyAndWeight();
				}
			}
			if (int_1 == 3)
			{
				this.method_1(int_0, 31, int_2);
			}
		}

		public void method_9(int int_0, int int_1, int int_2)
		{
			if (int_1 == 1)
			{
				if (this.class15_0.Player_FLD_LEVEL >= 100)
				{
					this.method_1(int_0, 11, int_2);
				}
				else
				{
					this.method_1(int_0, 10, int_2);
				}
			}
			if (int_1 == 2)
			{
				if (this.class15_0.Player_FLD_JOB_LEVEL >= 5)
				{
					return;
				}
				if (this.class15_0.Player_FLD_LEVEL >= 100)
				{
					this.class15_0.NHAN_VAT_CHUYEN_NGHE_NGHIEP(this.class15_0.Player_Zx, 5);
					this.method_1(int_0, 21, 1);
					this.method_12(int_0, 1);
					if (BitConverter.ToInt16(this.class15_0.Qigong[10].气功_byte, 0) == 255)
					{
						this.class15_0.Qigong[10] = new QigongClass(new byte[2]);
					}
					this.class15_0.method_412(0, 25);
					this.class15_0.method_412(0, 26);
					this.class15_0.method_412(0, 27);
					this.class15_0.UpdatePowersAndStatus();
					this.class15_0.UpdateExperience();
					Players class150 = this.class15_0;
					class150.Player_Money = class150.Player_Money + (long)400000000;
					this.class15_0.UpdateMoneyAndWeight();
				}
				else
				{
					this.method_1(int_0, 10, int_2);
				}
			}
			if (int_1 == 3)
			{
				this.method_1(int_0, 31, int_2);
			}
		}

		void System.IDisposable.Dispose()
		{
			this.class15_0 = null;
		}
	}
}