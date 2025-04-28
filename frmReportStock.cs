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
public class frmReportStock : Form
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
	[AccessedThroughProperty("cboStorageType")]
	private ComboBox _cboStorageType;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnPrint")]
	private Button _btnPrint;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSearchNew")]
	private Button _btnSearchNew;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSearchOld")]
	private Button _btnSearchOld;

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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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

	[field: AccessedThroughProperty("cboStorage")]
	internal virtual ComboBox cboStorage
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

	internal virtual ComboBox cboStorageType
	{
		[CompilerGenerated]
		get
		{
			return _cboStorageType;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cboStorageType_SelectedIndexChanged;
			ComboBox comboBox = _cboStorageType;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_cboStorageType = value;
			comboBox = _cboStorageType;
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

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnSearchNew
	{
		[CompilerGenerated]
		get
		{
			return _btnSearchNew;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnSearchNew_Click;
			Button button = _btnSearchNew;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnSearchNew = value;
			button = _btnSearchNew;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button btnSearchOld
	{
		[CompilerGenerated]
		get
		{
			return _btnSearchOld;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnSearchOld_Click;
			Button button = _btnSearchOld;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnSearchOld = value;
			button = _btnSearchOld;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
		this.Label7 = new System.Windows.Forms.Label();
		this.cboBranch = new System.Windows.Forms.ComboBox();
		this.dgvList = new System.Windows.Forms.DataGridView();
		this.btnSearch = new System.Windows.Forms.Button();
		this.Label2 = new System.Windows.Forms.Label();
		this.dtpEnd = new System.Windows.Forms.DateTimePicker();
		this.dtpBegin = new System.Windows.Forms.DateTimePicker();
		this.Label3 = new System.Windows.Forms.Label();
		this.cboItem = new System.Windows.Forms.ComboBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.cboStorage = new System.Windows.Forms.ComboBox();
		this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
		this.Label5 = new System.Windows.Forms.Label();
		this.cboItemCategory = new System.Windows.Forms.ComboBox();
		this.Label6 = new System.Windows.Forms.Label();
		this.cboStorageType = new System.Windows.Forms.ComboBox();
		this.btnPrint = new System.Windows.Forms.Button();
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.Label9 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.btnSearchNew = new System.Windows.Forms.Button();
		this.btnSearchOld = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		this.GroupBox1.SuspendLayout();
		base.SuspendLayout();
		this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnReset.Location = new System.Drawing.Point(149, 200);
		this.btnReset.Name = "btnReset";
		this.btnReset.Size = new System.Drawing.Size(47, 24);
		this.btnReset.TabIndex = 7;
		this.btnReset.Text = "&Reset";
		this.btnReset.UseVisualStyleBackColor = true;
		this.btnWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnWord.Location = new System.Drawing.Point(670, 380);
		this.btnWord.Name = "btnWord";
		this.btnWord.Size = new System.Drawing.Size(73, 23);
		this.btnWord.TabIndex = 9;
		this.btnWord.Text = "&Word";
		this.btnWord.UseVisualStyleBackColor = true;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(10, 15);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(71, 13);
		this.Label1.TabIndex = 81;
		this.Label1.Text = "Tanggal awal";
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.Location = new System.Drawing.Point(11, 95);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(44, 13);
		this.Label7.TabIndex = 79;
		this.Label7.Text = "Cabang";
		this.cboBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboBranch.FormattingEnabled = true;
		this.cboBranch.Location = new System.Drawing.Point(97, 92);
		this.cboBranch.Name = "cboBranch";
		this.cboBranch.Size = new System.Drawing.Size(150, 21);
		this.cboBranch.TabIndex = 3;
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.Location = new System.Drawing.Point(263, 12);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(558, 362);
		this.dgvList.TabIndex = 8;
		this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSearch.Location = new System.Drawing.Point(96, 200);
		this.btnSearch.Name = "btnSearch";
		this.btnSearch.Size = new System.Drawing.Size(47, 24);
		this.btnSearch.TabIndex = 6;
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
		this.dtpEnd.Location = new System.Drawing.Point(97, 38);
		this.dtpEnd.Name = "dtpEnd";
		this.dtpEnd.Size = new System.Drawing.Size(150, 20);
		this.dtpEnd.TabIndex = 1;
		this.dtpBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpBegin.Location = new System.Drawing.Point(97, 12);
		this.dtpBegin.Name = "dtpBegin";
		this.dtpBegin.Size = new System.Drawing.Size(150, 20);
		this.dtpBegin.TabIndex = 0;
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(11, 176);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(41, 13);
		this.Label3.TabIndex = 83;
		this.Label3.Text = "Barang";
		this.cboItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboItem.FormattingEnabled = true;
		this.cboItem.Location = new System.Drawing.Point(97, 173);
		this.cboItem.Name = "cboItem";
		this.cboItem.Size = new System.Drawing.Size(150, 21);
		this.cboItem.TabIndex = 6;
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(11, 122);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(45, 13);
		this.Label4.TabIndex = 85;
		this.Label4.Text = "Gudang";
		this.cboStorage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboStorage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboStorage.FormattingEnabled = true;
		this.cboStorage.Location = new System.Drawing.Point(97, 119);
		this.cboStorage.Name = "cboStorage";
		this.cboStorage.Size = new System.Drawing.Size(150, 21);
		this.cboStorage.TabIndex = 4;
		this.ProgressBar1.Location = new System.Drawing.Point(263, 380);
		this.ProgressBar1.Name = "ProgressBar1";
		this.ProgressBar1.Size = new System.Drawing.Size(401, 23);
		this.ProgressBar1.TabIndex = 86;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(8, 149);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(86, 13);
		this.Label5.TabIndex = 88;
		this.Label5.Text = " Kategori Barang";
		this.cboItemCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboItemCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboItemCategory.FormattingEnabled = true;
		this.cboItemCategory.Location = new System.Drawing.Point(97, 146);
		this.cboItemCategory.Name = "cboItemCategory";
		this.cboItemCategory.Size = new System.Drawing.Size(150, 21);
		this.cboItemCategory.TabIndex = 5;
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.Location = new System.Drawing.Point(10, 67);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(68, 13);
		this.Label6.TabIndex = 90;
		this.Label6.Text = "Jenis Barang";
		this.cboStorageType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboStorageType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboStorageType.FormattingEnabled = true;
		this.cboStorageType.Location = new System.Drawing.Point(96, 64);
		this.cboStorageType.Name = "cboStorageType";
		this.cboStorageType.Size = new System.Drawing.Size(151, 21);
		this.cboStorageType.TabIndex = 2;
		this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnPrint.Location = new System.Drawing.Point(749, 380);
		this.btnPrint.Name = "btnPrint";
		this.btnPrint.Size = new System.Drawing.Size(73, 23);
		this.btnPrint.TabIndex = 10;
		this.btnPrint.Text = "Cetak";
		this.btnPrint.UseVisualStyleBackColor = true;
		this.GroupBox1.Controls.Add(this.Label9);
		this.GroupBox1.Controls.Add(this.Label8);
		this.GroupBox1.Controls.Add(this.btnSearchNew);
		this.GroupBox1.Controls.Add(this.btnSearchOld);
		this.GroupBox1.Location = new System.Drawing.Point(48, 230);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(199, 161);
		this.GroupBox1.TabIndex = 91;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Tombol Sementara";
		this.Label9.ForeColor = System.Drawing.Color.Red;
		this.Label9.Location = new System.Drawing.Point(15, 115);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(152, 43);
		this.Label9.TabIndex = 10;
		this.Label9.Text = "Cara baru masih dalam tahap Testing. Hasil belum tentu akurat.";
		this.Label8.Location = new System.Drawing.Point(6, 22);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(154, 14);
		this.Label8.TabIndex = 9;
		this.Label8.Text = "Tombol cari untuk Grup Master";
		this.btnSearchNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSearchNew.Location = new System.Drawing.Point(51, 84);
		this.btnSearchNew.Name = "btnSearchNew";
		this.btnSearchNew.Size = new System.Drawing.Size(117, 24);
		this.btnSearchNew.TabIndex = 8;
		this.btnSearchNew.Text = "Cari ( Kode Baru )";
		this.btnSearchNew.UseVisualStyleBackColor = true;
		this.btnSearchOld.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSearchOld.Location = new System.Drawing.Point(51, 47);
		this.btnSearchOld.Name = "btnSearchOld";
		this.btnSearchOld.Size = new System.Drawing.Size(117, 24);
		this.btnSearchOld.TabIndex = 7;
		this.btnSearchOld.Text = "Cari ( Kode Lama )";
		this.btnSearchOld.UseVisualStyleBackColor = true;
		base.AcceptButton = this.btnSearch;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(836, 412);
		base.Controls.Add(this.GroupBox1);
		base.Controls.Add(this.btnPrint);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.cboStorageType);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.cboItemCategory);
		base.Controls.Add(this.ProgressBar1);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.cboStorage);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.cboItem);
		base.Controls.Add(this.btnReset);
		base.Controls.Add(this.btnWord);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.cboBranch);
		base.Controls.Add(this.dgvList);
		base.Controls.Add(this.btnSearch);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.dtpEnd);
		base.Controls.Add(this.dtpBegin);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmReportStock";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Report Stok";
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		this.GroupBox1.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmReportStock()
	{
		base.KeyDown += frmReportPurchaseInvoice_KeyDown;
		base.Load += frmReportPurchaseInvoice_Load;
		InitializeComponent();
		base.MdiParent = MyProject.Forms.frmMenu;
	}

	private void frmReportPurchaseInvoice_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void frmReportPurchaseInvoice_Load(object sender, EventArgs e)
	{
		DoubleBuffered = true;
		prepareForm();
	}

	private void prepareForm()
	{
		btnWord.Enabled = false;
		btnPrint.Enabled = false;
		ProgressBar1.Visible = false;
		dtpBegin.Value = Module1.getFirstDateInMonth(DateAndTime.Now);
		dtpEnd.Value = DateAndTime.Now;
		ComboBox combo = cboItemCategory;
		cCombo.getItemCategory(ref combo, Module1.pubGroupId, All: true, Active: true);
		cboItemCategory = combo;
		combo = cboItem;
		cCombo.getItemAll(ref combo, 99, 99, 0, 0, 0, 0, 99, 1, 0, 0, 0, 0, 0.0, CanBeUsedAsGroupMember: false, Module1.pubGroupId, All: true, Active: true);
		cboItem = combo;
		combo = cboStorage;
		cCombo.getStorage(ref combo, Module1.pubGroupId, 0, "ALL", blnAll: true, 1);
		cboStorage = combo;
		combo = cboStorageType;
		cCombo.getStorageType(ref combo, All: false);
		cboStorageType = combo;
		combo = cboBranch;
		bool branch = cCombo.getBranch(ref combo, Module1.pubGroupId, blnAll: false);
		cboBranch = combo;
		if (!branch)
		{
			cboBranch.Enabled = false;
		}
		if (Module1.pubGroupId == 4)
		{
			GroupBox1.Visible = true;
		}
		else
		{
			GroupBox1.Visible = false;
		}
		cboStorageType.SelectedIndex = 0;
		combo = cboBranch;
		Module1.comboBoundValue(ref combo, Module1.pubBranchId);
		cboBranch = combo;
		cboItem.SelectedIndex = 0;
		cboStorage.SelectedIndex = 0;
		cboItemCategory.SelectedIndex = 0;
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

	private void cboStorageType_SelectedIndexChanged(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboBranch.SelectedItem;
		cComboItem cComboItem3 = (cComboItem)cboStorageType.SelectedItem;
		if (Information.IsNothing(cComboItem2))
		{
			return;
		}
		if (Conversions.ToDouble(cComboItem3.Value) == -1.0)
		{
			Interaction.MsgBox("Pilih jenis barang", MsgBoxStyle.Information);
			cboStorageType.Focus();
			return;
		}
		if (Conversions.ToDouble(cComboItem3.Value) == 1.0)
		{
			ComboBox combo = cboStorage;
			cCombo.getStorage(ref combo, Module1.pubGroupId, Conversions.ToInteger(cComboItem2.Value), "NO_RETURN", blnAll: true, 1);
			cboStorage = combo;
		}
		else if (Conversions.ToDouble(cComboItem3.Value) == 2.0)
		{
			ComboBox combo = cboStorage;
			cCombo.getStorage(ref combo, Module1.pubGroupId, Conversions.ToInteger(cComboItem2.Value), "RETURN", blnAll: true, 1);
			cboStorage = combo;
		}
		cboStorage.SelectedIndex = 0;
	}

	private void cboBranch_SelectedIndexChanged(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboBranch.SelectedItem;
		cComboItem cComboItem3 = (cComboItem)cboStorageType.SelectedItem;
		if (Conversions.ToDouble(cComboItem3.Value) == -1.0)
		{
			Interaction.MsgBox("Pilih jenis barang", MsgBoxStyle.Information);
			cboStorageType.Focus();
			return;
		}
		if (Conversions.ToDouble(cComboItem3.Value) == 1.0)
		{
			ComboBox combo = cboStorage;
			cCombo.getStorage(ref combo, Module1.pubGroupId, Conversions.ToInteger(cComboItem2.Value), "NO_RETURN", blnAll: true, 1);
			cboStorage = combo;
		}
		else
		{
			ComboBox combo = cboStorage;
			cCombo.getStorage(ref combo, Module1.pubGroupId, Conversions.ToInteger(cComboItem2.Value), "RETURN", blnAll: true, 1);
			cboStorage = combo;
		}
		cboStorage.SelectedIndex = 0;
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
		int try0001_dispatch = -1;
		int num2 = default(int);
		double num7 = default(double);
		double num8 = default(double);
		double num9 = default(double);
		double num11 = default(double);
		double num13 = default(double);
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
						if (!Module1.pubDatabaseIsConnected)
						{
							Interaction.MsgBox("Database tidak terkoneksi. Silahkan coba tekan tombol 'Restart koneksi'", MsgBoxStyle.Information);
							goto end_IL_0001;
						}
						cComboItem cComboItem2 = (cComboItem)cboItem.SelectedItem;
						cComboItem cComboItem3 = (cComboItem)cboStorage.SelectedItem;
						cComboItem cComboItem4 = (cComboItem)cboStorageType.SelectedItem;
						cComboItem cComboItem5 = (cComboItem)cboBranch.SelectedItem;
						cComboItem cComboItem6 = (cComboItem)cboItemCategory.SelectedItem;
						if (DateTime.Compare(dtpBegin.Value, Module1.pubBalanceDate) < 0)
						{
							Interaction.MsgBox("Data sebelum " + Conversions.ToString(Module1.pubBalanceDate) + " tidak tersedia.");
							dtpBegin.Focus();
							goto end_IL_0001;
						}
						if (cboStorageType.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih jenis barang", MsgBoxStyle.Information);
							cboStorageType.Focus();
							goto end_IL_0001;
						}
						if (cboBranch.SelectedIndex == -1)
						{
							Interaction.MsgBox("Cabang yang anda pilih tidak terdaftar", MsgBoxStyle.Information);
							cboBranch.Focus();
							goto end_IL_0001;
						}
						if (cboStorage.SelectedIndex == -1)
						{
							Interaction.MsgBox("Gudang yang anda pilih tidak terdaftar", MsgBoxStyle.Information);
							cboStorage.Focus();
							goto end_IL_0001;
						}
						if (cboItemCategory.SelectedIndex == -1)
						{
							Interaction.MsgBox("Kategori barang yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
							cboItemCategory.Focus();
							goto end_IL_0001;
						}
						if (cboItem.SelectedIndex == -1)
						{
							Interaction.MsgBox("Barang yang anda pilih tidak terdaftar", MsgBoxStyle.Information);
							cboItem.Focus();
							goto end_IL_0001;
						}
						DataTable dataTable = new DataTable();
						string storageType = ((Conversions.ToDouble(cComboItem4.Value) != 1.0) ? "Damage" : "Good");
						Module1.SaveDebug(Module1.pubLogin + " before IF");
						if (cboItem.SelectedIndex == 0)
						{
							Cursor = Cursors.WaitCursor;
							formatGridAll(Storage: false);
							ProgressBar1.Visible = true;
							ProgressBar1.Value = 5;
							Module1.SaveDebug(Module1.pubLogin + " before cItem.Search");
							dataTable = cItem.Search(99, 99, 0, 0, 0, 0, 99, 1, Conversions.ToInteger(cComboItem6.Value), 0, Conversions.ToInteger(cComboItem3.Value), 0, 0.0, CanBeUsedAsGroupMember: false, Module1.pubGroupId, Conversions.ToInteger(cComboItem5.Value), -1);
							Module1.SaveDebug(Module1.pubLogin + " after cItem.Search");
							if (dataTable.Rows.Count > 0)
							{
								ProgressBar1.Value = 10;
								int num3 = 10;
								int num4 = (int)Math.Round(Math.Floor(90.0 / (double)dataTable.Rows.Count));
								IEnumerator enumerator = dataTable.Rows.GetEnumerator();
								while (enumerator.MoveNext())
								{
									DataRow dataRow = (DataRow)enumerator.Current;
									Module1.SaveDebug(Module1.pubLogin + " before stockFirst");
									double stock = cStock.getStock(Conversions.ToInteger(dataRow["prodId"]), Module1.pubBalanceDate, dtpBegin.Value, storageType, Conversions.ToInteger(cComboItem3.Value), Module1.pubGroupId, Conversions.ToInteger(cComboItem5.Value), Module1.pubReportUseNewGetStockCode);
									num3 += num4;
									ProgressBar1.Value = num3;
									Module1.SaveDebug(Module1.pubLogin + " before stockLast");
									double stock2 = cStock.getStock(Conversions.ToInteger(dataRow["prodId"]), Module1.pubBalanceDate, DateAndTime.DateAdd(DateInterval.Day, 1.0, dtpEnd.Value), storageType, Conversions.ToInteger(cComboItem3.Value), Module1.pubGroupId, Conversions.ToInteger(cComboItem5.Value), Module1.pubReportUseNewGetStockCode);
									dgvList.Rows.Add(dataRow["prodName"], Module1.formatCustomDecimal(Conversions.ToString(stock), 3), Module1.formatCustomDecimal(Conversions.ToString(stock2), 3));
								}
								if (enumerator is IDisposable)
								{
									(enumerator as IDisposable).Dispose();
								}
								ProgressBar1.Visible = false;
								if (Module1.pubPreviewReport)
								{
									btnWord.Enabled = true;
								}
								if (Module1.pubPrintReport)
								{
									btnPrint.Enabled = true;
								}
								dgvList.Focus();
							}
							else
							{
								Interaction.MsgBox("Gudang tidak memiliki stok", MsgBoxStyle.Information);
								ProgressBar1.Visible = false;
								btnWord.Enabled = false;
								btnPrint.Enabled = false;
								cboStorage.Focus();
							}
							Cursor = Cursors.Default;
							goto end_IL_0001;
						}
						if ((cboStorage.SelectedIndex == 0) & (cboItem.SelectedIndex > 0))
						{
							Cursor = Cursors.WaitCursor;
							formatGridAll(Storage: true);
							ProgressBar1.Visible = true;
							ProgressBar1.Value = 5;
							Module1.SaveDebug(Module1.pubLogin + " before cItem.GetItemStorage");
							dataTable = cItem.GetItemStorage(Conversions.ToInteger(cComboItem2.Value), (Conversions.ToDouble(cComboItem4.Value) == 1.0) ? "Good" : "Return", Conversions.ToInteger(cComboItem5.Value), Module1.pubGroupId);
							if (dataTable.Rows.Count > 0)
							{
								ProgressBar1.Value = 10;
								int num5 = 10;
								int num6 = (int)Math.Round(Math.Floor(90.0 / (double)dataTable.Rows.Count));
								IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
								while (enumerator2.MoveNext())
								{
									DataRow dataRow2 = (DataRow)enumerator2.Current;
									Module1.SaveDebug(Module1.pubLogin + " before SECOND stockFirst");
									double stock3 = cStock.getStock(Conversions.ToInteger(cComboItem2.Value), Module1.pubBalanceDate, dtpBegin.Value, storageType, Conversions.ToInteger(dataRow2["storeId"]), Module1.pubGroupId, Conversions.ToInteger(cComboItem5.Value), Module1.pubReportUseNewGetStockCode);
									num5 += num6;
									ProgressBar1.Value = num5;
									Module1.SaveDebug(Module1.pubLogin + " before SECOND stockLast");
									double stock4 = cStock.getStock(Conversions.ToInteger(cComboItem2.Value), Module1.pubBalanceDate, DateAndTime.DateAdd(DateInterval.Day, 1.0, dtpEnd.Value), storageType, Conversions.ToInteger(dataRow2["storeId"]), Module1.pubGroupId, Conversions.ToInteger(cComboItem5.Value), Module1.pubReportUseNewGetStockCode);
									dgvList.Rows.Add(dataRow2["storeName"], Module1.formatCustomDecimal(Conversions.ToString(stock3), 3), Module1.formatCustomDecimal(Conversions.ToString(stock4), 3));
									num7 += stock3;
									num8 += stock4;
								}
								if (enumerator2 is IDisposable)
								{
									(enumerator2 as IDisposable).Dispose();
								}
								dgvList.Rows.Add("Total", Module1.formatCustomDecimal(Conversions.ToString(num7), 3), Module1.formatCustomDecimal(Conversions.ToString(num8), 3));
								ProgressBar1.Visible = false;
								if (Module1.pubPreviewReport)
								{
									btnWord.Enabled = true;
								}
								if (Module1.pubPrintReport)
								{
									btnPrint.Enabled = true;
								}
								dgvList.Focus();
							}
							else
							{
								Interaction.MsgBox("Gudang tidak memiliki stok", MsgBoxStyle.Information);
								ProgressBar1.Visible = false;
								btnWord.Enabled = false;
								btnPrint.Enabled = false;
								cboStorage.Focus();
							}
							Cursor = Cursors.Default;
							goto end_IL_0001;
						}
						Cursor = Cursors.WaitCursor;
						btnSearch.Focus();
						Module1.SaveDebug(Module1.pubLogin + "before cStock.StockDetail outside if");
						dataTable = cStock.StockDetail(Conversions.ToInteger(cComboItem2.Value), Module1.pubBalanceDate, dtpBegin.Value, dtpEnd.Value, storageType, Conversions.ToInteger(cComboItem3.Value), Module1.pubGroupId, Conversions.ToInteger(cComboItem5.Value), Module1.pubReportUseNewGetStockCode);
						Module1.SaveDebug(Module1.pubLogin + "after cStock.StockDetail outside if");
						formatGrid();
						dgvList.Rows.Clear();
						IEnumerator enumerator3 = dataTable.Rows.GetEnumerator();
						while (enumerator3.MoveNext())
						{
							DataRow dataRow3 = (DataRow)enumerator3.Current;
							if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataRow3["orderby1"], 2, TextCompare: false), Operators.CompareObjectGreater(dataRow3["stockIn"], 0, TextCompare: false))))
							{
								num9 = Conversions.ToDouble(Operators.AddObject(num9, dataRow3["stockIn"]));
								dgvList.Rows.Add(dataRow3["stockDate"], dataRow3["Description"], Module1.formatCustomDecimal(Conversions.ToString(dataRow3["stockIn"]), 3), "", Module1.formatCustomDecimal(Conversions.ToString(num9), 3));
								double num10 = Conversions.ToDouble(dataRow3["stockIn"]);
								num11 += num10;
							}
							else if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataRow3["orderby1"], 2, TextCompare: false), Operators.CompareObjectGreater(dataRow3["stockOut"], 0, TextCompare: false))))
							{
								num9 = Conversions.ToDouble(Operators.SubtractObject(num9, dataRow3["stockOut"]));
								dgvList.Rows.Add(dataRow3["stockDate"], dataRow3["Description"], "", Module1.formatCustomDecimal(Conversions.ToString(dataRow3["stockOut"]), 3), Module1.formatCustomDecimal(Conversions.ToString(num9), 3));
								double num12 = Conversions.ToDouble(dataRow3["stockOut"]);
								num13 += num12;
							}
							else
							{
								dgvList.Rows.Add("", dataRow3["Description"], "", "", Module1.formatCustomDecimal(Conversions.ToString(dataRow3["stockIn"]), 3));
								num9 = Conversions.ToDouble(dataRow3["stockIn"]);
							}
						}
						if (enumerator3 is IDisposable)
						{
							(enumerator3 as IDisposable).Dispose();
						}
						dgvList.Rows.Add("", "", Module1.formatCustomDecimal(Conversions.ToString(num11), 3), Module1.formatCustomDecimal(Conversions.ToString(num13), 3));
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
						Cursor = Cursors.Default;
						goto end_IL_0001;
					}
					case 3296:
						num = -1;
						switch (num2)
						{
						case 2:
							ProgressBar1.Visible = false;
							Cursor = Cursors.Default;
							Module1.SaveError(Information.Err(), "frmReportStock", "btnSearch_click", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 3296;
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
		dgvList.Columns.Add("", "Tanggal");
		dgvList.Columns.Add("", "Keterangan");
		dgvList.Columns.Add("", "Masuk");
		dgvList.Columns.Add("", "Keluar");
		dgvList.Columns.Add("", "Sisa");
		dgvList.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvList.Columns[0].Width = 70;
		dgvList.Columns[1].Width = 180;
		dgvList.Columns[2].Width = 90;
		dgvList.Columns[3].Width = 90;
		dgvList.Columns[4].Width = 90;
		dgvList.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.RowHeadersVisible = false;
		dgvList.AllowUserToAddRows = false;
		dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvList.ReadOnly = true;
		dgvList.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvList.AllowUserToResizeRows = false;
		dgvList.DefaultCellStyle.Font = new Font("Segoe UI", 8f, FontStyle.Regular);
		DataGridView grid = dgvList;
		Module1.DisableGridSorting(ref grid);
		dgvList = grid;
	}

	private void formatGridAll(bool Storage)
	{
		dgvList.Rows.Clear();
		dgvList.Columns.Clear();
		if (!Storage)
		{
			dgvList.Columns.Add("", "Produk");
		}
		else
		{
			dgvList.Columns.Add("", "Gudang");
		}
		dgvList.Columns.Add("", "Jumlah Awal");
		dgvList.Columns.Add("", "Jumlah Akhir");
		dgvList.Columns[0].Width = 180;
		dgvList.Columns[1].Width = 90;
		dgvList.Columns[2].Width = 90;
		dgvList.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.RowHeadersVisible = false;
		dgvList.AllowUserToAddRows = false;
		dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvList.ReadOnly = true;
		dgvList.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvList.AllowUserToResizeRows = false;
		foreach (object column in dgvList.Columns)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(column);
			NewLateBinding.LateSet(objectValue, null, "SortMode", new object[1] { DataGridViewColumnSortMode.NotSortable }, null, null);
		}
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
		if (dgvList.RowCount > 0 && !(Conversion.Val(RuntimeHelpers.GetObjectValue(dgvList[0, dgvList.CurrentRow.Index].Value)) > 0.0))
		{
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
		if ((cboStorage.SelectedIndex > 0) & (cboItem.SelectedIndex == 0))
		{
			msWord.rptWordNew(dgvList.Rows.Count, dgvList.Columns.Count, "LRR", blnPortrait: true, "", Print);
		}
		else if ((cboStorage.SelectedIndex == 0) & (cboItem.SelectedIndex > 0))
		{
			msWord.rptWordNew(dgvList.Rows.Count, dgvList.Columns.Count, "LRR", blnPortrait: true, "", Print);
		}
		else
		{
			msWord.rptWordNew(dgvList.Rows.Count, dgvList.Columns.Count, "LLRRR", blnPortrait: true, "", Print);
		}
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

	private void btnSearchOld_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		double num7 = default(double);
		double num8 = default(double);
		double num9 = default(double);
		double num11 = default(double);
		double num13 = default(double);
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
						cComboItem cComboItem2 = (cComboItem)cboItem.SelectedItem;
						cComboItem cComboItem3 = (cComboItem)cboStorage.SelectedItem;
						cComboItem cComboItem4 = (cComboItem)cboStorageType.SelectedItem;
						cComboItem cComboItem5 = (cComboItem)cboBranch.SelectedItem;
						cComboItem cComboItem6 = (cComboItem)cboItemCategory.SelectedItem;
						if (DateTime.Compare(dtpBegin.Value, Module1.pubBalanceDate) < 0)
						{
							Interaction.MsgBox("Data sebelum " + Conversions.ToString(Module1.pubBalanceDate) + " tidak tersedia.");
							dtpBegin.Focus();
							goto end_IL_0001;
						}
						if (cboStorageType.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih jenis barang", MsgBoxStyle.Information);
							cboStorageType.Focus();
							goto end_IL_0001;
						}
						if (cboBranch.SelectedIndex == -1)
						{
							Interaction.MsgBox("Cabang yang anda pilih tidak terdaftar", MsgBoxStyle.Information);
							cboBranch.Focus();
							goto end_IL_0001;
						}
						if (cboStorage.SelectedIndex == -1)
						{
							Interaction.MsgBox("Gudang yang anda pilih tidak terdaftar", MsgBoxStyle.Information);
							cboStorage.Focus();
							goto end_IL_0001;
						}
						if (cboItemCategory.SelectedIndex == -1)
						{
							Interaction.MsgBox("Kategori barang yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
							cboItemCategory.Focus();
							goto end_IL_0001;
						}
						if (cboItem.SelectedIndex == -1)
						{
							Interaction.MsgBox("Barang yang anda pilih tidak terdaftar", MsgBoxStyle.Information);
							cboItem.Focus();
							goto end_IL_0001;
						}
						if ((cboItem.SelectedIndex == 0) & (cboStorage.SelectedIndex == 0))
						{
							Interaction.MsgBox("Pilih gudang/barang", MsgBoxStyle.Information);
							cboStorage.Focus();
							goto end_IL_0001;
						}
						DataTable dataTable = new DataTable();
						string storageType = ((Conversions.ToDouble(cComboItem4.Value) != 1.0) ? "Damage" : "Good");
						if ((cboStorage.SelectedIndex > 0) & (cboItem.SelectedIndex == 0))
						{
							Cursor = Cursors.WaitCursor;
							formatGridAll(Storage: false);
							ProgressBar1.Visible = true;
							ProgressBar1.Value = 5;
							dataTable = cItem.Search(99, 99, 0, 0, 0, 0, 99, 1, Conversions.ToInteger(cComboItem6.Value), 0, Conversions.ToInteger(cComboItem3.Value), 0, 0.0, CanBeUsedAsGroupMember: false, Module1.pubGroupId, 0, -1);
							if (dataTable.Rows.Count > 0)
							{
								ProgressBar1.Value = 10;
								int num3 = 10;
								int num4 = (int)Math.Round(Math.Floor(90.0 / (double)dataTable.Rows.Count));
								IEnumerator enumerator = dataTable.Rows.GetEnumerator();
								while (enumerator.MoveNext())
								{
									DataRow dataRow = (DataRow)enumerator.Current;
									double stock = cStock.getStock(Conversions.ToInteger(dataRow["prodId"]), Module1.pubBalanceDate, dtpBegin.Value, storageType, Conversions.ToInteger(cComboItem3.Value), Module1.pubGroupId, Conversions.ToInteger(cComboItem5.Value), blnNewGetStockCode: false);
									num3 += num4;
									ProgressBar1.Value = num3;
									double stock2 = cStock.getStock(Conversions.ToInteger(dataRow["prodId"]), Module1.pubBalanceDate, DateAndTime.DateAdd(DateInterval.Day, 1.0, dtpEnd.Value), storageType, Conversions.ToInteger(cComboItem3.Value), Module1.pubGroupId, Conversions.ToInteger(cComboItem5.Value), blnNewGetStockCode: false);
									dgvList.Rows.Add(dataRow["prodName"], Module1.formatCustomDecimal(Conversions.ToString(stock), 3), Module1.formatCustomDecimal(Conversions.ToString(stock2), 3));
								}
								if (enumerator is IDisposable)
								{
									(enumerator as IDisposable).Dispose();
								}
								ProgressBar1.Visible = false;
								if (Module1.pubPreviewReport)
								{
									btnWord.Enabled = true;
								}
								if (Module1.pubPrintReport)
								{
									btnPrint.Enabled = true;
								}
								dgvList.Focus();
							}
							else
							{
								Interaction.MsgBox("Gudang tidak memiliki stok", MsgBoxStyle.Information);
								ProgressBar1.Visible = false;
								btnWord.Enabled = false;
								btnPrint.Enabled = false;
								cboStorage.Focus();
							}
							Cursor = Cursors.Default;
							goto end_IL_0001;
						}
						if ((cboStorage.SelectedIndex == 0) & (cboItem.SelectedIndex > 0))
						{
							Cursor = Cursors.WaitCursor;
							formatGridAll(Storage: true);
							ProgressBar1.Visible = true;
							ProgressBar1.Value = 5;
							dataTable = cItem.GetItemStorage(Conversions.ToInteger(cComboItem2.Value), (Conversions.ToDouble(cComboItem4.Value) == 1.0) ? "Good" : "Return", Conversions.ToInteger(cComboItem5.Value), Module1.pubGroupId);
							if (dataTable.Rows.Count > 0)
							{
								ProgressBar1.Value = 10;
								int num5 = 10;
								int num6 = (int)Math.Round(Math.Floor(90.0 / (double)dataTable.Rows.Count));
								IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
								while (enumerator2.MoveNext())
								{
									DataRow dataRow2 = (DataRow)enumerator2.Current;
									double stock3 = cStock.getStock(Conversions.ToInteger(cComboItem2.Value), Module1.pubBalanceDate, dtpBegin.Value, storageType, Conversions.ToInteger(dataRow2["storeId"]), Module1.pubGroupId, Conversions.ToInteger(cComboItem5.Value), blnNewGetStockCode: false);
									num5 += num6;
									ProgressBar1.Value = num5;
									double stock4 = cStock.getStock(Conversions.ToInteger(cComboItem2.Value), Module1.pubBalanceDate, DateAndTime.DateAdd(DateInterval.Day, 1.0, dtpEnd.Value), storageType, Conversions.ToInteger(dataRow2["storeId"]), Module1.pubGroupId, Conversions.ToInteger(cComboItem5.Value), blnNewGetStockCode: false);
									dgvList.Rows.Add(dataRow2["storeName"], Module1.formatCustomDecimal(Conversions.ToString(stock3), 3), Module1.formatCustomDecimal(Conversions.ToString(stock4), 3));
									num7 += stock3;
									num8 += stock4;
								}
								if (enumerator2 is IDisposable)
								{
									(enumerator2 as IDisposable).Dispose();
								}
								dgvList.Rows.Add("Total", Module1.formatCustomDecimal(Conversions.ToString(num7), 3), Module1.formatCustomDecimal(Conversions.ToString(num8), 3));
								ProgressBar1.Visible = false;
								if (Module1.pubPreviewReport)
								{
									btnWord.Enabled = true;
								}
								if (Module1.pubPrintReport)
								{
									btnPrint.Enabled = true;
								}
								dgvList.Focus();
							}
							else
							{
								Interaction.MsgBox("Gudang tidak memiliki stok", MsgBoxStyle.Information);
								ProgressBar1.Visible = false;
								btnWord.Enabled = false;
								btnPrint.Enabled = false;
								cboStorage.Focus();
							}
							Cursor = Cursors.Default;
							goto end_IL_0001;
						}
						Cursor = Cursors.WaitCursor;
						btnSearchOld.Focus();
						dataTable = cStock.StockDetail(Conversions.ToInteger(cComboItem2.Value), Module1.pubBalanceDate, dtpBegin.Value, dtpEnd.Value, storageType, Conversions.ToInteger(cComboItem3.Value), Module1.pubGroupId, Conversions.ToInteger(cComboItem5.Value), blnNewCode: false);
						formatGrid();
						dgvList.Rows.Clear();
						IEnumerator enumerator3 = dataTable.Rows.GetEnumerator();
						while (enumerator3.MoveNext())
						{
							DataRow dataRow3 = (DataRow)enumerator3.Current;
							if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataRow3["orderby1"], 2, TextCompare: false), Operators.CompareObjectGreater(dataRow3["stockIn"], 0, TextCompare: false))))
							{
								num9 = Conversions.ToDouble(Operators.AddObject(num9, dataRow3["stockIn"]));
								dgvList.Rows.Add(dataRow3["stockDate"], dataRow3["Description"], Module1.formatCustomDecimal(Conversions.ToString(dataRow3["stockIn"]), 3), "", Module1.formatCustomDecimal(Conversions.ToString(num9), 3));
								double num10 = Conversions.ToDouble(dataRow3["stockIn"]);
								num11 += num10;
							}
							else if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataRow3["orderby1"], 2, TextCompare: false), Operators.CompareObjectGreater(dataRow3["stockOut"], 0, TextCompare: false))))
							{
								num9 = Conversions.ToDouble(Operators.SubtractObject(num9, dataRow3["stockOut"]));
								dgvList.Rows.Add(dataRow3["stockDate"], dataRow3["Description"], "", Module1.formatCustomDecimal(Conversions.ToString(dataRow3["stockOut"]), 3), Module1.formatCustomDecimal(Conversions.ToString(num9), 3));
								double num12 = Conversions.ToDouble(dataRow3["stockOut"]);
								num13 += num12;
							}
							else
							{
								dgvList.Rows.Add("", dataRow3["Description"], "", "", Module1.formatCustomDecimal(Conversions.ToString(dataRow3["stockIn"]), 3));
								num9 = Conversions.ToDouble(dataRow3["stockIn"]);
							}
						}
						if (enumerator3 is IDisposable)
						{
							(enumerator3 as IDisposable).Dispose();
						}
						dgvList.Rows.Add("", "", Module1.formatCustomDecimal(Conversions.ToString(num11), 3), Module1.formatCustomDecimal(Conversions.ToString(num13), 3));
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
						Cursor = Cursors.Default;
						goto end_IL_0001;
					}
					case 3102:
						num = -1;
						switch (num2)
						{
						case 2:
							ProgressBar1.Visible = false;
							Cursor = Cursors.Default;
							Module1.SaveError(Information.Err(), "frmReportStock", "btnSearchOld_click", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 3102;
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

	private void btnSearchNew_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		double num7 = default(double);
		double num8 = default(double);
		double num9 = default(double);
		double num11 = default(double);
		double num13 = default(double);
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
						cComboItem cComboItem2 = (cComboItem)cboItem.SelectedItem;
						cComboItem cComboItem3 = (cComboItem)cboStorage.SelectedItem;
						cComboItem cComboItem4 = (cComboItem)cboStorageType.SelectedItem;
						cComboItem cComboItem5 = (cComboItem)cboBranch.SelectedItem;
						cComboItem cComboItem6 = (cComboItem)cboItemCategory.SelectedItem;
						if (DateTime.Compare(dtpBegin.Value, Module1.pubBalanceDate) < 0)
						{
							Interaction.MsgBox("Data sebelum " + Conversions.ToString(Module1.pubBalanceDate) + " tidak tersedia.");
							dtpBegin.Focus();
							goto end_IL_0001;
						}
						if (cboStorageType.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih jenis barang", MsgBoxStyle.Information);
							cboStorageType.Focus();
							goto end_IL_0001;
						}
						if (cboBranch.SelectedIndex == -1)
						{
							Interaction.MsgBox("Cabang yang anda pilih tidak terdaftar", MsgBoxStyle.Information);
							cboBranch.Focus();
							goto end_IL_0001;
						}
						if (cboStorage.SelectedIndex == -1)
						{
							Interaction.MsgBox("Gudang yang anda pilih tidak terdaftar", MsgBoxStyle.Information);
							cboStorage.Focus();
							goto end_IL_0001;
						}
						if (cboItemCategory.SelectedIndex == -1)
						{
							Interaction.MsgBox("Kategori barang yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
							cboItemCategory.Focus();
							goto end_IL_0001;
						}
						if (cboItem.SelectedIndex == -1)
						{
							Interaction.MsgBox("Barang yang anda pilih tidak terdaftar", MsgBoxStyle.Information);
							cboItem.Focus();
							goto end_IL_0001;
						}
						DataTable dataTable = new DataTable();
						string storageType = ((Conversions.ToDouble(cComboItem4.Value) != 1.0) ? "Damage" : "Good");
						if (cboItem.SelectedIndex == 0)
						{
							Cursor = Cursors.WaitCursor;
							formatGridAll(Storage: false);
							ProgressBar1.Visible = true;
							ProgressBar1.Value = 5;
							dataTable = cItem.Search(99, 99, 0, 0, 0, 0, 99, 1, Conversions.ToInteger(cComboItem6.Value), 0, Conversions.ToInteger(cComboItem3.Value), 0, 0.0, CanBeUsedAsGroupMember: false, Module1.pubGroupId, Conversions.ToInteger(cComboItem5.Value), -1);
							if (dataTable.Rows.Count > 0)
							{
								ProgressBar1.Value = 10;
								int num3 = 10;
								int num4 = (int)Math.Round(Math.Floor(90.0 / (double)dataTable.Rows.Count));
								IEnumerator enumerator = dataTable.Rows.GetEnumerator();
								while (enumerator.MoveNext())
								{
									DataRow dataRow = (DataRow)enumerator.Current;
									double stock = cStock.getStock(Conversions.ToInteger(dataRow["prodId"]), Module1.pubBalanceDate, dtpBegin.Value, storageType, Conversions.ToInteger(cComboItem3.Value), Module1.pubGroupId, Conversions.ToInteger(cComboItem5.Value), blnNewGetStockCode: true);
									num3 += num4;
									ProgressBar1.Value = num3;
									double stock2 = cStock.getStock(Conversions.ToInteger(dataRow["prodId"]), Module1.pubBalanceDate, DateAndTime.DateAdd(DateInterval.Day, 1.0, dtpEnd.Value), storageType, Conversions.ToInteger(cComboItem3.Value), Module1.pubGroupId, Conversions.ToInteger(cComboItem5.Value), blnNewGetStockCode: true);
									dgvList.Rows.Add(dataRow["prodName"], Module1.formatCustomDecimal(Conversions.ToString(stock), 3), Module1.formatCustomDecimal(Conversions.ToString(stock2), 3));
								}
								if (enumerator is IDisposable)
								{
									(enumerator as IDisposable).Dispose();
								}
								ProgressBar1.Visible = false;
								if (Module1.pubPreviewReport)
								{
									btnWord.Enabled = true;
								}
								if (Module1.pubPrintReport)
								{
									btnPrint.Enabled = true;
								}
								dgvList.Focus();
							}
							else
							{
								Interaction.MsgBox("Gudang tidak memiliki stok", MsgBoxStyle.Information);
								ProgressBar1.Visible = false;
								btnWord.Enabled = false;
								btnPrint.Enabled = false;
								cboStorage.Focus();
							}
							Cursor = Cursors.Default;
							goto end_IL_0001;
						}
						if ((cboStorage.SelectedIndex == 0) & (cboItem.SelectedIndex > 0))
						{
							Cursor = Cursors.WaitCursor;
							formatGridAll(Storage: true);
							ProgressBar1.Visible = true;
							ProgressBar1.Value = 5;
							dataTable = cItem.GetItemStorage(Conversions.ToInteger(cComboItem2.Value), (Conversions.ToDouble(cComboItem4.Value) == 1.0) ? "Good" : "Return", Conversions.ToInteger(cComboItem5.Value), Module1.pubGroupId);
							if (dataTable.Rows.Count > 0)
							{
								ProgressBar1.Value = 10;
								int num5 = 10;
								int num6 = (int)Math.Round(Math.Floor(90.0 / (double)dataTable.Rows.Count));
								IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
								while (enumerator2.MoveNext())
								{
									DataRow dataRow2 = (DataRow)enumerator2.Current;
									double stock3 = cStock.getStock(Conversions.ToInteger(cComboItem2.Value), Module1.pubBalanceDate, dtpBegin.Value, storageType, Conversions.ToInteger(dataRow2["storeId"]), Module1.pubGroupId, Conversions.ToInteger(cComboItem5.Value), blnNewGetStockCode: true);
									num5 += num6;
									ProgressBar1.Value = num5;
									double stock4 = cStock.getStock(Conversions.ToInteger(cComboItem2.Value), Module1.pubBalanceDate, DateAndTime.DateAdd(DateInterval.Day, 1.0, dtpEnd.Value), storageType, Conversions.ToInteger(dataRow2["storeId"]), Module1.pubGroupId, Conversions.ToInteger(cComboItem5.Value), blnNewGetStockCode: true);
									dgvList.Rows.Add(dataRow2["storeName"], Module1.formatCustomDecimal(Conversions.ToString(stock3), 3), Module1.formatCustomDecimal(Conversions.ToString(stock4), 3));
									num7 += stock3;
									num8 += stock4;
								}
								if (enumerator2 is IDisposable)
								{
									(enumerator2 as IDisposable).Dispose();
								}
								dgvList.Rows.Add("Total", Module1.formatCustomDecimal(Conversions.ToString(num7), 3), Module1.formatCustomDecimal(Conversions.ToString(num8), 3));
								ProgressBar1.Visible = false;
								if (Module1.pubPreviewReport)
								{
									btnWord.Enabled = true;
								}
								if (Module1.pubPrintReport)
								{
									btnPrint.Enabled = true;
								}
								dgvList.Focus();
							}
							else
							{
								Interaction.MsgBox("Gudang tidak memiliki stok", MsgBoxStyle.Information);
								ProgressBar1.Visible = false;
								btnWord.Enabled = false;
								btnPrint.Enabled = false;
								cboStorage.Focus();
							}
							Cursor = Cursors.Default;
							goto end_IL_0001;
						}
						Cursor = Cursors.WaitCursor;
						btnSearchNew.Focus();
						dataTable = cStock.StockDetail(Conversions.ToInteger(cComboItem2.Value), Module1.pubBalanceDate, dtpBegin.Value, dtpEnd.Value, storageType, Conversions.ToInteger(cComboItem3.Value), Module1.pubGroupId, Conversions.ToInteger(cComboItem5.Value), blnNewCode: true);
						formatGrid();
						dgvList.Rows.Clear();
						IEnumerator enumerator3 = dataTable.Rows.GetEnumerator();
						while (enumerator3.MoveNext())
						{
							DataRow dataRow3 = (DataRow)enumerator3.Current;
							if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataRow3["orderby1"], 2, TextCompare: false), Operators.CompareObjectGreater(dataRow3["stockIn"], 0, TextCompare: false))))
							{
								num9 = Conversions.ToDouble(Operators.AddObject(num9, dataRow3["stockIn"]));
								dgvList.Rows.Add(dataRow3["stockDate"], dataRow3["Description"], Module1.formatCustomDecimal(Conversions.ToString(dataRow3["stockIn"]), 3), "", Module1.formatCustomDecimal(Conversions.ToString(num9), 3));
								double num10 = Conversions.ToDouble(dataRow3["stockIn"]);
								num11 += num10;
							}
							else if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataRow3["orderby1"], 2, TextCompare: false), Operators.CompareObjectGreater(dataRow3["stockOut"], 0, TextCompare: false))))
							{
								num9 = Conversions.ToDouble(Operators.SubtractObject(num9, dataRow3["stockOut"]));
								dgvList.Rows.Add(dataRow3["stockDate"], dataRow3["Description"], "", Module1.formatCustomDecimal(Conversions.ToString(dataRow3["stockOut"]), 3), Module1.formatCustomDecimal(Conversions.ToString(num9), 3));
								double num12 = Conversions.ToDouble(dataRow3["stockOut"]);
								num13 += num12;
							}
							else
							{
								dgvList.Rows.Add("", dataRow3["Description"], "", "", Module1.formatCustomDecimal(Conversions.ToString(dataRow3["stockIn"]), 3));
								num9 = Conversions.ToDouble(dataRow3["stockIn"]);
							}
						}
						if (enumerator3 is IDisposable)
						{
							(enumerator3 as IDisposable).Dispose();
						}
						dgvList.Rows.Add("", "", Module1.formatCustomDecimal(Conversions.ToString(num11), 3), Module1.formatCustomDecimal(Conversions.ToString(num13), 3));
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
						Cursor = Cursors.Default;
						goto end_IL_0001;
					}
					case 3032:
						num = -1;
						switch (num2)
						{
						case 2:
							ProgressBar1.Visible = false;
							Cursor = Cursors.Default;
							Module1.SaveError(Information.Err(), "frmReportStock", "btnSearchNew_click", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 3032;
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
}
