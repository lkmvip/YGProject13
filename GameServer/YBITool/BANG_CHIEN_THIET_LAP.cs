namespace ns3
{
      using ns0;
      using ns12;
      using ns13;
      using ns9;
      using System;
      using System.Collections.Generic;
      using System.Timers;

      internal class BANG_CHIEN_THIET_LAP
      {
            public BANG_CHIEN_STRING class47_0;
            public BANG_CHIEN_STRING class47_1;
            private DateTime dateTime_0;
            private DateTime dateTime_1;
            public int int_0;
            public int int_1;
            public int int_2;
            public int int_3;
            private object object_0 = new object();
            private Timer timer_0;
            private Timer timer_1;

            public BANG_CHIEN_THIET_LAP(BANG_CHIEN_STRING SQUARE, BANG_CHIEN_STRING Passenger)
            {
                  try
                  {
                        Lock @lock;
                        Dictionary<int, Players>.ValueCollection.Enumerator enumerator;
                        this.class47_0 = SQUARE;
                        this.class47_1 = Passenger;
                        this.int_0 = 0;
                        this.int_1 = 0;
                        this.int_2 = 0;
                        using (@lock = new Lock(this.class47_0.dictionary_0, "帮战客方.申请人物列表"))
                        {
                              using (enumerator = this.class47_0.dictionary_0.Values.GetEnumerator())
                              {
                                    while (enumerator.MoveNext())
                                    {
                                          enumerator.Current.BANG_CHIEN_GHEP_DOI_THANH_CONG_THONG_BAO(0);
                                    }
                              }
                        }
                        using (@lock = new Lock(this.class47_1.dictionary_0, "帮战客方.申请人物列表"))
                        {
                              using (enumerator = this.class47_1.dictionary_0.Values.GetEnumerator())
                              {
                                    while (enumerator.MoveNext())
                                    {
                                          enumerator.Current.BANG_CHIEN_GHEP_DOI_THANH_CONG_THONG_BAO(0);
                                    }
                              }
                        }
                        this.dateTime_0 = DateTime.Now.AddMinutes(1.0);
                        this.timer_0 = new Timer(60000.0);
                        this.timer_0.Elapsed += new ElapsedEventHandler(this.timer_0_Elapsed);
                        this.timer_0.Enabled = true;
                        this.timer_0.AutoReset = true;
                        this.timer_0_Elapsed(null, null);
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "Blood gang war Prepare timer end event error：" + exception);
                  }
            }

            public void method_0()
            {
                  if (this.int_3 != 1)
                  {
                        try
                        {
                              object[] objArray1;
                              Lock @lock;
                              char[] separator = new char[] { ';' };
                              string[] strArray = World.To_help_fight_winning_gold_ingot_number.Split(separator);
                              char[] chArray2 = new char[] { ';' };
                              string[] strArray2 = World.Number_of_points_gold_coins_to_help_draw.Split(chArray2);
                              if (this.int_0 > this.int_1)
                              {
                                    using (@lock = new Lock(this.class47_0.dictionary_0, "帮战客方.申请人物列表"))
                                    {
                                          foreach (Players players in this.class47_0.dictionary_0.Values)
                                          {
                                                if (players.Bang_phai_nhan_vat_thu_bac == 6)
                                                {
                                                      players.KIEM_TRA_BACH_BAO_CAC_NGUYEN_BAO_SO_LUONG();
                                                      players.KIEM_SOAT_CASH_SO_LIEU(Convert.ToInt32(strArray[0]), 1);
                                                      players.Player_Money += Convert.ToInt32(strArray[1]);
                                                      RxjhClass.DELETE_BANG_CHIEN_DAT_CUOC_DATA(players.Userid, players.UserName, this.class47_0.int_0, 1);
                                                      players.UPDATE_RXPIONT();
                                                      players.UpdateMoneyAndWeight();
                                                }
                                                if (this.int_2 == 1)
                                                {
                                                      players.LOI_KHUYEN_CHIEN_TRANH_BAT_DAU(13, 1);
                                                }
                                                else if (this.int_2 == 2)
                                                {
                                                      players.GameMessage("The main fact one of them quit map, to help combat the forced end.", 9, "System");
                                                }
                                                players.LOI_KHUYEN_CHIEN_TRANH_BAT_DAU(12, 3);
                                                players.Move(0f, 0f, 15f, 0x4b1);
                                          }
                                    }
                                    using (@lock = new Lock(this.class47_1.dictionary_0, "帮战客方.申请人物列表"))
                                    {
                                          foreach (Players players2 in this.class47_1.dictionary_0.Values)
                                          {
                                                if (players2.Bang_phai_nhan_vat_thu_bac == 6)
                                                {
                                                      RxjhClass.DELETE_BANG_CHIEN_DAT_CUOC_DATA(players2.Userid, players2.UserName, this.class47_1.int_0, -1);
                                                }
                                                if (this.int_2 == 1)
                                                {
                                                      players2.LOI_KHUYEN_CHIEN_TRANH_BAT_DAU(13, -1);
                                                }
                                                else if (this.int_2 == 2)
                                                {
                                                      players2.GameMessage("The main fact one of them quit map, to help combat the forced end.", 9, "System");
                                                }
                                                players2.LOI_KHUYEN_CHIEN_TRANH_BAT_DAU(12, 3);
                                                players2.Move(0f, 0f, 15f, 0x4b1);
                                          }
                                          goto Label_06A7;
                                    }
                              }
                              if (this.int_1 > this.int_0)
                              {
                                    using (@lock = new Lock(this.class47_0.dictionary_0, "帮战客方.申请人物列表"))
                                    {
                                          foreach (Players players3 in this.class47_0.dictionary_0.Values)
                                          {
                                                if (players3.Bang_phai_nhan_vat_thu_bac == 6)
                                                {
                                                      RxjhClass.DELETE_BANG_CHIEN_DAT_CUOC_DATA(players3.Userid, players3.UserName, this.class47_0.int_0, -1);
                                                }
                                                if (this.int_2 == 1)
                                                {
                                                      players3.LOI_KHUYEN_CHIEN_TRANH_BAT_DAU(13, -1);
                                                }
                                                else if (this.int_2 == 2)
                                                {
                                                      players3.GameMessage("The main fact one of them quit map, to help combat the forced end.", 9, "System");
                                                }
                                                players3.LOI_KHUYEN_CHIEN_TRANH_BAT_DAU(12, 3);
                                                players3.Move(0f, 0f, 15f, 0x4b1);
                                          }
                                    }
                                    using (@lock = new Lock(this.class47_1.dictionary_0, "帮战客方.申请人物列表"))
                                    {
                                          foreach (Players players4 in this.class47_1.dictionary_0.Values)
                                          {
                                                if (players4.Bang_phai_nhan_vat_thu_bac == 6)
                                                {
                                                      players4.KIEM_TRA_BACH_BAO_CAC_NGUYEN_BAO_SO_LUONG();
                                                      players4.KIEM_SOAT_CASH_SO_LIEU(Convert.ToInt32(strArray[0]), 1);
                                                      players4.Player_Money += Convert.ToInt32(strArray[1]);
                                                      RxjhClass.DELETE_BANG_CHIEN_DAT_CUOC_DATA(players4.Userid, players4.UserName, this.class47_1.int_0, 1);
                                                      players4.UPDATE_RXPIONT();
                                                      players4.UpdateMoneyAndWeight();
                                                }
                                                if (this.int_2 == 1)
                                                {
                                                      players4.LOI_KHUYEN_CHIEN_TRANH_BAT_DAU(13, 1);
                                                }
                                                else if (this.int_2 == 2)
                                                {
                                                      players4.GameMessage("The main fact one of them quit map, to help combat the forced end.", 9, "System");
                                                }
                                                players4.LOI_KHUYEN_CHIEN_TRANH_BAT_DAU(12, 3);
                                                players4.Move(0f, 0f, 15f, 0x4b1);
                                          }
                                          goto Label_06A7;
                                    }
                              }
                              if (this.int_1 == this.int_0)
                              {
                                    using (@lock = new Lock(this.class47_0.dictionary_0, "帮战客方.申请人物列表"))
                                    {
                                          foreach (Players players5 in this.class47_0.dictionary_0.Values)
                                          {
                                                if (players5.Bang_phai_nhan_vat_thu_bac == 6)
                                                {
                                                      players5.KIEM_TRA_BACH_BAO_CAC_NGUYEN_BAO_SO_LUONG();
                                                      players5.KIEM_SOAT_CASH_SO_LIEU(Convert.ToInt32(strArray2[0]), 1);
                                                      players5.Player_Money += Convert.ToInt32(strArray2[1]);
                                                      RxjhClass.DELETE_BANG_CHIEN_DAT_CUOC_DATA(players5.Userid, players5.UserName, this.class47_0.int_0, 0);
                                                      players5.UPDATE_RXPIONT();
                                                      players5.UpdateMoneyAndWeight();
                                                }
                                                if (this.int_2 == 1)
                                                {
                                                      players5.LOI_KHUYEN_CHIEN_TRANH_BAT_DAU(13, 0);
                                                }
                                                else if (this.int_2 == 2)
                                                {
                                                      players5.GameMessage("The main fact one of them quit map, to help combat the forced end.", 9, "System");
                                                }
                                                players5.LOI_KHUYEN_CHIEN_TRANH_BAT_DAU(12, 3);
                                                players5.Move(0f, 0f, 15f, 0x4b1);
                                          }
                                    }
                                    using (@lock = new Lock(this.class47_1.dictionary_0, "帮战客方.申请人物列表"))
                                    {
                                          foreach (Players players6 in this.class47_1.dictionary_0.Values)
                                          {
                                                if (players6.Bang_phai_nhan_vat_thu_bac == 6)
                                                {
                                                      players6.KIEM_TRA_BACH_BAO_CAC_NGUYEN_BAO_SO_LUONG();
                                                      players6.KIEM_SOAT_CASH_SO_LIEU(Convert.ToInt32(strArray2[0]), 1);
                                                      players6.Player_Money += Convert.ToInt32(strArray2[1]);
                                                      RxjhClass.DELETE_BANG_CHIEN_DAT_CUOC_DATA(players6.Userid, players6.UserName, this.class47_1.int_0, 0);
                                                      players6.UPDATE_RXPIONT();
                                                      players6.UpdateMoneyAndWeight();
                                                }
                                                if (this.int_2 == 1)
                                                {
                                                      players6.LOI_KHUYEN_CHIEN_TRANH_BAT_DAU(13, 0);
                                                }
                                                else if (this.int_2 == 2)
                                                {
                                                      players6.GameMessage("The main fact one of them quit map, to help combat the forced end.", 9, "System");
                                                }
                                                players6.LOI_KHUYEN_CHIEN_TRANH_BAT_DAU(12, 3);
                                                players6.Move(0f, 0f, 15f, 0x4b1);
                                          }
                                    }
                              }
                              Label_06A7:
                              objArray1 = new object[] {
                        "End gang war mapID:7101 EndID:", this.int_2, " Main gangID:", this.class47_0.int_0, " Main gang name:", this.class47_0.string_0, " Main fact:", this.class47_0.string_1, " Number of people:", this.class47_0.dictionary_0.Count, " fraction:", this.int_0, " ---- Off gangsID:", this.class47_1.int_0, " Off gang name:", this.class47_1.string_0,
                        " Main fact:", this.class47_1.string_1, " Number of people:", this.class47_1.dictionary_0.Count, " fraction:", this.int_1
                    };
                              Form1.WriteLine(0x58, string.Concat(objArray1));
                              this.int_3 = 1;
                              if (this.timer_0 != null)
                              {
                                    this.timer_0.Enabled = false;
                                    this.timer_0.Close();
                                    this.timer_0.Dispose();
                              }
                              if (this.timer_1 != null)
                              {
                                    this.timer_1.Enabled = false;
                                    this.timer_1.Close();
                                    this.timer_1.Dispose();
                              }
                              if (this.class47_0 != null)
                              {
                                    if (this.class47_0.dictionary_0 != null)
                                    {
                                          this.class47_0.dictionary_0.Clear();
                                          this.class47_0.dictionary_0 = null;
                                    }
                                    this.class47_0 = null;
                              }
                              if (this.class47_1 != null)
                              {
                                    if (this.class47_1.dictionary_0 != null)
                                    {
                                          this.class47_1.dictionary_0.Clear();
                                          this.class47_1.dictionary_0 = null;
                                    }
                                    this.class47_1 = null;
                              }
                              World.class11_0 = null;
                              this.int_3 = 1;
                        }
                        catch (Exception exception)
                        {
                              Form1.WriteLine(1, "Blood gang war Dispose() Error：" + exception);
                        }
                  }
            }

            public void timer_0_Elapsed(object sender, ElapsedEventArgs e)
            {
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "Prepare timer end event");
                  }
                  try
                  {
                        Lock @lock;
                        Dictionary<int, Players>.ValueCollection.Enumerator enumerator;
                        TimeSpan span = this.dateTime_0.Subtract(DateTime.Now);
                        int totalSeconds = (int)span.TotalSeconds;
                        using (@lock = new Lock(this.class47_0.dictionary_0, "帮战客方.申请人物列表"))
                        {
                              using (enumerator = this.class47_0.dictionary_0.Values.GetEnumerator())
                              {
                                    while (enumerator.MoveNext())
                                    {
                                          enumerator.Current.BANG_CHIEN_THONG_BAO_SAN_SANG(span.Minutes.ToString());
                                    }
                              }
                        }
                        using (@lock = new Lock(this.class47_1.dictionary_0, "帮战客方.申请人物列表"))
                        {
                              using (enumerator = this.class47_1.dictionary_0.Values.GetEnumerator())
                              {
                                    while (enumerator.MoveNext())
                                    {
                                          enumerator.Current.BANG_CHIEN_THONG_BAO_SAN_SANG(span.Minutes.ToString());
                                    }
                              }
                        }
                        if (totalSeconds <= 0)
                        {
                              this.timer_0.Enabled = false;
                              this.timer_0.Close();
                              this.timer_0.Dispose();
                              this.dateTime_1 = DateTime.Now.AddMinutes((double)World.Bang_chien_thoi_gian_chien_dau);
                              this.timer_1 = new Timer(1000.0);
                              this.timer_1.Elapsed += new ElapsedEventHandler(this.timer_1_Elapsed);
                              this.timer_1.Enabled = true;
                              this.timer_1.AutoReset = true;
                              using (@lock = new Lock(this.class47_0.dictionary_0, "帮战客方.申请人物列表"))
                              {
                                    foreach (Players local1 in this.class47_0.dictionary_0.Values)
                                    {
                                          local1.Move(787f, -787f, 15f, 0x1bbd);
                                          local1.LOI_KHUYEN_CHIEN_TRANH_BAT_DAU(0, 0);
                                    }
                              }
                              using (@lock = new Lock(this.class47_1.dictionary_0, "帮战客方.申请人物列表"))
                              {
                                    foreach (Players local2 in this.class47_1.dictionary_0.Values)
                                    {
                                          local2.Move(-787f, 787f, 15f, 0x1bbd);
                                          local2.LOI_KHUYEN_CHIEN_TRANH_BAT_DAU(0, 0);
                                    }
                              }
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "Blood gang war Prepare timer end event Error：" + exception);
                  }
            }

            public void timer_1_Elapsed(object sender, ElapsedEventArgs e)
            {
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "Wars began to end when the event");
                  }
                  try
                  {
                        Lock @lock;
                        int num = 0;
                        int num2 = 0;
                        using (@lock = new Lock(this.class47_0.dictionary_0, "帮战客方.申请人物列表"))
                        {
                              foreach (Players local1 in this.class47_0.dictionary_0.Values)
                              {
                                    if (local1.int_12 == 1)
                                    {
                                          num++;
                                    }
                                    local1.BANG_CHIEN_CAP_NHAT_DIEM_SO(this.int_0, this.int_1);
                              }
                        }
                        using (@lock = new Lock(this.class47_1.dictionary_0, "帮战客方.申请人物列表"))
                        {
                              foreach (Players local2 in this.class47_1.dictionary_0.Values)
                              {
                                    if (local2.int_12 == 1)
                                    {
                                          num2++;
                                    }
                                    local2.BANG_CHIEN_CAP_NHAT_DIEM_SO(this.int_0, this.int_1);
                              }
                        }
                        if (((int)this.dateTime_1.Subtract(DateTime.Now).TotalSeconds) <= 0)
                        {
                              this.int_2 = 1;
                              this.timer_1.Enabled = false;
                              this.timer_1.Close();
                              this.timer_1.Dispose();
                              this.method_0();
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "Blood gang war Wars began to end when the event Error：" + exception);
                  }
            }
      }
}

