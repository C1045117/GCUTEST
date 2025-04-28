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
using MySql.Data.MySqlClient;

namespace GCUv2;

[DesignerGenerated]
public class frmSalesInvoice : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvItem")]
	private DataGridView _dgvItem;

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
	[AccessedThroughProperty("txtDiscountValue")]
	private FilteredTextBox _txtDiscountValue;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnItem")]
	private Button _btnItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvReturn")]
	private DataGridView _dgvReturn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TabControl1")]
	private TabControl _TabControl1;

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
	[AccessedThroughProperty("txtInvoiceNumber")]
	private TextBox _txtInvoiceNumber;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dtpInvoice")]
	private DateTimePicker _dtpInvoice;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("txtTaxInvoiceNumber")]
	private TextBox _txtTaxInvoiceNumber;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dtpTaxInvoice")]
	private DateTimePicker _dtpTaxInvoice;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboInvoiceCode")]
	private ComboBox _cboInvoiceCode;

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
	[AccessedThroughProperty("txtDeduction")]
	private FilteredTextBox _txtDeduction;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboStorage")]
	private ComboBox _cboStorage;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboSalesPerson")]
	private ComboBox _cboSalesPerson;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnPrint")]
	private Button _btnPrint;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSearch")]
	private Button _btnSearch;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnCash")]
	private Button _btnCash;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnDO")]
	private Button _btnDO;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSO")]
	private Button _btnSO;

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

	private double _customerParentId;

	private int _branchId;

	private DateTime _originalDate;

	private int _originalStorageId;

	private bool _edited;

	private string _currentInvoiceNumber;

	private double _currentTaxInvoiceNumber;

	private bool _isDonation;

	private bool _fullyPaidWhenLoaded;

	private bool _disableDgvItem;

	private int _totalItem;

	private bool _authorised;

	private bool _wasCashInvoice;

	private int _totalUnpaid;

	private int _unpaidLimit;

	private cSalesInvoiceItem[] _item;

	private double[] _SOId;

	private double[] _DOId;

	private int _cashAccountId;

	private int _bankAccountId;

	private string _cashAccountName;

	private int _discountId;

	private bool _justLoaded;

	private bool _dateIsChanged;

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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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
			KeyEventHandler value3 = dgvReturn_KeyDown;
			DataGridViewCellEventHandler value4 = dgvReturn_CellContentClick;
			DataGridViewCellEventHandler value5 = dgvReturn_CellContentDoubleClick;
			DataGridView dataGridView = _dgvReturn;
			if (dataGridView != null)
			{
				dataGridView.DoubleClick -= value2;
				dataGridView.KeyDown -= value3;
				dataGridView.CellContentClick -= value4;
				dataGridView.CellContentDoubleClick -= value5;
			}
			_dgvReturn = value;
			dataGridView = _dgvReturn;
			if (dataGridView != null)
			{
				dataGridView.DoubleClick += value2;
				dataGridView.KeyDown += value3;
				dataGridView.CellContentClick += value4;
				dataGridView.CellContentDoubleClick += value5;
			}
		}
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

	[field: AccessedThroughProperty("TabPage3")]
	internal virtual TabPage TabPage3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("lblTotalReturn")]
	internal virtual Label lblTotalReturn
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

	internal virtual TextBox txtInvoiceNumber
	{
		[CompilerGenerated]
		get
		{
			return _txtInvoiceNumber;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = txtInvoiceNumber_TextChanged;
			TextBox textBox = _txtInvoiceNumber;
			if (textBox != null)
			{
				textBox.TextChanged -= value2;
			}
			_txtInvoiceNumber = value;
			textBox = _txtInvoiceNumber;
			if (textBox != null)
			{
				textBox.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
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

	internal virtual TextBox txtTaxInvoiceNumber
	{
		[CompilerGenerated]
		get
		{
			return _txtTaxInvoiceNumber;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = txtTaxInvoiceNumber_TextChanged;
			TextBox textBox = _txtTaxInvoiceNumber;
			if (textBox != null)
			{
				textBox.TextChanged -= value2;
			}
			_txtTaxInvoiceNumber = value;
			textBox = _txtTaxInvoiceNumber;
			if (textBox != null)
			{
				textBox.TextChanged += value2;
			}
		}
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

	[field: AccessedThroughProperty("Label19")]
	internal virtual Label Label19
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("Label20")]
	internal virtual Label Label20
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label21")]
	internal virtual Label Label21
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTotalNetPayment")]
	internal virtual Label lblTotalNetPayment
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label22")]
	internal virtual Label Label22
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label23")]
	internal virtual Label Label23
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label26")]
	internal virtual Label Label26
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label25")]
	internal virtual Label Label25
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dtpTF")]
	internal virtual DateTimePicker dtpTF
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label24")]
	internal virtual Label Label24
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

	[field: AccessedThroughProperty("chkUseOldPrice")]
	internal virtual CheckBox chkUseOldPrice
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label29")]
	internal virtual Label Label29
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

	internal virtual ComboBox cboSalesPerson
	{
		[CompilerGenerated]
		get
		{
			return _cboSalesPerson;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cboSalesPerson_SelectedIndexChanged;
			ComboBox comboBox = _cboSalesPerson;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_cboSalesPerson = value;
			comboBox = _cboSalesPerson;
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

	internal virtual Button btnCash
	{
		[CompilerGenerated]
		get
		{
			return _btnCash;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnCash_Click;
			Button button = _btnCash;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnCash = value;
			button = _btnCash;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button btnDO
	{
		[CompilerGenerated]
		get
		{
			return _btnDO;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnDO_Click;
			Button button = _btnDO;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnDO = value;
			button = _btnDO;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button btnSO
	{
		[CompilerGenerated]
		get
		{
			return _btnSO;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnSO_Click;
			Button button = _btnSO;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnSO = value;
			button = _btnSO;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("lblPaidDate")]
	internal virtual Label lblPaidDate
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

	[field: AccessedThroughProperty("lblTaxDateDash")]
	internal virtual Label lblTaxDateDash
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDiscountDescription")]
	internal virtual FilteredTextBox txtDiscountDescription
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

	public double[] SOId
	{
		get
		{
			return _SOId;
		}
		set
		{
			_SOId = value;
		}
	}

	public double[] DOId
	{
		get
		{
			return _DOId;
		}
		set
		{
			_DOId = value;
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

	public bool Authorised
	{
		get
		{
			return _authorised;
		}
		set
		{
			_authorised = value;
		}
	}

	public int UnpaidLimit
	{
		get
		{
			return _unpaidLimit;
		}
		set
		{
			_unpaidLimit = value;
		}
	}

	public bool IsDonation
	{
		get
		{
			return _isDonation;
		}
		set
		{
			_isDonation = value;
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
		this.dgvItem = new System.Windows.Forms.DataGridView();
		this.btnHistory = new System.Windows.Forms.Button();
		this.btnSaveClose = new System.Windows.Forms.Button();
		this.btnDelete = new System.Windows.Forms.Button();
		this.btnSave = new System.Windows.Forms.Button();
		this.Label10 = new System.Windows.Forms.Label();
		this.Label13 = new System.Windows.Forms.Label();
		this.Label12 = new System.Windows.Forms.Label();
		this.Label11 = new System.Windows.Forms.Label();
		this.Label9 = new System.Windows.Forms.Label();
		this.lblTotalInvoice = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.TabPage4 = new System.Windows.Forms.TabPage();
		this.txtNote = new System.Windows.Forms.TextBox();
		this.Label17 = new System.Windows.Forms.Label();
		this.cboSalesPerson = new System.Windows.Forms.ComboBox();
		this.chkUseOldPrice = new System.Windows.Forms.CheckBox();
		this.Label29 = new System.Windows.Forms.Label();
		this.Label27 = new System.Windows.Forms.Label();
		this.cboStorage = new System.Windows.Forms.ComboBox();
		this.Label26 = new System.Windows.Forms.Label();
		this.Label25 = new System.Windows.Forms.Label();
		this.dtpTF = new System.Windows.Forms.DateTimePicker();
		this.Label24 = new System.Windows.Forms.Label();
		this.cboTF = new System.Windows.Forms.ComboBox();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.btnDO = new System.Windows.Forms.Button();
		this.btnSO = new System.Windows.Forms.Button();
		this.btnItem = new System.Windows.Forms.Button();
		this.dgvReturn = new System.Windows.Forms.DataGridView();
		this.TabControl1 = new System.Windows.Forms.TabControl();
		this.TabPage2 = new System.Windows.Forms.TabPage();
		this.btnCash = new System.Windows.Forms.Button();
		this.dgvPayment = new System.Windows.Forms.DataGridView();
		this.btnPayment = new System.Windows.Forms.Button();
		this.TabPage3 = new System.Windows.Forms.TabPage();
		this.lblTotalReceivable = new System.Windows.Forms.Label();
		this.lblTotalPayment = new System.Windows.Forms.Label();
		this.lblTotalReturn = new System.Windows.Forms.Label();
		this.lblTotalPrice = new System.Windows.Forms.Label();
		this.txtInvoiceNumber = new System.Windows.Forms.TextBox();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.dtpInvoice = new System.Windows.Forms.DateTimePicker();
		this.txtTaxInvoiceNumber = new System.Windows.Forms.TextBox();
		this.lblTaxNumber = new System.Windows.Forms.Label();
		this.lblTaxDate = new System.Windows.Forms.Label();
		this.dtpTaxInvoice = new System.Windows.Forms.DateTimePicker();
		this.Label16 = new System.Windows.Forms.Label();
		this.cboInvoiceCode = new System.Windows.Forms.ComboBox();
		this.Label19 = new System.Windows.Forms.Label();
		this.lblCustomerAddress = new System.Windows.Forms.Label();
		this.lblCustomerName = new System.Windows.Forms.Label();
		this.Label20 = new System.Windows.Forms.Label();
		this.Label21 = new System.Windows.Forms.Label();
		this.lblTotalNetPayment = new System.Windows.Forms.Label();
		this.Label22 = new System.Windows.Forms.Label();
		this.Label23 = new System.Windows.Forms.Label();
		this.btnPrint = new System.Windows.Forms.Button();
		this.btnSearch = new System.Windows.Forms.Button();
		this.lblPaidDate = new System.Windows.Forms.Label();
		this.lblTaxNumberDash = new System.Windows.Forms.Label();
		this.lblTaxDateDash = new System.Windows.Forms.Label();
		this.txtDiscountDescription = new GCUv2.FilteredTextBox();
		this.txtDeduction = new GCUv2.FilteredTextBox();
		this.txtDiscountValue = new GCUv2.FilteredTextBox();
		((System.ComponentModel.ISupportInitialize)this.dgvItem).BeginInit();
		this.TabPage4.SuspendLayout();
		this.TabPage1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvReturn).BeginInit();
		this.TabControl1.SuspendLayout();
		this.TabPage2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvPayment).BeginInit();
		this.TabPage3.SuspendLayout();
		base.SuspendLayout();
		this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvItem.Location = new System.Drawing.Point(6, 38);
		this.dgvItem.Name = "dgvItem";
		this.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dgvItem.Size = new System.Drawing.Size(590, 156);
		this.dgvItem.TabIndex = 15;
		this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnHistory.Location = new System.Drawing.Point(547, 492);
		this.btnHistory.Name = "btnHistory";
		this.btnHistory.Size = new System.Drawing.Size(50, 24);
		this.btnHistory.TabIndex = 34;
		this.btnHistory.Text = "&History";
		this.btnHistory.UseVisualStyleBackColor = true;
		this.btnSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSaveClose.Location = new System.Drawing.Point(393, 492);
		this.btnSaveClose.Name = "btnSaveClose";
		this.btnSaveClose.Size = new System.Drawing.Size(93, 24);
		this.btnSaveClose.TabIndex = 32;
		this.btnSaveClose.Text = "Simpan && &Tutup";
		this.btnSaveClose.UseVisualStyleBackColor = true;
		this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDelete.Location = new System.Drawing.Point(492, 492);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new System.Drawing.Size(49, 24);
		this.btnDelete.TabIndex = 33;
		this.btnDelete.Text = "Hapus";
		this.btnDelete.UseVisualStyleBackColor = true;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(301, 492);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(86, 24);
		this.btnSave.TabIndex = 31;
		this.btnSave.Text = "&Simpan && Baru";
		this.btnSave.UseVisualStyleBackColor = true;
		this.Label10.BackColor = System.Drawing.Color.Silver;
		this.Label10.Location = new System.Drawing.Point(-15, 482);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(713, 59);
		this.Label10.TabIndex = 152;
		this.Label13.BackColor = System.Drawing.Color.Silver;
		this.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Label13.Location = new System.Drawing.Point(14, 437);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(482, 1);
		this.Label13.TabIndex = 150;
		this.Label12.AutoSize = true;
		this.Label12.Location = new System.Drawing.Point(325, 461);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(70, 13);
		this.Label12.TabIndex = 149;
		this.Label12.Text = "Total Piutang";
		this.Label11.AutoSize = true;
		this.Label11.Location = new System.Drawing.Point(325, 391);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(93, 13);
		this.Label11.TabIndex = 148;
		this.Label11.Text = "Total Pembayaran";
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(11, 441);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(31, 13);
		this.Label9.TabIndex = 147;
		this.Label9.Text = "Total";
		this.lblTotalInvoice.Location = new System.Drawing.Point(74, 441);
		this.lblTotalInvoice.Name = "lblTotalInvoice";
		this.lblTotalInvoice.Size = new System.Drawing.Size(90, 13);
		this.lblTotalInvoice.TabIndex = 146;
		this.lblTotalInvoice.Text = "Total Invoice";
		this.lblTotalInvoice.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(11, 371);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(63, 13);
		this.Label8.TabIndex = 144;
		this.Label8.Text = "Total Harga";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(11, 391);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(60, 13);
		this.Label3.TabIndex = 145;
		this.Label3.Text = "Total Retur";
		this.TabPage4.BackColor = System.Drawing.Color.DarkGray;
		this.TabPage4.Controls.Add(this.txtNote);
		this.TabPage4.Controls.Add(this.Label17);
		this.TabPage4.Controls.Add(this.cboSalesPerson);
		this.TabPage4.Controls.Add(this.chkUseOldPrice);
		this.TabPage4.Controls.Add(this.Label29);
		this.TabPage4.Controls.Add(this.Label27);
		this.TabPage4.Controls.Add(this.cboStorage);
		this.TabPage4.Controls.Add(this.Label26);
		this.TabPage4.Controls.Add(this.Label25);
		this.TabPage4.Controls.Add(this.dtpTF);
		this.TabPage4.Controls.Add(this.Label24);
		this.TabPage4.Controls.Add(this.cboTF);
		this.TabPage4.Location = new System.Drawing.Point(4, 22);
		this.TabPage4.Name = "TabPage4";
		this.TabPage4.Size = new System.Drawing.Size(644, 200);
		this.TabPage4.TabIndex = 3;
		this.TabPage4.Text = "Lain-lain";
		this.txtNote.AcceptsReturn = true;
		this.txtNote.Location = new System.Drawing.Point(88, 65);
		this.txtNote.MaxLength = 100;
		this.txtNote.Multiline = true;
		this.txtNote.Name = "txtNote";
		this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
		this.txtNote.Size = new System.Drawing.Size(190, 60);
		this.txtNote.TabIndex = 43;
		this.Label17.AutoSize = true;
		this.Label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label17.Location = new System.Drawing.Point(339, 12);
		this.Label17.Name = "Label17";
		this.Label17.Size = new System.Drawing.Size(33, 13);
		this.Label17.TabIndex = 152;
		this.Label17.Text = "Sales";
		this.cboSalesPerson.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboSalesPerson.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboSalesPerson.FormattingEnabled = true;
		this.cboSalesPerson.Location = new System.Drawing.Point(426, 8);
		this.cboSalesPerson.Name = "cboSalesPerson";
		this.cboSalesPerson.Size = new System.Drawing.Size(121, 21);
		this.cboSalesPerson.TabIndex = 45;
		this.chkUseOldPrice.AutoSize = true;
		this.chkUseOldPrice.Location = new System.Drawing.Point(88, 131);
		this.chkUseOldPrice.Name = "chkUseOldPrice";
		this.chkUseOldPrice.Size = new System.Drawing.Size(208, 17);
		this.chkUseOldPrice.TabIndex = 44;
		this.chkUseOldPrice.Text = "Faktur menggunakan extra harga lama";
		this.chkUseOldPrice.UseVisualStyleBackColor = true;
		this.Label29.AutoSize = true;
		this.Label29.Location = new System.Drawing.Point(14, 132);
		this.Label29.Name = "Label29";
		this.Label29.Size = new System.Drawing.Size(63, 13);
		this.Label29.TabIndex = 147;
		this.Label29.Text = "Extra Harga";
		this.Label27.AutoSize = true;
		this.Label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label27.Location = new System.Drawing.Point(339, 39);
		this.Label27.Name = "Label27";
		this.Label27.Size = new System.Drawing.Size(45, 13);
		this.Label27.TabIndex = 146;
		this.Label27.Text = "Gudang";
		this.cboStorage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboStorage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboStorage.FormattingEnabled = true;
		this.cboStorage.Location = new System.Drawing.Point(426, 35);
		this.cboStorage.Name = "cboStorage";
		this.cboStorage.Size = new System.Drawing.Size(121, 21);
		this.cboStorage.TabIndex = 46;
		this.Label26.AutoSize = true;
		this.Label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label26.Location = new System.Drawing.Point(14, 65);
		this.Label26.Name = "Label26";
		this.Label26.Size = new System.Drawing.Size(62, 13);
		this.Label26.TabIndex = 141;
		this.Label26.Text = "Keterangan";
		this.Label25.AutoSize = true;
		this.Label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label25.Location = new System.Drawing.Point(14, 39);
		this.Label25.Name = "Label25";
		this.Label25.Size = new System.Drawing.Size(56, 13);
		this.Label25.TabIndex = 138;
		this.Label25.Text = "Tgl. Tukar";
		this.dtpTF.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpTF.Location = new System.Drawing.Point(88, 36);
		this.dtpTF.Name = "dtpTF";
		this.dtpTF.Size = new System.Drawing.Size(121, 20);
		this.dtpTF.TabIndex = 42;
		this.Label24.AutoSize = true;
		this.Label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label24.Location = new System.Drawing.Point(14, 12);
		this.Label24.Name = "Label24";
		this.Label24.Size = new System.Drawing.Size(68, 13);
		this.Label24.TabIndex = 65;
		this.Label24.Text = "Tukar Faktur";
		this.cboTF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboTF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboTF.FormattingEnabled = true;
		this.cboTF.Location = new System.Drawing.Point(88, 9);
		this.cboTF.Name = "cboTF";
		this.cboTF.Size = new System.Drawing.Size(121, 21);
		this.cboTF.TabIndex = 41;
		this.TabPage1.Controls.Add(this.btnDO);
		this.TabPage1.Controls.Add(this.btnSO);
		this.TabPage1.Controls.Add(this.btnItem);
		this.TabPage1.Controls.Add(this.dgvItem);
		this.TabPage1.Location = new System.Drawing.Point(4, 22);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage1.Size = new System.Drawing.Size(644, 200);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = "Barang";
		this.TabPage1.UseVisualStyleBackColor = true;
		this.btnDO.BackColor = System.Drawing.SystemColors.ButtonFace;
		this.btnDO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDO.Location = new System.Drawing.Point(188, 8);
		this.btnDO.Name = "btnDO";
		this.btnDO.Size = new System.Drawing.Size(114, 24);
		this.btnDO.TabIndex = 14;
		this.btnDO.Text = "Pengiriman Pesanan";
		this.btnDO.UseVisualStyleBackColor = false;
		this.btnSO.BackColor = System.Drawing.SystemColors.ButtonFace;
		this.btnSO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSO.Location = new System.Drawing.Point(73, 8);
		this.btnSO.Name = "btnSO";
		this.btnSO.Size = new System.Drawing.Size(109, 24);
		this.btnSO.TabIndex = 13;
		this.btnSO.Text = "Pesanan Penjualan";
		this.btnSO.UseVisualStyleBackColor = false;
		this.btnItem.BackColor = System.Drawing.SystemColors.ButtonFace;
		this.btnItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnItem.Location = new System.Drawing.Point(6, 8);
		this.btnItem.Name = "btnItem";
		this.btnItem.Size = new System.Drawing.Size(61, 24);
		this.btnItem.TabIndex = 12;
		this.btnItem.Text = "+ Barang";
		this.btnItem.UseVisualStyleBackColor = false;
		this.dgvReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvReturn.Location = new System.Drawing.Point(11, 14);
		this.dgvReturn.Name = "dgvReturn";
		this.dgvReturn.Size = new System.Drawing.Size(388, 173);
		this.dgvReturn.TabIndex = 9;
		this.TabControl1.Controls.Add(this.TabPage1);
		this.TabControl1.Controls.Add(this.TabPage2);
		this.TabControl1.Controls.Add(this.TabPage3);
		this.TabControl1.Controls.Add(this.TabPage4);
		this.TabControl1.Location = new System.Drawing.Point(11, 136);
		this.TabControl1.Name = "TabControl1";
		this.TabControl1.SelectedIndex = 0;
		this.TabControl1.Size = new System.Drawing.Size(652, 226);
		this.TabControl1.TabIndex = 11;
		this.TabPage2.Controls.Add(this.btnCash);
		this.TabPage2.Controls.Add(this.dgvPayment);
		this.TabPage2.Controls.Add(this.btnPayment);
		this.TabPage2.Location = new System.Drawing.Point(4, 22);
		this.TabPage2.Name = "TabPage2";
		this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage2.Size = new System.Drawing.Size(644, 200);
		this.TabPage2.TabIndex = 1;
		this.TabPage2.Text = "Pembayaran";
		this.TabPage2.UseVisualStyleBackColor = true;
		this.btnCash.BackColor = System.Drawing.SystemColors.ButtonFace;
		this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCash.Location = new System.Drawing.Point(97, 6);
		this.btnCash.Name = "btnCash";
		this.btnCash.Size = new System.Drawing.Size(79, 24);
		this.btnCash.TabIndex = 7;
		this.btnCash.Text = "+ Cash ( F1 )";
		this.btnCash.UseVisualStyleBackColor = false;
		this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvPayment.Location = new System.Drawing.Point(7, 36);
		this.dgvPayment.Name = "dgvPayment";
		this.dgvPayment.Size = new System.Drawing.Size(631, 158);
		this.dgvPayment.TabIndex = 8;
		this.btnPayment.BackColor = System.Drawing.SystemColors.ButtonFace;
		this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnPayment.Location = new System.Drawing.Point(6, 6);
		this.btnPayment.Name = "btnPayment";
		this.btnPayment.Size = new System.Drawing.Size(85, 24);
		this.btnPayment.TabIndex = 6;
		this.btnPayment.Text = "+ Pembayaran";
		this.btnPayment.UseVisualStyleBackColor = false;
		this.TabPage3.Controls.Add(this.dgvReturn);
		this.TabPage3.Location = new System.Drawing.Point(4, 22);
		this.TabPage3.Name = "TabPage3";
		this.TabPage3.Size = new System.Drawing.Size(644, 200);
		this.TabPage3.TabIndex = 2;
		this.TabPage3.Text = "Retur";
		this.TabPage3.UseVisualStyleBackColor = true;
		this.lblTotalReceivable.Location = new System.Drawing.Point(405, 461);
		this.lblTotalReceivable.Name = "lblTotalReceivable";
		this.lblTotalReceivable.Size = new System.Drawing.Size(91, 20);
		this.lblTotalReceivable.TabIndex = 143;
		this.lblTotalReceivable.Text = "Total Receivable";
		this.lblTotalReceivable.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.lblTotalPayment.Location = new System.Drawing.Point(415, 391);
		this.lblTotalPayment.Name = "lblTotalPayment";
		this.lblTotalPayment.Size = new System.Drawing.Size(81, 13);
		this.lblTotalPayment.TabIndex = 142;
		this.lblTotalPayment.Text = "Total Payment";
		this.lblTotalPayment.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.lblTotalReturn.Location = new System.Drawing.Point(71, 391);
		this.lblTotalReturn.Name = "lblTotalReturn";
		this.lblTotalReturn.Size = new System.Drawing.Size(93, 13);
		this.lblTotalReturn.TabIndex = 141;
		this.lblTotalReturn.Text = "Total Return";
		this.lblTotalReturn.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.lblTotalPrice.Location = new System.Drawing.Point(74, 371);
		this.lblTotalPrice.Name = "lblTotalPrice";
		this.lblTotalPrice.Size = new System.Drawing.Size(90, 13);
		this.lblTotalPrice.TabIndex = 140;
		this.lblTotalPrice.Text = "Total Price";
		this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.txtInvoiceNumber.Location = new System.Drawing.Point(301, 57);
		this.txtInvoiceNumber.Name = "txtInvoiceNumber";
		this.txtInvoiceNumber.Size = new System.Drawing.Size(121, 20);
		this.txtInvoiceNumber.TabIndex = 2;
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.Location = new System.Drawing.Point(227, 60);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(57, 13);
		this.Label6.TabIndex = 139;
		this.Label6.Text = "No. Faktur";
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(12, 413);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(40, 13);
		this.Label5.TabIndex = 138;
		this.Label5.Text = "Diskon";
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(8, 61);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(46, 13);
		this.Label1.TabIndex = 136;
		this.Label1.Text = "Tanggal";
		this.dtpInvoice.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpInvoice.Location = new System.Drawing.Point(94, 57);
		this.dtpInvoice.Name = "dtpInvoice";
		this.dtpInvoice.Size = new System.Drawing.Size(121, 20);
		this.dtpInvoice.TabIndex = 1;
		this.txtTaxInvoiceNumber.Location = new System.Drawing.Point(301, 83);
		this.txtTaxInvoiceNumber.Name = "txtTaxInvoiceNumber";
		this.txtTaxInvoiceNumber.Size = new System.Drawing.Size(121, 20);
		this.txtTaxInvoiceNumber.TabIndex = 4;
		this.lblTaxNumber.AutoSize = true;
		this.lblTaxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblTaxNumber.Location = new System.Drawing.Point(227, 86);
		this.lblTaxNumber.Name = "lblTaxNumber";
		this.lblTaxNumber.Size = new System.Drawing.Size(66, 13);
		this.lblTaxNumber.TabIndex = 157;
		this.lblTaxNumber.Text = "No. F. Pajak";
		this.lblTaxDate.AutoSize = true;
		this.lblTaxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblTaxDate.Location = new System.Drawing.Point(8, 86);
		this.lblTaxDate.Name = "lblTaxDate";
		this.lblTaxDate.Size = new System.Drawing.Size(67, 13);
		this.lblTaxDate.TabIndex = 156;
		this.lblTaxDate.Text = "Tgl. F. Pajak";
		this.dtpTaxInvoice.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpTaxInvoice.Location = new System.Drawing.Point(94, 83);
		this.dtpTaxInvoice.Name = "dtpTaxInvoice";
		this.dtpTaxInvoice.Size = new System.Drawing.Size(121, 20);
		this.dtpTaxInvoice.TabIndex = 3;
		this.Label16.AutoSize = true;
		this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label16.Location = new System.Drawing.Point(8, 111);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(66, 13);
		this.Label16.TabIndex = 159;
		this.Label16.Text = "Tunai/Kredit";
		this.cboInvoiceCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboInvoiceCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboInvoiceCode.FormattingEnabled = true;
		this.cboInvoiceCode.Location = new System.Drawing.Point(94, 109);
		this.cboInvoiceCode.Name = "cboInvoiceCode";
		this.cboInvoiceCode.Size = new System.Drawing.Size(121, 21);
		this.cboInvoiceCode.TabIndex = 5;
		this.Label19.BackColor = System.Drawing.SystemColors.ButtonHighlight;
		this.Label19.Location = new System.Drawing.Point(-12, -7);
		this.Label19.Name = "Label19";
		this.Label19.Size = new System.Drawing.Size(691, 58);
		this.Label19.TabIndex = 162;
		this.lblCustomerAddress.AutoSize = true;
		this.lblCustomerAddress.BackColor = System.Drawing.SystemColors.ButtonHighlight;
		this.lblCustomerAddress.Cursor = System.Windows.Forms.Cursors.Hand;
		this.lblCustomerAddress.Location = new System.Drawing.Point(8, 30);
		this.lblCustomerAddress.Name = "lblCustomerAddress";
		this.lblCustomerAddress.Size = new System.Drawing.Size(99, 13);
		this.lblCustomerAddress.TabIndex = 167;
		this.lblCustomerAddress.Text = "lblCustomerAddress";
		this.lblCustomerName.AutoSize = true;
		this.lblCustomerName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
		this.lblCustomerName.Cursor = System.Windows.Forms.Cursors.Hand;
		this.lblCustomerName.Location = new System.Drawing.Point(8, 9);
		this.lblCustomerName.Name = "lblCustomerName";
		this.lblCustomerName.Size = new System.Drawing.Size(89, 13);
		this.lblCustomerName.TabIndex = 165;
		this.lblCustomerName.Text = "lblCustomerName";
		this.lblCustomerName.UseMnemonic = false;
		this.Label20.AutoSize = true;
		this.Label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label20.Location = new System.Drawing.Point(325, 415);
		this.Label20.Name = "Label20";
		this.Label20.Size = new System.Drawing.Size(53, 13);
		this.Label20.TabIndex = 170;
		this.Label20.Text = "Potongan";
		this.Label21.AutoSize = true;
		this.Label21.Location = new System.Drawing.Point(325, 441);
		this.Label21.Name = "Label21";
		this.Label21.Size = new System.Drawing.Size(31, 13);
		this.Label21.TabIndex = 172;
		this.Label21.Text = "Total";
		this.lblTotalNetPayment.Location = new System.Drawing.Point(415, 441);
		this.lblTotalNetPayment.Name = "lblTotalNetPayment";
		this.lblTotalNetPayment.Size = new System.Drawing.Size(81, 13);
		this.lblTotalNetPayment.TabIndex = 171;
		this.lblTotalNetPayment.Text = "Total Net Payment";
		this.lblTotalNetPayment.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.Label22.BackColor = System.Drawing.Color.Silver;
		this.Label22.Location = new System.Drawing.Point(281, 365);
		this.Label22.Name = "Label22";
		this.Label22.Size = new System.Drawing.Size(1, 120);
		this.Label22.TabIndex = 173;
		this.Label23.BackColor = System.Drawing.Color.Silver;
		this.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Label23.Location = new System.Drawing.Point(15, 457);
		this.Label23.Name = "Label23";
		this.Label23.Size = new System.Drawing.Size(482, 1);
		this.Label23.TabIndex = 174;
		this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnPrint.Location = new System.Drawing.Point(603, 492);
		this.btnPrint.Name = "btnPrint";
		this.btnPrint.Size = new System.Drawing.Size(60, 24);
		this.btnPrint.TabIndex = 35;
		this.btnPrint.Text = "Preview";
		this.btnPrint.UseVisualStyleBackColor = true;
		this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnSearch.Location = new System.Drawing.Point(540, 12);
		this.btnSearch.Name = "btnSearch";
		this.btnSearch.Size = new System.Drawing.Size(83, 23);
		this.btnSearch.TabIndex = 0;
		this.btnSearch.Text = "Pilih Customer";
		this.btnSearch.UseVisualStyleBackColor = true;
		this.lblPaidDate.AutoSize = true;
		this.lblPaidDate.Location = new System.Drawing.Point(504, 461);
		this.lblPaidDate.Name = "lblPaidDate";
		this.lblPaidDate.Size = new System.Drawing.Size(61, 13);
		this.lblPaidDate.TabIndex = 180;
		this.lblPaidDate.Text = "lblPaidDate";
		this.lblTaxNumberDash.AutoSize = true;
		this.lblTaxNumberDash.Location = new System.Drawing.Point(300, 86);
		this.lblTaxNumberDash.Name = "lblTaxNumberDash";
		this.lblTaxNumberDash.Size = new System.Drawing.Size(10, 13);
		this.lblTaxNumberDash.TabIndex = 185;
		this.lblTaxNumberDash.Text = "-";
		this.lblTaxDateDash.AutoSize = true;
		this.lblTaxDateDash.Location = new System.Drawing.Point(95, 86);
		this.lblTaxDateDash.Name = "lblTaxDateDash";
		this.lblTaxDateDash.Size = new System.Drawing.Size(10, 13);
		this.lblTaxDateDash.TabIndex = 184;
		this.lblTaxDateDash.Text = "-";
		this.txtDiscountDescription.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtDiscountDescription.DontFormat = false;
		this.txtDiscountDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtDiscountDescription.Location = new System.Drawing.Point(170, 411);
		this.txtDiscountDescription.MaximumDigit = 3;
		this.txtDiscountDescription.Name = "txtDiscountDescription";
		this.txtDiscountDescription.Size = new System.Drawing.Size(87, 21);
		this.txtDiscountDescription.TabIndex = 22;
		this.txtDeduction.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtDeduction.DontFormat = false;
		this.txtDeduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtDeduction.Location = new System.Drawing.Point(409, 412);
		this.txtDeduction.MaximumDigit = 3;
		this.txtDeduction.Name = "txtDeduction";
		this.txtDeduction.Size = new System.Drawing.Size(87, 21);
		this.txtDeduction.TabIndex = 23;
		this.txtDeduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.txtDiscountValue.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtDiscountValue.DontFormat = false;
		this.txtDiscountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtDiscountValue.Location = new System.Drawing.Point(77, 411);
		this.txtDiscountValue.MaximumDigit = 3;
		this.txtDiscountValue.Name = "txtDiscountValue";
		this.txtDiscountValue.Size = new System.Drawing.Size(87, 21);
		this.txtDiscountValue.TabIndex = 21;
		this.txtDiscountValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(675, 523);
		base.Controls.Add(this.txtDiscountDescription);
		base.Controls.Add(this.lblTaxNumberDash);
		base.Controls.Add(this.lblTaxDateDash);
		base.Controls.Add(this.lblPaidDate);
		base.Controls.Add(this.btnSearch);
		base.Controls.Add(this.btnPrint);
		base.Controls.Add(this.Label23);
		base.Controls.Add(this.Label22);
		base.Controls.Add(this.Label21);
		base.Controls.Add(this.lblTotalNetPayment);
		base.Controls.Add(this.Label20);
		base.Controls.Add(this.txtDeduction);
		base.Controls.Add(this.lblCustomerAddress);
		base.Controls.Add(this.lblCustomerName);
		base.Controls.Add(this.Label19);
		base.Controls.Add(this.Label16);
		base.Controls.Add(this.cboInvoiceCode);
		base.Controls.Add(this.txtTaxInvoiceNumber);
		base.Controls.Add(this.lblTaxNumber);
		base.Controls.Add(this.lblTaxDate);
		base.Controls.Add(this.dtpTaxInvoice);
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
		base.Controls.Add(this.Label8);
		base.Controls.Add(this.txtDiscountValue);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.TabControl1);
		base.Controls.Add(this.lblTotalReceivable);
		base.Controls.Add(this.lblTotalPayment);
		base.Controls.Add(this.lblTotalReturn);
		base.Controls.Add(this.lblTotalPrice);
		base.Controls.Add(this.txtInvoiceNumber);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.dtpInvoice);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSalesInvoice";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Faktur Penjualan";
		((System.ComponentModel.ISupportInitialize)this.dgvItem).EndInit();
		this.TabPage4.ResumeLayout(false);
		this.TabPage4.PerformLayout();
		this.TabPage1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgvReturn).EndInit();
		this.TabControl1.ResumeLayout(false);
		this.TabPage2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgvPayment).EndInit();
		this.TabPage3.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmSalesInvoice()
	{
		base.KeyDown += frmSalesInvoice_KeyDown;
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
					txtDiscountValue.AllowedCharacters = FilteredTextBox.InputType.NumeralsAndCurrency;
					txtDiscountDescription.AllowedCharacters = FilteredTextBox.InputType.All;
					txtDiscountDescription.DontFormat = true;
					ComboBox combo = cboInvoiceCode;
					cCombo.getInvoiceCode(ref combo, All: false);
					cboInvoiceCode = combo;
					formatGrid();
					goto end_IL_001b;
				}
				case 169:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSalesInvoice", "New", "");
						goto end_IL_001b;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try001b_dispatch = 169;
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

	private void cboSalesPerson_SelectedIndexChanged(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboSalesPerson.SelectedItem;
		ComboBox combo = cboTF;
		cCombo.getSalesPerson(ref combo, "SALESPERSON_COLLECTOR", Conversions.ToInteger(cComboItem2.Value), 0, _branchId, Module1.pubGroupId, All: false, Dash: true, 1);
		cboTF = combo;
		cboTF.SelectedIndex = 0;
		cSalesPerson cSalesPerson2 = new cSalesPerson(Conversions.ToInteger(cComboItem2.Value));
		IsDonation = cSalesPerson2.IsDonator != 0;
	}

	private void frmSalesInvoice_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
		else if (e.KeyCode == Keys.F1)
		{
			btnCash_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}

	private void formatGrid()
	{
		DataGridViewComboBoxColumn dataGridViewComboBoxColumn = new DataGridViewComboBoxColumn();
		dataGridViewComboBoxColumn.HeaderText = "--Produk--";
		dataGridViewComboBoxColumn.Name = "item";
		dataGridViewComboBoxColumn.AutoComplete = true;
		dataGridViewComboBoxColumn.Items.Add("A");
		dataGridViewComboBoxColumn.Items.Add("Ba");
		dataGridViewComboBoxColumn.Items.Add("Bca");
		dataGridViewComboBoxColumn.Items.Add("Bcb");
		dataGridViewComboBoxColumn.Items.Add("Bcd");
		dataGridViewComboBoxColumn.Items.Add("Ca");
		dgvItem.Columns.Add("", "prodId");
		dgvItem.Columns.Add("", "Barang");
		dgvItem.Columns.Add("", "Deskripsi");
		dgvItem.Columns.Add("", "Jumlah");
		dgvItem.Columns.Add("", "Harga");
		dgvItem.Columns.Add("", "Total");
		dgvItem.Columns.Add("", "BasePrice");
		dgvItem.Columns.Add("", "BaseTotal");
		dgvItem.Columns.Add("", "Teh GOPEK");
		dgvItem.Columns.Add("", "LongName");
		dgvItem.Columns.Add("", "Packaging");
		dgvItem.Columns.Add("", "SmallUnit");
		dgvItem.Columns.Add("", "SmallQty");
		dgvItem.Columns.Add("", "LargeUnit");
		dgvItem.Columns.Add("", "No Pesanan");
		dgvItem.Columns.Add("", "No Pengiriman");
		dgvItem.Columns.Add("", "SOId");
		dgvItem.Columns.Add("", "DOId");
		dgvItem.Columns.Add("", "ParentItemId");
		dgvItem.Columns[0].Visible = false;
		dgvItem.Columns[2].Visible = false;
		dgvItem.Columns[6].Visible = false;
		dgvItem.Columns[7].Visible = false;
		dgvItem.Columns[8].Visible = false;
		dgvItem.Columns[9].Visible = false;
		dgvItem.Columns[10].Visible = false;
		dgvItem.Columns[11].Visible = false;
		dgvItem.Columns[12].Visible = false;
		dgvItem.Columns[13].Visible = false;
		dgvItem.Columns[16].Visible = false;
		dgvItem.Columns[17].Visible = false;
		dgvItem.Columns[18].Visible = false;
		dgvItem.Columns[1].Width = 100;
		dgvItem.Columns[2].Width = 160;
		dgvItem.Columns[3].Width = 100;
		dgvItem.Columns[4].Width = 120;
		dgvItem.Columns[5].Width = 80;
		dgvItem.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItem.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItem.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItem.RowHeadersVisible = false;
		dgvItem.AllowUserToAddRows = false;
		dgvItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvItem.ReadOnly = true;
		dgvItem.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvItem.AllowUserToResizeRows = false;
		dgvPayment.Columns.Add("", "payId");
		dgvPayment.Columns.Add("", "mpayId");
		dgvPayment.Columns.Add("", "paymentCodeId");
		dgvPayment.Columns.Add("", "salesId");
		dgvPayment.Columns.Add("", "bankId");
		dgvPayment.Columns.Add("", "Tanggal");
		dgvPayment.Columns.Add("", "Tipe");
		dgvPayment.Columns.Add("", "Penagih");
		dgvPayment.Columns.Add("", "Tgl C/G");
		dgvPayment.Columns.Add("", "No C/G");
		dgvPayment.Columns.Add("", "Bank");
		dgvPayment.Columns.Add("", "Jumlah");
		dgvPayment.Columns.Add("", "Akun");
		dgvPayment.Columns.Add("", "accountId");
		dgvPayment.Columns.Add("", "gcSetorDate");
		dgvPayment.Columns.Add("", "gcMasukDate");
		dgvPayment.Columns.Add("", "CreatedDate");
		dgvPayment.Columns[0].Visible = false;
		dgvPayment.Columns[1].Visible = false;
		dgvPayment.Columns[2].Visible = false;
		dgvPayment.Columns[3].Visible = false;
		dgvPayment.Columns[4].Visible = false;
		dgvPayment.Columns[13].Visible = false;
		dgvPayment.Columns[14].Visible = false;
		dgvPayment.Columns[15].Visible = false;
		dgvPayment.Columns[16].Visible = false;
		dgvPayment.Columns[5].Width = 75;
		dgvPayment.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvPayment.Columns[6].Width = 50;
		dgvPayment.Columns[7].Width = 80;
		dgvPayment.Columns[8].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvPayment.Columns[8].Width = 75;
		dgvPayment.Columns[9].Width = 80;
		dgvPayment.Columns[10].Width = 80;
		dgvPayment.Columns[11].Width = 80;
		dgvPayment.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvPayment.Columns[12].Width = 100;
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
		dgvReturn.RowHeadersVisible = false;
		dgvReturn.AllowUserToAddRows = false;
		dgvReturn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvReturn.Columns[2].ReadOnly = true;
		dgvReturn.Columns[3].ReadOnly = true;
		dgvReturn.Columns[4].ReadOnly = true;
		dgvReturn.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvReturn.AllowUserToResizeRows = false;
	}

	public void prepareForm(bool SaveNew)
	{
		_disableDgvItem = false;
		_justLoaded = false;
		_authorised = false;
		_wasCashInvoice = false;
		btnSearch.Visible = true;
		_currentId = 0.0;
		_currentlySelectedComboIndex = -1;
		_fullyPaidWhenLoaded = false;
		if (!SaveNew)
		{
			dtpInvoice.Value = DateAndTime.Now;
		}
		_dateIsChanged = false;
		OriginalDate = DateAndTime.Now;
		OriginalStorageId = 0;
		dtpTaxInvoice.Visible = false;
		txtTaxInvoiceNumber.Visible = false;
		lblCustomerName.Text = "Klik tombol 'Pilih Customer' untuk memilih customer";
		lblCustomerAddress.Text = "";
		TabControl1.SelectedIndex = 0;
		dgvItem.Rows.Clear();
		dgvPayment.Rows.Clear();
		dgvReturn.Rows.Clear();
		txtInvoiceNumber.Text = "";
		txtTaxInvoiceNumber.Text = "";
		txtDiscountValue.Text = "";
		txtDiscountDescription.Text = "";
		txtDeduction.Text = "";
		btnSave.Enabled = true;
		btnSaveClose.Enabled = true;
		btnDelete.Enabled = false;
		btnHistory.Enabled = false;
		btnPrint.Enabled = false;
		lblTotalPrice.Text = "";
		lblTotalInvoice.Text = "";
		lblTotalReceivable.Text = "";
		lblTotalPayment.Text = "";
		lblTotalNetPayment.Text = "";
		lblTotalReturn.Text = "";
		lblPaidDate.Text = "Tgl. Lunas: -";
		lblPaidDate.Visible = false;
		if (Module1.pubModifySalesInvoice)
		{
			dtpInvoice.Enabled = true;
			dtpTaxInvoice.Enabled = true;
			btnItem.Enabled = true;
			txtDiscountDescription.Enabled = true;
			txtDiscountValue.Enabled = true;
			btnDO.Enabled = true;
			btnSO.Enabled = true;
		}
		else
		{
			dtpInvoice.Enabled = false;
			dtpTaxInvoice.Enabled = false;
			btnItem.Enabled = false;
			txtDiscountDescription.Enabled = false;
			txtDiscountValue.Enabled = false;
			btnDO.Enabled = false;
			btnSO.Enabled = false;
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
		_edited = false;
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
					OriginalDate = cSalesInvoice2.InvoiceDate;
					OriginalStorageId = cSalesInvoice2.StorageId;
					_cashAccountId = cSalesInvoice2.CashAccountId;
					_bankAccountId = cSalesInvoice2.BankAccountId;
					_cashAccountName = cSalesInvoice2.CashAccountName;
					_customerId = cSalesInvoice2.CustomerId;
					_customerParentId = cSalesInvoice2.CustomerParentId;
					_branchId = cSalesInvoice2.BranchId;
					_discountId = cSalesInvoice2.DiscountId;
					ComboBox combo = cboSalesPerson;
					cCombo.getSalesPerson(ref combo, "SALESPERSON", 0, 99, cSalesInvoice2.BranchId, Module1.pubGroupId, All: false, Dash: false, 1);
					cboSalesPerson = combo;
					combo = cboStorage;
					cCombo.getStorage(ref combo, Module1.pubGroupId, cSalesInvoice2.BranchId, "MARKETING", blnAll: false, 1);
					cboStorage = combo;
					if (!Information.IsDBNull(cSalesInvoice2.PaidDate) && DateTime.Compare(cSalesInvoice2.PaidDate, DateTime.MinValue) > 0)
					{
						lblPaidDate.Text = "Tgl. Lunas: " + Conversions.ToString(cSalesInvoice2.PaidDate);
						lblPaidDate.Visible = true;
					}
					DateTime createdDate = cSalesInvoice2.CreatedDate;
					if (DateAndTime.DateDiff(DateInterval.Day, createdDate, DateAndTime.Now) <= Module1.pubDaysLimit)
					{
						btnDelete.Enabled = true;
					}
					else
					{
						btnDelete.Enabled = false;
					}
					if (cSalesInvoice2.InvoiceCode == 0)
					{
						_wasCashInvoice = true;
					}
					else
					{
						_wasCashInvoice = false;
					}
					lblCustomerName.Text = cSalesInvoice2.CustomerName;
					lblCustomerAddress.Text = cSalesInvoice2.CustomerAddress;
					_justLoaded = true;
					dtpInvoice.Value = cSalesInvoice2.InvoiceDate;
					_dateIsChanged = false;
					_justLoaded = false;
					txtInvoiceNumber.Text = cSalesInvoice2.Number;
					txtTaxInvoiceNumber.Text = Module1.FormatTaxInvoiceNumber(Conversions.ToString(cSalesInvoice2.TaxNumber));
					if (cSalesInvoice2.TaxNumber > 0.0)
					{
						dtpTaxInvoice.Visible = true;
						txtTaxInvoiceNumber.Visible = true;
						lblTaxDateDash.Visible = false;
						lblTaxNumberDash.Visible = false;
					}
					else
					{
						dtpTaxInvoice.Visible = false;
						txtTaxInvoiceNumber.Visible = false;
						lblTaxDateDash.Visible = true;
						lblTaxNumberDash.Visible = true;
					}
					_customerPT = cSalesInvoice2.CustomerPT;
					_customerNPWP = cSalesInvoice2.CustomerNPWP;
					_customerTaxAddress = cSalesInvoice2.CustomerTaxAddress;
					dtpTaxInvoice.Value = cSalesInvoice2.TaxInvoiceDate;
					combo = cboInvoiceCode;
					Module1.comboBoundValue(ref combo, cSalesInvoice2.InvoiceCode);
					cboInvoiceCode = combo;
					txtDiscountValue.Text = Module1.formatCustomDecimal(Conversions.ToString(cSalesInvoice2.Discount), 2);
					txtDiscountDescription.Text = cSalesInvoice2.DiscountDescription;
					txtDeduction.Text = Module1.formatCustomDecimal(Conversions.ToString(cSalesInvoice2.Deduction), 2);
					combo = cboSalesPerson;
					Module1.comboBoundValue(ref combo, cSalesInvoice2.SalesPersonId);
					cboSalesPerson = combo;
					combo = cboTF;
					Module1.comboBoundValue(ref combo, cSalesInvoice2.TukarFaktur);
					cboTF = combo;
					combo = cboStorage;
					Module1.comboBoundValue(ref combo, cSalesInvoice2.StorageId);
					cboStorage = combo;
					dtpTF.Value = cSalesInvoice2.TukarFakturDate;
					txtNote.Text = cSalesInvoice2.Note;
					chkUseOldPrice.Checked = cSalesInvoice2.UseOldPrice != 0;
					_currentInvoiceNumber = cSalesInvoice2.Number;
					_currentTaxInvoiceNumber = cSalesInvoice2.TaxNumber;
					dgvItem.Rows.Clear();
					cSalesInvoiceItem[] item = cSalesInvoice2.Item;
					foreach (cSalesInvoiceItem cSalesInvoiceItem2 in item)
					{
						dgvItem.Rows.Add(cSalesInvoiceItem2.ItemId, Operators.ConcatenateObject(Interaction.IIf(cSalesInvoiceItem2.ParentItemId > 0, "|--- ", ""), cSalesInvoiceItem2.Name), cSalesInvoiceItem2.Description, Module1.formatCustomDecimal(Conversions.ToString(cSalesInvoiceItem2.Qty), 3), Module1.formatCustomDecimal(Conversions.ToString(cSalesInvoiceItem2.Price), 2), Module1.formatCustomDecimal(Conversions.ToString(cSalesInvoiceItem2.Price * cSalesInvoiceItem2.Qty), 2), cSalesInvoiceItem2.BasePrice, cSalesInvoiceItem2.BasePrice * cSalesInvoiceItem2.Qty, cSalesInvoiceItem2.GeneralType, cSalesInvoiceItem2.LongName, cSalesInvoiceItem2.Packaging, cSalesInvoiceItem2.SmallUnit, cSalesInvoiceItem2.SmallQtyMultiplier, cSalesInvoiceItem2.LargeUnit, cSalesInvoiceItem2.PONumber, cSalesInvoiceItem2.DONumber, cSalesInvoiceItem2.SOId, cSalesInvoiceItem2.DOId, cSalesInvoiceItem2.ParentItemId);
					}
					_item = cSalesInvoice2.Item;
					if (dgvItem.Rows.Count > 0)
					{
						dgvItem.CurrentRow.Selected = false;
					}
					calculateTotalPrice();
					dgvPayment.Rows.Clear();
					cSalesInvoicePayment[] payment = cSalesInvoice2.Payment;
					foreach (cSalesInvoicePayment cSalesInvoicePayment2 in payment)
					{
						dgvPayment.Rows.Add(cSalesInvoicePayment2.PaymentId, cSalesInvoicePayment2.MultiPaymentId, cSalesInvoicePayment2.PaymentCodeId, cSalesInvoicePayment2.SalesPersonId, cSalesInvoicePayment2.BankId, cSalesInvoicePayment2.PaymentDate, cSalesInvoicePayment2.PaymentCodeName, cSalesInvoicePayment2.SalesPersonName, Interaction.IIf(Operators.CompareString(Strings.Right(cSalesInvoicePayment2.PaymentCodeName, 3), "C/G", TextCompare: false) == 0, cSalesInvoicePayment2.ChequeDate, ""), cSalesInvoicePayment2.ChequeNumber, cSalesInvoicePayment2.BankName, Module1.formatCustomDecimal(Conversions.ToString(cSalesInvoicePayment2.Amount), 2), cSalesInvoicePayment2.AccountName, cSalesInvoicePayment2.AccountId, cSalesInvoicePayment2.ChequeDepositDate, cSalesInvoicePayment2.ChequeClearingDate, cSalesInvoicePayment2.CreatedDate);
					}
					calculateTotalPayment();
					dgvReturn.Rows.Clear();
					cSalesInvoiceReturn[] invoiceReturn = cSalesInvoice2.InvoiceReturn;
					foreach (cSalesInvoiceReturn cSalesInvoiceReturn2 in invoiceReturn)
					{
						dgvReturn.Rows.Add(cSalesInvoiceReturn2.Id, TriState.True, cSalesInvoiceReturn2.InvoiceDate, cSalesInvoiceReturn2.Number, Module1.formatCustomDecimal(Conversions.ToString(cSalesInvoiceReturn2.Amount), 2));
					}
					GetUnpaidReturn();
					calculateTotalReturn();
					if (Conversion.Val(lblTotalReceivable.Text) == 0.0)
					{
						_fullyPaidWhenLoaded = true;
					}
					getTotalUnpaid();
					_unpaidLimit = cSalesInvoice2.CustomerUnpaidLimit;
					_edited = false;
					btnHistory.Enabled = true;
					btnPrint.Enabled = true;
					if (Module1.pubUpdateSalesInvoice)
					{
						if (DateTime.Compare(cSalesInvoice2.PaidDate, DateTime.MinValue) > 0 && DateAndTime.DateDiff(DateInterval.Day, cSalesInvoice2.PaidDate, DateAndTime.Now) <= Module1.pubDaysLimitForPaidSalesInvoice)
						{
							btnSave.Enabled = true;
							btnSaveClose.Enabled = true;
						}
						else if (DateTime.Compare(cSalesInvoice2.PaidDate, DateTime.MinValue) == 0)
						{
							btnSave.Enabled = true;
							btnSaveClose.Enabled = true;
						}
						else
						{
							btnSave.Enabled = false;
							btnSaveClose.Enabled = false;
						}
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
					if (Module1.pubModifySalesInvoiceNumber)
					{
						txtInvoiceNumber.Enabled = true;
					}
					else
					{
						txtInvoiceNumber.Enabled = false;
					}
					if (Module1.pubModifySalesTaxInvoiceNumber)
					{
						txtTaxInvoiceNumber.Enabled = true;
					}
					else
					{
						txtTaxInvoiceNumber.Enabled = false;
					}
					if (Module1.pubModifySalesInvoice & (DateAndTime.DateDiff(DateInterval.Day, dtpInvoice.Value, DateAndTime.Now) <= Module1.pubDaysLimit))
					{
						dtpInvoice.Enabled = true;
						dtpTaxInvoice.Enabled = true;
						btnItem.Enabled = true;
						btnSO.Enabled = true;
						btnDO.Enabled = true;
						_disableDgvItem = false;
						txtDiscountDescription.Enabled = true;
						txtDiscountValue.Enabled = true;
					}
					else
					{
						dtpInvoice.Enabled = false;
						dtpTaxInvoice.Enabled = false;
						btnItem.Enabled = false;
						btnSO.Enabled = false;
						btnDO.Enabled = false;
						_disableDgvItem = true;
						txtDiscountDescription.Enabled = false;
						txtDiscountValue.Enabled = false;
					}
					goto end_IL_0001;
				}
				case 2776:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSalesInvoice", "LoadData", "");
						if (Information.Err().Number == 513)
						{
							Close();
						}
						goto end_IL_0001;
					}
					break;
				}
				goto IL_0b0e;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 2776;
				continue;
			}
			break;
			IL_0b0e:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void getTotalUnpaid()
	{
		_totalUnpaid = cSalesInvoice.TotalUnpaidInvoice(_customerId);
	}

	private void btnSearch_Click(object sender, EventArgs e)
	{
		frmCustomerMiniSearch frmCustomerMiniSearch2 = new frmCustomerMiniSearch();
		frmCustomerMiniSearch2.CallerName = "SalesInvoice";
		frmCustomerMiniSearch2.ShowDialog();
		frmCustomerMiniSearch2.Close();
		frmCustomerMiniSearch2.Dispose();
		if (_customerId > 0.0)
		{
			LoadCustomer();
			txtTaxInvoiceNumber.Text = "";
			dtpInvoice.Focus();
		}
	}

	public void LoadCustomer()
	{
		cboInvoiceCode.SelectedIndex = -1;
		cCustomer cCustomer2 = new cCustomer(_customerId);
		_customerParentId = cCustomer2.ParentId;
		_branchId = cCustomer2.BranchId;
		lblCustomerName.Text = cCustomer2.Name;
		lblCustomerAddress.Text = cCustomer2.Address;
		_customerNPWP = cCustomer2.NPWP;
		_unpaidLimit = cCustomer2.CreditLimit;
		getTotalUnpaid();
		GetUnpaidReturn();
		if (Operators.CompareString(_customerNPWP, "", TextCompare: false) != 0)
		{
			dtpTaxInvoice.Visible = true;
			txtTaxInvoiceNumber.Visible = true;
			lblTaxDateDash.Visible = false;
			lblTaxNumberDash.Visible = false;
		}
		else
		{
			dtpTaxInvoice.Visible = false;
			txtTaxInvoiceNumber.Visible = false;
			lblTaxDateDash.Visible = true;
			lblTaxNumberDash.Visible = true;
		}
		ComboBox combo = cboStorage;
		cCombo.getStorage(ref combo, Module1.pubGroupId, _branchId, "MARKETING", blnAll: false, 1);
		cboStorage = combo;
		combo = cboSalesPerson;
		cCombo.getSalesPerson(ref combo, "SALESPERSON", 0, 99, _branchId, Module1.pubGroupId, All: false, Dash: false, 1);
		cboSalesPerson = combo;
		combo = cboTF;
		Module1.comboBoundValue(ref combo, cCustomer2.TukarFaktur);
		cboTF = combo;
		combo = cboSalesPerson;
		Module1.comboBoundValue(ref combo, cCustomer2.SalesPersonId);
		cboSalesPerson = combo;
		_cashAccountId = cCustomer2.CashAccountId;
		_bankAccountId = cCustomer2.BankAccountId;
		_cashAccountName = cCustomer2.CashAccountName;
		combo = cboStorage;
		Module1.comboBoundValue(ref combo, cCustomer2.StorageId);
		cboStorage = combo;
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

	public void GetUnpaidReturn()
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
					DataTable unpaidReturn = cSalesInvoice.GetUnpaidReturn(_customerParentId);
					IEnumerator enumerator = unpaidReturn.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						dgvReturn.Rows.Add(dataRow["penjId"], 0, dataRow["penjDate"], dataRow["penjFaktur"], Module1.formatCustomDecimal(Conversions.ToString(dataRow["payable"]), 2));
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					goto end_IL_0001;
				}
				case 219:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSalesInvoice", "GetUnpaidReturn", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 219;
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
		bool flag2 = default(bool);
		bool flag3 = default(bool);
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
							if (Operators.ConditionalCompareObjectEqual(dgvItem[18, i].Value, 0, TextCompare: false))
							{
								ref int totalItem = ref _totalItem;
								totalItem = (int)Math.Round((double)totalItem + Conversions.ToDouble(dgvItem[3, i].Value));
							}
							num4 += Conversions.ToDouble(dgvItem[5, i].Value);
							if (Operators.ConditionalCompareObjectNotEqual(dgvItem[2, i].Value, "", TextCompare: false))
							{
								flag = true;
							}
							if (Operators.ConditionalCompareObjectGreater(dgvItem[16, i].Value, 0, TextCompare: false))
							{
								flag2 = true;
							}
							if (Operators.ConditionalCompareObjectGreater(dgvItem[17, i].Value, 0, TextCompare: false))
							{
								flag3 = true;
							}
						}
						if (flag)
						{
							dgvItem.Columns[2].Visible = true;
						}
						else
						{
							dgvItem.Columns[2].Visible = false;
						}
						if (flag2)
						{
							dgvItem.Columns[14].Visible = true;
						}
						else
						{
							dgvItem.Columns[14].Visible = false;
						}
						if (flag3)
						{
							dgvItem.Columns[15].Visible = true;
						}
						else
						{
							dgvItem.Columns[15].Visible = false;
						}
						lblTotalPrice.Text = Module1.formatCustomDecimal(Conversions.ToString(num4), 2);
						calculateTotalInvoice();
						goto end_IL_0001;
					}
					case 538:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmSalesInvoice", "CalculateTotalPrice", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 538;
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

	public void calculateTotalReturn()
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
							Module1.SaveError(Information.Err(), "frmSalesInvoice", "CalculateTotalReturn", "");
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
							num4 += Conversions.ToDouble(dgvPayment[11, i].Value);
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
							Module1.SaveError(Information.Err(), "frmSalesInvoice", "CalculateTotalPayment", "");
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
					double num3 = Conversion.Val(Module1.unformatNumber(lblTotalPrice.Text)) - Conversion.Val(Module1.unformatNumber(lblTotalReturn.Text)) - Conversion.Val(Module1.unformatNumber(txtDiscountValue.Text));
					lblTotalInvoice.Text = Module1.formatCustomDecimal(Conversions.ToString(num3), 2);
					double num4 = Conversion.Val(Module1.unformatNumber(lblTotalPayment.Text));
					lblTotalNetPayment.Text = Module1.formatCustomDecimal(Conversions.ToString(num4 + Conversion.Val(Module1.unformatNumber(txtDeduction.Text))), 2);
					double num5 = num3 - Conversion.Val(Module1.unformatNumber(lblTotalNetPayment.Text));
					lblTotalReceivable.Text = Module1.formatCustomDecimal(Conversions.ToString(num5), 2);
					DateTime t = new DateTime(2022, 4, 1);
					short num6 = checked((short)DateTime.Compare(dtpTaxInvoice.Value.Date, t));
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
				case 536:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSalesInvoice", "CalculateTotalInvoice", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 536;
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
		frmSalesInvoiceItem frmSalesInvoiceItem2 = new frmSalesInvoiceItem(CurrentData: false, _customerId, Conversions.ToInteger(cComboItem2.Value));
		frmSalesInvoiceItem2.ShowDialog();
		frmSalesInvoiceItem2.Close();
		frmSalesInvoiceItem2.Dispose();
	}

	private void btnSO_Click(object sender, EventArgs e)
	{
		if (_customerId > 0.0)
		{
			Cursor = Cursors.WaitCursor;
			frmSalesInvoiceSO frmSalesInvoiceSO2 = new frmSalesInvoiceSO(checked((int)Math.Round(_customerId)), _currentId);
			frmSalesInvoiceSO2.ShowDialog();
			frmSalesInvoiceSO2.Close();
			frmSalesInvoiceSO2.Dispose();
			Cursor = Cursors.Default;
		}
		else
		{
			Interaction.MsgBox("Pilih customer.", (MsgBoxStyle)(-2147483637));
			btnSearch.Focus();
		}
	}

	private void btnDO_Click(object sender, EventArgs e)
	{
		if (_customerId > 0.0)
		{
			frmSalesInvoiceDO frmSalesInvoiceDO2 = new frmSalesInvoiceDO(checked((int)Math.Round(_customerId)), _currentId);
			frmSalesInvoiceDO2.ShowDialog();
			frmSalesInvoiceDO2.Close();
			frmSalesInvoiceDO2.Dispose();
		}
		else
		{
			Interaction.MsgBox("Pilih customer.", (MsgBoxStyle)(-2147483637));
			btnSearch.Focus();
		}
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
			btnDO.Focus();
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
					else
					{
						if (dgvItem.Rows.Count <= 0)
						{
							goto end_IL_0001;
						}
						if (Conversion.Val(RuntimeHelpers.GetObjectValue(dgvItem[18, dgvItem.CurrentRow.Index].Value)) > 0.0)
						{
							Interaction.MsgBox("Barang tidak bisa diedit karena merupakan bagian dari grup.", MsgBoxStyle.Information);
							goto end_IL_0001;
						}
						cComboItem cComboItem2 = (cComboItem)cboStorage.SelectedItem;
						frmSalesInvoiceItem frmSalesInvoiceItem2 = new frmSalesInvoiceItem(CurrentData: true, _customerId, Conversions.ToInteger(cComboItem2.Value));
						frmSalesInvoiceItem2.Item = _item;
						ComboBox cboSource = frmSalesInvoiceItem2.cboItem;
						Module1.comboBoundValue(ref cboSource, Conversions.ToDouble(dgvItem[0, dgvItem.CurrentRow.Index].Value));
						frmSalesInvoiceItem2.cboItem = cboSource;
						frmSalesInvoiceItem2.rtxDescription.Text = Conversions.ToString(dgvItem[2, dgvItem.CurrentRow.Index].Value);
						frmSalesInvoiceItem2.txtQty.Text = Module1.formatCustomDecimal(Conversions.ToString(dgvItem[3, dgvItem.CurrentRow.Index].Value), 3);
						frmSalesInvoiceItem2.txtPrice.Text = Module1.formatCustomDecimal(Conversions.ToString(dgvItem[4, dgvItem.CurrentRow.Index].Value), 2);
						if (Conversion.Val(RuntimeHelpers.GetObjectValue(dgvItem[16, dgvItem.CurrentRow.Index].Value)) > 0.0)
						{
							frmSalesInvoiceItem2.cboItem.Enabled = false;
						}
						if (Conversion.Val(RuntimeHelpers.GetObjectValue(dgvItem[17, dgvItem.CurrentRow.Index].Value)) > 0.0)
						{
							frmSalesInvoiceItem2.cboItem.Enabled = false;
							frmSalesInvoiceItem2.txtQty.Enabled = false;
							frmSalesInvoiceItem2.btnDelete.Enabled = false;
						}
						frmSalesInvoiceItem2.ShowDialog();
					}
					goto end_IL_0001;
				case 689:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSalesInvoice", "OpenItem", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 689;
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
		frmSalesInvoicePayment frmSalesInvoicePayment2 = new frmSalesInvoicePayment(CurrentData: false, Conversions.ToInteger(cComboItem2.Value));
		frmSalesInvoicePayment2.CashAccountId = _cashAccountId;
		frmSalesInvoicePayment2.BankAccountId = _bankAccountId;
		frmSalesInvoicePayment2.ShowDialog();
		frmSalesInvoicePayment2.Close();
		frmSalesInvoicePayment2.Dispose();
		calculateTotalPayment();
	}

	private void btnCash_Click(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboSalesPerson.SelectedItem;
		if (cboSalesPerson.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih sales.", MsgBoxStyle.Information);
			TabControl1.SelectedIndex = 3;
			cboSalesPerson.Focus();
		}
		else if (Conversion.Val(Module1.unformatNumber(lblTotalReceivable.Text)) > 0.0)
		{
			dgvPayment.Rows.Add(0, 0, 1, cComboItem2.Value, 0, dtpInvoice.Value, "CASH", cboSalesPerson.Text, "", "", "", lblTotalReceivable.Text, _cashAccountName, _cashAccountId, DateTime.MinValue, DateTime.MinValue, DateAndTime.Now);
			_edited = true;
			calculateTotalPayment();
		}
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
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			btnCash.Focus();
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
					if (dgvPayment.Rows.Count > 0 && Operators.ConditionalCompareObjectNotEqual(dgvPayment[14, dgvPayment.CurrentRow.Index].Value, DateTime.MinValue, TextCompare: false))
					{
						Interaction.MsgBox("Pembayaran tidak bisa di-edit karena Cek/Giro sudah disetor.", MsgBoxStyle.Information);
						goto end_IL_0001;
					}
					cComboItem cComboItem2 = (cComboItem)cboSalesPerson.SelectedItem;
					if (dgvPayment.Rows.Count > 0 && Operators.ConditionalCompareObjectEqual(dgvPayment[1, dgvPayment.CurrentRow.Index].Value, 0, TextCompare: false))
					{
						frmSalesInvoicePayment frmSalesInvoicePayment2 = new frmSalesInvoicePayment(CurrentData: true, Conversions.ToInteger(cComboItem2.Value));
						frmSalesInvoicePayment2.CashAccountId = _cashAccountId;
						frmSalesInvoicePayment2.BankAccountId = _bankAccountId;
						ComboBox cboSource = frmSalesInvoicePayment2.cboPaymentCode;
						Module1.comboBoundValue(ref cboSource, Conversions.ToDouble(dgvPayment[2, dgvPayment.CurrentRow.Index].Value));
						frmSalesInvoicePayment2.cboPaymentCode = cboSource;
						cboSource = frmSalesInvoicePayment2.cboSalesPerson;
						Module1.comboBoundValue(ref cboSource, Conversions.ToDouble(dgvPayment[3, dgvPayment.CurrentRow.Index].Value));
						frmSalesInvoicePayment2.cboSalesPerson = cboSource;
						frmSalesInvoicePayment2.dtpPayment.Value = Conversions.ToDate(dgvPayment[5, dgvPayment.CurrentRow.Index].Value);
						frmSalesInvoicePayment2.txtAmount.Text = Module1.formatCustomDecimal(Conversions.ToString(dgvPayment[11, dgvPayment.CurrentRow.Index].Value), 3);
						cboSource = frmSalesInvoicePayment2.cboAccount;
						Module1.comboBoundValue(ref cboSource, Conversions.ToDouble(dgvPayment[13, dgvPayment.CurrentRow.Index].Value));
						frmSalesInvoicePayment2.cboAccount = cboSource;
						if (Operators.ConditionalCompareObjectEqual(dgvPayment[6, dgvPayment.CurrentRow.Index].Value, "C/G", TextCompare: false))
						{
							frmSalesInvoicePayment2.dtpCheque.Value = Conversions.ToDate(dgvPayment[8, dgvPayment.CurrentRow.Index].Value);
							frmSalesInvoicePayment2.txtChequeNo.Text = Conversions.ToString(dgvPayment[9, dgvPayment.CurrentRow.Index].Value);
							cboSource = frmSalesInvoicePayment2.cboBank;
							Module1.comboBoundValue(ref cboSource, Conversions.ToDouble(dgvPayment[4, dgvPayment.CurrentRow.Index].Value));
							frmSalesInvoicePayment2.cboBank = cboSource;
						}
						frmSalesInvoicePayment2.ShowDialog();
					}
					else if (dgvPayment.Rows.Count > 0)
					{
						Interaction.MsgBox("Pembayaran hanya bisa dibuka di Form Pembayaran", MsgBoxStyle.Information);
					}
					goto end_IL_0001_2;
				}
				case 884:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSalesInvoice", "OpenPayment", "");
						goto end_IL_0001_2;
					}
					break;
				}
				goto IL_03aa;
				end_IL_0001_2:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 884;
				continue;
			}
			break;
			IL_03aa:
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

	private void dgvReturn_DoubleClick(object sender, EventArgs e)
	{
		OpenSalesReturn();
	}

	private void OpenSalesReturn()
	{
		if (dgvReturn.RowCount > 0)
		{
			MyProject.Forms.frmSalesReturn.Show();
			MyProject.Forms.frmSalesReturn.prepareForm(SaveNew: false);
			MyProject.Forms.frmSalesReturn.CurrentId = Conversions.ToDouble(dgvReturn[0, dgvReturn.CurrentRow.Index].Value);
			MyProject.Forms.frmSalesReturn.LoadData();
			MyProject.Forms.frmSalesReturn.Activate();
			MyProject.Forms.frmSalesReturn.WindowState = FormWindowState.Normal;
		}
	}

	private void dgvReturn_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			OpenSalesReturn();
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			txtDiscountValue.Focus();
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
		calculateTotalReturn();
	}

	private void dgvReturn_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		calculateTotalReturn();
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
	}

	private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (TabControl1.SelectedIndex == 1 && dgvPayment.Rows.Count > 0)
		{
			dgvPayment.CurrentRow.Selected = false;
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
				if (DateAndTime.DateDiff(DateInterval.Day, dtpInvoice.Value, Conversions.ToDate(dgvPayment[5, i].Value)) > 0)
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
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		int itemId = default(int);
		double qty = default(double);
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
					Module1.SaveDebug("checkInput - START");
					result = false;
					cComboItem cComboItem2 = (cComboItem)cboSalesPerson.SelectedItem;
					bool flag;
					if (Operators.CompareString(txtInvoiceNumber.Text, "", TextCompare: false) == 0)
					{
						flag = false;
					}
					else
					{
						flag = cInvoiceNumber.isExist(txtInvoiceNumber.Text, (Operators.CompareString(_customerNPWP, "", TextCompare: false) != 0) ? true : false, dtpInvoice.Value, _currentId);
						txtInvoiceNumber.Text = Module1.FormatInvoiceNumber(txtInvoiceNumber.Text);
						flag2 = cInvoiceNumber.isMyNumber(txtInvoiceNumber.Text, (Operators.CompareString(_customerNPWP, "", TextCompare: false) != 0) ? true : false, Conversions.ToInteger(cComboItem2.Value), DateAndTime.Year(dtpInvoice.Value));
						flag3 = cInvoiceNumber.isMyCode(txtInvoiceNumber.Text, (Operators.CompareString(_customerNPWP, "", TextCompare: false) != 0) ? true : false, Conversions.ToInteger(cComboItem2.Value));
					}
					bool flag4;
					bool flag5;
					if (Operators.CompareString(txtTaxInvoiceNumber.Text, "", TextCompare: false) != 0)
					{
						flag4 = cInvoiceNumber.isExist(txtTaxInvoiceNumber.Text, blnFP: true, dtpTaxInvoice.Value, _currentId);
						flag5 = cInvoiceNumber.isMyNumber(txtTaxInvoiceNumber.Text, blnFP: true, Conversions.ToInteger(cComboItem2.Value), DateAndTime.Year(dtpTaxInvoice.Value));
						bool flag6 = cInvoiceNumber.isMyCode(txtTaxInvoiceNumber.Text, blnFP: true, Conversions.ToInteger(cComboItem2.Value));
						txtTaxInvoiceNumber.Text = Module1.FormatInvoiceNumber(txtTaxInvoiceNumber.Text);
					}
					else
					{
						flag4 = false;
						flag5 = true;
						bool flag6 = true;
					}
					if ((Operators.CompareString(txtInvoiceNumber.Text, "", TextCompare: false) == 0) & (_currentId > 0.0))
					{
						Interaction.MsgBox("Silahkan masukkan No Faktur", MsgBoxStyle.Information);
						if (txtInvoiceNumber.Enabled)
						{
							txtInvoiceNumber.Focus();
						}
					}
					else if ((Operators.CompareString(txtInvoiceNumber.Text, "", TextCompare: false) != 0) & (Operators.CompareString(_currentInvoiceNumber, "", TextCompare: false) == 0) & (Operators.CompareString(_customerNPWP, "", TextCompare: false) == 0) & !Module1.BeginWithChar(txtInvoiceNumber.Text))
					{
						if (Operators.CompareString(_customerNPWP, "", TextCompare: false) == 0)
						{
							Interaction.MsgBox("Customer tidak memiliki NPWP,\r\nMaka No Faktur Penjualan harus diawali oleh kode sales", MsgBoxStyle.Information);
						}
						if (txtInvoiceNumber.Enabled)
						{
							txtInvoiceNumber.Focus();
						}
					}
					else if ((Operators.CompareString(_customerNPWP, "", TextCompare: false) != 0) & (Operators.CompareString(txtInvoiceNumber.Text, "", TextCompare: false) != 0) & (Conversion.Val(txtInvoiceNumber.Text) == 0.0))
					{
						Interaction.MsgBox("No Faktur harus dalam format angka (tidak mengandung huruf)", MsgBoxStyle.Information);
						if (txtInvoiceNumber.Enabled)
						{
							txtInvoiceNumber.Focus();
						}
					}
					else if ((Operators.CompareString(_customerNPWP, "", TextCompare: false) != 0) & (_currentId > 0.0) & (Operators.CompareString(txtTaxInvoiceNumber.Text, "", TextCompare: false) == 0))
					{
						Interaction.MsgBox("Masukkan no Faktur Pajak", MsgBoxStyle.Information);
						if (txtTaxInvoiceNumber.Enabled)
						{
							txtTaxInvoiceNumber.Focus();
						}
					}
					else if ((Operators.CompareString(_customerNPWP, "", TextCompare: false) != 0) & (Operators.CompareString(txtTaxInvoiceNumber.Text, "", TextCompare: false) != 0) & (Conversion.Val(txtTaxInvoiceNumber.Text) == 0.0))
					{
						Interaction.MsgBox("No Faktur Pajak harus dalam format angka (tidak mengandung huruf)", MsgBoxStyle.Information);
						if (txtTaxInvoiceNumber.Enabled)
						{
							txtTaxInvoiceNumber.Focus();
						}
					}
					else if (Operators.CompareString(txtInvoiceNumber.Text, "", TextCompare: false) != 0 && flag)
					{
						Interaction.MsgBox("No Faktur telah dipakai. Silahkan masukkan No Faktur lain", MsgBoxStyle.Information);
						if (txtInvoiceNumber.Enabled)
						{
							txtInvoiceNumber.Focus();
						}
					}
					else if (((Operators.CompareString(txtTaxInvoiceNumber.Text, "", TextCompare: false) != 0) & (Conversion.Val(txtTaxInvoiceNumber.Text) > 0.0)) && flag4)
					{
						Interaction.MsgBox("No Faktur Pajak telah dipakai. Silahkan masukkan No Faktur lain", MsgBoxStyle.Information);
						if (txtTaxInvoiceNumber.Enabled)
						{
							txtTaxInvoiceNumber.Focus();
						}
					}
					else if (Operators.CompareString(txtInvoiceNumber.Text, "", TextCompare: false) != 0 && !flag2)
					{
						Interaction.MsgBox("No Faktur tidak sesuai dengan setting. Silahkan masukkan No Faktur lain", MsgBoxStyle.Information);
						if (txtInvoiceNumber.Enabled)
						{
							txtInvoiceNumber.Focus();
						}
					}
					else if (((Operators.CompareString(txtTaxInvoiceNumber.Text, "", TextCompare: false) != 0) & (Conversion.Val(txtTaxInvoiceNumber.Text) > 0.0)) && !flag5)
					{
						Interaction.MsgBox("No Faktur Pajak tidak sesuai dengan setting. Silahkan masukkan No Faktur Pajak lain", MsgBoxStyle.Information);
						if (txtTaxInvoiceNumber.Enabled)
						{
							txtTaxInvoiceNumber.Focus();
						}
					}
					else if (Operators.CompareString(txtInvoiceNumber.Text, "", TextCompare: false) != 0 && !flag3)
					{
						Interaction.MsgBox("Kode faktur yang anda masukkan salah.", MsgBoxStyle.Information);
						if (txtInvoiceNumber.Enabled)
						{
							txtInvoiceNumber.Focus();
						}
					}
					else if (Conversion.Val(txtTaxInvoiceNumber.Text) > 0.0 && !flag3)
					{
						Interaction.MsgBox("Kode faktur yang anda masukkan salah.", MsgBoxStyle.Information);
						if (txtTaxInvoiceNumber.Enabled)
						{
							txtTaxInvoiceNumber.Focus();
						}
					}
					else if (cboInvoiceCode.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih kode penjualan.", MsgBoxStyle.Information);
						cboInvoiceCode.Focus();
					}
					else if (dgvItem.Rows.Count == 0)
					{
						Interaction.MsgBox("Faktur harus memiliki minimum 1 barang.", MsgBoxStyle.Information);
						TabControl1.SelectedIndex = 0;
					}
					else if ((cboInvoiceCode.SelectedIndex == 0) & (Conversion.Val(lblTotalReceivable.Text) > 0.0))
					{
						Interaction.MsgBox("Anda tidak bisa memilih kode penjualan Tunai\r\nkarena pembayaran masih belum terlunasi", MsgBoxStyle.Critical);
					}
					else if ((cboInvoiceCode.SelectedIndex == 0) & !isCash())
					{
						Interaction.MsgBox("Anda tidak bisa memilih kode penjualan Tunai\r\nkarena tanggal pembayaran melebihi tanggal faktur", MsgBoxStyle.Critical);
					}
					else if ((cboInvoiceCode.SelectedIndex == 0) & (DateTime.Compare(dtpInvoice.Value, Conversions.ToDate(_paidDate.ToShortDateString())) < 0))
					{
						Interaction.MsgBox("Anda tidak bisa memilih kode penjualan Tunai\r\nkarena tanggal lunas melebihi tanggal faktur.", MsgBoxStyle.Information);
					}
					else if (cboTF.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih Tukar Faktur.", MsgBoxStyle.Information);
						TabControl1.SelectedIndex = 3;
						cboTF.Focus();
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
					else if (Conversion.Val(Module1.unformatNumber(lblTotalReceivable.Text)) < 0.0)
					{
						Interaction.MsgBox("Nilai piutang tidak boleh negatif.", MsgBoxStyle.Information);
					}
					else if ((Conversion.Val(txtDeduction.Text) > 0.0) & (dgvPayment.RowCount == 0))
					{
						Interaction.MsgBox("Potongan hanya bisa diisi jika ada minimum 1 pembayaran.", MsgBoxStyle.Information);
						txtDeduction.Focus();
					}
					else if ((Conversion.Val(txtDeduction.Text) > 0.0) & (Conversion.Val(lblTotalReceivable.Text) > 0.0))
					{
						Interaction.MsgBox("Potongan tidak bisa diisi karena Faktur masih belum lunas.", MsgBoxStyle.Information);
						txtDeduction.Focus();
					}
					else if (!Module1.pubUnlimitedCredit & _fullyPaidWhenLoaded & (Operators.CompareString(lblTotalReceivable.Text, "0", TextCompare: false) != 0) & cSalesInvoice.isMoreThanLimit(_customerId))
					{
						Interaction.MsgBox("Faktur tidak bisa disimpan karena akan melewati batas piutang.", MsgBoxStyle.Information);
					}
					else if ((_currentId == 0.0) & (Operators.CompareString(txtInvoiceNumber.Text, "", TextCompare: false) == 0) & (Operators.CompareString(_customerNPWP, "", TextCompare: false) == 0))
					{
						string invoiceNumber = cSalesInvoice.getInvoiceNumber(Conversions.ToInteger(cComboItem2.Value), dtpInvoice.Value, Module1.pubUseDeletedInvoiceNumber, _branchId, blnUpdate: true);
						if (Operators.CompareString(invoiceNumber, "", TextCompare: false) == 0)
						{
							Interaction.MsgBox("No Faktur Penjualan untuk sales " + cboSalesPerson.Text + " tidak tersedia.\r\nHubungi manager anda.", MsgBoxStyle.Critical);
						}
						else
						{
							txtInvoiceNumber.Text = invoiceNumber;
							result = true;
						}
					}
					else if ((_currentId == 0.0) & (Operators.CompareString(txtTaxInvoiceNumber.Text, "", TextCompare: false) == 0) & (Operators.CompareString(_customerNPWP, "", TextCompare: false) != 0))
					{
						double num3 = Conversions.ToDouble(cSalesInvoice.getTaxInvoiceNumber(Conversions.ToInteger(cComboItem2.Value), dtpInvoice.Value, _branchId, blnUpdate: true));
						if (num3 == 0.0)
						{
							Interaction.MsgBox("No Faktur Pajak untuk sales " + cboSalesPerson.Text + " tidak tersedia.\r\nHubungi manager anda.", MsgBoxStyle.Critical);
						}
						else
						{
							txtInvoiceNumber.Text = Module1.FormatInvoiceNumber(Conversion.Str(num3));
							txtTaxInvoiceNumber.Text = Module1.FormatInvoiceNumber(Conversion.Str(num3));
							result = true;
						}
					}
					else
					{
						result = true;
					}
					Module1.SaveDebug("Before check stock");
					cComboItem cComboItem3 = (cComboItem)cboStorage.SelectedItem;
					if (!((dgvItem.RowCount > 0) & _dateIsChanged))
					{
						goto end_IL_0001;
					}
					checked
					{
						int num4 = dgvItem.RowCount - 1;
						for (int i = 0; i <= num4; i++)
						{
							if (!Information.IsNothing(_item))
							{
								cSalesInvoiceItem[] item = _item;
								foreach (cSalesInvoiceItem cSalesInvoiceItem2 in item)
								{
									if (Operators.ConditionalCompareObjectEqual(cSalesInvoiceItem2.ItemId, dgvItem[0, i].Value, TextCompare: false))
									{
										itemId = cSalesInvoiceItem2.ItemId;
										qty = cSalesInvoiceItem2.Qty;
										break;
									}
								}
							}
							Module1.SaveDebug(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("before is in stock ", dgvItem[0, i].Value), ","), dgvItem[3, i].Value), ","), cComboItem3.Value)));
							if (!cValidation.isInStock(Module1.pubCheckStock, Module1.pubBalanceDate, dtpInvoice.Value, "", OriginalDate, Conversions.ToInteger(dgvItem[0, i].Value), itemId, Conversions.ToDouble(dgvItem[3, i].Value), qty, Conversions.ToInteger(cComboItem3.Value), OriginalStorageId, Module1.pubGroupId, 2))
							{
								Module1.SaveDebug("Faktur Penjualan " + txtInvoiceNumber.Text + " - Stok dicek ulang dan tidak tersedia - " + Module1.pubLogin);
								Interaction.MsgBox(Operators.ConcatenateObject(Operators.ConcatenateObject("Stok ", dgvItem[1, i].Value), " tidak tersedia"), MsgBoxStyle.Information);
								result = false;
								dgvItem.Focus();
								break;
							}
							Module1.SaveDebug("after is in stock");
						}
						goto end_IL_0001;
					}
				}
				case 3639:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSalesInvoice", "checkInput", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 3639;
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
						cComboItem cComboItem2 = (cComboItem)cboTF.SelectedItem;
						cComboItem cComboItem3 = (cComboItem)cboSalesPerson.SelectedItem;
						cComboItem cComboItem4 = (cComboItem)cboStorage.SelectedItem;
						val = Module1.connectData.BeginTransaction();
						int num3 = 0;
						Module1.SaveDebug("Save Penjualan - START " + Module1.pubLogin);
						_paidDate = DateTime.MinValue;
						if (Conversion.Val(lblTotalReceivable.Text) > 0.0)
						{
							_paidDate = DateTime.MinValue;
						}
						else if ((Conversion.Val(lblTotalReceivable.Text) == 0.0) & (Conversion.Val(lblTotalPayment.Text) == 0.0) & (Conversion.Val(lblTotalReturn.Text) == 0.0))
						{
							_paidDate = dtpInvoice.Value;
						}
						else
						{
							int num4 = dgvPayment.Rows.Count - 1;
							for (num3 = 0; num3 <= num4; num3++)
							{
								if (Operators.ConditionalCompareObjectGreater(dgvPayment[5, num3].Value, _paidDate, TextCompare: false))
								{
									_paidDate = Conversions.ToDate(dgvPayment[5, num3].Value);
								}
							}
							int num5 = dgvReturn.Rows.Count - 1;
							for (num3 = 0; num3 <= num5; num3++)
							{
								if (Operators.ConditionalCompareObjectEqual(dgvReturn[1, num3].EditedFormattedValue, true, TextCompare: false) && Operators.ConditionalCompareObjectGreater(dgvReturn[2, num3].Value, _paidDate, TextCompare: false))
								{
									_paidDate = Conversions.ToDate(dgvReturn[2, num3].Value);
								}
							}
						}
						Module1.SaveDebug("Before checkInput()");
						if (!checkInput())
						{
							val.Rollback();
							goto end_IL_0001;
						}
						Module1.SaveDebug("After checkInput()");
						cSalesInvoice cSalesInvoice2 = new cSalesInvoice(CurrentId);
						cSalesInvoiceItem[] array = new cSalesInvoiceItem[dgvItem.Rows.Count - 1 + 1];
						cSalesInvoicePayment[] array2 = new cSalesInvoicePayment[dgvPayment.Rows.Count - 1 + 1];
						cSalesInvoice2.CurrentItem = cSalesInvoice2.Item;
						cSalesInvoice2.CurrentDate = cSalesInvoice2.InvoiceDate;
						cSalesInvoice2.CurrentStorage = cSalesInvoice2.StorageId;
						cSalesInvoice2.CustomerId = _customerId;
						cSalesInvoice2.InvoiceCode = cboInvoiceCode.SelectedIndex;
						cSalesInvoice2.Number = txtInvoiceNumber.Text;
						cSalesInvoice2.TaxNumber = Conversion.Val(txtTaxInvoiceNumber.Text);
						cSalesInvoice2.InvoiceDate = dtpInvoice.Value;
						cSalesInvoice2.TaxInvoiceDate = dtpTaxInvoice.Value;
						cSalesInvoice2.Discount = Conversion.Val(Module1.unformatNumber(txtDiscountValue.Text));
						cSalesInvoice2.DiscountDescription = txtDiscountDescription.Text;
						cSalesInvoice2.TotalPrice = Conversion.Val(Module1.unformatNumber(lblTotalPrice.Text));
						cSalesInvoice2.TotalReturn = Conversion.Val(Module1.unformatNumber(lblTotalReturn.Text));
						cSalesInvoice2.TotalPayment = Conversion.Val(Module1.unformatNumber(lblTotalPayment.Text));
						cSalesInvoice2.Deduction = Conversion.Val(Module1.unformatNumber(txtDeduction.Text));
						cSalesInvoice2.PaidDate = _paidDate;
						cSalesInvoice2.isReturn = 0;
						cSalesInvoice2.SalesPersonId = Conversions.ToInteger(cComboItem3.Value);
						cSalesInvoice2.StorageId = Conversions.ToInteger(cComboItem4.Value);
						cSalesInvoice2.TukarFaktur = Conversions.ToInteger(cComboItem2.Value);
						cSalesInvoice2.TukarFakturDate = dtpTF.Value;
						cSalesInvoice2.Note = txtNote.Text;
						cSalesInvoice2.UseOldPrice = Conversions.ToInteger(Interaction.IIf(chkUseOldPrice.Checked, 1, 0));
						string text = "";
						int num6 = dgvItem.Rows.Count - 1;
						for (num3 = 0; num3 <= num6; num3++)
						{
							array[num3] = new cSalesInvoiceItem();
							array[num3].ItemId = Conversions.ToInteger(dgvItem[0, num3].Value);
							array[num3].Description = Conversions.ToString(dgvItem[2, num3].Value);
							array[num3].Qty = Conversions.ToDouble(dgvItem[3, num3].Value);
							array[num3].Price = Conversions.ToDouble(dgvItem[4, num3].Value);
							array[num3].BasePrice = Conversions.ToDouble(dgvItem[6, num3].Value);
							array[num3].SOId = Conversions.ToDouble(dgvItem[16, num3].Value);
							array[num3].DOId = Conversions.ToDouble(dgvItem[17, num3].Value);
							array[num3].ParentItemId = Conversions.ToInteger(dgvItem[18, num3].Value);
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<tr><td>", dgvItem[1, num3].Value), "</td>"), "<td>"), dgvItem[2, num3].Value), "</td>"), "<td>"), Module1.formatCustomDecimal(Conversions.ToString(dgvItem[3, num3].Value), 3)), "</td>"), "<td align='right'>"), Module1.formatCustomDecimal(Conversions.ToString(dgvItem[4, num3].Value), 2)), "</td>"), "<td align='right'>"), Module1.formatCustomDecimal(Conversions.ToString(dgvItem[5, num3].Value), 2)), "</td>"), "<td align='right'>"), dgvItem[14, num3].Value), "</td>"), "<td align='right'>"), dgvItem[15, num3].Value), "</td></tr>\"")));
						}
						cSalesInvoice2.Item = array;
						string text2 = "";
						int num7 = dgvPayment.Rows.Count - 1;
						for (num3 = 0; num3 <= num7; num3++)
						{
							array2[num3] = new cSalesInvoicePayment();
							array2[num3].PaymentDate = Conversions.ToDate(dgvPayment[5, num3].Value);
							array2[num3].Amount = Conversions.ToDouble(dgvPayment[11, num3].Value);
							array2[num3].PaymentCodeId = Conversions.ToByte(dgvPayment[2, num3].Value);
							array2[num3].MultiPaymentId = Conversions.ToDouble(dgvPayment[1, num3].Value);
							array2[num3].CreatedDate = Conversions.ToDate(dgvPayment[16, num3].Value);
							array2[num3].PaymentCodeName = Conversions.ToString(dgvPayment[6, num3].Value);
							array2[num3].SalesPersonId = Conversions.ToInteger(dgvPayment[3, num3].Value);
							array2[num3].AccountId = Conversions.ToInteger(dgvPayment[13, num3].Value);
							if (Operators.ConditionalCompareObjectEqual(dgvPayment[6, num3].Value, "C/G", TextCompare: false))
							{
								array2[num3].ChequeDate = Conversions.ToDate(dgvPayment[8, num3].Value);
								array2[num3].ChequeNumber = Conversions.ToString(dgvPayment[9, num3].Value);
								array2[num3].BankId = Conversions.ToInteger(dgvPayment[4, num3].Value);
							}
							text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<tr><td>", dgvPayment[5, num3].Value), "</td>"), "<td>"), dgvPayment[6, num3].Value), "</td>"), "<td>"), dgvPayment[7, num3].Value), "</td>"), "<td>"), dgvPayment[8, num3].Value), "</td>"), "<td>"), dgvPayment[9, num3].Value), "</td>"), "<td align='right'>"), Module1.formatCustomDecimal(Conversions.ToString(dgvPayment[11, num3].Value), 2)), "</td>"), "<td>"), dgvPayment[12, num3].Value), "</td></tr>")));
						}
						cSalesInvoice2.Payment = array2;
						string text3 = "";
						cSalesInvoiceReturn[] array3 = new cSalesInvoiceReturn[0];
						int num8 = 0;
						int num9 = dgvReturn.Rows.Count - 1;
						for (num3 = 0; num3 <= num9; num3++)
						{
							if (Operators.ConditionalCompareObjectEqual(dgvReturn[1, num3].EditedFormattedValue, true, TextCompare: false))
							{
								array3 = (cSalesInvoiceReturn[])Utils.CopyArray(array3, new cSalesInvoiceReturn[num8 + 1]);
								array3[num8] = new cSalesInvoiceReturn();
								array3[num8].Id = Conversions.ToDouble(dgvReturn[0, num3].Value);
								array3[num8].Amount = Conversions.ToDouble(dgvReturn[4, num3].Value);
								text3 = Conversions.ToString(Operators.ConcatenateObject(text3, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<tr><td>", dgvReturn[2, num3].Value), "</td><td>"), dgvReturn[3, num3].Value), "</td><td align='right'>"), Module1.formatCustomDecimal(Conversions.ToString(dgvReturn[4, num3].Value), 2)), "</td></tr>")));
								num8++;
							}
						}
						cSalesInvoice2.InvoiceReturn = array3;
						Module1.SaveDebug("Before Invoice Save");
						cSalesInvoice2.Save();
						Module1.SaveDebug("After Invoice Save");
						string text4 = "Tanggal: " + Conversions.ToString(dtpInvoice.Value) + "<br />No Faktur: " + txtInvoiceNumber.Text + "<br />Discount: " + txtDiscountValue.Text + "<br />";
						text4 += "Barang:<br />";
						text4 += "<table>";
						text4 += "<tr><td>Barang</td><td>Deskripsi</td><td>Jumlah</td><td>Harga</td><td>Total</td><td>No Pesanan</td><td>No Pengiriman</td></tr>";
						text4 += text;
						text4 += "</table><br />";
						text4 += "<table>";
						text4 += "<tr><td>Tanggal</td><td>Tipe</td><td>Penagih</td><td>Tgl C/G</td><td>No C/G</td><td>Jumlah</td><td>Akun</td></tr>";
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
							_currentId = cSalesInvoice2.Id;
						}
						else
						{
							text5 = "mengupdate ";
						}
						text5 = text5 + "faktur penjualan " + txtInvoiceNumber.Text + " tanggal  " + Strings.Format(dtpInvoice.Value, "dd/MM/yyyy") + ". ID= " + Conversions.ToString(_currentId) + ", v2";
						cHistory cHistory2 = new cHistory();
						cHistory2.Content = text4;
						cHistory2.Description = text5;
						cHistory2.UserId = Module1.pubUserId;
						cHistory2.UserLogin = Module1.pubLogin;
						cHistory2.fKeyId = CurrentId;
						cHistory2.HistoryType = 19;
						Module1.SaveDebug("Before History Save");
						cHistory2.Save();
						Module1.SaveDebug("After History Save");
						val.Commit();
						Module1.SaveDebug("Save Penjualan - FINISH");
						Interaction.MsgBox("Faktur Penjualan berhasil disimpan", MsgBoxStyle.Information);
						if (Module1.FormIsOpen("frmSalesInvoiceList"))
						{
							MyProject.Forms.frmSalesInvoiceList.GetRecent();
						}
						if (Module1.FormIsOpen("frmCustomer"))
						{
							MyProject.Forms.frmCustomer._loadInvoice = true;
							MyProject.Forms.frmCustomer._loadPayment = true;
							if (MyProject.Forms.frmCustomer.TabControl1.SelectedIndex == 3)
							{
								MyProject.Forms.frmCustomer.GetInvoice();
							}
							if (MyProject.Forms.frmCustomer.TabControl1.SelectedIndex == 5)
							{
								MyProject.Forms.frmCustomer.GetPayment();
							}
						}
						MyProject.Forms.frmInformation.GetActivity();
						if (CloseForm)
						{
							Close();
							goto end_IL_0001;
						}
						_edited = false;
						_suppressComboChange = true;
						prepareForm(SaveNew: true);
						goto end_IL_0001_2;
					}
					case 3953:
						num = -1;
						switch (num2)
						{
						case 2:
							if (Operators.CompareString(Information.Err().Description, "Fatal error encountered during command execution.", TextCompare: false) != 0 && Operators.CompareString(Information.Err().Description, "The connection is not open.", TextCompare: false) != 0)
							{
								val.Rollback();
							}
							Module1.SaveError(Information.Err(), "frmSalesInvoice", "SaveData", "");
							goto end_IL_0001_2;
						}
						break;
					}
					goto IL_0fa7;
				}
				end_IL_0001_2:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 3953;
				continue;
			}
			break;
			IL_0fa7:
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
					if (MessageBox.Show("Hapus Faktur Penjualan?", "Konfirmasi", MessageBoxButtons.YesNo) != DialogResult.No)
					{
						cSalesInvoice cSalesInvoice2 = new cSalesInvoice(_currentId);
						cSalesInvoice2.CurrentItem = cSalesInvoice2.Item;
						cSalesInvoice2.CurrentDate = cSalesInvoice2.InvoiceDate;
						cSalesInvoice2.CurrentStorage = cSalesInvoice2.StorageId;
						cSalesInvoice2.Delete();
						string description = "menghapus faktur penjualan " + cSalesInvoice2.Number + ". ID=" + Conversions.ToString(cSalesInvoice2.Id) + ", v2";
						cHistory cHistory2 = new cHistory();
						cHistory2.Description = description;
						cHistory2.UserId = Module1.pubUserId;
						cHistory2.UserLogin = Module1.pubLogin;
						cHistory2.fKeyId = _currentId;
						cHistory2.HistoryType = 19;
						cHistory2.Save();
						Interaction.MsgBox("Penjualan berhasil dihapus", MsgBoxStyle.Information);
						MyProject.Forms.frmSalesInvoiceList.GetRecent();
						MyProject.Forms.frmInformation.GetActivity();
						Close();
					}
					goto end_IL_0001;
				case 316:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSalesInvoice", "btnDelete_Click", "");
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
		MyProject.Forms.frmHistory.GetHistory(checked((int)Math.Round(_currentId)), 19);
		MyProject.Forms.frmHistory.Show();
		MyProject.Forms.frmHistory.Activate();
		MyProject.Forms.frmHistory.WindowState = FormWindowState.Normal;
	}

	private void btnPrint_Click(object sender, EventArgs e)
	{
		if (_edited && btnSave.Enabled)
		{
			if (MessageBox.Show("Anda melakukan perubahan data.\r\nSimpan Faktur Penjualan sebelum mencetak?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				SaveData(CloseForm: false);
			}
			return;
		}
		frmSalesInvoicePrint frmSalesInvoicePrint2 = new frmSalesInvoicePrint();
		frmSalesInvoicePrint2.Id = _currentId;
		cPrintSetting cPrintSetting2 = new cPrintSetting(1);
		frmSalesInvoicePrint2.lblCompanyName.Text = cPrintSetting2.CompanyName;
		frmSalesInvoicePrint2.lblCompanyDetail1.Text = cPrintSetting2.CompanyDetail1;
		frmSalesInvoicePrint2.lblCompanyDetail2.Text = cPrintSetting2.CompanyDetail2;
		frmSalesInvoicePrint2.lblCompanyDetail3.Text = cPrintSetting2.CompanyDetail3;
		frmSalesInvoicePrint2.lblDateLetter.Text = cPrintSetting2.CompanyCity + ", " + Strings.Format(dtpInvoice.Value, "d MMMM yyyy");
		frmSalesInvoicePrint2.lblNameLetter.Text = lblCustomerName.Text;
		frmSalesInvoicePrint2.lblAddressLetter.Text = lblCustomerAddress.Text;
		frmSalesInvoicePrint2.lblInvoiceNoLetter.Text = "No. Faktur: " + txtInvoiceNumber.Text;
		checked
		{
			int num = dgvItem.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				string left = ((!Operators.ConditionalCompareObjectNotEqual(dgvItem[8, i].Value, "", TextCompare: false)) ? "" : Conversions.ToString(Operators.ConcatenateObject(dgvItem[8, i].Value, " ")));
				left = ((!Operators.ConditionalCompareObjectEqual(dgvItem[9, i].Value, "", TextCompare: false)) ? Conversions.ToString(Operators.ConcatenateObject(left, dgvItem[9, i].Value)) : Conversions.ToString(Operators.ConcatenateObject(left, dgvItem[1, i].Value)));
				string text = Conversions.ToString(Operators.ConcatenateObject(Module1.formatCustomDecimal(Conversions.ToString(dgvItem[3, i].Value), 3) + " ", dgvItem[13, i].Value));
				if (Operators.ConditionalCompareObjectNotEqual(dgvItem[2, i].Value, "", TextCompare: false))
				{
					left = Conversions.ToString(dgvItem[2, i].Value);
					text = "";
				}
				string[] array = Module1.divideString(left, 32);
				frmSalesInvoicePrint2.dgvItemLetter.Rows.Add(i + 1, array[0], dgvItem[10, i].Value, text);
				int num2 = Information.UBound(array);
				for (int j = 1; j <= num2; j++)
				{
					frmSalesInvoicePrint2.dgvItemLetter.Rows.Add("", array[j], "", "");
				}
			}
			frmSalesInvoicePrint2.lblDateCommercial.Text = cPrintSetting2.CompanyCity + ", " + Strings.Format(dtpInvoice.Value, "d MMMM yyyy");
			frmSalesInvoicePrint2.lblNameCommercial.Text = lblCustomerName.Text;
			frmSalesInvoicePrint2.lblAddressCommercial.Text = lblCustomerAddress.Text;
			frmSalesInvoicePrint2.lblInvoiceNoCommercial.Text = "No. Faktur: " + txtInvoiceNumber.Text;
			frmSalesInvoicePrint2.txtDiscountDescription.Text = txtDiscountDescription.Text;
			frmSalesInvoicePrint2.lblTotalPriceCommercial.Text = lblTotalPrice.Text;
			frmSalesInvoicePrint2.lblDiscountValueCommercial.Text = txtDiscountValue.Text;
			frmSalesInvoicePrint2.lblDeductionCommercial.Text = txtDeduction.Text;
			frmSalesInvoicePrint2.lblTotalPaymentCommercial.Text = Module1.formatCustomDecimal(Conversions.ToString(Conversions.ToDouble(Module1.unformatNumber(lblTotalInvoice.Text)) - Conversions.ToDouble(Module1.unformatNumber(txtDeduction.Text))), 2);
			int num3 = dgvItem.Rows.Count - 1;
			for (int i = 0; i <= num3; i++)
			{
				string left = ((!Operators.ConditionalCompareObjectNotEqual(dgvItem[8, i].Value, "", TextCompare: false)) ? "" : Conversions.ToString(Operators.ConcatenateObject(dgvItem[8, i].Value, " ")));
				left = ((!Operators.ConditionalCompareObjectEqual(dgvItem[9, i].Value, "", TextCompare: false)) ? Conversions.ToString(Operators.ConcatenateObject(left, dgvItem[9, i].Value)) : Conversions.ToString(Operators.ConcatenateObject(left, dgvItem[1, i].Value)));
				string text = Conversions.ToString(Operators.ConcatenateObject(Module1.formatCustomDecimal(Conversions.ToString(dgvItem[3, i].Value), 3) + " ", dgvItem[13, i].Value));
				string text2 = Module1.formatCustomDecimal(Conversions.ToString(dgvItem[4, i].Value), 2);
				if (Operators.ConditionalCompareObjectNotEqual(dgvItem[2, i].Value, "", TextCompare: false))
				{
					left = Conversions.ToString(dgvItem[2, i].Value);
					text = "";
					text2 = "";
				}
				string[] array = Module1.divideString(left, 32);
				frmSalesInvoicePrint2.dgvItemCommercial.Rows.Add(i + 1, array[0], dgvItem[10, i].Value, text, text2, Module1.formatCustomDecimal(Conversions.ToString(dgvItem[5, i].Value), 2));
				int num4 = Information.UBound(array);
				for (int j = 1; j <= num4; j++)
				{
					frmSalesInvoicePrint2.dgvItemCommercial.Rows.Add("", array[j], "", "", "", "");
				}
			}
			frmSalesInvoicePrint2.NPWP = cPrintSetting2.NPWP;
			frmSalesInvoicePrint2.TaxAddress = cPrintSetting2.TaxAddress;
			frmSalesInvoicePrint2.lblYear.Text = cPrintSetting2.TaxNumber + Strings.Mid(Conversions.ToString(DateAndTime.Year(dtpInvoice.Value)), 3, 2) + ".";
			frmSalesInvoicePrint2.lblTaxInvoiceNo.Text = txtTaxInvoiceNumber.Text;
			frmSalesInvoicePrint2.lblNameTax.Text = _customerPT;
			frmSalesInvoicePrint2.lblAddressTax.Text = _customerTaxAddress;
			frmSalesInvoicePrint2.lblNPWP.Text = _customerNPWP;
			frmSalesInvoicePrint2.txtStar.Text = "****************************";
			frmSalesInvoicePrint2.txtDiscountDescriptionTax.Text = txtDiscountDescription.Text;
			frmSalesInvoicePrint2.lblTotalPriceTax.Text = lblTotalPrice.Text;
			frmSalesInvoicePrint2.lblDiscountValueTax.Text = txtDiscountValue.Text;
			frmSalesInvoicePrint2.lblDPP.Text = Module1.formatCustomDecimal(Conversions.ToString(_DPP), 2);
			frmSalesInvoicePrint2.lblPPN.Text = Module1.formatCustomDecimal(Conversions.ToString(_PPN), 2);
			frmSalesInvoicePrint2.txtCityTax.Text = cPrintSetting2.CompanyCity;
			frmSalesInvoicePrint2.txtDateTax.Text = Strings.Format(dtpTaxInvoice.Value, "d MMMM yyyy");
			frmSalesInvoicePrint2.txtTaxPersonName.Text = cPrintSetting2.TaxPersonName;
			frmSalesInvoicePrint2.txtTaxPersonPosition.Text = cPrintSetting2.TaxPersonPosition;
			frmSalesInvoicePrint2.chkNPPKP.Checked = true;
			int num5 = dgvItem.Rows.Count - 1;
			for (int i = 0; i <= num5; i++)
			{
				string left = ((!Operators.ConditionalCompareObjectEqual(dgvItem[9, i].Value, "", TextCompare: false)) ? Conversions.ToString(dgvItem[9, i].Value) : Conversions.ToString(dgvItem[1, i].Value));
				string text3 = Module1.formatCustomDecimal(Conversions.ToString(Conversions.ToDouble(dgvItem[3, i].Value) / Conversions.ToDouble(dgvItem[12, i].Value)), 3);
				string text4 = Conversions.ToString(dgvItem[11, i].Value);
				if (Operators.ConditionalCompareObjectNotEqual(dgvItem[2, i].Value, "", TextCompare: false))
				{
					left = Conversions.ToString(dgvItem[2, i].Value);
					text3 = "";
					text4 = "";
				}
				string[] array = Module1.divideString(left, 32);
				frmSalesInvoicePrint2.dgvItemTax.Rows.Add(i + 1, array[0], text3, text4, Module1.formatCustomDecimal(Conversions.ToString(dgvItem[5, i].Value), 2));
				int num6 = Information.UBound(array);
				for (int j = 1; j <= num6; j++)
				{
					frmSalesInvoicePrint2.dgvItemTax.Rows.Add("", array[j], "", "", "");
				}
			}
			if (Operators.CompareString(_customerNPWP, "", TextCompare: false) == 0)
			{
				frmSalesInvoicePrint2.TabControl1.Controls.RemoveAt(2);
			}
			frmSalesInvoicePrint2.ShowDialog();
			frmSalesInvoicePrint2.Close();
			frmSalesInvoicePrint2.Dispose();
		}
	}

	private void cboInvoiceCode_SelectedIndexChanged(object sender, EventArgs e)
	{
		object left = false;
		if (cboInvoiceCode.SelectedIndex != 1)
		{
			return;
		}
		if (!_authorised & _wasCashInvoice & (checked(_totalUnpaid + 1) >= _unpaidLimit) & !Module1.pubUnlimitedCredit)
		{
			left = true;
		}
		else if (!_authorised & !_wasCashInvoice & (_currentId == 0.0) & (_totalUnpaid >= _unpaidLimit) & !Module1.pubUnlimitedCredit)
		{
			left = true;
		}
		if (Operators.ConditionalCompareObjectEqual(left, true, TextCompare: false))
		{
			frmAuthorisation frmAuthorisation2 = new frmAuthorisation(lblCustomerName.Text);
			frmAuthorisation2.ShowDialog();
			frmAuthorisation2.Close();
			frmAuthorisation2.Dispose();
			if (!_authorised)
			{
				cboInvoiceCode.SelectedIndex = -1;
			}
		}
	}

	private void dtpInvoice_ValueChanged(object sender, EventArgs e)
	{
		if (!_justLoaded & (DateAndTime.DateDiff(DateInterval.Day, dtpInvoice.Value, DateAndTime.Now) > Module1.pubDaysLimit))
		{
			Interaction.MsgBox("Anda tidak bisa membuat Faktur Penjualan sebelum " + Strings.FormatDateTime(DateAndTime.Now.AddDays(checked(Module1.pubDaysLimit * -1)), DateFormat.ShortDate), MsgBoxStyle.Information);
			dtpInvoice.Value = DateAndTime.Now;
		}
		_edited = true;
		dtpTaxInvoice.Value = dtpInvoice.Value;
		if (dgvItem.RowCount > 0)
		{
			_dateIsChanged = true;
		}
	}

	private void dtpTaxInvoice_ValueChanged(object sender, EventArgs e)
	{
		_edited = true;
	}

	private void txtInvoiceNumber_TextChanged(object sender, EventArgs e)
	{
		_edited = true;
	}

	private void txtTaxInvoiceNumber_TextChanged(object sender, EventArgs e)
	{
		_edited = true;
	}
}
