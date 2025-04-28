using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
public class frmReportProductionPrediction : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvList")]
	private DataGridView _dgvList;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnReset")]
	private Button _btnReset;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSearch")]
	private Button _btnSearch;

	private Excel.Application _xlApp;

	private Workbook _xlWb;

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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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

	[field: AccessedThroughProperty("lblPath")]
	internal virtual Label lblPath
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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboType")]
	internal virtual ComboBox cboType
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

	[field: AccessedThroughProperty("LineShape1")]
	internal virtual LineShape LineShape1
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

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
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

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
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
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		this.dgvList = new System.Windows.Forms.DataGridView();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.lblPath = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.dtpBegin = new System.Windows.Forms.DateTimePicker();
		this.btnReset = new System.Windows.Forms.Button();
		this.btnSearch = new System.Windows.Forms.Button();
		this.Label5 = new System.Windows.Forms.Label();
		this.cboType = new System.Windows.Forms.ComboBox();
		this.ShapeContainer1 = new ShapeContainer();
		this.LineShape1 = new LineShape();
		this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		base.SuspendLayout();
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.Location = new System.Drawing.Point(274, 127);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(387, 275);
		this.dgvList.TabIndex = 10;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(271, 38);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(213, 13);
		this.Label1.TabIndex = 11;
		this.Label1.Text = "Double Click nama file untuk membuka File.";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(271, 60);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(218, 13);
		this.Label2.TabIndex = 12;
		this.Label2.Text = "Hanya 10 file terakhir yang ditampilkan disini.";
		this.lblPath.AutoSize = true;
		this.lblPath.Location = new System.Drawing.Point(271, 105);
		this.lblPath.Name = "lblPath";
		this.lblPath.Size = new System.Drawing.Size(39, 13);
		this.lblPath.TabIndex = 14;
		this.lblPath.Text = "lblPath";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(271, 83);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(205, 13);
		this.Label3.TabIndex = 15;
		this.Label3.Text = "Daftar file lengkapnya bisa dilihat di folder:";
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(11, 41);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(46, 13);
		this.Label4.TabIndex = 244;
		this.Label4.Text = "Tanggal";
		this.dtpBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpBegin.Location = new System.Drawing.Point(63, 38);
		this.dtpBegin.Name = "dtpBegin";
		this.dtpBegin.Size = new System.Drawing.Size(121, 20);
		this.dtpBegin.TabIndex = 243;
		this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnReset.Location = new System.Drawing.Point(117, 91);
		this.btnReset.Name = "btnReset";
		this.btnReset.Size = new System.Drawing.Size(47, 24);
		this.btnReset.TabIndex = 246;
		this.btnReset.Text = "&Reset";
		this.btnReset.UseVisualStyleBackColor = true;
		this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSearch.Location = new System.Drawing.Point(64, 91);
		this.btnSearch.Name = "btnSearch";
		this.btnSearch.Size = new System.Drawing.Size(47, 24);
		this.btnSearch.TabIndex = 245;
		this.btnSearch.Text = "Excel";
		this.btnSearch.UseVisualStyleBackColor = true;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(11, 67);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(28, 13);
		this.Label5.TabIndex = 248;
		this.Label5.Text = "Tipe";
		this.cboType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboType.FormattingEnabled = true;
		this.cboType.Location = new System.Drawing.Point(63, 64);
		this.cboType.Name = "cboType";
		this.cboType.Size = new System.Drawing.Size(121, 21);
		this.cboType.TabIndex = 247;
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).Location = new System.Drawing.Point(0, 0);
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).Margin = new System.Windows.Forms.Padding(0);
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).Name = "ShapeContainer1";
		this.ShapeContainer1.Shapes.AddRange((Shape[])(object)new Shape[1] { (Shape)this.LineShape1 });
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).Size = new System.Drawing.Size(676, 415);
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).TabIndex = 249;
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).TabStop = false;
		((Shape)this.LineShape1).Name = "LineShape1";
		this.LineShape1.X1 = 258;
		this.LineShape1.X2 = 259;
		this.LineShape1.Y1 = 13;
		this.LineShape1.Y2 = 401;
		this.ProgressBar1.Location = new System.Drawing.Point(12, 136);
		this.ProgressBar1.Name = "ProgressBar1";
		this.ProgressBar1.Size = new System.Drawing.Size(233, 23);
		this.ProgressBar1.TabIndex = 253;
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.Location = new System.Drawing.Point(271, 15);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(307, 13);
		this.Label6.TabIndex = 254;
		this.Label6.Text = "Buka Report lama ( report ini dibuat secara otomatis setiap hari )";
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.Location = new System.Drawing.Point(11, 15);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(88, 13);
		this.Label7.TabIndex = 255;
		this.Label7.Text = "Buat Report baru";
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(12, 118);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(236, 13);
		this.Label8.TabIndex = 256;
		this.Label8.Text = "Pembuatan Report memakan waktu 30-70 detik.";
		base.AcceptButton = this.btnSearch;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(676, 415);
		base.Controls.Add(this.Label8);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.ProgressBar1);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.cboType);
		base.Controls.Add(this.btnReset);
		base.Controls.Add(this.btnSearch);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.dtpBegin);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.lblPath);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.dgvList);
		base.Controls.Add((System.Windows.Forms.Control)(object)this.ShapeContainer1);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmReportProductionPrediction";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Report Kebutuhan Bahan";
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmReportProductionPrediction()
	{
		base.KeyDown += frmReportProductionPrediction_KeyDown;
		base.Load += frmReportProductionPrediction_Load;
		InitializeComponent();
		DoubleBuffered = true;
		ComboBox combo = cboType;
		cCombo.getReportProductionPredictionType(ref combo);
		cboType = combo;
		base.MdiParent = MyProject.Forms.frmMenu;
		PrepareForm();
	}

	private void PrepareForm()
	{
		dtpBegin.Value = DateAndTime.Now;
		cboType.SelectedIndex = 0;
	}

	private void frmReportProductionPrediction_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void frmReportProductionPrediction_Load(object sender, EventArgs e)
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
					lblPath.Text = Module1.pubReportPredictionPath;
					DirectoryInfo directoryInfo = new DirectoryInfo(Module1.pubReportPredictionPath);
					FileInfo[] files = directoryInfo.GetFiles("*");
					Array.Sort(files, new cCompareFileInfo());
					Array.Reverse(files);
					dgvList.Rows.Clear();
					dgvList.Columns.Add("", "FullFileName");
					dgvList.Columns.Add("", "Nama File");
					dgvList.Columns[0].Visible = false;
					dgvList.Columns[1].Width = 360;
					dgvList.RowHeadersVisible = false;
					dgvList.AllowUserToAddRows = false;
					dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
					dgvList.ReadOnly = true;
					dgvList.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
					dgvList.AllowUserToResizeRows = false;
					int num3 = 0;
					FileInfo[] array = files;
					foreach (FileInfo fileInfo in array)
					{
						dgvList.Rows.Add(fileInfo.FullName.ToString(), fileInfo.Name.ToString());
						num3 = checked(num3 + 1);
						if (num3 == 10)
						{
							break;
						}
					}
					goto end_IL_0001;
				}
				case 423:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmProductionPrediction", "FormLoad", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 423;
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

	private void dgvList_DoubleClick(object sender, EventArgs e)
	{
		getData();
	}

	private void getData()
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
					if (dgvList.RowCount > 0 && Operators.ConditionalCompareObjectNotEqual(dgvList[0, dgvList.CurrentRow.Index].Value, "", TextCompare: false))
					{
						Type typeFromHandle = typeof(Process);
						DataGridViewCell dataGridViewCell;
						object[] obj = new object[1] { (dataGridViewCell = dgvList[0, dgvList.CurrentRow.Index]).Value };
						object[] array = obj;
						bool[] obj2 = new bool[1] { true };
						bool[] array2 = obj2;
						NewLateBinding.LateCall(null, typeFromHandle, "Start", obj, null, null, obj2, IgnoreReturn: true);
						if (array2[0])
						{
							dataGridViewCell.Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
						}
					}
					goto end_IL_0001;
				case 222:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmReportProductionPrediction", "getData", "");
						goto end_IL_0001;
					}
					break;
				}
				goto IL_0114;
				end_IL_0001:;
			}
			catch (object obj3) when (obj3 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj3);
				try0001_dispatch = 222;
				continue;
			}
			break;
			IL_0114:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
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
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			e.SuppressKeyPress = true;
		}
	}

	private void dgvList_GotFocus(object sender, EventArgs e)
	{
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

	private void btnSearch_Click(object sender, EventArgs e)
	{
		if (cboType.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih tipe report.", MsgBoxStyle.Information);
			cboType.Focus();
			return;
		}
		Module1.SaveDebug("Report Production Prediction - Start");
		Cursor = Cursors.WaitCursor;
		ProgressBar1.Visible = true;
		ReportProductionPrediction(dtpBegin.Value, Conversions.ToString(Interaction.IIf(cboType.SelectedIndex == 0, "TEH", "KEMASAN")), SaveToFile: false);
		ProgressBar1.Visible = false;
		Cursor = Cursors.Default;
		Module1.SaveDebug("Report Production Prediction - Finish");
	}

	public void ReportProductionPrediction(DateTime datReport, string strType, bool SaveToFile)
	{
		ProgressBar1.Value = 5;
		_xlApp = (Excel.Application)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
		_xlWb = _xlApp.Workbooks.Add(RuntimeHelpers.GetObjectValue(Missing.Value));
		NewLateBinding.LateCall(_xlApp.Sheets["Sheet1"], null, "Select", new object[0], null, null, null, IgnoreReturn: true);
		NewLateBinding.LateSetComplex(_xlApp.Sheets["Sheet1"], null, "Name", new object[1] { "Produksi" }, null, null, OptimisticSet: false, RValueBase: true);
		object obj = NewLateBinding.LateGet(_xlApp.ActiveSheet, null, "PageSetup", new object[0], null, null, null);
		obj = null;
		ProgressBar1.Value = 10;
		cStock cStock2 = new cStock();
		int num = 1;
		int num2 = 2;
		checked
		{
			int num3 = DateAndTime.Month(DateAndTime.Now) - 1;
			int num4 = DateAndTime.Year(DateAndTime.Now);
			if (num3 == 0)
			{
				num3 = 12;
				num4--;
			}
			string text = Conversions.ToString(datReport.Year - 1) + "-" + Conversions.ToString(datReport.Month) + "-" + Conversions.ToString(datReport.Day);
			string text2 = Strings.Format(datReport, "yyyy-MM-dd");
			string text3 = " SELECT catId, prodName, FORMAT(SUM(qty),0) as qty  FROM ( ";
			text3 = text3 + " SELECT c.catId, prodName, SUM(ppAmount) as qty  FROM penjualan a, penjProd b, produk c, customer d  WHERE a.penjId = b.penjId  AND b.prodId = c.prodId  AND a.custId = d.custId  AND c.typeId = 1  AND penjBsType = 0  AND b.doId IS NULL  AND penjDate >= '" + text + "' AND penjDate < '" + text2 + "'  AND d.branchId = 1   GROUP BY prodName ";
			text3 += " UNION ALL ";
			text3 = text3 + " SELECT c.catId, prodName, SUM(doQty) as qty  FROM deliveryorder a, deliveryorder_item b, produk c, customer d  WHERE a.doId = b.doId  AND b.itemId = c.prodId  AND a.custId = d.custId  AND c.typeId = 1  AND doDate >= '" + text + "' AND doDate < '" + text2 + "'  AND d.branchId = 1   GROUP BY prodName ORDER BY catId, prodName ";
			text3 += " ) as a GROUP BY prodName ORDER BY catId, prodName ";
			DataTable dataTable = Module1.sqlTable(text3, "data", Clone: false);
			int count = dataTable.Rows.Count;
			int num5 = count + 2;
			string left = "";
			string left2 = "";
			string left3 = "";
			foreach (DataRow row in dataTable.Rows)
			{
				left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, Interaction.IIf(Operators.CompareString(left, "", TextCompare: false) != 0, "\t", "")), row["catId"]));
				left2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left2, Interaction.IIf(Operators.CompareString(left2, "", TextCompare: false) != 0, "\t", "")), row["prodName"]));
				left3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left3, Interaction.IIf(Operators.CompareString(left3, "", TextCompare: false) != 0, "\t", "")), row["qty"]));
			}
			num = num2;
			int num6 = num + 1;
			Clipboard.SetText(left);
			((_Application)_xlApp).get_Range((object)("C" + Conversions.ToString(num - 1)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
			NewLateBinding.LateCall(_xlApp.ActiveSheet, null, "Paste", new object[0], null, null, null, IgnoreReturn: true);
			Clipboard.SetText(left2);
			((_Application)_xlApp).get_Range((object)("C" + Conversions.ToString(num + 1 - 1)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
			NewLateBinding.LateCall(_xlApp.ActiveSheet, null, "Paste", new object[0], null, null, null, IgnoreReturn: true);
			Clipboard.SetText(left3);
			((_Application)_xlApp).get_Range((object)("C" + Conversions.ToString(num + 2 - 1)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
			NewLateBinding.LateCall(_xlApp.ActiveSheet, null, "Paste", new object[0], null, null, null, IgnoreReturn: true);
			_xlApp.Cells[num + 1, 2] = "Total";
			num += 2;
			object obj2 = _xlApp.Sheets[1];
			object instance = obj2;
			object[] array = new object[2];
			object instance2;
			object instance3 = (instance2 = obj2);
			int num7;
			object[] obj3 = new object[2]
			{
				num7 = num,
				null
			};
			object obj4 = (obj3[1] = 3);
			object[] array2 = obj3;
			bool[] array3;
			object obj5 = NewLateBinding.LateGet(instance3, null, "Cells", obj3, null, null, array3 = new bool[2] { true, false });
			if (array3[0])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
			}
			array[0] = obj5;
			object instance4;
			object instance5 = (instance4 = obj2);
			int num8;
			object[] obj6 = new object[2]
			{
				num8 = num,
				null
			};
			object obj7 = (obj6[1] = 3);
			array2 = obj6;
			obj5 = NewLateBinding.LateGet(instance5, null, "Cells", obj6, null, null, array3 = new bool[2] { true, false });
			if (array3[0])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
			}
			array[1] = obj5;
			object[] array4 = array;
			bool[] array5;
			object obj8 = NewLateBinding.LateGet(instance, null, "Range", array, null, null, array5 = new bool[2] { true, true });
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(instance2, null, "Cells", new object[3]
				{
					num7,
					obj4,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array5[1])
			{
				NewLateBinding.LateSetComplex(instance4, null, "Cells", new object[3]
				{
					num8,
					obj7,
					array4[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			Range range = (Range)obj8;
			range.Select();
			obj2 = null;
			_xlApp.ActiveCell.FormulaR1C1 = "=R[-1]C/12/25";
			object obj9 = _xlApp.Sheets[1];
			object selection = _xlApp.Selection;
			array2 = new object[2];
			object[] array6 = array2;
			object instance6 = (obj7 = obj9);
			object[] array7 = new object[2];
			object instance7 = (instance2 = obj9);
			object[] obj10 = new object[2]
			{
				num8 = num,
				null
			};
			obj8 = (obj10[1] = 3);
			object[] array8 = obj10;
			bool[] array9;
			object obj11 = NewLateBinding.LateGet(instance7, null, "Cells", obj10, null, null, array9 = new bool[2] { true, false });
			if (array9[0])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array8[0]), typeof(int));
			}
			instance4 = (array7[0] = obj11);
			object instance8 = (obj5 = obj9);
			object[] obj12 = new object[2]
			{
				num7 = num,
				null
			};
			object obj13 = (obj12[1] = 2 + count);
			array8 = obj12;
			obj11 = NewLateBinding.LateGet(instance8, null, "Cells", obj12, null, null, array9 = new bool[2] { true, false });
			if (array9[0])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array8[0]), typeof(int));
			}
			obj4 = (array7[1] = obj11);
			object[] array10 = array7;
			object obj14 = NewLateBinding.LateGet(instance6, null, "Range", array7, null, null, array3 = new bool[2] { true, true });
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(instance2, null, "Cells", new object[3]
				{
					num8,
					obj8,
					array10[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array3[1])
			{
				NewLateBinding.LateSetComplex(obj5, null, "Cells", new object[3]
				{
					num7,
					obj13,
					array10[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			array6[0] = obj14;
			array2[1] = XlAutoFillType.xlFillDefault;
			NewLateBinding.LateCall(selection, null, "AutoFill", array4 = array2, new string[2] { "Destination", "Type" }, null, array5 = new bool[2] { true, false }, IgnoreReturn: true);
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(obj7, null, "Range", new object[3]
				{
					instance4,
					obj4,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			obj9 = null;
			_xlApp.Cells[num, 2] = "Daily avg(bal)";
			num++;
			object obj15 = _xlApp.Sheets[1];
			object instance9 = obj15;
			object[] array11 = new object[2];
			object instance10 = (obj4 = obj15);
			object[] obj16 = new object[2]
			{
				num7 = num,
				null
			};
			instance4 = (obj16[1] = 3);
			array2 = obj16;
			obj8 = NewLateBinding.LateGet(instance10, null, "Cells", obj16, null, null, array3 = new bool[2] { true, false });
			if (array3[0])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
			}
			array11[0] = obj8;
			object instance11 = (obj7 = obj15);
			object[] obj17 = new object[2]
			{
				num8 = num,
				null
			};
			obj13 = (obj17[1] = 3);
			array2 = obj17;
			obj8 = NewLateBinding.LateGet(instance11, null, "Cells", obj17, null, null, array3 = new bool[2] { true, false });
			if (array3[0])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
			}
			array11[1] = obj8;
			array4 = array11;
			obj5 = NewLateBinding.LateGet(instance9, null, "Range", array11, null, null, array5 = new bool[2] { true, true });
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(obj4, null, "Cells", new object[3]
				{
					num7,
					instance4,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array5[1])
			{
				NewLateBinding.LateSetComplex(obj7, null, "Cells", new object[3]
				{
					num8,
					obj13,
					array4[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			range = (Range)obj5;
			range.Select();
			obj15 = null;
			_xlApp.ActiveCell.FormulaR1C1 = "=R[-2]C/12";
			object obj18 = _xlApp.Sheets[1];
			object selection2 = _xlApp.Selection;
			array2 = new object[2];
			object[] array12 = array2;
			object instance12 = (obj13 = obj18);
			object[] array13 = new object[2];
			object instance13 = (obj4 = obj18);
			object[] obj19 = new object[2]
			{
				num8 = num,
				null
			};
			obj5 = (obj19[1] = 3);
			array8 = obj19;
			obj11 = NewLateBinding.LateGet(instance13, null, "Cells", obj19, null, null, array9 = new bool[2] { true, false });
			if (array9[0])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array8[0]), typeof(int));
			}
			obj7 = (array13[0] = obj11);
			object instance14 = (obj8 = obj18);
			object[] obj20 = new object[2]
			{
				num7 = num,
				null
			};
			instance2 = (obj20[1] = 2 + count);
			array8 = obj20;
			obj11 = NewLateBinding.LateGet(instance14, null, "Cells", obj20, null, null, array9 = new bool[2] { true, false });
			if (array9[0])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array8[0]), typeof(int));
			}
			instance4 = (array13[1] = obj11);
			array10 = array13;
			obj14 = NewLateBinding.LateGet(instance12, null, "Range", array13, null, null, array3 = new bool[2] { true, true });
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj4, null, "Cells", new object[3]
				{
					num8,
					obj5,
					array10[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array3[1])
			{
				NewLateBinding.LateSetComplex(obj8, null, "Cells", new object[3]
				{
					num7,
					instance2,
					array10[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			array12[0] = obj14;
			array2[1] = XlAutoFillType.xlFillDefault;
			NewLateBinding.LateCall(selection2, null, "AutoFill", array4 = array2, new string[2] { "Destination", "Type" }, null, array5 = new bool[2] { true, false }, IgnoreReturn: true);
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(obj13, null, "Range", new object[3]
				{
					obj7,
					instance4,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			obj18 = null;
			_xlApp.Cells[num, 2] = "Monthly avg(bal)";
			num++;
			object obj21 = _xlApp.Sheets[1];
			object instance15 = obj21;
			object[] array14 = new object[2];
			object instance16 = (instance4 = obj21);
			object[] obj22 = new object[2]
			{
				num7 = num,
				null
			};
			obj7 = (obj22[1] = 3);
			array2 = obj22;
			obj5 = NewLateBinding.LateGet(instance16, null, "Cells", obj22, null, null, array3 = new bool[2] { true, false });
			if (array3[0])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
			}
			array14[0] = obj5;
			object instance17 = (obj13 = obj21);
			object[] obj23 = new object[2]
			{
				num8 = num,
				null
			};
			instance2 = (obj23[1] = 3);
			array2 = obj23;
			obj5 = NewLateBinding.LateGet(instance17, null, "Cells", obj23, null, null, array3 = new bool[2] { true, false });
			if (array3[0])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
			}
			array14[1] = obj5;
			array4 = array14;
			obj8 = NewLateBinding.LateGet(instance15, null, "Range", array14, null, null, array5 = new bool[2] { true, true });
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(instance4, null, "Cells", new object[3]
				{
					num7,
					obj7,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array5[1])
			{
				NewLateBinding.LateSetComplex(obj13, null, "Cells", new object[3]
				{
					num8,
					instance2,
					array4[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			range = (Range)obj8;
			range.Select();
			obj21 = null;
			_xlApp.ActiveCell.FormulaR1C1 = "=R[-1]C*5";
			object obj24 = _xlApp.Sheets[1];
			object selection3 = _xlApp.Selection;
			array2 = new object[2];
			object[] array15 = array2;
			object instance18 = (instance2 = obj24);
			object[] array16 = new object[2];
			object instance19 = (instance4 = obj24);
			object[] obj25 = new object[2]
			{
				num8 = num,
				null
			};
			obj8 = (obj25[1] = 3);
			array8 = obj25;
			obj11 = NewLateBinding.LateGet(instance19, null, "Cells", obj25, null, null, array9 = new bool[2] { true, false });
			if (array9[0])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array8[0]), typeof(int));
			}
			obj13 = (array16[0] = obj11);
			object instance20 = (obj5 = obj24);
			object[] obj26 = new object[2]
			{
				num7 = num,
				null
			};
			obj4 = (obj26[1] = 2 + count);
			array8 = obj26;
			obj11 = NewLateBinding.LateGet(instance20, null, "Cells", obj26, null, null, array9 = new bool[2] { true, false });
			if (array9[0])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array8[0]), typeof(int));
			}
			obj7 = (array16[1] = obj11);
			array10 = array16;
			obj14 = NewLateBinding.LateGet(instance18, null, "Range", array16, null, null, array3 = new bool[2] { true, true });
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(instance4, null, "Cells", new object[3]
				{
					num8,
					obj8,
					array10[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array3[1])
			{
				NewLateBinding.LateSetComplex(obj5, null, "Cells", new object[3]
				{
					num7,
					obj4,
					array10[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			array15[0] = obj14;
			array2[1] = XlAutoFillType.xlFillDefault;
			NewLateBinding.LateCall(selection3, null, "AutoFill", array4 = array2, new string[2] { "Destination", "Type" }, null, array5 = new bool[2] { true, false }, IgnoreReturn: true);
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(instance2, null, "Range", new object[3]
				{
					obj13,
					obj7,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			obj24 = null;
			((_Application)_xlApp).get_Range((object)("B" + Conversions.ToString(num)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
			_xlApp.Cells[num, 2] = "Berat(kg)/month";
			object obj27 = _xlApp.Sheets[1];
			object instance21 = obj27;
			object[] array17 = new object[2];
			object instance22 = (obj7 = obj27);
			object[] array18 = new object[2];
			obj13 = (array18[0] = num2 + 1);
			instance2 = (array18[1] = 3);
			array17[0] = NewLateBinding.LateGet(instance22, null, "Cells", array18, null, null, null);
			object instance23 = (obj4 = obj27);
			object[] obj28 = new object[2]
			{
				num7 = num,
				null
			};
			obj5 = (obj28[1] = count + 2);
			array2 = obj28;
			instance4 = NewLateBinding.LateGet(instance23, null, "Cells", obj28, null, null, array3 = new bool[2] { true, false });
			if (array3[0])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
			}
			array17[1] = instance4;
			array4 = array17;
			obj8 = NewLateBinding.LateGet(instance21, null, "Range", array17, null, null, array5 = new bool[2] { true, true });
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(obj7, null, "Cells", new object[3]
				{
					obj13,
					instance2,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array5[1])
			{
				NewLateBinding.LateSetComplex(obj4, null, "Cells", new object[3]
				{
					num7,
					obj5,
					array4[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			range = (Range)obj8;
			range.Select();
			obj27 = null;
			NewLateBinding.LateSetComplex(_xlApp.Selection, null, "HorizontalAlignment", new object[1] { XlHAlign.xlHAlignRight }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(_xlApp.Selection, null, "NumberFormat", new object[1] { "#,##0" }, null, null, OptimisticSet: false, RValueBase: true);
			object obj29 = _xlApp.Sheets[1];
			object instance24 = obj29;
			object[] array19 = new object[2];
			object instance25 = (obj5 = obj29);
			object[] obj30 = new object[2]
			{
				num7 = num2,
				null
			};
			obj4 = (obj30[1] = 2);
			array2 = obj30;
			instance4 = NewLateBinding.LateGet(instance25, null, "Cells", obj30, null, null, array3 = new bool[2] { true, false });
			if (array3[0])
			{
				num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
			}
			array19[0] = instance4;
			object instance26 = (instance2 = obj29);
			object[] array20 = new object[2];
			obj13 = (array20[0] = num2 + 4);
			obj7 = (array20[1] = count + 2);
			array19[1] = NewLateBinding.LateGet(instance26, null, "Cells", array20, null, null, null);
			array4 = array19;
			obj8 = NewLateBinding.LateGet(instance24, null, "Range", array19, null, null, array5 = new bool[2] { true, true });
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(obj5, null, "Cells", new object[3]
				{
					num7,
					obj4,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array5[1])
			{
				NewLateBinding.LateSetComplex(instance2, null, "Cells", new object[3]
				{
					obj13,
					obj7,
					array4[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			range = (Range)obj8;
			range.Select();
			obj29 = null;
			ExcelModule.formatBorder(_xlApp);
			ProgressBar1.Value = 20;
			num += 3;
			string right = "";
			int num9 = num;
			int j;
			if (Operators.CompareString(strType, "KEMASAN", TextCompare: false) == 0)
			{
				text3 = " SELECT catName,c.itemId,prodName FROM produk a, itemcategory b, items c  WHERE a.catId = b.catId  AND a.prodId = c.itemId  AND c.itemAllowProcess = 0  AND a.prodId IN (  SELECT comId FROM itemcomponents WHERE itemId IN (  SELECT itemId FROM items WHERE stepId = 5))  AND prodName NOT LIKE '%CAM%' ORDER BY catName, prodName ";
				dataTable = Module1.sqlTable(text3, "data", Clone: false);
				int num10 = default(int);
				int num11 = default(int);
				foreach (DataRow row2 in dataTable.Rows)
				{
					if (Operators.ConditionalCompareObjectNotEqual(row2["catName"], right, TextCompare: false))
					{
						right = Conversions.ToString(row2["catName"]);
						num9++;
						num10 = num9;
						_xlApp.Cells[num9, 2] = RuntimeHelpers.GetObjectValue(row2["catName"]);
						_xlApp.Cells[num9, 3] = "Monthly Avg";
						_xlApp.Cells[num9, 4] = "Daily Avg";
						_xlApp.Cells[num9, 5] = "";
						_xlApp.Cells[num9, 6] = "";
						_xlApp.Cells[num9, 7] = "Stok Tersedia";
						_xlApp.Cells[num9, 8] = "";
						num9++;
					}
					_xlApp.Cells[num9, 2] = RuntimeHelpers.GetObjectValue(row2["prodName"]);
					_xlApp.Cells[num9, 4] = Operators.ConcatenateObject(Operators.ConcatenateObject("=", NewLateBinding.LateGet(_xlApp.Cells[num9, 3], null, "Address", new object[2] { false, false }, null, null, null)), "/25");
					_xlApp.Cells[num9, 7] = cStock.getStock(Conversions.ToInteger(row2["itemId"]), Module1.pubBalanceDate, datReport, "Good", 0, Module1.pubGroupId, Module1.pubBranchId, Module1.pubReportUseNewGetStockCode);
					object obj31 = _xlApp.Sheets[1];
					object instance27 = obj31;
					object[] array21 = new object[2];
					object instance28 = (obj7 = obj31);
					object[] obj32 = new object[2]
					{
						num7 = num10,
						null
					};
					obj13 = (obj32[1] = 2);
					array2 = obj32;
					obj8 = NewLateBinding.LateGet(instance28, null, "Cells", obj32, null, null, array3 = new bool[2] { true, false });
					if (array3[0])
					{
						num10 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
					}
					array21[0] = obj8;
					object instance29 = (instance2 = obj31);
					object[] obj33 = new object[2]
					{
						num8 = num9,
						null
					};
					obj4 = (obj33[1] = 8);
					array2 = obj33;
					obj8 = NewLateBinding.LateGet(instance29, null, "Cells", obj33, null, null, array3 = new bool[2] { true, false });
					if (array3[0])
					{
						num9 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
					}
					array21[1] = obj8;
					array4 = array21;
					obj5 = NewLateBinding.LateGet(instance27, null, "Range", array21, null, null, array5 = new bool[2] { true, true });
					if (array5[0])
					{
						NewLateBinding.LateSetComplex(obj7, null, "Cells", new object[3]
						{
							num7,
							obj13,
							array4[0]
						}, null, null, OptimisticSet: true, RValueBase: true);
					}
					if (array5[1])
					{
						NewLateBinding.LateSetComplex(instance2, null, "Cells", new object[3]
						{
							num8,
							obj4,
							array4[1]
						}, null, null, OptimisticSet: true, RValueBase: true);
					}
					range = (Range)obj5;
					range.Select();
					obj31 = null;
					ExcelModule.formatBorder(_xlApp);
					object obj34 = _xlApp.Sheets[1];
					object instance30 = obj34;
					object[] array22 = new object[2];
					object instance31 = (obj4 = obj34);
					object[] array23 = new object[2];
					instance2 = (array23[0] = num10 + 1);
					obj13 = (array23[1] = 3);
					array22[0] = NewLateBinding.LateGet(instance31, null, "Cells", array23, null, null, null);
					object instance32 = (obj7 = obj34);
					object[] obj35 = new object[2]
					{
						num8 = num9,
						null
					};
					obj5 = (obj35[1] = 8);
					array2 = obj35;
					instance4 = NewLateBinding.LateGet(instance32, null, "Cells", obj35, null, null, array3 = new bool[2] { true, false });
					if (array3[0])
					{
						num9 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
					}
					array22[1] = instance4;
					array4 = array22;
					obj8 = NewLateBinding.LateGet(instance30, null, "Range", array22, null, null, array5 = new bool[2] { true, true });
					if (array5[0])
					{
						NewLateBinding.LateSetComplex(obj4, null, "Cells", new object[3]
						{
							instance2,
							obj13,
							array4[0]
						}, null, null, OptimisticSet: true, RValueBase: true);
					}
					if (array5[1])
					{
						NewLateBinding.LateSetComplex(obj7, null, "Cells", new object[3]
						{
							num8,
							obj5,
							array4[1]
						}, null, null, OptimisticSet: true, RValueBase: true);
					}
					range = (Range)obj8;
					range.Select();
					obj34 = null;
					NewLateBinding.LateSetComplex(_xlApp.Selection, null, "HorizontalAlignment", new object[1] { XlHAlign.xlHAlignRight }, null, null, OptimisticSet: false, RValueBase: true);
					NewLateBinding.LateSetComplex(_xlApp.Selection, null, "NumberFormat", new object[1] { "#,##0" }, null, null, OptimisticSet: false, RValueBase: true);
					num11 = num9;
					num9++;
				}
				int num12 = count + 2;
				for (int i = 3; i <= num12; i++)
				{
					string text4 = ExcelModule.ReadCell((Range)_xlApp.Cells[num2, i]);
					text3 = " SELECT proId,proMainQty FROM processes a, items b WHERE a.itemId = b.itemId  AND itemName = '" + text4 + "' ORDER BY proDate DESC LIMIT 1 ";
					dataTable = Module1.sqlTable(text3, "data", Clone: false);
					if (dataTable.Rows.Count <= 0)
					{
						continue;
					}
					double num13 = Conversions.ToDouble(dataTable.Rows[0]["proid"]);
					double num14 = Conversions.ToDouble(dataTable.Rows[0]["proMainQty"]);
					text3 = " SELECT * FROM processcomponents a, items b WHERE a.itemId = b.itemId  AND proId = " + Conversions.ToString(num13) + " AND b.itemId IN (SELECT itemId FROM items  WHERE itemName not like 'CAM%')  ORDER BY itemName ";
					dataTable = Module1.sqlTable(text3, "data", Clone: false);
					foreach (DataRow row3 in dataTable.Rows)
					{
						text4 = Conversions.ToString(row3["itemName"]);
						int num15 = num;
						int num16 = num11;
						for (j = num15; j <= num16; j++)
						{
							if (Operators.CompareString(Strings.UCase(ExcelModule.ReadCell((Range)_xlApp.Cells[j, 2])), Strings.UCase(text4), TextCompare: false) == 0)
							{
								string text5 = Conversions.ToString(NewLateBinding.LateGet(_xlApp.Cells[j, 3], null, "Formula", new object[0], null, null, null));
								if (Operators.CompareString(text5, "", TextCompare: false) == 0)
								{
									text5 = "=";
								}
								((_Application)_xlApp).get_Range((object)("C" + Conversions.ToString(j)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
								text5 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(text5 + "+(", NewLateBinding.LateGet(_xlApp.Cells[num6 + 2, i], null, "Address", new object[2] { false, false }, null, null, null)), "*"), Module1.unformatNumber(Conversions.ToString(Operators.DivideObject(row3["comMainqty"], num14)))), ")"));
								_xlApp.Cells[j, 3] = text5;
								break;
							}
						}
					}
				}
				object obj36 = _xlApp.Sheets[1];
				object instance33 = obj36;
				object[] array24 = new object[2];
				object instance34 = (obj5 = obj36);
				object[] array25 = new object[2];
				obj7 = (array25[0] = num6 - 2);
				obj13 = (array25[1] = 3);
				array24[0] = NewLateBinding.LateGet(instance34, null, "Cells", array25, null, null, null);
				object instance35 = (instance2 = obj36);
				object[] array26 = new object[2];
				obj4 = (array26[0] = num6 - 2);
				array26[1] = (num8 = num5);
				array2 = array26;
				instance4 = NewLateBinding.LateGet(instance35, null, "Cells", array26, null, null, array3 = new bool[2] { false, true });
				if (array3[1])
				{
					num5 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
				}
				array24[1] = instance4;
				array4 = array24;
				obj8 = NewLateBinding.LateGet(instance33, null, "Range", array24, null, null, array5 = new bool[2] { true, true });
				if (array5[0])
				{
					NewLateBinding.LateSetComplex(obj5, null, "Cells", new object[3]
					{
						obj7,
						obj13,
						array4[0]
					}, null, null, OptimisticSet: true, RValueBase: true);
				}
				if (array5[1])
				{
					NewLateBinding.LateSetComplex(instance2, null, "Cells", new object[3]
					{
						obj4,
						num8,
						array4[1]
					}, null, null, OptimisticSet: true, RValueBase: true);
				}
				range = (Range)obj8;
				range.Select();
				obj36 = null;
				NewLateBinding.LateCall(_xlApp.Selection, null, "ClearContents", new object[0], null, null, null, IgnoreReturn: true);
				_xlApp.Cells.Select();
				NewLateBinding.LateCall(NewLateBinding.LateGet(_xlApp.Selection, null, "Columns", new object[0], null, null, null), null, "AutoFit", new object[0], null, null, null, IgnoreReturn: true);
				NewLateBinding.LateCall(_xlApp.Cells[1, 1], null, "Select", new object[0], null, null, null, IgnoreReturn: true);
				DisplayOrSave(datReport, strType, SaveToFile);
				return;
			}
			text3 = " SELECT itemName FROM items i  WHERE itemAllowProcess = 1  AND itemAllowComponent=1  AND itemAllowPurchase = 0  AND itemActive = 1  AND stepId = 4  AND itemName LIKE 'CAM%'  ORDER BY 1 ";
			dataTable = Module1.sqlTable(text3, "data", Clone: false);
			num += 3;
			j = 0;
			foreach (DataRow row4 in dataTable.Rows)
			{
				_xlApp.Cells[num + j, 2] = RuntimeHelpers.GetObjectValue(row4["itemName"]);
				j++;
			}
			int num17 = num;
			int num18 = num17 + dataTable.Rows.Count - 1;
			_xlApp.Cells[num17 - 1, 2] = "Bahan";
			int num19 = count + 2;
			for (int i = 3; i <= num19; i++)
			{
				string text4 = ExcelModule.ReadCell((Range)_xlApp.Cells[num2, i]);
				text3 = " SELECT proId FROM processes a, items b WHERE a.itemId = b.itemId  AND itemName = '" + text4 + "' ORDER BY proDate DESC LIMIT 1 ";
				dataTable = Module1.sqlTable(text3, "data", Clone: false);
				if (dataTable.Rows.Count <= 0)
				{
					continue;
				}
				double num13 = Conversions.ToDouble(dataTable.Rows[0]["proId"]);
				text3 = " SELECT * FROM processcomponents a, items b WHERE a.itemId = b.itemId  AND proId = " + Conversions.ToString(num13) + " AND b.itemId IN (SELECT itemId FROM items  WHERE itemName like 'CAM%')  ORDER BY itemName ";
				dataTable = Module1.sqlTable(text3, "data", Clone: false);
				if (dataTable.Rows.Count <= 0)
				{
					continue;
				}
				string value = Conversions.ToString(dataTable.Rows[0]["itemName"]);
				int num20 = num17;
				int num21 = num18;
				for (j = num20; j <= num21; j++)
				{
					if (Operators.CompareString(Strings.UCase(ExcelModule.ReadCell((Range)_xlApp.Cells[j, 2])), Strings.UCase(value), TextCompare: false) == 0)
					{
						string text5 = Conversions.ToString(NewLateBinding.LateGet(_xlApp.Cells[j, 3], null, "Formula", new object[0], null, null, null));
						if (Operators.CompareString(text5, "", TextCompare: false) == 0)
						{
							text5 = "=";
						}
						((_Application)_xlApp).get_Range((object)("C" + Conversions.ToString(j)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
						text5 = Conversions.ToString(Operators.ConcatenateObject(text5 + "+", NewLateBinding.LateGet(_xlApp.Cells[num6 + 3, i], null, "Address", new object[2] { false, false }, null, null, null)));
						_xlApp.Cells[j, 3] = text5;
						break;
					}
				}
			}
			ProgressBar1.Value = 30;
			count = 0;
			int num22 = num18 + 11;
			int num23 = num17;
			int num24 = num18;
			for (j = num23; j <= num24; j++)
			{
				string value = ExcelModule.ReadCell((Range)_xlApp.Cells[j, 2]);
				text3 = " SELECT proId FROM processes a, items b WHERE a.itemId = b.itemId  AND itemName = '" + value + "' ORDER BY proDate DESC LIMIT 1 ";
				dataTable = Module1.sqlTable(text3, "data", Clone: false);
				if (dataTable.Rows.Count <= 0)
				{
					continue;
				}
				double num13 = Conversions.ToDouble(dataTable.Rows[0]["proId"]);
				double num25 = 0.0;
				text3 = " SELECT * FROM processcomponents a, items b WHERE a.itemId = b.itemId  AND proId = " + Conversions.ToString(num13) + " ORDER BY itemName ";
				dataTable = Module1.sqlTable(text3, "data", Clone: false);
				num25 = 0.0;
				foreach (DataRow row5 in dataTable.Rows)
				{
					num25 = Conversions.ToDouble(Operators.AddObject(num25, row5["comMainQty"]));
				}
				foreach (DataRow row6 in dataTable.Rows)
				{
					double num26 = Conversions.ToDouble(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[2]
					{
						Operators.MultiplyObject(Operators.DivideObject(row6["comMainqty"], num25), 100),
						0
					}, null, null, null));
					bool flag = false;
					int num27 = 4;
					string text6;
					do
					{
						text6 = ExcelModule.ReadCell((Range)_xlApp.Cells[num17 - 1, num27]);
						if (Operators.ConditionalCompareObjectEqual(row6["itemName"], text6, TextCompare: false))
						{
							flag = true;
						}
						num27++;
					}
					while (!unchecked(Operators.CompareString(text6, "", TextCompare: false) == 0 || flag));
					if (!flag)
					{
						_xlApp.Cells[num17 - 1, num27 - 1] = RuntimeHelpers.GetObjectValue(row6["itemName"]);
						count++;
						bool flag2 = false;
						int num28 = num17;
						int num29 = num18;
						for (num9 = num28; num9 <= num29; num9++)
						{
							if (Operators.ConditionalCompareObjectEqual(ExcelModule.ReadCell((Range)_xlApp.Cells[num9, 2]), row6["itemName"], TextCompare: false))
							{
								flag2 = true;
							}
						}
						bool flag3 = false;
						text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(" SELECT * FROM processes  WHERE itemId IN (SELECT itemId FROM items  WHERE itemName = '", row6["itemName"]), "') ORDER BY 1 DESC LIMIT 1"));
						DataTable dataTable2 = Module1.sqlTable(text3, "data", Clone: false);
						if (dataTable2.Rows.Count > 0)
						{
							flag3 = true;
						}
						if (unchecked(!flag2 && flag3))
						{
							_xlApp.Cells[num22, 2] = RuntimeHelpers.GetObjectValue(row6["itemName"]);
							num22++;
						}
					}
					string text5 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("=", NewLateBinding.LateGet(_xlApp.Cells[j, 3], null, "Address", new object[2] { false, false }, null, null, null)), "*"), num26), "%"));
					_xlApp.Cells[j, num27 - 1] = text5;
					int num30 = num17;
					int num31 = num18;
					for (num9 = num30; num9 <= num31; num9++)
					{
						if (Operators.ConditionalCompareObjectEqual(row6["itemName"], ExcelModule.ReadCell((Range)_xlApp.Cells[num9, 2]), TextCompare: false))
						{
							text5 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateGet(_xlApp.Cells[num9, 3], null, "Formula", new object[0], null, null, null), "+"), NewLateBinding.LateGet(_xlApp.Cells[j, num27 - 1], null, "Address", new object[2] { false, false }, null, null, null)));
							_xlApp.Cells[num9, 3] = text5;
						}
					}
				}
			}
			int intToCol = count + 3;
			ProgressBar1.Value = 50;
			_xlApp.Cells[num18 + 2, 2] = "TOTAL";
			_xlApp.Cells[num18 + 3, 2] = "Buffer Stok 50%";
			_xlApp.Cells[num18 + 4, 2] = "Buffer Stok 75%";
			_xlApp.Cells[num18 + 6, 2] = "Stok tersedia";
			_xlApp.Cells[num18 + 8, 2] = "+/- 75%";
			num = num18 + 2;
			object obj37 = _xlApp.Sheets[1];
			object instance36 = obj37;
			object[] array27 = new object[2];
			object instance37 = (obj4 = obj37);
			object[] obj38 = new object[2]
			{
				num8 = num,
				null
			};
			instance2 = (obj38[1] = 4);
			array2 = obj38;
			obj8 = NewLateBinding.LateGet(instance37, null, "Cells", obj38, null, null, array3 = new bool[2] { true, false });
			if (array3[0])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
			}
			array27[0] = obj8;
			object instance38 = (obj13 = obj37);
			object[] obj39 = new object[2]
			{
				num7 = num,
				null
			};
			obj7 = (obj39[1] = 4);
			array2 = obj39;
			obj8 = NewLateBinding.LateGet(instance38, null, "Cells", obj39, null, null, array3 = new bool[2] { true, false });
			if (array3[0])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
			}
			array27[1] = obj8;
			array4 = array27;
			obj5 = NewLateBinding.LateGet(instance36, null, "Range", array27, null, null, array5 = new bool[2] { true, true });
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(obj4, null, "Cells", new object[3]
				{
					num8,
					instance2,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array5[1])
			{
				NewLateBinding.LateSetComplex(obj13, null, "Cells", new object[3]
				{
					num7,
					obj7,
					array4[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			range = (Range)obj5;
			range.Select();
			obj37 = null;
			_xlApp.ActiveCell.FormulaR1C1 = "=SUM(R[-" + Conversions.ToString(num18 - num17 + 2) + "]C:R[-2]C)";
			object obj40 = _xlApp.Sheets[1];
			object selection4 = _xlApp.Selection;
			array2 = new object[2];
			object[] array28 = array2;
			object instance39 = (obj7 = obj40);
			object[] array29 = new object[2];
			object instance40 = (obj4 = obj40);
			object[] obj41 = new object[2]
			{
				num7 = num,
				null
			};
			obj5 = (obj41[1] = 4);
			array8 = obj41;
			obj11 = NewLateBinding.LateGet(instance40, null, "Cells", obj41, null, null, array9 = new bool[2] { true, false });
			if (array9[0])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array8[0]), typeof(int));
			}
			obj13 = (array29[0] = obj11);
			object instance41 = (obj8 = obj40);
			object[] obj42 = new object[2]
			{
				num8 = num,
				null
			};
			instance4 = (obj42[1] = 3 + count);
			array8 = obj42;
			obj11 = NewLateBinding.LateGet(instance41, null, "Cells", obj42, null, null, array9 = new bool[2] { true, false });
			if (array9[0])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array8[0]), typeof(int));
			}
			instance2 = (array29[1] = obj11);
			array10 = array29;
			obj14 = NewLateBinding.LateGet(instance39, null, "Range", array29, null, null, array3 = new bool[2] { true, true });
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj4, null, "Cells", new object[3]
				{
					num7,
					obj5,
					array10[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array3[1])
			{
				NewLateBinding.LateSetComplex(obj8, null, "Cells", new object[3]
				{
					num8,
					instance4,
					array10[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			array28[0] = obj14;
			array2[1] = XlAutoFillType.xlFillDefault;
			NewLateBinding.LateCall(selection4, null, "AutoFill", array4 = array2, new string[2] { "Destination", "Type" }, null, array5 = new bool[2] { true, false }, IgnoreReturn: true);
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(obj7, null, "Range", new object[3]
				{
					obj13,
					instance2,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			obj40 = null;
			object obj43 = _xlApp.Sheets[1];
			object instance42 = obj43;
			object[] array30 = new object[2];
			object instance43 = (instance2 = obj43);
			object[] array31 = new object[2];
			obj13 = (array31[0] = num18 + 3);
			obj7 = (array31[1] = 4);
			array30[0] = NewLateBinding.LateGet(instance43, null, "Cells", array31, null, null, null);
			object instance44 = (instance4 = obj43);
			object[] array32 = new object[2];
			obj8 = (array32[0] = num18 + 3);
			obj5 = (array32[1] = 4);
			array30[1] = NewLateBinding.LateGet(instance44, null, "Cells", array32, null, null, null);
			array4 = array30;
			obj4 = NewLateBinding.LateGet(instance42, null, "Range", array30, null, null, array5 = new bool[2] { true, true });
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(instance2, null, "Cells", new object[3]
				{
					obj13,
					obj7,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array5[1])
			{
				NewLateBinding.LateSetComplex(instance4, null, "Cells", new object[3]
				{
					obj8,
					obj5,
					array4[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			range = (Range)obj4;
			range.Select();
			obj43 = null;
			_xlApp.ActiveCell.FormulaR1C1 = "=0.5*R[-1]C";
			object obj44 = _xlApp.Sheets[1];
			object selection5 = _xlApp.Selection;
			array2 = new object[2];
			object[] array33 = array2;
			object instance45 = (obj5 = obj44);
			object[] array34 = new object[2];
			object instance46 = (obj7 = obj44);
			object[] array35 = new object[2];
			obj13 = (array35[0] = num18 + 3);
			instance2 = (array35[1] = 4);
			obj8 = (array34[0] = NewLateBinding.LateGet(instance46, null, "Cells", array35, null, null, null));
			object instance47 = (obj4 = obj44);
			object[] array36 = new object[2];
			obj14 = (array36[0] = num18 + 3);
			obj11 = (array36[1] = count + 3);
			instance4 = (array34[1] = NewLateBinding.LateGet(instance47, null, "Cells", array36, null, null, null));
			array10 = array34;
			object obj45 = NewLateBinding.LateGet(instance45, null, "Range", array34, null, null, array3 = new bool[2] { true, true });
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj7, null, "Cells", new object[3]
				{
					obj13,
					instance2,
					array10[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array3[1])
			{
				NewLateBinding.LateSetComplex(obj4, null, "Cells", new object[3]
				{
					obj14,
					obj11,
					array10[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			array33[0] = obj45;
			array2[1] = XlAutoFillType.xlFillDefault;
			NewLateBinding.LateCall(selection5, null, "AutoFill", array4 = array2, new string[2] { "Destination", "Type" }, null, array5 = new bool[2] { true, false }, IgnoreReturn: true);
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(obj5, null, "Range", new object[3]
				{
					obj8,
					instance4,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			obj44 = null;
			object obj46 = _xlApp.Sheets[1];
			object instance48 = obj46;
			object[] array37 = new object[2];
			object instance49 = (instance4 = obj46);
			object[] array38 = new object[2];
			obj8 = (array38[0] = num18 + 4);
			obj5 = (array38[1] = 4);
			array37[0] = NewLateBinding.LateGet(instance49, null, "Cells", array38, null, null, null);
			object instance50 = (obj11 = obj46);
			object[] array39 = new object[2];
			obj14 = (array39[0] = num18 + 4);
			obj4 = (array39[1] = 4);
			array37[1] = NewLateBinding.LateGet(instance50, null, "Cells", array39, null, null, null);
			array4 = array37;
			instance2 = NewLateBinding.LateGet(instance48, null, "Range", array37, null, null, array5 = new bool[2] { true, true });
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(instance4, null, "Cells", new object[3]
				{
					obj8,
					obj5,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array5[1])
			{
				NewLateBinding.LateSetComplex(obj11, null, "Cells", new object[3]
				{
					obj14,
					obj4,
					array4[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			range = (Range)instance2;
			range.Select();
			obj46 = null;
			_xlApp.ActiveCell.FormulaR1C1 = "=0.75*R[-2]C";
			object obj47 = _xlApp.Sheets[1];
			object selection6 = _xlApp.Selection;
			array2 = new object[2];
			object[] array40 = array2;
			object instance51 = (obj4 = obj47);
			object[] array41 = new object[2];
			object instance52 = (obj5 = obj47);
			object[] array42 = new object[2];
			obj8 = (array42[0] = num18 + 4);
			instance4 = (array42[1] = 4);
			obj14 = (array41[0] = NewLateBinding.LateGet(instance52, null, "Cells", array42, null, null, null));
			object instance53 = (instance2 = obj47);
			object[] array43 = new object[2];
			obj13 = (array43[0] = num18 + 4);
			obj7 = (array43[1] = count + 3);
			obj11 = (array41[1] = NewLateBinding.LateGet(instance53, null, "Cells", array43, null, null, null));
			array10 = array41;
			obj45 = NewLateBinding.LateGet(instance51, null, "Range", array41, null, null, array3 = new bool[2] { true, true });
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj5, null, "Cells", new object[3]
				{
					obj8,
					instance4,
					array10[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array3[1])
			{
				NewLateBinding.LateSetComplex(instance2, null, "Cells", new object[3]
				{
					obj13,
					obj7,
					array10[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			array40[0] = obj45;
			array2[1] = XlAutoFillType.xlFillDefault;
			NewLateBinding.LateCall(selection6, null, "AutoFill", array4 = array2, new string[2] { "Destination", "Type" }, null, array5 = new bool[2] { true, false }, IgnoreReturn: true);
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(obj4, null, "Range", new object[3]
				{
					obj14,
					obj11,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			obj47 = null;
			int num32 = count + 3;
			for (j = 4; j <= num32; j++)
			{
				string text4 = ExcelModule.ReadCell((Range)_xlApp.Cells[num17 - 1, j]);
				double num33 = ((!((Operators.CompareString(Strings.UCase(text4), "BUNGA GAMBIR", TextCompare: false) == 0) | (Operators.CompareString(Strings.UCase(text4), "BUNGA MELATI", TextCompare: false) == 0))) ? cStock.getStock((int)Math.Round(cItem.GetItemId(text4)), Module1.pubBalanceDate, datReport, "Good", 0, Module1.pubGroupId, Module1.pubBranchId, Module1.pubReportUseNewGetStockCode) : 0.0);
				_xlApp.Cells[num18 + 6, j] = num33;
			}
			object obj48 = _xlApp.Sheets[1];
			object instance54 = obj48;
			object[] array44 = new object[2];
			object instance55 = (obj11 = obj48);
			object[] array45 = new object[2];
			obj14 = (array45[0] = num18 + 8);
			obj4 = (array45[1] = 4);
			array44[0] = NewLateBinding.LateGet(instance55, null, "Cells", array45, null, null, null);
			object instance56 = (obj7 = obj48);
			object[] array46 = new object[2];
			obj13 = (array46[0] = num18 + 8);
			instance2 = (array46[1] = 4);
			array44[1] = NewLateBinding.LateGet(instance56, null, "Cells", array46, null, null, null);
			array4 = array44;
			instance4 = NewLateBinding.LateGet(instance54, null, "Range", array44, null, null, array5 = new bool[2] { true, true });
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(obj11, null, "Cells", new object[3]
				{
					obj14,
					obj4,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array5[1])
			{
				NewLateBinding.LateSetComplex(obj7, null, "Cells", new object[3]
				{
					obj13,
					instance2,
					array4[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			range = (Range)instance4;
			range.Select();
			obj48 = null;
			_xlApp.ActiveCell.FormulaR1C1 = "=R[-2]C-R[-4]C";
			object obj49 = _xlApp.Sheets[1];
			object selection7 = _xlApp.Selection;
			array2 = new object[2];
			object[] array47 = array2;
			object instance57 = (instance2 = obj49);
			object[] array48 = new object[2];
			object instance58 = (obj4 = obj49);
			object[] array49 = new object[2];
			obj14 = (array49[0] = num18 + 8);
			obj11 = (array49[1] = 4);
			obj13 = (array48[0] = NewLateBinding.LateGet(instance58, null, "Cells", array49, null, null, null));
			object instance59 = (instance4 = obj49);
			object[] array50 = new object[2];
			obj8 = (array50[0] = num18 + 8);
			obj5 = (array50[1] = count + 3);
			obj7 = (array48[1] = NewLateBinding.LateGet(instance59, null, "Cells", array50, null, null, null));
			array10 = array48;
			obj45 = NewLateBinding.LateGet(instance57, null, "Range", array48, null, null, array3 = new bool[2] { true, true });
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj4, null, "Cells", new object[3]
				{
					obj14,
					obj11,
					array10[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array3[1])
			{
				NewLateBinding.LateSetComplex(instance4, null, "Cells", new object[3]
				{
					obj8,
					obj5,
					array10[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			array47[0] = obj45;
			array2[1] = XlAutoFillType.xlFillDefault;
			NewLateBinding.LateCall(selection7, null, "AutoFill", array4 = array2, new string[2] { "Destination", "Type" }, null, array5 = new bool[2] { true, false }, IgnoreReturn: true);
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(instance2, null, "Range", new object[3]
				{
					obj13,
					obj7,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			obj49 = null;
			object obj50 = _xlApp.Sheets[1];
			object instance60 = obj50;
			object[] array51 = new object[2];
			object instance61 = (obj7 = obj50);
			object[] array52 = new object[2];
			obj13 = (array52[0] = num17 - 1);
			instance2 = (array52[1] = 2);
			array51[0] = NewLateBinding.LateGet(instance61, null, "Cells", array52, null, null, null);
			object instance62 = (obj5 = obj50);
			object[] array53 = new object[2];
			obj8 = (array53[0] = num18 + 8);
			instance4 = (array53[1] = count + 3);
			array51[1] = NewLateBinding.LateGet(instance62, null, "Cells", array53, null, null, null);
			array4 = array51;
			obj11 = NewLateBinding.LateGet(instance60, null, "Range", array51, null, null, array5 = new bool[2] { true, true });
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(obj7, null, "Cells", new object[3]
				{
					obj13,
					instance2,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array5[1])
			{
				NewLateBinding.LateSetComplex(obj5, null, "Cells", new object[3]
				{
					obj8,
					instance4,
					array4[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			range = (Range)obj11;
			range.Select();
			obj50 = null;
			ExcelModule.formatBorder(_xlApp);
			object obj51 = _xlApp.Sheets[1];
			object instance63 = obj51;
			object[] array54 = new object[2];
			object instance64 = (instance4 = obj51);
			object[] obj52 = new object[2]
			{
				num8 = num17,
				null
			};
			obj8 = (obj52[1] = 4);
			array2 = obj52;
			obj11 = NewLateBinding.LateGet(instance64, null, "Cells", obj52, null, null, array3 = new bool[2] { true, false });
			if (array3[0])
			{
				num17 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
			}
			array54[0] = obj11;
			object instance65 = (obj5 = obj51);
			object[] array55 = new object[2];
			instance2 = (array55[0] = num18 + 8);
			obj13 = (array55[1] = count + 3);
			array54[1] = NewLateBinding.LateGet(instance65, null, "Cells", array55, null, null, null);
			array4 = array54;
			obj7 = NewLateBinding.LateGet(instance63, null, "Range", array54, null, null, array5 = new bool[2] { true, true });
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(instance4, null, "Cells", new object[3]
				{
					num8,
					obj8,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array5[1])
			{
				NewLateBinding.LateSetComplex(obj5, null, "Cells", new object[3]
				{
					instance2,
					obj13,
					array4[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			range = (Range)obj7;
			range.Select();
			obj51 = null;
			NewLateBinding.LateSetComplex(_xlApp.Selection, null, "HorizontalAlignment", new object[1] { XlHAlign.xlHAlignRight }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(_xlApp.Selection, null, "NumberFormat", new object[1] { "#,##0" }, null, null, OptimisticSet: false, RValueBase: true);
			int num34 = num18 + 11;
			int num35 = num22 - 1;
			num9 = 0;
			int num36 = count + 3;
			for (j = 4; j <= num36; j++)
			{
				bool flag = false;
				int num37 = num17;
				int num38 = num18;
				for (int i = num37; i <= num38; i++)
				{
					if (Operators.CompareString(ExcelModule.ReadCell((Range)_xlApp.Cells[i, 2]), ExcelModule.ReadCell((Range)_xlApp.Cells[num17 - 1, j]), TextCompare: false) == 0)
					{
						flag = true;
					}
				}
				bool flag3 = false;
				text3 = " SELECT * FROM processes  WHERE itemId IN (SELECT itemId FROM items  WHERE itemName = '" + ExcelModule.ReadCell((Range)_xlApp.Cells[num17 - 1, j]) + "') ORDER BY 1 DESC LIMIT 1";
				DataTable dataTable2 = Module1.sqlTable(text3, "data", Clone: false);
				if (dataTable2.Rows.Count > 0)
				{
					flag3 = true;
				}
				if (unchecked(!flag && flag3))
				{
					string text5 = Conversions.ToString(Operators.ConcatenateObject("=", NewLateBinding.LateGet(_xlApp.Cells[num, j], null, "Address", new object[2] { false, false }, null, null, null)));
					_xlApp.Cells[num34 + num9, 3] = text5;
					num9++;
				}
			}
			ProgressBar1.Value = 60;
			_xlApp.Cells[num34 - 1, 2] = "Bahan";
			int num39 = num35 + 4;
			int num40 = 0;
			count = 0;
			int num41 = num34;
			int num42 = num35;
			int num44 = default(int);
			for (j = num41; j <= num42; j++)
			{
				string value = ExcelModule.ReadCell((Range)_xlApp.Cells[j, 2]);
				text3 = " SELECT proId FROM processes a, items b WHERE a.itemId = b.itemId  AND itemName = '" + value + "' ORDER BY proDate DESC LIMIT 1 ";
				dataTable = Module1.sqlTable(text3, "data", Clone: false);
				double num13 = Conversions.ToDouble(dataTable.Rows[0]["proId"]);
				text3 = " SELECT * FROM processcomponents a, items b WHERE a.itemId = b.itemId  AND proId = " + Conversions.ToString(num13) + " AND b.itemId NOT IN (SELECT itemId FROM items  WHERE itemName like '%Bunga%'  OR itemName like 'Rafia'  OR itemName = 'EM'  OR itemName = 'EJ') ORDER BY itemName ";
				dataTable = Module1.sqlTable(text3, "data", Clone: false);
				double num25 = 0.0;
				foreach (DataRow row7 in dataTable.Rows)
				{
					num25 = Conversions.ToDouble(Operators.AddObject(num25, row7["comMainQty"]));
				}
				_xlApp.Cells[j, 1] = num25;
				foreach (DataRow row8 in dataTable.Rows)
				{
					double num26 = Conversions.ToDouble(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[2]
					{
						Operators.MultiplyObject(Operators.DivideObject(row8["comMainqty"], num25), 100),
						0
					}, null, null, null));
					bool flag = false;
					int num27 = 4;
					string text6;
					do
					{
						text6 = ExcelModule.ReadCell((Range)_xlApp.Cells[num34 - 1, num27]);
						if (Operators.ConditionalCompareObjectEqual(row8["itemName"], text6, TextCompare: false))
						{
							flag = true;
						}
						num27++;
					}
					while (!unchecked(Operators.CompareString(text6, "", TextCompare: false) == 0 || flag));
					string text5;
					if (!flag)
					{
						_xlApp.Cells[num34 - 1, num27 - 1] = RuntimeHelpers.GetObjectValue(row8["itemName"]);
						count++;
						text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" SELECT proId FROM processes a, items b WHERE a.itemId = b.itemId  AND itemName = '", row8["itemName"]), "'"), " ORDER BY proDate DESC LIMIT 1 "));
						DataTable dataTable2 = Module1.sqlTable(text3, "data", Clone: false);
						if (dataTable2.Rows.Count > 0)
						{
							num13 = Conversions.ToDouble(dataTable2.Rows[0]["proid"]);
							text3 = " SELECT * FROM processcomponents a, items b WHERE a.itemId = b.itemId  AND proId = " + Conversions.ToString(num13) + " AND b.itemId IN (SELECT itemId FROM items  WHERE itemName like '%Bunga%'  OR itemName like 'EM'  OR itemName like 'EJ') ORDER BY itemName ";
							dataTable2 = Module1.sqlTable(text3, "data", Clone: false);
							if (dataTable2.Rows.Count > 0)
							{
								bool flag2 = false;
								if (num40 > 0)
								{
									int num43 = num39;
									int num45 = num44;
									for (num9 = num43; num9 <= num45; num9++)
									{
										if (Operators.ConditionalCompareObjectEqual(ExcelModule.ReadCell((Range)_xlApp.Cells[2, num9]), row8["itemName"], TextCompare: false))
										{
											flag2 = true;
										}
									}
								}
								if (!flag2)
								{
									_xlApp.Cells[num39 + num40, 2] = RuntimeHelpers.GetObjectValue(row8["itemName"]);
									text5 = Conversions.ToString(Operators.ConcatenateObject("=", NewLateBinding.LateGet(_xlApp.Cells[num39 - 2, num27 - 1], null, "Address", new object[2] { false, false }, null, null, null)));
									_xlApp.Cells[num39 + num40, 3] = text5;
									num40++;
								}
							}
						}
					}
					text5 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("=", NewLateBinding.LateGet(_xlApp.Cells[j, 3], null, "Address", new object[2] { false, false }, null, null, null)), "*"), num26), "%"));
					_xlApp.Cells[j, num27 - 1] = text5;
				}
			}
			int num46 = 3 + count;
			num = num35 + 2;
			int num47 = num35 + 2;
			ProgressBar1.Value = 70;
			num44 = num39 + num40 - 1;
			int num48 = num39;
			int num49 = num44;
			for (j = num48; j <= num49; j++)
			{
				string value = ExcelModule.ReadCell((Range)_xlApp.Cells[j, 2]);
				text3 = " SELECT proId FROM processes a, items b WHERE a.itemId = b.itemId  AND itemName = '" + value + "' ORDER BY proDate DESC LIMIT 1 ";
				dataTable = Module1.sqlTable(text3, "data", Clone: false);
				double num13 = Conversions.ToDouble(dataTable.Rows[0]["proId"]);
				text3 = " SELECT * FROM processcomponents a, items b WHERE a.itemId = b.itemId  AND proId = " + Conversions.ToString(num13) + " AND b.itemId NOT IN (SELECT itemId FROM items  WHERE itemName like '%Bunga%'  OR itemName like 'Rafia'  OR itemName = 'EM'  OR itemName = 'EJ' ) ORDER BY itemName ";
				dataTable = Module1.sqlTable(text3, "data", Clone: false);
				double num25 = 0.0;
				foreach (DataRow row9 in dataTable.Rows)
				{
					num25 = Conversions.ToDouble(Operators.AddObject(num25, row9["comMainqty"]));
				}
				_xlApp.Cells[j, 1] = num25;
				foreach (DataRow row10 in dataTable.Rows)
				{
					double num26 = Conversions.ToDouble(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[2]
					{
						Operators.MultiplyObject(Operators.DivideObject(row10["comMainQty"], num25), 100),
						0
					}, null, null, null));
					bool flag = false;
					int num27 = 4;
					string text6;
					do
					{
						text6 = ExcelModule.ReadCell((Range)_xlApp.Cells[num34 - 1, num27]);
						if (Operators.ConditionalCompareObjectEqual(row10["itemName"], text6, TextCompare: false))
						{
							flag = true;
						}
						num27++;
					}
					while (!unchecked(Operators.CompareString(text6, "", TextCompare: false) == 0 || flag));
					string text5 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("=", NewLateBinding.LateGet(_xlApp.Cells[j, 3], null, "Address", new object[2] { false, false }, null, null, null)), "*"), num26), "%"));
					_xlApp.Cells[j, num27 - 1] = text5;
				}
			}
			ProgressBar1.Value = 75;
			int num50 = count + 3;
			int num51 = num50 + 1;
			int num52 = num34;
			int num53 = num44;
			for (j = num52; j <= num53; j++)
			{
				string text4 = ExcelModule.ReadCell((Range)_xlApp.Cells[j, 2]);
				if (Operators.CompareString(text4, "", TextCompare: false) == 0)
				{
					continue;
				}
				text3 = " SELECT proId FROM processes a, items b WHERE a.itemId = b.itemId  AND itemName = '" + text4 + "' ORDER BY proDate DESC LIMIT 1 ";
				dataTable = Module1.sqlTable(text3, "data", Clone: false);
				double num13 = Conversions.ToDouble(dataTable.Rows[0]["proid"]);
				text3 = " SELECT * FROM processcomponents a, items b WHERE a.itemId = b.itemId  AND proId = " + Conversions.ToString(num13) + " AND b.itemId IN (SELECT itemId FROM items  WHERE itemName like '%Bunga%'  OR itemName = 'EM'  OR itemName = 'EJ' ) ORDER BY itemName ";
				dataTable = Module1.sqlTable(text3, "data", Clone: false);
				double num25 = Conversions.ToDouble(ExcelModule.ReadCell((Range)_xlApp.Cells[j, 1]));
				_xlApp.Cells[j, 1] = "";
				foreach (DataRow row11 in dataTable.Rows)
				{
					DataRow dataRow12;
					object obj53 = NewLateBinding.LateGet(null, typeof(Strings), "UCase", array4 = new object[1] { (dataRow12 = row11)["itemName"] }, null, null, array5 = new bool[1] { true });
					if (array5[0])
					{
						dataRow12["itemName"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array4[0]));
					}
					double num54 = ((Strings.InStr(Conversions.ToString(obj53), "BUNGA") <= 0) ? Conversions.ToDouble(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[2]
					{
						Operators.DivideObject(Operators.DivideObject(row11["comMainQty"], num25), 10),
						2
					}, null, null, null)) : ((!Operators.ConditionalCompareObjectEqual(row11["comMainQty"], 0, TextCompare: false)) ? Conversions.ToDouble(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[2]
					{
						Operators.DivideObject(num25, row11["comMainQty"]),
						0
					}, null, null, null)) : 0.0));
					bool flag = false;
					int num27 = num50 + 1;
					string text6;
					do
					{
						text6 = ExcelModule.ReadCell((Range)_xlApp.Cells[num34 - 1, num27 + 1]);
						if (Operators.ConditionalCompareObjectEqual(row11["itemName"], text6, TextCompare: false))
						{
							flag = true;
						}
						num27 += 2;
					}
					while (!unchecked(Operators.CompareString(text6, "", TextCompare: false) == 0 || flag));
					if (!flag)
					{
						_xlApp.Cells[num34 - 1, num27 - 2] = "Komposisi";
						_xlApp.Cells[num34 - 1, num27 - 1] = RuntimeHelpers.GetObjectValue(row11["itemName"]);
						count += 2;
					}
					_xlApp.Cells[j, num27 - 2] = num54;
					object obj54 = NewLateBinding.LateGet(null, typeof(Strings), "UCase", array4 = new object[1] { (dataRow12 = row11)["itemName"] }, null, null, array5 = new bool[1] { true });
					if (array5[0])
					{
						dataRow12["itemName"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array4[0]));
					}
					string text5 = ((Strings.InStr(Conversions.ToString(obj54), "BUNGA") <= 0) ? Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("=", NewLateBinding.LateGet(_xlApp.Cells[j, 3], null, "Address", new object[2] { false, false }, null, null, null)), "*"), NewLateBinding.LateGet(_xlApp.Cells[j, num27 - 2], null, "Address", new object[2] { false, false }, null, null, null)), "/100")) : Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("=", NewLateBinding.LateGet(_xlApp.Cells[j, 3], null, "Address", new object[2] { false, false }, null, null, null)), "/"), NewLateBinding.LateGet(_xlApp.Cells[j, num27 - 2], null, "Address", new object[2] { false, false }, null, null, null))));
					object obj55 = _xlApp.Sheets[1];
					object instance66 = obj55;
					object[] array56 = new object[2];
					object instance67 = (obj13 = obj55);
					object[] obj56 = new object[2]
					{
						num8 = j,
						null
					};
					instance2 = (obj56[1] = num27 - 1);
					array2 = obj56;
					obj7 = NewLateBinding.LateGet(instance67, null, "Cells", obj56, null, null, array3 = new bool[2] { true, false });
					if (array3[0])
					{
						j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
					}
					array56[0] = obj7;
					object instance68 = (obj5 = obj55);
					object[] obj57 = new object[2]
					{
						num7 = j,
						null
					};
					obj8 = (obj57[1] = num27 - 1);
					array2 = obj57;
					obj7 = NewLateBinding.LateGet(instance68, null, "Cells", obj57, null, null, array3 = new bool[2] { true, false });
					if (array3[0])
					{
						j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
					}
					array56[1] = obj7;
					array4 = array56;
					instance4 = NewLateBinding.LateGet(instance66, null, "Range", array56, null, null, array5 = new bool[2] { true, true });
					if (array5[0])
					{
						NewLateBinding.LateSetComplex(obj13, null, "Cells", new object[3]
						{
							num8,
							instance2,
							array4[0]
						}, null, null, OptimisticSet: true, RValueBase: true);
					}
					if (array5[1])
					{
						NewLateBinding.LateSetComplex(obj5, null, "Cells", new object[3]
						{
							num7,
							obj8,
							array4[1]
						}, null, null, OptimisticSet: true, RValueBase: true);
					}
					range = (Range)instance4;
					range.Select();
					obj55 = null;
					_xlApp.Cells[j, num27 - 1] = text5;
				}
			}
			int num55 = count + 3;
			object obj58 = _xlApp.Sheets[1];
			object instance69 = obj58;
			object[] array57 = new object[2];
			object instance70 = (obj8 = obj58);
			object[] obj59 = new object[2]
			{
				num7 = num47,
				null
			};
			obj5 = (obj59[1] = 4);
			array2 = obj59;
			obj7 = NewLateBinding.LateGet(instance70, null, "Cells", obj59, null, null, array3 = new bool[2] { true, false });
			if (array3[0])
			{
				num47 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
			}
			array57[0] = obj7;
			object instance71 = (instance2 = obj58);
			object[] obj60 = new object[2]
			{
				num8 = num47,
				null
			};
			obj13 = (obj60[1] = 4);
			array2 = obj60;
			obj7 = NewLateBinding.LateGet(instance71, null, "Cells", obj60, null, null, array3 = new bool[2] { true, false });
			if (array3[0])
			{
				num47 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
			}
			array57[1] = obj7;
			array4 = array57;
			instance4 = NewLateBinding.LateGet(instance69, null, "Range", array57, null, null, array5 = new bool[2] { true, true });
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(obj8, null, "Cells", new object[3]
				{
					num7,
					obj5,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array5[1])
			{
				NewLateBinding.LateSetComplex(instance2, null, "Cells", new object[3]
				{
					num8,
					obj13,
					array4[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			range = (Range)instance4;
			range.Select();
			obj58 = null;
			_xlApp.ActiveCell.FormulaR1C1 = "=SUM(R[-" + Conversions.ToString(num35 - num34 + 2) + "]C:R[-2]C)";
			object obj61 = _xlApp.Sheets[1];
			object selection8 = _xlApp.Selection;
			array2 = new object[2];
			object[] array58 = array2;
			object instance72 = (obj13 = obj61);
			object[] array59 = new object[2];
			object instance73 = (obj8 = obj61);
			object[] obj62 = new object[2]
			{
				num8 = num47,
				null
			};
			instance4 = (obj62[1] = 4);
			array8 = obj62;
			obj4 = NewLateBinding.LateGet(instance73, null, "Cells", obj62, null, null, array9 = new bool[2] { true, false });
			if (array9[0])
			{
				num47 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array8[0]), typeof(int));
			}
			instance2 = (array59[0] = obj4);
			object instance74 = (obj7 = obj61);
			object[] obj63 = new object[2]
			{
				num7 = num47,
				null
			};
			obj11 = (obj63[1] = 3 + count);
			array8 = obj63;
			obj4 = NewLateBinding.LateGet(instance74, null, "Cells", obj63, null, null, array9 = new bool[2] { true, false });
			if (array9[0])
			{
				num47 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array8[0]), typeof(int));
			}
			obj5 = (array59[1] = obj4);
			array10 = array59;
			obj14 = NewLateBinding.LateGet(instance72, null, "Range", array59, null, null, array3 = new bool[2] { true, true });
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj8, null, "Cells", new object[3]
				{
					num8,
					instance4,
					array10[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array3[1])
			{
				NewLateBinding.LateSetComplex(obj7, null, "Cells", new object[3]
				{
					num7,
					obj11,
					array10[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			array58[0] = obj14;
			array2[1] = XlAutoFillType.xlFillDefault;
			NewLateBinding.LateCall(selection8, null, "AutoFill", array4 = array2, new string[2] { "Destination", "Type" }, null, array5 = new bool[2] { true, false }, IgnoreReturn: true);
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(obj13, null, "Range", new object[3]
				{
					instance2,
					obj5,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			obj61 = null;
			int num56 = num50 + 1;
			int num57 = count + 2;
			for (j = num56; j <= num57; j += 2)
			{
				_xlApp.Cells[num47, j] = "";
			}
			num = num44 + 2;
			object obj64 = _xlApp.Sheets[1];
			object instance75 = obj64;
			object[] array60 = new object[2];
			object instance76 = (obj5 = obj64);
			object[] obj65 = new object[2]
			{
				num7 = num,
				null
			};
			instance2 = (obj65[1] = 4);
			array2 = obj65;
			instance4 = NewLateBinding.LateGet(instance76, null, "Cells", obj65, null, null, array3 = new bool[2] { true, false });
			if (array3[0])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
			}
			array60[0] = instance4;
			object instance77 = (obj13 = obj64);
			object[] obj66 = new object[2]
			{
				num8 = num,
				null
			};
			obj11 = (obj66[1] = 4);
			array2 = obj66;
			instance4 = NewLateBinding.LateGet(instance77, null, "Cells", obj66, null, null, array3 = new bool[2] { true, false });
			if (array3[0])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
			}
			array60[1] = instance4;
			array4 = array60;
			obj7 = NewLateBinding.LateGet(instance75, null, "Range", array60, null, null, array5 = new bool[2] { true, true });
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(obj5, null, "Cells", new object[3]
				{
					num7,
					instance2,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array5[1])
			{
				NewLateBinding.LateSetComplex(obj13, null, "Cells", new object[3]
				{
					num8,
					obj11,
					array4[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			range = (Range)obj7;
			range.Select();
			obj64 = null;
			_xlApp.ActiveCell.FormulaR1C1 = "=SUM(R[-" + Conversions.ToString(num44 - num39 + 4) + "]C:R[-2]C)";
			object obj67 = _xlApp.Sheets[1];
			object selection9 = _xlApp.Selection;
			array2 = new object[2];
			object[] array61 = array2;
			object instance78 = (obj11 = obj67);
			object[] array62 = new object[2];
			object instance79 = (obj5 = obj67);
			object[] obj68 = new object[2]
			{
				num8 = num,
				null
			};
			obj7 = (obj68[1] = 4);
			array8 = obj68;
			obj4 = NewLateBinding.LateGet(instance79, null, "Cells", obj68, null, null, array9 = new bool[2] { true, false });
			if (array9[0])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array8[0]), typeof(int));
			}
			obj13 = (array62[0] = obj4);
			object instance80 = (instance4 = obj67);
			object[] obj69 = new object[2]
			{
				num7 = num,
				null
			};
			obj8 = (obj69[1] = 3 + count);
			array8 = obj69;
			obj4 = NewLateBinding.LateGet(instance80, null, "Cells", obj69, null, null, array9 = new bool[2] { true, false });
			if (array9[0])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array8[0]), typeof(int));
			}
			instance2 = (array62[1] = obj4);
			array10 = array62;
			obj14 = NewLateBinding.LateGet(instance78, null, "Range", array62, null, null, array3 = new bool[2] { true, true });
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj5, null, "Cells", new object[3]
				{
					num8,
					obj7,
					array10[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array3[1])
			{
				NewLateBinding.LateSetComplex(instance4, null, "Cells", new object[3]
				{
					num7,
					obj8,
					array10[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			array61[0] = obj14;
			array2[1] = XlAutoFillType.xlFillDefault;
			NewLateBinding.LateCall(selection9, null, "AutoFill", array4 = array2, new string[2] { "Destination", "Type" }, null, array5 = new bool[2] { true, false }, IgnoreReturn: true);
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(obj11, null, "Range", new object[3]
				{
					obj13,
					instance2,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			obj67 = null;
			int num58 = num50 + 1;
			int num59 = count + 2;
			for (j = num58; j <= num59; j += 2)
			{
				_xlApp.Cells[num, j] = "";
			}
			ProgressBar1.Value = 80;
			_xlApp.Cells[num35 + 2, 2] = "Sub Total";
			_xlApp.Cells[num44 + 2, 2] = "Total Needs ";
			_xlApp.Cells[num44 + 4, 2] = "Daily average";
			_xlApp.Cells[num44 + 6, 2] = "Stok tersedia";
			object obj70 = _xlApp.Sheets[1];
			object instance81 = obj70;
			object[] array63 = new object[2];
			object instance82 = (instance2 = obj70);
			object[] array64 = new object[2];
			obj13 = (array64[0] = num44 + 4);
			obj11 = (array64[1] = 4);
			array63[0] = NewLateBinding.LateGet(instance82, null, "Cells", array64, null, null, null);
			object instance83 = (obj8 = obj70);
			object[] array65 = new object[2];
			instance4 = (array65[0] = num44 + 4);
			obj7 = (array65[1] = 4);
			array63[1] = NewLateBinding.LateGet(instance83, null, "Cells", array65, null, null, null);
			array4 = array63;
			obj5 = NewLateBinding.LateGet(instance81, null, "Range", array63, null, null, array5 = new bool[2] { true, true });
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(instance2, null, "Cells", new object[3]
				{
					obj13,
					obj11,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array5[1])
			{
				NewLateBinding.LateSetComplex(obj8, null, "Cells", new object[3]
				{
					instance4,
					obj7,
					array4[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			range = (Range)obj5;
			range.Select();
			obj70 = null;
			_xlApp.ActiveCell.FormulaR1C1 = "=R[-2]C/30";
			object obj71 = _xlApp.Sheets[1];
			object selection10 = _xlApp.Selection;
			array2 = new object[2];
			object[] array66 = array2;
			object instance84 = (obj7 = obj71);
			object[] array67 = new object[2];
			object instance85 = (obj11 = obj71);
			object[] array68 = new object[2];
			obj13 = (array68[0] = num44 + 4);
			instance2 = (array68[1] = 4);
			instance4 = (array67[0] = NewLateBinding.LateGet(instance85, null, "Cells", array68, null, null, null));
			object instance86 = (obj5 = obj71);
			object[] array69 = new object[2];
			obj14 = (array69[0] = num44 + 4);
			obj4 = (array69[1] = count + 3);
			obj8 = (array67[1] = NewLateBinding.LateGet(instance86, null, "Cells", array69, null, null, null));
			array10 = array67;
			obj45 = NewLateBinding.LateGet(instance84, null, "Range", array67, null, null, array3 = new bool[2] { true, true });
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj11, null, "Cells", new object[3]
				{
					obj13,
					instance2,
					array10[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array3[1])
			{
				NewLateBinding.LateSetComplex(obj5, null, "Cells", new object[3]
				{
					obj14,
					obj4,
					array10[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			array66[0] = obj45;
			array2[1] = XlAutoFillType.xlFillDefault;
			NewLateBinding.LateCall(selection10, null, "AutoFill", array4 = array2, new string[2] { "Destination", "Type" }, null, array5 = new bool[2] { true, false }, IgnoreReturn: true);
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(obj7, null, "Range", new object[3]
				{
					instance4,
					obj8,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			obj71 = null;
			int num60 = num50 + 1;
			int num61 = count + 2;
			for (j = num60; j <= num61; j += 2)
			{
				_xlApp.Cells[num44 + 4, j] = "";
			}
			int num62 = count + 3;
			for (j = 4; j <= num62; j++)
			{
				string text4 = ExcelModule.ReadCell((Range)_xlApp.Cells[num34 - 1, j]);
				double num33 = ((!((Operators.CompareString(Strings.UCase(text4), "KOMPOSISI", TextCompare: false) == 0) | (Operators.CompareString(Strings.UCase(text4), "BUNGA GAMBIR", TextCompare: false) == 0) | (Operators.CompareString(Strings.UCase(text4), "BUNGA MELATI", TextCompare: false) == 0))) ? cStock.getStock((int)Math.Round(cItem.GetItemId(text4)), Module1.pubBalanceDate, datReport, "Good", 0, Module1.pubGroupId, Module1.pubBranchId, Module1.pubReportUseNewGetStockCode) : 0.0);
				_xlApp.Cells[num44 + 6, j] = num33;
			}
			int num63 = num50 + 1;
			int num64 = count + 2;
			for (j = num63; j <= num64; j += 2)
			{
				_xlApp.Cells[num44 + 6, j] = "";
			}
			object obj72 = _xlApp.Sheets[1];
			object instance87 = obj72;
			object[] array70 = new object[2];
			object instance88 = (obj8 = obj72);
			object[] array71 = new object[2];
			instance4 = (array71[0] = num34 - 1);
			obj7 = (array71[1] = 2);
			array70[0] = NewLateBinding.LateGet(instance88, null, "Cells", array71, null, null, null);
			object instance89 = (obj4 = obj72);
			object[] array72 = new object[2];
			obj14 = (array72[0] = num44 + 6);
			obj5 = (array72[1] = count + 3);
			array70[1] = NewLateBinding.LateGet(instance89, null, "Cells", array72, null, null, null);
			array4 = array70;
			instance2 = NewLateBinding.LateGet(instance87, null, "Range", array70, null, null, array5 = new bool[2] { true, true });
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(obj8, null, "Cells", new object[3]
				{
					instance4,
					obj7,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array5[1])
			{
				NewLateBinding.LateSetComplex(obj4, null, "Cells", new object[3]
				{
					obj14,
					obj5,
					array4[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			range = (Range)instance2;
			range.Select();
			obj72 = null;
			ExcelModule.formatBorder(_xlApp);
			object obj73 = _xlApp.Sheets[1];
			object instance90 = obj73;
			object[] array73 = new object[2];
			object instance91 = (obj5 = obj73);
			object[] obj74 = new object[2]
			{
				num7 = num34,
				null
			};
			obj14 = (obj74[1] = 3);
			array2 = obj74;
			instance2 = NewLateBinding.LateGet(instance91, null, "Cells", obj74, null, null, array3 = new bool[2] { true, false });
			if (array3[0])
			{
				num34 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
			}
			array73[0] = instance2;
			object instance92 = (obj4 = obj73);
			object[] array74 = new object[2];
			obj7 = (array74[0] = num44 + 6);
			instance4 = (array74[1] = count + 3);
			array73[1] = NewLateBinding.LateGet(instance92, null, "Cells", array74, null, null, null);
			array4 = array73;
			obj8 = NewLateBinding.LateGet(instance90, null, "Range", array73, null, null, array5 = new bool[2] { true, true });
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(obj5, null, "Cells", new object[3]
				{
					num7,
					obj14,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array5[1])
			{
				NewLateBinding.LateSetComplex(obj4, null, "Cells", new object[3]
				{
					obj7,
					instance4,
					array4[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			range = (Range)obj8;
			range.Select();
			obj73 = null;
			NewLateBinding.LateSetComplex(_xlApp.Selection, null, "HorizontalAlignment", new object[1] { XlHAlign.xlHAlignRight }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(_xlApp.Selection, null, "NumberFormat", new object[1] { "#,##0" }, null, null, OptimisticSet: false, RValueBase: true);
			int num65 = num50 + 1;
			int num66 = count + 2;
			int num67;
			for (j = num65; j <= num66; j += 2)
			{
				if (Strings.InStr(Strings.UCase(ExcelModule.ReadCell((Range)_xlApp.Cells[num34 - 1, j + 1])), "BUNGA") == 0)
				{
					object obj75 = _xlApp.Sheets[1];
					object instance93 = obj75;
					object[] array75 = new object[2];
					object instance94 = (instance4 = obj75);
					object[] obj76 = new object[2]
					{
						num7 = num34,
						num8 = j
					};
					array2 = obj76;
					bool[] obj77 = new bool[2] { true, true };
					array3 = obj77;
					obj5 = NewLateBinding.LateGet(instance94, null, "Cells", obj76, null, null, obj77);
					if (array3[0])
					{
						num34 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
					}
					if (array3[1])
					{
						j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
					}
					array75[0] = obj5;
					object instance95 = (obj7 = obj75);
					object[] array76 = new object[2];
					obj4 = (array76[0] = num44 + 6);
					array76[1] = (num67 = j);
					array2 = array76;
					obj5 = NewLateBinding.LateGet(instance95, null, "Cells", array76, null, null, array3 = new bool[2] { false, true });
					if (array3[1])
					{
						j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
					}
					array75[1] = obj5;
					array4 = array75;
					obj14 = NewLateBinding.LateGet(instance93, null, "Range", array75, null, null, array5 = new bool[2] { true, true });
					if (array5[0])
					{
						NewLateBinding.LateSetComplex(instance4, null, "Cells", new object[3]
						{
							num7,
							num8,
							array4[0]
						}, null, null, OptimisticSet: true, RValueBase: true);
					}
					if (array5[1])
					{
						NewLateBinding.LateSetComplex(obj7, null, "Cells", new object[3]
						{
							obj4,
							num67,
							array4[1]
						}, null, null, OptimisticSet: true, RValueBase: true);
					}
					range = (Range)obj14;
					range.Select();
					obj75 = null;
					NewLateBinding.LateSetComplex(_xlApp.Selection, null, "NumberFormat", new object[1] { "#,##0.00" }, null, null, OptimisticSet: false, RValueBase: true);
				}
			}
			ProgressBar1.Value = 90;
			num = num44 + 9;
			int num68 = num;
			j = 1;
			int num69;
			int num73;
			do
			{
				_xlApp.Cells[num68 - 1, 2] = RuntimeHelpers.GetObjectValue(Interaction.IIf(j == 1, "TAELAN", RuntimeHelpers.GetObjectValue(Interaction.IIf(j == 2, "LOSINAN", "MISC"))));
				_xlApp.Cells[num68 - 1, 3] = "Monthly Avg (Bal)";
				_xlApp.Cells[num68 - 1, 4] = "Daily Avg (Bal)";
				_xlApp.Cells[num68 - 1, 5] = "x10";
				_xlApp.Cells[num68 - 1, 6] = "Buffer Stock";
				_xlApp.Cells[num68 - 1, 7] = "Stok tersedia";
				_xlApp.Cells[num68 - 1, 8] = "% Stok";
				num69 = 0;
				int num70 = num5;
				for (int i = 3; i <= num70; i++)
				{
					if (Conversions.ToDouble(ExcelModule.ReadCell((Range)_xlApp.Cells[num6 - 2, i])) != (double)j)
					{
						continue;
					}
					_xlApp.Cells[num68 + num69, 2] = Operators.ConcatenateObject("=", NewLateBinding.LateGet(_xlApp.Cells[num6 - 1, i], null, "Address", new object[2] { false, false }, null, null, null));
					string text4 = ExcelModule.ReadCell((Range)_xlApp.Cells[num68 + num69, 2]);
					_xlApp.Cells[num68 + num69, 3] = Operators.ConcatenateObject("=", NewLateBinding.LateGet(_xlApp.Cells[num6 + 2, i], null, "Address", new object[2] { false, false }, null, null, null));
					_xlApp.Cells[num68 + num69, 4] = Operators.ConcatenateObject("=", NewLateBinding.LateGet(_xlApp.Cells[num6 + 1, i], null, "Address", new object[2] { false, false }, null, null, null));
					_xlApp.Cells[num68 + num69, 5] = Operators.ConcatenateObject(Operators.ConcatenateObject("=", NewLateBinding.LateGet(_xlApp.Cells[num68 + num69, 4], null, "Address", new object[2] { false, false }, null, null, null)), "*10");
					double num71 = Conversions.ToDouble(ExcelModule.ReadCell((Range)_xlApp.Cells[num68 + num69, 5]));
					if (Conversions.ToDouble(ExcelModule.ReadCell((Range)_xlApp.Cells[num68 + num69, 3])) >= 50.0)
					{
						_xlApp.Cells[num68 + num69, 6] = RuntimeHelpers.GetObjectValue(Module1.RoundUp(num71, 50.0));
					}
					else
					{
						_xlApp.Cells[num68 + num69, 6] = 0;
					}
					_xlApp.Cells[num68 + num69, 7] = cStock.getStock((int)Math.Round(cItem.GetItemId(text4)), Module1.pubBalanceDate, datReport, "Good", 0, Module1.pubGroupId, Module1.pubBranchId, Module1.pubReportUseNewGetStockCode);
					if (Conversions.ToDouble(ExcelModule.ReadCell((Range)_xlApp.Cells[num68 + num69, 6])) > 0.0)
					{
						_xlApp.Cells[num68 + num69, 8] = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("=", NewLateBinding.LateGet(_xlApp.Cells[num68 + num69, 7], null, "Address", new object[2] { false, false }, null, null, null)), "/"), NewLateBinding.LateGet(_xlApp.Cells[num68 + num69, 6], null, "Address", new object[2] { false, false }, null, null, null));
					}
					double num72 = ((!((num71 > 0.0) & (Operators.CompareString(ExcelModule.ReadCell((Range)_xlApp.Cells[num68 + num69, 8]), "", TextCompare: false) != 0))) ? 0.0 : Conversions.ToDouble(ExcelModule.ReadCell((Range)_xlApp.Cells[num68 + num69, 8])));
					if (Conversions.ToDouble(ExcelModule.ReadCell((Range)_xlApp.Cells[num68 + num69, 6])) != 0.0)
					{
						if (num72 <= 0.5)
						{
							((_Application)_xlApp).get_Range((object)("H" + Conversions.ToString(num68 + num69)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							object instance96 = NewLateBinding.LateGet(_xlApp.Selection, null, "Interior", new object[0], null, null, null);
							NewLateBinding.LateSetComplex(instance96, null, "ColorIndex", new object[1] { 3 }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance96, null, "Pattern", new object[1] { XlPattern.xlPatternSolid }, null, null, OptimisticSet: false, RValueBase: true);
							instance96 = null;
						}
						else
						{
							((_Application)_xlApp).get_Range((object)("H" + Conversions.ToString(num68 + num69)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							object instance97 = NewLateBinding.LateGet(_xlApp.Selection, null, "Interior", new object[0], null, null, null);
							NewLateBinding.LateSetComplex(instance97, null, "ColorIndex", new object[1] { 43 }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance97, null, "Pattern", new object[1] { XlPattern.xlPatternSolid }, null, null, OptimisticSet: false, RValueBase: true);
							instance97 = null;
						}
					}
					num69++;
				}
				num73 = num68 + num69 - 1;
				object obj78 = _xlApp.Sheets[1];
				object instance98 = obj78;
				object[] array77 = new object[2];
				object instance99 = (obj4 = obj78);
				object[] array78 = new object[2];
				obj7 = (array78[0] = num68 - 1);
				instance4 = (array78[1] = 2);
				array77[0] = NewLateBinding.LateGet(instance99, null, "Cells", array78, null, null, null);
				object instance100 = (obj14 = obj78);
				object[] obj79 = new object[2]
				{
					num67 = num73,
					null
				};
				obj5 = (obj79[1] = 8);
				array2 = obj79;
				bool[] obj80 = new bool[2] { true, false };
				array3 = obj80;
				instance2 = NewLateBinding.LateGet(instance100, null, "Cells", obj79, null, null, obj80);
				if (array3[0])
				{
					num73 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
				}
				array77[1] = instance2;
				array4 = array77;
				obj8 = NewLateBinding.LateGet(instance98, null, "Range", array77, null, null, array5 = new bool[2] { true, true });
				if (array5[0])
				{
					NewLateBinding.LateSetComplex(obj4, null, "Cells", new object[3]
					{
						obj7,
						instance4,
						array4[0]
					}, null, null, OptimisticSet: true, RValueBase: true);
				}
				if (array5[1])
				{
					NewLateBinding.LateSetComplex(obj14, null, "Cells", new object[3]
					{
						num67,
						obj5,
						array4[1]
					}, null, null, OptimisticSet: true, RValueBase: true);
				}
				range = (Range)obj8;
				range.Select();
				obj78 = null;
				ExcelModule.formatBorder(_xlApp);
				object obj81 = _xlApp.Sheets[1];
				object instance101 = obj81;
				object[] array79 = new object[2];
				object instance102 = (obj5 = obj81);
				object[] obj82 = new object[2]
				{
					num67 = num68,
					null
				};
				obj14 = (obj82[1] = 3);
				array2 = obj82;
				obj8 = NewLateBinding.LateGet(instance102, null, "Cells", obj82, null, null, array3 = new bool[2] { true, false });
				if (array3[0])
				{
					num68 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
				}
				array79[0] = obj8;
				object instance103 = (instance4 = obj81);
				object[] obj83 = new object[2]
				{
					num8 = num73,
					null
				};
				obj7 = (obj83[1] = 7);
				array2 = obj83;
				obj8 = NewLateBinding.LateGet(instance103, null, "Cells", obj83, null, null, array3 = new bool[2] { true, false });
				if (array3[0])
				{
					num73 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
				}
				array79[1] = obj8;
				array4 = array79;
				obj4 = NewLateBinding.LateGet(instance101, null, "Range", array79, null, null, array5 = new bool[2] { true, true });
				if (array5[0])
				{
					NewLateBinding.LateSetComplex(obj5, null, "Cells", new object[3]
					{
						num67,
						obj14,
						array4[0]
					}, null, null, OptimisticSet: true, RValueBase: true);
				}
				if (array5[1])
				{
					NewLateBinding.LateSetComplex(instance4, null, "Cells", new object[3]
					{
						num8,
						obj7,
						array4[1]
					}, null, null, OptimisticSet: true, RValueBase: true);
				}
				range = (Range)obj4;
				range.Select();
				obj81 = null;
				NewLateBinding.LateSetComplex(_xlApp.Selection, null, "HorizontalAlignment", new object[1] { XlHAlign.xlHAlignRight }, null, null, OptimisticSet: false, RValueBase: true);
				NewLateBinding.LateSetComplex(_xlApp.Selection, null, "NumberFormat", new object[1] { "#,##0" }, null, null, OptimisticSet: false, RValueBase: true);
				object obj84 = _xlApp.Sheets[1];
				object instance104 = obj84;
				object[] array80 = new object[2];
				object instance105 = (obj7 = obj84);
				object[] obj85 = new object[2]
				{
					num8 = num68,
					null
				};
				instance4 = (obj85[1] = 8);
				array2 = obj85;
				obj8 = NewLateBinding.LateGet(instance105, null, "Cells", obj85, null, null, array3 = new bool[2] { true, false });
				if (array3[0])
				{
					num68 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
				}
				array80[0] = obj8;
				object instance106 = (obj14 = obj84);
				object[] obj86 = new object[2]
				{
					num67 = num73,
					null
				};
				obj5 = (obj86[1] = 8);
				array2 = obj86;
				obj8 = NewLateBinding.LateGet(instance106, null, "Cells", obj86, null, null, array3 = new bool[2] { true, false });
				if (array3[0])
				{
					num73 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
				}
				array80[1] = obj8;
				array4 = array80;
				obj4 = NewLateBinding.LateGet(instance104, null, "Range", array80, null, null, array5 = new bool[2] { true, true });
				if (array5[0])
				{
					NewLateBinding.LateSetComplex(obj7, null, "Cells", new object[3]
					{
						num8,
						instance4,
						array4[0]
					}, null, null, OptimisticSet: true, RValueBase: true);
				}
				if (array5[1])
				{
					NewLateBinding.LateSetComplex(obj14, null, "Cells", new object[3]
					{
						num67,
						obj5,
						array4[1]
					}, null, null, OptimisticSet: true, RValueBase: true);
				}
				range = (Range)obj4;
				range.Select();
				obj84 = null;
				NewLateBinding.LateSetComplex(_xlApp.Selection, null, "HorizontalAlignment", new object[1] { XlHAlign.xlHAlignRight }, null, null, OptimisticSet: false, RValueBase: true);
				NewLateBinding.LateSetComplex(_xlApp.Selection, null, "NumberFormat", new object[1] { "0%" }, null, null, OptimisticSet: false, RValueBase: true);
				num68 = num68 + num69 + 2;
				j++;
			}
			while (j <= 3);
			num = num73 + 3;
			num68 = num;
			j = 1;
			int num76;
			do
			{
				int num74;
				int num75;
				if (j == 1)
				{
					num74 = num17;
					num75 = num18;
					num76 = 3;
				}
				else
				{
					num74 = num34;
					num75 = num44;
					num76 = 15;
				}
				_xlApp.Cells[num68 - 1, 2] = RuntimeHelpers.GetObjectValue(Interaction.IIf(j == 1, "CAM", "BDP"));
				_xlApp.Cells[num68 - 1, 3] = "Monthly Avg (Kg)";
				_xlApp.Cells[num68 - 1, 4] = "Daily Avg (Kg)";
				_xlApp.Cells[num68 - 1, 5] = "x" + Conversions.ToString(num76);
				_xlApp.Cells[num68 - 1, 6] = "Buffer Stock";
				_xlApp.Cells[num68 - 1, 7] = "Stok tersedia";
				_xlApp.Cells[num68 - 1, 8] = "% Stok";
				num69 = 0;
				num9 = 0;
				int num77 = num74;
				int num78 = num75;
				for (int i = num77; i <= num78; i++)
				{
					if ((Operators.CompareString(ExcelModule.ReadCell((Range)_xlApp.Cells[i, 2]), "", TextCompare: false) != 0) & (Operators.CompareString(ExcelModule.ReadCell((Range)_xlApp.Cells[i, 2]), "Sub Total", TextCompare: false) != 0))
					{
						_xlApp.Cells[num68 + num69, 2] = Operators.ConcatenateObject("=", NewLateBinding.LateGet(_xlApp.Cells[num74 + num9, 2], null, "Address", new object[2] { false, false }, null, null, null));
						_xlApp.Cells[num68 + num69, 3] = Operators.ConcatenateObject("=", NewLateBinding.LateGet(_xlApp.Cells[num74 + num9, 3], null, "Address", new object[2] { false, false }, null, null, null));
						_xlApp.Cells[num68 + num69, 4] = Operators.ConcatenateObject(Operators.ConcatenateObject("=", NewLateBinding.LateGet(_xlApp.Cells[num68 + num69, 3], null, "Address", new object[2] { false, false }, null, null, null)), "/25");
						_xlApp.Cells[num68 + num69, 5] = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("=", NewLateBinding.LateGet(_xlApp.Cells[num68 + num69, 4], null, "Address", new object[2] { false, false }, null, null, null)), "*"), num76);
						double num71 = Conversions.ToDouble(ExcelModule.ReadCell((Range)_xlApp.Cells[num68 + num69, 5]));
						if (Conversions.ToDouble(ExcelModule.ReadCell((Range)_xlApp.Cells[num68 + num69, 3])) >= 50.0)
						{
							_xlApp.Cells[num68 + num69, 6] = RuntimeHelpers.GetObjectValue(Module1.RoundUp(num71, 50.0));
						}
						else
						{
							_xlApp.Cells[num68 + num69, 6] = 0;
						}
						string text4 = ExcelModule.ReadCell((Range)_xlApp.Cells[num68 + num69, 2]);
						if (j == 1)
						{
							double stock = cStock.getStock((int)Math.Round(cItem.GetItemId(text4)), Module1.pubBalanceDate, datReport, "Good", 0, Module1.pubGroupId, Module1.pubBranchId, Module1.pubReportUseNewGetStockCode);
							_xlApp.Cells[num68 + num69, 7] = stock;
						}
						else if (i <= num35)
						{
							_xlApp.Cells[num68 + num69, 7] = getStockFromExcel(_xlApp, text4, num17 - 1, num18 + 6, 4, intToCol);
						}
						else
						{
							_xlApp.Cells[num68 + num69, 7] = getStockFromExcel(_xlApp, text4, num34 - 1, num44 + 6, 4, num46);
						}
						if (Conversions.ToDouble(ExcelModule.ReadCell((Range)_xlApp.Cells[num68 + num69, 6])) > 0.0)
						{
							_xlApp.Cells[num68 + num69, 8] = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("=", NewLateBinding.LateGet(_xlApp.Cells[num68 + num69, 7], null, "Address", new object[2] { false, false }, null, null, null)), "/"), NewLateBinding.LateGet(_xlApp.Cells[num68 + num69, 6], null, "Address", new object[2] { false, false }, null, null, null));
						}
						double num72 = ((!((num71 > 0.0) & (Conversions.ToDouble(ExcelModule.ReadCell((Range)_xlApp.Cells[num68 + num69, 6])) > 0.0))) ? 0.0 : Conversions.ToDouble(ExcelModule.ReadCell((Range)_xlApp.Cells[num68 + num69, 8])));
						if (Conversions.ToDouble(ExcelModule.ReadCell((Range)_xlApp.Cells[num68 + num69, 6])) != 0.0)
						{
							if (num72 <= 0.5)
							{
								((_Application)_xlApp).get_Range((object)("H" + Conversions.ToString(num68 + num69)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
								object instance107 = NewLateBinding.LateGet(_xlApp.Selection, null, "Interior", new object[0], null, null, null);
								NewLateBinding.LateSetComplex(instance107, null, "ColorIndex", new object[1] { 3 }, null, null, OptimisticSet: false, RValueBase: true);
								NewLateBinding.LateSetComplex(instance107, null, "Pattern", new object[1] { XlPattern.xlPatternSolid }, null, null, OptimisticSet: false, RValueBase: true);
								instance107 = null;
							}
							else
							{
								((_Application)_xlApp).get_Range((object)("H" + Conversions.ToString(num68 + num69)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
								object instance108 = NewLateBinding.LateGet(_xlApp.Selection, null, "Interior", new object[0], null, null, null);
								NewLateBinding.LateSetComplex(instance108, null, "ColorIndex", new object[1] { 43 }, null, null, OptimisticSet: false, RValueBase: true);
								NewLateBinding.LateSetComplex(instance108, null, "Pattern", new object[1] { XlPattern.xlPatternSolid }, null, null, OptimisticSet: false, RValueBase: true);
								instance108 = null;
							}
						}
						num69++;
					}
					num9++;
				}
				num73 = num68 + num69 - 1;
				object obj87 = _xlApp.Sheets[1];
				object instance109 = obj87;
				object[] array81 = new object[2];
				object instance110 = (obj5 = obj87);
				object[] array82 = new object[2];
				obj14 = (array82[0] = num68 - 1);
				instance4 = (array82[1] = 2);
				array81[0] = NewLateBinding.LateGet(instance110, null, "Cells", array82, null, null, null);
				object instance111 = (obj7 = obj87);
				object[] obj88 = new object[2]
				{
					num67 = num73,
					null
				};
				obj4 = (obj88[1] = 8);
				array2 = obj88;
				instance2 = NewLateBinding.LateGet(instance111, null, "Cells", obj88, null, null, array3 = new bool[2] { true, false });
				if (array3[0])
				{
					num73 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
				}
				array81[1] = instance2;
				array4 = array81;
				obj8 = NewLateBinding.LateGet(instance109, null, "Range", array81, null, null, array5 = new bool[2] { true, true });
				if (array5[0])
				{
					NewLateBinding.LateSetComplex(obj5, null, "Cells", new object[3]
					{
						obj14,
						instance4,
						array4[0]
					}, null, null, OptimisticSet: true, RValueBase: true);
				}
				if (array5[1])
				{
					NewLateBinding.LateSetComplex(obj7, null, "Cells", new object[3]
					{
						num67,
						obj4,
						array4[1]
					}, null, null, OptimisticSet: true, RValueBase: true);
				}
				range = (Range)obj8;
				range.Select();
				obj87 = null;
				ExcelModule.formatBorder(_xlApp);
				object obj89 = _xlApp.Sheets[1];
				object instance112 = obj89;
				object[] array83 = new object[2];
				object instance113 = (obj4 = obj89);
				object[] obj90 = new object[2]
				{
					num67 = num68,
					null
				};
				obj7 = (obj90[1] = 3);
				array2 = obj90;
				obj8 = NewLateBinding.LateGet(instance113, null, "Cells", obj90, null, null, array3 = new bool[2] { true, false });
				if (array3[0])
				{
					num68 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
				}
				array83[0] = obj8;
				object instance114 = (instance4 = obj89);
				object[] obj91 = new object[2]
				{
					num8 = num73,
					null
				};
				obj14 = (obj91[1] = 7);
				array2 = obj91;
				obj8 = NewLateBinding.LateGet(instance114, null, "Cells", obj91, null, null, array3 = new bool[2] { true, false });
				if (array3[0])
				{
					num73 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
				}
				array83[1] = obj8;
				array4 = array83;
				obj5 = NewLateBinding.LateGet(instance112, null, "Range", array83, null, null, array5 = new bool[2] { true, true });
				if (array5[0])
				{
					NewLateBinding.LateSetComplex(obj4, null, "Cells", new object[3]
					{
						num67,
						obj7,
						array4[0]
					}, null, null, OptimisticSet: true, RValueBase: true);
				}
				if (array5[1])
				{
					NewLateBinding.LateSetComplex(instance4, null, "Cells", new object[3]
					{
						num8,
						obj14,
						array4[1]
					}, null, null, OptimisticSet: true, RValueBase: true);
				}
				range = (Range)obj5;
				range.Select();
				obj89 = null;
				NewLateBinding.LateSetComplex(_xlApp.Selection, null, "HorizontalAlignment", new object[1] { XlHAlign.xlHAlignRight }, null, null, OptimisticSet: false, RValueBase: true);
				NewLateBinding.LateSetComplex(_xlApp.Selection, null, "NumberFormat", new object[1] { "#,##0" }, null, null, OptimisticSet: false, RValueBase: true);
				object obj92 = _xlApp.Sheets[1];
				object instance115 = obj92;
				object[] array84 = new object[2];
				object instance116 = (obj14 = obj92);
				object[] obj93 = new object[2]
				{
					num8 = num68,
					null
				};
				instance4 = (obj93[1] = 8);
				array2 = obj93;
				obj8 = NewLateBinding.LateGet(instance116, null, "Cells", obj93, null, null, array3 = new bool[2] { true, false });
				if (array3[0])
				{
					num68 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
				}
				array84[0] = obj8;
				object instance117 = (obj7 = obj92);
				object[] obj94 = new object[2]
				{
					num67 = num73,
					null
				};
				obj4 = (obj94[1] = 8);
				array2 = obj94;
				obj8 = NewLateBinding.LateGet(instance117, null, "Cells", obj94, null, null, array3 = new bool[2] { true, false });
				if (array3[0])
				{
					num73 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
				}
				array84[1] = obj8;
				array4 = array84;
				obj5 = NewLateBinding.LateGet(instance115, null, "Range", array84, null, null, array5 = new bool[2] { true, true });
				if (array5[0])
				{
					NewLateBinding.LateSetComplex(obj14, null, "Cells", new object[3]
					{
						num8,
						instance4,
						array4[0]
					}, null, null, OptimisticSet: true, RValueBase: true);
				}
				if (array5[1])
				{
					NewLateBinding.LateSetComplex(obj7, null, "Cells", new object[3]
					{
						num67,
						obj4,
						array4[1]
					}, null, null, OptimisticSet: true, RValueBase: true);
				}
				range = (Range)obj5;
				range.Select();
				obj92 = null;
				NewLateBinding.LateSetComplex(_xlApp.Selection, null, "HorizontalAlignment", new object[1] { XlHAlign.xlHAlignRight }, null, null, OptimisticSet: false, RValueBase: true);
				NewLateBinding.LateSetComplex(_xlApp.Selection, null, "NumberFormat", new object[1] { "0%" }, null, null, OptimisticSet: false, RValueBase: true);
				num68 = num68 + num69 + 2;
				j++;
			}
			while (j <= 2);
			num = num73 + 3;
			num68 = num;
			num76 = 3;
			_xlApp.Cells[num68 - 1, 2] = "CAUCWIE";
			_xlApp.Cells[num68 - 1, 3] = "Monthly Avg (Kg)";
			_xlApp.Cells[num68 - 1, 4] = "Daily Avg (Kg)";
			_xlApp.Cells[num68 - 1, 5] = "x" + Conversions.ToString(num76);
			_xlApp.Cells[num68 - 1, 6] = "Buffer Stock";
			_xlApp.Cells[num68 - 1, 7] = "Stok tersedia";
			_xlApp.Cells[num68 - 1, 8] = "% Stok";
			num69 = 0;
			num9 = 0;
			int num79 = num46;
			for (int i = 4; i <= num79; i++)
			{
				if (Strings.InStr(ExcelModule.ReadCell((Range)_xlApp.Cells[num34 - 1, i]), "CC") > 0)
				{
					_xlApp.Cells[num68 + num69, 2] = Operators.ConcatenateObject("=", NewLateBinding.LateGet(_xlApp.Cells[num34 - 1, i], null, "Address", new object[2] { false, false }, null, null, null));
					_xlApp.Cells[num68 + num69, 3] = Operators.ConcatenateObject("=", NewLateBinding.LateGet(_xlApp.Cells[num44 + 2, i], null, "Address", new object[2] { false, false }, null, null, null));
					_xlApp.Cells[num68 + num69, 4] = Operators.ConcatenateObject(Operators.ConcatenateObject("=", NewLateBinding.LateGet(_xlApp.Cells[num68 + num69, 3], null, "Address", new object[2] { false, false }, null, null, null)), "/25");
					_xlApp.Cells[num68 + num69, 5] = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("=", NewLateBinding.LateGet(_xlApp.Cells[num68 + num69, 3], null, "Address", new object[2] { false, false }, null, null, null)), "*"), num76);
					double num71 = Conversions.ToDouble(ExcelModule.ReadCell((Range)_xlApp.Cells[num68 + num69, 5]));
					if (Conversions.ToDouble(ExcelModule.ReadCell((Range)_xlApp.Cells[num68 + num69, 3])) >= 50.0)
					{
						_xlApp.Cells[num68 + num69, 6] = RuntimeHelpers.GetObjectValue(Module1.RoundUp(num71, 50.0));
					}
					else
					{
						_xlApp.Cells[num68 + num69, 6] = 0;
					}
					string text4 = ExcelModule.ReadCell((Range)_xlApp.Cells[num68 + num69, 2]);
					_xlApp.Cells[num68 + num69, 7] = getStockFromExcel(_xlApp, text4, num34 - 1, num44 + 6, 4, num46);
					if (Conversions.ToDouble(ExcelModule.ReadCell((Range)_xlApp.Cells[num68 + num69, 6])) > 0.0)
					{
						_xlApp.Cells[num68 + num69, 8] = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("=", NewLateBinding.LateGet(_xlApp.Cells[num68 + num69, 7], null, "Address", new object[2] { false, false }, null, null, null)), "/"), NewLateBinding.LateGet(_xlApp.Cells[num68 + num69, 6], null, "Address", new object[2] { false, false }, null, null, null));
					}
					double num72 = ((!((num71 > 0.0) & (Operators.CompareString(ExcelModule.ReadCell((Range)_xlApp.Cells[num68 + num69, 8]), "", TextCompare: false) != 0))) ? 0.0 : Conversions.ToDouble(ExcelModule.ReadCell((Range)_xlApp.Cells[num68 + num69, 8])));
					if (Conversions.ToDouble(ExcelModule.ReadCell((Range)_xlApp.Cells[num68 + num69, 6])) != 0.0)
					{
						if (num72 <= 0.5)
						{
							((_Application)_xlApp).get_Range((object)("H" + Conversions.ToString(num68 + num69)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							object instance118 = NewLateBinding.LateGet(_xlApp.Selection, null, "Interior", new object[0], null, null, null);
							NewLateBinding.LateSetComplex(instance118, null, "ColorIndex", new object[1] { 3 }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance118, null, "Pattern", new object[1] { XlPattern.xlPatternSolid }, null, null, OptimisticSet: false, RValueBase: true);
							instance118 = null;
						}
						else
						{
							((_Application)_xlApp).get_Range((object)("H" + Conversions.ToString(num68 + num69)), RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
							object instance119 = NewLateBinding.LateGet(_xlApp.Selection, null, "Interior", new object[0], null, null, null);
							NewLateBinding.LateSetComplex(instance119, null, "ColorIndex", new object[1] { 43 }, null, null, OptimisticSet: false, RValueBase: true);
							NewLateBinding.LateSetComplex(instance119, null, "Pattern", new object[1] { XlPattern.xlPatternSolid }, null, null, OptimisticSet: false, RValueBase: true);
							instance119 = null;
						}
					}
					num69++;
				}
				num9++;
			}
			num73 = num68 + num69 - 1;
			object obj95 = _xlApp.Sheets[1];
			object instance120 = obj95;
			object[] array85 = new object[2];
			object instance121 = (obj4 = obj95);
			object[] array86 = new object[2];
			obj7 = (array86[0] = num68 - 1);
			instance4 = (array86[1] = 2);
			array85[0] = NewLateBinding.LateGet(instance121, null, "Cells", array86, null, null, null);
			object instance122 = (obj14 = obj95);
			object[] obj96 = new object[2]
			{
				num67 = num73,
				null
			};
			obj5 = (obj96[1] = 8);
			array2 = obj96;
			instance2 = NewLateBinding.LateGet(instance122, null, "Cells", obj96, null, null, array3 = new bool[2] { true, false });
			if (array3[0])
			{
				num73 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
			}
			array85[1] = instance2;
			array4 = array85;
			obj8 = NewLateBinding.LateGet(instance120, null, "Range", array85, null, null, array5 = new bool[2] { true, true });
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(obj4, null, "Cells", new object[3]
				{
					obj7,
					instance4,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array5[1])
			{
				NewLateBinding.LateSetComplex(obj14, null, "Cells", new object[3]
				{
					num67,
					obj5,
					array4[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			range = (Range)obj8;
			range.Select();
			obj95 = null;
			ExcelModule.formatBorder(_xlApp);
			object obj97 = _xlApp.Sheets[1];
			object instance123 = obj97;
			object[] array87 = new object[2];
			object instance124 = (obj5 = obj97);
			object[] obj98 = new object[2]
			{
				num67 = num68,
				null
			};
			obj14 = (obj98[1] = 3);
			array2 = obj98;
			obj8 = NewLateBinding.LateGet(instance124, null, "Cells", obj98, null, null, array3 = new bool[2] { true, false });
			if (array3[0])
			{
				num68 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
			}
			array87[0] = obj8;
			object instance125 = (instance4 = obj97);
			object[] obj99 = new object[2]
			{
				num8 = num73,
				null
			};
			obj7 = (obj99[1] = 7);
			array2 = obj99;
			obj8 = NewLateBinding.LateGet(instance125, null, "Cells", obj99, null, null, array3 = new bool[2] { true, false });
			if (array3[0])
			{
				num73 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
			}
			array87[1] = obj8;
			array4 = array87;
			obj4 = NewLateBinding.LateGet(instance123, null, "Range", array87, null, null, array5 = new bool[2] { true, true });
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(obj5, null, "Cells", new object[3]
				{
					num67,
					obj14,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array5[1])
			{
				NewLateBinding.LateSetComplex(instance4, null, "Cells", new object[3]
				{
					num8,
					obj7,
					array4[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			range = (Range)obj4;
			range.Select();
			obj97 = null;
			NewLateBinding.LateSetComplex(_xlApp.Selection, null, "HorizontalAlignment", new object[1] { XlHAlign.xlHAlignRight }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(_xlApp.Selection, null, "NumberFormat", new object[1] { "#,##0" }, null, null, OptimisticSet: false, RValueBase: true);
			object obj100 = _xlApp.Sheets[1];
			object instance126 = obj100;
			object[] array88 = new object[2];
			object instance127 = (obj7 = obj100);
			object[] obj101 = new object[2]
			{
				num8 = num68,
				null
			};
			instance4 = (obj101[1] = 8);
			array2 = obj101;
			obj8 = NewLateBinding.LateGet(instance127, null, "Cells", obj101, null, null, array3 = new bool[2] { true, false });
			if (array3[0])
			{
				num68 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
			}
			array88[0] = obj8;
			object instance128 = (obj14 = obj100);
			object[] obj102 = new object[2]
			{
				num67 = num73,
				null
			};
			obj5 = (obj102[1] = 8);
			array2 = obj102;
			obj8 = NewLateBinding.LateGet(instance128, null, "Cells", obj102, null, null, array3 = new bool[2] { true, false });
			if (array3[0])
			{
				num73 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
			}
			array88[1] = obj8;
			array4 = array88;
			obj4 = NewLateBinding.LateGet(instance126, null, "Range", array88, null, null, array5 = new bool[2] { true, true });
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(obj7, null, "Cells", new object[3]
				{
					num8,
					instance4,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array5[1])
			{
				NewLateBinding.LateSetComplex(obj14, null, "Cells", new object[3]
				{
					num67,
					obj5,
					array4[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			range = (Range)obj4;
			range.Select();
			obj100 = null;
			NewLateBinding.LateSetComplex(_xlApp.Selection, null, "HorizontalAlignment", new object[1] { XlHAlign.xlHAlignRight }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(_xlApp.Selection, null, "NumberFormat", new object[1] { "0%" }, null, null, OptimisticSet: false, RValueBase: true);
			object obj103 = _xlApp.Sheets[1];
			object instance129 = obj103;
			object[] array89 = new object[2];
			object instance130 = (obj5 = obj103);
			object[] array90 = new object[2];
			obj14 = (array90[0] = num6 - 2);
			instance4 = (array90[1] = 3);
			array89[0] = NewLateBinding.LateGet(instance130, null, "Cells", array90, null, null, null);
			object instance131 = (obj7 = obj103);
			object[] array91 = new object[2];
			obj4 = (array91[0] = num6 - 2);
			array91[1] = (num67 = num5);
			array2 = array91;
			instance2 = NewLateBinding.LateGet(instance131, null, "Cells", array91, null, null, array3 = new bool[2] { false, true });
			if (array3[1])
			{
				num5 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
			}
			array89[1] = instance2;
			array4 = array89;
			obj8 = NewLateBinding.LateGet(instance129, null, "Range", array89, null, null, array5 = new bool[2] { true, true });
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(obj5, null, "Cells", new object[3]
				{
					obj14,
					instance4,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array5[1])
			{
				NewLateBinding.LateSetComplex(obj7, null, "Cells", new object[3]
				{
					obj4,
					num67,
					array4[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			range = (Range)obj8;
			range.Select();
			obj103 = null;
			NewLateBinding.LateCall(_xlApp.Selection, null, "ClearContents", new object[0], null, null, null, IgnoreReturn: true);
			num68 = num68 + num69 + 2;
			ProgressBar1.Value = 95;
			num = num73 + 3;
			num68 = num;
			num76 = 3;
			_xlApp.Cells[num68 - 1, 2] = "BUNGA/ESSEN";
			_xlApp.Cells[num68 - 1, 3] = "Monthly Avg (Kg)";
			_xlApp.Cells[num68 - 1, 4] = "Daily Avg (Kg)";
			_xlApp.Cells[num68 - 1, 7] = "Avg per " + Strings.Format(datReport, "dd-MMM-yyyy");
			num69 = 0;
			num9 = 0;
			int num80 = num51;
			int num81 = num55;
			for (int i = num80; i <= num81; i += 2)
			{
				string text4 = ExcelModule.ReadCell((Range)_xlApp.Cells[num34 - 1, i + 1]);
				if (Strings.InStr(text4, "EJ") == 0)
				{
					_xlApp.Cells[num68 + num69, 2] = Operators.ConcatenateObject("=", NewLateBinding.LateGet(_xlApp.Cells[num34 - 1, i + 1], null, "Address", new object[2] { false, false }, null, null, null));
					_xlApp.Cells[num68 + num69, 3] = Operators.ConcatenateObject("=", NewLateBinding.LateGet(_xlApp.Cells[num44 + 2, i + 1], null, "Address", new object[2] { false, false }, null, null, null));
					_xlApp.Cells[num68 + num69, 4] = Operators.ConcatenateObject(Operators.ConcatenateObject("=", NewLateBinding.LateGet(_xlApp.Cells[num68 + num69, 3], null, "Address", new object[2] { false, false }, null, null, null)), "/30");
					if (Strings.InStr(text4, "Bunga") > 0)
					{
						text = Strings.Format(DateAndTime.DateAdd("d", -30.0, datReport), "yyyy-MM-dd");
						text3 = " SELECT SUM(iiMainQty) as qty  FROM purchaseinvoices a, purchaseinvoices_items b, items c  WHERE a.invId = b.invId  AND b.itemId = c.itemId  AND c.itemName = '" + text4 + "' AND invDate >= '" + text + "' AND invDate < '" + text2 + "' ";
						dataTable = Module1.sqlTable(text3, "data", Clone: false);
						if (dataTable.Rows.Count > 0)
						{
							_xlApp.Cells[num68 + num69, 7] = "=" + Module1.unformatNumber(Conversions.ToString(dataTable.Rows[0]["qty"])) + "/30";
						}
					}
					else
					{
						double stock = cStock.getStock((int)Math.Round(cItem.GetItemId(text4)), Module1.pubBalanceDate, datReport, "Good", 0, Module1.pubGroupId, Module1.pubBranchId, Module1.pubReportUseNewGetStockCode);
						_xlApp.Cells[num68 + num69, 7] = stock;
					}
					num69++;
				}
				num9++;
			}
			num73 = num68 + num69 - 1;
			object obj104 = _xlApp.Sheets[1];
			object instance132 = obj104;
			object[] array92 = new object[2];
			object instance133 = (obj4 = obj104);
			object[] array93 = new object[2];
			obj7 = (array93[0] = num68 - 1);
			instance4 = (array93[1] = 2);
			array92[0] = NewLateBinding.LateGet(instance133, null, "Cells", array93, null, null, null);
			object instance134 = (obj14 = obj104);
			object[] obj105 = new object[2]
			{
				num67 = num73,
				null
			};
			obj5 = (obj105[1] = 8);
			array2 = obj105;
			instance2 = NewLateBinding.LateGet(instance134, null, "Cells", obj105, null, null, array3 = new bool[2] { true, false });
			if (array3[0])
			{
				num73 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
			}
			array92[1] = instance2;
			array4 = array92;
			obj8 = NewLateBinding.LateGet(instance132, null, "Range", array92, null, null, array5 = new bool[2] { true, true });
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(obj4, null, "Cells", new object[3]
				{
					obj7,
					instance4,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array5[1])
			{
				NewLateBinding.LateSetComplex(obj14, null, "Cells", new object[3]
				{
					num67,
					obj5,
					array4[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			range = (Range)obj8;
			range.Select();
			obj104 = null;
			ExcelModule.formatBorder(_xlApp);
			object obj106 = _xlApp.Sheets[1];
			object instance135 = obj106;
			object[] array94 = new object[2];
			object instance136 = (obj5 = obj106);
			object[] obj107 = new object[2]
			{
				num67 = num68,
				null
			};
			obj14 = (obj107[1] = 3);
			array2 = obj107;
			obj8 = NewLateBinding.LateGet(instance136, null, "Cells", obj107, null, null, array3 = new bool[2] { true, false });
			if (array3[0])
			{
				num68 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
			}
			array94[0] = obj8;
			object instance137 = (instance4 = obj106);
			object[] obj108 = new object[2]
			{
				num8 = num73,
				null
			};
			obj7 = (obj108[1] = 7);
			array2 = obj108;
			obj8 = NewLateBinding.LateGet(instance137, null, "Cells", obj108, null, null, array3 = new bool[2] { true, false });
			if (array3[0])
			{
				num73 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
			}
			array94[1] = obj8;
			array4 = array94;
			obj4 = NewLateBinding.LateGet(instance135, null, "Range", array94, null, null, array5 = new bool[2] { true, true });
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(obj5, null, "Cells", new object[3]
				{
					num67,
					obj14,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array5[1])
			{
				NewLateBinding.LateSetComplex(instance4, null, "Cells", new object[3]
				{
					num8,
					obj7,
					array4[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			range = (Range)obj4;
			range.Select();
			obj106 = null;
			NewLateBinding.LateSetComplex(_xlApp.Selection, null, "HorizontalAlignment", new object[1] { XlHAlign.xlHAlignRight }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(_xlApp.Selection, null, "NumberFormat", new object[1] { "#,##0" }, null, null, OptimisticSet: false, RValueBase: true);
			object obj109 = _xlApp.Sheets[1];
			object instance138 = obj109;
			object[] array95 = new object[2];
			object instance139 = (obj7 = obj109);
			object[] obj110 = new object[2]
			{
				num8 = num68,
				null
			};
			instance4 = (obj110[1] = 8);
			array2 = obj110;
			obj8 = NewLateBinding.LateGet(instance139, null, "Cells", obj110, null, null, array3 = new bool[2] { true, false });
			if (array3[0])
			{
				num68 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
			}
			array95[0] = obj8;
			object instance140 = (obj14 = obj109);
			object[] obj111 = new object[2]
			{
				num67 = num73,
				null
			};
			obj5 = (obj111[1] = 8);
			array2 = obj111;
			obj8 = NewLateBinding.LateGet(instance140, null, "Cells", obj111, null, null, array3 = new bool[2] { true, false });
			if (array3[0])
			{
				num73 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
			}
			array95[1] = obj8;
			array4 = array95;
			obj4 = NewLateBinding.LateGet(instance138, null, "Range", array95, null, null, array5 = new bool[2] { true, true });
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(obj7, null, "Cells", new object[3]
				{
					num8,
					instance4,
					array4[0]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			if (array5[1])
			{
				NewLateBinding.LateSetComplex(obj14, null, "Cells", new object[3]
				{
					num67,
					obj5,
					array4[1]
				}, null, null, OptimisticSet: true, RValueBase: true);
			}
			range = (Range)obj4;
			range.Select();
			obj109 = null;
			NewLateBinding.LateSetComplex(_xlApp.Selection, null, "HorizontalAlignment", new object[1] { XlHAlign.xlHAlignRight }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(_xlApp.Selection, null, "NumberFormat", new object[1] { "0%" }, null, null, OptimisticSet: false, RValueBase: true);
			num68 = num68 + num69 + 2;
			ProgressBar1.Value = 100;
			_xlApp.Cells.Select();
			NewLateBinding.LateCall(NewLateBinding.LateGet(_xlApp.Selection, null, "Columns", new object[0], null, null, null), null, "AutoFit", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateCall(_xlApp.Cells[1, 1], null, "Select", new object[0], null, null, null, IgnoreReturn: true);
			DisplayOrSave(datReport, strType, SaveToFile);
		}
	}

	private void DisplayOrSave(DateTime ReportDate, string ReportType, bool SaveToFile)
	{
		if (!SaveToFile)
		{
			Module1.MinimiseAllWindows();
			_xlApp.Visible = true;
			_xlApp.WindowState = XlWindowState.xlMaximized;
			return;
		}
		Module1.SaveDebug("Save to File - start");
		_xlApp.DisplayAlerts = false;
		string text = ((Operators.CompareString(ReportType, "TEH", TextCompare: false) != 0) ? ("\\kebutuhan-bahan-KEMASAN-" + Strings.Format(ReportDate, "dd-MMMM-yyyy") + ".xls") : ("\\kebutuhan-bahan-TEH-" + Strings.Format(ReportDate, "dd-MMMM-yyyy") + ".xls"));
		_xlWb.SaveAs(Module1.pubReportPredictionPath + text, XlFileFormat.xlWorkbookNormal, "", "", false, false, XlSaveAsAccessMode.xlNoChange, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
		_xlApp.DisplayAlerts = true;
		_xlWb.Close(false, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
		_xlApp.Quit();
	}

	private string getStockFromExcel(Excel.Application xlApp, string strItem, int intItemNameRow, int intItemStockRow, int intFromCol, int intToCol)
	{
		string result = "";
		for (int i = intFromCol; i <= intToCol; i = checked(i + 1))
		{
			if (Operators.CompareString(ExcelModule.ReadCell((Range)xlApp.Cells[intItemNameRow, i]), strItem, TextCompare: false) == 0)
			{
				result = Conversions.ToString(Operators.ConcatenateObject("=", NewLateBinding.LateGet(xlApp.Cells[intItemStockRow, i], null, "Address", new object[2] { false, false }, null, null, null)));
				break;
			}
		}
		return result;
	}

	private void btnReset_Click(object sender, EventArgs e)
	{
		PrepareForm();
	}
}
