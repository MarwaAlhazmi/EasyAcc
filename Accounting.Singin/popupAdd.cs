using System.Windows.Forms;
using System.ComponentModel;
using System;
using System.Web.Security;
using System.Drawing;

namespace Accounting.Singin
{
public class popupAdd : Form
{
	internal AccountsManagerForm _AccMgr;

	private Button btnAdd;

	private Button btnCancel;

	private IContainer components;

	private ComboBox ddlRole;

	private Label lblPass;

	private Label lblPass2;

	private Label lblRole;

	private Label lblUsername;

	private TextBox tbPass;

	private TextBox tbPass2;

	private TextBox tbUsername;

	public popupAdd()
	{
		this.components = null;
		base();
		this.InitializeComponent();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		MembershipCreateStatus membershipCreateStatu = MembershipCreateStatus.Success;
		if (string.IsNullOrEmpty(this.tbUsername.Text) || this.tbPass.Text != this.tbPass2.Text)
		{
			MessageBox.Show("المعلومات المزودة غير كاملة", "خطأ في الإدخال");
		}
		else
		{
			string text = this.tbUsername.Text;
			string str1 = this.tbPass2.Text;
			string str2 = this.ddlRole.SelectedItem.ToString();
			Membership.CreateUser(text, str1, "test@test.com", "what", "this", true, ref membershipCreateStatu);
			if (membershipCreateStatu != MembershipCreateStatus.Success)
			{
				MessageBox.Show(membershipCreateStatu.ToString());
			}
			else
			{
				Roles.AddUserToRole(text, str2);
				this._AccMgr.refreshDGV();
				MessageBox.Show("تمت الإضافة");
				this.tbUsername.Text = "";
				this.tbPass.Text = "";
				this.tbPass2.Text = "";
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
		this.lblUsername = new Label();
		this.tbUsername = new TextBox();
		this.tbPass = new TextBox();
		this.lblPass = new Label();
		this.tbPass2 = new TextBox();
		this.lblPass2 = new Label();
		this.lblRole = new Label();
		this.ddlRole = new ComboBox();
		this.btnAdd = new Button();
		this.btnCancel = new Button();
		base.SuspendLayout();
		this.lblUsername.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblUsername.AutoSize = true;
		this.lblUsername.ForeColor = SystemColors.ButtonFace;
		this.lblUsername.Location = new Point(32, 15);
		this.lblUsername.Name = "lblUsername";
		this.lblUsername.Size = new Size(81, 13);
		this.lblUsername.TabIndex = 0;
		this.lblUsername.Text = "اسم المستخدم";
		this.tbUsername.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.tbUsername.Location = new Point(121, 12);
		this.tbUsername.Name = "tbUsername";
		this.tbUsername.Size = new Size(122, 20);
		this.tbUsername.TabIndex = 1;
		this.tbPass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.tbPass.Location = new Point(121, 38);
		this.tbPass.Name = "tbPass";
		this.tbPass.PasswordChar = 42;
		this.tbPass.Size = new Size(122, 20);
		this.tbPass.TabIndex = 3;
		this.tbPass.UseSystemPasswordChar = true;
		this.lblPass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblPass.AutoSize = true;
		this.lblPass.ForeColor = SystemColors.ButtonFace;
		this.lblPass.Location = new Point(32, 41);
		this.lblPass.Name = "lblPass";
		this.lblPass.Size = new Size(59, 13);
		this.lblPass.TabIndex = 2;
		this.lblPass.Text = "كلمة المرور";
		this.tbPass2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.tbPass2.Location = new Point(121, 64);
		this.tbPass2.Name = "tbPass2";
		this.tbPass2.PasswordChar = 42;
		this.tbPass2.Size = new Size(122, 20);
		this.tbPass2.TabIndex = 5;
		this.tbPass2.UseSystemPasswordChar = true;
		this.lblPass2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblPass2.AutoSize = true;
		this.lblPass2.ForeColor = SystemColors.ButtonFace;
		this.lblPass2.Location = new Point(32, 67);
		this.lblPass2.Name = "lblPass2";
		this.lblPass2.Size = new Size(83, 13);
		this.lblPass2.TabIndex = 4;
		this.lblPass2.Text = "تأكيد كلمة المرور";
		this.lblRole.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblRole.AutoSize = true;
		this.lblRole.ForeColor = SystemColors.ButtonFace;
		this.lblRole.Location = new Point(32, 93);
		this.lblRole.Name = "lblRole";
		this.lblRole.Size = new Size(41, 13);
		this.lblRole.TabIndex = 6;
		this.lblRole.Text = "الوظيفة";
		this.ddlRole.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.ddlRole.FormattingEnabled = true;
		this.ddlRole.Location = new Point(121, 90);
		this.ddlRole.Name = "ddlRole";
		this.ddlRole.Size = new Size(122, 21);
		this.ddlRole.TabIndex = 7;
		this.btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.btnAdd.BackColor = Color.FromArgb(150, 180, 200);
		this.btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.btnAdd.FlatStyle = FlatStyle.Flat;
		this.btnAdd.Location = new Point(26, 134);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new Size(75, 23);
		this.btnAdd.TabIndex = 8;
		this.btnAdd.Text = "إضافة";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.add_Click(new EventHandler(this.btnAdd_Click));
		this.btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.btnCancel.BackColor = Color.FromArgb(150, 180, 200);
		this.btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.btnCancel.FlatStyle = FlatStyle.Flat;
		this.btnCancel.Location = new Point(178, 134);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new Size(75, 23);
		this.btnCancel.TabIndex = 9;
		this.btnCancel.Text = "إلغاء";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.add_Click(new EventHandler(this.btnCancel_Click));
		base.AutoScaleDimensions = new SizeF(6, 13);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.BackColor = SystemColors.ControlDarkDark;
		base.ClientSize = new Size(283, 179);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnAdd);
		base.Controls.Add(this.ddlRole);
		base.Controls.Add(this.lblRole);
		base.Controls.Add(this.tbPass2);
		base.Controls.Add(this.lblPass2);
		base.Controls.Add(this.tbPass);
		base.Controls.Add(this.lblPass);
		base.Controls.Add(this.tbUsername);
		base.Controls.Add(this.lblUsername);
		base.FormBorderStyle = FormBorderStyle.Fixed3D;
		base.MaximizeBox = false;
		base.Name = "popupAdd";
		base.RightToLeft = RightToLeft.Yes;
		base.RightToLeftLayout = true;
		base.ShowIcon = false;
		base.StartPosition = FormStartPosition.CenterScreen;
		base.Text = "إضافة مستخدم جديد";
		base.Load += new EventHandler(this.popupAdd_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void popupAdd_Load(object sender, EventArgs e)
	{
		this.ddlRole.DataSource = Roles.GetAllRoles();
	}
}
}