using System;
using System.ComponentModel.Design;
namespace RxjhTool
{
	public class MyRequiredItemsCollectionEditor : CollectionEditor
	{
		public MyRequiredItemsCollectionEditor(Type type) : base(type)
		{
		}
		protected override string GetDisplayText(object value)
		{
			string result;
			if (value is RequiredItems)
			{
				RequiredItems 任务RequiredItems类 = (RequiredItems)value;
				result = string.Concat(new object[]
				{
					"ID:",
					任务RequiredItems类.ItemID,
					" - 수량:",
					任务RequiredItems类.ItemAmmount
				});
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}
	}
}
