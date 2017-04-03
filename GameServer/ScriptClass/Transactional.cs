using ns3;
using ns9;
using System;
using System.Collections.Generic;

namespace ns2
{
	public class Transactional : IDisposable
	{
		public bool bool_0;

		private bool bool_1;

		private Players class15_0;

		public Dictionary<long, IndividualStoreItems_Category> dictionary_0;

		public long long_0;

		public Players GIAO_DICH_CON_NGUOI
		{
			get
			{
				return this.class15_0;
			}
			set
			{
				this.class15_0 = value;
			}
		}

		public bool GIAO_DICH_TIEP_THU
		{
			get
			{
				return this.bool_1;
			}
			set
			{
				this.bool_1 = value;
			}
		}

		public Transactional()
		{
		}

		public Transactional(Players GIAO_DICH_CON_NGUOI_)
		{
			this.GIAO_DICH_CON_NGUOI = GIAO_DICH_CON_NGUOI_;
			this.GIAO_DICH_TIEP_THU = false;
			this.long_0 = (long)0;
			this.dictionary_0 = new Dictionary<long, IndividualStoreItems_Category>();
		}

		public void Dispose()
		{
			try
			{
				this.bool_0 = false;
				if (this.GIAO_DICH_CON_NGUOI != null)
				{
					this.GIAO_DICH_CON_NGUOI.OpenWarehouse = false;
					this.GIAO_DICH_CON_NGUOI.class66_0.GIAO_DICH_CON_NGUOI.OpenWarehouse = false;
					this.GIAO_DICH_CON_NGUOI.class66_0.bool_0 = false;
					this.GIAO_DICH_CON_NGUOI.class66_0.GIAO_DICH_CON_NGUOI = null;
					this.GIAO_DICH_CON_NGUOI = null;
				}
			}
			catch (Exception exception)
			{
			}
		}

		~Transactional()
		{
		}

		public void method_0()
		{
			this.Dispose();
		}
	}
}