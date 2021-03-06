﻿using CrystalDecisions.CrystalReports.Engine;
using System;
using System.ComponentModel;
using CrystalDecisions.Shared;

namespace Accounting.bin.Debug
{
public class reportTest : ReportClass
{
	public string FullResourceName
	{
		get
		{
			return "Accounting.bin.Debug.reportTest.rpt";
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
			return base.DataDefinition.ParameterFields[2];
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public IParameterField Parameter_dtFrom
	{
		get
		{
			return base.DataDefinition.ParameterFields[0];
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public IParameterField Parameter_dtTo
	{
		get
		{
			return base.DataDefinition.ParameterFields[1];
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public IParameterField Parameter_tBalance
	{
		get
		{
			return base.DataDefinition.ParameterFields[3];
		}
	}

	public string ResourceName
	{
		get
		{
			return "reportTest.rpt";
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

	public reportTest()
	{
	}
}
}