using ns0;
using ns10;
using ns11;
using ns13;
using ns3;
using ns9;
using RxjhServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns2
{
	internal class UserList : Form
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

		private ColumnHeader columnHeader_2;

		private ColumnHeader columnHeader_3;

		private ColumnHeader columnHeader_4;

		private ColumnHeader columnHeader_5;

		private ColumnHeader columnHeader_6;

		private ColumnHeader columnHeader_7;

		private ColumnHeader columnHeader_8;

		private ColumnHeader columnHeader_9;

		private System.ComponentModel.Container container_0 = new System.ComponentModel.Container();

		private System.Windows.Forms.ContextMenu contextMenu_0;

		private ListView listView1;

		private MenuItem menuItem_0;

		private MenuItem menuItem_1;

		private MenuItem menuItem_2;

		private MenuItem menuItem_3;

		private MenuItem menuItem_4;

		public UserList()
		{
			this.InitializeComponent();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.container_0 != null)
			{
				this.container_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
                  this.listView1 = new System.Windows.Forms.ListView();
                  this.columnHeader_4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                  this.columnHeader_0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                  this.columnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                  this.columnHeader_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                  this.columnHeader_8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                  this.columnHeader_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                  this.columnHeader_5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                  this.columnHeader_6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                  this.columnHeader_7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                  this.columnHeader_9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                  this.columnHeader_13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                  this.columnHeader_10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                  this.columnHeader_14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                  this.columnHeader_12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                  this.columnHeader_11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                  this.columnHeader_15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                  this.columnHeader_16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                  this.contextMenu_0 = new System.Windows.Forms.ContextMenu();
                  this.menuItem_0 = new System.Windows.Forms.MenuItem();
                  this.menuItem_1 = new System.Windows.Forms.MenuItem();
                  this.menuItem_2 = new System.Windows.Forms.MenuItem();
                  this.menuItem_3 = new System.Windows.Forms.MenuItem();
                  this.menuItem_4 = new System.Windows.Forms.MenuItem();
                  this.SuspendLayout();
                  // 
                  // listView1
                  // 
                  this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_4,
            this.columnHeader_0,
            this.columnHeader_1,
            this.columnHeader_2,
            this.columnHeader_8,
            this.columnHeader_3,
            this.columnHeader_5,
            this.columnHeader_6,
            this.columnHeader_7,
            this.columnHeader_9,
            this.columnHeader_13,
            this.columnHeader_10,
            this.columnHeader_14,
            this.columnHeader_12,
            this.columnHeader_11,
            this.columnHeader_15,
            this.columnHeader_16});
                  this.listView1.ContextMenu = this.contextMenu_0;
                  this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
                  this.listView1.ForeColor = System.Drawing.SystemColors.WindowText;
                  this.listView1.FullRowSelect = true;
                  this.listView1.GridLines = true;
                  this.listView1.Location = new System.Drawing.Point(0, 0);
                  this.listView1.Name = "listView1";
                  this.listView1.Size = new System.Drawing.Size(875, 372);
                  this.listView1.TabIndex = 1;
                  this.listView1.UseCompatibleStateImageBehavior = false;
                  this.listView1.View = System.Windows.Forms.View.Details;
                  // 
                  // columnHeader_4
                  // 
                  this.columnHeader_4.Text = "No.";
                  this.columnHeader_4.Width = 36;
                  // 
                  // columnHeader_0
                  // 
                  this.columnHeader_0.Text = "ID";
                  this.columnHeader_0.Width = 66;
                  // 
                  // columnHeader_1
                  // 
                  this.columnHeader_1.Text = "Name";
                  this.columnHeader_1.Width = 98;
                  // 
                  // columnHeader_2
                  // 
                  this.columnHeader_2.Text = "Rank";
                  this.columnHeader_2.Width = 38;
                  // 
                  // columnHeader_8
                  // 
                  this.columnHeader_8.Text = "HP";
                  this.columnHeader_8.Width = 47;
                  // 
                  // columnHeader_3
                  // 
                  this.columnHeader_3.Text = "IP";
                  this.columnHeader_3.Width = 113;
                  // 
                  // columnHeader_5
                  // 
                  this.columnHeader_5.Text = "Map";
                  this.columnHeader_5.Width = 42;
                  // 
                  // columnHeader_6
                  // 
                  this.columnHeader_6.Text = "X";
                  this.columnHeader_6.Width = 61;
                  // 
                  // columnHeader_7
                  // 
                  this.columnHeader_7.Text = "Y";
                  this.columnHeader_7.Width = 61;
                  // 
                  // columnHeader_9
                  // 
                  this.columnHeader_9.Text = "Attack";
                  this.columnHeader_9.Width = 36;
                  // 
                  // columnHeader_13
                  // 
                  this.columnHeader_13.Text = "Plus attack";
                  this.columnHeader_13.Width = 41;
                  // 
                  // columnHeader_10
                  // 
                  this.columnHeader_10.Text = "Anti";
                  this.columnHeader_10.Width = 37;
                  // 
                  // columnHeader_14
                  // 
                  this.columnHeader_14.Text = "Anti-plus";
                  this.columnHeader_14.Width = 39;
                  // 
                  // columnHeader_12
                  // 
                  this.columnHeader_12.Text = "Air";
                  this.columnHeader_12.Width = 39;
                  // 
                  // columnHeader_11
                  // 
                  this.columnHeader_11.Text = "ping";
                  this.columnHeader_11.Width = 39;
                  // 
                  // columnHeader_15
                  // 
                  this.columnHeader_15.Text = "Strong attack";
                  this.columnHeader_15.Width = 39;
                  // 
                  // columnHeader_16
                  // 
                  this.columnHeader_16.Text = "Against strong";
                  this.columnHeader_16.Width = 37;
                  // 
                  // contextMenu_0
                  // 
                  this.contextMenu_0.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_0,
            this.menuItem_1,
            this.menuItem_2,
            this.menuItem_3,
            this.menuItem_4});
                  this.contextMenu_0.Popup += new System.EventHandler(this.contextMenu_0_Popup);
                  // 
                  // menuItem_0
                  // 
                  this.menuItem_0.Index = 0;
                  this.menuItem_0.Text = "선택 유저 추방";
                  this.menuItem_0.Click += new System.EventHandler(this.menuItem_0_Click);
                  // 
                  // menuItem_1
                  // 
                  this.menuItem_1.Index = 1;
                  this.menuItem_1.Text = "선택 유저 ID 추방";
                  this.menuItem_1.Click += new System.EventHandler(this.menuItem_1_Click);
                  // 
                  // menuItem_2
                  // 
                  this.menuItem_2.Index = 2;
                  this.menuItem_2.Text = "IP 차단";
                  this.menuItem_2.Click += new System.EventHandler(this.menuItem_2_Click);
                  // 
                  // menuItem_3
                  // 
                  this.menuItem_3.Index = 3;
                  this.menuItem_3.Text = "SealID";
                  this.menuItem_3.Click += new System.EventHandler(this.menuItem_3_Click);
                  // 
                  // menuItem_4
                  // 
                  this.menuItem_4.Index = 4;
                  this.menuItem_4.Text = "Check data";
                  this.menuItem_4.Click += new System.EventHandler(this.menuItem_4_Click);
                  // 
                  // UserList
                  // 
                  this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
                  this.ClientSize = new System.Drawing.Size(875, 372);
                  this.Controls.Add(this.listView1);
                  this.Name = "UserList";
                  this.Text = "UserList";
                  this.Load += new System.EventHandler(this.UserList_Load);
                  this.ResumeLayout(false);

		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void menuItem_0_Click(object sender, EventArgs e)
		{
			if (this.listView1.SelectedItems.Count > 0)
			{
				Players player = World.smethod_2(this.listView1.SelectedItems[0].SubItems[2].Text);
				if (player != null && player.Client != null)
				{
					player.Client.Dispose();
				}
			}
		}

		private void menuItem_1_Click(object sender, EventArgs e)
		{
			if (this.listView1.SelectedItems.Count > 0)
			{
				Players player = World.smethod_0(this.listView1.SelectedItems[0].SubItems[1].Text);
				if (player != null && player.Client != null)
				{
					player.Client.Dispose();
				}
			}
		}

		private void menuItem_2_Click(object sender, EventArgs e)
		{
			if (this.listView1.SelectedItems.Count > 0)
			{
				string text = this.listView1.SelectedItems[0].SubItems[5].Text;
				DBA.smethod_7(string.Format(" Insert into TBL_BANED values ( '{0}')", text), "rxjhaccount");
			}
		}

		private void menuItem_3_Click(object sender, EventArgs e)
		{
			if (this.listView1.SelectedItems.Count > 0)
			{
				string text = this.listView1.SelectedItems[0].SubItems[1].Text;
				DBA.smethod_7(string.Format("UPDATE TBL_ACCOUNT SET FLD_ZT=1 WHERE FLD_ID='{0}'", text), "rxjhaccount");
			}
		}

		private void menuItem_4_Click(object sender, EventArgs e)
		{
			if (this.listView1.SelectedItems.Count > 0)
			{
				string text = this.listView1.SelectedItems[0].SubItems[2].Text;
				(new UserIdList()
				{
					username = text
				}).ShowDialog();
			}
		}

		private void UserList_Load(object sender, EventArgs e)
		{
			int userSessionID;
			try
			{
				this.listView1.ListViewItemSorter = new ListViewColumnSorter();
				this.listView1.ColumnClick += new ColumnClickEventHandler(ListViewItemS.smethod_0);
				foreach (Players value in World.allConnectedChars.Values)
				{
					if (value == null)
					{
						continue;
					}
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
					this.listView1.Items.Insert(this.listView1.Items.Count, new ListViewItem(str));
				}
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				Form1.WriteLine(1, string.Concat("人物列表出错", exception.Message));
			}
		}

            private void contextMenu_0_Popup(object sender, EventArgs e)
            {

            }
      }
}