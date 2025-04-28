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
public class frmSettingDiscountInput : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboType")]
	private ComboBox _cboType;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSaveClose")]
	private Button _btnSaveClose;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvList")]
	private DataGridView _dgvList;

	private int _currentId;

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox cboType
	{
		[CompilerGenerated]
		get
		{
			return _cboType;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cboType_SelectedIndexChanged;
			ComboBox comboBox = _cboType;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_cboType = value;
			comboBox = _cboType;
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

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPercentage")]
	internal virtual FilteredTextBox txtPercentage
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

	[field: AccessedThroughProperty("GroupBox2")]
	internal virtual GroupBox GroupBox2
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
			DataGridViewCellFormattingEventHandler value3 = dgvList_CellFormatting;
			DataGridViewCellValidatingEventHandler value4 = dgvList_CellValidating;
			DataGridView dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.KeyDown -= value2;
				dataGridView.CellFormatting -= value3;
				dataGridView.CellValidating -= value4;
			}
			_dgvList = value;
			dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.KeyDown += value2;
				dataGridView.CellFormatting += value3;
				dataGridView.CellValidating += value4;
			}
		}
	}

	[field: AccessedThroughProperty("chkCanBeOverwritten")]
	internal virtual CheckBox chkCanBeOverwritten
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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
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
		this.Label2 = new System.Windows.Forms.Label();
		this.cboType = new System.Windows.Forms.ComboBox();
		this.btnSaveClose = new System.Windows.Forms.Button();
		this.Label9 = new System.Windows.Forms.Label();
		this.cboActive = new System.Windows.Forms.ComboBox();
		this.txtName = new System.Windows.Forms.TextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.txtPercentage = new GCUv2.FilteredTextBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.dgvList = new System.Windows.Forms.DataGridView();
		this.chkCanBeOverwritten = new System.Windows.Forms.CheckBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.GroupBox1.SuspendLayout();
		this.GroupBox2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		base.SuspendLayout();
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(15, 41);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(28, 13);
		this.Label2.TabIndex = 143;
		this.Label2.Text = "Tipe";
		this.cboType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboType.FormattingEnabled = true;
		this.cboType.Location = new System.Drawing.Point(80, 38);
		this.cboType.Name = "cboType";
		this.cboType.Size = new System.Drawing.Size(125, 21);
		this.cboType.TabIndex = 1;
		this.btnSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSaveClose.Location = new System.Drawing.Point(179, 362);
		this.btnSaveClose.Name = "btnSaveClose";
		this.btnSaveClose.Size = new System.Drawing.Size(93, 24);
		this.btnSaveClose.TabIndex = 6;
		this.btnSaveClose.Text = "Simpan && &Tutup";
		this.btnSaveClose.UseVisualStyleBackColor = true;
		this.Label9.AutoSize = true;
		this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label9.Location = new System.Drawing.Point(15, 68);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(28, 13);
		this.Label9.TabIndex = 147;
		this.Label9.Text = "Aktif";
		this.cboActive.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboActive.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboActive.FormattingEnabled = true;
		this.cboActive.Location = new System.Drawing.Point(80, 65);
		this.cboActive.Name = "cboActive";
		this.cboActive.Size = new System.Drawing.Size(125, 21);
		this.cboActive.TabIndex = 3;
		this.txtName.Location = new System.Drawing.Point(80, 12);
		this.txtName.Name = "txtName";
		this.txtName.Size = new System.Drawing.Size(125, 20);
		this.txtName.TabIndex = 0;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(15, 15);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(32, 13);
		this.Label1.TabIndex = 145;
		this.Label1.Text = "Kode";
		this.GroupBox1.Controls.Add(this.Label4);
		this.GroupBox1.Controls.Add(this.txtPercentage);
		this.GroupBox1.Controls.Add(this.Label5);
		this.GroupBox1.Location = new System.Drawing.Point(8, 94);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(264, 89);
		this.GroupBox1.TabIndex = 257;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Persentasi";
		this.txtPercentage.AllowedCharacters = GCUv2.FilteredTextBox.InputType.All;
		this.txtPercentage.DontFormat = false;
		this.txtPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtPercentage.Location = new System.Drawing.Point(72, 19);
		this.txtPercentage.MaximumDigit = 3;
		this.txtPercentage.Name = "txtPercentage";
		this.txtPercentage.Size = new System.Drawing.Size(125, 21);
		this.txtPercentage.TabIndex = 4;
		this.txtPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(7, 22);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(56, 13);
		this.Label5.TabIndex = 257;
		this.Label5.Text = "Persentasi";
		this.GroupBox2.Controls.Add(this.dgvList);
		this.GroupBox2.Location = new System.Drawing.Point(8, 189);
		this.GroupBox2.Name = "GroupBox2";
		this.GroupBox2.Size = new System.Drawing.Size(264, 167);
		this.GroupBox2.TabIndex = 258;
		this.GroupBox2.TabStop = false;
		this.GroupBox2.Text = "Jumlah Barang";
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.Location = new System.Drawing.Point(10, 19);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(248, 133);
		this.dgvList.TabIndex = 5;
		this.chkCanBeOverwritten.AutoSize = true;
		this.chkCanBeOverwritten.Location = new System.Drawing.Point(49, 369);
		this.chkCanBeOverwritten.Name = "chkCanBeOverwritten";
		this.chkCanBeOverwritten.Size = new System.Drawing.Size(180, 17);
		this.chkCanBeOverwritten.TabIndex = 2;
		this.chkCanBeOverwritten.Text = "Nilai diskon bisa diganti di Faktur";
		this.chkCanBeOverwritten.UseVisualStyleBackColor = true;
		this.chkCanBeOverwritten.Visible = false;
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(15, 370);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(28, 13);
		this.Label3.TabIndex = 260;
		this.Label3.Text = "Opsi";
		this.Label3.Visible = false;
		this.Label4.Location = new System.Drawing.Point(7, 49);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(238, 29);
		this.Label4.TabIndex = 258;
		this.Label4.Text = "Angka desimal harus menggunakan TITIK, bukan KOMA.";
		base.AcceptButton = this.btnSaveClose;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(284, 398);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.chkCanBeOverwritten);
		base.Controls.Add(this.GroupBox2);
		base.Controls.Add(this.GroupBox1);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.cboType);
		base.Controls.Add(this.btnSaveClose);
		base.Controls.Add(this.Label9);
		base.Controls.Add(this.cboActive);
		base.Controls.Add(this.txtName);
		base.Controls.Add(this.Label1);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSettingDiscountInput";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Setting Diskon";
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		this.GroupBox2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmSettingDiscountInput()
	{
		base.KeyDown += frmSettingDiscountInput_KeyDown;
		base.Load += frmSettingDiscountInput_Load;
		InitializeComponent();
		ComboBox combo = cboType;
		cCombo.getDiscountType(ref combo);
		cboType = combo;
		combo = cboActive;
		cCombo.getYesNo(ref combo, All: false);
		cboActive = combo;
		txtPercentage.DontFormat = true;
		txtPercentage.AllowedCharacters = FilteredTextBox.InputType.NumeralsAndDotAndPlus;
		cboActive.SelectedIndex = 0;
		formatGrid();
	}

	private void frmSettingDiscountInput_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void formatGrid()
	{
		dgvList.Columns.Add("", "Jml. Awal");
		dgvList.Columns.Add("", "Jml. Akhir");
		dgvList.Columns.Add("", "Diskon");
		dgvList.Columns[0].Width = 80;
		dgvList.Columns[1].Width = 80;
		dgvList.Columns[2].Width = 80;
		dgvList.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.RowHeadersVisible = false;
		dgvList.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvList.AllowUserToResizeRows = false;
		dgvList.AllowUserToDeleteRows = true;
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
					cDiscount cDiscount2 = new cDiscount(_currentId);
					txtName.Text = cDiscount2.Name;
					ComboBox cboSource = cboType;
					Module1.comboBoundValue(ref cboSource, cDiscount2.Type);
					cboType = cboSource;
					cboSource = cboActive;
					Module1.comboBoundValue(ref cboSource, cDiscount2.Active);
					cboActive = cboSource;
					txtPercentage.Text = cDiscount2.Percentage;
					chkCanBeOverwritten.Checked = cDiscount2.CanBeOverwritten != 0;
					dgvList.Rows.Clear();
					cDiscount.DiscountQty[] qty = cDiscount2.Qty;
					for (int i = 0; i < qty.Length; i = checked(i + 1))
					{
						cDiscount.DiscountQty discountQty = qty[i];
						dgvList.Rows.Add(Module1.formatCustomDecimal(Conversions.ToString(discountQty._begin), 2), Module1.formatCustomDecimal(Conversions.ToString(discountQty._end), 2), Module1.formatCustomDecimal(Conversions.ToString(discountQty._value), 2));
					}
					goto end_IL_0001;
				}
				case 325:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSettingDiscountInput", "LoadData", "");
						_currentId = 0;
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 325;
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

	private void dgvList_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Delete && !dgvList.Rows[dgvList.CurrentRow.Index].IsNewRow)
		{
			dgvList.Rows.RemoveAt(dgvList.CurrentRow.Index);
		}
	}

	private void frmSettingDiscountInput_Load(object sender, EventArgs e)
	{
		if (dgvList.Rows.Count > 1)
		{
			dgvList.CurrentRow.Selected = false;
		}
	}

	private void dgvList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
		if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(e.Value)) && dgvList.CurrentRow.Index > 0 && Conversion.Val(RuntimeHelpers.GetObjectValue(e.Value)) > 0.0)
		{
			e.Value = Module1.formatCustomDecimal(Conversions.ToString(e.Value), 2);
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
						Module1.SaveError(Information.Err(), "frmSettingDiscountInput", "dgvList_CellValidating", "");
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

	private void btnSaveClose_Click(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboType.SelectedItem;
		cComboItem cComboItem3 = (cComboItem)cboActive.SelectedItem;
		checked
		{
			if (Operators.CompareString(txtName.Text, "", TextCompare: false) == 0)
			{
				Interaction.MsgBox("Masukkan kode diskon.", MsgBoxStyle.Information);
				txtName.Focus();
			}
			else if (cboType.SelectedIndex == -1)
			{
				Interaction.MsgBox("Pilih tipe diskon.", MsgBoxStyle.Information);
				cboType.Focus();
			}
			else if (cDiscount.IsExist(_currentId, Module1.cleanString(txtName.Text)))
			{
				Interaction.MsgBox("Kode discount sudah pernah digunakan. Masukkan kode lain.", MsgBoxStyle.Information);
				txtName.Focus();
			}
			else if (cboActive.SelectedIndex == -1)
			{
				Interaction.MsgBox("Pilih aktif/tidak", MsgBoxStyle.Information);
				cboActive.Focus();
			}
			else
			{
				if (!Module1.isBeginLessThanEnd(dgvList) || Module1.isAlreadyInGrid(dgvList))
				{
					return;
				}
				cDiscount cDiscount2 = new cDiscount(0);
				cDiscount2.Id = Conversions.ToInteger(CurrentId);
				cDiscount2.Name = txtName.Text;
				cDiscount2.Type = Conversions.ToInteger(cComboItem2.Value);
				cDiscount2.Percentage = txtPercentage.Text;
				cDiscount2.CanBeOverwritten = (chkCanBeOverwritten.Checked ? 1 : 0);
				cDiscount2.Active = Conversions.ToInteger(cComboItem3.Value);
				cDiscount.DiscountQty[] array = null;
				int num = dgvList.Rows.Count - 2;
				int num2 = default(int);
				for (int i = 0; i <= num; i++)
				{
					if ((Conversion.Val(RuntimeHelpers.GetObjectValue(dgvList[0, i].Value)) > 0.0) & (Conversion.Val(RuntimeHelpers.GetObjectValue(dgvList[1, i].Value)) > 0.0) & (Conversion.Val(RuntimeHelpers.GetObjectValue(dgvList[2, i].Value)) > 0.0))
					{
						array = (cDiscount.DiscountQty[])Utils.CopyArray(array, new cDiscount.DiscountQty[num2 + 1]);
						array[num2]._begin = Conversions.ToDouble(dgvList[0, i].Value);
						array[num2]._end = Conversions.ToDouble(dgvList[1, i].Value);
						array[num2]._value = Conversions.ToDouble(dgvList[2, i].Value);
						num2++;
					}
				}
				cDiscount2.Qty = array;
				cDiscount2.Save();
				Interaction.MsgBox("Diskon berhasil disimpan", MsgBoxStyle.Information);
				if (!MyProject.Forms.frmSettingDiscountList.chkManual.Checked)
				{
					MyProject.Forms.frmSettingDiscountList.getList();
				}
				Close();
			}
		}
	}

	private void cboType_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (cboType.SelectedIndex == 0)
		{
			GroupBox1.Enabled = true;
			GroupBox2.Enabled = false;
			dgvList.Rows.Clear();
		}
		else
		{
			GroupBox1.Enabled = false;
			GroupBox2.Enabled = true;
			txtPercentage.Text = "";
		}
	}
}
