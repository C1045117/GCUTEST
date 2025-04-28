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
public class frmPurchaseReturnPayment : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboPaymentCode")]
	private ComboBox _cboPaymentCode;

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
	[AccessedThroughProperty("cboAccount")]
	private ComboBox _cboAccount;

	private bool _currentData;

	private int _invoiceCurrencyId;

	private int _currencyId;

	private string _currencyName;

	private int _cashAccountId;

	private int _bankAccountId;

	[field: AccessedThroughProperty("txtAmount")]
	internal virtual FilteredTextBox txtAmount
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAmount")]
	internal virtual Label lblAmount
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtChequeNo")]
	internal virtual TextBox txtChequeNo
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

	[field: AccessedThroughProperty("dtpCheque")]
	internal virtual DateTimePicker dtpCheque
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dtpPayment")]
	internal virtual DateTimePicker dtpPayment
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

	internal virtual ComboBox cboPaymentCode
	{
		[CompilerGenerated]
		get
		{
			return _cboPaymentCode;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cboPaymentType_SelectedIndexChanged;
			ComboBox comboBox = _cboPaymentCode;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_cboPaymentCode = value;
			comboBox = _cboPaymentCode;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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

	[field: AccessedThroughProperty("lblAccount")]
	internal virtual Label lblAccount
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

	public int CashAccountId
	{
		get
		{
			return _cashAccountId;
		}
		set
		{
			_cashAccountId = value;
		}
	}

	public int BankAccountId
	{
		get
		{
			return _bankAccountId;
		}
		set
		{
			_bankAccountId = value;
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
		this.txtAmount = new GCUv2.FilteredTextBox();
		this.lblAmount = new System.Windows.Forms.Label();
		this.txtChequeNo = new System.Windows.Forms.TextBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.dtpCheque = new System.Windows.Forms.DateTimePicker();
		this.Label9 = new System.Windows.Forms.Label();
		this.dtpPayment = new System.Windows.Forms.DateTimePicker();
		this.Label4 = new System.Windows.Forms.Label();
		this.cboPaymentCode = new System.Windows.Forms.ComboBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.btnDelete = new System.Windows.Forms.Button();
		this.btnSave = new System.Windows.Forms.Button();
		this.txtCurrencyRate = new GCUv2.FilteredTextBox();
		this.lblCurrencyRate = new System.Windows.Forms.Label();
		this.lblAccount = new System.Windows.Forms.Label();
		this.cboAccount = new System.Windows.Forms.ComboBox();
		base.SuspendLayout();
		this.txtAmount.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtAmount.Location = new System.Drawing.Point(99, 120);
		this.txtAmount.MaximumDigit = 3;
		this.txtAmount.Name = "txtAmount";
		this.txtAmount.Size = new System.Drawing.Size(116, 26);
		this.txtAmount.TabIndex = 4;
		this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.lblAmount.AutoSize = true;
		this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblAmount.Location = new System.Drawing.Point(10, 126);
		this.lblAmount.Name = "lblAmount";
		this.lblAmount.Size = new System.Drawing.Size(43, 13);
		this.lblAmount.TabIndex = 109;
		this.lblAmount.Text = "Jumlah ";
		this.txtChequeNo.Enabled = false;
		this.txtChequeNo.Location = new System.Drawing.Point(99, 94);
		this.txtChequeNo.Name = "txtChequeNo";
		this.txtChequeNo.Size = new System.Drawing.Size(116, 20);
		this.txtChequeNo.TabIndex = 3;
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(10, 68);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(69, 13);
		this.Label3.TabIndex = 108;
		this.Label3.Text = "Tanggal C/G";
		this.dtpCheque.Enabled = false;
		this.dtpCheque.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpCheque.Location = new System.Drawing.Point(99, 65);
		this.dtpCheque.Name = "dtpCheque";
		this.dtpCheque.Size = new System.Drawing.Size(116, 20);
		this.dtpCheque.TabIndex = 2;
		this.Label9.AutoSize = true;
		this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label9.Location = new System.Drawing.Point(10, 15);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(46, 13);
		this.Label9.TabIndex = 107;
		this.Label9.Text = "Tanggal";
		this.dtpPayment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpPayment.Location = new System.Drawing.Point(99, 12);
		this.dtpPayment.Name = "dtpPayment";
		this.dtpPayment.Size = new System.Drawing.Size(116, 20);
		this.dtpPayment.TabIndex = 0;
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(10, 41);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(28, 13);
		this.Label4.TabIndex = 106;
		this.Label4.Text = "Tipe";
		this.cboPaymentCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboPaymentCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboPaymentCode.FormattingEnabled = true;
		this.cboPaymentCode.Location = new System.Drawing.Point(99, 38);
		this.cboPaymentCode.Name = "cboPaymentCode";
		this.cboPaymentCode.Size = new System.Drawing.Size(116, 21);
		this.cboPaymentCode.TabIndex = 1;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(10, 97);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(44, 13);
		this.Label2.TabIndex = 105;
		this.Label2.Text = "No C/G";
		this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDelete.Location = new System.Drawing.Point(169, 211);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new System.Drawing.Size(58, 24);
		this.btnDelete.TabIndex = 103;
		this.btnDelete.Text = "Hapus";
		this.btnDelete.UseVisualStyleBackColor = true;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(100, 211);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(63, 24);
		this.btnSave.TabIndex = 102;
		this.btnSave.Text = "Simpan ";
		this.btnSave.UseVisualStyleBackColor = true;
		this.txtCurrencyRate.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtCurrencyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtCurrencyRate.Location = new System.Drawing.Point(99, 179);
		this.txtCurrencyRate.MaximumDigit = 3;
		this.txtCurrencyRate.Name = "txtCurrencyRate";
		this.txtCurrencyRate.Size = new System.Drawing.Size(116, 26);
		this.txtCurrencyRate.TabIndex = 7;
		this.txtCurrencyRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.lblCurrencyRate.AutoSize = true;
		this.lblCurrencyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblCurrencyRate.Location = new System.Drawing.Point(10, 185);
		this.lblCurrencyRate.Name = "lblCurrencyRate";
		this.lblCurrencyRate.Size = new System.Drawing.Size(28, 13);
		this.lblCurrencyRate.TabIndex = 181;
		this.lblCurrencyRate.Text = "Kurs";
		this.lblAccount.AutoSize = true;
		this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblAccount.Location = new System.Drawing.Point(10, 155);
		this.lblAccount.Name = "lblAccount";
		this.lblAccount.Size = new System.Drawing.Size(76, 13);
		this.lblAccount.TabIndex = 179;
		this.lblAccount.Text = "Kas/Rekening";
		this.cboAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboAccount.FormattingEnabled = true;
		this.cboAccount.Location = new System.Drawing.Point(99, 152);
		this.cboAccount.Name = "cboAccount";
		this.cboAccount.Size = new System.Drawing.Size(116, 21);
		this.cboAccount.TabIndex = 5;
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(246, 247);
		base.Controls.Add(this.txtCurrencyRate);
		base.Controls.Add(this.lblCurrencyRate);
		base.Controls.Add(this.lblAccount);
		base.Controls.Add(this.cboAccount);
		base.Controls.Add(this.txtAmount);
		base.Controls.Add(this.lblAmount);
		base.Controls.Add(this.txtChequeNo);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.dtpCheque);
		base.Controls.Add(this.Label9);
		base.Controls.Add(this.dtpPayment);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.cboPaymentCode);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.btnDelete);
		base.Controls.Add(this.btnSave);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmPurchaseReturnPayment";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Pembayaran ";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmPurchaseReturnPayment(bool CurrentData, int CurrencyId)
	{
		base.KeyDown += frmPurchaseReturnPayment_KeyDown;
		InitializeComponent();
		_currentData = CurrentData;
		_invoiceCurrencyId = CurrencyId;
		if (_invoiceCurrencyId == 1)
		{
			txtCurrencyRate.Enabled = false;
		}
		else
		{
			txtCurrencyRate.Enabled = true;
		}
		if (_invoiceCurrencyId == 1)
		{
			txtCurrencyRate.Text = Conversions.ToString(1);
		}
		else
		{
			cCurrency cCurrency2 = new cCurrency(_invoiceCurrencyId);
			txtCurrencyRate.Text = Module1.formatCustomDecimal(Conversions.ToString(cCurrency2.Rate), 2);
		}
		txtAmount.AllowedCharacters = FilteredTextBox.InputType.NumeralsAndCurrency;
		ComboBox combo = cboPaymentCode;
		cCombo.getPaymentCode(ref combo, All: false, ShowCheque: false);
		cboPaymentCode = combo;
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

	private void frmPurchaseReturnPayment_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboAccount.SelectedItem;
		cComboItem cComboItem3 = (cComboItem)cboPaymentCode.SelectedItem;
		if (cboPaymentCode.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih tipe pembayaran", MsgBoxStyle.Information);
			cboPaymentCode.Focus();
			return;
		}
		if (!cValidation.isDateWithinRange(dtpPayment.Value, Module1.pubGroupId, Module1.pubDaysLimit))
		{
			Interaction.MsgBox("Anda tidak bisa memasukkan pembayaran sebelum " + Strings.FormatDateTime(DateAndTime.Now.AddDays(checked(Module1.pubDaysLimit * -1)), DateFormat.ShortDate), MsgBoxStyle.Information);
			dtpPayment.Focus();
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
		if ((Operators.CompareString(cboPaymentCode.Text, "C/G", TextCompare: false) == 0) & (Operators.CompareString(txtChequeNo.Text, "", TextCompare: false) == 0))
		{
			Interaction.MsgBox("Masukkan nomer Cek/Giro", MsgBoxStyle.Information);
			txtChequeNo.Focus();
			return;
		}
		if (cboAccount.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih Kas/Rekening", MsgBoxStyle.Information);
			cboAccount.Focus();
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
			MyProject.Forms.frmPurchaseReturn.dgvPayment[2, MyProject.Forms.frmPurchaseReturn.dgvPayment.CurrentRow.Index].Value = cComboItem3.Value;
			MyProject.Forms.frmPurchaseReturn.dgvPayment[3, MyProject.Forms.frmPurchaseReturn.dgvPayment.CurrentRow.Index].Value = cComboItem2.Value;
			MyProject.Forms.frmPurchaseReturn.dgvPayment[13, MyProject.Forms.frmPurchaseReturn.dgvPayment.CurrentRow.Index].Value = cboAccount.Text;
			MyProject.Forms.frmPurchaseReturn.dgvPayment[4, MyProject.Forms.frmPurchaseReturn.dgvPayment.CurrentRow.Index].Value = _currencyId;
			MyProject.Forms.frmPurchaseReturn.dgvPayment[5, MyProject.Forms.frmPurchaseReturn.dgvPayment.CurrentRow.Index].Value = dtpPayment.Value;
			MyProject.Forms.frmPurchaseReturn.dgvPayment[6, MyProject.Forms.frmPurchaseReturn.dgvPayment.CurrentRow.Index].Value = cboPaymentCode.Text;
			MyProject.Forms.frmPurchaseReturn.dgvPayment[12, MyProject.Forms.frmPurchaseReturn.dgvPayment.CurrentRow.Index].Value = Module1.formatCustomDecimal(txtAmount.Text, 2);
			MyProject.Forms.frmPurchaseReturn.dgvPayment[14, MyProject.Forms.frmPurchaseReturn.dgvPayment.CurrentRow.Index].Value = _currencyName;
			MyProject.Forms.frmPurchaseReturn.dgvPayment[15, MyProject.Forms.frmPurchaseReturn.dgvPayment.CurrentRow.Index].Value = txtCurrencyRate.Text;
			if (Operators.CompareString(cboPaymentCode.Text, "C/G", TextCompare: false) == 0)
			{
				MyProject.Forms.frmPurchaseReturn.dgvPayment[8, MyProject.Forms.frmPurchaseReturn.dgvPayment.CurrentRow.Index].Value = dtpCheque.Value;
				MyProject.Forms.frmPurchaseReturn.dgvPayment[9, MyProject.Forms.frmPurchaseReturn.dgvPayment.CurrentRow.Index].Value = txtChequeNo.Text;
			}
		}
		else
		{
			MyProject.Forms.frmPurchaseReturn.dgvPayment.Rows.Add(0, 0, cComboItem3.Value, cComboItem2.Value, _currencyId, dtpPayment.Value, cboPaymentCode.Text, 0, Interaction.IIf(Operators.CompareString(cboPaymentCode.Text, "C/G", TextCompare: false) == 0, dtpCheque.Value, ""), txtChequeNo.Text, 0, 0, Module1.formatCustomDecimal(txtAmount.Text, 2), cboAccount.Text, _currencyName, txtCurrencyRate.Text, DateAndTime.Now);
			MyProject.Forms.frmPurchaseReturn.dgvPayment.CurrentRow.Selected = false;
		}
		MyProject.Forms.frmPurchaseReturn.calculateTotalPayment();
		MyProject.Forms.frmPurchaseReturn.Edited = true;
		Close();
	}

	private void btnDelete_Click(object sender, EventArgs e)
	{
		MyProject.Forms.frmPurchaseReturn.dgvPayment.Rows.RemoveAt(MyProject.Forms.frmPurchaseReturn.dgvPayment.CurrentRow.Index);
		MyProject.Forms.frmPurchaseReturn.calculateTotalPayment();
		MyProject.Forms.frmPurchaseReturn.Edited = true;
		Close();
	}

	private void cboPaymentType_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(cboPaymentCode.Text, "C/G", TextCompare: false) == 0)
		{
			txtChequeNo.Enabled = true;
			dtpCheque.Enabled = true;
		}
		else
		{
			txtChequeNo.Text = "";
			txtChequeNo.Enabled = false;
			dtpCheque.Enabled = false;
		}
		if (Operators.CompareString(cboPaymentCode.Text, "Cash", TextCompare: false) == 0)
		{
			ComboBox combo = cboAccount;
			cCombo.getCashAccount(ref combo, 0, Module1.pubGroupId, All: false, GroupDefault: false, Active: true, "GENERAL", 0);
			cboAccount = combo;
			combo = cboAccount;
			Module1.comboBoundValue(ref combo, _cashAccountId);
			cboAccount = combo;
		}
		else
		{
			ComboBox combo = cboAccount;
			cCombo.getBankAccount(ref combo, 0, Module1.pubGroupId, All: false, GroupDefault: false, Active: true, "GENERAL", 0);
			cboAccount = combo;
			combo = cboAccount;
			Module1.comboBoundValue(ref combo, _bankAccountId);
			cboAccount = combo;
		}
		cboAccount_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void cboAccount_SelectedIndexChanged(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboAccount.SelectedItem;
		if (!Information.IsNothing(cComboItem2) && cboPaymentCode.SelectedIndex > -1 && Conversions.ToDouble(cComboItem2.Value) > 1.0)
		{
			DataTable currencyOfAccount = cCurrency.GetCurrencyOfAccount(Conversions.ToInteger(cComboItem2.Value));
			if (cboPaymentCode.SelectedIndex == 0)
			{
				lblAccount.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Kas (", currencyOfAccount.Rows[0]["currencyName"]), ")"));
			}
			else
			{
				lblAccount.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Rekening (", currencyOfAccount.Rows[0]["currencyName"]), ")"));
			}
			_currencyName = Conversions.ToString(currencyOfAccount.Rows[0]["currencyName"]);
			_currencyId = Conversions.ToInteger(currencyOfAccount.Rows[0]["currencyId"]);
		}
	}
}
