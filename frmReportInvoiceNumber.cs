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
public class frmReportInvoiceNumber : Form
{
	private IContainer components;

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
	[AccessedThroughProperty("cboBranch")]
	private ComboBox _cboBranch;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboType")]
	private ComboBox _cboType;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvList")]
	private DataGridView _dgvList;

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

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox cboType
	{
		[CompilerGenerated]
		get
		{
			return _cboType;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cboType_SelectedIndexChanged;
			ComboBox comboBox = _cboType;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_cboType = value;
			comboBox = _cboType;
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboYear")]
	internal virtual ComboBox cboYear
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
			DataGridView dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.KeyDown -= value2;
				dataGridView.GotFocus -= value3;
				dataGridView.LostFocus -= value4;
			}
			_dgvList = value;
			dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.KeyDown += value2;
				dataGridView.GotFocus += value3;
				dataGridView.LostFocus += value4;
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
		this.btnSearch = new System.Windows.Forms.Button();
		this.btnReset = new System.Windows.Forms.Button();
		this.Label7 = new System.Windows.Forms.Label();
		this.cboBranch = new System.Windows.Forms.ComboBox();
		this.Label6 = new System.Windows.Forms.Label();
		this.cboType = new System.Windows.Forms.ComboBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.cboYear = new System.Windows.Forms.ComboBox();
		this.cboSalesPerson = new System.Windows.Forms.ComboBox();
		this.dgvList = new System.Windows.Forms.DataGridView();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		base.SuspendLayout();
		this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSearch.Location = new System.Drawing.Point(74, 120);
		this.btnSearch.Name = "btnSearch";
		this.btnSearch.Size = new System.Drawing.Size(47, 24);
		this.btnSearch.TabIndex = 11;
		this.btnSearch.Text = "&Cari";
		this.btnSearch.UseVisualStyleBackColor = true;
		this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnReset.Location = new System.Drawing.Point(127, 120);
		this.btnReset.Name = "btnReset";
		this.btnReset.Size = new System.Drawing.Size(47, 24);
		this.btnReset.TabIndex = 12;
		this.btnReset.Text = "&Reset";
		this.btnReset.UseVisualStyleBackColor = true;
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.Location = new System.Drawing.Point(10, 42);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(44, 13);
		this.Label7.TabIndex = 65;
		this.Label7.Text = "Cabang";
		this.cboBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboBranch.FormattingEnabled = true;
		this.cboBranch.Location = new System.Drawing.Point(73, 39);
		this.cboBranch.Name = "cboBranch";
		this.cboBranch.Size = new System.Drawing.Size(120, 21);
		this.cboBranch.TabIndex = 1;
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.Location = new System.Drawing.Point(10, 15);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(61, 13);
		this.Label6.TabIndex = 64;
		this.Label6.Text = "Tipe Faktur";
		this.cboType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboType.FormattingEnabled = true;
		this.cboType.Location = new System.Drawing.Point(73, 12);
		this.cboType.Name = "cboType";
		this.cboType.Size = new System.Drawing.Size(120, 21);
		this.cboType.TabIndex = 0;
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(10, 95);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(38, 13);
		this.Label4.TabIndex = 63;
		this.Label4.Text = "Tahun";
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(10, 69);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(33, 13);
		this.Label3.TabIndex = 62;
		this.Label3.Text = "Sales";
		this.cboYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboYear.FormattingEnabled = true;
		this.cboYear.Location = new System.Drawing.Point(73, 93);
		this.cboYear.Name = "cboYear";
		this.cboYear.Size = new System.Drawing.Size(120, 21);
		this.cboYear.TabIndex = 3;
		this.cboSalesPerson.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboSalesPerson.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboSalesPerson.FormattingEnabled = true;
		this.cboSalesPerson.Location = new System.Drawing.Point(73, 66);
		this.cboSalesPerson.Name = "cboSalesPerson";
		this.cboSalesPerson.Size = new System.Drawing.Size(120, 21);
		this.cboSalesPerson.TabIndex = 2;
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.Location = new System.Drawing.Point(210, 12);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(471, 362);
		this.dgvList.TabIndex = 13;
		base.AcceptButton = this.btnSearch;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(695, 386);
		base.Controls.Add(this.btnSearch);
		base.Controls.Add(this.btnReset);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.cboBranch);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.cboType);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.cboYear);
		base.Controls.Add(this.cboSalesPerson);
		base.Controls.Add(this.dgvList);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmReportInvoiceNumber";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Report Nomer Faktur";
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmReportInvoiceNumber()
	{
		base.KeyDown += frmReportInvoiceNumber_KeyDown;
		base.Load += frmReportInvoiceNumber_Load;
		InitializeComponent();
		base.MdiParent = MyProject.Forms.frmMenu;
		ComboBox combo = cboYear;
		cCombo.getYear(ref combo, blnAll: false, checked(DateAndTime.Year(DateAndTime.Now) - 1), 0);
		cboYear = combo;
		combo = cboType;
		cCombo.getReportInvoiceNumberFilter(ref combo);
		cboType = combo;
	}

	private void frmReportInvoiceNumber_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void frmReportInvoiceNumber_Load(object sender, EventArgs e)
	{
		DoubleBuffered = true;
		prepareForm();
	}

	private void prepareForm()
	{
		ComboBox combo = cboBranch;
		bool branch = cCombo.getBranch(ref combo, Module1.pubGroupId, blnAll: false);
		cboBranch = combo;
		if (!branch)
		{
			cboBranch.Enabled = false;
		}
		cboBranch.SelectedIndex = 0;
		cboSalesPerson.SelectedIndex = 0;
		cboYear.SelectedIndex = 1;
		cboType.SelectedIndex = 0;
		cboType.Focus();
	}

	private void cboBranch_SelectedIndexChanged(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboBranch.SelectedItem;
		cboSalesPerson.Text = "";
		ComboBox combo = cboSalesPerson;
		cCombo.getSalesPerson(ref combo, "SALESPERSON", 0, 0, Conversions.ToInteger(cComboItem2.Value), Module1.pubGroupId, All: false, Dash: false, 1);
		cboSalesPerson = combo;
		cboSalesPerson.SelectedIndex = 0;
	}

	private void cboType_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (cboType.SelectedIndex == 0)
		{
			cboSalesPerson.Enabled = true;
		}
		else
		{
			cboSalesPerson.Enabled = false;
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
					cComboItem cComboItem3 = (cComboItem)cboSalesPerson.SelectedItem;
					cComboItem cComboItem4 = (cComboItem)cboYear.SelectedItem;
					cComboItem cComboItem5 = (cComboItem)cboType.SelectedItem;
					if (cboType.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih tipe faktur.", MsgBoxStyle.Information);
						cboType.Focus();
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
						Interaction.MsgBox("Pilih sales.", MsgBoxStyle.Information);
						cboSalesPerson.Focus();
						goto end_IL_0001;
					}
					if (cboYear.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih tahun.", MsgBoxStyle.Information);
						cboYear.Focus();
						goto end_IL_0001;
					}
					Cursor = Cursors.WaitCursor;
					DataTable dataTable = new DataTable();
					btnSearch.Focus();
					formatGrid();
					if (cboType.SelectedIndex == 0)
					{
						getFutureInvoiceNumber(Conversions.ToInteger(cComboItem3.Value), Module1.pubGroupId, Conversions.ToInteger(cComboItem2.Value), Conversions.ToInteger(cComboItem4.Value), UseDeleted: true);
					}
					else
					{
						getFutureTaxInvoiceNumber(Conversions.ToInteger(cComboItem3.Value), Conversions.ToInteger(cComboItem4.Value), Conversions.ToInteger(cComboItem2.Value));
					}
					if (dgvList.RowCount == 0)
					{
						Interaction.MsgBox("Data tidak ditemukan", MsgBoxStyle.Information);
						cboType.Focus();
					}
					else
					{
						dgvList.Focus();
					}
					Cursor = Cursors.Default;
					goto end_IL_0001;
				}
				case 553:
					num = -1;
					switch (num2)
					{
					case 2:
						Cursor = Cursors.Default;
						Module1.SaveError(Information.Err(), "frmReportInvoiceNumber", "btnSearch_click", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 553;
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
		dgvList.Columns.Add("", "Nomer");
		dgvList.Columns.Add("", "Keterangan");
		dgvList.Columns[0].Width = 140;
		dgvList.Columns[1].Width = 300;
		dgvList.RowHeadersVisible = false;
		dgvList.AllowUserToAddRows = false;
		dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvList.ReadOnly = true;
		dgvList.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvList.AllowUserToResizeRows = false;
		DataGridView grid = dgvList;
		Module1.DisableGridSorting(ref grid);
		dgvList = grid;
	}

	private void dgvList_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			e.SuppressKeyPress = true;
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			btnSearch.Focus();
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			cboType.Focus();
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

	private void btnReset_Click(object sender, EventArgs e)
	{
		prepareForm();
	}

	public void getFutureInvoiceNumber(int SalesPersonId, int GroupId, int BranchId, int Year, bool UseDeleted)
	{
		string strSql = " SELECT * FROM SALES  WHERE salesId = " + Conversions.ToString(SalesPersonId);
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (Operators.ConditionalCompareObjectEqual(dataTable.Rows[0]["salesFakNo"], "", TextCompare: false))
		{
			dgvList.Rows.Add("-", "Kode awal sales belum diset");
			return;
		}
		string text = Conversions.ToString(dataTable.Rows[0]["salesFakNo"]);
		strSql = " SELECT fakturLatestNo FROM fakturLatest  WHERE fakturType = 1  AND fakturYear = " + Conversions.ToString(Year) + " AND salesId = " + Conversions.ToString(SalesPersonId);
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		double num = default(double);
		if (dataTable.Rows.Count > 0)
		{
			num = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["fakturLatestNo"])) + 1.0;
		}
		checked
		{
			int num2 = default(int);
			if (UseDeleted)
			{
				strSql = " select * from fakturDeleted  where fdType = 1  and FakturYear = " + Conversions.ToString(Year) + "  AND branchId = " + Conversions.ToString(BranchId) + " order by fs ";
				dataTable = Module1.sqlTable(strSql, "data", Clone: false);
				foreach (DataRow row in dataTable.Rows)
				{
					strSql = " select * from FakturSales  where salesId = " + Conversions.ToString(SalesPersonId) + "  and CONVERT(fsBegin,SIGNED) <= " + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(row["fs"]))) + "  and CONVERT(fsEnd,SIGNED) >= " + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(row["fs"]))) + "  and FakturYear = " + Conversions.ToString(Year) + " ";
					DataTable dataTable2 = Module1.sqlTable(strSql, "data", Clone: false);
					if (dataTable2.Rows.Count > 0)
					{
						dgvList.Rows.Add(text + Module1.FormatInvoiceNumber(Conversions.ToString(row["fs"])), "Tersedia (berasal dari Faktur yang dihapus)");
						num2++;
					}
				}
			}
			while (num2 <= 50)
			{
				strSql = " select * from FakturSales  where salesId = " + Conversions.ToString(SalesPersonId) + "  and CONVERT(fsBegin,SIGNED) <= " + Conversions.ToString(num) + "  and CONVERT(fsEnd,SIGNED) >= " + Conversions.ToString(num) + "  and FakturYear = " + Conversions.ToString(Year);
				dataTable = Module1.sqlTable(strSql, "data", Clone: false);
				if (dataTable.Rows.Count == 0)
				{
					strSql = " select * from FakturSales  where salesId = " + Conversions.ToString(SalesPersonId) + "  and CONVERT(fsBegin,SIGNED) > " + Conversions.ToString(num) + "  and FakturYear = " + Conversions.ToString(Year) + " order by CONVERT(fsBegin,SIGNED) ";
					dataTable = Module1.sqlTable(strSql, "data", Clone: false);
					bool flag;
					if (dataTable.Rows.Count == 0)
					{
						flag = false;
					}
					else
					{
						num = Conversions.ToDouble(dataTable.Rows[0]["fsBegin"]);
						flag = true;
					}
					string text2;
					if (!flag)
					{
						text2 = text + Module1.FormatInvoiceNumber(Conversion.Str(num));
						dgvList.Rows.Add(text2, "Tidak tersedia (No faktur tidak termasuk di range)");
						num2++;
						break;
					}
					text2 = text + Module1.FormatInvoiceNumber(Conversion.Str(num));
					strSql = " select penjFaktur from penjualan  where penjFaktur = '" + text2 + "'  and year(penjDate) = " + Conversions.ToString(Year);
					dataTable = Module1.sqlTable(strSql, "data", Clone: false);
					if (dataTable.Rows.Count == 0)
					{
						dgvList.Rows.Add(text2, "Tersedia");
					}
					else
					{
						dgvList.Rows.Add(text2, "Tidak tersedia (No faktur telah dipakai)");
					}
					num2++;
					num += 1.0;
				}
				else
				{
					string text2 = text + Module1.FormatInvoiceNumber(Conversion.Str(num));
					strSql = " select penjFaktur from penjualan  where penjFaktur = '" + text2 + "'  and year(penjDate) = " + Conversions.ToString(Year);
					dataTable = Module1.sqlTable(strSql, "data", Clone: false);
					if (dataTable.Rows.Count == 0)
					{
						dgvList.Rows.Add(text2, "Tersedia");
					}
					else
					{
						dgvList.Rows.Add(text2, "Tidak tersedia (No faktur telah dipakai)");
					}
					num2++;
					num += 1.0;
				}
			}
		}
	}

	private void getFutureTaxInvoiceNumber(int intSales, int Year, int intBranchId)
	{
		string strSql = " SELECT * FROM fakturDeleted  WHERE fdType = 2  AND FakturYear = " + Conversions.ToString(Year) + " AND branchId = " + Conversions.ToString(intBranchId) + " ORDER BY fs ";
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		checked
		{
			int i = default(int);
			foreach (DataRow row in dataTable.Rows)
			{
				strSql = " SELECT * FROM FakturPajak  WHERE CONVERT(fsBegin,SIGNED) <= " + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(row["fs"]))) + "  and CONVERT(fsEnd,SIGNED) >= " + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(row["fs"]))) + "  and FakturYear = " + Conversions.ToString(Year) + " and branchId = (select branchId from sales where salesId=" + Conversions.ToString(intSales) + ") ";
				DataTable dataTable2 = Module1.sqlTable(strSql, "data", Clone: true);
				if (dataTable2.Rows.Count > 0)
				{
					dgvList.Rows.Add(Module1.FormatInvoiceNumber(Conversions.ToString(row["fs"])), "Tersedia (berasal dari faktur yang dihapus)");
					i++;
				}
			}
			strSql = " SELECT fakturLatestNo FROM fakturLatest  WHERE fakturType = 2  AND fakturYear = " + Conversions.ToString(Year) + " AND branchId = ( SELECT branchId FROM Sales WHERE salesId = " + Conversions.ToString(intSales) + ")";
			dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			double num = default(double);
			if (dataTable.Rows.Count > 0)
			{
				num = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["fakturLatestNo"])) + 1.0;
			}
			for (; i <= 50; i++)
			{
				strSql = " select * from FakturPajak  where CONVERT(fsBegin,SIGNED) <= " + Conversions.ToString(num) + "  and CONVERT(fsEnd,SIGNED) >= " + Conversions.ToString(num) + "  and FakturYear = " + Conversions.ToString(Year) + " and branchId = (select branchId from sales where salesId=" + Conversions.ToString(intSales) + ") ";
				dataTable = Module1.sqlTable(strSql, "data", Clone: false);
				if (dataTable.Rows.Count == 0)
				{
					strSql = " select * from FakturPajak  where CONVERT(fsBegin,SIGNED) > " + Conversions.ToString(num) + "  and FakturYear = " + Conversions.ToString(Year) + " and branchId = (select branchId from sales where salesId=" + Conversions.ToString(intSales) + ")  order by CONVERT(fsBegin,SIGNED) ";
					dataTable = Module1.sqlTable(strSql, "data", Clone: false);
					if (dataTable.Rows.Count == 0)
					{
						dgvList.Rows.Add(Module1.FormatInvoiceNumber(Conversions.ToString(num)), "Tidak tersedia (tidak ada di range)");
						num = 0.0;
						i++;
					}
					else
					{
						num = Conversions.ToDouble(dataTable.Rows[0]["fsBegin"]);
					}
				}
				if (num == 0.0)
				{
					bool flag = true;
					break;
				}
				strSql = " SELECT penjFP FROM penjualan  WHERE penjFP = " + Conversions.ToString(num) + "  AND YEAR(penjDateFp) = " + Conversions.ToString(Year) + " UNION ALL  SELECT fs FROM fakturBL  WHERE CONVERT(fs,SIGNED) = " + Conversions.ToString(num) + "  AND FakturYear = " + Conversions.ToString(Year);
				dataTable = Module1.sqlTable(strSql, "data", Clone: false);
				if (dataTable.Rows.Count == 0)
				{
					bool flag = true;
					dgvList.Rows.Add(Module1.FormatInvoiceNumber(Conversions.ToString(num)), "Tersedia");
				}
				else
				{
					dgvList.Rows.Add(Module1.FormatInvoiceNumber(Conversions.ToString(num)), "Tidak tersedia (sudah dipakai atau ada di-blacklist)");
				}
				num += 1.0;
			}
		}
	}
}
