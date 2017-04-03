using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace YBQ_TOOLS_NEW
{

      [DefaultProperty("QUEST ITEM ID")]
      internal class QuestItems_Category
      {
            private int int_0;

            private int int_1;

            [Category("기본")]
            [Description("ITEM ID")]
            public int ItemID
            {
                  get
                  {
                        return this.int_0;
                  }
                  set
                  {
                        this.int_0 = value;
                  }
            }

            [Category("기본")]
            [Description("번호")]
            public int ItemQuantity
            {
                  get
                  {
                        return this.int_1;
                  }
                  set
                  {
                        this.int_1 = value;
                  }
            }

            public QuestItems_Category()
            {
            }
      }
}
