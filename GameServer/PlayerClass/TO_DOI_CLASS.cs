namespace ns1
{
      using ns13;
      using ns3;
      using System;
      using System.Collections.Generic;
      using System.Timers;

      public class TO_DOI_CLASS: IDisposable
      {
            public Players class15_0;
            public Dictionary<int, Players> dictionary_0;
            public int int_0;
            public int int_1;
            public int int_2;
            public List<Players> list_0 = new List<Players>();
            public List<Players> list_1 = new List<Players>();
            public string string_0;
            public Timer timer_0 = new Timer(2000.0);

            public TO_DOI_CLASS(Players DOI_TRUONG_)
            {
                  this.timer_0.Elapsed += new ElapsedEventHandler(this.timer_0_Elapsed);
                  this.timer_0.AutoReset = true;
                  this.string_0 = DOI_TRUONG_.UserName;
                  this.dictionary_0 = new Dictionary<int, Players>();
                  this.dictionary_0.Add(DOI_TRUONG_.UserSessionID, DOI_TRUONG_);
                  this.list_1.Add(DOI_TRUONG_);
                  this.int_1 = 0;
                  this.int_2 = 1;
            }

            public void Dispose()
            {
                  try
                  {
                        foreach (Players local1 in this.dictionary_0.Values)
                        {
                              local1.GIAI_TAN_TO_DOI_NHAC_NHO();
                              local1.TO_DOI_ID = 0;
                              local1.bool_12 = false;
                              local1.int_7 = 0;
                        }
                        this.dictionary_0.Clear();
                        this.list_1.Clear();
                        World.W_TO_DOI.Remove(this.int_0);
                        if (this.timer_0 != null)
                        {
                              this.timer_0.Enabled = false;
                              this.timer_0.Close();
                              this.timer_0.Dispose();
                              this.timer_0 = null;
                        }
                        this.class15_0 = null;
                        this.list_0 = null;
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "组队类 Dispose 出错!" + exception.Message);
                  }
                  finally
                  {
                        this.list_0 = null;
                        this.list_1 = null;
                        this.dictionary_0 = null;
                        World.W_TO_DOI.Remove(this.int_0);
                  }
            }

            ~TO_DOI_CLASS()
            {
            }

            public void method_0()
            {
                  if (this.dictionary_0 != null)
                  {
                        foreach (Players local1 in this.dictionary_0.Values)
                        {
                              local1.GIAI_TAN_TO_DOI_NHAC_NHO();
                              local1.TO_DOI_ID = 0;
                              local1.bool_12 = false;
                        }
                        this.dictionary_0.Clear();
                  }
                  World.W_TO_DOI.Remove(this.int_0);
                  if (this.timer_0 != null)
                  {
                        this.timer_0.Enabled = false;
                        this.timer_0.Close();
                        this.timer_0.Dispose();
                        this.timer_0 = null;
                  }
                  this.class15_0 = null;
                  this.list_0 = null;
            }

            public void method_1(Players class15_1, Players class15_2)
            {
                  try
                  {
                        this.string_0 = class15_2.UserName;
                        foreach (Players local1 in this.dictionary_0.Values)
                        {
                              local1.BO_NHIEM_DOI_TRUONG_NHAC_NHO(class15_1, class15_2);
                              local1.HIEN_THI_THANH_VIEN_PARTY();
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "组队类 委任队长 出错!" + exception.Message);
                  }
            }

            public void method_2(Players class15_1)
            {
                  try
                  {
                        if (class15_1.FLD_TINH_NHAN != "")
                        {
                              using (Dictionary<int, Players>.ValueCollection.Enumerator enumerator = this.dictionary_0.Values.GetEnumerator())
                              {
                                    Players current;
                                    while (enumerator.MoveNext())
                                    {
                                          current = enumerator.Current;
                                          if (current.UserName == class15_1.FLD_TINH_NHAN)
                                          {
                                                goto Label_004B;
                                          }
                                    }
                                    goto Label_0069;
                                    Label_004B:
                                    class15_1.bool_12 = true;
                                    current.bool_12 = true;
                              }
                        }
                        Label_0069:
                        foreach (Players players2 in this.dictionary_0.Values)
                        {
                              if (class15_1 != players2)
                              {
                                    players2.GIA_NHAP_TO_DOI_NHAC_NHO(class15_1);
                                    class15_1.GIA_NHAP_TO_DOI_NHAC_NHO(players2);
                              }
                              players2.HIEN_THI_THANH_VIEN_PARTY();
                        }
                        if (this.dictionary_0.Count >= 2)
                        {
                              this.timer_0.Enabled = true;
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "组队类 加入队员提示 出错!" + exception.Message);
                  }
            }

            public void method_3(Players class15_1)
            {
                  try
                  {
                        this.dictionary_0.Remove(class15_1.UserSessionID);
                        this.list_1.Remove(class15_1);
                        if (class15_1.FLD_TINH_NHAN != "")
                        {
                              class15_1.bool_12 = false;
                              using (Dictionary<int, Players>.ValueCollection.Enumerator enumerator = this.dictionary_0.Values.GetEnumerator())
                              {
                                    Players current;
                                    while (enumerator.MoveNext())
                                    {
                                          current = enumerator.Current;
                                          if (current.UserName == class15_1.FLD_TINH_NHAN)
                                          {
                                                goto Label_0071;
                                          }
                                    }
                                    goto Label_0088;
                                    Label_0071:
                                    current.bool_12 = false;
                              }
                        }
                        Label_0088:
                        if (this.dictionary_0.Count >= 2)
                        {
                              if (this.string_0 != class15_1.UserName)
                              {
                                    foreach (Players local1 in this.dictionary_0.Values)
                                    {
                                          local1.THOAT_KHOI_TO_DOI_NHAC_NHO(class15_1);
                                          local1.HIEN_THI_THANH_VIEN_PARTY();
                                    }
                              }
                              else
                              {
                                    bool flag = true;
                                    foreach (Players players2 in this.dictionary_0.Values)
                                    {
                                          if (flag)
                                          {
                                                this.string_0 = players2.UserName;
                                                players2.BO_NHIEM_DOI_TRUONG_NHAC_NHO(class15_1, players2);
                                                flag = false;
                                          }
                                          players2.THOAT_KHOI_TO_DOI_NHAC_NHO(class15_1);
                                          players2.HIEN_THI_THANH_VIEN_PARTY();
                                    }
                              }
                        }
                        else
                        {
                              this.Dispose();
                        }
                        class15_1.TOI_ROI_KHOI_TO_DOI_NHAC_NHO();
                        class15_1.TO_DOI_ID = 0;
                        class15_1.int_7 = 0;
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "组队类 退出 出错!" + exception.Message);
                  }
            }

            private void timer_0_Elapsed(object sender, ElapsedEventArgs e)
            {
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "组队Class-自动显示事件");
                  }
                  try
                  {
                        if (this.dictionary_0.Count <= 1)
                        {
                              this.Dispose();
                        }
                        else
                        {
                              foreach (Players players in this.dictionary_0.Values)
                              {
                                    if (World.allConnectedChars.ContainsKey(players.UserSessionID))
                                    {
                                          players.HIEN_THI_THANH_VIEN_PARTY();
                                    }
                                    else
                                    {
                                          this.list_0.Add(players);
                                    }
                              }
                              foreach (Players players2 in this.list_0)
                              {
                                    this.dictionary_0.Remove(players2.UserSessionID);
                              }
                              if (this.list_0.Count > 0)
                              {
                                    this.list_0.Clear();
                              }
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "组队类 自动显示事件 出错!" + exception.Message);
                  }
            }
      }
}

