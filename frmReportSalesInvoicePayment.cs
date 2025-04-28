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
public class frmReportSalesInvoicePayment : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboBranch")]
	private ComboBox _cboBranch;

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

	private double _customerId;

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
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

	[field: AccessedThroughProperty("cboSalesPerson")]
	internal virtual ComboBox cboSalesPerson
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

	[field: AccessedThroughProperty("cboArea")]
	internal virtual ComboBox cboArea
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

	[field: AccessedThroughProperty("cboPaymentCode")]
	internal virtual ComboBox cboPaymentCode
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

	[field: AccessedThroughProperty("cboInvoiceCode")]
	internal virtual ComboBox cboInvoiceCode
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboCollector")]
	internal virtual ComboBox cboCollector
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboInvoiceType")]
	internal virtual ComboBox cboInvoiceType
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

	[field: AccessedThroughProperty("cboTF")]
	internal virtual ComboBox cboTF
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

	public double CustomerId
	{
		get
		{
			return _customerId;
		}
		set
		{
			_customerId = value;
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
		this.cboStorage = new System.Windows.Forms.ComboBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.cboSalesPerson = new System.Windows.Forms.ComboBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.cboBranch = new System.Windows.Forms.ComboBox();
		this.btnReset = new System.Windows.Forms.Button();
		this.btnWord = new System.Windows.Forms.Button();
		this.Label1 = new System.Windows.Forms.Label();
		this.lblTotal = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.cboArea = new System.Windows.Forms.ComboBox();
		this.dgvList = new System.Windows.Forms.DataGridView();
		this.btnSearch = new System.Windows.Forms.Button();
		this.Label2 = new System.Windows.Forms.Label();
		this.dtpEnd = new System.Windows.Forms.DateTimePicker();
		this.dtpBegin = new System.Windows.Forms.DateTimePicker();
		this.Label5 = new System.Windows.Forms.Label();
		this.cboPaymentCode = new System.Windows.Forms.ComboBox();
		this.Label8 = new System.Windows.Forms.Label();
		this.cboInvoiceCode = new System.Windows.Forms.ComboBox();
		this.Label10 = new System.Windows.Forms.Label();
		this.cboCollector = new System.Windows.Forms.ComboBox();
		this.Label11 = new System.Windows.Forms.Label();
		this.cboInvoiceType = new System.Windows.Forms.ComboBox();
		this.Label9 = new System.Windows.Forms.Label();
		this.cboTF = new System.Windows.Forms.ComboBox();
		this.btnPrint = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		base.SuspendLayout();
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.Location = new System.Drawing.Point(10, 94);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(45, 13);
		this.Label6.TabIndex = 202;
		this.Label6.Text = "Gudang";
		this.cboStorage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboStorage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboStorage.FormattingEnabled = true;
		this.cboStorage.Location = new System.Drawing.Point(101, 91);
		this.cboStorage.Name = "cboStorage";
		this.cboStorage.Size = new System.Drawing.Size(120, 21);
		this.cboStorage.TabIndex = 3;
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(10, 202);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(33, 13);
		this.Label4.TabIndex = 201;
		this.Label4.Text = "Sales";
		this.cboSalesPerson.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboSalesPerson.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboSalesPerson.FormattingEnabled = true;
		this.cboSalesPerson.Location = new System.Drawing.Point(101, 199);
		this.cboSalesPerson.Name = "cboSalesPerson";
		this.cboSalesPerson.Size = new System.Drawing.Size(120, 21);
		this.cboSalesPerson.TabIndex = 9;
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(10, 67);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(44, 13);
		this.Label3.TabIndex = 200;
		this.Label3.Text = "Cabang";
		this.cboBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboBranch.FormattingEnabled = true;
		this.cboBranch.Location = new System.Drawing.Point(101, 64);
		this.cboBranch.Name = "cboBranch";
		this.cboBranch.Size = new System.Drawing.Size(120, 21);
		this.cboBranch.TabIndex = 2;
		this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnReset.Location = new System.Drawing.Point(156, 308);
		this.btnReset.Name = "btnReset";
		this.btnReset.Size = new System.Drawing.Size(47, 24);
		this.btnReset.TabIndex = 22;
		this.btnReset.Text = "&Reset";
		this.btnReset.UseVisualStyleBackColor = true;
		this.btnWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnWord.Location = new System.Drawing.Point(796, 490);
		this.btnWord.Name = "btnWord";
		this.btnWord.Size = new System.Drawing.Size(73, 23);
		this.btnWord.TabIndex = 24;
		this.btnWord.Text = "&Word";
		this.btnWord.UseVisualStyleBackColor = true;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(10, 15);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(71, 13);
		this.Label1.TabIndex = 198;
		this.Label1.Text = "Tanggal awal";
		this.lblTotal.AutoSize = true;
		this.lblTotal.Location = new System.Drawing.Point(234, 495);
		this.lblTotal.Name = "lblTotal";
		this.lblTotal.Size = new System.Drawing.Size(91, 13);
		this.lblTotal.TabIndex = 197;
		this.lblTotal.Text = "Total Pencarian: -";
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.Location = new System.Drawing.Point(10, 283);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(45, 13);
		this.Label7.TabIndex = 196;
		this.Label7.Text = "Wilayah";
		this.cboArea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboArea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboArea.FormattingEnabled = true;
		this.cboArea.Location = new System.Drawing.Point(101, 280);
		this.cboArea.Name = "cboArea";
		this.cboArea.Size = new System.Drawing.Size(120, 21);
		this.cboArea.TabIndex = 12;
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.Location = new System.Drawing.Point(237, 12);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(711, 472);
		this.dgvList.TabIndex = 23;
		this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSearch.Location = new System.Drawing.Point(102, 307);
		this.btnSearch.Name = "btnSearch";
		this.btnSearch.Size = new System.Drawing.Size(47, 24);
		this.btnSearch.TabIndex = 21;
		this.btnSearch.Text = "&Cari";
		this.btnSearch.UseVisualStyleBackColor = true;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(10, 41);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(72, 13);
		this.Label2.TabIndex = 195;
		this.Label2.Text = "Tanggal akhir";
		this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpEnd.Location = new System.Drawing.Point(100, 38);
		this.dtpEnd.Name = "dtpEnd";
		this.dtpEnd.Size = new System.Drawing.Size(121, 20);
		this.dtpEnd.TabIndex = 1;
		this.dtpBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpBegin.Location = new System.Drawing.Point(100, 12);
		this.dtpBegin.Name = "dtpBegin";
		this.dtpBegin.Size = new System.Drawing.Size(121, 20);
		this.dtpBegin.TabIndex = 0;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(10, 148);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(58, 13);
		this.Label5.TabIndex = 208;
		this.Label5.Text = "Tipe Bayar";
		this.cboPaymentCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboPaymentCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboPaymentCode.FormattingEnabled = true;
		this.cboPaymentCode.Location = new System.Drawing.Point(101, 145);
		this.cboPaymentCode.Name = "cboPaymentCode";
		this.cboPaymentCode.Size = new System.Drawing.Size(120, 21);
		this.cboPaymentCode.TabIndex = 7;
		this.Label8.AutoSize = true;
		this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label8.Location = new System.Drawing.Point(10, 175);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(66, 13);
		this.Label8.TabIndex = 210;
		this.Label8.Text = "Tunai/Kredit";
		this.cboInvoiceCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboInvoiceCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboInvoiceCode.FormattingEnabled = true;
		this.cboInvoiceCode.Location = new System.Drawing.Point(101, 172);
		this.cboInvoiceCode.Name = "cboInvoiceCode";
		this.cboInvoiceCode.Size = new System.Drawing.Size(120, 21);
		this.cboInvoiceCode.TabIndex = 8;
		this.Label10.AutoSize = true;
		this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label10.Location = new System.Drawing.Point(10, 229);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(46, 13);
		this.Label10.TabIndex = 212;
		this.Label10.Text = "Penagih";
		this.cboCollector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboCollector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboCollector.FormattingEnabled = true;
		this.cboCollector.Location = new System.Drawing.Point(101, 226);
		this.cboCollector.Name = "cboCollector";
		this.cboCollector.Size = new System.Drawing.Size(120, 21);
		this.cboCollector.TabIndex = 10;
		this.Label11.AutoSize = true;
		this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label11.Location = new System.Drawing.Point(10, 121);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(61, 13);
		this.Label11.TabIndex = 214;
		this.Label11.Text = "Tipe Faktur";
		this.cboInvoiceType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboInvoiceType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboInvoiceType.FormattingEnabled = true;
		this.cboInvoiceType.Location = new System.Drawing.Point(101, 118);
		this.cboInvoiceType.Name = "cboInvoiceType";
		this.cboInvoiceType.Size = new System.Drawing.Size(120, 21);
		this.cboInvoiceType.TabIndex = 6;
		this.Label9.AutoSize = true;
		this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label9.Location = new System.Drawing.Point(10, 256);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(68, 13);
		this.Label9.TabIndex = 216;
		this.Label9.Text = "Tukar Faktur";
		this.cboTF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboTF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboTF.FormattingEnabled = true;
		this.cboTF.Location = new System.Drawing.Point(101, 253);
		this.cboTF.Name = "cboTF";
		this.cboTF.Size = new System.Drawing.Size(120, 21);
		this.cboTF.TabIndex = 11;
		this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnPrint.Location = new System.Drawing.Point(875, 489);
		this.btnPrint.Name = "btnPrint";
		this.btnPrint.Size = new System.Drawing.Size(73, 23);
		this.btnPrint.TabIndex = 25;
		this.btnPrint.Text = "Cetak";
		this.btnPrint.UseVisualStyleBackColor = true;
		base.AcceptButton = this.btnSearch;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(962, 524);
		base.Controls.Add(this.btnPrint);
		base.Controls.Add(this.Label9);
		base.Controls.Add(this.cboTF);
		base.Controls.Add(this.Label11);
		base.Controls.Add(this.cboInvoiceType);
		base.Controls.Add(this.Label10);
		base.Controls.Add(this.cboCollector);
		base.Controls.Add(this.Label8);
		base.Controls.Add(this.cboInvoiceCode);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.cboPaymentCode);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.cboStorage);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.cboSalesPerson);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.cboBranch);
		base.Controls.Add(this.btnReset);
		base.Controls.Add(this.btnWord);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.lblTotal);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.cboArea);
		base.Controls.Add(this.dgvList);
		base.Controls.Add(this.btnSearch);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.dtpEnd);
		base.Controls.Add(this.dtpBegin);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmReportSalesInvoicePayment";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Report Pembayaran Faktur";
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmReportSalesInvoicePayment()
	{
		base.KeyDown += frmSalesInvoicePayment_KeyDown;
		base.Load += frmSalesInvoicePayment_Load;
		InitializeComponent();
		DoubleBuffered = true;
		base.MdiParent = MyProject.Forms.frmMenu;
		ComboBox combo = cboBranch;
		cCombo.getBranch(ref combo, Module1.pubGroupId, blnAll: true);
		cboBranch = combo;
		combo = cboInvoiceType;
		cCombo.getSalesInvoiceType(ref combo, All: false);
		cboInvoiceType = combo;
		combo = cboPaymentCode;
		cCombo.getPaymentCode(ref combo, All: true, ShowCheque: true);
		cboPaymentCode = combo;
		combo = cboInvoiceCode;
		cCombo.getInvoiceCode(ref combo, All: true);
		cboInvoiceCode = combo;
	}

	private void frmSalesInvoicePayment_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void frmSalesInvoicePayment_Load(object sender, EventArgs e)
	{
		prepareForm();
		ExtensionMethods.DoubleBuffered(dgvList, setting: true);
	}

	private void prepareForm()
	{
		btnWord.Enabled = false;
		btnPrint.Enabled = false;
		dtpBegin.Value = Module1.getFirstDateInMonth(DateAndTime.Now);
		dtpEnd.Value = DateAndTime.Now;
		cboInvoiceType.SelectedIndex = 0;
		cboPaymentCode.SelectedIndex = 0;
		cboInvoiceCode.SelectedIndex = 0;
		cboBranch.SelectedIndex = 0;
		cboArea.SelectedIndex = 0;
		cboStorage.SelectedIndex = 0;
		cboSalesPerson.SelectedIndex = 0;
		cboCollector.SelectedIndex = 0;
		cboTF.SelectedIndex = 0;
		dgvList.Rows.Clear();
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

	private void cboBranch_SelectedIndexChanged(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboBranch.SelectedItem;
		if (!Information.IsNothing(cComboItem2))
		{
			ComboBox combo = cboStorage;
			cCombo.getStorage(ref combo, Module1.pubGroupId, Conversions.ToInteger(cComboItem2.Value), "MARKETING", blnAll: true, 1);
			cboStorage = combo;
			combo = cboSalesPerson;
			cCombo.getSalesPerson(ref combo, "SALESPERSON", 0, 99, Conversions.ToInteger(cComboItem2.Value), Module1.pubGroupId, All: true, Dash: false, 1);
			cboSalesPerson = combo;
			combo = cboCollector;
			cCombo.getSalesPerson(ref combo, "ALL", 0, 99, Conversions.ToInteger(cComboItem2.Value), Module1.pubGroupId, All: true, Dash: false, 1);
			cboCollector = combo;
			combo = cboTF;
			cCombo.getSalesPerson(ref combo, "ALL", 0, 99, Conversions.ToInteger(cComboItem2.Value), Module1.pubGroupId, All: true, Dash: false, 1);
			cboTF = combo;
			combo = cboArea;
			cCombo.getArea(ref combo, Conversions.ToInteger(cComboItem2.Value), Module1.pubGroupId, All: true, Active: true);
			cboArea = combo;
			combo = cboStorage;
			Module1.comboBoundValue(ref combo, 0.0);
			cboStorage = combo;
			combo = cboArea;
			Module1.comboBoundValue(ref combo, 0.0);
			cboArea = combo;
			combo = cboSalesPerson;
			Module1.comboBoundValue(ref combo, 0.0);
			cboSalesPerson = combo;
			combo = cboCollector;
			Module1.comboBoundValue(ref combo, 0.0);
			cboCollector = combo;
			combo = cboTF;
			Module1.comboBoundValue(ref combo, 0.0);
			cboTF = combo;
			_customerId = 0.0;
		}
	}

	private void btnAllCustomer_Click(object sender, EventArgs e)
	{
		_customerId = 0.0;
	}

	private void btnSearchCustomer_Click(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboBranch.SelectedItem;
		frmCustomerMiniSearch frmCustomerMiniSearch2 = new frmCustomerMiniSearch();
		frmCustomerMiniSearch2.BranchId = Conversions.ToInteger(cComboItem2.Value);
		frmCustomerMiniSearch2.CallerName = "reportCustomerPayment";
		frmCustomerMiniSearch2.ShowDialog();
		frmCustomerMiniSearch2.Close();
		frmCustomerMiniSearch2.Dispose();
	}

	private void btnSearch_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		double num3 = default(double);
		double num4 = default(double);
		double num5 = default(double);
		double num6 = default(double);
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
					cComboItem cComboItem4 = (cComboItem)cboArea.SelectedItem;
					cComboItem cComboItem5 = (cComboItem)cboSalesPerson.SelectedItem;
					cComboItem cComboItem6 = (cComboItem)cboCollector.SelectedItem;
					cComboItem cComboItem7 = (cComboItem)cboTF.SelectedItem;
					cComboItem cComboItem8 = (cComboItem)cboInvoiceCode.SelectedItem;
					cComboItem cComboItem9 = (cComboItem)cboInvoiceType.SelectedItem;
					cComboItem cComboItem10 = (cComboItem)cboPaymentCode.SelectedItem;
					if (cboBranch.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih cabang", MsgBoxStyle.Information);
						cboBranch.Focus();
						goto end_IL_0001;
					}
					if (cboStorage.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih gudang", MsgBoxStyle.Information);
						cboStorage.Focus();
						goto end_IL_0001;
					}
					if (cboInvoiceType.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih tipe faktur", MsgBoxStyle.Information);
						cboInvoiceType.Focus();
						goto end_IL_0001;
					}
					if (cboPaymentCode.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih tipe bayar", MsgBoxStyle.Information);
						cboPaymentCode.Focus();
						goto end_IL_0001;
					}
					if (cboInvoiceCode.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih tunai/kredit", MsgBoxStyle.Information);
						cboInvoiceCode.Focus();
						goto end_IL_0001;
					}
					if (cboSalesPerson.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih sales", MsgBoxStyle.Information);
						cboSalesPerson.Focus();
						goto end_IL_0001;
					}
					if (cboCollector.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih penagih", MsgBoxStyle.Information);
						cboCollector.Focus();
						goto end_IL_0001;
					}
					if (cboTF.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih tukar faktur", MsgBoxStyle.Information);
						cboTF.Focus();
						goto end_IL_0001;
					}
					if (cboArea.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih wilayah", MsgBoxStyle.Information);
						cboArea.Focus();
						goto end_IL_0001;
					}
					DataTable dataTable = new DataTable();
					Cursor = Cursors.WaitCursor;
					btnSearch.Focus();
					dataTable = cSalesInvoice.SearchPayment(dtpBegin.Value, dtpEnd.Value, Conversions.ToInteger(cComboItem10.Value), Conversions.ToInteger(cComboItem9.Value), Conversions.ToInteger(cComboItem8.Value), Conversions.ToInteger(cComboItem5.Value), Conversions.ToInteger(cComboItem6.Value), Conversions.ToInteger(cComboItem7.Value), Conversions.ToInteger(cComboItem4.Value), Conversions.ToInteger(cComboItem3.Value), Conversions.ToInteger(cComboItem2.Value), Module1.pubGroupId);
					dgvList.Rows.Clear();
					formatGrid();
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						dgvList.Rows.Add(dataRow["penjId"], dataRow["pbDate"], dataRow["penjFaktur"], dataRow["pkName"], Interaction.IIf(Operators.ConditionalCompareObjectEqual(dataRow["penjKode"], 0, TextCompare: false), "T", "K"), dataRow["salesName"], Interaction.IIf(Operators.ConditionalCompareObjectNotEqual(dataRow["salesId"], dataRow["kolId"], TextCompare: false), RuntimeHelpers.GetObjectValue(dataRow["collector"]), "-"), Interaction.IIf(!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TF"])), RuntimeHelpers.GetObjectValue(dataRow["TF"]), "-"), dataRow["wilName"], Module1.formatCustomDecimal(Conversions.ToString(dataRow["pbAmount"]), 2));
						if (Operators.ConditionalCompareObjectEqual(dataRow["pkName"], "CASH", TextCompare: false))
						{
							num3 = Conversions.ToDouble(Operators.AddObject(num3, dataRow["pbAmount"]));
						}
						else if (Operators.ConditionalCompareObjectEqual(dataRow["pkName"], "C/G", TextCompare: false))
						{
							num4 = Conversions.ToDouble(Operators.AddObject(num4, dataRow["pbAmount"]));
						}
						else if (Operators.ConditionalCompareObjectEqual(dataRow["pkName"], "LLG", TextCompare: false))
						{
							num5 = Conversions.ToDouble(Operators.AddObject(num5, dataRow["pbAmount"]));
						}
						num6 = Conversions.ToDouble(Operators.AddObject(num6, dataRow["pbAmount"]));
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
						dgvList.Rows.Add("", "Total Cash", "", "", "", "", "", "", "", Module1.formatCustomDecimal(Conversions.ToString(num3), 2));
						dgvList.Rows.Add("", "Total Cek/Giro", "", "", "", "", "", "", "", Module1.formatCustomDecimal(Conversions.ToString(num4), 2));
						dgvList.Rows.Add("", "Total LLG", "", "", "", "", "", "", "", Module1.formatCustomDecimal(Conversions.ToString(num5), 2));
						dgvList.Rows.Add("", "Total", "", "", "", "", "", "", "", Module1.formatCustomDecimal(Conversions.ToString(num6), 2));
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
					lblTotal.Text = "Total Pencarian: " + Conversions.ToString(dataTable.Rows.Count);
					Cursor = Cursors.Default;
					goto end_IL_0001;
				}
				case 2103:
					num = -1;
					switch (num2)
					{
					case 2:
						Cursor = Cursors.Default;
						Module1.SaveError(Information.Err(), "frmSalesInvoicePayment", "btnSearch_click", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 2103;
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
		dgvList.Columns.Add("", "penjId");
		dgvList.Columns.Add("", "Tanggal");
		dgvList.Columns.Add("", "Faktur");
		dgvList.Columns.Add("", "Tipe");
		dgvList.Columns.Add("", "T/K");
		dgvList.Columns.Add("", "Sales");
		dgvList.Columns.Add("", "Penagih");
		dgvList.Columns.Add("", "Tukar Faktur");
		dgvList.Columns.Add("", "Wilayah");
		dgvList.Columns.Add("", "Jumlah");
		dgvList.Columns[0].Visible = false;
		dgvList.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvList.Columns[1].Width = 65;
		dgvList.Columns[2].Width = 100;
		dgvList.Columns[3].Width = 40;
		dgvList.Columns[4].Width = 35;
		dgvList.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		dgvList.Columns[5].Width = 120;
		dgvList.Columns[6].Width = 65;
		dgvList.Columns[7].Width = 70;
		dgvList.Columns[8].Width = 100;
		dgvList.Columns[9].Width = 80;
		dgvList.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.RowHeadersVisible = false;
		dgvList.AllowUserToAddRows = false;
		dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvList.ReadOnly = true;
		dgvList.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvList.AllowUserToResizeRows = false;
		DataGridView grid = dgvList;
		Module1.DisableGridSorting(ref grid);
		dgvList = grid;
		dgvList.DefaultCellStyle.Font = new Font("Segoe UI", 8f, FontStyle.Regular);
		dgvList.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8f, FontStyle.Regular);
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
			MyProject.Forms.frmSalesInvoice.Show();
			MyProject.Forms.frmSalesInvoice.prepareForm(SaveNew: false);
			MyProject.Forms.frmSalesInvoice.CurrentId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
			MyProject.Forms.frmSalesInvoice.LoadData();
			MyProject.Forms.frmSalesInvoice.Activate();
			MyProject.Forms.frmSalesInvoice.WindowState = FormWindowState.Normal;
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
		msWord.rptWordNew(dgvList.Rows.Count, dgvList.Columns.Count, "LLLLLLLLR", blnPortrait: false, "", Print);
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
