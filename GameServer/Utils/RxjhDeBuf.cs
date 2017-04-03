using ns13;
using System;
using System.Runtime.InteropServices;

namespace ns4
{
	internal class RxjhDeBuf
	{
		private static IntPtr intptr_0;

		public RxjhDeBuf()
		{
		}

		[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=false, SetLastError=true)]
		public static extern bool FreeLibrary(IntPtr intptr_1);

		[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=false, SetLastError=true)]
		public static extern int GetProcAddress(IntPtr intptr_1, string string_0);

		[DllImport("Kernel32.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern IntPtr LoadLibrary(string string_0);

		private static Delegate DelegateGetProcAddress(IntPtr intptr_1, string string_0, Type type_0)
		{
			int procAddress = GetProcAddress(intptr_0, string_0);
			if (procAddress == 0)
			{
				return null;
			}
			return Marshal.GetDelegateForFunctionPointer(new IntPtr(procAddress), type_0);
		}

		public static void LoadLibrary()
		{
			intptr_0 = LoadLibrary("rxjhDeBuf.dll");
			if (intptr_0.ToInt32() != 0)
			{
				Form1.WriteLine(2, "The logger plugin is loaded successfully");
			}
		}

		public static void FreeLibrary()
		{
			FreeLibrary(intptr_0);
		}

		public static void Decrypt(byte[] byte_0, int int_0)
		{
			try
			{
				((Delegate9)DelegateGetProcAddress(intptr_0, "Decrypt", typeof(Delegate9)))(byte_0, int_0);
			}
			catch (Exception exception)
			{
				Form1.WriteLine(1, "rxjhDeBuf.dll Version error!!");
			}
		}

		public delegate int Delegate9(byte[] lpBuffer, int nDataLength);
	}
}