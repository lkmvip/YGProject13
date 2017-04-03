namespace YBQ_TOOLS_NEW
{
      partial class frmMain
      {
            /// <summary>
            /// Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            /// <summary>
            /// Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose(bool disposing)
            {
                  if (disposing && (components != null))
                  {
                        components.Dispose();
                  }
                  base.Dispose(disposing);
            }

            #region Windows Form Designer generated code

            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
                  this.components = new System.ComponentModel.Container();
                  this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
                  this.deleteQuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.temporaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.SaveQuestOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
                  this.reloadRefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.columnHeader_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                  this.columnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                  this.columnHeader_0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                  this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
                  this.statusStrip1 = new System.Windows.Forms.StatusStrip();
                  this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
                  this.SaveFileYbqcfgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.OpenFileYbqcfgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.splitContainer1 = new System.Windows.Forms.SplitContainer();
                  this.listView = new System.Windows.Forms.ListView();
                  this.menuStrip1 = new System.Windows.Forms.MenuStrip();
                  this.퀘스트모두저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.contextMenuStrip1.SuspendLayout();
                  this.statusStrip1.SuspendLayout();
                  ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
                  this.splitContainer1.Panel1.SuspendLayout();
                  this.splitContainer1.Panel2.SuspendLayout();
                  this.splitContainer1.SuspendLayout();
                  this.menuStrip1.SuspendLayout();
                  this.SuspendLayout();
                  // 
                  // propertyGrid1
                  // 
                  this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
                  this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
                  this.propertyGrid1.Name = "propertyGrid1";
                  this.propertyGrid1.Size = new System.Drawing.Size(441, 522);
                  this.propertyGrid1.TabIndex = 0;
                  // 
                  // deleteQuestToolStripMenuItem
                  // 
                  this.deleteQuestToolStripMenuItem.Enabled = false;
                  this.deleteQuestToolStripMenuItem.Name = "deleteQuestToolStripMenuItem";
                  this.deleteQuestToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
                  this.deleteQuestToolStripMenuItem.Text = "퀘스트 삭제";
                  this.deleteQuestToolStripMenuItem.Click += new System.EventHandler(this.deleteQuestToolStripMenuItem_Click);
                  // 
                  // temporaryToolStripMenuItem
                  // 
                  this.temporaryToolStripMenuItem.Enabled = false;
                  this.temporaryToolStripMenuItem.Name = "temporaryToolStripMenuItem";
                  this.temporaryToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
                  this.temporaryToolStripMenuItem.Text = "퀘스트ID 복사";
                  // 
                  // SaveQuestOneToolStripMenuItem
                  // 
                  this.SaveQuestOneToolStripMenuItem.Name = "SaveQuestOneToolStripMenuItem";
                  this.SaveQuestOneToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
                  this.SaveQuestOneToolStripMenuItem.Text = "선택 퀘스트 저장";
                  this.SaveQuestOneToolStripMenuItem.Click += new System.EventHandler(this.SaveQuestOneToolStripMenuItem_Click);
                  // 
                  // contextMenuStrip1
                  // 
                  this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveQuestOneToolStripMenuItem,
            this.deleteQuestToolStripMenuItem,
            this.reloadRefreshToolStripMenuItem,
            this.temporaryToolStripMenuItem});
                  this.contextMenuStrip1.Name = "contextMenuStrip1";
                  this.contextMenuStrip1.Size = new System.Drawing.Size(167, 114);
                  // 
                  // reloadRefreshToolStripMenuItem
                  // 
                  this.reloadRefreshToolStripMenuItem.Enabled = false;
                  this.reloadRefreshToolStripMenuItem.Name = "reloadRefreshToolStripMenuItem";
                  this.reloadRefreshToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
                  this.reloadRefreshToolStripMenuItem.Text = "다시 읽기";
                  // 
                  // columnHeader_2
                  // 
                  this.columnHeader_2.Text = "레벨";
                  // 
                  // columnHeader_1
                  // 
                  this.columnHeader_1.Text = "퀘스트 이름";
                  this.columnHeader_1.Width = 150;
                  // 
                  // columnHeader_0
                  // 
                  this.columnHeader_0.Text = "퀘스트ID";
                  // 
                  // toolStripStatusLabel1
                  // 
                  this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
                  this.toolStripStatusLabel1.Size = new System.Drawing.Size(55, 17);
                  this.toolStripStatusLabel1.Text = "로드파일";
                  // 
                  // statusStrip1
                  // 
                  this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
                  this.statusStrip1.Location = new System.Drawing.Point(0, 546);
                  this.statusStrip1.Name = "statusStrip1";
                  this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
                  this.statusStrip1.Size = new System.Drawing.Size(740, 22);
                  this.statusStrip1.TabIndex = 4;
                  this.statusStrip1.Text = "statusStrip1";
                  // 
                  // toolStripProgressBar1
                  // 
                  this.toolStripProgressBar1.Name = "toolStripProgressBar1";
                  this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
                  this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
                  this.toolStripProgressBar1.Value = 100;
                  this.toolStripProgressBar1.Visible = false;
                  // 
                  // SaveFileYbqcfgToolStripMenuItem
                  // 
                  this.SaveFileYbqcfgToolStripMenuItem.Name = "SaveFileYbqcfgToolStripMenuItem";
                  this.SaveFileYbqcfgToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
                  this.SaveFileYbqcfgToolStripMenuItem.Text = "저장";
                  this.SaveFileYbqcfgToolStripMenuItem.Click += new System.EventHandler(this.SaveFileYbqcfgToolStripMenuItem_Click);
                  // 
                  // OpenFileYbqcfgToolStripMenuItem
                  // 
                  this.OpenFileYbqcfgToolStripMenuItem.Name = "OpenFileYbqcfgToolStripMenuItem";
                  this.OpenFileYbqcfgToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
                  this.OpenFileYbqcfgToolStripMenuItem.Text = "열기";
                  this.OpenFileYbqcfgToolStripMenuItem.Click += new System.EventHandler(this.OpenFileYbqcfgToolStripMenuItem_Click);
                  // 
                  // 文件ToolStripMenuItem
                  // 
                  this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileYbqcfgToolStripMenuItem,
            this.SaveFileYbqcfgToolStripMenuItem});
                  this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
                  this.文件ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
                  this.文件ToolStripMenuItem.Text = "파일";
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
                  this.splitContainer1.Size = new System.Drawing.Size(740, 522);
                  this.splitContainer1.SplitterDistance = 294;
                  this.splitContainer1.SplitterWidth = 5;
                  this.splitContainer1.TabIndex = 5;
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
                  this.listView.Size = new System.Drawing.Size(294, 522);
                  this.listView.TabIndex = 5;
                  this.listView.UseCompatibleStateImageBehavior = false;
                  this.listView.View = System.Windows.Forms.View.Details;
                  this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
                  this.listView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseClick);
                  // 
                  // menuStrip1
                  // 
                  this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.퀘스트모두저장ToolStripMenuItem});
                  this.menuStrip1.Location = new System.Drawing.Point(0, 0);
                  this.menuStrip1.Name = "menuStrip1";
                  this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
                  this.menuStrip1.Size = new System.Drawing.Size(740, 24);
                  this.menuStrip1.TabIndex = 3;
                  this.menuStrip1.Text = "menuStrip1";
                  // 
                  // 퀘스트모두저장ToolStripMenuItem
                  // 
                  this.퀘스트모두저장ToolStripMenuItem.Name = "퀘스트모두저장ToolStripMenuItem";
                  this.퀘스트모두저장ToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
                  this.퀘스트모두저장ToolStripMenuItem.Text = "퀘스트 모두저장";
                  this.퀘스트모두저장ToolStripMenuItem.Click += new System.EventHandler(this.퀘스트모두저장ToolStripMenuItem_Click);
                  // 
                  // frmMain
                  // 
                  this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
                  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                  this.ClientSize = new System.Drawing.Size(740, 568);
                  this.Controls.Add(this.splitContainer1);
                  this.Controls.Add(this.menuStrip1);
                  this.Controls.Add(this.statusStrip1);
                  this.Name = "frmMain";
                  this.Text = "퀘스트 에디터 13 20170320";
                  this.Load += new System.EventHandler(this.frmMain_Load);
                  this.contextMenuStrip1.ResumeLayout(false);
                  this.statusStrip1.ResumeLayout(false);
                  this.statusStrip1.PerformLayout();
                  this.splitContainer1.Panel1.ResumeLayout(false);
                  this.splitContainer1.Panel2.ResumeLayout(false);
                  ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
                  this.splitContainer1.ResumeLayout(false);
                  this.menuStrip1.ResumeLayout(false);
                  this.menuStrip1.PerformLayout();
                  this.ResumeLayout(false);
                  this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.PropertyGrid propertyGrid1;
            private System.Windows.Forms.ToolStripMenuItem deleteQuestToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem temporaryToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem SaveQuestOneToolStripMenuItem;
            private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
            private System.Windows.Forms.ToolStripMenuItem reloadRefreshToolStripMenuItem;
            private System.Windows.Forms.ColumnHeader columnHeader_2;
            private System.Windows.Forms.ColumnHeader columnHeader_1;
            private System.Windows.Forms.ColumnHeader columnHeader_0;
            private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
            private System.Windows.Forms.StatusStrip statusStrip1;
            private System.Windows.Forms.ToolStripMenuItem SaveFileYbqcfgToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem OpenFileYbqcfgToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
            private System.Windows.Forms.SplitContainer splitContainer1;
            private System.Windows.Forms.ListView listView;
            private System.Windows.Forms.MenuStrip menuStrip1;
            public System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
            private System.Windows.Forms.ToolStripMenuItem 퀘스트모두저장ToolStripMenuItem;
      }
}