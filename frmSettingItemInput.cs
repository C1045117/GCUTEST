using System;
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
public class frmSettingItemInput : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSave")]
	private Button _btnSave;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TabControl1")]
	private TabControl _TabControl1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvStandardComponent")]
	private DataGridView _dgvStandardComponent;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboStep")]
	private ComboBox _cboStep;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("chkAllowProcess")]
	private CheckBox _chkAllowProcess;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvSupplier")]
	private DataGridView _dgvSupplier;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboItemType")]
	private ComboBox _cboItemType;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvDropDownComponent")]
	private DataGridView _dgvDropDownComponent;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnStandard")]
	private Button _btnStandard;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSupplier")]
	private Button _btnSupplier;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvStorage")]
	private DataGridView _dgvStorage;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("txtUnitName1")]
	private TextBox _txtUnitName1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnStandardUsage")]
	private Button _btnStandardUsage;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvStandardUsage")]
	private DataGridView _dgvStandardUsage;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnItemGroup")]
	private Button _btnItemGroup;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvItemGroup")]
	private DataGridView _dgvItemGroup;

	private int _currentId;

	private bool _blnDecimal;

	private bool _dontFocus;

	private bool _finishLoading;

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

	[field: AccessedThroughProperty("cboActive")]
	internal virtual ComboBox cboActive
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

	[field: AccessedThroughProperty("chkFlower")]
	internal virtual CheckBox chkFlower
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkAllowComponent")]
	internal virtual CheckBox chkAllowComponent
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboItemCategory")]
	internal virtual ComboBox cboItemCategory
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

	[field: AccessedThroughProperty("txtName")]
	internal virtual TextBox txtName
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

	[field: AccessedThroughProperty("TabPage2")]
	internal virtual TabPage TabPage2
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

	internal virtual DataGridView dgvStandardComponent
	{
		[CompilerGenerated]
		get
		{
			return _dgvStandardComponent;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = dgvStandardComponent_DoubleClick;
			KeyEventHandler value3 = dgvStandardComponent_KeyDown;
			DataGridView dataGridView = _dgvStandardComponent;
			if (dataGridView != null)
			{
				dataGridView.DoubleClick -= value2;
				dataGridView.KeyDown -= value3;
			}
			_dgvStandardComponent = value;
			dataGridView = _dgvStandardComponent;
			if (dataGridView != null)
			{
				dataGridView.DoubleClick += value2;
				dataGridView.KeyDown += value3;
			}
		}
	}

	internal virtual ComboBox cboStep
	{
		[CompilerGenerated]
		get
		{
			return _cboStep;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cboStep_SelectedIndexChanged;
			ComboBox comboBox = _cboStep;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_cboStep = value;
			comboBox = _cboStep;
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

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual CheckBox chkAllowProcess
	{
		[CompilerGenerated]
		get
		{
			return _chkAllowProcess;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = chkAllowProcess_CheckedChanged;
			CheckBox checkBox = _chkAllowProcess;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value2;
			}
			_chkAllowProcess = value;
			checkBox = _chkAllowProcess;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TabPage3")]
	internal virtual TabPage TabPage3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkAllowPurchase")]
	internal virtual CheckBox chkAllowPurchase
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblSupplier")]
	internal virtual Label lblSupplier
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView dgvSupplier
	{
		[CompilerGenerated]
		get
		{
			return _dgvSupplier;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = dgvSupplier_GotFocus;
			EventHandler value3 = dgvSupplier_LostFocus;
			EventHandler value4 = dgvSupplier_DoubleClick;
			KeyEventHandler value5 = dgvSupplier_KeyDown;
			DataGridView dataGridView = _dgvSupplier;
			if (dataGridView != null)
			{
				dataGridView.GotFocus -= value2;
				dataGridView.LostFocus -= value3;
				dataGridView.DoubleClick -= value4;
				dataGridView.KeyDown -= value5;
			}
			_dgvSupplier = value;
			dataGridView = _dgvSupplier;
			if (dataGridView != null)
			{
				dataGridView.GotFocus += value2;
				dataGridView.LostFocus += value3;
				dataGridView.DoubleClick += value4;
				dataGridView.KeyDown += value5;
			}
		}
	}

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox cboItemType
	{
		[CompilerGenerated]
		get
		{
			return _cboItemType;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cboItemType_SelectedIndexChanged;
			ComboBox comboBox = _cboItemType;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_cboItemType = value;
			comboBox = _cboItemType;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView dgvDropDownComponent
	{
		[CompilerGenerated]
		get
		{
			return _dgvDropDownComponent;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellEventHandler value2 = dgvDropDownComponent_CellContentClick;
			DataGridViewCellEventHandler value3 = dgvDropDownComponent_CellContentDoubleClick;
			KeyEventHandler value4 = dgvDropDownComponent_KeyDown;
			EventHandler value5 = dgvDropDownComponent_GotFocus;
			EventHandler value6 = dgvDropDownComponent_LostFocus;
			DataGridView dataGridView = _dgvDropDownComponent;
			if (dataGridView != null)
			{
				dataGridView.CellContentClick -= value2;
				dataGridView.CellDoubleClick -= value3;
				dataGridView.KeyDown -= value4;
				dataGridView.GotFocus -= value5;
				dataGridView.LostFocus -= value6;
			}
			_dgvDropDownComponent = value;
			dataGridView = _dgvDropDownComponent;
			if (dataGridView != null)
			{
				dataGridView.CellContentClick += value2;
				dataGridView.CellDoubleClick += value3;
				dataGridView.KeyDown += value4;
				dataGridView.GotFocus += value5;
				dataGridView.LostFocus += value6;
			}
		}
	}

	internal virtual Button btnStandard
	{
		[CompilerGenerated]
		get
		{
			return _btnStandard;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnStandard_Click;
			Button button = _btnStandard;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnStandard = value;
			button = _btnStandard;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button btnSupplier
	{
		[CompilerGenerated]
		get
		{
			return _btnSupplier;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnSupplier_Click;
			Button button = _btnSupplier;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnSupplier = value;
			button = _btnSupplier;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
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

	[field: AccessedThroughProperty("txtLongName")]
	internal virtual TextBox txtLongName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label12")]
	internal virtual Label Label12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkTehGopek")]
	internal virtual CheckBox chkTehGopek
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkAllowSell")]
	internal virtual CheckBox chkAllowSell
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkAllowEditStockQty")]
	internal virtual CheckBox chkAllowEditStockQty
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage4")]
	internal virtual TabPage TabPage4
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
			DataGridViewCellEventHandler value2 = dgvStorage_CellEnter;
			DataGridViewCellEventHandler value3 = dgvStorage_CellEndEdit;
			DataGridViewCellValidatingEventHandler value4 = dgvStorage_CellValidating;
			EventHandler value5 = dgvStorage_GotFocus;
			EventHandler value6 = dgvStorage_LostFocus;
			KeyEventHandler value7 = dgvStorage_KeyDown;
			DataGridViewCellEventHandler value8 = dgvStorage_CellContentClick;
			DataGridViewCellEventHandler value9 = dgvStorage_CellContentDoubleClick;
			DataGridViewEditingControlShowingEventHandler value10 = dgvStorage_EditingControlShowing;
			DataGridView dataGridView = _dgvStorage;
			if (dataGridView != null)
			{
				dataGridView.CellEnter -= value2;
				dataGridView.CellEndEdit -= value3;
				dataGridView.CellValidating -= value4;
				dataGridView.GotFocus -= value5;
				dataGridView.LostFocus -= value6;
				dataGridView.KeyDown -= value7;
				dataGridView.CellContentClick -= value8;
				dataGridView.CellContentDoubleClick -= value9;
				dataGridView.EditingControlShowing -= value10;
			}
			_dgvStorage = value;
			dataGridView = _dgvStorage;
			if (dataGridView != null)
			{
				dataGridView.CellEnter += value2;
				dataGridView.CellEndEdit += value3;
				dataGridView.CellValidating += value4;
				dataGridView.GotFocus += value5;
				dataGridView.LostFocus += value6;
				dataGridView.KeyDown += value7;
				dataGridView.CellContentClick += value8;
				dataGridView.CellContentDoubleClick += value9;
				dataGridView.EditingControlShowing += value10;
			}
		}
	}

	[field: AccessedThroughProperty("txtUnitQty2")]
	internal virtual FilteredTextBox txtUnitQty2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label16")]
	internal virtual Label Label16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label15")]
	internal virtual Label Label15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtUnitQty4")]
	internal virtual FilteredTextBox txtUnitQty4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label18")]
	internal virtual Label Label18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtUnitQty3")]
	internal virtual FilteredTextBox txtUnitQty3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label17")]
	internal virtual Label Label17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label21")]
	internal virtual Label Label21
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label20")]
	internal virtual Label Label20
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label19")]
	internal virtual Label Label19
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtUnitName4")]
	internal virtual TextBox txtUnitName4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtUnitName3")]
	internal virtual TextBox txtUnitName3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtUnitName2")]
	internal virtual TextBox txtUnitName2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox txtUnitName1
	{
		[CompilerGenerated]
		get
		{
			return _txtUnitName1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = txtUnitName1_TextChanged;
			TextBox textBox = _txtUnitName1;
			if (textBox != null)
			{
				textBox.TextChanged -= value2;
			}
			_txtUnitName1 = value;
			textBox = _txtUnitName1;
			if (textBox != null)
			{
				textBox.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("lblUnitName4")]
	internal virtual Label lblUnitName4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblUnitName3")]
	internal virtual Label lblUnitName3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblUnitName2")]
	internal virtual Label lblUnitName2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label22")]
	internal virtual Label Label22
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPackaging")]
	internal virtual TextBox txtPackaging
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label13")]
	internal virtual Label Label13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label14")]
	internal virtual Label Label14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label23")]
	internal virtual Label Label23
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblStockDate")]
	internal virtual Label lblStockDate
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

	internal virtual Button btnStandardUsage
	{
		[CompilerGenerated]
		get
		{
			return _btnStandardUsage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnStandardUsage_Click;
			Button button = _btnStandardUsage;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnStandardUsage = value;
			button = _btnStandardUsage;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual DataGridView dgvStandardUsage
	{
		[CompilerGenerated]
		get
		{
			return _dgvStandardUsage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = dgvStandardComponent_GotFocus;
			EventHandler value3 = dgvStandardComponent_LostFocus;
			EventHandler value4 = dgvStandardUsage_DoubleClick;
			KeyEventHandler value5 = dgvStandardUsage_KeyDown;
			EventHandler value6 = dgvStandardUsage_GotFocus;
			EventHandler value7 = dgvStandardUsage_LostFocus;
			DataGridView dataGridView = _dgvStandardUsage;
			if (dataGridView != null)
			{
				dataGridView.GotFocus -= value2;
				dataGridView.LostFocus -= value3;
				dataGridView.DoubleClick -= value4;
				dataGridView.KeyDown -= value5;
				dataGridView.GotFocus -= value6;
				dataGridView.LostFocus -= value7;
			}
			_dgvStandardUsage = value;
			dataGridView = _dgvStandardUsage;
			if (dataGridView != null)
			{
				dataGridView.GotFocus += value2;
				dataGridView.LostFocus += value3;
				dataGridView.DoubleClick += value4;
				dataGridView.KeyDown += value5;
				dataGridView.GotFocus += value6;
				dataGridView.LostFocus += value7;
			}
		}
	}

	[field: AccessedThroughProperty("TabPage6")]
	internal virtual TabPage TabPage6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnItemGroup
	{
		[CompilerGenerated]
		get
		{
			return _btnItemGroup;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnItemGroup_Click;
			Button button = _btnItemGroup;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnItemGroup = value;
			button = _btnItemGroup;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual DataGridView dgvItemGroup
	{
		[CompilerGenerated]
		get
		{
			return _dgvItemGroup;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = dgvItemGroup_DoubleClick;
			KeyEventHandler value3 = dgvItemGroup_KeyDown;
			EventHandler value4 = dgvItemGroup_GotFocus;
			EventHandler value5 = dgvItemGroup_LostFocus;
			DataGridView dataGridView = _dgvItemGroup;
			if (dataGridView != null)
			{
				dataGridView.DoubleClick -= value2;
				dataGridView.KeyDown -= value3;
				dataGridView.GotFocus -= value4;
				dataGridView.LostFocus -= value5;
			}
			_dgvItemGroup = value;
			dataGridView = _dgvItemGroup;
			if (dataGridView != null)
			{
				dataGridView.DoubleClick += value2;
				dataGridView.KeyDown += value3;
				dataGridView.GotFocus += value4;
				dataGridView.LostFocus += value5;
			}
		}
	}

	[field: AccessedThroughProperty("TabPage7")]
	internal virtual TabPage TabPage7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboInventoryAccount")]
	internal virtual ComboBox cboInventoryAccount
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label24")]
	internal virtual Label Label24
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public string CurrentId
	{
		get
		{
			return Conversions.ToString(_currentId);
		}
		set
		{
			_currentId = Conversions.ToInteger(value);
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
		this.btnSave = new System.Windows.Forms.Button();
		this.TabControl1 = new System.Windows.Forms.TabControl();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.Label23 = new System.Windows.Forms.Label();
		this.Label14 = new System.Windows.Forms.Label();
		this.Label22 = new System.Windows.Forms.Label();
		this.lblUnitName4 = new System.Windows.Forms.Label();
		this.lblUnitName3 = new System.Windows.Forms.Label();
		this.lblUnitName2 = new System.Windows.Forms.Label();
		this.txtUnitName4 = new System.Windows.Forms.TextBox();
		this.txtUnitName3 = new System.Windows.Forms.TextBox();
		this.txtUnitName2 = new System.Windows.Forms.TextBox();
		this.txtUnitName1 = new System.Windows.Forms.TextBox();
		this.Label21 = new System.Windows.Forms.Label();
		this.Label20 = new System.Windows.Forms.Label();
		this.Label19 = new System.Windows.Forms.Label();
		this.txtUnitQty4 = new GCUv2.FilteredTextBox();
		this.Label18 = new System.Windows.Forms.Label();
		this.txtUnitQty3 = new GCUv2.FilteredTextBox();
		this.Label17 = new System.Windows.Forms.Label();
		this.txtUnitQty2 = new GCUv2.FilteredTextBox();
		this.Label16 = new System.Windows.Forms.Label();
		this.Label15 = new System.Windows.Forms.Label();
		this.chkAllowEditStockQty = new System.Windows.Forms.CheckBox();
		this.chkTehGopek = new System.Windows.Forms.CheckBox();
		this.chkAllowSell = new System.Windows.Forms.CheckBox();
		this.txtLongName = new System.Windows.Forms.TextBox();
		this.Label12 = new System.Windows.Forms.Label();
		this.txtPackaging = new System.Windows.Forms.TextBox();
		this.Label13 = new System.Windows.Forms.Label();
		this.Label10 = new System.Windows.Forms.Label();
		this.cboItemType = new System.Windows.Forms.ComboBox();
		this.Label9 = new System.Windows.Forms.Label();
		this.cboActive = new System.Windows.Forms.ComboBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.chkFlower = new System.Windows.Forms.CheckBox();
		this.chkAllowComponent = new System.Windows.Forms.CheckBox();
		this.cboItemCategory = new System.Windows.Forms.ComboBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.txtName = new System.Windows.Forms.TextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.TabPage4 = new System.Windows.Forms.TabPage();
		this.lblStockDate = new System.Windows.Forms.Label();
		this.dgvStorage = new System.Windows.Forms.DataGridView();
		this.TabPage3 = new System.Windows.Forms.TabPage();
		this.btnSupplier = new System.Windows.Forms.Button();
		this.lblSupplier = new System.Windows.Forms.Label();
		this.dgvSupplier = new System.Windows.Forms.DataGridView();
		this.Label7 = new System.Windows.Forms.Label();
		this.chkAllowPurchase = new System.Windows.Forms.CheckBox();
		this.TabPage2 = new System.Windows.Forms.TabPage();
		this.Label11 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.btnStandard = new System.Windows.Forms.Button();
		this.dgvDropDownComponent = new System.Windows.Forms.DataGridView();
		this.Label6 = new System.Windows.Forms.Label();
		this.chkAllowProcess = new System.Windows.Forms.CheckBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.dgvStandardComponent = new System.Windows.Forms.DataGridView();
		this.cboStep = new System.Windows.Forms.ComboBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.TabPage5 = new System.Windows.Forms.TabPage();
		this.btnStandardUsage = new System.Windows.Forms.Button();
		this.dgvStandardUsage = new System.Windows.Forms.DataGridView();
		this.TabPage6 = new System.Windows.Forms.TabPage();
		this.btnItemGroup = new System.Windows.Forms.Button();
		this.dgvItemGroup = new System.Windows.Forms.DataGridView();
		this.TabPage7 = new System.Windows.Forms.TabPage();
		this.cboInventoryAccount = new System.Windows.Forms.ComboBox();
		this.Label24 = new System.Windows.Forms.Label();
		this.TabControl1.SuspendLayout();
		this.TabPage1.SuspendLayout();
		this.TabPage4.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvStorage).BeginInit();
		this.TabPage3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvSupplier).BeginInit();
		this.TabPage2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvDropDownComponent).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dgvStandardComponent).BeginInit();
		this.TabPage5.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvStandardUsage).BeginInit();
		this.TabPage6.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvItemGroup).BeginInit();
		this.TabPage7.SuspendLayout();
		base.SuspendLayout();
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(503, 464);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(98, 24);
		this.btnSave.TabIndex = 15;
		this.btnSave.Text = "Simpan && Tutup";
		this.btnSave.UseVisualStyleBackColor = true;
		this.TabControl1.Controls.Add(this.TabPage1);
		this.TabControl1.Controls.Add(this.TabPage4);
		this.TabControl1.Controls.Add(this.TabPage3);
		this.TabControl1.Controls.Add(this.TabPage2);
		this.TabControl1.Controls.Add(this.TabPage5);
		this.TabControl1.Controls.Add(this.TabPage6);
		this.TabControl1.Controls.Add(this.TabPage7);
		this.TabControl1.Location = new System.Drawing.Point(12, 12);
		this.TabControl1.Name = "TabControl1";
		this.TabControl1.SelectedIndex = 0;
		this.TabControl1.Size = new System.Drawing.Size(589, 445);
		this.TabControl1.TabIndex = 30;
		this.TabPage1.Controls.Add(this.Label23);
		this.TabPage1.Controls.Add(this.Label14);
		this.TabPage1.Controls.Add(this.Label22);
		this.TabPage1.Controls.Add(this.lblUnitName4);
		this.TabPage1.Controls.Add(this.lblUnitName3);
		this.TabPage1.Controls.Add(this.lblUnitName2);
		this.TabPage1.Controls.Add(this.txtUnitName4);
		this.TabPage1.Controls.Add(this.txtUnitName3);
		this.TabPage1.Controls.Add(this.txtUnitName2);
		this.TabPage1.Controls.Add(this.txtUnitName1);
		this.TabPage1.Controls.Add(this.Label21);
		this.TabPage1.Controls.Add(this.Label20);
		this.TabPage1.Controls.Add(this.Label19);
		this.TabPage1.Controls.Add(this.txtUnitQty4);
		this.TabPage1.Controls.Add(this.Label18);
		this.TabPage1.Controls.Add(this.txtUnitQty3);
		this.TabPage1.Controls.Add(this.Label17);
		this.TabPage1.Controls.Add(this.txtUnitQty2);
		this.TabPage1.Controls.Add(this.Label16);
		this.TabPage1.Controls.Add(this.Label15);
		this.TabPage1.Controls.Add(this.chkAllowEditStockQty);
		this.TabPage1.Controls.Add(this.chkTehGopek);
		this.TabPage1.Controls.Add(this.chkAllowSell);
		this.TabPage1.Controls.Add(this.txtLongName);
		this.TabPage1.Controls.Add(this.Label12);
		this.TabPage1.Controls.Add(this.txtPackaging);
		this.TabPage1.Controls.Add(this.Label13);
		this.TabPage1.Controls.Add(this.Label10);
		this.TabPage1.Controls.Add(this.cboItemType);
		this.TabPage1.Controls.Add(this.Label9);
		this.TabPage1.Controls.Add(this.cboActive);
		this.TabPage1.Controls.Add(this.Label2);
		this.TabPage1.Controls.Add(this.chkFlower);
		this.TabPage1.Controls.Add(this.chkAllowComponent);
		this.TabPage1.Controls.Add(this.cboItemCategory);
		this.TabPage1.Controls.Add(this.Label3);
		this.TabPage1.Controls.Add(this.txtName);
		this.TabPage1.Controls.Add(this.Label1);
		this.TabPage1.Location = new System.Drawing.Point(4, 22);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage1.Size = new System.Drawing.Size(581, 419);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = "Detail";
		this.TabPage1.UseVisualStyleBackColor = true;
		this.Label23.AutoSize = true;
		this.Label23.ForeColor = System.Drawing.Color.Black;
		this.Label23.Location = new System.Drawing.Point(261, 44);
		this.Label23.Name = "Label23";
		this.Label23.Size = new System.Drawing.Size(264, 13);
		this.Label23.TabIndex = 159;
		this.Label23.Text = "(Untuk pencetakan Surat Jalan/F. Komersial/F. Pajak)";
		this.Label14.AutoSize = true;
		this.Label14.ForeColor = System.Drawing.Color.Black;
		this.Label14.Location = new System.Drawing.Point(261, 124);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(220, 13);
		this.Label14.TabIndex = 158;
		this.Label14.Text = "(Untuk pencetakan Surat Jalan/F. Komersial)";
		this.Label22.AutoSize = true;
		this.Label22.ForeColor = System.Drawing.Color.Red;
		this.Label22.Location = new System.Drawing.Point(196, 262);
		this.Label22.Name = "Label22";
		this.Label22.Size = new System.Drawing.Size(344, 13);
		this.Label22.TabIndex = 157;
		this.Label22.Text = "Jika urutan satuan dirubah, satuan di tab Pembelian juga harus dirubah.";
		this.lblUnitName4.AutoSize = true;
		this.lblUnitName4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblUnitName4.Location = new System.Drawing.Point(308, 340);
		this.lblUnitName4.Name = "lblUnitName4";
		this.lblUnitName4.Size = new System.Drawing.Size(50, 13);
		this.lblUnitName4.TabIndex = 156;
		this.lblUnitName4.Text = "Satuan 1";
		this.lblUnitName3.AutoSize = true;
		this.lblUnitName3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblUnitName3.Location = new System.Drawing.Point(308, 314);
		this.lblUnitName3.Name = "lblUnitName3";
		this.lblUnitName3.Size = new System.Drawing.Size(50, 13);
		this.lblUnitName3.TabIndex = 155;
		this.lblUnitName3.Text = "Satuan 1";
		this.lblUnitName2.AutoSize = true;
		this.lblUnitName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblUnitName2.Location = new System.Drawing.Point(308, 288);
		this.lblUnitName2.Name = "lblUnitName2";
		this.lblUnitName2.Size = new System.Drawing.Size(50, 13);
		this.lblUnitName2.TabIndex = 154;
		this.lblUnitName2.Text = "Satuan 1";
		this.txtUnitName4.Location = new System.Drawing.Point(103, 336);
		this.txtUnitName4.Name = "txtUnitName4";
		this.txtUnitName4.Size = new System.Drawing.Size(84, 20);
		this.txtUnitName4.TabIndex = 27;
		this.txtUnitName3.Location = new System.Drawing.Point(103, 310);
		this.txtUnitName3.Name = "txtUnitName3";
		this.txtUnitName3.Size = new System.Drawing.Size(84, 20);
		this.txtUnitName3.TabIndex = 25;
		this.txtUnitName2.Location = new System.Drawing.Point(103, 284);
		this.txtUnitName2.Name = "txtUnitName2";
		this.txtUnitName2.Size = new System.Drawing.Size(84, 20);
		this.txtUnitName2.TabIndex = 23;
		this.txtUnitName1.Location = new System.Drawing.Point(103, 258);
		this.txtUnitName1.Name = "txtUnitName1";
		this.txtUnitName1.Size = new System.Drawing.Size(84, 20);
		this.txtUnitName1.TabIndex = 22;
		this.Label21.AutoSize = true;
		this.Label21.Location = new System.Drawing.Point(196, 341);
		this.Label21.Name = "Label21";
		this.Label21.Size = new System.Drawing.Size(13, 13);
		this.Label21.TabIndex = 149;
		this.Label21.Text = "=";
		this.Label20.AutoSize = true;
		this.Label20.Location = new System.Drawing.Point(196, 315);
		this.Label20.Name = "Label20";
		this.Label20.Size = new System.Drawing.Size(13, 13);
		this.Label20.TabIndex = 148;
		this.Label20.Text = "=";
		this.Label19.AutoSize = true;
		this.Label19.Location = new System.Drawing.Point(196, 289);
		this.Label19.Name = "Label19";
		this.Label19.Size = new System.Drawing.Size(13, 13);
		this.Label19.TabIndex = 147;
		this.Label19.Text = "=";
		this.txtUnitQty4.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtUnitQty4.DontFormat = false;
		this.txtUnitQty4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtUnitQty4.Location = new System.Drawing.Point(215, 336);
		this.txtUnitQty4.MaximumDigit = 3;
		this.txtUnitQty4.Name = "txtUnitQty4";
		this.txtUnitQty4.Size = new System.Drawing.Size(87, 21);
		this.txtUnitQty4.TabIndex = 28;
		this.txtUnitQty4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.Label18.AutoSize = true;
		this.Label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label18.Location = new System.Drawing.Point(18, 339);
		this.Label18.Name = "Label18";
		this.Label18.Size = new System.Drawing.Size(50, 13);
		this.Label18.TabIndex = 146;
		this.Label18.Text = "Satuan 4";
		this.txtUnitQty3.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtUnitQty3.DontFormat = false;
		this.txtUnitQty3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtUnitQty3.Location = new System.Drawing.Point(215, 310);
		this.txtUnitQty3.MaximumDigit = 3;
		this.txtUnitQty3.Name = "txtUnitQty3";
		this.txtUnitQty3.Size = new System.Drawing.Size(87, 21);
		this.txtUnitQty3.TabIndex = 26;
		this.txtUnitQty3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.Label17.AutoSize = true;
		this.Label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label17.Location = new System.Drawing.Point(18, 313);
		this.Label17.Name = "Label17";
		this.Label17.Size = new System.Drawing.Size(50, 13);
		this.Label17.TabIndex = 144;
		this.Label17.Text = "Satuan 3";
		this.txtUnitQty2.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtUnitQty2.DontFormat = false;
		this.txtUnitQty2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtUnitQty2.Location = new System.Drawing.Point(215, 284);
		this.txtUnitQty2.MaximumDigit = 3;
		this.txtUnitQty2.Name = "txtUnitQty2";
		this.txtUnitQty2.Size = new System.Drawing.Size(87, 21);
		this.txtUnitQty2.TabIndex = 24;
		this.txtUnitQty2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.Label16.AutoSize = true;
		this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label16.Location = new System.Drawing.Point(18, 289);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(50, 13);
		this.Label16.TabIndex = 142;
		this.Label16.Text = "Satuan 2";
		this.Label15.AutoSize = true;
		this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label15.Location = new System.Drawing.Point(17, 262);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(63, 13);
		this.Label15.TabIndex = 140;
		this.Label15.Text = "Satuan 1 (*)";
		this.chkAllowEditStockQty.AutoSize = true;
		this.chkAllowEditStockQty.Location = new System.Drawing.Point(103, 170);
		this.chkAllowEditStockQty.Name = "chkAllowEditStockQty";
		this.chkAllowEditStockQty.Size = new System.Drawing.Size(277, 17);
		this.chkAllowEditStockQty.TabIndex = 18;
		this.chkAllowEditStockQty.Text = "Jumlah stok di surat jalan/faktur pembelian bisa diedit";
		this.chkAllowEditStockQty.UseVisualStyleBackColor = true;
		this.chkTehGopek.AutoSize = true;
		this.chkTehGopek.Location = new System.Drawing.Point(103, 239);
		this.chkTehGopek.Name = "chkTehGopek";
		this.chkTehGopek.Size = new System.Drawing.Size(402, 17);
		this.chkTehGopek.TabIndex = 21;
		this.chkTehGopek.Text = "Tambah awalan 'Teh GOPEK' saat dicetak di Surat Jalan/F. Komersial/F. Pajak";
		this.chkTehGopek.UseVisualStyleBackColor = true;
		this.chkAllowSell.AutoSize = true;
		this.chkAllowSell.Location = new System.Drawing.Point(103, 216);
		this.chkAllowSell.Name = "chkAllowSell";
		this.chkAllowSell.Size = new System.Drawing.Size(73, 17);
		this.chkAllowSell.TabIndex = 20;
		this.chkAllowSell.Text = "Bisa dijual";
		this.chkAllowSell.UseVisualStyleBackColor = true;
		this.txtLongName.Location = new System.Drawing.Point(103, 41);
		this.txtLongName.Name = "txtLongName";
		this.txtLongName.Size = new System.Drawing.Size(152, 20);
		this.txtLongName.TabIndex = 12;
		this.Label12.AutoSize = true;
		this.Label12.Location = new System.Drawing.Point(18, 44);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(77, 13);
		this.Label12.TabIndex = 50;
		this.Label12.Text = "Nama Panjang";
		this.txtPackaging.Location = new System.Drawing.Point(103, 121);
		this.txtPackaging.Name = "txtPackaging";
		this.txtPackaging.Size = new System.Drawing.Size(152, 20);
		this.txtPackaging.TabIndex = 15;
		this.Label13.AutoSize = true;
		this.Label13.Location = new System.Drawing.Point(18, 124);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(54, 13);
		this.Label13.TabIndex = 46;
		this.Label13.Text = "Kemasan ";
		this.Label10.AutoSize = true;
		this.Label10.Location = new System.Drawing.Point(18, 148);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(28, 13);
		this.Label10.TabIndex = 40;
		this.Label10.Text = "Opsi";
		this.cboItemType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboItemType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboItemType.FormattingEnabled = true;
		this.cboItemType.Location = new System.Drawing.Point(103, 67);
		this.cboItemType.Name = "cboItemType";
		this.cboItemType.Size = new System.Drawing.Size(152, 21);
		this.cboItemType.TabIndex = 12;
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(18, 70);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(41, 13);
		this.Label9.TabIndex = 39;
		this.Label9.Text = "Tipe (*)";
		this.cboActive.FormattingEnabled = true;
		this.cboActive.Location = new System.Drawing.Point(103, 362);
		this.cboActive.Name = "cboActive";
		this.cboActive.Size = new System.Drawing.Size(84, 21);
		this.cboActive.TabIndex = 29;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(18, 365);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(41, 13);
		this.Label2.TabIndex = 37;
		this.Label2.Text = "Aktif (*)";
		this.chkFlower.AutoSize = true;
		this.chkFlower.Location = new System.Drawing.Point(103, 193);
		this.chkFlower.Name = "chkFlower";
		this.chkFlower.Size = new System.Drawing.Size(262, 17);
		this.chkFlower.TabIndex = 19;
		this.chkFlower.Text = "Memiliki jumlah parkir,  potongan, harga tambahan";
		this.chkFlower.UseVisualStyleBackColor = true;
		this.chkAllowComponent.AutoSize = true;
		this.chkAllowComponent.Location = new System.Drawing.Point(103, 147);
		this.chkAllowComponent.Name = "chkAllowComponent";
		this.chkAllowComponent.Size = new System.Drawing.Size(180, 17);
		this.chkAllowComponent.TabIndex = 17;
		this.chkAllowComponent.Text = "Bisa dijadikan komponen produk";
		this.chkAllowComponent.UseVisualStyleBackColor = true;
		this.cboItemCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboItemCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboItemCategory.FormattingEnabled = true;
		this.cboItemCategory.Location = new System.Drawing.Point(103, 94);
		this.cboItemCategory.Name = "cboItemCategory";
		this.cboItemCategory.Size = new System.Drawing.Size(152, 21);
		this.cboItemCategory.TabIndex = 13;
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(18, 97);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(59, 13);
		this.Label3.TabIndex = 29;
		this.Label3.Text = "Kategori (*)";
		this.txtName.Location = new System.Drawing.Point(103, 15);
		this.txtName.Name = "txtName";
		this.txtName.Size = new System.Drawing.Size(152, 20);
		this.txtName.TabIndex = 11;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(18, 18);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(48, 13);
		this.Label1.TabIndex = 27;
		this.Label1.Text = "Nama (*)";
		this.TabPage4.Controls.Add(this.lblStockDate);
		this.TabPage4.Controls.Add(this.dgvStorage);
		this.TabPage4.Location = new System.Drawing.Point(4, 22);
		this.TabPage4.Name = "TabPage4";
		this.TabPage4.Size = new System.Drawing.Size(581, 419);
		this.TabPage4.TabIndex = 3;
		this.TabPage4.Text = "Gudang";
		this.TabPage4.UseVisualStyleBackColor = true;
		this.lblStockDate.AutoSize = true;
		this.lblStockDate.Location = new System.Drawing.Point(13, 10);
		this.lblStockDate.Name = "lblStockDate";
		this.lblStockDate.Size = new System.Drawing.Size(68, 13);
		this.lblStockDate.TabIndex = 15;
		this.lblStockDate.Text = "lblStockDate";
		this.dgvStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvStorage.Location = new System.Drawing.Point(16, 26);
		this.dgvStorage.Name = "dgvStorage";
		this.dgvStorage.Size = new System.Drawing.Size(482, 355);
		this.dgvStorage.TabIndex = 14;
		this.TabPage3.Controls.Add(this.btnSupplier);
		this.TabPage3.Controls.Add(this.lblSupplier);
		this.TabPage3.Controls.Add(this.dgvSupplier);
		this.TabPage3.Controls.Add(this.Label7);
		this.TabPage3.Controls.Add(this.chkAllowPurchase);
		this.TabPage3.Location = new System.Drawing.Point(4, 22);
		this.TabPage3.Name = "TabPage3";
		this.TabPage3.Size = new System.Drawing.Size(581, 419);
		this.TabPage3.TabIndex = 2;
		this.TabPage3.Text = "Pembelian";
		this.TabPage3.UseVisualStyleBackColor = true;
		this.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSupplier.Location = new System.Drawing.Point(79, 41);
		this.btnSupplier.Name = "btnSupplier";
		this.btnSupplier.Size = new System.Drawing.Size(97, 24);
		this.btnSupplier.TabIndex = 12;
		this.btnSupplier.Text = "+ Harga Supplier";
		this.btnSupplier.UseVisualStyleBackColor = true;
		this.lblSupplier.AutoSize = true;
		this.lblSupplier.Location = new System.Drawing.Point(17, 41);
		this.lblSupplier.Name = "lblSupplier";
		this.lblSupplier.Size = new System.Drawing.Size(45, 13);
		this.lblSupplier.TabIndex = 38;
		this.lblSupplier.Text = "Supplier";
		this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvSupplier.Location = new System.Drawing.Point(79, 71);
		this.dgvSupplier.Name = "dgvSupplier";
		this.dgvSupplier.Size = new System.Drawing.Size(486, 262);
		this.dgvSupplier.TabIndex = 13;
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(17, 18);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(28, 13);
		this.Label7.TabIndex = 36;
		this.Label7.Text = "Opsi";
		this.chkAllowPurchase.AutoSize = true;
		this.chkAllowPurchase.Location = new System.Drawing.Point(79, 18);
		this.chkAllowPurchase.Name = "chkAllowPurchase";
		this.chkAllowPurchase.Size = new System.Drawing.Size(132, 17);
		this.chkAllowPurchase.TabIndex = 11;
		this.chkAllowPurchase.Text = "Bisa dibeli dari supplier";
		this.chkAllowPurchase.UseVisualStyleBackColor = true;
		this.TabPage2.Controls.Add(this.Label11);
		this.TabPage2.Controls.Add(this.Label8);
		this.TabPage2.Controls.Add(this.btnStandard);
		this.TabPage2.Controls.Add(this.dgvDropDownComponent);
		this.TabPage2.Controls.Add(this.Label6);
		this.TabPage2.Controls.Add(this.chkAllowProcess);
		this.TabPage2.Controls.Add(this.Label5);
		this.TabPage2.Controls.Add(this.dgvStandardComponent);
		this.TabPage2.Controls.Add(this.cboStep);
		this.TabPage2.Controls.Add(this.Label4);
		this.TabPage2.Location = new System.Drawing.Point(4, 22);
		this.TabPage2.Name = "TabPage2";
		this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage2.Size = new System.Drawing.Size(581, 419);
		this.TabPage2.TabIndex = 1;
		this.TabPage2.Text = "Produksi";
		this.TabPage2.UseVisualStyleBackColor = true;
		this.Label11.BackColor = System.Drawing.Color.Black;
		this.Label11.Location = new System.Drawing.Point(21, 71);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(535, 1);
		this.Label11.TabIndex = 40;
		this.Label11.Text = "Label11";
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(17, 82);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(121, 13);
		this.Label8.TabIndex = 39;
		this.Label8.Text = "Komponen - Drop Down";
		this.btnStandard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnStandard.Location = new System.Drawing.Point(230, 98);
		this.btnStandard.Name = "btnStandard";
		this.btnStandard.Size = new System.Drawing.Size(86, 24);
		this.btnStandard.TabIndex = 24;
		this.btnStandard.Text = "+ Standar";
		this.btnStandard.UseVisualStyleBackColor = true;
		this.dgvDropDownComponent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvDropDownComponent.Location = new System.Drawing.Point(20, 98);
		this.dgvDropDownComponent.Name = "dgvDropDownComponent";
		this.dgvDropDownComponent.Size = new System.Drawing.Size(175, 282);
		this.dgvDropDownComponent.TabIndex = 23;
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(17, 18);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(28, 13);
		this.Label6.TabIndex = 35;
		this.Label6.Text = "Opsi";
		this.chkAllowProcess.AutoSize = true;
		this.chkAllowProcess.Location = new System.Drawing.Point(112, 17);
		this.chkAllowProcess.Name = "chkAllowProcess";
		this.chkAllowProcess.Size = new System.Drawing.Size(97, 17);
		this.chkAllowProcess.TabIndex = 21;
		this.chkAllowProcess.Text = "Bisa diproduksi";
		this.chkAllowProcess.UseVisualStyleBackColor = true;
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(227, 82);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(104, 13);
		this.Label5.TabIndex = 33;
		this.Label5.Text = "Komponen - Standar";
		this.dgvStandardComponent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvStandardComponent.Location = new System.Drawing.Point(230, 128);
		this.dgvStandardComponent.Name = "dgvStandardComponent";
		this.dgvStandardComponent.Size = new System.Drawing.Size(327, 252);
		this.dgvStandardComponent.TabIndex = 25;
		this.cboStep.FormattingEnabled = true;
		this.cboStep.Location = new System.Drawing.Point(112, 40);
		this.cboStep.Name = "cboStep";
		this.cboStep.Size = new System.Drawing.Size(157, 21);
		this.cboStep.TabIndex = 22;
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(17, 43);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(83, 13);
		this.Label4.TabIndex = 31;
		this.Label4.Text = "Urutan Produksi";
		this.TabPage5.Controls.Add(this.btnStandardUsage);
		this.TabPage5.Controls.Add(this.dgvStandardUsage);
		this.TabPage5.Location = new System.Drawing.Point(4, 22);
		this.TabPage5.Name = "TabPage5";
		this.TabPage5.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage5.Size = new System.Drawing.Size(581, 419);
		this.TabPage5.TabIndex = 4;
		this.TabPage5.Text = "Penggunaan";
		this.TabPage5.UseVisualStyleBackColor = true;
		this.btnStandardUsage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnStandardUsage.Location = new System.Drawing.Point(17, 16);
		this.btnStandardUsage.Name = "btnStandardUsage";
		this.btnStandardUsage.Size = new System.Drawing.Size(86, 24);
		this.btnStandardUsage.TabIndex = 26;
		this.btnStandardUsage.Text = "+ Barang";
		this.btnStandardUsage.UseVisualStyleBackColor = true;
		this.dgvStandardUsage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvStandardUsage.Location = new System.Drawing.Point(17, 46);
		this.dgvStandardUsage.Name = "dgvStandardUsage";
		this.dgvStandardUsage.Size = new System.Drawing.Size(327, 358);
		this.dgvStandardUsage.TabIndex = 27;
		this.TabPage6.Controls.Add(this.btnItemGroup);
		this.TabPage6.Controls.Add(this.dgvItemGroup);
		this.TabPage6.Location = new System.Drawing.Point(4, 22);
		this.TabPage6.Name = "TabPage6";
		this.TabPage6.Size = new System.Drawing.Size(581, 419);
		this.TabPage6.TabIndex = 5;
		this.TabPage6.Text = "Grup";
		this.TabPage6.UseVisualStyleBackColor = true;
		this.btnItemGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnItemGroup.Location = new System.Drawing.Point(17, 16);
		this.btnItemGroup.Name = "btnItemGroup";
		this.btnItemGroup.Size = new System.Drawing.Size(86, 24);
		this.btnItemGroup.TabIndex = 28;
		this.btnItemGroup.Text = "+ Barang";
		this.btnItemGroup.UseVisualStyleBackColor = true;
		this.dgvItemGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvItemGroup.Location = new System.Drawing.Point(17, 46);
		this.dgvItemGroup.Name = "dgvItemGroup";
		this.dgvItemGroup.Size = new System.Drawing.Size(327, 358);
		this.dgvItemGroup.TabIndex = 29;
		this.TabPage7.Controls.Add(this.cboInventoryAccount);
		this.TabPage7.Controls.Add(this.Label24);
		this.TabPage7.Location = new System.Drawing.Point(4, 22);
		this.TabPage7.Name = "TabPage7";
		this.TabPage7.Size = new System.Drawing.Size(581, 419);
		this.TabPage7.TabIndex = 6;
		this.TabPage7.Text = "Akun";
		this.TabPage7.UseVisualStyleBackColor = true;
		this.cboInventoryAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboInventoryAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboInventoryAccount.FormattingEnabled = true;
		this.cboInventoryAccount.Location = new System.Drawing.Point(127, 15);
		this.cboInventoryAccount.Name = "cboInventoryAccount";
		this.cboInventoryAccount.Size = new System.Drawing.Size(238, 21);
		this.cboInventoryAccount.TabIndex = 40;
		this.Label24.AutoSize = true;
		this.Label24.Location = new System.Drawing.Point(20, 18);
		this.Label24.Name = "Label24";
		this.Label24.Size = new System.Drawing.Size(101, 13);
		this.Label24.TabIndex = 41;
		this.Label24.Text = "Akun Persediaan (*)";
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(613, 500);
		base.Controls.Add(this.TabControl1);
		base.Controls.Add(this.btnSave);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSettingItemInput";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Setting - Barang ";
		this.TabControl1.ResumeLayout(false);
		this.TabPage1.ResumeLayout(false);
		this.TabPage1.PerformLayout();
		this.TabPage4.ResumeLayout(false);
		this.TabPage4.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvStorage).EndInit();
		this.TabPage3.ResumeLayout(false);
		this.TabPage3.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvSupplier).EndInit();
		this.TabPage2.ResumeLayout(false);
		this.TabPage2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvDropDownComponent).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dgvStandardComponent).EndInit();
		this.TabPage5.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgvStandardUsage).EndInit();
		this.TabPage6.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgvItemGroup).EndInit();
		this.TabPage7.ResumeLayout(false);
		this.TabPage7.PerformLayout();
		base.ResumeLayout(false);
	}

	public frmSettingItemInput()
	{
		base.Load += frmSettingItemInput_Load;
		base.KeyDown += frmSettingItemInput_KeyDown;
		_blnDecimal = false;
		InitializeComponent();
		DoubleBuffered = true;
		base.MdiParent = MyProject.Forms.frmMenu;
		txtUnitQty2.AllowedCharacters = FilteredTextBox.InputType.NumeralsAndCurrency;
		txtUnitQty3.AllowedCharacters = FilteredTextBox.InputType.NumeralsAndCurrency;
		txtUnitQty4.AllowedCharacters = FilteredTextBox.InputType.NumeralsAndCurrency;
		ComboBox combo = cboActive;
		cCombo.getYesNo(ref combo, All: false);
		cboActive = combo;
		combo = cboItemType;
		cCombo.getItemType(ref combo, All: false);
		cboItemType = combo;
		combo = cboItemCategory;
		cCombo.getItemCategory(ref combo, 0, All: false, Active: false);
		cboItemCategory = combo;
		combo = cboStep;
		cCombo.getProductionStep(ref combo, 0, blnAll: false);
		cboStep = combo;
		combo = cboInventoryAccount;
		cCombo.getAccount(ref combo, All: false, 0, 3, 0, 0, 99, 0, 0, 0, 1);
		cboInventoryAccount = combo;
		txtName.SelectionStart = 0;
		txtName.SelectionLength = Strings.Len(txtName.Text);
		cboActive.SelectedIndex = 0;
		formatGrid();
		lblStockDate.Text = "Tanggal Stok Awal: " + Strings.Format(Module1.pubBalanceDate, "dd/MM/yyyy");
		DataTable dataTable = cStorage.Search(0, 0, "", 1);
		foreach (DataRow row in dataTable.Rows)
		{
			dgvStorage.Rows.Add(row["storeId"], TriState.False, Operators.ConcatenateObject(Operators.ConcatenateObject(row["storeName"], " - "), Strings.Left(Conversions.ToString(row["branchName"]), 3)), 0);
		}
		txtName.Focus();
	}

	private void formatGrid()
	{
		DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
		dgvStorage.Columns.Add("", "ID");
		dgvStorage.Columns.Add(dataGridViewCheckBoxColumn);
		dataGridViewCheckBoxColumn.HeaderText = "Tersedia";
		dataGridViewCheckBoxColumn.Name = "chk";
		dgvStorage.Columns.Add("", "Gudang");
		dgvStorage.Columns.Add("", "Stok Awal");
		dgvStorage.Columns.Add("", "Harga per barang");
		dgvStorage.Columns[0].Visible = false;
		dgvStorage.Columns[1].Width = 60;
		dgvStorage.Columns[2].Width = 180;
		dgvStorage.Columns[2].ReadOnly = true;
		dgvStorage.Columns[3].Width = 100;
		dgvStorage.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvStorage.Columns[4].Width = 80;
		dgvStorage.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvStorage.RowHeadersVisible = false;
		dgvStorage.AllowUserToAddRows = false;
		dgvStorage.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvStorage.AllowUserToResizeRows = false;
		dgvStorage.EditMode = DataGridViewEditMode.EditOnEnter;
		dgvSupplier.Columns.Add("", "supplierId");
		dgvSupplier.Columns.Add("", "unitNumber");
		dgvSupplier.Columns.Add("", "Supplier");
		dgvSupplier.Columns.Add("", "Satuan");
		dgvSupplier.Columns.Add("", "Harga");
		dgvSupplier.Columns.Add("", "Tanggal Berlaku");
		dgvSupplier.Columns[0].Visible = false;
		dgvSupplier.Columns[1].Visible = false;
		dgvSupplier.Columns[2].Width = 155;
		dgvSupplier.Columns[3].Width = 130;
		dgvSupplier.Columns[4].Width = 70;
		dgvSupplier.Columns[5].Width = 110;
		dgvSupplier.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvSupplier.Columns[4].DefaultCellStyle.Format = "N0";
		dgvSupplier.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvSupplier.RowHeadersVisible = false;
		dgvSupplier.AllowUserToAddRows = false;
		dgvSupplier.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvSupplier.ReadOnly = true;
		dgvSupplier.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvSupplier.AllowUserToResizeRows = false;
		DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2 = new DataGridViewCheckBoxColumn();
		dgvDropDownComponent.Columns.Add("", "ID");
		dgvDropDownComponent.Columns.Add(dataGridViewCheckBoxColumn2);
		dataGridViewCheckBoxColumn2.HeaderText = "";
		dataGridViewCheckBoxColumn2.Name = "chk";
		dgvDropDownComponent.Columns.Add("", "Komponen");
		dgvDropDownComponent.Columns[0].Visible = false;
		dgvDropDownComponent.Columns[2].ReadOnly = true;
		dgvDropDownComponent.Columns[1].Width = 30;
		dgvDropDownComponent.Columns[2].Width = 120;
		dgvDropDownComponent.RowHeadersVisible = false;
		dgvDropDownComponent.AllowUserToAddRows = false;
		dgvDropDownComponent.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvDropDownComponent.AllowUserToResizeRows = false;
		dgvDropDownComponent.DefaultCellStyle.Font = new Font("Arial", 7f);
		dgvStandardComponent.Columns.Add("", "storeId");
		dgvStandardComponent.Columns.Add("", "comId");
		dgvStandardComponent.Columns.Add("", "Gudang");
		dgvStandardComponent.Columns.Add("", "Komponen");
		dgvStandardComponent.Columns.Add("", "Jml. Standar");
		dgvStandardComponent.Columns[0].Visible = false;
		dgvStandardComponent.Columns[1].Visible = false;
		dgvStandardComponent.Columns[2].Width = 100;
		dgvStandardComponent.Columns[3].Width = 110;
		dgvStandardComponent.Columns[4].Width = 80;
		dgvStandardComponent.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvStandardComponent.RowHeadersVisible = false;
		dgvStandardComponent.AllowUserToAddRows = false;
		dgvStandardComponent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvStandardComponent.ReadOnly = true;
		dgvStandardComponent.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvStandardComponent.AllowUserToResizeRows = false;
		dgvStandardComponent.DefaultCellStyle.Font = new Font("Arial", 8f);
		dgvStandardUsage.Columns.Add("", "storeId");
		dgvStandardUsage.Columns.Add("", "comId");
		dgvStandardUsage.Columns.Add("", "Cabang");
		dgvStandardUsage.Columns.Add("", "Komponen");
		dgvStandardUsage.Columns.Add("", "Jumlah");
		dgvStandardUsage.Columns[0].Visible = false;
		dgvStandardUsage.Columns[1].Visible = false;
		dgvStandardUsage.Columns[2].Width = 100;
		dgvStandardUsage.Columns[3].Width = 110;
		dgvStandardUsage.Columns[4].Width = 80;
		dgvStandardUsage.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvStandardUsage.RowHeadersVisible = false;
		dgvStandardUsage.AllowUserToAddRows = false;
		dgvStandardUsage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvStandardUsage.ReadOnly = true;
		dgvStandardUsage.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvStandardUsage.AllowUserToResizeRows = false;
		dgvStandardUsage.DefaultCellStyle.Font = new Font("Arial", 8f);
		dgvItemGroup.Columns.Add("", "comId");
		dgvItemGroup.Columns.Add("", "Komponen");
		dgvItemGroup.Columns.Add("", "Jumlah");
		dgvItemGroup.Columns[0].Visible = false;
		dgvItemGroup.Columns[1].Width = 110;
		dgvItemGroup.Columns[2].Width = 80;
		dgvItemGroup.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItemGroup.RowHeadersVisible = false;
		dgvItemGroup.AllowUserToAddRows = false;
		dgvItemGroup.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvItemGroup.ReadOnly = true;
		dgvItemGroup.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvItemGroup.AllowUserToResizeRows = false;
		dgvItemGroup.DefaultCellStyle.Font = new Font("Arial", 8f);
	}

	private void frmSettingItemInput_Load(object sender, EventArgs e)
	{
		txtName.Select();
	}

	private void frmSettingItemInput_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	public void prepareForm()
	{
		_currentId = 0;
		_finishLoading = true;
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
					_finishLoading = false;
					cItem cItem2 = new cItem(_currentId);
					txtName.Text = cItem2.Name;
					ComboBox cboSource = cboItemType;
					Module1.comboBoundValue(ref cboSource, cItem2.TypeId);
					cboItemType = cboSource;
					cboSource = cboItemCategory;
					Module1.comboBoundValue(ref cboSource, cItem2.CatId);
					cboItemCategory = cboSource;
					chkAllowComponent.Checked = cItem2.AllowComponent != 0;
					chkAllowEditStockQty.Checked = cItem2.AllowEditStockQty != 0;
					chkFlower.Checked = cItem2.Flower != 0;
					txtLongName.Text = cItem2.LongName;
					txtPackaging.Text = cItem2.Packaging;
					chkTehGopek.Checked = cItem2.IsTehGopek != 0;
					chkAllowSell.Checked = cItem2.AllowSell != 0;
					txtUnitName1.Text = cItem2.UnitName1;
					txtUnitName2.Text = cItem2.UnitName2;
					txtUnitName3.Text = cItem2.UnitName3;
					txtUnitName4.Text = cItem2.UnitName4;
					txtUnitQty2.Text = Module1.formatCustomDecimal(Conversions.ToString(cItem2.UnitQty2), 3);
					txtUnitQty3.Text = Module1.formatCustomDecimal(Conversions.ToString(cItem2.UnitQty3), 3);
					txtUnitQty4.Text = Module1.formatCustomDecimal(Conversions.ToString(cItem2.UnitQty4), 3);
					lblUnitName2.Text = txtUnitName1.Text;
					lblUnitName3.Text = txtUnitName1.Text;
					lblUnitName4.Text = txtUnitName1.Text;
					cboSource = cboActive;
					Module1.comboBoundValue(ref cboSource, cItem2.Active);
					cboActive = cboSource;
					cboSource = cboInventoryAccount;
					Module1.comboBoundValue(ref cboSource, cItem2.InventoryAccountId);
					cboInventoryAccount = cboSource;
					chkAllowPurchase.Checked = cItem2.AllowPurchase != 0;
					chkAllowProcess.Checked = cItem2.AllowProcess != 0;
					if (cItem2.AllowProcess == 1)
					{
						cboStep.Enabled = true;
						btnStandard.Enabled = true;
					}
					else
					{
						cboStep.Enabled = false;
						btnStandard.Enabled = false;
					}
					cboSource = cboStep;
					Module1.comboBoundValue(ref cboSource, cItem2.ProductionStepId);
					cboStep = cboSource;
					dgvStorage.Rows.Clear();
					cItemStorage[] storage = cItem2.Storage;
					foreach (cItemStorage cItemStorage2 in storage)
					{
						dgvStorage.Rows.Add(cItemStorage2.StorageId, Interaction.IIf(0 - (cItemStorage2.IsMember ? 1 : 0) == 0, TriState.False, TriState.True), cItemStorage2.StorageName + " - " + Strings.Left(cItemStorage2.BranchName, 3), Module1.formatCustomDecimal(Conversions.ToString(cItemStorage2.Qty), 3), Module1.formatCustomDecimal(Conversions.ToString(cItemStorage2.Price), 2));
						if (cItemStorage2.IsMember)
						{
							dgvStorage[2, checked(dgvStorage.RowCount - 1)].Style.BackColor = Color.LightGreen;
						}
					}
					dgvSupplier.Rows.Clear();
					cItemPurchasePrice[] purchasePrice = cItem2.PurchasePrice;
					foreach (cItemPurchasePrice cItemPurchasePrice2 in purchasePrice)
					{
						dgvSupplier.Rows.Add(cItemPurchasePrice2.SupplierId, cItemPurchasePrice2.UnitNumber, cItemPurchasePrice2.SupplierName, "Satuan " + Conversions.ToString(cItemPurchasePrice2.UnitNumber) + ": " + cItemPurchasePrice2.UnitName, cItemPurchasePrice2.Price, cItemPurchasePrice2.ValidFromDate);
					}
					dgvDropDownComponent.Rows.Clear();
					cItemComponent[] component = cItem2.Component;
					foreach (cItemComponent cItemComponent2 in component)
					{
						dgvDropDownComponent.Rows.Add(cItemComponent2.ItemId, Interaction.IIf(0 - (cItemComponent2.IsMember ? 1 : 0) == 0, TriState.False, TriState.True), cItemComponent2.ItemName);
						if (cItemComponent2.IsMember)
						{
							dgvDropDownComponent[2, checked(dgvDropDownComponent.RowCount - 1)].Style.BackColor = Color.LightGreen;
						}
					}
					dgvStandardComponent.Rows.Clear();
					cItemStandardComponent[] standardComponent = cItem2.StandardComponent;
					foreach (cItemStandardComponent cItemStandardComponent2 in standardComponent)
					{
						dgvStandardComponent.Rows.Add(cItemStandardComponent2.StorageId, cItemStandardComponent2.ComponentId, cItemStandardComponent2.StorageName, cItemStandardComponent2.ComponentName, Module1.formatCustomDecimal(Conversions.ToString(cItemStandardComponent2.Qty), 3));
					}
					dgvStandardUsage.Rows.Clear();
					cItemStandardUsage[] standardUsage = cItem2.StandardUsage;
					foreach (cItemStandardUsage cItemStandardUsage2 in standardUsage)
					{
						dgvStandardUsage.Rows.Add(cItemStandardUsage2.BranchId, cItemStandardUsage2.ComponentId, cItemStandardUsage2.BranchName, cItemStandardUsage2.ComponentName, Module1.formatCustomDecimal(Conversions.ToString(cItemStandardUsage2.Qty), 8));
					}
					dgvItemGroup.Rows.Clear();
					cItemGroup[] group = cItem2.Group;
					foreach (cItemGroup cItemGroup2 in group)
					{
						dgvItemGroup.Rows.Add(cItemGroup2.ComponentId, cItemGroup2.ComponentName, Module1.formatCustomDecimal(Conversions.ToString(cItemGroup2.Qty), 3));
					}
					_finishLoading = true;
					goto end_IL_0001;
				}
				case 1812:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSettingItemInput", "loadData", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1812;
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

	private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (TabControl1.SelectedIndex == 1)
		{
			if (dgvStorage.Rows.Count > 0)
			{
				dgvStorage.CurrentRow.Selected = false;
			}
		}
		else if (TabControl1.SelectedIndex == 2)
		{
			if (dgvSupplier.Rows.Count > 0)
			{
				dgvSupplier.CurrentRow.Selected = false;
			}
		}
		else if (TabControl1.SelectedIndex == 3)
		{
			if (dgvDropDownComponent.Rows.Count > 0)
			{
				dgvDropDownComponent.CurrentRow.Selected = false;
			}
			if (dgvStandardComponent.Rows.Count > 0)
			{
				dgvStandardComponent.CurrentRow.Selected = false;
			}
		}
		else if (TabControl1.SelectedIndex == 4)
		{
			if (dgvStandardUsage.Rows.Count > 0)
			{
				dgvStandardUsage.CurrentRow.Selected = false;
			}
		}
		else if (TabControl1.SelectedIndex == 5 && dgvItemGroup.Rows.Count > 0)
		{
			dgvItemGroup.CurrentRow.Selected = false;
		}
	}

	private void txtUnitName1_TextChanged(object sender, EventArgs e)
	{
		lblUnitName2.Text = txtUnitName1.Text;
		lblUnitName3.Text = txtUnitName1.Text;
		lblUnitName4.Text = txtUnitName1.Text;
	}

	private void dgvStorage_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		if (dgvStorage.CurrentCell.ColumnIndex == 3)
		{
			string strInput = dgvStorage[dgvStorage.CurrentCell.ColumnIndex, dgvStorage.CurrentCell.RowIndex].Value.ToString();
			strInput = Module1.formatCustomDecimal(strInput, 3);
			strInput = Conversions.ToString(decimal.Parse(strInput, NumberStyles.Currency));
			dgvStorage[dgvStorage.CurrentCell.ColumnIndex, dgvStorage.CurrentCell.RowIndex].Value = strInput;
		}
		else if (dgvStorage.CurrentCell.ColumnIndex == 4)
		{
			string strInput2 = dgvStorage[dgvStorage.CurrentCell.ColumnIndex, dgvStorage.CurrentCell.RowIndex].Value.ToString();
			strInput2 = Module1.formatCustomDecimal(strInput2, 2);
			strInput2 = Conversions.ToString(decimal.Parse(strInput2, NumberStyles.Currency));
			dgvStorage[dgvStorage.CurrentCell.ColumnIndex, dgvStorage.CurrentCell.RowIndex].Value = strInput2;
		}
	}

	private void dgvStorage_CellEndEdit(object sender, DataGridViewCellEventArgs e)
	{
		if (dgvStorage.CurrentCell.ColumnIndex == 3)
		{
			string strInput = ((Information.IsNothing(RuntimeHelpers.GetObjectValue(dgvStorage[dgvStorage.CurrentCell.ColumnIndex, dgvStorage.CurrentCell.RowIndex].Value)) || Operators.CompareString(dgvStorage[dgvStorage.CurrentCell.ColumnIndex, dgvStorage.CurrentCell.RowIndex].Value.ToString(), "", TextCompare: false) == 0) ? Conversions.ToString(0) : dgvStorage[dgvStorage.CurrentCell.ColumnIndex, dgvStorage.CurrentCell.RowIndex].Value.ToString());
			strInput = Module1.formatCustomDecimal(strInput, 3);
			dgvStorage[dgvStorage.CurrentCell.ColumnIndex, dgvStorage.CurrentCell.RowIndex].Value = strInput;
		}
		else if (dgvStorage.CurrentCell.ColumnIndex == 4)
		{
			string strInput2 = ((Information.IsNothing(RuntimeHelpers.GetObjectValue(dgvStorage[dgvStorage.CurrentCell.ColumnIndex, dgvStorage.CurrentCell.RowIndex].Value)) || Operators.CompareString(dgvStorage[dgvStorage.CurrentCell.ColumnIndex, dgvStorage.CurrentCell.RowIndex].Value.ToString(), "", TextCompare: false) == 0) ? Conversions.ToString(0) : dgvStorage[dgvStorage.CurrentCell.ColumnIndex, dgvStorage.CurrentCell.RowIndex].Value.ToString());
			strInput2 = Module1.formatCustomDecimal(strInput2, 2);
			dgvStorage[dgvStorage.CurrentCell.ColumnIndex, dgvStorage.CurrentCell.RowIndex].Value = strInput2;
		}
	}

	private void dgvStorage_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
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
					if (!((e.ColumnIndex != 3) & (e.ColumnIndex != 4)) && !dgvStorage.Rows[e.RowIndex].IsNewRow)
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
				case 200:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSettingItemInput", "dgvStorage_CellValidating", "");
						goto end_IL_0001;
					}
					break;
				}
				goto IL_00fe;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 200;
				continue;
			}
			break;
			IL_00fe:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void dgvStorage_GotFocus(object sender, EventArgs e)
	{
		if ((dgvStorage.RowCount > 0) & !_dontFocus)
		{
			dgvStorage.CurrentCell.Selected = true;
		}
		else
		{
			_dontFocus = false;
		}
	}

	private void dgvStorage_LostFocus(object sender, EventArgs e)
	{
		if (dgvStorage.RowCount > 0)
		{
			dgvStorage.CurrentCell.Selected = false;
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
			TabControl1.Focus();
			e.SuppressKeyPress = true;
		}
	}

	private void dgvStorage_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(dgvStorage[1, dgvStorage.CurrentCell.RowIndex].EditedFormattedValue, true, TextCompare: false))
		{
			dgvStorage[2, dgvStorage.CurrentCell.RowIndex].Style.BackColor = Color.LightGreen;
		}
		else if (dgvStorage.CurrentCell.RowIndex % 2 == 1)
		{
			dgvStorage[2, dgvStorage.CurrentCell.RowIndex].Style.BackColor = Color.WhiteSmoke;
		}
		else
		{
			dgvStorage[2, dgvStorage.CurrentCell.RowIndex].Style.BackColor = Color.White;
		}
	}

	private void dgvStorage_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(dgvStorage[1, dgvStorage.CurrentCell.RowIndex].EditedFormattedValue, true, TextCompare: false))
		{
			dgvStorage[2, dgvStorage.CurrentCell.RowIndex].Style.BackColor = Color.LightGreen;
		}
		else if (dgvStorage.CurrentCell.RowIndex % 2 == 1)
		{
			dgvStorage[2, dgvStorage.CurrentCell.RowIndex].Style.BackColor = Color.WhiteSmoke;
		}
		else
		{
			dgvStorage[2, dgvStorage.CurrentCell.RowIndex].Style.BackColor = Color.White;
		}
	}

	private void dgvStorage_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
	{
		Control control = e.Control;
		control.KeyDown += Handle_KeyDown;
		control.KeyPress += Handle_KeyPress;
	}

	protected void Handle_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyValue == 110)
		{
			_blnDecimal = true;
		}
		else
		{
			_blnDecimal = false;
		}
	}

	protected void Handle_KeyPress(object sender, KeyPressEventArgs e)
	{
		short num = checked((short)Strings.Asc(e.KeyChar));
		if (_blnDecimal)
		{
			e.KeyChar = Conversions.ToChar(CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
		}
		if (!((num >= 48 && num <= 57) | (e.KeyChar == Convert.ToChar(110)) | (e.KeyChar == Convert.ToChar(8)) | (Operators.CompareString(Conversions.ToString(e.KeyChar), CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator, TextCompare: false) == 0)))
		{
			e.Handled = true;
		}
	}

	private void btnSupplier_Click(object sender, EventArgs e)
	{
		frmSettingItemSupplier frmSettingItemSupplier2 = new frmSettingItemSupplier(CurrentData: false);
		frmSettingItemSupplier2.cboUnit.Items.Clear();
		frmSettingItemSupplier2.cboUnit.Items.Add("Satuan 1: " + txtUnitName1.Text);
		frmSettingItemSupplier2.cboUnit.Items.Add("Satuan 2: " + txtUnitName2.Text);
		frmSettingItemSupplier2.cboUnit.Items.Add("Satuan 3: " + txtUnitName3.Text);
		frmSettingItemSupplier2.cboUnit.Items.Add("Satuan 4: " + txtUnitName4.Text);
		frmSettingItemSupplier2.ShowDialog();
		frmSettingItemSupplier2.Close();
		frmSettingItemSupplier2.Dispose();
	}

	private void dgvSupplier_GotFocus(object sender, EventArgs e)
	{
		if (dgvSupplier.RowCount > 0)
		{
			dgvSupplier.CurrentRow.Selected = true;
		}
	}

	private void dgvSupplier_LostFocus(object sender, EventArgs e)
	{
		if (dgvSupplier.RowCount > 0)
		{
			dgvSupplier.CurrentRow.Selected = false;
		}
	}

	private void dgvSupplier_DoubleClick(object sender, EventArgs e)
	{
		OpenItem();
	}

	private void dgvSupplier_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			OpenItem();
			e.SuppressKeyPress = true;
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			btnSupplier.Focus();
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
					ProjectData.ClearProjectError();
					num2 = 2;
					if (dgvSupplier.Rows.Count > 0)
					{
						frmSettingItemSupplier frmSettingItemSupplier2 = new frmSettingItemSupplier(CurrentData: true);
						frmSettingItemSupplier2.cboUnit.Items.Clear();
						frmSettingItemSupplier2.cboUnit.Items.Add("Satuan 1: " + txtUnitName1.Text);
						frmSettingItemSupplier2.cboUnit.Items.Add("Satuan 2: " + txtUnitName2.Text);
						frmSettingItemSupplier2.cboUnit.Items.Add("Satuan 3: " + txtUnitName3.Text);
						frmSettingItemSupplier2.cboUnit.Items.Add("Satuan 4: " + txtUnitName4.Text);
						ComboBox cboSource = frmSettingItemSupplier2.cboSupplier;
						Module1.comboBoundValue(ref cboSource, Conversions.ToDouble(dgvSupplier[0, dgvSupplier.CurrentRow.Index].Value));
						frmSettingItemSupplier2.cboSupplier = cboSource;
						frmSettingItemSupplier2.cboUnit.SelectedIndex = checked((int)Math.Round(Conversion.Val(Operators.SubtractObject(dgvSupplier[1, dgvSupplier.CurrentRow.Index].Value, 1))));
						frmSettingItemSupplier2.txtPrice.Text = Module1.formatCustomDecimal(Conversions.ToString(dgvSupplier[4, dgvSupplier.CurrentRow.Index].Value), 2);
						frmSettingItemSupplier2.dtpValid.Value = Conversions.ToDate(dgvSupplier[5, dgvSupplier.CurrentRow.Index].Value);
						frmSettingItemSupplier2.ShowDialog();
					}
					goto end_IL_0001;
				case 488:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSettingItemInput", "OpenItem", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 488;
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

	private void dgvDropDownComponent_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(dgvDropDownComponent[1, dgvDropDownComponent.CurrentCell.RowIndex].EditedFormattedValue, true, TextCompare: false))
		{
			dgvDropDownComponent[2, dgvDropDownComponent.CurrentCell.RowIndex].Style.BackColor = Color.LightGreen;
		}
		else if (dgvDropDownComponent.CurrentCell.RowIndex % 2 == 1)
		{
			dgvDropDownComponent[2, dgvDropDownComponent.CurrentCell.RowIndex].Style.BackColor = Color.WhiteSmoke;
		}
		else
		{
			dgvDropDownComponent[2, dgvDropDownComponent.CurrentCell.RowIndex].Style.BackColor = Color.White;
		}
	}

	private void dgvDropDownComponent_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(dgvDropDownComponent[1, dgvDropDownComponent.CurrentCell.RowIndex].EditedFormattedValue, true, TextCompare: false))
		{
			dgvDropDownComponent[2, dgvDropDownComponent.CurrentCell.RowIndex].Style.BackColor = Color.LightGreen;
		}
		else if (dgvDropDownComponent.CurrentCell.RowIndex % 2 == 1)
		{
			dgvDropDownComponent[2, dgvDropDownComponent.CurrentCell.RowIndex].Style.BackColor = Color.WhiteSmoke;
		}
		else
		{
			dgvDropDownComponent[2, dgvDropDownComponent.CurrentCell.RowIndex].Style.BackColor = Color.White;
		}
	}

	private void dgvDropDownComponent_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			e.SuppressKeyPress = true;
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			cboStep.Focus();
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			btnStandard.Focus();
			e.SuppressKeyPress = true;
		}
	}

	private void dgvDropDownComponent_GotFocus(object sender, EventArgs e)
	{
		if (dgvDropDownComponent.RowCount > 0)
		{
			dgvDropDownComponent.CurrentRow.Selected = true;
		}
	}

	private void dgvDropDownComponent_LostFocus(object sender, EventArgs e)
	{
		if (dgvDropDownComponent.RowCount > 0)
		{
			dgvDropDownComponent.CurrentRow.Selected = false;
		}
	}

	private void dgvStandardComponent_DoubleClick(object sender, EventArgs e)
	{
		OpenStandardComponent();
	}

	private void dgvStandardComponent_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			OpenStandardComponent();
			e.SuppressKeyPress = true;
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			btnStandard.Focus();
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			btnSave.Focus();
			e.SuppressKeyPress = true;
		}
	}

	private void dgvStandardComponent_GotFocus(object sender, EventArgs e)
	{
		if (dgvStandardComponent.RowCount > 0)
		{
			dgvStandardComponent.CurrentRow.Selected = true;
		}
	}

	private void dgvStandardComponent_LostFocus(object sender, EventArgs e)
	{
		if (dgvStandardComponent.RowCount > 0)
		{
			dgvStandardComponent.CurrentRow.Selected = false;
		}
	}

	private void dgvStandardUsage_DoubleClick(object sender, EventArgs e)
	{
		OpenStandardUsage();
	}

	private void dgvStandardUsage_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			OpenStandardUsage();
			e.SuppressKeyPress = true;
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			btnStandard.Focus();
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			btnSave.Focus();
			e.SuppressKeyPress = true;
		}
	}

	private void dgvStandardUsage_GotFocus(object sender, EventArgs e)
	{
		if (dgvStandardUsage.RowCount > 0)
		{
			dgvStandardUsage.CurrentRow.Selected = true;
		}
	}

	private void dgvStandardUsage_LostFocus(object sender, EventArgs e)
	{
		if (dgvStandardUsage.RowCount > 0)
		{
			dgvStandardUsage.CurrentRow.Selected = false;
		}
	}

	private void dgvItemGroup_DoubleClick(object sender, EventArgs e)
	{
		OpenItemGroup();
	}

	private void dgvItemGroup_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			OpenItemGroup();
			e.SuppressKeyPress = true;
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			btnStandard.Focus();
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			btnSave.Focus();
			e.SuppressKeyPress = true;
		}
	}

	private void dgvItemGroup_GotFocus(object sender, EventArgs e)
	{
		if (dgvItemGroup.RowCount > 0)
		{
			dgvItemGroup.CurrentRow.Selected = true;
		}
	}

	private void dgvItemGroup_LostFocus(object sender, EventArgs e)
	{
		if (dgvItemGroup.RowCount > 0)
		{
			dgvItemGroup.CurrentRow.Selected = false;
		}
	}

	private void chkAllowProcess_CheckedChanged(object sender, EventArgs e)
	{
		if (chkAllowProcess.Checked)
		{
			cboStep.Enabled = true;
			btnStandard.Enabled = true;
		}
	}

	private void cboStep_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!_finishLoading)
		{
			return;
		}
		cComboItem cComboItem2 = (cComboItem)cboStep.SelectedItem;
		DataTable component = cStep.GetComponent(Conversions.ToInteger(cComboItem2.Value));
		dgvDropDownComponent.Rows.Clear();
		foreach (DataRow row in component.Rows)
		{
			dgvDropDownComponent.Rows.Add(row["itemId"], TriState.False, row["itemName"]);
		}
	}

	private void btnStandard_Click(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboStep.SelectedItem;
		if (cboStep.SelectedIndex > -1)
		{
			frmSettingItemStandardComponent frmSettingItemStandardComponent2 = new frmSettingItemStandardComponent(CurrentData: false, Conversions.ToInteger(cComboItem2.Value));
			frmSettingItemStandardComponent2.ShowDialog();
			frmSettingItemStandardComponent2.Close();
			frmSettingItemStandardComponent2.Dispose();
		}
		else
		{
			Interaction.MsgBox("Pilih urutan produksi", MsgBoxStyle.Information);
			cboStep.Focus();
		}
	}

	private void OpenStandardComponent()
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
					if (dgvStandardComponent.Rows.Count > 0)
					{
						cComboItem cComboItem2 = (cComboItem)cboStep.SelectedItem;
						frmSettingItemStandardComponent frmSettingItemStandardComponent2 = new frmSettingItemStandardComponent(CurrentData: true, Conversions.ToInteger(cComboItem2.Value));
						ComboBox cboSource = frmSettingItemStandardComponent2.cboStorage;
						Module1.comboBoundValue(ref cboSource, Conversions.ToDouble(dgvStandardComponent[0, dgvStandardComponent.CurrentRow.Index].Value));
						frmSettingItemStandardComponent2.cboStorage = cboSource;
						cboSource = frmSettingItemStandardComponent2.cboItem;
						Module1.comboBoundValue(ref cboSource, Conversions.ToDouble(dgvStandardComponent[1, dgvStandardComponent.CurrentRow.Index].Value));
						frmSettingItemStandardComponent2.cboItem = cboSource;
						frmSettingItemStandardComponent2.txtQty.Text = Module1.formatCustomDecimal(Conversions.ToString(dgvStandardComponent[4, dgvStandardComponent.CurrentRow.Index].Value), 3);
						frmSettingItemStandardComponent2.ShowDialog();
					}
					goto end_IL_0001;
				case 298:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSettingItemInput", "OpenStandardComponent", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 298;
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

	private void OpenStandardUsage()
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
					if (dgvStandardUsage.Rows.Count > 0)
					{
						frmSettingItemStandardUsage frmSettingItemStandardUsage2 = new frmSettingItemStandardUsage(CurrentData: true);
						ComboBox cboSource = frmSettingItemStandardUsage2.cboBranch;
						Module1.comboBoundValue(ref cboSource, Conversions.ToDouble(dgvStandardUsage[0, dgvStandardUsage.CurrentRow.Index].Value));
						frmSettingItemStandardUsage2.cboBranch = cboSource;
						cboSource = frmSettingItemStandardUsage2.cboItem;
						Module1.comboBoundValue(ref cboSource, Conversions.ToDouble(dgvStandardUsage[1, dgvStandardUsage.CurrentRow.Index].Value));
						frmSettingItemStandardUsage2.cboItem = cboSource;
						frmSettingItemStandardUsage2.txtQty.Text = Module1.formatCustomDecimal(Conversions.ToString(dgvStandardUsage[4, dgvStandardUsage.CurrentRow.Index].Value), 8);
						frmSettingItemStandardUsage2.ShowDialog();
					}
					goto end_IL_0001;
				case 265:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSettingItemInput", "OpenStandardUsage", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 265;
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

	private void OpenItemGroup()
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
					if (dgvStandardUsage.Rows.Count > 0)
					{
						frmSettingItemGroup frmSettingItemGroup2 = new frmSettingItemGroup(CurrentData: true);
						ComboBox cboSource = frmSettingItemGroup2.cboItem;
						Module1.comboBoundValue(ref cboSource, Conversions.ToDouble(dgvStandardUsage[1, dgvStandardUsage.CurrentRow.Index].Value));
						frmSettingItemGroup2.cboItem = cboSource;
						frmSettingItemGroup2.txtQty.Text = Module1.formatCustomDecimal(Conversions.ToString(dgvStandardUsage[4, dgvStandardUsage.CurrentRow.Index].Value), 8);
						frmSettingItemGroup2.ShowDialog();
					}
					goto end_IL_0001;
				case 202:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSettingItemInput", "OpenItemGroup", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 202;
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
						cComboItem cComboItem2 = (cComboItem)cboItemType.SelectedItem;
						cComboItem cComboItem3 = (cComboItem)cboItemCategory.SelectedItem;
						cComboItem cComboItem4 = (cComboItem)cboActive.SelectedItem;
						cComboItem cComboItem5 = (cComboItem)cboStep.SelectedItem;
						cComboItem cComboItem6 = (cComboItem)cboInventoryAccount.SelectedItem;
						if (Operators.CompareString(txtName.Text, "", TextCompare: false) == 0)
						{
							Interaction.MsgBox("Masukkan nama barang", MsgBoxStyle.Information);
							txtName.Focus();
							goto end_IL_0001;
						}
						if (cItem.IsExist(_currentId, Module1.cleanString(txtName.Text)))
						{
							Interaction.MsgBox("Nama barang sudah pernah digunakan. Masukkan nama lain.", MsgBoxStyle.Information);
							txtName.Focus();
							goto end_IL_0001;
						}
						if (cboItemType.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih tipe barang", MsgBoxStyle.Information);
							cboItemType.Focus();
							goto end_IL_0001;
						}
						if (cboItemCategory.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih kategori barang", MsgBoxStyle.Information);
							cboItemCategory.Focus();
							goto end_IL_0001;
						}
						if (Operators.CompareString(txtUnitName1.Text, "", TextCompare: false) == 0)
						{
							Interaction.MsgBox("Masukkan satuan 1 (default).", MsgBoxStyle.Information);
							txtUnitName1.Focus();
							goto end_IL_0001;
						}
						if (cboActive.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih aktif/tidak", MsgBoxStyle.Information);
							cboActive.Focus();
							goto end_IL_0001;
						}
						if (chkAllowProcess.Checked && cboStep.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih urutan produksi", MsgBoxStyle.Information);
							cboStep.Focus();
							goto end_IL_0001;
						}
						if ((Operators.CompareString(Strings.Trim(txtUnitName2.Text), "", TextCompare: false) == 0) & (Conversion.Val(Module1.unformatNumber(txtUnitQty2.Text)) > 0.0))
						{
							Interaction.MsgBox("Masukkan nama satuan 2", MsgBoxStyle.Information);
							txtUnitName2.Focus();
							goto end_IL_0001;
						}
						if ((Operators.CompareString(Strings.Trim(txtUnitName2.Text), "", TextCompare: false) != 0) & (Conversion.Val(Module1.unformatNumber(txtUnitQty2.Text)) == 0.0))
						{
							Interaction.MsgBox("Masukkan jumlah satuan 2", MsgBoxStyle.Information);
							txtUnitQty2.Focus();
							goto end_IL_0001;
						}
						if ((Operators.CompareString(Strings.Trim(txtUnitName2.Text), "", TextCompare: false) != 0) & (Conversion.Val(Module1.unformatNumber(txtUnitQty2.Text)) == 1.0))
						{
							Interaction.MsgBox("Jumlah satuan 2 tidak boleh 1.", MsgBoxStyle.Information);
							txtUnitQty2.Focus();
							goto end_IL_0001;
						}
						if ((Operators.CompareString(Strings.Trim(txtUnitName3.Text), "", TextCompare: false) == 0) & (Conversion.Val(Module1.unformatNumber(txtUnitQty3.Text)) > 0.0))
						{
							Interaction.MsgBox("Masukkan nama satuan 3", MsgBoxStyle.Information);
							txtUnitName3.Focus();
							goto end_IL_0001;
						}
						if ((Operators.CompareString(Strings.Trim(txtUnitName3.Text), "", TextCompare: false) != 0) & (Conversion.Val(Module1.unformatNumber(txtUnitQty3.Text)) == 0.0))
						{
							Interaction.MsgBox("Masukkan jumlah satuan 3", MsgBoxStyle.Information);
							txtUnitQty3.Focus();
							goto end_IL_0001;
						}
						if ((Operators.CompareString(Strings.Trim(txtUnitName3.Text), "", TextCompare: false) != 0) & (Conversion.Val(Module1.unformatNumber(txtUnitQty3.Text)) == 1.0))
						{
							Interaction.MsgBox("Jumlah satuan 3 tidak boleh 1.", MsgBoxStyle.Information);
							txtUnitQty3.Focus();
							goto end_IL_0001;
						}
						if ((Operators.CompareString(Strings.Trim(txtUnitName4.Text), "", TextCompare: false) == 0) & (Conversion.Val(Module1.unformatNumber(txtUnitQty4.Text)) > 0.0))
						{
							Interaction.MsgBox("Masukkan nama satuan 4", MsgBoxStyle.Information);
							txtUnitName4.Focus();
							goto end_IL_0001;
						}
						if ((Operators.CompareString(Strings.Trim(txtUnitName4.Text), "", TextCompare: false) != 0) & (Conversion.Val(Module1.unformatNumber(txtUnitQty4.Text)) == 0.0))
						{
							Interaction.MsgBox("Masukkan jumlah satuan 4", MsgBoxStyle.Information);
							txtUnitQty4.Focus();
							goto end_IL_0001;
						}
						if ((Operators.CompareString(Strings.Trim(txtUnitName4.Text), "", TextCompare: false) != 0) & (Conversion.Val(Module1.unformatNumber(txtUnitQty4.Text)) == 1.0))
						{
							Interaction.MsgBox("Jumlah satuan 4 tidak boleh 1.", MsgBoxStyle.Information);
							txtUnitQty4.Focus();
							goto end_IL_0001;
						}
						if (cboInventoryAccount.SelectedIndex == -1)
						{
							TabControl1.SelectedTab = TabControl1.TabPages[6];
							Interaction.MsgBox("Pilih Akun Persediaan.", MsgBoxStyle.Information);
							cboInventoryAccount.Focus();
							goto end_IL_0001;
						}
						Cursor = Cursors.WaitCursor;
						cItem cItem2 = new cItem(0);
						cItem2.Id = _currentId;
						cItem2.Name = txtName.Text;
						cItem2.TypeId = Conversions.ToInteger(cComboItem2.Value);
						cItem2.CatId = Conversions.ToInteger(cComboItem3.Value);
						cItem2.AllowComponent = Conversions.ToInteger(Interaction.IIf(chkAllowComponent.Checked, 1, 0));
						cItem2.AllowEditStockQty = Conversions.ToInteger(Interaction.IIf(chkAllowEditStockQty.Checked, 1, 0));
						cItem2.Flower = Conversions.ToInteger(Interaction.IIf(chkFlower.Checked, 1, 0));
						cItem2.HasDeduction = Conversions.ToInteger(Interaction.IIf(chkFlower.Checked, 1, 0));
						cItem2.HasParkedQty = Conversions.ToInteger(Interaction.IIf(chkFlower.Checked, 1, 0));
						cItem2.HasExtraPrice = Conversions.ToInteger(Interaction.IIf(chkFlower.Checked, 1, 0));
						cItem2.AllowPurchase = Conversions.ToInteger(Interaction.IIf(chkAllowPurchase.Checked, 1, 0));
						cItem2.AllowComponent = Conversions.ToInteger(Interaction.IIf(chkAllowComponent.Checked, 1, 0));
						cItem2.AllowProcess = Conversions.ToInteger(Interaction.IIf(chkAllowProcess.Checked, 1, 0));
						cItem2.IsTehGopek = Conversions.ToInteger(Interaction.IIf(chkTehGopek.Checked, 1, 0));
						cItem2.AllowSell = Conversions.ToInteger(Interaction.IIf(chkAllowSell.Checked, 1, 0));
						cItem2.LongName = txtLongName.Text;
						cItem2.Packaging = txtPackaging.Text;
						cItem2.UnitName1 = txtUnitName1.Text;
						cItem2.UnitName2 = txtUnitName2.Text;
						cItem2.UnitName3 = txtUnitName3.Text;
						cItem2.UnitName4 = txtUnitName4.Text;
						cItem2.UnitQty2 = Conversion.Val(Module1.unformatNumber(txtUnitQty2.Text));
						cItem2.UnitQty3 = Conversion.Val(Module1.unformatNumber(txtUnitQty3.Text));
						cItem2.UnitQty4 = Conversion.Val(Module1.unformatNumber(txtUnitQty4.Text));
						cItem2.InventoryAccountId = Conversions.ToInteger(cComboItem6.Value);
						cItemStorage[] array = new cItemStorage[dgvStorage.Rows.Count - 1 + 1];
						array = null;
						cItemComponent[] array2 = new cItemComponent[dgvDropDownComponent.Rows.Count - 1 + 1];
						array2 = null;
						cItemStandardComponent[] array3 = new cItemStandardComponent[dgvStandardComponent.Rows.Count - 1 + 1];
						array3 = null;
						cItemStandardUsage[] array4 = new cItemStandardUsage[dgvStandardUsage.Rows.Count - 1 + 1];
						array4 = null;
						cItemGroup[] array5 = new cItemGroup[dgvItemGroup.Rows.Count - 1 + 1];
						array5 = null;
						int num3 = 0;
						int num4 = dgvStorage.Rows.Count - 1;
						for (int i = 0; i <= num4; i++)
						{
							array = (cItemStorage[])Utils.CopyArray(array, new cItemStorage[num3 + 1]);
							array[num3] = new cItemStorage();
							array[num3].StorageId = Conversions.ToInteger(dgvStorage[0, i].Value);
							array[num3].IsMember = Conversions.ToBoolean(dgvStorage[1, i].Value);
							array[num3].Qty = Conversions.ToDouble(dgvStorage[3, i].Value);
							array[num3].Price = Conversions.ToDouble(dgvStorage[4, i].Value);
							num3++;
						}
						cItem2.Storage = array;
						if (chkAllowProcess.Checked)
						{
							cItem2.ProductionStepId = Conversions.ToInteger(cComboItem5.Value);
							num3 = 0;
							int num5 = dgvDropDownComponent.Rows.Count - 1;
							for (int i = 0; i <= num5; i++)
							{
								if (Operators.ConditionalCompareObjectEqual(dgvDropDownComponent[1, i].Value, true, TextCompare: false))
								{
									array2 = (cItemComponent[])Utils.CopyArray(array2, new cItemComponent[num3 + 1]);
									array2[num3] = new cItemComponent();
									array2[num3].ItemId = Conversions.ToInteger(dgvDropDownComponent[0, i].Value);
									num3++;
								}
							}
							cItem2.Component = array2;
							num3 = 0;
							int num6 = dgvStandardComponent.Rows.Count - 1;
							for (int i = 0; i <= num6; i++)
							{
								array3 = (cItemStandardComponent[])Utils.CopyArray(array3, new cItemStandardComponent[num3 + 1]);
								array3[num3] = new cItemStandardComponent();
								array3[num3].StorageId = Conversions.ToInteger(dgvStandardComponent[0, i].Value);
								array3[num3].ComponentId = Conversions.ToInteger(dgvStandardComponent[1, i].Value);
								array3[num3].Qty = Conversions.ToDouble(dgvStandardComponent[4, i].Value);
								num3++;
							}
							cItem2.StandardComponent = array3;
						}
						else
						{
							cItem2.ProductionStepId = 0;
						}
						num3 = 0;
						int num7 = dgvStandardUsage.Rows.Count - 1;
						for (int i = 0; i <= num7; i++)
						{
							array4 = (cItemStandardUsage[])Utils.CopyArray(array4, new cItemStandardUsage[num3 + 1]);
							array4[num3] = new cItemStandardUsage();
							array4[num3].BranchId = Conversions.ToInteger(dgvStandardUsage[0, i].Value);
							array4[num3].ComponentId = Conversions.ToInteger(dgvStandardUsage[1, i].Value);
							array4[num3].Qty = Conversions.ToDouble(dgvStandardUsage[4, i].Value);
							num3++;
						}
						cItem2.StandardUsage = array4;
						num3 = 0;
						int num8 = dgvItemGroup.Rows.Count - 1;
						for (int i = 0; i <= num8; i++)
						{
							array5 = (cItemGroup[])Utils.CopyArray(array5, new cItemGroup[num3 + 1]);
							array5[num3] = new cItemGroup();
							array5[num3].ComponentId = Conversions.ToInteger(dgvItemGroup[0, i].Value);
							array5[num3].Qty = Conversions.ToDouble(dgvItemGroup[2, i].Value);
							num3++;
						}
						cItem2.Group = array5;
						cItem2.Active = Conversions.ToInteger(cComboItem4.Value);
						cItemPurchasePrice[] array6 = new cItemPurchasePrice[dgvSupplier.Rows.Count - 1 + 1];
						int num9 = dgvSupplier.Rows.Count - 1;
						for (int i = 0; i <= num9; i++)
						{
							array6[i] = new cItemPurchasePrice(0, 0, DateAndTime.Now, 0.0, "");
							array6[i].SupplierId = Conversions.ToInteger(dgvSupplier[0, i].Value);
							array6[i].UnitNumber = Conversions.ToInteger(dgvSupplier[1, i].Value);
							array6[i].Price = Conversions.ToDouble(dgvSupplier[4, i].Value);
							array6[i].ValidFromDate = Conversions.ToDate(dgvSupplier[5, i].Value);
						}
						cItem2.PurchasePrice = array6;
						cItem2.Save();
						Cursor = Cursors.Default;
						Interaction.MsgBox("Barang berhasil disimpan", MsgBoxStyle.Information);
						if (!MyProject.Forms.frmSettingItemList.chkManual.Checked)
						{
							MyProject.Forms.frmSettingItemList.getItem();
						}
						Close();
						goto end_IL_0001_2;
					}
					case 3824:
						num = -1;
						switch (num2)
						{
						case 2:
							Cursor = Cursors.Default;
							Module1.SaveError(Information.Err(), "frmSettingItemInput", "btnSave_click", "");
							goto end_IL_0001_2;
						}
						break;
					}
					goto IL_0f26;
				}
				end_IL_0001_2:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 3824;
				continue;
			}
			break;
			IL_0f26:
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

	private void btnStandardUsage_Click(object sender, EventArgs e)
	{
		frmSettingItemStandardUsage frmSettingItemStandardUsage2 = new frmSettingItemStandardUsage(CurrentData: false);
		frmSettingItemStandardUsage2.ShowDialog();
		frmSettingItemStandardUsage2.Close();
		frmSettingItemStandardUsage2.Dispose();
	}

	private void cboItemType_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (cboItemType.SelectedIndex == 3)
		{
			chkAllowComponent.Checked = false;
			chkAllowComponent.Enabled = false;
			chkAllowEditStockQty.Checked = false;
			chkAllowEditStockQty.Enabled = false;
			chkFlower.Checked = false;
			chkFlower.Enabled = false;
			chkAllowPurchase.Checked = false;
			chkAllowPurchase.Enabled = false;
			chkAllowProcess.Checked = false;
			chkAllowProcess.Enabled = false;
		}
		else
		{
			chkAllowComponent.Enabled = true;
			chkAllowEditStockQty.Enabled = true;
			chkFlower.Enabled = true;
			chkAllowPurchase.Enabled = true;
			chkAllowProcess.Enabled = true;
		}
	}

	private void btnItemGroup_Click(object sender, EventArgs e)
	{
		frmSettingItemGroup frmSettingItemGroup2 = new frmSettingItemGroup(CurrentData: false);
		frmSettingItemGroup2.ShowDialog();
		frmSettingItemGroup2.Close();
		frmSettingItemGroup2.Dispose();
	}
}
