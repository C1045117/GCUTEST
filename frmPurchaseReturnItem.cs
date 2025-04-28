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
public class frmPurchaseReturnItem : Form
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

	private string _generalType;

	private string _longName;

	private string _packaging;

	private string _largeUnit;

	private double _unitId;

	private double _unitQty;

	private cPurchaseInvoiceItem[] _item;

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

	[field: AccessedThroughProperty("lblBaseUnit")]
	internal virtual Label lblBaseUnit
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

	public cPurchaseInvoiceItem[] item
	{
		get
		{
			return _item;
		}
		set
		{
			_item = value;
		}
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
		this.txtPrice = new GCUv2.FilteredTextBox();
		this.Label8 = new System.Windows.Forms.Label();
		this.btnDelete = new System.Windows.Forms.Button();
		this.btnSave = new System.Windows.Forms.Button();
		this.txtQty = new GCUv2.FilteredTextBox();
		this.Label6 = new System.Windows.Forms.Label();
		this.cboItem = new System.Windows.Forms.ComboBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.lblBaseUnit = new System.Windows.Forms.Label();
		this.txtStockQty = new GCUv2.FilteredTextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.cboUnit = new System.Windows.Forms.ComboBox();
		base.SuspendLayout();
		this.txtPrice.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtPrice.DontFormat = false;
		this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtPrice.Location = new System.Drawing.Point(91, 106);
		this.txtPrice.MaximumDigit = 3;
		this.txtPrice.Name = "txtPrice";
		this.txtPrice.Size = new System.Drawing.Size(139, 26);
		this.txtPrice.TabIndex = 5;
		this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.Label8.AutoSize = true;
		this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label8.Location = new System.Drawing.Point(10, 113);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(36, 13);
		this.Label8.TabIndex = 82;
		this.Label8.Text = "Harga";
		this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDelete.Location = new System.Drawing.Point(157, 138);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new System.Drawing.Size(54, 25);
		this.btnDelete.TabIndex = 76;
		this.btnDelete.Text = "Hapus";
		this.btnDelete.UseVisualStyleBackColor = true;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(91, 138);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(59, 25);
		this.btnSave.TabIndex = 75;
		this.btnSave.Text = "Simpan ";
		this.btnSave.UseVisualStyleBackColor = true;
		this.txtQty.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtQty.DontFormat = false;
		this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtQty.Location = new System.Drawing.Point(91, 39);
		this.txtQty.MaximumDigit = 3;
		this.txtQty.Name = "txtQty";
		this.txtQty.Size = new System.Drawing.Size(139, 26);
		this.txtQty.TabIndex = 2;
		this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.Location = new System.Drawing.Point(9, 15);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(41, 13);
		this.Label6.TabIndex = 78;
		this.Label6.Text = "Barang";
		this.cboItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboItem.FormattingEnabled = true;
		this.cboItem.Location = new System.Drawing.Point(91, 12);
		this.cboItem.Name = "cboItem";
		this.cboItem.Size = new System.Drawing.Size(139, 21);
		this.cboItem.TabIndex = 1;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(10, 47);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(40, 13);
		this.Label5.TabIndex = 77;
		this.Label5.Text = "Jumlah";
		this.lblBaseUnit.AutoSize = true;
		this.lblBaseUnit.Location = new System.Drawing.Point(235, 79);
		this.lblBaseUnit.Name = "lblBaseUnit";
		this.lblBaseUnit.Size = new System.Drawing.Size(53, 13);
		this.lblBaseUnit.TabIndex = 86;
		this.lblBaseUnit.Text = "Base Unit";
		this.txtStockQty.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtStockQty.DontFormat = false;
		this.txtStockQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtStockQty.Location = new System.Drawing.Point(91, 71);
		this.txtStockQty.MaximumDigit = 3;
		this.txtStockQty.Name = "txtStockQty";
		this.txtStockQty.Size = new System.Drawing.Size(139, 26);
		this.txtStockQty.TabIndex = 4;
		this.txtStockQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(10, 79);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(75, 13);
		this.Label1.TabIndex = 88;
		this.Label1.Text = "Jumlah ( stok )";
		this.cboUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboUnit.FormattingEnabled = true;
		this.cboUnit.Location = new System.Drawing.Point(234, 43);
		this.cboUnit.Name = "cboUnit";
		this.cboUnit.Size = new System.Drawing.Size(73, 21);
		this.cboUnit.TabIndex = 3;
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(312, 172);
		base.Controls.Add(this.cboUnit);
		base.Controls.Add(this.txtStockQty);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.lblBaseUnit);
		base.Controls.Add(this.txtPrice);
		base.Controls.Add(this.Label8);
		base.Controls.Add(this.btnDelete);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.txtQty);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.cboItem);
		base.Controls.Add(this.Label5);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmPurchaseReturnItem";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Barang - Input";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmPurchaseReturnItem(bool CurrentData, int SupplierId, DateTime PurchaseDate, int StorageId)
	{
		base.KeyDown += frmPurchaseReturnItem_KeyDown;
		InitializeComponent();
		_currentData = CurrentData;
		_supplierId = SupplierId;
		_purchaseDate = PurchaseDate;
		_storageId = StorageId;
		txtQty.AllowedCharacters = FilteredTextBox.InputType.NumeralsAndCurrency;
		txtPrice.AllowedCharacters = FilteredTextBox.InputType.NumeralsAndCurrency;
		txtQty.MaximumDigit = 3;
		txtPrice.MaximumDigit = 2;
		ComboBox combo = cboItem;
		cCombo.getItemAll(ref combo, 1, 99, 0, 0, 0, 0, 99, 1, 0, _supplierId, _storageId, 0, 0.0, CanBeUsedAsGroupMember: false, Module1.pubGroupId, All: false, Active: true);
		cboItem = combo;
		lblBaseUnit.Text = "";
		txtStockQty.Enabled = false;
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

	private void frmPurchaseReturnItem_KeyDown(object sender, KeyEventArgs e)
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
			_generalType = cItem2.GeneralType;
			_longName = cItem2.LongName;
			_packaging = cItem2.Packaging;
			_largeUnit = lblBaseUnit.Text;
			if (cItem2.AllowEditStockQty == -1)
			{
				txtStockQty.Enabled = true;
			}
			else
			{
				txtStockQty.Enabled = false;
			}
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
			_unitId = cItemPurchasePrice2.UnitId;
			_unitQty = cItemPurchasePrice2.UnitQty;
			lblBaseUnit.Text = cItemPurchasePrice2.BaseUnitName;
			if (price > 0.0)
			{
				txtPrice.Text = Module1.formatCustomDecimal(Conversions.ToString(price), 2);
			}
			else
			{
				txtPrice.Text = "";
			}
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
		cComboItem cComboItem3 = (cComboItem)MyProject.Forms.frmPurchaseReturn.cboStorage.SelectedItem;
		if (cboItem.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih barang.", MsgBoxStyle.Information);
			cboItem.Focus();
			return;
		}
		int itemId = default(int);
		double stockQty = default(double);
		if (!Information.IsNothing(_item))
		{
			cPurchaseInvoiceItem[] array = _item;
			foreach (cPurchaseInvoiceItem cPurchaseInvoiceItem2 in array)
			{
				if ((double)cPurchaseInvoiceItem2.ItemId == Conversions.ToDouble(cComboItem2.Value))
				{
					itemId = cPurchaseInvoiceItem2.ItemId;
					stockQty = cPurchaseInvoiceItem2.StockQty;
					break;
				}
			}
		}
		checked
		{
			int num = MyProject.Forms.frmDeliveryOrder.dgvItem.Rows.Count - 1;
			bool flag = default(bool);
			for (int j = 0; j <= num; j++)
			{
				if (Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmPurchaseReturn.dgvItem[0, j].Value, cComboItem2.Value, TextCompare: false))
				{
					if (_currentData & (j != MyProject.Forms.frmPurchaseReturn.dgvItem.CurrentRow.Index))
					{
						flag = true;
					}
					else if (!_currentData)
					{
						flag = true;
					}
				}
			}
			if (flag)
			{
				Interaction.MsgBox(cboItem.Text + " tidak bisa dipilih karena sudah dimasukkan.", MsgBoxStyle.Information);
				cboItem.Focus();
				return;
			}
			if (Conversion.Val(Module1.unformatNumber(txtQty.Text)) == 0.0)
			{
				Interaction.MsgBox("Masukkan jumlah.", MsgBoxStyle.Information);
				txtQty.Focus();
				return;
			}
			if (!Versioned.IsNumeric(txtQty.Text))
			{
				Interaction.MsgBox("Masukkan jumlah dengan format angka yang benar.", MsgBoxStyle.Information);
				txtQty.Focus();
				return;
			}
			if (!cValidation.isInStock(Module1.pubCheckStock, Module1.pubBalanceDate, MyProject.Forms.frmPurchaseReturn.dtpInvoice.Value, "not_used", MyProject.Forms.frmPurchaseReturn.OriginalDate, Conversions.ToInteger(cComboItem2.Value), itemId, Conversions.ToDouble(txtQty.Text), stockQty, Conversions.ToInteger(cComboItem3.Value), MyProject.Forms.frmPurchaseReturn.OriginalStorageId, Module1.pubGroupId, 2))
			{
				Interaction.MsgBox("Stok tidak tersedia", MsgBoxStyle.Information);
				txtQty.Focus();
				return;
			}
			cItem cItem2 = new cItem(Conversions.ToInteger(cComboItem2.Value));
			double num2 = Conversion.Val(Module1.unformatNumber(txtQty.Text)) * Conversion.Val(Module1.unformatNumber(txtPrice.Text));
			if (_currentData)
			{
				MyProject.Forms.frmPurchaseReturn.dgvItem[1, MyProject.Forms.frmPurchaseReturn.dgvItem.CurrentRow.Index].Value = cComboItem2.Value;
				MyProject.Forms.frmPurchaseReturn.dgvItem[2, MyProject.Forms.frmPurchaseReturn.dgvItem.CurrentRow.Index].Value = 0;
				MyProject.Forms.frmPurchaseReturn.dgvItem[3, MyProject.Forms.frmPurchaseReturn.dgvItem.CurrentRow.Index].Value = "";
				MyProject.Forms.frmPurchaseReturn.dgvItem[4, MyProject.Forms.frmPurchaseReturn.dgvItem.CurrentRow.Index].Value = cboItem.Text;
				MyProject.Forms.frmPurchaseReturn.dgvItem[5, MyProject.Forms.frmPurchaseReturn.dgvItem.CurrentRow.Index].Value = Module1.formatCustomDecimal(txtQty.Text, 3);
				MyProject.Forms.frmPurchaseReturn.dgvItem[6, MyProject.Forms.frmPurchaseReturn.dgvItem.CurrentRow.Index].Value = cboUnit.Text;
				MyProject.Forms.frmPurchaseReturn.dgvItem[7, MyProject.Forms.frmPurchaseReturn.dgvItem.CurrentRow.Index].Value = Module1.formatCustomDecimal(txtQty.Text, 3) + " " + cboUnit.Text;
				MyProject.Forms.frmPurchaseReturn.dgvItem[8, MyProject.Forms.frmPurchaseReturn.dgvItem.CurrentRow.Index].Value = Module1.formatCustomDecimal(txtStockQty.Text, 3);
				MyProject.Forms.frmPurchaseReturn.dgvItem[9, MyProject.Forms.frmPurchaseReturn.dgvItem.CurrentRow.Index].Value = Module1.formatCustomDecimal(txtStockQty.Text, 3) + " " + lblBaseUnit.Text;
				MyProject.Forms.frmPurchaseReturn.dgvItem[10, MyProject.Forms.frmPurchaseReturn.dgvItem.CurrentRow.Index].Value = Module1.formatCustomDecimal(txtPrice.Text, 2);
				MyProject.Forms.frmPurchaseReturn.dgvItem[11, MyProject.Forms.frmPurchaseReturn.dgvItem.CurrentRow.Index].Value = Module1.formatCustomDecimal(Conversions.ToString(num2), 2);
				MyProject.Forms.frmPurchaseReturn.dgvItem[12, MyProject.Forms.frmPurchaseReturn.dgvItem.CurrentRow.Index].Value = _generalType;
				MyProject.Forms.frmPurchaseReturn.dgvItem[13, MyProject.Forms.frmPurchaseReturn.dgvItem.CurrentRow.Index].Value = _longName;
				MyProject.Forms.frmPurchaseReturn.dgvItem[14, MyProject.Forms.frmPurchaseReturn.dgvItem.CurrentRow.Index].Value = _packaging;
				MyProject.Forms.frmPurchaseReturn.dgvItem[15, MyProject.Forms.frmPurchaseReturn.dgvItem.CurrentRow.Index].Value = _largeUnit;
			}
			else
			{
				MyProject.Forms.frmPurchaseReturn.dgvItem.Rows.Add(0, cComboItem2.Value, 0, "", cboItem.Text, Module1.formatCustomDecimal(txtQty.Text, 3), cboUnit.Text, Module1.formatCustomDecimal(txtQty.Text, 3) + " " + cboUnit.Text, Module1.formatCustomDecimal(txtStockQty.Text, 3), Module1.formatCustomDecimal(txtStockQty.Text, 3) + " " + lblBaseUnit.Text, Module1.formatCustomDecimal(txtPrice.Text, 2), Module1.formatCustomDecimal(Conversions.ToString(num2), 2), _generalType, _longName, _packaging, _largeUnit);
				MyProject.Forms.frmPurchaseReturn.dgvItem.CurrentRow.Selected = false;
			}
			MyProject.Forms.frmPurchaseReturn.calculateTotalPrice();
			MyProject.Forms.frmPurchaseReturn.Edited = true;
			Close();
		}
	}

	private void btnDelete_Click(object sender, EventArgs e)
	{
		MyProject.Forms.frmPurchaseReturn.dgvItem.Rows.RemoveAt(MyProject.Forms.frmPurchaseReturn.dgvItem.CurrentRow.Index);
		MyProject.Forms.frmPurchaseReturn.calculateTotalPrice();
		MyProject.Forms.frmPurchaseReturn.Edited = true;
		Close();
	}
}
