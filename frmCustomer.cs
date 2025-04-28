using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GCUv2.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

[DesignerGenerated]
public class frmCustomer : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TabControl1")]
	private TabControl _TabControl1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboSalesPerson")]
	private ComboBox _cboSalesPerson;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboBranch")]
	private ComboBox _cboBranch;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvInvoice")]
	private DataGridView _dgvInvoice;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnHistory")]
	private Button _btnHistory;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSave")]
	private Button _btnSave;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvSalesOrder")]
	private DataGridView _dgvSalesOrder;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvDeliveryOrder")]
	private DataGridView _dgvDeliveryOrder;

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
	[AccessedThroughProperty("dgvSalesReceipt")]
	private DataGridView _dgvSalesReceipt;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("chkIsParent")]
	private CheckBox _chkIsParent;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSalesInvoice")]
	private Button _btnSalesInvoice;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSalesReturn")]
	private Button _btnSalesReturn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnDO")]
	private Button _btnDO;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSO")]
	private Button _btnSO;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnPayment")]
	private Button _btnPayment;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSalesReceipt")]
	private Button _btnSalesReceipt;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BackgroundWorker1")]
	private BackgroundWorker _BackgroundWorker1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BackgroundWorkerSalesInvoice")]
	private BackgroundWorker _BackgroundWorkerSalesInvoice;

	private double _currentId;

	private bool _hasMember;

	public bool _loadInvoice;

	private bool _loadReturn;

	public bool _loadPayment;

	private bool _loadReturnPayment;

	private int _unpaidMoreThanTop;

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

	[field: AccessedThroughProperty("txtCity")]
	internal virtual TextBox txtCity
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

	[field: AccessedThroughProperty("txtAddress")]
	internal virtual TextBox txtAddress
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

	[field: AccessedThroughProperty("txtName")]
	internal virtual TextBox txtName
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

	[field: AccessedThroughProperty("TabPage2")]
	internal virtual TabPage TabPage2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFax")]
	internal virtual TextBox txtFax
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

	[field: AccessedThroughProperty("txtPhone")]
	internal virtual TextBox txtPhone
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPostCode")]
	internal virtual TextBox txtPostCode
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPT")]
	internal virtual TextBox txtPT
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

	[field: AccessedThroughProperty("txtContact")]
	internal virtual TextBox txtContact
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

	[field: AccessedThroughProperty("Label23")]
	internal virtual Label Label23
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

	[field: AccessedThroughProperty("cboGroupCustomer")]
	internal virtual ComboBox cboGroupCustomer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTaxPostCode")]
	internal virtual TextBox txtTaxPostCode
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTaxCity")]
	internal virtual TextBox txtTaxCity
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label19")]
	internal virtual Label Label19
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTaxAddress")]
	internal virtual TextBox txtTaxAddress
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

	[field: AccessedThroughProperty("txtNPWP")]
	internal virtual TextBox txtNPWP
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

	[field: AccessedThroughProperty("Label24")]
	internal virtual Label Label24
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkTF")]
	internal virtual CheckBox chkTF
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

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboDiscount")]
	internal virtual ComboBox cboDiscount
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

	[field: AccessedThroughProperty("cboActive")]
	internal virtual ComboBox cboActive
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

	[field: AccessedThroughProperty("cboPriceCode")]
	internal virtual ComboBox cboPriceCode
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

	[field: AccessedThroughProperty("cboCustomerCode")]
	internal virtual ComboBox cboCustomerCode
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

	[field: AccessedThroughProperty("Label14")]
	internal virtual Label Label14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboCashAccount")]
	internal virtual ComboBox cboCashAccount
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

	[field: AccessedThroughProperty("cboCollector")]
	internal virtual ComboBox cboCollector
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

	[field: AccessedThroughProperty("cboBankAccount")]
	internal virtual ComboBox cboBankAccount
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dtpActive")]
	internal virtual DateTimePicker dtpActive
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tabInvoice")]
	internal virtual TabPage tabInvoice
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

	[field: AccessedThroughProperty("TabPage5")]
	internal virtual TabPage TabPage5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage6")]
	internal virtual TabPage TabPage6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView dgvInvoice
	{
		[CompilerGenerated]
		get
		{
			return _dgvInvoice;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = dgvInvoice_DoubleClick;
			KeyEventHandler value3 = dgvInvoice_KeyDown;
			EventHandler value4 = dgvInvoice_GotFocus;
			EventHandler value5 = dgvInvoice_LostFocus;
			DataGridView dataGridView = _dgvInvoice;
			if (dataGridView != null)
			{
				dataGridView.DoubleClick -= value2;
				dataGridView.KeyDown -= value3;
				dataGridView.GotFocus -= value4;
				dataGridView.LostFocus -= value5;
			}
			_dgvInvoice = value;
			dataGridView = _dgvInvoice;
			if (dataGridView != null)
			{
				dataGridView.DoubleClick += value2;
				dataGridView.KeyDown += value3;
				dataGridView.GotFocus += value4;
				dataGridView.LostFocus += value5;
			}
		}
	}

	[field: AccessedThroughProperty("txtCreditLimit")]
	internal virtual FilteredTextBox txtCreditLimit
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTOP")]
	internal virtual FilteredTextBox txtTOP
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("Label27")]
	internal virtual Label Label27
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage7")]
	internal virtual TabPage TabPage7
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

	internal virtual DataGridView dgvSalesOrder
	{
		[CompilerGenerated]
		get
		{
			return _dgvSalesOrder;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = dgvSalesOrder_DoubleClick;
			KeyEventHandler value3 = dgvSalesOrder_KeyDown;
			EventHandler value4 = dgvSalesOrder_GotFocus;
			EventHandler value5 = dgvSalesOrder_LostFocus;
			DataGridView dataGridView = _dgvSalesOrder;
			if (dataGridView != null)
			{
				dataGridView.DoubleClick -= value2;
				dataGridView.KeyDown -= value3;
				dataGridView.GotFocus -= value4;
				dataGridView.LostFocus -= value5;
			}
			_dgvSalesOrder = value;
			dataGridView = _dgvSalesOrder;
			if (dataGridView != null)
			{
				dataGridView.DoubleClick += value2;
				dataGridView.KeyDown += value3;
				dataGridView.GotFocus += value4;
				dataGridView.LostFocus += value5;
			}
		}
	}

	internal virtual DataGridView dgvDeliveryOrder
	{
		[CompilerGenerated]
		get
		{
			return _dgvDeliveryOrder;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = dgvDeliveryOrder_DoubleClick;
			KeyEventHandler value3 = dgvDeliveryOrder_KeyDown;
			EventHandler value4 = dgvDeliveryOrder_GotFocus;
			EventHandler value5 = dgvDeliveryOrder_LostFocus;
			DataGridView dataGridView = _dgvDeliveryOrder;
			if (dataGridView != null)
			{
				dataGridView.DoubleClick -= value2;
				dataGridView.KeyDown -= value3;
				dataGridView.GotFocus -= value4;
				dataGridView.LostFocus -= value5;
			}
			_dgvDeliveryOrder = value;
			dataGridView = _dgvDeliveryOrder;
			if (dataGridView != null)
			{
				dataGridView.DoubleClick += value2;
				dataGridView.KeyDown += value3;
				dataGridView.GotFocus += value4;
				dataGridView.LostFocus += value5;
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
			EventHandler value4 = dgvReturn_GotFocus;
			EventHandler value5 = dgvReturn_LostFocus;
			DataGridView dataGridView = _dgvReturn;
			if (dataGridView != null)
			{
				dataGridView.DoubleClick -= value2;
				dataGridView.KeyDown -= value3;
				dataGridView.GotFocus -= value4;
				dataGridView.LostFocus -= value5;
			}
			_dgvReturn = value;
			dataGridView = _dgvReturn;
			if (dataGridView != null)
			{
				dataGridView.DoubleClick += value2;
				dataGridView.KeyDown += value3;
				dataGridView.GotFocus += value4;
				dataGridView.LostFocus += value5;
			}
		}
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
			EventHandler value2 = dgvPayment_DoubleClick;
			KeyEventHandler value3 = dgvPayment_KeyDown;
			EventHandler value4 = dgvPayment_GotFocus;
			EventHandler value5 = dgvPayment_LostFocus;
			DataGridView dataGridView = _dgvPayment;
			if (dataGridView != null)
			{
				dataGridView.DoubleClick -= value2;
				dataGridView.KeyDown -= value3;
				dataGridView.GotFocus -= value4;
				dataGridView.LostFocus -= value5;
			}
			_dgvPayment = value;
			dataGridView = _dgvPayment;
			if (dataGridView != null)
			{
				dataGridView.DoubleClick += value2;
				dataGridView.KeyDown += value3;
				dataGridView.GotFocus += value4;
				dataGridView.LostFocus += value5;
			}
		}
	}

	internal virtual DataGridView dgvSalesReceipt
	{
		[CompilerGenerated]
		get
		{
			return _dgvSalesReceipt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = dgvSalesReceipt_DoubleClick;
			KeyEventHandler value3 = dgvSalesReceipt_KeyDown;
			EventHandler value4 = dgvSalesReceipt_GotFocus;
			EventHandler value5 = dgvSalesReceipt_LostFocus;
			DataGridView dataGridView = _dgvSalesReceipt;
			if (dataGridView != null)
			{
				dataGridView.DoubleClick -= value2;
				dataGridView.KeyDown -= value3;
				dataGridView.GotFocus -= value4;
				dataGridView.LostFocus -= value5;
			}
			_dgvSalesReceipt = value;
			dataGridView = _dgvSalesReceipt;
			if (dataGridView != null)
			{
				dataGridView.DoubleClick += value2;
				dataGridView.KeyDown += value3;
				dataGridView.GotFocus += value4;
				dataGridView.LostFocus += value5;
			}
		}
	}

	[field: AccessedThroughProperty("TabPage3")]
	internal virtual TabPage TabPage3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dgvReturnPayment")]
	internal virtual DataGridView dgvReturnPayment
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual CheckBox chkIsParent
	{
		[CompilerGenerated]
		get
		{
			return _chkIsParent;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = chkIsParent_CheckedChanged;
			CheckBox checkBox = _chkIsParent;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value2;
			}
			_chkIsParent = value;
			checkBox = _chkIsParent;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label28")]
	internal virtual Label Label28
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtMemberName")]
	internal virtual TextBox txtMemberName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnSalesInvoice
	{
		[CompilerGenerated]
		get
		{
			return _btnSalesInvoice;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnSalesInvoice_Click;
			Button button = _btnSalesInvoice;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnSalesInvoice = value;
			button = _btnSalesInvoice;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button btnSalesReturn
	{
		[CompilerGenerated]
		get
		{
			return _btnSalesReturn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnSalesReturn_Click;
			Button button = _btnSalesReturn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnSalesReturn = value;
			button = _btnSalesReturn;
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

	internal virtual Button btnSalesReceipt
	{
		[CompilerGenerated]
		get
		{
			return _btnSalesReceipt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnSalesReceipt_Click;
			Button button = _btnSalesReceipt;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnSalesReceipt = value;
			button = _btnSalesReceipt;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual BackgroundWorker BackgroundWorker1
	{
		[CompilerGenerated]
		get
		{
			return _BackgroundWorker1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = BackgroundWorker1_DoWork;
			BackgroundWorker backgroundWorker = _BackgroundWorker1;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
			}
			_BackgroundWorker1 = value;
			backgroundWorker = _BackgroundWorker1;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value2;
			}
		}
	}

	[field: AccessedThroughProperty("lblChequeLaterThanTOP")]
	internal virtual Label lblChequeLaterThanTOP
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblUnpaidMoreThanTOP")]
	internal virtual Label lblUnpaidMoreThanTOP
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblUnpaid")]
	internal virtual Label lblUnpaid
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual BackgroundWorker BackgroundWorkerSalesInvoice
	{
		[CompilerGenerated]
		get
		{
			return _BackgroundWorkerSalesInvoice;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = BackgroundWorkerSalesInvoice_DoWork;
			ProgressChangedEventHandler value3 = BackgroundWorkerSalesInvoice_ProgressChanged;
			RunWorkerCompletedEventHandler value4 = BackgroundWorkerSalesInvoice_RunWorkerCompleted;
			BackgroundWorker backgroundWorker = _BackgroundWorkerSalesInvoice;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
				backgroundWorker.ProgressChanged -= value3;
				backgroundWorker.RunWorkerCompleted -= value4;
			}
			_BackgroundWorkerSalesInvoice = value;
			backgroundWorker = _BackgroundWorkerSalesInvoice;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value2;
				backgroundWorker.ProgressChanged += value3;
				backgroundWorker.RunWorkerCompleted += value4;
			}
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
		this.TabControl1 = new System.Windows.Forms.TabControl();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.txtMemberName = new System.Windows.Forms.TextBox();
		this.chkIsParent = new System.Windows.Forms.CheckBox();
		this.Label28 = new System.Windows.Forms.Label();
		this.cboArea = new System.Windows.Forms.ComboBox();
		this.btnHistory = new System.Windows.Forms.Button();
		this.btnSave = new System.Windows.Forms.Button();
		this.Label27 = new System.Windows.Forms.Label();
		this.txtCreditLimit = new GCUv2.FilteredTextBox();
		this.txtTOP = new GCUv2.FilteredTextBox();
		this.dtpActive = new System.Windows.Forms.DateTimePicker();
		this.Label14 = new System.Windows.Forms.Label();
		this.cboCashAccount = new System.Windows.Forms.ComboBox();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label25 = new System.Windows.Forms.Label();
		this.cboStorage = new System.Windows.Forms.ComboBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.cboCollector = new System.Windows.Forms.ComboBox();
		this.cboBranch = new System.Windows.Forms.ComboBox();
		this.Label26 = new System.Windows.Forms.Label();
		this.cboBankAccount = new System.Windows.Forms.ComboBox();
		this.Label13 = new System.Windows.Forms.Label();
		this.Label12 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.cboDiscount = new System.Windows.Forms.ComboBox();
		this.Label9 = new System.Windows.Forms.Label();
		this.cboActive = new System.Windows.Forms.ComboBox();
		this.Label10 = new System.Windows.Forms.Label();
		this.cboPriceCode = new System.Windows.Forms.ComboBox();
		this.Label11 = new System.Windows.Forms.Label();
		this.cboSalesPerson = new System.Windows.Forms.ComboBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.cboCustomerCode = new System.Windows.Forms.ComboBox();
		this.chkTF = new System.Windows.Forms.CheckBox();
		this.Label24 = new System.Windows.Forms.Label();
		this.Label23 = new System.Windows.Forms.Label();
		this.Label22 = new System.Windows.Forms.Label();
		this.cboGroupCustomer = new System.Windows.Forms.ComboBox();
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.txtTaxPostCode = new System.Windows.Forms.TextBox();
		this.txtTaxCity = new System.Windows.Forms.TextBox();
		this.Label19 = new System.Windows.Forms.Label();
		this.txtTaxAddress = new System.Windows.Forms.TextBox();
		this.Label20 = new System.Windows.Forms.Label();
		this.txtNPWP = new System.Windows.Forms.TextBox();
		this.Label21 = new System.Windows.Forms.Label();
		this.txtPT = new System.Windows.Forms.TextBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.txtContact = new System.Windows.Forms.TextBox();
		this.Label18 = new System.Windows.Forms.Label();
		this.txtFax = new System.Windows.Forms.TextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.txtPhone = new System.Windows.Forms.TextBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.txtPostCode = new System.Windows.Forms.TextBox();
		this.txtCity = new System.Windows.Forms.TextBox();
		this.Label15 = new System.Windows.Forms.Label();
		this.txtAddress = new System.Windows.Forms.TextBox();
		this.Label16 = new System.Windows.Forms.Label();
		this.txtName = new System.Windows.Forms.TextBox();
		this.Label17 = new System.Windows.Forms.Label();
		this.TabPage2 = new System.Windows.Forms.TabPage();
		this.btnSO = new System.Windows.Forms.Button();
		this.dgvSalesOrder = new System.Windows.Forms.DataGridView();
		this.TabPage7 = new System.Windows.Forms.TabPage();
		this.btnDO = new System.Windows.Forms.Button();
		this.dgvDeliveryOrder = new System.Windows.Forms.DataGridView();
		this.tabInvoice = new System.Windows.Forms.TabPage();
		this.lblUnpaid = new System.Windows.Forms.Label();
		this.lblChequeLaterThanTOP = new System.Windows.Forms.Label();
		this.lblUnpaidMoreThanTOP = new System.Windows.Forms.Label();
		this.btnSalesInvoice = new System.Windows.Forms.Button();
		this.dgvInvoice = new System.Windows.Forms.DataGridView();
		this.TabPage4 = new System.Windows.Forms.TabPage();
		this.btnSalesReturn = new System.Windows.Forms.Button();
		this.dgvReturn = new System.Windows.Forms.DataGridView();
		this.TabPage5 = new System.Windows.Forms.TabPage();
		this.btnPayment = new System.Windows.Forms.Button();
		this.dgvPayment = new System.Windows.Forms.DataGridView();
		this.TabPage3 = new System.Windows.Forms.TabPage();
		this.dgvReturnPayment = new System.Windows.Forms.DataGridView();
		this.TabPage6 = new System.Windows.Forms.TabPage();
		this.btnSalesReceipt = new System.Windows.Forms.Button();
		this.dgvSalesReceipt = new System.Windows.Forms.DataGridView();
		this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
		this.BackgroundWorkerSalesInvoice = new System.ComponentModel.BackgroundWorker();
		this.TabControl1.SuspendLayout();
		this.TabPage1.SuspendLayout();
		this.GroupBox1.SuspendLayout();
		this.TabPage2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvSalesOrder).BeginInit();
		this.TabPage7.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvDeliveryOrder).BeginInit();
		this.tabInvoice.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvInvoice).BeginInit();
		this.TabPage4.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvReturn).BeginInit();
		this.TabPage5.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvPayment).BeginInit();
		this.TabPage3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvReturnPayment).BeginInit();
		this.TabPage6.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvSalesReceipt).BeginInit();
		base.SuspendLayout();
		this.TabControl1.Controls.Add(this.TabPage1);
		this.TabControl1.Controls.Add(this.TabPage2);
		this.TabControl1.Controls.Add(this.TabPage7);
		this.TabControl1.Controls.Add(this.tabInvoice);
		this.TabControl1.Controls.Add(this.TabPage4);
		this.TabControl1.Controls.Add(this.TabPage5);
		this.TabControl1.Controls.Add(this.TabPage3);
		this.TabControl1.Controls.Add(this.TabPage6);
		this.TabControl1.Location = new System.Drawing.Point(12, 12);
		this.TabControl1.Name = "TabControl1";
		this.TabControl1.SelectedIndex = 0;
		this.TabControl1.Size = new System.Drawing.Size(653, 468);
		this.TabControl1.TabIndex = 94;
		this.TabPage1.BackColor = System.Drawing.SystemColors.Control;
		this.TabPage1.Controls.Add(this.txtMemberName);
		this.TabPage1.Controls.Add(this.chkIsParent);
		this.TabPage1.Controls.Add(this.Label28);
		this.TabPage1.Controls.Add(this.cboArea);
		this.TabPage1.Controls.Add(this.btnHistory);
		this.TabPage1.Controls.Add(this.btnSave);
		this.TabPage1.Controls.Add(this.Label27);
		this.TabPage1.Controls.Add(this.txtCreditLimit);
		this.TabPage1.Controls.Add(this.txtTOP);
		this.TabPage1.Controls.Add(this.dtpActive);
		this.TabPage1.Controls.Add(this.Label14);
		this.TabPage1.Controls.Add(this.cboCashAccount);
		this.TabPage1.Controls.Add(this.Label7);
		this.TabPage1.Controls.Add(this.Label25);
		this.TabPage1.Controls.Add(this.cboStorage);
		this.TabPage1.Controls.Add(this.Label4);
		this.TabPage1.Controls.Add(this.cboCollector);
		this.TabPage1.Controls.Add(this.cboBranch);
		this.TabPage1.Controls.Add(this.Label26);
		this.TabPage1.Controls.Add(this.cboBankAccount);
		this.TabPage1.Controls.Add(this.Label13);
		this.TabPage1.Controls.Add(this.Label12);
		this.TabPage1.Controls.Add(this.Label8);
		this.TabPage1.Controls.Add(this.cboDiscount);
		this.TabPage1.Controls.Add(this.Label9);
		this.TabPage1.Controls.Add(this.cboActive);
		this.TabPage1.Controls.Add(this.Label10);
		this.TabPage1.Controls.Add(this.cboPriceCode);
		this.TabPage1.Controls.Add(this.Label11);
		this.TabPage1.Controls.Add(this.cboSalesPerson);
		this.TabPage1.Controls.Add(this.Label5);
		this.TabPage1.Controls.Add(this.Label6);
		this.TabPage1.Controls.Add(this.cboCustomerCode);
		this.TabPage1.Controls.Add(this.chkTF);
		this.TabPage1.Controls.Add(this.Label24);
		this.TabPage1.Controls.Add(this.Label23);
		this.TabPage1.Controls.Add(this.Label22);
		this.TabPage1.Controls.Add(this.cboGroupCustomer);
		this.TabPage1.Controls.Add(this.GroupBox1);
		this.TabPage1.Controls.Add(this.txtPT);
		this.TabPage1.Controls.Add(this.Label3);
		this.TabPage1.Controls.Add(this.txtContact);
		this.TabPage1.Controls.Add(this.Label18);
		this.TabPage1.Controls.Add(this.txtFax);
		this.TabPage1.Controls.Add(this.Label1);
		this.TabPage1.Controls.Add(this.txtPhone);
		this.TabPage1.Controls.Add(this.Label2);
		this.TabPage1.Controls.Add(this.txtPostCode);
		this.TabPage1.Controls.Add(this.txtCity);
		this.TabPage1.Controls.Add(this.Label15);
		this.TabPage1.Controls.Add(this.txtAddress);
		this.TabPage1.Controls.Add(this.Label16);
		this.TabPage1.Controls.Add(this.txtName);
		this.TabPage1.Controls.Add(this.Label17);
		this.TabPage1.Location = new System.Drawing.Point(4, 22);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage1.Size = new System.Drawing.Size(645, 442);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = "Detail";
		this.txtMemberName.BackColor = System.Drawing.SystemColors.ScrollBar;
		this.txtMemberName.Location = new System.Drawing.Point(292, 341);
		this.txtMemberName.Multiline = true;
		this.txtMemberName.Name = "txtMemberName";
		this.txtMemberName.ReadOnly = true;
		this.txtMemberName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
		this.txtMemberName.Size = new System.Drawing.Size(347, 60);
		this.txtMemberName.TabIndex = 144;
		this.chkIsParent.AutoSize = true;
		this.chkIsParent.Location = new System.Drawing.Point(109, 347);
		this.chkIsParent.Name = "chkIsParent";
		this.chkIsParent.Size = new System.Drawing.Size(49, 17);
		this.chkIsParent.TabIndex = 25;
		this.chkIsParent.Text = "Grup";
		this.chkIsParent.UseVisualStyleBackColor = true;
		this.Label28.AutoSize = true;
		this.Label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label28.Location = new System.Drawing.Point(16, 348);
		this.Label28.Name = "Label28";
		this.Label28.Size = new System.Drawing.Size(28, 13);
		this.Label28.TabIndex = 142;
		this.Label28.Text = "Tipe";
		this.cboArea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboArea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboArea.FormattingEnabled = true;
		this.cboArea.Location = new System.Drawing.Point(390, 80);
		this.cboArea.Name = "cboArea";
		this.cboArea.Size = new System.Drawing.Size(124, 21);
		this.cboArea.TabIndex = 30;
		this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnHistory.Location = new System.Drawing.Point(581, 411);
		this.btnHistory.Name = "btnHistory";
		this.btnHistory.Size = new System.Drawing.Size(50, 24);
		this.btnHistory.TabIndex = 53;
		this.btnHistory.Text = "&History";
		this.btnHistory.UseVisualStyleBackColor = true;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(510, 411);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(65, 24);
		this.btnSave.TabIndex = 50;
		this.btnSave.Text = "&Simpan";
		this.btnSave.UseVisualStyleBackColor = true;
		this.Label27.BackColor = System.Drawing.Color.Silver;
		this.Label27.Location = new System.Drawing.Point(-63, 404);
		this.Label27.Name = "Label27";
		this.Label27.Size = new System.Drawing.Size(713, 39);
		this.Label27.TabIndex = 130;
		this.txtCreditLimit.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtCreditLimit.DontFormat = false;
		this.txtCreditLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.txtCreditLimit.Location = new System.Drawing.Point(390, 54);
		this.txtCreditLimit.MaximumDigit = 3;
		this.txtCreditLimit.Name = "txtCreditLimit";
		this.txtCreditLimit.Size = new System.Drawing.Size(88, 20);
		this.txtCreditLimit.TabIndex = 28;
		this.txtCreditLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.txtTOP.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtTOP.DontFormat = false;
		this.txtTOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.txtTOP.Location = new System.Drawing.Point(390, 28);
		this.txtTOP.MaximumDigit = 3;
		this.txtTOP.Name = "txtTOP";
		this.txtTOP.Size = new System.Drawing.Size(88, 20);
		this.txtTOP.TabIndex = 27;
		this.txtTOP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.dtpActive.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpActive.Location = new System.Drawing.Point(390, 317);
		this.dtpActive.Name = "dtpActive";
		this.dtpActive.Size = new System.Drawing.Size(124, 20);
		this.dtpActive.TabIndex = 38;
		this.Label14.AutoSize = true;
		this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label14.Location = new System.Drawing.Point(287, 240);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(35, 13);
		this.Label14.TabIndex = 124;
		this.Label14.Text = "Kas(*)";
		this.cboCashAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboCashAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboCashAccount.FormattingEnabled = true;
		this.cboCashAccount.Location = new System.Drawing.Point(390, 237);
		this.cboCashAccount.Name = "cboCashAccount";
		this.cboCashAccount.Size = new System.Drawing.Size(124, 21);
		this.cboCashAccount.TabIndex = 35;
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.Location = new System.Drawing.Point(16, 298);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(54, 13);
		this.Label7.TabIndex = 109;
		this.Label7.Text = "Cabang(*)";
		this.Label25.AutoSize = true;
		this.Label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label25.Location = new System.Drawing.Point(287, 215);
		this.Label25.Name = "Label25";
		this.Label25.Size = new System.Drawing.Size(56, 13);
		this.Label25.TabIndex = 123;
		this.Label25.Text = "Penagih(*)";
		this.cboStorage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboStorage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboStorage.FormattingEnabled = true;
		this.cboStorage.Location = new System.Drawing.Point(109, 320);
		this.cboStorage.Name = "cboStorage";
		this.cboStorage.Size = new System.Drawing.Size(124, 21);
		this.cboStorage.TabIndex = 24;
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(16, 324);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(55, 13);
		this.Label4.TabIndex = 108;
		this.Label4.Text = "Gudang(*)";
		this.cboCollector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboCollector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboCollector.FormattingEnabled = true;
		this.cboCollector.Location = new System.Drawing.Point(390, 211);
		this.cboCollector.Name = "cboCollector";
		this.cboCollector.Size = new System.Drawing.Size(124, 21);
		this.cboCollector.TabIndex = 34;
		this.cboBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboBranch.FormattingEnabled = true;
		this.cboBranch.Location = new System.Drawing.Point(109, 295);
		this.cboBranch.Name = "cboBranch";
		this.cboBranch.Size = new System.Drawing.Size(124, 21);
		this.cboBranch.TabIndex = 23;
		this.Label26.AutoSize = true;
		this.Label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label26.Location = new System.Drawing.Point(287, 268);
		this.Label26.Name = "Label26";
		this.Label26.Size = new System.Drawing.Size(63, 13);
		this.Label26.TabIndex = 122;
		this.Label26.Text = "Rekening(*)";
		this.cboBankAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboBankAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboBankAccount.FormattingEnabled = true;
		this.cboBankAccount.Location = new System.Drawing.Point(390, 263);
		this.cboBankAccount.Name = "cboBankAccount";
		this.cboBankAccount.Size = new System.Drawing.Size(124, 21);
		this.cboBankAccount.TabIndex = 36;
		this.Label13.AutoSize = true;
		this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label13.Location = new System.Drawing.Point(287, 57);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(83, 13);
		this.Label13.TabIndex = 118;
		this.Label13.Text = "Batas Piutang(*)";
		this.Label12.AutoSize = true;
		this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label12.Location = new System.Drawing.Point(287, 320);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(70, 13);
		this.Label12.TabIndex = 116;
		this.Label12.Text = "Tanggal Aktif";
		this.Label8.AutoSize = true;
		this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label8.Location = new System.Drawing.Point(287, 162);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(87, 13);
		this.Label8.TabIndex = 115;
		this.Label8.Text = "Kode Discount(*)";
		this.cboDiscount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboDiscount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboDiscount.FormattingEnabled = true;
		this.cboDiscount.Location = new System.Drawing.Point(390, 157);
		this.cboDiscount.Name = "cboDiscount";
		this.cboDiscount.Size = new System.Drawing.Size(124, 21);
		this.cboDiscount.TabIndex = 32;
		this.Label9.AutoSize = true;
		this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label9.Location = new System.Drawing.Point(287, 293);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(47, 13);
		this.Label9.TabIndex = 114;
		this.Label9.Text = "Status(*)";
		this.cboActive.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboActive.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboActive.FormattingEnabled = true;
		this.cboActive.Location = new System.Drawing.Point(390, 290);
		this.cboActive.Name = "cboActive";
		this.cboActive.Size = new System.Drawing.Size(124, 21);
		this.cboActive.TabIndex = 37;
		this.Label10.AutoSize = true;
		this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label10.Location = new System.Drawing.Point(287, 135);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(74, 13);
		this.Label10.TabIndex = 113;
		this.Label10.Text = "Kode Harga(*)";
		this.cboPriceCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboPriceCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboPriceCode.FormattingEnabled = true;
		this.cboPriceCode.Location = new System.Drawing.Point(390, 131);
		this.cboPriceCode.Name = "cboPriceCode";
		this.cboPriceCode.Size = new System.Drawing.Size(124, 21);
		this.cboPriceCode.TabIndex = 31;
		this.Label11.AutoSize = true;
		this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label11.Location = new System.Drawing.Point(287, 188);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(43, 13);
		this.Label11.TabIndex = 112;
		this.Label11.Text = "Sales(*)";
		this.cboSalesPerson.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboSalesPerson.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboSalesPerson.FormattingEnabled = true;
		this.cboSalesPerson.Location = new System.Drawing.Point(390, 183);
		this.cboSalesPerson.Name = "cboSalesPerson";
		this.cboSalesPerson.Size = new System.Drawing.Size(124, 21);
		this.cboSalesPerson.TabIndex = 33;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(287, 83);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(55, 13);
		this.Label5.TabIndex = 111;
		this.Label5.Text = "Wilayah(*)";
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.Location = new System.Drawing.Point(287, 108);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(89, 13);
		this.Label6.TabIndex = 110;
		this.Label6.Text = "Kode Customer(*)";
		this.cboCustomerCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboCustomerCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboCustomerCode.FormattingEnabled = true;
		this.cboCustomerCode.Location = new System.Drawing.Point(390, 105);
		this.cboCustomerCode.Name = "cboCustomerCode";
		this.cboCustomerCode.Size = new System.Drawing.Size(124, 21);
		this.cboCustomerCode.TabIndex = 30;
		this.chkTF.AutoSize = true;
		this.chkTF.Location = new System.Drawing.Point(390, 9);
		this.chkTF.Name = "chkTF";
		this.chkTF.Size = new System.Drawing.Size(110, 17);
		this.chkTF.TabIndex = 26;
		this.chkTF.Text = "Bisa Tukar Faktur";
		this.chkTF.UseVisualStyleBackColor = true;
		this.Label24.AutoSize = true;
		this.Label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label24.Location = new System.Drawing.Point(287, 9);
		this.Label24.Name = "Label24";
		this.Label24.Size = new System.Drawing.Size(68, 13);
		this.Label24.TabIndex = 96;
		this.Label24.Text = "Tukar Faktur";
		this.Label23.AutoSize = true;
		this.Label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label23.Location = new System.Drawing.Point(287, 31);
		this.Label23.Name = "Label23";
		this.Label23.Size = new System.Drawing.Size(97, 13);
		this.Label23.TabIndex = 94;
		this.Label23.Text = "Term of Payment(*)";
		this.Label22.AutoSize = true;
		this.Label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label22.Location = new System.Drawing.Point(16, 373);
		this.Label22.Name = "Label22";
		this.Label22.Size = new System.Drawing.Size(80, 13);
		this.Label22.TabIndex = 92;
		this.Label22.Text = "Anggota dari (*)";
		this.cboGroupCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboGroupCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboGroupCustomer.FormattingEnabled = true;
		this.cboGroupCustomer.Location = new System.Drawing.Point(109, 370);
		this.cboGroupCustomer.Name = "cboGroupCustomer";
		this.cboGroupCustomer.Size = new System.Drawing.Size(152, 21);
		this.cboGroupCustomer.TabIndex = 25;
		this.GroupBox1.Controls.Add(this.txtTaxPostCode);
		this.GroupBox1.Controls.Add(this.txtTaxCity);
		this.GroupBox1.Controls.Add(this.Label19);
		this.GroupBox1.Controls.Add(this.txtTaxAddress);
		this.GroupBox1.Controls.Add(this.Label20);
		this.GroupBox1.Controls.Add(this.txtNPWP);
		this.GroupBox1.Controls.Add(this.Label21);
		this.GroupBox1.Location = new System.Drawing.Point(10, 189);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(262, 103);
		this.GroupBox1.TabIndex = 19;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Keterangan Pajak";
		this.txtTaxPostCode.Location = new System.Drawing.Point(193, 71);
		this.txtTaxPostCode.Name = "txtTaxPostCode";
		this.txtTaxPostCode.Size = new System.Drawing.Size(58, 20);
		this.txtTaxPostCode.TabIndex = 22;
		this.txtTaxCity.Location = new System.Drawing.Point(99, 71);
		this.txtTaxCity.Name = "txtTaxCity";
		this.txtTaxCity.Size = new System.Drawing.Size(88, 20);
		this.txtTaxCity.TabIndex = 21;
		this.Label19.AutoSize = true;
		this.Label19.Location = new System.Drawing.Point(6, 74);
		this.Label19.Name = "Label19";
		this.Label19.Size = new System.Drawing.Size(87, 13);
		this.Label19.TabIndex = 87;
		this.Label19.Text = "Kota && Kode Pos";
		this.txtTaxAddress.Location = new System.Drawing.Point(99, 45);
		this.txtTaxAddress.Name = "txtTaxAddress";
		this.txtTaxAddress.Size = new System.Drawing.Size(152, 20);
		this.txtTaxAddress.TabIndex = 20;
		this.Label20.AutoSize = true;
		this.Label20.Location = new System.Drawing.Point(6, 48);
		this.Label20.Name = "Label20";
		this.Label20.Size = new System.Drawing.Size(39, 13);
		this.Label20.TabIndex = 86;
		this.Label20.Text = "Alamat";
		this.txtNPWP.Location = new System.Drawing.Point(99, 19);
		this.txtNPWP.Name = "txtNPWP";
		this.txtNPWP.Size = new System.Drawing.Size(152, 20);
		this.txtNPWP.TabIndex = 19;
		this.Label21.AutoSize = true;
		this.Label21.Location = new System.Drawing.Point(6, 22);
		this.Label21.Name = "Label21";
		this.Label21.Size = new System.Drawing.Size(40, 13);
		this.Label21.TabIndex = 83;
		this.Label21.Text = "NPWP";
		this.txtPT.Location = new System.Drawing.Point(109, 162);
		this.txtPT.Name = "txtPT";
		this.txtPT.Size = new System.Drawing.Size(152, 20);
		this.txtPT.TabIndex = 18;
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(16, 166);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(52, 13);
		this.Label3.TabIndex = 89;
		this.Label3.Text = "Nama PT";
		this.txtContact.Location = new System.Drawing.Point(109, 136);
		this.txtContact.Name = "txtContact";
		this.txtContact.Size = new System.Drawing.Size(152, 20);
		this.txtContact.TabIndex = 17;
		this.Label18.AutoSize = true;
		this.Label18.Location = new System.Drawing.Point(16, 140);
		this.Label18.Name = "Label18";
		this.Label18.Size = new System.Drawing.Size(82, 13);
		this.Label18.TabIndex = 87;
		this.Label18.Text = "Nama Kontak(*)";
		this.txtFax.Location = new System.Drawing.Point(109, 110);
		this.txtFax.Name = "txtFax";
		this.txtFax.Size = new System.Drawing.Size(152, 20);
		this.txtFax.TabIndex = 16;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(16, 114);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(24, 13);
		this.Label1.TabIndex = 85;
		this.Label1.Text = "Fax";
		this.txtPhone.Location = new System.Drawing.Point(109, 84);
		this.txtPhone.Name = "txtPhone";
		this.txtPhone.Size = new System.Drawing.Size(152, 20);
		this.txtPhone.TabIndex = 15;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(16, 88);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(46, 13);
		this.Label2.TabIndex = 83;
		this.Label2.Text = "Telepon";
		this.txtPostCode.Location = new System.Drawing.Point(203, 58);
		this.txtPostCode.Name = "txtPostCode";
		this.txtPostCode.Size = new System.Drawing.Size(58, 20);
		this.txtPostCode.TabIndex = 14;
		this.txtCity.Location = new System.Drawing.Point(109, 58);
		this.txtCity.Name = "txtCity";
		this.txtCity.Size = new System.Drawing.Size(88, 20);
		this.txtCity.TabIndex = 13;
		this.Label15.AutoSize = true;
		this.Label15.Location = new System.Drawing.Point(16, 61);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(87, 13);
		this.Label15.TabIndex = 80;
		this.Label15.Text = "Kota && Kode Pos";
		this.txtAddress.Location = new System.Drawing.Point(109, 32);
		this.txtAddress.Name = "txtAddress";
		this.txtAddress.Size = new System.Drawing.Size(152, 20);
		this.txtAddress.TabIndex = 12;
		this.Label16.AutoSize = true;
		this.Label16.Location = new System.Drawing.Point(16, 35);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(49, 13);
		this.Label16.TabIndex = 79;
		this.Label16.Text = "Alamat(*)";
		this.txtName.Location = new System.Drawing.Point(109, 6);
		this.txtName.Name = "txtName";
		this.txtName.Size = new System.Drawing.Size(152, 20);
		this.txtName.TabIndex = 11;
		this.Label17.AutoSize = true;
		this.Label17.Location = new System.Drawing.Point(16, 9);
		this.Label17.Name = "Label17";
		this.Label17.Size = new System.Drawing.Size(92, 13);
		this.Label17.TabIndex = 76;
		this.Label17.Text = "Nama Customer(*)";
		this.TabPage2.Controls.Add(this.btnSO);
		this.TabPage2.Controls.Add(this.dgvSalesOrder);
		this.TabPage2.Location = new System.Drawing.Point(4, 22);
		this.TabPage2.Name = "TabPage2";
		this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage2.Size = new System.Drawing.Size(645, 442);
		this.TabPage2.TabIndex = 1;
		this.TabPage2.Text = "Pesanan Penjualan";
		this.TabPage2.UseVisualStyleBackColor = true;
		this.btnSO.BackColor = System.Drawing.Color.Gainsboro;
		this.btnSO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSO.Location = new System.Drawing.Point(506, 405);
		this.btnSO.Name = "btnSO";
		this.btnSO.Size = new System.Drawing.Size(123, 26);
		this.btnSO.TabIndex = 10;
		this.btnSO.Text = "+ Pesanan Penjualan";
		this.btnSO.UseVisualStyleBackColor = false;
		this.dgvSalesOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvSalesOrder.Location = new System.Drawing.Point(12, 13);
		this.dgvSalesOrder.Name = "dgvSalesOrder";
		this.dgvSalesOrder.Size = new System.Drawing.Size(617, 386);
		this.dgvSalesOrder.TabIndex = 8;
		this.TabPage7.Controls.Add(this.btnDO);
		this.TabPage7.Controls.Add(this.dgvDeliveryOrder);
		this.TabPage7.Location = new System.Drawing.Point(4, 22);
		this.TabPage7.Name = "TabPage7";
		this.TabPage7.Size = new System.Drawing.Size(645, 442);
		this.TabPage7.TabIndex = 6;
		this.TabPage7.Text = "Pengiriman Pesanan";
		this.TabPage7.UseVisualStyleBackColor = true;
		this.btnDO.BackColor = System.Drawing.Color.Gainsboro;
		this.btnDO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDO.Location = new System.Drawing.Point(506, 402);
		this.btnDO.Name = "btnDO";
		this.btnDO.Size = new System.Drawing.Size(123, 26);
		this.btnDO.TabIndex = 9;
		this.btnDO.Text = "+ Pengiriman Pesanan";
		this.btnDO.UseVisualStyleBackColor = false;
		this.dgvDeliveryOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvDeliveryOrder.Location = new System.Drawing.Point(12, 13);
		this.dgvDeliveryOrder.Name = "dgvDeliveryOrder";
		this.dgvDeliveryOrder.Size = new System.Drawing.Size(617, 383);
		this.dgvDeliveryOrder.TabIndex = 8;
		this.tabInvoice.Controls.Add(this.lblUnpaid);
		this.tabInvoice.Controls.Add(this.lblChequeLaterThanTOP);
		this.tabInvoice.Controls.Add(this.lblUnpaidMoreThanTOP);
		this.tabInvoice.Controls.Add(this.btnSalesInvoice);
		this.tabInvoice.Controls.Add(this.dgvInvoice);
		this.tabInvoice.Location = new System.Drawing.Point(4, 22);
		this.tabInvoice.Name = "tabInvoice";
		this.tabInvoice.Size = new System.Drawing.Size(645, 442);
		this.tabInvoice.TabIndex = 2;
		this.tabInvoice.Text = "Faktur Penjualan";
		this.tabInvoice.UseVisualStyleBackColor = true;
		this.lblUnpaid.BackColor = System.Drawing.Color.WhiteSmoke;
		this.lblUnpaid.ForeColor = System.Drawing.Color.Red;
		this.lblUnpaid.Location = new System.Drawing.Point(365, 399);
		this.lblUnpaid.Name = "lblUnpaid";
		this.lblUnpaid.Size = new System.Drawing.Size(180, 16);
		this.lblUnpaid.TabIndex = 11;
		this.lblUnpaid.Text = "lblUnpaid";
		this.lblChequeLaterThanTOP.BackColor = System.Drawing.Color.Yellow;
		this.lblChequeLaterThanTOP.Location = new System.Drawing.Point(9, 399);
		this.lblChequeLaterThanTOP.Name = "lblChequeLaterThanTOP";
		this.lblChequeLaterThanTOP.Size = new System.Drawing.Size(350, 16);
		this.lblChequeLaterThanTOP.TabIndex = 10;
		this.lblChequeLaterThanTOP.Text = "lblChequeLaterThanTOP";
		this.lblUnpaidMoreThanTOP.BackColor = System.Drawing.Color.Red;
		this.lblUnpaidMoreThanTOP.Location = new System.Drawing.Point(9, 418);
		this.lblUnpaidMoreThanTOP.Name = "lblUnpaidMoreThanTOP";
		this.lblUnpaidMoreThanTOP.Size = new System.Drawing.Size(350, 13);
		this.lblUnpaidMoreThanTOP.TabIndex = 9;
		this.lblUnpaidMoreThanTOP.Text = "lblTOP";
		this.btnSalesInvoice.BackColor = System.Drawing.Color.Gainsboro;
		this.btnSalesInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSalesInvoice.Location = new System.Drawing.Point(551, 402);
		this.btnSalesInvoice.Name = "btnSalesInvoice";
		this.btnSalesInvoice.Size = new System.Drawing.Size(78, 26);
		this.btnSalesInvoice.TabIndex = 8;
		this.btnSalesInvoice.Text = "+ Penjualan";
		this.btnSalesInvoice.UseVisualStyleBackColor = false;
		this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvInvoice.Location = new System.Drawing.Point(12, 13);
		this.dgvInvoice.Name = "dgvInvoice";
		this.dgvInvoice.Size = new System.Drawing.Size(617, 383);
		this.dgvInvoice.TabIndex = 7;
		this.TabPage4.Controls.Add(this.btnSalesReturn);
		this.TabPage4.Controls.Add(this.dgvReturn);
		this.TabPage4.Location = new System.Drawing.Point(4, 22);
		this.TabPage4.Name = "TabPage4";
		this.TabPage4.Size = new System.Drawing.Size(645, 442);
		this.TabPage4.TabIndex = 3;
		this.TabPage4.Text = "Retur";
		this.TabPage4.UseVisualStyleBackColor = true;
		this.btnSalesReturn.BackColor = System.Drawing.Color.Gainsboro;
		this.btnSalesReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSalesReturn.Location = new System.Drawing.Point(569, 404);
		this.btnSalesReturn.Name = "btnSalesReturn";
		this.btnSalesReturn.Size = new System.Drawing.Size(60, 26);
		this.btnSalesReturn.TabIndex = 9;
		this.btnSalesReturn.Text = "+ Retur";
		this.btnSalesReturn.UseVisualStyleBackColor = false;
		this.dgvReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvReturn.Location = new System.Drawing.Point(12, 13);
		this.dgvReturn.Name = "dgvReturn";
		this.dgvReturn.Size = new System.Drawing.Size(617, 385);
		this.dgvReturn.TabIndex = 8;
		this.TabPage5.Controls.Add(this.btnPayment);
		this.TabPage5.Controls.Add(this.dgvPayment);
		this.TabPage5.Location = new System.Drawing.Point(4, 22);
		this.TabPage5.Name = "TabPage5";
		this.TabPage5.Size = new System.Drawing.Size(645, 442);
		this.TabPage5.TabIndex = 4;
		this.TabPage5.Text = "Pembayaran Faktur";
		this.TabPage5.UseVisualStyleBackColor = true;
		this.btnPayment.BackColor = System.Drawing.Color.Gainsboro;
		this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnPayment.Location = new System.Drawing.Point(539, 404);
		this.btnPayment.Name = "btnPayment";
		this.btnPayment.Size = new System.Drawing.Size(90, 26);
		this.btnPayment.TabIndex = 10;
		this.btnPayment.Text = "+ Pembayaran";
		this.btnPayment.UseVisualStyleBackColor = false;
		this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvPayment.Location = new System.Drawing.Point(12, 13);
		this.dgvPayment.Name = "dgvPayment";
		this.dgvPayment.Size = new System.Drawing.Size(617, 385);
		this.dgvPayment.TabIndex = 8;
		this.TabPage3.Controls.Add(this.dgvReturnPayment);
		this.TabPage3.Location = new System.Drawing.Point(4, 22);
		this.TabPage3.Name = "TabPage3";
		this.TabPage3.Size = new System.Drawing.Size(645, 442);
		this.TabPage3.TabIndex = 7;
		this.TabPage3.Text = "Pembayaran Retur";
		this.TabPage3.UseVisualStyleBackColor = true;
		this.dgvReturnPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvReturnPayment.Location = new System.Drawing.Point(12, 13);
		this.dgvReturnPayment.Name = "dgvReturnPayment";
		this.dgvReturnPayment.Size = new System.Drawing.Size(617, 404);
		this.dgvReturnPayment.TabIndex = 9;
		this.TabPage6.Controls.Add(this.btnSalesReceipt);
		this.TabPage6.Controls.Add(this.dgvSalesReceipt);
		this.TabPage6.Location = new System.Drawing.Point(4, 22);
		this.TabPage6.Name = "TabPage6";
		this.TabPage6.Size = new System.Drawing.Size(645, 442);
		this.TabPage6.TabIndex = 5;
		this.TabPage6.Text = "Kuitansi";
		this.TabPage6.UseVisualStyleBackColor = true;
		this.btnSalesReceipt.BackColor = System.Drawing.Color.Gainsboro;
		this.btnSalesReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSalesReceipt.Location = new System.Drawing.Point(554, 404);
		this.btnSalesReceipt.Name = "btnSalesReceipt";
		this.btnSalesReceipt.Size = new System.Drawing.Size(75, 26);
		this.btnSalesReceipt.TabIndex = 10;
		this.btnSalesReceipt.Text = "+ Kuitansi";
		this.btnSalesReceipt.UseVisualStyleBackColor = false;
		this.dgvSalesReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvSalesReceipt.Location = new System.Drawing.Point(12, 13);
		this.dgvSalesReceipt.Name = "dgvSalesReceipt";
		this.dgvSalesReceipt.Size = new System.Drawing.Size(617, 385);
		this.dgvSalesReceipt.TabIndex = 8;
		this.BackgroundWorkerSalesInvoice.WorkerReportsProgress = true;
		this.BackgroundWorkerSalesInvoice.WorkerSupportsCancellation = true;
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(677, 492);
		base.Controls.Add(this.TabControl1);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmCustomer";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Customer";
		this.TabControl1.ResumeLayout(false);
		this.TabPage1.ResumeLayout(false);
		this.TabPage1.PerformLayout();
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		this.TabPage2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgvSalesOrder).EndInit();
		this.TabPage7.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgvDeliveryOrder).EndInit();
		this.tabInvoice.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgvInvoice).EndInit();
		this.TabPage4.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgvReturn).EndInit();
		this.TabPage5.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgvPayment).EndInit();
		this.TabPage3.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgvReturnPayment).EndInit();
		this.TabPage6.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgvSalesReceipt).EndInit();
		base.ResumeLayout(false);
	}

	private void frmCustomer_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	public frmCustomer()
	{
		base.KeyDown += frmCustomer_KeyDown;
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
					ComboBox combo = cboBranch;
					bool branch = cCombo.getBranch(ref combo, Module1.pubGroupId, blnAll: false);
					cboBranch = combo;
					if (!branch)
					{
						cboBranch.Enabled = false;
					}
					combo = cboCustomerCode;
					cCombo.getCustomerCode(ref combo, All: false, 1);
					cboCustomerCode = combo;
					combo = cboPriceCode;
					cCombo.getPriceCode(ref combo, All: false, -1);
					cboPriceCode = combo;
					combo = cboDiscount;
					cCombo.getDiscount(ref combo, All: false, Active: true);
					cboDiscount = combo;
					combo = cboActive;
					cCombo.getActive(ref combo, All: false);
					cboActive = combo;
					txtTOP.AllowedCharacters = FilteredTextBox.InputType.NumeralsOnly;
					txtCreditLimit.AllowedCharacters = FilteredTextBox.InputType.NumeralsOnly;
					ExtensionMethods.DoubleBuffered(dgvDeliveryOrder, setting: true);
					ExtensionMethods.DoubleBuffered(dgvInvoice, setting: true);
					ExtensionMethods.DoubleBuffered(dgvPayment, setting: true);
					ExtensionMethods.DoubleBuffered(dgvReturn, setting: true);
					ExtensionMethods.DoubleBuffered(dgvReturnPayment, setting: true);
					ExtensionMethods.DoubleBuffered(dgvSalesOrder, setting: true);
					ExtensionMethods.DoubleBuffered(dgvSalesReceipt, setting: true);
					formatGrid();
					goto end_IL_001b;
				}
				case 372:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmCustomer", "New", "");
						goto end_IL_001b;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try001b_dispatch = 372;
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

	public void prepareForm()
	{
		_currentId = 0.0;
		_hasMember = false;
		txtName.Text = "";
		txtAddress.Text = "";
		txtCity.Text = "";
		txtPostCode.Text = "";
		txtPhone.Text = "";
		txtFax.Text = "";
		txtContact.Text = "";
		txtPT.Text = "";
		txtNPWP.Text = "";
		txtTaxAddress.Text = "";
		txtTaxCity.Text = "";
		txtTaxPostCode.Text = "";
		ComboBox cboSource = cboBranch;
		Module1.comboBoundValue(ref cboSource, Module1.pubBranchId);
		cboBranch = cboSource;
		cboGroupCustomer.SelectedIndex = 0;
		txtTOP.Text = "";
		txtCreditLimit.Text = "";
		chkTF.Checked = false;
		cboSource = cboStorage;
		Module1.comboBoundValue(ref cboSource, Module1.pubStorageId);
		cboStorage = cboSource;
		chkIsParent.Checked = false;
		cboCustomerCode.Text = "";
		cboPriceCode.Text = "";
		cboDiscount.Text = "";
		cboSalesPerson.Text = "";
		cboCollector.Text = "";
		cboCustomerCode.SelectedIndex = -1;
		cboPriceCode.SelectedIndex = -1;
		cboDiscount.SelectedIndex = -1;
		cboSalesPerson.SelectedIndex = -1;
		cboCollector.SelectedIndex = -1;
		cboSource = cboCashAccount;
		Module1.comboBoundValue(ref cboSource, Module1.pubCashAccountId);
		cboCashAccount = cboSource;
		cboSource = cboBankAccount;
		Module1.comboBoundValue(ref cboSource, Module1.pubBankAccountId);
		cboBankAccount = cboSource;
		cboActive.SelectedIndex = 0;
		dtpActive.Value = DateAndTime.Now;
		lblChequeLaterThanTOP.Text = "";
		lblUnpaid.Text = "";
		lblUnpaidMoreThanTOP.Text = "";
		txtMemberName.Visible = false;
		txtName.Focus();
	}

	private void cboBranch_SelectedIndexChanged(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboBranch.SelectedItem;
		if (!Information.IsNothing(cComboItem2))
		{
			ComboBox combo = cboStorage;
			cCombo.getStorage(ref combo, Module1.pubGroupId, Conversions.ToInteger(cComboItem2.Value), "MARKETING", blnAll: false, 1);
			cboStorage = combo;
			combo = cboSalesPerson;
			cCombo.getSalesPerson(ref combo, "SALESPERSON", 0, 99, Conversions.ToInteger(cComboItem2.Value), Module1.pubGroupId, All: false, Dash: false, 1);
			cboSalesPerson = combo;
			combo = cboArea;
			cCombo.getArea(ref combo, Conversions.ToInteger(cComboItem2.Value), Module1.pubGroupId, All: false, Active: true);
			cboArea = combo;
			combo = cboGroupCustomer;
			cCombo.getGroupCustomer(ref combo, Conversions.ToInteger(cComboItem2.Value), Module1.pubGroupId, None: true, All: false, Active: true);
			cboGroupCustomer = combo;
			combo = cboCashAccount;
			cCombo.getCashAccount(ref combo, 0, Module1.pubGroupId, All: false, GroupDefault: false, Active: true, "GENERAL", 0);
			cboCashAccount = combo;
			combo = cboBankAccount;
			cCombo.getBankAccount(ref combo, 0, Module1.pubGroupId, All: false, GroupDefault: false, Active: true, "GENERAL", 0);
			cboBankAccount = combo;
			cboStorage.Text = "";
			cboArea.Text = "";
			cboSalesPerson.Text = "";
			cboCollector.Text = "";
			cboGroupCustomer.Text = "";
			cboCashAccount.Text = "";
			cboBankAccount.Text = "";
			cboStorage.SelectedIndex = -1;
			cboArea.SelectedIndex = -1;
			cboCustomerCode.SelectedIndex = -1;
			cboPriceCode.SelectedIndex = -1;
			cboDiscount.SelectedIndex = -1;
			cboSalesPerson.SelectedIndex = -1;
			cboCollector.SelectedIndex = -1;
			cboGroupCustomer.SelectedIndex = -1;
			cboCashAccount.SelectedIndex = -1;
			cboBankAccount.SelectedIndex = -1;
			cboCollector.Items.Clear();
		}
	}

	private void cboSalesPerson_SelectedIndexChanged(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboBranch.SelectedItem;
		cComboItem cComboItem3 = (cComboItem)cboSalesPerson.SelectedItem;
		if (!Information.IsNothing(cComboItem3))
		{
			ComboBox combo = cboCollector;
			cCombo.getSalesPerson(ref combo, "SALESPERSON_COLLECTOR", Conversions.ToInteger(cComboItem3.Value), 99, Conversions.ToInteger(cComboItem2.Value), Module1.pubGroupId, All: false, Dash: false, 1);
			cboCollector = combo;
			cboCollector.SelectedIndex = 0;
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
				checked
				{
					switch (try0001_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						cCustomer cCustomer2 = new cCustomer(_currentId);
						txtName.Text = cCustomer2.Name;
						txtAddress.Text = cCustomer2.Address;
						txtCity.Text = cCustomer2.City;
						txtPostCode.Text = cCustomer2.PostCode;
						txtPhone.Text = cCustomer2.Phone;
						txtFax.Text = cCustomer2.Fax;
						txtContact.Text = cCustomer2.Contact;
						txtPT.Text = cCustomer2.PT;
						txtNPWP.Text = cCustomer2.NPWP;
						txtTaxAddress.Text = cCustomer2.TaxAddress;
						txtTaxCity.Text = cCustomer2.TaxCity;
						txtTaxPostCode.Text = cCustomer2.TaxPostCode;
						ComboBox cboSource = cboBranch;
						Module1.comboBoundValue(ref cboSource, cCustomer2.BranchId);
						cboBranch = cboSource;
						if (cCustomer2.Id == cCustomer2.ParentId)
						{
							cboSource = cboGroupCustomer;
							Module1.comboBoundValue(ref cboSource, 0.0);
							cboGroupCustomer = cboSource;
						}
						else
						{
							cboSource = cboGroupCustomer;
							Module1.comboBoundValue(ref cboSource, cCustomer2.ParentId);
							cboGroupCustomer = cboSource;
						}
						if (cCustomer2.IsParent == 0)
						{
							chkIsParent.Checked = false;
							txtMemberName.Visible = false;
						}
						else
						{
							txtMemberName.Visible = true;
							chkIsParent.Checked = true;
							btnDO.Enabled = false;
							btnSO.Enabled = false;
							btnSalesInvoice.Enabled = false;
							btnSalesReturn.Enabled = false;
							btnSalesReceipt.Enabled = false;
						}
						txtTOP.Text = Conversions.ToString(cCustomer2.TOP);
						txtCreditLimit.Text = Conversions.ToString(cCustomer2.CreditLimit);
						chkTF.Checked = cCustomer2.TukarFaktur != 0;
						cboSource = cboStorage;
						Module1.comboBoundValue(ref cboSource, cCustomer2.StorageId);
						cboStorage = cboSource;
						cboSource = cboArea;
						Module1.comboBoundValue(ref cboSource, cCustomer2.AreaId);
						cboArea = cboSource;
						cboSource = cboCustomerCode;
						Module1.comboBoundValue(ref cboSource, cCustomer2.CustomerCodeId);
						cboCustomerCode = cboSource;
						cboSource = cboPriceCode;
						Module1.comboBoundValue(ref cboSource, cCustomer2.PriceCodeId);
						cboPriceCode = cboSource;
						cboSource = cboDiscount;
						Module1.comboBoundValue(ref cboSource, cCustomer2.DiscountId);
						cboDiscount = cboSource;
						cboSource = cboSalesPerson;
						Module1.comboBoundValue(ref cboSource, cCustomer2.SalesPersonId);
						cboSalesPerson = cboSource;
						cboSource = cboCollector;
						Module1.comboBoundValue(ref cboSource, cCustomer2.CollectorId);
						cboCollector = cboSource;
						cboSource = cboCashAccount;
						Module1.comboBoundValue(ref cboSource, cCustomer2.CashAccountId);
						cboCashAccount = cboSource;
						cboSource = cboBankAccount;
						Module1.comboBoundValue(ref cboSource, cCustomer2.BankAccountId);
						cboBankAccount = cboSource;
						cboSource = cboActive;
						Module1.comboBoundValue(ref cboSource, cCustomer2.Active);
						cboActive = cboSource;
						dtpActive.Value = cCustomer2.CreatedDate;
						txtName.SelectionLength = txtName.Text.Length;
						txtMemberName.Text = "Anggota grup: ";
						if (!Information.IsNothing(cCustomer2.MemberName))
						{
							_hasMember = true;
							int num3 = cCustomer2.MemberName.Count() - 1;
							for (int i = 0; i <= num3; i++)
							{
								if (i > 0)
								{
									txtMemberName.Text += ", ";
								}
								txtMemberName.Text += cCustomer2.MemberName[i];
							}
						}
						else
						{
							_hasMember = false;
						}
						if (cCustomer2.IsParent == 0)
						{
							txtMemberName.Text = "Anggota grup: -";
						}
						if (Module1.pubUpdateCreditLimit)
						{
							txtCreditLimit.Enabled = true;
						}
						else
						{
							txtCreditLimit.Enabled = false;
						}
						if (Module1.pubUpdateTOP)
						{
							txtTOP.Enabled = true;
						}
						else
						{
							txtTOP.Enabled = false;
						}
						if (Module1.pubUpdateCustomer)
						{
							btnSave.Enabled = true;
						}
						else
						{
							btnSave.Enabled = false;
						}
						_loadInvoice = true;
						_loadReturn = true;
						_loadPayment = true;
						_loadReturnPayment = true;
						GetSalesOrder();
						GetDeliveryOrder();
						GetSalesReceipt();
						if (!BackgroundWorker1.IsBusy)
						{
							BackgroundWorker1.RunWorkerAsync();
						}
						TabControl1.SelectedIndex = 0;
						goto end_IL_0001;
					}
					case 1360:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmCustomer", "loadData", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1360;
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

	private void btnSave_Click(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboBranch.SelectedItem;
		cComboItem cComboItem3 = (cComboItem)cboStorage.SelectedItem;
		cComboItem cComboItem4 = (cComboItem)cboGroupCustomer.SelectedItem;
		cComboItem cComboItem5 = (cComboItem)cboArea.SelectedItem;
		cComboItem cComboItem6 = (cComboItem)cboCustomerCode.SelectedItem;
		cComboItem cComboItem7 = (cComboItem)cboPriceCode.SelectedItem;
		cComboItem cComboItem8 = (cComboItem)cboDiscount.SelectedItem;
		cComboItem cComboItem9 = (cComboItem)cboSalesPerson.SelectedItem;
		cComboItem cComboItem10 = (cComboItem)cboCollector.SelectedItem;
		cComboItem cComboItem11 = (cComboItem)cboCashAccount.SelectedItem;
		cComboItem cComboItem12 = (cComboItem)cboBankAccount.SelectedItem;
		cComboItem cComboItem13 = (cComboItem)cboActive.SelectedItem;
		if (Operators.CompareString(txtName.Text, "", TextCompare: false) == 0)
		{
			Interaction.MsgBox("Masukkan nama customer", MsgBoxStyle.Information);
			txtName.Focus();
			return;
		}
		if (Operators.CompareString(txtAddress.Text, "", TextCompare: false) == 0)
		{
			Interaction.MsgBox("Masukkan alamat", MsgBoxStyle.Information);
			txtAddress.Focus();
			return;
		}
		if (Operators.CompareString(txtContact.Text, "", TextCompare: false) == 0)
		{
			Interaction.MsgBox("Masukkan nama kontak", MsgBoxStyle.Information);
			txtContact.Focus();
			return;
		}
		if (_hasMember & !chkIsParent.Checked)
		{
			Interaction.MsgBox("Customer harus tipe Grup karena telah memiliki anggota grup.", MsgBoxStyle.Information);
			chkIsParent.Focus();
			return;
		}
		if (Operators.CompareString(txtTOP.Text, "", TextCompare: false) == 0)
		{
			Interaction.MsgBox("Masukkan Term of Payment", MsgBoxStyle.Information);
			txtTOP.Focus();
			return;
		}
		if (Conversion.Val(txtTOP.Text) == 0.0)
		{
			Interaction.MsgBox("Masukkan Term of Payment", MsgBoxStyle.Information);
			txtTOP.Focus();
			return;
		}
		if (Conversions.ToDouble(txtTOP.Text) > 1000.0)
		{
			Interaction.MsgBox("Term of Payment tidak boleh melebihi 1000", MsgBoxStyle.Information);
			txtTOP.Focus();
			return;
		}
		if (Operators.CompareString(txtCreditLimit.Text, "", TextCompare: false) == 0)
		{
			Interaction.MsgBox("Masukkan batas piutang", MsgBoxStyle.Information);
			txtCreditLimit.Focus();
			return;
		}
		if (Conversions.ToDouble(txtCreditLimit.Text) > 1000.0)
		{
			Interaction.MsgBox("Batas Piutang tidak boleh melebihi 1000", MsgBoxStyle.Information);
			txtCreditLimit.Focus();
			return;
		}
		if (cboBranch.SelectedIndex == -1)
		{
			Interaction.MsgBox("Cabang yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
			cboBranch.Focus();
			return;
		}
		if (cboStorage.SelectedIndex == -1)
		{
			Interaction.MsgBox("Gudang yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
			cboStorage.Focus();
			return;
		}
		if (cboArea.SelectedIndex == -1)
		{
			Interaction.MsgBox("Wilayah yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
			cboArea.Focus();
			return;
		}
		if (cboCustomerCode.SelectedIndex == -1)
		{
			Interaction.MsgBox("Kode Customer yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
			cboCustomerCode.Focus();
			return;
		}
		if (cboPriceCode.SelectedIndex == -1)
		{
			Interaction.MsgBox("Kode Harga yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
			cboPriceCode.Focus();
			return;
		}
		if (cboDiscount.SelectedIndex == -1)
		{
			Interaction.MsgBox("Kode Discount yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
			cboDiscount.Focus();
			return;
		}
		if (cboSalesPerson.SelectedIndex == -1)
		{
			Interaction.MsgBox("Sales yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
			cboSalesPerson.Focus();
			return;
		}
		if (cboCollector.SelectedIndex == -1)
		{
			Interaction.MsgBox("Penagih yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
			cboSalesPerson.Focus();
			return;
		}
		if (cboCashAccount.SelectedIndex == -1)
		{
			Interaction.MsgBox("Kas yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
			cboCashAccount.Focus();
			return;
		}
		if (cboBankAccount.SelectedIndex == -1)
		{
			Interaction.MsgBox("Rekening bank yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
			cboBankAccount.Focus();
			return;
		}
		if (cboActive.SelectedIndex == -1)
		{
			Interaction.MsgBox("Status yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
			cboActive.Focus();
			return;
		}
		cCustomer cCustomer2 = new cCustomer(0.0);
		cCustomer2.Id = _currentId;
		cCustomer2.Name = txtName.Text;
		cCustomer2.Address = txtAddress.Text;
		cCustomer2.City = txtCity.Text;
		cCustomer2.PostCode = txtPostCode.Text;
		cCustomer2.Phone = txtPhone.Text;
		cCustomer2.Fax = txtFax.Text;
		cCustomer2.Contact = txtContact.Text;
		cCustomer2.PT = txtPT.Text;
		cCustomer2.NPWP = txtNPWP.Text;
		cCustomer2.TaxAddress = txtTaxAddress.Text;
		cCustomer2.TaxCity = txtTaxCity.Text;
		cCustomer2.TaxPostCode = txtTaxPostCode.Text;
		cCustomer2.BranchId = Conversions.ToInteger(cComboItem2.Value);
		cCustomer2.StorageId = Conversions.ToInteger(cComboItem3.Value);
		cCustomer2.IsParent = Conversions.ToInteger(Interaction.IIf(chkIsParent.Checked, 1, 0));
		if (Conversions.ToDouble(cComboItem4.Value) == 0.0)
		{
			cCustomer2.ParentId = _currentId;
		}
		else
		{
			cCustomer2.ParentId = Conversions.ToDouble(cComboItem4.Value);
		}
		cCustomer2.TukarFaktur = Conversions.ToInteger(Interaction.IIf(chkTF.Checked, 1, 0));
		cCustomer2.TOP = Conversions.ToInteger(txtTOP.Text);
		cCustomer2.CreditLimit = Conversions.ToInteger(txtCreditLimit.Text);
		cCustomer2.AreaId = Conversions.ToInteger(cComboItem5.Value);
		cCustomer2.CustomerCodeId = Conversions.ToInteger(cComboItem6.Value);
		cCustomer2.PriceCodeId = Conversions.ToInteger(cComboItem7.Value);
		cCustomer2.DiscountId = Conversions.ToInteger(cComboItem8.Value);
		cCustomer2.SalesPersonId = Conversions.ToInteger(cComboItem9.Value);
		cCustomer2.CollectorId = Conversions.ToInteger(cComboItem10.Value);
		cCustomer2.CashAccountId = Conversions.ToInteger(cComboItem11.Value);
		cCustomer2.BankAccountId = Conversions.ToInteger(cComboItem12.Value);
		cCustomer2.Active = Conversions.ToInteger(cComboItem13.Value);
		cCustomer2.CreatedDate = dtpActive.Value;
		cCustomer2.save();
		string content = "Nama: " + Module1.cleanString(txtName.Text) + "<br />Alamat: " + Module1.cleanString(txtAddress.Text) + "<br />Kota: " + Module1.cleanString(txtCity.Text) + "<br />Kode Pos: " + Module1.cleanString(txtPostCode.Text) + "<br />Telepon: " + Module1.cleanString(txtPhone.Text) + "<br />Fax: " + Module1.cleanString(txtFax.Text) + "<br />Kontak: " + Module1.cleanString(txtContact.Text) + "<br />PT: " + Module1.cleanString(txtPT.Text) + "<br />NPWP: " + Module1.cleanString(txtNPWP.Text) + "<br />Alamat: " + Module1.cleanString(txtTaxAddress.Text) + "<br />Kota: " + Module1.cleanString(txtTaxCity.Text) + "<br />Kode Pos: " + Module1.cleanString(txtTaxPostCode.Text) + "<br />Cabang: " + cboBranch.Text + "<br />Gudang: " + cboStorage.Text + "<br />Group Customer: " + cboGroupCustomer.Text + "<br />Tukar Faktur: " + Conversions.ToString(chkTF.Checked) + "<br />Term of Payment: " + txtTOP.Text + "<br />Batas Piutang: " + txtCreditLimit.Text + "<br />Wilayah: " + cboArea.Text + "<br />Kode Customer: " + cboCustomerCode.Text + "<br />Kode Harga: " + cboPriceCode.Text + "<br />Discount: " + cboDiscount.Text + "<br />Sales: " + cboSalesPerson.Text + "<br />Penagih: " + cboCollector.Text + "<br />Kas: " + cboCashAccount.Text + "<br />Rekening: " + cboBankAccount.Text + "<br />Status: " + cboActive.Text + "<br />Tanggal aktif: " + Conversions.ToString(dtpActive.Value) + "<br />";
		string text;
		if (_currentId == 0.0)
		{
			text = "membuat ";
			_currentId = cDatabase.LastId("data");
		}
		else
		{
			text = "mengupdate ";
		}
		text = text + "customer " + txtName.Text + ". ID= " + Conversions.ToString(_currentId) + ", v2";
		cHistory cHistory2 = new cHistory();
		cHistory2.Content = content;
		cHistory2.Description = text;
		cHistory2.UserId = Module1.pubUserId;
		cHistory2.UserLogin = Module1.pubLogin;
		cHistory2.fKeyId = _currentId;
		cHistory2.HistoryType = 8;
		cHistory2.Save();
		Interaction.MsgBox("Customer berhasil disimpan", MsgBoxStyle.Information);
	}

	private void formatGrid()
	{
		dgvSalesOrder.Columns.Clear();
		dgvSalesOrder.Columns.Add("", "soId");
		dgvSalesOrder.Columns.Add("", "Tgl. Pesanan");
		dgvSalesOrder.Columns.Add("", "Tgl. Expired");
		dgvSalesOrder.Columns.Add("", "Nomer Pesanan");
		dgvSalesOrder.Columns.Add("", "Customer");
		dgvSalesOrder.Columns.Add("", "Total");
		dgvSalesOrder.Columns.Add("", "Tgl. Faktur");
		dgvSalesOrder.Columns.Add("", "No. Faktur");
		dgvSalesOrder.Columns[0].Visible = false;
		dgvSalesOrder.Columns[1].Width = 70;
		dgvSalesOrder.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvSalesOrder.Columns[2].Width = 70;
		dgvSalesOrder.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvSalesOrder.Columns[3].Width = 150;
		dgvSalesOrder.Columns[4].Visible = false;
		dgvSalesOrder.Columns[5].Width = 80;
		dgvSalesOrder.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvSalesOrder.Columns[6].Width = 70;
		dgvSalesOrder.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvSalesOrder.Columns[7].Width = 80;
		dgvSalesOrder.RowHeadersVisible = false;
		dgvSalesOrder.AllowUserToAddRows = false;
		dgvSalesOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvSalesOrder.ReadOnly = true;
		dgvSalesOrder.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvSalesOrder.AllowUserToResizeRows = false;
		dgvSalesOrder.DefaultCellStyle.Font = new Font("Segoe UI", 8f, FontStyle.Regular);
		dgvDeliveryOrder.Columns.Clear();
		dgvDeliveryOrder.Columns.Add("", "doId");
		dgvDeliveryOrder.Columns.Add("", "Tanggal");
		dgvDeliveryOrder.Columns.Add("", "Nomer");
		dgvDeliveryOrder.Columns.Add("", "Customer");
		dgvDeliveryOrder.Columns.Add("", "Gudang");
		dgvDeliveryOrder.Columns.Add("", "Barang");
		dgvDeliveryOrder.Columns.Add("", "Jumlah");
		dgvDeliveryOrder.Columns[0].Visible = false;
		dgvDeliveryOrder.Columns[1].Width = 70;
		dgvDeliveryOrder.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvDeliveryOrder.Columns[2].Width = 110;
		dgvDeliveryOrder.Columns[3].Visible = false;
		dgvDeliveryOrder.Columns[4].Width = 120;
		dgvDeliveryOrder.Columns[5].Width = 80;
		dgvDeliveryOrder.Columns[6].Width = 80;
		dgvDeliveryOrder.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvDeliveryOrder.RowHeadersVisible = false;
		dgvDeliveryOrder.AllowUserToAddRows = false;
		dgvDeliveryOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvDeliveryOrder.ReadOnly = true;
		dgvDeliveryOrder.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvDeliveryOrder.AllowUserToResizeRows = false;
		dgvDeliveryOrder.DefaultCellStyle.Font = new Font("Segoe UI", 8f, FontStyle.Regular);
		dgvInvoice.Columns.Clear();
		dgvInvoice.Columns.Add("", "invId");
		dgvInvoice.Columns.Add("", "No Faktur");
		dgvInvoice.Columns.Add("", "Tgl. Penj.");
		dgvInvoice.Columns.Add("", "Kode");
		dgvInvoice.Columns.Add("", "Ttl. Penj.");
		dgvInvoice.Columns.Add("", "Potongan");
		dgvInvoice.Columns.Add("", "Ttl. Pemb.");
		dgvInvoice.Columns.Add("", "Ttl. Piutang");
		dgvInvoice.Columns.Add("", "Umur Piutang");
		dgvInvoice.Columns[0].Visible = false;
		dgvInvoice.Columns[1].Width = 100;
		dgvInvoice.Columns[2].Width = 65;
		dgvInvoice.Columns[3].Width = 45;
		dgvInvoice.Columns[4].Width = 75;
		dgvInvoice.Columns[5].Width = 75;
		dgvInvoice.Columns[6].Width = 75;
		dgvInvoice.Columns[7].Width = 75;
		dgvInvoice.Columns[8].Width = 50;
		dgvInvoice.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvInvoice.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvInvoice.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvInvoice.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvInvoice.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvInvoice.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvInvoice.RowHeadersVisible = false;
		dgvInvoice.AllowUserToAddRows = false;
		dgvInvoice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvInvoice.ReadOnly = true;
		dgvInvoice.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvInvoice.AllowUserToResizeRows = false;
		dgvInvoice.DefaultCellStyle.Font = new Font("Segoe UI", 8f, FontStyle.Regular);
		dgvReturn.Columns.Clear();
		dgvReturn.Columns.Add("", "invId");
		dgvReturn.Columns.Add("", "No Faktur");
		dgvReturn.Columns.Add("", "Tgl. Penj.");
		dgvReturn.Columns.Add("", "Kode");
		dgvReturn.Columns.Add("", "Ttl. Retur");
		dgvReturn.Columns.Add("", "Potongan");
		dgvReturn.Columns.Add("", "Ttl. Pemb.");
		dgvReturn.Columns.Add("", "Ttl. Hutang");
		dgvReturn.Columns.Add("", "Umur Hutang");
		dgvReturn.Columns[0].Visible = false;
		dgvReturn.Columns[1].Width = 100;
		dgvReturn.Columns[2].Width = 65;
		dgvReturn.Columns[3].Width = 45;
		dgvReturn.Columns[4].Width = 75;
		dgvReturn.Columns[5].Width = 55;
		dgvReturn.Columns[6].Width = 75;
		dgvReturn.Columns[7].Width = 75;
		dgvReturn.Columns[8].Width = 50;
		dgvReturn.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvReturn.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvReturn.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvReturn.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvReturn.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvReturn.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvReturn.RowHeadersVisible = false;
		dgvReturn.AllowUserToAddRows = false;
		dgvReturn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvReturn.ReadOnly = true;
		dgvReturn.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvReturn.AllowUserToResizeRows = false;
		dgvReturn.DefaultCellStyle.Font = new Font("Segoe UI", 8f, FontStyle.Regular);
		dgvPayment.Columns.Clear();
		dgvPayment.Columns.Add("", "penjId");
		dgvPayment.Columns.Add("", "pbgId");
		dgvPayment.Columns.Add("", "Tanggal");
		dgvPayment.Columns.Add("", "Customer");
		dgvPayment.Columns.Add("", "Tipe");
		dgvPayment.Columns.Add("", "Penagih");
		dgvPayment.Columns.Add("", "Jumlah");
		dgvPayment.Columns.Add("", "Sisa");
		dgvPayment.Columns[0].Visible = false;
		dgvPayment.Columns[1].Visible = false;
		dgvPayment.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvPayment.Columns[2].Width = 70;
		dgvPayment.Columns[3].Visible = false;
		dgvPayment.Columns[4].Width = 50;
		dgvPayment.Columns[5].Width = 120;
		dgvPayment.Columns[6].Width = 85;
		dgvPayment.Columns[7].Width = 85;
		dgvPayment.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvPayment.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvPayment.RowHeadersVisible = false;
		dgvPayment.AllowUserToAddRows = false;
		dgvPayment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvPayment.ReadOnly = true;
		dgvPayment.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvPayment.AllowUserToResizeRows = false;
		dgvPayment.DefaultCellStyle.Font = new Font("Segoe UI", 8f, FontStyle.Regular);
		dgvReturnPayment.Columns.Clear();
		dgvReturnPayment.Columns.Add("", "penjId");
		dgvReturnPayment.Columns.Add("", "pbgId");
		dgvReturnPayment.Columns.Add("", "Tanggal");
		dgvReturnPayment.Columns.Add("", "Customer");
		dgvReturnPayment.Columns.Add("", "Tipe");
		dgvReturnPayment.Columns.Add("", "Penagih");
		dgvReturnPayment.Columns.Add("", "Jumlah");
		dgvReturnPayment.Columns.Add("", "Sisa");
		dgvReturnPayment.Columns[0].Visible = false;
		dgvReturnPayment.Columns[1].Visible = false;
		dgvReturnPayment.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvReturnPayment.Columns[2].Width = 70;
		dgvReturnPayment.Columns[3].Visible = false;
		dgvReturnPayment.Columns[4].Width = 50;
		dgvReturnPayment.Columns[5].Width = 120;
		dgvReturnPayment.Columns[6].Width = 85;
		dgvReturnPayment.Columns[7].Width = 85;
		dgvReturnPayment.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvReturnPayment.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvReturnPayment.RowHeadersVisible = false;
		dgvReturnPayment.AllowUserToAddRows = false;
		dgvReturnPayment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvReturnPayment.ReadOnly = true;
		dgvReturnPayment.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvReturnPayment.AllowUserToResizeRows = false;
		dgvReturnPayment.DefaultCellStyle.Font = new Font("Segoe UI", 8f, FontStyle.Regular);
		dgvSalesReceipt.Columns.Clear();
		dgvSalesReceipt.Columns.Add("", "kuiId");
		dgvSalesReceipt.Columns.Add("", "custId");
		dgvSalesReceipt.Columns.Add("", "Tanggal");
		dgvSalesReceipt.Columns.Add("", "No Kuitansi");
		dgvSalesReceipt.Columns.Add("", "Customer");
		dgvSalesReceipt.Columns.Add("", "Jumlah");
		dgvSalesReceipt.Columns.Add("", "Meterai");
		dgvSalesReceipt.Columns[0].Visible = false;
		dgvSalesReceipt.Columns[1].Visible = false;
		dgvSalesReceipt.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvSalesReceipt.Columns[2].Width = 70;
		dgvSalesReceipt.Columns[3].Width = 100;
		dgvSalesReceipt.Columns[4].Visible = false;
		dgvSalesReceipt.Columns[5].Width = 70;
		dgvSalesReceipt.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvSalesReceipt.Columns[6].Width = 60;
		dgvSalesReceipt.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvSalesReceipt.Columns[6].DefaultCellStyle.Format = "N0";
		dgvSalesReceipt.RowHeadersVisible = false;
		dgvSalesReceipt.AllowUserToAddRows = false;
		dgvSalesReceipt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvSalesReceipt.ReadOnly = true;
		dgvSalesReceipt.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvSalesReceipt.AllowUserToResizeRows = false;
		dgvSalesReceipt.DefaultCellStyle.Font = new Font("Segoe UI", 8f, FontStyle.Regular);
	}

	private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (TabControl1.SelectedIndex == 1)
		{
			if (dgvSalesOrder.Rows.Count > 0)
			{
				dgvSalesOrder.CurrentRow.Selected = false;
			}
		}
		else if (TabControl1.SelectedIndex == 2)
		{
			if (dgvDeliveryOrder.Rows.Count > 0)
			{
				dgvDeliveryOrder.CurrentRow.Selected = false;
			}
		}
		else if (TabControl1.SelectedIndex == 3)
		{
			if (_loadInvoice)
			{
				Cursor = Cursors.WaitCursor;
				GetInvoice();
				Cursor = Cursors.Default;
				_loadInvoice = false;
			}
			if (dgvInvoice.Rows.Count > 0)
			{
				dgvInvoice.CurrentRow.Selected = false;
			}
		}
		else if (TabControl1.SelectedIndex == 4)
		{
			if (_loadReturn)
			{
				Cursor = Cursors.WaitCursor;
				GetReturn();
				Cursor = Cursors.Default;
				_loadReturn = false;
			}
			if (dgvReturn.Rows.Count > 0)
			{
				dgvReturn.CurrentRow.Selected = false;
			}
		}
		else if (TabControl1.SelectedIndex == 5)
		{
			if (_loadPayment)
			{
				Cursor = Cursors.WaitCursor;
				GetPayment();
				Cursor = Cursors.Default;
				_loadPayment = false;
			}
			if (dgvPayment.Rows.Count > 0)
			{
				dgvPayment.CurrentRow.Selected = false;
			}
		}
		else if (TabControl1.SelectedIndex == 6)
		{
			if (_loadReturnPayment)
			{
				Cursor = Cursors.WaitCursor;
				GetReturnPayment();
				Cursor = Cursors.Default;
				_loadReturnPayment = false;
			}
			if (dgvReturnPayment.Rows.Count > 0)
			{
				dgvReturnPayment.CurrentRow.Selected = false;
			}
		}
		else if (TabControl1.SelectedIndex == 7 && dgvSalesReceipt.Rows.Count > 0)
		{
			dgvSalesReceipt.CurrentRow.Selected = false;
		}
	}

	public void GetSalesOrder()
	{
		DataTable dataTable = new DataTable();
		dgvSalesOrder.Rows.Clear();
		dataTable = cSalesOrder.Search(4, DateAndTime.Now, DateAndTime.Now, _currentId, Module1.pubGroupId, 0, 0.0);
		foreach (DataRow row in dataTable.Rows)
		{
			dgvSalesOrder.Rows.Add(row["soId"], row["soDate"], row["soExpiredDate"], row["poNumber"], row["custName"], Module1.formatCustomDecimal(Conversions.ToString(Operators.SubtractObject(row["soTotalPrice"], row["soDiscount"])), 2), Interaction.IIf(Operators.ConditionalCompareObjectGreater(row["penjDate"], DateTime.MinValue, TextCompare: false), RuntimeHelpers.GetObjectValue(row["penjDate"]), ""), row["penjFaktur"]);
		}
	}

	public void GetDeliveryOrder()
	{
		DataTable dataTable = new DataTable();
		dgvDeliveryOrder.Rows.Clear();
		dataTable = cDeliveryOrder.Search(3, DateAndTime.Now, DateAndTime.Now, _currentId, 0, Module1.pubGroupId, 0, 0.0, 0, 0);
		foreach (DataRow row in dataTable.Rows)
		{
			dgvDeliveryOrder.Rows.Add(row["doId"], row["doDate"], row["doNumber"], row["custName"], row["storeName"], row["itemName"], Module1.formatCustomDecimal(Conversions.ToString(row["doQty"]), 3));
		}
	}

	public void GetInvoice()
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
					dgvInvoice.Rows.Clear();
					if (!BackgroundWorkerSalesInvoice.IsBusy)
					{
						BackgroundWorkerSalesInvoice.RunWorkerAsync();
					}
					goto end_IL_0001;
				case 102:
					num = -1;
					switch (num2)
					{
					case 2:
						Cursor = Cursors.Default;
						Module1.SaveError(Information.Err(), "frmCustomer", "GetInvoice", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 102;
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

	private void BackgroundWorkerSalesInvoice_DoWork(object sender, DoWorkEventArgs e)
	{
		DataTable dataTable = cSalesInvoice.Search(99, DateAndTime.Now, DateAndTime.Now, 0, 0, 0, 0, Conversions.ToString(0), _currentId, 0.0, 99, 0, 99, 99, 0, 0, Module1.pubGroupId, "DESC");
		_unpaidMoreThanTop = 0;
		foreach (DataRow row in dataTable.Rows)
		{
			BackgroundWorkerSalesInvoice.ReportProgress(1, row);
		}
	}

	private void BackgroundWorkerSalesInvoice_ProgressChanged(object sender, ProgressChangedEventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		DataRow dataRow = default(DataRow);
		double num5 = default(double);
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
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_000b;
					case 530:
						{
							num2 = num;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_000b;
							case 3:
								goto IL_0019;
							case 4:
								goto IL_003d;
							case 5:
								goto IL_00f8;
							case 6:
								goto IL_011a;
							case 7:
								goto IL_0152;
							case 8:
								goto IL_0181;
							case 10:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 9:
							case 11:
							case 12:
							case 13:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_011a:
						num = 6;
						if (!((double)DateAndTime.DateDiff(DateInterval.Day, Conversions.ToDate(dataRow["penjDate"]), DateAndTime.Now) > Conversion.Val(txtTOP.Text)))
						{
							break;
						}
						goto IL_0152;
						IL_0152:
						num = 7;
						dgvInvoice.Rows[dgvInvoice.RowCount - 1].DefaultCellStyle.BackColor = Color.Red;
						goto IL_0181;
						IL_00f8:
						num = 5;
						if (!Operators.ConditionalCompareObjectGreater(dataRow["penjReceivable"], 0, TextCompare: false))
						{
							goto end_IL_0001_3;
						}
						goto IL_011a;
						IL_0181:
						num = 8;
						_unpaidMoreThanTop++;
						goto end_IL_0001_3;
						IL_000b:
						num = 2;
						dataRow = (DataRow)e.UserState;
						goto IL_0019;
						IL_0019:
						num = 3;
						num5 = Conversions.ToDouble(Operators.SubtractObject(dataRow["penjTotal"], dataRow["penjDisc"]));
						goto IL_003d;
						IL_003d:
						num = 4;
						dgvInvoice.Rows.Add(dataRow["penjId"], dataRow["penjFaktur"], dataRow["penjDate"], dataRow["penjKode"], Module1.formatCustomDecimal(Conversions.ToString(num5), 2), Module1.formatCustomDecimal(Conversions.ToString(dataRow["penjPot"]), 2), Module1.formatCustomDecimal(Conversions.ToString(dataRow["penjBayar"]), 2), Module1.formatCustomDecimal(Conversions.ToString(dataRow["penjReceivable"]), 2), dataRow["penjReceivableDays"]);
						goto IL_00f8;
						end_IL_0001_2:
						break;
					}
					num = 10;
					dgvInvoice.Rows[dgvInvoice.RowCount - 1].DefaultCellStyle.ForeColor = Color.Red;
					break;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 530;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void BackgroundWorkerSalesInvoice_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		double[] array = cSalesInvoice.arrChequeNotDue(_currentId);
		checked
		{
			int num = default(int);
			if (!Information.IsNothing(array))
			{
				num = array.Count();
				int i = 1;
				int num2 = array.Length - 1;
				for (int j = 0; j <= num2; j++)
				{
					for (bool flag = false; !flag & (i < dgvInvoice.Rows.Count - 1); i++)
					{
						if (Operators.ConditionalCompareObjectEqual(dgvInvoice[0, i].Value, array[j], TextCompare: false))
						{
							dgvInvoice.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
							flag = true;
						}
					}
				}
			}
			int num3 = cSalesInvoice.TotalUnpaidInvoice(_currentId);
			lblChequeLaterThanTOP.Text = "Faktur dibayar dengan Cek/Giro yang melebihi Term of Payment = " + Conversions.ToString(num);
			lblUnpaid.Text = "Faktur Piutang = " + Conversions.ToString(num3 - num);
			lblUnpaidMoreThanTOP.Text = "Faktur Piutang yang melebihi Term of Payment = " + Conversions.ToString(_unpaidMoreThanTop);
		}
	}

	public void GetReturn()
	{
		DataTable dataTable = cSalesInvoice.Search(99, DateAndTime.Now, DateAndTime.Now, 0, 0, 0, 0, Conversions.ToString(0), _currentId, 0.0, 99, 1, 99, 99, 0, 0, Module1.pubGroupId, "DESC");
		dgvReturn.Rows.Clear();
		foreach (DataRow row in dataTable.Rows)
		{
			double num = Conversions.ToDouble(Operators.SubtractObject(row["penjBs"], Operators.MultiplyObject(row["penjDisc"], -1)));
			dgvReturn.Rows.Add(row["penjId"], row["penjFaktur"], row["penjDate"], row["penjKode"], Module1.formatCustomDecimal(Conversions.ToString(num), 2), Module1.formatCustomDecimal(Conversions.ToString(Operators.MultiplyObject(row["penjPot"], -1)), 2), Module1.formatCustomDecimal(Conversions.ToString(Operators.MultiplyObject(row["penjBayar"], -1)), 2), Module1.formatCustomDecimal(Conversions.ToString(Operators.MultiplyObject(row["penjReceivable"], -1)), 2), row["penjReceivableDays"]);
		}
	}

	public void GetPayment()
	{
		DataTable dataTable = new DataTable();
		dataTable = cSalesInvoicePayment.Search(3, DateAndTime.Now, DateAndTime.Now, _currentId, 0, 0, 0, 0, 0, Module1.pubGroupId);
		dgvPayment.Rows.Clear();
		foreach (DataRow row in dataTable.Rows)
		{
			dgvPayment.Rows.Add(row["penjId"], row["pbgId"], row["paymentDate"], row["custName"], row["pkName"], row["salesName"], Module1.formatCustomDecimal(Conversions.ToString(row["paymentAmount"]), 2), Module1.formatCustomDecimal(Conversions.ToString(row["paymentRemainder"]), 2));
		}
	}

	public void GetReturnPayment()
	{
		DataTable dataTable = new DataTable();
		dataTable = cSalesInvoicePayment.Search(3, DateAndTime.Now, DateAndTime.Now, _currentId, 0, 0, 1, 0, 0, Module1.pubGroupId);
		dgvReturnPayment.Rows.Clear();
		foreach (DataRow row in dataTable.Rows)
		{
			dgvReturnPayment.Rows.Add(row["penjId"], row["pbgId"], row["paymentDate"], row["custName"], row["pkName"], row["salesName"], Module1.formatCustomDecimal(Conversions.ToString(row["paymentAmount"]), 2), Module1.formatCustomDecimal(Conversions.ToString(row["paymentRemainder"]), 2));
		}
	}

	public void GetSalesReceipt()
	{
		DataTable dataTable = new DataTable();
		dgvSalesReceipt.Rows.Clear();
		dataTable = cSalesReceipt.Search(3, DateAndTime.Now, DateAndTime.Now, _currentId, 0, 0, Module1.pubGroupId);
		foreach (DataRow row in dataTable.Rows)
		{
			string text = Conversions.ToString(cSalesReceipt.FormatSalesReceiptNumber(Module1.pubSalesReceiptCode, Conversions.ToInteger(row["kuiNo"]), DateAndTime.Month(Conversions.ToDate(row["kuiDate"])), DateAndTime.Year(Conversions.ToDate(row["kuiDate"]))));
			dgvSalesReceipt.Rows.Add(row["kuiId"], row["custId"], row["kuiDate"], text, Operators.ConcatenateObject(row["custName"], Interaction.IIf(Operators.ConditionalCompareObjectNotEqual(row["custPT"], "", TextCompare: false), Operators.ConcatenateObject(Operators.ConcatenateObject(" (", row["custPT"]), ")"), "")), Module1.formatCustomDecimal(Conversions.ToString(row["kuiAmount"]), 2), row["meterai"]);
		}
	}

	private void dgvSalesOrder_DoubleClick(object sender, EventArgs e)
	{
		OpenSalesOrder();
	}

	private void dgvSalesOrder_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			OpenSalesOrder();
			e.SuppressKeyPress = true;
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			TabControl1.Focus();
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			TabControl1.Focus();
			e.SuppressKeyPress = true;
		}
	}

	private void dgvSalesOrder_GotFocus(object sender, EventArgs e)
	{
		dgvSalesOrder.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
		dgvSalesOrder.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
		if (dgvSalesOrder.RowCount > 0)
		{
			dgvSalesOrder.CurrentRow.Selected = true;
		}
		dgvSalesOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
	}

	private void dgvSalesOrder_LostFocus(object sender, EventArgs e)
	{
		if (dgvSalesOrder.RowCount > 0)
		{
			dgvSalesOrder.CurrentRow.Selected = false;
		}
	}

	private void OpenSalesOrder()
	{
		if (dgvSalesOrder.RowCount > 0 && Conversion.Val(RuntimeHelpers.GetObjectValue(dgvSalesOrder[0, dgvSalesOrder.CurrentRow.Index].Value)) > 0.0)
		{
			MyProject.Forms.frmSalesOrder.Show();
			MyProject.Forms.frmSalesOrder.prepareForm(SaveNew: false);
			MyProject.Forms.frmSalesOrder.CurrentId = Conversions.ToDouble(dgvSalesOrder[0, dgvSalesOrder.CurrentRow.Index].Value);
			MyProject.Forms.frmSalesOrder.loadData();
			MyProject.Forms.frmSalesOrder.Activate();
			MyProject.Forms.frmSalesOrder.WindowState = FormWindowState.Normal;
		}
	}

	private void dgvDeliveryOrder_DoubleClick(object sender, EventArgs e)
	{
		OpenDeliveryOrder();
	}

	private void dgvDeliveryOrder_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			OpenDeliveryOrder();
			e.SuppressKeyPress = true;
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			TabControl1.Focus();
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			TabControl1.Focus();
			e.SuppressKeyPress = true;
		}
	}

	private void dgvDeliveryOrder_GotFocus(object sender, EventArgs e)
	{
		dgvDeliveryOrder.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
		dgvDeliveryOrder.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
		if (dgvDeliveryOrder.RowCount > 0)
		{
			dgvDeliveryOrder.CurrentRow.Selected = true;
		}
		dgvDeliveryOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
	}

	private void dgvDeliveryOrder_LostFocus(object sender, EventArgs e)
	{
		if (dgvDeliveryOrder.RowCount > 0)
		{
			dgvDeliveryOrder.CurrentRow.Selected = false;
		}
	}

	private void OpenDeliveryOrder()
	{
		if (dgvDeliveryOrder.RowCount > 0 && Conversion.Val(RuntimeHelpers.GetObjectValue(dgvDeliveryOrder[0, dgvDeliveryOrder.CurrentRow.Index].Value)) > 0.0)
		{
			MyProject.Forms.frmDeliveryOrder.Show();
			MyProject.Forms.frmDeliveryOrder.prepareForm(SaveNew: false);
			MyProject.Forms.frmDeliveryOrder.CurrentId = Conversions.ToDouble(dgvDeliveryOrder[0, dgvDeliveryOrder.CurrentRow.Index].Value);
			MyProject.Forms.frmDeliveryOrder.loadData();
			MyProject.Forms.frmDeliveryOrder.Activate();
			MyProject.Forms.frmDeliveryOrder.WindowState = FormWindowState.Normal;
		}
	}

	private void dgvInvoice_DoubleClick(object sender, EventArgs e)
	{
		OpenInvoice();
	}

	private void dgvInvoice_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			OpenInvoice();
			e.SuppressKeyPress = true;
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			TabControl1.Focus();
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			TabControl1.Focus();
			e.SuppressKeyPress = true;
		}
	}

	private void dgvInvoice_GotFocus(object sender, EventArgs e)
	{
		dgvInvoice.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
		dgvInvoice.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
		if (dgvInvoice.RowCount > 0)
		{
			dgvInvoice.CurrentRow.Selected = true;
		}
		dgvInvoice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
	}

	private void dgvInvoice_LostFocus(object sender, EventArgs e)
	{
		if (dgvInvoice.RowCount > 0)
		{
			dgvInvoice.CurrentRow.Selected = false;
		}
	}

	private void OpenInvoice()
	{
		if (dgvInvoice.RowCount > 0 && Conversion.Val(RuntimeHelpers.GetObjectValue(dgvInvoice[0, dgvInvoice.CurrentRow.Index].Value)) > 0.0)
		{
			MyProject.Forms.frmSalesInvoice.Show();
			MyProject.Forms.frmSalesInvoice.prepareForm(SaveNew: false);
			MyProject.Forms.frmSalesInvoice.CurrentId = Conversions.ToDouble(dgvInvoice[0, dgvInvoice.CurrentRow.Index].Value);
			MyProject.Forms.frmSalesInvoice.LoadData();
			MyProject.Forms.frmSalesInvoice.Activate();
			MyProject.Forms.frmSalesInvoice.WindowState = FormWindowState.Normal;
		}
	}

	private void dgvReturn_DoubleClick(object sender, EventArgs e)
	{
		OpenReturn();
	}

	private void dgvReturn_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			OpenReturn();
			e.SuppressKeyPress = true;
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			TabControl1.Focus();
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			TabControl1.Focus();
			e.SuppressKeyPress = true;
		}
	}

	private void dgvReturn_GotFocus(object sender, EventArgs e)
	{
		dgvReturn.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
		dgvReturn.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
		if (dgvReturn.RowCount > 0)
		{
			dgvReturn.CurrentRow.Selected = true;
		}
		dgvReturn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
	}

	private void dgvReturn_LostFocus(object sender, EventArgs e)
	{
		if (dgvReturn.RowCount > 0)
		{
			dgvReturn.CurrentRow.Selected = false;
		}
	}

	private void OpenReturn()
	{
		if (dgvReturn.RowCount > 0 && Conversion.Val(RuntimeHelpers.GetObjectValue(dgvReturn[0, dgvReturn.CurrentRow.Index].Value)) > 0.0)
		{
			MyProject.Forms.frmSalesReturn.Show();
			MyProject.Forms.frmSalesReturn.prepareForm(SaveNew: false);
			MyProject.Forms.frmSalesReturn.CurrentId = Conversions.ToDouble(dgvReturn[0, dgvReturn.CurrentRow.Index].Value);
			MyProject.Forms.frmSalesReturn.LoadData();
			MyProject.Forms.frmSalesReturn.Activate();
			MyProject.Forms.frmSalesReturn.WindowState = FormWindowState.Normal;
		}
	}

	private void dgvPayment_DoubleClick(object sender, EventArgs e)
	{
		OpenPayment();
	}

	private void dgvPayment_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			OpenPayment();
			e.SuppressKeyPress = true;
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			TabControl1.Focus();
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			TabControl1.Focus();
			e.SuppressKeyPress = true;
		}
	}

	private void dgvPayment_GotFocus(object sender, EventArgs e)
	{
		dgvPayment.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
		dgvPayment.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
		if (dgvPayment.RowCount > 0)
		{
			dgvPayment.CurrentRow.Selected = true;
		}
		dgvPayment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
	}

	private void dgvPayment_LostFocus(object sender, EventArgs e)
	{
		if (dgvPayment.RowCount > 0)
		{
			dgvPayment.CurrentRow.Selected = false;
		}
	}

	private void OpenPayment()
	{
		if (dgvPayment.RowCount > 0 && Conversion.Val(RuntimeHelpers.GetObjectValue(dgvPayment[1, dgvPayment.CurrentRow.Index].Value)) > 0.0)
		{
			MyProject.Forms.frmCustomerPayment.Show();
			MyProject.Forms.frmCustomerPayment.PrepareForm(SaveNew: false);
			MyProject.Forms.frmCustomerPayment.CurrentId = Conversions.ToDouble(dgvPayment[1, dgvPayment.CurrentRow.Index].Value);
			MyProject.Forms.frmCustomerPayment.LoadData();
			MyProject.Forms.frmCustomerPayment.Activate();
			MyProject.Forms.frmCustomerPayment.WindowState = FormWindowState.Normal;
		}
		else if (dgvPayment.RowCount > 0 && Conversion.Val(RuntimeHelpers.GetObjectValue(dgvPayment[0, dgvPayment.CurrentRow.Index].Value)) > 0.0)
		{
			MyProject.Forms.frmSalesInvoice.Show();
			MyProject.Forms.frmSalesInvoice.prepareForm(SaveNew: false);
			MyProject.Forms.frmSalesInvoice.CurrentId = Conversions.ToDouble(dgvPayment[0, dgvPayment.CurrentRow.Index].Value);
			MyProject.Forms.frmSalesInvoice.LoadData();
			MyProject.Forms.frmSalesInvoice.Activate();
			MyProject.Forms.frmSalesInvoice.WindowState = FormWindowState.Normal;
		}
	}

	private void dgvSalesReceipt_DoubleClick(object sender, EventArgs e)
	{
		OpenSalesReceipt();
	}

	private void dgvSalesReceipt_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			OpenSalesReceipt();
			e.SuppressKeyPress = true;
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			TabControl1.Focus();
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			TabControl1.Focus();
			e.SuppressKeyPress = true;
		}
	}

	private void dgvSalesReceipt_GotFocus(object sender, EventArgs e)
	{
		dgvSalesReceipt.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
		dgvSalesReceipt.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
		if (dgvSalesReceipt.RowCount > 0)
		{
			dgvSalesReceipt.CurrentRow.Selected = true;
		}
		dgvSalesReceipt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
	}

	private void dgvSalesReceipt_LostFocus(object sender, EventArgs e)
	{
		if (dgvSalesReceipt.RowCount > 0)
		{
			dgvSalesReceipt.CurrentRow.Selected = false;
		}
	}

	private void OpenSalesReceipt()
	{
		if (dgvSalesReceipt.RowCount > 0 && Conversion.Val(RuntimeHelpers.GetObjectValue(dgvSalesReceipt[0, dgvSalesReceipt.CurrentRow.Index].Value)) > 0.0)
		{
			MyProject.Forms.frmSalesReceipt.Show();
			MyProject.Forms.frmSalesReceipt.prepareForm(SaveNew: false);
			MyProject.Forms.frmSalesReceipt.CurrentId = Conversions.ToDouble(dgvSalesReceipt[0, dgvSalesReceipt.CurrentRow.Index].Value);
			MyProject.Forms.frmSalesReceipt.loadData();
			MyProject.Forms.frmSalesReceipt.Activate();
			MyProject.Forms.frmSalesReceipt.WindowState = FormWindowState.Normal;
		}
	}

	private void btnHistory_Click(object sender, EventArgs e)
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
					MyProject.Forms.frmHistory.GetHistory(checked((int)Math.Round(_currentId)), 8);
					MyProject.Forms.frmHistory.Show();
					MyProject.Forms.frmHistory.Activate();
					MyProject.Forms.frmHistory.WindowState = FormWindowState.Normal;
					goto end_IL_0001;
				case 119:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmCustomer", "btnHistory_Click", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 119;
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

	private void chkIsParent_CheckedChanged(object sender, EventArgs e)
	{
		if (chkIsParent.Checked)
		{
			cboGroupCustomer.SelectedIndex = 0;
			cboGroupCustomer.Enabled = false;
		}
		else
		{
			cboGroupCustomer.Enabled = true;
		}
	}

	private void btnSalesInvoice_Click(object sender, EventArgs e)
	{
		if (Module1.pubCreateSalesInvoice)
		{
			MyProject.Forms.frmSalesInvoice.Show();
			MyProject.Forms.frmSalesInvoice.prepareForm(SaveNew: false);
			MyProject.Forms.frmSalesInvoice.CustomerId = _currentId;
			MyProject.Forms.frmSalesInvoice.LoadCustomer();
			MyProject.Forms.frmSalesInvoice.Activate();
			MyProject.Forms.frmSalesInvoice.dtpInvoice.Focus();
		}
		else
		{
			Interaction.MsgBox("Anda tidak memiliki hak untuk membuat Faktur Penjualan.", MsgBoxStyle.Information);
		}
	}

	private void btnSalesReturn_Click(object sender, EventArgs e)
	{
		if (Module1.pubCreateSalesInvoice)
		{
			MyProject.Forms.frmSalesReturn.Show();
			MyProject.Forms.frmSalesReturn.prepareForm(SaveNew: false);
			MyProject.Forms.frmSalesReturn.CustomerId = _currentId;
			MyProject.Forms.frmSalesReturn.LoadCustomer();
			MyProject.Forms.frmSalesReturn.Activate();
			MyProject.Forms.frmSalesReturn.dtpInvoice.Focus();
		}
		else
		{
			Interaction.MsgBox("Anda tidak memiliki hak untuk membuat Retur Penjualan.", MsgBoxStyle.Information);
		}
	}

	private void btnDO_Click(object sender, EventArgs e)
	{
		MyProject.Forms.frmDeliveryOrder.Show();
		MyProject.Forms.frmDeliveryOrder.prepareForm(SaveNew: false);
		MyProject.Forms.frmDeliveryOrder.CustomerId = _currentId;
		MyProject.Forms.frmDeliveryOrder.LoadCustomer();
		MyProject.Forms.frmDeliveryOrder.Activate();
		MyProject.Forms.frmDeliveryOrder.dtpDO.Focus();
	}

	private void btnSO_Click(object sender, EventArgs e)
	{
		MyProject.Forms.frmSalesOrder.Show();
		MyProject.Forms.frmSalesOrder.prepareForm(SaveNew: false);
		MyProject.Forms.frmSalesOrder.CustomerId = _currentId;
		MyProject.Forms.frmSalesOrder.LoadCustomer();
		MyProject.Forms.frmSalesOrder.Activate();
		MyProject.Forms.frmSalesOrder.dtpSO.Focus();
	}

	private void btnSalesReceipt_Click(object sender, EventArgs e)
	{
		if (Module1.pubCreateSalesReceipt)
		{
			MyProject.Forms.frmSalesReceipt.Show();
			MyProject.Forms.frmSalesReceipt.prepareForm(SaveNew: false);
			MyProject.Forms.frmSalesReceipt.CustomerId = _currentId;
			MyProject.Forms.frmSalesReceipt.LoadCustomer();
			MyProject.Forms.frmSalesReceipt.Activate();
			MyProject.Forms.frmSalesReceipt.dtpReceipt.Focus();
		}
		else
		{
			Interaction.MsgBox("Anda tidak memiliki hak untuk membuat Kuitansi.", MsgBoxStyle.Information);
		}
	}

	private void btnPayment_Click(object sender, EventArgs e)
	{
		if (Module1.pubModifyPaymentInSalesInvoice)
		{
			MyProject.Forms.frmCustomerPayment.Show();
			MyProject.Forms.frmCustomerPayment.PrepareForm(SaveNew: false);
			MyProject.Forms.frmCustomerPayment.CustomerId = _currentId;
			MyProject.Forms.frmCustomerPayment.LoadCustomer();
			MyProject.Forms.frmCustomerPayment.Activate();
			MyProject.Forms.frmCustomerPayment.dtpPayment.Focus();
		}
		else
		{
			Interaction.MsgBox("Anda tidak memiliki hak untuk membuat Pembayaran.", MsgBoxStyle.Information);
		}
	}

	private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
	{
	}
}
