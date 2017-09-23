using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using System.Configuration;
using System.Diagnostics;
using System;

namespace Accounting.Properties
{
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
[CompilerGenerated]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance;

	[SpecialSetting(SpecialSetting.ConnectionString)]
	[DefaultSettingValue("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Data\\AccountingDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")]
	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public string AccountingDBConnectionString
	{
		get
		{
			return (string)base["AccountingDBConnectionString"];
		}
	}

	public static Settings Default
	{
		get
		{
			return Settings.defaultInstance;
		}
	}

	static Settings()
	{
		Settings.defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}

	public Settings()
	{
	}
}
}