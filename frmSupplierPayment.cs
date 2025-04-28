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
public class frmSupplierPayment : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvList")]
	private DataGridView _dgvList;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("txtAmount")]
	private FilteredTextBox _txtAmount;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboPaymentCode")]
	private ComboBox _cboPaymentCode;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboSupplier")]
	private ComboBox _cboSupplier;

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
	[AccessedThroughProperty("btnHistory")]
	private Button _btnHistory;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSaveClose")]
	private Button _btnSaveClose;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboAccount")]
	private ComboBox _cboAccount;

	private double _currentId;

	private bool _dontFocus;

	private bool _formIsJustLoaded;

	private int _invoiceCurrencyId;

	private int _cashAccountId;

	private int _bankAccountId;

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

	[field: AccessedThroughProperty("lblAmount")]
	internal virtual Label lblAmount
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkPayInFront")]
	internal virtual CheckBox chkPayInFront
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dtpPayment")]
	internal virtual DateTimePicker dtpPayment
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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
			EventHandler value3 = cboSupplier_SelectionChangeCommitted;
			ComboBox comboBox = _cboSupplier;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
				comboBox.SelectionChangeCommitted -= value3;
			}
			_cboSupplier = value;
			comboBox = _cboSupplier;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
				comboBox.SelectionChangeCommitted += value3;
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

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("Label12")]
	internal virtual Label Label12
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

	[field: AccessedThroughProperty("lblSupplier")]
	internal virtual Label lblSupplier
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

	[field: AccessedThroughProperty("txtDescription")]
	internal virtual TextBox txtDescription
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

	internal virtual ComboBox cboAccount
	{
		[CompilerGenerated]
		get
		{
			return _cboAccount;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cboCashAccount_SelectedIndexChanged;
			ComboBox comboBox = _cboAccount;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_cboAccount = value;
			comboBox = _cboAccount;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("lblCurrencyName")]
	internal virtual Label lblCurrencyName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCurrencyRate")]
	internal virtual FilteredTextBox txtCurrencyRate
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
		this.dgvList = new System.Windows.Forms.DataGridView();
		this.lblAmount = new System.Windows.Forms.Label();
		this.chkPayInFront = new System.Windows.Forms.CheckBox();
		this.txtChequeNo = new System.Windows.Forms.TextBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.dtpCheque = new System.Windows.Forms.DateTimePicker();
		this.Label9 = new System.Windows.Forms.Label();
		this.dtpPayment = new System.Windows.Forms.DateTimePicker();
		this.Label4 = new System.Windows.Forms.Label();
		this.cboPaymentCode = new System.Windows.Forms.ComboBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.cboSupplier = new System.Windows.Forms.ComboBox();
		this.lblTotalAllocation = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label11 = new System.Windows.Forms.Label();
		this.btnDelete = new System.Windows.Forms.Button();
		this.btnSave = new System.Windows.Forms.Button();
		this.Label12 = new System.Windows.Forms.Label();
		this.lblRemain = new System.Windows.Forms.Label();
		this.btnHistory = new System.Windows.Forms.Button();
		this.btnSaveClose = new System.Windows.Forms.Button();
		this.lblSupplier = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.txtDescription = new System.Windows.Forms.TextBox();
		this.lblAccount = new System.Windows.Forms.Label();
		this.cboAccount = new System.Windows.Forms.ComboBox();
		this.lblCurrencyName = new System.Windows.Forms.Label();
		this.Label14 = new System.Windows.Forms.Label();
		this.txtCurrencyRate = new GCUv2.FilteredTextBox();
		this.txtAmount = new GCUv2.FilteredTextBox();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		base.SuspendLayout();
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
		this.dgvList.Location = new System.Drawing.Point(286, 11);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(474, 277);
		this.dgvList.TabIndex = 8;
		this.lblAmount.AutoSize = true;
		this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblAmount.Location = new System.Drawing.Point(10, 172);
		this.lblAmount.Name = "lblAmount";
		this.lblAmount.Size = new System.Drawing.Size(43, 13);
		this.lblAmount.TabIndex = 109;
		this.lblAmount.Text = "Jumlah ";
		this.chkPayInFront.AutoSize = true;
		this.chkPayInFront.Location = new System.Drawing.Point(97, 90);
		this.chkPayInFront.Name = "chkPayInFront";
		this.chkPayInFront.Size = new System.Drawing.Size(45, 17);
		this.chkPayInFront.TabIndex = 3;
		this.chkPayInFront.Text = "Bon";
		this.chkPayInFront.UseVisualStyleBackColor = true;
		this.txtChequeNo.Location = new System.Drawing.Point(96, 139);
		this.txtChequeNo.Name = "txtChequeNo";
		this.txtChequeNo.Size = new System.Drawing.Size(116, 20);
		this.txtChequeNo.TabIndex = 5;
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(10, 115);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(69, 13);
		this.Label3.TabIndex = 108;
		this.Label3.Text = "Tanggal C/G";
		this.dtpCheque.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpCheque.Location = new System.Drawing.Point(96, 113);
		this.dtpCheque.Name = "dtpCheque";
		this.dtpCheque.Size = new System.Drawing.Size(116, 20);
		this.dtpCheque.TabIndex = 4;
		this.Label9.AutoSize = true;
		this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label9.Location = new System.Drawing.Point(10, 13);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(46, 13);
		this.Label9.TabIndex = 107;
		this.Label9.Text = "Tanggal";
		this.dtpPayment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpPayment.Location = new System.Drawing.Point(96, 10);
		this.dtpPayment.Name = "dtpPayment";
		this.dtpPayment.Size = new System.Drawing.Size(116, 20);
		this.dtpPayment.TabIndex = 0;
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(10, 66);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(28, 13);
		this.Label4.TabIndex = 106;
		this.Label4.Text = "Tipe";
		this.cboPaymentCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboPaymentCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboPaymentCode.FormattingEnabled = true;
		this.cboPaymentCode.Location = new System.Drawing.Point(96, 63);
		this.cboPaymentCode.Name = "cboPaymentCode";
		this.cboPaymentCode.Size = new System.Drawing.Size(116, 21);
		this.cboPaymentCode.TabIndex = 2;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(10, 142);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(44, 13);
		this.Label2.TabIndex = 105;
		this.Label2.Text = "No C/G";
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(10, 91);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(26, 13);
		this.Label1.TabIndex = 104;
		this.Label1.Text = "Bon";
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.Location = new System.Drawing.Point(10, 39);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(45, 13);
		this.Label7.TabIndex = 111;
		this.Label7.Text = "Supplier";
		this.cboSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboSupplier.FormattingEnabled = true;
		this.cboSupplier.Location = new System.Drawing.Point(96, 36);
		this.cboSupplier.Name = "cboSupplier";
		this.cboSupplier.Size = new System.Drawing.Size(174, 21);
		this.cboSupplier.TabIndex = 1;
		this.lblTotalAllocation.Location = new System.Drawing.Point(357, 297);
		this.lblTotalAllocation.Name = "lblTotalAllocation";
		this.lblTotalAllocation.Size = new System.Drawing.Size(87, 13);
		this.lblTotalAllocation.TabIndex = 112;
		this.lblTotalAllocation.Text = "lblTotalAllocation";
		this.lblTotalAllocation.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(283, 297);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(68, 13);
		this.Label6.TabIndex = 113;
		this.Label6.Text = "Total Alokasi";
		this.Label11.BackColor = System.Drawing.Color.Silver;
		this.Label11.Location = new System.Drawing.Point(-6, 344);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(794, 51);
		this.Label11.TabIndex = 118;
		this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDelete.Location = new System.Drawing.Point(645, 353);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new System.Drawing.Size(58, 24);
		this.btnDelete.TabIndex = 11;
		this.btnDelete.Text = "Hapus";
		this.btnDelete.UseVisualStyleBackColor = true;
		this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
		this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
		this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(452, 353);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(88, 24);
		this.btnSave.TabIndex = 9;
		this.btnSave.Text = "&Simpan && Baru";
		this.btnSave.UseVisualStyleBackColor = true;
		this.Label12.AutoSize = true;
		this.Label12.Location = new System.Drawing.Point(283, 316);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(27, 13);
		this.Label12.TabIndex = 122;
		this.Label12.Text = "Sisa";
		this.lblRemain.Location = new System.Drawing.Point(357, 317);
		this.lblRemain.Name = "lblRemain";
		this.lblRemain.Size = new System.Drawing.Size(87, 13);
		this.lblRemain.TabIndex = 121;
		this.lblRemain.Text = "lblRemain";
		this.lblRemain.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnHistory.Location = new System.Drawing.Point(709, 353);
		this.btnHistory.Name = "btnHistory";
		this.btnHistory.Size = new System.Drawing.Size(50, 24);
		this.btnHistory.TabIndex = 12;
		this.btnHistory.Text = "&History";
		this.btnHistory.UseVisualStyleBackColor = true;
		this.btnSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSaveClose.Location = new System.Drawing.Point(546, 353);
		this.btnSaveClose.Name = "btnSaveClose";
		this.btnSaveClose.Size = new System.Drawing.Size(93, 24);
		this.btnSaveClose.TabIndex = 10;
		this.btnSaveClose.Text = "Simpan && &Tutup";
		this.btnSaveClose.UseVisualStyleBackColor = true;
		this.lblSupplier.AutoSize = true;
		this.lblSupplier.Location = new System.Drawing.Point(96, 39);
		this.lblSupplier.Name = "lblSupplier";
		this.lblSupplier.Size = new System.Drawing.Size(55, 13);
		this.lblSupplier.TabIndex = 127;
		this.lblSupplier.Text = "lblSupplier";
		this.Label8.AutoSize = true;
		this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label8.Location = new System.Drawing.Point(10, 200);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(62, 13);
		this.Label8.TabIndex = 129;
		this.Label8.Text = "Keterangan";
		this.txtDescription.AcceptsReturn = true;
		this.txtDescription.Location = new System.Drawing.Point(96, 197);
		this.txtDescription.MaxLength = 100;
		this.txtDescription.Multiline = true;
		this.txtDescription.Name = "txtDescription";
		this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
		this.txtDescription.Size = new System.Drawing.Size(139, 52);
		this.txtDescription.TabIndex = 7;
		this.lblAccount.AutoSize = true;
		this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblAccount.Location = new System.Drawing.Point(10, 258);
		this.lblAccount.Name = "lblAccount";
		this.lblAccount.Size = new System.Drawing.Size(76, 13);
		this.lblAccount.TabIndex = 132;
		this.lblAccount.Text = "Kas/Rekening";
		this.cboAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboAccount.FormattingEnabled = true;
		this.cboAccount.Location = new System.Drawing.Point(96, 255);
		this.cboAccount.Name = "cboAccount";
		this.cboAccount.Size = new System.Drawing.Size(121, 21);
		this.cboAccount.TabIndex = 8;
		this.lblCurrencyName.AutoSize = true;
		this.lblCurrencyName.Location = new System.Drawing.Point(34, 287);
		this.lblCurrencyName.Name = "lblCurrencyName";
		this.lblCurrencyName.Size = new System.Drawing.Size(60, 13);
		this.lblCurrencyName.TabIndex = 179;
		this.lblCurrencyName.Text = "Mata Uang";
		this.Label14.AutoSize = true;
		this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label14.Location = new System.Drawing.Point(10, 287);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(28, 13);
		this.Label14.TabIndex = 177;
		this.Label14.Text = "Kurs";
		this.txtCurrencyRate.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtCurrencyRate.DontFormat = false;
		this.txtCurrencyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtCurrencyRate.Location = new System.Drawing.Point(96, 282);
		this.txtCurrencyRate.MaximumDigit = 3;
		this.txtCurrencyRate.Name = "txtCurrencyRate";
		this.txtCurrencyRate.Size = new System.Drawing.Size(121, 26);
		this.txtCurrencyRate.TabIndex = 10;
		this.txtCurrencyRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.txtAmount.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtAmount.DontFormat = false;
		this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtAmount.Location = new System.Drawing.Point(96, 165);
		this.txtAmount.MaximumDigit = 3;
		this.txtAmount.Name = "txtAmount";
		this.txtAmount.Size = new System.Drawing.Size(116, 26);
		this.txtAmount.TabIndex = 6;
		this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(774, 384);
		base.Controls.Add(this.lblCurrencyName);
		base.Controls.Add(this.txtCurrencyRate);
		base.Controls.Add(this.Label14);
		base.Controls.Add(this.lblAccount);
		base.Controls.Add(this.cboAccount);
		base.Controls.Add(this.Label8);
		base.Controls.Add(this.txtDescription);
		base.Controls.Add(this.lblSupplier);
		base.Controls.Add(this.btnSaveClose);
		base.Controls.Add(this.btnHistory);
		base.Controls.Add(this.Label12);
		base.Controls.Add(this.lblRemain);
		base.Controls.Add(this.btnDelete);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.Label11);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.lblTotalAllocation);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.cboSupplier);
		base.Controls.Add(this.txtAmount);
		base.Controls.Add(this.lblAmount);
		base.Controls.Add(this.chkPayInFront);
		base.Controls.Add(this.txtChequeNo);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.dtpCheque);
		base.Controls.Add(this.Label9);
		base.Controls.Add(this.dtpPayment);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.cboPaymentCode);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.dgvList);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSupplierPayment";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Pembayaran Supplier - Input";
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmSupplierPayment()
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
					ComboBox combo = cboSupplier;
					cCombo.getSupplier(ref combo, Module1.pubGroupId, All: false, FlowerOnly: false, IncludeParent: true, Active: true);
					cboSupplier = combo;
					combo = cboPaymentCode;
					cCombo.getPaymentCode(ref combo, All: false, ShowCheque: true);
					cboPaymentCode = combo;
					FormatGrid();
					goto end_IL_001b;
				}
				case 189:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSupplierPayment", "New", "");
						goto end_IL_001b;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try001b_dispatch = 189;
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
					lblSupplier.Text = "";
					lblSupplier.Visible = false;
					cboSupplier.Visible = true;
					if (!SaveNew)
					{
						dtpPayment.Value = DateAndTime.Now;
						cboPaymentCode.SelectedIndex = -1;
					}
					cboSupplier.SelectedIndex = -1;
					lblCurrencyName.Text = "";
					cboAccount.SelectedIndex = -1;
					dtpCheque.Enabled = false;
					txtChequeNo.Enabled = false;
					txtCurrencyRate.Text = "";
					txtAmount.Text = "";
					lblTotalAllocation.Text = "0";
					lblRemain.Text = "0";
					txtDescription.Text = "";
					btnDelete.Enabled = false;
					btnHistory.Enabled = false;
					dtpPayment.Enabled = true;
					dtpPayment.Focus();
					goto end_IL_0001;
				case 344:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSupplierPayment", "PrepareForm", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 344;
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
					cPurchaseInvoiceMultiPayment cPurchaseInvoiceMultiPayment2 = new cPurchaseInvoiceMultiPayment(_currentId);
					ComboBox cboSource = cboSupplier;
					Module1.comboBoundValue(ref cboSource, cPurchaseInvoiceMultiPayment2.SupplierId);
					cboSupplier = cboSource;
					dtpPayment.Value = cPurchaseInvoiceMultiPayment2.PaymentDate;
					cboSource = cboPaymentCode;
					Module1.comboBoundValue(ref cboSource, (int)cPurchaseInvoiceMultiPayment2.PaymentCodeId);
					cboPaymentCode = cboSource;
					chkPayInFront.Checked = cPurchaseInvoiceMultiPayment2.InFront != 0;
					txtAmount.Text = Module1.formatCustomDecimal(Conversions.ToString(cPurchaseInvoiceMultiPayment2.Amount), 2);
					txtDescription.Text = cPurchaseInvoiceMultiPayment2.Description;
					cboSource = cboAccount;
					Module1.comboBoundValue(ref cboSource, cPurchaseInvoiceMultiPayment2.AccountId);
					cboAccount = cboSource;
					txtCurrencyRate.Text = Module1.formatCustomDecimal(Conversions.ToString(cPurchaseInvoiceMultiPayment2.CurrencyRate), 2);
					cboSupplier.Visible = false;
					lblSupplier.Text = cboSupplier.Text;
					lblSupplier.Visible = true;
					if (Operators.CompareString(cPurchaseInvoiceMultiPayment2.PaymentCodeName, "C/G", TextCompare: false) == 0)
					{
						txtChequeNo.Text = cPurchaseInvoiceMultiPayment2.ChequeNumber;
						dtpCheque.Value = cPurchaseInvoiceMultiPayment2.ChequeDate;
					}
					dgvList.Rows.Clear();
					cPurchaseInvoicePayment[] allocation = cPurchaseInvoiceMultiPayment2.Allocation;
					foreach (cPurchaseInvoicePayment cPurchaseInvoicePayment2 in allocation)
					{
						dgvList.Rows.Add(cPurchaseInvoicePayment2.InvoiceId, TriState.True, cPurchaseInvoicePayment2.InvoiceDate, cPurchaseInvoicePayment2.InvoiceNumber, Module1.formatCustomDecimal(Conversions.ToString(cPurchaseInvoicePayment2.InvoicePayable), 2), Module1.formatCustomDecimal(Conversions.ToString(cPurchaseInvoicePayment2.Amount), 2), Module1.formatCustomDecimal(Conversions.ToString(cPurchaseInvoicePayment2.InvoicePayable + cPurchaseInvoicePayment2.Amount), 2));
					}
					GetUnpaid();
					if (DateAndTime.DateDiff(DateInterval.Day, dtpPayment.Value, DateAndTime.Now) <= Module1.pubDaysLimit)
					{
						dtpPayment.Enabled = true;
					}
					else
					{
						dtpPayment.Enabled = false;
					}
					if (DateAndTime.DateDiff(DateInterval.Day, dtpPayment.Value, DateAndTime.Now) <= Module1.pubDaysLimit)
					{
						btnDelete.Enabled = true;
					}
					else
					{
						btnDelete.Enabled = false;
					}
					btnHistory.Enabled = true;
					goto end_IL_0001;
				}
				case 742:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSupplierPayment", "LoadData", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 742;
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
		dgvList.Columns.Add("", "Hutang");
		dgvList.Columns.Add("", "Jumlah Alokasi");
		dgvList.Columns.Add("", "OriginalHutang");
		dgvList.Columns[0].Visible = false;
		dgvList.Columns[6].Visible = false;
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
					if (e.ColumnIndex == 1)
					{
						if (Operators.ConditionalCompareObjectEqual(dgvList[1, dgvList.CurrentRow.Index].Value, true, TextCompare: false))
						{
							dgvList[1, dgvList.CurrentRow.Index].Value = true;
							TickAllocation();
						}
						else
						{
							dgvList[1, dgvList.CurrentRow.Index].Value = false;
							UntickAllocation();
						}
					}
					goto end_IL_0001;
				case 219:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSupplierPayment", "dgvList_CellContentClick", "");
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

	private void dgvList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.ColumnIndex == 1)
		{
			if (Operators.ConditionalCompareObjectEqual(dgvList[1, dgvList.CurrentRow.Index].Value, true, TextCompare: false))
			{
				dgvList[1, dgvList.CurrentRow.Index].Value = false;
				UntickAllocation();
			}
			else
			{
				dgvList[1, dgvList.CurrentRow.Index].Value = true;
				TickAllocation();
			}
		}
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
							Interaction.MsgBox("Sisa hutang tidak boleh dibawah 0", MsgBoxStyle.Information);
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
						Module1.SaveError(Information.Err(), "frmSupplierPayment", "dgvList_CellValidating", "");
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
			MyProject.Forms.frmPurchaseInvoice.Show();
			MyProject.Forms.frmPurchaseInvoice.prepareForm(SaveNew: false, KeepSupplier: false);
			MyProject.Forms.frmPurchaseInvoice.CurrentId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
			MyProject.Forms.frmPurchaseInvoice.LoadData();
			MyProject.Forms.frmPurchaseInvoice.Activate();
			MyProject.Forms.frmPurchaseInvoice.WindowState = FormWindowState.Normal;
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
							Module1.SaveError(Information.Err(), "frmSupplierPayment", "CalculateAllocation", "");
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
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					cComboItem cComboItem2 = (cComboItem)cboSupplier.SelectedItem;
					dgvList.Rows.Clear();
					if (cboSupplier.SelectedIndex > -1)
					{
						GetUnpaid();
						cSupplier cSupplier2 = new cSupplier(Conversions.ToInteger(cComboItem2.Value));
						ComboBox cboSource = cboAccount;
						Module1.comboBoundValue(ref cboSource, Conversions.ToDouble(Interaction.IIf(cSupplier2.CashAccountId > 0, cSupplier2.CashAccountId, Module1.pubCashAccountId)));
						cboAccount = cboSource;
						_invoiceCurrencyId = cSupplier2.CurrencyId;
						lblCurrencyName.Text = cSupplier2.CurrencyName;
						lblAmount.Text = "Jumlah (" + cSupplier2.CurrencyName + ")";
						if (_invoiceCurrencyId == 1)
						{
							txtCurrencyRate.Enabled = false;
						}
						else
						{
							txtCurrencyRate.Enabled = true;
						}
						if (_invoiceCurrencyId == 1)
						{
							txtCurrencyRate.Text = Conversions.ToString(1);
						}
						else
						{
							cCurrency cCurrency2 = new cCurrency(_invoiceCurrencyId);
							txtCurrencyRate.Text = Module1.formatCustomDecimal(Conversions.ToString(cCurrency2.Rate), 2);
						}
						_cashAccountId = Conversions.ToInteger(Interaction.IIf(cSupplier2.CashAccountId > 0, cSupplier2.CashAccountId, Module1.pubCashAccountId));
						_bankAccountId = Conversions.ToInteger(Interaction.IIf(cSupplier2.BankAccountId > 0, cSupplier2.BankAccountId, Module1.pubBankAccountId));
					}
					goto end_IL_0001;
				}
				case 479:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSupplierPayment", "cboSupplier_SelectedIndexChanged", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 479;
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

	private void cboSupplier_SelectionChangeCommitted(object sender, EventArgs e)
	{
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
				switch (try0001_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					cComboItem cComboItem2 = (cComboItem)cboSupplier.SelectedItem;
					DataTable dataTable = cPurchaseInvoice.dtUnpaid(Conversions.ToInteger(cComboItem2.Value), Module1.pubGroupId);
					int count = dgvList.Rows.Count;
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						DataGridView dataGridView = dgvList;
						bool num3 = IsInDataGridView(ref dataGridView, Conversions.ToString(dataRow["invId"]), 0, count);
						dgvList = dataGridView;
						if (!num3)
						{
							dgvList.Rows.Add(dataRow["invId"], 0, dataRow["invDate"], dataRow["invNumber"], Module1.formatCustomDecimal(Conversions.ToString(dataRow["invPayable"]), 2), 0, Module1.formatCustomDecimal(Conversions.ToString(dataRow["invPayable"]), 2));
							dgvList.Rows[checked(dgvList.RowCount - 1)].Cells[5].ReadOnly = true;
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
				case 465:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSupplierPayment", "GetUnpaid", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 465;
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
		}
		else
		{
			txtChequeNo.Text = "";
			txtChequeNo.Enabled = false;
			dtpCheque.Enabled = false;
		}
		if (Operators.CompareString(cboPaymentCode.Text, "Cash", TextCompare: false) == 0)
		{
			ComboBox combo = cboAccount;
			cCombo.getCashAccount(ref combo, 0, Module1.pubGroupId, All: false, GroupDefault: false, Active: true, "GENERAL", _invoiceCurrencyId);
			cboAccount = combo;
			combo = cboAccount;
			Module1.comboBoundValue(ref combo, _cashAccountId);
			cboAccount = combo;
		}
		else
		{
			ComboBox combo = cboAccount;
			cCombo.getBankAccount(ref combo, 0, Module1.pubGroupId, All: false, GroupDefault: false, Active: true, "GENERAL", _invoiceCurrencyId);
			cboAccount = combo;
			combo = cboAccount;
			Module1.comboBoundValue(ref combo, _bankAccountId);
			cboAccount = combo;
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
						cComboItem cComboItem2 = (cComboItem)cboSupplier.SelectedItem;
						cComboItem cComboItem3 = (cComboItem)cboPaymentCode.SelectedItem;
						cComboItem cComboItem4 = (cComboItem)cboAccount.SelectedItem;
						if (cboSupplier.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih supplier", MsgBoxStyle.Information);
							cboSupplier.Focus();
							goto end_IL_0001;
						}
						if (cboPaymentCode.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih tipe pembayaran", MsgBoxStyle.Information);
							cboPaymentCode.Focus();
							goto end_IL_0001;
						}
						if (!cValidation.isDateWithinRange(dtpPayment.Value, Module1.pubGroupId, Module1.pubDaysLimit))
						{
							Interaction.MsgBox("Tanggal diluar batas yang diperbolehkan", MsgBoxStyle.Information);
							dtpPayment.Focus();
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
						cPurchaseInvoiceMultiPayment cPurchaseInvoiceMultiPayment2 = new cPurchaseInvoiceMultiPayment(0.0);
						cPurchaseInvoiceMultiPayment2.MultiPaymentId = _currentId;
						cPurchaseInvoiceMultiPayment2.SupplierId = Conversions.ToInteger(cComboItem2.Value);
						cPurchaseInvoiceMultiPayment2.PaymentDate = dtpPayment.Value;
						cPurchaseInvoiceMultiPayment2.PaymentCodeId = Conversions.ToByte(cComboItem3.Value);
						cPurchaseInvoiceMultiPayment2.PaymentCodeName = cboPaymentCode.Text;
						cPurchaseInvoiceMultiPayment2.Amount = Conversions.ToDouble(txtAmount.Text);
						cPurchaseInvoiceMultiPayment2.InFront = Conversions.ToByte(Interaction.IIf(chkPayInFront.Checked, 1, 0));
						cPurchaseInvoiceMultiPayment2.Description = txtDescription.Text;
						cPurchaseInvoiceMultiPayment2.AccountId = Conversions.ToInteger(cComboItem4.Value);
						cPurchaseInvoiceMultiPayment2.CurrencyRate = Conversions.ToDouble(txtCurrencyRate.Text);
						cPurchaseInvoiceMultiPayment2.AllocatedAmount = Conversions.ToDouble(lblTotalAllocation.Text);
						if (Operators.CompareString(cboPaymentCode.Text, "C/G", TextCompare: false) == 0)
						{
							cPurchaseInvoiceMultiPayment2.ChequeDate = dtpCheque.Value;
							cPurchaseInvoiceMultiPayment2.ChequeNumber = txtChequeNo.Text;
						}
						cPurchaseInvoicePayment[] array = null;
						string text = "";
						int num3 = dgvList.Rows.Count - 1;
						for (int i = 0; i <= num3; i++)
						{
							if (Operators.ConditionalCompareObjectEqual(dgvList[1, i].Value, true, TextCompare: false))
							{
								array = (cPurchaseInvoicePayment[])Utils.CopyArray(array, new cPurchaseInvoicePayment[num4 + 1]);
								array[num4] = new cPurchaseInvoicePayment();
								array[num4].InvoiceId = Conversions.ToDouble(dgvList[0, i].Value);
								array[num4].Amount = Conversions.ToDouble(dgvList[5, i].Value);
								num4++;
								text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<tr><td>", dgvList[2, i].Value), "</td>"), "<td>"), dgvList[3, i].Value), "</td>"), "<td align='right'>"), Module1.formatCustomDecimal(Conversions.ToString(dgvList[5, i].Value), 2)), "</td></tr>")));
							}
						}
						cPurchaseInvoiceMultiPayment2.Allocation = array;
						cPurchaseInvoiceMultiPayment2.Save();
						string text2 = "Tanggal: " + Conversions.ToString(dtpPayment.Value) + "<br />Tipe: " + cboPaymentCode.Text + "<br />Bon: " + Conversions.ToString(chkPayInFront.Checked) + "<br />Tgl C/G: " + Conversions.ToString(dtpCheque.Value) + "<br />No C/G: " + txtChequeNo.Text + "<br />Jumlah: " + txtAmount.Text + "<br />Keterangan: " + Module1.cleanString(txtDescription.Text) + "<br />Kas/Rekening: " + cboAccount.Text + "<br /><br />";
						text2 += "Alokasi:<br />";
						text2 += "<table>";
						text2 += "<tr><td>Tanggal</td><td>No Faktur</td><td>Alokasi</td></tr>";
						text2 += text;
						text2 += "</table>";
						string text3;
						if (_currentId == 0.0)
						{
							text3 = "membuat ";
							_currentId = cPurchaseInvoiceMultiPayment2.MultiPaymentId;
						}
						else
						{
							text3 = "mengupdate ";
						}
						text3 = text3 + "pembayaran tanggal " + Strings.Format(dtpPayment.Value, "dd/MM/yyyy") + " untuk supplier " + cboSupplier.Text + ". ID= " + Conversions.ToString(_currentId) + ", v2";
						cHistory cHistory2 = new cHistory();
						cHistory2.Content = text2;
						cHistory2.Description = text3;
						cHistory2.UserId = Module1.pubUserId;
						cHistory2.UserLogin = Module1.pubLogin;
						cHistory2.fKeyId = _currentId;
						cHistory2.HistoryType = 6;
						cHistory2.Save();
						Cursor = Cursors.Default;
						Interaction.MsgBox("Pembayaran berhasil disimpan", MsgBoxStyle.Information);
						if (Module1.FormIsOpen("frmSupplierPaymentList"))
						{
							MyProject.Forms.frmSupplierPaymentList.GetRecent();
						}
						if (Module1.FormIsOpen("frmSupplier"))
						{
							MyProject.Forms.frmSupplier.GetPayment();
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
					case 1994:
						num = -1;
						switch (num2)
						{
						case 2:
							Cursor = Cursors.Default;
							Module1.SaveError(Information.Err(), "frmSupplierPayment", "SaveData", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1994;
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
						cPurchaseInvoiceMultiPayment cPurchaseInvoiceMultiPayment2 = new cPurchaseInvoiceMultiPayment(_currentId);
						cPurchaseInvoiceMultiPayment2.Delete();
						string description = "menghapus pembayaran tanggal " + Conversions.ToString(cPurchaseInvoiceMultiPayment2.PaymentDate) + " untuk supplier " + cPurchaseInvoiceMultiPayment2.SupplierName + ". ID=" + Conversions.ToString(cPurchaseInvoiceMultiPayment2.MultiPaymentId) + ", v2";
						cHistory cHistory2 = new cHistory();
						cHistory2.Description = description;
						cHistory2.UserId = Module1.pubUserId;
						cHistory2.UserLogin = Module1.pubLogin;
						cHistory2.fKeyId = _currentId;
						cHistory2.HistoryType = 6;
						cHistory2.Save();
						Interaction.MsgBox("Pembayaran berhasil dihapus", MsgBoxStyle.Information);
						if (Module1.FormIsOpen("frmSupplierPaymentList"))
						{
							MyProject.Forms.frmSupplierPaymentList.GetRecent();
						}
						MyProject.Forms.frmInformation.GetActivity();
						Close();
					}
					goto end_IL_0001;
				case 316:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSupplierPayment", "btnDelete_Click", "");
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
		MyProject.Forms.frmHistory.GetHistory(checked((int)Math.Round(_currentId)), 6);
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

	private void cboCashAccount_SelectedIndexChanged(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboAccount.SelectedItem;
		if (!Information.IsNothing(cComboItem2) && Conversions.ToDouble(cComboItem2.Value) > 1.0)
		{
			DataTable currencyOfAccount = cCurrency.GetCurrencyOfAccount(Conversions.ToInteger(cComboItem2.Value));
			if (cboPaymentCode.SelectedIndex == 0)
			{
				lblAccount.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Kas (", currencyOfAccount.Rows[0]["currencyName"]), ")"));
			}
			else
			{
				lblAccount.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Rekening (", currencyOfAccount.Rows[0]["currencyName"]), ")"));
			}
		}
	}
}
