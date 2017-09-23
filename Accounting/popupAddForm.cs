using System.Windows.Forms;
using System.ComponentModel;
using System;
using Accounting.Client;
using System.Drawing;

namespace Accounting
{
public class popupAddForm : Form
{
	private AccountsBLL accounts;

	public AccountsForm accountsForm;

	internal Button btnAdd;

	private Button btnCancel;

	private IContainer components;

	internal ComboBox ddlCategory;

	internal ComboBox ddlSub;

	public bool edit;

	private Label lblBalance;

	private Label lblCategory;

	private Label lblCode;

	private Label lblName;

	private Label lblSub;

	private Panel pnlAdd;

	internal Panel pnlSub;

	internal Panel pnlType;

	internal RadioButton rbType1;

	internal RadioButton rbType2;

	internal TextBox tbBalance;

	internal TextBox tbCode;

	internal TextBox tbName;

	public popupAddForm()
	{
		this.components = null;
		base();
		this.InitializeComponent();
		this.accounts = new AccountsBLL();
		CategoryDataTable categories = this.accounts.getCategories();
		this.ddlCategory.DataSource = categories;
		this.ddlCategory.DisplayMember = "Category_Name";
		this.ddlCategory.ValueMember = "Category_ID";
		COA_TDataTable mainAccounts = this.accounts.GetMainAccounts();
		this.ddlSub.DataSource = mainAccounts;
		this.ddlSub.DisplayMember = "GL_Name_VC";
		this.ddlSub.ValueMember = "GL_ID";
		int num = Convert.ToInt32(this.ddlCategory.SelectedValue);
		int nextCategoryCode = this.accounts.getNextCategoryCode(num).Text = nextCategoryCode.ToString();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		int? nullable;
		BankBll bankBll;
		popupClient _popupClient;
		try
		{
			string text = this.tbName.Text;
			int num1 = int.Parse(this.tbCode.Text);
			int catgeory = Convert.ToInt32(this.ddlCategory.SelectedValue);
			decimal num2 = decimal.Parse(this.tbBalance.Text);
			new int?(0);
			if (this.rbType1.Checked)
			{
				nullable = new int?(Convert.ToInt32(this.ddlSub.SelectedValue));
				catgeory = this.accounts.getCatgeory(num1);
			}
			if (!this.edit)
			{
				if (catgeory == 1)
				{
					int nextParentCode = this.accounts.getNextParentCode(35);
					this.accounts.InsertFixedAssetAccount(num1, text, catgeory, num2, nullable, nextParentCode);
				}
				else
				{
					if (int valueOrDefault = nullable.GetValueOrDefault().HasValue || valueOrDefault != 0)
					{
						switch (valueOrDefault)
						{
							case 0:
							{
								this.accounts.InsertAccount(num1, text, catgeory, true, num2, nullable);
								bankBll = new BankBll();
								bankBll.insertBank(text, num1, "");
								break;
							}
							case 1:
							{
								_popupClient = new popupClient();
								_popupClient.edit = false;
								_popupClient.clientF = null;
								_popupClient.accForm = this.accountsForm;
								_popupClient.tbAccCode.set_Text(this.tbCode.Text);
								_popupClient.tbEName.set_Text(this.tbName.Text);
								_popupClient.tbBalance.set_Text(this.tbBalance.Text);
								_popupClient.tbBalance.set_Visible(true);
								_popupClient.lblBalance.set_Visible(true);
								_popupClient.set_Text("إضافة عميل");
								_popupClient.Show();
								break;
							}
							case 2:
							{
								break;
							}
							case 32:
							{
								this.accounts.InsertAccount(num1, text, catgeory, true, num2, nullable);
								break;
							}
							default:
							{
								this.accounts.InsertAccount(num1, text, catgeory, true, num2, nullable);
								goto L_0207;
								break;
							}
						}
					}
				}
			}
			else
			{
				if (catgeory == 1)
				{
					this.accounts.UpdateFixedAssetAccount(num1, text);
				}
				else
				{
					this.accounts.UpdateAccount(num1, text, catgeory, true, num2, nullable);
				}
			}
			AccountsViewDataTable accountsView = this.accounts.GetAccountsView();
			accountsView.BalanceColumn.ColumnName = "الرصيد";
			accountsView.Category_NameColumn.ColumnName = "نوع الحساب";
			accountsView.GL_IDColumn.ColumnName = "رقم الحساب";
			accountsView.GL_Name_VCColumn.ColumnName = "اسم الحساب";
			accountsView.ParentColumn.ColumnName = "تابع لحساب";
			accountsView.Status_BTColumn.ColumnName = "مفعل";
			this.accountsForm.dgvAccounts.DataSource = accountsView;
			this.accountsForm.dgvAccounts.Columns["BS_Category_VC"].Visible = false;
			base.Close();
			base.Dispose();
		}
		catch (Exception exception)
		{
			MessageBox.Show(exception.Message);
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		base.Close();
		base.Dispose();
	}

	private void ddlCategory_KeyDown(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		if (keyCode == Keys.Return)
		{
			this.tbCode.Focus();
			goto L_001d;
		}
	L_001d:
	}

	private void ddlCategory_SelectionChangeCommitted(object sender, EventArgs e)
	{
		int num = Convert.ToInt32(this.ddlCategory.SelectedValue);
		int nextCategoryCode = this.accounts.getNextCategoryCode(num).Text = nextCategoryCode.ToString();
	}

	private void ddlSub_KeyDown(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		if (keyCode == Keys.Return)
		{
			this.tbCode.Focus();
			goto L_001d;
		}
	L_001d:
	}

	private void ddlSub_SelectionChangeCommitted(object sender, EventArgs e)
	{
		int num = Convert.ToInt32(this.ddlSub.SelectedValue);
		int nextParentCode = this.accounts.getNextParentCode(num).Text = nextParentCode.ToString();
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
		this.btnAdd = new Button();
		this.btnCancel = new Button();
		this.lblCategory = new Label();
		this.lblCode = new Label();
		this.lblName = new Label();
		this.lblBalance = new Label();
		this.ddlCategory = new ComboBox();
		this.pnlAdd = new Panel();
		this.pnlSub = new Panel();
		this.ddlSub = new ComboBox();
		this.lblSub = new Label();
		this.pnlType = new Panel();
		this.rbType2 = new RadioButton();
		this.rbType1 = new RadioButton();
		this.tbBalance = new TextBox();
		this.tbName = new TextBox();
		this.tbCode = new TextBox();
		this.pnlAdd.SuspendLayout();
		this.pnlSub.SuspendLayout();
		this.pnlType.SuspendLayout();
		base.SuspendLayout();
		this.btnAdd.BackColor = Color.FromArgb(150, 180, 200);
		this.btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.btnAdd.FlatStyle = FlatStyle.Flat;
		this.btnAdd.Location = new Point(38, 216);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new Size(75, 23);
		this.btnAdd.TabIndex = 6;
		this.btnAdd.Text = "إضافة";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.add_Click(new EventHandler(this.btnAdd_Click));
		this.btnCancel.BackColor = Color.FromArgb(150, 180, 200);
		this.btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.btnCancel.FlatStyle = FlatStyle.Flat;
		this.btnCancel.Location = new Point(227, 216);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new Size(75, 23);
		this.btnCancel.TabIndex = 7;
		this.btnCancel.Text = "إلغاء";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.add_Click(new EventHandler(this.btnCancel_Click));
		this.lblCategory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblCategory.AutoSize = true;
		this.lblCategory.ForeColor = SystemColors.ButtonFace;
		this.lblCategory.Location = new Point(223, 76);
		this.lblCategory.Name = "lblCategory";
		this.lblCategory.Size = new Size(62, 13);
		this.lblCategory.TabIndex = 2;
		this.lblCategory.Text = "نوع الحساب";
		this.lblCode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblCode.AutoSize = true;
		this.lblCode.ForeColor = SystemColors.ButtonFace;
		this.lblCode.Location = new Point(223, 110);
		this.lblCode.Name = "lblCode";
		this.lblCode.Size = new Size(64, 13);
		this.lblCode.TabIndex = 3;
		this.lblCode.Text = "رقم الحساب";
		this.lblName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblName.AutoSize = true;
		this.lblName.ForeColor = SystemColors.ButtonFace;
		this.lblName.Location = new Point(223, 136);
		this.lblName.Name = "lblName";
		this.lblName.Size = new Size(69, 13);
		this.lblName.TabIndex = 4;
		this.lblName.Text = "اسم الحساب";
		this.lblBalance.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblBalance.AutoSize = true;
		this.lblBalance.ForeColor = SystemColors.ButtonFace;
		this.lblBalance.Location = new Point(223, 162);
		this.lblBalance.Name = "lblBalance";
		this.lblBalance.Size = new Size(55, 13);
		this.lblBalance.TabIndex = 5;
		this.lblBalance.Text = "رصيد أولي";
		this.ddlCategory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.ddlCategory.FormattingEnabled = true;
		this.ddlCategory.ItemHeight = 13;
		this.ddlCategory.Location = new Point(34, 73);
		this.ddlCategory.Name = "ddlCategory";
		this.ddlCategory.Size = new Size(179, 21);
		this.ddlCategory.TabIndex = 2;
		this.ddlCategory.SelectionChangeCommitted += new EventHandler(this.ddlCategory_SelectionChangeCommitted);
		this.ddlCategory.add_KeyDown(new KeyEventHandler(this.ddlCategory_KeyDown));
		this.pnlAdd.BorderStyle = BorderStyle.Fixed3D;
		this.pnlAdd.Controls.Add(this.pnlSub);
		this.pnlAdd.Controls.Add(this.pnlType);
		this.pnlAdd.Controls.Add(this.tbBalance);
		this.pnlAdd.Controls.Add(this.tbName);
		this.pnlAdd.Controls.Add(this.tbCode);
		this.pnlAdd.Controls.Add(this.lblName);
		this.pnlAdd.Controls.Add(this.ddlCategory);
		this.pnlAdd.Controls.Add(this.lblCategory);
		this.pnlAdd.Controls.Add(this.lblCode);
		this.pnlAdd.Controls.Add(this.lblBalance);
		this.pnlAdd.Dock = DockStyle.Top;
		this.pnlAdd.Location = new Point(0, 0);
		this.pnlAdd.Name = "pnlAdd";
		this.pnlAdd.Size = new Size(338, 210);
		this.pnlAdd.TabIndex = 9;
		this.pnlSub.Controls.Add(this.ddlSub);
		this.pnlSub.Controls.Add(this.lblSub);
		this.pnlSub.Dock = DockStyle.Bottom;
		this.pnlSub.Location = new Point(0, 158);
		this.pnlSub.Name = "pnlSub";
		this.pnlSub.Size = new Size(334, 48);
		this.pnlSub.TabIndex = 13;
		this.pnlSub.Visible = false;
		this.ddlSub.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.ddlSub.FormattingEnabled = true;
		this.ddlSub.Location = new Point(34, 21);
		this.ddlSub.Name = "ddlSub";
		this.ddlSub.Size = new Size(179, 21);
		this.ddlSub.TabIndex = 2;
		this.ddlSub.SelectionChangeCommitted += new EventHandler(this.ddlSub_SelectionChangeCommitted);
		this.ddlSub.add_KeyDown(new KeyEventHandler(this.ddlSub_KeyDown));
		this.lblSub.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblSub.AutoSize = true;
		this.lblSub.ForeColor = SystemColors.ButtonFace;
		this.lblSub.Location = new Point(223, 24);
		this.lblSub.Name = "lblSub";
		this.lblSub.Size = new Size(86, 13);
		this.lblSub.TabIndex = 0;
		this.lblSub.Text = "متفرع من حساب";
		this.pnlType.BorderStyle = BorderStyle.Fixed3D;
		this.pnlType.Controls.Add(this.rbType2);
		this.pnlType.Controls.Add(this.rbType1);
		this.pnlType.Dock = DockStyle.Top;
		this.pnlType.Location = new Point(0, 0);
		this.pnlType.Name = "pnlType";
		this.pnlType.Size = new Size(334, 52);
		this.pnlType.TabIndex = 12;
		this.rbType2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.rbType2.AutoSize = true;
		this.rbType2.Checked = true;
		this.rbType2.ForeColor = SystemColors.ButtonFace;
		this.rbType2.Location = new Point(184, 18);
		this.rbType2.Name = "rbType2";
		this.rbType2.Size = new Size(93, 17);
		this.rbType2.TabIndex = 0;
		this.rbType2.TabStop = true;
		this.rbType2.Text = "حساب رئيسي";
		this.rbType2.UseVisualStyleBackColor = true;
		this.rbType2.CheckedChanged += new EventHandler(this.rbType2_CheckedChanged);
		this.rbType1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.rbType1.AutoSize = true;
		this.rbType1.ForeColor = SystemColors.ButtonFace;
		this.rbType1.Location = new Point(55, 18);
		this.rbType1.Name = "rbType1";
		this.rbType1.Size = new Size(87, 17);
		this.rbType1.TabIndex = 1;
		this.rbType1.Text = "حساب فرعي";
		this.rbType1.UseVisualStyleBackColor = true;
		this.rbType1.CheckedChanged += new EventHandler(this.rbType1_CheckedChanged);
		this.tbBalance.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.tbBalance.Location = new Point(34, 159);
		this.tbBalance.Name = "tbBalance";
		this.tbBalance.Size = new Size(179, 20);
		this.tbBalance.TabIndex = 5;
		this.tbBalance.add_KeyDown(new KeyEventHandler(this.tbBalance_KeyDown));
		this.tbBalance.add_Leave(new EventHandler(this.tbBalance_Leave));
		this.tbName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.tbName.Location = new Point(34, 133);
		this.tbName.Name = "tbName";
		this.tbName.Size = new Size(179, 20);
		this.tbName.TabIndex = 4;
		this.tbName.add_KeyDown(new KeyEventHandler(this.tbName_KeyDown));
		this.tbCode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.tbCode.Location = new Point(34, 107);
		this.tbCode.Name = "tbCode";
		this.tbCode.Size = new Size(179, 20);
		this.tbCode.TabIndex = 3;
		this.tbCode.add_KeyDown(new KeyEventHandler(this.tbCode_KeyDown));
		base.AutoScaleDimensions = new SizeF(6, 13);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.BackColor = SystemColors.ControlDarkDark;
		base.ClientSize = new Size(338, 247);
		base.Controls.Add(this.pnlAdd);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnAdd);
		base.FormBorderStyle = FormBorderStyle.Fixed3D;
		base.MaximizeBox = false;
		base.Name = "popupAddForm";
		base.RightToLeft = RightToLeft.Yes;
		base.RightToLeftLayout = true;
		base.StartPosition = FormStartPosition.CenterScreen;
		base.Text = "إضافة حساب جديد";
		base.Load += new EventHandler(this.popupAddForm_Load);
		this.pnlAdd.ResumeLayout(false);
		this.pnlAdd.PerformLayout();
		this.pnlSub.ResumeLayout(false);
		this.pnlSub.PerformLayout();
		this.pnlType.ResumeLayout(false);
		this.pnlType.PerformLayout();
		base.ResumeLayout(false);
	}

