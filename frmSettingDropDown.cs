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
public class frmSettingDropDown : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSaveClose")]
	private Button _btnSaveClose;

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

	[field: AccessedThroughProperty("txtTOP")]
	internal virtual TextBox txtTOP
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

	[field: AccessedThroughProperty("txtCredit")]
	internal virtual TextBox txtCredit
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
		this.txtTOP = new System.Windows.Forms.TextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.txtCredit = new System.Windows.Forms.TextBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.btnSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSaveClose.Location = new System.Drawing.Point(160, 88);
		this.btnSaveClose.Name = "btnSaveClose";
		this.btnSaveClose.Size = new System.Drawing.Size(93, 24);
		this.btnSaveClose.TabIndex = 2;
		this.btnSaveClose.Text = "Simpan && &Tutup";
		this.btnSaveClose.UseVisualStyleBackColor = true;
		this.txtTOP.Location = new System.Drawing.Point(160, 62);
		this.txtTOP.Name = "txtTOP";
		this.txtTOP.Size = new System.Drawing.Size(93, 20);
		this.txtTOP.TabIndex = 1;
		this.txtTOP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(10, 65);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(142, 13);
		this.Label1.TabIndex = 137;
		this.Label1.Text = "Maksimum Term Of Payment";
		this.txtCredit.Location = new System.Drawing.Point(160, 35);
		this.txtCredit.Name = "txtCredit";
		this.txtCredit.Size = new System.Drawing.Size(93, 20);
		this.txtCredit.TabIndex = 0;
		this.txtCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(10, 38);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(96, 13);
		this.Label2.TabIndex = 140;
		this.Label2.Text = "Maksimum Piutang";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(10, 9);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(269, 13);
		this.Label3.TabIndex = 141;
		this.Label3.Text = "Setting ini mempengaruhi Drop Down di Form Customer.";
		base.AcceptButton = this.btnSaveClose;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(291, 132);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.txtCredit);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.btnSaveClose);
		base.Controls.Add(this.txtTOP);
		base.Controls.Add(this.Label1);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSettingDropDown";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Setting - Batas Piutang & T.O.P";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmSettingDropDown()
	{
		base.KeyDown += frmSettingDropDown_KeyDown;
		InitializeComponent();
		base.MdiParent = MyProject.Forms.frmMenu;
		loadData();
	}

	private void frmSettingDropDown_KeyDown(object sender, KeyEventArgs e)
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
					cSetting cSetting2 = new cSetting("TopLimit");
					txtTOP.Text = cSetting2.Value;
					cSetting2 = new cSetting("PiutangLimit");
					txtCredit.Text = cSetting2.Value;
					goto end_IL_0001;
				}
				case 99:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSettingDropDown", "LoadData", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 99;
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

	private void btnSaveClose_Click(object sender, EventArgs e)
	{
		int maximumCredit = cSetting.GetMaximumCredit();
		int maximumTOP = cSetting.GetMaximumTOP();
		if (Conversion.Val(Module1.unformatNumber(txtCredit.Text)) == 0.0)
		{
			Interaction.MsgBox("Masukkan maksimum batas piutang", MsgBoxStyle.Information);
			txtCredit.Focus();
			return;
		}
		if (!Versioned.IsNumeric(txtCredit.Text))
		{
			Interaction.MsgBox("Masukkan maksimum batas piutang dengan format angka yang benar", MsgBoxStyle.Information);
			txtCredit.Focus();
			return;
		}
		if (Conversions.ToDouble(txtCredit.Text) < (double)maximumCredit)
		{
			Interaction.MsgBox("Batas piutang terlalu kecil. Ada customer yang memiliki batas piutang " + Conversions.ToString(maximumCredit), MsgBoxStyle.Information);
			txtCredit.Focus();
			return;
		}
		if (Conversion.Val(Module1.unformatNumber(txtTOP.Text)) == 0.0)
		{
			Interaction.MsgBox("Masukkan maksimum Term of Payment", MsgBoxStyle.Information);
			txtTOP.Focus();
			return;
		}
		if (!Versioned.IsNumeric(txtTOP.Text))
		{
			Interaction.MsgBox("Masukkan maksimum Term of Payment dengan format angka yang benar", MsgBoxStyle.Information);
			txtCredit.Focus();
			return;
		}
		if (Conversions.ToDouble(txtTOP.Text) < (double)maximumTOP)
		{
			Interaction.MsgBox("Batas Term of Payment terlalu kecil. Ada customer yang memiliki Term of Payment " + Conversions.ToString(maximumTOP), MsgBoxStyle.Information);
			txtCredit.Focus();
			return;
		}
		cSetting cSetting2 = new cSetting("");
		cSetting2.Name = "TopLimit";
		cSetting2.Value = txtTOP.Text;
		cSetting2.Save();
		cSetting2.Name = "PiutangLimit";
		cSetting2.Value = txtCredit.Text;
		cSetting2.Save();
		Interaction.MsgBox("Setting berhasil disimpan", MsgBoxStyle.Information);
		Close();
	}
}
