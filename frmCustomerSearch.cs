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
public class frmCustomerSearch : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboBranch")]
	private ComboBox _cboBranch;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboMonth")]
	private ComboBox _cboMonth;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSearch")]
	private Button _btnSearch;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnReset")]
	private Button _btnReset;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvList")]
	private DataGridView _dgvList;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("tsbNew")]
	private ToolStripButton _tsbNew;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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

	[field: AccessedThroughProperty("txtAddress")]
	internal virtual TextBox txtAddress
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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
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

	[field: AccessedThroughProperty("cboSalesPerson")]
	internal virtual ComboBox cboSalesPerson
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

	internal virtual ComboBox cboMonth
	{
		[CompilerGenerated]
		get
		{
			return _cboMonth;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cboMonth_SelectedIndexChanged;
			ComboBox comboBox = _cboMonth;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_cboMonth = value;
			comboBox = _cboMonth;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("cboYear")]
	internal virtual ComboBox cboYear
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

	[field: AccessedThroughProperty("Label13")]
	internal virtual Label Label13
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
			KeyEventHandler value2 = dgvList_KeyDown;
			EventHandler value3 = dgvList_GotFocus;
			EventHandler value4 = dgvList_LostFocus;
			EventHandler value5 = dgvList_DoubleClick;
			DataGridView dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.KeyDown -= value2;
				dataGridView.GotFocus -= value3;
				dataGridView.LostFocus -= value4;
				dataGridView.DoubleClick -= value5;
			}
			_dgvList = value;
			dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.KeyDown += value2;
				dataGridView.GotFocus += value3;
				dataGridView.LostFocus += value4;
				dataGridView.DoubleClick += value5;
			}
		}
	}

	[field: AccessedThroughProperty("btnWord")]
	internal virtual Button btnWord
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTotal")]
	internal virtual Label lblTotal
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStrip1")]
	internal virtual ToolStrip ToolStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripButton tsbNew
	{
		[CompilerGenerated]
		get
		{
			return _tsbNew;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = tsbNew_Click;
			ToolStripButton toolStripButton = _tsbNew;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value2;
			}
			_tsbNew = value;
			toolStripButton = _tsbNew;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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

	[field: AccessedThroughProperty("Label15")]
	internal virtual Label Label15
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GCUv2.frmCustomerSearch));
		this.Label1 = new System.Windows.Forms.Label();
		this.txtName = new System.Windows.Forms.TextBox();
		this.txtAddress = new System.Windows.Forms.TextBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.cboBranch = new System.Windows.Forms.ComboBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.cboStorage = new System.Windows.Forms.ComboBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.cboArea = new System.Windows.Forms.ComboBox();
		this.Label6 = new System.Windows.Forms.Label();
		this.cboCustomerCode = new System.Windows.Forms.ComboBox();
		this.Label8 = new System.Windows.Forms.Label();
		this.cboDiscount = new System.Windows.Forms.ComboBox();
		this.Label9 = new System.Windows.Forms.Label();
		this.cboActive = new System.Windows.Forms.ComboBox();
		this.Label10 = new System.Windows.Forms.Label();
		this.cboPriceCode = new System.Windows.Forms.ComboBox();
		this.Label11 = new System.Windows.Forms.Label();
		this.cboSalesPerson = new System.Windows.Forms.ComboBox();
		this.Label12 = new System.Windows.Forms.Label();
		this.cboMonth = new System.Windows.Forms.ComboBox();
		this.cboYear = new System.Windows.Forms.ComboBox();
		this.btnSearch = new System.Windows.Forms.Button();
		this.btnReset = new System.Windows.Forms.Button();
		this.Label13 = new System.Windows.Forms.Label();
		this.Label14 = new System.Windows.Forms.Label();
		this.dgvList = new System.Windows.Forms.DataGridView();
		this.btnWord = new System.Windows.Forms.Button();
		this.lblTotal = new System.Windows.Forms.Label();
		this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
		this.tsbNew = new System.Windows.Forms.ToolStripButton();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label16 = new System.Windows.Forms.Label();
		this.Label15 = new System.Windows.Forms.Label();
		this.Label17 = new System.Windows.Forms.Label();
		this.Label18 = new System.Windows.Forms.Label();
		this.Label19 = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		this.ToolStrip1.SuspendLayout();
		base.SuspendLayout();
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(10, 66);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(35, 13);
		this.Label1.TabIndex = 0;
		this.Label1.Text = "Nama";
		this.txtName.Location = new System.Drawing.Point(89, 63);
		this.txtName.Name = "txtName";
		this.txtName.Size = new System.Drawing.Size(124, 20);
		this.txtName.TabIndex = 0;
		this.txtAddress.Location = new System.Drawing.Point(89, 89);
		this.txtAddress.Name = "txtAddress";
		this.txtAddress.Size = new System.Drawing.Size(124, 20);
		this.txtAddress.TabIndex = 1;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(10, 92);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(39, 13);
		this.Label2.TabIndex = 2;
		this.Label2.Text = "Alamat";
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.Location = new System.Drawing.Point(10, 118);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(44, 13);
		this.Label7.TabIndex = 50;
		this.Label7.Text = "Cabang";
		this.cboBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboBranch.FormattingEnabled = true;
		this.cboBranch.Location = new System.Drawing.Point(89, 115);
		this.cboBranch.Name = "cboBranch";
		this.cboBranch.Size = new System.Drawing.Size(124, 21);
		this.cboBranch.TabIndex = 3;
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(10, 145);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(45, 13);
		this.Label4.TabIndex = 49;
		this.Label4.Text = "Gudang";
		this.cboStorage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboStorage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboStorage.FormattingEnabled = true;
		this.cboStorage.Location = new System.Drawing.Point(89, 142);
		this.cboStorage.Name = "cboStorage";
		this.cboStorage.Size = new System.Drawing.Size(124, 21);
		this.cboStorage.TabIndex = 4;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(10, 186);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(45, 13);
		this.Label5.TabIndex = 54;
		this.Label5.Text = "Wilayah";
		this.cboArea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboArea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboArea.FormattingEnabled = true;
		this.cboArea.Location = new System.Drawing.Point(89, 183);
		this.cboArea.Name = "cboArea";
		this.cboArea.Size = new System.Drawing.Size(124, 21);
		this.cboArea.TabIndex = 5;
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.Location = new System.Drawing.Point(10, 213);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(79, 13);
		this.Label6.TabIndex = 53;
		this.Label6.Text = "Kode Customer";
		this.cboCustomerCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboCustomerCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboCustomerCode.FormattingEnabled = true;
		this.cboCustomerCode.Location = new System.Drawing.Point(89, 210);
		this.cboCustomerCode.Name = "cboCustomerCode";
		this.cboCustomerCode.Size = new System.Drawing.Size(124, 21);
		this.cboCustomerCode.TabIndex = 6;
		this.Label8.AutoSize = true;
		this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label8.Location = new System.Drawing.Point(10, 267);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(77, 13);
		this.Label8.TabIndex = 62;
		this.Label8.Text = "Kode Discount";
		this.cboDiscount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboDiscount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboDiscount.FormattingEnabled = true;
		this.cboDiscount.Location = new System.Drawing.Point(90, 264);
		this.cboDiscount.Name = "cboDiscount";
		this.cboDiscount.Size = new System.Drawing.Size(124, 21);
		this.cboDiscount.TabIndex = 8;
		this.Label9.AutoSize = true;
		this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label9.Location = new System.Drawing.Point(10, 339);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(37, 13);
		this.Label9.TabIndex = 61;
		this.Label9.Text = "Status";
		this.cboActive.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboActive.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboActive.FormattingEnabled = true;
		this.cboActive.Location = new System.Drawing.Point(89, 336);
		this.cboActive.Name = "cboActive";
		this.cboActive.Size = new System.Drawing.Size(124, 21);
		this.cboActive.TabIndex = 10;
		this.Label10.AutoSize = true;
		this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label10.Location = new System.Drawing.Point(10, 240);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(64, 13);
		this.Label10.TabIndex = 58;
		this.Label10.Text = "Kode Harga";
		this.cboPriceCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboPriceCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboPriceCode.FormattingEnabled = true;
		this.cboPriceCode.Location = new System.Drawing.Point(89, 237);
		this.cboPriceCode.Name = "cboPriceCode";
		this.cboPriceCode.Size = new System.Drawing.Size(124, 21);
		this.cboPriceCode.TabIndex = 7;
		this.Label11.AutoSize = true;
		this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label11.Location = new System.Drawing.Point(10, 312);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(33, 13);
		this.Label11.TabIndex = 57;
		this.Label11.Text = "Sales";
		this.cboSalesPerson.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboSalesPerson.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboSalesPerson.FormattingEnabled = true;
		this.cboSalesPerson.Location = new System.Drawing.Point(89, 309);
		this.cboSalesPerson.Name = "cboSalesPerson";
		this.cboSalesPerson.Size = new System.Drawing.Size(124, 21);
		this.cboSalesPerson.TabIndex = 9;
		this.Label12.AutoSize = true;
		this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label12.Location = new System.Drawing.Point(10, 366);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(58, 13);
		this.Label12.TabIndex = 64;
		this.Label12.Text = "Bulan Aktif";
		this.cboMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboMonth.FormattingEnabled = true;
		this.cboMonth.Location = new System.Drawing.Point(89, 363);
		this.cboMonth.Name = "cboMonth";
		this.cboMonth.Size = new System.Drawing.Size(61, 21);
		this.cboMonth.TabIndex = 11;
		this.cboYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboYear.FormattingEnabled = true;
		this.cboYear.Location = new System.Drawing.Point(156, 363);
		this.cboYear.Name = "cboYear";
		this.cboYear.Size = new System.Drawing.Size(57, 21);
		this.cboYear.TabIndex = 12;
		this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSearch.Location = new System.Drawing.Point(89, 390);
		this.btnSearch.Name = "btnSearch";
		this.btnSearch.Size = new System.Drawing.Size(47, 24);
		this.btnSearch.TabIndex = 20;
		this.btnSearch.Text = "&Cari";
		this.btnSearch.UseVisualStyleBackColor = true;
		this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnReset.Location = new System.Drawing.Point(142, 390);
		this.btnReset.Name = "btnReset";
		this.btnReset.Size = new System.Drawing.Size(47, 24);
		this.btnReset.TabIndex = 21;
		this.btnReset.Text = "&Reset";
		this.btnReset.UseVisualStyleBackColor = true;
		this.Label13.BackColor = System.Drawing.Color.Gray;
		this.Label13.Location = new System.Drawing.Point(-9, 170);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(223, 1);
		this.Label13.TabIndex = 65;
		this.Label14.BackColor = System.Drawing.Color.Gray;
		this.Label14.Location = new System.Drawing.Point(-10, 296);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(223, 1);
		this.Label14.TabIndex = 66;
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.Location = new System.Drawing.Point(229, 63);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(699, 374);
		this.dgvList.TabIndex = 30;
		this.btnWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnWord.Location = new System.Drawing.Point(855, 443);
		this.btnWord.Name = "btnWord";
		this.btnWord.Size = new System.Drawing.Size(73, 23);
		this.btnWord.TabIndex = 81;
		this.btnWord.Text = "&Word";
		this.btnWord.UseVisualStyleBackColor = true;
		this.lblTotal.AutoSize = true;
		this.lblTotal.Location = new System.Drawing.Point(226, 443);
		this.lblTotal.Name = "lblTotal";
		this.lblTotal.Size = new System.Drawing.Size(91, 13);
		this.lblTotal.TabIndex = 82;
		this.lblTotal.Text = "Total Pencarian: -";
		this.ToolStrip1.AutoSize = false;
		this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
		this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.tsbNew });
		this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
		this.ToolStrip1.Name = "ToolStrip1";
		this.ToolStrip1.Size = new System.Drawing.Size(940, 60);
		this.ToolStrip1.TabIndex = 83;
		this.ToolStrip1.Text = "ToolStrip1";
		this.tsbNew.Image = (System.Drawing.Image)resources.GetObject("tsbNew.Image");
		this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.tsbNew.Name = "tsbNew";
		this.tsbNew.Size = new System.Drawing.Size(44, 57);
		this.tsbNew.Text = "&Baru";
		this.tsbNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(226, 9);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(170, 13);
		this.Label3.TabIndex = 84;
		this.Label3.Text = "Shortcut: P = Pesanan Penjualan; ";
		this.Label16.AutoSize = true;
		this.Label16.Location = new System.Drawing.Point(272, 31);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(112, 13);
		this.Label16.TabIndex = 85;
		this.Label16.Text = "R = Retur Penjualan;  ";
		this.Label15.AutoSize = true;
		this.Label15.Location = new System.Drawing.Point(414, 9);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(203, 13);
		this.Label15.TabIndex = 86;
		this.Label15.Text = "D = Delivery Order (Pengiriman Pesanan);";
		this.Label17.AutoSize = true;
		this.Label17.Location = new System.Drawing.Point(627, 9);
		this.Label17.Name = "Label17";
		this.Label17.Size = new System.Drawing.Size(105, 13);
		this.Label17.TabIndex = 87;
		this.Label17.Text = "F = Faktur Penjualan";
		this.Label18.AutoSize = true;
		this.Label18.Location = new System.Drawing.Point(414, 31);
		this.Label18.Name = "Label18";
		this.Label18.Size = new System.Drawing.Size(91, 13);
		this.Label18.TabIndex = 88;
		this.Label18.Text = "B = Pembayaran; ";
		this.Label19.AutoSize = true;
		this.Label19.Location = new System.Drawing.Point(627, 31);
		this.Label19.Name = "Label19";
		this.Label19.Size = new System.Drawing.Size(63, 13);
		this.Label19.TabIndex = 89;
		this.Label19.Text = "K = Kuitansi";
		base.AcceptButton = this.btnSearch;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(940, 481);
		base.Controls.Add(this.Label19);
		base.Controls.Add(this.Label18);
		base.Controls.Add(this.Label17);
		base.Controls.Add(this.Label15);
		base.Controls.Add(this.Label16);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.ToolStrip1);
		base.Controls.Add(this.btnWord);
		base.Controls.Add(this.lblTotal);
		base.Controls.Add(this.dgvList);
		base.Controls.Add(this.Label14);
		base.Controls.Add(this.Label13);
		base.Controls.Add(this.btnSearch);
		base.Controls.Add(this.btnReset);
		base.Controls.Add(this.cboYear);
		base.Controls.Add(this.Label12);
		base.Controls.Add(this.cboMonth);
		base.Controls.Add(this.Label8);
		base.Controls.Add(this.cboDiscount);
		base.Controls.Add(this.Label9);
		base.Controls.Add(this.cboActive);
		base.Controls.Add(this.Label10);
		base.Controls.Add(this.cboPriceCode);
		base.Controls.Add(this.Label11);
		base.Controls.Add(this.cboSalesPerson);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.cboArea);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.cboCustomerCode);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.cboBranch);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.cboStorage);
		base.Controls.Add(this.txtAddress);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.txtName);
		base.Controls.Add(this.Label1);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmCustomerSearch";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Cari Customer";
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		this.ToolStrip1.ResumeLayout(false);
		this.ToolStrip1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmCustomerSearch()
	{
		base.KeyDown += frmCustomerSearch_KeyDown;
		base.Load += frmCustomerSearch_Load;
		InitializeComponent();
		DoubleBuffered = true;
		base.MdiParent = MyProject.Forms.frmMenu;
		ComboBox combo = cboBranch;
		bool branch = cCombo.getBranch(ref combo, Module1.pubGroupId, blnAll: true);
		cboBranch = combo;
		if (!branch)
		{
			cboBranch.Enabled = false;
		}
		combo = cboCustomerCode;
		cCombo.getCustomerCode(ref combo, All: true, 1);
		cboCustomerCode = combo;
		combo = cboPriceCode;
		cCombo.getPriceCode(ref combo, All: true, -1);
		cboPriceCode = combo;
		combo = cboDiscount;
		cCombo.getDiscount(ref combo, All: true, Active: true);
		cboDiscount = combo;
		combo = cboActive;
		cCombo.getActive(ref combo, All: true);
		cboActive = combo;
		combo = cboMonth;
		cCombo.getMonth(ref combo, blnAll: true);
		cboMonth = combo;
		combo = cboYear;
		cCombo.getYear(ref combo, blnAll: false, 2004, 0);
		cboYear = combo;
	}

	private void frmCustomerSearch_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
		else if (e.KeyCode == Keys.F2)
		{
			tsbNew.PerformClick();
		}
	}

	private void frmCustomerSearch_Load(object sender, EventArgs e)
	{
		prepareForm();
	}

	private void prepareForm()
	{
		cboBranch.SelectedIndex = 0;
		cboCustomerCode.SelectedIndex = 0;
		cboPriceCode.SelectedIndex = 0;
		cboDiscount.SelectedIndex = 0;
		cboActive.SelectedIndex = 1;
		cboMonth.SelectedIndex = 0;
		lblTotal.Text = "Total Pencarian: -";
	}

	private void cboBranch_SelectedIndexChanged(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboBranch.SelectedItem;
		ComboBox combo = cboStorage;
		cCombo.getStorage(ref combo, Module1.pubGroupId, Conversions.ToInteger(cComboItem2.Value), "MARKETING", blnAll: true, 1);
		cboStorage = combo;
		combo = cboArea;
		cCombo.getArea(ref combo, Conversions.ToInteger(cComboItem2.Value), Module1.pubGroupId, All: true, Active: true);
		cboArea = combo;
		combo = cboSalesPerson;
		cCombo.getSalesPerson(ref combo, "SALESPERSON", 0, 99, Conversions.ToInteger(cComboItem2.Value), Module1.pubGroupId, All: true, Dash: false, 1);
		cboSalesPerson = combo;
		cboStorage.SelectedIndex = 0;
		cboArea.SelectedIndex = 0;
		cboSalesPerson.SelectedIndex = 0;
	}

	private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (cboMonth.SelectedIndex > 0)
		{
			cboYear.Enabled = true;
		}
		else
		{
			cboYear.Enabled = false;
		}
	}

	private void btnSearch_Click(object sender, EventArgs e)
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
					cComboItem cComboItem2 = (cComboItem)cboBranch.SelectedItem;
					cComboItem cComboItem3 = (cComboItem)cboStorage.SelectedItem;
					cComboItem cComboItem4 = (cComboItem)cboArea.SelectedItem;
					cComboItem cComboItem5 = (cComboItem)cboCustomerCode.SelectedItem;
					cComboItem cComboItem6 = (cComboItem)cboPriceCode.SelectedItem;
					cComboItem cComboItem7 = (cComboItem)cboDiscount.SelectedItem;
					cComboItem cComboItem8 = (cComboItem)cboSalesPerson.SelectedItem;
					cComboItem cComboItem9 = (cComboItem)cboActive.SelectedItem;
					cComboItem cComboItem10 = (cComboItem)cboMonth.SelectedItem;
					cComboItem cComboItem11 = (cComboItem)cboYear.SelectedItem;
					if (cboBranch.SelectedIndex == -1)
					{
						Interaction.MsgBox("Cabang yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
						cboBranch.Focus();
						goto end_IL_0001;
					}
					if (cboStorage.SelectedIndex == -1)
					{
						Interaction.MsgBox("Gudang yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
						cboStorage.Focus();
						goto end_IL_0001;
					}
					if (cboArea.SelectedIndex == -1)
					{
						Interaction.MsgBox("Wilayah yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
						cboArea.Focus();
						goto end_IL_0001;
					}
					if (cboCustomerCode.SelectedIndex == -1)
					{
						Interaction.MsgBox("Kode Customer yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
						cboCustomerCode.Focus();
						goto end_IL_0001;
					}
					if (cboPriceCode.SelectedIndex == -1)
					{
						Interaction.MsgBox("Kode Harga yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
						cboPriceCode.Focus();
						goto end_IL_0001;
					}
					if (cboDiscount.SelectedIndex == -1)
					{
						Interaction.MsgBox("Kode Discount yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
						cboDiscount.Focus();
						goto end_IL_0001;
					}
					if (cboSalesPerson.SelectedIndex == -1)
					{
						Interaction.MsgBox("Sales yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
						cboSalesPerson.Focus();
						goto end_IL_0001;
					}
					if (cboActive.SelectedIndex == -1)
					{
						Interaction.MsgBox("Status yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
						cboActive.Focus();
						goto end_IL_0001;
					}
					if (cboMonth.SelectedIndex == -1)
					{
						Interaction.MsgBox("Bulan yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
						cboMonth.Focus();
						goto end_IL_0001;
					}
					if (cboYear.SelectedIndex == -1)
					{
						Interaction.MsgBox("Tahun yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
						cboYear.Focus();
						goto end_IL_0001;
					}
					DataTable dataTable = new DataTable();
					btnSearch.Focus();
					dataTable = cCustomer.Search(Module1.cleanString(txtName.Text), Module1.cleanString(txtAddress.Text), Conversions.ToInteger(cComboItem5.Value), Conversions.ToInteger(cComboItem8.Value), Conversions.ToInteger(cComboItem6.Value), Conversions.ToInteger(cComboItem4.Value), Conversions.ToInteger(cComboItem7.Value), Conversions.ToInteger(cComboItem9.Value), BelongToGroup: false, Conversions.ToInteger(cComboItem3.Value), Module1.pubGroupId, Conversions.ToInteger(cComboItem2.Value), Conversions.ToInteger(cComboItem10.Value), Conversions.ToInteger(cComboItem11.Value), 99);
					formatGrid();
					dgvList.Rows.Clear();
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						dgvList.Rows.Add(dataRow["custId"], dataRow["custName"], dataRow["custAddress"], dataRow["wilName"], dataRow["ckName"], dataRow["salesName"], dataRow["isParent"]);
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					if (dataTable.Rows.Count == 0)
					{
						Interaction.MsgBox("Data tidak ditemukan", MsgBoxStyle.Information);
						txtName.Focus();
					}
					else
					{
						dgvList.Focus();
					}
					lblTotal.Text = "Total Pencarian: " + Conversions.ToString(dataTable.Rows.Count);
					goto end_IL_0001;
				}
				case 1240:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmCustomerSearch", "btnSearch_click", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1240;
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
		dgvList.Columns.Clear();
		dgvList.Columns.Add("", "custId");
		dgvList.Columns.Add("", "Nama");
		dgvList.Columns.Add("", "Alamat");
		dgvList.Columns.Add("", "Wilayah");
		dgvList.Columns.Add("", "Kode Cust.");
		dgvList.Columns.Add("", "Sales");
		dgvList.Columns.Add("", "IsParent");
		dgvList.Columns[0].Visible = false;
		dgvList.Columns[1].Width = 180;
		dgvList.Columns[2].Width = 200;
		dgvList.Columns[3].Width = 120;
		dgvList.Columns[4].Width = 60;
		dgvList.Columns[5].Width = 100;
		dgvList.Columns[6].Visible = false;
		dgvList.RowHeadersVisible = false;
		dgvList.AllowUserToAddRows = false;
		dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvList.ReadOnly = true;
		dgvList.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvList.AllowUserToResizeRows = false;
	}

	private void dgvList_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			getData();
			e.SuppressKeyPress = true;
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			btnReset.Focus();
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			btnWord.Focus();
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.P && dgvList.RowCount > 0 && Operators.ConditionalCompareObjectGreater(dgvList[0, dgvList.CurrentRow.Index].Value, 0, TextCompare: false) && Operators.ConditionalCompareObjectEqual(dgvList[6, dgvList.CurrentRow.Index].Value, 0, TextCompare: false))
		{
			MyProject.Forms.frmSalesOrder.Show();
			MyProject.Forms.frmSalesOrder.prepareForm(SaveNew: false);
			MyProject.Forms.frmSalesOrder.CustomerId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
			MyProject.Forms.frmSalesOrder.LoadCustomer();
			MyProject.Forms.frmSalesOrder.Activate();
			MyProject.Forms.frmSalesOrder.txtPONumber.Focus();
		}
		else if (e.KeyCode == Keys.D && dgvList.RowCount > 0 && Operators.ConditionalCompareObjectGreater(dgvList[0, dgvList.CurrentRow.Index].Value, 0, TextCompare: false) && Operators.ConditionalCompareObjectEqual(dgvList[6, dgvList.CurrentRow.Index].Value, 0, TextCompare: false))
		{
			MyProject.Forms.frmDeliveryOrder.Show();
			MyProject.Forms.frmDeliveryOrder.prepareForm(SaveNew: false);
			MyProject.Forms.frmDeliveryOrder.CustomerId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
			MyProject.Forms.frmDeliveryOrder.LoadCustomer();
			MyProject.Forms.frmDeliveryOrder.Activate();
			MyProject.Forms.frmDeliveryOrder.dtpDO.Focus();
		}
		else if (e.KeyCode == Keys.F && dgvList.RowCount > 0 && Operators.ConditionalCompareObjectGreater(dgvList[0, dgvList.CurrentRow.Index].Value, 0, TextCompare: false) && Operators.ConditionalCompareObjectEqual(dgvList[6, dgvList.CurrentRow.Index].Value, 0, TextCompare: false))
		{
			if (Module1.pubCreateSalesInvoice)
			{
				MyProject.Forms.frmSalesInvoice.Show();
				MyProject.Forms.frmSalesInvoice.prepareForm(SaveNew: false);
				MyProject.Forms.frmSalesInvoice.CustomerId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
				MyProject.Forms.frmSalesInvoice.LoadCustomer();
				MyProject.Forms.frmSalesInvoice.Activate();
				MyProject.Forms.frmSalesInvoice.dtpInvoice.Focus();
			}
			else
			{
				Interaction.MsgBox("Anda tidak memiliki hak untuk membuat Faktur Penjualan.", MsgBoxStyle.Information);
			}
		}
		else if (e.KeyCode == Keys.R && dgvList.RowCount > 0 && Operators.ConditionalCompareObjectGreater(dgvList[0, dgvList.CurrentRow.Index].Value, 0, TextCompare: false) && Operators.ConditionalCompareObjectEqual(dgvList[6, dgvList.CurrentRow.Index].Value, 0, TextCompare: false))
		{
			if (Module1.pubCreateSalesInvoice)
			{
				MyProject.Forms.frmSalesReturn.Show();
				MyProject.Forms.frmSalesReturn.prepareForm(SaveNew: false);
				MyProject.Forms.frmSalesReturn.CustomerId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
				MyProject.Forms.frmSalesReturn.LoadCustomer();
				MyProject.Forms.frmSalesReturn.Activate();
				MyProject.Forms.frmSalesReturn.dtpInvoice.Focus();
			}
			else
			{
				Interaction.MsgBox("Anda tidak memiliki hak untuk membuat Retur Penjualan.", MsgBoxStyle.Information);
			}
		}
		else if (e.KeyCode == Keys.B && dgvList.RowCount > 0 && Operators.ConditionalCompareObjectGreater(dgvList[0, dgvList.CurrentRow.Index].Value, 0, TextCompare: false))
		{
			if (Module1.pubModifyPaymentInSalesInvoice)
			{
				MyProject.Forms.frmCustomerPayment.Show();
				MyProject.Forms.frmCustomerPayment.PrepareForm(SaveNew: false);
				MyProject.Forms.frmCustomerPayment.CustomerId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
				MyProject.Forms.frmCustomerPayment.LoadCustomer();
				MyProject.Forms.frmCustomerPayment.Activate();
				MyProject.Forms.frmCustomerPayment.dtpPayment.Focus();
			}
			else
			{
				Interaction.MsgBox("Anda tidak memiliki hak untuk membuat Pembayaran.", MsgBoxStyle.Information);
			}
		}
		else if (e.KeyCode == Keys.K && dgvList.RowCount > 0 && Operators.ConditionalCompareObjectGreater(dgvList[0, dgvList.CurrentRow.Index].Value, 0, TextCompare: false) && Operators.ConditionalCompareObjectEqual(dgvList[6, dgvList.CurrentRow.Index].Value, 0, TextCompare: false))
		{
			if (Module1.pubCreateSalesReceipt)
			{
				MyProject.Forms.frmSalesReceipt.Show();
				MyProject.Forms.frmSalesReceipt.prepareForm(SaveNew: false);
				MyProject.Forms.frmSalesReceipt.CustomerId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
				MyProject.Forms.frmSalesReceipt.LoadCustomer();
				MyProject.Forms.frmSalesReceipt.Activate();
				MyProject.Forms.frmSalesReceipt.dtpReceipt.Focus();
			}
			else
			{
				Interaction.MsgBox("Anda tidak memiliki hak untuk membuat Kuitansi.", MsgBoxStyle.Information);
			}
		}
	}

	private void dgvList_GotFocus(object sender, EventArgs e)
	{
		btnSearch.NotifyDefault(value: false);
		if (dgvList.RowCount > 0)
		{
			dgvList.CurrentRow.Selected = true;
		}
	}

	private void dgvList_LostFocus(object sender, EventArgs e)
	{
		if (dgvList.RowCount > 0)
		{
			dgvList.CurrentRow.Selected = false;
		}
	}

	private void dgvList_DoubleClick(object sender, EventArgs e)
	{
		getData();
	}

	public void getData()
	{
		if (dgvList.RowCount > 0 && Operators.ConditionalCompareObjectGreater(dgvList[0, dgvList.CurrentRow.Index].Value, 0, TextCompare: false))
		{
			Cursor = Cursors.WaitCursor;
			MyProject.Forms.frmCustomer.Show();
			MyProject.Forms.frmCustomer.prepareForm();
			MyProject.Forms.frmCustomer.CurrentId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
			MyProject.Forms.frmCustomer.LoadData();
			MyProject.Forms.frmCustomer.Activate();
			MyProject.Forms.frmCustomer.WindowState = FormWindowState.Normal;
			Cursor = Cursors.Default;
		}
	}

	private void btnReset_Click(object sender, EventArgs e)
	{
		prepareForm();
	}

	private void tsbNew_Click(object sender, EventArgs e)
	{
		if (Module1.pubCreateCustomer)
		{
			MyProject.Forms.frmCustomer.Show();
			MyProject.Forms.frmCustomer.prepareForm();
			MyProject.Forms.frmCustomer.Activate();
		}
		else
		{
			Interaction.MsgBox("Anda tidak memiliki hak untuk membuat customer baru.", MsgBoxStyle.Information);
		}
	}
}
