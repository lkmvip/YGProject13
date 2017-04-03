using ns3;
using System;
using System.Collections.Generic;

namespace ns7
{
	internal class DINH_NGHIA_CHUYEN_CHUC_THUOC_TINH
	{
		private int int_0;

		private int int_1;

		private int int_2;

		private int int_3;

		private int int_4;

		public int FLD_AT
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

		public int FLD_DF
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

		public int FLD_HP
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

		public int FLD_JOB_LEVEL
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

		public int FLD_MP
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

		public DINH_NGHIA_CHUYEN_CHUC_THUOC_TINH()
		{
		}

		public DINH_NGHIA_CHUYEN_CHUC_THUOC_TINH method_0(int int_5)
		{
			DINH_NGHIA_CHUYEN_CHUC_THUOC_TINH dINHNGHIACHUYENCHUCTHUOCTINH;
			Dictionary<int, DINH_NGHIA_CHUYEN_CHUC_THUOC_TINH>.ValueCollection.Enumerator enumerator = World.dictionary_15.Values.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					DINH_NGHIA_CHUYEN_CHUC_THUOC_TINH current = enumerator.Current;
					if (current.FLD_JOB_LEVEL != int_5)
					{
						continue;
					}
					dINHNGHIACHUYENCHUCTHUOCTINH = current;
					return dINHNGHIACHUYENCHUCTHUOCTINH;
				}
				return null;
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			return dINHNGHIACHUYENCHUCTHUOCTINH;
		}
	}
}