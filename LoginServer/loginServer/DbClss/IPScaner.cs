namespace LoginServer.DbClss
{
    using System;
    using System.IO;
    using System.Text;

    public class IPScaner
    {
        private string country;
        private int countryFlag;
        private string dataPath;
        private long endIp;
        private long endIpOff;
        private string errMsg;
        private long firstStartIp;
        private string ip;
        private long lastStartIp;
        private string local;
        private FileStream objfs;
        private long startIp;

        static IPScaner()
        {
            ZYXDNGuarder.Startup();
        }

        private long a()
        {
            this.objfs.Position = this.endIpOff;
            byte[] buffer = new byte[5];
            this.objfs.Read(buffer, 0, 5);
            this.endIp = ((Convert.ToInt64(buffer[0].ToString()) + (Convert.ToInt64(buffer[1].ToString()) * 0x100L)) + ((Convert.ToInt64(buffer[2].ToString()) * 0x100L) * 0x100L)) + (((Convert.ToInt64(buffer[3].ToString()) * 0x100L) * 0x100L) * 0x100L);
            this.countryFlag = buffer[4];
            return this.endIp;
        }

        private string b()
        {
            switch (this.countryFlag)
            {
                case 1:
                case 2:
                    this.country = this.c(this.endIpOff + 4L);
                    this.local = (1 == this.countryFlag) ? " " : this.c(this.endIpOff + 8L);
                    break;

                default:
                    this.country = this.c(this.endIpOff + 4L);
                    this.local = this.c(this.objfs.Position);
                    break;
            }
            return " ";
        }

        private string c(long offSet)
        {
            int num = 0;
            byte[] buffer = new byte[3];
            while (true)
            {
                this.objfs.Position = offSet;
                num = this.objfs.ReadByte();
                if ((num != 1) && (num != 2))
                {
                    if (offSet < 12L)
                    {
                        return " ";
                    }
                    this.objfs.Position = offSet;
                    return this.d();
                }
                this.objfs.Read(buffer, 0, 3);
                if (num == 2)
                {
                    this.countryFlag = 2;
                    this.endIpOff = offSet - 4L;
                }
                offSet = (Convert.ToInt64(buffer[0].ToString()) + (Convert.ToInt64(buffer[1].ToString()) * 0x100L)) + ((Convert.ToInt64(buffer[2].ToString()) * 0x100L) * 0x100L);
            }
        }

        private string d()
        {
            byte num = 0;
            byte num2 = 0;
            string str = "";
            byte[] bytes = new byte[2];
            while (true)
            {
                num = (byte) this.objfs.ReadByte();
                if (num == 0)
                {
                    return str;
                }
                if (num > 0x7f)
                {
                    num2 = (byte) this.objfs.ReadByte();
                    bytes[0] = num;
                    bytes[1] = num2;
                    Encoding encoding = Encoding.GetEncoding("GB2312");
                    str = str + encoding.GetString(bytes);
                }
                else
                {
                    str = str + ((char) num);
                }
            }
        }

        public string IPLocation()
        {
            this.method_0();
            return (this.country + this.local);
        }

        public string IPLocation(string dataPath, string ip)
        {
            this.dataPath = dataPath;
            this.ip = ip;
            this.method_0();
            return (this.country + this.local);
        }

        private int method_0()
        {
            long num = this.method_1(this.ip);
            int num2 = 0;
            if ((num >= this.method_1("127.0.0.0")) && (num <= this.method_1("127.255.255.255")))
            {
                this.country = "本机内部环回地址";
                this.local = "";
                num2 = 1;
            }
            else if ((((num >= this.method_1("0.0.0.0")) && (num <= this.method_1("2.255.255.255"))) || ((num >= this.method_1("64.0.0.0")) && (num <= this.method_1("126.255.255.255")))) || ((num >= this.method_1("58.0.0.0")) && (num <= this.method_1("60.255.255.255"))))
            {
                this.country = "网络保留地址";
                this.local = "";
                num2 = 1;
            }
            this.objfs = new FileStream(this.dataPath, FileMode.Open, FileAccess.Read);
            try
            {
                this.objfs.Position = 0L;
                byte[] buffer = new byte[8];
                this.objfs.Read(buffer, 0, 8);
                this.firstStartIp = ((buffer[0] + (buffer[1] * 0x100)) + ((buffer[2] * 0x100) * 0x100)) + (((buffer[3] * 0x100) * 0x100) * 0x100);
                this.lastStartIp = ((buffer[4] + (buffer[5] * 0x100)) + ((buffer[6] * 0x100) * 0x100)) + (((buffer[7] * 0x100) * 0x100) * 0x100);
                long num3 = Convert.ToInt64((double) (((double) (this.lastStartIp - this.firstStartIp)) / 7.0));
                if (num3 <= 1L)
                {
                    this.country = "FileDataError";
                    this.objfs.Close();
                    return 2;
                }
                long num4 = num3;
                long recNO = 0L;
                long num6 = 0L;
                while (recNO < (num4 - 1L))
                {
                    num6 = (num4 + recNO) / 2L;
                    this.method_3(num6);
                    if (num == this.startIp)
                    {
                        goto Label_0229;
                    }
                    if (num > this.startIp)
                    {
                        recNO = num6;
                    }
                    else
                    {
                        num4 = num6;
                    }
                }
                goto Label_022D;
            Label_0229:
                recNO = num6;
            Label_022D:
                this.method_3(recNO);
                this.a();
                if ((this.startIp <= num) && (this.endIp >= num))
                {
                    this.b();
                    this.local = this.local.Replace("（我们一定要解放台湾！！！）", "");
                }
                else
                {
                    num2 = 3;
                    this.country = "未知";
                    this.local = "";
                }
                this.objfs.Close();
                return num2;
            }
            catch
            {
                return 1;
            }
        }

        private long method_1(string ip)
        {
            char[] separator = new char[] { '.' };
            if (ip.Split(separator).Length == 3)
            {
                ip = ip + ".0";
            }
            string[] strArray = ip.Split(separator);
            long num = ((long.Parse(strArray[0]) * 0x100L) * 0x100L) * 0x100L;
            long num2 = (long.Parse(strArray[1]) * 0x100L) * 0x100L;
            long num3 = long.Parse(strArray[2]) * 0x100L;
            long num4 = long.Parse(strArray[3]);
            return (((num + num2) + num3) + num4);
        }

        private string method_2(long ip_Int)
        {
            long num = (long) ((ip_Int & 0xff000000L) >> 0x18);
            if (num < 0L)
            {
                num += 0x100L;
            }
            long num2 = (ip_Int & 0xff0000L) >> 0x10;
            if (num2 < 0L)
            {
                num2 += 0x100L;
            }
            long num3 = (ip_Int & 0xff00L) >> 8;
            if (num3 < 0L)
            {
                num3 += 0x100L;
            }
            long num4 = ip_Int & 0xffL;
            if (num4 < 0L)
            {
                num4 += 0x100L;
            }
            return (num.ToString() + "." + num2.ToString() + "." + num3.ToString() + "." + num4.ToString());
        }

        private long method_3(long recNO)
        {
            long num = this.firstStartIp + (recNO * 7L);
            this.objfs.Position = num;
            byte[] buffer = new byte[7];
            this.objfs.Read(buffer, 0, 7);
            this.endIpOff = (Convert.ToInt64(buffer[4].ToString()) + (Convert.ToInt64(buffer[5].ToString()) * 0x100L)) + ((Convert.ToInt64(buffer[6].ToString()) * 0x100L) * 0x100L);
            this.startIp = ((Convert.ToInt64(buffer[0].ToString()) + (Convert.ToInt64(buffer[1].ToString()) * 0x100L)) + ((Convert.ToInt64(buffer[2].ToString()) * 0x100L) * 0x100L)) + (((Convert.ToInt64(buffer[3].ToString()) * 0x100L) * 0x100L) * 0x100L);
            return this.startIp;
        }

        public string Country =>
            this.country;

        public string DataPath
        {
            set
            {
                this.dataPath = value;
            }
        }

        public string ErrMsg =>
            this.errMsg;

        public string IP
        {
            set
            {
                this.ip = value;
            }
        }

        public string Local =>
            this.local;
    }
}

