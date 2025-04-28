using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GCUv2.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

[DesignerGenerated]
public class frmSettingSalesPriceCodeInput : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSaveClose")]
	private Button _btnSaveClose;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvList")]
	private DataGridView _dgvList;

	private bool _dontFocus;

	private int _currentId;

	private bool _blnDecimal;

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
			DataGridViewCellEventHandler value2 = dgvList_CellEnter;
			DataGridViewCellEventHandler value3 = dgvList_CellEndEdit;
			DataGridViewCellValidatingEventHandler value4 = dgvList_CellValidating;
			DataGridViewCellEventHandler value5 = dgvList_CellValidated;
			EventHandler value6 = dgvList_GotFocus;
			EventHandler value7 = dgvList_LostFocus;
			KeyEventHandler value8 = dgvList_KeyDown;
			DataGridViewEditingControlShowingEventHandler value9 = dgvList_EditingControlShowing;
			DataGridView dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.CellEnter -= value2;
				dataGridView.CellEndEdit -= value3;
				dataGridView.CellValidating -= value4;
				dataGridView.CellValidated -= value5;
				dataGridView.GotFocus -= value6;
				dataGridView.LostFocus -= value7;
				dataGridView.KeyDown -= value8;
				dataGridView.EditingControlShowing -= value9;
			}
			_dgvList = value;
			dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.CellEnter += value2;
				dataGridView.CellEndEdit += value3;
				dataGridView.CellValidating += value4;
				dataGridView.CellValidated += value5;
				dataGridView.GotFocus += value6;
				dataGridView.LostFocus += value7;
				dataGridView.KeyDown += value8;
				dataGridView.EditingControlShowing += value9;
			}
		}
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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
		this.dgvList = new System.Windows.Forms.DataGridView();
		this.Label2 = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		base.SuspendLayout();
		this.btnSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSaveClose.Location = new System.Drawing.Point(91, 526);
		this.btnSaveClose.Name = "btnSaveClose";
		this.btnSaveClose.Size = new System.Drawing.Size(93, 24);
		this.btnSaveClose.TabIndex = 10;
		this.btnSaveClose.Text = "Simpan && &Tutup";
		this.btnSaveClose.UseVisualStyleBackColor = true;
		this.Label9.AutoSize = true;
		this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label9.Location = new System.Drawing.Point(11, 41);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(28, 13);
		this.Label9.TabIndex = 135;
		this.Label9.Text = "Aktif";
		this.cboActive.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboActive.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboActive.FormattingEnabled = true;
		this.cboActive.Location = new System.Drawing.Point(91, 38);
		this.cboActive.Name = "cboActive";
		this.cboActive.Size = new System.Drawing.Size(110, 21);
		this.cboActive.TabIndex = 1;
		this.txtName.Location = new System.Drawing.Point(91, 12);
		this.txtName.Name = "txtName";
		this.txtName.Size = new System.Drawing.Size(110, 20);
		this.txtName.TabIndex = 0;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(11, 15);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(64, 13);
		this.Label1.TabIndex = 133;
		this.Label1.Text = "Kode Harga";
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.Location = new System.Drawing.Point(91, 69);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(239, 451);
		this.dgvList.TabIndex = 2;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(12, 69);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(66, 13);
		this.Label2.TabIndex = 137;
		this.Label2.Text = "Detail Harga";
		base.AcceptButton = this.btnSaveClose;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(342, 562);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.dgvList);
		base.Controls.Add(this.btnSaveClose);
		base.Controls.Add(this.Label9);
		base.Controls.Add(this.cboActive);
		base.Controls.Add(this.txtName);
		base.Controls.Add(this.Label1);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSettingSalesPriceCodeInput";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Setting - Kode Harga";
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmSettingSalesPriceCodeInput()
	{
		base.KeyDown += frmSettingSalesPriceCodeInput_KeyDown;
		base.Load += frmSettingSalesPriceCodeInput_Load;
		_blnDecimal = false;
		InitializeComponent();
		ComboBox combo = cboActive;
		cCombo.getYesNo(ref combo, All: false);
		cboActive = combo;
		cboActive.SelectedIndex = 0;
		FormatGrid();
	}

	private void frmSettingSalesPriceCodeInput_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void frmSettingSalesPriceCodeInput_Load(object sender, EventArgs e)
	{
		if (dgvList.RowCount > 0)
		{
			dgvList.CurrentCell.Selected = false;
		}
	}

	private void FormatGrid()
	{
		dgvList.Columns.Add("", "prodId");
		dgvList.Columns.Add("", "Barang");
		dgvList.Columns.Add("", "Harga Jual");
		dgvList.Columns[0].Visible = false;
		dgvList.Columns[1].ReadOnly = true;
		dgvList.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[2].DefaultCellStyle.Format = "N0";
		dgvList.Columns[1].Width = 120;
		dgvList.Columns[2].Width = 97;
		dgvList.RowHeadersVisible = false;
		dgvList.AllowUserToAddRows = false;
		dgvList.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvList.AllowUserToResizeRows = false;
		dgvList.EditMode = DataGridViewEditMode.EditOnEnter;
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
					cSalesPriceCode cSalesPriceCode2 = new cSalesPriceCode(_currentId);
					txtName.Text = cSalesPriceCode2.Name;
					ComboBox cboSource = cboActive;
					Module1.comboBoundValue(ref cboSource, cSalesPriceCode2.Active);
					cboActive = cboSource;
					cSalesPriceCodeItem[] item = cSalesPriceCode2.Item;
					foreach (cSalesPriceCodeItem cSalesPriceCodeItem2 in item)
					{
						dgvList.Rows.Add(cSalesPriceCodeItem2.ItemId, cSalesPriceCodeItem2.ItemName, cSalesPriceCodeItem2.Price);
						if (cSalesPriceCodeItem2.Price > 0.0)
						{
							dgvList[2, checked(dgvList.RowCount - 1)].Style.BackColor = Color.LightGreen;
						}
					}
					goto end_IL_0001;
				}
				case 285:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSettingSettingSalesPriceCodeInput", "LoadData", "");
						_currentId = 0;
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 285;
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
		int try0001_dispatch = -1;
		int num2 = default(int);
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
						cComboItem cComboItem2 = (cComboItem)cboActive.SelectedItem;
						if (Operators.CompareString(txtName.Text, "", TextCompare: false) == 0)
						{
							Interaction.MsgBox("Masukkan kode harga", MsgBoxStyle.Information);
							txtName.Focus();
							goto end_IL_0001;
						}
						if (cSalesPriceCode.IsExist(_currentId, Module1.cleanString(txtName.Text)))
						{
							Interaction.MsgBox("Kode harga sudah pernah digunakan. Masukkan kode harga lain.", MsgBoxStyle.Information);
							txtName.Focus();
							goto end_IL_0001;
						}
						if (cboActive.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih aktif/tidak", MsgBoxStyle.Information);
							cboActive.Focus();
							goto end_IL_0001;
						}
						Cursor = Cursors.WaitCursor;
						cSalesPriceCode cSalesPriceCode2 = new cSalesPriceCode(0);
						cSalesPriceCode2.Id = Conversions.ToInteger(CurrentId);
						cSalesPriceCode2.Name = txtName.Text;
						cSalesPriceCode2.Active = Conversions.ToInteger(cComboItem2.Value);
						cSalesPriceCodeItem[] array = new cSalesPriceCodeItem[dgvList.Rows.Count - 1 + 1];
						int num3 = dgvList.Rows.Count - 1;
						for (int i = 0; i <= num3; i++)
						{
							array[i] = new cSalesPriceCodeItem();
							array[i].ItemId = Conversions.ToInteger(dgvList[0, i].Value);
							array[i].Price = Conversions.ToDouble(dgvList[2, i].Value);
						}
						cSalesPriceCode2.Item = array;
						cSalesPriceCode2.Save();
						Cursor = Cursors.Default;
						Interaction.MsgBox("Kode harga berhasil disimpan", MsgBoxStyle.Information);
						MyProject.Forms.frmSettingSalesPriceCodeList.getList();
						Close();
						goto end_IL_0001;
					}
					case 529:
						num = -1;
						switch (num2)
						{
						case 2:
							Cursor = Cursors.Default;
							Module1.SaveError(Information.Err(), "frmSettingSalesPriceCodeInput", "btnSaveClose_click", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 529;
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

	private void dgvList_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		if (dgvList.CurrentCell.ColumnIndex == 2)
		{
			string strInput = dgvList[dgvList.CurrentCell.ColumnIndex, dgvList.CurrentCell.RowIndex].Value.ToString();
			strInput = Module1.formatCustomDecimal(strInput, 3);
			strInput = Conversions.ToString(decimal.Parse(strInput, NumberStyles.Currency));
			dgvList[dgvList.CurrentCell.ColumnIndex, dgvList.CurrentCell.RowIndex].Value = strInput;
		}
	}

	private void dgvList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
	{
		if (dgvList.CurrentCell.ColumnIndex == 2)
		{
			string strInput = ((Information.IsNothing(RuntimeHelpers.GetObjectValue(dgvList[dgvList.CurrentCell.ColumnIndex, dgvList.CurrentCell.RowIndex].Value)) || Operators.CompareString(dgvList[dgvList.CurrentCell.ColumnIndex, dgvList.CurrentCell.RowIndex].Value.ToString(), "", TextCompare: false) == 0) ? Conversions.ToString(0) : dgvList[dgvList.CurrentCell.ColumnIndex, dgvList.CurrentCell.RowIndex].Value.ToString());
			strInput = Module1.formatCustomDecimal(strInput, 2);
			dgvList[dgvList.CurrentCell.ColumnIndex, dgvList.CurrentCell.RowIndex].Value = strInput;
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
					if (e.ColumnIndex == 2 && !dgvList.Rows[e.RowIndex].IsNewRow)
					{
						if (Operators.CompareString(Strings.Trim(e.FormattedValue.ToString()), "", TextCompare: false) != 0 && !Versioned.IsNumeric(e.FormattedValue.ToString()))
						{
							e.Cancel = true;
							Interaction.MsgBox("Masukkan jumlah dengan format angka yang benar", MsgBoxStyle.Information);
						}
						else
						{
							_dontFocus = true;
						}
					}
					goto end_IL_0001;
				case 187:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSettingSalesPrice", "dgvList_CellValidating", "");
						goto end_IL_0001;
					}
					break;
				}
				goto IL_00f1;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 187;
				continue;
			}
			break;
			IL_00f1:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void dgvList_CellValidated(object sender, DataGridViewCellEventArgs e)
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
					double num3 = Conversion.Val(Module1.unformatNumber(Conversions.ToString(dgvList[2, dgvList.CurrentCell.RowIndex].Value)));
					if (num3 > 0.0)
					{
						dgvList[2, dgvList.CurrentCell.RowIndex].Style.BackColor = Color.LightGreen;
					}
					else if (dgvList.CurrentCell.RowIndex % 2 == 1)
					{
						dgvList[2, dgvList.CurrentCell.RowIndex].Style.BackColor = Color.WhiteSmoke;
					}
					else
					{
						dgvList[2, dgvList.CurrentCell.RowIndex].Style.BackColor = Color.White;
					}
					goto end_IL_0001;
				}
				case 274:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSettingSalesPriceCodeInput", "dgvList_CellValidated", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 274;
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

	private void dgvList_GotFocus(object sender, EventArgs e)
	{
		if ((dgvList.RowCount > 0) & !_dontFocus)
		{
			dgvList.CurrentCell.Selected = true;
		}
		else
		{
			_dontFocus = false;
		}
	}

	private void dgvList_LostFocus(object sender, EventArgs e)
	{
		if (dgvList.RowCount > 0)
		{
			dgvList.CurrentCell.Selected = false;
		}
	}

	private void dgvList_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			e.SuppressKeyPress = true;
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			cboActive.Focus();
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			btnSaveClose.Focus();
			e.SuppressKeyPress = true;
		}
	}

	private void dgvList_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
	{
		Control control = e.Control;
		control.KeyDown += Handle_KeyDown;
		control.KeyPress += Handle_KeyPress;
	}

	protected void Handle_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyValue == 110)
		{
			_blnDecimal = true;
		}
		else
		{
			_blnDecimal = false;
		}
	}

	protected void Handle_KeyPress(object sender, KeyPressEventArgs e)
	{
		short num = checked((short)Strings.Asc(e.KeyChar));
		if (_blnDecimal)
		{
			e.KeyChar = Conversions.ToChar(CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
		}
		if (!((num >= 48 && num <= 57) | (e.KeyChar == Convert.ToChar(110)) | (e.KeyChar == Convert.ToChar(8)) | (Operators.CompareString(Conversions.ToString(e.KeyChar), CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator, TextCompare: false) == 0)))
		{
			e.Handled = true;
		}
	}
}
