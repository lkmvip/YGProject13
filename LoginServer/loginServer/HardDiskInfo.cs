namespace LoginServer
{
    using System;
    using System.Runtime.InteropServices;

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct HardDiskInfo
    {
        public string ModuleNumber;
        public string Firmware;
        public string SerialNumber;
        public uint Capacity;
    }
}

