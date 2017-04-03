using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.Design;
using System.Threading.Tasks;
using RxjhTool;

namespace YBQ_TOOLS_NEW
{


      public partial class frmMain: Form
      {

            private static int euckrCodepage = 51949;
            private Encoding euckr = System.Text.Encoding.GetEncoding(euckrCodepage);

            private byte[] byte_0 = new byte[256];

            private Dictionary<int, QUEST_CLASS> dictionary_0 = new Dictionary<int, QUEST_CLASS>();

            private string string_0 = "";

            private string string_1 = "";

            private string string_2 = "";

            private bool OneSave = false;

            public frmMain()
            {
                  InitializeComponent();
                  int bytes = 0;
                  do
                  {
                        this.byte_0[bytes] = (byte)(bytes >> 4 & 1 | bytes >> 2 & 24 | bytes >> 1 & 64 | 2 * (bytes & 3 | 4 * (bytes & 4 | 2 * (bytes & 248))));
                        bytes++;
                  }
                  while (bytes < 256);
            }

            private void frmMain_Load(object sender, EventArgs e)
            {

            }

            private void a(FileStream fileStream_0, string string_3)
            {
                  byte[] dst = this.method_3(Encoding.Default.GetBytes(string_3));
                  this.method_5(fileStream_0, (int)dst.Length);
                  fileStream_0.Write(dst, 0, (int)dst.Length);
                  fileStream_0.WriteByte(this.method_4(32));
            }

            

            private void settoolStripStatusLabel1(string _text)
            {
                  
            }

            private void c()
            {
                  int count = 0;
                  this.dictionary_0 = (
                        from keyValuePair_0 in this.dictionary_0
                        orderby keyValuePair_0.Key
                        select keyValuePair_0).ToDictionary((KeyValuePair<int, QUEST_CLASS> keyValuePair_0) => keyValuePair_0.Key, (KeyValuePair<int, QUEST_CLASS> keyValuePair_0) => keyValuePair_0.Value);
                  this.listView.Items.Clear();
                  foreach (QUEST_CLASS dst in this.dictionary_0.Values)
                  {
                        count++;
                        string[] str = new string[3];
                        int nHIEMVUID = dst.QuestID;
                        str[0] = nHIEMVUID.ToString();
                        str[1] = dst.QuestName;
                        nHIEMVUID = dst.QuestLevel;
                        str[2] = nHIEMVUID.ToString();
                        string[] strArrays = str;
                        this.listView.Items.Insert(this.listView.Items.Count, new ListViewItem(strArrays));
                        UpdateStatusBar(string.Concat("데이터 적용중:", count));
                        //this.toolStripStatusLabel1.Text = string.Concat("데이터 적용중:", count);
                  }
                  toolStripProgressBar1.Visible = false;
                  this.toolStripStatusLabel1.Text = string.Concat("Loaded Quests:", this.dictionary_0.Count);
            }

            private int method_0(byte[] byte_1, ref int int_0)
            {
                  int int0;
                  try
                  {
                        int0 = int_0;
                        int_0 = int0 + 1;
                        int num = int0;
                        int num1 = num;
                        
                        while (num1 < (int)byte_1.Length)
                        {
                              if (byte_1[num1] == 32 || byte_1[num1] == 10)
                              {
                                    byte[] dst = new byte[num1 - num];
                                    Buffer.BlockCopy(byte_1, num, dst, 0, (int)dst.Length);
                                    string str = Encoding.Default.GetString(dst);
                                    int_0 = int_0 + (int)dst.Length;
                                    int.TryParse(str, out int0);
                                    return int0;
                              }
                              else
                              {
                                    num1++;
                              }
                        }
                        int0 = 0;
                  }
                  catch
                  {
                        int0 = 0;
                  }
                  return int0;
            }

            private string method_1(byte[] byte_1, ref int int_0)
            {
                  string str;
                  try
                  {
                        int int0 = int_0;
                        int_0 = int0 + 1;
                        int num = int0;
                        int num1 = num;
                        int intParse = 0;
                        while (num1 < (int)byte_1.Length)
                        {
                              if (byte_1[num1] == 32 || byte_1[num1] == 10)
                              {
                                    byte[] class2 = new byte[num1 - num];
                                    Buffer.BlockCopy(byte_1, num, class2, 0, (int)class2.Length);
                                    string str1 = Encoding.Default.GetString(class2);
                                    int_0 = int_0 + (int)class2.Length;
                                    int.TryParse(str1, out intParse);
                                    byte[] numArray = new byte[intParse];
                                    Buffer.BlockCopy(byte_1, int_0, numArray, 0, (int)numArray.Length);
                                    int_0 = int_0 + (int)numArray.Length + 1;
                                    str = Encoding.Default.GetString(numArray);
                                    return str;
                              }
                              else
                              {
                                    num1++;
                              }
                        }
                        str = "";
                  }
                  catch
                  {
                        str = "";
                  }
                  return str;
            }

            private string method_2(byte[] byte_1, ref int int_0)
            {
                  int bytes = int_0;
                  for (int i = bytes; i < (int)byte_1.Length; i++)
                  {
                        if (byte_1[i] == 32 || byte_1[i] == 10)
                        {
                              byte[] str = new byte[i - bytes];
                              Buffer.BlockCopy(byte_1, int_0, str, 0, (int)str.Length);
                              int_0 = int_0 + (int)str.Length + 1;
                              return Encoding.Default.GetString(str);
                        }
                  }
                  return "";
            }

            private byte[] method_3(byte[] byte_1)
            {
                  for (int class2 = 0; (long)class2 < (long)byte_1.Length; class2++)
                  {
                        int num = 0;
                        while (true)
                        {
                              if (num >= (int)this.byte_0.Length)
                              {
                                    break;
                              }
                              else if (byte_1[class2] == this.byte_0[num])
                              {
                                    byte_1[class2] = (byte)num;
                                    break;
                              }
                              else
                              {
                                    num++;
                              }
                        }
                  }
                  return byte_1;
            }

            private byte method_4(byte byte_1)
            {
                  for (int class2 = 0; class2 < (int)this.byte_0.Length; class2++)
                  {
                        if (byte_1 == this.byte_0[class2])
                        {
                              byte_1 = (byte)class2;
                              return byte_1;
                        }
                  }
                  return byte_1;
            }

            private void method_5(FileStream fileStream_0, int int_0)
            {
                  byte[] class2 = this.method_3(Encoding.Default.GetBytes(int_0.ToString()));
                  fileStream_0.Write(class2, 0, (int)class2.Length);
                  fileStream_0.WriteByte(this.method_4(32));
            }

   
            private void SaveFileYbqcfgToolStripMenuItem_Click(object sender, EventArgs e)
            {
                  try
                  {
                        SaveFileDialog dst = new SaveFileDialog()
                        {
                              Filter = "cfg files (*.cfg)|*.cfg|All files (*.*)|*.*",
                              FilterIndex = 1,
                              RestoreDirectory = true
                        };
                        if (dst.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                              using (FileStream str = new FileStream(dst.FileName, FileMode.Create, FileAccess.Write, FileShare.Read))
                              {
                                    byte[] buffer2 = Encoding.Default.GetBytes(this.string_0);
                                    byte[] bytes = Encoding.Default.GetBytes(this.string_1);
                                    Encoding @default = Encoding.Default;
                                    int count = this.dictionary_0.Count;
                                    byte[] numArray = @default.GetBytes(count.ToString());
                                    str.Write(buffer2, 0, (int)buffer2.Length);
                                    str.WriteByte(32);
                                    str.Write(bytes, 0, (int)bytes.Length);
                                    str.WriteByte(10);
                                    str.Write(numArray, 0, (int)numArray.Length);
                                    str.WriteByte(32);
                                    foreach (QUEST_CLASS value in this.dictionary_0.Values)
                                    {
                                          this.method_5(str, value.QuestID);
                                          this.a(str, value.QuestName);
                                          this.method_5(str, value.QuestLevel);
                                          this.method_5(str, value.Missionunknown1);
                                          this.method_5(str, value.Missionunknown2);
                                          this.method_5(str, value.Missionunknown3);
                                          this.method_5(str, value.Missionunknown4);
                                          this.method_5(str, value.Missionunknown5);
                                          this.method_5(str, value.Missionunknown6);
                                          this.method_5(str, value.Missionunknown7);
                                          this.a(str, value.QuestAccept1);
                                          this.a(str, value.QuestRefuse1);
                                          this.a(str, value.QuestAccept2);
                                          this.a(str, value.QuestRefuse2);
                                          this.method_5(str, value.RewardItems.Count);
                                          if (value.RewardItems.Count > 0)
                                          {
                                                foreach (QuestItems_Category kHENTHUONGITEM in value.RewardItems)
                                                {
                                                      this.method_5(str, kHENTHUONGITEM.ItemID);
                                                      this.method_5(str, kHENTHUONGITEM.ItemQuantity);
                                                }
                                          }
                                          if (value.QuestStageNumber <= 0)
                                          {
                                                Encoding encoding = Encoding.Default;
                                                count = value.QuestStage.Count;
                                                byte[] numArray1 = this.method_3(encoding.GetBytes(count.ToString()));
                                                str.Write(numArray1, 0, (int)numArray1.Length);
                                                str.WriteByte(this.method_4(10));
                                          }
                                          else
                                          {
                                                this.method_5(str, value.QuestStage.Count + 1);
                                                this.method_5(str, value.NpcID);
                                                this.method_5(str, value.NPCCord);
                                                this.method_5(str, value.NpcCords.MapID);
                                                this.method_5(str, value.NpcCords.CoordX);
                                                this.method_5(str, value.NpcCords.CoordY);
                                                this.method_5(str, value.NeededItem.Count);
                                                if (value.NeededItem.Count > 0)
                                                {
                                                      foreach (TaskRequiresItem_Category neededItem in value.NeededItem)
                                                      {
                                                            this.method_5(str, neededItem.ItemID);
                                                            this.method_5(str, neededItem.ItemQuantity);
                                                            this.method_5(str, neededItem.MapID);
                                                            this.method_5(str, neededItem.CoordX);
                                                            this.method_5(str, neededItem.CoordY);
                                                      }
                                                }
                                                try
                                                {
                                                      if (value.AssignmentReception1.Length > 10)
                                                      {
                                                            while (value.AssignmentReception1.LastIndexOf("\r\n") >= value.AssignmentReception1.Length - 2)
                                                            {
                                                                  value.AssignmentReception1 = value.AssignmentReception1.Remove(value.AssignmentReception1.Length - 2, 2);
                                                            }
                                                      }
                                                      if (value.Missionpresent1.Length > 10)
                                                      {
                                                            while (value.Missionpresent1.LastIndexOf("\r\n") >= value.Missionpresent1.Length - 2)
                                                            {
                                                                  value.Missionpresent1 = value.Missionpresent1.Remove(value.Missionpresent1.Length - 2, 2);
                                                            }
                                                      }
                                                }
                                                catch (Exception exception)
                                                {
                                                }
                                                this.a(str, string.Concat(value.AssignmentReception1, this.string_2));
                                                this.a(str, value.AssignmentReception2);
                                                this.a(str, value.AssignmentReception3);
                                                this.a(str, value.AssignmentReception4);
                                                this.a(str, value.AssignmentReception5);
                                                this.a(str, string.Concat(value.Missionpresent1, this.string_2));
                                                this.a(str, value.Missionpresent2);
                                                this.a(str, value.Missionpresent3);
                                                this.a(str, value.Missionpresent4);
                                                this.a(str, value.Missionpresent5);
                                                foreach (NPC_CLASS nHIEMVUGIAIDOAN in value.QuestStage)
                                                {
                                                      this.a(str, nHIEMVUGIAIDOAN.StageText);
                                                      this.method_5(str, nHIEMVUGIAIDOAN.NpcID);
                                                      this.method_5(str, nHIEMVUGIAIDOAN.NpcCoords);
                                                      this.method_5(str, nHIEMVUGIAIDOAN.NpcMapID);
                                                      this.method_5(str, nHIEMVUGIAIDOAN.NpcCoordX);
                                                      this.method_5(str, nHIEMVUGIAIDOAN.NpcCoordY);
                                                      this.method_5(str, nHIEMVUGIAIDOAN.NeededItem.Count);
                                                      if (nHIEMVUGIAIDOAN.NeededItem.Count > 0)
                                                      {
                                                            foreach (TaskRequiresItem_Category taskRequiresItemCategory in nHIEMVUGIAIDOAN.NeededItem)
                                                            {
                                                                  this.method_5(str, taskRequiresItemCategory.ItemID);
                                                                  this.method_5(str, taskRequiresItemCategory.ItemQuantity);
                                                                  this.method_5(str, taskRequiresItemCategory.MapID);
                                                                  this.method_5(str, taskRequiresItemCategory.CoordX);
                                                                  this.method_5(str, taskRequiresItemCategory.CoordY);
                                                            }
                                                      }
                                                      this.a(str, nHIEMVUGIAIDOAN.RequirementsMet);
                                                      this.a(str, nHIEMVUGIAIDOAN.string_2);
                                                      this.a(str, nHIEMVUGIAIDOAN.string_3);
                                                      this.a(str, nHIEMVUGIAIDOAN.string_4);
                                                      this.a(str, nHIEMVUGIAIDOAN.string_5);
                                                      this.a(str, nHIEMVUGIAIDOAN.RequirementsNotMet);
                                                      this.a(str, nHIEMVUGIAIDOAN.string_7);
                                                      this.a(str, nHIEMVUGIAIDOAN.string_8);
                                                      this.a(str, nHIEMVUGIAIDOAN.string_9);
                                                      this.a(str, nHIEMVUGIAIDOAN.string_10);
                                                }
                                                this.method_5(str, 0);
                                                str.WriteByte(this.method_4(10));
                                          }
                                    }
                              }
                        }
                  }
                  catch (Exception exception1)
                  {
                  }
            }

