using System.Windows.Forms;
using System;
using System.ComponentModel;
using Accounting;
using System.Drawing;
using Accounting.Properties;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;
using CrystalDecisions.Shared;

namespace Accounting.Vouchers
{
public class DepositForm : Form
{
	private AccountsBLL _accounts;

	private CashBll _cash;

	private bool _closed;

	internal bool _directed;

	private static Mode _mode;

	private popupAccounts _popAcc;

	private static bool _print;

	internal int _vNum;

	internal VoucherBll _voucher;

	internal static int _voucherID;

	private Button button1;

	private CheckBox cbType;

	private IContainer components;

	private ComboBox ddlBank;

	private DateTimePicker dtpDate;

	private Label label1;

	private Label lblAmount;

	private Label lblBank;

	private Label lblcheck;

	private Label lblCode;

	private Label lblDate;

	internal Label lblName;

	private Label lblNote;

	private Label lblType;

	private Label lblVNumber;

	private Panel pnlButtons;

	private Panel pnlDeposit;

	private Panel pnlHeader;

	private Panel pnlMain;

	private Panel pnlSpace;

	private Panel pnlType;

	private PrintDialog printDialog1;

	internal TextBox tbAmount;

	private TextBox tbCheck;

	internal TextBox tbCode;

	internal TextBox tbName;

	private TextBox tbNote;

	private TextBox tbVNumber;

	private ToolTip toolTip1;

	private Button tsAdd;

	private Button tsCreat;

	private Button tsEdit;

	private Button tsExit;

	private Button tsPrint;

	public DepositForm()
	{
		this.components = null;
		base();
		this.InitializeComponent();
		this._accounts = new AccountsBLL();
		this._cash = new CashBll();
		this._voucher = new VoucherBll();
		DepositForm._mode = Mode.Null;
		DepositForm._print = 0;
		this._closed = false;
		this._directed = false;
	}

	private void button1_Click(object sender, EventArgs e)
	{
		this._popAcc = new popupAccounts();
		this._popAcc.depositForm = this;
		this._popAcc.Show();
	}

	private void canPrint(bool print)
	{
		this.tsPrint.Enabled = print;
		(Form1)this.MdiParent.tsPreview.Enabled = print;
		(Form1)this.MdiParent.tsPrint.Enabled = print;
	}

	private void cbType_CheckedChanged(object sender, EventArgs e)
	{
		if (this.cbType.Checked)
		{
			this.pnlType.Visible = true;
			Size size.Width.Size = new Size(size = this.pnlType.Size, size.Height);
		}
		else
		{
			this.pnlType.Visible = false;
		}
	}

	private void cbType_KeyDown(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		if (keyCode != Keys.Return && keyCode == Keys.Up || this.cbType.Checked)
		{
			this.tbCheck.Focus();
		}
	L_0044:
	}

	private bool checkValidity()
	{
		int num1 = 0;
		decimal num2;
		if (int.TryParse(this.tbCode.Text, ref num1))
		{
		}
		if (!decimal.TryParse(this.tbAmount.Text, ref num2) || this.cbType.Checked && !int.TryParse(this.tbCheck.Text, ref num1))
		{
			MessageBox.Show("خطأ في المعلومات المزودة ", "خطأ في الادخال");
			return false;
		}
		return true;
	}

	private void ddlBank_KeyDown(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		if (keyCode != Keys.Return)
		{
			switch (keyCode)
			{
				case Keys.LButton:
				{
					this.tbCheck.Focus();
					break;
				}
			}
		}
		else
		{
			this.tsCreat.Focus();
		}
	}

	private void Deposit_KeyDown(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		if (keyCode != Keys.A && keyCode == Keys.E || keyCode != Keys.X)
		{
			if (e.Control)
			{
				this.tsCreat_Click(sender, e);
			}
			if (e.Control)
			{
				this.tsEdit_Click(sender, e);
			}
		}
	L_0067:
	}

