using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace YBQ_TOOLS_NEW
{
      public class TaskClass
      {
            private PositionClass _NpcCoords = new PositionClass();
            private int _NpcID;
            private string _QuestAccept1 = "";
            private string _QuestAccept2 = "";
            private int _QuestID;
            private int _QuestLevel;
            private string _QuestName = "";
            private string _QuestRefuse1 = "";
            private string _QuestRefuse2 = "";
            private List<QuestStage> _QuestStage = new List<QuestStage>();
            private int _QuestStageNumber;
            private List<RequiredItems> _RequiredItems = new List<RequiredItems>();
            private List<任务RewardItems类> _RewardItems = new List<任务RewardItems类>();
            private string _任务欢迎接受提示1 = "";
            private string _任务欢迎拒绝提示1 = "";
            public int Npc未知1;
            public string 任务欢迎接受提示2 = "";
            public string 任务欢迎接受提示3 = "";
            public string 任务欢迎接受提示4 = "";
            public string 任务欢迎接受提示5 = "";
            public string 任务欢迎拒绝提示2 = "";
            public string 任务欢迎拒绝提示3 = "";
            public string 任务欢迎拒绝提示4 = "";
            public string 任务欢迎拒绝提示5 = "";
            public int 任务未知1;
            public int 任务未知2;
            public int 任务未知3;
            public int 任务未知4;
            public int 任务未知5;
            public int 任务未知6;
            public int 任务未知7;
            public PositionClass NpcCoords
            {
                  get
                  {
                        return this._NpcCoords;
                  }
                  set
                  {
                        this._NpcCoords = value;
                  }
            }
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
            public string QuestAccept1
            {
                  get
                  {
                        return this._QuestAccept1;
                  }
                  set
                  {
                        this._QuestAccept1 = value;
                  }
            }
            public string QuestAccept2
            {
                  get
                  {
                        return this._QuestAccept2;
                  }
                  set
                  {
                        this._QuestAccept2 = value;
                  }
            }
            public int QuestID
            {
                  get
                  {
                        return this._QuestID;
                  }
                  set
                  {
                        this._QuestID = value;
                  }
            }
            public int QuestLevel
            {
                  get
                  {
                        return this._QuestLevel;
                  }
                  set
                  {
                        this._QuestLevel = value;
                  }
            }
            public string QuestName
            {
                  get
                  {
                        return this._QuestName;
                  }
                  set
                  {
                        this._QuestName = value;
                  }
            }
            public string QuestRefuse1
            {
                  get
                  {
                        return this._QuestRefuse1;
                  }
                  set
                  {
                        this._QuestRefuse1 = value;
                  }
            }
            public string QuestRefuse2
            {
                  get
                  {
                        return this._QuestRefuse2;
                  }
                  set
                  {
                        this._QuestRefuse2 = value;
                  }
            }
            public List<QuestStage> QuestStage
            {
                  get
                  {
                        return this._QuestStage;
                  }
                  set
                  {
                        this._QuestStage = value;
                  }
            }
            public int QuestStageNumber
            {
                  get
                  {
                        return this._QuestStageNumber;
                  }
                  set
                  {
                        this._QuestStageNumber = value;
                  }
            }
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
            public List<任务RewardItems类> RewardItems
            {
                  get
                  {
                        return this._RewardItems;
                  }
                  set
                  {
                        this._RewardItems = value;
                  }
            }
            public string 任务欢迎接受提示1
            {
                  get
                  {
                        return this._任务欢迎接受提示1;
                  }
                  set
                  {
                        this._任务欢迎接受提示1 = value;
                  }
            }
            public string 任务欢迎拒绝提示1
            {
                  get
                  {
                        return this._任务欢迎拒绝提示1;
                  }
                  set
                  {
                        this._任务欢迎拒绝提示1 = value;
                  }
            }
      }
}
