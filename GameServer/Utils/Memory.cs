using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ns9
{
	internal class Memory
	{
		private static Version version_0;

		static Memory()
		{
			Memory.ZYDNGuard();
		}

		public Memory()
		{
		}

		[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern int SetProcessWorkingSetSize(IntPtr intptr_0, int int_0, int int_1);

		public static int smethod_0()
		{
			return Memory.smethod_1(Process.GetCurrentProcess().Handle);
		}

		public static int smethod_1(IntPtr intptr_0)
		{
			if (Environment.OSVersion.Platform != PlatformID.Win32NT)
			{
				return -1;
			}
			return Memory.SetProcessWorkingSetSize(intptr_0, -1, -1);
		}

		private static void ZYDNGuard()
		{
			Memory.version_0 = new Version(1, 0);
		}
	}
}