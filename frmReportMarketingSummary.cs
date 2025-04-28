using System;
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

namespace GCUv2;

[DesignerGenerated]
public class frmReportMarketingSummary : Form
{
	private IContainer components;

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
	[AccessedThroughProperty("btnReset")]
	private Button _btnReset;

	private Excel.Application _xlApp;

	private Workbook _xlWb;

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboBranch")]
	internal virtual ComboBox cboBranch
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

	[field: AccessedThroughProperty("chkSales")]
	internal virtual CheckBox chkSales
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

	[field: AccessedThroughProperty("chkStok")]
	internal virtual CheckBox chkStok
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkRetur")]
	internal virtual CheckBox chkRetur
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkBPFP")]
	internal virtual CheckBox chkBPFP
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblStatus")]
	internal virtual Label lblStatus
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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
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
		this.Label3 = new System.Windows.Forms.Label();
		this.cboBranch = new System.Windows.Forms.ComboBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.btnSearch = new System.Windows.Forms.Button();
		this.Label2 = new System.Windows.Forms.Label();
		this.dtpEnd = new System.Windows.Forms.DateTimePicker();
		this.dtpBegin = new System.Windows.Forms.DateTimePicker();
		this.btnReset = new System.Windows.Forms.Button();
		this.chkSales = new System.Windows.Forms.CheckBox();
		this.Label6 = new System.Windows.Forms.Label();
		this.chkStok = new System.Windows.Forms.CheckBox();
		this.chkRetur = new System.Windows.Forms.CheckBox();
		this.chkBPFP = new System.Windows.Forms.CheckBox();
		this.lblStatus = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(12, 67);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(44, 13);
		this.Label3.TabIndex = 243;
		this.Label3.Text = "Cabang";
		this.cboBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboBranch.FormattingEnabled = true;
		this.cboBranch.Location = new System.Drawing.Point(103, 64);
		this.cboBranch.Name = "cboBranch";
		this.cboBranch.Size = new System.Drawing.Size(120, 21);
		this.cboBranch.TabIndex = 2;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(12, 15);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(71, 13);
		this.Label1.TabIndex = 242;
		this.Label1.Text = "Tanggal awal";
		this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSearch.Location = new System.Drawing.Point(101, 183);
		this.btnSearch.Name = "btnSearch";
		this.btnSearch.Size = new System.Drawing.Size(47, 24);
		this.btnSearch.TabIndex = 21;
		this.btnSearch.Text = "Excel";
		this.btnSearch.UseVisualStyleBackColor = true;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(12, 41);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(72, 13);
		this.Label2.TabIndex = 241;
		this.Label2.Text = "Tanggal akhir";
		this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpEnd.Location = new System.Drawing.Point(102, 38);
		this.dtpEnd.Name = "dtpEnd";
		this.dtpEnd.Size = new System.Drawing.Size(121, 20);
		this.dtpEnd.TabIndex = 1;
		this.dtpBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpBegin.Location = new System.Drawing.Point(102, 12);
		this.dtpBegin.Name = "dtpBegin";
		this.dtpBegin.Size = new System.Drawing.Size(121, 20);
		this.dtpBegin.TabIndex = 0;
		this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnReset.Location = new System.Drawing.Point(154, 183);
		this.btnReset.Name = "btnReset";
		this.btnReset.Size = new System.Drawing.Size(47, 24);
		this.btnReset.TabIndex = 22;
		this.btnReset.Text = "&Reset";
		this.btnReset.UseVisualStyleBackColor = true;
		this.chkSales.AutoSize = true;
		this.chkSales.Location = new System.Drawing.Point(103, 91);
		this.chkSales.Name = "chkSales";
		this.chkSales.Size = new System.Drawing.Size(163, 17);
		this.chkSales.TabIndex = 3;
		this.chkSales.Text = "Laporan Penjualan Per Sales";
		this.chkSales.UseVisualStyleBackColor = true;
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(12, 92);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(71, 13);
		this.Label6.TabIndex = 247;
		this.Label6.Text = "Daftar Report";
		this.chkStok.AutoSize = true;
		this.chkStok.Location = new System.Drawing.Point(102, 114);
		this.chkStok.Name = "chkStok";
		this.chkStok.Size = new System.Drawing.Size(124, 17);
		this.chkStok.TabIndex = 4;
		this.chkStok.Text = "Rincian Stok Barang";
		this.chkStok.UseVisualStyleBackColor = true;
		this.chkRetur.AutoSize = true;
		this.chkRetur.Location = new System.Drawing.Point(102, 137);
		this.chkRetur.Name = "chkRetur";
		this.chkRetur.Size = new System.Drawing.Size(116, 17);
		this.chkRetur.TabIndex = 5;
		this.chkRetur.Text = "Rincian Stok Retur";
		this.chkRetur.UseVisualStyleBackColor = true;
		this.chkBPFP.AutoSize = true;
		this.chkBPFP.Location = new System.Drawing.Point(102, 160);
		this.chkBPFP.Name = "chkBPFP";
		this.chkBPFP.Size = new System.Drawing.Size(88, 17);
		this.chkBPFP.TabIndex = 6;
		this.chkBPFP.Text = "Rekap BPFP";
		this.chkBPFP.UseVisualStyleBackColor = true;
		this.lblStatus.AutoSize = true;
		this.lblStatus.Location = new System.Drawing.Point(12, 230);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(47, 13);
		this.lblStatus.TabIndex = 248;
		this.lblStatus.Text = "lblStatus";
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(12, 212);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(318, 13);
		this.Label4.TabIndex = 249;
		this.Label4.Text = "Catatan: Pembuatan Report bisa memakan waktu sampai 2 menit.";
		this.Label5.AutoSize = true;
		this.Label5.ForeColor = System.Drawing.Color.Red;
		this.Label5.Location = new System.Drawing.Point(12, 252);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(234, 13);
		this.Label5.TabIndex = 250;
		this.Label5.Text = "Juni 2013: Report ini WAJIB ditest secara detail.";
		this.Label7.AutoSize = true;
		this.Label7.ForeColor = System.Drawing.Color.Red;
		this.Label7.Location = new System.Drawing.Point(12, 270);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(181, 13);
		this.Label7.TabIndex = 251;
		this.Label7.Text = "Kemungkinan besar masih ada BUG.";
		base.AcceptButton = this.btnSearch;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(354, 292);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.lblStatus);
		base.Controls.Add(this.chkBPFP);
		base.Controls.Add(this.chkRetur);
		base.Controls.Add(this.chkStok);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.chkSales);
		base.Controls.Add(this.btnReset);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.cboBranch);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.btnSearch);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.dtpEnd);
		base.Controls.Add(this.dtpBegin);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmReportMarketingSummary";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Report Rangkuman Marketing";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmReportMarketingSummary()
	{
		base.KeyDown += frmReportMarketingSummary_KeyDown;
		base.Load += frmReportMarketingSummary_Load;
		InitializeComponent();
		DoubleBuffered = true;
		base.MdiParent = MyProject.Forms.frmMenu;
		ComboBox combo = cboBranch;
		cCombo.getBranch(ref combo, Module1.pubGroupId, blnAll: false);
		cboBranch = combo;
		cboBranch.SelectedIndex = 0;
	}

	private void frmReportMarketingSummary_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void frmReportMarketingSummary_Load(object sender, EventArgs e)
	{
		prepareForm();
	}

	private void prepareForm()
	{
		dtpBegin.Value = Module1.getFirstDateInMonth(DateAndTime.Now);
		dtpEnd.Value = DateAndTime.Now;
		dtpBegin.Focus();
		cboBranch.SelectedIndex = 0;
		chkSales.Checked = true;
		chkStok.Checked = true;
		chkRetur.Checked = true;
		chkBPFP.Checked = true;
		lblStatus.Text = "";
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
		cComboItem cComboItem2 = (cComboItem)cboBranch.SelectedItem;
		if (cboBranch.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih cabang.", MsgBoxStyle.Information);
			return;
		}
		if (!chkSales.Checked & !chkStok.Checked & !chkRetur.Checked & !chkBPFP.Checked)
		{
			Interaction.MsgBox("Pilih minimum 1 report.", MsgBoxStyle.Information);
			return;
		}
		Cursor = Cursors.WaitCursor;
		Module1.SaveDebug("Report Marketing Summary - Start");
		_xlApp = (Excel.Application)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
		_xlWb = _xlApp.Workbooks.Add(RuntimeHelpers.GetObjectValue(Missing.Value));
		int num = DateAndTime.Month(DateAndTime.Now);
		int num2 = DateAndTime.Year(DateAndTime.Now);
		int num3 = 1;
		checked
		{
			if (chkSales.Checked)
			{
				lblStatus.Text = "Status: buat sheet Sales. Harap tunggu.";
				MarketingBulananSheetSales(dtpBegin.Value, dtpEnd.Value, Conversions.ToInteger(cComboItem2.Value), num3);
				num3++;
			}
			if (chkStok.Checked)
			{
				lblStatus.Text = "Status: buat sheet Stok. Harap tunggu.";
				MarketingBulananSheetStok(dtpBegin.Value, dtpEnd.Value, Conversions.ToInteger(cComboItem2.Value), num3);
				num3++;
			}
			if (chkRetur.Checked)
			{
				lblStatus.Text = "Status: buat sheet Retur. Harap tunggu.";
				MarketingBulananSheetRetur(dtpBegin.Value, dtpEnd.Value, Conversions.ToInteger(cComboItem2.Value), num3);
				num3++;
			}
			if (chkBPFP.Checked)
			{
				lblStatus.Text = "Status: buat sheet BPFP. Harap tunggu.";
				MarketingBulananSheetBPFP(dtpBegin.Value, dtpEnd.Value, Conversions.ToInteger(cComboItem2.Value), num3);
				num3++;
			}
			Module1.MinimiseAllWindows();
			_xlApp.Visible = true;
			_xlApp.WindowState = XlWindowState.xlMaximized;
			lblStatus.Text = "";
			Cursor = Cursors.Default;
			Module1.SaveDebug("Report Marketing Summary - Finish");
		}
	}

	private void MarketingBulananSheetSales(DateTime BeginDate, DateTime EndDate, int BranchId, int SheetNumber)
	{
		if (SheetNumber > 3)
		{
			_xlApp.Sheets.Add(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(_xlApp.Sheets[_xlApp.Worksheets.Count]), 1, RuntimeHelpers.GetObjectValue(Missing.Value));
		}
		NewLateBinding.LateCall(_xlApp.Sheets[SheetNumber], null, "Select", new object[0], null, null, null, IgnoreReturn: true);
		NewLateBinding.LateSetComplex(_xlApp.Sheets[SheetNumber], null, "Name", new object[1] { "SALES" }, null, null, OptimisticSet: false, RValueBase: true);
		prepareExcel(_xlApp);
		_xlApp.Cells[1, 1] = "LAPORAN PENJUALAN PER SALES";
		((_Application)_xlApp).get_Range((object)"A1:J1", RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Font", new object[0], null, null, null), null, "Bold", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Font", new object[0], null, null, null), null, "Size", new object[1] { 14 }, null, null, OptimisticSet: false, RValueBase: true);
		mergeColumns(_xlApp, "A1:J1");
		_xlApp.Cells[2, 1] = "Per " + Strings.Format(EndDate, "dd-MMMM-yyyy");
		((_Application)_xlApp).get_Range((object)"A2:J2", RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Font", new object[0], null, null, null), null, "Bold", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Font", new object[0], null, null, null), null, "Size", new object[1] { 12 }, null, null, OptimisticSet: false, RValueBase: true);
		mergeColumns(_xlApp, "A2:J2");
		_xlApp.Cells[5, 1] = "SALES";
		_xlApp.Cells[5, 2] = "PENJ. TUNAI";
		_xlApp.Cells[5, 3] = "PENJ. KREDIT";
		_xlApp.Cells[5, 4] = "PENJ. KOTOR";
		_xlApp.Cells[5, 5] = "RETUR";
		_xlApp.Cells[5, 6] = "DISCOUNT";
		_xlApp.Cells[5, 7] = "POTONGAN";
		_xlApp.Cells[5, 8] = "PENJ. BERSIH";
		_xlApp.Cells[5, 9] = "TAGIHAN";
		_xlApp.Cells[5, 10] = "SETORAN";
		((_Application)_xlApp).get_Range((object)"A5:J5", RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Font", new object[0], null, null, null), null, "Bold", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
		int num = 6;
		string strSql = " SELECT * FROM SALES  WHERE branchId = " + Conversions.ToString(BranchId) + " AND salesStatus = 1  AND salesKol = 0  ORDER BY salesName ";
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		checked
		{
			int num2 = 5 + dataTable.Rows.Count;
			double num3 = 100.0 / (double)dataTable.Rows.Count;
			double num4 = default(double);
			foreach (DataRow row in dataTable.Rows)
			{
				num4 += num3;
				lblStatus.Text = "Status: buat sheet Sales. Harap tunggu. (" + Conversions.ToString(Math.Floor(num4)) + "%)";
				_xlApp.Cells[num, 1] = RuntimeHelpers.GetObjectValue(row["salesName"]);
				double num5 = 0.0;
				double num6 = 0.0;
				double num7 = 0.0;
				double num8 = 0.0;
				double num9 = 0.0;
				double num10 = 0.0;
				double num11 = 0.0;
				DataTable dataTable2 = cSalesInvoice.Search(1, BeginDate, EndDate, 0, Conversions.ToInteger(row["salesId"]), 99, 0, "", 0.0, 0.0, 99, 99, 99, 99, 0, BranchId, Module1.pubGroupId, "ASC");
				foreach (DataRow row2 in dataTable2.Rows)
				{
					num5 = Conversions.ToDouble(Operators.AddObject(num5, row2["penjDisc"]));
					num6 = Conversions.ToDouble(Operators.AddObject(num6, row2["penjPot"]));
					if (Operators.ConditionalCompareObjectGreater(row2["penjBsType"], 0, TextCompare: false))
					{
						num9 = Conversions.ToDouble(Operators.AddObject(num9, row2["penjBs"]));
					}
					if (Operators.ConditionalCompareObjectEqual(row2["penjKode"], "T", TextCompare: false))
					{
						num7 = Conversions.ToDouble(Operators.AddObject(num7, row2["penjTotal"]));
					}
					else if (Operators.ConditionalCompareObjectEqual(row2["penjKode"], "K", TextCompare: false))
					{
						num8 = Conversions.ToDouble(Operators.AddObject(num8, row2["penjTotal"]));
					}
				}
				dataTable2 = cSalesInvoice.SearchPayment(BeginDate, EndDate, 0, 99, 99, Conversions.ToInteger(row["salesId"]), 0, 0, 0, 0, BranchId, Module1.pubGroupId);
				foreach (DataRow row3 in dataTable2.Rows)
				{
					if (Operators.ConditionalCompareObjectEqual(row3["penjKode"], 1, TextCompare: false))
					{
						num10 = Conversions.ToDouble(Operators.AddObject(num10, row3["pbAmount"]));
					}
					num11 = Conversions.ToDouble(Operators.AddObject(num11, row3["pbAmount"]));
				}
				_xlApp.Cells[num, 2] = num7;
				_xlApp.Cells[num, 3] = num8;
				_xlApp.Cells[num, 4] = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("=", NewLateBinding.LateGet(_xlApp.Cells[num, 2], null, "Address", new object[2] { false, false }, null, null, null)), "+"), NewLateBinding.LateGet(_xlApp.Cells[num, 3], null, "Address", new object[2] { false, false }, null, null, null));
				_xlApp.Cells[num, 5] = num9;
				_xlApp.Cells[num, 6] = num5;
				_xlApp.Cells[num, 7] = num6;
				_xlApp.Cells[num, 8] = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("=", NewLateBinding.LateGet(_xlApp.Cells[num, 4], null, "Address", new object[2] { false, false }, null, null, null)), "+"), NewLateBinding.LateGet(_xlApp.Cells[num, 5], null, "Address", new object[2] { false, false }, null, null, null)), "-"), NewLateBinding.LateGet(_xlApp.Cells[num, 6], null, "Address", new object[2] { false, false }, null, null, null)), "-"), NewLateBinding.LateGet(_xlApp.Cells[num, 7], null, "Address", new object[2] { false, false }, null, null, null));
				_xlApp.Cells[num, 9] = num10;
				_xlApp.Cells[num, 10] = num11;
				num++;
			}
			num = num2 + 2;
			_xlApp.Cells[num, 2] = "=SUM(B6:B" + Conversions.ToString(num2) + ")";
			_xlApp.Cells[num, 3] = "=SUM(C6:C" + Conversions.ToString(num2) + ")";
			_xlApp.Cells[num, 4] = "=SUM(D6:D" + Conversions.ToString(num2) + ")";
			_xlApp.Cells[num, 5] = "=SUM(E6:E" + Conversions.ToString(num2) + ")";
			_xlApp.Cells[num, 6] = "=SUM(F6:F" + Conversions.ToString(num2) + ")";
			_xlApp.Cells[num, 7] = "=SUM(G6:G" + Conversions.ToString(num2) + ")";
			_xlApp.Cells[num, 8] = "=SUM(H6:H" + Conversions.ToString(num2) + ")";
			_xlApp.Cells[num, 9] = "=SUM(I6:I" + Conversions.ToString(num2) + ")";
			_xlApp.Cells[num, 10] = "=SUM(J6:J" + Conversions.ToString(num2) + ")";
			((_Application)_xlApp).get_Range((object)("A" + Conversions.ToString(num) + ":J" + Conversions.ToString(num)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Font", new object[0], null, null, null), null, "Bold", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
			object obj = _xlApp.Sheets[SheetNumber];
			object instance = obj;
			object[] array = new object[2];
			object instance2;
			object instance3 = (instance2 = obj);
			object[] array2 = new object[2];
			object obj2 = (array2[0] = 5);
			object obj3 = (array2[1] = 1);
			array[0] = NewLateBinding.LateGet(instance3, null, "Cells", array2, null, null, null);
			object instance4;
			object instance5 = (instance4 = obj);
			object[] array3 = new object[2];
			object obj4 = (array3[0] = num2 + 2);
			object obj5 = (array3[1] = 10);
			array[1] = NewLateBinding.LateGet(instance5, null, "Cells", array3, null, null, null);
			object[] array4 = array;
			bool[] array5;
			object obj6 = NewLateBinding.LateGet(instance, null, "Range", array, null, null, array5 = new bool[2] { true, true });
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(instance2, null, "Cells", new object[3]
				{
					obj2,
					obj3,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array5[1])
			{
				NewLateBinding.LateSetComplex(instance4, null, "Cells", new object[3]
				{
					obj4,
					obj5,
					array4[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			Range range = (Range)obj6;
			range.Select();
			obj = null;
			ExcelModule.formatBorder(_xlApp);
			object obj7 = _xlApp.Sheets[1];
			object instance6 = obj7;
			object[] array6 = new object[2];
			object instance7 = (obj5 = obj7);
			object[] array7 = new object[2];
			obj4 = (array7[0] = 6);
			instance4 = (array7[1] = 2);
			array6[0] = NewLateBinding.LateGet(instance7, null, "Cells", array7, null, null, null);
			object instance8 = (obj3 = obj7);
			object[] array8 = new object[2];
			obj2 = (array8[0] = num2 + 2);
			instance2 = (array8[1] = 10);
			array6[1] = NewLateBinding.LateGet(instance8, null, "Cells", array8, null, null, null);
			array4 = array6;
			obj6 = NewLateBinding.LateGet(instance6, null, "Range", array6, null, null, array5 = new bool[2] { true, true });
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(obj5, null, "Cells", new object[3]
				{
					obj4,
					instance4,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array5[1])
			{
				NewLateBinding.LateSetComplex(obj3, null, "Cells", new object[3]
				{
					obj2,
					instance2,
					array4[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			range = (Range)obj6;
			range.Select();
			obj7 = null;
			NewLateBinding.LateSetComplex(_xlApp.Selection, null, "HorizontalAlignment", new object[1] { XlHAlign.xlHAlignLeft }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(_xlApp.Selection, null, "NumberFormat", new object[1] { "_($* #,##0_);_($* (#,##0);_($* \"-\"_);_(@_)" }, null, null, OptimisticSet: false, RValueBase: true);
			_xlApp.Cells.Select();
			NewLateBinding.LateCall(NewLateBinding.LateGet(_xlApp.Selection, null, "Columns", new object[0], null, null, null), null, "AutoFit", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateCall(_xlApp.Cells[1, 1], null, "Select", new object[0], null, null, null, IgnoreReturn: true);
		}
	}

	private void MarketingBulananSheetStok(DateTime BeginDate, DateTime EndDate, int BranchId, int SheetNumber)
	{
		if (SheetNumber > 3)
		{
			_xlApp.Sheets.Add(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(_xlApp.Sheets[_xlApp.Worksheets.Count]), 1, RuntimeHelpers.GetObjectValue(Missing.Value));
		}
		NewLateBinding.LateCall(_xlApp.Sheets[SheetNumber], null, "Select", new object[0], null, null, null, IgnoreReturn: true);
		NewLateBinding.LateSetComplex(_xlApp.Sheets[SheetNumber], null, "Name", new object[1] { "STOK" }, null, null, OptimisticSet: false, RValueBase: true);
		prepareExcel(_xlApp);
		_xlApp.Cells[1, 1] = "RINCIAN STOK BARANG";
		((_Application)_xlApp).get_Range((object)"A1:E1", RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Font", new object[0], null, null, null), null, "Bold", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Font", new object[0], null, null, null), null, "Size", new object[1] { 14 }, null, null, OptimisticSet: false, RValueBase: true);
		mergeColumns(_xlApp, "A1:E1");
		_xlApp.Cells[2, 1] = "Per " + Strings.Format(EndDate, "dd-MMMM-yyyy");
		((_Application)_xlApp).get_Range((object)"A2:E2", RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Font", new object[0], null, null, null), null, "Bold", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Font", new object[0], null, null, null), null, "Size", new object[1] { 12 }, null, null, OptimisticSet: false, RValueBase: true);
		mergeColumns(_xlApp, "A2:E2");
		_xlApp.Cells[5, 1] = "Barang";
		_xlApp.Cells[5, 2] = "Jumlah Awal";
		_xlApp.Cells[5, 3] = "Masuk";
		_xlApp.Cells[5, 4] = "Keluar";
		_xlApp.Cells[5, 5] = "Jumlah Akhir";
		((_Application)_xlApp).get_Range((object)"A5:E5", RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Font", new object[0], null, null, null), null, "Bold", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
		int num = 6;
		string strSql = " SELECT * FROM items a, produk b  WHERE a.itemId = b.prodId  AND prodAllowSell = 1  AND itemActive = 1  AND itemId IN (SELECT prodId FROM produkStorages  WHERE psAvailable = 1 AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 0 AND branchId = " + Conversions.ToString(BranchId) + ")) ORDER BY itemName ";
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		checked
		{
			int num2 = 5 + dataTable.Rows.Count;
			double num3 = 100.0 / (double)dataTable.Rows.Count;
			double num4 = default(double);
			foreach (DataRow row in dataTable.Rows)
			{
				num4 += num3;
				lblStatus.Text = "Status: buat sheet Stok. Harap tunggu. (" + Conversions.ToString(Math.Floor(num4)) + "%)";
				_xlApp.Cells[num, 1] = RuntimeHelpers.GetObjectValue(row["itemName"]);
				_xlApp.Cells[num, 2] = cStock.getStock(Conversions.ToInteger(row["itemId"]), Module1.pubBalanceDate, BeginDate, "Good", 0, Module1.pubGroupId, BranchId, Module1.pubReportUseNewGetStockCode);
				_xlApp.Cells[num, 3] = cStock.getInStock(Conversions.ToInteger(row["itemId"]), BeginDate, EndDate.AddDays(1.0), "Good", 0, Module1.pubGroupId, BranchId);
				_xlApp.Cells[num, 4] = cStock.getOutStock(Conversions.ToInteger(row["itemId"]), BeginDate, EndDate.AddDays(1.0), "Good", 0, Module1.pubGroupId, BranchId);
				_xlApp.Cells[num, 5] = cStock.getStock(Conversions.ToInteger(row["itemId"]), Module1.pubBalanceDate, EndDate.AddDays(1.0), "Good", 0, Module1.pubGroupId, BranchId, Module1.pubReportUseNewGetStockCode);
				num++;
			}
			num = num2 + 2;
			_xlApp.Cells[num, 2] = "=SUM(B6:B" + Conversions.ToString(num2) + ")";
			_xlApp.Cells[num, 3] = "=SUM(C6:C" + Conversions.ToString(num2) + ")";
			_xlApp.Cells[num, 4] = "=SUM(D6:D" + Conversions.ToString(num2) + ")";
			_xlApp.Cells[num, 5] = "=SUM(E6:E" + Conversions.ToString(num2) + ")";
			((_Application)_xlApp).get_Range((object)("A" + Conversions.ToString(num) + ":J" + Conversions.ToString(num)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Font", new object[0], null, null, null), null, "Bold", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
			object obj = _xlApp.Sheets[SheetNumber];
			object instance = obj;
			object[] array = new object[2];
			object instance2;
			object instance3 = (instance2 = obj);
			object[] array2 = new object[2];
			object obj2 = (array2[0] = 5);
			object obj3 = (array2[1] = 1);
			array[0] = NewLateBinding.LateGet(instance3, null, "Cells", array2, null, null, null);
			object instance4;
			object instance5 = (instance4 = obj);
			object[] array3 = new object[2];
			object obj4 = (array3[0] = num2 + 2);
			object obj5 = (array3[1] = 5);
			array[1] = NewLateBinding.LateGet(instance5, null, "Cells", array3, null, null, null);
			object[] array4 = array;
			bool[] array5;
			object obj6 = NewLateBinding.LateGet(instance, null, "Range", array, null, null, array5 = new bool[2] { true, true });
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(instance2, null, "Cells", new object[3]
				{
					obj2,
					obj3,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array5[1])
			{
				NewLateBinding.LateSetComplex(instance4, null, "Cells", new object[3]
				{
					obj4,
					obj5,
					array4[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			Range range = (Range)obj6;
			range.Select();
			obj = null;
			ExcelModule.formatBorder(_xlApp);
			object obj7 = _xlApp.Sheets[SheetNumber];
			object instance6 = obj7;
			object[] array6 = new object[2];
			object instance7 = (obj5 = obj7);
			object[] array7 = new object[2];
			obj4 = (array7[0] = 6);
			instance4 = (array7[1] = 2);
			array6[0] = NewLateBinding.LateGet(instance7, null, "Cells", array7, null, null, null);
			object instance8 = (obj3 = obj7);
			object[] array8 = new object[2];
			obj2 = (array8[0] = num2 + 2);
			instance2 = (array8[1] = 5);
			array6[1] = NewLateBinding.LateGet(instance8, null, "Cells", array8, null, null, null);
			array4 = array6;
			obj6 = NewLateBinding.LateGet(instance6, null, "Range", array6, null, null, array5 = new bool[2] { true, true });
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(obj5, null, "Cells", new object[3]
				{
					obj4,
					instance4,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array5[1])
			{
				NewLateBinding.LateSetComplex(obj3, null, "Cells", new object[3]
				{
					obj2,
					instance2,
					array4[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			range = (Range)obj6;
			range.Select();
			obj7 = null;
			NewLateBinding.LateSetComplex(_xlApp.Selection, null, "NumberFormat", new object[1] { "#,##0.000" }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(_xlApp.Selection, null, "NumberFormat", new object[1] { "#,##0.000" }, null, null, OptimisticSet: false, RValueBase: true);
			_xlApp.Cells.Select();
			NewLateBinding.LateCall(NewLateBinding.LateGet(_xlApp.Selection, null, "Columns", new object[0], null, null, null), null, "AutoFit", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateCall(_xlApp.Cells[1, 1], null, "Select", new object[0], null, null, null, IgnoreReturn: true);
		}
	}

	private void MarketingBulananSheetRetur(DateTime BeginDate, DateTime EndDate, int BranchId, int SheetNumber)
	{
		if (SheetNumber > 3)
		{
			_xlApp.Sheets.Add(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(_xlApp.Sheets[_xlApp.Worksheets.Count]), 1, RuntimeHelpers.GetObjectValue(Missing.Value));
		}
		NewLateBinding.LateCall(_xlApp.Sheets[SheetNumber], null, "Select", new object[0], null, null, null, IgnoreReturn: true);
		NewLateBinding.LateSetComplex(_xlApp.Sheets[SheetNumber], null, "Name", new object[1] { "RETUR" }, null, null, OptimisticSet: false, RValueBase: true);
		prepareExcel(_xlApp);
		_xlApp.Cells[1, 1] = "RINCIAN STOK RETUR";
		((_Application)_xlApp).get_Range((object)"A1:E1", RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Font", new object[0], null, null, null), null, "Bold", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Font", new object[0], null, null, null), null, "Size", new object[1] { 14 }, null, null, OptimisticSet: false, RValueBase: true);
		mergeColumns(_xlApp, "A1:E1");
		_xlApp.Cells[2, 1] = "Per " + Strings.Format(EndDate, "dd-MMMM-yyyy");
		((_Application)_xlApp).get_Range((object)"A2:E2", RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Font", new object[0], null, null, null), null, "Bold", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Font", new object[0], null, null, null), null, "Size", new object[1] { 12 }, null, null, OptimisticSet: false, RValueBase: true);
		mergeColumns(_xlApp, "A2:E2");
		_xlApp.Cells[5, 1] = "Barang";
		_xlApp.Cells[5, 2] = "Jumlah Awal";
		_xlApp.Cells[5, 3] = "Masuk";
		_xlApp.Cells[5, 4] = "Keluar";
		_xlApp.Cells[5, 5] = "Jumlah Akhir";
		((_Application)_xlApp).get_Range((object)"A5:E5", RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Font", new object[0], null, null, null), null, "Bold", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
		int num = 6;
		string strSql = " SELECT * FROM items a, produk b  WHERE a.itemId = b.prodId  AND prodAllowSell = 1  AND itemActive = 1  AND itemId IN (SELECT prodId FROM produkStorages  WHERE psAvailable = 1 AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 1 AND branchId = " + Conversions.ToString(BranchId) + ")) ORDER BY itemName ";
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		checked
		{
			int num2 = 5 + dataTable.Rows.Count;
			double num3 = 100.0 / (double)dataTable.Rows.Count;
			double num4 = default(double);
			foreach (DataRow row in dataTable.Rows)
			{
				num4 += num3;
				lblStatus.Text = "Status: buat sheet Retur. Harap tunggu. (" + Conversions.ToString(Math.Floor(num4)) + "%)";
				_xlApp.Cells[num, 1] = RuntimeHelpers.GetObjectValue(row["itemName"]);
				_xlApp.Cells[num, 2] = cStock.getStock(Conversions.ToInteger(row["itemId"]), Module1.pubBalanceDate, BeginDate, "Damage", 0, Module1.pubGroupId, BranchId, Module1.pubReportUseNewGetStockCode);
				_xlApp.Cells[num, 3] = cStock.getInStock(Conversions.ToInteger(row["itemId"]), BeginDate, EndDate.AddDays(1.0), "Damage", 0, Module1.pubGroupId, BranchId);
				_xlApp.Cells[num, 4] = cStock.getOutStock(Conversions.ToInteger(row["itemId"]), BeginDate, EndDate.AddDays(1.0), "Damage", 0, Module1.pubGroupId, BranchId);
				_xlApp.Cells[num, 5] = cStock.getStock(Conversions.ToInteger(row["itemId"]), Module1.pubBalanceDate, EndDate.AddDays(1.0), "Damage", 0, Module1.pubGroupId, BranchId, Module1.pubReportUseNewGetStockCode);
				num++;
			}
			num = num2 + 2;
			_xlApp.Cells[num, 2] = "=SUM(B6:B" + Conversions.ToString(num2) + ")";
			_xlApp.Cells[num, 3] = "=SUM(C6:C" + Conversions.ToString(num2) + ")";
			_xlApp.Cells[num, 4] = "=SUM(D6:D" + Conversions.ToString(num2) + ")";
			_xlApp.Cells[num, 5] = "=SUM(E6:E" + Conversions.ToString(num2) + ")";
			((_Application)_xlApp).get_Range((object)("A" + Conversions.ToString(num) + ":J" + Conversions.ToString(num)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Font", new object[0], null, null, null), null, "Bold", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
			object obj = _xlApp.Sheets[SheetNumber];
			object instance = obj;
			object[] array = new object[2];
			object instance2;
			object instance3 = (instance2 = obj);
			object[] array2 = new object[2];
			object obj2 = (array2[0] = 5);
			object obj3 = (array2[1] = 1);
			array[0] = NewLateBinding.LateGet(instance3, null, "Cells", array2, null, null, null);
			object instance4;
			object instance5 = (instance4 = obj);
			object[] array3 = new object[2];
			object obj4 = (array3[0] = num2 + 2);
			object obj5 = (array3[1] = 5);
			array[1] = NewLateBinding.LateGet(instance5, null, "Cells", array3, null, null, null);
			object[] array4 = array;
			bool[] array5;
			object obj6 = NewLateBinding.LateGet(instance, null, "Range", array, null, null, array5 = new bool[2] { true, true });
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(instance2, null, "Cells", new object[3]
				{
					obj2,
					obj3,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array5[1])
			{
				NewLateBinding.LateSetComplex(instance4, null, "Cells", new object[3]
				{
					obj4,
					obj5,
					array4[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			Range range = (Range)obj6;
			range.Select();
			obj = null;
			ExcelModule.formatBorder(_xlApp);
			object obj7 = _xlApp.Sheets[SheetNumber];
			object instance6 = obj7;
			object[] array6 = new object[2];
			object instance7 = (obj5 = obj7);
			object[] array7 = new object[2];
			obj4 = (array7[0] = 6);
			instance4 = (array7[1] = 2);
			array6[0] = NewLateBinding.LateGet(instance7, null, "Cells", array7, null, null, null);
			object instance8 = (obj3 = obj7);
			object[] array8 = new object[2];
			obj2 = (array8[0] = num2 + 2);
			instance2 = (array8[1] = 5);
			array6[1] = NewLateBinding.LateGet(instance8, null, "Cells", array8, null, null, null);
			array4 = array6;
			obj6 = NewLateBinding.LateGet(instance6, null, "Range", array6, null, null, array5 = new bool[2] { true, true });
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(obj5, null, "Cells", new object[3]
				{
					obj4,
					instance4,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array5[1])
			{
				NewLateBinding.LateSetComplex(obj3, null, "Cells", new object[3]
				{
					obj2,
					instance2,
					array4[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			range = (Range)obj6;
			range.Select();
			obj7 = null;
			NewLateBinding.LateSetComplex(_xlApp.Selection, null, "NumberFormat", new object[1] { "#,##0.000" }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(_xlApp.Selection, null, "NumberFormat", new object[1] { "#,##0.000" }, null, null, OptimisticSet: false, RValueBase: true);
			_xlApp.Cells.Select();
			NewLateBinding.LateCall(NewLateBinding.LateGet(_xlApp.Selection, null, "Columns", new object[0], null, null, null), null, "AutoFit", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateCall(_xlApp.Cells[1, 1], null, "Select", new object[0], null, null, null, IgnoreReturn: true);
		}
	}

	private void MarketingBulananSheetBPFP(DateTime BeginDate, DateTime EndDate, int BranchId, int SheetNumber)
	{
		if (SheetNumber > 3)
		{
			_xlApp.Sheets.Add(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(_xlApp.Sheets[_xlApp.Worksheets.Count]), 1, RuntimeHelpers.GetObjectValue(Missing.Value));
		}
		NewLateBinding.LateCall(_xlApp.Sheets[SheetNumber], null, "Select", new object[0], null, null, null, IgnoreReturn: true);
		NewLateBinding.LateSetComplex(_xlApp.Sheets[SheetNumber], null, "Name", new object[1] { "Rekap BPFP" }, null, null, OptimisticSet: false, RValueBase: true);
		prepareExcel(_xlApp);
		lblStatus.Text = "Status: buat sheet BPFP. Harap tunggu. (10%)";
		_xlApp.Cells[1, 1] = "BPFP";
		((_Application)_xlApp).get_Range((object)"A1:E1", RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Font", new object[0], null, null, null), null, "Bold", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Font", new object[0], null, null, null), null, "Size", new object[1] { 14 }, null, null, OptimisticSet: false, RValueBase: true);
		mergeColumns(_xlApp, "A1:D1");
		_xlApp.Cells[2, 1] = "Per " + Strings.Format(EndDate, "dd-MMMM-yyyy");
		((_Application)_xlApp).get_Range((object)"A2:E2", RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Font", new object[0], null, null, null), null, "Bold", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Font", new object[0], null, null, null), null, "Size", new object[1] { 12 }, null, null, OptimisticSet: false, RValueBase: true);
		mergeColumns(_xlApp, "A2:D2");
		lblStatus.Text = "Status: buat sheet BPFP. Harap tunggu. (20%)";
		int[] areaId = new int[0];
		DataTable dataTable = cSalesInvoice.SearchReceivable(2, BeginDate, DateAndTime.Now, 0.0, areaId, 0, 0, 0, 0, BranchId, Module1.pubGroupId);
		double num = default(double);
		foreach (DataRow row in dataTable.Rows)
		{
			if (Operators.ConditionalCompareObjectGreater(row["penjReceivable"], 0, TextCompare: false))
			{
				num = Conversions.ToDouble(Operators.AddObject(num, row["penjReceivable"]));
			}
		}
		_xlApp.Cells[4, 1] = "Saldo Awal BPFP";
		_xlApp.Cells[4, 3] = num;
		lblStatus.Text = "Status: buat sheet BPFP. Harap tunggu. (40%)";
		double totalReturnConnectedToCreditInvoice = cSalesInvoice.GetTotalReturnConnectedToCreditInvoice(BeginDate, EndDate, BranchId, Module1.pubGroupId);
		_xlApp.Cells[6, 1] = "BS";
		_xlApp.Cells[6, 2] = totalReturnConnectedToCreditInvoice;
		lblStatus.Text = "Status: buat sheet BPFP. Harap tunggu. (60%)";
		dataTable = cSalesInvoice.Search(1, BeginDate, EndDate, 0, 0, 0, 0, "", 0.0, 0.0, 1, 0, 99, 99, 0, BranchId, Module1.pubGroupId, "ASC");
		double num2 = default(double);
		double num3 = default(double);
		foreach (DataRow row2 in dataTable.Rows)
		{
			num2 = Conversions.ToDouble(Operators.AddObject(num2, row2["penjDisc"]));
			num3 = Conversions.ToDouble(Operators.AddObject(num3, row2["penjTotal"]));
		}
		_xlApp.Cells[7, 1] = "Discount";
		_xlApp.Cells[7, 2] = num2;
		_xlApp.Cells[5, 1] = "Total Harga Penj. Kredit";
		_xlApp.Cells[5, 2] = num3;
		lblStatus.Text = "Status: buat sheet BPFP. Harap tunggu. (75%)";
		double totalPaymentDiscountOfCreditInvoice = cSalesInvoice.GetTotalPaymentDiscountOfCreditInvoice(BeginDate, EndDate, BranchId, Module1.pubGroupId);
		_xlApp.Cells[8, 1] = "Potongan";
		_xlApp.Cells[8, 2] = totalPaymentDiscountOfCreditInvoice;
		_xlApp.Cells[9, 3] = "=B5-B6-B7-B8";
		_xlApp.Cells[10, 4] = "=C4+C9";
		lblStatus.Text = "Status: buat sheet BPFP. Harap tunggu. (90%)";
		dataTable = cSalesInvoice.SearchPayment(dtpBegin.Value, dtpEnd.Value, 0, 1, 1, 0, 0, 0, 0, 0, BranchId, Module1.pubGroupId);
		double num4 = default(double);
		double num5 = default(double);
		double num6 = default(double);
		foreach (DataRow row3 in dataTable.Rows)
		{
			if (Operators.ConditionalCompareObjectEqual(row3["pkId"], 1, TextCompare: false))
			{
				num4 = Conversions.ToDouble(Operators.AddObject(num4, row3["pbAmount"]));
			}
			else if (Operators.ConditionalCompareObjectEqual(row3["pkId"], 2, TextCompare: false))
			{
				num5 = Conversions.ToDouble(Operators.AddObject(num5, row3["pbAmount"]));
			}
			else if (Operators.ConditionalCompareObjectEqual(row3["pkId"], 3, TextCompare: false))
			{
				num6 = Conversions.ToDouble(Operators.AddObject(num6, row3["pbAmount"]));
			}
		}
		_xlApp.Cells[12, 1] = "Cash";
		_xlApp.Cells[12, 2] = num4;
		_xlApp.Cells[13, 1] = "Cek/Giro";
		_xlApp.Cells[13, 2] = num5;
		_xlApp.Cells[14, 1] = "LLG";
		_xlApp.Cells[14, 2] = num6;
		_xlApp.Cells[15, 4] = "=SUM(B12:B14)";
		_xlApp.Cells[17, 1] = "Saldo Akhir BPFP";
		_xlApp.Cells[17, 4] = "=D10-D15";
		lblStatus.Text = "Status: buat sheet BPFP. Harap tunggu. (95%)";
		dataTable = cSalesInvoice.SearchReceivable(2, EndDate.AddDays(1.0), DateAndTime.Now, 0.0, areaId, 0, 0, 0, 0, BranchId, Module1.pubGroupId);
		num = 0.0;
		foreach (DataRow row4 in dataTable.Rows)
		{
			if (Operators.ConditionalCompareObjectGreater(row4["penjReceivable"], 0, TextCompare: false))
			{
				num = Conversions.ToDouble(Operators.AddObject(num, row4["penjReceivable"]));
			}
		}
		_xlApp.Cells[17, 5] = num;
		_xlApp.Cells[18, 4] = "Selisih";
		_xlApp.Cells[18, 5] = "=D17-E17";
		((_Application)_xlApp).get_Range((object)"D1:D17", RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
		lblStatus.Text = "Status: buat sheet BPFP. Harap tunggu. (95%)";
		ExcelModule.formatBorder(_xlApp);
		((_Application)_xlApp).get_Range((object)"D1:D17", RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
		NewLateBinding.LateSetComplex(_xlApp.Selection, null, "NumberFormat", new object[1] { "_($* #,##0_);_($* (#,##0);_($* \"-\"_);_(@_)" }, null, null, OptimisticSet: false, RValueBase: true);
		((_Application)_xlApp).get_Range((object)"E17:E18", RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
		NewLateBinding.LateSetComplex(_xlApp.Selection, null, "NumberFormat", new object[1] { "_($* #,##0_);_($* (#,##0);_($* \"-\"_);_(@_)" }, null, null, OptimisticSet: false, RValueBase: true);
		lblStatus.Text = "Status: buat sheet BPFP. Harap tunggu. (100%)";
		_xlApp.Cells.Select();
		NewLateBinding.LateCall(NewLateBinding.LateGet(_xlApp.Selection, null, "Columns", new object[0], null, null, null), null, "AutoFit", new object[0], null, null, null, IgnoreReturn: true);
		NewLateBinding.LateCall(_xlApp.Cells[1, 1], null, "Select", new object[0], null, null, null, IgnoreReturn: true);
	}

	private void prepareExcel(Excel.Application xlApp)
	{
	}

	private void mergeColumns(Excel.Application xlApp, string strRange)
	{
		((_Application)xlApp).get_Range((object)strRange, RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
		object selection = xlApp.Selection;
		NewLateBinding.LateSetComplex(selection, null, "HorizontalAlignment", new object[1] { XlHAlign.xlHAlignCenter }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(selection, null, "VerticalAlignment", new object[1] { XlVAlign.xlVAlignBottom }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(selection, null, "WrapText", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(selection, null, "Orientation", new object[1] { 0 }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(selection, null, "AddIndent", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(selection, null, "ShrinkToFit", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(selection, null, "MergeCells", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
		selection = null;
		NewLateBinding.LateCall(xlApp.Selection, null, "Merge", new object[0], null, null, null, IgnoreReturn: true);
	}

	private void btnReset_Click(object sender, EventArgs e)
	{
		prepareForm();
	}
}
