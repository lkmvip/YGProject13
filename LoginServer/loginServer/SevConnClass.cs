namespace LoginServer
{
      using System;

      public class SevConnClass
      {
            private PlayerHandler _Server;
            private string _ServerID;
            private string _ServerID2;
            private string _UserIp;
            private string _WorldID;
            private string userid;

            static SevConnClass()
            {
                  ZYXDNGuarder.Startup();
            }

            public PlayerHandler Server
            {
                  get
                  {
                        return this._Server;
                  }
                  set
                  {
                        this._Server = value;
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

            public string ServerID2
            {
                  get
                  {
                        return this._ServerID2;
                  }
                  set
                  {
                        this._ServerID2 = value;
                  }
            }

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

