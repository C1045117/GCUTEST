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
public class frmSettingItemSupplier : Form
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

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboSupplier")]
	internal virtual ComboBox cboSupplier
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

	[field: AccessedThroughProperty("dtpValid")]
	internal virtual DateTimePicker dtpValid
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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboUnit")]
	internal virtual ComboBox cboUnit
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
		this.Label7 = new System.Windows.Forms.Label();
		this.cboSupplier = new System.Windows.Forms.ComboBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.dtpValid = new System.Windows.Forms.DateTimePicker();
		this.Label5 = new System.Windows.Forms.Label();
		this.btnDelete = new System.Windows.Forms.Button();
		this.btnSave = new System.Windows.Forms.Button();
		this.txtPrice = new GCUv2.FilteredTextBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.cboUnit = new System.Windows.Forms.ComboBox();
		base.SuspendLayout();
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.Location = new System.Drawing.Point(12, 15);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(45, 13);
		this.Label7.TabIndex = 57;
		this.Label7.Text = "Supplier";
		this.cboSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboSupplier.FormattingEnabled = true;
		this.cboSupplier.Location = new System.Drawing.Point(114, 12);
		this.cboSupplier.Name = "cboSupplier";
		this.cboSupplier.Size = new System.Drawing.Size(174, 21);
		this.cboSupplier.TabIndex = 0;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(12, 97);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(101, 13);
		this.Label1.TabIndex = 56;
		this.Label1.Text = "Harga berlaku mulai";
		this.dtpValid.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpValid.Location = new System.Drawing.Point(114, 94);
		this.dtpValid.Name = "dtpValid";
		this.dtpValid.Size = new System.Drawing.Size(121, 20);
		this.dtpValid.TabIndex = 2;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(12, 71);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(36, 13);
		this.Label5.TabIndex = 63;
		this.Label5.Text = "Harga";
		this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDelete.Location = new System.Drawing.Point(181, 120);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new System.Drawing.Size(54, 25);
		this.btnDelete.TabIndex = 4;
		this.btnDelete.Text = "Hapus";
		this.btnDelete.UseVisualStyleBackColor = true;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(115, 120);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(59, 25);
		this.btnSave.TabIndex = 3;
		this.btnSave.Text = "Simpan ";
		this.btnSave.UseVisualStyleBackColor = true;
		this.txtPrice.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtPrice.Location = new System.Drawing.Point(115, 66);
		this.txtPrice.MaximumDigit = 3;
		this.txtPrice.Name = "txtPrice";
		this.txtPrice.Size = new System.Drawing.Size(121, 22);
		this.txtPrice.TabIndex = 2;
		this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(12, 42);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(41, 13);
		this.Label2.TabIndex = 67;
		this.Label2.Text = "Satuan";
		this.cboUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboUnit.FormattingEnabled = true;
		this.cboUnit.Location = new System.Drawing.Point(114, 39);
		this.cboUnit.Name = "cboUnit";
		this.cboUnit.Size = new System.Drawing.Size(174, 21);
		this.cboUnit.TabIndex = 1;
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(303, 159);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.cboUnit);
		base.Controls.Add(this.btnDelete);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.txtPrice);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.cboSupplier);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.dtpValid);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSettingItemSupplier";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Setting Harga Barang - Supplier";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmSettingItemSupplier(bool CurrentData)
	{
		base.KeyDown += frmSettingItemSupplier_KeyDown;
		InitializeComponent();
		DoubleBuffered = true;
		_currentData = CurrentData;
		txtPrice.AllowedCharacters = FilteredTextBox.InputType.NumeralsAndCurrency;
		ComboBox combo = cboSupplier;
		cCombo.getSupplier(ref combo, Module1.pubGroupId, All: false, FlowerOnly: false, IncludeParent: false, Active: true);
		cboSupplier = combo;
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

	private void frmSettingItemSupplier_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboSupplier.SelectedItem;
		if (cboSupplier.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih supplier", MsgBoxStyle.Information);
			cboSupplier.Focus();
			return;
		}
		if (cboUnit.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih satuan.", MsgBoxStyle.Information);
			cboUnit.Focus();
			return;
		}
		if (!Versioned.IsNumeric(txtPrice.Text))
		{
			Interaction.MsgBox("Masukkan harga dengan format angka yang benar", MsgBoxStyle.Information);
			txtPrice.Focus();
			return;
		}
		checked
		{
			if (_currentData)
			{
				MyProject.Forms.frmSettingItemInput.dgvSupplier[0, MyProject.Forms.frmSettingItemInput.dgvSupplier.CurrentRow.Index].Value = cComboItem2.Value;
				MyProject.Forms.frmSettingItemInput.dgvSupplier[1, MyProject.Forms.frmSettingItemInput.dgvSupplier.CurrentRow.Index].Value = cboUnit.SelectedIndex + 1;
				MyProject.Forms.frmSettingItemInput.dgvSupplier[2, MyProject.Forms.frmSettingItemInput.dgvSupplier.CurrentRow.Index].Value = cboSupplier.Text;
				MyProject.Forms.frmSettingItemInput.dgvSupplier[3, MyProject.Forms.frmSettingItemInput.dgvSupplier.CurrentRow.Index].Value = cboUnit.Text;
				MyProject.Forms.frmSettingItemInput.dgvSupplier[4, MyProject.Forms.frmSettingItemInput.dgvSupplier.CurrentRow.Index].Value = Module1.formatCustomDecimal(Conversions.ToString(Conversion.Val(Module1.unformatNumber(txtPrice.Text))), 2);
				MyProject.Forms.frmSettingItemInput.dgvSupplier[5, MyProject.Forms.frmSettingItemInput.dgvSupplier.CurrentRow.Index].Value = Strings.Format(dtpValid.Value, "dd/MM/yyyy");
			}
			else
			{
				MyProject.Forms.frmSettingItemInput.dgvSupplier.Rows.Add(cComboItem2.Value, cboUnit.SelectedIndex + 1, cboSupplier.Text, cboUnit.Text, Module1.formatCustomDecimal(Conversions.ToString(Conversion.Val(Module1.unformatNumber(txtPrice.Text))), 2), Strings.Format(dtpValid.Value, "dd/MM/yyyy"));
				MyProject.Forms.frmSettingItemInput.dgvSupplier.CurrentRow.Selected = false;
			}
			Close();
		}
	}

	private void btnDelete_Click(object sender, EventArgs e)
	{
		MyProject.Forms.frmSettingItemInput.dgvSupplier.Rows.RemoveAt(MyProject.Forms.frmSettingItemInput.dgvSupplier.CurrentRow.Index);
		Close();
	}
}
