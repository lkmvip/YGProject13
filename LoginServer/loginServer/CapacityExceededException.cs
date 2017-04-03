namespace LoginServer
{
    using System;

    public sealed class CapacityExceededException : Exception
    {
        static CapacityExceededException()
        {
            ZYXDNGuarder.Startup();
        }

        public CapacityExceededException() : base("Too much data pending.")
        {
        }
    }
}

