using System.Windows.Forms;
using System.ComponentModel;
using Accounting.Journal;
using System;
using System.Drawing;
using System.Data;

namespace Accounting.Vouchers
{
public class popupAccounts : Form
{
	private AccountsBLL accounts;

	private IContainer components;

	internal DepositForm depositForm;

	private DataGridView dgvAccounts;

	internal JournalForm journalForm;

	private Label lblFilter;

	private Label lblSearch;

	private Panel pnlSearch;

	private RadioButton rbCode;

	private RadioButton rbName;

	private AccountsViewDataTable table;

	private TextBox tbSearch;

	internal WithdrawalForm withdrawalForm;

	public popupAccounts()
	{
		this.components = null;
		base();
		this.InitializeComponent();
		this.accounts = new AccountsBLL();
	}

	private void dgvAccounts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		if (this.depositForm != null)
		{
			this.depositForm.tbName.Text = this.dgvAccounts.get_Item(1, e.RowIndex).Value.ToString();
			this.depositForm.tbCode.Text = this.dgvAccounts.get_Item(0, e.RowIndex).Value.ToString();
			this.depositForm.tbAmount.Focus();
			base.Close();
			base.Dispose();
		}
		else
		{
			if (this.journalForm != null)
			{
				this.journalForm.tbCode.Text = this.dgvAccounts.get_Item(0, e.RowIndex).Value.ToString();
				this.journalForm.tbAmount.Focus();
				base.Close();
				base.Dispose();
			}
			else
			{
				if (this.withdrawalForm != null)
				{
					this.withdrawalForm.tbName.Text = this.dgvAccounts.get_Item(1, e.RowIndex).Value.ToString();
					this.withdrawalForm.tbCode.Text = this.dgvAccounts.get_Item(0, e.RowIndex).Value.ToString();
					this.withdrawalForm.tbAmount.Focus();
					base.Close();
					base.Dispose();
				}
			}
		}
	}

