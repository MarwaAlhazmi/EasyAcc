using System.Windows.Forms;
using Accounting;
using System.ComponentModel;
using System;
using System.Web.Security;
using System.Drawing;

namespace Accounting.Singin
{
public class SigninForm : Form
{
	internal Form1 _form1;

	private Button btnCancel;

	private Button btnSignin;

	private IContainer components;

	private Label lblPassword;

	private Label lblUsername;

	private TextBox tbPassword;

	private TextBox tbUsername;

	public SigninForm()
	{
		this.components = null;
		base();
		this.InitializeComponent();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		base.Close();
		base.Dispose();
	}

	private void btnSignin_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(this.tbPassword.Text) || string.IsNullOrEmpty(this.tbUsername.Text))
		{
			MessageBox.Show("خطأ في المعلومات المزودة");
		}
		else
		{
			string text = this.tbUsername.Text;
			string str = this.tbPassword.Text;
			try
			{
				if (Membership.ValidateUser(text, str))
				{
					this._form1.UserName = text;
					this._form1.resetUI(text);
					this._form1.tsSignout.Enabled = true;
					this._form1.tsSignin.Enabled = false;
					base.Close();
				}
				else
				{
					MessageBox.Show("خطأ في اسم المستخدم أو كلمة المرور");
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show(string.Concat("خطأ ", exception.Message));
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
		this.lblUsername = new Label();
		this.lblPassword = new Label();
		this.tbUsername = new TextBox();
		this.tbPassword = new TextBox();
		this.btnSignin = new Button();
		this.btnCancel = new Button();
		base.SuspendLayout();
		this.lblUsername.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblUsername.AutoSize = true;
		this.lblUsername.ForeColor = SystemColors.ButtonFace;
		this.lblUsername.Location = new Point(9, 35);
		this.lblUsername.Name = "lblUsername";
		this.lblUsername.Size = new Size(81, 13);
		this.lblUsername.TabIndex = 0;
		this.lblUsername.Text = "اسم المستخدم";
		this.lblPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblPassword.AutoSize = true;
		this.lblPassword.ForeColor = SystemColors.ButtonFace;
		this.lblPassword.Location = new Point(9, 66);
		this.lblPassword.Name = "lblPassword";
		this.lblPassword.Size = new Size(59, 13);
		this.lblPassword.TabIndex = 1;
		this.lblPassword.Text = "كلمة المرور";
		this.tbUsername.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.tbUsername.Location = new Point(96, 32);
		this.tbUsername.Name = "tbUsername";
		this.tbUsername.Size = new Size(155, 20);
		this.tbUsername.TabIndex = 2;
		this.tbPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.tbPassword.Location = new Point(96, 63);
		this.tbPassword.Name = "tbPassword";
		this.tbPassword.PasswordChar = 42;
		this.tbPassword.Size = new Size(155, 20);
		this.tbPassword.TabIndex = 3;
		this.tbPassword.UseSystemPasswordChar = true;
		this.btnSignin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.btnSignin.BackColor = Color.FromArgb(150, 180, 200);
		this.btnSignin.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.btnSignin.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.btnSignin.FlatStyle = FlatStyle.Flat;
		this.btnSignin.Location = new Point(12, 109);
		this.btnSignin.Name = "btnSignin";
		this.btnSignin.Size = new Size(88, 23);
		this.btnSignin.TabIndex = 4;
		this.btnSignin.Text = "تسجيل دخول";
		this.btnSignin.UseVisualStyleBackColor = false;
		this.btnSignin.add_Click(new EventHandler(this.btnSignin_Click));
		this.btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.btnCancel.BackColor = Color.FromArgb(150, 180, 200);
		this.btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.btnCancel.FlatStyle = FlatStyle.Flat;
		this.btnCancel.Location = new Point(173, 109);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new Size(88, 23);
		this.btnCancel.TabIndex = 5;
		this.btnCancel.Text = "إلغاء";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.add_Click(new EventHandler(this.btnCancel_Click));
		base.AutoScaleDimensions = new SizeF(6, 13);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.BackColor = SystemColors.ControlDarkDark;
		base.ClientSize = new Size(273, 149);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnSignin);
		base.Controls.Add(this.tbPassword);
		base.Controls.Add(this.tbUsername);
		base.Controls.Add(this.lblPassword);
		base.Controls.Add(this.lblUsername);
		base.FormBorderStyle = FormBorderStyle.Fixed3D;
		base.MaximizeBox = false;
		base.Name = "SigninForm";
		base.RightToLeft = RightToLeft.Yes;
		base.RightToLeftLayout = true;
		base.ShowIcon = false;
		base.StartPosition = FormStartPosition.CenterScreen;
		base.Text = "تسجيل الدخول";
		base.Load += new EventHandler(this.SigninForm_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void SigninForm_Load(object sender, EventArgs e)
	{
	}
}
}