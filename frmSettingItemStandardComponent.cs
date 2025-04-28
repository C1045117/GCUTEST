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
public class frmSettingItemStandardComponent : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboStorage")]
	private ComboBox _cboStorage;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnDelete")]
	private Button _btnDelete;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSave")]
	private Button _btnSave;

	private bool _currentData;

	private int _productionStepId;

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
		this.Label4 = new System.Windows.Forms.Label();
		this.cboStorage = new System.Windows.Forms.ComboBox();
		this.btnDelete = new System.Windows.Forms.Button();
		this.btnSave = new System.Windows.Forms.Button();
		this.txtQty = new GCUv2.FilteredTextBox();
		this.Label6 = new System.Windows.Forms.Label();
		this.cboItem = new System.Windows.Forms.ComboBox();
		this.Label5 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(10, 15);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(45, 13);
		this.Label4.TabIndex = 94;
		this.Label4.Text = "Gudang";
		this.cboStorage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboStorage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboStorage.FormattingEnabled = true;
		this.cboStorage.Location = new System.Drawing.Point(79, 12);
		this.cboStorage.Name = "cboStorage";
		this.cboStorage.Size = new System.Drawing.Size(139, 21);
		this.cboStorage.TabIndex = 85;
		this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDelete.Location = new System.Drawing.Point(145, 98);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new System.Drawing.Size(54, 25);
		this.btnDelete.TabIndex = 90;
		this.btnDelete.Text = "Hapus";
		this.btnDelete.UseVisualStyleBackColor = true;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(79, 98);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(59, 25);
		this.btnSave.TabIndex = 89;
		this.btnSave.Text = "Simpan ";
		this.btnSave.UseVisualStyleBackColor = true;
		this.txtQty.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtQty.Location = new System.Drawing.Point(79, 66);
		this.txtQty.Name = "txtQty";
		this.txtQty.Size = new System.Drawing.Size(139, 26);
		this.txtQty.TabIndex = 87;
		this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.Location = new System.Drawing.Point(10, 42);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(58, 13);
		this.Label6.TabIndex = 92;
		this.Label6.Text = "Komponen";
		this.cboItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboItem.FormattingEnabled = true;
		this.cboItem.Location = new System.Drawing.Point(79, 39);
		this.cboItem.Name = "cboItem";
		this.cboItem.Size = new System.Drawing.Size(139, 21);
		this.cboItem.TabIndex = 86;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(10, 74);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(65, 13);
		this.Label5.TabIndex = 91;
		this.Label5.Text = "Jml. Standar";
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(234, 132);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.cboStorage);
		base.Controls.Add(this.btnDelete);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.txtQty);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.cboItem);
		base.Controls.Add(this.Label5);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSettingItemStandardComponent";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Komponen Standar";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmSettingItemStandardComponent(bool CurrentData, int ProductionStepId)
	{
		base.KeyDown += frmSettingItemInputItem_KeyDown;
		InitializeComponent();
		_currentData = CurrentData;
		_productionStepId = ProductionStepId;
		txtQty.AllowedCharacters = FilteredTextBox.InputType.NumeralsAndCurrency;
		ComboBox combo = cboStorage;
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
	}

	private void frmSettingItemInputItem_KeyDown(object sender, KeyEventArgs e)
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
			cCombo.getItemAll(ref combo, 99, 99, 0, 1, 0, _productionStepId, 99, 1, 0, 0, Conversions.ToInteger(cComboItem2.Value), 0, 0.0, CanBeUsedAsGroupMember: false, Module1.pubGroupId, All: false, Active: true);
			cboItem = combo;
			cboItem.Text = "";
			cboItem.SelectedIndex = -1;
		}
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboItem.SelectedItem;
		cComboItem cComboItem3 = (cComboItem)cboStorage.SelectedItem;
		if (cboStorage.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih gudang", MsgBoxStyle.Information);
			cboStorage.Focus();
			return;
		}
		if (cboItem.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih komponen", MsgBoxStyle.Information);
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
		if (_currentData)
		{
			MyProject.Forms.frmSettingItemInput.dgvStandardComponent[0, MyProject.Forms.frmSettingItemInput.dgvStandardComponent.CurrentRow.Index].Value = cComboItem3.Value;
			MyProject.Forms.frmSettingItemInput.dgvStandardComponent[1, MyProject.Forms.frmSettingItemInput.dgvStandardComponent.CurrentRow.Index].Value = cComboItem2.Value;
			MyProject.Forms.frmSettingItemInput.dgvStandardComponent[2, MyProject.Forms.frmSettingItemInput.dgvStandardComponent.CurrentRow.Index].Value = cboStorage.Text;
			MyProject.Forms.frmSettingItemInput.dgvStandardComponent[3, MyProject.Forms.frmSettingItemInput.dgvStandardComponent.CurrentRow.Index].Value = cboItem.Text;
			MyProject.Forms.frmSettingItemInput.dgvStandardComponent[4, MyProject.Forms.frmSettingItemInput.dgvStandardComponent.CurrentRow.Index].Value = Module1.formatCustomDecimal(Conversions.ToString(Conversion.Val(Module1.unformatNumber(txtQty.Text))), 3);
		}
		else
		{
			MyProject.Forms.frmSettingItemInput.dgvStandardComponent.Rows.Add(cComboItem3.Value, cComboItem2.Value, cboStorage.Text, cboItem.Text, Module1.formatCustomDecimal(Conversions.ToString(Conversion.Val(Module1.unformatNumber(txtQty.Text))), 3));
			MyProject.Forms.frmSettingItemInput.dgvStandardComponent.CurrentRow.Selected = false;
		}
		Close();
	}

	private void btnDelete_Click(object sender, EventArgs e)
	{
		MyProject.Forms.frmSettingItemInput.dgvStandardComponent.Rows.RemoveAt(MyProject.Forms.frmSettingItemInput.dgvStandardComponent.CurrentRow.Index);
		Close();
	}
}
