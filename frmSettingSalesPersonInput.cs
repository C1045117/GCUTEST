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
public class frmSettingSalesPersonInput : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSaveClose")]
	private Button _btnSaveClose;

	private int _currentId;

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkCollector")]
	internal virtual CheckBox chkCollector
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkDonator")]
	internal virtual CheckBox chkDonator
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
		this.cboBranch = new System.Windows.Forms.ComboBox();
		this.btnSaveClose = new System.Windows.Forms.Button();
		this.Label9 = new System.Windows.Forms.Label();
		this.cboActive = new System.Windows.Forms.ComboBox();
		this.txtName = new System.Windows.Forms.TextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.chkCollector = new System.Windows.Forms.CheckBox();
		this.chkDonator = new System.Windows.Forms.CheckBox();
		this.Label4 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(10, 93);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(44, 13);
		this.Label2.TabIndex = 143;
		this.Label2.Text = "Cabang";
		this.cboBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboBranch.FormattingEnabled = true;
		this.cboBranch.Location = new System.Drawing.Point(75, 90);
		this.cboBranch.Name = "cboBranch";
		this.cboBranch.Size = new System.Drawing.Size(125, 21);
		this.cboBranch.TabIndex = 3;
		this.btnSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSaveClose.Location = new System.Drawing.Point(75, 145);
		this.btnSaveClose.Name = "btnSaveClose";
		this.btnSaveClose.Size = new System.Drawing.Size(93, 24);
		this.btnSaveClose.TabIndex = 5;
		this.btnSaveClose.Text = "Simpan && &Tutup";
		this.btnSaveClose.UseVisualStyleBackColor = true;
		this.Label9.AutoSize = true;
		this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label9.Location = new System.Drawing.Point(10, 121);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(28, 13);
		this.Label9.TabIndex = 147;
		this.Label9.Text = "Aktif";
		this.cboActive.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboActive.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboActive.FormattingEnabled = true;
		this.cboActive.Location = new System.Drawing.Point(75, 118);
		this.cboActive.Name = "cboActive";
		this.cboActive.Size = new System.Drawing.Size(125, 21);
		this.cboActive.TabIndex = 4;
		this.txtName.Location = new System.Drawing.Point(75, 41);
		this.txtName.Name = "txtName";
		this.txtName.Size = new System.Drawing.Size(125, 20);
		this.txtName.TabIndex = 0;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(10, 44);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(64, 13);
		this.Label1.TabIndex = 145;
		this.Label1.Text = "Nama Sales";
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(10, 67);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(28, 13);
		this.Label3.TabIndex = 148;
		this.Label3.Text = "Tipe";
		this.chkCollector.AutoSize = true;
		this.chkCollector.Location = new System.Drawing.Point(75, 67);
		this.chkCollector.Name = "chkCollector";
		this.chkCollector.Size = new System.Drawing.Size(65, 17);
		this.chkCollector.TabIndex = 1;
		this.chkCollector.Text = "Kolektor";
		this.chkCollector.UseVisualStyleBackColor = true;
		this.chkDonator.AutoSize = true;
		this.chkDonator.Location = new System.Drawing.Point(146, 67);
		this.chkDonator.Name = "chkDonator";
		this.chkDonator.Size = new System.Drawing.Size(83, 17);
		this.chkDonator.TabIndex = 2;
		this.chkDonator.Text = "Sumbangan";
		this.chkDonator.UseVisualStyleBackColor = true;
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(10, 9);
		this.Label4.MaximumSize = new System.Drawing.Size(220, 100);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(217, 26);
		this.Label4.TabIndex = 149;
		this.Label4.Text = "Catatan: Opsi Sumbangan hanya bisa dipilih saat membuat Sales baru";
		base.AcceptButton = this.btnSaveClose;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(239, 178);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.chkDonator);
		base.Controls.Add(this.chkCollector);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.cboBranch);
		base.Controls.Add(this.btnSaveClose);
		base.Controls.Add(this.Label9);
		base.Controls.Add(this.cboActive);
		base.Controls.Add(this.txtName);
		base.Controls.Add(this.Label1);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSettingSalesPersonInput";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Setting - Sales";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmSettingSalesPersonInput()
	{
		base.KeyDown += frmSettingSalesPersonInput_KeyDown;
		InitializeComponent();
		ComboBox combo = cboBranch;
		cCombo.getBranch(ref combo, Module1.pubGroupId, blnAll: false);
		cboBranch = combo;
		combo = cboActive;
		cCombo.getYesNo(ref combo, All: false);
		cboActive = combo;
		cboActive.SelectedIndex = 0;
	}

	private void frmSettingSalesPersonInput_KeyDown(object sender, KeyEventArgs e)
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
					cSalesPerson cSalesPerson2 = new cSalesPerson(_currentId);
					txtName.Text = cSalesPerson2.Name;
					chkCollector.Checked = Conversions.ToBoolean(Interaction.IIf(cSalesPerson2.IsCollector == 1, true, false));
					chkDonator.Checked = Conversions.ToBoolean(Interaction.IIf(cSalesPerson2.IsDonator == 1, true, false));
					ComboBox cboSource = cboBranch;
					Module1.comboBoundValue(ref cboSource, cSalesPerson2.BranchId);
					cboBranch = cboSource;
					cboSource = cboActive;
					Module1.comboBoundValue(ref cboSource, cSalesPerson2.Active);
					cboActive = cboSource;
					chkDonator.Enabled = false;
					goto end_IL_0001;
				}
				case 237:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSettingSalesPersonInput", "LoadData", "");
						_currentId = 0;
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

	public void prepareForm()
	{
		_currentId = 0;
	}

	private void btnSaveClose_Click(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboBranch.SelectedItem;
		cComboItem cComboItem3 = (cComboItem)cboActive.SelectedItem;
		if (Operators.CompareString(txtName.Text, "", TextCompare: false) == 0)
		{
			Interaction.MsgBox("Masukkan nama sales", MsgBoxStyle.Information);
			txtName.Focus();
			return;
		}
		if (cboBranch.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih cabang", MsgBoxStyle.Information);
			cboBranch.Focus();
			return;
		}
		if (cSalesPerson.IsExist(_currentId, Conversions.ToInteger(cComboItem2.Value), Module1.cleanString(txtName.Text)))
		{
			Interaction.MsgBox("Nama sales sudah pernah digunakan di cabang " + cboBranch.Text + ". Masukkan nama lain.", MsgBoxStyle.Information);
			txtName.Focus();
			return;
		}
		if (cboActive.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih aktif/tidak", MsgBoxStyle.Information);
			cboActive.Focus();
			return;
		}
		cSalesPerson cSalesPerson2 = new cSalesPerson(0);
		cSalesPerson2.Id = Conversions.ToInteger(CurrentId);
		cSalesPerson2.Name = txtName.Text;
		cSalesPerson2.IsCollector = Conversions.ToInteger(Interaction.IIf(chkCollector.Checked, 1, 0));
		cSalesPerson2.IsDonator = Conversions.ToInteger(Interaction.IIf(chkDonator.Checked, 1, 0));
		cSalesPerson2.BranchId = Conversions.ToInteger(cComboItem2.Value);
		cSalesPerson2.Active = Conversions.ToInteger(cComboItem3.Value);
		cSalesPerson2.save();
		Interaction.MsgBox("Sales berhasil disimpan", MsgBoxStyle.Information);
		if (!MyProject.Forms.frmSettingSalesPersonList.chkManual.Checked)
		{
			MyProject.Forms.frmSettingSalesPersonList.getList();
		}
		Close();
	}
}
