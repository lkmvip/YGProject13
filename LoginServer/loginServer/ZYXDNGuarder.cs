using System;
using System.Runtime.InteropServices;

public sealed class ZYXDNGuarder
{
    private static IntPtr m_bStartup;

    internal static bool CheckRuntime()
    {
        throw new Exception("-=Load DNGuard Runtime library failed, runtime library not found or Access Denied.=-");
    }

    internal static IntPtr CheckString(int int_0, int int_1)
    {
        if (IntPtr.Size != 4)
        {
            IntPtr p = m_bStartup;
            int num3 = int_0;
            int num4 = int_1;
            return GetUserString_1(p, num3, num4);
        }
        IntPtr bStartup = m_bStartup;
        int num2 = int_0;
        int num = int_1;
        return GetUserString(bStartup, num2, num);
    }

    [DllImport("Login.dll")]
    private static extern bool DNG_Runtime();
    [DllImport("HVMRun64.dll", EntryPoint="DNG_Runtime")]
    private static extern bool DNG_Runtime_1();
    [DllImport("Login.dll")]
    private static extern IntPtr GetUserString(IntPtr p, int p1, int p2);
    [DllImport("HVMRun64.dll", EntryPoint="GetUserString")]
    private static extern IntPtr GetUserString_1(IntPtr p, int p1, int p2);
    [DllImport("Login.dll")]
    private static extern IntPtr RunHVM();
    internal static IntPtr RunHVM2()
    {
        throw new Exception("-=Load DNGuard Runtime library failed, runtime library not found or Access Denied.=-");
    }

    internal static void Startup()
    {
    }
}

