namespace ns2
{
      using ns13;
      using ns3;
      using ns6;
      using ns9;
      using RxjhServer;
      using System;
      using System.Collections;
      using System.Collections.Generic;
      using System.Diagnostics;
      using System.IO;
      using System.Threading;

      internal class TimerClass
      {
            private bool bool_0;
            private bool bool_1;
            private DateTime dateTime_0;
            private static Dictionary<string, TimerProfile> dictionary_0;
            private int int_0;
            private int int_1;
            private static int int_2;
            private static int int_3;
            private List<TimerClass> list_0;
            private static Queue<TimerClass> queue_0;
            private TimerPriority timerPriority_0;
            private TimeSpan timeSpan_0;
            private TimeSpan timeSpan_1;

            static TimerClass()
            {
                  ZYDNGuard();
            }

            public TimerClass(TimeSpan delay) : this(delay, TimeSpan.Zero, 1)
            {
            }

            public TimerClass(TimeSpan delay, TimeSpan interval) : this(delay, interval, 0)
            {
            }

            public TimerClass(TimeSpan delay, TimeSpan interval, int count)
            {
                  this.timeSpan_0 = delay;
                  this.timeSpan_1 = interval;
                  this.int_1 = count;
                  if (this.DefRegCreation)
                  {
                        this.vmethod_0();
                  }
            }

            public TimerProfile method_0()
            {
                  string key = this.ToString();
                  if (key == null)
                  {
                        key = "null";
                  }
                  TimerProfile profile = null;
                  dictionary_0.TryGetValue(key, out profile);
                  if (profile == null)
                  {
                        dictionary_0[key] = profile = new TimerProfile();
                  }
                  return profile;
            }

            public void method_1()
            {
                  if (!this.bool_0)
                  {
                        this.bool_0 = true;
                        Class128.smethod_2(this);
                        TimerProfile profile = this.method_0();
                        if (profile != null)
                        {
                              profile.method_1();
                        }
                  }
            }

            public void method_2()
            {
                  if (this.bool_0)
                  {
                        this.bool_0 = false;
                        Class128.smethod_4(this);
                        TimerProfile profile = this.method_0();
                        if (profile != null)
                        {
                              profile.method_2();
                        }
                  }
            }

            public static void Slice()
            {
                  Queue<TimerClass> queue = queue_0;
                  lock (queue)
                  {
                        int_3 = queue_0.Count;
                        int num = 0;
                        Stopwatch stopwatch = null;
                        while (num < int_2)
                        {
                              if (queue_0.Count == 0)
                              {
                                    break;
                              }
                              if (World.jlMsg == 1)
                              {
                                    Form1.WriteLine(0, "Slice");
                              }
                              TimerClass local1 = queue_0.Dequeue();
                              TimerProfile profile = local1.method_0();
                              if (profile != null)
                              {
                                    if (stopwatch == null)
                                    {
                                          stopwatch = Stopwatch.StartNew();
                                    }
                                    else
                                    {
                                          stopwatch.Start();
                                    }
                              }
                              local1.vmethod_1();
                              local1.bool_1 = false;
                              num++;
                              if (profile != null)
                              {
                                    profile.method_3(stopwatch.Elapsed);
                                    stopwatch.Reset();
                              }
                        }
                  }
            }

            private static string smethod_0(Delegate delegate_0)
            {
                  if (delegate_0 == null)
                  {
                        return "null";
                  }
                  return $"{delegate_0.Method.DeclaringType.FullName}.{delegate_0.Method.Name}";
            }

            public static void smethod_1(TextWriter textWriter_0)
            {
                  Class128.smethod_0(textWriter_0);
            }

