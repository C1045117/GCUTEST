using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GCUv2.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.PowerPacks;

namespace GCUv2;

[DesignerGenerated]
public class frmSettingReturnTaxInvoiceNumber : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSave")]
	private Button _btnSave;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboYear")]
	private ComboBox _cboYear;

	[field: AccessedThroughProperty("txtLatestNumber")]
	internal virtual FilteredTextBox txtLatestNumber
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox cboYear
	{
		[CompilerGenerated]
		get
		{
			return _cboYear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cboYear_SelectedIndexChanged;
			ComboBox comboBox = _cboYear;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_cboYear = value;
			comboBox = _cboYear;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("LineShape2")]
	internal virtual LineShape LineShape2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ShapeContainer1")]
	internal virtual ShapeContainer ShapeContainer1
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
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		this.txtLatestNumber = new GCUv2.FilteredTextBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.btnSave = new System.Windows.Forms.Button();
		this.Label1 = new System.Windows.Forms.Label();
		this.cboYear = new System.Windows.Forms.ComboBox();
		this.LineShape2 = new LineShape();
		this.ShapeContainer1 = new ShapeContainer();
		base.SuspendLayout();
		this.txtLatestNumber.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtLatestNumber.DontFormat = false;
		this.txtLatestNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtLatestNumber.Location = new System.Drawing.Point(121, 50);
		this.txtLatestNumber.MaximumDigit = 3;
		this.txtLatestNumber.Name = "txtLatestNumber";
		this.txtLatestNumber.Size = new System.Drawing.Size(76, 21);
		this.txtLatestNumber.TabIndex = 250;
		this.txtLatestNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(10, 52);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(105, 13);
		this.Label5.TabIndex = 253;
		this.Label5.Text = "Nomer Auto Terakhir";
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(121, 77);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(87, 28);
		this.btnSave.TabIndex = 251;
		this.btnSave.Text = "Simpan";
		this.btnSave.UseVisualStyleBackColor = true;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(11, 15);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(38, 13);
		this.Label1.TabIndex = 252;
		this.Label1.Text = "Tahun";
		this.cboYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboYear.FormattingEnabled = true;
		this.cboYear.Location = new System.Drawing.Point(121, 15);
		this.cboYear.Name = "cboYear";
		this.cboYear.Size = new System.Drawing.Size(120, 21);
		this.cboYear.TabIndex = 249;
		((Shape)this.LineShape2).BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
		((Shape)this.LineShape2).Name = "LineShape2";
		this.LineShape2.X1 = 11;
		this.LineShape2.X2 = 274;
		this.LineShape2.Y1 = 42;
		this.LineShape2.Y2 = 42;
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).Location = new System.Drawing.Point(0, 0);
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).Margin = new System.Windows.Forms.Padding(0);
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).Name = "ShapeContainer1";
		this.ShapeContainer1.Shapes.AddRange((Shape[])(object)new Shape[1] { (Shape)this.LineShape2 });
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).Size = new System.Drawing.Size(284, 116);
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).TabIndex = 254;
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).TabStop = false;
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(284, 116);
		base.Controls.Add(this.txtLatestNumber);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.cboYear);
		base.Controls.Add((System.Windows.Forms.Control)(object)this.ShapeContainer1);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSettingReturnTaxInvoiceNumber";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Setting - No. Retur Pajak";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmSettingReturnTaxInvoiceNumber()
	{
		base.KeyDown += frmSettingReturnTaxInvoiceNumber_KeyDown;
		InitializeComponent();
		DoubleBuffered = true;
		base.MdiParent = MyProject.Forms.frmMenu;
		txtLatestNumber.AllowedCharacters = FilteredTextBox.InputType.NumeralsOnly;
		txtLatestNumber.DontFormat = true;
		ComboBox combo = cboYear;
		cCombo.getYear(ref combo, blnAll: false, checked(DateAndTime.Year(DateAndTime.Now) - 1), 1);
		cboYear = combo;
		cboYear.SelectedIndex = 1;
	}

	private void frmSettingReturnTaxInvoiceNumber_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (cboYear.SelectedIndex > -1)
		{
			getData();
		}
	}

	private void getData()
	{
		cComboItem cComboItem2 = (cComboItem)cboYear.SelectedItem;
		cReturnTaxInvoiceNumber cReturnTaxInvoiceNumber2 = new cReturnTaxInvoiceNumber(Conversions.ToInteger(cComboItem2.Value));
		txtLatestNumber.Text = Conversions.ToString(cReturnTaxInvoiceNumber2.LatestNumber);
	}

	private void btnSave_Click(object sender, EventArgs e)
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
					cComboItem cComboItem2 = (cComboItem)cboYear.SelectedItem;
					if (cboYear.SelectedIndex == -1)
					{
						Interaction.MsgBox("Pilih tahun.", MsgBoxStyle.Information);
						cboYear.Focus();
						goto end_IL_0001;
					}
					if (Operators.CompareString(txtLatestNumber.Text, "", TextCompare: false) == 0)
					{
						Interaction.MsgBox("Masukkan nomer auto terakhir.", MsgBoxStyle.Information);
						txtLatestNumber.Focus();
						goto end_IL_0001;
					}
					cReturnTaxInvoiceNumber cReturnTaxInvoiceNumber2 = new cReturnTaxInvoiceNumber(0);
					cReturnTaxInvoiceNumber2.Year = Conversions.ToInteger(cComboItem2.Value);
					cReturnTaxInvoiceNumber2.LatestNumber = Conversions.ToDouble(txtLatestNumber.Text);
					cReturnTaxInvoiceNumber2.Save();
					Interaction.MsgBox("Nomer Faktur berhasil disimpan.", MsgBoxStyle.Information);
					goto end_IL_0001;
				}
				case 237:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSettingReturnTaxInvoiceNumber", "btnSave_click", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 237;
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
}
