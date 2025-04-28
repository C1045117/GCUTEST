using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GCUv2.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6;

namespace GCUv2;

[DesignerGenerated]
public class frmTransfer : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dtpTransfer")]
	private DateTimePicker _dtpTransfer;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboStorageFrom")]
	private ComboBox _cboStorageFrom;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboStorageTo")]
	private ComboBox _cboStorageTo;

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
	[AccessedThroughProperty("dgvItem")]
	private DataGridView _dgvItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnItem")]
	private Button _btnItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnPrint")]
	private Button _btnPrint;

	private double _currentId;

	private bool _edited;

	public int intOriginalItemId;

	public DateTime OriginalDate;

	public int OriginalStorageId;

	private cTransferItem[] _TransferItem;

	private bool _dateIsChanged;

	internal virtual DateTimePicker dtpTransfer
	{
		[CompilerGenerated]
		get
		{
			return _dtpTransfer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = dtpTransfer_ValueChanged;
			DateTimePicker dateTimePicker = _dtpTransfer;
			if (dateTimePicker != null)
			{
				dateTimePicker.ValueChanged -= value2;
			}
			_dtpTransfer = value;
			dateTimePicker = _dtpTransfer;
			if (dateTimePicker != null)
			{
				dateTimePicker.ValueChanged += value2;
			}
		}
	}

	internal virtual ComboBox cboStorageFrom
	{
		[CompilerGenerated]
		get
		{
			return _cboStorageFrom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cboStorageFrom_SelectedIndexChanged;
			ComboBox comboBox = _cboStorageFrom;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_cboStorageFrom = value;
			comboBox = _cboStorageFrom;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	internal virtual ComboBox cboStorageTo
	{
		[CompilerGenerated]
		get
		{
			return _cboStorageTo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cboStorageTo_SelectedIndexChanged;
			ComboBox comboBox = _cboStorageTo;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_cboStorageTo = value;
			comboBox = _cboStorageTo;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

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

	[field: AccessedThroughProperty("lblStorageTo")]
	internal virtual Label lblStorageTo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblStorageFrom")]
	internal virtual Label lblStorageFrom
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNumber")]
	internal virtual Label lblNumber
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

	[field: AccessedThroughProperty("TabControl1")]
	internal virtual TabControl TabControl1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage1")]
	internal virtual TabPage TabPage1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView dgvItem
	{
		[CompilerGenerated]
		get
		{
			return _dgvItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = dgvItem_GotFocus;
			EventHandler value3 = dgvItem_LostFocus;
			EventHandler value4 = dgvItem_DoubleClick;
			KeyEventHandler value5 = dgvItem_KeyDown;
			DataGridView dataGridView = _dgvItem;
			if (dataGridView != null)
			{
				dataGridView.GotFocus -= value2;
				dataGridView.LostFocus -= value3;
				dataGridView.DoubleClick -= value4;
				dataGridView.KeyDown -= value5;
			}
			_dgvItem = value;
			dataGridView = _dgvItem;
			if (dataGridView != null)
			{
				dataGridView.GotFocus += value2;
				dataGridView.LostFocus += value3;
				dataGridView.DoubleClick += value4;
				dataGridView.KeyDown += value5;
			}
		}
	}

	internal virtual Button btnItem
	{
		[CompilerGenerated]
		get
		{
			return _btnItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnItem_Click;
			Button button = _btnItem;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnItem = value;
			button = _btnItem;
			if (button != null)
			{
				button.Click += value2;
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

	public bool Edited
	{
		get
		{
			return _edited;
		}
		set
		{
			_edited = value;
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
		this.dtpTransfer = new System.Windows.Forms.DateTimePicker();
		this.cboStorageFrom = new System.Windows.Forms.ComboBox();
		this.cboStorageTo = new System.Windows.Forms.ComboBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label11 = new System.Windows.Forms.Label();
		this.btnHistory = new System.Windows.Forms.Button();
		this.btnSaveClose = new System.Windows.Forms.Button();
		this.btnDelete = new System.Windows.Forms.Button();
		this.btnSave = new System.Windows.Forms.Button();
		this.lblStorageTo = new System.Windows.Forms.Label();
		this.lblStorageFrom = new System.Windows.Forms.Label();
		this.lblNumber = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.TabControl1 = new System.Windows.Forms.TabControl();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.dgvItem = new System.Windows.Forms.DataGridView();
		this.btnItem = new System.Windows.Forms.Button();
		this.btnPrint = new System.Windows.Forms.Button();
		this.TabControl1.SuspendLayout();
		this.TabPage1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvItem).BeginInit();
		base.SuspendLayout();
		this.dtpTransfer.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpTransfer.Location = new System.Drawing.Point(71, 33);
		this.dtpTransfer.Name = "dtpTransfer";
		this.dtpTransfer.Size = new System.Drawing.Size(138, 20);
		this.dtpTransfer.TabIndex = 0;
		this.cboStorageFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboStorageFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboStorageFrom.FormattingEnabled = true;
		this.cboStorageFrom.Location = new System.Drawing.Point(71, 59);
		this.cboStorageFrom.Name = "cboStorageFrom";
		this.cboStorageFrom.Size = new System.Drawing.Size(139, 21);
		this.cboStorageFrom.TabIndex = 2;
		this.cboStorageTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboStorageTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboStorageTo.FormattingEnabled = true;
		this.cboStorageTo.Location = new System.Drawing.Point(71, 86);
		this.cboStorageTo.Name = "cboStorageTo";
		this.cboStorageTo.Size = new System.Drawing.Size(139, 21);
		this.cboStorageTo.TabIndex = 3;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(9, 36);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(46, 13);
		this.Label1.TabIndex = 9;
		this.Label1.Text = "Tanggal";
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(11, 62);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(27, 13);
		this.Label3.TabIndex = 11;
		this.Label3.Text = "Asal";
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(9, 91);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(40, 13);
		this.Label4.TabIndex = 12;
		this.Label4.Text = "Tujuan";
		this.Label11.BackColor = System.Drawing.Color.Silver;
		this.Label11.Location = new System.Drawing.Point(-149, 435);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(713, 51);
		this.Label11.TabIndex = 119;
		this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnHistory.Location = new System.Drawing.Point(262, 444);
		this.btnHistory.Name = "btnHistory";
		this.btnHistory.Size = new System.Drawing.Size(50, 25);
		this.btnHistory.TabIndex = 24;
		this.btnHistory.Text = "Histor&y";
		this.btnHistory.UseVisualStyleBackColor = true;
		this.btnSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSaveClose.Location = new System.Drawing.Point(108, 444);
		this.btnSaveClose.Name = "btnSaveClose";
		this.btnSaveClose.Size = new System.Drawing.Size(93, 25);
		this.btnSaveClose.TabIndex = 22;
		this.btnSaveClose.Text = "Simpan && &Tutup";
		this.btnSaveClose.UseVisualStyleBackColor = true;
		this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDelete.Location = new System.Drawing.Point(207, 444);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new System.Drawing.Size(49, 25);
		this.btnDelete.TabIndex = 23;
		this.btnDelete.Text = "&Hapus";
		this.btnDelete.UseVisualStyleBackColor = true;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(16, 444);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(86, 25);
		this.btnSave.TabIndex = 21;
		this.btnSave.Text = "&Simpan && Baru";
		this.btnSave.UseVisualStyleBackColor = true;
		this.lblStorageTo.AutoSize = true;
		this.lblStorageTo.Location = new System.Drawing.Point(69, 91);
		this.lblStorageTo.Name = "lblStorageTo";
		this.lblStorageTo.Size = new System.Drawing.Size(67, 13);
		this.lblStorageTo.TabIndex = 130;
		this.lblStorageTo.Text = "lblStorageTo";
		this.lblStorageFrom.AutoSize = true;
		this.lblStorageFrom.Location = new System.Drawing.Point(69, 62);
		this.lblStorageFrom.Name = "lblStorageFrom";
		this.lblStorageFrom.Size = new System.Drawing.Size(77, 13);
		this.lblStorageFrom.TabIndex = 131;
		this.lblStorageFrom.Text = "lblStorageFrom";
		this.lblNumber.AutoSize = true;
		this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblNumber.Location = new System.Drawing.Point(68, 12);
		this.lblNumber.Name = "lblNumber";
		this.lblNumber.Size = new System.Drawing.Size(54, 13);
		this.lblNumber.TabIndex = 208;
		this.lblNumber.Text = "lblNumber";
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(9, 12);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(38, 13);
		this.Label2.TabIndex = 207;
		this.Label2.Text = "Nomer";
		this.TabControl1.Controls.Add(this.TabPage1);
		this.TabControl1.Location = new System.Drawing.Point(12, 113);
		this.TabControl1.Name = "TabControl1";
		this.TabControl1.SelectedIndex = 0;
		this.TabControl1.Size = new System.Drawing.Size(367, 314);
		this.TabControl1.TabIndex = 10;
		this.TabPage1.Controls.Add(this.dgvItem);
		this.TabPage1.Controls.Add(this.btnItem);
		this.TabPage1.Location = new System.Drawing.Point(4, 22);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage1.Size = new System.Drawing.Size(359, 288);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = "Barang";
		this.TabPage1.UseVisualStyleBackColor = true;
		this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvItem.Location = new System.Drawing.Point(6, 43);
		this.dgvItem.Name = "dgvItem";
		this.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dgvItem.Size = new System.Drawing.Size(346, 239);
		this.dgvItem.TabIndex = 12;
		this.btnItem.BackColor = System.Drawing.SystemColors.ButtonFace;
		this.btnItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnItem.Location = new System.Drawing.Point(6, 10);
		this.btnItem.Name = "btnItem";
		this.btnItem.Size = new System.Drawing.Size(61, 24);
		this.btnItem.TabIndex = 11;
		this.btnItem.Text = "+ Barang";
		this.btnItem.UseVisualStyleBackColor = false;
		this.btnPrint.BackColor = System.Drawing.SystemColors.ButtonFace;
		this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnPrint.Location = new System.Drawing.Point(318, 444);
		this.btnPrint.Name = "btnPrint";
		this.btnPrint.Size = new System.Drawing.Size(57, 25);
		this.btnPrint.TabIndex = 25;
		this.btnPrint.Text = "Cetak";
		this.btnPrint.UseVisualStyleBackColor = false;
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(387, 477);
		base.Controls.Add(this.btnPrint);
		base.Controls.Add(this.lblNumber);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.TabControl1);
		base.Controls.Add(this.lblStorageFrom);
		base.Controls.Add(this.lblStorageTo);
		base.Controls.Add(this.btnHistory);
		base.Controls.Add(this.btnSaveClose);
		base.Controls.Add(this.btnDelete);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.Label11);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.cboStorageTo);
		base.Controls.Add(this.cboStorageFrom);
		base.Controls.Add(this.dtpTransfer);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "frmTransfer";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Transfer Stok - Input";
		this.TabControl1.ResumeLayout(false);
		this.TabPage1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgvItem).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmTransfer()
	{
		base.KeyDown += frmTransfer_KeyDown;
		InitializeComponent();
		base.MdiParent = MyProject.Forms.frmMenu;
		DoubleBuffered = true;
		ComboBox combo = cboStorageFrom;
		cCombo.getStorage(ref combo, Module1.pubGroupId, 0, "ALL", blnAll: false, 1);
		cboStorageFrom = combo;
		combo = cboStorageTo;
		cCombo.getStorage(ref combo, Module1.pubGroupId, 0, "ALL", blnAll: false, 1);
		cboStorageTo = combo;
		formatGrid();
	}

	private void frmTransfer_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void formatGrid()
	{
		dgvItem.Columns.Add("", "itemId");
		dgvItem.Columns.Add("", "Barang");
		dgvItem.Columns.Add("", "Jumlah");
		dgvItem.Columns[0].Visible = false;
		dgvItem.Columns[1].Width = 120;
		dgvItem.Columns[2].Width = 100;
		dgvItem.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItem.RowHeadersVisible = false;
		dgvItem.AllowUserToAddRows = false;
		dgvItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvItem.ReadOnly = true;
		dgvItem.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvItem.AllowUserToResizeRows = false;
	}

	public void prepareForm(bool SaveNew)
	{
		_currentId = 0.0;
		_TransferItem = null;
		dgvItem.Rows.Clear();
		lblNumber.Text = "auto";
		lblStorageFrom.Text = "";
		lblStorageFrom.Visible = false;
		cboStorageFrom.Visible = true;
		lblStorageTo.Text = "";
		lblStorageTo.Visible = false;
		cboStorageTo.Visible = true;
		dtpTransfer.Enabled = true;
		if (!SaveNew)
		{
			dtpTransfer.Value = DateAndTime.Now;
			cboStorageFrom.SelectedIndex = -1;
		}
		_dateIsChanged = false;
		cboStorageTo.SelectedIndex = -1;
		intOriginalItemId = 0;
		OriginalStorageId = 0;
		OriginalDate = DateAndTime.Now;
		btnDelete.Enabled = false;
		btnHistory.Enabled = false;
		_edited = false;
		btnPrint.Enabled = false;
		dtpTransfer.Focus();
	}

	public void loadData()
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
					cTransfer cTransfer2 = new cTransfer(_currentId);
					OriginalStorageId = cTransfer2.StorageFromId;
					OriginalDate = cTransfer2.TransferDate;
					dtpTransfer.Value = cTransfer2.TransferDate;
					lblNumber.Text = cTransfer2.TransferNumber;
					lblStorageFrom.Text = cTransfer2.StorageFromName;
					lblStorageTo.Text = cTransfer2.StorageToName;
					ComboBox cboSource = cboStorageFrom;
					Module1.comboBoundValue(ref cboSource, cTransfer2.StorageFromId);
					cboStorageFrom = cboSource;
					cboSource = cboStorageTo;
					Module1.comboBoundValue(ref cboSource, cTransfer2.StorageToId);
					cboStorageTo = cboSource;
					_dateIsChanged = false;
					_TransferItem = cTransfer2.Item;
					cTransferItem[] item = cTransfer2.Item;
					foreach (cTransferItem cTransferItem2 in item)
					{
						dgvItem.Rows.Add(cTransferItem2.ItemId, cTransferItem2.ItemName, Module1.formatCustomDecimal(Conversions.ToString(cTransferItem2.Qty), 3));
					}
					if (dgvItem.RowCount > 0)
					{
						dgvItem.CurrentRow.Selected = false;
					}
					DateTime createdDate = cTransfer2.CreatedDate;
					if (DateAndTime.DateDiff(DateInterval.Day, dtpTransfer.Value, DateAndTime.Now) <= Module1.pubDaysLimit)
					{
						dtpTransfer.Enabled = true;
					}
					else
					{
						dtpTransfer.Enabled = false;
					}
					if (DateAndTime.DateDiff(DateInterval.Day, createdDate, DateAndTime.Now) <= Module1.pubDaysLimit)
					{
						btnDelete.Enabled = true;
					}
					else
					{
						btnDelete.Enabled = false;
					}
					btnHistory.Enabled = true;
					btnPrint.Enabled = true;
					_edited = false;
					goto end_IL_0001;
				}
				case 588:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmTransfer", "loadData", "");
						if (Information.Err().Number == 513)
						{
							Close();
						}
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 588;
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

	private void dtpTransfer_ValueChanged(object sender, EventArgs e)
	{
		_edited = true;
		if (dgvItem.RowCount > 0)
		{
			_dateIsChanged = true;
		}
	}

	private void cboStorageFrom_SelectedIndexChanged(object sender, EventArgs e)
	{
		_edited = true;
		if (dgvItem.RowCount > 0)
		{
			_dateIsChanged = true;
		}
	}

	private void cboStorageTo_SelectedIndexChanged(object sender, EventArgs e)
	{
		_edited = true;
		if (dgvItem.RowCount > 0)
		{
			_dateIsChanged = true;
		}
	}

	private void btnItem_Click(object sender, EventArgs e)
	{
		if (cboStorageFrom.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih gudang asal", (MsgBoxStyle)(-2147483637));
			cboStorageFrom.Focus();
			return;
		}
		if (cboStorageTo.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih gudang tujuan", (MsgBoxStyle)(-2147483637));
			cboStorageTo.Focus();
			return;
		}
		cComboItem cComboItem2 = (cComboItem)cboStorageFrom.SelectedItem;
		cComboItem cComboItem3 = (cComboItem)cboStorageTo.SelectedItem;
		frmTransferItem frmTransferItem2 = new frmTransferItem(CurrentData: false, Conversions.ToInteger(cComboItem2.Value), Conversions.ToInteger(cComboItem3.Value));
		frmTransferItem2.ShowDialog();
		frmTransferItem2.Close();
		frmTransferItem2.Dispose();
	}

	private void dgvItem_GotFocus(object sender, EventArgs e)
	{
		if (dgvItem.RowCount > 0)
		{
			dgvItem.CurrentRow.Selected = true;
		}
	}

	private void dgvItem_LostFocus(object sender, EventArgs e)
	{
		if (dgvItem.RowCount > 0)
		{
			dgvItem.CurrentRow.Selected = false;
		}
	}

	private void dgvItem_DoubleClick(object sender, EventArgs e)
	{
		OpenItem();
	}

	private void dgvItem_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			OpenItem();
			e.SuppressKeyPress = true;
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			btnItem.Focus();
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			btnSave.Focus();
			e.SuppressKeyPress = true;
		}
	}

	private void OpenItem()
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
					if (cboStorageFrom.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih gudang asal", (MsgBoxStyle)(-2147483637));
						cboStorageFrom.Focus();
						goto end_IL_0001;
					}
					if (cboStorageTo.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih gudang tujuan", (MsgBoxStyle)(-2147483637));
						cboStorageTo.Focus();
						goto end_IL_0001;
					}
					cComboItem cComboItem2 = (cComboItem)cboStorageFrom.SelectedItem;
					cComboItem cComboItem3 = (cComboItem)cboStorageTo.SelectedItem;
					if (dgvItem.Rows.Count > 0)
					{
						frmTransferItem frmTransferItem2 = new frmTransferItem(CurrentData: true, Conversions.ToInteger(cComboItem2.Value), Conversions.ToInteger(cComboItem3.Value));
						frmTransferItem2.TransferItem = _TransferItem;
						ComboBox cboSource = frmTransferItem2.cboItem;
						Module1.comboBoundValue(ref cboSource, Conversions.ToDouble(dgvItem[0, dgvItem.CurrentRow.Index].Value));
						frmTransferItem2.cboItem = cboSource;
						frmTransferItem2.txtQty.Text = Module1.formatCustomDecimal(Conversions.ToString(dgvItem[2, dgvItem.CurrentRow.Index].Value), 3);
						frmTransferItem2.ShowDialog();
					}
					goto end_IL_0001;
				}
				case 386:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmTransfer", "OpenItem", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 386;
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

	private void btnSave_Click(object sender, EventArgs e)
	{
		saveData(CloseForm: false);
	}

	private void btnSaveClose_Click(object sender, EventArgs e)
	{
		saveData(CloseForm: true);
	}

	private void saveData(bool CloseForm)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		int itemId = default(int);
		double qty = default(double);
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
						cComboItem cComboItem2 = (cComboItem)cboStorageFrom.SelectedItem;
						cComboItem cComboItem3 = (cComboItem)cboStorageTo.SelectedItem;
						string text = "";
						if (!cValidation.isDateWithinRange(dtpTransfer.Value, Module1.pubGroupId, Module1.pubDaysLimit))
						{
							Interaction.MsgBox("Tanggal diluar batas yang diperbolehkan", MsgBoxStyle.Information);
							dtpTransfer.Focus();
							goto end_IL_0001;
						}
						if (cboStorageFrom.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih gudang asal", MsgBoxStyle.Information);
							cboStorageFrom.Focus();
							goto end_IL_0001;
						}
						if (cboStorageTo.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih gudang tujuan", MsgBoxStyle.Information);
							cboStorageTo.Focus();
							goto end_IL_0001;
						}
						if (cboStorageFrom.SelectedIndex == cboStorageTo.SelectedIndex)
						{
							Interaction.MsgBox("Gudang tujuan harus berbeda dari gudang asal", MsgBoxStyle.Information);
							cboStorageTo.Focus();
							goto end_IL_0001;
						}
						if (dgvItem.Rows.Count == 0)
						{
							Interaction.MsgBox("Masukkan barang yang ditransfer", MsgBoxStyle.Information);
							btnItem.Focus();
							goto end_IL_0001;
						}
						int i;
						if ((dgvItem.RowCount > 0) & _dateIsChanged)
						{
							text = ". Catatan: Stok dicek ulang.";
							int num3 = dgvItem.RowCount - 1;
							for (i = 0; i <= num3; i++)
							{
								if (!Information.IsNothing(_TransferItem))
								{
									cTransferItem[] transferItem = _TransferItem;
									foreach (cTransferItem cTransferItem2 in transferItem)
									{
										if (Operators.ConditionalCompareObjectEqual(cTransferItem2.ItemId, dgvItem[0, i].Value, TextCompare: false))
										{
											itemId = cTransferItem2.ItemId;
											qty = cTransferItem2.Qty;
											break;
										}
									}
								}
								if (!cValidation.isInStock(Module1.pubCheckStock, Module1.pubBalanceDate, dtpTransfer.Value, "", OriginalDate, Conversions.ToInteger(dgvItem[0, i].Value), itemId, Conversions.ToDouble(dgvItem[2, i].Value), qty, Conversions.ToInteger(cComboItem2.Value), OriginalStorageId, Module1.pubGroupId, 2))
								{
									Module1.SaveDebug("Transfer - Stok dicek ulang dan tidak tersedia - " + Module1.pubLogin);
									Interaction.MsgBox(Operators.ConcatenateObject(Operators.ConcatenateObject("Stok ", dgvItem[1, i].Value), " tidak tersedia"), MsgBoxStyle.Information);
									dgvItem.Focus();
									goto end_IL_0001;
								}
							}
						}
						cTransfer cTransfer2 = new cTransfer(_currentId);
						cTransferItem[] array = new cTransferItem[dgvItem.Rows.Count - 1 + 1];
						cTransfer2.CurrentItem = cTransfer2.Item;
						cTransfer2.CurrentStorageFrom = cTransfer2.StorageFromId;
						cTransfer2.CurrentStorageTo = cTransfer2.StorageToId;
						cTransfer2.CurrentDate = cTransfer2.TransferDate;
						i = 0;
						cTransfer2.StorageFromId = Conversions.ToInteger(cComboItem2.Value);
						cTransfer2.StorageToId = Conversions.ToInteger(cComboItem3.Value);
						cTransfer2.TransferDate = dtpTransfer.Value;
						int num4 = dgvItem.Rows.Count - 1;
						for (i = 0; i <= num4; i++)
						{
							array[i] = new cTransferItem();
							array[i].ItemId = Conversions.ToInteger(dgvItem[0, i].Value);
							array[i].Qty = Conversions.ToDouble(dgvItem[2, i].Value);
						}
						cTransfer2.Item = array;
						cTransfer2.save();
						if (Operators.CompareString(lblNumber.Text, "auto", TextCompare: false) == 0)
						{
							lblNumber.Text = "TRF/" + Conversions.ToString(cTransfer2.StorageFromId) + "/" + Strings.Right(Conversions.ToString(DateAndTime.Year(cTransfer2.TransferDate)), 2) + "/" + cTransfer2.TransferNumber;
						}
						string text2 = "Tanggal: " + Conversions.ToString(dtpTransfer.Value) + "<br />Asal: " + cboStorageFrom.Text + "<br />Tujuan: " + cboStorageTo.Text + "<br />";
						text2 += "Barang:<br />";
						text2 += "<table><tr><td>Barang</ td><td>Jumlah</ td></tr>";
						int num5 = dgvItem.Rows.Count - 1;
						for (i = 0; i <= num5; i++)
						{
							text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<tr><td>", dgvItem[1, i].Value), "</ td>"), "<td align='right'>"), Module1.formatCustomDecimal(Conversions.ToString(dgvItem[2, i].Value), 3)), "</ td></tr>")));
						}
						text2 += "</table>";
						string text3;
						if (_currentId == 0.0)
						{
							text3 = "membuat ";
							_currentId = cTransfer2.Id;
						}
						else
						{
							text3 = "mengupdate ";
						}
						text3 = text3 + "Transfer " + lblNumber.Text + " dari gudang " + cboStorageFrom.Text + " ke gudang " + cboStorageTo.Text + ". Tanggal transfer " + Strings.Format(dtpTransfer.Value, "dd/MM/yyyy") + ". ID=" + Conversions.ToString(_currentId) + ", v2";
						text3 += text;
						cHistory cHistory2 = new cHistory();
						cHistory2.Content = text2;
						cHistory2.Description = text3;
						cHistory2.UserId = Module1.pubUserId;
						cHistory2.UserLogin = Module1.pubLogin;
						cHistory2.fKeyId = _currentId;
						cHistory2.HistoryType = 4;
						cHistory2.Save();
						Interaction.MsgBox("Transfer berhasil disimpan", MsgBoxStyle.Information);
						if (Module1.FormIsOpen("frmTransferList"))
						{
							MyProject.Forms.frmTransferList.GetRecent();
						}
						MyProject.Forms.frmInformation.GetActivity();
						if (CloseForm)
						{
							Close();
							goto end_IL_0001;
						}
						prepareForm(SaveNew: true);
						btnPrint.Enabled = true;
						_edited = false;
						cboStorageTo.Focus();
						goto end_IL_0001;
					}
					case 1912:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmTransfer", "saveData", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1912;
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
					if (MessageBox.Show("Hapus Transfer Stok?", "Konfirmasi", MessageBoxButtons.YesNo) != DialogResult.No)
					{
						cTransfer cTransfer2 = new cTransfer(_currentId);
						cTransfer2.CurrentItem = cTransfer2.Item;
						cTransfer2.CurrentStorageFrom = cTransfer2.StorageFromId;
						cTransfer2.CurrentStorageTo = cTransfer2.StorageToId;
						cTransfer2.CurrentDate = cTransfer2.TransferDate;
						cTransfer2.Delete();
						string description = "menghapus transfer " + cTransfer2.TransferNumber + ". Tanggal " + Strings.Format(cTransfer2.TransferDate, "dd/MM/yyyy") + " , ID=" + Conversions.ToString(_currentId) + ", v2";
						cHistory cHistory2 = new cHistory();
						cHistory2.Description = description;
						cHistory2.UserId = Module1.pubUserId;
						cHistory2.UserLogin = Module1.pubLogin;
						cHistory2.fKeyId = _currentId;
						cHistory2.HistoryType = 4;
						cHistory2.Save();
						Interaction.MsgBox("Transfer berhasil dihapus", MsgBoxStyle.Information);
						if (Module1.FormIsOpen("frmTransferList"))
						{
							MyProject.Forms.frmTransferList.GetRecent();
						}
						MyProject.Forms.frmInformation.GetActivity();
						Close();
					}
					goto end_IL_0001;
				case 378:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmTransfer", "btnDelete_Click", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 378;
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
		MyProject.Forms.frmHistory.GetHistory(checked((int)Math.Round(_currentId)), 4);
		MyProject.Forms.frmHistory.Show();
		MyProject.Forms.frmHistory.Activate();
		MyProject.Forms.frmHistory.WindowState = FormWindowState.Normal;
	}

	private void btnPrint_Click(object sender, EventArgs e)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
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
						if (_edited && btnSave.Enabled)
						{
							if (MessageBox.Show("Anda melakukan perubahan data.\r\nSimpan Transfer sebelum mencetak?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
							{
								saveData(CloseForm: false);
							}
							goto end_IL_0001;
						}
						Printer val = new Printer();
						val.ScaleMode = 6;
						val.Width = 11907;
						val.Height = 7880;
						val.Font = new Font("Times New Roman", 11f);
						double num3 = 1.0;
						int num4 = 5;
						val.CurrentX = num4;
						val.CurrentY = (float)(num3 + 3.0);
						val.Print(new object[1] { "Transfer Stok: " + lblNumber.Text });
						val.CurrentX = num4;
						val.CurrentY = (float)(num3 + 8.0);
						val.Print(new object[1] { "Tanggal: " + Strings.Format(dtpTransfer.Value, "d MMMM yyyy") });
						val.CurrentX = num4;
						val.CurrentY = (float)(num3 + 13.0);
						val.Print(new object[1] { "Gudang asal: " + cboStorageFrom.Text });
						val.CurrentX = num4;
						val.CurrentY = (float)(num3 + 18.0);
						val.Print(new object[1] { "Gudang tujuan: " + cboStorageTo.Text });
						val.Font = new Font("Times New Roman", 9f);
						int num5 = (int)Math.Round(num3 + 28.0);
						int rowCount = dgvItem.RowCount;
						for (int i = 0; i <= rowCount; i++)
						{
							val.Line(5f, (float)num5, 13f, (float)(num5 + 5), -1, true, false);
							val.Line(13f, (float)num5, 85f, (float)(num5 + 5), -1, true, false);
							val.Line(85f, (float)num5, 115f, (float)(num5 + 5), -1, true, false);
							num5 += 5;
						}
						num5 = (int)Math.Round(num3 + 34.0);
						int num6 = dgvItem.RowCount - 1;
						for (int i = 0; i <= num6; i++)
						{
							val.CurrentX = 8f;
							val.CurrentY = num5;
							val.Print(new object[1] { i + 1 });
							val.CurrentX = 15f;
							val.CurrentY = num5;
							val.Print(new object[1] { dgvItem[1, i].Value });
							val.CurrentX = 110f - val.TextWidth(Module1.formatCustomDecimal(Conversions.ToString(dgvItem[2, i].Value), 3));
							val.CurrentY = num5;
							val.Print(new object[1] { Module1.formatCustomDecimal(Conversions.ToString(dgvItem[2, i].Value), 3) });
							num5 += 5;
						}
						num5 = (int)Math.Round(num3 + 29.0);
						val.CurrentX = 7f;
						val.CurrentY = num5;
						val.Print(new object[1] { "No." });
						val.CurrentX = 15f;
						val.CurrentY = num5;
						val.Print(new object[1] { "Nama Barang" });
						val.CurrentX = 87f;
						val.CurrentY = num5;
						val.Print(new object[1] { "Jumlah" });
						val.NewPage();
						val.EndDoc();
						goto end_IL_0001_2;
					}
					case 1050:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmTransfer", "btnPrint_click", "");
							goto end_IL_0001_2;
						}
						break;
					}
					goto IL_0450;
				}
				end_IL_0001_2:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1050;
				continue;
			}
			break;
			IL_0450:
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
