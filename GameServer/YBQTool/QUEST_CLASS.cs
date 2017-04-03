using ns1;
using ns2;
using ns4;
using System;
using System.Collections.Generic;

namespace ns12
{
	internal class QUEST_CLASS : ICloneable
	{
		private MAP_CLASS class139_0 = new MAP_CLASS();

		private int int_0;

		private int int_1;

		public int int_10;

		public int int_11;

		private int int_2;

		private int int_3;

		public int int_4;

		public int int_5;

		public int int_6;

		public int int_7;

		public int int_8;

		public int int_9;

		private List<QuestItems_Category> list_0 = new List<QuestItems_Category>();

		private List<TaskRequiresItem_Category> list_1 = new List<TaskRequiresItem_Category>();

		private List<NPC_CLASS> list_2 = new List<NPC_CLASS>();

		private string string_0 = "";

		private string string_1 = "";

		public string string_10 = "";

		public string string_11 = "";

		public string string_12 = "";

		public string string_13 = "";

		public string string_14 = "";

		private string string_2 = "";

		private string string_3 = "";

		private string string_4 = "";

		private string string_5 = "";

		private string string_6 = "";

		public string string_7 = "";

		public string string_8 = "";

		public string string_9 = "";

		public List<QuestItems_Category> KHEN_THUONG_ITEM
		{
			get
			{
				return this.list_0;
			}
			set
			{
				this.list_0 = value;
			}
		}

		public List<TaskRequiresItem_Category> NeededItem
		{
			get
			{
				return this.list_1;
			}
			set
			{
				this.list_1 = value;
			}
		}

		public List<NPC_CLASS> NHIEM_VU_GIAI_DOAN
		{
			get
			{
				return this.list_2;
			}
			set
			{
				this.list_2 = value;
			}
		}

		public int NHIEM_VU_GIAI_DOAN_SO_LUONG
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

		public string NHIEM_VU_HOAN_NGHENH_TIEP_THU_NHAC_NHO_1
		{
			get
			{
				return this.string_6;
			}
			set
			{
				this.string_6 = value;
			}
		}

		public string NHIEM_VU_HOAN_NGHENH_TU_CHOI_NHAC_NHO_1
		{
			get
			{
				return this.string_5;
			}
			set
			{
				this.string_5 = value;
			}
		}

		public int NHIEM_VU_ID
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

		public string NHIEM_VU_TEN
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

		public int NHIEM_VU_THU_BAC
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

		public string NHIEM_VU_TIEP_THU_NHAC_NHO_1
		{
			get
			{
				return this.string_3;
			}
			set
			{
				this.string_3 = value;
			}
		}

		public string NHIEM_VU_TIEP_THU_NHAC_NHO_2
		{
			get
			{
				return this.string_4;
			}
			set
			{
				this.string_4 = value;
			}
		}

		public string NHIEM_VU_TU_CHOI_NHAC_NHO_1
		{
			get
			{
				return this.string_1;
			}
			set
			{
				this.string_1 = value;
			}
		}

		public string NHIEM_VU_TU_CHOI_NHAC_NHO_2
		{
			get
			{
				return this.string_2;
			}
			set
			{
				this.string_2 = value;
			}
		}

		public MAP_CLASS NPC_TOA_DO
		{
			get
			{
				return this.class139_0;
			}
			set
			{
				this.class139_0 = value;
			}
		}

		public int NpcID
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

		public QUEST_CLASS()
		{
		}

		public QUEST_CLASS method_0()
		{
			return (QUEST_CLASS)this.MemberwiseClone();
		}

		object System.ICloneable.Clone()
		{
			return this.method_0();
		}
	}
}