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
public class frmBankTransaction : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnHistory")]
	private Button _btnHistory;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSaveClose")]
	private Button _btnSaveClose;

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
	[AccessedThroughProperty("cboBankAccount")]
	private ComboBox _cboBankAccount;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dtpVoucher")]
	private DateTimePicker _dtpVoucher;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboIncomeExpense")]
	private ComboBox _cboIncomeExpense;

	private double _currentId;

	internal virtual Button btnHistory
	{
		[CompilerGenerated]
		get
		{
			return _btnHistory;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnHistory_Click;
			Button button = _btnHistory;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnHistory = value;
			button = _btnHistory;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button btnSaveClose
	{
		[CompilerGenerated]
		get
		{
			return _btnSaveClose;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnSaveClose_Click;
			Button button = _btnSaveClose;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnSaveClose = value;
			button = _btnSaveClose;
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

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
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

	[field: AccessedThroughProperty("txtDescription")]
	internal virtual TextBox txtDescription
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

	[field: AccessedThroughProperty("cboAccount")]
	internal virtual ComboBox cboAccount
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtQty")]
	internal virtual FilteredTextBox txtQty
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox cboBankAccount
	{
		[CompilerGenerated]
		get
		{
			return _cboBankAccount;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cboBankAccount_SelectedIndexChanged;
			ComboBox comboBox = _cboBankAccount;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_cboBankAccount = value;
			comboBox = _cboBankAccount;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	internal virtual DateTimePicker dtpVoucher
	{
		[CompilerGenerated]
		get
		{
			return _dtpVoucher;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = dtpVoucher_ValueChanged;
			DateTimePicker dateTimePicker = _dtpVoucher;
			if (dateTimePicker != null)
			{
				dateTimePicker.ValueChanged -= value2;
			}
			_dtpVoucher = value;
			dateTimePicker = _dtpVoucher;
			if (dateTimePicker != null)
			{
				dateTimePicker.ValueChanged += value2;
			}
		}
	}

	internal virtual ComboBox cboIncomeExpense
	{
		[CompilerGenerated]
		get
		{
			return _cboIncomeExpense;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cboIncomeExpense_SelectedIndexChanged;
			ComboBox comboBox = _cboIncomeExpense;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_cboIncomeExpense = value;
			comboBox = _cboIncomeExpense;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("txtAmount")]
	internal virtual FilteredTextBox txtAmount
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblInformation")]
	internal virtual Label lblInformation
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

	[field: AccessedThroughProperty("lblCurrencyRate")]
	internal virtual Label lblCurrencyRate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public double CurrentId
	{
		get
		{
			return _currentId;
		}
		set
		{
			_currentId = value;
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
		this.btnHistory = new System.Windows.Forms.Button();
		this.btnSaveClose = new System.Windows.Forms.Button();
		this.btnDelete = new System.Windows.Forms.Button();
		this.btnSave = new System.Windows.Forms.Button();
		this.Label11 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.txtDescription = new System.Windows.Forms.TextBox();
		this.Label7 = new System.Windows.Forms.Label();
		this.cboAccount = new System.Windows.Forms.ComboBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.cboBankAccount = new System.Windows.Forms.ComboBox();
		this.dtpVoucher = new System.Windows.Forms.DateTimePicker();
		this.cboIncomeExpense = new System.Windows.Forms.ComboBox();
		this.txtAmount = new GCUv2.FilteredTextBox();
		this.lblInformation = new System.Windows.Forms.Label();
		this.txtCurrencyRate = new GCUv2.FilteredTextBox();
		this.lblCurrencyRate = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnHistory.Location = new System.Drawing.Point(256, 283);
		this.btnHistory.Name = "btnHistory";
		this.btnHistory.Size = new System.Drawing.Size(50, 24);
		this.btnHistory.TabIndex = 14;
		this.btnHistory.Text = "&History";
		this.btnHistory.UseVisualStyleBackColor = true;
		this.btnSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSaveClose.Location = new System.Drawing.Point(102, 283);
		this.btnSaveClose.Name = "btnSaveClose";
		this.btnSaveClose.Size = new System.Drawing.Size(93, 24);
		this.btnSaveClose.TabIndex = 12;
		this.btnSaveClose.Text = "Simpan && &Tutup";
		this.btnSaveClose.UseVisualStyleBackColor = true;
		this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDelete.Location = new System.Drawing.Point(201, 283);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new System.Drawing.Size(49, 24);
		this.btnDelete.TabIndex = 13;
		this.btnDelete.Text = "Hapus";
		this.btnDelete.UseVisualStyleBackColor = true;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(10, 283);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(86, 24);
		this.btnSave.TabIndex = 11;
		this.btnSave.Text = "&Simpan && Baru";
		this.btnSave.UseVisualStyleBackColor = true;
		this.Label11.BackColor = System.Drawing.Color.Silver;
		this.Label11.Location = new System.Drawing.Point(-321, 275);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(713, 59);
		this.Label11.TabIndex = 167;
		this.Label8.AutoSize = true;
		this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label8.Location = new System.Drawing.Point(10, 184);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(62, 13);
		this.Label8.TabIndex = 166;
		this.Label8.Text = "Keterangan";
		this.txtDescription.AcceptsReturn = true;
		this.txtDescription.Location = new System.Drawing.Point(99, 178);
		this.txtDescription.MaxLength = 100;
		this.txtDescription.Multiline = true;
		this.txtDescription.Name = "txtDescription";
		this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
		this.txtDescription.Size = new System.Drawing.Size(165, 52);
		this.txtDescription.TabIndex = 6;
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.Location = new System.Drawing.Point(10, 95);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(32, 13);
		this.Label7.TabIndex = 165;
		this.Label7.Text = "Akun";
		this.cboAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboAccount.FormattingEnabled = true;
		this.cboAccount.Location = new System.Drawing.Point(100, 92);
		this.cboAccount.Name = "cboAccount";
		this.cboAccount.Size = new System.Drawing.Size(164, 21);
		this.cboAccount.TabIndex = 3;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(10, 127);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(40, 13);
		this.Label5.TabIndex = 163;
		this.Label5.Text = "Jumlah";
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(10, 42);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(53, 13);
		this.Label3.TabIndex = 162;
		this.Label3.Text = "Rekening";
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(9, 68);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(31, 13);
		this.Label2.TabIndex = 161;
		this.Label2.Text = "Jenis";
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(10, 15);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(46, 13);
		this.Label1.TabIndex = 160;
		this.Label1.Text = "Tanggal";
		this.cboBankAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboBankAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboBankAccount.FormattingEnabled = true;
		this.cboBankAccount.Location = new System.Drawing.Point(100, 38);
		this.cboBankAccount.Name = "cboBankAccount";
		this.cboBankAccount.Size = new System.Drawing.Size(164, 21);
		this.cboBankAccount.TabIndex = 1;
		this.dtpVoucher.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpVoucher.Location = new System.Drawing.Point(101, 12);
		this.dtpVoucher.Name = "dtpVoucher";
		this.dtpVoucher.Size = new System.Drawing.Size(163, 20);
		this.dtpVoucher.TabIndex = 0;
		this.cboIncomeExpense.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboIncomeExpense.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboIncomeExpense.FormattingEnabled = true;
		this.cboIncomeExpense.Location = new System.Drawing.Point(100, 65);
		this.cboIncomeExpense.Name = "cboIncomeExpense";
		this.cboIncomeExpense.Size = new System.Drawing.Size(164, 21);
		this.cboIncomeExpense.TabIndex = 2;
		this.txtAmount.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtAmount.DontFormat = false;
		this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtAmount.Location = new System.Drawing.Point(100, 119);
		this.txtAmount.MaximumDigit = 3;
		this.txtAmount.Name = "txtAmount";
		this.txtAmount.Size = new System.Drawing.Size(164, 26);
		this.txtAmount.TabIndex = 4;
		this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.lblInformation.ForeColor = System.Drawing.Color.Red;
		this.lblInformation.Location = new System.Drawing.Point(12, 238);
		this.lblInformation.Name = "lblInformation";
		this.lblInformation.Size = new System.Drawing.Size(262, 28);
		this.lblInformation.TabIndex = 168;
		this.lblInformation.Text = "lblInformation";
		this.txtCurrencyRate.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtCurrencyRate.DontFormat = false;
		this.txtCurrencyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtCurrencyRate.Location = new System.Drawing.Point(100, 151);
		this.txtCurrencyRate.MaximumDigit = 3;
		this.txtCurrencyRate.Name = "txtCurrencyRate";
		this.txtCurrencyRate.Size = new System.Drawing.Size(164, 21);
		this.txtCurrencyRate.TabIndex = 5;
		this.txtCurrencyRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.lblCurrencyRate.AutoSize = true;
		this.lblCurrencyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblCurrencyRate.Location = new System.Drawing.Point(9, 156);
		this.lblCurrencyRate.Name = "lblCurrencyRate";
		this.lblCurrencyRate.Size = new System.Drawing.Size(28, 13);
		this.lblCurrencyRate.TabIndex = 179;
		this.lblCurrencyRate.Text = "Kurs";
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(316, 317);
		base.Controls.Add(this.txtCurrencyRate);
		base.Controls.Add(this.lblCurrencyRate);
		base.Controls.Add(this.lblInformation);
		base.Controls.Add(this.txtAmount);
		base.Controls.Add(this.btnHistory);
		base.Controls.Add(this.btnSaveClose);
		base.Controls.Add(this.btnDelete);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.Label11);
		base.Controls.Add(this.Label8);
		base.Controls.Add(this.txtDescription);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.cboAccount);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.cboBankAccount);
		base.Controls.Add(this.dtpVoucher);
		base.Controls.Add(this.cboIncomeExpense);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmBankTransaction";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Transaksi Bank ";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmBankTransaction()
	{
		base.KeyDown += frmBankTransaction_KeyDown;
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
					DoubleBuffered = true;
					base.MdiParent = MyProject.Forms.frmMenu;
					txtAmount.AllowedCharacters = FilteredTextBox.InputType.NumeralsAndCurrency;
					ComboBox combo = cboBankAccount;
					cCombo.getBankAccount(ref combo, 0, Module1.pubGroupId, All: false, GroupDefault: false, Active: true, "TRANSACTION", 0);
					cboBankAccount = combo;
					combo = cboIncomeExpense;
					cCombo.getIncomeExpense(ref combo, All: false);
					cboIncomeExpense = combo;
					goto end_IL_001b;
				}
				case 174:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmBankTransaction", "New", "");
						goto end_IL_001b;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try001b_dispatch = 174;
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

	private void cboBankAccount_SelectedIndexChanged(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboBankAccount.SelectedItem;
		cComboItem cComboItem3 = (cComboItem)cboIncomeExpense.SelectedItem;
		if (!Information.IsNothing(cComboItem2))
		{
			cAccount cAccount2 = new cAccount(Conversions.ToInteger(cComboItem2.Value));
			lblCurrencyRate.Text = "Kurs (" + cAccount2.CurrencyName + ")";
			txtCurrencyRate.Text = Module1.formatCustomDecimal(Conversions.ToString(cAccount2.CurrencyRate), 2);
			if (cAccount2.CurrencyId == 1)
			{
				txtCurrencyRate.Enabled = false;
			}
			else
			{
				txtCurrencyRate.Enabled = true;
			}
			if (!Information.IsNothing(cComboItem3))
			{
				ComboBox combo = cboAccount;
				cCombo.getAccountForTransaction(ref combo, All: false, 0, Conversions.ToInteger(cComboItem2.Value), 0, Conversions.ToInteger(cComboItem3.Value), cAccount2.CurrencyId, Module1.pubGroupId, 1);
				cboAccount = combo;
				cboAccount.Text = "";
				cboAccount.SelectedIndex = -1;
			}
		}
	}

	private void cboIncomeExpense_SelectedIndexChanged(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboBankAccount.SelectedItem;
		cComboItem cComboItem3 = (cComboItem)cboIncomeExpense.SelectedItem;
		if (!Information.IsNothing(cComboItem2) & !Information.IsNothing(cComboItem3))
		{
			cAccount cAccount2 = new cAccount(Conversions.ToInteger(cComboItem2.Value));
			ComboBox combo = cboAccount;
			cCombo.getAccountForTransaction(ref combo, All: false, 0, Conversions.ToInteger(cComboItem2.Value), 0, Conversions.ToInteger(cComboItem3.Value), cAccount2.CurrencyId, Module1.pubGroupId, 1);
			cboAccount = combo;
			cboAccount.Text = "";
			cboAccount.SelectedIndex = -1;
		}
	}

	private void frmBankTransaction_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	public void prepareForm(bool SaveNew)
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
					ProjectData.ClearProjectError();
					num2 = 2;
					_currentId = 0.0;
					if (!SaveNew)
					{
						dtpVoucher.Value = DateAndTime.Now;
						cboBankAccount.SelectedIndex = -1;
						txtCurrencyRate.Text = "";
					}
					cboIncomeExpense.SelectedIndex = -1;
					cboAccount.SelectedIndex = -1;
					txtAmount.Text = "";
					txtDescription.Text = "";
					btnHistory.Enabled = false;
					btnDelete.Enabled = false;
					goto end_IL_0001;
				case 199:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmBankTransaction", "prepareForm", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 199;
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

	public void LoadData()
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
					cVoucher cVoucher2 = new cVoucher(_currentId);
					dtpVoucher.Value = cVoucher2.VoucherDate;
					if (DateAndTime.DateDiff(DateInterval.Day, cVoucher2.VoucherDate, DateAndTime.Now) > Module1.pubDaysLimitForBankTransaction)
					{
						btnSave.Enabled = false;
						btnSaveClose.Enabled = false;
						btnDelete.Enabled = false;
						dtpVoucher.Enabled = false;
						lblInformation.Text = "Anda tidak bisa menyimpan/menghapus transaksi sebelum " + Strings.FormatDateTime(DateAndTime.Now.AddDays(checked(Module1.pubDaysLimitForBankTransaction * -1)), DateFormat.ShortDate);
					}
					else
					{
						btnDelete.Enabled = true;
					}
					txtDescription.Text = cVoucher2.VoucherDescription;
					cVoucherAccount[] account = cVoucher2.Account;
					foreach (cVoucherAccount cVoucherAccount2 in account)
					{
						if (cVoucherAccount2.VoucherMain == 1)
						{
							ComboBox cboSource = cboBankAccount;
							Module1.comboBoundValue(ref cboSource, cVoucherAccount2.AccountId);
							cboBankAccount = cboSource;
							cboSource = cboIncomeExpense;
							Module1.comboBoundValue(ref cboSource, cVoucherAccount2.VoucherDebitCredit);
							cboIncomeExpense = cboSource;
							txtAmount.Text = Module1.formatCustomDecimal(Conversions.ToString(cVoucherAccount2.VoucherAmount), 2);
							txtCurrencyRate.Text = Module1.formatCustomDecimal(Conversions.ToString(cVoucherAccount2.CurrencyRate), 2);
						}
						else
						{
							ComboBox cboSource = cboAccount;
							Module1.comboBoundValue(ref cboSource, cVoucherAccount2.AccountId);
							cboAccount = cboSource;
						}
					}
					btnHistory.Enabled = true;
					goto end_IL_0001;
				}
				case 515:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmBankTransaction", "loadData", "");
						if (Information.Err().Number == 513)
						{
							Close();
						}
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 515;
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

	private void dtpVoucher_ValueChanged(object sender, EventArgs e)
	{
		if (DateAndTime.DateDiff(DateInterval.Day, dtpVoucher.Value, DateAndTime.Now) > Module1.pubDaysLimitForBankTransaction)
		{
			btnSave.Enabled = false;
			btnSaveClose.Enabled = false;
			btnDelete.Enabled = false;
			lblInformation.Text = "Anda tidak bisa menyimpan/menghapus transaksi sebelum " + Strings.FormatDateTime(DateAndTime.Now.AddDays(checked(Module1.pubDaysLimitForBankTransaction * -1)), DateFormat.ShortDate);
			return;
		}
		btnSave.Enabled = true;
		btnSaveClose.Enabled = true;
		lblInformation.Text = "";
		if (_currentId > 0.0)
		{
			btnDelete.Enabled = true;
		}
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		SaveData(CloseForm: false);
	}

	private void btnSaveClose_Click(object sender, EventArgs e)
	{
		SaveData(CloseForm: true);
	}

	private void SaveData(bool CloseForm)
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
					cComboItem cComboItem2 = (cComboItem)cboBankAccount.SelectedItem;
					cComboItem cComboItem3 = (cComboItem)cboAccount.SelectedItem;
					cComboItem cComboItem4 = (cComboItem)cboIncomeExpense.SelectedItem;
					if (!cValidation.isDateWithinRange(dtpVoucher.Value, Module1.pubGroupId, Module1.pubDaysLimitForBankTransaction))
					{
						Interaction.MsgBox("Tanggal diluar batas yang diperbolehkan", MsgBoxStyle.Information);
						dtpVoucher.Focus();
						goto end_IL_0001;
					}
					if (cboBankAccount.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih Rekening", MsgBoxStyle.Information);
						cboBankAccount.Focus();
						goto end_IL_0001;
					}
					if (cboIncomeExpense.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih Pendapatan/Pengeluaran", MsgBoxStyle.Information);
						cboIncomeExpense.Focus();
						goto end_IL_0001;
					}
					if (cboAccount.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih akun", MsgBoxStyle.Information);
						cboAccount.Focus();
						goto end_IL_0001;
					}
					if (Conversion.Val(Module1.unformatNumber(txtAmount.Text)) == 0.0)
					{
						Interaction.MsgBox("Masukkan jumlah", MsgBoxStyle.Information);
						txtAmount.Focus();
						goto end_IL_0001;
					}
					if (!Versioned.IsNumeric(txtAmount.Text))
					{
						Interaction.MsgBox("Masukkan jumlah dengan format angka yang benar", MsgBoxStyle.Information);
						txtAmount.Focus();
						goto end_IL_0001;
					}
					if (Conversion.Val(txtCurrencyRate.Text) == 0.0)
					{
						Interaction.MsgBox("Masukkan nilai kurs", MsgBoxStyle.Information);
						txtCurrencyRate.Focus();
						goto end_IL_0001;
					}
					if (!Versioned.IsNumeric(txtCurrencyRate.Text))
					{
						Interaction.MsgBox("Masukkan nilai kurs format angka yang benar", MsgBoxStyle.Information);
						txtCurrencyRate.Focus();
						goto end_IL_0001;
					}
					if (Strings.Len(txtDescription.Text) > 100)
					{
						Interaction.MsgBox("Deskripsi tidak boleh melebihi 100 karakter", MsgBoxStyle.Information);
						txtDescription.Focus();
						goto end_IL_0001;
					}
					cVoucher cVoucher2 = new cVoucher(0.0);
					cVoucherAccount[] array = new cVoucherAccount[2];
					int num3 = 0;
					cVoucher2.VoucherId = _currentId;
					cVoucher2.VoucherType = 3;
					cVoucher2.VoucherDate = dtpVoucher.Value;
					cVoucher2.VoucherDescription = txtDescription.Text;
					cVoucher2.VoucherNote = cboAccount.Text;
					array[0] = new cVoucherAccount();
					array[0].VoucherAmount = Conversions.ToDouble(txtAmount.Text);
					array[0].AccountId = Conversions.ToInteger(cComboItem2.Value);
					array[0].VoucherDebitCredit = Conversions.ToInteger(cComboItem4.Value);
					array[0].VoucherMain = 1;
					array[0].CounterAccountId = Conversions.ToInteger(cComboItem3.Value);
					array[0].CurrencyRate = Conversions.ToDouble(txtCurrencyRate.Text);
					array[1] = new cVoucherAccount();
					array[1].VoucherAmount = Conversions.ToDouble(txtAmount.Text);
					array[1].AccountId = Conversions.ToInteger(cComboItem3.Value);
					array[1].VoucherDebitCredit = Conversions.ToInteger(Interaction.IIf(Conversions.ToDouble(cComboItem4.Value) == 1.0, 2, 1));
					array[1].VoucherMain = 0;
					array[1].CounterAccountId = Conversions.ToInteger(cComboItem2.Value);
					array[1].CurrencyRate = Conversions.ToDouble(txtCurrencyRate.Text);
					cVoucher2.Account = array;
					cVoucher2.save();
					string content = "Tanggal: " + Conversions.ToString(dtpVoucher.Value) + "<br />Kas: " + cboBankAccount.Text + "<br />Tipe: " + cboIncomeExpense.Text + "<br />Akun: " + cboAccount.Text + "<br />Jumlah: " + txtAmount.Text + "<br />Keterangan: " + txtDescription.Text + "<br /><br />";
					string text;
					if (_currentId == 0.0)
					{
						text = "membuat ";
						_currentId = cVoucher2.VoucherId;
					}
					else
					{
						text = "mengupdate ";
					}
					text = text + "Transaksi Bank: " + cboIncomeExpense.Text + " " + cboBankAccount.Text + ". Akun " + cboAccount.Text + ". Tanggal " + Strings.Format(dtpVoucher.Value, "dd/MM/yyyy") + ". ID= " + Conversions.ToString(_currentId) + ", v2";
					cHistory cHistory2 = new cHistory();
					cHistory2.Content = content;
					cHistory2.Description = text;
					cHistory2.UserId = Module1.pubUserId;
					cHistory2.UserLogin = Module1.pubLogin;
					cHistory2.fKeyId = _currentId;
					cHistory2.HistoryType = 13;
					cHistory2.Save();
					Interaction.MsgBox("Transaksi Bank berhasil disimpan", MsgBoxStyle.Information);
					if (Module1.FormIsOpen("frmBankTransactionList"))
					{
						MyProject.Forms.frmBankTransactionList.GetRecent();
					}
					MyProject.Forms.frmInformation.GetActivity();
					if (CloseForm)
					{
						Close();
						goto end_IL_0001;
					}
					prepareForm(SaveNew: true);
					cboIncomeExpense.Focus();
					goto end_IL_0001;
				}
				case 1606:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmBankTransaction", "SaveData", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1606;
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

	private void btnDelete_Click(object sender, EventArgs e)
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
					if (MessageBox.Show("Hapus Transaksi Bank?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.No)
					{
						goto end_IL_0001;
					}
					cVoucher cVoucher2 = new cVoucher(_currentId);
					cVoucher2.Delete();
					string text = "";
					string text2 = "";
					string text3 = "";
					cVoucherAccount[] account = cVoucher2.Account;
					foreach (cVoucherAccount cVoucherAccount2 in account)
					{
						if (cVoucherAccount2.VoucherMain == 1)
						{
							text2 = cVoucherAccount2.AccountName;
							text = Conversions.ToString(Interaction.IIf(cVoucherAccount2.VoucherDebitCredit == 1, "Pendapatan", "Pengeluaran"));
						}
					}
					string description = "menghapus Transaksi Bank: " + text + " " + text2 + ". Akun " + cVoucher2.VoucherNote + ". Tanggal  " + Strings.Format(cVoucher2.VoucherDate, "dd/MM/yyyy") + ". ID= " + Conversions.ToString(_currentId) + ", v2";
					cHistory cHistory2 = new cHistory();
					cHistory2.Description = description;
					cHistory2.UserId = Module1.pubUserId;
					cHistory2.UserLogin = Module1.pubLogin;
					cHistory2.fKeyId = _currentId;
					cHistory2.HistoryType = 13;
					cHistory2.Save();
					Interaction.MsgBox("Transaksi Bank berhasil dihapus", MsgBoxStyle.Information);
					if (Module1.FormIsOpen("frmBankTransactionList"))
					{
						MyProject.Forms.frmBankTransactionList.GetRecent();
					}
					MyProject.Forms.frmInformation.GetActivity();
					Close();
					goto end_IL_0001;
				}
				case 479:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmBankTransaction", "btnDelete_Click", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 479;
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

	private void btnHistory_Click(object sender, EventArgs e)
	{
		MyProject.Forms.frmHistory.GetHistory(checked((int)Math.Round(_currentId)), 13);
		MyProject.Forms.frmHistory.Show();
		MyProject.Forms.frmHistory.Activate();
		MyProject.Forms.frmHistory.WindowState = FormWindowState.Normal;
	}
}
