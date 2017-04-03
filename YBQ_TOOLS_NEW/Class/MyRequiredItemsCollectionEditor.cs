using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace YBQ_TOOLS_NEW
{
      public class MyRequiredItemsCollectionEditor: CollectionEditor
      {
            public MyRequiredItemsCollectionEditor(Type type) : base(type)
            {
            }
            protected override string GetDisplayText(object value)
            {
                  string result;
                  if (value is RequiredItems)
                  {
                        RequiredItems _RequiredItems = (RequiredItems)value;
                        result = string.Concat(new object[]
                        {
                              "ID:",
                              _RequiredItems.ItemID,
                              " - 수량:",
                              _RequiredItems.ItemAmmount
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
