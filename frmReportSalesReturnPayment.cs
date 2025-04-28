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
using Microsoft.VisualBasic.PowerPacks;

namespace GCUv2;

[DesignerGenerated]
public class frmReportSalesReturnPayment : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnAllCustomer")]
	private Button _btnAllCustomer;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSearchCustomer")]
	private Button _btnSearchCustomer;

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
	[AccessedThroughProperty("btnWord")]
	private Button _btnWord;

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
	[AccessedThroughProperty("dtpEnd")]
	private DateTimePicker _dtpEnd;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dtpBegin")]
	private DateTimePicker _dtpBegin;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnPrint")]
	private Button _btnPrint;

	private double _customerId;

	internal virtual Button btnAllCustomer
	{
		[CompilerGenerated]
		get
		{
			return _btnAllCustomer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnAllCustomer_Click;
			Button button = _btnAllCustomer;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnAllCustomer = value;
			button = _btnAllCustomer;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button btnSearchCustomer
	{
		[CompilerGenerated]
		get
		{
			return _btnSearchCustomer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnSearchCustomer_Click;
			Button button = _btnSearchCustomer;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnSearchCustomer = value;
			button = _btnSearchCustomer;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("lblCustomerName")]
	internal virtual Label lblCustomerName
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

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboPaymentCode")]
	internal virtual ComboBox cboPaymentCode
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

	[field: AccessedThroughProperty("cboStorage")]
	internal virtual ComboBox cboStorage
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

	internal virtual Button btnWord
	{
		[CompilerGenerated]
		get
		{
			return _btnWord;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnWord_Click;
			Button button = _btnWord;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnWord = value;
			button = _btnWord;
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

	[field: AccessedThroughProperty("lblTotal")]
	internal virtual Label lblTotal
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
			EventHandler value2 = dgvList_DoubleClick;
			KeyEventHandler value3 = dgvList_KeyDown;
			EventHandler value4 = dgvList_GotFocus;
			EventHandler value5 = dgvList_LostFocus;
			DataGridView dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.DoubleClick -= value2;
				dataGridView.KeyDown -= value3;
				dataGridView.GotFocus -= value4;
				dataGridView.LostFocus -= value5;
			}
			_dgvList = value;
			dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.DoubleClick += value2;
				dataGridView.KeyDown += value3;
				dataGridView.GotFocus += value4;
				dataGridView.LostFocus += value5;
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DateTimePicker dtpEnd
	{
		[CompilerGenerated]
		get
		{
			return _dtpEnd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = dtpEnd_KeyDown;
			DateTimePicker dateTimePicker = _dtpEnd;
			if (dateTimePicker != null)
			{
				dateTimePicker.KeyDown -= value2;
			}
			_dtpEnd = value;
			dateTimePicker = _dtpEnd;
			if (dateTimePicker != null)
			{
				dateTimePicker.KeyDown += value2;
			}
		}
	}

	internal virtual DateTimePicker dtpBegin
	{
		[CompilerGenerated]
		get
		{
			return _dtpBegin;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = dtpBegin_KeyDown;
			DateTimePicker dateTimePicker = _dtpBegin;
			if (dateTimePicker != null)
			{
				dateTimePicker.KeyDown -= value2;
			}
			_dtpBegin = value;
			dateTimePicker = _dtpBegin;
			if (dateTimePicker != null)
			{
				dateTimePicker.KeyDown += value2;
			}
		}
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

	[field: AccessedThroughProperty("ShapeContainer1")]
	internal virtual ShapeContainer ShapeContainer1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		this.btnAllCustomer = new System.Windows.Forms.Button();
		this.btnSearchCustomer = new System.Windows.Forms.Button();
		this.lblCustomerName = new System.Windows.Forms.Label();
		this.Label9 = new System.Windows.Forms.Label();
		this.Label10 = new System.Windows.Forms.Label();
		this.cboCollector = new System.Windows.Forms.ComboBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.cboPaymentCode = new System.Windows.Forms.ComboBox();
		this.Label6 = new System.Windows.Forms.Label();
		this.cboStorage = new System.Windows.Forms.ComboBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.cboBranch = new System.Windows.Forms.ComboBox();
		this.btnReset = new System.Windows.Forms.Button();
		this.btnWord = new System.Windows.Forms.Button();
		this.Label1 = new System.Windows.Forms.Label();
		this.lblTotal = new System.Windows.Forms.Label();
		this.dgvList = new System.Windows.Forms.DataGridView();
		this.btnSearch = new System.Windows.Forms.Button();
		this.Label2 = new System.Windows.Forms.Label();
		this.dtpEnd = new System.Windows.Forms.DateTimePicker();
		this.dtpBegin = new System.Windows.Forms.DateTimePicker();
		this.LineShape2 = new LineShape();
		this.LineShape1 = new LineShape();
		this.ShapeContainer1 = new ShapeContainer();
		this.btnPrint = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		base.SuspendLayout();
		this.btnAllCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAllCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAllCustomer.Location = new System.Drawing.Point(73, 124);
		this.btnAllCustomer.Name = "btnAllCustomer";
		this.btnAllCustomer.Size = new System.Drawing.Size(50, 23);
		this.btnAllCustomer.TabIndex = 4;
		this.btnAllCustomer.Text = "Semua";
		this.btnAllCustomer.UseVisualStyleBackColor = true;
		this.btnSearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnSearchCustomer.Location = new System.Drawing.Point(129, 124);
		this.btnSearchCustomer.Name = "btnSearchCustomer";
		this.btnSearchCustomer.Size = new System.Drawing.Size(92, 23);
		this.btnSearchCustomer.TabIndex = 5;
		this.btnSearchCustomer.Text = "Pilih Customer";
		this.btnSearchCustomer.UseVisualStyleBackColor = true;
		this.lblCustomerName.AutoSize = true;
		this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblCustomerName.Location = new System.Drawing.Point(100, 152);
		this.lblCustomerName.Name = "lblCustomerName";
		this.lblCustomerName.Size = new System.Drawing.Size(63, 13);
		this.lblCustomerName.TabIndex = 267;
		this.lblCustomerName.Text = "-- SEMUA --";
		this.Label9.AutoSize = true;
		this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label9.Location = new System.Drawing.Point(12, 152);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(51, 13);
		this.Label9.TabIndex = 266;
		this.Label9.Text = "Customer";
		this.Label10.AutoSize = true;
		this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label10.Location = new System.Drawing.Point(10, 208);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(46, 13);
		this.Label10.TabIndex = 263;
		this.Label10.Text = "Penagih";
		this.cboCollector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboCollector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboCollector.FormattingEnabled = true;
		this.cboCollector.Location = new System.Drawing.Point(101, 205);
		this.cboCollector.Name = "cboCollector";
		this.cboCollector.Size = new System.Drawing.Size(120, 21);
		this.cboCollector.TabIndex = 7;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(9, 181);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(58, 13);
		this.Label5.TabIndex = 262;
		this.Label5.Text = "Tipe Bayar";
		this.cboPaymentCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboPaymentCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboPaymentCode.FormattingEnabled = true;
		this.cboPaymentCode.Location = new System.Drawing.Point(100, 178);
		this.cboPaymentCode.Name = "cboPaymentCode";
		this.cboPaymentCode.Size = new System.Drawing.Size(120, 21);
		this.cboPaymentCode.TabIndex = 6;
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.Location = new System.Drawing.Point(10, 94);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(45, 13);
		this.Label6.TabIndex = 261;
		this.Label6.Text = "Gudang";
		this.cboStorage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboStorage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboStorage.FormattingEnabled = true;
		this.cboStorage.Location = new System.Drawing.Point(101, 91);
		this.cboStorage.Name = "cboStorage";
		this.cboStorage.Size = new System.Drawing.Size(120, 21);
		this.cboStorage.TabIndex = 3;
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(10, 67);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(44, 13);
		this.Label3.TabIndex = 260;
		this.Label3.Text = "Cabang";
		this.cboBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboBranch.FormattingEnabled = true;
		this.cboBranch.Location = new System.Drawing.Point(101, 64);
		this.cboBranch.Name = "cboBranch";
		this.cboBranch.Size = new System.Drawing.Size(120, 21);
		this.cboBranch.TabIndex = 2;
		this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnReset.Location = new System.Drawing.Point(156, 232);
		this.btnReset.Name = "btnReset";
		this.btnReset.Size = new System.Drawing.Size(47, 24);
		this.btnReset.TabIndex = 12;
		this.btnReset.Text = "&Reset";
		this.btnReset.UseVisualStyleBackColor = true;
		this.btnWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnWord.Location = new System.Drawing.Point(796, 490);
		this.btnWord.Name = "btnWord";
		this.btnWord.Size = new System.Drawing.Size(73, 23);
		this.btnWord.TabIndex = 14;
		this.btnWord.Text = "&Word";
		this.btnWord.UseVisualStyleBackColor = true;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(10, 15);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(71, 13);
		this.Label1.TabIndex = 259;
		this.Label1.Text = "Tanggal awal";
		this.lblTotal.AutoSize = true;
		this.lblTotal.Location = new System.Drawing.Point(234, 495);
		this.lblTotal.Name = "lblTotal";
		this.lblTotal.Size = new System.Drawing.Size(91, 13);
		this.lblTotal.TabIndex = 258;
		this.lblTotal.Text = "Total Pencarian: -";
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.Location = new System.Drawing.Point(237, 12);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(711, 472);
		this.dgvList.TabIndex = 13;
		this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSearch.Location = new System.Drawing.Point(102, 232);
		this.btnSearch.Name = "btnSearch";
		this.btnSearch.Size = new System.Drawing.Size(47, 24);
		this.btnSearch.TabIndex = 11;
		this.btnSearch.Text = "&Cari";
		this.btnSearch.UseVisualStyleBackColor = true;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(10, 41);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(72, 13);
		this.Label2.TabIndex = 257;
		this.Label2.Text = "Tanggal akhir";
		this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpEnd.Location = new System.Drawing.Point(100, 38);
		this.dtpEnd.Name = "dtpEnd";
		this.dtpEnd.Size = new System.Drawing.Size(121, 20);
		this.dtpEnd.TabIndex = 1;
		this.dtpBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpBegin.Location = new System.Drawing.Point(100, 12);
		this.dtpBegin.Name = "dtpBegin";
		this.dtpBegin.Size = new System.Drawing.Size(121, 20);
		this.dtpBegin.TabIndex = 0;
		((Shape)this.LineShape2).Name = "LineShape2";
		this.LineShape2.X1 = 14;
		this.LineShape2.X2 = 220;
		this.LineShape2.Y1 = 117;
		this.LineShape2.Y2 = 117;
		((Shape)this.LineShape1).Name = "LineShape1";
		this.LineShape1.X1 = 14;
		this.LineShape1.X2 = 220;
		this.LineShape1.Y1 = 169;
		this.LineShape1.Y2 = 169;
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).Location = new System.Drawing.Point(0, 0);
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).Margin = new System.Windows.Forms.Padding(0);
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).Name = "ShapeContainer1";
		this.ShapeContainer1.Shapes.AddRange((Shape[])(object)new Shape[2]
		{
			(Shape)this.LineShape1,
			(Shape)this.LineShape2
		});
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).Size = new System.Drawing.Size(962, 522);
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).TabIndex = 268;
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).TabStop = false;
		this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnPrint.Location = new System.Drawing.Point(875, 490);
		this.btnPrint.Name = "btnPrint";
		this.btnPrint.Size = new System.Drawing.Size(73, 23);
		this.btnPrint.TabIndex = 15;
		this.btnPrint.Text = "Cetak";
		this.btnPrint.UseVisualStyleBackColor = true;
		base.AcceptButton = this.btnSearch;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(962, 522);
		base.Controls.Add(this.btnPrint);
		base.Controls.Add(this.btnAllCustomer);
		base.Controls.Add(this.btnSearchCustomer);
		base.Controls.Add(this.lblCustomerName);
		base.Controls.Add(this.Label9);
		base.Controls.Add(this.Label10);
		base.Controls.Add(this.cboCollector);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.cboPaymentCode);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.cboStorage);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.cboBranch);
		base.Controls.Add(this.btnReset);
		base.Controls.Add(this.btnWord);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.lblTotal);
		base.Controls.Add(this.dgvList);
		base.Controls.Add(this.btnSearch);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.dtpEnd);
		base.Controls.Add(this.dtpBegin);
		base.Controls.Add((System.Windows.Forms.Control)(object)this.ShapeContainer1);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmReportSalesReturnPayment";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Report Pembayaran Retur Penjualan";
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmReportSalesReturnPayment()
	{
		base.KeyDown += frmreportSalesReturnPayment_KeyDown;
		base.Load += frmreportSalesReturnPayment_Load;
		InitializeComponent();
		DoubleBuffered = true;
		base.MdiParent = MyProject.Forms.frmMenu;
		ComboBox combo = cboBranch;
		cCombo.getBranch(ref combo, Module1.pubGroupId, blnAll: true);
		cboBranch = combo;
		combo = cboPaymentCode;
		cCombo.getPaymentCode(ref combo, All: true, ShowCheque: true);
		cboPaymentCode = combo;
		cboPaymentCode.SelectedIndex = 0;
		cboBranch.SelectedIndex = 0;
	}

	private void frmreportSalesReturnPayment_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void frmreportSalesReturnPayment_Load(object sender, EventArgs e)
	{
		prepareForm();
		ExtensionMethods.DoubleBuffered(dgvList, setting: true);
	}

	private void prepareForm()
	{
		btnWord.Enabled = false;
		btnPrint.Enabled = false;
		dtpBegin.Value = Module1.getFirstDateInMonth(DateAndTime.Now);
		dtpEnd.Value = DateAndTime.Now;
		cboBranch.SelectedIndex = 0;
		cboStorage.SelectedIndex = 0;
		_customerId = 0.0;
		lblCustomerName.Text = "--SEMUA--";
		cboPaymentCode.SelectedIndex = 0;
		cboCollector.SelectedIndex = 0;
		dgvList.Rows.Clear();
		lblTotal.Text = "Total Pencarian: -";
		dtpBegin.Focus();
	}

	private void dtpBegin_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Space)
		{
			dtpEnd.Focus();
			dtpBegin.Focus();
			dtpEnd.Value = dtpBegin.Value;
		}
		else if (e.KeyCode == Keys.ControlKey)
		{
			dtpEnd.Focus();
			dtpBegin.Focus();
			dtpBegin.Value = Module1.getFirstDateInMonth(dtpBegin.Value);
			dtpEnd.Value = Module1.getLastDateInMonth(dtpBegin.Value);
		}
	}

	private void dtpEnd_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Space)
		{
			dtpBegin.Focus();
			dtpEnd.Focus();
			dtpBegin.Value = dtpEnd.Value;
		}
		else if (e.KeyCode == Keys.ControlKey)
		{
			dtpBegin.Focus();
			dtpEnd.Focus();
			dtpBegin.Value = Module1.getFirstDateInMonth(dtpEnd.Value);
			dtpEnd.Value = Module1.getLastDateInMonth(dtpEnd.Value);
		}
	}

	private void cboBranch_SelectedIndexChanged(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboBranch.SelectedItem;
		if (!Information.IsNothing(cComboItem2))
		{
			ComboBox combo = cboStorage;
			cCombo.getStorage(ref combo, Module1.pubGroupId, Conversions.ToInteger(cComboItem2.Value), "MARKETING", blnAll: true, 1);
			cboStorage = combo;
			combo = cboCollector;
			cCombo.getSalesPerson(ref combo, "ALL", 0, 99, Conversions.ToInteger(cComboItem2.Value), Module1.pubGroupId, All: true, Dash: false, 1);
			cboCollector = combo;
			combo = cboStorage;
			Module1.comboBoundValue(ref combo, 0.0);
			cboStorage = combo;
			combo = cboCollector;
			Module1.comboBoundValue(ref combo, 0.0);
			cboCollector = combo;
			_customerId = 0.0;
			lblCustomerName.Text = "--SEMUA--";
		}
	}

	private void btnAllCustomer_Click(object sender, EventArgs e)
	{
		_customerId = 0.0;
		lblCustomerName.Text = "--SEMUA--";
	}

	private void btnSearchCustomer_Click(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboBranch.SelectedItem;
		frmCustomerMiniSearch frmCustomerMiniSearch2 = new frmCustomerMiniSearch();
		frmCustomerMiniSearch2.BranchId = Conversions.ToInteger(cComboItem2.Value);
		frmCustomerMiniSearch2.CallerName = "ReportSalesReturnPayment";
		frmCustomerMiniSearch2.ShowDialog();
		frmCustomerMiniSearch2.Close();
		frmCustomerMiniSearch2.Dispose();
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
					cComboItem cComboItem4 = (cComboItem)cboCollector.SelectedItem;
					cComboItem cComboItem5 = (cComboItem)cboPaymentCode.SelectedItem;
					if (cboBranch.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih cabang", MsgBoxStyle.Information);
						cboBranch.Focus();
						goto end_IL_0001;
					}
					if (cboStorage.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih gudang", MsgBoxStyle.Information);
						cboStorage.Focus();
						goto end_IL_0001;
					}
					if (cboPaymentCode.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih tipe bayar", MsgBoxStyle.Information);
						cboPaymentCode.Focus();
						goto end_IL_0001;
					}
					if (cboCollector.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih penagih", MsgBoxStyle.Information);
						cboCollector.Focus();
						goto end_IL_0001;
					}
					DataTable dataTable = new DataTable();
					Cursor = Cursors.WaitCursor;
					btnSearch.Focus();
					dataTable = cSalesInvoicePayment.Search(1, dtpBegin.Value, dtpEnd.Value, _customerId, Conversions.ToInteger(cComboItem5.Value), Conversions.ToInteger(cComboItem4.Value), 1, Conversions.ToInteger(cComboItem3.Value), Conversions.ToInteger(cComboItem2.Value), Module1.pubGroupId);
					dgvList.Rows.Clear();
					formatGrid();
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						dgvList.Rows.Add(dataRow["penjId"], dataRow["pbgId"], dataRow["paymentDate"], dataRow["custName"], dataRow["pkName"], dataRow["salesName"], Module1.formatCustomDecimal(Conversions.ToString(dataRow["paymentAmount"]), 2), Module1.formatCustomDecimal(Conversions.ToString(dataRow["paymentRemainder"]), 2));
						num3 = Conversions.ToDouble(Operators.AddObject(num3, dataRow["paymentAmount"]));
						num4 = Conversions.ToDouble(Operators.AddObject(num4, dataRow["paymentRemainder"]));
						DataRow dataRow2;
						object[] array;
						bool[] array2;
						object obj = NewLateBinding.LateGet(null, typeof(Strings), "UCase", array = new object[1] { (dataRow2 = dataRow)["pkName"] }, null, null, array2 = new bool[1] { true });
						if (array2[0])
						{
							dataRow2["pkName"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
						}
						if (Operators.CompareString(Strings.Right(Conversions.ToString(obj), 4), "CASH", TextCompare: false) == 0)
						{
							num5 = Conversions.ToDouble(Operators.AddObject(num5, dataRow["paymentAmount"]));
							num6 = Conversions.ToDouble(Operators.AddObject(num6, dataRow["paymentRemainder"]));
							continue;
						}
						Type typeFromHandle = typeof(Strings);
						object[] obj2 = new object[1] { (dataRow2 = dataRow)["pkName"] };
						array = obj2;
						bool[] obj3 = new bool[1] { true };
						array2 = obj3;
						object obj4 = NewLateBinding.LateGet(null, typeFromHandle, "UCase", obj2, null, null, obj3);
						if (array2[0])
						{
							dataRow2["pkName"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
						}
						if (Operators.CompareString(Strings.Right(Conversions.ToString(obj4), 3), "C/G", TextCompare: false) == 0)
						{
							num7 = Conversions.ToDouble(Operators.AddObject(num7, dataRow["paymentAmount"]));
							num8 = Conversions.ToDouble(Operators.AddObject(num8, dataRow["paymentRemainder"]));
						}
						else
						{
							num9 = Conversions.ToDouble(Operators.AddObject(num9, dataRow["paymentAmount"]));
							num10 = Conversions.ToDouble(Operators.AddObject(num10, dataRow["paymentRemainder"]));
						}
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					if (dataTable.Rows.Count == 0)
					{
						Interaction.MsgBox("Data tidak ditemukan", MsgBoxStyle.Information);
						btnWord.Enabled = false;
						btnPrint.Enabled = false;
						dtpBegin.Focus();
					}
					else
					{
						if ((Conversions.ToDouble(cComboItem5.Value) == 0.0) | (Conversions.ToDouble(cComboItem5.Value) == 1.0))
						{
							dgvList.Rows.Add("", "", "Total Cash", "", "", "", Module1.formatCustomDecimal(Conversions.ToString(num5), 2), Module1.formatCustomDecimal(Conversions.ToString(num6), 2));
						}
						if ((Conversions.ToDouble(cComboItem5.Value) == 0.0) | (Conversions.ToDouble(cComboItem5.Value) == 2.0))
						{
							dgvList.Rows.Add("", "", "Total C/G", "", "", "", Module1.formatCustomDecimal(Conversions.ToString(num7), 2), Module1.formatCustomDecimal(Conversions.ToString(num8), 2));
						}
						if ((Conversions.ToDouble(cComboItem5.Value) == 0.0) | (Conversions.ToDouble(cComboItem5.Value) == 3.0))
						{
							dgvList.Rows.Add("", "", "Total LLG", "", "", "", Module1.formatCustomDecimal(Conversions.ToString(num9), 2), Module1.formatCustomDecimal(Conversions.ToString(num10), 2));
						}
						dgvList.Rows.Add("", "", "Total", "", "", "", Module1.formatCustomDecimal(Conversions.ToString(num3), 2), Module1.formatCustomDecimal(Conversions.ToString(num4), 2));
						dgvList.Focus();
						if (Module1.pubPreviewReport)
						{
							btnWord.Enabled = true;
						}
						if (Module1.pubPrintReport)
						{
							btnPrint.Enabled = true;
						}
					}
					lblTotal.Text = "Total Pencarian: " + Conversions.ToString(dataTable.Rows.Count);
					Cursor = Cursors.Default;
					goto end_IL_0001;
				}
				case 1997:
					num = -1;
					switch (num2)
					{
					case 2:
						Cursor = Cursors.Default;
						Module1.SaveError(Information.Err(), "frmReportSalesReturnPayment", "btnSearch_click", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj5) when (obj5 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj5);
				try0001_dispatch = 1997;
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
		dgvList.Columns.Add("", "penjId");
		dgvList.Columns.Add("", "pbgId");
		dgvList.Columns.Add("", "Tanggal");
		dgvList.Columns.Add("", "Customer");
		dgvList.Columns.Add("", "Tipe");
		dgvList.Columns.Add("", "Penagih");
		dgvList.Columns.Add("", "Jumlah");
		dgvList.Columns.Add("", "Sisa");
		dgvList.Columns[0].Visible = false;
		dgvList.Columns[1].Visible = false;
		dgvList.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvList.Columns[2].Width = 70;
		dgvList.Columns[3].Width = 170;
		dgvList.Columns[4].Width = 50;
		dgvList.Columns[5].Width = 120;
		dgvList.Columns[6].Width = 85;
		dgvList.Columns[7].Visible = false;
		dgvList.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.RowHeadersVisible = false;
		dgvList.AllowUserToAddRows = false;
		dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvList.ReadOnly = true;
		dgvList.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvList.AllowUserToResizeRows = false;
		DataGridView grid = dgvList;
		Module1.DisableGridSorting(ref grid);
		dgvList = grid;
		dgvList.DefaultCellStyle.Font = new Font("Segoe UI", 8f, FontStyle.Regular);
	}

	private void dgvList_DoubleClick(object sender, EventArgs e)
	{
		getData();
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

	private void getData()
	{
		if (dgvList.RowCount > 0 && Conversion.Val(RuntimeHelpers.GetObjectValue(dgvList[0, dgvList.CurrentRow.Index].Value)) > 0.0)
		{
			MyProject.Forms.frmSalesReturn.Show();
			MyProject.Forms.frmSalesReturn.prepareForm(SaveNew: false);
			MyProject.Forms.frmSalesReturn.CurrentId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
			MyProject.Forms.frmSalesReturn.LoadData();
			MyProject.Forms.frmSalesReturn.Activate();
			MyProject.Forms.frmSalesReturn.WindowState = FormWindowState.Normal;
		}
	}

	private void btnWord_Click(object sender, EventArgs e)
	{
		ExportReport(Print: false);
	}

	private void ExportReport(bool Print)
	{
		dgvList.SelectAll();
		dgvList.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
		Clipboard.SetDataObject(dgvList.GetClipboardContent());
		dgvList.ClearSelection();
		MsWord msWord = new MsWord();
		msWord.rptWordNew(dgvList.Rows.Count, dgvList.Columns.Count, "LLLLRR", blnPortrait: false, "", Print);
	}

	private void btnReset_Click(object sender, EventArgs e)
	{
		prepareForm();
	}

	private void btnPrint_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show("Cetak Report?", "Konfirmasi", MessageBoxButtons.YesNo) != DialogResult.No)
		{
			ExportReport(Print: true);
		}
	}
}
