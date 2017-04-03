namespace ns10
{
      using ns13;
      using ns3;
      using ns4;
      using ns9;
      using System;
      using System.Net.Sockets;
      using System.Text;

      internal class ClientConnection: SockClienT
      {
            public ClientConnection(Socket sock, Delegate7 rcd) : base(sock, rcd)
            {
            }

            public void WebPacketProcess(byte[] byte_1, int int_0)
            {
                  if (World.jlMsg == 1)
                  {
                        Form1.WriteLine(0, "ProcessDataReceived()");
                  }
                  try
                  {
                        byte[] bytes = new byte[int_0];
                        for (int i = 0; i < int_0; i++)
                        {
                              bytes[i] = byte_1[i];
                        }
                        string str = "-1";
                        char[] separator = new char[] { ',' };
                        string[] strArray = Encoding.Default.GetString(bytes).Split(separator);
                        switch (strArray[0])
                        {
                              //사용자 로그인
                              case "用户登陆":
                                    if (World.smethod_0(strArray[1]) == null)
                                    {
                                          //실패
                                          str = "登陆失败";
                                    }
                                    else
                                    {
                                          //성공
                                          str = "登陆成功";
                                    }
                                    break;

                              case "查询":
                                    {
                                          
                                          Players players2 = World.smethod_0(strArray[1]);
                                          if (players2 == null)
                                          {
                                                str = "-1";
                                          }
                                          else if (strArray[2] == "热血元宝")
                                          {
                                                players2.KIEM_TRA_BACH_BAO_CAC_NGUYEN_BAO_SO_LUONG();
                                                str = players2.FLD_RXPIONT.ToString();
                                          }
                                          else if (strArray[2] == "赠品元宝")
                                          {
                                                players2.KIEM_TRA_BACH_BAO_CAC_NGUYEN_BAO_SO_LUONG();
                                                str = players2.FLD_RXPIONTX.ToString();
                                          }
                                          else if (strArray[2] == "空位")
                                          {
                                                str = players2.NHAN_TUI_TRONG_SO_LUONG().ToString();
                                          }
                                          break;
                                    }
                              case "购买":
                                    {
                                          Form1.WriteLine(3, "웹 구매");
                                          Players players = World.smethod_0(strArray[1]);
                                          if ((long.Parse(strArray[4]) >= 0L) && (int.Parse(strArray[3]) >= 1))
                                          {
                                                if (players == null)
                                                {
                                                      str = "-1";
                                                }
                                                else
                                                {
                                                      ITEMSELL itemsell;
                                                      if (World.dictionary_0.TryGetValue(int.Parse(strArray[2]), out itemsell))
                                                      {
                                                            Form1.WriteLine(3, "웹 구매 패킷 전송");
                                                            str = players.WebItemsell(int.Parse(strArray[2]), int.Parse(strArray[3]), long.Parse(strArray[4]), int.Parse(strArray[5]), itemsell.FLD_MAGIC1, itemsell.FLD_MAGIC2, itemsell.FLD_MAGIC3, itemsell.FLD_MAGIC4, itemsell.FLD_MAGIC5, itemsell.FLD_TRUNG_CAP_PHU_HON, itemsell.FLD_SO_CAP_PHU_HON, itemsell.FLD_TIEN_HOA, itemsell.FLD_CO_HAY_KHONG_TROI_CHAT, itemsell.FLD_DAYS);
                                                            Form1.WriteLine(3, string.Format("웹 구매 패킷 전송 리턴 {0}", str));
                                                      }
                                                }
                                          }
                                          else
                                          {
                                                str = "-1";
                                                players.Dispose();
                                          }
                                          break;
                                    }
                              default:
                                    str = "-1";
                                    break;
                        }
                        this.vmethod_2(str);
                  }
                  catch (Exception ex)
                  {
                        base.method_0();
                        Form1.WriteLine(1, string.Format("웹 구매 패킷 Exception {0}", ex.ToString()));
                  }
            }

            public override void vmethod_1(byte[] byte_1, int int_0)
            {
                  int index = 0;
                  if ((170 != byte_1[0]) || (0x66 != byte_1[1]))
                  {
                        Form1.WriteLine(1, string.Concat(new object[] { "错包：", byte_1[0], " ", byte_1[1] }));
                        return;
                  }
                  byte[] dst = new byte[4];
                  Buffer.BlockCopy(byte_1, 2, dst, 0, 4);
                  int count = BitConverter.ToInt32(dst, 0);
                  if (int_0 < (count + 6))
                  {
                        return;
                  }
                  while (true)
                  {
                        if (World.jlMsg == 1)
                        {
                              Form1.WriteLine(0, "ProcessDataReceived");
                        }
                        byte[] buffer2 = new byte[count];
                        Buffer.BlockCopy(byte_1, index + 6, buffer2, 0, count);
                        index += count + 6;
                        this.WebPacketProcess(buffer2, count);
                        if (((index >= int_0) || (byte_1[index] != 170)) || (byte_1[index + 1] != 0x66))
                        {
                              return;
                        }
                        Buffer.BlockCopy(byte_1, index + 2, dst, 0, 4);
                        count = BitConverter.ToInt16(dst, 0);
                  }
            }
      }
}