            public static TimerPriority smethod_3(TimeSpan timeSpan_2)
            {
                  if (timeSpan_2 >= TimeSpan.FromMinutes(1.0))
                  {
                        return TimerPriority.FiveSeconds;
                  }
                  if (timeSpan_2 >= TimeSpan.FromSeconds(10.0))
                  {
                        return TimerPriority.OneSecond;
                  }
                  if (timeSpan_2 >= TimeSpan.FromSeconds(5.0))
                  {
                        return TimerPriority.TwoFiftyMS;
                  }
                  if (timeSpan_2 >= TimeSpan.FromSeconds(2.5))
                  {
                        return TimerPriority.FiftyMS;
                  }
                  if (timeSpan_2 >= TimeSpan.FromSeconds(1.0))
                  {
                        return TimerPriority.TwentyFiveMS;
                  }
                  if (timeSpan_2 >= TimeSpan.FromSeconds(0.5))
                  {
                        return TimerPriority.TenMS;
                  }
                  return TimerPriority.EveryTick;
            }

            public static TimerClass smethod_4(TimeSpan timeSpan_2, Delegate10 delegate10_0) =>
                smethod_6(timeSpan_2, TimeSpan.Zero, 1, delegate10_0);

            public static TimerClass smethod_5(TimeSpan timeSpan_2, TimeSpan timeSpan_3, Delegate10 delegate10_0) =>
                smethod_6(timeSpan_2, timeSpan_3, 0, delegate10_0);

            public static TimerClass smethod_6(TimeSpan timeSpan_2, TimeSpan timeSpan_3, int int_4, Delegate10 delegate10_0)
            {
                  TimerClass class2 = new Class126(timeSpan_2, timeSpan_3, int_4, delegate10_0);
                  if (int_4 == 1)
                  {
                        class2.Priority = smethod_3(timeSpan_2);
                  }
                  else
                  {
                        class2.Priority = smethod_3(timeSpan_3);
                  }
                  class2.method_1();
                  return class2;
            }

            public static TimerClass smethod_7(TimeSpan timeSpan_2, Delegate11 delegate11_0, object object_0) =>
                smethod_9(timeSpan_2, TimeSpan.Zero, 1, delegate11_0, object_0);

            public static TimerClass smethod_8(TimeSpan timeSpan_2, TimeSpan timeSpan_3, Delegate11 delegate11_0, object object_0) =>
                smethod_9(timeSpan_2, timeSpan_3, 0, delegate11_0, object_0);

            public static TimerClass smethod_9(TimeSpan timeSpan_2, TimeSpan timeSpan_3, int int_4, Delegate11 delegate11_0, object object_0)
            {
                  TimerClass class2 = new Class127(timeSpan_2, timeSpan_3, int_4, delegate11_0, object_0);
                  if (int_4 == 1)
                  {
                        class2.Priority = smethod_3(timeSpan_2);
                  }
                  else
                  {
                        class2.Priority = smethod_3(timeSpan_3);
                  }
                  class2.method_1();
                  return class2;
            }

            public override string ToString() =>
                base.GetType().FullName;

            public virtual void vmethod_0()
            {
                  TimerProfile profile = this.method_0();
                  if (profile != null)
                  {
                        profile.method_0();
                  }
            }

            protected virtual void vmethod_1()
            {
            }

            private static void ZYDNGuard()
            {
                  dictionary_0 = new Dictionary<string, TimerProfile>();
                  queue_0 = new Queue<TimerClass>();
                  int_2 = 0x4e20;
            }

            public static int BreakCount
            {
                  get
                  {
                        return int_2;
                  }
                  set
                  {
                        int_2 = value;
                  }
            }

            public virtual bool DefRegCreation =>
                true;

            public TimeSpan Delay
            {
                  get
                  {
                        return this.timeSpan_0;
                  }
                  set
                  {
                        this.timeSpan_0 = value;
                  }
            }

            public TimeSpan Interval
            {
                  get
                  {
                        return this.timeSpan_1;
                  }
                  set
                  {
                        this.timeSpan_1 = value;
                  }
            }

            public DateTime Next =>
                this.dateTime_0;

            public TimerPriority Priority
            {
                  get
                  {
                        return this.timerPriority_0;
                  }
                  set
                  {
                        if (this.timerPriority_0 != value)
                        {
                              this.timerPriority_0 = value;
                              if (this.bool_0)
                              {
                                    Class128.smethod_3(this, (int)this.timerPriority_0);
                              }
                        }
                  }
            }

            public static Dictionary<string, TimerProfile> Profiles =>
                dictionary_0;

