using ns1;
using ns10;
using ns3;
using ns9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns0
{
	internal class FormUser : Form
	{
		private ColumnHeader columnHeader_0;

		private ColumnHeader columnHeader_1;

		private ColumnHeader columnHeader_10;

		private ColumnHeader columnHeader_11;

		private ColumnHeader columnHeader_12;

		private ColumnHeader columnHeader_13;

		private ColumnHeader columnHeader_14;

		private ColumnHeader columnHeader_15;

		private ColumnHeader columnHeader_16;

		private ColumnHeader columnHeader_17;

		private ColumnHeader columnHeader_18;

		private ColumnHeader columnHeader_2;

		private ColumnHeader columnHeader_3;

		private ColumnHeader columnHeader_4;

		private ColumnHeader columnHeader_5;

		private ColumnHeader columnHeader_6;

		private ColumnHeader columnHeader_7;

		private ColumnHeader columnHeader_8;

		private ColumnHeader columnHeader_9;

		private IContainer icontainer_0 = new System.ComponentModel.Container();

		private ListView listView1;

		private ListView listView2;

		private SplitContainer splitContainer1;

		public FormUser()
		{
			this.InitializeComponent();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void FormUser组队_Load(object sender, EventArgs e)
		{
			foreach (TO_DOI_CLASS value in World.W_TO_DOI.Values)
			{
				string[] str = new string[2];
				try
				{
					str[0] = value.int_0.ToString();
					str[1] = value.dictionary_0.Count.ToString();
					this.listView1.Items.Insert(this.listView1.Items.Count, new ListViewItem(str));
				}
				catch
				{
				}
			}
		}

		private void InitializeComponent()
		{
			this.listView1 = new ListView();
			this.columnHeader_0 = new ColumnHeader();
			this.columnHeader_1 = new ColumnHeader();
			this.splitContainer1 = new SplitContainer();
			this.listView2 = new ListView();
			this.columnHeader_2 = new ColumnHeader();
			this.columnHeader_3 = new ColumnHeader();
			this.columnHeader_4 = new ColumnHeader();
			this.columnHeader_5 = new ColumnHeader();
			this.columnHeader_6 = new ColumnHeader();
			this.columnHeader_7 = new ColumnHeader();
			this.columnHeader_8 = new ColumnHeader();
			this.columnHeader_9 = new ColumnHeader();
			this.columnHeader_10 = new ColumnHeader();
			this.columnHeader_11 = new ColumnHeader();
			this.columnHeader_12 = new ColumnHeader();
			this.columnHeader_13 = new ColumnHeader();
			this.columnHeader_14 = new ColumnHeader();
			this.columnHeader_15 = new ColumnHeader();
			this.columnHeader_16 = new ColumnHeader();
			this.columnHeader_17 = new ColumnHeader();
			this.columnHeader_18 = new ColumnHeader();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			base.SuspendLayout();
			this.listView1.Columns.AddRange(new ColumnHeader[] { this.columnHeader_0, this.columnHeader_1 });
			this.listView1.Dock = DockStyle.Fill;
			this.listView1.ForeColor = SystemColors.WindowText;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.Location = new Point(0, 0);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(550, 182);
			this.listView1.TabIndex = 9;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = View.Details;
			this.listView1.Click += new EventHandler(this.listView1_Click);
			this.columnHeader_0.Text = "名称";
			this.columnHeader_0.Width = 71;
			this.columnHeader_1.Text = "数据";
			this.columnHeader_1.Width = 90;
			this.splitContainer1.Dock = DockStyle.Fill;
			this.splitContainer1.Location = new Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = Orientation.Horizontal;
			this.splitContainer1.Panel1.Controls.Add(this.listView1);
			this.splitContainer1.Panel2.Controls.Add(this.listView2);
			this.splitContainer1.Size = new System.Drawing.Size(550, 403);
			this.splitContainer1.SplitterDistance = 182;
			this.splitContainer1.TabIndex = 10;
			this.listView2.Columns.AddRange(new ColumnHeader[] { this.columnHeader_2, this.columnHeader_3, this.columnHeader_4, this.columnHeader_5, this.columnHeader_6, this.columnHeader_7, this.columnHeader_8, this.columnHeader_9, this.columnHeader_10, this.columnHeader_11, this.columnHeader_12, this.columnHeader_13, this.columnHeader_14, this.columnHeader_15, this.columnHeader_16, this.columnHeader_17, this.columnHeader_18 });
			this.listView2.Dock = DockStyle.Fill;
			this.listView2.ForeColor = SystemColors.WindowText;
			this.listView2.FullRowSelect = true;
			this.listView2.GridLines = true;
			this.listView2.Location = new Point(0, 0);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(550, 217);
			this.listView2.TabIndex = 2;
			this.listView2.UseCompatibleStateImageBehavior = false;
			this.listView2.View = View.Details;
			this.columnHeader_2.Text = "序号";
			this.columnHeader_2.Width = 36;
			this.columnHeader_3.Text = "ID";
			this.columnHeader_3.Width = 66;
			this.columnHeader_4.Text = "名字";
			this.columnHeader_4.Width = 98;
			this.columnHeader_5.Text = "等级";
			this.columnHeader_5.Width = 38;
			this.columnHeader_6.Text = "HP";
			this.columnHeader_6.Width = 47;
			this.columnHeader_7.Text = "IP";
			this.columnHeader_7.Width = 113;
			this.columnHeader_8.Text = "地图";
			this.columnHeader_8.Width = 42;
			this.columnHeader_9.Text = "X";
			this.columnHeader_9.Width = 61;
			this.columnHeader_10.Text = "Y";
			this.columnHeader_10.Width = 61;
			this.columnHeader_11.Text = "攻";
			this.columnHeader_11.Width = 36;
			this.columnHeader_12.Text = "攻加";
			this.columnHeader_12.Width = 41;
			this.columnHeader_13.Text = "防";
			this.columnHeader_13.Width = 37;
			this.columnHeader_14.Text = "防加";
			this.columnHeader_14.Width = 39;
			this.columnHeader_15.Text = "气";
			this.columnHeader_15.Width = 39;
			this.columnHeader_16.Text = "ping";
			this.columnHeader_16.Width = 39;
			this.columnHeader_17.Text = "攻强";
			this.columnHeader_17.Width = 39;
			this.columnHeader_18.Text = "防强";
			this.columnHeader_18.Width = 37;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(550, 403);
			base.Controls.Add(this.splitContainer1);
			base.Name = "FormUser组队";
			this.Text = "组队列表";
			base.Load += new EventHandler(this.FormUser组队_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		private void listView1_Click(object sender, EventArgs e)
		{
			TO_DOI_CLASS tODOICLAss;
			int userSessionID;
			if (this.listView1.SelectedItems.Count > 0 && World.W_TO_DOI.TryGetValue(int.Parse(this.listView1.SelectedItems[0].SubItems[0].Text), out tODOICLAss))
			{
				this.listView2.Items.Clear();
				foreach (Players value in tODOICLAss.dictionary_0.Values)
				{
					string[] str = new string[17];
					try
					{
						userSessionID = value.UserSessionID;
						str[0] = userSessionID.ToString();
						str[1] = value.Userid;
						str[2] = value.UserName;
						userSessionID = value.Player_FLD_LEVEL;
						str[3] = userSessionID.ToString();
						long nHANVATHP = value.NHAN_VAT_HP;
						str[4] = nHANVATHP.ToString();
						if (value.Client != null)
						{
							str[5] = value.Client.ToString();
						}
						userSessionID = value.CharacterCoords_Map;
						str[6] = userSessionID.ToString();
						float characterCoordsX = value.CharacterCoords_X;
						str[7] = characterCoordsX.ToString();
						characterCoordsX = value.CharacterCoords_Y;
						str[8] = characterCoordsX.ToString();
						nHANVATHP = value.FLD_BasicCharAttack;
						str[9] = nHANVATHP.ToString();
						decimal fLDThemVaoTiLePhanTramCongKich = value.FLD_them_vao_ti_le_phan_tram_cong_kich;
						str[10] = fLDThemVaoTiLePhanTramCongKich.ToString();
						nHANVATHP = value.FLD_BasicCharDefense;
						str[11] = nHANVATHP.ToString();
						fLDThemVaoTiLePhanTramCongKich = value.FLD_them_vao_ti_le_phan_tram_phong_ngu;
						str[12] = fLDThemVaoTiLePhanTramCongKich.ToString();
						userSessionID = value.FLD_trang_bi_them_vao_Khi_cong;
						str[13] = userSessionID.ToString();
						str[14] = value.Client.int_6.ToString();
						userSessionID = value.FLD_trang_bi_them_vao_vu_khi_cuong_hoa;
						str[15] = userSessionID.ToString();
						userSessionID = value.FLD_trang_bi_them_vao_Phong_cu_Cuong_hoa;
						str[16] = userSessionID.ToString();
					}
					catch
					{
						userSessionID = value.UserSessionID;
						str[0] = userSessionID.ToString();
						str[1] = value.Userid;
						str[2] = value.UserName;
						userSessionID = value.Player_FLD_LEVEL;
						str[3] = userSessionID.ToString();
					}
					this.listView2.Items.Insert(this.listView2.Items.Count, new ListViewItem(str));
				}
			}
		}
	}
}