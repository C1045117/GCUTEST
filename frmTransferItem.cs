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
public class frmTransferItem : Form
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

	private bool _currentData;

	private cTransferItem[] _TransferItem;

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

	public cTransferItem[] TransferItem
	{
		get
		{
			return _TransferItem;
		}
		set
		{
			_TransferItem = value;
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
		base.SuspendLayout();
		this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDelete.Location = new System.Drawing.Point(131, 71);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new System.Drawing.Size(54, 25);
		this.btnDelete.TabIndex = 70;
		this.btnDelete.Text = "Hapus";
		this.btnDelete.UseVisualStyleBackColor = true;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(65, 71);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(59, 25);
		this.btnSave.TabIndex = 69;
		this.btnSave.Text = "Simpan ";
		this.btnSave.UseVisualStyleBackColor = true;
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.Location = new System.Drawing.Point(9, 15);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(41, 13);
		this.Label6.TabIndex = 72;
		this.Label6.Text = "Barang";
		this.cboItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboItem.FormattingEnabled = true;
		this.cboItem.Location = new System.Drawing.Point(65, 12);
		this.cboItem.Name = "cboItem";
		this.cboItem.Size = new System.Drawing.Size(139, 21);
		this.cboItem.TabIndex = 67;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(10, 47);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(40, 13);
		this.Label5.TabIndex = 71;
		this.Label5.Text = "Jumlah";
		this.txtQty.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtQty.Location = new System.Drawing.Point(65, 39);
		this.txtQty.Name = "txtQty";
		this.txtQty.Size = new System.Drawing.Size(139, 26);
		this.txtQty.TabIndex = 68;
		this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(219, 102);
		base.Controls.Add(this.btnDelete);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.txtQty);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.cboItem);
		base.Controls.Add(this.Label5);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmTransferItem";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Barang - Input";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmTransferItem(bool CurrentData, int StorageFromId, int StorageToId)
	{
		base.KeyDown += frmTransferItem_KeyDown;
		InitializeComponent();
		DoubleBuffered = true;
		_currentData = CurrentData;
		txtQty.AllowedCharacters = FilteredTextBox.InputType.NumeralsAndCurrency;
		ComboBox combo = cboItem;
		cCombo.getItemAll(ref combo, 99, 99, 0, 0, 0, 0, 99, 1, 0, 0, StorageFromId, StorageToId, 0.0, CanBeUsedAsGroupMember: false, Module1.pubGroupId, All: false, Active: true);
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
	}

	private void frmTransferItem_KeyDown(object sender, KeyEventArgs e)
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
						cComboItem cComboItem3 = (cComboItem)MyProject.Forms.frmTransfer.cboStorageFrom.SelectedItem;
						cComboItem cComboItem4 = (cComboItem)MyProject.Forms.frmTransfer.cboStorageTo.SelectedItem;
						if (cboItem.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih barang", MsgBoxStyle.Information);
							cboItem.Focus();
							goto end_IL_0001;
						}
						if (!Information.IsNothing(_TransferItem))
						{
							cTransferItem[] transferItem = _TransferItem;
							foreach (cTransferItem cTransferItem2 in transferItem)
							{
								if ((double)cTransferItem2.ItemId == Conversions.ToDouble(cComboItem2.Value))
								{
									itemId = cTransferItem2.ItemId;
									qty = cTransferItem2.Qty;
									break;
								}
							}
						}
						int num3 = MyProject.Forms.frmTransfer.dgvItem.Rows.Count - 1;
						for (int j = 0; j <= num3; j++)
						{
							if (Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmTransfer.dgvItem[0, j].Value, cComboItem2.Value, TextCompare: false))
							{
								if (_currentData & (j != MyProject.Forms.frmTransfer.dgvItem.CurrentRow.Index))
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
						if (!cValidation.isInStock(Module1.pubCheckStock, Module1.pubBalanceDate, MyProject.Forms.frmTransfer.dtpTransfer.Value, "not_used", MyProject.Forms.frmTransfer.OriginalDate, Conversions.ToInteger(cComboItem2.Value), itemId, Conversions.ToDouble(txtQty.Text), qty, Conversions.ToInteger(cComboItem3.Value), MyProject.Forms.frmTransfer.OriginalStorageId, Module1.pubGroupId, 2))
						{
							Interaction.MsgBox("Stok tidak tersedia", MsgBoxStyle.Information);
							txtQty.Focus();
							goto end_IL_0001;
						}
						if (_currentData)
						{
							MyProject.Forms.frmTransfer.dgvItem[0, MyProject.Forms.frmTransfer.dgvItem.CurrentRow.Index].Value = cComboItem2.Value;
							MyProject.Forms.frmTransfer.dgvItem[1, MyProject.Forms.frmTransfer.dgvItem.CurrentRow.Index].Value = cboItem.Text;
							MyProject.Forms.frmTransfer.dgvItem[2, MyProject.Forms.frmTransfer.dgvItem.CurrentRow.Index].Value = Module1.formatCustomDecimal(txtQty.Text, 3);
						}
						else
						{
							MyProject.Forms.frmTransfer.dgvItem.Rows.Add(cComboItem2.Value, cboItem.Text, Module1.formatCustomDecimal(txtQty.Text, 3));
							MyProject.Forms.frmTransfer.dgvItem.CurrentRow.Selected = false;
						}
						MyProject.Forms.frmTransfer.Edited = true;
						Close();
						goto end_IL_0001;
					}
					case 1116:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmTransferItem", "btnSave_Click", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1116;
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
		MyProject.Forms.frmTransfer.dgvItem.Rows.RemoveAt(MyProject.Forms.frmTransfer.dgvItem.CurrentRow.Index);
		MyProject.Forms.frmTransfer.Edited = true;
		Close();
	}
}
