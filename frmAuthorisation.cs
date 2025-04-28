using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GCUv2.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

[DesignerGenerated]
public class frmAuthorisation : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnAuthorise")]
	private Button _btnAuthorise;

	private string _customerName;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnAuthorise
	{
		[CompilerGenerated]
		get
		{
			return _btnAuthorise;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnAuthorise_Click;
			Button button = _btnAuthorise;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnAuthorise = value;
			button = _btnAuthorise;
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

	[field: AccessedThroughProperty("txtUserName")]
	internal virtual TextBox txtUserName
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.btnAuthorise = new System.Windows.Forms.Button();
		this.txtPassword = new System.Windows.Forms.TextBox();
		this.txtUserName = new System.Windows.Forms.TextBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.GroupBox1.SuspendLayout();
		base.SuspendLayout();
		this.GroupBox1.Controls.Add(this.btnAuthorise);
		this.GroupBox1.Controls.Add(this.txtPassword);
		this.GroupBox1.Controls.Add(this.txtUserName);
		this.GroupBox1.Controls.Add(this.Label2);
		this.GroupBox1.Controls.Add(this.Label1);
		this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.GroupBox1.Location = new System.Drawing.Point(5, 57);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(270, 102);
		this.GroupBox1.TabIndex = 28;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Pemberi Autorisasi";
		this.btnAuthorise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAuthorise.Location = new System.Drawing.Point(104, 71);
		this.btnAuthorise.Name = "btnAuthorise";
		this.btnAuthorise.Size = new System.Drawing.Size(71, 21);
		this.btnAuthorise.TabIndex = 2;
		this.btnAuthorise.Text = "Autorisasi";
		this.btnAuthorise.UseVisualStyleBackColor = true;
		this.txtPassword.Location = new System.Drawing.Point(104, 45);
		this.txtPassword.Name = "txtPassword";
		this.txtPassword.PasswordChar = '*';
		this.txtPassword.Size = new System.Drawing.Size(139, 20);
		this.txtPassword.TabIndex = 1;
		this.txtUserName.Location = new System.Drawing.Point(104, 19);
		this.txtUserName.Name = "txtUserName";
		this.txtUserName.Size = new System.Drawing.Size(139, 20);
		this.txtUserName.TabIndex = 0;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(6, 48);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(53, 13);
		this.Label2.TabIndex = 29;
		this.Label2.Text = "Password";
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(6, 22);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(60, 13);
		this.Label1.TabIndex = 28;
		this.Label1.Text = "User Name";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(13, 9);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(142, 13);
		this.Label3.TabIndex = 29;
		this.Label3.Text = "Batas piutang telah tercapai.";
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(12, 32);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(268, 13);
		this.Label4.TabIndex = 30;
		this.Label4.Text = "Penjualan Kredit hanya bisa dibuat setelah di-autorisasi.";
		base.AcceptButton = this.btnAuthorise;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(283, 168);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.GroupBox1);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmAuthorisation";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Autorisasi Penjualan";
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmAuthorisation(string CustomerName)
	{
		base.KeyDown += frmAuthorisation_KeyDown;
		InitializeComponent();
		_customerName = CustomerName;
		txtUserName.Text = "";
		txtPassword.Text = "";
	}

	private void frmAuthorisation_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void btnAuthorise_Click(object sender, EventArgs e)
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
					if (Operators.CompareString(txtUserName.Text, "", TextCompare: false) == 0)
					{
						Interaction.MsgBox("Masukkan user name.", MsgBoxStyle.Information);
						txtUserName.Focus();
						goto end_IL_0001;
					}
					if (Operators.CompareString(txtPassword.Text, "", TextCompare: false) == 0)
					{
						Interaction.MsgBox("Masukkan password.", MsgBoxStyle.Information);
						txtPassword.Focus();
						goto end_IL_0001;
					}
					DataTable dataTable = cUser.Login(txtUserName.Text, txtPassword.Text);
					if (dataTable.Rows.Count > 0)
					{
						if (cUser.GetUserPermission(txtUserName.Text, "noCreditLimit") == 1)
						{
							cHistory cHistory2 = new cHistory();
							cHistory2.Content = "";
							cHistory2.Description = " diberi autorisasi oleh " + txtUserName.Text + " untuk membuat Faktur Kredit customer " + _customerName;
							cHistory2.UserId = Module1.pubUserId;
							cHistory2.UserLogin = Module1.pubLogin;
							cHistory2.fKeyId = 0.0;
							cHistory2.HistoryType = 18;
							cHistory2.Save();
							MyProject.Forms.frmSalesInvoice.Authorised = true;
							MyProject.Forms.frmSalesInvoice.cboInvoiceCode.SelectedIndex = 1;
							Close();
						}
						else
						{
							Interaction.MsgBox("User " + txtUserName.Text + " tidak memiliki hak untuk memberi autorisasi.");
						}
					}
					else
					{
						Interaction.MsgBox("User Name/Password yang anda masukkan salah.", MsgBoxStyle.Information);
					}
					goto end_IL_0001;
				}
				case 472:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmAuthorisation", "btnAuthorise_Click", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 472;
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
}
