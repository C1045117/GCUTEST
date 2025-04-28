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
public class frmSettingInvoiceNumber : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboSalesPerson")]
	private ComboBox _cboSalesPerson;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboYear")]
	private ComboBox _cboYear;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvList")]
	private DataGridView _dgvList;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSave")]
	private Button _btnSave;

	private int _isDonator;

	private int _branchId;

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox cboSalesPerson
	{
		[CompilerGenerated]
		get
		{
			return _cboSalesPerson;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cboSalesPerson_SelectedIndexChanged;
			ComboBox comboBox = _cboSalesPerson;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_cboSalesPerson = value;
			comboBox = _cboSalesPerson;
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

	[field: AccessedThroughProperty("txtSalesPersonCode")]
	internal virtual TextBox txtSalesPersonCode
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

	[field: AccessedThroughProperty("ShapeContainer1")]
	internal virtual ShapeContainer ShapeContainer1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LineShape2")]
	internal virtual LineShape LineShape2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LineShape1")]
	internal virtual LineShape LineShape1
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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtLatestNumber")]
	internal virtual FilteredTextBox txtLatestNumber
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
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		this.Label4 = new System.Windows.Forms.Label();
		this.cboSalesPerson = new System.Windows.Forms.ComboBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.cboYear = new System.Windows.Forms.ComboBox();
		this.txtSalesPersonCode = new System.Windows.Forms.TextBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.dgvList = new System.Windows.Forms.DataGridView();
		this.btnSave = new System.Windows.Forms.Button();
		this.ShapeContainer1 = new ShapeContainer();
		this.LineShape2 = new LineShape();
		this.LineShape1 = new LineShape();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.txtLatestNumber = new GCUv2.FilteredTextBox();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		base.SuspendLayout();
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(10, 15);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(33, 13);
		this.Label4.TabIndex = 239;
		this.Label4.Text = "Sales";
		this.cboSalesPerson.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboSalesPerson.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboSalesPerson.FormattingEnabled = true;
		this.cboSalesPerson.Location = new System.Drawing.Point(76, 12);
		this.cboSalesPerson.Name = "cboSalesPerson";
		this.cboSalesPerson.Size = new System.Drawing.Size(120, 21);
		this.cboSalesPerson.TabIndex = 0;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(10, 78);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(38, 13);
		this.Label1.TabIndex = 241;
		this.Label1.Text = "Tahun";
		this.cboYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboYear.FormattingEnabled = true;
		this.cboYear.Location = new System.Drawing.Point(76, 75);
		this.cboYear.Name = "cboYear";
		this.cboYear.Size = new System.Drawing.Size(120, 21);
		this.cboYear.TabIndex = 2;
		this.txtSalesPersonCode.Location = new System.Drawing.Point(76, 49);
		this.txtSalesPersonCode.Name = "txtSalesPersonCode";
		this.txtSalesPersonCode.Size = new System.Drawing.Size(120, 20);
		this.txtSalesPersonCode.TabIndex = 1;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(10, 52);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(58, 13);
		this.Label2.TabIndex = 243;
		this.Label2.Text = "Kode Awal";
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.Location = new System.Drawing.Point(76, 140);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(201, 295);
		this.dgvList.TabIndex = 4;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(76, 441);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(87, 28);
		this.btnSave.TabIndex = 5;
		this.btnSave.Text = "Simpan";
		this.btnSave.UseVisualStyleBackColor = true;
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).Location = new System.Drawing.Point(0, 0);
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).Margin = new System.Windows.Forms.Padding(0);
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).Name = "ShapeContainer1";
		this.ShapeContainer1.Shapes.AddRange((Shape[])(object)new Shape[2]
		{
			(Shape)this.LineShape2,
			(Shape)this.LineShape1
		});
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).Size = new System.Drawing.Size(293, 479);
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).TabIndex = 246;
		((System.Windows.Forms.Control)(object)this.ShapeContainer1).TabStop = false;
		((Shape)this.LineShape2).BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
		((Shape)this.LineShape2).Name = "LineShape2";
		this.LineShape2.X1 = 14;
		this.LineShape2.X2 = 277;
		this.LineShape2.Y1 = 105;
		this.LineShape2.Y2 = 105;
		((Shape)this.LineShape1).BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
		((Shape)this.LineShape1).Name = "LineShape1";
		this.LineShape1.X1 = 14;
		this.LineShape1.X2 = 277;
		this.LineShape1.Y1 = 39;
		this.LineShape1.Y2 = 39;
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(10, 140);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(57, 13);
		this.Label3.TabIndex = 247;
		this.Label3.Text = "No. Faktur";
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(9, 115);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(105, 13);
		this.Label5.TabIndex = 248;
		this.Label5.Text = "Nomer Auto Terakhir";
		this.txtLatestNumber.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtLatestNumber.DontFormat = false;
		this.txtLatestNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtLatestNumber.Location = new System.Drawing.Point(120, 113);
		this.txtLatestNumber.MaximumDigit = 3;
		this.txtLatestNumber.Name = "txtLatestNumber";
		this.txtLatestNumber.Size = new System.Drawing.Size(76, 21);
		this.txtLatestNumber.TabIndex = 3;
		this.txtLatestNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(293, 479);
		base.Controls.Add(this.txtLatestNumber);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.dgvList);
		base.Controls.Add(this.txtSalesPersonCode);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.cboYear);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.cboSalesPerson);
		base.Controls.Add((System.Windows.Forms.Control)(object)this.ShapeContainer1);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSettingInvoiceNumber";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Setting - No. Faktur Komersial";
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmSettingInvoiceNumber()
	{
		base.KeyDown += frmSettingInvoiceNumber_KeyDown;
		InitializeComponent();
		DoubleBuffered = true;
		base.MdiParent = MyProject.Forms.frmMenu;
		txtLatestNumber.AllowedCharacters = FilteredTextBox.InputType.NumeralsOnly;
		txtLatestNumber.DontFormat = true;
		ComboBox combo = cboSalesPerson;
		cCombo.getSalesPerson(ref combo, "SALESPERSON", 0, 99, 0, Module1.pubGroupId, All: false, Dash: false, 1);
		cboSalesPerson = combo;
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

	private void frmSettingInvoiceNumber_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void cboSalesPerson_SelectedIndexChanged(object sender, EventArgs e)
	{
		if ((cboSalesPerson.SelectedIndex > -1) & (cboYear.SelectedIndex > -1))
		{
			getData();
		}
	}

	private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
	{
		if ((cboSalesPerson.SelectedIndex > -1) & (cboYear.SelectedIndex > -1))
		{
			getData();
		}
	}

	private void getData()
	{
		cComboItem cComboItem2 = (cComboItem)cboSalesPerson.SelectedItem;
		cComboItem cComboItem3 = (cComboItem)cboYear.SelectedItem;
		cInvoiceNumber cInvoiceNumber2 = new cInvoiceNumber(Conversions.ToInteger(cComboItem2.Value), Conversions.ToInteger(cComboItem3.Value));
		cSalesPerson cSalesPerson2 = new cSalesPerson(Conversions.ToInteger(cComboItem2.Value));
		txtSalesPersonCode.Text = cInvoiceNumber2.SalesPersonCode;
		txtLatestNumber.Text = Conversions.ToString(cInvoiceNumber2.LatestNumber);
		_isDonator = cSalesPerson2.IsDonator;
		_branchId = cSalesPerson2.BranchId;
		dgvList.Rows.Clear();
		cInvoiceNumber.NumberRange[] range = cInvoiceNumber2.Range;
		for (int i = 0; i < range.Length; i = checked(i + 1))
		{
			cInvoiceNumber.NumberRange numberRange = range[i];
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
						Module1.SaveError(Information.Err(), "frmSettingInvoiceNumber", "dgvList_CellValidating", "");
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
						cComboItem cComboItem2 = (cComboItem)cboSalesPerson.SelectedItem;
						cComboItem cComboItem3 = (cComboItem)cboYear.SelectedItem;
						if (cboSalesPerson.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih sales.", MsgBoxStyle.Information);
							cboSalesPerson.Focus();
						}
						else if (Operators.CompareString(txtSalesPersonCode.Text, "", TextCompare: false) == 0)
						{
							Interaction.MsgBox("Masukkan kode awal.", MsgBoxStyle.Information);
							txtSalesPersonCode.Focus();
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
							if (!Module1.isBeginLessThanEnd(dgvList) || (_isDonator != 1 && Module1.pubDuplicateSalesInvoiceNumber != 1 && cInvoiceNumber.IsUsed(cInvoiceNumber.SearchInvoiceNumber(Conversions.ToInteger(cComboItem2.Value), Conversions.ToInteger(cComboItem3.Value), blnAll: true, _branchId), dgvList)) || Module1.isAlreadyInGrid(dgvList))
							{
								goto end_IL_0001;
							}
							cInvoiceNumber cInvoiceNumber2 = new cInvoiceNumber(0, 0);
							cInvoiceNumber.NumberRange[] array = null;
							cInvoiceNumber2.SalesPersonId = Conversions.ToInteger(cComboItem2.Value);
							cInvoiceNumber2.Year = Conversions.ToInteger(cComboItem3.Value);
							cInvoiceNumber2.SalesPersonCode = txtSalesPersonCode.Text;
							cInvoiceNumber2.LatestNumber = Conversions.ToDouble(txtLatestNumber.Text);
							int num3 = dgvList.Rows.Count - 2;
							for (int i = 0; i <= num3; i++)
							{
								if ((Conversion.Val(RuntimeHelpers.GetObjectValue(dgvList[0, i].Value)) > 0.0) & (Conversion.Val(RuntimeHelpers.GetObjectValue(dgvList[1, i].Value)) > 0.0))
								{
									array = (cInvoiceNumber.NumberRange[])Utils.CopyArray(array, new cInvoiceNumber.NumberRange[num4 + 1]);
									array[num4]._begin = Conversions.ToDouble(dgvList[0, i].Value);
									array[num4]._end = Conversions.ToDouble(dgvList[1, i].Value);
									num4++;
								}
							}
							cInvoiceNumber2.Range = array;
							cInvoiceNumber2.Save();
							Interaction.MsgBox("Nomer Faktur berhasil disimpan.", MsgBoxStyle.Information);
							goto end_IL_0001;
						}
						goto end_IL_0001_2;
					}
					case 767:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmSettingInvoiceNumber", "btnSave_click", "");
							goto end_IL_0001_2;
						}
						break;
					}
					goto IL_0335;
				}
				end_IL_0001_2:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 767;
				continue;
			}
			break;
			IL_0335:
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