	private void Deposit_Load(object sender, EventArgs e)
	{
		base.KeyDown += new KeyEventHandler(this.Deposit_KeyDown);
		BankBll bankBll = new BankBll();
		this.ddlBank.DataSource = bankBll.getBanks();
		this.ddlBank.ValueMember = "AccCode";
		this.ddlBank.DisplayMember = "Name";
		DepositForm._print = 0;
		DepositForm._voucherID = 0;
		COA_TDataTable allAccounts = this._accounts.GetAllAccounts();
		string[] array = allAccounts.Select<COA_TRow,string>(new Func<COA_TRow, string>((a) => a.GL_Name_VC)).ToArray<string>();
		AutoCompleteStringCollection autoCompleteStringCollections1 = new AutoCompleteStringCollection();
		for (int i = 0; i < array.Count<string>(); i++)
		{
			autoCompleteStringCollections1.Add(array[i]);
		}
		this.tbName.AutoCompleteSource = AutoCompleteSource.CustomSource;
		this.tbName.AutoCompleteMode = AutoCompleteMode.Suggest;
		this.tbName.AutoCompleteCustomSource = autoCompleteStringCollections1;
		int[] numArray = allAccounts.Select<COA_TRow,int>(new Func<COA_TRow, int>((a) => a.GL_ID)).ToArray<int>();
		AutoCompleteStringCollection autoCompleteStringCollections2 = new AutoCompleteStringCollection();
		for (i = 0; i < numArray.Count<int>(); i++)
		{
			autoCompleteStringCollections2.Add(numArray[i].ToString());
		}
		this.tbCode.AutoCompleteSource = AutoCompleteSource.CustomSource;
		this.tbCode.AutoCompleteMode = AutoCompleteMode.Suggest;
		this.tbCode.AutoCompleteCustomSource = autoCompleteStringCollections2;
		base.WindowState = FormWindowState.Maximized;
		this.canPrint(false);
		this.tsCreat.Select();
		if (this._directed != 0)
		{
			this.tsEdit_Click(sender, e);
			this.tbVNumber.Text = &this._vNum.ToString();
			this.tbVNumber_Leave(sender, e);
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

	private void dtpDate_KeyDown(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		if (keyCode == Keys.Return || keyCode != Keys.Right)
		{
			this.tbName.Focus();
		}
	L_0030:
	}

	private void InitializeComponent()
	{
		this.components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(DepositForm));
		this.label1 = new Label();
		this.pnlDeposit = new Panel();
		this.pnlHeader = new Panel();
		this.dtpDate = new DateTimePicker();
		this.tbVNumber = new TextBox();
		this.lblDate = new Label();
		this.lblVNumber = new Label();
		this.lblName = new Label();
		this.lblCode = new Label();
		this.lblAmount = new Label();
		this.lblNote = new Label();
		this.lblType = new Label();
		this.lblcheck = new Label();
		this.pnlMain = new Panel();
		this.button1 = new Button();
		this.tbAmount = new TextBox();
		this.tbCode = new TextBox();
		this.tbNote = new TextBox();
		this.tbName = new TextBox();
		this.pnlType = new Panel();
		this.ddlBank = new ComboBox();
		this.lblBank = new Label();
		this.tbCheck = new TextBox();
		this.cbType = new CheckBox();
		this.pnlSpace = new Panel();
		this.pnlButtons = new Panel();
		this.tsExit = new Button();
		this.tsPrint = new Button();
		this.tsAdd = new Button();
		this.tsEdit = new Button();
		this.tsCreat = new Button();
		this.printDialog1 = new PrintDialog();
		this.toolTip1 = new ToolTip(this.components);
		this.pnlDeposit.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		this.pnlMain.SuspendLayout();
		this.pnlType.SuspendLayout();
		this.pnlSpace.SuspendLayout();
		this.pnlButtons.SuspendLayout();
		base.SuspendLayout();
		this.label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.label1.AutoSize = true;
		this.label1.BackColor = SystemColors.Control;
		this.label1.Font = new Font("Sakkal Majalla", 20.25, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.label1.ForeColor = Color.SteelBlue;
		this.label1.Location = new Point(98, 10);
		this.label1.Name = "label1";
		this.label1.Size = new Size(99, 35);
		this.label1.TabIndex = 0;
		this.label1.Text = "سند قبض";
		this.pnlDeposit.BackColor = Color.SteelBlue;
		this.pnlDeposit.BorderStyle = BorderStyle.Fixed3D;
		this.pnlDeposit.Controls.Add(this.label1);
		this.pnlDeposit.Dock = DockStyle.Top;
		this.pnlDeposit.Location = new Point(0, 0);
		this.pnlDeposit.Name = "pnlDeposit";
		this.pnlDeposit.Size = new Size(762, 60);
		this.pnlDeposit.TabIndex = 1;
		this.pnlHeader.BorderStyle = BorderStyle.FixedSingle;
		this.pnlHeader.Controls.Add(this.dtpDate);
		this.pnlHeader.Controls.Add(this.tbVNumber);
		this.pnlHeader.Controls.Add(this.lblDate);
		this.pnlHeader.Controls.Add(this.lblVNumber);
		this.pnlHeader.Dock = DockStyle.Top;
		this.pnlHeader.Enabled = false;
		this.pnlHeader.Location = new Point(0, 60);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new Size(762, 49);
		this.pnlHeader.TabIndex = 12;
		this.dtpDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.dtpDate.Location = new Point(59, 14);
		this.dtpDate.Name = "dtpDate";
		this.dtpDate.RightToLeftLayout = true;
		this.dtpDate.Size = new Size(200, 20);
		this.dtpDate.TabIndex = 2;
		this.dtpDate.add_KeyDown(new KeyEventHandler(this.dtpDate_KeyDown));
		this.tbVNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.tbVNumber.Location = new Point(480, 14);
		this.tbVNumber.Name = "tbVNumber";
		this.tbVNumber.Size = new Size(157, 20);
		this.tbVNumber.TabIndex = 1;
		this.tbVNumber.add_KeyDown(new KeyEventHandler(this.tbVNumber_KeyDown));
		this.tbVNumber.add_Leave(new EventHandler(this.tbVNumber_Leave));
		this.lblDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblDate.AutoSize = true;
		this.lblDate.ForeColor = SystemColors.ButtonFace;
		this.lblDate.Location = new Point(286, 17);
		this.lblDate.Name = "lblDate";
		this.lblDate.Size = new Size(35, 13);
		this.lblDate.TabIndex = 1;
		this.lblDate.Text = "التاريخ";
		this.lblVNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblVNumber.AutoSize = true;
		this.lblVNumber.ForeColor = SystemColors.ButtonFace;
		this.lblVNumber.Location = new Point(669, 17);
		this.lblVNumber.Name = "lblVNumber";
		this.lblVNumber.Size = new Size(80, 13);
		this.lblVNumber.TabIndex = 0;
		this.lblVNumber.Text = "رقم سند القبض";
		this.lblName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		this.lblName.AutoSize = true;
		this.lblName.ForeColor = SystemColors.ButtonFace;
		this.lblName.Location = new Point(601, 45);
		this.lblName.Name = "lblName";
		this.lblName.Size = new Size(132, 13);
		this.lblName.TabIndex = 3;
		this.lblName.Text = "استلمنا من السيد / السادة";
		this.lblCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		this.lblCode.AutoSize = true;
		this.lblCode.ForeColor = SystemColors.ButtonFace;
		this.lblCode.Location = new Point(609, 92);
		this.lblCode.Name = "lblCode";
		this.lblCode.Size = new Size(64, 13);
		this.lblCode.TabIndex = 4;
		this.lblCode.Text = "رقم الحساب";
		this.lblAmount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		this.lblAmount.AutoSize = true;
		this.lblAmount.ForeColor = SystemColors.ButtonFace;
		this.lblAmount.Location = new Point(609, 132);
		this.lblAmount.Name = "lblAmount";
		this.lblAmount.Size = new Size(64, 13);
		this.lblAmount.TabIndex = 5;
		this.lblAmount.Text = "مبـــلغ وقدره";
		this.lblNote.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		this.lblNote.AutoSize = true;
		this.lblNote.ForeColor = SystemColors.ButtonFace;
		this.lblNote.Location = new Point(608, 172);
		this.lblNote.Name = "lblNote";
		this.lblNote.Size = new Size(65, 13);
		this.lblNote.TabIndex = 6;
		this.lblNote.Text = "وذلــك عــــن";
		this.lblType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		this.lblType.AutoSize = true;
		this.lblType.ForeColor = SystemColors.ButtonFace;
		this.lblType.Location = new Point(609, 242);
		this.lblType.Name = "lblType";
		this.lblType.Size = new Size(61, 13);
		this.lblType.TabIndex = 7;
		this.lblType.Text = "شيــــــــــك";
		this.lblcheck.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblcheck.AutoSize = true;
		this.lblcheck.ForeColor = SystemColors.ButtonFace;
		this.lblcheck.Location = new Point(673, 27);
		this.lblcheck.Name = "lblcheck";
		this.lblcheck.Size = new Size(58, 13);
		this.lblcheck.TabIndex = 8;
		this.lblcheck.Text = "رقم الشيك";
		this.pnlMain.Controls.Add(this.button1);
		this.pnlMain.Controls.Add(this.tbAmount);
		this.pnlMain.Controls.Add(this.tbCode);
		this.pnlMain.Controls.Add(this.tbNote);
		this.pnlMain.Controls.Add(this.tbName);
		this.pnlMain.Controls.Add(this.pnlType);
		this.pnlMain.Controls.Add(this.cbType);
		this.pnlMain.Controls.Add(this.lblAmount);
		this.pnlMain.Controls.Add(this.lblCode);
		this.pnlMain.Controls.Add(this.lblName);
		this.pnlMain.Controls.Add(this.lblNote);
		this.pnlMain.Controls.Add(this.lblType);
		this.pnlMain.Dock = DockStyle.Fill;
		this.pnlMain.Enabled = false;
		this.pnlMain.Location = new Point(0, 109);
		this.pnlMain.Name = "pnlMain";
		this.pnlMain.Size = new Size(762, 371);
		this.pnlMain.TabIndex = 10;
		this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.button1.FlatAppearance.BorderColor = SystemColors.ButtonFace;
		this.button1.FlatStyle = FlatStyle.Flat;
		this.button1.Image = Resources.Browse;
		this.button1.Location = new Point(306, 45);
		this.button1.Name = "button1";
		this.button1.Size = new Size(21, 20);
		this.button1.TabIndex = 11;
		this.button1.UseVisualStyleBackColor = true;
		this.button1.add_Click(new EventHandler(this.button1_Click));
		this.tbAmount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		this.tbAmount.Location = new Point(333, 129);
		this.tbAmount.Name = "tbAmount";
		this.tbAmount.Size = new Size(261, 20);
		this.tbAmount.TabIndex = 5;
		this.tbAmount.add_KeyDown(new KeyEventHandler(this.tbAmount_KeyDown));
		this.tbCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		this.tbCode.Location = new Point(333, 85);
		this.tbCode.Name = "tbCode";
		this.tbCode.Size = new Size(261, 20);
		this.tbCode.TabIndex = 4;
		this.tbCode.add_KeyDown(new KeyEventHandler(this.tbCode_KeyDown));
		this.tbCode.add_Leave(new EventHandler(this.tbCode_Leave));
		this.tbNote.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.tbNote.Location = new Point(333, 172);
		this.tbNote.Name = "tbNote";
		this.tbNote.Size = new Size(261, 20);
		this.tbNote.TabIndex = 6;
		this.tbNote.add_KeyDown(new KeyEventHandler(this.tbNote_KeyDown));
		this.tbName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		this.tbName.AutoCompleteMode = AutoCompleteMode.Suggest;
		this.tbName.Location = new Point(333, 45);
		this.tbName.Name = "tbName";
		this.tbName.Size = new Size(261, 20);
		this.tbName.TabIndex = 3;
		this.tbName.add_KeyDown(new KeyEventHandler(this.tbName_KeyDown));
		this.tbName.add_Leave(new EventHandler(this.tbName_Leave));
		this.pnlType.BorderStyle = BorderStyle.FixedSingle;
		this.pnlType.Controls.Add(this.ddlBank);
		this.pnlType.Controls.Add(this.lblBank);
		this.pnlType.Controls.Add(this.tbCheck);
		this.pnlType.Controls.Add(this.lblcheck);
		this.pnlType.Location = new Point(0, 273);
		this.pnlType.Name = "pnlType";
		this.pnlType.Size = new Size(762, 78);
		this.pnlType.TabIndex = 10;
		this.pnlType.Visible = false;
		this.ddlBank.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.ddlBank.FormattingEnabled = true;
		this.ddlBank.Location = new Point(58, 26);
		this.ddlBank.Name = "ddlBank";
		this.ddlBank.Size = new Size(177, 21);
		this.ddlBank.TabIndex = 9;
		this.ddlBank.add_KeyDown(new KeyEventHandler(this.ddlBank_KeyDown));
		this.lblBank.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblBank.AutoSize = true;
		this.lblBank.ForeColor = SystemColors.ButtonFace;
		this.lblBank.Location = new Point(272, 30);
		this.lblBank.Name = "lblBank";
		this.lblBank.Size = new Size(48, 13);
		this.lblBank.TabIndex = 10;
		this.lblBank.Text = "على بنك";
		this.tbCheck.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.tbCheck.Location = new Point(402, 27);
		this.tbCheck.Name = "tbCheck";
		this.tbCheck.Size = new Size(177, 20);
		this.tbCheck.TabIndex = 8;
		this.tbCheck.add_KeyDown(new KeyEventHandler(this.tbCheck_KeyDown));
		this.cbType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		this.cbType.AutoSize = true;
		this.cbType.Location = new Point(579, 242);
		this.cbType.Name = "cbType";
		this.cbType.Size = new Size(15, 14);
		this.cbType.TabIndex = 7;
		this.cbType.UseVisualStyleBackColor = true;
		this.cbType.CheckedChanged += new EventHandler(this.cbType_CheckedChanged);
		this.cbType.add_KeyDown(new KeyEventHandler(this.cbType_KeyDown));
		this.pnlSpace.Controls.Add(this.pnlButtons);
		this.pnlSpace.Dock = DockStyle.Bottom;
		this.pnlSpace.Location = new Point(0, 480);
		this.pnlSpace.Name = "pnlSpace";
		this.pnlSpace.Size = new Size(762, 87);
		this.pnlSpace.TabIndex = 11;
		this.pnlButtons.BackColor = SystemColors.Control;
		this.pnlButtons.Controls.Add(this.tsExit);
		this.pnlButtons.Controls.Add(this.tsPrint);
		this.pnlButtons.Controls.Add(this.tsAdd);
		this.pnlButtons.Controls.Add(this.tsEdit);
		this.pnlButtons.Controls.Add(this.tsCreat);
		this.pnlButtons.Dock = DockStyle.Top;
		this.pnlButtons.Location = new Point(0, 0);
		this.pnlButtons.Name = "pnlButtons";
		this.pnlButtons.Size = new Size(762, 37);
		this.pnlButtons.TabIndex = 18;
		this.tsExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.tsExit.BackColor = Color.FromArgb(150, 180, 200);
		this.tsExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.tsExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.tsExit.FlatStyle = FlatStyle.Flat;
		this.tsExit.Image = Resources.Exit;
		this.tsExit.ImageAlign = ContentAlignment.MiddleLeft;
		this.tsExit.Location = new Point(306, 6);
		this.tsExit.Name = "tsExit";
		this.tsExit.Size = new Size(84, 27);
		this.tsExit.TabIndex = 4;
		this.tsExit.Text = "خروج";
		this.tsExit.TextImageRelation = TextImageRelation.ImageBeforeText;
		this.tsExit.UseVisualStyleBackColor = false;
		this.tsExit.add_Click(new EventHandler(this.tsExit_Click));
		this.tsPrint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.tsPrint.BackColor = Color.FromArgb(150, 180, 200);
		this.tsPrint.Enabled = false;
		this.tsPrint.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.tsPrint.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.tsPrint.FlatStyle = FlatStyle.Flat;
		this.tsPrint.Image = Resources.Print;
		this.tsPrint.ImageAlign = ContentAlignment.MiddleLeft;
		this.tsPrint.Location = new Point(396, 6);
		this.tsPrint.Name = "tsPrint";
		this.tsPrint.Size = new Size(84, 27);
		this.tsPrint.TabIndex = 3;
		this.tsPrint.Text = "طباعة";
		this.tsPrint.TextImageRelation = TextImageRelation.ImageBeforeText;
		this.toolTip1.SetToolTip(this.tsPrint, "طباعة السند");
		this.tsPrint.UseVisualStyleBackColor = false;
		this.tsPrint.add_Click(new EventHandler(this.tsPrint_Click));
		this.tsAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.tsAdd.BackColor = Color.FromArgb(150, 180, 200);
		this.tsAdd.Enabled = false;
		this.tsAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.tsAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.tsAdd.FlatStyle = FlatStyle.Flat;
		this.tsAdd.Image = (Image)componentResourceManager.GetObject("tsAdd.Image");
		this.tsAdd.ImageAlign = ContentAlignment.MiddleLeft;
		this.tsAdd.Location = new Point(486, 6);
		this.tsAdd.Name = "tsAdd";
		this.tsAdd.Size = new Size(84, 27);
		this.tsAdd.TabIndex = 2;
		this.tsAdd.Text = "حفظ";
		this.tsAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
		this.toolTip1.SetToolTip(this.tsAdd, "حفظ السند");
		this.tsAdd.UseVisualStyleBackColor = false;
		this.tsAdd.add_Click(new EventHandler(this.tsAdd_Click));
		this.tsEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.tsEdit.BackColor = Color.FromArgb(150, 180, 200);
		this.tsEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.tsEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.tsEdit.FlatStyle = FlatStyle.Flat;
		this.tsEdit.Image = Resources.Edit;
		this.tsEdit.ImageAlign = ContentAlignment.MiddleLeft;
		this.tsEdit.Location = new Point(576, 6);
		this.tsEdit.Name = "tsEdit";
		this.tsEdit.Size = new Size(84, 27);
		this.tsEdit.TabIndex = 1;
		this.tsEdit.Text = "تعديل";
		this.tsEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
		this.toolTip1.SetToolTip(this.tsEdit, "تعديل سند سابق");
		this.tsEdit.UseVisualStyleBackColor = false;
		this.tsEdit.add_Click(new EventHandler(this.tsEdit_Click));
		this.tsCreat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.tsCreat.BackColor = Color.FromArgb(150, 180, 200);
		this.tsCreat.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.tsCreat.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.tsCreat.FlatStyle = FlatStyle.Flat;
		this.tsCreat.Image = Resources.Add;
		this.tsCreat.ImageAlign = ContentAlignment.MiddleLeft;
		this.tsCreat.Location = new Point(666, 6);
		this.tsCreat.Name = "tsCreat";
		this.tsCreat.Size = new Size(84, 27);
		this.tsCreat.TabIndex = 0;
		this.tsCreat.Text = "إضافة";
		this.tsCreat.TextImageRelation = TextImageRelation.ImageBeforeText;
		this.toolTip1.SetToolTip(this.tsCreat, "إضافة سند جديد");
		this.tsCreat.UseVisualStyleBackColor = false;
		this.tsCreat.add_Click(new EventHandler(this.tsCreat_Click));
		this.printDialog1.UseEXDialog = true;
		base.AutoScaleDimensions = new SizeF(6, 13);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.BackColor = SystemColors.ControlDarkDark;
		base.ClientSize = new Size(762, 567);
		base.Controls.Add(this.pnlMain);
		base.Controls.Add(this.pnlSpace);
		base.Controls.Add(this.pnlHeader);
		base.Controls.Add(this.pnlDeposit);
		base.FormBorderStyle = FormBorderStyle.Fixed3D;
		base.KeyPreview = true;
		base.Name = "DepositForm";
		base.RightToLeft = RightToLeft.Yes;
		base.RightToLeftLayout = true;
		base.ShowIcon = false;
		base.Text = "سند قبض";
		base.Load += new EventHandler(this.Deposit_Load);
		base.KeyDown += new KeyEventHandler(this.Deposit_KeyDown);
		this.pnlDeposit.ResumeLayout(false);
		this.pnlDeposit.PerformLayout();
		this.pnlHeader.ResumeLayout(false);
		this.pnlHeader.PerformLayout();
		this.pnlMain.ResumeLayout(false);
		this.pnlMain.PerformLayout();
		this.pnlType.ResumeLayout(false);
		this.pnlType.PerformLayout();
		this.pnlSpace.ResumeLayout(false);
		this.pnlButtons.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void ResetControls()
	{
		this.tbVNumber.Text = "";
		this.tbVNumber.Focus();
		DateTime now = DateTime.Now.Text = now.ToShortDateString();
		this.tbCode.Text = "";
		this.tbName.Text = "";
		this.tbAmount.Text = "";
		this.tbNote.Text = "";
		this.cbType.Checked = false;
		this.tbCheck.Text = "";
		this.tbVNumber.Enabled = true;
		this.dtpDate.Enabled = true;
		if (this.ddlBank.Items.Count > 0)
		{
			this.ddlBank.SelectedIndex = 0;
		}
	}

	private void tbAmount_KeyDown(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		if (keyCode == Keys.Return || keyCode != Keys.Up)
		{
			this.tbNote.Focus();
		}
	L_0030:
	}

	private void tbCheck_KeyDown(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		if (keyCode == Keys.Return || keyCode != Keys.Up)
		{
			this.ddlBank.Focus();
		}
	L_0030:
	}

	private void tbCode_KeyDown(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		if (keyCode != Keys.Return && keyCode == Keys.Up || keyCode != Keys.F1)
		{
			this.tbAmount.Focus();
			this.tbName.Focus();
		}
	L_005a:
	}

	private void tbCode_Leave(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(this.tbCode.Text))
		{
			int num = Convert.ToInt32(this.tbCode.Text);
			COA_TDataTable accountByID = this._accounts.GetAccountByID(num);
			this.tbName.Text = accountByID.Select<COA_TRow,string>(new Func<COA_TRow, string>((a) => a.GL_Name_VC)).Max<string>();
			MessageBox.Show("خطأ في رقم الحساب");
		}
		try
		{
		}
		catch
		{
		}
	}

	private void tbName_KeyDown(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		if (keyCode != Keys.Return && keyCode == Keys.Up || keyCode != Keys.F1)
		{
			this.tbCode.Focus();
			this.tbVNumber.Focus();
		}
	L_005a:
	}

	private void tbName_Leave(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(this.tbName.Text))
		{
			string text = this.tbName.Text;
			int accountNumber = this._accounts.getAccountNumber(text);
			this.tbCode.Text = accountNumber.ToString();
			MessageBox.Show("خطأ في اسم الحساب");
			this.tbName.Focus();
		}
		try
		{
		}
		catch
		{
		}
	}

	private void tbNote_KeyDown(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		if (keyCode == Keys.Return || keyCode != Keys.Up)
		{
			this.cbType.Focus();
		}
	L_0030:
	}

	private void tbVNumber_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode != 13 || this.dtpDate.Enabled)
		{
			this.dtpDate.Focus();
		}
	}

