using System.Drawing;
using System;
using System.ComponentModel;
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Accounting.bin.Debug
{
[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
public class CachedJournalCR : Component, ICachedReport
{
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public TimeSpan CacheTimeOut
	{
		get
		{
			return CachedReportConstants.DEFAULT_TIMEOUT;
		}
		set
		{
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool IsCacheable
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool ShareDBLogonInfo
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public CachedJournalCR()
	{
	}

	public virtual ReportDocument CreateReport()
	{
		JournalCR journalCR = new JournalCR();
		journalCR.Site = this.Site;
		return journalCR;
	}

	public virtual string GetCustomizedCacheKey(RequestContext request)
	{
		string str = null;
		return str;
	}
}
}