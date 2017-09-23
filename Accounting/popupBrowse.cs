using System.Windows.Forms;
using System;
using Accounting.Journal;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using Accounting.Properties;

namespace Accounting
{
public class popupBrowse : Form
{
	private bool _dayShow;

	private JournalBll _Journal;

	internal JournalForm _journalForm;

	private Button btnSearch;

	private Button btnSelect;

	private IContainer components;

	internal string dateString;

	internal TagType dateType;

	private DataGridView dgvResult;

	private DateTimePicker dtFrom;

	private DateTimePicker dtTo;

	private DailyJournalDataTable JTable;

	private Label lblFrom;

	private Label lblTo;

	private Label lblView;

	private Dictionary<int, string> months;

	private Panel pnlBrowse;

	private Panel pnlSearch;

	private RadioButton rbDay;

	private RadioButton rbMonth;

	private SplitContainer splitContainer1;

	private TreeView tvResult;

	public popupBrowse()
	{
		this.months = new Dictionary<int, string>();
		this.components = null;
		base();
		this.InitializeComponent();
		this.months.Add(1, "يناير");
		this.months.Add(2, "فبراير");
		this.months.Add(3, "مارس");
		this.months.Add(4, "ابريل");
		this.months.Add(5, "مايو");
		this.months.Add(6, "يونيو");
		this.months.Add(7, "يوليو");
		this.months.Add(8, "أغسطس");
		this.months.Add(9, "سبتمبر");
		this.months.Add(10, "اكتوبر");
		this.months.Add(11, "نوفمبر");
		this.months.Add(12, "ديسمبر");
	}

