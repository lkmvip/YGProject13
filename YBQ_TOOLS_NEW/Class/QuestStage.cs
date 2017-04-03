using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;



namespace YBQ_TOOLS_NEW
{
      public class QuestStage
      {
            private int _NpcCoordsX;
            private int _NpcCoordsY;
            private int _NpcID;
            private int _NpcMapID;
            private string _QuestStageCount = "";
            private List<RequiredItems> _RequiredItems = new List<RequiredItems>();
            private string _TaskTip1 = "";
            private string _TaskTip_compl1 = "";
            public int Npc1;
            public string TaskTip_None_2 = "";
            public string TaskTip_None_3 = "";
            public string TaskTip_None_4 = "";
            public string TaskTip_None_5 = "";
            public string TaskTip_Compl_2 = "";
            public string TaskTip_Compl_3 = "";
            public string TaskTip_Compl_4 = "";
            public string TaskTip_Compl_5 = "";
            [Category("Basic"), Description("CoordsX")]
            public int NpcCoordsX
            {
                  get
                  {
                        return this._NpcCoordsX;
                  }
                  set
                  {
                        this._NpcCoordsX = value;
                  }
            }
            [Category("Basic"), Description("CoordsY")]
            public int NpcCoordsY
            {
                  get
                  {
                        return this._NpcCoordsY;
                  }
                  set
                  {
                        this._NpcCoordsY = value;
                  }
            }
            [Category("Basic"), Description("NpcID")]
            public int NpcID
            {
                  get
                  {
                        return this._NpcID;
                  }
                  set
                  {
                        this._NpcID = value;
                  }
            }
            [Category("Basic"), Description("MapID")]
            public int NpcMapID
            {
                  get
                  {
                        return this._NpcMapID;
                  }
                  set
                  {
                        this._NpcMapID = value;
                  }
            }
            
            [Category("퀘스트 설명"), Description("설명")]
            public string QuestStageCount
            {
                  get
                  {
                        return this._QuestStageCount;
                  }
                  set
                  {
                        this._QuestStageCount = value;
                  }
            }
            
            [Category("RequiredItems"), Description("RequiredItemsToFinishQuest")]
            public List<RequiredItems> RequiredItems
            {
                  get
                  {
                        return this._RequiredItems;
                  }
                  set
                  {
                        this._RequiredItems = value;
                  }
            }
            
            [Category("퀘스트 팁"), Description("CoordsY")]
            public string TaskTip1
            {
                  get
                  {
                        return this._TaskTip1;
                  }
                  set
                  {
                        this.TaskTip1 = value;
                  }
            }
            
            [Category("퀘스트 팁"), Description("CoordsY")]
            public string TaskTip_compl1
            {
                  get
                  {
                        return this._TaskTip_compl1;
                  }
                  set
                  {
                        this._TaskTip_compl1 = value;
                  }
            }
      }
}