            private void SaveAll()
            {
                  OneSave = false;
                  string startupPath = Application.StartupPath;
                  string DirPath = startupPath + "\\Script";
                  DirectoryInfo di = new DirectoryInfo(DirPath);
                  if (di.Exists != true) Directory.CreateDirectory(DirPath);
                  try
                  {

                        for (int j = 0; j < listView.Items.Count; j++)
                        {
                              SaveQuest(j);
                        }
                        MessageBox.Show("퀘스트 모두 저장완료!!");

                  }
                  catch { }
            }
            
            private void SaveQuest(int _count)
            {
                  QUEST_CLASS class2;
                  if (_count > 0)
                  {                        
                        string dst = this.listView.Items[_count].SubItems[0].Text;
                        if (this.dictionary_0.TryGetValue(int.Parse(dst), out class2))
                        {
                              string startupPath = Application.StartupPath;
                              int nHIEMVUID = class2.QuestID;
                              string DirPath = startupPath + "\\Script";
                              DirectoryInfo di = new DirectoryInfo(DirPath);
                              if (di.Exists != true) Directory.CreateDirectory(DirPath);
                              using (StreamWriter key = new StreamWriter(new FileStream(string.Concat(DirPath, "\\MissIon", nHIEMVUID.ToString(), ".lua"), FileMode.Create, FileAccess.Write, FileShare.Read), Encoding.GetEncoding("GB2312")))
                              {
                                    key.Write("--LUA Generator by YULGANG - 13 20170320 \r\n");
                                    //string[] nHIEMVUTEN = new string[] { "--[", class2.NHIEM_VU_TEN, "] Stage Count:[", null, null };
                                    nHIEMVUID = class2.QuestStage.Count;
                                    //nHIEMVUTEN[3] = nHIEMVUID.ToString();
                                    //nHIEMVUTEN[4] = "]\r\n";
                                    // key.Write(string.Concat(nHIEMVUTEN));
                                    nHIEMVUID = class2.QuestID;
                                    key.Write(string.Concat("function MissIon", nHIEMVUID.ToString(), "(UserWorldId,QuestId, CzId, RwJdId)\r\n"));
                                    key.Write("  local Player = GetPlayer(UserWorldId)\r\n");
                                    key.Write("  if CzId==1 then\r\n");
                                    if (class2.QuestName.Contains("(正)") || class2.QuestName.Contains("（正派）") || class2.QuestName.Contains("(正派)"))
                                    {
                                          key.Write("      if Player.Player_Zx==2 then\r\n");
                                          key.Write("          SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                          key.Write("      elseif Player.Player_Zx==0 then\r\n");
                                          key.Write("          SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                          key.Write("      end\r\n");
                                    }
                                    if (class2.QuestName.Contains("(邪)") || class2.QuestName.Contains("（邪派）") || class2.QuestName.Contains("(邪派)"))
                                    {
                                          key.Write("      if Player.Player_Zx==1 then\r\n");
                                          key.Write("\t\t\tSendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                          key.Write("      elseif Player.Player_Zx==0 then\r\n");
                                          key.Write("          SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                          key.Write("      end\r\n");
                                    }
                                    if (class2.QuestName.Contains("/刀)"))
                                    {
                                          key.Write("      if Player.Player_Job!=1 then\r\n");
                                          key.Write("         SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                          key.Write("      end\r\n");
                                    }
                                    if (class2.QuestName.Contains("/剑)"))
                                    {
                                          key.Write("      if Player.Player_Job!=2 then\r\n");
                                          key.Write("          SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                          key.Write("      end\r\n");
                                    }
                                    if (class2.QuestName.Contains("/枪)"))
                                    {
                                          key.Write("      if Player.Player_Job!=3 then\r\n");
                                          key.Write("          SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                          key.Write("      end\r\n");
                                    }
                                    if (class2.QuestName.Contains("/弓)"))
                                    {
                                          key.Write("      if Player.Player_Job!=4 then\r\n");
                                          key.Write("          SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                          key.Write("      end\r\n");
                                    }
                                    if (class2.QuestName.Contains("/医生)"))
                                    {
                                          key.Write("      if Player.Player_Job!=5 then\r\n");
                                          key.Write("          SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                          key.Write("      end\r\n");
                                    }
                                    if (class2.QuestName.Contains("/刺客)"))
                                    {
                                          key.Write("      if Player.Player_Job!=6 then\r\n");
                                          key.Write("          SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                          key.Write("      end\r\n");
                                    }
                                    nHIEMVUID = class2.QuestLevel;
                                    key.Write(string.Concat("      if Player.Player_FLD_LEVEL<", nHIEMVUID.ToString(), " then\r\n"));
                                    key.Write("          SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                    key.Write("      else\r\n");
                                    key.Write("          local QuestLevel=GetQuestLevel(UserWorldId,QuestId)\r\n");
                                    key.Write("          if QuestLevel==1 then\r\n");
                                    key.Write("              RwJdId=2\r\n");
                                    key.Write("              AddQuest(UserWorldId,QuestId,RwJdId)\r\n");
                                    key.Write("              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)\r\n");
                                    if (class2.QuestStage.Count == 1)
                                    {
                                          foreach (TaskRequiresItem_Category neededItem in class2.NeededItem)
                                          {
                                                string[] str = new string[] { "              local  bool", null, null, null, null, null, null };
                                                nHIEMVUID = neededItem.ItemID;
                                                str[1] = nHIEMVUID.ToString();
                                                str[2] = " = GetQuestItme(UserWorldId, ";
                                                nHIEMVUID = neededItem.ItemID;
                                                str[3] = nHIEMVUID.ToString();
                                                str[4] = ", ";
                                                nHIEMVUID = neededItem.ItemQuantity;
                                                str[5] = nHIEMVUID.ToString();
                                                str[6] = ")\r\n";
                                                key.Write(string.Concat(str));
                                                nHIEMVUID = neededItem.ItemID;
                                                key.Write(string.Concat("              if bool", nHIEMVUID.ToString(), " then\r\n"));
                                                nHIEMVUID = neededItem.ItemID;
                                                key.Write(string.Concat("                  AddQuestItme(UserWorldId,", nHIEMVUID.ToString(), ",0)\r\n"));
                                                key.Write("              else\r\n");
                                                key.Write("                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                                key.Write("              end\r\n");
                                          }
                                    }
                                    else if (class2.QuestStage.Count > 1)
                                    {
                                          for (int i = 0; i < class2.QuestStage.Count; i++)
                                          {
                                                if (i + 2 <= class2.QuestStage.Count)
                                                {
                                                      nHIEMVUID = i + 2;
                                                      key.Write(string.Concat("          elseif QuestLevel==", nHIEMVUID.ToString(), " then\r\n"));
                                                }
                                                foreach (TaskRequiresItem_Category taskRequiresItemCategory in class2.QuestStage[i].NeededItem)
                                                {
                                                      string[] strArrays = new string[] { "              local  bool", null, null, null, null, null, null };
                                                      nHIEMVUID = taskRequiresItemCategory.ItemID;
                                                      strArrays[1] = nHIEMVUID.ToString();
                                                      strArrays[2] = " = GetQuestItme(UserWorldId, ";
                                                      nHIEMVUID = taskRequiresItemCategory.ItemID;
                                                      strArrays[3] = nHIEMVUID.ToString();
                                                      strArrays[4] = ", ";
                                                      nHIEMVUID = taskRequiresItemCategory.ItemQuantity;
                                                      strArrays[5] = nHIEMVUID.ToString();
                                                      strArrays[6] = ")\r\n";
                                                      key.Write(string.Concat(strArrays));
                                                      nHIEMVUID = taskRequiresItemCategory.ItemID;
                                                      key.Write(string.Concat("              if bool", nHIEMVUID.ToString(), " then\r\n"));
                                                      nHIEMVUID = taskRequiresItemCategory.ItemID;
                                                      key.Write(string.Concat("                  AddQuestItme(UserWorldId,", nHIEMVUID.ToString(), ",0)\r\n"));
                                                      key.Write("              else\r\n");
                                                      key.Write("                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                                      key.Write("              end\r\n");
                                                }
                                                if (i + 1 != class2.QuestStage.Count)
                                                {
                                                      nHIEMVUID = i + 3;
                                                      key.Write(string.Concat("              RwJdId=", nHIEMVUID.ToString(), "\r\n"));
                                                      key.Write("              AddQuest(UserWorldId,QuestId,RwJdId)\r\n");
                                                      key.Write("              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)\r\n");
                                                }
                                          }
                                    }
                                    key.Write("          else\r\n");
                                    key.Write("              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)\r\n");
                                    key.Write("          end\r\n");
                                    key.Write("      end\r\n");
                                    key.Write("  elseif CzId==2 then\r\n");
                                    key.Write("      RwJdId=1\r\n");
                                    key.Write("      AddQuest(UserWorldId,QuestId,RwJdId)\r\n");
                                    key.Write("      SendMissionMsg(UserWorldId,QuestId, 21, RwJdId)\r\n");
                                    key.Write("  elseif CzId==3 then\r\n");
                                    key.Write("      SendMissionMsg(UserWorldId,QuestId, 31, RwJdId)\r\n");
                                    key.Write("  elseif CzId==5 then\r\n");
                                    key.Write("      local QuestLevel=GetQuestLevel(UserWorldId,QuestId)\r\n");
                                    nHIEMVUID = 1 + class2.QuestStage.Count;
                                    key.Write(string.Concat("      if QuestLevel==", nHIEMVUID.ToString(), " then\r\n"));
                                    if (class2.RewardItems.Count > 0)
                                    {
                                          foreach (QuestItems_Category kHENTHUONGITEM in class2.RewardItems)
                                          {
                                                nHIEMVUID = kHENTHUONGITEM.ItemID;
                                                key.Write(string.Concat("              local weiz", nHIEMVUID.ToString(), "=GetPackage(UserWorldId)\r\n"));
                                                nHIEMVUID = kHENTHUONGITEM.ItemID;
                                                key.Write(string.Concat("              if weiz", nHIEMVUID.ToString(), "==-1 then\r\n"));
                                                key.Write("                  SendSysMsg(UserWorldId,\"There is no space in the equipment column\", 9, \"SystemMessage\")\r\n");
                                                key.Write("                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                                key.Write("                  return \r\n");
                                                key.Write("              else\r\n");
                                                string[] str1 = new string[] { "                  AddItme(UserWorldId,", null, null, null, null, null, null };
                                                nHIEMVUID = kHENTHUONGITEM.ItemID;
                                                str1[1] = nHIEMVUID.ToString();
                                                str1[2] = ",weiz";
                                                nHIEMVUID = kHENTHUONGITEM.ItemID;
                                                str1[3] = nHIEMVUID.ToString();
                                                str1[4] = ",";
                                                nHIEMVUID = kHENTHUONGITEM.ItemQuantity;
                                                str1[5] = nHIEMVUID.ToString();
                                                str1[6] = ")\r\n";
                                                key.Write(string.Concat(str1));
                                                key.Write("              end\r\n");
                                          }
                                    }
                                    key.Write("      end\r\n");
                                    key.Write("      SendMissionMsg(UserWorldId,QuestId, 51, RwJdId)\r\n");
                                    key.Write("  end\r\n");
                                    key.Write("end\r\n");
                              }
                        }
                        if (OneSave)
                        {
                              MessageBox.Show("[" + class2.QuestID.ToString() + " : " + class2.QuestName + "] 퀘스트 저장 완료!!");
                        }
                  }
            }

            private void SaveQuestNew(int _count)
            {

                  if (_count > 0)
                  {

                        QUEST_CLASS class2;
                        string text = this.listView.Items[_count].SubItems[0].Text;

                        if (this.dictionary_0.TryGetValue(int.Parse(text), out class2))
                        {
                              string DirPath = Application.StartupPath + "\\Script\\";
                              DirectoryInfo di = new DirectoryInfo(DirPath);
                              if (di.Exists != true) Directory.CreateDirectory(DirPath);
                              using (StreamWriter streamWriter = new StreamWriter(new FileStream(DirPath + "MissIon" + class2.QuestID.ToString() + ".lua", FileMode.Create, FileAccess.Write, FileShare.Read), Encoding.GetEncoding("GB2312")))
                              {
                                    streamWriter.Write("--LUA Generator by YULGANG - 13 - 20170319 \r\n");
                                    streamWriter.Write(string.Concat(new string[]
                                    {
                                                "--Ten nhiem vu: (",
                                                class2.QuestName,
                                                ") --- So buoc: (",
                                                class2.QuestStage.Count.ToString(),
                                                ")\r\n"
                                    }));
                                    streamWriter.Write("function MissIon" + class2.QuestID.ToString() + "(UserWorldId,QuestId, StepQuest, StatusQuest)\r\n");
                                    streamWriter.Write("  local Player = GetPlayer(UserWorldId)\r\n");
                                    streamWriter.Write("--Cac buoc xu li nhiem vu\r\n");
                                    streamWriter.Write("  if StepQuest==1 then\r\n");
                                    if (class2.QuestName.Contains("(正)") || class2.QuestName.Contains("（正派）") || class2.QuestName.Contains("(正派)"))
                                    {
                                          streamWriter.Write("      if Player.Player_Zx==2 then\r\n");
                                          streamWriter.Write("          SendSysMsg(UserWorldId,\"Ta phai khong the nhan nhiem vu !\", 9, \"He thong\")\r\n");
                                          streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)\r\n");
                                          streamWriter.Write("      elseif Player.Player_Zx==0 then\r\n");
                                          streamWriter.Write("          SendSysMsg(UserWorldId,\"Chua gia nhap mon phai, khong the nhan nhiem vu !\", 9, \"He thong\")\r\n");
                                          streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)\r\n");
                                          streamWriter.Write("      end\r\n");
                                    }
                                    if (class2.QuestName.Contains("(邪)") || class2.QuestName.Contains("（邪派）") || class2.QuestName.Contains("(邪派)"))
                                    {
                                          streamWriter.Write("      if Player.Player_Zx==1 then\r\n");
                                          streamWriter.Write("          SendSysMsg(UserWorldId,\"Chinh phai khong the nhan nhiem vu !\", 9, \"He thong\")\r\n");
                                          streamWriter.Write("\t\t\tSendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)\r\n");
                                          streamWriter.Write("      elseif Player.Player_Zx==0 then\r\n");
                                          streamWriter.Write("          SendSysMsg(UserWorldId,\"Chua gia nhap mon phai, khong the nhan nhiem vu !\", 9, \"He thong\")\r\n");
                                          streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12,StatusQuest)\r\n");
                                          streamWriter.Write("      end\r\n");
                                    }
                                    if (class2.QuestName.Contains("/刀)"))
                                    {
                                          streamWriter.Write("      if Player.Player_Job~=1 then\r\n");
                                          streamWriter.Write("         SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)\r\n");
                                          streamWriter.Write("      end\r\n");
                                    }
                                    if (class2.QuestName.Contains("/剑)"))
                                    {
                                          streamWriter.Write("      if Player.Player_Job~=2 then\r\n");
                                          streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)\r\n");
                                          streamWriter.Write("      end\r\n");
                                    }
                                    if (class2.QuestName.Contains("/枪)"))
                                    {
                                          streamWriter.Write("      if Player.Player_Job~=3 then\r\n");
                                          streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)\r\n");
                                          streamWriter.Write("      end\r\n");
                                    }
                                    if (class2.QuestName.Contains("/弓)"))
                                    {
                                          streamWriter.Write("      if Player.Player_Job~=4 then\r\n");
                                          streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)\r\n");
                                          streamWriter.Write("      end\r\n");
                                    }
                                    if (class2.QuestName.Contains("/医生)"))
                                    {
                                          streamWriter.Write("      if Player.Player_Job~=5 then\r\n");
                                          streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)\r\n");
                                          streamWriter.Write("      end\r\n");
                                    }
                                    if (class2.QuestName.Contains("/刺客)"))
                                    {
                                          streamWriter.Write("      if Player.Player_Job~=6 then\r\n");
                                          streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)\r\n");
                                          streamWriter.Write("      end\r\n");
                                    }
                                    streamWriter.Write("      if Player.Player_FLD_LEVEL<" + class2.QuestLevel.ToString() + " then \r\n");
                                    streamWriter.Write("          SendSysMsg(UserWorldId,\"Ban phai dat cap do " + class2.QuestLevel.ToString() + " moi co the nhan nhiem vu !\", 9, \"He thong\")\r\n");
                                    streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --Chua du cap du yeu cau\r\n");
                                    streamWriter.Write("      else\r\n");
                                    streamWriter.Write("          local QuestLevel=GetQuestLevel(UserWorldId,QuestId)  --lay gia tri QuestLevel la buoc hien tai cua nhan vatt\r\n");
                                    streamWriter.Write("          if QuestLevel==1 then  --neu dang o buoc 1\r\n");
                                    if (class2.QuestStage.Count == 1)
                                    {
                                          streamWriter.Write("              local controng=GetPackages(UserWorldId," + class2.RewardItems.Count.ToString() + ")  --vi tri con trong\r\n");
                                          streamWriter.Write("              if controng.Count < " + class2.RewardItems.Count.ToString() + " then  --neu thung do day \r\n");
                                          streamWriter.Write("                SendSysMsg(UserWorldId,\"Tui do khong du " + class2.RewardItems.Count.ToString() + " khong gian trong!\", 9, \"Chu Y\")\r\n");
                                          streamWriter.Write("                SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)\r\n");
                                          streamWriter.Write("                return \r\n");
                                          streamWriter.Write("              else  --neu con cho trong\r\n");
                                          foreach (TaskRequiresItem_Category current in class2.NeededItem)
                                          {
                                                streamWriter.Write(string.Concat(new string[]
                                                {
                                                            "              local bool",
                                                            current.ItemID.ToString(),
                                                            " = GetQuestItme(UserWorldId, ",
                                                            current.ItemID.ToString(),
                                                            ", ",
                                                            current.ItemQuantity.ToString(),
                                                            ")  --kiem tra vat pham nhiem vu\r\n"
                                                }));
                                          }
                                          foreach (TaskRequiresItem_Category current2 in class2.NeededItem)
                                          {
                                                streamWriter.Write("              if bool" + current2.ItemID.ToString() + " then --du yeu cau\r\n");
                                          }
                                          foreach (TaskRequiresItem_Category current3 in class2.NeededItem)
                                          {
                                                streamWriter.Write("                  AddQuestItme(UserWorldId," + current3.ItemID.ToString() + ",0) --xoa item nhiem vu\r\n");
                                          }
                                          streamWriter.Write("                  StatusQuest=2  --dat buoc tiep theo la 2\r\n");
                                          streamWriter.Write("                  AddQuest(UserWorldId,QuestId, StatusQuest)  --cho lam buoc tiep theo la: 2\r\n");
                                          streamWriter.Write("                  SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 2\r\n");
                                          foreach (TaskRequiresItem_Category arg_656_0 in class2.NeededItem)
                                          {
                                                streamWriter.Write("              else\r\n");
                                                streamWriter.Write("                  SendSysMsg(UserWorldId,\"Chua dat yeu cau, quay lai sau !\", 9, \"He thong\")\r\n");
                                                streamWriter.Write("                  SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest) \r\n");
                                                streamWriter.Write("              end\r\n");
                                          }
                                          streamWriter.Write("          end\r\n");
                                    }
                                    else
                                    {
                                          if (class2.QuestStage.Count > 1)
                                          {
                                                foreach (TaskRequiresItem_Category current4 in class2.NeededItem)
                                                {
                                                      streamWriter.Write(string.Concat(new string[]
                                                      {
                                                                  "              local bool",
                                                                  current4.ItemID.ToString(),
                                                                  " = GetQuestItme(UserWorldId, ",
                                                                  current4.ItemID.ToString(),
                                                                  ", ",
                                                                  current4.ItemQuantity.ToString(),
                                                                  ")  --kiem tra vat pham nhiem vu\r\n"
                                                      }));
                                                }
                                                foreach (TaskRequiresItem_Category current5 in class2.NeededItem)
                                                {
                                                      streamWriter.Write("              if bool" + current5.ItemID.ToString() + " then --du yeu cau\r\n");
                                                }
                                                foreach (TaskRequiresItem_Category current6 in class2.NeededItem)
                                                {
                                                      streamWriter.Write("              AddQuestItme(UserWorldId," + current6.ItemID.ToString() + ",0) --xoa vat pham nhiem vu\r\n");
                                                }
                                                /*
                                                foreach (TaskRequiresItem_Category current7 in class2.QuestStage[0].NeededItem)
                                                {
                                                      if (current7.ItemQuantity != 1)
                                                      {
                                                            streamWriter.Write(" \r\n");
                                                            streamWriter.Write("-- VAT PHAM ROT RA KHI DANH QUAI --\r\n");
                                                            streamWriter.Write(string.Concat(new string[]
                                                            {
                                                                        "-- ID VAT PHAM: ( ",
                                                                        current7.ItemID.ToString(),
                                                                        " ) -- SO LUONG: ( ",
                                                                        current7.ItemQuantity.ToString(),
                                                                        " ) -- BUOC: ( 2 ) --\r\n"
                                                            }));
                                                            streamWriter.Write(string.Concat(new string[]
                                                            {
                                                                        "-- BAN DO: ( ",
                                                                        current7.MapID.ToString(),
                                                                        " ) -- X: ( ",
                                                                        current7.CoordX.ToString(),
                                                                        " ) -- Y: ( ",
                                                                        current7.CoordY.ToString(),
                                                                        " ) --\r\n"
                                                            }));
                                                            streamWriter.Write(" \r\n");
                                                      }
                                                      else
                                                      {
                                                            if (current7.ItemID == 900000043 || current7.ItemID == 900000008 || current7.ItemID == 900000513 || current7.ItemID == 900000010 || current7.ItemID == 900000003 || current7.ItemID == 900000465 || current7.ItemID == 900000467)
                                                            {
                                                                  streamWriter.Write(" \r\n");
                                                                  streamWriter.Write("-- VAT PHAM ROT RA KHI DANH QUAI --\r\n");
                                                                  streamWriter.Write(string.Concat(new string[]
                                                                  {
                                                                              "-- ID VAT PHAM: ( ",
                                                                              current7.ItemID.ToString(),
                                                                              " ) -- SO LUONG: ( ",
                                                                              current7.ItemQuantity.ToString(),
                                                                              " ) -- BUOC: ( 2 ) --\r\n"
                                                                  }));
                                                                  streamWriter.Write(string.Concat(new string[]
                                                                  {
                                                                              "-- BAN DO: ( ",
                                                                              current7.MapID.ToString(),
                                                                              " ) -- X: ( ",
                                                                              current7.CoordX.ToString(),
                                                                              " ) -- Y: ( ",
                                                                              current7.CoordY.ToString(),
                                                                              " ) --\r\n"
                                                                  }));
                                                                  streamWriter.Write(" \r\n");
                                                            }
                                                            else
                                                            {
                                                                  streamWriter.Write(string.Concat(new string[]
                                                                  {
                                                                              "                  AddQuestItme(UserWorldId,",
                                                                              current7.ItemID.ToString(),
                                                                              ",",
                                                                              current7.ItemQuantity.ToString(),
                                                                              ") --them vat pham nhiem vu cho buoc tiep theo\r\n"
                                                                  }));
                                                            }
                                                      }
                                                }
                                                */
                                                streamWriter.Write("              StatusQuest=2 \r\n");
                                                streamWriter.Write("              AddQuest(UserWorldId,QuestId, StatusQuest) \r\n");
                                                streamWriter.Write("              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la 2\r\n");
                                                foreach (TaskRequiresItem_Category arg_B4E_0 in class2.NeededItem)
                                                {
                                                      streamWriter.Write("              else \r\n");
                                                      streamWriter.Write("              SendSysMsg(UserWorldId,\"Chua dat yeu cau, quay lai sau !\", 9, \"He thong\")\r\n");
                                                      streamWriter.Write("              SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --cho lam buoc tiep theo la 2\r\n");
                                                      streamWriter.Write("              end \r\n");
                                                }
                                                for (int j = 0; j < class2.QuestStage.Count - 1; j++)
                                                {
                                                      streamWriter.Write("          elseif QuestLevel==" + (j + 2).ToString() + " then\r\n");
                                                      if (j == class2.QuestStage.Count - 2)
                                                      {
                                                            streamWriter.Write("              local controng=GetPackages(UserWorldId," + class2.RewardItems.Count.ToString() + ")  --vi tri con trong\r\n");
                                                            streamWriter.Write("              if controng.Count < " + class2.RewardItems.Count.ToString() + " then  --neu thung do day \r\n");
                                                            streamWriter.Write("                SendSysMsg(UserWorldId,\"Tui do khong du " + class2.RewardItems.Count.ToString() + " khong gian trong!\", 9, \"Chu Y\")\r\n");
                                                            streamWriter.Write("                SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)\r\n");
                                                            streamWriter.Write("                return \r\n");
                                                            streamWriter.Write("              else  --neu con cho trong\r\n");
                                                      }
                                                      foreach (TaskRequiresItem_Category current8 in class2.QuestStage[j].NeededItem)
                                                      {
                                                            streamWriter.Write(string.Concat(new string[]
                                                            {
                                                                        "              local bool",
                                                                        current8.ItemID.ToString(),
                                                                        " = GetQuestItme(UserWorldId, ",
                                                                        current8.ItemID.ToString(),
                                                                        ", ",
                                                                        current8.ItemQuantity.ToString(),
                                                                        ")  --kiem tra vat pham nhiem vu\r\n"
                                                            }));
                                                      }
                                                      foreach (TaskRequiresItem_Category current9 in class2.QuestStage[j].NeededItem)
                                                      {
                                                            streamWriter.Write("              if bool" + current9.ItemID.ToString() + " then --du yeu cau\r\n");
                                                      }
                                                      foreach (TaskRequiresItem_Category current10 in class2.QuestStage[j].NeededItem)
                                                      {
                                                            streamWriter.Write("                  AddQuestItme(UserWorldId," + current10.ItemID.ToString() + ",0) --xoa vat pham nhiem vu\r\n");
                                                      }
                                                      /*
                                                      foreach (TaskRequiresItem_Category current11 in class2.QuestStage[j + 1].NeededItem)
                                                      {
                                                            if (current11.ItemQuantity != 1)
                                                            {
                                                                  streamWriter.Write(" \r\n");
                                                                  streamWriter.Write("-- VAT PHAM ROT RA KHI DANH QUAI --\r\n");
                                                                  streamWriter.Write(string.Concat(new object[]
                                                                  {
                                                                              "-- ID VAT PHAM: ( ",
                                                                              current11.ItemID.ToString(),
                                                                              " ) -- SO LUONG: ( ",
                                                                              current11.ItemQuantity.ToString(),
                                                                              " ) -- BUOC: ( ",
                                                                              j + 3,
                                                                              " ) --\r\n"
                                                                  }));
                                                                  streamWriter.Write(string.Concat(new string[]
                                                                  {
                                                                              "-- BAN DO: ( ",
                                                                              current11.MapID.ToString(),
                                                                              " ) -- X: ( ",
                                                                              current11.CoordX.ToString(),
                                                                              " ) -- Y: ( ",
                                                                              current11.CoordY.ToString(),
                                                                              " ) --\r\n"
                                                                  }));
                                                                  streamWriter.Write(" \r\n");
                                                            }
                                                            else
                                                            {
                                                                  if (current11.ItemID == 900000043 || current11.ItemID == 900000008 || current11.ItemID == 900000513 || current11.ItemID == 900000010 || current11.ItemID == 900000003 || current11.ItemID == 900000465 || current11.ItemID == 900000467)
                                                                  {
                                                                        streamWriter.Write(" \r\n");
                                                                        streamWriter.Write("-- VAT PHAM ROT RA KHI DANH QUAI --\r\n");
                                                                        streamWriter.Write(string.Concat(new object[]
                                                                        {
                                                                                    "-- ID VAT PHAM: ( ",
                                                                                    current11.ItemID.ToString(),
                                                                                    " ) -- SO LUONG: ( ",
                                                                                    current11.ItemQuantity.ToString(),
                                                                                    " ) -- BUOC: ( ",
                                                                                    j + 3,
                                                                                    " ) --\r\n"
                                                                        }));
                                                                        streamWriter.Write(string.Concat(new string[]
                                                                        {
                                                                                    "-- BAN DO: ( ",
                                                                                    current11.MapID.ToString(),
                                                                                    " ) -- X: ( ",
                                                                                    current11.CoordX.ToString(),
                                                                                    " ) -- Y: ( ",
                                                                                    current11.CoordY.ToString(),
                                                                                    " ) --\r\n"
                                                                        }));
                                                                        streamWriter.Write(" \r\n");
                                                                  }
                                                                  else
                                                                  {
                                                                        streamWriter.Write(string.Concat(new string[]
                                                                        {
                                                                                    "                  AddQuestItme(UserWorldId,",
                                                                                    current11.ItemID.ToString(),
                                                                                    ",",
                                                                                    current11.ItemQuantity.ToString(),
                                                                                    ") --them vat pham nhiem vu cho buoc tiep theo\r\n"
                                                                        }));
                                                                  }
                                                            }
                                                      }
                                                      */
                                                      if (j + 1 != class2.QuestStage.Count)
                                                      {
                                                            streamWriter.Write(string.Concat(new string[]
                                                            {
                                                                        "              StatusQuest=",
                                                                        (j + 3).ToString(),
                                                                        "  --dat buoc tiep theo la: ",
                                                                        (j + 3).ToString(),
                                                                        "\r\n"
                                                            }));
                                                            streamWriter.Write("              AddQuest(UserWorldId, QuestId, StatusQuest)  --cho lam buoc tiep theo la: " + (j + 3).ToString() + "\r\n");
                                                            streamWriter.Write("              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: " + (j + 3).ToString() + "\r\n");
                                                      }
                                                      foreach (TaskRequiresItem_Category arg_11ED_0 in class2.QuestStage[j].NeededItem)
                                                      {
                                                            streamWriter.Write("              else \r\n");
                                                            streamWriter.Write("                  SendSysMsg(UserWorldId,\"Chua dat yeu cau, quay lai sau !\", 9, \"He thong\")\r\n");
                                                            streamWriter.Write("                  SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest) \r\n");
                                                            streamWriter.Write("              end\r\n");
                                                      }
                                                      if (j == class2.QuestStage.Count - 2)
                                                      {
                                                            streamWriter.Write("              end\r\n");
                                                      }
                                                }
                                          }
                                    }
                                    streamWriter.Write("           else\r\n");
                                    streamWriter.Write("           SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest) \r\n");
                                    streamWriter.Write("           end\r\n");
                                    streamWriter.Write("      end\r\n");
                                    streamWriter.Write("  elseif StepQuest==2 then\r\n");
                                    streamWriter.Write("      local QuestLevel=GetQuestLevel(UserWorldId,QuestId)\r\n");
                                    streamWriter.Write("      if Player.Player_FLD_LEVEL<" + class2.QuestLevel.ToString() + " then  \r\n");
                                    streamWriter.Write("          SendSysMsg(UserWorldId,\"Ban phai dat cap do " + class2.QuestLevel.ToString() + " moi co the nhan nhiem vu !\", 9, \"He thong\")\r\n");
                                    streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --chua dat yeu cau, quay lai sau\r\n");
                                    streamWriter.Write("      else\r\n");
                                    int num = class2.QuestStage.Count + 1;
                                    streamWriter.Write("         if QuestLevel==" + num + " then \r\n");
                                    streamWriter.Write("            SendMissionMsg(UserWorldId,QuestId, 22, StatusQuest) \r\n");
                                    streamWriter.Write("         else\r\n");
                                    /*
                                    foreach (TaskRequiresItem_Category current12 in class2.NeededItem)
                                    {                                          
                                          if (current12.ItemQuantity != 1)
                                          {
                                                streamWriter.Write(" \r\n");
                                                streamWriter.Write("-- VAT PHAM ROT RA KHI DANH QUAI --\r\n");
                                                streamWriter.Write(string.Concat(new string[]
                                                {
                                                            "-- ID VAT PHAM: ( ",
                                                            current12.ItemID.ToString(),
                                                            " ) -- SO LUONG: ( ",
                                                            current12.ItemQuantity.ToString(),
                                                            " ) -- BUOC: ( 1 ) --\r\n"
                                                }));
                                                streamWriter.Write(string.Concat(new string[]
                                                {
                                                            "-- BAN DO: ( ",
                                                            current12.MapID.ToString(),
                                                            " ) -- X: ( ",
                                                            current12.CoordX.ToString(),
                                                            " ) -- Y: ( ",
                                                            current12.CoordY.ToString(),
                                                            " ) --\r\n"
                                                }));
                                                streamWriter.Write(" \r\n");
                                          }
                                          else
                                          {
                                                if (current12.ItemID == 900000043 || current12.ItemID == 900000008 || current12.ItemID == 900000513 || current12.ItemID == 900000010 || current12.ItemID == 900000003 || current12.ItemID == 900000465 || current12.ItemID == 900000467)
                                                {
                                                      streamWriter.Write(" \r\n");
                                                      streamWriter.Write("-- VAT PHAM ROT RA KHI DANH QUAI --\r\n");
                                                      streamWriter.Write(string.Concat(new string[]
                                                      {
                                                                  "-- ID VAT PHAM: ( ",
                                                                  current12.ItemID.ToString(),
                                                                  " ) -- SO LUONG: ( ",
                                                                  current12.ItemQuantity.ToString(),
                                                                  " ) -- BUOC: ( 1 ) --\r\n"
                                                      }));
                                                      streamWriter.Write(string.Concat(new string[]
                                                      {
                                                                  "-- BAN DO: ( ",
                                                                  current12.MapID.ToString(),
                                                                  " ) -- X: ( ",
                                                                  current12.CoordX.ToString(),
                                                                  " ) -- Y: ( ",
                                                                  current12.CoordY.ToString(),
                                                                  " ) --\r\n"
                                                      }));
                                                      streamWriter.Write(" \r\n");
                                                }
                                                else
                                                {
                                                      streamWriter.Write(string.Concat(new string[]
                                                      {
                                                                  "                  AddQuestItme(UserWorldId,",
                                                                  current12.ItemID.ToString(),
                                                                  ",",
                                                                  current12.ItemQuantity.ToString(),
                                                                  ") --them vat pham nhiem vu cho buoc tiep theo\r\n"
                                                      }));
                                                }
                                          }                                          
                                          
                                    }
                                    */
                                    streamWriter.Write("            StatusQuest=1\r\n");
                                    streamWriter.Write("            AddQuest(UserWorldId,QuestId, StatusQuest)\r\n");
                                    streamWriter.Write("            SendMissionMsg(UserWorldId,QuestId, 21, StatusQuest)\r\n");
                                    streamWriter.Write("            SendSysMsg(UserWorldId,\"Nhan nhiem vu thanh cong !\", 9, \"He thong\")\r\n");
                                    streamWriter.Write("         end\r\n");
                                    streamWriter.Write("      end\r\n");
                                    streamWriter.Write("  elseif StepQuest==3 then\r\n");
                                    streamWriter.Write("      SendMissionMsg(UserWorldId,QuestId, 31, StatusQuest)\r\n");
                                    streamWriter.Write("      SendSysMsg(UserWorldId,\"Ban vua tu choi nhiem vu !\", 9, \"He thong\")\r\n");
                                    streamWriter.Write("  elseif StepQuest==4 then\r\n");
                                    streamWriter.Write("      SendSysMsg(UserWorldId,\"Huy bo nhiem vu thanh cong !\", 9, \"He thong\")\r\n");
                                    streamWriter.Write("  elseif StepQuest==5 then\r\n");
                                    streamWriter.Write("      local QuestLevel=GetQuestLevel(UserWorldId,QuestId)\r\n");
                                    int num2 = class2.QuestStage.Count + 1;
                                    streamWriter.Write("      if QuestLevel==" + num2 + " then\r\n");
                                    streamWriter.Write("      local controng=GetPackages(UserWorldId," + class2.RewardItems.Count.ToString() + ")  --vi tri con trong\r\n");
                                    streamWriter.Write("        if controng.Count < " + class2.RewardItems.Count.ToString() + " then  --neu thung do day \r\n");
                                    streamWriter.Write("          SendSysMsg(UserWorldId,\"Tui do khong du " + class2.RewardItems.Count.ToString() + " khong gian trong!\", 9, \"Chu Y\")\r\n");
                                    streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)\r\n");
                                    streamWriter.Write("          return \r\n");
                                    streamWriter.Write("        else  --neu con cho trong\r\n");
                                    if (class2.RewardItems.Count > 0)
                                    {
                                          foreach (QuestItems_Category current13 in class2.RewardItems)
                                          {
                                                int itemID = current13.ItemID;
                                                if (itemID <= 800000029)
                                                {
                                                      if (itemID <= 9001215)
                                                      {
                                                            if (itemID == 9000120)
                                                            {
                                                                  streamWriter.Write("                 UpExp(UserWorldId," + current13.ItemID + ",10800000) \r\n");
                                                                  continue;
                                                            }
                                                            switch (itemID)
                                                            {
                                                                  case 9001214:
                                                                        streamWriter.Write("                 UpExp(UserWorldId," + current13.ItemID + ",10800000) \r\n");
                                                                        continue;
                                                                  case 9001215:
                                                                        streamWriter.Write("                 UpExp(UserWorldId," + current13.ItemID + ",10800000) \r\n");
                                                                        continue;
                                                            }
                                                      }
                                                      else
                                                      {
                                                            switch (itemID)
                                                            {
                                                                  case 800000001:
                                                                        streamWriter.Write("              --tang thuong\r\n");
                                                                        streamWriter.Write(string.Concat(new string[]
                                                                        {
                                                                              "              local weiz",
                                                                              current13.ItemID.ToString(),
                                                                              "=GetPackages(UserWorldId,",
                                                                              current13.ItemQuantity.ToString(),
                                                                              ")  --vi tri con trong\r\n"
                                                                        }));
                                                                        streamWriter.Write("                  local chiso=math.random(100005,100011) \r\n");
                                                                        for (int k = 0; k < current13.ItemQuantity; k++)
                                                                        {
                                                                              streamWriter.Write(string.Concat(new object[]
                                                                              {
                                                                                    "                  AddItmeProp(UserWorldId,",
                                                                                    current13.ItemID.ToString(),
                                                                                    ",weiz",
                                                                                    current13.ItemID.ToString(),
                                                                                    "[",
                                                                                    k,
                                                                                    "],1,chiso,0,0,0,0,0,0,0,0)\r\n"
                                                                              }));
                                                                        }
                                                                        continue;
                                                                  case 800000002:
                                                                        streamWriter.Write("              --tang thuong\r\n");
                                                                        streamWriter.Write(string.Concat(new string[]
                                                                        {
                                                                              "              local weiz",
                                                                              current13.ItemID.ToString(),
                                                                              "=GetPackages(UserWorldId,",
                                                                              current13.ItemQuantity.ToString(),
                                                                              ")  --vi tri con trong\r\n"
                                                                        }));
                                                                        streamWriter.Write("                  local chiso=math.random(200001,200004) \r\n");
                                                                        for (int l = 0; l < current13.ItemQuantity; l++)
                                                                        {
                                                                              streamWriter.Write(string.Concat(new object[]
                                                                              {
                                                                                    "                  AddItmeProp(UserWorldId,",
                                                                                    current13.ItemID.ToString(),
                                                                                    ",weiz",
                                                                                    current13.ItemID.ToString(),
                                                                                    "[",
                                                                                    l,
                                                                                    "],1,chiso,0,0,0,0,0,0,0,0)\r\n"
                                                                              }));
                                                                        }
                                                                        continue;
                                                                  case 800000003:
                                                                        streamWriter.Write("              --tang thuong\r\n");
                                                                        streamWriter.Write(string.Concat(new string[]
                                                                        {
                                                                              "              local weiz",
                                                                              current13.ItemID.ToString(),
                                                                              "=GetPackages(UserWorldId,",
                                                                              current13.ItemQuantity.ToString(),
                                                                              ")  --vi tri con trong\r\n"
                                                                        }));
                                                                        for (int m = 0; m < current13.ItemQuantity; m++)
                                                                        {
                                                                              streamWriter.Write(string.Concat(new object[]
                                                                              {
                                                                                    "                  AddItmeProp(UserWorldId,",
                                                                                    current13.ItemID.ToString(),
                                                                                    ",weiz",
                                                                                    current13.ItemID.ToString(),
                                                                                    "[",
                                                                                    m,
                                                                                    "],1,0,0,0,0,0,0,0,0,0)\r\n"
                                                                              }));
                                                                        }
                                                                        continue;
                                                                  case 800000004:
                                                                        streamWriter.Write("              --tang thuong\r\n");
                                                                        streamWriter.Write(string.Concat(new string[]
                                                                        {
                                                                              "              local weiz",
                                                                              current13.ItemID.ToString(),
                                                                              "=GetPackages(UserWorldId,",
                                                                              current13.ItemQuantity.ToString(),
                                                                              ")  --vi tri con trong\r\n"
                                                                        }));
                                                                        for (int n = 0; n < current13.ItemQuantity; n++)
                                                                        {
                                                                              streamWriter.Write(string.Concat(new object[]
                                                                              {
                                                                                    "                  AddItmeProp(UserWorldId,",
                                                                                    current13.ItemID.ToString(),
                                                                                    ",weiz",
                                                                                    current13.ItemID.ToString(),
                                                                                    "[",
                                                                                    n,
                                                                                    "],1,0,0,0,0,0,0,0,0,0)\r\n"
                                                                              }));
                                                                        }
                                                                        continue;
                                                                  case 800000005:
                                                                        streamWriter.Write("              --tang thuong\r\n");
                                                                        streamWriter.Write(string.Concat(new string[]
                                                                        {
                                                                              "              local weiz",
                                                                              current13.ItemID.ToString(),
                                                                              "=GetPackages(UserWorldId,",
                                                                              current13.ItemQuantity.ToString(),
                                                                              ")  --vi tri con trong\r\n"
                                                                        }));
                                                                        for (int num3 = 0; num3 < current13.ItemQuantity; num3++)
                                                                        {
                                                                              streamWriter.Write(string.Concat(new object[]
                                                                              {
                                                                                    "                  AddItmeProp(UserWorldId,",
                                                                                    current13.ItemID.ToString(),
                                                                                    ",weiz",
                                                                                    current13.ItemID.ToString(),
                                                                                    "[",
                                                                                    num3,
                                                                                    "],1,0,0,0,0,0,0,0,0,0)\r\n"
                                                                              }));
                                                                        }
                                                                        continue;
                                                                  default:
                                                                        switch (itemID)
                                                                        {
                                                                              case 800000023:
                                                                                    streamWriter.Write("              --tang thuong\r\n");
                                                                                    streamWriter.Write(string.Concat(new string[]
                                                                                    {
                                                                                    "              local weiz",
                                                                                    current13.ItemID.ToString(),
                                                                                    "=GetPackages(UserWorldId,",
                                                                                    current13.ItemQuantity.ToString(),
                                                                                    ")  --vi tri con trong\r\n"
                                                                                    }));
                                                                                    streamWriter.Write("                  local chiso=math.random(700015,700025) \r\n");
                                                                                    for (int num4 = 0; num4 < current13.ItemQuantity; num4++)
                                                                                    {
                                                                                          streamWriter.Write(string.Concat(new object[]
                                                                                          {
                                                                                          "                  AddItmeProp(UserWorldId,",
                                                                                          current13.ItemID.ToString(),
                                                                                          ",weiz",
                                                                                          current13.ItemID.ToString(),
                                                                                          "[",
                                                                                          num4,
                                                                                          "],1,chiso,0,0,0,0,0,0,0,0)\r\n"
                                                                                          }));
                                                                                    }
                                                                                    continue;
                                                                              case 800000024:
                                                                                    streamWriter.Write("              --tang thuong\r\n");
                                                                                    streamWriter.Write(string.Concat(new string[]
                                                                                    {
                                                                                    "              local weiz",
                                                                                    current13.ItemID.ToString(),
                                                                                    "=GetPackages(UserWorldId,",
                                                                                    current13.ItemQuantity.ToString(),
                                                                                    ")  --vi tri con trong\r\n"
                                                                                    }));
                                                                                    streamWriter.Write("                  local chiso=math.random(200005,2000015) \r\n");
                                                                                    for (int num5 = 0; num5 < current13.ItemQuantity; num5++)
                                                                                    {
                                                                                          streamWriter.Write(string.Concat(new object[]
                                                                                          {
                                                                                          "                  AddItmeProp(UserWorldId,",
                                                                                          current13.ItemID.ToString(),
                                                                                          ",weiz",
                                                                                          current13.ItemID.ToString(),
                                                                                          "[",
                                                                                          num5,
                                                                                          "],1,chiso,0,0,0,0,0,0,0,0)\r\n"
                                                                                          }));
                                                                                    }
                                                                                    continue;
                                                                              case 800000025:
                                                                                    streamWriter.Write("              --tang thuong\r\n");
                                                                                    streamWriter.Write(string.Concat(new string[]
                                                                                    {
                                                                                    "              local weiz",
                                                                                    current13.ItemID.ToString(),
                                                                                    "=GetPackages(UserWorldId,",
                                                                                    current13.ItemQuantity.ToString(),
                                                                                    ")  --vi tri con trong\r\n"
                                                                                    }));
                                                                                    streamWriter.Write("                  local chiso=math.random(1000012,1000018) \r\n");
                                                                                    for (int num6 = 0; num6 < current13.ItemQuantity; num6++)
                                                                                    {
                                                                                          streamWriter.Write(string.Concat(new object[]
                                                                                          {
                                                                                          "                  AddItmeProp(UserWorldId,",
                                                                                          current13.ItemID.ToString(),
                                                                                          ",weiz",
                                                                                          current13.ItemID.ToString(),
                                                                                          "[",
                                                                                          num6,
                                                                                          "],1,chiso,0,0,0,0,0,0,0,0)\r\n"
                                                                                          }));
                                                                                    }
                                                                                    continue;
                                                                              case 800000026:
                                                                                    streamWriter.Write("              --tang thuong\r\n");
                                                                                    streamWriter.Write(string.Concat(new string[]
                                                                                    {
                                                                                    "              local weiz",
                                                                                    current13.ItemID.ToString(),
                                                                                    "=GetPackages(UserWorldId,",
                                                                                    current13.ItemQuantity.ToString(),
                                                                                    ")  --vi tri con trong\r\n"
                                                                                    }));
                                                                                    streamWriter.Write("                  local chiso=math.random(700005,700015) \r\n");
                                                                                    for (int num7 = 0; num7 < current13.ItemQuantity; num7++)
                                                                                    {
                                                                                          streamWriter.Write(string.Concat(new object[]
                                                                                          {
                                                                                          "                  AddItmeProp(UserWorldId,",
                                                                                          current13.ItemID.ToString(),
                                                                                          ",weiz",
                                                                                          current13.ItemID.ToString(),
                                                                                          "[",
                                                                                          num7,
                                                                                          "],1,chiso,0,0,0,0,0,0,0,0)\r\n"
                                                                                          }));
                                                                                    }
                                                                                    continue;
                                                                              case 800000029:
                                                                                    streamWriter.Write("              --tang thuong\r\n");
                                                                                    streamWriter.Write(string.Concat(new string[]
                                                                                    {
                                                                                    "              local weiz",
                                                                                    current13.ItemID.ToString(),
                                                                                    "=GetPackages(UserWorldId,",
                                                                                    current13.ItemQuantity.ToString(),
                                                                                    ")  --vi tri con trong\r\n"
                                                                                    }));
                                                                                    for (int num8 = 0; num8 < current13.ItemQuantity; num8++)
                                                                                    {
                                                                                          streamWriter.Write(string.Concat(new object[]
                                                                                          {
                                                                                          "                  AddItmeProp(UserWorldId,",
                                                                                          current13.ItemID.ToString(),
                                                                                          ",weiz",
                                                                                          current13.ItemID.ToString(),
                                                                                          "[",
                                                                                          num8,
                                                                                          "],1,0,0,0,0,0,0,0,0,0)\r\n"
                                                                                          }));
                                                                                    }
                                                                                    continue;
                                                                        }
                                                                        break;
                                                            }
                                                      }
                                                }
                                                else
                                                {
                                                      if (itemID <= 1000000003)
                                                      {
                                                            switch (itemID)
                                                            {
                                                                  case 909000001:
                                                                        streamWriter.Write("                  AddExpToCharacter(UserWorldId," + current13.ItemQuantity.ToString() + ") \r\n");
                                                                        continue;
                                                                  case 909000002:
                                                                        streamWriter.Write("                  UpExp(UserWorldId," + current13.ItemQuantity.ToString() + ") \r\n");
                                                                        continue;
                                                                  case 909000003:
                                                                        streamWriter.Write("              --tang thuong\r\n");
                                                                        streamWriter.Write("              local weiz" + current13.ItemID.ToString() + "=GetPackage(UserWorldId)  --vi tri con trong\r\n");
                                                                        streamWriter.Write("                  if Player.Player_Job==1 then -- neu la DAO \r\n");
                                                                        streamWriter.Write("                  AddItmeProp(UserWorldId,100200007,weiz" + current13.ItemID.ToString() + ",1,0,0,0,0,0,0,0,0,0) \r\n");
                                                                        streamWriter.Write("                  elseif Player.Player_Job==2 then -- neu la KIEM \r\n");
                                                                        streamWriter.Write("                  AddItmeProp(UserWorldId,200200007,weiz" + current13.ItemID.ToString() + ",1,0,0,0,0,0,0,0,0,0) \r\n");
                                                                        streamWriter.Write("                  elseif Player.Player_Job==3 then -- neu la THUONG \r\n");
                                                                        streamWriter.Write("                  AddItmeProp(UserWorldId,300200007,weiz" + current13.ItemID.ToString() + ",1,0,0,0,0,0,0,0,0,0) \r\n");
                                                                        streamWriter.Write("                  elseif Player.Player_Job==4 then -- neu la CUNG \r\n");
                                                                        streamWriter.Write("                  AddItmeProp(UserWorldId,400200007,weiz" + current13.ItemID.ToString() + ",1,0,0,0,0,0,0,0,0,0) \r\n");
                                                                        streamWriter.Write("                  elseif Player.Player_Job==5 then -- neu la DAI PHU \r\n");
                                                                        streamWriter.Write("                  AddItmeProp(UserWorldId,500200007,weiz" + current13.ItemID.ToString() + ",1,0,0,0,0,0,0,0,0,0) \r\n");
                                                                        streamWriter.Write("                  elseif Player.Player_Job==6 then -- neu la THICH KHACH \r\n");
                                                                        streamWriter.Write("                  AddItmeProp(UserWorldId,700200007,weiz" + current13.ItemID.ToString() + ",1,0,0,0,0,0,0,0,0,0) \r\n");
                                                                        streamWriter.Write("                  end \r\n");
                                                                        continue;
                                                                  case 909000004:
                                                                        streamWriter.Write("                  AddMoneyToCharacter(UserWorldId," + current13.ItemQuantity.ToString() + ") \r\n");
                                                                        streamWriter.Write("                  SendSysMsg(UserWorldId,\"Nhan duoc " + current13.ItemQuantity.ToString() + " tien vang!\", 9, \"He thong\")\r\n");
                                                                        continue;
                                                                  default:
                                                                        switch (itemID)
                                                                        {
                                                                              case 1000000001:
                                                                                    streamWriter.Write("              --tang thuong\r\n");
                                                                                    streamWriter.Write(string.Concat(new string[]
                                                                                    {
                                                                                    "              local weiz",
                                                                                    current13.ItemID.ToString(),
                                                                                    "=GetPackages(UserWorldId,",
                                                                                    current13.ItemQuantity.ToString(),
                                                                                    ")  --vi tri con trong\r\n"
                                                                                    }));
                                                                                    for (int num9 = 0; num9 < current13.ItemQuantity; num9++)
                                                                                    {
                                                                                          streamWriter.Write(string.Concat(new object[]
                                                                                          {
                                                                                          "                  AddItmeProp(UserWorldId,",
                                                                                          current13.ItemID.ToString(),
                                                                                          ",weiz",
                                                                                          current13.ItemID.ToString(),
                                                                                          "[",
                                                                                          num9,
                                                                                          "],1,0,0,0,0,0,0,0,0,0)\r\n"
                                                                                          }));
                                                                                    }
                                                                                    continue;
                                                                              case 1000000002:
                                                                                    streamWriter.Write("              --tang thuong\r\n");
                                                                                    streamWriter.Write(string.Concat(new string[]
                                                                                    {
                                                                                    "              local weiz",
                                                                                    current13.ItemID.ToString(),
                                                                                    "=GetPackages(UserWorldId,",
                                                                                    current13.ItemQuantity.ToString(),
                                                                                    ")  --vi tri con trong\r\n"
                                                                                    }));
                                                                                    for (int num10 = 0; num10 < current13.ItemQuantity; num10++)
                                                                                    {
                                                                                          streamWriter.Write(string.Concat(new object[]
                                                                                          {
                                                                                          "                  AddItmeProp(UserWorldId,",
                                                                                          current13.ItemID.ToString(),
                                                                                          ",weiz",
                                                                                          current13.ItemID.ToString(),
                                                                                          "[",
                                                                                          num10,
                                                                                          "],1,0,0,0,0,0,0,0,0,0)\r\n"
                                                                                          }));
                                                                                    }
                                                                                    continue;
                                                                              case 1000000003:
                                                                                    streamWriter.Write("              --tang thuong\r\n");
                                                                                    streamWriter.Write(string.Concat(new string[]
                                                                                    {
                                                                                    "              local weiz",
                                                                                    current13.ItemID.ToString(),
                                                                                    "=GetPackages(UserWorldId,",
                                                                                    current13.ItemQuantity.ToString(),
                                                                                    ")  --vi tri con trong\r\n"
                                                                                    }));
                                                                                    for (int num11 = 0; num11 < current13.ItemQuantity; num11++)
                                                                                    {
                                                                                          streamWriter.Write(string.Concat(new object[]
                                                                                          {
                                                                                          "                  AddItmeProp(UserWorldId,",
                                                                                          current13.ItemID.ToString(),
                                                                                          ",weiz",
                                                                                          current13.ItemID.ToString(),
                                                                                          "[",
                                                                                          num11,
                                                                                          "],1,0,0,0,0,0,0,0,0,0)\r\n"
                                                                                          }));
                                                                                    }
                                                                                    continue;
                                                                        }
                                                                        break;
                                                            }
                                                      }
                                                      else
                                                      {
                                                            if (itemID == 1000000008)
                                                            {
                                                                  streamWriter.Write("              --tang thuong\r\n");
                                                                  streamWriter.Write(string.Concat(new string[]
                                                                  {
                                                                              "              local weiz",
                                                                              current13.ItemID.ToString(),
                                                                              "=GetPackages(UserWorldId,",
                                                                              current13.ItemQuantity.ToString(),
                                                                              ")  --vi tri con trong\r\n"
                                                                  }));
                                                                  for (int num12 = 0; num12 < current13.ItemQuantity; num12++)
                                                                  {
                                                                        streamWriter.Write(string.Concat(new object[]
                                                                        {
                                                                                    "                  AddItmeProp(UserWorldId,",
                                                                                    current13.ItemID.ToString(),
                                                                                    ",weiz",
                                                                                    current13.ItemID.ToString(),
                                                                                    "[",
                                                                                    num12,
                                                                                    "],1,0,0,0,0,0,0,0,0,0)\r\n"
                                                                        }));
                                                                  }
                                                                  continue;
                                                            }
                                                            if (itemID == 1000000026)
                                                            {
                                                                  streamWriter.Write("              --tang thuong\r\n");
                                                                  streamWriter.Write(string.Concat(new string[]
                                                                  {
                                                                              "              local weiz",
                                                                              current13.ItemID.ToString(),
                                                                              "=GetPackages(UserWorldId,",
                                                                              current13.ItemQuantity.ToString(),
                                                                              ")  --vi tri con trong\r\n"
                                                                  }));
                                                                  for (int num13 = 0; num13 < current13.ItemQuantity; num13++)
                                                                  {
                                                                        streamWriter.Write(string.Concat(new object[]
                                                                        {
                                                                                    "                  AddItmeProp(UserWorldId,",
                                                                                    current13.ItemID.ToString(),
                                                                                    ",weiz",
                                                                                    current13.ItemID.ToString(),
                                                                                    "[",
                                                                                    num13,
                                                                                    "],1,0,0,0,0,0,0,0,0,0)\r\n"
                                                                        }));
                                                                  }
                                                                  continue;
                                                            }
                                                            switch (itemID)
                                                            {
                                                                  case 1000000250:
                                                                        streamWriter.Write("              --tang thuong\r\n");
                                                                        streamWriter.Write(string.Concat(new string[]
                                                                        {
                                                                              "              local weiz",
                                                                              current13.ItemID.ToString(),
                                                                              "=GetPackages(UserWorldId,",
                                                                              current13.ItemQuantity.ToString(),
                                                                              ")  --vi tri con trong\r\n"
                                                                        }));
                                                                        for (int num14 = 0; num14 < current13.ItemQuantity; num14++)
                                                                        {
                                                                              streamWriter.Write(string.Concat(new object[]
                                                                              {
                                                                                    "                  AddItmeProp(UserWorldId,",
                                                                                    current13.ItemID.ToString(),
                                                                                    ",weiz",
                                                                                    current13.ItemID.ToString(),
                                                                                    "[",
                                                                                    num14,
                                                                                    "],1,0,0,0,0,0,0,0,0,0)\r\n"
                                                                              }));
                                                                        }
                                                                        continue;
                                                                  case 1000000251:
                                                                        streamWriter.Write("              --tang thuong\r\n");
                                                                        streamWriter.Write(string.Concat(new string[]
                                                                        {
                                                                              "              local weiz",
                                                                              current13.ItemID.ToString(),
                                                                              "=GetPackages(UserWorldId,",
                                                                              current13.ItemQuantity.ToString(),
                                                                              ")  --vi tri con trong\r\n"
                                                                        }));
                                                                        for (int num15 = 0; num15 < current13.ItemQuantity; num15++)
                                                                        {
                                                                              streamWriter.Write(string.Concat(new object[]
                                                                              {
                                                                                    "                  AddItmeProp(UserWorldId,",
                                                                                    current13.ItemID.ToString(),
                                                                                    ",weiz",
                                                                                    current13.ItemID.ToString(),
                                                                                    "[",
                                                                                    num15,
                                                                                    "],1,0,0,0,0,0,0,0,0,0)\r\n"
                                                                              }));
                                                                        }
                                                                        continue;
                                                            }
                                                      }
                                                }
                                                if (current13.ItemID < 1000000000 && current13.ItemID > 900000000)
                                                {
                                                      streamWriter.Write(string.Concat(new string[]
                                                      {
                                                                  "              AddQuestItme(UserWorldId,",
                                                                  current13.ItemID.ToString(),
                                                                  ",",
                                                                  current13.ItemQuantity.ToString(),
                                                                  ") --them vat pham cho nhiem vu khac\r\n"
                                                      }));
                                                }
                                                else
                                                {
                                                      streamWriter.Write("              --tang thuong\r\n");
                                                      streamWriter.Write("              local weiz" + current13.ItemID.ToString() + "=GetPackage(UserWorldId)  --vi tri con trong\r\n");
                                                      streamWriter.Write(string.Concat(new string[]
                                                      {
                                                                  "                  AddItme(UserWorldId,",
                                                                  current13.ItemID.ToString(),
                                                                  ",weiz",
                                                                  current13.ItemID.ToString(),
                                                                  ",",
                                                                  current13.ItemQuantity.ToString(),
                                                                  ") \r\n"
                                                      }));
                                                }
                                          }
                                    }
                                    streamWriter.Write("        end \r\n");
                                    streamWriter.Write("              SendSysMsg(UserWorldId,\"Chuc mung ban da hoan thanh nhiem vu !!!\",10,\"Chu Y\") \r\n");
                                    streamWriter.Write("      end\r\n");
                                    streamWriter.Write("      SendMissionMsg(UserWorldId,QuestId, 51, StatusQuest)\r\n");
                                    streamWriter.Write("  end\r\n");
                                    streamWriter.Write("end\r\n");
                              }
                        }
                        if (OneSave)
                        {
                              MessageBox.Show("[" + class2.QuestID.ToString() + " : " + class2.QuestName + "] 퀘스트 저장 완료!!");
                        }
                  }
            }

            public void UpdateStatusBar(string status)
            {
                  if (this.InvokeRequired)
                  {
                        this.BeginInvoke((MethodInvoker)delegate
                        {
                              UpdateStatusBar(status);
                        });
                  }
                  else
                  {
                        this.toolStripStatusLabel1.Text = status;
                  }

                  
            }

            delegate void ToolStripPrograssDelegate(int value);
            private void ToolStripPrograss(int value)
            {
                  if (this.InvokeRequired)
                  {
                        ToolStripPrograssDelegate del = new ToolStripPrograssDelegate(ToolStripPrograss);
                        this.Invoke(del, new object[] { value });
                  }
                  else
                  {
                        toolStripProgressBar1.Value = value; 
                  }

                  
            }

            private void ToolStripPrograssMax(int value)
            {
                  if (this.InvokeRequired)
                  {
                        ToolStripPrograssDelegate del = new ToolStripPrograssDelegate(ToolStripPrograss);
                        this.Invoke(del, new object[] { value });
                  }
                  else
                  {
                        toolStripProgressBar1.Maximum = value;

                  }
                  
            }

            private void OpenFileYbqcfgToolStripMenuItem_Click(object sender, EventArgs e)
            {
                  try
                  {
                        OpenFileDialog str = new OpenFileDialog()
                        {
                              Filter = "cfg files (*.cfg)|ybq.cfg|All files (*.*)|*.*",
                              FilterIndex = 1,
                              RestoreDirectory = true
                        };
                        if (str.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                              toolStripProgressBar1.Visible = true;
                              this.dictionary_0.Clear();
                              this.listView.Items.Clear();
                              Task WebConn = Task.Factory.StartNew(() =>
                              {
                                    using (FileStream dst = new FileStream(str.FileName, FileMode.Open, FileAccess.Read, FileShare.Read))
                                    {
                                          using (BinaryReader binaryReader = new BinaryReader(dst))
                                          {
                                                MemoryStream memoryStream = new MemoryStream();
                                                byte[] numArray = new byte[checked(binaryReader.BaseStream.Length)];
                                                UpdateStatusBar("파일 로딩중...");
                                                //ToolStripPrograssMax((int)numArray.Length);
                                                while (binaryReader.Read(numArray, 0, (int)numArray.Length) > 0)
                                                {
                                                      int num = 0;
                                                      this.string_0 = this.method_2(numArray, ref num);
                                                      this.string_1 = this.method_2(numArray, ref num);
                                                      this.method_0(numArray, ref num);
                                                      for (int i = num; (long)i < (long)numArray.Length; i++)
                                                      {
                                                            if ((long)(i + 1) >= (long)numArray.Length)
                                                            {
                                                                  memoryStream.WriteByte(this.byte_0[numArray[i]]);
                                                            }
                                                            else if (numArray[i] != 13 || numArray[i + 1] != 10)
                                                            {
                                                                  memoryStream.WriteByte(this.byte_0[numArray[i]]);
                                                            }
                                                            else
                                                            {
                                                                  Console.WriteLine(i);
                                                            }
                                                            //UpdateStatusBar(string.Format("파일 로딩중...{0}/{1}",i, numArray.Length));
                                                      }
                                                      
                                                }
                                                byte[] array = memoryStream.ToArray();
                                                int num1 = 0;
                                                //ToolStripPrograss(0);
                                                //ToolStripPrograssMax((int)array.Length);
                                                UpdateStatusBar("QUEST 로딩중...");
                                                while (num1 < (int)array.Length)
                                                {
                                                      try
                                                      {
                                                            QUEST_CLASS qUESTCLAss = new QUEST_CLASS()
                                                            {
                                                                  QuestID = this.method_0(array, ref num1)
                                                            };
                                                            if (qUESTCLAss.QuestID == 0 || qUESTCLAss.QuestID == 232 || qUESTCLAss.QuestID == 242)
                                                            {
                                                                  Console.WriteLine(qUESTCLAss.QuestID);
                                                                  num1++;
                                                            }
                                                            else
                                                            {
                                                                  qUESTCLAss.QuestName = this.method_1(array, ref num1);
                                                                  qUESTCLAss.QuestLevel = this.method_0(array, ref num1);
                                                                  qUESTCLAss.Missionunknown1 = this.method_0(array, ref num1);
                                                                  qUESTCLAss.Missionunknown2 = this.method_0(array, ref num1);
                                                                  qUESTCLAss.Missionunknown3 = this.method_0(array, ref num1);
                                                                  qUESTCLAss.Missionunknown4 = this.method_0(array, ref num1);
                                                                  qUESTCLAss.Missionunknown5 = this.method_0(array, ref num1);
                                                                  qUESTCLAss.Missionunknown6 = this.method_0(array, ref num1);
                                                                  qUESTCLAss.Missionunknown7 = this.method_0(array, ref num1);
                                                                  qUESTCLAss.QuestAccept1 = this.method_1(array, ref num1);
                                                                  qUESTCLAss.QuestRefuse1 = this.method_1(array, ref num1);
                                                                  qUESTCLAss.QuestAccept2 = this.method_1(array, ref num1);
                                                                  qUESTCLAss.QuestRefuse2 = this.method_1(array, ref num1);
                                                                  int num2 = this.method_0(array, ref num1);
                                                                  for (int j = 0; j < num2; j++)
                                                                  {
                                                                        QuestItems_Category questItemsCategory = new QuestItems_Category()
                                                                        {
                                                                              ItemID = this.method_0(array, ref num1),
                                                                              ItemQuantity = this.method_0(array, ref num1)
                                                                        };
                                                                        qUESTCLAss.RewardItems.Add(questItemsCategory);
                                                                        
                                                                  }
                                                                  qUESTCLAss.QuestStageNumber = this.method_0(array, ref num1);
                                                                  if (qUESTCLAss.QuestStageNumber > 0)
                                                                  {
                                                                        qUESTCLAss.NpcID = this.method_0(array, ref num1);
                                                                        qUESTCLAss.NPCCord = this.method_0(array, ref num1);
                                                                        qUESTCLAss.NpcCords.MapID = this.method_0(array, ref num1);
                                                                        qUESTCLAss.NpcCords.CoordX = this.method_0(array, ref num1);
                                                                        qUESTCLAss.NpcCords.CoordY = this.method_0(array, ref num1);
                                                                        int num3 = this.method_0(array, ref num1);
                                                                        for (int k = 0; k < num3; k++)
                                                                        {
                                                                              TaskRequiresItem_Category taskRequiresItemCategory = new TaskRequiresItem_Category()
                                                                              {
                                                                                    ItemID = this.method_0(array, ref num1),
                                                                                    ItemQuantity = this.method_0(array, ref num1),
                                                                                    MapID = this.method_0(array, ref num1),
                                                                                    CoordX = this.method_0(array, ref num1),
                                                                                    CoordY = this.method_0(array, ref num1)
                                                                              };
                                                                              qUESTCLAss.NeededItem.Add(taskRequiresItemCategory);
                                                                        }
                                                                        qUESTCLAss.AssignmentReception1 = this.method_1(array, ref num1);
                                                                        qUESTCLAss.AssignmentReception2 = this.method_1(array, ref num1);
                                                                        qUESTCLAss.AssignmentReception3 = this.method_1(array, ref num1);
                                                                        qUESTCLAss.AssignmentReception4 = this.method_1(array, ref num1);
                                                                        qUESTCLAss.AssignmentReception5 = this.method_1(array, ref num1);
                                                                        qUESTCLAss.Missionpresent1 = this.method_1(array, ref num1);
                                                                        qUESTCLAss.Missionpresent2 = this.method_1(array, ref num1);
                                                                        qUESTCLAss.Missionpresent3 = this.method_1(array, ref num1);
                                                                        qUESTCLAss.Missionpresent4 = this.method_1(array, ref num1);
                                                                        qUESTCLAss.Missionpresent5 = this.method_1(array, ref num1);
                                                                        for (int l = 0; l < qUESTCLAss.QuestStageNumber - 1; l++)
                                                                        {
                                                                              NPC_CLASS nPCCLAss = new NPC_CLASS()
                                                                              {
                                                                                    StageText = this.method_1(array, ref num1),
                                                                                    NpcID = this.method_0(array, ref num1),
                                                                                    NpcCoords = this.method_0(array, ref num1),
                                                                                    NpcMapID = this.method_0(array, ref num1),
                                                                                    NpcCoordX = this.method_0(array, ref num1),
                                                                                    NpcCoordY = this.method_0(array, ref num1)
                                                                              };
                                                                              int num4 = this.method_0(array, ref num1);
                                                                              for (int m = 0; m < num4; m++)
                                                                              {
                                                                                    TaskRequiresItem_Category taskRequiresItemCategory1 = new TaskRequiresItem_Category()
                                                                                    {
                                                                                          ItemID = this.method_0(array, ref num1),
                                                                                          ItemQuantity = this.method_0(array, ref num1),
                                                                                          MapID = this.method_0(array, ref num1),
                                                                                          CoordX = this.method_0(array, ref num1),
                                                                                          CoordY = this.method_0(array, ref num1)
                                                                                    };
                                                                                    nPCCLAss.NeededItem.Add(taskRequiresItemCategory1);
                                                                              }
                                                                              nPCCLAss.RequirementsMet = this.method_1(array, ref num1);
                                                                              nPCCLAss.string_2 = this.method_1(array, ref num1);
                                                                              nPCCLAss.string_3 = this.method_1(array, ref num1);
                                                                              nPCCLAss.string_4 = this.method_1(array, ref num1);
                                                                              nPCCLAss.string_5 = this.method_1(array, ref num1);
                                                                              nPCCLAss.RequirementsNotMet = this.method_1(array, ref num1);
                                                                              nPCCLAss.string_7 = this.method_1(array, ref num1);
                                                                              nPCCLAss.string_8 = this.method_1(array, ref num1);
                                                                              nPCCLAss.string_9 = this.method_1(array, ref num1);
                                                                              nPCCLAss.string_10 = this.method_1(array, ref num1);
                                                                              qUESTCLAss.QuestStage.Add(nPCCLAss);
                                                                        }
                                                                        int num5 = this.method_0(array, ref num1);
                                                                        if (num5 > 0)
                                                                        {
                                                                              Console.WriteLine(num5);
                                                                        }
                                                                        num1++;
                                                                  }
                                                                  this.dictionary_0.Add(qUESTCLAss.QuestID, qUESTCLAss);

                                                            }
                                                      }
                                                      catch
                                                      {
                                                      }
                                                      //UpdateStatusBar(string.Format("파일 로딩중...{0}/{1}", num1, array.Length));
                                                }
                                                this.c();
                                          }
                                    }
                              });
                        }
                  }
                  catch (Exception exception)
                  {
                  }
            }
           
            private void listView_SelectedIndexChanged(object sender, EventArgs e)
            {
                  
                 
                  if (this.listView.SelectedItems.Count > 0)
                  {     
                        string text = this.listView.SelectedItems[0].SubItems[0].Text;
                        QUEST_CLASS qUESTCLAss = new QUEST_CLASS();
                        if (this.dictionary_0.TryGetValue(int.Parse(text), out qUESTCLAss))
                        {
                              CustomPropertyCollection customPropertyCollection = new CustomPropertyCollection
                              {
                                    new CustomProperty("코드", "QuestID", true, "Basic", "Quest ID", qUESTCLAss),
                                    new CustomProperty("제목", "QuestName", false, "Basic", "Quest Name", qUESTCLAss),
                                    new CustomProperty("레벨", "QuestLevel", false, "Basic", "Quest Level", qUESTCLAss),
                                    new CustomProperty("거절 메세지1", "QuestRefuse1", false, "Basic", "Quest Refuse1", qUESTCLAss, typeof(MultilineStringEditor)),
                                    new CustomProperty("거절 메세지2", "QuestRefuse2", false, "Basic", "Quest Refuse2", qUESTCLAss, typeof(MultilineStringEditor)),
                                    new CustomProperty("승인 메세지1", "QuestAccept1", false, "Basic", "Quest Accept1", qUESTCLAss, typeof(MultilineStringEditor)),
                                    new CustomProperty("승인 메세지2", "QuestAccept2", false, "Basic", "Quest Accept2", qUESTCLAss, typeof(MultilineStringEditor)),
                                    new CustomProperty("NPC ID", "NpcID", false, "Npc", "Npc ID", qUESTCLAss),
                                    new CustomProperty("엔피시 설정", "NpcCords", false, "Npc", "Npc Coords", qUESTCLAss, true),
                                    new CustomProperty("보상 아이템 목록", "RewardItems", false, "RewardItems", "Reward Items", qUESTCLAss, typeof(My_Need_Items_CollectionEditor)),
                                    new CustomProperty("요구 아이템 목록", "NeededItem", false, "NeededItem", "Needed Item", qUESTCLAss, typeof(MyRewardItemsCollectionEditor)),
                                    new CustomProperty("미완료 메세지", "Missionpresent1", false, "QuestContent", "Mission present1", qUESTCLAss, typeof(MultilineStringEditor)),
                                    new CustomProperty("완료 메세지", "AssignmentReception1", false, "QuestContent", "Assignment Reception1", qUESTCLAss, typeof(MultilineStringEditor)),
                                    new CustomProperty("QuestStageNumber", "QuestStageNumber", false, "QuestStageNumber", "QuestStageNumber=QuestStageNumber+1", qUESTCLAss),
                                    new CustomProperty("QuestStage", "QuestStage", false, "QuestStage", "Quest Stage", qUESTCLAss, typeof(MyQuestStageCollectionEditor))
                              };
                              this.propertyGrid1.SelectedObject = customPropertyCollection;
                        }
                  }
                  
            }

            private void 모두저장ToolStripMenuItem_Click(object sender, EventArgs e)
            {

            }

            private void deleteQuestToolStripMenuItem_Click(object sender, EventArgs e)
            {

            }

            private void SaveQuestOneToolStripMenuItem_Click(object sender, EventArgs e)
            {
                  OneSave = true;
                  SaveQuest(this.listView.SelectedItems[0].Index);                  
                  //SaveQuestNew(this.listView.SelectedItems[0].Index);
            }

            private void 퀘스트모두저장ToolStripMenuItem_Click(object sender, EventArgs e)
            {
                  SaveAll();
            }

            private void listView_MouseClick(object sender, MouseEventArgs e)
            {
                  if (e.Button == MouseButtons.Right && this.listView.SelectedItems.Count > 0)
                  {
                        this.contextMenuStrip1.Show(Control.MousePosition.X, Control.MousePosition.Y);
                  }
            }
      }
}
