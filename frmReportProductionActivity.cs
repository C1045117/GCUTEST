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

namespace GCUv2;

[DesignerGenerated]
public class frmReportProductionActivity : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSearch")]
	private Button _btnSearch;

	private Excel.Application _xlApp;

	private Workbook _xlWb;

	private string strReport;

	private int intTotalRows;

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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dtpBegin")]
	internal virtual DateTimePicker dtpBegin
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBar1")]
	internal virtual ProgressBar ProgressBar1
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
		this.btnSearch = new System.Windows.Forms.Button();
		this.Label4 = new System.Windows.Forms.Label();
		this.dtpBegin = new System.Windows.Forms.DateTimePicker();
		this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
		base.SuspendLayout();
		this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSearch.Location = new System.Drawing.Point(62, 38);
		this.btnSearch.Name = "btnSearch";
		this.btnSearch.Size = new System.Drawing.Size(47, 24);
		this.btnSearch.TabIndex = 251;
		this.btnSearch.Text = "Excel";
		this.btnSearch.UseVisualStyleBackColor = true;
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(10, 15);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(46, 13);
		this.Label4.TabIndex = 250;
		this.Label4.Text = "Tanggal";
		this.dtpBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpBegin.Location = new System.Drawing.Point(62, 12);
		this.dtpBegin.Name = "dtpBegin";
		this.dtpBegin.Size = new System.Drawing.Size(121, 20);
		this.dtpBegin.TabIndex = 249;
		this.ProgressBar1.Location = new System.Drawing.Point(10, 68);
		this.ProgressBar1.Name = "ProgressBar1";
		this.ProgressBar1.Size = new System.Drawing.Size(262, 23);
		this.ProgressBar1.TabIndex = 252;
		base.AcceptButton = this.btnSearch;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(280, 99);
		base.Controls.Add(this.ProgressBar1);
		base.Controls.Add(this.btnSearch);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.dtpBegin);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmReportProductionActivity";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Report Aktivitas Produksi";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmReportProductionActivity()
	{
		base.KeyDown += frmReportProductionActivity_KeyDown;
		InitializeComponent();
		DoubleBuffered = true;
		base.MdiParent = MyProject.Forms.frmMenu;
		PrepareForm();
	}

	private void PrepareForm()
	{
		dtpBegin.Value = DateAndTime.Now;
		ProgressBar1.Visible = false;
	}

	private void frmReportProductionActivity_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void btnSearch_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num8 = default(int);
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
						Cursor = Cursors.WaitCursor;
						ProgressBar1.Visible = true;
						ProgressBar1.Value = 5;
						_xlApp = (Excel.Application)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
						_xlWb = _xlApp.Workbooks.Add(RuntimeHelpers.GetObjectValue(Missing.Value));
						ProgressBar1.Value = 20;
						NewLateBinding.LateCall(_xlApp.Sheets["Sheet1"], null, "Select", new object[0], null, null, null, IgnoreReturn: true);
						NewLateBinding.LateSetComplex(_xlApp.Sheets["Sheet1"], null, "Name", new object[1] { "Produksi" }, null, null, OptimisticSet: false, RValueBase: true);
						object instance = NewLateBinding.LateGet(_xlApp.ActiveSheet, null, "PageSetup", new object[0], null, null, null);
						NewLateBinding.LateSetComplex(instance, null, "LeftHeader", new object[1] { "" }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateSetComplex(instance, null, "CenterHeader", new object[1] { "" }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateSetComplex(instance, null, "RightHeader", new object[1] { "" }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateSetComplex(instance, null, "LeftFooter", new object[1] { "" }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateSetComplex(instance, null, "CenterFooter", new object[1] { "&F;  Page &P of &N" }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateSetComplex(instance, null, "RightFooter", new object[1] { "" }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateSetComplex(instance, null, "LeftMargin", new object[1] { _xlApp.Application.InchesToPoints(0.393700787401575) }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateSetComplex(instance, null, "RightMargin", new object[1] { _xlApp.Application.InchesToPoints(0.393700787401575) }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateSetComplex(instance, null, "TopMargin", new object[1] { _xlApp.Application.InchesToPoints(0.590551181102362) }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateSetComplex(instance, null, "BottomMargin", new object[1] { _xlApp.Application.InchesToPoints(0.590551181102362) }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateSetComplex(instance, null, "HeaderMargin", new object[1] { _xlApp.Application.InchesToPoints(0.511811023622047) }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateSetComplex(instance, null, "FooterMargin", new object[1] { _xlApp.Application.InchesToPoints(0.511811023622047) }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateSetComplex(instance, null, "PrintHeadings", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateSetComplex(instance, null, "PrintGridlines", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateSetComplex(instance, null, "CenterHorizontally", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateSetComplex(instance, null, "CenterVertically", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateSetComplex(instance, null, "Orientation", new object[1] { XlPageOrientation.xlPortrait }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateSetComplex(instance, null, "Draft", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateSetComplex(instance, null, "PaperSize", new object[1] { XlPaperSize.xlPaperLetter }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateSetComplex(instance, null, "FirstPageNumber", new object[1] { XlColorIndex.xlColorIndexAutomatic }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateSetComplex(instance, null, "Order", new object[1] { XlOrder.xlDownThenOver }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateSetComplex(instance, null, "BlackAndWhite", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateSetComplex(instance, null, "Zoom", new object[1] { 100 }, null, null, OptimisticSet: false, RValueBase: true);
						instance = null;
						((_Application)_xlApp).get_Range((object)"A1:D1", RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
						NewLateBinding.LateCall(_xlApp.Selection, null, "Merge", new object[0], null, null, null, IgnoreReturn: true);
						NewLateBinding.LateSetComplex(_xlApp.Selection, null, "HorizontalAlignment", new object[1] { XlHAlign.xlHAlignCenter }, null, null, OptimisticSet: false, RValueBase: true);
						((_Application)_xlApp).get_Range((object)"A2:D2", RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
						NewLateBinding.LateCall(_xlApp.Selection, null, "Merge", new object[0], null, null, null, IgnoreReturn: true);
						NewLateBinding.LateSetComplex(_xlApp.Selection, null, "HorizontalAlignment", new object[1] { XlHAlign.xlHAlignCenter }, null, null, OptimisticSet: false, RValueBase: true);
						((_Application)_xlApp).get_Range((object)"A1:D1", RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Font", new object[0], null, null, null), null, "Bold", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
						_xlApp.ActiveCell.FormulaR1C1 = "Daftar Aktivitas Produksi";
						((_Application)_xlApp).get_Range((object)"A2:D2", RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Font", new object[0], null, null, null), null, "Bold", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
						_xlApp.ActiveCell.FormulaR1C1 = Strings.Format(dtpBegin.Value, "dd MMMM yyyy");
						int num3 = 4;
						int num4 = num3;
						NewLateBinding.LateSetComplex(_xlApp.Columns["A:A", RuntimeHelpers.GetObjectValue(Missing.Value)], null, "ColumnWidth", new object[1] { 10 }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateSetComplex(_xlApp.Columns["B:B", RuntimeHelpers.GetObjectValue(Missing.Value)], null, "ColumnWidth", new object[1] { 22 }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateSetComplex(_xlApp.Columns["C:C", RuntimeHelpers.GetObjectValue(Missing.Value)], null, "ColumnWidth", new object[1] { 20 }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateSetComplex(_xlApp.Columns["D:D", RuntimeHelpers.GetObjectValue(Missing.Value)], null, "ColumnWidth", new object[1] { 20 }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateSetComplex(_xlApp.Columns["E:E", RuntimeHelpers.GetObjectValue(Missing.Value)], null, "ColumnWidth", new object[1] { 15 }, null, null, OptimisticSet: false, RValueBase: true);
						ProgressBar1.Value = 50;
						strReport = getPurchase();
						if (Operators.CompareString(strReport, "", TextCompare: false) != 0)
						{
							((_Application)_xlApp).get_Range((object)("A" + Conversions.ToString(num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Font", new object[0], null, null, null), null, "Bold", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
							_xlApp.ActiveCell.FormulaR1C1 = "Pembelian";
							num4++;
							((_Application)_xlApp).get_Range((object)("A" + Conversions.ToString(num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							_xlApp.ActiveCell.FormulaR1C1 = "Tanggal";
							((_Application)_xlApp).get_Range((object)("B" + Conversions.ToString(num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							_xlApp.ActiveCell.FormulaR1C1 = "Supplier";
							((_Application)_xlApp).get_Range((object)("C" + Conversions.ToString(num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							_xlApp.ActiveCell.FormulaR1C1 = "Barang";
							((_Application)_xlApp).get_Range((object)("D" + Conversions.ToString(num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							_xlApp.ActiveCell.FormulaR1C1 = "Jumlah";
							((_Application)_xlApp).get_Range((object)("A" + Conversions.ToString(num4) + ":D" + Conversions.ToString(num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Font", new object[0], null, null, null), null, "Bold", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
							object instance2 = NewLateBinding.LateGet(_xlApp.Selection, null, "Interior", new object[0], null, null, null);
							NewLateBinding.LateSetComplex(instance2, null, "ColorIndex", new object[1] { 15 }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance2, null, "Pattern", new object[1] { XlPattern.xlPatternSolid }, null, null, OptimisticSet: false, RValueBase: true);
							instance2 = null;
							((_Application)_xlApp).get_Range((object)("A" + Conversions.ToString(num4) + ":D" + Conversions.ToString(intTotalRows + num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlDiagonalDown }, null, null, null), null, "LineStyle", new object[1] { XlLineStyle.xlLineStyleNone }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlDiagonalUp }, null, null, null), null, "LineStyle", new object[1] { XlLineStyle.xlLineStyleNone }, null, null, OptimisticSet: false, RValueBase: true);
							object instance3 = NewLateBinding.LateGet(_xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlEdgeLeft }, null, null, null);
							NewLateBinding.LateSetComplex(instance3, null, "LineStyle", new object[1] { XlLineStyle.xlContinuous }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance3, null, "Weight", new object[1] { XlBorderWeight.xlThin }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance3, null, "ColorIndex", new object[1] { XlColorIndex.xlColorIndexAutomatic }, null, null, OptimisticSet: false, RValueBase: true);
							instance3 = null;
							object instance4 = NewLateBinding.LateGet(_xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlEdgeTop }, null, null, null);
							NewLateBinding.LateSetComplex(instance4, null, "LineStyle", new object[1] { XlLineStyle.xlContinuous }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance4, null, "Weight", new object[1] { XlBorderWeight.xlThin }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance4, null, "ColorIndex", new object[1] { XlColorIndex.xlColorIndexAutomatic }, null, null, OptimisticSet: false, RValueBase: true);
							instance4 = null;
							object instance5 = NewLateBinding.LateGet(_xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlEdgeBottom }, null, null, null);
							NewLateBinding.LateSetComplex(instance5, null, "LineStyle", new object[1] { XlLineStyle.xlContinuous }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance5, null, "Weight", new object[1] { XlBorderWeight.xlThin }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance5, null, "ColorIndex", new object[1] { XlColorIndex.xlColorIndexAutomatic }, null, null, OptimisticSet: false, RValueBase: true);
							instance5 = null;
							object instance6 = NewLateBinding.LateGet(_xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlEdgeRight }, null, null, null);
							NewLateBinding.LateSetComplex(instance6, null, "LineStyle", new object[1] { XlLineStyle.xlContinuous }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance6, null, "Weight", new object[1] { XlBorderWeight.xlThin }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance6, null, "ColorIndex", new object[1] { XlColorIndex.xlColorIndexAutomatic }, null, null, OptimisticSet: false, RValueBase: true);
							instance6 = null;
							object instance7 = NewLateBinding.LateGet(_xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlInsideVertical }, null, null, null);
							NewLateBinding.LateSetComplex(instance7, null, "LineStyle", new object[1] { XlLineStyle.xlContinuous }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance7, null, "Weight", new object[1] { XlBorderWeight.xlThin }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance7, null, "ColorIndex", new object[1] { XlColorIndex.xlColorIndexAutomatic }, null, null, OptimisticSet: false, RValueBase: true);
							instance7 = null;
							object instance8 = NewLateBinding.LateGet(_xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlInsideHorizontal }, null, null, null);
							NewLateBinding.LateSetComplex(instance8, null, "LineStyle", new object[1] { XlLineStyle.xlContinuous }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance8, null, "Weight", new object[1] { XlBorderWeight.xlThin }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance8, null, "ColorIndex", new object[1] { XlColorIndex.xlColorIndexAutomatic }, null, null, OptimisticSet: false, RValueBase: true);
							instance8 = null;
							((_Application)_xlApp).get_Range((object)("A" + Conversions.ToString(num4) + ":D" + Conversions.ToString(num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							object selection = _xlApp.Selection;
							NewLateBinding.LateSetComplex(selection, null, "HorizontalAlignment", new object[1] { XlHAlign.xlHAlignCenter }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection, null, "VerticalAlignment", new object[1] { XlVAlign.xlVAlignBottom }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection, null, "WrapText", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection, null, "Orientation", new object[1] { 0 }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection, null, "AddIndent", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection, null, "ShrinkToFit", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection, null, "MergeCells", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
							selection = null;
							num4++;
							((_Application)_xlApp).get_Range((object)("D" + Conversions.ToString(num4) + ":D" + Conversions.ToString(intTotalRows + num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							object selection2 = _xlApp.Selection;
							NewLateBinding.LateSetComplex(selection2, null, "HorizontalAlignment", new object[1] { XlHAlign.xlHAlignRight }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection2, null, "VerticalAlignment", new object[1] { XlVAlign.xlVAlignBottom }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection2, null, "numberformat", new object[1] { "@" }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection2, null, "WrapText", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection2, null, "Orientation", new object[1] { 0 }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection2, null, "AddIndent", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection2, null, "ShrinkToFit", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection2, null, "MergeCells", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
							selection2 = null;
							Clipboard.Clear();
							Clipboard.SetText(strReport);
							((_Application)_xlApp).get_Range((object)("A" + Conversions.ToString(num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							NewLateBinding.LateCall(_xlApp.ActiveSheet, null, "paste", new object[0], null, null, null, IgnoreReturn: true);
							num4 = num4 + intTotalRows + 1;
						}
						ProgressBar1.Value = 70;
						strReport = getProcess();
						if (Operators.CompareString(strReport, "", TextCompare: false) != 0)
						{
							((_Application)_xlApp).get_Range((object)("A" + Conversions.ToString(num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Font", new object[0], null, null, null), null, "Bold", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
							_xlApp.ActiveCell.FormulaR1C1 = "Produksi";
							num4++;
							((_Application)_xlApp).get_Range((object)("A" + Conversions.ToString(num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							_xlApp.ActiveCell.FormulaR1C1 = "Tanggal";
							((_Application)_xlApp).get_Range((object)("B" + Conversions.ToString(num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							_xlApp.ActiveCell.FormulaR1C1 = "Barang";
							((_Application)_xlApp).get_Range((object)("C" + Conversions.ToString(num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							_xlApp.ActiveCell.FormulaR1C1 = "Gudang";
							((_Application)_xlApp).get_Range((object)("D" + Conversions.ToString(num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							_xlApp.ActiveCell.FormulaR1C1 = "Jumlah";
							((_Application)_xlApp).get_Range((object)("A" + Conversions.ToString(num4) + ":D" + Conversions.ToString(num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Font", new object[0], null, null, null), null, "Bold", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
							object instance9 = NewLateBinding.LateGet(_xlApp.Selection, null, "Interior", new object[0], null, null, null);
							NewLateBinding.LateSetComplex(instance9, null, "ColorIndex", new object[1] { 15 }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance9, null, "Pattern", new object[1] { XlPattern.xlPatternSolid }, null, null, OptimisticSet: false, RValueBase: true);
							instance9 = null;
							((_Application)_xlApp).get_Range((object)("A" + Conversions.ToString(num4) + ":D" + Conversions.ToString(num4 + intTotalRows)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlDiagonalDown }, null, null, null), null, "LineStyle", new object[1] { XlLineStyle.xlLineStyleNone }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlDiagonalUp }, null, null, null), null, "LineStyle", new object[1] { XlLineStyle.xlLineStyleNone }, null, null, OptimisticSet: false, RValueBase: true);
							object instance10 = NewLateBinding.LateGet(_xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlEdgeLeft }, null, null, null);
							NewLateBinding.LateSetComplex(instance10, null, "LineStyle", new object[1] { XlLineStyle.xlContinuous }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance10, null, "Weight", new object[1] { XlBorderWeight.xlThin }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance10, null, "ColorIndex", new object[1] { XlColorIndex.xlColorIndexAutomatic }, null, null, OptimisticSet: false, RValueBase: true);
							instance10 = null;
							object instance11 = NewLateBinding.LateGet(_xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlEdgeTop }, null, null, null);
							NewLateBinding.LateSetComplex(instance11, null, "LineStyle", new object[1] { XlLineStyle.xlContinuous }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance11, null, "Weight", new object[1] { XlBorderWeight.xlThin }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance11, null, "ColorIndex", new object[1] { XlColorIndex.xlColorIndexAutomatic }, null, null, OptimisticSet: false, RValueBase: true);
							instance11 = null;
							object instance12 = NewLateBinding.LateGet(_xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlEdgeBottom }, null, null, null);
							NewLateBinding.LateSetComplex(instance12, null, "LineStyle", new object[1] { XlLineStyle.xlContinuous }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance12, null, "Weight", new object[1] { XlBorderWeight.xlThin }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance12, null, "ColorIndex", new object[1] { XlColorIndex.xlColorIndexAutomatic }, null, null, OptimisticSet: false, RValueBase: true);
							instance12 = null;
							object instance13 = NewLateBinding.LateGet(_xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlEdgeRight }, null, null, null);
							NewLateBinding.LateSetComplex(instance13, null, "LineStyle", new object[1] { XlLineStyle.xlContinuous }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance13, null, "Weight", new object[1] { XlBorderWeight.xlThin }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance13, null, "ColorIndex", new object[1] { XlColorIndex.xlColorIndexAutomatic }, null, null, OptimisticSet: false, RValueBase: true);
							instance13 = null;
							object instance14 = NewLateBinding.LateGet(_xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlInsideVertical }, null, null, null);
							NewLateBinding.LateSetComplex(instance14, null, "LineStyle", new object[1] { XlLineStyle.xlContinuous }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance14, null, "Weight", new object[1] { XlBorderWeight.xlThin }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance14, null, "ColorIndex", new object[1] { XlColorIndex.xlColorIndexAutomatic }, null, null, OptimisticSet: false, RValueBase: true);
							instance14 = null;
							object instance15 = NewLateBinding.LateGet(_xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlInsideHorizontal }, null, null, null);
							NewLateBinding.LateSetComplex(instance15, null, "LineStyle", new object[1] { XlLineStyle.xlContinuous }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance15, null, "Weight", new object[1] { XlBorderWeight.xlThin }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance15, null, "ColorIndex", new object[1] { XlColorIndex.xlColorIndexAutomatic }, null, null, OptimisticSet: false, RValueBase: true);
							instance15 = null;
							((_Application)_xlApp).get_Range((object)("A" + Conversions.ToString(num4) + ":D" + Conversions.ToString(num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							object selection3 = _xlApp.Selection;
							NewLateBinding.LateSetComplex(selection3, null, "HorizontalAlignment", new object[1] { XlHAlign.xlHAlignCenter }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection3, null, "VerticalAlignment", new object[1] { XlVAlign.xlVAlignBottom }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection3, null, "WrapText", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection3, null, "Orientation", new object[1] { 0 }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection3, null, "AddIndent", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection3, null, "ShrinkToFit", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection3, null, "MergeCells", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
							selection3 = null;
							num4++;
							((_Application)_xlApp).get_Range((object)("D" + Conversions.ToString(num4) + ":D" + Conversions.ToString(num4 + intTotalRows)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							object selection4 = _xlApp.Selection;
							NewLateBinding.LateSetComplex(selection4, null, "HorizontalAlignment", new object[1] { XlHAlign.xlHAlignRight }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection4, null, "VerticalAlignment", new object[1] { XlVAlign.xlVAlignBottom }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection4, null, "WrapText", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection4, null, "Orientation", new object[1] { 0 }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection4, null, "AddIndent", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection4, null, "ShrinkToFit", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection4, null, "MergeCells", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection4, null, "numberformat", new object[1] { "@" }, null, null, OptimisticSet: false, RValueBase: true);
							selection4 = null;
							Clipboard.Clear();
							Clipboard.SetText(strReport);
							((_Application)_xlApp).get_Range((object)("A" + Conversions.ToString(num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							NewLateBinding.LateCall(_xlApp.ActiveSheet, null, "Paste", new object[0], null, null, null, IgnoreReturn: true);
							int num5 = num4;
							num4 = num4 + intTotalRows + 1;
							bool flag = true;
							int num6 = num5;
							int num7 = num4 - 2;
							for (int i = num6; i <= num7; i++)
							{
								if (flag)
								{
									((_Application)_xlApp).get_Range((object)("A" + Conversions.ToString(i) + ":D" + Conversions.ToString(i)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
									object instance16 = NewLateBinding.LateGet(_xlApp.Selection, null, "Interior", new object[0], null, null, null);
									NewLateBinding.LateSetComplex(instance16, null, "ColorIndex", new object[1] { 15 }, null, null, OptimisticSet: false, RValueBase: true);
									NewLateBinding.LateSetComplex(instance16, null, "Pattern", new object[1] { XlPattern.xlPatternSolid }, null, null, OptimisticSet: false, RValueBase: true);
									instance16 = null;
									flag = false;
								}
								else if (Operators.ConditionalCompareObjectEqual(((_Application)_xlApp).get_Range((object)("A" + Conversions.ToString(i)), RuntimeHelpers.GetObjectValue(Missing.Value)).Text, "", TextCompare: false))
								{
									num8++;
								}
								if (num8 == 2)
								{
									num8 = 0;
									flag = true;
								}
							}
						}
						ProgressBar1.Value = 80;
						strReport = getTransfer();
						if (Operators.CompareString(strReport, "", TextCompare: false) != 0)
						{
							((_Application)_xlApp).get_Range((object)("A" + Conversions.ToString(num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Font", new object[0], null, null, null), null, "Bold", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
							_xlApp.ActiveCell.FormulaR1C1 = "Transfer";
							num4++;
							((_Application)_xlApp).get_Range((object)("A" + Conversions.ToString(num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							_xlApp.ActiveCell.FormulaR1C1 = "Tanggal";
							((_Application)_xlApp).get_Range((object)("B" + Conversions.ToString(num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							_xlApp.ActiveCell.FormulaR1C1 = "Barang";
							((_Application)_xlApp).get_Range((object)("C" + Conversions.ToString(num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							_xlApp.ActiveCell.FormulaR1C1 = "Asal";
							((_Application)_xlApp).get_Range((object)("D" + Conversions.ToString(num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							_xlApp.ActiveCell.FormulaR1C1 = "Tujuan";
							((_Application)_xlApp).get_Range((object)("E" + Conversions.ToString(num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							_xlApp.ActiveCell.FormulaR1C1 = "Jumlah";
							((_Application)_xlApp).get_Range((object)("A" + Conversions.ToString(num4) + ":E" + Conversions.ToString(num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Font", new object[0], null, null, null), null, "Bold", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
							object instance17 = NewLateBinding.LateGet(_xlApp.Selection, null, "Interior", new object[0], null, null, null);
							NewLateBinding.LateSetComplex(instance17, null, "ColorIndex", new object[1] { 15 }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance17, null, "Pattern", new object[1] { XlPattern.xlPatternSolid }, null, null, OptimisticSet: false, RValueBase: true);
							instance17 = null;
							((_Application)_xlApp).get_Range((object)("A" + Conversions.ToString(num4) + ":E" + Conversions.ToString(intTotalRows + num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlDiagonalDown }, null, null, null), null, "LineStyle", new object[1] { XlLineStyle.xlLineStyleNone }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlDiagonalUp }, null, null, null), null, "LineStyle", new object[1] { XlLineStyle.xlLineStyleNone }, null, null, OptimisticSet: false, RValueBase: true);
							object instance18 = NewLateBinding.LateGet(_xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlEdgeLeft }, null, null, null);
							NewLateBinding.LateSetComplex(instance18, null, "LineStyle", new object[1] { XlLineStyle.xlContinuous }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance18, null, "Weight", new object[1] { XlBorderWeight.xlThin }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance18, null, "ColorIndex", new object[1] { XlColorIndex.xlColorIndexAutomatic }, null, null, OptimisticSet: false, RValueBase: true);
							instance18 = null;
							object instance19 = NewLateBinding.LateGet(_xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlEdgeTop }, null, null, null);
							NewLateBinding.LateSetComplex(instance19, null, "LineStyle", new object[1] { XlLineStyle.xlContinuous }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance19, null, "Weight", new object[1] { XlBorderWeight.xlThin }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance19, null, "ColorIndex", new object[1] { XlColorIndex.xlColorIndexAutomatic }, null, null, OptimisticSet: false, RValueBase: true);
							instance19 = null;
							object instance20 = NewLateBinding.LateGet(_xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlEdgeBottom }, null, null, null);
							NewLateBinding.LateSetComplex(instance20, null, "LineStyle", new object[1] { XlLineStyle.xlContinuous }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance20, null, "Weight", new object[1] { XlBorderWeight.xlThin }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance20, null, "ColorIndex", new object[1] { XlColorIndex.xlColorIndexAutomatic }, null, null, OptimisticSet: false, RValueBase: true);
							instance20 = null;
							object instance21 = NewLateBinding.LateGet(_xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlEdgeRight }, null, null, null);
							NewLateBinding.LateSetComplex(instance21, null, "LineStyle", new object[1] { XlLineStyle.xlContinuous }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance21, null, "Weight", new object[1] { XlBorderWeight.xlThin }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance21, null, "ColorIndex", new object[1] { XlColorIndex.xlColorIndexAutomatic }, null, null, OptimisticSet: false, RValueBase: true);
							instance21 = null;
							object instance22 = NewLateBinding.LateGet(_xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlInsideVertical }, null, null, null);
							NewLateBinding.LateSetComplex(instance22, null, "LineStyle", new object[1] { XlLineStyle.xlContinuous }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance22, null, "Weight", new object[1] { XlBorderWeight.xlThin }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance22, null, "ColorIndex", new object[1] { XlColorIndex.xlColorIndexAutomatic }, null, null, OptimisticSet: false, RValueBase: true);
							instance22 = null;
							object instance23 = NewLateBinding.LateGet(_xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlInsideHorizontal }, null, null, null);
							NewLateBinding.LateSetComplex(instance23, null, "LineStyle", new object[1] { XlLineStyle.xlContinuous }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance23, null, "Weight", new object[1] { XlBorderWeight.xlThin }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance23, null, "ColorIndex", new object[1] { XlColorIndex.xlColorIndexAutomatic }, null, null, OptimisticSet: false, RValueBase: true);
							instance23 = null;
							((_Application)_xlApp).get_Range((object)("A" + Conversions.ToString(num4) + ":E" + Conversions.ToString(num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							object selection5 = _xlApp.Selection;
							NewLateBinding.LateSetComplex(selection5, null, "HorizontalAlignment", new object[1] { XlHAlign.xlHAlignCenter }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection5, null, "VerticalAlignment", new object[1] { XlVAlign.xlVAlignBottom }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection5, null, "WrapText", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection5, null, "Orientation", new object[1] { 0 }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection5, null, "AddIndent", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection5, null, "ShrinkToFit", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection5, null, "MergeCells", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
							selection5 = null;
							num4++;
							((_Application)_xlApp).get_Range((object)("E" + Conversions.ToString(num4) + ":E" + Conversions.ToString(intTotalRows + num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							object selection6 = _xlApp.Selection;
							NewLateBinding.LateSetComplex(selection6, null, "HorizontalAlignment", new object[1] { XlHAlign.xlHAlignRight }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection6, null, "VerticalAlignment", new object[1] { XlVAlign.xlVAlignBottom }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection6, null, "numberformat", new object[1] { "@" }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection6, null, "WrapText", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection6, null, "Orientation", new object[1] { 0 }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection6, null, "AddIndent", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection6, null, "ShrinkToFit", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection6, null, "MergeCells", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
							selection6 = null;
							Clipboard.Clear();
							Clipboard.SetText(strReport);
							((_Application)_xlApp).get_Range((object)("A" + Conversions.ToString(num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							NewLateBinding.LateCall(_xlApp.ActiveSheet, null, "Paste", new object[0], null, null, null, IgnoreReturn: true);
							num4 = num4 + intTotalRows + 1;
						}
						ProgressBar1.Value = 90;
						strReport = getAdjustment();
						if (Operators.CompareString(strReport, "", TextCompare: false) != 0)
						{
							((_Application)_xlApp).get_Range((object)("A" + Conversions.ToString(num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Font", new object[0], null, null, null), null, "Bold", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
							_xlApp.ActiveCell.FormulaR1C1 = "Penyesuaian";
							num4++;
							((_Application)_xlApp).get_Range((object)("A" + Conversions.ToString(num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							_xlApp.ActiveCell.FormulaR1C1 = "Tanggal";
							((_Application)_xlApp).get_Range((object)("B" + Conversions.ToString(num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							_xlApp.ActiveCell.FormulaR1C1 = "Barang";
							((_Application)_xlApp).get_Range((object)("C" + Conversions.ToString(num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							_xlApp.ActiveCell.FormulaR1C1 = "Gudang";
							((_Application)_xlApp).get_Range((object)("D" + Conversions.ToString(num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							_xlApp.ActiveCell.FormulaR1C1 = "Tipe";
							((_Application)_xlApp).get_Range((object)("E" + Conversions.ToString(num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							_xlApp.ActiveCell.FormulaR1C1 = "Jumlah";
							((_Application)_xlApp).get_Range((object)("A" + Conversions.ToString(num4) + ":E" + Conversions.ToString(num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Font", new object[0], null, null, null), null, "Bold", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
							object instance24 = NewLateBinding.LateGet(_xlApp.Selection, null, "Interior", new object[0], null, null, null);
							NewLateBinding.LateSetComplex(instance24, null, "ColorIndex", new object[1] { 15 }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance24, null, "Pattern", new object[1] { XlPattern.xlPatternSolid }, null, null, OptimisticSet: false, RValueBase: true);
							instance24 = null;
							((_Application)_xlApp).get_Range((object)("A" + Conversions.ToString(num4) + ":E" + Conversions.ToString(intTotalRows + num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlDiagonalDown }, null, null, null), null, "LineStyle", new object[1] { XlLineStyle.xlLineStyleNone }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(_xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlDiagonalUp }, null, null, null), null, "LineStyle", new object[1] { XlLineStyle.xlLineStyleNone }, null, null, OptimisticSet: false, RValueBase: true);
							object instance25 = NewLateBinding.LateGet(_xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlEdgeLeft }, null, null, null);
							NewLateBinding.LateSetComplex(instance25, null, "LineStyle", new object[1] { XlLineStyle.xlContinuous }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance25, null, "Weight", new object[1] { XlBorderWeight.xlThin }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance25, null, "ColorIndex", new object[1] { XlColorIndex.xlColorIndexAutomatic }, null, null, OptimisticSet: false, RValueBase: true);
							instance25 = null;
							object instance26 = NewLateBinding.LateGet(_xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlEdgeTop }, null, null, null);
							NewLateBinding.LateSetComplex(instance26, null, "LineStyle", new object[1] { XlLineStyle.xlContinuous }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance26, null, "Weight", new object[1] { XlBorderWeight.xlThin }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance26, null, "ColorIndex", new object[1] { XlColorIndex.xlColorIndexAutomatic }, null, null, OptimisticSet: false, RValueBase: true);
							instance26 = null;
							object instance27 = NewLateBinding.LateGet(_xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlEdgeBottom }, null, null, null);
							NewLateBinding.LateSetComplex(instance27, null, "LineStyle", new object[1] { XlLineStyle.xlContinuous }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance27, null, "Weight", new object[1] { XlBorderWeight.xlThin }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance27, null, "ColorIndex", new object[1] { XlColorIndex.xlColorIndexAutomatic }, null, null, OptimisticSet: false, RValueBase: true);
							instance27 = null;
							object instance28 = NewLateBinding.LateGet(_xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlEdgeRight }, null, null, null);
							NewLateBinding.LateSetComplex(instance28, null, "LineStyle", new object[1] { XlLineStyle.xlContinuous }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance28, null, "Weight", new object[1] { XlBorderWeight.xlThin }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance28, null, "ColorIndex", new object[1] { XlColorIndex.xlColorIndexAutomatic }, null, null, OptimisticSet: false, RValueBase: true);
							instance28 = null;
							object instance29 = NewLateBinding.LateGet(_xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlInsideVertical }, null, null, null);
							NewLateBinding.LateSetComplex(instance29, null, "LineStyle", new object[1] { XlLineStyle.xlContinuous }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance29, null, "Weight", new object[1] { XlBorderWeight.xlThin }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance29, null, "ColorIndex", new object[1] { XlColorIndex.xlColorIndexAutomatic }, null, null, OptimisticSet: false, RValueBase: true);
							instance29 = null;
							object instance30 = NewLateBinding.LateGet(_xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlInsideHorizontal }, null, null, null);
							NewLateBinding.LateSetComplex(instance30, null, "LineStyle", new object[1] { XlLineStyle.xlContinuous }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance30, null, "Weight", new object[1] { XlBorderWeight.xlThin }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance30, null, "ColorIndex", new object[1] { XlColorIndex.xlColorIndexAutomatic }, null, null, OptimisticSet: false, RValueBase: true);
							instance30 = null;
							((_Application)_xlApp).get_Range((object)("A" + Conversions.ToString(num4) + ":E" + Conversions.ToString(num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							object selection7 = _xlApp.Selection;
							NewLateBinding.LateSetComplex(selection7, null, "HorizontalAlignment", new object[1] { XlHAlign.xlHAlignCenter }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection7, null, "VerticalAlignment", new object[1] { XlVAlign.xlVAlignBottom }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection7, null, "WrapText", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection7, null, "Orientation", new object[1] { 0 }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection7, null, "AddIndent", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection7, null, "ShrinkToFit", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection7, null, "MergeCells", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
							selection7 = null;
							num4++;
							((_Application)_xlApp).get_Range((object)("E" + Conversions.ToString(num4) + ":E" + Conversions.ToString(intTotalRows + num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							object selection8 = _xlApp.Selection;
							NewLateBinding.LateSetComplex(selection8, null, "HorizontalAlignment", new object[1] { XlHAlign.xlHAlignRight }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection8, null, "VerticalAlignment", new object[1] { XlVAlign.xlVAlignBottom }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection8, null, "numberformat", new object[1] { "@" }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection8, null, "WrapText", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection8, null, "Orientation", new object[1] { 0 }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection8, null, "AddIndent", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection8, null, "ShrinkToFit", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(selection8, null, "MergeCells", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
							selection8 = null;
							Clipboard.Clear();
							Clipboard.SetText(strReport);
							((_Application)_xlApp).get_Range((object)("A" + Conversions.ToString(num4)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							NewLateBinding.LateCall(_xlApp.ActiveSheet, null, "Paste", new object[0], null, null, null, IgnoreReturn: true);
							num4 = num4 + intTotalRows + 1;
						}
						NewLateBinding.LateCall(_xlApp.Cells[1, 1], null, "Select", new object[0], null, null, null, IgnoreReturn: true);
						Module1.MinimiseAllWindows();
						_xlApp.Visible = true;
						_xlApp.WindowState = XlWindowState.xlMaximized;
						ProgressBar1.Visible = false;
						Cursor = Cursors.Default;
						goto end_IL_0001;
					}
					case 12756:
						num = -1;
						switch (num2)
						{
						case 2:
							Cursor = Cursors.Default;
							Module1.SaveError(Information.Err(), "frmReportProductionActivity", "btnSearch_click", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 12756;
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

	private string getPurchase()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		string text = default(string);
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
						text = "";
						string strSql = " SELECT invId,invDate,invNumber,supName FROM purchaseinvoices a, suppliers b  WHERE a.supId = b.supId AND invCreated LIKE '" + Strings.Format(dtpBegin.Value, "yyyy-MM-dd") + "%' ";
						DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
						intTotalRows = 0;
						IEnumerator enumerator = dataTable.Rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(text, dataRow["invDate"]), "\t"), dataRow["supName"]), "\t"));
							strSql = Conversions.ToString(Operators.ConcatenateObject(" SELECT itemName,iiMainQty FROM purchaseinvoices_items a, items b  WHERE a.itemId = b.itemId AND invId = ", dataRow["invid"]));
							DataTable dataTable2 = Module1.sqlTable(strSql, "data", Clone: false);
							string value = Conversions.ToString(Value: true);
							IEnumerator enumerator2 = dataTable2.Rows.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								DataRow dataRow2 = (DataRow)enumerator2.Current;
								if (Conversions.ToBoolean(value))
								{
									text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(text, dataRow2["itemName"]), "\t"), Module1.formatCustomDecimal(Conversions.ToString(dataRow2["iiMainQty"]), 3)), "\r\n"));
									value = Conversions.ToString(Value: false);
								}
								else
								{
									text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(text + "\t\t", dataRow2["itemName"]), "\t"), Module1.formatCustomDecimal(Conversions.ToString(dataRow2["iiMainQty"]), 3)), "\r\n"));
								}
								intTotalRows++;
							}
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
						goto end_IL_0001;
					}
					case 561:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmReportProductionActivity", "getPurchase", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 561;
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
		return text;
	}

	private string getProcess()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		string text = default(string);
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
						text = "";
						string strSql = " SELECT proId,proDate,proMainQty,itemName,storeName FROM processes a, items b, storages c  WHERE a.itemId = b.itemId  AND a.storeId = c.storeId  AND proCreated LIKE '" + Strings.Format(dtpBegin.Value, "yyyy-MM-dd") + "%' ";
						DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
						intTotalRows = 0;
						IEnumerator enumerator = dataTable.Rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(text, dataRow["proDate"]), "\t"), dataRow["itemName"]), "\t"), dataRow["storeName"]), "\t"), Module1.formatCustomDecimal(Conversions.ToString(dataRow["proMainQty"]), 3)), "\r\n"));
							strSql = Conversions.ToString(Operators.ConcatenateObject(" SELECT itemName,comMainQty,comDate,storeName  FROM processcomponents a, items b, storages c  WHERE a.itemId = b.itemId  AND a.storeId = c.storeId  AND proId = ", dataRow["proid"]));
							DataTable dataTable2 = Module1.sqlTable(strSql, "data", Clone: false);
							text += "\tKomponen:\r\n";
							IEnumerator enumerator2 = dataTable2.Rows.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								DataRow dataRow2 = (DataRow)enumerator2.Current;
								text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(text, dataRow2["comDate"]), "\t"), dataRow2["itemName"]), "\t"), dataRow2["storeName"]), "\t"), Module1.formatCustomDecimal(Conversions.ToString(dataRow2["comMainQty"]), 3)), "\r\n"));
								intTotalRows++;
							}
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
							text += "\r\n";
							intTotalRows += 3;
						}
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
						intTotalRows--;
						goto end_IL_0001;
					}
					case 616:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmReportProductionActivity", "getProcess", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 616;
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
		return text;
	}

	private string getTransfer()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		string text = default(string);
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
						text = "";
						string strSql = " SELECT a.transferId,transferDate,transferQty,itemName,d.storeName as storageFrom, e.storeName as storageTo  FROM transfer a, transfer_item b, items c, storages d, storages e  WHERE a.transferId = b.transferId  AND b.itemId = c.itemId  AND storageFromId = d.storeId  AND storageToId = e.storeId  AND transferCreated LIKE '" + Strings.Format(dtpBegin.Value, "yyyy-MM-dd") + "%' ORDER BY 2,5,6,3 ";
						DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
						intTotalRows = 0;
						IEnumerator enumerator = dataTable.Rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(text, dataRow["transferDate"]), "\t"), dataRow["itemName"]), "\t"), dataRow["storageFrom"]), "\t"), dataRow["storageTo"]), "\t"), Module1.formatCustomDecimal(Conversions.ToString(dataRow["transferQty"]), 3)), "\r\n"));
							intTotalRows++;
						}
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
						goto end_IL_0001;
					}
					case 349:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmReportProductionActivity", "getTransfer", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 349;
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
		return text;
	}

	private string getAdjustment()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		string text = default(string);
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
						text = "";
						string strSql = " SELECT adjId,adjDate,adjMainQty,adjType,itemName,storeName  FROM adjustments a, items b, storages c  WHERE a.itemId = b.itemId  AND a.storeId = c.storeId  AND adjCreated LIKE '" + Strings.Format(dtpBegin.Value, "yyyy-MM-dd") + "%' ORDER BY 2,5,6,3 ";
						DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
						intTotalRows = 0;
						IEnumerator enumerator = dataTable.Rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(text, dataRow["adjDate"]), "\t"), dataRow["itemName"]), "\t"), dataRow["storeName"]), "\t"), Interaction.IIf(Conversions.ToBoolean(dataRow["adjType"]), "Kurang", "Tambah")), "\t"), Module1.formatCustomDecimal(Conversions.ToString(dataRow["adjMainQty"]), 3)), "\r\n"));
							intTotalRows++;
						}
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
						goto end_IL_0001;
					}
					case 369:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmReportProductionActivity", "getAdjustment", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 369;
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
		return text;
	}
}
