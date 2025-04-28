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
using Microsoft.VisualBasic.PowerPacks;

namespace GCUv2;

[DesignerGenerated]
public class frmReportSalesReturnItem : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnAllCustomer")]
	private Button _btnAllCustomer;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSearchCustomer")]
	private Button _btnSearchCustomer;

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
	[AccessedThroughProperty("cboItemCategory")]
	private ComboBox _cboItemCategory;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnPrint")]
	private Button _btnPrint;

	private double _customerId;

	internal virtual Button btnAllCustomer
	{
		[CompilerGenerated]
		get
		{
			return _btnAllCustomer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnAllCustomer_Click;
			Button button = _btnAllCustomer;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnAllCustomer = value;
			button = _btnAllCustomer;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button btnSearchCustomer
	{
		[CompilerGenerated]
		get
		{
			return _btnSearchCustomer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnSearchCustomer_Click;
			Button button = _btnSearchCustomer;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnSearchCustomer = value;
			button = _btnSearchCustomer;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("lblCustomerName")]
	internal virtual Label lblCustomerName
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

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboGroupBy")]
	internal virtual ComboBox cboGroupBy
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

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

	[field: AccessedThroughProperty("LineShape2")]
	internal virtual LineShape LineShape2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LineShape1")]
	internal virtual LineShape LineShape1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ShapeContainer1")]
	internal virtual ShapeContainer ShapeContainer1
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

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
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
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		this.btnAllCustomer = new System.Windows.Forms.Button();
		this.btnSearchCustomer = new System.Windows.Forms.Button();
		this.lblCustomerName = new System.Windows.Forms.Label();
		this.Label9 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.cboGroupBy = new System.Windows.Forms.ComboBox();
		this.Label6 = new System.Windows.Forms.Label();
		this.cboStorage = new System.Windows.Forms.ComboBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.cboSalesPerson = new System.Windows.Forms.ComboBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.cboBranch = new System.Windows.Forms.ComboBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.cboSearchType = new System.Windows.Forms.ComboBox();
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
		this.LineShape2 = new LineShape();
		this.LineShape1 = new LineShape();
		this.ShapeContainer1 = new ShapeContainer();
		this.Label10 = new System.Windows.Forms.Label();
		this.cboItemCategory = new System.Windows.Forms.ComboBox();
		this.Label11 = new System.Windows.Forms.Label();
		this.cboItem = new System.Windows.Forms.ComboBox();
		this.btnPrint = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		base.SuspendLayout();
		this.btnAllCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAllCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAllCustomer.Location = new System.Drawing.Point(71, 156);
		this.btnAllCustomer.Name = "btnAllCustomer";
		this.btnAllCustomer.Size = new System.Drawing.Size(50, 23);
		this.btnAllCustomer.TabIndex = 5;
		this.btnAllCustomer.Text = "Semua";
		this.btnAllCustomer.UseVisualStyleBackColor = true;
		this.btnSearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnSearchCustomer.Location = new System.Drawing.Point(127, 156);
		this.btnSearchCustomer.Name = "btnSearchCustomer";
		this.btnSearchCustomer.Size = new System.Drawing.Size(92, 23);
		this.btnSearchCustomer.TabIndex = 6;
		this.btnSearchCustomer.Text = "Pilih Customer";
		this.btnSearchCustomer.UseVisualStyleBackColor = true;
		this.lblCustomerName.AutoSize = true;
		this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblCustomerName.Location = new System.Drawing.Point(98, 184);
		this.lblCustomerName.Name = "lblCustomerName";
		this.lblCustomerName.Size = new System.Drawing.Size(63, 13);
		this.lblCustomerName.TabIndex = 205;
		this.lblCustomerName.Text = "-- SEMUA --";
		this.Label9.AutoSize = true;
		this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label9.Location = new System.Drawing.Point(10, 184);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(51, 13);
		this.Label9.TabIndex = 204;
		this.Label9.Text = "Customer";
		this.Label8.AutoSize = true;
		this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label8.Location = new System.Drawing.Point(9, 330);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(84, 13);
		this.Label8.TabIndex = 203;
		this.Label8.Text = "Pengelompokan";
		this.cboGroupBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboGroupBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboGroupBy.FormattingEnabled = true;
		this.cboGroupBy.Location = new System.Drawing.Point(101, 327);
		this.cboGroupBy.Name = "cboGroupBy";
		this.cboGroupBy.Size = new System.Drawing.Size(120, 21);
		this.cboGroupBy.TabIndex = 11;
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.Location = new System.Drawing.Point(10, 121);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(45, 13);
		this.Label6.TabIndex = 202;
		this.Label6.Text = "Gudang";
		this.cboStorage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboStorage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboStorage.FormattingEnabled = true;
		this.cboStorage.Location = new System.Drawing.Point(101, 118);
		this.cboStorage.Name = "cboStorage";
		this.cboStorage.Size = new System.Drawing.Size(120, 21);
		this.cboStorage.TabIndex = 4;
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(9, 249);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(33, 13);
		this.Label4.TabIndex = 201;
		this.Label4.Text = "Sales";
		this.cboSalesPerson.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboSalesPerson.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboSalesPerson.FormattingEnabled = true;
		this.cboSalesPerson.Location = new System.Drawing.Point(101, 246);
		this.cboSalesPerson.Name = "cboSalesPerson";
		this.cboSalesPerson.Size = new System.Drawing.Size(120, 21);
		this.cboSalesPerson.TabIndex = 8;
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(10, 94);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(44, 13);
		this.Label3.TabIndex = 200;
		this.Label3.Text = "Cabang";
		this.cboBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboBranch.FormattingEnabled = true;
		this.cboBranch.Location = new System.Drawing.Point(101, 91);
		this.cboBranch.Name = "cboBranch";
		this.cboBranch.Size = new System.Drawing.Size(120, 21);
		this.cboBranch.TabIndex = 3;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(10, 67);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(79, 13);
		this.Label5.TabIndex = 199;
		this.Label5.Text = "Tipe Pencarian";
		this.cboSearchType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboSearchType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboSearchType.FormattingEnabled = true;
		this.cboSearchType.Location = new System.Drawing.Point(101, 64);
		this.cboSearchType.Name = "cboSearchType";
		this.cboSearchType.Size = new System.Drawing.Size(120, 21);
		this.cboSearchType.TabIndex = 2;
		this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnReset.Location = new System.Drawing.Point(154, 354);
		this.btnReset.Name = "btnReset";
		this.btnReset.Size = new System.Drawing.Size(47, 24);
		this.btnReset.TabIndex = 22;
		this.btnReset.Text = "&Reset";
		this.btnReset.UseVisualStyleBackColor = true;
		this.btnWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnWord.Location = new System.Drawing.Point(820, 490);
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
		this.Label7.Location = new System.Drawing.Point(9, 222);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(45, 13);
		this.Label7.TabIndex = 196;
		this.Label7.Text = "Wilayah";
		this.cboArea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboArea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboArea.FormattingEnabled = true;
		this.cboArea.Location = new System.Drawing.Point(101, 219);
		this.cboArea.Name = "cboArea";
		this.cboArea.Size = new System.Drawing.Size(120, 21);
		this.cboArea.TabIndex = 7;
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.Location = new System.Drawing.Point(237, 12);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(735, 472);
		this.dgvList.TabIndex = 23;
		this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSearch.Location = new System.Drawing.Point(101, 354);
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
		((Shape)this.LineShape2).Name = "LineShape2";
		this.LineShape2.X1 = 14;
		this.LineShape2.X2 = 220;
		this.LineShape2.Y1 = 145;
		this.LineShape2.Y2 = 145;
		((Shape)this.LineShape1).Name = "LineShape1";
		this.LineShape1.X1 = 13;
		this.LineShape1.X2 = 219;
		this.LineShape1.Y1 = 210;
		this.LineShape1.Y2 = 210;
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).Location = new System.Drawing.Point(0, 0);
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).Margin = new System.Windows.Forms.Padding(0);
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).Name = "ShapeContainer1";
		this.ShapeContainer1.Shapes.AddRange((Shape[])(object)new Shape[2]
		{
			(Shape)this.LineShape1,
			(Shape)this.LineShape2
		});
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).Size = new System.Drawing.Size(987, 524);
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).TabIndex = 206;
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).TabStop = false;
		this.Label10.AutoSize = true;
		this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label10.Location = new System.Drawing.Point(6, 276);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(86, 13);
		this.Label10.TabIndex = 210;
		this.Label10.Text = " Kategori Barang";
		this.cboItemCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboItemCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboItemCategory.FormattingEnabled = true;
		this.cboItemCategory.Location = new System.Drawing.Point(101, 273);
		this.cboItemCategory.Name = "cboItemCategory";
		this.cboItemCategory.Size = new System.Drawing.Size(120, 21);
		this.cboItemCategory.TabIndex = 9;
		this.Label11.AutoSize = true;
		this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label11.Location = new System.Drawing.Point(9, 303);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(41, 13);
		this.Label11.TabIndex = 209;
		this.Label11.Text = "Barang";
		this.cboItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboItem.FormattingEnabled = true;
		this.cboItem.Location = new System.Drawing.Point(101, 300);
		this.cboItem.Name = "cboItem";
		this.cboItem.Size = new System.Drawing.Size(121, 21);
		this.cboItem.TabIndex = 10;
		this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnPrint.Location = new System.Drawing.Point(899, 490);
		this.btnPrint.Name = "btnPrint";
		this.btnPrint.Size = new System.Drawing.Size(73, 23);
		this.btnPrint.TabIndex = 25;
		this.btnPrint.Text = "Cetak";
		this.btnPrint.UseVisualStyleBackColor = true;
		base.AcceptButton = this.btnSearch;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(987, 524);
		base.Controls.Add(this.btnPrint);
		base.Controls.Add(this.Label10);
		base.Controls.Add(this.cboItemCategory);
		base.Controls.Add(this.Label11);
		base.Controls.Add(this.cboItem);
		base.Controls.Add(this.btnAllCustomer);
		base.Controls.Add(this.btnSearchCustomer);
		base.Controls.Add(this.lblCustomerName);
		base.Controls.Add(this.Label9);
		base.Controls.Add(this.Label8);
		base.Controls.Add(this.cboGroupBy);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.cboStorage);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.cboSalesPerson);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.cboBranch);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.cboSearchType);
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
		base.Controls.Add((System.Windows.Forms.Control)(object)this.ShapeContainer1);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmReportSalesReturnItem";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Report Retur Penjualan per Barang";
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmReportSalesReturnItem()
	{
		base.KeyDown += frmReportSalesReturnItem_KeyDown;
		base.Load += frmReportSalesReturnItem_Load;
		InitializeComponent();
		DoubleBuffered = true;
		base.MdiParent = MyProject.Forms.frmMenu;
		ComboBox combo = cboBranch;
		cCombo.getBranch(ref combo, Module1.pubGroupId, blnAll: true);
		cboBranch = combo;
		cboBranch.SelectedIndex = 0;
		cboGroupBy.Items.Clear();
		cboGroupBy.Items.Add(new cComboItem("-", Conversions.ToString(0)));
		cboGroupBy.Items.Add(new cComboItem("Barang", Conversions.ToString(2)));
		cboGroupBy.Items.Add(new cComboItem("Sales", Conversions.ToString(3)));
		cboGroupBy.Items.Add(new cComboItem("Wilayah", Conversions.ToString(4)));
		cboGroupBy.SelectedIndex = 0;
		combo = cboSearchType;
		cCombo.getSearchType(ref combo);
		cboSearchType = combo;
		combo = cboItemCategory;
		cCombo.getItemCategory(ref combo, Module1.pubGroupId, All: true, Active: true);
		cboItemCategory = combo;
	}

	private void frmReportSalesReturnItem_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void frmReportSalesReturnItem_Load(object sender, EventArgs e)
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
		cboSearchType.SelectedIndex = 0;
		cboBranch.SelectedIndex = 0;
		cboStorage.SelectedIndex = 0;
		lblCustomerName.Text = "--SEMUA--";
		_customerId = 0.0;
		cboArea.SelectedIndex = 0;
		cboSalesPerson.SelectedIndex = 0;
		cboItemCategory.SelectedIndex = 0;
		cboItem.SelectedIndex = 0;
		cboGroupBy.SelectedIndex = 0;
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
			combo = cboArea;
			cCombo.getArea(ref combo, Conversions.ToInteger(cComboItem2.Value), Module1.pubGroupId, All: true, Active: true);
			cboArea = combo;
			cboStorage.Text = "";
			cboArea.Text = "";
			cboSalesPerson.Text = "";
			cboStorage.SelectedIndex = 0;
			cboArea.SelectedIndex = 0;
			cboSalesPerson.SelectedIndex = 0;
			_customerId = 0.0;
			lblCustomerName.Text = "--SEMUA--";
		}
	}

	private void btnAllCustomer_Click(object sender, EventArgs e)
	{
		_customerId = 0.0;
		lblCustomerName.Text = "--SEMUA--";
	}

	private void btnSearchCustomer_Click(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboBranch.SelectedItem;
		frmCustomerMiniSearch frmCustomerMiniSearch2 = new frmCustomerMiniSearch();
		frmCustomerMiniSearch2.BranchId = Conversions.ToInteger(cComboItem2.Value);
		frmCustomerMiniSearch2.CallerName = "ReportSalesReturnItem";
		frmCustomerMiniSearch2.ShowDialog();
		frmCustomerMiniSearch2.Close();
		frmCustomerMiniSearch2.Dispose();
	}

	private void cboItemCategory_SelectedIndexChanged(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboItemCategory.SelectedItem;
		ComboBox combo = cboItem;
		cCombo.getItemAll(ref combo, 99, 99, 0, 0, 0, 0, 1, 0, Conversions.ToInteger(cComboItem2.Value), 0, 0, 0, 0.0, CanBeUsedAsGroupMember: false, Module1.pubGroupId, All: true, Active: true);
		cboItem = combo;
		cboItem.SelectedIndex = 0;
	}

	private void btnSearch_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		double num3 = default(double);
		int num4 = default(int);
		double num5 = default(double);
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
						cComboItem cComboItem2 = (cComboItem)cboSearchType.SelectedItem;
						cComboItem cComboItem3 = (cComboItem)cboBranch.SelectedItem;
						cComboItem cComboItem4 = (cComboItem)cboStorage.SelectedItem;
						cComboItem cComboItem5 = (cComboItem)cboArea.SelectedItem;
						cComboItem cComboItem6 = (cComboItem)cboSalesPerson.SelectedItem;
						cComboItem cComboItem7 = (cComboItem)cboItemCategory.SelectedItem;
						cComboItem cComboItem8 = (cComboItem)cboItem.SelectedItem;
						if (cboSearchType.SelectedIndex == -1)
						{
							Interaction.MsgBox("Tipe Pencarian yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
							cboSearchType.Focus();
							goto end_IL_0001;
						}
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
						if (cboArea.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih wilayah", MsgBoxStyle.Information);
							cboArea.Focus();
							goto end_IL_0001;
						}
						if (cboSalesPerson.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih sales", MsgBoxStyle.Information);
							cboSalesPerson.Focus();
							goto end_IL_0001;
						}
						if (cboItemCategory.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih kategory barang.", MsgBoxStyle.Information);
							cboItemCategory.Focus();
							goto end_IL_0001;
						}
						if (cboItem.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih barang.", MsgBoxStyle.Information);
							cboItem.Focus();
							goto end_IL_0001;
						}
						if (cboGroupBy.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih pengelompokan", MsgBoxStyle.Information);
							cboGroupBy.Focus();
							goto end_IL_0001;
						}
						if ((cboSearchType.SelectedIndex == 1) & (cboGroupBy.SelectedIndex < 1))
						{
							Interaction.MsgBox("Pilih pengelompokan", MsgBoxStyle.Information);
							cboGroupBy.Focus();
							goto end_IL_0001;
						}
						DataTable dataTable = new DataTable();
						Cursor = Cursors.WaitCursor;
						btnSearch.Focus();
						dataTable = cSalesInvoice.SearchItem(dtpBegin.Value, dtpEnd.Value, _customerId, Conversions.ToInteger(cComboItem5.Value), Conversions.ToInteger(cComboItem6.Value), 99, Conversions.ToInteger(cComboItem7.Value), Conversions.ToInteger(cComboItem8.Value), Conversions.ToInteger(cComboItem4.Value), Conversions.ToInteger(cComboItem3.Value), 1, Conversions.ToInteger(cComboItem2.Value), cboGroupBy.Text, IncludeDO: true, Module1.pubGroupId);
						dgvList.Rows.Clear();
						formatGrid();
						string left = "";
						bool flag = true;
						IEnumerator enumerator = dataTable.Rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataRow["orderBy"], 2, TextCompare: false), flag)))
							{
								flag = false;
								dgvList.Rows.Add("");
								dgvList.Rows.Add("", "", "", "", "", "", "Total per Barang:");
							}
							if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataRow["orderBy"], 0, TextCompare: false), Operators.OrObject(Operators.CompareObjectNotEqual(num3, dataRow["penjId"], TextCompare: false), Operators.CompareString(cboGroupBy.Text, "-", TextCompare: false) != 0))))
							{
								dgvList.Rows.Add(dataRow["penjId"], dataRow["penjDate"], dataRow["penjFaktur"], dataRow["wilName"], dataRow["salesName"], dataRow["custName"], dataRow["itemName"], Module1.formatCustomDecimal(Conversions.ToString(dataRow["qty"]), 3));
								num4++;
							}
							else if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataRow["orderBy"], 1, TextCompare: false), Operators.CompareObjectNotEqual(left, dataRow["custName"], TextCompare: false))))
							{
								dgvList.Rows.Add(dataRow["penjId"], dataRow["penjDate"], dataRow["penjFaktur"], dataRow["wilName"], dataRow["salesName"], dataRow["custName"], dataRow["itemName"], Module1.formatCustomDecimal(Conversions.ToString(dataRow["qty"]), 3));
								num4++;
							}
							else if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(dataRow["orderBy"], 0, TextCompare: false), Operators.CompareObjectEqual(dataRow["orderBy"], 1, TextCompare: false))))
							{
								dgvList.Rows.Add(dataRow["penjId"], "", "", "", "", "", dataRow["itemName"], Module1.formatCustomDecimal(Conversions.ToString(dataRow["qty"]), 3));
								num4++;
							}
							else
							{
								dgvList.Rows.Add(0, "", "", "", "", "", dataRow["itemName"], Module1.formatCustomDecimal(Conversions.ToString(dataRow["qty"]), 3));
							}
							num3 = Conversions.ToDouble(dataRow["penjId"]);
							left = Conversions.ToString(dataRow["custName"]);
							num5 = Conversions.ToDouble(Operators.AddObject(num5, dataRow["qty"]));
						}
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
						if (Operators.CompareString(cboGroupBy.Text, "Customer", TextCompare: false) == 0)
						{
							dgvList.Columns[2].Visible = false;
							dgvList.Columns[3].Visible = false;
							dgvList.Columns[4].Visible = false;
						}
						else if (Operators.CompareString(cboGroupBy.Text, "Barang", TextCompare: false) == 0)
						{
							dgvList.Columns[2].Visible = false;
							dgvList.Columns[3].Visible = false;
							dgvList.Columns[4].Visible = false;
							dgvList.Columns[5].Visible = false;
						}
						else if (Operators.CompareString(cboGroupBy.Text, "Sales", TextCompare: false) == 0)
						{
							dgvList.Columns[2].Visible = false;
							dgvList.Columns[3].Visible = false;
							dgvList.Columns[5].Visible = false;
						}
						else if (Operators.CompareString(cboGroupBy.Text, "Wilayah", TextCompare: false) == 0)
						{
							dgvList.Columns[2].Visible = false;
							dgvList.Columns[4].Visible = false;
							dgvList.Columns[5].Visible = false;
						}
						if (Conversions.ToDouble(cComboItem2.Value) == 2.0)
						{
							dgvList.Columns[1].Visible = false;
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
						lblTotal.Text = "Total Pencarian: " + Conversions.ToString(num4);
						Cursor = Cursors.Default;
						goto end_IL_0001;
					}
					case 2653:
						num = -1;
						switch (num2)
						{
						case 2:
							Cursor = Cursors.Default;
							Module1.SaveError(Information.Err(), "frmReportSalesItem", "btnSearch_click", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 2653;
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
		dgvList.Columns.Add("", "Wilayah");
		dgvList.Columns.Add("", "Sales");
		dgvList.Columns.Add("", "Customer");
		dgvList.Columns.Add("", "Barang");
		dgvList.Columns.Add("", "Jumlah");
		dgvList.Columns[0].Visible = false;
		dgvList.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvList.Columns[1].Width = 65;
		dgvList.Columns[2].Width = 100;
		dgvList.Columns[3].Width = 100;
		dgvList.Columns[4].Width = 140;
		dgvList.Columns[5].Width = 120;
		dgvList.Columns[6].Width = 100;
		dgvList.Columns[7].Width = 80;
		dgvList.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
			MyProject.Forms.frmSalesReturn.Show();
			MyProject.Forms.frmSalesReturn.prepareForm(SaveNew: false);
			MyProject.Forms.frmSalesReturn.CurrentId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
			MyProject.Forms.frmSalesReturn.LoadData();
			MyProject.Forms.frmSalesReturn.Activate();
			MyProject.Forms.frmSalesReturn.WindowState = FormWindowState.Normal;
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
		if (cboSearchType.SelectedIndex == 0)
		{
			if (cboGroupBy.SelectedIndex == 0)
			{
				msWord.rptWordNew(dgvList.Rows.Count, dgvList.Columns.Count, "LLLLR", blnPortrait: false, "", Print);
			}
			else if (cboGroupBy.SelectedIndex == 1)
			{
				msWord.rptWordNew(dgvList.Rows.Count, dgvList.Columns.Count, "LLR", blnPortrait: false, "", Print);
			}
			else
			{
				msWord.rptWordNew(dgvList.Rows.Count, dgvList.Columns.Count, "LLLR", blnPortrait: false, "", Print);
			}
		}
		else if (cboGroupBy.SelectedIndex == 1)
		{
			msWord.rptWordNew(dgvList.Rows.Count, dgvList.Columns.Count, "LR", blnPortrait: false, "", Print);
		}
		else
		{
			msWord.rptWordNew(dgvList.Rows.Count, dgvList.Columns.Count, "LLR", blnPortrait: false, "", Print);
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
}
