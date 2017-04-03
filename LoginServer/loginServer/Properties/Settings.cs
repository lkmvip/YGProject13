namespace LoginServer.Properties
{
    using System;
    using System.CodeDom.Compiler;
    using System.Configuration;
    using System.Runtime.CompilerServices;

    [CompilerGenerated, GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed class Settings : ApplicationSettingsBase
    {
        private static Settings defaultInstance;

        static Settings()
        {
            ZYXDNGuarder.Startup();
            ZYDNGuard();
        }

        private static void ZYDNGuard()
        {
            defaultInstance = (Settings) SettingsBase.Synchronized(new Settings());
        }

        public static Settings Default =>
            defaultInstance;
    }
}

