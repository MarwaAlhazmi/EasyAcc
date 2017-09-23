using System.ComponentModel;
using System.ComponentModel.Design;
using System.Xml.Serialization;
using System.CodeDom.Compiler;
using System;
using System.Data;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Xml;
using System.IO;
using System.Xml.Schema;
using System.Collections;
using System.Reflection;

namespace Accounting.Code
{
[ToolboxItem(true)]
[HelpKeyword("vs.data.DataSet")]
[XmlRoot("AccountingDS")]
[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[DesignerCategory("code")]
[Serializable]
public class AccountingDS : DataSet
{
	private SchemaSerializationMode _schemaSerializationMode;

	private DataRelation relationFK_Bank_T_COA_T;

	private DataRelation relationFK_Cash_T_Bank_T;

	private DataRelation relationFK_COA_T_Category;

	private DataRelation relationFK_COA_T_COA_T1;

	private DataRelation relationFK_Journal_T_Cash_T;

	private DataRelation relationFK_Journal_T_COA_T;

	private AccountsViewDataTable tableAccountsView;

	private BalanceReportDataTable tableBalanceReport;

	private BalanceSheetDataTable tableBalanceSheet;

	private BalanceSheetTableDataTable tableBalanceSheetTable;

	private Bank_TDataTable tableBank_T;

	private Cash_TDataTable tableCash_T;

	private CategoryDataTable tableCategory;

	private ClientDataTable tableClient;

	private COA_TDataTable tableCOA_T;

	private DailyJournalDataTable tableDailyJournal;

	private EmployeeDataTable tableEmployee;

	private FixedAssetReportDataTable tableFixedAssetReport;

	private getParentDataTable tablegetParent;

	private Journal_TDataTable tableJournal_T;

	private ProfitLossDataTable tableProfitLoss;

	private ReportDataTable tableReport;

	private Sec_TDataTable tableSec_T;

	private SupplierDataTable tableSupplier;

	private TrialBalanceDataTable tableTrialBalance;

	private VoucherDataTable tableVoucher;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[DebuggerNonUserCode]
	public AccountsViewDataTable AccountsView
	{
		get
		{
			return this.tableAccountsView;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[DebuggerNonUserCode]
	[Browsable(false)]
	public BalanceReportDataTable BalanceReport
	{
		get
		{
			return this.tableBalanceReport;
		}
	}

	[Browsable(false)]
	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public BalanceSheetDataTable BalanceSheet
	{
		get
		{
			return this.tableBalanceSheet;
		}
	}

	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	public BalanceSheetTableDataTable BalanceSheetTable
	{
		get
		{
			return this.tableBalanceSheetTable;
		}
	}

	[DebuggerNonUserCode]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public Bank_TDataTable Bank_T
	{
		get
		{
			return this.tableBank_T;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[DebuggerNonUserCode]
	public Cash_TDataTable Cash_T
	{
		get
		{
			return this.tableCash_T;
		}
	}

	[DebuggerNonUserCode]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public CategoryDataTable Category
	{
		get
		{
			return this.tableCategory;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[DebuggerNonUserCode]
	[Browsable(false)]
	public ClientDataTable Client
	{
		get
		{
			return this.tableClient;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[DebuggerNonUserCode]
	public COA_TDataTable COA_T
	{
		get
		{
			return this.tableCOA_T;
		}
	}

	[Browsable(false)]
	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public DailyJournalDataTable DailyJournal
	{
		get
		{
			return this.tableDailyJournal;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[DebuggerNonUserCode]
	[Browsable(false)]
	public EmployeeDataTable Employee
	{
		get
		{
			return this.tableEmployee;
		}
	}

	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	public FixedAssetReportDataTable FixedAssetReport
	{
		get
		{
			return this.tableFixedAssetReport;
		}
	}

	[DebuggerNonUserCode]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public getParentDataTable getParent
	{
		get
		{
			return this.tablegetParent;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[DebuggerNonUserCode]
	public Journal_TDataTable Journal_T
	{
		get
		{
			return this.tableJournal_T;
		}
	}

	[DebuggerNonUserCode]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public ProfitLossDataTable ProfitLoss
	{
		get
		{
			return this.tableProfitLoss;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DebuggerNonUserCode]
	public DataRelationCollection Relations
	{
		get
		{
			return base.Relations;
		}
	}

	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	public ReportDataTable Report
	{
		get
		{
			return this.tableReport;
		}
	}

	[DebuggerNonUserCode]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	public SchemaSerializationMode SchemaSerializationMode
	{
		get
		{
			return this._schemaSerializationMode;
		}
		set
		{
			this._schemaSerializationMode = value;
		}
	}

	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	public Sec_TDataTable Sec_T
	{
		get
		{
			return this.tableSec_T;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[DebuggerNonUserCode]
	public SupplierDataTable Supplier
	{
		get
		{
			return this.tableSupplier;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DebuggerNonUserCode]
	public DataTableCollection Tables
	{
		get
		{
			return base.Tables;
		}
	}

	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	public TrialBalanceDataTable TrialBalance
	{
		get
		{
			return this.tableTrialBalance;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[DebuggerNonUserCode]
	[Browsable(false)]
	public VoucherDataTable Voucher
	{
		get
		{
			return this.tableVoucher;
		}
	}

	[DebuggerNonUserCode]
	public AccountingDS()
	{
		this._schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		base();
		base.BeginInit();
		this.InitClass();
		CollectionChangeEventHandler collectionChangeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
		base.Tables.add_CollectionChanged(collectionChangeEventHandler);
		base.Relations.add_CollectionChanged(collectionChangeEventHandler);
		base.EndInit();
	}

	[DebuggerNonUserCode]
	protected AccountingDS(SerializationInfo info, StreamingContext context)
	{
		this._schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		base(info, context, false);
		if (base.IsBinarySerialized(info, context))
		{
			this.InitVars(false);
			CollectionChangeEventHandler collectionChangeEventHandler1 = new CollectionChangeEventHandler(this.SchemaChanged);
			this.Tables.add_CollectionChanged(collectionChangeEventHandler1);
			this.Relations.add_CollectionChanged(collectionChangeEventHandler1);
		}
		else
		{
			string @value = (string)info.GetValue("XmlSchema", typeof(string));
			if (base.DetermineSchemaSerializationMode(info, context) == 1)
			{
				DataSet dataSet = new DataSet();
				dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(@value)));
				if (dataSet.Tables["Bank_T"] != null)
				{
					base.Tables.Add(new Bank_TDataTable(dataSet.Tables["Bank_T"]));
				}
				if (dataSet.Tables["Cash_T"] != null)
				{
					base.Tables.Add(new Cash_TDataTable(dataSet.Tables["Cash_T"]));
				}
				if (dataSet.Tables["Category"] != null)
				{
					base.Tables.Add(new CategoryDataTable(dataSet.Tables["Category"]));
				}
				if (dataSet.Tables["COA_T"] != null)
				{
					base.Tables.Add(new COA_TDataTable(dataSet.Tables["COA_T"]));
				}
				if (dataSet.Tables["Journal_T"] != null)
				{
					base.Tables.Add(new Journal_TDataTable(dataSet.Tables["Journal_T"]));
				}
				if (dataSet.Tables["Supplier"] != null)
				{
					base.Tables.Add(new SupplierDataTable(dataSet.Tables["Supplier"]));
				}
				if (dataSet.Tables["Employee"] != null)
				{
					base.Tables.Add(new EmployeeDataTable(dataSet.Tables["Employee"]));
				}
				if (dataSet.Tables["AccountsView"] != null)
				{
					base.Tables.Add(new AccountsViewDataTable(dataSet.Tables["AccountsView"]));
				}
				if (dataSet.Tables["getParent"] != null)
				{
					base.Tables.Add(new getParentDataTable(dataSet.Tables["getParent"]));
				}
				if (dataSet.Tables["Voucher"] != null)
				{
					base.Tables.Add(new VoucherDataTable(dataSet.Tables["Voucher"]));
				}
				if (dataSet.Tables["DailyJournal"] != null)
				{
					base.Tables.Add(new DailyJournalDataTable(dataSet.Tables["DailyJournal"]));
				}
				if (dataSet.Tables["Report"] != null)
				{
					base.Tables.Add(new ReportDataTable(dataSet.Tables["Report"]));
				}
				if (dataSet.Tables["BalanceSheet"] != null)
				{
					base.Tables.Add(new BalanceSheetDataTable(dataSet.Tables["BalanceSheet"]));
				}
				if (dataSet.Tables["ProfitLoss"] != null)
				{
					base.Tables.Add(new ProfitLossDataTable(dataSet.Tables["ProfitLoss"]));
				}
				if (dataSet.Tables["TrialBalance"] != null)
				{
					base.Tables.Add(new TrialBalanceDataTable(dataSet.Tables["TrialBalance"]));
				}
				if (dataSet.Tables["Sec_T"] != null)
				{
					base.Tables.Add(new Sec_TDataTable(dataSet.Tables["Sec_T"]));
				}
				if (dataSet.Tables["BalanceReport"] != null)
				{
					base.Tables.Add(new BalanceReportDataTable(dataSet.Tables["BalanceReport"]));
				}
				if (dataSet.Tables["FixedAssetReport"] != null)
				{
					base.Tables.Add(new FixedAssetReportDataTable(dataSet.Tables["FixedAssetReport"]));
				}
				if (dataSet.Tables["Client"] != null)
				{
					base.Tables.Add(new ClientDataTable(dataSet.Tables["Client"]));
				}
				if (dataSet.Tables["BalanceSheetTable"] != null)
				{
					base.Tables.Add(new BalanceSheetTableDataTable(dataSet.Tables["BalanceSheetTable"]));
				}
				base.DataSetName = dataSet.DataSetName;
				base.Prefix = dataSet.Prefix;
				base.Namespace = dataSet.Namespace;
				base.Locale = dataSet.Locale;
				base.CaseSensitive = dataSet.CaseSensitive;
				base.EnforceConstraints = dataSet.EnforceConstraints;
				base.Merge(dataSet, false, MissingSchemaAction.Add);
				this.InitVars();
			}
			else
			{
				base.ReadXmlSchema(new XmlTextReader(new StringReader(@value)));
			}
			base.GetSerializationData(info, context);
			CollectionChangeEventHandler collectionChangeEventHandler2 = new CollectionChangeEventHandler(this.SchemaChanged);
			base.Tables.add_CollectionChanged(collectionChangeEventHandler2);
			this.Relations.add_CollectionChanged(collectionChangeEventHandler2);
		}
	}

	[DebuggerNonUserCode]
	public override DataSet Clone()
	{
		AccountingDS schemaSerializationMode = (AccountingDS)base.Clone();
		schemaSerializationMode.InitVars();
		schemaSerializationMode.SchemaSerializationMode = this.SchemaSerializationMode;
		return schemaSerializationMode;
	}

	[DebuggerNonUserCode]
	protected override XmlSchema GetSchemaSerializable()
	{
		MemoryStream memoryStream = new MemoryStream();
		base.WriteXmlSchema(new XmlTextWriter(memoryStream, null));
		memoryStream.Position = (long)0;
		return XmlSchema.Read(new XmlTextReader(memoryStream), null);
	}

	[DebuggerNonUserCode]
	public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
	{
		XmlSchemaComplexType xmlSchemaComplexType1;
		AccountingDS accountingD = new AccountingDS();
		XmlSchemaComplexType xmlSchemaComplexType2 = new XmlSchemaComplexType();
		XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
		XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
		xmlSchemaAny.Namespace = accountingD.Namespace;
		xmlSchemaSequence.Items.Add(xmlSchemaAny);
		xmlSchemaComplexType2.Particle = xmlSchemaSequence;
		XmlSchema schemaSerializable = accountingD.GetSchemaSerializable();
		if (xs.Contains(schemaSerializable.TargetNamespace))
		{
			MemoryStream memoryStream1 = new MemoryStream();
			MemoryStream memoryStream2 = new MemoryStream();
			try
			{
				XmlSchema current = null;
				schemaSerializable.Write(memoryStream1);
				IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
				while (enumerator.MoveNext())
				{
					current = (XmlSchema)enumerator.Current;
					memoryStream2.SetLength((long)0);
					current.Write(memoryStream2);
					if (memoryStream1.Length == memoryStream2.Length)
					{
						memoryStream1.Position = (long)0;
						memoryStream2.Position = (long)0;
						do
						{
						}
						while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
						if (memoryStream1.Position == memoryStream1.Length)
						{
							xmlSchemaComplexType1 = xmlSchemaComplexType2;
						}
					}
				}
			}
			finally
			{
				if (memoryStream1 != null)
				{
					memoryStream1.Close();
				}
				if (memoryStream2 != null)
				{
					memoryStream2.Close();
				}
			}
		}
		xs.Add(schemaSerializable);
		xmlSchemaComplexType1 = xmlSchemaComplexType2;
		return xmlSchemaComplexType1;
	}

	[DebuggerNonUserCode]
	private void InitClass()
	{
		DataColumn[] dataColumnArray;
		base.DataSetName = "AccountingDS";
		base.Prefix = "";
		base.Namespace = "http://tempuri.org/AccountingDS.xsd";
		base.EnforceConstraints = true;
		base.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		this.tableBank_T = new Bank_TDataTable();
		base.Tables.Add(this.tableBank_T);
		this.tableCash_T = new Cash_TDataTable();
		base.Tables.Add(this.tableCash_T);
		this.tableCategory = new CategoryDataTable();
		base.Tables.Add(this.tableCategory);
		this.tableCOA_T = new COA_TDataTable();
		base.Tables.Add(this.tableCOA_T);
		this.tableJournal_T = new Journal_TDataTable();
		base.Tables.Add(this.tableJournal_T);
		this.tableSupplier = new SupplierDataTable();
		base.Tables.Add(this.tableSupplier);
		this.tableEmployee = new EmployeeDataTable();
		base.Tables.Add(this.tableEmployee);
		this.tableAccountsView = new AccountsViewDataTable();
		base.Tables.Add(this.tableAccountsView);
		this.tablegetParent = new getParentDataTable();
		base.Tables.Add(this.tablegetParent);
		this.tableVoucher = new VoucherDataTable();
		base.Tables.Add(this.tableVoucher);
		this.tableDailyJournal = new DailyJournalDataTable();
		base.Tables.Add(this.tableDailyJournal);
		this.tableReport = new ReportDataTable();
		base.Tables.Add(this.tableReport);
		this.tableBalanceSheet = new BalanceSheetDataTable();
		base.Tables.Add(this.tableBalanceSheet);
		this.tableProfitLoss = new ProfitLossDataTable();
		base.Tables.Add(this.tableProfitLoss);
		this.tableTrialBalance = new TrialBalanceDataTable();
		base.Tables.Add(this.tableTrialBalance);
		this.tableSec_T = new Sec_TDataTable();
		base.Tables.Add(this.tableSec_T);
		this.tableBalanceReport = new BalanceReportDataTable();
		base.Tables.Add(this.tableBalanceReport);
		this.tableFixedAssetReport = new FixedAssetReportDataTable();
		base.Tables.Add(this.tableFixedAssetReport);
		this.tableClient = new ClientDataTable();
		base.Tables.Add(this.tableClient);
		this.tableBalanceSheetTable = new BalanceSheetTableDataTable();
		base.Tables.Add(this.tableBalanceSheetTable);
		this.relationFK_Cash_T_Bank_T = new DataRelation("FK_Cash_T_Bank_T", new DataColumn[] { this.tableBank_T.CodeColumn }, new DataColumn[] { this.tableCash_T.BankCodeColumn }, false);
		this.Relations.Add(this.relationFK_Cash_T_Bank_T);
		this.relationFK_COA_T_COA_T1 = new DataRelation("FK_COA_T_COA_T1", new DataColumn[] { this.tableCOA_T.GL_IDColumn }, new DataColumn[] { this.tableCOA_T.ParentAccColumn }, false);
		this.Relations.Add(this.relationFK_COA_T_COA_T1);
		this.relationFK_Bank_T_COA_T = new DataRelation("FK_Bank_T_COA_T", new DataColumn[] { this.tableCOA_T.GL_IDColumn }, new DataColumn[] { this.tableBank_T.AccCodeColumn }, false);
		this.Relations.Add(this.relationFK_Bank_T_COA_T);
		this.relationFK_COA_T_Category = new DataRelation("FK_COA_T_Category", new DataColumn[] { this.tableCategory.Category_IDColumn }, new DataColumn[] { this.tableCOA_T.BS_Category_VCColumn }, false);
		this.Relations.Add(this.relationFK_COA_T_Category);
		this.relationFK_Journal_T_Cash_T = new DataRelation("FK_Journal_T_Cash_T", new DataColumn[] { this.tableCash_T.CodeColumn }, new DataColumn[] { this.tableJournal_T.Doc_No_VCColumn }, false);
		this.Relations.Add(this.relationFK_Journal_T_Cash_T);
		this.relationFK_Journal_T_COA_T = new DataRelation("FK_Journal_T_COA_T", new DataColumn[] { this.tableCOA_T.GL_IDColumn }, new DataColumn[] { this.tableJournal_T.GL_IDColumn }, false);
		this.Relations.Add(this.relationFK_Journal_T_COA_T);
	}

	[DebuggerNonUserCode]
	protected override void InitializeDerivedDataSet()
	{
		base.BeginInit();
		this.InitClass();
		base.EndInit();
	}

	[DebuggerNonUserCode]
	internal void InitVars()
	{
		this.InitVars(true);
	}

	[DebuggerNonUserCode]
	internal void InitVars(bool initTable)
	{
		this.tableBank_T = (Bank_TDataTable)base.Tables["Bank_T"];
		if (initTable != 0 && this.tableBank_T != null)
		{
			this.tableBank_T.InitVars();
		}
		this.tableCash_T = (Cash_TDataTable)base.Tables["Cash_T"];
		if (initTable != 0 && this.tableCash_T != null)
		{
			this.tableCash_T.InitVars();
		}
		this.tableCategory = (CategoryDataTable)base.Tables["Category"];
		if (initTable != 0 && this.tableCategory != null)
		{
			this.tableCategory.InitVars();
		}
		this.tableCOA_T = (COA_TDataTable)base.Tables["COA_T"];
		if (initTable != 0 && this.tableCOA_T != null)
		{
			this.tableCOA_T.InitVars();
		}
		this.tableJournal_T = (Journal_TDataTable)base.Tables["Journal_T"];
		if (initTable != 0 && this.tableJournal_T != null)
		{
			this.tableJournal_T.InitVars();
		}
		this.tableSupplier = (SupplierDataTable)base.Tables["Supplier"];
		if (initTable != 0 && this.tableSupplier != null)
		{
			this.tableSupplier.InitVars();
		}
		this.tableEmployee = (EmployeeDataTable)base.Tables["Employee"];
		if (initTable != 0 && this.tableEmployee != null)
		{
			this.tableEmployee.InitVars();
		}
		this.tableAccountsView = (AccountsViewDataTable)base.Tables["AccountsView"];
		if (initTable != 0 && this.tableAccountsView != null)
		{
			this.tableAccountsView.InitVars();
		}
		this.tablegetParent = (getParentDataTable)base.Tables["getParent"];
		if (initTable != 0 && this.tablegetParent != null)
		{
			this.tablegetParent.InitVars();
		}
		this.tableVoucher = (VoucherDataTable)base.Tables["Voucher"];
		if (initTable != 0 && this.tableVoucher != null)
		{
			this.tableVoucher.InitVars();
		}
		this.tableDailyJournal = (DailyJournalDataTable)base.Tables["DailyJournal"];
		if (initTable != 0 && this.tableDailyJournal != null)
		{
			this.tableDailyJournal.InitVars();
		}
		this.tableReport = (ReportDataTable)base.Tables["Report"];
		if (initTable != 0 && this.tableReport != null)
		{
			this.tableReport.InitVars();
		}
		this.tableBalanceSheet = (BalanceSheetDataTable)base.Tables["BalanceSheet"];
		if (initTable != 0 && this.tableBalanceSheet != null)
		{
			this.tableBalanceSheet.InitVars();
		}
		this.tableProfitLoss = (ProfitLossDataTable)base.Tables["ProfitLoss"];
		if (initTable != 0 && this.tableProfitLoss != null)
		{
			this.tableProfitLoss.InitVars();
		}
		this.tableTrialBalance = (TrialBalanceDataTable)base.Tables["TrialBalance"];
		if (initTable != 0 && this.tableTrialBalance != null)
		{
			this.tableTrialBalance.InitVars();
		}
		this.tableSec_T = (Sec_TDataTable)base.Tables["Sec_T"];
		if (initTable != 0 && this.tableSec_T != null)
		{
			this.tableSec_T.InitVars();
		}
		this.tableBalanceReport = (BalanceReportDataTable)base.Tables["BalanceReport"];
		if (initTable != 0 && this.tableBalanceReport != null)
		{
			this.tableBalanceReport.InitVars();
		}
		this.tableFixedAssetReport = (FixedAssetReportDataTable)base.Tables["FixedAssetReport"];
		if (initTable != 0 && this.tableFixedAssetReport != null)
		{
			this.tableFixedAssetReport.InitVars();
		}
		this.tableClient = (ClientDataTable)base.Tables["Client"];
		if (initTable != 0 && this.tableClient != null)
		{
			this.tableClient.InitVars();
		}
		this.tableBalanceSheetTable = (BalanceSheetTableDataTable)base.Tables["BalanceSheetTable"];
		if (initTable != 0 && this.tableBalanceSheetTable != null)
		{
			this.tableBalanceSheetTable.InitVars();
		}
		this.relationFK_Cash_T_Bank_T = this.Relations["FK_Cash_T_Bank_T"];
		this.relationFK_COA_T_COA_T1 = this.Relations["FK_COA_T_COA_T1"];
		this.relationFK_Bank_T_COA_T = this.Relations["FK_Bank_T_COA_T"];
		this.relationFK_COA_T_Category = this.Relations["FK_COA_T_Category"];
		this.relationFK_Journal_T_Cash_T = this.Relations["FK_Journal_T_Cash_T"];
		this.relationFK_Journal_T_COA_T = this.Relations["FK_Journal_T_COA_T"];
	}

	[DebuggerNonUserCode]
	protected override void ReadXmlSerializable(XmlReader reader)
	{
		if (base.DetermineSchemaSerializationMode(reader) == 1)
		{
			base.Reset();
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(reader);
			if (dataSet.Tables["Bank_T"] != null)
			{
				base.Tables.Add(new Bank_TDataTable(dataSet.Tables["Bank_T"]));
			}
			if (dataSet.Tables["Cash_T"] != null)
			{
				base.Tables.Add(new Cash_TDataTable(dataSet.Tables["Cash_T"]));
			}
			if (dataSet.Tables["Category"] != null)
			{
				base.Tables.Add(new CategoryDataTable(dataSet.Tables["Category"]));
			}
			if (dataSet.Tables["COA_T"] != null)
			{
				base.Tables.Add(new COA_TDataTable(dataSet.Tables["COA_T"]));
			}
			if (dataSet.Tables["Journal_T"] != null)
			{
				base.Tables.Add(new Journal_TDataTable(dataSet.Tables["Journal_T"]));
			}
			if (dataSet.Tables["Supplier"] != null)
			{
				base.Tables.Add(new SupplierDataTable(dataSet.Tables["Supplier"]));
			}
			if (dataSet.Tables["Employee"] != null)
			{
				base.Tables.Add(new EmployeeDataTable(dataSet.Tables["Employee"]));
			}
			if (dataSet.Tables["AccountsView"] != null)
			{
				base.Tables.Add(new AccountsViewDataTable(dataSet.Tables["AccountsView"]));
			}
			if (dataSet.Tables["getParent"] != null)
			{
				base.Tables.Add(new getParentDataTable(dataSet.Tables["getParent"]));
			}
			if (dataSet.Tables["Voucher"] != null)
			{
				base.Tables.Add(new VoucherDataTable(dataSet.Tables["Voucher"]));
			}
			if (dataSet.Tables["DailyJournal"] != null)
			{
				base.Tables.Add(new DailyJournalDataTable(dataSet.Tables["DailyJournal"]));
			}
			if (dataSet.Tables["Report"] != null)
			{
				base.Tables.Add(new ReportDataTable(dataSet.Tables["Report"]));
			}
			if (dataSet.Tables["BalanceSheet"] != null)
			{
				base.Tables.Add(new BalanceSheetDataTable(dataSet.Tables["BalanceSheet"]));
			}
			if (dataSet.Tables["ProfitLoss"] != null)
			{
				base.Tables.Add(new ProfitLossDataTable(dataSet.Tables["ProfitLoss"]));
			}
			if (dataSet.Tables["TrialBalance"] != null)
			{
				base.Tables.Add(new TrialBalanceDataTable(dataSet.Tables["TrialBalance"]));
			}
			if (dataSet.Tables["Sec_T"] != null)
			{
				base.Tables.Add(new Sec_TDataTable(dataSet.Tables["Sec_T"]));
			}
			if (dataSet.Tables["BalanceReport"] != null)
			{
				base.Tables.Add(new BalanceReportDataTable(dataSet.Tables["BalanceReport"]));
			}
			if (dataSet.Tables["FixedAssetReport"] != null)
			{
				base.Tables.Add(new FixedAssetReportDataTable(dataSet.Tables["FixedAssetReport"]));
			}
			if (dataSet.Tables["Client"] != null)
			{
				base.Tables.Add(new ClientDataTable(dataSet.Tables["Client"]));
			}
			if (dataSet.Tables["BalanceSheetTable"] != null)
			{
				base.Tables.Add(new BalanceSheetTableDataTable(dataSet.Tables["BalanceSheetTable"]));
			}
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			base.Merge(dataSet, false, MissingSchemaAction.Add);
			this.InitVars();
		}
		else
		{
			base.ReadXml(reader);
			this.InitVars();
		}
	}

	[DebuggerNonUserCode]
	private void SchemaChanged(object sender, CollectionChangeEventArgs e)
	{
		if (e.Action == 2)
		{
			this.InitVars();
		}
	}

	[DebuggerNonUserCode]
	private bool ShouldSerializeAccountsView()
	{
		return false;
	}

	[DebuggerNonUserCode]
	private bool ShouldSerializeBalanceReport()
	{
		return false;
	}

	[DebuggerNonUserCode]
	private bool ShouldSerializeBalanceSheet()
	{
		return false;
	}

	[DebuggerNonUserCode]
	private bool ShouldSerializeBalanceSheetTable()
	{
		return false;
	}

	[DebuggerNonUserCode]
	private bool ShouldSerializeBank_T()
	{
		return false;
	}

	[DebuggerNonUserCode]
	private bool ShouldSerializeCash_T()
	{
		return false;
	}

	[DebuggerNonUserCode]
	private bool ShouldSerializeCategory()
	{
		return false;
	}

	[DebuggerNonUserCode]
	private bool ShouldSerializeClient()
	{
		return false;
	}

	[DebuggerNonUserCode]
	private bool ShouldSerializeCOA_T()
	{
		return false;
	}

	[DebuggerNonUserCode]
	private bool ShouldSerializeDailyJournal()
	{
		return false;
	}

	[DebuggerNonUserCode]
	private bool ShouldSerializeEmployee()
	{
		return false;
	}

	[DebuggerNonUserCode]
	private bool ShouldSerializeFixedAssetReport()
	{
		return false;
	}

	[DebuggerNonUserCode]
	private bool ShouldSerializegetParent()
	{
		return false;
	}

	[DebuggerNonUserCode]
	private bool ShouldSerializeJournal_T()
	{
		return false;
	}

	[DebuggerNonUserCode]
	private bool ShouldSerializeProfitLoss()
	{
		return false;
	}

	[DebuggerNonUserCode]
	protected override bool ShouldSerializeRelations()
	{
		return false;
	}

	[DebuggerNonUserCode]
	private bool ShouldSerializeReport()
	{
		return false;
	}

	[DebuggerNonUserCode]
	private bool ShouldSerializeSec_T()
	{
		return false;
	}

	[DebuggerNonUserCode]
	private bool ShouldSerializeSupplier()
	{
		return false;
	}

	[DebuggerNonUserCode]
	protected override bool ShouldSerializeTables()
	{
		return false;
	}

	[DebuggerNonUserCode]
	private bool ShouldSerializeTrialBalance()
	{
		return false;
	}

	[DebuggerNonUserCode]
	private bool ShouldSerializeVoucher()
	{
		return false;
	}

	[DefaultMember("Item")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class AccountsViewDataTable : TypedTableBase<AccountsViewRow>
	{
		private AccountsViewRowChangeEventHandler AccountsViewRowChanged;

		private AccountsViewRowChangeEventHandler AccountsViewRowChanging;

		private AccountsViewRowChangeEventHandler AccountsViewRowDeleted;

		private AccountsViewRowChangeEventHandler AccountsViewRowDeleting;

		private DataColumn columnBalance;

		private DataColumn columnBS_Category_VC;

		private DataColumn columnCategory_Name;

		private DataColumn columnGL_ID;

		private DataColumn columnGL_Name_VC;

		private DataColumn columnParent;

		private DataColumn columnStatus_BT;

		[DebuggerNonUserCode]
		public DataColumn BalanceColumn;

		[DebuggerNonUserCode]
		public DataColumn BS_Category_VCColumn;

		[DebuggerNonUserCode]
		public DataColumn Category_NameColumn;

		[DebuggerNonUserCode]
		[Browsable(false)]
		public int Count;

		[DebuggerNonUserCode]
		public DataColumn GL_IDColumn;

		[DebuggerNonUserCode]
		public DataColumn GL_Name_VCColumn;

		[DebuggerNonUserCode]
		public AccountsViewRow Item;

		[DebuggerNonUserCode]
		public DataColumn ParentColumn;

		[DebuggerNonUserCode]
		public DataColumn Status_BTColumn;

		[DebuggerNonUserCode]
		public AccountsViewDataTable();

		[DebuggerNonUserCode]
		internal AccountsViewDataTable(DataTable table);

		[DebuggerNonUserCode]
		protected AccountsViewDataTable(SerializationInfo info, StreamingContext context);

		[DebuggerNonUserCode]
		public void AddAccountsViewRow(AccountsViewRow row);

		[DebuggerNonUserCode]
		public AccountsViewRow AddAccountsViewRow(int GL_ID, string GL_Name_VC, string Category_Name, int BS_Category_VC, bool Status_BT, decimal Balance, string Parent);

		[DebuggerNonUserCode]
		public override DataTable Clone();

		[DebuggerNonUserCode]
		protected override DataTable CreateInstance();

		[DebuggerNonUserCode]
		protected override Type GetRowType();

		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs);

		[DebuggerNonUserCode]
		private void InitClass();

		[DebuggerNonUserCode]
		internal void InitVars();

		[DebuggerNonUserCode]
		public AccountsViewRow NewAccountsViewRow();

		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder);

		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		public void RemoveAccountsViewRow(AccountsViewRow row);

		public event AccountsViewRowChangeEventHandler AccountsViewRowChanged;;

		public event AccountsViewRowChangeEventHandler AccountsViewRowChanging;;

		public event AccountsViewRowChangeEventHandler AccountsViewRowDeleted;;

		public event AccountsViewRowChangeEventHandler AccountsViewRowDeleting;;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class AccountsViewRow : DataRow
	{
		private AccountsViewDataTable tableAccountsView;

		[DebuggerNonUserCode]
		public decimal Balance;

		[DebuggerNonUserCode]
		public int BS_Category_VC;

		[DebuggerNonUserCode]
		public string Category_Name;

		[DebuggerNonUserCode]
		public int GL_ID;

		[DebuggerNonUserCode]
		public string GL_Name_VC;

		[DebuggerNonUserCode]
		public string Parent;

		[DebuggerNonUserCode]
		public bool Status_BT;

		[DebuggerNonUserCode]
		internal AccountsViewRow(DataRowBuilder rb);

		[DebuggerNonUserCode]
		public bool IsParentNull();

		[DebuggerNonUserCode]
		public void SetParentNull();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class AccountsViewRowChangeEvent : EventArgs
	{
		private DataRowAction eventAction;

		private AccountsViewRow eventRow;

		[DebuggerNonUserCode]
		public DataRowAction Action;

		[DebuggerNonUserCode]
		public AccountsViewRow Row;

		[DebuggerNonUserCode]
		public AccountsViewRowChangeEvent(AccountsViewRow row, DataRowAction action);
	}

	public sealed class AccountsViewRowChangeEventHandler : MulticastDelegate
	{
		public AccountsViewRowChangeEventHandler(object object, IntPtr method);

		public virtual IAsyncResult BeginInvoke(object sender, AccountsViewRowChangeEvent e, AsyncCallback callback, object object);

		public virtual void EndInvoke(IAsyncResult result);

		public virtual void Invoke(object sender, AccountsViewRowChangeEvent e);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	[XmlSchemaProvider("GetTypedTableSchema")]
	[DefaultMember("Item")]
	[Serializable]
	public class BalanceReportDataTable : TypedTableBase<BalanceReportRow>
	{
		private BalanceReportRowChangeEventHandler BalanceReportRowChanged;

		private BalanceReportRowChangeEventHandler BalanceReportRowChanging;

		private BalanceReportRowChangeEventHandler BalanceReportRowDeleted;

		private BalanceReportRowChangeEventHandler BalanceReportRowDeleting;

		private DataColumn columnCredit;

		private DataColumn columnDebit;

		private DataColumn columnGL_ID;

		private DataColumn columnGL_Name_VC;

		private DataColumn columnParentAcc;

		[DebuggerNonUserCode]
		[Browsable(false)]
		public int Count;

		[DebuggerNonUserCode]
		public DataColumn CreditColumn;

		[DebuggerNonUserCode]
		public DataColumn DebitColumn;

		[DebuggerNonUserCode]
		public DataColumn GL_IDColumn;

		[DebuggerNonUserCode]
		public DataColumn GL_Name_VCColumn;

		[DebuggerNonUserCode]
		public BalanceReportRow Item;

		[DebuggerNonUserCode]
		public DataColumn ParentAccColumn;

		[DebuggerNonUserCode]
		public BalanceReportDataTable();

		[DebuggerNonUserCode]
		internal BalanceReportDataTable(DataTable table);

		[DebuggerNonUserCode]
		protected BalanceReportDataTable(SerializationInfo info, StreamingContext context);

		[DebuggerNonUserCode]
		public void AddBalanceReportRow(BalanceReportRow row);

		[DebuggerNonUserCode]
		public BalanceReportRow AddBalanceReportRow(int GL_ID, string GL_Name_VC, decimal Debit, decimal Credit, int ParentAcc);

		[DebuggerNonUserCode]
		public override DataTable Clone();

		[DebuggerNonUserCode]
		protected override DataTable CreateInstance();

		[DebuggerNonUserCode]
		public BalanceReportRow FindByGL_ID(int GL_ID);

		[DebuggerNonUserCode]
		protected override Type GetRowType();

		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs);

		[DebuggerNonUserCode]
		private void InitClass();

		[DebuggerNonUserCode]
		internal void InitVars();

		[DebuggerNonUserCode]
		public BalanceReportRow NewBalanceReportRow();

		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder);

		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		public void RemoveBalanceReportRow(BalanceReportRow row);

		public event BalanceReportRowChangeEventHandler BalanceReportRowChanged;;

		public event BalanceReportRowChangeEventHandler BalanceReportRowChanging;;

		public event BalanceReportRowChangeEventHandler BalanceReportRowDeleted;;

		public event BalanceReportRowChangeEventHandler BalanceReportRowDeleting;;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class BalanceReportRow : DataRow
	{
		private BalanceReportDataTable tableBalanceReport;

		[DebuggerNonUserCode]
		public decimal Credit;

		[DebuggerNonUserCode]
		public decimal Debit;

		[DebuggerNonUserCode]
		public int GL_ID;

		[DebuggerNonUserCode]
		public string GL_Name_VC;

		[DebuggerNonUserCode]
		public int ParentAcc;

		[DebuggerNonUserCode]
		internal BalanceReportRow(DataRowBuilder rb);

		[DebuggerNonUserCode]
		public bool IsCreditNull();

		[DebuggerNonUserCode]
		public bool IsDebitNull();

		[DebuggerNonUserCode]
		public bool IsParentAccNull();

		[DebuggerNonUserCode]
		public void SetCreditNull();

		[DebuggerNonUserCode]
		public void SetDebitNull();

		[DebuggerNonUserCode]
		public void SetParentAccNull();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class BalanceReportRowChangeEvent : EventArgs
	{
		private DataRowAction eventAction;

		private BalanceReportRow eventRow;

		[DebuggerNonUserCode]
		public DataRowAction Action;

		[DebuggerNonUserCode]
		public BalanceReportRow Row;

		[DebuggerNonUserCode]
		public BalanceReportRowChangeEvent(BalanceReportRow row, DataRowAction action);
	}

	public sealed class BalanceReportRowChangeEventHandler : MulticastDelegate
	{
		public BalanceReportRowChangeEventHandler(object object, IntPtr method);

		public virtual IAsyncResult BeginInvoke(object sender, BalanceReportRowChangeEvent e, AsyncCallback callback, object object);

		public virtual void EndInvoke(IAsyncResult result);

		public virtual void Invoke(object sender, BalanceReportRowChangeEvent e);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	[DefaultMember("Item")]
	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class BalanceSheetDataTable : TypedTableBase<BalanceSheetRow>
	{
		private BalanceSheetRowChangeEventHandler BalanceSheetRowChanged;

		private BalanceSheetRowChangeEventHandler BalanceSheetRowChanging;

		private BalanceSheetRowChangeEventHandler BalanceSheetRowDeleted;

		private BalanceSheetRowChangeEventHandler BalanceSheetRowDeleting;

		private DataColumn columnBalance;

		private DataColumn columnCategory_ID;

		private DataColumn columnCategory_Name;

		private DataColumn columnGL_ID;

		private DataColumn columnGL_Name_VC;

		private DataColumn columnParentAcc;

		[DebuggerNonUserCode]
		public DataColumn BalanceColumn;

		[DebuggerNonUserCode]
		public DataColumn Category_IDColumn;

		[DebuggerNonUserCode]
		public DataColumn Category_NameColumn;

		[Browsable(false)]
		[DebuggerNonUserCode]
		public int Count;

		[DebuggerNonUserCode]
		public DataColumn GL_IDColumn;

		[DebuggerNonUserCode]
		public DataColumn GL_Name_VCColumn;

		[DebuggerNonUserCode]
		public BalanceSheetRow Item;

		[DebuggerNonUserCode]
		public DataColumn ParentAccColumn;

		[DebuggerNonUserCode]
		public BalanceSheetDataTable();

		[DebuggerNonUserCode]
		internal BalanceSheetDataTable(DataTable table);

		[DebuggerNonUserCode]
		protected BalanceSheetDataTable(SerializationInfo info, StreamingContext context);

		[DebuggerNonUserCode]
		public void AddBalanceSheetRow(BalanceSheetRow row);

		[DebuggerNonUserCode]
		public BalanceSheetRow AddBalanceSheetRow(int GL_ID, string GL_Name_VC, int Category_ID, string Category_Name, int ParentAcc, decimal Balance);

		[DebuggerNonUserCode]
		public override DataTable Clone();

		[DebuggerNonUserCode]
		protected override DataTable CreateInstance();

		[DebuggerNonUserCode]
		protected override Type GetRowType();

		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs);

		[DebuggerNonUserCode]
		private void InitClass();

		[DebuggerNonUserCode]
		internal void InitVars();

		[DebuggerNonUserCode]
		public BalanceSheetRow NewBalanceSheetRow();

		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder);

		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		public void RemoveBalanceSheetRow(BalanceSheetRow row);

		public event BalanceSheetRowChangeEventHandler BalanceSheetRowChanged;;

		public event BalanceSheetRowChangeEventHandler BalanceSheetRowChanging;;

		public event BalanceSheetRowChangeEventHandler BalanceSheetRowDeleted;;

		public event BalanceSheetRowChangeEventHandler BalanceSheetRowDeleting;;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class BalanceSheetRow : DataRow
	{
		private BalanceSheetDataTable tableBalanceSheet;

		[DebuggerNonUserCode]
		public decimal Balance;

		[DebuggerNonUserCode]
		public int Category_ID;

		[DebuggerNonUserCode]
		public string Category_Name;

		[DebuggerNonUserCode]
		public int GL_ID;

		[DebuggerNonUserCode]
		public string GL_Name_VC;

		[DebuggerNonUserCode]
		public int ParentAcc;

		[DebuggerNonUserCode]
		internal BalanceSheetRow(DataRowBuilder rb);

		[DebuggerNonUserCode]
		public bool IsBalanceNull();

		[DebuggerNonUserCode]
		public bool IsParentAccNull();

		[DebuggerNonUserCode]
		public void SetBalanceNull();

		[DebuggerNonUserCode]
		public void SetParentAccNull();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class BalanceSheetRowChangeEvent : EventArgs
	{
		private DataRowAction eventAction;

		private BalanceSheetRow eventRow;

		[DebuggerNonUserCode]
		public DataRowAction Action;

		[DebuggerNonUserCode]
		public BalanceSheetRow Row;

		[DebuggerNonUserCode]
		public BalanceSheetRowChangeEvent(BalanceSheetRow row, DataRowAction action);
	}

	public sealed class BalanceSheetRowChangeEventHandler : MulticastDelegate
	{
		public BalanceSheetRowChangeEventHandler(object object, IntPtr method);

		public virtual IAsyncResult BeginInvoke(object sender, BalanceSheetRowChangeEvent e, AsyncCallback callback, object object);

		public virtual void EndInvoke(IAsyncResult result);

		public virtual void Invoke(object sender, BalanceSheetRowChangeEvent e);
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	[DefaultMember("Item")]
	[Serializable]
	public class BalanceSheetTableDataTable : TypedTableBase<BalanceSheetTableRow>
	{
		private BalanceSheetTableRowChangeEventHandler BalanceSheetTableRowChanged;

		private BalanceSheetTableRowChangeEventHandler BalanceSheetTableRowChanging;

		private BalanceSheetTableRowChangeEventHandler BalanceSheetTableRowDeleted;

		private BalanceSheetTableRowChangeEventHandler BalanceSheetTableRowDeleting;

		private DataColumn columnBalance;

		private DataColumn columnCategory;

		private DataColumn columnMainAcc;

		private DataColumn columnSubAcc;

		[DebuggerNonUserCode]
		public DataColumn BalanceColumn;

		[DebuggerNonUserCode]
		public DataColumn CategoryColumn;

		[DebuggerNonUserCode]
		[Browsable(false)]
		public int Count;

		[DebuggerNonUserCode]
		public BalanceSheetTableRow Item;

		[DebuggerNonUserCode]
		public DataColumn MainAccColumn;

		[DebuggerNonUserCode]
		public DataColumn SubAccColumn;

		[DebuggerNonUserCode]
		public BalanceSheetTableDataTable();

		[DebuggerNonUserCode]
		internal BalanceSheetTableDataTable(DataTable table);

		[DebuggerNonUserCode]
		protected BalanceSheetTableDataTable(SerializationInfo info, StreamingContext context);

		[DebuggerNonUserCode]
		public void AddBalanceSheetTableRow(BalanceSheetTableRow row);

		[DebuggerNonUserCode]
		public BalanceSheetTableRow AddBalanceSheetTableRow(string Category, string MainAcc, string SubAcc, string Balance);

		[DebuggerNonUserCode]
		public override DataTable Clone();

		[DebuggerNonUserCode]
		protected override DataTable CreateInstance();

		[DebuggerNonUserCode]
		protected override Type GetRowType();

		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs);

		[DebuggerNonUserCode]
		private void InitClass();

		[DebuggerNonUserCode]
		internal void InitVars();

		[DebuggerNonUserCode]
		public BalanceSheetTableRow NewBalanceSheetTableRow();

		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder);

		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		public void RemoveBalanceSheetTableRow(BalanceSheetTableRow row);

		public event BalanceSheetTableRowChangeEventHandler BalanceSheetTableRowChanged;;

		public event BalanceSheetTableRowChangeEventHandler BalanceSheetTableRowChanging;;

		public event BalanceSheetTableRowChangeEventHandler BalanceSheetTableRowDeleted;;

		public event BalanceSheetTableRowChangeEventHandler BalanceSheetTableRowDeleting;;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class BalanceSheetTableRow : DataRow
	{
		private BalanceSheetTableDataTable tableBalanceSheetTable;

		[DebuggerNonUserCode]
		public string Balance;

		[DebuggerNonUserCode]
		public string Category;

		[DebuggerNonUserCode]
		public string MainAcc;

		[DebuggerNonUserCode]
		public string SubAcc;

		[DebuggerNonUserCode]
		internal BalanceSheetTableRow(DataRowBuilder rb);

		[DebuggerNonUserCode]
		public bool IsBalanceNull();

		[DebuggerNonUserCode]
		public bool IsCategoryNull();

		[DebuggerNonUserCode]
		public bool IsMainAccNull();

		[DebuggerNonUserCode]
		public bool IsSubAccNull();

		[DebuggerNonUserCode]
		public void SetBalanceNull();

		[DebuggerNonUserCode]
		public void SetCategoryNull();

		[DebuggerNonUserCode]
		public void SetMainAccNull();

		[DebuggerNonUserCode]
		public void SetSubAccNull();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class BalanceSheetTableRowChangeEvent : EventArgs
	{
		private DataRowAction eventAction;

		private BalanceSheetTableRow eventRow;

		[DebuggerNonUserCode]
		public DataRowAction Action;

		[DebuggerNonUserCode]
		public BalanceSheetTableRow Row;

		[DebuggerNonUserCode]
		public BalanceSheetTableRowChangeEvent(BalanceSheetTableRow row, DataRowAction action);
	}

	public sealed class BalanceSheetTableRowChangeEventHandler : MulticastDelegate
	{
		public BalanceSheetTableRowChangeEventHandler(object object, IntPtr method);

		public virtual IAsyncResult BeginInvoke(object sender, BalanceSheetTableRowChangeEvent e, AsyncCallback callback, object object);

		public virtual void EndInvoke(IAsyncResult result);

		public virtual void Invoke(object sender, BalanceSheetTableRowChangeEvent e);
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[DefaultMember("Item")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	[Serializable]
	public class Bank_TDataTable : TypedTableBase<Bank_TRow>
	{
		private Bank_TRowChangeEventHandler Bank_TRowChanged;

		private Bank_TRowChangeEventHandler Bank_TRowChanging;

		private Bank_TRowChangeEventHandler Bank_TRowDeleted;

		private Bank_TRowChangeEventHandler Bank_TRowDeleting;

		private DataColumn columnAccCode;

		private DataColumn columnCode;

		private DataColumn columnContacts;

		private DataColumn columnName;

		[DebuggerNonUserCode]
		public DataColumn AccCodeColumn;

		[DebuggerNonUserCode]
		public DataColumn CodeColumn;

		[DebuggerNonUserCode]
		public DataColumn ContactsColumn;

		[DebuggerNonUserCode]
		[Browsable(false)]
		public int Count;

		[DebuggerNonUserCode]
		public Bank_TRow Item;

		[DebuggerNonUserCode]
		public DataColumn NameColumn;

		[DebuggerNonUserCode]
		public Bank_TDataTable();

		[DebuggerNonUserCode]
		internal Bank_TDataTable(DataTable table);

		[DebuggerNonUserCode]
		protected Bank_TDataTable(SerializationInfo info, StreamingContext context);

		[DebuggerNonUserCode]
		public void AddBank_TRow(Bank_TRow row);

		[DebuggerNonUserCode]
		public Bank_TRow AddBank_TRow(int Code, string Name, COA_TRow parentCOA_TRowByFK_Bank_T_COA_T, string Contacts);

		[DebuggerNonUserCode]
		public override DataTable Clone();

		[DebuggerNonUserCode]
		protected override DataTable CreateInstance();

		[DebuggerNonUserCode]
		public Bank_TRow FindByCode(int Code);

		[DebuggerNonUserCode]
		protected override Type GetRowType();

		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs);

		[DebuggerNonUserCode]
		private void InitClass();

		[DebuggerNonUserCode]
		internal void InitVars();

		[DebuggerNonUserCode]
		public Bank_TRow NewBank_TRow();

		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder);

		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		public void RemoveBank_TRow(Bank_TRow row);

		public event Bank_TRowChangeEventHandler Bank_TRowChanged;;

		public event Bank_TRowChangeEventHandler Bank_TRowChanging;;

		public event Bank_TRowChangeEventHandler Bank_TRowDeleted;;

		public event Bank_TRowChangeEventHandler Bank_TRowDeleting;;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class Bank_TRow : DataRow
	{
		private Bank_TDataTable tableBank_T;

		[DebuggerNonUserCode]
		public int AccCode;

		[DebuggerNonUserCode]
		public COA_TRow COA_TRow;

		[DebuggerNonUserCode]
		public int Code;

		[DebuggerNonUserCode]
		public string Contacts;

		[DebuggerNonUserCode]
		public string Name;

		[DebuggerNonUserCode]
		internal Bank_TRow(DataRowBuilder rb);

		[DebuggerNonUserCode]
		public Cash_TRow[] GetCash_TRows();

		[DebuggerNonUserCode]
		public bool IsContactsNull();

		[DebuggerNonUserCode]
		public void SetContactsNull();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class Bank_TRowChangeEvent : EventArgs
	{
		private DataRowAction eventAction;

		private Bank_TRow eventRow;

		[DebuggerNonUserCode]
		public DataRowAction Action;

		[DebuggerNonUserCode]
		public Bank_TRow Row;

		[DebuggerNonUserCode]
		public Bank_TRowChangeEvent(Bank_TRow row, DataRowAction action);
	}

	public sealed class Bank_TRowChangeEventHandler : MulticastDelegate
	{
		public Bank_TRowChangeEventHandler(object object, IntPtr method);

		public virtual IAsyncResult BeginInvoke(object sender, Bank_TRowChangeEvent e, AsyncCallback callback, object object);

		public virtual void EndInvoke(IAsyncResult result);

		public virtual void Invoke(object sender, Bank_TRowChangeEvent e);
	}

	[DefaultMember("Item")]
	[XmlSchemaProvider("GetTypedTableSchema")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	[Serializable]
	public class Cash_TDataTable : TypedTableBase<Cash_TRow>
	{
		private Cash_TRowChangeEventHandler Cash_TRowChanged;

		private Cash_TRowChangeEventHandler Cash_TRowChanging;

		private Cash_TRowChangeEventHandler Cash_TRowDeleted;

		private Cash_TRowChangeEventHandler Cash_TRowDeleting;

		private DataColumn columnBankCode;

		private DataColumn columnchkNumber;

		private DataColumn columnCode;

		private DataColumn columnType;

		[DebuggerNonUserCode]
		public DataColumn BankCodeColumn;

		[DebuggerNonUserCode]
		public DataColumn chkNumberColumn;

		[DebuggerNonUserCode]
		public DataColumn CodeColumn;

		[Browsable(false)]
		[DebuggerNonUserCode]
		public int Count;

		[DebuggerNonUserCode]
		public Cash_TRow Item;

		[DebuggerNonUserCode]
		public DataColumn TypeColumn;

		[DebuggerNonUserCode]
		public Cash_TDataTable();

		[DebuggerNonUserCode]
		internal Cash_TDataTable(DataTable table);

		[DebuggerNonUserCode]
		protected Cash_TDataTable(SerializationInfo info, StreamingContext context);

		[DebuggerNonUserCode]
		public void AddCash_TRow(Cash_TRow row);

		[DebuggerNonUserCode]
		public Cash_TRow AddCash_TRow(int Code, string Type, Bank_TRow parentBank_TRowByFK_Cash_T_Bank_T, int chkNumber);

		[DebuggerNonUserCode]
		public override DataTable Clone();

		[DebuggerNonUserCode]
		protected override DataTable CreateInstance();

		[DebuggerNonUserCode]
		public Cash_TRow FindByCode(int Code);

		[DebuggerNonUserCode]
		protected override Type GetRowType();

		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs);

		[DebuggerNonUserCode]
		private void InitClass();

		[DebuggerNonUserCode]
		internal void InitVars();

		[DebuggerNonUserCode]
		public Cash_TRow NewCash_TRow();

		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder);

		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		public void RemoveCash_TRow(Cash_TRow row);

		public event Cash_TRowChangeEventHandler Cash_TRowChanged;;

		public event Cash_TRowChangeEventHandler Cash_TRowChanging;;

		public event Cash_TRowChangeEventHandler Cash_TRowDeleted;;

		public event Cash_TRowChangeEventHandler Cash_TRowDeleting;;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class Cash_TRow : DataRow
	{
		private Cash_TDataTable tableCash_T;

		[DebuggerNonUserCode]
		public Bank_TRow Bank_TRow;

		[DebuggerNonUserCode]
		public int BankCode;

		[DebuggerNonUserCode]
		public int chkNumber;

		[DebuggerNonUserCode]
		public int Code;

		[DebuggerNonUserCode]
		public string Type;

		[DebuggerNonUserCode]
		internal Cash_TRow(DataRowBuilder rb);

		[DebuggerNonUserCode]
		public Journal_TRow[] GetJournal_TRows();

		[DebuggerNonUserCode]
		public bool IsBankCodeNull();

		[DebuggerNonUserCode]
		public bool IschkNumberNull();

		[DebuggerNonUserCode]
		public void SetBankCodeNull();

		[DebuggerNonUserCode]
		public void SetchkNumberNull();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class Cash_TRowChangeEvent : EventArgs
	{
		private DataRowAction eventAction;

		private Cash_TRow eventRow;

		[DebuggerNonUserCode]
		public DataRowAction Action;

		[DebuggerNonUserCode]
		public Cash_TRow Row;

		[DebuggerNonUserCode]
		public Cash_TRowChangeEvent(Cash_TRow row, DataRowAction action);
	}

	public sealed class Cash_TRowChangeEventHandler : MulticastDelegate
	{
		public Cash_TRowChangeEventHandler(object object, IntPtr method);

		public virtual IAsyncResult BeginInvoke(object sender, Cash_TRowChangeEvent e, AsyncCallback callback, object object);

		public virtual void EndInvoke(IAsyncResult result);

		public virtual void Invoke(object sender, Cash_TRowChangeEvent e);
	}

	[DefaultMember("Item")]
	[XmlSchemaProvider("GetTypedTableSchema")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	[Serializable]
	public class CategoryDataTable : TypedTableBase<CategoryRow>
	{
		private CategoryRowChangeEventHandler CategoryRowChanged;

		private CategoryRowChangeEventHandler CategoryRowChanging;

		private CategoryRowChangeEventHandler CategoryRowDeleted;

		private CategoryRowChangeEventHandler CategoryRowDeleting;

		private DataColumn columnCategory_ID;

		private DataColumn columnCategory_Name;

		[DebuggerNonUserCode]
		public DataColumn Category_IDColumn;

		[DebuggerNonUserCode]
		public DataColumn Category_NameColumn;

		[DebuggerNonUserCode]
		[Browsable(false)]
		public int Count;

		[DebuggerNonUserCode]
		public CategoryRow Item;

		[DebuggerNonUserCode]
		public CategoryDataTable();

		[DebuggerNonUserCode]
		internal CategoryDataTable(DataTable table);

		[DebuggerNonUserCode]
		protected CategoryDataTable(SerializationInfo info, StreamingContext context);

		[DebuggerNonUserCode]
		public void AddCategoryRow(CategoryRow row);

		[DebuggerNonUserCode]
		public CategoryRow AddCategoryRow(int Category_ID, string Category_Name);

		[DebuggerNonUserCode]
		public override DataTable Clone();

		[DebuggerNonUserCode]
		protected override DataTable CreateInstance();

		[DebuggerNonUserCode]
		public CategoryRow FindByCategory_ID(int Category_ID);

		[DebuggerNonUserCode]
		protected override Type GetRowType();

		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs);

		[DebuggerNonUserCode]
		private void InitClass();

		[DebuggerNonUserCode]
		internal void InitVars();

		[DebuggerNonUserCode]
		public CategoryRow NewCategoryRow();

		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder);

		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		public void RemoveCategoryRow(CategoryRow row);

		public event CategoryRowChangeEventHandler CategoryRowChanged;;

		public event CategoryRowChangeEventHandler CategoryRowChanging;;

		public event CategoryRowChangeEventHandler CategoryRowDeleted;;

		public event CategoryRowChangeEventHandler CategoryRowDeleting;;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class CategoryRow : DataRow
	{
		private CategoryDataTable tableCategory;

		[DebuggerNonUserCode]
		public int Category_ID;

		[DebuggerNonUserCode]
		public string Category_Name;

		[DebuggerNonUserCode]
		internal CategoryRow(DataRowBuilder rb);

		[DebuggerNonUserCode]
		public COA_TRow[] GetCOA_TRows();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class CategoryRowChangeEvent : EventArgs
	{
		private DataRowAction eventAction;

		private CategoryRow eventRow;

		[DebuggerNonUserCode]
		public DataRowAction Action;

		[DebuggerNonUserCode]
		public CategoryRow Row;

		[DebuggerNonUserCode]
		public CategoryRowChangeEvent(CategoryRow row, DataRowAction action);
	}

	public sealed class CategoryRowChangeEventHandler : MulticastDelegate
	{
		public CategoryRowChangeEventHandler(object object, IntPtr method);

		public virtual IAsyncResult BeginInvoke(object sender, CategoryRowChangeEvent e, AsyncCallback callback, object object);

		public virtual void EndInvoke(IAsyncResult result);

		public virtual void Invoke(object sender, CategoryRowChangeEvent e);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	[XmlSchemaProvider("GetTypedTableSchema")]
	[DefaultMember("Item")]
	[Serializable]
	public class ClientDataTable : TypedTableBase<ClientRow>
	{
		private ClientRowChangeEventHandler ClientRowChanged;

		private ClientRowChangeEventHandler ClientRowChanging;

		private ClientRowChangeEventHandler ClientRowDeleted;

		private ClientRowChangeEventHandler ClientRowDeleting;

		private DataColumn columnAccCode;

		private DataColumn columnAddress;

		private DataColumn columnClientID;

		private DataColumn columnIDNumber;

		private DataColumn columnName;

		private DataColumn columnNationality;

		private DataColumn columnPhone;

		[DebuggerNonUserCode]
		public DataColumn AccCodeColumn;

		[DebuggerNonUserCode]
		public DataColumn AddressColumn;

		[DebuggerNonUserCode]
		public DataColumn ClientIDColumn;

		[Browsable(false)]
		[DebuggerNonUserCode]
		public int Count;

		[DebuggerNonUserCode]
		public DataColumn IDNumberColumn;

		[DebuggerNonUserCode]
		public ClientRow Item;

		[DebuggerNonUserCode]
		public DataColumn NameColumn;

		[DebuggerNonUserCode]
		public DataColumn NationalityColumn;

		[DebuggerNonUserCode]
		public DataColumn PhoneColumn;

		[DebuggerNonUserCode]
		public ClientDataTable();

		[DebuggerNonUserCode]
		internal ClientDataTable(DataTable table);

		[DebuggerNonUserCode]
		protected ClientDataTable(SerializationInfo info, StreamingContext context);

		[DebuggerNonUserCode]
		public void AddClientRow(ClientRow row);

		[DebuggerNonUserCode]
		public ClientRow AddClientRow(string Name, int Phone, string Nationality, int IDNumber, string Address, int AccCode);

		[DebuggerNonUserCode]
		public override DataTable Clone();

		[DebuggerNonUserCode]
		protected override DataTable CreateInstance();

		[DebuggerNonUserCode]
		protected override Type GetRowType();

		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs);

		[DebuggerNonUserCode]
		private void InitClass();

		[DebuggerNonUserCode]
		internal void InitVars();

		[DebuggerNonUserCode]
		public ClientRow NewClientRow();

		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder);

		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		public void RemoveClientRow(ClientRow row);

		public event ClientRowChangeEventHandler ClientRowChanged;;

		public event ClientRowChangeEventHandler ClientRowChanging;;

		public event ClientRowChangeEventHandler ClientRowDeleted;;

		public event ClientRowChangeEventHandler ClientRowDeleting;;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class ClientRow : DataRow
	{
		private ClientDataTable tableClient;

		[DebuggerNonUserCode]
		public int AccCode;

		[DebuggerNonUserCode]
		public string Address;

		[DebuggerNonUserCode]
		public int ClientID;

		[DebuggerNonUserCode]
		public int IDNumber;

		[DebuggerNonUserCode]
		public string Name;

		[DebuggerNonUserCode]
		public string Nationality;

		[DebuggerNonUserCode]
		public int Phone;

		[DebuggerNonUserCode]
		internal ClientRow(DataRowBuilder rb);

		[DebuggerNonUserCode]
		public bool IsAddressNull();

		[DebuggerNonUserCode]
		public bool IsIDNumberNull();

		[DebuggerNonUserCode]
		public bool IsNationalityNull();

		[DebuggerNonUserCode]
		public void SetAddressNull();

		[DebuggerNonUserCode]
		public void SetIDNumberNull();

		[DebuggerNonUserCode]
		public void SetNationalityNull();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class ClientRowChangeEvent : EventArgs
	{
		private DataRowAction eventAction;

		private ClientRow eventRow;

		[DebuggerNonUserCode]
		public DataRowAction Action;

		[DebuggerNonUserCode]
		public ClientRow Row;

		[DebuggerNonUserCode]
		public ClientRowChangeEvent(ClientRow row, DataRowAction action);
	}

	public sealed class ClientRowChangeEventHandler : MulticastDelegate
	{
		public ClientRowChangeEventHandler(object object, IntPtr method);

		public virtual IAsyncResult BeginInvoke(object sender, ClientRowChangeEvent e, AsyncCallback callback, object object);

		public virtual void EndInvoke(IAsyncResult result);

		public virtual void Invoke(object sender, ClientRowChangeEvent e);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	[DefaultMember("Item")]
	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class COA_TDataTable : TypedTableBase<COA_TRow>
	{
		private COA_TRowChangeEventHandler COA_TRowChanged;

		private COA_TRowChangeEventHandler COA_TRowChanging;

		private COA_TRowChangeEventHandler COA_TRowDeleted;

		private COA_TRowChangeEventHandler COA_TRowDeleting;

		private DataColumn columnBalance;

		private DataColumn columnBS_Category_VC;

		private DataColumn columnGL_ID;

		private DataColumn columnGL_Name_VC;

		private DataColumn columnParentAcc;

		private DataColumn columnStatus_BT;

		[DebuggerNonUserCode]
		public DataColumn BalanceColumn;

		[DebuggerNonUserCode]
		public DataColumn BS_Category_VCColumn;

		[DebuggerNonUserCode]
		[Browsable(false)]
		public int Count;

		[DebuggerNonUserCode]
		public DataColumn GL_IDColumn;

		[DebuggerNonUserCode]
		public DataColumn GL_Name_VCColumn;

		[DebuggerNonUserCode]
		public COA_TRow Item;

		[DebuggerNonUserCode]
		public DataColumn ParentAccColumn;

		[DebuggerNonUserCode]
		public DataColumn Status_BTColumn;

		[DebuggerNonUserCode]
		public COA_TDataTable();

		[DebuggerNonUserCode]
		internal COA_TDataTable(DataTable table);

		[DebuggerNonUserCode]
		protected COA_TDataTable(SerializationInfo info, StreamingContext context);

		[DebuggerNonUserCode]
		public void AddCOA_TRow(COA_TRow row);

		[DebuggerNonUserCode]
		public COA_TRow AddCOA_TRow(int GL_ID, string GL_Name_VC, CategoryRow parentCategoryRowByFK_COA_T_Category, bool Status_BT, decimal Balance, COA_TRow parentCOA_TRowByFK_COA_T_COA_T1);

		[DebuggerNonUserCode]
		public override DataTable Clone();

		[DebuggerNonUserCode]
		protected override DataTable CreateInstance();

		[DebuggerNonUserCode]
		public COA_TRow FindByGL_ID(int GL_ID);

		[DebuggerNonUserCode]
		protected override Type GetRowType();

		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs);

		[DebuggerNonUserCode]
		private void InitClass();

		[DebuggerNonUserCode]
		internal void InitVars();

		[DebuggerNonUserCode]
		public COA_TRow NewCOA_TRow();

		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder);

		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		public void RemoveCOA_TRow(COA_TRow row);

		public event COA_TRowChangeEventHandler COA_TRowChanged;;

		public event COA_TRowChangeEventHandler COA_TRowChanging;;

		public event COA_TRowChangeEventHandler COA_TRowDeleted;;

		public event COA_TRowChangeEventHandler COA_TRowDeleting;;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class COA_TRow : DataRow
	{
		private COA_TDataTable tableCOA_T;

		[DebuggerNonUserCode]
		public decimal Balance;

		[DebuggerNonUserCode]
		public int BS_Category_VC;

		[DebuggerNonUserCode]
		public CategoryRow CategoryRow;

		[DebuggerNonUserCode]
		public COA_TRow COA_TRowParent;

		[DebuggerNonUserCode]
		public int GL_ID;

		[DebuggerNonUserCode]
		public string GL_Name_VC;

		[DebuggerNonUserCode]
		public int ParentAcc;

		[DebuggerNonUserCode]
		public bool Status_BT;

		[DebuggerNonUserCode]
		internal COA_TRow(DataRowBuilder rb);

		[DebuggerNonUserCode]
		public Bank_TRow[] GetBank_TRows();

		[DebuggerNonUserCode]
		public COA_TRow[] GetCOA_TRows();

		[DebuggerNonUserCode]
		public Journal_TRow[] GetJournal_TRows();

		[DebuggerNonUserCode]
		public bool IsParentAccNull();

		[DebuggerNonUserCode]
		public void SetParentAccNull();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class COA_TRowChangeEvent : EventArgs
	{
		private DataRowAction eventAction;

		private COA_TRow eventRow;

		[DebuggerNonUserCode]
		public DataRowAction Action;

		[DebuggerNonUserCode]
		public COA_TRow Row;

		[DebuggerNonUserCode]
		public COA_TRowChangeEvent(COA_TRow row, DataRowAction action);
	}

	public sealed class COA_TRowChangeEventHandler : MulticastDelegate
	{
		public COA_TRowChangeEventHandler(object object, IntPtr method);

		public virtual IAsyncResult BeginInvoke(object sender, COA_TRowChangeEvent e, AsyncCallback callback, object object);

		public virtual void EndInvoke(IAsyncResult result);

		public virtual void Invoke(object sender, COA_TRowChangeEvent e);
	}

	[DefaultMember("Item")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class DailyJournalDataTable : TypedTableBase<DailyJournalRow>
	{
		private DataColumn columnAccount;

		private DataColumn columncode;

		private DataColumn columnCredit;

		private DataColumn columnDate_DT;

		private DataColumn columnDebit;

		private DataColumn columnDescrip_VC;

		private DailyJournalRowChangeEventHandler DailyJournalRowChanged;

		private DailyJournalRowChangeEventHandler DailyJournalRowChanging;

		private DailyJournalRowChangeEventHandler DailyJournalRowDeleted;

		private DailyJournalRowChangeEventHandler DailyJournalRowDeleting;

		[DebuggerNonUserCode]
		public DataColumn AccountColumn;

		[DebuggerNonUserCode]
		public DataColumn codeColumn;

		[Browsable(false)]
		[DebuggerNonUserCode]
		public int Count;

		[DebuggerNonUserCode]
		public DataColumn CreditColumn;

		[DebuggerNonUserCode]
		public DataColumn Date_DTColumn;

		[DebuggerNonUserCode]
		public DataColumn DebitColumn;

		[DebuggerNonUserCode]
		public DataColumn Descrip_VCColumn;

		[DebuggerNonUserCode]
		public DailyJournalRow Item;

		[DebuggerNonUserCode]
		public DailyJournalDataTable();

		[DebuggerNonUserCode]
		internal DailyJournalDataTable(DataTable table);

		[DebuggerNonUserCode]
		protected DailyJournalDataTable(SerializationInfo info, StreamingContext context);

		[DebuggerNonUserCode]
		public void AddDailyJournalRow(DailyJournalRow row);

		[DebuggerNonUserCode]
		public DailyJournalRow AddDailyJournalRow(int code, int Account, decimal Debit, decimal Credit, string Descrip_VC, DateTime Date_DT);

		[DebuggerNonUserCode]
		public override DataTable Clone();

		[DebuggerNonUserCode]
		protected override DataTable CreateInstance();

		[DebuggerNonUserCode]
		protected override Type GetRowType();

		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs);

		[DebuggerNonUserCode]
		private void InitClass();

		[DebuggerNonUserCode]
		internal void InitVars();

		[DebuggerNonUserCode]
		public DailyJournalRow NewDailyJournalRow();

		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder);

		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		public void RemoveDailyJournalRow(DailyJournalRow row);

		public event DailyJournalRowChangeEventHandler DailyJournalRowChanged;;

		public event DailyJournalRowChangeEventHandler DailyJournalRowChanging;;

		public event DailyJournalRowChangeEventHandler DailyJournalRowDeleted;;

		public event DailyJournalRowChangeEventHandler DailyJournalRowDeleting;;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class DailyJournalRow : DataRow
	{
		private DailyJournalDataTable tableDailyJournal;

		[DebuggerNonUserCode]
		public int Account;

		[DebuggerNonUserCode]
		public int code;

		[DebuggerNonUserCode]
		public decimal Credit;

		[DebuggerNonUserCode]
		public DateTime Date_DT;

		[DebuggerNonUserCode]
		public decimal Debit;

		[DebuggerNonUserCode]
		public string Descrip_VC;

		[DebuggerNonUserCode]
		internal DailyJournalRow(DataRowBuilder rb);

		[DebuggerNonUserCode]
		public bool IsCreditNull();

		[DebuggerNonUserCode]
		public bool IsDebitNull();

		[DebuggerNonUserCode]
		public void SetCreditNull();

		[DebuggerNonUserCode]
		public void SetDebitNull();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class DailyJournalRowChangeEvent : EventArgs
	{
		private DataRowAction eventAction;

		private DailyJournalRow eventRow;

		[DebuggerNonUserCode]
		public DataRowAction Action;

		[DebuggerNonUserCode]
		public DailyJournalRow Row;

		[DebuggerNonUserCode]
		public DailyJournalRowChangeEvent(DailyJournalRow row, DataRowAction action);
	}

	public sealed class DailyJournalRowChangeEventHandler : MulticastDelegate
	{
		public DailyJournalRowChangeEventHandler(object object, IntPtr method);

		public virtual IAsyncResult BeginInvoke(object sender, DailyJournalRowChangeEvent e, AsyncCallback callback, object object);

		public virtual void EndInvoke(IAsyncResult result);

		public virtual void Invoke(object sender, DailyJournalRowChangeEvent e);
	}

	[DefaultMember("Item")]
	[XmlSchemaProvider("GetTypedTableSchema")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	[Serializable]
	public class EmployeeDataTable : TypedTableBase<EmployeeRow>
	{
		private DataColumn columnAccCode;

		private DataColumn columnAddress;

		private DataColumn columnEmployeeID;

		private DataColumn columnIDNumber;

		private DataColumn columnName;

		private DataColumn columnNationality;

		private DataColumn columnPhone;

		private DataColumn columnRole;

		private EmployeeRowChangeEventHandler EmployeeRowChanged;

		private EmployeeRowChangeEventHandler EmployeeRowChanging;

		private EmployeeRowChangeEventHandler EmployeeRowDeleted;

		private EmployeeRowChangeEventHandler EmployeeRowDeleting;

		[DebuggerNonUserCode]
		public DataColumn AccCodeColumn;

		[DebuggerNonUserCode]
		public DataColumn AddressColumn;

		[Browsable(false)]
		[DebuggerNonUserCode]
		public int Count;

		[DebuggerNonUserCode]
		public DataColumn EmployeeIDColumn;

		[DebuggerNonUserCode]
		public DataColumn IDNumberColumn;

		[DebuggerNonUserCode]
		public EmployeeRow Item;

		[DebuggerNonUserCode]
		public DataColumn NameColumn;

		[DebuggerNonUserCode]
		public DataColumn NationalityColumn;

		[DebuggerNonUserCode]
		public DataColumn PhoneColumn;

		[DebuggerNonUserCode]
		public DataColumn RoleColumn;

		[DebuggerNonUserCode]
		public EmployeeDataTable();

		[DebuggerNonUserCode]
		internal EmployeeDataTable(DataTable table);

		[DebuggerNonUserCode]
		protected EmployeeDataTable(SerializationInfo info, StreamingContext context);

		[DebuggerNonUserCode]
		public void AddEmployeeRow(EmployeeRow row);

		[DebuggerNonUserCode]
		public EmployeeRow AddEmployeeRow(string Name, string Nationality, long IDNumber, long Phone, string Address, int AccCode, string Role);

		[DebuggerNonUserCode]
		public override DataTable Clone();

		[DebuggerNonUserCode]
		protected override DataTable CreateInstance();

		[DebuggerNonUserCode]
		public EmployeeRow FindByEmployeeID(int EmployeeID);

		[DebuggerNonUserCode]
		protected override Type GetRowType();

		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs);

		[DebuggerNonUserCode]
		private void InitClass();

		[DebuggerNonUserCode]
		internal void InitVars();

		[DebuggerNonUserCode]
		public EmployeeRow NewEmployeeRow();

		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder);

		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		public void RemoveEmployeeRow(EmployeeRow row);

		public event EmployeeRowChangeEventHandler EmployeeRowChanged;;

		public event EmployeeRowChangeEventHandler EmployeeRowChanging;;

		public event EmployeeRowChangeEventHandler EmployeeRowDeleted;;

		public event EmployeeRowChangeEventHandler EmployeeRowDeleting;;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class EmployeeRow : DataRow
	{
		private EmployeeDataTable tableEmployee;

		[DebuggerNonUserCode]
		public int AccCode;

		[DebuggerNonUserCode]
		public string Address;

		[DebuggerNonUserCode]
		public int EmployeeID;

		[DebuggerNonUserCode]
		public long IDNumber;

		[DebuggerNonUserCode]
		public string Name;

		[DebuggerNonUserCode]
		public string Nationality;

		[DebuggerNonUserCode]
		public long Phone;

		[DebuggerNonUserCode]
		public string Role;

		[DebuggerNonUserCode]
		internal EmployeeRow(DataRowBuilder rb);

		[DebuggerNonUserCode]
		public bool IsAddressNull();

		[DebuggerNonUserCode]
		public bool IsPhoneNull();

		[DebuggerNonUserCode]
		public void SetAddressNull();

		[DebuggerNonUserCode]
		public void SetPhoneNull();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class EmployeeRowChangeEvent : EventArgs
	{
		private DataRowAction eventAction;

		private EmployeeRow eventRow;

		[DebuggerNonUserCode]
		public DataRowAction Action;

		[DebuggerNonUserCode]
		public EmployeeRow Row;

		[DebuggerNonUserCode]
		public EmployeeRowChangeEvent(EmployeeRow row, DataRowAction action);
	}

	public sealed class EmployeeRowChangeEventHandler : MulticastDelegate
	{
		public EmployeeRowChangeEventHandler(object object, IntPtr method);

		public virtual IAsyncResult BeginInvoke(object sender, EmployeeRowChangeEvent e, AsyncCallback callback, object object);

		public virtual void EndInvoke(IAsyncResult result);

		public virtual void Invoke(object sender, EmployeeRowChangeEvent e);
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[DefaultMember("Item")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	[Serializable]
	public class FixedAssetReportDataTable : TypedTableBase<FixedAssetReportRow>
	{
		private DataColumn columnAccDep;

		private DataColumn columndesc;

		private DataColumn columnlastAccDep;

		private DataColumn columnlastYearBalance;

		private DataColumn columntotal;

		private DataColumn columnyearBalance;

		private DataColumn columnyearCredit;

		private DataColumn columnyearDebit;

		private DataColumn columnyearDep;

		private FixedAssetReportRowChangeEventHandler FixedAssetReportRowChanged;

		private FixedAssetReportRowChangeEventHandler FixedAssetReportRowChanging;

		private FixedAssetReportRowChangeEventHandler FixedAssetReportRowDeleted;

		private FixedAssetReportRowChangeEventHandler FixedAssetReportRowDeleting;

		[DebuggerNonUserCode]
		public DataColumn AccDepColumn;

		[DebuggerNonUserCode]
		[Browsable(false)]
		public int Count;

		[DebuggerNonUserCode]
		public DataColumn descColumn;

		[DebuggerNonUserCode]
		public FixedAssetReportRow Item;

		[DebuggerNonUserCode]
		public DataColumn lastAccDepColumn;

		[DebuggerNonUserCode]
		public DataColumn lastYearBalanceColumn;

		[DebuggerNonUserCode]
		public DataColumn totalColumn;

		[DebuggerNonUserCode]
		public DataColumn yearBalanceColumn;

		[DebuggerNonUserCode]
		public DataColumn yearCreditColumn;

		[DebuggerNonUserCode]
		public DataColumn yearDebitColumn;

		[DebuggerNonUserCode]
		public DataColumn yearDepColumn;

		[DebuggerNonUserCode]
		public FixedAssetReportDataTable();

		[DebuggerNonUserCode]
		internal FixedAssetReportDataTable(DataTable table);

		[DebuggerNonUserCode]
		protected FixedAssetReportDataTable(SerializationInfo info, StreamingContext context);

		[DebuggerNonUserCode]
		public void AddFixedAssetReportRow(FixedAssetReportRow row);

		[DebuggerNonUserCode]
		public FixedAssetReportRow AddFixedAssetReportRow(string desc, decimal lastYearBalance, decimal yearDebit, decimal yearCredit, decimal yearBalance, decimal lastAccDep, decimal yearDep, decimal AccDep, decimal total);

		[DebuggerNonUserCode]
		public override DataTable Clone();

		[DebuggerNonUserCode]
		protected override DataTable CreateInstance();

		[DebuggerNonUserCode]
		protected override Type GetRowType();

		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs);

		[DebuggerNonUserCode]
		private void InitClass();

		[DebuggerNonUserCode]
		internal void InitVars();

		[DebuggerNonUserCode]
		public FixedAssetReportRow NewFixedAssetReportRow();

		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder);

		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		public void RemoveFixedAssetReportRow(FixedAssetReportRow row);

		public event FixedAssetReportRowChangeEventHandler FixedAssetReportRowChanged;;

		public event FixedAssetReportRowChangeEventHandler FixedAssetReportRowChanging;;

		public event FixedAssetReportRowChangeEventHandler FixedAssetReportRowDeleted;;

		public event FixedAssetReportRowChangeEventHandler FixedAssetReportRowDeleting;;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class FixedAssetReportRow : DataRow
	{
		private FixedAssetReportDataTable tableFixedAssetReport;

		[DebuggerNonUserCode]
		public decimal AccDep;

		[DebuggerNonUserCode]
		public string desc;

		[DebuggerNonUserCode]
		public decimal lastAccDep;

		[DebuggerNonUserCode]
		public decimal lastYearBalance;

		[DebuggerNonUserCode]
		public decimal total;

		[DebuggerNonUserCode]
		public decimal yearBalance;

		[DebuggerNonUserCode]
		public decimal yearCredit;

		[DebuggerNonUserCode]
		public decimal yearDebit;

		[DebuggerNonUserCode]
		public decimal yearDep;

		[DebuggerNonUserCode]
		internal FixedAssetReportRow(DataRowBuilder rb);

		[DebuggerNonUserCode]
		public bool IsAccDepNull();

		[DebuggerNonUserCode]
		public bool IsdescNull();

		[DebuggerNonUserCode]
		public bool IslastAccDepNull();

		[DebuggerNonUserCode]
		public bool IslastYearBalanceNull();

		[DebuggerNonUserCode]
		public bool IstotalNull();

		[DebuggerNonUserCode]
		public bool IsyearBalanceNull();

		[DebuggerNonUserCode]
		public bool IsyearCreditNull();

		[DebuggerNonUserCode]
		public bool IsyearDebitNull();

		[DebuggerNonUserCode]
		public bool IsyearDepNull();

		[DebuggerNonUserCode]
		public void SetAccDepNull();

		[DebuggerNonUserCode]
		public void SetdescNull();

		[DebuggerNonUserCode]
		public void SetlastAccDepNull();

		[DebuggerNonUserCode]
		public void SetlastYearBalanceNull();

		[DebuggerNonUserCode]
		public void SettotalNull();

		[DebuggerNonUserCode]
		public void SetyearBalanceNull();

		[DebuggerNonUserCode]
		public void SetyearCreditNull();

		[DebuggerNonUserCode]
		public void SetyearDebitNull();

		[DebuggerNonUserCode]
		public void SetyearDepNull();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class FixedAssetReportRowChangeEvent : EventArgs
	{
		private DataRowAction eventAction;

		private FixedAssetReportRow eventRow;

		[DebuggerNonUserCode]
		public DataRowAction Action;

		[DebuggerNonUserCode]
		public FixedAssetReportRow Row;

		[DebuggerNonUserCode]
		public FixedAssetReportRowChangeEvent(FixedAssetReportRow row, DataRowAction action);
	}

	public sealed class FixedAssetReportRowChangeEventHandler : MulticastDelegate
	{
		public FixedAssetReportRowChangeEventHandler(object object, IntPtr method);

		public virtual IAsyncResult BeginInvoke(object sender, FixedAssetReportRowChangeEvent e, AsyncCallback callback, object object);

		public virtual void EndInvoke(IAsyncResult result);

		public virtual void Invoke(object sender, FixedAssetReportRowChangeEvent e);
	}

	[DefaultMember("Item")]
	[XmlSchemaProvider("GetTypedTableSchema")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	[Serializable]
	public class getParentDataTable : TypedTableBase<getParentRow>
	{
		private DataColumn columnParentAcc;

		private getParentRowChangeEventHandler getParentRowChanged;

		private getParentRowChangeEventHandler getParentRowChanging;

		private getParentRowChangeEventHandler getParentRowDeleted;

		private getParentRowChangeEventHandler getParentRowDeleting;

		[DebuggerNonUserCode]
		[Browsable(false)]
		public int Count;

		[DebuggerNonUserCode]
		public getParentRow Item;

		[DebuggerNonUserCode]
		public DataColumn ParentAccColumn;

		[DebuggerNonUserCode]
		public getParentDataTable();

		[DebuggerNonUserCode]
		internal getParentDataTable(DataTable table);

		[DebuggerNonUserCode]
		protected getParentDataTable(SerializationInfo info, StreamingContext context);

		[DebuggerNonUserCode]
		public void AddgetParentRow(getParentRow row);

		[DebuggerNonUserCode]
		public getParentRow AddgetParentRow(int ParentAcc);

		[DebuggerNonUserCode]
		public override DataTable Clone();

		[DebuggerNonUserCode]
		protected override DataTable CreateInstance();

		[DebuggerNonUserCode]
		protected override Type GetRowType();

		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs);

		[DebuggerNonUserCode]
		private void InitClass();

		[DebuggerNonUserCode]
		internal void InitVars();

		[DebuggerNonUserCode]
		public getParentRow NewgetParentRow();

		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder);

		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		public void RemovegetParentRow(getParentRow row);

		public event getParentRowChangeEventHandler getParentRowChanged;;

		public event getParentRowChangeEventHandler getParentRowChanging;;

		public event getParentRowChangeEventHandler getParentRowDeleted;;

		public event getParentRowChangeEventHandler getParentRowDeleting;;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class getParentRow : DataRow
	{
		private getParentDataTable tablegetParent;

		[DebuggerNonUserCode]
		public int ParentAcc;

		[DebuggerNonUserCode]
		internal getParentRow(DataRowBuilder rb);

		[DebuggerNonUserCode]
		public bool IsParentAccNull();

		[DebuggerNonUserCode]
		public void SetParentAccNull();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class getParentRowChangeEvent : EventArgs
	{
		private DataRowAction eventAction;

		private getParentRow eventRow;

		[DebuggerNonUserCode]
		public DataRowAction Action;

		[DebuggerNonUserCode]
		public getParentRow Row;

		[DebuggerNonUserCode]
		public getParentRowChangeEvent(getParentRow row, DataRowAction action);
	}

	public sealed class getParentRowChangeEventHandler : MulticastDelegate
	{
		public getParentRowChangeEventHandler(object object, IntPtr method);

		public virtual IAsyncResult BeginInvoke(object sender, getParentRowChangeEvent e, AsyncCallback callback, object object);

		public virtual void EndInvoke(IAsyncResult result);

		public virtual void Invoke(object sender, getParentRowChangeEvent e);
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[DefaultMember("Item")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	[Serializable]
	public class Journal_TDataTable : TypedTableBase<Journal_TRow>
	{
		private DataColumn columnAmount_NU;

		private DataColumn columnDate_DT;

		private DataColumn columnDescrip_VC;

		private DataColumn columnDoc_No_VC;

		private DataColumn columnGL_ID;

		private DataColumn columnPeriod_TI;

		private DataColumn columnYear_SI;

		private Journal_TRowChangeEventHandler Journal_TRowChanged;

		private Journal_TRowChangeEventHandler Journal_TRowChanging;

		private Journal_TRowChangeEventHandler Journal_TRowDeleted;

		private Journal_TRowChangeEventHandler Journal_TRowDeleting;

		[DebuggerNonUserCode]
		public DataColumn Amount_NUColumn;

		[Browsable(false)]
		[DebuggerNonUserCode]
		public int Count;

		[DebuggerNonUserCode]
		public DataColumn Date_DTColumn;

		[DebuggerNonUserCode]
		public DataColumn Descrip_VCColumn;

		[DebuggerNonUserCode]
		public DataColumn Doc_No_VCColumn;

		[DebuggerNonUserCode]
		public DataColumn GL_IDColumn;

		[DebuggerNonUserCode]
		public Journal_TRow Item;

		[DebuggerNonUserCode]
		public DataColumn Period_TIColumn;

		[DebuggerNonUserCode]
		public DataColumn Year_SIColumn;

		[DebuggerNonUserCode]
		public Journal_TDataTable();

		[DebuggerNonUserCode]
		internal Journal_TDataTable(DataTable table);

		[DebuggerNonUserCode]
		protected Journal_TDataTable(SerializationInfo info, StreamingContext context);

		[DebuggerNonUserCode]
		public void AddJournal_TRow(Journal_TRow row);

		[DebuggerNonUserCode]
		public Journal_TRow AddJournal_TRow(Cash_TRow parentCash_TRowByFK_Journal_T_Cash_T, COA_TRow parentCOA_TRowByFK_Journal_T_COA_T, decimal Amount_NU, string Descrip_VC, DateTime Date_DT, byte Period_TI, short Year_SI);

		[DebuggerNonUserCode]
		public override DataTable Clone();

		[DebuggerNonUserCode]
		protected override DataTable CreateInstance();

		[DebuggerNonUserCode]
		protected override Type GetRowType();

		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs);

		[DebuggerNonUserCode]
		private void InitClass();

		[DebuggerNonUserCode]
		internal void InitVars();

		[DebuggerNonUserCode]
		public Journal_TRow NewJournal_TRow();

		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder);

		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		public void RemoveJournal_TRow(Journal_TRow row);

		public event Journal_TRowChangeEventHandler Journal_TRowChanged;;

		public event Journal_TRowChangeEventHandler Journal_TRowChanging;;

		public event Journal_TRowChangeEventHandler Journal_TRowDeleted;;

		public event Journal_TRowChangeEventHandler Journal_TRowDeleting;;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class Journal_TRow : DataRow
	{
		private Journal_TDataTable tableJournal_T;

		[DebuggerNonUserCode]
		public decimal Amount_NU;

		[DebuggerNonUserCode]
		public Cash_TRow Cash_TRow;

		[DebuggerNonUserCode]
		public COA_TRow COA_TRow;

		[DebuggerNonUserCode]
		public DateTime Date_DT;

		[DebuggerNonUserCode]
		public string Descrip_VC;

		[DebuggerNonUserCode]
		public int Doc_No_VC;

		[DebuggerNonUserCode]
		public int GL_ID;

		[DebuggerNonUserCode]
		public byte Period_TI;

		[DebuggerNonUserCode]
		public short Year_SI;

		[DebuggerNonUserCode]
		internal Journal_TRow(DataRowBuilder rb);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class Journal_TRowChangeEvent : EventArgs
	{
		private DataRowAction eventAction;

		private Journal_TRow eventRow;

		[DebuggerNonUserCode]
		public DataRowAction Action;

		[DebuggerNonUserCode]
		public Journal_TRow Row;

		[DebuggerNonUserCode]
		public Journal_TRowChangeEvent(Journal_TRow row, DataRowAction action);
	}

	public sealed class Journal_TRowChangeEventHandler : MulticastDelegate
	{
		public Journal_TRowChangeEventHandler(object object, IntPtr method);

		public virtual IAsyncResult BeginInvoke(object sender, Journal_TRowChangeEvent e, AsyncCallback callback, object object);

		public virtual void EndInvoke(IAsyncResult result);

		public virtual void Invoke(object sender, Journal_TRowChangeEvent e);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	[XmlSchemaProvider("GetTypedTableSchema")]
	[DefaultMember("Item")]
	[Serializable]
	public class ProfitLossDataTable : TypedTableBase<ProfitLossRow>
	{
		private DataColumn columnAmount;

		private DataColumn columnDesc;

		private ProfitLossRowChangeEventHandler ProfitLossRowChanged;

		private ProfitLossRowChangeEventHandler ProfitLossRowChanging;

		private ProfitLossRowChangeEventHandler ProfitLossRowDeleted;

		private ProfitLossRowChangeEventHandler ProfitLossRowDeleting;

		[DebuggerNonUserCode]
		public DataColumn AmountColumn;

		[DebuggerNonUserCode]
		[Browsable(false)]
		public int Count;

		[DebuggerNonUserCode]
		public DataColumn DescColumn;

		[DebuggerNonUserCode]
		public ProfitLossRow Item;

		[DebuggerNonUserCode]
		public ProfitLossDataTable();

		[DebuggerNonUserCode]
		internal ProfitLossDataTable(DataTable table);

		[DebuggerNonUserCode]
		protected ProfitLossDataTable(SerializationInfo info, StreamingContext context);

		[DebuggerNonUserCode]
		public void AddProfitLossRow(ProfitLossRow row);

		[DebuggerNonUserCode]
		public ProfitLossRow AddProfitLossRow(string Desc, decimal Amount);

		[DebuggerNonUserCode]
		public override DataTable Clone();

		[DebuggerNonUserCode]
		protected override DataTable CreateInstance();

		[DebuggerNonUserCode]
		protected override Type GetRowType();

		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs);

		[DebuggerNonUserCode]
		private void InitClass();

		[DebuggerNonUserCode]
		internal void InitVars();

		[DebuggerNonUserCode]
		public ProfitLossRow NewProfitLossRow();

		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder);

		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		public void RemoveProfitLossRow(ProfitLossRow row);

		public event ProfitLossRowChangeEventHandler ProfitLossRowChanged;;

		public event ProfitLossRowChangeEventHandler ProfitLossRowChanging;;

		public event ProfitLossRowChangeEventHandler ProfitLossRowDeleted;;

		public event ProfitLossRowChangeEventHandler ProfitLossRowDeleting;;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class ProfitLossRow : DataRow
	{
		private ProfitLossDataTable tableProfitLoss;

		[DebuggerNonUserCode]
		public decimal Amount;

		[DebuggerNonUserCode]
		public string Desc;

		[DebuggerNonUserCode]
		internal ProfitLossRow(DataRowBuilder rb);

		[DebuggerNonUserCode]
		public bool IsAmountNull();

		[DebuggerNonUserCode]
		public bool IsDescNull();

		[DebuggerNonUserCode]
		public void SetAmountNull();

		[DebuggerNonUserCode]
		public void SetDescNull();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class ProfitLossRowChangeEvent : EventArgs
	{
		private DataRowAction eventAction;

		private ProfitLossRow eventRow;

		[DebuggerNonUserCode]
		public DataRowAction Action;

		[DebuggerNonUserCode]
		public ProfitLossRow Row;

		[DebuggerNonUserCode]
		public ProfitLossRowChangeEvent(ProfitLossRow row, DataRowAction action);
	}

	public sealed class ProfitLossRowChangeEventHandler : MulticastDelegate
	{
		public ProfitLossRowChangeEventHandler(object object, IntPtr method);

		public virtual IAsyncResult BeginInvoke(object sender, ProfitLossRowChangeEvent e, AsyncCallback callback, object object);

		public virtual void EndInvoke(IAsyncResult result);

		public virtual void Invoke(object sender, ProfitLossRowChangeEvent e);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	[XmlSchemaProvider("GetTypedTableSchema")]
	[DefaultMember("Item")]
	[Serializable]
	public class ReportDataTable : TypedTableBase<ReportRow>
	{
		private DataColumn columnAccount;

		private DataColumn columnBalance;

		private DataColumn columncode;

		private DataColumn columnCredit;

		private DataColumn columnDate_DT;

		private DataColumn columnDebit;

		private DataColumn columnDescrip_VC;

		private ReportRowChangeEventHandler ReportRowChanged;

		private ReportRowChangeEventHandler ReportRowChanging;

		private ReportRowChangeEventHandler ReportRowDeleted;

		private ReportRowChangeEventHandler ReportRowDeleting;

		[DebuggerNonUserCode]
		public DataColumn AccountColumn;

		[DebuggerNonUserCode]
		public DataColumn BalanceColumn;

		[DebuggerNonUserCode]
		public DataColumn codeColumn;

		[DebuggerNonUserCode]
		[Browsable(false)]
		public int Count;

		[DebuggerNonUserCode]
		public DataColumn CreditColumn;

		[DebuggerNonUserCode]
		public DataColumn Date_DTColumn;

		[DebuggerNonUserCode]
		public DataColumn DebitColumn;

		[DebuggerNonUserCode]
		public DataColumn Descrip_VCColumn;

		[DebuggerNonUserCode]
		public ReportRow Item;

		[DebuggerNonUserCode]
		public ReportDataTable();

		[DebuggerNonUserCode]
		internal ReportDataTable(DataTable table);

		[DebuggerNonUserCode]
		protected ReportDataTable(SerializationInfo info, StreamingContext context);

		[DebuggerNonUserCode]
		public void AddReportRow(ReportRow row);

		[DebuggerNonUserCode]
		public ReportRow AddReportRow(int code, int Account, decimal Debit, decimal Credit, string Descrip_VC, DateTime Date_DT, decimal Balance);

		[DebuggerNonUserCode]
		public override DataTable Clone();

		[DebuggerNonUserCode]
		protected override DataTable CreateInstance();

		[DebuggerNonUserCode]
		protected override Type GetRowType();

		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs);

		[DebuggerNonUserCode]
		private void InitClass();

		[DebuggerNonUserCode]
		internal void InitVars();

		[DebuggerNonUserCode]
		public ReportRow NewReportRow();

		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder);

		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		public void RemoveReportRow(ReportRow row);

		public event ReportRowChangeEventHandler ReportRowChanged;;

		public event ReportRowChangeEventHandler ReportRowChanging;;

		public event ReportRowChangeEventHandler ReportRowDeleted;;

		public event ReportRowChangeEventHandler ReportRowDeleting;;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class ReportRow : DataRow
	{
		private ReportDataTable tableReport;

		[DebuggerNonUserCode]
		public int Account;

		[DebuggerNonUserCode]
		public decimal Balance;

		[DebuggerNonUserCode]
		public int code;

		[DebuggerNonUserCode]
		public decimal Credit;

		[DebuggerNonUserCode]
		public DateTime Date_DT;

		[DebuggerNonUserCode]
		public decimal Debit;

		[DebuggerNonUserCode]
		public string Descrip_VC;

		[DebuggerNonUserCode]
		internal ReportRow(DataRowBuilder rb);

		[DebuggerNonUserCode]
		public bool IsBalanceNull();

		[DebuggerNonUserCode]
		public bool IsCreditNull();

		[DebuggerNonUserCode]
		public bool IsDebitNull();

		[DebuggerNonUserCode]
		public void SetBalanceNull();

		[DebuggerNonUserCode]
		public void SetCreditNull();

		[DebuggerNonUserCode]
		public void SetDebitNull();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class ReportRowChangeEvent : EventArgs
	{
		private DataRowAction eventAction;

		private ReportRow eventRow;

		[DebuggerNonUserCode]
		public DataRowAction Action;

		[DebuggerNonUserCode]
		public ReportRow Row;

		[DebuggerNonUserCode]
		public ReportRowChangeEvent(ReportRow row, DataRowAction action);
	}

	public sealed class ReportRowChangeEventHandler : MulticastDelegate
	{
		public ReportRowChangeEventHandler(object object, IntPtr method);

		public virtual IAsyncResult BeginInvoke(object sender, ReportRowChangeEvent e, AsyncCallback callback, object object);

		public virtual void EndInvoke(IAsyncResult result);

		public virtual void Invoke(object sender, ReportRowChangeEvent e);
	}

	[DefaultMember("Item")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class Sec_TDataTable : TypedTableBase<Sec_TRow>
	{
		private DataColumn columnID;

		private DataColumn columnName;

		private DataColumn columnType;

		private DataColumn columnValue;

		private Sec_TRowChangeEventHandler Sec_TRowChanged;

		private Sec_TRowChangeEventHandler Sec_TRowChanging;

		private Sec_TRowChangeEventHandler Sec_TRowDeleted;

		private Sec_TRowChangeEventHandler Sec_TRowDeleting;

		[DebuggerNonUserCode]
		[Browsable(false)]
		public int Count;

		[DebuggerNonUserCode]
		public DataColumn IDColumn;

		[DebuggerNonUserCode]
		public Sec_TRow Item;

		[DebuggerNonUserCode]
		public DataColumn NameColumn;

		[DebuggerNonUserCode]
		public DataColumn TypeColumn;

		[DebuggerNonUserCode]
		public DataColumn ValueColumn;

		[DebuggerNonUserCode]
		public Sec_TDataTable();

		[DebuggerNonUserCode]
		internal Sec_TDataTable(DataTable table);

		[DebuggerNonUserCode]
		protected Sec_TDataTable(SerializationInfo info, StreamingContext context);

		[DebuggerNonUserCode]
		public void AddSec_TRow(Sec_TRow row);

		[DebuggerNonUserCode]
		public Sec_TRow AddSec_TRow(string Type, string Value, string Name);

		[DebuggerNonUserCode]
		public override DataTable Clone();

		[DebuggerNonUserCode]
		protected override DataTable CreateInstance();

		[DebuggerNonUserCode]
		public Sec_TRow FindByID(int ID);

		[DebuggerNonUserCode]
		protected override Type GetRowType();

		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs);

		[DebuggerNonUserCode]
		private void InitClass();

		[DebuggerNonUserCode]
		internal void InitVars();

		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder);

		[DebuggerNonUserCode]
		public Sec_TRow NewSec_TRow();

		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		public void RemoveSec_TRow(Sec_TRow row);

		public event Sec_TRowChangeEventHandler Sec_TRowChanged;;

		public event Sec_TRowChangeEventHandler Sec_TRowChanging;;

		public event Sec_TRowChangeEventHandler Sec_TRowDeleted;;

		public event Sec_TRowChangeEventHandler Sec_TRowDeleting;;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class Sec_TRow : DataRow
	{
		private Sec_TDataTable tableSec_T;

		[DebuggerNonUserCode]
		public int ID;

		[DebuggerNonUserCode]
		public string Name;

		[DebuggerNonUserCode]
		public string Type;

		[DebuggerNonUserCode]
		public string Value;

		[DebuggerNonUserCode]
		internal Sec_TRow(DataRowBuilder rb);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class Sec_TRowChangeEvent : EventArgs
	{
		private DataRowAction eventAction;

		private Sec_TRow eventRow;

		[DebuggerNonUserCode]
		public DataRowAction Action;

		[DebuggerNonUserCode]
		public Sec_TRow Row;

		[DebuggerNonUserCode]
		public Sec_TRowChangeEvent(Sec_TRow row, DataRowAction action);
	}

	public sealed class Sec_TRowChangeEventHandler : MulticastDelegate
	{
		public Sec_TRowChangeEventHandler(object object, IntPtr method);

		public virtual IAsyncResult BeginInvoke(object sender, Sec_TRowChangeEvent e, AsyncCallback callback, object object);

		public virtual void EndInvoke(IAsyncResult result);

		public virtual void Invoke(object sender, Sec_TRowChangeEvent e);
	}

	[DefaultMember("Item")]
	[XmlSchemaProvider("GetTypedTableSchema")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	[Serializable]
	public class SupplierDataTable : TypedTableBase<SupplierRow>
	{
		private DataColumn columnAccCode;

		private DataColumn columnAddress;

		private DataColumn columnName;

		private DataColumn columnPersonName;

		private DataColumn columnPhone;

		private DataColumn columnSupplierID;

		private SupplierRowChangeEventHandler SupplierRowChanged;

		private SupplierRowChangeEventHandler SupplierRowChanging;

		private SupplierRowChangeEventHandler SupplierRowDeleted;

		private SupplierRowChangeEventHandler SupplierRowDeleting;

		[DebuggerNonUserCode]
		public DataColumn AccCodeColumn;

		[DebuggerNonUserCode]
		public DataColumn AddressColumn;

		[DebuggerNonUserCode]
		[Browsable(false)]
		public int Count;

		[DebuggerNonUserCode]
		public SupplierRow Item;

		[DebuggerNonUserCode]
		public DataColumn NameColumn;

		[DebuggerNonUserCode]
		public DataColumn PersonNameColumn;

		[DebuggerNonUserCode]
		public DataColumn PhoneColumn;

		[DebuggerNonUserCode]
		public DataColumn SupplierIDColumn;

		[DebuggerNonUserCode]
		public SupplierDataTable();

		[DebuggerNonUserCode]
		internal SupplierDataTable(DataTable table);

		[DebuggerNonUserCode]
		protected SupplierDataTable(SerializationInfo info, StreamingContext context);

		[DebuggerNonUserCode]
		public void AddSupplierRow(SupplierRow row);

		[DebuggerNonUserCode]
		public SupplierRow AddSupplierRow(string Name, string PersonName, string Address, long Phone, int AccCode);

		[DebuggerNonUserCode]
		public override DataTable Clone();

		[DebuggerNonUserCode]
		protected override DataTable CreateInstance();

		[DebuggerNonUserCode]
		public SupplierRow FindBySupplierID(int SupplierID);

		[DebuggerNonUserCode]
		protected override Type GetRowType();

		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs);

		[DebuggerNonUserCode]
		private void InitClass();

		[DebuggerNonUserCode]
		internal void InitVars();

		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder);

		[DebuggerNonUserCode]
		public SupplierRow NewSupplierRow();

		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		public void RemoveSupplierRow(SupplierRow row);

		public event SupplierRowChangeEventHandler SupplierRowChanged;;

		public event SupplierRowChangeEventHandler SupplierRowChanging;;

		public event SupplierRowChangeEventHandler SupplierRowDeleted;;

		public event SupplierRowChangeEventHandler SupplierRowDeleting;;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class SupplierRow : DataRow
	{
		private SupplierDataTable tableSupplier;

		[DebuggerNonUserCode]
		public int AccCode;

		[DebuggerNonUserCode]
		public string Address;

		[DebuggerNonUserCode]
		public string Name;

		[DebuggerNonUserCode]
		public string PersonName;

		[DebuggerNonUserCode]
		public long Phone;

		[DebuggerNonUserCode]
		public int SupplierID;

		[DebuggerNonUserCode]
		internal SupplierRow(DataRowBuilder rb);

		[DebuggerNonUserCode]
		public bool IsAddressNull();

		[DebuggerNonUserCode]
		public bool IsPersonNameNull();

		[DebuggerNonUserCode]
		public bool IsPhoneNull();

		[DebuggerNonUserCode]
		public void SetAddressNull();

		[DebuggerNonUserCode]
		public void SetPersonNameNull();

		[DebuggerNonUserCode]
		public void SetPhoneNull();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class SupplierRowChangeEvent : EventArgs
	{
		private DataRowAction eventAction;

		private SupplierRow eventRow;

		[DebuggerNonUserCode]
		public DataRowAction Action;

		[DebuggerNonUserCode]
		public SupplierRow Row;

		[DebuggerNonUserCode]
		public SupplierRowChangeEvent(SupplierRow row, DataRowAction action);
	}

	public sealed class SupplierRowChangeEventHandler : MulticastDelegate
	{
		public SupplierRowChangeEventHandler(object object, IntPtr method);

		public virtual IAsyncResult BeginInvoke(object sender, SupplierRowChangeEvent e, AsyncCallback callback, object object);

		public virtual void EndInvoke(IAsyncResult result);

		public virtual void Invoke(object sender, SupplierRowChangeEvent e);
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[DefaultMember("Item")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	[Serializable]
	public class TrialBalanceDataTable : TypedTableBase<TrialBalanceRow>
	{
		private DataColumn columnBS_Category_VC;

		private DataColumn columnCategory_Name;

		private DataColumn columnCredit;

		private DataColumn columnCurrCredit;

		private DataColumn columnCurrDebit;

		private DataColumn columnDebit;

		private DataColumn columnGL_ID;

		private DataColumn columnGL_Name_VC;

		private DataColumn columnPreCredit;

		private DataColumn columnPreDebit;

		private TrialBalanceRowChangeEventHandler TrialBalanceRowChanged;

		private TrialBalanceRowChangeEventHandler TrialBalanceRowChanging;

		private TrialBalanceRowChangeEventHandler TrialBalanceRowDeleted;

		private TrialBalanceRowChangeEventHandler TrialBalanceRowDeleting;

		[DebuggerNonUserCode]
		public DataColumn BS_Category_VCColumn;

		[DebuggerNonUserCode]
		public DataColumn Category_NameColumn;

		[DebuggerNonUserCode]
		[Browsable(false)]
		public int Count;

		[DebuggerNonUserCode]
		public DataColumn CreditColumn;

		[DebuggerNonUserCode]
		public DataColumn CurrCreditColumn;

		[DebuggerNonUserCode]
		public DataColumn CurrDebitColumn;

		[DebuggerNonUserCode]
		public DataColumn DebitColumn;

		[DebuggerNonUserCode]
		public DataColumn GL_IDColumn;

		[DebuggerNonUserCode]
		public DataColumn GL_Name_VCColumn;

		[DebuggerNonUserCode]
		public TrialBalanceRow Item;

		[DebuggerNonUserCode]
		public DataColumn PreCreditColumn;

		[DebuggerNonUserCode]
		public DataColumn PreDebitColumn;

		[DebuggerNonUserCode]
		public TrialBalanceDataTable();

		[DebuggerNonUserCode]
		internal TrialBalanceDataTable(DataTable table);

		[DebuggerNonUserCode]
		protected TrialBalanceDataTable(SerializationInfo info, StreamingContext context);

		[DebuggerNonUserCode]
		public void AddTrialBalanceRow(TrialBalanceRow row);

		[DebuggerNonUserCode]
		public TrialBalanceRow AddTrialBalanceRow(string GL_Name_VC, int GL_ID, string Category_Name, int BS_Category_VC, decimal PreDebit, decimal PreCredit, decimal Debit, decimal Credit, decimal CurrDebit, decimal CurrCredit);

		[DebuggerNonUserCode]
		public override DataTable Clone();

		[DebuggerNonUserCode]
		protected override DataTable CreateInstance();

		[DebuggerNonUserCode]
		public TrialBalanceRow FindByGL_ID(int GL_ID);

		[DebuggerNonUserCode]
		protected override Type GetRowType();

		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs);

		[DebuggerNonUserCode]
		private void InitClass();

		[DebuggerNonUserCode]
		internal void InitVars();

		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder);

		[DebuggerNonUserCode]
		public TrialBalanceRow NewTrialBalanceRow();

		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		public void RemoveTrialBalanceRow(TrialBalanceRow row);

		public event TrialBalanceRowChangeEventHandler TrialBalanceRowChanged;;

		public event TrialBalanceRowChangeEventHandler TrialBalanceRowChanging;;

		public event TrialBalanceRowChangeEventHandler TrialBalanceRowDeleted;;

		public event TrialBalanceRowChangeEventHandler TrialBalanceRowDeleting;;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class TrialBalanceRow : DataRow
	{
		private TrialBalanceDataTable tableTrialBalance;

		[DebuggerNonUserCode]
		public int BS_Category_VC;

		[DebuggerNonUserCode]
		public string Category_Name;

		[DebuggerNonUserCode]
		public decimal Credit;

		[DebuggerNonUserCode]
		public decimal CurrCredit;

		[DebuggerNonUserCode]
		public decimal CurrDebit;

		[DebuggerNonUserCode]
		public decimal Debit;

		[DebuggerNonUserCode]
		public int GL_ID;

		[DebuggerNonUserCode]
		public string GL_Name_VC;

		[DebuggerNonUserCode]
		public decimal PreCredit;

		[DebuggerNonUserCode]
		public decimal PreDebit;

		[DebuggerNonUserCode]
		internal TrialBalanceRow(DataRowBuilder rb);

		[DebuggerNonUserCode]
		public bool IsCreditNull();

		[DebuggerNonUserCode]
		public bool IsCurrCreditNull();

		[DebuggerNonUserCode]
		public bool IsCurrDebitNull();

		[DebuggerNonUserCode]
		public bool IsDebitNull();

		[DebuggerNonUserCode]
		public bool IsPreCreditNull();

		[DebuggerNonUserCode]
		public bool IsPreDebitNull();

		[DebuggerNonUserCode]
		public void SetCreditNull();

		[DebuggerNonUserCode]
		public void SetCurrCreditNull();

		[DebuggerNonUserCode]
		public void SetCurrDebitNull();

		[DebuggerNonUserCode]
		public void SetDebitNull();

		[DebuggerNonUserCode]
		public void SetPreCreditNull();

		[DebuggerNonUserCode]
		public void SetPreDebitNull();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class TrialBalanceRowChangeEvent : EventArgs
	{
		private DataRowAction eventAction;

		private TrialBalanceRow eventRow;

		[DebuggerNonUserCode]
		public DataRowAction Action;

		[DebuggerNonUserCode]
		public TrialBalanceRow Row;

		[DebuggerNonUserCode]
		public TrialBalanceRowChangeEvent(TrialBalanceRow row, DataRowAction action);
	}

	public sealed class TrialBalanceRowChangeEventHandler : MulticastDelegate
	{
		public TrialBalanceRowChangeEventHandler(object object, IntPtr method);

		public virtual IAsyncResult BeginInvoke(object sender, TrialBalanceRowChangeEvent e, AsyncCallback callback, object object);

		public virtual void EndInvoke(IAsyncResult result);

		public virtual void Invoke(object sender, TrialBalanceRowChangeEvent e);
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[DefaultMember("Item")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	[Serializable]
	public class VoucherDataTable : TypedTableBase<VoucherRow>
	{
		private DataColumn columnAmount_NU;

		private DataColumn columnBankName;

		private DataColumn columnCAcc;

		private DataColumn columnchkNumber;

		private DataColumn columnCName;

		private DataColumn columnCode;

		private DataColumn columnDAcc;

		private DataColumn columnDate_DT;

		private DataColumn columnDescrip_VC;

		private DataColumn columnDName;

		private VoucherRowChangeEventHandler VoucherRowChanged;

		private VoucherRowChangeEventHandler VoucherRowChanging;

		private VoucherRowChangeEventHandler VoucherRowDeleted;

		private VoucherRowChangeEventHandler VoucherRowDeleting;

		[DebuggerNonUserCode]
		public DataColumn Amount_NUColumn;

		[DebuggerNonUserCode]
		public DataColumn BankNameColumn;

		[DebuggerNonUserCode]
		public DataColumn CAccColumn;

		[DebuggerNonUserCode]
		public DataColumn chkNumberColumn;

		[DebuggerNonUserCode]
		public DataColumn CNameColumn;

		[DebuggerNonUserCode]
		public DataColumn CodeColumn;

		[Browsable(false)]
		[DebuggerNonUserCode]
		public int Count;

		[DebuggerNonUserCode]
		public DataColumn DAccColumn;

		[DebuggerNonUserCode]
		public DataColumn Date_DTColumn;

		[DebuggerNonUserCode]
		public DataColumn Descrip_VCColumn;

		[DebuggerNonUserCode]
		public DataColumn DNameColumn;

		[DebuggerNonUserCode]
		public VoucherRow Item;

		[DebuggerNonUserCode]
		public VoucherDataTable();

		[DebuggerNonUserCode]
		internal VoucherDataTable(DataTable table);

		[DebuggerNonUserCode]
		protected VoucherDataTable(SerializationInfo info, StreamingContext context);

		[DebuggerNonUserCode]
		public void AddVoucherRow(VoucherRow row);

		[DebuggerNonUserCode]
		public VoucherRow AddVoucherRow(int chkNumber, int Code, string BankName, decimal Amount_NU, string Descrip_VC, DateTime Date_DT, int CAcc, string CName, int DAcc, string DName);

		[DebuggerNonUserCode]
		public override DataTable Clone();

		[DebuggerNonUserCode]
		protected override DataTable CreateInstance();

		[DebuggerNonUserCode]
		protected override Type GetRowType();

		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs);

		[DebuggerNonUserCode]
		private void InitClass();

		[DebuggerNonUserCode]
		internal void InitVars();

		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder);

		[DebuggerNonUserCode]
		public VoucherRow NewVoucherRow();

		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e);

		[DebuggerNonUserCode]
		public void RemoveVoucherRow(VoucherRow row);

		public event VoucherRowChangeEventHandler VoucherRowChanged;;

		public event VoucherRowChangeEventHandler VoucherRowChanging;;

		public event VoucherRowChangeEventHandler VoucherRowDeleted;;

		public event VoucherRowChangeEventHandler VoucherRowDeleting;;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class VoucherRow : DataRow
	{
		private VoucherDataTable tableVoucher;

		[DebuggerNonUserCode]
		public decimal Amount_NU;

		[DebuggerNonUserCode]
		public string BankName;

		[DebuggerNonUserCode]
		public int CAcc;

		[DebuggerNonUserCode]
		public int chkNumber;

		[DebuggerNonUserCode]
		public string CName;

		[DebuggerNonUserCode]
		public int Code;

		[DebuggerNonUserCode]
		public int DAcc;

		[DebuggerNonUserCode]
		public DateTime Date_DT;

		[DebuggerNonUserCode]
		public string Descrip_VC;

		[DebuggerNonUserCode]
		public string DName;

		[DebuggerNonUserCode]
		internal VoucherRow(DataRowBuilder rb);

		[DebuggerNonUserCode]
		public bool IsBankNameNull();

		[DebuggerNonUserCode]
		public bool IschkNumberNull();

		[DebuggerNonUserCode]
		public bool IsCodeNull();

		[DebuggerNonUserCode]
		public void SetBankNameNull();

		[DebuggerNonUserCode]
		public void SetchkNumberNull();

		[DebuggerNonUserCode]
		public void SetCodeNull();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class VoucherRowChangeEvent : EventArgs
	{
		private DataRowAction eventAction;

		private VoucherRow eventRow;

		[DebuggerNonUserCode]
		public DataRowAction Action;

		[DebuggerNonUserCode]
		public VoucherRow Row;

		[DebuggerNonUserCode]
		public VoucherRowChangeEvent(VoucherRow row, DataRowAction action);
	}

	public sealed class VoucherRowChangeEventHandler : MulticastDelegate
	{
		public VoucherRowChangeEventHandler(object object, IntPtr method);

		public virtual IAsyncResult BeginInvoke(object sender, VoucherRowChangeEvent e, AsyncCallback callback, object object);

		public virtual void EndInvoke(IAsyncResult result);

		public virtual void Invoke(object sender, VoucherRowChangeEvent e);
	}
}
}