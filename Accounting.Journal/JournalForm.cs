using System.Windows.Forms;
using System;
using System.ComponentModel;
using Accounting;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;
using CrystalDecisions.Shared;
using Accounting.Vouchers;
using System.Drawing;
using Accounting.Properties;
using Accounting.Code.Bll;

namespace Accounting.Journal
{
public class JournalForm : Form
{
	private static DateTime _date;

	private static int? _editRow;

	internal JournalBll _journal;

	private static bool _saved;

	private static int _savedIndex;

	internal Button btnAdd;

	private Button btnBrowse;

	private Button btnDelete;

	private Button btnEdit;

	private Button btnExit;

	private Button btnPrint;

	private Button btnSave;

	private Button btnSearch;

	private IContainer components;

	internal string dateString;

	private DataGridView dgvJournal;

	internal DateTimePicker dtDate;

	private Label lblAmount;

	private Label lblCode;

	private Label lblDate;

	private Label lblDocNumber;

	private Label lblNote;

	private Label lblR;

	private Label lblTitle;

	private static Mode mode;

	internal bool old;

	private Panel pnlAdd;

	private Panel pnlButtons;

	private Panel pnlFooter;

	private Panel pnlHeader;

	internal Panel pnlMain;

	private Panel pnlNumber;

	private PrintDialog printDialog1;

	internal TextBox tbAmount;

	internal TextBox tbCode;

	private TextBox tbDocNumber;

	private TextBox tbNote;

	private ToolTip toolTip1;

	public JournalForm()
	{
		this.components = null;
		base();
		this.InitializeComponent();
		DateTime now = DateTime.Now;
		JournalForm._date = now.Date;
		this._journal = new JournalBll();
		JournalForm.mode = Mode.Null;
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		this.pnlMain.Enabled = true;
		this.tbCode.Text = "";
		this.tbAmount.Text = "";
		this.tbNote.Text = "";
		int num = num.Text = num.ToString();
		DateTime now = DateTime.Now.Text = now.ToShortDateString();
		this.tbCode.Focus();
		JournalForm.mode = Mode.New;
	}

	private void btnBrowse_Click(object sender, EventArgs e)
	{
		popupBrowse _popupBrowse = new popupBrowse();
		_popupBrowse._journalForm = this;
		_popupBrowse.Show();
	}

	private void btnDelete_Click(object sender, EventArgs e)
	{
		this.pnlMain.Enabled = true;
		this.tbNote.Text = "";
		this.tbAmount.Text = "";
		this.tbCode.Text = "";
		this.tbDocNumber.Text = "";
		this.dtDate.Text = "";
		this.pnlAdd.Enabled = false;
		this.pnlNumber.Enabled = false;
		this.dgvJournal.Focus();
		this.dgvJournal.Rows[0].Selected = true;
		JournalForm.mode = Mode.Delete;
	}

	private void btnEdit_Click(object sender, EventArgs e)
	{
		if (this.dgvJournal.Rows.Count > 0)
		{
			this.pnlMain.Enabled = true;
			this.tbNote.Text = "";
			this.tbAmount.Text = "";
			this.tbCode.Text = "";
			this.tbDocNumber.Text = "";
			this.dtDate.Text = "";
			this.pnlAdd.Enabled = false;
			this.pnlNumber.Enabled = false;
			this.dgvJournal.Focus();
			this.dgvJournal.Rows[0].Selected = true;
			JournalForm.mode = Mode.Edit;
		}
	}

	private void btnExit_Click(object sender, EventArgs e)
	{
		base.Close();
		base.Dispose();
	}

