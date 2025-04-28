using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Excel;
using GCUv2.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.PowerPacks;

namespace GCUv2;

[DesignerGenerated]
public class frmReportSalesPerson : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboBranch")]
	private ComboBox _cboBranch;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnReset")]
	private Button _btnReset;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnPrint")]
	private Button _btnPrint;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvItem")]
	private DataGridView _dgvItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSearch")]
	private Button _btnSearch;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("txtBon")]
	private FilteredTextBox _txtBon;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnEmpty")]
	private Button _btnEmpty;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnExcel")]
	private Button _btnExcel;

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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
			KeyEventHandler value2 = dgvItem_KeyDown;
			EventHandler value3 = dgvItem_GotFocus;
			EventHandler value4 = dgvItem_LostFocus;
			DataGridView dataGridView = _dgvItem;
			if (dataGridView != null)
			{
				dataGridView.KeyDown -= value2;
				dataGridView.GotFocus -= value3;
				dataGridView.LostFocus -= value4;
			}
			_dgvItem = value;
			dataGridView = _dgvItem;
			if (dataGridView != null)
			{
				dataGridView.KeyDown += value2;
				dataGridView.GotFocus += value3;
				dataGridView.LostFocus += value4;
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

	[field: AccessedThroughProperty("dtpBegin")]
	internal virtual DateTimePicker dtpBegin
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dgvExpense")]
	internal virtual DataGridView dgvExpense
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

	[field: AccessedThroughProperty("lblTotalInvoice")]
	internal virtual Label lblTotalInvoice
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTotalCreditInvoice")]
	internal virtual Label lblTotalCreditInvoice
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTotalCashInvoice")]
	internal virtual Label lblTotalCashInvoice
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

	[field: AccessedThroughProperty("LineShape6")]
	internal virtual LineShape LineShape6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LineShape5")]
	internal virtual LineShape LineShape5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LineShape4")]
	internal virtual LineShape LineShape4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LineShape3")]
	internal virtual LineShape LineShape3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("lblTotalCreditPayment")]
	internal virtual Label lblTotalCreditPayment
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

	[field: AccessedThroughProperty("lblTotalPaymentReceived")]
	internal virtual Label lblTotalPaymentReceived
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

	[field: AccessedThroughProperty("LineShape13")]
	internal virtual LineShape LineShape13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LineShape12")]
	internal virtual LineShape LineShape12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LineShape11")]
	internal virtual LineShape LineShape11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LineShape10")]
	internal virtual LineShape LineShape10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LineShape9")]
	internal virtual LineShape LineShape9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LineShape8")]
	internal virtual LineShape LineShape8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LineShape7")]
	internal virtual LineShape LineShape7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPaper")]
	internal virtual FilteredTextBox txtPaper
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

	[field: AccessedThroughProperty("txtDriver")]
	internal virtual TextBox txtDriver
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

	[field: AccessedThroughProperty("txtKernet")]
	internal virtual TextBox txtKernet
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

	[field: AccessedThroughProperty("txtCoin")]
	internal virtual FilteredTextBox txtCoin
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

	[field: AccessedThroughProperty("LineShape14")]
	internal virtual LineShape LineShape14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual FilteredTextBox txtBon
	{
		[CompilerGenerated]
		get
		{
			return _txtBon;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = txtBon_TextChanged;
			FilteredTextBox filteredTextBox = _txtBon;
			if (filteredTextBox != null)
			{
				filteredTextBox.TextChanged -= value2;
			}
			_txtBon = value;
			filteredTextBox = _txtBon;
			if (filteredTextBox != null)
			{
				filteredTextBox.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label12")]
	internal virtual Label Label12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTotalDeposit")]
	internal virtual Label lblTotalDeposit
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTotalTransfer")]
	internal virtual Label lblTotalTransfer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTotalCheque")]
	internal virtual Label lblTotalCheque
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

	[field: AccessedThroughProperty("Label18")]
	internal virtual Label Label18
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

	[field: AccessedThroughProperty("lblTotalCreditDiscount")]
	internal virtual Label lblTotalCreditDiscount
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTotalCreditReturn")]
	internal virtual Label lblTotalCreditReturn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTotalExpense")]
	internal virtual Label lblTotalExpense
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

	[field: AccessedThroughProperty("Label21")]
	internal virtual Label Label21
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

	internal virtual Button btnEmpty
	{
		[CompilerGenerated]
		get
		{
			return _btnEmpty;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnEmpty_Click;
			Button button = _btnEmpty;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnEmpty = value;
			button = _btnEmpty;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button btnExcel
	{
		[CompilerGenerated]
		get
		{
			return _btnExcel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnExcel_Click;
			Button button = _btnExcel;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnExcel = value;
			button = _btnExcel;
			if (button != null)
			{
				button.Click += value2;
			}
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
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		this.Label4 = new System.Windows.Forms.Label();
		this.cboSalesPerson = new System.Windows.Forms.ComboBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.cboBranch = new System.Windows.Forms.ComboBox();
		this.btnReset = new System.Windows.Forms.Button();
		this.btnPrint = new System.Windows.Forms.Button();
		this.Label1 = new System.Windows.Forms.Label();
		this.dgvItem = new System.Windows.Forms.DataGridView();
		this.btnSearch = new System.Windows.Forms.Button();
		this.dtpBegin = new System.Windows.Forms.DateTimePicker();
		this.dgvExpense = new System.Windows.Forms.DataGridView();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.lblTotalInvoice = new System.Windows.Forms.Label();
		this.lblTotalCreditInvoice = new System.Windows.Forms.Label();
		this.lblTotalCashInvoice = new System.Windows.Forms.Label();
		this.ShapeContainer1 = new ShapeContainer();
		this.LineShape14 = new LineShape();
		this.LineShape13 = new LineShape();
		this.LineShape12 = new LineShape();
		this.LineShape11 = new LineShape();
		this.LineShape10 = new LineShape();
		this.LineShape9 = new LineShape();
		this.LineShape8 = new LineShape();
		this.LineShape7 = new LineShape();
		this.LineShape6 = new LineShape();
		this.LineShape5 = new LineShape();
		this.LineShape4 = new LineShape();
		this.LineShape3 = new LineShape();
		this.LineShape2 = new LineShape();
		this.LineShape1 = new LineShape();
		this.lblTotalCreditPayment = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.lblTotalPaymentReceived = new System.Windows.Forms.Label();
		this.Label9 = new System.Windows.Forms.Label();
		this.Label13 = new System.Windows.Forms.Label();
		this.txtDriver = new System.Windows.Forms.TextBox();
		this.Label7 = new System.Windows.Forms.Label();
		this.txtKernet = new System.Windows.Forms.TextBox();
		this.Label10 = new System.Windows.Forms.Label();
		this.Label11 = new System.Windows.Forms.Label();
		this.Label12 = new System.Windows.Forms.Label();
		this.lblTotalDeposit = new System.Windows.Forms.Label();
		this.lblTotalTransfer = new System.Windows.Forms.Label();
		this.lblTotalCheque = new System.Windows.Forms.Label();
		this.Label17 = new System.Windows.Forms.Label();
		this.Label18 = new System.Windows.Forms.Label();
		this.Label19 = new System.Windows.Forms.Label();
		this.lblTotalCreditDiscount = new System.Windows.Forms.Label();
		this.lblTotalCreditReturn = new System.Windows.Forms.Label();
		this.lblTotalExpense = new System.Windows.Forms.Label();
		this.Label20 = new System.Windows.Forms.Label();
		this.Label21 = new System.Windows.Forms.Label();
		this.Label22 = new System.Windows.Forms.Label();
		this.btnEmpty = new System.Windows.Forms.Button();
		this.btnExcel = new System.Windows.Forms.Button();
		this.txtBon = new GCUv2.FilteredTextBox();
		this.txtCoin = new GCUv2.FilteredTextBox();
		this.txtPaper = new GCUv2.FilteredTextBox();
		((System.ComponentModel.ISupportInitialize)this.dgvItem).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dgvExpense).BeginInit();
		base.SuspendLayout();
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(9, 68);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(77, 13);
		this.Label4.TabIndex = 237;
		this.Label4.Text = "Sales/Kolektor";
		this.cboSalesPerson.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboSalesPerson.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboSalesPerson.FormattingEnabled = true;
		this.cboSalesPerson.Location = new System.Drawing.Point(101, 65);
		this.cboSalesPerson.Name = "cboSalesPerson";
		this.cboSalesPerson.Size = new System.Drawing.Size(120, 21);
		this.cboSalesPerson.TabIndex = 3;
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(10, 41);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(44, 13);
		this.Label3.TabIndex = 236;
		this.Label3.Text = "Cabang";
		this.cboBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboBranch.FormattingEnabled = true;
		this.cboBranch.Location = new System.Drawing.Point(101, 38);
		this.cboBranch.Name = "cboBranch";
		this.cboBranch.Size = new System.Drawing.Size(120, 21);
		this.cboBranch.TabIndex = 1;
		this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnReset.Location = new System.Drawing.Point(156, 92);
		this.btnReset.Name = "btnReset";
		this.btnReset.Size = new System.Drawing.Size(47, 24);
		this.btnReset.TabIndex = 22;
		this.btnReset.Text = "&Reset";
		this.btnReset.UseVisualStyleBackColor = true;
		this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnPrint.Location = new System.Drawing.Point(847, 467);
		this.btnPrint.Name = "btnPrint";
		this.btnPrint.Size = new System.Drawing.Size(73, 23);
		this.btnPrint.TabIndex = 33;
		this.btnPrint.Text = "Cetak";
		this.btnPrint.UseVisualStyleBackColor = true;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(10, 15);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(46, 13);
		this.Label1.TabIndex = 235;
		this.Label1.Text = "Tanggal";
		this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvItem.Location = new System.Drawing.Point(238, 12);
		this.dgvItem.Name = "dgvItem";
		this.dgvItem.Size = new System.Drawing.Size(344, 352);
		this.dgvItem.TabIndex = 230;
		this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSearch.Location = new System.Drawing.Point(102, 92);
		this.btnSearch.Name = "btnSearch";
		this.btnSearch.Size = new System.Drawing.Size(47, 24);
		this.btnSearch.TabIndex = 21;
		this.btnSearch.Text = "&Cari";
		this.btnSearch.UseVisualStyleBackColor = true;
		this.dtpBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpBegin.Location = new System.Drawing.Point(100, 12);
		this.dtpBegin.Name = "dtpBegin";
		this.dtpBegin.Size = new System.Drawing.Size(121, 20);
		this.dtpBegin.TabIndex = 0;
		this.dgvExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvExpense.Location = new System.Drawing.Point(592, 116);
		this.dgvExpense.Name = "dgvExpense";
		this.dgvExpense.Size = new System.Drawing.Size(329, 248);
		this.dgvExpense.TabIndex = 238;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(234, 367);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(121, 16);
		this.Label2.TabIndex = 239;
		this.Label2.Text = "Total Penjualan:";
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(234, 392);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(125, 16);
		this.Label5.TabIndex = 240;
		this.Label5.Text = "Penjualan Kredit:";
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.Location = new System.Drawing.Point(234, 419);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(124, 16);
		this.Label6.TabIndex = 241;
		this.Label6.Text = "Penjualan Tunai:";
		this.lblTotalInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblTotalInvoice.Location = new System.Drawing.Point(373, 367);
		this.lblTotalInvoice.Name = "lblTotalInvoice";
		this.lblTotalInvoice.Size = new System.Drawing.Size(95, 16);
		this.lblTotalInvoice.TabIndex = 242;
		this.lblTotalInvoice.Text = "Total";
		this.lblTotalInvoice.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.lblTotalCreditInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblTotalCreditInvoice.Location = new System.Drawing.Point(373, 392);
		this.lblTotalCreditInvoice.Name = "lblTotalCreditInvoice";
		this.lblTotalCreditInvoice.Size = new System.Drawing.Size(95, 16);
		this.lblTotalCreditInvoice.TabIndex = 243;
		this.lblTotalCreditInvoice.Text = "Total";
		this.lblTotalCreditInvoice.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.lblTotalCashInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblTotalCashInvoice.Location = new System.Drawing.Point(373, 419);
		this.lblTotalCashInvoice.Name = "lblTotalCashInvoice";
		this.lblTotalCashInvoice.Size = new System.Drawing.Size(95, 16);
		this.lblTotalCashInvoice.TabIndex = 244;
		this.lblTotalCashInvoice.Text = "Total";
		this.lblTotalCashInvoice.TextAlign = System.Drawing.ContentAlignment.TopRight;
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).Location = new System.Drawing.Point(0, 0);
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).Margin = new System.Windows.Forms.Padding(0);
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).Name = "ShapeContainer1";
		this.ShapeContainer1.Shapes.AddRange((Shape[])(object)new Shape[14]
		{
			(Shape)this.LineShape14,
			(Shape)this.LineShape13,
			(Shape)this.LineShape12,
			(Shape)this.LineShape11,
			(Shape)this.LineShape10,
			(Shape)this.LineShape9,
			(Shape)this.LineShape8,
			(Shape)this.LineShape7,
			(Shape)this.LineShape6,
			(Shape)this.LineShape5,
			(Shape)this.LineShape4,
			(Shape)this.LineShape3,
			(Shape)this.LineShape2,
			(Shape)this.LineShape1
		});
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).Size = new System.Drawing.Size(938, 498);
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).TabIndex = 245;
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).TabStop = false;
		((Shape)this.LineShape14).Name = "LineShape14";
		this.LineShape14.X1 = 230;
		this.LineShape14.X2 = 230;
		this.LineShape14.Y1 = 10;
		this.LineShape14.Y2 = 117;
		((Shape)this.LineShape13).Name = "LineShape13";
		this.LineShape13.X1 = 504;
		this.LineShape13.X2 = 504;
		this.LineShape13.Y1 = 441;
		this.LineShape13.Y2 = 481;
		((Shape)this.LineShape12).Name = "LineShape12";
		this.LineShape12.X1 = 468;
		this.LineShape12.X2 = 504;
		this.LineShape12.Y1 = 482;
		this.LineShape12.Y2 = 482;
		((Shape)this.LineShape11).Name = "LineShape11";
		this.LineShape11.X1 = 468;
		this.LineShape11.X2 = 489;
		this.LineShape11.Y1 = 452;
		this.LineShape11.Y2 = 452;
		((Shape)this.LineShape10).Name = "LineShape10";
		this.LineShape10.X1 = 468;
		this.LineShape10.X2 = 489;
		this.LineShape10.Y1 = 428;
		this.LineShape10.Y2 = 428;
		((Shape)this.LineShape9).Name = "LineShape9";
		this.LineShape9.X1 = 489;
		this.LineShape9.X2 = 489;
		this.LineShape9.Y1 = 428;
		this.LineShape9.Y2 = 452;
		((Shape)this.LineShape8).Name = "LineShape8";
		this.LineShape8.X1 = 489;
		this.LineShape8.X2 = 503;
		this.LineShape8.Y1 = 441;
		this.LineShape8.Y2 = 441;
		((Shape)this.LineShape7).Name = "LineShape7";
		this.LineShape7.X1 = 238;
		this.LineShape7.X2 = 461;
		this.LineShape7.Y1 = 467;
		this.LineShape7.Y2 = 467;
		((Shape)this.LineShape6).Name = "LineShape6";
		this.LineShape6.X1 = 195;
		this.LineShape6.X2 = 209;
		this.LineShape6.Y1 = 415;
		this.LineShape6.Y2 = 415;
		((Shape)this.LineShape5).Name = "LineShape5";
		this.LineShape5.X1 = 209;
		this.LineShape5.X2 = 209;
		this.LineShape5.Y1 = 402;
		this.LineShape5.Y2 = 426;
		((Shape)this.LineShape4).Name = "LineShape4";
		this.LineShape4.X1 = 210;
		this.LineShape4.X2 = 231;
		this.LineShape4.Y1 = 402;
		this.LineShape4.Y2 = 402;
		((Shape)this.LineShape3).Name = "LineShape3";
		this.LineShape3.X1 = 210;
		this.LineShape3.X2 = 231;
		this.LineShape3.Y1 = 426;
		this.LineShape3.Y2 = 426;
		((Shape)this.LineShape2).Name = "LineShape2";
		this.LineShape2.X1 = 195;
		this.LineShape2.X2 = 231;
		this.LineShape2.Y1 = 375;
		this.LineShape2.Y2 = 375;
		((Shape)this.LineShape1).Name = "LineShape1";
		this.LineShape1.X1 = 195;
		this.LineShape1.X2 = 195;
		this.LineShape1.Y1 = 376;
		this.LineShape1.Y2 = 414;
		this.lblTotalCreditPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblTotalCreditPayment.Location = new System.Drawing.Point(373, 444);
		this.lblTotalCreditPayment.Name = "lblTotalCreditPayment";
		this.lblTotalCreditPayment.Size = new System.Drawing.Size(95, 16);
		this.lblTotalCreditPayment.TabIndex = 247;
		this.lblTotalCreditPayment.Text = "Total";
		this.lblTotalCreditPayment.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.Label8.AutoSize = true;
		this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label8.Location = new System.Drawing.Point(234, 444);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(141, 16);
		this.Label8.TabIndex = 246;
		this.Label8.Text = "Pelunasan Piutang:";
		this.lblTotalPaymentReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblTotalPaymentReceived.Location = new System.Drawing.Point(373, 474);
		this.lblTotalPaymentReceived.Name = "lblTotalPaymentReceived";
		this.lblTotalPaymentReceived.Size = new System.Drawing.Size(95, 16);
		this.lblTotalPaymentReceived.TabIndex = 249;
		this.lblTotalPaymentReceived.Text = "Total";
		this.lblTotalPaymentReceived.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.Label9.AutoSize = true;
		this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label9.Location = new System.Drawing.Point(234, 474);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(61, 16);
		this.Label9.TabIndex = 248;
		this.Label9.Text = "Jumlah:";
		this.Label13.AutoSize = true;
		this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label13.Location = new System.Drawing.Point(589, 64);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(51, 13);
		this.Label13.TabIndex = 253;
		this.Label13.Text = "U. Kertas";
		this.txtDriver.Location = new System.Drawing.Point(641, 8);
		this.txtDriver.Name = "txtDriver";
		this.txtDriver.Size = new System.Drawing.Size(115, 20);
		this.txtDriver.TabIndex = 23;
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(589, 11);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(31, 13);
		this.Label7.TabIndex = 252;
		this.Label7.Text = "Sopir";
		this.txtKernet.Location = new System.Drawing.Point(641, 34);
		this.txtKernet.Name = "txtKernet";
		this.txtKernet.Size = new System.Drawing.Size(115, 20);
		this.txtKernet.TabIndex = 24;
		this.Label10.AutoSize = true;
		this.Label10.Location = new System.Drawing.Point(589, 37);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(38, 13);
		this.Label10.TabIndex = 255;
		this.Label10.Text = "Kernet";
		this.Label11.AutoSize = true;
		this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label11.Location = new System.Drawing.Point(589, 91);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(53, 13);
		this.Label11.TabIndex = 257;
		this.Label11.Text = "U. Logam";
		this.Label12.AutoSize = true;
		this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label12.Location = new System.Drawing.Point(772, 91);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(73, 13);
		this.Label12.TabIndex = 259;
		this.Label12.Text = "Bon Gantung:";
		this.lblTotalDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblTotalDeposit.Location = new System.Drawing.Point(847, 65);
		this.lblTotalDeposit.Name = "lblTotalDeposit";
		this.lblTotalDeposit.Size = new System.Drawing.Size(74, 16);
		this.lblTotalDeposit.TabIndex = 265;
		this.lblTotalDeposit.Text = "Total";
		this.lblTotalDeposit.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.lblTotalTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblTotalTransfer.Location = new System.Drawing.Point(847, 38);
		this.lblTotalTransfer.Name = "lblTotalTransfer";
		this.lblTotalTransfer.Size = new System.Drawing.Size(74, 16);
		this.lblTotalTransfer.TabIndex = 264;
		this.lblTotalTransfer.Text = "Total";
		this.lblTotalTransfer.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.lblTotalCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblTotalCheque.Location = new System.Drawing.Point(847, 12);
		this.lblTotalCheque.Name = "lblTotalCheque";
		this.lblTotalCheque.Size = new System.Drawing.Size(74, 16);
		this.lblTotalCheque.TabIndex = 263;
		this.lblTotalCheque.Text = "Total";
		this.lblTotalCheque.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.Label17.AutoSize = true;
		this.Label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label17.Location = new System.Drawing.Point(772, 65);
		this.Label17.Name = "Label17";
		this.Label17.Size = new System.Drawing.Size(74, 13);
		this.Label17.TabIndex = 262;
		this.Label17.Text = "Total Setoran:";
		this.Label18.AutoSize = true;
		this.Label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label18.Location = new System.Drawing.Point(772, 38);
		this.Label18.Name = "Label18";
		this.Label18.Size = new System.Drawing.Size(49, 13);
		this.Label18.TabIndex = 261;
		this.Label18.Text = "Transfer:";
		this.Label19.AutoSize = true;
		this.Label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label19.Location = new System.Drawing.Point(772, 12);
		this.Label19.Name = "Label19";
		this.Label19.Size = new System.Drawing.Size(53, 13);
		this.Label19.TabIndex = 260;
		this.Label19.Text = "Cek/Giro:";
		this.lblTotalCreditDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblTotalCreditDiscount.Location = new System.Drawing.Point(729, 419);
		this.lblTotalCreditDiscount.Name = "lblTotalCreditDiscount";
		this.lblTotalCreditDiscount.Size = new System.Drawing.Size(95, 16);
		this.lblTotalCreditDiscount.TabIndex = 271;
		this.lblTotalCreditDiscount.Text = "Total";
		this.lblTotalCreditDiscount.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.lblTotalCreditReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblTotalCreditReturn.Location = new System.Drawing.Point(729, 392);
		this.lblTotalCreditReturn.Name = "lblTotalCreditReturn";
		this.lblTotalCreditReturn.Size = new System.Drawing.Size(95, 16);
		this.lblTotalCreditReturn.TabIndex = 270;
		this.lblTotalCreditReturn.Text = "Total";
		this.lblTotalCreditReturn.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.lblTotalExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblTotalExpense.Location = new System.Drawing.Point(729, 367);
		this.lblTotalExpense.Name = "lblTotalExpense";
		this.lblTotalExpense.Size = new System.Drawing.Size(95, 16);
		this.lblTotalExpense.TabIndex = 269;
		this.lblTotalExpense.Text = "Total";
		this.lblTotalExpense.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.Label20.AutoSize = true;
		this.Label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label20.Location = new System.Drawing.Point(591, 419);
		this.Label20.Name = "Label20";
		this.Label20.Size = new System.Drawing.Size(130, 16);
		this.Label20.TabIndex = 268;
		this.Label20.Text = "Disc. Penj. Kredit:";
		this.Label21.AutoSize = true;
		this.Label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label21.Location = new System.Drawing.Point(591, 392);
		this.Label21.Name = "Label21";
		this.Label21.Size = new System.Drawing.Size(132, 16);
		this.Label21.TabIndex = 267;
		this.Label21.Text = "Retur Penj. Kredit:";
		this.Label22.AutoSize = true;
		this.Label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label22.Location = new System.Drawing.Point(590, 367);
		this.Label22.Name = "Label22";
		this.Label22.Size = new System.Drawing.Size(92, 16);
		this.Label22.TabIndex = 266;
		this.Label22.Text = "Total Biaya:";
		this.btnEmpty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnEmpty.Location = new System.Drawing.Point(679, 467);
		this.btnEmpty.Name = "btnEmpty";
		this.btnEmpty.Size = new System.Drawing.Size(90, 23);
		this.btnEmpty.TabIndex = 31;
		this.btnEmpty.Text = "Cetak Kosong";
		this.btnEmpty.UseVisualStyleBackColor = true;
		this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnExcel.Location = new System.Drawing.Point(775, 467);
		this.btnExcel.Name = "btnExcel";
		this.btnExcel.Size = new System.Drawing.Size(66, 23);
		this.btnExcel.TabIndex = 32;
		this.btnExcel.Text = "Excel";
		this.btnExcel.UseVisualStyleBackColor = true;
		this.txtBon.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtBon.DontFormat = false;
		this.txtBon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.txtBon.Location = new System.Drawing.Point(847, 88);
		this.txtBon.MaximumDigit = 3;
		this.txtBon.Name = "txtBon";
		this.txtBon.Size = new System.Drawing.Size(74, 20);
		this.txtBon.TabIndex = 27;
		this.txtBon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.txtCoin.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtCoin.DontFormat = false;
		this.txtCoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.txtCoin.Location = new System.Drawing.Point(641, 88);
		this.txtCoin.MaximumDigit = 3;
		this.txtCoin.Name = "txtCoin";
		this.txtCoin.Size = new System.Drawing.Size(115, 20);
		this.txtCoin.TabIndex = 26;
		this.txtCoin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.txtPaper.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtPaper.DontFormat = false;
		this.txtPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.txtPaper.Location = new System.Drawing.Point(641, 61);
		this.txtPaper.MaximumDigit = 3;
		this.txtPaper.Name = "txtPaper";
		this.txtPaper.Size = new System.Drawing.Size(115, 20);
		this.txtPaper.TabIndex = 25;
		this.txtPaper.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		base.AcceptButton = this.btnSearch;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(938, 498);
		base.Controls.Add(this.btnExcel);
		base.Controls.Add(this.btnEmpty);
		base.Controls.Add(this.lblTotalCreditDiscount);
		base.Controls.Add(this.lblTotalCreditReturn);
		base.Controls.Add(this.lblTotalExpense);
		base.Controls.Add(this.Label20);
		base.Controls.Add(this.Label21);
		base.Controls.Add(this.Label22);
		base.Controls.Add(this.lblTotalDeposit);
		base.Controls.Add(this.lblTotalTransfer);
		base.Controls.Add(this.lblTotalCheque);
		base.Controls.Add(this.Label17);
		base.Controls.Add(this.Label18);
		base.Controls.Add(this.Label19);
		base.Controls.Add(this.txtBon);
		base.Controls.Add(this.Label12);
		base.Controls.Add(this.txtCoin);
		base.Controls.Add(this.Label11);
		base.Controls.Add(this.txtKernet);
		base.Controls.Add(this.Label10);
		base.Controls.Add(this.txtPaper);
		base.Controls.Add(this.Label13);
		base.Controls.Add(this.txtDriver);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.lblTotalPaymentReceived);
		base.Controls.Add(this.Label9);
		base.Controls.Add(this.lblTotalCreditPayment);
		base.Controls.Add(this.Label8);
		base.Controls.Add(this.lblTotalCashInvoice);
		base.Controls.Add(this.lblTotalCreditInvoice);
		base.Controls.Add(this.lblTotalInvoice);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.dgvExpense);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.cboSalesPerson);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.cboBranch);
		base.Controls.Add(this.btnReset);
		base.Controls.Add(this.btnPrint);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.dgvItem);
		base.Controls.Add(this.btnSearch);
		base.Controls.Add(this.dtpBegin);
		base.Controls.Add((System.Windows.Forms.Control)(object)this.ShapeContainer1);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmReportSalesPerson";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Report Penjualan Sales";
		((System.ComponentModel.ISupportInitialize)this.dgvItem).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dgvExpense).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmReportSalesPerson()
	{
		base.KeyDown += frmReportSalesPerson_KeyDown;
		base.Load += frmReportSalesPerson_Load;
		InitializeComponent();
		DoubleBuffered = true;
		base.MdiParent = MyProject.Forms.frmMenu;
		ComboBox combo = cboBranch;
		cCombo.getBranch(ref combo, Module1.pubGroupId, blnAll: true);
		cboBranch = combo;
		txtPaper.AllowedCharacters = FilteredTextBox.InputType.NumeralsOnly;
		txtCoin.AllowedCharacters = FilteredTextBox.InputType.NumeralsOnly;
		txtBon.AllowedCharacters = FilteredTextBox.InputType.NumeralsOnly;
	}

	private void frmReportSalesPerson_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void frmReportSalesPerson_Load(object sender, EventArgs e)
	{
		prepareForm();
	}

	private void prepareForm()
	{
		btnPrint.Enabled = false;
		btnExcel.Enabled = false;
		dtpBegin.Value = DateAndTime.Now;
		cboBranch.SelectedIndex = 0;
		cboSalesPerson.SelectedIndex = 0;
		lblTotalInvoice.Text = "";
		lblTotalCashInvoice.Text = "";
		lblTotalCreditInvoice.Text = "";
		lblTotalCheque.Text = "";
		lblTotalTransfer.Text = "";
		lblTotalDeposit.Text = "";
		lblTotalCreditPayment.Text = "";
		lblTotalPaymentReceived.Text = "";
		lblTotalExpense.Text = "";
		lblTotalCreditReturn.Text = "";
		lblTotalCreditDiscount.Text = "";
		dtpBegin.Focus();
	}

	private void cboBranch_SelectedIndexChanged(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboBranch.SelectedItem;
		if (!Information.IsNothing(cComboItem2))
		{
			ComboBox combo = cboSalesPerson;
			cCombo.getSalesPerson(ref combo, "ALL", 0, 99, Conversions.ToInteger(cComboItem2.Value), Module1.pubGroupId, All: true, Dash: false, 1);
			cboSalesPerson = combo;
			combo = cboSalesPerson;
			Module1.comboBoundValue(ref combo, 0.0);
			cboSalesPerson = combo;
		}
	}

	private void btnSearch_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		double num3 = default(double);
		double num4 = default(double);
		double num5 = default(double);
		double num6 = default(double);
		double num7 = default(double);
		double num8 = default(double);
		double num9 = default(double);
		double num10 = default(double);
		double num11 = default(double);
		double num12 = default(double);
		double num13 = default(double);
		double num14 = default(double);
		double num15 = default(double);
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
					cComboItem cComboItem2 = (cComboItem)cboSalesPerson.SelectedItem;
					cComboItem cComboItem3 = (cComboItem)cboBranch.SelectedItem;
					if (DateTime.Compare(dtpBegin.Value, Module1.pubBalanceDate) < 0)
					{
						Interaction.MsgBox("Data sebelum " + Conversions.ToString(Module1.pubBalanceDate) + " tidak tersedia.");
						dtpBegin.Focus();
						goto end_IL_0001;
					}
					if (cboBranch.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih cabang.", MsgBoxStyle.Information);
						cboBranch.Focus();
						goto end_IL_0001;
					}
					if (cboSalesPerson.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih Sales/Kolektor.", MsgBoxStyle.Information);
						cboSalesPerson.Focus();
						goto end_IL_0001;
					}
					Cursor = Cursors.WaitCursor;
					DataTable dataTable = new DataTable();
					btnSearch.Focus();
					formatGrid();
					dataTable = cSalesPerson.SearchSalesItem(dtpBegin.Value, Conversions.ToInteger(cComboItem2.Value), Conversions.ToInteger(cComboItem3.Value), Module1.pubGroupId);
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						dgvItem.Rows.Add(dataRow["amount"], dataRow["prodName"], "x", Module1.formatCustomDecimal(Conversions.ToString(dataRow["ppPrice"]), 2), "Rp.", Module1.formatCustomDecimal(Conversions.ToString(dataRow["total"]), 2));
						num3 = Conversions.ToDouble(Operators.AddObject(num3, dataRow["total"]));
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					lblTotalInvoice.Text = Module1.formatCustomDecimal(Conversions.ToString(num3), 2);
					dataTable = cSalesPerson.SearchInvoice(dtpBegin.Value, Conversions.ToInteger(cComboItem2.Value), Conversions.ToInteger(cComboItem3.Value), Module1.pubGroupId);
					IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataRow dataRow2 = (DataRow)enumerator2.Current;
						if (Operators.ConditionalCompareObjectEqual(dataRow2["penjBsType"], 0, TextCompare: false))
						{
							if (Operators.ConditionalCompareObjectEqual(dataRow2["penjKode"], 0, TextCompare: false))
							{
								num4 = Conversions.ToDouble(Operators.AddObject(num4, dataRow2["penjTotal"]));
								num5 = Conversions.ToDouble(Operators.AddObject(num5, dataRow2["penjDisc"]));
								num6 = Conversions.ToDouble(Operators.AddObject(num6, dataRow2["penjPot"]));
							}
							else
							{
								num7 = Conversions.ToDouble(Operators.AddObject(num7, dataRow2["penjTotal"]));
								num8 = Conversions.ToDouble(Operators.AddObject(num8, dataRow2["penjDisc"]));
							}
						}
						else if (Operators.ConditionalCompareObjectEqual(dataRow2["penjKode"], 0, TextCompare: false))
						{
							num9 = Conversions.ToDouble(Operators.AddObject(num9, Operators.AddObject(Operators.AddObject(dataRow2["penjBs"], dataRow2["penjDisc"]), dataRow2["penjPot"])));
						}
						else
						{
							num10 = Conversions.ToDouble(Operators.AddObject(num10, Operators.AddObject(Operators.AddObject(dataRow2["penjBs"], dataRow2["penjDisc"]), dataRow2["penjPot"])));
						}
					}
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
					lblTotalCashInvoice.Text = Module1.formatCustomDecimal(Conversions.ToString(num4), 2);
					lblTotalCreditInvoice.Text = Module1.formatCustomDecimal(Conversions.ToString(num7), 2);
					dataTable = cSalesPerson.SearchPayment(dtpBegin.Value, Conversions.ToInteger(cComboItem2.Value), Conversions.ToInteger(cComboItem3.Value), Module1.pubGroupId);
					IEnumerator enumerator3 = dataTable.Rows.GetEnumerator();
					while (enumerator3.MoveNext())
					{
						DataRow dataRow3 = (DataRow)enumerator3.Current;
						if (Operators.ConditionalCompareObjectEqual(dataRow3["penjBsType"], 0, TextCompare: false))
						{
							if (Operators.ConditionalCompareObjectEqual(dataRow3["penjKode"], 1, TextCompare: false))
							{
								num11 = Conversions.ToDouble(Operators.AddObject(num11, dataRow3["pbAmount"]));
							}
							if (Operators.ConditionalCompareObjectEqual(dataRow3["pkId"], 2, TextCompare: false))
							{
								num12 = Conversions.ToDouble(Operators.AddObject(num12, dataRow3["pbAmount"]));
							}
							else if (Operators.ConditionalCompareObjectEqual(dataRow3["pkId"], 3, TextCompare: false))
							{
								num13 = Conversions.ToDouble(Operators.AddObject(num13, dataRow3["pbAmount"]));
							}
						}
						else if (Operators.ConditionalCompareObjectEqual(dataRow3["penjKode"], 1, TextCompare: false))
						{
							num14 = Conversions.ToDouble(Operators.AddObject(num14, Operators.MultiplyObject(dataRow3["pbAmount"], -1)));
						}
					}
					if (enumerator3 is IDisposable)
					{
						(enumerator3 as IDisposable).Dispose();
					}
					lblTotalCheque.Text = Module1.formatCustomDecimal(Conversions.ToString(num12), 2);
					lblTotalTransfer.Text = Module1.formatCustomDecimal(Conversions.ToString(num13), 2);
					double creditPaymentDiscount = cSalesPerson.GetCreditPaymentDiscount(dtpBegin.Value, Conversions.ToInteger(cComboItem2.Value), Conversions.ToInteger(cComboItem3.Value), Module1.pubGroupId);
					lblTotalCreditPayment.Text = Module1.formatCustomDecimal(Conversions.ToString(num11 + creditPaymentDiscount), 2);
					lblTotalPaymentReceived.Text = Module1.formatCustomDecimal(Conversions.ToString(num4 + num11), 2);
					dataTable = cSalesPerson.SearchExpense(dtpBegin.Value, Conversions.ToInteger(cComboItem2.Value), Conversions.ToInteger(cComboItem3.Value), Module1.pubGroupId);
					IEnumerator enumerator4 = dataTable.Rows.GetEnumerator();
					while (enumerator4.MoveNext())
					{
						DataRow dataRow4 = (DataRow)enumerator4.Current;
						dgvExpense.Rows.Add(dataRow4["voucherDescription"], "", Module1.formatCustomDecimal(Conversions.ToString(dataRow4["voucherAmount"]), 2));
						num15 = Conversions.ToDouble(Operators.AddObject(num15, dataRow4["voucherAmount"]));
					}
					if (enumerator4 is IDisposable)
					{
						(enumerator4 as IDisposable).Dispose();
					}
					if (num9 > 0.0)
					{
						dgvExpense.Rows.Add("");
						dgvExpense.Rows.Add("Retur Tunai", "", Module1.formatCustomDecimal(Conversions.ToString(num9), 2));
					}
					if (num14 > 0.0)
					{
						dgvExpense.Rows.Add("");
						dgvExpense.Rows.Add("Pembayaran Retur Kredit", "", Module1.formatCustomDecimal(Conversions.ToString(num14), 2));
					}
					if (creditPaymentDiscount > 0.0)
					{
						dgvExpense.Rows.Add("");
						dgvExpense.Rows.Add("Lain-lain Penjualan Kredit", "", Module1.formatCustomDecimal(Conversions.ToString(creditPaymentDiscount), 2));
					}
					lblTotalCreditReturn.Text = Module1.formatCustomDecimal(Conversions.ToString(num10), 2);
					lblTotalCreditDiscount.Text = Module1.formatCustomDecimal(Conversions.ToString(num8), 2);
					lblTotalExpense.Text = Module1.formatCustomDecimal(Conversions.ToString(num15 + num5 + num6 + num9 + creditPaymentDiscount), 2);
					lblTotalDeposit.Text = Conversions.ToString(Conversions.ToDouble(lblTotalPaymentReceived.Text) + Conversion.Val(Module1.unformatNumber(txtBon.Text)) - Conversions.ToDouble(lblTotalExpense.Text));
					lblTotalDeposit.Text = Module1.formatCustomDecimal(lblTotalDeposit.Text, 2);
					if (Module1.pubPreviewReport)
					{
						btnExcel.Enabled = true;
					}
					if (Module1.pubPrintReport)
					{
						btnPrint.Enabled = true;
					}
					Cursor = Cursors.Default;
					goto end_IL_0001;
				}
				case 2524:
					num = -1;
					switch (num2)
					{
					case 2:
						Cursor = Cursors.Default;
						Module1.SaveError(Information.Err(), "frmReportSalesPerson", "btnSearch_click", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 2524;
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
		dgvItem.Rows.Clear();
		dgvItem.Columns.Clear();
		dgvItem.Columns.Add("", "Bal");
		dgvItem.Columns.Add("", "Barang");
		dgvItem.Columns.Add("", "");
		dgvItem.Columns.Add("", "Harga");
		dgvItem.Columns.Add("", "");
		dgvItem.Columns.Add("", "Jumlah");
		dgvItem.Columns[0].Width = 40;
		dgvItem.Columns[1].Width = 100;
		dgvItem.Columns[2].Width = 15;
		dgvItem.Columns[3].Width = 60;
		dgvItem.Columns[4].Width = 25;
		dgvItem.Columns[5].Width = 80;
		dgvItem.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItem.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		dgvItem.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItem.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItem.RowHeadersVisible = false;
		dgvItem.AllowUserToAddRows = false;
		dgvItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvItem.ReadOnly = true;
		dgvItem.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvItem.AllowUserToResizeRows = false;
		foreach (object column in dgvItem.Columns)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(column);
			NewLateBinding.LateSet(objectValue, null, "SortMode", new object[1] { DataGridViewColumnSortMode.NotSortable }, null, null);
		}
		dgvItem.DefaultCellStyle.Font = new Font("Segoe UI", 8f, FontStyle.Regular);
		dgvExpense.Rows.Clear();
		dgvExpense.Columns.Clear();
		dgvExpense.Columns.Add("", "Biaya");
		dgvExpense.Columns.Add("", "");
		dgvExpense.Columns.Add("", "Jumlah");
		dgvExpense.Columns[0].Width = 230;
		dgvExpense.Columns[1].Width = 1;
		dgvExpense.Columns[2].Width = 70;
		dgvExpense.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvExpense.RowHeadersVisible = false;
		dgvExpense.AllowUserToAddRows = false;
		dgvExpense.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvExpense.ReadOnly = true;
		dgvExpense.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvExpense.AllowUserToResizeRows = false;
		foreach (object column2 in dgvExpense.Columns)
		{
			object objectValue2 = RuntimeHelpers.GetObjectValue(column2);
			NewLateBinding.LateSet(objectValue2, null, "SortMode", new object[1] { DataGridViewColumnSortMode.NotSortable }, null, null);
		}
		dgvExpense.DefaultCellStyle.Font = new Font("Segoe UI", 8f, FontStyle.Regular);
	}

	private void dgvItem_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			e.SuppressKeyPress = true;
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			btnReset.Focus();
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			btnPrint.Focus();
			e.SuppressKeyPress = true;
		}
	}

	private void dgvItem_GotFocus(object sender, EventArgs e)
	{
		btnSearch.NotifyDefault(value: false);
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

	private void btnReset_Click(object sender, EventArgs e)
	{
		prepareForm();
	}

	private void txtBon_TextChanged(object sender, EventArgs e)
	{
		lblTotalDeposit.Text = Conversions.ToString(Conversion.Val(Module1.unformatNumber(lblTotalPaymentReceived.Text)) + Conversion.Val(Module1.unformatNumber(txtBon.Text)) - Conversion.Val(Module1.unformatNumber(lblTotalExpense.Text)));
		lblTotalDeposit.Text = Module1.formatCustomDecimal(lblTotalDeposit.Text, 2);
	}

	private void btnExcel_Click(object sender, EventArgs e)
	{
		ExportReport(Print: false);
	}

	private void btnPrint_Click(object sender, EventArgs e)
	{
		ExportReport(Print: true);
	}

	private void ExportReport(bool Print)
	{
		checked
		{
			if (Operators.CompareString(txtDriver.Text, "", TextCompare: false) == 0)
			{
				Interaction.MsgBox("Masukkan nama sopir.", MsgBoxStyle.Information);
				txtDriver.Focus();
			}
			else if (Operators.CompareString(txtKernet.Text, "", TextCompare: false) == 0)
			{
				Interaction.MsgBox("Masukkan nama kernet.", MsgBoxStyle.Information);
				txtKernet.Focus();
			}
			else if (Conversion.Val(Module1.unformatNumber(txtPaper.Text)) + Conversion.Val(Module1.unformatNumber(txtCoin.Text)) + Conversion.Val(Module1.unformatNumber(lblTotalCheque.Text)) + Conversion.Val(Module1.unformatNumber(lblTotalTransfer.Text)) != Conversion.Val(Module1.unformatNumber(lblTotalPaymentReceived.Text)))
			{
				Interaction.MsgBox("Jumlah Uang Kertas+Uang Logam+Cek/Giro+Transfer tidak sama dengan jumlah yang diterima (" + lblTotalPaymentReceived.Text + ").", MsgBoxStyle.Information);
				txtPaper.Focus();
			}
			else if (!Print || MessageBox.Show("Cetak Report?", "Konfirmasi", MessageBoxButtons.YesNo) != DialogResult.No)
			{
				Excel.Application application = (Excel.Application)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
				Workbook workbook = application.Workbooks.Open(System.Windows.Forms.Application.StartupPath + "\\templates\\LPPS_template.xls", RuntimeHelpers.GetObjectValue(Missing.Value), true, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
				string left = "";
				int num = dgvItem.RowCount - 1;
				for (int i = 0; i <= num; i++)
				{
					left = Conversions.ToString(Operators.ConcatenateObject(left, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Module1.unformatNumber(Conversions.ToString(dgvItem[0, i].Value)) + "\t", dgvItem[1, i].Value), "\t"), "x"), "\t"), Module1.unformatNumber(Conversions.ToString(dgvItem[3, i].Value))), "\t"), "Rp."), "\t"), Module1.unformatNumber(Conversions.ToString(dgvItem[5, i].Value))), "\r\n")));
				}
				if (Operators.CompareString(left, "", TextCompare: false) != 0)
				{
					Clipboard.SetText(left);
					((_Application)application).get_Range((object)"A11", RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
					NewLateBinding.LateCall(application.ActiveSheet, null, "Paste", new object[0], null, null, null, IgnoreReturn: true);
				}
				application.Cells[42, 6] = Module1.unformatNumber(lblTotalCreditInvoice.Text);
				application.Cells[44, 6] = Module1.unformatNumber(lblTotalCreditPayment.Text);
				left = "";
				int num2 = dgvExpense.RowCount - 1;
				for (int i = 0; i <= num2; i++)
				{
					left = Conversions.ToString(Operators.ConcatenateObject(left, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(dgvExpense[0, i].Value, "\t"), "\t"), Module1.unformatNumber(Conversions.ToString(dgvExpense[2, i].Value))), "\r\n")));
				}
				if (Operators.CompareString(left, "", TextCompare: false) != 0)
				{
					Clipboard.SetText(left);
					((_Application)application).get_Range((object)"H11", RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
					NewLateBinding.LateCall(application.ActiveSheet, null, "Paste", new object[0], null, null, null, IgnoreReturn: true);
				}
				application.Cells[44, 10] = Module1.unformatNumber(lblTotalCreditReturn.Text);
				application.Cells[45, 10] = Module1.unformatNumber(lblTotalCreditDiscount.Text);
				application.Cells[4, 4] = Strings.FormatDateTime(dtpBegin.Value, DateFormat.LongDate);
				application.Cells[47, 9] = Strings.FormatDateTime(dtpBegin.Value, DateFormat.LongDate);
				if (cboSalesPerson.SelectedIndex > 0)
				{
					application.Cells[5, 4] = cboSalesPerson.Text;
				}
				application.Cells[6, 4] = txtDriver.Text;
				application.Cells[7, 4] = txtKernet.Text;
				application.Cells[3, 10] = Module1.unformatNumber(txtPaper.Text);
				application.Cells[4, 10] = Module1.unformatNumber(txtCoin.Text);
				application.Cells[5, 10] = Module1.unformatNumber(lblTotalCheque.Text);
				application.Cells[6, 10] = Module1.unformatNumber(lblTotalTransfer.Text);
				NewLateBinding.LateSetComplex(application.Cells[7, 10], null, "Value2", new object[1] { Module1.unformatNumber(lblTotalDeposit.Text) }, null, null, OptimisticSet: false, RValueBase: true);
				application.Cells[8, 10] = Module1.unformatNumber(txtBon.Text);
				if (Print)
				{
					workbook.PrintOut(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
					workbook.Close(false, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
					application.Quit();
				}
				else
				{
					application.Visible = true;
				}
				workbook = null;
				application = null;
			}
		}
	}

	private void btnEmpty_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show("Cetak Kosong?", "Konfirmasi", MessageBoxButtons.YesNo) != DialogResult.No)
		{
			Excel.Application application = (Excel.Application)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
			Workbook workbook = application.Workbooks.Open(System.Windows.Forms.Application.StartupPath + "\\templates\\LPPS.xls", RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
			application.Cells[4, 4] = Strings.FormatDateTime(dtpBegin.Value, DateFormat.LongDate);
			application.Cells[47, 9] = Strings.FormatDateTime(dtpBegin.Value, DateFormat.LongDate);
			if (cboSalesPerson.SelectedIndex > 0)
			{
				application.Cells[5, 4] = cboSalesPerson.Text;
			}
			workbook.PrintOut(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
			workbook.Close(false, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
			application.Quit();
			application = null;
			workbook = null;
		}
	}
}
