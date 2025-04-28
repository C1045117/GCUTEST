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
public class frmSettingGroupInput : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSave")]
	private Button _btnSave;

	public int CurrentId;

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

	public frmSettingGroupInput()
	{
		base.KeyDown += frmSettingGroupInput_KeyDown;
		base.Load += frmSettingGroupInput_Load;
		InitializeComponent();
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
		base.SuspendLayout();
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(78, 38);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(92, 24);
		this.btnSave.TabIndex = 11;
		this.btnSave.Text = "Simpan && Tutup";
		this.btnSave.UseVisualStyleBackColor = true;
		this.txtName.Location = new System.Drawing.Point(78, 12);
		this.txtName.Name = "txtName";
		this.txtName.Size = new System.Drawing.Size(141, 20);
		this.txtName.TabIndex = 10;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(11, 15);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(61, 13);
		this.Label1.TabIndex = 9;
		this.Label1.Text = "Nama Grup";
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(252, 74);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.txtName);
		base.Controls.Add(this.Label1);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSettingGroupInput";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Grup Baru";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		string text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtName.Text);
		if (Operators.CompareString(text, "", TextCompare: false) == 0)
		{
			Interaction.MsgBox("Masukkan nama grup.", MsgBoxStyle.Information);
			txtName.Focus();
			return;
		}
		if (cGroup.NameIsUsed(CurrentId, text))
		{
			Interaction.MsgBox("Nama grup sudah dipakai. Masukkan nama lain.", MsgBoxStyle.Information);
			txtName.Focus();
			return;
		}
		cGroup.SaveGroupName(CurrentId, Module1.cleanString(text));
		Interaction.MsgBox("Grup berhasil disimpan.", MsgBoxStyle.Information);
		frmSettingGroup obj = MyProject.Forms.frmSettingGroup;
		ComboBox combo = obj.cboGroup;
		cCombo.getGroup(ref combo);
		obj.cboGroup = combo;
		MyProject.Forms.frmSettingGroup.cboGroup.Text = text;
		Close();
	}

	private void frmSettingGroupInput_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void frmSettingGroupInput_Load(object sender, EventArgs e)
	{
		txtName.SelectionStart = 0;
		txtName.SelectionLength = Strings.Len(txtName.Text);
	}
}
