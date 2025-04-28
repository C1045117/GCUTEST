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
public class frmPurchaseInvoice : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dtpInvoice")]
	private DateTimePicker _dtpInvoice;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("txtDiscount")]
	private FilteredTextBox _txtDiscount;

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
	[AccessedThroughProperty("btnPayment")]
	private Button _btnPayment;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvReturn")]
	private DataGridView _dgvReturn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvPayment")]
	private DataGridView _dgvPayment;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnHistory")]
	private Button _btnHistory;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSaveClose")]
	private Button _btnSaveClose;

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
	[AccessedThroughProperty("cboSupplier")]
	private ComboBox _cboSupplier;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dtpTaxInvoice")]
	private DateTimePicker _dtpTaxInvoice;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("txtDeduction")]
	private FilteredTextBox _txtDeduction;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnReceivedItem")]
	private Button _btnReceivedItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboStorage")]
	private ComboBox _cboStorage;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("chkPPN")]
	private CheckBox _chkPPN;

	private double _currentId;

	private int _currentlySelectedComboIndex;

	private bool _suppressComboChange;

	private DateTime _paidDate;

	private bool _hasNPWP;

	private double[] _riId;

	private int _currencyId;

	private bool _disableDgvItem;

	private int _cashAccountId;

	private int _bankAccountId;

	private bool _justLoaded;

	private string _addDailyTotalSql;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
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

	[field: AccessedThroughProperty("txtInvoiceNo")]
	internal virtual TextBox txtInvoiceNo
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

	[field: AccessedThroughProperty("lblTotalReturn")]
	internal virtual Label lblTotalReturn
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

	[field: AccessedThroughProperty("TabPage3")]
	internal virtual TabPage TabPage3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView dgvReturn
	{
		[CompilerGenerated]
		get
		{
			return _dgvReturn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = dgvReturn_DoubleClick;
			EventHandler value3 = dgvReturn_GotFocus;
			EventHandler value4 = dgvReturn_LostFocus;
			KeyEventHandler value5 = dgvReturn_KeyDown;
			DataGridViewCellEventHandler value6 = dgvReturn_CellContentClick;
			DataGridViewCellEventHandler value7 = dgvReturn_CellContentDoubleClick;
			DataGridView dataGridView = _dgvReturn;
			if (dataGridView != null)
			{
				dataGridView.DoubleClick -= value2;
				dataGridView.GotFocus -= value3;
				dataGridView.LostFocus -= value4;
				dataGridView.KeyDown -= value5;
				dataGridView.CellContentClick -= value6;
				dataGridView.CellContentDoubleClick -= value7;
			}
			_dgvReturn = value;
			dataGridView = _dgvReturn;
			if (dataGridView != null)
			{
				dataGridView.DoubleClick += value2;
				dataGridView.GotFocus += value3;
				dataGridView.LostFocus += value4;
				dataGridView.KeyDown += value5;
				dataGridView.CellContentClick += value6;
				dataGridView.CellContentDoubleClick += value7;
			}
		}
	}

	[field: AccessedThroughProperty("TabPage4")]
	internal virtual TabPage TabPage4
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

	[field: AccessedThroughProperty("lblTotalInvoice")]
	internal virtual Label lblTotalInvoice
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

	[field: AccessedThroughProperty("Label13")]
	internal virtual Label Label13
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

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
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

	[field: AccessedThroughProperty("cboInvoiceCode")]
	internal virtual ComboBox cboInvoiceCode
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTaxInvoiceNo")]
	internal virtual TextBox txtTaxInvoiceNo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTaxNumber")]
	internal virtual Label lblTaxNumber
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTaxDate")]
	internal virtual Label lblTaxDate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DateTimePicker dtpTaxInvoice
	{
		[CompilerGenerated]
		get
		{
			return _dtpTaxInvoice;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = dtpTaxInvoice_ValueChanged;
			DateTimePicker dateTimePicker = _dtpTaxInvoice;
			if (dateTimePicker != null)
			{
				dateTimePicker.ValueChanged -= value2;
			}
			_dtpTaxInvoice = value;
			dateTimePicker = _dtpTaxInvoice;
			if (dateTimePicker != null)
			{
				dateTimePicker.ValueChanged += value2;
			}
		}
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

	[field: AccessedThroughProperty("Label18")]
	internal virtual Label Label18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnReceivedItem
	{
		[CompilerGenerated]
		get
		{
			return _btnReceivedItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnReceivedItem_Click;
			Button button = _btnReceivedItem;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnReceivedItem = value;
			button = _btnReceivedItem;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("txtCurrencyRate")]
	internal virtual FilteredTextBox txtCurrencyRate
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

	[field: AccessedThroughProperty("lblCurrencyName")]
	internal virtual Label lblCurrencyName
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

	[field: AccessedThroughProperty("lblPaidDate")]
	internal virtual Label lblPaidDate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTaxDateDash")]
	internal virtual Label lblTaxDateDash
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTaxNumberDash")]
	internal virtual Label lblTaxNumberDash
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPPN2")]
	internal virtual Label lblPPN2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblSubTotalPrice2")]
	internal virtual Label lblSubTotalPrice2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPPN")]
	internal virtual Label lblPPN
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblSubTotalPrice")]
	internal virtual Label lblSubTotalPrice
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label20")]
	internal virtual Label Label20
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual CheckBox chkPPN
	{
		[CompilerGenerated]
		get
		{
			return _chkPPN;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = chkPPN_CheckedChanged;
			CheckBox checkBox = _chkPPN;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value2;
			}
			_chkPPN = value;
			checkBox = _chkPPN;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value2;
			}
		}
	}

	public double[] RIId
	{
		get
		{
			return _riId;
		}
		set
		{
			_riId = value;
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
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		this.Label1 = new System.Windows.Forms.Label();
		this.dtpInvoice = new System.Windows.Forms.DateTimePicker();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.txtInvoiceNo = new System.Windows.Forms.TextBox();
		this.lblTotalPrice = new System.Windows.Forms.Label();
		this.lblTotalReturn = new System.Windows.Forms.Label();
		this.lblTotalPayment = new System.Windows.Forms.Label();
		this.lblTotalPayable = new System.Windows.Forms.Label();
		this.TabControl1 = new System.Windows.Forms.TabControl();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.btnReceivedItem = new System.Windows.Forms.Button();
		this.btnItem = new System.Windows.Forms.Button();
		this.dgvItem = new System.Windows.Forms.DataGridView();
		this.TabPage2 = new System.Windows.Forms.TabPage();
		this.dgvPayment = new System.Windows.Forms.DataGridView();
		this.btnPayment = new System.Windows.Forms.Button();
		this.TabPage3 = new System.Windows.Forms.TabPage();
		this.dgvReturn = new System.Windows.Forms.DataGridView();
		this.TabPage4 = new System.Windows.Forms.TabPage();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.Label9 = new System.Windows.Forms.Label();
		this.lblTotalInvoice = new System.Windows.Forms.Label();
		this.Label11 = new System.Windows.Forms.Label();
		this.Label12 = new System.Windows.Forms.Label();
		this.Label13 = new System.Windows.Forms.Label();
		this.btnHistory = new System.Windows.Forms.Button();
		this.btnSaveClose = new System.Windows.Forms.Button();
		this.btnDelete = new System.Windows.Forms.Button();
		this.btnSave = new System.Windows.Forms.Button();
		this.Label10 = new System.Windows.Forms.Label();
		this.cboSupplier = new System.Windows.Forms.ComboBox();
		this.Label7 = new System.Windows.Forms.Label();
		this.lblSupplier = new System.Windows.Forms.Label();
		this.Label16 = new System.Windows.Forms.Label();
		this.cboInvoiceCode = new System.Windows.Forms.ComboBox();
		this.txtTaxInvoiceNo = new System.Windows.Forms.TextBox();
		this.lblTaxNumber = new System.Windows.Forms.Label();
		this.lblTaxDate = new System.Windows.Forms.Label();
		this.dtpTaxInvoice = new System.Windows.Forms.DateTimePicker();
		this.Label14 = new System.Windows.Forms.Label();
		this.Label15 = new System.Windows.Forms.Label();
		this.lblTotalPaymentPlusDeduction = new System.Windows.Forms.Label();
		this.Label18 = new System.Windows.Forms.Label();
		this.Label17 = new System.Windows.Forms.Label();
		this.lblCurrencyName = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.cboStorage = new System.Windows.Forms.ComboBox();
		this.lblPaidDate = new System.Windows.Forms.Label();
		this.lblTaxDateDash = new System.Windows.Forms.Label();
		this.lblTaxNumberDash = new System.Windows.Forms.Label();
		this.lblPPN2 = new System.Windows.Forms.Label();
		this.lblSubTotalPrice2 = new System.Windows.Forms.Label();
		this.lblPPN = new System.Windows.Forms.Label();
		this.lblSubTotalPrice = new System.Windows.Forms.Label();
		this.Label20 = new System.Windows.Forms.Label();
		this.chkPPN = new System.Windows.Forms.CheckBox();
		this.txtCurrencyRate = new GCUv2.FilteredTextBox();
		this.txtDeduction = new GCUv2.FilteredTextBox();
		this.txtDiscount = new GCUv2.FilteredTextBox();
		this.TabControl1.SuspendLayout();
		this.TabPage1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvItem).BeginInit();
		this.TabPage2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvPayment).BeginInit();
		this.TabPage3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvReturn).BeginInit();
		base.SuspendLayout();
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(10, 40);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(46, 13);
		this.Label1.TabIndex = 50;
		this.Label1.Text = "Tanggal";
		this.dtpInvoice.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpInvoice.Location = new System.Drawing.Point(82, 36);
		this.dtpInvoice.Name = "dtpInvoice";
		this.dtpInvoice.Size = new System.Drawing.Size(121, 20);
		this.dtpInvoice.TabIndex = 1;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(18, 455);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(40, 13);
		this.Label5.TabIndex = 61;
		this.Label5.Text = "Diskon";
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.Location = new System.Drawing.Point(220, 40);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(57, 13);
		this.Label6.TabIndex = 64;
		this.Label6.Text = "No. Faktur";
		this.txtInvoiceNo.Location = new System.Drawing.Point(292, 36);
		this.txtInvoiceNo.Name = "txtInvoiceNo";
		this.txtInvoiceNo.Size = new System.Drawing.Size(121, 20);
		this.txtInvoiceNo.TabIndex = 2;
		this.lblTotalPrice.Location = new System.Drawing.Point(80, 413);
		this.lblTotalPrice.Name = "lblTotalPrice";
		this.lblTotalPrice.Size = new System.Drawing.Size(90, 13);
		this.lblTotalPrice.TabIndex = 66;
		this.lblTotalPrice.Text = "Total Price";
		this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.lblTotalReturn.Location = new System.Drawing.Point(77, 433);
		this.lblTotalReturn.Name = "lblTotalReturn";
		this.lblTotalReturn.Size = new System.Drawing.Size(93, 13);
		this.lblTotalReturn.TabIndex = 67;
		this.lblTotalReturn.Text = "Total Return";
		this.lblTotalReturn.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.lblTotalPayment.Location = new System.Drawing.Point(291, 433);
		this.lblTotalPayment.Name = "lblTotalPayment";
		this.lblTotalPayment.Size = new System.Drawing.Size(93, 13);
		this.lblTotalPayment.TabIndex = 68;
		this.lblTotalPayment.Text = "Total Payment";
		this.lblTotalPayment.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.lblTotalPayable.Location = new System.Drawing.Point(291, 501);
		this.lblTotalPayable.Name = "lblTotalPayable";
		this.lblTotalPayable.Size = new System.Drawing.Size(93, 20);
		this.lblTotalPayable.TabIndex = 69;
		this.lblTotalPayable.Text = "Total Payable";
		this.lblTotalPayable.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.TabControl1.Controls.Add(this.TabPage1);
		this.TabControl1.Controls.Add(this.TabPage2);
		this.TabControl1.Controls.Add(this.TabPage3);
		this.TabControl1.Controls.Add(this.TabPage4);
		this.TabControl1.Location = new System.Drawing.Point(12, 143);
		this.TabControl1.Name = "TabControl1";
		this.TabControl1.SelectedIndex = 0;
		this.TabControl1.Size = new System.Drawing.Size(667, 215);
		this.TabControl1.TabIndex = 11;
		this.TabPage1.Controls.Add(this.btnReceivedItem);
		this.TabPage1.Controls.Add(this.btnItem);
		this.TabPage1.Controls.Add(this.dgvItem);
		this.TabPage1.Location = new System.Drawing.Point(4, 22);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage1.Size = new System.Drawing.Size(659, 189);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = "Barang";
		this.TabPage1.UseVisualStyleBackColor = true;
		this.btnReceivedItem.BackColor = System.Drawing.SystemColors.ButtonFace;
		this.btnReceivedItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnReceivedItem.Location = new System.Drawing.Point(75, 8);
		this.btnReceivedItem.Name = "btnReceivedItem";
		this.btnReceivedItem.Size = new System.Drawing.Size(112, 24);
		this.btnReceivedItem.TabIndex = 13;
		this.btnReceivedItem.Text = "Penerimaan Barang";
		this.btnReceivedItem.UseVisualStyleBackColor = false;
		this.btnItem.BackColor = System.Drawing.SystemColors.ButtonFace;
		this.btnItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnItem.Location = new System.Drawing.Point(8, 8);
		this.btnItem.Name = "btnItem";
		this.btnItem.Size = new System.Drawing.Size(61, 24);
		this.btnItem.TabIndex = 12;
		this.btnItem.Text = "+ Barang";
		this.btnItem.UseVisualStyleBackColor = false;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.dgvItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.dgvItem.DefaultCellStyle = dataGridViewCellStyle2;
		this.dgvItem.Location = new System.Drawing.Point(8, 38);
		this.dgvItem.Name = "dgvItem";
		this.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dgvItem.Size = new System.Drawing.Size(637, 145);
		this.dgvItem.TabIndex = 13;
		this.TabPage2.Controls.Add(this.dgvPayment);
		this.TabPage2.Controls.Add(this.btnPayment);
		this.TabPage2.Location = new System.Drawing.Point(4, 22);
		this.TabPage2.Name = "TabPage2";
		this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage2.Size = new System.Drawing.Size(659, 189);
		this.TabPage2.TabIndex = 1;
		this.TabPage2.Text = "Pembayaran";
		this.TabPage2.UseVisualStyleBackColor = true;
		this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvPayment.Location = new System.Drawing.Point(9, 38);
		this.dgvPayment.Name = "dgvPayment";
		this.dgvPayment.Size = new System.Drawing.Size(632, 145);
		this.dgvPayment.TabIndex = 15;
		this.btnPayment.BackColor = System.Drawing.SystemColors.ButtonFace;
		this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnPayment.Location = new System.Drawing.Point(8, 8);
		this.btnPayment.Name = "btnPayment";
		this.btnPayment.Size = new System.Drawing.Size(85, 24);
		this.btnPayment.TabIndex = 14;
		this.btnPayment.Text = "+ Pembayaran";
		this.btnPayment.UseVisualStyleBackColor = false;
		this.TabPage3.Controls.Add(this.dgvReturn);
		this.TabPage3.Location = new System.Drawing.Point(4, 22);
		this.TabPage3.Name = "TabPage3";
		this.TabPage3.Size = new System.Drawing.Size(659, 189);
		this.TabPage3.TabIndex = 2;
		this.TabPage3.Text = "Retur";
		this.TabPage3.UseVisualStyleBackColor = true;
		this.dgvReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvReturn.Location = new System.Drawing.Point(8, 13);
		this.dgvReturn.Name = "dgvReturn";
		this.dgvReturn.Size = new System.Drawing.Size(388, 164);
		this.dgvReturn.TabIndex = 17;
		this.TabPage4.BackColor = System.Drawing.Color.DarkGray;
		this.TabPage4.Location = new System.Drawing.Point(4, 22);
		this.TabPage4.Name = "TabPage4";
		this.TabPage4.Size = new System.Drawing.Size(659, 189);
		this.TabPage4.TabIndex = 3;
		this.TabPage4.Text = "Lain-lain";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(17, 433);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(60, 13);
		this.Label3.TabIndex = 72;
		this.Label3.Text = "Total Retur";
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(17, 413);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(63, 13);
		this.Label8.TabIndex = 71;
		this.Label8.Text = "Total Harga";
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(17, 481);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(31, 13);
		this.Label9.TabIndex = 74;
		this.Label9.Text = "Total";
		this.lblTotalInvoice.Location = new System.Drawing.Point(80, 481);
		this.lblTotalInvoice.Name = "lblTotalInvoice";
		this.lblTotalInvoice.Size = new System.Drawing.Size(90, 13);
		this.lblTotalInvoice.TabIndex = 73;
		this.lblTotalInvoice.Text = "Total Invoice";
		this.lblTotalInvoice.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.Label11.AutoSize = true;
		this.Label11.Location = new System.Drawing.Point(200, 433);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(93, 13);
		this.Label11.TabIndex = 75;
		this.Label11.Text = "Total Pembayaran";
		this.Label12.AutoSize = true;
		this.Label12.Location = new System.Drawing.Point(200, 501);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(69, 13);
		this.Label12.TabIndex = 76;
		this.Label12.Text = "Total Hutang";
		this.Label13.BackColor = System.Drawing.SystemColors.ButtonShadow;
		this.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Label13.Location = new System.Drawing.Point(21, 477);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(365, 1);
		this.Label13.TabIndex = 79;
		this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnHistory.Location = new System.Drawing.Point(631, 539);
		this.btnHistory.Name = "btnHistory";
		this.btnHistory.Size = new System.Drawing.Size(50, 24);
		this.btnHistory.TabIndex = 44;
		this.btnHistory.Text = "&History";
		this.btnHistory.UseVisualStyleBackColor = true;
		this.btnSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSaveClose.Location = new System.Drawing.Point(477, 539);
		this.btnSaveClose.Name = "btnSaveClose";
		this.btnSaveClose.Size = new System.Drawing.Size(93, 24);
		this.btnSaveClose.TabIndex = 42;
		this.btnSaveClose.Text = "Simpan && &Tutup";
		this.btnSaveClose.UseVisualStyleBackColor = true;
		this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDelete.Location = new System.Drawing.Point(576, 539);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new System.Drawing.Size(49, 24);
		this.btnDelete.TabIndex = 43;
		this.btnDelete.Text = "Hapus";
		this.btnDelete.UseVisualStyleBackColor = true;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(385, 539);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(86, 24);
		this.btnSave.TabIndex = 41;
		this.btnSave.Text = "&Simpan && Baru";
		this.btnSave.UseVisualStyleBackColor = true;
		this.Label10.BackColor = System.Drawing.Color.Silver;
		this.Label10.Location = new System.Drawing.Point(-9, 531);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(713, 59);
		this.Label10.TabIndex = 125;
		this.cboSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboSupplier.FormattingEnabled = true;
		this.cboSupplier.Location = new System.Drawing.Point(82, 9);
		this.cboSupplier.Name = "cboSupplier";
		this.cboSupplier.Size = new System.Drawing.Size(174, 21);
		this.cboSupplier.TabIndex = 0;
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.Location = new System.Drawing.Point(10, 12);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(45, 13);
		this.Label7.TabIndex = 53;
		this.Label7.Text = "Supplier";
		this.lblSupplier.AutoSize = true;
		this.lblSupplier.Location = new System.Drawing.Point(79, 12);
		this.lblSupplier.Name = "lblSupplier";
		this.lblSupplier.Size = new System.Drawing.Size(55, 13);
		this.lblSupplier.TabIndex = 126;
		this.lblSupplier.Text = "lblSupplier";
		this.Label16.AutoSize = true;
		this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label16.Location = new System.Drawing.Point(9, 92);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(66, 13);
		this.Label16.TabIndex = 161;
		this.Label16.Text = "Tunai/Kredit";
		this.cboInvoiceCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboInvoiceCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboInvoiceCode.FormattingEnabled = true;
		this.cboInvoiceCode.Location = new System.Drawing.Point(82, 88);
		this.cboInvoiceCode.Name = "cboInvoiceCode";
		this.cboInvoiceCode.Size = new System.Drawing.Size(121, 21);
		this.cboInvoiceCode.TabIndex = 5;
		this.txtTaxInvoiceNo.Location = new System.Drawing.Point(292, 62);
		this.txtTaxInvoiceNo.Name = "txtTaxInvoiceNo";
		this.txtTaxInvoiceNo.Size = new System.Drawing.Size(121, 20);
		this.txtTaxInvoiceNo.TabIndex = 4;
		this.lblTaxNumber.AutoSize = true;
		this.lblTaxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblTaxNumber.Location = new System.Drawing.Point(220, 65);
		this.lblTaxNumber.Name = "lblTaxNumber";
		this.lblTaxNumber.Size = new System.Drawing.Size(66, 13);
		this.lblTaxNumber.TabIndex = 165;
		this.lblTaxNumber.Text = "No. F. Pajak";
		this.lblTaxDate.AutoSize = true;
		this.lblTaxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblTaxDate.Location = new System.Drawing.Point(10, 66);
		this.lblTaxDate.Name = "lblTaxDate";
		this.lblTaxDate.Size = new System.Drawing.Size(67, 13);
		this.lblTaxDate.TabIndex = 164;
		this.lblTaxDate.Text = "Tgl. F. Pajak";
		this.dtpTaxInvoice.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpTaxInvoice.Location = new System.Drawing.Point(82, 62);
		this.dtpTaxInvoice.Name = "dtpTaxInvoice";
		this.dtpTaxInvoice.Size = new System.Drawing.Size(121, 20);
		this.dtpTaxInvoice.TabIndex = 3;
		this.Label14.AutoSize = true;
		this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label14.Location = new System.Drawing.Point(200, 455);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(53, 13);
		this.Label14.TabIndex = 167;
		this.Label14.Text = "Potongan";
		this.Label15.AutoSize = true;
		this.Label15.Location = new System.Drawing.Point(200, 481);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(31, 13);
		this.Label15.TabIndex = 169;
		this.Label15.Text = "Total";
		this.lblTotalPaymentPlusDeduction.Location = new System.Drawing.Point(291, 481);
		this.lblTotalPaymentPlusDeduction.Name = "lblTotalPaymentPlusDeduction";
		this.lblTotalPaymentPlusDeduction.Size = new System.Drawing.Size(93, 13);
		this.lblTotalPaymentPlusDeduction.TabIndex = 168;
		this.lblTotalPaymentPlusDeduction.Text = "Total Pay+Deduct";
		this.lblTotalPaymentPlusDeduction.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.Label18.BackColor = System.Drawing.SystemColors.ButtonShadow;
		this.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Label18.Location = new System.Drawing.Point(186, 363);
		this.Label18.Name = "Label18";
		this.Label18.Size = new System.Drawing.Size(1, 155);
		this.Label18.TabIndex = 170;
		this.Label17.AutoSize = true;
		this.Label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label17.Location = new System.Drawing.Point(220, 91);
		this.Label17.Name = "Label17";
		this.Label17.Size = new System.Drawing.Size(28, 13);
		this.Label17.TabIndex = 172;
		this.Label17.Text = "Kurs";
		this.lblCurrencyName.AutoSize = true;
		this.lblCurrencyName.Location = new System.Drawing.Point(245, 91);
		this.lblCurrencyName.Name = "lblCurrencyName";
		this.lblCurrencyName.Size = new System.Drawing.Size(60, 13);
		this.lblCurrencyName.TabIndex = 174;
		this.lblCurrencyName.Text = "Mata Uang";
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(10, 118);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(45, 13);
		this.Label4.TabIndex = 176;
		this.Label4.Text = "Gudang";
		this.cboStorage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboStorage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboStorage.FormattingEnabled = true;
		this.cboStorage.Location = new System.Drawing.Point(82, 115);
		this.cboStorage.Name = "cboStorage";
		this.cboStorage.Size = new System.Drawing.Size(121, 21);
		this.cboStorage.TabIndex = 7;
		this.lblPaidDate.AutoSize = true;
		this.lblPaidDate.Location = new System.Drawing.Point(390, 501);
		this.lblPaidDate.Name = "lblPaidDate";
		this.lblPaidDate.Size = new System.Drawing.Size(61, 13);
		this.lblPaidDate.TabIndex = 181;
		this.lblPaidDate.Text = "lblPaidDate";
		this.lblTaxDateDash.AutoSize = true;
		this.lblTaxDateDash.Location = new System.Drawing.Point(83, 65);
		this.lblTaxDateDash.Name = "lblTaxDateDash";
		this.lblTaxDateDash.Size = new System.Drawing.Size(10, 13);
		this.lblTaxDateDash.TabIndex = 182;
		this.lblTaxDateDash.Text = "-";
		this.lblTaxNumberDash.AutoSize = true;
		this.lblTaxNumberDash.Location = new System.Drawing.Point(292, 65);
		this.lblTaxNumberDash.Name = "lblTaxNumberDash";
		this.lblTaxNumberDash.Size = new System.Drawing.Size(10, 13);
		this.lblTaxNumberDash.TabIndex = 183;
		this.lblTaxNumberDash.Text = "-";
		this.lblPPN2.AutoSize = true;
		this.lblPPN2.Location = new System.Drawing.Point(17, 385);
		this.lblPPN2.Name = "lblPPN2";
		this.lblPPN2.Size = new System.Drawing.Size(29, 13);
		this.lblPPN2.TabIndex = 187;
		this.lblPPN2.Text = "PPN";
		this.lblSubTotalPrice2.AutoSize = true;
		this.lblSubTotalPrice2.Location = new System.Drawing.Point(17, 365);
		this.lblSubTotalPrice2.Name = "lblSubTotalPrice2";
		this.lblSubTotalPrice2.Size = new System.Drawing.Size(53, 13);
		this.lblSubTotalPrice2.TabIndex = 186;
		this.lblSubTotalPrice2.Text = "Sub Total";
		this.lblPPN.Location = new System.Drawing.Point(79, 385);
		this.lblPPN.Name = "lblPPN";
		this.lblPPN.Size = new System.Drawing.Size(93, 13);
		this.lblPPN.TabIndex = 185;
		this.lblPPN.Text = "Total PPN";
		this.lblPPN.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.lblSubTotalPrice.Location = new System.Drawing.Point(82, 365);
		this.lblSubTotalPrice.Name = "lblSubTotalPrice";
		this.lblSubTotalPrice.Size = new System.Drawing.Size(90, 13);
		this.lblSubTotalPrice.TabIndex = 184;
		this.lblSubTotalPrice.Text = "Sub Total";
		this.lblSubTotalPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.Label20.BackColor = System.Drawing.SystemColors.ButtonShadow;
		this.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Label20.Location = new System.Drawing.Point(21, 404);
		this.Label20.Name = "Label20";
		this.Label20.Size = new System.Drawing.Size(165, 1);
		this.Label20.TabIndex = 188;
		this.chkPPN.AutoSize = true;
		this.chkPPN.Location = new System.Drawing.Point(419, 64);
		this.chkPPN.Name = "chkPPN";
		this.chkPPN.Size = new System.Drawing.Size(194, 17);
		this.chkPPN.TabIndex = 5;
		this.chkPPN.Text = "Harga barang sudah termasuk PPN";
		this.chkPPN.UseVisualStyleBackColor = true;
		this.txtCurrencyRate.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtCurrencyRate.DontFormat = false;
		this.txtCurrencyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtCurrencyRate.Location = new System.Drawing.Point(292, 86);
		this.txtCurrencyRate.MaximumDigit = 3;
		this.txtCurrencyRate.Name = "txtCurrencyRate";
		this.txtCurrencyRate.Size = new System.Drawing.Size(121, 21);
		this.txtCurrencyRate.TabIndex = 6;
		this.txtCurrencyRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.txtDeduction.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtDeduction.DontFormat = false;
		this.txtDeduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtDeduction.Location = new System.Drawing.Point(300, 453);
		this.txtDeduction.MaximumDigit = 3;
		this.txtDeduction.Name = "txtDeduction";
		this.txtDeduction.Size = new System.Drawing.Size(84, 21);
		this.txtDeduction.TabIndex = 32;
		this.txtDeduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.txtDiscount.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtDiscount.DontFormat = false;
		this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtDiscount.Location = new System.Drawing.Point(83, 453);
		this.txtDiscount.MaximumDigit = 3;
		this.txtDiscount.Name = "txtDiscount";
		this.txtDiscount.Size = new System.Drawing.Size(87, 21);
		this.txtDiscount.TabIndex = 31;
		this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(689, 572);
		base.Controls.Add(this.chkPPN);
		base.Controls.Add(this.Label20);
		base.Controls.Add(this.lblPPN2);
		base.Controls.Add(this.lblSubTotalPrice2);
		base.Controls.Add(this.lblPPN);
		base.Controls.Add(this.lblSubTotalPrice);
		base.Controls.Add(this.lblTaxNumberDash);
		base.Controls.Add(this.lblTaxDateDash);
		base.Controls.Add(this.lblPaidDate);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.cboStorage);
		base.Controls.Add(this.lblCurrencyName);
		base.Controls.Add(this.txtCurrencyRate);
		base.Controls.Add(this.Label17);
		base.Controls.Add(this.Label18);
		base.Controls.Add(this.Label15);
		base.Controls.Add(this.lblTotalPaymentPlusDeduction);
		base.Controls.Add(this.txtDeduction);
		base.Controls.Add(this.Label14);
		base.Controls.Add(this.txtTaxInvoiceNo);
		base.Controls.Add(this.lblTaxNumber);
		base.Controls.Add(this.lblTaxDate);
		base.Controls.Add(this.dtpTaxInvoice);
		base.Controls.Add(this.Label16);
		base.Controls.Add(this.cboInvoiceCode);
		base.Controls.Add(this.lblSupplier);
		base.Controls.Add(this.btnHistory);
		base.Controls.Add(this.btnSaveClose);
		base.Controls.Add(this.btnDelete);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.Label10);
		base.Controls.Add(this.Label13);
		base.Controls.Add(this.Label12);
		base.Controls.Add(this.Label11);
		base.Controls.Add(this.Label9);
		base.Controls.Add(this.lblTotalInvoice);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.Label8);
		base.Controls.Add(this.TabControl1);
		base.Controls.Add(this.lblTotalPayable);
		base.Controls.Add(this.lblTotalPayment);
		base.Controls.Add(this.lblTotalReturn);
		base.Controls.Add(this.lblTotalPrice);
		base.Controls.Add(this.txtInvoiceNo);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.txtDiscount);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.cboSupplier);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.dtpInvoice);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmPurchaseInvoice";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Faktur Pembelian - Input";
		this.TabControl1.ResumeLayout(false);
		this.TabPage1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgvItem).EndInit();
		this.TabPage2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgvPayment).EndInit();
		this.TabPage3.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgvReturn).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmPurchaseInvoice()
	{
		base.KeyDown += frmPurchaseInvoice_KeyDown;
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
					SetStyle(ControlStyles.UserPaint, value: true);
					SetStyle(ControlStyles.AllPaintingInWmPaint, value: true);
					SetStyle(ControlStyles.OptimizedDoubleBuffer, value: true);
					base.MdiParent = MyProject.Forms.frmMenu;
					txtDiscount.AllowedCharacters = FilteredTextBox.InputType.NumeralsAndCurrency;
					txtDeduction.AllowedCharacters = FilteredTextBox.InputType.NumeralsAndCurrency;
					txtCurrencyRate.AllowedCharacters = FilteredTextBox.InputType.NumeralsAndCurrency;
					txtDiscount.MaximumDigit = 2;
					txtDeduction.MaximumDigit = 2;
					txtCurrencyRate.MaximumDigit = 2;
					ComboBox combo = cboInvoiceCode;
					cCombo.getInvoiceCode(ref combo, All: false);
					cboInvoiceCode = combo;
					combo = cboSupplier;
					cCombo.getSupplier(ref combo, Module1.pubGroupId, All: false, FlowerOnly: false, IncludeParent: false, Active: true);
					cboSupplier = combo;
					combo = cboStorage;
					cCombo.getStorage(ref combo, Module1.pubGroupId, 0, "NO_RETURN", blnAll: false, 1);
					cboStorage = combo;
					btnItem.Enabled = false;
					btnReceivedItem.Enabled = false;
					formatGrid();
					goto end_IL_001b;
				}
				case 337:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmPurchaseInvoice", "New", "");
						goto end_IL_001b;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try001b_dispatch = 337;
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

	private void frmPurchaseInvoice_KeyDown(object sender, KeyEventArgs e)
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
		dgvItem.Columns.Add("", "Barang");
		dgvItem.Columns.Add("", "Deskripsi");
		dgvItem.Columns.Add("", "Jumlah");
		dgvItem.Columns.Add("", "Unit");
		dgvItem.Columns.Add("", "Jumlah");
		dgvItem.Columns.Add("", "Jml. (stok)");
		dgvItem.Columns.Add("", "Jml. (stok)");
		dgvItem.Columns.Add("", "Jml. Parkir");
		dgvItem.Columns.Add("", "Potongan");
		dgvItem.Columns.Add("", "Jml. Bersih");
		dgvItem.Columns.Add("", "Harga");
		dgvItem.Columns.Add("", "Harga+");
		dgvItem.Columns.Add("", "Total");
		dgvItem.Columns.Add("", "No Penerimaan");
		dgvItem.Columns.Add("", "riId");
		dgvItem.Columns.Add("", "riItemId");
		dgvItem.Columns.Add("", "inventoryAccountId");
		dgvItem.Columns[0].Visible = false;
		dgvItem.Columns[1].Visible = false;
		dgvItem.Columns[2].Visible = false;
		dgvItem.Columns[3].Visible = false;
		dgvItem.Columns[4].Width = 100;
		dgvItem.Columns[5].Width = 160;
		dgvItem.Columns[6].Visible = false;
		dgvItem.Columns[7].Visible = false;
		dgvItem.Columns[8].Width = 80;
		dgvItem.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItem.Columns[9].Visible = false;
		dgvItem.Columns[10].Width = 80;
		dgvItem.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItem.Columns[11].Width = 80;
		dgvItem.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItem.Columns[12].Width = 80;
		dgvItem.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItem.Columns[12].DefaultCellStyle.Format = "0\\%";
		dgvItem.Columns[13].Width = 80;
		dgvItem.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItem.Columns[14].Width = 80;
		dgvItem.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItem.Columns[15].Width = 80;
		dgvItem.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItem.Columns[16].Width = 80;
		dgvItem.Columns[16].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItem.Columns[17].Width = 100;
		dgvItem.Columns[17].Visible = false;
		dgvItem.Columns[18].Visible = false;
		dgvItem.Columns[19].Visible = false;
		dgvItem.Columns[20].Visible = false;
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
		dgvPayment.Columns.Add("paymentDate", "Tanggal");
		dgvPayment.Columns.Add("", "Tipe");
		dgvPayment.Columns.Add("", "Bon");
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
		dgvPayment.Columns[7].Visible = false;
		dgvPayment.Columns[10].Visible = false;
		dgvPayment.Columns[11].Visible = false;
		dgvPayment.Columns[16].Visible = false;
		dgvPayment.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvPayment.Columns[4].Width = 70;
		dgvPayment.Columns[5].Width = 40;
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
		DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
		dgvReturn.Columns.Add("", "invId");
		dgvReturn.Columns.Add(dataGridViewCheckBoxColumn);
		dataGridViewCheckBoxColumn.HeaderText = "";
		dataGridViewCheckBoxColumn.Name = "chk";
		dgvReturn.Columns.Add("", "Tanggal");
		dgvReturn.Columns.Add("", "No Retur");
		dgvReturn.Columns.Add("", "Jumlah");
		dgvReturn.Columns[0].Visible = false;
		dgvReturn.Columns[1].Width = 40;
		dgvReturn.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvReturn.Columns[2].Width = 80;
		dgvReturn.Columns[3].Width = 120;
		dgvReturn.Columns[4].Width = 120;
		dgvReturn.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvReturn.Columns[2].ReadOnly = true;
		dgvReturn.Columns[3].ReadOnly = true;
		dgvReturn.Columns[4].ReadOnly = true;
		dgvReturn.RowHeadersVisible = false;
		dgvReturn.AllowUserToAddRows = false;
		dgvReturn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvReturn.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvReturn.AllowUserToResizeRows = false;
	}

	public void prepareForm(bool SaveNew, bool KeepSupplier)
	{
		_disableDgvItem = false;
		_justLoaded = false;
		_currentId = 0.0;
		_currentlySelectedComboIndex = -1;
		_addDailyTotalSql = "";
		if (!SaveNew)
		{
			dtpInvoice.Value = DateAndTime.Now;
			dtpTaxInvoice.Value = DateAndTime.Now;
		}
		dtpTaxInvoice.Visible = false;
		txtTaxInvoiceNo.Visible = false;
		lblSubTotalPrice.Visible = false;
		lblSubTotalPrice2.Visible = false;
		lblPPN.Visible = false;
		lblPPN2.Visible = false;
		chkPPN.Visible = false;
		dgvItem.Rows.Clear();
		dgvPayment.Rows.Clear();
		dgvReturn.Rows.Clear();
		lblSupplier.Text = "";
		lblSupplier.Visible = false;
		cboSupplier.Visible = true;
		lblCurrencyName.Text = "";
		cboInvoiceCode.SelectedIndex = -1;
		cboStorage.SelectedIndex = -1;
		btnHistory.Enabled = false;
		if (!KeepSupplier)
		{
			cboSupplier.SelectedIndex = -1;
		}
		TabControl1.SelectedIndex = 0;
		txtInvoiceNo.Text = "";
		txtTaxInvoiceNo.Text = "";
		txtCurrencyRate.Text = "";
		txtDiscount.Text = "";
		txtDeduction.Text = "";
		btnSave.Enabled = true;
		btnSaveClose.Enabled = true;
		btnDelete.Enabled = false;
		btnHistory.Enabled = false;
		lblTotalPrice.Text = "";
		lblTotalInvoice.Text = "";
		lblTotalPaymentPlusDeduction.Text = "";
		lblTotalPayable.Text = "";
		lblTotalPayment.Text = "";
		lblTotalReturn.Text = "";
		lblPaidDate.Text = "Tgl. Lunas: -";
		lblPaidDate.Visible = false;
		dtpInvoice.Enabled = true;
		dtpTaxInvoice.Enabled = true;
		cboStorage.Enabled = true;
		cboInvoiceCode.Enabled = true;
		btnItem.Enabled = true;
		btnReceivedItem.Enabled = true;
		txtDiscount.Enabled = true;
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
					lblSupplier.Visible = true;
					cboSupplier.Visible = false;
					dgvItem.Rows.Clear();
					dgvPayment.Rows.Clear();
					dgvReturn.Rows.Clear();
					if (!Information.IsDBNull(cPurchaseInvoice2.PaidDate) && DateTime.Compare(cPurchaseInvoice2.PaidDate, DateTime.MinValue) > 0)
					{
						lblPaidDate.Text = "Tgl. Lunas: " + Conversions.ToString(cPurchaseInvoice2.PaidDate);
						lblPaidDate.Visible = true;
					}
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
					dtpTaxInvoice.Value = cPurchaseInvoice2.TaxInvoiceDate;
					txtInvoiceNo.Text = cPurchaseInvoice2.Number;
					txtTaxInvoiceNo.Text = cPurchaseInvoice2.TaxNumber;
					chkPPN.Checked = cPurchaseInvoice2.isTaxIncluded != 0;
					_currencyId = cPurchaseInvoice2.CurrencyId;
					lblCurrencyName.Text = cPurchaseInvoice2.CurrencyName;
					txtCurrencyRate.Text = Module1.formatCustomDecimal(Conversions.ToString(cPurchaseInvoice2.CurrencyRate), 2);
					txtDiscount.Text = Module1.formatCustomDecimal(Conversions.ToString(cPurchaseInvoice2.Discount), 2);
					txtDeduction.Text = Module1.formatCustomDecimal(Conversions.ToString(cPurchaseInvoice2.Deduction), 2);
					if (cPurchaseInvoice2.IsTaxInvoice)
					{
						dtpTaxInvoice.Visible = true;
						txtTaxInvoiceNo.Visible = true;
						lblTaxDateDash.Visible = false;
						lblTaxNumberDash.Visible = false;
						_hasNPWP = true;
						lblSubTotalPrice.Visible = true;
						lblSubTotalPrice2.Visible = true;
						lblPPN.Visible = true;
						lblPPN2.Visible = true;
						chkPPN.Visible = true;
					}
					else
					{
						dtpTaxInvoice.Visible = false;
						txtTaxInvoiceNo.Visible = false;
						lblTaxDateDash.Visible = true;
						lblTaxNumberDash.Visible = true;
						_hasNPWP = false;
						lblSubTotalPrice.Visible = false;
						lblSubTotalPrice2.Visible = false;
						lblPPN.Visible = false;
						lblPPN2.Visible = false;
						chkPPN.Visible = false;
						chkPPN.Checked = true;
					}
					cPurchaseInvoiceItem[] item = cPurchaseInvoice2.Item;
					foreach (cPurchaseInvoiceItem cPurchaseInvoiceItem2 in item)
					{
						dgvItem.Rows.Add(cPurchaseInvoiceItem2.Id, cPurchaseInvoiceItem2.ItemId, cPurchaseInvoiceItem2.StorageId, cPurchaseInvoiceItem2.StorageName, cPurchaseInvoiceItem2.ItemName, cPurchaseInvoiceItem2.Description, Module1.formatCustomDecimal(Conversions.ToString(cPurchaseInvoiceItem2.InvoiceQty), 3), cPurchaseInvoiceItem2.UnitName, Module1.formatCustomDecimal(Conversions.ToString(cPurchaseInvoiceItem2.InvoiceQty), 3) + " " + cPurchaseInvoiceItem2.UnitName, Module1.formatCustomDecimal(Conversions.ToString(cPurchaseInvoiceItem2.StockQty), 3), Module1.formatCustomDecimal(Conversions.ToString(cPurchaseInvoiceItem2.StockQty), 3) + " " + cPurchaseInvoiceItem2.BaseUnitName, Module1.formatCustomDecimal(Conversions.ToString(cPurchaseInvoiceItem2.ParkedQty), 3), cPurchaseInvoiceItem2.Deduction, Module1.formatCustomDecimal(Conversions.ToString(cPurchaseInvoiceItem2.NetQty), 3), Module1.formatCustomDecimal(Conversions.ToString(cPurchaseInvoiceItem2.Price), 2), Module1.formatCustomDecimal(Conversions.ToString(cPurchaseInvoiceItem2.ExtraPrice), 2), Module1.formatCustomDecimal(Conversions.ToString(cPurchaseInvoiceItem2.Total), 2), cPurchaseInvoiceItem2.RiNumber, cPurchaseInvoiceItem2.RiId, cPurchaseInvoiceItem2.RiItemId, cPurchaseInvoiceItem2.InventoryAccountId);
					}
					if (dgvItem.Rows.Count > 0)
					{
						dgvItem.CurrentRow.Selected = false;
					}
					calculateTotalPrice();
					cPurchaseInvoicePayment[] payment = cPurchaseInvoice2.Payment;
					foreach (cPurchaseInvoicePayment cPurchaseInvoicePayment2 in payment)
					{
						dgvPayment.Rows.Add(cPurchaseInvoicePayment2.PaymentId, cPurchaseInvoicePayment2.MultiPaymentId, cPurchaseInvoicePayment2.PaymentCodeId, cPurchaseInvoicePayment2.AccountId, cPurchaseInvoicePayment2.PaymentDate, cPurchaseInvoicePayment2.PaymentCodeName, Interaction.IIf(cPurchaseInvoicePayment2.InFront == 0, "-", "Ya"), cPurchaseInvoicePayment2.ChequeId, Interaction.IIf(Operators.CompareString(Strings.Right(cPurchaseInvoicePayment2.PaymentCodeName, 3), "C/G", TextCompare: false) == 0, cPurchaseInvoicePayment2.ChequeDate, ""), cPurchaseInvoicePayment2.ChequeNumber, 0, 0, Module1.formatCustomDecimal(Conversions.ToString(cPurchaseInvoicePayment2.Amount), 2), cPurchaseInvoicePayment2.AccountName, cPurchaseInvoicePayment2.CurrencyName, Module1.formatCustomDecimal(Conversions.ToString(cPurchaseInvoicePayment2.CurrencyRate), 2), cPurchaseInvoicePayment2.CreatedDate);
					}
					calculateTotalPayment();
					cPurchaseInvoiceReturn[] invoiceReturn = cPurchaseInvoice2.InvoiceReturn;
					foreach (cPurchaseInvoiceReturn cPurchaseInvoiceReturn2 in invoiceReturn)
					{
						dgvReturn.Rows.Insert(0, cPurchaseInvoiceReturn2.Id, TriState.True, cPurchaseInvoiceReturn2.InvoiceDate, cPurchaseInvoiceReturn2.Number, Module1.formatCustomDecimal(Conversions.ToString(cPurchaseInvoiceReturn2.Amount), 2));
					}
					CalculateTotalReturn();
					if (DateAndTime.DateDiff(DateInterval.Day, dtpInvoice.Value, DateAndTime.Now) <= Module1.pubDaysLimit)
					{
						dtpInvoice.Enabled = true;
						dtpTaxInvoice.Enabled = true;
						cboStorage.Enabled = true;
						cboInvoiceCode.Enabled = true;
						btnItem.Enabled = true;
						btnReceivedItem.Enabled = true;
						_disableDgvItem = false;
						txtDiscount.Enabled = true;
					}
					else
					{
						dtpInvoice.Enabled = false;
						dtpTaxInvoice.Enabled = false;
						cboStorage.Enabled = false;
						cboInvoiceCode.Enabled = false;
						btnItem.Enabled = false;
						btnReceivedItem.Enabled = false;
						_disableDgvItem = true;
						txtDiscount.Enabled = false;
					}
					btnHistory.Enabled = true;
					goto end_IL_0001_2;
				}
				case 2291:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmPurchaseInvoice", "LoadData", "");
						if (Information.Err().Number == 513)
						{
							Close();
						}
						goto end_IL_0001_2;
					}
					break;
				}
				goto IL_0929;
				end_IL_0001_2:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 2291;
				continue;
			}
			break;
			IL_0929:
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

	private void GetUnpaidReturn()
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
					cComboItem cComboItem2 = (cComboItem)cboSupplier.SelectedItem;
					DataTable unpaidReturn = cPurchaseInvoice.GetUnpaidReturn(Conversions.ToInteger(cComboItem2.Value));
					IEnumerator enumerator = unpaidReturn.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						dgvReturn.Rows.Add(dataRow["invId"], 0, dataRow["invDate"], dataRow["invNumber"], Module1.formatCustomDecimal(Conversions.ToString(dataRow["invReceivable"]), 2));
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					goto end_IL_0001;
				}
				case 246:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmPurchaseInvoice", "GetUnpaidReturn", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 246;
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

	private void dtpInvoice_ValueChanged(object sender, EventArgs e)
	{
		if (!_justLoaded & (DateAndTime.DateDiff(DateInterval.Day, dtpInvoice.Value, DateAndTime.Now) > Module1.pubDaysLimit))
		{
			Interaction.MsgBox("Anda tidak bisa membuat Faktur Pembelian sebelum " + Strings.FormatDateTime(DateAndTime.Now.AddDays(checked(Module1.pubDaysLimit * -1)), DateFormat.ShortDate), MsgBoxStyle.Information);
			dtpInvoice.Value = DateAndTime.Now;
		}
		dtpTaxInvoice.Value = dtpInvoice.Value;
	}

	public void calculateTotalPrice()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		double num4 = default(double);
		bool flag = default(bool);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		bool flag4 = default(bool);
		bool flag5 = default(bool);
		bool flag6 = default(bool);
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
					checked
					{
						int num3 = dgvItem.Rows.Count - 1;
						for (int i = 0; i <= num3; i++)
						{
							num4 += Conversions.ToDouble(dgvItem[16, i].Value);
							if (Operators.ConditionalCompareObjectNotEqual(dgvItem[5, i].Value, "", TextCompare: false))
							{
								flag = true;
							}
							if (Operators.ConditionalCompareObjectNotEqual(dgvItem[6, i].Value, dgvItem[9, i].Value, TextCompare: false))
							{
								flag2 = true;
							}
							if (Conversions.ToDouble(dgvItem[11, i].Value) > 0.0)
							{
								flag3 = true;
							}
							if (Conversions.ToDouble(dgvItem[12, i].Value) > 0.0)
							{
								flag4 = true;
							}
							if (Conversions.ToDouble(dgvItem[15, i].Value) > 0.0)
							{
								flag5 = true;
							}
							if (Operators.ConditionalCompareObjectGreater(dgvItem[18, i].Value, 0, TextCompare: false))
							{
								flag6 = true;
							}
						}
						if (flag)
						{
							dgvItem.Columns[5].Visible = true;
						}
						else
						{
							dgvItem.Columns[5].Visible = false;
						}
						if (flag2)
						{
							dgvItem.Columns[10].Visible = true;
						}
						else
						{
							dgvItem.Columns[10].Visible = false;
						}
						if (flag3)
						{
							dgvItem.Columns[11].Visible = true;
						}
						else
						{
							dgvItem.Columns[11].Visible = false;
						}
						if (flag4)
						{
							dgvItem.Columns[12].Visible = true;
						}
						else
						{
							dgvItem.Columns[12].Visible = false;
						}
					}
					if (flag3 || flag4)
					{
						dgvItem.Columns[13].Visible = true;
					}
					else
					{
						dgvItem.Columns[13].Visible = false;
					}
					if (flag5)
					{
						dgvItem.Columns[15].Visible = true;
					}
					else
					{
						dgvItem.Columns[15].Visible = false;
					}
					if (flag6)
					{
						dgvItem.Columns[17].Visible = true;
					}
					else
					{
						dgvItem.Columns[17].Visible = false;
					}
					lblSubTotalPrice.Text = Module1.formatCustomDecimal(Conversions.ToString(num4), 2);
					calculateTotalInvoice();
					goto end_IL_0001;
				case 854:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmPurchaseInvoice", "CalculateTotalPrice", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 854;
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

	public void CalculateTotalReturn()
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
						int num3 = dgvReturn.Rows.Count - 1;
						for (int i = 0; i <= num3; i++)
						{
							if (Operators.ConditionalCompareObjectEqual(dgvReturn[1, i].EditedFormattedValue, true, TextCompare: false))
							{
								num4 += Conversions.ToDouble(dgvReturn[4, i].Value);
							}
						}
						lblTotalReturn.Text = Module1.formatCustomDecimal(Conversions.ToString(num4), 2);
						calculateTotalInvoice();
						goto end_IL_0001;
					}
					case 169:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmPurchaseInvoice", "CalculateTotalReturn", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 169;
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
						}
						lblTotalPayment.Text = Module1.formatCustomDecimal(Conversions.ToString(num4), 2);
						calculateTotalInvoice();
						goto end_IL_0001;
					}
					case 132:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmPurchaseInvoice", "CalculateTotalPayment", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 132;
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
					double num3 = Conversions.ToDouble(Module1.unformatNumber(lblSubTotalPrice.Text)) - Conversions.ToDouble(Module1.unformatNumber(txtDiscount.Text));
					DateTime t = new DateTime(2022, 4, 1);
					short num4 = checked((short)DateTime.Compare(dtpTaxInvoice.Value.Date, t));
					double num5;
					double num6;
					if (num4 < 0)
					{
						num5 = 1.1;
						num6 = 0.1;
					}
					else
					{
						num5 = 1.11;
						num6 = 0.11;
					}
					if (chkPPN.Checked)
					{
						double number = num3 / num5;
						number = Module1.RoundMoney(number);
						double num7 = num3 - number;
						lblPPN.Text = Module1.formatCustomDecimal(Conversions.ToString(num7), 2);
						lblTotalPrice.Text = lblSubTotalPrice.Text;
					}
					else
					{
						double num7 = Conversion.Int(num3 * num6);
						lblPPN.Text = Module1.formatCustomDecimal(Conversions.ToString(num7), 2);
						lblTotalPrice.Text = Module1.formatCustomDecimal(Conversions.ToString(Conversion.Val(Module1.unformatNumber(lblSubTotalPrice.Text)) + Conversion.Val(Module1.unformatNumber(lblPPN.Text))), 2);
					}
					double num8 = Conversion.Val(Module1.unformatNumber(lblTotalPrice.Text)) - Conversion.Val(Module1.unformatNumber(lblTotalReturn.Text)) - Conversion.Val(Module1.unformatNumber(txtDiscount.Text));
					lblTotalInvoice.Text = Module1.formatCustomDecimal(Conversions.ToString(num8), 2);
					double num9 = Conversion.Val(Module1.unformatNumber(lblTotalPayment.Text)) + Conversion.Val(Module1.unformatNumber(txtDeduction.Text));
					lblTotalPaymentPlusDeduction.Text = Module1.formatCustomDecimal(Conversions.ToString(num9), 2);
					double num10 = num8 - num9;
					lblTotalPayable.Text = Module1.formatCustomDecimal(Conversions.ToString(num10), 2);
					goto end_IL_0001;
				}
				case 582:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmPurchaseInvoice", "CalculateTotalInvoice", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 582;
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
		if (cboSupplier.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih Supplier.", (MsgBoxStyle)(-2147483637));
			cboSupplier.Focus();
			return;
		}
		if (cboStorage.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih gudang.", (MsgBoxStyle)(-2147483637));
			cboStorage.Focus();
			return;
		}
		cComboItem cComboItem2 = (cComboItem)cboSupplier.SelectedItem;
		cComboItem cComboItem3 = (cComboItem)cboStorage.SelectedItem;
		if ((cboSupplier.SelectedIndex > -1) & (cboStorage.SelectedIndex > -1))
		{
			frmPurchaseInvoiceItem frmPurchaseInvoiceItem2 = new frmPurchaseInvoiceItem(CurrentData: false, Conversions.ToInteger(cComboItem2.Value), dtpInvoice.Value, Conversions.ToInteger(cComboItem3.Value));
			frmPurchaseInvoiceItem2.ShowDialog();
			frmPurchaseInvoiceItem2.Close();
			frmPurchaseInvoiceItem2.Dispose();
		}
	}

	private void btnReceivedItem_Click(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboSupplier.SelectedItem;
		if (cboSupplier.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih Supplier.", (MsgBoxStyle)(-2147483637));
			cboSupplier.Focus();
			return;
		}
		frmPurchaseInvoiceRI frmPurchaseInvoiceRI2 = new frmPurchaseInvoiceRI(Conversions.ToInteger(cComboItem2.Value), _currentId);
		frmPurchaseInvoiceRI2.ShowDialog();
		frmPurchaseInvoiceRI2.Close();
		frmPurchaseInvoiceRI2.Dispose();
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
						frmPurchaseInvoiceItem frmPurchaseInvoiceItem2 = new frmPurchaseInvoiceItem(CurrentData: true, Conversions.ToInteger(cComboItem2.Value), dtpInvoice.Value, Conversions.ToInteger(cComboItem3.Value));
						ComboBox cboSource = frmPurchaseInvoiceItem2.cboItem;
						Module1.comboBoundValue(ref cboSource, Conversions.ToDouble(dgvItem[1, dgvItem.CurrentRow.Index].Value));
						frmPurchaseInvoiceItem2.cboItem = cboSource;
						frmPurchaseInvoiceItem2.cboItem.Enabled = false;
						frmPurchaseInvoiceItem2.rtxDescription.Text = Conversions.ToString(dgvItem[5, dgvItem.CurrentRow.Index].Value);
						frmPurchaseInvoiceItem2.cboUnit.Text = Conversions.ToString(dgvItem[7, dgvItem.CurrentRow.Index].Value);
						frmPurchaseInvoiceItem2.txtQty.Text = Module1.formatCustomDecimal(Conversions.ToString(dgvItem[6, dgvItem.CurrentRow.Index].Value), 3);
						frmPurchaseInvoiceItem2.txtStockQty.Text = Module1.formatCustomDecimal(Conversions.ToString(dgvItem[9, dgvItem.CurrentRow.Index].Value), 3);
						frmPurchaseInvoiceItem2.txtParkedQty.Text = Module1.formatCustomDecimal(Conversions.ToString(dgvItem[11, dgvItem.CurrentRow.Index].Value), 3);
						frmPurchaseInvoiceItem2.txtDeduction.Text = Module1.formatCustomDecimal(Conversions.ToString(dgvItem[12, dgvItem.CurrentRow.Index].Value), 3);
						frmPurchaseInvoiceItem2.txtPrice.Text = Module1.formatCustomDecimal(Conversions.ToString(dgvItem[14, dgvItem.CurrentRow.Index].Value), 2);
						frmPurchaseInvoiceItem2.txtExtraPrice.Text = Module1.formatCustomDecimal(Conversions.ToString(dgvItem[15, dgvItem.CurrentRow.Index].Value), 2);
						if (Conversion.Val(RuntimeHelpers.GetObjectValue(dgvItem[18, dgvItem.CurrentRow.Index].Value)) > 0.0)
						{
							frmPurchaseInvoiceItem2.cboItem.Enabled = false;
							frmPurchaseInvoiceItem2.txtQty.Enabled = false;
							frmPurchaseInvoiceItem2.txtStockQty.Enabled = false;
							frmPurchaseInvoiceItem2.btnDelete.Enabled = false;
							frmPurchaseInvoiceItem2.cboUnit.Enabled = false;
						}
						frmPurchaseInvoiceItem2.ShowDialog();
					}
					goto end_IL_0001;
				case 846:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmPurchaseInvoice", "OpenItem", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 846;
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
		frmPurchaseInvoicePayment frmPurchaseInvoicePayment2 = new frmPurchaseInvoicePayment(CurrentData: false, _currencyId);
		frmPurchaseInvoicePayment2.lblAmount.Text = "Jumlah (" + lblCurrencyName.Text + ")";
		frmPurchaseInvoicePayment2.lblCurrencyRate.Text = "Kurs " + lblCurrencyName.Text;
		frmPurchaseInvoicePayment2.CashAccountId = _cashAccountId;
		frmPurchaseInvoicePayment2.BankAccountId = _bankAccountId;
		frmPurchaseInvoicePayment2.ShowDialog();
		frmPurchaseInvoicePayment2.Close();
		frmPurchaseInvoicePayment2.Dispose();
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
						frmPurchaseInvoicePayment frmPurchaseInvoicePayment2 = new frmPurchaseInvoicePayment(CurrentData: true, _currencyId);
						frmPurchaseInvoicePayment2.CashAccountId = _cashAccountId;
						frmPurchaseInvoicePayment2.BankAccountId = _bankAccountId;
						frmPurchaseInvoicePayment2.lblAmount.Text = "Jumlah (" + lblCurrencyName.Text + ")";
						frmPurchaseInvoicePayment2.lblCurrencyRate.Text = "Kurs " + lblCurrencyName.Text;
						ComboBox cboSource = frmPurchaseInvoicePayment2.cboPaymentCode;
						Module1.comboBoundValue(ref cboSource, Conversions.ToDouble(dgvPayment[2, dgvPayment.CurrentRow.Index].Value));
						frmPurchaseInvoicePayment2.cboPaymentCode = cboSource;
						frmPurchaseInvoicePayment2.dtpPayment.Value = Conversions.ToDate(dgvPayment[4, dgvPayment.CurrentRow.Index].Value);
						frmPurchaseInvoicePayment2.txtAmount.Text = Module1.formatCustomDecimal(Conversions.ToString(dgvPayment[12, dgvPayment.CurrentRow.Index].Value), 2);
						frmPurchaseInvoicePayment2.chkPayInFront.Checked = Conversions.ToBoolean(Interaction.IIf(Operators.ConditionalCompareObjectEqual(dgvPayment[6, dgvPayment.CurrentRow.Index].Value, "Ya", TextCompare: false), true, false));
						if (Operators.ConditionalCompareObjectEqual(dgvPayment[5, dgvPayment.CurrentRow.Index].Value, "C/G", TextCompare: false))
						{
							frmPurchaseInvoicePayment2.dtpCheque.Value = Conversions.ToDate(dgvPayment[8, dgvPayment.CurrentRow.Index].Value);
							frmPurchaseInvoicePayment2.txtChequeNo.Text = Conversions.ToString(dgvPayment[9, dgvPayment.CurrentRow.Index].Value);
						}
						cboSource = frmPurchaseInvoicePayment2.cboAccount;
						Module1.comboBoundValue(ref cboSource, Conversions.ToDouble(dgvPayment[3, dgvPayment.CurrentRow.Index].Value));
						frmPurchaseInvoicePayment2.cboAccount = cboSource;
						frmPurchaseInvoicePayment2.txtCurrencyRate.Text = Module1.formatCustomDecimal(Conversions.ToString(dgvPayment[15, dgvPayment.CurrentRow.Index].Value), 2);
						frmPurchaseInvoicePayment2.ShowDialog();
					}
					else if (dgvPayment.Rows.Count > 0)
					{
						Interaction.MsgBox("Pembayaran hanya bisa dibuka di Form Pembayaran", MsgBoxStyle.Information);
					}
					goto end_IL_0001;
				case 796:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmPurchaseInvoice", "OpenPayment", "");
						goto end_IL_0001;
					}
					break;
				}
				goto IL_0352;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 796;
				continue;
			}
			break;
			IL_0352:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void dgvReturn_DoubleClick(object sender, EventArgs e)
	{
		OpenPurchaseReturn();
	}

	private void OpenPurchaseReturn()
	{
		if (dgvReturn.RowCount > 0)
		{
			MyProject.Forms.frmPurchaseReturn.Show();
			MyProject.Forms.frmPurchaseReturn.prepareForm(SaveNew: false, KeepSupplier: false);
			MyProject.Forms.frmPurchaseReturn.CurrentId = Conversions.ToDouble(dgvReturn[0, dgvReturn.CurrentRow.Index].Value);
			MyProject.Forms.frmPurchaseReturn.LoadData();
			MyProject.Forms.frmPurchaseReturn.Activate();
			MyProject.Forms.frmPurchaseReturn.WindowState = FormWindowState.Normal;
		}
	}

	private void dgvReturn_GotFocus(object sender, EventArgs e)
	{
		if (dgvReturn.RowCount > 0)
		{
			dgvReturn.CurrentRow.Selected = true;
		}
	}

	private void dgvReturn_LostFocus(object sender, EventArgs e)
	{
		if (dgvReturn.RowCount > 0)
		{
			dgvReturn.CurrentRow.Selected = false;
		}
	}

	private void dgvReturn_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			OpenPurchaseReturn();
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

	private void dgvReturn_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		CalculateTotalReturn();
	}

	private void dgvReturn_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		CalculateTotalReturn();
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
						if ((dgvItem.RowCount > 0) | (dgvPayment.RowCount > 0) | (dgvReturn.RowCount > 0))
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
							if (Operators.CompareString(cSupplier2.NPWP, "", TextCompare: false) != 0)
							{
								dtpTaxInvoice.Visible = true;
								txtTaxInvoiceNo.Visible = true;
								lblTaxDateDash.Visible = false;
								lblTaxNumberDash.Visible = false;
								_hasNPWP = true;
								lblSubTotalPrice.Visible = true;
								lblSubTotalPrice2.Visible = true;
								lblPPN.Visible = true;
								lblPPN2.Visible = true;
								chkPPN.Visible = true;
								chkPPN.Checked = true;
							}
							else
							{
								dtpTaxInvoice.Visible = false;
								txtTaxInvoiceNo.Visible = false;
								lblTaxDateDash.Visible = true;
								lblTaxNumberDash.Visible = true;
								_hasNPWP = false;
								lblSubTotalPrice.Visible = false;
								lblSubTotalPrice2.Visible = false;
								lblPPN.Visible = false;
								lblPPN2.Visible = false;
								chkPPN.Visible = false;
								chkPPN.Checked = true;
							}
							txtTaxInvoiceNo.Text = "";
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
							GetUnpaidReturn();
							btnItem.Enabled = true;
							btnReceivedItem.Enabled = true;
							_currentlySelectedComboIndex = cboSupplier.SelectedIndex;
						}
					}
					_suppressComboChange = false;
					goto end_IL_0001;
				case 857:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmPurchaseInvoice", "cboSupplier_SelectedIndexChanged", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 857;
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

	private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (TabControl1.SelectedIndex == 1)
		{
			if (dgvPayment.Rows.Count > 0)
			{
				dgvPayment.CurrentRow.Selected = false;
			}
		}
		else if (TabControl1.SelectedIndex == 2 && dgvReturn.Rows.Count > 0)
		{
			dgvReturn.CurrentRow.Selected = false;
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

	private void SaveData(bool CloseForm)
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
						_paidDate = DateTime.MinValue;
						int i;
						if ((Conversion.Val(lblTotalPayable.Text) > 0.0) | (Conversion.Val(lblTotalPrice.Text) == 0.0))
						{
							_paidDate = DateTime.MinValue;
						}
						else if ((Conversion.Val(lblTotalPayable.Text) == 0.0) & (Conversion.Val(lblTotalPayment.Text) == 0.0) & (Conversion.Val(lblTotalReturn.Text) == 0.0))
						{
							_paidDate = dtpInvoice.Value;
						}
						else
						{
							int num3 = dgvPayment.Rows.Count - 1;
							for (i = 0; i <= num3; i++)
							{
								if (Operators.ConditionalCompareObjectGreater(dgvPayment[4, i].Value, _paidDate, TextCompare: false))
								{
									_paidDate = Conversions.ToDate(dgvPayment[4, i].Value);
								}
							}
							int num4 = dgvReturn.Rows.Count - 1;
							for (i = 0; i <= num4; i++)
							{
								if (Operators.ConditionalCompareObjectEqual(dgvReturn[1, i].EditedFormattedValue, true, TextCompare: false) && Operators.ConditionalCompareObjectGreater(dgvReturn[2, i].Value, _paidDate, TextCompare: false))
								{
									_paidDate = Conversions.ToDate(dgvReturn[2, i].Value);
								}
							}
						}
						if (cboSupplier.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih supplier", MsgBoxStyle.Information);
							cboSupplier.Focus();
							goto end_IL_0001;
						}
						if (Operators.CompareString(txtInvoiceNo.Text, "", TextCompare: false) == 0)
						{
							Interaction.MsgBox("Masukkan nomer faktur", MsgBoxStyle.Information);
							txtInvoiceNo.Focus();
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
						if ((Operators.CompareString(lblTotalPayable.Text, "0", TextCompare: false) != 0) & (Conversions.ToDouble(cComboItem2.Value) == 0.0))
						{
							Interaction.MsgBox("Kode Tunai tidak bisa dipilih karena faktur masih belum lunas", (MsgBoxStyle)(-2147483624));
							cboInvoiceCode.Focus();
							goto end_IL_0001;
						}
						if ((cboInvoiceCode.SelectedIndex == 0) & (DateTime.Compare(dtpInvoice.Value, Conversions.ToDate(_paidDate.ToShortDateString())) < 0))
						{
							Interaction.MsgBox("Anda tidak bisa memilih kode penjualan Tunai\r\nkarena tanggal lunas melebihi tanggal faktur.", MsgBoxStyle.Information);
							cboInvoiceCode.Focus();
							goto end_IL_0001;
						}
						if (dgvItem.Rows.Count == 0)
						{
							Interaction.MsgBox("Faktur harus memiliki minimum 1 barang.", MsgBoxStyle.Information);
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
						if (Conversion.Val(Module1.unformatNumber(lblTotalPayable.Text)) < 0.0)
						{
							Interaction.MsgBox("Nilai hutang tidak boleh negatif.", MsgBoxStyle.Information);
							goto end_IL_0001;
						}
						if ((Conversion.Val(txtDeduction.Text) > 0.0) & (dgvPayment.RowCount == 0))
						{
							Interaction.MsgBox("Potongan hanya bisa diisi jika ada minimum 1 pembayaran.", MsgBoxStyle.Information);
							txtDeduction.Focus();
						}
						else if ((Conversion.Val(txtDeduction.Text) > 0.0) & (Conversion.Val(lblTotalPayable.Text) > 0.0))
						{
							Interaction.MsgBox("Potongan tidak bisa diisi karena Faktur masih belum lunas.", MsgBoxStyle.Information);
							txtDeduction.Focus();
						}
						cPurchaseInvoice cPurchaseInvoice2 = new cPurchaseInvoice(CurrentId);
						cPurchaseInvoiceItem[] array = new cPurchaseInvoiceItem[dgvItem.Rows.Count - 1 + 1];
						cPurchaseInvoicePayment[] array2 = new cPurchaseInvoicePayment[dgvPayment.Rows.Count - 1 + 1];
						i = 0;
						cPurchaseInvoice2.CurrentItem = cPurchaseInvoice2.Item;
						cPurchaseInvoice2.CurrentDate = cPurchaseInvoice2.InvoiceDate;
						cPurchaseInvoice2.SupplierId = Conversions.ToInteger(cComboItem3.Value);
						cPurchaseInvoice2.Number = txtInvoiceNo.Text;
						cPurchaseInvoice2.TaxNumber = txtTaxInvoiceNo.Text;
						cPurchaseInvoice2.InvoiceDate = dtpInvoice.Value;
						cPurchaseInvoice2.TaxInvoiceDate = dtpTaxInvoice.Value;
						cPurchaseInvoice2.isTaxIncluded = unchecked(0 - (chkPPN.Checked ? 1 : 0));
						cPurchaseInvoice2.InvoiceCode = Conversions.ToInteger(cComboItem2.Value);
						cPurchaseInvoice2.CurrencyId = _currencyId;
						cPurchaseInvoice2.CurrencyRate = Conversion.Val(Module1.unformatNumber(txtCurrencyRate.Text));
						cPurchaseInvoice2.Discount = Conversion.Val(Module1.unformatNumber(txtDiscount.Text));
						cPurchaseInvoice2.Deduction = Conversion.Val(Module1.unformatNumber(txtDeduction.Text));
						cPurchaseInvoice2.TotalPrice = Conversion.Val(Module1.unformatNumber(lblTotalPrice.Text));
						cPurchaseInvoice2.TotalReturn = Conversion.Val(Module1.unformatNumber(lblTotalReturn.Text));
						cPurchaseInvoice2.TotalPayment = Conversion.Val(Module1.unformatNumber(lblTotalPayment.Text));
						cPurchaseInvoice2.StorageId = Conversions.ToInteger(cComboItem4.Value);
						cPurchaseInvoice2.PaidDate = _paidDate;
						cPurchaseInvoice2.isReturn = 0;
						cPurchaseInvoice2.RiId = _riId;
						string text = "";
						int num5 = dgvItem.Rows.Count - 1;
						for (i = 0; i <= num5; i++)
						{
							array[i] = new cPurchaseInvoiceItem();
							array[i].ItemId = Conversions.ToInteger(dgvItem[1, i].Value);
							array[i].StorageId = Conversions.ToInteger(cComboItem4.Value);
							array[i].Description = Module1.cleanString(Conversions.ToString(dgvItem[5, i].Value));
							array[i].InvoiceQty = Conversions.ToDouble(dgvItem[6, i].Value);
							array[i].UnitName = Conversions.ToString(dgvItem[7, i].Value);
							array[i].StockQty = Conversions.ToDouble(dgvItem[9, i].Value);
							array[i].ParkedQty = Conversions.ToDouble(dgvItem[11, i].Value);
							array[i].Deduction = Conversions.ToDouble(dgvItem[12, i].Value);
							array[i].NetQty = Conversions.ToDouble(dgvItem[13, i].Value);
							array[i].Price = Conversions.ToDouble(dgvItem[14, i].Value);
							array[i].ExtraPrice = Conversions.ToDouble(dgvItem[15, i].Value);
							array[i].RiId = Conversions.ToDouble(dgvItem[18, i].Value);
							array[i].RiItemId = Conversions.ToDouble(dgvItem[19, i].Value);
							array[i].CurrencyId = _currencyId;
							array[i].CurrencyRate = Conversion.Val(Module1.unformatNumber(txtCurrencyRate.Text));
							array[i].InventoryAccountId = Conversions.ToInteger(dgvItem[20, i].Value);
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<tr><td>", dgvItem[4, i].Value), "</td>"), "<td>"), dgvItem[5, i].Value), "</td>"), "<td align='right'>"), dgvItem[8, i].Value), "</td>"), "<td align='right'>"), dgvItem[10, i].Value), "</td>"), "<td align='right'>"), Module1.formatCustomDecimal(Conversions.ToString(dgvItem[11, i].Value), 3)), "</td>"), "<td align='right'>"), Module1.formatCustomDecimal(Conversions.ToString(dgvItem[12, i].Value), 3)), "</td>"), "<td align='right'>"), Module1.formatCustomDecimal(Conversions.ToString(dgvItem[13, i].Value), 3)), "</td>"), "<td align='right'>"), Module1.formatCustomDecimal(Conversions.ToString(dgvItem[14, i].Value), 2)), "</td>"), "<td align='right'>"), Module1.formatCustomDecimal(Conversions.ToString(dgvItem[15, i].Value), 2)), "</td>"), "<td align='right'>"), Module1.formatCustomDecimal(Conversions.ToString(dgvItem[16, i].Value), 2)), "</td>"), "<td align='left'>"), dgvItem[17, i].Value), "</td></tr>")));
						}
						cPurchaseInvoice2.Item = array;
						string text2 = "";
						int num6 = dgvPayment.Rows.Count - 1;
						for (i = 0; i <= num6; i++)
						{
							array2[i] = new cPurchaseInvoicePayment();
							array2[i].PaymentDate = Conversions.ToDate(dgvPayment[4, i].Value);
							array2[i].Amount = Conversions.ToDouble(dgvPayment[12, i].Value);
							array2[i].InFront = Conversions.ToByte(Interaction.IIf(Operators.ConditionalCompareObjectEqual(dgvPayment[6, i].Value, "Ya", TextCompare: false), 1, 0));
							array2[i].PaymentCodeId = Conversions.ToByte(dgvPayment[2, i].Value);
							array2[i].MultiPaymentId = Conversions.ToDouble(dgvPayment[1, i].Value);
							array2[i].CreatedDate = Conversions.ToDate(dgvPayment[16, i].Value);
							array2[i].PaymentCodeName = Conversions.ToString(dgvPayment[5, i].Value);
							array2[i].CurrencyRate = Conversions.ToDouble(dgvPayment[15, i].Value);
							array2[i].AccountId = Conversions.ToInteger(dgvPayment[3, i].Value);
							if (Operators.ConditionalCompareObjectEqual(dgvPayment[5, i].Value, "C/G", TextCompare: false))
							{
								array2[i].ChequeDate = Conversions.ToDate(dgvPayment[8, i].Value);
								array2[i].ChequeNumber = Conversions.ToString(dgvPayment[9, i].Value);
							}
							text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<tr><td>", dgvPayment[4, i].Value), "</td>"), "<td>"), dgvPayment[5, i].Value), "</td>"), "<td>"), dgvPayment[6, i].Value), "</td>"), "<td>"), dgvPayment[8, i].Value), "</td>"), "<td>"), dgvPayment[9, i].Value), "</td>"), "<td align='right'>"), Module1.formatCustomDecimal(Conversions.ToString(dgvPayment[12, i].Value), 2)), "</td>"), "<td>"), dgvPayment[13, i].Value), "</td>"), "<td>"), dgvPayment[14, i].Value), "</td>"), "<td align='right'>"), Module1.formatCustomDecimal(Conversions.ToString(dgvPayment[15, i].Value), 2)), "</td></tr>")));
						}
						cPurchaseInvoice2.Payment = array2;
						string text3 = "";
						cPurchaseInvoiceReturn[] array3 = new cPurchaseInvoiceReturn[0];
						int num7 = 0;
						int num8 = dgvReturn.Rows.Count - 1;
						for (i = 0; i <= num8; i++)
						{
							if (Operators.ConditionalCompareObjectEqual(dgvReturn[1, i].EditedFormattedValue, true, TextCompare: false))
							{
								array3 = (cPurchaseInvoiceReturn[])Utils.CopyArray(array3, new cPurchaseInvoiceReturn[num7 + 1]);
								array3[num7] = new cPurchaseInvoiceReturn();
								array3[num7].Id = Conversions.ToDouble(dgvReturn[0, i].Value);
								array3[num7].Amount = Conversions.ToDouble(Module1.unformatNumber(Conversions.ToString(dgvReturn[4, i].Value)));
								text3 = Conversions.ToString(Operators.ConcatenateObject(text3, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<tr><td>", dgvReturn[2, i].Value), "</td><td>"), dgvReturn[3, i].Value), "</td><td align='right'>"), Module1.formatCustomDecimal(Conversions.ToString(dgvReturn[4, i].Value), 2)), "</td></tr>")));
								num7++;
							}
						}
						cPurchaseInvoice2.InvoiceReturn = array3;
						cPurchaseInvoice2.Save();
						string text4 = "Tanggal: " + Conversions.ToString(dtpInvoice.Value) + "<br />No Faktur: " + txtInvoiceNo.Text + "<br />Tanggal F. Pajak: " + Conversions.ToString(dtpTaxInvoice.Value) + "<br />No F. Pajak: " + txtTaxInvoiceNo.Text + "<br />Harga termasuk PPN: " + Conversions.ToString(chkPPN.Checked) + "<br />Tunai/Kredit: " + cboInvoiceCode.Text + "<br />Mata Uang: " + lblCurrencyName.Text + "<br />Kurs: " + txtCurrencyRate.Text + "<br />Gudang: " + cboStorage.Text + "<br />Discount: " + txtDiscount.Text + "<br />Potongan: " + txtDeduction.Text + "<br />";
						text4 += "Barang:<br />";
						text4 += "<table>";
						text4 += "<tr><td>Barang</td><td>Deskripsi</td><td>Jumlah</td><td>Jml. Stok</td><td>Jml. Parkir</td><td>Potongan</td><td>Jml. Bersih</td><td>Harga</td><td>Harga+</td><td>Total</td><td>No Penerimaan</td></tr>";
						text4 += text;
						text4 += "</table><br />";
						text4 += "<table>";
						text4 += "<tr><td>Tanggal</td><td>Tipe</td><td>Bon</td><td>Tgl C/G</td><td>No C/G</td><td>Jumlah</td><td>Akun</td><td>Mata Uang</td><td>Kurs</td></tr>";
						text4 += text2;
						text4 += "</table></br />";
						text4 += "<table>";
						text4 += "<tr><td>Tanggal</td><td>No Retur</td><td>Jumlah</td></tr>";
						text4 += text3;
						text4 += "</table><br />";
						string text5;
						if (_currentId == 0.0)
						{
							text5 = "membuat ";
							_currentId = cPurchaseInvoice2.Id;
						}
						else
						{
							text5 = "mengupdate ";
						}
						text5 = text5 + "faktur pembelian " + txtInvoiceNo.Text + " tanggal " + Strings.Format(dtpInvoice.Value, "dd/MM/yyyy") + ". ID= " + Conversions.ToString(_currentId) + ", v2";
						cHistory cHistory2 = new cHistory();
						cHistory2.Content = text4;
						cHistory2.Description = text5;
						cHistory2.UserId = Module1.pubUserId;
						cHistory2.UserLogin = Module1.pubLogin;
						cHistory2.fKeyId = CurrentId;
						cHistory2.HistoryType = 1;
						cHistory2.Save();
						Interaction.MsgBox("Faktur Pembelian berhasil disimpan", MsgBoxStyle.Information);
						if (Module1.FormIsOpen("frmPurchaseInvoiceList"))
						{
							MyProject.Forms.frmPurchaseInvoiceList.GetRecent();
						}
						if (Module1.FormIsOpen("frmSupplier"))
						{
							MyProject.Forms.frmSupplier.GetInvoice();
						}
						MyProject.Forms.frmInformation.GetActivity();
						if (CloseForm)
						{
							Close();
							goto end_IL_0001;
						}
						_suppressComboChange = true;
						prepareForm(SaveNew: true, KeepSupplier: false);
						goto end_IL_0001_2;
					}
					case 5237:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmPurchaseInvoice", "SaveData", "");
							goto end_IL_0001_2;
						}
						break;
					}
					goto IL_14ab;
				}
				end_IL_0001_2:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 5237;
				continue;
			}
			break;
			IL_14ab:
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
					if (MessageBox.Show("Hapus Faktur Pembelian?", "Konfirmasi", MessageBoxButtons.YesNo) != DialogResult.No)
					{
						cPurchaseInvoice cPurchaseInvoice2 = new cPurchaseInvoice(_currentId);
						cPurchaseInvoice2.CurrentItem = cPurchaseInvoice2.Item;
						cPurchaseInvoice2.CurrentDate = cPurchaseInvoice2.InvoiceDate;
						cPurchaseInvoice2.Delete();
						string description = "menghapus faktur pembelian " + cPurchaseInvoice2.Number + ". ID=" + Conversions.ToString(cPurchaseInvoice2.Id) + ", v2";
						cHistory cHistory2 = new cHistory();
						cHistory2.Description = description;
						cHistory2.UserId = Module1.pubUserId;
						cHistory2.UserLogin = Module1.pubLogin;
						cHistory2.fKeyId = _currentId;
						cHistory2.HistoryType = 1;
						cHistory2.Save();
						Interaction.MsgBox("Pembelian berhasil dihapus", MsgBoxStyle.Information);
						if (Module1.FormIsOpen("frmPurchaseInvoiceList"))
						{
							MyProject.Forms.frmPurchaseInvoiceList.GetRecent();
						}
						MyProject.Forms.frmInformation.GetActivity();
						Close();
					}
					goto end_IL_0001;
				case 320:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmPurchaseInvoice", "btnDelete_Click", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 320;
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
		MyProject.Forms.frmHistory.GetHistory(checked((int)Math.Round(_currentId)), 1);
		MyProject.Forms.frmHistory.Show();
		MyProject.Forms.frmHistory.Activate();
		MyProject.Forms.frmHistory.WindowState = FormWindowState.Normal;
	}

	private void chkPPN_CheckedChanged(object sender, EventArgs e)
	{
		calculateTotalInvoice();
	}

	private void dtpTaxInvoice_ValueChanged(object sender, EventArgs e)
	{
		calculateTotalInvoice();
	}
}
