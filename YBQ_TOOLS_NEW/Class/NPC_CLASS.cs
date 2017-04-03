using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;

namespace YBQ_TOOLS_NEW
{
      internal class NPC_CLASS
      {
            private int int_0;

            private int int_1;

            private int int_2;

            private int int_3;

            public int NpcCoords;

            private List<TaskRequiresItem_Category> list_0 = new List<TaskRequiresItem_Category>();

            private string string_0 = "";

            private string string_1 = "";

            public string string_10 = "";

            public string string_2 = "";

            public string string_3 = "";

            public string string_4 = "";

            public string string_5 = "";

            private string string_6 = "";

            public string string_7 = "";

            public string string_8 = "";

            public string string_9 = "";

            [Category("요구항목")]
            [Description("완료 필요항목")]            
            public List<TaskRequiresItem_Category> NeededItem
            {
                  get
                  {
                        return this.list_0;
                  }
                  set
                  {
                        this.list_0 = value;
                  }
            }

            [Category("좌표")]
            [Description("X")]
            public int NpcCoordX
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

            [Category("좌표")]
            [Description("Y")]
            public int NpcCoordY
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
            [Description("NpcID")]
            public int NpcID
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
            [Description("MAP ID")]
            public int NpcMapID
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
            [Description("Y")]            
            public string RequirementsMet
            {
                  get
                  {
                        return this.string_1;
                  }
                  set
                  {
                        this.string_1 = value;
                  }
            }

            [Category("좌표")]
            [Description("Y")]            
            public string RequirementsNotMet
            {
                  get
                  {
                        return this.string_6;
                  }
                  set
                  {
                        this.string_6 = value;
                  }
            }

            [Category("설명")]
            [Description("설명내용")]           
            public string StageText
            {
                  get
                  {
                        return this.string_0;
                  }
                  set
                  {
                        this.string_0 = value;
                  }
            }

            public NPC_CLASS()
            {
            }
      }
}
