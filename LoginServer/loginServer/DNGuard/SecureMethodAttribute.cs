namespace DNGuard
{
    using System;

    public sealed class SecureMethodAttribute : Attribute
    {
        static SecureMethodAttribute()
        {
            ZYXDNGuarder.Startup();
        }
    }
}