            public bool Running
            {
                  get
                  {
                        return this.bool_0;
                  }
                  set
                  {
                        if (value)
                        {
                              this.method_1();
                        }
                        else
                        {
                              this.method_2();
                        }
                  }
            }

            private class Class126: TimerClass
            {
                  private Delegate10 delegate10_0;

                  public Class126(TimeSpan delay, TimeSpan interval, int count, Delegate10 callback) : base(delay, interval, count)
                  {
                        this.delegate10_0 = callback;
                        this.vmethod_0();
                  }

                  public override string ToString() =>
                      $"DelayCallTimer[{TimerClass.smethod_0(this.delegate10_0)}]";

                  protected override void vmethod_1()
                  {
                        if (this.delegate10_0 != null)
                        {
                              this.delegate10_0();
                        }
                  }

                  public Delegate10 Callback =>
                      this.delegate10_0;

                  public override bool DefRegCreation =>
                      false;
            }

            private class Class127: TimerClass
            {
                  private Delegate11 delegate11_0;
                  private object object_0;

                  public Class127(TimeSpan delay, TimeSpan interval, int count, Delegate11 callback, object state) : base(delay, interval, count)
                  {
                        this.delegate11_0 = callback;
                        this.object_0 = state;
                        this.vmethod_0();
                  }

                  public override string ToString() =>
                      $"DelayStateCall[{TimerClass.smethod_0(this.delegate11_0)}]";

                  protected override void vmethod_1()
                  {
                        if (this.delegate11_0 != null)
                        {
                              this.delegate11_0(this.object_0);
                        }
                  }

                  public Delegate11 Callback =>
                      this.delegate11_0;

                  public override bool DefRegCreation =>
                      false;
            }

            public class Class128
            {
                  private static DateTime[] dateTime_0;
                  private static List<TimerClass>[] list_0;
                  private static Queue queue_0;
                  private static TimeSpan[] timeSpan_0;

                  static Class128()
                  {
                        ZYDNGuard();
                  }

                  public void method_0()
                  {
                        while (true)
                        {
                              if (World.jlMsg == 1)
                              {
                                    Form1.WriteLine(0, "TimerMain");
                              }
                              Thread.Sleep(10);
                              smethod_5();
                              for (int i = 0; i < list_0.Length; i++)
                              {
                                    DateTime now = DateTime.Now;
                                    if (now < dateTime_0[i])
                                    {
                                          break;
                                    }
                                    dateTime_0[i] = now + timeSpan_0[i];
                                    for (int j = 0; j < list_0[i].Count; j++)
                                    {
                                          TimerClass item = list_0[i][j];
                                          if (item.bool_1 || (now <= item.dateTime_0))
                                          {
                                                continue;
                                          }
                                          item.bool_1 = true;
                                          Queue<TimerClass> queue = TimerClass.queue_0;
                                          lock (queue)
                                          {
                                                TimerClass.queue_0.Enqueue(item);
                                                if (item.int_1 == 0)
                                                {
                                                      goto Label_00DE;
                                                }
                                          }
                                          int num3 = item.int_0 + 1;
                                          item.int_0 = num3;
                                          if (num3 >= item.int_1)
                                          {
                                                item.method_2();
                                                continue;
                                          }
                                          Label_00DE:
                                          item.dateTime_0 = now + item.timeSpan_1;
                                    }
                              }
                        }
                  }

                  public static void smethod_0(TextWriter textWriter_0)
                  {
                        for (int i = 0; i < 8; i++)
                        {
                              textWriter_0.WriteLine("Priority: {0}", (TimerPriority)i);
                              textWriter_0.WriteLine();
                              Dictionary<string, List<TimerClass>> dictionary = new Dictionary<string, List<TimerClass>>();
                              for (int j = 0; j < list_0[i].Count; j++)
                              {
                                    List<TimerClass> list;
                                    TimerClass item = list_0[i][j];
                                    string key = item.ToString();
                                    dictionary.TryGetValue(key, out list);
                                    if (list == null)
                                    {
                                          dictionary[key] = list = new List<TimerClass>();
                                    }
                                    list.Add(item);
                              }
                              foreach (KeyValuePair<string, List<TimerClass>> pair in dictionary)
                              {
                                    string str2 = pair.Key;
                                    List<TimerClass> list2 = pair.Value;
                                    textWriter_0.WriteLine("Type: {0}; Count: {1}; Percent: {2}%", str2, list2.Count, (int)(100.0 * (((double)list2.Count) / ((double)list_0[i].Count))));
                              }
                              textWriter_0.WriteLine();
                              textWriter_0.WriteLine();
                        }
                  }