	internal void btnPrint_Click(object sender, EventArgs e)
	{
		if (this.dgvJournal.Rows.Count <= 0)
		{
			MessageBox.Show("لا يوجد بيانات للطباعه");
		}
		else
		{
			if (this._journal.getJournal().Count == 0)
			{
				MessageBox.Show("لا يمكن طباعة بيانات غير مرحلة");
			}
			else
			{
				ReportDocument reportDocument = new ReportDocument();
				reportDocument.Load(string.Concat(Path.GetDirectoryName(Application.ExecutablePath), "\\JournalCR.rpt"));
				DailyJournalDataTable dailyJournalDataTable = this.fillTable(this._journal.getJournal());
				reportDocument.SetDataSource(dailyJournalDataTable);
				ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();
				ParameterValues parameterValue = new ParameterValues();
				if (string.IsNullOrEmpty(this.dateString))
				{
					DateTime @value = this.dtDate.Value.set_Value(@value.ToShortDateString());
				}
				else
				{
					parameterDiscreteValue.set_Value(this.dateString);
				}
				parameterValue.Add(parameterDiscreteValue);
				reportDocument.DataDefinition.ParameterFields["date"].ApplyCurrentValues(parameterValue);
				if (this.printDialog1.ShowDialog() == 1)
				{
					reportDocument.PrintOptions.set_PrinterName(this.printDialog1.PrinterSettings.PrinterName);
					reportDocument.PrintToPrinter(1, false, 1, 1);
				}
			}
		}
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		try
		{
			if (this._journal.checkBalance())
			{
				this._journal.saveJournal();
				this._journal = new JournalBll();
				JournalForm._savedIndex = this._journal.getJournal().Count - 1;
				MessageBox.Show("تم ترحيل القيود");
			}
			else
			{
				MessageBox.Show("القيد غير موزون، لايمكن الحفظ");
			}
		}
		catch (Exception exception)
		{
			MessageBox.Show(string.Concat(" خطأ في اتصال قاعدة البيانات ", exception.Message), "DB Error");
		}
	}

	private void btnSearch_Click(object sender, EventArgs e)
	{
		popupAccounts popupAccount = new popupAccounts();
		popupAccount.journalForm = this;
		popupAccount.Show();
	}

	private void dgvJournal_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
	{
		DataGridView dataGridView = (DataGridView)sender;
		if (dataGridView.Rows.Count <= 0)
		{
			this.btnEdit.Enabled = false;
			this.btnDelete.Enabled = false;
			this.btnPrint.Enabled = false;
			(Form1)this.MdiParent.tsPreview.Enabled = false;
			(Form1)this.MdiParent.tsPrint.Enabled = false;
		}
		else
		{
			this.btnEdit.Enabled = true;
			this.btnDelete.Enabled = true;
			this.btnPrint.Enabled = true;
			(Form1)this.MdiParent.tsPreview.Enabled = true;
			(Form1)this.MdiParent.tsPrint.Enabled = true;
		}
	}

