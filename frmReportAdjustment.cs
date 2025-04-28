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
public class frmReportAdjustment : Form
{
	private IContainer components;

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
	[AccessedThroughProperty("cboBranch")]
	private ComboBox _cboBranch;

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
	[AccessedThroughProperty("cboItemCategory")]
	private ComboBox _cboItemCategory;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnPrint")]
	private Button _btnPrint;

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

	internal virtual ComboBox cboItemCategory
	{
		[CompilerGenerated]
		get
		{
			return _cboItemCategory;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cboItemCategory_SelectedIndexChanged;
			ComboBox comboBox = _cboItemCategory;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_cboItemCategory = value;
			comboBox = _cboItemCategory;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboItem")]
	internal virtual ComboBox cboItem
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

	[field: AccessedThroughProperty("cboStorage")]
	internal virtual ComboBox cboStorage
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

	[field: AccessedThroughProperty("cboCategory")]
	internal virtual ComboBox cboCategory
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboType")]
	internal virtual ComboBox cboType
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
		this.btnReset = new System.Windows.Forms.Button();
		this.btnWord = new System.Windows.Forms.Button();
		this.Label1 = new System.Windows.Forms.Label();
		this.lblTotal = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.cboBranch = new System.Windows.Forms.ComboBox();
		this.dgvList = new System.Windows.Forms.DataGridView();
		this.btnSearch = new System.Windows.Forms.Button();
		this.Label2 = new System.Windows.Forms.Label();
		this.dtpEnd = new System.Windows.Forms.DateTimePicker();
		this.dtpBegin = new System.Windows.Forms.DateTimePicker();
		this.Label5 = new System.Windows.Forms.Label();
		this.cboItemCategory = new System.Windows.Forms.ComboBox();
		this.Label6 = new System.Windows.Forms.Label();
		this.cboItem = new System.Windows.Forms.ComboBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.cboStorage = new System.Windows.Forms.ComboBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.cboCategory = new System.Windows.Forms.ComboBox();
		this.Label8 = new System.Windows.Forms.Label();
		this.cboType = new System.Windows.Forms.ComboBox();
		this.btnPrint = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		base.SuspendLayout();
		this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnReset.Location = new System.Drawing.Point(156, 226);
		this.btnReset.Name = "btnReset";
		this.btnReset.Size = new System.Drawing.Size(47, 24);
		this.btnReset.TabIndex = 9;
		this.btnReset.Text = "&Reset";
		this.btnReset.UseVisualStyleBackColor = true;
		this.btnWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnWord.Location = new System.Drawing.Point(629, 380);
		this.btnWord.Name = "btnWord";
		this.btnWord.Size = new System.Drawing.Size(73, 23);
		this.btnWord.TabIndex = 11;
		this.btnWord.Text = "&Word";
		this.btnWord.UseVisualStyleBackColor = true;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(10, 15);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(71, 13);
		this.Label1.TabIndex = 81;
		this.Label1.Text = "Tanggal awal";
		this.lblTotal.AutoSize = true;
		this.lblTotal.Location = new System.Drawing.Point(236, 380);
		this.lblTotal.Name = "lblTotal";
		this.lblTotal.Size = new System.Drawing.Size(91, 13);
		this.lblTotal.TabIndex = 80;
		this.lblTotal.Text = "Total Pencarian: -";
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.Location = new System.Drawing.Point(10, 67);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(44, 13);
		this.Label7.TabIndex = 79;
		this.Label7.Text = "Cabang";
		this.cboBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboBranch.FormattingEnabled = true;
		this.cboBranch.Location = new System.Drawing.Point(102, 64);
		this.cboBranch.Name = "cboBranch";
		this.cboBranch.Size = new System.Drawing.Size(120, 21);
		this.cboBranch.TabIndex = 2;
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.Location = new System.Drawing.Point(239, 12);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(541, 362);
		this.dgvList.TabIndex = 10;
		this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSearch.Location = new System.Drawing.Point(103, 226);
		this.btnSearch.Name = "btnSearch";
		this.btnSearch.Size = new System.Drawing.Size(47, 24);
		this.btnSearch.TabIndex = 8;
		this.btnSearch.Text = "&Cari";
		this.btnSearch.UseVisualStyleBackColor = true;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(10, 41);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(72, 13);
		this.Label2.TabIndex = 78;
		this.Label2.Text = "Tanggal akhir";
		this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpEnd.Location = new System.Drawing.Point(101, 38);
		this.dtpEnd.Name = "dtpEnd";
		this.dtpEnd.Size = new System.Drawing.Size(121, 20);
		this.dtpEnd.TabIndex = 1;
		this.dtpBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpBegin.Location = new System.Drawing.Point(101, 12);
		this.dtpBegin.Name = "dtpBegin";
		this.dtpBegin.Size = new System.Drawing.Size(121, 20);
		this.dtpBegin.TabIndex = 0;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(5, 122);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(86, 13);
		this.Label5.TabIndex = 85;
		this.Label5.Text = " Kategori Produk";
		this.cboItemCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboItemCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboItemCategory.FormattingEnabled = true;
		this.cboItemCategory.Location = new System.Drawing.Point(102, 118);
		this.cboItemCategory.Name = "cboItemCategory";
		this.cboItemCategory.Size = new System.Drawing.Size(120, 21);
		this.cboItemCategory.TabIndex = 4;
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.Location = new System.Drawing.Point(8, 148);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(41, 13);
		this.Label6.TabIndex = 84;
		this.Label6.Text = "Produk";
		this.cboItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboItem.FormattingEnabled = true;
		this.cboItem.Location = new System.Drawing.Point(102, 145);
		this.cboItem.Name = "cboItem";
		this.cboItem.Size = new System.Drawing.Size(120, 21);
		this.cboItem.TabIndex = 5;
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(10, 94);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(45, 13);
		this.Label3.TabIndex = 87;
		this.Label3.Text = "Gudang";
		this.cboStorage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboStorage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboStorage.FormattingEnabled = true;
		this.cboStorage.Location = new System.Drawing.Point(102, 91);
		this.cboStorage.Name = "cboStorage";
		this.cboStorage.Size = new System.Drawing.Size(120, 21);
		this.cboStorage.TabIndex = 3;
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(5, 176);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(31, 13);
		this.Label4.TabIndex = 89;
		this.Label4.Text = " Tipe";
		this.cboCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboCategory.FormattingEnabled = true;
		this.cboCategory.Location = new System.Drawing.Point(102, 172);
		this.cboCategory.Name = "cboCategory";
		this.cboCategory.Size = new System.Drawing.Size(120, 21);
		this.cboCategory.TabIndex = 6;
		this.Label8.AutoSize = true;
		this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label8.Location = new System.Drawing.Point(6, 203);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(85, 13);
		this.Label8.TabIndex = 91;
		this.Label8.Text = "Tambah/Kurang";
		this.cboType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboType.FormattingEnabled = true;
		this.cboType.Location = new System.Drawing.Point(102, 199);
		this.cboType.Name = "cboType";
		this.cboType.Size = new System.Drawing.Size(120, 21);
		this.cboType.TabIndex = 7;
		this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnPrint.Location = new System.Drawing.Point(708, 380);
		this.btnPrint.Name = "btnPrint";
		this.btnPrint.Size = new System.Drawing.Size(73, 23);
		this.btnPrint.TabIndex = 12;
		this.btnPrint.Text = "Cetak";
		this.btnPrint.UseVisualStyleBackColor = true;
		base.AcceptButton = this.btnSearch;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(793, 414);
		base.Controls.Add(this.btnPrint);
		base.Controls.Add(this.Label8);
		base.Controls.Add(this.cboType);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.cboCategory);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.cboStorage);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.cboItemCategory);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.cboItem);
		base.Controls.Add(this.btnReset);
		base.Controls.Add(this.btnWord);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.lblTotal);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.cboBranch);
		base.Controls.Add(this.dgvList);
		base.Controls.Add(this.btnSearch);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.dtpEnd);
		base.Controls.Add(this.dtpBegin);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmReportAdjustment";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Report Penyesuaian";
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmReportAdjustment()
	{
		base.KeyDown += frmReportAdjustment_KeyDown;
		base.Load += frmReportAdjustment_Load;
		InitializeComponent();
		base.MdiParent = MyProject.Forms.frmMenu;
	}

	private void frmReportAdjustment_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void frmReportAdjustment_Load(object sender, EventArgs e)
	{
		DoubleBuffered = true;
		prepareForm();
	}

	private void prepareForm()
	{
		btnWord.Enabled = false;
		btnPrint.Enabled = false;
		dtpBegin.Value = Module1.getFirstDateInMonth(DateAndTime.Now);
		dtpEnd.Value = DateAndTime.Now;
		ComboBox combo = cboItemCategory;
		cCombo.getItemCategory(ref combo, Module1.pubGroupId, All: true, Active: true);
		cboItemCategory = combo;
		combo = cboItem;
		cCombo.getItemAll(ref combo, 99, 99, 0, 0, 0, 0, 2, 1, 0, 0, 0, 0, 0.0, CanBeUsedAsGroupMember: false, Module1.pubGroupId, All: true, Active: true);
		cboItem = combo;
		combo = cboCategory;
		cCombo.getAdjustmentCategory(ref combo, All: true, Active: true);
		cboCategory = combo;
		combo = cboType;
		cCombo.getAdjustmentType(ref combo, All: true);
		cboType = combo;
		combo = cboBranch;
		bool branch = cCombo.getBranch(ref combo, Module1.pubGroupId, blnAll: true);
		cboBranch = combo;
		if (!branch)
		{
			cboBranch.Enabled = false;
		}
		cboBranch.SelectedIndex = 0;
		cboItemCategory.SelectedIndex = 0;
		cboItem.SelectedIndex = 0;
		cboStorage.SelectedIndex = 0;
		cboCategory.SelectedIndex = 0;
		cboType.SelectedIndex = 0;
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

	private void cboItemCategory_SelectedIndexChanged(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboItemCategory.SelectedItem;
		ComboBox combo = cboItem;
		cCombo.getItemAll(ref combo, 99, 99, 0, 0, 0, 0, 99, 1, Conversions.ToInteger(cComboItem2.Value), 0, 0, 0, 0.0, CanBeUsedAsGroupMember: false, Module1.pubGroupId, All: true, Active: true);
		cboItem = combo;
		cboItem.SelectedIndex = 0;
	}

	private void cboBranch_SelectedIndexChanged(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboBranch.SelectedItem;
		ComboBox combo = cboStorage;
		cCombo.getStorage(ref combo, Module1.pubGroupId, Conversions.ToInteger(cComboItem2.Value), "ALL", blnAll: true, 1);
		cboStorage = combo;
		cboStorage.SelectedIndex = 0;
	}

	private void btnSearch_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num3 = default(int);
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
					cComboItem cComboItem2 = (cComboItem)cboBranch.SelectedItem;
					cComboItem cComboItem3 = (cComboItem)cboStorage.SelectedItem;
					cComboItem cComboItem4 = (cComboItem)cboItemCategory.SelectedItem;
					cComboItem cComboItem5 = (cComboItem)cboItem.SelectedItem;
					cComboItem cComboItem6 = (cComboItem)cboCategory.SelectedItem;
					cComboItem cComboItem7 = (cComboItem)cboType.SelectedItem;
					if (cboBranch.SelectedIndex == -1)
					{
						Interaction.MsgBox("Cabang yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
						cboBranch.Focus();
						goto end_IL_0001;
					}
					if (cboStorage.SelectedIndex == -1)
					{
						Interaction.MsgBox("Gudang yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
						cboStorage.Focus();
						goto end_IL_0001;
					}
					if (cboItemCategory.SelectedIndex == -1)
					{
						Interaction.MsgBox("Kategori produk yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
						cboItemCategory.Focus();
						goto end_IL_0001;
					}
					if (cboItem.SelectedIndex == -1)
					{
						Interaction.MsgBox("Produk yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
						cboItem.Focus();
						goto end_IL_0001;
					}
					if (cboCategory.SelectedIndex == -1)
					{
						Interaction.MsgBox("Tipe yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
						cboCategory.Focus();
						goto end_IL_0001;
					}
					if (cboType.SelectedIndex == -1)
					{
						Interaction.MsgBox("+/- yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
						cboType.Focus();
						goto end_IL_0001;
					}
					DataTable dataTable = new DataTable();
					btnSearch.Focus();
					dataTable = cAdjustment.Search(1, dtpBegin.Value, dtpEnd.Value, Conversions.ToInteger(cComboItem6.Value), Conversions.ToInteger(cComboItem7.Value), Conversions.ToInteger(cComboItem4.Value), Conversions.ToInteger(cComboItem5.Value), Conversions.ToInteger(cComboItem3.Value), Module1.pubGroupId, Conversions.ToInteger(cComboItem2.Value));
					FormatGrid();
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						if (Operators.ConditionalCompareObjectEqual(dataRow["orderBy"], 0, TextCompare: false))
						{
							dgvList.Rows.Add(dataRow["adjId"], dataRow["adjDate"], dataRow["storeName"], dataRow["itemName"], dataRow["adjCategory"], dataRow["adjType"], Module1.formatCustomDecimal(Conversions.ToString(dataRow["adjMainQty"]), 3));
							num3 = checked(num3 + 1);
						}
						else
						{
							dgvList.Rows.Add(0, "Total", dataRow["storeName"], dataRow["itemName"], dataRow["adjCategory"], dataRow["adjType"], Module1.formatCustomDecimal(Conversions.ToString(dataRow["adjMainQty"]), 3));
						}
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
						dtpBegin.Focus();
					}
					else
					{
						dgvList.Focus();
						if (Module1.pubPreviewReport)
						{
							btnWord.Enabled = true;
						}
						if (Module1.pubPrintReport)
						{
							btnPrint.Enabled = true;
						}
					}
					lblTotal.Text = "Total Pencarian: " + Conversions.ToString(num3);
					goto end_IL_0001;
				}
				case 1139:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmReportAdjustment", "btnSearch_click", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1139;
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
		dgvList.Columns.Add("", "adjId");
		dgvList.Columns.Add("", "Tanggal");
		dgvList.Columns.Add("", "Gudang");
		dgvList.Columns.Add("", "Produk");
		dgvList.Columns.Add("", "Tipe");
		dgvList.Columns.Add("", "+/-");
		dgvList.Columns.Add("", "Jumlah");
		dgvList.Columns[0].Visible = false;
		dgvList.Columns[1].Width = 70;
		dgvList.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvList.Columns[2].Width = 120;
		dgvList.Columns[3].Width = 120;
		dgvList.Columns[4].Width = 80;
		dgvList.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		dgvList.Columns[5].Width = 30;
		dgvList.Columns[6].Width = 80;
		dgvList.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.RowHeadersVisible = false;
		dgvList.AllowUserToAddRows = false;
		dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvList.ReadOnly = true;
		dgvList.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvList.AllowUserToResizeRows = false;
		DataGridView grid = dgvList;
		Module1.DisableGridSorting(ref grid);
		dgvList = grid;
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
		if (dgvList.RowCount > 0 && Conversion.Val(RuntimeHelpers.GetObjectValue(dgvList[0, dgvList.CurrentRow.Index].Value)) > 0.0)
		{
			MyProject.Forms.frmAdjustment.Show();
			MyProject.Forms.frmAdjustment.prepareForm(SaveNew: false);
			MyProject.Forms.frmAdjustment.CurrentId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
			MyProject.Forms.frmAdjustment.LoadData();
			MyProject.Forms.frmAdjustment.Activate();
			MyProject.Forms.frmAdjustment.WindowState = FormWindowState.Normal;
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
		MsWord msWord = new MsWord();
		msWord.rptWordNew(dgvList.Rows.Count, dgvList.Columns.Count, "LLLLLR", blnPortrait: true, "", Print);
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
