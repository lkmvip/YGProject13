namespace LoginServer
{
    using LoginServer.DbClss;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class userlist : Form
    {
        private Button button1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private IContainer components;
        private ContextMenuStrip contextMenuStrip1;
        private ListView listView1;
        private SplitContainer splitContainer1;
        private TextBox textBox1;
        private ToolStripMenuItem toolStripMenuItem_0;

        static userlist()
        {
            ZYXDNGuarder.Startup();
        }

        public userlist()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            playerS rs;
            this.listView1.Items.Clear();
            if (World.Players.TryGetValue(this.textBox1.Text, out rs))
            {
                string[] items = new string[] { rs.UserId.ToString(), rs.UserIp, RxjhClass.GetUserIpadds(rs.UserIp), rs.ServerID, rs.TimeSpan_0.ToString().Remove(rs.TimeSpan_0.ToString().Length - 8, 8), rs.conn.ToString() };
                this.listView1.Items.Insert(this.listView1.Items.Count, new ListViewItem(items));
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            this.splitContainer1 = new SplitContainer();
            this.listView1 = new ListView();
            this.columnHeader5 = new ColumnHeader();
            this.columnHeader1 = new ColumnHeader();
            this.columnHeader2 = new ColumnHeader();
            this.columnHeader3 = new ColumnHeader();
            this.columnHeader4 = new ColumnHeader();
            this.contextMenuStrip1 = new ContextMenuStrip(this.components);
            this.toolStripMenuItem_0 = new ToolStripMenuItem();
            this.button1 = new Button();
            this.textBox1 = new TextBox();
            this.columnHeader6 = new ColumnHeader();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            base.SuspendLayout();
            this.splitContainer1.Dock = DockStyle.Fill;
            this.splitContainer1.Location = new Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Panel1.Controls.Add(this.listView1);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Size = new Size(0x2c8, 410);
            this.splitContainer1.SplitterDistance = 0x218;
            this.splitContainer1.TabIndex = 4;
            this.listView1.Columns.AddRange(new ColumnHeader[] { this.columnHeader5, this.columnHeader1, this.columnHeader6, this.columnHeader2, this.columnHeader3, this.columnHeader4 });
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Dock = DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new Size(0x218, 410);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = View.Details;
            this.columnHeader5.Text = "id";
            this.columnHeader5.Width = 0x5f;
            this.columnHeader1.Text = "用户IP";
            this.columnHeader1.Width = 0x7c;
            this.columnHeader2.Text = "所在服务器";
            this.columnHeader2.Width = 0x48;
            this.columnHeader3.Text = "在线时长";
            this.columnHeader3.Width = 0x4b;
            this.columnHeader4.Text = "conn";
            this.contextMenuStrip1.Items.AddRange(new ToolStripItem[] { this.toolStripMenuItem_0 });
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new Size(0x5f, 0x1a);
            this.toolStripMenuItem_0.Name = "踢IDToolStripMenuItem";
            this.toolStripMenuItem_0.Size = new Size(0x5e, 0x16);
            this.toolStripMenuItem_0.Text = "踢ID";
            this.toolStripMenuItem_0.Click += new EventHandler(this.toolStripMenuItem_0_Click);
            this.button1.Location = new Point(0x17, 0x3d);
            this.button1.Name = "button1";
            this.button1.Size = new Size(0x70, 0x17);
            this.button1.TabIndex = 1;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.textBox1.Location = new Point(0x17, 0x21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(0x70, 0x15);
            this.textBox1.TabIndex = 0;
            this.columnHeader6.Text = "地区";
            this.columnHeader6.Width = 0x68;
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x2c8, 410);
            base.Controls.Add(this.splitContainer1);
            base.Name = "userlist";
            this.Text = "userlist";
            base.Load += new EventHandler(this.userlist_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            base.ResumeLayout(false);
        }

        private void toolStripMenuItem_0_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count > 0)
            {
                string text = this.listView1.SelectedItems[0].SubItems[0].Text;
                playerS rs = World.smethod_3(text);
                if (rs != null)
                {
                    lock (World.Players)
                    {
                        World.Players.Remove(text);
                    }
                    World.smethod_9(rs.ServerID, rs.WorldID);
                    rs.npcyd.Dispose();
                }
            }
        }

        private void userlist_Load(object sender, EventArgs e)
        {
            try
            {
                this.listView1.ListViewItemSorter = new ListViewColumnSorter();
                this.listView1.ColumnClick += new ColumnClickEventHandler(ListViewHelper.ListView_ColumnClick);
                lock (World.Players)
                {
                    foreach (playerS rs in World.Players.Values)
                    {
                        if (rs != null)
                        {
                            string[] items = new string[] { rs.UserId.ToString(), rs.UserIp, RxjhClass.GetUserIpadds(rs.UserIp), rs.ServerID, rs.TimeSpan_0.ToString().Remove(rs.TimeSpan_0.ToString().Length - 8, 8), rs.conn.ToString() };
                            this.listView1.Items.Insert(this.listView1.Items.Count, new ListViewItem(items));
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}

