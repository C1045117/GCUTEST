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
public class frmCustomerPayment : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSave")]
	private Button _btnSave;

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
	[AccessedThroughProperty("btnSaveClose")]
	private Button _btnSaveClose;

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
	[AccessedThroughProperty("cboPaymentCode")]
	private ComboBox _cboPaymentCode;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dtpPayment")]
	private DateTimePicker _dtpPayment;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("txtAmount")]
	private FilteredTextBox _txtAmount;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("lblName")]
	private Label _lblName;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("lblAddress")]
	private Label _lblAddress;

	private double _currentId;

	private double _customerId;

	private bool _dontFocus;

	private bool _formIsJustLoaded;

	private int _invoiceCurrencyId;

	private int _cashAccountId;

	private int _bankAccountId;

	private DateTime _chequeDepositDate;

	private DateTime _chequeClearingDate;

	[field: AccessedThroughProperty("cbo")]
	internal virtual ComboBox cbo
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
			DataGridViewCellEventHandler value2 = dgvList_CellContentClick;
			DataGridViewCellEventHandler value3 = dgvList_CellContentDoubleClick;
			EventHandler value4 = dgvList_GotFocus;
			EventHandler value5 = dgvList_LostFocus;
			KeyEventHandler value6 = dgvList_KeyDown;
			DataGridViewCellValidatingEventHandler value7 = dgvList_CellValidating;
			DataGridViewCellFormattingEventHandler value8 = dgvList_CellFormatting;
			EventHandler value9 = dgvList_DoubleClick;
			DataGridViewCellEventHandler value10 = dgvList_CellValidated;
			DataGridView dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.CellContentClick -= value2;
				dataGridView.CellContentDoubleClick -= value3;
				dataGridView.GotFocus -= value4;
				dataGridView.LostFocus -= value5;
				dataGridView.KeyDown -= value6;
				dataGridView.CellValidating -= value7;
				dataGridView.CellFormatting -= value8;
				dataGridView.DoubleClick -= value9;
				dataGridView.CellValidated -= value10;
			}
			_dgvList = value;
			dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.CellContentClick += value2;
				dataGridView.CellContentDoubleClick += value3;
				dataGridView.GotFocus += value4;
				dataGridView.LostFocus += value5;
				dataGridView.KeyDown += value6;
				dataGridView.CellValidating += value7;
				dataGridView.CellFormatting += value8;
				dataGridView.DoubleClick += value9;
				dataGridView.CellValidated += value10;
			}
		}
	}

	[field: AccessedThroughProperty("lblTotalAllocation")]
	internal virtual Label lblTotalAllocation
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

	[field: AccessedThroughProperty("lblRemain")]
	internal virtual Label lblRemain
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

	[field: AccessedThroughProperty("txtDescription")]
	internal virtual TextBox txtDescription
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

	internal virtual ComboBox cboPaymentCode
	{
		[CompilerGenerated]
		get
		{
			return _cboPaymentCode;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cboPaymentCode_SelectedIndexChanged;
			ComboBox comboBox = _cboPaymentCode;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_cboPaymentCode = value;
			comboBox = _cboPaymentCode;
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

	internal virtual DateTimePicker dtpPayment
	{
		[CompilerGenerated]
		get
		{
			return _dtpPayment;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = dtpPayment_ValueChanged;
			DateTimePicker dateTimePicker = _dtpPayment;
			if (dateTimePicker != null)
			{
				dateTimePicker.ValueChanged -= value2;
			}
			_dtpPayment = value;
			dateTimePicker = _dtpPayment;
			if (dateTimePicker != null)
			{
				dateTimePicker.ValueChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dtpCheque")]
	internal virtual DateTimePicker dtpCheque
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

	[field: AccessedThroughProperty("txtChequeNo")]
	internal virtual TextBox txtChequeNo
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

	internal virtual FilteredTextBox txtAmount
	{
		[CompilerGenerated]
		get
		{
			return _txtAmount;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = txtAmount_TextChanged;
			FilteredTextBox filteredTextBox = _txtAmount;
			if (filteredTextBox != null)
			{
				filteredTextBox.TextChanged -= value2;
			}
			_txtAmount = value;
			filteredTextBox = _txtAmount;
			if (filteredTextBox != null)
			{
				filteredTextBox.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("cboAccount")]
	internal virtual ComboBox cboAccount
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAccount")]
	internal virtual Label lblAccount
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

	[field: AccessedThroughProperty("cboBank")]
	internal virtual ComboBox cboBank
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

	[field: AccessedThroughProperty("Label14")]
	internal virtual Label Label14
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

	[field: AccessedThroughProperty("lblNote")]
	internal virtual Label lblNote
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
		this.cbo = new System.Windows.Forms.ComboBox();
		this.Label11 = new System.Windows.Forms.Label();
		this.btnSave = new System.Windows.Forms.Button();
		this.btnDelete = new System.Windows.Forms.Button();
		this.btnHistory = new System.Windows.Forms.Button();
		this.btnSaveClose = new System.Windows.Forms.Button();
		this.dgvList = new System.Windows.Forms.DataGridView();
		this.lblTotalAllocation = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.lblRemain = new System.Windows.Forms.Label();
		this.Label12 = new System.Windows.Forms.Label();
		this.txtDescription = new System.Windows.Forms.TextBox();
		this.Label8 = new System.Windows.Forms.Label();
		this.btnSearch = new System.Windows.Forms.Button();
		this.Label2 = new System.Windows.Forms.Label();
		this.cboPaymentCode = new System.Windows.Forms.ComboBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.dtpPayment = new System.Windows.Forms.DateTimePicker();
		this.Label9 = new System.Windows.Forms.Label();
		this.dtpCheque = new System.Windows.Forms.DateTimePicker();
		this.Label3 = new System.Windows.Forms.Label();
		this.txtChequeNo = new System.Windows.Forms.TextBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.cboAccount = new System.Windows.Forms.ComboBox();
		this.lblAccount = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.lblName = new System.Windows.Forms.Label();
		this.lblAddress = new System.Windows.Forms.Label();
		this.cboBank = new System.Windows.Forms.ComboBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.txtAmount = new GCUv2.FilteredTextBox();
		this.Label14 = new System.Windows.Forms.Label();
		this.cboSalesPerson = new System.Windows.Forms.ComboBox();
		this.lblNote = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		base.SuspendLayout();
		this.cbo.Location = new System.Drawing.Point(0, 0);
		this.cbo.Name = "cbo";
		this.cbo.Size = new System.Drawing.Size(121, 21);
		this.cbo.TabIndex = 0;
		this.Label11.BackColor = System.Drawing.Color.Silver;
		this.Label11.Location = new System.Drawing.Point(-4, 374);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(781, 51);
		this.Label11.TabIndex = 156;
		this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
		this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
		this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(441, 383);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(88, 24);
		this.btnSave.TabIndex = 21;
		this.btnSave.Text = "&Simpan && Baru";
		this.btnSave.UseVisualStyleBackColor = true;
		this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDelete.Location = new System.Drawing.Point(634, 383);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new System.Drawing.Size(58, 24);
		this.btnDelete.TabIndex = 23;
		this.btnDelete.Text = "Hapus";
		this.btnDelete.UseVisualStyleBackColor = true;
		this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnHistory.Location = new System.Drawing.Point(698, 383);
		this.btnHistory.Name = "btnHistory";
		this.btnHistory.Size = new System.Drawing.Size(50, 24);
		this.btnHistory.TabIndex = 24;
		this.btnHistory.Text = "&History";
		this.btnHistory.UseVisualStyleBackColor = true;
		this.btnSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSaveClose.Location = new System.Drawing.Point(535, 383);
		this.btnSaveClose.Name = "btnSaveClose";
		this.btnSaveClose.Size = new System.Drawing.Size(93, 24);
		this.btnSaveClose.TabIndex = 22;
		this.btnSaveClose.Text = "Simpan && &Tutup";
		this.btnSaveClose.UseVisualStyleBackColor = true;
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
		this.dgvList.Location = new System.Drawing.Point(275, 67);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(474, 248);
		this.dgvList.TabIndex = 20;
		this.lblTotalAllocation.Location = new System.Drawing.Point(346, 327);
		this.lblTotalAllocation.Name = "lblTotalAllocation";
		this.lblTotalAllocation.Size = new System.Drawing.Size(87, 13);
		this.lblTotalAllocation.TabIndex = 154;
		this.lblTotalAllocation.Text = "lblTotalAllocation";
		this.lblTotalAllocation.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(272, 327);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(68, 13);
		this.Label6.TabIndex = 155;
		this.Label6.Text = "Total Alokasi";
		this.lblRemain.Location = new System.Drawing.Point(346, 347);
		this.lblRemain.Name = "lblRemain";
		this.lblRemain.Size = new System.Drawing.Size(87, 13);
		this.lblRemain.TabIndex = 157;
		this.lblRemain.Text = "lblRemain";
		this.lblRemain.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.Label12.AutoSize = true;
		this.Label12.Location = new System.Drawing.Point(272, 346);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(27, 13);
		this.Label12.TabIndex = 158;
		this.Label12.Text = "Sisa";
		this.txtDescription.AcceptsReturn = true;
		this.txtDescription.Location = new System.Drawing.Point(85, 257);
		this.txtDescription.MaxLength = 100;
		this.txtDescription.Multiline = true;
		this.txtDescription.Name = "txtDescription";
		this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
		this.txtDescription.Size = new System.Drawing.Size(139, 52);
		this.txtDescription.TabIndex = 8;
		this.Label8.AutoSize = true;
		this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label8.Location = new System.Drawing.Point(10, 260);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(62, 13);
		this.Label8.TabIndex = 160;
		this.Label8.Text = "Keterangan";
		this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnSearch.Location = new System.Drawing.Point(446, 17);
		this.btnSearch.Name = "btnSearch";
		this.btnSearch.Size = new System.Drawing.Size(83, 23);
		this.btnSearch.TabIndex = 0;
		this.btnSearch.Text = "Pilih Customer";
		this.btnSearch.UseVisualStyleBackColor = true;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(10, 175);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(44, 13);
		this.Label2.TabIndex = 148;
		this.Label2.Text = "No C/G";
		this.cboPaymentCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboPaymentCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboPaymentCode.FormattingEnabled = true;
		this.cboPaymentCode.Location = new System.Drawing.Point(85, 92);
		this.cboPaymentCode.Name = "cboPaymentCode";
		this.cboPaymentCode.Size = new System.Drawing.Size(116, 21);
		this.cboPaymentCode.TabIndex = 2;
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(10, 95);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(28, 13);
		this.Label4.TabIndex = 149;
		this.Label4.Text = "Tipe";
		this.dtpPayment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpPayment.Location = new System.Drawing.Point(85, 66);
		this.dtpPayment.Name = "dtpPayment";
		this.dtpPayment.Size = new System.Drawing.Size(116, 20);
		this.dtpPayment.TabIndex = 1;
		this.Label9.AutoSize = true;
		this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label9.Location = new System.Drawing.Point(10, 69);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(46, 13);
		this.Label9.TabIndex = 150;
		this.Label9.Text = "Tanggal";
		this.dtpCheque.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpCheque.Location = new System.Drawing.Point(85, 146);
		this.dtpCheque.Name = "dtpCheque";
		this.dtpCheque.Size = new System.Drawing.Size(116, 20);
		this.dtpCheque.TabIndex = 4;
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(10, 148);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(69, 13);
		this.Label3.TabIndex = 151;
		this.Label3.Text = "Tanggal C/G";
		this.txtChequeNo.Location = new System.Drawing.Point(85, 172);
		this.txtChequeNo.Name = "txtChequeNo";
		this.txtChequeNo.Size = new System.Drawing.Size(116, 20);
		this.txtChequeNo.TabIndex = 5;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(10, 232);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(43, 13);
		this.Label5.TabIndex = 152;
		this.Label5.Text = "Jumlah ";
		this.cboAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboAccount.FormattingEnabled = true;
		this.cboAccount.Location = new System.Drawing.Point(85, 315);
		this.cboAccount.Name = "cboAccount";
		this.cboAccount.Size = new System.Drawing.Size(116, 21);
		this.cboAccount.TabIndex = 9;
		this.lblAccount.AutoSize = true;
		this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblAccount.Location = new System.Drawing.Point(10, 318);
		this.lblAccount.Name = "lblAccount";
		this.lblAccount.Size = new System.Drawing.Size(76, 13);
		this.lblAccount.TabIndex = 163;
		this.lblAccount.Text = "Kas/Rekening";
		this.Label7.BackColor = System.Drawing.Color.White;
		this.Label7.Location = new System.Drawing.Point(-8, -12);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(785, 69);
		this.Label7.TabIndex = 185;
		this.lblName.BackColor = System.Drawing.Color.White;
		this.lblName.Cursor = System.Windows.Forms.Cursors.Hand;
		this.lblName.Location = new System.Drawing.Point(13, 8);
		this.lblName.Name = "lblName";
		this.lblName.Size = new System.Drawing.Size(420, 23);
		this.lblName.TabIndex = 186;
		this.lblName.Text = "lblName";
		this.lblAddress.BackColor = System.Drawing.Color.White;
		this.lblAddress.Cursor = System.Windows.Forms.Cursors.Hand;
		this.lblAddress.Location = new System.Drawing.Point(13, 31);
		this.lblAddress.Name = "lblAddress";
		this.lblAddress.Size = new System.Drawing.Size(420, 26);
		this.lblAddress.TabIndex = 187;
		this.lblAddress.Text = "lblAddress";
		this.cboBank.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboBank.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboBank.FormattingEnabled = true;
		this.cboBank.Location = new System.Drawing.Point(85, 198);
		this.cboBank.Name = "cboBank";
		this.cboBank.Size = new System.Drawing.Size(116, 21);
		this.cboBank.TabIndex = 6;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(10, 201);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(32, 13);
		this.Label1.TabIndex = 189;
		this.Label1.Text = "Bank";
		this.txtAmount.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtAmount.DontFormat = false;
		this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtAmount.Location = new System.Drawing.Point(85, 225);
		this.txtAmount.MaximumDigit = 3;
		this.txtAmount.Name = "txtAmount";
		this.txtAmount.Size = new System.Drawing.Size(116, 26);
		this.txtAmount.TabIndex = 7;
		this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.Label14.AutoSize = true;
		this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label14.Location = new System.Drawing.Point(10, 122);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(46, 13);
		this.Label14.TabIndex = 193;
		this.Label14.Text = "Penagih";
		this.cboSalesPerson.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboSalesPerson.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboSalesPerson.FormattingEnabled = true;
		this.cboSalesPerson.Location = new System.Drawing.Point(85, 119);
		this.cboSalesPerson.Name = "cboSalesPerson";
		this.cboSalesPerson.Size = new System.Drawing.Size(116, 21);
		this.cboSalesPerson.TabIndex = 3;
		this.lblNote.AutoSize = true;
		this.lblNote.ForeColor = System.Drawing.Color.Red;
		this.lblNote.Location = new System.Drawing.Point(13, 389);
		this.lblNote.Name = "lblNote";
		this.lblNote.Size = new System.Drawing.Size(40, 13);
		this.lblNote.TabIndex = 194;
		this.lblNote.Text = "lblNote";
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(763, 414);
		base.Controls.Add(this.lblNote);
		base.Controls.Add(this.Label14);
		base.Controls.Add(this.cboSalesPerson);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.cboBank);
		base.Controls.Add(this.btnSearch);
		base.Controls.Add(this.lblAddress);
		base.Controls.Add(this.lblName);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.lblAccount);
		base.Controls.Add(this.cboAccount);
		base.Controls.Add(this.Label8);
		base.Controls.Add(this.txtDescription);
		base.Controls.Add(this.btnSaveClose);
		base.Controls.Add(this.btnHistory);
		base.Controls.Add(this.Label12);
		base.Controls.Add(this.lblRemain);
		base.Controls.Add(this.btnDelete);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.Label11);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.lblTotalAllocation);
		base.Controls.Add(this.txtAmount);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.txtChequeNo);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.dtpCheque);
		base.Controls.Add(this.Label9);
		base.Controls.Add(this.dtpPayment);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.cboPaymentCode);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.dgvList);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmCustomerPayment";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Pembayaran Customer - Input";
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmCustomerPayment()
	{
		base.KeyDown += frmPayment_KeyDown;
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
					base.MdiParent = MyProject.Forms.frmMenu;
					DoubleBuffered = true;
					txtAmount.AllowedCharacters = FilteredTextBox.InputType.NumeralsAndCurrency;
					txtAmount.MaximumDigit = 2;
					ComboBox combo = cboBank;
					cCombo.getBank(ref combo, All: false, Active: true);
					cboBank = combo;
					combo = cboPaymentCode;
					cCombo.getPaymentCode(ref combo, All: false, ShowCheque: true);
					cboPaymentCode = combo;
					FormatGrid();
					goto end_IL_001b;
				}
				case 182:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmCustomerPayment", "New", "");
						goto end_IL_001b;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try001b_dispatch = 182;
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

	public void PrepareForm(bool SaveNew)
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
					_currentId = 0.0;
					_customerId = 0.0;
					btnSearch.Visible = true;
					if (!SaveNew)
					{
						dtpPayment.Value = DateAndTime.Now;
						cboPaymentCode.SelectedIndex = -1;
					}
					cboPaymentCode.Enabled = true;
					txtAmount.Enabled = true;
					dtpCheque.Enabled = true;
					txtChequeNo.Enabled = true;
					cboBank.Enabled = true;
					cboSalesPerson.SelectedIndex = -1;
					cboAccount.SelectedIndex = -1;
					cboBank.SelectedIndex = -1;
					dtpCheque.Enabled = false;
					txtChequeNo.Enabled = false;
					txtAmount.Text = "";
					lblTotalAllocation.Text = "0";
					lblRemain.Text = "0";
					txtDescription.Text = "";
					lblNote.Text = "";
					_chequeDepositDate = DateTime.MinValue;
					_chequeClearingDate = DateTime.MinValue;
					dtpPayment.Enabled = true;
					btnDelete.Enabled = false;
					btnHistory.Enabled = false;
					lblName.Text = "";
					lblAddress.Text = "";
					dgvList.Rows.Clear();
					btnSearch.Focus();
					goto end_IL_0001;
				case 463:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmCustomerPayment", "PrepareForm", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 463;
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
					cSalesInvoiceMultiPayment cSalesInvoiceMultiPayment2 = new cSalesInvoiceMultiPayment(_currentId);
					_customerId = cSalesInvoiceMultiPayment2.CustomerId;
					_cashAccountId = cSalesInvoiceMultiPayment2.CashAccountId;
					_bankAccountId = cSalesInvoiceMultiPayment2.BankAccountId;
					ComboBox combo = cboSalesPerson;
					cCombo.getSalesPerson(ref combo, "ALL", 0, 0, cSalesInvoiceMultiPayment2.BranchId, Module1.pubGroupId, All: false, Dash: false, -1);
					cboSalesPerson = combo;
					lblName.Text = cSalesInvoiceMultiPayment2.CustomerName;
					lblAddress.Text = cSalesInvoiceMultiPayment2.CustomerAddress;
					btnSearch.Visible = false;
					dtpPayment.Value = cSalesInvoiceMultiPayment2.PaymentDate;
					combo = cboPaymentCode;
					Module1.comboBoundValue(ref combo, (int)cSalesInvoiceMultiPayment2.PaymentCodeId);
					cboPaymentCode = combo;
					txtAmount.Text = Module1.formatCustomDecimal(Conversions.ToString(cSalesInvoiceMultiPayment2.Amount), 2);
					txtDescription.Text = cSalesInvoiceMultiPayment2.Description;
					combo = cboSalesPerson;
					Module1.comboBoundValue(ref combo, cSalesInvoiceMultiPayment2.SalesPersonId);
					cboSalesPerson = combo;
					combo = cboAccount;
					Module1.comboBoundValue(ref combo, cSalesInvoiceMultiPayment2.AccountId);
					cboAccount = combo;
					combo = cboBank;
					Module1.comboBoundValue(ref combo, cSalesInvoiceMultiPayment2.BankId);
					cboBank = combo;
					if (Operators.CompareString(cSalesInvoiceMultiPayment2.PaymentCodeName, "C/G", TextCompare: false) == 0)
					{
						txtChequeNo.Text = cSalesInvoiceMultiPayment2.ChequeNumber;
						dtpCheque.Value = cSalesInvoiceMultiPayment2.ChequeDate;
						_chequeDepositDate = cSalesInvoiceMultiPayment2.ChequeDepositDate;
						_chequeClearingDate = cSalesInvoiceMultiPayment2.ChequeClearingDate;
					}
					if (DateTime.Compare(_chequeDepositDate, DateTime.MinValue) > 0)
					{
						lblNote.Text = "Detail Cek/Giro tidak bisa di-edit karena telah disetor.";
						cboPaymentCode.Enabled = false;
						dtpCheque.Enabled = false;
						txtChequeNo.Enabled = false;
						cboBank.Enabled = false;
						txtAmount.Enabled = false;
					}
					else
					{
						cboPaymentCode.Enabled = true;
						txtAmount.Enabled = true;
						if (Operators.CompareString(cSalesInvoiceMultiPayment2.PaymentCodeName, "C/G", TextCompare: false) == 0)
						{
							dtpCheque.Enabled = true;
							txtChequeNo.Enabled = true;
							cboBank.Enabled = true;
						}
					}
					dgvList.Rows.Clear();
					cSalesInvoicePayment[] allocation = cSalesInvoiceMultiPayment2.Allocation;
					foreach (cSalesInvoicePayment cSalesInvoicePayment2 in allocation)
					{
						dgvList.Rows.Add(cSalesInvoicePayment2.InvoiceId, TriState.True, cSalesInvoicePayment2.InvoiceDate, cSalesInvoicePayment2.InvoiceNumber, Module1.formatCustomDecimal(Conversions.ToString(cSalesInvoicePayment2.InvoiceReceivable), 2), Module1.formatCustomDecimal(Conversions.ToString(cSalesInvoicePayment2.Amount), 2), Module1.formatCustomDecimal(Conversions.ToString(cSalesInvoicePayment2.InvoiceReceivable + cSalesInvoicePayment2.Amount), 2));
					}
					GetUnpaid();
					btnHistory.Enabled = true;
					if (DateAndTime.DateDiff(DateInterval.Day, dtpPayment.Value, DateAndTime.Now) <= Module1.pubDaysLimit)
					{
						dtpPayment.Enabled = true;
					}
					else
					{
						dtpPayment.Enabled = false;
					}
					if (DateAndTime.DateDiff(DateInterval.Day, cSalesInvoiceMultiPayment2.PaymentDate, DateAndTime.Now) <= Module1.pubDaysLimitForCustomerPayment)
					{
						btnSave.Enabled = true;
						btnSaveClose.Enabled = true;
						btnDelete.Enabled = true;
					}
					else
					{
						btnSave.Enabled = false;
						btnSaveClose.Enabled = false;
						btnDelete.Enabled = false;
						dtpPayment.Enabled = false;
						lblNote.Text = "Anda tidak bisa menyimpan/menghapus pembayaran sebelum " + Strings.FormatDateTime(DateAndTime.Now.AddDays(checked(Module1.pubDaysLimitForCustomerPayment * -1)), DateFormat.ShortDate);
					}
					goto end_IL_0001;
				}
				case 1173:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmCustomerPayment", "LoadData", "");
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
				try0001_dispatch = 1173;
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

	private void FormatGrid()
	{
		DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
		dgvList.Columns.Add("", "ID");
		dgvList.Columns.Add(dataGridViewCheckBoxColumn);
		dataGridViewCheckBoxColumn.HeaderText = "Alokasi";
		dataGridViewCheckBoxColumn.Name = "chk";
		dgvList.Columns.Add("", "Tanggal");
		dgvList.Columns.Add("", "No. Faktur");
		dgvList.Columns.Add("", "Piutang");
		dgvList.Columns.Add("", "Jumlah Alokasi");
		dgvList.Columns.Add("", "OriginalPiutang");
		dgvList.Columns.Add("", "TukarFaktur");
		dgvList.Columns[0].Visible = false;
		dgvList.Columns[6].Visible = false;
		dgvList.Columns[7].Visible = false;
		dgvList.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvList.Columns[2].ReadOnly = true;
		dgvList.Columns[3].ReadOnly = true;
		dgvList.Columns[4].ReadOnly = true;
		dgvList.Columns[5].ReadOnly = false;
		dgvList.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[1].Width = 60;
		dgvList.Columns[2].Width = 100;
		dgvList.Columns[3].Width = 100;
		dgvList.Columns[4].Width = 80;
		dgvList.Columns[5].Width = 100;
		dgvList.RowHeadersVisible = false;
		dgvList.AllowUserToAddRows = false;
		dgvList.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvList.AllowUserToResizeRows = false;
		dgvList.EditMode = DataGridViewEditMode.EditOnEnter;
	}

	private void frmPayment_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void btnSearch_Click(object sender, EventArgs e)
	{
		frmCustomerMiniSearch frmCustomerMiniSearch2 = new frmCustomerMiniSearch();
		frmCustomerMiniSearch2.CallerName = "CustomerPayment";
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
		_cashAccountId = cCustomer2.CashAccountId;
		_bankAccountId = cCustomer2.BankAccountId;
		lblName.Text = cCustomer2.Name;
		lblAddress.Text = cCustomer2.Address;
		dgvList.Rows.Clear();
		GetUnpaid();
		ComboBox combo = cboSalesPerson;
		cCombo.getSalesPerson(ref combo, "ALL", 0, 0, cCustomer2.BranchId, Module1.pubGroupId, All: false, Dash: false, -1);
		cboSalesPerson = combo;
		combo = cboSalesPerson;
		Module1.comboBoundValue(ref combo, cCustomer2.SalesPersonId);
		cboSalesPerson = combo;
		dtpPayment.Focus();
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

	private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
					dgvList.EndEdit();
					if (e.ColumnIndex != 1)
					{
						goto end_IL_0001;
					}
					if (Operators.ConditionalCompareObjectEqual(dgvList[1, dgvList.CurrentRow.Index].Value, true, TextCompare: false))
					{
						cComboItem cComboItem2 = (cComboItem)cboSalesPerson.SelectedItem;
						if (Conversion.Val(RuntimeHelpers.GetObjectValue(dgvList[7, dgvList.CurrentRow.Index].Value)) > 0.0 && Conversion.Val(RuntimeHelpers.GetObjectValue(dgvList[7, dgvList.CurrentRow.Index].Value)) != Conversions.ToDouble(cComboItem2.Value))
						{
							Interaction.MsgBox("Penagih berbeda dengan Penukar Faktur.", MsgBoxStyle.Information);
						}
						dgvList[1, dgvList.CurrentRow.Index].Value = true;
						TickAllocation();
					}
					else
					{
						dgvList[1, dgvList.CurrentRow.Index].Value = false;
						UntickAllocation();
					}
					goto end_IL_0001_2;
				case 379:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmCustomerPayment", "dgvList_CellContentClick", "");
						goto end_IL_0001_2;
					}
					break;
				}
				goto IL_01b1;
				end_IL_0001_2:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 379;
				continue;
			}
			break;
			IL_01b1:
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

	private void dgvList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.ColumnIndex != 1)
		{
			return;
		}
		if (Operators.ConditionalCompareObjectEqual(dgvList[1, dgvList.CurrentRow.Index].Value, true, TextCompare: false))
		{
			dgvList[1, dgvList.CurrentRow.Index].Value = false;
			UntickAllocation();
			return;
		}
		cComboItem cComboItem2 = (cComboItem)cboSalesPerson.SelectedItem;
		if (Conversion.Val(RuntimeHelpers.GetObjectValue(dgvList[7, dgvList.CurrentRow.Index].Value)) > 0.0 && Conversion.Val(RuntimeHelpers.GetObjectValue(dgvList[7, dgvList.CurrentRow.Index].Value)) != Conversions.ToDouble(cComboItem2.Value))
		{
			Interaction.MsgBox("Penagih berbeda dengan Penukar Faktur.", MsgBoxStyle.Information);
		}
		dgvList[1, dgvList.CurrentRow.Index].Value = true;
		TickAllocation();
	}

	private void dgvList_GotFocus(object sender, EventArgs e)
	{
		if ((dgvList.RowCount > 0) & !_dontFocus)
		{
			dgvList.CurrentCell.Selected = true;
		}
		else
		{
			_dontFocus = false;
		}
	}

	private void dgvList_LostFocus(object sender, EventArgs e)
	{
		if (dgvList.RowCount > 0)
		{
			dgvList.CurrentRow.Selected = false;
		}
	}

	private void dgvList_KeyDown(object sender, KeyEventArgs e)
	{
		if ((e.KeyCode != Keys.Space || !Operators.ConditionalCompareObjectEqual(dgvList[1, dgvList.CurrentRow.Index].Value, true, TextCompare: false)) && e.KeyCode != Keys.Space)
		{
			if (e.KeyCode == Keys.Return)
			{
				openSelection();
				e.SuppressKeyPress = true;
			}
			else if (e.Shift & (e.KeyCode == Keys.Tab))
			{
				cboAccount.Focus();
				e.SuppressKeyPress = true;
			}
			else if (e.KeyCode == Keys.Tab)
			{
				btnSave.Focus();
				e.SuppressKeyPress = true;
			}
		}
	}

	private void UntickAllocation()
	{
		dgvList[4, dgvList.CurrentRow.Index].Value = RuntimeHelpers.GetObjectValue(dgvList[6, dgvList.CurrentRow.Index].Value);
		dgvList[5, dgvList.CurrentRow.Index].Value = 0;
		dgvList.Rows[dgvList.CurrentRow.Index].Cells[5].ReadOnly = true;
		CalculateAllocation();
	}

	private void TickAllocation()
	{
		dgvList[5, dgvList.CurrentRow.Index].Value = RuntimeHelpers.GetObjectValue(dgvList[4, dgvList.CurrentRow.Index].Value);
		dgvList[4, dgvList.CurrentRow.Index].Value = 0;
		dgvList.Rows[dgvList.CurrentRow.Index].Cells[5].ReadOnly = false;
		CalculateAllocation();
	}

	private void dgvList_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
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
					if (e.ColumnIndex >= 5 && !dgvList.Rows[e.RowIndex].IsNewRow)
					{
						if (Operators.CompareString(Strings.Trim(e.FormattedValue.ToString()), "", TextCompare: false) != 0 && !Versioned.IsNumeric(e.FormattedValue.ToString()))
						{
							e.Cancel = true;
							Interaction.MsgBox("Masukkan jumlah alokasi dengan format angka yang benar", MsgBoxStyle.Information);
						}
						else if (Operators.CompareString(Strings.Trim(Conversions.ToString(e.FormattedValue)), "", TextCompare: false) != 0 && Operators.ConditionalCompareObjectLess(Operators.SubtractObject(dgvList[6, dgvList.CurrentRow.Index].Value, e.FormattedValue), 0, TextCompare: false))
						{
							e.Cancel = true;
							Interaction.MsgBox("Sisa piutang tidak boleh dibawah 0", MsgBoxStyle.Information);
						}
						else if (Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)) > 0.0)
						{
							dgvList[4, dgvList.CurrentRow.Index].Value = Operators.SubtractObject(dgvList[6, dgvList.CurrentRow.Index].Value, Conversions.ToDouble(e.FormattedValue));
							_dontFocus = true;
						}
					}
					goto end_IL_0001;
				case 432:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmCustomerPayment", "dgvList_CellValidating", "");
						goto end_IL_0001;
					}
					break;
				}
				goto IL_01e6;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 432;
				continue;
			}
			break;
			IL_01e6:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void dgvList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
		if (((e.ColumnIndex == 5) & (dgvList.CurrentRow.Index > 0)) && Conversion.Val(RuntimeHelpers.GetObjectValue(e.Value)) > 0.0)
		{
			e.Value = Module1.formatCustomDecimal(Conversions.ToString(e.Value), 2);
		}
	}

	private void dgvList_DoubleClick(object sender, EventArgs e)
	{
		openSelection();
	}

	private void openSelection()
	{
		if (dgvList.RowCount > 0 && Operators.ConditionalCompareObjectGreater(dgvList[0, dgvList.CurrentRow.Index].Value, 0, TextCompare: false) && dgvList.CurrentCell.ColumnIndex == 3)
		{
			MyProject.Forms.frmSalesInvoice.Show();
			MyProject.Forms.frmSalesInvoice.prepareForm(SaveNew: false);
			MyProject.Forms.frmSalesInvoice.CurrentId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
			MyProject.Forms.frmSalesInvoice.LoadData();
			MyProject.Forms.frmSalesInvoice.Activate();
			MyProject.Forms.frmSalesInvoice.WindowState = FormWindowState.Normal;
		}
	}

	private void CalculateAllocation()
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
						int num3 = dgvList.Rows.Count - 1;
						for (int i = 0; i <= num3; i++)
						{
							if (Operators.ConditionalCompareObjectEqual(dgvList[1, i].EditedFormattedValue, true, TextCompare: false))
							{
								num4 += Conversions.ToDouble(dgvList[5, i].Value);
							}
						}
						lblTotalAllocation.Text = Module1.formatCustomDecimal(Conversions.ToString(num4), 2);
						double num5 = ((Operators.CompareString(txtAmount.Text, "", TextCompare: false) != 0) ? Conversions.ToDouble(txtAmount.Text) : 0.0);
						lblRemain.Text = Module1.formatCustomDecimal(Conversions.ToString(num5 - num4), 2);
						goto end_IL_0001;
					}
					case 254:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmCustomerPayment", "CalculateAllocation", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 254;
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

	private void GetUnpaid()
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
						DataTable dataTable = cSalesInvoice.SearchUnpaid((int)Math.Round(_customerId));
						int count = dgvList.Rows.Count;
						IEnumerator enumerator = dataTable.Rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							DataGridView dataGridView = dgvList;
							bool num3 = IsInDataGridView(ref dataGridView, Conversions.ToString(dataRow["penjId"]), 0, count);
							dgvList = dataGridView;
							if (!num3)
							{
								dgvList.Rows.Add(dataRow["penjId"], 0, dataRow["penjDate"], dataRow["penjFaktur"], Module1.formatCustomDecimal(Conversions.ToString(dataRow["Receivable"]), 2), 0, Module1.formatCustomDecimal(Conversions.ToString(dataRow["Receivable"]), 2), dataRow["penjTf"]);
								dgvList.Rows[dgvList.RowCount - 1].Cells[5].ReadOnly = true;
							}
						}
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
						if (dgvList.Rows.Count > 0)
						{
							dgvList.CurrentRow.Selected = false;
						}
						CalculateAllocation();
						goto end_IL_0001;
					}
					case 457:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmCustomerPayment", "GetUnpaid", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 457;
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

	public bool IsInDataGridView(ref DataGridView dgvList, string SearchValue, int Column, int MaxRow)
	{
		bool result = false;
		checked
		{
			int num = MaxRow - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Operators.CompareString(Strings.Trim(Conversion.Str(RuntimeHelpers.GetObjectValue(dgvList[Column, i].Value))), SearchValue, TextCompare: false) == 0)
				{
					result = true;
					break;
				}
			}
			return result;
		}
	}

	private void cboPaymentCode_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(cboPaymentCode.Text, "C/G", TextCompare: false) == 0)
		{
			txtChequeNo.Enabled = true;
			dtpCheque.Enabled = true;
			cboBank.Enabled = true;
		}
		else
		{
			txtChequeNo.Text = "";
			txtChequeNo.Enabled = false;
			dtpCheque.Enabled = false;
			cboBank.Enabled = false;
		}
		if (Operators.CompareString(cboPaymentCode.Text, "Cash", TextCompare: false) == 0)
		{
			ComboBox combo = cboAccount;
			cCombo.getCashAccount(ref combo, 0, Module1.pubGroupId, All: false, GroupDefault: false, Active: true, "GENERAL", 1);
			cboAccount = combo;
			combo = cboAccount;
			Module1.comboBoundValue(ref combo, _cashAccountId);
			cboAccount = combo;
			lblAccount.Text = "Kas";
		}
		else
		{
			ComboBox combo = cboAccount;
			cCombo.getBankAccount(ref combo, 0, Module1.pubGroupId, All: false, GroupDefault: false, Active: true, "GENERAL", 1);
			cboAccount = combo;
			combo = cboAccount;
			Module1.comboBoundValue(ref combo, _bankAccountId);
			cboAccount = combo;
			lblAccount.Text = "Rekening";
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
		int num4 = default(int);
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
						cComboItem cComboItem2 = (cComboItem)cboPaymentCode.SelectedItem;
						cComboItem cComboItem3 = (cComboItem)cboSalesPerson.SelectedItem;
						cComboItem cComboItem4 = (cComboItem)cboAccount.SelectedItem;
						cComboItem cComboItem5 = (cComboItem)cboBank.SelectedItem;
						if (_customerId == 0.0)
						{
							Interaction.MsgBox("Pilih customer", MsgBoxStyle.Information);
							btnSearch.Focus();
							goto end_IL_0001;
						}
						if (cboPaymentCode.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih tipe pembayaran", MsgBoxStyle.Information);
							cboPaymentCode.Focus();
							goto end_IL_0001;
						}
						if (!cValidation.isDateWithinRange(dtpPayment.Value, Module1.pubGroupId, Module1.pubDaysLimitForCustomerPayment))
						{
							Interaction.MsgBox("Tanggal diluar batas yang diperbolehkan", MsgBoxStyle.Information);
							dtpPayment.Focus();
							goto end_IL_0001;
						}
						if (cboSalesPerson.SelectedIndex == -1)
						{
							Interaction.MsgBox("Masukkan penagih.", MsgBoxStyle.Information);
							cboSalesPerson.Focus();
							goto end_IL_0001;
						}
						if (Conversion.Val(txtAmount.Text) == 0.0)
						{
							Interaction.MsgBox("Masukkan jumlah pembayaran", MsgBoxStyle.Information);
							txtAmount.Focus();
							goto end_IL_0001;
						}
						if (!Versioned.IsNumeric(txtAmount.Text))
						{
							Interaction.MsgBox("Masukkan jumlah dengan format angka yang benar", MsgBoxStyle.Information);
							txtAmount.Focus();
							goto end_IL_0001;
						}
						if ((Operators.CompareString(cboPaymentCode.Text, "C/G", TextCompare: false) == 0) & (Operators.CompareString(txtChequeNo.Text, "", TextCompare: false) == 0))
						{
							Interaction.MsgBox("Masukkan nomer Cek/Giro", MsgBoxStyle.Information);
							txtChequeNo.Focus();
							goto end_IL_0001;
						}
						if ((Operators.CompareString(cboPaymentCode.Text, "C/G", TextCompare: false) == 0) & (cboBank.SelectedIndex == -1))
						{
							Interaction.MsgBox("Pilih bank.", MsgBoxStyle.Information);
							cboBank.Focus();
							goto end_IL_0001;
						}
						if (Conversions.ToDouble(txtAmount.Text) < Conversions.ToDouble(lblTotalAllocation.Text))
						{
							Interaction.MsgBox("Jumlah bayar harus lebih besar dari total alokasi", MsgBoxStyle.Information);
							txtAmount.Focus();
							goto end_IL_0001;
						}
						if (cboAccount.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih Kas/Rekening", MsgBoxStyle.Information);
							cboAccount.Focus();
							goto end_IL_0001;
						}
						Cursor = Cursors.WaitCursor;
						cSalesInvoiceMultiPayment cSalesInvoiceMultiPayment2 = new cSalesInvoiceMultiPayment(0.0);
						cSalesInvoiceMultiPayment2.MultiPaymentId = _currentId;
						cSalesInvoiceMultiPayment2.CustomerId = _customerId;
						cSalesInvoiceMultiPayment2.PaymentDate = dtpPayment.Value;
						cSalesInvoiceMultiPayment2.PaymentCodeId = Conversions.ToByte(cComboItem2.Value);
						cSalesInvoiceMultiPayment2.PaymentCodeName = cboPaymentCode.Text;
						cSalesInvoiceMultiPayment2.SalesPersonId = Conversions.ToInteger(cComboItem3.Value);
						cSalesInvoiceMultiPayment2.Amount = Conversions.ToDouble(txtAmount.Text);
						cSalesInvoiceMultiPayment2.Description = txtDescription.Text;
						cSalesInvoiceMultiPayment2.BankId = Conversions.ToInteger((cboBank.SelectedIndex > -1) ? cComboItem5.Value : ((object)0));
						cSalesInvoiceMultiPayment2.AccountId = Conversions.ToInteger(cComboItem4.Value);
						cSalesInvoiceMultiPayment2.AllocatedAmount = Conversions.ToDouble(lblTotalAllocation.Text);
						if (Operators.CompareString(cboPaymentCode.Text, "C/G", TextCompare: false) == 0)
						{
							cSalesInvoiceMultiPayment2.ChequeDate = dtpCheque.Value;
							cSalesInvoiceMultiPayment2.ChequeNumber = txtChequeNo.Text;
							cSalesInvoiceMultiPayment2.ChequeDepositDate = _chequeDepositDate;
							cSalesInvoiceMultiPayment2.ChequeClearingDate = _chequeClearingDate;
						}
						cSalesInvoicePayment[] array = null;
						string text = "";
						int num3 = dgvList.Rows.Count - 1;
						for (int i = 0; i <= num3; i++)
						{
							if (Operators.ConditionalCompareObjectEqual(dgvList[1, i].Value, true, TextCompare: false))
							{
								array = (cSalesInvoicePayment[])Utils.CopyArray(array, new cSalesInvoicePayment[num4 + 1]);
								array[num4] = new cSalesInvoicePayment();
								array[num4].InvoiceId = Conversions.ToDouble(dgvList[0, i].Value);
								array[num4].Amount = Conversions.ToDouble(dgvList[5, i].Value);
								num4++;
								text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<tr><td>", dgvList[2, i].Value), "</td>"), "<td>"), dgvList[3, i].Value), "</td>"), "<td align='right'>"), Module1.formatCustomDecimal(Conversions.ToString(dgvList[5, i].Value), 2)), "</td></tr>")));
							}
						}
						cSalesInvoiceMultiPayment2.Allocation = array;
						cSalesInvoiceMultiPayment2.Save();
						string text2 = "Tanggal: " + Conversions.ToString(dtpPayment.Value) + "<br />Tipe: " + cboPaymentCode.Text + "<br />Tgl C/G: " + Conversions.ToString(dtpCheque.Value) + "<br />No C/G: " + txtChequeNo.Text + "<br />Bank: " + cboBank.Text + "<br />Jumlah: " + txtAmount.Text + "<br />Keterangan: " + Module1.cleanString(txtDescription.Text) + "<br />Kas/Rekening: " + cboAccount.Text + "<br /><br />";
						text2 += "Alokasi:<br />";
						text2 += "<table>";
						text2 += "<tr><td>Tanggal</td><td>No Faktur</td><td>Alokasi</td></tr>";
						text2 += text;
						text2 += "</table>";
						string text3;
						if (_currentId == 0.0)
						{
							text3 = "membuat ";
							_currentId = cSalesInvoiceMultiPayment2.MultiPaymentId;
						}
						else
						{
							text3 = "mengupdate ";
						}
						text3 = text3 + "pembayaran tanggal " + Strings.Format(dtpPayment.Value, "dd/MM/yyyy") + " untuk customer " + lblName.Text + ". ID= " + Conversions.ToString(_currentId) + ", v2";
						cHistory cHistory2 = new cHistory();
						cHistory2.Content = text2;
						cHistory2.Description = text3;
						cHistory2.UserId = Module1.pubUserId;
						cHistory2.UserLogin = Module1.pubLogin;
						cHistory2.fKeyId = _currentId;
						cHistory2.HistoryType = 22;
						cHistory2.Save();
						Cursor = Cursors.Default;
						Interaction.MsgBox("Pembayaran berhasil disimpan", MsgBoxStyle.Information);
						if (Module1.FormIsOpen("frmCustomerPaymentList"))
						{
							MyProject.Forms.frmCustomerPaymentList.GetRecent();
						}
						if (Module1.FormIsOpen("frmCustomer"))
						{
							MyProject.Forms.frmCustomer.GetPayment();
						}
						MyProject.Forms.frmInformation.GetActivity();
						if (CloseForm)
						{
							Close();
						}
						else
						{
							PrepareForm(SaveNew: true);
						}
						goto end_IL_0001;
					}
					case 2158:
						num = -1;
						switch (num2)
						{
						case 2:
							Cursor = Cursors.Default;
							Module1.SaveError(Information.Err(), "frmCustomerPayment", "SaveData", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 2158;
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
					if (MessageBox.Show("Hapus Pembayaran?", "Konfirmasi", MessageBoxButtons.YesNo) != DialogResult.No)
					{
						cSalesInvoiceMultiPayment cSalesInvoiceMultiPayment2 = new cSalesInvoiceMultiPayment(_currentId);
						cSalesInvoiceMultiPayment2.Delete();
						string description = "menghapus pembayaran tanggal " + Conversions.ToString(cSalesInvoiceMultiPayment2.PaymentDate) + " untuk customer " + cSalesInvoiceMultiPayment2.CustomerName + ". ID=" + Conversions.ToString(cSalesInvoiceMultiPayment2.MultiPaymentId) + ", v2";
						cHistory cHistory2 = new cHistory();
						cHistory2.Description = description;
						cHistory2.UserId = Module1.pubUserId;
						cHistory2.UserLogin = Module1.pubLogin;
						cHistory2.fKeyId = _currentId;
						cHistory2.HistoryType = 22;
						cHistory2.Save();
						Interaction.MsgBox("Pembayaran berhasil dihapus", MsgBoxStyle.Information);
						if (Module1.FormIsOpen("frmCustomerPaymentList"))
						{
							MyProject.Forms.frmCustomerPaymentList.GetRecent();
						}
						MyProject.Forms.frmInformation.GetActivity();
						Close();
					}
					goto end_IL_0001;
				case 317:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmCustomerPayment", "btnDelete_Click", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 317;
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
		MyProject.Forms.frmHistory.GetHistory(checked((int)Math.Round(_currentId)), 22);
		MyProject.Forms.frmHistory.Show();
		MyProject.Forms.frmHistory.Activate();
		MyProject.Forms.frmHistory.WindowState = FormWindowState.Normal;
	}

	private void dgvList_CellValidated(object sender, DataGridViewCellEventArgs e)
	{
		CalculateAllocation();
	}

	private void txtAmount_TextChanged(object sender, EventArgs e)
	{
		CalculateAllocation();
	}

	private void dtpPayment_ValueChanged(object sender, EventArgs e)
	{
		if (DateAndTime.DateDiff(DateInterval.Day, dtpPayment.Value, DateAndTime.Now) > Module1.pubDaysLimitForCustomerPayment)
		{
			btnSave.Enabled = false;
			btnSaveClose.Enabled = false;
			btnDelete.Enabled = false;
			lblNote.Text = "Anda tidak bisa menyimpan/menghapus pembayaran sebelum " + Strings.FormatDateTime(DateAndTime.Now.AddDays(checked(Module1.pubDaysLimitForCustomerPayment * -1)), DateFormat.ShortDate);
			return;
		}
		btnSave.Enabled = true;
		btnSaveClose.Enabled = true;
		lblNote.Text = "";
		if (_currentId > 0.0)
		{
			btnDelete.Enabled = true;
		}
	}
}
