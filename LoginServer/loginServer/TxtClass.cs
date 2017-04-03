namespace LoginServer
{
      using System;

      public class TxtClass
      {
            private string m_txt;
            private int m_type;

            static TxtClass()
            {
                  ZYXDNGuarder.Startup();
            }

            public TxtClass(int type, string txtt)
            {
                  this.m_type = type;
                  this.m_txt = txtt;
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

            public int type
            {
                  get
                  {
                        return this.m_type;
                  }
                  set
                  {
                        this.m_type = value;
                  }
            }
      }
}

