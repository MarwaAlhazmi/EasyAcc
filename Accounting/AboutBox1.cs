using System.Windows.Forms;
using System.ComponentModel;
using System;
using System.Reflection;
using System.IO;
using System.Drawing;

namespace Accounting
{
internal class AboutBox1 : Form
{
	private IContainer components;

	private Label labelCompanyName;

	private Label labelCopyright;

	private Label labelProductName;

	private Label labelVersion;

	private PictureBox logoPictureBox;

	private Button okButton;

	private TableLayoutPanel tableLayoutPanel;

	private TextBox textBoxDescription;

	public string AssemblyCompany
	{
		get
		{
			object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
			if ((int)customAttributes.Length == 0)
			{
				return "";
			}
			return (AssemblyCompanyAttribute)customAttributes[0].Company;
		}
	}

	public string AssemblyCopyright
	{
		get
		{
			object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
			if ((int)customAttributes.Length == 0)
			{
				return "";
			}
			return (AssemblyCopyrightAttribute)customAttributes[0].Copyright;
		}
	}

	public string AssemblyDescription
	{
		get
		{
			object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
			if ((int)customAttributes.Length == 0)
			{
				return "";
			}
			return (AssemblyDescriptionAttribute)customAttributes[0].Description;
		}
	}

	public string AssemblyProduct
	{
		get
		{
			object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
			if ((int)customAttributes.Length == 0)
			{
				return "";
			}
			return (AssemblyProductAttribute)customAttributes[0].Product;
		}
	}

	public string AssemblyTitle
	{
		get
		{
			object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
			if ((int)customAttributes.Length > 0)
			{
				AssemblyTitleAttribute assemblyTitleAttribute = (AssemblyTitleAttribute)customAttributes[0];
				if (assemblyTitleAttribute.Title != "")
				{
					return assemblyTitleAttribute.Title;
				}
			}
			return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
		}
	}

	public string AssemblyVersion
	{
		get
		{
			return Assembly.GetExecutingAssembly().GetName().Version.ToString();
		}
	}

