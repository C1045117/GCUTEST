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
public class frmSettingAccountInput : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboAccountType")]
	private ComboBox _cboAccountType;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSave")]
	private Button _btnSave;

	private int _currentId;

	internal virtual ComboBox cboAccountType
	{
		[CompilerGenerated]
		get
		{
			return _cboAccountType;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cboAccountType_SelectedIndexChanged;
			ComboBox comboBox = _cboAccountType;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_cboAccountType = value;
			comboBox = _cboAccountType;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboActive")]
	internal virtual ComboBox cboActive
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

	[field: AccessedThroughProperty("txtName")]
	internal virtual TextBox txtName
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

	[field: AccessedThroughProperty("txtNumber")]
	internal virtual TextBox txtNumber
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

	[field: AccessedThroughProperty("cboParentAccount")]
	internal virtual ComboBox cboParentAccount
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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
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

	[field: AccessedThroughProperty("dtpBalance")]
	internal virtual DateTimePicker dtpBalance
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

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkBankExpense")]
	internal virtual CheckBox chkBankExpense
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkBankIncome")]
	internal virtual CheckBox chkBankIncome
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkCashExpense")]
	internal virtual CheckBox chkCashExpense
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

	[field: AccessedThroughProperty("chkCashIncome")]
	internal virtual CheckBox chkCashIncome
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label12")]
	internal virtual Label Label12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboBranch")]
	internal virtual ComboBox cboBranch
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtBalance")]
	internal virtual FilteredTextBox txtBalance
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkIsParent")]
	internal virtual CheckBox chkIsParent
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboCurrency")]
	internal virtual ComboBox cboCurrency
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label13")]
	internal virtual Label Label13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public string CurrentId
	{
		get
		{
			return Conversions.ToString(_currentId);
		}
		set
		{
			_currentId = Conversions.ToInteger(value);
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
		this.cboAccountType = new System.Windows.Forms.ComboBox();
		this.Label9 = new System.Windows.Forms.Label();
		this.cboActive = new System.Windows.Forms.ComboBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.txtName = new System.Windows.Forms.TextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.txtNumber = new System.Windows.Forms.TextBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.cboParentAccount = new System.Windows.Forms.ComboBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.dtpBalance = new System.Windows.Forms.DateTimePicker();
		this.btnSave = new System.Windows.Forms.Button();
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.chkBankExpense = new System.Windows.Forms.CheckBox();
		this.Label8 = new System.Windows.Forms.Label();
		this.chkBankIncome = new System.Windows.Forms.CheckBox();
		this.chkCashExpense = new System.Windows.Forms.CheckBox();
		this.Label7 = new System.Windows.Forms.Label();
		this.chkCashIncome = new System.Windows.Forms.CheckBox();
		this.Label12 = new System.Windows.Forms.Label();
		this.cboBranch = new System.Windows.Forms.ComboBox();
		this.Label11 = new System.Windows.Forms.Label();
		this.txtBalance = new GCUv2.FilteredTextBox();
		this.Label10 = new System.Windows.Forms.Label();
		this.chkIsParent = new System.Windows.Forms.CheckBox();
		this.cboCurrency = new System.Windows.Forms.ComboBox();
		this.Label13 = new System.Windows.Forms.Label();
		this.GroupBox1.SuspendLayout();
		base.SuspendLayout();
		this.cboAccountType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboAccountType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboAccountType.FormattingEnabled = true;
		this.cboAccountType.Location = new System.Drawing.Point(109, 65);
		this.cboAccountType.Name = "cboAccountType";
		this.cboAccountType.Size = new System.Drawing.Size(152, 21);
		this.cboAccountType.TabIndex = 2;
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(10, 68);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(56, 13);
		this.Label9.TabIndex = 47;
		this.Label9.Text = "Tipe Akun";
		this.cboActive.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboActive.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboActive.FormattingEnabled = true;
		this.cboActive.Location = new System.Drawing.Point(109, 298);
		this.cboActive.Name = "cboActive";
		this.cboActive.Size = new System.Drawing.Size(84, 21);
		this.cboActive.TabIndex = 13;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(10, 301);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(28, 13);
		this.Label2.TabIndex = 46;
		this.Label2.Text = "Aktif";
		this.txtName.Location = new System.Drawing.Point(109, 39);
		this.txtName.Name = "txtName";
		this.txtName.Size = new System.Drawing.Size(152, 20);
		this.txtName.TabIndex = 1;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(10, 42);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(63, 13);
		this.Label1.TabIndex = 45;
		this.Label1.Text = "Nama Akun";
		this.txtNumber.Location = new System.Drawing.Point(109, 13);
		this.txtNumber.Name = "txtNumber";
		this.txtNumber.Size = new System.Drawing.Size(152, 20);
		this.txtNumber.TabIndex = 0;
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(10, 16);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(66, 13);
		this.Label3.TabIndex = 50;
		this.Label3.Text = "Nomer Akun";
		this.cboParentAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboParentAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboParentAccount.FormattingEnabled = true;
		this.cboParentAccount.Location = new System.Drawing.Point(107, 143);
		this.cboParentAccount.Name = "cboParentAccount";
		this.cboParentAccount.Size = new System.Drawing.Size(211, 21);
		this.cboParentAccount.TabIndex = 5;
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(10, 145);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(63, 13);
		this.Label4.TabIndex = 52;
		this.Label4.Text = "Bagian dari:";
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(10, 201);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(60, 13);
		this.Label5.TabIndex = 54;
		this.Label5.Text = "Saldo Awal";
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.Location = new System.Drawing.Point(265, 201);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(76, 13);
		this.Label6.TabIndex = 58;
		this.Label6.Text = "Tanggal Saldo";
		this.Label6.Visible = false;
		this.dtpBalance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpBalance.Location = new System.Drawing.Point(364, 199);
		this.dtpBalance.Name = "dtpBalance";
		this.dtpBalance.Size = new System.Drawing.Size(111, 20);
		this.dtpBalance.TabIndex = 8;
		this.dtpBalance.Visible = false;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(107, 332);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(98, 24);
		this.btnSave.TabIndex = 20;
		this.btnSave.Text = "Simpan && Tutup";
		this.btnSave.UseVisualStyleBackColor = true;
		this.GroupBox1.Controls.Add(this.chkBankExpense);
		this.GroupBox1.Controls.Add(this.Label8);
		this.GroupBox1.Controls.Add(this.chkBankIncome);
		this.GroupBox1.Controls.Add(this.chkCashExpense);
		this.GroupBox1.Controls.Add(this.Label7);
		this.GroupBox1.Controls.Add(this.chkCashIncome);
		this.GroupBox1.Location = new System.Drawing.Point(107, 225);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(277, 67);
		this.GroupBox1.TabIndex = 68;
		this.GroupBox1.TabStop = false;
		this.chkBankExpense.AutoSize = true;
		this.chkBankExpense.Location = new System.Drawing.Point(186, 42);
		this.chkBankExpense.Name = "chkBankExpense";
		this.chkBankExpense.Size = new System.Drawing.Size(86, 17);
		this.chkBankExpense.TabIndex = 12;
		this.chkBankExpense.Text = "Pengeluaran";
		this.chkBankExpense.UseVisualStyleBackColor = true;
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(9, 42);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(81, 13);
		this.Label8.TabIndex = 71;
		this.Label8.Text = "Transaksi Bank";
		this.chkBankIncome.AutoSize = true;
		this.chkBankIncome.Location = new System.Drawing.Point(96, 42);
		this.chkBankIncome.Name = "chkBankIncome";
		this.chkBankIncome.Size = new System.Drawing.Size(84, 17);
		this.chkBankIncome.TabIndex = 11;
		this.chkBankIncome.Text = "Pendapatan";
		this.chkBankIncome.UseVisualStyleBackColor = true;
		this.chkCashExpense.AutoSize = true;
		this.chkCashExpense.Location = new System.Drawing.Point(186, 19);
		this.chkCashExpense.Name = "chkCashExpense";
		this.chkCashExpense.Size = new System.Drawing.Size(86, 17);
		this.chkCashExpense.TabIndex = 10;
		this.chkCashExpense.Text = "Pengeluaran";
		this.chkCashExpense.UseVisualStyleBackColor = true;
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(9, 20);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(74, 13);
		this.Label7.TabIndex = 68;
		this.Label7.Text = "Transaksi Kas";
		this.chkCashIncome.AutoSize = true;
		this.chkCashIncome.Location = new System.Drawing.Point(96, 19);
		this.chkCashIncome.Name = "chkCashIncome";
		this.chkCashIncome.Size = new System.Drawing.Size(84, 17);
		this.chkCashIncome.TabIndex = 9;
		this.chkCashIncome.Text = "Pendapatan";
		this.chkCashIncome.UseVisualStyleBackColor = true;
		this.Label12.AutoSize = true;
		this.Label12.Location = new System.Drawing.Point(10, 244);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(79, 13);
		this.Label12.TabIndex = 69;
		this.Label12.Text = "Opsi Kas/Bank";
		this.cboBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboBranch.FormattingEnabled = true;
		this.cboBranch.Location = new System.Drawing.Point(106, 170);
		this.cboBranch.Name = "cboBranch";
		this.cboBranch.Size = new System.Drawing.Size(152, 21);
		this.cboBranch.TabIndex = 6;
		this.Label11.AutoSize = true;
		this.Label11.Location = new System.Drawing.Point(10, 173);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(95, 13);
		this.Label11.TabIndex = 76;
		this.Label11.Text = "Cabang Kas/Bank";
		this.txtBalance.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtBalance.Location = new System.Drawing.Point(106, 196);
		this.txtBalance.MaximumDigit = 3;
		this.txtBalance.Name = "txtBalance";
		this.txtBalance.Size = new System.Drawing.Size(153, 21);
		this.txtBalance.TabIndex = 7;
		this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.Label10.AutoSize = true;
		this.Label10.Location = new System.Drawing.Point(10, 120);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(36, 13);
		this.Label10.TabIndex = 78;
		this.Label10.Text = "Grup?";
		this.chkIsParent.AutoSize = true;
		this.chkIsParent.Location = new System.Drawing.Point(109, 120);
		this.chkIsParent.Name = "chkIsParent";
		this.chkIsParent.Size = new System.Drawing.Size(292, 17);
		this.chkIsParent.TabIndex = 4;
		this.chkIsParent.Text = "Ya (Akun merupakan kumpulan dari beberapa akun lain)";
		this.chkIsParent.UseVisualStyleBackColor = true;
		this.cboCurrency.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboCurrency.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboCurrency.FormattingEnabled = true;
		this.cboCurrency.Location = new System.Drawing.Point(109, 93);
		this.cboCurrency.Name = "cboCurrency";
		this.cboCurrency.Size = new System.Drawing.Size(152, 21);
		this.cboCurrency.TabIndex = 3;
		this.Label13.AutoSize = true;
		this.Label13.Location = new System.Drawing.Point(10, 96);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(60, 13);
		this.Label13.TabIndex = 80;
		this.Label13.Text = "Mata Uang";
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(405, 367);
		base.Controls.Add(this.cboCurrency);
		base.Controls.Add(this.Label13);
		base.Controls.Add(this.Label10);
		base.Controls.Add(this.chkIsParent);
		base.Controls.Add(this.txtBalance);
		base.Controls.Add(this.cboBranch);
		base.Controls.Add(this.Label11);
		base.Controls.Add(this.Label12);
		base.Controls.Add(this.GroupBox1);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.dtpBalance);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.cboParentAccount);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.txtNumber);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.cboAccountType);
		base.Controls.Add(this.Label9);
		base.Controls.Add(this.cboActive);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.txtName);
		base.Controls.Add(this.Label1);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSettingAccountInput";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Setting - Akun";
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmSettingAccountInput(int AccountId)
	{
		base.KeyDown += frmSettingAccountInput_KeyDown;
		InitializeComponent();
		DoubleBuffered = true;
		_currentId = AccountId;
		txtBalance.AllowedCharacters = FilteredTextBox.InputType.NumeralsAndCurrency;
		ComboBox combo = cboActive;
		cCombo.getYesNo(ref combo, All: false);
		cboActive = combo;
		combo = cboAccountType;
		cCombo.getAccountType(ref combo, All: false);
		cboAccountType = combo;
		combo = cboParentAccount;
		cCombo.getAccount(ref combo, All: false, -1, 0, 1, _currentId, 99, 0, 0, 0, 1);
		cboParentAccount = combo;
		combo = cboCurrency;
		cCombo.getCurrency(ref combo, All: false, 1);
		cboCurrency = combo;
		combo = cboBranch;
		cCombo.getBranch(ref combo, 0, blnAll: false);
		cboBranch = combo;
		txtName.SelectionStart = 0;
		txtName.SelectionLength = Strings.Len(txtName.Text);
		cboActive.SelectedIndex = 0;
		txtName.Focus();
	}

	private void frmSettingAccountInput_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	public void loadData()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					cAccount cAccount2 = new cAccount(_currentId);
					txtName.Text = cAccount2.Name;
					txtNumber.Text = cAccount2.Number;
					ComboBox cboSource = cboAccountType;
					Module1.comboBoundValue(ref cboSource, cAccount2.TypeId);
					cboAccountType = cboSource;
					if (cAccount2.Id != cAccount2.ParentId)
					{
						cboSource = cboParentAccount;
						Module1.comboBoundValue(ref cboSource, cAccount2.ParentId);
						cboParentAccount = cboSource;
					}
					else
					{
						cboSource = cboParentAccount;
						Module1.comboBoundValue(ref cboSource, 0.0);
						cboParentAccount = cboSource;
					}
					chkIsParent.Checked = cAccount2.IsParent != 0;
					txtBalance.Text = Module1.formatCustomDecimal(Conversions.ToString(cAccount2.BalanceAmount), 2);
					dtpBalance.Value = cAccount2.BalanceDate;
					chkCashIncome.Checked = cAccount2.CashIncome != 0;
					chkCashExpense.Checked = cAccount2.CashExpense != 0;
					chkBankIncome.Checked = cAccount2.BankIncome != 0;
					chkBankExpense.Checked = cAccount2.BankExpense != 0;
					cboCurrency.Enabled = false;
					cboSource = cboCurrency;
					Module1.comboBoundValue(ref cboSource, cAccount2.CurrencyId);
					cboCurrency = cboSource;
					cboSource = cboBranch;
					Module1.comboBoundValue(ref cboSource, cAccount2.BranchId);
					cboBranch = cboSource;
					cboSource = cboActive;
					Module1.comboBoundValue(ref cboSource, cAccount2.Active);
					cboActive = cboSource;
					if (cAccount2.BuiltIn == 1)
					{
						txtName.Enabled = false;
						cboAccountType.Enabled = false;
						cboCurrency.Enabled = false;
						cboBranch.Enabled = false;
						cboParentAccount.Enabled = false;
						chkIsParent.Enabled = false;
						txtBalance.Enabled = false;
						dtpBalance.Enabled = false;
						chkCashIncome.Enabled = false;
						chkCashExpense.Enabled = false;
						chkBankIncome.Enabled = false;
						chkBankExpense.Enabled = false;
						cboActive.Enabled = false;
					}
					goto end_IL_0001;
				}
				case 653:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSettingAccountInput", "loadData", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 653;
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

	private void chkIsParent_CheckedChanged(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboAccountType.SelectedItem;
		if (!chkIsParent.Checked)
		{
			txtBalance.Enabled = true;
			dtpBalance.Enabled = true;
			chkCashIncome.Enabled = true;
			chkCashExpense.Enabled = true;
			chkBankIncome.Enabled = true;
			chkBankExpense.Enabled = true;
			if (Conversions.ToDouble(cComboItem2.Value) == 1.0)
			{
				cboBranch.Enabled = true;
			}
			else
			{
				cboBranch.Enabled = false;
			}
		}
		else
		{
			txtBalance.Text = "0";
			chkCashIncome.Checked = false;
			chkCashExpense.Checked = false;
			chkBankIncome.Checked = false;
			chkBankExpense.Checked = false;
			cboBranch.SelectedIndex = -1;
			txtBalance.Enabled = false;
			dtpBalance.Enabled = false;
			chkCashIncome.Enabled = false;
			chkCashExpense.Enabled = false;
			chkBankIncome.Enabled = false;
			chkBankExpense.Enabled = false;
			cboBranch.Enabled = false;
		}
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboAccountType.SelectedItem;
		cComboItem cComboItem3 = (cComboItem)cboCurrency.SelectedItem;
		cComboItem cComboItem4 = (cComboItem)cboParentAccount.SelectedItem;
		cComboItem cComboItem5 = (cComboItem)cboBranch.SelectedItem;
		cComboItem cComboItem6 = (cComboItem)cboActive.SelectedItem;
		if (Operators.CompareString(txtName.Text, "", TextCompare: false) == 0)
		{
			Interaction.MsgBox("Masukkan nama akun", MsgBoxStyle.Information);
			txtName.Focus();
			return;
		}
		if (Operators.CompareString(txtNumber.Text, "", TextCompare: false) == 0)
		{
			Interaction.MsgBox("Masukkan nomer akun", MsgBoxStyle.Information);
			txtNumber.Focus();
			return;
		}
		if (cboAccountType.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih tipe akun", MsgBoxStyle.Information);
			cboAccountType.Focus();
			return;
		}
		if (cboCurrency.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih mata uang", MsgBoxStyle.Information);
			cboCurrency.Focus();
			return;
		}
		if (cboParentAccount.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih grup akun", MsgBoxStyle.Information);
			cboParentAccount.Focus();
			return;
		}
		if ((Conversions.ToDouble(cComboItem2.Value) == 1.0) & !chkIsParent.Checked & (cboBranch.SelectedIndex == -1))
		{
			Interaction.MsgBox("Pilih cabang akun", MsgBoxStyle.Information);
			cboBranch.Focus();
			return;
		}
		if (!Versioned.IsNumeric(txtBalance.Text))
		{
			Interaction.MsgBox("Masukkan jumlah saldo awal dengan format angka yang benar", MsgBoxStyle.Information);
			txtBalance.Focus();
			return;
		}
		if (cboActive.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih aktif/tidak", MsgBoxStyle.Information);
			cboActive.Focus();
			return;
		}
		cAccount cAccount2 = new cAccount(0);
		cAccount2.Id = Conversions.ToInteger(CurrentId);
		cAccount2.Name = txtName.Text;
		cAccount2.Number = txtNumber.Text;
		cAccount2.TypeId = Conversions.ToInteger(cComboItem2.Value);
		cAccount2.CurrencyId = Conversions.ToInteger(cComboItem3.Value);
		if (Conversions.ToDouble(cComboItem4.Value) == 0.0)
		{
			cAccount2.ParentId = _currentId;
		}
		else
		{
			cAccount2.ParentId = Conversions.ToInteger(cComboItem4.Value);
		}
		cAccount2.IsParent = Conversions.ToInteger(Interaction.IIf(chkIsParent.Checked, 1, 0));
		cAccount2.BalanceAmount = Conversions.ToDouble(txtBalance.Text);
		cAccount2.BalanceDate = dtpBalance.Value;
		if ((Conversions.ToDouble(cComboItem2.Value) == 1.0) & !chkIsParent.Checked)
		{
			cAccount2.BranchId = Conversions.ToInteger(cComboItem5.Value);
		}
		else
		{
			cAccount2.BranchId = 0;
		}
		cAccount2.CashIncome = Conversions.ToInteger(Interaction.IIf(chkCashIncome.Checked, 1, 0));
		cAccount2.CashExpense = Conversions.ToInteger(Interaction.IIf(chkCashExpense.Checked, 1, 0));
		cAccount2.BankIncome = Conversions.ToInteger(Interaction.IIf(chkBankIncome.Checked, 1, 0));
		cAccount2.BankExpense = Conversions.ToInteger(Interaction.IIf(chkBankExpense.Checked, 1, 0));
		cAccount2.Active = Conversions.ToInteger(cComboItem6.Value);
		cAccount2.Save();
		Interaction.MsgBox("Akun berhasil disimpan", MsgBoxStyle.Information);
		if (!MyProject.Forms.frmSettingAccountList.chkManual.Checked)
		{
			MyProject.Forms.frmSettingAccountList.getAccount();
		}
		Close();
	}

	private void cboAccountType_SelectedIndexChanged(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboAccountType.SelectedItem;
		if ((Conversions.ToDouble(cComboItem2.Value) == 1.0) & !chkIsParent.Checked)
		{
			cboBranch.Enabled = true;
		}
		else
		{
			cboBranch.Enabled = false;
		}
		cboCurrency.SelectedIndex = 0;
		if ((Conversions.ToDouble(cComboItem2.Value) == 1.0) | (Conversions.ToDouble(cComboItem2.Value) == 2.0) | (Conversions.ToDouble(cComboItem2.Value) == 4.0) | (Conversions.ToDouble(cComboItem2.Value) == 7.0) | (Conversions.ToDouble(cComboItem2.Value) == 8.0) | (Conversions.ToDouble(cComboItem2.Value) == 9.0) | (Conversions.ToDouble(cComboItem2.Value) == 10.0))
		{
			cboCurrency.Enabled = true;
		}
		else
		{
			cboCurrency.Enabled = false;
		}
	}
}
