using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
namespace RxjhTool
{
	public class YbQForm : Form
	{
		private byte[] byte_1A24628 = new byte[256];
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private IContainer components;
		private ContextMenuStrip contextMenuStrip1;
		private int delOK;
		private ListView listView;
		private MenuStrip menuStrip1;
		private PropertyGrid propertyGrid1;
		private SplitContainer splitContainer1;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel toolStripStatusLabel1;
		private ToolStripMenuItem 保存YbqcfgToolStripMenuItem;
		private ToolStripMenuItem 打开YbqcfgToolStripMenuItem;
		private Dictionary<int, TaskClass> 任务 = new Dictionary<int, TaskClass>();
		private ToolStripMenuItem 删除ToolStripMenuItem;
		private ToolStripMenuItem 生成lua脚本ToolStripMenuItem;
		private ToolStripMenuItem 文件ToolStripMenuItem;
		private string 文件地区 = "";
		private string 文件时间 = "";
            private ToolStripMenuItem lua일괄제작ToolStripMenuItem;
            private string 增加内容 = "\r\n\r\nVn-play";
		public YbQForm()
		{
			this.InitializeComponent();
			int num = 0;
			do
			{
				this.byte_1A24628[num] = (byte)((num >> 4 & 1) | (num >> 2 & 24) | (num >> 1 & 64) | 2 * ((num & 3) | 4 * ((num & 4) | 2 * (num & 248))));
				num++;
			}
			while (num < 256);
		}
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			this.toolStripStatusLabel1.Text = "퀘스트 리스트: " + this.任务.Count;
                  

            }
		private int getlen(byte[] var, ref int 处理长度)
		{
			int num = 处理长度++;
			int result;
			for (int i = num; i < var.Length; i++)
			{
				if (var[i] == 32 || var[i] == 10)
				{
					byte[] array = new byte[i - num];
					Buffer.BlockCopy(var, num, array, 0, array.Length);
					string @string = Encoding.Default.GetString(array);
					处理长度 += array.Length;
					try
					{
						result = int.Parse(@string);
					}
					catch (Exception)
					{
						result = 0;
					}
					return result;
				}
			}
			result = 0;
			return result;
		}
		private string getString(byte[] var, ref int 处理长度)
		{
			int num = 处理长度++;
			int i = num;
			while (i < var.Length)
			{
				if (var[i] == 32)
				{
                    goto IL_21;
				}
				if (var[i] == 10)
				{
					goto Block_2;
				}
				IL_95:
				i++;
				continue;
				Block_2:

            IL_21:
				try
				{
                    byte[] array = new byte[i - num];
                    Buffer.BlockCopy(var, num, array, 0, array.Length);
                    string @string = Encoding.Default.GetString(array);
                    处理长度 += array.Length;
                    byte[] array2 = new byte[int.Parse(@string)];
                    Buffer.BlockCopy(var, 处理长度, array2, 0, array2.Length);
                    string string2 = Encoding.Default.GetString(array2);
                    处理长度 += array2.Length + 1;
                    string text = string2;
                    string result = text;
                    return result;
				}
				catch (Exception)
				{
					string text = "";
					string result = text;
					return result;
				}
				goto IL_95;
			}
			return "";
		}
		private string getStringtou(byte[] var, ref int 处理长度)
		{
			int num = 处理长度;
			for (int i = num; i < var.Length; i++)
			{
				if (var[i] == 32 || var[i] == 10)
				{
					byte[] array = new byte[i - num];
					Buffer.BlockCopy(var, 处理长度, array, 0, array.Length);
					string @string = Encoding.Default.GetString(array);
					处理长度 += array.Length + 1;
					return @string;
				}
			}
			return "";
		}
		private void InitializeComponent()
		{
                  this.components = new System.ComponentModel.Container();
                  this.menuStrip1 = new System.Windows.Forms.MenuStrip();
                  this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.打开YbqcfgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.保存YbqcfgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.lua일괄제작ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.statusStrip1 = new System.Windows.Forms.StatusStrip();
                  this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
                  this.splitContainer1 = new System.Windows.Forms.SplitContainer();
                  this.listView = new System.Windows.Forms.ListView();
                  this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                  this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                  this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
                  this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
                  this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.生成lua脚本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.menuStrip1.SuspendLayout();
                  this.statusStrip1.SuspendLayout();
                  ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
                  this.splitContainer1.Panel1.SuspendLayout();
                  this.splitContainer1.Panel2.SuspendLayout();
                  this.splitContainer1.SuspendLayout();
                  this.contextMenuStrip1.SuspendLayout();
                  this.SuspendLayout();
                  // 
                  // menuStrip1
                  // 
                  this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.lua일괄제작ToolStripMenuItem});
                  this.menuStrip1.Location = new System.Drawing.Point(0, 0);
                  this.menuStrip1.Name = "menuStrip1";
                  this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
                  this.menuStrip1.Size = new System.Drawing.Size(754, 24);
                  this.menuStrip1.TabIndex = 0;
                  this.menuStrip1.Text = "menuStrip1";
                  // 
                  // 文件ToolStripMenuItem
                  // 
                  this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开YbqcfgToolStripMenuItem,
            this.保存YbqcfgToolStripMenuItem});
                  this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
                  this.文件ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
                  this.文件ToolStripMenuItem.Text = "불러오기";
                  this.文件ToolStripMenuItem.Click += new System.EventHandler(this.文件ToolStripMenuItem_Click);
                  // 
                  // 打开YbqcfgToolStripMenuItem
                  // 
                  this.打开YbqcfgToolStripMenuItem.Name = "打开YbqcfgToolStripMenuItem";
                  this.打开YbqcfgToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
                  this.打开YbqcfgToolStripMenuItem.Text = "Load Ybq.cfg";
                  this.打开YbqcfgToolStripMenuItem.Click += new System.EventHandler(this.打开YbqcfgToolStripMenuItem_Click);
                  // 
                  // 保存YbqcfgToolStripMenuItem
                  // 
                  this.保存YbqcfgToolStripMenuItem.Name = "保存YbqcfgToolStripMenuItem";
                  this.保存YbqcfgToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
                  this.保存YbqcfgToolStripMenuItem.Text = "Save Ybq.cfg";
                  this.保存YbqcfgToolStripMenuItem.Click += new System.EventHandler(this.保存YbqcfgToolStripMenuItem_Click);
                  // 
                  // lua일괄제작ToolStripMenuItem
                  // 
                  this.lua일괄제작ToolStripMenuItem.Name = "lua일괄제작ToolStripMenuItem";
                  this.lua일괄제작ToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
                  this.lua일괄제작ToolStripMenuItem.Text = "퀘스트 전체 저장";
                  this.lua일괄제작ToolStripMenuItem.Click += new System.EventHandler(this.lua일괄제작ToolStripMenuItem_Click);
                  // 
                  // statusStrip1
                  // 
                  this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
                  this.statusStrip1.Location = new System.Drawing.Point(0, 484);
                  this.statusStrip1.Name = "statusStrip1";
                  this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
                  this.statusStrip1.Size = new System.Drawing.Size(754, 22);
                  this.statusStrip1.TabIndex = 1;
                  this.statusStrip1.Text = "statusStrip1";
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
                  this.splitContainer1.Size = new System.Drawing.Size(754, 460);
                  this.splitContainer1.SplitterDistance = 299;
                  this.splitContainer1.SplitterWidth = 5;
                  this.splitContainer1.TabIndex = 2;
                  // 
                  // listView
                  // 
                  this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
                  this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
                  this.listView.FullRowSelect = true;
                  this.listView.GridLines = true;
                  this.listView.Location = new System.Drawing.Point(0, 0);
                  this.listView.Name = "listView";
                  this.listView.Size = new System.Drawing.Size(299, 460);
                  this.listView.TabIndex = 5;
                  this.listView.UseCompatibleStateImageBehavior = false;
                  this.listView.View = System.Windows.Forms.View.Details;
                  this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
                  this.listView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseClick);
                  // 
                  // columnHeader1
                  // 
                  this.columnHeader1.Text = "코드";
                  this.columnHeader1.Width = 75;
                  // 
                  // columnHeader2
                  // 
                  this.columnHeader2.Text = "퀘스트 제목";
                  this.columnHeader2.Width = 200;
                  // 
                  // propertyGrid1
                  // 
                  this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
                  this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
                  this.propertyGrid1.Name = "propertyGrid1";
                  this.propertyGrid1.Size = new System.Drawing.Size(450, 460);
                  this.propertyGrid1.TabIndex = 0;
                  // 
                  // contextMenuStrip1
                  // 
                  this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem,
            this.生成lua脚本ToolStripMenuItem});
                  this.contextMenuStrip1.Name = "contextMenuStrip1";
                  this.contextMenuStrip1.Size = new System.Drawing.Size(161, 48);
                  // 
                  // 删除ToolStripMenuItem
                  // 
                  this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
                  this.删除ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
                  this.删除ToolStripMenuItem.Text = "삭제";
                  this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
                  // 
                  // 生成lua脚本ToolStripMenuItem
                  // 
                  this.生成lua脚本ToolStripMenuItem.Name = "生成lua脚本ToolStripMenuItem";
                  this.生成lua脚本ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
                  this.生成lua脚本ToolStripMenuItem.Text = "파일만들기 LUA";
                  this.生成lua脚本ToolStripMenuItem.Click += new System.EventHandler(this.生成lua脚本ToolStripMenuItem_Click);
                  // 
                  // YbQForm
                  // 
                  this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
                  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                  this.ClientSize = new System.Drawing.Size(754, 506);
                  this.Controls.Add(this.splitContainer1);
                  this.Controls.Add(this.statusStrip1);
                  this.Controls.Add(this.menuStrip1);
                  this.MainMenuStrip = this.menuStrip1;
                  this.Name = "YbQForm";
                  this.Text = "열혈강호 퀘스트 툴 13";
                  this.Load += new System.EventHandler(this.Form1_Load);
                  this.menuStrip1.ResumeLayout(false);
                  this.menuStrip1.PerformLayout();
                  this.statusStrip1.ResumeLayout(false);
                  this.statusStrip1.PerformLayout();
                  this.splitContainer1.Panel1.ResumeLayout(false);
                  this.splitContainer1.Panel2.ResumeLayout(false);
                  ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
                  this.splitContainer1.ResumeLayout(false);
                  this.contextMenuStrip1.ResumeLayout(false);
                  this.ResumeLayout(false);
                  this.PerformLayout();

		}
		private void listView_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right && this.listView.SelectedItems.Count > 0)
			{
				this.contextMenuStrip1.Show(Control.MousePosition.X, Control.MousePosition.Y);
			}
		}
		private void listView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.listView.SelectedItems.Count > 0)
			{
				string text = this.listView.SelectedItems[0].SubItems[0].Text;
				TaskClass 对象;
				if (this.任务.TryGetValue(int.Parse(text), out 对象))
				{
					CustomPropertyCollection selectedObject = new CustomPropertyCollection
					{
						new CustomProperty("코드", "QuestID", false, "퀘스트 코드", "Quest ID", 对象),
						new CustomProperty("제목", "QuestName", false, "퀘스트 제목", "Quest Name", 对象),
						new CustomProperty("레벨", "QuestLevel", false, "퀘스트 레벨", "Level Required", 对象),
						new CustomProperty("거절 메세지1", "QuestRefuse1", false, "Basic", "Refused Quest - Message 1", 对象, typeof(MultilineStringEditor)),
						new CustomProperty("거절 메세지2", "QuestRefuse2", false, "Basic", "Refused Quest - Message 2", 对象, typeof(MultilineStringEditor)),
						new CustomProperty("승인 메세지1", "QuestAccept1", false, "Basic", "Accepted Quest - Message 1", 对象, typeof(MultilineStringEditor)),
						new CustomProperty("승인 메세지2", "QuestAccept2", false, "Basic", "Accepted Quest - Message 2", 对象, typeof(MultilineStringEditor)),
						new CustomProperty("엔피시 코드", "NpcID", false, "엔피시 설정", "NpcID", 对象),
						new CustomProperty("엔피시 설정", "NpcCoords", false, "엔피시 설정", "Npc Coordinates Location", 对象, Convert.ToBoolean(1)),
						new CustomProperty("보상 아이템 목록", "RewardItems", false, "RewardItems", "List of Reward Items", 对象, typeof(MyRewardItemsCollectionEditor)),
						new CustomProperty("요구 아이템 목록", "RequiredItems", false, "RequiredItems", "List of Required Items", 对象, typeof(MyRequiredItemsCollectionEditor)),
						new CustomProperty("미완료 메세지", "任务欢迎拒绝提示1", false, "QuestContent", "Does not meet the requirements", 对象, typeof(MultilineStringEditor)),
						new CustomProperty("완료 메세지", "任务欢迎接受提示1", false, "QuestContent", "Meets the requirements", 对象, typeof(MultilineStringEditor)),
						new CustomProperty("QuestStageNumber", "QuestStageNumber", false, "QuestStage", "QuestStage总Qty=StageNumbers的Qty+1", 对象),
						new CustomProperty("QuestStage", "QuestStage", false, "QuestStage", "QuestStageList", 对象, typeof(MyQuestStageCollectionEditor))
					};
					this.propertyGrid1.SelectedObject = selectedObject;
				}
			}
		}

            private void AllConvert()
            {
                  //일괄제작 2017-03-17 추가
                  try
                  {
                        if (this.listView.Items.Count > 0)
                        {
                              string DirPath = Application.StartupPath + "\\Script\\";
                              DirectoryInfo di = new DirectoryInfo(DirPath);
                              if (di.Exists != true) Directory.CreateDirectory(DirPath);

                              for (int i = 0; i < this.listView.Items.Count; i++)
                              {
                                    string text = this.listView.Items[i].SubItems[0].Text;
                                    SaveDataLua(int.Parse(text));
                              }
                              MessageBox.Show("전체 퀘스트 저장완료!");
                        }
                        else
                        {
                              MessageBox.Show("저장할 데이터가 없습니다.");
                        }
                  }
                  catch { }
            }

            private void SaveDataLua(int _count)
            {

                  TaskClass 任务类;
                  if (this.任务.TryGetValue(_count, out 任务类))
                  {
                        using (StreamWriter streamWriter = new StreamWriter(new FileStream(Application.StartupPath + "\\Script\\MissIon" + 任务类.QuestID.ToString() + ".lua", FileMode.Create, FileAccess.Write, FileShare.Read), Encoding.GetEncoding("GB2312")))
                        {
                              streamWriter.Write("--Tools tao Script Lua nhiem vu Hiep Khach\r\n");
                              streamWriter.Write(string.Concat(new string[]
                              {
                                                "--Ten nhiem vu: (",
                                                任务类.QuestName,
                                                ") --- So buoc: (",
                                                任务类.QuestStage.Count.ToString(),
                                                ")\r\n"
                              }));
                              streamWriter.Write("function MissIon" + 任务类.QuestID.ToString() + "(UserWorldId,QuestId, StepQuest, StatusQuest)\r\n");
                              streamWriter.Write("  local Player = GetPlayer(UserWorldId)\r\n");
                              streamWriter.Write("--Cac buoc xu li nhiem vu\r\n");
                              streamWriter.Write("  if StepQuest==1 then\r\n");
                              if (任务类.QuestName.Contains("(正)") || 任务类.QuestName.Contains("（正派）") || 任务类.QuestName.Contains("(正派)"))
                              {
                                    streamWriter.Write("      if Player.Player_Zx==2 then\r\n");
                                    streamWriter.Write("          SendSysMsg(UserWorldId,\"Ta phai khong the nhan nhiem vu !\", 9, \"He thong\")\r\n");
                                    streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)\r\n");
                                    streamWriter.Write("      elseif Player.Player_Zx==0 then\r\n");
                                    streamWriter.Write("          SendSysMsg(UserWorldId,\"Chua gia nhap mon phai, khong the nhan nhiem vu !\", 9, \"He thong\")\r\n");
                                    streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)\r\n");
                                    streamWriter.Write("      end\r\n");
                              }
                              if (任务类.QuestName.Contains("(邪)") || 任务类.QuestName.Contains("（邪派）") || 任务类.QuestName.Contains("(邪派)"))
                              {
                                    streamWriter.Write("      if Player.Player_Zx==1 then\r\n");
                                    streamWriter.Write("          SendSysMsg(UserWorldId,\"Chinh phai khong the nhan nhiem vu !\", 9, \"He thong\")\r\n");
                                    streamWriter.Write("\t\t\tSendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)\r\n");
                                    streamWriter.Write("      elseif Player.Player_Zx==0 then\r\n");
                                    streamWriter.Write("          SendSysMsg(UserWorldId,\"Chua gia nhap mon phai, khong the nhan nhiem vu !\", 9, \"He thong\")\r\n");
                                    streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12,StatusQuest)\r\n");
                                    streamWriter.Write("      end\r\n");
                              }
                              if (任务类.QuestName.Contains("/刀)"))
                              {
                                    streamWriter.Write("      if Player.Player_Job~=1 then\r\n");
                                    streamWriter.Write("         SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)\r\n");
                                    streamWriter.Write("      end\r\n");
                              }
                              if (任务类.QuestName.Contains("/剑)"))
                              {
                                    streamWriter.Write("      if Player.Player_Job~=2 then\r\n");
                                    streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)\r\n");
                                    streamWriter.Write("      end\r\n");
                              }
                              if (任务类.QuestName.Contains("/枪)"))
                              {
                                    streamWriter.Write("      if Player.Player_Job~=3 then\r\n");
                                    streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)\r\n");
                                    streamWriter.Write("      end\r\n");
                              }
                              if (任务类.QuestName.Contains("/弓)"))
                              {
                                    streamWriter.Write("      if Player.Player_Job~=4 then\r\n");
                                    streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)\r\n");
                                    streamWriter.Write("      end\r\n");
                              }
                              if (任务类.QuestName.Contains("/医生)"))
                              {
                                    streamWriter.Write("      if Player.Player_Job~=5 then\r\n");
                                    streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)\r\n");
                                    streamWriter.Write("      end\r\n");
                              }
                              if (任务类.QuestName.Contains("/刺客)"))
                              {
                                    streamWriter.Write("      if Player.Player_Job~=6 then\r\n");
                                    streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)\r\n");
                                    streamWriter.Write("      end\r\n");
                              }
                              streamWriter.Write("      if Player.Player_FLD_LEVEL<" + 任务类.QuestLevel.ToString() + " then \r\n");
                              streamWriter.Write("          SendSysMsg(UserWorldId,\"Ban phai dat cap do " + 任务类.QuestLevel.ToString() + " moi co the nhan nhiem vu !\", 9, \"He thong\")\r\n");
                              streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --Chua du cap du yeu cau\r\n");
                              streamWriter.Write("      else\r\n");
                              streamWriter.Write("          local QuestLevel=GetQuestLevel(UserWorldId,QuestId)  --lay gia tri QuestLevel la buoc hien tai cua nhan vatt\r\n");
                              streamWriter.Write("          if QuestLevel==1 then  --neu dang o buoc 1\r\n");
                              if (任务类.QuestStage.Count == 1)
                              {
                                    streamWriter.Write("              local controng=GetPackages(UserWorldId," + 任务类.RewardItems.Count.ToString() + ")  --vi tri con trong\r\n");
                                    streamWriter.Write("              if controng.Count < " + 任务类.RewardItems.Count.ToString() + " then  --neu thung do day \r\n");
                                    streamWriter.Write("                SendSysMsg(UserWorldId,\"Tui do khong du " + 任务类.RewardItems.Count.ToString() + " khong gian trong!\", 9, \"Chu Y\")\r\n");
                                    streamWriter.Write("                SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)\r\n");
                                    streamWriter.Write("                return \r\n");
                                    streamWriter.Write("              else  --neu con cho trong\r\n");
                                    foreach (RequiredItems current in 任务类.RequiredItems)
                                    {
                                          streamWriter.Write(string.Concat(new string[]
                                          {
                                                            "              local  bool",
                                                            current.ItemID.ToString(),
                                                            " = GetQuestItme(UserWorldId, ",
                                                            current.ItemID.ToString(),
                                                            ", ",
                                                            current.ItemAmmount.ToString(),
                                                            ")  --kiem tra vat pham nhiem vu\r\n"
                                          }));
                                    }
                                    foreach (RequiredItems current2 in 任务类.RequiredItems)
                                    {
                                          streamWriter.Write("              if bool" + current2.ItemID.ToString() + " then --du yeu cau\r\n");
                                    }
                                    foreach (RequiredItems current3 in 任务类.RequiredItems)
                                    {
                                          streamWriter.Write("                  AddQuestItme(UserWorldId," + current3.ItemID.ToString() + ",0) --xoa item nhiem vu\r\n");
                                    }
                                    streamWriter.Write("                  StatusQuest=2  --dat buoc tiep theo la 2\r\n");
                                    streamWriter.Write("                  AddQuest(UserWorldId,QuestId, StatusQuest)  --cho lam buoc tiep theo la: 2\r\n");
                                    streamWriter.Write("                  SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 2\r\n");
                                    foreach (RequiredItems arg_656_0 in 任务类.RequiredItems)
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
                                    if (任务类.QuestStage.Count > 1)
                                    {
                                          foreach (RequiredItems current4 in 任务类.RequiredItems)
                                          {
                                                streamWriter.Write(string.Concat(new string[]
                                                {
                                                                  "              local  bool",
                                                                  current4.ItemID.ToString(),
                                                                  " = GetQuestItme(UserWorldId, ",
                                                                  current4.ItemID.ToString(),
                                                                  ", ",
                                                                  current4.ItemAmmount.ToString(),
                                                                  ")  --kiem tra vat pham nhiem vu\r\n"
                                                }));
                                          }
                                          foreach (RequiredItems current5 in 任务类.RequiredItems)
                                          {
                                                streamWriter.Write("              if bool" + current5.ItemID.ToString() + " then --du yeu cau\r\n");
                                          }
                                          foreach (RequiredItems current6 in 任务类.RequiredItems)
                                          {
                                                streamWriter.Write("              AddQuestItme(UserWorldId," + current6.ItemID.ToString() + ",0) --xoa vat pham nhiem vu\r\n");
                                          }
                                          foreach (RequiredItems current7 in 任务类.QuestStage[0].RequiredItems)
                                          {
                                                if (current7.ItemAmmount != 1)
                                                {
                                                      streamWriter.Write(" \r\n");
                                                      streamWriter.Write("-- VAT PHAM ROT RA KHI DANH QUAI --\r\n");
                                                      streamWriter.Write(string.Concat(new string[]
                                                      {
                                                                        "-- ID VAT PHAM: ( ",
                                                                        current7.ItemID.ToString(),
                                                                        " ) -- SO LUONG: ( ",
                                                                        current7.ItemAmmount.ToString(),
                                                                        " ) -- BUOC: ( 2 ) --\r\n"
                                                      }));
                                                      streamWriter.Write(string.Concat(new string[]
                                                      {
                                                                        "-- BAN DO: ( ",
                                                                        current7.MapID.ToString(),
                                                                        " ) -- X: ( ",
                                                                        current7.CoordsX.ToString(),
                                                                        " ) -- Y: ( ",
                                                                        current7.CoordsY.ToString(),
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
                                                                              current7.ItemAmmount.ToString(),
                                                                              " ) -- BUOC: ( 2 ) --\r\n"
                                                            }));
                                                            streamWriter.Write(string.Concat(new string[]
                                                            {
                                                                              "-- BAN DO: ( ",
                                                                              current7.MapID.ToString(),
                                                                              " ) -- X: ( ",
                                                                              current7.CoordsX.ToString(),
                                                                              " ) -- Y: ( ",
                                                                              current7.CoordsY.ToString(),
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
                                                                              current7.ItemAmmount.ToString(),
                                                                              ") --them vat pham nhiem vu cho buoc tiep theo\r\n"
                                                            }));
                                                      }
                                                }
                                          }
                                          streamWriter.Write("              StatusQuest=2 \r\n");
                                          streamWriter.Write("              AddQuest(UserWorldId,QuestId, StatusQuest) \r\n");
                                          streamWriter.Write("              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la 2\r\n");
                                          foreach (RequiredItems arg_B4E_0 in 任务类.RequiredItems)
                                          {
                                                streamWriter.Write("              else \r\n");
                                                streamWriter.Write("              SendSysMsg(UserWorldId,\"Chua dat yeu cau, quay lai sau !\", 9, \"He thong\")\r\n");
                                                streamWriter.Write("              SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --cho lam buoc tiep theo la 2\r\n");
                                                streamWriter.Write("              end \r\n");
                                          }
                                          for (int j = 0; j < 任务类.QuestStage.Count - 1; j++)
                                          {
                                                streamWriter.Write("          elseif QuestLevel==" + (j + 2).ToString() + " then\r\n");
                                                if (j == 任务类.QuestStage.Count - 2)
                                                {
                                                      streamWriter.Write("              local controng=GetPackages(UserWorldId," + 任务类.RewardItems.Count.ToString() + ")  --vi tri con trong\r\n");
                                                      streamWriter.Write("              if controng.Count < " + 任务类.RewardItems.Count.ToString() + " then  --neu thung do day \r\n");
                                                      streamWriter.Write("                SendSysMsg(UserWorldId,\"Tui do khong du " + 任务类.RewardItems.Count.ToString() + " khong gian trong!\", 9, \"Chu Y\")\r\n");
                                                      streamWriter.Write("                SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)\r\n");
                                                      streamWriter.Write("                return \r\n");
                                                      streamWriter.Write("              else  --neu con cho trong\r\n");
                                                }
                                                foreach (RequiredItems current8 in 任务类.QuestStage[j].RequiredItems)
                                                {
                                                      streamWriter.Write(string.Concat(new string[]
                                                      {
                                                                        "              local  bool",
                                                                        current8.ItemID.ToString(),
                                                                        " = GetQuestItme(UserWorldId, ",
                                                                        current8.ItemID.ToString(),
                                                                        ", ",
                                                                        current8.ItemAmmount.ToString(),
                                                                        ")  --kiem tra vat pham nhiem vu\r\n"
                                                      }));
                                                }
                                                foreach (RequiredItems current9 in 任务类.QuestStage[j].RequiredItems)
                                                {
                                                      streamWriter.Write("              if bool" + current9.ItemID.ToString() + " then --du yeu cau\r\n");
                                                }
                                                foreach (RequiredItems current10 in 任务类.QuestStage[j].RequiredItems)
                                                {
                                                      streamWriter.Write("                  AddQuestItme(UserWorldId," + current10.ItemID.ToString() + ",0) --xoa vat pham nhiem vu\r\n");
                                                }
                                                foreach (RequiredItems current11 in 任务类.QuestStage[j + 1].RequiredItems)
                                                {
                                                      if (current11.ItemAmmount != 1)
                                                      {
                                                            streamWriter.Write(" \r\n");
                                                            streamWriter.Write("-- VAT PHAM ROT RA KHI DANH QUAI --\r\n");
                                                            streamWriter.Write(string.Concat(new object[]
                                                            {
                                                                              "-- ID VAT PHAM: ( ",
                                                                              current11.ItemID.ToString(),
                                                                              " ) -- SO LUONG: ( ",
                                                                              current11.ItemAmmount.ToString(),
                                                                              " ) -- BUOC: ( ",
                                                                              j + 3,
                                                                              " ) --\r\n"
                                                            }));
                                                            streamWriter.Write(string.Concat(new string[]
                                                            {
                                                                              "-- BAN DO: ( ",
                                                                              current11.MapID.ToString(),
                                                                              " ) -- X: ( ",
                                                                              current11.CoordsX.ToString(),
                                                                              " ) -- Y: ( ",
                                                                              current11.CoordsY.ToString(),
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
                                                                                    current11.ItemAmmount.ToString(),
                                                                                    " ) -- BUOC: ( ",
                                                                                    j + 3,
                                                                                    " ) --\r\n"
                                                                  }));
                                                                  streamWriter.Write(string.Concat(new string[]
                                                                  {
                                                                                    "-- BAN DO: ( ",
                                                                                    current11.MapID.ToString(),
                                                                                    " ) -- X: ( ",
                                                                                    current11.CoordsX.ToString(),
                                                                                    " ) -- Y: ( ",
                                                                                    current11.CoordsY.ToString(),
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
                                                                                    current11.ItemAmmount.ToString(),
                                                                                    ") --them vat pham nhiem vu cho buoc tiep theo\r\n"
                                                                  }));
                                                            }
                                                      }
                                                }
                                                if (j + 1 != 任务类.QuestStage.Count)
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
                                                foreach (RequiredItems arg_11ED_0 in 任务类.QuestStage[j].RequiredItems)
                                                {
                                                      streamWriter.Write("              else \r\n");
                                                      streamWriter.Write("                  SendSysMsg(UserWorldId,\"Chua dat yeu cau, quay lai sau !\", 9, \"He thong\")\r\n");
                                                      streamWriter.Write("                  SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest) \r\n");
                                                      streamWriter.Write("              end\r\n");
                                                }
                                                if (j == 任务类.QuestStage.Count - 2)
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
                              streamWriter.Write("      if Player.Player_FLD_LEVEL<" + 任务类.QuestLevel.ToString() + " then  \r\n");
                              streamWriter.Write("          SendSysMsg(UserWorldId,\"Ban phai dat cap do " + 任务类.QuestLevel.ToString() + " moi co the nhan nhiem vu !\", 9, \"He thong\")\r\n");
                              streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --chua dat yeu cau, quay lai sau\r\n");
                              streamWriter.Write("      else\r\n");
                              int num = 任务类.QuestStage.Count + 1;
                              streamWriter.Write("         if QuestLevel==" + num + " then \r\n");
                              streamWriter.Write("            SendMissionMsg(UserWorldId,QuestId, 22, StatusQuest) \r\n");
                              streamWriter.Write("         else\r\n");
                              foreach (RequiredItems current12 in 任务类.RequiredItems)
                              {
                                    if (current12.ItemAmmount != 1)
                                    {
                                          streamWriter.Write(" \r\n");
                                          streamWriter.Write("-- VAT PHAM ROT RA KHI DANH QUAI --\r\n");
                                          streamWriter.Write(string.Concat(new string[]
                                          {
                                                            "-- ID VAT PHAM: ( ",
                                                            current12.ItemID.ToString(),
                                                            " ) -- SO LUONG: ( ",
                                                            current12.ItemAmmount.ToString(),
                                                            " ) -- BUOC: ( 1 ) --\r\n"
                                          }));
                                          streamWriter.Write(string.Concat(new string[]
                                          {
                                                            "-- BAN DO: ( ",
                                                            current12.MapID.ToString(),
                                                            " ) -- X: ( ",
                                                            current12.CoordsX.ToString(),
                                                            " ) -- Y: ( ",
                                                            current12.CoordsY.ToString(),
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
                                                                  current12.ItemAmmount.ToString(),
                                                                  " ) -- BUOC: ( 1 ) --\r\n"
                                                }));
                                                streamWriter.Write(string.Concat(new string[]
                                                {
                                                                  "-- BAN DO: ( ",
                                                                  current12.MapID.ToString(),
                                                                  " ) -- X: ( ",
                                                                  current12.CoordsX.ToString(),
                                                                  " ) -- Y: ( ",
                                                                  current12.CoordsY.ToString(),
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
                                                                  current12.ItemAmmount.ToString(),
                                                                  ") --them vat pham nhiem vu cho buoc tiep theo\r\n"
                                                }));
                                          }
                                    }
                              }
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
                              int num2 = 任务类.QuestStage.Count + 1;
                              streamWriter.Write("      if QuestLevel==" + num2 + " then\r\n");
                              streamWriter.Write("      local controng=GetPackages(UserWorldId," + 任务类.RewardItems.Count.ToString() + ")  --vi tri con trong\r\n");
                              streamWriter.Write("        if controng.Count < " + 任务类.RewardItems.Count.ToString() + " then  --neu thung do day \r\n");
                              streamWriter.Write("          SendSysMsg(UserWorldId,\"Tui do khong du " + 任务类.RewardItems.Count.ToString() + " khong gian trong!\", 9, \"Chu Y\")\r\n");
                              streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)\r\n");
                              streamWriter.Write("          return \r\n");
                              streamWriter.Write("        else  --neu con cho trong\r\n");
                              if (任务类.RewardItems.Count > 0)
                              {
                                    foreach (任务RewardItems类 current13 in 任务类.RewardItems)
                                    {
                                          int itemID = current13.ItemID;
                                          if (itemID <= 800000029)
                                          {
                                                if (itemID <= 9001215)
                                                {
                                                      if (itemID == 9000120)
                                                      {
                                                            streamWriter.Write("                 Addexporll(UserWorldId," + current13.ItemID + ",10800000) \r\n");
                                                            continue;
                                                      }
                                                      switch (itemID)
                                                      {
                                                            case 9001214:
                                                                  streamWriter.Write("                 Addexporll(UserWorldId," + current13.ItemID + ",10800000) \r\n");
                                                                  continue;
                                                            case 9001215:
                                                                  streamWriter.Write("                 Addexporll(UserWorldId," + current13.ItemID + ",10800000) \r\n");
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
                                                                              current13.ItemAmmount.ToString(),
                                                                              ")  --vi tri con trong\r\n"
                                                                  }));
                                                                  streamWriter.Write("                  local chiso=math.random(100005,100011) \r\n");
                                                                  for (int k = 0; k < current13.ItemAmmount; k++)
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
                                                                              current13.ItemAmmount.ToString(),
                                                                              ")  --vi tri con trong\r\n"
                                                                  }));
                                                                  streamWriter.Write("                  local chiso=math.random(200001,200004) \r\n");
                                                                  for (int l = 0; l < current13.ItemAmmount; l++)
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
                                                                              current13.ItemAmmount.ToString(),
                                                                              ")  --vi tri con trong\r\n"
                                                                  }));
                                                                  for (int m = 0; m < current13.ItemAmmount; m++)
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
                                                                              current13.ItemAmmount.ToString(),
                                                                              ")  --vi tri con trong\r\n"
                                                                  }));
                                                                  for (int n = 0; n < current13.ItemAmmount; n++)
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
                                                                              current13.ItemAmmount.ToString(),
                                                                              ")  --vi tri con trong\r\n"
                                                                  }));
                                                                  for (int num3 = 0; num3 < current13.ItemAmmount; num3++)
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
                                                                                    current13.ItemAmmount.ToString(),
                                                                                    ")  --vi tri con trong\r\n"
                                                                              }));
                                                                              streamWriter.Write("                  local chiso=math.random(700015,700025) \r\n");
                                                                              for (int num4 = 0; num4 < current13.ItemAmmount; num4++)
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
                                                                                    current13.ItemAmmount.ToString(),
                                                                                    ")  --vi tri con trong\r\n"
                                                                              }));
                                                                              streamWriter.Write("                  local chiso=math.random(200005,2000015) \r\n");
                                                                              for (int num5 = 0; num5 < current13.ItemAmmount; num5++)
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
                                                                                    current13.ItemAmmount.ToString(),
                                                                                    ")  --vi tri con trong\r\n"
                                                                              }));
                                                                              streamWriter.Write("                  local chiso=math.random(1000012,1000018) \r\n");
                                                                              for (int num6 = 0; num6 < current13.ItemAmmount; num6++)
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
                                                                                    current13.ItemAmmount.ToString(),
                                                                                    ")  --vi tri con trong\r\n"
                                                                              }));
                                                                              streamWriter.Write("                  local chiso=math.random(700005,700015) \r\n");
                                                                              for (int num7 = 0; num7 < current13.ItemAmmount; num7++)
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
                                                                                    current13.ItemAmmount.ToString(),
                                                                                    ")  --vi tri con trong\r\n"
                                                                              }));
                                                                              for (int num8 = 0; num8 < current13.ItemAmmount; num8++)
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
                                                                  streamWriter.Write("                  AddExpToCharacter(UserWorldId," + current13.ItemAmmount.ToString() + ") \r\n");
                                                                  continue;
                                                            case 909000002:
                                                                  streamWriter.Write("                  AddKiToCharacter(UserWorldId," + current13.ItemAmmount.ToString() + ") \r\n");
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
                                                                  streamWriter.Write("                  AddMoneyToCharacter(UserWorldId," + current13.ItemAmmount.ToString() + ") \r\n");
                                                                  streamWriter.Write("                  SendSysMsg(UserWorldId,\"Nhan duoc " + current13.ItemAmmount.ToString() + " tien vang!\", 9, \"He thong\")\r\n");
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
                                                                                    current13.ItemAmmount.ToString(),
                                                                                    ")  --vi tri con trong\r\n"
                                                                              }));
                                                                              for (int num9 = 0; num9 < current13.ItemAmmount; num9++)
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
                                                                                    current13.ItemAmmount.ToString(),
                                                                                    ")  --vi tri con trong\r\n"
                                                                              }));
                                                                              for (int num10 = 0; num10 < current13.ItemAmmount; num10++)
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
                                                                                    current13.ItemAmmount.ToString(),
                                                                                    ")  --vi tri con trong\r\n"
                                                                              }));
                                                                              for (int num11 = 0; num11 < current13.ItemAmmount; num11++)
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
                                                                              current13.ItemAmmount.ToString(),
                                                                              ")  --vi tri con trong\r\n"
                                                            }));
                                                            for (int num12 = 0; num12 < current13.ItemAmmount; num12++)
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
                                                                              current13.ItemAmmount.ToString(),
                                                                              ")  --vi tri con trong\r\n"
                                                            }));
                                                            for (int num13 = 0; num13 < current13.ItemAmmount; num13++)
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
                                                                              current13.ItemAmmount.ToString(),
                                                                              ")  --vi tri con trong\r\n"
                                                                  }));
                                                                  for (int num14 = 0; num14 < current13.ItemAmmount; num14++)
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
                                                                              current13.ItemAmmount.ToString(),
                                                                              ")  --vi tri con trong\r\n"
                                                                  }));
                                                                  for (int num15 = 0; num15 < current13.ItemAmmount; num15++)
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
                                                                  current13.ItemAmmount.ToString(),
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
                                                                  current13.ItemAmmount.ToString(),
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
            }
		private byte[] Write(byte[] 数据)
		{
			int num = 0;
			while ((long)num < 数据.LongLength)
			{
				for (int i = 0; i < this.byte_1A24628.Length; i++)
				{
					if (数据[num] == this.byte_1A24628[i])
					{
						数据[num] = (byte)i;
						num++;
						break;
					}
				}
			}
			return 数据;
		}
		private byte WriteByte(byte 数据)
		{
			for (int i = 0; i < this.byte_1A24628.Length; i++)
			{
				if (数据 == this.byte_1A24628[i])
				{
					数据 = (byte)i;
					return 数据;
				}
			}
			return 数据;
		}
		private void WriteInt(FileStream tdbtt, int 数据)
		{
			byte[] array = this.Write(Encoding.Default.GetBytes(数据.ToString()));
			tdbtt.Write(array, 0, array.Length);
			tdbtt.WriteByte(this.WriteByte(32));
		}
		private void WriteString(FileStream tdbtt, string 数据)
		{
			byte[] array = this.Write(Encoding.Default.GetBytes(数据));
			this.WriteInt(tdbtt, array.Length);
			tdbtt.Write(array, 0, array.Length);
			tdbtt.WriteByte(this.WriteByte(32));
		}
		private void 保存YbqcfgToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog
				{
					Filter = "Ybq (*.cfg)|Ybq.cfg|All files (*.*)|*.*",
					FilterIndex = 1,
					RestoreDirectory = true
				};
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					using (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write, FileShare.Read))
					{
						byte[] bytes = Encoding.Default.GetBytes(this.文件地区);
						byte[] bytes2 = Encoding.Default.GetBytes(this.文件时间);
						byte[] bytes3 = Encoding.Default.GetBytes(this.任务.Count.ToString());
						fileStream.Write(bytes, 0, bytes.Length);
						fileStream.WriteByte(32);
						fileStream.Write(bytes2, 0, bytes2.Length);
						fileStream.WriteByte(10);
						fileStream.Write(bytes3, 0, bytes3.Length);
						fileStream.WriteByte(32);
						foreach (TaskClass current in this.任务.Values)
						{
							this.WriteInt(fileStream, current.QuestID);
							this.WriteString(fileStream, current.QuestName);
							this.WriteInt(fileStream, current.QuestLevel);
							this.WriteInt(fileStream, current.任务未知1);
							this.WriteInt(fileStream, current.任务未知2);
							this.WriteInt(fileStream, current.任务未知3);
							this.WriteInt(fileStream, current.任务未知4);
							this.WriteInt(fileStream, current.任务未知5);
							this.WriteInt(fileStream, current.任务未知6);
							this.WriteInt(fileStream, current.任务未知7);
							this.WriteString(fileStream, current.QuestAccept1);
							this.WriteString(fileStream, current.QuestRefuse1);
							this.WriteString(fileStream, current.QuestAccept2);
							this.WriteString(fileStream, current.QuestRefuse2);
							this.WriteInt(fileStream, current.RewardItems.Count);
							if (current.RewardItems.Count > 0)
							{
								foreach (任务RewardItems类 current2 in current.RewardItems)
								{
									this.WriteInt(fileStream, current2.ItemID);
									this.WriteInt(fileStream, current2.ItemAmmount);
								}
							}
							if (current.QuestStageNumber <= 0)
							{
								byte[] array = this.Write(Encoding.Default.GetBytes(current.QuestStage.Count.ToString()));
								fileStream.Write(array, 0, array.Length);
								fileStream.WriteByte(this.WriteByte(10));
							}
							else
							{
								this.WriteInt(fileStream, current.QuestStage.Count + 1);
								this.WriteInt(fileStream, current.NpcID);
								this.WriteInt(fileStream, current.Npc未知1);
								this.WriteInt(fileStream, current.NpcCoords.MapID);
								this.WriteInt(fileStream, current.NpcCoords.CoordsX);
								this.WriteInt(fileStream, current.NpcCoords.CoordsY);
								this.WriteInt(fileStream, current.RequiredItems.Count);
								if (current.RequiredItems.Count > 0)
								{
									foreach (RequiredItems current3 in current.RequiredItems)
									{
										this.WriteInt(fileStream, current3.ItemID);
										this.WriteInt(fileStream, current3.ItemAmmount);
										this.WriteInt(fileStream, current3.MapID);
										this.WriteInt(fileStream, current3.CoordsX);
										this.WriteInt(fileStream, current3.CoordsY);
									}
								}
								try
								{
									if (current.任务欢迎接受提示1.Length > 10)
									{
										while (current.任务欢迎接受提示1.LastIndexOf("\r\n") >= current.任务欢迎接受提示1.Length - 2)
										{
											current.任务欢迎接受提示1 = current.任务欢迎接受提示1.Remove(current.任务欢迎接受提示1.Length - 2, 2);
										}
									}
									if (current.任务欢迎拒绝提示1.Length > 10)
									{
										while (current.任务欢迎拒绝提示1.LastIndexOf("\r\n") >= current.任务欢迎拒绝提示1.Length - 2)
										{
											current.任务欢迎拒绝提示1 = current.任务欢迎拒绝提示1.Remove(current.任务欢迎拒绝提示1.Length - 2, 2);
										}
									}
								}
								catch (Exception)
								{
								}
								this.WriteString(fileStream, current.任务欢迎接受提示1 + this.增加内容);
								this.WriteString(fileStream, current.任务欢迎接受提示2);
								this.WriteString(fileStream, current.任务欢迎接受提示3);
								this.WriteString(fileStream, current.任务欢迎接受提示4);
								this.WriteString(fileStream, current.任务欢迎接受提示5);
								this.WriteString(fileStream, current.任务欢迎拒绝提示1 + this.增加内容);
								this.WriteString(fileStream, current.任务欢迎拒绝提示2);
								this.WriteString(fileStream, current.任务欢迎拒绝提示3);
								this.WriteString(fileStream, current.任务欢迎拒绝提示4);
								this.WriteString(fileStream, current.任务欢迎拒绝提示5);
								foreach (QuestStage current4 in current.QuestStage)
								{
									this.WriteString(fileStream, current4.QuestStage内容);
									this.WriteInt(fileStream, current4.NpcID);
									this.WriteInt(fileStream, current4.Npc未知1);
									this.WriteInt(fileStream, current4.NpcMapID);
									this.WriteInt(fileStream, current4.NpcCoordsX);
									this.WriteInt(fileStream, current4.NpcCoordsY);
									this.WriteInt(fileStream, current4.RequiredItems.Count);
									if (current4.RequiredItems.Count > 0)
									{
										foreach (RequiredItems current5 in current4.RequiredItems)
										{
											this.WriteInt(fileStream, current5.ItemID);
											this.WriteInt(fileStream, current5.ItemAmmount);
											this.WriteInt(fileStream, current5.MapID);
											this.WriteInt(fileStream, current5.CoordsX);
											this.WriteInt(fileStream, current5.CoordsY);
										}
									}
									this.WriteString(fileStream, current4.任务条件符合提示1);
									this.WriteString(fileStream, current4.任务条件符合提示2);
									this.WriteString(fileStream, current4.任务条件符合提示3);
									this.WriteString(fileStream, current4.任务条件符合提示4);
									this.WriteString(fileStream, current4.任务条件符合提示5);
									this.WriteString(fileStream, current4.任务条件不符合提示1);
									this.WriteString(fileStream, current4.任务条件不符合提示2);
									this.WriteString(fileStream, current4.任务条件不符合提示3);
									this.WriteString(fileStream, current4.任务条件不符合提示4);
									this.WriteString(fileStream, current4.任务条件不符合提示5);
								}
								this.WriteInt(fileStream, 0);
								fileStream.WriteByte(this.WriteByte(10));
							}
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}
		private void 打开YbqcfgToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog
				{
					Filter = "Ybq (*.cfg)|Ybq.cfg|All files (*.*)|*.*",
					FilterIndex = 1,
					RestoreDirectory = true
				};
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					this.任务.Clear();
					this.listView.Items.Clear();
					using (FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read, FileShare.Read))
					{
						using (BinaryReader binaryReader = new BinaryReader(fileStream))
						{
							MemoryStream memoryStream = new MemoryStream();
							byte[] array = new byte[checked(binaryReader.BaseStream.Length)];
							while (binaryReader.Read(array, 0, array.Length) > 0)
							{
								int num = 0;
								this.文件地区 = this.getStringtou(array, ref num);
								this.文件时间 = this.getStringtou(array, ref num);
								this.getlen(array, ref num);
								int num2 = num;
                                                /*
								while ((long)num2 < array.LongLength)
								{
									if ((long)(num2 + 1) >= array.LongLength)
									{
										byte value = this.byte_1A24628[(int)array[num2]];
										memoryStream.WriteByte(value);
									}
									else
									{
										if (array[num2] == 13 && array[num2 + 1] == 10)
										{
											Console.WriteLine(num2);
										}
										else
										{
											byte value2 = this.byte_1A24628[(int)array[num2]];
											memoryStream.WriteByte(value2);
										}
									}
									num2++;
								}*/
                                                for (int j = num; (long)j < (long)array.Length; j++)
                                                {
                                                      if ((long)(j + 1) >= (long)array.Length)
                                                      {
                                                            memoryStream.WriteByte(this.byte_1A24628[array[j]]);
                                                      }
                                                      else if (array[j] != 13 || array[j + 1] != 10)
                                                      {
                                                            memoryStream.WriteByte(this.byte_1A24628[array[j]]);
                                                      }
                                                      else
                                                      {
                                                            Console.WriteLine(j);
                                                      }
                                                }
                                          }
							byte[] array2 = memoryStream.ToArray();
							int i = 0;
							while (i < array2.Length)
							{
								try
								{
									TaskClass 任务类 = new TaskClass
									{
										QuestID = this.getlen(array2, ref i),
										QuestName = this.getString(array2, ref i),
										QuestLevel = this.getlen(array2, ref i),
										任务未知1 = this.getlen(array2, ref i),
										任务未知2 = this.getlen(array2, ref i),
										任务未知3 = this.getlen(array2, ref i),
										任务未知4 = this.getlen(array2, ref i),
										任务未知5 = this.getlen(array2, ref i),
										任务未知6 = this.getlen(array2, ref i),
										任务未知7 = this.getlen(array2, ref i),
										QuestAccept1 = this.getString(array2, ref i),
										QuestRefuse1 = this.getString(array2, ref i),
										QuestAccept2 = this.getString(array2, ref i),
										QuestRefuse2 = this.getString(array2, ref i)
									};
									int num3 = this.getlen(array2, ref i);
									for (int j = 0; j < num3; j++)
									{
										任务RewardItems类 item = new 任务RewardItems类
										{
											ItemID = this.getlen(array2, ref i),
											ItemAmmount = this.getlen(array2, ref i)
										};
										任务类.RewardItems.Add(item);
									}
									任务类.QuestStageNumber = this.getlen(array2, ref i);
									if (任务类.QuestStageNumber > 0)
									{
										任务类.NpcID = this.getlen(array2, ref i);
										任务类.Npc未知1 = this.getlen(array2, ref i);
										任务类.NpcCoords.MapID = this.getlen(array2, ref i);
										任务类.NpcCoords.CoordsX = this.getlen(array2, ref i);
										任务类.NpcCoords.CoordsY = this.getlen(array2, ref i);
										int num4 = this.getlen(array2, ref i);
										for (int k = 0; k < num4; k++)
										{
											RequiredItems item2 = new RequiredItems
											{
												ItemID = this.getlen(array2, ref i),
												ItemAmmount = this.getlen(array2, ref i),
												MapID = this.getlen(array2, ref i),
												CoordsX = this.getlen(array2, ref i),
												CoordsY = this.getlen(array2, ref i)
											};
											任务类.RequiredItems.Add(item2);
										}
										任务类.任务欢迎接受提示1 = this.getString(array2, ref i);
										任务类.任务欢迎接受提示1 = 任务类.任务欢迎接受提示1.Replace(this.增加内容, "");
										任务类.任务欢迎接受提示2 = this.getString(array2, ref i);
										任务类.任务欢迎接受提示3 = this.getString(array2, ref i);
										任务类.任务欢迎接受提示4 = this.getString(array2, ref i);
										任务类.任务欢迎接受提示5 = this.getString(array2, ref i);
										任务类.任务欢迎拒绝提示1 = this.getString(array2, ref i);
										任务类.任务欢迎拒绝提示1 = 任务类.任务欢迎拒绝提示1.Replace(this.增加内容, "");
										任务类.任务欢迎拒绝提示2 = this.getString(array2, ref i);
										任务类.任务欢迎拒绝提示3 = this.getString(array2, ref i);
										任务类.任务欢迎拒绝提示4 = this.getString(array2, ref i);
										任务类.任务欢迎拒绝提示5 = this.getString(array2, ref i);
										for (int l = 0; l < 任务类.QuestStageNumber - 1; l++)
										{
											QuestStage questStage类 = new QuestStage
											{
												QuestStage内容 = this.getString(array2, ref i),
												NpcID = this.getlen(array2, ref i),
												Npc未知1 = this.getlen(array2, ref i),
												NpcMapID = this.getlen(array2, ref i),
												NpcCoordsX = this.getlen(array2, ref i),
												NpcCoordsY = this.getlen(array2, ref i)
											};
											int num5 = this.getlen(array2, ref i);
											for (int m = 0; m < num5; m++)
											{
												RequiredItems item3 = new RequiredItems
												{
													ItemID = this.getlen(array2, ref i),
													ItemAmmount = this.getlen(array2, ref i),
													MapID = this.getlen(array2, ref i),
													CoordsX = this.getlen(array2, ref i),
													CoordsY = this.getlen(array2, ref i)
												};
												questStage类.RequiredItems.Add(item3);
											}
											questStage类.任务条件符合提示1 = this.getString(array2, ref i);
											questStage类.任务条件符合提示2 = this.getString(array2, ref i);
											questStage类.任务条件符合提示3 = this.getString(array2, ref i);
											questStage类.任务条件符合提示4 = this.getString(array2, ref i);
											questStage类.任务条件符合提示5 = this.getString(array2, ref i);
											questStage类.任务条件不符合提示1 = this.getString(array2, ref i);
											questStage类.任务条件不符合提示2 = this.getString(array2, ref i);
											questStage类.任务条件不符合提示3 = this.getString(array2, ref i);
											questStage类.任务条件不符合提示4 = this.getString(array2, ref i);
											questStage类.任务条件不符合提示5 = this.getString(array2, ref i);
											任务类.QuestStage.Add(questStage类);
										}
										int num6 = this.getlen(array2, ref i);
										if (num6 > 0)
										{
											Console.WriteLine(num6);
										}
										i++;
									}
									this.任务.Add(任务类.QuestID, 任务类);
								}
								catch (Exception)
								{
								}
							}
							foreach (TaskClass current in this.任务.Values)
							{
								string[] items = new string[]
								{
									current.QuestID.ToString(),
									current.QuestName
								};
								this.listView.Items.Insert(this.listView.Items.Count, new ListViewItem(items));
							}
                                          this.toolStripStatusLabel1.Text = "퀘스트 리스트: " + this.任务.Count;
							MessageBox.Show("퀘스트" + this.任务.Count + " 목록", "완료");
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}
		private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn xóa nhiệm vụ này từ tập tin Ybq.cfg?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				int count = this.listView.SelectedItems.Count;
				if (count > 0)
				{
					for (int i = count - 1; i >= 0; i--)
					{
						int key = Convert.ToInt32(this.listView.SelectedItems[i].SubItems[0].Text);
						this.任务.Remove(key);
						this.listView.Items.Remove(this.listView.SelectedItems[i]);
					}
				}
			}
		}
		private void 生成lua脚本ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int count = this.listView.SelectedItems.Count;
			if (count > 0)
			{
				for (int i = count - 1; i >= 0; i--)
				{
					string text = this.listView.SelectedItems[i].SubItems[0].Text;
					TaskClass 任务类;
					if (this.任务.TryGetValue(int.Parse(text), out 任务类))
					{
                                    string DirPath = Application.StartupPath + "\\Script\\";
                                    DirectoryInfo di = new DirectoryInfo(DirPath);
                                    if (di.Exists != true) Directory.CreateDirectory(DirPath);
                                    using (StreamWriter streamWriter = new StreamWriter(new FileStream(DirPath + "MissIon" + 任务类.QuestID.ToString() + ".lua", FileMode.Create, FileAccess.Write, FileShare.Read), Encoding.GetEncoding("GB2312")))
						{
							streamWriter.Write("--Tools tao Script Lua nhiem vu Hiep Khach\r\n");
							streamWriter.Write(string.Concat(new string[]
							{
								"--Ten nhiem vu: (",
								任务类.QuestName,
								") --- So buoc: (",
								任务类.QuestStage.Count.ToString(),
								")\r\n"
							}));
							streamWriter.Write("function MissIon" + 任务类.QuestID.ToString() + "(UserWorldId,QuestId, StepQuest, StatusQuest)\r\n");
							streamWriter.Write("  local Player = GetPlayer(UserWorldId)\r\n");
							streamWriter.Write("--Cac buoc xu li nhiem vu\r\n");
							streamWriter.Write("  if StepQuest==1 then\r\n");
							if (任务类.QuestName.Contains("(正)") || 任务类.QuestName.Contains("（正派）") || 任务类.QuestName.Contains("(正派)"))
							{
								streamWriter.Write("      if Player.Player_Zx==2 then\r\n");
								streamWriter.Write("          SendSysMsg(UserWorldId,\"Ta phai khong the nhan nhiem vu !\", 9, \"He thong\")\r\n");
								streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)\r\n");
								streamWriter.Write("      elseif Player.Player_Zx==0 then\r\n");
								streamWriter.Write("          SendSysMsg(UserWorldId,\"Chua gia nhap mon phai, khong the nhan nhiem vu !\", 9, \"He thong\")\r\n");
								streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)\r\n");
								streamWriter.Write("      end\r\n");
							}
							if (任务类.QuestName.Contains("(邪)") || 任务类.QuestName.Contains("（邪派）") || 任务类.QuestName.Contains("(邪派)"))
							{
								streamWriter.Write("      if Player.Player_Zx==1 then\r\n");
								streamWriter.Write("          SendSysMsg(UserWorldId,\"Chinh phai khong the nhan nhiem vu !\", 9, \"He thong\")\r\n");
								streamWriter.Write("\t\t\tSendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)\r\n");
								streamWriter.Write("      elseif Player.Player_Zx==0 then\r\n");
								streamWriter.Write("          SendSysMsg(UserWorldId,\"Chua gia nhap mon phai, khong the nhan nhiem vu !\", 9, \"He thong\")\r\n");
								streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12,StatusQuest)\r\n");
								streamWriter.Write("      end\r\n");
							}
							if (任务类.QuestName.Contains("/刀)"))
							{
								streamWriter.Write("      if Player.Player_Job~=1 then\r\n");
								streamWriter.Write("         SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)\r\n");
								streamWriter.Write("      end\r\n");
							}
							if (任务类.QuestName.Contains("/剑)"))
							{
								streamWriter.Write("      if Player.Player_Job~=2 then\r\n");
								streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)\r\n");
								streamWriter.Write("      end\r\n");
							}
							if (任务类.QuestName.Contains("/枪)"))
							{
								streamWriter.Write("      if Player.Player_Job~=3 then\r\n");
								streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)\r\n");
								streamWriter.Write("      end\r\n");
							}
							if (任务类.QuestName.Contains("/弓)"))
							{
								streamWriter.Write("      if Player.Player_Job~=4 then\r\n");
								streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)\r\n");
								streamWriter.Write("      end\r\n");
							}
							if (任务类.QuestName.Contains("/医生)"))
							{
								streamWriter.Write("      if Player.Player_Job~=5 then\r\n");
								streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)\r\n");
								streamWriter.Write("      end\r\n");
							}
							if (任务类.QuestName.Contains("/刺客)"))
							{
								streamWriter.Write("      if Player.Player_Job~=6 then\r\n");
								streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)\r\n");
								streamWriter.Write("      end\r\n");
							}
							streamWriter.Write("      if Player.Player_FLD_LEVEL<" + 任务类.QuestLevel.ToString() + " then \r\n");
							streamWriter.Write("          SendSysMsg(UserWorldId,\"Ban phai dat cap do " + 任务类.QuestLevel.ToString() + " moi co the nhan nhiem vu !\", 9, \"He thong\")\r\n");
							streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --Chua du cap du yeu cau\r\n");
							streamWriter.Write("      else\r\n");
							streamWriter.Write("          local QuestLevel=GetQuestLevel(UserWorldId,QuestId)  --lay gia tri QuestLevel la buoc hien tai cua nhan vatt\r\n");
							streamWriter.Write("          if QuestLevel==1 then  --neu dang o buoc 1\r\n");
							if (任务类.QuestStage.Count == 1)
							{
								streamWriter.Write("              local controng=GetPackages(UserWorldId," + 任务类.RewardItems.Count.ToString() + ")  --vi tri con trong\r\n");
								streamWriter.Write("              if controng.Count < " + 任务类.RewardItems.Count.ToString() + " then  --neu thung do day \r\n");
								streamWriter.Write("                SendSysMsg(UserWorldId,\"Tui do khong du " + 任务类.RewardItems.Count.ToString() + " khong gian trong!\", 9, \"Chu Y\")\r\n");
								streamWriter.Write("                SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)\r\n");
								streamWriter.Write("                return \r\n");
								streamWriter.Write("              else  --neu con cho trong\r\n");
								foreach (RequiredItems current in 任务类.RequiredItems)
								{
									streamWriter.Write(string.Concat(new string[]
									{
										"              local  bool",
										current.ItemID.ToString(),
										" = GetQuestItme(UserWorldId, ",
										current.ItemID.ToString(),
										", ",
										current.ItemAmmount.ToString(),
										")  --kiem tra vat pham nhiem vu\r\n"
									}));
								}
								foreach (RequiredItems current2 in 任务类.RequiredItems)
								{
									streamWriter.Write("              if bool" + current2.ItemID.ToString() + " then --du yeu cau\r\n");
								}
								foreach (RequiredItems current3 in 任务类.RequiredItems)
								{
									streamWriter.Write("                  AddQuestItme(UserWorldId," + current3.ItemID.ToString() + ",0) --xoa item nhiem vu\r\n");
								}
								streamWriter.Write("                  StatusQuest=2  --dat buoc tiep theo la 2\r\n");
								streamWriter.Write("                  AddQuest(UserWorldId,QuestId, StatusQuest)  --cho lam buoc tiep theo la: 2\r\n");
								streamWriter.Write("                  SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la: 2\r\n");
								foreach (RequiredItems arg_656_0 in 任务类.RequiredItems)
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
								if (任务类.QuestStage.Count > 1)
								{
									foreach (RequiredItems current4 in 任务类.RequiredItems)
									{
										streamWriter.Write(string.Concat(new string[]
										{
											"              local  bool",
											current4.ItemID.ToString(),
											" = GetQuestItme(UserWorldId, ",
											current4.ItemID.ToString(),
											", ",
											current4.ItemAmmount.ToString(),
											")  --kiem tra vat pham nhiem vu\r\n"
										}));
									}
									foreach (RequiredItems current5 in 任务类.RequiredItems)
									{
										streamWriter.Write("              if bool" + current5.ItemID.ToString() + " then --du yeu cau\r\n");
									}
									foreach (RequiredItems current6 in 任务类.RequiredItems)
									{
										streamWriter.Write("              AddQuestItme(UserWorldId," + current6.ItemID.ToString() + ",0) --xoa vat pham nhiem vu\r\n");
									}
									foreach (RequiredItems current7 in 任务类.QuestStage[0].RequiredItems)
									{
										if (current7.ItemAmmount != 1)
										{
											streamWriter.Write(" \r\n");
											streamWriter.Write("-- VAT PHAM ROT RA KHI DANH QUAI --\r\n");
											streamWriter.Write(string.Concat(new string[]
											{
												"-- ID VAT PHAM: ( ",
												current7.ItemID.ToString(),
												" ) -- SO LUONG: ( ",
												current7.ItemAmmount.ToString(),
												" ) -- BUOC: ( 2 ) --\r\n"
											}));
											streamWriter.Write(string.Concat(new string[]
											{
												"-- BAN DO: ( ",
												current7.MapID.ToString(),
												" ) -- X: ( ",
												current7.CoordsX.ToString(),
												" ) -- Y: ( ",
												current7.CoordsY.ToString(),
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
													current7.ItemAmmount.ToString(),
													" ) -- BUOC: ( 2 ) --\r\n"
												}));
												streamWriter.Write(string.Concat(new string[]
												{
													"-- BAN DO: ( ",
													current7.MapID.ToString(),
													" ) -- X: ( ",
													current7.CoordsX.ToString(),
													" ) -- Y: ( ",
													current7.CoordsY.ToString(),
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
													current7.ItemAmmount.ToString(),
													") --them vat pham nhiem vu cho buoc tiep theo\r\n"
												}));
											}
										}
									}
									streamWriter.Write("              StatusQuest=2 \r\n");
									streamWriter.Write("              AddQuest(UserWorldId,QuestId, StatusQuest) \r\n");
									streamWriter.Write("              SendMissionMsg(UserWorldId,QuestId, 11, StatusQuest)  --cho lam buoc tiep theo la 2\r\n");
									foreach (RequiredItems arg_B4E_0 in 任务类.RequiredItems)
									{
										streamWriter.Write("              else \r\n");
										streamWriter.Write("              SendSysMsg(UserWorldId,\"Chua dat yeu cau, quay lai sau !\", 9, \"He thong\")\r\n");
										streamWriter.Write("              SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --cho lam buoc tiep theo la 2\r\n");
										streamWriter.Write("              end \r\n");
									}
									for (int j = 0; j < 任务类.QuestStage.Count - 1; j++)
									{
										streamWriter.Write("          elseif QuestLevel==" + (j + 2).ToString() + " then\r\n");
										if (j == 任务类.QuestStage.Count - 2)
										{
											streamWriter.Write("              local controng=GetPackages(UserWorldId," + 任务类.RewardItems.Count.ToString() + ")  --vi tri con trong\r\n");
											streamWriter.Write("              if controng.Count < " + 任务类.RewardItems.Count.ToString() + " then  --neu thung do day \r\n");
											streamWriter.Write("                SendSysMsg(UserWorldId,\"Tui do khong du " + 任务类.RewardItems.Count.ToString() + " khong gian trong!\", 9, \"Chu Y\")\r\n");
											streamWriter.Write("                SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)\r\n");
											streamWriter.Write("                return \r\n");
											streamWriter.Write("              else  --neu con cho trong\r\n");
										}
										foreach (RequiredItems current8 in 任务类.QuestStage[j].RequiredItems)
										{
											streamWriter.Write(string.Concat(new string[]
											{
												"              local  bool",
												current8.ItemID.ToString(),
												" = GetQuestItme(UserWorldId, ",
												current8.ItemID.ToString(),
												", ",
												current8.ItemAmmount.ToString(),
												")  --kiem tra vat pham nhiem vu\r\n"
											}));
										}
										foreach (RequiredItems current9 in 任务类.QuestStage[j].RequiredItems)
										{
											streamWriter.Write("              if bool" + current9.ItemID.ToString() + " then --du yeu cau\r\n");
										}
										foreach (RequiredItems current10 in 任务类.QuestStage[j].RequiredItems)
										{
											streamWriter.Write("                  AddQuestItme(UserWorldId," + current10.ItemID.ToString() + ",0) --xoa vat pham nhiem vu\r\n");
										}
										foreach (RequiredItems current11 in 任务类.QuestStage[j + 1].RequiredItems)
										{
											if (current11.ItemAmmount != 1)
											{
												streamWriter.Write(" \r\n");
												streamWriter.Write("-- VAT PHAM ROT RA KHI DANH QUAI --\r\n");
												streamWriter.Write(string.Concat(new object[]
												{
													"-- ID VAT PHAM: ( ",
													current11.ItemID.ToString(),
													" ) -- SO LUONG: ( ",
													current11.ItemAmmount.ToString(),
													" ) -- BUOC: ( ",
													j + 3,
													" ) --\r\n"
												}));
												streamWriter.Write(string.Concat(new string[]
												{
													"-- BAN DO: ( ",
													current11.MapID.ToString(),
													" ) -- X: ( ",
													current11.CoordsX.ToString(),
													" ) -- Y: ( ",
													current11.CoordsY.ToString(),
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
														current11.ItemAmmount.ToString(),
														" ) -- BUOC: ( ",
														j + 3,
														" ) --\r\n"
													}));
													streamWriter.Write(string.Concat(new string[]
													{
														"-- BAN DO: ( ",
														current11.MapID.ToString(),
														" ) -- X: ( ",
														current11.CoordsX.ToString(),
														" ) -- Y: ( ",
														current11.CoordsY.ToString(),
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
														current11.ItemAmmount.ToString(),
														") --them vat pham nhiem vu cho buoc tiep theo\r\n"
													}));
												}
											}
										}
										if (j + 1 != 任务类.QuestStage.Count)
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
										foreach (RequiredItems arg_11ED_0 in 任务类.QuestStage[j].RequiredItems)
										{
											streamWriter.Write("              else \r\n");
											streamWriter.Write("                  SendSysMsg(UserWorldId,\"Chua dat yeu cau, quay lai sau !\", 9, \"He thong\")\r\n");
											streamWriter.Write("                  SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest) \r\n");
											streamWriter.Write("              end\r\n");
										}
										if (j == 任务类.QuestStage.Count - 2)
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
							streamWriter.Write("      if Player.Player_FLD_LEVEL<" + 任务类.QuestLevel.ToString() + " then  \r\n");
							streamWriter.Write("          SendSysMsg(UserWorldId,\"Ban phai dat cap do " + 任务类.QuestLevel.ToString() + " moi co the nhan nhiem vu !\", 9, \"He thong\")\r\n");
							streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)  --chua dat yeu cau, quay lai sau\r\n");
							streamWriter.Write("      else\r\n");
							int num = 任务类.QuestStage.Count + 1;
							streamWriter.Write("         if QuestLevel==" + num + " then \r\n");
							streamWriter.Write("            SendMissionMsg(UserWorldId,QuestId, 22, StatusQuest) \r\n");
							streamWriter.Write("         else\r\n");
							foreach (RequiredItems current12 in 任务类.RequiredItems)
							{
								if (current12.ItemAmmount != 1)
								{
									streamWriter.Write(" \r\n");
									streamWriter.Write("-- VAT PHAM ROT RA KHI DANH QUAI --\r\n");
									streamWriter.Write(string.Concat(new string[]
									{
										"-- ID VAT PHAM: ( ",
										current12.ItemID.ToString(),
										" ) -- SO LUONG: ( ",
										current12.ItemAmmount.ToString(),
										" ) -- BUOC: ( 1 ) --\r\n"
									}));
									streamWriter.Write(string.Concat(new string[]
									{
										"-- BAN DO: ( ",
										current12.MapID.ToString(),
										" ) -- X: ( ",
										current12.CoordsX.ToString(),
										" ) -- Y: ( ",
										current12.CoordsY.ToString(),
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
											current12.ItemAmmount.ToString(),
											" ) -- BUOC: ( 1 ) --\r\n"
										}));
										streamWriter.Write(string.Concat(new string[]
										{
											"-- BAN DO: ( ",
											current12.MapID.ToString(),
											" ) -- X: ( ",
											current12.CoordsX.ToString(),
											" ) -- Y: ( ",
											current12.CoordsY.ToString(),
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
											current12.ItemAmmount.ToString(),
											") --them vat pham nhiem vu cho buoc tiep theo\r\n"
										}));
									}
								}
							}
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
							int num2 = 任务类.QuestStage.Count + 1;
							streamWriter.Write("      if QuestLevel==" + num2 + " then\r\n");
							streamWriter.Write("      local controng=GetPackages(UserWorldId," + 任务类.RewardItems.Count.ToString() + ")  --vi tri con trong\r\n");
							streamWriter.Write("        if controng.Count < " + 任务类.RewardItems.Count.ToString() + " then  --neu thung do day \r\n");
							streamWriter.Write("          SendSysMsg(UserWorldId,\"Tui do khong du " + 任务类.RewardItems.Count.ToString() + " khong gian trong!\", 9, \"Chu Y\")\r\n");
							streamWriter.Write("          SendMissionMsg(UserWorldId,QuestId, 12, StatusQuest)\r\n");
							streamWriter.Write("          return \r\n");
							streamWriter.Write("        else  --neu con cho trong\r\n");
							if (任务类.RewardItems.Count > 0)
							{
								foreach (任务RewardItems类 current13 in 任务类.RewardItems)
								{
									int itemID = current13.ItemID;
									if (itemID <= 800000029)
									{
										if (itemID <= 9001215)
										{
											if (itemID == 9000120)
											{
												streamWriter.Write("                 Addexporll(UserWorldId," + current13.ItemID + ",10800000) \r\n");
												continue;
											}
											switch (itemID)
											{
											case 9001214:
												streamWriter.Write("                 Addexporll(UserWorldId," + current13.ItemID + ",10800000) \r\n");
												continue;
											case 9001215:
												streamWriter.Write("                 Addexporll(UserWorldId," + current13.ItemID + ",10800000) \r\n");
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
													current13.ItemAmmount.ToString(),
													")  --vi tri con trong\r\n"
												}));
												streamWriter.Write("                  local chiso=math.random(100005,100011) \r\n");
												for (int k = 0; k < current13.ItemAmmount; k++)
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
													current13.ItemAmmount.ToString(),
													")  --vi tri con trong\r\n"
												}));
												streamWriter.Write("                  local chiso=math.random(200001,200004) \r\n");
												for (int l = 0; l < current13.ItemAmmount; l++)
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
													current13.ItemAmmount.ToString(),
													")  --vi tri con trong\r\n"
												}));
												for (int m = 0; m < current13.ItemAmmount; m++)
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
													current13.ItemAmmount.ToString(),
													")  --vi tri con trong\r\n"
												}));
												for (int n = 0; n < current13.ItemAmmount; n++)
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
													current13.ItemAmmount.ToString(),
													")  --vi tri con trong\r\n"
												}));
												for (int num3 = 0; num3 < current13.ItemAmmount; num3++)
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
														current13.ItemAmmount.ToString(),
														")  --vi tri con trong\r\n"
													}));
													streamWriter.Write("                  local chiso=math.random(700015,700025) \r\n");
													for (int num4 = 0; num4 < current13.ItemAmmount; num4++)
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
														current13.ItemAmmount.ToString(),
														")  --vi tri con trong\r\n"
													}));
													streamWriter.Write("                  local chiso=math.random(200005,2000015) \r\n");
													for (int num5 = 0; num5 < current13.ItemAmmount; num5++)
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
														current13.ItemAmmount.ToString(),
														")  --vi tri con trong\r\n"
													}));
													streamWriter.Write("                  local chiso=math.random(1000012,1000018) \r\n");
													for (int num6 = 0; num6 < current13.ItemAmmount; num6++)
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
														current13.ItemAmmount.ToString(),
														")  --vi tri con trong\r\n"
													}));
													streamWriter.Write("                  local chiso=math.random(700005,700015) \r\n");
													for (int num7 = 0; num7 < current13.ItemAmmount; num7++)
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
														current13.ItemAmmount.ToString(),
														")  --vi tri con trong\r\n"
													}));
													for (int num8 = 0; num8 < current13.ItemAmmount; num8++)
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
												streamWriter.Write("                  AddExpToCharacter(UserWorldId," + current13.ItemAmmount.ToString() + ") \r\n");
												continue;
											case 909000002:
												streamWriter.Write("                  AddKiToCharacter(UserWorldId," + current13.ItemAmmount.ToString() + ") \r\n");
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
												streamWriter.Write("                  AddMoneyToCharacter(UserWorldId," + current13.ItemAmmount.ToString() + ") \r\n");
												streamWriter.Write("                  SendSysMsg(UserWorldId,\"Nhan duoc " + current13.ItemAmmount.ToString() + " tien vang!\", 9, \"He thong\")\r\n");
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
														current13.ItemAmmount.ToString(),
														")  --vi tri con trong\r\n"
													}));
													for (int num9 = 0; num9 < current13.ItemAmmount; num9++)
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
														current13.ItemAmmount.ToString(),
														")  --vi tri con trong\r\n"
													}));
													for (int num10 = 0; num10 < current13.ItemAmmount; num10++)
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
														current13.ItemAmmount.ToString(),
														")  --vi tri con trong\r\n"
													}));
													for (int num11 = 0; num11 < current13.ItemAmmount; num11++)
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
													current13.ItemAmmount.ToString(),
													")  --vi tri con trong\r\n"
												}));
												for (int num12 = 0; num12 < current13.ItemAmmount; num12++)
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
													current13.ItemAmmount.ToString(),
													")  --vi tri con trong\r\n"
												}));
												for (int num13 = 0; num13 < current13.ItemAmmount; num13++)
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
													current13.ItemAmmount.ToString(),
													")  --vi tri con trong\r\n"
												}));
												for (int num14 = 0; num14 < current13.ItemAmmount; num14++)
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
													current13.ItemAmmount.ToString(),
													")  --vi tri con trong\r\n"
												}));
												for (int num15 = 0; num15 < current13.ItemAmmount; num15++)
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
											current13.ItemAmmount.ToString(),
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
											current13.ItemAmmount.ToString(),
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
				}
				MessageBox.Show("Tổng số nhiệm vụ được tạo ra ：" + count.ToString() + " kịch bản LUA");
			}
		}

            private void lua일괄제작ToolStripMenuItem_Click(object sender, EventArgs e)
            {
                  AllConvert();
            }

            private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
            {

            }
      }
}
