using System.Windows.Forms;
using System.ComponentModel;
using System;
using Accounting.Client;
using Accounting.Vouchers;
using Accounting.Employee;
using Accounting.Journal;
using Accounting.Supplier;
using System.Drawing;
using Accounting.Properties;
using Accounting.Code.Bll;

namespace Accounting
{
public class MainForm : Form
{
	private Button btnAccountMain;

	private Button btnAccounts;

	private Button btnBalance;

	private Button btnClients;

	private Button btnDeposit;

	private Button btnEmployees;

	private Button btnJournal;

	private Button btnProfit;

	private Button btnReports;

	private Button btnSuppliers;

	private Button btnTrans;

	private Button btnTrial;

	private Button btnVouchers;

	private Button btnWith;

	private IContainer components;

	private Panel panel1;

	private Panel pnlAccounts;

	private Panel pnlReports;

	private Panel pnlVouchers;

	public MainForm()
	{
		this.components = null;
		base();
		this.InitializeComponent();
	}

	private void btnAccounts_Click(object sender, EventArgs e)
	{
		this.deleteSubs();
		AccountsForm accountsForm = new AccountsForm();
		accountsForm.MdiParent = (Form1)this.MdiParent;
		accountsForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		accountsForm.Dock = DockStyle.Fill;
		accountsForm.Show();
	}

	private void btnBalance_Click(object sender, EventArgs e)
	{
		popupSearch _popupSearch = new popupSearch();
		_popupSearch.reportType = ReportType.BalanceSheet;
		_popupSearch._form1 = (Form1)base.MdiParent;
		_popupSearch.Show();
	}

	private void btnClients_Click(object sender, EventArgs e)
	{
		this.deleteSubs();
		ClientForm clientForm = new ClientForm();
		clientForm.MdiParent = (Form1)this.MdiParent;
		clientForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		clientForm.Dock = DockStyle.Fill;
		clientForm.Show();
	}

	private void btnDeposit_Click(object sender, EventArgs e)
	{
		this.deleteSubs();
		DepositForm depositForm = new DepositForm();
		depositForm.MdiParent = (Form1)this.MdiParent;
		depositForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		depositForm.Dock = DockStyle.Fill;
		depositForm.Show();
	}

	private void btnEmployees_Click(object sender, EventArgs e)
	{
		this.deleteSubs();
		EmployeeForm employeeForm = new EmployeeForm();
		employeeForm.MdiParent = (Form1)this.MdiParent;
		employeeForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		employeeForm.Dock = DockStyle.Fill;
		employeeForm.Show();
	}

	private void btnJournal_Click(object sender, EventArgs e)
	{
		this.deleteSubs();
		JournalForm journalForm = new JournalForm();
		journalForm.MdiParent = (Form1)this.MdiParent;
		journalForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		journalForm.Dock = DockStyle.Fill;
		journalForm.Show();
	}

	private void btnProfit_Click(object sender, EventArgs e)
	{
		popupSearch _popupSearch = new popupSearch();
		_popupSearch.reportType = ReportType.ProfitAndLoss;
		_popupSearch._form1 = (Form1)base.MdiParent;
		_popupSearch.Show();
	}

	private void btnSuppliers_Click(object sender, EventArgs e)
	{
		this.deleteSubs();
		SupplierForm supplierForm = new SupplierForm();
		supplierForm.MdiParent = (Form1)this.MdiParent;
		supplierForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		supplierForm.Dock = DockStyle.Fill;
		supplierForm.Show();
	}

	private void btnTrans_Click(object sender, EventArgs e)
	{
		popupSearch _popupSearch = new popupSearch();
		_popupSearch.reportType = ReportType.Transactions;
		_popupSearch._form1 = (Form1)base.MdiParent;
		_popupSearch.Show();
	}

	private void btnTrial_Click(object sender, EventArgs e)
	{
		popupSearch _popupSearch = new popupSearch();
		_popupSearch.reportType = ReportType.TrialBalance;
		_popupSearch._form1 = (Form1)base.MdiParent;
		_popupSearch.Show();
	}

	private void btnWith_Click(object sender, EventArgs e)
	{
		this.deleteSubs();
		WithdrawalForm withdrawalForm = new WithdrawalForm();
		withdrawalForm.MdiParent = (Form1)this.MdiParent;
		withdrawalForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		withdrawalForm.Dock = DockStyle.Fill;
		withdrawalForm.Show();
	}

