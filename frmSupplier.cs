using System;
using System.Collections;
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
public class frmSupplier : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TabControl1")]
	private TabControl _TabControl1;

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
	[AccessedThroughProperty("btnSave")]
	private Button _btnSave;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvInvoice")]
	private DataGridView _dgvInvoice;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboCurrency")]
	private ComboBox _cboCurrency;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvReturn")]
	private DataGridView _dgvReturn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvReceiveItem")]
	private DataGridView _dgvReceiveItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvPayment")]
	private DataGridView _dgvPayment;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvReturnPayment")]
	private DataGridView _dgvReturnPayment;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("chkIsParent")]
	private CheckBox _chkIsParent;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnReceiveItem")]
	private Button _btnReceiveItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnPurchaseInvoice")]
	private Button _btnPurchaseInvoice;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnPurchaseReturn")]
	private Button _btnPurchaseReturn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnPayment")]
	private Button _btnPayment;

	private double _currentId;

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

	[field: AccessedThroughProperty("TabPage7")]
	internal virtual TabPage TabPage7
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

	[field: AccessedThroughProperty("TabPage4")]
	internal virtual TabPage TabPage4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("A")]
	internal virtual TabPage A
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
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

	[field: AccessedThroughProperty("cboParentSupplier")]
	internal virtual ComboBox cboParentSupplier
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox cboCurrency
	{
		[CompilerGenerated]
		get
		{
			return _cboCurrency;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cboCurrency_SelectedIndexChanged;
			ComboBox comboBox = _cboCurrency;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_cboCurrency = value;
			comboBox = _cboCurrency;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label13")]
	internal virtual Label Label13
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

	[field: AccessedThroughProperty("lblInvoiceNote")]
	internal virtual Label lblInvoiceNote
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblReturnNote")]
	internal virtual Label lblReturnNote
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

	internal virtual DataGridView dgvReceiveItem
	{
		[CompilerGenerated]
		get
		{
			return _dgvReceiveItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = dgvReceiveItem_DoubleClick;
			KeyEventHandler value3 = dgvReceiveItem_KeyDown;
			EventHandler value4 = dgvReceiveItem_GotFocus;
			EventHandler value5 = dgvReceiveItem_LostFocus;
			DataGridView dataGridView = _dgvReceiveItem;
			if (dataGridView != null)
			{
				dataGridView.DoubleClick -= value2;
				dataGridView.KeyDown -= value3;
				dataGridView.GotFocus -= value4;
				dataGridView.LostFocus -= value5;
			}
			_dgvReceiveItem = value;
			dataGridView = _dgvReceiveItem;
			if (dataGridView != null)
			{
				dataGridView.DoubleClick += value2;
				dataGridView.KeyDown += value3;
				dataGridView.GotFocus += value4;
				dataGridView.LostFocus += value5;
			}
		}
	}

	[field: AccessedThroughProperty("lblPaymentNote")]
	internal virtual Label lblPaymentNote
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

	[field: AccessedThroughProperty("TabPage2")]
	internal virtual TabPage TabPage2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView dgvReturnPayment
	{
		[CompilerGenerated]
		get
		{
			return _dgvReturnPayment;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = dgvReturnPayment_DoubleClick;
			KeyEventHandler value3 = dgvReturnPayment_KeyDown;
			EventHandler value4 = dgvReturnPayment_GotFocus;
			EventHandler value5 = dgvReturnPayment_LostFocus;
			DataGridView dataGridView = _dgvReturnPayment;
			if (dataGridView != null)
			{
				dataGridView.DoubleClick -= value2;
				dataGridView.KeyDown -= value3;
				dataGridView.GotFocus -= value4;
				dataGridView.LostFocus -= value5;
			}
			_dgvReturnPayment = value;
			dataGridView = _dgvReturnPayment;
			if (dataGridView != null)
			{
				dataGridView.DoubleClick += value2;
				dataGridView.KeyDown += value3;
				dataGridView.GotFocus += value4;
				dataGridView.LostFocus += value5;
			}
		}
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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblMemberName")]
	internal virtual Label lblMemberName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnReceiveItem
	{
		[CompilerGenerated]
		get
		{
			return _btnReceiveItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnReceiveItem_Click;
			Button button = _btnReceiveItem;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnReceiveItem = value;
			button = _btnReceiveItem;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button btnPurchaseInvoice
	{
		[CompilerGenerated]
		get
		{
			return _btnPurchaseInvoice;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnPurchaseInvoice_Click;
			Button button = _btnPurchaseInvoice;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnPurchaseInvoice = value;
			button = _btnPurchaseInvoice;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button btnPurchaseReturn
	{
		[CompilerGenerated]
		get
		{
			return _btnPurchaseReturn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnPurchaseReturn_Click;
			Button button = _btnPurchaseReturn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnPurchaseReturn = value;
			button = _btnPurchaseReturn;
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

	[field: AccessedThroughProperty("lblReturnPaymentNote")]
	internal virtual Label lblReturnPaymentNote
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
		this.lblMemberName = new System.Windows.Forms.Label();
		this.chkIsParent = new System.Windows.Forms.CheckBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.cboCurrency = new System.Windows.Forms.ComboBox();
		this.Label13 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.cboParentSupplier = new System.Windows.Forms.ComboBox();
		this.txtNPWP = new System.Windows.Forms.TextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.btnSaveClose = new System.Windows.Forms.Button();
		this.btnHistory = new System.Windows.Forms.Button();
		this.btnSave = new System.Windows.Forms.Button();
		this.Label27 = new System.Windows.Forms.Label();
		this.Label14 = new System.Windows.Forms.Label();
		this.cboCashAccount = new System.Windows.Forms.ComboBox();
		this.Label26 = new System.Windows.Forms.Label();
		this.cboBankAccount = new System.Windows.Forms.ComboBox();
		this.Label9 = new System.Windows.Forms.Label();
		this.cboActive = new System.Windows.Forms.ComboBox();
		this.txtAddress = new System.Windows.Forms.TextBox();
		this.Label16 = new System.Windows.Forms.Label();
		this.txtName = new System.Windows.Forms.TextBox();
		this.Label17 = new System.Windows.Forms.Label();
		this.TabPage7 = new System.Windows.Forms.TabPage();
		this.btnReceiveItem = new System.Windows.Forms.Button();
		this.dgvReceiveItem = new System.Windows.Forms.DataGridView();
		this.tabInvoice = new System.Windows.Forms.TabPage();
		this.btnPurchaseInvoice = new System.Windows.Forms.Button();
		this.lblInvoiceNote = new System.Windows.Forms.Label();
		this.dgvInvoice = new System.Windows.Forms.DataGridView();
		this.TabPage4 = new System.Windows.Forms.TabPage();
		this.btnPurchaseReturn = new System.Windows.Forms.Button();
		this.lblReturnNote = new System.Windows.Forms.Label();
		this.dgvReturn = new System.Windows.Forms.DataGridView();
		this.A = new System.Windows.Forms.TabPage();
		this.btnPayment = new System.Windows.Forms.Button();
		this.lblPaymentNote = new System.Windows.Forms.Label();
		this.dgvPayment = new System.Windows.Forms.DataGridView();
		this.TabPage2 = new System.Windows.Forms.TabPage();
		this.dgvReturnPayment = new System.Windows.Forms.DataGridView();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.lblReturnPaymentNote = new System.Windows.Forms.Label();
		this.TabControl1.SuspendLayout();
		this.TabPage1.SuspendLayout();
		this.TabPage7.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvReceiveItem).BeginInit();
		this.tabInvoice.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvInvoice).BeginInit();
		this.TabPage4.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvReturn).BeginInit();
		this.A.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvPayment).BeginInit();
		this.TabPage2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvReturnPayment).BeginInit();
		base.SuspendLayout();
		this.TabControl1.Controls.Add(this.TabPage1);
		this.TabControl1.Controls.Add(this.TabPage7);
		this.TabControl1.Controls.Add(this.tabInvoice);
		this.TabControl1.Controls.Add(this.TabPage4);
		this.TabControl1.Controls.Add(this.A);
		this.TabControl1.Controls.Add(this.TabPage2);
		this.TabControl1.Location = new System.Drawing.Point(12, 12);
		this.TabControl1.Name = "TabControl1";
		this.TabControl1.SelectedIndex = 0;
		this.TabControl1.Size = new System.Drawing.Size(652, 459);
		this.TabControl1.TabIndex = 95;
		this.TabPage1.BackColor = System.Drawing.SystemColors.Control;
		this.TabPage1.Controls.Add(this.lblMemberName);
		this.TabPage1.Controls.Add(this.chkIsParent);
		this.TabPage1.Controls.Add(this.Label4);
		this.TabPage1.Controls.Add(this.Label2);
		this.TabPage1.Controls.Add(this.cboCurrency);
		this.TabPage1.Controls.Add(this.Label13);
		this.TabPage1.Controls.Add(this.Label3);
		this.TabPage1.Controls.Add(this.cboParentSupplier);
		this.TabPage1.Controls.Add(this.txtNPWP);
		this.TabPage1.Controls.Add(this.Label1);
		this.TabPage1.Controls.Add(this.btnSaveClose);
		this.TabPage1.Controls.Add(this.btnHistory);
		this.TabPage1.Controls.Add(this.btnSave);
		this.TabPage1.Controls.Add(this.Label27);
		this.TabPage1.Controls.Add(this.Label14);
		this.TabPage1.Controls.Add(this.cboCashAccount);
		this.TabPage1.Controls.Add(this.Label26);
		this.TabPage1.Controls.Add(this.cboBankAccount);
		this.TabPage1.Controls.Add(this.Label9);
		this.TabPage1.Controls.Add(this.cboActive);
		this.TabPage1.Controls.Add(this.txtAddress);
		this.TabPage1.Controls.Add(this.Label16);
		this.TabPage1.Controls.Add(this.txtName);
		this.TabPage1.Controls.Add(this.Label17);
		this.TabPage1.Location = new System.Drawing.Point(4, 22);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage1.Size = new System.Drawing.Size(644, 433);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = "Data";
		this.lblMemberName.BackColor = System.Drawing.SystemColors.ControlLight;
		this.lblMemberName.Location = new System.Drawing.Point(101, 116);
		this.lblMemberName.Name = "lblMemberName";
		this.lblMemberName.Size = new System.Drawing.Size(537, 47);
		this.lblMemberName.TabIndex = 140;
		this.lblMemberName.Text = "Anggota grup:";
		this.chkIsParent.AutoSize = true;
		this.chkIsParent.Location = new System.Drawing.Point(101, 94);
		this.chkIsParent.Name = "chkIsParent";
		this.chkIsParent.Size = new System.Drawing.Size(414, 17);
		this.chkIsParent.TabIndex = 14;
		this.chkIsParent.Text = "Grup (Jika dicentang, berarti Supplier merupakan kumpulan/grup dari Supplier lain)";
		this.chkIsParent.UseVisualStyleBackColor = true;
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(8, 95);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(28, 13);
		this.Label4.TabIndex = 139;
		this.Label4.Text = "Tipe";
		this.Label2.AutoSize = true;
		this.Label2.ForeColor = System.Drawing.Color.Red;
		this.Label2.Location = new System.Drawing.Point(8, 366);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(580, 13);
		this.Label2.TabIndex = 138;
		this.Label2.Text = "Catatan: Setelah membuat Supplier baru, anda harus menghubungkan Supplier dengan Grup di form \"Setting - Hak Grup\"";
		this.cboCurrency.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboCurrency.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboCurrency.FormattingEnabled = true;
		this.cboCurrency.Location = new System.Drawing.Point(101, 193);
		this.cboCurrency.Name = "cboCurrency";
		this.cboCurrency.Size = new System.Drawing.Size(152, 21);
		this.cboCurrency.TabIndex = 16;
		this.Label13.AutoSize = true;
		this.Label13.Location = new System.Drawing.Point(8, 196);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(73, 13);
		this.Label13.TabIndex = 137;
		this.Label13.Text = "Mata Uang (*)";
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(8, 169);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(80, 13);
		this.Label3.TabIndex = 135;
		this.Label3.Text = "Anggota dari (*)";
		this.cboParentSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboParentSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboParentSupplier.FormattingEnabled = true;
		this.cboParentSupplier.Location = new System.Drawing.Point(101, 166);
		this.cboParentSupplier.Name = "cboParentSupplier";
		this.cboParentSupplier.Size = new System.Drawing.Size(152, 21);
		this.cboParentSupplier.TabIndex = 15;
		this.txtNPWP.Location = new System.Drawing.Point(101, 68);
		this.txtNPWP.Name = "txtNPWP";
		this.txtNPWP.Size = new System.Drawing.Size(152, 20);
		this.txtNPWP.TabIndex = 13;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(8, 71);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(40, 13);
		this.Label1.TabIndex = 132;
		this.Label1.Text = "NPWP";
		this.btnSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSaveClose.Location = new System.Drawing.Point(489, 403);
		this.btnSaveClose.Name = "btnSaveClose";
		this.btnSaveClose.Size = new System.Drawing.Size(93, 24);
		this.btnSaveClose.TabIndex = 52;
		this.btnSaveClose.Text = "Simpan && &Tutup";
		this.btnSaveClose.UseVisualStyleBackColor = true;
		this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnHistory.Location = new System.Drawing.Point(588, 403);
		this.btnHistory.Name = "btnHistory";
		this.btnHistory.Size = new System.Drawing.Size(50, 24);
		this.btnHistory.TabIndex = 53;
		this.btnHistory.Text = "&History";
		this.btnHistory.UseVisualStyleBackColor = true;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(418, 403);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(65, 24);
		this.btnSave.TabIndex = 50;
		this.btnSave.Text = "&Simpan";
		this.btnSave.UseVisualStyleBackColor = true;
		this.Label27.BackColor = System.Drawing.Color.Silver;
		this.Label27.Location = new System.Drawing.Point(-63, 395);
		this.Label27.Name = "Label27";
		this.Label27.Size = new System.Drawing.Size(713, 39);
		this.Label27.TabIndex = 130;
		this.Label14.AutoSize = true;
		this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label14.Location = new System.Drawing.Point(8, 223);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(35, 13);
		this.Label14.TabIndex = 124;
		this.Label14.Text = "Kas(*)";
		this.cboCashAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboCashAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboCashAccount.FormattingEnabled = true;
		this.cboCashAccount.Location = new System.Drawing.Point(101, 220);
		this.cboCashAccount.Name = "cboCashAccount";
		this.cboCashAccount.Size = new System.Drawing.Size(124, 21);
		this.cboCashAccount.TabIndex = 17;
		this.Label26.AutoSize = true;
		this.Label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label26.Location = new System.Drawing.Point(8, 249);
		this.Label26.Name = "Label26";
		this.Label26.Size = new System.Drawing.Size(63, 13);
		this.Label26.TabIndex = 122;
		this.Label26.Text = "Rekening(*)";
		this.cboBankAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboBankAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboBankAccount.FormattingEnabled = true;
		this.cboBankAccount.Location = new System.Drawing.Point(101, 246);
		this.cboBankAccount.Name = "cboBankAccount";
		this.cboBankAccount.Size = new System.Drawing.Size(124, 21);
		this.cboBankAccount.TabIndex = 18;
		this.Label9.AutoSize = true;
		this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label9.Location = new System.Drawing.Point(8, 274);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(47, 13);
		this.Label9.TabIndex = 114;
		this.Label9.Text = "Status(*)";
		this.cboActive.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboActive.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboActive.FormattingEnabled = true;
		this.cboActive.Location = new System.Drawing.Point(101, 273);
		this.cboActive.Name = "cboActive";
		this.cboActive.Size = new System.Drawing.Size(124, 21);
		this.cboActive.TabIndex = 19;
		this.txtAddress.Location = new System.Drawing.Point(101, 42);
		this.txtAddress.Name = "txtAddress";
		this.txtAddress.Size = new System.Drawing.Size(152, 20);
		this.txtAddress.TabIndex = 12;
		this.Label16.AutoSize = true;
		this.Label16.Location = new System.Drawing.Point(8, 45);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(49, 13);
		this.Label16.TabIndex = 79;
		this.Label16.Text = "Alamat(*)";
		this.txtName.Location = new System.Drawing.Point(101, 16);
		this.txtName.Name = "txtName";
		this.txtName.Size = new System.Drawing.Size(152, 20);
		this.txtName.TabIndex = 11;
		this.Label17.AutoSize = true;
		this.Label17.Location = new System.Drawing.Point(8, 19);
		this.Label17.Name = "Label17";
		this.Label17.Size = new System.Drawing.Size(45, 13);
		this.Label17.TabIndex = 76;
		this.Label17.Text = "Nama(*)";
		this.TabPage7.Controls.Add(this.btnReceiveItem);
		this.TabPage7.Controls.Add(this.dgvReceiveItem);
		this.TabPage7.Location = new System.Drawing.Point(4, 22);
		this.TabPage7.Name = "TabPage7";
		this.TabPage7.Size = new System.Drawing.Size(644, 433);
		this.TabPage7.TabIndex = 6;
		this.TabPage7.Text = "Penerimaan Barang";
		this.TabPage7.UseVisualStyleBackColor = true;
		this.btnReceiveItem.BackColor = System.Drawing.Color.Gainsboro;
		this.btnReceiveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnReceiveItem.Location = new System.Drawing.Point(508, 397);
		this.btnReceiveItem.Name = "btnReceiveItem";
		this.btnReceiveItem.Size = new System.Drawing.Size(122, 26);
		this.btnReceiveItem.TabIndex = 11;
		this.btnReceiveItem.Text = "+ Penerimaan Barang";
		this.btnReceiveItem.UseVisualStyleBackColor = false;
		this.dgvReceiveItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvReceiveItem.Location = new System.Drawing.Point(13, 13);
		this.dgvReceiveItem.Name = "dgvReceiveItem";
		this.dgvReceiveItem.Size = new System.Drawing.Size(617, 378);
		this.dgvReceiveItem.TabIndex = 9;
		this.tabInvoice.Controls.Add(this.btnPurchaseInvoice);
		this.tabInvoice.Controls.Add(this.lblInvoiceNote);
		this.tabInvoice.Controls.Add(this.dgvInvoice);
		this.tabInvoice.Location = new System.Drawing.Point(4, 22);
		this.tabInvoice.Name = "tabInvoice";
		this.tabInvoice.Size = new System.Drawing.Size(644, 433);
		this.tabInvoice.TabIndex = 2;
		this.tabInvoice.Text = "Pembelian";
		this.tabInvoice.UseVisualStyleBackColor = true;
		this.btnPurchaseInvoice.BackColor = System.Drawing.Color.Gainsboro;
		this.btnPurchaseInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnPurchaseInvoice.Location = new System.Drawing.Point(555, 398);
		this.btnPurchaseInvoice.Name = "btnPurchaseInvoice";
		this.btnPurchaseInvoice.Size = new System.Drawing.Size(75, 26);
		this.btnPurchaseInvoice.TabIndex = 11;
		this.btnPurchaseInvoice.Text = "+ Pembelian";
		this.btnPurchaseInvoice.UseVisualStyleBackColor = false;
		this.lblInvoiceNote.AutoSize = true;
		this.lblInvoiceNote.Location = new System.Drawing.Point(10, 398);
		this.lblInvoiceNote.Name = "lblInvoiceNote";
		this.lblInvoiceNote.Size = new System.Drawing.Size(75, 13);
		this.lblInvoiceNote.TabIndex = 8;
		this.lblInvoiceNote.Text = "lblInvoiceNote";
		this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvInvoice.Location = new System.Drawing.Point(13, 13);
		this.dgvInvoice.Name = "dgvInvoice";
		this.dgvInvoice.Size = new System.Drawing.Size(617, 379);
		this.dgvInvoice.TabIndex = 7;
		this.TabPage4.Controls.Add(this.btnPurchaseReturn);
		this.TabPage4.Controls.Add(this.lblReturnNote);
		this.TabPage4.Controls.Add(this.dgvReturn);
		this.TabPage4.Location = new System.Drawing.Point(4, 22);
		this.TabPage4.Name = "TabPage4";
		this.TabPage4.Size = new System.Drawing.Size(644, 433);
		this.TabPage4.TabIndex = 3;
		this.TabPage4.Text = "Retur";
		this.TabPage4.UseVisualStyleBackColor = true;
		this.btnPurchaseReturn.BackColor = System.Drawing.Color.Gainsboro;
		this.btnPurchaseReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnPurchaseReturn.Location = new System.Drawing.Point(568, 398);
		this.btnPurchaseReturn.Name = "btnPurchaseReturn";
		this.btnPurchaseReturn.Size = new System.Drawing.Size(62, 26);
		this.btnPurchaseReturn.TabIndex = 11;
		this.btnPurchaseReturn.Text = "+ Retur";
		this.btnPurchaseReturn.UseVisualStyleBackColor = false;
		this.lblReturnNote.AutoSize = true;
		this.lblReturnNote.Location = new System.Drawing.Point(10, 398);
		this.lblReturnNote.Name = "lblReturnNote";
		this.lblReturnNote.Size = new System.Drawing.Size(72, 13);
		this.lblReturnNote.TabIndex = 10;
		this.lblReturnNote.Text = "lblReturnNote";
		this.dgvReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvReturn.Location = new System.Drawing.Point(13, 13);
		this.dgvReturn.Name = "dgvReturn";
		this.dgvReturn.Size = new System.Drawing.Size(617, 379);
		this.dgvReturn.TabIndex = 9;
		this.A.Controls.Add(this.btnPayment);
		this.A.Controls.Add(this.lblPaymentNote);
		this.A.Controls.Add(this.dgvPayment);
		this.A.Location = new System.Drawing.Point(4, 22);
		this.A.Name = "A";
		this.A.Size = new System.Drawing.Size(644, 433);
		this.A.TabIndex = 4;
		this.A.Text = "Pembayaran Faktur";
		this.A.UseVisualStyleBackColor = true;
		this.btnPayment.BackColor = System.Drawing.Color.Gainsboro;
		this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnPayment.Location = new System.Drawing.Point(541, 398);
		this.btnPayment.Name = "btnPayment";
		this.btnPayment.Size = new System.Drawing.Size(89, 26);
		this.btnPayment.TabIndex = 12;
		this.btnPayment.Text = "+ Pembayaran";
		this.btnPayment.UseVisualStyleBackColor = false;
		this.lblPaymentNote.AutoSize = true;
		this.lblPaymentNote.Location = new System.Drawing.Point(10, 398);
		this.lblPaymentNote.Name = "lblPaymentNote";
		this.lblPaymentNote.Size = new System.Drawing.Size(81, 13);
		this.lblPaymentNote.TabIndex = 11;
		this.lblPaymentNote.Text = "lblPaymentNote";
		this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvPayment.Location = new System.Drawing.Point(13, 13);
		this.dgvPayment.Name = "dgvPayment";
		this.dgvPayment.Size = new System.Drawing.Size(617, 379);
		this.dgvPayment.TabIndex = 8;
		this.TabPage2.Controls.Add(this.lblReturnPaymentNote);
		this.TabPage2.Controls.Add(this.dgvReturnPayment);
		this.TabPage2.Location = new System.Drawing.Point(4, 22);
		this.TabPage2.Name = "TabPage2";
		this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage2.Size = new System.Drawing.Size(644, 433);
		this.TabPage2.TabIndex = 7;
		this.TabPage2.Text = "Pembayaran Retur";
		this.TabPage2.UseVisualStyleBackColor = true;
		this.dgvReturnPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvReturnPayment.Location = new System.Drawing.Point(13, 13);
		this.dgvReturnPayment.Name = "dgvReturnPayment";
		this.dgvReturnPayment.Size = new System.Drawing.Size(617, 395);
		this.dgvReturnPayment.TabIndex = 9;
		this.TextBox1.Location = new System.Drawing.Point(101, 68);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(152, 20);
		this.TextBox1.TabIndex = 131;
		this.lblReturnPaymentNote.AutoSize = true;
		this.lblReturnPaymentNote.Location = new System.Drawing.Point(10, 411);
		this.lblReturnPaymentNote.Name = "lblReturnPaymentNote";
		this.lblReturnPaymentNote.Size = new System.Drawing.Size(113, 13);
		this.lblReturnPaymentNote.TabIndex = 12;
		this.lblReturnPaymentNote.Text = "lblReturnPaymentNote";
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(676, 478);
		base.Controls.Add(this.TabControl1);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSupplier";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Supplier";
		this.TabControl1.ResumeLayout(false);
		this.TabPage1.ResumeLayout(false);
		this.TabPage1.PerformLayout();
		this.TabPage7.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgvReceiveItem).EndInit();
		this.tabInvoice.ResumeLayout(false);
		this.tabInvoice.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvInvoice).EndInit();
		this.TabPage4.ResumeLayout(false);
		this.TabPage4.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvReturn).EndInit();
		this.A.ResumeLayout(false);
		this.A.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvPayment).EndInit();
		this.TabPage2.ResumeLayout(false);
		this.TabPage2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvReturnPayment).EndInit();
		base.ResumeLayout(false);
	}

	private void frmSupplier_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	public frmSupplier()
	{
		base.KeyDown += frmSupplier_KeyDown;
		InitializeComponent();
		DoubleBuffered = true;
		base.MdiParent = MyProject.Forms.frmMenu;
		ComboBox combo = cboParentSupplier;
		cCombo.getParentSupplier(ref combo, Module1.pubGroupId, All: false, Dash: true);
		cboParentSupplier = combo;
		combo = cboCurrency;
		cCombo.getCurrency(ref combo, All: false, 1);
		cboCurrency = combo;
		combo = cboActive;
		cCombo.getActive(ref combo, All: false);
		cboActive = combo;
		formatGrid();
	}

	private void cboCurrency_SelectedIndexChanged(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboCurrency.SelectedItem;
		ComboBox combo = cboCashAccount;
		cCombo.getCashAccount(ref combo, 0, Module1.pubGroupId, All: false, GroupDefault: true, Active: true, "GENERAL", Conversions.ToInteger(cComboItem2.Value));
		cboCashAccount = combo;
		combo = cboBankAccount;
		cCombo.getBankAccount(ref combo, 0, Module1.pubGroupId, All: false, GroupDefault: true, Active: true, "GENERAL", Conversions.ToInteger(cComboItem2.Value));
		cboBankAccount = combo;
	}

	public void prepareForm()
	{
		_currentId = 0.0;
		txtName.Text = "";
		txtAddress.Text = "";
		txtNPWP.Text = "";
		ComboBox cboSource = cboParentSupplier;
		Module1.comboBoundValue(ref cboSource, -1.0);
		cboParentSupplier = cboSource;
		cboSource = cboCurrency;
		Module1.comboBoundValue(ref cboSource, -1.0);
		cboCurrency = cboSource;
		cboSource = cboCashAccount;
		Module1.comboBoundValue(ref cboSource, -1.0);
		cboCashAccount = cboSource;
		cboSource = cboBankAccount;
		Module1.comboBoundValue(ref cboSource, -1.0);
		cboBankAccount = cboSource;
		cboActive.SelectedIndex = 0;
		btnHistory.Enabled = false;
		cboCurrency.Enabled = true;
		txtName.Focus();
		lblInvoiceNote.Text = "";
		lblReturnNote.Text = "";
		lblPaymentNote.Text = "";
		lblReturnPaymentNote.Text = "";
		chkIsParent.Checked = false;
	}

	private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (TabControl1.SelectedIndex == 1)
		{
			if (dgvReceiveItem.Rows.Count > 0)
			{
				dgvReceiveItem.CurrentRow.Selected = false;
			}
		}
		else if (TabControl1.SelectedIndex == 2)
		{
			if (dgvInvoice.Rows.Count > 0)
			{
				dgvInvoice.CurrentRow.Selected = false;
			}
		}
		else if (TabControl1.SelectedIndex == 3)
		{
			if (dgvReturn.Rows.Count > 0)
			{
				dgvReturn.CurrentRow.Selected = false;
			}
		}
		else if (TabControl1.SelectedIndex == 4)
		{
			if (dgvPayment.Rows.Count > 0)
			{
				dgvPayment.CurrentRow.Selected = false;
			}
		}
		else if (TabControl1.SelectedIndex == 5 && dgvReturnPayment.Rows.Count > 0)
		{
			dgvReturnPayment.CurrentRow.Selected = false;
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
						cSupplier cSupplier2 = new cSupplier((int)Math.Round(_currentId));
						txtName.Text = cSupplier2.Name;
						txtAddress.Text = cSupplier2.Address;
						txtNPWP.Text = cSupplier2.NPWP;
						ComboBox cboSource;
						if (cSupplier2.Id == cSupplier2.ParentId)
						{
							cboSource = cboParentSupplier;
							Module1.comboBoundValue(ref cboSource, 0.0);
							cboParentSupplier = cboSource;
						}
						else
						{
							cboSource = cboParentSupplier;
							Module1.comboBoundValue(ref cboSource, cSupplier2.ParentId);
							cboParentSupplier = cboSource;
						}
						if (cSupplier2.IsParent == 1)
						{
							chkIsParent.Checked = true;
							btnReceiveItem.Enabled = false;
							btnPurchaseInvoice.Enabled = false;
							btnPurchaseReturn.Enabled = false;
						}
						else
						{
							chkIsParent.Checked = false;
						}
						lblMemberName.Text = "Anggota grup: ";
						if (!Information.IsNothing(cSupplier2.MemberName))
						{
							int num3 = cSupplier2.MemberName.Count() - 1;
							for (int i = 0; i <= num3; i++)
							{
								if (i > 0)
								{
									lblMemberName.Text += ", ";
								}
								lblMemberName.Text += cSupplier2.MemberName[i];
							}
						}
						if (cSupplier2.IsParent == 0)
						{
							lblMemberName.Text = "Anggota grup: -";
						}
						cboSource = cboCurrency;
						Module1.comboBoundValue(ref cboSource, cSupplier2.CurrencyId);
						cboCurrency = cboSource;
						cboSource = cboCashAccount;
						Module1.comboBoundValue(ref cboSource, cSupplier2.CashAccountId);
						cboCashAccount = cboSource;
						cboSource = cboBankAccount;
						Module1.comboBoundValue(ref cboSource, cSupplier2.BankAccountId);
						cboBankAccount = cboSource;
						cboSource = cboActive;
						Module1.comboBoundValue(ref cboSource, cSupplier2.Active);
						cboActive = cboSource;
						cboCurrency.Enabled = false;
						txtName.SelectionLength = txtName.Text.Length;
						btnHistory.Enabled = true;
						formatGrid();
						GetReceiveItem();
						GetInvoice();
						GetReturn();
						GetPayment();
						GetReturnPayment();
						goto end_IL_0001;
					}
					case 697:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmSupplier", "loadData", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 697;
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
			cboParentSupplier.SelectedIndex = 0;
			cboParentSupplier.Enabled = false;
		}
		else
		{
			cboParentSupplier.Enabled = true;
		}
	}

	private void formatGrid()
	{
		dgvReceiveItem.Rows.Clear();
		dgvReceiveItem.Columns.Clear();
		dgvReceiveItem.Columns.Add("", "riId");
		dgvReceiveItem.Columns.Add("", "Tanggal");
		dgvReceiveItem.Columns.Add("", "Nomer");
		dgvReceiveItem.Columns.Add("", "Gudang");
		dgvReceiveItem.Columns.Add("", "Barang");
		dgvReceiveItem.Columns.Add("", "Jumlah");
		dgvReceiveItem.Columns[0].Visible = false;
		dgvReceiveItem.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvReceiveItem.Columns[1].Width = 70;
		dgvReceiveItem.Columns[2].Width = 110;
		dgvReceiveItem.Columns[3].Width = 120;
		dgvReceiveItem.Columns[4].Width = 80;
		dgvReceiveItem.Columns[5].Width = 80;
		dgvReceiveItem.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvReceiveItem.RowHeadersVisible = false;
		dgvReceiveItem.AllowUserToAddRows = false;
		dgvReceiveItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvReceiveItem.ReadOnly = true;
		dgvReceiveItem.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvReceiveItem.AllowUserToResizeRows = false;
		dgvReceiveItem.DefaultCellStyle.Font = new Font("Segoe UI", 8f, FontStyle.Regular);
		dgvInvoice.Columns.Clear();
		dgvInvoice.Rows.Clear();
		dgvInvoice.Columns.Add("", "invId");
		dgvInvoice.Columns.Add("", "Tanggal");
		dgvInvoice.Columns.Add("", "No Faktur");
		dgvInvoice.Columns.Add("", "Total Harga");
		dgvInvoice.Columns[0].Visible = false;
		dgvInvoice.Columns[0].Width = 0;
		dgvInvoice.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvInvoice.Columns[1].Width = 80;
		dgvInvoice.Columns[2].Width = 120;
		dgvInvoice.Columns[3].Width = 100;
		dgvInvoice.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvInvoice.RowHeadersVisible = false;
		dgvInvoice.AllowUserToAddRows = false;
		dgvInvoice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvInvoice.ReadOnly = true;
		dgvInvoice.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvInvoice.AllowUserToResizeRows = false;
		dgvInvoice.DefaultCellStyle.Font = new Font("Segoe UI", 8f, FontStyle.Regular);
		dgvReturn.Columns.Clear();
		dgvReturn.Rows.Clear();
		dgvReturn.Columns.Add("", "invId");
		dgvReturn.Columns.Add("", "Tanggal");
		dgvReturn.Columns.Add("", "No Faktur");
		dgvReturn.Columns.Add("", "Total Harga");
		dgvReturn.Columns[0].Visible = false;
		dgvReturn.Columns[0].Width = 0;
		dgvReturn.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvReturn.Columns[1].Width = 80;
		dgvReturn.Columns[2].Width = 120;
		dgvReturn.Columns[3].Width = 100;
		dgvReturn.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvReturn.RowHeadersVisible = false;
		dgvReturn.AllowUserToAddRows = false;
		dgvReturn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvReturn.ReadOnly = true;
		dgvReturn.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvReturn.AllowUserToResizeRows = false;
		dgvReturn.DefaultCellStyle.Font = new Font("Segoe UI", 8f, FontStyle.Regular);
		dgvPayment.Columns.Clear();
		dgvPayment.Rows.Clear();
		dgvPayment.Columns.Add("", "invId");
		dgvPayment.Columns.Add("", "mpayId");
		dgvPayment.Columns.Add("", "Tanggal");
		dgvPayment.Columns.Add("", "Tipe");
		dgvPayment.Columns.Add("", "Jumlah");
		dgvPayment.Columns.Add("", "Sisa");
		dgvPayment.Columns[0].Visible = false;
		dgvPayment.Columns[1].Visible = false;
		dgvPayment.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvPayment.Columns[2].Width = 80;
		dgvPayment.Columns[3].Width = 60;
		dgvPayment.Columns[4].Width = 100;
		dgvPayment.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvPayment.Columns[5].Width = 100;
		dgvPayment.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvPayment.RowHeadersVisible = false;
		dgvPayment.AllowUserToAddRows = false;
		dgvPayment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvPayment.ReadOnly = true;
		dgvPayment.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvPayment.AllowUserToResizeRows = false;
		dgvPayment.DefaultCellStyle.Font = new Font("Segoe UI", 8f, FontStyle.Regular);
		dgvReturnPayment.Columns.Clear();
		dgvReturnPayment.Rows.Clear();
		dgvReturnPayment.Columns.Add("", "invId");
		dgvReturnPayment.Columns.Add("", "mpayId");
		dgvReturnPayment.Columns.Add("", "Tanggal");
		dgvReturnPayment.Columns.Add("", "Tipe");
		dgvReturnPayment.Columns.Add("", "Jumlah");
		dgvReturnPayment.Columns.Add("", "Sisa");
		dgvReturnPayment.Columns[0].Visible = false;
		dgvReturnPayment.Columns[1].Visible = false;
		dgvReturnPayment.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvReturnPayment.Columns[2].Width = 80;
		dgvReturnPayment.Columns[3].Width = 60;
		dgvReturnPayment.Columns[4].Width = 100;
		dgvReturnPayment.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvReturnPayment.Columns[5].Visible = false;
		dgvReturnPayment.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvReturnPayment.RowHeadersVisible = false;
		dgvReturnPayment.AllowUserToAddRows = false;
		dgvReturnPayment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvReturnPayment.ReadOnly = true;
		dgvReturnPayment.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvReturnPayment.AllowUserToResizeRows = false;
		dgvReturnPayment.DefaultCellStyle.Font = new Font("Segoe UI", 8f, FontStyle.Regular);
	}

	public void GetReceiveItem()
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
					DataTable dataTable = new DataTable();
					dataTable = cReceivedItem.Search(4, DateAndTime.Now, DateAndTime.Now, checked((int)Math.Round(_currentId)), 0, Module1.pubGroupId, 0, 0.0, 0, 0, 0);
					formatGrid();
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						dgvReceiveItem.Rows.Add(dataRow["riId"], dataRow["riDate"], dataRow["riNumber"], dataRow["storeName"], dataRow["itemName"], Module1.formatCustomDecimal(Conversions.ToString(dataRow["riQty"]), 2));
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					goto end_IL_0001;
				}
				case 292:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSupplier", "GetReceiveItem", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 292;
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

	public void GetInvoice()
	{
		if (!Module1.pubViewReportPurchaseInvoicePrice)
		{
			lblInvoiceNote.Text = "(Hanya Faktur yang belum memiliki harga)";
		}
		DataTable dataTable = cPurchaseInvoice.Search(6, DateAndTime.Now, DateAndTime.Now, 0, checked((int)Math.Round(_currentId)), "", 99, 0, Module1.pubGroupId, 0, 99, 99, Module1.pubViewReportPurchaseInvoicePrice);
		foreach (DataRow row in dataTable.Rows)
		{
			dgvInvoice.Rows.Add(row["invId"], row["invDate"], row["invNumber"], Module1.formatCustomDecimal(Conversions.ToString(row["invTotal"]), 2));
		}
	}

	public void GetReturn()
	{
		if (!Module1.pubViewReportPurchaseInvoicePrice)
		{
			lblReturnNote.Text = "(Hanya Retur yang belum memiliki harga)";
		}
		DataTable dataTable = cPurchaseInvoice.Search(6, DateAndTime.Now, DateAndTime.Now, 0, checked((int)Math.Round(_currentId)), "", 99, 1, Module1.pubGroupId, 0, 99, 99, Module1.pubViewReportPurchaseInvoicePrice);
		foreach (DataRow row in dataTable.Rows)
		{
			dgvReturn.Rows.Add(row["invId"], row["invDate"], row["invNumber"], Module1.formatCustomDecimal(Conversions.ToString(row["invReturn"]), 2));
		}
	}

	public void GetPayment()
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
					if (!Module1.pubViewReportPurchaseInvoicePrice)
					{
						lblPaymentNote.Text = "Anda tidak bisa melihat Faktur yang telah memiliki harga.";
						goto end_IL_0001;
					}
					DataTable dataTable = new DataTable();
					dataTable = cPurchaseInvoiceMultiPayment.Search(3, DateAndTime.Now, DateAndTime.Now, checked((int)Math.Round(_currentId)), 0, 0, 0, Module1.pubGroupId, Module1.pubBranchId);
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						dgvPayment.Rows.Add(dataRow["invId"], dataRow["mpayId"], dataRow["payDate"], dataRow["pcName"], Module1.formatCustomDecimal(Conversions.ToString(dataRow["payAmount"]), 2), Module1.formatCustomDecimal(Conversions.ToString(dataRow["payRemain"]), 2));
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					goto end_IL_0001;
				}
				case 330:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSupplier", "GetPayment", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 330;
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

	public void GetReturnPayment()
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
					if (!Module1.pubViewReportPurchaseInvoicePrice)
					{
						lblReturnPaymentNote.Text = "Anda tidak bisa melihat Faktur yang telah memiliki harga.";
						goto end_IL_0001;
					}
					DataTable dataTable = new DataTable();
					dataTable = cPurchaseInvoiceMultiPayment.Search(3, DateAndTime.Now, DateAndTime.Now, checked((int)Math.Round(_currentId)), 0, 0, 1, Module1.pubGroupId, Module1.pubBranchId);
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						dgvReturnPayment.Rows.Add(dataRow["invId"], dataRow["mpayId"], dataRow["payDate"], dataRow["pcName"], Module1.formatCustomDecimal(Conversions.ToString(dataRow["payAmount"]), 2), Module1.formatCustomDecimal(Conversions.ToString(dataRow["payRemain"]), 2));
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					goto end_IL_0001;
				}
				case 330:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSupplier", "GetReturnPayment", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 330;
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

	private void dgvReceiveItem_DoubleClick(object sender, EventArgs e)
	{
		openReceiveItem();
	}

	private void dgvReceiveItem_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			openReceiveItem();
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

	private void dgvReceiveItem_GotFocus(object sender, EventArgs e)
	{
		dgvReceiveItem.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
		dgvReceiveItem.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
		if (dgvReceiveItem.RowCount > 0)
		{
			dgvReceiveItem.CurrentRow.Selected = true;
		}
		dgvReceiveItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
	}

	private void dgvReceiveItem_LostFocus(object sender, EventArgs e)
	{
		if (dgvReceiveItem.RowCount > 0)
		{
			dgvReceiveItem.CurrentRow.Selected = false;
		}
	}

	private void openReceiveItem()
	{
		if (dgvReceiveItem.RowCount > 0 && Conversion.Val(RuntimeHelpers.GetObjectValue(dgvReceiveItem[0, dgvReceiveItem.CurrentRow.Index].Value)) > 0.0)
		{
			MyProject.Forms.frmReceivedItem.Show();
			MyProject.Forms.frmReceivedItem.prepareForm(SaveNew: false);
			MyProject.Forms.frmReceivedItem.CurrentId = Conversions.ToDouble(dgvReceiveItem[0, dgvReceiveItem.CurrentRow.Index].Value);
			MyProject.Forms.frmReceivedItem.loadData();
			MyProject.Forms.frmReceivedItem.Activate();
			MyProject.Forms.frmReceivedItem.WindowState = FormWindowState.Normal;
		}
	}

	private void dgvInvoice_DoubleClick(object sender, EventArgs e)
	{
		openInvoice();
	}

	private void dgvInvoice_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			openInvoice();
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

	private void openInvoice()
	{
		if (dgvInvoice.RowCount > 0 && Conversion.Val(RuntimeHelpers.GetObjectValue(dgvInvoice[0, dgvInvoice.CurrentRow.Index].Value)) > 0.0)
		{
			MyProject.Forms.frmPurchaseInvoice.Show();
			MyProject.Forms.frmPurchaseInvoice.prepareForm(SaveNew: false, KeepSupplier: false);
			MyProject.Forms.frmPurchaseInvoice.CurrentId = Conversions.ToDouble(dgvInvoice[0, dgvInvoice.CurrentRow.Index].Value);
			MyProject.Forms.frmPurchaseInvoice.LoadData();
			MyProject.Forms.frmPurchaseInvoice.Activate();
			MyProject.Forms.frmPurchaseInvoice.WindowState = FormWindowState.Normal;
		}
	}

	private void dgvReturn_DoubleClick(object sender, EventArgs e)
	{
		openReturn();
	}

	private void dgvReturn_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			openReturn();
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

	private void openReturn()
	{
		if (dgvReturn.RowCount > 0 && Conversion.Val(RuntimeHelpers.GetObjectValue(dgvReturn[0, dgvReturn.CurrentRow.Index].Value)) > 0.0)
		{
			MyProject.Forms.frmPurchaseReturn.Show();
			MyProject.Forms.frmPurchaseReturn.prepareForm(SaveNew: false, KeepSupplier: false);
			MyProject.Forms.frmPurchaseReturn.CurrentId = Conversions.ToDouble(dgvReturn[0, dgvReturn.CurrentRow.Index].Value);
			MyProject.Forms.frmPurchaseReturn.LoadData();
			MyProject.Forms.frmPurchaseReturn.Activate();
			MyProject.Forms.frmPurchaseReturn.WindowState = FormWindowState.Normal;
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

	private void openPayment()
	{
		if (dgvPayment.RowCount > 0 && Conversion.Val(RuntimeHelpers.GetObjectValue(dgvPayment[1, dgvPayment.CurrentRow.Index].Value)) > 0.0)
		{
			MyProject.Forms.frmSupplierPayment.Show();
			MyProject.Forms.frmSupplierPayment.PrepareForm(SaveNew: false);
			MyProject.Forms.frmSupplierPayment.CurrentId = Conversions.ToDouble(dgvPayment[1, dgvPayment.CurrentRow.Index].Value);
			MyProject.Forms.frmSupplierPayment.LoadData();
			MyProject.Forms.frmSupplierPayment.Activate();
			MyProject.Forms.frmSupplierPayment.WindowState = FormWindowState.Normal;
		}
		else if (dgvPayment.RowCount > 0 && Conversion.Val(RuntimeHelpers.GetObjectValue(dgvPayment[0, dgvPayment.CurrentRow.Index].Value)) > 0.0)
		{
			MyProject.Forms.frmPurchaseInvoice.Show();
			MyProject.Forms.frmPurchaseInvoice.prepareForm(SaveNew: false, KeepSupplier: false);
			MyProject.Forms.frmPurchaseInvoice.CurrentId = Conversions.ToDouble(dgvPayment[0, dgvPayment.CurrentRow.Index].Value);
			MyProject.Forms.frmPurchaseInvoice.LoadData();
			MyProject.Forms.frmPurchaseInvoice.TabControl1.SelectedIndex = 1;
			MyProject.Forms.frmPurchaseInvoice.Activate();
			MyProject.Forms.frmPurchaseInvoice.WindowState = FormWindowState.Normal;
		}
	}

	private void dgvReturnPayment_DoubleClick(object sender, EventArgs e)
	{
		openReturnPayment();
	}

	private void dgvReturnPayment_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			openReturnPayment();
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

	private void dgvReturnPayment_GotFocus(object sender, EventArgs e)
	{
		dgvReturnPayment.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
		dgvReturnPayment.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
		if (dgvReturnPayment.RowCount > 0)
		{
			dgvReturnPayment.CurrentRow.Selected = true;
		}
		dgvReturnPayment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
	}

	private void dgvReturnPayment_LostFocus(object sender, EventArgs e)
	{
		if (dgvReturnPayment.RowCount > 0)
		{
			dgvReturnPayment.CurrentRow.Selected = false;
		}
	}

	private void openReturnPayment()
	{
		if (dgvReturnPayment.RowCount > 0 && Conversion.Val(RuntimeHelpers.GetObjectValue(dgvReturnPayment[0, dgvReturnPayment.CurrentRow.Index].Value)) > 0.0)
		{
			MyProject.Forms.frmPurchaseReturn.Show();
			MyProject.Forms.frmPurchaseReturn.prepareForm(SaveNew: false, KeepSupplier: false);
			MyProject.Forms.frmPurchaseReturn.CurrentId = Conversions.ToDouble(dgvReturnPayment[0, dgvReturnPayment.CurrentRow.Index].Value);
			MyProject.Forms.frmPurchaseReturn.LoadData();
			MyProject.Forms.frmPurchaseReturn.TabControl1.SelectedIndex = 1;
			MyProject.Forms.frmPurchaseReturn.Activate();
			MyProject.Forms.frmPurchaseReturn.WindowState = FormWindowState.Normal;
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
						cComboItem cComboItem2 = (cComboItem)cboParentSupplier.SelectedItem;
						cComboItem cComboItem3 = (cComboItem)cboCurrency.SelectedItem;
						cComboItem cComboItem4 = (cComboItem)cboCashAccount.SelectedItem;
						cComboItem cComboItem5 = (cComboItem)cboBankAccount.SelectedItem;
						cComboItem cComboItem6 = (cComboItem)cboActive.SelectedItem;
						if (Operators.CompareString(txtName.Text, "", TextCompare: false) == 0)
						{
							Interaction.MsgBox("Masukkan nama Supplier", MsgBoxStyle.Information);
							txtName.Focus();
							goto end_IL_0001;
						}
						if (Operators.CompareString(txtAddress.Text, "", TextCompare: false) == 0)
						{
							Interaction.MsgBox("Masukkan alamat", MsgBoxStyle.Information);
							txtAddress.Focus();
							goto end_IL_0001;
						}
						if (Operators.CompareString(cboParentSupplier.Text, "", TextCompare: false) == 0)
						{
							Interaction.MsgBox("Pilih Grup Supplier", MsgBoxStyle.Information);
							cboParentSupplier.Focus();
							goto end_IL_0001;
						}
						if (cboParentSupplier.SelectedIndex == -1)
						{
							Interaction.MsgBox("Grup Supplier anda pilih tidak terdaftar.", MsgBoxStyle.Information);
							cboParentSupplier.Focus();
							goto end_IL_0001;
						}
						if (cboCurrency.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih mata uang.", MsgBoxStyle.Information);
							cboCurrency.Focus();
							goto end_IL_0001;
						}
						if (Operators.CompareString(cboCashAccount.Text, "", TextCompare: false) == 0)
						{
							Interaction.MsgBox("Pilih Kas", MsgBoxStyle.Information);
							cboCashAccount.Focus();
							goto end_IL_0001;
						}
						if (cboCashAccount.SelectedIndex == -1)
						{
							Interaction.MsgBox("Kas yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
							cboCashAccount.Focus();
							goto end_IL_0001;
						}
						if (Operators.CompareString(cboBankAccount.Text, "", TextCompare: false) == 0)
						{
							Interaction.MsgBox("Pilih Rekening", MsgBoxStyle.Information);
							cboBankAccount.Focus();
							goto end_IL_0001;
						}
						if (cboBankAccount.SelectedIndex == -1)
						{
							Interaction.MsgBox("Rekening bank yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
							cboBankAccount.Focus();
							goto end_IL_0001;
						}
						if (cboActive.SelectedIndex == -1)
						{
							Interaction.MsgBox("Status yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
							cboActive.Focus();
							goto end_IL_0001;
						}
						cSupplier cSupplier2 = new cSupplier(0);
						cSupplier2.Id = (int)Math.Round(_currentId);
						cSupplier2.Name = txtName.Text;
						cSupplier2.Address = txtAddress.Text;
						cSupplier2.NPWP = txtNPWP.Text;
						cSupplier2.IsParent = (chkIsParent.Checked ? 1 : 0);
						if (Conversions.ToDouble(cComboItem2.Value) == 0.0)
						{
							cSupplier2.ParentId = (int)Math.Round(_currentId);
						}
						else
						{
							cSupplier2.ParentId = Conversions.ToInteger(cComboItem2.Value);
						}
						cSupplier2.CurrencyId = Conversions.ToInteger(cComboItem3.Value);
						cSupplier2.CashAccountId = Conversions.ToInteger(cComboItem4.Value);
						cSupplier2.BankAccountId = Conversions.ToInteger(cComboItem5.Value);
						cSupplier2.Active = Conversions.ToInteger(cComboItem6.Value);
						cSupplier2.save();
						string content = "Nama: " + Module1.cleanString(txtName.Text) + "<br />Alamat: " + Module1.cleanString(txtAddress.Text) + "<br />NPWP: " + Module1.cleanString(txtNPWP.Text) + "<br />Tipe: " + (chkIsParent.Checked ? "Grup" : "Non-Grup") + "<br />Anggota dari: " + cboParentSupplier.Text + "<br />Kas: " + cboCashAccount.Text + "<br />Rekening: " + cboBankAccount.Text + "<br />Status: " + cboActive.Text + "<br />";
						string text;
						if (_currentId == 0.0)
						{
							text = "membuat ";
							_currentId = cSupplier2.Id;
						}
						else
						{
							text = "mengupdate ";
						}
						text = text + "Supplier " + txtName.Text + ". ID= " + Conversions.ToString(_currentId) + ", v2";
						cHistory cHistory2 = new cHistory();
						cHistory2.Content = content;
						cHistory2.Description = text;
						cHistory2.UserId = Module1.pubUserId;
						cHistory2.UserLogin = Module1.pubLogin;
						cHistory2.fKeyId = _currentId;
						cHistory2.HistoryType = 11;
						cHistory2.Save();
						Interaction.MsgBox("Supplier berhasil disimpan", MsgBoxStyle.Information);
						if (CloseForm)
						{
							Close();
						}
						else
						{
							btnHistory.Enabled = true;
						}
						goto end_IL_0001;
					}
					case 1455:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmSupplier", "SaveData", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1455;
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
					MyProject.Forms.frmHistory.GetHistory(checked((int)Math.Round(_currentId)), 11);
					MyProject.Forms.frmHistory.Show();
					MyProject.Forms.frmHistory.Activate();
					MyProject.Forms.frmHistory.WindowState = FormWindowState.Normal;
					goto end_IL_0001;
				case 120:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSupplier", "btnHistory_Click", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 120;
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

	private void btnReceiveItem_Click(object sender, EventArgs e)
	{
		MyProject.Forms.frmReceivedItem.Show();
		MyProject.Forms.frmReceivedItem.prepareForm(SaveNew: false);
		frmReceivedItem obj = MyProject.Forms.frmReceivedItem;
		ComboBox cboSource = obj.cboSupplier;
		Module1.comboBoundValue(ref cboSource, _currentId);
		obj.cboSupplier = cboSource;
		MyProject.Forms.frmReceivedItem.Activate();
		MyProject.Forms.frmReceivedItem.dtpRI.Focus();
	}

	private void btnPurchaseInvoice_Click(object sender, EventArgs e)
	{
		MyProject.Forms.frmPurchaseInvoice.Show();
		MyProject.Forms.frmPurchaseInvoice.prepareForm(SaveNew: false, KeepSupplier: false);
		frmPurchaseInvoice obj = MyProject.Forms.frmPurchaseInvoice;
		ComboBox cboSource = obj.cboSupplier;
		Module1.comboBoundValue(ref cboSource, _currentId);
		obj.cboSupplier = cboSource;
		MyProject.Forms.frmPurchaseInvoice.Activate();
		MyProject.Forms.frmPurchaseInvoice.dtpInvoice.Focus();
	}

	private void btnPurchaseReturn_Click(object sender, EventArgs e)
	{
		MyProject.Forms.frmPurchaseReturn.Show();
		MyProject.Forms.frmPurchaseReturn.prepareForm(SaveNew: false, KeepSupplier: false);
		frmPurchaseReturn obj = MyProject.Forms.frmPurchaseReturn;
		ComboBox cboSource = obj.cboSupplier;
		Module1.comboBoundValue(ref cboSource, _currentId);
		obj.cboSupplier = cboSource;
		MyProject.Forms.frmPurchaseReturn.Activate();
		MyProject.Forms.frmPurchaseReturn.dtpInvoice.Focus();
	}

	private void btnPayment_Click(object sender, EventArgs e)
	{
		if (!Module1.pubViewReportPurchaseInvoicePrice)
		{
			Interaction.MsgBox("Anda tidak bisa melihat faktur yang telah memiliki harga.", MsgBoxStyle.Information);
			return;
		}
		MyProject.Forms.frmSupplierPayment.Show();
		MyProject.Forms.frmSupplierPayment.PrepareForm(SaveNew: false);
		frmSupplierPayment obj = MyProject.Forms.frmSupplierPayment;
		ComboBox cboSource = obj.cboSupplier;
		Module1.comboBoundValue(ref cboSource, _currentId);
		obj.cboSupplier = cboSource;
		MyProject.Forms.frmSupplierPayment.Activate();
	}
}
