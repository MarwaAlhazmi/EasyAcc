using System.Windows.Forms;
using System.ComponentModel;
using System;
using System.Web.Security;
using System.Drawing;
using Accounting.Properties;

namespace Accounting.Singin
{
public class AccountsManagerForm : Form
{
	private Button btnAdd;

	private Button btnDelete;

	private Button btnEdit;

	private Button btnExit;

	private IContainer components;

	private DataGridView dgvUsers;

	private Panel pnlHeader;

	private DataGridViewTextBoxColumn role;

	private DataGridViewTextBoxColumn Username;

	public AccountsManagerForm()
	{
		this.components = null;
		base();
		this.InitializeComponent();
	}

	private void AccountsManagerForm_Load(object sender, EventArgs e)
	{
		this.refreshDGV();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		popupAdd _popupAdd = new popupAdd();
		_popupAdd._AccMgr = this;
		_popupAdd.Show();
	}

	private void btnDelete_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show("هل تريد بالتأكيد حذف المستخدم؟", "حذف", MessageBoxButtons.OKCancel) == 1)
		{
			Membership.DeleteUser(this.dgvUsers.SelectedRows[0].Cells["Username"].Value.ToString());
			this.refreshDGV();
		}
	}

	private void btnEdit_Click(object sender, EventArgs e)
	{
		string str1 = this.dgvUsers.SelectedRows[0].Cells["Username"].Value.ToString();
		string str2 = this.dgvUsers.SelectedRows[0].Cells["role"].Value.ToString();
		popupEditForm _popupEditForm = new popupEditForm();
		_popupEditForm._Username = str1;
		_popupEditForm._Role = str2;
		_popupEditForm._Accmgr = this;
		_popupEditForm.tbUsername.Text = str1;
		_popupEditForm.Show();
		_popupEditForm.ddlRole.SelectedItem = str2;
	}

	private void btnExit_Click(object sender, EventArgs e)
	{
		base.Close();
		base.Dispose();
	}

	private void dgvUsers_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.Control)
		{
			Keys keyCode = e.KeyCode;
			switch (e.KeyCode)
			{
				case 0:
				{
					this.btnDelete_Click(sender, new EventArgs());
					break;
				}
				case 1:
				{
					this.btnEdit_Click(sender, new EventArgs());
					break;
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
		DataGridViewColumn[] dataGridViewColumnArray;
		DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
		this.pnlHeader = new Panel();
		this.dgvUsers = new DataGridView();
		this.Username = new DataGridViewTextBoxColumn();
		this.role = new DataGridViewTextBoxColumn();
		this.btnExit = new Button();
		this.btnDelete = new Button();
		this.btnEdit = new Button();
		this.btnAdd = new Button();
		this.pnlHeader.SuspendLayout();
		this.dgvUsers.BeginInit();
		base.SuspendLayout();
		this.pnlHeader.BackColor = SystemColors.Control;
		this.pnlHeader.Controls.Add(this.btnExit);
		this.pnlHeader.Controls.Add(this.btnDelete);
		this.pnlHeader.Controls.Add(this.btnEdit);
		this.pnlHeader.Controls.Add(this.btnAdd);
		this.pnlHeader.Dock = DockStyle.Top;
		this.pnlHeader.Location = new Point(0, 0);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new Size(516, 47);
		this.pnlHeader.TabIndex = 1;
		this.dgvUsers.AllowUserToAddRows = false;
		this.dgvUsers.AllowUserToDeleteRows = false;
		this.dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		this.dgvUsers.BackgroundColor = SystemColors.ControlDarkDark;
		this.dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvUsers.Columns.AddRange(new DataGridViewColumn[] { this.Username, this.role });
		this.dgvUsers.Dock = DockStyle.Fill;
		this.dgvUsers.Location = new Point(0, 47);
		this.dgvUsers.Name = "dgvUsers";
		this.dgvUsers.ReadOnly = true;
		dataGridViewCellStyle.SelectionBackColor = SystemColors.ControlDark;
		this.dgvUsers.RowsDefaultCellStyle = dataGridViewCellStyle;
		this.dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dgvUsers.Size = new Size(516, 340);
		this.dgvUsers.TabIndex = 2;
		this.dgvUsers.add_KeyDown(new KeyEventHandler(this.dgvUsers_KeyDown));
		this.Username.FillWeight = 179.6954;
		this.Username.HeaderText = "اسم المستخدم";
		this.Username.Name = "Username";
		this.Username.ReadOnly = true;
		this.role.FillWeight = 150;
		this.role.HeaderText = "الوظيفة";
		this.role.Name = "role";
		this.role.ReadOnly = true;
		this.btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.btnExit.BackColor = Color.FromArgb(150, 180, 200);
		this.btnExit.FlatAppearance.BorderColor = Color.Black;
		this.btnExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.btnExit.FlatStyle = FlatStyle.Flat;
		this.btnExit.Image = Resources.Exit;
		this.btnExit.ImageAlign = ContentAlignment.MiddleLeft;
		this.btnExit.Location = new Point(116, 10);
		this.btnExit.Name = "btnExit";
		this.btnExit.Size = new Size(84, 27);
		this.btnExit.TabIndex = 10;
		this.btnExit.Text = "خروج";
		this.btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
		this.btnExit.UseVisualStyleBackColor = false;
		this.btnExit.add_Click(new EventHandler(this.btnExit_Click));
		this.btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.btnDelete.BackColor = Color.FromArgb(150, 180, 200);
		this.btnDelete.FlatAppearance.BorderColor = Color.Black;
		this.btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.btnDelete.FlatStyle = FlatStyle.Flat;
		this.btnDelete.Image = Resources.Delete;
		this.btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
		this.btnDelete.Location = new Point(217, 10);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new Size(84, 27);
		this.btnDelete.TabIndex = 8;
		this.btnDelete.Text = "حذف";
		this.btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
		this.btnDelete.UseVisualStyleBackColor = false;
		this.btnDelete.add_Click(new EventHandler(this.btnDelete_Click));
		this.btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.btnEdit.BackColor = Color.FromArgb(150, 180, 200);
		this.btnEdit.FlatAppearance.BorderColor = Color.Black;
		this.btnEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.btnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.btnEdit.FlatStyle = FlatStyle.Flat;
		this.btnEdit.Image = Resources.Edit;
		this.btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
		this.btnEdit.Location = new Point(317, 10);
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
		this.btnAdd.Location = new Point(417, 10);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new Size(84, 27);
		this.btnAdd.TabIndex = 6;
		this.btnAdd.Text = "إضافة";
		this.btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.add_Click(new EventHandler(this.btnAdd_Click));
		base.AutoScaleDimensions = new SizeF(6, 13);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.BackColor = SystemColors.ControlDarkDark;
		base.ClientSize = new Size(516, 387);
		base.Controls.Add(this.dgvUsers);
		base.Controls.Add(this.pnlHeader);
		base.FormBorderStyle = FormBorderStyle.Fixed3D;
		base.MaximizeBox = false;
		base.Name = "AccountsManagerForm";
		base.RightToLeft = RightToLeft.Yes;
		base.RightToLeftLayout = true;
		base.ShowIcon = false;
		base.StartPosition = FormStartPosition.CenterScreen;
		base.Text = "إدارة حسابات المستخدمين";
		base.Load += new EventHandler(this.AccountsManagerForm_Load);
		this.pnlHeader.ResumeLayout(false);
		this.dgvUsers.EndInit();
		base.ResumeLayout(false);
	}

	internal void refreshDGV()
	{
		string str;
		this.dgvUsers.Rows.Clear();
		MembershipUserCollection allUsers = Membership.GetAllUsers();
		foreach (MembershipUser allUser in allUsers)
		{
			if (Roles.GetRolesForUser(allUser.UserName).Count<string>() > 0)
			{
				str = Roles.GetRolesForUser(allUser.UserName).ElementAt<string>(0);
				continue;
			}
			str = "";
			object[] userName = new object[2];
			userName[0] = allUser.UserName;
			userName[1] = str;
			object[] objArray = userName;
			this.dgvUsers.Rows.Add(objArray);
		}
	}
}
}