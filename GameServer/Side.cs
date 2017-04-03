using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns9
{
	internal class Side : Form
	{
		private IContainer icontainer_0 = new System.ComponentModel.Container();

		private Label label1;

		private Label label2;

		public Side()
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

		private void InitializeComponent()
		{
                  this.label1 = new System.Windows.Forms.Label();
                  this.label2 = new System.Windows.Forms.Label();
                  this.SuspendLayout();
                  // 
                  // label1
                  // 
                  this.label1.ForeColor = System.Drawing.Color.Red;
                  this.label1.Location = new System.Drawing.Point(14, 22);
                  this.label1.Name = "label1";
                  this.label1.Size = new System.Drawing.Size(387, 121);
                  this.label1.TabIndex = 0;
                  // 
                  // label2
                  // 
                  this.label2.AutoSize = true;
                  this.label2.Location = new System.Drawing.Point(258, 185);
                  this.label2.Name = "label2";
                  this.label2.Size = new System.Drawing.Size(143, 12);
                  this.label2.TabIndex = 1;
                  this.label2.Text = "YULGANG SERVER 2015";
                  // 
                  // Side
                  // 
                  this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
                  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                  this.ClientSize = new System.Drawing.Size(415, 206);
                  this.Controls.Add(this.label2);
                  this.Controls.Add(this.label1);
                  this.Name = "Side";
                  this.Text = "GAMESERVER";
                  this.ResumeLayout(false);
                  this.PerformLayout();

		}
	}
}