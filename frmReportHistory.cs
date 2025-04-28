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
public class frmReportHistory : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnWord")]
	private Button _btnWord;

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

	[field: AccessedThroughProperty("lblTotal")]
	internal virtual Label lblTotal
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

	[field: AccessedThroughProperty("cboUser")]
	internal virtual ComboBox cboUser
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboHistoryType")]
	internal virtual ComboBox cboHistoryType
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
		this.btnWord = new System.Windows.Forms.Button();
		this.lblTotal = new System.Windows.Forms.Label();
		this.btnSearch = new System.Windows.Forms.Button();
		this.btnReset = new System.Windows.Forms.Button();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.cboUser = new System.Windows.Forms.ComboBox();
		this.dgvList = new System.Windows.Forms.DataGridView();
		this.Label2 = new System.Windows.Forms.Label();
		this.dtpEnd = new System.Windows.Forms.DateTimePicker();
		this.dtpBegin = new System.Windows.Forms.DateTimePicker();
		this.Label3 = new System.Windows.Forms.Label();
		this.cboHistoryType = new System.Windows.Forms.ComboBox();
		this.btnPrint = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		base.SuspendLayout();
		this.btnWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnWord.Location = new System.Drawing.Point(820, 452);
		this.btnWord.Name = "btnWord";
		this.btnWord.Size = new System.Drawing.Size(73, 23);
		this.btnWord.TabIndex = 14;
		this.btnWord.Text = "&Word";
		this.btnWord.UseVisualStyleBackColor = true;
		this.lblTotal.AutoSize = true;
		this.lblTotal.Location = new System.Drawing.Point(235, 457);
		this.lblTotal.Name = "lblTotal";
		this.lblTotal.Size = new System.Drawing.Size(91, 13);
		this.lblTotal.TabIndex = 93;
		this.lblTotal.Text = "Total Pencarian: -";
		this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSearch.Location = new System.Drawing.Point(100, 121);
		this.btnSearch.Name = "btnSearch";
		this.btnSearch.Size = new System.Drawing.Size(47, 24);
		this.btnSearch.TabIndex = 11;
		this.btnSearch.Text = "&Cari";
		this.btnSearch.UseVisualStyleBackColor = true;
		this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnReset.Location = new System.Drawing.Point(153, 121);
		this.btnReset.Name = "btnReset";
		this.btnReset.Size = new System.Drawing.Size(47, 24);
		this.btnReset.TabIndex = 12;
		this.btnReset.Text = "&Reset";
		this.btnReset.UseVisualStyleBackColor = true;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(10, 15);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(71, 13);
		this.Label1.TabIndex = 92;
		this.Label1.Text = "Tanggal awal";
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.Location = new System.Drawing.Point(12, 67);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(29, 13);
		this.Label7.TabIndex = 91;
		this.Label7.Text = "User";
		this.cboUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboUser.FormattingEnabled = true;
		this.cboUser.Location = new System.Drawing.Point(100, 64);
		this.cboUser.Name = "cboUser";
		this.cboUser.Size = new System.Drawing.Size(121, 21);
		this.cboUser.TabIndex = 2;
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.Location = new System.Drawing.Point(238, 12);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(734, 434);
		this.dgvList.TabIndex = 13;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(10, 41);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(72, 13);
		this.Label2.TabIndex = 90;
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
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(12, 94);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(31, 13);
		this.Label3.TabIndex = 95;
		this.Label3.Text = "Jenis";
		this.cboHistoryType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboHistoryType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboHistoryType.FormattingEnabled = true;
		this.cboHistoryType.Location = new System.Drawing.Point(100, 91);
		this.cboHistoryType.Name = "cboHistoryType";
		this.cboHistoryType.Size = new System.Drawing.Size(121, 21);
		this.cboHistoryType.TabIndex = 3;
		this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnPrint.Location = new System.Drawing.Point(899, 452);
		this.btnPrint.Name = "btnPrint";
		this.btnPrint.Size = new System.Drawing.Size(73, 23);
		this.btnPrint.TabIndex = 15;
		this.btnPrint.Text = "Cetak";
		this.btnPrint.UseVisualStyleBackColor = true;
		base.AcceptButton = this.btnSearch;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(984, 483);
		base.Controls.Add(this.btnPrint);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.cboHistoryType);
		base.Controls.Add(this.btnWord);
		base.Controls.Add(this.lblTotal);
		base.Controls.Add(this.btnSearch);
		base.Controls.Add(this.btnReset);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.cboUser);
		base.Controls.Add(this.dgvList);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.dtpEnd);
		base.Controls.Add(this.dtpBegin);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmReportHistory";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Report History";
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmReportHistory()
	{
		base.Load += frmReportCollector_Load;
		base.KeyDown += frmReportCollector_KeyDown;
		InitializeComponent();
		base.MdiParent = MyProject.Forms.frmMenu;
		FormatGrid();
	}

	private void frmReportCollector_Load(object sender, EventArgs e)
	{
		prepareForm();
	}

	private void frmReportCollector_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void prepareForm()
	{
		btnWord.Enabled = false;
		btnPrint.Enabled = false;
		dtpBegin.Value = Module1.getFirstDateInMonth(DateAndTime.Now);
		dtpEnd.Value = DateAndTime.Now;
		ComboBox combo = cboUser;
		cCombo.getUser(ref combo, All: true, 1);
		cboUser = combo;
		cboUser.SelectedIndex = 0;
		combo = cboHistoryType;
		cCombo.getHistoryType(ref combo, All: true);
		cboHistoryType = combo;
		cboHistoryType.SelectedIndex = 0;
		dgvList.DataSource = null;
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
					cComboItem cComboItem2 = (cComboItem)cboUser.SelectedItem;
					cComboItem cComboItem3 = (cComboItem)cboHistoryType.SelectedItem;
					if (cboUser.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih user.", MsgBoxStyle.Information);
						cboUser.Focus();
						goto end_IL_0001;
					}
					if (cboHistoryType.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih tipe.", MsgBoxStyle.Information);
						cboHistoryType.Focus();
						goto end_IL_0001;
					}
					DataTable dataTable = new DataTable();
					btnSearch.Focus();
					Cursor = Cursors.WaitCursor;
					dataTable = cHistory.Search(dtpBegin.Value, dtpEnd.Value, cboUser.Text, Conversions.ToInteger(cComboItem3.Value));
					FormatGrid();
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						dgvList.Rows.Add(dataRow["histTypeId"], dataRow["fkeyId"], dataRow["histDate"], dataRow["activity"]);
						if (Strings.InStr(1, Conversions.ToString(dataRow["activity"]), "menghapus") > 0)
						{
							dgvList.Rows[checked(dgvList.RowCount - 1)].DefaultCellStyle.BackColor = Color.Red;
						}
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					dgvList.Focus();
					if (dataTable.Rows.Count == 0)
					{
						Interaction.MsgBox("Data tidak ditemukan", MsgBoxStyle.Information);
						btnWord.Enabled = false;
						btnPrint.Enabled = false;
						dtpBegin.Focus();
					}
					else
					{
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
				case 711:
					num = -1;
					switch (num2)
					{
					case 2:
						Cursor = Cursors.Default;
						Module1.SaveError(Information.Err(), "frmReportCollector", "btnSearch_click", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 711;
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
		dgvList.Columns.Clear();
		dgvList.Rows.Clear();
		dgvList.Columns.Add("", "histTypeId");
		dgvList.Columns.Add("", "fkeyId");
		dgvList.Columns.Add("", "Tanggal");
		dgvList.Columns.Add("", "Keterangan");
		dgvList.Columns[0].Visible = false;
		dgvList.Columns[1].Visible = false;
		dgvList.Columns[2].Width = 120;
		dgvList.Columns[3].Width = 593;
		dgvList.RowHeadersVisible = false;
		dgvList.AllowUserToAddRows = false;
		dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvList.ReadOnly = true;
		dgvList.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvList.AllowUserToResizeRows = false;
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
		if (dgvList.RowCount != 0)
		{
			if (Operators.ConditionalCompareObjectEqual(dgvList[0, dgvList.CurrentRow.Index].Value, 1, TextCompare: false))
			{
				MyProject.Forms.frmPurchaseInvoice.Show();
				MyProject.Forms.frmPurchaseInvoice.prepareForm(SaveNew: false, KeepSupplier: false);
				MyProject.Forms.frmPurchaseInvoice.CurrentId = Conversions.ToDouble(dgvList[1, dgvList.CurrentRow.Index].Value);
				MyProject.Forms.frmPurchaseInvoice.LoadData();
				MyProject.Forms.frmPurchaseInvoice.Activate();
				MyProject.Forms.frmPurchaseInvoice.WindowState = FormWindowState.Normal;
			}
			else if (Operators.ConditionalCompareObjectEqual(dgvList[0, dgvList.CurrentRow.Index].Value, 2, TextCompare: false))
			{
				MyProject.Forms.frmProcess.Show();
				MyProject.Forms.frmProcess.prepareForm(SaveNew: false, KeepItem: false);
				MyProject.Forms.frmProcess.CurrentId = Conversions.ToDouble(dgvList[1, dgvList.CurrentRow.Index].Value);
				MyProject.Forms.frmProcess.loadData();
				MyProject.Forms.frmProcess.Activate();
				MyProject.Forms.frmProcess.WindowState = FormWindowState.Normal;
			}
			else if (Operators.ConditionalCompareObjectEqual(dgvList[0, dgvList.CurrentRow.Index].Value, 3, TextCompare: false))
			{
				MyProject.Forms.frmAdjustment.Show();
				MyProject.Forms.frmAdjustment.prepareForm(SaveNew: false);
				MyProject.Forms.frmAdjustment.CurrentId = Conversions.ToDouble(dgvList[1, dgvList.CurrentRow.Index].Value);
				MyProject.Forms.frmAdjustment.LoadData();
				MyProject.Forms.frmAdjustment.Activate();
				MyProject.Forms.frmAdjustment.WindowState = FormWindowState.Normal;
			}
			else if (Operators.ConditionalCompareObjectEqual(dgvList[0, dgvList.CurrentRow.Index].Value, 4, TextCompare: false))
			{
				MyProject.Forms.frmTransfer.Show();
				MyProject.Forms.frmTransfer.prepareForm(SaveNew: false);
				MyProject.Forms.frmTransfer.CurrentId = Conversions.ToDouble(dgvList[1, dgvList.CurrentRow.Index].Value);
				MyProject.Forms.frmTransfer.loadData();
				MyProject.Forms.frmTransfer.Activate();
				MyProject.Forms.frmTransfer.WindowState = FormWindowState.Normal;
			}
			else if (Operators.ConditionalCompareObjectEqual(dgvList[0, dgvList.CurrentRow.Index].Value, 6, TextCompare: false))
			{
				MyProject.Forms.frmSupplierPayment.Show();
				MyProject.Forms.frmSupplierPayment.PrepareForm(SaveNew: false);
				MyProject.Forms.frmSupplierPayment.CurrentId = Conversions.ToDouble(dgvList[1, dgvList.CurrentRow.Index].Value);
				MyProject.Forms.frmSupplierPayment.LoadData();
				MyProject.Forms.frmSupplierPayment.Activate();
				MyProject.Forms.frmSupplierPayment.WindowState = FormWindowState.Normal;
			}
			else if (Operators.ConditionalCompareObjectEqual(dgvList[0, dgvList.CurrentRow.Index].Value, 7, TextCompare: false))
			{
				MyProject.Forms.frmUsage.Show();
				MyProject.Forms.frmUsage.PrepareForm(SaveNew: false);
				MyProject.Forms.frmUsage.CurrentId = Conversions.ToDouble(dgvList[1, dgvList.CurrentRow.Index].Value);
				MyProject.Forms.frmUsage.LoadData();
				MyProject.Forms.frmUsage.Activate();
				MyProject.Forms.frmUsage.WindowState = FormWindowState.Normal;
			}
			else if (Operators.ConditionalCompareObjectEqual(dgvList[0, dgvList.CurrentRow.Index].Value, 8, TextCompare: false))
			{
				MyProject.Forms.frmCustomer.Show();
				MyProject.Forms.frmCustomer.prepareForm();
				MyProject.Forms.frmCustomer.CurrentId = Conversions.ToDouble(dgvList[1, dgvList.CurrentRow.Index].Value);
				MyProject.Forms.frmCustomer.LoadData();
				MyProject.Forms.frmCustomer.Activate();
				MyProject.Forms.frmCustomer.WindowState = FormWindowState.Normal;
			}
			else if (Operators.ConditionalCompareObjectEqual(dgvList[0, dgvList.CurrentRow.Index].Value, 9, TextCompare: false))
			{
				MyProject.Forms.frmDeliveryOrder.Show();
				MyProject.Forms.frmDeliveryOrder.prepareForm(SaveNew: false);
				MyProject.Forms.frmDeliveryOrder.CurrentId = Conversions.ToDouble(dgvList[1, dgvList.CurrentRow.Index].Value);
				MyProject.Forms.frmDeliveryOrder.loadData();
				MyProject.Forms.frmDeliveryOrder.Activate();
				MyProject.Forms.frmDeliveryOrder.WindowState = FormWindowState.Normal;
			}
			else if (Operators.ConditionalCompareObjectEqual(dgvList[0, dgvList.CurrentRow.Index].Value, 10, TextCompare: false))
			{
				MyProject.Forms.frmReceivedItem.Show();
				MyProject.Forms.frmReceivedItem.prepareForm(SaveNew: false);
				MyProject.Forms.frmReceivedItem.CurrentId = Conversions.ToDouble(dgvList[1, dgvList.CurrentRow.Index].Value);
				MyProject.Forms.frmReceivedItem.loadData();
				MyProject.Forms.frmReceivedItem.Activate();
				MyProject.Forms.frmReceivedItem.WindowState = FormWindowState.Normal;
			}
			else if (Operators.ConditionalCompareObjectEqual(dgvList[0, dgvList.CurrentRow.Index].Value, 11, TextCompare: false))
			{
				MyProject.Forms.frmSupplier.Show();
				MyProject.Forms.frmSupplier.prepareForm();
				MyProject.Forms.frmSupplier.CurrentId = Conversions.ToDouble(dgvList[1, dgvList.CurrentRow.Index].Value);
				MyProject.Forms.frmSupplier.LoadData();
				MyProject.Forms.frmSupplier.Activate();
				MyProject.Forms.frmSupplier.WindowState = FormWindowState.Normal;
			}
			else if (Operators.ConditionalCompareObjectEqual(dgvList[0, dgvList.CurrentRow.Index].Value, 12, TextCompare: false))
			{
				MyProject.Forms.frmCashTransaction.Show();
				MyProject.Forms.frmCashTransaction.prepareForm(SaveNew: false);
				MyProject.Forms.frmCashTransaction.CurrentId = Conversions.ToDouble(dgvList[1, dgvList.CurrentRow.Index].Value);
				MyProject.Forms.frmCashTransaction.LoadData();
				MyProject.Forms.frmCashTransaction.Activate();
				MyProject.Forms.frmCashTransaction.WindowState = FormWindowState.Normal;
			}
			else if (Operators.ConditionalCompareObjectEqual(dgvList[0, dgvList.CurrentRow.Index].Value, 13, TextCompare: false))
			{
				MyProject.Forms.frmBankTransaction.Show();
				MyProject.Forms.frmBankTransaction.prepareForm(SaveNew: false);
				MyProject.Forms.frmBankTransaction.CurrentId = Conversions.ToDouble(dgvList[1, dgvList.CurrentRow.Index].Value);
				MyProject.Forms.frmBankTransaction.LoadData();
				MyProject.Forms.frmBankTransaction.Activate();
				MyProject.Forms.frmBankTransaction.WindowState = FormWindowState.Normal;
			}
			else if (Operators.ConditionalCompareObjectEqual(dgvList[0, dgvList.CurrentRow.Index].Value, 14, TextCompare: false))
			{
				MyProject.Forms.frmJournalTransaction.Show();
				MyProject.Forms.frmJournalTransaction.prepareForm(SaveNew: false);
				MyProject.Forms.frmJournalTransaction.CurrentId = Conversions.ToDouble(dgvList[1, dgvList.CurrentRow.Index].Value);
				MyProject.Forms.frmJournalTransaction.LoadData();
				MyProject.Forms.frmJournalTransaction.Activate();
				MyProject.Forms.frmJournalTransaction.WindowState = FormWindowState.Normal;
			}
			else if (Operators.ConditionalCompareObjectEqual(dgvList[0, dgvList.CurrentRow.Index].Value, 15, TextCompare: false))
			{
				MyProject.Forms.frmSalesReceipt.Show();
				MyProject.Forms.frmSalesReceipt.prepareForm(SaveNew: false);
				MyProject.Forms.frmSalesReceipt.CurrentId = Conversions.ToDouble(dgvList[1, dgvList.CurrentRow.Index].Value);
				MyProject.Forms.frmSalesReceipt.loadData();
				MyProject.Forms.frmSalesReceipt.Activate();
				MyProject.Forms.frmSalesReceipt.WindowState = FormWindowState.Normal;
			}
			else if (Operators.ConditionalCompareObjectEqual(dgvList[0, dgvList.CurrentRow.Index].Value, 16, TextCompare: false))
			{
				MyProject.Forms.frmSalesReceipt.Show();
				MyProject.Forms.frmSalesReceipt.prepareForm(SaveNew: false);
				MyProject.Forms.frmSalesReceipt.CurrentId = Conversions.ToDouble(dgvList[1, dgvList.CurrentRow.Index].Value);
				MyProject.Forms.frmSalesReceipt.loadData();
				MyProject.Forms.frmSalesReceipt.Activate();
				MyProject.Forms.frmSalesReceipt.WindowState = FormWindowState.Normal;
			}
			else if (Operators.ConditionalCompareObjectEqual(dgvList[0, dgvList.CurrentRow.Index].Value, 17, TextCompare: false))
			{
				MyProject.Forms.frmSalesOrder.Show();
				MyProject.Forms.frmSalesOrder.prepareForm(SaveNew: false);
				MyProject.Forms.frmSalesOrder.CurrentId = Conversions.ToDouble(dgvList[1, dgvList.CurrentRow.Index].Value);
				MyProject.Forms.frmSalesOrder.loadData();
				MyProject.Forms.frmSalesOrder.Activate();
				MyProject.Forms.frmSalesOrder.WindowState = FormWindowState.Normal;
			}
			else if (Operators.ConditionalCompareObjectEqual(dgvList[0, dgvList.CurrentRow.Index].Value, 19, TextCompare: false))
			{
				MyProject.Forms.frmSalesInvoice.Show();
				MyProject.Forms.frmSalesInvoice.prepareForm(SaveNew: false);
				MyProject.Forms.frmSalesInvoice.CurrentId = Conversions.ToDouble(dgvList[1, dgvList.CurrentRow.Index].Value);
				MyProject.Forms.frmSalesInvoice.LoadData();
				MyProject.Forms.frmSalesInvoice.Activate();
				MyProject.Forms.frmSalesInvoice.WindowState = FormWindowState.Normal;
			}
			else if (Operators.ConditionalCompareObjectEqual(dgvList[0, dgvList.CurrentRow.Index].Value, 20, TextCompare: false))
			{
				MyProject.Forms.frmSalesReturn.Show();
				MyProject.Forms.frmSalesReturn.prepareForm(SaveNew: false);
				MyProject.Forms.frmSalesReturn.CurrentId = Conversions.ToDouble(dgvList[1, dgvList.CurrentRow.Index].Value);
				MyProject.Forms.frmSalesReturn.LoadData();
				MyProject.Forms.frmSalesReturn.Activate();
				MyProject.Forms.frmSalesReturn.WindowState = FormWindowState.Normal;
			}
			else if (Operators.ConditionalCompareObjectEqual(dgvList[0, dgvList.CurrentRow.Index].Value, 21, TextCompare: false))
			{
				MyProject.Forms.frmPurchaseReturn.Show();
				MyProject.Forms.frmPurchaseReturn.prepareForm(SaveNew: false, KeepSupplier: false);
				MyProject.Forms.frmPurchaseReturn.CurrentId = Conversions.ToDouble(dgvList[1, dgvList.CurrentRow.Index].Value);
				MyProject.Forms.frmPurchaseReturn.LoadData();
				MyProject.Forms.frmPurchaseReturn.Activate();
				MyProject.Forms.frmPurchaseReturn.WindowState = FormWindowState.Normal;
			}
			else if (Operators.ConditionalCompareObjectEqual(dgvList[0, dgvList.CurrentRow.Index].Value, 22, TextCompare: false))
			{
				MyProject.Forms.frmCustomerPayment.Show();
				MyProject.Forms.frmCustomerPayment.PrepareForm(SaveNew: false);
				MyProject.Forms.frmCustomerPayment.CurrentId = Conversions.ToDouble(dgvList[1, dgvList.CurrentRow.Index].Value);
				MyProject.Forms.frmCustomerPayment.LoadData();
				MyProject.Forms.frmCustomerPayment.Activate();
				MyProject.Forms.frmCustomerPayment.WindowState = FormWindowState.Normal;
			}
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
		dgvList.Rows[0].Selected = true;
		MsWord msWord = new MsWord();
		msWord.rptWordNew(dgvList.Rows.Count, dgvList.Columns.Count, "LL", blnPortrait: true, "", Print);
	}

	private void btnReset_Click(object sender, EventArgs e)
	{
		prepareForm();
	}

	private void btnPrint_Click(object sender, EventArgs e)
	{
		ExportReport(Print: true);
	}
}
