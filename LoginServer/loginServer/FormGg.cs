namespace LoginServer
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class FormGg : Form
    {
        private Button button1;
        private ComboBox comboBox1;
        private IContainer components;
        private TextBox textBox1;

        static FormGg()
        {
            ZYXDNGuarder.Startup();
        }

        public FormGg()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.Text == "系统公告")
            {
                this.method_0(0, this.textBox1.Text);
            }
            else if (this.comboBox1.Text == "系统滚动公告")
            {
                this.method_0(1, this.textBox1.Text);
            }
            else if (this.comboBox1.Text == "系统提示")
            {
                this.method_0(2, this.textBox1.Text);
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
            this.comboBox1 = new ComboBox();
            this.textBox1 = new TextBox();
            this.button1 = new Button();
            base.SuspendLayout();
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] { "系统公告", "系统滚动公告", "系统提示" });
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] { "系统公告", "系统滚动公告", "系统提示" });
            this.comboBox1.Location = new Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(0x5c, 20);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "系统公告";
            this.textBox1.Location = new Point(12, 0x26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(0x124, 0x97);
            this.textBox1.TabIndex = 1;
            this.button1.Location = new Point(0xd9, 9);
            this.button1.Name = "button1";
            this.button1.Size = new Size(0x4b, 0x17);
            this.button1.TabIndex = 2;
            this.button1.Text = "发送";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x13c, 0xc9);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.textBox1);
            base.Controls.Add(this.comboBox1);
            base.MaximizeBox = false;
            base.Name = "FormGg";
            this.Text = "FormGg";
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        public void method_0(int id, string txt)
        {
            foreach (PlayerHandler handler in BbcServer.clients)
            {
                handler.Sendd(string.Concat(new object[] { "发送公告|", id, "|", txt }));
            }
        }
    }
}

