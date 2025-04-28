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
public class frmReceivedItemItem : Form
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

	private cReceivedItemItem[] _RIItem;

	private int _supplierId;

	private DateTime _purchaseDate;

	private double _unitId;

	private double _unitQty;

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

	public cReceivedItemItem[] RIItem
	{
		get
		{
			return _RIItem;
		}
		set
		{
			_RIItem = value;
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
		this.txtQty = new GCUv2.FilteredTextBox();
		this.txtStockQty = new GCUv2.FilteredTextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.lblBaseUnit = new System.Windows.Forms.Label();
		this.cboUnit = new System.Windows.Forms.ComboBox();
		base.SuspendLayout();
		this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDelete.Location = new System.Drawing.Point(152, 104);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new System.Drawing.Size(54, 25);
		this.btnDelete.TabIndex = 64;
		this.btnDelete.Text = "Hapus";
		this.btnDelete.UseVisualStyleBackColor = true;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(86, 104);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(59, 25);
		this.btnSave.TabIndex = 63;
		this.btnSave.Text = "Simpan ";
		this.btnSave.UseVisualStyleBackColor = true;
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.Location = new System.Drawing.Point(11, 16);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(41, 13);
		this.Label6.TabIndex = 66;
		this.Label6.Text = "Barang";
		this.cboItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboItem.FormattingEnabled = true;
		this.cboItem.Location = new System.Drawing.Point(86, 13);
		this.cboItem.Name = "cboItem";
		this.cboItem.Size = new System.Drawing.Size(139, 21);
		this.cboItem.TabIndex = 0;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(12, 48);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(40, 13);
		this.Label5.TabIndex = 65;
		this.Label5.Text = "Jumlah";
		this.txtQty.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtQty.DontFormat = false;
		this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtQty.Location = new System.Drawing.Point(86, 40);
		this.txtQty.MaximumDigit = 3;
		this.txtQty.Name = "txtQty";
		this.txtQty.Size = new System.Drawing.Size(139, 26);
		this.txtQty.TabIndex = 1;
		this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.txtStockQty.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtStockQty.DontFormat = false;
		this.txtStockQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtStockQty.Location = new System.Drawing.Point(86, 72);
		this.txtStockQty.MaximumDigit = 3;
		this.txtStockQty.Name = "txtStockQty";
		this.txtStockQty.Size = new System.Drawing.Size(139, 26);
		this.txtStockQty.TabIndex = 3;
		this.txtStockQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(12, 80);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(75, 13);
		this.Label1.TabIndex = 92;
		this.Label1.Text = "Jumlah ( stok )";
		this.lblBaseUnit.AutoSize = true;
		this.lblBaseUnit.Location = new System.Drawing.Point(231, 80);
		this.lblBaseUnit.Name = "lblBaseUnit";
		this.lblBaseUnit.Size = new System.Drawing.Size(53, 13);
		this.lblBaseUnit.TabIndex = 90;
		this.lblBaseUnit.Text = "Base Unit";
		this.cboUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboUnit.FormattingEnabled = true;
		this.cboUnit.Location = new System.Drawing.Point(231, 43);
		this.cboUnit.Name = "cboUnit";
		this.cboUnit.Size = new System.Drawing.Size(73, 21);
		this.cboUnit.TabIndex = 2;
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(313, 140);
		base.Controls.Add(this.cboUnit);
		base.Controls.Add(this.txtStockQty);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.lblBaseUnit);
		base.Controls.Add(this.btnDelete);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.txtQty);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.cboItem);
		base.Controls.Add(this.Label5);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmReceivedItemItem";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Barang - Input";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmReceivedItemItem(bool CurrentData, int SupplierId, int StorageId, DateTime PurchaseDate)
	{
		base.KeyDown += frmReceivedItemItem_KeyDown;
		InitializeComponent();
		_supplierId = SupplierId;
		_purchaseDate = PurchaseDate;
		DoubleBuffered = true;
		_currentData = CurrentData;
		txtQty.AllowedCharacters = FilteredTextBox.InputType.NumeralsAndCurrency;
		ComboBox combo = cboItem;
		cCombo.getItemAll(ref combo, 99, 99, 0, 0, 0, 0, 2, 1, 0, SupplierId, StorageId, 0, 0.0, CanBeUsedAsGroupMember: false, Module1.pubGroupId, All: false, Active: true);
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

	private void frmReceivedItemItem_KeyDown(object sender, KeyEventArgs e)
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
		int try0001_dispatch = -1;
		int num2 = default(int);
		int itemId = default(int);
		double rIQty = default(double);
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
						cComboItem cComboItem3 = (cComboItem)MyProject.Forms.frmReceivedItem.cboStorage.SelectedItem;
						if (cboItem.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih barang", MsgBoxStyle.Information);
							cboItem.Focus();
							goto end_IL_0001;
						}
						if (!Information.IsNothing(_RIItem))
						{
							cReceivedItemItem[] rIItem = _RIItem;
							foreach (cReceivedItemItem cReceivedItemItem2 in rIItem)
							{
								if ((double)cReceivedItemItem2.ItemId == Conversions.ToDouble(cComboItem2.Value))
								{
									itemId = cReceivedItemItem2.ItemId;
									rIQty = cReceivedItemItem2.RIQty;
									break;
								}
							}
						}
						int num3 = MyProject.Forms.frmReceivedItem.dgvItem.Rows.Count - 1;
						for (int j = 0; j <= num3; j++)
						{
							if (Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmReceivedItem.dgvItem[0, j].Value, cComboItem2.Value, TextCompare: false))
							{
								if (_currentData & (j != MyProject.Forms.frmReceivedItem.dgvItem.CurrentRow.Index))
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
						if (!cValidation.isInStock(Module1.pubCheckStock, Module1.pubBalanceDate, MyProject.Forms.frmReceivedItem.dtpRI.Value, "not_used", MyProject.Forms.frmReceivedItem.OriginalDate, Conversions.ToInteger(cComboItem2.Value), itemId, Conversions.ToDouble(txtQty.Text), rIQty, Conversions.ToInteger(cComboItem3.Value), MyProject.Forms.frmReceivedItem.OriginalStorageId, Module1.pubGroupId, 1))
						{
							Interaction.MsgBox("Update ini akan membuat stok menjadi negatif", MsgBoxStyle.Information);
							txtQty.Focus();
							goto end_IL_0001;
						}
						if (_currentData)
						{
							MyProject.Forms.frmReceivedItem.dgvItem[0, MyProject.Forms.frmReceivedItem.dgvItem.CurrentRow.Index].Value = cComboItem2.Value;
							MyProject.Forms.frmReceivedItem.dgvItem[1, MyProject.Forms.frmReceivedItem.dgvItem.CurrentRow.Index].Value = cboItem.Text;
							MyProject.Forms.frmReceivedItem.dgvItem[2, MyProject.Forms.frmReceivedItem.dgvItem.CurrentRow.Index].Value = Module1.formatCustomDecimal(txtQty.Text, 3);
							MyProject.Forms.frmReceivedItem.dgvItem[3, MyProject.Forms.frmReceivedItem.dgvItem.CurrentRow.Index].Value = cboUnit.Text;
							MyProject.Forms.frmReceivedItem.dgvItem[4, MyProject.Forms.frmReceivedItem.dgvItem.CurrentRow.Index].Value = Module1.formatCustomDecimal(txtQty.Text, 3) + " " + cboUnit.Text;
							MyProject.Forms.frmReceivedItem.dgvItem[5, MyProject.Forms.frmReceivedItem.dgvItem.CurrentRow.Index].Value = Module1.formatCustomDecimal(txtStockQty.Text, 3);
							MyProject.Forms.frmReceivedItem.dgvItem[6, MyProject.Forms.frmReceivedItem.dgvItem.CurrentRow.Index].Value = Module1.formatCustomDecimal(txtStockQty.Text, 3) + " " + lblBaseUnit.Text;
						}
						else
						{
							MyProject.Forms.frmReceivedItem.dgvItem.Rows.Add(cComboItem2.Value, cboItem.Text, Module1.formatCustomDecimal(txtQty.Text, 3), cboUnit.Text, Module1.formatCustomDecimal(txtQty.Text, 3) + " " + cboUnit.Text, Module1.formatCustomDecimal(txtStockQty.Text, 3), Module1.formatCustomDecimal(txtStockQty.Text, 3) + " " + lblBaseUnit.Text);
							MyProject.Forms.frmReceivedItem.dgvItem.CurrentRow.Selected = false;
						}
						Close();
						goto end_IL_0001;
					}
					case 1503:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmReceivedItemItem", "btnSave_Click", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1503;
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
		MyProject.Forms.frmReceivedItem.dgvItem.Rows.RemoveAt(MyProject.Forms.frmReceivedItem.dgvItem.CurrentRow.Index);
		Close();
	}
}
