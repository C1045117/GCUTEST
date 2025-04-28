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
public class frmAdjustment : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboStorage")]
	private ComboBox _cboStorage;

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

	public int intOriginalItemId;

	public int intOriginalStorageId;

	public DateTime dateOriginal;

	public double dblOriginalQty;

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

	[field: AccessedThroughProperty("cboItem")]
	internal virtual ComboBox cboItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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

	[field: AccessedThroughProperty("dtpAdjustment")]
	internal virtual DateTimePicker dtpAdjustment
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboCategory")]
	internal virtual ComboBox cboCategory
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

	[field: AccessedThroughProperty("cboType")]
	internal virtual ComboBox cboType
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDescription")]
	internal virtual TextBox txtDescription
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

	[field: AccessedThroughProperty("lblItem")]
	internal virtual Label lblItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblType")]
	internal virtual Label lblType
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
		this.txtQty = new GCUv2.FilteredTextBox();
		this.Label6 = new System.Windows.Forms.Label();
		this.cboItem = new System.Windows.Forms.ComboBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.cboStorage = new System.Windows.Forms.ComboBox();
		this.dtpAdjustment = new System.Windows.Forms.DateTimePicker();
		this.cboCategory = new System.Windows.Forms.ComboBox();
		this.Label7 = new System.Windows.Forms.Label();
		this.cboType = new System.Windows.Forms.ComboBox();
		this.txtDescription = new System.Windows.Forms.TextBox();
		this.Label8 = new System.Windows.Forms.Label();
		this.btnHistory = new System.Windows.Forms.Button();
		this.btnSaveClose = new System.Windows.Forms.Button();
		this.btnDelete = new System.Windows.Forms.Button();
		this.btnSave = new System.Windows.Forms.Button();
		this.Label11 = new System.Windows.Forms.Label();
		this.lblItem = new System.Windows.Forms.Label();
		this.lblType = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.txtQty.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtQty.DontFormat = false;
		this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtQty.Location = new System.Drawing.Point(100, 146);
		this.txtQty.MaximumDigit = 3;
		this.txtQty.Name = "txtQty";
		this.txtQty.Size = new System.Drawing.Size(139, 26);
		this.txtQty.TabIndex = 5;
		this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.Location = new System.Drawing.Point(10, 68);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(41, 13);
		this.Label6.TabIndex = 36;
		this.Label6.Text = "Barang";
		this.cboItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboItem.FormattingEnabled = true;
		this.cboItem.Location = new System.Drawing.Point(101, 65);
		this.cboItem.Name = "cboItem";
		this.cboItem.Size = new System.Drawing.Size(139, 21);
		this.cboItem.TabIndex = 2;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(11, 154);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(40, 13);
		this.Label5.TabIndex = 35;
		this.Label5.Text = "Jumlah";
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(10, 42);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(45, 13);
		this.Label3.TabIndex = 33;
		this.Label3.Text = "Gudang";
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(10, 95);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(28, 13);
		this.Label2.TabIndex = 32;
		this.Label2.Text = "Tipe";
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(10, 15);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(46, 13);
		this.Label1.TabIndex = 31;
		this.Label1.Text = "Tanggal";
		this.cboStorage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboStorage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboStorage.FormattingEnabled = true;
		this.cboStorage.Location = new System.Drawing.Point(100, 38);
		this.cboStorage.Name = "cboStorage";
		this.cboStorage.Size = new System.Drawing.Size(139, 21);
		this.cboStorage.TabIndex = 1;
		this.dtpAdjustment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpAdjustment.Location = new System.Drawing.Point(101, 12);
		this.dtpAdjustment.Name = "dtpAdjustment";
		this.dtpAdjustment.Size = new System.Drawing.Size(138, 20);
		this.dtpAdjustment.TabIndex = 0;
		this.cboCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboCategory.FormattingEnabled = true;
		this.cboCategory.Location = new System.Drawing.Point(101, 92);
		this.cboCategory.Name = "cboCategory";
		this.cboCategory.Size = new System.Drawing.Size(139, 21);
		this.cboCategory.TabIndex = 3;
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.Location = new System.Drawing.Point(10, 122);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(85, 13);
		this.Label7.TabIndex = 40;
		this.Label7.Text = "Tambah/Kurang";
		this.cboType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboType.FormattingEnabled = true;
		this.cboType.Location = new System.Drawing.Point(101, 119);
		this.cboType.Name = "cboType";
		this.cboType.Size = new System.Drawing.Size(139, 21);
		this.cboType.TabIndex = 4;
		this.txtDescription.Location = new System.Drawing.Point(100, 178);
		this.txtDescription.Multiline = true;
		this.txtDescription.Name = "txtDescription";
		this.txtDescription.Size = new System.Drawing.Size(139, 52);
		this.txtDescription.TabIndex = 6;
		this.Label8.AutoSize = true;
		this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label8.Location = new System.Drawing.Point(10, 184);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(62, 13);
		this.Label8.TabIndex = 42;
		this.Label8.Text = "Keterangan";
		this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnHistory.Location = new System.Drawing.Point(257, 251);
		this.btnHistory.Name = "btnHistory";
		this.btnHistory.Size = new System.Drawing.Size(50, 24);
		this.btnHistory.TabIndex = 10;
		this.btnHistory.Text = "&History";
		this.btnHistory.UseVisualStyleBackColor = true;
		this.btnSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSaveClose.Location = new System.Drawing.Point(103, 251);
		this.btnSaveClose.Name = "btnSaveClose";
		this.btnSaveClose.Size = new System.Drawing.Size(93, 24);
		this.btnSaveClose.TabIndex = 8;
		this.btnSaveClose.Text = "Simpan && &Tutup";
		this.btnSaveClose.UseVisualStyleBackColor = true;
		this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDelete.Location = new System.Drawing.Point(202, 251);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new System.Drawing.Size(49, 24);
		this.btnDelete.TabIndex = 9;
		this.btnDelete.Text = "Hapus";
		this.btnDelete.UseVisualStyleBackColor = true;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(11, 251);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(86, 24);
		this.btnSave.TabIndex = 7;
		this.btnSave.Text = "&Simpan && Baru";
		this.btnSave.UseVisualStyleBackColor = true;
		this.Label11.BackColor = System.Drawing.Color.Silver;
		this.Label11.Location = new System.Drawing.Point(-320, 243);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(713, 59);
		this.Label11.TabIndex = 125;
		this.lblItem.AutoSize = true;
		this.lblItem.Location = new System.Drawing.Point(100, 68);
		this.lblItem.Name = "lblItem";
		this.lblItem.Size = new System.Drawing.Size(37, 13);
		this.lblItem.TabIndex = 128;
		this.lblItem.Text = "lblItem";
		this.lblType.AutoSize = true;
		this.lblType.Location = new System.Drawing.Point(101, 122);
		this.lblType.Name = "lblType";
		this.lblType.Size = new System.Drawing.Size(41, 13);
		this.lblType.TabIndex = 129;
		this.lblType.Text = "lblType";
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(318, 282);
		base.Controls.Add(this.lblType);
		base.Controls.Add(this.lblItem);
		base.Controls.Add(this.btnHistory);
		base.Controls.Add(this.btnSaveClose);
		base.Controls.Add(this.btnDelete);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.Label11);
		base.Controls.Add(this.Label8);
		base.Controls.Add(this.txtDescription);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.cboType);
		base.Controls.Add(this.txtQty);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.cboItem);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.cboStorage);
		base.Controls.Add(this.dtpAdjustment);
		base.Controls.Add(this.cboCategory);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmAdjustment";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Penyesuaian - Input";
		base.TopMost = true;
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmAdjustment()
	{
		base.KeyDown += frmAdjustment_KeyDown;
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
					base.MdiParent = MyProject.Forms.frmMenu;
					DoubleBuffered = true;
					txtQty.AllowedCharacters = FilteredTextBox.InputType.NumeralsAndCurrency;
					ComboBox combo = cboStorage;
					cCombo.getStorage(ref combo, Module1.pubGroupId, 0, "ALL", blnAll: false, 1);
					cboStorage = combo;
					combo = cboType;
					cCombo.getAdjustmentType(ref combo, All: false);
					cboType = combo;
					combo = cboCategory;
					cCombo.getAdjustmentCategory(ref combo, All: false, Active: true);
					cboCategory = combo;
					goto end_IL_001b;
				}
				case 197:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmAdjustment", "New", "");
						goto end_IL_001b;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try001b_dispatch = 197;
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

	public void prepareForm(bool SaveNew)
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
					if (!SaveNew)
					{
						cboStorage.SelectedIndex = -1;
						dtpAdjustment.Value = DateAndTime.Now;
					}
					dtpAdjustment.Enabled = true;
					lblItem.Text = "";
					lblItem.Visible = false;
					cboItem.Visible = true;
					lblType.Text = "";
					lblType.Visible = false;
					cboType.Visible = true;
					cboCategory.SelectedIndex = -1;
					txtQty.Text = "";
					txtDescription.Text = "";
					cboItem.SelectedIndex = -1;
					cboType.SelectedIndex = -1;
					btnHistory.Enabled = false;
					btnDelete.Enabled = false;
					intOriginalItemId = 0;
					intOriginalStorageId = 0;
					dblOriginalQty = 0.0;
					dateOriginal = DateAndTime.Now;
					goto end_IL_0001;
				case 334:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmAdjustment", "prepareForm", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 334;
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

	private void frmAdjustment_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void cboStorage_SelectedIndexChanged(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboStorage.SelectedItem;
		if (!Information.IsNothing(cComboItem2))
		{
			ComboBox combo = cboItem;
			cCombo.getItemAll(ref combo, 99, 99, 0, 0, 0, 0, 2, 1, 0, 0, Conversions.ToInteger(cComboItem2.Value), 0, 0.0, CanBeUsedAsGroupMember: false, Module1.pubGroupId, All: false, Active: true);
			cboItem = combo;
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
				switch (try0001_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					cAdjustment cAdjustment2 = new cAdjustment(_currentId);
					intOriginalItemId = cAdjustment2.ItemId;
					intOriginalStorageId = cAdjustment2.StorageId;
					dateOriginal = cAdjustment2.AdjustmentDate;
					dblOriginalQty = cAdjustment2.Qty;
					lblItem.Text = cAdjustment2.ItemName;
					lblItem.Visible = true;
					cboItem.Visible = false;
					lblType.Text = cAdjustment2.TypeName;
					lblType.Visible = true;
					cboType.Visible = false;
					ComboBox cboSource = cboStorage;
					Module1.comboBoundValue(ref cboSource, cAdjustment2.StorageId);
					cboStorage = cboSource;
					dtpAdjustment.Value = cAdjustment2.AdjustmentDate;
					cboSource = cboItem;
					Module1.comboBoundValue(ref cboSource, cAdjustment2.ItemId);
					cboItem = cboSource;
					cboSource = cboCategory;
					Module1.comboBoundValue(ref cboSource, cAdjustment2.CategoryId);
					cboCategory = cboSource;
					cboSource = cboType;
					Module1.comboBoundValue(ref cboSource, cAdjustment2.Type);
					cboType = cboSource;
					txtQty.Text = Module1.formatCustomDecimal(Conversions.ToString(cAdjustment2.Qty), 3);
					txtDescription.Text = cAdjustment2.Description;
					btnHistory.Enabled = true;
					if (DateAndTime.DateDiff(DateInterval.Day, dtpAdjustment.Value, DateAndTime.Now) <= Module1.pubDaysLimit)
					{
						dtpAdjustment.Enabled = true;
					}
					else
					{
						dtpAdjustment.Enabled = false;
					}
					if (DateAndTime.DateDiff(DateInterval.Day, dtpAdjustment.Value, DateAndTime.Now) <= Module1.pubDaysLimit)
					{
						btnDelete.Enabled = true;
					}
					else
					{
						btnDelete.Enabled = false;
					}
					goto end_IL_0001;
				}
				case 563:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmAdjustment", "loadData", "");
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
				try0001_dispatch = 563;
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
		Save(CloseForm: false);
	}

	private void btnSaveClose_Click(object sender, EventArgs e)
	{
		Save(CloseForm: true);
	}

	private void Save(bool CloseForm)
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
					cComboItem cComboItem4 = (cComboItem)cboCategory.SelectedItem;
					cComboItem cComboItem5 = (cComboItem)cboType.SelectedItem;
					if (!cValidation.isDateWithinRange(dtpAdjustment.Value, Module1.pubGroupId, Module1.pubDaysLimit))
					{
						Interaction.MsgBox("Tanggal diluar batas yang diperbolehkan", MsgBoxStyle.Information);
						dtpAdjustment.Focus();
						goto end_IL_0001;
					}
					if (cboStorage.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih gudang penyesuaian", MsgBoxStyle.Information);
						cboStorage.Focus();
						goto end_IL_0001;
					}
					if (cboItem.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih barang yang akan disesuaikan", MsgBoxStyle.Information);
						cboItem.Focus();
						goto end_IL_0001;
					}
					if (cboCategory.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih kategori penyesuaian", MsgBoxStyle.Information);
						cboCategory.Focus();
						goto end_IL_0001;
					}
					if (cboType.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih tambah/kurang", MsgBoxStyle.Information);
						cboType.Focus();
						goto end_IL_0001;
					}
					if (Conversion.Val(Module1.unformatNumber(txtQty.Text)) == 0.0)
					{
						Interaction.MsgBox("Masukkan jumlah penyesuaian", MsgBoxStyle.Information);
						txtQty.Focus();
						goto end_IL_0001;
					}
					if (!Versioned.IsNumeric(txtQty.Text))
					{
						Interaction.MsgBox("Masukkan jumlah penyesuaian dengan format angka yang benar", MsgBoxStyle.Information);
						txtQty.Focus();
						goto end_IL_0001;
					}
					if (((Conversions.ToDouble(cComboItem5.Value) == 1.0) & (dblOriginalQty < Conversions.ToDouble(txtQty.Text))) && !cValidation.isInStock(Module1.pubCheckStock, Module1.pubBalanceDate, dtpAdjustment.Value, "", dateOriginal, Conversions.ToInteger(cComboItem3.Value), intOriginalItemId, Conversions.ToDouble(txtQty.Text), dblOriginalQty, Conversions.ToInteger(cComboItem2.Value), intOriginalStorageId, Module1.pubGroupId, 2))
					{
						Interaction.MsgBox("Stok tidak tersedia", MsgBoxStyle.Information);
						txtQty.Focus();
						goto end_IL_0001;
					}
					if (((_currentId > 0.0) & (Conversions.ToDouble(cComboItem5.Value) == 0.0) & (Conversions.ToDouble(cComboItem2.Value) == (double)intOriginalStorageId) & (dblOriginalQty > Conversions.ToDouble(txtQty.Text))) && !cValidation.isInStock(Module1.pubCheckStock, Module1.pubBalanceDate, dtpAdjustment.Value, "", dateOriginal, Conversions.ToInteger(cComboItem3.Value), intOriginalItemId, Conversions.ToDouble(txtQty.Text), dblOriginalQty, Conversions.ToInteger(cComboItem2.Value), intOriginalStorageId, Module1.pubGroupId, 1))
					{
						Interaction.MsgBox("Stok tidak tersedia. Update ini membuat stok di gudang menjadi negatif.", MsgBoxStyle.Information);
						txtQty.Focus();
						goto end_IL_0001;
					}
					if (((_currentId > 0.0) & (Conversions.ToDouble(cComboItem5.Value) == 0.0) & (Conversions.ToDouble(cComboItem2.Value) != (double)intOriginalStorageId) & (dblOriginalQty > Conversions.ToDouble(txtQty.Text))) && !cValidation.isInStock(Module1.pubCheckStock, Module1.pubBalanceDate, dtpAdjustment.Value, "", dateOriginal, Conversions.ToInteger(cComboItem3.Value), intOriginalItemId, Conversions.ToDouble(txtQty.Text), dblOriginalQty, intOriginalStorageId, intOriginalStorageId, Module1.pubGroupId, 3))
					{
						Interaction.MsgBox("Stok tidak tersedia. Update ini membuat stok di gudang yang sebelumnya menjadi negatif.", MsgBoxStyle.Information);
						cboStorage.Focus();
						goto end_IL_0001;
					}
					cAdjustment cAdjustment2 = new cAdjustment(_currentId);
					cAdjustment2.CurrentItem = cAdjustment2.ItemId;
					cAdjustment2.CurrentDate = cAdjustment2.AdjustmentDate;
					cAdjustment2.CurrentQty = cAdjustment2.Qty;
					cAdjustment2.CurrentStorage = cAdjustment2.StorageId;
					cAdjustment2.CurrentType = cAdjustment2.Type;
					cAdjustment2.AdjustmentDate = dtpAdjustment.Value;
					cAdjustment2.StorageId = Conversions.ToInteger(cComboItem2.Value);
					cAdjustment2.ItemId = Conversions.ToInteger(cComboItem3.Value);
					cAdjustment2.CategoryId = Conversions.ToInteger(cComboItem4.Value);
					cAdjustment2.Type = Conversions.ToInteger(cComboItem5.Value);
					cAdjustment2.Qty = Conversions.ToDouble(txtQty.Text);
					cAdjustment2.Description = txtDescription.Text;
					cAdjustment2.save();
					string content = "Tanggal: " + Strings.Format(dtpAdjustment.Value, "dd/MM/yyyy") + "<br />Gudang: " + cboStorage.Text + "<br />Barang: " + cboItem.Text + "<br />+/-: " + cboType.Text + "<br />Jumlah: " + txtQty.Text + "<br />Keterangan: " + Module1.cleanString(txtDescription.Text);
					string text;
					if (_currentId == 0.0)
					{
						text = "membuat ";
						_currentId = cDatabase.LastId("data");
					}
					else
					{
						text = "mengupdate ";
					}
					text = text + "penyesuaian " + cboItem.Text + ". " + cboType.Text + " sejumlah " + txtQty.Text + " di gudang " + cboStorage.Text + ". Tanggal penyesuaian " + Strings.Format(dtpAdjustment.Value, "dd/MM/yyyy") + ". ID= " + Conversions.ToString(_currentId) + ", v2";
					cHistory cHistory2 = new cHistory();
					cHistory2.Content = content;
					cHistory2.Description = text;
					cHistory2.UserId = Module1.pubUserId;
					cHistory2.UserLogin = Module1.pubLogin;
					cHistory2.fKeyId = _currentId;
					cHistory2.HistoryType = 3;
					cHistory2.Save();
					Interaction.MsgBox("Penyesuaian berhasil disimpan", MsgBoxStyle.Information);
					if (Module1.FormIsOpen("frmAdjustmentList"))
					{
						MyProject.Forms.frmAdjustmentList.GetRecent();
					}
					MyProject.Forms.frmInformation.GetActivity();
					if (CloseForm)
					{
						Close();
						goto end_IL_0001;
					}
					prepareForm(SaveNew: true);
					cboItem.Focus();
					goto end_IL_0001_2;
				}
				case 1988:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmAdjustment", "SaveData", "");
						goto end_IL_0001_2;
					}
					break;
				}
				goto IL_07fa;
				end_IL_0001_2:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1988;
				continue;
			}
			break;
			IL_07fa:
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
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					cComboItem cComboItem2 = (cComboItem)cboType.SelectedItem;
					if (((_currentId > 0.0) & (Conversions.ToDouble(cComboItem2.Value) == 0.0)) && !cValidation.isInStock(Module1.pubCheckStock, Module1.pubBalanceDate, dateOriginal, "", dateOriginal, intOriginalItemId, intOriginalItemId, dblOriginalQty, dblOriginalQty, intOriginalStorageId, intOriginalStorageId, Module1.pubGroupId, 3))
					{
						Interaction.MsgBox("Penyesuaian tidak bisa dihapus karena akan membuat stok gudang menjadi negatif", MsgBoxStyle.Information);
					}
					else if (MessageBox.Show("Hapus Penyesuaian?", "Konfirmasi", MessageBoxButtons.YesNo) != DialogResult.No)
					{
						cAdjustment cAdjustment2 = new cAdjustment(_currentId);
						cAdjustment2.CurrentItem = cAdjustment2.ItemId;
						cAdjustment2.CurrentDate = cAdjustment2.AdjustmentDate;
						cAdjustment2.CurrentQty = cAdjustment2.Qty;
						cAdjustment2.CurrentStorage = cAdjustment2.StorageId;
						cAdjustment2.CurrentType = cAdjustment2.Type;
						cAdjustment2.Delete();
						string description = "menghapus penyesuaian " + cAdjustment2.ItemName + ". " + cAdjustment2.TypeName + " sejumlah " + Conversions.ToString(cAdjustment2.Qty) + " di gudang " + cAdjustment2.StorageName + ". Tanggal penyesuaian " + Strings.Format(cAdjustment2.AdjustmentDate, "dd/MM/yyyy") + ". ID=" + Conversions.ToString(_currentId) + ", v2";
						cHistory cHistory2 = new cHistory();
						cHistory2.Description = description;
						cHistory2.UserId = Module1.pubUserId;
						cHistory2.UserLogin = Module1.pubLogin;
						cHistory2.fKeyId = _currentId;
						cHistory2.HistoryType = 3;
						cHistory2.Save();
						Interaction.MsgBox("Penyesuaian berhasil dihapus", MsgBoxStyle.Information);
						if (Module1.FormIsOpen("frmAdjustmentList"))
						{
							MyProject.Forms.frmAdjustmentList.GetRecent();
						}
						MyProject.Forms.frmInformation.GetActivity();
						Close();
					}
					goto end_IL_0001;
				}
				case 634:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmAdjustment", "btnDelete_Click", "");
						goto end_IL_0001;
					}
					break;
				}
				goto IL_02b0;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 634;
				continue;
			}
			break;
			IL_02b0:
			throw ProjectData.CreateProjectError(-2146828237);
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
					MyProject.Forms.frmHistory.GetHistory(checked((int)Math.Round(_currentId)), 3);
					MyProject.Forms.frmHistory.Show();
					MyProject.Forms.frmHistory.Activate();
					MyProject.Forms.frmHistory.WindowState = FormWindowState.Normal;
					goto end_IL_0001;
				case 119:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmAdjustment", "btnHistory_Click", "");
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
