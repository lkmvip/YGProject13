namespace LoginServer
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class FormIpList : Form
    {
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private IContainer components;
        private ContextMenuStrip contextMenuStrip1;
        private ListView listView1;
        private ToolStripMenuItem toolStripMenuItem_0;

        static FormIpList()
        {
            ZYXDNGuarder.Startup();
        }

        public FormIpList()
        {
            this.InitializeComponent();
        }

        public void bind()
        {
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormIpList_Load(object sender, EventArgs e)
        {
            this.method_0();
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            this.listView1 = new ListView();
            this.columnHeader5 = new ColumnHeader();
            this.columnHeader1 = new ColumnHeader();
            this.columnHeader2 = new ColumnHeader();
            this.columnHeader3 = new ColumnHeader();
            this.columnHeader4 = new ColumnHeader();
            this.contextMenuStrip1 = new ContextMenuStrip(this.components);
            this.toolStripMenuItem_0 = new ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            base.SuspendLayout();
            this.listView1.Columns.AddRange(new ColumnHeader[] { this.columnHeader5, this.columnHeader1, this.columnHeader2, this.columnHeader3, this.columnHeader4 });
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Dock = DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new Size(0x213, 0x184);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = View.Details;
            this.columnHeader5.Text = "id";
            this.columnHeader5.Width = 0x5f;
            this.columnHeader1.Text = "用户IP";
            this.columnHeader1.Width = 0x7c;
            this.columnHeader2.Text = "所在服务器";
            this.columnHeader2.Width = 0x87;
            this.columnHeader3.Text = "在线时长";
            this.columnHeader3.Width = 0x4b;
            this.columnHeader4.Text = "conn";
            this.contextMenuStrip1.Items.AddRange(new ToolStripItem[] { this.toolStripMenuItem_0 });
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new Size(0x5f, 0x1a);
            this.toolStripMenuItem_0.Name = "封IPToolStripMenuItem";
            this.toolStripMenuItem_0.Size = new Size(0x5e, 0x16);
            this.toolStripMenuItem_0.Text = "封IP";
            this.toolStripMenuItem_0.Click += new EventHandler(this.toolStripMenuItem_0_Click);
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x213, 0x184);
            base.Controls.Add(this.listView1);
            base.Name = "FormIpList";
            this.Text = "FormIpList";
            base.Load += new EventHandler(this.FormIpList_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            base.ResumeLayout(false);
        }

        private void method_0()
        {
            try
            {
                this.listView1.ListViewItemSorter = new ListViewColumnSorter();
                this.listView1.ColumnClick += new ColumnClickEventHandler(ListViewHelper.ListView_ColumnClick);
                foreach (NetState state in World.list.Values)
                {
                    if (state != null)
                    {
                        string[] items = new string[5];
                        items[0] = state.WorldId.ToString();
                        items[1] = state.ToString();
                        items[2] = state.packconn.ToString();
                        this.listView1.Items.Insert(this.listView1.Items.Count, new ListViewItem(items));
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void toolStripMenuItem_0_Click(object sender, EventArgs e)
        {
        }
    }
}