	private void tbVNumber_Leave(object sender, EventArgs e)
	{
		bool str = string.IsNullOrEmpty(this.tbVNumber.Text) || DepositForm._mode != Mode.Edit || this._closed;
		try
		{
			int num1 = Convert.ToInt32(this.tbVNumber.Text);
			string voucherType = this._voucher.getVoucherType(num1);
			str = !(voucherType == 0.ToString());
			if (!str)
			{
				VoucherDataTable voucher = this._voucher.getVoucher(num1);
				DateTime dateDT = voucher[0].Date_DT.Text = dateDT.ToShortDateString();
				int cAcc = voucher[0].CAcc.Text = cAcc.ToString();
				this.tbName.Text = voucher[0].CName;
				decimal amountNU = voucher[0].Amount_NU.Text = amountNU.ToString();
				this.tbNote.Text = voucher[0].Descrip_VC;
				this.cbType.Checked = (!voucher[0].chkNumber ? 0 : 1);
				str = !this.cbType.Checked;
				if (!str)
				{
					cAcc = voucher[0].chkNumber.Text = cAcc.ToString();
					this.ddlBank.SelectedValue = voucher[0].DAcc;
				}
				DepositForm._print = 1;
				DepositForm._voucherID = Convert.ToInt32(this.tbVNumber.Text);
				this.tbVNumber.Enabled = false;
				this.dtpDate.Enabled = false;
			}
			else
			{
				str = !(voucherType == 1.ToString());
				if (!str)
				{
					str = MessageBox.Show("نوع السند - سند صرف - هل تريد تحريره؟", "سند صرف", MessageBoxButtons.YesNo) != 6;
					if (!str)
					{
						WithdrawalForm withdrawalForm = new WithdrawalForm();
						Form mdiParent = base.MdiParent;
						this._closed = true;
						Form[] mdiChildren = mdiParent.MdiChildren;
						int num2 = 0;
						while (str)
						{
							Form form = mdiChildren[num2];
							form.Close();
							form.Dispose();
							num2++;
							str = num2 < (int)mdiChildren.Length;
						}
						withdrawalForm.MdiParent = mdiParent;
						withdrawalForm._directed = true;
						withdrawalForm._vNum = num1;
						withdrawalForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
						withdrawalForm.Dock = DockStyle.Fill;
						withdrawalForm.Show();
					}
				}
				str = !(voucherType == 2.ToString());
				if (!str)
				{
					MessageBox.Show("قيد يومي. لا يمكن التعديل", "قيد يومي");
					this.tbVNumber.Text = "";
					this.tbVNumber.Focus();
				}
			}
		}
		catch
		{
			MessageBox.Show("خطأ في رقم السند - غير موجود");
		}
	}

