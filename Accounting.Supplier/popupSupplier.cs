using System.Windows.Forms;
using System.ComponentModel;
using System;
using System.Drawing;
using Accounting.Properties;

namespace Accounting.Supplier
{
public class popupSupplier : Form
{
	private SupplierBll _supplierBll;

	private Button btnAdd;

	private Button btnCancel;

	private IContainer components;

	internal bool edit;

	private Label lblAccCode;

	private Label lblAddress;

	internal Label lblBalance;

	private Label lblPhone;

	private Label lblPName;

	private Label lblSName;

	private Panel panel1;

	internal int row;

	internal SupplierForm supplierF;

	internal TextBox tbAccCode;

	internal TextBox tbAddress;

	internal TextBox tbBalance;

	internal TextBox tbPhone;

	internal TextBox tbPName;

	internal TextBox tbSName;

	public popupSupplier()
	{
		this.components = null;
		base();
		this.InitializeComponent();
		this._supplierBll = new SupplierBll();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		long? nullable;
		if (string.IsNullOrEmpty(this.tbAccCode.Text) || string.IsNullOrEmpty(this.tbSName.Text))
		{
			MessageBox.Show("رقم الحساب، الرصيد الأولي واسم المورد معلومات مطلوبة");
			this.tbAccCode.Focus();
		}
		else
		{
			if (this.supplierF != null)
			{
				if (string.IsNullOrEmpty(this.tbPhone.Text) || this.tbPhone.Text == "0")
				{
					nullable = null;
				}
				else
				{
					new long?(long.Parse(this.tbPhone.Text));
				}
				string text1 = this.tbAddress.Text;
				string str = this.tbPName.Text;
				string text2 = this.tbSName.Text;
				int num1 = int.Parse(this.tbAccCode.Text);
				if (this.edit != 0)
				{
					int num2 = Convert.ToInt32(this.supplierF.dgvSuppliers.get_Item(5, this.row).Value);
					int num3 = Convert.ToInt32(this.supplierF.dgvSuppliers.get_Item(0, this.row).Value);
					this._supplierBll.updateSuppliers(text2, str, text1, nullable, num1, num3, num2);
				}
				else
				{
					decimal num4 = decimal.Parse(this.tbBalance.Text);
					this._supplierBll.insertSuppliers(text2, str, text1, nullable, num1, num4);
				}
				this.supplierF.sTable = this._supplierBll.getSuppliers();
				this.supplierF.sTable.AddressColumn.ColumnName = "العنوان";
				this.supplierF.sTable.AccCodeColumn.ColumnName = "رقم الحساب";
				this.supplierF.sTable.NameColumn.ColumnName = "اسم المورد";
				this.supplierF.sTable.PersonNameColumn.ColumnName = "اسم المسؤول";
				this.supplierF.sTable.PhoneColumn.ColumnName = "رقم الهاتف";
				this.supplierF.sTable.SupplierIDColumn.ColumnName = "رقم المورد";
				this.supplierF.dgvSuppliers.DataSource = this._supplierBll.getSuppliers();
				this.supplierF.dgvSuppliers.Refresh();
				base.Close();
				base.Dispose();
				MessageBox.Show(exception.Message);
			}
			try
			{
			}
			catch (Exception exception)
			{
			}
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
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
		this.lblAccCode = new Label();
		this.lblSName = new Label();
		this.lblBalance = new Label();
		this.lblPhone = new Label();
		this.lblPName = new Label();
		this.lblAddress = new Label();
		this.tbAccCode = new TextBox();
		this.tbSName = new TextBox();
		this.tbBalance = new TextBox();
		this.tbPhone = new TextBox();
		this.tbPName = new TextBox();
		this.tbAddress = new TextBox();
		this.panel1 = new Panel();
		this.btnAdd = new Button();
		this.btnCancel = new Button();
		this.panel1.SuspendLayout();
		base.SuspendLayout();
		this.lblAccCode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblAccCode.AutoSize = true;
		this.lblAccCode.ForeColor = SystemColors.ButtonFace;
		this.lblAccCode.Location = new Point(210, 18);
		this.lblAccCode.Name = "lblAccCode";
		this.lblAccCode.Size = new Size(64, 13);
		this.lblAccCode.TabIndex = 0;
		this.lblAccCode.Text = "رقم الحساب";
		this.lblSName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblSName.AutoSize = true;
		this.lblSName.ForeColor = SystemColors.ButtonFace;
		this.lblSName.Location = new Point(26, 105);
		this.lblSName.Name = "lblSName";
		this.lblSName.Size = new Size(59, 13);
		this.lblSName.TabIndex = 1;
		this.lblSName.Text = "اسم المورد";
		this.lblBalance.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblBalance.AutoSize = true;
		this.lblBalance.ForeColor = SystemColors.ButtonFace;
		this.lblBalance.Location = new Point(210, 47);
		this.lblBalance.Name = "lblBalance";
		this.lblBalance.Size = new Size(55, 13);
		this.lblBalance.TabIndex = 2;
		this.lblBalance.Text = "رصيد أولي";
		this.lblPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblPhone.AutoSize = true;
		this.lblPhone.ForeColor = SystemColors.ButtonFace;
		this.lblPhone.Location = new Point(50, 154);
		this.lblPhone.Name = "lblPhone";
		this.lblPhone.Size = new Size(35, 13);
		this.lblPhone.TabIndex = 3;
		this.lblPhone.Text = "الهاتف";
		this.lblPName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblPName.AutoSize = true;
		this.lblPName.ForeColor = SystemColors.ButtonFace;
		this.lblPName.Location = new Point(11, 131);
		this.lblPName.Name = "lblPName";
		this.lblPName.Size = new Size(74, 13);
		this.lblPName.TabIndex = 4;
		this.lblPName.Text = "اسم المسؤول";
		this.lblAddress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblAddress.AutoSize = true;
		this.lblAddress.ForeColor = SystemColors.ButtonFace;
		this.lblAddress.Location = new Point(47, 180);
		this.lblAddress.Name = "lblAddress";
		this.lblAddress.Size = new Size(38, 13);
		this.lblAddress.TabIndex = 5;
		this.lblAddress.Text = "العنوان";
		this.tbAccCode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.tbAccCode.Location = new Point(54, 18);
		this.tbAccCode.Name = "tbAccCode";
		this.tbAccCode.Size = new Size(137, 20);
		this.tbAccCode.TabIndex = 1;
		this.tbAccCode.add_KeyDown(new KeyEventHandler(this.tbAccCode_KeyDown));
		this.tbSName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.tbSName.Location = new Point(104, 102);
		this.tbSName.Name = "tbSName";
		this.tbSName.Size = new Size(137, 20);
		this.tbSName.TabIndex = 3;
		this.tbSName.add_KeyDown(new KeyEventHandler(this.tbSName_KeyDown));
		this.tbBalance.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.tbBalance.Location = new Point(54, 44);
		this.tbBalance.Name = "tbBalance";
		this.tbBalance.Size = new Size(137, 20);
		this.tbBalance.TabIndex = 2;
		this.tbBalance.add_KeyDown(new KeyEventHandler(this.tbBalance_KeyDown));
		this.tbBalance.add_Leave(new EventHandler(this.tbBalance_Leave));
		this.tbPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.tbPhone.Location = new Point(104, 154);
		this.tbPhone.Name = "tbPhone";
		this.tbPhone.Size = new Size(137, 20);
		this.tbPhone.TabIndex = 6;
		this.tbPhone.add_KeyDown(new KeyEventHandler(this.tbPhone_KeyDown));
		this.tbPName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.tbPName.Location = new Point(104, 128);
		this.tbPName.Name = "tbPName";
		this.tbPName.Size = new Size(137, 20);
		this.tbPName.TabIndex = 4;
		this.tbPName.add_KeyDown(new KeyEventHandler(this.tbPName_KeyDown));
		this.tbAddress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.tbAddress.Location = new Point(104, 180);
		this.tbAddress.Multiline = true;
		this.tbAddress.Name = "tbAddress";
		this.tbAddress.Size = new Size(179, 55);
		this.tbAddress.TabIndex = 5;
		this.tbAddress.add_KeyDown(new KeyEventHandler(this.tbAddress_KeyDown));
		this.panel1.BorderStyle = BorderStyle.Fixed3D;
		this.panel1.Controls.Add(this.tbBalance);
		this.panel1.Controls.Add(this.lblAccCode);
		this.panel1.Controls.Add(this.lblBalance);
		this.panel1.Controls.Add(this.tbAccCode);
		this.panel1.Dock = DockStyle.Top;
		this.panel1.Location = new Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new Size(297, 86);
		this.panel1.TabIndex = 12;
		this.btnAdd.BackColor = Color.FromArgb(150, 180, 200);
		this.btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.btnAdd.FlatStyle = FlatStyle.Flat;
		this.btnAdd.Image = Resources.Save1;
		this.btnAdd.Location = new Point(16, 251);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new Size(75, 27);
		this.btnAdd.TabIndex = 7;
		this.btnAdd.Text = "حفظ";
		this.btnAdd.TextImageRelation = TextImageRelation.TextBeforeImage;
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.add_Click(new EventHandler(this.btnAdd_Click));
		this.btnCancel.BackColor = Color.FromArgb(150, 180, 200);
		this.btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.btnCancel.FlatStyle = FlatStyle.Flat;
		this.btnCancel.Image = Resources.Delete;
		this.btnCancel.Location = new Point(210, 251);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new Size(75, 27);
		this.btnCancel.TabIndex = 8;
		this.btnCancel.Text = "إلغاء";
		this.btnCancel.TextImageRelation = TextImageRelation.TextBeforeImage;
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.add_Click(new EventHandler(this.btnCancel_Click));
		base.AutoScaleDimensions = new SizeF(6, 13);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.BackColor = SystemColors.ControlDarkDark;
		base.ClientSize = new Size(297, 290);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnAdd);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.tbAddress);
		base.Controls.Add(this.tbPName);
		base.Controls.Add(this.tbPhone);
		base.Controls.Add(this.tbSName);
		base.Controls.Add(this.lblAddress);
		base.Controls.Add(this.lblPName);
		base.Controls.Add(this.lblPhone);
		base.Controls.Add(this.lblSName);
		base.FormBorderStyle = FormBorderStyle.Fixed3D;
		base.MaximizeBox = false;
		base.Name = "popupSupplier";
		base.RightToLeft = RightToLeft.Yes;
		base.RightToLeftLayout = true;
		base.StartPosition = FormStartPosition.CenterScreen;
		base.Text = "اضافة مورد";
		base.Load += new EventHandler(this.popupSupplier_Load);
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void popupSupplier_Load(object sender, EventArgs e)
	{
		if (!this.edit)
		{
			int newCode = this._supplierBll.getNewCode().Text = newCode.ToString();
			this.tbAccCode.Focus();
		}
	}