	public AboutBox1()
	{
		this.components = null;
		base();
		this.InitializeComponent();
		base.Text = string.Format("About {0} {0}", this.AssemblyTitle);
		this.labelProductName.Text = this.AssemblyProduct;
		this.labelVersion.Text = string.Format("Version {0} {0}", this.AssemblyVersion);
		this.labelCopyright.Text = this.AssemblyCopyright;
		this.labelCompanyName.Text = this.AssemblyCompany;
		this.textBoxDescription.Text = this.AssemblyDescription;
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AboutBox1));
		this.tableLayoutPanel = new TableLayoutPanel();
		this.logoPictureBox = new PictureBox();
		this.labelProductName = new Label();
		this.labelVersion = new Label();
		this.labelCopyright = new Label();
		this.labelCompanyName = new Label();
		this.textBoxDescription = new TextBox();
		this.okButton = new Button();
		this.tableLayoutPanel.SuspendLayout();
		this.logoPictureBox.BeginInit();
		base.SuspendLayout();
		this.tableLayoutPanel.ColumnCount = 2;
		this.tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33));
		this.tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67));
		this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
		this.tableLayoutPanel.Controls.Add(this.labelProductName, 1, 0);
		this.tableLayoutPanel.Controls.Add(this.labelVersion, 1, 1);
		this.tableLayoutPanel.Controls.Add(this.labelCopyright, 1, 2);
		this.tableLayoutPanel.Controls.Add(this.labelCompanyName, 1, 3);
		this.tableLayoutPanel.Controls.Add(this.textBoxDescription, 1, 4);
		this.tableLayoutPanel.Controls.Add(this.okButton, 1, 5);
		this.tableLayoutPanel.Dock = DockStyle.Fill;
		this.tableLayoutPanel.Location = new Point(9, 9);
		this.tableLayoutPanel.Name = "tableLayoutPanel";
		this.tableLayoutPanel.RowCount = 6;
		this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
		this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
		this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
		this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
		this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
		this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
		this.tableLayoutPanel.Size = new Size(417, 265);
		this.tableLayoutPanel.TabIndex = 0;
		this.logoPictureBox.Dock = DockStyle.Fill;
		this.logoPictureBox.Image = (Image)componentResourceManager.GetObject("logoPictureBox.Image");
		this.logoPictureBox.Location = new Point(283, 3);
		this.logoPictureBox.Name = "logoPictureBox";
		this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
		this.logoPictureBox.Size = new Size(131, 259);
		this.logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
		this.logoPictureBox.TabIndex = 12;
		this.logoPictureBox.TabStop = false;
		this.labelProductName.Dock = DockStyle.Fill;
		this.labelProductName.ForeColor = SystemColors.ButtonFace;
		this.labelProductName.Location = new Point(3, 0);
		this.labelProductName.Margin = new Padding(6, 0, 3, 0);
		this.labelProductName.MaximumSize = new Size(0, 17);
		this.labelProductName.Name = "labelProductName";
		this.labelProductName.Size = new Size(271, 17);
		this.labelProductName.TabIndex = 19;
		this.labelProductName.Text = "برنامج المحاسبة";
		this.labelProductName.TextAlign = ContentAlignment.MiddleRight;
		this.labelVersion.Dock = DockStyle.Fill;
		this.labelVersion.ForeColor = SystemColors.ButtonFace;
		this.labelVersion.Location = new Point(3, 26);
		this.labelVersion.Margin = new Padding(6, 0, 3, 0);
		this.labelVersion.MaximumSize = new Size(0, 17);
		this.labelVersion.Name = "labelVersion";
		this.labelVersion.Size = new Size(271, 17);
		this.labelVersion.TabIndex = 0;
		this.labelVersion.Text = "1.0";
		this.labelVersion.TextAlign = ContentAlignment.MiddleRight;
		this.labelCopyright.Dock = DockStyle.Fill;
		this.labelCopyright.ForeColor = SystemColors.ButtonFace;
		this.labelCopyright.Location = new Point(3, 52);
		this.labelCopyright.Margin = new Padding(6, 0, 3, 0);
		this.labelCopyright.MaximumSize = new Size(0, 17);
		this.labelCopyright.Name = "labelCopyright";
		this.labelCopyright.Size = new Size(271, 17);
		this.labelCopyright.TabIndex = 21;
		this.labelCopyright.Text = "2011";
		this.labelCopyright.TextAlign = ContentAlignment.MiddleRight;
		this.labelCompanyName.Dock = DockStyle.Fill;
		this.labelCompanyName.ForeColor = SystemColors.ButtonFace;
		this.labelCompanyName.Location = new Point(3, 78);
		this.labelCompanyName.Margin = new Padding(6, 0, 3, 0);
		this.labelCompanyName.MaximumSize = new Size(0, 17);
		this.labelCompanyName.Name = "labelCompanyName";
		this.labelCompanyName.Size = new Size(271, 17);
		this.labelCompanyName.TabIndex = 22;
		this.labelCompanyName.Text = "Company Name";
		this.labelCompanyName.TextAlign = ContentAlignment.MiddleRight;
		this.textBoxDescription.Dock = DockStyle.Fill;
		this.textBoxDescription.Location = new Point(3, 107);
		this.textBoxDescription.Margin = new Padding(6, 3, 3, 3);
		this.textBoxDescription.Multiline = true;
		this.textBoxDescription.Name = "textBoxDescription";
		this.textBoxDescription.ReadOnly = true;
		this.textBoxDescription.ScrollBars = ScrollBars.Both;
		this.textBoxDescription.Size = new Size(271, 126);
		this.textBoxDescription.TabIndex = 23;
		this.textBoxDescription.TabStop = false;
		this.okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		this.okButton.DialogResult = DialogResult.Cancel;
		this.okButton.Location = new Point(3, 239);
		this.okButton.Name = "okButton";
		this.okButton.Size = new Size(75, 23);
		this.okButton.TabIndex = 24;
		this.okButton.Text = "&OK";
		this.okButton.add_Click(new EventHandler(this.okButton_Click));
		base.AcceptButton = this.okButton;
		base.AutoScaleDimensions = new SizeF(6, 13);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.BackColor = SystemColors.ControlDarkDark;
		base.ClientSize = new Size(435, 283);
		base.Controls.Add(this.tableLayoutPanel);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "AboutBox1";
		base.Padding = new Padding(9);
		base.RightToLeft = RightToLeft.Yes;
		base.RightToLeftLayout = true;
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		base.Text = "عن البرنامج";
		this.tableLayoutPanel.ResumeLayout(false);
		this.tableLayoutPanel.PerformLayout();
		this.logoPictureBox.EndInit();
		base.ResumeLayout(false);
	}

	private void okButton_Click(object sender, EventArgs e)
	{
		base.Close();
		base.Dispose();
	}
}
}