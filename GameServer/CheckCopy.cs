using ns11;
using ns2;
using ns3;
using RxjhServer;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ns6
{
	internal class CheckCopy : Form
	{
		private Button button1;

		private DataTable dataTable_0;

		private DataTable dataTable_1;

		private DataTable dataTable_2;

		private DataTable dataTable_3;

		private DataTable dataTable_4;

		private DataTable dataTable_5;

		private GroupBox groupBox1;

		private GroupBox groupBox2;

		private IContainer icontainer_0 = new System.ComponentModel.Container();

		private MenuStrip menuStrip1;

		private RadioButton radioButton2;

		private RadioButton radioButton3;

		private RadioButton radioButton4;

		private RadioButton radioButton7;

		private TextBox textBox1;

		private ToolStripMenuItem 帮助ToolStripMenuItem;

		private ToolStripMenuItem 说明ToolStripMenuItem;

		public CheckCopy()
		{
			this.InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.dataTable_2 = null;
			this.dataTable_0 = null;
			this.dataTable_4 = null;
			this.dataTable_3 = null;
			this.dataTable_1 = null;
			this.dataTable_5 = null;
			if (World.allConnectedChars.Count > 0)
			{
				MessageBox.Show("有人物在线不能查询!", "提示");
				return;
			}
			this.method_0("开始查询....");
			this.button1.Enabled = false;
			string str = string.Format("select FLD_ID,FLD_NAME,FLD_WEARITEM,FLD_ITEM from [TBL_XWWL_Char]", new object[0]);
			string str1 = string.Format("select FLD_ID,FLD_NAME,FLD_ITEM from [TBL_XWWL_Warehouse]", new object[0]);
			string str2 = string.Format("select FLD_ID,FLD_ITEM from [TBL_XWWL_PublicWarehouse]", new object[0]);
			this.dataTable_2 = DBA.GetDBToDataTable(str, "GameServer");
			this.dataTable_0 = DBA.GetDBToDataTable(str1, "GameServer");
			this.dataTable_4 = DBA.GetDBToDataTable(str2, "GameServer");
			if (this.radioButton2.Checked || this.radioButton7.Checked)
			{
				if (this.dataTable_2.Rows.Count != 0)
				{
					if (this.radioButton2.Checked)
					{
						for (int i = 0; i < this.dataTable_2.Rows.Count; i++)
						{
							byte[] item = (byte[])this.dataTable_2.Rows[i]["FLD_ITEM"];
							string str3 = this.dataTable_2.Rows[i]["FLD_ID"].ToString();
							string str4 = this.dataTable_2.Rows[i]["FLD_NAME"].ToString();
							for (int j = 0; j < 36; j++)
							{
								byte[] numArray = new byte[4];
								Buffer.BlockCopy(item, j * 73, numArray, 0, 4);
								int num = BitConverter.ToInt32(numArray, 0);
								if (num != 0)
								{
									try
									{
										ThreadParameter threadParameter = new ThreadParameter(num, str3, str4, 0);
										ThreadPool.QueueUserWorkItem(new WaitCallback(this.method_1), threadParameter);
									}
									catch (Exception exception)
									{
										this.method_0(string.Concat("查询背包线程出错", exception.ToString()));
									}
								}
							}
						}
					}
					else
					{
						for (int k = 0; k < this.dataTable_2.Rows.Count; k++)
						{
							byte[] item1 = (byte[])this.dataTable_2.Rows[k]["FLD_WEARITEM"];
							string str5 = this.dataTable_2.Rows[k]["FLD_ID"].ToString();
							string str6 = this.dataTable_2.Rows[k]["FLD_NAME"].ToString();
							for (int l = 0; l < 15; l++)
							{
								byte[] numArray1 = new byte[4];
								Buffer.BlockCopy(item1, l * 73, numArray1, 0, 4);
								int num1 = BitConverter.ToInt32(numArray1, 0);
								if (num1 != 0)
								{
									try
									{
										ThreadParameter threadParameter1 = new ThreadParameter(num1, str5, str6, 1);
										ThreadPool.QueueUserWorkItem(new WaitCallback(this.method_1), threadParameter1);
									}
									catch (Exception exception1)
									{
										this.method_0(string.Concat("查询已穿装备线程出错", exception1.ToString()));
									}
								}
							}
						}
					}
				}
				this.dataTable_2.Dispose();
			}
			else if (this.radioButton3.Checked)
			{
				if (this.dataTable_0.Rows.Count != 0)
				{
					for (int m = 0; m < this.dataTable_0.Rows.Count; m++)
					{
						byte[] item2 = (byte[])this.dataTable_0.Rows[m]["FLD_ITEM"];
						for (int n = 0; n < 60; n++)
						{
							byte[] numArray2 = new byte[4];
							string str7 = this.dataTable_0.Rows[m]["FLD_ID"].ToString();
							string str8 = this.dataTable_0.Rows[m]["FLD_NAME"].ToString();
							Buffer.BlockCopy(item2, n * 73, numArray2, 0, 4);
							int num2 = BitConverter.ToInt32(numArray2, 0);
							if (num2 != 0)
							{
								try
								{
									ThreadParameter threadParameter2 = new ThreadParameter(num2, str7, str8, 2);
									ThreadPool.QueueUserWorkItem(new WaitCallback(this.method_1), threadParameter2);
								}
								catch (Exception exception2)
								{
									this.method_0(string.Concat("查询个人仓库线程出错", exception2.ToString()));
								}
							}
						}
					}
				}
				this.dataTable_0.Dispose();
			}
			else
			{
				if (this.dataTable_4.Rows.Count != 0)
				{
					for (int o = 0; o < this.dataTable_4.Rows.Count; o++)
					{
						byte[] item3 = (byte[])this.dataTable_4.Rows[o]["FLD_ITEM"];
						for (int p = 0; p < 60; p++)
						{
							byte[] numArray3 = new byte[4];
							string str9 = this.dataTable_4.Rows[o]["FLD_ID"].ToString();
							Buffer.BlockCopy(item3, p * 73, numArray3, 0, 4);
							int num3 = BitConverter.ToInt32(numArray3, 0);
							if (num3 != 0)
							{
								try
								{
									ThreadParameter threadParameter3 = new ThreadParameter(num3, str9, "", 3);
									ThreadPool.QueueUserWorkItem(new WaitCallback(this.method_1), threadParameter3);
								}
								catch (Exception exception3)
								{
									this.method_0(string.Concat("查询综合仓库线程出错", exception3.ToString()));
								}
							}
						}
					}
				}
				this.dataTable_4.Dispose();
			}
			this.button1.Enabled = true;
		}

		private void CheckCopy_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				if (this.dataTable_2 != null)
				{
					this.dataTable_2 = null;
				}
				if (this.dataTable_3 != null)
				{
					this.dataTable_3 = null;
				}
				if (this.dataTable_0 != null)
				{
					this.dataTable_0 = null;
				}
				if (this.dataTable_1 != null)
				{
					this.dataTable_1 = null;
				}
				if (this.dataTable_4 != null)
				{
					this.dataTable_4 = null;
				}
				if (this.dataTable_5 != null)
				{
					this.dataTable_5 = null;
				}
			}
			catch
			{
			}
		}

		private void CheckCopy_Load(object sender, EventArgs e)
		{
			ThreadPool.SetMinThreads(100, 100);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.groupBox1 = new GroupBox();
			this.radioButton7 = new RadioButton();
			this.radioButton4 = new RadioButton();
			this.radioButton3 = new RadioButton();
			this.radioButton2 = new RadioButton();
			this.groupBox2 = new GroupBox();
			this.textBox1 = new TextBox();
			this.button1 = new Button();
			this.menuStrip1 = new MenuStrip();
			this.说明ToolStripMenuItem = new ToolStripMenuItem();
			this.帮助ToolStripMenuItem = new ToolStripMenuItem();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			base.SuspendLayout();
			this.groupBox1.Controls.Add(this.radioButton7);
			this.groupBox1.Controls.Add(this.radioButton4);
			this.groupBox1.Controls.Add(this.radioButton3);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Location = new Point(33, 29);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(496, 67);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "查询类型";
			this.radioButton7.AutoSize = true;
			this.radioButton7.Location = new Point(91, 33);
			this.radioButton7.Name = "radioButton7";
			this.radioButton7.Size = new System.Drawing.Size(73, 18);
			this.radioButton7.TabIndex = 5;
			this.radioButton7.TabStop = true;
			this.radioButton7.Text = "已穿装备";
			this.radioButton7.UseVisualStyleBackColor = true;
			this.radioButton4.AutoSize = true;
			this.radioButton4.Location = new Point(283, 33);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(73, 18);
			this.radioButton4.TabIndex = 3;
			this.radioButton4.TabStop = true;
			this.radioButton4.Text = "综合仓库";
			this.radioButton4.UseVisualStyleBackColor = true;
			this.radioButton3.AutoSize = true;
			this.radioButton3.Location = new Point(187, 33);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(73, 18);
			this.radioButton3.TabIndex = 2;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "个人仓库";
			this.radioButton3.UseVisualStyleBackColor = true;
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new Point(19, 33);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(49, 18);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "背包";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Location = new Point(33, 111);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(496, 418);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "查询记录";
			this.textBox1.Location = new Point(19, 22);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(458, 376);
			this.textBox1.TabIndex = 0;
			this.button1.Location = new Point(435, 535);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 25);
			this.button1.TabIndex = 4;
			this.button1.Text = "开始查询";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.menuStrip1.Items.AddRange(new ToolStripItem[] { this.说明ToolStripMenuItem });
			this.menuStrip1.Location = new Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(570, 24);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			this.说明ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.帮助ToolStripMenuItem });
			this.说明ToolStripMenuItem.Name = "说明ToolStripMenuItem";
			this.说明ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.说明ToolStripMenuItem.Text = "说明";
			this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
			this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
			this.帮助ToolStripMenuItem.Text = "帮助";
			this.帮助ToolStripMenuItem.Click += new EventHandler(this.帮助ToolStripMenuItem_Click);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(570, 573);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.groupBox2);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.menuStrip1);
			base.MainMenuStrip = this.menuStrip1;
			base.Name = "CheckCopy";
			this.Text = "查复制";
			base.FormClosing += new FormClosingEventHandler(this.CheckCopy_FormClosing);
			base.Load += new EventHandler(this.CheckCopy_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void method_0(string string_0)
		{
			if (!this.textBox1.InvokeRequired)
			{
				this.textBox1.Text = string.Concat(this.textBox1.Text, "\r\n", string_0);
				return;
			}
			CheckCopy.Delegate8 delegate8 = new CheckCopy.Delegate8(this.method_0);
			base.Invoke(delegate8, new object[] { string.Concat("\r\n", string_0) });
		}

		private void method_1(object object_0)
		{
			int num;
			ThreadParameter object0 = (ThreadParameter)object_0;
			string str = "";
			string str1 = string.Format("select FLD_ID,FLD_NAME,FLD_WEARITEM,FLD_ITEM from [TBL_XWWL_Char] where FLD_NAME<>'{0}'", object0.name);
			string str2 = string.Format("select FLD_ID,FLD_NAME,FLD_ITEM from [TBL_XWWL_Warehouse] where FLD_NAME<>'{0}'", object0.name);
			string str3 = string.Format("select FLD_ID,FLD_ITEM from [TBL_XWWL_PublicWarehouse] where FLD_ID<>'{0}'", object0.id);
			switch (object0.类型)
			{
				case 0:
				{
					str = "背包";
					break;
				}
				case 1:
				{
					str = "已穿装备";
					break;
				}
				case 2:
				{
					str = "个人仓库";
					break;
				}
				case 3:
				{
					str1 = "select FLD_ID,FLD_NAME,FLD_WEARITEM,FLD_ITEM from [TBL_XWWL_Char]";
					str2 = "select FLD_ID,FLD_NAME,FLD_ITEM from [TBL_XWWL_Warehouse]";
					str = "综合仓库";
					break;
				}
			}
			this.dataTable_3 = DBA.GetDBToDataTable(str1, "GameServer");
			this.dataTable_1 = DBA.GetDBToDataTable(str2, "GameServer");
			this.dataTable_5 = DBA.GetDBToDataTable(str3, "GameServer");
			if (this.dataTable_3.Rows.Count != 0)
			{
				for (int i = 0; i < this.dataTable_3.Rows.Count; i++)
				{
					byte[] item = (byte[])this.dataTable_3.Rows[i]["FLD_ITEM"];
					byte[] numArray = (byte[])this.dataTable_3.Rows[i]["FLD_WEARITEM"];
					this.dataTable_3.Rows[i]["FLD_ID"].ToString();
					string str4 = this.dataTable_3.Rows[i]["FLD_NAME"].ToString();
					for (int j = 0; j < 36; j++)
					{
						byte[] numArray1 = new byte[4];
						Buffer.BlockCopy(item, j * 73, numArray1, 0, 4);
						int num1 = BitConverter.ToInt32(numArray1, 0);
						if (num1 != 0 && num1 == object0.全局ID)
						{
							string[] strArrays = new string[] { "发现复制装备,Item_toan_bo_ID[", null, null, null, null, null, null, null };
							num = object0.全局ID;
							strArrays[1] = num.ToString();
							strArrays[2] = "],在人物【";
							strArrays[3] = str4;
							strArrays[4] = "】的背包栏和人物【";
							strArrays[5] = object0.name;
							strArrays[6] = "】的";
							strArrays[7] = str;
							this.method_0(string.Concat(strArrays));
						}
					}
					for (int k = 0; k < 15; k++)
					{
						byte[] numArray2 = new byte[4];
						Buffer.BlockCopy(numArray, k * 73, numArray2, 0, 4);
						int num2 = BitConverter.ToInt32(numArray2, 0);
						if (num2 != 0 && num2 == object0.全局ID)
						{
							string[] strArrays1 = new string[] { "发现复制装备,Item_toan_bo_ID[", null, null, null, null, null, null, null };
							num = object0.全局ID;
							strArrays1[1] = num.ToString();
							strArrays1[2] = "],在人物【";
							strArrays1[3] = str4;
							strArrays1[4] = "】的已穿装备栏和人物【";
							strArrays1[5] = object0.name;
							strArrays1[6] = "】的";
							strArrays1[7] = str;
							this.method_0(string.Concat(strArrays1));
						}
					}
				}
			}
			this.dataTable_3.Dispose();
			if (this.dataTable_1.Rows.Count != 0)
			{
				for (int l = 0; l < this.dataTable_1.Rows.Count; l++)
				{
					byte[] item1 = (byte[])this.dataTable_1.Rows[l]["FLD_ITEM"];
					string str5 = this.dataTable_1.Rows[l]["FLD_NAME"].ToString();
					for (int m = 0; m < 60; m++)
					{
						byte[] numArray3 = new byte[4];
						Buffer.BlockCopy(item1, m * 73, numArray3, 0, 4);
						int num3 = BitConverter.ToInt32(numArray3, 0);
						if (num3 != 0 && num3 == object0.全局ID)
						{
							string[] strArrays2 = new string[] { "发现复制装备,Item_toan_bo_ID[", null, null, null, null, null, null, null };
							num = object0.全局ID;
							strArrays2[1] = num.ToString();
							strArrays2[2] = "],在人物【";
							strArrays2[3] = str5;
							strArrays2[4] = "】的个人仓库和人物【";
							strArrays2[5] = object0.name;
							strArrays2[6] = "】的";
							strArrays2[7] = str;
							this.method_0(string.Concat(strArrays2));
						}
					}
				}
			}
			this.dataTable_1.Dispose();
			if (this.dataTable_5.Rows.Count != 0)
			{
				for (int n = 0; n < this.dataTable_5.Rows.Count; n++)
				{
					byte[] item2 = (byte[])this.dataTable_5.Rows[n]["FLD_ITEM"];
					string str6 = this.dataTable_5.Rows[n]["FLD_ID"].ToString();
					for (int o = 0; o < 60; o++)
					{
						byte[] numArray4 = new byte[4];
						Buffer.BlockCopy(item2, o * 73, numArray4, 0, 4);
						int num4 = BitConverter.ToInt32(numArray4, 0);
						if (num4 != 0 && num4 == object0.全局ID)
						{
							string[] strArrays3 = new string[] { "发现复制装备,Item_toan_bo_ID[", null, null, null, null, null, null, null };
							num = object0.全局ID;
							strArrays3[1] = num.ToString();
							strArrays3[2] = "],在帐号【";
							strArrays3[3] = str6;
							strArrays3[4] = "】的综合仓库和人物【";
							strArrays3[5] = object0.name;
							strArrays3[6] = "】的";
							strArrays3[7] = str;
							this.method_0(string.Concat(strArrays3));
						}
					}
				}
			}
			this.dataTable_5.Dispose();
		}

		private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("数据量大的查询时间比较长,必须是停服维护(关闭LoginServer且无玩家登录)才能查询", "帮助");
		}

		public delegate void Delegate8(string str);
	}
}