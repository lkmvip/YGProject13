using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;


namespace YBQ_TOOLS_NEW
{
      [DefaultProperty("ID")]
      [Category("요구 아이템 목록")]
      internal class TaskRequiresItem_Category
      {
            private int int_0;

            private int int_1;

            private int int_2;

            private int int_3;

            private int int_4;

            [Category("좌표")]
            [Description("X")]
            public int CoordX
            {
                  get
                  {
                        return this.int_3;
                  }
                  set
                  {
                        this.int_3 = value;
                  }
            }

            [Category("좌표")]
            [Description("Y")]
            public int CoordY
            {
                  get
                  {
                        return this.int_4;
                  }
                  set
                  {
                        this.int_4 = value;
                  }
            }

            [Category("좌표")]
            [Description("MAP ID")]
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

            [Category("좌표")]
            [Description("ITEM ID")]
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

            [Category("좌표")]
            [Description("MAP ID")]
            public int MapID
            {
                  get
                  {
                        return this.int_2;
                  }
                  set
                  {
                        this.int_2 = value;
                  }
            }

            public TaskRequiresItem_Category()
            {
            }
      }
}
