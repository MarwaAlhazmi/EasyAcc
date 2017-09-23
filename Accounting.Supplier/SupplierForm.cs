using System.Windows.Forms;
using System.ComponentModel;
using System;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;
using System.Drawing;
using Accounting.Properties;
using Accounting.Code.Bll;
using Accounting;

namespace Accounting.Supplier
{
public class SupplierForm : Form
{
	private popupSupplier _addSub;

	private SupplierBll _supplier;

	private Button btnAdd;

	private Button btnDelete;

	private Button btnEdit;

	private Button btnExit;

	private Button btnPrint;

	private IContainer components;

	internal DataGridView dgvSuppliers;

	private Mode mode;

	private Panel pnlHeader;

	private PrintDialog printDialog1;

	internal SupplierDataTable sTable;

	public SupplierForm()
	{
		this.components = null;
		base();
		this.InitializeComponent();
		this._supplier = new SupplierBll();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		this.mode = Mode.Null;
		this._addSub = new popupSupplier();
		this._addSub.supplierF = this;
		this._addSub.edit = false;
		this._addSub.Show();
	}

	private void btnDelete_Click(object sender, EventArgs e)
	{
		this.mode = Mode.Delete;
		this.dgvSuppliers.Focus();
		this.dgvSuppliers.Rows[0].Selected = true;
	}

	private void btnEdit_Click(object sender, EventArgs e)
	{
		this.dgvSuppliers.Focus();
		this.dgvSuppliers.Rows[0].Selected = true;
		this.mode = Mode.Edit;
	}

	private void btnExit_Click(object sender, EventArgs e)
	{
		base.Close();
		base.Dispose();
	}

	internal void btnPrint_Click(object sender, EventArgs e)
	{
		this.mode = Mode.Null;
		if (this.printDialog1.ShowDialog() == 1)
		{
			ReportDocument reportDocument = new ReportDocument();
			reportDocument.Load(string.Concat(Path.GetDirectoryName(Application.ExecutablePath), "\\SupplierCR.rpt"));
			reportDocument.SetDataSource(this._supplier.getSuppliers());
			reportDocument.PrintOptions.set_PrinterName(this.printDialog1.PrinterSettings.PrinterName);
			reportDocument.PrintToPrinter(this.printDialog1.PrinterSettings.Copies, this.printDialog1.PrinterSettings.Collate, 0, 0);
			MessageBox.Show(exception.Message);
		}
		try
		{
		}
		catch (Exception exception)
		{
		}
	}

	private void dgvSuppliers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
	{
		DataGridView dataGridView = (DataGridView)sender;
		if (dataGridView.Rows.Count <= 0)
		{
			this.btnEdit.Enabled = false;
			this.btnDelete.Enabled = false;
			this.btnPrint.Enabled = false;
		}
		else
		{
			this.btnEdit.Enabled = true;
			this.btnDelete.Enabled = true;
			this.btnPrint.Enabled = true;
		}
	}

