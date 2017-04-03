namespace LoginServer
{
    using System;
    using System.IO;

    public class logo
    {
        static logo()
        {
            ZYXDNGuarder.Startup();
        }

        public static void FileTxtLog(string ErrTxt)
        {
            try
            {
                if (!Directory.Exists("logs"))
                {
                    Directory.CreateDirectory("logs");
                }
                using (StreamWriter writer = new StreamWriter(new FileStream(@"logs\错误日志_" + DateTime.Now.ToString("yyyy_MM_dd") + ".log", FileMode.Append, FileAccess.Write, FileShare.Read)))
                {
                    writer.Write(string.Concat(new object[] { DateTime.Now, " ", ErrTxt, "\r\n" }));
                }
            }
            catch
            {
            }
        }
    }
}

