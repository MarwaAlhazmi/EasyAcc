using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Printing;
using System;
using System.Drawing;
using Accounting.Singin;
using System.Collections.Generic;
using Accounting.Properties;
using Accounting.Code.Bll;
using Accounting.Client;
using Accounting.Vouchers;
using Accounting.Employee;
using Accounting.Journal;
using Accounting.Reports;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;
using CrystalDecisions.Shared;
using Accounting.Supplier;

namespace Accounting
{
public class Form1 : Form
{
	private AccountsForm cc;

	private IContainer components;

	internal MenuStrip menuStrip1;

	private ToolStripMenuItem mtsAbout;

	private ToolStripMenuItem mtsAccounts;

	internal ToolStripMenuItem mtsFile;

	private ToolStripMenuItem mtsReports;

	private ToolStripMenuItem mtsVouchers;

	private PrintDocument printDocument1;

	internal PrintPreviewDialog printPreviewDialog1;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripSeparator toolStripSeparator2;

	private ToolStripSeparator toolStripSeparator3;

	private ToolStripSeparator toolStripSeparator4;

	private ToolStripSeparator toolStripSeparator5;

	private ToolStripSeparator toolStripSeparator6;

	private ToolStripSeparator toolStripSeparator7;

	private ToolStripSeparator toolStripSeparator8;

	private ToolStripSeparator toolStripSeparator9;

	private ToolStripMenuItem tsAccountBalance;

	private ToolStripMenuItem tsAccounts;

	private ToolStripMenuItem tsBalanceSheet;

	private ToolStripMenuItem tsCategory;

	private ToolStripMenuItem tsClients;

	internal ToolStripMenuItem tsClose;

	private ToolStripMenuItem tsDeposit;

	private ToolStripMenuItem tsEmployees;

	private ToolStripMenuItem tsExit;

	private ToolStripMenuItem tsFixedAsset;

	private ToolStripMenuItem tsJournal;

	private ToolStripMenuItem tsMainForm;

	private ToolStripMenuItem tsMemebers;

	internal ToolStripMenuItem tsPreview;

	internal ToolStripMenuItem tsPrint;

	private ToolStripMenuItem tsProfitAndLoss;

	internal ToolStripMenuItem tsSignin;

	internal ToolStripMenuItem tsSignout;

	private ToolStripMenuItem tsSubAccount;

	private ToolStripMenuItem tsSuppliers;

	private ToolStripMenuItem tsTransactionReport;

	private ToolStripMenuItem tsTrialBalance;

	private ToolStripMenuItem tsWithdrawal;

	internal string UserName;

