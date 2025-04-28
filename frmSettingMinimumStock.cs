using System;
using System.ComponentModel;
using System.Data;
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
public class frmSettingMinimumStock : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboBranch")]
	private ComboBox _cboBranch;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSaveClose")]
	private Button _btnSaveClose;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvList")]
	private DataGridView _dgvList;

	private bool _dontFocus;

	private bool _blnDecimal;

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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
			EventHandler value5 = dgvList_GotFocus;
			EventHandler value6 = dgvList_LostFocus;
			KeyEventHandler value7 = dgvList_KeyDown;
			DataGridViewEditingControlShowingEventHandler value8 = dgvList_EditingControlShowing;
			DataGridView dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.CellEnter -= value2;
				dataGridView.CellEndEdit -= value3;
				dataGridView.CellValidating -= value4;
				dataGridView.GotFocus -= value5;
				dataGridView.LostFocus -= value6;
				dataGridView.KeyDown -= value7;
				dataGridView.EditingControlShowing -= value8;
			}
			_dgvList = value;
			dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.CellEnter += value2;
				dataGridView.CellEndEdit += value3;
				dataGridView.CellValidating += value4;
				dataGridView.GotFocus += value5;
				dataGridView.LostFocus += value6;
				dataGridView.KeyDown += value7;
				dataGridView.EditingControlShowing += value8;
			}
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
		this.Label2 = new System.Windows.Forms.Label();
		this.cboBranch = new System.Windows.Forms.ComboBox();
		this.btnSaveClose = new System.Windows.Forms.Button();
		this.dgvList = new System.Windows.Forms.DataGridView();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		base.SuspendLayout();
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(11, 15);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(44, 13);
		this.Label2.TabIndex = 141;
		this.Label2.Text = "Cabang";
		this.cboBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboBranch.FormattingEnabled = true;
		this.cboBranch.Location = new System.Drawing.Point(76, 12);
		this.cboBranch.Name = "cboBranch";
		this.cboBranch.Size = new System.Drawing.Size(125, 21);
		this.cboBranch.TabIndex = 0;
		this.btnSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSaveClose.Location = new System.Drawing.Point(176, 529);
		this.btnSaveClose.Name = "btnSaveClose";
		this.btnSaveClose.Size = new System.Drawing.Size(93, 24);
		this.btnSaveClose.TabIndex = 142;
		this.btnSaveClose.Text = "Simpan && &Tutup";
		this.btnSaveClose.UseVisualStyleBackColor = true;
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.Location = new System.Drawing.Point(12, 39);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(255, 481);
		this.dgvList.TabIndex = 1;
		base.AcceptButton = this.btnSaveClose;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(281, 562);
		base.Controls.Add(this.dgvList);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.cboBranch);
		base.Controls.Add(this.btnSaveClose);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSettingMinimumStock";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Setting - Minimum Stok";
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmSettingMinimumStock()
	{
		base.KeyDown += frmSettingMinimumItem_KeyDown;
		_blnDecimal = false;
		InitializeComponent();
		base.MdiParent = MyProject.Forms.frmMenu;
		ComboBox combo = cboBranch;
		cCombo.getBranch(ref combo, 0, blnAll: false);
		cboBranch = combo;
		FormatGrid();
	}

	private void frmSettingMinimumItem_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void FormatGrid()
	{
		dgvList.Columns.Add("", "prodId");
		dgvList.Columns.Add("", "Barang");
		dgvList.Columns.Add("", "Jml. Minimum");
		dgvList.Columns[0].Visible = false;
		dgvList.Columns[1].ReadOnly = true;
		dgvList.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[2].DefaultCellStyle.Format = "N0";
		dgvList.Columns[1].Width = 140;
		dgvList.Columns[2].Width = 95;
		dgvList.RowHeadersVisible = false;
		dgvList.AllowUserToAddRows = false;
		dgvList.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvList.AllowUserToResizeRows = false;
		dgvList.EditMode = DataGridViewEditMode.EditOnEnter;
	}

	private void cboBranch_SelectedIndexChanged(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboBranch.SelectedItem;
		DataTable dataTable = cMinimumStock.Search(Conversions.ToInteger(cComboItem2.Value));
		dgvList.Rows.Clear();
		foreach (DataRow row in dataTable.Rows)
		{
			dgvList.Rows.Add(row["prodId"], row["prodName"], Information.IsDBNull(RuntimeHelpers.GetObjectValue(row["prodMin"])) ? ((object)0) : row["prodMin"]);
		}
		if (dataTable.Rows.Count > 0)
		{
			dgvList.Focus();
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
			strInput = Module1.formatCustomDecimal(strInput, 0);
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
						Module1.SaveError(Information.Err(), "frmSettingMinimumStock", "dgvList_CellValidating", "");
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
			cboBranch.Focus();
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
						cComboItem cComboItem2 = (cComboItem)cboBranch.SelectedItem;
						cMinimumStock cMinimumStock2 = new cMinimumStock();
						Cursor = Cursors.WaitCursor;
						cMinimumStockItem[] array = new cMinimumStockItem[dgvList.Rows.Count - 1 + 1];
						int num3 = dgvList.Rows.Count - 1;
						for (int i = 0; i <= num3; i++)
						{
							array[i] = new cMinimumStockItem();
							array[i].ItemId = Conversions.ToInteger(dgvList[0, i].Value);
							array[i].Qty = Conversions.ToDouble((!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dgvList[2, i].Value))) ? dgvList[2, i].Value : ((object)0));
						}
						cMinimumStock2.BranchId = Conversions.ToInteger(cComboItem2.Value);
						cMinimumStock2.Item = array;
						cMinimumStock2.Save();
						Cursor = Cursors.Default;
						Interaction.MsgBox("Minimum Stok berhasil disimpan", MsgBoxStyle.Information);
						goto end_IL_0001;
					}
					case 334:
						num = -1;
						switch (num2)
						{
						case 2:
							Cursor = Cursors.Default;
							Module1.SaveError(Information.Err(), "frmSettingMinimumStock", "btnSaveClose_click", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 334;
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
