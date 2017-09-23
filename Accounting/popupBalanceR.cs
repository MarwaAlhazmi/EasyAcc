using System.Windows.Forms;
using System;
using System.ComponentModel;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;
using Accounting.Code.Bll;
using CrystalDecisions.Shared;
using Accounting.Reports;
using System.Drawing;
using Accounting.Code.AccountingDSTableAdapters;

namespace Accounting
{
public class popupBalanceR : Form
{
	private Button btnCancel;

	private Button btnOK;

	internal bool category;

	private IContainer components;

	private ComboBox ddlAccounts;

	private DateTimePicker dtDate;

	internal Form form1;

	private Label label1;

	private Label label2;

	public popupBalanceR()
	{
		this.components = null;
		base();
		this.InitializeComponent();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		base.Close();
		base.Dispose();
	}

	private void btnOK_Click(object sender, EventArgs e)
	{
		BalanceReportDataTable balanceReportDataTable;
		ReportDocument reportDocument = new ReportDocument();
		reportDocument.Load(string.Concat(Path.GetDirectoryName(Application.ExecutablePath), "\\BalanceReportCR.rpt"));
		ReportBll reportBll = new ReportBll();
		DateTime @value = this.dtDate.Value;
		DateTime date = @value.Date;
		int selectedValue = (int)this.ddlAccounts.SelectedValue;
		string str = string.Concat(this.ddlAccounts.SelectedValue.ToString(), " | ", this.ddlAccounts.GetItemText(this.ddlAccounts.SelectedItem));
		if (this.category != 0)
		{
			balanceReportDataTable = reportBll.BalanceReportByCategory(selectedValue, date);
		}
		else
		{
			balanceReportDataTable = reportBll.BalanceReportByAccount(selectedValue, date);
		}
		reportDocument.SetDataSource(balanceReportDataTable);
		ParameterValues parameterValue1 = new ParameterValues();
		ParameterDiscreteValue parameterDiscreteValue1 = new ParameterDiscreteValue();
		parameterDiscreteValue1.set_Value(str);
		parameterValue1.Add(parameterDiscreteValue1);
		reportDocument.DataDefinition.ParameterFields["account"].ApplyCurrentValues(parameterValue1);
		ParameterValues parameterValue2 = new ParameterValues();
		ParameterDiscreteValue parameterDiscreteValue2 = new ParameterDiscreteValue();
		parameterDiscreteValue2.set_Value(date);
		parameterValue2.Add(parameterDiscreteValue2);
		reportDocument.DataDefinition.ParameterFields["dtTo"].ApplyCurrentValues(parameterValue2);
		ReportFrom reportFrom = new ReportFrom();
		reportFrom.crViewer.set_ReportSource(reportDocument);
		reportFrom.MdiParent = this.form1;
		reportFrom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		reportFrom.Dock = DockStyle.Fill;
		reportFrom.reportType = ReportType.None;
		reportFrom.Show();
		base.Close();
		base.Dispose();
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
		this.label1 = new Label();
		this.label2 = new Label();
		this.dtDate = new DateTimePicker();
		this.btnOK = new Button();
		this.btnCancel = new Button();
		this.ddlAccounts = new ComboBox();
		base.SuspendLayout();
		this.label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.label1.AutoSize = true;
		this.label1.ForeColor = SystemColors.ButtonFace;
		this.label1.Location = new Point(38, 30);
		this.label1.Name = "label1";
		this.label1.Size = new Size(44, 13);
		this.label1.TabIndex = 0;
		this.label1.Text = "الحساب";
		this.label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.label2.AutoSize = true;
		this.label2.ForeColor = SystemColors.ButtonFace;
		this.label2.Location = new Point(29, 72);
		this.label2.Name = "label2";
		this.label2.Size = new Size(53, 13);
		this.label2.TabIndex = 1;
		this.label2.Text = "حتى تاريخ";
		this.dtDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.dtDate.Location = new Point(104, 66);
		this.dtDate.Name = "dtDate";
		this.dtDate.RightToLeftLayout = true;
		this.dtDate.Size = new Size(165, 20);
		this.dtDate.TabIndex = 2;
		this.btnOK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.btnOK.BackColor = Color.FromArgb(150, 180, 200);
		this.btnOK.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.btnOK.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.btnOK.FlatStyle = FlatStyle.Flat;
		this.btnOK.Location = new Point(32, 122);
		this.btnOK.Name = "btnOK";
		this.btnOK.Size = new Size(62, 23);
		this.btnOK.TabIndex = 4;
		this.btnOK.Text = "موافق";
		this.btnOK.UseVisualStyleBackColor = false;
		this.btnOK.add_Click(new EventHandler(this.btnOK_Click));
		this.btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.btnCancel.BackColor = Color.FromArgb(150, 180, 200);
		this.btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.btnCancel.FlatStyle = FlatStyle.Flat;
		this.btnCancel.Location = new Point(207, 122);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new Size(62, 23);
		this.btnCancel.TabIndex = 5;
		this.btnCancel.Text = "إلغاء";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.add_Click(new EventHandler(this.btnCancel_Click));
		this.ddlAccounts.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.ddlAccounts.FormattingEnabled = true;
		this.ddlAccounts.Location = new Point(104, 27);
		this.ddlAccounts.Name = "ddlAccounts";
		this.ddlAccounts.Size = new Size(165, 21);
		this.ddlAccounts.TabIndex = 6;
		base.AutoScaleDimensions = new SizeF(6, 13);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.BackColor = SystemColors.ControlDarkDark;
		base.ClientSize = new Size(299, 158);
		base.Controls.Add(this.ddlAccounts);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnOK);
		base.Controls.Add(this.dtDate);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.Name = "popupBalanceR";
		base.RightToLeft = RightToLeft.Yes;
		base.RightToLeftLayout = true;
		base.Text = "كشف أرصدة";
		base.Load += new EventHandler(this.popupBalanceR_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void popupBalanceR_Load(object sender, EventArgs e)
	{
		if (this.category != 0)
		{
			CategoryDataTable data = new CategoryTableAdapter().GetData();
			this.ddlAccounts.DataSource = data;
			this.ddlAccounts.ValueMember = "Category_ID";
			this.ddlAccounts.DisplayMember = "Category_Name";
		}
		else
		{
			COA_TDataTable mainAccounts = new COA_TTableAdapter().GetMainAccounts();
			this.ddlAccounts.DataSource = mainAccounts;
			this.ddlAccounts.ValueMember = "GL_ID";
			this.ddlAccounts.DisplayMember = "GL_Name_VC";
		}
	}
}
}