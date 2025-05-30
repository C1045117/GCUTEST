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
public class frmReportCashTransaction : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboCashAccount")]
	private ComboBox _cboCashAccount;

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
	[AccessedThroughProperty("cboIncomeExpense")]
	private ComboBox _cboIncomeExpense;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnPrint")]
	private Button _btnPrint;

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboSalesPerson")]
	internal virtual ComboBox cboSalesPerson
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

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

	internal virtual ComboBox cboCashAccount
	{
		[CompilerGenerated]
		get
		{
			return _cboCashAccount;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cboCashAccount_SelectedIndexChanged;
			ComboBox comboBox = _cboCashAccount;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_cboCashAccount = value;
			comboBox = _cboCashAccount;
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

	internal virtual ComboBox cboIncomeExpense
	{
		[CompilerGenerated]
		get
		{
			return _cboIncomeExpense;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cboIncomeExpense_SelectedIndexChanged;
			ComboBox comboBox = _cboIncomeExpense;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_cboIncomeExpense = value;
			comboBox = _cboIncomeExpense;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
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
		this.Label6 = new System.Windows.Forms.Label();
		this.cboSalesPerson = new System.Windows.Forms.ComboBox();
		this.txtDescription = new System.Windows.Forms.TextBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.cboCashAccount = new System.Windows.Forms.ComboBox();
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
		this.cboIncomeExpense = new System.Windows.Forms.ComboBox();
		this.btnPrint = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		base.SuspendLayout();
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.Location = new System.Drawing.Point(9, 174);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(77, 13);
		this.Label6.TabIndex = 172;
		this.Label6.Text = "Sales/Kolektor";
		this.cboSalesPerson.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboSalesPerson.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboSalesPerson.FormattingEnabled = true;
		this.cboSalesPerson.Location = new System.Drawing.Point(90, 171);
		this.cboSalesPerson.Name = "cboSalesPerson";
		this.cboSalesPerson.Size = new System.Drawing.Size(142, 21);
		this.cboSalesPerson.TabIndex = 6;
		this.txtDescription.Location = new System.Drawing.Point(90, 145);
		this.txtDescription.Name = "txtDescription";
		this.txtDescription.Size = new System.Drawing.Size(141, 20);
		this.txtDescription.TabIndex = 5;
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(8, 148);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(62, 13);
		this.Label4.TabIndex = 171;
		this.Label4.Text = "Keterangan";
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(11, 67);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(25, 13);
		this.Label3.TabIndex = 170;
		this.Label3.Text = "Kas";
		this.cboCashAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboCashAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboCashAccount.FormattingEnabled = true;
		this.cboCashAccount.Location = new System.Drawing.Point(90, 64);
		this.cboCashAccount.Name = "cboCashAccount";
		this.cboCashAccount.Size = new System.Drawing.Size(142, 21);
		this.cboCashAccount.TabIndex = 2;
		this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnReset.Location = new System.Drawing.Point(144, 198);
		this.btnReset.Name = "btnReset";
		this.btnReset.Size = new System.Drawing.Size(47, 24);
		this.btnReset.TabIndex = 12;
		this.btnReset.Text = "&Reset";
		this.btnReset.UseVisualStyleBackColor = true;
		this.btnWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnWord.Location = new System.Drawing.Point(790, 437);
		this.btnWord.Name = "btnWord";
		this.btnWord.Size = new System.Drawing.Size(73, 23);
		this.btnWord.TabIndex = 22;
		this.btnWord.Text = "&Word";
		this.btnWord.UseVisualStyleBackColor = true;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(10, 15);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(71, 13);
		this.Label1.TabIndex = 169;
		this.Label1.Text = "Tanggal awal";
		this.lblTotal.AutoSize = true;
		this.lblTotal.Location = new System.Drawing.Point(238, 437);
		this.lblTotal.Name = "lblTotal";
		this.lblTotal.Size = new System.Drawing.Size(91, 13);
		this.lblTotal.TabIndex = 168;
		this.lblTotal.Text = "Total Pencarian: -";
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.Location = new System.Drawing.Point(10, 121);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(32, 13);
		this.Label7.TabIndex = 167;
		this.Label7.Text = "Akun";
		this.cboAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboAccount.FormattingEnabled = true;
		this.cboAccount.Location = new System.Drawing.Point(91, 118);
		this.cboAccount.Name = "cboAccount";
		this.cboAccount.Size = new System.Drawing.Size(142, 21);
		this.cboAccount.TabIndex = 4;
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.Location = new System.Drawing.Point(241, 12);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(701, 419);
		this.dgvList.TabIndex = 21;
		this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSearch.Location = new System.Drawing.Point(91, 198);
		this.btnSearch.Name = "btnSearch";
		this.btnSearch.Size = new System.Drawing.Size(47, 24);
		this.btnSearch.TabIndex = 11;
		this.btnSearch.Text = "&Cari";
		this.btnSearch.UseVisualStyleBackColor = true;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(10, 41);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(72, 13);
		this.Label2.TabIndex = 166;
		this.Label2.Text = "Tanggal akhir";
		this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpEnd.Location = new System.Drawing.Point(90, 38);
		this.dtpEnd.Name = "dtpEnd";
		this.dtpEnd.Size = new System.Drawing.Size(142, 20);
		this.dtpEnd.TabIndex = 1;
		this.dtpBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpBegin.Location = new System.Drawing.Point(90, 12);
		this.dtpBegin.Name = "dtpBegin";
		this.dtpBegin.Size = new System.Drawing.Size(142, 20);
		this.dtpBegin.TabIndex = 0;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(11, 94);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(28, 13);
		this.Label5.TabIndex = 174;
		this.Label5.Text = "Tipe";
		this.cboIncomeExpense.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboIncomeExpense.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboIncomeExpense.FormattingEnabled = true;
		this.cboIncomeExpense.Location = new System.Drawing.Point(90, 91);
		this.cboIncomeExpense.Name = "cboIncomeExpense";
		this.cboIncomeExpense.Size = new System.Drawing.Size(142, 21);
		this.cboIncomeExpense.TabIndex = 3;
		this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnPrint.Location = new System.Drawing.Point(869, 437);
		this.btnPrint.Name = "btnPrint";
		this.btnPrint.Size = new System.Drawing.Size(73, 23);
		this.btnPrint.TabIndex = 23;
		this.btnPrint.Text = "Cetak";
		this.btnPrint.UseVisualStyleBackColor = true;
		base.AcceptButton = this.btnSearch;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(954, 468);
		base.Controls.Add(this.btnPrint);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.cboIncomeExpense);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.cboSalesPerson);
		base.Controls.Add(this.txtDescription);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.cboCashAccount);
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
		base.Name = "frmReportCashTransaction";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Report Transaksi Kas";
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmReportCashTransaction()
	{
		base.KeyDown += frmReportCashTransaction_KeyDown;
		base.Load += frmReportCashTransaction_Load;
		InitializeComponent();
		DoubleBuffered = true;
		base.MdiParent = MyProject.Forms.frmMenu;
		ComboBox combo = cboCashAccount;
		cCombo.getCashAccount(ref combo, 0, Module1.pubGroupId, All: true, GroupDefault: false, Active: true, "TRANSACTION", 0);
		cboCashAccount = combo;
		combo = cboSalesPerson;
		cCombo.getSalesPerson(ref combo, "ALL", 0, 0, 0, Module1.pubGroupId, All: false, Dash: true, 1);
		cboSalesPerson = combo;
		combo = cboIncomeExpense;
		cCombo.getIncomeExpense(ref combo, All: true);
		cboIncomeExpense = combo;
	}

	private void frmReportCashTransaction_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void frmReportCashTransaction_Load(object sender, EventArgs e)
	{
		prepareForm();
	}

	private void prepareForm()
	{
		btnWord.Enabled = false;
		btnPrint.Enabled = false;
		dtpBegin.Value = Module1.getFirstDateInMonth(DateAndTime.Now);
		dtpEnd.Value = DateAndTime.Now;
		cboCashAccount.SelectedIndex = 0;
		cboSalesPerson.SelectedIndex = 0;
		cboIncomeExpense.SelectedIndex = 0;
		cboAccount.SelectedIndex = 0;
		txtDescription.Text = "";
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

	private void cboCashAccount_SelectedIndexChanged(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboCashAccount.SelectedItem;
		cComboItem cComboItem3 = (cComboItem)cboIncomeExpense.SelectedItem;
		if (!Information.IsNothing(cComboItem2))
		{
			cAccount cAccount2 = new cAccount(Conversions.ToInteger(cComboItem2.Value));
			ComboBox combo = cboSalesPerson;
			cCombo.getSalesPerson(ref combo, "ALL", 0, 0, cAccount2.BranchId, Module1.pubGroupId, All: false, Dash: true, 1);
			cboSalesPerson = combo;
			cboSalesPerson.SelectedIndex = 0;
			if (!Information.IsNothing(cComboItem3))
			{
				combo = cboAccount;
				cCombo.getAccount(ref combo, All: true, 0, 0, 0, Conversions.ToInteger(cComboItem2.Value), 99, Conversions.ToInteger(cComboItem3.Value), 0, cAccount2.CurrencyId, 1);
				cboAccount = combo;
				cboAccount.SelectedIndex = 0;
			}
		}
	}

	private void cboIncomeExpense_SelectedIndexChanged(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboCashAccount.SelectedItem;
		cComboItem cComboItem3 = (cComboItem)cboIncomeExpense.SelectedItem;
		if (!Information.IsNothing(cComboItem2) & !Information.IsNothing(cComboItem3))
		{
			cAccount cAccount2 = new cAccount(Conversions.ToInteger(cComboItem2.Value));
			ComboBox combo = cboAccount;
			cCombo.getAccount(ref combo, All: true, 0, 0, 0, Conversions.ToInteger(cComboItem2.Value), 99, Conversions.ToInteger(cComboItem3.Value), 0, cAccount2.CurrencyId, 1);
			cboAccount = combo;
			cboAccount.SelectedIndex = 0;
		}
	}

	private void btnSearch_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		double num3 = default(double);
		double num4 = default(double);
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
					cComboItem cComboItem2 = (cComboItem)cboCashAccount.SelectedItem;
					cComboItem cComboItem3 = (cComboItem)cboIncomeExpense.SelectedItem;
					cComboItem cComboItem4 = (cComboItem)cboAccount.SelectedItem;
					cComboItem cComboItem5 = (cComboItem)cboSalesPerson.SelectedItem;
					if (DateTime.Compare(dtpBegin.Value, Module1.pubBalanceDate) < 0)
					{
						Interaction.MsgBox("Data sebelum " + Conversions.ToString(Module1.pubBalanceDate) + " tidak tersedia.");
						dtpBegin.Focus();
						goto end_IL_0001;
					}
					if (cboCashAccount.SelectedIndex == -1)
					{
						Interaction.MsgBox("Kas yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
						cboCashAccount.Focus();
						goto end_IL_0001;
					}
					if (cboAccount.SelectedIndex == -1)
					{
						Interaction.MsgBox("Akun yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
						cboAccount.Focus();
						goto end_IL_0001;
					}
					if (cboSalesPerson.SelectedIndex == -1)
					{
						Interaction.MsgBox("Sales/Kolektor yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
						cboSalesPerson.Focus();
						goto end_IL_0001;
					}
					Cursor = Cursors.WaitCursor;
					DataTable dataTable = new DataTable();
					btnSearch.Focus();
					dataTable = cVoucher.SearchCashBank(1, dtpBegin.Value, dtpEnd.Value, 2, Conversions.ToInteger(cComboItem2.Value), Conversions.ToInteger(cComboItem4.Value), Conversions.ToInteger(cComboItem3.Value), Conversions.ToInteger(cComboItem5.Value), Module1.cleanString(txtDescription.Text), Module1.pubGroupId);
					formatGrid();
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						dgvList.Rows.Add(dataRow["voucherId"], dataRow["voucherDate"], dataRow["accountName"], Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow["counterAccountNumber"], " - "), dataRow["counterAccountName"]), dataRow["voucherDescription"], dataRow["salesName"], Operators.ConditionalCompareObjectEqual(dataRow["voucherDebitCredit"], 1, TextCompare: false) ? Module1.formatCustomDecimal(Conversions.ToString(dataRow["voucherAmount"]), 2) : "", Operators.ConditionalCompareObjectEqual(dataRow["voucherDebitCredit"], 2, TextCompare: false) ? Module1.formatCustomDecimal(Conversions.ToString(dataRow["voucherAmount"]), 2) : "");
						if (Operators.ConditionalCompareObjectEqual(dataRow["voucherDebitCredit"], 1, TextCompare: false))
						{
							num3 = Conversions.ToDouble(Operators.AddObject(num3, dataRow["voucherAmount"]));
						}
						else
						{
							num4 = Conversions.ToDouble(Operators.AddObject(num4, dataRow["voucherAmount"]));
						}
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
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
						dgvList.Rows.Add(0, "", "Total", "", "", "", Module1.formatCustomDecimal(Conversions.ToString(num3), 2), Module1.formatCustomDecimal(Conversions.ToString(num4), 2));
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
				case 1219:
					num = -1;
					switch (num2)
					{
					case 2:
						Cursor = Cursors.Default;
						Module1.SaveError(Information.Err(), "frmReportCashTransaction", "btnSearch_click", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1219;
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

	private void formatGrid()
	{
		dgvList.Columns.Clear();
		dgvList.Rows.Clear();
		dgvList.Columns.Add("", "voucherId");
		dgvList.Columns.Add("", "Tanggal");
		dgvList.Columns.Add("", "Kas");
		dgvList.Columns.Add("", "Akun");
		dgvList.Columns.Add("", "Keterangan");
		dgvList.Columns.Add("", "Sales/Kolektor");
		dgvList.Columns.Add("", "Pendapatan");
		dgvList.Columns.Add("", "Pengeluaran");
		dgvList.Columns[0].Visible = false;
		dgvList.Columns[0].Width = 0;
		dgvList.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvList.Columns[1].Width = 65;
		dgvList.Columns[2].Width = 110;
		dgvList.Columns[3].Width = 140;
		dgvList.Columns[4].Width = 100;
		dgvList.Columns[5].Width = 90;
		dgvList.Columns[6].Width = 85;
		dgvList.Columns[7].Width = 85;
		dgvList.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.RowHeadersVisible = false;
		dgvList.AllowUserToAddRows = false;
		dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvList.ReadOnly = true;
		dgvList.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvList.AllowUserToResizeRows = false;
		dgvList.DefaultCellStyle.Font = new Font("Arial", 8f, FontStyle.Regular);
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
		if (dgvList.RowCount > 0 && Operators.ConditionalCompareObjectGreater(dgvList[0, dgvList.CurrentRow.Index].Value, 0, TextCompare: false))
		{
			MyProject.Forms.frmCashTransaction.Show();
			MyProject.Forms.frmCashTransaction.prepareForm(SaveNew: false);
			MyProject.Forms.frmCashTransaction.CurrentId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
			MyProject.Forms.frmCashTransaction.LoadData();
			MyProject.Forms.frmCashTransaction.Activate();
			MyProject.Forms.frmCashTransaction.WindowState = FormWindowState.Normal;
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
		msWord.rptWordNew(dgvList.Rows.Count, dgvList.Columns.Count, "LLLLLRR", blnPortrait: true, "", Print);
	}

	private void btnReset_Click(object sender, EventArgs e)
	{
		prepareForm();
	}

	private void btnPrint_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show("Cetak Report?", "Konfirmasi", MessageBoxButtons.YesNo) != DialogResult.No)
		{
			ExportReport(Print: true);
		}
	}
}
