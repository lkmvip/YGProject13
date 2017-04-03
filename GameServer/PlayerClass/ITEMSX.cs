using ns3;
using System;

namespace ns2
{
	public class ITEMSX
	{
		private int int_0;

		private int int_1;

		private int int_2;

		private int int_3;

		public int Number_Prop
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

		public int Prop_Type
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

		public int QigqongPropType
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

		public int So_luong
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

		public ITEMSX(byte[] Thuoc_Tinh)
		{
			this.method_0(Thuoc_Tinh);
		}

		public void method_0(byte[] byte_0)
		{
			string str = BitConverter.ToInt32(byte_0, 0).ToString();
			switch (str.Length)
			{
				case 8:
				{
					this.So_luong = 1;
					this.Prop_Type = int.Parse(str.Substring(0, 1));
					if (this.Prop_Type == 8)
					{
						this.QigqongPropType = int.Parse(str.Substring(4, 2));
					}
					if (World.Thuoc_tinh_mo_rong_co_hay_khong_mo_ra == 0)
					{
						this.Number_Prop = int.Parse(str.Substring(6, 2));
						return;
					}
					this.Number_Prop = int.Parse(str) - int.Parse(str.Substring(0, 1)) * 10000000;
					return;
				}
				case 9:
				{
					this.So_luong = 1;
					this.Prop_Type = int.Parse(str.Substring(0, 2));
					if (World.Thuoc_tinh_mo_rong_co_hay_khong_mo_ra == 0)
					{
						this.Number_Prop = int.Parse(str.Substring(7, 2));
						return;
					}
					this.Number_Prop = int.Parse(str) - int.Parse(str.Substring(0, 2)) * 10000000;
					return;
				}
				case 10:
				{
					this.So_luong = 1;
					this.Prop_Type = int.Parse(str.Substring(0, 2));
					if (World.Thuoc_tinh_mo_rong_co_hay_khong_mo_ra == 0)
					{
						this.Number_Prop = int.Parse(str.Substring(7, 2));
						return;
					}
					this.Number_Prop = int.Parse(str) - int.Parse(str.Substring(0, 3)) * 10000000;
					return;
				}
				default:
				{
					return;
				}
			}
		}
	}
}