	private void tsAdd_Click(object sender, EventArgs e)
	{
		int num1;
		int? nullable1;
		int? nullable2;
		int num2;
		DateTime dateTime;
		if (!this.checkValidity())
		{
			this.tbName.Focus();
		}
		else
		{
			int num3 = Convert.ToInt32(this.tbCode.Text);
			decimal num4 = Convert.ToDecimal(this.tbAmount.Text);
			string text = this.tbNote.Text;
			if (!string.IsNullOrEmpty(this.tbCode.Text) && !string.IsNullOrEmpty(this.tbName.Text) && !string.IsNullOrEmpty(this.tbAmount.Text))
			{
				BankBll bankBll = new BankBll();
				new int?(Convert.ToInt32(this.tbCheck.Text));
				new int?(num1 = Convert.ToInt32(this.ddlBank.SelectedValue));
			}
			else
			{
				nullable1 = null;
				nullable2 = null;
				num1 = 21;
			}
			if (this.cbType.Checked)
			{
				MessageBox.Show("أحد الحسابات هو حساب رئيسي .. لايمكن اختياره");
			}
			else
			{
				switch (DepositForm._mode)
				{
					case Mode.New:
					{
						num2 = this._cash.getNewVoucher();
						num2.insertVoucher(num1, num3, num4, 0.ToString(), nullable2, nullable1, 2, text, dateTime = DateTime.Now, dateTime.Date);
						MessageBox.Show("تم حفظ السند");
						DepositForm._mode = 1;
						DepositForm._print = 1;
						DepositForm._voucherID = num2;
						this.canPrint(true);
						MessageBox.Show(exception.Message);
						break;
					}
				}
				try
				{
					VoucherDataTable voucher = this._voucher.getVoucher(Convert.ToInt32(this.tbVNumber.Text));
					this._voucher.updateVoucher(int.Parse(this.tbVNumber.Text), num1, voucher[0].DAcc, num3, voucher[0].CAcc, voucher[0].Amount_NU, num4, text, nullable1, nullable2);
					MessageBox.Show("تم التعديل");
					DepositForm._print = 1;
					DepositForm._voucherID = int.Parse(this.tbVNumber.Text);
					this.canPrint(true);
				}
				catch (Exception exception)
				{
					MessageBox.Show(exception.Message);
				}
				goto L_0276;
			L_0276:
				break;
				MessageBox.Show("الرجاء اضافة المعلومات");
			}
		}
	}

