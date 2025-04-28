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
public class frmSalesReturnPayment : Form
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

	private bool _currentData;

	private string _currencyName;

	private int _cashAccountId;

	private int _bankAccountId;

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
		this.Label1 = new System.Windows.Forms.Label();
		this.cboPaymentCode = new System.Windows.Forms.ComboBox();
		this.lblAccount = new System.Windows.Forms.Label();
		this.cboAccount = new System.Windows.Forms.ComboBox();
		this.txtAmount = new GCUv2.FilteredTextBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label9 = new System.Windows.Forms.Label();
		this.dtpPayment = new System.Windows.Forms.DateTimePicker();
		this.Label4 = new System.Windows.Forms.Label();
		this.cboSalesPerson = new System.Windows.Forms.ComboBox();
		this.btnDelete = new System.Windows.Forms.Button();
		this.btnSave = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(11, 41);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(28, 13);
		this.Label1.TabIndex = 132;
		this.Label1.Text = "Tipe";
		this.cboPaymentCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboPaymentCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboPaymentCode.FormattingEnabled = true;
		this.cboPaymentCode.Location = new System.Drawing.Point(88, 38);
		this.cboPaymentCode.Name = "cboPaymentCode";
		this.cboPaymentCode.Size = new System.Drawing.Size(116, 21);
		this.cboPaymentCode.TabIndex = 117;
		this.lblAccount.AutoSize = true;
		this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblAccount.Location = new System.Drawing.Point(11, 128);
		this.lblAccount.Name = "lblAccount";
		this.lblAccount.Size = new System.Drawing.Size(76, 13);
		this.lblAccount.TabIndex = 131;
		this.lblAccount.Text = "Kas/Rekening";
		this.cboAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboAccount.FormattingEnabled = true;
		this.cboAccount.Location = new System.Drawing.Point(88, 125);
		this.cboAccount.Name = "cboAccount";
		this.cboAccount.Size = new System.Drawing.Size(116, 21);
		this.cboAccount.TabIndex = 123;
		this.txtAmount.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtAmount.DontFormat = false;
		this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtAmount.Location = new System.Drawing.Point(88, 93);
		this.txtAmount.MaximumDigit = 3;
		this.txtAmount.Name = "txtAmount";
		this.txtAmount.Size = new System.Drawing.Size(116, 26);
		this.txtAmount.TabIndex = 122;
		this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(11, 99);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(43, 13);
		this.Label5.TabIndex = 130;
		this.Label5.Text = "Jumlah ";
		this.Label9.AutoSize = true;
		this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label9.Location = new System.Drawing.Point(11, 15);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(46, 13);
		this.Label9.TabIndex = 128;
		this.Label9.Text = "Tanggal";
		this.dtpPayment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpPayment.Location = new System.Drawing.Point(88, 12);
		this.dtpPayment.Name = "dtpPayment";
		this.dtpPayment.Size = new System.Drawing.Size(116, 20);
		this.dtpPayment.TabIndex = 116;
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(11, 69);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(46, 13);
		this.Label4.TabIndex = 127;
		this.Label4.Text = "Penagih";
		this.cboSalesPerson.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboSalesPerson.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboSalesPerson.FormattingEnabled = true;
		this.cboSalesPerson.Location = new System.Drawing.Point(88, 66);
		this.cboSalesPerson.Name = "cboSalesPerson";
		this.cboSalesPerson.Size = new System.Drawing.Size(116, 21);
		this.cboSalesPerson.TabIndex = 118;
		this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDelete.Location = new System.Drawing.Point(156, 152);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new System.Drawing.Size(58, 24);
		this.btnDelete.TabIndex = 125;
		this.btnDelete.Text = "Hapus";
		this.btnDelete.UseVisualStyleBackColor = true;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(89, 152);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(61, 24);
		this.btnSave.TabIndex = 124;
		this.btnSave.Text = "Simpan ";
		this.btnSave.UseVisualStyleBackColor = true;
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(227, 188);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.cboPaymentCode);
		base.Controls.Add(this.lblAccount);
		base.Controls.Add(this.cboAccount);
		base.Controls.Add(this.txtAmount);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.Label9);
		base.Controls.Add(this.dtpPayment);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.cboSalesPerson);
		base.Controls.Add(this.btnDelete);
		base.Controls.Add(this.btnSave);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSalesReturnPayment";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Pembayaran";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmSalesReturnPayment(bool CurrentData, int SalesPersonId)
	{
		base.KeyDown += frmSalesReturnPayment_KeyDown;
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

	private void frmSalesReturnPayment_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboSalesPerson.SelectedItem;
		cComboItem cComboItem3 = (cComboItem)cboAccount.SelectedItem;
		cComboItem cComboItem4 = (cComboItem)cboPaymentCode.SelectedItem;
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
		if (cboAccount.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih Kas/Rekening", MsgBoxStyle.Information);
			cboAccount.Focus();
			return;
		}
		if (_currentData)
		{
			MyProject.Forms.frmSalesReturn.dgvPayment[1, MyProject.Forms.frmSalesReturn.dgvPayment.CurrentRow.Index].Value = cComboItem4.Value;
			MyProject.Forms.frmSalesReturn.dgvPayment[2, MyProject.Forms.frmSalesReturn.dgvPayment.CurrentRow.Index].Value = cComboItem2.Value;
			MyProject.Forms.frmSalesReturn.dgvPayment[3, MyProject.Forms.frmSalesReturn.dgvPayment.CurrentRow.Index].Value = dtpPayment.Value;
			MyProject.Forms.frmSalesReturn.dgvPayment[4, MyProject.Forms.frmSalesReturn.dgvPayment.CurrentRow.Index].Value = cboPaymentCode.Text;
			MyProject.Forms.frmSalesReturn.dgvPayment[5, MyProject.Forms.frmSalesReturn.dgvPayment.CurrentRow.Index].Value = cboSalesPerson.Text;
			MyProject.Forms.frmSalesReturn.dgvPayment[6, MyProject.Forms.frmSalesReturn.dgvPayment.CurrentRow.Index].Value = Module1.formatCustomDecimal(txtAmount.Text, 2);
			MyProject.Forms.frmSalesReturn.dgvPayment[7, MyProject.Forms.frmSalesReturn.dgvPayment.CurrentRow.Index].Value = cboAccount.Text;
			MyProject.Forms.frmSalesReturn.dgvPayment[8, MyProject.Forms.frmSalesReturn.dgvPayment.CurrentRow.Index].Value = cComboItem3.Value;
		}
		else
		{
			MyProject.Forms.frmSalesReturn.dgvPayment.Rows.Add(0, cComboItem4.Value, cComboItem2.Value, dtpPayment.Value, cboPaymentCode.Text, cboSalesPerson.Text, Module1.formatCustomDecimal(txtAmount.Text, 2), cboAccount.Text, cComboItem3.Value);
			MyProject.Forms.frmSalesReturn.dgvPayment.CurrentRow.Selected = false;
		}
		MyProject.Forms.frmSalesReturn.calculateTotalPayment();
		Close();
	}

	private void btnDelete_Click(object sender, EventArgs e)
	{
		MyProject.Forms.frmSalesReturn.dgvPayment.Rows.RemoveAt(MyProject.Forms.frmSalesReturn.dgvPayment.CurrentRow.Index);
		MyProject.Forms.frmSalesReturn.calculateTotalPayment();
		Close();
	}

	private void cboPaymentCode_SelectedIndexChanged(object sender, EventArgs e)
	{
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
