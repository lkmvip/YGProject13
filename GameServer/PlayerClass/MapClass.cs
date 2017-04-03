using ns12;
using ns13;
using ns3;
using System;
using System.Collections.Generic;

namespace ns6
{
	internal class MapClass
	{
		public Dictionary<int, TBL_XWWL_NPC> dictionary_0 = new Dictionary<int, TBL_XWWL_NPC>();

		private int int_0;

		public int MapID
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

		public MapClass()
		{
		}

		public static Dictionary<int, TBL_XWWL_NPC> GetnpcTemplate(int int_1)
		{
			MapClass mapClass;
			if (!World.dictionary_12.TryGetValue(int_1, out mapClass))
			{
				return new Dictionary<int, TBL_XWWL_NPC>();
			}
			return mapClass.dictionary_0;
		}

		public void method_0(int int_1)
		{
			using (Lock @lock = new Lock(this.dictionary_0, "MapClass-del"))
			{
				this.dictionary_0.Remove(int_1);
			}
		}

		public void method_1(TBL_XWWL_NPC class153_0)
		{
			int num = 10000;
			while (num < 30000)
			{
				if (this.dictionary_0.ContainsKey(num))
				{
					num++;
				}
				else
				{
					class153_0.FLD_INDEX = num;
					if (this.dictionary_0.ContainsKey(class153_0.FLD_INDEX))
					{
						break;
					}
					this.dictionary_0.Add(class153_0.FLD_INDEX, class153_0);
					return;
				}
			}
		}

		public static int smethod_0()
		{
			int count = 0;
			foreach (MapClass value in World.dictionary_12.Values)
			{
				count = count + value.dictionary_0.Count;
			}
			return count;
		}

		public static TBL_XWWL_NPC smethod_2(int int_1, int int_2)
		{
			MapClass mapClass;
			TBL_XWWL_NPC tBLXWWLNPC;
			if (World.dictionary_12.TryGetValue(int_1, out mapClass) && mapClass.dictionary_0.TryGetValue(int_2, out tBLXWWLNPC))
			{
				return tBLXWWLNPC;
			}
			return null;
		}

		public static void smethod_3(int int_1, int int_2)
		{
			MapClass mapClass;
			if (World.dictionary_12.TryGetValue(int_1, out mapClass))
			{
				mapClass.method_0(int_2);
			}
		}
	}
}