	private void popupAddForm_Load(object sender, EventArgs e)
	{
	}

	private void rbType1_CheckedChanged(object sender, EventArgs e)
	{
		if (this.rbType1.Checked)
		{
			int num = Convert.ToInt32(this.ddlSub.SelectedValue);
			int nextParentCode = this.accounts.getNextParentCode(num).Text = nextParentCode.ToString();
		}
	}

	private void rbType2_CheckedChanged(object sender, EventArgs e)
	{
		if (this.rbType2.Checked)
		{
			this.pnlSub.Visible = false;
			int num = Convert.ToInt32(this.ddlCategory.SelectedValue);
			int nextCategoryCode = this.accounts.getNextCategoryCode(num).Text = nextCategoryCode.ToString();
		}
		else
		{
			this.pnlSub.Visible = true;
			this.pnlSub.Dock = DockStyle.Top;
		}
	}

	private void tbBalance_KeyDown(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		if (keyCode == Keys.Return)
		{
			this.btnAdd.Focus();
			goto L_001d;
		}
	L_001d:
	}

	private void tbBalance_Leave(object sender, EventArgs e)
	{
		decimal num;
		if (!string.IsNullOrEmpty(this.tbBalance.Text) && !decimal.TryParse(this.tbBalance.Text, ref num))
		{
			MessageBox.Show("Invalid input");
			this.tbBalance.Focus();
		}
	}

	private void tbCode_KeyDown(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		if (keyCode == Keys.Return)
		{
			this.tbName.Focus();
			goto L_001d;
		}
	L_001d:
	}

	private void tbName_KeyDown(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		if (keyCode == Keys.Return)
		{
			this.tbBalance.Focus();
			goto L_001d;
		}
	L_001d:
	}
}
}