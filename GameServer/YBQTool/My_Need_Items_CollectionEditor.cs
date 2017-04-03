using ns4;
using System;
using System.ComponentModel.Design;

namespace ns10
{
	internal class My_Need_Items_CollectionEditor : CollectionEditor
	{
		public My_Need_Items_CollectionEditor(Type type) : base(type)
		{
		}

		protected override string GetDisplayText(object value)
		{
			if (!(value is QuestItems_Category))
			{
				return value.ToString();
			}
			QuestItems_Category questItemsCategory = (QuestItems_Category)value;
			return string.Concat(questItemsCategory.ItemID, " 数量 ", questItemsCategory.ItemQuantity);
		}
	}
}