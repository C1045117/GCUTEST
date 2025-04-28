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
public class frmSettingAreaInput : Form
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
		this.Label2 = new System.Windows.Forms.Label();
		this.cboBranch = new System.Windows.Forms.ComboBox();
		base.SuspendLayout();
		this.btnSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSaveClose.Location = new System.Drawing.Point(75, 93);
		this.btnSaveClose.Name = "btnSaveClose";
		this.btnSaveClose.Size = new System.Drawing.Size(93, 24);
		this.btnSaveClose.TabIndex = 139;
		this.btnSaveClose.Text = "Simpan && &Tutup";
		this.btnSaveClose.UseVisualStyleBackColor = true;
		this.Label9.AutoSize = true;
		this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label9.Location = new System.Drawing.Point(10, 69);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(28, 13);
		this.Label9.TabIndex = 140;
		this.Label9.Text = "Aktif";
		this.cboActive.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboActive.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboActive.FormattingEnabled = true;
		this.cboActive.Location = new System.Drawing.Point(75, 66);
		this.cboActive.Name = "cboActive";
		this.cboActive.Size = new System.Drawing.Size(125, 21);
		this.cboActive.TabIndex = 2;
		this.txtName.Location = new System.Drawing.Point(75, 12);
		this.txtName.Name = "txtName";
		this.txtName.Size = new System.Drawing.Size(125, 20);
		this.txtName.TabIndex = 0;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(10, 15);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(45, 13);
		this.Label1.TabIndex = 138;
		this.Label1.Text = "Wilayah";
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(10, 41);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(44, 13);
		this.Label2.TabIndex = 1;
		this.Label2.Text = "Cabang";
		this.cboBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboBranch.FormattingEnabled = true;
		this.cboBranch.Location = new System.Drawing.Point(75, 38);
		this.cboBranch.Name = "cboBranch";
		this.cboBranch.Size = new System.Drawing.Size(125, 21);
		this.cboBranch.TabIndex = 1;
		base.AcceptButton = this.btnSaveClose;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(218, 129);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.cboBranch);
		base.Controls.Add(this.btnSaveClose);
		base.Controls.Add(this.Label9);
		base.Controls.Add(this.cboActive);
		base.Controls.Add(this.txtName);
		base.Controls.Add(this.Label1);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSettingAreaInput";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Setting - Wilayah";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmSettingAreaInput()
	{
		base.KeyDown += frmSettingAreaInput_KeyDown;
		InitializeComponent();
		ComboBox combo = cboBranch;
		cCombo.getBranch(ref combo, Module1.pubGroupId, blnAll: false);
		cboBranch = combo;
		combo = cboActive;
		cCombo.getYesNo(ref combo, All: false);
		cboActive = combo;
		cboActive.SelectedIndex = 0;
	}

	private void frmSettingAreaInput_KeyDown(object sender, KeyEventArgs e)
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
					cArea cArea2 = new cArea(_currentId);
					txtName.Text = cArea2.Name;
					ComboBox cboSource = cboBranch;
					Module1.comboBoundValue(ref cboSource, cArea2.BranchId);
					cboBranch = cboSource;
					cboSource = cboActive;
					Module1.comboBoundValue(ref cboSource, cArea2.Active);
					cboActive = cboSource;
					goto end_IL_0001;
				}
				case 138:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSettingAreaInput", "LoadData", "");
						_currentId = 0;
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 138;
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
			Interaction.MsgBox("Masukkan nama wilayah", MsgBoxStyle.Information);
			txtName.Focus();
			return;
		}
		if (cboBranch.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih cabang", MsgBoxStyle.Information);
			cboBranch.Focus();
			return;
		}
		if (cArea.IsExist(_currentId, Conversions.ToInteger(cComboItem2.Value), Module1.cleanString(txtName.Text)))
		{
			Interaction.MsgBox("Nama wilayah sudah pernah digunakan di cabang " + cboBranch.Text + ". Masukkan nama lain.", MsgBoxStyle.Information);
			txtName.Focus();
			return;
		}
		if (cboActive.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih aktif/tidak", MsgBoxStyle.Information);
			cboActive.Focus();
			return;
		}
		cArea cArea2 = new cArea(0);
		cArea2.Id = Conversions.ToInteger(CurrentId);
		cArea2.Name = txtName.Text;
		cArea2.BranchId = Conversions.ToInteger(cComboItem2.Value);
		cArea2.Active = Conversions.ToInteger(cComboItem3.Value);
		cArea2.Save();
		Interaction.MsgBox("Wilayah berhasil disimpan", MsgBoxStyle.Information);
		if (!MyProject.Forms.frmSettingAreaList.chkManual.Checked)
		{
			MyProject.Forms.frmSettingAreaList.getList();
		}
		Close();
	}
}
