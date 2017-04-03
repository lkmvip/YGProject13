namespace ns13
{
      using LuaInterface;
      using ns1;
      using ns10;
      using ns12;
      using ns2;
      using ns3;
      using ns4;
      using ns5;
      using ns6;
      using ns7;
      using ns8;
      using ns9;
      using RxjhServer;
      using System;
      using System.Collections;
      using System.Collections.Generic;
      using System.Timers;

      public class TBL_XWWL_NPC: IDisposable
      {
            private ArrayList arrayList_0 = new ArrayList();
            private bool bool_0;
            private bool bool_1;
            public Reverser<PlayGjClass> class106_0 = new Reverser<PlayGjClass>(class152_0.GetType(), "Gjsl", Struct10.Enum1.const_1);
            private static PlayGjClass class152_0;
            private Dictionary<int, TBL_XWWL_NPC> dictionary_0 = new Dictionary<int, TBL_XWWL_NPC>();
            private double double_0;
            private double double_1;
            private float float_0;
            private float float_1;
            private float float_2;
            private float float_3;
            private float float_4;
            private float float_5;
            private float float_6;
            private float float_7;
            private int int_0;
            private int int_1;
            private int int_2;
            private int int_3;
            private int int_4;
            private int int_5;
            private int int_6;
            private int int_7;
            private int int_8;
            private List<PlayGjClass> list_0 = new List<PlayGjClass>();
            private long long_0;
            private long long_1;
            private object object_0 = new object();
            private object object_1 = new object();
            private object object_2 = new object();
            private object object_3 = new object();
            public static object object_4;
            private Random random_0 = new Random();
            public static Random random_1;
            private Random random_2 = new Random(DateTime.Now.Millisecond);
            private string string_0;
            private ThreadSafeDictionary<int, Players> threadSafeDictionary_0 = new ThreadSafeDictionary<int, Players>();
            public ThreadSafeDictionary<int, DI_THUONG_TRANG_THAI_NEW> threadSafeDictionary_1;
            public Timer timer_0;
            public Timer timer_1;
            public Timer timer_2;

            private bool QuestItemBool = false; 
            static TBL_XWWL_NPC()
            {
                  ZYDNGuard();
            }

            public TBL_XWWL_NPC()
            {
                  double interval = random_1.Next(0xbb8, 0x3a98);
                  this.timer_0 = new Timer(interval);
                  this.timer_0.Elapsed += new ElapsedEventHandler(this.timer_0_Elapsed);
                  this.timer_0.AutoReset = true;
                  this.timer_0.Enabled = true;
                  this.timer_1 = new Timer(1000.0);
                  this.timer_1.Elapsed += new ElapsedEventHandler(this.timer_1_Elapsed);
                  this.timer_1.AutoReset = true;
                  this.threadSafeDictionary_1 = new ThreadSafeDictionary<int, DI_THUONG_TRANG_THAI_NEW>();
            }

            public void Dispose()
            {
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "NpcClass_Dispose");
                  }
                  try
                  {
                        MapClass.smethod_3(this.Rxjh_Map, this.FLD_INDEX);
                        if (this.timer_1 != null)
                        {
                              this.timer_1.Enabled = false;
                              this.timer_1.Close();
                              this.timer_1.Dispose();
                        }
                        if (this.timer_0 != null)
                        {
                              this.timer_0.Enabled = false;
                              this.timer_0.Close();
                              this.timer_0.Dispose();
                        }
                        if (this.timer_2 != null)
                        {
                              this.timer_2.Enabled = false;
                              this.timer_2.Close();
                              this.timer_2.Dispose();
                              this.timer_2 = null;
                        }
                        this.method_4();
                        this.method_6();
                        this.dictionary_0.Clear();
                        this.arrayList_0.Clear();
                        if (this.threadSafeDictionary_0 != null)
                        {
                              this.threadSafeDictionary_0.Dispose();
                              this.threadSafeDictionary_0 = null;
                        }
                        if (this.dictionary_0 != null)
                        {
                              this.dictionary_0 = null;
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "NPC 关闭数据Dispose() 出错：" + exception);
                  }
            }

            ~TBL_XWWL_NPC()
            {
            }

            public void method_0(Players class15_0)
            {
                  try
                  {
                        if ((this.threadSafeDictionary_0 != null) && !this.threadSafeDictionary_0.ContainsKey(class15_0.UserSessionID))
                        {
                              this.threadSafeDictionary_0.Add(class15_0.UserSessionID, class15_0);
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(100, "PlayList_Add 出错：" + exception);
                  }
            }

            public void method_1(Players class15_0)
            {
                  try
                  {
                        if ((this.threadSafeDictionary_0 != null) && this.threadSafeDictionary_0.ContainsKey(class15_0.UserSessionID))
                        {
                              this.threadSafeDictionary_0.Remove(class15_0.UserSessionID);
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(100, "PlayList_Remove 出错：" + exception);
                  }
            }

            public int method_10()
            {
                  int num = this.Level * World.Ky_nang_boi_so;
                  int num2 = num / 3;
                  return this.random_2.Next(num - num2, num + num2);
            }

            public int method_11()
            {
                  int num = (int)(this.Rxjh_Exp * World.Thang_thien_kinh_nghiem_boi_so);
                  int num2 = num / 3;
                  return this.random_2.Next(num - num2, num + num2);
            }

            public List<TBL_XWWL_NPC> method_12(int int_9)
            {
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "NpcClass_群攻查找范围Npc2");
                  }
                  try
                  {
                        List<TBL_XWWL_NPC> list = new List<TBL_XWWL_NPC>();
                        int num = 0;
                        foreach (TBL_XWWL_NPC tbl_xwwl_npc in MapClass.GetnpcTemplate(this.Rxjh_Map).Values)
                        {
                              if ((!tbl_xwwl_npc.NPC_TU_VONG && (tbl_xwwl_npc.IsNpc == 0)) && (this.method_32(0x19, tbl_xwwl_npc) && (tbl_xwwl_npc.int_1 != this.int_1)))
                              {
                                    list.Add(tbl_xwwl_npc);
                                    if (num >= int_9)
                                    {
                                          break;
                                    }
                                    num++;
                              }
                        }
                        return list;
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "群攻查找范围Npc 出错：" + exception);
                        return null;
                  }
            }

            public void method_13()
            {
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "NpcClass_群攻查找范围Npc");
                  }
                  try
                  {
                        this.dictionary_0.Clear();
                        int num = 0;
                        foreach (TBL_XWWL_NPC tbl_xwwl_npc in MapClass.GetnpcTemplate(this.Rxjh_Map).Values)
                        {
                              if ((!tbl_xwwl_npc.NPC_TU_VONG && (tbl_xwwl_npc.IsNpc == 0)) && this.method_32(0x19, tbl_xwwl_npc))
                              {
                                    this.dictionary_0.Add(tbl_xwwl_npc.FLD_INDEX, tbl_xwwl_npc);
                                    if (num > 4)
                                    {
                                          return;
                                    }
                                    num++;
                              }
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "群攻查找范围Npc 出错：" + exception);
                  }
            }

            public void method_14(Players class15_0)
            {
                  using (PacketData data = new PacketData())
                  {
                        data.Write4(1);
                        data.Write2(this.FLD_INDEX);
                        data.Write2(this.FLD_INDEX);
                        data.Write2(this.FLD_PID);
                        data.Write4(1);
                        data.Write4((int)this.Rxjh_HP);
                        data.Write4((int)this.Max_Rxjh_HP);
                        data.method_1(this.Rxjh_X);
                        data.method_1(this.Rxjh_Z);
                        data.method_1(this.Rxjh_Y);
                        data.Write4(0x40800000);
                        data.method_1(this.FLD_FACE1);
                        data.method_1(this.FLD_FACE2);
                        data.method_1(this.Rxjh_X);
                        data.method_1(this.Rxjh_Z);
                        data.method_1(this.Rxjh_Y);
                        data.Write4(0);
                        data.Write4(0);
                        data.Write4(12);
                        data.Write4(0);
                        if (class15_0.Client != null)
                        {
                              class15_0.Client.method_5(data, 0x6800, class15_0.UserSessionID, 0);
                        }
                  }
            }

            private void method_15()
            {
                  try
                  {
                        this.NPC_TU_VONG = false;
                        if (this.timer_2 != null)
                        {
                              this.timer_2.Enabled = false;
                              this.timer_2.Close();
                              this.timer_2.Dispose();
                              this.timer_2 = null;
                        }
                        this.Rxjh_HP = this.Max_Rxjh_HP;
                        if ((this.int_2 != 0x3bf5) && (this.int_2 != 0x3bf6))
                        {
                              if ((this.int_2 != 0x3b11) && (this.int_2 != 0x3b12))
                              {
                                    Random random1 = new Random();
                                    int num = random1.Next(0, 2);
                                    double num2 = random1.NextDouble() * 50.0;
                                    double num3 = random1.NextDouble() * 50.0;
                                    if (num == 0)
                                    {
                                          this.Rxjh_X = this.Rxjh_cs_X + ((float)num2);
                                          this.Rxjh_Y = this.Rxjh_cs_Y + ((float)num3);
                                    }
                                    else
                                    {
                                          this.Rxjh_X = this.Rxjh_cs_X - ((float)num2);
                                          this.Rxjh_Y = this.Rxjh_cs_Y - ((float)num3);
                                    }
                              }
                              else
                              {
                                    this.Rxjh_X = this.Rxjh_cs_X;
                                    this.Rxjh_Y = this.Rxjh_cs_Y;
                              }
                        }
                        else
                        {
                              this.Rxjh_X = this.Rxjh_cs_X;
                              this.Rxjh_Y = this.Rxjh_cs_Y;
                        }
                        this.Rxjh_Z = this.Rxjh_cs_Z;
                        using (PacketData data = new PacketData())
                        {
                              data.Write4(1);
                              data.Write2(this.FLD_INDEX);
                              data.Write2(this.FLD_INDEX);
                              data.Write2(this.FLD_PID);
                              data.Write4(1);
                              data.Write4((int)this.Rxjh_HP);
                              data.Write4((int)this.Max_Rxjh_HP);
                              data.method_1(this.Rxjh_X);
                              data.method_1(this.Rxjh_Z);
                              data.method_1(this.Rxjh_Y);
                              data.Write4(0);
                              data.method_1(this.FLD_FACE1);
                              data.method_1(this.FLD_FACE2);
                              data.method_1(this.Rxjh_X);
                              data.method_1(this.Rxjh_Z);
                              data.method_1(this.Rxjh_Y);
                              data.Write4(0);
                              data.Write4(0);
                              data.Write4(0);
                              this.method_21(data, 0x7b00, this.FLD_INDEX);
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, string.Concat(new object[] { "更新NPC复活数据 出错", this.FLD_PID, "|", this.Name, " ", exception.Message }));
                  }
            }

            private void method_16(Players class15_0)
            {
                  using (PacketData data = new PacketData())
                  {
                        if (class15_0.Client != null)
                        {
                              class15_0.Client.method_5(data, 0x8800, this.FLD_INDEX, 0);
                        }
                  }
            }

            public void method_17()
            {
                  try
                  {
                        if (!this.NPC_TU_VONG)
                        {
                              this.NPC_TU_VONG = true;
                              if (this.bool_1)
                              {
                                    this.method_4();
                                    this.method_18();
                                    this.Dispose();
                              }
                              else
                              {
                                    this.timer_1.Enabled = false;
                                    this.timer_0.Enabled = false;
                                    if (this.timer_2 != null)
                                    {
                                          this.timer_2.Interval = this.FLD_NEWTIME * 0x3e8;
                                          this.timer_2.Enabled = true;
                                    }
                                    else
                                    {
                                          this.timer_2 = new Timer((double)(this.FLD_NEWTIME * 0x3e8));
                                          this.timer_2.Elapsed += new ElapsedEventHandler(this.timer_2_Elapsed);
                                          this.timer_2.Enabled = true;
                                    }
                              }
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, string.Concat(new object[] { "更新死亡数据 出错", this.FLD_PID, "|", this.Name, " ", exception.Message }));
                  }
            }

            private void method_18()
            {
                  using (PacketData data = new PacketData())
                  {
                        this.method_21(data, 0x8800, this.FLD_INDEX);
                  }
            }

            public void method_19(float float_8, float float_9, int int_9, int int_10)
            {
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "NpcClass_发送移动数据");
                  }
                  try
                  {
                        using (PacketData data = new PacketData())
                        {
                              Random random1 = new Random();
                              int num = random1.Next(0, 2);
                              double num2 = random1.NextDouble() * int_9;
                              double num3 = random1.NextDouble() * int_9;
                              if (num == 0)
                              {
                                    this.Rxjh_X = float_8 + ((float)num2);
                                    this.Rxjh_Y = float_9 + ((float)num3);
                              }
                              else
                              {
                                    this.Rxjh_X = float_8 - ((float)num2);
                                    this.Rxjh_Y = float_9 - ((float)num3);
                              }
                              data.method_1(this.Rxjh_X);
                              data.method_1(this.Rxjh_Y);
                              data.method_1(this.Rxjh_Z);
                              data.Write4(-1);
                              data.Write4(int_10);
                              data.method_1((float)num2);
                              data.Write4((int)this.Rxjh_HP);
                              this.method_21(data, 0x7400, this.FLD_INDEX);
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, string.Concat(new object[] { "发送移动数据 出错", this.FLD_PID, "|", this.Name, " ", exception.Message }));
                  }
            }

            public bool method_2(Players class15_0) =>
                this.threadSafeDictionary_0.ContainsKey(class15_0.UserSessionID);

            public void method_20(int int_9, int int_10, int int_11)
            {
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "NpcClass_发送攻击数据");
                  }
                  try
                  {
                        using (PacketData data = new PacketData())
                        {
                              data.Write2(int_11);
                              data.Write4(1);
                              data.Write2(0);
                              data.Write4(int_9);
                              data.Write4(0);
                              data.Write4(0);
                              data.Write4(0);
                              data.Write4(0);
                              data.Write4(0);
                              data.Write4(int_10);
                              data.method_1(this.Rxjh_X);
                              data.method_1(15f);
                              data.method_1(this.Rxjh_Y);
                              data.method_2(0);
                              data.method_2(1);
                              data.Write2(0);
                              data.Write4(0);
                              data.Write4(0);
                              data.Write4(0);
                              data.Write4(0);
                              data.Write4(0);
                              data.Write4(0);
                              data.Write4(-1);
                              data.Write4(0);
                              this.method_21(data, 0xc00, this.FLD_INDEX);
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, string.Concat(new object[] { "发送攻击数据 出错", this.FLD_PID, "|", this.Name, " ", exception }));
                  }
            }

            public void method_21(PacketData class143_0, int int_9, int int_10)
            {
                  try
                  {
                        if (this.threadSafeDictionary_0 != null)
                        {
                              Queue queue = Queue.Synchronized(new Queue());
                              foreach (Players players in this.threadSafeDictionary_0.Values)
                              {
                                    queue.Enqueue(players);
                              }
                              while (queue.Count > 0)
                              {
                                    if (World.jlMsg == 1)
                                    {
                                          Form1.WriteLine(0, "发送当前范围广播数据");
                                    }
                                    Players players2 = (Players)queue.Dequeue();
                                    if (players2.Client != null)
                                    {
                                          if (players2.Client.Running)
                                          {
                                                players2.Client.method_5(class143_0, int_9, int_10, 0);
                                          }
                                          else
                                          {
                                                this.threadSafeDictionary_0.Remove(players2.UserSessionID);
                                                if (players2.Client != null)
                                                {
                                                      players2.Client.Dispose();
                                                }
                                          }
                                    }
                                    else
                                    {
                                          this.threadSafeDictionary_0.Remove(players2.UserSessionID);
                                          if (players2.Client != null)
                                          {
                                                players2.Client.Dispose();
                                          }
                                    }
                                    if (!World.allConnectedChars.ContainsKey(players2.Client.int_3))
                                    {
                                          Form1.WriteLine(2, "NPC发送当前范围广播数据 删除卡号人物：[" + players2.Userid + "] [" + players2.UserName + "]");
                                          if (players2.Client != null)
                                          {
                                                players2.Client.Dispose();
                                          }
                                          this.threadSafeDictionary_0.Remove(players2.UserSessionID);
                                    }
                              }
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "NPC广播数据 出错3：" + exception);
                  }
            }

            public void method_22()
            {
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "NpcClass_发送采药数据");
                  }
                  if (this.IsNpc == 2)
                  {
                        if (this.timer_2 != null)
                        {
                              this.timer_2.Interval = this.FLD_NEWTIME * 0x3e8;
                              this.timer_2.Enabled = true;
                        }
                        else
                        {
                              this.timer_2 = new Timer((double)(this.FLD_NEWTIME * 0x3e8));
                              this.timer_2.Elapsed += new ElapsedEventHandler(this.timer_2_Elapsed);
                              this.timer_2.Enabled = true;
                        }
                        this.method_4();
                        this.method_18();
                  }
            }

            public void DestroyMonsterScript(int int_9)
            {
                  //Form1.WriteLine(1, "DestroyMonster TBL_XWWL_NPC method_23");
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "NpcClass_发送死亡数据");
                  }
                  if (World.DestroyMonsterScriptUSE == 1)
                  {
                        //Form1.WriteLine(1, "DestroyMonster TBL_XWWL_NPC Function");
                        try
                        {
                              LuaFunction function = World.scriptClass_0.pLuaVM.GetFunction("DestroyMonster");
                              if (function != null)
                              {
                                    object[] args = new object[] { int_9, this.FLD_PID };
                                    function.Call(args);
                              }
                              else
                              {
                                    World.scriptClass_0.pLuaVM.DoString(string.Concat(new object[] { "DestroyMonster(", int_9, ",", this.FLD_PID, ")" }));
                              }
                        }
                        catch (Exception exception)
                        {
                              Form1.WriteLine(2, string.Concat(new object[] { "DestroyMonster(", int_9, ",", this.FLD_PID, ")" }));
                              Form1.WriteLine(2, "DestroyMonster Error, Pleas Fix-" + exception.Message);
                        }
                  }
                  try
                  {
                        this.method_31();
                        if ((this.IsNpc != 1) && !this.NPC_TU_VONG)
                        {
                              Players players;
                              if (World.allConnectedChars.TryGetValue(this.PlayerWid, out players))
                              {
                                    this.method_26(players);
                              }
                              else
                              {
                                    this.method_26(null);
                              }
                              this.NPC_TU_VONG = true;
                              if (this.bool_1)
                              {
                                    this.method_4();
                                    this.method_18();
                                    this.Dispose();
                              }
                              else
                              {
                                    this.timer_1.Enabled = false;
                                    this.timer_0.Enabled = true;
                                    if ((World.THE_LUC_CHIEN_2_TIEN_TRINH == 3) && ((((this.int_2 == 0x3c83) || (this.int_2 == 0x3c84)) || ((this.int_2 == 0x3c85) || (this.int_2 == 0x3c86))) || ((this.int_2 == 0x3b11) || (this.int_2 == 0x3b12))))
                                    {
                                          if (((this.int_2 != 0x3c85) && (this.int_2 != 0x3c86)) && (this.int_2 != 0x3b11))
                                          {
                                                if (((this.int_2 == 0x3c84) || (this.int_2 == 0x3c83)) || (this.int_2 == 0x3b12))
                                                {
                                                      World.THE_LUC_CHIEN_2_TA_PHAI_DIEM_SO += 100;
                                                }
                                          }
                                          else
                                          {
                                                World.THE_LUC_CHIEN_2_CHINH_PHAI_DIEM_SO += 100;
                                          }
                                    }
                                    if (this.timer_2 != null)
                                    {
                                          this.timer_2.Interval = this.FLD_NEWTIME * 0x3e8;
                                          this.timer_2.Enabled = true;
                                    }
                                    else
                                    {
                                          this.timer_2 = new Timer((double)(this.FLD_NEWTIME * 0x3e8));
                                          this.timer_2.Elapsed += new ElapsedEventHandler(this.timer_2_Elapsed);
                                          this.timer_2.Enabled = true;
                                    }
                                    this.method_4();
                                    this.method_18();
                              }
                        }
                  }
                  catch (Exception exception2)
                  {
                        Form1.WriteLine(1, string.Concat(new object[] { "发送死亡数据 出错", this.FLD_PID, "|", this.Name, " ", exception2.Message }));
                  }
            }

            public void method_24(int int_9, int int_10)
            {
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "NpcClass_发送反伤攻击数据");
                  }
                  byte[] dst = Converter.hexStringToByte("AA551C0000A42789000C002C0100000F0000000100000000000000000000000055AA");
                  Buffer.BlockCopy(BitConverter.GetBytes(this.FLD_INDEX), 0, dst, 5, 2);
                  Buffer.BlockCopy(BitConverter.GetBytes(int_10), 0, dst, 11, 2);
                  Buffer.BlockCopy(BitConverter.GetBytes(int_9), 0, dst, 0x13, 2);
                  this.method_37(dst, dst.Length);
            }

            public byte[] method_25(TBL_XWWL_DROP class96_0, Players class15_0)
            {
                  Form1.WriteLine(0, "TBL_XWWL_NPC method_25");
                  byte[] buffer;
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "NpcClass_掉出VAT_PHAM");
                  }
                  try
                  {
                        TBL_XWWL_ITEM tbl_xwwl_item;
                        long dBItmeId = RxjhClass.GetDBItmeId();
                        byte[] dst = new byte[0x49];
                        byte[] bytes = BitConverter.GetBytes(dBItmeId);
                        byte[] buffer4 = new byte[0x38];
                        if (World.Itme.TryGetValue(class96_0.FLD_PID, out tbl_xwwl_item))
                        {
                              MAT_DAT_ITEM_LOAI mat_dat_item_loai;
                              if (tbl_xwwl_item.FLD_QUESTITEM == 1)
                              {
                                    if (class15_0 != null)
                                    {
                                          int num3 = class15_0.DUOC_KIEN_HANG_RONG(class15_0);
                                          if (num3 != -1)
                                          {
                                                class15_0.TANG_CUONG_VAT_PHAM(bytes, BitConverter.GetBytes(class96_0.FLD_PID), num3, BitConverter.GetBytes(1), new byte[0x38]);
                                          }
                                    }
                                    return null;
                              }
                              try
                              {
                                    if (World.bool_0)
                                    {
                                          Form1.WriteLine(4, string.Concat(new object[] { "VAT_PHAM掉落--VAT_PHAM名:", class96_0.FLD_NAME, " Thuoc_tinh_1[", class96_0.FLD_MAGIC0, "]Thuoc_tinh_2[", class96_0.FLD_MAGIC1, "]Thuoc_tinh_3[", class96_0.FLD_MAGIC2, "]Thuoc_tinh_4[", class96_0.FLD_MAGIC3, "]属性5[", class96_0.FLD_MAGIC4, "]" }));
                                    }
                                    if (class96_0.CO_HAY_KHONG_MO_RA_THONG_BAO == 1)
                                    {
                                          foreach (Players players in World.allConnectedChars.Values)
                                          {
                                                char[] separator = new char[] { ';' };
                                                string[] strArray = World.Drop_Nhac_nho_noi_dung.Split(separator);
                                                string str = string.Format(strArray[0], class15_0.UserName, TBL_XWWL_MAP.smethod_0(class15_0.CharacterCoords_Map), class96_0.FLD_NAME);
                                                players.GameMessage(str ?? "", int.Parse(strArray[2]), strArray[1] ?? "");
                                          }
                                    }
                                    Buffer.BlockCopy(BitConverter.GetBytes(class96_0.FLD_MAGIC0), 0, buffer4, 0, 4);
                                    Buffer.BlockCopy(BitConverter.GetBytes(class96_0.FLD_MAGIC1), 0, buffer4, 4, 4);
                                    Buffer.BlockCopy(BitConverter.GetBytes(class96_0.FLD_MAGIC2), 0, buffer4, 8, 4);
                                    Buffer.BlockCopy(BitConverter.GetBytes(class96_0.FLD_MAGIC3), 0, buffer4, 12, 4);
                                    Buffer.BlockCopy(BitConverter.GetBytes(class96_0.FLD_MAGIC4), 0, buffer4, 0x10, 4);
                                    Buffer.BlockCopy(bytes, 0, dst, 0, 4);
                                    Buffer.BlockCopy(buffer4, 0, dst, 0x10, 20);
                                    Buffer.BlockCopy(BitConverter.GetBytes(class96_0.FLD_PID), 0, dst, 8, 4);
                                    Buffer.BlockCopy(BitConverter.GetBytes(1), 0, dst, 12, 4);
                                    if (tbl_xwwl_item.FLD_CJL != 0)
                                    {
                                          if (tbl_xwwl_item.FLD_CJL > 0x3e8)
                                          {
                                                tbl_xwwl_item.FLD_CJL = 0x3e8;
                                          }
                                          Buffer.BlockCopy(BitConverter.GetBytes(tbl_xwwl_item.FLD_CJL), 0, dst, 60, 2);
                                    }
                              }
                              catch (Exception exception)
                              {
                                    Form1.WriteLine(1, string.Concat(new object[] { "掉出VAT_PHAM1 出错 ", this.FLD_PID, "|", this.Name, " ", exception.Message }));
                                    return null;
                              }
                              int num2 = 0;
                              try
                              {
                                    num2 = 1;
                                    if (this.FLD_BOSS == 0)
                                    {
                                          num2 = 7;
                                          mat_dat_item_loai = new MAT_DAT_ITEM_LOAI(dst, this.Rxjh_X, this.Rxjh_Y, this.Rxjh_Z, this.Rxjh_Map, class15_0, 0);
                                    }
                                    else
                                    {
                                          double num4 = this.random_0.NextDouble() * 25.0;
                                          double num5 = this.random_0.NextDouble() * 25.0;
                                          if (this.random_0.Next(0, 2) == 0)
                                          {
                                                num2 = 8;
                                                mat_dat_item_loai = new MAT_DAT_ITEM_LOAI(dst, this.Rxjh_X + ((float)num4), this.Rxjh_Y + ((float)num5), this.Rxjh_Z, this.Rxjh_Map, class15_0, 0);
                                          }
                                          else
                                          {
                                                num2 = 9;
                                                mat_dat_item_loai = new MAT_DAT_ITEM_LOAI(dst, this.Rxjh_X - ((float)num4), this.Rxjh_Y - ((float)num5), this.Rxjh_Z, this.Rxjh_Map, class15_0, 0);
                                          }
                                    }
                                    if (mat_dat_item_loai == null)
                                    {
                                          Form1.WriteLine(1, string.Concat(new object[] { "掉出VAT_PHAM2 出错 ", this.FLD_PID, "|", this.Name }));
                                          return null;
                                    }
                                    num2 = 10;
                                    if (!World.threadSafeDictionary_3.ContainsKey(dBItmeId))
                                    {
                                          num2 = 11;
                                          World.threadSafeDictionary_3.Add(dBItmeId, mat_dat_item_loai);
                                    }
                              }
                              catch (Exception exception2)
                              {
                                    Form1.WriteLine(1, string.Concat(new object[] { "掉出VAT_PHAM3 出错 ", this.FLD_PID, "|", this.Name, "出错地方", num2, " ", exception2.Message }));
                                    return null;
                              }
                              try
                              {
                                    if (World.threadSafeDictionary_3.ContainsKey(dBItmeId))
                                    {
                                          mat_dat_item_loai.method_1();
                                    }
                                    return dst;
                              }
                              catch (Exception exception3)
                              {
                                    Form1.WriteLine(1, string.Concat(new object[] { "掉出VAT_PHAM4 出错 ", this.FLD_PID, "|", this.Name, " ", exception3.Message }));
                                    return null;
                              }
                        }
                        buffer = null;
                  }
                  catch (Exception exception4)
                  {
                        Form1.WriteLine(1, string.Concat(new object[] { "掉出VAT_PHAM5 出错 ", this.FLD_PID, "|", this.Name, " ", exception4.Message }));
                        buffer = null;
                  }
                  finally
                  {
                        class96_0.FLD_MAGIC0 = class96_0.int_4;
                        class96_0.FLD_MAGIC1 = class96_0.int_5;
                        class96_0.FLD_MAGIC2 = class96_0.int_6;
                        class96_0.FLD_MAGIC3 = class96_0.int_7;
                        class96_0.FLD_MAGIC4 = class96_0.int_8;
                  }
                  return buffer;
            }

            public void method_26(Players class15_0)
            {
                  try
                  {
                        if (class15_0 != null)
                        {
                              if (this.FLD_BOSS == 0)
                              {
                                    this.method_29(class15_0);
                              }
                              else if (this.FLD_BOSS == 1)
                              {
                                    this.method_28(class15_0);
                              }
                              else if (this.FLD_BOSS == 2)
                              {
                                    this.method_27(1, 3, class15_0);
                              }
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "暴VAT_PHAM 出错：" + exception);
                  }
            }

            public void method_27(int int_9, int int_10, Players class15_0)
            {
                  Form1.WriteLine(0, "TBL_XWWL_NPC method_27");
                  try
                  {
                        if ((this.Rxjh_Exp > 0) && (this.random_0.Next(1, 0xfa0) <= World.The_rate_of_violence))
                        {
                              foreach (TBL_XWWL_DROP tbl_xwwl_drop in TBL_XWWL_DROP.smethod_2(this.Level, int_9, int_10))
                              {
                                    if (tbl_xwwl_drop == null)
                                    {
                                          continue;
                                    }
                                    int num = tbl_xwwl_drop.FLD_PID;
                                    if (num > 0x2faf081c)
                                    {
                                          goto Label_06D6;
                                    }
                                    switch (num)
                                    {
                                          case 0x2faf0801:
                                                goto Label_056A;

                                          case 0x2faf0802:
                                                goto Label_0620;

                                          case 0x2faf080b:
                                                goto Label_03FE;

                                          case 0x2faf080c:
                                                goto Label_04B4;

                                          case 0x2faf080d:
                                                if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                                                {
                                                      tbl_xwwl_drop.FLD_MAGIC0 = World.smethod_16(tbl_xwwl_drop.FLD_PID, 7);
                                                      tbl_xwwl_drop.FLD_PID = World.smethod_14(tbl_xwwl_drop.FLD_PID);
                                                }
                                                goto Label_0AC4;

                                          case 0x2faf0817:
                                                break;

                                          case 0x2faf0818:
                                                goto Label_01DC;

                                          case 0x2faf0819:
                                                goto Label_0292;

                                          case 0x2faf081a:
                                                goto Label_0348;

                                          case 0x2faf081c:
                                                if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                                                {
                                                      tbl_xwwl_drop.FLD_MAGIC0 = World.smethod_16(tbl_xwwl_drop.FLD_PID, 7);
                                                      tbl_xwwl_drop.FLD_PID = World.smethod_14(tbl_xwwl_drop.FLD_PID);
                                                }
                                                goto Label_0AC4;

                                          default:
                                                goto Label_0835;
                                    }
                                    if (tbl_xwwl_drop.FLD_MAGIC0 != 10)
                                    {
                                          goto Label_01A9;
                                    }
                                    int num2 = 0;
                                    int num3 = this.random_0.Next(1, 0x65);
                                    using (List<Class95>.Enumerator enumerator2 = tbl_xwwl_drop.list_0.GetEnumerator())
                                    {
                                          Class95 current;
                                          while (enumerator2.MoveNext())
                                          {
                                                current = enumerator2.Current;
                                                if (num3 <= current.int_0)
                                                {
                                                      goto Label_0173;
                                                }
                                          }
                                          goto Label_019D;
                                          Label_0173:
                                          num2 = this.random_0.Next(current.int_1, current.int_2);
                                    }
                                    Label_019D:
                                    tbl_xwwl_drop.FLD_MAGIC0 = num2;
                                    goto Label_0AC4;
                                    Label_01A9:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                                    {
                                          tbl_xwwl_drop.FLD_MAGIC0 = World.smethod_16(tbl_xwwl_drop.FLD_PID, 7);
                                          tbl_xwwl_drop.FLD_PID = World.smethod_14(tbl_xwwl_drop.FLD_PID);
                                    }
                                    goto Label_0AC4;
                                    Label_01DC:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 != 10)
                                    {
                                          goto Label_025F;
                                    }
                                    int num4 = 0;
                                    int num5 = this.random_0.Next(1, 0x65);
                                    using (List<Class95>.Enumerator enumerator3 = tbl_xwwl_drop.list_0.GetEnumerator())
                                    {
                                          Class95 class3;
                                          while (enumerator3.MoveNext())
                                          {
                                                class3 = enumerator3.Current;
                                                if (num5 <= class3.int_0)
                                                {
                                                      goto Label_0227;
                                                }
                                          }
                                          goto Label_0252;
                                          Label_0227:
                                          num4 = this.random_0.Next(class3.int_1, class3.int_2);
                                    }
                                    Label_0252:
                                    tbl_xwwl_drop.FLD_MAGIC0 = num4;
                                    goto Label_0AC4;
                                    Label_025F:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                                    {
                                          tbl_xwwl_drop.FLD_MAGIC0 = World.smethod_16(tbl_xwwl_drop.FLD_PID, 7);
                                          tbl_xwwl_drop.FLD_PID = World.smethod_14(tbl_xwwl_drop.FLD_PID);
                                    }
                                    goto Label_0AC4;
                                    Label_0292:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 != 10)
                                    {
                                          goto Label_0315;
                                    }
                                    int num6 = 0;
                                    int num7 = this.random_0.Next(1, 0x65);
                                    using (List<Class95>.Enumerator enumerator4 = tbl_xwwl_drop.list_0.GetEnumerator())
                                    {
                                          Class95 class4;
                                          while (enumerator4.MoveNext())
                                          {
                                                class4 = enumerator4.Current;
                                                if (num7 <= class4.int_0)
                                                {
                                                      goto Label_02DD;
                                                }
                                          }
                                          goto Label_0308;
                                          Label_02DD:
                                          num6 = this.random_0.Next(class4.int_1, class4.int_2);
                                    }
                                    Label_0308:
                                    tbl_xwwl_drop.FLD_MAGIC0 = num6;
                                    goto Label_0AC4;
                                    Label_0315:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                                    {
                                          tbl_xwwl_drop.FLD_MAGIC0 = World.smethod_16(tbl_xwwl_drop.FLD_PID, 7);
                                          tbl_xwwl_drop.FLD_PID = World.smethod_14(tbl_xwwl_drop.FLD_PID);
                                    }
                                    goto Label_0AC4;
                                    Label_0348:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 != 10)
                                    {
                                          goto Label_03CB;
                                    }
                                    int num8 = 0;
                                    int num9 = this.random_0.Next(1, 0x65);
                                    using (List<Class95>.Enumerator enumerator5 = tbl_xwwl_drop.list_0.GetEnumerator())
                                    {
                                          Class95 class5;
                                          while (enumerator5.MoveNext())
                                          {
                                                class5 = enumerator5.Current;
                                                if (num9 <= class5.int_0)
                                                {
                                                      goto Label_0393;
                                                }
                                          }
                                          goto Label_03BE;
                                          Label_0393:
                                          num8 = this.random_0.Next(class5.int_1, class5.int_2);
                                    }
                                    Label_03BE:
                                    tbl_xwwl_drop.FLD_MAGIC0 = num8;
                                    goto Label_0AC4;
                                    Label_03CB:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                                    {
                                          tbl_xwwl_drop.FLD_MAGIC0 = World.smethod_16(tbl_xwwl_drop.FLD_PID, 7);
                                          tbl_xwwl_drop.FLD_PID = World.smethod_14(tbl_xwwl_drop.FLD_PID);
                                    }
                                    goto Label_0AC4;
                                    Label_03FE:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 != 10)
                                    {
                                          goto Label_0481;
                                    }
                                    int num10 = 0;
                                    int num11 = this.random_0.Next(1, 0x65);
                                    using (List<Class95>.Enumerator enumerator6 = tbl_xwwl_drop.list_0.GetEnumerator())
                                    {
                                          Class95 class6;
                                          while (enumerator6.MoveNext())
                                          {
                                                class6 = enumerator6.Current;
                                                if (num11 <= class6.int_0)
                                                {
                                                      goto Label_0449;
                                                }
                                          }
                                          goto Label_0474;
                                          Label_0449:
                                          num10 = this.random_0.Next(class6.int_1, class6.int_2);
                                    }
                                    Label_0474:
                                    tbl_xwwl_drop.FLD_MAGIC0 = num10;
                                    goto Label_0AC4;
                                    Label_0481:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                                    {
                                          tbl_xwwl_drop.FLD_MAGIC0 = World.smethod_16(tbl_xwwl_drop.FLD_PID, 7);
                                          tbl_xwwl_drop.FLD_PID = World.smethod_14(tbl_xwwl_drop.FLD_PID);
                                    }
                                    goto Label_0AC4;
                                    Label_04B4:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 != 10)
                                    {
                                          goto Label_0537;
                                    }
                                    int num12 = 0;
                                    int num13 = this.random_0.Next(1, 0x65);
                                    using (List<Class95>.Enumerator enumerator7 = tbl_xwwl_drop.list_0.GetEnumerator())
                                    {
                                          Class95 class7;
                                          while (enumerator7.MoveNext())
                                          {
                                                class7 = enumerator7.Current;
                                                if (num13 <= class7.int_0)
                                                {
                                                      goto Label_04FF;
                                                }
                                          }
                                          goto Label_052A;
                                          Label_04FF:
                                          num12 = this.random_0.Next(class7.int_1, class7.int_2);
                                    }
                                    Label_052A:
                                    tbl_xwwl_drop.FLD_MAGIC0 = num12;
                                    goto Label_0AC4;
                                    Label_0537:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                                    {
                                          tbl_xwwl_drop.FLD_MAGIC0 = World.smethod_16(tbl_xwwl_drop.FLD_PID, 7);
                                          tbl_xwwl_drop.FLD_PID = World.smethod_14(tbl_xwwl_drop.FLD_PID);
                                    }
                                    goto Label_0AC4;
                                    Label_056A:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 != 10)
                                    {
                                          goto Label_05ED;
                                    }
                                    int num14 = 0;
                                    int num15 = this.random_0.Next(1, 0x65);
                                    using (List<Class95>.Enumerator enumerator8 = tbl_xwwl_drop.list_0.GetEnumerator())
                                    {
                                          Class95 class8;
                                          while (enumerator8.MoveNext())
                                          {
                                                class8 = enumerator8.Current;
                                                if (num15 <= class8.int_0)
                                                {
                                                      goto Label_05B5;
                                                }
                                          }
                                          goto Label_05E0;
                                          Label_05B5:
                                          num14 = this.random_0.Next(class8.int_1, class8.int_2);
                                    }
                                    Label_05E0:
                                    tbl_xwwl_drop.FLD_MAGIC0 = num14;
                                    goto Label_0AC4;
                                    Label_05ED:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                                    {
                                          tbl_xwwl_drop.FLD_MAGIC0 = World.smethod_16(tbl_xwwl_drop.FLD_PID, 7);
                                          tbl_xwwl_drop.FLD_PID = World.smethod_14(tbl_xwwl_drop.FLD_PID);
                                    }
                                    goto Label_0AC4;
                                    Label_0620:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 != 10)
                                    {
                                          goto Label_06A3;
                                    }
                                    int num16 = 0;
                                    int num17 = this.random_0.Next(1, 0x65);
                                    using (List<Class95>.Enumerator enumerator9 = tbl_xwwl_drop.list_0.GetEnumerator())
                                    {
                                          Class95 class9;
                                          while (enumerator9.MoveNext())
                                          {
                                                class9 = enumerator9.Current;
                                                if (num17 <= class9.int_0)
                                                {
                                                      goto Label_066B;
                                                }
                                          }
                                          goto Label_0696;
                                          Label_066B:
                                          num16 = this.random_0.Next(class9.int_1, class9.int_2);
                                    }
                                    Label_0696:
                                    tbl_xwwl_drop.FLD_MAGIC0 = num16;
                                    goto Label_0AC4;
                                    Label_06A3:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                                    {
                                          tbl_xwwl_drop.FLD_MAGIC0 = World.smethod_16(tbl_xwwl_drop.FLD_PID, 7);
                                          tbl_xwwl_drop.FLD_PID = World.smethod_14(tbl_xwwl_drop.FLD_PID);
                                    }
                                    goto Label_0AC4;
                                    Label_06D6:
                                    if (num != 0x2faf082e)
                                    {
                                          if (num == 0x2faf082f)
                                          {
                                                goto Label_0A27;
                                          }
                                    }
                                    else
                                    {
                                          if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                                          {
                                                tbl_xwwl_drop.FLD_MAGIC0 = this.random_0.Next(1, 0x17);
                                          }
                                          goto Label_0AC4;
                                    }
                                    switch (num)
                                    {
                                          case 0x3b9acb41:
                                                tbl_xwwl_drop.FLD_MAGIC0 = this.random_0.Next(0x3e9, 0xbb8);
                                                tbl_xwwl_drop.FLD_MAGIC1 = this.random_0.Next(10, 0x33);
                                                goto Label_0AC4;

                                          case 0x3b9acb43:
                                                tbl_xwwl_drop.FLD_MAGIC0 = this.random_0.Next(0x3e9, 0xbb8);
                                                tbl_xwwl_drop.FLD_MAGIC1 = this.random_0.Next(100, 0x97);
                                                goto Label_0AC4;

                                          case 0x3b9acb45:
                                                tbl_xwwl_drop.FLD_MAGIC0 = this.random_0.Next(0x3e9, 0xbb8);
                                                tbl_xwwl_drop.FLD_MAGIC1 = this.random_0.Next(400, 700);
                                                goto Label_0AC4;

                                          case 0x3b9acb47:
                                                tbl_xwwl_drop.FLD_MAGIC0 = this.random_0.Next(0x3e9, 0xbb8);
                                                tbl_xwwl_drop.FLD_MAGIC1 = this.random_0.Next(0x7d0, 0x9c4);
                                                goto Label_0AC4;

                                          case 0x2faf083e:
                                                goto Label_0971;

                                          case 0x2faf083d:
                                                goto Label_08BB;
                                    }
                                    Label_0835:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 != 10)
                                    {
                                          goto Label_0AC4;
                                    }
                                    int num18 = 0;
                                    int num19 = this.random_0.Next(1, 0x65);
                                    using (List<Class95>.Enumerator enumerator10 = tbl_xwwl_drop.list_0.GetEnumerator())
                                    {
                                          Class95 class10;
                                          while (enumerator10.MoveNext())
                                          {
                                                class10 = enumerator10.Current;
                                                if (num19 <= class10.int_0)
                                                {
                                                      goto Label_0883;
                                                }
                                          }
                                          goto Label_08AE;
                                          Label_0883:
                                          num18 = this.random_0.Next(class10.int_1, class10.int_2);
                                    }
                                    Label_08AE:
                                    tbl_xwwl_drop.FLD_MAGIC0 = num18;
                                    goto Label_0AC4;
                                    Label_08BB:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 != 10)
                                    {
                                          goto Label_093E;
                                    }
                                    int num20 = 0;
                                    int num21 = this.random_0.Next(1, 0x65);
                                    using (List<Class95>.Enumerator enumerator11 = tbl_xwwl_drop.list_0.GetEnumerator())
                                    {
                                          Class95 class11;
                                          while (enumerator11.MoveNext())
                                          {
                                                class11 = enumerator11.Current;
                                                if (num21 <= class11.int_0)
                                                {
                                                      goto Label_0906;
                                                }
                                          }
                                          goto Label_0931;
                                          Label_0906:
                                          num20 = this.random_0.Next(class11.int_1, class11.int_2);
                                    }
                                    Label_0931:
                                    tbl_xwwl_drop.FLD_MAGIC0 = num20;
                                    goto Label_0AC4;
                                    Label_093E:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                                    {
                                          tbl_xwwl_drop.FLD_MAGIC0 = World.smethod_16(tbl_xwwl_drop.FLD_PID, 7);
                                          tbl_xwwl_drop.FLD_PID = World.smethod_14(tbl_xwwl_drop.FLD_PID);
                                    }
                                    goto Label_0AC4;
                                    Label_0971:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 != 10)
                                    {
                                          goto Label_09F4;
                                    }
                                    int num22 = 0;
                                    int num23 = this.random_0.Next(1, 0x65);
                                    using (List<Class95>.Enumerator enumerator12 = tbl_xwwl_drop.list_0.GetEnumerator())
                                    {
                                          Class95 class12;
                                          while (enumerator12.MoveNext())
                                          {
                                                class12 = enumerator12.Current;
                                                if (num23 <= class12.int_0)
                                                {
                                                      goto Label_09BC;
                                                }
                                          }
                                          goto Label_09E7;
                                          Label_09BC:
                                          num22 = this.random_0.Next(class12.int_1, class12.int_2);
                                    }
                                    Label_09E7:
                                    tbl_xwwl_drop.FLD_MAGIC0 = num22;
                                    goto Label_0AC4;
                                    Label_09F4:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                                    {
                                          tbl_xwwl_drop.FLD_MAGIC0 = World.smethod_16(tbl_xwwl_drop.FLD_PID, 7);
                                          tbl_xwwl_drop.FLD_PID = World.smethod_14(tbl_xwwl_drop.FLD_PID);
                                    }
                                    goto Label_0AC4;
                                    Label_0A27:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 != 10)
                                    {
                                          goto Label_0AA7;
                                    }
                                    int num24 = 0;
                                    int num25 = this.random_0.Next(1, 0x65);
                                    using (List<Class95>.Enumerator enumerator13 = tbl_xwwl_drop.list_0.GetEnumerator())
                                    {
                                          Class95 class13;
                                          while (enumerator13.MoveNext())
                                          {
                                                class13 = enumerator13.Current;
                                                if (num25 <= class13.int_0)
                                                {
                                                      goto Label_0A72;
                                                }
                                          }
                                          goto Label_0A9D;
                                          Label_0A72:
                                          num24 = this.random_0.Next(class13.int_1, class13.int_2);
                                    }
                                    Label_0A9D:
                                    tbl_xwwl_drop.FLD_MAGIC0 = num24;
                                    goto Label_0AC4;
                                    Label_0AA7:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                                    {
                                          tbl_xwwl_drop.FLD_MAGIC0 = this.random_0.Next(0x17, 0x34);
                                    }
                                    Label_0AC4:
                                    this.method_25(tbl_xwwl_drop, class15_0);
                              }
                        }
                  }
                  catch (Exception)
                  {
                  }
            }

            public void method_28(Players class15_0)
            {
                  Form1.WriteLine(0, "TBL_XWWL_NPC method_28");
                  try
                  {
                        if (this.Rxjh_Exp > 0)
                        {
                              foreach (TBL_XWWL_DROP tbl_xwwl_drop in TBL_XWWL_DROP.smethod_1(this.Level))
                              {
                                    if (tbl_xwwl_drop == null)
                                    {
                                          continue;
                                    }
                                    int num = tbl_xwwl_drop.FLD_PID;
                                    if (num > 0x2faf081c)
                                    {
                                          goto Label_06B9;
                                    }
                                    switch (num)
                                    {
                                          case 0x2faf0801:
                                                goto Label_054D;

                                          case 0x2faf0802:
                                                goto Label_0603;

                                          case 0x2faf080b:
                                                goto Label_03E1;

                                          case 0x2faf080c:
                                                goto Label_0497;

                                          case 0x2faf080d:
                                                if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                                                {
                                                      tbl_xwwl_drop.FLD_MAGIC0 = World.smethod_16(tbl_xwwl_drop.FLD_PID, 4);
                                                      tbl_xwwl_drop.FLD_PID = World.smethod_14(tbl_xwwl_drop.FLD_PID);
                                                }
                                                goto Label_0AA7;

                                          case 0x2faf0817:
                                                break;

                                          case 0x2faf0818:
                                                goto Label_01BF;

                                          case 0x2faf0819:
                                                goto Label_0275;

                                          case 0x2faf081a:
                                                goto Label_032B;

                                          case 0x2faf081c:
                                                if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                                                {
                                                      tbl_xwwl_drop.FLD_MAGIC0 = World.smethod_16(tbl_xwwl_drop.FLD_PID, 4);
                                                      tbl_xwwl_drop.FLD_PID = World.smethod_14(tbl_xwwl_drop.FLD_PID);
                                                }
                                                goto Label_0AA7;

                                          default:
                                                goto Label_0818;
                                    }
                                    if (tbl_xwwl_drop.FLD_MAGIC0 != 10)
                                    {
                                          goto Label_018C;
                                    }
                                    int num2 = 0;
                                    int num3 = this.random_0.Next(1, 0x65);
                                    using (List<Class95>.Enumerator enumerator2 = tbl_xwwl_drop.list_0.GetEnumerator())
                                    {
                                          Class95 current;
                                          while (enumerator2.MoveNext())
                                          {
                                                current = enumerator2.Current;
                                                if (num3 <= current.int_0)
                                                {
                                                      goto Label_0156;
                                                }
                                          }
                                          goto Label_0180;
                                          Label_0156:
                                          num2 = this.random_0.Next(current.int_1, current.int_2);
                                    }
                                    Label_0180:
                                    tbl_xwwl_drop.FLD_MAGIC0 = num2;
                                    goto Label_0AA7;
                                    Label_018C:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                                    {
                                          tbl_xwwl_drop.FLD_MAGIC0 = World.smethod_16(tbl_xwwl_drop.FLD_PID, 4);
                                          tbl_xwwl_drop.FLD_PID = World.smethod_14(tbl_xwwl_drop.FLD_PID);
                                    }
                                    goto Label_0AA7;
                                    Label_01BF:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 != 10)
                                    {
                                          goto Label_0242;
                                    }
                                    int num4 = 0;
                                    int num5 = this.random_0.Next(1, 0x65);
                                    using (List<Class95>.Enumerator enumerator3 = tbl_xwwl_drop.list_0.GetEnumerator())
                                    {
                                          Class95 class3;
                                          while (enumerator3.MoveNext())
                                          {
                                                class3 = enumerator3.Current;
                                                if (num5 <= class3.int_0)
                                                {
                                                      goto Label_020A;
                                                }
                                          }
                                          goto Label_0235;
                                          Label_020A:
                                          num4 = this.random_0.Next(class3.int_1, class3.int_2);
                                    }
                                    Label_0235:
                                    tbl_xwwl_drop.FLD_MAGIC0 = num4;
                                    goto Label_0AA7;
                                    Label_0242:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                                    {
                                          tbl_xwwl_drop.FLD_MAGIC0 = World.smethod_16(tbl_xwwl_drop.FLD_PID, 4);
                                          tbl_xwwl_drop.FLD_PID = World.smethod_14(tbl_xwwl_drop.FLD_PID);
                                    }
                                    goto Label_0AA7;
                                    Label_0275:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 != 10)
                                    {
                                          goto Label_02F8;
                                    }
                                    int num6 = 0;
                                    int num7 = this.random_0.Next(1, 0x65);
                                    using (List<Class95>.Enumerator enumerator4 = tbl_xwwl_drop.list_0.GetEnumerator())
                                    {
                                          Class95 class4;
                                          while (enumerator4.MoveNext())
                                          {
                                                class4 = enumerator4.Current;
                                                if (num7 <= class4.int_0)
                                                {
                                                      goto Label_02C0;
                                                }
                                          }
                                          goto Label_02EB;
                                          Label_02C0:
                                          num6 = this.random_0.Next(class4.int_1, class4.int_2);
                                    }
                                    Label_02EB:
                                    tbl_xwwl_drop.FLD_MAGIC0 = num6;
                                    goto Label_0AA7;
                                    Label_02F8:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                                    {
                                          tbl_xwwl_drop.FLD_MAGIC0 = World.smethod_16(tbl_xwwl_drop.FLD_PID, 4);
                                          tbl_xwwl_drop.FLD_PID = World.smethod_14(tbl_xwwl_drop.FLD_PID);
                                    }
                                    goto Label_0AA7;
                                    Label_032B:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 != 10)
                                    {
                                          goto Label_03AE;
                                    }
                                    int num8 = 0;
                                    int num9 = this.random_0.Next(1, 0x65);
                                    using (List<Class95>.Enumerator enumerator5 = tbl_xwwl_drop.list_0.GetEnumerator())
                                    {
                                          Class95 class5;
                                          while (enumerator5.MoveNext())
                                          {
                                                class5 = enumerator5.Current;
                                                if (num9 <= class5.int_0)
                                                {
                                                      goto Label_0376;
                                                }
                                          }
                                          goto Label_03A1;
                                          Label_0376:
                                          num8 = this.random_0.Next(class5.int_1, class5.int_2);
                                    }
                                    Label_03A1:
                                    tbl_xwwl_drop.FLD_MAGIC0 = num8;
                                    goto Label_0AA7;
                                    Label_03AE:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                                    {
                                          tbl_xwwl_drop.FLD_MAGIC0 = World.smethod_16(tbl_xwwl_drop.FLD_PID, 4);
                                          tbl_xwwl_drop.FLD_PID = World.smethod_14(tbl_xwwl_drop.FLD_PID);
                                    }
                                    goto Label_0AA7;
                                    Label_03E1:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 != 10)
                                    {
                                          goto Label_0464;
                                    }
                                    int num10 = 0;
                                    int num11 = this.random_0.Next(1, 0x65);
                                    using (List<Class95>.Enumerator enumerator6 = tbl_xwwl_drop.list_0.GetEnumerator())
                                    {
                                          Class95 class6;
                                          while (enumerator6.MoveNext())
                                          {
                                                class6 = enumerator6.Current;
                                                if (num11 <= class6.int_0)
                                                {
                                                      goto Label_042C;
                                                }
                                          }
                                          goto Label_0457;
                                          Label_042C:
                                          num10 = this.random_0.Next(class6.int_1, class6.int_2);
                                    }
                                    Label_0457:
                                    tbl_xwwl_drop.FLD_MAGIC0 = num10;
                                    goto Label_0AA7;
                                    Label_0464:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                                    {
                                          tbl_xwwl_drop.FLD_MAGIC0 = World.smethod_16(tbl_xwwl_drop.FLD_PID, 4);
                                          tbl_xwwl_drop.FLD_PID = World.smethod_14(tbl_xwwl_drop.FLD_PID);
                                    }
                                    goto Label_0AA7;
                                    Label_0497:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 != 10)
                                    {
                                          goto Label_051A;
                                    }
                                    int num12 = 0;
                                    int num13 = this.random_0.Next(1, 0x65);
                                    using (List<Class95>.Enumerator enumerator7 = tbl_xwwl_drop.list_0.GetEnumerator())
                                    {
                                          Class95 class7;
                                          while (enumerator7.MoveNext())
                                          {
                                                class7 = enumerator7.Current;
                                                if (num13 <= class7.int_0)
                                                {
                                                      goto Label_04E2;
                                                }
                                          }
                                          goto Label_050D;
                                          Label_04E2:
                                          num12 = this.random_0.Next(class7.int_1, class7.int_2);
                                    }
                                    Label_050D:
                                    tbl_xwwl_drop.FLD_MAGIC0 = num12;
                                    goto Label_0AA7;
                                    Label_051A:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                                    {
                                          tbl_xwwl_drop.FLD_MAGIC0 = World.smethod_16(tbl_xwwl_drop.FLD_PID, 4);
                                          tbl_xwwl_drop.FLD_PID = World.smethod_14(tbl_xwwl_drop.FLD_PID);
                                    }
                                    goto Label_0AA7;
                                    Label_054D:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 != 10)
                                    {
                                          goto Label_05D0;
                                    }
                                    int num14 = 0;
                                    int num15 = this.random_0.Next(1, 0x65);
                                    using (List<Class95>.Enumerator enumerator8 = tbl_xwwl_drop.list_0.GetEnumerator())
                                    {
                                          Class95 class8;
                                          while (enumerator8.MoveNext())
                                          {
                                                class8 = enumerator8.Current;
                                                if (num15 <= class8.int_0)
                                                {
                                                      goto Label_0598;
                                                }
                                          }
                                          goto Label_05C3;
                                          Label_0598:
                                          num14 = this.random_0.Next(class8.int_1, class8.int_2);
                                    }
                                    Label_05C3:
                                    tbl_xwwl_drop.FLD_MAGIC0 = num14;
                                    goto Label_0AA7;
                                    Label_05D0:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                                    {
                                          tbl_xwwl_drop.FLD_MAGIC0 = World.smethod_16(tbl_xwwl_drop.FLD_PID, 4);
                                          tbl_xwwl_drop.FLD_PID = World.smethod_14(tbl_xwwl_drop.FLD_PID);
                                    }
                                    goto Label_0AA7;
                                    Label_0603:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 != 10)
                                    {
                                          goto Label_0686;
                                    }
                                    int num16 = 0;
                                    int num17 = this.random_0.Next(1, 0x65);
                                    using (List<Class95>.Enumerator enumerator9 = tbl_xwwl_drop.list_0.GetEnumerator())
                                    {
                                          Class95 class9;
                                          while (enumerator9.MoveNext())
                                          {
                                                class9 = enumerator9.Current;
                                                if (num17 <= class9.int_0)
                                                {
                                                      goto Label_064E;
                                                }
                                          }
                                          goto Label_0679;
                                          Label_064E:
                                          num16 = this.random_0.Next(class9.int_1, class9.int_2);
                                    }
                                    Label_0679:
                                    tbl_xwwl_drop.FLD_MAGIC0 = num16;
                                    goto Label_0AA7;
                                    Label_0686:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                                    {
                                          tbl_xwwl_drop.FLD_MAGIC0 = World.smethod_16(tbl_xwwl_drop.FLD_PID, 4);
                                          tbl_xwwl_drop.FLD_PID = World.smethod_14(tbl_xwwl_drop.FLD_PID);
                                    }
                                    goto Label_0AA7;
                                    Label_06B9:
                                    if (num != 0x2faf082e)
                                    {
                                          if (num == 0x2faf082f)
                                          {
                                                goto Label_0A0A;
                                          }
                                    }
                                    else
                                    {
                                          if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                                          {
                                                tbl_xwwl_drop.FLD_MAGIC0 = this.random_0.Next(1, 0x17);
                                          }
                                          goto Label_0AA7;
                                    }
                                    switch (num)
                                    {
                                          case 0x3b9acb41:
                                                tbl_xwwl_drop.FLD_MAGIC0 = this.random_0.Next(0x3e9, 0xbb8);
                                                tbl_xwwl_drop.FLD_MAGIC1 = this.random_0.Next(10, 0x33);
                                                goto Label_0AA7;

                                          case 0x3b9acb43:
                                                tbl_xwwl_drop.FLD_MAGIC0 = this.random_0.Next(0x3e9, 0xbb8);
                                                tbl_xwwl_drop.FLD_MAGIC1 = this.random_0.Next(100, 0x97);
                                                goto Label_0AA7;

                                          case 0x3b9acb45:
                                                tbl_xwwl_drop.FLD_MAGIC0 = this.random_0.Next(0x3e9, 0xbb8);
                                                tbl_xwwl_drop.FLD_MAGIC1 = this.random_0.Next(400, 700);
                                                goto Label_0AA7;

                                          case 0x3b9acb47:
                                                tbl_xwwl_drop.FLD_MAGIC0 = this.random_0.Next(0x3e9, 0xbb8);
                                                tbl_xwwl_drop.FLD_MAGIC1 = this.random_0.Next(0x7d0, 0x9c4);
                                                goto Label_0AA7;

                                          case 0x2faf083e:
                                                goto Label_0954;

                                          case 0x2faf083d:
                                                goto Label_089E;
                                    }
                                    Label_0818:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 != 10)
                                    {
                                          goto Label_0AA7;
                                    }
                                    int num18 = 0;
                                    int num19 = this.random_0.Next(1, 0x65);
                                    using (List<Class95>.Enumerator enumerator10 = tbl_xwwl_drop.list_0.GetEnumerator())
                                    {
                                          Class95 class10;
                                          while (enumerator10.MoveNext())
                                          {
                                                class10 = enumerator10.Current;
                                                if (num19 <= class10.int_0)
                                                {
                                                      goto Label_0866;
                                                }
                                          }
                                          goto Label_0891;
                                          Label_0866:
                                          num18 = this.random_0.Next(class10.int_1, class10.int_2);
                                    }
                                    Label_0891:
                                    tbl_xwwl_drop.FLD_MAGIC0 = num18;
                                    goto Label_0AA7;
                                    Label_089E:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 != 10)
                                    {
                                          goto Label_0921;
                                    }
                                    int num20 = 0;
                                    int num21 = this.random_0.Next(1, 0x65);
                                    using (List<Class95>.Enumerator enumerator11 = tbl_xwwl_drop.list_0.GetEnumerator())
                                    {
                                          Class95 class11;
                                          while (enumerator11.MoveNext())
                                          {
                                                class11 = enumerator11.Current;
                                                if (num21 <= class11.int_0)
                                                {
                                                      goto Label_08E9;
                                                }
                                          }
                                          goto Label_0914;
                                          Label_08E9:
                                          num20 = this.random_0.Next(class11.int_1, class11.int_2);
                                    }
                                    Label_0914:
                                    tbl_xwwl_drop.FLD_MAGIC0 = num20;
                                    goto Label_0AA7;
                                    Label_0921:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                                    {
                                          tbl_xwwl_drop.FLD_MAGIC0 = World.smethod_16(tbl_xwwl_drop.FLD_PID, 4);
                                          tbl_xwwl_drop.FLD_PID = World.smethod_14(tbl_xwwl_drop.FLD_PID);
                                    }
                                    goto Label_0AA7;
                                    Label_0954:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 != 10)
                                    {
                                          goto Label_09D7;
                                    }
                                    int num22 = 0;
                                    int num23 = this.random_0.Next(1, 0x65);
                                    using (List<Class95>.Enumerator enumerator12 = tbl_xwwl_drop.list_0.GetEnumerator())
                                    {
                                          Class95 class12;
                                          while (enumerator12.MoveNext())
                                          {
                                                class12 = enumerator12.Current;
                                                if (num23 <= class12.int_0)
                                                {
                                                      goto Label_099F;
                                                }
                                          }
                                          goto Label_09CA;
                                          Label_099F:
                                          num22 = this.random_0.Next(class12.int_1, class12.int_2);
                                    }
                                    Label_09CA:
                                    tbl_xwwl_drop.FLD_MAGIC0 = num22;
                                    goto Label_0AA7;
                                    Label_09D7:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                                    {
                                          tbl_xwwl_drop.FLD_MAGIC0 = World.smethod_16(tbl_xwwl_drop.FLD_PID, 4);
                                          tbl_xwwl_drop.FLD_PID = World.smethod_14(tbl_xwwl_drop.FLD_PID);
                                    }
                                    goto Label_0AA7;
                                    Label_0A0A:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 != 10)
                                    {
                                          goto Label_0A8A;
                                    }
                                    int num24 = 0;
                                    int num25 = this.random_0.Next(1, 0x65);
                                    using (List<Class95>.Enumerator enumerator13 = tbl_xwwl_drop.list_0.GetEnumerator())
                                    {
                                          Class95 class13;
                                          while (enumerator13.MoveNext())
                                          {
                                                class13 = enumerator13.Current;
                                                if (num25 <= class13.int_0)
                                                {
                                                      goto Label_0A55;
                                                }
                                          }
                                          goto Label_0A80;
                                          Label_0A55:
                                          num24 = this.random_0.Next(class13.int_1, class13.int_2);
                                    }
                                    Label_0A80:
                                    tbl_xwwl_drop.FLD_MAGIC0 = num24;
                                    goto Label_0AA7;
                                    Label_0A8A:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                                    {
                                          tbl_xwwl_drop.FLD_MAGIC0 = this.random_0.Next(0x17, 0x34);
                                    }
                                    Label_0AA7:
                                    this.method_25(tbl_xwwl_drop, class15_0);
                              }
                        }
                  }
                  catch (Exception)
                  {
                  }
            }

            //일반 몬스터 드롭
            public void method_29(Players class15_0)
            {
                  try
                  {
                        Form1.WriteLine(0, "일반몬스터 드롭");
                        TBL_XWWL_DROP tbl_xwwl_drop;
                        Players players;
                        
                        if ((this.Rxjh_Exp <= 0) || (this.random_0.Next(1, 0x1f40) > World.The_rate_of_violence))
                        {
                              return;
                        }
                        if (World.allConnectedChars.TryGetValue(this.PlayerWid, out players))
                        {
                              //DestroyMonster Script
                              //this.method_23(players.UserSessionID);
                              if (players.FLD_VIP == 1)
                              {
                                    tbl_xwwl_drop = TBL_XWWL_DROP.smethod_4(this.Level);
                              }
                              else
                              {
                                    tbl_xwwl_drop = TBL_XWWL_DROP.smethod_3(this.Level);
                              }
                        }
                        else
                        {
                              tbl_xwwl_drop = TBL_XWWL_DROP.smethod_3(this.Level);
                        }
                        if (tbl_xwwl_drop == null)
                        {
                              return;
                        }
                        int num2 = tbl_xwwl_drop.FLD_PID;
                        if (num2 > 0x2faf081c)
                        {
                              goto Label_0706;
                        }
                        switch (num2)
                        {
                              case 0x2faf0801:
                                    goto Label_059A;

                              case 0x2faf0802:
                                    goto Label_0650;

                              case 0x2faf080b:
                                    goto Label_042E;

                              case 0x2faf080c:
                                    goto Label_04E4;

                              case 0x2faf080d:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                                    {
                                          tbl_xwwl_drop.FLD_MAGIC0 = World.smethod_16(tbl_xwwl_drop.FLD_PID, 3);
                                          tbl_xwwl_drop.FLD_PID = World.smethod_14(tbl_xwwl_drop.FLD_PID);
                                    }
                                    goto Label_0B1E;

                              case 0x2faf0817:
                                    break;

                              case 0x2faf0818:
                                    goto Label_020C;

                              case 0x2faf0819:
                                    goto Label_02C2;

                              case 0x2faf081a:
                                    goto Label_0378;

                              case 0x2faf081c:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                                    {
                                          tbl_xwwl_drop.FLD_MAGIC0 = World.smethod_16(tbl_xwwl_drop.FLD_PID, 3);
                                          tbl_xwwl_drop.FLD_PID = World.smethod_14(tbl_xwwl_drop.FLD_PID);
                                    }
                                    goto Label_0B1E;

                              default:
                                    goto Label_088F;
                        }
                        if (tbl_xwwl_drop.FLD_MAGIC0 != 10)
                        {
                              goto Label_01D9;
                        }
                        int num3 = 0;
                        int num4 = this.random_0.Next(1, 0x65);
                        using (List<Class95>.Enumerator enumerator = tbl_xwwl_drop.list_0.GetEnumerator())
                        {
                              Class95 current;
                              while (enumerator.MoveNext())
                              {
                                    current = enumerator.Current;
                                    if (num4 <= current.int_0)
                                    {
                                          goto Label_01A1;
                                    }
                              }
                              goto Label_01CC;
                              Label_01A1:
                              num3 = this.random_0.Next(current.int_1, current.int_2);
                        }
                        Label_01CC:
                        tbl_xwwl_drop.FLD_MAGIC0 = num3;
                        goto Label_0B1E;
                        Label_01D9:
                        if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                        {
                              tbl_xwwl_drop.FLD_MAGIC0 = World.smethod_16(tbl_xwwl_drop.FLD_PID, 3);
                              tbl_xwwl_drop.FLD_PID = World.smethod_14(tbl_xwwl_drop.FLD_PID);
                        }
                        goto Label_0B1E;
                        Label_020C:
                        if (tbl_xwwl_drop.FLD_MAGIC0 != 10)
                        {
                              goto Label_028F;
                        }
                        int num5 = 0;
                        int num6 = this.random_0.Next(1, 0x65);
                        using (List<Class95>.Enumerator enumerator2 = tbl_xwwl_drop.list_0.GetEnumerator())
                        {
                              Class95 class3;
                              while (enumerator2.MoveNext())
                              {
                                    class3 = enumerator2.Current;
                                    if (num6 <= class3.int_0)
                                    {
                                          goto Label_0257;
                                    }
                              }
                              goto Label_0282;
                              Label_0257:
                              num5 = this.random_0.Next(class3.int_1, class3.int_2);
                        }
                        Label_0282:
                        tbl_xwwl_drop.FLD_MAGIC0 = num5;
                        goto Label_0B1E;
                        Label_028F:
                        if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                        {
                              tbl_xwwl_drop.FLD_MAGIC0 = World.smethod_16(tbl_xwwl_drop.FLD_PID, 3);
                              tbl_xwwl_drop.FLD_PID = World.smethod_14(tbl_xwwl_drop.FLD_PID);
                        }
                        goto Label_0B1E;
                        Label_02C2:
                        if (tbl_xwwl_drop.FLD_MAGIC0 != 10)
                        {
                              goto Label_0345;
                        }
                        int num7 = 0;
                        int num8 = this.random_0.Next(1, 0x65);
                        using (List<Class95>.Enumerator enumerator3 = tbl_xwwl_drop.list_0.GetEnumerator())
                        {
                              Class95 class4;
                              while (enumerator3.MoveNext())
                              {
                                    class4 = enumerator3.Current;
                                    if (num8 <= class4.int_0)
                                    {
                                          goto Label_030D;
                                    }
                              }
                              goto Label_0338;
                              Label_030D:
                              num7 = this.random_0.Next(class4.int_1, class4.int_2);
                        }
                        Label_0338:
                        tbl_xwwl_drop.FLD_MAGIC0 = num7;
                        goto Label_0B1E;
                        Label_0345:
                        if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                        {
                              tbl_xwwl_drop.FLD_MAGIC0 = World.smethod_16(tbl_xwwl_drop.FLD_PID, 3);
                              tbl_xwwl_drop.FLD_PID = World.smethod_14(tbl_xwwl_drop.FLD_PID);
                        }
                        goto Label_0B1E;
                        Label_0378:
                        if (tbl_xwwl_drop.FLD_MAGIC0 != 10)
                        {
                              goto Label_03FB;
                        }
                        int num9 = 0;
                        int num10 = this.random_0.Next(1, 0x65);
                        using (List<Class95>.Enumerator enumerator4 = tbl_xwwl_drop.list_0.GetEnumerator())
                        {
                              Class95 class5;
                              while (enumerator4.MoveNext())
                              {
                                    class5 = enumerator4.Current;
                                    if (num10 <= class5.int_0)
                                    {
                                          goto Label_03C3;
                                    }
                              }
                              goto Label_03EE;
                              Label_03C3:
                              num9 = this.random_0.Next(class5.int_1, class5.int_2);
                        }
                        Label_03EE:
                        tbl_xwwl_drop.FLD_MAGIC0 = num9;
                        goto Label_0B1E;
                        Label_03FB:
                        if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                        {
                              tbl_xwwl_drop.FLD_MAGIC0 = World.smethod_16(tbl_xwwl_drop.FLD_PID, 3);
                              tbl_xwwl_drop.FLD_PID = World.smethod_14(tbl_xwwl_drop.FLD_PID);
                        }
                        goto Label_0B1E;
                        Label_042E:
                        if (tbl_xwwl_drop.FLD_MAGIC0 != 10)
                        {
                              goto Label_04B1;
                        }
                        int num11 = 0;
                        int num12 = this.random_0.Next(1, 0x65);
                        using (List<Class95>.Enumerator enumerator5 = tbl_xwwl_drop.list_0.GetEnumerator())
                        {
                              Class95 class6;
                              while (enumerator5.MoveNext())
                              {
                                    class6 = enumerator5.Current;
                                    if (num12 <= class6.int_0)
                                    {
                                          goto Label_0479;
                                    }
                              }
                              goto Label_04A4;
                              Label_0479:
                              num11 = this.random_0.Next(class6.int_1, class6.int_2);
                        }
                        Label_04A4:
                        tbl_xwwl_drop.FLD_MAGIC0 = num11;
                        goto Label_0B1E;
                        Label_04B1:
                        if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                        {
                              tbl_xwwl_drop.FLD_MAGIC0 = World.smethod_16(tbl_xwwl_drop.FLD_PID, 3);
                              tbl_xwwl_drop.FLD_PID = World.smethod_14(tbl_xwwl_drop.FLD_PID);
                        }
                        goto Label_0B1E;
                        Label_04E4:
                        if (tbl_xwwl_drop.FLD_MAGIC0 != 10)
                        {
                              goto Label_0567;
                        }
                        int num13 = 0;
                        int num14 = this.random_0.Next(1, 0x65);
                        using (List<Class95>.Enumerator enumerator6 = tbl_xwwl_drop.list_0.GetEnumerator())
                        {
                              Class95 class7;
                              while (enumerator6.MoveNext())
                              {
                                    class7 = enumerator6.Current;
                                    if (num14 <= class7.int_0)
                                    {
                                          goto Label_052F;
                                    }
                              }
                              goto Label_055A;
                              Label_052F:
                              num13 = this.random_0.Next(class7.int_1, class7.int_2);
                        }
                        Label_055A:
                        tbl_xwwl_drop.FLD_MAGIC0 = num13;
                        goto Label_0B1E;
                        Label_0567:
                        if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                        {
                              tbl_xwwl_drop.FLD_MAGIC0 = World.smethod_16(tbl_xwwl_drop.FLD_PID, 3);
                              tbl_xwwl_drop.FLD_PID = World.smethod_14(tbl_xwwl_drop.FLD_PID);
                        }
                        goto Label_0B1E;
                        Label_059A:
                        if (tbl_xwwl_drop.FLD_MAGIC0 != 10)
                        {
                              goto Label_061D;
                        }
                        int num15 = 0;
                        int num16 = this.random_0.Next(1, 0x65);
                        using (List<Class95>.Enumerator enumerator7 = tbl_xwwl_drop.list_0.GetEnumerator())
                        {
                              Class95 class8;
                              while (enumerator7.MoveNext())
                              {
                                    class8 = enumerator7.Current;
                                    if (num16 <= class8.int_0)
                                    {
                                          goto Label_05E5;
                                    }
                              }
                              goto Label_0610;
                              Label_05E5:
                              num15 = this.random_0.Next(class8.int_1, class8.int_2);
                        }
                        Label_0610:
                        tbl_xwwl_drop.FLD_MAGIC0 = num15;
                        goto Label_0B1E;
                        Label_061D:
                        if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                        {
                              tbl_xwwl_drop.FLD_MAGIC0 = World.smethod_16(tbl_xwwl_drop.FLD_PID, 3);
                              tbl_xwwl_drop.FLD_PID = World.smethod_14(tbl_xwwl_drop.FLD_PID);
                        }
                        goto Label_0B1E;
                        Label_0650:
                        if (tbl_xwwl_drop.FLD_MAGIC0 != 10)
                        {
                              goto Label_06D3;
                        }
                        int num17 = 0;
                        int num18 = this.random_0.Next(1, 0x65);
                        using (List<Class95>.Enumerator enumerator8 = tbl_xwwl_drop.list_0.GetEnumerator())
                        {
                              Class95 class9;
                              while (enumerator8.MoveNext())
                              {
                                    class9 = enumerator8.Current;
                                    if (num18 <= class9.int_0)
                                    {
                                          goto Label_069B;
                                    }
                              }
                              goto Label_06C6;
                              Label_069B:
                              num17 = this.random_0.Next(class9.int_1, class9.int_2);
                        }
                        Label_06C6:
                        tbl_xwwl_drop.FLD_MAGIC0 = num17;
                        goto Label_0B1E;
                        Label_06D3:
                        if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                        {
                              tbl_xwwl_drop.FLD_MAGIC0 = World.smethod_16(tbl_xwwl_drop.FLD_PID, 3);
                              tbl_xwwl_drop.FLD_PID = World.smethod_14(tbl_xwwl_drop.FLD_PID);
                        }
                        goto Label_0B1E;
                        Label_0706:
                        switch (num2)
                        {
                              case 0x2faf082e:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                                    {
                                          tbl_xwwl_drop.FLD_MAGIC0 = this.random_0.Next(1, 0x17);
                                    }
                                    goto Label_0B1E;

                              case 0x2faf082f:
                                    goto Label_0A81;

                              case 0x2faf0830:
                                    if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                                    {
                                          tbl_xwwl_drop.FLD_MAGIC0 = this.random_0.Next(70, 0x51);
                                    }
                                    goto Label_0B1E;

                              case 0x2faf083d:
                                    goto Label_0915;

                              default:
                                    switch (num2)
                                    {
                                          case 0x3b9acb41:
                                                tbl_xwwl_drop.FLD_MAGIC0 = this.random_0.Next(0x3e9, 0xbb8);
                                                tbl_xwwl_drop.FLD_MAGIC1 = this.random_0.Next(10, 0x33);
                                                goto Label_0B1E;

                                          case 0x3b9acb43:
                                                tbl_xwwl_drop.FLD_MAGIC0 = this.random_0.Next(0x3e9, 0xbb8);
                                                tbl_xwwl_drop.FLD_MAGIC1 = this.random_0.Next(100, 0x97);
                                                goto Label_0B1E;

                                          case 0x3b9acb45:
                                                tbl_xwwl_drop.FLD_MAGIC0 = this.random_0.Next(0x3e9, 0xbb8);
                                                tbl_xwwl_drop.FLD_MAGIC1 = this.random_0.Next(400, 700);
                                                goto Label_0B1E;

                                          case 0x3b9acb47:
                                                tbl_xwwl_drop.FLD_MAGIC0 = this.random_0.Next(0x3e9, 0xbb8);
                                                tbl_xwwl_drop.FLD_MAGIC1 = this.random_0.Next(0x7d0, 0x9c4);
                                                goto Label_0B1E;

                                          case 0x2faf083e:
                                                goto Label_09CB;
                                    }
                                    break;
                        }
                        Label_088F:
                        if (tbl_xwwl_drop.FLD_MAGIC0 != 10)
                        {
                              goto Label_0B1E;
                        }
                        int num19 = 0;
                        int num20 = this.random_0.Next(1, 0x65);
                        using (List<Class95>.Enumerator enumerator9 = tbl_xwwl_drop.list_0.GetEnumerator())
                        {
                              Class95 class10;
                              while (enumerator9.MoveNext())
                              {
                                    class10 = enumerator9.Current;
                                    if (num20 <= class10.int_0)
                                    {
                                          goto Label_08DD;
                                    }
                              }
                              goto Label_0908;
                              Label_08DD:
                              num19 = this.random_0.Next(class10.int_1, class10.int_2);
                        }
                        Label_0908:
                        tbl_xwwl_drop.FLD_MAGIC0 = num19;
                        goto Label_0B1E;
                        Label_0915:
                        if (tbl_xwwl_drop.FLD_MAGIC0 != 10)
                        {
                              goto Label_0998;
                        }
                        int num21 = 0;
                        int num22 = this.random_0.Next(1, 0x65);
                        using (List<Class95>.Enumerator enumerator10 = tbl_xwwl_drop.list_0.GetEnumerator())
                        {
                              Class95 class11;
                              while (enumerator10.MoveNext())
                              {
                                    class11 = enumerator10.Current;
                                    if (num22 <= class11.int_0)
                                    {
                                          goto Label_0960;
                                    }
                              }
                              goto Label_098B;
                              Label_0960:
                              num21 = this.random_0.Next(class11.int_1, class11.int_2);
                        }
                        Label_098B:
                        tbl_xwwl_drop.FLD_MAGIC0 = num21;
                        goto Label_0B1E;
                        Label_0998:
                        if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                        {
                              tbl_xwwl_drop.FLD_MAGIC0 = World.smethod_16(tbl_xwwl_drop.FLD_PID, 3);
                              tbl_xwwl_drop.FLD_PID = World.smethod_14(tbl_xwwl_drop.FLD_PID);
                        }
                        goto Label_0B1E;
                        Label_09CB:
                        if (tbl_xwwl_drop.FLD_MAGIC0 != 10)
                        {
                              goto Label_0A4E;
                        }
                        int num23 = 0;
                        int num24 = this.random_0.Next(1, 0x65);
                        using (List<Class95>.Enumerator enumerator11 = tbl_xwwl_drop.list_0.GetEnumerator())
                        {
                              Class95 class12;
                              while (enumerator11.MoveNext())
                              {
                                    class12 = enumerator11.Current;
                                    if (num24 <= class12.int_0)
                                    {
                                          goto Label_0A16;
                                    }
                              }
                              goto Label_0A41;
                              Label_0A16:
                              num23 = this.random_0.Next(class12.int_1, class12.int_2);
                        }
                        Label_0A41:
                        tbl_xwwl_drop.FLD_MAGIC0 = num23;
                        goto Label_0B1E;
                        Label_0A4E:
                        if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                        {
                              tbl_xwwl_drop.FLD_MAGIC0 = World.smethod_16(tbl_xwwl_drop.FLD_PID, 3);
                              tbl_xwwl_drop.FLD_PID = World.smethod_14(tbl_xwwl_drop.FLD_PID);
                        }
                        goto Label_0B1E;
                        Label_0A81:
                        if (tbl_xwwl_drop.FLD_MAGIC0 != 10)
                        {
                              goto Label_0B01;
                        }
                        int num25 = 0;
                        int num26 = this.random_0.Next(1, 0x65);
                        using (List<Class95>.Enumerator enumerator12 = tbl_xwwl_drop.list_0.GetEnumerator())
                        {
                              Class95 class13;
                              while (enumerator12.MoveNext())
                              {
                                    class13 = enumerator12.Current;
                                    if (num26 <= class13.int_0)
                                    {
                                          goto Label_0ACC;
                                    }
                              }
                              goto Label_0AF7;
                              Label_0ACC:
                              num25 = this.random_0.Next(class13.int_1, class13.int_2);
                        }
                        Label_0AF7:
                        tbl_xwwl_drop.FLD_MAGIC0 = num25;
                        goto Label_0B1E;
                        Label_0B01:
                        if (tbl_xwwl_drop.FLD_MAGIC0 == 0)
                        {
                              tbl_xwwl_drop.FLD_MAGIC0 = this.random_0.Next(0x17, 0x34);
                        }
                        Label_0B1E:
                        this.method_25(tbl_xwwl_drop, class15_0);
                  }
                  catch (Exception)
                  {
                  }
            }

            public void method_3(Players class15_0)
            {
                  PlayGjClass class2;
                  using (List<PlayGjClass>.Enumerator enumerator = this.list_0.GetEnumerator())
                  {
                        PlayGjClass current;
                        while (enumerator.MoveNext())
                        {
                              current = enumerator.Current;
                              if (current.PlayID == class15_0.UserSessionID)
                              {
                                    goto Label_002F;
                              }
                        }
                        goto Label_004F;
                        Label_002F:
                        current.Gjsl++;
                        return;
                  }
                  Label_004F:
                  class2 = new PlayGjClass();
                  class2.Gjsl = 1;
                  class2.PlayID = class15_0.UserSessionID;
                  this.list_0.Add(class2);
            }

            public void method_30(List<TBL_XWWL_NPC_DROP> list_1, Players class15_0)
            {
                  //800000001
                  //900000655
                  try
                  {
                        foreach (TBL_XWWL_NPC_DROP tbl_xwwl_npc_drop in list_1)
                        {
                              if (tbl_xwwl_npc_drop != null)
                              {
                                    switch (tbl_xwwl_npc_drop.FLD_ITME_PID)
                                    {
                                          case 0x2faf0801:
                                                if (tbl_xwwl_npc_drop.FLD_MAGIC0 == 0)
                                                {
                                                      int num2 = this.random_0.Next(0x186aa, 0x186ba);
                                                      tbl_xwwl_npc_drop.FLD_MAGIC0 = num2;
                                                }
                                                break;

                                          case 0x2faf0802:
                                                if (tbl_xwwl_npc_drop.FLD_MAGIC0 == 0)
                                                {
                                                      int num3 = this.random_0.Next(0x30d4a, 0x30d55);
                                                      tbl_xwwl_npc_drop.FLD_MAGIC0 = num3;
                                                }
                                                break;

                                          case 0x2faf080d:
                                                if (tbl_xwwl_npc_drop.FLD_MAGIC0 == 0)
                                                {
                                                      int num4 = this.random_0.Next(8, 10);
                                                      string str = "0000";
                                                      int num5 = 0;
                                                      num5 = this.random_0.Next(1, 3);
                                                      string s = num4.ToString() + str + num5;
                                                      tbl_xwwl_npc_drop.FLD_MAGIC0 = int.Parse(s);
                                                }
                                                break;

                                          case 0x2faf0817:
                                                if (tbl_xwwl_npc_drop.FLD_MAGIC0 == 0)
                                                {
                                                      int num6 = this.random_0.Next(0xaae72, 0xaae7f);
                                                      tbl_xwwl_npc_drop.FLD_MAGIC0 = num6;
                                                }
                                                break;

                                          case 0x2faf0818:
                                                if (tbl_xwwl_npc_drop.FLD_MAGIC0 == 0)
                                                {
                                                      int num7 = this.random_0.Next(0x30d52, 0x30d5a);
                                                      tbl_xwwl_npc_drop.FLD_MAGIC0 = num7;
                                                }
                                                break;

                                          case 0x2faf0819:
                                                if (tbl_xwwl_npc_drop.FLD_MAGIC0 == 0)
                                                {
                                                      int num8 = this.random_0.Next(0xf4245, 0xf4255);
                                                      tbl_xwwl_npc_drop.FLD_MAGIC0 = num8;
                                                }
                                                break;

                                          case 0x2faf081a:
                                                if (tbl_xwwl_npc_drop.FLD_MAGIC0 == 0)
                                                {
                                                      int num9 = this.random_0.Next(0xaae6f, 0xaae7a);
                                                      tbl_xwwl_npc_drop.FLD_MAGIC0 = num9;
                                                }
                                                break;

                                          case 0x2faf081c:
                                                if (tbl_xwwl_npc_drop.FLD_MAGIC0 == 0)
                                                {
                                                      int num10 = this.random_0.Next(1, 7);
                                                      string str3 = "000";
                                                      string str4 = "200" + num10.ToString() + str3;
                                                      tbl_xwwl_npc_drop.FLD_MAGIC0 = int.Parse(str4);
                                                }
                                                break;

                                          case 0x2faf082e:
                                                if (tbl_xwwl_npc_drop.FLD_MAGIC0 == 0)
                                                {
                                                      tbl_xwwl_npc_drop.FLD_MAGIC0 = this.random_0.Next(1, 0x17);
                                                }
                                                break;

                                          case 0x2faf082f:
                                                if (tbl_xwwl_npc_drop.FLD_MAGIC0 == 0)
                                                {
                                                      tbl_xwwl_npc_drop.FLD_MAGIC0 = this.random_0.Next(0x17, 0x34);
                                                }
                                                break;

                                          case 0x2faf0830:
                                                if (tbl_xwwl_npc_drop.FLD_MAGIC0 == 0)
                                                {
                                                      tbl_xwwl_npc_drop.FLD_MAGIC0 = this.random_0.Next(70, 0x51);
                                                }
                                                break;

                                          case 0x2faf083d:
                                                if (tbl_xwwl_npc_drop.FLD_MAGIC0 == 0)
                                                {
                                                      int num11 = this.random_0.Next(0xaae74, 0xaae84);
                                                      tbl_xwwl_npc_drop.FLD_MAGIC0 = num11;
                                                }
                                                break;

                                          case 0x2faf083e:
                                                if (tbl_xwwl_npc_drop.FLD_MAGIC0 == 0)
                                                {
                                                      int num12 = this.random_0.Next(0x30d5d, 0x30d61);
                                                      tbl_xwwl_npc_drop.FLD_MAGIC0 = num12;
                                                }
                                                break;
                                    }
                              }
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "New暴VAT_PHAM 出错：" + exception);
                  }
            }

            public void method_31()
            {
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "NpcClass_异常状态列表");
                  }
                  Queue queue = Queue.Synchronized(new Queue());
                  try
                  {
                        foreach (DI_THUONG_TRANG_THAI_NEW di_thuong_trang_thai_new in this.threadSafeDictionary_1.Values)
                        {
                              queue.Enqueue(di_thuong_trang_thai_new);
                        }
                        while (queue.Count > 0)
                        {
                              if (World.jlMsg == 1)
                              {
                                    Form1.WriteLine(0, "异常状态列表NPC");
                              }
                              DI_THUONG_TRANG_THAI_NEW di_thuong_trang_thai_new2 = (DI_THUONG_TRANG_THAI_NEW)queue.Dequeue();
                              di_thuong_trang_thai_new2.method_1();
                              if (this.threadSafeDictionary_1 != null)
                              {
                                    this.threadSafeDictionary_1.Remove(di_thuong_trang_thai_new2.FLD_PID);
                              }
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, string.Concat(new object[] { "NPC异常状态列表出错![", this.FLD_INDEX, "]-[", this.Name, "]", exception.Message }));
                  }
                  finally
                  {
                        queue = null;
                  }
            }

            public bool method_32(int int_9, TBL_XWWL_NPC class153_0)
            {
                  if (class153_0.Rxjh_Map != this.Rxjh_Map)
                  {
                        return false;
                  }
                  float num = class153_0.Rxjh_Y - this.Rxjh_Y;
                  float single1 = class153_0.Rxjh_X - this.Rxjh_X;
                  return (((int)Math.Sqrt((double)((single1 * single1) + (num * num)))) <= int_9);
            }

            public bool method_33(int int_9, Players class15_0)
            {
                  if (class15_0.NHAN_VAT_HP <= 0L)
                  {
                        return false;
                  }
                  if (class15_0.CharacterCoords_Map != this.Rxjh_Map)
                  {
                        return false;
                  }
                  if (class15_0.CharacterCoords_Map == 0x1bbd)
                  {
                        int_9 = 0x3e8;
                  }
                  float num = class15_0.CharacterCoords_Y - this.Rxjh_Y;
                  float single1 = class15_0.CharacterCoords_X - this.Rxjh_X;
                  return (((int)Math.Sqrt((double)((single1 * single1) + (num * num)))) <= int_9);
            }

            public bool method_34(int int_9, Players class15_0)
            {
                  if (class15_0.CharacterCoords_Map != this.Rxjh_Map)
                  {
                        return false;
                  }
                  if (class15_0.CharacterCoords_Map == 0x1bbd)
                  {
                        int_9 = 0x3e8;
                  }
                  float num = class15_0.CharacterCoords_Y - this.Rxjh_Y;
                  float single1 = class15_0.CharacterCoords_X - this.Rxjh_X;
                  return (((int)Math.Sqrt((double)((single1 * single1) + (num * num)))) <= int_9);
            }

            public bool method_35(int int_9, PET_CLASS class89_0)
            {
                  if (class89_0.NHAN_VAT_TOA_DO_MAP != this.Rxjh_Map)
                  {
                        return false;
                  }
                  float num = class89_0.NHAN_VAT_TOA_DO_Y - this.Rxjh_Y;
                  float single1 = class89_0.NHAN_VAT_TOA_DO_X - this.Rxjh_X;
                  return (((int)Math.Sqrt((double)((single1 * single1) + (num * num)))) <= int_9);
            }

            public bool method_36()
            {
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "NpcClass_获取范围玩家");
                  }
                  try
                  {
                        using (IEnumerator<Players> enumerator = World.allConnectedChars.Values.GetEnumerator())
                        {
                              Players current;
                              while (enumerator.MoveNext())
                              {
                                    current = enumerator.Current;
                                    if (((this.Level >= (current.Player_FLD_LEVEL - 20)) && (current.NHAN_VAT_HP > 0L)) && this.method_33(60, current))
                                    {
                                          goto Label_005D;
                                    }
                              }
                              goto Label_0077;
                              Label_005D:
                              this.method_3(current);
                              return true;
                        }
                  }
                  catch (Exception)
                  {
                        return false;
                  }
                  Label_0077:
                  return false;
            }

            public void method_37(byte[] byte_0, int int_9)
            {
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "NpcClass_广播数据2");
                  }
                  try
                  {
                        Queue queue = Queue.Synchronized(new Queue());
                        foreach (Players players in this.threadSafeDictionary_0.Values)
                        {
                              queue.Enqueue(players);
                        }
                        while (queue.Count > 0)
                        {
                              if (World.jlMsg == 1)
                              {
                                    Form1.WriteLine(0, "广播数据2");
                              }
                              Players players2 = (Players)queue.Dequeue();
                              if (players2.Client != null)
                              {
                                    if (players2.Client.Running)
                                    {
                                          players2.Client.Send(byte_0, int_9);
                                    }
                                    else
                                    {
                                          players2.Client.Dispose();
                                          this.threadSafeDictionary_0.Remove(players2.UserSessionID);
                                    }
                              }
                              if (!World.allConnectedChars.ContainsKey(players2.Client.int_3))
                              {
                                    Form1.WriteLine(2, "NPC 广播数据 删除卡号人物：[" + players2.Userid + "] [" + players2.UserName + "]");
                                    if (players2.Client != null)
                                    {
                                          players2.Client.Dispose();
                                    }
                                    this.threadSafeDictionary_0.Remove(players2.UserSessionID);
                              }
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "NPC广播数据2 出错2：" + exception);
                  }
            }

            public void method_4()
            {
                  if (this.list_0.Count > 0)
                  {
                        this.list_0.Clear();
                  }
            }

            public void method_5()
            {
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "NpcClass_获取范围玩家发送增加数据包");
                  }
                  try
                  {
                        foreach (Players players in World.allConnectedChars.Values)
                        {
                              if (this.method_34(400, players))
                              {
                                    players.BAT_GIU_KIEM_TRA_LAI_NPC();
                              }
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "获取范围玩家发送地面增加Npc数据包 出错：" + exception);
                  }
            }

            public void method_6()
            {
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "NpcClass_获取范围玩家发送消失数据包");
                  }
                  try
                  {
                        Queue queue = Queue.Synchronized(new Queue());
                        try
                        {
                              foreach (Players players in this.threadSafeDictionary_0.Values)
                              {
                                    queue.Enqueue(players);
                              }
                        }
                        catch (Exception exception)
                        {
                              Form1.WriteLine(1, "NPC 获取范围玩家发送消失数据包1 出错：" + exception);
                        }
                        while (queue.Count > 0)
                        {
                              if (World.jlMsg == 1)
                              {
                                    Form1.WriteLine(0, "获取范围玩家发送消失数据包");
                              }
                              Players players2 = (Players)queue.Dequeue();
                              try
                              {
                                    players2.BAT_GIU_KIEM_TRA_LAI_NPC();
                              }
                              catch (Exception exception2)
                              {
                                    Form1.WriteLine(1, "NPC 获取范围玩家发送消失数据包2 出错：" + exception2);
                              }
                        }
                        this.threadSafeDictionary_0.Clear();
                  }
                  catch (Exception exception3)
                  {
                        Form1.WriteLine(1, "NPC 获取范围玩家发送消失数据包3 出错：" + exception3);
                  }
            }

            public void method_7()
            {
                  if (this.threadSafeDictionary_0.Count > 0)
                  {
                        Form1.WriteLine(2, this.string_0 + " 人物：" + this.threadSafeDictionary_0.Count);
                        if (this.timer_0 != null)
                        {
                              Form1.WriteLine(2, this.string_0 + " 人物_自动移动：" + this.timer_0.Enabled.ToString());
                        }
                        if (this.timer_1 != null)
                        {
                              Form1.WriteLine(2, this.string_0 + " 人物_自动攻击：" + this.timer_1.Enabled.ToString());
                        }
                        if (this.timer_2 != null)
                        {
                              Form1.WriteLine(2, this.string_0 + " 人物_自动复活：" + this.timer_2.Enabled.ToString());
                        }
                  }
                  if (this.dictionary_0.Count > 0)
                  {
                        Form1.WriteLine(2, this.string_0 + " NPC：" + this.dictionary_0.Count);
                  }
                  if (this.list_0.Count > 0)
                  {
                        Form1.WriteLine(2, this.string_0 + " 攻击：" + this.list_0.Count);
                  }
            }

            public long method_8()
            {
                  int num = this.Rxjh_Exp * World.Kinh_nghiem_boi_so;
                  int num2 = num / 3;
                  return (long)this.random_2.Next(num - num2, num + num2);
            }

            public int method_9()
            {
                  int num = this.Level * World.Tien_boi_so;
                  int num2 = num / 3;
                  return this.random_2.Next(num - num2, num + num2);
            }

            public static void smethod_0(Dictionary<int, TBL_XWWL_NPC> dictionary_1, Players class15_0)
            {
                  if ((dictionary_1 != null) && (dictionary_1.Count > 0))
                  {
                        using (PacketData data = new PacketData())
                        {
                              data.Write4(dictionary_1.Count);
                              foreach (TBL_XWWL_NPC tbl_xwwl_npc in dictionary_1.Values)
                              {
                                    data.Write2(tbl_xwwl_npc.FLD_INDEX);
                                    data.Write2(tbl_xwwl_npc.FLD_INDEX);
                                    data.Write2(tbl_xwwl_npc.FLD_PID);
                                    data.Write4(1);
                                    data.Write4((int)tbl_xwwl_npc.Rxjh_HP);
                                    data.Write4((int)tbl_xwwl_npc.Max_Rxjh_HP);
                                    data.method_1(tbl_xwwl_npc.Rxjh_X);
                                    data.method_1(tbl_xwwl_npc.Rxjh_Z);
                                    data.method_1(tbl_xwwl_npc.Rxjh_Y);
                                    data.Write4(0x40800000);
                                    data.method_1(tbl_xwwl_npc.FLD_FACE1);
                                    data.method_1(tbl_xwwl_npc.FLD_FACE2);
                                    data.method_1(tbl_xwwl_npc.Rxjh_X);
                                    data.method_1(tbl_xwwl_npc.Rxjh_Z);
                                    data.method_1(tbl_xwwl_npc.Rxjh_Y);
                                    data.Write4(0);
                                    data.Write4(0);
                                    data.Write4(12);
                                    data.Write4(0);
                                    if (tbl_xwwl_npc.NPC_TU_VONG)
                                    {
                                          tbl_xwwl_npc.method_14(class15_0);
                                          tbl_xwwl_npc.method_16(class15_0);
                                    }
                              }
                              if (class15_0.Client != null)
                              {
                                    class15_0.Client.method_5(data, 0x6700, class15_0.UserSessionID, 0);
                              }
                        }
                  }
            }

            public static void smethod_1(Dictionary<int, TBL_XWWL_NPC> dictionary_1, Players class15_0)
            {
                  if ((dictionary_1 != null) && (dictionary_1.Count > 0))
                  {
                        using (PacketData data = new PacketData())
                        {
                              data.Write4(dictionary_1.Count);
                              foreach (TBL_XWWL_NPC tbl_xwwl_npc in dictionary_1.Values)
                              {
                                    data.Write2(tbl_xwwl_npc.FLD_INDEX);
                                    data.Write2(tbl_xwwl_npc.FLD_INDEX);
                                    data.Write2(tbl_xwwl_npc.FLD_PID);
                                    data.Write4(1);
                                    data.Write4((int)tbl_xwwl_npc.Rxjh_HP);
                                    data.Write4((int)tbl_xwwl_npc.Max_Rxjh_HP);
                                    data.method_1(tbl_xwwl_npc.Rxjh_X);
                                    data.method_1(tbl_xwwl_npc.Rxjh_Z);
                                    data.method_1(tbl_xwwl_npc.Rxjh_Y);
                                    data.Write4(0x40800000);
                                    data.method_1(tbl_xwwl_npc.FLD_FACE1);
                                    data.method_1(tbl_xwwl_npc.FLD_FACE2);
                                    data.method_1(tbl_xwwl_npc.Rxjh_X);
                                    data.method_1(tbl_xwwl_npc.Rxjh_Z);
                                    data.method_1(tbl_xwwl_npc.Rxjh_Y);
                                    data.Write4(0);
                                    data.Write4(0);
                                    data.Write4(12);
                                    data.Write4(0);
                              }
                              if (class15_0.Client != null)
                              {
                                    class15_0.Client.method_5(data, 0x6800, class15_0.UserSessionID, 0);
                              }
                        }
                  }
            }

            private void timer_0_Elapsed(object sender, ElapsedEventArgs e)
            {
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "自动移动事件");
                  }
                  try
                  {
                        if (this.IsNpc != 0)
                        {
                              this.timer_0.Enabled = false;
                        }
                        else
                        {
                              this.method_4();
                              if ((this.dictionary_0 != null) && (this.dictionary_0.Count > 0))
                              {
                                    this.dictionary_0.Clear();
                              }
                              if (((this.threadSafeDictionary_0 == null) || (this.threadSafeDictionary_0.Count >= 1)) && !this.NPC_TU_VONG)
                              {
                                    if ((this.IsNpc != 1) && (this.FLD_AT > 0.0))
                                    {
                                          int num = new Random(DateTime.Now.Millisecond).Next(0xbb8, 0x3a98);
                                          this.timer_0.Interval = num;
                                          if ((this.FLD_AUTO == 1) && this.method_36())
                                          {
                                                this.timer_0.Enabled = false;
                                                this.timer_1.Enabled = true;
                                                if (this.Rxjh_HP > 0L)
                                                {
                                                      QuestItemBool = false;
                                                }
                                          }
                                          else
                                          {
                                                this.method_19(this.Rxjh_cs_X, this.Rxjh_cs_Y, 50, 1);
                                          }
                                    }
                                    else
                                    {
                                          this.timer_0.Interval = 20000.0;
                                          foreach (Players players in this.threadSafeDictionary_0.Values)
                                          {
                                                if (players.Client != null)
                                                {
                                                      if (!World.allConnectedChars.ContainsKey(players.Client.int_3))
                                                      {
                                                            this.arrayList_0.Add(players);
                                                      }
                                                }
                                                else
                                                {
                                                      this.arrayList_0.Add(players);
                                                }
                                          }
                                          foreach (Players players2 in this.arrayList_0)
                                          {
                                                Form1.WriteLine(2, "NPC广播数据 删除卡号人物：[" + players2.Userid + "] [" + players2.UserName + "]");
                                                if (players2.Client != null)
                                                {
                                                      players2.Client.Dispose();
                                                }
                                                this.threadSafeDictionary_0.Remove(players2.UserSessionID);
                                          }
                                          this.arrayList_0.Clear();
                                    }
                              }
                        }
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "自动移动事件 出错：" + exception);
                  }
            }

            private void timer_1_Elapsed(object sender, ElapsedEventArgs e)
            {                  
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "自动攻击事件");
                  }
                  try
                  {
                        if (this.IsNpc != 0)
                        {
                              this.timer_1.Enabled = false;
                        }
                        else if (this.Rxjh_HP < 0L)
                        {
                              this.timer_1.Enabled = false;
                        }
                        else if (this.FLD_AT > 0.0)
                        {
                              Players players;
                              int num = (int)this.FLD_AT;
                              Random random = new Random(DateTime.Now.Millisecond);
                              int num2 = random.Next(0x3e8, 0xbb8);
                              Random random2 = new Random();
                              this.timer_1.Interval = num2;
                              num = random.Next(num - 8, num + 8);
                              if (World.allConnectedChars.TryGetValue(this.PlayerWid, out players))
                              {
                                    if (players.NHAN_VAT_HP <= 0L)
                                    {
                                          Form1.WriteLine(0, "timer_1_Elapsed false");
                                          this.timer_1.Enabled = false;
                                          this.timer_0.Enabled = true;
                                          this.Rxjh_X = this.Rxjh_cs_X;
                                          this.Rxjh_Y = this.Rxjh_cs_Y;
                                          this.Rxjh_Z = this.Rxjh_cs_Z;
                                          this.method_19(this.Rxjh_cs_X, this.Rxjh_cs_Y, 50, 1);
                                    }
                                    else
                                    {
                                          if ((players.int_113 != 0) && (random.Next(0, 80) <= players.int_113))
                                          {
                                                players.Show_Char(this.PlayerWid, 0x195);
                                          }
                                          double num3 = players.FLD_BasicCharDefense;
                                          bool flag = false;
                                          if (((players.Player_Job == 3) && (players.Thuong_khach_Chuyen_cong_vi_thu != 0.0)) && (random.Next(0, 0x8d) <= players.Thuong_khach_Chuyen_cong_vi_thu))
                                          {
                                                players.Show_Char(this.PlayerWid, 130);
                                                num3 += players.FLD_ATTACK;
                                          }
                                          if (players.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[0].ItemPropertyType == 1)
                                          {
                                                num -= (int)(num * (players.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[0].ItemPropertyNumber * 0.01));
                                          }
                                          if (num <= num3)
                                          {
                                                num = 1;
                                          }
                                          else
                                          {
                                                num -= (int)num3;
                                          }
                                          if (this.method_33(15, players))
                                          {
                                                Form1.WriteLine(0, "timer_1_Elapsed 1");
                                                if ((players.Player_Job == 2) || (players.Player_Job == 9))
                                                {
                                                      double num4 = num;
                                                      if ((players.Kiem_khach_Ho_than_cuong_khi != 0.0) && (random.Next(0, 0x79) <= players.Kiem_khach_Ho_than_cuong_khi))
                                                      {
                                                            num = (int)(num4 * 0.5);
                                                            players.Show_Char(this.PlayerWid, 0x19);
                                                      }
                                                      if ((players.Bach_bien_than_hanh != 0.0) && ((random.NextDouble() * World.KHI_CONG_TI_LE_PHAN_TRAM) <= players.Bach_bien_than_hanh))
                                                      {
                                                            num = 0;
                                                      }
                                                }
                                                if (((players.Player_Job == 6) && (players.Thich_khach_Tam_hoa_tu_dinh != 0.0)) && ((random.NextDouble() * World.KHI_CONG_TI_LE_PHAN_TRAM) <= players.Thich_khach_Tam_hoa_tu_dinh))
                                                {
                                                      players.double_114 = num * players.Thich_khach_Lien_tieu_dai_da;
                                                      num = 0;
                                                }
                                                if ((players.int_114 != 0) && (random.Next(0, 80) <= players.int_114))
                                                {
                                                      Form1.WriteLine(1, "timer_1_Elapsed 2");
                                                      players.Show_Char(this.PlayerWid, 0x196);
                                                      players.NHAN_VAT_MP += num;
                                                      players.UpdateHP_MP_SP();
                                                }
                                                else
                                                {
                                                      Form1.WriteLine(1, "timer_1_Elapsed 3");
                                                      if (players.Thanh_vien_thu_bac != 0)
                                                      {
                                                            this.method_20(0, 0x1c, players.UserSessionID);
                                                      }
                                                      else
                                                      {
                                                            this.method_20(num, 0x1c, players.UserSessionID);
                                                            players.NHAN_VAT_HP -= num;
                                                      }
                                                      if (((players.Kiem_khach_thang_thien_3_khi_cong_Hoa_phuong_lam_trieu != 0.0) || (players.Player_Job == 9)) && ((random.Next(0, 120) <= players.Kiem_khach_thang_thien_3_khi_cong_Hoa_phuong_lam_trieu) && (players.NHAN_VAT_HP <= 0L)))
                                                      {
                                                            players.NHAN_VAT_HP = 10L;
                                                            players.Show_Char(this.PlayerWid, 0x142);
                                                      }
                                                      if (players.Player_Job == 3)
                                                      {
                                                            if (players.Thuong_khach_Cuong_than_hang_the != 0.0)
                                                            {
                                                                  players.NHAN_VAT_SP += (int)((players.Player_FLD_LEVEL * 4) * players.Thuong_khach_Cuong_than_hang_the);
                                                            }
                                                            else if (num <= num3)
                                                            {
                                                                  players.NHAN_VAT_SP++;
                                                            }
                                                            else
                                                            {
                                                                  players.NHAN_VAT_SP += 2;
                                                            }
                                                            if (players.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[0].ItemPropertyType == 2)
                                                            {
                                                                  players.NHAN_VAT_SP += players.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[0].ItemPropertyNumber * 2;
                                                            }
                                                      }
                                                      else if (players.Player_Job == 6)
                                                      {
                                                            if (players.Thich_khach_Kinh_kha_chi_no != 0.0)
                                                            {
                                                                  players.NHAN_VAT_SP += (int)(3.0 + ((players.Player_FLD_LEVEL / 2) * players.Thich_khach_Kinh_kha_chi_no));
                                                            }
                                                            else if (num <= num3)
                                                            {
                                                                  players.NHAN_VAT_SP++;
                                                            }
                                                            else
                                                            {
                                                                  players.NHAN_VAT_SP += 2;
                                                            }
                                                            if (players.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[0].ItemPropertyType == 2)
                                                            {
                                                                  players.NHAN_VAT_SP += players.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[0].ItemPropertyNumber * 2;
                                                            }
                                                      }
                                                      else if (players.Player_Job != 5)
                                                      {
                                                            if (num <= num3)
                                                            {
                                                                  players.NHAN_VAT_SP++;
                                                            }
                                                            else
                                                            {
                                                                  players.NHAN_VAT_SP += 2;
                                                            }
                                                            if (players.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[0].ItemPropertyType == 2)
                                                            {
                                                                  players.NHAN_VAT_SP += players.TRANG_BI_LAN_CHOC_THUNG_TRANG_BI[0].ItemPropertyNumber * 2;
                                                            }
                                                      }
                                                      else if (((players.Player_Job == 5) && (players.Thang_thien_1_khi_cong_Cuong_phong_thien_y != 0.0)) && ((random2.Next(0, 200) <= players.Thang_thien_1_khi_cong_Cuong_phong_thien_y) && !players.Add_Status_List.ContainsKey(0xaae6e)))
                                                      {
                                                            players.NHAN_VAT_SP = players.NHAN_VAT_LON_NHAT_SP + 1;
                                                      }
                                                      try
                                                      {
                                                            if (players.Player_Job == 7)
                                                            {
                                                                  if ((players.Cam_su_thang_thien_2_khi_cong_Tam_dam_anh_nguyet != 0.0) && (random2.Next(0, 0x65) <= players.Cam_su_thang_thien_2_khi_cong_Tam_dam_anh_nguyet))
                                                                  {
                                                                        players.Show_Char(players.UserSessionID, 0x187);
                                                                        this.method_24(num, 0);
                                                                        this.Rxjh_HP -= num;
                                                                  }
                                                            }
                                                            else if (((players.Player_Job == 1) && (players.Phan_sat_thuong_ty_le != 0.0)) && (random2.Next(0, 0x65) <= players.Phan_sat_thuong_ty_le))
                                                            {
                                                                  this.method_24(num, players.UserSessionID);
                                                                  this.Rxjh_HP -= num;
                                                            }
                                                            Form1.WriteLine(0, string.Format("timer_1_Elapsed Rxjh_HP: {0}", this.Rxjh_HP));
                                                            if (this.Rxjh_HP < 1L)
                                                            {
                                                                  Form1.WriteLine(0, "DestroyMonster Timer");
                                                                  //if (!QuestItemBool)
                                                                  //{
                                                                  //      QuestItemBool = true;
                                                                  //      this.method_23(players.UserSessionID);
                                                                  //}
                                                                  double num6 = this.method_9();
                                                                  double num7 = this.method_8();
                                                                  double num8 = this.method_10();
                                                                  if (players.FLD_VIP == 1)
                                                                  {
                                                                        num7 += num7 * World.VIP_Kinh_nghiem_boi_so_ti_le_phan_tram;
                                                                        num8 += num8 * World.VIP_ky_nang_boi_so_ti_le_phan_tram;
                                                                  }
                                                                  if (((players.TO_DOI_ID != 0) && (players.int_7 == 1)) && (players.Player_FLD_LEVEL < World.Nhan_vat_dang_cap_cao_nhat))
                                                                  {
                                                                        TO_DOI_CLASS to_doi_class;
                                                                        if (World.W_TO_DOI.TryGetValue(players.TO_DOI_ID, out to_doi_class))
                                                                        {
                                                                              double num9 = (num7 * (1.0 + (to_doi_class.dictionary_0.Count * 0.1))) / ((double)to_doi_class.dictionary_0.Count);
                                                                              double num10 = (num8 * (1.0 + (to_doi_class.dictionary_0.Count * 0.1))) / ((double)to_doi_class.dictionary_0.Count);
                                                                              double num11 = (num6 * (1.0 + (to_doi_class.dictionary_0.Count * 0.1))) / ((double)to_doi_class.dictionary_0.Count);
                                                                              foreach (Players players2 in to_doi_class.dictionary_0.Values)
                                                                              {
                                                                                    if ((this.method_34(700, players2) && (Math.Abs((int)(players2.Player_FLD_LEVEL - this.Level)) < World.Gain_experience_level_difference)) && (players.Player_FLD_LEVEL < World.Nhan_vat_dang_cap_cao_nhat))
                                                                                    {
                                                                                          players2.NHAN_VAT_KINH_NGHIEM += (long)(num9 * (1.0 + players2.NHAN_VAT_THEM_VAO_KINH_NGHIEM_TI_LE_PHAN_TRAM));
                                                                                          players2.Player_ExpErience += (int)(num10 * (1.0 + players2.FLD_nhan_vat_them_vao_kinh_nghiem_hoc_vo_cong_ti_le_phan_tram));
                                                                                          players2.Player_Money += (uint)(num11 * ((1.0 + players2.FLD_nhan_vat_them_vao_gold_ti_le_phan_tram) + players2.FLD_trang_bi_them_vao_thu_duoc_tro_choi_te_ti_le_phan_tram));
                                                                                          players2.Get_Money_Tip((uint)(num11 * ((1.0 + players2.FLD_nhan_vat_them_vao_gold_ti_le_phan_tram) + players2.FLD_trang_bi_them_vao_thu_duoc_tro_choi_te_ti_le_phan_tram)));
                                                                                          players2.Calculate_Basic_Char_Data_3();
                                                                                          players2.UpdateHP_MP_SP();
                                                                                          players2.UpdatePowersAndStatus();
                                                                                          players2.UpdateExperience();
                                                                                          players2.UpdateMoneyAndWeight();
                                                                                    }
                                                                              }
                                                                        }
                                                                  }
                                                                  else if (((players.Player_FLD_LEVEL - this.Level) < World.Gain_experience_level_difference) && (players.Player_FLD_LEVEL < World.Nhan_vat_dang_cap_cao_nhat))
                                                                  {
                                                                        players.NHAN_VAT_KINH_NGHIEM += (long)(num7 * (players.NHAN_VAT_THEM_VAO_KINH_NGHIEM_TI_LE_PHAN_TRAM + 1.0));
                                                                        players.Player_ExpErience += (int)(num8 * (players.FLD_nhan_vat_them_vao_kinh_nghiem_hoc_vo_cong_ti_le_phan_tram + 1.0));
                                                                        players.Player_Money += (uint)(num6 * ((1.0 + players.FLD_nhan_vat_them_vao_gold_ti_le_phan_tram) + players.FLD_trang_bi_them_vao_thu_duoc_tro_choi_te_ti_le_phan_tram));
                                                                        players.Get_Money_Tip((uint)(num6 * ((players.FLD_nhan_vat_them_vao_gold_ti_le_phan_tram + 1.0) + players.FLD_trang_bi_them_vao_thu_duoc_tro_choi_te_ti_le_phan_tram)));
                                                                        players.Calculate_Basic_Char_Data_3();
                                                                        players.UpdateHP_MP_SP();
                                                                        players.UpdatePowersAndStatus();
                                                                        players.UpdateExperience();
                                                                        players.UpdateMoneyAndWeight();
                                                                  }
                                                                  flag = true;
                                                            }
                                                      }
                                                      catch (Exception exception)
                                                      {
                                                            Form1.WriteLine(1, "自动攻击事件 刀反伤 出错：" + exception);
                                                      }
                                                      if (players.NHAN_VAT_HP <= 0L)
                                                      {
                                                            if ((World.Tu_vong_kinh_nghiem_roi_xuong_co_hay_khong_mo_ra == 1) && (players.Player_FLD_LEVEL > 15))
                                                            {
                                                                  double num12 = Convert.ToInt64(World.lever[players.Player_FLD_LEVEL]) - Convert.ToInt64(World.lever[players.Player_FLD_LEVEL - 1]);
                                                                  Convert.ToInt64(World.lever[players.Player_FLD_LEVEL - 1]);
                                                                  if ((!players.dictionary_3.ContainsKey(0x3c14dc1b) && !players.dictionary_3.ContainsKey(0x3c14dc1c)) && !players.dictionary_3.ContainsKey(0x3c14dc1d))
                                                                  {
                                                                        players.int_8 = 2;
                                                                        if (World.Co_hay_khong_mo_ra_Dang_cap_khen_thuong != 0)
                                                                        {
                                                                              if (players.NHAN_VAT_KINH_NGHIEM > ((num12 * 0.01) * players.int_8))
                                                                              {
                                                                                    players.NHAN_VAT_KINH_NGHIEM -= (long)((num12 * 0.01) * players.int_8);
                                                                                    if (players.NHAN_VAT_KINH_NGHIEM < (num12 * 0.01))
                                                                                    {
                                                                                          players.NHAN_VAT_KINH_NGHIEM = (long)(num12 * 0.01);
                                                                                    }
                                                                              }
                                                                        }
                                                                        else if (players.NHAN_VAT_KINH_NGHIEM > ((num12 * 0.01) * players.int_8))
                                                                        {
                                                                              players.NHAN_VAT_KINH_NGHIEM -= (long)((num12 * 0.01) * players.int_8);
                                                                              if (players.NHAN_VAT_KINH_NGHIEM < (num12 * 0.01))
                                                                              {
                                                                                    players.NHAN_VAT_KINH_NGHIEM = (long)(num12 * 0.01);
                                                                              }
                                                                        }
                                                                        players.UpdateExperience();
                                                                  }
                                                                  else
                                                                  {
                                                                        if (players.int_8 != 0)
                                                                        {
                                                                              players.int_8 = 0;
                                                                        }
                                                                        if (World.Co_hay_khong_mo_ra_Dang_cap_khen_thuong != 0)
                                                                        {
                                                                              if (players.NHAN_VAT_KINH_NGHIEM > (num12 * 0.01))
                                                                              {
                                                                                    players.NHAN_VAT_KINH_NGHIEM -= (long)(num12 * 0.01);
                                                                                    if (players.NHAN_VAT_KINH_NGHIEM < (num12 * 0.01))
                                                                                    {
                                                                                          players.NHAN_VAT_KINH_NGHIEM = (long)(num12 * 0.01);
                                                                                    }
                                                                              }
                                                                        }
                                                                        else if (players.NHAN_VAT_KINH_NGHIEM > ((long)(num12 * 0.01)))
                                                                        {
                                                                              players.NHAN_VAT_KINH_NGHIEM -= (long)(num12 * 0.01);
                                                                              if (players.NHAN_VAT_KINH_NGHIEM < (num12 * 0.01))
                                                                              {
                                                                                    players.NHAN_VAT_KINH_NGHIEM = (long)(num12 * 0.01);
                                                                              }
                                                                        }
                                                                        players.UpdateExperience();
                                                                  }
                                                            }
                                                            this.timer_1.Enabled = false;
                                                            this.timer_0.Enabled = true;
                                                            this.Rxjh_X = this.Rxjh_cs_X;
                                                            this.Rxjh_Y = this.Rxjh_cs_Y;
                                                            this.Rxjh_Z = this.Rxjh_cs_Z;
                                                            this.method_19(this.Rxjh_cs_X, this.Rxjh_cs_Y, 50, 1);
                                                            this.method_4();
                                                            players.NHAN_VAT_HP = 0L;
                                                            players.Dead();
                                                            players.UpdateHP_MP_SP();
                                                      }
                                                      else
                                                      {
                                                            players.UpdateHP_MP_SP();
                                                      }
                                                      if (flag)
                                                      {
                                                            this.DestroyMonsterScript(players.UserSessionID);
                                                            Form1.WriteLine(1, "DestroyMonsterScript TBL_XWWL_NPC timer1");
                                                      }
                                                }
                                          }
                                          else if (this.method_33(80, players))
                                          {
                                                this.method_19(players.CharacterCoords_X, players.CharacterCoords_Y, 10, 2);
                                          }
                                          else
                                          {
                                                this.method_4();
                                                this.timer_1.Enabled = false;
                                                this.timer_0.Enabled = true;
                                                this.Rxjh_X = this.Rxjh_cs_X;
                                                this.Rxjh_Y = this.Rxjh_cs_Y;
                                                this.Rxjh_Z = this.Rxjh_cs_Z;
                                                this.method_19(this.Rxjh_cs_X, this.Rxjh_cs_Y, 50, 1);
                                          }
                                    }
                              }
                              else
                              {
                                    this.method_4();
                                    this.timer_1.Enabled = false;
                                    this.timer_0.Enabled = true;
                                    this.Rxjh_X = this.Rxjh_cs_X;
                                    this.Rxjh_Y = this.Rxjh_cs_Y;
                                    this.Rxjh_Z = this.Rxjh_cs_Z;
                                    this.method_19(this.Rxjh_cs_X, this.Rxjh_cs_Y, 50, 1);
                              }
                        }
                  }
                  catch (Exception exception2)
                  {
                        this.method_4();
                        this.timer_1.Enabled = false;
                        this.timer_0.Enabled = true;
                        this.Rxjh_X = this.Rxjh_cs_X;
                        this.Rxjh_Y = this.Rxjh_cs_Y;
                        this.Rxjh_Z = this.Rxjh_cs_Z;
                        this.method_19(this.Rxjh_cs_X, this.Rxjh_cs_Y, 50, 1);
                        Form1.WriteLine(1, "自动攻击事件 出错：" + exception2);
                  }
            }

            private void timer_2_Elapsed(object sender, ElapsedEventArgs e)
            {
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "自动复活事件");
                  }
                  try
                  {
                        if (this.IsNpc == 1)
                        {
                              this.timer_2.Enabled = false;
                        }
                        else
                        {
                              this.timer_0.Enabled = true;
                              if (this.NPC_TU_VONG)
                              {
                                    this.method_15();
                              }
                        }
                  }
                  catch (Exception exception)
                  {
                        if (this.timer_2 != null)
                        {
                              this.timer_2.Enabled = false;
                              this.timer_2.Close();
                              this.timer_2.Dispose();
                              this.timer_2 = null;
                        }
                        Form1.WriteLine(1, "自动复活事件1 出错：" + exception);
                  }
                  finally
                  {
                        if (this.timer_2 != null)
                        {
                              this.timer_2.Enabled = false;
                              this.timer_2.Close();
                              this.timer_2.Dispose();
                              this.timer_2 = null;
                        }
                  }
            }

            private static void ZYDNGuard()
            {
                  class152_0 = new PlayGjClass();
                  random_1 = new Random(DateTime.Now.Millisecond);
                  object_4 = new object();
            }

            public double FLD_AT
            {
                  get
                  {
                        return this.double_0;
                  }
                  set
                  {
                        this.double_0 = value;
                  }
            }

            public int FLD_AUTO
            {
                  get
                  {
                        return this.int_6;
                  }
                  set
                  {
                        this.int_6 = value;
                  }
            }

            public int FLD_BOSS
            {
                  get
                  {
                        return this.int_7;
                  }
                  set
                  {
                        this.int_7 = value;
                  }
            }

            public double FLD_DF
            {
                  get
                  {
                        return this.double_1;
                  }
                  set
                  {
                        this.double_1 = value;
                  }
            }

            public float FLD_FACE1
            {
                  get
                  {
                        return this.float_0;
                  }
                  set
                  {
                        this.float_0 = value;
                  }
            }

            public float FLD_FACE2
            {
                  get
                  {
                        return this.float_1;
                  }
                  set
                  {
                        this.float_1 = value;
                  }
            }

            public int FLD_INDEX
            {
                  get
                  {
                        return this.int_1;
                  }
                  set
                  {
                        this.int_1 = value;
                  }
            }

            public int FLD_NEWTIME
            {
                  get
                  {
                        return this.int_8;
                  }
                  set
                  {
                        this.int_8 = value;
                  }
            }

            public int FLD_PID
            {
                  get
                  {
                        return this.int_2;
                  }
                  set
                  {
                        this.int_2 = value;
                  }
            }

            public int IsNpc
            {
                  get
                  {
                        return this.int_0;
                  }
                  set
                  {
                        this.int_0 = value;
                  }
            }

            public int Level
            {
                  get
                  {
                        return this.int_5;
                  }
                  set
                  {
                        this.int_5 = value;
                  }
            }

            public long Max_Rxjh_HP
            {
                  get
                  {
                        return this.long_0;
                  }
                  set
                  {
                        this.long_0 = value;
                  }
            }

            public string Name
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

            public bool NPC_TU_VONG
            {
                  get
                  {
                        return this.bool_0;
                  }
                  set
                  {
                        this.bool_0 = value;
                  }
            }

            public int PlayerWid
            {
                  get
                  {
                        if (this.list_0.Count <= 0)
                        {
                              return 0;
                        }
                        try
                        {
                              this.list_0.Sort(this.class106_0);
                              return this.list_0[0].PlayID;
                        }
                        catch (Exception)
                        {
                              return 0;
                        }
                  }
            }

            public float Rxjh_cs_X
            {
                  get
                  {
                        return this.float_5;
                  }
                  set
                  {
                        this.float_5 = value;
                  }
            }

            public float Rxjh_cs_Y
            {
                  get
                  {
                        return this.float_6;
                  }
                  set
                  {
                        this.float_6 = value;
                  }
            }

            public float Rxjh_cs_Z
            {
                  get
                  {
                        return this.float_7;
                  }
                  set
                  {
                        this.float_7 = value;
                  }
            }

            public int Rxjh_Exp
            {
                  get
                  {
                        return this.int_4;
                  }
                  set
                  {
                        this.int_4 = value;
                  }
            }

            public long Rxjh_HP
            {
                  get
                  {
                        return this.long_1;
                  }
                  set
                  {
                        this.long_1 = value;
                  }
            }

            public int Rxjh_Map
            {
                  get
                  {
                        return this.int_3;
                  }
                  set
                  {
                        this.int_3 = value;
                  }
            }

            public float Rxjh_X
            {
                  get
                  {
                        return this.float_2;
                  }
                  set
                  {
                        this.float_2 = value;
                  }
            }

            public float Rxjh_Y
            {
                  get
                  {
                        return this.float_3;
                  }
                  set
                  {
                        this.float_3 = value;
                  }
            }

            public float Rxjh_Z
            {
                  get
                  {
                        return this.float_4;
                  }
                  set
                  {
                        this.float_4 = value;
                  }
            }

            public bool 一次性怪
            {
                  get
                  {
                        return this.bool_1;
                  }
                  set
                  {
                        this.bool_1 = value;
                  }
            }
      }
}

