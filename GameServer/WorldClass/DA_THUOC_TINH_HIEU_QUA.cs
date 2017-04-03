using ns3;
using System;
using System.Collections.Generic;

namespace ns11
{
	internal class DA_THUOC_TINH_HIEU_QUA
	{
		private int int_0;

		private int int_1;

		public int FLD_ID
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

		public int FLD_TI_LE_PHAN_TRAM
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

		public DA_THUOC_TINH_HIEU_QUA()
		{
		}

		public int method_0(int int_2)
		{
			int fLDTILEPHANTRAM;
			Dictionary<int, DA_THUOC_TINH_HIEU_QUA>.ValueCollection.Enumerator enumerator = World.dictionary_4.Values.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					DA_THUOC_TINH_HIEU_QUA current = enumerator.Current;
					if (current.FLD_ID != int_2)
					{
						continue;
					}
					fLDTILEPHANTRAM = current.FLD_TI_LE_PHAN_TRAM;
					return fLDTILEPHANTRAM;
				}
				return 0;
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			return fLDTILEPHANTRAM;
		}
	}
}