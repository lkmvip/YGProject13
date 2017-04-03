using ns3;
using RxjhServer;
using System;

namespace ns6
{
	internal class ConnectString
	{
		public static bool bool_0;

		public static bool bool_1;

		public static int int_0;

		public static int int_1;

		public static string string_0;

		public static string string_1;

		public static string string_2;

		static ConnectString()
		{
			ConnectString.ZYDNGuard();
		}

		public ConnectString()
		{
		}

		private static void ZYDNGuard()
		{
			ConnectString.int_0 = 9999;
			ConnectString.string_0 = "yes99888.xicp.net";
			ConnectString.string_1 = "专用版本";
			ConnectString.string_2 = string.Concat("当前人数", World.allConnectedChars.Count);
			ConnectString.bool_0 = true;
			ConnectString.bool_1 = true;
			ConnectString.int_1 = 6666;
		}
	}
}