	public Form1()
	{
		this.components = null;
		base();
		this.InitializeComponent();
		Rectangle workingArea = SystemInformation.WorkingArea.MaximumSize = workingArea.Size;
		workingArea = SystemInformation.WorkingArea.MinimumSize = workingArea.Size;
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

	private void Form1_Load(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Maximized;
		MainForm mainForm = new MainForm();
		mainForm.MdiParent = this;
		mainForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		mainForm.Dock = DockStyle.Fill;
		mainForm.Show();
		this.InitialStatus(false);
		SigninForm signinForm = new SigninForm();
		signinForm._form1 = this;
		signinForm.Show();
	}

	private void Form1_MdiChildActivate(object sender, EventArgs e)
	{
		int num = 0;
		if (base.ActiveMdiChild != null)
		{
			string name = base.ActiveMdiChild.Name;
			if (name != null)
			{
				if (<PrivateImplementationDetails>{872C86BB-7B68-47C8-8D6E-5871256AF993}.$$method0x6000865-1 == null)
				{
					<PrivateImplementationDetails>{872C86BB-7B68-47C8-8D6E-5871256AF993}.$$method0x6000865-1 = new Dictionary<string, int>(7).Add("EmployeeForm", 0).Add("SupplierForm", 1).Add("AccountsForm", 2).Add("JournalForm", 3).Add("DepositForm", 4).Add("WithdrawalForm", 5).Add("ReportFrom", 6);
				}
				if (<PrivateImplementationDetails>{872C86BB-7B68-47C8-8D6E-5871256AF993}.$$method0x6000865-1.TryGetValue(name, ref num))
				{
					switch (num)
					{
						case 5:
						{
							this.tsClose.set_Enabled(true);
							this.tsPreview.set_Enabled(true);
							this.tsPrint.set_Enabled(true);
							break;
						}
						case 6:
						{
							this.tsClose.set_Enabled(true);
							this.tsPrint.set_Enabled(true);
							break;
						}
					}
				}
			}
			break;
		}
		this.tsClose.Enabled = false;
		this.tsPreview.Enabled = false;
		this.tsPrint.Enabled = false;
	}

	private void InitializeComponent()
	{
		ToolStripItem[] toolStripItemArray;
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		this.menuStrip1 = new MenuStrip();
		this.mtsFile = new ToolStripMenuItem();
		this.tsMainForm = new ToolStripMenuItem();
		this.toolStripSeparator9 = new ToolStripSeparator();
		this.tsPreview = new ToolStripMenuItem();
		this.tsPrint = new ToolStripMenuItem();
		this.toolStripSeparator7 = new ToolStripSeparator();
		this.tsClose = new ToolStripMenuItem();
		this.toolStripSeparator2 = new ToolStripSeparator();
		this.tsSignin = new ToolStripMenuItem();
		this.tsSignout = new ToolStripMenuItem();
		this.tsMemebers = new ToolStripMenuItem();
		this.toolStripSeparator6 = new ToolStripSeparator();
		this.tsExit = new ToolStripMenuItem();
		this.mtsVouchers = new ToolStripMenuItem();
		this.tsDeposit = new ToolStripMenuItem();
		this.tsWithdrawal = new ToolStripMenuItem();
		this.toolStripSeparator1 = new ToolStripSeparator();
		this.tsJournal = new ToolStripMenuItem();
		this.mtsReports = new ToolStripMenuItem();
		this.tsTransactionReport = new ToolStripMenuItem();
		this.tsAccountBalance = new ToolStripMenuItem();
		this.tsCategory = new ToolStripMenuItem();
		this.tsSubAccount = new ToolStripMenuItem();
		this.toolStripSeparator3 = new ToolStripSeparator();
		this.tsTrialBalance = new ToolStripMenuItem();
		this.tsBalanceSheet = new ToolStripMenuItem();
		this.toolStripSeparator4 = new ToolStripSeparator();
		this.tsProfitAndLoss = new ToolStripMenuItem();
		this.toolStripSeparator8 = new ToolStripSeparator();
		this.tsFixedAsset = new ToolStripMenuItem();
		this.mtsAccounts = new ToolStripMenuItem();
		this.tsAccounts = new ToolStripMenuItem();
		this.toolStripSeparator5 = new ToolStripSeparator();
		this.tsSuppliers = new ToolStripMenuItem();
		this.tsEmployees = new ToolStripMenuItem();
		this.tsClients = new ToolStripMenuItem();
		this.mtsAbout = new ToolStripMenuItem();
		this.printDocument1 = new PrintDocument();
		this.printPreviewDialog1 = new PrintPreviewDialog();
		this.menuStrip1.SuspendLayout();
		base.SuspendLayout();
		this.menuStrip1.BackColor = Color.FromArgb(0, 64, 90);
		this.menuStrip1.Items.AddRange(new ToolStripItem[] { this.mtsFile, this.mtsVouchers, this.mtsReports, this.mtsAccounts, this.mtsAbout });
		this.menuStrip1.Location = new Point(0, 0);
		this.menuStrip1.Name = "menuStrip1";
		this.menuStrip1.Size = new Size(697, 24);
		this.menuStrip1.TabIndex = 0;
		this.menuStrip1.Text = "menuStrip1";
		this.mtsFile.BackColor = Color.FromArgb(0, 64, 80);
		this.mtsFile.DropDownItems.AddRange(new ToolStripItem[] { this.tsMainForm, this.toolStripSeparator9, this.tsPreview, this.tsPrint, this.toolStripSeparator7, this.tsClose, this.toolStripSeparator2, this.tsSignin, this.tsSignout, this.tsMemebers, this.toolStripSeparator6, this.tsExit });
		this.mtsFile.ForeColor = Color.LightSlateGray;
		this.mtsFile.Name = "mtsFile";
		this.mtsFile.Size = new Size(36, 20);
		this.mtsFile.Text = "ملف";
		this.tsMainForm.Name = "tsMainForm";
		this.tsMainForm.Size = new Size(190, 22);
		this.tsMainForm.Text = "الصفحة الرئيسية";
		this.tsMainForm.add_Click(new EventHandler(this.tsMainForm_Click));
		this.toolStripSeparator9.Name = "toolStripSeparator9";
		this.toolStripSeparator9.Size = new Size(187, 6);
		this.tsPreview.BackColor = SystemColors.Control;
		this.tsPreview.Enabled = false;
		this.tsPreview.Image = Resources.PrintPreview;
		this.tsPreview.Name = "tsPreview";
		this.tsPreview.Size = new Size(190, 22);
		this.tsPreview.Text = "معاينة قبل الطباعة";
		this.tsPreview.add_Click(new EventHandler(this.tsPreview_Click));
		this.tsPrint.BackColor = SystemColors.Control;
		this.tsPrint.Enabled = false;
		this.tsPrint.Image = Resources.Print;
		this.tsPrint.Name = "tsPrint";
		this.tsPrint.Size = new Size(190, 22);
		this.tsPrint.Text = "طباعة";
		this.tsPrint.add_Click(new EventHandler(this.tsPrint_Click));
		this.toolStripSeparator7.BackColor = SystemColors.Control;
		this.toolStripSeparator7.Name = "toolStripSeparator7";
		this.toolStripSeparator7.Size = new Size(187, 6);
		this.tsClose.BackColor = SystemColors.Control;
		this.tsClose.Enabled = false;
		this.tsClose.Image = Resources.Delete;
		this.tsClose.Name = "tsClose";
		this.tsClose.Size = new Size(190, 22);
		this.tsClose.Text = "إغلاق";
		this.tsClose.add_Click(new EventHandler(this.tsClose_Click));
		this.toolStripSeparator2.BackColor = SystemColors.Control;
		this.toolStripSeparator2.Name = "toolStripSeparator2";
		this.toolStripSeparator2.Size = new Size(187, 6);
		this.tsSignin.BackColor = SystemColors.Control;
		this.tsSignin.Name = "tsSignin";
		this.tsSignin.Size = new Size(190, 22);
		this.tsSignin.Text = "تسجيل دخول";
		this.tsSignin.add_Click(new EventHandler(this.tsSignin_Click));
		this.tsSignout.BackColor = SystemColors.Control;
		this.tsSignout.Enabled = false;
		this.tsSignout.Name = "tsSignout";
		this.tsSignout.Size = new Size(190, 22);
		this.tsSignout.Text = "تسجيل خروج";
		this.tsSignout.add_Click(new EventHandler(this.tsSignout_Click));
		this.tsMemebers.Name = "tsMemebers";
		this.tsMemebers.Size = new Size(190, 22);
		this.tsMemebers.Text = "إدارة حسابات المستخدمين";
		this.tsMemebers.Visible = false;
		this.tsMemebers.add_Click(new EventHandler(this.tsMemebers_Click));
		this.toolStripSeparator6.BackColor = SystemColors.Control;
		this.toolStripSeparator6.Name = "toolStripSeparator6";
		this.toolStripSeparator6.Size = new Size(187, 6);
		this.tsExit.BackColor = SystemColors.Control;
		this.tsExit.Name = "tsExit";
		this.tsExit.Size = new Size(190, 22);
		this.tsExit.Text = "خروج";
		this.tsExit.add_Click(new EventHandler(this.tsExit_Click));
		this.mtsVouchers.DropDownItems.AddRange(new ToolStripItem[] { this.tsDeposit, this.tsWithdrawal, this.toolStripSeparator1, this.tsJournal });
		this.mtsVouchers.ForeColor = Color.LightSlateGray;
		this.mtsVouchers.Name = "mtsVouchers";
		this.mtsVouchers.Size = new Size(48, 20);
		this.mtsVouchers.Text = "سندات";
		this.tsDeposit.Image = Resources.Deposit;
		this.tsDeposit.Name = "tsDeposit";
		this.tsDeposit.Size = new Size(125, 22);
		this.tsDeposit.Text = "سند قبض";
		this.tsDeposit.add_Click(new EventHandler(this.tsDeposit_Click));
		this.tsWithdrawal.Image = Resources.Wothdrawal;
		this.tsWithdrawal.Name = "tsWithdrawal";
		this.tsWithdrawal.Size = new Size(125, 22);
		this.tsWithdrawal.Text = "سند صرف";
		this.tsWithdrawal.add_Click(new EventHandler(this.tsWithdrawal_Click));
		this.toolStripSeparator1.Name = "toolStripSeparator1";
		this.toolStripSeparator1.Size = new Size(122, 6);
		this.tsJournal.Image = (Image)componentResourceManager.GetObject("tsJournal.Image");
		this.tsJournal.Name = "tsJournal";
		this.tsJournal.Size = new Size(125, 22);
		this.tsJournal.Text = "قيود اليومية";
		this.tsJournal.add_Click(new EventHandler(this.tsJournal_Click));
		this.mtsReports.DropDownItems.AddRange(new ToolStripItem[] { this.tsTransactionReport, this.tsAccountBalance, this.toolStripSeparator3, this.tsTrialBalance, this.tsBalanceSheet, this.toolStripSeparator4, this.tsProfitAndLoss, this.toolStripSeparator8, this.tsFixedAsset });
		this.mtsReports.ForeColor = Color.LightSlateGray;
		this.mtsReports.ImageTransparentColor = Color.White;
		this.mtsReports.Name = "mtsReports";
		this.mtsReports.Size = new Size(54, 20);
		this.mtsReports.Text = "التقارير";
		this.tsTransactionReport.Name = "tsTransactionReport";
		this.tsTransactionReport.Size = new Size(207, 22);
		this.tsTransactionReport.Text = "كشف حركة حساب";
		this.tsTransactionReport.add_Click(new EventHandler(this.tsTransactionReport_Click));
		this.tsAccountBalance.DropDownItems.AddRange(new ToolStripItem[] { this.tsCategory, this.tsSubAccount });
		this.tsAccountBalance.Name = "tsAccountBalance";
		this.tsAccountBalance.Size = new Size(207, 22);
		this.tsAccountBalance.Text = "كشف أرصدة مجموعة حسابات";
		this.tsCategory.Name = "tsCategory";
		this.tsCategory.Size = new Size(146, 22);
		this.tsCategory.Text = "حسابات رئيسية";
		this.tsCategory.add_Click(new EventHandler(this.tsCategory_Click));
		this.tsSubAccount.Name = "tsSubAccount";
		this.tsSubAccount.Size = new Size(146, 22);
		this.tsSubAccount.Text = "حسابات فرعية";
		this.tsSubAccount.add_Click(new EventHandler(this.tsSubAccount_Click));
		this.toolStripSeparator3.Name = "toolStripSeparator3";
		this.toolStripSeparator3.Size = new Size(204, 6);
		this.tsTrialBalance.Name = "tsTrialBalance";
		this.tsTrialBalance.Size = new Size(207, 22);
		this.tsTrialBalance.Text = "ميزان المراجعة";
		this.tsTrialBalance.add_Click(new EventHandler(this.tsTrialBalance_Click));
		this.tsBalanceSheet.Name = "tsBalanceSheet";
		this.tsBalanceSheet.Size = new Size(207, 22);
		this.tsBalanceSheet.Text = "الميزانية العمومية";
		this.tsBalanceSheet.add_Click(new EventHandler(this.tsBalanceSheet_Click));
		this.toolStripSeparator4.Name = "toolStripSeparator4";
		this.toolStripSeparator4.Size = new Size(204, 6);
		this.tsProfitAndLoss.Name = "tsProfitAndLoss";
		this.tsProfitAndLoss.Size = new Size(207, 22);
		this.tsProfitAndLoss.Text = "بيان الأرباح والخسائر";
		this.tsProfitAndLoss.add_Click(new EventHandler(this.tsProfitAndLoss_Click));
		this.toolStripSeparator8.Name = "toolStripSeparator8";
		this.toolStripSeparator8.Size = new Size(204, 6);
		this.tsFixedAsset.Name = "tsFixedAsset";
		this.tsFixedAsset.Size = new Size(207, 22);
		this.tsFixedAsset.Text = "مجمع الإهلاك";
		this.tsFixedAsset.add_Click(new EventHandler(this.tsFixedAsset_Click));
		this.mtsAccounts.DropDownItems.AddRange(new ToolStripItem[] { this.tsAccounts, this.toolStripSeparator5, this.tsSuppliers, this.tsEmployees, this.tsClients });
		this.mtsAccounts.ForeColor = Color.LightSlateGray;
		this.mtsAccounts.Name = "mtsAccounts";
		this.mtsAccounts.Size = new Size(61, 20);
		this.mtsAccounts.Text = "الحسابات";
		this.tsAccounts.Name = "tsAccounts";
		this.tsAccounts.Size = new Size(145, 22);
		this.tsAccounts.Text = "عرض الحسابات";
		this.tsAccounts.add_Click(new EventHandler(this.tsAccounts_Click));
		this.toolStripSeparator5.Name = "toolStripSeparator5";
		this.toolStripSeparator5.Size = new Size(142, 6);
		this.tsSuppliers.Name = "tsSuppliers";
		this.tsSuppliers.Size = new Size(145, 22);
		this.tsSuppliers.Text = "الموردون";
		this.tsSuppliers.add_Click(new EventHandler(this.tsSuppliers_Click));
		this.tsEmployees.Name = "tsEmployees";
		this.tsEmployees.Size = new Size(145, 22);
		this.tsEmployees.Text = "الموظفين";
		this.tsEmployees.add_Click(new EventHandler(this.tsEmployees_Click));
		this.tsClients.Name = "tsClients";
		this.tsClients.Size = new Size(145, 22);
		this.tsClients.Text = "العملاء";
		this.tsClients.add_Click(new EventHandler(this.tsClients_Click));
		this.mtsAbout.ForeColor = Color.LightSlateGray;
		this.mtsAbout.Name = "mtsAbout";
		this.mtsAbout.Size = new Size(73, 20);
		this.mtsAbout.Text = "عن البرنامج";
		this.mtsAbout.add_Click(new EventHandler(this.mtsAbout_Click));
		this.printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
		this.printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
		this.printPreviewDialog1.ClientSize = new Size(400, 300);
		this.printPreviewDialog1.Document = this.printDocument1;
		this.printPreviewDialog1.Enabled = true;
		this.printPreviewDialog1.Icon = (Icon)componentResourceManager.GetObject("printPreviewDialog1.Icon");
		this.printPreviewDialog1.Name = "printPreviewDialog1";
		this.printPreviewDialog1.Visible = false;
		base.AutoScaleDimensions = new SizeF(6, 13);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.BackColor = SystemColors.ButtonFace;
		base.ClientSize = new Size(697, 484);
		base.Controls.Add(this.menuStrip1);
		base.ForeColor = SystemColors.ActiveCaptionText;
		base.FormBorderStyle = FormBorderStyle.Fixed3D;
		base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		base.IsMdiContainer = true;
		base.MainMenuStrip = this.menuStrip1;
		base.MaximizeBox = false;
		base.Name = "Form1";
		base.RightToLeft = RightToLeft.Yes;
		base.RightToLeftLayout = true;
		base.StartPosition = FormStartPosition.CenterScreen;
		base.Text = "المحاسبة";
		base.TransparencyKey = Color.White;
		base.WindowState = FormWindowState.Maximized;
		base.Load += new EventHandler(this.Form1_Load);
		base.MdiChildActivate += new EventHandler(this.Form1_MdiChildActivate);
		this.menuStrip1.ResumeLayout(false);
		this.menuStrip1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void InitialStatus(bool status)
	{
		this.mtsAccounts.Enabled = status;
		this.mtsReports.Enabled = status;
		this.mtsVouchers.Enabled = status;
		this.tsSignout.Enabled = status;
		this.tsMemebers.Enabled = status;
		this.tsMainForm.Enabled = status;
		this.tsSignin.Enabled = status == 0;
		Form[] mdiChildren = base.MdiChildren;
		foreach (Form mdiChild in mdiChildren)
		{
			mdiChild.Enabled = status;
		}
	}

	private void mtsAbout_Click(object sender, EventArgs e)
	{
		AboutBox1 aboutBox1 = new AboutBox1();
		aboutBox1.StartPosition = FormStartPosition.CenterScreen;
		aboutBox1.Show();
	}

	internal void resetUI(string username)
	{
		Right right = SecBll.getRight(username);
		this.InitialStatus(true);
		switch (right)
		{
			case Right.Full:
			{
				this.tsMemebers.set_Visible(true);
				break;
			}
			case Right.ReadWrite:
			{
				this.tsMemebers.set_Visible(false);
				break;
			}
			case Right.ReadOnly:
			{
				this.tsDeposit.set_Enabled(false);
				this.tsWithdrawal.set_Enabled(false);
				this.tsMemebers.set_Visible(false);
				break;
			}
		}
	}

	private void tsAccounts_Click(object sender, EventArgs e)
	{
		this.deleteSubs();
		if (this.cc != null)
		{
			this.cc.Close();
			this.cc.Dispose();
		}
		this.cc = new AccountsForm();
		this.cc.MdiParent = this;
		this.cc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.cc.Dock = DockStyle.Fill;
		this.cc.Show();
	}

	private void tsBalanceSheet_Click(object sender, EventArgs e)
	{
		popupSearch _popupSearch = new popupSearch();
		_popupSearch.reportType = ReportType.BalanceSheet;
		_popupSearch._form1 = this;
		_popupSearch.Show();
	}

	private void tsCategory_Click(object sender, EventArgs e)
	{
		popupBalanceR _popupBalanceR = new popupBalanceR();
		_popupBalanceR.category = true;
		_popupBalanceR.StartPosition = FormStartPosition.CenterScreen;
		_popupBalanceR.form1 = this;
		_popupBalanceR.Show();
	}

	private void tsClients_Click(object sender, EventArgs e)
	{
		this.deleteSubs();
		ClientForm clientForm = new ClientForm();
		clientForm.MdiParent = this;
		clientForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		clientForm.Dock = DockStyle.Fill;
		clientForm.Show();
	}

	private void tsClose_Click(object sender, EventArgs e)
	{
		if (base.ActiveMdiChild != null)
		{
			base.ActiveMdiChild.Close();
		}
	}

	private void tsDeposit_Click(object sender, EventArgs e)
	{
		this.deleteSubs();
		DepositForm depositForm = new DepositForm();
		depositForm.MdiParent = this;
		depositForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		depositForm.Dock = DockStyle.Fill;
		depositForm.Show();
	}

	private void tsEmployees_Click(object sender, EventArgs e)
	{
		this.deleteSubs();
		EmployeeForm employeeForm = new EmployeeForm();
		employeeForm.MdiParent = this;
		employeeForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		employeeForm.Dock = DockStyle.Fill;
		employeeForm.Show();
	}

	private void tsExit_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void tsFixedAsset_Click(object sender, EventArgs e)
	{
		popupSearch _popupSearch = new popupSearch();
		_popupSearch.reportType = ReportType.FixedAsset;
		_popupSearch._form1 = this;
		_popupSearch.Show();
	}

	private void tsJournal_Click(object sender, EventArgs e)
	{
		this.deleteSubs();
		JournalForm journalForm = new JournalForm();
		journalForm.MdiParent = this;
		journalForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		journalForm.Dock = DockStyle.Fill;
		journalForm.Show();
	}

	private void tsMainForm_Click(object sender, EventArgs e)
	{
		this.deleteSubs();
		MainForm mainForm = new MainForm();
		mainForm.MdiParent = this;
		mainForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		mainForm.Dock = DockStyle.Fill;
		mainForm.Show();
	}

	private void tsMemebers_Click(object sender, EventArgs e)
	{
		AccountsManagerForm accountsManagerForm = new AccountsManagerForm();
		accountsManagerForm.Show();
	}

	private void tsPreview_Click(object sender, EventArgs e)
	{
		int item;
		DateTime dateDT;
		string name = base.ActiveMdiChild.Name;
		ReportFrom reportFrom = new ReportFrom();
		string str = name;
		if (str != null && (((str == "AccountsForm" || str != "DepositForm") && str == "WithdrawalForm" || str != "EmployeeForm") && str == "SupplierForm" || str != "JournalForm"))
		{
			reportFrom.StartPosition = FormStartPosition.CenterScreen;
			reportFrom.FormBorderStyle = FormBorderStyle.FixedSingle;
			reportFrom.reportType = ReportType.Accounts;
			reportFrom.Show();
			DepositForm activeMdiChild = (DepositForm)base.ActiveMdiChild;
			VoucherDataTable voucher = activeMdiChild._voucher.getVoucher(DepositForm._voucherID);
			ReportDocument reportDocument1 = new ReportDocument();
			reportDocument1.Load(string.Concat(Path.GetDirectoryName(Application.ExecutablePath), "\\VoucherCR.rpt"));
			ParameterValues parameterValue1 = new ParameterValues();
			ParameterDiscreteValue parameterDiscreteValue1 = new ParameterDiscreteValue();
			parameterDiscreteValue1.set_Value("سند قبض");
			parameterValue1.Add(parameterDiscreteValue1);
			reportDocument1.DataDefinition.ParameterFields["title"].ApplyCurrentValues(parameterValue1);
			ParameterValues parameterValue2 = new ParameterValues();
			ParameterDiscreteValue parameterDiscreteValue2 = new ParameterDiscreteValue();
			parameterDiscreteValue2.set_Value(activeMdiChild.lblName.Text);
			parameterValue2.Add(parameterDiscreteValue2);
			reportDocument1.DataDefinition.ParameterFields["lblAccName"].ApplyCurrentValues(parameterValue2);
			ParameterValues parameterValue3 = new ParameterValues();
			ParameterDiscreteValue parameterDiscreteValue3 = new ParameterDiscreteValue();
			parameterDiscreteValue3.set_Value(voucher[0].CName);
			parameterValue3.Add(parameterDiscreteValue3);
			reportDocument1.DataDefinition.ParameterFields["AccName"].ApplyCurrentValues(parameterValue3);
			ParameterValues parameterValue4 = new ParameterValues();
			ParameterDiscreteValue parameterDiscreteValue4 = new ParameterDiscreteValue();
			parameterDiscreteValue4.set_Value(voucher[0].CAcc);
			parameterValue4.Add(parameterDiscreteValue4);
			reportDocument1.DataDefinition.ParameterFields["AccNumber"].ApplyCurrentValues(parameterValue4);
			ParameterValues parameterValue5 = new ParameterValues();
			ParameterDiscreteValue parameterDiscreteValue5 = new ParameterDiscreteValue();
			parameterDiscreteValue5.set_Value(voucher[0].Amount_NU);
			parameterValue5.Add(parameterDiscreteValue5);
			reportDocument1.DataDefinition.ParameterFields["Amount"].ApplyCurrentValues(parameterValue5);
			ParameterValues parameterValue6 = new ParameterValues();
			ParameterDiscreteValue parameterDiscreteValue6 = new ParameterDiscreteValue();
			parameterDiscreteValue6.set_Value(voucher[0].Descrip_VC);
			parameterValue6.Add(parameterDiscreteValue6);
			reportDocument1.DataDefinition.ParameterFields["Desc"].ApplyCurrentValues(parameterValue6);
			ParameterValues parameterValue7 = new ParameterValues();
			ParameterDiscreteValue parameterDiscreteValue7 = new ParameterDiscreteValue();
			try
			{
				item = voucher[0].chkNumber.set_Value((!voucher[0].chkNumber ? "" : item.ToString()));
			}
			catch
			{
				parameterDiscreteValue7.set_Value("");
			}
			parameterValue7.Add(parameterDiscreteValue7);
			reportDocument1.DataDefinition.ParameterFields["chkNumber"].ApplyCurrentValues(parameterValue7);
			ParameterValues parameterValue8 = new ParameterValues();
			ParameterDiscreteValue parameterDiscreteValue8 = new ParameterDiscreteValue();
			parameterDiscreteValue8.set_Value((!voucher[0].BankName ? "" : voucher[0].BankName));
			parameterValue8.Add(parameterDiscreteValue8);
			reportDocument1.DataDefinition.ParameterFields["Bank"].ApplyCurrentValues(parameterValue8);
			ParameterValues parameterValue9 = new ParameterValues();
			ParameterDiscreteValue parameterDiscreteValue9 = new ParameterDiscreteValue();
			dateDT = voucher[0].Date_DT.set_Value(dateDT.ToShortDateString());
			parameterValue9.Add(parameterDiscreteValue9);
			reportDocument1.DataDefinition.ParameterFields["Date"].ApplyCurrentValues(parameterValue9);
			ParameterValues parameterValue10 = new ParameterValues();
			ParameterDiscreteValue parameterDiscreteValue10 = new ParameterDiscreteValue();
			parameterDiscreteValue10.set_Value(DepositForm._voucherID);
			parameterValue10.Add(parameterDiscreteValue10);
			reportDocument1.DataDefinition.ParameterFields["VNumber"].ApplyCurrentValues(parameterValue10);
			reportFrom.StartPosition = FormStartPosition.CenterScreen;
			reportFrom.FormBorderStyle = FormBorderStyle.FixedSingle;
			reportFrom.reportType = ReportType.None;
			reportFrom.crViewer.set_ReportSource(reportDocument1);
			reportFrom.Show();
			WithdrawalForm withdrawalForm = (WithdrawalForm)base.ActiveMdiChild;
			VoucherDataTable voucherDataTable = withdrawalForm._voucher.getVoucher(WithdrawalForm._voucherID);
			ReportDocument reportDocument2 = new ReportDocument();
			reportDocument2.Load(string.Concat(Path.GetDirectoryName(Application.ExecutablePath), "\\VoucherCR.rpt"));
			ParameterValues parameterValue11 = new ParameterValues();
			ParameterDiscreteValue parameterDiscreteValue11 = new ParameterDiscreteValue();
			parameterDiscreteValue11.set_Value("سند صرف");
			parameterValue11.Add(parameterDiscreteValue11);
			reportDocument2.DataDefinition.ParameterFields["title"].ApplyCurrentValues(parameterValue11);
			ParameterValues parameterValue12 = new ParameterValues();
			ParameterDiscreteValue parameterDiscreteValue12 = new ParameterDiscreteValue();
			parameterDiscreteValue12.set_Value(withdrawalForm.lblName.Text);
			parameterValue12.Add(parameterDiscreteValue12);
			reportDocument2.DataDefinition.ParameterFields["lblAccName"].ApplyCurrentValues(parameterValue12);
			ParameterValues parameterValue13 = new ParameterValues();
			ParameterDiscreteValue parameterDiscreteValue13 = new ParameterDiscreteValue();
			parameterDiscreteValue13.set_Value(voucherDataTable[0].CName);
			parameterValue13.Add(parameterDiscreteValue13);
			reportDocument2.DataDefinition.ParameterFields["AccName"].ApplyCurrentValues(parameterValue13);
			ParameterValues parameterValue14 = new ParameterValues();
			ParameterDiscreteValue parameterDiscreteValue14 = new ParameterDiscreteValue();
			parameterDiscreteValue14.set_Value(voucherDataTable[0].CAcc);
			parameterValue14.Add(parameterDiscreteValue14);
			reportDocument2.DataDefinition.ParameterFields["AccNumber"].ApplyCurrentValues(parameterValue14);
			ParameterValues parameterValue15 = new ParameterValues();
			ParameterDiscreteValue parameterDiscreteValue15 = new ParameterDiscreteValue();
			parameterDiscreteValue15.set_Value(voucherDataTable[0].Amount_NU);
			parameterValue15.Add(parameterDiscreteValue15);
			reportDocument2.DataDefinition.ParameterFields["Amount"].ApplyCurrentValues(parameterValue15);
			ParameterValues parameterValue16 = new ParameterValues();
			ParameterDiscreteValue parameterDiscreteValue16 = new ParameterDiscreteValue();
			parameterDiscreteValue16.set_Value(voucherDataTable[0].Descrip_VC);
			parameterValue16.Add(parameterDiscreteValue16);
			reportDocument2.DataDefinition.ParameterFields["Desc"].ApplyCurrentValues(parameterValue16);
			ParameterValues parameterValue17 = new ParameterValues();
			ParameterDiscreteValue parameterDiscreteValue17 = new ParameterDiscreteValue();
			try
			{
				item = voucherDataTable[0].chkNumber.set_Value((!voucherDataTable[0].chkNumber ? "" : item.ToString()));
			}
			catch
			{
				parameterDiscreteValue17.set_Value("");
			}
			parameterValue17.Add(parameterDiscreteValue17);
			reportDocument2.DataDefinition.ParameterFields["chkNumber"].ApplyCurrentValues(parameterValue17);
			ParameterValues parameterValue18 = new ParameterValues();
			ParameterDiscreteValue parameterDiscreteValue18 = new ParameterDiscreteValue();
			parameterDiscreteValue18.set_Value((!voucherDataTable[0].BankName ? "" : voucherDataTable[0].BankName));
			parameterValue18.Add(parameterDiscreteValue18);
			reportDocument2.DataDefinition.ParameterFields["Bank"].ApplyCurrentValues(parameterValue18);
			ParameterValues parameterValue19 = new ParameterValues();
			ParameterDiscreteValue parameterDiscreteValue19 = new ParameterDiscreteValue();
			dateDT = voucherDataTable[0].Date_DT.set_Value(dateDT.ToShortDateString());
			parameterValue19.Add(parameterDiscreteValue19);
			reportDocument2.DataDefinition.ParameterFields["Date"].ApplyCurrentValues(parameterValue19);
			ParameterValues parameterValue20 = new ParameterValues();
			ParameterDiscreteValue parameterDiscreteValue20 = new ParameterDiscreteValue();
			parameterDiscreteValue20.set_Value(WithdrawalForm._voucherID);
			parameterValue20.Add(parameterDiscreteValue20);
			reportDocument2.DataDefinition.ParameterFields["VNumber"].ApplyCurrentValues(parameterValue20);
			reportFrom.StartPosition = FormStartPosition.CenterScreen;
			reportFrom.FormBorderStyle = FormBorderStyle.FixedSingle;
			reportFrom.reportType = ReportType.None;
			reportFrom.crViewer.set_ReportSource(reportDocument2);
			reportFrom.Show();
			reportFrom.StartPosition = FormStartPosition.CenterScreen;
			reportFrom.FormBorderStyle = FormBorderStyle.FixedSingle;
			reportFrom.reportType = ReportType.Employees;
			reportFrom.Show();
			reportFrom.StartPosition = FormStartPosition.CenterScreen;
			reportFrom.FormBorderStyle = FormBorderStyle.FixedSingle;
			reportFrom.reportType = ReportType.Suppliers;
			reportFrom.Show();
		}
	L_093e:
	}

	private void tsPrint_Click(object sender, EventArgs e)
	{
		EmployeeForm employeeForm;
		SupplierForm supplierForm;
		AccountsForm accountsForm;
		JournalForm journalForm;
		DepositForm depositForm;
		WithdrawalForm withdrawalForm;
		ReportFrom reportFrom;
		int num = 0;
		string name = base.ActiveMdiChild.Name;
		string str = name;
		if (str != null)
		{
			if (<PrivateImplementationDetails>{872C86BB-7B68-47C8-8D6E-5871256AF993}.$$method0x6000866-1 == null)
			{
				<PrivateImplementationDetails>{872C86BB-7B68-47C8-8D6E-5871256AF993}.$$method0x6000866-1 = new Dictionary<string, int>(7).Add("EmployeeForm", 0).Add("SupplierForm", 1).Add("AccountsForm", 2).Add("JournalForm", 3).Add("DepositForm", 4).Add("WithdrawalForm", 5).Add("ReportFrom", 6);
			}
			if (<PrivateImplementationDetails>{872C86BB-7B68-47C8-8D6E-5871256AF993}.$$method0x6000866-1.TryGetValue(str, ref num))
			{
				switch (num)
				{
					case 0:
					{
						employeeForm = (EmployeeForm)this.ActiveMdiChild;
						employeeForm.btnPrint_Click(sender, e);
						break;
					}
					case 1:
					{
						supplierForm = (SupplierForm)this.ActiveMdiChild;
						supplierForm.btnPrint_Click(sender, e);
						break;
					}
					case 2:
					{
						accountsForm = (AccountsForm)this.ActiveMdiChild;
						accountsForm.tsPrint_Click(sender, e);
						break;
					}
					case 3:
					{
						journalForm = (JournalForm)this.ActiveMdiChild;
						journalForm.btnPrint_Click(sender, e);
						break;
					}
					case 4:
					{
						depositForm = (DepositForm)this.ActiveMdiChild;
						depositForm.tsPrint_Click(sender, e);
						break;
					}
					case 5:
					{
						withdrawalForm = (WithdrawalForm)this.ActiveMdiChild;
						withdrawalForm.tsPrint_Click(sender, e);
						break;
					}
					case 6:
					{
						reportFrom = (ReportFrom)this.ActiveMdiChild;
						reportFrom.crViewer.PrintReport();
						break;
					}
				}
			}
		}
	}

	private void tsProfitAndLoss_Click(object sender, EventArgs e)
	{
		popupSearch _popupSearch = new popupSearch();
		_popupSearch.reportType = ReportType.ProfitAndLoss;
		_popupSearch._form1 = this;
		_popupSearch.Show();
	}

	private void tsSignin_Click(object sender, EventArgs e)
	{
		SigninForm signinForm = new SigninForm();
		signinForm._form1 = this;
		signinForm.Show();
	}

	private void tsSignout_Click(object sender, EventArgs e)
	{
		this.UserName = "";
		Form[] mdiChildren = base.MdiChildren;
		foreach (Form mdiChild in mdiChildren)
		{
			mdiChild.Close();
			mdiChild.Dispose();
		}
		this.InitialStatus(false);
	}

	private void tsSubAccount_Click(object sender, EventArgs e)
	{
		popupBalanceR _popupBalanceR = new popupBalanceR();
		_popupBalanceR.category = false;
		_popupBalanceR.StartPosition = FormStartPosition.CenterScreen;
		_popupBalanceR.form1 = this;
		_popupBalanceR.Show();
	}

	private void tsSuppliers_Click(object sender, EventArgs e)
	{
		this.deleteSubs();
		SupplierForm supplierForm = new SupplierForm();
		supplierForm.MdiParent = this;
		supplierForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		supplierForm.Dock = DockStyle.Fill;
		supplierForm.Show();
	}

	private void tsTransactionReport_Click(object sender, EventArgs e)
	{
		popupSearch _popupSearch = new popupSearch();
		_popupSearch.reportType = ReportType.Transactions;
		_popupSearch._form1 = this;
		_popupSearch.Show();
	}

	private void tsTrialBalance_Click(object sender, EventArgs e)
	{
		popupSearch _popupSearch = new popupSearch();
		_popupSearch.reportType = ReportType.TrialBalance;
		_popupSearch._form1 = this;
		_popupSearch.Show();
	}

	private void tsWithdrawal_Click(object sender, EventArgs e)
	{
		this.deleteSubs();
		WithdrawalForm withdrawalForm = new WithdrawalForm();
		withdrawalForm.MdiParent = this;
		withdrawalForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		withdrawalForm.Dock = DockStyle.Fill;
		withdrawalForm.Show();
	}
}
}