	private void tbAccCode_KeyDown(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		if (keyCode == Keys.Return)
		{
			this.tbBalance.Focus();
			goto L_001d;
		}
	L_001d:
	}

	private void tbAddress_KeyDown(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		if (keyCode == Keys.Return)
		{
			this.tbPhone.Focus();
			goto L_001d;
		}
	L_001d:
	}

	private void tbBalance_KeyDown(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		if (keyCode == Keys.Return)
		{
			this.tbSName.Focus();
			goto L_001d;
		}
	L_001d:
	}

	private void tbBalance_Leave(object sender, EventArgs e)
	{
		decimal num;
		if (string.IsNullOrEmpty(this.tbBalance.Text) || !decimal.TryParse(this.tbBalance.Text, ref num))
		{
			MessageBox.Show("أدخل الصيغة الصحيحة للرصيد الأولي");
		}
		else
		{
			this.tbBalance.Text = "0";
		}
	}

	private void tbPhone_KeyDown(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		if (keyCode == Keys.Return)
		{
			this.btnAdd.Focus();
			goto L_001d;
		}
	L_001d:
	}

	private void tbPName_KeyDown(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		if (keyCode == Keys.Return)
		{
			this.tbAddress.Focus();
			goto L_001d;
		}
	L_001d:
	}

	private void tbSName_KeyDown(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		if (keyCode == Keys.Return)
		{
			this.tbPName.Focus();
			goto L_001d;
		}
	L_001d:
	}
}
}