namespace DNGuard
{
    using System;

    public sealed class NonSecureAttribute : Attribute
    {
        static NonSecureAttribute()
        {
            ZYXDNGuarder.Startup();
        }
    }
}

