using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YBQ_TOOLS_NEW
{
      class MAP_CLASS
      {
            private int int_0;

            private int int_1;

            private int int_2;

            public int CoordX
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

            public int CoordY
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

            public int MapID
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

            public MAP_CLASS()
            {
            }
      }
}
