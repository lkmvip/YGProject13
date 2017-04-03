using ns10;
using ns3;
using ns9;
using RxjhServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace ns11
{
	internal class BinIP : Form
	{
		private Button button1;

		private CheckBox checkBox1;

		private CheckBox checkBox2;

		private CheckBox checkBox3;

		private CheckBox checkBox4;

		private CheckBox checkBox5;

		private ColumnHeader columnHeader_0;

		private ColumnHeader columnHeader_1;

		private ColumnHeader columnHeader_2;

		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1_1;

		private GroupBox groupBox1;

		private GroupBox groupBox2;

		private GroupBox groupBox3;

		private GroupBox groupBox4;

		private GroupBox groupBox5;

		private IContainer icontainer_0;

		private Label label1;

		private Label label2;

		private Label label3;

		private Label label4;

		private Label label5;

		private Label label6;

		private ListView listView1;

		private ListView listView2;

		private NumericUpDown numericUpDown1;

		private NumericUpDown numericUpDown2;

		private NumericUpDown numericUpDown3;

		private ToolStripMenuItem toolStripMenuItem1;

		private IContainer components;

		private ToolStripMenuItem 删除ToolStripMenuItem;

		public BinIP()
		{
			this.InitializeComponent();
		}

		private void BinIP_Load(object sender, EventArgs e)
		{
			this.method_1();
			this.method_2();
			this.method_0();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			World.IP_closure = this.checkBox1.Checked;
			World.Game_landing_port_maximum_number_of_connections = (int)this.numericUpDown1.Value;
			World.Tu_dong_lien_tiep_Thoi_gian = (int)this.numericUpDown2.Value;
			World.Tro_choi_do_bo_cang_lon_nhat_lien_tiep_Thoi_gian_so = (int)this.numericUpDown3.Value;
			World.Automatically_open_connection = this.checkBox5.Checked;
			World.Disconnect = this.checkBox2.Checked;
			World.Join_filter_list = this.checkBox3.Checked;
			World.Close_connection = this.checkBox4.Checked;
			bool @checked = this.checkBox1.Checked;
			Config.smethod_0("GameServer", "封IP", @checked.ToString());
			@checked = this.checkBox5.Checked;
			Config.smethod_0("GameServer", "自动开启连接", @checked.ToString());
			@checked = this.checkBox2.Checked;
			Config.smethod_0("GameServer", "断开连接", @checked.ToString());
			@checked = this.checkBox3.Checked;
			Config.smethod_0("GameServer", "加入过滤列表", @checked.ToString());
			@checked = this.checkBox4.Checked;
			Config.smethod_0("GameServer", "关闭连接", @checked.ToString());
			decimal value = this.numericUpDown1.Value;
			Config.smethod_0("GameServer", "游戏登陆端口最大连接数", value.ToString());
			value = this.numericUpDown2.Value;
			Config.smethod_0("GameServer", "自动连接时间", value.ToString());
			value = this.numericUpDown3.Value;
			Config.smethod_0("GameServer", "游戏登陆端口最大连接时间数", value.ToString());
			base.Close();
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
			this.components = new System.ComponentModel.Container();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.删除ToolStripMenuItem = new ToolStripMenuItem();
			this.button1 = new Button();
			this.groupBox1 = new GroupBox();
			this.listView2 = new ListView();
			this.columnHeader_2 = new ColumnHeader();
			this.columnHeader_0 = new ColumnHeader();
			this.contextMenuStrip1_1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem1 = new ToolStripMenuItem();
			this.groupBox2 = new GroupBox();
			this.listView1 = new ListView();
			this.columnHeader_1 = new ColumnHeader();
			this.groupBox3 = new GroupBox();
			this.label5 = new Label();
			this.numericUpDown3 = new NumericUpDown();
			this.label6 = new Label();
			this.groupBox5 = new GroupBox();
			this.label4 = new Label();
			this.label3 = new Label();
			this.numericUpDown2 = new NumericUpDown();
			this.checkBox5 = new CheckBox();
			this.groupBox4 = new GroupBox();
			this.checkBox4 = new CheckBox();
			this.checkBox3 = new CheckBox();
			this.checkBox2 = new CheckBox();
			this.checkBox1 = new CheckBox();
			this.label2 = new Label();
			this.numericUpDown1 = new NumericUpDown();
			this.label1 = new Label();
			this.contextMenuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.contextMenuStrip1_1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((ISupportInitialize)this.numericUpDown3).BeginInit();
			this.groupBox5.SuspendLayout();
			((ISupportInitialize)this.numericUpDown2).BeginInit();
			this.groupBox4.SuspendLayout();
			((ISupportInitialize)this.numericUpDown1).BeginInit();
			base.SuspendLayout();
			this.contextMenuStrip1.Items.AddRange(new ToolStripItem[] { this.删除ToolStripMenuItem });
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(95, 26);
			this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
			this.删除ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
			this.删除ToolStripMenuItem.Text = "删除";
			this.删除ToolStripMenuItem.Click += new EventHandler(this.删除ToolStripMenuItem_Click);
			this.button1.Location = new Point(79, 269);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 25);
			this.button1.TabIndex = 4;
			this.button1.Text = "确定";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.groupBox1.Controls.Add(this.listView2);
			this.groupBox1.Location = new Point(8, 10);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(151, 303);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "当前连接";
			this.listView2.Columns.AddRange(new ColumnHeader[] { this.columnHeader_2, this.columnHeader_0 });
			this.listView2.ContextMenuStrip = this.contextMenuStrip1_1;
			this.listView2.Dock = DockStyle.Fill;
			this.listView2.FullRowSelect = true;
			this.listView2.GridLines = true;
			this.listView2.Location = new Point(3, 18);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(145, 281);
			this.listView2.TabIndex = 4;
			this.listView2.UseCompatibleStateImageBehavior = false;
			this.listView2.View = View.Details;
			this.columnHeader_2.Text = "ID";
			this.columnHeader_2.Width = 30;
			this.columnHeader_0.Text = "IP";
			this.columnHeader_0.Width = 150;
			this.contextMenuStrip1_1.Items.AddRange(new ToolStripItem[] { this.toolStripMenuItem1 });
			this.contextMenuStrip1_1.Name = "contextMenuStrip1";
			this.contextMenuStrip1_1.Size = new System.Drawing.Size(119, 26);
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
			this.toolStripMenuItem1.Text = "断开连接";
			this.toolStripMenuItem1.Click += new EventHandler(this.toolStripMenuItem1_Click);
			this.groupBox2.Controls.Add(this.listView1);
			this.groupBox2.Location = new Point(165, 10);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(156, 303);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "过滤列表";
			this.listView1.Columns.AddRange(new ColumnHeader[] { this.columnHeader_1 });
			this.listView1.ContextMenuStrip = this.contextMenuStrip1;
			this.listView1.Dock = DockStyle.Fill;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.Location = new Point(3, 18);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(150, 281);
			this.listView1.TabIndex = 5;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = View.Details;
			this.columnHeader_1.Text = "IP";
			this.columnHeader_1.Width = 150;
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.numericUpDown3);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.groupBox5);
			this.groupBox3.Controls.Add(this.groupBox4);
			this.groupBox3.Controls.Add(this.checkBox1);
			this.groupBox3.Controls.Add(this.button1);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.numericUpDown1);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Location = new Point(327, 10);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(162, 303);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "攻击保护";
			this.label5.AutoSize = true;
			this.label5.Location = new Point(137, 70);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(19, 13);
			this.label5.TabIndex = 18;
			this.label5.Text = "秒";
			this.numericUpDown3.Location = new Point(65, 66);
			this.numericUpDown3.Maximum = new decimal(new int[] { 60000, 0, 0, 0 });
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(60, 20);
			this.numericUpDown3.TabIndex = 17;
			this.numericUpDown3.Value = new decimal(new int[] { 10000, 0, 0, 0 });
			this.label6.AutoSize = true;
			this.label6.Location = new Point(6, 70);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 13);
			this.label6.TabIndex = 16;
			this.label6.Text = "连接时间";
			this.groupBox5.Controls.Add(this.label4);
			this.groupBox5.Controls.Add(this.label3);
			this.groupBox5.Controls.Add(this.numericUpDown2);
			this.groupBox5.Controls.Add(this.checkBox5);
			this.groupBox5.Location = new Point(6, 189);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(150, 74);
			this.groupBox5.TabIndex = 15;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "关闭连接";
			this.label4.AutoSize = true;
			this.label4.Location = new Point(108, 44);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(19, 13);
			this.label4.TabIndex = 17;
			this.label4.Text = "秒";
			this.label3.AutoSize = true;
			this.label3.Location = new Point(12, 44);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 16;
			this.label3.Text = "间隔时间";
			this.numericUpDown2.Location = new Point(67, 40);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(38, 20);
			this.numericUpDown2.TabIndex = 15;
			this.numericUpDown2.Value = new decimal(new int[] { 10, 0, 0, 0 });
			this.checkBox5.AutoSize = true;
			this.checkBox5.Location = new Point(12, 18);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(98, 18);
			this.checkBox5.TabIndex = 14;
			this.checkBox5.Text = "自动开启连接";
			this.checkBox5.UseVisualStyleBackColor = true;
			this.groupBox4.Controls.Add(this.checkBox4);
			this.groupBox4.Controls.Add(this.checkBox3);
			this.groupBox4.Controls.Add(this.checkBox2);
			this.groupBox4.Location = new Point(6, 92);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(150, 86);
			this.groupBox4.TabIndex = 7;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "攻击操作";
			this.checkBox4.AutoSize = true;
			this.checkBox4.Location = new Point(12, 59);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(74, 18);
			this.checkBox4.TabIndex = 14;
			this.checkBox4.Text = "关闭连接";
			this.checkBox4.UseVisualStyleBackColor = true;
			this.checkBox3.AutoSize = true;
			this.checkBox3.Location = new Point(13, 36);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(98, 18);
			this.checkBox3.TabIndex = 13;
			this.checkBox3.Text = "加入过滤列表";
			this.checkBox3.UseVisualStyleBackColor = true;
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new Point(14, 15);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(74, 18);
			this.checkBox2.TabIndex = 12;
			this.checkBox2.Text = "断开连接";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new Point(11, 18);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(98, 18);
			this.checkBox1.TabIndex = 6;
			this.checkBox1.Text = "开启攻击保护";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.label2.AutoSize = true;
			this.label2.Location = new Point(109, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "连接/IP";
			this.numericUpDown1.Location = new Point(65, 40);
			this.numericUpDown1.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(38, 20);
			this.numericUpDown1.TabIndex = 1;
			this.numericUpDown1.Value = new decimal(new int[] { 5, 0, 0, 0 });
			this.label1.AutoSize = true;
			this.label1.Location = new Point(6, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "连接限制";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(496, 317);
			base.Controls.Add(this.groupBox3);
			base.Controls.Add(this.groupBox2);
			base.Controls.Add(this.groupBox1);
			base.MaximizeBox = false;
			base.Name = "BinIP";
			this.Text = "防CC设置";
			base.Load += new EventHandler(this.BinIP_Load);
			this.contextMenuStrip1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.contextMenuStrip1_1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((ISupportInitialize)this.numericUpDown3).EndInit();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			((ISupportInitialize)this.numericUpDown2).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((ISupportInitialize)this.numericUpDown1).EndInit();
			base.ResumeLayout(false);
		}

		public void method_0()
		{
			this.checkBox1.Checked = World.IP_closure;
			this.numericUpDown1.Value = World.Game_landing_port_maximum_number_of_connections;
			this.numericUpDown2.Value = World.Tu_dong_lien_tiep_Thoi_gian;
			this.numericUpDown3.Value = World.Tro_choi_do_bo_cang_lon_nhat_lien_tiep_Thoi_gian_so;
			this.checkBox5.Checked = World.Automatically_open_connection;
			this.checkBox2.Checked = World.Disconnect;
			this.checkBox3.Checked = World.Join_filter_list;
			this.checkBox4.Checked = World.Close_connection;
		}

		public void method_1()
		{
			this.listView1.Items.Clear();
			foreach (IPAddress list17 in World.list_17)
			{
				string[] str = new string[] { list17.ToString() };
				this.listView1.Items.Insert(this.listView1.Items.Count, new ListViewItem(str));
			}
		}

		public void method_2()
		{
			this.listView2.Items.Clear();
			foreach (NetState value in World.threadSafeDictionary_0.Values)
			{
				string[] str = new string[] { value.int_3.ToString(), value.ToString() };
				this.listView2.Items.Insert(this.listView2.Items.Count, new ListViewItem(str));
			}
		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			NetState netState;
			if (this.listView2.SelectedItems.Count > 0)
			{
				for (int i = 0; i < this.listView2.SelectedItems.Count; i++)
				{
					string text = this.listView2.SelectedItems[i].SubItems[0].Text;
					if (World.threadSafeDictionary_0.TryGetValue(int.Parse(text), out netState))
					{
						netState.Dispose();
					}
					this.method_2();
				}
			}
		}

		private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.listView1.SelectedItems.Count > 0)
			{
				for (int i = 0; i < this.listView1.SelectedItems.Count; i++)
				{
					string text = this.listView1.SelectedItems[i].SubItems[0].Text;
					World.list_17.Remove(IPAddress.Parse(text));
					this.method_1();
				}
			}
		}
	}
}