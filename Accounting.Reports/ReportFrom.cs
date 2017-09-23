using System.Windows.Forms;
using Accounting.Code.Bll;
using System;
using System.ComponentModel;
using CrystalDecisions.Windows.Forms;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.IO;

namespace Accounting.Reports
{
public class ReportFrom : Form
{
	private ReportBll _reportBll;

	internal int account;

	private IContainer components;

	internal CrystalReportViewer crViewer;

	internal DateTime From;

	internal ReportType reportType;

	internal DateTime To;

	public ReportFrom()
	{
		this.components = null;
		base();
		this.InitializeComponent();
		this._reportBll = new ReportBll();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && this.components != null)
		{
			this.components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		this.crViewer = new CrystalReportViewer();
		base.SuspendLayout();
		this.crViewer.set_ActiveViewIndex(-1);
		this.crViewer.BorderStyle = BorderStyle.FixedSingle;
		this.crViewer.Dock = DockStyle.Fill;
		this.crViewer.Location = new Point(0, 0);
		this.crViewer.Name = "crViewer";
		this.crViewer.set_SelectionFormula("");
		this.crViewer.Size = new Size(558, 386);
		this.crViewer.TabIndex = 0;
		this.crViewer.set_ViewTimeSelectionFormula("");
		base.AutoScaleDimensions = new SizeF(6, 13);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(558, 386);
		base.Controls.Add(this.crViewer);
		base.FormBorderStyle = FormBorderStyle.Fixed3D;
		base.Name = "ReportFrom";
		base.RightToLeft = RightToLeft.Yes;
		base.RightToLeftLayout = true;
		base.ShowIcon = false;
		base.Text = "تقارير";
		base.Load += new EventHandler(this.TransactionsReportFrom_Load);
		base.ResumeLayout(false);
	}

