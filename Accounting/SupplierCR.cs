using CrystalDecisions.CrystalReports.Engine;
using System;
using System.ComponentModel;

namespace Accounting
{
public class SupplierCR : ReportClass
{
	public string FullResourceName
	{
		get
		{
			return "Accounting.SupplierCR.rpt";
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

	public string ResourceName
	{
		get
		{
			return "SupplierCR.rpt";
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

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section Section4
	{
		get
		{
			return base.ReportDefinition.Sections[3];
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Section Section5
	{
		get
		{
			return base.ReportDefinition.Sections[4];
		}
	}

	public SupplierCR()
	{
	}
}
}