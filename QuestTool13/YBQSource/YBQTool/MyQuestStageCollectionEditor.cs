using System;
using System.ComponentModel.Design;
namespace RxjhTool
{
	public class MyQuestStageCollectionEditor : CollectionEditor
	{
		public MyQuestStageCollectionEditor(Type type) : base(type)
		{
		}
		protected override string GetDisplayText(object value)
		{
			string result;
			if (value is QuestStage)
			{
				QuestStage questStage类 = (QuestStage)value;
				result = questStage类.QuestStage内容;
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}
	}
}