	private void deleteSubs()
	{
		Form[] mdiChildren = base.MdiChildren;
		foreach (Form mdiChild in mdiChildren)
		{
			mdiChild.Close();
			mdiChild.Dispose();
		}
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
		this.pnlVouchers = new Panel();
		this.btnJournal = new Button();
		this.btnWith = new Button();
		this.btnDeposit = new Button();
		this.btnVouchers = new Button();
		this.pnlReports = new Panel();
		this.btnProfit = new Button();
		this.btnBalance = new Button();
		this.btnTrial = new Button();
		this.btnTrans = new Button();
		this.btnReports = new Button();
		this.pnlAccounts = new Panel();
		this.btnEmployees = new Button();
		this.btnSuppliers = new Button();
		this.btnAccounts = new Button();
		this.btnAccountMain = new Button();
		this.panel1 = new Panel();
		this.btnClients = new Button();
		this.pnlVouchers.SuspendLayout();
		this.pnlReports.SuspendLayout();
		this.pnlAccounts.SuspendLayout();
		this.panel1.SuspendLayout();
		base.SuspendLayout();
		this.pnlVouchers.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.pnlVouchers.BackColor = Color.FromArgb(150, 180, 200);
		this.pnlVouchers.Controls.Add(this.btnJournal);
		this.pnlVouchers.Controls.Add(this.btnWith);
		this.pnlVouchers.Controls.Add(this.btnDeposit);
		this.pnlVouchers.Controls.Add(this.btnVouchers);
		this.pnlVouchers.Location = new Point(466, 12);
		this.pnlVouchers.Name = "pnlVouchers";
		this.pnlVouchers.Size = new Size(160, 212);
		this.pnlVouchers.TabIndex = 1;
		this.btnJournal.FlatAppearance.BorderColor = SystemColors.ButtonFace;
		this.btnJournal.FlatStyle = FlatStyle.Flat;
		this.btnJournal.Location = new Point(30, 175);
		this.btnJournal.Name = "btnJournal";
		this.btnJournal.Size = new Size(104, 23);
		this.btnJournal.TabIndex = 3;
		this.btnJournal.Text = "قيود اليومية";
		this.btnJournal.UseVisualStyleBackColor = true;
		this.btnJournal.add_Click(new EventHandler(this.btnJournal_Click));
		this.btnWith.FlatAppearance.BorderColor = SystemColors.ButtonFace;
		this.btnWith.FlatStyle = FlatStyle.Flat;
		this.btnWith.Location = new Point(30, 131);
		this.btnWith.Name = "btnWith";
		this.btnWith.Size = new Size(104, 23);
		this.btnWith.TabIndex = 2;
		this.btnWith.Text = "سند صرف";
		this.btnWith.UseVisualStyleBackColor = true;
		this.btnWith.add_Click(new EventHandler(this.btnWith_Click));
		this.btnDeposit.FlatAppearance.BorderColor = SystemColors.ButtonFace;
		this.btnDeposit.FlatStyle = FlatStyle.Flat;
		this.btnDeposit.Location = new Point(30, 88);
		this.btnDeposit.Name = "btnDeposit";
		this.btnDeposit.Size = new Size(104, 23);
		this.btnDeposit.TabIndex = 1;
		this.btnDeposit.Text = "سند قبض";
		this.btnDeposit.UseVisualStyleBackColor = true;
		this.btnDeposit.add_Click(new EventHandler(this.btnDeposit_Click));
		this.btnVouchers.BackColor = SystemColors.Control;
		this.btnVouchers.Dock = DockStyle.Top;
		this.btnVouchers.FlatStyle = FlatStyle.Flat;
		this.btnVouchers.Font = new Font("Tahoma", 11.25, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.btnVouchers.Image = Resources.Calculator2;
		this.btnVouchers.Location = new Point(0, 0);
		this.btnVouchers.Name = "btnVouchers";
		this.btnVouchers.Size = new Size(160, 71);
		this.btnVouchers.TabIndex = 0;
		this.btnVouchers.Text = "السندات";
		this.btnVouchers.TextImageRelation = TextImageRelation.ImageBeforeText;
		this.btnVouchers.UseVisualStyleBackColor = false;
		this.pnlReports.Anchor = AnchorStyles.Top;
		this.pnlReports.BackColor = Color.FromArgb(150, 180, 200);
		this.pnlReports.Controls.Add(this.btnProfit);
		this.pnlReports.Controls.Add(this.btnBalance);
		this.pnlReports.Controls.Add(this.btnTrial);
		this.pnlReports.Controls.Add(this.btnTrans);
		this.pnlReports.Controls.Add(this.btnReports);
		this.pnlReports.Location = new Point(248, 12);
		this.pnlReports.Name = "pnlReports";
		this.pnlReports.Size = new Size(179, 212);
		this.pnlReports.TabIndex = 2;
		this.btnProfit.FlatAppearance.BorderColor = SystemColors.ButtonFace;
		this.btnProfit.FlatStyle = FlatStyle.Flat;
		this.btnProfit.Location = new Point(31, 175);
		this.btnProfit.Name = "btnProfit";
		this.btnProfit.Size = new Size(116, 23);
		this.btnProfit.TabIndex = 5;
		this.btnProfit.Text = "بيان الأرباح والخسائر";
		this.btnProfit.UseVisualStyleBackColor = true;
		this.btnProfit.add_Click(new EventHandler(this.btnProfit_Click));
		this.btnBalance.FlatAppearance.BorderColor = SystemColors.ButtonFace;
		this.btnBalance.FlatStyle = FlatStyle.Flat;
		this.btnBalance.Location = new Point(31, 146);
		this.btnBalance.Name = "btnBalance";
		this.btnBalance.Size = new Size(116, 23);
		this.btnBalance.TabIndex = 4;
		this.btnBalance.Text = "الميزانية العمومية";
		this.btnBalance.UseVisualStyleBackColor = true;
		this.btnBalance.add_Click(new EventHandler(this.btnBalance_Click));
		this.btnTrial.FlatAppearance.BorderColor = SystemColors.ButtonFace;
		this.btnTrial.FlatStyle = FlatStyle.Flat;
		this.btnTrial.Location = new Point(31, 117);
		this.btnTrial.Name = "btnTrial";
		this.btnTrial.Size = new Size(116, 23);
		this.btnTrial.TabIndex = 3;
		this.btnTrial.Text = "ميزان مراجعة";
		this.btnTrial.UseVisualStyleBackColor = true;
		this.btnTrial.add_Click(new EventHandler(this.btnTrial_Click));
		this.btnTrans.FlatAppearance.BorderColor = SystemColors.ButtonFace;
		this.btnTrans.FlatStyle = FlatStyle.Flat;
		this.btnTrans.Location = new Point(31, 88);
		this.btnTrans.Name = "btnTrans";
		this.btnTrans.Size = new Size(116, 23);
		this.btnTrans.TabIndex = 2;
		this.btnTrans.Text = "كشف حركة حساب";
		this.btnTrans.UseVisualStyleBackColor = true;
		this.btnTrans.add_Click(new EventHandler(this.btnTrans_Click));
		this.btnReports.BackColor = SystemColors.Control;
		this.btnReports.Dock = DockStyle.Top;
		this.btnReports.FlatStyle = FlatStyle.Flat;
		this.btnReports.Font = new Font("Tahoma", 11.25, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.btnReports.Image = Resources.NotesALT;
		this.btnReports.Location = new Point(0, 0);
		this.btnReports.Name = "btnReports";
		this.btnReports.Size = new Size(179, 71);
		this.btnReports.TabIndex = 0;
		this.btnReports.Text = "التقارير";
		this.btnReports.TextImageRelation = TextImageRelation.ImageBeforeText;
		this.btnReports.UseVisualStyleBackColor = false;
		this.pnlAccounts.BackColor = Color.FromArgb(150, 180, 200);
		this.pnlAccounts.Controls.Add(this.btnClients);
		this.pnlAccounts.Controls.Add(this.btnEmployees);
		this.pnlAccounts.Controls.Add(this.btnSuppliers);
		this.pnlAccounts.Controls.Add(this.btnAccounts);
		this.pnlAccounts.Controls.Add(this.btnAccountMain);
		this.pnlAccounts.Location = new Point(38, 12);
		this.pnlAccounts.Name = "pnlAccounts";
		this.pnlAccounts.Size = new Size(179, 212);
		this.pnlAccounts.TabIndex = 3;
		this.btnEmployees.FlatAppearance.BorderColor = SystemColors.ButtonFace;
		this.btnEmployees.FlatStyle = FlatStyle.Flat;
		this.btnEmployees.Location = new Point(32, 146);
		this.btnEmployees.Name = "btnEmployees";
		this.btnEmployees.Size = new Size(116, 23);
		this.btnEmployees.TabIndex = 5;
		this.btnEmployees.Text = "الموظفون";
		this.btnEmployees.UseVisualStyleBackColor = true;
		this.btnEmployees.add_Click(new EventHandler(this.btnEmployees_Click));
		this.btnSuppliers.FlatAppearance.BorderColor = SystemColors.ButtonFace;
		this.btnSuppliers.FlatStyle = FlatStyle.Flat;
		this.btnSuppliers.Location = new Point(32, 117);
		this.btnSuppliers.Name = "btnSuppliers";
		this.btnSuppliers.Size = new Size(116, 23);
		this.btnSuppliers.TabIndex = 4;
		this.btnSuppliers.Text = "الموردون";
		this.btnSuppliers.UseVisualStyleBackColor = true;
		this.btnSuppliers.add_Click(new EventHandler(this.btnSuppliers_Click));
		this.btnAccounts.FlatAppearance.BorderColor = SystemColors.ButtonFace;
		this.btnAccounts.FlatStyle = FlatStyle.Flat;
		this.btnAccounts.Location = new Point(32, 88);
		this.btnAccounts.Name = "btnAccounts";
		this.btnAccounts.Size = new Size(116, 23);
		this.btnAccounts.TabIndex = 3;
		this.btnAccounts.Text = "عرض الحسابات";
		this.btnAccounts.UseVisualStyleBackColor = true;
		this.btnAccounts.add_Click(new EventHandler(this.btnAccounts_Click));
		this.btnAccountMain.BackColor = SystemColors.Control;
		this.btnAccountMain.Dock = DockStyle.Top;
		this.btnAccountMain.FlatStyle = FlatStyle.Flat;
		this.btnAccountMain.Font = new Font("Tahoma", 11.25, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.btnAccountMain.Image = Resources.Contacts;
		this.btnAccountMain.Location = new Point(0, 0);
		this.btnAccountMain.Name = "btnAccountMain";
		this.btnAccountMain.Size = new Size(179, 71);
		this.btnAccountMain.TabIndex = 0;
		this.btnAccountMain.Text = "الحسابات";
		this.btnAccountMain.TextImageRelation = TextImageRelation.ImageBeforeText;
		this.btnAccountMain.UseVisualStyleBackColor = false;
		this.panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
		this.panel1.Controls.Add(this.pnlAccounts);
		this.panel1.Controls.Add(this.pnlVouchers);
		this.panel1.Controls.Add(this.pnlReports);
		this.panel1.Location = new Point(24, 127);
		this.panel1.Name = "panel1";
		this.panel1.Size = new Size(689, 240);
		this.panel1.TabIndex = 4;
		this.btnClients.FlatAppearance.BorderColor = SystemColors.ButtonFace;
		this.btnClients.FlatStyle = FlatStyle.Flat;
		this.btnClients.Location = new Point(32, 175);
		this.btnClients.Name = "btnClients";
		this.btnClients.Size = new Size(116, 23);
		this.btnClients.TabIndex = 6;
		this.btnClients.Text = "العملاء";
		this.btnClients.UseVisualStyleBackColor = true;
		this.btnClients.add_Click(new EventHandler(this.btnClients_Click));
		base.AutoScaleDimensions = new SizeF(6, 13);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.BackColor = SystemColors.ControlDarkDark;
		base.ClientSize = new Size(746, 379);
		base.Controls.Add(this.panel1);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "MainForm";
		base.ShowIcon = false;
		base.Load += new EventHandler(this.MainForm_Load);
		this.pnlVouchers.ResumeLayout(false);
		this.pnlReports.ResumeLayout(false);
		this.pnlAccounts.ResumeLayout(false);
		this.panel1.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void MainForm_Load(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty((Form1)base.MdiParent.UserName))
		{
			this.resetUI((Form1)base.MdiParent.UserName);
		}
	}

	internal void resetUI(string username)
	{
		Right right1 = SecBll.getRight(username);
		Right right2 = right1;
		if (right2 == Right.ReadOnly)
		{
			this.btnDeposit.Enabled = false;
			this.btnWith.Enabled = false;
			goto L_002c;
		}
	L_002c:
	}
}
}