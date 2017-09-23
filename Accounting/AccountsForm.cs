using System.Windows.Forms;
using System.ComponentModel;
using System;
using System.Drawing;
using Accounting.Properties;
using Accounting.Code.Bll;
using Accounting.Client;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;

namespace Accounting
{
public class AccountsForm : Form
{
	private AccountsBLL accounts;

	private IContainer components;

	internal DataGridView dgvAccounts;

	private Panel panel1;

	private popupAddForm pop;

	private PrintDialog printDialog1;

	private Button toolstripButton2;

	private Button toolstripButton4;

	private Button tsAdd;

	private Button tsExit;

	private Button tsPrint;

	public AccountsForm()
	{
		this.components = null;
		base();
		this.InitializeComponent();
		this.accounts = new AccountsBLL();
	}

	private void Accounts_Load(object sender, EventArgs e)
	{
		AccountsViewDataTable accountsView = this.accounts.GetAccountsView();
		accountsView.BalanceColumn.ColumnName = "الرصيد";
		accountsView.Category_NameColumn.ColumnName = "نوع الحساب";
		accountsView.GL_IDColumn.ColumnName = "رقم الحساب";
		accountsView.GL_Name_VCColumn.ColumnName = "اسم الحساب";
		accountsView.ParentColumn.ColumnName = "تابع لحساب";
		accountsView.Status_BTColumn.ColumnName = "مفعل";
		this.dgvAccounts.DataSource = accountsView;
		this.dgvAccounts.Columns["BS_Category_VC"].Visible = false;
		base.WindowState = FormWindowState.Maximized;
		this.resetUI((Form1)base.MdiParent.UserName);
	}

