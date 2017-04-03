namespace LoginServer
{
    using System;

    public class ThreadParameter
    {
        private byte[] _databyte;
        private playerS Playes;

        static ThreadParameter()
        {
            ZYXDNGuarder.Startup();
        }

        public ThreadParameter(byte[] date)
        {
            this.Databyte = date;
        }

        public ThreadParameter(byte[] date, playerS play)
        {
            this.Databyte = date;
            this.players = play;
        }

        public byte[] Databyte
        {
            get
                  {
                   return     this._databyte;
                  }
            set
            {
                this._databyte = value;
            }
        }

        public playerS players
        {
            get
                  {
                   return     this.Playes;
                  }
            set
            {
                this.Playes = value;
            }
        }
    }
}

