using System.Drawing;
using System;
using System.ComponentModel;
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Accounting
{
[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
public class CachedAccountsCR : Component, ICachedReport
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

	public CachedAccountsCR()
	{
	}

	public virtual ReportDocument CreateReport()
	{
		AccountsCR accountsCR = new AccountsCR();
		accountsCR.Site = this.Site;
		return accountsCR;
	}

	public virtual string GetCustomizedCacheKey(RequestContext request)
	{
		string str = null;
		return str;
	}
}
}