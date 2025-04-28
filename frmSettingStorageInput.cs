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
public class frmSettingStorageInput : Form
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

	[field: AccessedThroughProperty("cboMarketingStorageType")]
	internal virtual ComboBox cboMarketingStorageType
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
		this.cboMarketingStorageType = new System.Windows.Forms.ComboBox();
		base.SuspendLayout();
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(10, 70);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(44, 13);
		this.Label2.TabIndex = 143;
		this.Label2.Text = "Cabang";
		this.cboBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboBranch.FormattingEnabled = true;
		this.cboBranch.Location = new System.Drawing.Point(75, 67);
		this.cboBranch.Name = "cboBranch";
		this.cboBranch.Size = new System.Drawing.Size(145, 21);
		this.cboBranch.TabIndex = 2;
		this.btnSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSaveClose.Location = new System.Drawing.Point(75, 123);
		this.btnSaveClose.Name = "btnSaveClose";
		this.btnSaveClose.Size = new System.Drawing.Size(93, 24);
		this.btnSaveClose.TabIndex = 10;
		this.btnSaveClose.Text = "Simpan && &Tutup";
		this.btnSaveClose.UseVisualStyleBackColor = true;
		this.Label9.AutoSize = true;
		this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label9.Location = new System.Drawing.Point(10, 98);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(28, 13);
		this.Label9.TabIndex = 147;
		this.Label9.Text = "Aktif";
		this.cboActive.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboActive.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboActive.FormattingEnabled = true;
		this.cboActive.Location = new System.Drawing.Point(75, 95);
		this.cboActive.Name = "cboActive";
		this.cboActive.Size = new System.Drawing.Size(145, 21);
		this.cboActive.TabIndex = 3;
		this.txtName.Location = new System.Drawing.Point(75, 12);
		this.txtName.Name = "txtName";
		this.txtName.Size = new System.Drawing.Size(145, 20);
		this.txtName.TabIndex = 0;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(10, 15);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(45, 13);
		this.Label1.TabIndex = 145;
		this.Label1.Text = "Gudang";
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(10, 43);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(31, 13);
		this.Label3.TabIndex = 149;
		this.Label3.Text = "Jenis";
		this.cboMarketingStorageType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboMarketingStorageType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboMarketingStorageType.FormattingEnabled = true;
		this.cboMarketingStorageType.Location = new System.Drawing.Point(75, 40);
		this.cboMarketingStorageType.Name = "cboMarketingStorageType";
		this.cboMarketingStorageType.Size = new System.Drawing.Size(145, 21);
		this.cboMarketingStorageType.TabIndex = 1;
		base.AcceptButton = this.btnSaveClose;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(241, 158);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.cboMarketingStorageType);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.cboBranch);
		base.Controls.Add(this.btnSaveClose);
		base.Controls.Add(this.Label9);
		base.Controls.Add(this.cboActive);
		base.Controls.Add(this.txtName);
		base.Controls.Add(this.Label1);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSettingStorageInput";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Setting - Gudang";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmSettingStorageInput()
	{
		base.KeyDown += frmSettingAreaInput_KeyDown;
		InitializeComponent();
		ComboBox combo = cboBranch;
		cCombo.getBranch(ref combo, Module1.pubGroupId, blnAll: false);
		cboBranch = combo;
		combo = cboMarketingStorageType;
		cCombo.getMarketingStorageType(ref combo);
		cboMarketingStorageType = combo;
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
					cStorage cStorage2 = new cStorage(_currentId);
					txtName.Text = cStorage2.Name;
					ComboBox cboSource;
					if (cStorage2.IsMarketing == 1)
					{
						cboSource = cboMarketingStorageType;
						Module1.comboBoundValue(ref cboSource, 1.0);
						cboMarketingStorageType = cboSource;
					}
					else if (cStorage2.IsReturn == 1)
					{
						cboSource = cboMarketingStorageType;
						Module1.comboBoundValue(ref cboSource, 2.0);
						cboMarketingStorageType = cboSource;
					}
					else
					{
						cboSource = cboMarketingStorageType;
						Module1.comboBoundValue(ref cboSource, 0.0);
						cboMarketingStorageType = cboSource;
					}
					cboSource = cboBranch;
					Module1.comboBoundValue(ref cboSource, cStorage2.BranchId);
					cboBranch = cboSource;
					cboSource = cboActive;
					Module1.comboBoundValue(ref cboSource, cStorage2.Active);
					cboActive = cboSource;
					goto end_IL_0001;
				}
				case 280:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSettingStorageInput", "LoadData", "");
						_currentId = 0;
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 280;
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
		cComboItem cComboItem3 = (cComboItem)cboMarketingStorageType.SelectedItem;
		cComboItem cComboItem4 = (cComboItem)cboActive.SelectedItem;
		if (Operators.CompareString(txtName.Text, "", TextCompare: false) == 0)
		{
			Interaction.MsgBox("Masukkan kode customer", MsgBoxStyle.Information);
			txtName.Focus();
			return;
		}
		if (cboMarketingStorageType.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih jenis gudang", MsgBoxStyle.Information);
			cboMarketingStorageType.Focus();
			return;
		}
		if ((Conversions.ToDouble(cComboItem3.Value) == 2.0) & (Operators.CompareString(Strings.Left(Strings.UCase(txtName.Text), 2), "BS", TextCompare: false) != 0))
		{
			Interaction.MsgBox("Nama gudang BS harus diawali dengan awalan 'BS'", MsgBoxStyle.Information);
			txtName.Focus();
			return;
		}
		if (cboBranch.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih cabang", MsgBoxStyle.Information);
			cboBranch.Focus();
			return;
		}
		if (cStorage.IsExist(_currentId, Module1.cleanString(txtName.Text)))
		{
			Interaction.MsgBox("Nama gudang sudah pernah digunakan. Masukkan nama lain.", MsgBoxStyle.Information);
			txtName.Focus();
			return;
		}
		if (cboActive.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih aktif/tidak", MsgBoxStyle.Information);
			cboActive.Focus();
			return;
		}
		cStorage cStorage2 = new cStorage(0);
		cStorage2.Id = Conversions.ToInteger(CurrentId);
		cStorage2.Name = txtName.Text;
		if (Conversions.ToDouble(cComboItem3.Value) == 1.0)
		{
			cStorage2.IsMarketing = 1;
		}
		else if (Conversions.ToDouble(cComboItem3.Value) == 2.0)
		{
			cStorage2.IsReturn = 1;
		}
		cStorage2.BranchId = Conversions.ToInteger(cComboItem2.Value);
		cStorage2.Active = Conversions.ToInteger(cComboItem4.Value);
		cStorage2.Save();
		Interaction.MsgBox("Gudang berhasil disimpan", MsgBoxStyle.Information);
		if (!MyProject.Forms.frmSettingStorageList.chkManual.Checked)
		{
			MyProject.Forms.frmSettingStorageList.getList();
		}
		Close();
	}
}
