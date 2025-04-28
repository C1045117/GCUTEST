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
public class frmReportSalesReturn : Form
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
	[AccessedThroughProperty("btnPrint")]
	private Button _btnPrint;

	private double _customerId;

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

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboStatus")]
	internal virtual ComboBox cboStatus
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

	[field: AccessedThroughProperty("cboNPWP")]
	internal virtual ComboBox cboNPWP
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtInvoiceNo")]
	internal virtual TextBox txtInvoiceNo
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
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		this.Label13 = new System.Windows.Forms.Label();
		this.cboSalesPerson = new System.Windows.Forms.ComboBox();
		this.Label12 = new System.Windows.Forms.Label();
		this.cboCustomerCode = new System.Windows.Forms.ComboBox();
		this.btnAllCustomer = new System.Windows.Forms.Button();
		this.btnSearchCustomer = new System.Windows.Forms.Button();
		this.lblCustomerName = new System.Windows.Forms.Label();
		this.Label11 = new System.Windows.Forms.Label();
		this.Label9 = new System.Windows.Forms.Label();
		this.cboStorage = new System.Windows.Forms.ComboBox();
		this.Label10 = new System.Windows.Forms.Label();
		this.cboBranch = new System.Windows.Forms.ComboBox();
		this.Label8 = new System.Windows.Forms.Label();
		this.cboInvoiceCode = new System.Windows.Forms.ComboBox();
		this.Label6 = new System.Windows.Forms.Label();
		this.cboStatus = new System.Windows.Forms.ComboBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.cboNPWP = new System.Windows.Forms.ComboBox();
		this.txtInvoiceNo = new System.Windows.Forms.TextBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.cboBaseFilter = new System.Windows.Forms.ComboBox();
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
		this.btnPrint = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		base.SuspendLayout();
		this.Label13.AutoSize = true;
		this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label13.Location = new System.Drawing.Point(491, 15);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(33, 13);
		this.Label13.TabIndex = 221;
		this.Label13.Text = "Sales";
		this.cboSalesPerson.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboSalesPerson.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboSalesPerson.FormattingEnabled = true;
		this.cboSalesPerson.Location = new System.Drawing.Point(577, 12);
		this.cboSalesPerson.Name = "cboSalesPerson";
		this.cboSalesPerson.Size = new System.Drawing.Size(114, 21);
		this.cboSalesPerson.TabIndex = 8;
		this.Label12.AutoSize = true;
		this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label12.Location = new System.Drawing.Point(241, 124);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(79, 13);
		this.Label12.TabIndex = 220;
		this.Label12.Text = "Kode Customer";
		this.cboCustomerCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboCustomerCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboCustomerCode.FormattingEnabled = true;
		this.cboCustomerCode.Location = new System.Drawing.Point(331, 121);
		this.cboCustomerCode.Name = "cboCustomerCode";
		this.cboCustomerCode.Size = new System.Drawing.Size(114, 21);
		this.cboCustomerCode.TabIndex = 7;
		this.btnAllCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAllCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAllCustomer.Location = new System.Drawing.Point(303, 69);
		this.btnAllCustomer.Name = "btnAllCustomer";
		this.btnAllCustomer.Size = new System.Drawing.Size(50, 23);
		this.btnAllCustomer.TabIndex = 5;
		this.btnAllCustomer.Text = "Semua";
		this.btnAllCustomer.UseVisualStyleBackColor = true;
		this.btnSearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnSearchCustomer.Location = new System.Drawing.Point(359, 69);
		this.btnSearchCustomer.Name = "btnSearchCustomer";
		this.btnSearchCustomer.Size = new System.Drawing.Size(92, 23);
		this.btnSearchCustomer.TabIndex = 6;
		this.btnSearchCustomer.Text = "Pilih Customer";
		this.btnSearchCustomer.UseVisualStyleBackColor = true;
		this.lblCustomerName.AutoSize = true;
		this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblCustomerName.Location = new System.Drawing.Point(330, 97);
		this.lblCustomerName.Name = "lblCustomerName";
		this.lblCustomerName.Size = new System.Drawing.Size(63, 13);
		this.lblCustomerName.TabIndex = 219;
		this.lblCustomerName.Text = "-- SEMUA --";
		this.Label11.AutoSize = true;
		this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label11.Location = new System.Drawing.Point(242, 97);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(51, 13);
		this.Label11.TabIndex = 218;
		this.Label11.Text = "Customer";
		this.Label9.AutoSize = true;
		this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label9.Location = new System.Drawing.Point(240, 42);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(45, 13);
		this.Label9.TabIndex = 217;
		this.Label9.Text = "Gudang";
		this.cboStorage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboStorage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboStorage.FormattingEnabled = true;
		this.cboStorage.Location = new System.Drawing.Point(331, 39);
		this.cboStorage.Name = "cboStorage";
		this.cboStorage.Size = new System.Drawing.Size(120, 21);
		this.cboStorage.TabIndex = 4;
		this.Label10.AutoSize = true;
		this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label10.Location = new System.Drawing.Point(240, 15);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(44, 13);
		this.Label10.TabIndex = 216;
		this.Label10.Text = "Cabang";
		this.cboBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboBranch.FormattingEnabled = true;
		this.cboBranch.Location = new System.Drawing.Point(331, 12);
		this.cboBranch.Name = "cboBranch";
		this.cboBranch.Size = new System.Drawing.Size(120, 21);
		this.cboBranch.TabIndex = 3;
		this.Label8.AutoSize = true;
		this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label8.Location = new System.Drawing.Point(491, 69);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(66, 13);
		this.Label8.TabIndex = 215;
		this.Label8.Text = "Tunai/Kredit";
		this.cboInvoiceCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboInvoiceCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboInvoiceCode.FormattingEnabled = true;
		this.cboInvoiceCode.Location = new System.Drawing.Point(577, 66);
		this.cboInvoiceCode.Name = "cboInvoiceCode";
		this.cboInvoiceCode.Size = new System.Drawing.Size(114, 21);
		this.cboInvoiceCode.TabIndex = 10;
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.Location = new System.Drawing.Point(491, 124);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(37, 13);
		this.Label6.TabIndex = 214;
		this.Label6.Text = "Status";
		this.cboStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboStatus.FormattingEnabled = true;
		this.cboStatus.Location = new System.Drawing.Point(577, 121);
		this.cboStatus.Name = "cboStatus";
		this.cboStatus.Size = new System.Drawing.Size(114, 21);
		this.cboStatus.TabIndex = 12;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(491, 97);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(40, 13);
		this.Label5.TabIndex = 213;
		this.Label5.Text = "NPWP";
		this.cboNPWP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboNPWP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboNPWP.FormattingEnabled = true;
		this.cboNPWP.Location = new System.Drawing.Point(577, 94);
		this.cboNPWP.Name = "cboNPWP";
		this.cboNPWP.Size = new System.Drawing.Size(114, 21);
		this.cboNPWP.TabIndex = 11;
		this.txtInvoiceNo.Location = new System.Drawing.Point(94, 91);
		this.txtInvoiceNo.Name = "txtInvoiceNo";
		this.txtInvoiceNo.Size = new System.Drawing.Size(114, 20);
		this.txtInvoiceNo.TabIndex = 192;
		this.txtInvoiceNo.Visible = false;
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(9, 94);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(54, 13);
		this.Label4.TabIndex = 212;
		this.Label4.Text = "No Faktur";
		this.Label4.Visible = false;
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(8, 15);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(86, 13);
		this.Label3.TabIndex = 211;
		this.Label3.Text = "Dasar Pencarian";
		this.cboBaseFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboBaseFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboBaseFilter.FormattingEnabled = true;
		this.cboBaseFilter.Location = new System.Drawing.Point(94, 12);
		this.cboBaseFilter.Name = "cboBaseFilter";
		this.cboBaseFilter.Size = new System.Drawing.Size(114, 21);
		this.cboBaseFilter.TabIndex = 0;
		this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnReset.Location = new System.Drawing.Point(147, 117);
		this.btnReset.Name = "btnReset";
		this.btnReset.Size = new System.Drawing.Size(47, 24);
		this.btnReset.TabIndex = 22;
		this.btnReset.Text = "&Reset";
		this.btnReset.UseVisualStyleBackColor = true;
		this.btnWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnWord.Location = new System.Drawing.Point(820, 530);
		this.btnWord.Name = "btnWord";
		this.btnWord.Size = new System.Drawing.Size(73, 23);
		this.btnWord.TabIndex = 24;
		this.btnWord.Text = "&Word";
		this.btnWord.UseVisualStyleBackColor = true;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(7, 42);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(71, 13);
		this.Label1.TabIndex = 210;
		this.Label1.Text = "Tanggal awal";
		this.lblTotal.AutoSize = true;
		this.lblTotal.Location = new System.Drawing.Point(9, 530);
		this.lblTotal.Name = "lblTotal";
		this.lblTotal.Size = new System.Drawing.Size(91, 13);
		this.lblTotal.TabIndex = 209;
		this.lblTotal.Text = "Total Pencarian: -";
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.Location = new System.Drawing.Point(491, 42);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(45, 13);
		this.Label7.TabIndex = 208;
		this.Label7.Text = "Wilayah";
		this.cboArea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboArea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboArea.FormattingEnabled = true;
		this.cboArea.Location = new System.Drawing.Point(577, 39);
		this.cboArea.Name = "cboArea";
		this.cboArea.Size = new System.Drawing.Size(114, 21);
		this.cboArea.TabIndex = 9;
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.Location = new System.Drawing.Point(12, 161);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(960, 363);
		this.dgvList.TabIndex = 23;
		this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSearch.Location = new System.Drawing.Point(94, 117);
		this.btnSearch.Name = "btnSearch";
		this.btnSearch.Size = new System.Drawing.Size(47, 24);
		this.btnSearch.TabIndex = 21;
		this.btnSearch.Text = "&Cari";
		this.btnSearch.UseVisualStyleBackColor = true;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(7, 68);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(72, 13);
		this.Label2.TabIndex = 207;
		this.Label2.Text = "Tanggal akhir";
		this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpEnd.Location = new System.Drawing.Point(95, 65);
		this.dtpEnd.Name = "dtpEnd";
		this.dtpEnd.Size = new System.Drawing.Size(113, 20);
		this.dtpEnd.TabIndex = 2;
		this.dtpBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpBegin.Location = new System.Drawing.Point(95, 39);
		this.dtpBegin.Name = "dtpBegin";
		this.dtpBegin.Size = new System.Drawing.Size(113, 20);
		this.dtpBegin.TabIndex = 1;
		((Shape)this.LineShape2).Name = "LineShape2";
		this.LineShape2.X1 = 244;
		this.LineShape2.X2 = 450;
		this.LineShape2.Y1 = 64;
		this.LineShape2.Y2 = 64;
		((Shape)this.LineShape1).Name = "LineShape1";
		this.LineShape1.X1 = 244;
		this.LineShape1.X2 = 450;
		this.LineShape1.Y1 = 116;
		this.LineShape1.Y2 = 116;
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).Location = new System.Drawing.Point(0, 0);
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).Margin = new System.Windows.Forms.Padding(0);
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).Name = "ShapeContainer1";
		this.ShapeContainer1.Shapes.AddRange((Shape[])(object)new Shape[2]
		{
			(Shape)this.LineShape1,
			(Shape)this.LineShape2
		});
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).Size = new System.Drawing.Size(987, 563);
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).TabIndex = 222;
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).TabStop = false;
		this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnPrint.Location = new System.Drawing.Point(899, 530);
		this.btnPrint.Name = "btnPrint";
		this.btnPrint.Size = new System.Drawing.Size(73, 23);
		this.btnPrint.TabIndex = 25;
		this.btnPrint.Text = "Cetak";
		this.btnPrint.UseVisualStyleBackColor = true;
		base.AcceptButton = this.btnSearch;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(987, 563);
		base.Controls.Add(this.btnPrint);
		base.Controls.Add(this.Label13);
		base.Controls.Add(this.cboSalesPerson);
		base.Controls.Add(this.Label12);
		base.Controls.Add(this.cboCustomerCode);
		base.Controls.Add(this.btnAllCustomer);
		base.Controls.Add(this.btnSearchCustomer);
		base.Controls.Add(this.lblCustomerName);
		base.Controls.Add(this.Label11);
		base.Controls.Add(this.Label9);
		base.Controls.Add(this.cboStorage);
		base.Controls.Add(this.Label10);
		base.Controls.Add(this.cboBranch);
		base.Controls.Add(this.Label8);
		base.Controls.Add(this.cboInvoiceCode);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.cboStatus);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.cboNPWP);
		base.Controls.Add(this.txtInvoiceNo);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.cboBaseFilter);
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
		base.Name = "frmReportSalesReturn";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Report Retur Penjualan";
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmReportSalesReturn()
	{
		base.KeyDown += frmReportSalesReturn_KeyDown;
		base.Load += frmReportSalesReturn_Load;
		InitializeComponent();
		DoubleBuffered = true;
		base.MdiParent = MyProject.Forms.frmMenu;
		ComboBox combo = cboBranch;
		cCombo.getBranch(ref combo, Module1.pubGroupId, blnAll: true);
		cboBranch = combo;
		combo = cboBaseFilter;
		cCombo.getReportSalesInvoiceFilter(ref combo, IsReturn: true);
		cboBaseFilter = combo;
		combo = cboCustomerCode;
		cCombo.getCustomerCode(ref combo, All: true, 1);
		cboCustomerCode = combo;
		combo = cboNPWP;
		cCombo.getYesNo(ref combo, All: true);
		cboNPWP = combo;
		combo = cboInvoiceCode;
		cCombo.getInvoiceCode(ref combo, All: true);
		cboInvoiceCode = combo;
		combo = cboStatus;
		cCombo.getPaymentStatus(ref combo, All: true);
		cboStatus = combo;
		combo = cboNPWP;
		cCombo.getYesNo(ref combo, All: true);
		cboNPWP = combo;
	}

	private void frmReportSalesReturn_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void frmReportSalesReturn_Load(object sender, EventArgs e)
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
		cboBaseFilter.SelectedIndex = 0;
		cboBranch.SelectedIndex = 0;
		cboStorage.SelectedIndex = 0;
		_customerId = 0.0;
		lblCustomerName.Text = "--SEMUA--";
		cboCustomerCode.SelectedIndex = 0;
		cboSalesPerson.SelectedIndex = 0;
		cboArea.SelectedIndex = 0;
		cboInvoiceCode.SelectedIndex = 0;
		cboNPWP.SelectedIndex = 0;
		cboStatus.SelectedIndex = 0;
		dgvList.Rows.Clear();
		lblTotal.Text = "Total Pencarian: -";
		dtpBegin.Focus();
	}

	private void cboBaseFilter_SelectedIndexChanged(object sender, EventArgs e)
	{
		if ((cboBaseFilter.SelectedIndex == 0) | (cboBaseFilter.SelectedIndex == 1) | (cboBaseFilter.SelectedIndex == 2) | (cboBaseFilter.SelectedIndex == 3))
		{
			dtpBegin.Enabled = true;
			dtpEnd.Enabled = true;
			txtInvoiceNo.Enabled = false;
		}
		else
		{
			dtpBegin.Enabled = false;
			dtpEnd.Enabled = false;
			txtInvoiceNo.Enabled = true;
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
		frmCustomerMiniSearch2.CallerName = "ReportSalesReturn";
		frmCustomerMiniSearch2.ShowDialog();
		frmCustomerMiniSearch2.Close();
		frmCustomerMiniSearch2.Dispose();
	}

	private void btnSearch_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		double num4 = default(double);
		double num5 = default(double);
		double num6 = default(double);
		double num7 = default(double);
		double num8 = default(double);
		double num9 = default(double);
		double num10 = default(double);
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
					cComboItem cComboItem2 = (cComboItem)cboBaseFilter.SelectedItem;
					cComboItem cComboItem3 = (cComboItem)cboBranch.SelectedItem;
					cComboItem cComboItem4 = (cComboItem)cboStorage.SelectedItem;
					cComboItem cComboItem5 = (cComboItem)cboCustomerCode.SelectedItem;
					cComboItem cComboItem6 = (cComboItem)cboArea.SelectedItem;
					cComboItem cComboItem7 = (cComboItem)cboSalesPerson.SelectedItem;
					cComboItem cComboItem8 = (cComboItem)cboInvoiceCode.SelectedItem;
					cComboItem cComboItem9 = (cComboItem)cboNPWP.SelectedItem;
					cComboItem cComboItem10 = (cComboItem)cboStatus.SelectedItem;
					if (cboBaseFilter.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih dasar pencarian", MsgBoxStyle.Information);
						cboBaseFilter.Focus();
						goto end_IL_0001;
					}
					if ((Conversions.ToDouble(cComboItem2.Value) == 6.0) & (Operators.CompareString(txtInvoiceNo.Text, "", TextCompare: false) == 0))
					{
						Interaction.MsgBox("Masukkan nomer faktur", MsgBoxStyle.Information);
						txtInvoiceNo.Focus();
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
					if (cboCustomerCode.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih kode customer", MsgBoxStyle.Information);
						cboCustomerCode.Focus();
						goto end_IL_0001;
					}
					if (cboSalesPerson.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih sales", MsgBoxStyle.Information);
						cboSalesPerson.Focus();
						goto end_IL_0001;
					}
					if (cboArea.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih wilayah", MsgBoxStyle.Information);
						cboArea.Focus();
						goto end_IL_0001;
					}
					if (cboInvoiceCode.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih Tunai/Kredit.", MsgBoxStyle.Information);
						cboInvoiceCode.Focus();
						goto end_IL_0001;
					}
					if (cboNPWP.SelectedIndex == -1)
					{
						Interaction.MsgBox("Opsi NPWP yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
						cboNPWP.Focus();
						goto end_IL_0001;
					}
					if (cboStatus.SelectedIndex == -1)
					{
						Interaction.MsgBox("Status yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
						cboStatus.Focus();
						goto end_IL_0001;
					}
					Cursor = Cursors.WaitCursor;
					DataTable dataTable = new DataTable();
					btnSearch.Focus();
					dataTable = cSalesInvoice.Search(Conversions.ToInteger(cComboItem2.Value), dtpBegin.Value, dtpEnd.Value, Conversions.ToInteger(cComboItem5.Value), Conversions.ToInteger(cComboItem7.Value), Conversions.ToInteger(cComboItem10.Value), Conversions.ToInteger(cComboItem6.Value), txtInvoiceNo.Text, 0.0, _customerId, Conversions.ToInteger(cComboItem8.Value), 1, Conversions.ToInteger(cComboItem9.Value), 99, Conversions.ToInteger(cComboItem4.Value), Conversions.ToInteger(cComboItem3.Value), Module1.pubGroupId, "ASC");
					dgvList.Rows.Clear();
					formatGrid();
					if ((Conversions.ToDouble(cComboItem2.Value) == 3.0) | (Conversions.ToDouble(cComboItem2.Value) == 5.0))
					{
						dgvList.Columns[1].Visible = false;
						dgvList.Columns[2].Visible = false;
						dgvList.Columns[3].Visible = true;
						dgvList.Columns[4].Visible = true;
					}
					else
					{
						dgvList.Columns[1].Visible = true;
						dgvList.Columns[2].Visible = true;
						dgvList.Columns[3].Visible = false;
						dgvList.Columns[4].Visible = false;
					}
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						double num3 = Conversions.ToDouble(Operators.SubtractObject(Operators.SubtractObject(dataRow["penjTotal"], dataRow["penjBs"]), dataRow["penjDisc"]));
						dgvList.Rows.Add(dataRow["penjId"], dataRow["penjDate"], dataRow["penjFaktur"], dataRow["penjDateFP"], dataRow["penjFP"], dataRow["penjKode"], Module1.formatCustomDecimal(Conversions.ToString(dataRow["penjTotal"]), 2), Module1.formatCustomDecimal(Conversions.ToString(dataRow["penjBs"]), 2), Module1.formatCustomDecimal(Conversions.ToString(Operators.MultiplyObject(dataRow["penjDisc"], -1)), 2), Module1.formatCustomDecimal(Conversions.ToString(num3 * -1.0), 2), Module1.formatCustomDecimal(Conversions.ToString(Operators.MultiplyObject(dataRow["penjPot"], -1)), 2), Module1.formatCustomDecimal(Conversions.ToString(Operators.MultiplyObject(dataRow["penjBayar"], -1)), 2), Module1.formatCustomDecimal(Conversions.ToString(Operators.MultiplyObject(dataRow["penjReceivable"], -1)), 2), Module1.formatCustomDecimal(Conversions.ToString(dataRow["penjReceivableDays"]), 2), dataRow["tfDate"], dataRow["penjPrintKomTotal"], dataRow["penjPrintPajakTotal"]);
						num4 = Conversions.ToDouble(Operators.AddObject(num4, dataRow["penjTotal"]));
						num5 = Conversions.ToDouble(Operators.AddObject(num5, dataRow["penjBs"]));
						num6 = Conversions.ToDouble(Operators.AddObject(num6, Operators.MultiplyObject(dataRow["penjDisc"], -1)));
						num7 += num3 * -1.0;
						num8 = Conversions.ToDouble(Operators.AddObject(num8, Operators.MultiplyObject(dataRow["penjBayar"], -1)));
						num9 = Conversions.ToDouble(Operators.AddObject(num9, Operators.MultiplyObject(dataRow["penjPot"], -1)));
						num10 = Conversions.ToDouble(Operators.AddObject(num10, Operators.MultiplyObject(dataRow["penjReceivable"], -1)));
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
						dgvList.Rows.Add("", "Total", "", "Total", "", "", Module1.formatCustomDecimal(Conversions.ToString(num4), 2), Module1.formatCustomDecimal(Conversions.ToString(num5), 2), Module1.formatCustomDecimal(Conversions.ToString(num6), 2), Module1.formatCustomDecimal(Conversions.ToString(num7), 2), Module1.formatCustomDecimal(Conversions.ToString(num9), 2), Module1.formatCustomDecimal(Conversions.ToString(num8), 2), Module1.formatCustomDecimal(Conversions.ToString(num10), 2));
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
				case 2409:
					num = -1;
					switch (num2)
					{
					case 2:
						Cursor = Cursors.Default;
						Module1.SaveError(Information.Err(), "frmReportSalesReturn", "btnSearch_click", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 2409;
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
		dgvList.Columns.Add("", "No Faktur");
		dgvList.Columns.Add("", "Tgl Pajak");
		dgvList.Columns.Add("", "No Faktur Pajak");
		dgvList.Columns.Add("", "T/K");
		dgvList.Columns.Add("", "Total Harga");
		dgvList.Columns.Add("", "Retur");
		dgvList.Columns.Add("", "Diskon");
		dgvList.Columns.Add("", "Total Faktur");
		dgvList.Columns.Add("", "Potongan");
		dgvList.Columns.Add("", "Total Bayar");
		dgvList.Columns.Add("", "Total Piutang");
		dgvList.Columns.Add("", "Umur Piutang");
		dgvList.Columns.Add("", "Tgl TF");
		dgvList.Columns.Add("", "Kom");
		dgvList.Columns.Add("", "Pjk");
		dgvList.Columns[0].Visible = false;
		dgvList.Columns[14].Visible = false;
		dgvList.Columns[15].Visible = false;
		dgvList.Columns[16].Visible = false;
		dgvList.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvList.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvList.Columns[0].Width = 0;
		dgvList.Columns[1].Width = 65;
		dgvList.Columns[2].Width = 90;
		dgvList.Columns[3].Width = 65;
		dgvList.Columns[4].Width = 90;
		dgvList.Columns[5].Width = 35;
		dgvList.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		dgvList.Columns[6].Width = 85;
		dgvList.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[7].Width = 60;
		dgvList.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[8].Width = 60;
		dgvList.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[9].Width = 85;
		dgvList.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[10].Width = 60;
		dgvList.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[11].Width = 85;
		dgvList.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[12].Width = 85;
		dgvList.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[13].Width = 60;
		dgvList.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[14].Width = 77;
		dgvList.Columns[14].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvList.Columns[15].Width = 44;
		dgvList.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[16].Width = 44;
		dgvList.Columns[16].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
		msWord.rptWordNew(dgvList.Rows.Count, dgvList.Columns.Count, "LLLRRRRRRRRLRR", blnPortrait: false, "", Print);
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
