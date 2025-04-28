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
using Microsoft.VisualBasic.PowerPacks;

namespace GCUv2;

[DesignerGenerated]
public class frmReportReceivable : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboBaseFilter")]
	private ComboBox _cboBaseFilter;

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
	[AccessedThroughProperty("cboBranch")]
	private ComboBox _cboBranch;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("chkAllArea")]
	private CheckBox _chkAllArea;

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
	[AccessedThroughProperty("btnPrint")]
	private Button _btnPrint;

	private double _customerId;

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox cboBaseFilter
	{
		[CompilerGenerated]
		get
		{
			return _cboBaseFilter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cboBaseFilter_SelectedIndexChanged;
			ComboBox comboBox = _cboBaseFilter;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_cboBaseFilter = value;
			comboBox = _cboBaseFilter;
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

	[field: AccessedThroughProperty("lblDate")]
	internal virtual Label lblDate
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
			DataGridViewCellFormattingEventHandler value2 = dgvList_CellFormatting;
			DataGridViewSortCompareEventHandler value3 = dgvList_SortCompare;
			EventHandler value4 = dgvList_DoubleClick;
			KeyEventHandler value5 = dgvList_KeyDown;
			EventHandler value6 = dgvList_GotFocus;
			EventHandler value7 = dgvList_LostFocus;
			DataGridView dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.CellFormatting -= value2;
				dataGridView.SortCompare -= value3;
				dataGridView.DoubleClick -= value4;
				dataGridView.KeyDown -= value5;
				dataGridView.GotFocus -= value6;
				dataGridView.LostFocus -= value7;
			}
			_dgvList = value;
			dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.CellFormatting += value2;
				dataGridView.SortCompare += value3;
				dataGridView.DoubleClick += value4;
				dataGridView.KeyDown += value5;
				dataGridView.GotFocus += value6;
				dataGridView.LostFocus += value7;
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

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
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

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
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

	[field: AccessedThroughProperty("clbArea")]
	internal virtual CheckedListBox clbArea
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

	internal virtual CheckBox chkAllArea
	{
		[CompilerGenerated]
		get
		{
			return _chkAllArea;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = chkAllArea_CheckedChanged;
			CheckBox checkBox = _chkAllArea;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value2;
			}
			_chkAllArea = value;
			checkBox = _chkAllArea;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("LineShape1")]
	internal virtual LineShape LineShape1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LineShape2")]
	internal virtual LineShape LineShape2
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

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label12")]
	internal virtual Label Label12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboCustomerCode")]
	internal virtual ComboBox cboCustomerCode
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
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		this.Label3 = new System.Windows.Forms.Label();
		this.cboBaseFilter = new System.Windows.Forms.ComboBox();
		this.btnReset = new System.Windows.Forms.Button();
		this.btnWord = new System.Windows.Forms.Button();
		this.lblDate = new System.Windows.Forms.Label();
		this.lblTotal = new System.Windows.Forms.Label();
		this.dgvList = new System.Windows.Forms.DataGridView();
		this.btnSearch = new System.Windows.Forms.Button();
		this.Label2 = new System.Windows.Forms.Label();
		this.dtpEnd = new System.Windows.Forms.DateTimePicker();
		this.dtpBegin = new System.Windows.Forms.DateTimePicker();
		this.Label9 = new System.Windows.Forms.Label();
		this.cboStorage = new System.Windows.Forms.ComboBox();
		this.Label10 = new System.Windows.Forms.Label();
		this.cboBranch = new System.Windows.Forms.ComboBox();
		this.clbArea = new System.Windows.Forms.CheckedListBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.chkAllArea = new System.Windows.Forms.CheckBox();
		this.LineShape1 = new LineShape();
		this.LineShape2 = new LineShape();
		this.ShapeContainer1 = new ShapeContainer();
		this.btnAllCustomer = new System.Windows.Forms.Button();
		this.btnSearchCustomer = new System.Windows.Forms.Button();
		this.lblCustomerName = new System.Windows.Forms.Label();
		this.Label11 = new System.Windows.Forms.Label();
		this.Label12 = new System.Windows.Forms.Label();
		this.cboCustomerCode = new System.Windows.Forms.ComboBox();
		this.Label13 = new System.Windows.Forms.Label();
		this.cboSalesPerson = new System.Windows.Forms.ComboBox();
		this.btnPrint = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		base.SuspendLayout();
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(10, 15);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(86, 13);
		this.Label3.TabIndex = 91;
		this.Label3.Text = "Dasar Pencarian";
		this.cboBaseFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboBaseFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboBaseFilter.FormattingEnabled = true;
		this.cboBaseFilter.Location = new System.Drawing.Point(100, 12);
		this.cboBaseFilter.Name = "cboBaseFilter";
		this.cboBaseFilter.Size = new System.Drawing.Size(121, 21);
		this.cboBaseFilter.TabIndex = 0;
		this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnReset.Location = new System.Drawing.Point(153, 431);
		this.btnReset.Name = "btnReset";
		this.btnReset.Size = new System.Drawing.Size(47, 24);
		this.btnReset.TabIndex = 22;
		this.btnReset.Text = "&Reset";
		this.btnReset.UseVisualStyleBackColor = true;
		this.btnWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnWord.Location = new System.Drawing.Point(699, 451);
		this.btnWord.Name = "btnWord";
		this.btnWord.Size = new System.Drawing.Size(73, 23);
		this.btnWord.TabIndex = 24;
		this.btnWord.Text = "&Word";
		this.btnWord.UseVisualStyleBackColor = true;
		this.lblDate.AutoSize = true;
		this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblDate.Location = new System.Drawing.Point(10, 42);
		this.lblDate.Name = "lblDate";
		this.lblDate.Size = new System.Drawing.Size(71, 13);
		this.lblDate.TabIndex = 90;
		this.lblDate.Text = "Tanggal awal";
		this.lblTotal.AutoSize = true;
		this.lblTotal.Location = new System.Drawing.Point(267, 456);
		this.lblTotal.Name = "lblTotal";
		this.lblTotal.Size = new System.Drawing.Size(91, 13);
		this.lblTotal.TabIndex = 89;
		this.lblTotal.Text = "Total Pencarian: -";
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.Location = new System.Drawing.Point(270, 12);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(581, 433);
		this.dgvList.TabIndex = 23;
		this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSearch.Location = new System.Drawing.Point(100, 431);
		this.btnSearch.Name = "btnSearch";
		this.btnSearch.Size = new System.Drawing.Size(47, 24);
		this.btnSearch.TabIndex = 21;
		this.btnSearch.Text = "&Cari";
		this.btnSearch.UseVisualStyleBackColor = true;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(10, 68);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(72, 13);
		this.Label2.TabIndex = 87;
		this.Label2.Text = "Tanggal akhir";
		this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpEnd.Location = new System.Drawing.Point(100, 65);
		this.dtpEnd.Name = "dtpEnd";
		this.dtpEnd.Size = new System.Drawing.Size(121, 20);
		this.dtpEnd.TabIndex = 2;
		this.dtpBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpBegin.Location = new System.Drawing.Point(100, 39);
		this.dtpBegin.Name = "dtpBegin";
		this.dtpBegin.Size = new System.Drawing.Size(121, 20);
		this.dtpBegin.TabIndex = 1;
		this.Label9.AutoSize = true;
		this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label9.Location = new System.Drawing.Point(10, 121);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(45, 13);
		this.Label9.TabIndex = 183;
		this.Label9.Text = "Gudang";
		this.cboStorage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboStorage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboStorage.FormattingEnabled = true;
		this.cboStorage.Location = new System.Drawing.Point(100, 118);
		this.cboStorage.Name = "cboStorage";
		this.cboStorage.Size = new System.Drawing.Size(120, 21);
		this.cboStorage.TabIndex = 4;
		this.Label10.AutoSize = true;
		this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label10.Location = new System.Drawing.Point(10, 94);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(44, 13);
		this.Label10.TabIndex = 182;
		this.Label10.Text = "Cabang";
		this.cboBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboBranch.FormattingEnabled = true;
		this.cboBranch.Location = new System.Drawing.Point(100, 91);
		this.cboBranch.Name = "cboBranch";
		this.cboBranch.Size = new System.Drawing.Size(120, 21);
		this.cboBranch.TabIndex = 3;
		this.clbArea.CheckOnClick = true;
		this.clbArea.FormattingEnabled = true;
		this.clbArea.Location = new System.Drawing.Point(100, 286);
		this.clbArea.Name = "clbArea";
		this.clbArea.Size = new System.Drawing.Size(153, 139);
		this.clbArea.TabIndex = 10;
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(10, 265);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(45, 13);
		this.Label4.TabIndex = 185;
		this.Label4.Text = "Wilayah";
		this.chkAllArea.AutoSize = true;
		this.chkAllArea.Location = new System.Drawing.Point(103, 265);
		this.chkAllArea.Name = "chkAllArea";
		this.chkAllArea.Size = new System.Drawing.Size(76, 17);
		this.chkAllArea.TabIndex = 9;
		this.chkAllArea.Text = "--SEMUA--";
		this.chkAllArea.UseVisualStyleBackColor = true;
		((Shape)this.LineShape1).Name = "LineShape1";
		this.LineShape1.X1 = 14;
		this.LineShape1.X2 = 220;
		this.LineShape1.Y1 = 199;
		this.LineShape1.Y2 = 199;
		((Shape)this.LineShape2).Name = "LineShape2";
		this.LineShape2.X1 = 14;
		this.LineShape2.X2 = 220;
		this.LineShape2.Y1 = 147;
		this.LineShape2.Y2 = 147;
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).Location = new System.Drawing.Point(0, 0);
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).Margin = new System.Windows.Forms.Padding(0);
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).Name = "ShapeContainer1";
		this.ShapeContainer1.Shapes.AddRange((Shape[])(object)new Shape[2]
		{
			(Shape)this.LineShape2,
			(Shape)this.LineShape1
		});
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).Size = new System.Drawing.Size(863, 486);
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).TabIndex = 187;
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).TabStop = false;
		this.btnAllCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAllCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAllCustomer.Location = new System.Drawing.Point(72, 153);
		this.btnAllCustomer.Name = "btnAllCustomer";
		this.btnAllCustomer.Size = new System.Drawing.Size(50, 23);
		this.btnAllCustomer.TabIndex = 5;
		this.btnAllCustomer.Text = "Semua";
		this.btnAllCustomer.UseVisualStyleBackColor = true;
		this.btnSearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnSearchCustomer.Location = new System.Drawing.Point(128, 153);
		this.btnSearchCustomer.Name = "btnSearchCustomer";
		this.btnSearchCustomer.Size = new System.Drawing.Size(92, 23);
		this.btnSearchCustomer.TabIndex = 6;
		this.btnSearchCustomer.Text = "Pilih Customer";
		this.btnSearchCustomer.UseVisualStyleBackColor = true;
		this.lblCustomerName.AutoSize = true;
		this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblCustomerName.Location = new System.Drawing.Point(69, 181);
		this.lblCustomerName.Name = "lblCustomerName";
		this.lblCustomerName.Size = new System.Drawing.Size(63, 13);
		this.lblCustomerName.TabIndex = 191;
		this.lblCustomerName.Text = "-- SEMUA --";
		this.Label11.AutoSize = true;
		this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label11.Location = new System.Drawing.Point(11, 181);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(51, 13);
		this.Label11.TabIndex = 190;
		this.Label11.Text = "Customer";
		this.Label12.AutoSize = true;
		this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label12.Location = new System.Drawing.Point(10, 212);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(79, 13);
		this.Label12.TabIndex = 193;
		this.Label12.Text = "Kode Customer";
		this.cboCustomerCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboCustomerCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboCustomerCode.FormattingEnabled = true;
		this.cboCustomerCode.Location = new System.Drawing.Point(100, 209);
		this.cboCustomerCode.Name = "cboCustomerCode";
		this.cboCustomerCode.Size = new System.Drawing.Size(120, 21);
		this.cboCustomerCode.TabIndex = 7;
		this.Label13.AutoSize = true;
		this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label13.Location = new System.Drawing.Point(10, 239);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(33, 13);
		this.Label13.TabIndex = 197;
		this.Label13.Text = "Sales";
		this.cboSalesPerson.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboSalesPerson.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboSalesPerson.FormattingEnabled = true;
		this.cboSalesPerson.Location = new System.Drawing.Point(100, 236);
		this.cboSalesPerson.Name = "cboSalesPerson";
		this.cboSalesPerson.Size = new System.Drawing.Size(120, 21);
		this.cboSalesPerson.TabIndex = 8;
		this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnPrint.Location = new System.Drawing.Point(778, 451);
		this.btnPrint.Name = "btnPrint";
		this.btnPrint.Size = new System.Drawing.Size(73, 23);
		this.btnPrint.TabIndex = 25;
		this.btnPrint.Text = "Cetak";
		this.btnPrint.UseVisualStyleBackColor = true;
		base.AcceptButton = this.btnSearch;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(863, 486);
		base.Controls.Add(this.btnPrint);
		base.Controls.Add(this.Label13);
		base.Controls.Add(this.cboSalesPerson);
		base.Controls.Add(this.Label12);
		base.Controls.Add(this.cboCustomerCode);
		base.Controls.Add(this.btnAllCustomer);
		base.Controls.Add(this.btnSearchCustomer);
		base.Controls.Add(this.lblCustomerName);
		base.Controls.Add(this.Label11);
		base.Controls.Add(this.chkAllArea);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.clbArea);
		base.Controls.Add(this.Label9);
		base.Controls.Add(this.cboStorage);
		base.Controls.Add(this.Label10);
		base.Controls.Add(this.cboBranch);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.cboBaseFilter);
		base.Controls.Add(this.btnReset);
		base.Controls.Add(this.btnWord);
		base.Controls.Add(this.lblDate);
		base.Controls.Add(this.lblTotal);
		base.Controls.Add(this.dgvList);
		base.Controls.Add(this.btnSearch);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.dtpEnd);
		base.Controls.Add(this.dtpBegin);
		base.Controls.Add((System.Windows.Forms.Control)(object)this.ShapeContainer1);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmReportReceivable";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Report Piutang";
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmReportReceivable()
	{
		base.KeyDown += frmReportPurchaseInvoice_KeyDown;
		base.Load += frmReportPurchaseInvoice_Load;
		InitializeComponent();
		DoubleBuffered = true;
		base.MdiParent = MyProject.Forms.frmMenu;
		ComboBox combo = cboBaseFilter;
		cCombo.getReportReceivableFilter(ref combo);
		cboBaseFilter = combo;
		combo = cboCustomerCode;
		cCombo.getCustomerCode(ref combo, All: true, 1);
		cboCustomerCode = combo;
		combo = cboBranch;
		cCombo.getBranch(ref combo, Module1.pubGroupId, blnAll: true);
		cboBranch = combo;
		formatGrid();
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
		prepareForm();
		ExtensionMethods.DoubleBuffered(dgvList, setting: true);
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
			CheckedListBox ListBox = clbArea;
			cCombo.getAreaList(ref ListBox, Conversions.ToInteger(cComboItem2.Value), Module1.pubGroupId, Active: true);
			clbArea = ListBox;
			cboStorage.Text = "";
			cboSalesPerson.Text = "";
			cboStorage.SelectedIndex = 0;
			cboSalesPerson.SelectedIndex = 0;
			chkAllArea_CheckedChanged(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}

	private void prepareForm()
	{
		btnWord.Enabled = false;
		btnPrint.Enabled = false;
		_customerId = 0.0;
		dtpBegin.Value = Conversions.ToDate("01/01/2000");
		dtpEnd.Value = DateAndTime.Now;
		cboBaseFilter.SelectedIndex = 0;
		cboBranch.SelectedIndex = 0;
		cboStorage.SelectedIndex = 0;
		_customerId = 0.0;
		lblCustomerName.Text = "--SEMUA--";
		cboCustomerCode.SelectedIndex = 0;
		cboSalesPerson.SelectedIndex = 0;
		chkAllArea.Checked = false;
		chkAllArea.Checked = true;
		lblTotal.Text = "Total Pencarian: -";
		dgvList.Rows.Clear();
		dtpBegin.Focus();
	}

	private void cboBaseFilter_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (cboBaseFilter.SelectedIndex == 0)
		{
			dtpEnd.Enabled = true;
			lblDate.Text = "Tanggal awal";
			dtpBegin.Value = Conversions.ToDate("01/01/2000");
		}
		else
		{
			dtpEnd.Enabled = false;
			lblDate.Text = "Tanggal piutang";
			dtpBegin.Value = Module1.getFirstDateInMonth(DateAndTime.Now);
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
		frmCustomerMiniSearch2.CallerName = "ReportReceivable";
		frmCustomerMiniSearch2.ShowDialog();
		frmCustomerMiniSearch2.Close();
		frmCustomerMiniSearch2.Dispose();
	}

	private void btnSearch_Click(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboBaseFilter.SelectedItem;
		cComboItem cComboItem3 = (cComboItem)cboBranch.SelectedItem;
		cComboItem cComboItem4 = (cComboItem)cboStorage.SelectedItem;
		cComboItem cComboItem5 = (cComboItem)cboSalesPerson.SelectedItem;
		cComboItem cComboItem6 = (cComboItem)cboCustomerCode.SelectedItem;
		if (cboBaseFilter.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih dasar pencarian", MsgBoxStyle.Information);
			cboBaseFilter.Focus();
			return;
		}
		if (cboBranch.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih cabang", MsgBoxStyle.Information);
			cboBranch.Focus();
			return;
		}
		if (cboStorage.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih gudang", MsgBoxStyle.Information);
			cboStorage.Focus();
			return;
		}
		if (clbArea.CheckedItems.Count == 0)
		{
			Interaction.MsgBox("Pilih wilayah", MsgBoxStyle.Information);
			clbArea.Focus();
			return;
		}
		if (cboSalesPerson.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih sales", MsgBoxStyle.Information);
			cboSalesPerson.Focus();
			return;
		}
		if (cboCustomerCode.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih kode customer", MsgBoxStyle.Information);
			cboCustomerCode.Focus();
			return;
		}
		checked
		{
			int[] array = new int[clbArea.CheckedItems.Count - 1 + 1];
			int num = clbArea.CheckedItems.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				cComboItem cComboItem7 = (cComboItem)clbArea.CheckedItems[i];
				array[i] = Conversions.ToInteger(cComboItem7.Value);
			}
			DataTable dataTable = new DataTable();
			btnSearch.Focus();
			Cursor = Cursors.WaitCursor;
			dataTable = cSalesInvoice.SearchReceivable(Conversions.ToInteger(cComboItem2.Value), dtpBegin.Value, dtpEnd.Value, _customerId, array, Conversions.ToInteger(cComboItem5.Value), Conversions.ToInteger(cComboItem6.Value), Conversions.ToInteger(cComboItem4.Value), 0, Conversions.ToInteger(cComboItem3.Value), Module1.pubGroupId);
			dgvList.Rows.Clear();
			double num2 = default(double);
			foreach (DataRow row in dataTable.Rows)
			{
				if (Operators.ConditionalCompareObjectGreater(row["penjReceivable"], 0, TextCompare: false))
				{
					dgvList.Rows.Add(row["penjId"], row["penjDate"], row["penjFaktur"], row["custName"], row["penjReceivable"], row["penjReceivableDays"]);
					num2 = Conversions.ToDouble(Operators.AddObject(num2, row["penjReceivable"]));
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
				dgvList.Rows.Add("", "Total", "", "", Module1.formatCustomDecimal(Conversions.ToString(num2), 2), "");
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
		}
	}

	private void formatGrid()
	{
		dgvList.Columns.Add("", "penjId");
		dgvList.Columns.Add("", "Tanggal");
		dgvList.Columns.Add("", "No Faktur");
		dgvList.Columns.Add("", "Customer");
		dgvList.Columns.Add("", "Piutang");
		dgvList.Columns.Add("", "Umur Piutang");
		dgvList.Columns.Add("", "Bayar Cash");
		dgvList.Columns.Add("", "Bayar Bank");
		dgvList.Columns.Add("", "Potongan / Retur");
		dgvList.Columns[0].Visible = false;
		dgvList.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvList.Columns[1].Width = 65;
		dgvList.Columns[2].Width = 110;
		dgvList.Columns[3].Width = 220;
		dgvList.Columns[4].Width = 90;
		dgvList.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[5].Width = 58;
		dgvList.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[6].Width = 0;
		dgvList.Columns[7].Width = 0;
		dgvList.Columns[8].Width = 0;
		dgvList.RowHeadersVisible = false;
		dgvList.AllowUserToAddRows = false;
		dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvList.ReadOnly = true;
		dgvList.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvList.AllowUserToResizeRows = false;
		dgvList.DefaultCellStyle.Font = new Font("Segoe UI", 8f, FontStyle.Regular);
		dgvList.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8f, FontStyle.Regular);
	}

	private void dgvList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
		if (e.ColumnIndex == 4)
		{
			e.Value = Module1.formatCustomDecimal(Conversions.ToString(e.Value), 2);
		}
	}

	private void dgvList_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
	{
		checked
		{
			if (e.RowIndex1 == dgvList.Rows.Count - 1)
			{
				e.Handled = true;
			}
			if (e.RowIndex2 == dgvList.Rows.Count - 1)
			{
				e.Handled = true;
			}
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
		msWord.rptWordNew(dgvList.Rows.Count, dgvList.Columns.Count, "LLLRR", blnPortrait: true, "", Print);
	}

	private void btnReset_Click(object sender, EventArgs e)
	{
		prepareForm();
	}

	private void chkAllArea_CheckedChanged(object sender, EventArgs e)
	{
		checked
		{
			int num = clbArea.Items.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (!chkAllArea.Checked)
				{
					clbArea.SetItemChecked(i, value: false);
				}
				else
				{
					clbArea.SetItemChecked(i, value: true);
				}
			}
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
