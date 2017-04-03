using ns12;
using ns2;
using ns8;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ns3
{
	internal class YbiForm : Form
	{
            Dictionary<string, int> dictionary_1;
            private Button button1;

		private Button button2;

		private byte[] byte_0 = new byte[256];

		private byte[] byte_1 = new byte[] { 45, 151, 132, 242, 40, 209, 41, 84, 241, 18, 2, 40, 107, 32, 97, 66, 245, 236, 31, 82, 34, 68, 59, 35, 87, 63, 98, 111, 242, 163, 36, 210, 167, 22, 86, 193, 242, 2, 72, 98, 39, 66, 33, 172, 35, 173, 67, 242, 50, 24, 4, 80, 69, 113, 191, 110, 120, 97, 114, 88, 34, 146, 22, 2, 120, 98, 215, 40, 82, 223, 232, 179, 66, 20, 177, 166, 110, 49, 175, 38, 33, 179, 215, 84, 233, 47, 114, 44, 63, 81, 244, 17, 2, 242, 183, 64, 37, 195, 37, 130, 67, 50, 36, 241, 238, 255, 66, 18, 4, 158, 47, 249, 100, 33, 246, 49, 114, 8, 116, 130, 35, 25, 222, 207, 35, 39, 56, 54, 237, 242, 73, 98, 113, 40, 232, 34, 59, 183, 53, 66, 119, 66, 47, 164, 66, 39, 148, 2, 98, 167 };

		private byte[] byte_10 = new byte[98304];

		private byte[] byte_11 = new byte[6897664];

		private byte[] byte_12 = new byte[16309568];

		private byte[] byte_13 = new byte[16097280];

		private static byte[] byte_2;

		private byte[] byte_3 = new byte[64];

		private byte[] byte_4 = new byte[9216];

		private byte[] byte_5 = new byte[102400];

		private byte[] byte_6 = new byte[131072];

		private byte[] byte_7 = new byte[262144];

		private byte[] byte_8 = new byte[1421312];

		private byte[] byte_9 = new byte[96];

		private ComboBox comboBox1;

		public static Dictionary<int, TBL_XWWL_ITEM_CLASS> dictionary_0;

		private GroupBox groupBox1;

		private GroupBox groupBox2;

		private GroupBox groupBox3;

		private IContainer icontainer_0 = new System.ComponentModel.Container();

		private Label label1;

		private Label label10;

		private Label label11;

		private Label label12;

		private Label label13;

		private Label label14;

		private Label label15;

		private Label label16;

		private Label label17;

		private Label label18;

		private Label label19;

		private Label label2;

		private Label label20;

		private Label label21;

		private Label label25;

		private Label label27;

		private Label label28;

		private Label label3;

		private Label label4;

		private Label label5;

		private Label label6;

		private Label label7;

		private Label label8;

		private Label label9;

		private ListBox listBox1;

		private MenuStrip menuStrip1;

		private RadioButton radioButton1;

		private RadioButton radioButton2;

		private TextBox textBox1;

		private TextBox textBox10;

		private TextBox textBox11;

		private TextBox textBox12;

		private TextBox textBox13;

		private TextBox textBox14;

		private TextBox textBox15;

		private TextBox textBox2;

		private TextBox textBox21;

		private TextBox textBox22;

		private TextBox textBox23;

		private TextBox textBox24;

		private TextBox textBox25;

		private TextBox textBox26;

		private TextBox textBox3;

		private TextBox textBox4;

		private TextBox textBox5;

		private TextBox textBox6;

		private TextBox textBox7;

		private TextBox textBox8;

		private TextBox textBox9;

		private ToolStripMenuItem 保存YBIToolStripMenuItem;

		private ToolStripMenuItem 打开YBIToolStripMenuItem;

		private ToolStripMenuItem 功能ToolStripMenuItem;

		private ToolStripMenuItem 文件ToolStripMenuItem;

		private ToolStripMenuItem VAT_PHAM入库ToolStripMenuItem;

		static YbiForm()
		{
			YbiForm.ZYDNGuard();
		}

		public YbiForm()
		{
			this.InitializeComponent();
			int num = 0;
			do
			{
				this.byte_0[num] = (byte)(num >> 4 & 1 | num >> 2 & 24 | num >> 1 & 64 | 2 * (num & 3 | 4 * (num & 4 | 2 * (num & 248))));
				num++;
			}
			while (num < 256);
		}

		private void b(object sender, FormClosingEventArgs e)
		{
			try
			{
				if (YbiForm.dictionary_0 != null)
				{
					YbiForm.dictionary_0.Clear();
				}
				this.byte_12 = null;
				this.byte_3 = null;
				this.byte_11 = null;
				this.byte_8 = null;
				this.byte_4 = null;
				this.byte_6 = null;
				this.byte_7 = null;
				this.byte_13 = null;
				this.byte_9 = null;
				this.byte_5 = null;
				this.byte_10 = null;
			}
			catch (Exception exception)
			{
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (this.listBox1.Items.Count == 0)
			{
				MessageBox.Show("请先打开Ybi.cfg文件!", "提示");
				return;
			}
			if (this.textBox1.Text == "")
			{
				MessageBox.Show("请先选择要修改的VAT_PHAM!", "提示");
				return;
			}
			if (this.textBox14.Text.Length > 120)
			{
				MessageBox.Show("装备说明不能超过120个文字!");
				return;
			}
			if (this.textBox3.Text.Length > 15)
			{
				MessageBox.Show("装备名称不能超过15个文字!");
				return;
			}
			TBL_XWWL_ITEM_CLASS text = this.method_0(int.Parse(this.textBox1.Text));
			if (text == null)
			{
				MessageBox.Show("查找VAT_PHAM出错!");
				return;
			}
			text.FLD_QUESTITEM = int.Parse(this.textBox2.Text);
			text.FLD_Name = this.textBox3.Text;
			text.FLD_NJ = int.Parse(this.textBox4.Text);
			text.FLD_RESIDE1 = int.Parse(this.textBox5.Text);
			text.FLD_RESIDE2 = int.Parse(this.textBox6.Text);
			text.FLD_SEX = int.Parse(this.textBox7.Text);
			text.FLD_DF = int.Parse(this.textBox8.Text);
			text.FLD_AT1 = int.Parse(this.textBox9.Text);
			text.FLD_AT2 = int.Parse(this.textBox10.Text);
			text.FLD_LEVEL = int.Parse(this.textBox11.Text);
			text.FLD_JOB_LEVEL = int.Parse(this.textBox12.Text);
			text.FLD_ZX = int.Parse(this.textBox13.Text);
			text.FLD_THUYET_MINH = this.textBox14.Text;
			text.FLD_TYPE = int.Parse(this.textBox21.Text);
			text.FLD_WEIGHT = int.Parse(this.textBox22.Text);
			text.FLD_MONEY = int.Parse(this.textBox23.Text);
			text.FLD_EL = int.Parse(this.textBox24.Text);
			text.FLD_WXJD = int.Parse(this.textBox25.Text);
			text.FLD_WX = int.Parse(this.textBox26.Text);
			MessageBox.Show("修改成功!");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int num;
			if (this.listBox1.Items.Count == 0)
			{
				MessageBox.Show("请先打开Ybi.cfg文件!", "提示");
				return;
			}
			if (this.textBox15.Text == "")
			{
				MessageBox.Show("请先输入要查询的内容!", "提示");
				return;
			}
			if (this.radioButton1.Checked)
			{
				try
				{
					if (int.TryParse(this.textBox15.Text, NumberStyles.Integer, NumberFormatInfo.CurrentInfo, out num))
					{
						try
						{
							if (int.Parse(this.textBox15.Text) <= 0)
							{
								MessageBox.Show("必须是正整数");
								return;
							}
						}
						catch (FormatException formatException)
						{
							MessageBox.Show("必须是正整数");
							return;
						}
						int num1 = Convert.ToInt32(this.textBox15.Text);
						TBL_XWWL_ITEM_CLASS tBLXWWLITEMCLAss = this.method_0(num1);
						if (tBLXWWLITEMCLAss == null)
						{
							MessageBox.Show("无此VAT_PHAM,请检查PID是否正确！", "提示");
							return;
						}
						else
						{
							this.textBox1.Text = tBLXWWLITEMCLAss.FLD_PID.ToString();
							this.textBox2.Text = tBLXWWLITEMCLAss.FLD_QUESTITEM.ToString();
							this.textBox3.Text = tBLXWWLITEMCLAss.FLD_Name;
							this.textBox4.Text = tBLXWWLITEMCLAss.FLD_NJ.ToString();
							this.textBox5.Text = tBLXWWLITEMCLAss.FLD_RESIDE1.ToString();
							this.textBox6.Text = tBLXWWLITEMCLAss.FLD_RESIDE2.ToString();
							this.textBox7.Text = tBLXWWLITEMCLAss.FLD_SEX.ToString();
							this.textBox8.Text = tBLXWWLITEMCLAss.FLD_DF.ToString();
							this.textBox9.Text = tBLXWWLITEMCLAss.FLD_AT1.ToString();
							this.textBox10.Text = tBLXWWLITEMCLAss.FLD_AT2.ToString();
							this.textBox11.Text = tBLXWWLITEMCLAss.FLD_LEVEL.ToString();
							this.textBox12.Text = tBLXWWLITEMCLAss.FLD_JOB_LEVEL.ToString();
							this.textBox13.Text = tBLXWWLITEMCLAss.FLD_ZX.ToString();
							this.textBox14.Text = tBLXWWLITEMCLAss.FLD_THUYET_MINH;
							this.textBox21.Text = tBLXWWLITEMCLAss.FLD_TYPE.ToString();
							this.textBox22.Text = tBLXWWLITEMCLAss.FLD_WEIGHT.ToString();
							this.textBox23.Text = tBLXWWLITEMCLAss.FLD_MONEY.ToString();
							this.textBox24.Text = tBLXWWLITEMCLAss.FLD_EL.ToString();
							this.textBox25.Text = tBLXWWLITEMCLAss.FLD_WXJD.ToString();
							this.textBox26.Text = tBLXWWLITEMCLAss.FLD_WX.ToString();
							int num2 = 0;
							while (num2 < this.listBox1.Items.Count)
							{
								if (this.listBox1.Items[num2].Equals(this.textBox3.Text))
								{
									this.listBox1.SetSelected(num2, true);
									return;
								}
								else
								{
									num2++;
								}
							}
						}
					}
					else
					{
						MessageBox.Show("请输入正确的VAT_PHAM_ID!", "提示");
					}
				}
				catch (Exception exception)
				{
					MessageBox.Show(exception.ToString(), "错误");
				}
			}
			else if (!this.radioButton2.Checked)
			{
				MessageBox.Show("请选择查询的类型", "提示");
			}
			else
			{
				try
				{
					TBL_XWWL_ITEM_CLASS tBLXWWLITEMCLAss1 = this.method_1(this.textBox15.Text);
					if (tBLXWWLITEMCLAss1 == null)
					{
						MessageBox.Show("无此VAT_PHAM,请检查VAT_PHAM名是否正确！", "提示");
					}
					else
					{
						this.textBox1.Text = tBLXWWLITEMCLAss1.FLD_PID.ToString();
						this.textBox2.Text = tBLXWWLITEMCLAss1.FLD_QUESTITEM.ToString();
						this.textBox3.Text = tBLXWWLITEMCLAss1.FLD_Name;
						this.textBox4.Text = tBLXWWLITEMCLAss1.FLD_NJ.ToString();
						this.textBox5.Text = tBLXWWLITEMCLAss1.FLD_RESIDE1.ToString();
						this.textBox6.Text = tBLXWWLITEMCLAss1.FLD_RESIDE2.ToString();
						this.textBox7.Text = tBLXWWLITEMCLAss1.FLD_SEX.ToString();
						this.textBox8.Text = tBLXWWLITEMCLAss1.FLD_DF.ToString();
						this.textBox9.Text = tBLXWWLITEMCLAss1.FLD_AT1.ToString();
						this.textBox10.Text = tBLXWWLITEMCLAss1.FLD_AT2.ToString();
						this.textBox11.Text = tBLXWWLITEMCLAss1.FLD_LEVEL.ToString();
						this.textBox12.Text = tBLXWWLITEMCLAss1.FLD_JOB_LEVEL.ToString();
						this.textBox13.Text = tBLXWWLITEMCLAss1.FLD_ZX.ToString();
						this.textBox14.Text = tBLXWWLITEMCLAss1.FLD_THUYET_MINH;
						this.textBox21.Text = tBLXWWLITEMCLAss1.FLD_TYPE.ToString();
						this.textBox22.Text = tBLXWWLITEMCLAss1.FLD_WEIGHT.ToString();
						this.textBox23.Text = tBLXWWLITEMCLAss1.FLD_MONEY.ToString();
						this.textBox24.Text = tBLXWWLITEMCLAss1.FLD_EL.ToString();
						this.textBox25.Text = tBLXWWLITEMCLAss1.FLD_WXJD.ToString();
						this.textBox26.Text = tBLXWWLITEMCLAss1.FLD_WX.ToString();
					}
				}
				catch (Exception exception1)
				{
					MessageBox.Show(exception1.ToString(), "错误");
				}
			}
		}

		private void c(object sender, EventArgs e)
		{
			this.label28.Text = "0";
			this.radioButton1.Checked = true;
			this.comboBox1.SelectedText = "全部";
		}

		private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
		{
			int num;
			Dictionary<int, TBL_XWWL_ITEM_CLASS>.ValueCollection.Enumerator enumerator;
			int num1 = 1;
			string str = this.comboBox1.SelectedItem.ToString();
			if (str != null)
			{
				if (dictionary_1 == null)
				{
					dictionary_1 = new Dictionary<string, int>(17)
					{
						{ "全部", 0 },
						{ "衣服", 1 },
						{ "护手", 2 },
						{ "武器", 3 },
						{ "靴子", 4 },
						{ "内甲", 5 },
						{ "项链", 6 },
						{ "耳环", 7 },
						{ "戒指", 8 },
						{ "披风", 9 },
						{ "灵兽", 10 },
						{ "石头", 11 },
						{ "盒子", 12 },
						{ "符文", 13 },
						{ "任务VAT_PHAM", 14 },
						{ "其他", 15 },
						{ "百宝", 16 }
					};
				}
				if (dictionary_1.TryGetValue(str, out num))
				{
					switch (num)
					{
						case 0:
						{
							num1 = 3000;
							break;
						}
						case 1:
						{
							num1 = 1;
							break;
						}
						case 2:
						{
							num1 = 2;
							break;
						}
						case 3:
						{
							num1 = 4;
							break;
						}
						case 4:
						{
							num1 = 5;
							break;
						}
						case 5:
						{
							num1 = 6;
							break;
						}
						case 6:
						{
							num1 = 7;
							break;
						}
						case 7:
						{
							num1 = 8;
							break;
						}
						case 8:
						{
							num1 = 10;
							break;
						}
						case 9:
						{
							num1 = 12;
							break;
						}
						case 10:
						{
							num1 = 15;
							break;
						}
						case 11:
						{
							num1 = 16;
							break;
						}
						case 12:
						{
							num1 = 17;
							break;
						}
						case 13:
						{
							num1 = 18;
							break;
						}
						case 14:
						{
							num1 = 1000;
							break;
						}
						case 15:
						{
							num1 = 2000;
							break;
						}
						case 16:
						{
							num1 = 4000;
							break;
						}
						default:
						{
							goto Label0;
						}
					}
				}
				else
				{
					goto Label0;
				}
			}
			else
			{
				goto Label0;
			}
		Label3:
			this.listBox1.Items.Clear();
			if (num1 <= 1000)
			{
				switch (num1)
				{
					case 1:
					{
						enumerator = YbiForm.dictionary_0.Values.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								TBL_XWWL_ITEM_CLASS current = enumerator.Current;
								if (current.FLD_RESIDE2 != num1)
								{
									continue;
								}
								this.listBox1.Items.Add(current.FLD_Name);
							}
							break;
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
						}
						break;
					}
					case 2:
					{
						enumerator = YbiForm.dictionary_0.Values.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								TBL_XWWL_ITEM_CLASS tBLXWWLITEMCLAss = enumerator.Current;
								if (tBLXWWLITEMCLAss.FLD_RESIDE2 != num1)
								{
									continue;
								}
								this.listBox1.Items.Add(tBLXWWLITEMCLAss.FLD_Name);
							}
							break;
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
						}
						break;
					}
					case 3:
					case 9:
					case 11:
					case 13:
					case 14:
					{
						goto Label1;
					}
					case 4:
					{
						enumerator = YbiForm.dictionary_0.Values.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								TBL_XWWL_ITEM_CLASS current1 = enumerator.Current;
								if (current1.FLD_RESIDE2 != num1)
								{
									continue;
								}
								this.listBox1.Items.Add(current1.FLD_Name);
							}
							break;
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
						}
						break;
					}
					case 5:
					{
						enumerator = YbiForm.dictionary_0.Values.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								TBL_XWWL_ITEM_CLASS tBLXWWLITEMCLAss1 = enumerator.Current;
								if (tBLXWWLITEMCLAss1.FLD_RESIDE2 != num1)
								{
									continue;
								}
								this.listBox1.Items.Add(tBLXWWLITEMCLAss1.FLD_Name);
							}
							break;
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
						}
						break;
					}
					case 6:
					{
						enumerator = YbiForm.dictionary_0.Values.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								TBL_XWWL_ITEM_CLASS current2 = enumerator.Current;
								if (current2.FLD_RESIDE2 != num1)
								{
									continue;
								}
								this.listBox1.Items.Add(current2.FLD_Name);
							}
							break;
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
						}
						break;
					}
					case 7:
					{
						enumerator = YbiForm.dictionary_0.Values.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								TBL_XWWL_ITEM_CLASS tBLXWWLITEMCLAss2 = enumerator.Current;
								if (tBLXWWLITEMCLAss2.FLD_RESIDE2 != num1)
								{
									continue;
								}
								this.listBox1.Items.Add(tBLXWWLITEMCLAss2.FLD_Name);
							}
							break;
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
						}
						break;
					}
					case 8:
					{
						enumerator = YbiForm.dictionary_0.Values.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								TBL_XWWL_ITEM_CLASS current3 = enumerator.Current;
								if (current3.FLD_RESIDE2 != num1)
								{
									continue;
								}
								this.listBox1.Items.Add(current3.FLD_Name);
							}
							break;
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
						}
						break;
					}
					case 10:
					{
						enumerator = YbiForm.dictionary_0.Values.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								TBL_XWWL_ITEM_CLASS tBLXWWLITEMCLAss3 = enumerator.Current;
								if (tBLXWWLITEMCLAss3.FLD_RESIDE2 != num1)
								{
									continue;
								}
								this.listBox1.Items.Add(tBLXWWLITEMCLAss3.FLD_Name);
							}
							break;
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
						}
						break;
					}
					case 12:
					{
						enumerator = YbiForm.dictionary_0.Values.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								TBL_XWWL_ITEM_CLASS current4 = enumerator.Current;
								if (current4.FLD_RESIDE2 != num1)
								{
									continue;
								}
								this.listBox1.Items.Add(current4.FLD_Name);
							}
							break;
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
						}
						break;
					}
					case 15:
					{
						enumerator = YbiForm.dictionary_0.Values.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								TBL_XWWL_ITEM_CLASS tBLXWWLITEMCLAss4 = enumerator.Current;
								if (tBLXWWLITEMCLAss4.FLD_RESIDE2 != num1)
								{
									continue;
								}
								this.listBox1.Items.Add(tBLXWWLITEMCLAss4.FLD_Name);
							}
							break;
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
						}
						break;
					}
					case 16:
					{
						enumerator = YbiForm.dictionary_0.Values.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								TBL_XWWL_ITEM_CLASS current5 = enumerator.Current;
								if (current5.FLD_RESIDE2 != num1)
								{
									continue;
								}
								this.listBox1.Items.Add(current5.FLD_Name);
							}
							break;
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
						}
						break;
					}
					case 17:
					{
						enumerator = YbiForm.dictionary_0.Values.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								TBL_XWWL_ITEM_CLASS tBLXWWLITEMCLAss5 = enumerator.Current;
								if (tBLXWWLITEMCLAss5.FLD_PID != 1000000001 && tBLXWWLITEMCLAss5.FLD_PID != 1000000251 && tBLXWWLITEMCLAss5.FLD_PID != 1000000250 && tBLXWWLITEMCLAss5.FLD_PID != 1000000071 && tBLXWWLITEMCLAss5.FLD_PID != 1000000006 && tBLXWWLITEMCLAss5.FLD_PID != 1000000005 && tBLXWWLITEMCLAss5.FLD_PID != 1000000026 && tBLXWWLITEMCLAss5.FLD_PID != 1000000023 && tBLXWWLITEMCLAss5.FLD_PID != 1000000008 && tBLXWWLITEMCLAss5.FLD_PID != 1000000003 && tBLXWWLITEMCLAss5.FLD_PID != 1000000002)
								{
									continue;
								}
								this.listBox1.Items.Add(tBLXWWLITEMCLAss5.FLD_Name);
							}
							break;
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
						}
						break;
					}
					case 18:
					{
						enumerator = YbiForm.dictionary_0.Values.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								TBL_XWWL_ITEM_CLASS current6 = enumerator.Current;
								if (current6.FLD_RESIDE2 != num1)
								{
									continue;
								}
								this.listBox1.Items.Add(current6.FLD_Name);
							}
							break;
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
						}
						break;
					}
					default:
					{
						if (num1 == 1000)
						{
							enumerator = YbiForm.dictionary_0.Values.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									TBL_XWWL_ITEM_CLASS tBLXWWLITEMCLAss6 = enumerator.Current;
									if (tBLXWWLITEMCLAss6.FLD_PID <= 900000001 || tBLXWWLITEMCLAss6.FLD_PID >= 1000000000)
									{
										continue;
									}
									this.listBox1.Items.Add(tBLXWWLITEMCLAss6.FLD_Name);
								}
								break;
							}
							finally
							{
								((IDisposable)enumerator).Dispose();
							}
						}
						else
						{
							goto Label1;
						}
						break;
					}
				}
			}
			else if (num1 == 3000)
			{
				foreach (TBL_XWWL_ITEM_CLASS value in YbiForm.dictionary_0.Values)
				{
					this.listBox1.Items.Add(value.FLD_Name);
				}
			}
			else
			{
				if (num1 != 4000)
				{
					goto Label1;
				}
				foreach (TBL_XWWL_ITEM_CLASS value1 in YbiForm.dictionary_0.Values)
				{
					if (value1.FLD_TYPE != 6)
					{
						continue;
					}
					this.listBox1.Items.Add(value1.FLD_Name);
				}
			}
			Label label = this.label28;
			int count = this.listBox1.Items.Count;
			label.Text = count.ToString();
			return;
		Label0:
			num1 = 3000;
			goto Label3;
		Label1:
			enumerator = YbiForm.dictionary_0.Values.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					TBL_XWWL_ITEM_CLASS current7 = enumerator.Current;
					if (current7.FLD_RESIDE2 == 1 || current7.FLD_RESIDE2 == 2 || current7.FLD_RESIDE2 == 4 || current7.FLD_RESIDE2 == 5 || current7.FLD_RESIDE2 == 6 || current7.FLD_RESIDE2 == 7 || current7.FLD_RESIDE2 == 8 || current7.FLD_RESIDE2 == 10 || current7.FLD_RESIDE2 == 12 || current7.FLD_RESIDE2 == 15 || current7.FLD_RESIDE2 == 16 || current7.FLD_RESIDE2 == 17 || current7.FLD_RESIDE2 == 18 || current7.FLD_PID == 1000000001 || current7.FLD_PID == 1000000251 || current7.FLD_PID == 1000000250 || current7.FLD_PID == 1000000071 || current7.FLD_PID == 1000000006 || current7.FLD_PID == 1000000005 || current7.FLD_PID == 1000000026 || current7.FLD_PID == 1000000023 || current7.FLD_PID == 1000000008 || current7.FLD_PID == 1000000003 || current7.FLD_PID == 1000000002 || current7.FLD_PID > 900000001 && current7.FLD_PID < 1000000000 || current7.FLD_TYPE == 6)
					{
						continue;
					}
					this.listBox1.Items.Add(current7.FLD_Name);
				}
				label = this.label28;
				count = this.listBox1.Items.Count;
				label.Text = count.ToString();
				return;
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
		}

		private void d(object sender, EventArgs e)
		{
			try
			{
				if (this.listBox1.Items.Count != 0)
				{
					using (FileStream fileStream = new FileStream("YBi.cfg.bak", FileMode.Open, FileAccess.Read, FileShare.Read))
					{
						using (FileStream fileStream1 = new FileStream("YBi.cfg1.bak", FileMode.Create, FileAccess.Write, FileShare.Read))
						{
							using (BinaryReader binaryReader = new BinaryReader(fileStream))
							{
								fileStream1.Write(BitConverter.GetBytes(binaryReader.ReadInt32()), 0, 4);
								fileStream1.Write(BitConverter.GetBytes(binaryReader.ReadInt32()), 0, 4);
								int num = 8;
								fileStream1.Seek((long)8, SeekOrigin.Begin);
								foreach (TBL_XWWL_ITEM_CLASS value in YbiForm.dictionary_0.Values)
								{
									byte[] fLDByte = value.FLD_byte;
									byte[] bytes = Encoding.Default.GetBytes(string.Concat(value.FLD_Name, "\0"));
									byte[] numArray = Encoding.Default.GetBytes(string.Concat(value.FLD_THUYET_MINH, "\0"));
									Buffer.BlockCopy(BitConverter.GetBytes(value.FLD_PID), 0, fLDByte, 0, 4);
									Buffer.BlockCopy(BitConverter.GetBytes(value.FLD_JOB_LEVEL), 0, fLDByte, 78, 1);
									Buffer.BlockCopy(BitConverter.GetBytes(value.FLD_ZX), 0, fLDByte, 73, 1);
									Buffer.BlockCopy(BitConverter.GetBytes(value.FLD_RESIDE1), 0, fLDByte, 74, 1);
									Buffer.BlockCopy(BitConverter.GetBytes(value.FLD_LEVEL), 0, fLDByte, 76, 2);
									Buffer.BlockCopy(BitConverter.GetBytes(value.FLD_SEX), 0, fLDByte, 79, 1);
									Buffer.BlockCopy(BitConverter.GetBytes(value.FLD_RESIDE2), 0, fLDByte, 80, 2);
									Buffer.BlockCopy(BitConverter.GetBytes(value.FLD_WEIGHT), 0, fLDByte, 82, 2);
									Buffer.BlockCopy(BitConverter.GetBytes(value.FLD_AT2), 0, fLDByte, 84, 2);
									Buffer.BlockCopy(BitConverter.GetBytes(value.FLD_AT1), 0, fLDByte, 86, 2);
									Buffer.BlockCopy(BitConverter.GetBytes(value.FLD_DF), 0, fLDByte, 88, 2);
									Buffer.BlockCopy(BitConverter.GetBytes(value.FLD_NJ), 0, fLDByte, 96, 2);
									Buffer.BlockCopy(BitConverter.GetBytes(value.FLD_MONEY), 0, fLDByte, 100, 4);
									Buffer.BlockCopy(BitConverter.GetBytes(value.FLD_EL), 0, fLDByte, 113, 2);
									Buffer.BlockCopy(bytes, 0, fLDByte, 8, (int)bytes.Length);
									Buffer.BlockCopy(numArray, 0, fLDByte, 116, (int)numArray.Length);
									fileStream1.Write(fLDByte, 0, (int)fLDByte.Length);
									num = num + 848;
								}
								fileStream.Seek((long)num, SeekOrigin.Begin);
								byte[] numArray1 = new byte[4];
								while (binaryReader.Read(numArray1, 0, 4) > 0)
								{
									fileStream1.Write(numArray1, 0, (int)numArray1.Length);
								}
							}
						}
					}
					this.method_5();
				}
				else
				{
					MessageBox.Show("请先打开Ybi.cfg文件!", "提示");
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.ToString(), "错误");
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void e(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog()
			{
				Filter = "Ybi.cfg file|Ybi.cfg",
				FilterIndex = 1,
				RestoreDirectory = true
			};
			if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				Stream stream = openFileDialog.OpenFile();
				if (stream != null)
				{
					BinaryReader binaryReader = new BinaryReader(stream);
					using (FileStream fileStream = new FileStream("YBi.cfg.bak", FileMode.Create, FileAccess.Write, FileShare.Read))
					{
						int num = binaryReader.ReadInt32();
						int num1 = binaryReader.ReadInt32();
						fileStream.Write(BitConverter.GetBytes(num), 0, 4);
						fileStream.Write(BitConverter.GetBytes(num1), 0, 4);
						byte[] numArray = new byte[4];
						while (binaryReader.Read(numArray, 0, 4) > 0)
						{
							fileStream.Write(BitConverter.GetBytes(YbiForm.smethod_0(BitConverter.ToUInt32(numArray, 0), 0)), 0, 4);
						}
					}
					stream.Close();
				}
				this.method_4();
			}
		}

		private void InitializeComponent()
		{
                  this.menuStrip1 = new System.Windows.Forms.MenuStrip();
                  this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.打开YBIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.保存YBIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.VAT_PHAM入库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.listBox1 = new System.Windows.Forms.ListBox();
                  this.groupBox1 = new System.Windows.Forms.GroupBox();
                  this.groupBox2 = new System.Windows.Forms.GroupBox();
                  this.label20 = new System.Windows.Forms.Label();
                  this.button1 = new System.Windows.Forms.Button();
                  this.textBox14 = new System.Windows.Forms.TextBox();
                  this.textBox21 = new System.Windows.Forms.TextBox();
                  this.textBox22 = new System.Windows.Forms.TextBox();
                  this.textBox23 = new System.Windows.Forms.TextBox();
                  this.textBox24 = new System.Windows.Forms.TextBox();
                  this.textBox25 = new System.Windows.Forms.TextBox();
                  this.textBox26 = new System.Windows.Forms.TextBox();
                  this.textBox13 = new System.Windows.Forms.TextBox();
                  this.textBox12 = new System.Windows.Forms.TextBox();
                  this.textBox11 = new System.Windows.Forms.TextBox();
                  this.textBox10 = new System.Windows.Forms.TextBox();
                  this.textBox9 = new System.Windows.Forms.TextBox();
                  this.textBox8 = new System.Windows.Forms.TextBox();
                  this.textBox7 = new System.Windows.Forms.TextBox();
                  this.textBox6 = new System.Windows.Forms.TextBox();
                  this.textBox5 = new System.Windows.Forms.TextBox();
                  this.textBox4 = new System.Windows.Forms.TextBox();
                  this.textBox3 = new System.Windows.Forms.TextBox();
                  this.textBox2 = new System.Windows.Forms.TextBox();
                  this.textBox1 = new System.Windows.Forms.TextBox();
                  this.label25 = new System.Windows.Forms.Label();
                  this.label19 = new System.Windows.Forms.Label();
                  this.label18 = new System.Windows.Forms.Label();
                  this.label17 = new System.Windows.Forms.Label();
                  this.label16 = new System.Windows.Forms.Label();
                  this.label15 = new System.Windows.Forms.Label();
                  this.label14 = new System.Windows.Forms.Label();
                  this.label13 = new System.Windows.Forms.Label();
                  this.label12 = new System.Windows.Forms.Label();
                  this.label11 = new System.Windows.Forms.Label();
                  this.label10 = new System.Windows.Forms.Label();
                  this.label9 = new System.Windows.Forms.Label();
                  this.label8 = new System.Windows.Forms.Label();
                  this.label7 = new System.Windows.Forms.Label();
                  this.label6 = new System.Windows.Forms.Label();
                  this.label5 = new System.Windows.Forms.Label();
                  this.label4 = new System.Windows.Forms.Label();
                  this.label3 = new System.Windows.Forms.Label();
                  this.label2 = new System.Windows.Forms.Label();
                  this.label1 = new System.Windows.Forms.Label();
                  this.label27 = new System.Windows.Forms.Label();
                  this.label28 = new System.Windows.Forms.Label();
                  this.textBox15 = new System.Windows.Forms.TextBox();
                  this.radioButton1 = new System.Windows.Forms.RadioButton();
                  this.radioButton2 = new System.Windows.Forms.RadioButton();
                  this.button2 = new System.Windows.Forms.Button();
                  this.groupBox3 = new System.Windows.Forms.GroupBox();
                  this.comboBox1 = new System.Windows.Forms.ComboBox();
                  this.label21 = new System.Windows.Forms.Label();
                  this.menuStrip1.SuspendLayout();
                  this.groupBox1.SuspendLayout();
                  this.groupBox2.SuspendLayout();
                  this.groupBox3.SuspendLayout();
                  this.SuspendLayout();
                  // 
                  // menuStrip1
                  // 
                  this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.功能ToolStripMenuItem});
                  this.menuStrip1.Location = new System.Drawing.Point(0, 0);
                  this.menuStrip1.Name = "menuStrip1";
                  this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
                  this.menuStrip1.Size = new System.Drawing.Size(937, 24);
                  this.menuStrip1.TabIndex = 0;
                  this.menuStrip1.Text = "menuStrip1";
                  // 
                  // 文件ToolStripMenuItem
                  // 
                  this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开YBIToolStripMenuItem,
            this.保存YBIToolStripMenuItem});
                  this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
                  this.文件ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
                  this.文件ToolStripMenuItem.Text = "文件";
                  // 
                  // 打开YBIToolStripMenuItem
                  // 
                  this.打开YBIToolStripMenuItem.Name = "打开YBIToolStripMenuItem";
                  this.打开YBIToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
                  this.打开YBIToolStripMenuItem.Text = "打开YBi.cfg";
                  this.打开YBIToolStripMenuItem.Click += new System.EventHandler(this.e);
                  // 
                  // 保存YBIToolStripMenuItem
                  // 
                  this.保存YBIToolStripMenuItem.Name = "保存YBIToolStripMenuItem";
                  this.保存YBIToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
                  this.保存YBIToolStripMenuItem.Text = "保存YBi.cfg";
                  this.保存YBIToolStripMenuItem.Click += new System.EventHandler(this.d);
                  // 
                  // 功能ToolStripMenuItem
                  // 
                  this.功能ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VAT_PHAM入库ToolStripMenuItem});
                  this.功能ToolStripMenuItem.Name = "功能ToolStripMenuItem";
                  this.功能ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
                  this.功能ToolStripMenuItem.Text = "功能";
                  // 
                  // VAT_PHAM入库ToolStripMenuItem
                  // 
                  this.VAT_PHAM入库ToolStripMenuItem.Name = "VAT_PHAM入库ToolStripMenuItem";
                  this.VAT_PHAM入库ToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
                  this.VAT_PHAM入库ToolStripMenuItem.Text = "VAT_PHAM入库";
                  this.VAT_PHAM入库ToolStripMenuItem.Click += new System.EventHandler(this.VAT_PHAM入库ToolStripMenuItem_Click);
                  // 
                  // listBox1
                  // 
                  this.listBox1.FormattingEnabled = true;
                  this.listBox1.ItemHeight = 12;
                  this.listBox1.Location = new System.Drawing.Point(20, 26);
                  this.listBox1.Name = "listBox1";
                  this.listBox1.Size = new System.Drawing.Size(223, 352);
                  this.listBox1.TabIndex = 1;
                  this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
                  // 
                  // groupBox1
                  // 
                  this.groupBox1.Controls.Add(this.listBox1);
                  this.groupBox1.Location = new System.Drawing.Point(14, 97);
                  this.groupBox1.Name = "groupBox1";
                  this.groupBox1.Size = new System.Drawing.Size(262, 399);
                  this.groupBox1.TabIndex = 2;
                  this.groupBox1.TabStop = false;
                  this.groupBox1.Text = "VAT_PHAM列表";
                  // 
                  // groupBox2
                  // 
                  this.groupBox2.Controls.Add(this.label20);
                  this.groupBox2.Controls.Add(this.button1);
                  this.groupBox2.Controls.Add(this.textBox14);
                  this.groupBox2.Controls.Add(this.textBox21);
                  this.groupBox2.Controls.Add(this.textBox22);
                  this.groupBox2.Controls.Add(this.textBox23);
                  this.groupBox2.Controls.Add(this.textBox24);
                  this.groupBox2.Controls.Add(this.textBox25);
                  this.groupBox2.Controls.Add(this.textBox26);
                  this.groupBox2.Controls.Add(this.textBox13);
                  this.groupBox2.Controls.Add(this.textBox12);
                  this.groupBox2.Controls.Add(this.textBox11);
                  this.groupBox2.Controls.Add(this.textBox10);
                  this.groupBox2.Controls.Add(this.textBox9);
                  this.groupBox2.Controls.Add(this.textBox8);
                  this.groupBox2.Controls.Add(this.textBox7);
                  this.groupBox2.Controls.Add(this.textBox6);
                  this.groupBox2.Controls.Add(this.textBox5);
                  this.groupBox2.Controls.Add(this.textBox4);
                  this.groupBox2.Controls.Add(this.textBox3);
                  this.groupBox2.Controls.Add(this.textBox2);
                  this.groupBox2.Controls.Add(this.textBox1);
                  this.groupBox2.Controls.Add(this.label25);
                  this.groupBox2.Controls.Add(this.label19);
                  this.groupBox2.Controls.Add(this.label18);
                  this.groupBox2.Controls.Add(this.label17);
                  this.groupBox2.Controls.Add(this.label16);
                  this.groupBox2.Controls.Add(this.label15);
                  this.groupBox2.Controls.Add(this.label14);
                  this.groupBox2.Controls.Add(this.label13);
                  this.groupBox2.Controls.Add(this.label12);
                  this.groupBox2.Controls.Add(this.label11);
                  this.groupBox2.Controls.Add(this.label10);
                  this.groupBox2.Controls.Add(this.label9);
                  this.groupBox2.Controls.Add(this.label8);
                  this.groupBox2.Controls.Add(this.label7);
                  this.groupBox2.Controls.Add(this.label6);
                  this.groupBox2.Controls.Add(this.label5);
                  this.groupBox2.Controls.Add(this.label4);
                  this.groupBox2.Controls.Add(this.label3);
                  this.groupBox2.Controls.Add(this.label2);
                  this.groupBox2.Controls.Add(this.label1);
                  this.groupBox2.Location = new System.Drawing.Point(309, 97);
                  this.groupBox2.Name = "groupBox2";
                  this.groupBox2.Size = new System.Drawing.Size(604, 399);
                  this.groupBox2.TabIndex = 3;
                  this.groupBox2.TabStop = false;
                  this.groupBox2.Text = "Item_thuoc_tinh";
                  // 
                  // label20
                  // 
                  this.label20.AutoSize = true;
                  this.label20.Location = new System.Drawing.Point(320, 215);
                  this.label20.Name = "label20";
                  this.label20.Size = new System.Drawing.Size(75, 12);
                  this.label20.TabIndex = 53;
                  this.label20.Text = "注:120字以内";
                  // 
                  // button1
                  // 
                  this.button1.Location = new System.Drawing.Point(486, 368);
                  this.button1.Name = "button1";
                  this.button1.Size = new System.Drawing.Size(87, 23);
                  this.button1.TabIndex = 52;
                  this.button1.Text = "修改";
                  this.button1.UseVisualStyleBackColor = true;
                  this.button1.Click += new System.EventHandler(this.button1_Click);
                  // 
                  // textBox14
                  // 
                  this.textBox14.Location = new System.Drawing.Point(415, 194);
                  this.textBox14.Multiline = true;
                  this.textBox14.Name = "textBox14";
                  this.textBox14.Size = new System.Drawing.Size(158, 166);
                  this.textBox14.TabIndex = 51;
                  // 
                  // textBox21
                  // 
                  this.textBox21.Location = new System.Drawing.Point(415, 163);
                  this.textBox21.Name = "textBox21";
                  this.textBox21.Size = new System.Drawing.Size(158, 21);
                  this.textBox21.TabIndex = 44;
                  // 
                  // textBox22
                  // 
                  this.textBox22.Location = new System.Drawing.Point(415, 135);
                  this.textBox22.Name = "textBox22";
                  this.textBox22.Size = new System.Drawing.Size(158, 21);
                  this.textBox22.TabIndex = 43;
                  // 
                  // textBox23
                  // 
                  this.textBox23.Location = new System.Drawing.Point(415, 107);
                  this.textBox23.Name = "textBox23";
                  this.textBox23.Size = new System.Drawing.Size(158, 21);
                  this.textBox23.TabIndex = 42;
                  // 
                  // textBox24
                  // 
                  this.textBox24.Location = new System.Drawing.Point(415, 79);
                  this.textBox24.Name = "textBox24";
                  this.textBox24.Size = new System.Drawing.Size(158, 21);
                  this.textBox24.TabIndex = 41;
                  // 
                  // textBox25
                  // 
                  this.textBox25.Location = new System.Drawing.Point(415, 51);
                  this.textBox25.Name = "textBox25";
                  this.textBox25.Size = new System.Drawing.Size(158, 21);
                  this.textBox25.TabIndex = 40;
                  // 
                  // textBox26
                  // 
                  this.textBox26.Location = new System.Drawing.Point(415, 23);
                  this.textBox26.Name = "textBox26";
                  this.textBox26.Size = new System.Drawing.Size(158, 21);
                  this.textBox26.TabIndex = 39;
                  // 
                  // textBox13
                  // 
                  this.textBox13.Location = new System.Drawing.Point(126, 350);
                  this.textBox13.Name = "textBox13";
                  this.textBox13.Size = new System.Drawing.Size(158, 21);
                  this.textBox13.TabIndex = 38;
                  // 
                  // textBox12
                  // 
                  this.textBox12.Location = new System.Drawing.Point(126, 323);
                  this.textBox12.Name = "textBox12";
                  this.textBox12.Size = new System.Drawing.Size(158, 21);
                  this.textBox12.TabIndex = 37;
                  // 
                  // textBox11
                  // 
                  this.textBox11.Location = new System.Drawing.Point(126, 296);
                  this.textBox11.Name = "textBox11";
                  this.textBox11.Size = new System.Drawing.Size(158, 21);
                  this.textBox11.TabIndex = 36;
                  // 
                  // textBox10
                  // 
                  this.textBox10.Location = new System.Drawing.Point(126, 269);
                  this.textBox10.Name = "textBox10";
                  this.textBox10.Size = new System.Drawing.Size(158, 21);
                  this.textBox10.TabIndex = 35;
                  // 
                  // textBox9
                  // 
                  this.textBox9.Location = new System.Drawing.Point(126, 242);
                  this.textBox9.Name = "textBox9";
                  this.textBox9.Size = new System.Drawing.Size(158, 21);
                  this.textBox9.TabIndex = 34;
                  // 
                  // textBox8
                  // 
                  this.textBox8.Location = new System.Drawing.Point(126, 215);
                  this.textBox8.Name = "textBox8";
                  this.textBox8.Size = new System.Drawing.Size(158, 21);
                  this.textBox8.TabIndex = 33;
                  // 
                  // textBox7
                  // 
                  this.textBox7.Location = new System.Drawing.Point(126, 188);
                  this.textBox7.Name = "textBox7";
                  this.textBox7.Size = new System.Drawing.Size(158, 21);
                  this.textBox7.TabIndex = 32;
                  // 
                  // textBox6
                  // 
                  this.textBox6.Location = new System.Drawing.Point(126, 161);
                  this.textBox6.Name = "textBox6";
                  this.textBox6.Size = new System.Drawing.Size(158, 21);
                  this.textBox6.TabIndex = 31;
                  // 
                  // textBox5
                  // 
                  this.textBox5.Location = new System.Drawing.Point(126, 134);
                  this.textBox5.Name = "textBox5";
                  this.textBox5.Size = new System.Drawing.Size(158, 21);
                  this.textBox5.TabIndex = 30;
                  // 
                  // textBox4
                  // 
                  this.textBox4.Location = new System.Drawing.Point(126, 107);
                  this.textBox4.Name = "textBox4";
                  this.textBox4.Size = new System.Drawing.Size(158, 21);
                  this.textBox4.TabIndex = 29;
                  // 
                  // textBox3
                  // 
                  this.textBox3.Location = new System.Drawing.Point(126, 80);
                  this.textBox3.Name = "textBox3";
                  this.textBox3.Size = new System.Drawing.Size(158, 21);
                  this.textBox3.TabIndex = 28;
                  // 
                  // textBox2
                  // 
                  this.textBox2.Location = new System.Drawing.Point(126, 53);
                  this.textBox2.Name = "textBox2";
                  this.textBox2.Size = new System.Drawing.Size(158, 21);
                  this.textBox2.TabIndex = 27;
                  // 
                  // textBox1
                  // 
                  this.textBox1.Enabled = false;
                  this.textBox1.Location = new System.Drawing.Point(126, 26);
                  this.textBox1.Name = "textBox1";
                  this.textBox1.Size = new System.Drawing.Size(158, 21);
                  this.textBox1.TabIndex = 26;
                  // 
                  // label25
                  // 
                  this.label25.AutoSize = true;
                  this.label25.Location = new System.Drawing.Point(320, 188);
                  this.label25.Name = "label25";
                  this.label25.Size = new System.Drawing.Size(61, 12);
                  this.label25.TabIndex = 24;
                  this.label25.Text = "FLD_DES:";
                  // 
                  // label19
                  // 
                  this.label19.AutoSize = true;
                  this.label19.Location = new System.Drawing.Point(320, 161);
                  this.label19.Name = "label19";
                  this.label19.Size = new System.Drawing.Size(69, 12);
                  this.label19.TabIndex = 18;
                  this.label19.Text = "FLD_TYPE:";
                  // 
                  // label18
                  // 
                  this.label18.AutoSize = true;
                  this.label18.Location = new System.Drawing.Point(14, 56);
                  this.label18.Name = "label18";
                  this.label18.Size = new System.Drawing.Size(108, 12);
                  this.label18.TabIndex = 17;
                  this.label18.Text = "FLD_QUESTITEM:";
                  // 
                  // label17
                  // 
                  this.label17.AutoSize = true;
                  this.label17.Location = new System.Drawing.Point(320, 53);
                  this.label17.Name = "label17";
                  this.label17.Size = new System.Drawing.Size(69, 12);
                  this.label17.TabIndex = 16;
                  this.label17.Text = "FLD_WXJD:";
                  // 
                  // label16
                  // 
                  this.label16.AutoSize = true;
                  this.label16.Location = new System.Drawing.Point(320, 26);
                  this.label16.Name = "label16";
                  this.label16.Size = new System.Drawing.Size(55, 12);
                  this.label16.TabIndex = 15;
                  this.label16.Text = "FLD_WX:";
                  // 
                  // label15
                  // 
                  this.label15.AutoSize = true;
                  this.label15.Location = new System.Drawing.Point(320, 80);
                  this.label15.Name = "label15";
                  this.label15.Size = new System.Drawing.Size(52, 12);
                  this.label15.TabIndex = 14;
                  this.label15.Text = "FLD_EL:";
                  // 
                  // label14
                  // 
                  this.label14.AutoSize = true;
                  this.label14.Location = new System.Drawing.Point(320, 107);
                  this.label14.Name = "label14";
                  this.label14.Size = new System.Drawing.Size(82, 12);
                  this.label14.TabIndex = 13;
                  this.label14.Text = "FLD_MONEY:";
                  // 
                  // label13
                  // 
                  this.label13.AutoSize = true;
                  this.label13.Location = new System.Drawing.Point(14, 110);
                  this.label13.Name = "label13";
                  this.label13.Size = new System.Drawing.Size(52, 12);
                  this.label13.TabIndex = 12;
                  this.label13.Text = "FLD_NJ:";
                  // 
                  // label12
                  // 
                  this.label12.AutoSize = true;
                  this.label12.Location = new System.Drawing.Point(14, 218);
                  this.label12.Name = "label12";
                  this.label12.Size = new System.Drawing.Size(52, 12);
                  this.label12.TabIndex = 11;
                  this.label12.Text = "FLD_DF:";
                  // 
                  // label11
                  // 
                  this.label11.AutoSize = true;
                  this.label11.Location = new System.Drawing.Point(14, 272);
                  this.label11.Name = "label11";
                  this.label11.Size = new System.Drawing.Size(59, 12);
                  this.label11.TabIndex = 10;
                  this.label11.Text = "FLD_AT2:";
                  // 
                  // label10
                  // 
                  this.label10.AutoSize = true;
                  this.label10.Location = new System.Drawing.Point(14, 245);
                  this.label10.Name = "label10";
                  this.label10.Size = new System.Drawing.Size(59, 12);
                  this.label10.TabIndex = 9;
                  this.label10.Text = "FLD_AT1:";
                  // 
                  // label9
                  // 
                  this.label9.AutoSize = true;
                  this.label9.Location = new System.Drawing.Point(320, 134);
                  this.label9.Name = "label9";
                  this.label9.Size = new System.Drawing.Size(83, 12);
                  this.label9.TabIndex = 8;
                  this.label9.Text = "FLD_WEIGHT:";
                  // 
                  // label8
                  // 
                  this.label8.AutoSize = true;
                  this.label8.Location = new System.Drawing.Point(14, 164);
                  this.label8.Name = "label8";
                  this.label8.Size = new System.Drawing.Size(86, 12);
                  this.label8.TabIndex = 7;
                  this.label8.Text = "FLD_RESIDE2:";
                  // 
                  // label7
                  // 
                  this.label7.AutoSize = true;
                  this.label7.Location = new System.Drawing.Point(14, 191);
                  this.label7.Name = "label7";
                  this.label7.Size = new System.Drawing.Size(61, 12);
                  this.label7.TabIndex = 6;
                  this.label7.Text = "FLD_SEX:";
                  // 
                  // label6
                  // 
                  this.label6.AutoSize = true;
                  this.label6.Location = new System.Drawing.Point(14, 326);
                  this.label6.Name = "label6";
                  this.label6.Size = new System.Drawing.Size(104, 12);
                  this.label6.TabIndex = 5;
                  this.label6.Text = "FLD_JOB_LEVEL:";
                  // 
                  // label5
                  // 
                  this.label5.AutoSize = true;
                  this.label5.Location = new System.Drawing.Point(14, 299);
                  this.label5.Name = "label5";
                  this.label5.Size = new System.Drawing.Size(75, 12);
                  this.label5.TabIndex = 4;
                  this.label5.Text = "FLD_LEVEL:";
                  // 
                  // label4
                  // 
                  this.label4.AutoSize = true;
                  this.label4.Location = new System.Drawing.Point(14, 137);
                  this.label4.Name = "label4";
                  this.label4.Size = new System.Drawing.Size(86, 12);
                  this.label4.TabIndex = 3;
                  this.label4.Text = "FLD_RESIDE1:";
                  // 
                  // label3
                  // 
                  this.label3.AutoSize = true;
                  this.label3.Location = new System.Drawing.Point(14, 353);
                  this.label3.Name = "label3";
                  this.label3.Size = new System.Drawing.Size(53, 12);
                  this.label3.TabIndex = 2;
                  this.label3.Text = "FLD_ZX:";
                  // 
                  // label2
                  // 
                  this.label2.AutoSize = true;
                  this.label2.Location = new System.Drawing.Point(14, 83);
                  this.label2.Name = "label2";
                  this.label2.Size = new System.Drawing.Size(73, 12);
                  this.label2.TabIndex = 1;
                  this.label2.Text = "FLD_NAME:";
                  // 
                  // label1
                  // 
                  this.label1.AutoSize = true;
                  this.label1.Location = new System.Drawing.Point(14, 29);
                  this.label1.Name = "label1";
                  this.label1.Size = new System.Drawing.Size(56, 12);
                  this.label1.TabIndex = 0;
                  this.label1.Text = "FLD_PID:";
                  // 
                  // label27
                  // 
                  this.label27.AutoSize = true;
                  this.label27.Location = new System.Drawing.Point(31, 502);
                  this.label27.Name = "label27";
                  this.label27.Size = new System.Drawing.Size(98, 12);
                  this.label27.TabIndex = 4;
                  this.label27.Text = "VAT_PHAM总数:";
                  // 
                  // label28
                  // 
                  this.label28.AutoSize = true;
                  this.label28.Location = new System.Drawing.Point(107, 502);
                  this.label28.Name = "label28";
                  this.label28.Size = new System.Drawing.Size(44, 12);
                  this.label28.TabIndex = 5;
                  this.label28.Text = "label28";
                  // 
                  // textBox15
                  // 
                  this.textBox15.Location = new System.Drawing.Point(311, 17);
                  this.textBox15.Name = "textBox15";
                  this.textBox15.Size = new System.Drawing.Size(153, 21);
                  this.textBox15.TabIndex = 6;
                  // 
                  // radioButton1
                  // 
                  this.radioButton1.AutoSize = true;
                  this.radioButton1.Location = new System.Drawing.Point(490, 18);
                  this.radioButton1.Name = "radioButton1";
                  this.radioButton1.Size = new System.Drawing.Size(42, 16);
                  this.radioButton1.TabIndex = 7;
                  this.radioButton1.TabStop = true;
                  this.radioButton1.Text = "PID";
                  this.radioButton1.UseVisualStyleBackColor = true;
                  // 
                  // radioButton2
                  // 
                  this.radioButton2.AutoSize = true;
                  this.radioButton2.Location = new System.Drawing.Point(545, 18);
                  this.radioButton2.Name = "radioButton2";
                  this.radioButton2.Size = new System.Drawing.Size(100, 16);
                  this.radioButton2.TabIndex = 8;
                  this.radioButton2.TabStop = true;
                  this.radioButton2.Text = "VAT_PHAM名";
                  this.radioButton2.UseVisualStyleBackColor = true;
                  // 
                  // button2
                  // 
                  this.button2.Location = new System.Drawing.Point(666, 15);
                  this.button2.Name = "button2";
                  this.button2.Size = new System.Drawing.Size(78, 23);
                  this.button2.TabIndex = 9;
                  this.button2.Text = "确定";
                  this.button2.UseVisualStyleBackColor = true;
                  this.button2.Click += new System.EventHandler(this.button2_Click);
                  // 
                  // groupBox3
                  // 
                  this.groupBox3.Controls.Add(this.comboBox1);
                  this.groupBox3.Controls.Add(this.label21);
                  this.groupBox3.Controls.Add(this.button2);
                  this.groupBox3.Controls.Add(this.textBox15);
                  this.groupBox3.Controls.Add(this.radioButton2);
                  this.groupBox3.Controls.Add(this.radioButton1);
                  this.groupBox3.Location = new System.Drawing.Point(14, 34);
                  this.groupBox3.Name = "groupBox3";
                  this.groupBox3.Size = new System.Drawing.Size(899, 48);
                  this.groupBox3.TabIndex = 10;
                  this.groupBox3.TabStop = false;
                  this.groupBox3.Text = "查找";
                  // 
                  // comboBox1
                  // 
                  this.comboBox1.FormattingEnabled = true;
                  this.comboBox1.Items.AddRange(new object[] {
            "全部",
            "衣服",
            "护手",
            "武器",
            "靴子",
            "内甲",
            "项链",
            "耳环",
            "戒指",
            "披风",
            "灵兽",
            "石头",
            "盒子",
            "符文",
            "任务VAT_PHAM",
            "百宝",
            "其他"});
                  this.comboBox1.Location = new System.Drawing.Point(103, 15);
                  this.comboBox1.Name = "comboBox1";
                  this.comboBox1.Size = new System.Drawing.Size(140, 20);
                  this.comboBox1.TabIndex = 11;
                  this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
                  // 
                  // label21
                  // 
                  this.label21.AutoSize = true;
                  this.label21.Location = new System.Drawing.Point(17, 20);
                  this.label21.Name = "label21";
                  this.label21.Size = new System.Drawing.Size(89, 12);
                  this.label21.TabIndex = 10;
                  this.label21.Text = "Item_loai_hinh:";
                  // 
                  // YbiForm
                  // 
                  this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
                  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                  this.ClientSize = new System.Drawing.Size(937, 523);
                  this.Controls.Add(this.groupBox3);
                  this.Controls.Add(this.label28);
                  this.Controls.Add(this.label27);
                  this.Controls.Add(this.groupBox2);
                  this.Controls.Add(this.groupBox1);
                  this.Controls.Add(this.menuStrip1);
                  this.MainMenuStrip = this.menuStrip1;
                  this.Name = "YbiForm";
                  this.Text = "YBI编辑器";
                  this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.b);
                  this.Load += new System.EventHandler(this.c);
                  this.menuStrip1.ResumeLayout(false);
                  this.menuStrip1.PerformLayout();
                  this.groupBox1.ResumeLayout(false);
                  this.groupBox2.ResumeLayout(false);
                  this.groupBox2.PerformLayout();
                  this.groupBox3.ResumeLayout(false);
                  this.groupBox3.PerformLayout();
                  this.ResumeLayout(false);
                  this.PerformLayout();

		}

		private void listBox1_SelectedValueChanged(object sender, EventArgs e)
		{
			TBL_XWWL_ITEM_CLASS tBLXWWLITEMCLAss = this.method_1(this.listBox1.SelectedItem.ToString());
			if (tBLXWWLITEMCLAss != null)
			{
				this.textBox1.Text = tBLXWWLITEMCLAss.FLD_PID.ToString();
				this.textBox2.Text = tBLXWWLITEMCLAss.FLD_QUESTITEM.ToString();
				this.textBox3.Text = tBLXWWLITEMCLAss.FLD_Name;
				this.textBox4.Text = tBLXWWLITEMCLAss.FLD_NJ.ToString();
				this.textBox5.Text = tBLXWWLITEMCLAss.FLD_RESIDE1.ToString();
				this.textBox6.Text = tBLXWWLITEMCLAss.FLD_RESIDE2.ToString();
				this.textBox7.Text = tBLXWWLITEMCLAss.FLD_SEX.ToString();
				this.textBox8.Text = tBLXWWLITEMCLAss.FLD_DF.ToString();
				this.textBox9.Text = tBLXWWLITEMCLAss.FLD_AT1.ToString();
				this.textBox10.Text = tBLXWWLITEMCLAss.FLD_AT2.ToString();
				this.textBox11.Text = tBLXWWLITEMCLAss.FLD_LEVEL.ToString();
				this.textBox12.Text = tBLXWWLITEMCLAss.FLD_JOB_LEVEL.ToString();
				this.textBox13.Text = tBLXWWLITEMCLAss.FLD_ZX.ToString();
				this.textBox14.Text = tBLXWWLITEMCLAss.FLD_THUYET_MINH;
				this.textBox21.Text = tBLXWWLITEMCLAss.FLD_TYPE.ToString();
				this.textBox22.Text = tBLXWWLITEMCLAss.FLD_WEIGHT.ToString();
				this.textBox23.Text = tBLXWWLITEMCLAss.FLD_MONEY.ToString();
				this.textBox24.Text = tBLXWWLITEMCLAss.FLD_EL.ToString();
				this.textBox25.Text = tBLXWWLITEMCLAss.FLD_WXJD.ToString();
				this.textBox26.Text = tBLXWWLITEMCLAss.FLD_WX.ToString();
			}
		}

		private TBL_XWWL_ITEM_CLASS method_0(int int_0)
		{
			TBL_XWWL_ITEM_CLASS tBLXWWLITEMCLAss;
			Dictionary<int, TBL_XWWL_ITEM_CLASS>.ValueCollection.Enumerator enumerator = YbiForm.dictionary_0.Values.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					TBL_XWWL_ITEM_CLASS current = enumerator.Current;
					if (current.FLD_PID != int_0)
					{
						continue;
					}
					tBLXWWLITEMCLAss = current;
					return tBLXWWLITEMCLAss;
				}
				return null;
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			return tBLXWWLITEMCLAss;
		}

		private TBL_XWWL_ITEM_CLASS method_1(string string_0)
		{
			TBL_XWWL_ITEM_CLASS tBLXWWLITEMCLAss;
			Dictionary<int, TBL_XWWL_ITEM_CLASS>.ValueCollection.Enumerator enumerator = YbiForm.dictionary_0.Values.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					TBL_XWWL_ITEM_CLASS current = enumerator.Current;
					if (current.FLD_Name != string_0)
					{
						continue;
					}
					tBLXWWLITEMCLAss = current;
					return tBLXWWLITEMCLAss;
				}
				return null;
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			return tBLXWWLITEMCLAss;
		}

		private TBL_XWWL_ITEM_CLASS method_2(int int_0)
		{
			TBL_XWWL_ITEM_CLASS tBLXWWLITEMCLAss;
			Dictionary<int, TBL_XWWL_ITEM_CLASS>.ValueCollection.Enumerator enumerator = YbiForm.dictionary_0.Values.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					TBL_XWWL_ITEM_CLASS current = enumerator.Current;
					if (current.FLD_RESIDE2 != int_0)
					{
						continue;
					}
					tBLXWWLITEMCLAss = current;
					return tBLXWWLITEMCLAss;
				}
				return null;
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			return tBLXWWLITEMCLAss;
		}

		public void method_3(BinaryReader binaryReader_0, int int_0, int int_1, ref byte[] byte_14)
		{
			for (int i = 0; i < int_1; i++)
			{
				byte[] numArray = new byte[int_0];
				binaryReader_0.Read(numArray, 0, (int)numArray.Length);
				Buffer.BlockCopy(numArray, 0, byte_14, i * (int)numArray.Length, (int)numArray.Length);
			}
		}

		private void method_4()
		{
			using (FileStream fileStream = new FileStream("YBi.cfg.bak", FileMode.Open, FileAccess.Read, FileShare.Read))
			{
				BinaryReader binaryReader = new BinaryReader(fileStream);
				binaryReader.ReadInt32();
				binaryReader.ReadInt32();
				this.method_3(binaryReader, 848, 4238, ref this.byte_12);
				this.method_3(binaryReader, 64, 1, ref this.byte_3);
				this.method_3(binaryReader, 6736, 1024, ref this.byte_11);
				this.method_3(binaryReader, 1388, 1024, ref this.byte_8);
				this.method_3(binaryReader, 72, 128, ref this.byte_4);
				this.method_3(binaryReader, 64, 2048, ref this.byte_6);
				this.method_3(binaryReader, 128, 2048, ref this.byte_7);
				this.method_3(binaryReader, 7860, 2048, ref this.byte_13);
				this.method_3(binaryReader, 16, 6, ref this.byte_9);
				this.method_3(binaryReader, 100, 1024, ref this.byte_5);
				this.method_3(binaryReader, 96, 1024, ref this.byte_10);
			}
			this.method_6();
		}

		private void method_5()
		{
			try
			{
				using (FileStream fileStream = new FileStream("YBi.cfg1.bak", FileMode.Open, FileAccess.Read, FileShare.Read))
				{
					using (FileStream fileStream1 = new FileStream("YBiNew.cfg", FileMode.Create, FileAccess.Write, FileShare.Read))
					{
						BinaryReader binaryReader = new BinaryReader(fileStream);
						fileStream1.Write(BitConverter.GetBytes(binaryReader.ReadInt32()), 0, 4);
						fileStream1.Write(BitConverter.GetBytes(binaryReader.ReadInt32()), 0, 4);
						byte[] numArray = new byte[4];
						while (binaryReader.Read(numArray, 0, 4) > 0)
						{
							fileStream1.Write(BitConverter.GetBytes(YbiForm.smethod_0(BitConverter.ToUInt32(numArray, 0), 1)), 0, 4);
						}
					}
				}
				MessageBox.Show("完成,新的文件为'YBiNew.cfg'", "提示");
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.ToString(), "错误");
			}
		}

		private void method_6()
		{
			YbiForm.dictionary_0.Clear();
			int num = 0;
			while (num < 5096)
			{
				int num1 = 0;
				int num2 = 0;
				int num3 = 0;
				TBL_XWWL_ITEM_CLASS tBLXWWLITEMCLAss = new TBL_XWWL_ITEM_CLASS();
				byte[] numArray = new byte[848];
				Buffer.BlockCopy(this.byte_12, num * (int)numArray.Length, numArray, 0, (int)numArray.Length);
				if (BitConverter.ToInt32(numArray, 0) == 0)
				{
					break;
				}
				string str = Encoding.Default.GetString(numArray, 8, 64).Replace("\0", "").Replace('\'', ' ');
				if (str == "")
				{
					str = "未知VAT_PHAM(待命名)";
				}
				string str1 = Encoding.Default.GetString(numArray, 156, 256).Replace("\0", "").Replace('\'', ' ');
				if (str1 != null && str1.Length == 0 || str1 == " ")
				{
					str1 = str;
				}
				int num4 = BitConverter.ToInt16(numArray, 80);
				this.listBox1.Items.Add(str);
				int num5 = BitConverter.ToInt32(numArray, 0);
				int num6 = BitConverter.ToInt16(numArray, 96);
				tBLXWWLITEMCLAss.FLD_PID = num5;
				tBLXWWLITEMCLAss.FLD_Name = str;
				tBLXWWLITEMCLAss.FLD_THUYET_MINH = str1;
				tBLXWWLITEMCLAss.FLD_ZX = numArray[73];
				tBLXWWLITEMCLAss.FLD_RESIDE1 = numArray[74];
				if (tBLXWWLITEMCLAss.FLD_Name.Contains("盒") && !tBLXWWLITEMCLAss.FLD_Name.Contains("江湖小助手礼盒") && !tBLXWWLITEMCLAss.FLD_Name.Contains("礼券"))
				{
					tBLXWWLITEMCLAss.FLD_RESIDE2 = 17;
				}
				switch (tBLXWWLITEMCLAss.FLD_RESIDE1)
				{
					case 11:
					{
						tBLXWWLITEMCLAss.FLD_RESIDE1 = 6;
						break;
					}
					case 12:
					{
						tBLXWWLITEMCLAss.FLD_RESIDE1 = 7;
						break;
					}
					case 13:
					{
						tBLXWWLITEMCLAss.FLD_RESIDE1 = 8;
						break;
					}
				}
				tBLXWWLITEMCLAss.FLD_LEVEL = BitConverter.ToInt16(numArray, 76);
				tBLXWWLITEMCLAss.FLD_JOB_LEVEL = numArray[78];
				tBLXWWLITEMCLAss.FLD_SEX = numArray[79];
				tBLXWWLITEMCLAss.FLD_WEIGHT = 0;
				tBLXWWLITEMCLAss.FLD_AT2 = BitConverter.ToInt16(numArray, 84);
				tBLXWWLITEMCLAss.FLD_AT1 = BitConverter.ToInt16(numArray, 86);
				tBLXWWLITEMCLAss.FLD_DF = BitConverter.ToInt16(numArray, 88);
				tBLXWWLITEMCLAss.FLD_NJ = num6;
				tBLXWWLITEMCLAss.FLD_MONEY = BitConverter.ToInt32(numArray, 100);
				tBLXWWLITEMCLAss.FLD_EL = BitConverter.ToInt16(numArray, 113);
				switch (num4)
				{
					case 3:
					{
						num4 = 4;
						goto case 20;
					}
					case 4:
					{
						num4 = 5;
						goto case 20;
					}
					case 5:
					{
						num4 = 6;
						goto case 20;
					}
					case 6:
					{
						num4 = 7;
						goto case 20;
					}
					case 7:
					{
						num4 = 8;
						goto case 20;
					}
					case 8:
					{
						num4 = 10;
						goto case 20;
					}
					case 9:
					{
						num4 = 12;
						goto case 20;
					}
					case 10:
					{
						num4 = 16;
						goto case 20;
					}
					case 11:
					{
						num4 = 18;
						goto case 20;
					}
					case 12:
					{
						num4 = 16;
						goto case 20;
					}
					case 13:
					case 14:
					case 15:
					case 16:
					case 17:
					case 18:
					case 20:
					{
						tBLXWWLITEMCLAss.FLD_RESIDE2 = num4;
						tBLXWWLITEMCLAss.FLD_WX = 0;
						tBLXWWLITEMCLAss.FLD_WXJD = 0;
						if (num5 > 900000001 && num5 < 1000000000)
						{
							num1 = 1;
						}
						tBLXWWLITEMCLAss.FLD_QUESTITEM = num1;
						if (num5.ToString().Contains("1008000") || num5.ToString().Contains("16900") || num5.ToString().Contains("26900") || num5.ToString().Contains("1007000"))
						{
							num2 = 6;
						}
						tBLXWWLITEMCLAss.FLD_TYPE = num2;
						if (num6 == 0)
						{
							num3 = 0;
						}
						else
						{
							string str2 = "2000000";
							switch (num6.ToString().Length)
							{
								case 1:
								{
									str2 = "200000000";
									goto case 3;
								}
								case 2:
								{
									str2 = "20000000";
									goto case 3;
								}
								case 3:
								{
									num3 = int.Parse(string.Concat(str2, num6.ToString()));
									break;
								}
								case 4:
								{
									str2 = "200000";
									goto case 3;
								}
								default:
								{
									goto case 3;
								}
							}
						}
						tBLXWWLITEMCLAss.FLD_MAGIC1 = num3;
						tBLXWWLITEMCLAss.FLD_SIDE = 0;
						tBLXWWLITEMCLAss.FLD_CJL = 0;
						if ((tBLXWWLITEMCLAss.FLD_Name.Contains("箭") || tBLXWWLITEMCLAss.FLD_Name.Contains("回城") || tBLXWWLITEMCLAss.FLD_THUYET_MINH.Contains("材料")) && !tBLXWWLITEMCLAss.FLD_Name.Contains("箭破残阳") && !tBLXWWLITEMCLAss.FLD_Name.Contains("石"))
						{
							tBLXWWLITEMCLAss.FLD_SIDE = 1;
						}
						if (tBLXWWLITEMCLAss.FLD_Name.Contains("强化石") || tBLXWWLITEMCLAss.FLD_Name.Contains("高级强化石"))
						{
							tBLXWWLITEMCLAss.FLD_SIDE = 1;
						}
						if (tBLXWWLITEMCLAss.FLD_Name.Contains("纹龙") || tBLXWWLITEMCLAss.FLD_Name.Contains("绣龙") || tBLXWWLITEMCLAss.FLD_Name.Contains("金龙"))
						{
							tBLXWWLITEMCLAss.FLD_CJL = 1000;
						}
						if (tBLXWWLITEMCLAss.FLD_Name == "玄武" || tBLXWWLITEMCLAss.FLD_Name == "北天玄武刀" || tBLXWWLITEMCLAss.FLD_Name.Contains("玄武龙啸"))
						{
							tBLXWWLITEMCLAss.FLD_CJL = 1000;
						}
						if (tBLXWWLITEMCLAss.FLD_Name == "青龙" || tBLXWWLITEMCLAss.FLD_Name == "青天青龙剑" || tBLXWWLITEMCLAss.FLD_Name.Contains("青龙缠天"))
						{
							tBLXWWLITEMCLAss.FLD_CJL = 1000;
						}
						if (tBLXWWLITEMCLAss.FLD_Name == "朱雀" || tBLXWWLITEMCLAss.FLD_Name == "南天朱雀弓" || tBLXWWLITEMCLAss.FLD_Name.Contains("朱雀覆火"))
						{
							tBLXWWLITEMCLAss.FLD_CJL = 1000;
						}
						if (tBLXWWLITEMCLAss.FLD_Name == "麒麟" || tBLXWWLITEMCLAss.FLD_Name == "中天麒麟枪" || tBLXWWLITEMCLAss.FLD_Name.Contains("麒麟踏宇"))
						{
							tBLXWWLITEMCLAss.FLD_CJL = 1000;
						}
						if (tBLXWWLITEMCLAss.FLD_Name == "白虎" || tBLXWWLITEMCLAss.FLD_Name == "西天白虎扇" || tBLXWWLITEMCLAss.FLD_Name.Contains("虎扇吞日"))
						{
							tBLXWWLITEMCLAss.FLD_CJL = 1000;
						}
						if (tBLXWWLITEMCLAss.FLD_Name == "鬼牙" || tBLXWWLITEMCLAss.FLD_Name == "玄天鬼牙刃" || tBLXWWLITEMCLAss.FLD_Name.Contains("天兆鬼牙"))
						{
							tBLXWWLITEMCLAss.FLD_CJL = 1000;
						}
						if (tBLXWWLITEMCLAss.FLD_Name == "鳳凰" || tBLXWWLITEMCLAss.FLD_Name == "齐天凤凰琴" || tBLXWWLITEMCLAss.FLD_Name.Contains("凤凰栾鸣"))
						{
							tBLXWWLITEMCLAss.FLD_CJL = 1000;
						}
						tBLXWWLITEMCLAss.FLD_MAGIC2 = 0;
						tBLXWWLITEMCLAss.FLD_MAGIC3 = 0;
						tBLXWWLITEMCLAss.FLD_MAGIC4 = 0;
						tBLXWWLITEMCLAss.FLD_MAGIC5 = 0;
						tBLXWWLITEMCLAss.FLD_byte = numArray;
						if (!YbiForm.dictionary_0.ContainsKey(num5))
						{
							YbiForm.dictionary_0.Add(num5, tBLXWWLITEMCLAss);
						}
						num++;
						continue;
					}
					case 19:
					{
						num4 = 16;
						goto case 20;
					}
					case 21:
					{
						num4 = 14;
						goto case 20;
					}
					case 22:
					{
						num4 = 15;
						goto case 20;
					}
					default:
					{
						goto case 20;
					}
				}
			}
			this.label28.Text = this.listBox1.Items.Count.ToString();
		}

		public static int smethod_0(uint uint_0, int int_0)
		{
			int num = 0;
			int num1 = 0;
			int num2 = 0;
			while (uint_0 != 0)
			{
				int uint0 = (int)(uint_0 - (uint_0 & -2));
				uint_0 = uint_0 >> 1;
				if (uint0 > 0)
				{
					num1 = (int_0 != 0 ? YbiForm.byte_2[num2 + 32] : YbiForm.byte_2[num2]);
					num = num + (uint0 << (num1 & 31));
				}
				num2++;
			}
			return num;
		}

		private void VAT_PHAM入库ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int fLDNJ;
			try
			{
				if (this.listBox1.Items.Count != 0)
				{
					int num = 0;
					int num1 = 0;
					foreach (TBL_XWWL_ITEM_CLASS value in YbiForm.dictionary_0.Values)
					{
						if (value.FLD_PID > 900000001 && value.FLD_PID < 1000000000)
						{
							value.FLD_QUESTITEM = 1;
							value.FLD_SIDE = 1;
						}
						if (value.FLD_PID.ToString().Contains("1008000") || value.FLD_PID.ToString().Contains("16900") || value.FLD_PID.ToString().Contains("26900") || value.FLD_PID.ToString().Contains("1007000"))
						{
							value.FLD_TYPE = 6;
						}
						else
						{
							value.FLD_TYPE = 0;
						}
						if (value.FLD_PID == 111301009)
						{
							value.FLD_NJ = 0;
						}
						if (value.FLD_NJ == 0)
						{
							num = 0;
						}
						else
						{
							string str = "2000000";
							switch (value.FLD_NJ.ToString().Length)
							{
								case 1:
								{
									str = "200000000";
									goto case 3;
								}
								case 2:
								{
									str = "20000000";
									goto case 3;
								}
								case 3:
								{
									fLDNJ = value.FLD_NJ;
									num = int.Parse(string.Concat(str, fLDNJ.ToString()));
									break;
								}
								case 4:
								{
									str = "200000";
									goto case 3;
								}
								default:
								{
									goto case 3;
								}
							}
						}
						value.FLD_MAGIC1 = num;
						fLDNJ = value.FLD_PID;
						DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT * FROM TBL_XWWL_ITEM WHERE FLD_PID = {0}", fLDNJ.ToString()), "PublicDb");
						if (dBToDataTable == null)
						{
							continue;
						}
						if (dBToDataTable.Rows.Count == 0)
						{
							DBA.smethod_7(string.Format("INSERT INTO TBL_XWWL_ITEM (FLD_PID, FLD_NAME, FLD_RESIDE1, FLD_RESIDE2, FLD_SEX, FLD_DF, FLD_AT1, FLD_AT2, FLD_LEVEL, FLD_JOB_LEVEL, FLD_ZX, FLD_MONEY, FLD_WEIGHT,FLD_DES,FLD_WX,FLD_WXJD,FLD_EL,FLD_QUESTITEM,FLD_NJ,FLD_TYPE,FLD_MAGIC1,FLD_MAGIC2,FLD_MAGIC3,FLD_MAGIC4,FLD_MAGIC5,FLD_SIDE,fld_cjl) VALUES ({0}, '{1}', {2}, {3},{4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12},'{13}',{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24},{25},{26})", new object[] { value.FLD_PID, value.FLD_Name, value.FLD_RESIDE1, value.FLD_RESIDE2, value.FLD_SEX, value.FLD_DF, value.FLD_AT1, value.FLD_AT2, value.FLD_LEVEL, value.FLD_JOB_LEVEL, value.FLD_ZX, value.FLD_MONEY, value.FLD_WEIGHT, value.FLD_THUYET_MINH, value.FLD_WX, value.FLD_WXJD, value.FLD_EL, value.FLD_QUESTITEM, value.FLD_NJ, value.FLD_TYPE, value.FLD_MAGIC1, 0, 0, 0, 0, value.FLD_SIDE, value.FLD_CJL }), "PublicDb");
							num1++;
						}
						dBToDataTable.Clear();
						dBToDataTable.Dispose();
					}
					MessageBox.Show(string.Concat("完成,共增加新VAT_PHAM", num1.ToString()), "提示");
				}
				else
				{
					MessageBox.Show("请先打开Ybi.cfg文件!", "提示");
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.ToString(), "错误");
			}
		}

		private static void ZYDNGuard()
		{
			YbiForm.byte_2 = new byte[] { 18, 29, 7, 25, 15, 31, 22, 27, 9, 26, 3, 13, 19, 14, 20, 11, 5, 2, 23, 16, 10, 24, 28, 17, 6, 30, 0, 21, 12, 8, 4, 1, 26, 31, 17, 10, 30, 16, 24, 2, 29, 8, 20, 15, 28, 11, 13, 4, 19, 23, 0, 12, 14, 27, 6, 18, 21, 3, 9, 7, 22, 1, 25, 5 };
			YbiForm.dictionary_0 = new Dictionary<int, TBL_XWWL_ITEM_CLASS>();
		}
	}
}