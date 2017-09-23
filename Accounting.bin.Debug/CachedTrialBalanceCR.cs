using System.Drawing;
using System;
using System.ComponentModel;
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Accounting.bin.Debug
{
[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
public class CachedTrialBalanceCR : Component, ICachedReport
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

	public CachedTrialBalanceCR()
	{
	}

	public virtual ReportDocument CreateReport()
	{
		TrialBalanceCR trialBalanceCR = new TrialBalanceCR();
		trialBalanceCR.Site = this.Site;
		return trialBalanceCR;
	}

	public virtual string GetCustomizedCacheKey(RequestContext request)
	{
		string str = null;
		return str;
	}
}
}