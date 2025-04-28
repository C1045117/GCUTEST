using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GCUv2.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

[DesignerGenerated]
public class frmSettingGroup : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSave")]
	private Button _btnSave;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboGroup")]
	private ComboBox _cboGroup;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TabControl1")]
	private TabControl _TabControl1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvCashAccount")]
	private DataGridView _dgvCashAccount;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvBankAccount")]
	private DataGridView _dgvBankAccount;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvPermissionType1")]
	private DataGridView _dgvPermissionType1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvPermissionType2")]
	private DataGridView _dgvPermissionType2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvStorage")]
	private DataGridView _dgvStorage;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvBranch")]
	private DataGridView _dgvBranch;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("tsbNew")]
	private ToolStripButton _tsbNew;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("tsbDelete")]
	private ToolStripButton _tsbDelete;

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

	internal virtual ComboBox cboGroup
	{
		[CompilerGenerated]
		get
		{
			return _cboGroup;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cboGroup_SelectedIndexChanged;
			ComboBox comboBox = _cboGroup;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_cboGroup = value;
			comboBox = _cboGroup;
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

	internal virtual TabControl TabControl1
	{
		[CompilerGenerated]
		get
		{
			return _TabControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TabControl1_SelectedIndexChanged;
			TabControl tabControl = _TabControl1;
			if (tabControl != null)
			{
				tabControl.SelectedIndexChanged -= value2;
			}
			_TabControl1 = value;
			tabControl = _TabControl1;
			if (tabControl != null)
			{
				tabControl.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TabPage1")]
	internal virtual TabPage TabPage1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("clbItemCategory")]
	internal virtual CheckedListBox clbItemCategory
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage2")]
	internal virtual TabPage TabPage2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage3")]
	internal virtual TabPage TabPage3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView dgvCashAccount
	{
		[CompilerGenerated]
		get
		{
			return _dgvCashAccount;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = dgvCashAccount_KeyDown;
			EventHandler value3 = dgvCashAccount_GotFocus;
			EventHandler value4 = dgvCashAccount_LostFocus;
			DataGridViewCellEventHandler value5 = dgvCashAccount_CellContentClick;
			DataGridView dataGridView = _dgvCashAccount;
			if (dataGridView != null)
			{
				dataGridView.KeyDown -= value2;
				dataGridView.GotFocus -= value3;
				dataGridView.LostFocus -= value4;
				dataGridView.CellContentClick -= value5;
			}
			_dgvCashAccount = value;
			dataGridView = _dgvCashAccount;
			if (dataGridView != null)
			{
				dataGridView.KeyDown += value2;
				dataGridView.GotFocus += value3;
				dataGridView.LostFocus += value4;
				dataGridView.CellContentClick += value5;
			}
		}
	}

	[field: AccessedThroughProperty("lblUserName")]
	internal virtual Label lblUserName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView dgvBankAccount
	{
		[CompilerGenerated]
		get
		{
			return _dgvBankAccount;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = dgvBankAccount_KeyDown;
			EventHandler value3 = dgvBankAccount_GotFocus;
			EventHandler value4 = dgvBankAccount_LostFocus;
			DataGridViewCellEventHandler value5 = dgvBankAccount_CellContentClick;
			DataGridView dataGridView = _dgvBankAccount;
			if (dataGridView != null)
			{
				dataGridView.KeyDown -= value2;
				dataGridView.GotFocus -= value3;
				dataGridView.LostFocus -= value4;
				dataGridView.CellContentClick -= value5;
			}
			_dgvBankAccount = value;
			dataGridView = _dgvBankAccount;
			if (dataGridView != null)
			{
				dataGridView.KeyDown += value2;
				dataGridView.GotFocus += value3;
				dataGridView.LostFocus += value4;
				dataGridView.CellContentClick += value5;
			}
		}
	}

	[field: AccessedThroughProperty("TabPage4")]
	internal virtual TabPage TabPage4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("clbPage")]
	internal virtual CheckedListBox clbPage
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage5")]
	internal virtual TabPage TabPage5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage6")]
	internal virtual TabPage TabPage6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("clbSupplier")]
	internal virtual CheckedListBox clbSupplier
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView dgvPermissionType1
	{
		[CompilerGenerated]
		get
		{
			return _dgvPermissionType1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = dgvPermissionType1_KeyDown;
			EventHandler value3 = dgvPermissionType1_GotFocus;
			EventHandler value4 = dgvPermissionType1_LostFocus;
			DataGridView dataGridView = _dgvPermissionType1;
			if (dataGridView != null)
			{
				dataGridView.KeyDown -= value2;
				dataGridView.GotFocus -= value3;
				dataGridView.LostFocus -= value4;
			}
			_dgvPermissionType1 = value;
			dataGridView = _dgvPermissionType1;
			if (dataGridView != null)
			{
				dataGridView.KeyDown += value2;
				dataGridView.GotFocus += value3;
				dataGridView.LostFocus += value4;
			}
		}
	}

	[field: AccessedThroughProperty("TabPage7")]
	internal virtual TabPage TabPage7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView dgvPermissionType2
	{
		[CompilerGenerated]
		get
		{
			return _dgvPermissionType2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = dgvPermissionType2_KeyDown;
			EventHandler value3 = dgvPermissionType2_GotFocus;
			EventHandler value4 = dgvPermissionType2_LostFocus;
			DataGridView dataGridView = _dgvPermissionType2;
			if (dataGridView != null)
			{
				dataGridView.KeyDown -= value2;
				dataGridView.GotFocus -= value3;
				dataGridView.LostFocus -= value4;
			}
			_dgvPermissionType2 = value;
			dataGridView = _dgvPermissionType2;
			if (dataGridView != null)
			{
				dataGridView.KeyDown += value2;
				dataGridView.GotFocus += value3;
				dataGridView.LostFocus += value4;
			}
		}
	}

	[field: AccessedThroughProperty("TabPage8")]
	internal virtual TabPage TabPage8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView dgvStorage
	{
		[CompilerGenerated]
		get
		{
			return _dgvStorage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = dgvStorage_KeyDown;
			EventHandler value3 = dgvStorage_GotFocus;
			EventHandler value4 = dgvStorage_LostFocus;
			DataGridViewCellEventHandler value5 = dgvStorage_CellContentClick;
			DataGridView dataGridView = _dgvStorage;
			if (dataGridView != null)
			{
				dataGridView.KeyDown -= value2;
				dataGridView.GotFocus -= value3;
				dataGridView.LostFocus -= value4;
				dataGridView.CellContentClick -= value5;
			}
			_dgvStorage = value;
			dataGridView = _dgvStorage;
			if (dataGridView != null)
			{
				dataGridView.KeyDown += value2;
				dataGridView.GotFocus += value3;
				dataGridView.LostFocus += value4;
				dataGridView.CellContentClick += value5;
			}
		}
	}

	[field: AccessedThroughProperty("TabPage9")]
	internal virtual TabPage TabPage9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView dgvBranch
	{
		[CompilerGenerated]
		get
		{
			return _dgvBranch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = dgvBranch_KeyDown;
			EventHandler value3 = dgvBranch_GotFocus;
			EventHandler value4 = dgvBranch_LostFocus;
			DataGridViewCellEventHandler value5 = dgvBranch_CellContentClick;
			DataGridView dataGridView = _dgvBranch;
			if (dataGridView != null)
			{
				dataGridView.KeyDown -= value2;
				dataGridView.GotFocus -= value3;
				dataGridView.LostFocus -= value4;
				dataGridView.CellContentClick -= value5;
			}
			_dgvBranch = value;
			dataGridView = _dgvBranch;
			if (dataGridView != null)
			{
				dataGridView.KeyDown += value2;
				dataGridView.GotFocus += value3;
				dataGridView.LostFocus += value4;
				dataGridView.CellContentClick += value5;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStrip1")]
	internal virtual ToolStrip ToolStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripButton tsbNew
	{
		[CompilerGenerated]
		get
		{
			return _tsbNew;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = tsbNew_Click;
			ToolStripButton toolStripButton = _tsbNew;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value2;
			}
			_tsbNew = value;
			toolStripButton = _tsbNew;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value2;
			}
		}
	}

	internal virtual ToolStripButton tsbDelete
	{
		[CompilerGenerated]
		get
		{
			return _tsbDelete;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = tsbDelete_Click;
			ToolStripButton toolStripButton = _tsbDelete;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value2;
			}
			_tsbDelete = value;
			toolStripButton = _tsbDelete;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value2;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GCUv2.frmSettingGroup));
		this.btnSave = new System.Windows.Forms.Button();
		this.cboGroup = new System.Windows.Forms.ComboBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.TabControl1 = new System.Windows.Forms.TabControl();
		this.TabPage4 = new System.Windows.Forms.TabPage();
		this.clbPage = new System.Windows.Forms.CheckedListBox();
		this.TabPage5 = new System.Windows.Forms.TabPage();
		this.dgvPermissionType1 = new System.Windows.Forms.DataGridView();
		this.TabPage7 = new System.Windows.Forms.TabPage();
		this.dgvPermissionType2 = new System.Windows.Forms.DataGridView();
		this.TabPage6 = new System.Windows.Forms.TabPage();
		this.clbSupplier = new System.Windows.Forms.CheckedListBox();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.clbItemCategory = new System.Windows.Forms.CheckedListBox();
		this.TabPage2 = new System.Windows.Forms.TabPage();
		this.dgvCashAccount = new System.Windows.Forms.DataGridView();
		this.TabPage3 = new System.Windows.Forms.TabPage();
		this.dgvBankAccount = new System.Windows.Forms.DataGridView();
		this.TabPage8 = new System.Windows.Forms.TabPage();
		this.dgvStorage = new System.Windows.Forms.DataGridView();
		this.TabPage9 = new System.Windows.Forms.TabPage();
		this.dgvBranch = new System.Windows.Forms.DataGridView();
		this.lblUserName = new System.Windows.Forms.Label();
		this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
		this.tsbNew = new System.Windows.Forms.ToolStripButton();
		this.tsbDelete = new System.Windows.Forms.ToolStripButton();
		this.TabControl1.SuspendLayout();
		this.TabPage4.SuspendLayout();
		this.TabPage5.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvPermissionType1).BeginInit();
		this.TabPage7.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvPermissionType2).BeginInit();
		this.TabPage6.SuspendLayout();
		this.TabPage1.SuspendLayout();
		this.TabPage2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvCashAccount).BeginInit();
		this.TabPage3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvBankAccount).BeginInit();
		this.TabPage8.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvStorage).BeginInit();
		this.TabPage9.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvBranch).BeginInit();
		this.ToolStrip1.SuspendLayout();
		base.SuspendLayout();
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(564, 490);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(65, 28);
		this.btnSave.TabIndex = 100;
		this.btnSave.Text = "Simpan";
		this.btnSave.UseVisualStyleBackColor = true;
		this.cboGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboGroup.FormattingEnabled = true;
		this.cboGroup.Location = new System.Drawing.Point(48, 68);
		this.cboGroup.Name = "cboGroup";
		this.cboGroup.Size = new System.Drawing.Size(145, 21);
		this.cboGroup.TabIndex = 0;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(16, 71);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(30, 13);
		this.Label1.TabIndex = 3;
		this.Label1.Text = "Grup";
		this.TabControl1.Controls.Add(this.TabPage4);
		this.TabControl1.Controls.Add(this.TabPage5);
		this.TabControl1.Controls.Add(this.TabPage7);
		this.TabControl1.Controls.Add(this.TabPage6);
		this.TabControl1.Controls.Add(this.TabPage1);
		this.TabControl1.Controls.Add(this.TabPage2);
		this.TabControl1.Controls.Add(this.TabPage3);
		this.TabControl1.Controls.Add(this.TabPage8);
		this.TabControl1.Controls.Add(this.TabPage9);
		this.TabControl1.Location = new System.Drawing.Point(19, 103);
		this.TabControl1.Name = "TabControl1";
		this.TabControl1.SelectedIndex = 0;
		this.TabControl1.Size = new System.Drawing.Size(610, 381);
		this.TabControl1.TabIndex = 1;
		this.TabPage4.Controls.Add(this.clbPage);
		this.TabPage4.Location = new System.Drawing.Point(4, 22);
		this.TabPage4.Name = "TabPage4";
		this.TabPage4.Size = new System.Drawing.Size(602, 355);
		this.TabPage4.TabIndex = 3;
		this.TabPage4.Text = "Menu";
		this.TabPage4.UseVisualStyleBackColor = true;
		this.clbPage.CheckOnClick = true;
		this.clbPage.FormattingEnabled = true;
		this.clbPage.Location = new System.Drawing.Point(17, 19);
		this.clbPage.Name = "clbPage";
		this.clbPage.Size = new System.Drawing.Size(299, 319);
		this.clbPage.TabIndex = 12;
		this.TabPage5.Controls.Add(this.dgvPermissionType1);
		this.TabPage5.Location = new System.Drawing.Point(4, 22);
		this.TabPage5.Name = "TabPage5";
		this.TabPage5.Size = new System.Drawing.Size(602, 355);
		this.TabPage5.TabIndex = 4;
		this.TabPage5.Text = "Detail 1";
		this.TabPage5.UseVisualStyleBackColor = true;
		this.dgvPermissionType1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvPermissionType1.Location = new System.Drawing.Point(17, 19);
		this.dgvPermissionType1.Name = "dgvPermissionType1";
		this.dgvPermissionType1.Size = new System.Drawing.Size(413, 324);
		this.dgvPermissionType1.TabIndex = 24;
		this.TabPage7.Controls.Add(this.dgvPermissionType2);
		this.TabPage7.Location = new System.Drawing.Point(4, 22);
		this.TabPage7.Name = "TabPage7";
		this.TabPage7.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage7.Size = new System.Drawing.Size(602, 355);
		this.TabPage7.TabIndex = 6;
		this.TabPage7.Text = "Detail 2";
		this.TabPage7.UseVisualStyleBackColor = true;
		this.dgvPermissionType2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvPermissionType2.Location = new System.Drawing.Point(17, 19);
		this.dgvPermissionType2.Name = "dgvPermissionType2";
		this.dgvPermissionType2.Size = new System.Drawing.Size(475, 324);
		this.dgvPermissionType2.TabIndex = 26;
		this.TabPage6.Controls.Add(this.clbSupplier);
		this.TabPage6.Location = new System.Drawing.Point(4, 22);
		this.TabPage6.Name = "TabPage6";
		this.TabPage6.Size = new System.Drawing.Size(602, 355);
		this.TabPage6.TabIndex = 5;
		this.TabPage6.Text = "Supplier";
		this.TabPage6.UseVisualStyleBackColor = true;
		this.clbSupplier.CheckOnClick = true;
		this.clbSupplier.FormattingEnabled = true;
		this.clbSupplier.Location = new System.Drawing.Point(17, 19);
		this.clbSupplier.Name = "clbSupplier";
		this.clbSupplier.Size = new System.Drawing.Size(215, 319);
		this.clbSupplier.TabIndex = 13;
		this.TabPage1.Controls.Add(this.clbItemCategory);
		this.TabPage1.Location = new System.Drawing.Point(4, 22);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage1.Size = new System.Drawing.Size(602, 355);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = "Kategori Produk";
		this.TabPage1.UseVisualStyleBackColor = true;
		this.clbItemCategory.CheckOnClick = true;
		this.clbItemCategory.FormattingEnabled = true;
		this.clbItemCategory.Location = new System.Drawing.Point(17, 19);
		this.clbItemCategory.Name = "clbItemCategory";
		this.clbItemCategory.Size = new System.Drawing.Size(168, 319);
		this.clbItemCategory.TabIndex = 11;
		this.TabPage2.Controls.Add(this.dgvCashAccount);
		this.TabPage2.Location = new System.Drawing.Point(4, 22);
		this.TabPage2.Name = "TabPage2";
		this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage2.Size = new System.Drawing.Size(602, 355);
		this.TabPage2.TabIndex = 1;
		this.TabPage2.Text = "Kas";
		this.TabPage2.UseVisualStyleBackColor = true;
		this.dgvCashAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvCashAccount.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
		this.dgvCashAccount.Location = new System.Drawing.Point(6, 20);
		this.dgvCashAccount.Name = "dgvCashAccount";
		this.dgvCashAccount.Size = new System.Drawing.Size(523, 320);
		this.dgvCashAccount.TabIndex = 21;
		this.TabPage3.Controls.Add(this.dgvBankAccount);
		this.TabPage3.Location = new System.Drawing.Point(4, 22);
		this.TabPage3.Name = "TabPage3";
		this.TabPage3.Size = new System.Drawing.Size(602, 355);
		this.TabPage3.TabIndex = 2;
		this.TabPage3.Text = "Rekening";
		this.TabPage3.UseVisualStyleBackColor = true;
		this.dgvBankAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvBankAccount.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
		this.dgvBankAccount.Location = new System.Drawing.Point(6, 20);
		this.dgvBankAccount.Name = "dgvBankAccount";
		this.dgvBankAccount.Size = new System.Drawing.Size(522, 321);
		this.dgvBankAccount.TabIndex = 62;
		this.TabPage8.Controls.Add(this.dgvStorage);
		this.TabPage8.Location = new System.Drawing.Point(4, 22);
		this.TabPage8.Name = "TabPage8";
		this.TabPage8.Size = new System.Drawing.Size(602, 355);
		this.TabPage8.TabIndex = 7;
		this.TabPage8.Text = "Gudang";
		this.TabPage8.UseVisualStyleBackColor = true;
		this.dgvStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvStorage.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
		this.dgvStorage.Location = new System.Drawing.Point(13, 17);
		this.dgvStorage.Name = "dgvStorage";
		this.dgvStorage.Size = new System.Drawing.Size(522, 305);
		this.dgvStorage.TabIndex = 22;
		this.TabPage9.Controls.Add(this.dgvBranch);
		this.TabPage9.Location = new System.Drawing.Point(4, 22);
		this.TabPage9.Name = "TabPage9";
		this.TabPage9.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage9.Size = new System.Drawing.Size(602, 355);
		this.TabPage9.TabIndex = 8;
		this.TabPage9.Text = "Cabang";
		this.TabPage9.UseVisualStyleBackColor = true;
		this.dgvBranch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvBranch.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
		this.dgvBranch.Location = new System.Drawing.Point(13, 17);
		this.dgvBranch.Name = "dgvBranch";
		this.dgvBranch.Size = new System.Drawing.Size(522, 305);
		this.dgvBranch.TabIndex = 22;
		this.lblUserName.AutoSize = true;
		this.lblUserName.Location = new System.Drawing.Point(194, 71);
		this.lblUserName.Name = "lblUserName";
		this.lblUserName.Size = new System.Drawing.Size(56, 13);
		this.lblUserName.TabIndex = 100;
		this.lblUserName.Text = "Anggota: -";
		this.ToolStrip1.AutoSize = false;
		this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
		this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.tsbNew, this.tsbDelete });
		this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
		this.ToolStrip1.Name = "ToolStrip1";
		this.ToolStrip1.Size = new System.Drawing.Size(644, 60);
		this.ToolStrip1.TabIndex = 101;
		this.ToolStrip1.Text = "ToolStrip1";
		this.tsbNew.Image = (System.Drawing.Image)resources.GetObject("tsbNew.Image");
		this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.tsbNew.Name = "tsbNew";
		this.tsbNew.Size = new System.Drawing.Size(55, 57);
		this.tsbNew.Text = "&Tambah";
		this.tsbNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.tsbDelete.Image = (System.Drawing.Image)resources.GetObject("tsbDelete.Image");
		this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.tsbDelete.Name = "tsbDelete";
		this.tsbDelete.Size = new System.Drawing.Size(45, 57);
		this.tsbDelete.Text = "&Hapus";
		this.tsbDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.tsbDelete.ToolTipText = "Hapus";
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(644, 530);
		base.Controls.Add(this.ToolStrip1);
		base.Controls.Add(this.lblUserName);
		base.Controls.Add(this.TabControl1);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.cboGroup);
		base.Controls.Add(this.btnSave);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSettingGroup";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Setting - Grup";
		this.TabControl1.ResumeLayout(false);
		this.TabPage4.ResumeLayout(false);
		this.TabPage5.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgvPermissionType1).EndInit();
		this.TabPage7.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgvPermissionType2).EndInit();
		this.TabPage6.ResumeLayout(false);
		this.TabPage1.ResumeLayout(false);
		this.TabPage2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgvCashAccount).EndInit();
		this.TabPage3.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgvBankAccount).EndInit();
		this.TabPage8.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgvStorage).EndInit();
		this.TabPage9.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgvBranch).EndInit();
		this.ToolStrip1.ResumeLayout(false);
		this.ToolStrip1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmSettingGroup()
	{
		base.KeyDown += frmSettingGroup_KeyDown;
		base.Load += frmSettingGroup_Load;
		InitializeComponent();
		base.MdiParent = MyProject.Forms.frmMenu;
		FormatGrid();
	}

	private void frmSettingGroup_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
		else if (e.KeyCode == Keys.F2)
		{
			tsbNew.PerformClick();
		}
	}

	private void frmSettingGroup_Load(object sender, EventArgs e)
	{
		ComboBox combo = cboGroup;
		cCombo.getGroup(ref combo);
		cboGroup = combo;
		DataTable dataTable = cSupplier.Search("", 0, 99);
		foreach (DataRow row in dataTable.Rows)
		{
			clbSupplier.Items.Add(new cSupplier(Conversions.ToInteger(row["supId"])));
		}
		dataTable = cPermission.Search(1);
		foreach (DataRow row2 in dataTable.Rows)
		{
			dgvPermissionType1.Rows.Add(row2["permId"], TriState.False, row2["permDesc"]);
		}
		dataTable = cPermission.Search(2);
		foreach (DataRow row3 in dataTable.Rows)
		{
			dgvPermissionType2.Rows.Add(row3["permId"], row3["permDesc"]);
		}
		dataTable = cItemCategory.getItemCategory(0, Active: false);
		foreach (DataRow row4 in dataTable.Rows)
		{
			clbItemCategory.Items.Add(new cItemCategory(Conversions.ToInteger(row4["catId"])));
		}
		dataTable = cPage.getParent();
		foreach (DataRow row5 in dataTable.Rows)
		{
			clbPage.Items.Add(new cPage(Conversions.ToInteger(row5["pageId"])));
			DataTable child = cPage.getChild(Conversions.ToInteger(row5["pageId"]));
			foreach (DataRow row6 in child.Rows)
			{
				clbPage.Items.Add(new cPage(Conversions.ToInteger(row6["pageId"])));
				if (!Operators.ConditionalCompareObjectEqual(row6["pageIsParent"], 1, TextCompare: false))
				{
					continue;
				}
				DataTable child2 = cPage.getChild(Conversions.ToInteger(row6["pageId"]));
				foreach (DataRow row7 in child2.Rows)
				{
					clbPage.Items.Add(new cPage(Conversions.ToInteger(row7["pageId"])));
				}
			}
		}
	}

	private void FormatGrid()
	{
		DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
		dgvPermissionType1.Columns.Add("", "ID");
		dgvPermissionType1.Columns.Add(dataGridViewCheckBoxColumn);
		dataGridViewCheckBoxColumn.HeaderText = "";
		dataGridViewCheckBoxColumn.Name = "chk";
		dgvPermissionType1.Columns.Add("", "Permission");
		dgvPermissionType1.Columns[0].Visible = false;
		dgvPermissionType1.Columns[2].ReadOnly = true;
		dgvPermissionType1.Columns[1].Width = 30;
		dgvPermissionType1.Columns[2].Width = 360;
		dgvPermissionType1.RowHeadersVisible = false;
		dgvPermissionType1.AllowUserToAddRows = false;
		dgvPermissionType1.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvPermissionType1.AllowUserToResizeRows = false;
		dgvPermissionType1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8f);
		dgvPermissionType2.Columns.Add("", "ID");
		dgvPermissionType2.Columns.Add("", "Permission");
		dgvPermissionType2.Columns.Add("", "Nilai");
		dgvPermissionType2.Columns[0].Visible = false;
		dgvPermissionType2.Columns[1].ReadOnly = true;
		dgvPermissionType2.Columns[1].Width = 300;
		dgvPermissionType2.Columns[2].Width = 100;
		dgvPermissionType2.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvPermissionType2.RowHeadersVisible = false;
		dgvPermissionType2.AllowUserToAddRows = false;
		dgvPermissionType2.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvPermissionType2.AllowUserToResizeRows = false;
		dgvPermissionType2.EditMode = DataGridViewEditMode.EditOnEnter;
		DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2 = new DataGridViewCheckBoxColumn();
		DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3 = new DataGridViewCheckBoxColumn();
		DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4 = new DataGridViewCheckBoxColumn();
		DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5 = new DataGridViewCheckBoxColumn();
		dgvCashAccount.Columns.Add("", "kgId");
		dgvCashAccount.Columns[0].Visible = false;
		dgvCashAccount.Columns.Add("", "Kas");
		dgvCashAccount.Columns[1].ReadOnly = true;
		dgvCashAccount.Columns.Add(dataGridViewCheckBoxColumn2);
		dataGridViewCheckBoxColumn2.HeaderText = "Umum";
		dataGridViewCheckBoxColumn2.Name = "chkGeneral";
		dgvCashAccount.Columns.Add(dataGridViewCheckBoxColumn3);
		dataGridViewCheckBoxColumn3.HeaderText = "Default";
		dataGridViewCheckBoxColumn3.Name = "chkDefault";
		dgvCashAccount.Columns.Add(dataGridViewCheckBoxColumn4);
		dataGridViewCheckBoxColumn4.HeaderText = "Transaksi";
		dataGridViewCheckBoxColumn4.Name = "chkTransaction";
		dgvCashAccount.Columns.Add(dataGridViewCheckBoxColumn5);
		dataGridViewCheckBoxColumn5.HeaderText = "Saldo";
		dataGridViewCheckBoxColumn5.Name = "chkBalance";
		dgvCashAccount.RowHeadersVisible = false;
		dgvCashAccount.AllowUserToAddRows = false;
		dgvCashAccount.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvCashAccount.AllowUserToResizeRows = false;
		DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn6 = new DataGridViewCheckBoxColumn();
		DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn7 = new DataGridViewCheckBoxColumn();
		DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn8 = new DataGridViewCheckBoxColumn();
		DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn9 = new DataGridViewCheckBoxColumn();
		dgvBankAccount.Columns.Add("", "tgId");
		dgvBankAccount.Columns[0].Visible = false;
		dgvBankAccount.Columns.Add("", "Rekening");
		dgvBankAccount.Columns[1].ReadOnly = true;
		dgvBankAccount.Columns.Add(dataGridViewCheckBoxColumn6);
		dataGridViewCheckBoxColumn6.HeaderText = "Umum";
		dataGridViewCheckBoxColumn6.Name = "chkGeneral";
		dgvBankAccount.Columns.Add(dataGridViewCheckBoxColumn7);
		dataGridViewCheckBoxColumn7.HeaderText = "Default";
		dataGridViewCheckBoxColumn7.Name = "chkDefault";
		dgvBankAccount.Columns.Add(dataGridViewCheckBoxColumn8);
		dataGridViewCheckBoxColumn8.HeaderText = "Transaksi";
		dataGridViewCheckBoxColumn8.Name = "chkTransaction";
		dgvBankAccount.Columns.Add(dataGridViewCheckBoxColumn9);
		dataGridViewCheckBoxColumn9.HeaderText = "Saldo";
		dataGridViewCheckBoxColumn9.Name = "chkBalance";
		dgvBankAccount.RowHeadersVisible = false;
		dgvBankAccount.AllowUserToAddRows = false;
		dgvBankAccount.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvBankAccount.AllowUserToResizeRows = false;
		DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn10 = new DataGridViewCheckBoxColumn();
		DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn11 = new DataGridViewCheckBoxColumn();
		dgvStorage.Columns.Add("", "kgId");
		dgvStorage.Columns[0].Visible = false;
		dgvStorage.Columns.Add("", "Gudang");
		dgvStorage.Columns[1].ReadOnly = true;
		dgvStorage.Columns.Add(dataGridViewCheckBoxColumn10);
		dataGridViewCheckBoxColumn10.HeaderText = "Umum";
		dataGridViewCheckBoxColumn10.Name = "chkGeneral";
		dgvStorage.Columns.Add(dataGridViewCheckBoxColumn11);
		dataGridViewCheckBoxColumn11.HeaderText = "Default";
		dataGridViewCheckBoxColumn11.Name = "chkDefault";
		dgvStorage.Columns[1].Width = 160;
		dgvStorage.RowHeadersVisible = false;
		dgvStorage.AllowUserToAddRows = false;
		dgvStorage.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvStorage.AllowUserToResizeRows = false;
		DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn12 = new DataGridViewCheckBoxColumn();
		DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn13 = new DataGridViewCheckBoxColumn();
		dgvBranch.Columns.Add("", "kgId");
		dgvBranch.Columns[0].Visible = false;
		dgvBranch.Columns.Add("", "Cabang");
		dgvBranch.Columns[1].ReadOnly = true;
		dgvBranch.Columns.Add(dataGridViewCheckBoxColumn12);
		dataGridViewCheckBoxColumn12.HeaderText = "Umum";
		dataGridViewCheckBoxColumn12.Name = "chkGeneral";
		dgvBranch.Columns.Add(dataGridViewCheckBoxColumn13);
		dataGridViewCheckBoxColumn13.HeaderText = "Default";
		dataGridViewCheckBoxColumn13.Name = "chkDefault";
		dgvBranch.Columns[1].Width = 160;
		dgvBranch.RowHeadersVisible = false;
		dgvBranch.AllowUserToAddRows = false;
		dgvBranch.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvBranch.AllowUserToResizeRows = false;
	}

	private void dgvPermissionType1_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			e.SuppressKeyPress = true;
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			TabControl1.Focus();
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			dgvPermissionType2.Focus();
			e.SuppressKeyPress = true;
		}
	}

	private void dgvPermissionType1_GotFocus(object sender, EventArgs e)
	{
		if (dgvPermissionType1.RowCount > 0)
		{
			dgvPermissionType1.CurrentRow.Selected = true;
		}
	}

	private void dgvPermissionType1_LostFocus(object sender, EventArgs e)
	{
		if (dgvPermissionType1.RowCount > 0)
		{
			dgvPermissionType1.CurrentRow.Selected = false;
		}
	}

	private void dgvPermissionType2_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			e.SuppressKeyPress = true;
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			dgvPermissionType1.Focus();
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			btnSave.Focus();
			e.SuppressKeyPress = true;
		}
	}

	private void dgvPermissionType2_GotFocus(object sender, EventArgs e)
	{
		if (dgvPermissionType2.RowCount > 0)
		{
			dgvPermissionType2.CurrentRow.Selected = true;
		}
	}

	private void dgvPermissionType2_LostFocus(object sender, EventArgs e)
	{
		if (dgvPermissionType2.RowCount > 0)
		{
			dgvPermissionType2.CurrentRow.Selected = false;
		}
	}

	private void dgvCashAccount_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			e.SuppressKeyPress = true;
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			TabControl1.Focus();
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			btnSave.Focus();
			e.SuppressKeyPress = true;
		}
	}

	private void dgvBankAccount_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			e.SuppressKeyPress = true;
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			TabControl1.Focus();
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			btnSave.Focus();
			e.SuppressKeyPress = true;
		}
	}

	private void dgvStorage_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			e.SuppressKeyPress = true;
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			TabControl1.Focus();
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			btnSave.Focus();
			e.SuppressKeyPress = true;
		}
	}

	private void dgvBranch_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			e.SuppressKeyPress = true;
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			TabControl1.Focus();
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			btnSave.Focus();
			e.SuppressKeyPress = true;
		}
	}

	private void dgvCashAccount_GotFocus(object sender, EventArgs e)
	{
		if (dgvCashAccount.RowCount > 0)
		{
			dgvCashAccount.CurrentRow.Selected = true;
		}
	}

	private void dgvCashAccount_LostFocus(object sender, EventArgs e)
	{
		if (dgvCashAccount.RowCount > 0)
		{
			dgvCashAccount.CurrentRow.Selected = false;
		}
	}

	private void dgvBankAccount_GotFocus(object sender, EventArgs e)
	{
		if (dgvBankAccount.RowCount > 0)
		{
			dgvBankAccount.CurrentRow.Selected = true;
		}
	}

	private void dgvBankAccount_LostFocus(object sender, EventArgs e)
	{
		if (dgvBankAccount.RowCount > 0)
		{
			dgvBankAccount.CurrentRow.Selected = false;
		}
	}

	private void dgvStorage_GotFocus(object sender, EventArgs e)
	{
		if (dgvStorage.RowCount > 0)
		{
			dgvStorage.CurrentRow.Selected = true;
		}
	}

	private void dgvStorage_LostFocus(object sender, EventArgs e)
	{
		if (dgvStorage.RowCount > 0)
		{
			dgvStorage.CurrentRow.Selected = false;
		}
	}

	private void dgvBranch_GotFocus(object sender, EventArgs e)
	{
		if (dgvBranch.RowCount > 0)
		{
			dgvBranch.CurrentRow.Selected = true;
		}
	}

	private void dgvBranch_LostFocus(object sender, EventArgs e)
	{
		if (dgvBranch.RowCount > 0)
		{
			dgvBranch.CurrentRow.Selected = false;
		}
	}

	private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (TabControl1.SelectedIndex == 1)
		{
			if (dgvPermissionType1.Rows.Count > 0)
			{
				dgvPermissionType1.CurrentRow.Selected = false;
			}
		}
		else if (TabControl1.SelectedIndex == 2)
		{
			if (dgvPermissionType2.Rows.Count > 0)
			{
				dgvPermissionType2.CurrentRow.Selected = false;
			}
		}
		else if (TabControl1.SelectedIndex == 5)
		{
			if (dgvCashAccount.Rows.Count > 0)
			{
				dgvCashAccount.CurrentRow.Selected = false;
			}
		}
		else if (TabControl1.SelectedIndex == 6)
		{
			if (dgvBankAccount.Rows.Count > 0)
			{
				dgvBankAccount.CurrentRow.Selected = false;
			}
		}
		else if (TabControl1.SelectedIndex == 7)
		{
			if (dgvStorage.Rows.Count > 0)
			{
				dgvStorage.CurrentRow.Selected = false;
			}
		}
		else if (TabControl1.SelectedIndex == 8 && dgvBranch.Rows.Count > 0)
		{
			dgvBranch.CurrentRow.Selected = false;
		}
	}

	private void cboGroup_SelectedIndexChanged(object sender, EventArgs e)
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
						cComboItem cComboItem2 = (cComboItem)cboGroup.SelectedItem;
						cGroup cGroup2 = new cGroup(Conversions.ToInteger(cComboItem2.Value));
						lblUserName.Text = "Anggota: ";
						int i;
						if (!Information.IsNothing(cGroup2.UserName))
						{
							int num3 = cGroup2.UserName.Count() - 1;
							for (i = 0; i <= num3; i++)
							{
								if (i > 0)
								{
									lblUserName.Text += ", ";
								}
								lblUserName.Text += cGroup2.UserName[i];
							}
						}
						int num4 = clbPage.Items.Count - 1;
						for (i = 0; i <= num4; i++)
						{
							clbPage.SetItemChecked(i, value: false);
						}
						if (!Information.IsNothing(cGroup2.PageId))
						{
							int num5 = clbPage.Items.Count - 1;
							for (i = 0; i <= num5; i++)
							{
								cPage cPage2 = (cPage)clbPage.Items[i];
								if (Array.IndexOf(cGroup2.PageId, cPage2.Id) != -1)
								{
									clbPage.SetItemChecked(i, value: true);
								}
							}
						}
						DataGridView Dgv = dgvPermissionType1;
						Module1.UncheckDataGridView(ref Dgv, 1);
						dgvPermissionType1 = Dgv;
						if (!Information.IsNothing(cGroup2.PermissionType1))
						{
							int num6 = dgvPermissionType1.Rows.Count - 1;
							for (i = 0; i <= num6; i++)
							{
								int value = Conversions.ToInteger(dgvPermissionType1[0, i].Value);
								if (Array.IndexOf(cGroup2.PermissionType1, value) != -1)
								{
									dgvPermissionType1[1, i].Value = true;
								}
							}
						}
						dgvPermissionType2.Rows.Clear();
						i = 0;
						cGroupPermission[] permission = cGroup2.Permission;
						foreach (cGroupPermission cGroupPermission2 in permission)
						{
							dgvPermissionType2.Rows.Add(cGroupPermission2.Id, cGroupPermission2.Description, cGroupPermission2.PermissionValue);
						}
						int num7 = clbSupplier.Items.Count - 1;
						for (i = 0; i <= num7; i++)
						{
							clbSupplier.SetItemChecked(i, value: false);
						}
						if (!Information.IsNothing(cGroup2.SupplierId))
						{
							int num8 = clbSupplier.Items.Count - 1;
							for (i = 0; i <= num8; i++)
							{
								cSupplier cSupplier2 = (cSupplier)clbSupplier.Items[i];
								if (Array.IndexOf(cGroup2.SupplierId, cSupplier2.Id) != -1)
								{
									clbSupplier.SetItemChecked(i, value: true);
								}
							}
						}
						int num9 = clbItemCategory.Items.Count - 1;
						for (i = 0; i <= num9; i++)
						{
							clbItemCategory.SetItemChecked(i, value: false);
						}
						if (!Information.IsNothing(cGroup2.CatId))
						{
							int num10 = clbItemCategory.Items.Count - 1;
							for (i = 0; i <= num10; i++)
							{
								cItemCategory cItemCategory2 = (cItemCategory)clbItemCategory.Items[i];
								if (Array.IndexOf(cGroup2.CatId, cItemCategory2.Id) != -1)
								{
									clbItemCategory.SetItemChecked(i, value: true);
								}
							}
						}
						dgvCashAccount.Rows.Clear();
						i = 0;
						cGroupCashAccount[] groupCashAccount = cGroup2.GroupCashAccount;
						foreach (cGroupCashAccount cGroupCashAccount2 in groupCashAccount)
						{
							dgvCashAccount.Rows.Add(cGroupCashAccount2.CashAccountId, cGroupCashAccount2.CashAccountName, Interaction.IIf(cGroupCashAccount2.GeneralDropDown == 0, TriState.False, TriState.True), Interaction.IIf(cGroupCashAccount2.DefaultDropDown == 0, TriState.False, TriState.True), Interaction.IIf(cGroupCashAccount2.TransactionDropDown == 0, TriState.False, TriState.True), Interaction.IIf(cGroupCashAccount2.ShowBalance == 0, TriState.False, TriState.True));
							if (Operators.ConditionalCompareObjectEqual(dgvCashAccount[2, i].Value, 0, TextCompare: false))
							{
								dgvCashAccount[3, i].ReadOnly = true;
								dgvCashAccount[4, i].ReadOnly = true;
								dgvCashAccount[5, i].ReadOnly = true;
							}
							else
							{
								dgvCashAccount[3, i].ReadOnly = false;
								dgvCashAccount[4, i].ReadOnly = false;
								dgvCashAccount[5, i].ReadOnly = false;
							}
							if (Operators.ConditionalCompareObjectEqual(dgvCashAccount[4, i].Value, 0, TextCompare: false))
							{
								dgvCashAccount[5, i].ReadOnly = true;
							}
							else
							{
								dgvCashAccount[5, i].ReadOnly = false;
							}
							i++;
						}
						dgvBankAccount.Rows.Clear();
						i = 0;
						cGroupBankAccount[] groupBankAccount = cGroup2.GroupBankAccount;
						foreach (cGroupBankAccount cGroupBankAccount2 in groupBankAccount)
						{
							dgvBankAccount.Rows.Add(cGroupBankAccount2.BankAccountId, cGroupBankAccount2.BankAccountName, Interaction.IIf(cGroupBankAccount2.GeneralDropDown == 0, TriState.False, TriState.True), Interaction.IIf(cGroupBankAccount2.DefaultDropDown == 0, TriState.False, TriState.True), Interaction.IIf(cGroupBankAccount2.TransactionDropDown == 0, TriState.False, TriState.True), Interaction.IIf(cGroupBankAccount2.ShowBalance == 0, TriState.False, TriState.True));
							if (Operators.ConditionalCompareObjectEqual(dgvBankAccount[2, i].Value, 0, TextCompare: false))
							{
								dgvBankAccount[3, i].ReadOnly = true;
								dgvBankAccount[4, i].ReadOnly = true;
								dgvBankAccount[5, i].ReadOnly = true;
							}
							else
							{
								dgvBankAccount[3, i].ReadOnly = false;
								dgvBankAccount[4, i].ReadOnly = false;
								dgvBankAccount[5, i].ReadOnly = false;
							}
							if (Operators.ConditionalCompareObjectEqual(dgvBankAccount[4, i].Value, 0, TextCompare: false))
							{
								dgvBankAccount[5, i].ReadOnly = true;
							}
							else
							{
								dgvBankAccount[5, i].ReadOnly = false;
							}
							i++;
						}
						dgvStorage.Rows.Clear();
						i = 0;
						cGroupStorage[] groupStorage = cGroup2.GroupStorage;
						foreach (cGroupStorage cGroupStorage2 in groupStorage)
						{
							dgvStorage.Rows.Add(cGroupStorage2.StorageId, cGroupStorage2.StorageName, Interaction.IIf(cGroupStorage2.GeneralDropDown == 0, TriState.False, TriState.True), Interaction.IIf(cGroupStorage2.DefaultDropDown == 0, TriState.False, TriState.True));
							if (Operators.ConditionalCompareObjectEqual(dgvStorage[2, i].Value, 0, TextCompare: false))
							{
								dgvStorage[3, i].ReadOnly = true;
							}
							else
							{
								dgvStorage[3, i].ReadOnly = false;
							}
							i++;
						}
						dgvBranch.Rows.Clear();
						i = 0;
						cGroupBranch[] groupBranch = cGroup2.GroupBranch;
						foreach (cGroupBranch cGroupBranch2 in groupBranch)
						{
							dgvBranch.Rows.Add(cGroupBranch2.BranchId, cGroupBranch2.BranchName, Interaction.IIf(cGroupBranch2.GeneralDropDown == 0, TriState.False, TriState.True), Interaction.IIf(cGroupBranch2.DefaultDropDown == 0, TriState.False, TriState.True));
							if (Operators.ConditionalCompareObjectEqual(dgvBranch[2, i].Value, 0, TextCompare: false))
							{
								dgvBranch[3, i].ReadOnly = true;
							}
							else
							{
								dgvBranch[3, i].ReadOnly = false;
							}
							i++;
						}
						goto end_IL_0001;
					}
					case 2580:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmSettingGroup", "cboGroup_SelectedIndexChanged", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 2580;
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
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		bool flag4 = default(bool);
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
						cComboItem cComboItem2 = (cComboItem)cboGroup.SelectedItem;
						if (cboGroup.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih group", MsgBoxStyle.Information);
							goto end_IL_0001;
						}
						int num3 = dgvCashAccount.Rows.Count - 1;
						for (int i = 0; i <= num3; i++)
						{
							if (Operators.ConditionalCompareObjectEqual(dgvCashAccount[3, i].Value, true, TextCompare: false))
							{
								flag = true;
								break;
							}
						}
						int num4 = dgvBankAccount.Rows.Count - 1;
						for (int i = 0; i <= num4; i++)
						{
							if (Operators.ConditionalCompareObjectEqual(dgvBankAccount[3, i].Value, true, TextCompare: false))
							{
								flag2 = true;
								break;
							}
						}
						int num5 = dgvStorage.Rows.Count - 1;
						for (int i = 0; i <= num5; i++)
						{
							if (Operators.ConditionalCompareObjectEqual(dgvStorage[3, i].Value, true, TextCompare: false))
							{
								flag3 = true;
								break;
							}
						}
						int num6 = dgvBranch.Rows.Count - 1;
						for (int i = 0; i <= num6; i++)
						{
							if (Operators.ConditionalCompareObjectEqual(dgvBranch[3, i].Value, true, TextCompare: false))
							{
								flag4 = true;
								break;
							}
						}
						if (!flag)
						{
							Interaction.MsgBox("Pilih default Kas", MsgBoxStyle.Information);
							goto end_IL_0001;
						}
						if (!flag2)
						{
							Interaction.MsgBox("Pilih default Rekening", MsgBoxStyle.Information);
							goto end_IL_0001;
						}
						if (!flag3)
						{
							Interaction.MsgBox("Pilih default Gudang", MsgBoxStyle.Information);
							goto end_IL_0001;
						}
						if (!flag4)
						{
							Interaction.MsgBox("Pilih default Cabang", MsgBoxStyle.Information);
							goto end_IL_0001;
						}
						Cursor = Cursors.WaitCursor;
						cGroup cGroup2 = new cGroup(0);
						int[] array = new int[clbPage.CheckedItems.Count - 1 + 1];
						int num7 = clbPage.CheckedItems.Count - 1;
						for (int i = 0; i <= num7; i++)
						{
							cPage cPage2 = (cPage)clbPage.CheckedItems[i];
							array[i] = cPage2.Id;
						}
						int num8 = 0;
						int[] array2 = new int[0];
						int num9 = dgvPermissionType1.Rows.Count - 1;
						for (int i = 0; i <= num9; i++)
						{
							if (Operators.ConditionalCompareObjectEqual(dgvPermissionType1[1, i].Value, true, TextCompare: false))
							{
								array2 = (int[])Utils.CopyArray(array2, new int[num8 + 1]);
								array2[num8] = Conversions.ToInteger(dgvPermissionType1[0, i].Value);
								num8++;
							}
						}
						int[] array3 = new int[clbSupplier.CheckedItems.Count - 1 + 1];
						int num10 = clbSupplier.CheckedItems.Count - 1;
						for (int i = 0; i <= num10; i++)
						{
							cSupplier cSupplier2 = (cSupplier)clbSupplier.CheckedItems[i];
							array3[i] = cSupplier2.Id;
						}
						int[] array4 = new int[clbItemCategory.CheckedItems.Count - 1 + 1];
						int num11 = clbItemCategory.CheckedItems.Count - 1;
						for (int i = 0; i <= num11; i++)
						{
							cItemCategory cItemCategory2 = (cItemCategory)clbItemCategory.CheckedItems[i];
							array4[i] = cItemCategory2.Id;
						}
						cGroup2.Id = cComboItem2.Value;
						cGroup2.PageId = array;
						cGroup2.PermissionType1 = array2;
						cGroup2.SupplierId = array3;
						cGroup2.CatId = array4;
						cGroupPermission[] array5 = null;
						int num12 = dgvPermissionType2.Rows.Count - 1;
						for (int i = 0; i <= num12; i++)
						{
							array5 = (cGroupPermission[])Utils.CopyArray(array5, new cGroupPermission[i + 1]);
							array5[i] = new cGroupPermission();
							array5[i].Id = Conversions.ToInteger(dgvPermissionType2[0, i].Value);
							array5[i].PermissionValue = Conversions.ToInteger(dgvPermissionType2[2, i].Value);
						}
						cGroup2.Permission = array5;
						cGroupCashAccount[] array6 = null;
						int num13 = dgvCashAccount.Rows.Count - 1;
						for (int i = 0; i <= num13; i++)
						{
							array6 = (cGroupCashAccount[])Utils.CopyArray(array6, new cGroupCashAccount[i + 1]);
							array6[i] = new cGroupCashAccount();
							array6[i].CashAccountId = Conversions.ToInteger(dgvCashAccount[0, i].Value);
							array6[i].GeneralDropDown = Conversions.ToInteger(Interaction.IIf(Operators.ConditionalCompareObjectEqual(dgvCashAccount[2, i].Value, TriState.False, TextCompare: false), 0, 1));
							array6[i].DefaultDropDown = Conversions.ToInteger(Interaction.IIf(Operators.ConditionalCompareObjectEqual(dgvCashAccount[3, i].Value, TriState.False, TextCompare: false), 0, 1));
							array6[i].TransactionDropDown = Conversions.ToInteger(Interaction.IIf(Operators.ConditionalCompareObjectEqual(dgvCashAccount[4, i].Value, TriState.False, TextCompare: false), 0, 1));
							array6[i].ShowBalance = Conversions.ToInteger(Interaction.IIf(Operators.ConditionalCompareObjectEqual(dgvCashAccount[5, i].Value, TriState.False, TextCompare: false), 0, 1));
						}
						cGroup2.GroupCashAccount = array6;
						cGroupBankAccount[] array7 = null;
						int num14 = dgvBankAccount.Rows.Count - 1;
						for (int i = 0; i <= num14; i++)
						{
							array7 = (cGroupBankAccount[])Utils.CopyArray(array7, new cGroupBankAccount[i + 1]);
							array7[i] = new cGroupBankAccount();
							array7[i].BankAccountId = Conversions.ToInteger(dgvBankAccount[0, i].Value);
							array7[i].GeneralDropDown = Conversions.ToInteger(Interaction.IIf(Operators.ConditionalCompareObjectEqual(dgvBankAccount[2, i].Value, TriState.False, TextCompare: false), 0, 1));
							array7[i].DefaultDropDown = Conversions.ToInteger(Interaction.IIf(Operators.ConditionalCompareObjectEqual(dgvBankAccount[3, i].Value, TriState.False, TextCompare: false), 0, 1));
							array7[i].TransactionDropDown = Conversions.ToInteger(Interaction.IIf(Operators.ConditionalCompareObjectEqual(dgvBankAccount[4, i].Value, TriState.False, TextCompare: false), 0, 1));
							array7[i].ShowBalance = Conversions.ToInteger(Interaction.IIf(Operators.ConditionalCompareObjectEqual(dgvBankAccount[5, i].Value, TriState.False, TextCompare: false), 0, 1));
						}
						cGroup2.GroupBankAccount = array7;
						cGroupStorage[] array8 = null;
						int num15 = dgvStorage.Rows.Count - 1;
						for (int i = 0; i <= num15; i++)
						{
							array8 = (cGroupStorage[])Utils.CopyArray(array8, new cGroupStorage[i + 1]);
							array8[i] = new cGroupStorage();
							array8[i].StorageId = Conversions.ToInteger(dgvStorage[0, i].Value);
							array8[i].GeneralDropDown = Conversions.ToInteger(Interaction.IIf(Operators.ConditionalCompareObjectEqual(dgvStorage[2, i].Value, TriState.False, TextCompare: false), 0, 1));
							array8[i].DefaultDropDown = Conversions.ToInteger(Interaction.IIf(Operators.ConditionalCompareObjectEqual(dgvStorage[3, i].Value, TriState.False, TextCompare: false), 0, 1));
						}
						cGroup2.GroupStorage = array8;
						cGroupBranch[] array9 = null;
						int num16 = dgvBranch.Rows.Count - 1;
						for (int i = 0; i <= num16; i++)
						{
							array9 = (cGroupBranch[])Utils.CopyArray(array9, new cGroupBranch[i + 1]);
							array9[i] = new cGroupBranch();
							array9[i].BranchId = Conversions.ToInteger(dgvBranch[0, i].Value);
							array9[i].GeneralDropDown = Conversions.ToInteger(Interaction.IIf(Operators.ConditionalCompareObjectEqual(dgvBranch[2, i].Value, TriState.False, TextCompare: false), 0, 1));
							array9[i].DefaultDropDown = Conversions.ToInteger(Interaction.IIf(Operators.ConditionalCompareObjectEqual(dgvBranch[3, i].Value, TriState.False, TextCompare: false), 0, 1));
						}
						cGroup2.GroupBranch = array9;
						cGroup2.Save();
						Cursor = Cursors.Default;
						Interaction.MsgBox("Hak Grup berhasil disimpan. \r\nUser dari grup yang bersangkutan harus login ulang untuk mengaktifkan setting.", MsgBoxStyle.Information);
						goto end_IL_0001;
					}
					case 2521:
						num = -1;
						switch (num2)
						{
						case 2:
							Cursor = Cursors.Default;
							Module1.SaveError(Information.Err(), "frmSettingGroup", "btnSave_click", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 2521;
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

	private void dgvCashAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
						ProjectData.ClearProjectError();
						num2 = 2;
						dgvCashAccount.EndEdit();
						if (e.ColumnIndex == 2)
						{
							if (Operators.ConditionalCompareObjectEqual(dgvCashAccount[2, dgvCashAccount.CurrentRow.Index].Value, false, TextCompare: false))
							{
								dgvCashAccount[3, dgvCashAccount.CurrentRow.Index].Value = false;
								dgvCashAccount[4, dgvCashAccount.CurrentRow.Index].Value = false;
								dgvCashAccount[5, dgvCashAccount.CurrentRow.Index].Value = false;
								dgvCashAccount[3, dgvCashAccount.CurrentRow.Index].ReadOnly = true;
								dgvCashAccount[4, dgvCashAccount.CurrentRow.Index].ReadOnly = true;
								dgvCashAccount[5, dgvCashAccount.CurrentRow.Index].ReadOnly = true;
							}
							else
							{
								dgvCashAccount[3, dgvCashAccount.CurrentRow.Index].ReadOnly = false;
								dgvCashAccount[4, dgvCashAccount.CurrentRow.Index].ReadOnly = false;
							}
						}
						if (e.ColumnIndex == 3 && Conversions.ToBoolean(Operators.AndObject(!dgvCashAccount[3, dgvCashAccount.CurrentRow.Index].ReadOnly, Operators.CompareObjectEqual(dgvCashAccount[3, dgvCashAccount.CurrentRow.Index].Value, true, TextCompare: false))))
						{
							int num3 = dgvCashAccount.Rows.Count - 1;
							for (int i = 0; i <= num3; i++)
							{
								if (i != dgvCashAccount.CurrentRow.Index)
								{
									dgvCashAccount[3, i].Value = false;
								}
							}
						}
						if (e.ColumnIndex == 4)
						{
							if (Operators.ConditionalCompareObjectEqual(dgvCashAccount[4, dgvCashAccount.CurrentRow.Index].Value, false, TextCompare: false))
							{
								dgvCashAccount[5, dgvCashAccount.CurrentRow.Index].Value = false;
								dgvCashAccount[5, dgvCashAccount.CurrentRow.Index].ReadOnly = true;
							}
							else
							{
								dgvCashAccount[5, dgvCashAccount.CurrentRow.Index].ReadOnly = false;
							}
						}
						goto end_IL_0001;
					case 823:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmSettingGroup", "dgvCashAccount_CellContentClick", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 823;
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

	private void dgvBankAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
						ProjectData.ClearProjectError();
						num2 = 2;
						dgvBankAccount.EndEdit();
						if (e.ColumnIndex == 2)
						{
							if (Operators.ConditionalCompareObjectEqual(dgvBankAccount[2, dgvBankAccount.CurrentRow.Index].Value, false, TextCompare: false))
							{
								dgvBankAccount[3, dgvBankAccount.CurrentRow.Index].Value = false;
								dgvBankAccount[4, dgvBankAccount.CurrentRow.Index].Value = false;
								dgvBankAccount[5, dgvBankAccount.CurrentRow.Index].Value = false;
								dgvBankAccount[3, dgvBankAccount.CurrentRow.Index].ReadOnly = true;
								dgvBankAccount[4, dgvBankAccount.CurrentRow.Index].ReadOnly = true;
								dgvBankAccount[5, dgvBankAccount.CurrentRow.Index].ReadOnly = true;
							}
							else
							{
								dgvBankAccount[3, dgvBankAccount.CurrentRow.Index].ReadOnly = false;
								dgvBankAccount[4, dgvBankAccount.CurrentRow.Index].ReadOnly = false;
							}
						}
						if (e.ColumnIndex == 3 && Conversions.ToBoolean(Operators.AndObject(!dgvBankAccount[3, dgvBankAccount.CurrentRow.Index].ReadOnly, Operators.CompareObjectEqual(dgvBankAccount[3, dgvBankAccount.CurrentRow.Index].Value, true, TextCompare: false))))
						{
							int num3 = dgvBankAccount.Rows.Count - 1;
							for (int i = 0; i <= num3; i++)
							{
								if (i != dgvBankAccount.CurrentRow.Index)
								{
									dgvBankAccount[3, i].Value = false;
								}
							}
						}
						if (e.ColumnIndex == 4)
						{
							if (Operators.ConditionalCompareObjectEqual(dgvBankAccount[4, dgvBankAccount.CurrentRow.Index].Value, false, TextCompare: false))
							{
								dgvBankAccount[5, dgvBankAccount.CurrentRow.Index].Value = false;
								dgvBankAccount[5, dgvBankAccount.CurrentRow.Index].ReadOnly = true;
							}
							else
							{
								dgvBankAccount[5, dgvBankAccount.CurrentRow.Index].ReadOnly = false;
							}
						}
						goto end_IL_0001;
					case 823:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmSettingGroup", "dgvBankAccount_CellContentClick", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 823;
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

	private void dgvStorage_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
						dgvStorage.EndEdit();
						if (e.ColumnIndex == 2)
						{
							if (Operators.ConditionalCompareObjectEqual(dgvStorage[2, dgvStorage.CurrentRow.Index].Value, false, TextCompare: false))
							{
								dgvStorage[3, dgvStorage.CurrentRow.Index].Value = false;
								dgvStorage[3, dgvStorage.CurrentRow.Index].ReadOnly = true;
							}
							else
							{
								dgvStorage[3, dgvStorage.CurrentRow.Index].ReadOnly = false;
							}
						}
						if (e.ColumnIndex != 3 || !Conversions.ToBoolean(Operators.AndObject(!dgvStorage[3, dgvStorage.CurrentRow.Index].ReadOnly, Operators.CompareObjectEqual(dgvStorage[3, dgvStorage.CurrentRow.Index].Value, true, TextCompare: false))))
						{
							goto end_IL_0001;
						}
						int num3 = dgvStorage.Rows.Count - 1;
						for (int i = 0; i <= num3; i++)
						{
							if (i != dgvStorage.CurrentRow.Index)
							{
								dgvStorage[3, i].Value = false;
							}
						}
						goto end_IL_0001;
					}
					case 449:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmSettingGroup", "dgvStorage_CellContentClick", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 449;
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

	private void dgvBranch_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
						dgvBranch.EndEdit();
						if (e.ColumnIndex == 2)
						{
							if (Operators.ConditionalCompareObjectEqual(dgvBranch[2, dgvBranch.CurrentRow.Index].Value, false, TextCompare: false))
							{
								dgvBranch[3, dgvBranch.CurrentRow.Index].Value = false;
								dgvBranch[3, dgvBranch.CurrentRow.Index].ReadOnly = true;
							}
							else
							{
								dgvBranch[3, dgvBranch.CurrentRow.Index].ReadOnly = false;
							}
						}
						if (e.ColumnIndex != 3 || !Conversions.ToBoolean(Operators.AndObject(!dgvBranch[3, dgvBranch.CurrentRow.Index].ReadOnly, Operators.CompareObjectEqual(dgvBranch[3, dgvBranch.CurrentRow.Index].Value, true, TextCompare: false))))
						{
							goto end_IL_0001;
						}
						int num3 = dgvBranch.Rows.Count - 1;
						for (int i = 0; i <= num3; i++)
						{
							if (i != dgvBranch.CurrentRow.Index)
							{
								dgvBranch[3, i].Value = false;
							}
						}
						goto end_IL_0001;
					}
					case 449:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmSettingGroup", "dgvBranch_CellContentClick", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 449;
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

	private void tsbDelete_Click(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboGroup.SelectedItem;
		if (cboGroup.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih group", MsgBoxStyle.Information);
		}
		else if (cGroup.HasUser(Conversions.ToInteger(cComboItem2.Value)))
		{
			Interaction.MsgBox("Grup tidak dapat dihapus karena ada user yang terkait dengan grup ini.", MsgBoxStyle.Information);
		}
		else if (MessageBox.Show("Hapus Grup " + cboGroup.Text + "?", "Konfirmasi", MessageBoxButtons.YesNo) != DialogResult.No)
		{
			cGroup.Delete(Conversions.ToInteger(cComboItem2.Value));
			Interaction.MsgBox("Grup berhasil dihapus.", MsgBoxStyle.Information);
			ComboBox combo = cboGroup;
			cCombo.getGroup(ref combo);
			cboGroup = combo;
			cboGroup.SelectedIndex = 0;
		}
	}

	private void tsbNew_Click(object sender, EventArgs e)
	{
		MyProject.Forms.frmSettingGroupInput.ShowDialog();
		MyProject.Forms.frmSettingGroupInput.Close();
		MyProject.Forms.frmSettingGroupInput.Dispose();
	}
}
