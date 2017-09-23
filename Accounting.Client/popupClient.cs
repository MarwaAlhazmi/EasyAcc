using System.Windows.Forms;
using Accounting;
using System.ComponentModel;
using System;
using System.Drawing;
using Accounting.Properties;

namespace Accounting.Client
{
public class popupClient : Form
{
	private ClientBll _clientBll;

	internal AccountsForm accForm;

	private Button btnAdd;

	private Button btnCancel;

	internal ClientForm clientF;

	private IContainer components;

	internal bool edit;

	private Label lblAccCode;

	private Label lblAddress;

	internal Label lblBalance;

	private Label lblEName;

	private Label lblID;

	private Label lblNation;

	private Label lblPhone;

	private Panel panel1;

	internal int row;

	internal TextBox tbAccCode;

	internal TextBox tbAddress;

	internal TextBox tbBalance;

	internal TextBox tbEName;

	internal TextBox tbID;

	internal TextBox tbNation;

	internal TextBox tbPhone;

	public popupClient()
	{
		this.components = null;
		base();
		this.InitializeComponent();
		this._clientBll = new ClientBll();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		long? nullable;
		int num1;
		int num2;
		decimal num3;
		bool flag = !string.IsNullOrEmpty(this.tbAccCode.Text) && !string.IsNullOrEmpty(this.tbEName.Text) && string.IsNullOrEmpty(this.tbPhone.Text);
		MessageBox.Show("الرجاء تعبئة جميع البيانات");
		this.tbAccCode.Focus();
		new long?(long.Parse(this.tbPhone.Text));
		string text1 = this.tbAddress.Text;
		string str = this.tbNation.Text;
		string text2 = this.tbEName.Text;
		long num4 = long.Parse(this.tbID.Text);
		int num5 = int.Parse(this.tbAccCode.Text);
		flag = this.clientF == null;
		if (!flag)
		{
			flag = this.edit == 0;
			if (!flag)
			{
				num1 = Convert.ToInt32(this.clientF.dgvClient.get_Item(6, this.row).Value);
				num2 = Convert.ToInt32(this.clientF.dgvClient.get_Item(0, this.row).Value);
				this._clientBll.updateClient(text2, str, new long?(num4), nullable, text1, num5, num1, num2);
			}
			else
			{
				num3 = decimal.Parse(this.tbBalance.Text);
				this._clientBll.insertClient(text2, str, new long?(num4), nullable, text1, num5, num3);
			}
			this.clientF.eTable = this._clientBll.getClient();
			this.clientF.eTable.AddressColumn.ColumnName = "العنوان";
			this.clientF.eTable.AccCodeColumn.ColumnName = "رقم الحساب";
			this.clientF.eTable.NameColumn.ColumnName = "اسم العميل";
			this.clientF.eTable.ClientIDColumn.ColumnName = "رقم العميل";
			this.clientF.eTable.PhoneColumn.ColumnName = "رقم الهاتف";
			this.clientF.eTable.NationalityColumn.ColumnName = "الجنسية";
			this.clientF.eTable.IDNumberColumn.ColumnName = "رقم الهوية";
			this.clientF.dgvClient.DataSource = this.clientF.eTable;
			this.clientF.dgvClient.Refresh();
			base.Close();
			base.Dispose();
			MessageBox.Show(exception.Message);
		}
		else
		{
			flag = this.accForm == null;
			if (!flag)
			{
				flag = this.edit == 0;
				if (!flag)
				{
					num1 = Convert.ToInt32(this.clientF.dgvClient.get_Item(6, this.row).Value);
					num2 = Convert.ToInt32(this.clientF.dgvClient.get_Item(0, this.row).Value);
					this._clientBll.updateClient(text2, str, new long?(num4), nullable, text1, num5, num1, num2);
				}
				else
				{
					num3 = decimal.Parse(this.tbBalance.Text);
					this._clientBll.insertClient(text2, str, new long?(num4), nullable, text1, num5, num3);
					this.accForm.reloadData();
					base.Close();
					base.Dispose();
				}
				MessageBox.Show(exception.Message);
			}
			try
			{
			}
			catch (Exception exception)
			{
			}
		}
		try
		{
		}
		catch (Exception exception)
		{
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
		this.lblEName = new Label();
		this.lblBalance = new Label();
		this.lblPhone = new Label();
		this.lblAddress = new Label();
		this.tbAccCode = new TextBox();
		this.tbEName = new TextBox();
		this.tbBalance = new TextBox();
		this.tbPhone = new TextBox();
		this.tbNation = new TextBox();
		this.tbAddress = new TextBox();
		this.panel1 = new Panel();
		this.btnAdd = new Button();
		this.btnCancel = new Button();
		this.tbID = new TextBox();
		this.lblID = new Label();
		this.lblNation = new Label();
		this.panel1.SuspendLayout();
		base.SuspendLayout();
		this.lblAccCode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblAccCode.AutoSize = true;
		this.lblAccCode.ForeColor = SystemColors.ButtonFace;
		this.lblAccCode.Location = new Point(218, 17);
		this.lblAccCode.Name = "lblAccCode";
		this.lblAccCode.Size = new Size(64, 13);
		this.lblAccCode.TabIndex = 0;
		this.lblAccCode.Text = "رقم الحساب";
		this.lblEName.AutoSize = true;
		this.lblEName.ForeColor = SystemColors.ButtonFace;
		this.lblEName.Location = new Point(21, 95);
		this.lblEName.Name = "lblEName";
		this.lblEName.Size = new Size(63, 13);
		this.lblEName.TabIndex = 1;
		this.lblEName.Text = "اسم العميل";
		this.lblBalance.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblBalance.AutoSize = true;
		this.lblBalance.ForeColor = SystemColors.ButtonFace;
		this.lblBalance.Location = new Point(218, 43);
		this.lblBalance.Name = "lblBalance";
		this.lblBalance.Size = new Size(55, 13);
		this.lblBalance.TabIndex = 2;
		this.lblBalance.Text = "رصيد أولي";
		this.lblPhone.AutoSize = true;
		this.lblPhone.ForeColor = SystemColors.ButtonFace;
		this.lblPhone.Location = new Point(49, 121);
		this.lblPhone.Name = "lblPhone";
		this.lblPhone.Size = new Size(35, 13);
		this.lblPhone.TabIndex = 3;
		this.lblPhone.Text = "الهاتف";
		this.lblAddress.AutoSize = true;
		this.lblAddress.ForeColor = SystemColors.ButtonFace;
		this.lblAddress.Location = new Point(46, 196);
		this.lblAddress.Name = "lblAddress";
		this.lblAddress.Size = new Size(38, 13);
		this.lblAddress.TabIndex = 5;
		this.lblAddress.Text = "العنوان";
		this.tbAccCode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.tbAccCode.Location = new Point(62, 14);
		this.tbAccCode.Name = "tbAccCode";
		this.tbAccCode.Size = new Size(137, 20);
		this.tbAccCode.TabIndex = 1;
		this.tbAccCode.add_KeyDown(new KeyEventHandler(this.tbAccCode_KeyDown));
		this.tbEName.Location = new Point(103, 92);
		this.tbEName.Name = "tbEName";
		this.tbEName.Size = new Size(137, 20);
		this.tbEName.TabIndex = 3;
		this.tbEName.add_KeyDown(new KeyEventHandler(this.tbSName_KeyDown));
		this.tbBalance.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.tbBalance.Location = new Point(62, 40);
		this.tbBalance.Name = "tbBalance";
		this.tbBalance.Size = new Size(137, 20);
		this.tbBalance.TabIndex = 2;
		this.tbBalance.add_KeyDown(new KeyEventHandler(this.tbBalance_KeyDown));
		this.tbBalance.add_Leave(new EventHandler(this.tbBalance_Leave));
		this.tbPhone.Location = new Point(103, 118);
		this.tbPhone.Name = "tbPhone";
		this.tbPhone.Size = new Size(137, 20);
		this.tbPhone.TabIndex = 8;
		this.tbPhone.add_KeyDown(new KeyEventHandler(this.tbPhone_KeyDown));
		this.tbNation.Location = new Point(103, 144);
		this.tbNation.Name = "tbNation";
		this.tbNation.Size = new Size(137, 20);
		this.tbNation.TabIndex = 5;
		this.tbNation.add_KeyDown(new KeyEventHandler(this.tbPName_KeyDown));
		this.tbAddress.Location = new Point(103, 196);
		this.tbAddress.Multiline = true;
		this.tbAddress.Name = "tbAddress";
		this.tbAddress.Size = new Size(179, 55);
		this.tbAddress.TabIndex = 7;
		this.tbAddress.add_KeyDown(new KeyEventHandler(this.tbAddress_KeyDown));
		this.panel1.BorderStyle = BorderStyle.Fixed3D;
		this.panel1.Controls.Add(this.tbBalance);
		this.panel1.Controls.Add(this.lblAccCode);
		this.panel1.Controls.Add(this.lblBalance);
		this.panel1.Controls.Add(this.tbAccCode);
		this.panel1.Location = new Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new Size(304, 77);
		this.panel1.TabIndex = 1;
		this.btnAdd.BackColor = Color.FromArgb(150, 180, 200);
		this.btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.btnAdd.FlatStyle = FlatStyle.Flat;
		this.btnAdd.Image = Resources.Save1;
		this.btnAdd.Location = new Point(23, 270);
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
		this.btnCancel.Location = new Point(207, 270);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new Size(75, 27);
		this.btnCancel.TabIndex = 8;
		this.btnCancel.Text = "إلغاء";
		this.btnCancel.TextImageRelation = TextImageRelation.TextBeforeImage;
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.add_Click(new EventHandler(this.btnCancel_Click));
		this.tbID.Location = new Point(103, 170);
		this.tbID.Name = "tbID";
		this.tbID.Size = new Size(137, 20);
		this.tbID.TabIndex = 6;
		this.tbID.Text = "0";
		this.tbID.add_TextChanged(new EventHandler(this.tbID_TextChanged));
		this.tbID.add_KeyDown(new KeyEventHandler(this.tbID_KeyDown));
		this.tbID.add_Leave(new EventHandler(this.tbID_Leave));
		this.lblID.AutoSize = true;
		this.lblID.ForeColor = SystemColors.ButtonFace;
		this.lblID.Location = new Point(31, 173);
		this.lblID.Name = "lblID";
		this.lblID.Size = new Size(53, 13);
		this.lblID.TabIndex = 15;
		this.lblID.Text = "رقم الهوية";
		this.lblNation.AutoSize = true;
		this.lblNation.ForeColor = SystemColors.ButtonFace;
		this.lblNation.Location = new Point(38, 147);
		this.lblNation.Name = "lblNation";
		this.lblNation.Size = new Size(46, 13);
		this.lblNation.TabIndex = 13;
		this.lblNation.Text = "الجنسية";
		base.AutoScaleDimensions = new SizeF(6, 13);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.BackColor = SystemColors.ControlDarkDark;
		base.ClientSize = new Size(304, 307);
		base.Controls.Add(this.tbID);
		base.Controls.Add(this.lblID);
		base.Controls.Add(this.lblNation);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnAdd);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.tbAddress);
		base.Controls.Add(this.tbNation);
		base.Controls.Add(this.tbPhone);
		base.Controls.Add(this.tbEName);
		base.Controls.Add(this.lblAddress);
		base.Controls.Add(this.lblPhone);
		base.Controls.Add(this.lblEName);
		base.FormBorderStyle = FormBorderStyle.Fixed3D;
		base.MaximizeBox = false;
		base.Name = "popupClient";
		base.RightToLeft = RightToLeft.Yes;
		base.RightToLeftLayout = true;
		base.StartPosition = FormStartPosition.CenterScreen;
		base.Text = "اضافة عميل";
		base.Load += new EventHandler(this.popupClient_Load);
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void popupClient_Load(object sender, EventArgs e)
	{
		if (!this.edit)
		{
			int nextCode = this._clientBll.getNextCode().Text = nextCode.ToString();
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
			this.btnAdd.Focus();
			goto L_001d;
		}
	L_001d:
	}

	private void tbBalance_KeyDown(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		if (keyCode == Keys.Return)
		{
			this.tbEName.Focus();
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

	private void tbID_KeyDown(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		if (keyCode == Keys.Return)
		{
			this.tbAddress.Focus();
			goto L_001d;
		}
	L_001d:
	}

	private void tbID_Leave(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(this.tbID.Text))
		{
			this.tbID.Text = "0";
		}
	}

	private void tbID_TextChanged(object sender, EventArgs e)
	{
	}

	private void tbPhone_KeyDown(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		if (keyCode == Keys.Return)
		{
			this.tbNation.Focus();
			goto L_001d;
		}
	L_001d:
	}

	private void tbPName_KeyDown(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		if (keyCode == Keys.Return)
		{
			this.tbID.Focus();
			goto L_001d;
		}
	L_001d:
	}

	private void tbSName_KeyDown(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		if (keyCode == Keys.Return)
		{
			this.tbPhone.Focus();
			goto L_001d;
		}
	L_001d:
	}
}
}