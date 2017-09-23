using System.Windows.Forms;
using System.ComponentModel;
using System;
using Accounting.Reports;
using System.Drawing;

namespace Accounting
{
public class popupSearch : Form
{
	private AccountsBLL _accounts;

	internal Form1 _form1;

	private Button btnClose;

	private Button btnShow;

	private IContainer components;

	private ComboBox ddlAccounts;

	private DateTimePicker dtFrom;

	private DateTimePicker dtTo;

	private Label lblAccount;

	private Label lblFrom;

	private Label lblTo;

	private Panel panel1;

	public ReportType reportType;

	public popupSearch()
	{
		this.components = null;
		base();
		this.InitializeComponent();
		this._accounts = new AccountsBLL();
	}

	private void btnClose_Click(object sender, EventArgs e)
	{
		base.Close();
		base.Dispose();
	}

	private void btnShow_Click(object sender, EventArgs e)
	{
		int num;
		DateTime @value = this.dtFrom.Value;
		DateTime date = @value.Date;
		@value = this.dtTo.Value;
		DateTime dateTime = @value.Date;
		ReportFrom reportFrom = new ReportFrom();
		switch (this.reportType)
		{
			case ReportType.TrialBalance:
			{
				reportFrom.reportType = 0;
			}
			case ReportType.BalanceSheet:
			{
				reportFrom.reportType = 1;
			}
			case ReportType.Transactions:
			{
				reportFrom.reportType = 2;
				num = Convert.ToInt32(this.ddlAccounts.SelectedValue);
				reportFrom.account = num;
			}
			case ReportType.ProfitAndLoss:
			{
				reportFrom.reportType = 3;
				reportFrom.reportType = 8;
				goto ;
			}
			case ReportType.Suppliers:
			{
				reportFrom.From = date;
				reportFrom.To = dateTime;
				this.closeSubs(this._form1);
				reportFrom.set_MdiParent(this._form1);
				this.Close();
				this.Dispose();
				reportFrom.set_Anchor(9);
				reportFrom.set_Dock(5);
				reportFrom.Show();
				return;
			}
		}
	}

	private void closeSubs(Form1 form)
	{
		Form[] mdiChildren = form.MdiChildren;
		foreach (Form mdiChild in mdiChildren)
		{
			mdiChild.Close();
			mdiChild.Dispose();
		}
	}

