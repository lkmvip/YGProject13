namespace LoginServer
{
    using LoginServer.HelperTools;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Reflection;
    using System.Threading;
    using System.Timers;
    using System.Windows.Forms;

    public class Form1 : Form
    {
        private IContainer components;
        private FlickerFreePanel GraphPanel;
        private Listener l;
        private MenuStrip menuStrip1;
        private bool runn;
        private StatusStrip statusStrip1;
        private Thread thThreadRead;
        private Thread thThreadRead2;
        private System.Timers.Timer timer_0;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripMenuItem toolStripMenuItem_0;
        private ToolStripMenuItem toolStripMenuItem_1;
        private ToolStripMenuItem toolStripMenuItem_2;
        private ToolStripMenuItem toolStripMenuItem_3;
        private ToolStripMenuItem toolStripMenuItem_4;
        private ToolStripMenuItem toolStripMenuItem_5;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripTextBox toolStripTextBox1;
        private static List<TxtClass> txt;
        private World world;

        static Form1()
        {
            ZYXDNGuarder.Startup();
            ZYDNGuard();
        }

        public Form1()
        {
            this.InitializeComponent();
        }

        private void a(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.runn = true;
                this.thThreadRead.Abort();
                this.thThreadRead2.Abort();
            }
            catch
            {
            }
        }

        private void b(object sender, FormClosedEventArgs e)
        {
        }

        private void c(object sender, EventArgs e)
        {
            new userlist().ShowDialog();
        }

        private void d(object sender, EventArgs e)
        {
            this.GraphPanel.Invalidate();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void e(object sender, EventArgs e)
        {
            this.world.SetConfig();
            this.world.SetConfig2();
            this.world.SetConfig3();
        }

        private void f(object sender, EventArgs e)
        {
            new FormGg().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().ProcessorAffinity = (IntPtr) 1;
            this.world = new World();
            this.world.SetConfig();
            this.world.SetConfig2();
            this.world.SetConfig3();
            this.l = new Listener(World.int_3);
            new BbcServer("127.0.0.1", World.int_2).Start();
            this.thThreadRead = new Thread(new ThreadStart(this.method_0));
            this.thThreadRead.Name = "FlushAll";
            this.thThreadRead.Start();
            this.thThreadRead2 = new Thread(new ThreadStart(this.method_1));
            this.thThreadRead2.Name = "FlushSERAll";
            this.thThreadRead2.Start();
            this.timer_0 = new System.Timers.Timer(10000.0);
            this.timer_0.Elapsed += new ElapsedEventHandler(this.timer_0_Elapsed);
            this.timer_0.AutoReset = true;
            this.timer_0.Enabled = true;
            this.Text = this.Text + "_" + World.string_0 + "_" + Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void GraphPanel_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Graphics graphics = e.Graphics;
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.PixelOffsetMode = PixelOffsetMode.None;
                string s = "Connection:" + World.list.Count.ToString() + " MainSocket:" + World.bool_0.ToString() + " ServerCount:" + BbcServer.clients.Count.ToString() + " Online:" + World.Players.Count.ToString() + " Login queue:" + World.Connect.Count.ToString() + " Lions queue:" + World.queue_0.Count.ToString();
                graphics.DrawString(s, Control.DefaultFont, Brushes.Yellow, (PointF) new Point(50, 5));
                int num = 0;
                foreach (TxtClass class2 in txt)
                {
                    switch (class2.type)
                    {
                        case 0:
                            graphics.DrawString(class2.Txt, Control.DefaultFont, Brushes.Lime, (PointF) new Point(5, num += 0x11));
                            break;

                        case 1:
                            graphics.DrawString(class2.Txt, Control.DefaultFont, Brushes.Red, (PointF) new Point(5, num += 0x11));
                            break;

                        case 2:
                            graphics.DrawString(class2.Txt, Control.DefaultFont, Brushes.Lime, (PointF) new Point(5, num += 0x11));
                            break;

                        case 3:
                            graphics.DrawString(class2.Txt, Control.DefaultFont, Brushes.Green, (PointF) new Point(5, num += 0x11));
                            break;

                        case 4:
                            graphics.DrawString(class2.Txt, Control.DefaultFont, Brushes.Teal, (PointF) new Point(5, num += 0x11));
                            break;

                        case 5:
                            graphics.DrawString(class2.Txt, Control.DefaultFont, Brushes.DodgerBlue, (PointF) new Point(5, num += 0x11));
                            break;

                        case 6:
                            graphics.DrawString(class2.Txt, Control.DefaultFont, Brushes.Blue, (PointF) new Point(5, num += 0x11));
                            break;

                        default:
                            graphics.DrawString(class2.Txt, Control.DefaultFont, Brushes.Lime, (PointF) new Point(5, num += 0x11));
                            break;
                    }
                }
            }
            catch
            {
            }
        }

        private void InitializeComponent()
        {
                  this.components = new System.ComponentModel.Container();
                  this.menuStrip1 = new System.Windows.Forms.MenuStrip();
                  this.toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
                  this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
                  this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
                  this.toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
                  this.toolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
                  this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
                  this.toolStripMenuItem_3 = new System.Windows.Forms.ToolStripMenuItem();
                  this.toolStripMenuItem_4 = new System.Windows.Forms.ToolStripMenuItem();
                  this.toolStripMenuItem_5 = new System.Windows.Forms.ToolStripMenuItem();
                  this.timer1 = new System.Windows.Forms.Timer(this.components);
                  this.toolStrip1 = new System.Windows.Forms.ToolStrip();
                  this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
                  this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
                  this.timer2 = new System.Windows.Forms.Timer(this.components);
                  this.GraphPanel = new LoginServer.FlickerFreePanel();
                  this.statusStrip1 = new System.Windows.Forms.StatusStrip();
                  this.menuStrip1.SuspendLayout();
                  this.toolStrip1.SuspendLayout();
                  this.GraphPanel.SuspendLayout();
                  this.SuspendLayout();
                  // 
                  // menuStrip1
                  // 
                  this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_0});
                  this.menuStrip1.Location = new System.Drawing.Point(0, 0);
                  this.menuStrip1.Name = "menuStrip1";
                  this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
                  this.menuStrip1.Size = new System.Drawing.Size(672, 24);
                  this.menuStrip1.TabIndex = 0;
                  this.menuStrip1.Text = "menuStrip1";
                  // 
                  // toolStripMenuItem_0
                  // 
                  this.toolStripMenuItem_0.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem_1,
            this.toolStripMenuItem_2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem_3,
            this.toolStripMenuItem_4,
            this.toolStripMenuItem_5});
                  this.toolStripMenuItem_0.Name = "toolStripMenuItem_0";
                  this.toolStripMenuItem_0.Size = new System.Drawing.Size(47, 20);
                  this.toolStripMenuItem_0.Text = "Users";
                  // 
                  // toolStripMenuItem1
                  // 
                  this.toolStripMenuItem1.Checked = true;
                  this.toolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
                  this.toolStripMenuItem1.Name = "toolStripMenuItem1";
                  this.toolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
                  this.toolStripMenuItem1.Text = "Auto Connect";
                  this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
                  // 
                  // toolStripMenuItem2
                  // 
                  this.toolStripMenuItem2.Name = "toolStripMenuItem2";
                  this.toolStripMenuItem2.Size = new System.Drawing.Size(201, 22);
                  this.toolStripMenuItem2.Text = "Start";
                  this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
                  // 
                  // toolStripMenuItem_1
                  // 
                  this.toolStripMenuItem_1.Name = "toolStripMenuItem_1";
                  this.toolStripMenuItem_1.Size = new System.Drawing.Size(201, 22);
                  this.toolStripMenuItem_1.Text = "UserList";
                  this.toolStripMenuItem_1.Click += new System.EventHandler(this.c);
                  // 
                  // toolStripMenuItem_2
                  // 
                  this.toolStripMenuItem_2.Name = "toolStripMenuItem_2";
                  this.toolStripMenuItem_2.Size = new System.Drawing.Size(201, 22);
                  this.toolStripMenuItem_2.Text = "RereadingConfiguration";
                  this.toolStripMenuItem_2.Click += new System.EventHandler(this.e);
                  // 
                  // toolStripMenuItem3
                  // 
                  this.toolStripMenuItem3.Name = "toolStripMenuItem3";
                  this.toolStripMenuItem3.Size = new System.Drawing.Size(201, 22);
                  this.toolStripMenuItem3.Text = "RereadingClosureIP";
                  this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
                  // 
                  // toolStripMenuItem_3
                  // 
                  this.toolStripMenuItem_3.Name = "toolStripMenuItem_3";
                  this.toolStripMenuItem_3.Size = new System.Drawing.Size(201, 22);
                  this.toolStripMenuItem_3.Text = "BulletinTX";
                  this.toolStripMenuItem_3.Click += new System.EventHandler(this.f);
                  // 
                  // toolStripMenuItem_4
                  // 
                  this.toolStripMenuItem_4.Name = "toolStripMenuItem_4";
                  this.toolStripMenuItem_4.Size = new System.Drawing.Size(201, 22);
                  this.toolStripMenuItem_4.Text = "ListOfBlockedIP";
                  this.toolStripMenuItem_4.Click += new System.EventHandler(this.toolStripMenuItem_4_Click);
                  // 
                  // toolStripMenuItem_5
                  // 
                  this.toolStripMenuItem_5.Name = "toolStripMenuItem_5";
                  this.toolStripMenuItem_5.Size = new System.Drawing.Size(201, 22);
                  this.toolStripMenuItem_5.Text = "IPlist";
                  this.toolStripMenuItem_5.Click += new System.EventHandler(this.toolStripMenuItem_5_Click);
                  // 
                  // timer1
                  // 
                  this.timer1.Enabled = true;
                  this.timer1.Interval = 500;
                  this.timer1.Tick += new System.EventHandler(this.d);
                  // 
                  // toolStrip1
                  // 
                  this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripButton1});
                  this.toolStrip1.Location = new System.Drawing.Point(0, 24);
                  this.toolStrip1.Name = "toolStrip1";
                  this.toolStrip1.Size = new System.Drawing.Size(672, 25);
                  this.toolStrip1.TabIndex = 1;
                  this.toolStrip1.Text = "toolStrip1";
                  // 
                  // toolStripTextBox1
                  // 
                  this.toolStripTextBox1.Name = "toolStripTextBox1";
                  this.toolStripTextBox1.Size = new System.Drawing.Size(233, 25);
                  // 
                  // toolStripButton1
                  // 
                  this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
                  this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
                  this.toolStripButton1.Name = "toolStripButton1";
                  this.toolStripButton1.Size = new System.Drawing.Size(38, 22);
                  this.toolStripButton1.Text = "Send";
                  this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
                  // 
                  // timer2
                  // 
                  this.timer2.Enabled = true;
                  this.timer2.Interval = 21000;
                  this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
                  // 
                  // GraphPanel
                  // 
                  this.GraphPanel.BackColor = System.Drawing.Color.Black;
                  this.GraphPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                  this.GraphPanel.Controls.Add(this.statusStrip1);
                  this.GraphPanel.Dock = System.Windows.Forms.DockStyle.Fill;
                  this.GraphPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                  this.GraphPanel.Location = new System.Drawing.Point(0, 49);
                  this.GraphPanel.Name = "GraphPanel";
                  this.GraphPanel.Size = new System.Drawing.Size(672, 306);
                  this.GraphPanel.TabIndex = 0;
                  this.GraphPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphPanel_Paint);
                  // 
                  // statusStrip1
                  // 
                  this.statusStrip1.Location = new System.Drawing.Point(0, 280);
                  this.statusStrip1.Name = "statusStrip1";
                  this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
                  this.statusStrip1.Size = new System.Drawing.Size(668, 22);
                  this.statusStrip1.TabIndex = 0;
                  this.statusStrip1.Text = "statusStrip1";
                  // 
                  // Form1
                  // 
                  this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
                  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                  this.ClientSize = new System.Drawing.Size(672, 355);
                  this.Controls.Add(this.GraphPanel);
                  this.Controls.Add(this.toolStrip1);
                  this.Controls.Add(this.menuStrip1);
                  this.MainMenuStrip = this.menuStrip1;
                  this.Name = "Form1";
                  this.Text = "LoginServer";
                  this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.a);
                  this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.b);
                  this.Load += new System.EventHandler(this.Form1_Load);
                  this.menuStrip1.ResumeLayout(false);
                  this.menuStrip1.PerformLayout();
                  this.toolStrip1.ResumeLayout(false);
                  this.toolStrip1.PerformLayout();
                  this.GraphPanel.ResumeLayout(false);
                  this.GraphPanel.PerformLayout();
                  this.ResumeLayout(false);
                  this.PerformLayout();

        }

        private void method_0()
        {
            try
            {
                bool flag;
                goto Label_0013;
            Label_0004:
                Thread.Sleep(1);
                World.ProcessDisposedQueue();
            Label_0013:
                flag = true;
                goto Label_0004;
            }
            catch (Exception exception)
            {
                WriteLine(1, "FlushAll Error" + exception.Message);
                if (!this.runn)
                {
                    this.thThreadRead = new Thread(new ThreadStart(this.method_0));
                    this.thThreadRead.Name = "FlushAll";
                    this.thThreadRead.Start();
                }
            }
        }

        private void method_1()
        {
            try
            {
                bool flag;
                goto Label_0013;
            Label_0004:
                Thread.Sleep(1);
                World.ProcessSerQueue();
            Label_0013:
                flag = true;
                goto Label_0004;
            }
            catch (Exception exception)
            {
                WriteLine(1, "FlushSERAll Error" + exception.Message);
                if (!this.runn)
                {
                    this.thThreadRead2 = new Thread(new ThreadStart(this.method_1));
                    this.thThreadRead2.Name = "FlushSERAll";
                    this.thThreadRead2.Start();
                }
            }
        }

        private void timer_0_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.timer_0.Interval = World.int_10;
            if (!World.bool_0 && this.toolStripMenuItem1.Checked)
            {
                if (this.l != null)
                {
                    this.l.Dispose();
                }
                this.l = new Listener(World.int_3);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            World.smethod_0();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] toSendBuff = Converter.hexStringToByte(this.toolStripTextBox1.Text);
                foreach (NetState state in World.list.Values)
                {
                    if (state != null)
                    {
                        state.Send(toSendBuff, toSendBuff.Length);
                    }
                }
            }
            catch
            {
            }
        }

        private void toolStripMenuItem_4_Click(object sender, EventArgs e)
        {
            new BinIP().ShowDialog();
        }

        private void toolStripMenuItem_5_Click(object sender, EventArgs e)
        {
            new FormIpList().ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.toolStripMenuItem1.Checked)
            {
                this.toolStripMenuItem1.Checked = false;
            }
            else
            {
                this.toolStripMenuItem1.Checked = true;
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (this.l != null)
            {
                this.l.Dispose();
                this.l = null;
            }
            else
            {
                this.l = new Listener(World.int_3);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.world.SetConfig3();
        }

        public static void WriteLine(int type, string txtt)
        {
            if ((type == 1) || (type == 6))
            {
                logo.FileTxtLog(txtt);
            }
            int num = 20;
            txt.Add(new TxtClass(type, txtt));
            int count = txt.Count;
            if (count > 20)
            {
                for (int i = 0; i < (count - num); i++)
                {
                    txt.RemoveAt(0);
                }
            }
        }

        private static void ZYDNGuard()
        {
            txt = new List<TxtClass>();
        }
    }
}

