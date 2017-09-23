using System.Drawing;
using System;
using System.ComponentModel;
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Accounting.bin.Debug
{
[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
public class CachedBalanceSheetCR : Component, ICachedReport
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

	public CachedBalanceSheetCR()
	{
	}

	public virtual ReportDocument CreateReport()
	{
		BalanceSheetCR balanceSheetCR = new BalanceSheetCR();
		balanceSheetCR.Site = this.Site;
		return balanceSheetCR;
	}

	public virtual string GetCustomizedCacheKey(RequestContext request)
	{
		string str = null;
		return str;
	}
}
}