namespace LoginServer
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class BinIP : Form
    {
        private Button button1;
        private ColumnHeader columnHeader2;
        private IContainer components;
        private ContextMenuStrip contextMenuStrip1;
        private ListView listView1;
        private MaskedTextBox maskedTextBox1;
        private ToolStripMenuItem toolStripMenuItem_0;

        static BinIP()
        {
            ZYXDNGuarder.Startup();
        }

        public BinIP()
        {
            this.InitializeComponent();
        }

        public void bind()
        {
        }

        public void bind2()
        {
        }

        private void BinIP_Load(object sender, EventArgs e)
        {
            this.bind2();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void InitializeComponent()
        {
            this.components = new Container();
            this.listView1 = new ListView();
            this.columnHeader2 = new ColumnHeader();
            this.button1 = new Button();
            this.maskedTextBox1 = new MaskedTextBox();
            this.contextMenuStrip1 = new ContextMenuStrip(this.components);
            this.toolStripMenuItem_0 = new ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            base.SuspendLayout();
            this.listView1.Columns.AddRange(new ColumnHeader[] { this.columnHeader2 });
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new Point(8, 8);
            this.listView1.Name = "listView1";
            this.listView1.Size = new Size(0xde, 0x11c);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = View.Details;
            this.columnHeader2.Text = "IP";
            this.columnHeader2.Width = 0xa6;
            this.button1.Location = new Point(0x9b, 300);
            this.button1.Name = "button1";
            this.button1.Size = new Size(0x4b, 0x17);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.maskedTextBox1.Location = new Point(8, 0x12e);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new Size(0x8b, 0x15);
            this.maskedTextBox1.TabIndex = 5;
            this.contextMenuStrip1.Items.AddRange(new ToolStripItem[] { this.toolStripMenuItem_0 });
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new Size(0x99, 0x30);
            this.toolStripMenuItem_0.Name = "删除ToolStripMenuItem";
            this.toolStripMenuItem_0.Size = new Size(0x98, 0x16);
            this.toolStripMenuItem_0.Text = "删除";
            this.toolStripMenuItem_0.Click += new EventHandler(this.toolStripMenuItem_0_Click);
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0xf2, 0x14f);
            base.Controls.Add(this.maskedTextBox1);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.listView1);
            base.Name = "BinIP";
            this.Text = "BinIP";
            base.Load += new EventHandler(this.BinIP_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void toolStripMenuItem_0_Click(object sender, EventArgs e)
        {
        }
    }
}

