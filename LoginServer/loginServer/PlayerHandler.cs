namespace LoginServer
{
      using System;
      using System.Collections.Generic;
      using System.Net.Sockets;
      using System.Text;

      public class PlayerHandler: SockClient
      {
            private string _ServerId;
            private int int_0;
            private int int_1;
            private SevConnClass SevConn;

            static PlayerHandler()
            {
                  ZYXDNGuarder.Startup();
            }

            public PlayerHandler(Socket from, RemoveClientDelegate rftsl) : base(from, rftsl)
            {
            }

            public byte[] DataReceived(byte[] data, int length)
            {
                  byte[] buffer;
                  try
                  {
                        Dictionary<string, playerS> dictionary;
                        string[] strArray2;
                        int num;
                        bool flag;
                        string str = Encoding.Default.GetString(data);
                        Form1.WriteLine(3, "帐号验证收到：" + str);
                        string[] strArray = str.Split(new char[] { '|' });
                        switch (strArray[0])
                        {
                              case "复查用户登陆":
                                    dictionary = new Dictionary<string, playerS>();
                                    strArray2 = strArray[1].Split(new char[] { ',' });
                                    if (strArray2.Length <= 1)
                                    {
                                          goto Label_04AD;
                                    }
                                    num = 0;
                                    goto Label_045C;

                              case "踢出玩家用户":
                                    if (!World.smethod_4(strArray[1]))
                                    {
                                          goto Label_0475;
                                    }
                                    this.Sendd("踢出玩家成功 ID： " + strArray[1]);
                                    goto Label_04AD;

                              case "用户登陆":
                                    if (strArray.Length == 5)
                                    {
                                          this.SevConn = new SevConnClass();
                                          this.SevConn.Server = this;
                                          this.SevConn.UserId = strArray[1];
                                          this.SevConn.UserIp = strArray[2];
                                          this.SevConn.ServerID = strArray[3];
                                          this.SevConn.WorldID = strArray[4];
                                          World.Connect.Enqueue(this.SevConn);
                                    }
                                    goto Label_04AD;

                              case "用户登出":
                                    World.smethod_2(strArray[1]);
                                    goto Label_04AD;

                              case "更新服务器配置":
                                    this.Int32_0 = int.Parse(strArray[2]);
                                    goto Label_04AD;

                              case "服务器连接登陆":
                                    this.ServerId = strArray[1];
                                    this.Int32_0 = int.Parse(strArray[2]);
                                    World.smethod_6(this.ServerId);
                                    Form1.WriteLine(3, "服务器连接成功 ID：" + strArray[1]);
                                    goto Label_04AD;

                              case "狮子吼":
                                    if (World.queue_0.Count < World.int_1)
                                    {
                                          break;
                                    }
                                    goto Label_0499;

                              case "更新服务器端口":
                                    {
                                          string s = strArray[1];
                                          string str3 = strArray[2];
                                          foreach (ServerClass class4 in World.ServerList)
                                          {
                                                foreach (ServerXlClass class5 in class4.ServerList)
                                                {
                                                      if (class5.ServerZId == int.Parse(s))
                                                      {
                                                            class5.SERVER_PORT = str3;
                                                      }
                                                }
                                          }
                                          Form1.WriteLine(3, "更新服务器端口 ID：" + strArray[1] + "   " + strArray[2]);
                                          goto Label_04AD;
                                    }
                              default:
                                    goto Label_04AD;
                        }
                        GClass0 class2 = new GClass0
                        {
                              FLD_INDEX = int.Parse(strArray[1]),
                              UserName = strArray[2],
                              TxtId = World.int_0,
                              Txt = strArray[3],
                              UserClientIP = strArray[4],
                              Int32_0 = int.Parse(strArray[5]),
                              Map = int.Parse(strArray[6])
                        };
                        World.queue_0.Enqueue(class2);
                        if (World.int_0 < 0x7f)
                        {
                              goto Label_048B;
                        }
                        World.int_0 = 0;
                        goto Label_04AD;
                        Label_03C3:
                        if (num >= strArray2.Length)
                        {
                              goto Label_0464;
                        }
                        try
                        {
                              string[] strArray3 = strArray2[num].Split(new char[] { '-' });
                              playerS rs = new playerS
                              {
                                    UserId = strArray3[0]
                              };
                              if (strArray3.Length >= 2)
                              {
                                    rs.UserIp = strArray3[1];
                              }
                              rs.ServerID = this.ServerId;
                              rs.conn = 0;
                              dictionary.Add(strArray3[0], rs);
                        }
                        catch
                        {
                        }
                        num++;
                        Label_045C:
                        flag = true;
                        goto Label_03C3;
                        Label_0464:
                        World.smethod_10(this.ServerId, dictionary);
                        goto Label_04AD;
                        Label_0475:
                        this.Sendd("踢出玩家失败 ID： " + strArray[1]);
                        goto Label_04AD;
                        Label_048B:
                        World.int_0++;
                        goto Label_04AD;
                        Label_0499:
                        this.Sendd("狮子吼|NO|" + strArray[1]);
                        Label_04AD:
                        buffer = null;
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "出错：" + exception.Message);
                        Console.WriteLine(exception.Message);
                        Console.WriteLine(exception.Source);
                        Console.WriteLine(exception.StackTrace);
                        buffer = null;
                  }
                  return buffer;
            }

            public override byte[] DataReceived2(byte[] data, int length)
            {
                  byte[] buffer2;
                  try
                  {
                        bool flag;
                        byte[] dst = new byte[length];
                        Buffer.BlockCopy(data, 0, dst, 0, length);
                        string str = Encoding.Default.GetString(dst);
                        Form1.WriteLine(3, "帐号验证收到：" + str);
                        string[] strArray = str.Split(new char[] { '|' });
                        string str2 = strArray[0];
                        if (str2 == null)
                        {
                              goto Label_028E;
                        }
                        if (str2 != "复查用户登陆")
                        {
                              goto Label_0166;
                        }
                        Dictionary<string, playerS> players = new Dictionary<string, playerS>();
                        string[] strArray2 = strArray[1].Split(new char[] { ',' });
                        if (strArray2.Length <= 1)
                        {
                              goto Label_028E;
                        }
                        int index = 0;
                        goto Label_0149;
                        Label_00B0:
                        if (index >= strArray2.Length)
                        {
                              goto Label_0151;
                        }
                        try
                        {
                              string[] strArray3 = strArray2[index].Split(new char[] { '-' });
                              playerS rs = new playerS
                              {
                                    UserId = strArray3[0]
                              };
                              if (strArray3.Length >= 2)
                              {
                                    rs.UserIp = strArray3[1];
                              }
                              rs.ServerID = this.ServerId;
                              rs.conn = 0;
                              players.Add(strArray3[0], rs);
                        }
                        catch
                        {
                        }
                        index++;
                        Label_0149:
                        flag = true;
                        goto Label_00B0;
                        Label_0151:
                        World.smethod_10(this.ServerId, players);
                        goto Label_028E;
                        Label_0166:
                        switch (str2)
                        {
                              case "用户登陆":
                                    if (strArray.Length == 5)
                                    {
                                          this.SevConn = new SevConnClass();
                                          this.SevConn.Server = this;
                                          this.SevConn.UserId = strArray[1];
                                          this.SevConn.UserIp = strArray[2];
                                          this.SevConn.ServerID = strArray[3];
                                          this.SevConn.WorldID = strArray[4];
                                          World.Connect.Enqueue(this.SevConn);
                                    }
                                    break;

                              case "用户登出":
                                    World.smethod_2(strArray[1]);
                                    break;

                              default:
                                    switch (str2)
                                    {
                                          case "更新服务器配置":
                                                this.Int32_0 = int.Parse(strArray[2]);
                                                break;

                                          case "服务器连接登陆":
                                                this.ServerId = strArray[1];
                                                this.Int32_0 = int.Parse(strArray[2]);
                                                World.smethod_6(this.ServerId);
                                                Form1.WriteLine(3, "服务器连接成功 ID：" + strArray[1]);
                                                break;
                                    }
                                    break;
                        }
                        Label_028E:
                        buffer2 = null;
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "出错：" + exception.Message);
                        Console.WriteLine(exception.Message);
                        Console.WriteLine(exception.Source);
                        Console.WriteLine(exception.StackTrace);
                        buffer2 = null;
                  }
                  return buffer2;
            }

            public void Logout()
            {
                  World.smethod_6(this.ServerId);
                  Form1.WriteLine(3, "服务器以断开 ID：" + this.ServerId);
            }

            public override byte[] ProcessDataReceived(byte[] data, int length)
            {
                  byte[] buffer;
                  try
                  {
                        byte[] buffer2;
                        int index = 0;
                        if ((170 != data[0]) || (0x66 != data[1]))
                        {
                              goto Label_00C5;
                        }
                        byte[] dst = new byte[4];
                        Buffer.BlockCopy(data, 2, dst, 0, 4);
                        int count = BitConverter.ToInt32(dst, 0);
                        if (length >= (count + 6))
                        {
                              goto Label_008F;
                        }
                        return null;
                        Label_0057:
                        if ((data[index] != 170) || (data[index + 1] != 0x66))
                        {
                              goto Label_0105;
                        }
                        Buffer.BlockCopy(data, index + 2, dst, 0, 4);
                        count = BitConverter.ToInt16(dst, 0);
                        Label_008F:
                        buffer2 = new byte[count];
                        Buffer.BlockCopy(data, index + 6, buffer2, 0, count);
                        index += count + 6;
                        this.DataReceived(buffer2, count);
                        if (index < length)
                        {
                              goto Label_0057;
                        }
                        goto Label_0105;
                        Label_00C5:;
                        Form1.WriteLine(1, string.Concat(new object[] { "错包：", data[0], " ", data[1] }));
                        Label_0105:
                        buffer = null;
                  }
                  catch (Exception exception)
                  {
                        Form1.WriteLine(1, "出错：" + exception.Message);
                        Console.WriteLine(exception.Message);
                        Console.WriteLine(exception.Source);
                        Console.WriteLine(exception.StackTrace);
                        buffer = null;
                  }
                  return buffer;
            }

            public int Int32_0
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

            public int Int32_1
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

            public int Int32_2 =>
                World.smethod_5(this.ServerId);

            public string ServerId
            {
                  get
                  {
                        return this._ServerId;
                  }
                  set
                  {
                        this._ServerId = value;
                  }
            }
      }
}

