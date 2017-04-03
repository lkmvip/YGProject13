using ns3;
using System;
using System.Collections.Generic;

namespace ns1
{
	public class TBL_XWWL_MAP : IDisposable
	{
		private float float_0;

		private float float_1;

		private float float_2;

		private int int_0;

		private int int_1;

		private string string_0;

		public int Rxjh_LEVEL
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

		public int Rxjh_Map
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

		public string Rxjh_name
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

		public float Rxjh_X
		{
			get
			{
				return this.float_0;
			}
			set
			{
				this.float_0 = value;
			}
		}

		public float Rxjh_Y
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

		public float Rxjh_Z
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

		public TBL_XWWL_MAP()
		{
		}

		public TBL_XWWL_MAP(float Rxjh__X, float Rxjh__Y, float Rxjh__Z, int Rxjh__Map)
		{
			this.Rxjh_X = Rxjh__X;
			this.Rxjh_Y = Rxjh__Y;
			this.Rxjh_Z = Rxjh__Z;
			this.Rxjh_Map = Rxjh__Map;
		}

		public static string smethod_0(int int_2)
		{
			string rxjhName;
			List<TBL_XWWL_MAP>.Enumerator enumerator = World.list_15.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					TBL_XWWL_MAP current = enumerator.Current;
					if (current.Rxjh_Map != int_2)
					{
						continue;
					}
					rxjhName = current.Rxjh_name;
					return rxjhName;
				}
				return "";
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			return rxjhName;
		}

		void System.IDisposable.Dispose()
		{
		}
	}
}