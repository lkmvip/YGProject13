using ns1;
using ns12;
using ns2;
using ns4;
using ns5;
using ns8;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace ns10
{
      internal class YbQForm: Form
      {
            private byte[] byte_0 = new byte[256];

            private ColumnHeader columnHeader_0;

            private ColumnHeader columnHeader_1;

            private ColumnHeader columnHeader_2;

            private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

            private ToolStripMenuItem deleteQuestToolStripMenuItem;

            private ToolStripMenuItem deleteToolStripMenuItem;

            private Dictionary<int, QUEST_CLASS> dictionary_0 = new Dictionary<int, QUEST_CLASS>();

            private IContainer icontainer_0;

            private ListView listView;

            private MenuStrip menuStrip1;

            private PropertyGrid propertyGrid1;

            private ToolStripMenuItem reloadRefreshToolStripMenuItem;

            private SplitContainer splitContainer1;

            private StatusStrip statusStrip1;

            private string string_0 = "";

            private string string_1 = "";

            private string string_2 = "";

            private ToolStripMenuItem temporaryToolStripMenuItem;

            private ToolStripStatusLabel toolStripStatusLabel1;

            private ToolStripMenuItem 保存YbqcfgToolStripMenuItem;

            private ToolStripMenuItem 打开YbqcfgToolStripMenuItem;

            private IContainer components;

            private ToolStripMenuItem 文件ToolStripMenuItem;

            public YbQForm()
            {
                  this.InitializeComponent();
                  int num = 0;
                  do
                  {
                        this.byte_0[num] = (byte)(num >> 4 & 1 | num >> 2 & 24 | num >> 1 & 64 | 2 * (num & 3 | 4 * (num & 4 | 2 * (num & 248))));
                        num++;
                  }
                  while (num < 256);
            }

            private void a(FileStream fileStream_0, string string_3)
            {
                  byte[] numArray = this.method_3(Encoding.Default.GetBytes(string_3));
                  this.method_5(fileStream_0, (int)numArray.Length);
                  fileStream_0.Write(numArray, 0, (int)numArray.Length);
                  fileStream_0.WriteByte(this.method_4(32));
            }

            private void b(object sender, EventArgs e)
            {
                  try
                  {
                        OpenFileDialog openFileDialog = new OpenFileDialog()
                        {
                              Filter = "cfg files (*.cfg)|*.cfg|All files (*.*)|*.*",
                              FilterIndex = 1,
                              RestoreDirectory = true
                        };
                        if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                              this.dictionary_0.Clear();
                              this.listView.Items.Clear();
                              using (FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read, FileShare.Read))
                              {
                                    using (BinaryReader binaryReader = new BinaryReader(fileStream))
                                    {
                                          MemoryStream memoryStream = new MemoryStream();
                                          byte[] numArray = new byte[binaryReader.BaseStream.Length];
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
                                                }
                                          }
                                          byte[] array = memoryStream.ToArray();
                                          int num1 = 0;
                                          while (num1 < (int)array.Length)
                                          {
                                                try
                                                {
                                                      QUEST_CLASS qUESTCLAss = new QUEST_CLASS()
                                                      {
                                                            NHIEM_VU_ID = this.method_0(array, ref num1)
                                                      };
                                                      if (qUESTCLAss.NHIEM_VU_ID == 0 || qUESTCLAss.NHIEM_VU_ID == 232 || qUESTCLAss.NHIEM_VU_ID == 242)
                                                      {
                                                            Console.WriteLine(qUESTCLAss.NHIEM_VU_ID);
                                                            num1++;
                                                      }
                                                      else
                                                      {
                                                            qUESTCLAss.NHIEM_VU_TEN = this.method_1(array, ref num1);
                                                            qUESTCLAss.NHIEM_VU_THU_BAC = this.method_0(array, ref num1);
                                                            qUESTCLAss.int_4 = this.method_0(array, ref num1);
                                                            qUESTCLAss.int_5 = this.method_0(array, ref num1);
                                                            qUESTCLAss.int_6 = this.method_0(array, ref num1);
                                                            qUESTCLAss.int_7 = this.method_0(array, ref num1);
                                                            qUESTCLAss.int_8 = this.method_0(array, ref num1);
                                                            qUESTCLAss.int_9 = this.method_0(array, ref num1);
                                                            qUESTCLAss.int_10 = this.method_0(array, ref num1);
                                                            qUESTCLAss.NHIEM_VU_TIEP_THU_NHAC_NHO_1 = this.method_1(array, ref num1);
                                                            qUESTCLAss.NHIEM_VU_TU_CHOI_NHAC_NHO_1 = this.method_1(array, ref num1);
                                                            qUESTCLAss.NHIEM_VU_TIEP_THU_NHAC_NHO_2 = this.method_1(array, ref num1);
                                                            qUESTCLAss.NHIEM_VU_TU_CHOI_NHAC_NHO_2 = this.method_1(array, ref num1);
                                                            int num2 = this.method_0(array, ref num1);
                                                            for (int j = 0; j < num2; j++)
                                                            {
                                                                  QuestItems_Category questItemsCategory = new QuestItems_Category()
                                                                  {
                                                                        ItemID = this.method_0(array, ref num1),
                                                                        ItemQuantity = this.method_0(array, ref num1)
                                                                  };
                                                                  qUESTCLAss.KHEN_THUONG_ITEM.Add(questItemsCategory);
                                                            }
                                                            qUESTCLAss.NHIEM_VU_GIAI_DOAN_SO_LUONG = this.method_0(array, ref num1);
                                                            if (qUESTCLAss.NHIEM_VU_GIAI_DOAN_SO_LUONG > 0)
                                                            {
                                                                  qUESTCLAss.NpcID = this.method_0(array, ref num1);
                                                                  qUESTCLAss.int_11 = this.method_0(array, ref num1);
                                                                  qUESTCLAss.NPC_TOA_DO.MapID = this.method_0(array, ref num1);
                                                                  qUESTCLAss.NPC_TOA_DO.CoordX = this.method_0(array, ref num1);
                                                                  qUESTCLAss.NPC_TOA_DO.CoordY = this.method_0(array, ref num1);
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
                                                                  qUESTCLAss.NHIEM_VU_HOAN_NGHENH_TIEP_THU_NHAC_NHO_1 = this.method_1(array, ref num1);
                                                                  qUESTCLAss.string_11 = this.method_1(array, ref num1);
                                                                  qUESTCLAss.string_12 = this.method_1(array, ref num1);
                                                                  qUESTCLAss.string_13 = this.method_1(array, ref num1);
                                                                  qUESTCLAss.string_14 = this.method_1(array, ref num1);
                                                                  qUESTCLAss.NHIEM_VU_HOAN_NGHENH_TU_CHOI_NHAC_NHO_1 = this.method_1(array, ref num1);
                                                                  qUESTCLAss.string_7 = this.method_1(array, ref num1);
                                                                  qUESTCLAss.string_8 = this.method_1(array, ref num1);
                                                                  qUESTCLAss.string_9 = this.method_1(array, ref num1);
                                                                  qUESTCLAss.string_10 = this.method_1(array, ref num1);
                                                                  for (int l = 0; l < qUESTCLAss.NHIEM_VU_GIAI_DOAN_SO_LUONG - 1; l++)
                                                                  {
                                                                        NPC_CLASS nPCCLAss = new NPC_CLASS()
                                                                        {
                                                                              StageText = this.method_1(array, ref num1),
                                                                              NpcID = this.method_0(array, ref num1),
                                                                              int_4 = this.method_0(array, ref num1),
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
                                                                        qUESTCLAss.NHIEM_VU_GIAI_DOAN.Add(nPCCLAss);
                                                                  }
                                                                  int num5 = this.method_0(array, ref num1);
                                                                  if (num5 > 0)
                                                                  {
                                                                        Console.WriteLine(num5);
                                                                  }
                                                                  num1++;
                                                            }
                                                            this.dictionary_0.Add(qUESTCLAss.NHIEM_VU_ID, qUESTCLAss);
                                                      }
                                                }
                                                catch
                                                {
                                                }
                                          }
                                          this.c();
                                    }
                              }
                        }
                  }
                  catch (Exception exception)
                  {
                  }
            }

            private void c()
            {
                  this.dictionary_0 = (
                        from keyValuePair_0 in this.dictionary_0
                        orderby keyValuePair_0.Key
                        select keyValuePair_0).ToDictionary<KeyValuePair<int, QUEST_CLASS>, int, QUEST_CLASS>((KeyValuePair<int, QUEST_CLASS> keyValuePair_0) => keyValuePair_0.Key, (KeyValuePair<int, QUEST_CLASS> keyValuePair_0) => keyValuePair_0.Value);
                  this.listView.Items.Clear();
                  foreach (QUEST_CLASS value in this.dictionary_0.Values)
                  {
                        string[] str = new string[3];
                        int nHIEMVUID = value.NHIEM_VU_ID;
                        str[0] = nHIEMVUID.ToString();
                        str[1] = value.NHIEM_VU_TEN;
                        nHIEMVUID = value.NHIEM_VU_THU_BAC;
                        str[2] = nHIEMVUID.ToString();
                        string[] strArrays = str;
                        this.listView.Items.Insert(this.listView.Items.Count, new ListViewItem(strArrays));
                  }
                  this.toolStripStatusLabel1.Text = string.Concat("Loaded Quests:", this.dictionary_0.Count);
            }

            private void d(object sender, EventArgs e)
            {
                  try
                  {
                        SaveFileDialog saveFileDialog = new SaveFileDialog()
                        {
                              Filter = "cfg files (*.cfg)|*.cfg|All files (*.*)|*.*",
                              FilterIndex = 1,
                              RestoreDirectory = true
                        };
                        if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                              using (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write, FileShare.Read))
                              {
                                    byte[] bytes = Encoding.Default.GetBytes(this.string_0);
                                    byte[] numArray = Encoding.Default.GetBytes(this.string_1);
                                    Encoding @default = Encoding.Default;
                                    int count = this.dictionary_0.Count;
                                    byte[] bytes1 = @default.GetBytes(count.ToString());
                                    fileStream.Write(bytes, 0, (int)bytes.Length);
                                    fileStream.WriteByte(32);
                                    fileStream.Write(numArray, 0, (int)numArray.Length);
                                    fileStream.WriteByte(10);
                                    fileStream.Write(bytes1, 0, (int)bytes1.Length);
                                    fileStream.WriteByte(32);
                                    foreach (QUEST_CLASS value in this.dictionary_0.Values)
                                    {
                                          this.method_5(fileStream, value.NHIEM_VU_ID);
                                          this.a(fileStream, value.NHIEM_VU_TEN);
                                          this.method_5(fileStream, value.NHIEM_VU_THU_BAC);
                                          this.method_5(fileStream, value.int_4);
                                          this.method_5(fileStream, value.int_5);
                                          this.method_5(fileStream, value.int_6);
                                          this.method_5(fileStream, value.int_7);
                                          this.method_5(fileStream, value.int_8);
                                          this.method_5(fileStream, value.int_9);
                                          this.method_5(fileStream, value.int_10);
                                          this.a(fileStream, value.NHIEM_VU_TIEP_THU_NHAC_NHO_1);
                                          this.a(fileStream, value.NHIEM_VU_TU_CHOI_NHAC_NHO_1);
                                          this.a(fileStream, value.NHIEM_VU_TIEP_THU_NHAC_NHO_2);
                                          this.a(fileStream, value.NHIEM_VU_TU_CHOI_NHAC_NHO_2);
                                          this.method_5(fileStream, value.KHEN_THUONG_ITEM.Count);
                                          if (value.KHEN_THUONG_ITEM.Count > 0)
                                          {
                                                foreach (QuestItems_Category kHENTHUONGITEM in value.KHEN_THUONG_ITEM)
                                                {
                                                      this.method_5(fileStream, kHENTHUONGITEM.ItemID);
                                                      this.method_5(fileStream, kHENTHUONGITEM.ItemQuantity);
                                                }
                                          }
                                          if (value.NHIEM_VU_GIAI_DOAN_SO_LUONG <= 0)
                                          {
                                                Encoding encoding = Encoding.Default;
                                                count = value.NHIEM_VU_GIAI_DOAN.Count;
                                                byte[] numArray1 = this.method_3(encoding.GetBytes(count.ToString()));
                                                fileStream.Write(numArray1, 0, (int)numArray1.Length);
                                                fileStream.WriteByte(this.method_4(10));
                                          }
                                          else
                                          {
                                                this.method_5(fileStream, value.NHIEM_VU_GIAI_DOAN.Count + 1);
                                                this.method_5(fileStream, value.NpcID);
                                                this.method_5(fileStream, value.int_11);
                                                this.method_5(fileStream, value.NPC_TOA_DO.MapID);
                                                this.method_5(fileStream, value.NPC_TOA_DO.CoordX);
                                                this.method_5(fileStream, value.NPC_TOA_DO.CoordY);
                                                this.method_5(fileStream, value.NeededItem.Count);
                                                if (value.NeededItem.Count > 0)
                                                {
                                                      foreach (TaskRequiresItem_Category neededItem in value.NeededItem)
                                                      {
                                                            this.method_5(fileStream, neededItem.ItemID);
                                                            this.method_5(fileStream, neededItem.ItemQuantity);
                                                            this.method_5(fileStream, neededItem.MapID);
                                                            this.method_5(fileStream, neededItem.CoordX);
                                                            this.method_5(fileStream, neededItem.CoordY);
                                                      }
                                                }
                                                try
                                                {
                                                      if (value.NHIEM_VU_HOAN_NGHENH_TIEP_THU_NHAC_NHO_1.Length > 10)
                                                      {
                                                            while (value.NHIEM_VU_HOAN_NGHENH_TIEP_THU_NHAC_NHO_1.LastIndexOf("\r\n") >= value.NHIEM_VU_HOAN_NGHENH_TIEP_THU_NHAC_NHO_1.Length - 2)
                                                            {
                                                                  value.NHIEM_VU_HOAN_NGHENH_TIEP_THU_NHAC_NHO_1 = value.NHIEM_VU_HOAN_NGHENH_TIEP_THU_NHAC_NHO_1.Remove(value.NHIEM_VU_HOAN_NGHENH_TIEP_THU_NHAC_NHO_1.Length - 2, 2);
                                                            }
                                                      }
                                                      if (value.NHIEM_VU_HOAN_NGHENH_TU_CHOI_NHAC_NHO_1.Length > 10)
                                                      {
                                                            while (value.NHIEM_VU_HOAN_NGHENH_TU_CHOI_NHAC_NHO_1.LastIndexOf("\r\n") >= value.NHIEM_VU_HOAN_NGHENH_TU_CHOI_NHAC_NHO_1.Length - 2)
                                                            {
                                                                  value.NHIEM_VU_HOAN_NGHENH_TU_CHOI_NHAC_NHO_1 = value.NHIEM_VU_HOAN_NGHENH_TU_CHOI_NHAC_NHO_1.Remove(value.NHIEM_VU_HOAN_NGHENH_TU_CHOI_NHAC_NHO_1.Length - 2, 2);
                                                            }
                                                      }
                                                }
                                                catch (Exception exception)
                                                {
                                                }
                                                this.a(fileStream, string.Concat(value.NHIEM_VU_HOAN_NGHENH_TIEP_THU_NHAC_NHO_1, this.string_2));
                                                this.a(fileStream, value.string_11);
                                                this.a(fileStream, value.string_12);
                                                this.a(fileStream, value.string_13);
                                                this.a(fileStream, value.string_14);
                                                this.a(fileStream, string.Concat(value.NHIEM_VU_HOAN_NGHENH_TU_CHOI_NHAC_NHO_1, this.string_2));
                                                this.a(fileStream, value.string_7);
                                                this.a(fileStream, value.string_8);
                                                this.a(fileStream, value.string_9);
                                                this.a(fileStream, value.string_10);
                                                foreach (NPC_CLASS nHIEMVUGIAIDOAN in value.NHIEM_VU_GIAI_DOAN)
                                                {
                                                      this.a(fileStream, nHIEMVUGIAIDOAN.StageText);
                                                      this.method_5(fileStream, nHIEMVUGIAIDOAN.NpcID);
                                                      this.method_5(fileStream, nHIEMVUGIAIDOAN.int_4);
                                                      this.method_5(fileStream, nHIEMVUGIAIDOAN.NpcMapID);
                                                      this.method_5(fileStream, nHIEMVUGIAIDOAN.NpcCoordX);
                                                      this.method_5(fileStream, nHIEMVUGIAIDOAN.NpcCoordY);
                                                      this.method_5(fileStream, nHIEMVUGIAIDOAN.NeededItem.Count);
                                                      if (nHIEMVUGIAIDOAN.NeededItem.Count > 0)
                                                      {
                                                            foreach (TaskRequiresItem_Category taskRequiresItemCategory in nHIEMVUGIAIDOAN.NeededItem)
                                                            {
                                                                  this.method_5(fileStream, taskRequiresItemCategory.ItemID);
                                                                  this.method_5(fileStream, taskRequiresItemCategory.ItemQuantity);
                                                                  this.method_5(fileStream, taskRequiresItemCategory.MapID);
                                                                  this.method_5(fileStream, taskRequiresItemCategory.CoordX);
                                                                  this.method_5(fileStream, taskRequiresItemCategory.CoordY);
                                                            }
                                                      }
                                                      this.a(fileStream, nHIEMVUGIAIDOAN.RequirementsMet);
                                                      this.a(fileStream, nHIEMVUGIAIDOAN.string_2);
                                                      this.a(fileStream, nHIEMVUGIAIDOAN.string_3);
                                                      this.a(fileStream, nHIEMVUGIAIDOAN.string_4);
                                                      this.a(fileStream, nHIEMVUGIAIDOAN.string_5);
                                                      this.a(fileStream, nHIEMVUGIAIDOAN.RequirementsNotMet);
                                                      this.a(fileStream, nHIEMVUGIAIDOAN.string_7);
                                                      this.a(fileStream, nHIEMVUGIAIDOAN.string_8);
                                                      this.a(fileStream, nHIEMVUGIAIDOAN.string_9);
                                                      this.a(fileStream, nHIEMVUGIAIDOAN.string_10);
                                                }
                                                this.method_5(fileStream, 0);
                                                fileStream.WriteByte(this.method_4(10));
                                          }
                                    }
                              }
                        }
                  }
                  catch (Exception exception1)
                  {
                  }
            }

            private void deleteQuestToolStripMenuItem_Click(object sender, EventArgs e)
            {
                  try
                  {
                        IEnumerator enumerator = this.listView.SelectedItems.GetEnumerator();
                        try
                        {
                              if (enumerator.MoveNext())
                              {
                                    ListViewItem current = (ListViewItem)enumerator.Current;
                                    if (MessageBox.Show(string.Concat("您确认要删除任务 # ", current.Text), "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                                    {
                                          this.dictionary_0.Remove(int.Parse(current.Text));
                                          this.c();
                                    }
                              }
                        }
                        finally
                        {
                              IDisposable disposable = enumerator as IDisposable;
                              if (disposable != null)
                              {
                                    disposable.Dispose();
                              }
                        }
                  }
                  catch
                  {
                  }
            }

            private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
            {
                  QUEST_CLASS qUESTCLAss;
                  if (this.listView.SelectedItems.Count > 0)
                  {
                        string text = this.listView.SelectedItems[0].SubItems[0].Text;
                        if (this.dictionary_0.TryGetValue(int.Parse(text), out qUESTCLAss))
                        {
                              string startupPath = Application.StartupPath;
                              int nHIEMVUID = qUESTCLAss.NHIEM_VU_ID;
                              using (StreamWriter streamWriter = new StreamWriter(new FileStream(string.Concat(startupPath, "\\MissIon", nHIEMVUID.ToString(), ".lua"), FileMode.Create, FileAccess.Write, FileShare.Read), Encoding.GetEncoding("gb2312")))
                              {
                                    streamWriter.Write("--LUA Generator by YULGANG \r\n");
                                    string[] nHIEMVUTEN = new string[] { "--[", qUESTCLAss.NHIEM_VU_TEN, "] Stage Count:[", null, null };
                                    nHIEMVUID = qUESTCLAss.NHIEM_VU_GIAI_DOAN.Count;
                                    nHIEMVUTEN[3] = nHIEMVUID.ToString();
                                    nHIEMVUTEN[4] = "]\r\n";
                                    streamWriter.Write(string.Concat(nHIEMVUTEN));
                                    nHIEMVUID = qUESTCLAss.NHIEM_VU_ID;
                                    streamWriter.Write(string.Concat("function MissIon", nHIEMVUID.ToString(), "(UserWorldId,QuestId, CzId, RwJdId)\r\n"));
                                    streamWriter.Write("  local Player = GetPlayer(UserWorldId)\r\n");
                                    streamWriter.Write("  if CzId==1 then\r\n");
                                    if (qUESTCLAss.NHIEM_VU_TEN.Contains("(正)") || qUESTCLAss.NHIEM_VU_TEN.Contains("（正派）") || qUESTCLAss.NHIEM_VU_TEN.Contains("(正派)"))
                                    {
                                          streamWriter.Write("      if Player.Player_Zx==2 then\r\n");
                                          streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                          streamWriter.Write("      elseif Player.Player_Zx==0 then\r\n");
                                          streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                          streamWriter.Write("      end\r\n");
                                    }
                                    if (qUESTCLAss.NHIEM_VU_TEN.Contains("(邪)") || qUESTCLAss.NHIEM_VU_TEN.Contains("（邪派）") || qUESTCLAss.NHIEM_VU_TEN.Contains("(邪派)"))
                                    {
                                          streamWriter.Write("      if Player.Player_Zx==1 then\r\n");
                                          streamWriter.Write("\t\t\tSendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                          streamWriter.Write("      elseif Player.Player_Zx==0 then\r\n");
                                          streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                          streamWriter.Write("      end\r\n");
                                    }
                                    if (qUESTCLAss.NHIEM_VU_TEN.Contains("/刀)"))
                                    {
                                          streamWriter.Write("      if Player.Player_Job!=1 then\r\n");
                                          streamWriter.Write("         SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                          streamWriter.Write("      end\r\n");
                                    }
                                    if (qUESTCLAss.NHIEM_VU_TEN.Contains("/剑)"))
                                    {
                                          streamWriter.Write("      if Player.Player_Job!=2 then\r\n");
                                          streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                          streamWriter.Write("      end\r\n");
                                    }
                                    if (qUESTCLAss.NHIEM_VU_TEN.Contains("/枪)"))
                                    {
                                          streamWriter.Write("      if Player.Player_Job!=3 then\r\n");
                                          streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                          streamWriter.Write("      end\r\n");
                                    }
                                    if (qUESTCLAss.NHIEM_VU_TEN.Contains("/弓)"))
                                    {
                                          streamWriter.Write("      if Player.Player_Job!=4 then\r\n");
                                          streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                          streamWriter.Write("      end\r\n");
                                    }
                                    if (qUESTCLAss.NHIEM_VU_TEN.Contains("/医生)"))
                                    {
                                          streamWriter.Write("      if Player.Player_Job!=5 then\r\n");
                                          streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                          streamWriter.Write("      end\r\n");
                                    }
                                    if (qUESTCLAss.NHIEM_VU_TEN.Contains("/刺客)"))
                                    {
                                          streamWriter.Write("      if Player.Player_Job!=6 then\r\n");
                                          streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                          streamWriter.Write("      end\r\n");
                                    }
                                    nHIEMVUID = qUESTCLAss.NHIEM_VU_THU_BAC;
                                    streamWriter.Write(string.Concat("      if Player.Player_FLD_LEVEL<", nHIEMVUID.ToString(), " then\r\n"));
                                    streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                    streamWriter.Write("      else\r\n");
                                    streamWriter.Write("          local QuestLevel=GetQuestLevel(UserWorldId,QuestId)\r\n");
                                    streamWriter.Write("          if QuestLevel==1 then\r\n");
                                    streamWriter.Write("              RwJdId=2\r\n");
                                    streamWriter.Write("              AddQuest(UserWorldId,QuestId,RwJdId)\r\n");
                                    streamWriter.Write("              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)\r\n");
                                    if (qUESTCLAss.NHIEM_VU_GIAI_DOAN.Count == 1)
                                    {
                                          foreach (TaskRequiresItem_Category neededItem in qUESTCLAss.NeededItem)
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
                                                streamWriter.Write(string.Concat(str));
                                                nHIEMVUID = neededItem.ItemID;
                                                streamWriter.Write(string.Concat("              if bool", nHIEMVUID.ToString(), " then\r\n"));
                                                nHIEMVUID = neededItem.ItemID;
                                                streamWriter.Write(string.Concat("                  AddQuestItme(UserWorldId,", nHIEMVUID.ToString(), ",0)\r\n"));
                                                streamWriter.Write("              else\r\n");
                                                streamWriter.Write("                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                                streamWriter.Write("              end\r\n");
                                          }
                                    }
                                    else if (qUESTCLAss.NHIEM_VU_GIAI_DOAN.Count > 1)
                                    {
                                          for (int i = 0; i < qUESTCLAss.NHIEM_VU_GIAI_DOAN.Count; i++)
                                          {
                                                if (i + 2 <= qUESTCLAss.NHIEM_VU_GIAI_DOAN.Count)
                                                {
                                                      nHIEMVUID = i + 2;
                                                      streamWriter.Write(string.Concat("          elseif QuestLevel==", nHIEMVUID.ToString(), " then\r\n"));
                                                }
                                                foreach (TaskRequiresItem_Category taskRequiresItemCategory in qUESTCLAss.NHIEM_VU_GIAI_DOAN[i].NeededItem)
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
                                                      streamWriter.Write(string.Concat(strArrays));
                                                      nHIEMVUID = taskRequiresItemCategory.ItemID;
                                                      streamWriter.Write(string.Concat("              if bool", nHIEMVUID.ToString(), " then\r\n"));
                                                      nHIEMVUID = taskRequiresItemCategory.ItemID;
                                                      streamWriter.Write(string.Concat("                  AddQuestItme(UserWorldId,", nHIEMVUID.ToString(), ",0)\r\n"));
                                                      streamWriter.Write("              else\r\n");
                                                      streamWriter.Write("                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                                      streamWriter.Write("              end\r\n");
                                                }
                                                if (i + 1 != qUESTCLAss.NHIEM_VU_GIAI_DOAN.Count)
                                                {
                                                      nHIEMVUID = i + 3;
                                                      streamWriter.Write(string.Concat("              RwJdId=", nHIEMVUID.ToString(), "\r\n"));
                                                      streamWriter.Write("              AddQuest(UserWorldId,QuestId,RwJdId)\r\n");
                                                      streamWriter.Write("              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)\r\n");
                                                }
                                          }
                                    }
                                    streamWriter.Write("          else\r\n");
                                    streamWriter.Write("              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)\r\n");
                                    streamWriter.Write("          end\r\n");
                                    streamWriter.Write("      end\r\n");
                                    streamWriter.Write("  elseif CzId==2 then\r\n");
                                    streamWriter.Write("      RwJdId=1\r\n");
                                    streamWriter.Write("      AddQuest(UserWorldId,QuestId,RwJdId)\r\n");
                                    streamWriter.Write("      SendMissionMsg(UserWorldId,QuestId, 21, RwJdId)\r\n");
                                    streamWriter.Write("  elseif CzId==3 then\r\n");
                                    streamWriter.Write("      SendMissionMsg(UserWorldId,QuestId, 31, RwJdId)\r\n");
                                    streamWriter.Write("  elseif CzId==5 then\r\n");
                                    streamWriter.Write("      local QuestLevel=GetQuestLevel(UserWorldId,QuestId)\r\n");
                                    nHIEMVUID = 1 + qUESTCLAss.NHIEM_VU_GIAI_DOAN.Count;
                                    streamWriter.Write(string.Concat("      if QuestLevel==", nHIEMVUID.ToString(), " then\r\n"));
                                    if (qUESTCLAss.KHEN_THUONG_ITEM.Count > 0)
                                    {
                                          foreach (QuestItems_Category kHENTHUONGITEM in qUESTCLAss.KHEN_THUONG_ITEM)
                                          {
                                                nHIEMVUID = kHENTHUONGITEM.ItemID;
                                                streamWriter.Write(string.Concat("              local weiz", nHIEMVUID.ToString(), "=GetPackage(UserWorldId)\r\n"));
                                                nHIEMVUID = kHENTHUONGITEM.ItemID;
                                                streamWriter.Write(string.Concat("              if weiz", nHIEMVUID.ToString(), "==-1 then\r\n"));
                                                streamWriter.Write("                  SendSysMsg(UserWorldId,\"装备栏没有空位了，请清理!\", 9, \"GOI_Y_HE_THONG\")\r\n");
                                                streamWriter.Write("                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                                streamWriter.Write("                  return \r\n");
                                                streamWriter.Write("              else\r\n");
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
                                                streamWriter.Write(string.Concat(str1));
                                                streamWriter.Write("              end\r\n");
                                          }
                                    }
                                    streamWriter.Write("      end\r\n");
                                    streamWriter.Write("      SendMissionMsg(UserWorldId,QuestId, 51, RwJdId)\r\n");
                                    streamWriter.Write("  end\r\n");
                                    streamWriter.Write("end\r\n");
                              }
                        }
                  }
            }

            protected override void Dispose(bool disposing)
            {
                  if (disposing && this.icontainer_0 != null)
                  {
                        this.icontainer_0.Dispose();
                  }
                  base.Dispose(disposing);
            }

            private void e(object sender, EventArgs e)
            {

            }

            private void f(object sender, EventArgs e)
            {
            }

            private void InitializeComponent()
            {
                  this.components = new System.ComponentModel.Container();
                  this.menuStrip1 = new System.Windows.Forms.MenuStrip();
                  this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.打开YbqcfgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.保存YbqcfgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.statusStrip1 = new System.Windows.Forms.StatusStrip();
                  this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
                  this.splitContainer1 = new System.Windows.Forms.SplitContainer();
                  this.listView = new System.Windows.Forms.ListView();
                  this.columnHeader_0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                  this.columnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                  this.columnHeader_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                  this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
                  this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.temporaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.deleteQuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.reloadRefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
                  this.menuStrip1.SuspendLayout();
                  this.statusStrip1.SuspendLayout();
                  this.splitContainer1.Panel1.SuspendLayout();
                  this.splitContainer1.Panel2.SuspendLayout();
                  this.splitContainer1.SuspendLayout();
                  this.contextMenuStrip1.SuspendLayout();
                  this.SuspendLayout();
                  // 
                  // menuStrip1
                  // 
                  this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem});
                  this.menuStrip1.Location = new System.Drawing.Point(0, 0);
                  this.menuStrip1.Name = "menuStrip1";
                  this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
                  this.menuStrip1.Size = new System.Drawing.Size(826, 24);
                  this.menuStrip1.TabIndex = 0;
                  this.menuStrip1.Text = "menuStrip1";
                  // 
                  // 文件ToolStripMenuItem
                  // 
                  this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开YbqcfgToolStripMenuItem,
            this.保存YbqcfgToolStripMenuItem});
                  this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
                  this.文件ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
                  this.文件ToolStripMenuItem.Text = "文件";
                  // 
                  // 打开YbqcfgToolStripMenuItem
                  // 
                  this.打开YbqcfgToolStripMenuItem.Name = "打开YbqcfgToolStripMenuItem";
                  this.打开YbqcfgToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
                  this.打开YbqcfgToolStripMenuItem.Text = "打开YBQ文件";
                  this.打开YbqcfgToolStripMenuItem.Click += new System.EventHandler(this.b);
                  // 
                  // 保存YbqcfgToolStripMenuItem
                  // 
                  this.保存YbqcfgToolStripMenuItem.Name = "保存YbqcfgToolStripMenuItem";
                  this.保存YbqcfgToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
                  this.保存YbqcfgToolStripMenuItem.Text = "保存YBQ文件";
                  this.保存YbqcfgToolStripMenuItem.Click += new System.EventHandler(this.d);
                  // 
                  // statusStrip1
                  // 
                  this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
                  this.statusStrip1.Location = new System.Drawing.Point(0, 472);
                  this.statusStrip1.Name = "statusStrip1";
                  this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
                  this.statusStrip1.Size = new System.Drawing.Size(826, 22);
                  this.statusStrip1.TabIndex = 1;
                  this.statusStrip1.Text = "statusStrip1";
                  this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
                  // 
                  // toolStripStatusLabel1
                  // 
                  this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
                  this.toolStripStatusLabel1.Size = new System.Drawing.Size(121, 17);
                  this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
                  // 
                  // splitContainer1
                  // 
                  this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
                  this.splitContainer1.Location = new System.Drawing.Point(0, 24);
                  this.splitContainer1.Name = "splitContainer1";
                  // 
                  // splitContainer1.Panel1
                  // 
                  this.splitContainer1.Panel1.Controls.Add(this.listView);
                  // 
                  // splitContainer1.Panel2
                  // 
                  this.splitContainer1.Panel2.Controls.Add(this.propertyGrid1);
                  this.splitContainer1.Size = new System.Drawing.Size(826, 448);
                  this.splitContainer1.SplitterDistance = 329;
                  this.splitContainer1.SplitterWidth = 5;
                  this.splitContainer1.TabIndex = 2;
                  // 
                  // listView
                  // 
                  this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_0,
            this.columnHeader_1,
            this.columnHeader_2});
                  this.listView.ContextMenuStrip = this.contextMenuStrip1;
                  this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
                  this.listView.FullRowSelect = true;
                  this.listView.GridLines = true;
                  this.listView.Location = new System.Drawing.Point(0, 0);
                  this.listView.Name = "listView";
                  this.listView.Size = new System.Drawing.Size(329, 448);
                  this.listView.TabIndex = 5;
                  this.listView.UseCompatibleStateImageBehavior = false;
                  this.listView.View = System.Windows.Forms.View.Details;
                  this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
                  // 
                  // columnHeader_0
                  // 
                  this.columnHeader_0.Text = "任务 ID";
                  // 
                  // columnHeader_1
                  // 
                  this.columnHeader_1.Text = "任务名";
                  this.columnHeader_1.Width = 140;
                  // 
                  // columnHeader_2
                  // 
                  this.columnHeader_2.Text = "任务等级";
                  // 
                  // contextMenuStrip1
                  // 
                  this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.temporaryToolStripMenuItem,
            this.deleteQuestToolStripMenuItem,
            this.reloadRefreshToolStripMenuItem});
                  this.contextMenuStrip1.Name = "contextMenuStrip1";
                  this.contextMenuStrip1.Size = new System.Drawing.Size(182, 92);
                  // 
                  // deleteToolStripMenuItem
                  // 
                  this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
                  this.deleteToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
                  this.deleteToolStripMenuItem.Text = "生成lua脚本";
                  this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
                  // 
                  // temporaryToolStripMenuItem
                  // 
                  this.temporaryToolStripMenuItem.Name = "temporaryToolStripMenuItem";
                  this.temporaryToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
                  this.temporaryToolStripMenuItem.Text = "复制任务ID(自定义)";
                  this.temporaryToolStripMenuItem.Click += new System.EventHandler(this.temporaryToolStripMenuItem_Click);
                  // 
                  // deleteQuestToolStripMenuItem
                  // 
                  this.deleteQuestToolStripMenuItem.Name = "deleteQuestToolStripMenuItem";
                  this.deleteQuestToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
                  this.deleteQuestToolStripMenuItem.Text = "删除任务";
                  this.deleteQuestToolStripMenuItem.Click += new System.EventHandler(this.deleteQuestToolStripMenuItem_Click);
                  // 
                  // reloadRefreshToolStripMenuItem
                  // 
                  this.reloadRefreshToolStripMenuItem.Name = "reloadRefreshToolStripMenuItem";
                  this.reloadRefreshToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
                  this.reloadRefreshToolStripMenuItem.Text = "重新读取任务";
                  this.reloadRefreshToolStripMenuItem.Click += new System.EventHandler(this.reloadRefreshToolStripMenuItem_Click);
                  // 
                  // propertyGrid1
                  // 
                  this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
                  this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
                  this.propertyGrid1.Name = "propertyGrid1";
                  this.propertyGrid1.Size = new System.Drawing.Size(492, 448);
                  this.propertyGrid1.TabIndex = 0;
                  // 
                  // YbQForm
                  // 
                  this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
                  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                  this.ClientSize = new System.Drawing.Size(826, 494);
                  this.Controls.Add(this.splitContainer1);
                  this.Controls.Add(this.statusStrip1);
                  this.Controls.Add(this.menuStrip1);
                  this.MainMenuStrip = this.menuStrip1;
                  this.Name = "YbQForm";
                  this.Text = "YBQTOOLS 13.0";
                  this.Load += new System.EventHandler(this.YbQForm_Load);
                  this.menuStrip1.ResumeLayout(false);
                  this.menuStrip1.PerformLayout();
                  this.statusStrip1.ResumeLayout(false);
                  this.statusStrip1.PerformLayout();
                  this.splitContainer1.Panel1.ResumeLayout(false);
                  this.splitContainer1.Panel2.ResumeLayout(false);
                  this.splitContainer1.ResumeLayout(false);
                  this.contextMenuStrip1.ResumeLayout(false);
                  this.ResumeLayout(false);
                  this.PerformLayout();

            }

            private int method_0(byte[] byte_1, ref int int_0)
            {
                  int int0 = 0;
                  try
                  {
                        int0 = int_0;
                        int_0 = int0 + 1;
                        int num = int0;
                        int num1 = num;
                        while (num1 < byte_1.Length)
                        {
                              if (byte_1[num1] == 32 || byte_1[num1] == 10)
                              {
                                    byte[] numArray = new byte[num1 - num];
                                    Buffer.BlockCopy(byte_1, num, numArray, 0, numArray.Length);
                                    string str = Encoding.Default.GetString(numArray);
                                    int_0 = int_0 + numArray.Length;
                                    //int0 = int.Parse(str);
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
                  string str = "0";
                  try
                  {
                        int int0 = int_0;
                        int_0 = int0 + 1;
                        int num = int0;
                        int num1 = num;
                        while (num1 < byte_1.Length)
                        {
                              if (byte_1[num1] == 32 || byte_1[num1] == 10)
                              {
                                    byte[] numArray = new byte[num1 - num];
                                    Buffer.BlockCopy(byte_1, num, numArray, 0, numArray.Length);
                                    string str1 = Encoding.Default.GetString(numArray);
                                    int_0 = int_0 + numArray.Length;
                                    byte[] numArray1 = new byte[int.Parse(str1)];
                                    Buffer.BlockCopy(byte_1, int_0, numArray1, 0, numArray1.Length);
                                    int_0 = int_0 + numArray1.Length + 1;
                                    str = Encoding.Default.GetString(numArray1);
                                    return str;
                              }
                              else
                              {
                                    num1++;
                              }
                        }
                        str = "0";
                  }
                  catch
                  {
                        str = "0";
                  }
                  return str;
            }

            private string method_2(byte[] byte_1, ref int int_0)
            {
                  int int0 = int_0;
                  for (int i = int0; i < (int)byte_1.Length; i++)
                  {
                        if (byte_1[i] == 32 || byte_1[i] == 10)
                        {
                              byte[] numArray = new byte[i - int0];
                              Buffer.BlockCopy(byte_1, int_0, numArray, 0, (int)numArray.Length);
                              int_0 = int_0 + (int)numArray.Length + 1;
                              return Encoding.Default.GetString(numArray);
                        }
                  }
                  return "";
            }

            private byte[] method_3(byte[] byte_1)
            {
                  for (int i = 0; (long)i < (long)byte_1.Length; i++)
                  {
                        int num = 0;
                        while (true)
                        {
                              if (num >= (int)this.byte_0.Length)
                              {
                                    break;
                              }
                              else if (byte_1[i] == this.byte_0[num])
                              {
                                    byte_1[i] = (byte)num;
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
                  for (int i = 0; i < (int)this.byte_0.Length; i++)
                  {
                        if (byte_1 == this.byte_0[i])
                        {
                              byte_1 = (byte)i;
                              return byte_1;
                        }
                  }
                  return byte_1;
            }

            private void method_5(FileStream fileStream_0, int int_0)
            {
                  byte[] numArray = this.method_3(Encoding.Default.GetBytes(int_0.ToString()));
                  fileStream_0.Write(numArray, 0, (int)numArray.Length);
                  fileStream_0.WriteByte(this.method_4(32));
            }

            private void reloadRefreshToolStripMenuItem_Click(object sender, EventArgs e)
            {
                  this.c();
            }

            public static System.Windows.Forms.DialogResult smethod_0(string string_3, string string_4, ref string string_5)
            {
                  Form form = new Form();
                  Label label = new Label();
                  TextBox textBox = new TextBox();
                  Button button = new Button();
                  Button button1 = new Button();
                  form.Text = string_3;
                  label.Text = string_4;
                  textBox.Text = string_5;
                  button.Text = "OK";
                  button1.Text = "Cancel";
                  button.DialogResult = System.Windows.Forms.DialogResult.OK;
                  button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                  label.SetBounds(9, 20, 372, 13);
                  textBox.SetBounds(12, 36, 372, 20);
                  button.SetBounds(228, 72, 75, 23);
                  button1.SetBounds(309, 72, 75, 23);
                  label.AutoSize = true;
                  TextBox anchor = textBox;
                  anchor.Anchor = anchor.Anchor | AnchorStyles.Right;
                  button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                  button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                  form.ClientSize = new System.Drawing.Size(396, 107);
                  form.Controls.AddRange(new Control[] { label, textBox, button, button1 });
                  form.ClientSize = new System.Drawing.Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
                  form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                  form.StartPosition = FormStartPosition.CenterScreen;
                  form.MinimizeBox = false;
                  form.MaximizeBox = false;
                  form.AcceptButton = button;
                  form.CancelButton = button1;
                  System.Windows.Forms.DialogResult dialogResult = form.ShowDialog();
                  string_5 = textBox.Text;
                  return dialogResult;
            }

            private void temporaryToolStripMenuItem_Click(object sender, EventArgs e)
            {
                  int num;
                  try
                  {
                        foreach (ListViewItem selectedItem in this.listView.SelectedItems)
                        {
                              string str = "";
                              if (YbQForm.smethod_0("任务ID", "Please insert a new Quest ID to use", ref str) != System.Windows.Forms.DialogResult.OK)
                              {
                                    continue;
                              }
                              if (int.TryParse(str, out num))
                              {
                                    foreach (object item in this.listView.Items)
                                    {
                                          if (int.Parse(((ListViewItem)item).Text) != num)
                                          {
                                                continue;
                                          }
                                          MessageBox.Show("The Quest ID you entered already exists!", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                          return;
                                    }
                                    int num1 = int.Parse(selectedItem.Text);
                                    QUEST_CLASS qUESTCLAss = this.dictionary_0[num1].method_0();
                                    qUESTCLAss.NHIEM_VU_ID = num;
                                    this.dictionary_0.Add(num, qUESTCLAss);
                                    this.c();
                                    break;
                              }
                              else
                              {
                                    MessageBox.Show("There was a problem with your Quest ID!", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    break;
                              }
                        }
                  }
                  catch
                  {
                  }
            }

            private void YbQForm_Load(object sender, EventArgs e)
            {
                  this.toolStripStatusLabel1.Text = string.Concat("任务总数:", this.dictionary_0.Count);
            }

            private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
            {

            }

            private void listView_SelectedIndexChanged(object sender, EventArgs e)
            {

            }
      }
}