	private void dgvAccounts_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == 13)
		{
			DataGridView dataGridView = (DataGridView)sender;
			if (this.depositForm != null)
			{
				this.depositForm.tbName.Text = this.dgvAccounts.get_Item(1, dataGridView.SelectedRows[0].Index).Value.ToString();
				this.depositForm.tbCode.Text = this.dgvAccounts.get_Item(0, dataGridView.SelectedRows[0].Index).Value.ToString();
				this.depositForm.tbAmount.Focus();
				base.Close();
				base.Dispose();
			}
			else
			{
				if (this.journalForm != null)
				{
					this.journalForm.tbCode.Text = this.dgvAccounts.get_Item(0, dataGridView.SelectedRows[0].Index).Value.ToString();
					this.journalForm.tbAmount.Focus();
					base.Close();
					base.Dispose();
				}
				else
				{
					if (this.withdrawalForm != null)
					{
						this.withdrawalForm.tbName.Text = this.dgvAccounts.get_Item(1, dataGridView.SelectedRows[0].Index).Value.ToString();
						this.withdrawalForm.tbCode.Text = this.dgvAccounts.get_Item(0, dataGridView.SelectedRows[0].Index).Value.ToString();
						this.withdrawalForm.tbAmount.Focus();
						base.Close();
						base.Dispose();
					}
				}
			}
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
		DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
		this.lblSearch = new Label();
		this.tbSearch = new TextBox();
		this.dgvAccounts = new DataGridView();
		this.pnlSearch = new Panel();
		this.lblFilter = new Label();
		this.rbCode = new RadioButton();
		this.rbName = new RadioButton();
		this.dgvAccounts.BeginInit();
		this.pnlSearch.SuspendLayout();
		base.SuspendLayout();
		this.lblSearch.AutoSize = true;
		this.lblSearch.ForeColor = SystemColors.ButtonFace;
		this.lblSearch.Location = new Point(18, 80);
		this.lblSearch.Name = "lblSearch";
		this.lblSearch.Size = new Size(27, 13);
		this.lblSearch.TabIndex = 0;
		this.lblSearch.Text = "بحث";
		this.tbSearch.Location = new Point(109, 77);
		this.tbSearch.Name = "tbSearch";
		this.tbSearch.Size = new Size(168, 20);
		this.tbSearch.TabIndex = 1;
		this.tbSearch.add_TextChanged(new EventHandler(this.tbSearch_TextChanged));
		this.dgvAccounts.AllowUserToAddRows = false;
		this.dgvAccounts.AllowUserToDeleteRows = false;
		this.dgvAccounts.BackgroundColor = SystemColors.ControlDarkDark;
		this.dgvAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvAccounts.Dock = DockStyle.Bottom;
		this.dgvAccounts.Location = new Point(0, 109);
		this.dgvAccounts.Name = "dgvAccounts";
		this.dgvAccounts.ReadOnly = true;
		dataGridViewCellStyle.SelectionBackColor = SystemColors.ControlDark;
		this.dgvAccounts.RowsDefaultCellStyle = dataGridViewCellStyle;
		this.dgvAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dgvAccounts.Size = new Size(328, 223);
		this.dgvAccounts.TabIndex = 2;
		this.dgvAccounts.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvAccounts_CellDoubleClick);
		this.dgvAccounts.add_KeyDown(new KeyEventHandler(this.dgvAccounts_KeyDown));
		this.pnlSearch.BorderStyle = BorderStyle.Fixed3D;
		this.pnlSearch.Controls.Add(this.lblFilter);
		this.pnlSearch.Controls.Add(this.rbCode);
		this.pnlSearch.Controls.Add(this.rbName);
		this.pnlSearch.Dock = DockStyle.Top;
		this.pnlSearch.Location = new Point(0, 0);
		this.pnlSearch.Name = "pnlSearch";
		this.pnlSearch.Size = new Size(328, 64);
		this.pnlSearch.TabIndex = 3;
		this.lblFilter.AutoSize = true;
		this.lblFilter.ForeColor = SystemColors.ButtonFace;
		this.lblFilter.Location = new Point(234, 6);
		this.lblFilter.Name = "lblFilter";
		this.lblFilter.Size = new Size(74, 13);
		this.lblFilter.TabIndex = 4;
		this.lblFilter.Text = "بحث باستخدام";
		this.rbCode.AutoSize = true;
		this.rbCode.ForeColor = SystemColors.ButtonFace;
		this.rbCode.Location = new Point(135, 36);
		this.rbCode.Name = "rbCode";
		this.rbCode.Size = new Size(82, 17);
		this.rbCode.TabIndex = 1;
		this.rbCode.Text = "رقم الحساب";
		this.rbCode.UseVisualStyleBackColor = true;
		this.rbName.AutoSize = true;
		this.rbName.Checked = true;
		this.rbName.ForeColor = SystemColors.ButtonFace;
		this.rbName.Location = new Point(130, 13);
		this.rbName.Name = "rbName";
		this.rbName.Size = new Size(87, 17);
		this.rbName.TabIndex = 0;
		this.rbName.TabStop = true;
		this.rbName.Text = "اسم الحساب";
		this.rbName.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new SizeF(6, 13);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.BackColor = SystemColors.ControlDarkDark;
		base.ClientSize = new Size(328, 332);
		base.Controls.Add(this.pnlSearch);
		base.Controls.Add(this.dgvAccounts);
		base.Controls.Add(this.tbSearch);
		base.Controls.Add(this.lblSearch);
		base.FormBorderStyle = FormBorderStyle.Fixed3D;
		base.MaximizeBox = false;
		base.Name = "popupAccounts";
		base.RightToLeft = RightToLeft.Yes;
		base.RightToLeftLayout = true;
		base.StartPosition = FormStartPosition.CenterScreen;
		base.Text = "بحث...";
		base.Load += new EventHandler(this.popupAccounts_Load);
		this.dgvAccounts.EndInit();
		this.pnlSearch.ResumeLayout(false);
		this.pnlSearch.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void popupAccounts_Load(object sender, EventArgs e)
	{
		this.table = this.accounts.GetAccountsView();
		this.table.GL_IDColumn.ColumnName = "رقم الحساب";
		this.table.GL_Name_VCColumn.ColumnName = "اسم الحساب";
		this.table.ParentColumn.ColumnName = "تابع لحساب";
		this.dgvAccounts.DataSource = this.table;
		this.dgvAccounts.Columns["BS_Category_VC"].Visible = false;
		this.dgvAccounts.Columns["Status_BT"].Visible = false;
		this.dgvAccounts.Columns["Balance"].Visible = false;
		this.dgvAccounts.Columns["Category_Name"].Visible = false;
		this.dgvAccounts.AutoResizeColumns();
	}

	private void tbSearch_TextChanged(object sender, EventArgs e)
	{
		EnumerableRowCollection<AccountsViewRow> accountsViewRows;
		Func<AccountsViewRow, bool> func1 = null;
		Func<AccountsViewRow, bool> func2 = null;
		popupAccounts popupAccount = new popupAccounts();
		popupAccount.sender = sender;
		if (this.rbName.Checked)
		{
		}
		else
		{
		}
	}
}
}