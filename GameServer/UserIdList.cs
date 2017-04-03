namespace ns0
{
      using ns13;
      using ns3;
      using System;
      using System.Collections.Generic;
      using System.ComponentModel;
      using System.Drawing;
      using System.Windows.Forms;

      internal class UserIdList: Form
      {
            private ColumnHeader columnHeader_0;
            private ColumnHeader columnHeader_1;
            private IContainer icontainer_0 = new Container();
            private ListView listView1;
            private PropertyGrid propertyGridNPC;
            private string string_0;

            public UserIdList()
            {
                  this.InitializeComponent();
            }

            protected override void Dispose(bool disposing)
            {
                  if (disposing && (this.icontainer_0 != null))
                  {
                        this.icontainer_0.Dispose();
                  }
                  base.Dispose(disposing);
            }

            private void InitializeComponent()
            {
                  this.propertyGridNPC = new PropertyGrid();
                  this.listView1 = new ListView();
                  this.columnHeader_0 = new ColumnHeader();
                  this.columnHeader_1 = new ColumnHeader();
                  base.SuspendLayout();
                  this.propertyGridNPC.Location = new Point(0x139, 0x8a);
                  this.propertyGridNPC.Margin = new Padding(2);
                  this.propertyGridNPC.Name = "propertyGridNPC";
                  this.propertyGridNPC.PropertySort = PropertySort.Categorized;
                  this.propertyGridNPC.Size = new Size(0xae, 0x40);
                  this.propertyGridNPC.TabIndex = 7;
                  ColumnHeader[] values = new ColumnHeader[] { this.columnHeader_0, this.columnHeader_1 };
                  this.listView1.Columns.AddRange(values);
                  this.listView1.Dock = DockStyle.Fill;
                  this.listView1.ForeColor = SystemColors.WindowText;
                  this.listView1.FullRowSelect = true;
                  this.listView1.GridLines = true;
                  this.listView1.Location = new Point(0, 0);
                  this.listView1.Name = "listView1";
                  this.listView1.Size = new Size(0x12e, 0x1ba);
                  this.listView1.TabIndex = 8;
                  this.listView1.UseCompatibleStateImageBehavior = false;
                  this.listView1.View = View.Details;
                  this.columnHeader_0.Text = "名称";
                  this.columnHeader_0.Width = 170;
                  this.columnHeader_1.Text = "数据";
                  this.columnHeader_1.Width = 90;
                  base.AutoScaleDimensions = new SizeF(6f, 13f);
                  base.AutoScaleMode = AutoScaleMode.Font;
                  base.ClientSize = new Size(0x12e, 0x1ba);
                  base.Controls.Add(this.listView1);
                  base.Controls.Add(this.propertyGridNPC);
                  base.Name = "UserIdList";
                  this.Text = "用户信息";
                  base.Load += new EventHandler(this.UserIdList_Load);
                  base.ResumeLayout(false);
            }

            public void method_0(string string_1, object object_0)
            {
                  string[] items = new string[2];
                  try
                  {
                        items[0] = string_1;
                        items[1] = object_0.ToString();
                        this.listView1.Items.Insert(this.listView1.Items.Count, new ListViewItem(items));
                  }
                  catch
                  {
                  }
            }

            private void UserIdList_Load(object sender, EventArgs e)
            {
                  try
                  {
                        using (IEnumerator<Players> enumerator = World.allConnectedChars.Values.GetEnumerator())
                        {
                              Players current;
                              while (enumerator.MoveNext())
                              {
                                    current = enumerator.Current;
                                    if (current.UserName == this.username)
                                    {
                                          goto Label_0039;
                                    }
                              }
                              return;
                              Label_0039:
                              this.method_0("UserId", current.Userid);
                              this.method_0("UserName", current.UserName);
                              this.method_0("Phong_ngu----------", "-------------");
                              this.method_0("FLD_Nhan_vat_co_ban_phong_ngu", current.FLD_BasicCharDefense);
                              this.method_0("FLD_Phong_ngu", current.FLD_PHONG_NGU);
                              this.method_0("FLD_Vo_cong_phong_ngu", current.FLD_Vo_cong_phong_ngu);
                              this.method_0("FLD_trang_bi_them_vao_phong_ngu", current.FLD_trang_bi_them_vao_phong_ngu);
                              this.method_0("FLD_nhan_vat_them_vao_phong_ngu", current.FLD_nhan_vat_them_vao_phong_ngu);
                              this.method_0("FLD_NHAN_VAT_KHI_CONG_PHONG_NGU", current.FLD_NHAN_VAT_KHI_CONG_PHONG_NGU);
                              this.method_0("FLD_them_vao_ti_le_phan_tram_phong_ngu", current.FLD_them_vao_ti_le_phan_tram_phong_ngu);
                              this.method_0("FLD_nhan_vat_vo_cong_suc_phong_ngu_tang_cuong_ti_le_phan_tram", current.FLD_nhan_vat_vo_cong_suc_phong_ngu_tang_cuong_ti_le_phan_tram);
                              this.method_0("FLD_trang_bi_suc_phong_ngu_vo_cong_tang_cuong_ti_le_phan_tram", current.FLD_trang_bi_suc_phong_ngu_vo_cong_tang_cuong_ti_le_phan_tram);
                              this.method_0("FLD_NHAN_VAT_KHI_CONG_LUC_PHONG_NGU_VO_CONG_TANG_CUONG_TI_LE_PHAN_TRAM", current.FLD_NHAN_VAT_KHI_CONG_LUC_PHONG_NGU_VO_CONG_TANG_CUONG_TI_LE_PHAN_TRAM);
                              this.method_0("Cong_kich----------", "-------------");
                              this.method_0("FLD_BasicCharAttack", current.FLD_BasicCharAttack);
                              this.method_0("FLD_ATTACK", current.FLD_ATTACK);
                              this.method_0("FLD_Vo_cong_cong_kich", current.FLD_Vo_cong_cong_kich);
                              this.method_0("FLD_trang_bi_them_vao_cong_kich", current.FLD_trang_bi_them_vao_cong_kich);
                              this.method_0("FLD_nhan_vat_them_vao_cong_kich", current.FLD_nhan_vat_them_vao_cong_kich);
                              this.method_0("FLD_QigqongAttack", current.FLD_QigqongAttack);
                              this.method_0("FLD_them_vao_ti_le_phan_tram_cong_kich", current.FLD_them_vao_ti_le_phan_tram_cong_kich);
                              this.method_0("FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram", current.FLD_nhan_vat_vo_cong_luc_cong_kich_tang_cuong_ti_le_phan_tram);
                              this.method_0("FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram", current.FLD_trang_bi_luc_cong_kich_vo_cong_tang_cuong_ti_le_phan_tram);
                              this.method_0("FLD_NHAN_VAT_KHI_CONG_LUC_CONG_KICH_VO_CONG_TANG_CUONG_TI_LE_PHAN_TRAM", current.FLD_NHAN_VAT_KHI_CONG_LUC_CONG_KICH_VO_CONG_TANG_CUONG_TI_LE_PHAN_TRAM);
                              this.method_0("Khac----------", "-------------");
                              this.method_0("FLD_Vo_huan_them_vao_khi_cong", current.FLD_Vo_huan_them_vao_khi_cong);
                              this.method_0("FLD_NHAN_VAT_KHI_CONG_TRUNG_MUC_TIEU", current.FLD_NHAN_VAT_KHI_CONG_TRUNG_MUC_TIEU);
                              this.method_0("FLD_NHAN_VAT_KHI_CONG_NE_TRANH", current.FLD_NHAN_VAT_KHI_CONG_NE_TRANH);
                              this.method_0("FLD_nhan_vat_them_vao_sinh_menh", current.FLD_nhan_vat_them_vao_sinh_menh);
                              this.method_0("FLD_nhan_vat_them_vao_ne_tranh", current.FLD_nhan_vat_them_vao_ne_tranh);
                              this.method_0("FLD_NHAN_VAT_CO_BAN_TRUNG_MUC_TIEU", current.FLD_NHAN_VAT_CO_BAN_TRUNG_MUC_TIEU);
                              this.method_0("FLD_NHAN_VAT_CO_BAN_NE_TRANH", current.FLD_NHAN_VAT_CO_BAN_NE_TRANH);
                              this.method_0("FLD_THAN_THE", current.FLD_THAN_THE);
                              this.method_0("FLD_SUC_MANH", current.FLD_SUC_MANH);
                              this.method_0("FLD_TRUNG_MUC_TIEU", current.FLD_TRUNG_MUC_TIEU);
                              this.method_0("FLD_NE_TRANH", current.FLD_NE_TRANH);
                              this.method_0("FLD_TIM", current.FLD_TIM);
                              this.method_0("FLD_SINH_MENH", current.FLD_SINH_MENH);
                              this.method_0("Vo_Huan_them_vao_HP", current.Vo_Huan_them_vao_HP);
                              this.method_0("Vo_Huan_them_vao_MP", current.Vo_Huan_them_vao_MP);
                              this.method_0("FLD_trang_bi_them_vao_HP", current.FLD_trang_bi_them_vao_HP);
                              this.method_0("FLD_trang_bi_them_vao_MP", current.FLD_trang_bi_them_vao_MP);
                              this.method_0("FLD_trang_bi_them_vao_trung_muc_tieu", current.FLD_trang_bi_them_vao_trung_muc_tieu);
                              this.method_0("FLD_trang_bi_them_vao_ne_tranh", current.FLD_trang_bi_them_vao_ne_tranh);
                              this.method_0("FLD_trang_bi_them_vao_vu_khi_cuong_hoa", current.FLD_trang_bi_them_vao_vu_khi_cuong_hoa);
                              this.method_0("FLD_trang_bi_them_vao_Khi_cong", current.FLD_trang_bi_them_vao_Khi_cong);
                              this.method_0("FLD_trang_bi_them_vao_Phong_cu_Cuong_hoa", current.FLD_trang_bi_them_vao_Phong_cu_Cuong_hoa);
                              this.method_0("FLD_them_vao_ti_le_phan_tram_HP_han_muc_toi_da", current.FLD_them_vao_ti_le_phan_tram_HP_han_muc_toi_da);
                              this.method_0("FLD_them_vao_ti_le_phan_tram_MP_han_muc_toi_da", current.FLD_them_vao_ti_le_phan_tram_MP_han_muc_toi_da);
                              this.method_0("FLD_them_vao_ti_le_phan_tram_sinh_menh", current.FLD_them_vao_ti_le_phan_tram_sinh_menh);
                              this.method_0("FLD_them_vao_ti_le_phan_tram_ne_tranh", current.FLD_them_vao_ti_le_phan_tram_ne_tranh);
                              this.method_0("NHAN_VAT_HP", current.NHAN_VAT_HP);
                              this.method_0("NHAN_VAT_MP", current.NHAN_VAT_MP);
                              this.method_0("NHAN_VAT_SP", current.NHAN_VAT_SP);
                              this.method_0("Nhan_vat_khi_cong_them_vao_HP", current.Nhan_vat_khi_cong_them_vao_HP);
                              this.method_0("Nhan_vat_khi_cong_them_vao_MP", current.Nhan_vat_khi_cong_them_vao_MP);
                              this.method_0("PlayerPKMode", current.PlayerPKMode);
                              this.method_0("Player_WuXun", current.Player_WuXun);
                              this.method_0("NHAN_VAT_THIEN_AC", current.NHAN_VAT_THIEN_AC);
                              this.method_0("Player_Level", current.Player_FLD_LEVEL);
                              this.method_0("NHAN_VAT_KINH_NGHIEM", current.NHAN_VAT_KINH_NGHIEM);
                              this.method_0("NHAN_VAT_LON_NHAT_KINH_NGHIEM", current.NHAN_VAT_LON_NHAT_KINH_NGHIEM);
                              this.method_0("Nhan_vat_tien_so_luong", current.Player_Money);
                              this.method_0("Nhan_vat_nghe_nghiep", current.Player_Job);
                              this.method_0("Nhan_vat_nghe_nghiep_level", current.Player_FLD_JOB_LEVEL);
                              foreach (Additional_Sate_Class class2 in current.Add_Status_List.Values)
                              {
                                    this.method_0(class2.FLD_PID.ToString(), class2.timer_0.Interval);
                              }
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "Nhan vat danh sach loi" + exception);
                  }
            }

            public string username
            {
                  get
                  {
                        return this.string_0;
                  }
                  set
                  {
                        this.string_0 = value;
                  }
            }
      }
}

