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
public class frmSettingGeneral : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSave")]
	private Button _btnSave;

	[field: AccessedThroughProperty("TabControl1")]
	internal virtual TabControl TabControl1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage1")]
	internal virtual TabPage TabPage1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboPurchaseReturn")]
	internal virtual ComboBox cboPurchaseReturn
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

	[field: AccessedThroughProperty("chkReportUseNewGetStockCode")]
	internal virtual CheckBox chkReportUseNewGetStockCode
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkUseNewGetStockCode")]
	internal virtual CheckBox chkUseNewGetStockCode
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
		this.TabControl1 = new System.Windows.Forms.TabControl();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.Label3 = new System.Windows.Forms.Label();
		this.chkReportUseNewGetStockCode = new System.Windows.Forms.CheckBox();
		this.chkUseNewGetStockCode = new System.Windows.Forms.CheckBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.cboPurchaseReturn = new System.Windows.Forms.ComboBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.btnSave = new System.Windows.Forms.Button();
		this.TabControl1.SuspendLayout();
		this.TabPage1.SuspendLayout();
		base.SuspendLayout();
		this.TabControl1.Controls.Add(this.TabPage1);
		this.TabControl1.Location = new System.Drawing.Point(12, 12);
		this.TabControl1.Name = "TabControl1";
		this.TabControl1.SelectedIndex = 0;
		this.TabControl1.Size = new System.Drawing.Size(431, 341);
		this.TabControl1.TabIndex = 0;
		this.TabPage1.Controls.Add(this.Label3);
		this.TabPage1.Controls.Add(this.chkReportUseNewGetStockCode);
		this.TabPage1.Controls.Add(this.chkUseNewGetStockCode);
		this.TabPage1.Controls.Add(this.Label2);
		this.TabPage1.Controls.Add(this.cboPurchaseReturn);
		this.TabPage1.Controls.Add(this.Label1);
		this.TabPage1.Location = new System.Drawing.Point(4, 22);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage1.Size = new System.Drawing.Size(423, 315);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = "Pendukung Transaksi";
		this.TabPage1.UseVisualStyleBackColor = true;
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(6, 53);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(212, 13);
		this.Label3.TabIndex = 5;
		this.Label3.Text = "Kode program untuk pencarian jumlah stok ";
		this.chkReportUseNewGetStockCode.AutoSize = true;
		this.chkReportUseNewGetStockCode.Location = new System.Drawing.Point(9, 92);
		this.chkReportUseNewGetStockCode.Name = "chkReportUseNewGetStockCode";
		this.chkReportUseNewGetStockCode.Size = new System.Drawing.Size(285, 17);
		this.chkReportUseNewGetStockCode.TabIndex = 4;
		this.chkReportUseNewGetStockCode.Text = "Gunakan kode baru untuk mencari stok awal di Report";
		this.chkReportUseNewGetStockCode.UseVisualStyleBackColor = true;
		this.chkUseNewGetStockCode.AutoSize = true;
		this.chkUseNewGetStockCode.Location = new System.Drawing.Point(9, 69);
		this.chkUseNewGetStockCode.Name = "chkUseNewGetStockCode";
		this.chkUseNewGetStockCode.Size = new System.Drawing.Size(306, 17);
		this.chkUseNewGetStockCode.TabIndex = 3;
		this.chkUseNewGetStockCode.Text = "Gunakan kode baru untuk validasi cek stok saat input data";
		this.chkUseNewGetStockCode.UseVisualStyleBackColor = true;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(255, 150);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(0, 13);
		this.Label2.TabIndex = 2;
		this.cboPurchaseReturn.FormattingEnabled = true;
		this.cboPurchaseReturn.Location = new System.Drawing.Point(115, 10);
		this.cboPurchaseReturn.Name = "cboPurchaseReturn";
		this.cboPurchaseReturn.Size = new System.Drawing.Size(218, 21);
		this.cboPurchaseReturn.TabIndex = 1;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(6, 13);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(85, 13);
		this.Label1.TabIndex = 0;
		this.Label1.Text = "Retur Pembelian";
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(374, 359);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(65, 28);
		this.btnSave.TabIndex = 101;
		this.btnSave.Text = "Simpan";
		this.btnSave.UseVisualStyleBackColor = true;
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(454, 396);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.TabControl1);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSettingGeneral";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Setting Umum";
		this.TabControl1.ResumeLayout(false);
		this.TabPage1.ResumeLayout(false);
		this.TabPage1.PerformLayout();
		base.ResumeLayout(false);
	}

	public frmSettingGeneral()
	{
		base.KeyDown += frmSettingGeneral_KeyDown;
		InitializeComponent();
		ComboBox combo = cboPurchaseReturn;
		cCombo.getAccount(ref combo, All: false, 0, 0, 0, 0, 0, 0, 0, 0, -1);
		cboPurchaseReturn = combo;
		cSetting cSetting2 = new cSetting("PurchaseReturnAccountId");
		combo = cboPurchaseReturn;
		Module1.comboBoundValue(ref combo, Conversions.ToDouble(cSetting2.Value));
		cboPurchaseReturn = combo;
		cSetting2 = new cSetting("UseNewGetStockCode");
		chkUseNewGetStockCode.Checked = Conversions.ToBoolean(cSetting2.Value);
		cSetting2 = new cSetting("ReportUseNewGetStockCode");
		chkReportUseNewGetStockCode.Checked = Conversions.ToBoolean(cSetting2.Value);
	}

	private void frmSettingGeneral_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		cComboItem cComboItem2 = (cComboItem)cboPurchaseReturn.SelectedItem;
		if (cboPurchaseReturn.SelectedIndex == -1)
		{
			Interaction.MsgBox("Pilih akun Retur Pembelian", MsgBoxStyle.Information);
			cboPurchaseReturn.Focus();
			return;
		}
		cSetting cSetting2 = new cSetting("PurchaseReturnAccountId");
		cSetting2.Value = cComboItem2.Value;
		cSetting2.Save();
		cSetting2 = new cSetting("UseNewGetStockCode");
		cSetting2.Value = Conversions.ToString(Interaction.IIf(chkUseNewGetStockCode.Checked, 1, 0));
		cSetting2.Save();
		cSetting2 = new cSetting("ReportUseNewGetStockCode");
		cSetting2.Value = Conversions.ToString(Interaction.IIf(chkReportUseNewGetStockCode.Checked, 1, 0));
		cSetting2.Save();
		Interaction.MsgBox("Setting berhasil disimpan. Harap logout dan login ulang untuk mengaktifkan.", MsgBoxStyle.Information);
		Close();
	}
}
