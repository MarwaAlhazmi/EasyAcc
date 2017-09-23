using CrystalDecisions.CrystalReports.Engine;
using System;
using System.ComponentModel;
using CrystalDecisions.Shared;

namespace Accounting.bin.Debug
{
public class TrialBalanceCR : ReportClass
{
	public string FullResourceName
	{
		get
		{
			return "Accounting.bin.Debug.TrialBalanceCR.rpt";
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

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public IParameterField Parameter_from
	{
		get
		{
			return base.DataDefinition.ParameterFields[0];
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public IParameterField Parameter_to
	{
		get
		{
			return base.DataDefinition.ParameterFields[1];
		}
	}

	public string ResourceName
	{
		get
		{
			return "TrialBalanceCR.rpt";
		}
		set
		{
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section Section1
	{
		get
		{
			return base.ReportDefinition.Sections[0];
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
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

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

	public TrialBalanceCR()
	{
	}
}
}