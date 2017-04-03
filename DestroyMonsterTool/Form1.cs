using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DestroyMonsterTool
{
      public partial class Form1 : Form
      {
            DestroyMonsterScript _DestroyMonsterScriptList = new DestroyMonsterScript();
            public Form1()
            {
                  InitializeComponent();
            }

            private void 추가ToolStripMenuItem_Click(object sender, EventArgs e)
            {
                  dataGridView1.Rows.Add();
            }

            private void Form1_Load(object sender, EventArgs e)
            {

            }

            #region Serialize
            private void SerializeGameRule(string _fileName, DestroyMonsterScript _DestroyMonsterScript)
            {
                  try
                  {
                        XmlSerializer serializer = new XmlSerializer(typeof(DestroyMonsterScript));
                        using (StreamWriter writer = new StreamWriter(_fileName))
                        {
                              serializer.Serialize(writer, _DestroyMonsterScript);
                        }
                  }
                  catch { }
            }
            #endregion

            #region DeSerialize
            private void DeSerializeGameRule(string _fileName)
            {
                  try
                  {
                        if (File.Exists(_fileName))
                        {

                              XmlSerializer Deserializer = new XmlSerializer(typeof(DestroyMonsterScript));
                              using (StreamReader reader = new StreamReader(_fileName))
                              {
                                    _DestroyMonsterScriptList = (DestroyMonsterScript)Deserializer.Deserialize(reader);
                              }

                        }

                  }
                  catch { }

            }
            #endregion

            private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
            {
                  saveFileDialog1.Filter = "DestroyMonster|*.xml";
                  saveFileDialog1.FileName = "*.xml";
                  saveFileDialog1.FilterIndex = 1;
                  saveFileDialog1.RestoreDirectory = true;

                  if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                  {
                        dataGridView1.EndEdit();
                        _DestroyMonsterScriptList.clearDestroyMonsterList();
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                              DestroyMonster _DestroyMonster = new DestroyMonster();
                              _DestroyMonster.MonsterID = dataGridView1.Rows[i].Cells[0].Value.ToString();
                              _DestroyMonster.QuestID = dataGridView1.Rows[i].Cells[1].Value.ToString();
                              _DestroyMonster.QuestLevel = dataGridView1.Rows[i].Cells[2].Value.ToString();
                              _DestroyMonster.DropItemID = dataGridView1.Rows[i].Cells[3].Value.ToString();
                              _DestroyMonster.DropItemCount = dataGridView1.Rows[i].Cells[4].Value.ToString();
                              _DestroyMonster.ItemProbability = dataGridView1.Rows[i].Cells[5].Value.ToString();                              
                              _DestroyMonsterScriptList.addDestroyMonsterList(_DestroyMonster);
                        }

                        SerializeGameRule(saveFileDialog1.FileName, _DestroyMonsterScriptList);
                  }

            }

            private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
            {
                  openFileDialog1.Filter = "DestroyMonster|*.xml";
                  openFileDialog1.FileName = "*.xml";
                  openFileDialog1.FilterIndex = 1;

                  if (openFileDialog1.ShowDialog() == DialogResult.OK)
                  {
                        dataGridView1.Rows.Clear();
                        _DestroyMonsterScriptList.clearDestroyMonsterList();
                        DeSerializeGameRule(openFileDialog1.FileName);

                        for (int i = 0; i < _DestroyMonsterScriptList.DestroyMonsterList.Count; i++)
                        {
                              dataGridView1.Rows.Add(
                                    _DestroyMonsterScriptList.DestroyMonsterList[i].MonsterID,
                                    _DestroyMonsterScriptList.DestroyMonsterList[i].QuestID,
                                    _DestroyMonsterScriptList.DestroyMonsterList[i].QuestLevel,
                                    _DestroyMonsterScriptList.DestroyMonsterList[i].DropItemID,
                                    _DestroyMonsterScriptList.DestroyMonsterList[i].DropItemCount,
                                    _DestroyMonsterScriptList.DestroyMonsterList[i].ItemProbability                                    
                                    );
                        }

                  }
            }

            private void 삭제ToolStripMenuItem_Click(object sender, EventArgs e)
            {
                  GridUtils.DeleteGridRow(dataGridView1);
            }

            private void SaveLuaScript()
            {
                  string startupPath = Application.StartupPath;
                  string DirPath = startupPath + "\\Script";
                  DirectoryInfo di = new DirectoryInfo(DirPath);
                  if (!di.Exists) Directory.CreateDirectory(DirPath);
                  using (StreamWriter key = new StreamWriter(new FileStream(string.Concat(DirPath, "\\DestroyMonster", ".lua"), FileMode.Create, FileAccess.Write, FileShare.Read), Encoding.GetEncoding("GB2312")))
                  {
                        key.Write("function DestroyMonster(UserWorldId, MonsterId) \r\n");
                        for (int i = 0; i < _DestroyMonsterScriptList.DestroyMonsterList.Count; i++)
                        {
                              key.Write("       if MonsterId==" + _DestroyMonsterScriptList.DestroyMonsterList[i].MonsterID + " then \r\n");
                              key.Write("             Monster" + _DestroyMonsterScriptList.DestroyMonsterList[i].MonsterID + "(UserWorldId) \r\n");
                              key.Write("       end \r\n");
                        }
                        key.Write("end \r\n");
                        key.Write("\r\n");
                        key.Write("\r\n");
                        key.Write("-----------------------------------------------------------------------------------------------------\r\n");
                        key.Write("-----------------------------------------------------------------------------------------------------\r\n");
                        key.Write("\r\n");
                        for (int i = 0; i < _DestroyMonsterScriptList.DestroyMonsterList.Count; i++)
                        {
                              key.Write("-----[" + _DestroyMonsterScriptList.DestroyMonsterList[i].MonsterID + "]---[" + _DestroyMonsterScriptList.DestroyMonsterList[i].QuestID + "]---------------------------------------------------------------\r\n");
                              key.Write("function Monster" + _DestroyMonsterScriptList.DestroyMonsterList[i].MonsterID + "(UserWorldId) \r\n");
                              key.Write("       local  bool" + _DestroyMonsterScriptList.DestroyMonsterList[i].DropItemID + " = GetQuestItme(UserWorldId, "+ _DestroyMonsterScriptList.DestroyMonsterList[i].DropItemID + ", "+ _DestroyMonsterScriptList.DestroyMonsterList[i].DropItemCount + ") \r\n");
                              key.Write("       if bool"+ _DestroyMonsterScriptList.DestroyMonsterList[i].DropItemID + " then \r\n");
                              key.Write("             return \r\n");
                              key.Write("       else \r\n");
                              key.Write("             local Player = GetPlayer(UserWorldId) \r\n");
                              key.Write("             local QuestLevel=GetQuestLevel(UserWorldId,"+ _DestroyMonsterScriptList.DestroyMonsterList[i].QuestID+ ") \r\n");
                              key.Write("             if QuestLevel == "+ _DestroyMonsterScriptList.DestroyMonsterList[i].QuestLevel+ " then \r\n");
                              key.Write("                   local ran=math.random(1,100) \r\n");
                              key.Write("                   if ran<="+ _DestroyMonsterScriptList.DestroyMonsterList[i].ItemProbability+ " then \r\n");
                              key.Write("                         AddQuestItme(UserWorldId,"+ _DestroyMonsterScriptList.DestroyMonsterList[i].DropItemID+ ",1) \r\n");
                              key.Write("                   end \r\n");
                              key.Write("             end \r\n");
                              key.Write("       end \r\n");
                              key.Write("end \r\n");
                              key.Write("\r\n");
                        }
                  }
            }

            private void lua저장ToolStripMenuItem_Click(object sender, EventArgs e)
            {
                  SaveLuaScript();
            }
      }
}
