namespace DNGuard
{
    using System;

    public sealed class SecureCallbackMethodAttribute : Attribute
    {
        static SecureCallbackMethodAttribute()
        {
            ZYXDNGuarder.Startup();
        }
    }
}

