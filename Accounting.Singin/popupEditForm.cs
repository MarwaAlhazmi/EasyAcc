using System.Windows.Forms;
using System;
using System.ComponentModel;
using System.Web.Security;
using System.Drawing;

namespace Accounting.Singin
{
public class popupEditForm : Form
{
	internal AccountsManagerForm _Accmgr;

	private bool _Changed;

	internal string _Role;

	internal string _Username;

	private Button btnCancel;

	private Button btnEdit;

	private CheckBox cbPass;

	private IContainer components;

	internal ComboBox ddlRole;

	private Label lblOldPass;

	private Label lblPass;

	private Label lblPass2;

	private Label lblRole;

	private Label lblUsername;

	private Panel pnlPass;

	private TextBox tbOldPass;

	private TextBox tbPass;

	private TextBox tbPass2;

	internal TextBox tbUsername;

	public popupEditForm()
	{
		this.components = null;
		base();
		this.InitializeComponent();
		this._Changed = false;
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		base.Close();
		base.Dispose();
	}

	private void btnEdit_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(this.tbPass.Text) || string.IsNullOrEmpty(this.tbPass2.Text) || this.tbPass.Text == this.tbPass2.Text)
		{
			MessageBox.Show("خطأ في المعلومات المزودة", "خطأ في الإدخال");
		}
		else
		{
			MembershipUser user = Membership.GetUser(this._Username);
			if (this._Changed != 0)
			{
				Roles.RemoveUserFromRole(this._Username, this._Role);
				Roles.AddUserToRole(this._Username, this.ddlRole.SelectedItem.ToString());
			}
			if (this.cbPass.Checked)
			{
				user.ChangePassword(this.tbOldPass.Text, this.tbPass.Text);
			}
			Membership.UpdateUser(user);
			this._Accmgr.refreshDGV();
			if (MessageBox.Show("تم التعديل") == 1)
			{
				base.Close();
				base.Dispose();
			}
		}
	}

	private void cbPass_CheckedChanged(object sender, EventArgs e)
	{
		if (this.cbPass.Checked)
		{
			this.pnlPass.Enabled = true;
		}
		else
		{
			this.pnlPass.Enabled = false;
		}
	}

	private void ddlRole_SelectionChangeCommitted(object sender, EventArgs e)
	{
		this._Changed = true;
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
		this.cbPass = new CheckBox();
		this.tbOldPass = new TextBox();
		this.lblOldPass = new Label();
		this.btnCancel = new Button();
		this.btnEdit = new Button();
		this.ddlRole = new ComboBox();
		this.lblRole = new Label();
		this.tbPass2 = new TextBox();
		this.lblPass2 = new Label();
		this.tbPass = new TextBox();
		this.lblPass = new Label();
		this.tbUsername = new TextBox();
		this.lblUsername = new Label();
		this.pnlPass = new Panel();
		this.pnlPass.SuspendLayout();
		base.SuspendLayout();
		this.cbPass.AutoSize = true;
		this.cbPass.ForeColor = SystemColors.ButtonFace;
		this.cbPass.Location = new Point(111, 67);
		this.cbPass.Name = "cbPass";
		this.cbPass.Size = new Size(103, 17);
		this.cbPass.TabIndex = 2;
		this.cbPass.Text = "تغيير كلمة المرور";
		this.cbPass.UseVisualStyleBackColor = true;
		this.cbPass.CheckedChanged += new EventHandler(this.cbPass_CheckedChanged);
		this.tbOldPass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.tbOldPass.Location = new Point(45, 13);
		this.tbOldPass.Name = "tbOldPass";
		this.tbOldPass.PasswordChar = 42;
		this.tbOldPass.Size = new Size(122, 20);
		this.tbOldPass.TabIndex = 3;
		this.tbOldPass.UseSystemPasswordChar = true;
		this.lblOldPass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblOldPass.AutoSize = true;
		this.lblOldPass.ForeColor = SystemColors.ButtonFace;
		this.lblOldPass.Location = new Point(170, 16);
		this.lblOldPass.Name = "lblOldPass";
		this.lblOldPass.Size = new Size(96, 13);
		this.lblOldPass.TabIndex = 23;
		this.lblOldPass.Text = "كلمة المرور القديمة";
		this.btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.btnCancel.BackColor = Color.FromArgb(150, 180, 200);
		this.btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.btnCancel.FlatStyle = FlatStyle.Flat;
		this.btnCancel.Location = new Point(173, 193);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new Size(75, 23);
		this.btnCancel.TabIndex = 7;
		this.btnCancel.Text = "إلغاء";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.add_Click(new EventHandler(this.btnCancel_Click));
		this.btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.btnEdit.BackColor = Color.FromArgb(150, 180, 200);
		this.btnEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.btnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.btnEdit.FlatStyle = FlatStyle.Flat;
		this.btnEdit.Location = new Point(12, 195);
		this.btnEdit.Name = "btnEdit";
		this.btnEdit.Size = new Size(75, 23);
		this.btnEdit.TabIndex = 6;
		this.btnEdit.Text = "تعديل";
		this.btnEdit.UseVisualStyleBackColor = false;
		this.btnEdit.add_Click(new EventHandler(this.btnEdit_Click));
		this.ddlRole.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.ddlRole.FormattingEnabled = true;
		this.ddlRole.Location = new Point(111, 38);
		this.ddlRole.Name = "ddlRole";
		this.ddlRole.Size = new Size(122, 21);
		this.ddlRole.TabIndex = 1;
		this.ddlRole.SelectionChangeCommitted += new EventHandler(this.ddlRole_SelectionChangeCommitted);
		this.lblRole.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblRole.AutoSize = true;
		this.lblRole.ForeColor = SystemColors.ButtonFace;
		this.lblRole.Location = new Point(9, 41);
		this.lblRole.Name = "lblRole";
		this.lblRole.Size = new Size(41, 13);
		this.lblRole.TabIndex = 19;
		this.lblRole.Text = "الوظيفة";
		this.tbPass2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.tbPass2.Location = new Point(45, 65);
		this.tbPass2.Name = "tbPass2";
		this.tbPass2.PasswordChar = 42;
		this.tbPass2.Size = new Size(122, 20);
		this.tbPass2.TabIndex = 5;
		this.tbPass2.UseSystemPasswordChar = true;
		this.lblPass2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblPass2.AutoSize = true;
		this.lblPass2.ForeColor = SystemColors.ButtonFace;
		this.lblPass2.Location = new Point(183, 68);
		this.lblPass2.Name = "lblPass2";
		this.lblPass2.Size = new Size(83, 13);
		this.lblPass2.TabIndex = 17;
		this.lblPass2.Text = "تأكيد كلمة المرور";
		this.tbPass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.tbPass.Location = new Point(45, 39);
		this.tbPass.Name = "tbPass";
		this.tbPass.PasswordChar = 42;
		this.tbPass.Size = new Size(122, 20);
		this.tbPass.TabIndex = 4;
		this.tbPass.UseSystemPasswordChar = true;
		this.lblPass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblPass.AutoSize = true;
		this.lblPass.ForeColor = SystemColors.ButtonFace;
		this.lblPass.Location = new Point(207, 42);
		this.lblPass.Name = "lblPass";
		this.lblPass.Size = new Size(59, 13);
		this.lblPass.TabIndex = 15;
		this.lblPass.Text = "كلمة المرور";
		this.tbUsername.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.tbUsername.Location = new Point(111, 12);
		this.tbUsername.Name = "tbUsername";
		this.tbUsername.ReadOnly = true;
		this.tbUsername.Size = new Size(122, 20);
		this.tbUsername.TabIndex = 0;
		this.lblUsername.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblUsername.AutoSize = true;
		this.lblUsername.ForeColor = SystemColors.ButtonFace;
		this.lblUsername.Location = new Point(9, 15);
		this.lblUsername.Name = "lblUsername";
		this.lblUsername.Size = new Size(81, 13);
		this.lblUsername.TabIndex = 13;
		this.lblUsername.Text = "اسم المستخدم";
		this.pnlPass.BorderStyle = BorderStyle.FixedSingle;
		this.pnlPass.Controls.Add(this.tbOldPass);
		this.pnlPass.Controls.Add(this.lblPass);
		this.pnlPass.Controls.Add(this.tbPass);
		this.pnlPass.Controls.Add(this.lblOldPass);
		this.pnlPass.Controls.Add(this.lblPass2);
		this.pnlPass.Controls.Add(this.tbPass2);
		this.pnlPass.Enabled = false;
		this.pnlPass.Location = new Point(3, 89);
		this.pnlPass.Name = "pnlPass";
		this.pnlPass.Size = new Size(275, 100);
		this.pnlPass.TabIndex = 3;
		base.AutoScaleDimensions = new SizeF(6, 13);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.BackColor = SystemColors.ControlDarkDark;
		base.ClientSize = new Size(260, 228);
		base.Controls.Add(this.pnlPass);
		base.Controls.Add(this.cbPass);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnEdit);
		base.Controls.Add(this.ddlRole);
		base.Controls.Add(this.lblRole);
		base.Controls.Add(this.tbUsername);
		base.Controls.Add(this.lblUsername);
		base.FormBorderStyle = FormBorderStyle.Fixed3D;
		base.MaximizeBox = false;
		base.Name = "popupEditForm";
		base.RightToLeft = RightToLeft.Yes;
		base.RightToLeftLayout = true;
		base.ShowIcon = false;
		base.StartPosition = FormStartPosition.CenterScreen;
		base.Text = "تحرير حساب المستخدم";
		base.Load += new EventHandler(this.popupEditForm_Load);
		this.pnlPass.ResumeLayout(false);
		this.pnlPass.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void popupEditForm_Load(object sender, EventArgs e)
	{
		this.ddlRole.DataSource = Roles.GetAllRoles();
	}
}
}