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
public class frmSettingTaxInvoiceNumber : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSave")]
	private Button _btnSave;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvList")]
	private DataGridView _dgvList;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboYear")]
	private ComboBox _cboYear;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboBranch")]
	private ComboBox _cboBranch;

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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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

	internal virtual DataGridView dgvList
	{
		[CompilerGenerated]
		get
		{
			return _dgvList;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = dgvList_KeyDown;
			DataGridViewCellValidatingEventHandler value3 = dgvList_CellValidating;
			DataGridView dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.KeyDown -= value2;
				dataGridView.CellValidating -= value3;
			}
			_dgvList = value;
			dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.KeyDown += value2;
				dataGridView.CellValidating += value3;
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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox cboBranch
	{
		[CompilerGenerated]
		get
		{
			return _cboBranch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cboBranch_SelectedIndexChanged;
			ComboBox comboBox = _cboBranch;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_cboBranch = value;
			comboBox = _cboBranch;
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
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		this.txtLatestNumber = new GCUv2.FilteredTextBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.btnSave = new System.Windows.Forms.Button();
		this.dgvList = new System.Windows.Forms.DataGridView();
		this.Label1 = new System.Windows.Forms.Label();
		this.cboYear = new System.Windows.Forms.ComboBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.cboBranch = new System.Windows.Forms.ComboBox();
		this.LineShape2 = new LineShape();
		this.ShapeContainer1 = new ShapeContainer();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		base.SuspendLayout();
		this.txtLatestNumber.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtLatestNumber.DontFormat = false;
		this.txtLatestNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtLatestNumber.Location = new System.Drawing.Point(121, 74);
		this.txtLatestNumber.MaximumDigit = 3;
		this.txtLatestNumber.Name = "txtLatestNumber";
		this.txtLatestNumber.Size = new System.Drawing.Size(76, 21);
		this.txtLatestNumber.TabIndex = 2;
		this.txtLatestNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(10, 76);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(105, 13);
		this.Label5.TabIndex = 259;
		this.Label5.Text = "Nomer Auto Terakhir";
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(10, 101);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(57, 13);
		this.Label3.TabIndex = 258;
		this.Label3.Text = "No. Faktur";
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(77, 438);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(87, 28);
		this.btnSave.TabIndex = 4;
		this.btnSave.Text = "Simpan";
		this.btnSave.UseVisualStyleBackColor = true;
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.Location = new System.Drawing.Point(76, 101);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(201, 331);
		this.dgvList.TabIndex = 3;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(11, 39);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(38, 13);
		this.Label1.TabIndex = 256;
		this.Label1.Text = "Tahun";
		this.cboYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboYear.FormattingEnabled = true;
		this.cboYear.Location = new System.Drawing.Point(77, 36);
		this.cboYear.Name = "cboYear";
		this.cboYear.Size = new System.Drawing.Size(120, 21);
		this.cboYear.TabIndex = 1;
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(11, 12);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(44, 13);
		this.Label4.TabIndex = 255;
		this.Label4.Text = "Cabang";
		this.cboBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboBranch.FormattingEnabled = true;
		this.cboBranch.Location = new System.Drawing.Point(77, 9);
		this.cboBranch.Name = "cboBranch";
		this.cboBranch.Size = new System.Drawing.Size(120, 21);
		this.cboBranch.TabIndex = 0;
		((Shape)this.LineShape2).BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
		((Shape)this.LineShape2).Name = "LineShape2";
		this.LineShape2.X1 = 13;
		this.LineShape2.X2 = 276;
		this.LineShape2.Y1 = 65;
		this.LineShape2.Y2 = 65;
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).Location = new System.Drawing.Point(0, 0);
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).Margin = new System.Windows.Forms.Padding(0);
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).Name = "ShapeContainer1";
		this.ShapeContainer1.Shapes.AddRange((Shape[])(object)new Shape[1] { (Shape)this.LineShape2 });
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).Size = new System.Drawing.Size(291, 476);
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).TabIndex = 260;
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).TabStop = false;
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(291, 476);
		base.Controls.Add(this.txtLatestNumber);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.dgvList);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.cboYear);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.cboBranch);
		base.Controls.Add((System.Windows.Forms.Control)(object)this.ShapeContainer1);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSettingTaxInvoiceNumber";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Setting - No. Faktur Pajak";
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmSettingTaxInvoiceNumber()
	{
		base.KeyDown += frmSettingTaxInvoiceNumber_KeyDown;
		InitializeComponent();
		DoubleBuffered = true;
		base.MdiParent = MyProject.Forms.frmMenu;
		txtLatestNumber.AllowedCharacters = FilteredTextBox.InputType.NumeralsOnly;
		txtLatestNumber.DontFormat = true;
		ComboBox combo = cboBranch;
		cCombo.getBranch(ref combo, Module1.pubGroupId, blnAll: false);
		cboBranch = combo;
		combo = cboYear;
		cCombo.getYear(ref combo, blnAll: false, checked(DateAndTime.Year(DateAndTime.Now) - 1), 1);
		cboYear = combo;
		cboYear.SelectedIndex = 1;
		formatGrid();
	}

	private void formatGrid()
	{
		dgvList.Columns.Add("", "Awal");
		dgvList.Columns.Add("", "Akhir");
		dgvList.Columns[0].Width = 80;
		dgvList.Columns[1].Width = 80;
		dgvList.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.RowHeadersVisible = false;
		dgvList.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvList.AllowUserToResizeRows = false;
		dgvList.AllowUserToDeleteRows = true;
	}

	private void frmSettingTaxInvoiceNumber_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void cboBranch_SelectedIndexChanged(object sender, EventArgs e)
	{
		if ((cboBranch.SelectedIndex > -1) & (cboYear.SelectedIndex > -1))
		{
			getData();
		}
	}

	private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
	{
		if ((cboBranch.SelectedIndex > -1) & (cboYear.SelectedIndex > -1))
		{
			getData();
		}
	}

	private void getData()
	{
		cComboItem cComboItem2 = (cComboItem)cboBranch.SelectedItem;
		cComboItem cComboItem3 = (cComboItem)cboYear.SelectedItem;
		cTaxInvoiceNumber cTaxInvoiceNumber2 = new cTaxInvoiceNumber(Conversions.ToInteger(cComboItem2.Value), Conversions.ToInteger(cboYear.Text));
		txtLatestNumber.Text = Conversions.ToString(cTaxInvoiceNumber2.LatestNumber);
		dgvList.Rows.Clear();
		cTaxInvoiceNumber.NumberRange[] range = cTaxInvoiceNumber2.Range;
		for (int i = 0; i < range.Length; i = checked(i + 1))
		{
			cTaxInvoiceNumber.NumberRange numberRange = range[i];
			dgvList.Rows.Add(Conversion.Val(numberRange._begin), Conversion.Val(numberRange._end));
		}
	}

	private void dgvList_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Delete && !dgvList.Rows[dgvList.CurrentRow.Index].IsNewRow)
		{
			dgvList.Rows.RemoveAt(dgvList.CurrentRow.Index);
		}
	}

	private void dgvList_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
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
					if (!dgvList.Rows[e.RowIndex].IsNewRow && Operators.CompareString(Strings.Trim(e.FormattedValue.ToString()), "", TextCompare: false) != 0 && !Versioned.IsNumeric(e.FormattedValue.ToString()))
					{
						e.Cancel = true;
						Interaction.MsgBox("Masukkan nomer dengan format angka yang benar", MsgBoxStyle.Information);
					}
					goto end_IL_0001;
				case 153:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSettingTaxInvoiceNumber", "dgvList_CellValidating", "");
						goto end_IL_0001;
					}
					break;
				}
				goto IL_00cf;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 153;
				continue;
			}
			break;
			IL_00cf:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num4 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						cComboItem cComboItem2 = (cComboItem)cboBranch.SelectedItem;
						cComboItem cComboItem3 = (cComboItem)cboYear.SelectedItem;
						if (cboBranch.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih cabang.", MsgBoxStyle.Information);
							cboBranch.Focus();
						}
						else if (cboYear.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih tahun.", MsgBoxStyle.Information);
							cboYear.Focus();
						}
						else if (Operators.CompareString(txtLatestNumber.Text, "", TextCompare: false) == 0)
						{
							Interaction.MsgBox("Masukkan nomer auto terakhir.", MsgBoxStyle.Information);
							txtLatestNumber.Focus();
						}
						else
						{
							if (!Module1.isBeginLessThanEnd(dgvList) || Module1.isAlreadyInGrid(dgvList))
							{
								goto end_IL_0001;
							}
							cTaxInvoiceNumber cTaxInvoiceNumber2 = new cTaxInvoiceNumber(0, 0);
							cTaxInvoiceNumber.NumberRange[] array = null;
							cTaxInvoiceNumber2.BranchId = Conversions.ToInteger(cComboItem2.Value);
							cTaxInvoiceNumber2.Year = Conversions.ToInteger(cComboItem3.Value);
							cTaxInvoiceNumber2.LatestNumber = Conversions.ToDouble(txtLatestNumber.Text);
							int num3 = dgvList.Rows.Count - 2;
							for (int i = 0; i <= num3; i++)
							{
								if ((Conversion.Val(RuntimeHelpers.GetObjectValue(dgvList[0, i].Value)) > 0.0) & (Conversion.Val(RuntimeHelpers.GetObjectValue(dgvList[1, i].Value)) > 0.0))
								{
									array = (cTaxInvoiceNumber.NumberRange[])Utils.CopyArray(array, new cTaxInvoiceNumber.NumberRange[num4 + 1]);
									array[num4]._begin = Conversions.ToDouble(dgvList[0, i].Value);
									array[num4]._end = Conversions.ToDouble(dgvList[1, i].Value);
									num4++;
								}
							}
							cTaxInvoiceNumber2.Range = array;
							cTaxInvoiceNumber2.Save();
							Interaction.MsgBox("Nomer Faktur berhasil disimpan.", MsgBoxStyle.Information);
							goto end_IL_0001;
						}
						goto end_IL_0001_2;
					}
					case 622:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmSettingTaxInvoiceNumber", "btnSave_click", "");
							goto end_IL_0001_2;
						}
						break;
					}
					goto IL_02a4;
				}
				end_IL_0001_2:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 622;
				continue;
			}
			break;
			IL_02a4:
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
