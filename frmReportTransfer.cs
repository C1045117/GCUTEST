using System;
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
public class frmReportTransfer : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dtpBegin")]
	private DateTimePicker _dtpBegin;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dtpEnd")]
	private DateTimePicker _dtpEnd;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvList")]
	private DataGridView _dgvList;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboBranch")]
	private ComboBox _cboBranch;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnWord")]
	private Button _btnWord;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnReset")]
	private Button _btnReset;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSearch")]
	private Button _btnSearch;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboItemCategory")]
	private ComboBox _cboItemCategory;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnPrint")]
	private Button _btnPrint;

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

	[field: AccessedThroughProperty("cboStorageTo")]
	internal virtual ComboBox cboStorageTo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboStorageFrom")]
	internal virtual ComboBox cboStorageFrom
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("optDate")]
	internal virtual RadioButton optDate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("optMonth")]
	internal virtual RadioButton optMonth
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboMM")]
	internal virtual ComboBox cboMM
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboYY")]
	internal virtual ComboBox cboYY
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
		this.dtpBegin = new System.Windows.Forms.DateTimePicker();
		this.Label2 = new System.Windows.Forms.Label();
		this.dtpEnd = new System.Windows.Forms.DateTimePicker();
		this.dgvList = new System.Windows.Forms.DataGridView();
		this.Label7 = new System.Windows.Forms.Label();
		this.cboBranch = new System.Windows.Forms.ComboBox();
		this.Label6 = new System.Windows.Forms.Label();
		this.cboItem = new System.Windows.Forms.ComboBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.cboStorageTo = new System.Windows.Forms.ComboBox();
		this.cboStorageFrom = new System.Windows.Forms.ComboBox();
		this.optDate = new System.Windows.Forms.RadioButton();
		this.optMonth = new System.Windows.Forms.RadioButton();
		this.cboMM = new System.Windows.Forms.ComboBox();
		this.cboYY = new System.Windows.Forms.ComboBox();
		this.lblTotal = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.btnWord = new System.Windows.Forms.Button();
		this.btnReset = new System.Windows.Forms.Button();
		this.btnSearch = new System.Windows.Forms.Button();
		this.Label5 = new System.Windows.Forms.Label();
		this.cboItemCategory = new System.Windows.Forms.ComboBox();
		this.btnPrint = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		base.SuspendLayout();
		this.dtpBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpBegin.Location = new System.Drawing.Point(100, 14);
		this.dtpBegin.Name = "dtpBegin";
		this.dtpBegin.Size = new System.Drawing.Size(121, 20);
		this.dtpBegin.TabIndex = 4;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(10, 43);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(72, 13);
		this.Label2.TabIndex = 13;
		this.Label2.Text = "Tanggal akhir";
		this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpEnd.Location = new System.Drawing.Point(100, 40);
		this.dtpEnd.Name = "dtpEnd";
		this.dtpEnd.Size = new System.Drawing.Size(121, 20);
		this.dtpEnd.TabIndex = 5;
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.Location = new System.Drawing.Point(236, 14);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(665, 362);
		this.dgvList.TabIndex = 12;
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.Location = new System.Drawing.Point(14, 306);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(44, 13);
		this.Label7.TabIndex = 25;
		this.Label7.Text = "Cabang";
		this.Label7.Visible = false;
		this.cboBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboBranch.FormattingEnabled = true;
		this.cboBranch.Location = new System.Drawing.Point(90, 303);
		this.cboBranch.Name = "cboBranch";
		this.cboBranch.Size = new System.Drawing.Size(121, 21);
		this.cboBranch.TabIndex = 6;
		this.cboBranch.Visible = false;
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.Location = new System.Drawing.Point(10, 149);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(41, 13);
		this.Label6.TabIndex = 24;
		this.Label6.Text = "Produk";
		this.cboItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboItem.FormattingEnabled = true;
		this.cboItem.Location = new System.Drawing.Point(99, 147);
		this.cboItem.Name = "cboItem";
		this.cboItem.Size = new System.Drawing.Size(121, 21);
		this.cboItem.TabIndex = 9;
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(10, 96);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(40, 13);
		this.Label4.TabIndex = 23;
		this.Label4.Text = "Tujuan";
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(10, 70);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(27, 13);
		this.Label3.TabIndex = 22;
		this.Label3.Text = "Asal";
		this.cboStorageTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboStorageTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboStorageTo.FormattingEnabled = true;
		this.cboStorageTo.Location = new System.Drawing.Point(100, 94);
		this.cboStorageTo.Name = "cboStorageTo";
		this.cboStorageTo.Size = new System.Drawing.Size(120, 21);
		this.cboStorageTo.TabIndex = 8;
		this.cboStorageFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboStorageFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboStorageFrom.FormattingEnabled = true;
		this.cboStorageFrom.Location = new System.Drawing.Point(100, 67);
		this.cboStorageFrom.Name = "cboStorageFrom";
		this.cboStorageFrom.Size = new System.Drawing.Size(120, 21);
		this.cboStorageFrom.TabIndex = 7;
		this.optDate.AutoSize = true;
		this.optDate.Location = new System.Drawing.Point(27, 280);
		this.optDate.Name = "optDate";
		this.optDate.Size = new System.Drawing.Size(90, 17);
		this.optDate.TabIndex = 0;
		this.optDate.TabStop = true;
		this.optDate.Text = "Tanggal Awal";
		this.optDate.UseVisualStyleBackColor = true;
		this.optDate.Visible = false;
		this.optMonth.AutoSize = true;
		this.optMonth.Location = new System.Drawing.Point(29, 257);
		this.optMonth.Name = "optMonth";
		this.optMonth.Size = new System.Drawing.Size(88, 17);
		this.optMonth.TabIndex = 0;
		this.optMonth.TabStop = true;
		this.optMonth.Text = "Bulan/Tahun";
		this.optMonth.UseVisualStyleBackColor = true;
		this.optMonth.Visible = false;
		this.cboMM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboMM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboMM.FormattingEnabled = true;
		this.cboMM.Location = new System.Drawing.Point(30, 230);
		this.cboMM.Name = "cboMM";
		this.cboMM.Size = new System.Drawing.Size(56, 21);
		this.cboMM.TabIndex = 1;
		this.cboMM.Visible = false;
		this.cboYY.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboYY.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboYY.FormattingEnabled = true;
		this.cboYY.Location = new System.Drawing.Point(91, 230);
		this.cboYY.Name = "cboYY";
		this.cboYY.Size = new System.Drawing.Size(58, 21);
		this.cboYY.TabIndex = 2;
		this.cboYY.Visible = false;
		this.lblTotal.AutoSize = true;
		this.lblTotal.Location = new System.Drawing.Point(232, 383);
		this.lblTotal.Name = "lblTotal";
		this.lblTotal.Size = new System.Drawing.Size(91, 13);
		this.lblTotal.TabIndex = 29;
		this.lblTotal.Text = "Total Pencarian: -";
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(10, 17);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(71, 13);
		this.Label1.TabIndex = 31;
		this.Label1.Text = "Tanggal awal";
		this.btnWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnWord.Location = new System.Drawing.Point(749, 382);
		this.btnWord.Name = "btnWord";
		this.btnWord.Size = new System.Drawing.Size(73, 23);
		this.btnWord.TabIndex = 13;
		this.btnWord.Text = "&Word";
		this.btnWord.UseVisualStyleBackColor = true;
		this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnReset.Location = new System.Drawing.Point(153, 174);
		this.btnReset.Name = "btnReset";
		this.btnReset.Size = new System.Drawing.Size(47, 24);
		this.btnReset.TabIndex = 11;
		this.btnReset.Text = "&Reset";
		this.btnReset.UseVisualStyleBackColor = true;
		this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSearch.Location = new System.Drawing.Point(100, 174);
		this.btnSearch.Name = "btnSearch";
		this.btnSearch.Size = new System.Drawing.Size(47, 24);
		this.btnSearch.TabIndex = 10;
		this.btnSearch.Text = "&Cari";
		this.btnSearch.UseVisualStyleBackColor = true;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(7, 124);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(86, 13);
		this.Label5.TabIndex = 33;
		this.Label5.Text = " Kategori Produk";
		this.cboItemCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboItemCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboItemCategory.FormattingEnabled = true;
		this.cboItemCategory.Location = new System.Drawing.Point(100, 121);
		this.cboItemCategory.Name = "cboItemCategory";
		this.cboItemCategory.Size = new System.Drawing.Size(121, 21);
		this.cboItemCategory.TabIndex = 9;
		this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnPrint.Location = new System.Drawing.Point(828, 383);
		this.btnPrint.Name = "btnPrint";
		this.btnPrint.Size = new System.Drawing.Size(73, 23);
		this.btnPrint.TabIndex = 14;
		this.btnPrint.Text = "Cetak";
		this.btnPrint.UseVisualStyleBackColor = true;
		base.AcceptButton = this.btnSearch;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(913, 412);
		base.Controls.Add(this.btnPrint);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.cboItemCategory);
		base.Controls.Add(this.btnSearch);
		base.Controls.Add(this.btnReset);
		base.Controls.Add(this.btnWord);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.lblTotal);
		base.Controls.Add(this.cboYY);
		base.Controls.Add(this.cboMM);
		base.Controls.Add(this.optMonth);
		base.Controls.Add(this.optDate);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.cboBranch);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.cboItem);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.cboStorageTo);
		base.Controls.Add(this.cboStorageFrom);
		base.Controls.Add(this.dgvList);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.dtpEnd);
		base.Controls.Add(this.dtpBegin);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmReportTransfer";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Report Transfer";
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmReportTransfer()
	{
		base.KeyDown += frmReportTransfer_KeyDown;
		InitializeComponent();
		DoubleBuffered = true;
		base.MdiParent = MyProject.Forms.frmMenu;
		prepareForm();
	}

	private void prepareForm()
	{
		btnWord.Enabled = false;
		btnPrint.Enabled = false;
		dtpBegin.Value = Module1.getFirstDateInMonth(DateAndTime.Now);
		dtpEnd.Value = DateAndTime.Now;
		ComboBox combo = cboBranch;
		bool branch = cCombo.getBranch(ref combo, Module1.pubGroupId, blnAll: true);
		cboBranch = combo;
		if (!branch)
		{
			cboBranch.Enabled = false;
		}
		combo = cboItemCategory;
		cCombo.getItemCategory(ref combo, Module1.pubGroupId, All: true, Active: true);
		cboItemCategory = combo;
		combo = cboItem;
		cCombo.getItemAll(ref combo, 99, 99, 0, 0, 0, 0, 99, 1, 0, 0, 0, 0, 0.0, CanBeUsedAsGroupMember: false, Module1.pubGroupId, All: false, Active: true);
		cboItem = combo;
		combo = cboBranch;
		Module1.comboBoundValue(ref combo, 0.0);
		cboBranch = combo;
		cboStorageFrom.SelectedIndex = 0;
		cboStorageTo.SelectedIndex = 0;
		cboItemCategory.SelectedIndex = 0;
		cboItem.SelectedIndex = 0;
		lblTotal.Text = "Total Pencarian: -";
		dtpBegin.Focus();
	}

	private void FormatGrid()
	{
		dgvList.Columns.Clear();
		dgvList.Rows.Clear();
		dgvList.Columns.Add("", "invId");
		dgvList.Columns.Add("", "Tanggal");
		dgvList.Columns.Add("", "Nomer");
		dgvList.Columns.Add("", "Asal");
		dgvList.Columns.Add("", "Tujuan");
		dgvList.Columns.Add("", "Produk");
		dgvList.Columns.Add("", "Jumlah");
		dgvList.Columns[0].Visible = false;
		dgvList.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvList.Columns[0].Width = 0;
		dgvList.Columns[1].Width = 70;
		dgvList.Columns[2].Width = 100;
		dgvList.Columns[3].Width = 135;
		dgvList.Columns[4].Width = 135;
		dgvList.Columns[5].Width = 120;
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

	private void frmReportTransfer_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
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

	private void btnSearch_Click(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboMM.SelectedItem;
		cComboItem cComboItem3 = (cComboItem)cboYY.SelectedItem;
		cComboItem cComboItem4 = (cComboItem)cboStorageFrom.SelectedItem;
		cComboItem cComboItem5 = (cComboItem)cboStorageTo.SelectedItem;
		cComboItem cComboItem6 = (cComboItem)cboItemCategory.SelectedItem;
		cComboItem cComboItem7 = (cComboItem)cboItem.SelectedItem;
		cComboItem cComboItem8 = (cComboItem)cboBranch.SelectedItem;
		if (cboBranch.SelectedIndex == -1)
		{
			Interaction.MsgBox("Cabang yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
			cboBranch.Focus();
			return;
		}
		if (cboStorageFrom.SelectedIndex == -1)
		{
			Interaction.MsgBox("Gudang asal yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
			cboStorageFrom.Focus();
			return;
		}
		if (cboStorageTo.SelectedIndex == -1)
		{
			Interaction.MsgBox("Gudang tujuan yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
			cboStorageTo.Focus();
			return;
		}
		if (cboItemCategory.SelectedIndex == -1)
		{
			Interaction.MsgBox("Kategori produk yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
			cboItemCategory.Focus();
			return;
		}
		if (cboItem.SelectedIndex == -1)
		{
			Interaction.MsgBox("Produk yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
			cboItem.Focus();
			return;
		}
		Cursor = Cursors.WaitCursor;
		DataTable dataTable = new DataTable();
		btnSearch.Focus();
		dataTable = cTransfer.Search(1, 0, 0, dtpBegin.Value, dtpEnd.Value, Conversions.ToInteger(cComboItem7.Value), Conversions.ToInteger(cComboItem6.Value), Conversions.ToInteger(cComboItem4.Value), Conversions.ToInteger(cComboItem5.Value), Module1.pubGroupId, Conversions.ToInteger(cComboItem8.Value), 0);
		FormatGrid();
		int num = default(int);
		foreach (DataRow row in dataTable.Rows)
		{
			if (Operators.ConditionalCompareObjectEqual(row["orderBy"], 0, TextCompare: false))
			{
				dgvList.Rows.Add(row["transferId"], row["transferDate"], row["transferNumber"], row["storageFromName"], row["storageToName"], row["itemName"], Module1.formatCustomDecimal(Conversions.ToString(row["transferQty"]), 3));
				num = checked(num + 1);
			}
			else
			{
				dgvList.Rows.Add(0, "", "Total", row["storageFromName"], row["storageToName"], row["itemName"], Module1.formatCustomDecimal(Conversions.ToString(row["transferQty"]), 3));
			}
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
		lblTotal.Text = "Total Pencarian: " + Conversions.ToString(num);
		Cursor = Cursors.Default;
	}

	private void dgvList_DoubleClick(object sender, EventArgs e)
	{
		getData();
	}

	public void getData()
	{
		if (dgvList.RowCount > 0 && Operators.ConditionalCompareObjectGreater(dgvList[0, dgvList.CurrentRow.Index].Value, 0, TextCompare: false))
		{
			MyProject.Forms.frmTransfer.Show();
			MyProject.Forms.frmTransfer.prepareForm(SaveNew: false);
			MyProject.Forms.frmTransfer.CurrentId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
			MyProject.Forms.frmTransfer.loadData();
			MyProject.Forms.frmTransfer.Activate();
			MyProject.Forms.frmTransfer.WindowState = FormWindowState.Normal;
		}
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

	private void cboBranch_SelectedIndexChanged(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboBranch.SelectedItem;
		string value = cComboItem2.Value;
		cboStorageFrom.Text = "";
		cboStorageTo.Text = "";
		ComboBox combo = cboStorageFrom;
		cCombo.getStorage(ref combo, Module1.pubGroupId, Conversions.ToInteger(value), "ALL", blnAll: true, 1);
		cboStorageFrom = combo;
		combo = cboStorageTo;
		cCombo.getStorage(ref combo, Module1.pubGroupId, Conversions.ToInteger(value), "ALL", blnAll: true, 1);
		cboStorageTo = combo;
		cboStorageFrom.SelectedIndex = 0;
		cboStorageTo.SelectedIndex = 0;
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
		msWord.rptWordNew(dgvList.Rows.Count, dgvList.Columns.Count, "LLLLR", blnPortrait: true, "", Print);
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