	private void tsCreat_Click(object sender, EventArgs e)
	{
		this.ResetControls();
		DepositForm._mode = Mode.New;
		int newVoucher = this._cash.getNewVoucher().Text = newVoucher.ToString();
		DateTime now = DateTime.Now.Text = now.ToShortDateString();
		DepositForm._print = 0;
		DepositForm._voucherID = 0;
		this.pnlHeader.Enabled = true;
		this.pnlMain.Enabled = true;
		this.tsAdd.Enabled = true;
		this.tbName.Focus();
	}

	private void tsEdit_Click(object sender, EventArgs e)
	{
		DepositForm._mode = Mode.Edit;
		this.ResetControls();
		this.dtpDate.Text = "";
		this.pnlHeader.Enabled = true;
		this.pnlMain.Enabled = true;
		this.tsAdd.Enabled = true;
		this.tbVNumber.Focus();
	}

	private void tsExit_Click(object sender, EventArgs e)
	{
		base.Close();
		base.Dispose();
	}

	internal void tsPrint_Click(object sender, EventArgs e)
	{
		if (DepositForm._print != 0)
		{
			if (this.printDialog1.ShowDialog() == 1)
			{
				VoucherDataTable voucher = this._voucher.getVoucher(DepositForm._voucherID);
				ReportDocument reportDocument = new ReportDocument();
				reportDocument.Load(string.Concat(Path.GetDirectoryName(Application.ExecutablePath), "\\VoucherCR.rpt"));
				ParameterValues parameterValue1 = new ParameterValues();
				ParameterDiscreteValue parameterDiscreteValue1 = new ParameterDiscreteValue();
				parameterDiscreteValue1.set_Value("سند قبض");
				parameterValue1.Add(parameterDiscreteValue1);
				reportDocument.DataDefinition.ParameterFields["title"].ApplyCurrentValues(parameterValue1);
				ParameterValues parameterValue2 = new ParameterValues();
				ParameterDiscreteValue parameterDiscreteValue2 = new ParameterDiscreteValue();
				parameterDiscreteValue2.set_Value(this.lblName.Text);
				parameterValue2.Add(parameterDiscreteValue2);
				reportDocument.DataDefinition.ParameterFields["lblAccName"].ApplyCurrentValues(parameterValue2);
				ParameterValues parameterValue3 = new ParameterValues();
				ParameterDiscreteValue parameterDiscreteValue3 = new ParameterDiscreteValue();
				parameterDiscreteValue3.set_Value(voucher[0].CName);
				parameterValue3.Add(parameterDiscreteValue3);
				reportDocument.DataDefinition.ParameterFields["AccName"].ApplyCurrentValues(parameterValue3);
				ParameterValues parameterValue4 = new ParameterValues();
				ParameterDiscreteValue parameterDiscreteValue4 = new ParameterDiscreteValue();
				parameterDiscreteValue4.set_Value(voucher[0].CAcc);
				parameterValue4.Add(parameterDiscreteValue4);
				reportDocument.DataDefinition.ParameterFields["AccNumber"].ApplyCurrentValues(parameterValue4);
				ParameterValues parameterValue5 = new ParameterValues();
				ParameterDiscreteValue parameterDiscreteValue5 = new ParameterDiscreteValue();
				parameterDiscreteValue5.set_Value(voucher[0].Amount_NU);
				parameterValue5.Add(parameterDiscreteValue5);
				reportDocument.DataDefinition.ParameterFields["Amount"].ApplyCurrentValues(parameterValue5);
				ParameterValues parameterValue6 = new ParameterValues();
				ParameterDiscreteValue parameterDiscreteValue6 = new ParameterDiscreteValue();
				parameterDiscreteValue6.set_Value(voucher[0].Descrip_VC);
				parameterValue6.Add(parameterDiscreteValue6);
				reportDocument.DataDefinition.ParameterFields["Desc"].ApplyCurrentValues(parameterValue6);
				ParameterValues parameterValue7 = new ParameterValues();
				ParameterDiscreteValue parameterDiscreteValue7 = new ParameterDiscreteValue();
				try
				{
					int item = voucher[0].chkNumber.set_Value((!voucher[0].chkNumber ? "" : item.ToString()));
				}
				catch
				{
					parameterDiscreteValue7.set_Value("");
				}
				parameterValue7.Add(parameterDiscreteValue7);
				reportDocument.DataDefinition.ParameterFields["chkNumber"].ApplyCurrentValues(parameterValue7);
				ParameterValues parameterValue8 = new ParameterValues();
				ParameterDiscreteValue parameterDiscreteValue8 = new ParameterDiscreteValue();
				parameterDiscreteValue8.set_Value((!voucher[0].BankName ? "" : voucher[0].BankName));
				parameterValue8.Add(parameterDiscreteValue8);
				reportDocument.DataDefinition.ParameterFields["Bank"].ApplyCurrentValues(parameterValue8);
				ParameterValues parameterValue9 = new ParameterValues();
				ParameterDiscreteValue parameterDiscreteValue9 = new ParameterDiscreteValue();
				DateTime dateDT = voucher[0].Date_DT.set_Value(dateDT.ToShortDateString());
				parameterValue9.Add(parameterDiscreteValue9);
				reportDocument.DataDefinition.ParameterFields["Date"].ApplyCurrentValues(parameterValue9);
				ParameterValues parameterValue10 = new ParameterValues();
				ParameterDiscreteValue parameterDiscreteValue10 = new ParameterDiscreteValue();
				parameterDiscreteValue10.set_Value(DepositForm._voucherID);
				parameterValue10.Add(parameterDiscreteValue10);
				reportDocument.DataDefinition.ParameterFields["VNumber"].ApplyCurrentValues(parameterValue10);
				reportDocument.PrintOptions.set_PrinterName(this.printDialog1.PrinterSettings.PrinterName);
				reportDocument.PrintToPrinter(this.printDialog1.PrinterSettings.Copies, this.printDialog1.PrinterSettings.Collate, 1, 1);
				MessageBox.Show(string.Concat("Report Error", exception.Message));
			}
			try
			{
			}
			catch (Exception exception)
			{
			}
		}
		else
		{
			MessageBox.Show("الرجاء حفظ السند");
		}
	}
}
}