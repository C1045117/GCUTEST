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
public class frmSalesInvoiceItem : Form
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
	[AccessedThroughProperty("cboItem")]
	private ComboBox _cboItem;

	private bool _currentData;

	private double _customerId;

	private double _basePrice;

	private cSalesInvoiceItem[] _item;

	private bool _isGroup;

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

	public cSalesInvoiceItem[] Item
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
		this.rtxDescription = new System.Windows.Forms.RichTextBox();
		this.Label26 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.txtPrice.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtPrice.DontFormat = false;
		this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtPrice.Location = new System.Drawing.Point(77, 137);
		this.txtPrice.MaximumDigit = 3;
		this.txtPrice.Name = "txtPrice";
		this.txtPrice.Size = new System.Drawing.Size(139, 26);
		this.txtPrice.TabIndex = 3;
		this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.Label8.AutoSize = true;
		this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label8.Location = new System.Drawing.Point(12, 144);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(36, 13);
		this.Label8.TabIndex = 82;
		this.Label8.Text = "Harga";
		this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDelete.Location = new System.Drawing.Point(143, 169);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new System.Drawing.Size(54, 25);
		this.btnDelete.TabIndex = 11;
		this.btnDelete.Text = "Hapus";
		this.btnDelete.UseVisualStyleBackColor = true;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(77, 169);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(59, 25);
		this.btnSave.TabIndex = 10;
		this.btnSave.Text = "Simpan ";
		this.btnSave.UseVisualStyleBackColor = true;
		this.txtQty.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtQty.DontFormat = false;
		this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtQty.Location = new System.Drawing.Point(77, 105);
		this.txtQty.MaximumDigit = 3;
		this.txtQty.Name = "txtQty";
		this.txtQty.Size = new System.Drawing.Size(139, 26);
		this.txtQty.TabIndex = 2;
		this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.Location = new System.Drawing.Point(11, 15);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(41, 13);
		this.Label6.TabIndex = 78;
		this.Label6.Text = "Barang";
		this.cboItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboItem.FormattingEnabled = true;
		this.cboItem.Location = new System.Drawing.Point(77, 12);
		this.cboItem.Name = "cboItem";
		this.cboItem.Size = new System.Drawing.Size(139, 21);
		this.cboItem.TabIndex = 0;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(12, 113);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(40, 13);
		this.Label5.TabIndex = 77;
		this.Label5.Text = "Jumlah";
		this.rtxDescription.Location = new System.Drawing.Point(77, 39);
		this.rtxDescription.MaxLength = 100;
		this.rtxDescription.Name = "rtxDescription";
		this.rtxDescription.Size = new System.Drawing.Size(139, 60);
		this.rtxDescription.TabIndex = 1;
		this.rtxDescription.Text = "";
		this.Label26.AutoSize = true;
		this.Label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label26.Location = new System.Drawing.Point(11, 39);
		this.Label26.Name = "Label26";
		this.Label26.Size = new System.Drawing.Size(50, 13);
		this.Label26.TabIndex = 143;
		this.Label26.Text = "Deskripsi";
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(228, 203);
		base.Controls.Add(this.rtxDescription);
		base.Controls.Add(this.Label26);
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
		base.Name = "frmSalesInvoiceItem";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Barang - Input";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmSalesInvoiceItem(bool CurrentData, double CustomerId, int StorageId)
	{
		base.KeyDown += frmSalesInvoiceItem_KeyDown;
		InitializeComponent();
		DoubleBuffered = true;
		_currentData = CurrentData;
		_customerId = CustomerId;
		txtQty.AllowedCharacters = FilteredTextBox.InputType.NumeralsAndCurrency;
		txtPrice.AllowedCharacters = FilteredTextBox.InputType.NumeralsAndCurrency;
		ComboBox combo = cboItem;
		cCombo.getItemAll(ref combo, 99, 99, 0, 0, 0, 0, 1, 0, 0, 0, StorageId, 0, _customerId, CanBeUsedAsGroupMember: false, Module1.pubGroupId, All: false, Active: true);
		cboItem = combo;
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
		if (Module1.pubModifyPriceInSalesInvoice)
		{
			txtPrice.Enabled = true;
		}
		else
		{
			txtPrice.Enabled = false;
		}
	}

	private void frmSalesInvoiceItem_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		int itemId = default(int);
		double qty = default(double);
		bool flag = default(bool);
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
						cComboItem cComboItem2 = (cComboItem)cboItem.SelectedItem;
						cComboItem cComboItem3 = (cComboItem)MyProject.Forms.frmSalesInvoice.cboStorage.SelectedItem;
						if (cboItem.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih barang", MsgBoxStyle.Information);
							cboItem.Focus();
							goto end_IL_0001;
						}
						if (rtxDescription.Enabled & (Operators.CompareString(rtxDescription.Text, "", TextCompare: false) == 0))
						{
							Interaction.MsgBox("Masukkan deskripsi jasa.", MsgBoxStyle.Information);
							rtxDescription.Focus();
							goto end_IL_0001;
						}
						if (!Information.IsNothing(_item))
						{
							cSalesInvoiceItem[] item = _item;
							foreach (cSalesInvoiceItem cSalesInvoiceItem2 in item)
							{
								if ((double)cSalesInvoiceItem2.ItemId == Conversions.ToDouble(cComboItem2.Value))
								{
									itemId = cSalesInvoiceItem2.ItemId;
									qty = cSalesInvoiceItem2.Qty;
									break;
								}
							}
						}
						int num3 = MyProject.Forms.frmSalesInvoice.dgvItem.Rows.Count - 1;
						for (int j = 0; j <= num3; j++)
						{
							if (Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmSalesInvoice.dgvItem[0, j].Value, cComboItem2.Value, TextCompare: false))
							{
								if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(_currentData & (j != MyProject.Forms.frmSalesInvoice.dgvItem.CurrentRow.Index), Operators.CompareObjectEqual(MyProject.Forms.frmSalesInvoice.dgvItem[16, MyProject.Forms.frmSalesInvoice.dgvItem.CurrentRow.Index].Value, 0, TextCompare: false)), Operators.CompareObjectEqual(MyProject.Forms.frmSalesInvoice.dgvItem[17, MyProject.Forms.frmSalesInvoice.dgvItem.CurrentRow.Index].Value, 0, TextCompare: false)), Operators.CompareObjectEqual(MyProject.Forms.frmSalesInvoice.dgvItem[18, MyProject.Forms.frmSalesInvoice.dgvItem.CurrentRow.Index].Value, 0, TextCompare: false))))
								{
									flag = true;
								}
								else if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(!_currentData, Operators.CompareObjectEqual(MyProject.Forms.frmSalesInvoice.dgvItem[16, MyProject.Forms.frmSalesInvoice.dgvItem.CurrentRow.Index].Value, 0, TextCompare: false)), Operators.CompareObjectEqual(MyProject.Forms.frmSalesInvoice.dgvItem[17, MyProject.Forms.frmSalesInvoice.dgvItem.CurrentRow.Index].Value, 0, TextCompare: false)), Operators.CompareObjectEqual(MyProject.Forms.frmSalesInvoice.dgvItem[18, MyProject.Forms.frmSalesInvoice.dgvItem.CurrentRow.Index].Value, 0, TextCompare: false))))
								{
									flag = true;
								}
							}
						}
						if (flag & !rtxDescription.Enabled)
						{
							Interaction.MsgBox(cboItem.Text + " tidak bisa dipilih karena sudah dimasukkan.", MsgBoxStyle.Information);
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
						if (!cValidation.isInStock(Module1.pubCheckStock, Module1.pubBalanceDate, MyProject.Forms.frmSalesInvoice.dtpInvoice.Value, "not_used", MyProject.Forms.frmSalesInvoice.OriginalDate, Conversions.ToInteger(cComboItem2.Value), itemId, Conversions.ToDouble(txtQty.Text), qty, Conversions.ToInteger(cComboItem3.Value), MyProject.Forms.frmSalesInvoice.OriginalStorageId, Module1.pubGroupId, 2))
						{
							Interaction.MsgBox("Stok tidak tersedia", MsgBoxStyle.Information);
							txtQty.Focus();
							goto end_IL_0001;
						}
						if (Operators.CompareString(txtPrice.Text, "", TextCompare: false) == 0)
						{
							Interaction.MsgBox("Masukkan harga.", MsgBoxStyle.Information);
							txtPrice.Focus();
							goto end_IL_0001;
						}
						if (!Versioned.IsNumeric(txtPrice.Text))
						{
							Interaction.MsgBox("Masukkan harga dengan format angka yang benar", MsgBoxStyle.Information);
							txtPrice.Focus();
							goto end_IL_0001;
						}
						cItemPrintDetail cItemPrintDetail2 = new cItemPrintDetail(Conversions.ToInteger(cComboItem2.Value));
						if (_currentData)
						{
							MyProject.Forms.frmSalesInvoice.dgvItem[0, MyProject.Forms.frmSalesInvoice.dgvItem.CurrentRow.Index].Value = cComboItem2.Value;
							MyProject.Forms.frmSalesInvoice.dgvItem[1, MyProject.Forms.frmSalesInvoice.dgvItem.CurrentRow.Index].Value = Module1.cleanString(cboItem.Text);
							MyProject.Forms.frmSalesInvoice.dgvItem[2, MyProject.Forms.frmSalesInvoice.dgvItem.CurrentRow.Index].Value = rtxDescription.Text;
							MyProject.Forms.frmSalesInvoice.dgvItem[3, MyProject.Forms.frmSalesInvoice.dgvItem.CurrentRow.Index].Value = Module1.formatCustomDecimal(txtQty.Text, 3);
							MyProject.Forms.frmSalesInvoice.dgvItem[4, MyProject.Forms.frmSalesInvoice.dgvItem.CurrentRow.Index].Value = Module1.formatCustomDecimal(txtPrice.Text, 2);
							MyProject.Forms.frmSalesInvoice.dgvItem[5, MyProject.Forms.frmSalesInvoice.dgvItem.CurrentRow.Index].Value = Module1.formatCustomDecimal(Conversions.ToString(Conversions.ToDouble(txtQty.Text) * Conversions.ToDouble(txtPrice.Text)), 2);
							MyProject.Forms.frmSalesInvoice.dgvItem[6, MyProject.Forms.frmSalesInvoice.dgvItem.CurrentRow.Index].Value = _basePrice;
							MyProject.Forms.frmSalesInvoice.dgvItem[7, MyProject.Forms.frmSalesInvoice.dgvItem.CurrentRow.Index].Value = Conversions.ToDouble(txtQty.Text) * _basePrice;
							MyProject.Forms.frmSalesInvoice.dgvItem[8, MyProject.Forms.frmSalesInvoice.dgvItem.CurrentRow.Index].Value = cItemPrintDetail2.GeneralType;
							MyProject.Forms.frmSalesInvoice.dgvItem[9, MyProject.Forms.frmSalesInvoice.dgvItem.CurrentRow.Index].Value = cItemPrintDetail2.LongName;
							MyProject.Forms.frmSalesInvoice.dgvItem[10, MyProject.Forms.frmSalesInvoice.dgvItem.CurrentRow.Index].Value = cItemPrintDetail2.Packaging;
							MyProject.Forms.frmSalesInvoice.dgvItem[11, MyProject.Forms.frmSalesInvoice.dgvItem.CurrentRow.Index].Value = cItemPrintDetail2.SmallUnit;
							MyProject.Forms.frmSalesInvoice.dgvItem[12, MyProject.Forms.frmSalesInvoice.dgvItem.CurrentRow.Index].Value = cItemPrintDetail2.SmallQtyMultiplier;
							MyProject.Forms.frmSalesInvoice.dgvItem[13, MyProject.Forms.frmSalesInvoice.dgvItem.CurrentRow.Index].Value = cItemPrintDetail2.LargeUnit;
							DeleteComponent();
						}
						else
						{
							MyProject.Forms.frmSalesInvoice.dgvItem.Rows.Add(cComboItem2.Value, cboItem.Text, Module1.cleanString(rtxDescription.Text), Module1.formatCustomDecimal(txtQty.Text, 3), Module1.formatCustomDecimal(txtPrice.Text, 2), Module1.formatCustomDecimal(Conversions.ToString(Conversions.ToDouble(txtQty.Text) * Conversions.ToDouble(txtPrice.Text)), 2), _basePrice, Conversions.ToDouble(txtQty.Text) * _basePrice, cItemPrintDetail2.GeneralType, cItemPrintDetail2.LongName, cItemPrintDetail2.Packaging, cItemPrintDetail2.SmallUnit, cItemPrintDetail2.SmallQtyMultiplier, cItemPrintDetail2.LargeUnit);
							MyProject.Forms.frmSalesInvoice.dgvItem.CurrentRow.Selected = false;
						}
						if (_isGroup)
						{
							int j = MyProject.Forms.frmSalesInvoice.dgvItem.CurrentRow.Index + 1;
							cItem cItem2 = new cItem(Conversions.ToInteger(cComboItem2.Value));
							cItemGroup[] group = cItem2.Group;
							foreach (cItemGroup cItemGroup2 in group)
							{
								if (!Information.IsNothing(_item))
								{
									cSalesInvoiceItem[] item2 = _item;
									foreach (cSalesInvoiceItem cSalesInvoiceItem3 in item2)
									{
										if ((cSalesInvoiceItem3.ItemId == cItemGroup2.ComponentId) & ((double)cSalesInvoiceItem3.ParentItemId == Conversions.ToDouble(cComboItem2.Value)))
										{
											qty = cSalesInvoiceItem3.Qty;
											break;
										}
									}
								}
								if (!cValidation.isInStock(Module1.pubCheckStock, Module1.pubBalanceDate, MyProject.Forms.frmSalesInvoice.dtpInvoice.Value, "not_used", MyProject.Forms.frmSalesInvoice.OriginalDate, cItemGroup2.ComponentId, itemId, Conversions.ToDouble(txtQty.Text), qty, Conversions.ToInteger(cComboItem3.Value), MyProject.Forms.frmSalesInvoice.OriginalStorageId, Module1.pubGroupId, 2))
								{
									Interaction.MsgBox("Stok " + cItemGroup2.ComponentName + " tidak tersedia", MsgBoxStyle.Information);
									txtQty.Focus();
									goto end_IL_0001;
								}
								cItemPrintDetail2 = new cItemPrintDetail(cItemGroup2.ComponentId);
								if (_currentData)
								{
									MyProject.Forms.frmSalesInvoice.dgvItem.Rows.Insert(j, cItemGroup2.ComponentId, "|--- " + cItemGroup2.ComponentName, "", Module1.formatCustomDecimal(Conversions.ToString(Conversions.ToDouble(txtQty.Text) * cItemGroup2.Qty), 3), 0, 0, 0, 0, cItemPrintDetail2.GeneralType, cItemPrintDetail2.LongName, cItemPrintDetail2.Packaging, cItemPrintDetail2.SmallUnit, cItemPrintDetail2.SmallQtyMultiplier, cItemPrintDetail2.LargeUnit, 0, 0, 0, 0, cComboItem2.Value);
								}
								else
								{
									MyProject.Forms.frmSalesInvoice.dgvItem.Rows.Add(cItemGroup2.ComponentId, "|--- " + cItemGroup2.ComponentName, "", Module1.formatCustomDecimal(Conversions.ToString(Conversions.ToDouble(txtQty.Text) * cItemGroup2.Qty), 3), 0, 0, 0, 0, cItemPrintDetail2.GeneralType, cItemPrintDetail2.LongName, cItemPrintDetail2.Packaging, cItemPrintDetail2.SmallUnit, cItemPrintDetail2.SmallQtyMultiplier, cItemPrintDetail2.LargeUnit, 0, 0, 0, 0, cComboItem2.Value);
								}
								j++;
							}
						}
						MyProject.Forms.frmSalesInvoice.Edited = true;
						MyProject.Forms.frmSalesInvoice.calculateTotalPrice();
						MyProject.Forms.frmSalesInvoice.calculateDiscount();
						Close();
						goto end_IL_0001;
					}
					case 3728:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmSalesInvoiceItem", "btnSave_Click", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 3728;
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

	private void DeleteComponent()
	{
		checked
		{
			bool flag = default(bool);
			if (MyProject.Forms.frmSalesInvoice.dgvItem.CurrentRow.Index == MyProject.Forms.frmSalesInvoice.dgvItem.Rows.Count - 1)
			{
				flag = false;
			}
			else if (Operators.ConditionalCompareObjectGreater(MyProject.Forms.frmSalesInvoice.dgvItem[18, MyProject.Forms.frmSalesInvoice.dgvItem.CurrentRow.Index + 1].Value, 0, TextCompare: false))
			{
				flag = true;
			}
			int num = MyProject.Forms.frmSalesInvoice.dgvItem.CurrentRow.Index;
			if (!flag)
			{
				return;
			}
			bool flag2 = default(bool);
			while (!flag2)
			{
				num++;
				if (num == MyProject.Forms.frmSalesInvoice.dgvItem.Rows.Count || Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmSalesInvoice.dgvItem[18, num].Value, 0, TextCompare: false))
				{
					flag2 = true;
				}
			}
			int num2 = num - 1;
			int num3 = num2;
			int num4 = MyProject.Forms.frmSalesInvoice.dgvItem.CurrentRow.Index + 1;
			for (num = num3; num >= num4; num += -1)
			{
				MyProject.Forms.frmSalesInvoice.dgvItem.Rows.RemoveAt(num);
			}
		}
	}

	private void btnDelete_Click(object sender, EventArgs e)
	{
		DeleteComponent();
		MyProject.Forms.frmSalesInvoice.dgvItem.Rows.RemoveAt(MyProject.Forms.frmSalesInvoice.dgvItem.CurrentRow.Index);
		MyProject.Forms.frmSalesInvoice.Edited = true;
		MyProject.Forms.frmSalesInvoice.calculateTotalPrice();
		MyProject.Forms.frmSalesInvoice.calculateDiscount();
		Close();
	}

	private void cboItem_SelectedIndexChanged(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboItem.SelectedItem;
		double price = cSalesPriceCode.GetPrice(Conversions.ToInteger(cComboItem2.Value), _customerId);
		if (!MyProject.Forms.frmSalesInvoice.IsDonation)
		{
			txtPrice.Text = Module1.formatCustomDecimal(Conversions.ToString(price), 2);
		}
		else
		{
			txtPrice.Text = "0";
		}
		_basePrice = price;
		int typeId = cItem.GetTypeId(Conversions.ToInteger(cComboItem2.Value));
		if (typeId == 3)
		{
			rtxDescription.Enabled = true;
		}
		else
		{
			rtxDescription.Text = "";
			rtxDescription.Enabled = false;
		}
		if (typeId == 4)
		{
			_isGroup = true;
		}
		else
		{
			_isGroup = false;
		}
	}
}
