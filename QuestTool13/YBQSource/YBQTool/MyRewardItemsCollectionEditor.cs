using System;
using System.ComponentModel.Design;
namespace RxjhTool
{
	public class MyRewardItemsCollectionEditor : CollectionEditor
	{
		public MyRewardItemsCollectionEditor(Type type) : base(type)
		{
		}
		protected override string GetDisplayText(object value)
		{
			string result;
			if (value is 任务RewardItems类)
			{
				任务RewardItems类 任务RewardItems类 = (任务RewardItems类)value;
				result = string.Concat(new object[]
				{
					"ID:",
					任务RewardItems类.ItemID,
					" - 수량:",
					任务RewardItems类.ItemAmmount
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
