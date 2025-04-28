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
public class frmSettingCurrencyInput : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSaveClose")]
	private Button _btnSaveClose;

	private int _currentId;

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

	[field: AccessedThroughProperty("txtSymbol")]
	internal virtual TextBox txtSymbol
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtRate")]
	internal virtual FilteredTextBox txtRate
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

	[field: AccessedThroughProperty("cboAccountPayable")]
	internal virtual ComboBox cboAccountPayable
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboAccountReceivable")]
	internal virtual ComboBox cboAccountReceivable
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

	[field: AccessedThroughProperty("cboAdvancePurchase")]
	internal virtual ComboBox cboAdvancePurchase
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

	[field: AccessedThroughProperty("cboAdvanceSales")]
	internal virtual ComboBox cboAdvanceSales
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

	[field: AccessedThroughProperty("cboRealizeGainLoss")]
	internal virtual ComboBox cboRealizeGainLoss
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

	[field: AccessedThroughProperty("cboUnrealizeGainLoss")]
	internal virtual ComboBox cboUnrealizeGainLoss
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

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
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
		this.btnSaveClose = new System.Windows.Forms.Button();
		this.Label9 = new System.Windows.Forms.Label();
		this.cboActive = new System.Windows.Forms.ComboBox();
		this.txtName = new System.Windows.Forms.TextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.txtSymbol = new System.Windows.Forms.TextBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.txtRate = new GCUv2.FilteredTextBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.cboAccountPayable = new System.Windows.Forms.ComboBox();
		this.cboAccountReceivable = new System.Windows.Forms.ComboBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.cboAdvancePurchase = new System.Windows.Forms.ComboBox();
		this.Label6 = new System.Windows.Forms.Label();
		this.cboAdvanceSales = new System.Windows.Forms.ComboBox();
		this.Label7 = new System.Windows.Forms.Label();
		this.cboRealizeGainLoss = new System.Windows.Forms.ComboBox();
		this.Label8 = new System.Windows.Forms.Label();
		this.cboUnrealizeGainLoss = new System.Windows.Forms.ComboBox();
		this.Label10 = new System.Windows.Forms.Label();
		this.Label11 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.btnSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSaveClose.Location = new System.Drawing.Point(141, 308);
		this.btnSaveClose.Name = "btnSaveClose";
		this.btnSaveClose.Size = new System.Drawing.Size(93, 24);
		this.btnSaveClose.TabIndex = 10;
		this.btnSaveClose.Text = "Simpan && &Tutup";
		this.btnSaveClose.UseVisualStyleBackColor = true;
		this.Label9.AutoSize = true;
		this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label9.Location = new System.Drawing.Point(10, 94);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(28, 13);
		this.Label9.TabIndex = 147;
		this.Label9.Text = "Aktif";
		this.cboActive.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboActive.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboActive.FormattingEnabled = true;
		this.cboActive.Location = new System.Drawing.Point(141, 91);
		this.cboActive.Name = "cboActive";
		this.cboActive.Size = new System.Drawing.Size(125, 21);
		this.cboActive.TabIndex = 3;
		this.txtName.Location = new System.Drawing.Point(141, 12);
		this.txtName.Name = "txtName";
		this.txtName.Size = new System.Drawing.Size(125, 20);
		this.txtName.TabIndex = 0;
		this.Label1.Location = new System.Drawing.Point(10, 15);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(35, 13);
		this.Label1.TabIndex = 145;
		this.Label1.Text = "Nama";
		this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.txtSymbol.Location = new System.Drawing.Point(141, 38);
		this.txtSymbol.Name = "txtSymbol";
		this.txtSymbol.Size = new System.Drawing.Size(125, 20);
		this.txtSymbol.TabIndex = 1;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(10, 41);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(38, 13);
		this.Label2.TabIndex = 149;
		this.Label2.Text = "Simbol";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(10, 67);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(58, 13);
		this.Label3.TabIndex = 151;
		this.Label3.Text = "Nilai Tukar";
		this.txtRate.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtRate.Location = new System.Drawing.Point(140, 64);
		this.txtRate.MaximumDigit = 3;
		this.txtRate.Name = "txtRate";
		this.txtRate.Size = new System.Drawing.Size(126, 21);
		this.txtRate.TabIndex = 2;
		this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(10, 145);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(70, 13);
		this.Label4.TabIndex = 152;
		this.Label4.Text = "Akun Hutang";
		this.cboAccountPayable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboAccountPayable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboAccountPayable.Enabled = false;
		this.cboAccountPayable.FormattingEnabled = true;
		this.cboAccountPayable.Location = new System.Drawing.Point(141, 142);
		this.cboAccountPayable.Name = "cboAccountPayable";
		this.cboAccountPayable.Size = new System.Drawing.Size(233, 21);
		this.cboAccountPayable.TabIndex = 153;
		this.cboAccountReceivable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboAccountReceivable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboAccountReceivable.Enabled = false;
		this.cboAccountReceivable.FormattingEnabled = true;
		this.cboAccountReceivable.Location = new System.Drawing.Point(141, 169);
		this.cboAccountReceivable.Name = "cboAccountReceivable";
		this.cboAccountReceivable.Size = new System.Drawing.Size(233, 21);
		this.cboAccountReceivable.TabIndex = 155;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(10, 172);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(71, 13);
		this.Label5.TabIndex = 154;
		this.Label5.Text = "Akun Piutang";
		this.cboAdvancePurchase.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboAdvancePurchase.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboAdvancePurchase.Enabled = false;
		this.cboAdvancePurchase.FormattingEnabled = true;
		this.cboAdvancePurchase.Location = new System.Drawing.Point(141, 196);
		this.cboAdvancePurchase.Name = "cboAdvancePurchase";
		this.cboAdvancePurchase.Size = new System.Drawing.Size(233, 21);
		this.cboAdvancePurchase.TabIndex = 157;
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.Location = new System.Drawing.Point(10, 199);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(115, 13);
		this.Label6.TabIndex = 156;
		this.Label6.Text = "Uang Muka Pembelian";
		this.cboAdvanceSales.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboAdvanceSales.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboAdvanceSales.Enabled = false;
		this.cboAdvanceSales.FormattingEnabled = true;
		this.cboAdvanceSales.Location = new System.Drawing.Point(141, 223);
		this.cboAdvanceSales.Name = "cboAdvanceSales";
		this.cboAdvanceSales.Size = new System.Drawing.Size(233, 21);
		this.cboAdvanceSales.TabIndex = 159;
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.Location = new System.Drawing.Point(10, 226);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(113, 13);
		this.Label7.TabIndex = 158;
		this.Label7.Text = "Uang Muka Penjualan";
		this.cboRealizeGainLoss.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboRealizeGainLoss.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboRealizeGainLoss.Enabled = false;
		this.cboRealizeGainLoss.FormattingEnabled = true;
		this.cboRealizeGainLoss.Location = new System.Drawing.Point(141, 250);
		this.cboRealizeGainLoss.Name = "cboRealizeGainLoss";
		this.cboRealizeGainLoss.Size = new System.Drawing.Size(233, 21);
		this.cboRealizeGainLoss.TabIndex = 161;
		this.Label8.AutoSize = true;
		this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label8.Location = new System.Drawing.Point(10, 253);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(103, 13);
		this.Label8.TabIndex = 160;
		this.Label8.Text = "Laba/Rugi Terealisir";
		this.cboUnrealizeGainLoss.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboUnrealizeGainLoss.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboUnrealizeGainLoss.Enabled = false;
		this.cboUnrealizeGainLoss.FormattingEnabled = true;
		this.cboUnrealizeGainLoss.Location = new System.Drawing.Point(141, 277);
		this.cboUnrealizeGainLoss.Name = "cboUnrealizeGainLoss";
		this.cboUnrealizeGainLoss.Size = new System.Drawing.Size(233, 21);
		this.cboUnrealizeGainLoss.TabIndex = 163;
		this.Label10.AutoSize = true;
		this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label10.Location = new System.Drawing.Point(10, 280);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(125, 13);
		this.Label10.TabIndex = 162;
		this.Label10.Text = "Laba/Rugi Tak Terealisir";
		this.Label11.AutoSize = true;
		this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label11.Location = new System.Drawing.Point(10, 121);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(85, 13);
		this.Label11.TabIndex = 164;
		this.Label11.Text = "Akun Default:";
		base.AcceptButton = this.btnSaveClose;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(386, 339);
		base.Controls.Add(this.Label11);
		base.Controls.Add(this.cboUnrealizeGainLoss);
		base.Controls.Add(this.Label10);
		base.Controls.Add(this.cboRealizeGainLoss);
		base.Controls.Add(this.Label8);
		base.Controls.Add(this.cboAdvanceSales);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.cboAdvancePurchase);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.cboAccountReceivable);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.cboAccountPayable);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.txtRate);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.txtSymbol);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.btnSaveClose);
		base.Controls.Add(this.Label9);
		base.Controls.Add(this.cboActive);
		base.Controls.Add(this.txtName);
		base.Controls.Add(this.Label1);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSettingCurrencyInput";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Setting - Mata Uang";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmSettingCurrencyInput()
	{
		base.KeyDown += frmSettingCurrencyInput_KeyDown;
		InitializeComponent();
		txtRate.AllowedCharacters = FilteredTextBox.InputType.NumeralsAndCurrency;
		txtRate.MaximumDigit = 2;
		ComboBox combo = cboActive;
		cCombo.getYesNo(ref combo, All: false);
		cboActive = combo;
		combo = cboAccountPayable;
		cCombo.getAccount(ref combo, All: false, 0, 8, 0, 0, 99, 99, 99, 0, 99);
		cboAccountPayable = combo;
		combo = cboAccountReceivable;
		cCombo.getAccount(ref combo, All: false, 0, 2, 0, 0, 99, 99, 99, 0, 99);
		cboAccountReceivable = combo;
		combo = cboAdvancePurchase;
		cCombo.getAccount(ref combo, All: false, 0, 8, 0, 0, 99, 99, 99, 0, 99);
		cboAdvancePurchase = combo;
		combo = cboAdvanceSales;
		cCombo.getAccount(ref combo, All: false, 0, 2, 0, 0, 99, 99, 99, 0, 99);
		cboAdvanceSales = combo;
		combo = cboRealizeGainLoss;
		cCombo.getAccount(ref combo, All: false, 0, 14, 0, 0, 99, 99, 99, 0, 99);
		cboRealizeGainLoss = combo;
		combo = cboUnrealizeGainLoss;
		cCombo.getAccount(ref combo, All: false, 0, 14, 0, 0, 99, 99, 99, 0, 99);
		cboUnrealizeGainLoss = combo;
		cboActive.SelectedIndex = 0;
	}

	private void frmSettingCurrencyInput_KeyDown(object sender, KeyEventArgs e)
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
					cCurrency cCurrency2 = new cCurrency(_currentId);
					txtName.Text = cCurrency2.Name;
					txtSymbol.Text = cCurrency2.Symbol;
					txtRate.Text = Module1.formatCustomDecimal(Conversions.ToString(cCurrency2.Rate), 2);
					ComboBox cboSource = cboActive;
					Module1.comboBoundValue(ref cboSource, cCurrency2.Active);
					cboActive = cboSource;
					cboSource = cboAccountPayable;
					Module1.comboBoundValue(ref cboSource, cCurrency2.AccountPayableId);
					cboAccountPayable = cboSource;
					cboSource = cboAccountReceivable;
					Module1.comboBoundValue(ref cboSource, cCurrency2.AccountReceivableId);
					cboAccountReceivable = cboSource;
					cboSource = cboAdvancePurchase;
					Module1.comboBoundValue(ref cboSource, cCurrency2.AdvancePurchaseId);
					cboAdvancePurchase = cboSource;
					cboSource = cboAdvanceSales;
					Module1.comboBoundValue(ref cboSource, cCurrency2.AdvanceSalesId);
					cboAdvanceSales = cboSource;
					cboSource = cboRealizeGainLoss;
					Module1.comboBoundValue(ref cboSource, cCurrency2.RealizeGainLossId);
					cboRealizeGainLoss = cboSource;
					cboSource = cboUnrealizeGainLoss;
					Module1.comboBoundValue(ref cboSource, cCurrency2.UnrealizeGainLossId);
					cboUnrealizeGainLoss = cboSource;
					goto end_IL_0001;
				}
				case 335:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSettingCurrencyInput", "LoadData", "");
						_currentId = 0;
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 335;
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

	public void prepareForm()
	{
		_currentId = 0;
	}

	private void btnSaveClose_Click(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboActive.SelectedItem;
		cComboItem cComboItem3 = (cComboItem)cboAccountPayable.SelectedItem;
		cComboItem cComboItem4 = (cComboItem)cboAccountReceivable.SelectedItem;
		cComboItem cComboItem5 = (cComboItem)cboAdvancePurchase.SelectedItem;
		cComboItem cComboItem6 = (cComboItem)cboAdvanceSales.SelectedItem;
		cComboItem cComboItem7 = (cComboItem)cboRealizeGainLoss.SelectedItem;
		cComboItem cComboItem8 = (cComboItem)cboUnrealizeGainLoss.SelectedItem;
		if (Operators.CompareString(txtName.Text, "", TextCompare: false) == 0)
		{
			Interaction.MsgBox("Masukkan nama mata uang", MsgBoxStyle.Information);
			txtName.Focus();
			return;
		}
		if (Operators.CompareString(txtSymbol.Text, "", TextCompare: false) == 0)
		{
			Interaction.MsgBox("Masukkan simbol mata uang", MsgBoxStyle.Information);
			txtSymbol.Focus();
			return;
		}
		if (cCurrency.IsExist(_currentId, Module1.cleanString(txtName.Text), Module1.cleanString(txtSymbol.Text)))
		{
			Interaction.MsgBox("Nama/simbol mata uang sudah pernah digunakan. Masukkan nama/simbol lain.", MsgBoxStyle.Information);
			txtName.Focus();
			return;
		}
		if (Operators.CompareString(txtRate.Text, "", TextCompare: false) == 0)
		{
			Interaction.MsgBox("Masukkan nilai tukar", MsgBoxStyle.Information);
			txtRate.Focus();
			return;
		}
		if (!Versioned.IsNumeric(txtRate.Text))
		{
			Interaction.MsgBox("Masukkan nilai tukar dengan format angka yang benar", MsgBoxStyle.Information);
			txtRate.Focus();
			return;
		}
		if (cboActive.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih aktif/tidak", MsgBoxStyle.Information);
			cboActive.Focus();
			return;
		}
		if (Conversions.ToDouble(CurrentId) > 0.0)
		{
			if (cboAccountPayable.SelectedIndex == -1)
			{
				Interaction.MsgBox("Pilih default akun hutang", MsgBoxStyle.Information);
				return;
			}
			if (cboAccountReceivable.SelectedIndex == -1)
			{
				Interaction.MsgBox("Pilih default akun piutang", MsgBoxStyle.Information);
				return;
			}
			if (cboAdvancePurchase.SelectedIndex == -1)
			{
				Interaction.MsgBox("Pilih default uang muka pembelian", MsgBoxStyle.Information);
				return;
			}
			if (cboAdvanceSales.SelectedIndex == -1)
			{
				Interaction.MsgBox("Pilih default uang muka penjualan", MsgBoxStyle.Information);
				return;
			}
			if (cboRealizeGainLoss.SelectedIndex == -1)
			{
				Interaction.MsgBox("Pilih default laba/rugi terealisir", MsgBoxStyle.Information);
				return;
			}
			if (cboUnrealizeGainLoss.SelectedIndex == -1)
			{
				Interaction.MsgBox("Pilih default laba/rugi tak terealisir", MsgBoxStyle.Information);
				return;
			}
		}
		cCurrency cCurrency2 = new cCurrency(0);
		cCurrency2.Id = Conversions.ToInteger(CurrentId);
		cCurrency2.Name = txtName.Text;
		cCurrency2.Symbol = txtSymbol.Text;
		cCurrency2.Rate = Math.Round(Conversion.Val(Module1.unformatNumber(txtRate.Text)), 2);
		cCurrency2.Active = Conversions.ToInteger(cComboItem2.Value);
		if (Conversions.ToDouble(CurrentId) > 0.0)
		{
			cCurrency2.AccountPayableId = Conversions.ToInteger(cComboItem3.Value);
			cCurrency2.AccountReceivableId = Conversions.ToInteger(cComboItem4.Value);
			cCurrency2.AdvancePurchaseId = Conversions.ToInteger(cComboItem5.Value);
			cCurrency2.AdvanceSalesId = Conversions.ToInteger(cComboItem6.Value);
			cCurrency2.RealizeGainLossId = Conversions.ToInteger(cComboItem7.Value);
			cCurrency2.UnrealizeGainLossId = Conversions.ToInteger(cComboItem8.Value);
		}
		cCurrency2.Save();
		Interaction.MsgBox("Mata uang berhasil disimpan", MsgBoxStyle.Information);
		MyProject.Forms.frmSettingCurrencyList.getList();
		Close();
	}
}