	private void ddlAccounts_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (this.reportType != ReportType.TrialBalance || this.ddlAccounts.SelectedIndex == 0)
		{
			DateTime now = DateTime.Now.Value = new DateTime(now.Year, 1, 1);
			now = DateTime.Now.Value = new DateTime(now.Year, 12, 31);
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
		this.dtFrom = new DateTimePicker();
		this.dtTo = new DateTimePicker();
		this.ddlAccounts = new ComboBox();
		this.lblAccount = new Label();
		this.lblFrom = new Label();
		this.lblTo = new Label();
		this.btnShow = new Button();
		this.btnClose = new Button();
		this.panel1 = new Panel();
		this.panel1.SuspendLayout();
		base.SuspendLayout();
		this.dtFrom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.dtFrom.Location = new Point(83, 68);
		this.dtFrom.Name = "dtFrom";
		this.dtFrom.RightToLeftLayout = true;
		this.dtFrom.Size = new Size(200, 20);
		this.dtFrom.TabIndex = 0;
		this.dtTo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.dtTo.Location = new Point(83, 98);
		this.dtTo.Name = "dtTo";
		this.dtTo.RightToLeftLayout = true;
		this.dtTo.Size = new Size(200, 20);
		this.dtTo.TabIndex = 1;
		this.ddlAccounts.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.ddlAccounts.FormattingEnabled = true;
		this.ddlAccounts.Location = new Point(102, 13);
		this.ddlAccounts.Name = "ddlAccounts";
		this.ddlAccounts.Size = new Size(200, 21);
		this.ddlAccounts.TabIndex = 2;
		this.ddlAccounts.SelectedIndexChanged += new EventHandler(this.ddlAccounts_SelectedIndexChanged);
		this.lblAccount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblAccount.AutoSize = true;
		this.lblAccount.ForeColor = SystemColors.ButtonFace;
		this.lblAccount.Location = new Point(308, 16);
		this.lblAccount.Name = "lblAccount";
		this.lblAccount.Size = new Size(44, 13);
		this.lblAccount.TabIndex = 3;
		this.lblAccount.Text = "الحساب";
		this.lblFrom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblFrom.AutoSize = true;
		this.lblFrom.ForeColor = SystemColors.ButtonFace;
		this.lblFrom.Location = new Point(32, 74);
		this.lblFrom.Name = "lblFrom";
		this.lblFrom.Size = new Size(45, 13);
		this.lblFrom.TabIndex = 4;
		this.lblFrom.Text = "من تاريخ";
		this.lblTo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblTo.AutoSize = true;
		this.lblTo.ForeColor = SystemColors.ButtonFace;
		this.lblTo.Location = new Point(29, 104);
		this.lblTo.Name = "lblTo";
		this.lblTo.Size = new Size(48, 13);
		this.lblTo.TabIndex = 5;
		this.lblTo.Text = "الى تاريخ";
		this.btnShow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.btnShow.BackColor = Color.FromArgb(150, 180, 200);
		this.btnShow.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.btnShow.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.btnShow.FlatStyle = FlatStyle.Flat;
		this.btnShow.Location = new Point(32, 145);
		this.btnShow.Name = "btnShow";
		this.btnShow.Size = new Size(75, 23);
		this.btnShow.TabIndex = 6;
		this.btnShow.Text = "عرض";
		this.btnShow.UseVisualStyleBackColor = false;
		this.btnShow.add_Click(new EventHandler(this.btnShow_Click));
		this.btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.btnClose.BackColor = Color.FromArgb(150, 180, 200);
		this.btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.btnClose.FlatStyle = FlatStyle.Flat;
		this.btnClose.Location = new Point(208, 145);
		this.btnClose.Name = "btnClose";
		this.btnClose.Size = new Size(75, 23);
		this.btnClose.TabIndex = 7;
		this.btnClose.Text = "إلغاء";
		this.btnClose.UseVisualStyleBackColor = false;
		this.btnClose.add_Click(new EventHandler(this.btnClose_Click));
		this.panel1.BorderStyle = BorderStyle.Fixed3D;
		this.panel1.Controls.Add(this.ddlAccounts);
		this.panel1.Controls.Add(this.lblAccount);
		this.panel1.Location = new Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new Size(387, 52);
		this.panel1.TabIndex = 8;
		base.AutoScaleDimensions = new SizeF(6, 13);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.BackColor = SystemColors.ControlDarkDark;
		base.ClientSize = new Size(317, 185);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.btnClose);
		base.Controls.Add(this.btnShow);
		base.Controls.Add(this.lblTo);
		base.Controls.Add(this.lblFrom);
		base.Controls.Add(this.dtTo);
		base.Controls.Add(this.dtFrom);
		base.FormBorderStyle = FormBorderStyle.FixedSingle;
		base.MaximizeBox = false;
		base.Name = "popupSearch";
		base.RightToLeft = RightToLeft.Yes;
		base.RightToLeftLayout = true;
		base.ShowIcon = false;
		base.StartPosition = FormStartPosition.CenterScreen;
		base.Text = "بحث";
		base.Load += new EventHandler(this.popupSearch_Load);
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void popupSearch_Load(object sender, EventArgs e)
	{
		COA_TDataTable cOATDataTable;
		DateTime dateTime;
		switch (this.reportType)
		{
			case ReportType.BalanceSheet:
			{
				this.ddlAccounts.Items.Add("سنة كامله");
				this.ddlAccounts.Items.Add("تاريخ محدد");
				this.ddlAccounts.set_SelectedIndex(0);
				this.lblAccount.set_Text("عرض التقرير لـ");
				dateTime = DateTime.Now.set_Value(new DateTime(dateTime.Year, 1, 1));
				dateTime = DateTime.Now.set_Value(new DateTime(dateTime.Year, 12, 31));
				break;
			}
			case ReportType.Transactions:
			{
				cOATDataTable = this._accounts.GetAllAccounts();
				this.ddlAccounts.set_DataSource(cOATDataTable);
				this.ddlAccounts.set_ValueMember("GL_ID");
				this.ddlAccounts.set_DisplayMember("GL_Name_VC");
				break;
			}
		}
	}
}
}