using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GCUv2.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

[DesignerGenerated]
public class frmUsage : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnHistory")]
	private Button _btnHistory;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSaveClose")]
	private Button _btnSaveClose;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnDelete")]
	private Button _btnDelete;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSave")]
	private Button _btnSave;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboStorage")]
	private ComboBox _cboStorage;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dtpUsage")]
	private DateTimePicker _dtpUsage;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvList")]
	private DataGridView _dgvList;

	private bool _dontFocus;

	private double _currentId;

	private DateTime _originalDate;

	private int _originalStorageId;

	private bool _dateIsChanged;

	private bool _dataIsInGrid;

	private bool blnDecimal;

	internal virtual Button btnHistory
	{
		[CompilerGenerated]
		get
		{
			return _btnHistory;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnHistory_Click;
			Button button = _btnHistory;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnHistory = value;
			button = _btnHistory;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button btnSaveClose
	{
		[CompilerGenerated]
		get
		{
			return _btnSaveClose;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnSaveClose_Click;
			Button button = _btnSaveClose;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnSaveClose = value;
			button = _btnSaveClose;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button btnDelete
	{
		[CompilerGenerated]
		get
		{
			return _btnDelete;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnDelete_Click;
			Button button = _btnDelete;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnDelete = value;
			button = _btnDelete;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button btnSave
	{
		[CompilerGenerated]
		get
		{
			return _btnSave;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnSave_Click;
			Button button = _btnSave;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnSave = value;
			button = _btnSave;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
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

	[field: AccessedThroughProperty("txtNote")]
	internal virtual TextBox txtNote
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox cboStorage
	{
		[CompilerGenerated]
		get
		{
			return _cboStorage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cboStorage_SelectedIndexChanged;
			ComboBox comboBox = _cboStorage;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_cboStorage = value;
			comboBox = _cboStorage;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	internal virtual DateTimePicker dtpUsage
	{
		[CompilerGenerated]
		get
		{
			return _dtpUsage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = dtpUsage_ValueChanged;
			DateTimePicker dateTimePicker = _dtpUsage;
			if (dateTimePicker != null)
			{
				dateTimePicker.ValueChanged -= value2;
			}
			_dtpUsage = value;
			dateTimePicker = _dtpUsage;
			if (dateTimePicker != null)
			{
				dateTimePicker.ValueChanged += value2;
			}
		}
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
			DataGridViewCellEventHandler value2 = dgvList_CellEnter;
			DataGridViewCellEventHandler value3 = dgvList_CellEndEdit;
			EventHandler value4 = dgvList_GotFocus;
			EventHandler value5 = dgvList_LostFocus;
			KeyEventHandler value6 = dgvList_KeyDown;
			DataGridViewCellValidatingEventHandler value7 = dgvList_CellValidating;
			DataGridViewCellEventHandler value8 = dgvList_CellValidated;
			DataGridViewEditingControlShowingEventHandler value9 = dgvList_EditingControlShowing;
			DataGridView dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.CellEnter -= value2;
				dataGridView.CellEndEdit -= value3;
				dataGridView.GotFocus -= value4;
				dataGridView.LostFocus -= value5;
				dataGridView.KeyDown -= value6;
				dataGridView.CellValidating -= value7;
				dataGridView.CellValidated -= value8;
				dataGridView.EditingControlShowing -= value9;
			}
			_dgvList = value;
			dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.CellEnter += value2;
				dataGridView.CellEndEdit += value3;
				dataGridView.GotFocus += value4;
				dataGridView.LostFocus += value5;
				dataGridView.KeyDown += value6;
				dataGridView.CellValidating += value7;
				dataGridView.CellValidated += value8;
				dataGridView.EditingControlShowing += value9;
			}
		}
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblUsageNumber")]
	internal virtual Label lblUsageNumber
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblStorage")]
	internal virtual Label lblStorage
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public double CurrentId
	{
		get
		{
			return _currentId;
		}
		set
		{
			_currentId = value;
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
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		this.btnHistory = new System.Windows.Forms.Button();
		this.btnSaveClose = new System.Windows.Forms.Button();
		this.btnDelete = new System.Windows.Forms.Button();
		this.btnSave = new System.Windows.Forms.Button();
		this.Label11 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.txtNote = new System.Windows.Forms.TextBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.cboStorage = new System.Windows.Forms.ComboBox();
		this.dtpUsage = new System.Windows.Forms.DateTimePicker();
		this.dgvList = new System.Windows.Forms.DataGridView();
		this.Label2 = new System.Windows.Forms.Label();
		this.lblUsageNumber = new System.Windows.Forms.Label();
		this.lblStorage = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		base.SuspendLayout();
		this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnHistory.Location = new System.Drawing.Point(643, 372);
		this.btnHistory.Name = "btnHistory";
		this.btnHistory.Size = new System.Drawing.Size(50, 24);
		this.btnHistory.TabIndex = 24;
		this.btnHistory.Text = "&History";
		this.btnHistory.UseVisualStyleBackColor = true;
		this.btnSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSaveClose.Location = new System.Drawing.Point(489, 372);
		this.btnSaveClose.Name = "btnSaveClose";
		this.btnSaveClose.Size = new System.Drawing.Size(93, 24);
		this.btnSaveClose.TabIndex = 22;
		this.btnSaveClose.Text = "Simpan && &Tutup";
		this.btnSaveClose.UseVisualStyleBackColor = true;
		this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDelete.Location = new System.Drawing.Point(588, 372);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new System.Drawing.Size(49, 24);
		this.btnDelete.TabIndex = 23;
		this.btnDelete.Text = "Hapus";
		this.btnDelete.UseVisualStyleBackColor = true;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(397, 372);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(86, 24);
		this.btnSave.TabIndex = 21;
		this.btnSave.Text = "&Simpan && Baru";
		this.btnSave.UseVisualStyleBackColor = true;
		this.Label11.BackColor = System.Drawing.Color.Silver;
		this.Label11.Location = new System.Drawing.Point(-303, 362);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(1015, 59);
		this.Label11.TabIndex = 148;
		this.Label8.AutoSize = true;
		this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label8.Location = new System.Drawing.Point(15, 90);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(62, 13);
		this.Label8.TabIndex = 147;
		this.Label8.Text = "Keterangan";
		this.txtNote.Location = new System.Drawing.Point(105, 84);
		this.txtNote.Multiline = true;
		this.txtNote.Name = "txtNote";
		this.txtNote.Size = new System.Drawing.Size(139, 52);
		this.txtNote.TabIndex = 2;
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(15, 61);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(45, 13);
		this.Label3.TabIndex = 143;
		this.Label3.Text = "Gudang";
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(15, 34);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(46, 13);
		this.Label1.TabIndex = 141;
		this.Label1.Text = "Tanggal";
		this.cboStorage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboStorage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboStorage.FormattingEnabled = true;
		this.cboStorage.Location = new System.Drawing.Point(105, 57);
		this.cboStorage.Name = "cboStorage";
		this.cboStorage.Size = new System.Drawing.Size(139, 21);
		this.cboStorage.TabIndex = 1;
		this.dtpUsage.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpUsage.Location = new System.Drawing.Point(106, 31);
		this.dtpUsage.Name = "dtpUsage";
		this.dtpUsage.Size = new System.Drawing.Size(138, 20);
		this.dtpUsage.TabIndex = 0;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
		this.dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.dgvList.DefaultCellStyle = dataGridViewCellStyle2;
		this.dgvList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
		this.dgvList.Location = new System.Drawing.Point(260, 11);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(432, 338);
		this.dgvList.TabIndex = 10;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(15, 11);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(38, 13);
		this.Label2.TabIndex = 149;
		this.Label2.Text = "Nomer";
		this.lblUsageNumber.AutoSize = true;
		this.lblUsageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblUsageNumber.Location = new System.Drawing.Point(103, 11);
		this.lblUsageNumber.Name = "lblUsageNumber";
		this.lblUsageNumber.Size = new System.Drawing.Size(85, 13);
		this.lblUsageNumber.TabIndex = 150;
		this.lblUsageNumber.Text = "lblUsageNumber";
		this.lblStorage.AutoSize = true;
		this.lblStorage.Location = new System.Drawing.Point(103, 60);
		this.lblStorage.Name = "lblStorage";
		this.lblStorage.Size = new System.Drawing.Size(54, 13);
		this.lblStorage.TabIndex = 189;
		this.lblStorage.Text = "lblStorage";
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(707, 404);
		base.Controls.Add(this.lblStorage);
		base.Controls.Add(this.lblUsageNumber);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.dgvList);
		base.Controls.Add(this.btnHistory);
		base.Controls.Add(this.btnSaveClose);
		base.Controls.Add(this.btnDelete);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.Label11);
		base.Controls.Add(this.Label8);
		base.Controls.Add(this.txtNote);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.cboStorage);
		base.Controls.Add(this.dtpUsage);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmUsage";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Penggunaan - Input";
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmUsage()
	{
		base.KeyDown += frmPayment_KeyDown;
		blnDecimal = false;
		InitializeComponent();
		DoubleBuffered = true;
		base.MdiParent = MyProject.Forms.frmMenu;
		ComboBox combo = cboStorage;
		cCombo.getStorage(ref combo, Module1.pubGroupId, 0, "NO_RETURN", blnAll: false, 1);
		cboStorage = combo;
		dgvList.Columns.Add("", "itemId");
		dgvList.Columns.Add("", "Produk");
		dgvList.Columns.Add("", "Jml. Digunakan");
		dgvList.Columns.Add("", "Jml. Dibuang");
		dgvList.Columns.Add("", "Total");
		dgvList.Columns.Add("", "UsageOriginal");
		dgvList.Columns.Add("", "WasteOriginal");
		dgvList.Columns[0].Visible = false;
		dgvList.Columns[5].Visible = false;
		dgvList.Columns[6].Visible = false;
		dgvList.Columns[1].ReadOnly = true;
		dgvList.Columns[4].ReadOnly = true;
		dgvList.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[1].Width = 140;
		dgvList.Columns[2].Width = 80;
		dgvList.Columns[3].Width = 80;
		dgvList.Columns[3].Width = 80;
		dgvList.RowHeadersVisible = false;
		dgvList.AllowUserToAddRows = false;
		dgvList.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvList.AllowUserToResizeRows = false;
		dgvList.EditMode = DataGridViewEditMode.EditOnEnter;
	}

	private void frmPayment_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	public void PrepareForm(bool SaveNew)
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
					_currentId = 0.0;
					_originalDate = DateAndTime.Now;
					_originalStorageId = 0;
					_dateIsChanged = false;
					_dataIsInGrid = false;
					if (!SaveNew)
					{
						dtpUsage.Value = DateAndTime.Now;
						_dateIsChanged = false;
					}
					lblStorage.Text = "";
					lblStorage.Visible = false;
					cboStorage.Visible = true;
					cboStorage.SelectedIndex = -1;
					lblUsageNumber.Text = "auto";
					txtNote.Text = "";
					btnDelete.Enabled = false;
					btnHistory.Enabled = false;
					dtpUsage.Enabled = true;
					dtpUsage.Focus();
					goto end_IL_0001;
				case 263:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmUsage", "PrepareForm", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 263;
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

	public void LoadData()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
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
						cUsage cUsage2 = new cUsage(_currentId);
						ComboBox cboSource = cboStorage;
						Module1.comboBoundValue(ref cboSource, cUsage2.StorageId);
						cboStorage = cboSource;
						lblStorage.Text = cUsage2.StorageName;
						lblStorage.Visible = true;
						cboStorage.Visible = false;
						lblUsageNumber.Text = cUsage2.UsageNumber;
						dtpUsage.Value = cUsage2.UsageDate;
						_dateIsChanged = false;
						txtNote.Text = cUsage2.Note;
						_originalDate = cUsage2.UsageDate;
						_originalStorageId = cUsage2.StorageId;
						dgvList.Rows.Clear();
						cUsageItem[] item = cUsage2.Item;
						foreach (cUsageItem cUsageItem2 in item)
						{
							dgvList.Rows.Add(cUsageItem2.ItemId, cUsageItem2.ItemName, Module1.formatCustomDecimal(Conversions.ToString(cUsageItem2.UseQty), 3), Module1.formatCustomDecimal(Conversions.ToString(cUsageItem2.WasteQty), 3), Module1.formatCustomDecimal(Conversions.ToString(cUsageItem2.UseQty + cUsageItem2.WasteQty), 3), cUsageItem2.UseQty, cUsageItem2.WasteQty);
							if (cUsageItem2.UseQty > 0.0)
							{
								dgvList[2, dgvList.RowCount - 1].Style.BackColor = Color.LightGreen;
							}
							if (cUsageItem2.WasteQty > 0.0)
							{
								dgvList[3, dgvList.RowCount - 1].Style.BackColor = Color.LightGreen;
							}
						}
						_dataIsInGrid = true;
						if (dgvList.Rows.Count > 0)
						{
							dgvList.CurrentRow.Selected = false;
						}
						if (DateAndTime.DateDiff(DateInterval.Day, dtpUsage.Value, DateAndTime.Now) <= Module1.pubDaysLimit)
						{
							dtpUsage.Enabled = true;
						}
						else
						{
							dtpUsage.Enabled = false;
						}
						if (DateAndTime.DateDiff(DateInterval.Day, dtpUsage.Value, DateAndTime.Now) <= Module1.pubDaysLimit)
						{
							btnDelete.Enabled = true;
						}
						else
						{
							btnDelete.Enabled = false;
						}
						btnHistory.Enabled = true;
						goto end_IL_0001;
					}
					case 800:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmSupplierPayment", "LoadData", "");
							if (Information.Err().Number == 513)
							{
								Close();
							}
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 800;
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

	private void dgvList_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		if ((dgvList.CurrentCell.ColumnIndex == 2) | (dgvList.CurrentCell.ColumnIndex == 3))
		{
			string strInput = dgvList[dgvList.CurrentCell.ColumnIndex, dgvList.CurrentCell.RowIndex].Value.ToString();
			strInput = Module1.formatCustomDecimal(strInput, 3);
			strInput = Conversions.ToString(decimal.Parse(strInput, NumberStyles.Currency));
			dgvList[dgvList.CurrentCell.ColumnIndex, dgvList.CurrentCell.RowIndex].Value = strInput;
		}
	}

	private void dgvList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
	{
		if ((dgvList.CurrentCell.ColumnIndex == 2) | (dgvList.CurrentCell.ColumnIndex == 3))
		{
			string strInput = ((Information.IsNothing(RuntimeHelpers.GetObjectValue(dgvList[dgvList.CurrentCell.ColumnIndex, dgvList.CurrentCell.RowIndex].Value)) || Operators.CompareString(dgvList[dgvList.CurrentCell.ColumnIndex, dgvList.CurrentCell.RowIndex].Value.ToString(), "", TextCompare: false) == 0) ? Conversions.ToString(0) : dgvList[dgvList.CurrentCell.ColumnIndex, dgvList.CurrentCell.RowIndex].Value.ToString());
			strInput = Module1.formatCustomDecimal(strInput, 3);
			dgvList[dgvList.CurrentCell.ColumnIndex, dgvList.CurrentCell.RowIndex].Value = strInput;
		}
	}

	private void dgvList_GotFocus(object sender, EventArgs e)
	{
		if ((dgvList.RowCount > 0) & !_dontFocus)
		{
			dgvList.CurrentCell.Selected = true;
		}
		else
		{
			_dontFocus = false;
		}
	}

	private void dgvList_LostFocus(object sender, EventArgs e)
	{
		if (dgvList.RowCount > 0)
		{
			dgvList.CurrentCell.Selected = false;
		}
	}

	private void dgvList_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			e.SuppressKeyPress = true;
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			txtNote.Focus();
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			btnSave.Focus();
			e.SuppressKeyPress = true;
		}
	}

	private void dgvList_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
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
					if (!((e.ColumnIndex < 2) | (e.ColumnIndex > 3)) && !dgvList.Rows[e.RowIndex].IsNewRow)
					{
						if (Operators.CompareString(Strings.Trim(e.FormattedValue.ToString()), "", TextCompare: false) != 0 && !Versioned.IsNumeric(e.FormattedValue.ToString()))
						{
							e.Cancel = true;
							Interaction.MsgBox("Masukkan jumlah dengan format angka yang benar", MsgBoxStyle.Information);
						}
						else
						{
							_dontFocus = true;
						}
					}
					goto end_IL_0001;
				case 194:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmUsage", "dgvList_CellValidating", "");
						goto end_IL_0001;
					}
					break;
				}
				goto IL_00f8;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 194;
				continue;
			}
			break;
			IL_00f8:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void dgvList_CellValidated(object sender, DataGridViewCellEventArgs e)
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
					cComboItem cComboItem2 = (cComboItem)cboStorage.SelectedItem;
					if (dgvList.CurrentCell.RowIndex == 0)
					{
						goto end_IL_0001;
					}
					double num3 = Conversion.Val(Module1.unformatNumber(Conversions.ToString(dgvList[2, dgvList.CurrentCell.RowIndex].Value)));
					double num4 = Conversion.Val(Module1.unformatNumber(Conversions.ToString(dgvList[3, dgvList.CurrentCell.RowIndex].Value)));
					dgvList[4, dgvList.CurrentCell.RowIndex].Value = Module1.formatCustomDecimal(Conversions.ToString(num3 + num4), 3);
					if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(cboStorage.SelectedItem)))
					{
						_dataIsInGrid = true;
						if (num3 + num4 > 0.0 && !cValidation.isInStock(Module1.pubCheckStock, Module1.pubBalanceDate, dtpUsage.Value, "", _originalDate, Conversions.ToInteger(dgvList[0, dgvList.CurrentCell.RowIndex].Value), Conversions.ToInteger(dgvList[0, dgvList.CurrentCell.RowIndex].Value), Conversions.ToDouble(dgvList[4, dgvList.CurrentCell.RowIndex].Value), Conversions.ToDouble(Operators.AddObject(dgvList[5, dgvList.CurrentCell.RowIndex].Value, dgvList[6, dgvList.CurrentCell.RowIndex].Value)), Conversions.ToInteger(cComboItem2.Value), _originalStorageId, Module1.pubGroupId, 2))
						{
							Interaction.MsgBox(Operators.ConcatenateObject(Operators.ConcatenateObject("Stok ", dgvList[1, dgvList.CurrentCell.RowIndex].Value), " tidak tersedia"), MsgBoxStyle.Information);
							num3 = 0.0;
							num4 = 0.0;
							dgvList[2, dgvList.CurrentCell.RowIndex].Value = 0;
							dgvList[3, dgvList.CurrentCell.RowIndex].Value = 0;
							dgvList[4, dgvList.CurrentCell.RowIndex].Value = 0;
							dgvList.Focus();
						}
						if (num3 > 0.0)
						{
							dgvList[2, dgvList.CurrentCell.RowIndex].Style.BackColor = Color.LightGreen;
						}
						else if (dgvList.CurrentCell.RowIndex % 2 == 1)
						{
							dgvList[2, dgvList.CurrentCell.RowIndex].Style.BackColor = Color.WhiteSmoke;
						}
						else
						{
							dgvList[2, dgvList.CurrentCell.RowIndex].Style.BackColor = Color.White;
						}
						if (num4 > 0.0)
						{
							dgvList[3, dgvList.CurrentCell.RowIndex].Style.BackColor = Color.LightGreen;
						}
						else if (dgvList.CurrentCell.RowIndex % 2 == 1)
						{
							dgvList[3, dgvList.CurrentCell.RowIndex].Style.BackColor = Color.WhiteSmoke;
						}
						else
						{
							dgvList[3, dgvList.CurrentCell.RowIndex].Style.BackColor = Color.White;
						}
					}
					goto end_IL_0001_2;
				}
				case 1147:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmUsage", "dgvList_CellValidated", "");
						goto end_IL_0001_2;
					}
					break;
				}
				goto IL_04b1;
				end_IL_0001_2:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1147;
				continue;
			}
			break;
			IL_04b1:
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

	private void dgvList_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
	{
		Control control = e.Control;
		control.KeyDown += Handle_KeyDown;
		control.KeyPress += Handle_KeyPress;
	}

	protected void Handle_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyValue == 110)
		{
			blnDecimal = true;
		}
		else
		{
			blnDecimal = false;
		}
	}

	protected void Handle_KeyPress(object sender, KeyPressEventArgs e)
	{
		short num = checked((short)Strings.Asc(e.KeyChar));
		if (blnDecimal)
		{
			e.KeyChar = Conversions.ToChar(CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
		}
		if (!((num >= 48 && num <= 57) | (e.KeyChar == Convert.ToChar(110)) | (e.KeyChar == Convert.ToChar(8)) | (Operators.CompareString(Conversions.ToString(e.KeyChar), CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator, TextCompare: false) == 0)))
		{
			e.Handled = true;
		}
	}

	private void cboStorage_SelectedIndexChanged(object sender, EventArgs e)
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
					cComboItem cComboItem2 = (cComboItem)cboStorage.SelectedItem;
					dgvList.Rows.Clear();
					if (cboStorage.SelectedIndex > -1)
					{
						GetItemByStorage();
					}
					goto end_IL_0001;
				}
				case 102:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmUsage", "cboStorage_SelectedIndexChanged", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 102;
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

	private void GetItemByStorage()
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
					cComboItem cComboItem2 = (cComboItem)cboStorage.SelectedItem;
					DataTable dataTable = cItem.Search(99, 99, 0, 1, 0, 0, 99, 1, 0, 0, Conversions.ToInteger(cComboItem2.Value), 0, 0.0, CanBeUsedAsGroupMember: false, Module1.pubGroupId, 0, -1);
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						dgvList.Rows.Add(dataRow["itemId"], dataRow["itemName"], 0, 0, 0);
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					if (dgvList.Rows.Count > 0)
					{
						dgvList.CurrentRow.Selected = false;
					}
					goto end_IL_0001;
				}
				case 296:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmUsage", "GetItemByStorage", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 296;
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

	private void dtpUsage_ValueChanged(object sender, EventArgs e)
	{
		if (_dataIsInGrid)
		{
			_dateIsChanged = true;
		}
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		SaveData(CloseForm: false);
	}

	private void btnSaveClose_Click(object sender, EventArgs e)
	{
		SaveData(CloseForm: true);
	}

	private void SaveData(bool CloseForm)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num6 = default(int);
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
						cComboItem cComboItem2 = (cComboItem)cboStorage.SelectedItem;
						string text = "";
						bool flag = true;
						int num3 = dgvList.Rows.Count - 1;
						for (int i = 0; i <= num3; i++)
						{
							if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectGreater(dgvList[2, i].Value, 0, TextCompare: false), Operators.CompareObjectGreater(dgvList[3, i].Value, 0, TextCompare: false))))
							{
								flag = false;
							}
						}
						if (cboStorage.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih gudang", MsgBoxStyle.Information);
							cboStorage.Focus();
							goto end_IL_0001;
						}
						if (!cValidation.isDateWithinRange(dtpUsage.Value, Module1.pubGroupId, Module1.pubDaysLimit))
						{
							Interaction.MsgBox("Tanggal diluar batas yang diperbolehkan", MsgBoxStyle.Information);
							dtpUsage.Focus();
							goto end_IL_0001;
						}
						if (flag)
						{
							Interaction.MsgBox("Masukkan minimum 1 penggunaan", MsgBoxStyle.Information);
							dgvList.Focus();
							goto end_IL_0001;
						}
						if (_dataIsInGrid & _dateIsChanged)
						{
							text = ". Catatan: Stok dicek ulang.";
							int num4 = dgvList.RowCount - 1;
							for (int i = 0; i <= num4; i++)
							{
								if (Operators.ConditionalCompareObjectGreater(dgvList[4, i].Value, 0, TextCompare: false) && !cValidation.isInStock(Module1.pubCheckStock, Module1.pubBalanceDate, dtpUsage.Value, "", _originalDate, Conversions.ToInteger(dgvList[0, i].Value), Conversions.ToInteger(dgvList[0, i].Value), Conversions.ToDouble(dgvList[4, i].Value), Conversions.ToDouble(Operators.AddObject(dgvList[5, i].Value, dgvList[6, i].Value)), Conversions.ToInteger(cComboItem2.Value), _originalStorageId, Module1.pubGroupId, 2))
								{
									Module1.SaveDebug("Penggunaan - Stok dicek ulang dan tidak tersedia - " + Module1.pubLogin);
									Interaction.MsgBox(Operators.ConcatenateObject(Operators.ConcatenateObject("Stok ", dgvList[1, i].Value), " tidak tersedia"), MsgBoxStyle.Information);
									dgvList.Focus();
									goto end_IL_0001;
								}
							}
						}
						cUsage cUsage2 = new cUsage(_currentId);
						cUsage2.CurrentItem = cUsage2.Item;
						cUsage2.CurrentDate = cUsage2.UsageDate;
						cUsage2.CurrentStorage = cUsage2.StorageId;
						cUsage2.UsageDate = dtpUsage.Value;
						cUsage2.StorageId = Conversions.ToInteger(cComboItem2.Value);
						cUsage2.StorageName = cboStorage.Text;
						cUsage2.Note = txtNote.Text;
						cUsageItem[] array = null;
						string text2 = "";
						int num5 = dgvList.Rows.Count - 1;
						for (int i = 0; i <= num5; i++)
						{
							if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectGreater(dgvList[2, i].Value, 0, TextCompare: false), Operators.CompareObjectGreater(dgvList[3, i].Value, 0, TextCompare: false))))
							{
								array = (cUsageItem[])Utils.CopyArray(array, new cUsageItem[num6 + 1]);
								array[num6] = new cUsageItem();
								array[num6].ItemId = Conversions.ToInteger(dgvList[0, i].Value);
								array[num6].UseQty = Conversions.ToDouble(dgvList[2, i].Value);
								array[num6].WasteQty = Conversions.ToDouble(dgvList[3, i].Value);
								num6++;
								text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<tr><td>", dgvList[1, i].Value), "</td>"), "<td>"), Module1.formatCustomDecimal(Conversions.ToString(dgvList[2, i].Value), 3)), "</td>"), "<td>"), Module1.formatCustomDecimal(Conversions.ToString(dgvList[3, i].Value), 3)), "</td></tr>")));
							}
						}
						cUsage2.Item = array;
						cUsage2.save();
						if (Operators.CompareString(lblUsageNumber.Text, "auto", TextCompare: false) == 0)
						{
							lblUsageNumber.Text = "USE/" + Conversions.ToString(cUsage2.StorageId) + "/" + Strings.Right(Conversions.ToString(DateAndTime.Year(cUsage2.UsageDate)), 2) + "/" + cUsage2.UsageNumber;
						}
						string text3 = "Nomer: " + lblUsageNumber.Text + "<br />Tanggal: " + Conversions.ToString(dtpUsage.Value) + "<br />Keterangan: " + Module1.cleanString(txtNote.Text) + "<br /><br />";
						text3 += "<table>";
						text3 += "<tr><td>Produk</td><td>Jml. Digunakan</td><td>Jml. Dibuang</td>";
						text3 += text2;
						text3 += "</table>";
						string text4;
						if (_currentId == 0.0)
						{
							text4 = "membuat ";
							_currentId = cUsage2.Id;
						}
						else
						{
							text4 = "mengupdate ";
						}
						text4 = text4 + "Penggunaan tanggal " + Strings.Format(dtpUsage.Value, "dd/MM/yyyy") + " untuk gudang " + cboStorage.Text + ". ID= " + Conversions.ToString(_currentId) + ", v2";
						text4 += text;
						cHistory cHistory2 = new cHistory();
						cHistory2.Content = text3;
						cHistory2.Description = text4;
						cHistory2.UserId = Module1.pubUserId;
						cHistory2.UserLogin = Module1.pubLogin;
						cHistory2.fKeyId = _currentId;
						cHistory2.HistoryType = 7;
						cHistory2.Save();
						Interaction.MsgBox("Penggunaan berhasil disimpan", MsgBoxStyle.Information);
						if (Module1.FormIsOpen("frmUsageList"))
						{
							MyProject.Forms.frmUsageList.GetRecent();
						}
						MyProject.Forms.frmInformation.GetActivity();
						if (CloseForm)
						{
							Close();
						}
						else
						{
							PrepareForm(SaveNew: true);
						}
						goto end_IL_0001_2;
					}
					case 1949:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmUsage", "SaveData", "");
							goto end_IL_0001_2;
						}
						break;
					}
					goto IL_07d3;
				}
				end_IL_0001_2:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1949;
				continue;
			}
			break;
			IL_07d3:
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

	private void btnDelete_Click(object sender, EventArgs e)
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
					if (MessageBox.Show("Hapus Penggunaan?", "Konfirmasi", MessageBoxButtons.YesNo) != DialogResult.No)
					{
						cUsage cUsage2 = new cUsage(_currentId);
						cUsage2.CurrentItem = cUsage2.Item;
						cUsage2.CurrentDate = cUsage2.UsageDate;
						cUsage2.CurrentStorage = cUsage2.StorageId;
						cUsage2.Delete();
						string description = "menghapus penggunaan tanggal " + Conversions.ToString(cUsage2.UsageDate) + " untuk gudang " + cUsage2.StorageName + ". ID=" + Conversions.ToString(cUsage2.Id) + ", v2";
						cHistory cHistory2 = new cHistory();
						cHistory2.Description = description;
						cHistory2.UserId = Module1.pubUserId;
						cHistory2.UserLogin = Module1.pubLogin;
						cHistory2.fKeyId = _currentId;
						cHistory2.HistoryType = 7;
						cHistory2.Save();
						Interaction.MsgBox("Penggunaan berhasil dihapus", MsgBoxStyle.Information);
						if (Module1.FormIsOpen("frmUsageList"))
						{
							MyProject.Forms.frmUsageList.GetRecent();
						}
						MyProject.Forms.frmInformation.GetActivity();
						Close();
					}
					goto end_IL_0001;
				case 355:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmUsage", "btnDelete_Click", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 355;
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

	private void btnHistory_Click(object sender, EventArgs e)
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
					MyProject.Forms.frmHistory.GetHistory(checked((int)Math.Round(_currentId)), 7);
					MyProject.Forms.frmHistory.Show();
					MyProject.Forms.frmHistory.Activate();
					MyProject.Forms.frmHistory.WindowState = FormWindowState.Normal;
					goto end_IL_0001;
				case 119:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmUsage", "btnHistory_Click", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 119;
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
}