	private void dgvSuppliers_KeyDown(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		if (keyCode == Keys.Return)
		{
			DataGridView dataGridView = (DataGridView)sender;
			int index = dataGridView.SelectedRows[0].Index;
			try
			{
				if (this.mode == Mode.Edit)
				{
					this._addSub = new popupSupplier();
					this._addSub.edit = true;
					this._addSub.supplierF = this;
					this._addSub.row = index;
					this._addSub.tbAccCode.Text = dataGridView.get_Item(5, index).Value.ToString();
					this._addSub.tbSName.Text = dataGridView.get_Item(1, index).Value.ToString();
					this._addSub.tbPName.Text = dataGridView.get_Item(2, index).Value.ToString();
					this._addSub.tbPhone.Text = dataGridView.get_Item(4, index).Value.ToString();
					this._addSub.tbAddress.Text = dataGridView.get_Item(3, index).Value.ToString();
					this._addSub.tbBalance.Visible = false;
					this._addSub.lblBalance.Visible = false;
					this._addSub.Text = "تعديل مورد";
					this._addSub.Show();
				}
				else
				{
					if (this.mode != Mode.Delete || MessageBox.Show("متاكد من حذف المزود؟", "حذف", MessageBoxButtons.OKCancel) == 1)
					{
						int num = Convert.ToInt32(dataGridView.get_Item(5, index).Value);
						this._supplier.deleteSupplier(num);
						this.dgvSuppliers.DataSource = this._supplier.getSuppliers();
						this.dgvSuppliers.Refresh();
					}
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show(string.Concat(" لايمكن حذف المزود ", exception.Message));
			}
			goto L_01fc;
		}
	L_01fc:
	}

	private void dgvSuppliers_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		try
		{
			DataGridView dataGridView = (DataGridView)sender;
			int index = dataGridView.SelectedRows[0].Index;
			if (this.mode == Mode.Edit)
			{
				this._addSub = new popupSupplier();
				this._addSub.edit = true;
				this._addSub.supplierF = this;
				this._addSub.row = index;
				this._addSub.tbAccCode.Text = dataGridView.get_Item(5, index).Value.ToString();
				this._addSub.tbSName.Text = dataGridView.get_Item(1, index).Value.ToString();
				this._addSub.tbPName.Text = dataGridView.get_Item(2, index).Value.ToString();
				this._addSub.tbPhone.Text = dataGridView.get_Item(4, index).Value.ToString();
				this._addSub.tbAddress.Text = dataGridView.get_Item(3, index).Value.ToString();
				this._addSub.tbBalance.Visible = false;
				this._addSub.lblBalance.Visible = false;
				this._addSub.Text = "تعديل مورد";
				this._addSub.Show();
			}
			else
			{
				if (this.mode != Mode.Delete || MessageBox.Show("متاكد من حذف المورد؟", "حذف", MessageBoxButtons.OKCancel) == 1)
				{
					int num = Convert.ToInt32(dataGridView.get_Item(5, index).Value);
					this._supplier.deleteSupplier(num);
					this.dgvSuppliers.DataSource = this._supplier.getSuppliers();
					this.dgvSuppliers.Refresh();
				}
			}
		}
		catch (Exception exception)
		{
			MessageBox.Show(string.Concat(" لايمكن حذف المورد ", exception.Message));
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
		this.pnlHeader = new Panel();
		this.btnExit = new Button();
		this.btnPrint = new Button();
		this.btnDelete = new Button();
		this.btnEdit = new Button();
		this.btnAdd = new Button();
		this.dgvSuppliers = new DataGridView();
		this.printDialog1 = new PrintDialog();
		this.pnlHeader.SuspendLayout();
		this.dgvSuppliers.BeginInit();
		base.SuspendLayout();
		this.pnlHeader.BackColor = SystemColors.Control;
		this.pnlHeader.Controls.Add(this.btnExit);
		this.pnlHeader.Controls.Add(this.btnPrint);
		this.pnlHeader.Controls.Add(this.btnDelete);
		this.pnlHeader.Controls.Add(this.btnEdit);
		this.pnlHeader.Controls.Add(this.btnAdd);
		this.pnlHeader.Dock = DockStyle.Top;
		this.pnlHeader.Location = new Point(0, 0);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new Size(751, 47);
		this.pnlHeader.TabIndex = 0;
		this.btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.btnExit.BackColor = Color.FromArgb(150, 180, 200);
		this.btnExit.FlatAppearance.BorderColor = Color.Black;
		this.btnExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.btnExit.FlatStyle = FlatStyle.Flat;
		this.btnExit.Image = Resources.Exit;
		this.btnExit.ImageAlign = ContentAlignment.MiddleLeft;
		this.btnExit.Location = new Point(252, 10);
		this.btnExit.Name = "btnExit";
		this.btnExit.Size = new Size(84, 27);
		this.btnExit.TabIndex = 10;
		this.btnExit.Text = "خروج";
		this.btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
		this.btnExit.UseVisualStyleBackColor = false;
		this.btnExit.add_Click(new EventHandler(this.btnExit_Click));
		this.btnPrint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.btnPrint.BackColor = Color.FromArgb(150, 180, 200);
		this.btnPrint.FlatAppearance.BorderColor = Color.Black;
		this.btnPrint.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.btnPrint.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.btnPrint.FlatStyle = FlatStyle.Flat;
		this.btnPrint.Image = Resources.Print;
		this.btnPrint.ImageAlign = ContentAlignment.MiddleLeft;
		this.btnPrint.Location = new Point(353, 10);
		this.btnPrint.Name = "btnPrint";
		this.btnPrint.Size = new Size(84, 27);
		this.btnPrint.TabIndex = 9;
		this.btnPrint.Text = "طباعة";
		this.btnPrint.TextImageRelation = TextImageRelation.ImageBeforeText;
		this.btnPrint.UseVisualStyleBackColor = false;
		this.btnPrint.add_Click(new EventHandler(this.btnPrint_Click));
		this.btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.btnDelete.BackColor = Color.FromArgb(150, 180, 200);
		this.btnDelete.FlatAppearance.BorderColor = Color.Black;
		this.btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.btnDelete.FlatStyle = FlatStyle.Flat;
		this.btnDelete.Image = Resources.Delete;
		this.btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
		this.btnDelete.Location = new Point(454, 10);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new Size(84, 27);
		this.btnDelete.TabIndex = 8;
		this.btnDelete.Text = "حذف";
		this.btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
		this.btnDelete.UseVisualStyleBackColor = false;
		this.btnDelete.add_Click(new EventHandler(this.btnExit_Click));
		this.btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.btnEdit.BackColor = Color.FromArgb(150, 180, 200);
		this.btnEdit.FlatAppearance.BorderColor = Color.Black;
		this.btnEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.btnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.btnEdit.FlatStyle = FlatStyle.Flat;
		this.btnEdit.Image = Resources.Edit;
		this.btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
		this.btnEdit.Location = new Point(554, 10);
		this.btnEdit.Name = "btnEdit";
		this.btnEdit.Size = new Size(84, 27);
		this.btnEdit.TabIndex = 7;
		this.btnEdit.Text = "تعديل";
		this.btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
		this.btnEdit.UseVisualStyleBackColor = false;
		this.btnEdit.add_Click(new EventHandler(this.btnEdit_Click));
		this.btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.btnAdd.BackColor = Color.FromArgb(150, 180, 200);
		this.btnAdd.FlatAppearance.BorderColor = Color.Black;
		this.btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.btnAdd.FlatStyle = FlatStyle.Flat;
		this.btnAdd.Image = Resources.Add;
		this.btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
		this.btnAdd.Location = new Point(654, 10);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new Size(84, 27);
		this.btnAdd.TabIndex = 6;
		this.btnAdd.Text = "إضافة";
		this.btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.add_Click(new EventHandler(this.btnAdd_Click));
		this.dgvSuppliers.AllowUserToAddRows = false;
		this.dgvSuppliers.AllowUserToDeleteRows = false;
		this.dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		this.dgvSuppliers.BackgroundColor = SystemColors.ControlDarkDark;
		this.dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvSuppliers.Dock = DockStyle.Fill;
		this.dgvSuppliers.Location = new Point(0, 47);
		this.dgvSuppliers.MultiSelect = false;
		this.dgvSuppliers.Name = "dgvSuppliers";
		this.dgvSuppliers.ReadOnly = true;
		dataGridViewCellStyle.SelectionBackColor = SystemColors.ControlDark;
		this.dgvSuppliers.RowsDefaultCellStyle = dataGridViewCellStyle;
		this.dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dgvSuppliers.Size = new Size(751, 383);
		this.dgvSuppliers.TabIndex = 1;
		this.dgvSuppliers.add_MouseDoubleClick(new MouseEventHandler(this.dgvSuppliers_MouseDoubleClick));
		this.dgvSuppliers.add_KeyDown(new KeyEventHandler(this.dgvSuppliers_KeyDown));
		this.dgvSuppliers.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(this.dgvSuppliers_DataBindingComplete);
		this.printDialog1.UseEXDialog = true;
		base.AutoScaleDimensions = new SizeF(6, 13);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(751, 430);
		base.Controls.Add(this.dgvSuppliers);
		base.Controls.Add(this.pnlHeader);
		base.FormBorderStyle = FormBorderStyle.Fixed3D;
		base.Name = "SupplierForm";
		base.RightToLeft = RightToLeft.Yes;
		base.RightToLeftLayout = true;
		base.ShowIcon = false;
		base.Text = "الموردون";
		base.Load += new EventHandler(this.SupplierForm_Load);
		this.pnlHeader.ResumeLayout(false);
		this.dgvSuppliers.EndInit();
		base.ResumeLayout(false);
	}

	internal void resetUI(string username)
	{
		Right right = SecBll.getRight(username);
		switch (right)
		{
			case Right.RestrictedWrite:
			{
				this.btnAdd.set_Enabled(false);
				this.btnEdit.set_Enabled(false);
				this.btnDelete.set_Enabled(false);
				break;
			}
		}
	}

	private void SupplierForm_Load(object sender, EventArgs e)
	{
		this.sTable = this._supplier.getSuppliers();
		this.sTable.AddressColumn.ColumnName = "العنوان";
		this.sTable.AccCodeColumn.ColumnName = "رقم الحساب";
		this.sTable.NameColumn.ColumnName = "اسم المورد";
		this.sTable.PersonNameColumn.ColumnName = "اسم المسؤول";
		this.sTable.PhoneColumn.ColumnName = "رقم الهاتف";
		this.sTable.SupplierIDColumn.ColumnName = "رقم المورد";
		this.dgvSuppliers.DataSource = this.sTable;
		this.mode = Mode.Null;
		base.WindowState = FormWindowState.Maximized;
		this.resetUI((Form1)base.MdiParent.UserName);
	}
}
}