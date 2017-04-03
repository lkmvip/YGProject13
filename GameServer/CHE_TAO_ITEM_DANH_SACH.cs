using ns3;
using System;
using System.Collections.Generic;

namespace RxjhServer
{
	public class CHE_TAO_ITEM_DANH_SACH
	{
		public int ITEM_ID;

		public string ITEM_TEN;

		public int ITEM_SO_LUONG;

		public List<CHE_TAC_CAN_ITEM_LOAI> CAN_ITEM = new List<CHE_TAC_CAN_ITEM_LOAI>();

		public int CHE_TAO_DANG_CAP;

		public int CHE_TAO_LOAI_HINH;

		public CHE_TAO_ITEM_DANH_SACH()
		{
		}

		public static List<int> Get_CHE_TAO_ITEM_LOAI_DANH_SACH(int CHE_TAO_LOAI_HINH, int CHE_TAO_DANG_CAP)
		{
			List<int> nums = new List<int>();
			foreach (CHE_TAO_ITEM_DANH_SACH value in World.dictionary_29.Values)
			{
				if (value.CHE_TAO_LOAI_HINH != CHE_TAO_LOAI_HINH || CHE_TAO_DANG_CAP < value.CHE_TAO_DANG_CAP)
				{
					continue;
				}
				nums.Add(value.ITEM_ID);
			}
			return nums;
		}
	}
}