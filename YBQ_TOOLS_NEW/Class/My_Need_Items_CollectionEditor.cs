using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace YBQ_TOOLS_NEW
{
      internal class My_Need_Items_CollectionEditor: CollectionEditor
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
                  return string.Concat(questItemsCategory.ItemID, " 수량 ", questItemsCategory.ItemQuantity);
            }
      }
}
