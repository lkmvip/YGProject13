namespace LoginServer
{
      using LoginServer.DbClss;
      using System;
      using System.Collections;
      using System.Collections.Generic;
      using System.Net;
      using System.Windows.Forms;

      public class World
    {
        public static int aaaaaa;
        public static int AtPort;
        public static List<IPAddress> BipList;
        public static bool bool_0;
        public static bool bool_1;
        public static bool bool_2;
        public static bool bool_3;
        public static Queue Connect;
        public static Dictionary<string, DbClass> Db;
        public static int int_0;
        public static int int_1;
        public static int int_10;
        public static int int_2;
        public static int int_3;
        public static int int_4;
        public static int int_5;
        public static int int_6;
        public static int int_7;
        public static int int_8;
        public static int int_9;
        public static Dictionary<string, KillClass> KillList;
        public static Dictionary<int, NetState> list;
        public static Queue m_Disposed;
        public static int ms;
        public static Dictionary<string, playerS> Players;
        public static Queue queue_0;
        public static int ServerCount;
        public static List<ServerClass> ServerList;
        public static string string_0;
        public static string string_1;
        public static string string_2;
        public static string string_3;
        public static string string_4;
        public static string string_5;
        public static string string_6;
        public static string string_7;
        public static int ver;

        static World()
        {
            ZYXDNGuarder.Startup();
            ZYDNGuard();
        }

        public static int MyCallBack() => 
            1;

        public static void ProcessDisposedQueue()
        {
            try
            {
                int num = 0;
                while (num < 200)
                {
                    if (m_Disposed.Count <= 0)
                    {
                        return;
                    }
                    num++;
                    NetState state = (NetState) m_Disposed.Dequeue();
                    try
                    {
                        state.delWorldIdd();
                        continue;
                    }
                    catch (Exception exception)
                    {
                        Form1.WriteLine(1, "ProcessDisposedQueue()出错 " + exception.Message);
                        continue;
                    }
                }
            }
            catch
            {
            }
        }

        public static void ProcessSerQueue()
        {
            try
            {
                int num = 0;
                while (num < 200)
                {
                    if (Connect.Count <= 0)
                    {
                        return;
                    }
                    num++;
                    SevConnClass class2 = (SevConnClass) Connect.Dequeue();
                    try
                    {
                        if (class2.UserId.IndexOf(' ', class2.UserId.Length - 1) != -1)
                        {
                            Form1.WriteLine(1, "用户非法登陆[" + class2.UserId + "]" + class2.UserIp);
                        }
                        else if (!smethod_4(class2.UserId))
                        {
                            playerS rs = smethod_3(class2.UserId);
                            if (rs != null)
                            {
                                rs.conn = 0;
                                rs.UserIp = class2.UserIp;
                                rs.ServerID = class2.ServerID;
                                rs.WorldID = class2.WorldID;
                                class2.Server.Sendd(string.Concat(new object[] { "用户登陆|", class2.UserId, "|", class2.WorldID, "|不在线|", int_9 }));
                            }
                        }
                        else
                        {
                            smethod_9(class2.ServerID, class2.WorldID);
                        }
                        continue;
                    }
                    catch (Exception exception)
                    {
                        Form1.WriteLine(1, "ProcessSerQueue()出错 " + exception.Message);
                        continue;
                    }
                }
            }
            catch
            {
            }
        }

        public static string pWord(string sSource, int iFlag)
        {
            if (sSource == null)
            {
                return null;
            }
            if (sSource.Equals(""))
            {
                return "";
            }
            string str = "";
            if (iFlag == 2)
            {
                int length = sSource.Length;
                str = "";
                int num2 = Convert.ToInt32(sSource.ToCharArray(0, 1)[0]) % 10;
                for (int i = 2; i < length; i += 2)
                {
                    string str2;
                    int num4 = Convert.ToInt32(sSource.ToCharArray(i, 1)[0]);
                    if ((Convert.ToInt32(sSource.ToCharArray(i - 1, 1)[0]) % 2) == 0)
                    {
                        char ch = (char) ((num4 + ((i - 1) / 2)) + num2);
                        str2 = ch.ToString();
                    }
                    else
                    {
                        str2 = ((char) ((num4 - ((i - 1) / 2)) - num2)).ToString();
                    }
                    str = str + str2;
                }
            }
            return str;
        }

        public void SetConfig()
        {
            int_8 = (Config.IniReadValue("LoginServer", "ACCEPT_THE_DATA_SIZE") == "") ? 10 : int.Parse(Config.IniReadValue("LoginServer", "ACCEPT_THE_DATA_SIZE"));
            int_7 = (Config.IniReadValue("LoginServer", "MAXIMUM_NUMBER_OF_ACCEPTED") == "") ? 10 : int.Parse(Config.IniReadValue("LoginServer", "MAXIMUM_NUMBER_OF_ACCEPTED"));
            string_1 = Config.IniReadValue("LoginServer", "GAME_SERVER_IP").Trim();
            int_2 = (Config.IniReadValue("LoginServer", "ACCOUNT_AUTHENTICATION_SERVER_PORT") == "") ? 0xdaa2 : int.Parse(Config.IniReadValue("LoginServer", "ACCOUNT_AUTHENTICATION_SERVER_PORT"));
            AtPort = (Config.IniReadValue("LoginServer", "AtPort") == "") ? 0xdaac : int.Parse(Config.IniReadValue("LoginServer", "AtPort"));
            int_3 = (Config.IniReadValue("LoginServer", "GAME_LOGIN_SERVER_PORT") == "") ? 0x514 : int.Parse(Config.IniReadValue("LoginServer", "GAME_LOGIN_SERVER_PORT"));
            int_1 = (Config.IniReadValue("LoginServer", "THE_MAXIMUM_NUMBER_OF_IDIOM") == "") ? 100 : int.Parse(Config.IniReadValue("LoginServer", "THE_MAXIMUM_NUMBER_OF_IDIOM"));
            int_4 = (Config.IniReadValue("LoginServer", "GAME_LANDING_PORT_MAXIMUM_NUMBER_OF_CONNECTIONS") == "") ? 10 : int.Parse(Config.IniReadValue("LoginServer", "GAME_LANDING_PORT_MAXIMUM_NUMBER_OF_CONNECTIONS"));
            int_5 = (Config.IniReadValue("LoginServer", "GAME_TIME_LANDING_PORT_MAXIMUM_NUMBER_OF_CONNECTIONS") == "") ? 0x3e8 : int.Parse(Config.IniReadValue("LoginServer", "GAME_TIME_LANDING_PORT_MAXIMUM_NUMBER_OF_CONNECTIONS"));
            ver = (Config.IniReadValue("LoginServer", "ver") == "") ? ver : int.Parse(Config.IniReadValue("LoginServer", "ver"));
            ms = (Config.IniReadValue("LoginServer", "ms") == "") ? ms : int.Parse(Config.IniReadValue("LoginServer", "ms"));
            int_10 = (Config.IniReadValue("LoginServer", "AUTOMATIC_CONNECTION_TIME") == "") ? int_10 : int.Parse(Config.IniReadValue("LoginServer", "AUTOMATIC_CONNECTION_TIME"));
            string_0 = Config.IniReadValue("LoginServer", "SERVER_NAME").Trim();
            string_2 = Config.IniReadValue("LoginServer", "PARTITION_NUMBER").Trim();
            string_5 = Config.IniReadValue("LoginServer", "PARTITION_LINE_STATUS").Trim();
            string_6 = (Config.IniReadValue("LoginServer", "REGISTER_WEB_SITE_ADDRESS") == "") ? string_6 : Config.IniReadValue("LoginServer", "REGISTER_WEB_SITE_ADDRESS");
            Config.Path = Application.StartupPath + @"\config.ini";
            DbClass class2 = new DbClass {
                ServerDb = "rxjhaccount",
                SqlConnect = "server=" + Config.IniReadValue("LoginServer", "Server").Trim() + ";uid=" + Config.IniReadValue("LoginServer", "UserName").Trim() + ";pwd=" + Config.IniReadValue("LoginServer", "PassWord").Trim() + ";database=" + Config.IniReadValue("LoginServer", "DataName").Trim()
            };
            Db.Add("rxjhaccount", class2);
        }

        public void SetConfig2()
        {
            ServerCount = int.Parse(Config.IniReadValue("LoginServer", "serverCount"));
            ServerList.Clear();
            for (int i = 0; i < ServerCount; i++)
            {
                ServerClass item = new ServerClass {
                    SERVER_NAME = Config.IniReadValue("server" + i, "servername"),
                    ServerCount = int.Parse(Config.IniReadValue("server" + i, "serverCount"))
                };
                for (int j = 0; j < item.ServerCount; j++)
                {
                    ServerXlClass class3 = new ServerXlClass();
                    string[] strArray = Config.IniReadValue("server" + i, "server" + j).Split(new char[] { ',' });
                    class3.SERVER_NAME = strArray[0];
                    class3.ServerId = j;
                    class3.ServerZId = int.Parse(strArray[4]);
                    class3.SERVER_IP = strArray[2];
                    class3.SERVER_PORT = strArray[3];
                    item.ServerList.Add(class3);
                }
                ServerList.Add(item);
            }
            Form1.WriteLine(2, "加载服务器列表完成:" + ServerList.Count);
        }

        public void SetConfig3()
        {
            int_6 = (Config.IniReadValue("LoginServer", "IP_CLOSURE") == "") ? 0 : int.Parse(Config.IniReadValue("LoginServer", "IP_CLOSURE"));
            string_3 = Config.IniReadValue("LoginServer", "SEAL_AREA");
            string_7 = Config.IniReadValue("LoginServer", "SOLUTION_AREA");
            string_4 = Config.IniReadValue("LoginServer", "IP_CLOSURE_SEGMENT");
            Form1.WriteLine(2, "加载封IP完成");
        }

        public static void smethod_0()
        {
            if (queue_0.Count > 0)
            {
                GClass0 class2 = (GClass0) queue_0.Dequeue();
                foreach (PlayerHandler handler in BbcServer.clients)
                {
                    handler.Sendd(string.Concat(new object[] { "狮子吼|OK|", class2.FLD_INDEX, "|", class2.UserName, "|", class2.TxtId, "|", class2.Txt, "|", class2.Int32_0, "|", class2.Map }));
                }
            }
        }

        public static bool smethod_1(string Userid)
        {
            try
            {
                if (smethod_3(Userid) == null)
                {
                    playerS rs = new playerS {
                        UserId = Userid,
                        conn = 1
                    };
                    lock (Players)
                    {
                        Players.Add(Userid, rs);
                    }
                }
                return true;
            }
            catch (Exception exception)
            {
                Form1.WriteLine(1, "World.登录玩家(id) 错误" + exception.Message);
                return false;
            }
        }

        public static void smethod_10(string ServerID, Dictionary<string, playerS> Players)
        {
            try
            {
                Dictionary<string, playerS> dictionary2;
                new Dictionary<string, playerS>();
                Dictionary<string, playerS> dictionary = new Dictionary<string, playerS>();
                new Dictionary<string, playerS>();
                List<playerS> list = new List<playerS>();
                foreach (playerS rs in Players.Values)
                {
                    playerS rs2;
                    if (!World.Players.ContainsKey(rs.UserId))
                    {
                        lock ((dictionary2 = World.Players))
                        {
                            World.Players.Add(rs.UserId, rs);
                            continue;
                        }
                    }
                    if (World.Players.TryGetValue(rs.UserId, out rs2) && (rs2.ServerID != rs.ServerID))
                    {
                        if (rs2.UserId != "")
                        {
                            list.Add(rs2);
                        }
                        if (rs.UserId != "")
                        {
                            list.Add(rs);
                        }
                        Form1.WriteLine(6, "同进在线 ID：[" + rs2.UserId + "] IP:[" + rs2.UserIp + "] ServerID:[" + rs2.ServerID + "] 和 [" + rs.UserId + "] IP:[" + rs.UserIp + "] ServerID:[" + rs.ServerID + "]");
                    }
                }
                lock ((dictionary2 = World.Players))
                {
                    foreach (playerS rs3 in World.Players.Values)
                    {
                        if (((rs3.ServerID == ServerID) && !Players.ContainsKey(rs3.UserId)) && (rs3.conn == 0))
                        {
                            dictionary.Add(rs3.UserId, rs3);
                        }
                    }
                }
                foreach (playerS rs4 in dictionary.Values)
                {
                    lock ((dictionary2 = World.Players))
                    {
                        World.Players.Remove(rs4.UserId);
                    }
                }
                foreach (playerS rs5 in list)
                {
                    smethod_9(rs5.ServerID, rs5.WorldID);
                }
            }
            catch (Exception)
            {
            }
        }

        public static void smethod_2(string Userid)
        {
            playerS rs = smethod_3(Userid);
            if (rs != null)
            {
                RxjhClass.SetUserIdONLINE(rs.UserId);
                lock (Players)
                {
                    Players.Remove(rs.UserId);
                }
            }
        }

        public static playerS smethod_3(string Userid)
        {
            lock (Players)
            {
                foreach (playerS rs in Players.Values)
                {
                    if (rs.UserId == Userid)
                    {
                        return rs;
                    }
                }
            }
            return null;
        }

        public static bool smethod_4(string Userid)
        {
            lock (Players)
            {
                using (Dictionary<string, playerS>.ValueCollection.Enumerator enumerator = Players.Values.GetEnumerator())
                {
                    playerS current;
                    while (enumerator.MoveNext())
                    {
                        current = enumerator.Current;
                        if ((current.UserId == Userid) && (current.conn == 0))
                        {
                            goto Label_0061;
                        }
                    }
                    goto Label_0092;
                Label_0061:
                    smethod_9(current.ServerID, current.WorldID);
                    return true;
                }
            Label_0092:;
            }
            return false;
        }

        public static int smethod_5(string serverid)
        {
            int num = 0;
            lock (Players)
            {
                foreach (playerS rs in Players.Values)
                {
                    if (rs.ServerID == serverid)
                    {
                        num++;
                    }
                }
            }
            return num;
        }

        public static void smethod_6(string ServerID)
        {
            Dictionary<string, playerS> dictionary;
            ArrayList list = new ArrayList();
            lock ((dictionary = Players))
            {
                foreach (playerS rs in Players.Values)
                {
                    if (rs.ServerID == ServerID)
                    {
                        list.Add(rs);
                    }
                }
            }
            foreach (playerS rs2 in list)
            {
                RxjhClass.SetUserIdONLINE(rs2.UserId);
                rs2.npcyd.Dispose();
                lock ((dictionary = Players))
                {
                    Players.Remove(rs2.UserId);
                }
            }
        }

        public static PlayerHandler smethod_7(string serverid)
        {
            foreach (PlayerHandler handler in BbcServer.clients)
            {
                if (handler.ServerId == serverid)
                {
                    return handler;
                }
            }
            return null;
        }

        public static void smethod_8(string serverid)
        {
        }

        public static void smethod_9(string serverid, string userid)
        {
            try
            {
                if ((userid != "") && (serverid != ""))
                {
                    foreach (PlayerHandler handler in BbcServer.clients)
                    {
                        if (handler.ServerId == serverid)
                        {
                            handler.Sendd("用户踢出|" + userid);
                            return;
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private static void ZYDNGuard()
        {
            list = new Dictionary<int, NetState>();
            m_Disposed = Queue.Synchronized(new Queue());
            Connect = Queue.Synchronized(new Queue());
            queue_0 = Queue.Synchronized(new Queue());
            int_0 = 0;
            int_1 = 100;
            Db = new Dictionary<string, DbClass>();
            ServerList = new List<ServerClass>();
            BipList = new List<IPAddress>();
            ServerCount = 0;
            Players = new Dictionary<string, playerS>(0x7d0);
            KillList = new Dictionary<string, KillClass>();
            int_2 = 0xdaa2;
            AtPort = 0xdaac;
            int_3 = 0x514;
            int_4 = 10;
            int_5 = 0x3e8;
            int_6 = 0;
            ms = 0;
            ver = 1;
            int_7 = 100;
            int_8 = 0x400;
            int_9 = 1;
            aaaaaa = 1;
            string_2 = "";
            string_3 = "";
            string_4 = "";
            string_5 = "";
            string_6 = "http://rxjh.xwwl.net";
            string_7 = "";
            int_10 = 0x2710;
            bool_0 = false;
            bool_1 = true;
            bool_2 = true;
            bool_3 = true;
        }
    }
}

