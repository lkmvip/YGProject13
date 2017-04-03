namespace LoginServer
{
      using System;

      public class ServerXlClass
      {
            private string _SERVER_IP;
            private string _SERVER_NAME;
            private string _SERVER_PORT;
            private int _ServerId;
            private int _ServerId2;
            private int _ServerZId;

            static ServerXlClass()
            {
                  ZYXDNGuarder.Startup();
            }

            public string SERVER_IP
            {
                  get
                  {
                        return this._SERVER_IP;
                  }
                  set
                  {
                        this._SERVER_IP = value;
                  }
            }

            public string SERVER_NAME
            {
                  get
                  {
                        return this._SERVER_NAME;
                  }
                  set
                  {
                        this._SERVER_NAME = value;
                  }
            }

            public string SERVER_PORT
            {
                  get
                  {
                        return this._SERVER_PORT;
                  }
                  set
                  {
                        this._SERVER_PORT = value;
                  }
            }

            public int ServerId
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

            public int ServerId2
            {
                  get
                  {
                        return this._ServerId2;
                  }
                  set
                  {
                        this._ServerId2 = value;
                  }
            }

            public int ServerZId
            {
                  get
                  {
                        return this._ServerZId;
                  }
                  set
                  {
                        this._ServerZId = value;
                  }
            }
      }
}

