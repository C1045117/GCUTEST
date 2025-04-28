using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GCUv2.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

[DesignerGenerated]
public class frmPurchaseReturn : Form
{
	private IContainer components;

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
	[AccessedThroughProperty("txtDiscount")]
	private FilteredTextBox _txtDiscount;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboSupplier")]
	private ComboBox _cboSupplier;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TabControl1")]
	private TabControl _TabControl1;

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
	[AccessedThroughProperty("dgvPayment")]
	private DataGridView _dgvPayment;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnPayment")]
	private Button _btnPayment;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dtpInvoice")]
	private DateTimePicker _dtpInvoice;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboInvoiceCode")]
	private ComboBox _cboInvoiceCode;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("txtDeduction")]
	private FilteredTextBox _txtDeduction;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("lblInformation")]
	private Label _lblInformation;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnPrint")]
	private Button _btnPrint;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("txtCurrencyRate")]
	private FilteredTextBox _txtCurrencyRate;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboStorage")]
	private ComboBox _cboStorage;

	private double _currentId;

	private int _currentlySelectedComboIndex;

	private bool _suppressComboChange;

	private DateTime _paidDate;

	private double _parentInvoiceId;

	private DateTime _originalDate;

	private int _originalStorageId;

	private int _currencyId;

	private int _cashAccountId;

	private int _bankAccountId;

	private bool _edited;

	private cPurchaseInvoiceItem[] _item;

	private bool _disableDgvItem;

	private bool _justLoaded;

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

	[field: AccessedThroughProperty("TabPage4")]
	internal virtual TabPage TabPage4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual FilteredTextBox txtDiscount
	{
		[CompilerGenerated]
		get
		{
			return _txtDiscount;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = txtDiscount_Click;
			EventHandler value3 = txtDiscount_GotFocus;
			EventHandler value4 = txtDiscount_TextChanged;
			FilteredTextBox filteredTextBox = _txtDiscount;
			if (filteredTextBox != null)
			{
				filteredTextBox.Click -= value2;
				filteredTextBox.GotFocus -= value3;
				filteredTextBox.TextChanged -= value4;
			}
			_txtDiscount = value;
			filteredTextBox = _txtDiscount;
			if (filteredTextBox != null)
			{
				filteredTextBox.Click += value2;
				filteredTextBox.GotFocus += value3;
				filteredTextBox.TextChanged += value4;
			}
		}
	}

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox cboSupplier
	{
		[CompilerGenerated]
		get
		{
			return _cboSupplier;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cboSupplier_SelectedIndexChanged;
			ComboBox comboBox = _cboSupplier;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_cboSupplier = value;
			comboBox = _cboSupplier;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
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

	[field: AccessedThroughProperty("TabPage1")]
	internal virtual TabPage TabPage1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

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

	[field: AccessedThroughProperty("lblTotalReceivable")]
	internal virtual Label lblTotalReceivable
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

	[field: AccessedThroughProperty("lblSupplier")]
	internal virtual Label lblSupplier
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

	internal virtual ComboBox cboInvoiceCode
	{
		[CompilerGenerated]
		get
		{
			return _cboInvoiceCode;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cboInvoiceCode_SelectedIndexChanged;
			ComboBox comboBox = _cboInvoiceCode;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_cboInvoiceCode = value;
			comboBox = _cboInvoiceCode;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label15")]
	internal virtual Label Label15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTotalPaymentPlusDeduction")]
	internal virtual Label lblTotalPaymentPlusDeduction
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

	[field: AccessedThroughProperty("lblNumber")]
	internal virtual Label lblNumber
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

	[field: AccessedThroughProperty("lblCurrencyName")]
	internal virtual Label lblCurrencyName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual FilteredTextBox txtCurrencyRate
	{
		[CompilerGenerated]
		get
		{
			return _txtCurrencyRate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = txtCurrencyRate_TextChanged;
			FilteredTextBox filteredTextBox = _txtCurrencyRate;
			if (filteredTextBox != null)
			{
				filteredTextBox.TextChanged -= value2;
			}
			_txtCurrencyRate = value;
			filteredTextBox = _txtCurrencyRate;
			if (filteredTextBox != null)
			{
				filteredTextBox.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label17")]
	internal virtual Label Label17
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
		this.TabPage4 = new System.Windows.Forms.TabPage();
		this.Label7 = new System.Windows.Forms.Label();
		this.cboSupplier = new System.Windows.Forms.ComboBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.TabControl1 = new System.Windows.Forms.TabControl();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.btnItem = new System.Windows.Forms.Button();
		this.dgvItem = new System.Windows.Forms.DataGridView();
		this.TabPage2 = new System.Windows.Forms.TabPage();
		this.dgvPayment = new System.Windows.Forms.DataGridView();
		this.btnPayment = new System.Windows.Forms.Button();
		this.lblTotalReceivable = new System.Windows.Forms.Label();
		this.lblTotalPayment = new System.Windows.Forms.Label();
		this.lblTotalPrice = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.dtpInvoice = new System.Windows.Forms.DateTimePicker();
		this.Label5 = new System.Windows.Forms.Label();
		this.lblSupplier = new System.Windows.Forms.Label();
		this.Label16 = new System.Windows.Forms.Label();
		this.cboInvoiceCode = new System.Windows.Forms.ComboBox();
		this.Label15 = new System.Windows.Forms.Label();
		this.lblTotalPaymentPlusDeduction = new System.Windows.Forms.Label();
		this.Label14 = new System.Windows.Forms.Label();
		this.lblNumber = new System.Windows.Forms.Label();
		this.lblInformation = new System.Windows.Forms.Label();
		this.btnPrint = new System.Windows.Forms.Button();
		this.lblCurrencyName = new System.Windows.Forms.Label();
		this.Label17 = new System.Windows.Forms.Label();
		this.txtCurrencyRate = new GCUv2.FilteredTextBox();
		this.txtDeduction = new GCUv2.FilteredTextBox();
		this.txtDiscount = new GCUv2.FilteredTextBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.cboStorage = new System.Windows.Forms.ComboBox();
		this.TabControl1.SuspendLayout();
		this.TabPage1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvItem).BeginInit();
		this.TabPage2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvPayment).BeginInit();
		base.SuspendLayout();
		this.btnSaveClose.BackColor = System.Drawing.Color.WhiteSmoke;
		this.btnSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSaveClose.Location = new System.Drawing.Point(360, 491);
		this.btnSaveClose.Name = "btnSaveClose";
		this.btnSaveClose.Size = new System.Drawing.Size(93, 24);
		this.btnSaveClose.TabIndex = 152;
		this.btnSaveClose.Text = "Simpan && &Tutup";
		this.btnSaveClose.UseVisualStyleBackColor = false;
		this.btnHistory.BackColor = System.Drawing.Color.WhiteSmoke;
		this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnHistory.Location = new System.Drawing.Point(514, 491);
		this.btnHistory.Name = "btnHistory";
		this.btnHistory.Size = new System.Drawing.Size(50, 24);
		this.btnHistory.TabIndex = 154;
		this.btnHistory.Text = "&History";
		this.btnHistory.UseVisualStyleBackColor = false;
		this.btnDelete.BackColor = System.Drawing.Color.WhiteSmoke;
		this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDelete.Location = new System.Drawing.Point(459, 491);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new System.Drawing.Size(49, 24);
		this.btnDelete.TabIndex = 153;
		this.btnDelete.Text = "Hapus";
		this.btnDelete.UseVisualStyleBackColor = false;
		this.btnSave.BackColor = System.Drawing.Color.WhiteSmoke;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(268, 491);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(86, 24);
		this.btnSave.TabIndex = 151;
		this.btnSave.Text = "&Simpan && Baru";
		this.btnSave.UseVisualStyleBackColor = false;
		this.Label10.BackColor = System.Drawing.Color.Silver;
		this.Label10.Location = new System.Drawing.Point(-12, 484);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(713, 59);
		this.Label10.TabIndex = 152;
		this.lblRetur.AutoSize = true;
		this.lblRetur.Font = new System.Drawing.Font("Microsoft Sans Serif", 36f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblRetur.ForeColor = System.Drawing.Color.White;
		this.lblRetur.Location = new System.Drawing.Point(443, 9);
		this.lblRetur.Name = "lblRetur";
		this.lblRetur.Size = new System.Drawing.Size(195, 55);
		this.lblRetur.TabIndex = 151;
		this.lblRetur.Text = "RETUR";
		this.Label13.BackColor = System.Drawing.SystemColors.ButtonShadow;
		this.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Label13.Location = new System.Drawing.Point(18, 428);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(349, 1);
		this.Label13.TabIndex = 150;
		this.Label12.AutoSize = true;
		this.Label12.Location = new System.Drawing.Point(192, 458);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(70, 13);
		this.Label12.TabIndex = 149;
		this.Label12.Text = "Total Piutang";
		this.Label11.AutoSize = true;
		this.Label11.Location = new System.Drawing.Point(193, 386);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(93, 13);
		this.Label11.TabIndex = 148;
		this.Label11.Text = "Total Pembayaran";
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(16, 438);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(31, 13);
		this.Label9.TabIndex = 147;
		this.Label9.Text = "Total";
		this.lblTotalInvoice.Location = new System.Drawing.Point(79, 438);
		this.lblTotalInvoice.Name = "lblTotalInvoice";
		this.lblTotalInvoice.Size = new System.Drawing.Size(90, 13);
		this.lblTotalInvoice.TabIndex = 146;
		this.lblTotalInvoice.Text = "Total Invoice";
		this.lblTotalInvoice.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(14, 386);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(63, 13);
		this.Label8.TabIndex = 144;
		this.Label8.Text = "Total Harga";
		this.TabPage4.BackColor = System.Drawing.Color.DarkGray;
		this.TabPage4.Location = new System.Drawing.Point(4, 22);
		this.TabPage4.Name = "TabPage4";
		this.TabPage4.Size = new System.Drawing.Size(608, 204);
		this.TabPage4.TabIndex = 3;
		this.TabPage4.Text = "Lain-lain";
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.Location = new System.Drawing.Point(11, 18);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(45, 13);
		this.Label7.TabIndex = 137;
		this.Label7.Text = "Supplier";
		this.cboSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboSupplier.FormattingEnabled = true;
		this.cboSupplier.Location = new System.Drawing.Point(83, 15);
		this.cboSupplier.Name = "cboSupplier";
		this.cboSupplier.Size = new System.Drawing.Size(174, 21);
		this.cboSupplier.TabIndex = 0;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(11, 46);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(46, 13);
		this.Label1.TabIndex = 136;
		this.Label1.Text = "Tanggal";
		this.TabControl1.Controls.Add(this.TabPage1);
		this.TabControl1.Controls.Add(this.TabPage2);
		this.TabControl1.Controls.Add(this.TabPage4);
		this.TabControl1.Location = new System.Drawing.Point(13, 151);
		this.TabControl1.Name = "TabControl1";
		this.TabControl1.SelectedIndex = 0;
		this.TabControl1.Size = new System.Drawing.Size(616, 230);
		this.TabControl1.TabIndex = 130;
		this.TabPage1.Controls.Add(this.btnItem);
		this.TabPage1.Controls.Add(this.dgvItem);
		this.TabPage1.Location = new System.Drawing.Point(4, 22);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage1.Size = new System.Drawing.Size(608, 204);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = "Barang";
		this.TabPage1.UseVisualStyleBackColor = true;
		this.btnItem.BackColor = System.Drawing.SystemColors.ButtonFace;
		this.btnItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnItem.Location = new System.Drawing.Point(8, 8);
		this.btnItem.Name = "btnItem";
		this.btnItem.Size = new System.Drawing.Size(61, 24);
		this.btnItem.TabIndex = 4;
		this.btnItem.Text = "+ Barang";
		this.btnItem.UseVisualStyleBackColor = false;
		this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvItem.Location = new System.Drawing.Point(8, 38);
		this.dgvItem.Name = "dgvItem";
		this.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dgvItem.Size = new System.Drawing.Size(590, 160);
		this.dgvItem.TabIndex = 5;
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
		this.dgvPayment.Location = new System.Drawing.Point(9, 38);
		this.dgvPayment.Name = "dgvPayment";
		this.dgvPayment.Size = new System.Drawing.Size(590, 160);
		this.dgvPayment.TabIndex = 82;
		this.btnPayment.BackColor = System.Drawing.SystemColors.ButtonFace;
		this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnPayment.Location = new System.Drawing.Point(8, 8);
		this.btnPayment.Name = "btnPayment";
		this.btnPayment.Size = new System.Drawing.Size(85, 24);
		this.btnPayment.TabIndex = 6;
		this.btnPayment.Text = "+ Pembayaran";
		this.btnPayment.UseVisualStyleBackColor = false;
		this.lblTotalReceivable.Location = new System.Drawing.Point(276, 458);
		this.lblTotalReceivable.Name = "lblTotalReceivable";
		this.lblTotalReceivable.Size = new System.Drawing.Size(91, 20);
		this.lblTotalReceivable.TabIndex = 143;
		this.lblTotalReceivable.Text = "Total Receivable";
		this.lblTotalReceivable.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.lblTotalPayment.Location = new System.Drawing.Point(286, 386);
		this.lblTotalPayment.Name = "lblTotalPayment";
		this.lblTotalPayment.Size = new System.Drawing.Size(81, 21);
		this.lblTotalPayment.TabIndex = 142;
		this.lblTotalPayment.Text = "Total Payment";
		this.lblTotalPayment.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.lblTotalPrice.Location = new System.Drawing.Point(77, 386);
		this.lblTotalPrice.Name = "lblTotalPrice";
		this.lblTotalPrice.Size = new System.Drawing.Size(90, 13);
		this.lblTotalPrice.TabIndex = 140;
		this.lblTotalPrice.Text = "Total Price";
		this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.Location = new System.Drawing.Point(11, 72);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(53, 13);
		this.Label6.TabIndex = 139;
		this.Label6.Text = "No. Retur";
		this.dtpInvoice.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpInvoice.Location = new System.Drawing.Point(83, 43);
		this.dtpInvoice.Name = "dtpInvoice";
		this.dtpInvoice.Size = new System.Drawing.Size(121, 20);
		this.dtpInvoice.TabIndex = 1;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(15, 405);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(40, 13);
		this.Label5.TabIndex = 138;
		this.Label5.Text = "Diskon";
		this.lblSupplier.AutoSize = true;
		this.lblSupplier.Location = new System.Drawing.Point(80, 18);
		this.lblSupplier.Name = "lblSupplier";
		this.lblSupplier.Size = new System.Drawing.Size(55, 13);
		this.lblSupplier.TabIndex = 153;
		this.lblSupplier.Text = "lblSupplier";
		this.Label16.AutoSize = true;
		this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label16.Location = new System.Drawing.Point(10, 99);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(66, 13);
		this.Label16.TabIndex = 163;
		this.Label16.Text = "Tunai/Kredit";
		this.cboInvoiceCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboInvoiceCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboInvoiceCode.FormattingEnabled = true;
		this.cboInvoiceCode.Location = new System.Drawing.Point(83, 95);
		this.cboInvoiceCode.Name = "cboInvoiceCode";
		this.cboInvoiceCode.Size = new System.Drawing.Size(121, 21);
		this.cboInvoiceCode.TabIndex = 3;
		this.Label15.AutoSize = true;
		this.Label15.Location = new System.Drawing.Point(193, 438);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(31, 13);
		this.Label15.TabIndex = 173;
		this.Label15.Text = "Total";
		this.lblTotalPaymentPlusDeduction.Location = new System.Drawing.Point(274, 438);
		this.lblTotalPaymentPlusDeduction.Name = "lblTotalPaymentPlusDeduction";
		this.lblTotalPaymentPlusDeduction.Size = new System.Drawing.Size(93, 13);
		this.lblTotalPaymentPlusDeduction.TabIndex = 172;
		this.lblTotalPaymentPlusDeduction.Text = "Total Pay+Deduct";
		this.lblTotalPaymentPlusDeduction.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.Label14.AutoSize = true;
		this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label14.Location = new System.Drawing.Point(193, 405);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(53, 13);
		this.Label14.TabIndex = 171;
		this.Label14.Text = "Potongan";
		this.lblNumber.AutoSize = true;
		this.lblNumber.Location = new System.Drawing.Point(80, 72);
		this.lblNumber.Name = "lblNumber";
		this.lblNumber.Size = new System.Drawing.Size(54, 13);
		this.lblNumber.TabIndex = 174;
		this.lblNumber.Text = "lblNumber";
		this.lblInformation.AutoSize = true;
		this.lblInformation.Cursor = System.Windows.Forms.Cursors.Hand;
		this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
		this.lblInformation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
		this.lblInformation.Location = new System.Drawing.Point(373, 384);
		this.lblInformation.Name = "lblInformation";
		this.lblInformation.Size = new System.Drawing.Size(82, 15);
		this.lblInformation.TabIndex = 175;
		this.lblInformation.Text = "lblInformation";
		this.btnPrint.BackColor = System.Drawing.Color.WhiteSmoke;
		this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnPrint.Location = new System.Drawing.Point(570, 491);
		this.btnPrint.Name = "btnPrint";
		this.btnPrint.Size = new System.Drawing.Size(59, 24);
		this.btnPrint.TabIndex = 155;
		this.btnPrint.Text = "Preview";
		this.btnPrint.UseVisualStyleBackColor = false;
		this.lblCurrencyName.AutoSize = true;
		this.lblCurrencyName.Location = new System.Drawing.Point(240, 100);
		this.lblCurrencyName.Name = "lblCurrencyName";
		this.lblCurrencyName.Size = new System.Drawing.Size(60, 13);
		this.lblCurrencyName.TabIndex = 178;
		this.lblCurrencyName.Text = "Mata Uang";
		this.Label17.AutoSize = true;
		this.Label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label17.Location = new System.Drawing.Point(216, 100);
		this.Label17.Name = "Label17";
		this.Label17.Size = new System.Drawing.Size(28, 13);
		this.Label17.TabIndex = 177;
		this.Label17.Text = "Kurs";
		this.txtCurrencyRate.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtCurrencyRate.DontFormat = false;
		this.txtCurrencyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtCurrencyRate.Location = new System.Drawing.Point(289, 95);
		this.txtCurrencyRate.MaximumDigit = 3;
		this.txtCurrencyRate.Name = "txtCurrencyRate";
		this.txtCurrencyRate.Size = new System.Drawing.Size(121, 21);
		this.txtCurrencyRate.TabIndex = 4;
		this.txtCurrencyRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.txtDeduction.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtDeduction.DontFormat = false;
		this.txtDeduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtDeduction.Location = new System.Drawing.Point(283, 402);
		this.txtDeduction.MaximumDigit = 3;
		this.txtDeduction.Name = "txtDeduction";
		this.txtDeduction.Size = new System.Drawing.Size(84, 21);
		this.txtDeduction.TabIndex = 132;
		this.txtDeduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.txtDiscount.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtDiscount.DontFormat = false;
		this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtDiscount.Location = new System.Drawing.Point(80, 402);
		this.txtDiscount.MaximumDigit = 3;
		this.txtDiscount.Name = "txtDiscount";
		this.txtDiscount.Size = new System.Drawing.Size(87, 21);
		this.txtDiscount.TabIndex = 131;
		this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(11, 125);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(45, 13);
		this.Label4.TabIndex = 180;
		this.Label4.Text = "Gudang";
		this.cboStorage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboStorage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboStorage.FormattingEnabled = true;
		this.cboStorage.Location = new System.Drawing.Point(83, 122);
		this.cboStorage.Name = "cboStorage";
		this.cboStorage.Size = new System.Drawing.Size(121, 21);
		this.cboStorage.TabIndex = 5;
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Gray;
		base.ClientSize = new System.Drawing.Size(645, 522);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.cboStorage);
		base.Controls.Add(this.lblCurrencyName);
		base.Controls.Add(this.txtCurrencyRate);
		base.Controls.Add(this.Label17);
		base.Controls.Add(this.btnPrint);
		base.Controls.Add(this.lblInformation);
		base.Controls.Add(this.lblNumber);
		base.Controls.Add(this.Label15);
		base.Controls.Add(this.lblTotalPaymentPlusDeduction);
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
		base.Controls.Add(this.txtDiscount);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.cboSupplier);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.TabControl1);
		base.Controls.Add(this.lblTotalReceivable);
		base.Controls.Add(this.lblTotalPayment);
		base.Controls.Add(this.lblTotalPrice);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.dtpInvoice);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.lblSupplier);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmPurchaseReturn";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Retur Pembelian";
		this.TabControl1.ResumeLayout(false);
		this.TabPage1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgvItem).EndInit();
		this.TabPage2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgvPayment).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmPurchaseReturn()
	{
		base.KeyDown += frmPurchaseReturn_KeyDown;
		int try001b_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try001b_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					InitializeComponent();
					DoubleBuffered = true;
					base.MdiParent = MyProject.Forms.frmMenu;
					txtDiscount.AllowedCharacters = FilteredTextBox.InputType.NumeralsAndCurrency;
					txtDeduction.AllowedCharacters = FilteredTextBox.InputType.NumeralsAndCurrency;
					txtDiscount.MaximumDigit = 2;
					txtDeduction.MaximumDigit = 2;
					ComboBox combo = cboSupplier;
					cCombo.getSupplier(ref combo, Module1.pubGroupId, All: false, FlowerOnly: false, IncludeParent: false, Active: true);
					cboSupplier = combo;
					combo = cboInvoiceCode;
					cCombo.getInvoiceCode(ref combo, All: false);
					cboInvoiceCode = combo;
					combo = cboStorage;
					cCombo.getStorage(ref combo, Module1.pubGroupId, 0, "RETURN", blnAll: false, 1);
					cboStorage = combo;
					btnItem.Enabled = false;
					formatGrid();
					goto end_IL_001b;
				}
				case 263:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmPurchaseReturn", "New", "");
						goto end_IL_001b;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try001b_dispatch = 263;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_001b:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void frmPurchaseReturn_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void formatGrid()
	{
		dgvItem.Columns.Add("", "iiId");
		dgvItem.Columns.Add("", "itemId");
		dgvItem.Columns.Add("", "storageId");
		dgvItem.Columns.Add("", "Gudang");
		dgvItem.Columns.Add("", "Produk");
		dgvItem.Columns.Add("", "Jumlah");
		dgvItem.Columns.Add("", "Unit");
		dgvItem.Columns.Add("", "Jumlah");
		dgvItem.Columns.Add("", "Jml. (stok)");
		dgvItem.Columns.Add("", "Jml. (stok)");
		dgvItem.Columns.Add("", "Harga");
		dgvItem.Columns.Add("", "Total");
		dgvItem.Columns.Add("", "Teh GOPEK");
		dgvItem.Columns.Add("", "LongName");
		dgvItem.Columns.Add("", "Packaging");
		dgvItem.Columns.Add("", "Large Unit");
		dgvItem.Columns[0].Visible = false;
		dgvItem.Columns[1].Visible = false;
		dgvItem.Columns[2].Visible = false;
		dgvItem.Columns[3].Visible = false;
		dgvItem.Columns[4].Width = 80;
		dgvItem.Columns[5].Visible = false;
		dgvItem.Columns[6].Visible = false;
		dgvItem.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItem.Columns[7].Width = 80;
		dgvItem.Columns[8].Visible = false;
		dgvItem.Columns[9].Width = 80;
		dgvItem.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItem.Columns[10].Width = 80;
		dgvItem.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItem.Columns[11].Width = 80;
		dgvItem.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItem.Columns[12].Visible = false;
		dgvItem.Columns[13].Visible = false;
		dgvItem.Columns[14].Visible = false;
		dgvItem.Columns[15].Visible = false;
		dgvItem.RowHeadersVisible = false;
		dgvItem.AllowUserToAddRows = false;
		dgvItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvItem.ReadOnly = true;
		dgvItem.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvItem.AllowUserToResizeRows = false;
		dgvPayment.Columns.Add("payId", "payId");
		dgvPayment.Columns.Add("mpayId", "mpayId");
		dgvPayment.Columns.Add("pcId", "paymentCodeId");
		dgvPayment.Columns.Add("", "accountId");
		dgvPayment.Columns.Add("currencyId", "currencyId");
		dgvPayment.Columns.Add("paymentDate", "Tanggal");
		dgvPayment.Columns.Add("", "Tipe");
		dgvPayment.Columns.Add("", "cheqId");
		dgvPayment.Columns.Add("", "Tgl C/G");
		dgvPayment.Columns.Add("", "No C/G");
		dgvPayment.Columns.Add("", "BankId");
		dgvPayment.Columns.Add("", "BankName");
		dgvPayment.Columns.Add("", "Jumlah");
		dgvPayment.Columns.Add("", "Akun");
		dgvPayment.Columns.Add("", "Mata Uang");
		dgvPayment.Columns.Add("", "Kurs");
		dgvPayment.Columns.Add("", "CreatedDate");
		dgvPayment.Columns[0].Visible = false;
		dgvPayment.Columns[1].Visible = false;
		dgvPayment.Columns[2].Visible = false;
		dgvPayment.Columns[3].Visible = false;
		dgvPayment.Columns[4].Visible = false;
		dgvPayment.Columns[7].Visible = false;
		dgvPayment.Columns[10].Visible = false;
		dgvPayment.Columns[11].Visible = false;
		dgvPayment.Columns[16].Visible = false;
		dgvPayment.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvPayment.Columns[5].Width = 70;
		dgvPayment.Columns[6].Width = 40;
		dgvPayment.Columns[8].Width = 70;
		dgvPayment.Columns[8].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvPayment.Columns[9].Width = 80;
		dgvPayment.Columns[12].Width = 80;
		dgvPayment.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvPayment.Columns[13].Width = 100;
		dgvPayment.Columns[14].Width = 50;
		dgvPayment.Columns[15].Width = 50;
		dgvPayment.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvPayment.RowHeadersVisible = false;
		dgvPayment.AllowUserToAddRows = false;
		dgvPayment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvPayment.ReadOnly = true;
		dgvPayment.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvPayment.AllowUserToResizeRows = false;
	}

	public void prepareForm(bool SaveNew, bool KeepSupplier)
	{
		_disableDgvItem = false;
		_justLoaded = false;
		_currentId = 0.0;
		_parentInvoiceId = 0.0;
		_currentlySelectedComboIndex = -1;
		_item = null;
		if (!SaveNew)
		{
			dtpInvoice.Value = DateAndTime.Now;
		}
		_originalDate = DateAndTime.Now;
		_originalStorageId = 0;
		dgvItem.Rows.Clear();
		dgvPayment.Rows.Clear();
		lblSupplier.Text = "";
		lblSupplier.Visible = false;
		cboSupplier.Visible = true;
		lblCurrencyName.Text = "";
		if (!KeepSupplier)
		{
			cboSupplier.SelectedIndex = -1;
		}
		cboStorage.SelectedIndex = -1;
		cboInvoiceCode.SelectedIndex = -1;
		TabControl1.SelectedIndex = 0;
		lblNumber.Text = "auto";
		txtDiscount.Text = "";
		dtpInvoice.Enabled = true;
		cboInvoiceCode.Enabled = true;
		dgvItem.Enabled = true;
		dgvPayment.Enabled = true;
		txtDiscount.Enabled = true;
		txtDeduction.Enabled = true;
		btnItem.Enabled = true;
		btnPayment.Enabled = true;
		btnSave.Enabled = true;
		btnSaveClose.Enabled = true;
		btnDelete.Enabled = false;
		btnHistory.Enabled = false;
		btnPrint.Enabled = false;
		lblTotalPrice.Text = "";
		lblTotalInvoice.Text = "";
		lblTotalReceivable.Text = "";
		lblTotalPayment.Text = "";
		lblTotalPaymentPlusDeduction.Text = "";
		lblInformation.Text = "";
		cboStorage.Enabled = true;
		_edited = false;
		cboSupplier.Focus();
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
					cPurchaseInvoice cPurchaseInvoice2 = new cPurchaseInvoice(_currentId);
					if ((cPurchaseInvoice2.TotalPrice > 0.0) & !Module1.pubViewReportPurchaseInvoicePrice)
					{
						Interaction.MsgBox("Anda tidak bisa melihat faktur yang memiliki harga.");
						Close();
						goto end_IL_0001;
					}
					_item = cPurchaseInvoice2.Item;
					lblSupplier.Visible = true;
					cboSupplier.Visible = false;
					dgvItem.Rows.Clear();
					dgvPayment.Rows.Clear();
					DateTime createdDate = cPurchaseInvoice2.CreatedDate;
					if (DateAndTime.DateDiff(DateInterval.Day, createdDate, DateAndTime.Now) <= Module1.pubDaysLimit)
					{
						btnDelete.Enabled = true;
					}
					else
					{
						btnDelete.Enabled = false;
					}
					ComboBox cboSource = cboSupplier;
					Module1.comboBoundValue(ref cboSource, cPurchaseInvoice2.SupplierId);
					cboSupplier = cboSource;
					cboSource = cboInvoiceCode;
					Module1.comboBoundValue(ref cboSource, cPurchaseInvoice2.InvoiceCode);
					cboInvoiceCode = cboSource;
					cboSource = cboStorage;
					Module1.comboBoundValue(ref cboSource, cPurchaseInvoice2.StorageId);
					cboStorage = cboSource;
					lblSupplier.Text = cboSupplier.Text;
					_justLoaded = true;
					dtpInvoice.Value = cPurchaseInvoice2.InvoiceDate;
					_justLoaded = false;
					_originalDate = cPurchaseInvoice2.InvoiceDate;
					_originalStorageId = cPurchaseInvoice2.StorageId;
					lblNumber.Text = cPurchaseInvoice2.Number;
					_currencyId = cPurchaseInvoice2.CurrencyId;
					lblCurrencyName.Text = cPurchaseInvoice2.CurrencyName;
					txtCurrencyRate.Text = Conversions.ToString(cPurchaseInvoice2.CurrencyRate);
					txtDiscount.Text = Module1.formatCustomDecimal(Conversions.ToString(cPurchaseInvoice2.Discount * -1.0), 2);
					txtDeduction.Text = Module1.formatCustomDecimal(Conversions.ToString(cPurchaseInvoice2.Deduction * -1.0), 2);
					cPurchaseInvoiceItem[] item = cPurchaseInvoice2.Item;
					foreach (cPurchaseInvoiceItem cPurchaseInvoiceItem2 in item)
					{
						dgvItem.Rows.Add(cPurchaseInvoiceItem2.Id, cPurchaseInvoiceItem2.ItemId, 0, "", cPurchaseInvoiceItem2.ItemName, Module1.formatCustomDecimal(Conversions.ToString(cPurchaseInvoiceItem2.InvoiceQty), 3), cPurchaseInvoiceItem2.UnitName, Module1.formatCustomDecimal(Conversions.ToString(cPurchaseInvoiceItem2.InvoiceQty), 3) + " " + cPurchaseInvoiceItem2.UnitName, Module1.formatCustomDecimal(Conversions.ToString(cPurchaseInvoiceItem2.StockQty), 3), Module1.formatCustomDecimal(Conversions.ToString(cPurchaseInvoiceItem2.StockQty), 3) + " " + cPurchaseInvoiceItem2.BaseUnitName, Module1.formatCustomDecimal(Conversions.ToString(cPurchaseInvoiceItem2.Price), 2), Module1.formatCustomDecimal(Conversions.ToString(cPurchaseInvoiceItem2.Total), 2), cPurchaseInvoiceItem2.GeneralType, cPurchaseInvoiceItem2.LongName, cPurchaseInvoiceItem2.Packaging, cPurchaseInvoiceItem2.LargeUnit);
					}
					if (dgvItem.Rows.Count > 0)
					{
						dgvItem.CurrentRow.Selected = false;
					}
					calculateTotalPrice();
					cPurchaseInvoicePayment[] payment = cPurchaseInvoice2.Payment;
					foreach (cPurchaseInvoicePayment cPurchaseInvoicePayment2 in payment)
					{
						dgvPayment.Rows.Add(cPurchaseInvoicePayment2.PaymentId, cPurchaseInvoicePayment2.MultiPaymentId, cPurchaseInvoicePayment2.PaymentCodeId, cPurchaseInvoicePayment2.AccountId, cPurchaseInvoicePayment2.CurrencyId, cPurchaseInvoicePayment2.PaymentDate, cPurchaseInvoicePayment2.PaymentCodeName, cPurchaseInvoicePayment2.ChequeId, Interaction.IIf(Operators.CompareString(Strings.Right(cPurchaseInvoicePayment2.PaymentCodeName, 3), "C/G", TextCompare: false) == 0, cPurchaseInvoicePayment2.ChequeDate, ""), cPurchaseInvoicePayment2.ChequeNumber, 0, 0, Module1.formatCustomDecimal(Conversions.ToString(cPurchaseInvoicePayment2.Amount), 2), cPurchaseInvoicePayment2.AccountName, cPurchaseInvoicePayment2.CurrencyName, cPurchaseInvoicePayment2.CurrencyRate, cPurchaseInvoicePayment2.CreatedDate);
					}
					calculateTotalPayment();
					lblTotalPayment.Text = Module1.formatCustomDecimal(Conversions.ToString(cPurchaseInvoice2.TotalPayment * -1.0), 2);
					calculateTotalInvoice();
					if (cPurchaseInvoice2.ParentInvoiceId > 0.0)
					{
						_parentInvoiceId = cPurchaseInvoice2.ParentInvoiceId;
						lblInformation.Text = "Diperhitungkan di Faktur " + cPurchaseInvoice2.ParentInvoiceNumber;
						dtpInvoice.Enabled = false;
						cboInvoiceCode.Enabled = false;
						dgvItem.Enabled = false;
						dgvPayment.Enabled = false;
						txtDiscount.Enabled = false;
						txtDeduction.Enabled = false;
						btnSave.Enabled = false;
						btnSaveClose.Enabled = false;
						btnDelete.Enabled = false;
						btnItem.Enabled = false;
						btnPayment.Enabled = false;
						txtDiscount.Enabled = false;
						txtDeduction.Enabled = false;
					}
					else
					{
						lblInformation.Text = "";
					}
					btnPrint.Enabled = true;
					btnHistory.Enabled = true;
					if (DateAndTime.DateDiff(DateInterval.Day, dtpInvoice.Value, DateAndTime.Now) <= Module1.pubDaysLimit)
					{
						dtpInvoice.Enabled = true;
						cboStorage.Enabled = true;
						cboInvoiceCode.Enabled = true;
						btnItem.Enabled = true;
						_disableDgvItem = false;
						txtDiscount.Enabled = true;
					}
					else
					{
						dtpInvoice.Enabled = false;
						cboStorage.Enabled = false;
						cboInvoiceCode.Enabled = false;
						btnItem.Enabled = false;
						_disableDgvItem = true;
						txtDiscount.Enabled = false;
					}
					_edited = false;
					goto end_IL_0001;
				}
				case 1883:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmPurchaseReturn", "LoadData", "");
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
				try0001_dispatch = 1883;
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

	public void calculateTotalPrice()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		double num4 = default(double);
		bool flag = default(bool);
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
						int num3 = dgvItem.Rows.Count - 1;
						for (int i = 0; i <= num3; i++)
						{
							num4 += Conversions.ToDouble(dgvItem[11, i].Value);
							if (Operators.ConditionalCompareObjectNotEqual(dgvItem[5, i].Value, dgvItem[8, i].Value, TextCompare: false))
							{
								flag = true;
							}
						}
						if (flag)
						{
							dgvItem.Columns[9].Visible = true;
						}
						else
						{
							dgvItem.Columns[9].Visible = false;
						}
						lblTotalPrice.Text = Module1.formatCustomDecimal(Conversions.ToString(num4), 2);
						calculateTotalInvoice();
						goto end_IL_0001;
					}
					case 248:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmPurchaseReturn", "CalculateTotalPrice", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 248;
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
						int num3 = dgvPayment.Rows.Count - 1;
						for (int i = 0; i <= num3; i++)
						{
							num4 += Conversions.ToDouble(dgvPayment[12, i].Value);
							if (Operators.ConditionalCompareObjectGreater(dgvPayment[5, i].Value, _paidDate, TextCompare: false))
							{
								_paidDate = Conversions.ToDate(dgvPayment[5, i].Value);
							}
						}
						lblTotalPayment.Text = Module1.formatCustomDecimal(Conversions.ToString(num4), 2);
						calculateTotalInvoice();
						goto end_IL_0001;
					}
					case 204:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmPurchaseReturn", "CalculateTotalPayment", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 204;
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
					double num3 = Conversion.Val(Module1.unformatNumber(lblTotalPrice.Text)) - Conversion.Val(Module1.unformatNumber(txtDiscount.Text));
					lblTotalInvoice.Text = Module1.formatCustomDecimal(Conversions.ToString(num3), 2);
					double num4 = Conversion.Val(Module1.unformatNumber(lblTotalPayment.Text)) + Conversion.Val(Module1.unformatNumber(txtDeduction.Text));
					lblTotalPaymentPlusDeduction.Text = Module1.formatCustomDecimal(Conversions.ToString(num4), 2);
					double num5 = num3 - num4;
					lblTotalReceivable.Text = Module1.formatCustomDecimal(Conversions.ToString(num5), 2);
					goto end_IL_0001;
				}
				case 212:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmPurchaseReturn", "CalculateTotalInvoice", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 212;
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
		cComboItem cComboItem2 = (cComboItem)cboSupplier.SelectedItem;
		cComboItem cComboItem3 = (cComboItem)cboStorage.SelectedItem;
		if (cboSupplier.SelectedIndex > -1)
		{
			frmPurchaseReturnItem frmPurchaseReturnItem2 = new frmPurchaseReturnItem(CurrentData: false, Conversions.ToInteger(cComboItem2.Value), dtpInvoice.Value, Conversions.ToInteger(cComboItem3.Value));
			frmPurchaseReturnItem2.ShowDialog();
			frmPurchaseReturnItem2.Close();
			frmPurchaseReturnItem2.Dispose();
			calculateTotalPrice();
		}
	}

	private void dgvItem_GotFocus(object sender, EventArgs e)
	{
		if (dgvItem.Rows.Count == 0)
		{
			txtDiscount.Focus();
			return;
		}
		btnSave.NotifyDefault(value: false);
		if (dgvItem.RowCount > 0)
		{
			dgvItem.CurrentRow.Selected = true;
		}
	}

	private void dgvItem_LostFocus(object sender, EventArgs e)
	{
		btnSave.NotifyDefault(value: true);
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
			txtDiscount.Focus();
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
					if (_disableDgvItem)
					{
						Interaction.MsgBox("Barang tidak bisa diedit.", MsgBoxStyle.Information);
					}
					else if (dgvItem.Rows.Count > 0)
					{
						cComboItem cComboItem2 = (cComboItem)cboSupplier.SelectedItem;
						cComboItem cComboItem3 = (cComboItem)cboStorage.SelectedItem;
						frmPurchaseReturnItem frmPurchaseReturnItem2 = new frmPurchaseReturnItem(CurrentData: true, Conversions.ToInteger(cComboItem2.Value), dtpInvoice.Value, Conversions.ToInteger(cComboItem3.Value));
						frmPurchaseReturnItem2.item = _item;
						ComboBox cboSource = frmPurchaseReturnItem2.cboItem;
						Module1.comboBoundValue(ref cboSource, Conversions.ToDouble(dgvItem[1, dgvItem.CurrentRow.Index].Value));
						frmPurchaseReturnItem2.cboItem = cboSource;
						frmPurchaseReturnItem2.cboUnit.Text = Conversions.ToString(dgvItem[6, dgvItem.CurrentRow.Index].Value);
						frmPurchaseReturnItem2.txtQty.Text = Module1.formatCustomDecimal(Conversions.ToString(dgvItem[5, dgvItem.CurrentRow.Index].Value), 3);
						frmPurchaseReturnItem2.txtStockQty.Text = Module1.formatCustomDecimal(Conversions.ToString(dgvItem[8, dgvItem.CurrentRow.Index].Value), 3);
						frmPurchaseReturnItem2.txtPrice.Text = Module1.formatCustomDecimal(Conversions.ToString(dgvItem[10, dgvItem.CurrentRow.Index].Value), 2);
						frmPurchaseReturnItem2.ShowDialog();
					}
					goto end_IL_0001;
				case 487:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmPurchaseReturn", "OpenItem", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 487;
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
		frmPurchaseReturnPayment frmPurchaseReturnPayment2 = new frmPurchaseReturnPayment(CurrentData: false, _currencyId);
		frmPurchaseReturnPayment2.lblAmount.Text = "Jumlah (" + lblCurrencyName.Text + ")";
		frmPurchaseReturnPayment2.lblCurrencyRate.Text = "Kurs " + lblCurrencyName.Text;
		frmPurchaseReturnPayment2.CashAccountId = _cashAccountId;
		frmPurchaseReturnPayment2.BankAccountId = _bankAccountId;
		frmPurchaseReturnPayment2.ShowDialog();
		frmPurchaseReturnPayment2.Close();
		frmPurchaseReturnPayment2.Dispose();
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
			txtDiscount.Focus();
			e.SuppressKeyPress = true;
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			btnPayment.Focus();
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
					ProjectData.ClearProjectError();
					num2 = 2;
					if (dgvPayment.Rows.Count > 0 && Operators.ConditionalCompareObjectEqual(dgvPayment[1, dgvPayment.CurrentRow.Index].Value, 0, TextCompare: false))
					{
						frmPurchaseReturnPayment frmPurchaseReturnPayment2 = new frmPurchaseReturnPayment(CurrentData: true, _currencyId);
						frmPurchaseReturnPayment2.CashAccountId = _cashAccountId;
						frmPurchaseReturnPayment2.BankAccountId = _bankAccountId;
						frmPurchaseReturnPayment2.lblAmount.Text = "Jumlah (" + lblCurrencyName.Text + ")";
						frmPurchaseReturnPayment2.lblCurrencyRate.Text = "Kurs " + lblCurrencyName.Text;
						ComboBox cboSource = frmPurchaseReturnPayment2.cboPaymentCode;
						Module1.comboBoundValue(ref cboSource, Conversions.ToDouble(dgvPayment[2, dgvPayment.CurrentRow.Index].Value));
						frmPurchaseReturnPayment2.cboPaymentCode = cboSource;
						frmPurchaseReturnPayment2.dtpPayment.Value = Conversions.ToDate(dgvPayment[5, dgvPayment.CurrentRow.Index].Value);
						frmPurchaseReturnPayment2.txtAmount.Text = Module1.formatCustomDecimal(Conversions.ToString(dgvPayment[12, dgvPayment.CurrentRow.Index].Value), 2);
						if (Operators.ConditionalCompareObjectGreater(dgvPayment[7, dgvPayment.CurrentRow.Index].Value, 0, TextCompare: false))
						{
							frmPurchaseReturnPayment2.dtpCheque.Value = Conversions.ToDate(dgvPayment[8, dgvPayment.CurrentRow.Index].Value);
							frmPurchaseReturnPayment2.txtChequeNo.Text = Conversions.ToString(dgvPayment[9, dgvPayment.CurrentRow.Index].Value);
						}
						cboSource = frmPurchaseReturnPayment2.cboAccount;
						Module1.comboBoundValue(ref cboSource, Conversions.ToDouble(dgvPayment[3, dgvPayment.CurrentRow.Index].Value));
						frmPurchaseReturnPayment2.cboAccount = cboSource;
						frmPurchaseReturnPayment2.txtCurrencyRate.Text = Module1.formatCustomDecimal(Conversions.ToString(dgvPayment[15, dgvPayment.CurrentRow.Index].Value), 2);
						frmPurchaseReturnPayment2.ShowDialog();
					}
					else if (dgvPayment.Rows.Count > 0)
					{
						Interaction.MsgBox("Pembayaran hanya bisa dibuka di Form Pembayaran", MsgBoxStyle.Information);
					}
					goto end_IL_0001;
				case 719:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmPurchaseReturn", "OpenPayment", "");
						goto end_IL_0001;
					}
					break;
				}
				goto IL_0305;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 719;
				continue;
			}
			break;
			IL_0305:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void dgvReturn_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			txtDiscount.Focus();
			e.SuppressKeyPress = true;
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			TabControl1.Focus();
			e.SuppressKeyPress = true;
		}
	}

	private void cboSupplier_SelectedIndexChanged(object sender, EventArgs e)
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
					if (!_suppressComboChange)
					{
						if ((dgvItem.RowCount > 0) | (dgvPayment.RowCount > 0))
						{
							if (MessageBox.Show("Form akan di-reset karena anda mengganti Supplier. Lanjutkan?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.No)
							{
								_suppressComboChange = true;
								cboSupplier.SelectedIndex = _currentlySelectedComboIndex;
								goto end_IL_0001;
							}
							if ((_currentlySelectedComboIndex > -1) & (cboSupplier.SelectedIndex > -1))
							{
								prepareForm(SaveNew: true, KeepSupplier: true);
							}
						}
						if (cboSupplier.SelectedIndex > -1)
						{
							cComboItem cComboItem2 = (cComboItem)cboSupplier.SelectedItem;
							cSupplier cSupplier2 = new cSupplier(Conversions.ToInteger(cComboItem2.Value));
							_cashAccountId = Conversions.ToInteger(Interaction.IIf(cSupplier2.CashAccountId > 0, cSupplier2.CashAccountId, Module1.pubCashAccountId));
							_bankAccountId = Conversions.ToInteger(Interaction.IIf(cSupplier2.BankAccountId > 0, cSupplier2.BankAccountId, Module1.pubBankAccountId));
							lblCurrencyName.Text = cSupplier2.CurrencyName;
							_currencyId = cSupplier2.CurrencyId;
							txtCurrencyRate.Text = Module1.formatCustomDecimal(Conversions.ToString(cSupplier2.CurrencyRate), 2);
							if (cSupplier2.CurrencyId > 1)
							{
								txtCurrencyRate.Enabled = true;
							}
							else
							{
								txtCurrencyRate.Enabled = false;
							}
							btnItem.Enabled = true;
							_currentlySelectedComboIndex = cboSupplier.SelectedIndex;
							_edited = true;
						}
					}
					_suppressComboChange = false;
					goto end_IL_0001;
				case 500:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmPurchaseReturn", "cboSupplier_SelectedIndexChanged", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 500;
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

	private void cboStorage_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (dgvItem.RowCount > 0)
		{
			Interaction.MsgBox("Barang akan dihapus karena anda mengganti Gudang.", MsgBoxStyle.Information);
			dgvItem.Rows.Clear();
		}
	}

	private void txtDiscount_Click(object sender, EventArgs e)
	{
		txtDiscount.SelectionStart = 0;
		txtDiscount.SelectionLength = Strings.Len(txtDiscount.Text);
	}

	private void txtDiscount_GotFocus(object sender, EventArgs e)
	{
		txtDiscount.SelectionStart = 0;
		txtDiscount.SelectionLength = Strings.Len(txtDiscount.Text);
	}

	private void txtDiscount_TextChanged(object sender, EventArgs e)
	{
		calculateTotalInvoice();
		_edited = true;
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
		_edited = true;
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
		SaveData(CloseForm: false, OpenPrintPreview: false);
	}

	private void btnSaveClose_Click(object sender, EventArgs e)
	{
		SaveData(CloseForm: true, OpenPrintPreview: false);
	}

	private void SaveData(bool CloseForm, bool OpenPrintPreview)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
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
						cComboItem cComboItem2 = (cComboItem)cboInvoiceCode.SelectedItem;
						cComboItem cComboItem3 = (cComboItem)cboSupplier.SelectedItem;
						cComboItem cComboItem4 = (cComboItem)cboStorage.SelectedItem;
						if (cboSupplier.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih supplier", MsgBoxStyle.Information);
							cboSupplier.Focus();
							goto end_IL_0001;
						}
						if (cboInvoiceCode.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih Tunai/Kredit", MsgBoxStyle.Information);
							cboInvoiceCode.Focus();
							goto end_IL_0001;
						}
						if (cboStorage.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih Gudang.", MsgBoxStyle.Information);
							cboStorage.Focus();
							goto end_IL_0001;
						}
						if ((Operators.CompareString(lblTotalReceivable.Text, "0", TextCompare: false) != 0) & (Conversions.ToDouble(cComboItem2.Value) == 0.0))
						{
							Interaction.MsgBox("Kode Tunai tidak bisa dipilih karena faktur masih belum lunas", (MsgBoxStyle)(-2147483624));
							cboInvoiceCode.Focus();
							goto end_IL_0001;
						}
						if (dgvItem.Rows.Count == 0)
						{
							Interaction.MsgBox("Faktur harus memiliki produk", MsgBoxStyle.Information);
							btnItem.Focus();
							goto end_IL_0001;
						}
						if (Conversion.Val(txtDiscount.Text) != 0.0 && !Versioned.IsNumeric(txtDiscount.Text))
						{
							Interaction.MsgBox("Masukkan jumlah diskon dengan format angka yang benar", MsgBoxStyle.Information);
							txtDiscount.Focus();
							goto end_IL_0001;
						}
						if (Conversion.Val(txtDeduction.Text) != 0.0 && !Versioned.IsNumeric(txtDeduction.Text))
						{
							Interaction.MsgBox("Masukkan jumlah potongan dengan format angka yang benar", MsgBoxStyle.Information);
							txtDeduction.Focus();
							goto end_IL_0001;
						}
						if (Conversion.Val(Module1.unformatNumber(lblTotalReceivable.Text)) < 0.0)
						{
							Interaction.MsgBox("Nilai piutang tidak boleh negatif.", MsgBoxStyle.Information);
							goto end_IL_0001;
						}
						if ((Conversion.Val(txtDeduction.Text) > 0.0) & (dgvPayment.RowCount == 0))
						{
							Interaction.MsgBox("Potongan hanya bisa diisi jika ada minimum 1 pembayaran.", MsgBoxStyle.Information);
							txtDeduction.Focus();
						}
						else if ((Conversion.Val(txtDeduction.Text) > 0.0) & (Conversion.Val(lblTotalReceivable.Text) > 0.0))
						{
							Interaction.MsgBox("Potongan tidak bisa diisi karena Faktur masih belum lunas.", MsgBoxStyle.Information);
							txtDeduction.Focus();
						}
						cPurchaseInvoice cPurchaseInvoice2 = new cPurchaseInvoice(CurrentId);
						cPurchaseInvoiceItem[] array = new cPurchaseInvoiceItem[dgvItem.Rows.Count - 1 + 1];
						cPurchaseInvoicePayment[] array2 = new cPurchaseInvoicePayment[dgvPayment.Rows.Count - 1 + 1];
						int num3 = 0;
						cPurchaseInvoice2.CurrentItem = cPurchaseInvoice2.Item;
						cPurchaseInvoice2.CurrentDate = cPurchaseInvoice2.InvoiceDate;
						cPurchaseInvoice2.isReturn = 1;
						cPurchaseInvoice2.SupplierId = Conversions.ToInteger(cComboItem3.Value);
						cPurchaseInvoice2.Number = lblNumber.Text;
						cPurchaseInvoice2.InvoiceDate = dtpInvoice.Value;
						cPurchaseInvoice2.InvoiceCode = Conversions.ToInteger(cComboItem2.Value);
						cPurchaseInvoice2.CurrencyId = _currencyId;
						cPurchaseInvoice2.CurrencyRate = Conversion.Val(Module1.unformatNumber(txtCurrencyRate.Text));
						cPurchaseInvoice2.Discount = Conversion.Val(Module1.unformatNumber(txtDiscount.Text));
						cPurchaseInvoice2.TotalPrice = 0.0;
						cPurchaseInvoice2.TotalReturn = Conversion.Val(Module1.unformatNumber(lblTotalPrice.Text));
						cPurchaseInvoice2.Deduction = Conversion.Val(Module1.unformatNumber(txtDeduction.Text));
						cPurchaseInvoice2.TotalPayment = Conversion.Val(Module1.unformatNumber(lblTotalPayment.Text));
						cPurchaseInvoice2.StorageId = Conversions.ToInteger(cComboItem4.Value);
						if (Conversion.Val(Module1.unformatNumber(lblTotalReceivable.Text)) <= 0.0)
						{
							cPurchaseInvoice2.PaidDate = _paidDate;
						}
						else
						{
							cPurchaseInvoice2.PaidDate = new DateTime(1, 1, 1);
						}
						cPurchaseInvoice2.isReturn = 1;
						string text = "";
						int num4 = dgvItem.Rows.Count - 1;
						for (num3 = 0; num3 <= num4; num3++)
						{
							array[num3] = new cPurchaseInvoiceItem();
							array[num3].ItemId = Conversions.ToInteger(dgvItem[1, num3].Value);
							array[num3].StorageId = Conversions.ToInteger(cComboItem4.Value);
							array[num3].InvoiceQty = Conversions.ToDouble(dgvItem[5, num3].Value);
							array[num3].StockQty = Conversions.ToDouble(dgvItem[8, num3].Value);
							array[num3].NetQty = Conversions.ToDouble(dgvItem[5, num3].Value);
							array[num3].Price = Conversions.ToDouble(dgvItem[10, num3].Value);
							array[num3].CurrencyId = _currencyId;
							array[num3].CurrencyRate = Conversion.Val(Module1.unformatNumber(txtCurrencyRate.Text));
							array[num3].UnitName = Conversions.ToString(dgvItem[6, num3].Value);
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<tr><td>", dgvItem[4, num3].Value), "</td>"), "<td align='right'>"), dgvItem[7, num3].Value), "</td>"), "<td align='right'>"), dgvItem[9, num3].Value), "</td>"), "<td align='right'>"), Module1.formatCustomDecimal(Conversions.ToString(dgvItem[10, num3].Value), 2)), "</td>"), "<td align='right'>"), Module1.formatCustomDecimal(Conversions.ToString(dgvItem[11, num3].Value), 2)), "</td></tr>")));
						}
						cPurchaseInvoice2.Item = array;
						string text2 = "";
						int num5 = dgvPayment.Rows.Count - 1;
						for (num3 = 0; num3 <= num5; num3++)
						{
							array2[num3] = new cPurchaseInvoicePayment();
							array2[num3].PaymentDate = Conversions.ToDate(dgvPayment[5, num3].Value);
							array2[num3].Amount = Conversions.ToDouble(dgvPayment[12, num3].Value);
							array2[num3].PaymentCodeId = Conversions.ToByte(dgvPayment[2, num3].Value);
							array2[num3].MultiPaymentId = Conversions.ToDouble(dgvPayment[1, num3].Value);
							array2[num3].CreatedDate = Conversions.ToDate(dgvPayment[16, num3].Value);
							array2[num3].PaymentCodeName = Conversions.ToString(dgvPayment[6, num3].Value);
							array2[num3].CurrencyId = Conversions.ToInteger(dgvPayment[4, num3].Value);
							array2[num3].CurrencyRate = Conversions.ToDouble(dgvPayment[15, num3].Value);
							array2[num3].AccountId = Conversions.ToInteger(dgvPayment[3, num3].Value);
							if (Operators.ConditionalCompareObjectEqual(dgvPayment[6, num3].Value, "C/G", TextCompare: false))
							{
								array2[num3].ChequeDate = Conversions.ToDate(dgvPayment[8, num3].Value);
								array2[num3].ChequeNumber = Conversions.ToString(dgvPayment[9, num3].Value);
							}
							text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<tr><td>", dgvPayment[5, num3].Value), "</td>"), "<td>"), dgvPayment[6, num3].Value), "</td>"), "<td>"), dgvPayment[8, num3].Value), "</td>"), "<td>"), dgvPayment[9, num3].Value), "</td>"), "<td align='right'>"), Module1.formatCustomDecimal(Conversions.ToString(dgvPayment[12, num3].Value), 2)), "</td>"), "<td>"), dgvPayment[13, num3].Value), "</td>"), "<td>"), dgvPayment[14, num3].Value), "</td>"), "<td align='right'>"), Module1.formatCustomDecimal(Conversions.ToString(dgvPayment[15, num3].Value), 2)), "</td></tr>")));
						}
						cPurchaseInvoice2.Payment = array2;
						cPurchaseInvoice2.Save();
						lblNumber.Text = cPurchaseInvoice2.Number;
						string text3 = "Tanggal: " + Conversions.ToString(dtpInvoice.Value) + "<br />No Faktur: " + lblNumber.Text + "<br />Mata Uang: " + lblCurrencyName.Text + "<br />Kurs: " + txtCurrencyRate.Text + "<br />Gudang: " + cboStorage.Text + "<br />Discount: " + txtDiscount.Text + "<br />Potongan: " + txtDeduction.Text + "<br />";
						text3 += "Produk:<br />";
						text3 += "<table>";
						text3 += "<tr><td>Produk</td><td>Jumlah</td><td>Jml. (stok)</td><td>Harga</td><td>Total</td></tr>";
						text3 += text;
						text3 += "</table><br />";
						text3 += "<table>";
						text3 += "<tr><td>Tanggal</td><td>Tipe</td><td>Tgl C/G</td><td>No C/G</td><td>Jumlah</td><td>Akun</td><td>Mata Uang</td><td>Kurs</td></tr>";
						text3 += text2;
						text3 += "</table></br />";
						string text4;
						if (_currentId == 0.0)
						{
							text4 = "membuat ";
							_currentId = cPurchaseInvoice2.Id;
						}
						else
						{
							text4 = "mengupdate ";
						}
						text4 = text4 + "retur pembelian " + lblNumber.Text + " tanggal " + Strings.Format(dtpInvoice.Value, "dd/MM/yyyy") + ". ID= " + Conversions.ToString(_currentId) + ", v2";
						cHistory cHistory2 = new cHistory();
						cHistory2.Content = text3;
						cHistory2.Description = text4;
						cHistory2.UserId = Module1.pubUserId;
						cHistory2.UserLogin = Module1.pubLogin;
						cHistory2.fKeyId = CurrentId;
						cHistory2.HistoryType = 21;
						cHistory2.Save();
						Interaction.MsgBox("Retur Pembelian berhasil disimpan", MsgBoxStyle.Information);
						if (Module1.FormIsOpen("frmPurchaseReturnList"))
						{
							MyProject.Forms.frmPurchaseReturnList.GetRecent();
						}
						if (Module1.FormIsOpen("frmSupplier"))
						{
							MyProject.Forms.frmSupplier.GetReturn();
						}
						MyProject.Forms.frmInformation.GetActivity();
						_edited = false;
						if (CloseForm)
						{
							Close();
						}
						else if (!OpenPrintPreview)
						{
							_suppressComboChange = true;
							prepareForm(SaveNew: true, KeepSupplier: false);
						}
						else if (!OpenPrintPreview)
						{
						}
						goto end_IL_0001_2;
					}
					case 3490:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmPurchaseReturn", "SaveData", "");
							goto end_IL_0001_2;
						}
						break;
					}
					goto IL_0dd8;
				}
				end_IL_0001_2:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 3490;
				continue;
			}
			break;
			IL_0dd8:
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
					if (MessageBox.Show("Hapus Retur Pembelian?", "Konfirmasi", MessageBoxButtons.YesNo) != DialogResult.No)
					{
						cPurchaseInvoice cPurchaseInvoice2 = new cPurchaseInvoice(_currentId);
						cPurchaseInvoice2.CurrentItem = cPurchaseInvoice2.Item;
						cPurchaseInvoice2.CurrentDate = cPurchaseInvoice2.InvoiceDate;
						cPurchaseInvoice2.Delete();
						string description = "menghapus retur pembelian " + cPurchaseInvoice2.Number + ". ID=" + Conversions.ToString(cPurchaseInvoice2.Id) + ", v2";
						cHistory cHistory2 = new cHistory();
						cHistory2.Description = description;
						cHistory2.UserId = Module1.pubUserId;
						cHistory2.UserLogin = Module1.pubLogin;
						cHistory2.fKeyId = _currentId;
						cHistory2.HistoryType = 21;
						cHistory2.Save();
						Interaction.MsgBox("Retur Pembelian berhasil dihapus", MsgBoxStyle.Information);
						if (Module1.FormIsOpen("frmPurchaseReturnList"))
						{
							MyProject.Forms.frmPurchaseReturnList.GetRecent();
						}
						MyProject.Forms.frmInformation.GetActivity();
						Close();
					}
					goto end_IL_0001;
				case 321:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmPurchaseReturn", "btnDelete_Click", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 321;
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
		MyProject.Forms.frmHistory.GetHistory(checked((int)Math.Round(_currentId)), 21);
		MyProject.Forms.frmHistory.Show();
		MyProject.Forms.frmHistory.Activate();
		MyProject.Forms.frmHistory.WindowState = FormWindowState.Normal;
	}

	private void lblInformation_Click(object sender, EventArgs e)
	{
		MyProject.Forms.frmPurchaseInvoice.Show();
		MyProject.Forms.frmPurchaseInvoice.prepareForm(SaveNew: false, KeepSupplier: false);
		MyProject.Forms.frmPurchaseInvoice.CurrentId = _parentInvoiceId;
		MyProject.Forms.frmPurchaseInvoice.LoadData();
		MyProject.Forms.frmPurchaseInvoice.Activate();
		MyProject.Forms.frmPurchaseInvoice.WindowState = FormWindowState.Normal;
	}

	private void btnPrint_Click(object sender, EventArgs e)
	{
		if (_edited && btnSave.Enabled)
		{
			if (MessageBox.Show("Anda melakukan perubahan data.\r\nSimpan Retur Pembelian sebelum mencetak?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				SaveData(CloseForm: false, OpenPrintPreview: true);
			}
			return;
		}
		frmPurchaseReturnPrint frmPurchaseReturnPrint2 = new frmPurchaseReturnPrint();
		cPrintSetting cPrintSetting2 = new cPrintSetting(1);
		frmPurchaseReturnPrint2.lblDateCommercial.Text = Strings.Format(dtpInvoice.Value, "d MMMM yyyy");
		frmPurchaseReturnPrint2.lblNameCommercial.Text = cboSupplier.Text;
		frmPurchaseReturnPrint2.lblAddressCommercial.Visible = false;
		frmPurchaseReturnPrint2.lblInvoiceNoCommercial.Text = "No. Faktur: " + lblNumber.Text;
		frmPurchaseReturnPrint2.lblTotalPriceCommercial.Text = lblTotalPrice.Text;
		frmPurchaseReturnPrint2.lblDiscountValueCommercial.Text = txtDiscount.Text;
		if (Conversion.Val(txtDiscount.Text) > 0.0)
		{
			frmPurchaseReturnPrint2.lblDiscount.Visible = true;
		}
		else
		{
			frmPurchaseReturnPrint2.lblDiscount.Visible = false;
		}
		frmPurchaseReturnPrint2.lblDeductionCommercial.Text = txtDeduction.Text;
		frmPurchaseReturnPrint2.lblTotalPaymentCommercial.Text = Module1.formatCustomDecimal(Conversions.ToString(Conversions.ToDouble(Module1.unformatNumber(lblTotalInvoice.Text)) - Conversions.ToDouble(Module1.unformatNumber(txtDeduction.Text))), 2);
		checked
		{
			int num = dgvItem.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				string left = ((!Operators.ConditionalCompareObjectNotEqual(dgvItem[12, i].Value, "", TextCompare: false)) ? "" : Conversions.ToString(Operators.ConcatenateObject(dgvItem[12, i].Value, " ")));
				left = ((!Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(dgvItem[13, i].Value, "", TextCompare: false), Operators.CompareObjectEqual(dgvItem[13, i].Value, "-", TextCompare: false)))) ? Conversions.ToString(Operators.ConcatenateObject(left, dgvItem[13, i].Value)) : Conversions.ToString(Operators.ConcatenateObject(left, dgvItem[4, i].Value)));
				frmPurchaseReturnPrint2.dgvItemCommercial.Rows.Add(i + 1, left, dgvItem[14, i].Value, Operators.ConcatenateObject(Module1.formatCustomDecimal(Conversions.ToString(dgvItem[5, i].Value), 3) + " ", dgvItem[15, i].Value), Module1.formatCustomDecimal(Conversions.ToString(dgvItem[10, i].Value), 2), Module1.formatCustomDecimal(Conversions.ToString(dgvItem[11, i].Value), 2));
			}
			cPurchaseInvoice cPurchaseInvoice2 = new cPurchaseInvoice(_parentInvoiceId);
			frmPurchaseReturnPrint2.lblPurchaseReturnNo.Text = Strings.Right(Conversions.ToString(cPurchaseInvoice2.TaxInvoiceDate), 2) + "." + lblNumber.Text;
			frmPurchaseReturnPrint2.lblPurchaseReturnDate.Text = Strings.Format(dtpInvoice.Value, "d MMMM yyyy");
			frmPurchaseReturnPrint2.lblTaxInvoiceNo.Text = cPrintSetting2.TaxNumber + Strings.Right(Conversions.ToString(cPurchaseInvoice2.TaxInvoiceDate), 2) + "." + cPurchaseInvoice2.TaxNumber;
			frmPurchaseReturnPrint2.lblTaxInvoiceDate.Text = Strings.Format(cPurchaseInvoice2.TaxInvoiceDate, "d MMMM yyyy");
			int num2 = dgvItem.Rows.Count - 1;
			double num5 = default(double);
			for (int i = 0; i <= num2; i++)
			{
				string left = ((!Operators.ConditionalCompareObjectNotEqual(dgvItem[12, i].Value, "", TextCompare: false)) ? "" : Conversions.ToString(Operators.ConcatenateObject(dgvItem[12, i].Value, " ")));
				left = ((!Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(dgvItem[13, i].Value, "", TextCompare: false), Operators.CompareObjectEqual(dgvItem[13, i].Value, "-", TextCompare: false)))) ? Conversions.ToString(Operators.ConcatenateObject(left, dgvItem[13, i].Value)) : Conversions.ToString(Operators.ConcatenateObject(left, dgvItem[4, i].Value)));
				double num3 = Conversion.Val(Module1.unformatNumber(Conversions.ToString(dgvItem[10, i].Value))) / 1.1;
				Math.Round(num3, 0, MidpointRounding.AwayFromZero);
				double num4 = num3 * Conversion.Val(Module1.unformatNumber(Conversions.ToString(dgvItem[5, i].Value)));
				num5 += Math.Round(num4, 0, MidpointRounding.AwayFromZero);
				frmPurchaseReturnPrint2.dgvItemTax.Rows.Add(i + 1, left, Operators.ConcatenateObject(Module1.formatCustomDecimal(Conversions.ToString(dgvItem[5, i].Value), 3) + " ", dgvItem[15, i].Value), Module1.formatCustomDecimal(Conversions.ToString(num3), 0), "", Module1.formatCustomDecimal(Conversions.ToString(num4), 0));
			}
			short num6 = (short)DateTime.Compare(t2: new DateTime(2022, 4, 1), t1: dtpInvoice.Value.Date);
			double num7 = ((num6 >= 0) ? 1.11 : 1.1);
			double num8 = Conversions.ToDouble(Module1.unformatNumber(lblTotalPrice.Text)) - Conversions.ToDouble(Module1.unformatNumber(txtDiscount.Text));
			double number = num8 / num7;
			number = Module1.RoundMoney(number);
			double num9 = num8 - number;
			frmPurchaseReturnPrint2.lblDPP.Text = Module1.formatCustomDecimal(Conversions.ToString(number), 2);
			frmPurchaseReturnPrint2.lblPPN.Text = Module1.formatCustomDecimal(Conversions.ToString(num9), 2);
			if (_parentInvoiceId > 0.0)
			{
				frmPurchaseReturnPrint2.btnPrintTax.Enabled = true;
				frmPurchaseReturnPrint2.lblInformation.Visible = false;
			}
			else
			{
				frmPurchaseReturnPrint2.btnPrintTax.Enabled = false;
				frmPurchaseReturnPrint2.lblInformation.Visible = true;
			}
			frmPurchaseReturnPrint2.ShowDialog();
			frmPurchaseReturnPrint2.Close();
			frmPurchaseReturnPrint2.Dispose();
		}
	}

	private void dtpInvoice_ValueChanged(object sender, EventArgs e)
	{
		if (!_justLoaded & (DateAndTime.DateDiff(DateInterval.Day, dtpInvoice.Value, DateAndTime.Now) > Module1.pubDaysLimit))
		{
			Interaction.MsgBox("Anda tidak bisa membuat Retur Pembelian sebelum " + Strings.FormatDateTime(DateAndTime.Now.AddDays(checked(Module1.pubDaysLimit * -1)), DateFormat.ShortDate), MsgBoxStyle.Information);
			dtpInvoice.Value = DateAndTime.Now;
		}
		_edited = true;
	}

	private void cboInvoiceCode_SelectedIndexChanged(object sender, EventArgs e)
	{
		_edited = true;
	}

	private void txtCurrencyRate_TextChanged(object sender, EventArgs e)
	{
		_edited = true;
	}
}
