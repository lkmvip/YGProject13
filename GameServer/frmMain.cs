using LuaInterface;
using ns0;
using ns1;
using ns10;
using ns11;
using ns12;
using ns2;
using ns3;
using ns4;
using ns6;
using ns9;
using RxjhServer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace ns13
{
	internal class Form1 : Form
	{
            private object lockObject = new object();
            private static List<TxtClass> txt;
            private bool runn;

		private static World world;

		private Listener class70_0;

		private DateTime dateTime_0 = DateTime.Now;

		private Thread thThreadRead;

		private IContainer icontainer_0 = new System.ComponentModel.Container();

		private ImageList imageList_0;

		private int int_0;

		private int int_1 = 2;

		private static int int_2;

		private static List<TxtClass> list_0;

		private MainMenu mainMenu_0;

		private MenuItem menuItem_0;

		private MenuItem menuItem_1;

		private MenuItem menuItem_10;

		private MenuItem menuItem_11;

		private MenuItem menuItem_12;

		private MenuItem menuItem_13;

		private MenuItem menuItem_14;

		private MenuItem menuItem_15;

		private MenuItem menuItem_16;

		private MenuItem menuItem_17;

		private MenuItem menuItem_18;

		private MenuItem menuItem_19;

		private MenuItem menuItem_2;

		private MenuItem menuItem_20;

		private MenuItem menuItem_21;

		private MenuItem menuItem_22;

		private MenuItem menuItem_23;

		private MenuItem menuItem_24;

		private MenuItem menuItem_25;

		private MenuItem menuItem_26;

		private MenuItem menuItem_27;

		private MenuItem menuItem_28;

		private MenuItem menuItem_29;

		private MenuItem menuItem_3;

		private MenuItem menuItem_30;

		private MenuItem menuItem_31;

		private MenuItem menuItem_32;

		private MenuItem menuItem_33;

		private MenuItem menuItem_34;

		private MenuItem menuItem_35;

		private MenuItem menuItem_36;

		private MenuItem menuItem_37;

		private MenuItem menuItem_38;

		private MenuItem menuItem_39;

		private MenuItem menuItem_4;

		private MenuItem menuItem_40;

		private MenuItem menuItem_41;

		private MenuItem menuItem_42;

		private MenuItem menuItem_43;

		private MenuItem menuItem_44;

		private MenuItem menuItem_45;

		private MenuItem menuItem_46;

		private MenuItem menuItem_47;

		private MenuItem menuItem_48;

		private MenuItem menuItem_49;

		private MenuItem menuItem_5;

		private MenuItem menuItem_50;

		private MenuItem menuItem_51;

		private MenuItem menuItem_52;

		private MenuItem menuItem_53;

		private MenuItem menuItem_54;

		private MenuItem menuItem_55;

		private MenuItem menuItem_56;

		private MenuItem menuItem_57;

		private MenuItem menuItem_58;

		private MenuItem menuItem_6;

		private MenuItem menuItem_7;

		private MenuItem menuItem_8;

		private MenuItem menuItem_9;

		private StatusBar statusBar1;

		private StatusBarPanel statusBarPanel1;

		private StatusBarPanel statusBarPanel2;

		private StatusBarPanel statusBarPanel3;

		private StatusBarPanel statusBarPanel4;

		private static Thread thread_0;

		private System.Timers.Timer timer_0 = new System.Timers.Timer(1000);

		private System.Timers.Timer timer_1 = new System.Timers.Timer(21000);

		private System.Timers.Timer timer_2;

		private System.Windows.Forms.Timer timer_3;

		private ToolStrip toolStrip1;

		private ToolStripButton toolStripButton1;

		private ToolStripButton toolStripButton2;

		private ToolStripButton toolStripButton3;

		private ToolStripButton toolStripButton4;

		private ToolStripComboBox toolStripComboBox1;

		private ToolStripComboBox toolStripComboBox2;

		private ToolStripSeparator toolStripSeparator1;

		private ToolStripSeparator toolStripSeparator2;

		private ToolStripTextBox toolStripTextBox1;

		private IContainer components;

		private MenuItem menuItem1;

		private MenuItem menuItem2;
            private RichTextBox LogTextBox;
            private System.Windows.Forms.Timer Logtimer;
            private ToolStripTextBox toolStripTextBox2;

		static Form1()
		{
			Form1.ZYDNGuard();
		}

		public Form1()
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

		private void e(string string_0, int int_3)
		{
			try
			{
				foreach (Players value in World.allConnectedChars.Values)
				{
					if (value == null || int_3 != 0)
					{
						continue;
					}
					value.System_Announcement(string_0);
				}
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				Form1.WriteLine(1, string.Concat("SetLogs Error", exception.Message));
			}
		}

		private void f(object sender, EventArgs e)
		{
			string str;
			string str1;
			double num;
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "timer1_Tick");
			}
			//this.GraphPanel.Invalidate();
			StatusBarPanel statusBarPanel = this.statusBarPanel1;
			object[] count = new object[] { "Connection:", null, null, null };
			int days = World.threadSafeDictionary_0.Count;
			count[1] = days.ToString();
			count[2] = " Online:";
			count[3] = World.allConnectedChars.Count;
			statusBarPanel.Text = string.Concat(count);
			StatusBarPanel statusBarPanel1 = this.statusBarPanel2;
			object[] objArray = new object[] { "Map Items:", null, null, null };
			days = World.threadSafeDictionary_3.Count;
			objArray[1] = days.ToString();
			objArray[2] = " Monster:";
			objArray[3] = MapClass.smethod_0();
			statusBarPanel1.Text = string.Concat(objArray);
			double double10 = World.double_10;
			double double8 = World.double_8;
			double double9 = World.double_9;
			if (double10 < 1024)
			{
				num = Math.Round(double10, 0);
				str = string.Concat(num.ToString(), "B");
			}
			else
			{
				double10 = World.double_10 / 1024;
				num = Math.Round(double10, 0);
				str = string.Concat(num.ToString(), "K");
			}
			if (double8 < 1024)
			{
				num = Math.Round(double8, 0);
				str1 = string.Concat(num.ToString(), "B");
			}
			else
			{
				double8 = World.double_8 / 1024;
				num = Math.Round(double8, 0);
				str1 = string.Concat(num.ToString(), "K");
			}
			if (double9 < 1024)
			{
				num = Math.Round(double9, 0);
				string.Concat(num.ToString(), "B");
			}
			else
			{
				double9 = World.double_9 / 1024;
				num = Math.Round(double9, 0);
				string.Concat(num.ToString(), "K");
			}
			StatusBarPanel statusBarPanel2 = this.statusBarPanel3;
			string[] strArrays = new string[] { "Receive:", str, "/s Sent:", str1, "/s P:", null };
			days = Converter.dictionary_0.Count;
			strArrays[5] = days.ToString();
			statusBarPanel2.Text = string.Concat(strArrays);
			World.double_10 = 0;
			World.double_8 = 0;
			World.double_9 = 0;
			TimeSpan timeSpan = DateTime.Now.Subtract(this.dateTime_0);
			StatusBarPanel statusBarPanel3 = this.statusBarPanel4;
			string[] strArrays1 = new string[8];
			days = timeSpan.Days;
			strArrays1[0] = days.ToString();
			strArrays1[1] = "Day";
			days = timeSpan.Hours;
			strArrays1[2] = days.ToString();
			strArrays1[3] = "H";
			days = timeSpan.Minutes;
			strArrays1[4] = days.ToString();
			strArrays1[5] = "M";
			days = timeSpan.Seconds;
			strArrays1[6] = days.ToString();
			strArrays1[7] = "S";
			statusBarPanel3.Text = string.Concat(strArrays1);
		}

		private void FlushAll()
		{
			try
			{
				while (!this.runn)
				{
					TimerClass.Slice();
					Thread.Sleep(1);
					World.ProcessDisposedQueue();
					World.ProcessSqlQueue();
				}
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				Form1.WriteLine(1, string.Concat("FlushAll Error", exception.Message));
				if (!this.runn)
				{
					this.thThreadRead = new Thread(new ThreadStart(this.FlushAll))
					{
						Name = "FlushAll"
					};
					this.thThreadRead.Start();
				}
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				if (World.queue_1.Count > 0)
				{
					if (MessageBox.Show(string.Concat("Data queue is not yet complete ", World.queue_1.Count), "Data queue is not yet complete", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) != System.Windows.Forms.DialogResult.OK)
					{
						e.Cancel = true;
					}
					else
					{
						this.runn = true;
						Form1.thread_0.Abort();
						this.thThreadRead.Abort();
					}
				}
				else if (World.allConnectedChars.Count <= 0)
				{
					this.runn = true;
					Form1.thread_0.Abort();
					this.thThreadRead.Abort();
					RxjhDeBuf.FreeLibrary();
				}
				else if (MessageBox.Show(string.Concat("There are people online ", World.allConnectedChars.Count), "There are people online", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) != System.Windows.Forms.DialogResult.OK)
				{
					e.Cancel = true;
				}
				else
				{
					this.runn = true;
					Form1.thread_0.Abort();
					this.thThreadRead.Abort();
				}
			}
			catch
			{
			}
		}

		private void Form1_Layout(object sender, LayoutEventArgs e)
		{
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			try
			{
                        Process.GetCurrentProcess().ProcessorAffinity = (IntPtr)1;
                        Form1.thread_0 = new Thread(new ThreadStart(new TimerClass.Class128().method_0))
				{
					Name = "Timer Thread"
				};
				Form1.thread_0.Start();
				Form1.world = new World();
				Form1.world.SetConfig();
				Form1.world.SetConfig2();
				Form1.world.SetConfig3();
				Form1.world.SetConfig4();
				Form1.world.SetConfigDB();
				if (World.smethod_13())
				{
					Form1.world.SetMonSter();
					Form1.world.SetNpc();
					Form1.world.SetDrop();
					Form1.world.Set_GSDrop();
					Form1.world.SetBossDrop();
					Form1.world.SetOpen();
					Form1.world.SetLever();
					Form1.world.SetWxLever();
					Form1.world.SetKONGFU();
					Form1.world.SetItme();
					Form1.world.SetNPC_Sell();
					Form1.world.SetMover();
					Form1.world.Set_THONG_BAO();
					Form1.world.SetMAP();
					Form1.world.method_11();
					Form1.world.method_15();
					Form1.world.method_9();
					Form1.world.method_10();
					Form1.world.method_14();
					Form1.world.SetAssumptionQigong();
					Form1.world.Set_CHE_TAO_VAT_PHAM();
					Form1.world.SetScript();
					Form1.world.SetItemShop();
					Form1.world.LOAD_DINH_NGHIA_CHUYEN_CHUC_THUOC_TINH();
					Form1.world.LOAD_DANG_CAP_KHEN_THUONG();
					Form1.world.LOAD_TRUC_TUYEN_THOI_GIAN_KHEN_THUONG();
					Form1.world.LOAD_ITEM_TRAO_DOI();
					Form1.world.method_29();
					Form1.world.LOAD_CHUYEN_SINH_SO_LAN_KHEN_THUONG();
					Form1.world.method_19();
					Form1.world.SetTZ();
					Form1.world.SetTZlist();
					World.class20_0 = new Connect();
					World.class20_0.method_0();
					this.class70_0 = new Listener(World.Game_server_port);
					AuthServer authServer = new AuthServer(World.string_42, World.Babolat_Club_server_port);
					this.Text = string.Concat(new string[] { this.Text, " [", World.Server_Name_2, "] ver", Assembly.GetExecutingAssembly().GetName().Version.ToString() });
					this.thThreadRead = new Thread(new ThreadStart(this.FlushAll))
					{
						Name = "FlushAll"
					};
					this.thThreadRead.Start();
					TimerClass.smethod_5(TimeSpan.FromMilliseconds(180000), TimeSpan.FromMilliseconds(180000), new Delegate10(this.method_0));
					this.timer_1 = new System.Timers.Timer(21000);
					this.timer_1.Elapsed += new ElapsedEventHandler(this.timer_1_Elapsed);
					this.timer_1.AutoReset = true;
					this.timer_1.Enabled = true;
					this.timer_2 = new System.Timers.Timer((double)(World.AtPort * 1000));
					this.timer_2.Elapsed += new ElapsedEventHandler(this.timer_2_Elapsed);
					this.timer_2.AutoReset = true;
					this.timer_2.Enabled = true;
					RxjhDeBuf.LoadLibrary();
					Form1.Thread1();                             
                        }
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				Form1.WriteLine(1, string.Concat("Form1_Load error", exception.Message));
			}
		}

		private void GraphPanel_Paint(object sender, PaintEventArgs e)
		{
			try
			{
				Graphics graphics = e.Graphics;
				graphics.SmoothingMode = SmoothingMode.AntiAlias;
				graphics.PixelOffsetMode = PixelOffsetMode.None;
				object[] str = new object[16];
				str[0] = "Connection:";
				int count = World.threadSafeDictionary_0.Count;
				str[1] = count.ToString();
				str[2] = "/";
				str[3] = World.Maximum_Online;
				str[4] = " Online:";
				str[5] = World.allConnectedChars.Count;
				str[6] = " MainSocket:";
				str[7] = World.bool_5.ToString();
				str[8] = " Team:";
				str[9] = World.W_TO_DOI.Count;
				str[10] = " Offline Queue:";
				str[11] = World.queue_0.Count;
				str[12] = " Database Queues:";
				str[13] = World.queue_1.Count;
				str[14] = " Lions Line:";
				count = World.queue_2.Count;
				str[15] = count.ToString();
				string str1 = string.Concat(str);
				graphics.DrawString(str1, Control.DefaultFont, Brushes.Yellow, new Point(20, 5));
				int num = 0;
				foreach (TxtClass list0 in Form1.list_0)
				{
					switch (list0.type)
					{
						case 0:
						{
							int num1 = num + 17;
							num = num1;
							graphics.DrawString(list0.Txt, Control.DefaultFont, Brushes.Lime, new Point(5, num1));
							continue;
						}
						case 1:
						{
							int num2 = num + 17;
							num = num2;
							graphics.DrawString(list0.Txt, Control.DefaultFont, Brushes.Red, new Point(5, num2));
							continue;
						}
						case 2:
						{
							int num3 = num + 17;
							num = num3;
							graphics.DrawString(list0.Txt, Control.DefaultFont, Brushes.Lime, new Point(5, num3));
							continue;
						}
						case 3:
						{
							int num4 = num + 17;
							num = num4;
							graphics.DrawString(list0.Txt, Control.DefaultFont, Brushes.Green, new Point(5, num4));
							continue;
						}
						case 4:
						{
							int num5 = num + 17;
							num = num5;
							graphics.DrawString(list0.Txt, Control.DefaultFont, Brushes.Teal, new Point(5, num5));
							continue;
						}
						case 5:
						{
							int num6 = num + 17;
							num = num6;
							graphics.DrawString(list0.Txt, Control.DefaultFont, Brushes.DodgerBlue, new Point(5, num6));
							continue;
						}
						case 6:
						{
							int num7 = num + 17;
							num = num7;
							graphics.DrawString(list0.Txt, Control.DefaultFont, Brushes.Blue, new Point(5, num7));
							continue;
						}
					}
					int num8 = num + 17;
					num = num8;
					graphics.DrawString(list0.Txt, Control.DefaultFont, Brushes.Lime, new Point(5, num8));
				}
			}
			catch
			{
			}
		}

		private void InitializeComponent()
		{
                  this.components = new System.ComponentModel.Container();
                  this.statusBar1 = new System.Windows.Forms.StatusBar();
                  this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
                  this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
                  this.statusBarPanel3 = new System.Windows.Forms.StatusBarPanel();
                  this.statusBarPanel4 = new System.Windows.Forms.StatusBarPanel();
                  this.imageList_0 = new System.Windows.Forms.ImageList(this.components);
                  this.mainMenu_0 = new System.Windows.Forms.MainMenu(this.components);
                  this.menuItem_0 = new System.Windows.Forms.MenuItem();
                  this.menuItem_30 = new System.Windows.Forms.MenuItem();
                  this.menuItem_2 = new System.Windows.Forms.MenuItem();
                  this.menuItem_1 = new System.Windows.Forms.MenuItem();
                  this.menuItem_27 = new System.Windows.Forms.MenuItem();
                  this.menuItem_15 = new System.Windows.Forms.MenuItem();
                  this.menuItem_29 = new System.Windows.Forms.MenuItem();
                  this.menuItem_3 = new System.Windows.Forms.MenuItem();
                  this.menuItem_4 = new System.Windows.Forms.MenuItem();
                  this.menuItem_25 = new System.Windows.Forms.MenuItem();
                  this.menuItem_31 = new System.Windows.Forms.MenuItem();
                  this.menuItem_18 = new System.Windows.Forms.MenuItem();
                  this.menuItem_32 = new System.Windows.Forms.MenuItem();
                  this.menuItem_17 = new System.Windows.Forms.MenuItem();
                  this.menuItem_13 = new System.Windows.Forms.MenuItem();
                  this.menuItem_16 = new System.Windows.Forms.MenuItem();
                  this.menuItem_19 = new System.Windows.Forms.MenuItem();
                  this.menuItem_24 = new System.Windows.Forms.MenuItem();
                  this.menuItem_37 = new System.Windows.Forms.MenuItem();
                  this.menuItem1 = new System.Windows.Forms.MenuItem();
                  this.menuItem_50 = new System.Windows.Forms.MenuItem();
                  this.menuItem2 = new System.Windows.Forms.MenuItem();
                  this.menuItem_53 = new System.Windows.Forms.MenuItem();
                  this.menuItem_54 = new System.Windows.Forms.MenuItem();
                  this.menuItem_57 = new System.Windows.Forms.MenuItem();
                  this.menuItem_5 = new System.Windows.Forms.MenuItem();
                  this.menuItem_6 = new System.Windows.Forms.MenuItem();
                  this.menuItem_28 = new System.Windows.Forms.MenuItem();
                  this.menuItem_26 = new System.Windows.Forms.MenuItem();
                  this.menuItem_39 = new System.Windows.Forms.MenuItem();
                  this.menuItem_20 = new System.Windows.Forms.MenuItem();
                  this.menuItem_21 = new System.Windows.Forms.MenuItem();
                  this.menuItem_22 = new System.Windows.Forms.MenuItem();
                  this.menuItem_7 = new System.Windows.Forms.MenuItem();
                  this.menuItem_23 = new System.Windows.Forms.MenuItem();
                  this.menuItem_8 = new System.Windows.Forms.MenuItem();
                  this.menuItem_9 = new System.Windows.Forms.MenuItem();
                  this.menuItem_10 = new System.Windows.Forms.MenuItem();
                  this.menuItem_11 = new System.Windows.Forms.MenuItem();
                  this.menuItem_12 = new System.Windows.Forms.MenuItem();
                  this.menuItem_14 = new System.Windows.Forms.MenuItem();
                  this.menuItem_33 = new System.Windows.Forms.MenuItem();
                  this.menuItem_36 = new System.Windows.Forms.MenuItem();
                  this.menuItem_38 = new System.Windows.Forms.MenuItem();
                  this.menuItem_40 = new System.Windows.Forms.MenuItem();
                  this.menuItem_42 = new System.Windows.Forms.MenuItem();
                  this.menuItem_43 = new System.Windows.Forms.MenuItem();
                  this.menuItem_44 = new System.Windows.Forms.MenuItem();
                  this.menuItem_45 = new System.Windows.Forms.MenuItem();
                  this.menuItem_46 = new System.Windows.Forms.MenuItem();
                  this.menuItem_47 = new System.Windows.Forms.MenuItem();
                  this.menuItem_49 = new System.Windows.Forms.MenuItem();
                  this.menuItem_52 = new System.Windows.Forms.MenuItem();
                  this.menuItem_55 = new System.Windows.Forms.MenuItem();
                  this.menuItem_56 = new System.Windows.Forms.MenuItem();
                  this.menuItem_58 = new System.Windows.Forms.MenuItem();
                  this.menuItem_34 = new System.Windows.Forms.MenuItem();
                  this.menuItem_35 = new System.Windows.Forms.MenuItem();
                  this.menuItem_41 = new System.Windows.Forms.MenuItem();
                  this.menuItem_51 = new System.Windows.Forms.MenuItem();
                  this.menuItem_48 = new System.Windows.Forms.MenuItem();
                  this.timer_3 = new System.Windows.Forms.Timer(this.components);
                  this.toolStrip1 = new System.Windows.Forms.ToolStrip();
                  this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
                  this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
                  this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
                  this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
                  this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
                  this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
                  this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
                  this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
                  this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
                  this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
                  this.LogTextBox = new System.Windows.Forms.RichTextBox();
                  this.Logtimer = new System.Windows.Forms.Timer(this.components);
                  ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel4)).BeginInit();
                  this.toolStrip1.SuspendLayout();
                  this.SuspendLayout();
                  // 
                  // statusBar1
                  // 
                  this.statusBar1.Location = new System.Drawing.Point(0, 434);
                  this.statusBar1.Name = "statusBar1";
                  this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1,
            this.statusBarPanel2,
            this.statusBarPanel3,
            this.statusBarPanel4});
                  this.statusBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                  this.statusBar1.ShowPanels = true;
                  this.statusBar1.Size = new System.Drawing.Size(650, 21);
                  this.statusBar1.TabIndex = 6;
                  this.statusBar1.Text = "statusBar1";
                  // 
                  // statusBarPanel1
                  // 
                  this.statusBarPanel1.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
                  this.statusBarPanel1.Name = "statusBarPanel1";
                  this.statusBarPanel1.Text = "Connection 1000 Online 1000";
                  this.statusBarPanel1.Width = 140;
                  // 
                  // statusBarPanel2
                  // 
                  this.statusBarPanel2.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
                  this.statusBarPanel2.Name = "statusBarPanel2";
                  this.statusBarPanel2.Width = 160;
                  // 
                  // statusBarPanel3
                  // 
                  this.statusBarPanel3.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
                  this.statusBarPanel3.Name = "statusBarPanel3";
                  this.statusBarPanel3.Width = 180;
                  // 
                  // statusBarPanel4
                  // 
                  this.statusBarPanel4.Name = "statusBarPanel4";
                  this.statusBarPanel4.Text = "statusBarPanel4";
                  this.statusBarPanel4.Width = 120;
                  // 
                  // imageList_0
                  // 
                  this.imageList_0.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
                  this.imageList_0.ImageSize = new System.Drawing.Size(16, 16);
                  this.imageList_0.TransparentColor = System.Drawing.Color.Transparent;
                  // 
                  // mainMenu_0
                  // 
                  this.mainMenu_0.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_0,
            this.menuItem_3,
            this.menuItem_5,
            this.menuItem_34,
            this.menuItem_48});
                  // 
                  // menuItem_0
                  // 
                  this.menuItem_0.Index = 0;
                  this.menuItem_0.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_30,
            this.menuItem_2,
            this.menuItem_1,
            this.menuItem_27,
            this.menuItem_15,
            this.menuItem_29});
                  this.menuItem_0.Text = "Main";
                  // 
                  // menuItem_30
                  // 
                  this.menuItem_30.Index = 0;
                  this.menuItem_30.Text = "Start Login Service";
                  this.menuItem_30.Click += new System.EventHandler(this.menuItem_30_Click);
                  // 
                  // menuItem_2
                  // 
                  this.menuItem_2.Index = 1;
                  this.menuItem_2.Text = "Stop Login Service";
                  this.menuItem_2.Click += new System.EventHandler(this.menuItem_2_Click);
                  // 
                  // menuItem_1
                  // 
                  this.menuItem_1.Index = 2;
                  this.menuItem_1.Text = "Stop Main Service";
                  this.menuItem_1.Click += new System.EventHandler(this.menuItem_1_Click);
                  // 
                  // menuItem_27
                  // 
                  this.menuItem_27.Index = 3;
                  this.menuItem_27.Text = "Stop Threads";
                  this.menuItem_27.Click += new System.EventHandler(this.menuItem_27_Click);
                  // 
                  // menuItem_15
                  // 
                  this.menuItem_15.Index = 4;
                  this.menuItem_15.Text = "Save";
                  this.menuItem_15.Click += new System.EventHandler(this.menuItem_15_Click);
                  // 
                  // menuItem_29
                  // 
                  this.menuItem_29.Index = 5;
                  this.menuItem_29.Text = "Anti-Flood Settings";
                  this.menuItem_29.Click += new System.EventHandler(this.menuItem_29_Click);
                  // 
                  // menuItem_3
                  // 
                  this.menuItem_3.Index = 1;
                  this.menuItem_3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_4,
            this.menuItem_25,
            this.menuItem_31,
            this.menuItem_18,
            this.menuItem_32,
            this.menuItem_17,
            this.menuItem_13,
            this.menuItem_16,
            this.menuItem_19,
            this.menuItem_24,
            this.menuItem_37,
            this.menuItem1,
            this.menuItem_50,
            this.menuItem2,
            this.menuItem_53,
            this.menuItem_57});
                  this.menuItem_3.Text = "Manage";
                  // 
                  // menuItem_4
                  // 
                  this.menuItem_4.Index = 0;
                  this.menuItem_4.Text = "User List";
                  this.menuItem_4.Click += new System.EventHandler(this.menuItem_4_Click);
                  // 
                  // menuItem_25
                  // 
                  this.menuItem_25.Index = 1;
                  this.menuItem_25.Text = "Party List";
                  this.menuItem_25.Click += new System.EventHandler(this.menuItem_25_Click);
                  // 
                  // menuItem_31
                  // 
                  this.menuItem_31.Index = 2;
                  this.menuItem_31.Text = "Ground Items";
                  this.menuItem_31.Click += new System.EventHandler(this.menuItem_31_Click);
                  // 
                  // menuItem_18
                  // 
                  this.menuItem_18.Checked = true;
                  this.menuItem_18.Index = 3;
                  this.menuItem_18.Text = "Show Record";
                  this.menuItem_18.Click += new System.EventHandler(this.menuItem_18_Click);
                  // 
                  // menuItem_32
                  // 
                  this.menuItem_32.Index = 4;
                  this.menuItem_32.Text = "Show Drop";
                  this.menuItem_32.Click += new System.EventHandler(this.menuItem_32_Click);
                  // 
                  // menuItem_17
                  // 
                  this.menuItem_17.Index = 5;
                  this.menuItem_17.Text = "Log";
                  this.menuItem_17.Click += new System.EventHandler(this.menuItem_17_Click);
                  // 
                  // menuItem_13
                  // 
                  this.menuItem_13.Index = 6;
                  this.menuItem_13.Text = "Record Packet";
                  this.menuItem_13.Click += new System.EventHandler(this.menuItem_13_Click);
                  // 
                  // menuItem_16
                  // 
                  this.menuItem_16.Index = 7;
                  this.menuItem_16.Text = "Auth. Server";
                  this.menuItem_16.Click += new System.EventHandler(this.menuItem_16_Click);
                  // 
                  // menuItem_19
                  // 
                  this.menuItem_19.Checked = true;
                  this.menuItem_19.Index = 8;
                  this.menuItem_19.Text = "Check Illegal Copy";
                  this.menuItem_19.Click += new System.EventHandler(this.menuItem_19_Click);
                  // 
                  // menuItem_24
                  // 
                  this.menuItem_24.Index = 9;
                  this.menuItem_24.Text = "Check SQL";
                  this.menuItem_24.Click += new System.EventHandler(this.menuItem_24_Click);
                  // 
                  // menuItem_37
                  // 
                  this.menuItem_37.Index = 10;
                  this.menuItem_37.Text = "Open Force War";
                  this.menuItem_37.Click += new System.EventHandler(this.menuItem_37_Click);
                  // 
                  // menuItem1
                  // 
                  this.menuItem1.Index = 11;
                  this.menuItem1.Text = "-";
                  // 
                  // menuItem_50
                  // 
                  this.menuItem_50.Index = 12;
                  this.menuItem_50.Text = "BOSS siege switch";
                  this.menuItem_50.Click += new System.EventHandler(this.menuItem_50_Click);
                  // 
                  // menuItem2
                  // 
                  this.menuItem2.Index = 13;
                  this.menuItem2.Text = "BOSS siege all in one";
                  this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
                  // 
                  // menuItem_53
                  // 
                  this.menuItem_53.Index = 14;
                  this.menuItem_53.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_54});
                  this.menuItem_53.Text = "A key clean open area data";
                  // 
                  // menuItem_54
                  // 
                  this.menuItem_54.Index = 0;
                  this.menuItem_54.Text = "Make sure to clear?";
                  this.menuItem_54.Click += new System.EventHandler(this.menuItem_54_Click);
                  // 
                  // menuItem_57
                  // 
                  this.menuItem_57.Index = 15;
                  this.menuItem_57.Text = "Reread accelerator detection time";
                  this.menuItem_57.Click += new System.EventHandler(this.menuItem_57_Click);
                  // 
                  // menuItem_5
                  // 
                  this.menuItem_5.Index = 2;
                  this.menuItem_5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_6,
            this.menuItem_28,
            this.menuItem_26,
            this.menuItem_39,
            this.menuItem_20,
            this.menuItem_21,
            this.menuItem_22,
            this.menuItem_7,
            this.menuItem_23,
            this.menuItem_8,
            this.menuItem_9,
            this.menuItem_10,
            this.menuItem_11,
            this.menuItem_12,
            this.menuItem_14,
            this.menuItem_33,
            this.menuItem_36,
            this.menuItem_38,
            this.menuItem_40,
            this.menuItem_42,
            this.menuItem_43,
            this.menuItem_44,
            this.menuItem_45,
            this.menuItem_46,
            this.menuItem_47,
            this.menuItem_49,
            this.menuItem_52,
            this.menuItem_55,
            this.menuItem_56,
            this.menuItem_58});
                  this.menuItem_5.Text = "Setup";
                  // 
                  // menuItem_6
                  // 
                  this.menuItem_6.Index = 0;
                  this.menuItem_6.Text = "Reload Configuration";
                  this.menuItem_6.Click += new System.EventHandler(this.menuItem_6_Click);
                  // 
                  // menuItem_28
                  // 
                  this.menuItem_28.Index = 1;
                  this.menuItem_28.Text = "Reload KongFu";
                  this.menuItem_28.Click += new System.EventHandler(this.menuItem_28_Click);
                  // 
                  // menuItem_26
                  // 
                  this.menuItem_26.Index = 2;
                  this.menuItem_26.Text = "Reload Message Filter";
                  this.menuItem_26.Click += new System.EventHandler(this.menuItem_26_Click);
                  // 
                  // menuItem_39
                  // 
                  this.menuItem_39.Enabled = false;
                  this.menuItem_39.Index = 3;
                  this.menuItem_39.Text = "Reload NPC";
                  this.menuItem_39.Click += new System.EventHandler(this.menuItem_39_Click);
                  // 
                  // menuItem_20
                  // 
                  this.menuItem_20.Index = 4;
                  this.menuItem_20.Text = "Reload Monster Data";
                  this.menuItem_20.Click += new System.EventHandler(this.menuItem_20_Click);
                  // 
                  // menuItem_21
                  // 
                  this.menuItem_21.Index = 5;
                  this.menuItem_21.Text = "Reload BOSS Drops";
                  this.menuItem_21.Click += new System.EventHandler(this.menuItem_21_Click);
                  // 
                  // menuItem_22
                  // 
                  this.menuItem_22.Index = 6;
                  this.menuItem_22.Text = "Reload New Item Drops";
                  this.menuItem_22.Click += new System.EventHandler(this.menuItem_22_Click);
                  // 
                  // menuItem_7
                  // 
                  this.menuItem_7.Index = 7;
                  this.menuItem_7.Text = "Reload Item Drops";
                  this.menuItem_7.Click += new System.EventHandler(this.menuItem_7_Click);
                  // 
                  // menuItem_23
                  // 
                  this.menuItem_23.Index = 8;
                  this.menuItem_23.Text = "Reload Supreme Mob Drops";
                  this.menuItem_23.Click += new System.EventHandler(this.menuItem_23_Click);
                  // 
                  // menuItem_8
                  // 
                  this.menuItem_8.Index = 9;
                  this.menuItem_8.Text = "Reload Chest/Box Output";
                  this.menuItem_8.Click += new System.EventHandler(this.menuItem_8_Click);
                  // 
                  // menuItem_9
                  // 
                  this.menuItem_9.Index = 10;
                  this.menuItem_9.Text = "Reload Items";
                  this.menuItem_9.Click += new System.EventHandler(this.menuItem_9_Click);
                  // 
                  // menuItem_10
                  // 
                  this.menuItem_10.Index = 11;
                  this.menuItem_10.Text = "Reload NPC Shops";
                  this.menuItem_10.Click += new System.EventHandler(this.menuItem_10_Click);
                  // 
                  // menuItem_11
                  // 
                  this.menuItem_11.Index = 12;
                  this.menuItem_11.Text = "Reload Spawn Points";
                  this.menuItem_11.Click += new System.EventHandler(this.menuItem_11_Click);
                  // 
                  // menuItem_12
                  // 
                  this.menuItem_12.Index = 13;
                  this.menuItem_12.Text = "Reload Notices";
                  this.menuItem_12.Click += new System.EventHandler(this.menuItem_12_Click);
                  // 
                  // menuItem_14
                  // 
                  this.menuItem_14.Index = 14;
                  this.menuItem_14.Text = "Reload Online";
                  this.menuItem_14.Click += new System.EventHandler(this.menuItem_14_Click);
                  // 
                  // menuItem_33
                  // 
                  this.menuItem_33.Index = 15;
                  this.menuItem_33.Text = "Reload Scripts";
                  this.menuItem_33.Click += new System.EventHandler(this.menuItem_33_Click);
                  // 
                  // menuItem_36
                  // 
                  this.menuItem_36.Index = 16;
                  this.menuItem_36.Text = "Reload Production List";
                  this.menuItem_36.Click += new System.EventHandler(this.menuItem_36_Click);
                  // 
                  // menuItem_38
                  // 
                  this.menuItem_38.Index = 17;
                  this.menuItem_38.Text = "Reload BBG Data";
                  this.menuItem_38.Click += new System.EventHandler(this.menuItem_38_Click);
                  // 
                  // menuItem_40
                  // 
                  this.menuItem_40.Index = 18;
                  this.menuItem_40.Text = "Reload Map Data";
                  this.menuItem_40.Click += new System.EventHandler(this.menuItem_40_Click);
                  // 
                  // menuItem_42
                  // 
                  this.menuItem_42.Index = 19;
                  this.menuItem_42.Text = "Reload Custom Transfers";
                  this.menuItem_42.Click += new System.EventHandler(this.menuItem_42_Click);
                  // 
                  // menuItem_43
                  // 
                  this.menuItem_43.Index = 20;
                  this.menuItem_43.Text = "Reload Reward Data";
                  this.menuItem_43.Click += new System.EventHandler(this.menuItem_43_Click);
                  // 
                  // menuItem_44
                  // 
                  this.menuItem_44.Index = 21;
                  this.menuItem_44.Text = "Reload Exchange Data";
                  this.menuItem_44.Click += new System.EventHandler(this.menuItem_44_Click);
                  // 
                  // menuItem_45
                  // 
                  this.menuItem_45.Index = 22;
                  this.menuItem_45.Text = "Reload Set Attribute Data";
                  this.menuItem_45.Click += new System.EventHandler(this.menuItem_45_Click);
                  // 
                  // menuItem_46
                  // 
                  this.menuItem_46.Index = 23;
                  this.menuItem_46.Text = "Reload Set Lists";
                  this.menuItem_46.Click += new System.EventHandler(this.menuItem_46_Click);
                  // 
                  // menuItem_47
                  // 
                  this.menuItem_47.Index = 24;
                  this.menuItem_47.Text = "Reload Online Rewards";
                  this.menuItem_47.Click += new System.EventHandler(this.menuItem_47_Click);
                  // 
                  // menuItem_49
                  // 
                  this.menuItem_49.Index = 25;
                  this.menuItem_49.Text = "Rereading the number of bonus data reincarnation";
                  this.menuItem_49.Click += new System.EventHandler(this.menuItem_49_Click);
                  // 
                  // menuItem_52
                  // 
                  this.menuItem_52.Index = 26;
                  this.menuItem_52.Text = "Rereading stone property data";
                  this.menuItem_52.Click += new System.EventHandler(this.menuItem_52_Click);
                  // 
                  // menuItem_55
                  // 
                  this.menuItem_55.Index = 27;
                  this.menuItem_55.Text = "Rereading the safety zone";
                  this.menuItem_55.Click += new System.EventHandler(this.menuItem_55_Click);
                  // 
                  // menuItem_56
                  // 
                  this.menuItem_56.Index = 28;
                  this.menuItem_56.Text = "Rereading days off map configuration";
                  this.menuItem_56.Click += new System.EventHandler(this.menuItem_56_Click);
                  // 
                  // menuItem_58
                  // 
                  this.menuItem_58.Index = 29;
                  this.menuItem_58.Text = "Rereading murder prompted data";
                  this.menuItem_58.Click += new System.EventHandler(this.menuItem_58_Click);
                  // 
                  // menuItem_34
                  // 
                  this.menuItem_34.Index = 3;
                  this.menuItem_34.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_35,
            this.menuItem_41,
            this.menuItem_51});
                  this.menuItem_34.Text = "Tool";
                  this.menuItem_34.Click += new System.EventHandler(this.menuItem_34_Click);
                  // 
                  // menuItem_35
                  // 
                  this.menuItem_35.Index = 0;
                  this.menuItem_35.Text = "Mission Modifiers";
                  this.menuItem_35.Click += new System.EventHandler(this.menuItem_35_Click);
                  // 
                  // menuItem_41
                  // 
                  this.menuItem_41.Index = 1;
                  this.menuItem_41.Text = "YBI Modifiers (8012+)";
                  this.menuItem_41.Click += new System.EventHandler(this.menuItem_41_Click);
                  // 
                  // menuItem_51
                  // 
                  this.menuItem_51.Index = 2;
                  this.menuItem_51.Text = "Copy search items";
                  this.menuItem_51.Click += new System.EventHandler(this.menuItem_51_Click);
                  // 
                  // menuItem_48
                  // 
                  this.menuItem_48.Index = 4;
                  this.menuItem_48.Text = "About the Software";
                  this.menuItem_48.Click += new System.EventHandler(this.menuItem_48_Click);
                  // 
                  // timer_3
                  // 
                  this.timer_3.Enabled = true;
                  this.timer_3.Interval = 1000;
                  this.timer_3.Tick += new System.EventHandler(this.f);
                  // 
                  // toolStrip1
                  // 
                  this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripComboBox2,
            this.toolStripButton1,
            this.toolStripTextBox2,
            this.toolStripComboBox1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripButton3,
            this.toolStripSeparator2,
            this.toolStripButton4});
                  this.toolStrip1.Location = new System.Drawing.Point(0, 0);
                  this.toolStrip1.Name = "toolStrip1";
                  this.toolStrip1.Size = new System.Drawing.Size(650, 25);
                  this.toolStrip1.TabIndex = 15;
                  this.toolStrip1.Text = "toolStrip1";
                  // 
                  // toolStripTextBox1
                  // 
                  this.toolStripTextBox1.Name = "toolStripTextBox1";
                  this.toolStripTextBox1.Size = new System.Drawing.Size(200, 25);
                  // 
                  // toolStripComboBox2
                  // 
                  this.toolStripComboBox2.DropDownWidth = 75;
                  this.toolStripComboBox2.IntegralHeight = false;
                  this.toolStripComboBox2.Items.AddRange(new object[] {
            "正常",
            "加密"});
                  this.toolStripComboBox2.Name = "toolStripComboBox2";
                  this.toolStripComboBox2.Size = new System.Drawing.Size(90, 25);
                  this.toolStripComboBox2.Text = "Normal";
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
                  // toolStripTextBox2
                  // 
                  this.toolStripTextBox2.Name = "toolStripTextBox2";
                  this.toolStripTextBox2.Size = new System.Drawing.Size(99, 25);
                  this.toolStripTextBox2.Text = "Empty";
                  // 
                  // toolStripComboBox1
                  // 
                  this.toolStripComboBox1.Items.AddRange(new object[] {
            "10",
            "9"});
                  this.toolStripComboBox1.Name = "toolStripComboBox1";
                  this.toolStripComboBox1.Size = new System.Drawing.Size(90, 25);
                  this.toolStripComboBox1.Text = "10";
                  // 
                  // toolStripButton2
                  // 
                  this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
                  this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
                  this.toolStripButton2.Name = "toolStripButton2";
                  this.toolStripButton2.Size = new System.Drawing.Size(38, 22);
                  this.toolStripButton2.Text = "Send";
                  this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
                  // 
                  // toolStripSeparator1
                  // 
                  this.toolStripSeparator1.Name = "toolStripSeparator1";
                  this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
                  // 
                  // toolStripButton3
                  // 
                  this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
                  this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
                  this.toolStripButton3.Name = "toolStripButton3";
                  this.toolStripButton3.Size = new System.Drawing.Size(86, 19);
                  this.toolStripButton3.Text = "Send Number";
                  this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
                  // 
                  // toolStripSeparator2
                  // 
                  this.toolStripSeparator2.Name = "toolStripSeparator2";
                  this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
                  // 
                  // toolStripButton4
                  // 
                  this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
                  this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
                  this.toolStripButton4.Name = "toolStripButton4";
                  this.toolStripButton4.Size = new System.Drawing.Size(44, 19);
                  this.toolStripButton4.Text = "Check";
                  this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
                  // 
                  // LogTextBox
                  // 
                  this.LogTextBox.BackColor = System.Drawing.Color.Black;
                  this.LogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                  this.LogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
                  this.LogTextBox.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                  this.LogTextBox.Location = new System.Drawing.Point(0, 25);
                  this.LogTextBox.Name = "LogTextBox";
                  this.LogTextBox.Size = new System.Drawing.Size(650, 409);
                  this.LogTextBox.TabIndex = 16;
                  this.LogTextBox.Text = "";
                  // 
                  // Logtimer
                  // 
                  this.Logtimer.Enabled = true;
                  this.Logtimer.Tick += new System.EventHandler(this.Logtimer_Tick);
                  // 
                  // Form1
                  // 
                  this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
                  this.BackColor = System.Drawing.SystemColors.Control;
                  this.ClientSize = new System.Drawing.Size(650, 455);
                  this.Controls.Add(this.LogTextBox);
                  this.Controls.Add(this.toolStrip1);
                  this.Controls.Add(this.statusBar1);
                  this.Menu = this.mainMenu_0;
                  this.Name = "Form1";
                  this.Text = "GameServer";
                  this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
                  this.Load += new System.EventHandler(this.Form1_Load);
                  this.Layout += new System.Windows.Forms.LayoutEventHandler(this.Form1_Layout);
                  ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel4)).EndInit();
                  this.toolStrip1.ResumeLayout(false);
                  this.toolStrip1.PerformLayout();
                  this.ResumeLayout(false);
                  this.PerformLayout();

		}

		[STAThread]
		private static void Main()
		{
			try
			{
				Application.Run(new Form1());
			}
			catch (Exception exception)
			{
				MessageBox.Show(string.Concat("Main Error", exception));
			}
		}

		private void menuItem_1_Click(object sender, EventArgs e)
		{
			if (this.class70_0 != null)
			{
				this.menuItem_1.Text = "Start Main Service";
				this.class70_0.method_1();
				this.class70_0 = null;
				return;
			}
			this.menuItem_1.Text = "Stop the main service";
			int num = (new Random()).Next(10, 100);
			this.class70_0 = new Listener(World.Game_server_port + num);
		}

		private void menuItem_10_Click(object sender, EventArgs e)
		{
			Form1.world.SetNPC_Sell();
		}

		private void menuItem_11_Click(object sender, EventArgs e)
		{
			Form1.world.SetMover();
		}

		private void menuItem_12_Click(object sender, EventArgs e)
		{
			Form1.world.Set_THONG_BAO();
		}

		private void menuItem_13_Click(object sender, EventArgs e)
		{
			if (this.menuItem_13.Checked)
			{
				this.menuItem_13.Checked = false;
				World.Log = 0;
				return;
			}
			this.menuItem_13.Checked = true;
			World.Log = 1;
		}

		private void menuItem_14_Click(object sender, EventArgs e)
		{
			Form1.world.SetConfig();
			Form1.world.SetConfig2();
			Form1.world.SetConfig3();
			Form1.world.SetConfig4();
			World.class20_0.method_4(string.Concat(new object[] { "Updating the server configuration|", World.Server_ID, "|", World.Maximum_Online }));
			Form1.WriteLine(2, "Reload the server configuration to complete party member");
		}

		private void menuItem_15_Click(object sender, EventArgs e)
		{
			List<Players> players = new List<Players>();
			foreach (Players value in World.allConnectedChars.Values)
			{
				players.Add(value);
			}
			foreach (Players player in players)
			{
				try
				{
					player.LUU_NHAN_VAT_SO_LIEU();
				}
				catch (Exception exception1)
				{
					Exception exception = exception1;
					Form1.WriteLine(1, string.Concat("CAP_NHAT_NHAN_VAT_SO_LIEU ERROR", exception.Message));
				}
			}
			players.Clear();
			Form1.WriteLine(8, "Save Char Data Completed");
		}

		private void menuItem_16_Click(object sender, EventArgs e)
		{
			if (this.menuItem_16.Checked)
			{
				this.menuItem_16.Checked = false;
				World.int_127 = 0;
				return;
			}
			this.menuItem_16.Checked = true;
			World.int_127 = 1;
		}

		private void menuItem_17_Click(object sender, EventArgs e)
		{
			if (this.menuItem_17.Checked)
			{
				this.menuItem_17.Checked = false;
				World.int_128 = 0;
				return;
			}
			this.menuItem_17.Checked = true;
			World.int_128 = 1;
		}

		private void menuItem_18_Click(object sender, EventArgs e)
		{
			if (this.menuItem_18.Checked)
			{
				this.menuItem_18.Checked = false;
				World.bool_1 = false;
				return;
			}
			this.menuItem_18.Checked = true;
			World.bool_1 = true;
		}

		private void menuItem_19_Click(object sender, EventArgs e)
		{
			try
			{
				if (!this.menuItem_19.Checked)
				{
					this.menuItem_19.Checked = true;
					World.AllItmelog = 1;
				}
				else
				{
					this.menuItem_19.Checked = false;
					World.AllItmelog = 0;
				}
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				Form1.WriteLine(1, string.Concat("TIM_VAT_PHAM_LOI    LOI", exception.Message));
			}
		}

		private void menuItem_2_Click(object sender, EventArgs e)
		{
			World.class20_0.method_1();
			List<Players> players = new List<Players>();
			foreach (Players value in World.allConnectedChars.Values)
			{
				players.Add(value);
			}
			foreach (Players player in players)
			{
				try
				{
					if (player.Client != null)
					{
						player.Client.Dispose();
					}
				}
				catch (Exception exception1)
				{
					Exception exception = exception1;
					Form1.WriteLine(1, string.Concat("CAP_NHAT_NHAN_VAT_SO_LIEU LOI", exception.Message));
				}
			}
			players.Clear();
		}

		private void menuItem_20_Click(object sender, EventArgs e)
		{
			Form1.world.SetMonSter();
		}

		private void menuItem_21_Click(object sender, EventArgs e)
		{
			Form1.world.SetBossDrop();
		}

		private void menuItem_22_Click(object sender, EventArgs e)
		{
			Form1.world.SetNpcDrop();
		}

		private void menuItem_23_Click(object sender, EventArgs e)
		{
			Form1.world.Set_GSDrop();
		}

		private void menuItem_24_Click(object sender, EventArgs e)
		{
			if (this.menuItem_24.Checked)
			{
				this.menuItem_24.Checked = false;
				World.jlMsg = 0;
				return;
			}
			this.menuItem_24.Checked = true;
			World.jlMsg = 1;
		}

		private void menuItem_25_Click(object sender, EventArgs e)
		{
			(new FormUser()).ShowDialog();
		}

		private void menuItem_26_Click(object sender, EventArgs e)
		{
			Form1.world.method_15();
			Form1.world.method_14();
		}

		private void menuItem_27_Click(object sender, EventArgs e)
		{
			if (!this.runn)
			{
				this.runn = true;
				Form1.thread_0.Abort();
				this.thThreadRead.Abort();
				return;
			}
			this.thThreadRead = new Thread(new ThreadStart(this.FlushAll))
			{
				Name = "FlushAll"
			};
			this.thThreadRead.Start();
			Form1.thread_0 = new Thread(new ThreadStart(new TimerClass.Class128().method_0))
			{
				Name = "Timer Thread"
			};
			Form1.thread_0.Start();
		}

		private void menuItem_28_Click(object sender, EventArgs e)
		{
			Form1.world.SetKONGFU();
		}

		private void menuItem_29_Click(object sender, EventArgs e)
		{
			(new BinIP()).ShowDialog();
		}

		private void menuItem_30_Click(object sender, EventArgs e)
		{
			if (World.class20_0 != null)
			{
				World.class20_0.method_1();
				World.class20_0 = null;
			}
			World.class20_0 = new Connect();
			World.class20_0.method_0();
		}

		private void menuItem_31_Click(object sender, EventArgs e)
		{
			(new Form2()).ShowDialog();
		}

		private void menuItem_32_Click(object sender, EventArgs e)
		{
			if (this.menuItem_32.Checked)
			{
				this.menuItem_32.Checked = false;
				World.bool_0 = false;
				return;
			}
			this.menuItem_32.Checked = true;
			World.bool_0 = true;
		}

		private void menuItem_33_Click(object sender, EventArgs e)
		{
			Form1.world.SetScript();
		}

		private void menuItem_34_Click(object sender, EventArgs e)
		{
		}

		private void menuItem_35_Click(object sender, EventArgs e)
		{
			(new YbQForm()).ShowDialog();
		}

		private void menuItem_36_Click(object sender, EventArgs e)
		{
			Form1.world.Set_CHE_TAO_VAT_PHAM();
		}

		private void menuItem_37_Click(object sender, EventArgs e)
		{
			if (World.eve == null)
			{
				World.eve = new EventClass();
				Form1.WriteLine(2, "Open Force of War");
				return;
			}
			World.eve.Dispose();
			Form1.WriteLine(2, "Close Force of War");
		}

		private void menuItem_38_Click(object sender, EventArgs e)
		{
			Form1.world.SetItemShop();
		}

		private void menuItem_39_Click(object sender, EventArgs e)
		{
			Queue queues = Queue.Synchronized(new Queue());
			foreach (MapClass value in World.dictionary_12.Values)
			{
				foreach (TBL_XWWL_NPC tBLXWWLNPC in value.dictionary_0.Values)
				{
					queues.Enqueue(tBLXWWLNPC);
				}
			}
			while (queues.Count > 0)
			{
				((TBL_XWWL_NPC)queues.Dequeue()).Dispose();
			}
		}

		private void menuItem_4_Click(object sender, EventArgs e)
		{
			(new UserList()).ShowDialog();
		}

		private void menuItem_40_Click(object sender, EventArgs e)
		{
			Form1.world.SetMAP();
		}

		private void menuItem_41_Click(object sender, EventArgs e)
		{
			(new YbiForm()).ShowDialog();
		}

		private void menuItem_42_Click(object sender, EventArgs e)
		{
			Form1.world.LOAD_DINH_NGHIA_CHUYEN_CHUC_THUOC_TINH();
		}

		private void menuItem_43_Click(object sender, EventArgs e)
		{
			Form1.world.LOAD_DANG_CAP_KHEN_THUONG();
		}

		private void menuItem_44_Click(object sender, EventArgs e)
		{
			Form1.world.LOAD_ITEM_TRAO_DOI();
		}

		private void menuItem_45_Click(object sender, EventArgs e)
		{
			Form1.world.SetTZ();
		}

		private void menuItem_46_Click(object sender, EventArgs e)
		{
			Form1.world.SetTZlist();
		}

		private void menuItem_47_Click(object sender, EventArgs e)
		{
			Form1.world.LOAD_TRUC_TUYEN_THOI_GIAN_KHEN_THUONG();
		}

		private void menuItem_48_Click(object sender, EventArgs e)
		{
			(new Side()).Show();
		}

		private void menuItem_49_Click(object sender, EventArgs e)
		{
			Form1.world.LOAD_CHUYEN_SINH_SO_LAN_KHEN_THUONG();
		}

		private void menuItem_50_Click(object sender, EventArgs e)
		{
			if (World.class76_0 == null)
			{
				World.class76_0 = new THIET_LAP_BOSS_CLASS();
				Form1.WriteLine(2, "BOSS Siege began");
				return;
			}
			World.class76_0.Dispose();
			Form1.WriteLine(2, "BOSS End Siege");
		}

		private void menuItem_51_Click(object sender, EventArgs e)
		{
			(new CheckCopy()).ShowDialog();
		}

		private void menuItem_52_Click(object sender, EventArgs e)
		{
			Form1.world.method_19();
		}

		private void menuItem_54_Click(object sender, EventArgs e)
		{
			string str = string.Format("DELETE FROM TBL_ACCOUNT", new object[0]);
			string str1 = string.Format("DELETE FROM TBL_XWWL_Char", new object[0]);
			string str2 = string.Format("DELETE FROM EventTop", new object[0]);
			string str3 = string.Format("DELETE FROM TBL_XWWL_Cw", new object[0]);
			string str4 = string.Format("DELETE FROM TBL_XWWL_Guild", new object[0]);
			string str5 = string.Format("DELETE FROM TBL_XWWL_GuildMember", new object[0]);
			string str6 = string.Format("DELETE FROM TBL_XWWL_PublicWarehouse", new object[0]);
			string str7 = string.Format("DELETE FROM TBL_XWWL_Warehouse", new object[0]);
			string str8 = string.Format("DELETE FROM BACH_BAO_GHI_CHEP", new object[0]);
			string str9 = string.Format("DELETE FROM DANG_NHAP_GHI_CHEP", new object[0]);
			string str10 = string.Format("DELETE FROM ITEM_GHI_CHEP", new object[0]);
			string str11 = string.Format("DELETE FROM ITEM_GHI_CHEP", new object[0]);
			DBA.smethod_7(str, "rxjhaccount");
			DBA.smethod_7(str1, "GameServer");
			DBA.smethod_7(str2, "GameServer");
			DBA.smethod_7(str3, "GameServer");
			DBA.smethod_7(str4, "GameServer");
			DBA.smethod_7(str5, "GameServer");
			DBA.smethod_7(str6, "GameServer");
			DBA.smethod_7(str7, "GameServer");
			DBA.smethod_7(str8, "GameServer");
			DBA.smethod_7(str9, "GameServer");
			DBA.smethod_7(str10, "GameServer");
			DBA.smethod_7(str11, "GameServer");
			Form1.WriteLine(2, "All account data character data has been completed clean-up~");
		}

		private void menuItem_55_Click(object sender, EventArgs e)
		{
			Form1.world.method_11();
		}

		private void menuItem_56_Click(object sender, EventArgs e)
		{
			Form1.world.method_10();
		}

		private void menuItem_57_Click(object sender, EventArgs e)
		{
			Form1.world.SetConfig();
			Form1.WriteLine(2, "Accelerator time the reload is complete");
		}

		private void menuItem_58_Click(object sender, EventArgs e)
		{
			Form1.world.method_29();
		}

		private void menuItem_6_Click(object sender, EventArgs e)
		{
			Form1.world.SetDrop();
			Form1.world.SetOpen();
			Form1.world.SetLever();
			Form1.world.SetKONGFU();
			Form1.world.SetItme();
			Form1.world.SetNPC_Sell();
			Form1.world.SetMover();
			Form1.world.Set_THONG_BAO();
			Form1.world.SetMAP();
			Form1.world.SetItemShop();
			Form1.world.LOAD_DINH_NGHIA_CHUYEN_CHUC_THUOC_TINH();
			Form1.world.LOAD_DANG_CAP_KHEN_THUONG();
			Form1.world.LOAD_TRUC_TUYEN_THOI_GIAN_KHEN_THUONG();
			Form1.world.LOAD_CHUYEN_SINH_SO_LAN_KHEN_THUONG();
			Form1.world.LOAD_ITEM_TRAO_DOI();
			Form1.world.method_19();
		}

		private void menuItem_7_Click(object sender, EventArgs e)
		{
			Form1.world.SetDrop();
		}

		private void menuItem_8_Click(object sender, EventArgs e)
		{
			Form1.world.SetOpen();
		}

		private void menuItem_9_Click(object sender, EventArgs e)
		{
			Form1.world.SetItme();
		}

		private void menuItem2_Click(object sender, EventArgs e)
		{
			if (World.boss2 == null)
			{
				World.boss2 = new THIET_LAP_BOSS_CLASS2();
				Form1.WriteLine(2, "BOS SSiege began");
				return;
			}
			World.boss2.Dispose();
			Form1.WriteLine(2, "BOSS End Siege");
		}

		public void method_0()
		{
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "Automatic event announcement");
			}
			this.method_3();
			if (World.dictionary_10.Count > 0)
			{
				TBL_XWWL_Gg item = World.dictionary_10[this.int_0];
				this.e(item.msg, item.type);
				this.int_0 = this.int_0 + 1;
				if (this.int_0 >= World.dictionary_10.Count)
				{
					this.int_0 = 0;
				}
			}
			if (World.Tu_dong_luu_tru == 1)
			{
				this.menuItem_15.PerformClick();
			}
			try
			{
				if (World.allConnectedChars.Count > World.threadSafeDictionary_0.Count)
				{
					Queue queues = Queue.Synchronized(new Queue());
					foreach (Players value in World.allConnectedChars.Values)
					{
						queues.Enqueue(value);
					}
					while (queues.Count > 0)
					{
						Players player = (Players)queues.Dequeue();
						if (World.threadSafeDictionary_0.ContainsKey(player.UserSessionID))
						{
							continue;
						}
						World.allConnectedChars.Remove(player.UserSessionID);
					}
					if (World.allConnectedChars.Count > World.threadSafeDictionary_0.Count)
					{
						World.class20_0.method_1();
						this.menuItem_2.PerformClick();
						World.Tu_dong_luu_tru = 0;
					}
				}
				if (World.ITEM_GHI_CHEP == 1)
				{
					DBA.ExeSqlCommand(string.Concat("DELETE FROM ITEM_GHI_CHEP WHERE  DateDiff(dd,Thoi_gian,getdate())>", World.Ghi_chep_bao_ton_Thang_thien));
				}
				if (World.DANG_NHAP_GHI_CHEP == 1)
				{
					DBA.ExeSqlCommand(string.Concat("DELETE FROM DANG_NHAP_GHI_CHEP WHERE  DateDiff(dd,Thoi_gian,getdate())>", World.Ghi_chep_bao_ton_Thang_thien));
				}
			}
			catch
			{
			}
		}

		public void method_1(byte[] byte_0, int int_3)
		{
			byte[] numArray = new byte[BitConverter.ToInt16(byte_0, 9) + 7];
			Buffer.BlockCopy(byte_0, 5, numArray, 0, (int)numArray.Length);
			this.method_2(numArray, (int)numArray.Length);
		}

		private void method_2(byte[] byte_0, int int_3)
		{
			byte[] numArray = new byte[int_3 + 15];
			numArray[0] = 170;
			numArray[1] = 85;
			Buffer.BlockCopy(BitConverter.GetBytes(int_3 + 9), 0, numArray, 2, 2);
			Buffer.BlockCopy(byte_0, 0, numArray, 5, int_3);
			numArray[(int)numArray.Length - 2] = 85;
			numArray[(int)numArray.Length - 1] = 170;
			Console.WriteLine(Converter.smethod_24(numArray));
		}

		public void method_3()
		{
			try
			{
				StringBuilder stringBuilder = new StringBuilder();
				foreach (NetState value in World.threadSafeDictionary_0.Values)
				{
					stringBuilder.Append(value.Player.Userid);
					stringBuilder.Append("-");
					stringBuilder.Append(value.ToString());
					stringBuilder.Append(",");
				}
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Remove(stringBuilder.Length - 1, 1);
				}
				World.class20_0.method_4(string.Concat("复查用户登陆|", stringBuilder));
				if (World.AutGC != 0)
				{
					GC.Collect();
				}
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				Form1.WriteLine(1, string.Concat("Review User Login Error", exception.Message));
			}
		}

		private void method_4(object sender, EventArgs e)
		{
			(new Thread(new ThreadStart(Form2.smethod_0))
			{
				Name = "Timer Thread"
			}).Start();
		}

		private void method_5(object sender, EventArgs e)
		{
			(new Thread(new ThreadStart(Form2.smethod_1))
			{
				Name = "Timer Thread"
			}).Start();
		}

		private void method_6(object sender, EventArgs e)
		{
			(new Thread(new ThreadStart(Form2.smethod_2))
			{
				Name = "Timer Thread"
			}).Start();
		}

		private void method_7(object sender, EventArgs e)
		{
			(new Thread(new ThreadStart(Form2.smethod_3))
			{
				Name = "Timer Thread"
			}).Start();
		}

		private static void Thread1()
		{
			try
			{
				LuaFunction function = World.scriptClass_0.pLuaVM.GetFunction("OpenItmeTrigGer");
				if (function != null)
				{
					function.Call(new object[] { 0, 100, 0, 1 });
				}
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception);
			}
		}

		private void timer_1_Elapsed(object sender, ElapsedEventArgs e)
		{
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "Idiom event");
			}
			World.smethod_6();
		}

		private void timer_2_Elapsed(object sender, ElapsedEventArgs e)
		{
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "Automatic connection event()");
			}
			this.timer_2.Interval = (double)(World.AtPort * 1000);
			if (!World.bool_5 && World.Automatically_open_connection)
			{
				if (this.class70_0 != null)
				{
					this.class70_0.method_1();
				}
				int num = (new Random()).Next(10, 100);
				this.class70_0 = new Listener(World.Game_server_port + num);
			}
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			try
			{
				byte[] numArray = Converter.smethod_28(this.toolStripTextBox1.Text);
				foreach (NetState value in World.threadSafeDictionary_0.Values)
				{
					if (value == null)
					{
						continue;
					}
					if (this.toolStripComboBox2.Text != "Normal")
					{
						value.method_8(numArray, (int)numArray.Length);
					}
					else
					{
						Buffer.BlockCopy(BitConverter.GetBytes(value.int_3), 0, numArray, 5, 2);
						value.method_11(numArray, (int)numArray.Length);
						this.method_1(numArray, (int)numArray.Length);
					}
				}
			}
			catch
			{
			}
			this.int_1 = this.int_1 + 1;
		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (Players value in World.allConnectedChars.Values)
				{
					if (value == null)
					{
						continue;
					}
					value.GameMessage(this.toolStripTextBox2.Text, int.Parse(this.toolStripComboBox1.SelectedItem.ToString()), "system message");
				}
			}
			catch
			{
			}
		}

		private void toolStripButton3_Click(object sender, EventArgs e)
		{
			this.method_3();
		}

		private void toolStripButton4_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (MapClass value in World.dictionary_12.Values)
				{
					foreach (TBL_XWWL_NPC tBLXWWLNPC in value.dictionary_0.Values)
					{
						tBLXWWLNPC.method_7();
					}
				}
				foreach (TO_DOI_CLASS tODOICLAss in World.W_TO_DOI.Values)
				{
					Form1.WriteLine(2, string.Concat(new object[] { "Team:", tODOICLAss.int_0, " Character：", tODOICLAss.dictionary_0.Count }));
					foreach (Players player in tODOICLAss.dictionary_0.Values)
					{
						Form1.WriteLine(2, string.Concat("Group members:", player.Userid, " Character：", player.UserName));
					}
				}
				foreach (Players value1 in World.allConnectedChars.Values)
				{
				}
				foreach (object list16 in World.list_16)
				{
					Form1.WriteLine(2, list16.ToString());
				}
			}
			catch (Exception exception)
			{
				Form1.WriteLine(1, exception.ToString());
			}
			GC.Collect();
		}

            #region 로그메세지 표시 
            public static void WriteLine(int int_3, string string_0)
		{

                  List<TxtClass> list0 = Form1.list_0;
                  Monitor.Enter(list0);
                  try
                  {
                        list0.Add(new TxtClass(int_3, string_0));
                  }
                  catch
                  {
                  }
                  finally
                  {
                        Monitor.Exit(list0);
                  }
		}

            private void LogWrite(int type, string text)
            {
                  try
                  {
                        Color _color = Color.White;

                        switch (type)
                        {
                              case 0:
                                    {
                                          _color = Color.White;
                                          break;
                                    }
                              case 1:
                                    {
                                          _color = Color.Red;
                                          break;
                                    }
                              case 2:
                                    {
                                          _color = Color.LimeGreen;
                                          break;
                                    }
                              case 3:
                                    {
                                          _color = Color.Green;
                                          break;
                                    }
                              case 4:
                                    {
                                          _color = Color.DeepSkyBlue;
                                          break;
                                    }
                              default:
                                    {
                                          _color = Color.White;
                                          break;
                                    }
                        }

                        if (text != string.Empty)
                        {
                              StringBuilder _Message = new StringBuilder();
                              _Message.Append(DateTime.Now.ToString("[yyyy-MM-dd hh:mm:ss]") + " ");
                              _Message.Append(text).AppendLine();


                              if (LogTextBox.InvokeRequired)
                              {
                                    LogTextBox.BeginInvoke(new Action(() =>
                                    {
                                          LogTextBox.SelectionColor = _color;
                                          LogTextBox.AppendText(_Message.ToString());
                                    }));

                              }
                              else
                              {
                                    LogTextBox.SelectionColor = _color;
                                    LogTextBox.AppendText(_Message.ToString());
                              }
                        }
                  }                  
                  catch
                  {
                  }                  

            }

            private void Logtimer_Tick(object sender, EventArgs e)
            {
                  List<TxtClass> list0 = Form1.list_0;
                  Monitor.Enter(list0);
                  try
                  {

                        if (list0.Count > 0)
                        {
                              LogWrite(list0[0].type, list0[0].Txt);
                              list0.RemoveAt(0);
                        }

                  }
                  catch
                  {
                  }
                  finally
                  {
                        Monitor.Exit(list0);
                  }
            }
            #endregion

            private static void ZYDNGuard()
		{
			Form1.list_0 = new List<TxtClass>();
			Form1.int_2 = 300;
		}
                        
      }
}