	private void btnSearch_Click(object sender, EventArgs e)
	{
		int num;
		this.tvResult.Nodes.Clear();
		DateTime @value = this.dtFrom.Value;
		DateTime date = @value.Date;
		@value = this.dtTo.Value;
		DateTime dateTime = @value.Date;
		this._Journal = new JournalBll();
		this._Journal.getJournalFromTo(date, dateTime);
		this.JTable = this._Journal.getJournal();
		if (this.rbDay.Checked)
		{
			popupBrowse _popupBrowse1 = new popupBrowse();
			this._dayShow = true;
			_popupBrowse1.dates = this.JTable.Select<DailyJournalRow,DateTime>(new Func<DailyJournalRow, DateTime>((d) => {
				DateTime dateDT = d.Date_DT;
				return dateDT.Date;
			}
			)).Distinct<DateTime>();
			this.tvResult.Nodes.Add("-1", "كل");
			this.tvResult.Nodes["-1"].Tag = new KeyValuePair<TagType, string>(3, string.Concat(date.ToShortDateString(), "-", dateTime.ToShortDateString()));
			Func<DailyJournalRow, bool> func1 = null;
			popupBrowse _popupBrowse2 = new popupBrowse();
			_popupBrowse2.CS$<>8__localse = _popupBrowse1;
			_popupBrowse2.x = 0;
			while (_popupBrowse2.x < _popupBrowse1.dates.Count<DateTime>())
			{
				&_popupBrowse2.x.ToString().Add(@value = _popupBrowse1.dates.ElementAt<DateTime>(_popupBrowse2.x), @value.ToShortDateString(), "");
				IEnumerable<int> nums = func1 = new Func<DailyJournalRow, bool>(_popupBrowse2.<btnSearch_Click>b__1).Where<DailyJournalRow>(func1).Select<DailyJournalRow,int>(new Func<DailyJournalRow, int>((s) => s.code)).Distinct<int>();
				@value = _popupBrowse1.dates.ElementAt<DateTime>(_popupBrowse2.x).Tag = new KeyValuePair<TagType, string>(@value = @value.Date, @value.ToShortDateString());
				for (int i = 0; i < nums.Count<int>(); i++)
				{
					" | ".Add(string.Concat(@value = _popupBrowse1.dates.ElementAt<DateTime>(_popupBrowse2.x), @value = @value.Date, @value.ToShortDateString()));
					4.Tag = new KeyValuePair<TagType, string>(num = nums.ElementAt<int>(i), num.ToString());
				}
				_popupBrowse2.x = _popupBrowse2.x + 1;
			}
		}
		if (this.rbMonth.Checked)
		{
			popupBrowse _popupBrowse3 = new popupBrowse();
			this._dayShow = false;
			_popupBrowse3.yearResult = this.JTable.Select<DailyJournalRow,int>(new Func<DailyJournalRow, int>((year) => {
				DateTime dateDT = year.Date_DT;
				return dateDT.Year;
			}
			)).Distinct<int>();
			Func<DailyJournalRow, bool> func2 = null;
			popupBrowse _popupBrowse4 = new popupBrowse();
			_popupBrowse4.CS$<>8__locals13 = _popupBrowse3;
			_popupBrowse4.y = 0;
			while (_popupBrowse4.y < _popupBrowse3.yearResult.Count<int>())
			{
				popupBrowse _popupBrowse5 = new popupBrowse();
				&_popupBrowse4.y.ToString().Add(num = _popupBrowse3.yearResult.ElementAt<int>(_popupBrowse4.y), num.ToString());
				2.Tag = new KeyValuePair<TagType, string>(num = _popupBrowse3.yearResult.ElementAt<int>(_popupBrowse4.y), num.ToString());
				func2.monthResult = func2 = new Func<DailyJournalRow, bool>(_popupBrowse4.<btnSearch_Click>b__4).Where<DailyJournalRow>(func2).Select<DailyJournalRow,int>(new Func<DailyJournalRow, int>((month) => {
					DateTime dateDT = month.Date_DT;
					return dateDT.Month;
				}
				)).Distinct<int>();
				Func<DailyJournalRow, bool> func3 = null;
				popupBrowse _popupBrowse6 = new popupBrowse();
				_popupBrowse6.CS$<>8__locals18 = _popupBrowse5;
				_popupBrowse6.CS$<>8__locals16 = _popupBrowse4;
				_popupBrowse6.CS$<>8__locals13 = _popupBrowse3;
				_popupBrowse6.m = 0;
				while (_popupBrowse6.m < _popupBrowse5.monthResult.Count<int>())
				{
					this.tvResult.Nodes[_popupBrowse4.y.ToString()].Nodes.Add(_popupBrowse6.m.ToString(), this.months[_popupBrowse5.monthResult.ElementAt<int>(_popupBrowse6.m)]);
					1.Tag = new KeyValuePair<TagType, string>(num = _popupBrowse5.monthResult.ElementAt<int>(_popupBrowse6.m), num.ToString());
					IEnumerable<DateTime> dateTimes = func3 = new Func<DailyJournalRow, bool>(_popupBrowse6.<btnSearch_Click>b__6).Where<DailyJournalRow>(func3).Select<DailyJournalRow,DateTime>(new Func<DailyJournalRow, DateTime>((day) => {
						DateTime dateDT = day.Date_DT;
						return dateDT.Date;
					}
					)).Distinct<DateTime>();
					for (int j = 0; j < dateTimes.Count<DateTime>(); j++)
					{
						j.ToString().Add(@value = dateTimes.ElementAt<DateTime>(j), @value.ToShortDateString());
						0.Tag = new KeyValuePair<TagType, string>(@value = dateTimes.ElementAt<DateTime>(j), @value.ToShortDateString());
					}
					_popupBrowse6.m = _popupBrowse6.m + 1;
				}
				_popupBrowse4.y = _popupBrowse4.y + 1;
			}
		}
	}

	private void btnSelect_Click(object sender, EventArgs e)
	{
		Form1 mdiParent = (Form1)this._journalForm.MdiParent;
		this._journalForm.Close();
		this._journalForm = new JournalForm();
		this._journalForm._journal = this._Journal;
		this._journalForm.MdiParent = mdiParent;
		this._journalForm.old = true;
		this._journalForm.dateString = this.dateString;
		if (this.dateType == TagType.Day)
		{
			this._journalForm.dtDate.Text = this.dateString;
		}
		else
		{
			this._journalForm.dtDate.Enabled = false;
		}
		this._journalForm.btnAdd.Enabled = false;
		this._journalForm.resetUI(mdiParent.UserName);
		this._journalForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this._journalForm.Dock = DockStyle.Fill;
		this._journalForm.Show();
		base.Close();
		base.Dispose();
	}

