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
public class frmReportSupplierTransactionFlower : Form
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
		this.btnPrint = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		base.SuspendLayout();
		this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnReset.Location = new System.Drawing.Point(131, 91);
		this.btnReset.Name = "btnReset";
		this.btnReset.Size = new System.Drawing.Size(47, 24);
		this.btnReset.TabIndex = 75;
		this.btnReset.Text = "&Reset";
		this.btnReset.UseVisualStyleBackColor = true;
		this.btnWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnWord.Location = new System.Drawing.Point(684, 477);
		this.btnWord.Name = "btnWord";
		this.btnWord.Size = new System.Drawing.Size(73, 23);
		this.btnWord.TabIndex = 77;
		this.btnWord.Text = "&Word";
		this.btnWord.UseVisualStyleBackColor = true;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(4, 15);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(71, 13);
		this.Label1.TabIndex = 81;
		this.Label1.Text = "Tanggal awal";
		this.lblTotal.AutoSize = true;
		this.lblTotal.Location = new System.Drawing.Point(14, 482);
		this.lblTotal.Name = "lblTotal";
		this.lblTotal.Size = new System.Drawing.Size(91, 13);
		this.lblTotal.TabIndex = 80;
		this.lblTotal.Text = "Total Pencarian: -";
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.Location = new System.Drawing.Point(5, 67);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(45, 13);
		this.Label7.TabIndex = 79;
		this.Label7.Text = "Supplier";
		this.cboSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboSupplier.FormattingEnabled = true;
		this.cboSupplier.Location = new System.Drawing.Point(77, 64);
		this.cboSupplier.Name = "cboSupplier";
		this.cboSupplier.Size = new System.Drawing.Size(140, 21);
		this.cboSupplier.TabIndex = 73;
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.Location = new System.Drawing.Point(12, 121);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(824, 350);
		this.dgvList.TabIndex = 76;
		this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSearch.Location = new System.Drawing.Point(78, 91);
		this.btnSearch.Name = "btnSearch";
		this.btnSearch.Size = new System.Drawing.Size(47, 24);
		this.btnSearch.TabIndex = 74;
		this.btnSearch.Text = "&Cari";
		this.btnSearch.UseVisualStyleBackColor = true;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(4, 41);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(72, 13);
		this.Label2.TabIndex = 78;
		this.Label2.Text = "Tanggal akhir";
		this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpEnd.Location = new System.Drawing.Point(78, 38);
		this.dtpEnd.Name = "dtpEnd";
		this.dtpEnd.Size = new System.Drawing.Size(140, 20);
		this.dtpEnd.TabIndex = 72;
		this.dtpBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpBegin.Location = new System.Drawing.Point(78, 12);
		this.dtpBegin.Name = "dtpBegin";
		this.dtpBegin.Size = new System.Drawing.Size(140, 20);
		this.dtpBegin.TabIndex = 71;
		this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnPrint.Location = new System.Drawing.Point(763, 477);
		this.btnPrint.Name = "btnPrint";
		this.btnPrint.Size = new System.Drawing.Size(73, 23);
		this.btnPrint.TabIndex = 78;
		this.btnPrint.Text = "Cetak";
		this.btnPrint.UseVisualStyleBackColor = true;
		base.AcceptButton = this.btnSearch;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(850, 512);
		base.Controls.Add(this.btnPrint);
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
		base.Name = "frmReportSupplierTransactionFlower";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Report - Tagihan Kembang";
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmReportSupplierTransactionFlower()
	{
		base.Load += frmReportSupplierTransactionFlower_Load;
		base.KeyDown += frmReportSupplierTransactionFlower_KeyDown;
		InitializeComponent();
		DoubleBuffered = true;
		base.MdiParent = MyProject.Forms.frmMenu;
		ComboBox combo = cboSupplier;
		cCombo.getSupplier(ref combo, Module1.pubGroupId, All: false, FlowerOnly: true, IncludeParent: true, Active: true);
		cboSupplier = combo;
	}

	private void frmReportSupplierTransactionFlower_Load(object sender, EventArgs e)
	{
		prepareForm();
	}

	private void frmReportSupplierTransactionFlower_KeyDown(object sender, KeyEventArgs e)
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
		if (cboSupplier.Items.Count > 0)
		{
			cboSupplier.SelectedIndex = 0;
		}
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
		double num3 = default(double);
		double num4 = default(double);
		double num5 = default(double);
		double num6 = default(double);
		double num7 = default(double);
		int num8 = default(int);
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
					if (!Module1.pubViewReportPurchaseInvoicePrice)
					{
						Interaction.MsgBox("Anda tidak bisa melihat faktur yang telah memiliki harga.", MsgBoxStyle.Information);
						goto end_IL_0001;
					}
					cComboItem cComboItem2 = (cComboItem)cboSupplier.SelectedItem;
					if (DateTime.Compare(dtpBegin.Value, Module1.pubBalanceDate) < 0)
					{
						Interaction.MsgBox("Data sebelum " + Conversions.ToString(Module1.pubBalanceDate) + " tidak tersedia.");
						dtpBegin.Focus();
						goto end_IL_0001;
					}
					if (cboSupplier.SelectedIndex == -1)
					{
						Interaction.MsgBox("Supplier yang anda pilih tidak terdaftar.", MsgBoxStyle.Information);
						cboSupplier.Focus();
						goto end_IL_0001;
					}
					Cursor = Cursors.WaitCursor;
					DataTable dataTable = new DataTable();
					btnSearch.Focus();
					dataTable = cPurchaseInvoice.SearchTransaction(Module1.pubBalanceDate, dtpBegin.Value, dtpEnd.Value, Conversions.ToInteger(cComboItem2.Value));
					formatGrid();
					dgvList.Rows.Clear();
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						num3 = Conversions.ToDouble(Operators.AddObject(num3, Operators.SubtractObject(Operators.SubtractObject(dataRow["iiTotal"], dataRow["mpayInFront"]), dataRow["mpayAmount"])));
						if (Operators.ConditionalCompareObjectEqual(dataRow["type"], 0, TextCompare: false))
						{
							dgvList.Rows.Add("", "", "", dataRow["description"], "", "", "", "", "", "", "", "", "", "", Module1.formatCustomDecimal(Conversions.ToString(dataRow["balance"]), 2));
							num3 = Conversions.ToDouble(dataRow["balance"]);
						}
						else if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(dataRow["type"], 1, TextCompare: false), Operators.CompareObjectEqual(dataRow["type"], 2, TextCompare: false))))
						{
							dgvList.Rows.Add(dataRow["id"], dataRow["type"], dataRow["transactionDate"], dataRow["description"], "", "", "", "", "", "", "", "", Module1.formatCustomDecimal(Conversions.ToString(dataRow["mpayInFront"]), 2), Module1.formatCustomDecimal(Conversions.ToString(dataRow["mpayAmount"]), 2), Module1.formatCustomDecimal(Conversions.ToString(num3), 2));
						}
						else if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(dataRow["type"], 3, TextCompare: false), Operators.CompareObjectEqual(dataRow["type"], 5, TextCompare: false))))
						{
							dgvList.Rows.Add(dataRow["id"], dataRow["type"], dataRow["transactionDate"], dataRow["description"], Module1.formatCustomDecimal(Conversions.ToString(dataRow["iiQty"]), 3), Module1.formatCustomDecimal(Conversions.ToString(dataRow["iiParkedQty"]), 3), Module1.formatCustomDecimal(Conversions.ToString(dataRow["iiAgreedQty"]), 3), dataRow["iiDeduction"], Module1.formatCustomDecimal(Conversions.ToString(dataRow["iiNetQty"]), 3), Module1.formatCustomDecimal(Conversions.ToString(dataRow["iiPrice"]), 2), Module1.formatCustomDecimal(Conversions.ToString(dataRow["iiExtraPrice"]), 2), Module1.formatCustomDecimal(Conversions.ToString(dataRow["iiTotal"]), 2), Module1.formatCustomDecimal(Conversions.ToString(dataRow["mpayInFront"]), 2), Module1.formatCustomDecimal(Conversions.ToString(dataRow["mpayAmount"]), 2), Module1.formatCustomDecimal(Conversions.ToString(num3), 2));
						}
						else if (Operators.ConditionalCompareObjectEqual(dataRow["type"], 4, TextCompare: false))
						{
							dgvList.Rows.Add(dataRow["id"], dataRow["type"], dataRow["transactionDate"], dataRow["description"], "", "", "", "", "", "", "", Module1.formatCustomDecimal(Conversions.ToString(dataRow["iiTotal"]), 2), "", "", Module1.formatCustomDecimal(Conversions.ToString(num3), 2));
						}
						else if (Operators.ConditionalCompareObjectEqual(dataRow["type"], 99, TextCompare: false))
						{
							dgvList.Rows.Add("", "", "Total", dataRow["description"], "", "", "", "", Module1.formatCustomDecimal(Conversions.ToString(dataRow["iiNetQty"]), 3), "", "", Module1.formatCustomDecimal(Conversions.ToString(dataRow["iiTotal"]), 2), "", "", Module1.formatCustomDecimal(Conversions.ToString(num3), 2));
						}
						if (Operators.ConditionalCompareObjectNotEqual(dataRow["type"], 99, TextCompare: false))
						{
							num4 = Conversions.ToDouble(Operators.AddObject(num4, dataRow["iiNetQty"]));
							num5 = Conversions.ToDouble(Operators.AddObject(num5, dataRow["mpayAmount"]));
							num6 = Conversions.ToDouble(Operators.AddObject(num6, dataRow["mpayInFront"]));
							num7 = Conversions.ToDouble(Operators.AddObject(num7, dataRow["iiTotal"]));
						}
						if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(dataRow["type"], 0, TextCompare: false), Operators.CompareObjectNotEqual(dataRow["type"], 99, TextCompare: false))))
						{
							num8 = checked(num8 + 1);
						}
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					dgvList.Rows.Add("", "", "Total", "", "", "", "", "", Module1.formatCustomDecimal(Conversions.ToString(num4), 3), "", "", Module1.formatCustomDecimal(Conversions.ToString(num7), 2), Module1.formatCustomDecimal(Conversions.ToString(num6), 2), Module1.formatCustomDecimal(Conversions.ToString(num5), 2), Module1.formatCustomDecimal(Conversions.ToString(num7 - num6 - num5), 2));
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
					lblTotal.Text = "Total Pencarian: " + Conversions.ToString(num8);
					Cursor = Cursors.Default;
					goto end_IL_0001;
				}
				case 2512:
					num = -1;
					switch (num2)
					{
					case 2:
						Cursor = Cursors.Default;
						Module1.SaveError(Information.Err(), "frmReportSupplierTransactionFlower", "btnSearch_click", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 2512;
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
		dgvList.Columns.Add("", "Id");
		dgvList.Columns.Add("", "Type");
		dgvList.Columns.Add("", "Tanggal");
		dgvList.Columns.Add("", "Deskripsi");
		dgvList.Columns.Add("", "Berat Kotor");
		dgvList.Columns.Add("", "Parkir");
		dgvList.Columns.Add("", "Dihitung");
		dgvList.Columns.Add("", "Potongan");
		dgvList.Columns.Add("", "Berat Netto");
		dgvList.Columns.Add("", "Harga per kg");
		dgvList.Columns.Add("", "Lain-lain");
		dgvList.Columns.Add("", "Total");
		dgvList.Columns.Add("", "Bon");
		dgvList.Columns.Add("", "Bayar");
		dgvList.Columns.Add("", "Saldo Hutang");
		dgvList.Columns[0].Visible = false;
		dgvList.Columns[1].Visible = false;
		dgvList.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvList.Columns[2].Width = 70;
		dgvList.Columns[3].Width = 80;
		dgvList.Columns[4].Width = 45;
		dgvList.Columns[5].Width = 40;
		dgvList.Columns[6].Width = 50;
		dgvList.Columns[7].Width = 55;
		dgvList.Columns[8].Width = 58;
		dgvList.Columns[9].Width = 50;
		dgvList.Columns[10].Width = 50;
		dgvList.Columns[11].Width = 80;
		dgvList.Columns[12].Width = 65;
		dgvList.Columns[13].Width = 80;
		dgvList.Columns[14].Width = 80;
		dgvList.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
		if (dgvList.RowCount > 0 && Conversion.Val(RuntimeHelpers.GetObjectValue(dgvList[0, dgvList.CurrentRow.Index].Value)) > 0.0)
		{
			if (Operators.ConditionalCompareObjectEqual(dgvList[1, dgvList.CurrentRow.Index].Value, 1, TextCompare: false))
			{
				MyProject.Forms.frmSupplierPayment.Show();
				MyProject.Forms.frmSupplierPayment.PrepareForm(SaveNew: false);
				MyProject.Forms.frmSupplierPayment.CurrentId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
				MyProject.Forms.frmSupplierPayment.LoadData();
				MyProject.Forms.frmSupplierPayment.Activate();
				MyProject.Forms.frmSupplierPayment.WindowState = FormWindowState.Normal;
			}
			else if (Operators.ConditionalCompareObjectEqual(dgvList[1, dgvList.CurrentRow.Index].Value, 2, TextCompare: false))
			{
				MyProject.Forms.frmPurchaseInvoice.Show();
				MyProject.Forms.frmPurchaseInvoice.prepareForm(SaveNew: false, KeepSupplier: false);
				MyProject.Forms.frmPurchaseInvoice.CurrentId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
				MyProject.Forms.frmPurchaseInvoice.LoadData();
				MyProject.Forms.frmPurchaseInvoice.TabControl1.SelectedIndex = 1;
				MyProject.Forms.frmPurchaseInvoice.Activate();
				MyProject.Forms.frmPurchaseInvoice.WindowState = FormWindowState.Normal;
			}
			else if (Operators.ConditionalCompareObjectEqual(dgvList[1, dgvList.CurrentRow.Index].Value, 3, TextCompare: false))
			{
				MyProject.Forms.frmPurchaseInvoice.Show();
				MyProject.Forms.frmPurchaseInvoice.prepareForm(SaveNew: false, KeepSupplier: false);
				MyProject.Forms.frmPurchaseInvoice.CurrentId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
				MyProject.Forms.frmPurchaseInvoice.LoadData();
				MyProject.Forms.frmPurchaseInvoice.Activate();
				MyProject.Forms.frmPurchaseInvoice.WindowState = FormWindowState.Normal;
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
		object left = "Report - Tagihan Kembang\r\nPT Gopek Cipta Utama\r\nJl. Pierre Tendean No.5 Slawi 52415, ph: (0283) 491572\r\n";
		left = Operators.ConcatenateObject(left, "Supplier: " + cboSupplier.Text);
		msWord.rptWordNew(dgvList.Rows.Count, dgvList.Columns.Count, "LLRRRRRRRRRRR", blnPortrait: false, Conversions.ToString(left), Print);
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
