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
public class frmSettingItemCategoryInput : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSave")]
	private Button _btnSave;

	private int _currentId;

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

	[field: AccessedThroughProperty("cboActive")]
	internal virtual ComboBox cboActive
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
		this.btnSave = new System.Windows.Forms.Button();
		this.txtName = new System.Windows.Forms.TextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.cboActive = new System.Windows.Forms.ComboBox();
		base.SuspendLayout();
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(60, 65);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(98, 24);
		this.btnSave.TabIndex = 2;
		this.btnSave.Text = "Simpan && Tutup";
		this.btnSave.UseVisualStyleBackColor = true;
		this.txtName.Location = new System.Drawing.Point(60, 12);
		this.txtName.Name = "txtName";
		this.txtName.Size = new System.Drawing.Size(177, 20);
		this.txtName.TabIndex = 0;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(12, 15);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(46, 13);
		this.Label1.TabIndex = 9;
		this.Label1.Text = "Kategori";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(12, 41);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(28, 13);
		this.Label2.TabIndex = 12;
		this.Label2.Text = "Aktif";
		this.cboActive.FormattingEnabled = true;
		this.cboActive.Location = new System.Drawing.Point(60, 38);
		this.cboActive.Name = "cboActive";
		this.cboActive.Size = new System.Drawing.Size(84, 21);
		this.cboActive.TabIndex = 1;
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(253, 103);
		base.Controls.Add(this.cboActive);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.txtName);
		base.Controls.Add(this.Label1);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "frmSettingItemCategoryInput";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Setting - Kategori Barang";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmSettingItemCategoryInput()
	{
		base.KeyDown += frmSetItemCategoryInput_KeyDown;
		InitializeComponent();
		ComboBox combo = cboActive;
		cCombo.getYesNo(ref combo, All: false);
		cboActive = combo;
		cboActive.SelectedIndex = 0;
	}

	private void frmSetItemCategoryInput_KeyDown(object sender, KeyEventArgs e)
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
					cItemCategory cItemCategory2 = new cItemCategory(_currentId);
					txtName.Text = cItemCategory2.Name;
					ComboBox cboSource = cboActive;
					Module1.comboBoundValue(ref cboSource, cItemCategory2.Active);
					cboActive = cboSource;
					goto end_IL_0001;
				}
				case 101:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSettingItemCategoryInput", "loadData", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 101;
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

	private void btnSave_Click(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboActive.SelectedItem;
		if (Operators.CompareString(txtName.Text, "", TextCompare: false) == 0)
		{
			Interaction.MsgBox("Masukkan kategori barang", MsgBoxStyle.Information);
			txtName.Focus();
			return;
		}
		if (cboActive.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih aktif/tidak", MsgBoxStyle.Information);
			cboActive.Focus();
			return;
		}
		cItemCategory cItemCategory2 = new cItemCategory(0);
		cItemCategory2.Id = Conversions.ToInteger(CurrentId);
		cItemCategory2.Name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtName.Text);
		cItemCategory2.Active = Conversions.ToInteger(cComboItem2.Value);
		cItemCategory2.Save();
		Interaction.MsgBox("Kategori Barang berhasil disimpan", MsgBoxStyle.Information);
		MyProject.Forms.frmSettingItemCategoryList.getItemCategory();
		Close();
	}
}