	private void dgvAccounts_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
	{
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
		DataGridViewCellStyle controlDark = new DataGridViewCellStyle();
		this.panel1 = new Panel();
		this.tsExit = new Button();
		this.toolstripButton2 = new Button();
		this.toolstripButton4 = new Button();
		this.tsPrint = new Button();
		this.tsAdd = new Button();
		this.dgvAccounts = new DataGridView();
		this.printDialog1 = new PrintDialog();
		this.panel1.SuspendLayout();
		this.dgvAccounts.BeginInit();
		base.SuspendLayout();
		this.panel1.BackColor = SystemColors.Control;
		this.panel1.Controls.Add(this.tsExit);
		this.panel1.Controls.Add(this.toolstripButton2);
		this.panel1.Controls.Add(this.toolstripButton4);
		this.panel1.Controls.Add(this.tsPrint);
		this.panel1.Controls.Add(this.tsAdd);
		this.panel1.Dock = DockStyle.Top;
		this.panel1.Location = new Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.RightToLeft = RightToLeft.Yes;
		this.panel1.Size = new Size(738, 48);
		this.panel1.TabIndex = 0;
		this.tsExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.tsExit.BackColor = Color.FromArgb(150, 180, 200);
		this.tsExit.FlatAppearance.BorderColor = Color.Black;
		this.tsExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.tsExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.tsExit.FlatStyle = FlatStyle.Flat;
		this.tsExit.Font = new Font("Tahoma", 8.25, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.tsExit.ForeColor = SystemColors.ControlText;
		this.tsExit.Image = Resources.Exit;
		this.tsExit.Location = new Point(280, 12);
		this.tsExit.Name = "tsExit";
		this.tsExit.Size = new Size(84, 27);
		this.tsExit.TabIndex = 4;
		this.tsExit.Text = "خروج";
		this.tsExit.TextImageRelation = TextImageRelation.ImageBeforeText;
		this.tsExit.UseVisualStyleBackColor = false;
		this.tsExit.add_Click(new EventHandler(this.tsExit_Click));
		this.toolstripButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.toolstripButton2.BackColor = Color.FromArgb(150, 180, 200);
		this.toolstripButton2.FlatAppearance.BorderColor = Color.Black;
		this.toolstripButton2.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.toolstripButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.toolstripButton2.FlatStyle = FlatStyle.Flat;
		this.toolstripButton2.Font = new Font("Tahoma", 8.25, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.toolstripButton2.ForeColor = SystemColors.ControlText;
		this.toolstripButton2.Image = Resources.Edit;
		this.toolstripButton2.Location = new Point(553, 12);
		this.toolstripButton2.Name = "toolstripButton2";
		this.toolstripButton2.Size = new Size(84, 27);
		this.toolstripButton2.TabIndex = 1;
		this.toolstripButton2.Text = "تعديل";
		this.toolstripButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
		this.toolstripButton2.UseVisualStyleBackColor = false;
		this.toolstripButton2.add_Click(new EventHandler(this.toolStripButton2_Click));
		this.toolstripButton4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.toolstripButton4.BackColor = Color.FromArgb(150, 180, 200);
		this.toolstripButton4.FlatAppearance.BorderColor = Color.Black;
		this.toolstripButton4.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.toolstripButton4.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.toolstripButton4.FlatStyle = FlatStyle.Flat;
		this.toolstripButton4.Font = new Font("Tahoma", 8.25, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.toolstripButton4.ForeColor = SystemColors.ControlText;
		this.toolstripButton4.Image = Resources.Delete;
		this.toolstripButton4.Location = new Point(463, 12);
		this.toolstripButton4.Name = "toolstripButton4";
		this.toolstripButton4.Size = new Size(84, 27);
		this.toolstripButton4.TabIndex = 2;
		this.toolstripButton4.Text = "حذف";
		this.toolstripButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
		this.toolstripButton4.UseVisualStyleBackColor = false;
		this.toolstripButton4.add_Click(new EventHandler(this.toolStripButton4_Click));
		this.tsPrint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.tsPrint.BackColor = Color.FromArgb(150, 180, 200);
		this.tsPrint.FlatAppearance.BorderColor = Color.Black;
		this.tsPrint.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.tsPrint.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.tsPrint.FlatStyle = FlatStyle.Flat;
		this.tsPrint.Font = new Font("Tahoma", 8.25, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.tsPrint.ForeColor = SystemColors.ControlText;
		this.tsPrint.Image = Resources.Print;
		this.tsPrint.Location = new Point(372, 12);
		this.tsPrint.Name = "tsPrint";
		this.tsPrint.Size = new Size(84, 27);
		this.tsPrint.TabIndex = 3;
		this.tsPrint.Text = "طباعة";
		this.tsPrint.TextImageRelation = TextImageRelation.ImageBeforeText;
		this.tsPrint.UseVisualStyleBackColor = false;
		this.tsPrint.add_Click(new EventHandler(this.tsPrint_Click));
		this.tsAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.tsAdd.BackColor = Color.FromArgb(150, 180, 200);
		this.tsAdd.FlatAppearance.BorderColor = Color.Black;
		this.tsAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.tsAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.tsAdd.FlatStyle = FlatStyle.Flat;
		this.tsAdd.Font = new Font("Tahoma", 8.25, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.tsAdd.ForeColor = SystemColors.ControlText;
		this.tsAdd.Image = Resources.Add;
		this.tsAdd.Location = new Point(643, 12);
		this.tsAdd.Name = "tsAdd";
		this.tsAdd.Size = new Size(84, 27);
		this.tsAdd.TabIndex = 0;
		this.tsAdd.Text = "إضافة";
		this.tsAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
		this.tsAdd.UseVisualStyleBackColor = false;
		this.tsAdd.add_Click(new EventHandler(this.tsAdd_Click));
		this.dgvAccounts.AllowUserToAddRows = false;
		this.dgvAccounts.AllowUserToDeleteRows = false;
		this.dgvAccounts.AllowUserToOrderColumns = true;
		this.dgvAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		this.dgvAccounts.BackgroundColor = SystemColors.ControlDarkDark;
		this.dgvAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvAccounts.Dock = DockStyle.Fill;
		this.dgvAccounts.Location = new Point(0, 48);
		this.dgvAccounts.Name = "dgvAccounts";
		this.dgvAccounts.ReadOnly = true;
		dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = SystemColors.Control;
		dataGridViewCellStyle.Font = new Font("Tahoma", 8);
		dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = Color.FromArgb(150, 192, 192);
		dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
		this.dgvAccounts.RowHeadersDefaultCellStyle = dataGridViewCellStyle;
		controlDark.SelectionBackColor = SystemColors.ControlDark;
		this.dgvAccounts.RowsDefaultCellStyle = controlDark;
		this.dgvAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dgvAccounts.Size = new Size(738, 429);
		this.dgvAccounts.TabIndex = 1;
		this.dgvAccounts.CellPainting += new DataGridViewCellPaintingEventHandler(this.dgvAccounts_CellPainting);
		this.printDialog1.UseEXDialog = true;
		base.AutoScaleDimensions = new SizeF(6, 13);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.BackColor = SystemColors.ControlDarkDark;
		base.ClientSize = new Size(738, 477);
		base.Controls.Add(this.dgvAccounts);
		base.Controls.Add(this.panel1);
		base.FormBorderStyle = FormBorderStyle.Fixed3D;
		base.Name = "AccountsForm";
		base.RightToLeft = RightToLeft.Yes;
		base.RightToLeftLayout = true;
		base.ShowIcon = false;
		base.Text = "قائمة الحسابات";
		base.Load += new EventHandler(this.Accounts_Load);
		this.panel1.ResumeLayout(false);
		this.dgvAccounts.EndInit();
		base.ResumeLayout(false);
	}

	internal void reloadData()
	{
		AccountsViewDataTable accountsView = this.accounts.GetAccountsView();
		accountsView.BalanceColumn.ColumnName = "الرصيد";
		accountsView.Category_NameColumn.ColumnName = "نوع الحساب";
		accountsView.GL_IDColumn.ColumnName = "رقم الحساب";
		accountsView.GL_Name_VCColumn.ColumnName = "اسم الحساب";
		accountsView.ParentColumn.ColumnName = "تابع لحساب";
		accountsView.Status_BTColumn.ColumnName = "مفعل";
		this.dgvAccounts.DataSource = accountsView;
		this.dgvAccounts.Columns["BS_Category_VC"].Visible = false;
	}

	internal void resetUI(string username)
	{
		Right right = SecBll.getRight(username);
		switch (right)
		{
			case Right.RestrictedWrite:
			{
				this.tsAdd.set_Enabled(false);
				this.toolstripButton2.set_Enabled(false);
				this.toolstripButton4.set_Enabled(false);
				break;
			}
		}
	}

	private void toolStripButton2_Click(object sender, EventArgs e)
	{
		int num1;
		try
		{
			int index = this.dgvAccounts.SelectedRows[0].Index;
			int num2 = Convert.ToInt32(this.dgvAccounts.Rows[index].Cells[0].Value);
			int parent = this.accounts.getParent(num2);
			num1 = parent;
			popupClient _popupClient = new popupClient();
			_popupClient.edit = true;
			_popupClient.clientF = null;
			_popupClient.row = index;
			_popupClient.tbAccCode.Text = this.dgvAccounts.Rows[index].Cells[0].Value.ToString();
			_popupClient.tbEName.Text = this.dgvAccounts.Rows[index].Cells[1].Value.ToString();
			_popupClient.tbBalance.Visible = true;
			_popupClient.tbBalance.ReadOnly = true;
			_popupClient.lblBalance.Visible = true;
			_popupClient.lblBalance.Enabled = false;
			_popupClient.Text = "تعديل معلومات عميل";
			_popupClient.Show();
			this.pop = new popupAddForm();
			this.pop.pnlType.Enabled = false;
			this.pop.accountsForm = this;
			if (string.IsNullOrEmpty(this.dgvAccounts.Rows[index].Cells[6].Value.ToString()))
			{
				this.pop.pnlSub.Visible = false;
				this.pop.ddlCategory.SelectedValue = this.dgvAccounts.Rows[index].Cells[3].Value.ToString();
				this.pop.ddlCategory.Enabled = false;
				this.pop.rbType2.Checked = true;
				this.pop.rbType1.Checked = false;
			}
			else
			{
				this.pop.pnlSub.Visible = true;
				this.pop.pnlSub.Dock = DockStyle.Top;
				this.pop.ddlSub.SelectedValue = this.dgvAccounts.Rows[index].Cells[0].Value.ToString().Substring(0, 2);
				this.pop.ddlSub.Enabled = false;
				this.pop.rbType2.Checked = false;
				this.pop.rbType1.Checked = true;
			}
		L_039f:
			this.pop.tbName.Text = this.dgvAccounts.Rows[index].Cells[1].Value.ToString();
			this.pop.tbCode.Text = this.dgvAccounts.Rows[index].Cells[0].Value.ToString();
			this.pop.tbCode.ReadOnly = true;
			this.pop.tbBalance.Text = this.dgvAccounts.Rows[index].Cells[5].Value.ToString();
			this.pop.tbBalance.ReadOnly = true;
			this.pop.btnAdd.Text = "حفظ";
			this.pop.edit = true;
			this.pop.Show();
			goto L_039f;
		}
		catch (Exception exception)
		{
			MessageBox.Show(exception.Message);
		}
		if (num1 != 23)
		{
		}
		else
		{
		}
	}

	private void toolStripButton4_Click(object sender, EventArgs e)
	{
		ClientBll clientBll;
		EmployeeBll employeeBll;
		SupplierBll supplierBll;
		try
		{
			if (MessageBox.Show("هل أنت متأكد من حذف الحساب؟") == 1)
			{
				int num1 = Convert.ToInt32(this.dgvAccounts.SelectedRows[0].Cells[0].Value);
				int parent = this.accounts.getParent(num1);
				int num2 = parent;
				if (num2 != 0)
				{
					switch (num2)
					{
						case 0:
						{
							this.accounts.DeleteBankAccount(num1);
							break;
						}
						case 1:
						{
							clientBll = new ClientBll();
							clientBll.deleteClient(num1);
							break;
						}
						case 2:
						{
							employeeBll = new EmployeeBll();
							employeeBll.deleteEmployee(num1);
							break;
						}
						case 32:
						{
							supplierBll = new SupplierBll();
							supplierBll.deleteSupplier(num1);
						}
					}
				}
				else
				{
					this.accounts.DeleteAccount(num1);
				}
				MessageBox.Show("تم الحذف");
				AccountsViewDataTable accountsView = this.accounts.GetAccountsView();
				accountsView.BalanceColumn.ColumnName = "الرصيد";
				accountsView.Category_NameColumn.ColumnName = "نوع الحساب";
				accountsView.GL_IDColumn.ColumnName = "رقم الحساب";
				accountsView.GL_Name_VCColumn.ColumnName = "اسم الحساب";
				accountsView.ParentColumn.ColumnName = "تابع لحساب";
				accountsView.Status_BTColumn.ColumnName = "مفعل";
				this.dgvAccounts.DataSource = accountsView;
				this.dgvAccounts.Columns["BS_Category_VC"].Visible = false;
			}
		}
		catch (Exception exception)
		{
			MessageBox.Show(exception.Message);
		}
	}

	private void tsAdd_Click(object sender, EventArgs e)
	{
		this.pop = new popupAddForm();
		this.pop.accountsForm = this;
		this.pop.Show();
	}

	private void tsExit_Click(object sender, EventArgs e)
	{
		base.Close();
		base.Dispose();
	}

	internal void tsPrint_Click(object sender, EventArgs e)
	{
		ReportDocument reportDocument = new ReportDocument();
		reportDocument.Load(string.Concat(Path.GetDirectoryName(Application.ExecutablePath), "\\AccountsCR.rpt"));
		AccountsViewDataTable accountsView = this.accounts.GetAccountsView();
		reportDocument.SetDataSource(accountsView);
		if (this.printDialog1.ShowDialog() == 1)
		{
			reportDocument.PrintOptions.set_PrinterName(this.printDialog1.PrinterSettings.PrinterName);
			reportDocument.PrintToPrinter(this.printDialog1.PrinterSettings.Copies, this.printDialog1.PrinterSettings.Collate, this.printDialog1.PrinterSettings.MinimumPage, this.printDialog1.PrinterSettings.MaximumPage);
		}
	}
}
}