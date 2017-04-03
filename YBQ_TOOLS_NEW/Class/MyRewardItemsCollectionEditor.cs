using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace YBQ_TOOLS_NEW
{
      public class MyRewardItemsCollectionEditor: CollectionEditor
      {
            public MyRewardItemsCollectionEditor(Type type) : base(type)
            {
            }
            protected override string GetDisplayText(object value)
            {
                  string result;
                  if (value is RewardItems)
                  {
                        RewardItems _RewardItems = (RewardItems)value;
                        result = string.Concat(new object[]
                        {
                              "ID:",
                              _RewardItems.ItemID,
                              " - 수량:",
                              _RewardItems.ItemAmmount
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
