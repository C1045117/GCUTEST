using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GCUv2.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

[DesignerGenerated]
public class frmReceivedItem : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboStorage")]
	private ComboBox _cboStorage;

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
	[AccessedThroughProperty("btnHistory")]
	private Button _btnHistory;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboSupplier")]
	private ComboBox _cboSupplier;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("lblInformation")]
	private Label _lblInformation;

	private double _currentId;

	public DateTime OriginalDate;

	public int OriginalStorageId;

	private cReceivedItemItem[] _RIItem;

	private double _invoiceId;

	[field: AccessedThroughProperty("lblNumber")]
	internal virtual Label lblNumber
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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dtpRI")]
	internal virtual DateTimePicker dtpRI
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

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("lblSupplier")]
	internal virtual Label lblSupplier
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

	internal virtual ComboBox cboSupplier
	{
		[CompilerGenerated]
		get
		{
			return _cboSupplier;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cboSupplier_SelectedIndexChanged;
			ComboBox comboBox = _cboSupplier;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_cboSupplier = value;
			comboBox = _cboSupplier;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	internal virtual Label lblInformation
	{
		[CompilerGenerated]
		get
		{
			return _lblInformation;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = lblInformation_Click;
			Label label = _lblInformation;
			if (label != null)
			{
				label.Click -= value2;
			}
			_lblInformation = value;
			label = _lblInformation;
			if (label != null)
			{
				label.Click += value2;
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
		this.lblNumber = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.cboStorage = new System.Windows.Forms.ComboBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.lblStorage = new System.Windows.Forms.Label();
		this.TabControl1 = new System.Windows.Forms.TabControl();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.dgvItem = new System.Windows.Forms.DataGridView();
		this.btnItem = new System.Windows.Forms.Button();
		this.Label1 = new System.Windows.Forms.Label();
		this.dtpRI = new System.Windows.Forms.DateTimePicker();
		this.Label10 = new System.Windows.Forms.Label();
		this.btnSaveClose = new System.Windows.Forms.Button();
		this.btnDelete = new System.Windows.Forms.Button();
		this.btnSave = new System.Windows.Forms.Button();
		this.btnHistory = new System.Windows.Forms.Button();
		this.lblSupplier = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.cboSupplier = new System.Windows.Forms.ComboBox();
		this.lblInformation = new System.Windows.Forms.Label();
		this.TabControl1.SuspendLayout();
		this.TabPage1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvItem).BeginInit();
		base.SuspendLayout();
		this.lblNumber.AutoSize = true;
		this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblNumber.Location = new System.Drawing.Point(66, 37);
		this.lblNumber.Name = "lblNumber";
		this.lblNumber.Size = new System.Drawing.Size(54, 13);
		this.lblNumber.TabIndex = 205;
		this.lblNumber.Text = "lblNumber";
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(12, 37);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(38, 13);
		this.Label3.TabIndex = 204;
		this.Label3.Text = "Nomer";
		this.cboStorage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboStorage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboStorage.FormattingEnabled = true;
		this.cboStorage.Location = new System.Drawing.Point(68, 83);
		this.cboStorage.Name = "cboStorage";
		this.cboStorage.Size = new System.Drawing.Size(139, 21);
		this.cboStorage.TabIndex = 3;
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(12, 86);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(45, 13);
		this.Label4.TabIndex = 203;
		this.Label4.Text = "Gudang";
		this.lblStorage.AutoSize = true;
		this.lblStorage.Location = new System.Drawing.Point(66, 86);
		this.lblStorage.Name = "lblStorage";
		this.lblStorage.Size = new System.Drawing.Size(54, 13);
		this.lblStorage.TabIndex = 206;
		this.lblStorage.Text = "lblStorage";
		this.TabControl1.Controls.Add(this.TabPage1);
		this.TabControl1.Location = new System.Drawing.Point(14, 110);
		this.TabControl1.Name = "TabControl1";
		this.TabControl1.SelectedIndex = 0;
		this.TabControl1.Size = new System.Drawing.Size(367, 239);
		this.TabControl1.TabIndex = 10;
		this.TabPage1.Controls.Add(this.dgvItem);
		this.TabPage1.Controls.Add(this.btnItem);
		this.TabPage1.Location = new System.Drawing.Point(4, 22);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage1.Size = new System.Drawing.Size(359, 213);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = "Barang";
		this.TabPage1.UseVisualStyleBackColor = true;
		this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvItem.Location = new System.Drawing.Point(6, 40);
		this.dgvItem.Name = "dgvItem";
		this.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dgvItem.Size = new System.Drawing.Size(346, 167);
		this.dgvItem.TabIndex = 12;
		this.btnItem.BackColor = System.Drawing.SystemColors.ButtonFace;
		this.btnItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnItem.Location = new System.Drawing.Point(6, 10);
		this.btnItem.Name = "btnItem";
		this.btnItem.Size = new System.Drawing.Size(61, 24);
		this.btnItem.TabIndex = 11;
		this.btnItem.Text = "+ Barang";
		this.btnItem.UseVisualStyleBackColor = false;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(11, 60);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(46, 13);
		this.Label1.TabIndex = 198;
		this.Label1.Text = "Tanggal";
		this.dtpRI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpRI.Location = new System.Drawing.Point(68, 57);
		this.dtpRI.Name = "dtpRI";
		this.dtpRI.Size = new System.Drawing.Size(121, 20);
		this.dtpRI.TabIndex = 2;
		this.Label10.BackColor = System.Drawing.Color.Silver;
		this.Label10.Location = new System.Drawing.Point(-49, 380);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(713, 59);
		this.Label10.TabIndex = 212;
		this.btnSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSaveClose.Location = new System.Drawing.Point(173, 389);
		this.btnSaveClose.Name = "btnSaveClose";
		this.btnSaveClose.Size = new System.Drawing.Size(93, 24);
		this.btnSaveClose.TabIndex = 21;
		this.btnSaveClose.Text = "Simpan && &Tutup";
		this.btnSaveClose.UseVisualStyleBackColor = true;
		this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDelete.Location = new System.Drawing.Point(272, 389);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new System.Drawing.Size(49, 24);
		this.btnDelete.TabIndex = 22;
		this.btnDelete.Text = "Hapus";
		this.btnDelete.UseVisualStyleBackColor = true;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(81, 389);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(86, 24);
		this.btnSave.TabIndex = 20;
		this.btnSave.Text = "&Simpan && Baru";
		this.btnSave.UseVisualStyleBackColor = true;
		this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnHistory.Location = new System.Drawing.Point(327, 389);
		this.btnHistory.Name = "btnHistory";
		this.btnHistory.Size = new System.Drawing.Size(50, 24);
		this.btnHistory.TabIndex = 23;
		this.btnHistory.Text = "&History";
		this.btnHistory.UseVisualStyleBackColor = true;
		this.lblSupplier.AutoSize = true;
		this.lblSupplier.Location = new System.Drawing.Point(65, 15);
		this.lblSupplier.Name = "lblSupplier";
		this.lblSupplier.Size = new System.Drawing.Size(55, 13);
		this.lblSupplier.TabIndex = 220;
		this.lblSupplier.Text = "lblSupplier";
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.Location = new System.Drawing.Point(11, 15);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(45, 13);
		this.Label7.TabIndex = 219;
		this.Label7.Text = "Supplier";
		this.cboSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboSupplier.FormattingEnabled = true;
		this.cboSupplier.Location = new System.Drawing.Point(68, 12);
		this.cboSupplier.Name = "cboSupplier";
		this.cboSupplier.Size = new System.Drawing.Size(174, 21);
		this.cboSupplier.TabIndex = 0;
		this.lblInformation.AutoSize = true;
		this.lblInformation.Cursor = System.Windows.Forms.Cursors.Hand;
		this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
		this.lblInformation.ForeColor = System.Drawing.Color.Blue;
		this.lblInformation.Location = new System.Drawing.Point(16, 353);
		this.lblInformation.Name = "lblInformation";
		this.lblInformation.Size = new System.Drawing.Size(82, 15);
		this.lblInformation.TabIndex = 221;
		this.lblInformation.Text = "lblInformation";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(394, 423);
		base.Controls.Add(this.lblInformation);
		base.Controls.Add(this.lblSupplier);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.cboSupplier);
		base.Controls.Add(this.btnSaveClose);
		base.Controls.Add(this.btnDelete);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.btnHistory);
		base.Controls.Add(this.Label10);
		base.Controls.Add(this.lblNumber);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.cboStorage);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.lblStorage);
		base.Controls.Add(this.TabControl1);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.dtpRI);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmReceivedItem";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Penerimaan Barang";
		this.TabControl1.ResumeLayout(false);
		this.TabPage1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgvItem).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmReceivedItem()
	{
		base.KeyDown += frmReceivedItem_KeyDown;
		int try001b_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try001b_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					InitializeComponent();
					DoubleBuffered = true;
					base.MdiParent = MyProject.Forms.frmMenu;
					ComboBox combo = cboSupplier;
					cCombo.getSupplier(ref combo, Module1.pubGroupId, All: false, FlowerOnly: false, IncludeParent: false, Active: true);
					cboSupplier = combo;
					combo = cboStorage;
					cCombo.getStorage(ref combo, Module1.pubGroupId, 0, "MARKETING_RETURN", blnAll: false, 1);
					cboStorage = combo;
					formatGrid();
					goto end_IL_001b;
				}
				case 174:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmReceivedItem", "New", "");
						goto end_IL_001b;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try001b_dispatch = 174;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_001b:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void formatGrid()
	{
		dgvItem.Columns.Add("", "itemId");
		dgvItem.Columns.Add("", "Barang");
		dgvItem.Columns.Add("", "Jumlah");
		dgvItem.Columns.Add("", "Unit");
		dgvItem.Columns.Add("", "Jumlah");
		dgvItem.Columns.Add("", "Jml. Stok");
		dgvItem.Columns.Add("", "Jml. (stok)");
		dgvItem.Columns[0].Visible = false;
		dgvItem.Columns[1].Width = 120;
		dgvItem.Columns[2].Visible = false;
		dgvItem.Columns[3].Visible = false;
		dgvItem.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItem.Columns[4].Width = 100;
		dgvItem.Columns[5].Visible = false;
		dgvItem.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItem.Columns[6].Width = 100;
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
		_invoiceId = 0.0;
		_RIItem = null;
		dgvItem.Rows.Clear();
		cboSupplier.Visible = true;
		lblSupplier.Visible = false;
		lblSupplier.Text = "";
		cboStorage.Visible = true;
		lblNumber.Text = "auto";
		lblStorage.Text = "";
		lblStorage.Visible = false;
		if (!SaveNew)
		{
			cboStorage.SelectedIndex = -1;
			dtpRI.Value = DateAndTime.Now;
		}
		dtpRI.Enabled = true;
		lblInformation.Text = "";
		btnDelete.Enabled = false;
		btnHistory.Enabled = false;
		OriginalDate = DateAndTime.Now;
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
					cReceivedItem cReceivedItem2 = new cReceivedItem(_currentId);
					ComboBox cboSource = cboSupplier;
					Module1.comboBoundValue(ref cboSource, cReceivedItem2.SupplierId);
					cboSupplier = cboSource;
					cboSupplier.Visible = false;
					lblSupplier.Text = cReceivedItem2.SupplierName;
					lblSupplier.Visible = true;
					lblNumber.Text = cReceivedItem2.Number;
					dtpRI.Value = cReceivedItem2.RIDate;
					OriginalDate = cReceivedItem2.RIDate;
					cboSource = cboStorage;
					Module1.comboBoundValue(ref cboSource, cReceivedItem2.StorageId);
					cboStorage = cboSource;
					lblStorage.Visible = true;
					lblStorage.Text = cReceivedItem2.StorageName;
					_RIItem = cReceivedItem2.Item;
					cReceivedItemItem[] item = cReceivedItem2.Item;
					foreach (cReceivedItemItem cReceivedItemItem2 in item)
					{
						dgvItem.Rows.Add(cReceivedItemItem2.ItemId, cReceivedItemItem2.ItemName, Module1.formatCustomDecimal(Conversions.ToString(cReceivedItemItem2.RIQty), 3), cReceivedItemItem2.UnitName, Module1.formatCustomDecimal(Conversions.ToString(cReceivedItemItem2.RIQty), 3) + " " + cReceivedItemItem2.UnitName, Module1.formatCustomDecimal(Conversions.ToString(cReceivedItemItem2.StockQty), 3), Module1.formatCustomDecimal(Conversions.ToString(cReceivedItemItem2.StockQty), 3) + " " + cReceivedItemItem2.BaseUnitName);
					}
					if (dgvItem.RowCount > 0)
					{
						dgvItem.CurrentRow.Selected = false;
					}
					_invoiceId = cReceivedItem2.InvoiceId;
					if (DateAndTime.DateDiff(DateInterval.Day, dtpRI.Value, DateAndTime.Now) <= Module1.pubDaysLimit)
					{
						dtpRI.Enabled = true;
					}
					else
					{
						dtpRI.Enabled = false;
					}
					if (Operators.CompareString(cReceivedItem2.InvoiceNumber, "", TextCompare: false) != 0)
					{
						lblInformation.Text = "Sudah dikaitkan dengan Faktur Pembelian: " + cReceivedItem2.InvoiceNumber;
						btnSave.Enabled = false;
						btnSaveClose.Enabled = false;
						btnDelete.Enabled = false;
					}
					else
					{
						btnSave.Enabled = true;
						btnSaveClose.Enabled = true;
						if (DateAndTime.DateDiff(DateInterval.Day, dtpRI.Value, DateAndTime.Now) <= Module1.pubDaysLimit)
						{
							btnDelete.Enabled = true;
						}
						else
						{
							btnDelete.Enabled = false;
						}
					}
					btnHistory.Enabled = true;
					goto end_IL_0001;
				}
				case 836:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmReceivedItem", "loadData", "");
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
				try0001_dispatch = 836;
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

	private void frmReceivedItem_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void cboSupplier_SelectedIndexChanged(object sender, EventArgs e)
	{
		cComboItem expression = (cComboItem)cboSupplier.SelectedItem;
		if (!Information.IsNothing(expression))
		{
			ComboBox combo = cboStorage;
			cCombo.getStorage(ref combo, Module1.pubGroupId, 0, "MARKETING_RETURN", blnAll: false, 1);
			cboStorage = combo;
			cboStorage.Text = "";
			cboStorage.SelectedIndex = -1;
		}
	}

	private void cboStorage_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (dgvItem.RowCount > 0)
		{
			Interaction.MsgBox("Barang akan dihapus karena anda mengganti Gudang.", MsgBoxStyle.Information);
			dgvItem.Rows.Clear();
		}
	}

	private void btnItem_Click(object sender, EventArgs e)
	{
		if (cboSupplier.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih supplier", (MsgBoxStyle)(-2147483637));
			cboSupplier.Focus();
			return;
		}
		if (cboStorage.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih gudang", (MsgBoxStyle)(-2147483637));
			cboStorage.Focus();
			return;
		}
		cComboItem cComboItem2 = (cComboItem)cboStorage.SelectedItem;
		cComboItem cComboItem3 = (cComboItem)cboSupplier.SelectedItem;
		frmReceivedItemItem frmReceivedItemItem2 = new frmReceivedItemItem(CurrentData: false, Conversions.ToInteger(cComboItem3.Value), Conversions.ToInteger(cComboItem2.Value), dtpRI.Value);
		frmReceivedItemItem2.ShowDialog();
		frmReceivedItemItem2.Close();
		frmReceivedItemItem2.Dispose();
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
					if (cboSupplier.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih supplier", (MsgBoxStyle)(-2147483637));
						cboSupplier.Focus();
						goto end_IL_0001;
					}
					if (cboStorage.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih gudang", (MsgBoxStyle)(-2147483637));
						cboStorage.Focus();
						goto end_IL_0001;
					}
					cComboItem cComboItem2 = (cComboItem)cboSupplier.SelectedItem;
					cComboItem cComboItem3 = (cComboItem)cboStorage.SelectedItem;
					if (dgvItem.Rows.Count > 0)
					{
						frmReceivedItemItem frmReceivedItemItem2 = new frmReceivedItemItem(CurrentData: true, Conversions.ToInteger(cComboItem2.Value), Conversions.ToInteger(cComboItem3.Value), dtpRI.Value);
						frmReceivedItemItem2.RIItem = _RIItem;
						ComboBox cboSource = frmReceivedItemItem2.cboItem;
						Module1.comboBoundValue(ref cboSource, Conversions.ToDouble(dgvItem[0, dgvItem.CurrentRow.Index].Value));
						frmReceivedItemItem2.cboItem = cboSource;
						frmReceivedItemItem2.cboItem.Enabled = false;
						frmReceivedItemItem2.txtQty.Text = Module1.formatCustomDecimal(Conversions.ToString(dgvItem[2, dgvItem.CurrentRow.Index].Value), 3);
						frmReceivedItemItem2.txtStockQty.Text = Module1.formatCustomDecimal(Conversions.ToString(dgvItem[5, dgvItem.CurrentRow.Index].Value), 3);
						frmReceivedItemItem2.ShowDialog();
					}
					goto end_IL_0001;
				}
				case 468:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmReceivedItem", "OpenItem", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 468;
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
						cComboItem cComboItem3 = (cComboItem)cboSupplier.SelectedItem;
						if (cboSupplier.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih supplier", MsgBoxStyle.Information);
							cboSupplier.Focus();
							goto end_IL_0001;
						}
						if (!cValidation.isDateWithinRange(dtpRI.Value, Module1.pubGroupId, Module1.pubDaysLimit))
						{
							Interaction.MsgBox("Tanggal diluar batas yang diperbolehkan", MsgBoxStyle.Information);
							dtpRI.Focus();
							goto end_IL_0001;
						}
						if (cboStorage.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih gudang", MsgBoxStyle.Information);
							cboStorage.Focus();
							goto end_IL_0001;
						}
						if (dgvItem.Rows.Count == 0)
						{
							Interaction.MsgBox("Masukkan barang yang dikirim", MsgBoxStyle.Information);
							btnItem.Focus();
							goto end_IL_0001;
						}
						cReceivedItem cReceivedItem2 = new cReceivedItem(_currentId);
						cReceivedItemItem[] array = new cReceivedItemItem[dgvItem.Rows.Count - 1 + 1];
						int num3 = 0;
						cReceivedItem2.CurrentItem = cReceivedItem2.Item;
						cReceivedItem2.CurrentDate = cReceivedItem2.RIDate;
						cReceivedItem2.CurrentStorage = cReceivedItem2.StorageId;
						cReceivedItem2.RIDate = dtpRI.Value;
						cReceivedItem2.StorageId = Conversions.ToInteger(cComboItem2.Value);
						cReceivedItem2.StorageName = cboStorage.Text;
						cReceivedItem2.SupplierId = Conversions.ToInteger(cComboItem3.Value);
						int num4 = dgvItem.Rows.Count - 1;
						for (num3 = 0; num3 <= num4; num3++)
						{
							array[num3] = new cReceivedItemItem();
							array[num3].ItemId = Conversions.ToInteger(dgvItem[0, num3].Value);
							array[num3].RIQty = Conversions.ToDouble(dgvItem[2, num3].Value);
							array[num3].UnitName = Conversions.ToString(dgvItem[3, num3].Value);
							array[num3].StockQty = Conversions.ToDouble(dgvItem[5, num3].Value);
						}
						cReceivedItem2.Item = array;
						cReceivedItem2.save();
						if (Operators.CompareString(lblNumber.Text, "auto", TextCompare: false) == 0)
						{
							lblNumber.Text = "RI/" + Conversions.ToString(cReceivedItem2.StorageId) + "/" + Strings.Right(Conversions.ToString(DateAndTime.Year(cReceivedItem2.RIDate)), 2) + "/" + cReceivedItem2.Number;
						}
						string text = "Tanggal: " + Conversions.ToString(dtpRI.Value) + "<br />Supplier: " + cboSupplier.Text + "<br />Gudang: " + cboStorage.Text + "<br /><br />";
						text += "Barang:<br />";
						text += "<table><tr><td>Barang</ td><td>Jumlah</ td><td>Jml. (stok)</td></tr>";
						int num5 = dgvItem.Rows.Count - 1;
						for (num3 = 0; num3 <= num5; num3++)
						{
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<tr><td>", dgvItem[1, num3].Value), "</ td>"), "<td align='right'>"), dgvItem[4, num3].Value), "</ td>"), "<td align='right'>"), dgvItem[6, num3].Value), "</ td></tr>")));
						}
						text += "</table>";
						string text2;
						if (_currentId == 0.0)
						{
							text2 = "membuat ";
							_currentId = cReceivedItem2.Id;
						}
						else
						{
							text2 = "mengupdate ";
						}
						text2 = text2 + "Penerimaan Barang " + lblNumber.Text + " dari gudang " + cboStorage.Text + ". Tanggal " + Strings.Format(dtpRI.Value, "dd/MM/yyyy") + ". ID= " + Conversions.ToString(_currentId) + ", v2";
						cHistory cHistory2 = new cHistory();
						cHistory2.Content = text;
						cHistory2.Description = text2;
						cHistory2.UserId = Module1.pubUserId;
						cHistory2.UserLogin = Module1.pubLogin;
						cHistory2.fKeyId = _currentId;
						cHistory2.HistoryType = 10;
						cHistory2.Save();
						Interaction.MsgBox("Penerimaan Barang berhasil disimpan", MsgBoxStyle.Information);
						if (Module1.FormIsOpen("frmReceivedItemList"))
						{
							MyProject.Forms.frmReceivedItemList.GetRecent();
						}
						if (Module1.FormIsOpen("frmSupplier"))
						{
							MyProject.Forms.frmSupplier.GetReceiveItem();
						}
						MyProject.Forms.frmInformation.GetActivity();
						if (CloseForm)
						{
							Close();
							goto end_IL_0001;
						}
						prepareForm(SaveNew: true);
						cboSupplier.Focus();
						goto end_IL_0001;
					}
					case 1531:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmReceivedItem", "SaveData", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1531;
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
					if (MessageBox.Show("Hapus Penerimaan Barang?", "Konfirmasi", MessageBoxButtons.YesNo) != DialogResult.No)
					{
						cReceivedItem cReceivedItem2 = new cReceivedItem(_currentId);
						cReceivedItem2.CurrentItem = cReceivedItem2.Item;
						cReceivedItem2.CurrentDate = cReceivedItem2.RIDate;
						cReceivedItem2.CurrentStorage = cReceivedItem2.StorageId;
						cReceivedItem2.Delete();
						string description = "menghapus Penerimaan Barang " + cReceivedItem2.Number + " dari gudang " + cReceivedItem2.StorageName + ". Tanggal  " + Strings.Format(cReceivedItem2.RIDate, "dd/MM/yyyy") + ". ID= " + Conversions.ToString(_currentId) + ", v2";
						cHistory cHistory2 = new cHistory();
						cHistory2.Description = description;
						cHistory2.UserId = Module1.pubUserId;
						cHistory2.UserLogin = Module1.pubLogin;
						cHistory2.fKeyId = _currentId;
						cHistory2.HistoryType = 10;
						cHistory2.Save();
						Interaction.MsgBox("Penerimaan Barang berhasil dihapus", MsgBoxStyle.Information);
						if (Module1.FormIsOpen("frmReceivedItemList"))
						{
							MyProject.Forms.frmReceivedItemList.GetRecent();
						}
						MyProject.Forms.frmInformation.GetActivity();
						Close();
					}
					goto end_IL_0001;
				case 384:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmReceivedItem", "btnDelete_Click", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 384;
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
		MyProject.Forms.frmHistory.GetHistory(checked((int)Math.Round(_currentId)), 10);
		MyProject.Forms.frmHistory.Show();
		MyProject.Forms.frmHistory.Activate();
		MyProject.Forms.frmHistory.WindowState = FormWindowState.Normal;
	}

	private void lblInformation_Click(object sender, EventArgs e)
	{
		MyProject.Forms.frmPurchaseInvoice.Show();
		MyProject.Forms.frmPurchaseInvoice.prepareForm(SaveNew: false, KeepSupplier: false);
		MyProject.Forms.frmPurchaseInvoice.CurrentId = _invoiceId;
		MyProject.Forms.frmPurchaseInvoice.LoadData();
		MyProject.Forms.frmPurchaseInvoice.Activate();
		MyProject.Forms.frmPurchaseInvoice.WindowState = FormWindowState.Normal;
	}
}
