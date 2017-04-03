using System;
using System.Runtime.InteropServices;

namespace ns11
{
	internal class Netapi32
	{
		public Netapi32()
		{
		}

		[DllImport("Netapi32.dll", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern int NetApiBufferFree(IntPtr intptr_0);

		[DllImport("Netapi32.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern int NetUserAdd(string string_0, int int_0, ref Netapi32.Struct6 struct6_0, int int_1);

		[DllImport("Netapi32.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern int NetUserChangePassword(string string_0, string string_1, string string_2, string string_3);

		[DllImport("Netapi32.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern int NetUserDel(string string_0, string string_1);

		[DllImport("Netapi32.dll", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern int NetUserEnum(string string_0, int int_0, int int_1, out IntPtr intptr_0, int int_2, out int int_3, out int int_4, out int int_5);

		[DllImport("Netapi32.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern int NetUserGetInfo(string string_0, string string_1, int int_0, out IntPtr intptr_0);

		[DllImport("Netapi32.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern int NetUserGetLocalGroups(string string_0, string string_1, int int_0, int int_1, out IntPtr intptr_0, int int_2, out int int_3, out int int_4);

		[DllImport("Netapi32.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern int NetUserSetInfo(string string_0, string string_1, int int_0, ref Netapi32.Struct6 struct6_0, int int_1);

		public struct Struct6
		{
			public string string_0;

			public string string_1;

			public int int_0;

			public int int_1;

			public string string_2;

			public string string_3;

			public int int_2;

			public string string_4;
		}

		public struct Struct7
		{
			public string string_0;
		}

		public struct Struct8
		{
			public string string_0;
		}
	}
}