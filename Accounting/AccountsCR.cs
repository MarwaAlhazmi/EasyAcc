using CrystalDecisions.CrystalReports.Engine;
using System;
using System.ComponentModel;

namespace Accounting
{
public class AccountsCR : ReportClass
{
	public string FullResourceName
	{
		get
		{
			return "Accounting.AccountsCR.rpt";
		}
		set
		{
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section GroupFooterSection1
	{
		get
		{
			return base.ReportDefinition.Sections[4];
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section GroupHeaderSection1
	{
		get
		{
			return base.ReportDefinition.Sections[2];
		}
	}

	public bool NewGenerator
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	public string ResourceName
	{
		get
		{
			return "AccountsCR.rpt";
		}
		set
		{
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Section Section1
	{
		get
		{
			return base.ReportDefinition.Sections[0];
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section Section2
	{
		get
		{
			return base.ReportDefinition.Sections[1];
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Section Section3
	{
		get
		{
			return base.ReportDefinition.Sections[3];
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Section Section4
	{
		get
		{
			return base.ReportDefinition.Sections[5];
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Section Section5
	{
		get
		{
			return base.ReportDefinition.Sections[6];
		}
	}

	public AccountsCR()
	{
	}
}
}