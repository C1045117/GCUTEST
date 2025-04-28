using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Excel;
using GCUv2.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

[DesignerGenerated]
public class frmReportCustomerVisit : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnWord")]
	private Button _btnWord;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSearch")]
	private Button _btnSearch;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnReset")]
	private Button _btnReset;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboBranch")]
	private ComboBox _cboBranch;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvList")]
	private DataGridView _dgvList;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("chkVisit")]
	private CheckBox _chkVisit;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("chkNoVisit")]
	private CheckBox _chkNoVisit;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnNotActive")]
	private Button _btnNotActive;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnPrint")]
	private Button _btnPrint;

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

	[field: AccessedThroughProperty("lblTotal")]
	internal virtual Label lblTotal
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox cboBranch
	{
		[CompilerGenerated]
		get
		{
			return _cboBranch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cboBranch_SelectedIndexChanged;
			ComboBox comboBox = _cboBranch;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_cboBranch = value;
			comboBox = _cboBranch;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboYear")]
	internal virtual ComboBox cboYear
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label13")]
	internal virtual Label Label13
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboArea")]
	internal virtual ComboBox cboArea
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual CheckBox chkVisit
	{
		[CompilerGenerated]
		get
		{
			return _chkVisit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = chkVisit_CheckedChanged;
			CheckBox checkBox = _chkVisit;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value2;
			}
			_chkVisit = value;
			checkBox = _chkVisit;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("dtpNoVisit")]
	internal virtual DateTimePicker dtpNoVisit
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dtpVisit")]
	internal virtual DateTimePicker dtpVisit
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual CheckBox chkNoVisit
	{
		[CompilerGenerated]
		get
		{
			return _chkNoVisit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = chkNoVisit_CheckedChanged;
			CheckBox checkBox = _chkNoVisit;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value2;
			}
			_chkNoVisit = value;
			checkBox = _chkNoVisit;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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

	[field: AccessedThroughProperty("ProgressBar1")]
	internal virtual ProgressBar ProgressBar1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkEmpty")]
	internal virtual CheckBox chkEmpty
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnNotActive
	{
		[CompilerGenerated]
		get
		{
			return _btnNotActive;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnNotActive_Click;
			Button button = _btnNotActive;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnNotActive = value;
			button = _btnNotActive;
			if (button != null)
			{
				button.Click += value2;
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
		this.btnWord = new System.Windows.Forms.Button();
		this.lblTotal = new System.Windows.Forms.Label();
		this.btnSearch = new System.Windows.Forms.Button();
		this.btnReset = new System.Windows.Forms.Button();
		this.Label7 = new System.Windows.Forms.Label();
		this.cboBranch = new System.Windows.Forms.ComboBox();
		this.dgvList = new System.Windows.Forms.DataGridView();
		this.Label1 = new System.Windows.Forms.Label();
		this.cboYear = new System.Windows.Forms.ComboBox();
		this.Label13 = new System.Windows.Forms.Label();
		this.cboSalesPerson = new System.Windows.Forms.ComboBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.cboArea = new System.Windows.Forms.ComboBox();
		this.chkVisit = new System.Windows.Forms.CheckBox();
		this.dtpNoVisit = new System.Windows.Forms.DateTimePicker();
		this.dtpVisit = new System.Windows.Forms.DateTimePicker();
		this.chkNoVisit = new System.Windows.Forms.CheckBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
		this.Label5 = new System.Windows.Forms.Label();
		this.chkEmpty = new System.Windows.Forms.CheckBox();
		this.btnNotActive = new System.Windows.Forms.Button();
		this.btnPrint = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		base.SuspendLayout();
		this.btnWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnWord.Location = new System.Drawing.Point(820, 573);
		this.btnWord.Name = "btnWord";
		this.btnWord.Size = new System.Drawing.Size(73, 23);
		this.btnWord.TabIndex = 15;
		this.btnWord.Text = "&Word";
		this.btnWord.UseVisualStyleBackColor = true;
		this.lblTotal.AutoSize = true;
		this.lblTotal.Location = new System.Drawing.Point(10, 578);
		this.lblTotal.Name = "lblTotal";
		this.lblTotal.Size = new System.Drawing.Size(91, 13);
		this.lblTotal.TabIndex = 93;
		this.lblTotal.Text = "Total Pencarian: -";
		this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSearch.Location = new System.Drawing.Point(79, 120);
		this.btnSearch.Name = "btnSearch";
		this.btnSearch.Size = new System.Drawing.Size(47, 24);
		this.btnSearch.TabIndex = 11;
		this.btnSearch.Text = "&Cari";
		this.btnSearch.UseVisualStyleBackColor = true;
		this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnReset.Location = new System.Drawing.Point(132, 120);
		this.btnReset.Name = "btnReset";
		this.btnReset.Size = new System.Drawing.Size(47, 24);
		this.btnReset.TabIndex = 12;
		this.btnReset.Text = "&Reset";
		this.btnReset.UseVisualStyleBackColor = true;
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.Location = new System.Drawing.Point(10, 42);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(44, 13);
		this.Label7.TabIndex = 91;
		this.Label7.Text = "Cabang";
		this.cboBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboBranch.FormattingEnabled = true;
		this.cboBranch.Location = new System.Drawing.Point(79, 39);
		this.cboBranch.Name = "cboBranch";
		this.cboBranch.Size = new System.Drawing.Size(121, 21);
		this.cboBranch.TabIndex = 1;
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.Location = new System.Drawing.Point(13, 152);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(959, 415);
		this.dgvList.TabIndex = 13;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(10, 15);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(38, 13);
		this.Label1.TabIndex = 95;
		this.Label1.Text = "Tahun";
		this.cboYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboYear.FormattingEnabled = true;
		this.cboYear.Location = new System.Drawing.Point(79, 12);
		this.cboYear.Name = "cboYear";
		this.cboYear.Size = new System.Drawing.Size(121, 21);
		this.cboYear.TabIndex = 0;
		this.Label13.AutoSize = true;
		this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label13.Location = new System.Drawing.Point(10, 69);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(33, 13);
		this.Label13.TabIndex = 192;
		this.Label13.Text = "Sales";
		this.cboSalesPerson.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboSalesPerson.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboSalesPerson.FormattingEnabled = true;
		this.cboSalesPerson.Location = new System.Drawing.Point(79, 66);
		this.cboSalesPerson.Name = "cboSalesPerson";
		this.cboSalesPerson.Size = new System.Drawing.Size(121, 21);
		this.cboSalesPerson.TabIndex = 2;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(10, 96);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(45, 13);
		this.Label2.TabIndex = 191;
		this.Label2.Text = "Wilayah";
		this.cboArea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboArea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboArea.FormattingEnabled = true;
		this.cboArea.Location = new System.Drawing.Point(79, 93);
		this.cboArea.Name = "cboArea";
		this.cboArea.Size = new System.Drawing.Size(121, 21);
		this.cboArea.TabIndex = 3;
		this.chkVisit.AutoSize = true;
		this.chkVisit.Location = new System.Drawing.Point(338, 16);
		this.chkVisit.Name = "chkVisit";
		this.chkVisit.Size = new System.Drawing.Size(15, 14);
		this.chkVisit.TabIndex = 4;
		this.chkVisit.UseVisualStyleBackColor = true;
		this.dtpNoVisit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpNoVisit.Location = new System.Drawing.Point(359, 38);
		this.dtpNoVisit.Name = "dtpNoVisit";
		this.dtpNoVisit.Size = new System.Drawing.Size(100, 20);
		this.dtpNoVisit.TabIndex = 7;
		this.dtpVisit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpVisit.Location = new System.Drawing.Point(359, 12);
		this.dtpVisit.Name = "dtpVisit";
		this.dtpVisit.Size = new System.Drawing.Size(100, 20);
		this.dtpVisit.TabIndex = 5;
		this.chkNoVisit.AutoSize = true;
		this.chkNoVisit.Location = new System.Drawing.Point(338, 41);
		this.chkNoVisit.Name = "chkNoVisit";
		this.chkNoVisit.Size = new System.Drawing.Size(15, 14);
		this.chkNoVisit.TabIndex = 6;
		this.chkNoVisit.UseVisualStyleBackColor = true;
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(218, 15);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(85, 13);
		this.Label3.TabIndex = 197;
		this.Label3.Text = "Dikunjungi sejak";
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(218, 41);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(113, 13);
		this.Label4.TabIndex = 198;
		this.Label4.Text = "Tidak dikunjungi sejak";
		this.ProgressBar1.Location = new System.Drawing.Point(132, 573);
		this.ProgressBar1.Name = "ProgressBar1";
		this.ProgressBar1.Size = new System.Drawing.Size(587, 23);
		this.ProgressBar1.TabIndex = 199;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(218, 69);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(43, 13);
		this.Label5.TabIndex = 201;
		this.Label5.Text = "Kosong";
		this.chkEmpty.AutoSize = true;
		this.chkEmpty.Location = new System.Drawing.Point(338, 69);
		this.chkEmpty.Name = "chkEmpty";
		this.chkEmpty.Size = new System.Drawing.Size(62, 17);
		this.chkEmpty.TabIndex = 8;
		this.chkEmpty.Text = "Kosong";
		this.chkEmpty.UseVisualStyleBackColor = true;
		this.btnNotActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnNotActive.Location = new System.Drawing.Point(725, 573);
		this.btnNotActive.Name = "btnNotActive";
		this.btnNotActive.Size = new System.Drawing.Size(89, 23);
		this.btnNotActive.TabIndex = 14;
		this.btnNotActive.Text = "Tidak Aktif";
		this.btnNotActive.UseVisualStyleBackColor = true;
		this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnPrint.Location = new System.Drawing.Point(899, 573);
		this.btnPrint.Name = "btnPrint";
		this.btnPrint.Size = new System.Drawing.Size(73, 23);
		this.btnPrint.TabIndex = 16;
		this.btnPrint.Text = "Cetak";
		this.btnPrint.UseVisualStyleBackColor = true;
		base.AcceptButton = this.btnSearch;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(984, 603);
		base.Controls.Add(this.btnPrint);
		base.Controls.Add(this.btnNotActive);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.chkEmpty);
		base.Controls.Add(this.ProgressBar1);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.chkNoVisit);
		base.Controls.Add(this.dtpNoVisit);
		base.Controls.Add(this.dtpVisit);
		base.Controls.Add(this.chkVisit);
		base.Controls.Add(this.Label13);
		base.Controls.Add(this.cboSalesPerson);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.cboArea);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.cboYear);
		base.Controls.Add(this.btnWord);
		base.Controls.Add(this.lblTotal);
		base.Controls.Add(this.btnSearch);
		base.Controls.Add(this.btnReset);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.cboBranch);
		base.Controls.Add(this.dgvList);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmReportCustomerVisit";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Report Kunjungan";
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmReportCustomerVisit()
	{
		base.Load += frmReportCustomerVisit_Load;
		base.KeyDown += frmReportCustomerVisit_KeyDown;
		InitializeComponent();
		DoubleBuffered = true;
		base.MdiParent = MyProject.Forms.frmMenu;
		FormatGrid();
	}

	private void frmReportCustomerVisit_Load(object sender, EventArgs e)
	{
		prepareForm();
	}

	private void frmReportCustomerVisit_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void prepareForm()
	{
		btnWord.Enabled = false;
		btnPrint.Enabled = false;
		ProgressBar1.Visible = false;
		dtpVisit.Value = DateAndTime.DateAdd(DateInterval.Month, -3.0, DateAndTime.Now);
		dtpNoVisit.Value = DateAndTime.DateAdd(DateInterval.Month, -3.0, DateAndTime.Now);
		ComboBox combo = cboYear;
		cCombo.getYear(ref combo, blnAll: false, checked(DateAndTime.Year(DateAndTime.Now) - 1), 0);
		cboYear = combo;
		combo = cboBranch;
		cCombo.getBranch(ref combo, Module1.pubGroupId, blnAll: false);
		cboBranch = combo;
		cboYear.SelectedIndex = 1;
		combo = cboBranch;
		Module1.comboBoundValue(ref combo, Module1.pubBranchId);
		cboBranch = combo;
		dgvList.DataSource = null;
		lblTotal.Text = "Total Pencarian: -";
		btnNotActive.Enabled = false;
		chkVisit.Checked = false;
		dtpVisit.Enabled = false;
		chkNoVisit.Checked = false;
		dtpNoVisit.Enabled = false;
		chkEmpty.Checked = false;
		cboYear.Focus();
	}

	private void cboBranch_SelectedIndexChanged(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboBranch.SelectedItem;
		if (!Information.IsNothing(cComboItem2))
		{
			ComboBox combo = cboSalesPerson;
			cCombo.getSalesPerson(ref combo, "SALESPERSON", 0, 0, Conversions.ToInteger(cComboItem2.Value), Module1.pubGroupId, All: true, Dash: false, 1);
			cboSalesPerson = combo;
			combo = cboArea;
			cCombo.getArea(ref combo, Conversions.ToInteger(cComboItem2.Value), Module1.pubGroupId, All: true, Active: true);
			cboArea = combo;
			cboArea.Text = "";
			cboSalesPerson.Text = "";
			cboArea.SelectedIndex = 0;
			cboSalesPerson.SelectedIndex = 0;
		}
	}

	private void chkVisit_CheckedChanged(object sender, EventArgs e)
	{
		if (chkVisit.Checked)
		{
			dtpVisit.Enabled = true;
			dtpNoVisit.Enabled = false;
			chkNoVisit.Checked = false;
		}
		else
		{
			dtpVisit.Enabled = false;
		}
	}

	private void chkNoVisit_CheckedChanged(object sender, EventArgs e)
	{
		if (chkNoVisit.Checked)
		{
			dtpNoVisit.Enabled = true;
			dtpVisit.Enabled = false;
			chkVisit.Checked = false;
		}
		else
		{
			dtpNoVisit.Enabled = false;
		}
	}

	private void btnSearch_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		double num4 = default(double);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						cComboItem cComboItem2 = (cComboItem)cboYear.SelectedItem;
						cComboItem cComboItem3 = (cComboItem)cboBranch.SelectedItem;
						cComboItem cComboItem4 = (cComboItem)cboSalesPerson.SelectedItem;
						cComboItem cComboItem5 = (cComboItem)cboArea.SelectedItem;
						if (cboYear.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih tahun.", MsgBoxStyle.Information);
							cboYear.Focus();
							goto end_IL_0001;
						}
						if (cboBranch.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih cabang.", MsgBoxStyle.Information);
							cboBranch.Focus();
							goto end_IL_0001;
						}
						if (cboSalesPerson.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih sales.", MsgBoxStyle.Information);
							cboSalesPerson.Focus();
							goto end_IL_0001;
						}
						if (cboArea.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih wilayah.", MsgBoxStyle.Information);
							cboArea.Focus();
							goto end_IL_0001;
						}
						DataTable dataTable = new DataTable();
						btnSearch.Focus();
						if (chkEmpty.Checked)
						{
							btnWord.Text = "Excel";
							dataTable = cSalesInvoice.SearchCustomerVisit(chkVisit.Checked, dtpVisit.Value, chkNoVisit.Checked, dtpNoVisit.Value, 1, Conversions.ToInteger(cComboItem2.Value), Conversions.ToInteger(cComboItem5.Value), Conversions.ToInteger(cComboItem4.Value), Conversions.ToInteger(cComboItem3.Value));
							FormatGrid();
							dgvList.Columns[1].Width = 300;
							int num3 = 2;
							do
							{
								dgvList.Columns[num3].Visible = false;
								num3++;
							}
							while (num3 <= 15);
							IEnumerator enumerator = dataTable.Rows.GetEnumerator();
							while (enumerator.MoveNext())
							{
								DataRow dataRow = (DataRow)enumerator.Current;
								dgvList.Rows.Add(dataRow["custId"], dataRow["custName"]);
							}
							if (enumerator is IDisposable)
							{
								(enumerator as IDisposable).Dispose();
							}
							if (dataTable.Rows.Count == 0)
							{
								Interaction.MsgBox("Data tidak ditemukan", MsgBoxStyle.Information);
								btnWord.Enabled = false;
								btnPrint.Enabled = false;
								cboYear.Focus();
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
							goto end_IL_0001;
						}
						btnWord.Text = "Word";
						Cursor = Cursors.WaitCursor;
						ProgressBar1.Visible = true;
						ProgressBar1.Value = 4;
						dataTable = cSalesInvoice.SearchCustomerVisit(chkVisit.Checked, dtpVisit.Value, chkNoVisit.Checked, dtpNoVisit.Value, 1, Conversions.ToInteger(cComboItem2.Value), Conversions.ToInteger(cComboItem5.Value), Conversions.ToInteger(cComboItem4.Value), Conversions.ToInteger(cComboItem3.Value));
						ProgressBar1.Value += 8;
						FormatGrid();
						double[] array = new double[12];
						IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							DataRow dataRow2 = (DataRow)enumerator2.Current;
							dgvList.Rows.Add(dataRow2["custId"], dataRow2["custName"], dataRow2["custAddress"], dataRow2["numberOfVisit"]);
							dgvList[15, dataTable.Rows.IndexOf(dataRow2)].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["numberOfVisit"])), RuntimeHelpers.GetObjectValue(dataRow2["numberOfVisit"]), 0));
							num4 = Conversions.ToDouble(Operators.AddObject(num4, Interaction.IIf(!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["numberOfVisit"])), RuntimeHelpers.GetObjectValue(dataRow2["numberOfVisit"]), 0)));
							ref double reference = ref array[0];
							reference = Conversions.ToDouble(Operators.AddObject(reference, Interaction.IIf(!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["numberOfVisit"])), RuntimeHelpers.GetObjectValue(dataRow2["numberOfVisit"]), 0)));
						}
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
						int num5 = 2;
						do
						{
							dataTable = cSalesInvoice.SearchCustomerVisit(chkVisit.Checked, dtpVisit.Value, chkNoVisit.Checked, dtpNoVisit.Value, num5, Conversions.ToInteger(cComboItem2.Value), Conversions.ToInteger(cComboItem5.Value), Conversions.ToInteger(cComboItem4.Value), Conversions.ToInteger(cComboItem3.Value));
							IEnumerator enumerator3 = dataTable.Rows.GetEnumerator();
							while (enumerator3.MoveNext())
							{
								DataRow dataRow3 = (DataRow)enumerator3.Current;
								dgvList[num5 + 2, dataTable.Rows.IndexOf(dataRow3)].Value = RuntimeHelpers.GetObjectValue(dataRow3["numberOfVisit"]);
								DataGridViewCell dataGridViewCell;
								(dataGridViewCell = dgvList[15, dataTable.Rows.IndexOf(dataRow3)]).Value = Operators.AddObject(dataGridViewCell.Value, Interaction.IIf(!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow3["numberOfVisit"])), RuntimeHelpers.GetObjectValue(dataRow3["numberOfVisit"]), 0));
								num4 = Conversions.ToDouble(Operators.AddObject(num4, Interaction.IIf(!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow3["numberOfVisit"])), RuntimeHelpers.GetObjectValue(dataRow3["numberOfVisit"]), 0)));
								ref double reference2 = ref array[num5 - 1];
								reference2 = Conversions.ToDouble(Operators.AddObject(reference2, Interaction.IIf(!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow3["numberOfVisit"])), RuntimeHelpers.GetObjectValue(dataRow3["numberOfVisit"]), 0)));
							}
							if (enumerator3 is IDisposable)
							{
								(enumerator3 as IDisposable).Dispose();
							}
							ProgressBar1.Value += 8;
							num5++;
						}
						while (num5 <= 12);
						dgvList.Focus();
						if (dataTable.Rows.Count == 0)
						{
							Interaction.MsgBox("Data tidak ditemukan", MsgBoxStyle.Information);
							btnWord.Enabled = false;
							btnPrint.Enabled = false;
							cboYear.Focus();
						}
						else
						{
							dgvList.Rows.Add(0, "Total", "", Strings.FormatNumber(array[0], 0, TriState.UseDefault, TriState.UseDefault, TriState.True), Strings.FormatNumber(array[1], 0, TriState.UseDefault, TriState.UseDefault, TriState.True), Strings.FormatNumber(array[2], 0, TriState.UseDefault, TriState.UseDefault, TriState.True), Strings.FormatNumber(array[3], 0, TriState.UseDefault, TriState.UseDefault, TriState.True), Strings.FormatNumber(array[4], 0, TriState.UseDefault, TriState.UseDefault, TriState.True), Strings.FormatNumber(array[5], 0, TriState.UseDefault, TriState.UseDefault, TriState.True), Strings.FormatNumber(array[6], 0, TriState.UseDefault, TriState.UseDefault, TriState.True), Strings.FormatNumber(array[7], 0, TriState.UseDefault, TriState.UseDefault, TriState.True), Strings.FormatNumber(array[8], 0, TriState.UseDefault, TriState.UseDefault, TriState.True), Strings.FormatNumber(array[9], 0, TriState.UseDefault, TriState.UseDefault, TriState.True), Strings.FormatNumber(array[10], 0, TriState.UseDefault, TriState.UseDefault, TriState.True), Strings.FormatNumber(array[11], 0, TriState.UseDefault, TriState.UseDefault, TriState.True), Strings.FormatNumber(num4, 0, TriState.UseDefault, TriState.UseDefault, TriState.True));
							if (Module1.pubPreviewReport)
							{
								btnWord.Enabled = true;
							}
							if (Module1.pubPrintReport)
							{
								btnPrint.Enabled = true;
							}
						}
						ProgressBar1.Visible = false;
						if (!chkNoVisit.Checked)
						{
							btnNotActive.Enabled = false;
						}
						else if (chkNoVisit.Checked & Module1.pubUpdateCustomer)
						{
							btnNotActive.Enabled = true;
						}
						lblTotal.Text = "Total Pencarian: " + Conversions.ToString(dataTable.Rows.Count);
						Cursor = Cursors.Default;
						goto end_IL_0001;
					}
					case 2620:
						num = -1;
						switch (num2)
						{
						case 2:
							ProgressBar1.Visible = false;
							Cursor = Cursors.Default;
							Module1.SaveError(Information.Err(), "frmReportCustomerVisit", "btnSearch_click", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 2620;
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

	private void FormatGrid()
	{
		dgvList.Columns.Clear();
		dgvList.Rows.Clear();
		dgvList.Columns.Add("", "custId");
		dgvList.Columns.Add("", "Customer");
		dgvList.Columns.Add("", "Alamat");
		dgvList.Columns.Add("", "Jan");
		dgvList.Columns.Add("", "Feb");
		dgvList.Columns.Add("", "Mar");
		dgvList.Columns.Add("", "Apr");
		dgvList.Columns.Add("", "Mei");
		dgvList.Columns.Add("", "Jun");
		dgvList.Columns.Add("", "Jul");
		dgvList.Columns.Add("", "Agu");
		dgvList.Columns.Add("", "Sep");
		dgvList.Columns.Add("", "Okt");
		dgvList.Columns.Add("", "Nov");
		dgvList.Columns.Add("", "Des");
		dgvList.Columns.Add("", "Total");
		dgvList.Columns[0].Visible = false;
		dgvList.Columns[1].Width = 200;
		dgvList.Columns[2].Width = 230;
		dgvList.Columns[3].Width = 30;
		dgvList.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[4].Width = 30;
		dgvList.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[5].Width = 30;
		dgvList.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[6].Width = 30;
		dgvList.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[7].Width = 30;
		dgvList.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[8].Width = 30;
		dgvList.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[9].Width = 30;
		dgvList.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[10].Width = 30;
		dgvList.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[11].Width = 30;
		dgvList.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[12].Width = 30;
		dgvList.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[13].Width = 30;
		dgvList.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[14].Width = 30;
		dgvList.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[15].Width = 50;
		dgvList.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.RowHeadersVisible = false;
		dgvList.AllowUserToAddRows = false;
		dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvList.ReadOnly = true;
		dgvList.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvList.AllowUserToResizeRows = false;
		dgvList.DefaultCellStyle.Font = new Font("Segoe UI", 8f);
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
		if ((dgvList.RowCount > 0) & (Conversion.Val(RuntimeHelpers.GetObjectValue(dgvList[0, dgvList.CurrentRow.Index].Value)) > 0.0))
		{
			MyProject.Forms.frmCustomer.Show();
			MyProject.Forms.frmCustomer.prepareForm();
			MyProject.Forms.frmCustomer.CurrentId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
			MyProject.Forms.frmCustomer.LoadData();
			MyProject.Forms.frmCustomer.Activate();
			MyProject.Forms.frmCustomer.WindowState = FormWindowState.Normal;
		}
	}

	private void btnWord_Click(object sender, EventArgs e)
	{
		ExportReport(Print: false);
	}

	private void btnPrint_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show("Cetak Report?", "Konfirmasi", MessageBoxButtons.YesNo) != DialogResult.No)
		{
			ExportReport(Print: true);
		}
	}

	private void ExportReport(bool Print)
	{
		if (chkEmpty.Checked)
		{
			EmptyExcel(Print);
			return;
		}
		dgvList.SelectAll();
		dgvList.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
		Clipboard.SetDataObject(dgvList.GetClipboardContent());
		dgvList.ClearSelection();
		dgvList.Rows[0].Selected = true;
		MsWord msWord = new MsWord();
		msWord.rptWordNew(dgvList.Rows.Count, dgvList.Columns.Count, "LLRRRRRRRRRRRRR", blnPortrait: true, "", Print);
	}

	private void EmptyExcel(bool Print)
	{
		Excel.Application application = (Excel.Application)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
		Workbook workbook = application.Workbooks.Add(RuntimeHelpers.GetObjectValue(Missing.Value));
		if (!Print)
		{
			application.Visible = true;
		}
		object instance = NewLateBinding.LateGet(application.ActiveSheet, null, "PageSetup", new object[0], null, null, null);
		NewLateBinding.LateSetComplex(instance, null, "Orientation", new object[1] { XlPageOrientation.xlLandscape }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(instance, null, "PrintTitleRows", new object[1] { "$3:$3" }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(instance, null, "PrintTitleColumns", new object[1] { "" }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(instance, null, "LeftMargin", new object[1] { application.Application.InchesToPoints(0.3) }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(instance, null, "RightMargin", new object[1] { application.Application.InchesToPoints(0.25) }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(instance, null, "papersize", new object[1] { XlPaperSize.xlPaperLetter }, null, null, OptimisticSet: false, RValueBase: true);
		instance = null;
		application.Cells.Select();
		object instance2 = NewLateBinding.LateGet(application.Selection, null, "Font", new object[0], null, null, null);
		NewLateBinding.LateSetComplex(instance2, null, "Name", new object[1] { "Arial" }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(instance2, null, "Size", new object[1] { 8 }, null, null, OptimisticSet: false, RValueBase: true);
		instance2 = null;
		dgvList.SelectAll();
		dgvList.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
		Clipboard.SetDataObject(dgvList.GetClipboardContent());
		dgvList.ClearSelection();
		dgvList.Rows[0].Selected = true;
		((_Application)application).get_Range((object)"A3", RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
		NewLateBinding.LateCall(application.ActiveSheet, null, "Paste", new object[0], null, null, null, IgnoreReturn: true);
		application.Cells[1, 1] = "Wilayah: " + cboArea.Text;
		application.Cells[2, 1] = "Sales: " + cboSalesPerson.Text;
		NewLateBinding.LateSetComplex(application.Columns["A:A", RuntimeHelpers.GetObjectValue(Missing.Value)], null, "ColumnWidth", new object[1] { 28 }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateCall(application.Columns["A:A", RuntimeHelpers.GetObjectValue(Missing.Value)], null, "Select", new object[0], null, null, null, IgnoreReturn: true);
		object selection = application.Selection;
		NewLateBinding.LateSetComplex(selection, null, "HorizontalAlignment", new object[1] { XlHAlign.xlHAlignGeneral }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(selection, null, "VerticalAlignment", new object[1] { XlVAlign.xlVAlignBottom }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(selection, null, "WrapText", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(selection, null, "Orientation", new object[1] { 0 }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(selection, null, "AddIndent", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(selection, null, "ShrinkToFit", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(selection, null, "MergeCells", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
		selection = null;
		int num = 16;
		object obj = application.Sheets[1];
		object instance3 = obj;
		object[] array = new object[2];
		object instance4;
		object instance5 = (instance4 = obj);
		object[] array2 = new object[2];
		object obj2 = (array2[0] = 1);
		object obj3 = (array2[1] = 2);
		array[0] = NewLateBinding.LateGet(instance5, null, "Cells", array2, null, null, null);
		object instance6;
		object instance7 = (instance6 = obj);
		object[] array3 = new object[2];
		object obj4 = (array3[0] = 1);
		int num2;
		array3[1] = (num2 = num);
		object[] array4 = array3;
		bool[] array5;
		object obj5 = NewLateBinding.LateGet(instance7, null, "Cells", array3, null, null, array5 = new bool[2] { false, true });
		if (array5[1])
		{
			num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
		}
		array[1] = obj5;
		object[] array6 = array;
		bool[] array7;
		object obj6 = NewLateBinding.LateGet(instance3, null, "Range", array, null, null, array7 = new bool[2] { true, true });
		if (array7[0])
		{
			NewLateBinding.LateSetComplex(instance4, null, "Cells", new object[3]
			{
				obj2,
				obj3,
				array6[0]
			}, null, null, OptimisticSet: true, RValueBase: true);
		}
		if (array7[1])
		{
			NewLateBinding.LateSetComplex(instance6, null, "Cells", new object[3]
			{
				obj4,
				num2,
				array6[1]
			}, null, null, OptimisticSet: true, RValueBase: true);
		}
		Range range = (Range)obj6;
		range.Select();
		obj = null;
		NewLateBinding.LateSetComplex(application.Selection, null, "ColumnWidth", new object[1] { 5.5 }, null, null, OptimisticSet: false, RValueBase: true);
		object selection2 = application.Selection;
		NewLateBinding.LateSetComplex(selection2, null, "HorizontalAlignment", new object[1] { XlHAlign.xlHAlignGeneral }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(selection2, null, "VerticalAlignment", new object[1] { XlVAlign.xlVAlignBottom }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(selection2, null, "WrapText", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(selection2, null, "Orientation", new object[1] { 0 }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(selection2, null, "AddIndent", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(selection2, null, "ShrinkToFit", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(selection2, null, "MergeCells", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
		selection2 = null;
		object obj7 = application.Sheets[1];
		object instance8 = obj7;
		object[] array8 = new object[2];
		object instance9 = (obj4 = obj7);
		object[] array9 = new object[2];
		instance6 = (array9[0] = 1);
		obj3 = (array9[1] = 15);
		array8[0] = NewLateBinding.LateGet(instance9, null, "Cells", array9, null, null, null);
		object instance10 = (obj2 = obj7);
		object[] array10 = new object[2];
		instance4 = (array10[0] = 1);
		obj6 = (array10[1] = 16);
		array8[1] = NewLateBinding.LateGet(instance10, null, "Cells", array10, null, null, null);
		array6 = array8;
		obj5 = NewLateBinding.LateGet(instance8, null, "Range", array8, null, null, array7 = new bool[2] { true, true });
		if (array7[0])
		{
			NewLateBinding.LateSetComplex(obj4, null, "Cells", new object[3]
			{
				instance6,
				obj3,
				array6[0]
			}, null, null, OptimisticSet: true, RValueBase: true);
		}
		if (array7[1])
		{
			NewLateBinding.LateSetComplex(obj2, null, "Cells", new object[3]
			{
				instance4,
				obj6,
				array6[1]
			}, null, null, OptimisticSet: true, RValueBase: true);
		}
		range = (Range)obj5;
		range.Select();
		obj7 = null;
		NewLateBinding.LateSetComplex(application.Selection, null, "ColumnWidth", new object[1] { 8.2 }, null, null, OptimisticSet: false, RValueBase: true);
		object obj8 = application.Sheets[1];
		object instance11 = obj8;
		object[] array11 = new object[2];
		object instance12 = (obj6 = obj8);
		object[] array12 = new object[2];
		instance4 = (array12[0] = 3);
		obj2 = (array12[1] = 1);
		array11[0] = NewLateBinding.LateGet(instance12, null, "Cells", array12, null, null, null);
		object instance13 = (obj3 = obj8);
		object[] array13 = new object[2];
		instance6 = (array13[0] = checked(dgvList.Rows.Count + 3));
		array13[1] = (num2 = num);
		array4 = array13;
		obj5 = NewLateBinding.LateGet(instance13, null, "Cells", array13, null, null, array5 = new bool[2] { false, true });
		if (array5[1])
		{
			num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(int));
		}
		array11[1] = obj5;
		array6 = array11;
		obj4 = NewLateBinding.LateGet(instance11, null, "Range", array11, null, null, array7 = new bool[2] { true, true });
		if (array7[0])
		{
			NewLateBinding.LateSetComplex(obj6, null, "Cells", new object[3]
			{
				instance4,
				obj2,
				array6[0]
			}, null, null, OptimisticSet: true, RValueBase: true);
		}
		if (array7[1])
		{
			NewLateBinding.LateSetComplex(obj3, null, "Cells", new object[3]
			{
				instance6,
				num2,
				array6[1]
			}, null, null, OptimisticSet: true, RValueBase: true);
		}
		range = (Range)obj4;
		range.Select();
		obj8 = null;
		object instance14 = NewLateBinding.LateGet(application.Selection, null, "Borders", new object[1] { XlBordersIndex.xlEdgeLeft }, null, null, null);
		NewLateBinding.LateSetComplex(instance14, null, "LineStyle", new object[1] { XlLineStyle.xlContinuous }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(instance14, null, "Weight", new object[1] { XlBorderWeight.xlThin }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(instance14, null, "ColorIndex", new object[1] { XlColorIndex.xlColorIndexAutomatic }, null, null, OptimisticSet: false, RValueBase: true);
		instance14 = null;
		object instance15 = NewLateBinding.LateGet(application.Selection, null, "Borders", new object[1] { XlBordersIndex.xlEdgeTop }, null, null, null);
		NewLateBinding.LateSetComplex(instance15, null, "LineStyle", new object[1] { XlLineStyle.xlContinuous }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(instance15, null, "Weight", new object[1] { XlBorderWeight.xlThin }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(instance15, null, "ColorIndex", new object[1] { XlColorIndex.xlColorIndexAutomatic }, null, null, OptimisticSet: false, RValueBase: true);
		instance15 = null;
		object instance16 = NewLateBinding.LateGet(application.Selection, null, "Borders", new object[1] { XlBordersIndex.xlEdgeBottom }, null, null, null);
		NewLateBinding.LateSetComplex(instance16, null, "LineStyle", new object[1] { XlLineStyle.xlContinuous }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(instance16, null, "Weight", new object[1] { XlBorderWeight.xlThin }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(instance16, null, "ColorIndex", new object[1] { XlColorIndex.xlColorIndexAutomatic }, null, null, OptimisticSet: false, RValueBase: true);
		instance16 = null;
		object instance17 = NewLateBinding.LateGet(application.Selection, null, "Borders", new object[1] { XlBordersIndex.xlEdgeRight }, null, null, null);
		NewLateBinding.LateSetComplex(instance17, null, "LineStyle", new object[1] { XlLineStyle.xlContinuous }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(instance17, null, "Weight", new object[1] { XlBorderWeight.xlThin }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(instance17, null, "ColorIndex", new object[1] { XlColorIndex.xlColorIndexAutomatic }, null, null, OptimisticSet: false, RValueBase: true);
		instance17 = null;
		object instance18 = NewLateBinding.LateGet(application.Selection, null, "Borders", new object[1] { XlBordersIndex.xlInsideVertical }, null, null, null);
		NewLateBinding.LateSetComplex(instance18, null, "LineStyle", new object[1] { XlLineStyle.xlContinuous }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(instance18, null, "Weight", new object[1] { XlBorderWeight.xlThin }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(instance18, null, "ColorIndex", new object[1] { XlColorIndex.xlColorIndexAutomatic }, null, null, OptimisticSet: false, RValueBase: true);
		instance18 = null;
		object instance19 = NewLateBinding.LateGet(application.Selection, null, "Borders", new object[1] { XlBordersIndex.xlInsideHorizontal }, null, null, null);
		NewLateBinding.LateSetComplex(instance19, null, "LineStyle", new object[1] { XlLineStyle.xlContinuous }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(instance19, null, "Weight", new object[1] { XlBorderWeight.xlThin }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(instance19, null, "ColorIndex", new object[1] { XlColorIndex.xlColorIndexAutomatic }, null, null, OptimisticSet: false, RValueBase: true);
		instance19 = null;
		((_Application)application).get_Range((object)"A1", RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
		if (Print)
		{
			workbook.PrintOut(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
			workbook.Close(false, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
			application.Quit();
		}
	}

	private void btnReset_Click(object sender, EventArgs e)
	{
		prepareForm();
	}

	private void btnNotActive_Click(object sender, EventArgs e)
	{
		checked
		{
			if (MessageBox.Show("Rubah status customer menjadi Tidak Aktif?", "Konfirmasi", MessageBoxButtons.YesNo) != DialogResult.No)
			{
				cHistory cHistory2 = new cHistory();
				Cursor = Cursors.WaitCursor;
				int num = dgvList.RowCount - 2;
				double num2 = default(double);
				for (int i = 0; i <= num; i++)
				{
					num2 = Conversions.ToDouble(dgvList[0, i].Value);
					cCustomer.NonActivate(num2);
					cHistory2.Content = "Status dirubah menjadi Tidak Aktif melalui Report Kunjungan.";
					cHistory2.Description = "";
					cHistory2.UserId = Module1.pubUserId;
					cHistory2.UserLogin = Module1.pubLogin;
					cHistory2.fKeyId = num2;
					cHistory2.HistoryType = 8;
					cHistory2.Save();
				}
				cHistory2.Content = "";
				cHistory2.Description = " merubah status customer melalui Report Kunjungan.";
				cHistory2.UserId = Module1.pubUserId;
				cHistory2.UserLogin = Module1.pubLogin;
				cHistory2.fKeyId = num2;
				cHistory2.HistoryType = 23;
				cHistory2.Save();
				Cursor = Cursors.Default;
				Interaction.MsgBox("Status customer berhasil dirubah menjadi Tidak Aktif.", MsgBoxStyle.Information);
			}
		}
	}
}
