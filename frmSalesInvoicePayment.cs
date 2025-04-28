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
public class frmSalesInvoicePayment : Form
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
	[AccessedThroughProperty("cboPaymentCode")]
	private ComboBox _cboPaymentCode;

	private bool _currentData;

	private string _currencyName;

	private int _cashAccountId;

	private int _bankAccountId;

	[field: AccessedThroughProperty("txtAmount")]
	internal virtual FilteredTextBox txtAmount
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

	[field: AccessedThroughProperty("cboSalesPerson")]
	internal virtual ComboBox cboSalesPerson
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

	[field: AccessedThroughProperty("lblAccount")]
	internal virtual Label lblAccount
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboAccount")]
	internal virtual ComboBox cboAccount
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
			EventHandler value2 = cboPaymentCode_SelectedIndexChanged;
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

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboBank")]
	internal virtual ComboBox cboBank
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
		this.txtAmount = new GCUv2.FilteredTextBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.txtChequeNo = new System.Windows.Forms.TextBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.dtpCheque = new System.Windows.Forms.DateTimePicker();
		this.Label9 = new System.Windows.Forms.Label();
		this.dtpPayment = new System.Windows.Forms.DateTimePicker();
		this.Label4 = new System.Windows.Forms.Label();
		this.cboSalesPerson = new System.Windows.Forms.ComboBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.btnDelete = new System.Windows.Forms.Button();
		this.btnSave = new System.Windows.Forms.Button();
		this.lblAccount = new System.Windows.Forms.Label();
		this.cboAccount = new System.Windows.Forms.ComboBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.cboPaymentCode = new System.Windows.Forms.ComboBox();
		this.Label6 = new System.Windows.Forms.Label();
		this.cboBank = new System.Windows.Forms.ComboBox();
		base.SuspendLayout();
		this.txtAmount.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtAmount.DontFormat = false;
		this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtAmount.Location = new System.Drawing.Point(85, 175);
		this.txtAmount.MaximumDigit = 3;
		this.txtAmount.Name = "txtAmount";
		this.txtAmount.Size = new System.Drawing.Size(116, 26);
		this.txtAmount.TabIndex = 6;
		this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(8, 181);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(43, 13);
		this.Label5.TabIndex = 109;
		this.Label5.Text = "Jumlah ";
		this.txtChequeNo.Location = new System.Drawing.Point(85, 122);
		this.txtChequeNo.Name = "txtChequeNo";
		this.txtChequeNo.Size = new System.Drawing.Size(116, 20);
		this.txtChequeNo.TabIndex = 4;
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(8, 96);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(69, 13);
		this.Label3.TabIndex = 108;
		this.Label3.Text = "Tanggal C/G";
		this.dtpCheque.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpCheque.Location = new System.Drawing.Point(85, 93);
		this.dtpCheque.Name = "dtpCheque";
		this.dtpCheque.Size = new System.Drawing.Size(116, 20);
		this.dtpCheque.TabIndex = 3;
		this.Label9.AutoSize = true;
		this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label9.Location = new System.Drawing.Point(8, 15);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(46, 13);
		this.Label9.TabIndex = 107;
		this.Label9.Text = "Tanggal";
		this.dtpPayment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpPayment.Location = new System.Drawing.Point(85, 12);
		this.dtpPayment.Name = "dtpPayment";
		this.dtpPayment.Size = new System.Drawing.Size(116, 20);
		this.dtpPayment.TabIndex = 0;
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(8, 69);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(46, 13);
		this.Label4.TabIndex = 106;
		this.Label4.Text = "Penagih";
		this.cboSalesPerson.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboSalesPerson.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboSalesPerson.FormattingEnabled = true;
		this.cboSalesPerson.Location = new System.Drawing.Point(85, 66);
		this.cboSalesPerson.Name = "cboSalesPerson";
		this.cboSalesPerson.Size = new System.Drawing.Size(116, 21);
		this.cboSalesPerson.TabIndex = 2;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(8, 125);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(44, 13);
		this.Label2.TabIndex = 105;
		this.Label2.Text = "No C/G";
		this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDelete.Location = new System.Drawing.Point(153, 234);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new System.Drawing.Size(58, 24);
		this.btnDelete.TabIndex = 12;
		this.btnDelete.Text = "Hapus";
		this.btnDelete.UseVisualStyleBackColor = true;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(86, 234);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(61, 24);
		this.btnSave.TabIndex = 11;
		this.btnSave.Text = "Simpan ";
		this.btnSave.UseVisualStyleBackColor = true;
		this.lblAccount.AutoSize = true;
		this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblAccount.Location = new System.Drawing.Point(8, 210);
		this.lblAccount.Name = "lblAccount";
		this.lblAccount.Size = new System.Drawing.Size(76, 13);
		this.lblAccount.TabIndex = 111;
		this.lblAccount.Text = "Kas/Rekening";
		this.cboAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboAccount.FormattingEnabled = true;
		this.cboAccount.Location = new System.Drawing.Point(85, 207);
		this.cboAccount.Name = "cboAccount";
		this.cboAccount.Size = new System.Drawing.Size(116, 21);
		this.cboAccount.TabIndex = 7;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(8, 41);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(28, 13);
		this.Label1.TabIndex = 113;
		this.Label1.Text = "Tipe";
		this.cboPaymentCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboPaymentCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboPaymentCode.FormattingEnabled = true;
		this.cboPaymentCode.Location = new System.Drawing.Point(85, 38);
		this.cboPaymentCode.Name = "cboPaymentCode";
		this.cboPaymentCode.Size = new System.Drawing.Size(116, 21);
		this.cboPaymentCode.TabIndex = 1;
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.Location = new System.Drawing.Point(9, 151);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(32, 13);
		this.Label6.TabIndex = 115;
		this.Label6.Text = "Bank";
		this.cboBank.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboBank.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboBank.FormattingEnabled = true;
		this.cboBank.Location = new System.Drawing.Point(85, 148);
		this.cboBank.Name = "cboBank";
		this.cboBank.Size = new System.Drawing.Size(116, 21);
		this.cboBank.TabIndex = 5;
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(232, 275);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.cboBank);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.cboPaymentCode);
		base.Controls.Add(this.lblAccount);
		base.Controls.Add(this.cboAccount);
		base.Controls.Add(this.txtAmount);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.txtChequeNo);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.dtpCheque);
		base.Controls.Add(this.Label9);
		base.Controls.Add(this.dtpPayment);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.cboSalesPerson);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.btnDelete);
		base.Controls.Add(this.btnSave);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSalesInvoicePayment";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Pembayaran";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmSalesInvoicePayment(bool CurrentData, int SalesPersonId)
	{
		base.KeyDown += frmSalesInvoicePayment_KeyDown;
		InitializeComponent();
		_currentData = CurrentData;
		txtAmount.AllowedCharacters = FilteredTextBox.InputType.NumeralsAndCurrency;
		ComboBox combo = cboPaymentCode;
		cCombo.getPaymentCode(ref combo, All: false, ShowCheque: true);
		cboPaymentCode = combo;
		combo = cboSalesPerson;
		cCombo.getSalesPerson(ref combo, "SALESPERSON_COLLECTOR", SalesPersonId, 0, 0, Module1.pubGroupId, All: false, Dash: false, -1);
		cboSalesPerson = combo;
		combo = cboSalesPerson;
		Module1.comboBoundValue(ref combo, SalesPersonId);
		cboSalesPerson = combo;
		combo = cboBank;
		cCombo.getBank(ref combo, All: false, Active: true);
		cboBank = combo;
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

	private void frmSalesInvoicePayment_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboSalesPerson.SelectedItem;
		cComboItem cComboItem3 = (cComboItem)cboBank.SelectedItem;
		cComboItem cComboItem4 = (cComboItem)cboAccount.SelectedItem;
		cComboItem cComboItem5 = (cComboItem)cboPaymentCode.SelectedItem;
		if (cboPaymentCode.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih tipe pembayaran", MsgBoxStyle.Information);
			cboPaymentCode.Focus();
			return;
		}
		if (cboSalesPerson.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih penagih.", MsgBoxStyle.Information);
			cboSalesPerson.Focus();
			return;
		}
		if (!cValidation.isDateWithinRange(dtpPayment.Value, Module1.pubGroupId, Module1.pubDaysLimitForCustomerPayment))
		{
			Interaction.MsgBox("Anda tidak bisa memasukkan pembayaran sebelum " + Strings.FormatDateTime(DateAndTime.Now.AddDays(checked(Module1.pubDaysLimitForCustomerPayment * -1)), DateFormat.ShortDate), MsgBoxStyle.Information);
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
		if ((Operators.CompareString(cboPaymentCode.Text, "C/G", TextCompare: false) == 0) & (cboBank.SelectedIndex == -1))
		{
			Interaction.MsgBox("Pilih bank.", MsgBoxStyle.Information);
			cboBank.Focus();
			return;
		}
		if (cboAccount.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih Kas/Rekening", MsgBoxStyle.Information);
			cboAccount.Focus();
			return;
		}
		if (_currentData)
		{
			MyProject.Forms.frmSalesInvoice.dgvPayment[2, MyProject.Forms.frmSalesInvoice.dgvPayment.CurrentRow.Index].Value = cComboItem5.Value;
			MyProject.Forms.frmSalesInvoice.dgvPayment[3, MyProject.Forms.frmSalesInvoice.dgvPayment.CurrentRow.Index].Value = cComboItem2.Value;
			MyProject.Forms.frmSalesInvoice.dgvPayment[4, MyProject.Forms.frmSalesInvoice.dgvPayment.CurrentRow.Index].Value = RuntimeHelpers.GetObjectValue((cboBank.SelectedIndex == -1) ? ((object)0) : cComboItem3.Value);
			MyProject.Forms.frmSalesInvoice.dgvPayment[5, MyProject.Forms.frmSalesInvoice.dgvPayment.CurrentRow.Index].Value = dtpPayment.Value;
			MyProject.Forms.frmSalesInvoice.dgvPayment[6, MyProject.Forms.frmSalesInvoice.dgvPayment.CurrentRow.Index].Value = cboPaymentCode.Text;
			MyProject.Forms.frmSalesInvoice.dgvPayment[7, MyProject.Forms.frmSalesInvoice.dgvPayment.CurrentRow.Index].Value = cboSalesPerson.Text;
			MyProject.Forms.frmSalesInvoice.dgvPayment[10, MyProject.Forms.frmSalesInvoice.dgvPayment.CurrentRow.Index].Value = cboBank.Text;
			MyProject.Forms.frmSalesInvoice.dgvPayment[11, MyProject.Forms.frmSalesInvoice.dgvPayment.CurrentRow.Index].Value = Module1.formatCustomDecimal(txtAmount.Text, 2);
			MyProject.Forms.frmSalesInvoice.dgvPayment[12, MyProject.Forms.frmSalesInvoice.dgvPayment.CurrentRow.Index].Value = cboAccount.Text;
			MyProject.Forms.frmSalesInvoice.dgvPayment[13, MyProject.Forms.frmSalesInvoice.dgvPayment.CurrentRow.Index].Value = cComboItem4.Value;
			if (Operators.CompareString(cboPaymentCode.Text, "C/G", TextCompare: false) == 0)
			{
				MyProject.Forms.frmSalesInvoice.dgvPayment[8, MyProject.Forms.frmSalesInvoice.dgvPayment.CurrentRow.Index].Value = dtpCheque.Value;
				MyProject.Forms.frmSalesInvoice.dgvPayment[9, MyProject.Forms.frmSalesInvoice.dgvPayment.CurrentRow.Index].Value = txtChequeNo.Text;
			}
		}
		else
		{
			MyProject.Forms.frmSalesInvoice.dgvPayment.Rows.Add(0, 0, cComboItem5.Value, cComboItem2.Value, (cboBank.SelectedIndex == -1) ? ((object)0) : cComboItem3.Value, dtpPayment.Value, cboPaymentCode.Text, cboSalesPerson.Text, Interaction.IIf(Operators.CompareString(cboPaymentCode.Text, "C/G", TextCompare: false) == 0, dtpCheque.Value, ""), txtChequeNo.Text, cboBank.Text, Module1.formatCustomDecimal(txtAmount.Text, 2), cboAccount.Text, cComboItem4.Value, DateTime.MinValue, DateTime.MinValue, DateAndTime.Now);
			MyProject.Forms.frmSalesInvoice.dgvPayment.CurrentRow.Selected = false;
		}
		MyProject.Forms.frmSalesInvoice.Edited = true;
		MyProject.Forms.frmSalesInvoice.calculateTotalPayment();
		Close();
	}

	private void btnDelete_Click(object sender, EventArgs e)
	{
		MyProject.Forms.frmSalesInvoice.dgvPayment.Rows.RemoveAt(MyProject.Forms.frmSalesInvoice.dgvPayment.CurrentRow.Index);
		MyProject.Forms.frmSalesInvoice.calculateTotalPayment();
		MyProject.Forms.frmSalesInvoice.Edited = true;
		Close();
	}

	private void cboPaymentCode_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(cboPaymentCode.Text, "C/G", TextCompare: false) == 0)
		{
			txtChequeNo.Enabled = true;
			dtpCheque.Enabled = true;
			cboBank.Enabled = true;
		}
		else
		{
			txtChequeNo.Text = "";
			txtChequeNo.Enabled = false;
			dtpCheque.Enabled = false;
			cboBank.Enabled = false;
		}
		if (Operators.CompareString(cboPaymentCode.Text, "Cash", TextCompare: false) == 0)
		{
			ComboBox combo = cboAccount;
			cCombo.getCashAccount(ref combo, 0, Module1.pubGroupId, All: false, GroupDefault: false, Active: true, "GENERAL", 1);
			cboAccount = combo;
			combo = cboAccount;
			Module1.comboBoundValue(ref combo, _cashAccountId);
			cboAccount = combo;
			lblAccount.Text = "Kas";
		}
		else
		{
			ComboBox combo = cboAccount;
			cCombo.getBankAccount(ref combo, 0, Module1.pubGroupId, All: false, GroupDefault: false, Active: true, "GENERAL", 1);
			cboAccount = combo;
			combo = cboAccount;
			Module1.comboBoundValue(ref combo, _bankAccountId);
			cboAccount = combo;
			lblAccount.Text = "Rekening";
		}
	}
}
