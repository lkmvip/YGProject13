using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace RxjhServer.Properties
{
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
	internal sealed class Settings : ApplicationSettingsBase
	{
		private static Settings settings_0;

		public static Settings Default
		{
			get
			{
				return Settings.settings_0;
			}
		}

		static Settings()
		{
			Settings.ZYDNGuard();
		}

		public Settings()
		{
		}

		private void method_0(object sender, SettingChangingEventArgs e)
		{
		}

		private void method_1(object sender, CancelEventArgs e)
		{
		}

		private static void ZYDNGuard()
		{
			Settings.settings_0 = (Settings)SettingsBase.Synchronized(new Settings());
		}
	}
}