using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestroyMonsterTool
{
      [Serializable]
      public class DestroyMonsterScript
      {
            public List<DestroyMonster> DestroyMonsterList = new List<DestroyMonster>();
            public DestroyMonsterScript() { }

            public void addDestroyMonsterList(DestroyMonster Rule)
            {
                  DestroyMonsterList.Add(Rule);
            }

            public void clearDestroyMonsterList()
            {
                  DestroyMonsterList.Clear();
            }
      }
}
