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
public class frmSalesOrder : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSearch")]
	private Button _btnSearch;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("lblAddress")]
	private Label _lblAddress;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("lblName")]
	private Label _lblName;

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
	[AccessedThroughProperty("btnSaveClose")]
	private Button _btnSaveClose;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnDelete")]
	private Button _btnDelete;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnHistory")]
	private Button _btnHistory;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("txtDiscountValue")]
	private FilteredTextBox _txtDiscountValue;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSave")]
	private Button _btnSave;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("lblInformation")]
	private Label _lblInformation;

	private double _customerId;

	private double _currentId;

	private int _storageId;

	private int _branchId;

	private cSalesOrderItem[] _SOItem;

	private double _invoiceId;

	private int _totalItem;

	private int _discountId;

	[field: AccessedThroughProperty("lblNumber")]
	internal virtual Label lblNumber
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

	internal virtual Label lblAddress
	{
		[CompilerGenerated]
		get
		{
			return _lblAddress;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = lblAddress_Click;
			Label label = _lblAddress;
			if (label != null)
			{
				label.Click -= value2;
			}
			_lblAddress = value;
			label = _lblAddress;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal virtual Label lblName
	{
		[CompilerGenerated]
		get
		{
			return _lblName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = lblName_Click;
			Label label = _lblName;
			if (label != null)
			{
				label.Click -= value2;
			}
			_lblName = value;
			label = _lblName;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabControl1")]
	internal virtual TabControl TabControl1
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dtpSO")]
	internal virtual DateTimePicker dtpSO
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

	[field: AccessedThroughProperty("Label23")]
	internal virtual Label Label23
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

	[field: AccessedThroughProperty("txtPONumber")]
	internal virtual TextBox txtPONumber
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

	[field: AccessedThroughProperty("dtpExpired")]
	internal virtual DateTimePicker dtpExpired
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DateTimePicker1")]
	internal virtual DateTimePicker DateTimePicker1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("txtDiscountDescription")]
	internal virtual FilteredTextBox txtDiscountDescription
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

	public int StorageId
	{
		get
		{
			return _storageId;
		}
		set
		{
			_storageId = value;
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
		this.lblNumber = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.btnSearch = new System.Windows.Forms.Button();
		this.lblAddress = new System.Windows.Forms.Label();
		this.lblName = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label10 = new System.Windows.Forms.Label();
		this.btnItem = new System.Windows.Forms.Button();
		this.Label3 = new System.Windows.Forms.Label();
		this.TabControl1 = new System.Windows.Forms.TabControl();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.dgvItem = new System.Windows.Forms.DataGridView();
		this.Label1 = new System.Windows.Forms.Label();
		this.dtpSO = new System.Windows.Forms.DateTimePicker();
		this.btnSaveClose = new System.Windows.Forms.Button();
		this.btnDelete = new System.Windows.Forms.Button();
		this.btnHistory = new System.Windows.Forms.Button();
		this.Label23 = new System.Windows.Forms.Label();
		this.Label13 = new System.Windows.Forms.Label();
		this.Label9 = new System.Windows.Forms.Label();
		this.lblTotalInvoice = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.lblTotalPrice = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.txtPONumber = new System.Windows.Forms.TextBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.dtpExpired = new System.Windows.Forms.DateTimePicker();
		this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
		this.btnSave = new System.Windows.Forms.Button();
		this.txtDiscountValue = new GCUv2.FilteredTextBox();
		this.lblInformation = new System.Windows.Forms.Label();
		this.txtDiscountDescription = new GCUv2.FilteredTextBox();
		this.TabControl1.SuspendLayout();
		this.TabPage1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvItem).BeginInit();
		base.SuspendLayout();
		this.lblNumber.AutoSize = true;
		this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblNumber.Location = new System.Drawing.Point(283, 73);
		this.lblNumber.Name = "lblNumber";
		this.lblNumber.Size = new System.Drawing.Size(54, 13);
		this.lblNumber.TabIndex = 204;
		this.lblNumber.Text = "lblNumber";
		this.lblNumber.Visible = false;
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(7, 125);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(63, 13);
		this.Label4.TabIndex = 202;
		this.Label4.Text = "Tgl. Expired";
		this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnSearch.Location = new System.Drawing.Point(365, 17);
		this.btnSearch.Name = "btnSearch";
		this.btnSearch.Size = new System.Drawing.Size(83, 23);
		this.btnSearch.TabIndex = 0;
		this.btnSearch.Text = "Pilih Customer";
		this.btnSearch.UseVisualStyleBackColor = true;
		this.lblAddress.BackColor = System.Drawing.Color.White;
		this.lblAddress.Cursor = System.Windows.Forms.Cursors.Hand;
		this.lblAddress.Location = new System.Drawing.Point(9, 32);
		this.lblAddress.Name = "lblAddress";
		this.lblAddress.Size = new System.Drawing.Size(350, 26);
		this.lblAddress.TabIndex = 201;
		this.lblAddress.Text = "lblAddress";
		this.lblName.BackColor = System.Drawing.Color.White;
		this.lblName.Cursor = System.Windows.Forms.Cursors.Hand;
		this.lblName.Location = new System.Drawing.Point(9, 9);
		this.lblName.Name = "lblName";
		this.lblName.Size = new System.Drawing.Size(350, 23);
		this.lblName.TabIndex = 200;
		this.lblName.Text = "lblName";
		this.Label2.BackColor = System.Drawing.Color.White;
		this.Label2.Location = new System.Drawing.Point(-12, -11);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(713, 69);
		this.Label2.TabIndex = 199;
		this.Label10.BackColor = System.Drawing.Color.Silver;
		this.Label10.Location = new System.Drawing.Point(-224, 455);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(713, 59);
		this.Label10.TabIndex = 198;
		this.btnItem.BackColor = System.Drawing.SystemColors.ButtonFace;
		this.btnItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnItem.Location = new System.Drawing.Point(6, 11);
		this.btnItem.Name = "btnItem";
		this.btnItem.Size = new System.Drawing.Size(61, 24);
		this.btnItem.TabIndex = 5;
		this.btnItem.Text = "+ Barang";
		this.btnItem.UseVisualStyleBackColor = false;
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(229, 73);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(38, 13);
		this.Label3.TabIndex = 203;
		this.Label3.Text = "Nomer";
		this.Label3.Visible = false;
		this.TabControl1.Controls.Add(this.TabPage1);
		this.TabControl1.Location = new System.Drawing.Point(9, 148);
		this.TabControl1.Name = "TabControl1";
		this.TabControl1.SelectedIndex = 0;
		this.TabControl1.Size = new System.Drawing.Size(441, 207);
		this.TabControl1.TabIndex = 4;
		this.TabPage1.Controls.Add(this.btnItem);
		this.TabPage1.Controls.Add(this.dgvItem);
		this.TabPage1.Location = new System.Drawing.Point(4, 22);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage1.Size = new System.Drawing.Size(433, 181);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = "Barang";
		this.TabPage1.UseVisualStyleBackColor = true;
		this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvItem.Location = new System.Drawing.Point(6, 41);
		this.dgvItem.Name = "dgvItem";
		this.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dgvItem.Size = new System.Drawing.Size(412, 134);
		this.dgvItem.TabIndex = 6;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(6, 99);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(70, 13);
		this.Label1.TabIndex = 197;
		this.Label1.Text = "Tgl. Pesanan";
		this.dtpSO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpSO.Location = new System.Drawing.Point(92, 96);
		this.dtpSO.Name = "dtpSO";
		this.dtpSO.Size = new System.Drawing.Size(121, 20);
		this.dtpSO.TabIndex = 2;
		this.btnSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSaveClose.Location = new System.Drawing.Point(244, 464);
		this.btnSaveClose.Name = "btnSaveClose";
		this.btnSaveClose.Size = new System.Drawing.Size(93, 24);
		this.btnSaveClose.TabIndex = 32;
		this.btnSaveClose.Text = "Simpan && &Tutup";
		this.btnSaveClose.UseVisualStyleBackColor = true;
		this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDelete.Location = new System.Drawing.Point(343, 464);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new System.Drawing.Size(49, 24);
		this.btnDelete.TabIndex = 33;
		this.btnDelete.Text = "Hapus";
		this.btnDelete.UseVisualStyleBackColor = true;
		this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnHistory.Location = new System.Drawing.Point(398, 464);
		this.btnHistory.Name = "btnHistory";
		this.btnHistory.Size = new System.Drawing.Size(50, 24);
		this.btnHistory.TabIndex = 34;
		this.btnHistory.Text = "&History";
		this.btnHistory.UseVisualStyleBackColor = true;
		this.Label23.BackColor = System.Drawing.Color.Silver;
		this.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Label23.Location = new System.Drawing.Point(16, 422);
		this.Label23.Name = "Label23";
		this.Label23.Size = new System.Drawing.Size(434, 1);
		this.Label23.TabIndex = 220;
		this.Label13.BackColor = System.Drawing.Color.Silver;
		this.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Label13.Location = new System.Drawing.Point(15, 402);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(434, 1);
		this.Label13.TabIndex = 219;
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(12, 406);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(31, 13);
		this.Label9.TabIndex = 218;
		this.Label9.Text = "Total";
		this.lblTotalInvoice.Location = new System.Drawing.Point(75, 406);
		this.lblTotalInvoice.Name = "lblTotalInvoice";
		this.lblTotalInvoice.Size = new System.Drawing.Size(90, 13);
		this.lblTotalInvoice.TabIndex = 217;
		this.lblTotalInvoice.Text = "Total Invoice";
		this.lblTotalInvoice.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(12, 358);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(63, 13);
		this.Label8.TabIndex = 215;
		this.Label8.Text = "Total Harga";
		this.lblTotalPrice.Location = new System.Drawing.Point(75, 358);
		this.lblTotalPrice.Name = "lblTotalPrice";
		this.lblTotalPrice.Size = new System.Drawing.Size(90, 13);
		this.lblTotalPrice.TabIndex = 213;
		this.lblTotalPrice.Text = "Total Price";
		this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.Location = new System.Drawing.Point(13, 376);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(40, 13);
		this.Label6.TabIndex = 212;
		this.Label6.Text = "Diskon";
		this.txtPONumber.Location = new System.Drawing.Point(92, 70);
		this.txtPONumber.Name = "txtPONumber";
		this.txtPONumber.Size = new System.Drawing.Size(121, 20);
		this.txtPONumber.TabIndex = 1;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(7, 73);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(83, 13);
		this.Label5.TabIndex = 222;
		this.Label5.Text = "Nomer Pesanan";
		this.dtpExpired.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpExpired.Location = new System.Drawing.Point(92, 122);
		this.dtpExpired.Name = "dtpExpired";
		this.dtpExpired.Size = new System.Drawing.Size(121, 20);
		this.dtpExpired.TabIndex = 3;
		this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.DateTimePicker1.Location = new System.Drawing.Point(78, 137);
		this.DateTimePicker1.Name = "DateTimePicker1";
		this.DateTimePicker1.Size = new System.Drawing.Size(121, 20);
		this.DateTimePicker1.TabIndex = 223;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(145, 464);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(93, 24);
		this.btnSave.TabIndex = 31;
		this.btnSave.Text = "&Simpan && Baru";
		this.btnSave.UseVisualStyleBackColor = true;
		this.txtDiscountValue.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtDiscountValue.DontFormat = false;
		this.txtDiscountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtDiscountValue.Location = new System.Drawing.Point(78, 374);
		this.txtDiscountValue.MaximumDigit = 3;
		this.txtDiscountValue.Name = "txtDiscountValue";
		this.txtDiscountValue.Size = new System.Drawing.Size(87, 21);
		this.txtDiscountValue.TabIndex = 21;
		this.txtDiscountValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.lblInformation.AutoSize = true;
		this.lblInformation.Cursor = System.Windows.Forms.Cursors.Hand;
		this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
		this.lblInformation.ForeColor = System.Drawing.Color.Blue;
		this.lblInformation.Location = new System.Drawing.Point(16, 429);
		this.lblInformation.Name = "lblInformation";
		this.lblInformation.Size = new System.Drawing.Size(82, 15);
		this.lblInformation.TabIndex = 223;
		this.lblInformation.Text = "lblInformation";
		this.txtDiscountDescription.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtDiscountDescription.DontFormat = false;
		this.txtDiscountDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtDiscountDescription.Location = new System.Drawing.Point(171, 374);
		this.txtDiscountDescription.MaximumDigit = 3;
		this.txtDiscountDescription.Name = "txtDiscountDescription";
		this.txtDiscountDescription.Size = new System.Drawing.Size(87, 21);
		this.txtDiscountDescription.TabIndex = 22;
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(460, 494);
		base.Controls.Add(this.txtDiscountDescription);
		base.Controls.Add(this.lblInformation);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.dtpExpired);
		base.Controls.Add(this.txtPONumber);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.Label23);
		base.Controls.Add(this.Label13);
		base.Controls.Add(this.Label9);
		base.Controls.Add(this.lblTotalInvoice);
		base.Controls.Add(this.Label8);
		base.Controls.Add(this.txtDiscountValue);
		base.Controls.Add(this.lblTotalPrice);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.btnSaveClose);
		base.Controls.Add(this.btnDelete);
		base.Controls.Add(this.btnHistory);
		base.Controls.Add(this.lblNumber);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.btnSearch);
		base.Controls.Add(this.lblAddress);
		base.Controls.Add(this.lblName);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Label10);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.TabControl1);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.dtpSO);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSalesOrder";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Pesanan Penjualan";
		this.TabControl1.ResumeLayout(false);
		this.TabPage1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgvItem).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmSalesOrder()
	{
		base.KeyDown += frmSalesOrder_KeyDown;
		InitializeComponent();
		DoubleBuffered = true;
		base.MdiParent = MyProject.Forms.frmMenu;
		txtDiscountValue.AllowedCharacters = FilteredTextBox.InputType.NumeralsAndCurrency;
		txtDiscountDescription.AllowedCharacters = FilteredTextBox.InputType.All;
		txtDiscountDescription.DontFormat = true;
		formatGrid();
		btnSearch.Focus();
	}

	private void formatGrid()
	{
		dgvItem.Columns.Add("", "itemId");
		dgvItem.Columns.Add("", "Barang");
		dgvItem.Columns.Add("", "Jumlah");
		dgvItem.Columns.Add("", "Harga");
		dgvItem.Columns.Add("", "Total");
		dgvItem.Columns[0].Visible = false;
		dgvItem.Columns[1].Width = 120;
		dgvItem.Columns[2].Width = 80;
		dgvItem.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItem.Columns[3].Width = 80;
		dgvItem.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItem.Columns[4].Width = 100;
		dgvItem.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItem.RowHeadersVisible = false;
		dgvItem.AllowUserToAddRows = false;
		dgvItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvItem.ReadOnly = true;
		dgvItem.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvItem.AllowUserToResizeRows = false;
	}

	public void prepareForm(bool SaveNew)
	{
		_currentId = 0.0;
		_customerId = 0.0;
		_SOItem = null;
		btnSearch.Visible = true;
		lblName.Text = "Klik tombol 'Pilih Customer' untuk memilih customer";
		lblAddress.Text = "";
		txtPONumber.Text = "";
		txtDiscountDescription.Text = "";
		txtDiscountValue.Text = "";
		dtpSO.Value = DateAndTime.Now;
		dtpExpired.Value = DateAndTime.Now;
		dtpSO.Enabled = true;
		lblTotalPrice.Text = "";
		lblTotalInvoice.Text = "";
		lblInformation.Text = "";
		dgvItem.Rows.Clear();
		lblNumber.Text = "auto";
		btnHistory.Enabled = false;
		btnDelete.Enabled = false;
	}

	public void loadData()
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
					cSalesOrder cSalesOrder2 = new cSalesOrder(_currentId);
					_customerId = cSalesOrder2.CustomerId;
					_discountId = cSalesOrder2.DiscountId;
					btnSearch.Visible = false;
					lblName.Text = cSalesOrder2.CustomerName;
					lblAddress.Text = cSalesOrder2.CustomerAddress;
					lblNumber.Text = cSalesOrder2.SONumber;
					txtPONumber.Text = cSalesOrder2.PONumber;
					dtpSO.Value = cSalesOrder2.SODate;
					dtpExpired.Value = cSalesOrder2.ExpiredDate;
					txtDiscountDescription.Text = cSalesOrder2.DiscountDescription;
					txtDiscountValue.Text = Module1.formatCustomDecimal(Conversions.ToString(cSalesOrder2.Discount), 2);
					_SOItem = cSalesOrder2.Item;
					cSalesOrderItem[] item = cSalesOrder2.Item;
					foreach (cSalesOrderItem cSalesOrderItem2 in item)
					{
						dgvItem.Rows.Add(cSalesOrderItem2.ItemId, cSalesOrderItem2.ItemName, Module1.formatCustomDecimal(Conversions.ToString(cSalesOrderItem2.Qty), 3), Module1.formatCustomDecimal(Conversions.ToString(cSalesOrderItem2.Price), 2), Module1.formatCustomDecimal(Conversions.ToString(cSalesOrderItem2.Qty * cSalesOrderItem2.Price), 2));
					}
					calculateTotalPrice();
					if (dgvItem.RowCount > 0)
					{
						dgvItem.CurrentRow.Selected = false;
					}
					_invoiceId = cSalesOrder2.InvoiceId;
					if (DateAndTime.DateDiff(DateInterval.Day, dtpSO.Value, DateAndTime.Now) <= Module1.pubDaysLimit)
					{
						dtpSO.Enabled = true;
					}
					else
					{
						dtpSO.Enabled = false;
					}
					if (Operators.CompareString(cSalesOrder2.InvoiceNumber, "", TextCompare: false) != 0)
					{
						lblInformation.Text = "Sudah dimasukkan di Faktur Penjualan: " + cSalesOrder2.InvoiceNumber;
						btnSave.Enabled = false;
						btnSaveClose.Enabled = false;
						btnDelete.Enabled = false;
					}
					else
					{
						btnSave.Enabled = true;
						btnSaveClose.Enabled = true;
						if (DateAndTime.DateDiff(DateInterval.Day, dtpSO.Value, DateAndTime.Now) <= Module1.pubDaysLimit)
						{
							btnDelete.Enabled = true;
						}
						else
						{
							btnDelete.Enabled = false;
						}
					}
					btnHistory.Enabled = true;
					goto end_IL_0001;
				}
				case 792:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSalesOrder", "loadData", "");
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
				try0001_dispatch = 792;
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

	private void frmSalesOrder_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void btnSearch_Click(object sender, EventArgs e)
	{
		frmCustomerMiniSearch frmCustomerMiniSearch2 = new frmCustomerMiniSearch();
		frmCustomerMiniSearch2.CallerName = "SalesOrder";
		frmCustomerMiniSearch2.ShowDialog();
		frmCustomerMiniSearch2.Close();
		frmCustomerMiniSearch2.Dispose();
		if (_customerId > 0.0)
		{
			LoadCustomer();
		}
	}

	public void LoadCustomer()
	{
		cCustomer cCustomer2 = new cCustomer(_customerId);
		_branchId = cCustomer2.BranchId;
		lblName.Text = cCustomer2.Name;
		lblAddress.Text = cCustomer2.Address;
		StorageId = cCustomer2.StorageId;
		_discountId = cCustomer2.DiscountId;
		txtPONumber.Focus();
	}

	private void lblName_Click(object sender, EventArgs e)
	{
		OpenCustomer();
	}

	private void lblAddress_Click(object sender, EventArgs e)
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

	private void btnItem_Click(object sender, EventArgs e)
	{
		frmSalesOrderItem frmSalesOrderItem2 = new frmSalesOrderItem(CurrentData: false, _customerId, _storageId);
		frmSalesOrderItem2.ShowDialog();
		frmSalesOrderItem2.Close();
		frmSalesOrderItem2.Dispose();
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
					if (dgvItem.Rows.Count > 0)
					{
						frmSalesOrderItem frmSalesOrderItem2 = new frmSalesOrderItem(CurrentData: true, _customerId, _storageId);
						frmSalesOrderItem2.SOItem = _SOItem;
						ComboBox cboSource = frmSalesOrderItem2.cboItem;
						Module1.comboBoundValue(ref cboSource, Conversions.ToDouble(dgvItem[0, dgvItem.CurrentRow.Index].Value));
						frmSalesOrderItem2.cboItem = cboSource;
						frmSalesOrderItem2.txtQty.Text = Module1.formatCustomDecimal(Conversions.ToString(dgvItem[2, dgvItem.CurrentRow.Index].Value), 3);
						frmSalesOrderItem2.txtPrice.Text = Module1.formatCustomDecimal(Conversions.ToString(dgvItem[3, dgvItem.CurrentRow.Index].Value), 2);
						frmSalesOrderItem2.ShowDialog();
					}
					goto end_IL_0001;
				case 283:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSalesOrder", "OpenItem", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 283;
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
							ref int totalItem = ref _totalItem;
							totalItem = (int)Math.Round((double)totalItem + Conversions.ToDouble(dgvItem[2, i].Value));
							num4 += Conversions.ToDouble(dgvItem[4, i].Value);
						}
						lblTotalPrice.Text = Module1.formatCustomDecimal(Conversions.ToString(num4), 2);
						calculateTotalInvoice();
						goto end_IL_0001;
					}
					case 182:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmSalesOrder", "CalculateTotalPrice", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 182;
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
					goto end_IL_0001;
				}
				case 111:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSalesOrder", "CalculateTotalInvoice", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 111;
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
						if (_customerId == 0.0)
						{
							Interaction.MsgBox("Pilih customer", MsgBoxStyle.Information);
							btnSearch.Focus();
							goto end_IL_0001;
						}
						if (Operators.CompareString(txtPONumber.Text, "", TextCompare: false) == 0)
						{
							Interaction.MsgBox("Masukkan Nomer PO.", MsgBoxStyle.Information);
							txtPONumber.Focus();
							goto end_IL_0001;
						}
						if (!cValidation.isDateWithinRange(dtpSO.Value, Module1.pubGroupId, Module1.pubDaysLimit))
						{
							Interaction.MsgBox("Tanggal diluar batas yang diperbolehkan", MsgBoxStyle.Information);
							dtpSO.Focus();
							goto end_IL_0001;
						}
						if (dgvItem.Rows.Count == 0)
						{
							Interaction.MsgBox("Masukkan barang.", MsgBoxStyle.Information);
							btnItem.Focus();
							goto end_IL_0001;
						}
						if (Conversion.Val(txtDiscountValue.Text) != 0.0 && !Versioned.IsNumeric(txtDiscountValue.Text))
						{
							Interaction.MsgBox("Masukkan jumlah discount dengan format angka yang benar", MsgBoxStyle.Information);
							txtDiscountValue.Focus();
							goto end_IL_0001;
						}
						cSalesOrder cSalesOrder2 = new cSalesOrder(0.0);
						cSalesOrderItem[] array = new cSalesOrderItem[dgvItem.Rows.Count - 1 + 1];
						int num3 = 0;
						cSalesOrder2.Id = _currentId;
						cSalesOrder2.SODate = dtpSO.Value;
						cSalesOrder2.ExpiredDate = dtpExpired.Value;
						cSalesOrder2.PONumber = txtPONumber.Text;
						cSalesOrder2.BranchId = _branchId;
						cSalesOrder2.CustomerId = _customerId;
						int num4 = dgvItem.Rows.Count - 1;
						for (num3 = 0; num3 <= num4; num3++)
						{
							array[num3] = new cSalesOrderItem();
							array[num3].ItemId = Conversions.ToInteger(dgvItem[0, num3].Value);
							array[num3].Qty = Conversions.ToDouble(dgvItem[2, num3].Value);
							array[num3].Price = Conversions.ToDouble(dgvItem[3, num3].Value);
						}
						cSalesOrder2.Item = array;
						cSalesOrder2.Discount = Conversion.Val(Module1.unformatNumber(txtDiscountValue.Text));
						cSalesOrder2.DiscountDescription = txtDiscountDescription.Text;
						cSalesOrder2.TotalPrice = Conversion.Val(Module1.unformatNumber(lblTotalPrice.Text));
						cSalesOrder2.Save();
						if (Operators.CompareString(lblNumber.Text, "auto", TextCompare: false) == 0)
						{
							lblNumber.Text = "SO/" + Conversions.ToString(cSalesOrder2.BranchId) + "/" + Strings.Right(Conversions.ToString(DateAndTime.Year(cSalesOrder2.SODate)), 2) + "/" + cSalesOrder2.SONumber;
						}
						string text = "Nomer: " + txtPONumber.Text + "<br />Tanggal: " + Strings.Format(dtpSO.Value, "dd/MM/yyyy") + "<br />Tanggal Expired: " + Strings.Format(dtpExpired.Value, "dd/MM/yyyy") + "<br />Customer: " + lblName.Text + "<br /><br />";
						text += "Barang:<br />";
						text += "<table><tr><td>Barang</td><td>Jumlah</td><td>Harga</td><td>Total</td></tr>";
						int num5 = dgvItem.Rows.Count - 1;
						for (num3 = 0; num3 <= num5; num3++)
						{
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<tr><td>", dgvItem[1, num3].Value), "</td>"), "<td align='right'>"), Module1.formatCustomDecimal(Conversions.ToString(dgvItem[2, num3].Value), 3)), "</td>"), "<td align='right'>"), Module1.formatCustomDecimal(Conversions.ToString(dgvItem[3, num3].Value), 2)), "</td>"), "<td align='right'>"), Module1.formatCustomDecimal(Conversions.ToString(dgvItem[4, num3].Value), 2)), "</td></tr>")));
						}
						text += "</table>";
						text = text + "Diskon: " + Module1.formatCustomDecimal(txtDiscountValue.Text, 2) + "<br />Deskripsi: " + txtDiscountDescription.Text + "<br />";
						string text2;
						if (_currentId == 0.0)
						{
							text2 = "membuat ";
							_currentId = cSalesOrder2.Id;
						}
						else
						{
							text2 = "mengupdate ";
						}
						text2 = text2 + "Pesanan Penjualan " + txtPONumber.Text + " tanggal " + Strings.Format(dtpSO.Value, "dd/MM/yyyy") + ". ID= " + Conversions.ToString(_currentId) + ", v2";
						cHistory cHistory2 = new cHistory();
						cHistory2.Content = text;
						cHistory2.Description = text2;
						cHistory2.UserId = Module1.pubUserId;
						cHistory2.UserLogin = Module1.pubLogin;
						cHistory2.fKeyId = _currentId;
						cHistory2.HistoryType = 17;
						cHistory2.Save();
						Interaction.MsgBox("Pesanan Penjualan berhasil disimpan", MsgBoxStyle.Information);
						if (Module1.FormIsOpen("frmSalesOrderList"))
						{
							MyProject.Forms.frmSalesOrderList.GetRecent();
						}
						if (Module1.FormIsOpen("frmCustomer"))
						{
							MyProject.Forms.frmCustomer.GetSalesOrder();
						}
						MyProject.Forms.frmInformation.GetActivity();
						if (CloseForm)
						{
							Close();
							goto end_IL_0001;
						}
						prepareForm(SaveNew: true);
						btnSearch.Focus();
						goto end_IL_0001_2;
					}
					case 1771:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmSalesOrder", "SaveData", "");
							goto end_IL_0001_2;
						}
						break;
					}
					goto IL_0721;
				}
				end_IL_0001_2:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1771;
				continue;
			}
			break;
			IL_0721:
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
					if (MessageBox.Show("Hapus Pengiriman Pesanan?", "Konfirmasi", MessageBoxButtons.YesNo) != DialogResult.No)
					{
						cSalesOrder cSalesOrder2 = new cSalesOrder(_currentId);
						cSalesOrder2.Delete();
						string description = "menghapus Pengiriman Pesanan " + cSalesOrder2.SONumber + ". Tanggal  " + Strings.Format(cSalesOrder2.SODate, "dd/MM/yyyy") + ". ID= " + Conversions.ToString(_currentId) + ", v2";
						cHistory cHistory2 = new cHistory();
						cHistory2.Description = description;
						cHistory2.UserId = Module1.pubUserId;
						cHistory2.UserLogin = Module1.pubLogin;
						cHistory2.fKeyId = _currentId;
						cHistory2.HistoryType = 17;
						cHistory2.Save();
						Interaction.MsgBox("Pengiriman Pesanan berhasil dihapus", MsgBoxStyle.Information);
						if (Module1.FormIsOpen("frmSalesOrderList"))
						{
							MyProject.Forms.frmSalesOrderList.GetRecent();
						}
						MyProject.Forms.frmInformation.GetActivity();
						Close();
					}
					goto end_IL_0001;
				case 327:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSalesOrder", "btnDelete_Click", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 327;
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
		MyProject.Forms.frmHistory.GetHistory(checked((int)Math.Round(_currentId)), 17);
		MyProject.Forms.frmHistory.Show();
		MyProject.Forms.frmHistory.Activate();
		MyProject.Forms.frmHistory.WindowState = FormWindowState.Normal;
	}

	private void lblInformation_Click(object sender, EventArgs e)
	{
		MyProject.Forms.frmSalesInvoice.Show();
		MyProject.Forms.frmSalesInvoice.prepareForm(SaveNew: false);
		MyProject.Forms.frmSalesInvoice.CurrentId = _invoiceId;
		MyProject.Forms.frmSalesInvoice.LoadData();
		MyProject.Forms.frmSalesInvoice.Activate();
		MyProject.Forms.frmSalesInvoice.WindowState = FormWindowState.Normal;
	}
}
