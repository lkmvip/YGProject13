using ns11;
using ns13;
using ns2;
using ns3;
using ns9;
using RxjhServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ns12
{
	internal class Form2 : Form
	{
		private ColumnHeader columnHeader_0;

		private ColumnHeader columnHeader_1;

		private ColumnHeader columnHeader_10;

		private ColumnHeader columnHeader_11;

		private ColumnHeader columnHeader_2;

		private ColumnHeader columnHeader_3;

		private ColumnHeader columnHeader_4;

		private ColumnHeader columnHeader_5;

		private ColumnHeader columnHeader_6;

		private ColumnHeader columnHeader_7;

		private ColumnHeader columnHeader_8;

		private ColumnHeader columnHeader_9;

		private IContainer icontainer_0 = new System.ComponentModel.Container();

		private ListView listView2;

		public Form2()
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

		private void Form2_Load(object sender, EventArgs e)
		{
			long num;
			int rxjhMap;
			float rxjhX;
			this.listView2.ListViewItemSorter = new ListViewColumnSorter();
			this.listView2.ColumnClick += new ColumnClickEventHandler(ListViewItemS.smethod_0);
			foreach (MAT_DAT_ITEM_LOAI value in World.threadSafeDictionary_3.Values)
			{
				try
				{
					string[] str = new string[17];
					try
					{
						num = BitConverter.ToInt64(value.VAT_PHAM.Item_toan_bo_ID, 0);
						str[0] = num.ToString();
						rxjhMap = BitConverter.ToInt32(value.VAT_PHAM.VAT_PHAM_ID, 0);
						str[1] = rxjhMap.ToString();
						str[2] = value.VAT_PHAM.method_13();
						rxjhMap = value.Rxjh_Map;
						str[3] = rxjhMap.ToString();
						rxjhX = value.Rxjh_X;
						str[4] = rxjhX.ToString();
						rxjhX = value.Rxjh_Y;
						str[5] = rxjhX.ToString();
						rxjhMap = value.VAT_PHAM.FLD_MAGIC0;
						str[6] = rxjhMap.ToString();
						rxjhMap = value.VAT_PHAM.FLD_MAGIC1;
						str[7] = rxjhMap.ToString();
						rxjhMap = value.VAT_PHAM.FLD_MAGIC2;
						str[8] = rxjhMap.ToString();
						rxjhMap = value.VAT_PHAM.FLD_MAGIC3;
						str[9] = rxjhMap.ToString();
						rxjhMap = value.VAT_PHAM.FLD_MAGIC4;
						str[10] = rxjhMap.ToString();
						str[11] = value.VAT_PHAM_QUYEN_UU_TIEN.UserName;
					}
					catch
					{
						num = BitConverter.ToInt64(value.VAT_PHAM.Item_toan_bo_ID, 0);
						str[0] = num.ToString();
						rxjhMap = BitConverter.ToInt32(value.VAT_PHAM.VAT_PHAM_ID, 0);
						str[1] = rxjhMap.ToString();
						str[2] = value.VAT_PHAM.method_13();
						rxjhMap = value.Rxjh_Map;
						str[3] = rxjhMap.ToString();
						rxjhX = value.Rxjh_X;
						str[4] = rxjhX.ToString();
						rxjhX = value.Rxjh_Y;
						str[5] = rxjhX.ToString();
						rxjhMap = value.VAT_PHAM.FLD_MAGIC0;
						str[6] = rxjhMap.ToString();
						rxjhMap = value.VAT_PHAM.FLD_MAGIC1;
						str[7] = rxjhMap.ToString();
						rxjhMap = value.VAT_PHAM.FLD_MAGIC2;
						str[8] = rxjhMap.ToString();
						rxjhMap = value.VAT_PHAM.FLD_MAGIC3;
						str[9] = rxjhMap.ToString();
						rxjhMap = value.VAT_PHAM.FLD_MAGIC4;
						str[10] = rxjhMap.ToString();
					}
					this.listView2.Items.Insert(this.listView2.Items.Count, new ListViewItem(str));
				}
				catch
				{
				}
			}
		}

		private void InitializeComponent()
		{
			this.listView2 = new ListView();
			this.columnHeader_0 = new ColumnHeader();
			this.columnHeader_1 = new ColumnHeader();
			this.columnHeader_2 = new ColumnHeader();
			this.columnHeader_3 = new ColumnHeader();
			this.columnHeader_4 = new ColumnHeader();
			this.columnHeader_5 = new ColumnHeader();
			this.columnHeader_6 = new ColumnHeader();
			this.columnHeader_7 = new ColumnHeader();
			this.columnHeader_8 = new ColumnHeader();
			this.columnHeader_9 = new ColumnHeader();
			this.columnHeader_10 = new ColumnHeader();
			this.columnHeader_11 = new ColumnHeader();
			base.SuspendLayout();
			this.listView2.Columns.AddRange(new ColumnHeader[] { this.columnHeader_0, this.columnHeader_1, this.columnHeader_2, this.columnHeader_3, this.columnHeader_4, this.columnHeader_5, this.columnHeader_6, this.columnHeader_7, this.columnHeader_8, this.columnHeader_9, this.columnHeader_10, this.columnHeader_11 });
			this.listView2.Dock = DockStyle.Fill;
			this.listView2.ForeColor = SystemColors.WindowText;
			this.listView2.FullRowSelect = true;
			this.listView2.GridLines = true;
			this.listView2.Location = new Point(0, 0);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(772, 416);
			this.listView2.TabIndex = 3;
			this.listView2.UseCompatibleStateImageBehavior = false;
			this.listView2.View = View.Details;
			this.columnHeader_0.Text = "全局ID";
			this.columnHeader_0.Width = 65;
			this.columnHeader_1.Text = "VAT_PHAM_ID";
			this.columnHeader_1.TextAlign = HorizontalAlignment.Center;
			this.columnHeader_1.Width = 79;
			this.columnHeader_2.Text = "VAT_PHAM名";
			this.columnHeader_2.TextAlign = HorizontalAlignment.Center;
			this.columnHeader_2.Width = 98;
			this.columnHeader_3.Text = "地图";
			this.columnHeader_3.Width = 42;
			this.columnHeader_4.Text = "X";
			this.columnHeader_4.Width = 61;
			this.columnHeader_5.Text = "Y";
			this.columnHeader_5.Width = 61;
			this.columnHeader_6.Text = "属性0";
			this.columnHeader_6.TextAlign = HorizontalAlignment.Center;
			this.columnHeader_7.Text = "Thuoc_tinh_1";
			this.columnHeader_7.TextAlign = HorizontalAlignment.Center;
			this.columnHeader_8.Text = "Thuoc_tinh_2";
			this.columnHeader_8.TextAlign = HorizontalAlignment.Center;
			this.columnHeader_9.Text = "Thuoc_tinh_3";
			this.columnHeader_9.TextAlign = HorizontalAlignment.Center;
			this.columnHeader_10.Text = "Thuoc_tinh_4";
			this.columnHeader_10.TextAlign = HorizontalAlignment.Center;
			this.columnHeader_11.Text = "优先";
			this.columnHeader_11.TextAlign = HorizontalAlignment.Center;
			this.columnHeader_11.Width = 56;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(772, 416);
			base.Controls.Add(this.listView2);
			base.Name = "Form2";
			this.Text = "地面VAT_PHAM";
			base.Load += new EventHandler(this.Form2_Load);
			base.ResumeLayout(false);
		}

		public static void smethod_0()
		{
			int num = 0;
			Form1.WriteLine(100, "删除人物数据开始");
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("select * from TBL_XWWL_Char", new object[0]));
			if (dBToDataTable != null)
			{
				Form1.WriteLine(100, string.Concat("共有人物数据", dBToDataTable.Rows.Count));
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					num++;
					Form1.WriteLine(100, string.Concat(new object[] { "删除人物[", dBToDataTable.Rows[i]["FLD_ID"].ToString(), "] [", dBToDataTable.Rows[i]["FLD_NAME"], "]" }));
					DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_Char WHERE FLD_NAME  ='{0}'", dBToDataTable.Rows[i]["FLD_NAME"].ToString()));
					DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_warehouse WHERE FLD_NAME  ='{0}'", dBToDataTable.Rows[i]["FLD_NAME"].ToString()));
					DataTable dataTable = DBA.GetDBToDataTable(string.Format("select * from TBL_XWWL_GuildMember WHERE Name ='{0}'", dBToDataTable.Rows[i]["FLD_NAME"].ToString()));
					if (dataTable != null)
					{
						if (dataTable.Rows.Count > 0)
						{
							if (dataTable.Rows[0]["leve"].ToString() != "6")
							{
								DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_GuildMember WHERE Name  ='{0}'", dBToDataTable.Rows[i]["FLD_NAME"].ToString()));
							}
							else
							{
								Form1.WriteLine(100, string.Concat("删除帮派", dataTable.Rows[0]["G_Name"]));
								DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_Guild WHERE G_Name  ='{0}'", dataTable.Rows[0]["G_Name"].ToString()));
								DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_GuildMember WHERE G_Name  ='{0}'", dataTable.Rows[0]["G_Name"].ToString()));
							}
						}
						dataTable.Dispose();
					}
				}
				dBToDataTable.Dispose();
			}
			Form1.WriteLine(100, string.Concat("删除人物数据完成", num));
		}

		public static void smethod_1()
		{
			int num = 0;
			Form1.WriteLine(100, "删除人物仓库数据开始");
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("select * from TBL_XWWL_warehouse", new object[0]));
			if (dBToDataTable != null)
			{
				Form1.WriteLine(100, string.Concat("共有人物数据", dBToDataTable.Rows.Count));
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					DataTable dataTable = DBA.GetDBToDataTable(string.Format("select * from TBL_XWWL_Char where FLD_NAME='{0}'", dBToDataTable.Rows[i]["FLD_NAME"]));
					if (dataTable.Rows.Count < 1)
					{
						num++;
						Form1.WriteLine(100, string.Concat(new object[] { "删除人物仓库[", dBToDataTable.Rows[i]["FLD_ID"].ToString(), "] [", dBToDataTable.Rows[i]["FLD_NAME"], "]" }));
						DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_warehouse WHERE FLD_ID='{0}'and FLD_NAME  ='{1}'", dBToDataTable.Rows[i]["FLD_ID"].ToString(), dBToDataTable.Rows[i]["FLD_NAME"].ToString()));
					}
					else if (dataTable.Rows[0]["FLD_ID"].ToString() != dBToDataTable.Rows[i]["FLD_ID"].ToString())
					{
						num++;
						Form1.WriteLine(100, string.Concat(new object[] { "删除人物仓库[", dBToDataTable.Rows[i]["FLD_ID"].ToString(), "] [", dBToDataTable.Rows[i]["FLD_NAME"], "]" }));
						DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_warehouse WHERE FLD_ID='{0}'and FLD_NAME  ='{1}'", dBToDataTable.Rows[i]["FLD_ID"].ToString(), dBToDataTable.Rows[i]["FLD_NAME"].ToString()));
					}
					dataTable.Dispose();
				}
				dBToDataTable.Dispose();
			}
			Form1.WriteLine(100, string.Concat("删除人物仓库数据完成", num));
		}

		public static void smethod_2()
		{
			int num = 0;
			Form1.WriteLine(100, "删除宗合仓库开始");
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("select * from TBL_XWWL_PublicWarehouse", new object[0]));
			if (dBToDataTable != null)
			{
				Form1.WriteLine(100, string.Concat("共有宗合仓库数据", dBToDataTable.Rows.Count));
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					string.Format("select count(*) from TBL_ACCOUNT where FLD_ID='{0}'", dBToDataTable.Rows[i]["FLD_ID"]);
					num++;
					Form1.WriteLine(100, string.Concat("删除宗合仓库[", dBToDataTable.Rows[i]["FLD_ID"].ToString(), "]"));
					DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_PublicWarehouse WHERE FLD_ID  ='{0}'", dBToDataTable.Rows[i]["FLD_ID"].ToString()));
				}
				dBToDataTable.Dispose();
			}
			Form1.WriteLine(100, string.Concat("删除宗合仓库完成", num));
		}

		public static void smethod_3()
		{
			int num = 0;
			Form1.WriteLine(100, "删除帮派数据开始");
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("select * from TBL_XWWL_Guild", new object[0]));
			if (dBToDataTable != null)
			{
				Form1.WriteLine(100, string.Concat("共有人物数据", dBToDataTable.Rows.Count));
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					DataTable dataTable = DBA.GetDBToDataTable(string.Format("select * from TBL_XWWL_Char where FLD_NAME='{0}'", dBToDataTable.Rows[i]["G_Master"]));
					if (dataTable.Rows.Count < 1)
					{
						num++;
						Form1.WriteLine(100, string.Concat(new object[] { "删除帮派[", dBToDataTable.Rows[i]["G_Name"].ToString(), "] [", dBToDataTable.Rows[i]["G_Master"], "]" }));
						DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_Guild WHERE G_Name  ='{0}'", dBToDataTable.Rows[i]["G_Name"].ToString()));
						DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_GuildMember WHERE G_Name  ='{0}'", dBToDataTable.Rows[i]["G_Name"].ToString()));
					}
					dataTable.Dispose();
				}
				dBToDataTable.Dispose();
			}
			Form1.WriteLine(100, string.Concat("删除帮派数据完成", num));
			Form2.smethod_4();
		}

		public static void smethod_4()
		{
			int num = 0;
			Form1.WriteLine(100, "删除帮派数据开始");
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("select * from TBL_XWWL_GuildMember", new object[0]));
			if (dBToDataTable != null)
			{
				Form1.WriteLine(100, string.Concat("共有帮派数据", dBToDataTable.Rows.Count));
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					DataTable dataTable = DBA.GetDBToDataTable(string.Format("select * from TBL_XWWL_Char where FLD_NAME='{0}'", dBToDataTable.Rows[i]["Name"]));
					if (dataTable.Rows.Count < 1)
					{
						num++;
						if (dBToDataTable.Rows[0]["leve"].ToString() != "6")
						{
							Form1.WriteLine(100, string.Concat(new object[] { "删除帮派", dBToDataTable.Rows[i]["G_Name"], "    ", dBToDataTable.Rows[i]["Name"].ToString() }));
							DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_GuildMember WHERE Name  ='{0}'", dBToDataTable.Rows[i]["Name"].ToString()));
						}
						else
						{
							Form1.WriteLine(100, string.Concat("删除帮派", dBToDataTable.Rows[i]["G_Name"]));
							DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_Guild WHERE G_Name  ='{0}'", dBToDataTable.Rows[0]["G_Name"].ToString()));
							DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_GuildMember WHERE G_Name  ='{0}'", dBToDataTable.Rows[0]["G_Name"].ToString()));
						}
					}
					dataTable.Dispose();
				}
				dBToDataTable.Dispose();
			}
			Form1.WriteLine(100, string.Concat("删除帮派数据完成", num));
		}
	}
}