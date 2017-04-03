using ns2;
using System;
using System.ComponentModel.Design;

namespace ns4
{
	internal class MyRewardItemsCollectionEditor : CollectionEditor
	{
		public MyRewardItemsCollectionEditor(Type type) : base(type)
		{
		}

		protected override string GetDisplayText(object value)
		{
			if (!(value is TaskRequiresItem_Category))
			{
				return value.ToString();
			}
			TaskRequiresItem_Category taskRequiresItemCategory = (TaskRequiresItem_Category)value;
			return string.Concat(taskRequiresItemCategory.ItemID, " 数量 ", taskRequiresItemCategory.ItemQuantity);
		}
	}
}