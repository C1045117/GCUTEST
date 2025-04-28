using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GCUv2.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

[DesignerGenerated]
public class frmReportBankBook : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboBankAccount")]
	private ComboBox _cboBankAccount;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnReset")]
	private Button _btnReset;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnWord")]
	private Button _btnWord;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvList")]
	private DataGridView _dgvList;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSearch")]
	private Button _btnSearch;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dtpEnd")]
	private DateTimePicker _dtpEnd;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dtpBegin")]
	private DateTimePicker _dtpBegin;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnPrint")]
	private Button _btnPrint;

	[field: AccessedThroughProperty("txtDescription")]
	internal virtual TextBox txtDescription
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox cboBankAccount
	{
		[CompilerGenerated]
		get
		{
			return _cboBankAccount;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cboBankAccount_SelectedIndexChanged;
			ComboBox comboBox = _cboBankAccount;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_cboBankAccount = value;
			comboBox = _cboBankAccount;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	internal virtual Button btnReset
	{
		[CompilerGenerated]
		get
		{
			return _btnReset;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnReset_Click;
			Button button = _btnReset;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnReset = value;
			button = _btnReset;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button btnWord
	{
		[CompilerGenerated]
		get
		{
			return _btnWord;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnWord_Click;
			Button button = _btnWord;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnWord = value;
			button = _btnWord;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTotal")]
	internal virtual Label lblTotal
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboAccount")]
	internal virtual ComboBox cboAccount
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView dgvList
	{
		[CompilerGenerated]
		get
		{
			return _dgvList;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = dgvList_DoubleClick;
			KeyEventHandler value3 = dgvList_KeyDown;
			EventHandler value4 = dgvList_GotFocus;
			EventHandler value5 = dgvList_LostFocus;
			DataGridView dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.DoubleClick -= value2;
				dataGridView.KeyDown -= value3;
				dataGridView.GotFocus -= value4;
				dataGridView.LostFocus -= value5;
			}
			_dgvList = value;
			dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.DoubleClick += value2;
				dataGridView.KeyDown += value3;
				dataGridView.GotFocus += value4;
				dataGridView.LostFocus += value5;
			}
		}
	}

	internal virtual Button btnSearch
	{
		[CompilerGenerated]
		get
		{
			return _btnSearch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnSearch_Click;
			Button button = _btnSearch;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnSearch = value;
			button = _btnSearch;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DateTimePicker dtpEnd
	{
		[CompilerGenerated]
		get
		{
			return _dtpEnd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = dtpEnd_KeyDown;
			DateTimePicker dateTimePicker = _dtpEnd;
			if (dateTimePicker != null)
			{
				dateTimePicker.KeyDown -= value2;
			}
			_dtpEnd = value;
			dateTimePicker = _dtpEnd;
			if (dateTimePicker != null)
			{
				dateTimePicker.KeyDown += value2;
			}
		}
	}

	internal virtual DateTimePicker dtpBegin
	{
		[CompilerGenerated]
		get
		{
			return _dtpBegin;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = dtpBegin_KeyDown;
			DateTimePicker dateTimePicker = _dtpBegin;
			if (dateTimePicker != null)
			{
				dateTimePicker.KeyDown -= value2;
			}
			_dtpBegin = value;
			dateTimePicker = _dtpBegin;
			if (dateTimePicker != null)
			{
				dateTimePicker.KeyDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboSearchType")]
	internal virtual ComboBox cboSearchType
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnPrint
	{
		[CompilerGenerated]
		get
		{
			return _btnPrint;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnPrint_Click;
			Button button = _btnPrint;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnPrint = value;
			button = _btnPrint;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.txtDescription = new System.Windows.Forms.TextBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.cboBankAccount = new System.Windows.Forms.ComboBox();
		this.btnReset = new System.Windows.Forms.Button();
		this.btnWord = new System.Windows.Forms.Button();
		this.Label1 = new System.Windows.Forms.Label();
		this.lblTotal = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.cboAccount = new System.Windows.Forms.ComboBox();
		this.dgvList = new System.Windows.Forms.DataGridView();
		this.btnSearch = new System.Windows.Forms.Button();
		this.Label2 = new System.Windows.Forms.Label();
		this.dtpEnd = new System.Windows.Forms.DateTimePicker();
		this.dtpBegin = new System.Windows.Forms.DateTimePicker();
		this.Label5 = new System.Windows.Forms.Label();
		this.cboSearchType = new System.Windows.Forms.ComboBox();
		this.btnPrint = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		base.SuspendLayout();
		this.txtDescription.Location = new System.Drawing.Point(86, 145);
		this.txtDescription.Name = "txtDescription";
		this.txtDescription.Size = new System.Drawing.Size(142, 20);
		this.txtDescription.TabIndex = 5;
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(6, 148);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(62, 13);
		this.Label4.TabIndex = 171;
		this.Label4.Text = "Keterangan";
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(6, 94);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(53, 13);
		this.Label3.TabIndex = 170;
		this.Label3.Text = "Rekening";
		this.cboBankAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboBankAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboBankAccount.FormattingEnabled = true;
		this.cboBankAccount.Location = new System.Drawing.Point(86, 91);
		this.cboBankAccount.Name = "cboBankAccount";
		this.cboBankAccount.Size = new System.Drawing.Size(142, 21);
		this.cboBankAccount.TabIndex = 3;
		this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnReset.Location = new System.Drawing.Point(140, 171);
		this.btnReset.Name = "btnReset";
		this.btnReset.Size = new System.Drawing.Size(47, 24);
		this.btnReset.TabIndex = 163;
		this.btnReset.Text = "&Reset";
		this.btnReset.UseVisualStyleBackColor = true;
		this.btnWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnWord.Location = new System.Drawing.Point(816, 437);
		this.btnWord.Name = "btnWord";
		this.btnWord.Size = new System.Drawing.Size(73, 23);
		this.btnWord.TabIndex = 165;
		this.btnWord.Text = "&Word";
		this.btnWord.UseVisualStyleBackColor = true;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(5, 15);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(71, 13);
		this.Label1.TabIndex = 169;
		this.Label1.Text = "Tanggal awal";
		this.lblTotal.AutoSize = true;
		this.lblTotal.Location = new System.Drawing.Point(234, 437);
		this.lblTotal.Name = "lblTotal";
		this.lblTotal.Size = new System.Drawing.Size(91, 13);
		this.lblTotal.TabIndex = 168;
		this.lblTotal.Text = "Total Pencarian: -";
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.Location = new System.Drawing.Point(6, 121);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(32, 13);
		this.Label7.TabIndex = 167;
		this.Label7.Text = "Akun";
		this.cboAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboAccount.FormattingEnabled = true;
		this.cboAccount.Location = new System.Drawing.Point(86, 118);
		this.cboAccount.Name = "cboAccount";
		this.cboAccount.Size = new System.Drawing.Size(142, 21);
		this.cboAccount.TabIndex = 4;
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.Location = new System.Drawing.Point(237, 12);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(731, 419);
		this.dgvList.TabIndex = 164;
		this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSearch.Location = new System.Drawing.Point(87, 171);
		this.btnSearch.Name = "btnSearch";
		this.btnSearch.Size = new System.Drawing.Size(47, 24);
		this.btnSearch.TabIndex = 162;
		this.btnSearch.Text = "&Cari";
		this.btnSearch.UseVisualStyleBackColor = true;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(5, 41);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(72, 13);
		this.Label2.TabIndex = 166;
		this.Label2.Text = "Tanggal akhir";
		this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpEnd.Location = new System.Drawing.Point(86, 38);
		this.dtpEnd.Name = "dtpEnd";
		this.dtpEnd.Size = new System.Drawing.Size(142, 20);
		this.dtpEnd.TabIndex = 1;
		this.dtpBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpBegin.Location = new System.Drawing.Point(86, 12);
		this.dtpBegin.Name = "dtpBegin";
		this.dtpBegin.Size = new System.Drawing.Size(142, 20);
		this.dtpBegin.TabIndex = 0;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(5, 67);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(79, 13);
		this.Label5.TabIndex = 173;
		this.Label5.Text = "Tipe Pencarian";
		this.cboSearchType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboSearchType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboSearchType.FormattingEnabled = true;
		this.cboSearchType.Location = new System.Drawing.Point(86, 64);
		this.cboSearchType.Name = "cboSearchType";
		this.cboSearchType.Size = new System.Drawing.Size(142, 21);
		this.cboSearchType.TabIndex = 2;
		this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnPrint.Location = new System.Drawing.Point(895, 437);
		this.btnPrint.Name = "btnPrint";
		this.btnPrint.Size = new System.Drawing.Size(73, 23);
		this.btnPrint.TabIndex = 166;
		this.btnPrint.Text = "Cetak";
		this.btnPrint.UseVisualStyleBackColor = true;
		base.AcceptButton = this.btnSearch;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(980, 468);
		base.Controls.Add(this.btnPrint);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.cboSearchType);
		base.Controls.Add(this.txtDescription);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.cboBankAccount);
		base.Controls.Add(this.btnReset);
		base.Controls.Add(this.btnWord);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.lblTotal);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.cboAccount);
		base.Controls.Add(this.dgvList);
		base.Controls.Add(this.btnSearch);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.dtpEnd);
		base.Controls.Add(this.dtpBegin);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmReportBankBook";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Report Buku Bank";
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmReportBankBook()
	{
		base.KeyDown += frmReportBankBook_KeyDown;
		base.Load += frmReportBankBook_Load;
		InitializeComponent();
		DoubleBuffered = true;
		base.MdiParent = MyProject.Forms.frmMenu;
		ComboBox combo = cboBankAccount;
		cCombo.getBankAccount(ref combo, 0, Module1.pubGroupId, All: false, GroupDefault: false, Active: true, "TRANSACTION", 0);
		cboBankAccount = combo;
		combo = cboAccount;
		cCombo.getAccount(ref combo, All: true, 0, 0, 0, 0, 99, 0, 3, 0, 1);
		cboAccount = combo;
		combo = cboSearchType;
		cCombo.getSearchType(ref combo);
		cboSearchType = combo;
	}

	private void frmReportBankBook_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void frmReportBankBook_Load(object sender, EventArgs e)
	{
		prepareForm();
	}

	private void prepareForm()
	{
		btnWord.Enabled = false;
		btnPrint.Enabled = false;
		dtpBegin.Value = Module1.getFirstDateInMonth(DateAndTime.Now);
		dtpEnd.Value = DateAndTime.Now;
		cboBankAccount.SelectedIndex = 0;
		cboAccount.SelectedIndex = 0;
		cboSearchType.SelectedIndex = 0;
		dgvList.DataSource = null;
		lblTotal.Text = "Total Pencarian: -";
		dtpBegin.Focus();
	}

	private void dtpBegin_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Space)
		{
			dtpEnd.Focus();
			dtpBegin.Focus();
			dtpEnd.Value = dtpBegin.Value;
		}
		else if (e.KeyCode == Keys.ControlKey)
		{
			dtpEnd.Focus();
			dtpBegin.Focus();
			dtpBegin.Value = Module1.getFirstDateInMonth(dtpBegin.Value);
			dtpEnd.Value = Module1.getLastDateInMonth(dtpBegin.Value);
		}
	}

	private void dtpEnd_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Space)
		{
			dtpBegin.Focus();
			dtpEnd.Focus();
			dtpBegin.Value = dtpEnd.Value;
		}
		else if (e.KeyCode == Keys.ControlKey)
		{
			dtpBegin.Focus();
			dtpEnd.Focus();
			dtpBegin.Value = Module1.getFirstDateInMonth(dtpEnd.Value);
			dtpEnd.Value = Module1.getLastDateInMonth(dtpEnd.Value);
		}
	}

	private void btnSearch_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		double num3 = default(double);
		double num4 = default(double);
		double num5 = default(double);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					cComboItem cComboItem2 = (cComboItem)cboBankAccount.SelectedItem;
					cComboItem cComboItem3 = (cComboItem)cboAccount.SelectedItem;
					cComboItem cComboItem4 = (cComboItem)cboSearchType.SelectedItem;
					if (DateTime.Compare(dtpBegin.Value, Module1.pubBalanceDate) < 0)
					{
						Interaction.MsgBox("Data sebelum " + Conversions.ToString(Module1.pubBalanceDate) + " tidak tersedia.");
						dtpBegin.Focus();
						goto end_IL_0001;
					}
					if (cboBankAccount.SelectedIndex == -1)
					{
						Interaction.MsgBox("Rekening yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
						cboBankAccount.Focus();
						goto end_IL_0001;
					}
					if (cboAccount.SelectedIndex == -1)
					{
						Interaction.MsgBox("Akun yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
						cboAccount.Focus();
						goto end_IL_0001;
					}
					if (cboSearchType.SelectedIndex == -1)
					{
						Interaction.MsgBox("Tipe Pencarian yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
						cboSearchType.Focus();
						goto end_IL_0001;
					}
					Cursor = Cursors.WaitCursor;
					DataTable dataTable = new DataTable();
					btnSearch.Focus();
					bool flag = cGroup.ShowBankBalance(Module1.pubGroupId, Conversions.ToInteger(cComboItem2.Value));
					dataTable = cBankAccount.BankBook(Module1.pubBalanceDate, dtpBegin.Value, dtpEnd.Value, Conversions.ToInteger(cComboItem2.Value), Conversions.ToInteger(cComboItem3.Value), Module1.cleanString(txtDescription.Text), Module1.pubGroupId, Conversions.ToInteger(cComboItem4.Value), flag);
					formatGrid(Conversions.ToInteger(cComboItem4.Value));
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataRow["orderby1"], 2, TextCompare: false), Operators.CompareObjectNotEqual(dataRow["debit"], 0, TextCompare: false))))
						{
							num3 = Conversions.ToDouble(Operators.SubtractObject(num3, dataRow["debit"]));
							dgvList.Rows.Add(dataRow["type"], dataRow["id"], dataRow["bankBookDate"], dataRow["Description"], dataRow["accountNumber"], Module1.formatCustomDecimal(Conversions.ToString(dataRow["debit"]), 2), "", Module1.formatCustomDecimal(Conversions.ToString(num3), 2));
							num4 = Conversions.ToDouble(Operators.AddObject(num4, dataRow["debit"]));
						}
						else if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataRow["orderby1"], 2, TextCompare: false), Operators.CompareObjectNotEqual(dataRow["credit"], 0, TextCompare: false))))
						{
							num3 = Conversions.ToDouble(Operators.AddObject(num3, dataRow["credit"]));
							dgvList.Rows.Add(dataRow["type"], dataRow["id"], dataRow["bankBookDate"], dataRow["Description"], dataRow["accountNumber"], "", Module1.formatCustomDecimal(Conversions.ToString(dataRow["credit"]), 2), Module1.formatCustomDecimal(Conversions.ToString(num3), 2));
							num5 = Conversions.ToDouble(Operators.AddObject(num5, dataRow["credit"]));
						}
						else if (Operators.ConditionalCompareObjectEqual(dataRow["orderby1"], 1, TextCompare: false))
						{
							num3 = Conversions.ToDouble(Operators.AddObject(num3, dataRow["debit"]));
							dgvList.Rows.Add(0, 0, "", dataRow["Description"], "", "", "", Module1.formatCustomDecimal(Conversions.ToString(num3), 2));
						}
						if (!Operators.ConditionalCompareObjectGreaterEqual(dataRow["type"], 10, TextCompare: false))
						{
						}
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					dgvList.Rows.Add(0, 0, "", "", "", Module1.formatCustomDecimal(Conversions.ToString(num4), 2), Module1.formatCustomDecimal(Conversions.ToString(num5), 2), "");
					if (flag)
					{
						dgvList.Columns[7].Visible = true;
					}
					else
					{
						dgvList.Columns[7].Visible = false;
					}
					dgvList.Focus();
					if (dataTable.Rows.Count == 0)
					{
						Interaction.MsgBox("Data tidak ditemukan", MsgBoxStyle.Information);
						btnWord.Enabled = false;
						btnPrint.Enabled = false;
						dtpBegin.Focus();
					}
					else
					{
						if (Module1.pubPreviewReport)
						{
							btnWord.Enabled = true;
						}
						if (Module1.pubPrintReport)
						{
							btnPrint.Enabled = true;
						}
					}
					lblTotal.Text = "Total Pencarian: " + Conversions.ToString(dataTable.Rows.Count);
					Cursor = Cursors.Default;
					goto end_IL_0001;
				}
				case 1701:
					num = -1;
					switch (num2)
					{
					case 2:
						Cursor = Cursors.Default;
						Module1.SaveError(Information.Err(), "frmReportBankBook", "btnSearch_click", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1701;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void formatGrid(int SearchType)
	{
		dgvList.Rows.Clear();
		dgvList.Columns.Clear();
		dgvList.Columns.Add("", "Type");
		dgvList.Columns.Add("", "Id");
		dgvList.Columns.Add("", "Tanggal");
		dgvList.Columns.Add("", "Deskripsi");
		dgvList.Columns.Add("", "Akun");
		dgvList.Columns.Add("", "Debit");
		dgvList.Columns.Add("", "Kredit");
		dgvList.Columns.Add("", "Saldo");
		dgvList.Columns[0].Visible = false;
		dgvList.Columns[1].Visible = false;
		dgvList.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvList.Columns[2].Width = 68;
		dgvList.Columns[3].Width = 290;
		dgvList.Columns[4].Width = 60;
		dgvList.Columns[5].Width = 92;
		dgvList.Columns[6].Width = 92;
		dgvList.Columns[7].Width = 105;
		dgvList.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		if (SearchType == 1)
		{
			dgvList.Columns[2].Visible = true;
		}
		else
		{
			dgvList.Columns[2].Visible = false;
		}
		dgvList.RowHeadersVisible = false;
		dgvList.AllowUserToAddRows = false;
		dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvList.ReadOnly = true;
		dgvList.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvList.AllowUserToResizeRows = false;
		dgvList.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Regular);
		foreach (object column in dgvList.Columns)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(column);
			NewLateBinding.LateSet(objectValue, null, "SortMode", new object[1] { DataGridViewColumnSortMode.NotSortable }, null, null);
		}
		dgvList.DefaultCellStyle.Font = new Font("Segoe UI", 8f, FontStyle.Regular);
	}

	private void dgvList_DoubleClick(object sender, EventArgs e)
	{
		getData();
	}

	private void dgvList_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			getData();
			e.SuppressKeyPress = true;
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			btnReset.Focus();
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			btnWord.Focus();
			e.SuppressKeyPress = true;
		}
	}

	private void dgvList_GotFocus(object sender, EventArgs e)
	{
		btnSearch.NotifyDefault(value: false);
		if (dgvList.RowCount > 0)
		{
			dgvList.CurrentRow.Selected = true;
		}
	}

	private void dgvList_LostFocus(object sender, EventArgs e)
	{
		if (dgvList.RowCount > 0)
		{
			dgvList.CurrentRow.Selected = false;
		}
	}

	private void getData()
	{
		if ((dgvList.RowCount > 0) & (Conversion.Val(RuntimeHelpers.GetObjectValue(dgvList[0, dgvList.CurrentRow.Index].Value)) == 2.0) & (Conversion.Val(RuntimeHelpers.GetObjectValue(dgvList[1, dgvList.CurrentRow.Index].Value)) > 0.0))
		{
			MyProject.Forms.frmCashTransaction.Show();
			MyProject.Forms.frmCashTransaction.prepareForm(SaveNew: false);
			MyProject.Forms.frmCashTransaction.CurrentId = Conversions.ToDouble(dgvList[1, dgvList.CurrentRow.Index].Value);
			MyProject.Forms.frmCashTransaction.LoadData();
			MyProject.Forms.frmCashTransaction.Activate();
			MyProject.Forms.frmCashTransaction.WindowState = FormWindowState.Normal;
		}
		else if ((dgvList.RowCount > 0) & (Conversion.Val(RuntimeHelpers.GetObjectValue(dgvList[0, dgvList.CurrentRow.Index].Value)) == 3.0) & (Conversion.Val(RuntimeHelpers.GetObjectValue(dgvList[1, dgvList.CurrentRow.Index].Value)) > 0.0))
		{
			MyProject.Forms.frmBankTransaction.Show();
			MyProject.Forms.frmBankTransaction.prepareForm(SaveNew: false);
			MyProject.Forms.frmBankTransaction.CurrentId = Conversions.ToDouble(dgvList[1, dgvList.CurrentRow.Index].Value);
			MyProject.Forms.frmBankTransaction.LoadData();
			MyProject.Forms.frmBankTransaction.Activate();
			MyProject.Forms.frmBankTransaction.WindowState = FormWindowState.Normal;
		}
	}

	private void btnWord_Click(object sender, EventArgs e)
	{
		ExportReport(Print: false);
	}

	private void ExportReport(bool Print)
	{
		dgvList.SelectAll();
		dgvList.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
		Clipboard.SetDataObject(dgvList.GetClipboardContent());
		dgvList.ClearSelection();
		dgvList.Rows[0].Selected = true;
		MsWord msWord = new MsWord();
		msWord.rptWordNew(dgvList.Rows.Count, dgvList.Columns.Count, "LLLRRR", blnPortrait: true, "", Print);
	}

	private void btnReset_Click(object sender, EventArgs e)
	{
		prepareForm();
	}

	private void cboBankAccount_SelectedIndexChanged(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboBankAccount.SelectedItem;
		if (!Information.IsNothing(cComboItem2))
		{
			cAccount cAccount2 = new cAccount(Conversions.ToInteger(cComboItem2.Value));
			ComboBox combo = cboAccount;
			cCombo.getAccount(ref combo, All: true, 0, 0, 0, 0, 99, 0, 3, cAccount2.CurrencyId, 1);
			cboAccount = combo;
			cboAccount.SelectedIndex = 0;
		}
	}

	private void btnPrint_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show("Cetak Report?", "Konfirmasi", MessageBoxButtons.YesNo) != DialogResult.No)
		{
			ExportReport(Print: true);
		}
	}
}
