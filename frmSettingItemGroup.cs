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
public class frmSettingItemGroup : Form
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
		this.btnDelete = new System.Windows.Forms.Button();
		this.btnSave = new System.Windows.Forms.Button();
		this.txtQty = new GCUv2.FilteredTextBox();
		this.Label6 = new System.Windows.Forms.Label();
		this.cboItem = new System.Windows.Forms.ComboBox();
		this.Label5 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDelete.Location = new System.Drawing.Point(148, 71);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new System.Drawing.Size(54, 25);
		this.btnDelete.TabIndex = 12;
		this.btnDelete.Text = "Hapus";
		this.btnDelete.UseVisualStyleBackColor = true;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(82, 71);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(59, 25);
		this.btnSave.TabIndex = 11;
		this.btnSave.Text = "Simpan ";
		this.btnSave.UseVisualStyleBackColor = true;
		this.txtQty.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtQty.DontFormat = false;
		this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtQty.Location = new System.Drawing.Point(82, 39);
		this.txtQty.MaximumDigit = 3;
		this.txtQty.Name = "txtQty";
		this.txtQty.Size = new System.Drawing.Size(139, 26);
		this.txtQty.TabIndex = 1;
		this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.Location = new System.Drawing.Point(13, 15);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(58, 13);
		this.Label6.TabIndex = 109;
		this.Label6.Text = "Komponen";
		this.cboItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboItem.FormattingEnabled = true;
		this.cboItem.Location = new System.Drawing.Point(82, 12);
		this.cboItem.Name = "cboItem";
		this.cboItem.Size = new System.Drawing.Size(139, 21);
		this.cboItem.TabIndex = 0;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(13, 47);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(40, 13);
		this.Label5.TabIndex = 108;
		this.Label5.Text = "Jumlah";
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(250, 108);
		base.Controls.Add(this.btnDelete);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.txtQty);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.cboItem);
		base.Controls.Add(this.Label5);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSettingItemGroup";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Komponen Grup";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmSettingItemGroup(bool CurrentData)
	{
		base.KeyDown += frmSettingItemGroup_KeyDown;
		InitializeComponent();
		_currentData = CurrentData;
		txtQty.MaximumDigit = 3;
		txtQty.AllowedCharacters = FilteredTextBox.InputType.NumeralsAndCurrency;
		ComboBox combo = cboItem;
		cCombo.getItemAll(ref combo, 99, 99, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0.0, CanBeUsedAsGroupMember: true, Module1.pubGroupId, All: false, Active: true);
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

	private void frmSettingItemGroup_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboItem.SelectedItem;
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
			MyProject.Forms.frmSettingItemInput.dgvItemGroup[0, MyProject.Forms.frmSettingItemInput.dgvItemGroup.CurrentRow.Index].Value = cComboItem2.Value;
			MyProject.Forms.frmSettingItemInput.dgvItemGroup[1, MyProject.Forms.frmSettingItemInput.dgvItemGroup.CurrentRow.Index].Value = cboItem.Text;
			MyProject.Forms.frmSettingItemInput.dgvItemGroup[2, MyProject.Forms.frmSettingItemInput.dgvItemGroup.CurrentRow.Index].Value = Module1.formatCustomDecimal(Conversions.ToString(Conversion.Val(Module1.unformatNumber(txtQty.Text))), 8);
		}
		else
		{
			MyProject.Forms.frmSettingItemInput.dgvItemGroup.Rows.Add(cComboItem2.Value, cboItem.Text, Module1.formatCustomDecimal(Conversions.ToString(Conversion.Val(Module1.unformatNumber(txtQty.Text))), 8));
			MyProject.Forms.frmSettingItemInput.dgvItemGroup.CurrentRow.Selected = false;
		}
		Close();
	}

	private void btnDelete_Click(object sender, EventArgs e)
	{
		MyProject.Forms.frmSettingItemInput.dgvItemGroup.Rows.RemoveAt(MyProject.Forms.frmSettingItemInput.dgvItemGroup.CurrentRow.Index);
		Close();
	}
}
