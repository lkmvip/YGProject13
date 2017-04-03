using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ns9
{
	internal class Config
	{
		private static string string_0;

		private static string string_1;

		private static string string_2;

		private static string string_3;

		public static string Path
		{
			set
			{
				Config.string_0 = value;
			}
		}

		public static string Pathgj
		{
			set
			{
				Config.string_3 = value;
			}
		}

		public static string Pathqg
		{
			set
			{
				Config.string_1 = value;
			}
		}

		public static string Pathst
		{
			set
			{
				Config.string_2 = value;
			}
		}

		static Config()
		{
			Config.ZYDNGuard();
		}

		public Config()
		{
		}

		[DllImport("kernel32", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern int GetPrivateProfileString(string string_4, string string_5, string string_6, StringBuilder stringBuilder_0, int int_0, string string_7);

		public static string IniReadValue(string string_4, string string_5)
		{
			StringBuilder stringBuilder = new StringBuilder(1024);
			Config.GetPrivateProfileString(string_4, string_5, "", stringBuilder, 1024, Config.string_0);
			return stringBuilder.ToString();
		}

		public static void smethod_0(string string_4, string string_5, string string_6)
		{
			Config.WritePrivateProfileString(string_4, string_5, string_6, Config.string_0);
		}

		public static string smethod_2(string string_4, string string_5)
		{
			StringBuilder stringBuilder = new StringBuilder(1024);
			Config.GetPrivateProfileString(string_4, string_5, "", stringBuilder, 1024, Config.string_1);
			return stringBuilder.ToString();
		}

		public static string smethod_3(string string_4, string string_5)
		{
			StringBuilder stringBuilder = new StringBuilder(1024);
			Config.GetPrivateProfileString(string_4, string_5, "", stringBuilder, 1024, Config.string_2);
			return stringBuilder.ToString();
		}

		public static string smethod_4(string string_4, string string_5)
		{
			StringBuilder stringBuilder = new StringBuilder(1024);
			Config.GetPrivateProfileString(string_4, string_5, "", stringBuilder, 1024, Config.string_3);
			return stringBuilder.ToString();
		}

		[DllImport("kernel32", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern long WritePrivateProfileString(string string_4, string string_5, string string_6, string string_7);

		private static void ZYDNGuard()
		{
			Config.string_0 = string.Concat(Application.StartupPath, "\\GameConfiguration.ini");
			Config.string_1 = string.Concat(Application.StartupPath, "\\QigongConfiguration.ini");
			Config.string_2 = string.Concat(Application.StartupPath, "\\StoneConfiguration.ini");
			Config.string_3 = string.Concat(Application.StartupPath, "\\HookConfiguration.ini");
		}
	}
}