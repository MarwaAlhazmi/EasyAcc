using System.Drawing;
using System;
using System.ComponentModel;
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Accounting.bin.Debug
{
[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
public class CachedreportTest : Component, ICachedReport
{
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
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

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
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

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

	public CachedreportTest()
	{
	}

	public virtual ReportDocument CreateReport()
	{
		reportTest _reportTest = new reportTest();
		_reportTest.Site = this.Site;
		return _reportTest;
	}

	public virtual string GetCustomizedCacheKey(RequestContext request)
	{
		string str = null;
		return str;
	}
}
}