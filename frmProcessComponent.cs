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
public class frmProcessComponent : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSave")]
	private Button _btnSave;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnDelete")]
	private Button _btnDelete;

	private bool _currentData;

	private int _productionItemId;

	private cComponent[] _component;

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

	[field: AccessedThroughProperty("cboStorage")]
	internal virtual ComboBox cboStorage
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dtpComponent")]
	internal virtual DateTimePicker dtpComponent
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
		this.dtpComponent = new System.Windows.Forms.DateTimePicker();
		this.btnSave = new System.Windows.Forms.Button();
		this.txtQty = new GCUv2.FilteredTextBox();
		this.btnDelete = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.Location = new System.Drawing.Point(12, 67);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(58, 13);
		this.Label6.TabIndex = 44;
		this.Label6.Text = "Komponen";
		this.cboItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboItem.FormattingEnabled = true;
		this.cboItem.Location = new System.Drawing.Point(73, 64);
		this.cboItem.Name = "cboItem";
		this.cboItem.Size = new System.Drawing.Size(139, 21);
		this.cboItem.TabIndex = 2;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(12, 97);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(40, 13);
		this.Label5.TabIndex = 43;
		this.Label5.Text = "Jumlah";
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(12, 38);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(45, 13);
		this.Label4.TabIndex = 42;
		this.Label4.Text = "Gudang";
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(12, 9);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(46, 13);
		this.Label1.TabIndex = 41;
		this.Label1.Text = "Tanggal";
		this.cboStorage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboStorage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboStorage.FormattingEnabled = true;
		this.cboStorage.Location = new System.Drawing.Point(72, 35);
		this.cboStorage.Name = "cboStorage";
		this.cboStorage.Size = new System.Drawing.Size(139, 21);
		this.cboStorage.TabIndex = 1;
		this.dtpComponent.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpComponent.Location = new System.Drawing.Point(73, 6);
		this.dtpComponent.Name = "dtpComponent";
		this.dtpComponent.Size = new System.Drawing.Size(138, 20);
		this.dtpComponent.TabIndex = 0;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(73, 123);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(60, 24);
		this.btnSave.TabIndex = 4;
		this.btnSave.Text = "Simpan ";
		this.btnSave.UseVisualStyleBackColor = true;
		this.txtQty.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtQty.Location = new System.Drawing.Point(72, 91);
		this.txtQty.Name = "txtQty";
		this.txtQty.Size = new System.Drawing.Size(139, 26);
		this.txtQty.TabIndex = 3;
		this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDelete.Location = new System.Drawing.Point(139, 123);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new System.Drawing.Size(59, 24);
		this.btnDelete.TabIndex = 5;
		this.btnDelete.Text = "Hapus";
		this.btnDelete.UseVisualStyleBackColor = true;
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(229, 157);
		base.Controls.Add(this.btnDelete);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.txtQty);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.cboItem);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.cboStorage);
		base.Controls.Add(this.dtpComponent);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "frmProcessComponent";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Komponen Produksi - Input";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmProcessComponent(bool CurrentData, int ProductionItemId)
	{
		base.KeyDown += frmProcessComponent_KeyDown;
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
					_currentData = CurrentData;
					_productionItemId = ProductionItemId;
					txtQty.AllowedCharacters = FilteredTextBox.InputType.NumeralsAndCurrency;
					ComboBox combo = cboItem;
					cCombo.getItemAll(ref combo, 99, 99, 0, 1, _productionItemId, 0, 99, 1, 0, 0, 0, 0, 0.0, CanBeUsedAsGroupMember: false, Module1.pubGroupId, All: false, Active: true);
					cboItem = combo;
					combo = cboStorage;
					cCombo.getStorage(ref combo, Module1.pubGroupId, 0, "NO_RETURN", blnAll: false, 1);
					cboStorage = combo;
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
					goto end_IL_001b;
				}
				case 272:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmProcessComponent", "New", "");
						goto end_IL_001b;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try001b_dispatch = 272;
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

	private void frmProcessComponent_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboStorage.SelectedItem;
		cComboItem cComboItem3 = (cComboItem)cboItem.SelectedItem;
		DateTime componentDate = default(DateTime);
		int itemId = default(int);
		int storageId = default(int);
		double qty = default(double);
		if (!Information.IsNothing(_component))
		{
			cComponent[] component = _component;
			foreach (cComponent cComponent2 in component)
			{
				if (((double)cComponent2.ItemId == Conversions.ToDouble(cComboItem3.Value)) & ((double)cComponent2.StorageId == Conversions.ToDouble(cComboItem2.Value)))
				{
					componentDate = cComponent2.ComponentDate;
					itemId = cComponent2.ItemId;
					storageId = cComponent2.StorageId;
					qty = cComponent2.Qty;
					break;
				}
			}
		}
		checked
		{
			int num = MyProject.Forms.frmProcess.dgvList.Rows.Count - 1;
			bool flag = default(bool);
			for (int j = 0; j <= num; j++)
			{
				if (Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmProcess.dgvList[1, j].Value, cComboItem3.Value, TextCompare: false))
				{
					if (_currentData & (j != MyProject.Forms.frmProcess.dgvList.CurrentRow.Index))
					{
						flag = true;
					}
					else if (!_currentData)
					{
						flag = true;
					}
				}
			}
			if (!cValidation.isDateWithinRange(dtpComponent.Value, Module1.pubGroupId, Module1.pubDaysLimit))
			{
				Interaction.MsgBox("Tanggal diluar batas yang diperbolehkan", MsgBoxStyle.Information);
				dtpComponent.Focus();
				return;
			}
			if (cboStorage.SelectedIndex == -1)
			{
				Interaction.MsgBox("Pilih gudang komponen", MsgBoxStyle.Information);
				cboStorage.Focus();
				return;
			}
			if (cboItem.SelectedIndex == -1)
			{
				Interaction.MsgBox("Pilih komponen", MsgBoxStyle.Information);
				cboItem.Focus();
				return;
			}
			if (flag)
			{
				Interaction.MsgBox(cComboItem3.Text + " tidak bisa dipilih karena sudah digunakan sebagai komponen", MsgBoxStyle.Information);
				cboItem.Focus();
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
			if (!cValidation.isInStock(Module1.pubCheckStock, Module1.pubBalanceDate, dtpComponent.Value, "not_used", componentDate, Conversions.ToInteger(cComboItem3.Value), itemId, Conversions.ToDouble(txtQty.Text), qty, Conversions.ToInteger(cComboItem2.Value), storageId, Module1.pubGroupId, 2))
			{
				Interaction.MsgBox("Stok tidak tersedia", MsgBoxStyle.Information);
				txtQty.Focus();
				return;
			}
			if (_currentData)
			{
				MyProject.Forms.frmProcess.dgvList[1, MyProject.Forms.frmProcess.dgvList.CurrentRow.Index].Value = cComboItem3.Value;
				MyProject.Forms.frmProcess.dgvList[2, MyProject.Forms.frmProcess.dgvList.CurrentRow.Index].Value = cComboItem2.Value;
				MyProject.Forms.frmProcess.dgvList[3, MyProject.Forms.frmProcess.dgvList.CurrentRow.Index].Value = dtpComponent.Value;
				MyProject.Forms.frmProcess.dgvList[4, MyProject.Forms.frmProcess.dgvList.CurrentRow.Index].Value = cboStorage.Text;
				MyProject.Forms.frmProcess.dgvList[5, MyProject.Forms.frmProcess.dgvList.CurrentRow.Index].Value = cboItem.Text;
				MyProject.Forms.frmProcess.dgvList[6, MyProject.Forms.frmProcess.dgvList.CurrentRow.Index].Value = Module1.formatCustomDecimal(txtQty.Text, 3);
			}
			else
			{
				MyProject.Forms.frmProcess.dgvList.Rows.Add(0, cComboItem3.Value, cComboItem2.Value, dtpComponent.Value, cboStorage.Text, cboItem.Text, Module1.formatCustomDecimal(txtQty.Text, 3));
				MyProject.Forms.frmProcess.dgvList.CurrentRow.Selected = false;
			}
			Close();
		}
	}

	private void btnDelete_Click(object sender, EventArgs e)
	{
		MyProject.Forms.frmProcess.dgvList.Rows.RemoveAt(MyProject.Forms.frmProcess.dgvList.CurrentRow.Index);
		Close();
	}
}
