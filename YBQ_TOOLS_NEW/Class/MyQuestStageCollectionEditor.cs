using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace YBQ_TOOLS_NEW
{
      public class MyQuestStageCollectionEditor: CollectionEditor
      {
            public MyQuestStageCollectionEditor(Type type) : base(type)
            {
            }
            protected override string GetDisplayText(object value)
            {
                  string result;
                  if (value is QuestStage)
                  {
                        QuestStage _questStage = (QuestStage)value;
                        result = _questStage.QuestStageCount;
                  }
                  else
                  {
                        result = value.ToString();
                  }
                  return result;
            }
      }
}
