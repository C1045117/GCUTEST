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
public class frmProcess : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboItem")]
	private ComboBox _cboItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboStorage")]
	private ComboBox _cboStorage;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvList")]
	private DataGridView _dgvList;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnStandardComponent")]
	private Button _btnStandardComponent;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnAddComponent")]
	private Button _btnAddComponent;

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

	private double _currentId;

	private int _currentlySelectedComboIndex;

	private bool _suppressComboChange;

	private cComponent[] _component;

	public int intOriginalItemId;

	public int intOriginalStorageId;

	public DateTime dateOriginal;

	public double dblOriginalQty;

	private cComponent[] _originalComponent;

	[field: AccessedThroughProperty("txtQty")]
	internal virtual FilteredTextBox txtQty
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

	internal virtual ComboBox cboItem
	{
		[CompilerGenerated]
		get
		{
			return _cboItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cboItem_SelectedIndexChanged;
			ComboBox comboBox = _cboItem;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_cboItem = value;
			comboBox = _cboItem;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
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

	[field: AccessedThroughProperty("dtpProcess")]
	internal virtual DateTimePicker dtpProcess
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnStandardComponent
	{
		[CompilerGenerated]
		get
		{
			return _btnStandardComponent;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnStandardComponent_Click;
			Button button = _btnStandardComponent;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnStandardComponent = value;
			button = _btnStandardComponent;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button btnAddComponent
	{
		[CompilerGenerated]
		get
		{
			return _btnAddComponent;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnAddComponent_Click;
			Button button = _btnAddComponent;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnAddComponent = value;
			button = _btnAddComponent;
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

	[field: AccessedThroughProperty("lblItem")]
	internal virtual Label lblItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public cComponent[] Component
	{
		get
		{
			return _component;
		}
		set
		{
			_component = value;
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
		this.Label6 = new System.Windows.Forms.Label();
		this.cboItem = new System.Windows.Forms.ComboBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.cboStorage = new System.Windows.Forms.ComboBox();
		this.dtpProcess = new System.Windows.Forms.DateTimePicker();
		this.dgvList = new System.Windows.Forms.DataGridView();
		this.Label3 = new System.Windows.Forms.Label();
		this.btnStandardComponent = new System.Windows.Forms.Button();
		this.btnAddComponent = new System.Windows.Forms.Button();
		this.txtQty = new GCUv2.FilteredTextBox();
		this.Label11 = new System.Windows.Forms.Label();
		this.btnHistory = new System.Windows.Forms.Button();
		this.btnSaveClose = new System.Windows.Forms.Button();
		this.btnDelete = new System.Windows.Forms.Button();
		this.btnSave = new System.Windows.Forms.Button();
		this.lblItem = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		base.SuspendLayout();
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.Location = new System.Drawing.Point(13, 65);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(41, 13);
		this.Label6.TabIndex = 36;
		this.Label6.Text = "Produk";
		this.cboItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboItem.FormattingEnabled = true;
		this.cboItem.Location = new System.Drawing.Point(73, 62);
		this.cboItem.Name = "cboItem";
		this.cboItem.Size = new System.Drawing.Size(138, 21);
		this.cboItem.TabIndex = 2;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(13, 98);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(40, 13);
		this.Label5.TabIndex = 35;
		this.Label5.Text = "Jumlah";
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(13, 36);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(45, 13);
		this.Label4.TabIndex = 34;
		this.Label4.Text = "Gudang";
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(13, 10);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(46, 13);
		this.Label1.TabIndex = 31;
		this.Label1.Text = "Tanggal";
		this.cboStorage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboStorage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboStorage.FormattingEnabled = true;
		this.cboStorage.Location = new System.Drawing.Point(72, 33);
		this.cboStorage.Name = "cboStorage";
		this.cboStorage.Size = new System.Drawing.Size(139, 21);
		this.cboStorage.TabIndex = 1;
		this.dtpProcess.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpProcess.Location = new System.Drawing.Point(73, 7);
		this.dtpProcess.Name = "dtpProcess";
		this.dtpProcess.Size = new System.Drawing.Size(138, 20);
		this.dtpProcess.TabIndex = 0;
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.Location = new System.Drawing.Point(72, 157);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(465, 244);
		this.dgvList.TabIndex = 6;
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(12, 127);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(58, 13);
		this.Label3.TabIndex = 42;
		this.Label3.Text = "Komponen";
		this.btnStandardComponent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnStandardComponent.Location = new System.Drawing.Point(162, 127);
		this.btnStandardComponent.Name = "btnStandardComponent";
		this.btnStandardComponent.Size = new System.Drawing.Size(76, 24);
		this.btnStandardComponent.TabIndex = 5;
		this.btnStandardComponent.Text = "+ &Standar";
		this.btnStandardComponent.UseVisualStyleBackColor = true;
		this.btnAddComponent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAddComponent.Location = new System.Drawing.Point(76, 127);
		this.btnAddComponent.Name = "btnAddComponent";
		this.btnAddComponent.Size = new System.Drawing.Size(80, 24);
		this.btnAddComponent.TabIndex = 4;
		this.btnAddComponent.Text = "+ &Komponen";
		this.btnAddComponent.UseVisualStyleBackColor = true;
		this.txtQty.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtQty.Location = new System.Drawing.Point(72, 92);
		this.txtQty.Name = "txtQty";
		this.txtQty.Size = new System.Drawing.Size(139, 26);
		this.txtQty.TabIndex = 3;
		this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.Label11.BackColor = System.Drawing.Color.Silver;
		this.Label11.Location = new System.Drawing.Point(-90, 418);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(713, 59);
		this.Label11.TabIndex = 120;
		this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnHistory.Location = new System.Drawing.Point(487, 426);
		this.btnHistory.Name = "btnHistory";
		this.btnHistory.Size = new System.Drawing.Size(50, 24);
		this.btnHistory.TabIndex = 10;
		this.btnHistory.Text = "&History";
		this.btnHistory.UseVisualStyleBackColor = true;
		this.btnSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSaveClose.Location = new System.Drawing.Point(333, 426);
		this.btnSaveClose.Name = "btnSaveClose";
		this.btnSaveClose.Size = new System.Drawing.Size(93, 24);
		this.btnSaveClose.TabIndex = 8;
		this.btnSaveClose.Text = "Simpan && &Tutup";
		this.btnSaveClose.UseVisualStyleBackColor = true;
		this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDelete.Location = new System.Drawing.Point(432, 426);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new System.Drawing.Size(49, 24);
		this.btnDelete.TabIndex = 9;
		this.btnDelete.Text = "Hapus";
		this.btnDelete.UseVisualStyleBackColor = true;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(241, 426);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(86, 24);
		this.btnSave.TabIndex = 7;
		this.btnSave.Text = "&Simpan && Baru";
		this.btnSave.UseVisualStyleBackColor = true;
		this.lblItem.AutoSize = true;
		this.lblItem.Location = new System.Drawing.Point(70, 65);
		this.lblItem.Name = "lblItem";
		this.lblItem.Size = new System.Drawing.Size(37, 13);
		this.lblItem.TabIndex = 127;
		this.lblItem.Text = "lblItem";
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(548, 455);
		base.Controls.Add(this.lblItem);
		base.Controls.Add(this.btnHistory);
		base.Controls.Add(this.btnSaveClose);
		base.Controls.Add(this.btnDelete);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.Label11);
		base.Controls.Add(this.btnStandardComponent);
		base.Controls.Add(this.btnAddComponent);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.dgvList);
		base.Controls.Add(this.txtQty);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.cboItem);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.cboStorage);
		base.Controls.Add(this.dtpProcess);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmProcess";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Produksi - Input";
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void frmProcess_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	public frmProcess()
	{
		base.KeyDown += frmProcess_KeyDown;
		base.Load += frmProcess_Load;
		InitializeComponent();
		base.MdiParent = MyProject.Forms.frmMenu;
		DoubleBuffered = true;
	}

	private void frmProcess_Load(object sender, EventArgs e)
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
					txtQty.AllowedCharacters = FilteredTextBox.InputType.NumeralsAndCurrency;
					ComboBox combo = cboItem;
					cCombo.getItemAll(ref combo, 99, 1, 0, 0, 0, 0, 99, 1, 0, 0, 0, 0, 0.0, CanBeUsedAsGroupMember: false, Module1.pubGroupId, All: false, Active: true);
					cboItem = combo;
					combo = cboStorage;
					cCombo.getStorage(ref combo, Module1.pubGroupId, 0, "NO_RETURN", blnAll: false, 1);
					cboStorage = combo;
					dgvList.Columns.Add("id", "Id");
					dgvList.Columns.Add("itemId", "itemId");
					dgvList.Columns.Add("storeageId", "storageId");
					dgvList.Columns.Add("componentDate", "Tanggal");
					dgvList.Columns.Add("storageName", "Gudang");
					dgvList.Columns.Add("itemName", "Komponen");
					dgvList.Columns.Add("qty", "Jumlah");
					dgvList.Columns[0].Visible = false;
					dgvList.Columns[1].Visible = false;
					dgvList.Columns[2].Visible = false;
					dgvList.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
					dgvList.Columns[3].Width = 80;
					dgvList.Columns[4].Width = 140;
					dgvList.Columns[5].Width = 120;
					dgvList.Columns[6].Width = 80;
					dgvList.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dgvList.RowHeadersVisible = false;
					dgvList.AllowUserToAddRows = false;
					dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
					dgvList.ReadOnly = true;
					dgvList.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
					dgvList.AllowUserToResizeRows = false;
					goto end_IL_0001;
				}
				case 658:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmProcess", "load", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 658;
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

	public void prepareForm(bool SaveNew, bool KeepItem)
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
					_currentlySelectedComboIndex = -1;
					lblItem.Visible = false;
					lblItem.Text = "";
					cboItem.Visible = true;
					dgvList.Rows.Clear();
					if (!SaveNew)
					{
						dtpProcess.Value = DateAndTime.Now;
						cboStorage.SelectedIndex = -1;
					}
					if (!KeepItem)
					{
						cboItem.SelectedIndex = -1;
					}
					intOriginalItemId = 0;
					intOriginalStorageId = 0;
					dblOriginalQty = 0.0;
					dateOriginal = DateAndTime.Now;
					txtQty.Text = "";
					btnDelete.Enabled = false;
					btnHistory.Enabled = false;
					btnAddComponent.Enabled = false;
					btnStandardComponent.Enabled = false;
					_originalComponent = null;
					dtpProcess.Focus();
					goto end_IL_0001;
				case 314:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmProcess", "prepareForm", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 314;
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
					cProcess cProcess2 = new cProcess(_currentId);
					intOriginalItemId = cProcess2.ItemId;
					intOriginalStorageId = cProcess2.StorageId;
					dateOriginal = cProcess2.ProcessDate;
					dblOriginalQty = cProcess2.Qty;
					dtpProcess.Value = cProcess2.ProcessDate;
					txtQty.Text = Module1.formatCustomDecimal(Conversions.ToString(cProcess2.Qty), 3);
					ComboBox cboSource = cboStorage;
					Module1.comboBoundValue(ref cboSource, cProcess2.StorageId);
					cboStorage = cboSource;
					cboSource = cboItem;
					Module1.comboBoundValue(ref cboSource, cProcess2.ItemId);
					cboItem = cboSource;
					_component = cProcess2.Component;
					lblItem.Text = cboItem.Text;
					lblItem.Visible = true;
					cboItem.Visible = false;
					dgvList.Rows.Clear();
					cComponent[] component = cProcess2.Component;
					foreach (cComponent cComponent2 in component)
					{
						dgvList.Rows.Add(cComponent2.Id, cComponent2.ItemId, cComponent2.StorageId, cComponent2.ComponentDate, cComponent2.StorageName, cComponent2.ItemName, Module1.formatCustomDecimal(Conversions.ToString(cComponent2.Qty), 3));
					}
					_originalComponent = cProcess2.Component;
					if (dgvList.Rows.Count > 0)
					{
						dgvList.CurrentRow.Selected = false;
					}
					DateTime createdDate = cProcess2.CreatedDate;
					if (DateAndTime.DateDiff(DateInterval.Day, createdDate, DateAndTime.Now) <= Module1.pubDaysLimit)
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
				case 632:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmProcess", "loadData", "");
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
				try0001_dispatch = 632;
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
					if (!Information.IsNothing(cComboItem2))
					{
						ComboBox combo = cboItem;
						cCombo.getItemAll(ref combo, 99, 1, 0, 0, 0, 0, 99, 1, 0, 0, Conversions.ToInteger(cComboItem2.Value), 0, 0.0, CanBeUsedAsGroupMember: false, Module1.pubGroupId, All: false, Active: true);
						cboItem = combo;
						cboItem.SelectedIndex = -1;
						cboItem.Text = "";
					}
					goto end_IL_0001;
				}
				case 169:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmProcess", "cboStorage_SelectedIndexChanged", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 169;
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

	private void cboItem_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!_suppressComboChange)
		{
			if (dgvList.RowCount > 0)
			{
				if (MessageBox.Show("Form akan di-reset karena anda mengganti Produk. Lanjutkan?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.No)
				{
					_suppressComboChange = true;
					cboItem.SelectedIndex = _currentlySelectedComboIndex;
					return;
				}
				if ((_currentlySelectedComboIndex > -1) & (cboItem.SelectedIndex > -1))
				{
					prepareForm(SaveNew: true, KeepItem: true);
				}
			}
			if (cboItem.SelectedIndex > -1)
			{
				btnAddComponent.Enabled = true;
				btnStandardComponent.Enabled = true;
			}
		}
		_currentlySelectedComboIndex = cboItem.SelectedIndex;
		_suppressComboChange = false;
	}

	private void dgvList_DoubleClick(object sender, EventArgs e)
	{
		openComponent();
	}

	private void openComponent()
	{
		cComboItem cComboItem2 = (cComboItem)cboItem.SelectedItem;
		if (!Information.IsNothing(cComboItem2))
		{
			frmProcessComponent frmProcessComponent2 = new frmProcessComponent(CurrentData: true, Conversions.ToInteger(cComboItem2.Value));
			frmProcessComponent2.Component = _component;
			frmProcessComponent2.dtpComponent.Value = Conversions.ToDate(dgvList[3, dgvList.CurrentRow.Index].Value);
			frmProcessComponent2.txtQty.Text = Module1.formatCustomDecimal(Conversions.ToString(dgvList[6, dgvList.CurrentRow.Index].Value), 3);
			ComboBox cboSource = frmProcessComponent2.cboItem;
			Module1.comboBoundValue(ref cboSource, Conversions.ToDouble(dgvList[1, dgvList.CurrentRow.Index].Value));
			frmProcessComponent2.cboItem = cboSource;
			cboSource = frmProcessComponent2.cboStorage;
			Module1.comboBoundValue(ref cboSource, Conversions.ToDouble(dgvList[2, dgvList.CurrentRow.Index].Value));
			frmProcessComponent2.cboStorage = cboSource;
			frmProcessComponent2.ShowDialog();
		}
	}

	private void dgvList_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			openComponent();
			e.SuppressKeyPress = true;
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			btnStandardComponent.Focus();
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			btnSave.Focus();
			e.SuppressKeyPress = true;
		}
	}

	private void btnAddComponent_Click(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboItem.SelectedItem;
		frmProcessComponent frmProcessComponent2 = new frmProcessComponent(CurrentData: false, Conversions.ToInteger(cComboItem2.Value));
		frmProcessComponent2.ShowDialog();
		frmProcessComponent2.Close();
		frmProcessComponent2.Dispose();
	}

	private void btnStandardComponent_Click(object sender, EventArgs e)
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
					cComboItem cComboItem3 = (cComboItem)cboItem.SelectedItem;
					if (cboStorage.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih gudang produksi", MsgBoxStyle.Information);
						cboStorage.Focus();
						goto end_IL_0001;
					}
					if (cboItem.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih produk yang akan diproduksi", MsgBoxStyle.Information);
						cboItem.Focus();
						goto end_IL_0001;
					}
					if (Conversion.Val(Module1.unformatNumber(txtQty.Text)) == 0.0)
					{
						Interaction.MsgBox("Masukkan jumlah", MsgBoxStyle.Information);
						txtQty.Focus();
						goto end_IL_0001;
					}
					if (!Versioned.IsNumeric(txtQty.Text))
					{
						Interaction.MsgBox("Masukkan jumlah dengan format angka yang benar", MsgBoxStyle.Information);
						txtQty.Focus();
						goto end_IL_0001;
					}
					dgvList.Rows.Clear();
					DataTable standardComponent = cComponent.GetStandardComponent(Conversions.ToInteger(cComboItem3.Value), Conversions.ToInteger(cComboItem2.Value), Conversions.ToDouble(txtQty.Text), dtpProcess.Value);
					IEnumerator enumerator = standardComponent.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						int num3 = 0;
						int intOriginalStoreId = 0;
						double num4 = 0.0;
						DateTime dateTime = DateAndTime.Now;
						if (!Information.IsNothing(_originalComponent))
						{
							cComponent[] originalComponent = _originalComponent;
							foreach (cComponent cComponent2 in originalComponent)
							{
								if (Operators.ConditionalCompareObjectEqual(cComponent2.ItemId, dataRow["itemId"], TextCompare: false))
								{
									num3 = cComponent2.ItemId;
									intOriginalStoreId = cComponent2.StorageId;
									num4 = cComponent2.Qty;
									dateTime = cComponent2.ComponentDate;
									break;
								}
							}
						}
						if (!cValidation.isInStock(Module1.pubCheckStock, Module1.pubBalanceDate, dtpProcess.Value, "", dateTime, Conversions.ToInteger(dataRow["itemId"]), num3, Conversions.ToDouble(dataRow["qty"]), num4, Conversions.ToInteger(dataRow["storageId"]), intOriginalStoreId, Module1.pubGroupId, 2))
						{
							Interaction.MsgBox(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Stok ", dataRow["itemName"]), " di gudang "), dataRow["storageName"]), " tidak tersedia"), MsgBoxStyle.Information);
							continue;
						}
						dgvList.Rows.Add(0, dataRow["itemId"], dataRow["storageId"], Interaction.IIf(Operators.ConditionalCompareObjectEqual(dataRow["itemProcessType"], 3, TextCompare: false), dtpProcess.Value.AddDays(-1.0), dtpProcess.Value), dataRow["storageName"], dataRow["itemName"], dataRow["qty"]);
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					if (dgvList.RowCount > 0)
					{
						dgvList.CurrentRow.Selected = false;
					}
					if (standardComponent.Rows.Count == 0)
					{
						Interaction.MsgBox("Komponen Standar tidak ditemukan", MsgBoxStyle.Information);
						btnStandardComponent.Focus();
					}
					else
					{
						btnSave.Focus();
					}
					goto end_IL_0001;
				}
				case 1084:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmProcess", "btnStandardComponent_click", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1084;
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

	private void dgvList_GotFocus(object sender, EventArgs e)
	{
		btnSave.NotifyDefault(value: false);
		if (dgvList.RowCount > 0)
		{
			dgvList.CurrentRow.Selected = true;
		}
	}

	private void dgvList_LostFocus(object sender, EventArgs e)
	{
		btnSave.NotifyDefault(value: true);
		if (dgvList.RowCount > 0)
		{
			dgvList.CurrentRow.Selected = false;
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
						cComboItem cComboItem3 = (cComboItem)cboItem.SelectedItem;
						if (!cValidation.isDateWithinRange(dtpProcess.Value, Module1.pubGroupId, Module1.pubDaysLimit))
						{
							Interaction.MsgBox("Tanggal diluar batas yang diperbolehkan", MsgBoxStyle.Information);
							dtpProcess.Focus();
							goto end_IL_0001;
						}
						if (cboStorage.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih gudang produksi", MsgBoxStyle.Information);
							cboStorage.Focus();
							goto end_IL_0001;
						}
						if (cboItem.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih produk yang akan diproduksi", MsgBoxStyle.Information);
							cboItem.Focus();
							goto end_IL_0001;
						}
						if (Conversion.Val(Module1.unformatNumber(txtQty.Text)) == 0.0)
						{
							Interaction.MsgBox("Masukkan jumlah", MsgBoxStyle.Information);
							txtQty.Focus();
							goto end_IL_0001;
						}
						if (!Versioned.IsNumeric(txtQty.Text))
						{
							Interaction.MsgBox("Masukkan jumlah dengan format angka yang benar", MsgBoxStyle.Information);
							txtQty.Focus();
							goto end_IL_0001;
						}
						if (dgvList.Rows.Count == 0)
						{
							Interaction.MsgBox("Masukkan komponen produk", MsgBoxStyle.Information);
							btnAddComponent.Focus();
							goto end_IL_0001;
						}
						if (((_currentId > 0.0) & (Conversions.ToDouble(cComboItem2.Value) == (double)intOriginalStorageId) & (dblOriginalQty > Conversions.ToDouble(txtQty.Text))) && !cValidation.isInStock(Module1.pubCheckStock, Module1.pubBalanceDate, dtpProcess.Value, "", dateOriginal, Conversions.ToInteger(cComboItem3.Value), intOriginalItemId, Conversions.ToDouble(txtQty.Text), dblOriginalQty, Conversions.ToInteger(cComboItem2.Value), intOriginalStorageId, Module1.pubGroupId, 1))
						{
							Interaction.MsgBox("Stok tidak tersedia. Update ini membuat stok di gudang menjadi negatif", MsgBoxStyle.Information);
							txtQty.Focus();
							goto end_IL_0001;
						}
						if (((_currentId > 0.0) & (Conversions.ToDouble(cComboItem2.Value) != (double)intOriginalStorageId) & (dblOriginalQty > Conversions.ToDouble(txtQty.Text))) && !cValidation.isInStock(Module1.pubCheckStock, Module1.pubBalanceDate, dtpProcess.Value, "", dateOriginal, Conversions.ToInteger(cComboItem3.Value), intOriginalItemId, Conversions.ToDouble(txtQty.Text), dblOriginalQty, intOriginalStorageId, intOriginalStorageId, Module1.pubGroupId, 3))
						{
							Interaction.MsgBox("Stok tidak tersedia. Update ini membuat stok di gudang yang sebelumnya menjadi negatif", MsgBoxStyle.Information);
							cboStorage.Focus();
							goto end_IL_0001;
						}
						cProcess cProcess2 = new cProcess(CurrentId);
						cComponent[] array = new cComponent[dgvList.Rows.Count - 1 + 1];
						cProcess2.CurrentComponent = cProcess2.Component;
						cProcess2.CurrentDate = cProcess2.ProcessDate;
						cProcess2.CurrentItem = cProcess2.ItemId;
						cProcess2.CurrentQty = cProcess2.Qty;
						cProcess2.CurrentStorage = cProcess2.StorageId;
						int num3 = 0;
						cProcess2.Id = CurrentId;
						cProcess2.ProcessDate = dtpProcess.Value;
						cProcess2.Qty = Conversions.ToDouble(txtQty.Text);
						cProcess2.StorageId = Conversions.ToInteger(cComboItem2.Value);
						cProcess2.ItemId = Conversions.ToInteger(cComboItem3.Value);
						int num4 = dgvList.Rows.Count - 1;
						for (num3 = 0; num3 <= num4; num3++)
						{
							array[num3] = new cComponent(0.0);
							array[num3].ItemId = Conversions.ToInteger(dgvList[1, num3].Value);
							array[num3].StorageId = Conversions.ToInteger(dgvList[2, num3].Value);
							array[num3].ComponentDate = Conversions.ToDate(dgvList[3, num3].Value);
							array[num3].Qty = Conversions.ToDouble(dgvList[6, num3].Value);
						}
						cProcess2.Component = array;
						cProcess2.save();
						string text = "Tanggal: " + Conversions.ToString(dtpProcess.Value) + "<br />Gudang: " + cboStorage.Text + "<br />Produk: " + cboItem.Text + "<br />Jumlah: " + Module1.formatCustomDecimal(txtQty.Text, 3) + "<br /><br />";
						text += "Komponen:<br />";
						text += "<table><tr><td>Tanggal</ td><td>Gudang</ td><td>Komponen</ td><td>Jumlah</ td></tr>";
						int num5 = dgvList.Rows.Count - 1;
						for (num3 = 0; num3 <= num5; num3++)
						{
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<tr><td>", dgvList[3, num3].Value), "</ td>"), "<td>"), dgvList[4, num3].Value), "</ td>"), "<td>"), dgvList[5, num3].Value), "</ td>"), "<td align='right'>"), Module1.formatCustomDecimal(Conversions.ToString(dgvList[6, num3].Value), 3)), "</ td></tr>")));
						}
						text += "</table>";
						string text2;
						if (_currentId == 0.0)
						{
							text2 = "membuat ";
							_currentId = cProcess2.Id;
						}
						else
						{
							text2 = "mengupdate ";
						}
						text2 = text2 + "produksi " + cboItem.Text + " sejumlah " + txtQty.Text + " di gudang " + cboStorage.Text + ". Tanggal " + Strings.Format(dtpProcess.Value, "dd/MM/yyyy") + ". ID= " + Conversions.ToString(_currentId) + ", v2";
						cHistory cHistory2 = new cHistory();
						cHistory2.Content = text;
						cHistory2.Description = text2;
						cHistory2.UserId = Module1.pubUserId;
						cHistory2.UserLogin = Module1.pubLogin;
						cHistory2.fKeyId = CurrentId;
						cHistory2.HistoryType = 2;
						cHistory2.Save();
						Interaction.MsgBox("Produksi berhasil disimpan", MsgBoxStyle.Information);
						if (Module1.FormIsOpen("frmProcessList"))
						{
							MyProject.Forms.frmProcessList.GetRecent();
						}
						MyProject.Forms.frmInformation.GetActivity();
						if (CloseForm)
						{
							Close();
							goto end_IL_0001;
						}
						_suppressComboChange = true;
						prepareForm(SaveNew: true, KeepItem: false);
						cboItem.Focus();
						goto end_IL_0001_2;
					}
					case 2077:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmProcess", "SaveData", "");
							goto end_IL_0001_2;
						}
						break;
					}
					goto IL_0853;
				}
				end_IL_0001_2:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 2077;
				continue;
			}
			break;
			IL_0853:
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
					if (_currentId > 0.0 && !cValidation.isInStock(Module1.pubCheckStock, Module1.pubBalanceDate, dtpProcess.Value, "", dateOriginal, intOriginalItemId, intOriginalItemId, Conversions.ToDouble(txtQty.Text), dblOriginalQty, intOriginalStorageId, intOriginalStorageId, Module1.pubGroupId, 3))
					{
						Interaction.MsgBox("Produksi tidak bisa dihapus karena akan membuat stok gudang menjadi negatif", MsgBoxStyle.Information);
					}
					else if (MessageBox.Show("Hapus Produksi?", "Konfirmasi", MessageBoxButtons.YesNo) != DialogResult.No)
					{
						cProcess cProcess2 = new cProcess(CurrentId);
						cProcess2.CurrentComponent = cProcess2.Component;
						cProcess2.CurrentDate = cProcess2.ProcessDate;
						cProcess2.CurrentItem = cProcess2.ItemId;
						cProcess2.CurrentQty = cProcess2.Qty;
						cProcess2.CurrentStorage = cProcess2.StorageId;
						cProcess2.Delete();
						string description = "menghapus produksi " + cProcess2.ItemName + " sejumlah " + Conversions.ToString(cProcess2.Qty) + " di gudang " + cProcess2.StorageName + ". Tanggal  " + Strings.Format(cProcess2.ProcessDate, "dd/MM/yyyy") + ". ID= " + Conversions.ToString(_currentId) + ", v2";
						cHistory cHistory2 = new cHistory();
						cHistory2.Description = description;
						cHistory2.UserId = Module1.pubUserId;
						cHistory2.UserLogin = Module1.pubLogin;
						cHistory2.fKeyId = _currentId;
						cHistory2.HistoryType = 2;
						cHistory2.Save();
						Interaction.MsgBox("Produksi berhasil dihapus", MsgBoxStyle.Information);
						if (Module1.FormIsOpen("frmProcessList"))
						{
							MyProject.Forms.frmProcessList.GetRecent();
						}
						MyProject.Forms.frmInformation.GetActivity();
						Close();
					}
					goto end_IL_0001;
				case 571:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmProcess", "btnDelete_Click", "");
						goto end_IL_0001;
					}
					break;
				}
				goto IL_0271;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 571;
				continue;
			}
			break;
			IL_0271:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void btnHistory_Click(object sender, EventArgs e)
	{
		MyProject.Forms.frmHistory.GetHistory(checked((int)Math.Round(_currentId)), 2);
		MyProject.Forms.frmHistory.Show();
		MyProject.Forms.frmHistory.Activate();
		MyProject.Forms.frmHistory.WindowState = FormWindowState.Normal;
	}
}
