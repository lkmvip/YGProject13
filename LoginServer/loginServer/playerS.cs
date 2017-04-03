namespace LoginServer
{
      using LoginServer.DbClss;
      using System;
      using System.Timers;

      public class playerS
      {
            private int _conn;
            private string _ServerID;
            private string _ServerIDD;
            private string _UserIp;
            private string _WorldID;
            public Timer npcyd = new Timer(600000.0);
            public DateTime time = DateTime.Now;
            private string userid;

            static playerS()
            {
                  ZYXDNGuarder.Startup();
            }

            public playerS()
            {
                  this.npcyd.Elapsed += new ElapsedEventHandler(this.npcyd_Elapsed);
                  this.npcyd.Enabled = true;
            }

            private TimeSpan f() =>
                DateTime.Now.Subtract(this.time);

            public void npcyd_Elapsed(object sender, ElapsedEventArgs e)
            {
                  if (this.conn == 1)
                  {
                        RxjhClass.SetUserIdONLINE(this.UserId);
                        lock (World.Players)
                        {
                              World.Players.Remove(this.UserId);
                        }
                  }
                  this.npcyd.Close();
                  this.npcyd.Dispose();
            }

            public int conn
            {
                  get
                  {
                        return this._conn;
                  }
                  set
                  {
                        this._conn = value;
                  }
            }

            public string ServerID
            {
                  get
                  {
                        return this._ServerID;
                  }
                  set
                  {
                        this._ServerID = value;
                  }
            }

            public string ServerIDD
            {
                  get
                  {
                        return this._ServerIDD;
                  }
                  set
                  {
                        this._ServerIDD = value;
                  }
            }

            public TimeSpan TimeSpan_0 =>
                this.f();

            public string UserId
            {
                  get
                  {
                        return this.userid;
                  }
                  set
                  {
                        this.userid = value;
                  }
            }

            public string UserIp
            {
                  get
                  {
                        return this._UserIp;
                  }
                  set
                  {
                        this._UserIp = value;
                  }
            }

            public string WorldID
            {
                  get
                  {
                        return this._WorldID;
                  }
                  set
                  {
                        this._WorldID = value;
                  }
            }
      }
}

