using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GCUv2.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace GCUv2;

[DesignerGenerated]
public class frmSalesReturn : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnItem")]
	private Button _btnItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvItem")]
	private DataGridView _dgvItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("lblInformation")]
	private Label _lblInformation;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("txtDeduction")]
	private FilteredTextBox _txtDeduction;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvPayment")]
	private DataGridView _dgvPayment;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnPayment")]
	private Button _btnPayment;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSaveClose")]
	private Button _btnSaveClose;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnHistory")]
	private Button _btnHistory;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnDelete")]
	private Button _btnDelete;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSave")]
	private Button _btnSave;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("txtDiscountValue")]
	private FilteredTextBox _txtDiscountValue;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TabControl1")]
	private TabControl _TabControl1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dtpInvoice")]
	private DateTimePicker _dtpInvoice;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSearch")]
	private Button _btnSearch;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("lblCustomerAddress")]
	private Label _lblCustomerAddress;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("lblCustomerName")]
	private Label _lblCustomerName;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboStorage")]
	private ComboBox _cboStorage;

	private double _currentId;

	private int _currentlySelectedComboIndex;

	private bool _suppressComboChange;

	private DateTime _paidDate;

	private ComboBox _cachedComboBox;

	private string _customerNPWP;

	private string _customerPT;

	private string _customerTaxAddress;

	private double _DPP;

	private double _PPN;

	private double _customerId;

	private int _branchId;

	private DateTime _originalDate;

	private int _originalStorageId;

	private bool _edited;

	private double _parentInvoiceId;

	private int _totalItem;

	private bool _disableDgvItem;

	private bool _justLoaded;

	private int _cashAccountId;

	private int _bankAccountId;

	private string _cashAccountName;

	private int _discountId;

	internal virtual Button btnItem
	{
		[CompilerGenerated]
		get
		{
			return _btnItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnItem_Click;
			Button button = _btnItem;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnItem = value;
			button = _btnItem;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TabPage1")]
	internal virtual TabPage TabPage1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView dgvItem
	{
		[CompilerGenerated]
		get
		{
			return _dgvItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = dgvItem_GotFocus;
			EventHandler value3 = dgvItem_LostFocus;
			EventHandler value4 = dgvItem_DoubleClick;
			KeyEventHandler value5 = dgvItem_KeyDown;
			DataGridView dataGridView = _dgvItem;
			if (dataGridView != null)
			{
				dataGridView.GotFocus -= value2;
				dataGridView.LostFocus -= value3;
				dataGridView.DoubleClick -= value4;
				dataGridView.KeyDown -= value5;
			}
			_dgvItem = value;
			dataGridView = _dgvItem;
			if (dataGridView != null)
			{
				dataGridView.GotFocus += value2;
				dataGridView.LostFocus += value3;
				dataGridView.DoubleClick += value4;
				dataGridView.KeyDown += value5;
			}
		}
	}

	[field: AccessedThroughProperty("lblNumber")]
	internal virtual Label lblNumber
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label15")]
	internal virtual Label Label15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label lblInformation
	{
		[CompilerGenerated]
		get
		{
			return _lblInformation;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = lblInformation_Click;
			Label label = _lblInformation;
			if (label != null)
			{
				label.Click -= value2;
			}
			_lblInformation = value;
			label = _lblInformation;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("lblTotalNetPayment")]
	internal virtual Label lblTotalNetPayment
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual FilteredTextBox txtDeduction
	{
		[CompilerGenerated]
		get
		{
			return _txtDeduction;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = txtDeduction_Click;
			EventHandler value3 = txtDeduction_GotFocus;
			EventHandler value4 = txtDeduction_TextChanged;
			FilteredTextBox filteredTextBox = _txtDeduction;
			if (filteredTextBox != null)
			{
				filteredTextBox.Click -= value2;
				filteredTextBox.GotFocus -= value3;
				filteredTextBox.TextChanged -= value4;
			}
			_txtDeduction = value;
			filteredTextBox = _txtDeduction;
			if (filteredTextBox != null)
			{
				filteredTextBox.Click += value2;
				filteredTextBox.GotFocus += value3;
				filteredTextBox.TextChanged += value4;
			}
		}
	}

	[field: AccessedThroughProperty("Label14")]
	internal virtual Label Label14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label16")]
	internal virtual Label Label16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage2")]
	internal virtual TabPage TabPage2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView dgvPayment
	{
		[CompilerGenerated]
		get
		{
			return _dgvPayment;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = dgvPayment_GotFocus;
			EventHandler value3 = dgvPayment_LostFocus;
			EventHandler value4 = dgvPayment_DoubleClick;
			KeyEventHandler value5 = dgvPayment_KeyDown;
			DataGridView dataGridView = _dgvPayment;
			if (dataGridView != null)
			{
				dataGridView.GotFocus -= value2;
				dataGridView.LostFocus -= value3;
				dataGridView.DoubleClick -= value4;
				dataGridView.KeyDown -= value5;
			}
			_dgvPayment = value;
			dataGridView = _dgvPayment;
			if (dataGridView != null)
			{
				dataGridView.GotFocus += value2;
				dataGridView.LostFocus += value3;
				dataGridView.DoubleClick += value4;
				dataGridView.KeyDown += value5;
			}
		}
	}

	internal virtual Button btnPayment
	{
		[CompilerGenerated]
		get
		{
			return _btnPayment;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnPayment_Click;
			Button button = _btnPayment;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnPayment = value;
			button = _btnPayment;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("cboInvoiceCode")]
	internal virtual ComboBox cboInvoiceCode
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnSaveClose
	{
		[CompilerGenerated]
		get
		{
			return _btnSaveClose;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnSaveClose_Click;
			Button button = _btnSaveClose;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnSaveClose = value;
			button = _btnSaveClose;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button btnHistory
	{
		[CompilerGenerated]
		get
		{
			return _btnHistory;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnHistory_Click;
			Button button = _btnHistory;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnHistory = value;
			button = _btnHistory;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button btnDelete
	{
		[CompilerGenerated]
		get
		{
			return _btnDelete;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnDelete_Click;
			Button button = _btnDelete;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnDelete = value;
			button = _btnDelete;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button btnSave
	{
		[CompilerGenerated]
		get
		{
			return _btnSave;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnSave_Click;
			Button button = _btnSave;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnSave = value;
			button = _btnSave;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRetur")]
	internal virtual Label lblRetur
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

	[field: AccessedThroughProperty("Label12")]
	internal virtual Label Label12
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

	[field: AccessedThroughProperty("lblTotalInvoice")]
	internal virtual Label lblTotalInvoice
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

	internal virtual FilteredTextBox txtDiscountValue
	{
		[CompilerGenerated]
		get
		{
			return _txtDiscountValue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = txtDiscount_Click;
			EventHandler value3 = txtDiscount_GotFocus;
			EventHandler value4 = txtDiscount_TextChanged;
			FilteredTextBox filteredTextBox = _txtDiscountValue;
			if (filteredTextBox != null)
			{
				filteredTextBox.Click -= value2;
				filteredTextBox.GotFocus -= value3;
				filteredTextBox.TextChanged -= value4;
			}
			_txtDiscountValue = value;
			filteredTextBox = _txtDiscountValue;
			if (filteredTextBox != null)
			{
				filteredTextBox.Click += value2;
				filteredTextBox.GotFocus += value3;
				filteredTextBox.TextChanged += value4;
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TabControl TabControl1
	{
		[CompilerGenerated]
		get
		{
			return _TabControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TabControl1_SelectedIndexChanged;
			TabControl tabControl = _TabControl1;
			if (tabControl != null)
			{
				tabControl.SelectedIndexChanged -= value2;
			}
			_TabControl1 = value;
			tabControl = _TabControl1;
			if (tabControl != null)
			{
				tabControl.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TabPage4")]
	internal virtual TabPage TabPage4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTotalPayment")]
	internal virtual Label lblTotalPayment
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTotalPayable")]
	internal virtual Label lblTotalPayable
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTotalPrice")]
	internal virtual Label lblTotalPrice
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

	internal virtual DateTimePicker dtpInvoice
	{
		[CompilerGenerated]
		get
		{
			return _dtpInvoice;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = dtpInvoice_ValueChanged;
			DateTimePicker dateTimePicker = _dtpInvoice;
			if (dateTimePicker != null)
			{
				dateTimePicker.ValueChanged -= value2;
			}
			_dtpInvoice = value;
			dateTimePicker = _dtpInvoice;
			if (dateTimePicker != null)
			{
				dateTimePicker.ValueChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
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

	internal virtual Label lblCustomerAddress
	{
		[CompilerGenerated]
		get
		{
			return _lblCustomerAddress;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = lblCustomerAddress_Click;
			Label label = _lblCustomerAddress;
			if (label != null)
			{
				label.Click -= value2;
			}
			_lblCustomerAddress = value;
			label = _lblCustomerAddress;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal virtual Label lblCustomerName
	{
		[CompilerGenerated]
		get
		{
			return _lblCustomerName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = lblCustomerName_Click;
			Label label = _lblCustomerName;
			if (label != null)
			{
				label.Click -= value2;
			}
			_lblCustomerName = value;
			label = _lblCustomerName;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label19")]
	internal virtual Label Label19
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label17")]
	internal virtual Label Label17
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

	[field: AccessedThroughProperty("Label27")]
	internal virtual Label Label27
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox cboStorage
	{
		[CompilerGenerated]
		get
		{
			return _cboStorage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cboStorage_SelectedIndexChanged;
			ComboBox comboBox = _cboStorage;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_cboStorage = value;
			comboBox = _cboStorage;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label26")]
	internal virtual Label Label26
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNote")]
	internal virtual TextBox txtNote
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	public string CustomerNPWP
	{
		get
		{
			return _customerNPWP;
		}
		set
		{
			_customerNPWP = value;
		}
	}

	public int BranchId
	{
		get
		{
			return _branchId;
		}
		set
		{
			_branchId = value;
		}
	}

	public bool Edited
	{
		get
		{
			return _edited;
		}
		set
		{
			_edited = value;
		}
	}

	public DateTime OriginalDate
	{
		get
		{
			return _originalDate;
		}
		set
		{
			_originalDate = value;
		}
	}

	public int OriginalStorageId
	{
		get
		{
			return _originalStorageId;
		}
		set
		{
			_originalStorageId = value;
		}
	}

	public double CurrentId
	{
		get
		{
			return _currentId;
		}
		set
		{
			_currentId = value;
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
		this.btnItem = new System.Windows.Forms.Button();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.dgvItem = new System.Windows.Forms.DataGridView();
		this.lblNumber = new System.Windows.Forms.Label();
		this.Label15 = new System.Windows.Forms.Label();
		this.lblInformation = new System.Windows.Forms.Label();
		this.lblTotalNetPayment = new System.Windows.Forms.Label();
		this.txtDeduction = new GCUv2.FilteredTextBox();
		this.Label14 = new System.Windows.Forms.Label();
		this.Label16 = new System.Windows.Forms.Label();
		this.TabPage2 = new System.Windows.Forms.TabPage();
		this.dgvPayment = new System.Windows.Forms.DataGridView();
		this.btnPayment = new System.Windows.Forms.Button();
		this.cboInvoiceCode = new System.Windows.Forms.ComboBox();
		this.btnSaveClose = new System.Windows.Forms.Button();
		this.btnHistory = new System.Windows.Forms.Button();
		this.btnDelete = new System.Windows.Forms.Button();
		this.btnSave = new System.Windows.Forms.Button();
		this.Label10 = new System.Windows.Forms.Label();
		this.lblRetur = new System.Windows.Forms.Label();
		this.Label13 = new System.Windows.Forms.Label();
		this.Label12 = new System.Windows.Forms.Label();
		this.Label11 = new System.Windows.Forms.Label();
		this.Label9 = new System.Windows.Forms.Label();
		this.lblTotalInvoice = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.txtDiscountValue = new GCUv2.FilteredTextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.TabControl1 = new System.Windows.Forms.TabControl();
		this.TabPage4 = new System.Windows.Forms.TabPage();
		this.txtNote = new System.Windows.Forms.TextBox();
		this.Label26 = new System.Windows.Forms.Label();
		this.Label17 = new System.Windows.Forms.Label();
		this.cboSalesPerson = new System.Windows.Forms.ComboBox();
		this.Label27 = new System.Windows.Forms.Label();
		this.cboStorage = new System.Windows.Forms.ComboBox();
		this.lblTotalPayment = new System.Windows.Forms.Label();
		this.lblTotalPayable = new System.Windows.Forms.Label();
		this.lblTotalPrice = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.dtpInvoice = new System.Windows.Forms.DateTimePicker();
		this.Label5 = new System.Windows.Forms.Label();
		this.btnSearch = new System.Windows.Forms.Button();
		this.lblCustomerAddress = new System.Windows.Forms.Label();
		this.lblCustomerName = new System.Windows.Forms.Label();
		this.Label19 = new System.Windows.Forms.Label();
		this.TabPage1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvItem).BeginInit();
		this.TabPage2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvPayment).BeginInit();
		this.TabControl1.SuspendLayout();
		this.TabPage4.SuspendLayout();
		base.SuspendLayout();
		this.btnItem.BackColor = System.Drawing.SystemColors.ButtonFace;
		this.btnItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnItem.Location = new System.Drawing.Point(8, 7);
		this.btnItem.Name = "btnItem";
		this.btnItem.Size = new System.Drawing.Size(61, 24);
		this.btnItem.TabIndex = 11;
		this.btnItem.Text = "+ Barang";
		this.btnItem.UseVisualStyleBackColor = false;
		this.TabPage1.Controls.Add(this.btnItem);
		this.TabPage1.Controls.Add(this.dgvItem);
		this.TabPage1.Location = new System.Drawing.Point(4, 22);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage1.Size = new System.Drawing.Size(608, 204);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = "Barang";
		this.TabPage1.UseVisualStyleBackColor = true;
		this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvItem.Location = new System.Drawing.Point(8, 37);
		this.dgvItem.Name = "dgvItem";
		this.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dgvItem.Size = new System.Drawing.Size(590, 160);
		this.dgvItem.TabIndex = 12;
		this.lblNumber.AutoSize = true;
		this.lblNumber.Location = new System.Drawing.Point(79, 93);
		this.lblNumber.Name = "lblNumber";
		this.lblNumber.Size = new System.Drawing.Size(54, 13);
		this.lblNumber.TabIndex = 207;
		this.lblNumber.Text = "lblNumber";
		this.Label15.AutoSize = true;
		this.Label15.Location = new System.Drawing.Point(192, 430);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(31, 13);
		this.Label15.TabIndex = 206;
		this.Label15.Text = "Total";
		this.lblInformation.AutoSize = true;
		this.lblInformation.Cursor = System.Windows.Forms.Cursors.Hand;
		this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
		this.lblInformation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
		this.lblInformation.Location = new System.Drawing.Point(372, 376);
		this.lblInformation.Name = "lblInformation";
		this.lblInformation.Size = new System.Drawing.Size(82, 15);
		this.lblInformation.TabIndex = 208;
		this.lblInformation.Text = "lblInformation";
		this.lblTotalNetPayment.Location = new System.Drawing.Point(273, 430);
		this.lblTotalNetPayment.Name = "lblTotalNetPayment";
		this.lblTotalNetPayment.Size = new System.Drawing.Size(93, 13);
		this.lblTotalNetPayment.TabIndex = 205;
		this.lblTotalNetPayment.Text = "Total Net";
		this.lblTotalNetPayment.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.txtDeduction.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtDeduction.DontFormat = false;
		this.txtDeduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtDeduction.Location = new System.Drawing.Point(282, 394);
		this.txtDeduction.MaximumDigit = 3;
		this.txtDeduction.Name = "txtDeduction";
		this.txtDeduction.Size = new System.Drawing.Size(84, 21);
		this.txtDeduction.TabIndex = 91;
		this.txtDeduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.Label14.AutoSize = true;
		this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label14.Location = new System.Drawing.Point(192, 397);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(53, 13);
		this.Label14.TabIndex = 204;
		this.Label14.Text = "Potongan";
		this.Label16.AutoSize = true;
		this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label16.Location = new System.Drawing.Point(9, 120);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(66, 13);
		this.Label16.TabIndex = 203;
		this.Label16.Text = "Tunai/Kredit";
		this.TabPage2.Controls.Add(this.dgvPayment);
		this.TabPage2.Controls.Add(this.btnPayment);
		this.TabPage2.Location = new System.Drawing.Point(4, 22);
		this.TabPage2.Name = "TabPage2";
		this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage2.Size = new System.Drawing.Size(608, 204);
		this.TabPage2.TabIndex = 1;
		this.TabPage2.Text = "Pembayaran";
		this.TabPage2.UseVisualStyleBackColor = true;
		this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvPayment.Location = new System.Drawing.Point(8, 37);
		this.dgvPayment.Name = "dgvPayment";
		this.dgvPayment.Size = new System.Drawing.Size(590, 160);
		this.dgvPayment.TabIndex = 22;
		this.btnPayment.BackColor = System.Drawing.SystemColors.ButtonFace;
		this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnPayment.Location = new System.Drawing.Point(7, 7);
		this.btnPayment.Name = "btnPayment";
		this.btnPayment.Size = new System.Drawing.Size(85, 24);
		this.btnPayment.TabIndex = 21;
		this.btnPayment.Text = "+ Pembayaran";
		this.btnPayment.UseVisualStyleBackColor = false;
		this.cboInvoiceCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboInvoiceCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboInvoiceCode.FormattingEnabled = true;
		this.cboInvoiceCode.Location = new System.Drawing.Point(82, 116);
		this.cboInvoiceCode.Name = "cboInvoiceCode";
		this.cboInvoiceCode.Size = new System.Drawing.Size(121, 21);
		this.cboInvoiceCode.TabIndex = 2;
		this.btnSaveClose.BackColor = System.Drawing.Color.WhiteSmoke;
		this.btnSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSaveClose.Location = new System.Drawing.Point(425, 483);
		this.btnSaveClose.Name = "btnSaveClose";
		this.btnSaveClose.Size = new System.Drawing.Size(93, 24);
		this.btnSaveClose.TabIndex = 102;
		this.btnSaveClose.Text = "Simpan && &Tutup";
		this.btnSaveClose.UseVisualStyleBackColor = false;
		this.btnHistory.BackColor = System.Drawing.Color.WhiteSmoke;
		this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnHistory.Location = new System.Drawing.Point(579, 483);
		this.btnHistory.Name = "btnHistory";
		this.btnHistory.Size = new System.Drawing.Size(50, 24);
		this.btnHistory.TabIndex = 104;
		this.btnHistory.Text = "&History";
		this.btnHistory.UseVisualStyleBackColor = false;
		this.btnDelete.BackColor = System.Drawing.Color.WhiteSmoke;
		this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDelete.Location = new System.Drawing.Point(524, 483);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new System.Drawing.Size(49, 24);
		this.btnDelete.TabIndex = 103;
		this.btnDelete.Text = "Hapus";
		this.btnDelete.UseVisualStyleBackColor = false;
		this.btnSave.BackColor = System.Drawing.Color.WhiteSmoke;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(333, 483);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(86, 24);
		this.btnSave.TabIndex = 101;
		this.btnSave.Text = "&Simpan && Baru";
		this.btnSave.UseVisualStyleBackColor = false;
		this.Label10.BackColor = System.Drawing.Color.Silver;
		this.Label10.Location = new System.Drawing.Point(-13, 476);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(713, 59);
		this.Label10.TabIndex = 197;
		this.lblRetur.AutoSize = true;
		this.lblRetur.Font = new System.Drawing.Font("Microsoft Sans Serif", 36f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblRetur.ForeColor = System.Drawing.Color.White;
		this.lblRetur.Location = new System.Drawing.Point(441, 60);
		this.lblRetur.Name = "lblRetur";
		this.lblRetur.Size = new System.Drawing.Size(195, 55);
		this.lblRetur.TabIndex = 196;
		this.lblRetur.Text = "RETUR";
		this.Label13.BackColor = System.Drawing.SystemColors.ButtonShadow;
		this.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Label13.Location = new System.Drawing.Point(17, 420);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(349, 1);
		this.Label13.TabIndex = 194;
		this.Label12.AutoSize = true;
		this.Label12.Location = new System.Drawing.Point(191, 450);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(69, 13);
		this.Label12.TabIndex = 193;
		this.Label12.Text = "Total Hutang";
		this.Label11.AutoSize = true;
		this.Label11.Location = new System.Drawing.Point(192, 378);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(93, 13);
		this.Label11.TabIndex = 192;
		this.Label11.Text = "Total Pembayaran";
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(15, 430);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(31, 13);
		this.Label9.TabIndex = 191;
		this.Label9.Text = "Total";
		this.lblTotalInvoice.Location = new System.Drawing.Point(78, 430);
		this.lblTotalInvoice.Name = "lblTotalInvoice";
		this.lblTotalInvoice.Size = new System.Drawing.Size(90, 13);
		this.lblTotalInvoice.TabIndex = 190;
		this.lblTotalInvoice.Text = "Total Invoice";
		this.lblTotalInvoice.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(13, 378);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(63, 13);
		this.Label8.TabIndex = 189;
		this.Label8.Text = "Total Harga";
		this.txtDiscountValue.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtDiscountValue.DontFormat = false;
		this.txtDiscountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtDiscountValue.Location = new System.Drawing.Point(79, 394);
		this.txtDiscountValue.MaximumDigit = 3;
		this.txtDiscountValue.Name = "txtDiscountValue";
		this.txtDiscountValue.Size = new System.Drawing.Size(87, 21);
		this.txtDiscountValue.TabIndex = 90;
		this.txtDiscountValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(10, 67);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(46, 13);
		this.Label1.TabIndex = 182;
		this.Label1.Text = "Tanggal";
		this.TabControl1.Controls.Add(this.TabPage1);
		this.TabControl1.Controls.Add(this.TabPage2);
		this.TabControl1.Controls.Add(this.TabPage4);
		this.TabControl1.Location = new System.Drawing.Point(12, 143);
		this.TabControl1.Name = "TabControl1";
		this.TabControl1.SelectedIndex = 0;
		this.TabControl1.Size = new System.Drawing.Size(616, 230);
		this.TabControl1.TabIndex = 10;
		this.TabPage4.BackColor = System.Drawing.Color.DarkGray;
		this.TabPage4.Controls.Add(this.txtNote);
		this.TabPage4.Controls.Add(this.Label26);
		this.TabPage4.Controls.Add(this.Label17);
		this.TabPage4.Controls.Add(this.cboSalesPerson);
		this.TabPage4.Controls.Add(this.Label27);
		this.TabPage4.Controls.Add(this.cboStorage);
		this.TabPage4.Location = new System.Drawing.Point(4, 22);
		this.TabPage4.Name = "TabPage4";
		this.TabPage4.Size = new System.Drawing.Size(608, 204);
		this.TabPage4.TabIndex = 3;
		this.TabPage4.Text = "Lain-lain";
		this.txtNote.AcceptsReturn = true;
		this.txtNote.Location = new System.Drawing.Point(79, 14);
		this.txtNote.MaxLength = 100;
		this.txtNote.Multiline = true;
		this.txtNote.Name = "txtNote";
		this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
		this.txtNote.Size = new System.Drawing.Size(190, 70);
		this.txtNote.TabIndex = 31;
		this.Label26.AutoSize = true;
		this.Label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label26.Location = new System.Drawing.Point(11, 17);
		this.Label26.Name = "Label26";
		this.Label26.Size = new System.Drawing.Size(62, 13);
		this.Label26.TabIndex = 161;
		this.Label26.Text = "Keterangan";
		this.Label17.AutoSize = true;
		this.Label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label17.Location = new System.Drawing.Point(328, 17);
		this.Label17.Name = "Label17";
		this.Label17.Size = new System.Drawing.Size(33, 13);
		this.Label17.TabIndex = 160;
		this.Label17.Text = "Sales";
		this.cboSalesPerson.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboSalesPerson.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboSalesPerson.FormattingEnabled = true;
		this.cboSalesPerson.Location = new System.Drawing.Point(415, 13);
		this.cboSalesPerson.Name = "cboSalesPerson";
		this.cboSalesPerson.Size = new System.Drawing.Size(121, 21);
		this.cboSalesPerson.TabIndex = 32;
		this.Label27.AutoSize = true;
		this.Label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label27.Location = new System.Drawing.Point(328, 44);
		this.Label27.Name = "Label27";
		this.Label27.Size = new System.Drawing.Size(45, 13);
		this.Label27.TabIndex = 158;
		this.Label27.Text = "Gudang";
		this.cboStorage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboStorage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboStorage.FormattingEnabled = true;
		this.cboStorage.Location = new System.Drawing.Point(415, 40);
		this.cboStorage.Name = "cboStorage";
		this.cboStorage.Size = new System.Drawing.Size(121, 21);
		this.cboStorage.TabIndex = 33;
		this.lblTotalPayment.Location = new System.Drawing.Point(285, 378);
		this.lblTotalPayment.Name = "lblTotalPayment";
		this.lblTotalPayment.Size = new System.Drawing.Size(81, 21);
		this.lblTotalPayment.TabIndex = 187;
		this.lblTotalPayment.Text = "Total Payment";
		this.lblTotalPayment.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.lblTotalPayable.Location = new System.Drawing.Point(275, 450);
		this.lblTotalPayable.Name = "lblTotalPayable";
		this.lblTotalPayable.Size = new System.Drawing.Size(91, 20);
		this.lblTotalPayable.TabIndex = 188;
		this.lblTotalPayable.Text = "Total Payable";
		this.lblTotalPayable.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.lblTotalPrice.Location = new System.Drawing.Point(76, 378);
		this.lblTotalPrice.Name = "lblTotalPrice";
		this.lblTotalPrice.Size = new System.Drawing.Size(90, 13);
		this.lblTotalPrice.TabIndex = 186;
		this.lblTotalPrice.Text = "Total Price";
		this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.Location = new System.Drawing.Point(10, 93);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(53, 13);
		this.Label6.TabIndex = 185;
		this.Label6.Text = "No. Retur";
		this.dtpInvoice.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpInvoice.Location = new System.Drawing.Point(82, 64);
		this.dtpInvoice.Name = "dtpInvoice";
		this.dtpInvoice.Size = new System.Drawing.Size(121, 20);
		this.dtpInvoice.TabIndex = 1;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(14, 397);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(40, 13);
		this.Label5.TabIndex = 184;
		this.Label5.Text = "Diskon";
		this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
		this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnSearch.Location = new System.Drawing.Point(544, 10);
		this.btnSearch.Name = "btnSearch";
		this.btnSearch.Size = new System.Drawing.Size(83, 23);
		this.btnSearch.TabIndex = 0;
		this.btnSearch.Text = "Pilih Customer";
		this.btnSearch.UseVisualStyleBackColor = false;
		this.lblCustomerAddress.AutoSize = true;
		this.lblCustomerAddress.BackColor = System.Drawing.SystemColors.ButtonHighlight;
		this.lblCustomerAddress.Cursor = System.Windows.Forms.Cursors.Hand;
		this.lblCustomerAddress.Location = new System.Drawing.Point(12, 28);
		this.lblCustomerAddress.Name = "lblCustomerAddress";
		this.lblCustomerAddress.Size = new System.Drawing.Size(99, 13);
		this.lblCustomerAddress.TabIndex = 212;
		this.lblCustomerAddress.Text = "lblCustomerAddress";
		this.lblCustomerName.AutoSize = true;
		this.lblCustomerName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
		this.lblCustomerName.Cursor = System.Windows.Forms.Cursors.Hand;
		this.lblCustomerName.Location = new System.Drawing.Point(12, 7);
		this.lblCustomerName.Name = "lblCustomerName";
		this.lblCustomerName.Size = new System.Drawing.Size(89, 13);
		this.lblCustomerName.TabIndex = 211;
		this.lblCustomerName.Text = "lblCustomerName";
		this.Label19.BackColor = System.Drawing.SystemColors.ButtonHighlight;
		this.Label19.Location = new System.Drawing.Point(-8, -9);
		this.Label19.Name = "Label19";
		this.Label19.Size = new System.Drawing.Size(657, 58);
		this.Label19.TabIndex = 210;
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Gray;
		base.ClientSize = new System.Drawing.Size(648, 513);
		base.Controls.Add(this.btnSearch);
		base.Controls.Add(this.lblCustomerAddress);
		base.Controls.Add(this.lblCustomerName);
		base.Controls.Add(this.Label19);
		base.Controls.Add(this.lblNumber);
		base.Controls.Add(this.Label15);
		base.Controls.Add(this.lblInformation);
		base.Controls.Add(this.lblTotalNetPayment);
		base.Controls.Add(this.txtDeduction);
		base.Controls.Add(this.Label14);
		base.Controls.Add(this.Label16);
		base.Controls.Add(this.cboInvoiceCode);
		base.Controls.Add(this.btnSaveClose);
		base.Controls.Add(this.btnHistory);
		base.Controls.Add(this.btnDelete);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.Label10);
		base.Controls.Add(this.lblRetur);
		base.Controls.Add(this.Label13);
		base.Controls.Add(this.Label12);
		base.Controls.Add(this.Label11);
		base.Controls.Add(this.Label9);
		base.Controls.Add(this.lblTotalInvoice);
		base.Controls.Add(this.Label8);
		base.Controls.Add(this.txtDiscountValue);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.TabControl1);
		base.Controls.Add(this.lblTotalPayment);
		base.Controls.Add(this.lblTotalPayable);
		base.Controls.Add(this.lblTotalPrice);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.dtpInvoice);
		base.Controls.Add(this.Label5);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSalesReturn";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Retur Penjualan";
		this.TabPage1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgvItem).EndInit();
		this.TabPage2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgvPayment).EndInit();
		this.TabControl1.ResumeLayout(false);
		this.TabPage4.ResumeLayout(false);
		this.TabPage4.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmSalesReturn()
	{
		base.KeyDown += frmSalesReturn_KeyDown;
		InitializeComponent();
		DoubleBuffered = true;
		base.MdiParent = MyProject.Forms.frmMenu;
		txtDiscountValue.AllowedCharacters = FilteredTextBox.InputType.NumeralsAndCurrency;
		ComboBox combo = cboInvoiceCode;
		cCombo.getInvoiceCode(ref combo, All: false);
		cboInvoiceCode = combo;
		formatGrid();
	}

	private void frmSalesReturn_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void formatGrid()
	{
		dgvItem.Columns.Add("", "prodId");
		dgvItem.Columns.Add("", "Barang");
		dgvItem.Columns.Add("", "Jumlah");
		dgvItem.Columns.Add("", "Harga");
		dgvItem.Columns.Add("", "Total");
		dgvItem.Columns.Add("", "BasePrice");
		dgvItem.Columns.Add("", "BaseTotal");
		dgvItem.Columns.Add("", "parentItemId");
		dgvItem.Columns[0].Visible = false;
		dgvItem.Columns[5].Visible = false;
		dgvItem.Columns[6].Visible = false;
		dgvItem.Columns[7].Visible = false;
		dgvItem.Columns[1].Width = 100;
		dgvItem.Columns[2].Width = 100;
		dgvItem.Columns[3].Width = 120;
		dgvItem.Columns[4].Width = 80;
		dgvItem.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItem.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItem.Columns[3].DefaultCellStyle.Format = "N0";
		dgvItem.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItem.Columns[4].DefaultCellStyle.Format = "N0";
		dgvItem.RowHeadersVisible = false;
		dgvItem.AllowUserToAddRows = false;
		dgvItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvItem.ReadOnly = true;
		dgvItem.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvItem.AllowUserToResizeRows = false;
		dgvPayment.Columns.Add("", "payId");
		dgvPayment.Columns.Add("", "paymentCodeId");
		dgvPayment.Columns.Add("", "salesId");
		dgvPayment.Columns.Add("", "Tanggal");
		dgvPayment.Columns.Add("", "Tipe");
		dgvPayment.Columns.Add("", "Penagih");
		dgvPayment.Columns.Add("", "Jumlah");
		dgvPayment.Columns.Add("", "Akun");
		dgvPayment.Columns.Add("", "accountId");
		dgvPayment.Columns[0].Visible = false;
		dgvPayment.Columns[1].Visible = false;
		dgvPayment.Columns[2].Visible = false;
		dgvPayment.Columns[3].Width = 80;
		dgvPayment.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvPayment.Columns[4].Width = 80;
		dgvPayment.Columns[5].Width = 80;
		dgvPayment.Columns[6].Width = 80;
		dgvPayment.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvPayment.Columns[7].Width = 80;
		dgvPayment.Columns[8].Visible = false;
		dgvPayment.RowHeadersVisible = false;
		dgvPayment.AllowUserToAddRows = false;
		dgvPayment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvPayment.ReadOnly = true;
		dgvPayment.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvPayment.AllowUserToResizeRows = false;
	}

	public void prepareForm(bool SaveNew)
	{
		_disableDgvItem = false;
		_justLoaded = false;
		btnSearch.Visible = true;
		_currentId = 0.0;
		_currentlySelectedComboIndex = -1;
		_parentInvoiceId = 0.0;
		lblNumber.Text = "BS";
		if (!SaveNew)
		{
			dtpInvoice.Value = DateAndTime.Now;
		}
		lblCustomerName.Text = "Klik tombol 'Pilih Customer' untuk memilih customer";
		lblCustomerAddress.Text = "";
		TabControl1.SelectedIndex = 0;
		cboInvoiceCode.Enabled = true;
		dgvItem.Enabled = true;
		dgvPayment.Enabled = true;
		dgvItem.Rows.Clear();
		dgvPayment.Rows.Clear();
		txtDiscountValue.Text = "";
		btnSave.Enabled = true;
		btnSaveClose.Enabled = true;
		btnDelete.Enabled = false;
		btnHistory.Enabled = false;
		lblTotalPrice.Text = "";
		lblTotalInvoice.Text = "";
		lblTotalPayable.Text = "";
		lblTotalPayment.Text = "";
		lblInformation.Text = "";
		if (Module1.pubModifySalesInvoice)
		{
			dtpInvoice.Enabled = true;
			btnItem.Enabled = true;
			txtDiscountValue.Enabled = true;
			_disableDgvItem = false;
		}
		else
		{
			dtpInvoice.Enabled = false;
			btnItem.Enabled = false;
			txtDiscountValue.Enabled = false;
			_disableDgvItem = true;
		}
		if (Module1.pubModifyPaymentInSalesInvoice)
		{
			btnPayment.Enabled = true;
			txtDeduction.Enabled = true;
		}
		else
		{
			btnPayment.Enabled = false;
			txtDeduction.Enabled = false;
		}
	}

	public void LoadData()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
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
					btnSearch.Visible = false;
					cSalesInvoice cSalesInvoice2 = new cSalesInvoice(_currentId);
					_cashAccountId = cSalesInvoice2.CashAccountId;
					_bankAccountId = cSalesInvoice2.BankAccountId;
					_customerId = cSalesInvoice2.CustomerId;
					_branchId = cSalesInvoice2.BranchId;
					_discountId = cSalesInvoice2.DiscountId;
					lblNumber.Text = cSalesInvoice2.Number;
					ComboBox combo = cboSalesPerson;
					cCombo.getSalesPerson(ref combo, "SALESPERSON", 0, 99, cSalesInvoice2.BranchId, Module1.pubGroupId, All: false, Dash: false, 1);
					cboSalesPerson = combo;
					combo = cboStorage;
					cCombo.getStorage(ref combo, Module1.pubGroupId, cSalesInvoice2.BranchId, "RETURN", blnAll: false, 1);
					cboStorage = combo;
					DateTime createdDate = cSalesInvoice2.CreatedDate;
					if (DateAndTime.DateDiff(DateInterval.Day, createdDate, DateAndTime.Now) <= Module1.pubDaysLimit)
					{
						btnDelete.Enabled = true;
					}
					else
					{
						btnDelete.Enabled = false;
					}
					lblCustomerName.Text = cSalesInvoice2.CustomerName;
					lblCustomerAddress.Text = cSalesInvoice2.CustomerAddress;
					_justLoaded = true;
					dtpInvoice.Value = cSalesInvoice2.InvoiceDate;
					_justLoaded = false;
					_customerPT = cSalesInvoice2.CustomerPT;
					_customerNPWP = cSalesInvoice2.CustomerNPWP;
					_customerTaxAddress = cSalesInvoice2.CustomerTaxAddress;
					combo = cboInvoiceCode;
					Module1.comboBoundValue(ref combo, cSalesInvoice2.InvoiceCode);
					cboInvoiceCode = combo;
					txtDiscountValue.Text = Module1.formatCustomDecimal(Conversions.ToString(cSalesInvoice2.Discount * -1.0), 2);
					txtDeduction.Text = Module1.formatCustomDecimal(Conversions.ToString(cSalesInvoice2.Deduction * -1.0), 2);
					combo = cboSalesPerson;
					Module1.comboBoundValue(ref combo, cSalesInvoice2.SalesPersonId);
					cboSalesPerson = combo;
					combo = cboStorage;
					Module1.comboBoundValue(ref combo, cSalesInvoice2.StorageId);
					cboStorage = combo;
					txtNote.Text = cSalesInvoice2.Note;
					dgvItem.Rows.Clear();
					cSalesInvoiceItem[] item = cSalesInvoice2.Item;
					foreach (cSalesInvoiceItem cSalesInvoiceItem2 in item)
					{
						dgvItem.Rows.Add(cSalesInvoiceItem2.ItemId, Operators.ConcatenateObject(Interaction.IIf(cSalesInvoiceItem2.ParentItemId > 0, "|--- ", ""), cSalesInvoiceItem2.Name), Module1.formatCustomDecimal(Conversions.ToString(cSalesInvoiceItem2.Qty), 3), cSalesInvoiceItem2.Price, cSalesInvoiceItem2.Price * cSalesInvoiceItem2.Qty, cSalesInvoiceItem2.BasePrice, cSalesInvoiceItem2.BasePrice * cSalesInvoiceItem2.Qty, cSalesInvoiceItem2.ParentItemId);
					}
					if (dgvItem.Rows.Count > 0)
					{
						dgvItem.CurrentRow.Selected = false;
					}
					calculateTotalPrice();
					dgvPayment.Rows.Clear();
					cSalesInvoicePayment[] payment = cSalesInvoice2.Payment;
					foreach (cSalesInvoicePayment cSalesInvoicePayment2 in payment)
					{
						dgvPayment.Rows.Add(cSalesInvoicePayment2.PaymentId, cSalesInvoicePayment2.PaymentCodeId, cSalesInvoicePayment2.SalesPersonId, cSalesInvoicePayment2.PaymentDate, cSalesInvoicePayment2.PaymentCodeName, cSalesInvoicePayment2.SalesPersonName, Module1.formatCustomDecimal(Conversions.ToString(cSalesInvoicePayment2.Amount * -1.0), 2), cSalesInvoicePayment2.AccountName, cSalesInvoicePayment2.AccountId);
					}
					calculateTotalPayment();
					lblTotalPayment.Text = Module1.formatCustomDecimal(Conversions.ToString(cSalesInvoice2.TotalPayment * -1.0), 2);
					calculateTotalInvoice();
					if (Module1.pubUpdateSalesInvoice)
					{
						btnSave.Enabled = true;
						btnSaveClose.Enabled = true;
					}
					else
					{
						btnSave.Enabled = false;
						btnSaveClose.Enabled = false;
					}
					if (Module1.pubDeleteSalesInvoice)
					{
						btnDelete.Enabled = true;
					}
					else
					{
						btnDelete.Enabled = false;
					}
					if (Module1.pubModifySalesInvoice & (DateAndTime.DateDiff(DateInterval.Day, dtpInvoice.Value, DateAndTime.Now) <= Module1.pubDaysLimit))
					{
						dtpInvoice.Enabled = true;
						btnItem.Enabled = true;
						txtDiscountValue.Enabled = true;
					}
					else
					{
						dtpInvoice.Enabled = false;
						btnItem.Enabled = false;
						txtDiscountValue.Enabled = false;
					}
					if (cSalesInvoice2.ParentInvoiceId > 0.0)
					{
						_parentInvoiceId = cSalesInvoice2.ParentInvoiceId;
						lblInformation.Text = "Diperhitungkan di Faktur " + cSalesInvoice2.ParentInvoiceNumber;
						dtpInvoice.Enabled = false;
						cboInvoiceCode.Enabled = false;
						dgvItem.Enabled = false;
						dgvPayment.Enabled = false;
						txtDiscountValue.Enabled = false;
						txtDeduction.Enabled = false;
						btnSave.Enabled = false;
						btnSaveClose.Enabled = false;
						btnDelete.Enabled = false;
						btnItem.Enabled = false;
						btnPayment.Enabled = false;
						txtDiscountValue.Enabled = false;
						txtDeduction.Enabled = false;
					}
					else
					{
						lblInformation.Text = "";
					}
					btnHistory.Enabled = true;
					goto end_IL_0001;
				}
				case 1724:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSalesReturn", "LoadData", "");
						if (Information.Err().Number == 513)
						{
							Close();
						}
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1724;
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

	private void btnSearch_Click(object sender, EventArgs e)
	{
		frmCustomerMiniSearch frmCustomerMiniSearch2 = new frmCustomerMiniSearch();
		frmCustomerMiniSearch2.CallerName = "SalesReturn";
		frmCustomerMiniSearch2.ShowDialog();
		frmCustomerMiniSearch2.Close();
		frmCustomerMiniSearch2.Dispose();
		if (_customerId > 0.0)
		{
			LoadCustomer();
			dtpInvoice.Focus();
		}
	}

	public void LoadCustomer()
	{
		cCustomer cCustomer2 = new cCustomer(_customerId);
		_branchId = cCustomer2.BranchId;
		lblCustomerName.Text = cCustomer2.Name;
		lblCustomerAddress.Text = cCustomer2.Address;
		_customerNPWP = cCustomer2.NPWP;
		_cashAccountId = cCustomer2.CashAccountId;
		_cashAccountName = cCustomer2.CashAccountName;
		_bankAccountId = cCustomer2.BankAccountId;
		ComboBox combo = cboStorage;
		cCombo.getStorage(ref combo, Module1.pubGroupId, _branchId, "RETURN", blnAll: false, 1);
		cboStorage = combo;
		combo = cboSalesPerson;
		cCombo.getSalesPerson(ref combo, "SALESPERSON", 0, 99, _branchId, Module1.pubGroupId, All: false, Dash: false, 1);
		cboSalesPerson = combo;
		combo = cboSalesPerson;
		Module1.comboBoundValue(ref combo, cCustomer2.SalesPersonId);
		cboSalesPerson = combo;
		cboStorage.SelectedIndex = 0;
		_branchId = cCustomer2.BranchId;
		_discountId = cCustomer2.DiscountId;
	}

	private void lblCustomerName_Click(object sender, EventArgs e)
	{
		OpenCustomer();
	}

	private void lblCustomerAddress_Click(object sender, EventArgs e)
	{
		OpenCustomer();
	}

	private void OpenCustomer()
	{
		if (_customerId > 0.0)
		{
			MyProject.Forms.frmCustomer.Show();
			MyProject.Forms.frmCustomer.prepareForm();
			MyProject.Forms.frmCustomer.CurrentId = _customerId;
			MyProject.Forms.frmCustomer.LoadData();
			MyProject.Forms.frmCustomer.Activate();
			MyProject.Forms.frmCustomer.WindowState = FormWindowState.Normal;
		}
	}

	private void dtpInvoice_ValueChanged(object sender, EventArgs e)
	{
		if (!_justLoaded & (DateAndTime.DateDiff(DateInterval.Day, dtpInvoice.Value, DateAndTime.Now) > Module1.pubDaysLimit))
		{
			Interaction.MsgBox("Anda tidak bisa membuat Retur Penjualan sebelum " + Strings.FormatDateTime(DateAndTime.Now.AddDays(checked(Module1.pubDaysLimit * -1)), DateFormat.ShortDate), MsgBoxStyle.Information);
			dtpInvoice.Value = DateAndTime.Now;
		}
	}

	public void calculateTotalPrice()
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
						_totalItem = 0;
						int num3 = dgvItem.Rows.Count - 1;
						for (int i = 0; i <= num3; i++)
						{
							if (Operators.ConditionalCompareObjectEqual(dgvItem[7, i].Value, 0, TextCompare: false))
							{
								ref int totalItem = ref _totalItem;
								totalItem = (int)Math.Round((double)totalItem + Conversions.ToDouble(dgvItem[2, i].Value));
							}
							num4 += Conversions.ToDouble(dgvItem[4, i].Value);
						}
						lblTotalPrice.Text = Module1.formatCustomDecimal(Conversions.ToString(num4), 2);
						calculateTotalInvoice();
						goto end_IL_0001;
					}
					case 220:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmSalesReturn", "CalculateTotalPrice", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 220;
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

	public void calculateDiscount()
	{
		txtDiscountValue.Text = Module1.formatCustomDecimal(Conversions.ToString(cDiscount.CalculateDiscount(_discountId, Conversion.Val(Module1.unformatNumber(lblTotalPrice.Text)), _totalItem)), 2);
	}

	public void calculateTotalPayment()
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
						_paidDate = DateTime.MinValue;
						int num3 = dgvPayment.Rows.Count - 1;
						for (int i = 0; i <= num3; i++)
						{
							num4 += Conversions.ToDouble(dgvPayment[6, i].Value);
							if (Operators.ConditionalCompareObjectGreater(dgvPayment[3, i].Value, _paidDate, TextCompare: false))
							{
								_paidDate = Conversions.ToDate(dgvPayment[3, i].Value);
							}
						}
						lblTotalPayment.Text = Module1.formatCustomDecimal(Conversions.ToString(num4), 2);
						calculateTotalInvoice();
						goto end_IL_0001;
					}
					case 214:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmSalesReturn", "CalculateTotalPayment", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 214;
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

	public void calculateTotalInvoice()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
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
					double num3 = Conversion.Val(Module1.unformatNumber(lblTotalPrice.Text)) - Conversion.Val(Module1.unformatNumber(txtDiscountValue.Text));
					lblTotalInvoice.Text = Module1.formatCustomDecimal(Conversions.ToString(num3), 2);
					double num4 = Conversion.Val(Module1.unformatNumber(lblTotalPayment.Text));
					lblTotalNetPayment.Text = Module1.formatCustomDecimal(Conversions.ToString(num4 + Conversion.Val(Module1.unformatNumber(txtDeduction.Text))), 2);
					double num5 = num3 - Conversion.Val(Module1.unformatNumber(lblTotalNetPayment.Text));
					if (num5 > 0.0)
					{
						_paidDate = DateTime.MinValue;
					}
					else if (num5 == 0.0 && num4 == 0.0)
					{
						_paidDate = dtpInvoice.Value;
					}
					lblTotalPayable.Text = Module1.formatCustomDecimal(Conversions.ToString(num5), 2);
					DateTime t = new DateTime(2022, 4, 1);
					short num6 = checked((short)DateTime.Compare(dtpInvoice.Value.Date, t));
					double num7 = ((num6 >= 0) ? 1.11 : 1.1);
					_DPP = (Conversion.Val(Module1.unformatNumber(lblTotalPrice.Text)) - Conversion.Val(Module1.unformatNumber(txtDiscountValue.Text))) / num7;
					if (_DPP - Conversion.Int(_DPP) >= 0.5)
					{
						_DPP = Conversion.Int(_DPP) + 1.0;
					}
					else
					{
						_DPP = Conversion.Int(_DPP);
					}
					_PPN = Conversion.Val(Module1.unformatNumber(lblTotalPrice.Text)) - Conversion.Val(Module1.unformatNumber(txtDiscountValue.Text)) - _DPP;
					goto end_IL_0001;
				}
				case 595:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSalesReturn", "CalculateTotalInvoice", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 595;
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

	private void btnItem_Click(object sender, EventArgs e)
	{
		if (_customerId == 0.0)
		{
			Interaction.MsgBox("Pilih customer.", (MsgBoxStyle)(-2147483637));
			btnSearch.Focus();
			return;
		}
		if (cboStorage.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih gudang", (MsgBoxStyle)(-2147483637));
			cboStorage.Focus();
			return;
		}
		cComboItem cComboItem2 = (cComboItem)cboStorage.SelectedItem;
		frmSalesReturnItem frmSalesReturnItem2 = new frmSalesReturnItem(CurrentData: false, _customerId, Conversions.ToInteger(cComboItem2.Value));
		frmSalesReturnItem2.ShowDialog();
		frmSalesReturnItem2.Close();
		frmSalesReturnItem2.Dispose();
	}

	private void dgvItem_GotFocus(object sender, EventArgs e)
	{
		if (dgvItem.RowCount > 0)
		{
			dgvItem.CurrentRow.Selected = true;
		}
	}

	private void dgvItem_LostFocus(object sender, EventArgs e)
	{
		if (dgvItem.RowCount > 0)
		{
			dgvItem.CurrentRow.Selected = false;
		}
	}

	private void dgvItem_DoubleClick(object sender, EventArgs e)
	{
		OpenItem();
	}

	private void dgvItem_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			OpenItem();
			e.SuppressKeyPress = true;
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			btnItem.Focus();
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			txtDiscountValue.Focus();
			e.SuppressKeyPress = true;
		}
	}

	private void OpenItem()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					if (!Module1.pubModifySalesInvoice)
					{
						Interaction.MsgBox("Anda tidak memiliki hak untuk meng-edit Barang.", MsgBoxStyle.Information);
					}
					else if (_disableDgvItem)
					{
						Interaction.MsgBox("Barang tidak bisa diedit.", MsgBoxStyle.Information);
					}
					else if (dgvItem.Rows.Count > 0)
					{
						if (Conversion.Val(RuntimeHelpers.GetObjectValue(dgvItem[7, dgvItem.CurrentRow.Index].Value)) > 0.0)
						{
							Interaction.MsgBox("Barang tidak bisa diedit karena merupakan bagian dari grup.", MsgBoxStyle.Information);
							goto end_IL_0001;
						}
						cComboItem cComboItem2 = (cComboItem)cboStorage.SelectedItem;
						frmSalesReturnItem frmSalesReturnItem2 = new frmSalesReturnItem(CurrentData: true, _customerId, Conversions.ToInteger(cComboItem2.Value));
						ComboBox cboSource = frmSalesReturnItem2.cboItem;
						Module1.comboBoundValue(ref cboSource, Conversions.ToDouble(dgvItem[0, dgvItem.CurrentRow.Index].Value));
						frmSalesReturnItem2.cboItem = cboSource;
						frmSalesReturnItem2.txtQty.Text = Module1.formatCustomDecimal(Conversions.ToString(dgvItem[2, dgvItem.CurrentRow.Index].Value), 3);
						frmSalesReturnItem2.txtPrice.Text = Module1.formatCustomDecimal(Conversions.ToString(dgvItem[3, dgvItem.CurrentRow.Index].Value), 2);
						frmSalesReturnItem2.ShowDialog();
					}
					goto end_IL_0001;
				case 441:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSalesReturn", "OpenItem", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 441;
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

	private void btnPayment_Click(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboSalesPerson.SelectedItem;
		frmSalesReturnPayment frmSalesReturnPayment2 = new frmSalesReturnPayment(CurrentData: false, Conversions.ToInteger(cComboItem2.Value));
		frmSalesReturnPayment2.CashAccountId = _cashAccountId;
		frmSalesReturnPayment2.BankAccountId = _bankAccountId;
		frmSalesReturnPayment2.ShowDialog();
		frmSalesReturnPayment2.Close();
		frmSalesReturnPayment2.Dispose();
		calculateTotalPayment();
	}

	private void dgvPayment_GotFocus(object sender, EventArgs e)
	{
		if (dgvPayment.RowCount > 0)
		{
			dgvPayment.CurrentRow.Selected = true;
		}
	}

	private void dgvPayment_LostFocus(object sender, EventArgs e)
	{
		if (dgvPayment.RowCount > 0)
		{
			dgvPayment.CurrentRow.Selected = false;
		}
	}

	private void dgvPayment_DoubleClick(object sender, EventArgs e)
	{
		openPayment();
	}

	private void dgvPayment_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			openPayment();
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			txtDiscountValue.Focus();
			e.SuppressKeyPress = true;
		}
	}

	private void openPayment()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
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
					if (!Module1.pubModifyPaymentInSalesInvoice)
					{
						Interaction.MsgBox("Anda tidak memiliki hak untuk meng-edit Pembayaran.", MsgBoxStyle.Information);
						goto end_IL_0001;
					}
					cComboItem cComboItem2 = (cComboItem)cboSalesPerson.SelectedItem;
					if (dgvPayment.Rows.Count > 0)
					{
						frmSalesReturnPayment frmSalesReturnPayment2 = new frmSalesReturnPayment(CurrentData: true, Conversions.ToInteger(cComboItem2.Value));
						frmSalesReturnPayment2.CashAccountId = _cashAccountId;
						frmSalesReturnPayment2.BankAccountId = _bankAccountId;
						ComboBox cboSource = frmSalesReturnPayment2.cboPaymentCode;
						Module1.comboBoundValue(ref cboSource, Conversions.ToDouble(dgvPayment[1, dgvPayment.CurrentRow.Index].Value));
						frmSalesReturnPayment2.cboPaymentCode = cboSource;
						cboSource = frmSalesReturnPayment2.cboSalesPerson;
						Module1.comboBoundValue(ref cboSource, Conversions.ToDouble(dgvPayment[2, dgvPayment.CurrentRow.Index].Value));
						frmSalesReturnPayment2.cboSalesPerson = cboSource;
						frmSalesReturnPayment2.dtpPayment.Value = Conversions.ToDate(dgvPayment[3, dgvPayment.CurrentRow.Index].Value);
						frmSalesReturnPayment2.txtAmount.Text = Module1.formatCustomDecimal(Conversions.ToString(dgvPayment[6, dgvPayment.CurrentRow.Index].Value), 3);
						cboSource = frmSalesReturnPayment2.cboAccount;
						Module1.comboBoundValue(ref cboSource, Conversions.ToDouble(dgvPayment[8, dgvPayment.CurrentRow.Index].Value));
						frmSalesReturnPayment2.cboAccount = cboSource;
						frmSalesReturnPayment2.ShowDialog();
					}
					goto end_IL_0001;
				}
				case 475:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSalesReturn", "OpenPayment", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 475;
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

	private void txtDiscount_Click(object sender, EventArgs e)
	{
		txtDiscountValue.SelectionStart = 0;
		txtDiscountValue.SelectionLength = Strings.Len(txtDiscountValue.Text);
	}

	private void txtDiscount_GotFocus(object sender, EventArgs e)
	{
		txtDiscountValue.SelectionStart = 0;
		txtDiscountValue.SelectionLength = Strings.Len(txtDiscountValue.Text);
	}

	private void txtDiscount_TextChanged(object sender, EventArgs e)
	{
		calculateTotalInvoice();
	}

	private void txtDeduction_Click(object sender, EventArgs e)
	{
		txtDeduction.SelectionStart = 0;
		txtDeduction.SelectionLength = Strings.Len(txtDeduction.Text);
	}

	private void txtDeduction_GotFocus(object sender, EventArgs e)
	{
		txtDeduction.SelectionStart = 0;
		txtDeduction.SelectionLength = Strings.Len(txtDeduction.Text);
	}

	private void txtDeduction_TextChanged(object sender, EventArgs e)
	{
		calculateTotalInvoice();
	}

	private void cboStorage_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (dgvItem.RowCount > 0)
		{
			Interaction.MsgBox("Barang akan dihapus karena anda mengganti Gudang.", MsgBoxStyle.Information);
			dgvItem.Rows.Clear();
		}
	}

	private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (TabControl1.SelectedIndex == 1 && dgvPayment.Rows.Count > 0)
		{
			dgvPayment.CurrentRow.Selected = false;
		}
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		SaveData(CloseForm: false);
	}

	private void btnSaveClose_Click(object sender, EventArgs e)
	{
		SaveData(CloseForm: true);
	}

	private bool isCash()
	{
		bool result = true;
		checked
		{
			int num = dgvPayment.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (DateAndTime.DateDiff(DateInterval.Day, dtpInvoice.Value, Conversions.ToDate(dgvPayment[3, i].Value)) > 0)
				{
					result = false;
				}
			}
			return result;
		}
	}

	private bool checkInput()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool result = default(bool);
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
					result = false;
					cComboItem cComboItem2 = (cComboItem)cboSalesPerson.SelectedItem;
					if (cboInvoiceCode.SelectedIndex == -1)
					{
						Interaction.MsgBox("Silahkan pilih kode penjualan", MsgBoxStyle.Information);
						cboInvoiceCode.Focus();
					}
					else if (dgvItem.Rows.Count == 0)
					{
						Interaction.MsgBox("Silahkan masukkan barang", MsgBoxStyle.Information);
						TabControl1.SelectedIndex = 0;
					}
					else if ((cboInvoiceCode.SelectedIndex == 0) & (Conversion.Val(lblTotalPayable.Text) > 0.0))
					{
						Interaction.MsgBox("Anda tidak bisa memilih kode penjualan Tunai\r\nkarena pembayaran masih belum terlunasi", MsgBoxStyle.Critical);
					}
					else if ((cboInvoiceCode.SelectedIndex == 0) & !isCash())
					{
						Interaction.MsgBox("Anda tidak bisa memilih kode penjualan Tunai\r\nkarena tanggal pembayaran melebihi tanggal faktur", MsgBoxStyle.Critical);
					}
					else if (cboSalesPerson.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih sales.", MsgBoxStyle.Information);
						TabControl1.SelectedIndex = 3;
						cboSalesPerson.Focus();
					}
					else if (cboStorage.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih gudang.", MsgBoxStyle.Information);
						TabControl1.SelectedIndex = 3;
						cboStorage.Focus();
					}
					else if (Strings.Len(txtNote.Text) > 255)
					{
						Interaction.MsgBox("Keterangan tidak boleh melebihi 255 huruf", MsgBoxStyle.Information);
						TabControl1.SelectedIndex = 3;
						if (txtNote.Enabled)
						{
							txtNote.Focus();
						}
					}
					else if (Conversion.Val(Module1.unformatNumber(lblTotalPayable.Text)) < 0.0)
					{
						Interaction.MsgBox("Nilai hutang tidak boleh negatif.", MsgBoxStyle.Information);
					}
					else if ((Conversion.Val(txtDeduction.Text) > 0.0) & (dgvPayment.RowCount == 0))
					{
						Interaction.MsgBox("Potongan hanya bisa diisi jika ada minimum 1 pembayaran.", MsgBoxStyle.Information);
						txtDeduction.Focus();
					}
					else if ((Conversion.Val(txtDeduction.Text) > 0.0) & (Conversion.Val(lblTotalPayable.Text) > 0.0))
					{
						Interaction.MsgBox("Potongan tidak bisa diisi karena Faktur masih belum lunas.", MsgBoxStyle.Information);
						txtDeduction.Focus();
					}
					else
					{
						result = true;
					}
					goto end_IL_0001;
				}
				case 740:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSalesReturn", "checkInput", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 740;
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
		return result;
	}

	private void SaveData(bool CloseForm)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		MySqlTransaction val = default(MySqlTransaction);
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
						cComboItem cComboItem2 = (cComboItem)cboSalesPerson.SelectedItem;
						cComboItem cComboItem3 = (cComboItem)cboStorage.SelectedItem;
						val = Module1.connectData.BeginTransaction();
						if (!checkInput())
						{
							val.Rollback();
							goto end_IL_0001;
						}
						cSalesInvoice cSalesInvoice2 = new cSalesInvoice(CurrentId);
						cSalesInvoiceItem[] array = new cSalesInvoiceItem[dgvItem.Rows.Count - 1 + 1];
						cSalesInvoicePayment[] array2 = new cSalesInvoicePayment[dgvPayment.Rows.Count - 1 + 1];
						int num3 = 0;
						cSalesInvoice2.CurrentItem = cSalesInvoice2.Item;
						cSalesInvoice2.CurrentDate = cSalesInvoice2.InvoiceDate;
						cSalesInvoice2.CurrentStorage = cSalesInvoice2.StorageId;
						cSalesInvoice2.isReturn = 1;
						cSalesInvoice2.CustomerId = _customerId;
						cSalesInvoice2.InvoiceCode = cboInvoiceCode.SelectedIndex;
						cSalesInvoice2.InvoiceDate = dtpInvoice.Value;
						cSalesInvoice2.TaxInvoiceDate = dtpInvoice.Value;
						cSalesInvoice2.Number = "BS";
						cSalesInvoice2.Discount = Conversion.Val(Module1.unformatNumber(txtDiscountValue.Text));
						cSalesInvoice2.TotalPrice = 0.0;
						cSalesInvoice2.TotalReturn = Conversion.Val(Module1.unformatNumber(lblTotalPrice.Text));
						cSalesInvoice2.TotalPayment = Conversion.Val(Module1.unformatNumber(lblTotalPayment.Text));
						cSalesInvoice2.Deduction = Conversion.Val(Module1.unformatNumber(txtDeduction.Text));
						cSalesInvoice2.PaidDate = _paidDate;
						cSalesInvoice2.SalesPersonId = Conversions.ToInteger(cComboItem2.Value);
						cSalesInvoice2.StorageId = Conversions.ToInteger(cComboItem3.Value);
						cSalesInvoice2.Note = txtNote.Text;
						string text = "";
						int num4 = dgvItem.Rows.Count - 1;
						for (num3 = 0; num3 <= num4; num3++)
						{
							array[num3] = new cSalesInvoiceItem();
							array[num3].ItemId = Conversions.ToInteger(dgvItem[0, num3].Value);
							array[num3].Qty = Conversions.ToDouble(dgvItem[2, num3].Value);
							array[num3].Price = Conversions.ToDouble(dgvItem[3, num3].Value);
							array[num3].BasePrice = Conversions.ToDouble(dgvItem[5, num3].Value);
							array[num3].ParentItemId = Conversions.ToInteger(dgvItem[7, num3].Value);
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<tr><td>", dgvItem[1, num3].Value), "</td>"), "<td>"), Module1.formatCustomDecimal(Conversions.ToString(dgvItem[2, num3].Value), 3)), "</td>"), "<td align='right'>"), Module1.formatCustomDecimal(Conversions.ToString(dgvItem[3, num3].Value), 2)), "</td>"), "<td align='right'>"), Module1.formatCustomDecimal(Conversions.ToString(dgvItem[4, num3].Value), 2)), "</td></tr>\"")));
						}
						cSalesInvoice2.Item = array;
						string text2 = "";
						int num5 = dgvPayment.Rows.Count - 1;
						for (num3 = 0; num3 <= num5; num3++)
						{
							array2[num3] = new cSalesInvoicePayment();
							array2[num3].PaymentDate = Conversions.ToDate(dgvPayment[3, num3].Value);
							array2[num3].Amount = Conversions.ToDouble(dgvPayment[6, num3].Value);
							array2[num3].PaymentCodeId = Conversions.ToByte(dgvPayment[1, num3].Value);
							array2[num3].PaymentCodeName = Conversions.ToString(dgvPayment[4, num3].Value);
							array2[num3].SalesPersonId = Conversions.ToInteger(dgvPayment[2, num3].Value);
							array2[num3].AccountId = Conversions.ToInteger(dgvPayment[8, num3].Value);
							text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<tr><td>", dgvPayment[3, num3].Value), "</td>"), "<td>"), dgvPayment[4, num3].Value), "</td>"), "<td>"), dgvPayment[5, num3].Value), "</td>"), "<td align='right'>"), Module1.formatCustomDecimal(Conversions.ToString(dgvPayment[6, num3].Value), 2)), "</td>"), "<td>"), dgvPayment[7, num3].Value), "</td></tr>")));
						}
						cSalesInvoice2.Payment = array2;
						cSalesInvoice2.Save();
						string text3 = "Tanggal: " + Conversions.ToString(dtpInvoice.Value) + "<br />No Faktur: " + lblNumber.Text + "<br />Discount: " + txtDiscountValue.Text + "<br />";
						text3 += "Barang:<br />";
						text3 += "<table>";
						text3 += "<tr><td>Barang</td><td>Jumlah</td><td>Harga</td><td>Total</td></tr>";
						text3 += text;
						text3 += "</table><br />";
						text3 += "<table>";
						text3 += "<tr><td>Tanggal</td><td>Tipe</td><td>Penagih</td><td>Jumlah</td><td>Akun</td></tr>";
						text3 += text2;
						text3 += "</table></br />";
						string text4;
						if (_currentId == 0.0)
						{
							text4 = "membuat ";
							_currentId = cSalesInvoice2.Id;
						}
						else
						{
							text4 = "mengupdate ";
						}
						text4 = text4 + "retur penjualan " + lblNumber.Text + " tanggal  " + Strings.Format(dtpInvoice.Value, "dd/MM/yyyy") + ". ID= " + Conversions.ToString(_currentId) + ", v2";
						cHistory cHistory2 = new cHistory();
						cHistory2.Content = text3;
						cHistory2.Description = text4;
						cHistory2.UserId = Module1.pubUserId;
						cHistory2.UserLogin = Module1.pubLogin;
						cHistory2.fKeyId = CurrentId;
						cHistory2.HistoryType = 20;
						cHistory2.Save();
						val.Commit();
						Interaction.MsgBox("Retur Penjualan berhasil disimpan", MsgBoxStyle.Information);
						if (Module1.FormIsOpen("frmSalesReturnList"))
						{
							MyProject.Forms.frmSalesReturnList.GetRecent();
						}
						if (Module1.FormIsOpen("frmCustomer"))
						{
							MyProject.Forms.frmCustomer.GetReturn();
						}
						MyProject.Forms.frmInformation.GetActivity();
						if (CloseForm)
						{
							Close();
							goto end_IL_0001;
						}
						_suppressComboChange = true;
						prepareForm(SaveNew: true);
						goto end_IL_0001_2;
					}
					case 2188:
						num = -1;
						switch (num2)
						{
						case 2:
							if (Operators.CompareString(Information.Err().Description, "Fatal error encountered during command execution.", TextCompare: false) != 0 && Operators.CompareString(Information.Err().Description, "The connection is not open.", TextCompare: false) != 0)
							{
								val.Rollback();
							}
							Module1.SaveError(Information.Err(), "frmSalesReturn", "SaveData", "");
							goto end_IL_0001_2;
						}
						break;
					}
					goto IL_08c2;
				}
				end_IL_0001_2:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 2188;
				continue;
			}
			break;
			IL_08c2:
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

	private void btnDelete_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					if (MessageBox.Show("Hapus Retur Penjualan?", "Konfirmasi", MessageBoxButtons.YesNo) != DialogResult.No)
					{
						cSalesInvoice cSalesInvoice2 = new cSalesInvoice(_currentId);
						cSalesInvoice2.CurrentItem = cSalesInvoice2.Item;
						cSalesInvoice2.CurrentDate = cSalesInvoice2.InvoiceDate;
						cSalesInvoice2.CurrentStorage = cSalesInvoice2.StorageId;
						cSalesInvoice2.Delete();
						string description = "menghapus retur penjualan " + cSalesInvoice2.Number + ". ID=" + Conversions.ToString(cSalesInvoice2.Id) + ", v2";
						cHistory cHistory2 = new cHistory();
						cHistory2.Description = description;
						cHistory2.UserId = Module1.pubUserId;
						cHistory2.UserLogin = Module1.pubLogin;
						cHistory2.fKeyId = _currentId;
						cHistory2.HistoryType = 20;
						cHistory2.Save();
						Interaction.MsgBox("Retur Penjualan berhasil dihapus", MsgBoxStyle.Information);
						MyProject.Forms.frmSalesReturnList.GetRecent();
						MyProject.Forms.frmInformation.GetActivity();
						Close();
					}
					goto end_IL_0001;
				case 316:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSalesReturn", "btnDelete_Click", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 316;
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

	private void btnHistory_Click(object sender, EventArgs e)
	{
		MyProject.Forms.frmHistory.GetHistory(checked((int)Math.Round(_currentId)), 20);
		MyProject.Forms.frmHistory.Show();
		MyProject.Forms.frmHistory.Activate();
		MyProject.Forms.frmHistory.WindowState = FormWindowState.Normal;
	}

	private void lblInformation_Click(object sender, EventArgs e)
	{
		MyProject.Forms.frmSalesInvoice.Show();
		MyProject.Forms.frmSalesInvoice.prepareForm(SaveNew: false);
		MyProject.Forms.frmSalesInvoice.CurrentId = _parentInvoiceId;
		MyProject.Forms.frmSalesInvoice.LoadData();
		MyProject.Forms.frmSalesInvoice.Activate();
		MyProject.Forms.frmSalesInvoice.WindowState = FormWindowState.Normal;
	}
}
