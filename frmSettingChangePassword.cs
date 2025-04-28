using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

[DesignerGenerated]
public class frmSettingChangePassword : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSaveClose")]
	private Button _btnSaveClose;

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

	[field: AccessedThroughProperty("txtPassword")]
	internal virtual TextBox txtPassword
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

	[field: AccessedThroughProperty("txtOldPassword")]
	internal virtual TextBox txtOldPassword
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

	public frmSettingChangePassword()
	{
		base.KeyDown += frmSettingChangePassword_KeyDown;
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
		this.txtPassword2 = new System.Windows.Forms.TextBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.btnSaveClose = new System.Windows.Forms.Button();
		this.txtPassword = new System.Windows.Forms.TextBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.txtOldPassword = new System.Windows.Forms.TextBox();
		this.Label1 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.txtPassword2.Location = new System.Drawing.Point(142, 64);
		this.txtPassword2.MaxLength = 20;
		this.txtPassword2.Name = "txtPassword2";
		this.txtPassword2.PasswordChar = '*';
		this.txtPassword2.Size = new System.Drawing.Size(139, 20);
		this.txtPassword2.TabIndex = 2;
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(10, 67);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(129, 13);
		this.Label3.TabIndex = 137;
		this.Label3.Text = "Konfirmasi Password Baru";
		this.btnSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSaveClose.Location = new System.Drawing.Point(142, 90);
		this.btnSaveClose.Name = "btnSaveClose";
		this.btnSaveClose.Size = new System.Drawing.Size(93, 24);
		this.btnSaveClose.TabIndex = 3;
		this.btnSaveClose.Text = "Simpan && &Tutup";
		this.btnSaveClose.UseVisualStyleBackColor = true;
		this.txtPassword.Location = new System.Drawing.Point(142, 38);
		this.txtPassword.MaxLength = 20;
		this.txtPassword.Name = "txtPassword";
		this.txtPassword.PasswordChar = '*';
		this.txtPassword.Size = new System.Drawing.Size(139, 20);
		this.txtPassword.TabIndex = 1;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(10, 41);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(78, 13);
		this.Label2.TabIndex = 133;
		this.Label2.Text = "Password Baru";
		this.txtOldPassword.Location = new System.Drawing.Point(142, 12);
		this.txtOldPassword.MaxLength = 20;
		this.txtOldPassword.Name = "txtOldPassword";
		this.txtOldPassword.PasswordChar = '*';
		this.txtOldPassword.Size = new System.Drawing.Size(139, 20);
		this.txtOldPassword.TabIndex = 0;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(10, 15);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(82, 13);
		this.Label1.TabIndex = 139;
		this.Label1.Text = "Password Lama";
		base.AcceptButton = this.btnSaveClose;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(295, 127);
		base.Controls.Add(this.txtOldPassword);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.txtPassword2);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.btnSaveClose);
		base.Controls.Add(this.txtPassword);
		base.Controls.Add(this.Label2);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSettingChangePassword";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Ganti Password";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void frmSettingChangePassword_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void btnSaveClose_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(txtOldPassword.Text, "", TextCompare: false) == 0)
		{
			Interaction.MsgBox("Masukkan password lama.", MsgBoxStyle.Information);
			txtOldPassword.Focus();
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
		cUser cUser2 = new cUser(Module1.pubUserId);
		if (Operators.CompareString(txtOldPassword.Text, cUser2.Password, TextCompare: false) != 0)
		{
			Interaction.MsgBox("Password lama yang anda masukkan salah.", MsgBoxStyle.Information);
			txtOldPassword.Focus();
			return;
		}
		cUser2.Password = txtPassword.Text;
		cUser2.Save();
		cHistory cHistory2 = new cHistory();
		cHistory2.Content = "Ganti password dari '" + txtOldPassword.Text + "' ke '" + txtPassword.Text + "'";
		cHistory2.Description = " mengganti password.";
		cHistory2.UserId = Module1.pubUserId;
		cHistory2.UserLogin = Module1.pubLogin;
		cHistory2.HistoryType = 5;
		cHistory2.Save();
		Interaction.MsgBox("Password berhasil diganti.", MsgBoxStyle.Information);
		Close();
	}
}
