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
public class frmDeliveryOrder : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dtpDO")]
	private DateTimePicker _dtpDO;

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
	[AccessedThroughProperty("btnItem")]
	private Button _btnItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvItem")]
	private DataGridView _dgvItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnPrint")]
	private Button _btnPrint;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("lblAddress")]
	private Label _lblAddress;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("lblName")]
	private Label _lblName;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSearch")]
	private Button _btnSearch;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboStorage")]
	private ComboBox _cboStorage;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("lblInformation")]
	private Label _lblInformation;

	private double _customerId;

	private double _currentId;

	private bool _edited;

	public DateTime OriginalDate;

	public int OriginalStorageId;

	private cDeliveryOrderItem[] _DOItem;

	private double _invoiceId;

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
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

	internal virtual DateTimePicker dtpDO
	{
		[CompilerGenerated]
		get
		{
			return _dtpDO;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = dtpDO_ValueChanged;
			DateTimePicker dateTimePicker = _dtpDO;
			if (dateTimePicker != null)
			{
				dateTimePicker.ValueChanged -= value2;
			}
			_dtpDO = value;
			dateTimePicker = _dtpDO;
			if (dateTimePicker != null)
			{
				dateTimePicker.ValueChanged += value2;
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label lblAddress
	{
		[CompilerGenerated]
		get
		{
			return _lblAddress;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = lblAddress_Click;
			Label label = _lblAddress;
			if (label != null)
			{
				label.Click -= value2;
			}
			_lblAddress = value;
			label = _lblAddress;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal virtual Label lblName
	{
		[CompilerGenerated]
		get
		{
			return _lblName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = lblName_Click;
			Label label = _lblName;
			if (label != null)
			{
				label.Click -= value2;
			}
			_lblName = value;
			label = _lblName;
			if (label != null)
			{
				label.Click += value2;
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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
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

	public double CustomerId
	{
		get
		{
			return _customerId;
		}
		set
		{
			_customerId = value;
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
		this.Label10 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.dtpDO = new System.Windows.Forms.DateTimePicker();
		this.btnSaveClose = new System.Windows.Forms.Button();
		this.btnDelete = new System.Windows.Forms.Button();
		this.btnSave = new System.Windows.Forms.Button();
		this.btnHistory = new System.Windows.Forms.Button();
		this.TabControl1 = new System.Windows.Forms.TabControl();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.btnItem = new System.Windows.Forms.Button();
		this.dgvItem = new System.Windows.Forms.DataGridView();
		this.btnPrint = new System.Windows.Forms.Button();
		this.Label2 = new System.Windows.Forms.Label();
		this.lblAddress = new System.Windows.Forms.Label();
		this.lblName = new System.Windows.Forms.Label();
		this.btnSearch = new System.Windows.Forms.Button();
		this.Label4 = new System.Windows.Forms.Label();
		this.cboStorage = new System.Windows.Forms.ComboBox();
		this.lblNumber = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.lblInformation = new System.Windows.Forms.Label();
		this.TabControl1.SuspendLayout();
		this.TabPage1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvItem).BeginInit();
		base.SuspendLayout();
		this.Label10.BackColor = System.Drawing.Color.Silver;
		this.Label10.Location = new System.Drawing.Point(-239, 359);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(713, 59);
		this.Label10.TabIndex = 137;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(6, 89);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(46, 13);
		this.Label1.TabIndex = 135;
		this.Label1.Text = "Tanggal";
		this.dtpDO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpDO.Location = new System.Drawing.Point(63, 86);
		this.dtpDO.Name = "dtpDO";
		this.dtpDO.Size = new System.Drawing.Size(121, 20);
		this.dtpDO.TabIndex = 1;
		this.btnSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSaveClose.Location = new System.Drawing.Point(185, 369);
		this.btnSaveClose.Name = "btnSaveClose";
		this.btnSaveClose.Size = new System.Drawing.Size(93, 24);
		this.btnSaveClose.TabIndex = 22;
		this.btnSaveClose.Text = "Simpan && &Tutup";
		this.btnSaveClose.UseVisualStyleBackColor = true;
		this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDelete.Location = new System.Drawing.Point(284, 369);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new System.Drawing.Size(49, 24);
		this.btnDelete.TabIndex = 23;
		this.btnDelete.Text = "Hapus";
		this.btnDelete.UseVisualStyleBackColor = true;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(121, 369);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(58, 24);
		this.btnSave.TabIndex = 21;
		this.btnSave.Text = "&Simpan";
		this.btnSave.UseVisualStyleBackColor = true;
		this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnHistory.Location = new System.Drawing.Point(339, 369);
		this.btnHistory.Name = "btnHistory";
		this.btnHistory.Size = new System.Drawing.Size(50, 24);
		this.btnHistory.TabIndex = 24;
		this.btnHistory.Text = "&History";
		this.btnHistory.UseVisualStyleBackColor = true;
		this.TabControl1.Controls.Add(this.TabPage1);
		this.TabControl1.Location = new System.Drawing.Point(9, 139);
		this.TabControl1.Name = "TabControl1";
		this.TabControl1.SelectedIndex = 0;
		this.TabControl1.Size = new System.Drawing.Size(441, 192);
		this.TabControl1.TabIndex = 10;
		this.TabPage1.Controls.Add(this.btnItem);
		this.TabPage1.Controls.Add(this.dgvItem);
		this.TabPage1.Location = new System.Drawing.Point(4, 22);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage1.Size = new System.Drawing.Size(433, 166);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = "Barang";
		this.TabPage1.UseVisualStyleBackColor = true;
		this.btnItem.BackColor = System.Drawing.SystemColors.ButtonFace;
		this.btnItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnItem.Location = new System.Drawing.Point(6, 6);
		this.btnItem.Name = "btnItem";
		this.btnItem.Size = new System.Drawing.Size(61, 24);
		this.btnItem.TabIndex = 11;
		this.btnItem.Text = "+ Barang";
		this.btnItem.UseVisualStyleBackColor = false;
		this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvItem.Location = new System.Drawing.Point(6, 36);
		this.dgvItem.Name = "dgvItem";
		this.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dgvItem.Size = new System.Drawing.Size(412, 120);
		this.dgvItem.TabIndex = 12;
		this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnPrint.Location = new System.Drawing.Point(395, 369);
		this.btnPrint.Name = "btnPrint";
		this.btnPrint.Size = new System.Drawing.Size(55, 24);
		this.btnPrint.TabIndex = 25;
		this.btnPrint.Text = "Preview";
		this.btnPrint.UseVisualStyleBackColor = true;
		this.Label2.BackColor = System.Drawing.Color.White;
		this.Label2.Location = new System.Drawing.Point(-12, -11);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(713, 69);
		this.Label2.TabIndex = 180;
		this.lblAddress.BackColor = System.Drawing.Color.White;
		this.lblAddress.Cursor = System.Windows.Forms.Cursors.Hand;
		this.lblAddress.Location = new System.Drawing.Point(9, 32);
		this.lblAddress.Name = "lblAddress";
		this.lblAddress.Size = new System.Drawing.Size(350, 26);
		this.lblAddress.TabIndex = 183;
		this.lblAddress.Text = "lblAddress";
		this.lblName.BackColor = System.Drawing.Color.White;
		this.lblName.Cursor = System.Windows.Forms.Cursors.Hand;
		this.lblName.Location = new System.Drawing.Point(9, 9);
		this.lblName.Name = "lblName";
		this.lblName.Size = new System.Drawing.Size(350, 23);
		this.lblName.TabIndex = 182;
		this.lblName.Text = "lblName";
		this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnSearch.Location = new System.Drawing.Point(365, 17);
		this.btnSearch.Name = "btnSearch";
		this.btnSearch.Size = new System.Drawing.Size(83, 23);
		this.btnSearch.TabIndex = 0;
		this.btnSearch.Text = "Pilih Customer";
		this.btnSearch.UseVisualStyleBackColor = true;
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(7, 115);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(45, 13);
		this.Label4.TabIndex = 185;
		this.Label4.Text = "Gudang";
		this.cboStorage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboStorage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboStorage.FormattingEnabled = true;
		this.cboStorage.Location = new System.Drawing.Point(63, 112);
		this.cboStorage.Name = "cboStorage";
		this.cboStorage.Size = new System.Drawing.Size(139, 21);
		this.cboStorage.TabIndex = 2;
		this.lblNumber.AutoSize = true;
		this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblNumber.Location = new System.Drawing.Point(61, 66);
		this.lblNumber.Name = "lblNumber";
		this.lblNumber.Size = new System.Drawing.Size(54, 13);
		this.lblNumber.TabIndex = 187;
		this.lblNumber.Text = "lblNumber";
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(7, 66);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(38, 13);
		this.Label3.TabIndex = 186;
		this.Label3.Text = "Nomer";
		this.lblInformation.AutoSize = true;
		this.lblInformation.Cursor = System.Windows.Forms.Cursors.Hand;
		this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
		this.lblInformation.ForeColor = System.Drawing.Color.Blue;
		this.lblInformation.Location = new System.Drawing.Point(7, 336);
		this.lblInformation.Name = "lblInformation";
		this.lblInformation.Size = new System.Drawing.Size(82, 15);
		this.lblInformation.TabIndex = 222;
		this.lblInformation.Text = "lblInformation";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(459, 400);
		base.Controls.Add(this.lblInformation);
		base.Controls.Add(this.lblNumber);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.cboStorage);
		base.Controls.Add(this.btnSearch);
		base.Controls.Add(this.lblAddress);
		base.Controls.Add(this.lblName);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.btnPrint);
		base.Controls.Add(this.TabControl1);
		base.Controls.Add(this.btnSaveClose);
		base.Controls.Add(this.btnDelete);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.btnHistory);
		base.Controls.Add(this.Label10);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.dtpDO);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmDeliveryOrder";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Pengiriman Pesanan";
		this.TabControl1.ResumeLayout(false);
		this.TabPage1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgvItem).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmDeliveryOrder()
	{
		base.KeyDown += frmDeliveryOrder_KeyDown;
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
					ComboBox combo = cboStorage;
					cCombo.getStorage(ref combo, Module1.pubGroupId, 0, "MARKETING_RETURN", blnAll: false, 1);
					cboStorage = combo;
					formatGrid();
					btnSearch.Focus();
					goto end_IL_001b;
				}
				case 154:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmDeliveryOrder", "New", "");
						goto end_IL_001b;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try001b_dispatch = 154;
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
		dgvItem.Columns.Add("", "GeneralType");
		dgvItem.Columns.Add("", "LongName");
		dgvItem.Columns.Add("", "Packaging");
		dgvItem.Columns.Add("", "LargeUnit");
		dgvItem.Columns[0].Visible = false;
		dgvItem.Columns[1].Width = 120;
		dgvItem.Columns[2].Width = 100;
		dgvItem.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItem.Columns[3].Visible = false;
		dgvItem.Columns[4].Visible = false;
		dgvItem.Columns[5].Visible = false;
		dgvItem.Columns[6].Visible = false;
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
		_customerId = 0.0;
		_DOItem = null;
		dgvItem.Rows.Clear();
		btnSearch.Visible = true;
		cboStorage.Enabled = false;
		lblName.Text = "Klik tombol 'Pilih Customer' untuk memilih customer";
		lblAddress.Text = "";
		if (!SaveNew)
		{
			cboStorage.SelectedIndex = -1;
			dtpDO.Value = DateAndTime.Now;
		}
		dtpDO.Enabled = true;
		lblNumber.Text = "auto";
		btnHistory.Enabled = false;
		btnDelete.Enabled = false;
		btnPrint.Enabled = false;
		lblInformation.Text = "";
		_edited = false;
		OriginalDate = DateAndTime.Now;
		OriginalStorageId = 0;
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
					cDeliveryOrder cDeliveryOrder2 = new cDeliveryOrder(_currentId);
					_customerId = cDeliveryOrder2.CustomerId;
					btnSearch.Visible = false;
					lblName.Text = cDeliveryOrder2.CustomerName;
					lblAddress.Text = cDeliveryOrder2.CustomerAddress;
					lblNumber.Text = cDeliveryOrder2.Number;
					dtpDO.Value = cDeliveryOrder2.DODate;
					OriginalDate = cDeliveryOrder2.DODate;
					OriginalStorageId = cDeliveryOrder2.StorageId;
					ComboBox cboSource = cboStorage;
					Module1.comboBoundValue(ref cboSource, cDeliveryOrder2.StorageId);
					cboStorage = cboSource;
					_DOItem = cDeliveryOrder2.Item;
					cDeliveryOrderItem[] item = cDeliveryOrder2.Item;
					foreach (cDeliveryOrderItem cDeliveryOrderItem2 in item)
					{
						dgvItem.Rows.Add(cDeliveryOrderItem2.ItemId, cDeliveryOrderItem2.ItemName, Module1.formatCustomDecimal(Conversions.ToString(cDeliveryOrderItem2.DOQty), 3), cDeliveryOrderItem2.GeneralType, cDeliveryOrderItem2.LongName, cDeliveryOrderItem2.Packaging, cDeliveryOrderItem2.LargeUnit);
					}
					if (dgvItem.RowCount > 0)
					{
						dgvItem.CurrentRow.Selected = false;
					}
					_invoiceId = cDeliveryOrder2.InvoiceId;
					if (DateAndTime.DateDiff(DateInterval.Day, dtpDO.Value, DateAndTime.Now) <= Module1.pubDaysLimit)
					{
						dtpDO.Enabled = true;
					}
					else
					{
						dtpDO.Enabled = false;
					}
					if (Operators.CompareString(cDeliveryOrder2.InvoiceNumber, "", TextCompare: false) != 0)
					{
						lblInformation.Text = "Sudah dikaitkan dengan Faktur Penjualan: " + cDeliveryOrder2.InvoiceNumber;
						btnSave.Enabled = false;
						btnSaveClose.Enabled = false;
						btnDelete.Enabled = false;
					}
					else
					{
						btnSave.Enabled = true;
						btnSaveClose.Enabled = true;
						if (DateAndTime.DateDiff(DateInterval.Day, dtpDO.Value, DateAndTime.Now) <= Module1.pubDaysLimit)
						{
							btnDelete.Enabled = true;
						}
						else
						{
							btnDelete.Enabled = false;
						}
					}
					cboStorage.Enabled = true;
					btnHistory.Enabled = true;
					btnPrint.Enabled = true;
					_edited = false;
					goto end_IL_0001;
				}
				case 767:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmDeliveryOrder", "loadData", "");
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
				try0001_dispatch = 767;
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

	private void frmDeliveryOrder_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void btnSearch_Click(object sender, EventArgs e)
	{
		frmCustomerMiniSearch frmCustomerMiniSearch2 = new frmCustomerMiniSearch();
		frmCustomerMiniSearch2.CallerName = "DeliveryOrder";
		frmCustomerMiniSearch2.ShowDialog();
		frmCustomerMiniSearch2.Close();
		frmCustomerMiniSearch2.Dispose();
		if (_customerId > 0.0)
		{
			LoadCustomer();
		}
	}

	public void LoadCustomer()
	{
		cCustomer cCustomer2 = new cCustomer(_customerId);
		lblName.Text = cCustomer2.Name;
		lblAddress.Text = cCustomer2.Address;
		ComboBox combo = cboStorage;
		cCombo.getStorage(ref combo, Module1.pubGroupId, cCustomer2.BranchId, "MARKETING_RETURN", blnAll: false, 1);
		cboStorage = combo;
		cboStorage.Enabled = true;
		cboStorage.SelectedIndex = -1;
		cboStorage.Text = "";
		dtpDO.Focus();
	}

	private void lblName_Click(object sender, EventArgs e)
	{
		OpenCustomer();
	}

	private void lblAddress_Click(object sender, EventArgs e)
	{
		OpenCustomer();
	}

	private void OpenCustomer()
	{
		if (_customerId > 0.0)
		{
			MyProject.Forms.frmCustomer.Show();
			MyProject.Forms.frmCustomer.prepareForm();
			MyProject.Forms.frmCustomer.CurrentId = _customerId;
			MyProject.Forms.frmCustomer.LoadData();
			MyProject.Forms.frmCustomer.Activate();
			MyProject.Forms.frmCustomer.WindowState = FormWindowState.Normal;
		}
	}

	private void dtpDO_ValueChanged(object sender, EventArgs e)
	{
		_edited = true;
	}

	private void cboStorage_SelectedIndexChanged(object sender, EventArgs e)
	{
		_edited = true;
		if (dgvItem.RowCount > 0)
		{
			Interaction.MsgBox("Barang akan dihapus karena anda mengganti Gudang.", MsgBoxStyle.Information);
			dgvItem.Rows.Clear();
		}
	}

	private void btnItem_Click(object sender, EventArgs e)
	{
		if (cboStorage.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih gudang", (MsgBoxStyle)(-2147483637));
			cboStorage.Focus();
			return;
		}
		cComboItem cComboItem2 = (cComboItem)cboStorage.SelectedItem;
		frmDeliveryOrderItem frmDeliveryOrderItem2 = new frmDeliveryOrderItem(CurrentData: false, Conversions.ToInteger(cComboItem2.Value));
		frmDeliveryOrderItem2.ShowDialog();
		frmDeliveryOrderItem2.Close();
		frmDeliveryOrderItem2.Dispose();
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
					if (cboStorage.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih gudang", (MsgBoxStyle)(-2147483637));
						cboStorage.Focus();
						goto end_IL_0001;
					}
					cComboItem cComboItem2 = (cComboItem)cboStorage.SelectedItem;
					if (dgvItem.Rows.Count > 0)
					{
						frmDeliveryOrderItem frmDeliveryOrderItem2 = new frmDeliveryOrderItem(CurrentData: true, Conversions.ToInteger(cComboItem2.Value));
						frmDeliveryOrderItem2.DOItem = _DOItem;
						ComboBox cboSource = frmDeliveryOrderItem2.cboItem;
						Module1.comboBoundValue(ref cboSource, Conversions.ToDouble(dgvItem[0, dgvItem.CurrentRow.Index].Value));
						frmDeliveryOrderItem2.cboItem = cboSource;
						frmDeliveryOrderItem2.txtQty.Text = Module1.formatCustomDecimal(Conversions.ToString(dgvItem[2, dgvItem.CurrentRow.Index].Value), 3);
						frmDeliveryOrderItem2.ShowDialog();
					}
					goto end_IL_0001;
				}
				case 303:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmDeliveryOrder", "OpenItem", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 303;
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
						if (_customerId == 0.0)
						{
							Interaction.MsgBox("Pilih customer", MsgBoxStyle.Information);
							btnSearch.Focus();
							goto end_IL_0001;
						}
						if (!cValidation.isDateWithinRange(dtpDO.Value, Module1.pubGroupId, Module1.pubDaysLimit))
						{
							Interaction.MsgBox("Tanggal diluar batas yang diperbolehkan", MsgBoxStyle.Information);
							dtpDO.Focus();
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
						cDeliveryOrder cDeliveryOrder2 = new cDeliveryOrder(_currentId);
						cDeliveryOrderItem[] array = new cDeliveryOrderItem[dgvItem.Rows.Count - 1 + 1];
						int num3 = 0;
						cDeliveryOrder2.CurrentItem = cDeliveryOrder2.Item;
						cDeliveryOrder2.CurrentDate = cDeliveryOrder2.DODate;
						cDeliveryOrder2.CurrentStorage = cDeliveryOrder2.StorageId;
						cDeliveryOrder2.DODate = dtpDO.Value;
						cDeliveryOrder2.StorageId = Conversions.ToInteger(cComboItem2.Value);
						cDeliveryOrder2.StorageName = cboStorage.Text;
						cDeliveryOrder2.CustomerId = _customerId;
						int num4 = dgvItem.Rows.Count - 1;
						for (num3 = 0; num3 <= num4; num3++)
						{
							array[num3] = new cDeliveryOrderItem();
							array[num3].ItemId = Conversions.ToInteger(dgvItem[0, num3].Value);
							array[num3].DOQty = Conversions.ToDouble(dgvItem[2, num3].Value);
						}
						cDeliveryOrder2.Item = array;
						cDeliveryOrder2.save();
						if (Operators.CompareString(lblNumber.Text, "auto", TextCompare: false) == 0)
						{
							lblNumber.Text = "DO/" + Conversions.ToString(cDeliveryOrder2.StorageId) + "/" + Strings.Right(Conversions.ToString(DateAndTime.Year(cDeliveryOrder2.DODate)), 2) + "/" + cDeliveryOrder2.Number;
						}
						string text = "Nomer: " + lblNumber.Text + "<br />Tanggal: " + Strings.Format(dtpDO.Value, "dd/MM/yyyy") + "<br />Customer: " + lblName.Text + "<br />Gudang: " + cboStorage.Text + "<br /><br />";
						text += "Barang:<br />";
						text += "<table><tr><td>Barang</ td><td>Jumlah</ td></tr>";
						int num5 = dgvItem.Rows.Count - 1;
						for (num3 = 0; num3 <= num5; num3++)
						{
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<tr><td>", dgvItem[1, num3].Value), "</ td>"), "<td align='right'>"), Module1.formatCustomDecimal(Conversions.ToString(dgvItem[2, num3].Value), 3)), "</ td></tr>")));
						}
						text += "</table>";
						string text2;
						if (_currentId == 0.0)
						{
							text2 = "membuat ";
							_currentId = cDeliveryOrder2.Id;
						}
						else
						{
							text2 = "mengupdate ";
						}
						text2 = text2 + "Pengiriman Pesanan " + lblNumber.Text + " dari gudang " + cboStorage.Text + ". Tanggal " + Strings.Format(dtpDO.Value, "dd/MM/yyyy") + ". ID= " + Conversions.ToString(_currentId) + ", v2";
						cHistory cHistory2 = new cHistory();
						cHistory2.Content = text;
						cHistory2.Description = text2;
						cHistory2.UserId = Module1.pubUserId;
						cHistory2.UserLogin = Module1.pubLogin;
						cHistory2.fKeyId = _currentId;
						cHistory2.HistoryType = 9;
						cHistory2.Save();
						Interaction.MsgBox("Pengiriman Pesanan berhasil disimpan", MsgBoxStyle.Information);
						if (Module1.FormIsOpen("frmDeliveryOrderList"))
						{
							MyProject.Forms.frmDeliveryOrderList.GetRecent();
						}
						if (Module1.FormIsOpen("frmCustomer"))
						{
							MyProject.Forms.frmCustomer.GetDeliveryOrder();
						}
						MyProject.Forms.frmInformation.GetActivity();
						if (CloseForm)
						{
							Close();
							goto end_IL_0001;
						}
						btnSearch.Visible = false;
						btnDelete.Enabled = true;
						btnHistory.Enabled = true;
						btnPrint.Enabled = true;
						_edited = false;
						goto end_IL_0001;
					}
					case 1452:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmDeliveryOrder", "SaveData", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1452;
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
					if (MessageBox.Show("Hapus Pengiriman Pesanan?", "Konfirmasi", MessageBoxButtons.YesNo) != DialogResult.No)
					{
						cDeliveryOrder cDeliveryOrder2 = new cDeliveryOrder(_currentId);
						cDeliveryOrder2.CurrentItem = cDeliveryOrder2.Item;
						cDeliveryOrder2.CurrentDate = cDeliveryOrder2.DODate;
						cDeliveryOrder2.CurrentStorage = cDeliveryOrder2.StorageId;
						cDeliveryOrder2.Delete();
						string description = "menghapus Pengiriman Pesanan " + cDeliveryOrder2.Number + " dari gudang " + cDeliveryOrder2.StorageName + ". Tanggal  " + Strings.Format(cDeliveryOrder2.DODate, "dd/MM/yyyy") + ". ID= " + Conversions.ToString(_currentId) + ", v2";
						cHistory cHistory2 = new cHistory();
						cHistory2.Description = description;
						cHistory2.UserId = Module1.pubUserId;
						cHistory2.UserLogin = Module1.pubLogin;
						cHistory2.fKeyId = _currentId;
						cHistory2.HistoryType = 9;
						cHistory2.Save();
						Interaction.MsgBox("Pengiriman Pesanan berhasil dihapus", MsgBoxStyle.Information);
						if (Module1.FormIsOpen("frmDeliveryOrderList"))
						{
							MyProject.Forms.frmDeliveryOrderList.GetRecent();
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
						Module1.SaveError(Information.Err(), "frmDeliveryOrder", "btnDelete_Click", "");
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
		MyProject.Forms.frmHistory.GetHistory(checked((int)Math.Round(_currentId)), 9);
		MyProject.Forms.frmHistory.Show();
		MyProject.Forms.frmHistory.Activate();
		MyProject.Forms.frmHistory.WindowState = FormWindowState.Normal;
	}

	private void lblInformation_Click(object sender, EventArgs e)
	{
		MyProject.Forms.frmSalesInvoice.Show();
		MyProject.Forms.frmSalesInvoice.prepareForm(SaveNew: false);
		MyProject.Forms.frmSalesInvoice.CurrentId = _invoiceId;
		MyProject.Forms.frmSalesInvoice.LoadData();
		MyProject.Forms.frmSalesInvoice.Activate();
		MyProject.Forms.frmSalesInvoice.WindowState = FormWindowState.Normal;
	}

	private void btnPrint_Click(object sender, EventArgs e)
	{
		if (_edited && btnSave.Enabled)
		{
			if (MessageBox.Show("Anda melakukan perubahan data.\r\nSimpan Pengiriman Pesanan sebelum mencetak?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				SaveData(CloseForm: false);
			}
			return;
		}
		frmDeliveryOrderPrint frmDeliveryOrderPrint2 = new frmDeliveryOrderPrint();
		frmDeliveryOrderPrint2.lblDateLetter.Text = Strings.Format(dtpDO.Value, "d MMMM yyyy");
		frmDeliveryOrderPrint2.lblNameLetter.Text = lblName.Text;
		frmDeliveryOrderPrint2.lblAddressLetter.Text = lblAddress.Text;
		frmDeliveryOrderPrint2.lblInvoiceNoLetter.Text = "No. Pengiriman Pesanan: " + lblNumber.Text;
		checked
		{
			int num = dgvItem.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				string left = ((!Operators.ConditionalCompareObjectNotEqual(dgvItem[3, i].Value, "", TextCompare: false)) ? "" : Conversions.ToString(Operators.ConcatenateObject(dgvItem[3, i].Value, " ")));
				left = ((!Operators.ConditionalCompareObjectEqual(dgvItem[4, i].Value, "", TextCompare: false)) ? Conversions.ToString(Operators.ConcatenateObject(left, dgvItem[4, i].Value)) : Conversions.ToString(Operators.ConcatenateObject(left, dgvItem[1, i].Value)));
				frmDeliveryOrderPrint2.dgvItemLetter.Rows.Add(i + 1, left, dgvItem[5, i].Value, Operators.ConcatenateObject(Module1.formatCustomDecimal(Conversions.ToString(dgvItem[2, i].Value), 3) + " ", dgvItem[6, i].Value));
			}
			frmDeliveryOrderPrint2.ShowDialog();
			frmDeliveryOrderPrint2.Close();
			frmDeliveryOrderPrint2.Dispose();
		}
	}
}
