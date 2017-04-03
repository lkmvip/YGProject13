namespace LoginServer.DbClss
{
    using System;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Windows.Forms;

    public class Config
    {
        private static string iniPath;

        static Config()
        {
            ZYXDNGuarder.Startup();
            ZYDNGuard();
        }

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        public static string IniReadValue(string Section, string Key)
        {
            StringBuilder retVal = new StringBuilder(0xff);
            GetPrivateProfileString(Section, Key, "", retVal, 0xff, iniPath);
            return retVal.ToString();
        }

        public static void IniWriteValue(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, iniPath);
        }

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        private static void ZYDNGuard()
        {
            iniPath = Application.StartupPath + @"\config.ini";
        }

        public static string Path
        {
            set
            {
                iniPath = value;
            }
        }
    }
}