                  public static void smethod_1(TimerClass class125_0, int int_0, bool bool_0)
                  {
                        queue_0.Enqueue(Class129.smethod_0(class125_0, int_0, bool_0));
                  }

                  public static void smethod_2(TimerClass class125_0)
                  {
                        smethod_1(class125_0, (int)class125_0.Priority, true);
                  }

                  public static void smethod_3(TimerClass class125_0, int int_0)
                  {
                        smethod_1(class125_0, int_0, false);
                  }

                  public static void smethod_4(TimerClass class125_0)
                  {
                        smethod_1(class125_0, -1, false);
                  }

                  private static void smethod_5()
                  {
                        while (queue_0.Count > 0)
                        {
                              if (World.jlMsg == 1)
                              {
                                    Form1.WriteLine(0, "ProcessChangeQueue");
                              }
                              Class129 class1 = (Class129)queue_0.Dequeue();
                              TimerClass item = class1.class125_0;
                              int index = class1.int_0;
                              if (item.list_0 != null)
                              {
                                    item.list_0.Remove(item);
                              }
                              if (class1.bool_0)
                              {
                                    item.dateTime_0 = DateTime.Now + item.timeSpan_0;
                                    item.int_0 = 0;
                              }
                              if (index >= 0)
                              {
                                    item.list_0 = list_0[index];
                                    item.list_0.Add(item);
                              }
                              else
                              {
                                    item.list_0 = null;
                              }
                              class1.method_0();
                        }
                  }

                  private static void ZYDNGuard()
                  {
                        queue_0 = Queue.Synchronized(new Queue());
                        dateTime_0 = new DateTime[8];
                        timeSpan_0 = new TimeSpan[] { TimeSpan.Zero, TimeSpan.FromMilliseconds(10.0), TimeSpan.FromMilliseconds(25.0), TimeSpan.FromMilliseconds(50.0), TimeSpan.FromMilliseconds(250.0), TimeSpan.FromSeconds(1.0), TimeSpan.FromSeconds(5.0), TimeSpan.FromMinutes(1.0) };
                        list_0 = new List<TimerClass>[] { new List<TimerClass>(), new List<TimerClass>(), new List<TimerClass>(), new List<TimerClass>(), new List<TimerClass>(), new List<TimerClass>(), new List<TimerClass>(), new List<TimerClass>() };
                  }

                  private class Class129
                  {
                        public bool bool_0;
                        public TimerClass class125_0;
                        public int int_0;
                        private static Queue<TimerClass.Class128.Class129> queue_0;

                        static Class129()
                        {
                              ZYDNGuard();
                        }

                        private Class129(TimerClass t, int newIndex, bool isAdd)
                        {
                              this.class125_0 = t;
                              this.int_0 = newIndex;
                              this.bool_0 = isAdd;
                        }

                        public void method_0()
                        {
                        }

                        public static TimerClass.Class128.Class129 smethod_0(TimerClass class125_1, int int_1, bool bool_1)
                        {
                              if (queue_0.Count <= 0)
                              {
                                    return new TimerClass.Class128.Class129(class125_1, int_1, bool_1);
                              }
                              TimerClass.Class128.Class129 class2 = queue_0.Dequeue();
                              if (class2 == null)
                              {
                                    return new TimerClass.Class128.Class129(class125_1, int_1, bool_1);
                              }
                              class2.class125_0 = class125_1;
                              class2.int_0 = int_1;
                              class2.bool_0 = bool_1;
                              return class2;
                        }

                        private static void ZYDNGuard()
                        {
                              queue_0 = new Queue<TimerClass.Class128.Class129>();
                        }
                  }
            }
      }
}

