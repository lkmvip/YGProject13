using ns13;
using ns2;
using ns3;
using System;

namespace ns1
{
	public class HcItimesClass
	{
		private byte[] byte_0;

		private byte[] byte_1;

		private ITEMSX class8_0;

		private ITEMSX class8_1;

		private ITEMSX class8_2;

		private ITEMSX class8_3;

		private int int_0;

		private int int_1;

		private int int_2;

		private int int_3;

		private int int_4;

		private int int_5;

		public int FLD_FJ_thuc_tinh
		{
			get
			{
				byte[] numArray = new byte[4];
				Buffer.BlockCopy(this.VAT_PHAM, 62, numArray, 0, 4);
				return BitConverter.ToInt32(numArray, 0);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, this.VAT_PHAM, 62, 4);
			}
		}

		public int FLD_FJ_tien_hoa
		{
			get
			{
				byte[] numArray = new byte[4];
				Buffer.BlockCopy(this.VAT_PHAM, 68, numArray, 0, 2);
				return BitConverter.ToInt32(numArray, 0);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, this.VAT_PHAM, 68, 2);
			}
		}

		public int FLD_FJ_trung_cap_phu_hon
		{
			get
			{
				byte[] numArray = new byte[2];
				Buffer.BlockCopy(this.VAT_PHAM, 40, numArray, 0, 2);
				return BitConverter.ToInt16(numArray, 0);
			}
			set
			{
				if (value > 0)
				{
					Buffer.BlockCopy(BitConverter.GetBytes(1), 0, this.VAT_PHAM, 38, 2);
				}
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, this.VAT_PHAM, 40, 2);
			}
		}

		public byte[] Item_thuoc_tinh
		{
			get
			{
				return this.method_0();
			}
		}

		public byte[] Item_toan_bo_ID
		{
			get
			{
				return this.method_7();
			}
		}

		public int KHI_CONG_THUOC_TINH_LOAI_HINH
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

		public int NumberOfPhase
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

		public int PhaseType
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

		public int StrengthNumber
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

		public int StrengthType
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

		public ITEMSX Thuoc_tinh_1
		{
			get
			{
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
				return this.class8_3;
			}
			set
			{
				this.class8_3 = value;
			}
		}

		public byte[] VAT_PHAM
		{
			get
			{
				return this.byte_0;
			}
			set
			{
				this.byte_0 = value;
			}
		}

		public byte[] VAT_PHAM_SO_LUONG
		{
			get
			{
				return this.method_2();
			}
			set
			{
				this.method_3(value);
			}
		}

		public byte[] VAT_PHAMid
		{
			get
			{
				return this.method_1();
			}
			set
			{
				this.byte_1 = value;
			}
		}

		public int VI_TRI
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

		public HcItimesClass()
		{
		}

		public byte[] method_0()
		{
			byte[] numArray = new byte[56];
			try
			{
				Buffer.BlockCopy(this.VAT_PHAM, 16, numArray, 0, 56);
			}
			catch
			{
			}
			return numArray;
		}

		public byte[] method_1()
		{
			byte[] numArray = new byte[4];
			try
			{
				Buffer.BlockCopy(this.VAT_PHAM, 8, numArray, 0, 4);
			}
			catch
			{
			}
			return numArray;
		}

		public byte[] method_2()
		{
			byte[] numArray = new byte[4];
			try
			{
				Buffer.BlockCopy(this.VAT_PHAM, 12, numArray, 0, 4);
			}
			catch
			{
			}
			return numArray;
		}

		public void method_3(byte[] byte_2)
		{
			Buffer.BlockCopy(byte_2, 0, this.VAT_PHAM, 12, 4);
		}

		public void method_5()
		{
			try
			{
				byte[] numArray = new byte[4];
				byte[] numArray1 = new byte[4];
				byte[] numArray2 = new byte[4];
				byte[] numArray3 = new byte[4];
				Buffer.BlockCopy(this.VAT_PHAM, 20, numArray, 0, 4);
				Buffer.BlockCopy(this.VAT_PHAM, 24, numArray1, 0, 4);
				Buffer.BlockCopy(this.VAT_PHAM, 28, numArray2, 0, 4);
				Buffer.BlockCopy(this.VAT_PHAM, 32, numArray3, 0, 4);
				this.Thuoc_tinh_1 = new ITEMSX(numArray);
				this.Thuoc_tinh_2 = new ITEMSX(numArray1);
				this.Thuoc_tinh_3 = new ITEMSX(numArray2);
				this.Thuoc_tinh_4 = new ITEMSX(numArray3);
			}
			catch (Exception exception)
			{
				Form1.WriteLine(1, string.Concat("合成 得到属性 出错：", exception));
			}
		}

		public void method_6()
		{
			try
			{
				string str = "00000000";
				string str1 = "0000000000";
				if (this.StrengthNumber != 0)
				{
					str = (this.StrengthNumber < 10 ? string.Concat(this.StrengthType, "000000", this.StrengthNumber) : string.Concat(this.StrengthType, "00000", this.StrengthNumber));
				}
				if (this.NumberOfPhase != 0)
				{
					this.NumberOfPhase = this.NumberOfPhase - 1;
					str1 = string.Concat(new object[] { "100000", this.PhaseType, this.NumberOfPhase, "00" });
				}
				Buffer.BlockCopy(BitConverter.GetBytes(int.Parse(str) + int.Parse(str1)), 0, this.VAT_PHAM, 16, 4);
			}
			catch (Exception exception)
			{
				Form1.WriteLine(1, string.Concat("合成 设置阶段属性 出错：", exception));
			}
		}

		public byte[] method_7()
		{
			byte[] numArray = new byte[8];
			try
			{
				Buffer.BlockCopy(this.VAT_PHAM, 0, numArray, 0, 8);
			}
			catch
			{
			}
			return numArray;
		}

		public void method_8()
		{
			try
			{
				byte[] numArray = new byte[4];
				Buffer.BlockCopy(this.VAT_PHAM, 16, numArray, 0, 4);
				string str = BitConverter.ToInt32(numArray, 0).ToString();
				switch (str.Length)
				{
					case 1:
					{
						this.NumberOfPhase = int.Parse(str.Substring(0, 1));
						return;
					}
					case 2:
					{
						this.NumberOfPhase = int.Parse(str.Substring(0, 2));
						return;
					}
					case 3:
					case 4:
					case 5:
					case 9:
					{
						return;
					}
					case 6:
					{
						this.PhaseType = int.Parse(str.Substring(0, 1));
						if (this.PhaseType == 8)
						{
							this.KHI_CONG_THUOC_TINH_LOAI_HINH = int.Parse(str.Substring(2, 2));
						}
						if (World.Thuoc_tinh_mo_rong_co_hay_khong_mo_ra == 0)
						{
							this.NumberOfPhase = int.Parse(str.Substring(4, 2));
						}
						else
						{
							this.NumberOfPhase = int.Parse(str) - int.Parse(str.Substring(0, 1)) * 100000;
						}
						return;
					}
					case 7:
					{
						this.PhaseType = int.Parse(str.Substring(0, 1));
						if (this.PhaseType != 2)
						{
							this.PhaseType = int.Parse(str.Substring(0, 2));
							if (World.Thuoc_tinh_mo_rong_co_hay_khong_mo_ra == 0)
							{
								this.NumberOfPhase = int.Parse(str.Substring(5, 2));
							}
							else
							{
								this.NumberOfPhase = int.Parse(str) - int.Parse(str.Substring(0, 2)) * 100000;
							}
							return;
						}
						else
						{
							this.PhaseType = int.Parse(str.Substring(3, 1));
							return;
						}
					}
					case 8:
					{
						this.StrengthType = int.Parse(str.Substring(0, 1));
						this.StrengthNumber = int.Parse(str.Substring(str.Length - 2, 2));
						return;
					}
					case 10:
					{
						this.PhaseType = int.Parse(str.Substring(6, 1));
						this.NumberOfPhase = int.Parse(str.Substring(7, 1)) + 1;
						this.StrengthType = int.Parse(str.Substring(2, 1));
						this.StrengthNumber = int.Parse(str.Substring(str.Length - 2, 2));
						break;
					}
				}
			}
			catch (Exception exception)
			{
				Form1.WriteLine(1, string.Concat("合成 强化属性阶段 出错：", exception));
			}
		}

		public void SetProperty()
		{
			try
			{
				string str = "00000000";
				string str1 = "00000000";
				string str2 = "00000000";
				string str3 = "00000000";
				if (World.Thuoc_tinh_mo_rong_co_hay_khong_mo_ra != 0)
				{
					if (this.Thuoc_tinh_1.Number_Prop != 0)
					{
						switch (this.Thuoc_tinh_1.Number_Prop.ToString().Length)
						{
							case 1:
							{
								str = string.Concat(this.Thuoc_tinh_1.Prop_Type, "000000", this.Thuoc_tinh_1.Number_Prop);
								break;
							}
							case 2:
							{
								str = string.Concat(this.Thuoc_tinh_1.Prop_Type, "00000", this.Thuoc_tinh_1.Number_Prop);
								break;
							}
							case 3:
							{
								str = string.Concat(this.Thuoc_tinh_1.Prop_Type, "0000", this.Thuoc_tinh_1.Number_Prop);
								break;
							}
							case 4:
							{
								str = string.Concat(this.Thuoc_tinh_1.Prop_Type, "000", this.Thuoc_tinh_1.Number_Prop);
								break;
							}
							case 5:
							{
								str = string.Concat(this.Thuoc_tinh_1.Prop_Type, "00", this.Thuoc_tinh_1.Number_Prop);
								break;
							}
						}
					}
					if (this.Thuoc_tinh_2.Number_Prop != 0)
					{
						switch (this.Thuoc_tinh_2.Number_Prop.ToString().Length)
						{
							case 1:
							{
								str1 = string.Concat(this.Thuoc_tinh_2.Prop_Type, "000000", this.Thuoc_tinh_2.Number_Prop);
								break;
							}
							case 2:
							{
								str1 = string.Concat(this.Thuoc_tinh_2.Prop_Type, "00000", this.Thuoc_tinh_2.Number_Prop);
								break;
							}
							case 3:
							{
								str1 = string.Concat(this.Thuoc_tinh_2.Prop_Type, "0000", this.Thuoc_tinh_2.Number_Prop);
								break;
							}
							case 4:
							{
								str1 = string.Concat(this.Thuoc_tinh_2.Prop_Type, "000", this.Thuoc_tinh_2.Number_Prop);
								break;
							}
							case 5:
							{
								str1 = string.Concat(this.Thuoc_tinh_2.Prop_Type, "00", this.Thuoc_tinh_2.Number_Prop);
								break;
							}
						}
					}
					if (this.Thuoc_tinh_3.Number_Prop != 0)
					{
						switch (this.Thuoc_tinh_3.Number_Prop.ToString().Length)
						{
							case 1:
							{
								str2 = string.Concat(this.Thuoc_tinh_3.Prop_Type, "000000", this.Thuoc_tinh_3.Number_Prop);
								break;
							}
							case 2:
							{
								str2 = string.Concat(this.Thuoc_tinh_3.Prop_Type, "00000", this.Thuoc_tinh_3.Number_Prop);
								break;
							}
							case 3:
							{
								str2 = string.Concat(this.Thuoc_tinh_3.Prop_Type, "0000", this.Thuoc_tinh_3.Number_Prop);
								break;
							}
							case 4:
							{
								str2 = string.Concat(this.Thuoc_tinh_3.Prop_Type, "000", this.Thuoc_tinh_3.Number_Prop);
								break;
							}
							case 5:
							{
								str2 = string.Concat(this.Thuoc_tinh_3.Prop_Type, "00", this.Thuoc_tinh_3.Number_Prop);
								break;
							}
						}
					}
					if (this.Thuoc_tinh_4.Number_Prop != 0)
					{
						switch (this.Thuoc_tinh_4.Number_Prop.ToString().Length)
						{
							case 1:
							{
								str3 = string.Concat(this.Thuoc_tinh_4.Prop_Type, "000000", this.Thuoc_tinh_4.Number_Prop);
								break;
							}
							case 2:
							{
								str3 = string.Concat(this.Thuoc_tinh_4.Prop_Type, "00000", this.Thuoc_tinh_4.Number_Prop);
								break;
							}
							case 3:
							{
								str3 = string.Concat(this.Thuoc_tinh_4.Prop_Type, "0000", this.Thuoc_tinh_4.Number_Prop);
								break;
							}
							case 4:
							{
								str3 = string.Concat(this.Thuoc_tinh_4.Prop_Type, "000", this.Thuoc_tinh_4.Number_Prop);
								break;
							}
							case 5:
							{
								str3 = string.Concat(this.Thuoc_tinh_4.Prop_Type, "00", this.Thuoc_tinh_4.Number_Prop);
								break;
							}
						}
					}
				}
				else
				{
					if (this.Thuoc_tinh_1.Number_Prop != 0)
					{
						if (this.Thuoc_tinh_1.Number_Prop < 10)
						{
							str = (this.Thuoc_tinh_1.Prop_Type != 8 || this.Thuoc_tinh_1.QigqongPropType == 0 ? string.Concat(this.Thuoc_tinh_1.Prop_Type, "000000", this.Thuoc_tinh_1.Number_Prop) : string.Concat(new object[] { this.Thuoc_tinh_1.Prop_Type, "000", this.Thuoc_tinh_1.QigqongPropType, "0", this.Thuoc_tinh_1.Number_Prop }));
						}
						else
						{
							str = (this.Thuoc_tinh_1.Prop_Type != 8 || this.Thuoc_tinh_1.QigqongPropType == 0 ? string.Concat(this.Thuoc_tinh_1.Prop_Type, "00000", this.Thuoc_tinh_1.Number_Prop) : string.Concat(new object[] { this.Thuoc_tinh_1.Prop_Type, "000", this.Thuoc_tinh_1.QigqongPropType, this.Thuoc_tinh_1.Number_Prop }));
						}
					}
					if (this.Thuoc_tinh_2.Number_Prop != 0)
					{
						if (this.Thuoc_tinh_2.Number_Prop < 10)
						{
							str1 = (this.Thuoc_tinh_2.Prop_Type != 8 || this.Thuoc_tinh_2.QigqongPropType == 0 ? string.Concat(this.Thuoc_tinh_2.Prop_Type, "000000", this.Thuoc_tinh_2.Number_Prop) : string.Concat(new object[] { this.Thuoc_tinh_2.Prop_Type, "000", this.Thuoc_tinh_2.QigqongPropType, "0", this.Thuoc_tinh_2.Number_Prop }));
						}
						else
						{
							str1 = (this.Thuoc_tinh_2.Prop_Type != 8 || this.Thuoc_tinh_2.QigqongPropType == 0 ? string.Concat(this.Thuoc_tinh_2.Prop_Type, "00000", this.Thuoc_tinh_2.Number_Prop) : string.Concat(new object[] { this.Thuoc_tinh_2.Prop_Type, "000", this.Thuoc_tinh_2.QigqongPropType, this.Thuoc_tinh_2.Number_Prop }));
						}
					}
					if (this.Thuoc_tinh_3.Number_Prop != 0)
					{
						if (this.Thuoc_tinh_3.Number_Prop < 10)
						{
							str2 = (this.Thuoc_tinh_3.Prop_Type != 8 || this.Thuoc_tinh_3.QigqongPropType == 0 ? string.Concat(this.Thuoc_tinh_3.Prop_Type, "000000", this.Thuoc_tinh_3.Number_Prop) : string.Concat(new object[] { this.Thuoc_tinh_3.Prop_Type, "000", this.Thuoc_tinh_3.QigqongPropType, "0", this.Thuoc_tinh_3.Number_Prop }));
						}
						else
						{
							str2 = (this.Thuoc_tinh_3.Prop_Type != 8 || this.Thuoc_tinh_3.QigqongPropType == 0 ? string.Concat(this.Thuoc_tinh_3.Prop_Type, "00000", this.Thuoc_tinh_3.Number_Prop) : string.Concat(new object[] { this.Thuoc_tinh_3.Prop_Type, "000", this.Thuoc_tinh_3.QigqongPropType, this.Thuoc_tinh_3.Number_Prop }));
						}
					}
					if (this.Thuoc_tinh_4.Number_Prop != 0)
					{
						if (this.Thuoc_tinh_4.Number_Prop < 10)
						{
							str3 = (this.Thuoc_tinh_4.Prop_Type != 8 || this.Thuoc_tinh_4.QigqongPropType == 0 ? string.Concat(this.Thuoc_tinh_4.Prop_Type, "000000", this.Thuoc_tinh_4.Number_Prop) : string.Concat(new object[] { this.Thuoc_tinh_4.Prop_Type, "000", this.Thuoc_tinh_4.QigqongPropType, "0", this.Thuoc_tinh_4.Number_Prop }));
						}
						else
						{
							str3 = (this.Thuoc_tinh_4.Prop_Type != 8 || this.Thuoc_tinh_4.QigqongPropType == 0 ? string.Concat(this.Thuoc_tinh_4.Prop_Type, "00000", this.Thuoc_tinh_4.Number_Prop) : string.Concat(new object[] { this.Thuoc_tinh_4.Prop_Type, "000", this.Thuoc_tinh_4.QigqongPropType, this.Thuoc_tinh_4.Number_Prop }));
						}
					}
				}
				byte[] bytes = BitConverter.GetBytes(int.Parse(str));
				byte[] numArray = BitConverter.GetBytes(int.Parse(str1));
				byte[] bytes1 = BitConverter.GetBytes(int.Parse(str2));
				byte[] numArray1 = BitConverter.GetBytes(int.Parse(str3));
				Buffer.BlockCopy((Array)bytes, 0, this.VAT_PHAM, 20, 4);
				Buffer.BlockCopy(numArray, 0, this.VAT_PHAM, 24, 4);
				Buffer.BlockCopy(bytes1, 0, this.VAT_PHAM, 28, 4);
				Buffer.BlockCopy(numArray1, 0, this.VAT_PHAM, 32, 4);
			}
			catch (Exception exception)
			{
				Form1.WriteLine(1, string.Concat("合成 设置属性 出错：", exception));
			}
		}
	}
}