	private void TransactionsReportFrom_Load(object sender, EventArgs e)
	{
		string str;
		ReportDocument reportDocument;
		ReportDataTable reportDataTable;
		ParameterValues parameterValue;
		ParameterDiscreteValue parameterDiscreteValue;
		ParameterValues parameterValue2;
		ParameterDiscreteValue parameterDiscreteValue2;
		ParameterValues parameterValue3;
		ParameterDiscreteValue parameterDiscreteValue3;
		ParameterValues parameterValue4;
		ParameterDiscreteValue parameterDiscreteValue4;
		ReportDocument reportDocument2;
		ParameterValues parameterValue5;
		ParameterDiscreteValue parameterDiscreteValue5;
		ParameterValues parameterValue6;
		ParameterDiscreteValue parameterDiscreteValue6;
		ReportDocument reportDocument3;
		ParameterValues parameterValue7;
		ParameterDiscreteValue parameterDiscreteValue7;
		ParameterValues parameterValue8;
		ParameterDiscreteValue parameterDiscreteValue8;
		ReportDocument reportDocument4;
		ParameterValues parameterValue9;
		ParameterDiscreteValue parameterDiscreteValue9;
		ParameterValues parameterValue10;
		ParameterDiscreteValue parameterDiscreteValue10;
		ReportDocument reportDocument5;
		AccountsViewDataTable accountsViewDataTable;
		ReportDocument reportDocument6;
		ReportDocument reportDocument7;
		ReportDocument reportDocument8;
		ParameterValues parameterValue11;
		ParameterDiscreteValue parameterDiscreteValue11;
		ParameterValues parameterValue12;
		ParameterDiscreteValue parameterDiscreteValue12;
		AccountsBLL accountsBLL = new AccountsBLL();
		Cursor.Current = Cursors.WaitCursor;
		base.WindowState = FormWindowState.Maximized;
		switch (this.reportType)
		{
			case ReportType.TrialBalance:
			{
				this.set_Text("ميزان المراجعة");
				reportDocument3 = new ReportDocument();
				reportDocument3.Load(string.Concat(Path.GetDirectoryName(Application.ExecutablePath), "\\TrialBalanceCR.rpt"));
				reportDocument3.SetDataSource(this._reportBll.getTrialBalance(this.From, this.To));
				parameterValue7 = new ParameterValues();
				parameterDiscreteValue7 = new ParameterDiscreteValue();
				parameterDiscreteValue7.set_Value(this.From);
				parameterValue7.Add(parameterDiscreteValue7);
				reportDocument3.DataDefinition.ParameterFields["from"].ApplyCurrentValues(parameterValue7);
				parameterValue8 = new ParameterValues();
				parameterDiscreteValue8 = new ParameterDiscreteValue();
				parameterDiscreteValue8.set_Value(this.To);
				parameterValue8.Add(parameterDiscreteValue8);
				reportDocument3.DataDefinition.ParameterFields["to"].ApplyCurrentValues(parameterValue8);
				this.crViewer.set_ReportSource(reportDocument3);
			}
			case ReportType.BalanceSheet:
			{
				this.set_Text("الميزانية العمومية");
				reportDocument4 = new ReportDocument();
				reportDocument4.Load(string.Concat(Path.GetDirectoryName(Application.ExecutablePath), "\\BalanceSheetCR.rpt"));
				reportDocument4.SetDataSource(this._reportBll.getBalanceSheet(this.From, this.To));
				parameterValue9 = new ParameterValues();
				parameterDiscreteValue9 = new ParameterDiscreteValue();
				parameterDiscreteValue9.set_Value(this.From);
				parameterValue9.Add(parameterDiscreteValue9);
				reportDocument4.DataDefinition.ParameterFields["from"].ApplyCurrentValues(parameterValue9);
				parameterValue10 = new ParameterValues();
				parameterDiscreteValue10 = new ParameterDiscreteValue();
				parameterDiscreteValue10.set_Value(this.To);
				parameterValue10.Add(parameterDiscreteValue10);
				reportDocument4.DataDefinition.ParameterFields["to"].ApplyCurrentValues(parameterValue10);
				this.crViewer.set_ReportSource(reportDocument4);
			}
			case ReportType.Transactions:
			{
				this.set_Text("كشف حركة حساب");
				str = accountsBLL.GetAccountByID(this.account)[0].GL_Name_VC;
				reportDocument = new ReportDocument();
				reportDocument.Load(string.Concat(Path.GetDirectoryName(Application.ExecutablePath), "\\reportTest.rpt"));
				reportDataTable = this._reportBll.getByCodeDate(this.From, this.To, this.account);
				reportDocument.SetDataSource(reportDataTable);
				parameterValue = new ParameterValues();
				parameterDiscreteValue = new ParameterDiscreteValue();
				parameterDiscreteValue.set_Value(str);
				parameterValue.Add(parameterDiscreteValue);
				reportDocument.DataDefinition.ParameterFields["account"].ApplyCurrentValues(parameterValue);
				parameterValue2 = new ParameterValues();
				parameterDiscreteValue2 = new ParameterDiscreteValue();
				parameterDiscreteValue2.set_Value(this.From);
				parameterValue2.Add(parameterDiscreteValue2);
				reportDocument.DataDefinition.ParameterFields["dtFrom"].ApplyCurrentValues(parameterValue2);
				parameterValue3 = new ParameterValues();
				parameterDiscreteValue3 = new ParameterDiscreteValue();
				parameterDiscreteValue3.set_Value(this.To);
				parameterValue3.Add(parameterDiscreteValue3);
				reportDocument.DataDefinition.ParameterFields["dtTo"].ApplyCurrentValues(parameterValue3);
				parameterValue4 = new ParameterValues();
				parameterDiscreteValue4 = new ParameterDiscreteValue();
				parameterDiscreteValue4.set_Value(reportDataTable[reportDataTable.Count - 1].Balance);
				parameterValue4.Add(parameterDiscreteValue4);
				reportDocument.DataDefinition.ParameterFields["tBalance"].ApplyCurrentValues(parameterValue4);
				this.crViewer.set_ReportSource(reportDocument);
			}
			case ReportType.ProfitAndLoss:
			{
				this.set_Text("بيان الأرباح والخسائر");
				reportDocument2 = new ReportDocument();
				reportDocument2.Load(string.Concat(Path.GetDirectoryName(Application.ExecutablePath), "\\ProfitLossCR.rpt"));
				reportDocument2.SetDataSource(this._reportBll.getProfitAndLoss(this.From, this.To));
				parameterValue5 = new ParameterValues();
				parameterDiscreteValue5 = new ParameterDiscreteValue();
				parameterDiscreteValue5.set_Value(this.From);
				parameterValue5.Add(parameterDiscreteValue5);
				reportDocument2.DataDefinition.ParameterFields["from"].ApplyCurrentValues(parameterValue5);
				parameterValue6 = new ParameterValues();
				parameterDiscreteValue6 = new ParameterDiscreteValue();
				parameterDiscreteValue6.set_Value(this.To);
				parameterValue6.Add(parameterDiscreteValue6);
				reportDocument2.DataDefinition.ParameterFields["to"].ApplyCurrentValues(parameterValue6);
				this.crViewer.set_ReportSource(reportDocument2);
			}
			case ReportType.Accounts:
			{
				this.set_Text("كشف أرصدة مجموعة حسابات");
				reportDocument5 = new ReportDocument();
				reportDocument5.Load(string.Concat(Path.GetDirectoryName(Application.ExecutablePath), "\\AccountsCR.rpt"));
				accountsViewDataTable = new AccountsBLL().GetAccountsView();
				reportDocument5.SetDataSource(accountsViewDataTable);
				this.crViewer.set_ReportSource(reportDocument5);
				this.set_Text("الموظفون");
				reportDocument6 = new ReportDocument();
				reportDocument6.Load(string.Concat(Path.GetDirectoryName(Application.ExecutablePath), "\\EmployeeCR.rpt"));
				reportDocument6.SetDataSource(new EmployeeBll().getEmployee());
				this.crViewer.set_ReportSource(reportDocument6);
				this.set_Text("الموردون");
				reportDocument7 = new ReportDocument();
				reportDocument7.Load(string.Concat(Path.GetDirectoryName(Application.ExecutablePath), "\\SupplierCR.rpt"));
				reportDocument7.SetDataSource(new SupplierBll().getSuppliers());
				this.crViewer.set_ReportSource(reportDocument7);
				this.set_Text("مجمع الإهلاك");
				reportDocument8 = new ReportDocument();
				reportDocument8.Load(string.Concat(Path.GetDirectoryName(Application.ExecutablePath), "\\fixedCR.rpt"));
				reportDocument8.SetDataSource(this._reportBll.FixedAssetsReport(this.From, this.To));
				parameterValue11 = new ParameterValues();
				parameterDiscreteValue11 = new ParameterDiscreteValue();
				parameterDiscreteValue11.set_Value(this.From);
				parameterValue11.Add(parameterDiscreteValue11);
				reportDocument8.DataDefinition.ParameterFields["from"].ApplyCurrentValues(parameterValue11);
				parameterValue12 = new ParameterValues();
				parameterDiscreteValue12 = new ParameterDiscreteValue();
				parameterDiscreteValue12.set_Value(this.To);
				parameterValue12.Add(parameterDiscreteValue12);
				reportDocument8.DataDefinition.ParameterFields["to"].ApplyCurrentValues(parameterValue12);
				this.crViewer.set_ReportSource(reportDocument8);
				goto ;
			}
			case ReportType.None:
			{
				this.set_Cursor(Cursors.Default);
				return;
			}
		}
	}
}
}