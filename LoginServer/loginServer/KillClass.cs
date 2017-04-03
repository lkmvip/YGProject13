namespace LoginServer
{
      using System;
      using System.Timers;

      public class KillClass
      {
            private int _conn;
            public Timer npcyd = new Timer(300000.0);
            public DateTime time = DateTime.Now.AddMinutes(5.0);
            private string userid;

            static KillClass()
            {
                  ZYXDNGuarder.Startup();
            }

            public KillClass()
            {
                  this.npcyd.Elapsed += new ElapsedEventHandler(this.npcyd_Elapsed);
                  this.npcyd.Enabled = true;
            }

            private TimeSpan method_0() =>
                this.time.Subtract(DateTime.Now);

            public void npcyd_Elapsed(object sender, ElapsedEventArgs e)
            {
                  lock (World.KillList)
                  {
                        World.KillList.Remove(this.UserId);
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

            public TimeSpan TimeSpan_0 =>
                this.method_0();

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
      }
}