	private void dgvJournal_KeyDown(object sender, KeyEventArgs e)
	{
		DataGridView dataGridView;
		int index;
		Keys keyCode = e.KeyCode;
		if (keyCode <= 69 && keyCode == Keys.Return || keyCode != Keys.Left)
		{
			switch (keyCode)
			{
				case Keys.None:
				{
					V_3 = !e.Control;
					if (!V_3)
					{
						this.btnAdd_Click(sender, new EventArgs());
					}
					V_3 = !e.Control;
					if (!V_3)
					{
						this.btnEdit_Click(sender, new EventArgs());
					}
					V_3 = !e.Control;
					if (!V_3)
					{
						this.btnSave_Click(sender, new EventArgs());
					}
					V_3 = !e.Control;
					if (!V_3)
					{
						this.btnDelete_Click(sender, new EventArgs());
					}
					V_3 = !e.Control;
					if (!V_3)
					{
						this.btnPrint_Click(sender, new EventArgs());
					}
				}
				case Keys.LButton:
				{
					V_3 = !e.Control;
					if (!V_3)
					{
						this.btnBrowse_Click(sender, new EventArgs());
					}
					V_3 = !e.Control;
					if (!V_3)
					{
						this.btnExit_Click(sender, new EventArgs());
					}
					goto ;
				}
			}
			if (keyCode != Keys.P)
			{
				if (keyCode == Keys.S || keyCode != Keys.X)
				{
					if (JournalForm.mode == Mode.Edit)
					{
						this.pnlNumber.Enabled = true;
						this.pnlAdd.Enabled = true;
						dataGridView = (DataGridView)sender;
						index = dataGridView.SelectedRows[0].Index;
						this.tbDocNumber.Text = this.dgvJournal.get_Item(0, index).Value.ToString();
						this.dtDate.Text = &JournalForm._date.ToShortDateString();
						this.tbCode.Text = this.dgvJournal.get_Item(1, index).Value.ToString();
						this.tbAmount.Text = (string.op_Equality(this.dgvJournal.get_Item(2, index).Value.ToString(), "0.0000") || string.op_Equality(this.dgvJournal.get_Item(2, index).Value.ToString(), "0") ? string.Concat("-", this.dgvJournal.get_Item(3, index).Value.ToString()) : this.dgvJournal.get_Item(2, index).Value.ToString());
						this.tbNote.Text = this.dgvJournal.get_Item(4, index).Value.ToString();
						this.tbCode.Focus();
						JournalForm._saved = 1;
						JournalForm._editRow = new int?(index);
						JournalForm._saved = 0;
						JournalForm._editRow = new int?(index);
					}
					else
					{
						if (index <= JournalForm._savedIndex && JournalForm.mode == Mode.Delete)
						{
							dataGridView = (DataGridView)sender;
							index = dataGridView.SelectedRows[0].Index;
							if (MessageBox.Show("متأكد من الحذف؟", "حذف", MessageBoxButtons.OKCancel) == 1)
							{
								MessageBox.Show("لايمكنك حذف قيد مرحل");
							}
							else
							{
								this._journal.delete(index);
								this.dgvJournal.DataSource = this._journal.getJournal();
							}
							this.dgvJournal.Focus();
						}
					}
					this.btnAdd.Focus();
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

	private void dtDate_KeyDown(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		if (keyCode == Keys.Return)
		{
			this.tbCode.Focus();
			goto L_001d;
		}
	L_001d:
	}

	public DailyJournalDataTable fillTable(DailyJournalDataTable journal)
	{
		DailyJournalDataTable dailyJournalDataTable1;
		try
		{
			DailyJournalDataTable dailyJournalDataTable2 = new DailyJournalDataTable();
			for (int i = 0; i < journal.Count; i++)
			{
				dailyJournalDataTable2.AddDailyJournalRow(journal[i].code, journal[i].Account, journal[i].Debit, journal[i].Credit, journal[i].Descrip_VC, journal[i].Date_DT);
			}
			dailyJournalDataTable1 = dailyJournalDataTable2;
		}
		catch (Exception exception)
		{
			throw new Exception(exception.Message);
		}
		return dailyJournalDataTable1;
	}

	private void InitializeComponent()
	{
		this.components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(JournalForm));
		DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
		this.pnlFooter = new Panel();
		this.pnlButtons = new Panel();
		this.btnSave = new Button();
		this.btnExit = new Button();
		this.btnBrowse = new Button();
		this.btnPrint = new Button();
		this.btnDelete = new Button();
		this.btnEdit = new Button();
		this.btnAdd = new Button();
		this.pnlHeader = new Panel();
		this.lblTitle = new Label();
		this.pnlMain = new Panel();
		this.dgvJournal = new DataGridView();
		this.pnlAdd = new Panel();
		this.btnSearch = new Button();
		this.lblR = new Label();
		this.tbNote = new TextBox();
		this.tbAmount = new TextBox();
		this.tbCode = new TextBox();
		this.lblNote = new Label();
		this.lblAmount = new Label();
		this.lblCode = new Label();
		this.pnlNumber = new Panel();
		this.dtDate = new DateTimePicker();
		this.lblDate = new Label();
		this.tbDocNumber = new TextBox();
		this.lblDocNumber = new Label();
		this.printDialog1 = new PrintDialog();
		this.toolTip1 = new ToolTip(this.components);
		this.pnlFooter.SuspendLayout();
		this.pnlButtons.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		this.pnlMain.SuspendLayout();
		this.dgvJournal.BeginInit();
		this.pnlAdd.SuspendLayout();
		this.pnlNumber.SuspendLayout();
		base.SuspendLayout();
		this.pnlFooter.Controls.Add(this.pnlButtons);
		this.pnlFooter.Dock = DockStyle.Bottom;
		this.pnlFooter.Location = new Point(0, 421);
		this.pnlFooter.Name = "pnlFooter";
		this.pnlFooter.Size = new Size(823, 106);
		this.pnlFooter.TabIndex = 0;
		this.pnlButtons.BackColor = SystemColors.Control;
		this.pnlButtons.Controls.Add(this.btnSave);
		this.pnlButtons.Controls.Add(this.btnExit);
		this.pnlButtons.Controls.Add(this.btnBrowse);
		this.pnlButtons.Controls.Add(this.btnPrint);
		this.pnlButtons.Controls.Add(this.btnDelete);
		this.pnlButtons.Controls.Add(this.btnEdit);
		this.pnlButtons.Controls.Add(this.btnAdd);
		this.pnlButtons.Dock = DockStyle.Top;
		this.pnlButtons.Location = new Point(0, 0);
		this.pnlButtons.Name = "pnlButtons";
		this.pnlButtons.Size = new Size(823, 37);
		this.pnlButtons.TabIndex = 0;
		this.btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.btnSave.BackColor = Color.FromArgb(150, 180, 200);
		this.btnSave.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
		this.btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.btnSave.FlatStyle = FlatStyle.Flat;
		this.btnSave.Image = (Image)componentResourceManager.GetObject("btnSave.Image");
		this.btnSave.ImageAlign = ContentAlignment.MiddleLeft;
		this.btnSave.Location = new Point(553, 6);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new Size(84, 27);
		this.btnSave.TabIndex = 8;
		this.btnSave.Text = "حفظ";
		this.btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
		this.toolTip1.SetToolTip(this.btnSave, "ترحيل القيود");
		this.btnSave.UseVisualStyleBackColor = false;
		this.btnSave.add_Click(new EventHandler(this.btnSave_Click));
		this.btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.btnExit.BackColor = Color.FromArgb(150, 180, 200);
		this.btnExit.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
		this.btnExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.btnExit.FlatStyle = FlatStyle.Flat;
		this.btnExit.Image = Resources.Exit;
		this.btnExit.ImageAlign = ContentAlignment.MiddleLeft;
		this.btnExit.Location = new Point(192, 6);
		this.btnExit.Name = "btnExit";
		this.btnExit.Size = new Size(84, 27);
		this.btnExit.TabIndex = 12;
		this.btnExit.Text = "خروج";
		this.btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
		this.btnExit.UseVisualStyleBackColor = false;
		this.btnExit.add_Click(new EventHandler(this.btnExit_Click));
		this.btnBrowse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.btnBrowse.BackColor = Color.FromArgb(150, 180, 200);
		this.btnBrowse.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
		this.btnBrowse.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.btnBrowse.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.btnBrowse.FlatStyle = FlatStyle.Flat;
		this.btnBrowse.Image = Resources.Search;
		this.btnBrowse.ImageAlign = ContentAlignment.MiddleLeft;
		this.btnBrowse.Location = new Point(282, 6);
		this.btnBrowse.Name = "btnBrowse";
		this.btnBrowse.Size = new Size(84, 27);
		this.btnBrowse.TabIndex = 11;
		this.btnBrowse.Text = "استعراض";
		this.btnBrowse.TextImageRelation = TextImageRelation.ImageBeforeText;
		this.toolTip1.SetToolTip(this.btnBrowse, "استعراض قيود سابقة");
		this.btnBrowse.UseVisualStyleBackColor = false;
		this.btnBrowse.add_Click(new EventHandler(this.btnBrowse_Click));
		this.btnPrint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.btnPrint.BackColor = Color.FromArgb(150, 180, 200);
		this.btnPrint.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
		this.btnPrint.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.btnPrint.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.btnPrint.FlatStyle = FlatStyle.Flat;
		this.btnPrint.Image = Resources.Print;
		this.btnPrint.ImageAlign = ContentAlignment.MiddleLeft;
		this.btnPrint.Location = new Point(372, 6);
		this.btnPrint.Name = "btnPrint";
		this.btnPrint.Size = new Size(84, 27);
		this.btnPrint.TabIndex = 10;
		this.btnPrint.Text = "طباعة";
		this.btnPrint.TextImageRelation = TextImageRelation.ImageBeforeText;
		this.toolTip1.SetToolTip(this.btnPrint, "طباعة القيود");
		this.btnPrint.UseVisualStyleBackColor = false;
		this.btnPrint.add_Click(new EventHandler(this.btnPrint_Click));
		this.btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.btnDelete.BackColor = Color.FromArgb(150, 180, 200);
		this.btnDelete.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
		this.btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.btnDelete.FlatStyle = FlatStyle.Flat;
		this.btnDelete.Image = Resources.Delete;
		this.btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
		this.btnDelete.Location = new Point(462, 6);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new Size(84, 27);
		this.btnDelete.TabIndex = 9;
		this.btnDelete.Text = "حذف";
		this.btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
		this.toolTip1.SetToolTip(this.btnDelete, "حذف قيد");
		this.btnDelete.UseVisualStyleBackColor = false;
		this.btnDelete.add_Click(new EventHandler(this.btnDelete_Click));
		this.btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.btnEdit.BackColor = Color.FromArgb(150, 180, 200);
		this.btnEdit.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
		this.btnEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.btnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.btnEdit.FlatStyle = FlatStyle.Flat;
		this.btnEdit.Image = Resources.Edit;
		this.btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
		this.btnEdit.Location = new Point(643, 6);
		this.btnEdit.Name = "btnEdit";
		this.btnEdit.Size = new Size(84, 27);
		this.btnEdit.TabIndex = 7;
		this.btnEdit.Text = "تعديل";
		this.btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
		this.toolTip1.SetToolTip(this.btnEdit, "تعديل قيد سابق");
		this.btnEdit.UseVisualStyleBackColor = false;
		this.btnEdit.add_Click(new EventHandler(this.btnEdit_Click));
		this.btnAdd.AccessibleName = "add";
		this.btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.btnAdd.BackColor = Color.FromArgb(150, 180, 200);
		this.btnAdd.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
		this.btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.btnAdd.FlatStyle = FlatStyle.Flat;
		this.btnAdd.Image = Resources.Add;
		this.btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
		this.btnAdd.Location = new Point(733, 6);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new Size(84, 27);
		this.btnAdd.TabIndex = 6;
		this.btnAdd.Text = "إضافة";
		this.btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
		this.toolTip1.SetToolTip(this.btnAdd, "إضافة قيد جديد");
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.add_Click(new EventHandler(this.btnAdd_Click));
		this.pnlHeader.Controls.Add(this.lblTitle);
		this.pnlHeader.Dock = DockStyle.Top;
		this.pnlHeader.Location = new Point(0, 0);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new Size(823, 71);
		this.pnlHeader.TabIndex = 1;
		this.lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblTitle.AutoSize = true;
		this.lblTitle.Font = new Font("Sakkal Majalla", 20.25, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.lblTitle.ForeColor = SystemColors.ButtonFace;
		this.lblTitle.Location = new Point(168, 20);
		this.lblTitle.Name = "lblTitle";
		this.lblTitle.Size = new Size(115, 35);
		this.lblTitle.TabIndex = 0;
		this.lblTitle.Text = "قيود اليومية";
		this.pnlMain.Controls.Add(this.dgvJournal);
		this.pnlMain.Controls.Add(this.pnlAdd);
		this.pnlMain.Controls.Add(this.pnlNumber);
		this.pnlMain.Dock = DockStyle.Fill;
		this.pnlMain.Location = new Point(0, 71);
		this.pnlMain.Name = "pnlMain";
		this.pnlMain.Size = new Size(823, 350);
		this.pnlMain.TabIndex = 2;
		this.dgvJournal.AllowUserToAddRows = false;
		this.dgvJournal.AllowUserToDeleteRows = false;
		this.dgvJournal.AllowUserToOrderColumns = true;
		this.dgvJournal.BackgroundColor = SystemColors.ControlDarkDark;
		this.dgvJournal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvJournal.Dock = DockStyle.Fill;
		this.dgvJournal.Location = new Point(0, 135);
		this.dgvJournal.MultiSelect = false;
		this.dgvJournal.Name = "dgvJournal";
		this.dgvJournal.ReadOnly = true;
		dataGridViewCellStyle.SelectionBackColor = SystemColors.ControlDark;
		this.dgvJournal.RowsDefaultCellStyle = dataGridViewCellStyle;
		this.dgvJournal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dgvJournal.Size = new Size(823, 215);
		this.dgvJournal.TabIndex = 2;
		this.dgvJournal.add_KeyDown(new KeyEventHandler(this.dgvJournal_KeyDown));
		this.dgvJournal.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(this.dgvJournal_DataBindingComplete);
		this.pnlAdd.BorderStyle = BorderStyle.FixedSingle;
		this.pnlAdd.Controls.Add(this.btnSearch);
		this.pnlAdd.Controls.Add(this.lblR);
		this.pnlAdd.Controls.Add(this.tbNote);
		this.pnlAdd.Controls.Add(this.tbAmount);
		this.pnlAdd.Controls.Add(this.tbCode);
		this.pnlAdd.Controls.Add(this.lblNote);
		this.pnlAdd.Controls.Add(this.lblAmount);
		this.pnlAdd.Controls.Add(this.lblCode);
		this.pnlAdd.Dock = DockStyle.Top;
		this.pnlAdd.Location = new Point(0, 55);
		this.pnlAdd.Name = "pnlAdd";
		this.pnlAdd.Size = new Size(823, 80);
		this.pnlAdd.TabIndex = 1;
		this.btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.btnSearch.FlatAppearance.BorderColor = SystemColors.ButtonFace;
		this.btnSearch.FlatStyle = FlatStyle.Flat;
		this.btnSearch.Image = Resources.Browse;
		this.btnSearch.Location = new Point(529, 12);
		this.btnSearch.Name = "btnSearch";
		this.btnSearch.Size = new Size(20, 20);
		this.btnSearch.TabIndex = 3;
		this.btnSearch.UseVisualStyleBackColor = true;
		this.btnSearch.add_Click(new EventHandler(this.btnSearch_Click));
		this.lblR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblR.AutoSize = true;
		this.lblR.ForeColor = SystemColors.ButtonFace;
		this.lblR.Location = new Point(521, 45);
		this.lblR.Name = "lblR";
		this.lblR.Size = new Size(30, 13);
		this.lblR.TabIndex = 6;
		this.lblR.Text = "ريــال";
		this.tbNote.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.tbNote.Location = new Point(38, 11);
		this.tbNote.Name = "tbNote";
		this.tbNote.Size = new Size(335, 20);
		this.tbNote.TabIndex = 5;
		this.tbNote.add_KeyDown(new KeyEventHandler(this.tbNote_KeyDown));
		this.tbAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.tbAmount.Location = new Point(555, 42);
		this.tbAmount.Name = "tbAmount";
		this.tbAmount.RightToLeft = RightToLeft.No;
		this.tbAmount.Size = new Size(175, 20);
		this.tbAmount.TabIndex = 4;
		this.tbAmount.add_KeyDown(new KeyEventHandler(this.tbAmount_KeyDown));
		this.tbCode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.tbCode.Location = new Point(555, 12);
		this.tbCode.Name = "tbCode";
		this.tbCode.Size = new Size(175, 20);
		this.tbCode.TabIndex = 3;
		this.tbCode.add_KeyDown(new KeyEventHandler(this.tbCode_KeyDown));
		this.lblNote.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblNote.AutoSize = true;
		this.lblNote.ForeColor = SystemColors.ButtonFace;
		this.lblNote.Location = new Point(379, 15);
		this.lblNote.Name = "lblNote";
		this.lblNote.Size = new Size(33, 13);
		this.lblNote.TabIndex = 2;
		this.lblNote.Text = "مقابل";
		this.lblAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblAmount.AutoSize = true;
		this.lblAmount.ForeColor = SystemColors.ButtonFace;
		this.lblAmount.Location = new Point(736, 45);
		this.lblAmount.Name = "lblAmount";
		this.lblAmount.Size = new Size(64, 13);
		this.lblAmount.TabIndex = 1;
		this.lblAmount.Text = "المبلــــــــــغ";
		this.lblCode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblCode.AutoSize = true;
		this.lblCode.ForeColor = SystemColors.ButtonFace;
		this.lblCode.Location = new Point(736, 15);
		this.lblCode.Name = "lblCode";
		this.lblCode.Size = new Size(64, 13);
		this.lblCode.TabIndex = 0;
		this.lblCode.Text = "رقم الحساب";
		this.pnlNumber.BorderStyle = BorderStyle.Fixed3D;
		this.pnlNumber.Controls.Add(this.dtDate);
		this.pnlNumber.Controls.Add(this.lblDate);
		this.pnlNumber.Controls.Add(this.tbDocNumber);
		this.pnlNumber.Controls.Add(this.lblDocNumber);
		this.pnlNumber.Dock = DockStyle.Top;
		this.pnlNumber.Location = new Point(0, 0);
		this.pnlNumber.Name = "pnlNumber";
		this.pnlNumber.Size = new Size(823, 55);
		this.pnlNumber.TabIndex = 0;
		this.dtDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.dtDate.Location = new Point(37, 15);
		this.dtDate.Name = "dtDate";
		this.dtDate.RightToLeftLayout = true;
		this.dtDate.Size = new Size(200, 20);
		this.dtDate.TabIndex = 3;
		this.dtDate.add_KeyDown(new KeyEventHandler(this.dtDate_KeyDown));
		this.lblDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblDate.AutoSize = true;
		this.lblDate.ForeColor = SystemColors.ButtonFace;
		this.lblDate.Location = new Point(245, 18);
		this.lblDate.Name = "lblDate";
		this.lblDate.Size = new Size(44, 13);
		this.lblDate.TabIndex = 2;
		this.lblDate.Text = "التـــاريخ";
		this.tbDocNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.tbDocNumber.Location = new Point(554, 19);
		this.tbDocNumber.Name = "tbDocNumber";
		this.tbDocNumber.Size = new Size(175, 20);
		this.tbDocNumber.TabIndex = 1;
		this.tbDocNumber.add_KeyDown(new KeyEventHandler(this.tbDocNumber_KeyDown));
		this.lblDocNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblDocNumber.AutoSize = true;
		this.lblDocNumber.ForeColor = SystemColors.ButtonFace;
		this.lblDocNumber.Location = new Point(735, 22);
		this.lblDocNumber.Name = "lblDocNumber";
		this.lblDocNumber.Size = new Size(58, 13);
		this.lblDocNumber.TabIndex = 0;
		this.lblDocNumber.Text = "رقم القيـــد";
		this.printDialog1.UseEXDialog = true;
		base.AutoScaleDimensions = new SizeF(6, 13);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.BackColor = SystemColors.ControlDarkDark;
		base.ClientSize = new Size(823, 527);
		base.Controls.Add(this.pnlMain);
		base.Controls.Add(this.pnlHeader);
		base.Controls.Add(this.pnlFooter);
		base.FormBorderStyle = FormBorderStyle.Fixed3D;
		base.Name = "JournalForm";
		base.RightToLeft = RightToLeft.Yes;
		base.RightToLeftLayout = true;
		base.ShowIcon = false;
		base.Text = "قيود اليومية";
		base.Load += new EventHandler(this.JournalForm_Load);
		this.pnlFooter.ResumeLayout(false);
		this.pnlButtons.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		this.pnlHeader.PerformLayout();
		this.pnlMain.ResumeLayout(false);
		this.dgvJournal.EndInit();
		this.pnlAdd.ResumeLayout(false);
		this.pnlAdd.PerformLayout();
		this.pnlNumber.ResumeLayout(false);
		this.pnlNumber.PerformLayout();
		base.ResumeLayout(false);
	}

	private void JournalForm_Load(object sender, EventArgs e)
	{
		string userName = (Form1)base.MdiParent.UserName;
		this.resetUI(userName);
		DailyJournalDataTable journal = this._journal.getJournal();
		journal.AccountColumn.ColumnName = "رقم الحساب";
		journal.codeColumn.ColumnName = "رقم القيد";
		journal.CreditColumn.ColumnName = "دائن";
		journal.DebitColumn.ColumnName = "مدين";
		journal.Descrip_VCColumn.ColumnName = "الشرح";
		journal.Date_DTColumn.ColumnName = "التاريخ";
		this.dgvJournal.DataSource = journal;
		this.dgvJournal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		this.dgvJournal.Columns["الشرح"].Width = 200;
		JournalForm._savedIndex = journal.Rows.Count - 1;
		base.WindowState = FormWindowState.Maximized;
		this.pnlMain.Enabled = false;
		AccountsBLL accountsBLL = new AccountsBLL();
		COA_TDataTable allAccounts = accountsBLL.GetAllAccounts();
		int[] array = allAccounts.Select<COA_TRow,int>(new Func<COA_TRow, int>((a) => a.GL_ID)).ToArray<int>();
		AutoCompleteStringCollection autoCompleteStringCollections = new AutoCompleteStringCollection();
		for (int i = 0; i < array.Count<int>(); i++)
		{
			autoCompleteStringCollections.Add(array[i].ToString());
		}
		this.tbCode.AutoCompleteSource = AutoCompleteSource.CustomSource;
		this.tbCode.AutoCompleteMode = AutoCompleteMode.Suggest;
		this.tbCode.AutoCompleteCustomSource = autoCompleteStringCollections;
	}

	internal void resetUI(string username)
	{
		Right right1 = SecBll.getRight(username);
		Right right2 = right1;
		if (right2 == Right.ReadOnly)
		{
			this.btnAdd.Enabled = false;
			this.btnEdit.Enabled = false;
			this.btnSave.Enabled = false;
			this.btnDelete.Enabled = false;
			goto L_0046;
		}
	L_0046:
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

	private void tbCode_KeyDown(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		if (keyCode != Keys.Return)
		{
			switch (keyCode)
			{
				case Keys.None:
				{
					this.tbNote.Focus();
					break;
				}
				case Keys.LButton:
				{
					this.tbDocNumber.Focus();
					break;
				}
				case Keys.Cancel:
				{
					this.tbAmount.Focus();
					break;
				}
				case Keys.F1:
				{
					this.btnSearch_Click(sender, e);
				}
			}
		}
		else
		{
			this.tbAmount.Focus();
		}
	}

	private void tbDocNumber_KeyDown(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		if (keyCode == Keys.Return || keyCode == Keys.Left || keyCode != Keys.Down)
		{
			this.dtDate.Focus();
		}
	L_0035:
	}

	private void tbNote_KeyDown(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		if ((keyCode == Keys.Return || keyCode != Keys.Right) && (string.IsNullOrEmpty(this.tbCode.Text) || !string.IsNullOrEmpty(this.tbAmount.Text)) && JournalForm.mode == Mode.New)
		{
			AccountsBLL accountsBLL = new AccountsBLL();
			if (accountsBLL.isParent(Convert.ToInt32(this.tbCode.Text)))
			{
				MessageBox.Show("لا يمكنك اضافة حساب رئيسي");
				this.tbCode.Focus();
			}
			try
			{
				this._journal.addEntry(Convert.ToInt32(this.tbDocNumber.Text), Convert.ToInt32(this.tbCode.Text), Convert.ToDecimal(this.tbAmount.Text), this.tbNote.Text);
				this.dgvJournal.DataSource = this._journal.getJournal();
				int num = Convert.ToInt32(this.tbAmount.Text) * -1.Text = num.ToString();
				this.tbCode.Focus();
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
			}
		}
	L_02a5:
	}
}
}