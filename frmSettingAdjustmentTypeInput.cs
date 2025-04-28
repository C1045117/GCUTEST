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
public class frmSettingAdjustmentTypeInput : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSave")]
	private Button _btnSave;

	public int intAdjtypeId;

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

	public frmSettingAdjustmentTypeInput()
	{
		base.KeyDown += frmSettingAdjustmentTypeEdit_KeyDown;
		base.Load += frmSettingAdjustmentTypeEdit_Load;
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
		this.txtName = new System.Windows.Forms.TextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.btnSave = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.txtName.Location = new System.Drawing.Point(60, 12);
		this.txtName.Name = "txtName";
		this.txtName.Size = new System.Drawing.Size(177, 20);
		this.txtName.TabIndex = 6;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(12, 15);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(28, 13);
		this.Label1.TabIndex = 4;
		this.Label1.Text = "Tipe";
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(60, 47);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(92, 24);
		this.btnSave.TabIndex = 8;
		this.btnSave.Text = "Simpan && Tutup";
		this.btnSave.UseVisualStyleBackColor = true;
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(261, 84);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.txtName);
		base.Controls.Add(this.Label1);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "frmSettingAdjustmentTypeInput";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Setting - Tipe Penyesuaian";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		string text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtName.Text);
		if (Operators.CompareString(text, "", TextCompare: false) == 0)
		{
			Interaction.MsgBox("Masukkan jenis penyesuaian", MsgBoxStyle.Information);
			txtName.Focus();
			return;
		}
		if (intAdjtypeId != 0)
		{
			string strSql = " UPDATE adjustment_types  SET adjtypeName = '" + text + "' WHERE adjtypeId = " + Conversions.ToString(intAdjtypeId);
			Module1.sqlNonQuery(strSql, "data");
		}
		else
		{
			string strSql = " INSERT INTO adjustment_types(adjtypeName) VALUES ('" + text + "')";
			Module1.sqlNonQuery(strSql, "data");
		}
		Interaction.MsgBox("Jenis penyesuaian telah disimpan", MsgBoxStyle.Information);
		MyProject.Forms.frmSettingAdjustmentTypeList.getAdjustmentTypes();
		Close();
	}

	private void frmSettingAdjustmentTypeEdit_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void frmSettingAdjustmentTypeEdit_Load(object sender, EventArgs e)
	{
		txtName.SelectionStart = 0;
		txtName.SelectionLength = Strings.Len(txtName.Text);
	}
}