	private DateTime[] correctDate(int month, int year)
	{
		DateTime[] dateTimeArray1;
		try
		{
			DateTime[] dateTimeArray2 = new DateTime[2];
			switch (month)
			{
				case 0:
				{
					dateTimeArray2[0] = new DateTime(year, month, 1);
					dateTimeArray2[1] = new DateTime(year, month, 31);
					break;
				}
				case 1:
				{
					dateTimeArray2[0] = new DateTime(year, month, 1);
					dateTimeArray2[1] = new DateTime(year, month, 29);
					break;
				}
				case 3:
				{
					dateTimeArray2[0] = new DateTime(year, month, 1);
					dateTimeArray2[1] = new DateTime(year, month, 30);
					break;
				}
			}
			dateTimeArray1 = dateTimeArray2;
		}
		catch (Exception exception)
		{
			throw new Exception(string.Concat("months error", exception.Message));
		}
		return dateTimeArray1;
	}

	private void dgvResult_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
	{
		DataGridView dataGridView = (DataGridView)sender;
		if (dataGridView.Rows.Count <= 0)
		{
			this.btnSelect.Enabled = false;
		}
		else
		{
			this.btnSelect.Enabled = true;
		}
	}

	private void dgvResult_KeyDown(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		if (keyCode != Keys.Right && keyCode == Keys.S || this.tvResult.Nodes.Count != 0)
		{
			this.tvResult.Focus();
			this.tvResult.SelectedNode = this.tvResult.Nodes[0];
		}
	L_0086:
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && this.components != null)
		{
			this.components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void dtFrom_KeyDown(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		switch (e.KeyCode)
		{
			case 0:
			{
				this.rbDay.Focus();
				break;
			}
			case 2:
			{
				this.dtTo.Focus();
				break;
			}
		}
	}

	private void dtTo_KeyDown(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		if (keyCode != Keys.Return)
		{
			switch (keyCode)
			{
				case Keys.None:
				{
					this.dtFrom.Focus();
					break;
				}
				case Keys.RButton:
				{
					this.btnSearch.Focus();
					break;
				}
			}
		}
	}

	private void GetData(TreeNode node)
	{
		string[] strArrays;
		KeyValuePair<TagType, string> keyValuePair;
		int num;
		int num2;
		DateTime[] dateTimeArray;
		int num3;
		char[] chrArray;
		KeyValuePair<TagType, string> tag = (KeyValuePair<TagType, string>)node.Tag;
		DailyJournalDataTable dailyJournalDataTable = new DailyJournalDataTable();
		if (&tag.Key == 4)
		{
			int num4 = Convert.ToInt32(tag.Value);
			this._Journal.getJournalByCode(num4);
			this.dateType = TagType.Day;
			DateTime dateDT = this._Journal.getJournal()[0].Date_DT.dateString = dateDT.ToShortDateString();
		}
		else
		{
			DateTime dateTime1 = new DateTime();
			DateTime dateTime2 = new DateTime();
			TagType key = &tag.Key;
			switch (&tag.Key)
			{
				case TagType.Day:
				{
					dateTime1 = dateTime2 = Convert.ToDateTime(tag.Value);
					this.dateType = 0;
					this.dateString = dateTime1.ToShortDateString();
					break;
				}
				case TagType.Month:
				{
					keyValuePair = (KeyValuePair<TagType, string>)node.Parent.Tag;
					num = Convert.ToInt32(tag.Value.ToString());
					num2 = Convert.ToInt32(keyValuePair.Value);
					dateTimeArray = this.correctDate(num, num2);
					dateTime1 = dateTimeArray[0];
					dateTime2 = dateTimeArray[1];
					this.dateType = 1;
					this.dateString = string.Concat("لشهر ", this.months[num]);
					break;
				}
				case TagType.Year:
				{
					num3 = Convert.ToInt32(tag.Value);
					dateTime1 = new DateTime(num3, 1, 1);
					dateTime2 = new DateTime(num3, 12, 31);
					this.dateType = 2;
					this.dateString = string.Concat("لسنة ", num3);
					break;
				}
				case TagType.FromTo:
				{
					strArrays = &tag.Value.Split(new char[] { 45 });
					dateTime1 = Convert.ToDateTime(strArrays[0]);
					dateTime2 = Convert.ToDateTime(strArrays[1]);
					this.dateType = 3;
					this.dateString = string.Concat("للفترة ", dateTime1.ToShortDateString(), " - ", dateTime2.ToShortDateString());
					break;
				}
			}
			this._Journal.getJournalFromTo(dateTime1, dateTime2);
		}
	}

	private void InitializeComponent()
	{
		DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
		DataGridViewCellStyle controlDark = new DataGridViewCellStyle();
		this.splitContainer1 = new SplitContainer();
		this.tvResult = new TreeView();
		this.pnlSearch = new Panel();
		this.btnSearch = new Button();
		this.dtTo = new DateTimePicker();
		this.dtFrom = new DateTimePicker();
		this.rbMonth = new RadioButton();
		this.rbDay = new RadioButton();
		this.lblTo = new Label();
		this.lblFrom = new Label();
		this.lblView = new Label();
		this.dgvResult = new DataGridView();
		this.pnlBrowse = new Panel();
		this.btnSelect = new Button();
		this.splitContainer1.Panel1.SuspendLayout();
		this.splitContainer1.Panel2.SuspendLayout();
		this.splitContainer1.SuspendLayout();
		this.pnlSearch.SuspendLayout();
		this.dgvResult.BeginInit();
		this.pnlBrowse.SuspendLayout();
		base.SuspendLayout();
		this.splitContainer1.Dock = DockStyle.Fill;
		this.splitContainer1.Location = new Point(0, 0);
		this.splitContainer1.Name = "splitContainer1";
		this.splitContainer1.Panel1.Controls.Add(this.tvResult);
		this.splitContainer1.Panel1.Controls.Add(this.pnlSearch);
		this.splitContainer1.Panel1.RightToLeft = RightToLeft.Yes;
		this.splitContainer1.Panel2.Controls.Add(this.dgvResult);
		this.splitContainer1.Panel2.Controls.Add(this.pnlBrowse);
		this.splitContainer1.Panel2.RightToLeft = RightToLeft.Yes;
		this.splitContainer1.Size = new Size(709, 528);
		this.splitContainer1.SplitterDistance = 247;
		this.splitContainer1.TabIndex = 6;
		this.splitContainer1.TabStop = false;
		this.tvResult.BackColor = SystemColors.ButtonFace;
		this.tvResult.Dock = DockStyle.Fill;
		this.tvResult.Location = new Point(0, 196);
		this.tvResult.Name = "tvResult";
		this.tvResult.RightToLeftLayout = true;
		this.tvResult.Size = new Size(247, 332);
		this.tvResult.TabIndex = 1;
		this.tvResult.NodeMouseDoubleClick += new TreeNodeMouseClickEventHandler(this.tvResult_NodeMouseDoubleClick);
		this.tvResult.add_KeyDown(new KeyEventHandler(this.tvResult_KeyDown));
		this.pnlSearch.Controls.Add(this.btnSearch);
		this.pnlSearch.Controls.Add(this.dtTo);
		this.pnlSearch.Controls.Add(this.dtFrom);
		this.pnlSearch.Controls.Add(this.rbMonth);
		this.pnlSearch.Controls.Add(this.rbDay);
		this.pnlSearch.Controls.Add(this.lblTo);
		this.pnlSearch.Controls.Add(this.lblFrom);
		this.pnlSearch.Controls.Add(this.lblView);
		this.pnlSearch.Dock = DockStyle.Top;
		this.pnlSearch.Location = new Point(0, 0);
		this.pnlSearch.Name = "pnlSearch";
		this.pnlSearch.Size = new Size(247, 196);
		this.pnlSearch.TabIndex = 0;
		this.btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.btnSearch.BackColor = Color.FromArgb(150, 180, 200);
		this.btnSearch.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.btnSearch.FlatStyle = FlatStyle.Flat;
		this.btnSearch.Image = Resources.Search;
		this.btnSearch.Location = new Point(9, 163);
		this.btnSearch.Name = "btnSearch";
		this.btnSearch.Size = new Size(75, 27);
		this.btnSearch.TabIndex = 9;
		this.btnSearch.Text = "بحث";
		this.btnSearch.TextImageRelation = TextImageRelation.TextBeforeImage;
		this.btnSearch.UseVisualStyleBackColor = false;
		this.btnSearch.add_Click(new EventHandler(this.btnSearch_Click));
		this.dtTo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.dtTo.Location = new Point(9, 123);
		this.dtTo.Name = "dtTo";
		this.dtTo.RightToLeftLayout = true;
		this.dtTo.Size = new Size(172, 20);
		this.dtTo.TabIndex = 8;
		this.dtTo.add_KeyDown(new KeyEventHandler(this.dtTo_KeyDown));
		this.dtFrom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.dtFrom.Location = new Point(9, 77);
		this.dtFrom.Name = "dtFrom";
		this.dtFrom.RightToLeftLayout = true;
		this.dtFrom.Size = new Size(172, 20);
		this.dtFrom.TabIndex = 7;
		this.dtFrom.add_KeyDown(new KeyEventHandler(this.dtFrom_KeyDown));
		this.rbMonth.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.rbMonth.AutoSize = true;
		this.rbMonth.ForeColor = SystemColors.ButtonFace;
		this.rbMonth.Location = new Point(47, 35);
		this.rbMonth.Name = "rbMonth";
		this.rbMonth.Size = new Size(86, 17);
		this.rbMonth.TabIndex = 6;
		this.rbMonth.Text = "حسب الشهر";
		this.rbMonth.UseVisualStyleBackColor = true;
		this.rbMonth.add_KeyDown(new KeyEventHandler(this.rbMonth_KeyDown));
		this.rbDay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.rbDay.AutoSize = true;
		this.rbDay.Checked = true;
		this.rbDay.ForeColor = SystemColors.ButtonFace;
		this.rbDay.Location = new Point(157, 35);
		this.rbDay.Name = "rbDay";
		this.rbDay.Size = new Size(38, 17);
		this.rbDay.TabIndex = 5;
		this.rbDay.TabStop = true;
		this.rbDay.Text = "كل";
		this.rbDay.UseVisualStyleBackColor = true;
		this.rbDay.add_KeyDown(new KeyEventHandler(this.rbDay_KeyDown));
		this.lblTo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblTo.AutoSize = true;
		this.lblTo.ForeColor = SystemColors.ButtonFace;
		this.lblTo.Location = new Point(187, 123);
		this.lblTo.Name = "lblTo";
		this.lblTo.Size = new Size(48, 13);
		this.lblTo.TabIndex = 2;
		this.lblTo.Text = "الى تاريخ";
		this.lblFrom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblFrom.AutoSize = true;
		this.lblFrom.ForeColor = SystemColors.ButtonFace;
		this.lblFrom.Location = new Point(190, 77);
		this.lblFrom.Name = "lblFrom";
		this.lblFrom.Size = new Size(45, 13);
		this.lblFrom.TabIndex = 1;
		this.lblFrom.Text = "من تاريخ";
		this.lblView.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.lblView.AutoSize = true;
		this.lblView.ForeColor = SystemColors.ButtonFace;
		this.lblView.Location = new Point(168, 9);
		this.lblView.Name = "lblView";
		this.lblView.Size = new Size(67, 13);
		this.lblView.TabIndex = 0;
		this.lblView.Text = "طريقة العرض";
		this.dgvResult.AllowUserToAddRows = false;
		this.dgvResult.AllowUserToDeleteRows = false;
		this.dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = Color.FromArgb(150, 180, 200);
		dataGridViewCellStyle.Font = new Font("Tahoma", 8);
		dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
		this.dgvResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		this.dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvResult.Dock = DockStyle.Fill;
		this.dgvResult.Location = new Point(0, 33);
		this.dgvResult.MultiSelect = false;
		this.dgvResult.Name = "dgvResult";
		this.dgvResult.ReadOnly = true;
		controlDark.SelectionBackColor = SystemColors.ControlDark;
		this.dgvResult.RowsDefaultCellStyle = controlDark;
		this.dgvResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dgvResult.Size = new Size(458, 495);
		this.dgvResult.TabIndex = 1;
		this.dgvResult.add_KeyDown(new KeyEventHandler(this.dgvResult_KeyDown));
		this.dgvResult.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(this.dgvResult_DataBindingComplete);
		this.pnlBrowse.Controls.Add(this.btnSelect);
		this.pnlBrowse.Dock = DockStyle.Top;
		this.pnlBrowse.Location = new Point(0, 0);
		this.pnlBrowse.Name = "pnlBrowse";
		this.pnlBrowse.Size = new Size(458, 33);
		this.pnlBrowse.TabIndex = 0;
		this.btnSelect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.btnSelect.BackColor = Color.FromArgb(150, 180, 200);
		this.btnSelect.Enabled = false;
		this.btnSelect.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 180, 200);
		this.btnSelect.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 180, 200);
		this.btnSelect.FlatStyle = FlatStyle.Flat;
		this.btnSelect.Location = new Point(380, 7);
		this.btnSelect.Name = "btnSelect";
		this.btnSelect.Size = new Size(75, 23);
		this.btnSelect.TabIndex = 0;
		this.btnSelect.Text = "اختيار";
		this.btnSelect.UseVisualStyleBackColor = false;
		this.btnSelect.add_Click(new EventHandler(this.btnSelect_Click));
		base.AutoScaleDimensions = new SizeF(6, 13);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.BackColor = SystemColors.ControlDarkDark;
		base.ClientSize = new Size(709, 528);
		base.Controls.Add(this.splitContainer1);
		base.MaximizeBox = false;
		base.Name = "popupBrowse";
		base.RightToLeft = RightToLeft.Yes;
		base.RightToLeftLayout = true;
		base.ShowIcon = false;
		base.Text = "استعراض";
		base.Load += new EventHandler(this.popupBrowse_Load);
		this.splitContainer1.Panel1.ResumeLayout(false);
		this.splitContainer1.Panel2.ResumeLayout(false);
		this.splitContainer1.ResumeLayout(false);
		this.pnlSearch.ResumeLayout(false);
		this.pnlSearch.PerformLayout();
		this.dgvResult.EndInit();
		this.pnlBrowse.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void popupBrowse_Load(object sender, EventArgs e)
	{
	}

