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
public class frmPurchaseInvoiceItem : Form
{
	private IContainer components;

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
	[AccessedThroughProperty("txtQty")]
	private FilteredTextBox _txtQty;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboItem")]
	private ComboBox _cboItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboUnit")]
	private ComboBox _cboUnit;

	private bool _currentData;

	private int _supplierId;

	private int _storageId;

	private DateTime _purchaseDate;

	private bool _AllowEditStockQty;

	private double _unitId;

	private double _unitQty;

	private int _inventoryAccountId;

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

	internal virtual FilteredTextBox txtQty
	{
		[CompilerGenerated]
		get
		{
			return _txtQty;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = txtQty_TextChanged;
			FilteredTextBox filteredTextBox = _txtQty;
			if (filteredTextBox != null)
			{
				filteredTextBox.TextChanged -= value2;
			}
			_txtQty = value;
			filteredTextBox = _txtQty;
			if (filteredTextBox != null)
			{
				filteredTextBox.TextChanged += value2;
			}
		}
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

	[field: AccessedThroughProperty("txtStockQty")]
	internal virtual FilteredTextBox txtStockQty
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

	[field: AccessedThroughProperty("txtDeduction")]
	internal virtual FilteredTextBox txtDeduction
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

	[field: AccessedThroughProperty("txtParkedQty")]
	internal virtual FilteredTextBox txtParkedQty
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

	[field: AccessedThroughProperty("txtExtraPrice")]
	internal virtual FilteredTextBox txtExtraPrice
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

	[field: AccessedThroughProperty("txtPrice")]
	internal virtual FilteredTextBox txtPrice
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

	[field: AccessedThroughProperty("lblBaseUnit")]
	internal virtual Label lblBaseUnit
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox cboUnit
	{
		[CompilerGenerated]
		get
		{
			return _cboUnit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cboUnit_SelectedIndexChanged;
			ComboBox comboBox = _cboUnit;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_cboUnit = value;
			comboBox = _cboUnit;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("rtxDescription")]
	internal virtual RichTextBox rtxDescription
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label26")]
	internal virtual Label Label26
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public int SupplierId
	{
		get
		{
			return _supplierId;
		}
		set
		{
			_supplierId = value;
		}
	}

	public int StorageId
	{
		get
		{
			return _storageId;
		}
		set
		{
			_storageId = value;
		}
	}

	public DateTime PurchaseDate
	{
		get
		{
			return _purchaseDate;
		}
		set
		{
			_purchaseDate = value;
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
		this.btnDelete = new System.Windows.Forms.Button();
		this.btnSave = new System.Windows.Forms.Button();
		this.Label6 = new System.Windows.Forms.Label();
		this.cboItem = new System.Windows.Forms.ComboBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.txtExtraPrice = new GCUv2.FilteredTextBox();
		this.txtPrice = new GCUv2.FilteredTextBox();
		this.txtDeduction = new GCUv2.FilteredTextBox();
		this.txtParkedQty = new GCUv2.FilteredTextBox();
		this.txtStockQty = new GCUv2.FilteredTextBox();
		this.txtQty = new GCUv2.FilteredTextBox();
		this.lblBaseUnit = new System.Windows.Forms.Label();
		this.cboUnit = new System.Windows.Forms.ComboBox();
		this.rtxDescription = new System.Windows.Forms.RichTextBox();
		this.Label26 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDelete.Location = new System.Drawing.Point(177, 301);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new System.Drawing.Size(54, 25);
		this.btnDelete.TabIndex = 22;
		this.btnDelete.Text = "Hapus";
		this.btnDelete.UseVisualStyleBackColor = true;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(111, 301);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(59, 25);
		this.btnSave.TabIndex = 21;
		this.btnSave.Text = "Simpan ";
		this.btnSave.UseVisualStyleBackColor = true;
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.Location = new System.Drawing.Point(15, 15);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(41, 13);
		this.Label6.TabIndex = 54;
		this.Label6.Text = "Barang";
		this.cboItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboItem.FormattingEnabled = true;
		this.cboItem.Location = new System.Drawing.Point(111, 12);
		this.cboItem.Name = "cboItem";
		this.cboItem.Size = new System.Drawing.Size(139, 21);
		this.cboItem.TabIndex = 1;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(16, 113);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(40, 13);
		this.Label5.TabIndex = 53;
		this.Label5.Text = "Jumlah";
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(16, 145);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(75, 13);
		this.Label1.TabIndex = 56;
		this.Label1.Text = "Jumlah ( stok )";
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(16, 209);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(70, 13);
		this.Label2.TabIndex = 60;
		this.Label2.Text = "Potongan (%)";
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(16, 177);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(34, 13);
		this.Label3.TabIndex = 58;
		this.Label3.Text = "Parkir";
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.Location = new System.Drawing.Point(16, 274);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(86, 13);
		this.Label7.TabIndex = 64;
		this.Label7.Text = "Harga tambahan";
		this.Label8.AutoSize = true;
		this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label8.Location = new System.Drawing.Point(16, 242);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(36, 13);
		this.Label8.TabIndex = 62;
		this.Label8.Text = "Harga";
		this.txtExtraPrice.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtExtraPrice.DontFormat = false;
		this.txtExtraPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtExtraPrice.Location = new System.Drawing.Point(111, 267);
		this.txtExtraPrice.MaximumDigit = 3;
		this.txtExtraPrice.Name = "txtExtraPrice";
		this.txtExtraPrice.Size = new System.Drawing.Size(139, 26);
		this.txtExtraPrice.TabIndex = 9;
		this.txtExtraPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.txtPrice.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtPrice.DontFormat = false;
		this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtPrice.Location = new System.Drawing.Point(111, 235);
		this.txtPrice.MaximumDigit = 3;
		this.txtPrice.Name = "txtPrice";
		this.txtPrice.Size = new System.Drawing.Size(139, 26);
		this.txtPrice.TabIndex = 8;
		this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.txtDeduction.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtDeduction.DontFormat = false;
		this.txtDeduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtDeduction.Location = new System.Drawing.Point(111, 201);
		this.txtDeduction.MaximumDigit = 3;
		this.txtDeduction.Name = "txtDeduction";
		this.txtDeduction.Size = new System.Drawing.Size(139, 26);
		this.txtDeduction.TabIndex = 7;
		this.txtDeduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.txtParkedQty.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtParkedQty.DontFormat = false;
		this.txtParkedQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtParkedQty.Location = new System.Drawing.Point(111, 169);
		this.txtParkedQty.MaximumDigit = 3;
		this.txtParkedQty.Name = "txtParkedQty";
		this.txtParkedQty.Size = new System.Drawing.Size(139, 26);
		this.txtParkedQty.TabIndex = 6;
		this.txtParkedQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.txtStockQty.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtStockQty.DontFormat = false;
		this.txtStockQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtStockQty.Location = new System.Drawing.Point(111, 137);
		this.txtStockQty.MaximumDigit = 3;
		this.txtStockQty.Name = "txtStockQty";
		this.txtStockQty.Size = new System.Drawing.Size(139, 26);
		this.txtStockQty.TabIndex = 5;
		this.txtStockQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.txtQty.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtQty.DontFormat = false;
		this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtQty.Location = new System.Drawing.Point(111, 105);
		this.txtQty.MaximumDigit = 3;
		this.txtQty.Name = "txtQty";
		this.txtQty.Size = new System.Drawing.Size(139, 26);
		this.txtQty.TabIndex = 3;
		this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.lblBaseUnit.AutoSize = true;
		this.lblBaseUnit.Location = new System.Drawing.Point(256, 145);
		this.lblBaseUnit.Name = "lblBaseUnit";
		this.lblBaseUnit.Size = new System.Drawing.Size(53, 13);
		this.lblBaseUnit.TabIndex = 68;
		this.lblBaseUnit.Text = "Base Unit";
		this.cboUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboUnit.FormattingEnabled = true;
		this.cboUnit.Location = new System.Drawing.Point(256, 108);
		this.cboUnit.Name = "cboUnit";
		this.cboUnit.Size = new System.Drawing.Size(73, 21);
		this.cboUnit.TabIndex = 4;
		this.rtxDescription.Location = new System.Drawing.Point(111, 39);
		this.rtxDescription.MaxLength = 100;
		this.rtxDescription.Name = "rtxDescription";
		this.rtxDescription.Size = new System.Drawing.Size(139, 60);
		this.rtxDescription.TabIndex = 2;
		this.rtxDescription.Text = "";
		this.Label26.AutoSize = true;
		this.Label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label26.Location = new System.Drawing.Point(15, 39);
		this.Label26.Name = "Label26";
		this.Label26.Size = new System.Drawing.Size(50, 13);
		this.Label26.TabIndex = 145;
		this.Label26.Text = "Deskripsi";
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(342, 338);
		base.Controls.Add(this.rtxDescription);
		base.Controls.Add(this.Label26);
		base.Controls.Add(this.cboUnit);
		base.Controls.Add(this.lblBaseUnit);
		base.Controls.Add(this.txtExtraPrice);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.txtPrice);
		base.Controls.Add(this.Label8);
		base.Controls.Add(this.txtDeduction);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.txtParkedQty);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.txtStockQty);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.btnDelete);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.txtQty);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.cboItem);
		base.Controls.Add(this.Label5);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "frmPurchaseInvoiceItem";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Barang";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmPurchaseInvoiceItem(bool CurrentData, int SupplierId, DateTime PurchaseDate, int StorageId)
	{
		base.KeyDown += frmPurchaseInvoiceItem_KeyDown;
		InitializeComponent();
		DoubleBuffered = true;
		_currentData = CurrentData;
		_supplierId = SupplierId;
		_purchaseDate = PurchaseDate;
		_storageId = StorageId;
		txtQty.AllowedCharacters = FilteredTextBox.InputType.NumeralsAndCurrency;
		txtStockQty.AllowedCharacters = FilteredTextBox.InputType.NumeralsAndCurrency;
		txtParkedQty.AllowedCharacters = FilteredTextBox.InputType.NumeralsAndCurrency;
		txtDeduction.AllowedCharacters = FilteredTextBox.InputType.NumeralsAndCurrency;
		txtDeduction.MaximumDigit = 0;
		txtPrice.AllowedCharacters = FilteredTextBox.InputType.NumeralsAndCurrency;
		txtPrice.MaximumDigit = 2;
		txtExtraPrice.AllowedCharacters = FilteredTextBox.InputType.NumeralsAndCurrency;
		txtExtraPrice.MaximumDigit = 2;
		ComboBox combo = cboItem;
		cCombo.getItemAll(ref combo, 1, 99, 0, 0, 0, 0, 99, 0, 0, _supplierId, _storageId, 0, 0.0, CanBeUsedAsGroupMember: false, Module1.pubGroupId, All: false, Active: true);
		cboItem = combo;
		lblBaseUnit.Text = "";
		if (_currentData)
		{
			btnSave.Text = "Update";
			btnDelete.Enabled = true;
		}
		else
		{
			btnSave.Text = "Tambah";
			btnDelete.Enabled = false;
		}
	}

	private void frmPurchaseInvoiceItem_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void cboItem_SelectedIndexChanged(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboItem.SelectedItem;
		if (cboItem.SelectedIndex > -1)
		{
			ComboBox combo = cboUnit;
			cCombo.getItemUnit(ref combo, Conversions.ToInteger(cComboItem2.Value), _supplierId, blnAll: false);
			cboUnit = combo;
			cboUnit.SelectedIndex = 0;
			cItem cItem2 = new cItem(Conversions.ToInteger(cComboItem2.Value));
			_inventoryAccountId = cItem2.InventoryAccountId;
			if (cItem2.TypeId == 3)
			{
				rtxDescription.Enabled = true;
			}
			else
			{
				rtxDescription.Text = "";
				rtxDescription.Enabled = false;
			}
			_AllowEditStockQty = cItem2.AllowEditStockQty != 0;
			if (cItem2.AllowEditStockQty == -1)
			{
				txtStockQty.Enabled = true;
			}
			else
			{
				txtStockQty.Text = "";
				txtStockQty.Enabled = false;
			}
			if (cItem2.HasParkedQty == -1)
			{
				txtParkedQty.Enabled = true;
			}
			else
			{
				txtParkedQty.Text = "";
				txtParkedQty.Enabled = false;
			}
			if (cItem2.HasDeduction == -1)
			{
				txtDeduction.Enabled = true;
			}
			else
			{
				txtDeduction.Text = "";
				txtDeduction.Enabled = false;
			}
			if (cItem2.HasExtraPrice == -1)
			{
				txtExtraPrice.Enabled = true;
				return;
			}
			txtExtraPrice.Text = "";
			txtExtraPrice.Enabled = false;
		}
	}

	private void cboUnit_SelectedIndexChanged(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboItem.SelectedItem;
		cComboItem cComboItem3 = (cComboItem)cboUnit.SelectedItem;
		if ((cboItem.SelectedIndex > -1) & (cboUnit.SelectedIndex > -1))
		{
			cItemPurchasePrice cItemPurchasePrice2 = new cItemPurchasePrice(Conversions.ToInteger(cComboItem2.Value), _supplierId, _purchaseDate, Conversions.ToDouble(cComboItem3.Value), "");
			double price = cItemPurchasePrice2.Price;
			if (price > 0.0)
			{
				txtPrice.Text = Module1.formatCustomDecimal(Conversions.ToString(price), 2);
			}
			else
			{
				txtPrice.Text = "";
			}
			_unitId = cItemPurchasePrice2.UnitId;
			_unitQty = cItemPurchasePrice2.UnitQty;
			lblBaseUnit.Text = cItemPurchasePrice2.BaseUnitName;
			if (Operators.CompareString(cboUnit.Text, "", TextCompare: false) == 0)
			{
				ComboBox cboSource = cboUnit;
				Module1.comboBoundValue(ref cboSource, cItemPurchasePrice2.UnitId);
				cboUnit = cboSource;
			}
			if (Operators.CompareString(txtQty.Text, "", TextCompare: false) != 0)
			{
				txtStockQty.Text = Module1.formatCustomDecimal(Conversions.ToString(Conversions.ToDouble(txtQty.Text) * _unitQty), 3);
			}
			else
			{
				txtStockQty.Text = "0";
			}
		}
	}

	private void txtQty_TextChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(txtQty.Text, "", TextCompare: false) != 0)
		{
			txtStockQty.Text = Module1.formatCustomDecimal(Conversions.ToString(Conversions.ToDouble(txtQty.Text) * _unitQty), 3);
		}
		else
		{
			txtStockQty.Text = "0";
		}
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboItem.SelectedItem;
		cComboItem cComboItem3 = (cComboItem)cboUnit.SelectedItem;
		if (cboItem.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih produk", MsgBoxStyle.Information);
			cboItem.Focus();
			return;
		}
		if (rtxDescription.Enabled & (Operators.CompareString(rtxDescription.Text, "", TextCompare: false) == 0))
		{
			Interaction.MsgBox("Masukkan deskripsi jasa.", MsgBoxStyle.Information);
			rtxDescription.Focus();
			return;
		}
		if (cboUnit.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih satuan.", MsgBoxStyle.Information);
			cboUnit.Focus();
			return;
		}
		if (Conversion.Val(Module1.unformatNumber(txtQty.Text)) == 0.0)
		{
			Interaction.MsgBox("Masukkan jumlah", MsgBoxStyle.Information);
			txtQty.Focus();
			return;
		}
		if (!Versioned.IsNumeric(txtQty.Text))
		{
			Interaction.MsgBox("Masukkan jumlah dengan format angka yang benar", MsgBoxStyle.Information);
			txtQty.Focus();
			return;
		}
		if (Conversion.Val(Module1.unformatNumber(txtStockQty.Text)) == 0.0)
		{
			Interaction.MsgBox("Masukkan jumlah(stok)", MsgBoxStyle.Information);
			txtStockQty.Focus();
			return;
		}
		if (!Versioned.IsNumeric(txtStockQty.Text))
		{
			Interaction.MsgBox("Masukkan jumlah(stok) dengan format angka yang benar", MsgBoxStyle.Information);
			txtStockQty.Focus();
			return;
		}
		cItem cItem2 = new cItem(Conversions.ToInteger(cComboItem2.Value));
		double num = Conversion.Val(Module1.unformatNumber(txtQty.Text)) - Conversion.Val(Module1.unformatNumber(txtParkedQty.Text));
		double num2 = num - num / 100.0 * Conversion.Val(Module1.unformatNumber(txtDeduction.Text));
		double num3 = num2 * (Conversion.Val(Module1.unformatNumber(Module1.formatCustomDecimal(txtPrice.Text, 2))) + Conversion.Val(Module1.unformatNumber(Module1.formatCustomDecimal(txtExtraPrice.Text, 2))));
		if (_currentData)
		{
			MyProject.Forms.frmPurchaseInvoice.dgvItem[1, MyProject.Forms.frmPurchaseInvoice.dgvItem.CurrentRow.Index].Value = cComboItem2.Value;
			MyProject.Forms.frmPurchaseInvoice.dgvItem[2, MyProject.Forms.frmPurchaseInvoice.dgvItem.CurrentRow.Index].Value = 0;
			MyProject.Forms.frmPurchaseInvoice.dgvItem[3, MyProject.Forms.frmPurchaseInvoice.dgvItem.CurrentRow.Index].Value = "";
			MyProject.Forms.frmPurchaseInvoice.dgvItem[4, MyProject.Forms.frmPurchaseInvoice.dgvItem.CurrentRow.Index].Value = cboItem.Text;
			MyProject.Forms.frmPurchaseInvoice.dgvItem[5, MyProject.Forms.frmPurchaseInvoice.dgvItem.CurrentRow.Index].Value = rtxDescription.Text;
			MyProject.Forms.frmPurchaseInvoice.dgvItem[6, MyProject.Forms.frmPurchaseInvoice.dgvItem.CurrentRow.Index].Value = Module1.formatCustomDecimal(txtQty.Text, 3);
			MyProject.Forms.frmPurchaseInvoice.dgvItem[7, MyProject.Forms.frmPurchaseInvoice.dgvItem.CurrentRow.Index].Value = cboUnit.Text;
			MyProject.Forms.frmPurchaseInvoice.dgvItem[8, MyProject.Forms.frmPurchaseInvoice.dgvItem.CurrentRow.Index].Value = Module1.formatCustomDecimal(txtQty.Text, 3) + " " + cboUnit.Text;
			MyProject.Forms.frmPurchaseInvoice.dgvItem[9, MyProject.Forms.frmPurchaseInvoice.dgvItem.CurrentRow.Index].Value = Module1.formatCustomDecimal(txtStockQty.Text, 3);
			MyProject.Forms.frmPurchaseInvoice.dgvItem[10, MyProject.Forms.frmPurchaseInvoice.dgvItem.CurrentRow.Index].Value = Module1.formatCustomDecimal(txtStockQty.Text, 3) + " " + lblBaseUnit.Text;
			MyProject.Forms.frmPurchaseInvoice.dgvItem[11, MyProject.Forms.frmPurchaseInvoice.dgvItem.CurrentRow.Index].Value = Module1.formatCustomDecimal(txtParkedQty.Text, 3);
			MyProject.Forms.frmPurchaseInvoice.dgvItem[12, MyProject.Forms.frmPurchaseInvoice.dgvItem.CurrentRow.Index].Value = Module1.formatCustomDecimal(Conversions.ToString(Conversion.Val(Module1.unformatNumber(txtDeduction.Text))), 0);
			MyProject.Forms.frmPurchaseInvoice.dgvItem[13, MyProject.Forms.frmPurchaseInvoice.dgvItem.CurrentRow.Index].Value = Module1.formatCustomDecimal(Conversions.ToString(num2), 3);
			MyProject.Forms.frmPurchaseInvoice.dgvItem[14, MyProject.Forms.frmPurchaseInvoice.dgvItem.CurrentRow.Index].Value = Module1.formatCustomDecimal(txtPrice.Text, 2);
			MyProject.Forms.frmPurchaseInvoice.dgvItem[15, MyProject.Forms.frmPurchaseInvoice.dgvItem.CurrentRow.Index].Value = Module1.formatCustomDecimal(txtExtraPrice.Text, 2);
			MyProject.Forms.frmPurchaseInvoice.dgvItem[16, MyProject.Forms.frmPurchaseInvoice.dgvItem.CurrentRow.Index].Value = Module1.formatCustomDecimal(Conversions.ToString(num3), 2);
			MyProject.Forms.frmPurchaseInvoice.dgvItem[20, MyProject.Forms.frmPurchaseInvoice.dgvItem.CurrentRow.Index].Value = _inventoryAccountId;
		}
		else
		{
			MyProject.Forms.frmPurchaseInvoice.dgvItem.Rows.Add(0, cComboItem2.Value, 0, "", cboItem.Text, rtxDescription.Text, Module1.formatCustomDecimal(txtQty.Text, 3), cboUnit.Text, Module1.formatCustomDecimal(txtQty.Text, 3) + " " + cboUnit.Text, Module1.formatCustomDecimal(txtStockQty.Text, 3), Module1.formatCustomDecimal(txtStockQty.Text, 3) + " " + lblBaseUnit.Text, Module1.formatCustomDecimal(txtParkedQty.Text, 3), Module1.formatCustomDecimal(Conversions.ToString(Conversion.Val(Module1.unformatNumber(txtDeduction.Text))), 0), Module1.formatCustomDecimal(Conversions.ToString(num2), 3), Module1.formatCustomDecimal(txtPrice.Text, 2), Module1.formatCustomDecimal(txtExtraPrice.Text, 2), Module1.formatCustomDecimal(Conversions.ToString(num3), 2), "", 0, 0, _inventoryAccountId);
			MyProject.Forms.frmPurchaseInvoice.dgvItem.CurrentRow.Selected = false;
		}
		MyProject.Forms.frmPurchaseInvoice.calculateTotalPrice();
		Close();
	}

	private void btnDelete_Click(object sender, EventArgs e)
	{
		MyProject.Forms.frmPurchaseInvoice.dgvItem.Rows.RemoveAt(MyProject.Forms.frmPurchaseInvoice.dgvItem.CurrentRow.Index);
		MyProject.Forms.frmPurchaseInvoice.calculateTotalPrice();
		Close();
	}
}
