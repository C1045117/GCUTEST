using System;
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
public class frmReportPurchaseReturn : Form
{
	private IContainer components;

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
	[AccessedThroughProperty("cboBaseFilter")]
	private ComboBox _cboBaseFilter;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnPrint")]
	private Button _btnPrint;

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

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboSupplier")]
	internal virtual ComboBox cboSupplier
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

	[field: AccessedThroughProperty("txtInvoiceNo")]
	internal virtual TextBox txtInvoiceNo
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox cboBaseFilter
	{
		[CompilerGenerated]
		get
		{
			return _cboBaseFilter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cboBaseFilter_SelectedIndexChanged;
			ComboBox comboBox = _cboBaseFilter;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_cboBaseFilter = value;
			comboBox = _cboBaseFilter;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboStatus")]
	internal virtual ComboBox cboStatus
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
		this.btnReset = new System.Windows.Forms.Button();
		this.btnWord = new System.Windows.Forms.Button();
		this.Label1 = new System.Windows.Forms.Label();
		this.lblTotal = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.cboSupplier = new System.Windows.Forms.ComboBox();
		this.dgvList = new System.Windows.Forms.DataGridView();
		this.btnSearch = new System.Windows.Forms.Button();
		this.Label2 = new System.Windows.Forms.Label();
		this.dtpEnd = new System.Windows.Forms.DateTimePicker();
		this.dtpBegin = new System.Windows.Forms.DateTimePicker();
		this.txtInvoiceNo = new System.Windows.Forms.TextBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.cboBaseFilter = new System.Windows.Forms.ComboBox();
		this.Label6 = new System.Windows.Forms.Label();
		this.cboStatus = new System.Windows.Forms.ComboBox();
		this.btnPrint = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		base.SuspendLayout();
		this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnReset.Location = new System.Drawing.Point(151, 171);
		this.btnReset.Name = "btnReset";
		this.btnReset.Size = new System.Drawing.Size(47, 24);
		this.btnReset.TabIndex = 6;
		this.btnReset.Text = "&Reset";
		this.btnReset.UseVisualStyleBackColor = true;
		this.btnWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnWord.Location = new System.Drawing.Point(805, 380);
		this.btnWord.Name = "btnWord";
		this.btnWord.Size = new System.Drawing.Size(73, 23);
		this.btnWord.TabIndex = 66;
		this.btnWord.Text = "&Word";
		this.btnWord.UseVisualStyleBackColor = true;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(8, 42);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(71, 13);
		this.Label1.TabIndex = 70;
		this.Label1.Text = "Tanggal awal";
		this.lblTotal.AutoSize = true;
		this.lblTotal.Location = new System.Drawing.Point(246, 380);
		this.lblTotal.Name = "lblTotal";
		this.lblTotal.Size = new System.Drawing.Size(91, 13);
		this.lblTotal.TabIndex = 69;
		this.lblTotal.Text = "Total Pencarian: -";
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.Location = new System.Drawing.Point(8, 120);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(45, 13);
		this.Label7.TabIndex = 68;
		this.Label7.Text = "Supplier";
		this.cboSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboSupplier.FormattingEnabled = true;
		this.cboSupplier.Location = new System.Drawing.Point(98, 117);
		this.cboSupplier.Name = "cboSupplier";
		this.cboSupplier.Size = new System.Drawing.Size(135, 21);
		this.cboSupplier.TabIndex = 4;
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.Location = new System.Drawing.Point(249, 12);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(708, 362);
		this.dgvList.TabIndex = 65;
		this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSearch.Location = new System.Drawing.Point(98, 171);
		this.btnSearch.Name = "btnSearch";
		this.btnSearch.Size = new System.Drawing.Size(47, 24);
		this.btnSearch.TabIndex = 5;
		this.btnSearch.Text = "&Cari";
		this.btnSearch.UseVisualStyleBackColor = true;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(8, 68);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(72, 13);
		this.Label2.TabIndex = 67;
		this.Label2.Text = "Tanggal akhir";
		this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpEnd.Location = new System.Drawing.Point(98, 65);
		this.dtpEnd.Name = "dtpEnd";
		this.dtpEnd.Size = new System.Drawing.Size(135, 20);
		this.dtpEnd.TabIndex = 2;
		this.dtpBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpBegin.Location = new System.Drawing.Point(98, 39);
		this.dtpBegin.Name = "dtpBegin";
		this.dtpBegin.Size = new System.Drawing.Size(135, 20);
		this.dtpBegin.TabIndex = 1;
		this.txtInvoiceNo.Location = new System.Drawing.Point(98, 91);
		this.txtInvoiceNo.Name = "txtInvoiceNo";
		this.txtInvoiceNo.Size = new System.Drawing.Size(135, 20);
		this.txtInvoiceNo.TabIndex = 3;
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(9, 94);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(54, 13);
		this.Label4.TabIndex = 74;
		this.Label4.Text = "No Faktur";
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(8, 15);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(86, 13);
		this.Label3.TabIndex = 73;
		this.Label3.Text = "Dasar Pencarian";
		this.cboBaseFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboBaseFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboBaseFilter.FormattingEnabled = true;
		this.cboBaseFilter.Location = new System.Drawing.Point(98, 12);
		this.cboBaseFilter.Name = "cboBaseFilter";
		this.cboBaseFilter.Size = new System.Drawing.Size(135, 21);
		this.cboBaseFilter.TabIndex = 0;
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.Location = new System.Drawing.Point(10, 147);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(37, 13);
		this.Label6.TabIndex = 76;
		this.Label6.Text = "Status";
		this.cboStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboStatus.FormattingEnabled = true;
		this.cboStatus.Location = new System.Drawing.Point(98, 144);
		this.cboStatus.Name = "cboStatus";
		this.cboStatus.Size = new System.Drawing.Size(135, 21);
		this.cboStatus.TabIndex = 5;
		this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnPrint.Location = new System.Drawing.Point(884, 380);
		this.btnPrint.Name = "btnPrint";
		this.btnPrint.Size = new System.Drawing.Size(73, 23);
		this.btnPrint.TabIndex = 77;
		this.btnPrint.Text = "Cetak";
		this.btnPrint.UseVisualStyleBackColor = true;
		base.AcceptButton = this.btnSearch;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(970, 412);
		base.Controls.Add(this.btnPrint);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.cboStatus);
		base.Controls.Add(this.txtInvoiceNo);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.cboBaseFilter);
		base.Controls.Add(this.btnReset);
		base.Controls.Add(this.btnWord);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.lblTotal);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.cboSupplier);
		base.Controls.Add(this.dgvList);
		base.Controls.Add(this.btnSearch);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.dtpEnd);
		base.Controls.Add(this.dtpBegin);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmReportPurchaseReturn";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Report Retur Pembelian";
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmReportPurchaseReturn()
	{
		base.KeyDown += frmReportPurchaseInvoice_KeyDown;
		base.Load += frmReportPurchaseInvoice_Load;
		InitializeComponent();
		DoubleBuffered = true;
		base.MdiParent = MyProject.Forms.frmMenu;
		ComboBox combo = cboSupplier;
		cCombo.getSupplier(ref combo, Module1.pubGroupId, All: true, FlowerOnly: false, IncludeParent: true, Active: true);
		cboSupplier = combo;
		combo = cboBaseFilter;
		cCombo.getReportPurchaseInvoiceFilter(ref combo);
		cboBaseFilter = combo;
		combo = cboStatus;
		cCombo.getPaymentStatus(ref combo, All: true);
		cboStatus = combo;
		formatGrid();
	}

	private void frmReportPurchaseInvoice_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void frmReportPurchaseInvoice_Load(object sender, EventArgs e)
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
		cboBaseFilter.SelectedIndex = 0;
		cboSupplier.SelectedIndex = 0;
		cboStatus.SelectedIndex = 0;
		txtInvoiceNo.Text = "";
		lblTotal.Text = "Total Pencarian: -";
		dtpBegin.Focus();
	}

	private void cboBaseFilter_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (cboBaseFilter.SelectedIndex == 0)
		{
			dtpBegin.Enabled = true;
			dtpEnd.Enabled = true;
			txtInvoiceNo.Enabled = false;
		}
		else
		{
			dtpBegin.Enabled = false;
			dtpEnd.Enabled = false;
			txtInvoiceNo.Enabled = true;
		}
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

	private void btnSearch_Click(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboBaseFilter.SelectedItem;
		cComboItem cComboItem3 = (cComboItem)cboSupplier.SelectedItem;
		cComboItem cComboItem4 = (cComboItem)cboStatus.SelectedItem;
		if (cboBaseFilter.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih dasar pencarian", MsgBoxStyle.Information);
			cboBaseFilter.Focus();
			return;
		}
		if (cboSupplier.SelectedIndex == -1)
		{
			Interaction.MsgBox("Supplier yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
			cboSupplier.Focus();
			return;
		}
		if (cboStatus.SelectedIndex == -1)
		{
			Interaction.MsgBox("Status yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
			cboStatus.Focus();
			return;
		}
		DataTable dataTable = new DataTable();
		btnSearch.Focus();
		dataTable = cPurchaseInvoice.Search(Conversions.ToInteger(cComboItem2.Value), dtpBegin.Value, dtpEnd.Value, 0, Conversions.ToInteger(cComboItem3.Value), txtInvoiceNo.Text, 99, 1, Module1.pubGroupId, 0, 99, Conversions.ToInteger(cComboItem4.Value), Module1.pubViewReportPurchaseInvoicePrice);
		dgvList.Rows.Clear();
		double num2 = default(double);
		double num3 = default(double);
		double num4 = default(double);
		double num5 = default(double);
		double num6 = default(double);
		double num7 = default(double);
		foreach (DataRow row in dataTable.Rows)
		{
			double num = Conversions.ToDouble(Operators.SubtractObject(row["invReturn"], Operators.MultiplyObject(row["invDiscount"], -1)));
			dgvList.Rows.Add(row["invId"], row["invDate"], row["invNumber"], row["supName"], row["invReturn"], Operators.MultiplyObject(row["invDiscount"], -1), num, Operators.MultiplyObject(row["invPayment"], -1), Operators.MultiplyObject(row["invDeduction"], -1), Operators.MultiplyObject(row["invPayable"], -1), row["invPayableDays"]);
			num2 = Conversions.ToDouble(Operators.AddObject(num2, row["invReturn"]));
			num3 = Conversions.ToDouble(Operators.AddObject(num3, Operators.MultiplyObject(row["invDiscount"], -1)));
			num4 += num;
			num5 = Conversions.ToDouble(Operators.AddObject(num5, Operators.MultiplyObject(row["invPayment"], -1)));
			num6 = Conversions.ToDouble(Operators.AddObject(num6, Operators.MultiplyObject(row["invDeduction"], -1)));
			num7 = Conversions.ToDouble(Operators.AddObject(num7, Operators.MultiplyObject(row["invPayable"], -1)));
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
			dgvList.Rows.Add("", "Total", "", "", num2, num3, num4, num5, num6, num7);
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
		if (!Module1.pubViewReportPurchaseInvoicePrice)
		{
			lblTotal.Text += " (Hanya Retur yang belum memiliki harga)";
		}
	}

	private void formatGrid()
	{
		dgvList.Columns.Add("", "invId");
		dgvList.Columns.Add("", "Tanggal");
		dgvList.Columns.Add("", "No Faktur");
		dgvList.Columns.Add("", "Supplier");
		dgvList.Columns.Add("", "Total Harga");
		dgvList.Columns.Add("", "Diskon");
		dgvList.Columns.Add("", "Total Faktur");
		dgvList.Columns.Add("", "Total Bayar");
		dgvList.Columns.Add("", "Potongan");
		dgvList.Columns.Add("", "Total Piutang");
		dgvList.Columns.Add("", "Umur Piutang");
		dgvList.Columns[0].Visible = false;
		dgvList.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvList.Columns[0].Width = 0;
		dgvList.Columns[1].Width = 63;
		dgvList.Columns[2].Width = 83;
		dgvList.Columns[3].Width = 98;
		dgvList.Columns[4].Width = 70;
		dgvList.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[4].DefaultCellStyle.Format = "N0";
		dgvList.Columns[5].Width = 58;
		dgvList.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[5].DefaultCellStyle.Format = "N0";
		dgvList.Columns[6].Width = 70;
		dgvList.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[6].DefaultCellStyle.Format = "N0";
		dgvList.Columns[7].Width = 70;
		dgvList.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[7].DefaultCellStyle.Format = "N0";
		dgvList.Columns[8].Width = 58;
		dgvList.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[8].DefaultCellStyle.Format = "N0";
		dgvList.Columns[9].Width = 70;
		dgvList.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[9].DefaultCellStyle.Format = "N0";
		dgvList.Columns[10].Width = 44;
		dgvList.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.RowHeadersVisible = false;
		dgvList.AllowUserToAddRows = false;
		dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvList.ReadOnly = true;
		dgvList.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvList.AllowUserToResizeRows = false;
		DataGridView grid = dgvList;
		Module1.DisableGridSorting(ref grid);
		dgvList = grid;
		dgvList.DefaultCellStyle.Font = new Font("Arial", 8f, FontStyle.Regular);
		dgvList.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8f, FontStyle.Regular);
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
			MyProject.Forms.frmPurchaseReturn.Show();
			MyProject.Forms.frmPurchaseReturn.prepareForm(SaveNew: false, KeepSupplier: false);
			MyProject.Forms.frmPurchaseReturn.CurrentId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
			MyProject.Forms.frmPurchaseReturn.LoadData();
			MyProject.Forms.frmPurchaseReturn.Activate();
			MyProject.Forms.frmPurchaseReturn.WindowState = FormWindowState.Normal;
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
		msWord.rptWordNew(dgvList.Rows.Count, dgvList.Columns.Count, "LLLRRRRRRR", blnPortrait: true, "", Print);
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
