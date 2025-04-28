using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GCUv2.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

[DesignerGenerated]
public class frmJournalTransactionAccount : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboAccount")]
	private ComboBox _cboAccount;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnDelete")]
	private Button _btnDelete;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSave")]
	private Button _btnSave;

	private bool _currentData;

	private string _currencyName;

	[field: AccessedThroughProperty("txtAmount")]
	internal virtual FilteredTextBox txtAmount
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

	internal virtual ComboBox cboAccount
	{
		[CompilerGenerated]
		get
		{
			return _cboAccount;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cboAccount_SelectedIndexChanged;
			ComboBox comboBox = _cboAccount;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_cboAccount = value;
			comboBox = _cboAccount;
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboDebitCredit")]
	internal virtual ComboBox cboDebitCredit
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

	[field: AccessedThroughProperty("txtCurrencyRate")]
	internal virtual FilteredTextBox txtCurrencyRate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCurrencyRate")]
	internal virtual Label lblCurrencyRate
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
		this.txtAmount = new GCUv2.FilteredTextBox();
		this.Label7 = new System.Windows.Forms.Label();
		this.cboAccount = new System.Windows.Forms.ComboBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.cboDebitCredit = new System.Windows.Forms.ComboBox();
		this.btnDelete = new System.Windows.Forms.Button();
		this.btnSave = new System.Windows.Forms.Button();
		this.txtCurrencyRate = new GCUv2.FilteredTextBox();
		this.lblCurrencyRate = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.txtAmount.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtAmount.Location = new System.Drawing.Point(79, 66);
		this.txtAmount.MaximumDigit = 3;
		this.txtAmount.Name = "txtAmount";
		this.txtAmount.Size = new System.Drawing.Size(165, 26);
		this.txtAmount.TabIndex = 2;
		this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.Location = new System.Drawing.Point(11, 42);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(32, 13);
		this.Label7.TabIndex = 190;
		this.Label7.Text = "Akun";
		this.cboAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboAccount.FormattingEnabled = true;
		this.cboAccount.Location = new System.Drawing.Point(79, 39);
		this.cboAccount.Name = "cboAccount";
		this.cboAccount.Size = new System.Drawing.Size(165, 21);
		this.cboAccount.TabIndex = 1;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(11, 74);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(40, 13);
		this.Label5.TabIndex = 189;
		this.Label5.Text = "Jumlah";
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(10, 15);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(64, 13);
		this.Label2.TabIndex = 187;
		this.Label2.Text = "Debit/Kredit";
		this.cboDebitCredit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboDebitCredit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboDebitCredit.FormattingEnabled = true;
		this.cboDebitCredit.Location = new System.Drawing.Point(80, 12);
		this.cboDebitCredit.Name = "cboDebitCredit";
		this.cboDebitCredit.Size = new System.Drawing.Size(164, 21);
		this.cboDebitCredit.TabIndex = 0;
		this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDelete.Location = new System.Drawing.Point(146, 130);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new System.Drawing.Size(54, 25);
		this.btnDelete.TabIndex = 4;
		this.btnDelete.Text = "Hapus";
		this.btnDelete.UseVisualStyleBackColor = true;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(80, 130);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(59, 25);
		this.btnSave.TabIndex = 3;
		this.btnSave.Text = "Simpan ";
		this.btnSave.UseVisualStyleBackColor = true;
		this.txtCurrencyRate.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtCurrencyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtCurrencyRate.Location = new System.Drawing.Point(80, 98);
		this.txtCurrencyRate.MaximumDigit = 3;
		this.txtCurrencyRate.Name = "txtCurrencyRate";
		this.txtCurrencyRate.Size = new System.Drawing.Size(116, 26);
		this.txtCurrencyRate.TabIndex = 3;
		this.txtCurrencyRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.lblCurrencyRate.AutoSize = true;
		this.lblCurrencyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblCurrencyRate.Location = new System.Drawing.Point(10, 106);
		this.lblCurrencyRate.Name = "lblCurrencyRate";
		this.lblCurrencyRate.Size = new System.Drawing.Size(28, 13);
		this.lblCurrencyRate.TabIndex = 192;
		this.lblCurrencyRate.Text = "Kurs";
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(271, 167);
		base.Controls.Add(this.txtCurrencyRate);
		base.Controls.Add(this.lblCurrencyRate);
		base.Controls.Add(this.btnDelete);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.txtAmount);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.cboAccount);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.cboDebitCredit);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmJournalTransactionAccount";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Bukti Jurnal Umum - Akun";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmJournalTransactionAccount(bool CurrentData)
	{
		base.KeyDown += frmJournalTransactionAccount_KeyDown;
		InitializeComponent();
		_currentData = CurrentData;
		txtAmount.AllowedCharacters = FilteredTextBox.InputType.NumeralsAndCurrency;
		ComboBox combo = cboAccount;
		cCombo.getAccount(ref combo, All: false, 0, 0, 0, 0, 99, 0, 0, 0, 1);
		cboAccount = combo;
		combo = cboDebitCredit;
		cCombo.getDebitCredit(ref combo, All: false);
		cboDebitCredit = combo;
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

	private void frmJournalTransactionAccount_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboDebitCredit.SelectedItem;
		cComboItem cComboItem3 = (cComboItem)cboAccount.SelectedItem;
		if (cboDebitCredit.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih Debit/Kredit", MsgBoxStyle.Information);
			cboDebitCredit.Focus();
			return;
		}
		if (cboAccount.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih akun", MsgBoxStyle.Information);
			cboAccount.Focus();
			return;
		}
		if (Conversion.Val(txtAmount.Text) == 0.0)
		{
			Interaction.MsgBox("Masukkan jumlah pembayaran", MsgBoxStyle.Information);
			txtAmount.Focus();
			return;
		}
		if (!Versioned.IsNumeric(txtAmount.Text))
		{
			Interaction.MsgBox("Masukkan jumlah dengan format angka yang benar", MsgBoxStyle.Information);
			txtAmount.Focus();
			return;
		}
		if (Conversion.Val(txtCurrencyRate.Text) == 0.0)
		{
			Interaction.MsgBox("Masukkan nilai kurs", MsgBoxStyle.Information);
			txtCurrencyRate.Focus();
			return;
		}
		if (!Versioned.IsNumeric(txtCurrencyRate.Text))
		{
			Interaction.MsgBox("Masukkan nilai kurs format angka yang benar", MsgBoxStyle.Information);
			txtCurrencyRate.Focus();
			return;
		}
		if (_currentData)
		{
			MyProject.Forms.frmJournalTransaction.dgvAccount[0, MyProject.Forms.frmJournalTransaction.dgvAccount.CurrentRow.Index].Value = cComboItem3.Value;
			MyProject.Forms.frmJournalTransaction.dgvAccount[1, MyProject.Forms.frmJournalTransaction.dgvAccount.CurrentRow.Index].Value = cComboItem2.Value;
			MyProject.Forms.frmJournalTransaction.dgvAccount[2, MyProject.Forms.frmJournalTransaction.dgvAccount.CurrentRow.Index].Value = cboAccount.Text;
			if (Conversions.ToDouble(cComboItem2.Value) == 1.0)
			{
				MyProject.Forms.frmJournalTransaction.dgvAccount[3, MyProject.Forms.frmJournalTransaction.dgvAccount.CurrentRow.Index].Value = Module1.formatCustomDecimal(txtAmount.Text, 2);
				MyProject.Forms.frmJournalTransaction.dgvAccount[4, MyProject.Forms.frmJournalTransaction.dgvAccount.CurrentRow.Index].Value = "";
			}
			else
			{
				MyProject.Forms.frmJournalTransaction.dgvAccount[4, MyProject.Forms.frmJournalTransaction.dgvAccount.CurrentRow.Index].Value = Module1.formatCustomDecimal(txtAmount.Text, 2);
				MyProject.Forms.frmJournalTransaction.dgvAccount[3, MyProject.Forms.frmJournalTransaction.dgvAccount.CurrentRow.Index].Value = "";
			}
			MyProject.Forms.frmJournalTransaction.dgvAccount[6, MyProject.Forms.frmJournalTransaction.dgvAccount.CurrentRow.Index].Value = Module1.formatCustomDecimal(txtCurrencyRate.Text, 2);
		}
		else
		{
			MyProject.Forms.frmJournalTransaction.dgvAccount.Rows.Add(cComboItem3.Value, cComboItem2.Value, cboAccount.Text, Interaction.IIf(Conversions.ToDouble(cComboItem2.Value) == 1.0, Module1.formatCustomDecimal(txtAmount.Text, 2), ""), Interaction.IIf(Conversions.ToDouble(cComboItem2.Value) == 2.0, Module1.formatCustomDecimal(txtAmount.Text, 2), ""), _currencyName, Module1.formatCustomDecimal(txtCurrencyRate.Text, 2));
			MyProject.Forms.frmJournalTransaction.dgvAccount.CurrentRow.Selected = false;
		}
		MyProject.Forms.frmJournalTransaction.calculateTotal();
		Close();
	}

	private void btnDelete_Click(object sender, EventArgs e)
	{
		MyProject.Forms.frmJournalTransaction.dgvAccount.Rows.RemoveAt(MyProject.Forms.frmJournalTransaction.dgvAccount.CurrentRow.Index);
		MyProject.Forms.frmJournalTransaction.calculateTotal();
		Close();
	}

	private void cboAccount_SelectedIndexChanged(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboAccount.SelectedItem;
		if (Conversions.ToDouble(cComboItem2.Value) > 0.0)
		{
			DataTable currencyOfAccount = cCurrency.GetCurrencyOfAccount(Conversions.ToInteger(cComboItem2.Value));
			lblCurrencyRate.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Kurs (", currencyOfAccount.Rows[0]["currencyName"]), ")"));
			txtCurrencyRate.Text = Module1.formatCustomDecimal(Conversions.ToString(currencyOfAccount.Rows[0]["currencyRate"]), 2);
			_currencyName = Conversions.ToString(currencyOfAccount.Rows[0]["currencyName"]);
			if (Operators.ConditionalCompareObjectEqual(currencyOfAccount.Rows[0]["currencyId"], 1, TextCompare: false))
			{
				txtCurrencyRate.Enabled = false;
			}
			else
			{
				txtCurrencyRate.Enabled = true;
			}
		}
	}
}
