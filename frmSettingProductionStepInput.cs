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
public class frmSettingProductionStepInput : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cboStep")]
	private ComboBox _cboStep;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSave")]
	private Button _btnSave;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvItem")]
	private DataGridView _dgvItem;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox cboStep
	{
		[CompilerGenerated]
		get
		{
			return _cboStep;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cboStep_SelectedIndexChanged;
			ComboBox comboBox = _cboStep;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_cboStep = value;
			comboBox = _cboStep;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView dgvItem
	{
		[CompilerGenerated]
		get
		{
			return _dgvItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = dgvItem_KeyDown;
			EventHandler value3 = dgvItem_GotFocus;
			EventHandler value4 = dgvItem_LostFocus;
			DataGridView dataGridView = _dgvItem;
			if (dataGridView != null)
			{
				dataGridView.KeyDown -= value2;
				dataGridView.GotFocus -= value3;
				dataGridView.LostFocus -= value4;
			}
			_dgvItem = value;
			dataGridView = _dgvItem;
			if (dataGridView != null)
			{
				dataGridView.KeyDown += value2;
				dataGridView.GotFocus += value3;
				dataGridView.LostFocus += value4;
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
		this.Label1 = new System.Windows.Forms.Label();
		this.cboStep = new System.Windows.Forms.ComboBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.btnSave = new System.Windows.Forms.Button();
		this.Label3 = new System.Windows.Forms.Label();
		this.dgvItem = new System.Windows.Forms.DataGridView();
		((System.ComponentModel.ISupportInitialize)this.dgvItem).BeginInit();
		base.SuspendLayout();
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(12, 29);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(83, 13);
		this.Label1.TabIndex = 14;
		this.Label1.Text = "Urutan Produksi";
		this.cboStep.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboStep.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboStep.FormattingEnabled = true;
		this.cboStep.Location = new System.Drawing.Point(101, 26);
		this.cboStep.Name = "cboStep";
		this.cboStep.Size = new System.Drawing.Size(148, 21);
		this.cboStep.TabIndex = 0;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(12, 53);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(58, 13);
		this.Label2.TabIndex = 16;
		this.Label2.Text = "Komponen";
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(101, 365);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(72, 28);
		this.btnSave.TabIndex = 2;
		this.btnSave.Text = "Simpan";
		this.btnSave.UseVisualStyleBackColor = true;
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(12, 9);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(375, 13);
		this.Label3.TabIndex = 101;
		this.Label3.Text = "Setting ini digunakan untuk mengkaitkan Komponen dengan Urutan Produksi.";
		this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
		this.dgvItem.Location = new System.Drawing.Point(101, 54);
		this.dgvItem.Name = "dgvItem";
		this.dgvItem.Size = new System.Drawing.Size(224, 305);
		this.dgvItem.TabIndex = 1;
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(395, 405);
		base.Controls.Add(this.dgvItem);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.cboStep);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSettingProductionStepInput";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Setting Urutan Produksi";
		((System.ComponentModel.ISupportInitialize)this.dgvItem).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmSettingProductionStepInput()
	{
		base.KeyDown += frmSettingComponen_KeyDown;
		base.Load += frmSettingComponen_Load;
		InitializeComponent();
		base.MdiParent = MyProject.Forms.frmMenu;
	}

	private void frmSettingComponen_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void frmSettingComponen_Load(object sender, EventArgs e)
	{
		ComboBox combo = cboStep;
		cCombo.getProductionStep(ref combo, Module1.pubGroupId, blnAll: false);
		cboStep = combo;
		FormatGrid();
	}

	private void FormatGrid()
	{
		DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
		dgvItem.Columns.Add("", "ID");
		dgvItem.Columns.Add(dataGridViewCheckBoxColumn);
		dataGridViewCheckBoxColumn.HeaderText = "";
		dataGridViewCheckBoxColumn.Name = "chk";
		dgvItem.Columns.Add("", "Barang");
		dgvItem.Columns[0].Visible = false;
		dgvItem.Columns[2].ReadOnly = true;
		dgvItem.Columns[1].Width = 60;
		dgvItem.Columns[2].Width = 143;
		dgvItem.RowHeadersVisible = false;
		dgvItem.AllowUserToAddRows = false;
		dgvItem.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvItem.AllowUserToResizeRows = false;
		dgvItem.DefaultCellStyle.Font = new Font("Arial", 7f);
	}

	private void dgvItem_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			e.SuppressKeyPress = true;
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			cboStep.Focus();
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			btnSave.Focus();
			e.SuppressKeyPress = true;
		}
	}

	private void dgvItem_GotFocus(object sender, EventArgs e)
	{
		if (dgvItem.RowCount > 0)
		{
			dgvItem.CurrentRow.Selected = true;
		}
	}

	private void dgvItem_LostFocus(object sender, EventArgs e)
	{
		if (dgvItem.RowCount > 0)
		{
			dgvItem.CurrentRow.Selected = false;
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
						cComboItem cComboItem2 = (cComboItem)cboStep.SelectedItem;
						if (cboStep.SelectedIndex == -1)
						{
							Interaction.MsgBox("Pilih urutan produksi", MsgBoxStyle.Information);
							goto end_IL_0001;
						}
						cStep cStep2 = new cStep(Conversions.ToDouble(cComboItem2.Value));
						cStepItem[] array = null;
						int num3 = dgvItem.Rows.Count - 1;
						for (int i = 0; i <= num3; i++)
						{
							if (Operators.ConditionalCompareObjectEqual(dgvItem[1, i].Value, true, TextCompare: false))
							{
								array = (cStepItem[])Utils.CopyArray(array, new cStepItem[num4 + 1]);
								array[num4] = new cStepItem();
								array[num4].ItemId = Conversions.ToInteger(dgvItem[0, i].Value);
								num4++;
							}
						}
						cStep2.Item = array;
						cStep2.save();
						Interaction.MsgBox("Urutan Produksi berhasil disimpan", MsgBoxStyle.Information);
						goto end_IL_0001;
					}
					case 298:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmSettingComponen", "btnSave_click", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 298;
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

	private void cboStep_SelectedIndexChanged(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboStep.SelectedItem;
		cStep cStep2 = new cStep(Conversions.ToDouble(cComboItem2.Value));
		dgvItem.Rows.Clear();
		int num = 0;
		cStepItem[] item = cStep2.Item;
		foreach (cStepItem cStepItem2 in item)
		{
			dgvItem.Rows.Add(cStepItem2.ItemId, Interaction.IIf(0 - (cStepItem2.IsMember ? 1 : 0) == 0, TriState.False, TriState.True), cStepItem2.ItemName);
			num = checked(num + 1);
		}
		if (dgvItem.RowCount > 0)
		{
			dgvItem.CurrentRow.Selected = false;
		}
	}
}
