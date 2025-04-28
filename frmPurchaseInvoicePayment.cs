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
public class frmPurchaseInvoicePayment : Form
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

	private string _currencyName;

	private int _cashAccountId;

	private int _bankAccountId;

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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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

	[field: AccessedThroughProperty("chkPayInFront")]
	internal virtual CheckBox chkPayInFront
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

	[field: AccessedThroughProperty("dtpCheque")]
	internal virtual DateTimePicker dtpCheque
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

	[field: AccessedThroughProperty("txtChequeNo")]
	internal virtual TextBox txtChequeNo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

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

	[field: AccessedThroughProperty("lblCurrencyRate")]
	internal virtual Label lblCurrencyRate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCurrencyRate")]
	internal virtual FilteredTextBox txtCurrencyRate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
		this.Label4 = new System.Windows.Forms.Label();
		this.cboPaymentCode = new System.Windows.Forms.ComboBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.btnDelete = new System.Windows.Forms.Button();
		this.btnSave = new System.Windows.Forms.Button();
		this.Label9 = new System.Windows.Forms.Label();
		this.dtpPayment = new System.Windows.Forms.DateTimePicker();
		this.chkPayInFront = new System.Windows.Forms.CheckBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.dtpCheque = new System.Windows.Forms.DateTimePicker();
		this.Label3 = new System.Windows.Forms.Label();
		this.txtChequeNo = new System.Windows.Forms.TextBox();
		this.lblAmount = new System.Windows.Forms.Label();
		this.txtAmount = new GCUv2.FilteredTextBox();
		this.lblAccount = new System.Windows.Forms.Label();
		this.cboAccount = new System.Windows.Forms.ComboBox();
		this.lblCurrencyRate = new System.Windows.Forms.Label();
		this.txtCurrencyRate = new GCUv2.FilteredTextBox();
		base.SuspendLayout();
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(10, 41);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(28, 13);
		this.Label4.TabIndex = 84;
		this.Label4.Text = "Tipe";
		this.cboPaymentCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboPaymentCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboPaymentCode.FormattingEnabled = true;
		this.cboPaymentCode.Location = new System.Drawing.Point(95, 38);
		this.cboPaymentCode.Name = "cboPaymentCode";
		this.cboPaymentCode.Size = new System.Drawing.Size(121, 21);
		this.cboPaymentCode.TabIndex = 1;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(10, 69);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(26, 13);
		this.Label1.TabIndex = 79;
		this.Label1.Text = "Bon";
		this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDelete.Location = new System.Drawing.Point(163, 239);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new System.Drawing.Size(58, 24);
		this.btnDelete.TabIndex = 12;
		this.btnDelete.Text = "Hapus";
		this.btnDelete.UseVisualStyleBackColor = true;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(96, 239);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(61, 24);
		this.btnSave.TabIndex = 11;
		this.btnSave.Text = "Simpan ";
		this.btnSave.UseVisualStyleBackColor = true;
		this.Label9.AutoSize = true;
		this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label9.Location = new System.Drawing.Point(10, 15);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(46, 13);
		this.Label9.TabIndex = 86;
		this.Label9.Text = "Tanggal";
		this.dtpPayment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpPayment.Location = new System.Drawing.Point(95, 12);
		this.dtpPayment.Name = "dtpPayment";
		this.dtpPayment.Size = new System.Drawing.Size(121, 20);
		this.dtpPayment.TabIndex = 0;
		this.chkPayInFront.AutoSize = true;
		this.chkPayInFront.Location = new System.Drawing.Point(95, 69);
		this.chkPayInFront.Name = "chkPayInFront";
		this.chkPayInFront.Size = new System.Drawing.Size(45, 17);
		this.chkPayInFront.TabIndex = 2;
		this.chkPayInFront.Text = "Bon";
		this.chkPayInFront.UseVisualStyleBackColor = true;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(10, 125);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(44, 13);
		this.Label2.TabIndex = 81;
		this.Label2.Text = "No C/G";
		this.dtpCheque.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpCheque.Location = new System.Drawing.Point(95, 93);
		this.dtpCheque.Name = "dtpCheque";
		this.dtpCheque.Size = new System.Drawing.Size(121, 20);
		this.dtpCheque.TabIndex = 3;
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(10, 96);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(69, 13);
		this.Label3.TabIndex = 88;
		this.Label3.Text = "Tanggal C/G";
		this.txtChequeNo.Location = new System.Drawing.Point(95, 122);
		this.txtChequeNo.Name = "txtChequeNo";
		this.txtChequeNo.Size = new System.Drawing.Size(121, 20);
		this.txtChequeNo.TabIndex = 4;
		this.lblAmount.AutoSize = true;
		this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblAmount.Location = new System.Drawing.Point(10, 154);
		this.lblAmount.Name = "lblAmount";
		this.lblAmount.Size = new System.Drawing.Size(43, 13);
		this.lblAmount.TabIndex = 95;
		this.lblAmount.Text = "Jumlah ";
		this.txtAmount.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtAmount.DontFormat = false;
		this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtAmount.Location = new System.Drawing.Point(95, 148);
		this.txtAmount.MaximumDigit = 3;
		this.txtAmount.Name = "txtAmount";
		this.txtAmount.Size = new System.Drawing.Size(121, 26);
		this.txtAmount.TabIndex = 5;
		this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.lblAccount.AutoSize = true;
		this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblAccount.Location = new System.Drawing.Point(10, 183);
		this.lblAccount.Name = "lblAccount";
		this.lblAccount.Size = new System.Drawing.Size(76, 13);
		this.lblAccount.TabIndex = 98;
		this.lblAccount.Text = "Kas/Rekening";
		this.cboAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboAccount.FormattingEnabled = true;
		this.cboAccount.Location = new System.Drawing.Point(95, 180);
		this.cboAccount.Name = "cboAccount";
		this.cboAccount.Size = new System.Drawing.Size(121, 21);
		this.cboAccount.TabIndex = 6;
		this.lblCurrencyRate.AutoSize = true;
		this.lblCurrencyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblCurrencyRate.Location = new System.Drawing.Point(10, 213);
		this.lblCurrencyRate.Name = "lblCurrencyRate";
		this.lblCurrencyRate.Size = new System.Drawing.Size(28, 13);
		this.lblCurrencyRate.TabIndex = 101;
		this.lblCurrencyRate.Text = "Kurs";
		this.txtCurrencyRate.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtCurrencyRate.DontFormat = false;
		this.txtCurrencyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtCurrencyRate.Location = new System.Drawing.Point(95, 207);
		this.txtCurrencyRate.MaximumDigit = 3;
		this.txtCurrencyRate.Name = "txtCurrencyRate";
		this.txtCurrencyRate.Size = new System.Drawing.Size(121, 26);
		this.txtCurrencyRate.TabIndex = 8;
		this.txtCurrencyRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(239, 273);
		base.Controls.Add(this.txtCurrencyRate);
		base.Controls.Add(this.lblCurrencyRate);
		base.Controls.Add(this.lblAccount);
		base.Controls.Add(this.cboAccount);
		base.Controls.Add(this.txtAmount);
		base.Controls.Add(this.lblAmount);
		base.Controls.Add(this.chkPayInFront);
		base.Controls.Add(this.txtChequeNo);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.dtpCheque);
		base.Controls.Add(this.Label9);
		base.Controls.Add(this.dtpPayment);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.cboPaymentCode);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.btnDelete);
		base.Controls.Add(this.btnSave);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "frmPurchaseInvoicePayment";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Pembayaran";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmPurchaseInvoicePayment(bool CurrentData, int CurrencyId)
	{
		base.KeyDown += frmPurchaseInvoicePayment_KeyDown;
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
		cCombo.getPaymentCode(ref combo, All: false, ShowCheque: true);
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

	private void frmPurchaseInvoicePayment_KeyDown(object sender, KeyEventArgs e)
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
			MyProject.Forms.frmPurchaseInvoice.dgvPayment[2, MyProject.Forms.frmPurchaseInvoice.dgvPayment.CurrentRow.Index].Value = cComboItem3.Value;
			MyProject.Forms.frmPurchaseInvoice.dgvPayment[3, MyProject.Forms.frmPurchaseInvoice.dgvPayment.CurrentRow.Index].Value = cComboItem2.Value;
			MyProject.Forms.frmPurchaseInvoice.dgvPayment[13, MyProject.Forms.frmPurchaseInvoice.dgvPayment.CurrentRow.Index].Value = cboAccount.Text;
			MyProject.Forms.frmPurchaseInvoice.dgvPayment[4, MyProject.Forms.frmPurchaseInvoice.dgvPayment.CurrentRow.Index].Value = dtpPayment.Value;
			MyProject.Forms.frmPurchaseInvoice.dgvPayment[5, MyProject.Forms.frmPurchaseInvoice.dgvPayment.CurrentRow.Index].Value = cboPaymentCode.Text;
			MyProject.Forms.frmPurchaseInvoice.dgvPayment[12, MyProject.Forms.frmPurchaseInvoice.dgvPayment.CurrentRow.Index].Value = Module1.formatCustomDecimal(txtAmount.Text, 2);
			MyProject.Forms.frmPurchaseInvoice.dgvPayment[14, MyProject.Forms.frmPurchaseInvoice.dgvPayment.CurrentRow.Index].Value = _currencyName;
			MyProject.Forms.frmPurchaseInvoice.dgvPayment[15, MyProject.Forms.frmPurchaseInvoice.dgvPayment.CurrentRow.Index].Value = txtCurrencyRate.Text;
			MyProject.Forms.frmPurchaseInvoice.dgvPayment[6, MyProject.Forms.frmPurchaseInvoice.dgvPayment.CurrentRow.Index].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(chkPayInFront.Checked, "Ya", "-"));
			if (Operators.CompareString(cboPaymentCode.Text, "C/G", TextCompare: false) == 0)
			{
				MyProject.Forms.frmPurchaseInvoice.dgvPayment[8, MyProject.Forms.frmPurchaseInvoice.dgvPayment.CurrentRow.Index].Value = dtpCheque.Value;
				MyProject.Forms.frmPurchaseInvoice.dgvPayment[9, MyProject.Forms.frmPurchaseInvoice.dgvPayment.CurrentRow.Index].Value = txtChequeNo.Text;
			}
		}
		else
		{
			MyProject.Forms.frmPurchaseInvoice.dgvPayment.Rows.Add(0, 0, cComboItem3.Value, cComboItem2.Value, dtpPayment.Value, cboPaymentCode.Text, Interaction.IIf(chkPayInFront.Checked, "Ya", "-"), 0, Interaction.IIf(Operators.CompareString(cboPaymentCode.Text, "C/G", TextCompare: false) == 0, dtpCheque.Value, ""), txtChequeNo.Text, 0, 0, Module1.formatCustomDecimal(txtAmount.Text, 2), cboAccount.Text, _currencyName, txtCurrencyRate.Text, DateAndTime.Now);
			MyProject.Forms.frmPurchaseInvoice.dgvPayment.CurrentRow.Selected = false;
		}
		MyProject.Forms.frmPurchaseInvoice.calculateTotalPayment();
		Close();
	}

	private void btnDelete_Click(object sender, EventArgs e)
	{
		MyProject.Forms.frmPurchaseInvoice.dgvPayment.Rows.RemoveAt(MyProject.Forms.frmPurchaseInvoice.dgvPayment.CurrentRow.Index);
		MyProject.Forms.frmPurchaseInvoice.calculateTotalPayment();
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
			cCombo.getCashAccount(ref combo, 0, Module1.pubGroupId, All: false, GroupDefault: false, Active: true, "GENERAL", _invoiceCurrencyId);
			cboAccount = combo;
			combo = cboAccount;
			Module1.comboBoundValue(ref combo, _cashAccountId);
			cboAccount = combo;
			cboAccount_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
		}
		else
		{
			ComboBox combo = cboAccount;
			cCombo.getBankAccount(ref combo, 0, Module1.pubGroupId, All: false, GroupDefault: false, Active: true, "GENERAL", _invoiceCurrencyId);
			cboAccount = combo;
			combo = cboAccount;
			Module1.comboBoundValue(ref combo, _bankAccountId);
			cboAccount = combo;
			cboAccount_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
		}
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
		}
	}
}
