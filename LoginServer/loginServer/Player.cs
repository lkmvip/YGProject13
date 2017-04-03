namespace LoginServer
{
    using LoginServer.DbClss;
    using LoginServer.HelperTools;
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Text;

    public class Player
    {
        public NetState Client;

        static Player()
        {
            ZYXDNGuarder.Startup();
        }

        public Player(NetState client)
        {
            this.Client = client;
        }

        public void ManagePacket(byte[] data, int length)
        {
            byte[] dst = new byte[length];
            Buffer.BlockCopy(data, 0, dst, 0, length);
            switch (data[0])
            {
                case 10:
                    this.method_1(data, length);
                    break;

                case 12:
                    this.method_2(data, length);
                    break;

                case 0x16:
                    this.method_3(data, length);
                    break;

                case 0:
                    this.method_0(data, length);
                    break;
            }
        }

        public void method_0(byte[] data, int length)
        {
            bool flag = false;
            byte[] toSendBuff = Converter.hexStringToByte("018004000A000300");
            Converter.hexStringToByte("018004000B000300");
            Converter.hexStringToByte("0180040009000300");
            try
            {
                string[] strArray;
                int num;
                byte[] buffer2;
                string[] strArray2;
                int num2;
                byte[] buffer3;
                KillClass class2;
                KillClass class3;
                KillClass class4;
                string str = RxjhClass.GetUserIpadds(this.Client.ToString()).Replace(" ", "").Trim();
                if (World.string_3 != "")
                {
                    bool flag2 = false;
                    strArray = World.string_3.Split(new char[] { ',' });
                    num = 0;
                    while (num < strArray.Length)
                    {
                        if (str.IndexOf(strArray[num]) != -1)
                        {
                            if (World.string_7 != "")
                            {
                                string[] strArray3 = World.string_7.Split(new char[] { ',' });
                                for (int i = 0; i < strArray3.Length; i++)
                                {
                                    if (str.IndexOf(strArray3[i]) != -1)
                                    {
                                        flag2 = true;
                                    }
                                }
                            }
                            if (!flag2)
                            {
                                goto Label_012F;
                            }
                        }
                        num++;
                    }
                }
                goto Label_0197;
            Label_012F:
                buffer2 = this.SetMsg("请重新登陆");
                Form1.WriteLine(1, str + "用户登陆[" + this.Client.ToString() + "]被封" + strArray[num]);
                this.Client.Send(buffer2, buffer2.Length);
                return;
            Label_0197:
                if (World.string_4 != "")
                {
                    strArray2 = World.string_4.Split(new char[] { ',' });
                    num2 = 0;
                    while (num2 < strArray2.Length)
                    {
                        if (this.Client.ToString().IndexOf(strArray2[num2]) != -1)
                        {
                            goto Label_020B;
                        }
                        num2++;
                    }
                }
                goto Label_0275;
            Label_020B:
                buffer3 = this.SetMsg("你的IP以被管理员停封");
                Form1.WriteLine(1, str + "用户登陆[" + this.Client.ToString() + "]被封" + strArray2[num2]);
                this.Client.Send(buffer3, buffer3.Length);
                return;
            Label_0275:
                if (RxjhClass.GetUserIP(this.Client.ToString()) == -1)
                {
                    byte[] buffer4 = this.SetMsg("你的IP以被管理员停封");
                    Form1.WriteLine(2, "用户登陆[" + this.Client.ToString() + "]被封");
                    this.Client.Send(buffer4, buffer4.Length);
                    return;
                }
                string webString = "";
                string pwd = "";
                try
                {
                    byte[] dst = new byte[data[4]];
                    Buffer.BlockCopy(data, 6, dst, 0, dst.Length);
                    webString = Encoding.Default.GetString(dst).Trim();
                    if (webString.Length > 14)
                    {
                        return;
                    }
                }
                catch (Exception exception)
                {
                    byte[] buffer6 = this.SetMsg("系统错误,请联系客服人员1");
                    Form1.WriteLine(1, "getid_得到ID 系统错误" + exception.Message);
                    this.Client.Send(buffer6, buffer6.Length);
                    return;
                }
                try
                {
                    byte[] buffer7 = new byte[data[6 + data[4]]];
                    Buffer.BlockCopy(data, 8 + data[4], buffer7, 0, buffer7.Length);
                    pwd = Encoding.Default.GetString(buffer7).Trim();
                }
                catch (Exception exception2)
                {
                    byte[] buffer8 = this.SetMsg("系统错误,请联系客服人员2");
                    Form1.WriteLine(1, "getid_得到pwd 系统错误" + exception2.Message);
                    this.Client.Send(buffer8, buffer8.Length);
                    return;
                }
                if (webString == "getver123")
                {
                    byte[] buffer9 = this.SetMsg(Assembly.GetExecutingAssembly().GetName().Version.ToString());
                    this.Client.Send(buffer9, buffer9.Length);
                    return;
                }
                if (RxjhClass.ReplaceComma(webString) == -1)
                {
                    byte[] buffer10 = this.SetMsg("检查到你输入了非法字符,请重新填写");
                    this.Client.Send(buffer10, buffer10.Length);
                    return;
                }
                if (World.KillList.TryGetValue(webString, out class2) && (class2.conn >= 5))
                {
                    Form1.WriteLine(2, "用户登陆[" + webString + "]-密码错误多次");
                    byte[] buffer11 = this.SetMsg("你输入的帐号密码错误多次，请5分钟以后再试。");
                    this.Client.Send(buffer11, buffer11.Length);
                    return;
                }
                int num4 = -2;
                try
                {
                    num4 = RxjhClass.GetUserId(webString, pwd, this.Client.ToString());
                }
                catch (Exception exception3)
                {
                    string str4 = Converter.ToString(data);
                    Console.WriteLine(str4);
                    Form1.WriteLine(1, str4);
                    Form1.WriteLine(1, exception3.Message);
                }
                switch (num4)
                {
                    case -2:
                    {
                        byte[] buffer13 = this.SetMsg("系统错误,请联系客服人员8");
                        this.Client.Send(buffer13, buffer13.Length);
                        return;
                    }
                    case -1:
                    {
                        byte[] buffer12 = this.SetMsg("你输入的帐号[" + webString + "]不存在\r\n请到" + World.string_6 + "重新注册帐号");
                        Form1.WriteLine(2, "用户登陆[" + webString + "]账号不存在");
                        this.Client.Send(buffer12, buffer12.Length);
                        return;
                    }
                    case 0:
                                    
                        if (!World.KillList.TryGetValue(webString, out class3))
                        {
                            goto Label_06E6;
                        }
                        if (class3.conn >= 5)
                        {
                            break;
                        }
                        
                        class3.conn++;
                        Form1.WriteLine(2, "用户登陆[" + webString + "]-[" + pwd + "]密码错误");
                        this.Client.Send(toSendBuff, toSendBuff.Length);
                        return;

                    case 2:
                    {
                        byte[] buffer15 = this.SetMsg("你输入的帐号以被停封。");
                        Form1.WriteLine(2, "用户登陆[" + webString + "]账号以被停封");
                        this.Client.Send(buffer15, buffer15.Length);
                        return;
                    }
                    default:
                        goto Label_07A4;
                }
                class3.time = DateTime.Now.AddMinutes(5.0);
                Form1.WriteLine(2, "用户登陆[" + webString + "]-[" + pwd + "]密码错误");
                byte[] buffer14 = this.SetMsg("你输入的帐号密码错误多次，请5分钟以后再试。");
                this.Client.Send(buffer14, buffer14.Length);
                return;
            Label_06E6:
                class4 = new KillClass();
                class4.UserId = webString;
                class4.conn = 1;
                class3 = class4;
                World.KillList.Add(webString, class3);
                Form1.WriteLine(2, "用户登陆[" + webString + "]-[" + pwd + "]密码错误");
                this.Client.Send(toSendBuff, toSendBuff.Length);
                return;
            Label_07A4:
                if (num4 == 1)
                {
                    if (World.KillList.ContainsKey(webString))
                    {
                        World.KillList.Remove(webString);
                    }
                    byte[] buffer16 = new byte[((11 + webString.Length) + webString.Length) + 3];
                    byte[] src = Converter.hexStringToByte("01800C0000003300");
                    try
                    {
                        Buffer.BlockCopy(src, 0, buffer16, 0, src.Length);
                    }
                    catch (Exception exception4)
                    {
                        byte[] buffer18 = this.SetMsg("系统错误,请联系客服人员3");
                        Form1.WriteLine(1, string.Concat(new object[] { "getid_bySend 1错误", buffer16.Length, " ", src.Length, exception4.Message }));
                        this.Client.Send(buffer18, buffer18.Length);
                        return;
                    }
                    byte[] bytes = new byte[0];
                    try
                    {
                        Buffer.BlockCopy(BitConverter.GetBytes(webString.Length), 0, buffer16, 8, 1);
                        Buffer.BlockCopy(BitConverter.GetBytes(webString.Length), 0, buffer16, (8 + webString.Length) + 3, 1);
                        Buffer.BlockCopy(BitConverter.GetBytes((int) (((7 + webString.Length) + webString.Length) + 2)), 0, buffer16, 2, 1);
                        bytes = Encoding.Default.GetBytes(webString);
                    }
                    catch (Exception exception5)
                    {
                        byte[] buffer20 = this.SetMsg("系统错误,请联系客服人员4");
                        Form1.WriteLine(1, string.Concat(new object[] { "getid_bySend 2错误", buffer16.Length, " ", bytes.Length, exception5.Message }));
                        this.Client.Send(buffer20, buffer20.Length);
                        return;
                    }
                    try
                    {
                        Buffer.BlockCopy(bytes, 0, buffer16, 10, bytes.Length);
                        Buffer.BlockCopy(bytes, 0, buffer16, (10 + webString.Length) + 3, bytes.Length);
                    }
                    catch (Exception exception6)
                    {
                        byte[] buffer21 = this.SetMsg("系统错误,请联系客服人员5");
                        Form1.WriteLine(1, string.Concat(new object[] { "getid_bySend 错误", buffer16.Length, " ", bytes.Length, exception6.Message }));
                        this.Client.Send(buffer21, buffer21.Length);
                        return;
                    }
                    try
                    {
                        string[] strArray4 = World.string_2.Split(new char[] { ';' });
                        if (strArray4.Length > 1)
                        {
                            for (int j = 0; j < strArray4.Length; j++)
                            {
                                if (RxjhClass.GetFq(webString) == strArray4[j])
                                {
                                    flag = true;
                                }
                            }
                        }
                    }
                    catch
                    {
                        byte[] buffer22 = this.SetMsg("系统错误,未设置正确的登陆分区,请联系管理员6");
                        this.Client.Send(buffer22, buffer22.Length);
                        return;
                    }
                    if (!flag)
                    {
                        byte[] buffer23 = this.SetMsg("帐号未激活或进错分区,请联系管理员7");
                        this.Client.Send(buffer23, buffer23.Length);
                    }
                    else if (!World.smethod_1(webString))
                    {
                        byte[] buffer24 = this.SetMsg("系统错误,请联系客服人员,请重新登陆6");
                        this.Client.Send(buffer24, buffer24.Length);
                    }
                    else
                    {
                        Form1.WriteLine(2, "用户登陆[" + webString + "]-[" + pwd + "]登陆成功 " + str + " " + this.Client.ToString());
                        this.Client.Send(buffer16, buffer16.Length);
                    }
                }
            }
            catch (Exception exception7)
            {
                byte[] buffer25 = this.SetMsg("系统错误,请联系客服人员7");
                Form1.WriteLine(1, "getid系统错误" + exception7.Message);
                this.Client.Send(buffer25, buffer25.Length);
            }
        }

        public void method_1(byte[] data, int length)
        {
            string hex = "0B8128004C4F47494E5F5345525645525F3030000159424F6E6C696E652D2D31323535363334313137005546";
            byte[] toSendBuff = Converter.hexStringToByte(hex);
            this.Client.Send(toSendBuff, toSendBuff.Length);
        }

        public void method_2(byte[] data, int length)
        {
            try
            {
                int num = data[4];
                int num2 = data[8];
                World.int_9 = num2;
                ServerClass class2 = World.ServerList[num - 1];
                byte[] bytes = Encoding.Default.GetBytes(class2.ServerList[num2 - 1].SERVER_IP);
                byte[] src = BitConverter.GetBytes(int.Parse(class2.ServerList[num2 - 1].SERVER_PORT));
                byte[] buffer3 = Encoding.Default.GetBytes(class2.ServerList[num2 - 1].SERVER_NAME);
                byte[] buffer4 = BitConverter.GetBytes(bytes.Length);
                byte[] buffer5 = BitConverter.GetBytes(buffer3.Length);
                BitConverter.GetBytes((int) (((3 + bytes.Length) + src.Length) + buffer3.Length));
                byte[] dst = new byte[((((6 + bytes.Length) + src.Length) + buffer3.Length) + 2) + buffer3.Length];
                dst[0] = 100;
                dst[1] = 0x80;
                dst[4] = buffer4[0];
                Buffer.BlockCopy(BitConverter.GetBytes((int) (dst.Length - 4)), 0, dst, 2, 2);
                Buffer.BlockCopy(bytes, 0, dst, 6, bytes.Length);
                Buffer.BlockCopy(src, 0, dst, 6 + bytes.Length, src.Length);
                Buffer.BlockCopy(buffer3, 0, dst, ((dst.Length - buffer3.Length) - buffer3.Length) - 2, buffer3.Length);
                Buffer.BlockCopy(buffer3, 0, dst, dst.Length - buffer3.Length, buffer3.Length);
                dst[(dst.Length - buffer3.Length) - 2] = buffer5[0];
                dst[(((dst.Length - buffer3.Length) - 2) - buffer3.Length) - 2] = buffer5[0];
                this.Client.Send(dst, dst.Length);
            }
            catch (Exception exception)
            {
                byte[] toSendBuff = this.SetMsg("系统错误,请联系客服人员");
                Form1.WriteLine(1, "选定服务器列表 错误" + exception.Message);
                this.Client.Send(toSendBuff, toSendBuff.Length);
            }
        }

        public void method_3(byte[] data, int length)
        {
            List<byte[]> list = new List<byte[]>();
            int serverCount = World.ServerCount;
            int dstOffset = 0;
            for (int i = 0; i < serverCount; i++)
            {
                byte[] item = this.method_6(i);
                list.Add(item);
                dstOffset += item.Length;
            }
            byte[] dst = new byte[dstOffset];
            dstOffset = 0;
            for (int j = 0; j < serverCount; j++)
            {
                byte[] src = list[j];
                Buffer.BlockCopy(src, 0, dst, dstOffset, src.Length);
                dstOffset += src.Length;
            }
            byte[] bytes = BitConverter.GetBytes(dst.Length);
            byte[] buffer5 = new byte[6 + dst.Length];
            Buffer.BlockCopy(bytes, 0, buffer5, 2, 2);
            buffer5[0] = 0x17;
            buffer5[1] = 0x80;
            buffer5[4] = (byte) serverCount;
            buffer5[5] = 0;
            Buffer.BlockCopy(dst, 0, buffer5, 6, dst.Length);
            this.Client.Send(buffer5, buffer5.Length);
        }

        public void method_4(byte[] data, int length)
        {
            byte[] src = Converter.hexStringToByte("010001000400544553540E0000000100010001000600544553542D310E00030053542D310E0003000010400000000008E1E0");
            byte[] dst = new byte[4 + src.Length];
            Buffer.BlockCopy(BitConverter.GetBytes(src.Length), 0, dst, 2, 2);
            dst[0] = 0x17;
            dst[1] = 0x80;
            Buffer.BlockCopy(src, 0, dst, 4, src.Length);
            this.Client.Send(dst, dst.Length);
        }

        public byte[] method_5(int id, int Zid, string string_0)
        {
            byte[] buffer;
            string[] strArray = World.string_5.Split(new char[] { ',' });
            double num = -1.0;
            double num2 = 1000.0;
            try
            {
                PlayerHandler handler = World.smethod_7(Zid.ToString());
                if (handler != null)
                {
                    num = handler.Int32_2;
                    num2 = handler.Int32_0;
                }
                for (int i = 0; i <= (strArray.Length - 1); i++)
                {
                    if (id == i)
                    {
                        if (Convert.ToInt32(strArray[id]) == 1)
                        {
                            num = num2;
                        }
                        else if (Convert.ToInt32(strArray[id]) == 2)
                        {
                            num = num2 * 0.6;
                        }
                        else if (Convert.ToInt32(strArray[id]) == 3)
                        {
                            num = num2 * 0.9;
                        }
                        else if (Convert.ToInt32(strArray[id]) == 4)
                        {
                            num = num2 * 0.99;
                        }
                    }
                }
                if (num != -1.0)
                {
                    if (num > 0.0)
                    {
                        if (num < num2)
                        {
                            double num4 = num2 / 100.0;
                            num /= num4;
                        }
                        else
                        {
                            num = -1.0;
                        }
                    }
                    else
                    {
                        num = 0.0;
                    }
                }
                else
                {
                    num = 101.0;
                }
            }
            catch
            {
                num = 101.0;
            }
            byte[] bytes = Encoding.Default.GetBytes(string_0);
            byte[] buffer3 = BitConverter.GetBytes((int) (id + 1));
            byte[] buffer4 = BitConverter.GetBytes((int) num);
            byte[] buffer5 = BitConverter.GetBytes(bytes.Length);
            if (World.ver == 0)
            {
                buffer = new byte[6 + bytes.Length];
                buffer[0] = buffer3[0];
                buffer[2] = buffer5[0];
                buffer[buffer.Length - 2] = buffer4[0];
            }
            else
            {
                buffer = new byte[8 + bytes.Length];
                buffer[0] = buffer3[0];
                buffer[2] = buffer5[0];
                buffer[buffer.Length - 4] = buffer4[0];
                buffer[buffer.Length - 2] = 3;
            }
            Buffer.BlockCopy(bytes, 0, buffer, 4, bytes.Length);
            return buffer;
        }

        public byte[] method_6(int int_0)
        {
            ServerClass class2 = World.ServerList[int_0];
            int serverCount = class2.ServerCount;
            byte[] bytes = Encoding.Default.GetBytes(class2.SERVER_NAME);
            int num2 = 0;
            List<byte[]> list = new List<byte[]>();
            for (int i = 0; i < serverCount; i++)
            {
                byte[] item = this.method_5(class2.ServerList[i].ServerId, class2.ServerList[i].ServerZId, class2.ServerList[i].SERVER_NAME);
                num2 += item.Length;
                list.Add(item);
            }
            byte[] dst = new byte[12 + bytes.Length];
            byte[] buffer4 = new byte[num2 + dst.Length];
            num2 = 0;
            for (int j = 0; j < serverCount; j++)
            {
                byte[] src = list[j];
                Buffer.BlockCopy(src, 0, buffer4, dst.Length + num2, src.Length);
                num2 += src.Length;
            }
            byte[] buffer6 = BitConverter.GetBytes((int) (int_0 + 1));
            byte[] buffer7 = BitConverter.GetBytes(serverCount);
            byte[] buffer8 = BitConverter.GetBytes(bytes.Length);
            dst[0] = buffer6[0];
            dst[dst.Length - 8] = 1;
            dst[2] = buffer8[0];
            dst[dst.Length - 2] = buffer7[0];
            dst[dst.Length - 4] = 1;
            Buffer.BlockCopy(bytes, 0, dst, 4, bytes.Length);
            Buffer.BlockCopy(dst, 0, buffer4, 0, dst.Length);
            return buffer4;
        }

        public byte[] SetMsg(string msg)
        {
            byte[] src = Converter.hexStringToByte("0180040017000300");
            byte[] bytes = Encoding.Default.GetBytes(msg);
            byte[] dst = new byte[(src.Length + bytes.Length) + 1];
            Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            Buffer.BlockCopy(bytes, 0, dst, 8, bytes.Length);
            Buffer.BlockCopy(BitConverter.GetBytes((int) (bytes.Length + 1)), 0, dst, 2, 2);
            Buffer.BlockCopy(BitConverter.GetBytes(bytes.Length), 0, dst, 6, 2);
            return dst;
        }
    }
}

