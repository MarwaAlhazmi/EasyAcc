﻿using CrystalDecisions.CrystalReports.Engine;
using System;
using System.ComponentModel;
using CrystalDecisions.Shared;

namespace Accounting.bin.Debug
{
public class BalanceReportCR : ReportClass
{
	public string FullResourceName
	{
		get
		{
			return "Accounting.bin.Debug.BalanceReportCR.rpt";
		}
		set
		{
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

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public IParameterField Parameter_account
	{
		get
		{
			return base.DataDefinition.ParameterFields[1];
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public IParameterField Parameter_dtTo
	{
		get
		{
			return base.DataDefinition.ParameterFields[0];
		}
	}

	public string ResourceName
	{
		get
		{
			return "BalanceReportCR.rpt";
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

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section Section3
	{
		get
		{
			return base.ReportDefinition.Sections[2];
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Section Section4
	{
		get
		{
			return base.ReportDefinition.Sections[3];
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section Section5
	{
		get
		{
			return base.ReportDefinition.Sections[4];
		}
	}

	public BalanceReportCR()
	{
	}
}
}