	private void rbDay_KeyDown(object sender, KeyEventArgs e)
	{
		e.KeyCode;
		goto L_000a;
	L_000a:
	}

	private void rbMonth_KeyDown(object sender, KeyEventArgs e)
	{
		e.KeyCode;
		goto L_000a;
	L_000a:
	}

	private void tvResult_KeyDown(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		if (keyCode != Keys.Return && keyCode == Keys.Space || this.tvResult.SelectedNode != null)
		{
			TreeNode selectedNode = this.tvResult.SelectedNode;
			this.GetData(selectedNode);
			DailyJournalDataTable journal = this._Journal.getJournal();
			journal.AccountColumn.ColumnName = "رقم الحساب";
			journal.codeColumn.ColumnName = "رقم القيد";
			journal.CreditColumn.ColumnName = "دائن";
			journal.DebitColumn.ColumnName = "مدين";
			journal.Descrip_VCColumn.ColumnName = "الشرح";
			journal.Date_DTColumn.ColumnName = "التاريخ";
			this.dgvResult.DataSource = journal;
		}
	L_0107:
	}

	private void tvResult_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
	{
		TreeNode node = e.Node;
		this.GetData(node);
		DailyJournalDataTable journal = this._Journal.getJournal();
		journal.AccountColumn.ColumnName = "رقم الحساب";
		journal.codeColumn.ColumnName = "رقم القيد";
		journal.CreditColumn.ColumnName = "دائن";
		journal.DebitColumn.ColumnName = "مدين";
		journal.Descrip_VCColumn.ColumnName = "الشرح";
		journal.Date_DTColumn.ColumnName = "التاريخ";
		this.dgvResult.DataSource = journal;
	}
}
}