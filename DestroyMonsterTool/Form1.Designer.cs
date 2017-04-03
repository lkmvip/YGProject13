namespace DestroyMonsterTool
{
      partial class Form1
      {
            /// <summary>
            /// 필수 디자이너 변수입니다.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            /// <summary>
            /// 사용 중인 모든 리소스를 정리합니다.
            /// </summary>
            /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
            protected override void Dispose(bool disposing)
            {
                  if (disposing && (components != null))
                  {
                        components.Dispose();
                  }
                  base.Dispose(disposing);
            }

            #region Windows Form 디자이너에서 생성한 코드

            /// <summary>
            /// 디자이너 지원에 필요한 메서드입니다. 
            /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
            /// </summary>
            private void InitializeComponent()
            {
                  this.statusStrip1 = new System.Windows.Forms.StatusStrip();
                  this.menuStrip1 = new System.Windows.Forms.MenuStrip();
                  this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.lua저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
                  this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
                  this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                  this.퀘스트IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
                  this.퀘스트레벨DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
                  this.드랍아이템IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
                  this.드랍아이템갯수DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
                  this.드랍확율DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
                  this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                  this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                  this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                  this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                  this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                  this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                  this.dataGridView1 = new System.Windows.Forms.DataGridView();
                  this.menuStrip1.SuspendLayout();
                  ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
                  this.SuspendLayout();
                  // 
                  // statusStrip1
                  // 
                  this.statusStrip1.Location = new System.Drawing.Point(0, 533);
                  this.statusStrip1.Name = "statusStrip1";
                  this.statusStrip1.Size = new System.Drawing.Size(1147, 22);
                  this.statusStrip1.TabIndex = 0;
                  this.statusStrip1.Text = "statusStrip1";
                  // 
                  // menuStrip1
                  // 
                  this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.추가ToolStripMenuItem,
            this.삭제ToolStripMenuItem});
                  this.menuStrip1.Location = new System.Drawing.Point(0, 0);
                  this.menuStrip1.Name = "menuStrip1";
                  this.menuStrip1.Size = new System.Drawing.Size(1147, 24);
                  this.menuStrip1.TabIndex = 3;
                  this.menuStrip1.Text = "menuStrip1";
                  // 
                  // 파일ToolStripMenuItem
                  // 
                  this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열기ToolStripMenuItem,
            this.저장ToolStripMenuItem,
            this.lua저장ToolStripMenuItem});
                  this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
                  this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
                  this.파일ToolStripMenuItem.Text = "파일";
                  // 
                  // 열기ToolStripMenuItem
                  // 
                  this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
                  this.열기ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
                  this.열기ToolStripMenuItem.Text = "열기";
                  this.열기ToolStripMenuItem.Click += new System.EventHandler(this.열기ToolStripMenuItem_Click);
                  // 
                  // 저장ToolStripMenuItem
                  // 
                  this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
                  this.저장ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
                  this.저장ToolStripMenuItem.Text = "저장";
                  this.저장ToolStripMenuItem.Click += new System.EventHandler(this.저장ToolStripMenuItem_Click);
                  // 
                  // lua저장ToolStripMenuItem
                  // 
                  this.lua저장ToolStripMenuItem.Name = "lua저장ToolStripMenuItem";
                  this.lua저장ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
                  this.lua저장ToolStripMenuItem.Text = "Lua 저장";
                  this.lua저장ToolStripMenuItem.Click += new System.EventHandler(this.lua저장ToolStripMenuItem_Click);
                  // 
                  // 추가ToolStripMenuItem
                  // 
                  this.추가ToolStripMenuItem.Name = "추가ToolStripMenuItem";
                  this.추가ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
                  this.추가ToolStripMenuItem.Text = "추가";
                  this.추가ToolStripMenuItem.Click += new System.EventHandler(this.추가ToolStripMenuItem_Click);
                  // 
                  // 삭제ToolStripMenuItem
                  // 
                  this.삭제ToolStripMenuItem.Name = "삭제ToolStripMenuItem";
                  this.삭제ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
                  this.삭제ToolStripMenuItem.Text = "삭제";
                  this.삭제ToolStripMenuItem.Click += new System.EventHandler(this.삭제ToolStripMenuItem_Click);
                  // 
                  // openFileDialog1
                  // 
                  this.openFileDialog1.FileName = "openFileDialog1";
                  // 
                  // iDDataGridViewTextBoxColumn1
                  // 
                  this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
                  this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
                  this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
                  // 
                  // 퀘스트IDDataGridViewTextBoxColumn
                  // 
                  this.퀘스트IDDataGridViewTextBoxColumn.DataPropertyName = "퀘스트ID";
                  this.퀘스트IDDataGridViewTextBoxColumn.HeaderText = "퀘스트ID";
                  this.퀘스트IDDataGridViewTextBoxColumn.Name = "퀘스트IDDataGridViewTextBoxColumn";
                  // 
                  // 퀘스트레벨DataGridViewTextBoxColumn
                  // 
                  this.퀘스트레벨DataGridViewTextBoxColumn.DataPropertyName = "퀘스트레벨";
                  this.퀘스트레벨DataGridViewTextBoxColumn.HeaderText = "퀘스트레벨";
                  this.퀘스트레벨DataGridViewTextBoxColumn.Name = "퀘스트레벨DataGridViewTextBoxColumn";
                  // 
                  // 드랍아이템IDDataGridViewTextBoxColumn
                  // 
                  this.드랍아이템IDDataGridViewTextBoxColumn.DataPropertyName = "드랍아이템ID";
                  this.드랍아이템IDDataGridViewTextBoxColumn.HeaderText = "드랍아이템ID";
                  this.드랍아이템IDDataGridViewTextBoxColumn.Name = "드랍아이템IDDataGridViewTextBoxColumn";
                  // 
                  // 드랍아이템갯수DataGridViewTextBoxColumn
                  // 
                  this.드랍아이템갯수DataGridViewTextBoxColumn.DataPropertyName = "드랍아이템갯수";
                  this.드랍아이템갯수DataGridViewTextBoxColumn.HeaderText = "드랍아이템갯수";
                  this.드랍아이템갯수DataGridViewTextBoxColumn.Name = "드랍아이템갯수DataGridViewTextBoxColumn";
                  // 
                  // 드랍확율DataGridViewTextBoxColumn
                  // 
                  this.드랍확율DataGridViewTextBoxColumn.DataPropertyName = "드랍확율";
                  this.드랍확율DataGridViewTextBoxColumn.HeaderText = "드랍확율";
                  this.드랍확율DataGridViewTextBoxColumn.Name = "드랍확율DataGridViewTextBoxColumn";
                  // 
                  // Column5
                  // 
                  this.Column5.HeaderText = "드랍확율";
                  this.Column5.Name = "Column5";
                  // 
                  // Column6
                  // 
                  this.Column6.HeaderText = "드랍아이템갯수";
                  this.Column6.Name = "Column6";
                  this.Column6.Width = 120;
                  // 
                  // Column4
                  // 
                  this.Column4.HeaderText = "드랍아이템ID";
                  this.Column4.Name = "Column4";
                  this.Column4.Width = 120;
                  // 
                  // Column3
                  // 
                  this.Column3.HeaderText = "퀘스트레벨";
                  this.Column3.Name = "Column3";
                  // 
                  // Column2
                  // 
                  this.Column2.HeaderText = "퀘스트ID";
                  this.Column2.Name = "Column2";
                  // 
                  // Column1
                  // 
                  this.Column1.HeaderText = "몬스터ID";
                  this.Column1.Name = "Column1";
                  // 
                  // dataGridView1
                  // 
                  this.dataGridView1.AllowUserToAddRows = false;
                  this.dataGridView1.AllowUserToDeleteRows = false;
                  this.dataGridView1.AllowUserToResizeColumns = false;
                  this.dataGridView1.AllowUserToResizeRows = false;
                  this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                  this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5});
                  this.dataGridView1.Location = new System.Drawing.Point(0, 27);
                  this.dataGridView1.Name = "dataGridView1";
                  this.dataGridView1.RowTemplate.Height = 23;
                  this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                  this.dataGridView1.Size = new System.Drawing.Size(98, 509);
                  this.dataGridView1.TabIndex = 2;
                  // 
                  // Form1
                  // 
                  this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
                  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                  this.ClientSize = new System.Drawing.Size(1147, 555);
                  this.Controls.Add(this.dataGridView1);
                  this.Controls.Add(this.statusStrip1);
                  this.Controls.Add(this.menuStrip1);
                  this.MainMenuStrip = this.menuStrip1;
                  this.Name = "Form1";
                  this.Text = "DestroyMonster";
                  this.Load += new System.EventHandler(this.Form1_Load);
                  this.menuStrip1.ResumeLayout(false);
                  this.menuStrip1.PerformLayout();
                  ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
                  this.ResumeLayout(false);
                  this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.StatusStrip statusStrip1;
            private System.Windows.Forms.MenuStrip menuStrip1;
            private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem 추가ToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem lua저장ToolStripMenuItem;
            private System.Windows.Forms.SaveFileDialog saveFileDialog1;
            private System.Windows.Forms.OpenFileDialog openFileDialog1;
            private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
            private System.Windows.Forms.DataGridViewTextBoxColumn 퀘스트IDDataGridViewTextBoxColumn;
            private System.Windows.Forms.DataGridViewTextBoxColumn 퀘스트레벨DataGridViewTextBoxColumn;
            private System.Windows.Forms.DataGridViewTextBoxColumn 드랍아이템IDDataGridViewTextBoxColumn;
            private System.Windows.Forms.DataGridViewTextBoxColumn 드랍아이템갯수DataGridViewTextBoxColumn;
            private System.Windows.Forms.DataGridViewTextBoxColumn 드랍확율DataGridViewTextBoxColumn;
            private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
            private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
            private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
            private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
            private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
            private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
            private System.Windows.Forms.DataGridView dataGridView1;
      }
}

