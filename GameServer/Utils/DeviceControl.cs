namespace ns12
{
      using ns11;
      using ns2;
      using ns3;
      using ns7;
      using RxjhServer;
      using System;
      using System.Runtime.InteropServices;
      using System.Text;

      internal class DeviceControl
      {
            private const uint uint_0 = 0x74080;
            private const uint uint_1 = 0x7c084;
            private const uint uint_2 = 0x7c088;
            private const uint uint_3 = 0x80000000;
            private const uint uint_4 = 0x40000000;
            private const uint uint_5 = 1;
            private const uint uint_6 = 2;
            private const uint uint_7 = 1;
            private const uint uint_8 = 3;

            [DllImport("kernel32.dll", SetLastError = true)]
            private static extern int CloseHandle(IntPtr intptr_0);
            [DllImport("kernel32.dll", SetLastError = true)]
            private static extern IntPtr CreateFile(string string_0, uint uint_9, uint uint_10, IntPtr intptr_0, uint uint_11, uint uint_12, IntPtr intptr_1);
            [DllImport("kernel32.dll")]
            private static extern int DeviceIoControl(IntPtr intptr_0, uint uint_9, IntPtr intptr_1, uint uint_10, ref Struct0 struct0_0, uint uint_11, ref uint uint_12, [Out] IntPtr intptr_2);
            [DllImport("kernel32.dll", EntryPoint = "DeviceIoControl")]
            private static extern int DeviceIoControl_1(IntPtr intptr_0, uint uint_9, ref Struct2 struct2_0, uint uint_10, ref Struct4 struct4_0, uint uint_11, ref uint uint_12, [Out] IntPtr intptr_1);
            public static HardDiskInfo smethod_0(byte byte_0)
            {
                  switch (Environment.OSVersion.Platform)
                  {
                        case PlatformID.Win32S:
                              throw new NotSupportedException("Win32s   is   not   supported.");

                        case PlatformID.Win32Windows:
                              return smethod_1(byte_0);

                        case PlatformID.Win32NT:
                              return smethod_2(byte_0);

                        case PlatformID.WinCE:
                              throw new NotSupportedException("WinCE   is   not   supported.");
                  }
                  throw new NotSupportedException("Unknown   Platform.");
            }

            private static HardDiskInfo smethod_1(byte byte_0)
            {
                  Struct0 struct2 = new Struct0();
                  Struct2 struct3 = new Struct2();
                  Struct4 struct4 = new Struct4();
                  uint num = 0;
                  IntPtr ptr = CreateFile(@"\\.\Smartvsd", 0, 0, IntPtr.Zero, 1, 0, IntPtr.Zero);
                  if (ptr == IntPtr.Zero)
                  {
                        throw new Exception("Open   smartvsd.vxd   failed.");
                  }
                  if (DeviceIoControl(ptr, 0x74080, IntPtr.Zero, 0, ref struct2, (uint)Marshal.SizeOf(struct2), ref num, IntPtr.Zero) == 0)
                  {
                        CloseHandle(ptr);
                        throw new Exception("DeviceIoControl   failed:DFP_GET_VERSION");
                  }
                  if ((struct2.uint_0 & 1) == 0)
                  {
                        CloseHandle(ptr);
                        throw new Exception("Error:   IDE   identify   command   not   supported.");
                  }
                  if ((byte_0 & 1) != 0)
                  {
                        struct3.struct1_0.byte_5 = 0xb0;
                  }
                  else
                  {
                        struct3.struct1_0.byte_5 = 160;
                  }
                  if ((struct2.uint_0 & (((int)0x10) >> byte_0)) != 0)
                  {
                        CloseHandle(ptr);
                        throw new Exception($"Drive   {byte_0 + 1}   is   a   ATAPI   device,   we   don't   detect   it");
                  }
                  struct3.struct1_0.byte_6 = 0xec;
                  struct3.byte_0 = byte_0;
                  struct3.struct1_0.byte_1 = 1;
                  struct3.struct1_0.byte_2 = 1;
                  struct3.uint_0 = 0x200;
                  if (DeviceIoControl_1(ptr, 0x7c088, ref struct3, (uint)Marshal.SizeOf(struct3), ref struct4, (uint)Marshal.SizeOf(struct4), ref num, IntPtr.Zero) == 0)
                  {
                        CloseHandle(ptr);
                        throw new Exception("DeviceIoControl   failed:   DFP_RECEIVE_DRIVE_DATA");
                  }
                  CloseHandle(ptr);
                  return smethod_3(struct4.struct5_0);
            }

            private static HardDiskInfo smethod_2(byte byte_0)
            {
                  Struct0 struct2 = new Struct0();
                  Struct2 struct3 = new Struct2();
                  Struct4 struct4 = new Struct4();
                  uint num = 0;
                  IntPtr ptr = CreateFile($"\\PhysicalDrive" + byte_0, 0xc0000000, 3, IntPtr.Zero, 3, 0, IntPtr.Zero);
                  if (ptr == IntPtr.Zero)
                  {
                        throw new Exception("CreateFile   faild.");
                  }
                  if (DeviceIoControl(ptr, 0x74080, IntPtr.Zero, 0, ref struct2, (uint)Marshal.SizeOf(struct2), ref num, IntPtr.Zero) == 0)
                  {
                        CloseHandle(ptr);
                        throw new Exception($"Drive   {byte_0 + 1}   may   not   exists.");
                  }
                  if ((struct2.uint_0 & 1) == 0)
                  {
                        CloseHandle(ptr);
                        throw new Exception("Error:   IDE   identify   command   not   supported.");
                  }
                  if ((byte_0 & 1) != 0)
                  {
                        struct3.struct1_0.byte_5 = 0xb0;
                  }
                  else
                  {
                        struct3.struct1_0.byte_5 = 160;
                  }
                  if ((struct2.uint_0 & (((int)0x10) >> byte_0)) != 0)
                  {
                        CloseHandle(ptr);
                        throw new Exception($"Drive   {byte_0 + 1}   is   a   ATAPI   device,   we   don't   detect   it.");
                  }
                  struct3.struct1_0.byte_6 = 0xec;
                  struct3.byte_0 = byte_0;
                  struct3.struct1_0.byte_1 = 1;
                  struct3.struct1_0.byte_2 = 1;
                  struct3.uint_0 = 0x200;
                  if (DeviceIoControl_1(ptr, 0x7c088, ref struct3, (uint)Marshal.SizeOf(struct3), ref struct4, (uint)Marshal.SizeOf(struct4), ref num, IntPtr.Zero) == 0)
                  {
                        CloseHandle(ptr);
                        throw new Exception("DeviceIoControl   failed:   DFP_RECEIVE_DRIVE_DATA");
                  }
                  CloseHandle(ptr);
                  return smethod_3(struct4.struct5_0);
            }

            private static HardDiskInfo smethod_3(Struct5 struct5_0)
            {
                  HardDiskInfo info = new HardDiskInfo();
                  smethod_4(struct5_0.byte_2);
                  info.ModuleNumber = Encoding.ASCII.GetString(struct5_0.byte_2).Trim();
                  smethod_4(struct5_0.byte_1);
                  info.Firmware = Encoding.ASCII.GetString(struct5_0.byte_1).Trim();
                  smethod_4(struct5_0.byte_0);
                  info.SerialNumber = Encoding.ASCII.GetString(struct5_0.byte_0).Trim();
                  info.Capacity = (struct5_0.uint_1 / 2) / 0x400;
                  return info;
            }

            private static void smethod_4(byte[] byte_0)
            {
                  for (int i = 0; i < byte_0.Length; i += 2)
                  {
                        byte num2 = byte_0[i];
                        byte_0[i] = byte_0[i + 1];
                        byte_0[i + 1] = num2;
                  }
            }

            public static string smethod_5()
            {
                  try
                  {
                        return smethod_0(0).SerialNumber;
                  }
                  catch (Exception)
                  {
                        return "0";
                  }
            }
      }
}

