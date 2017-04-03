using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace YBQ_TOOLS_NEW
{
      internal class QUEST_CLASS : ICloneable
      {
            private MAP_CLASS class139_0 = new MAP_CLASS();

            private int int_0;

            private int int_1;
            
            public int NPCCord;

            private int int_2;

            private int int_3;

            public int Missionunknown1;

            public int Missionunknown2;

            public int Missionunknown3;

            public int Missionunknown4;

            public int Missionunknown5;

            public int Missionunknown6;

            public int Missionunknown7;

            private List<QuestItems_Category> list_0 = new List<QuestItems_Category>();

            private List<TaskRequiresItem_Category> list_1 = new List<TaskRequiresItem_Category>();

            private List<NPC_CLASS> list_2 = new List<NPC_CLASS>();

            private string string_0 = "";

            private string string_1 = "";

            public string Missionpresent5 = "";

            public string AssignmentReception2 = "";

            public string AssignmentReception3 = "";

            public string AssignmentReception4 = "";

            public string AssignmentReception5 = "";

            private string string_2 = "";

            private string string_3 = "";

            private string string_4 = "";

            private string string_5 = "";

            private string string_6 = "";

            public string Missionpresent2 = "";

            public string Missionpresent3 = "";

            public string Missionpresent4 = "";

            public List<QuestItems_Category> RewardItems
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

            public List<TaskRequiresItem_Category> NeededItem
            {
                  get
                  {
                        return this.list_1;
                  }
                  set
                  {
                        this.list_1 = value;
                  }
            }

            public List<NPC_CLASS> QuestStage
            {
                  get
                  {
                        return this.list_2;
                  }
                  set
                  {
                        this.list_2 = value;
                  }
            }

            public int QuestStageNumber
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

            public string AssignmentReception1
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

            public string Missionpresent1
            {
                  get
                  {
                        return this.string_5;
                  }
                  set
                  {
                        this.string_5 = value;
                  }
            }

            public int QuestID
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

            public string QuestName
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

            public int QuestLevel
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

            public string QuestAccept1
            {
                  get
                  {
                        return this.string_3;
                  }
                  set
                  {
                        this.string_3 = value;
                  }
            }

            public string QuestAccept2
            {
                  get
                  {
                        return this.string_4;
                  }
                  set
                  {
                        this.string_4 = value;
                  }
            }

            public string QuestRefuse1
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

            public string QuestRefuse2
            {
                  get
                  {
                        return this.string_2;
                  }
                  set
                  {
                        this.string_2 = value;
                  }
            }

            public MAP_CLASS NpcCords
            {
                  get
                  {
                        return this.class139_0;
                  }
                  set
                  {
                        this.class139_0 = value;
                  }
            }

            public int NpcID
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

            public QUEST_CLASS()
            {
            }

            public QUEST_CLASS method_0()
            {
                  return (QUEST_CLASS)this.MemberwiseClone();
            }

            object System.ICloneable.Clone()
            {
                  return this.method_0();
            }
      }
}
