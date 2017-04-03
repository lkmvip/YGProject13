namespace LoginServer
{
      using System;

      public class GClass0
      {
            private int int_0;
            private int m_FLD_INDEX;
            private int m_Map;
            private string m_txt;
            private int m_TxtId;
            private string m_UserClientIP;
            private string m_UserName;

            static GClass0()
            {
                  ZYXDNGuarder.Startup();
            }

            public int FLD_INDEX
            {
                  get
                  {
                        return this.m_FLD_INDEX;
                  }
                  set
                  {
                        this.m_FLD_INDEX = value;
                  }
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

            public int Map
            {
                  get
                  {
                        return this.m_Map;
                  }
                  set
                  {
                        this.m_Map = value;
                  }
            }

            public string Txt
            {
                  get
                  {
                        return this.m_txt;
                  }
                  set
                  {
                        this.m_txt = value;
                  }
            }

            public int TxtId
            {
                  get
                  {
                        return this.m_TxtId;
                  }
                  set
                  {
                        this.m_TxtId = value;
                  }
            }

            public string UserClientIP
            {
                  get
                  {
                        return this.m_UserClientIP;
                  }
                  set
                  {
                        this.m_UserClientIP = value;
                  }
            }

            public string UserName
            {
                  get
                  {
                        return this.m_UserName;
                  }
                  set
                  {
                        this.m_UserName = value;
                  }
            }
      }
}

