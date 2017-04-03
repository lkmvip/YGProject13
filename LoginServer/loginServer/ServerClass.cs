namespace LoginServer
{
      using System;
      using System.Collections.Generic;

      public class ServerClass
      {
            private string _SERVER_NAME;
            private int _ServerCount;
            private int int_0;
            public List<ServerXlClass> ServerList = new List<ServerXlClass>();

            static ServerClass()
            {
                  ZYXDNGuarder.Startup();
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

            public int ServerCount
            {
                  get
                  {
                        return this._ServerCount;
                  }
                  set
                  {
                        this._ServerCount = value;
                  }
            }
      }
}

