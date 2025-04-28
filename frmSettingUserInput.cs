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
public class frmSettingUserInput : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSaveClose")]
	private Button _btnSaveClose;

	private int _currentId;

	[field: AccessedThroughProperty("txtPassword")]
	internal virtual TextBox txtPassword
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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

	[field: AccessedThroughProperty("Label26")]
	internal virtual Label Label26
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboGroup")]
	internal virtual ComboBox cboGroup
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("txtPassword2")]
	internal virtual TextBox txtPassword2
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
		this.txtPassword = new System.Windows.Forms.TextBox();
		this.txtName = new System.Windows.Forms.TextBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label26 = new System.Windows.Forms.Label();
		this.cboGroup = new System.Windows.Forms.ComboBox();
		this.Label9 = new System.Windows.Forms.Label();
		this.cboActive = new System.Windows.Forms.ComboBox();
		this.btnSaveClose = new System.Windows.Forms.Button();
		this.txtPassword2 = new System.Windows.Forms.TextBox();
		this.Label3 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.txtPassword.Location = new System.Drawing.Point(116, 38);
		this.txtPassword.Name = "txtPassword";
		this.txtPassword.PasswordChar = '*';
		this.txtPassword.Size = new System.Drawing.Size(139, 20);
		this.txtPassword.TabIndex = 1;
		this.txtName.Location = new System.Drawing.Point(116, 12);
		this.txtName.Name = "txtName";
		this.txtName.Size = new System.Drawing.Size(139, 20);
		this.txtName.TabIndex = 0;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(10, 41);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(53, 13);
		this.Label2.TabIndex = 10;
		this.Label2.Text = "Password";
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(10, 15);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(60, 13);
		this.Label1.TabIndex = 9;
		this.Label1.Text = "User Name";
		this.Label26.AutoSize = true;
		this.Label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label26.Location = new System.Drawing.Point(10, 93);
		this.Label26.Name = "Label26";
		this.Label26.Size = new System.Drawing.Size(30, 13);
		this.Label26.TabIndex = 126;
		this.Label26.Text = "Grup";
		this.cboGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboGroup.FormattingEnabled = true;
		this.cboGroup.Location = new System.Drawing.Point(116, 90);
		this.cboGroup.Name = "cboGroup";
		this.cboGroup.Size = new System.Drawing.Size(139, 21);
		this.cboGroup.TabIndex = 3;
		this.Label9.AutoSize = true;
		this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label9.Location = new System.Drawing.Point(10, 118);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(28, 13);
		this.Label9.TabIndex = 125;
		this.Label9.Text = "Aktif";
		this.cboActive.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cboActive.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cboActive.FormattingEnabled = true;
		this.cboActive.Location = new System.Drawing.Point(116, 118);
		this.cboActive.Name = "cboActive";
		this.cboActive.Size = new System.Drawing.Size(139, 21);
		this.cboActive.TabIndex = 4;
		this.btnSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSaveClose.Location = new System.Drawing.Point(116, 145);
		this.btnSaveClose.Name = "btnSaveClose";
		this.btnSaveClose.Size = new System.Drawing.Size(93, 24);
		this.btnSaveClose.TabIndex = 11;
		this.btnSaveClose.Text = "Simpan && &Tutup";
		this.btnSaveClose.UseVisualStyleBackColor = true;
		this.txtPassword2.Location = new System.Drawing.Point(116, 64);
		this.txtPassword2.Name = "txtPassword2";
		this.txtPassword2.PasswordChar = '*';
		this.txtPassword2.Size = new System.Drawing.Size(139, 20);
		this.txtPassword2.TabIndex = 2;
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(10, 67);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(104, 13);
		this.Label3.TabIndex = 128;
		this.Label3.Text = "Konfirmasi Password";
		base.AcceptButton = this.btnSaveClose;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(265, 179);
		base.Controls.Add(this.txtPassword2);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.btnSaveClose);
		base.Controls.Add(this.Label26);
		base.Controls.Add(this.cboGroup);
		base.Controls.Add(this.Label9);
		base.Controls.Add(this.cboActive);
		base.Controls.Add(this.txtPassword);
		base.Controls.Add(this.txtName);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Label1);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSettingUserInput";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Setting User - Input";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmSettingUserInput()
	{
		base.KeyDown += frmSettingUserInput_KeyDown;
		InitializeComponent();
		ComboBox combo = cboGroup;
		cCombo.getGroup(ref combo);
		cboGroup = combo;
		combo = cboActive;
		cCombo.getYesNo(ref combo, All: false);
		cboActive = combo;
		cboActive.SelectedIndex = 0;
	}

	private void frmSettingUserInput_KeyDown(object sender, KeyEventArgs e)
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
					cUser cUser2 = new cUser(_currentId);
					txtName.Text = cUser2.Name;
					txtPassword.Text = cUser2.Password;
					txtPassword2.Text = cUser2.Password;
					ComboBox cboSource = cboGroup;
					Module1.comboBoundValue(ref cboSource, cUser2.GroupId);
					cboGroup = cboSource;
					cboSource = cboActive;
					Module1.comboBoundValue(ref cboSource, cUser2.Active);
					cboActive = cboSource;
					txtName.Enabled = false;
					goto end_IL_0001;
				}
				case 187:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSettingUserInput", "LoadData", "");
						_currentId = 0;
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 187;
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
		cComboItem cComboItem2 = (cComboItem)cboGroup.SelectedItem;
		cComboItem cComboItem3 = (cComboItem)cboActive.SelectedItem;
		if (Operators.CompareString(txtName.Text, "", TextCompare: false) == 0)
		{
			Interaction.MsgBox("Masukkan user name", MsgBoxStyle.Information);
			txtName.Focus();
			return;
		}
		if (_currentId == 0 && cUser.IsExist(Module1.cleanString(txtName.Text)))
		{
			Interaction.MsgBox("User name sudah pernah digunakan. Masukkan user name lain.", MsgBoxStyle.Information);
			txtName.Focus();
			return;
		}
		if (Operators.CompareString(txtPassword.Text, "", TextCompare: false) == 0)
		{
			Interaction.MsgBox("Masukkan password", MsgBoxStyle.Information);
			txtPassword.Focus();
			return;
		}
		if (Operators.CompareString(txtPassword2.Text, "", TextCompare: false) == 0)
		{
			Interaction.MsgBox("Masukkan konfirmasi password", MsgBoxStyle.Information);
			txtPassword2.Focus();
			return;
		}
		if (Operators.CompareString(txtPassword.Text, txtPassword2.Text, TextCompare: false) != 0)
		{
			Interaction.MsgBox("Konfirmasi password tidak sesuai", MsgBoxStyle.Information);
			txtPassword2.Focus();
			return;
		}
		if (cboGroup.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih grup", MsgBoxStyle.Information);
			cboGroup.Focus();
			return;
		}
		if (cboActive.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih aktif/tidak", MsgBoxStyle.Information);
			cboActive.Focus();
			return;
		}
		cUser cUser2 = new cUser(0);
		cUser2.Id = Conversions.ToInteger(CurrentId);
		cUser2.Name = txtName.Text;
		cUser2.Password = txtPassword.Text;
		cUser2.GroupId = Conversions.ToInteger(cComboItem2.Value);
		cUser2.Active = Conversions.ToInteger(cComboItem3.Value);
		cUser2.Save();
		Interaction.MsgBox("User berhasil disimpan", MsgBoxStyle.Information);
		if (!MyProject.Forms.frmSettingUserList.chkManual.Checked)
		{
			MyProject.Forms.frmSettingUserList.getList();
		}
		Close();
	}
}
