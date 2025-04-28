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
public class frmSettingPrint : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSaveClose")]
	private Button _btnSaveClose;

	[field: AccessedThroughProperty("txtCompanyName")]
	internal virtual TextBox txtCompanyName
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

	[field: AccessedThroughProperty("txtCompanyDetail1")]
	internal virtual TextBox txtCompanyDetail1
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

	[field: AccessedThroughProperty("txtCompanyDetail2")]
	internal virtual TextBox txtCompanyDetail2
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

	[field: AccessedThroughProperty("txtCompanyDetail3")]
	internal virtual TextBox txtCompanyDetail3
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

	[field: AccessedThroughProperty("txtCompanyCity")]
	internal virtual TextBox txtCompanyCity
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtReceiptCity")]
	internal virtual TextBox txtReceiptCity
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtReceiptPersonName")]
	internal virtual TextBox txtReceiptPersonName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTaxPersonPosition")]
	internal virtual TextBox txtTaxPersonPosition
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTaxPersonName")]
	internal virtual TextBox txtTaxPersonName
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

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtReceiptCode")]
	internal virtual TextBox txtReceiptCode
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtReceiptDescription")]
	internal virtual TextBox txtReceiptDescription
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label12")]
	internal virtual Label Label12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNPWP")]
	internal virtual TextBox txtNPWP
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label13")]
	internal virtual Label Label13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTaxNumber")]
	internal virtual TextBox txtTaxNumber
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label14")]
	internal virtual Label Label14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTaxAddress")]
	internal virtual TextBox txtTaxAddress
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label15")]
	internal virtual Label Label15
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
		this.txtCompanyName = new System.Windows.Forms.TextBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.txtCompanyDetail1 = new System.Windows.Forms.TextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.txtCompanyDetail2 = new System.Windows.Forms.TextBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.txtCompanyDetail3 = new System.Windows.Forms.TextBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.txtCompanyCity = new System.Windows.Forms.TextBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.txtReceiptCity = new System.Windows.Forms.TextBox();
		this.Label6 = new System.Windows.Forms.Label();
		this.txtReceiptPersonName = new System.Windows.Forms.TextBox();
		this.Label7 = new System.Windows.Forms.Label();
		this.txtTaxPersonPosition = new System.Windows.Forms.TextBox();
		this.Label8 = new System.Windows.Forms.Label();
		this.txtTaxPersonName = new System.Windows.Forms.TextBox();
		this.Label9 = new System.Windows.Forms.Label();
		this.btnSaveClose = new System.Windows.Forms.Button();
		this.Label10 = new System.Windows.Forms.Label();
		this.txtReceiptCode = new System.Windows.Forms.TextBox();
		this.Label11 = new System.Windows.Forms.Label();
		this.txtReceiptDescription = new System.Windows.Forms.TextBox();
		this.Label12 = new System.Windows.Forms.Label();
		this.txtNPWP = new System.Windows.Forms.TextBox();
		this.Label13 = new System.Windows.Forms.Label();
		this.txtTaxNumber = new System.Windows.Forms.TextBox();
		this.Label14 = new System.Windows.Forms.Label();
		this.txtTaxAddress = new System.Windows.Forms.TextBox();
		this.Label15 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.txtCompanyName.Location = new System.Drawing.Point(126, 28);
		this.txtCompanyName.MaxLength = 50;
		this.txtCompanyName.Name = "txtCompanyName";
		this.txtCompanyName.Size = new System.Drawing.Size(293, 20);
		this.txtCompanyName.TabIndex = 0;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(10, 32);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(64, 13);
		this.Label2.TabIndex = 85;
		this.Label2.Text = "Perusahaan";
		this.txtCompanyDetail1.Location = new System.Drawing.Point(126, 54);
		this.txtCompanyDetail1.MaxLength = 50;
		this.txtCompanyDetail1.Name = "txtCompanyDetail1";
		this.txtCompanyDetail1.Size = new System.Drawing.Size(293, 20);
		this.txtCompanyDetail1.TabIndex = 1;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(10, 58);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(113, 13);
		this.Label1.TabIndex = 87;
		this.Label1.Text = "Keterangan 1 (F. Kom)";
		this.txtCompanyDetail2.Location = new System.Drawing.Point(126, 80);
		this.txtCompanyDetail2.MaxLength = 50;
		this.txtCompanyDetail2.Name = "txtCompanyDetail2";
		this.txtCompanyDetail2.Size = new System.Drawing.Size(293, 20);
		this.txtCompanyDetail2.TabIndex = 2;
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(10, 84);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(113, 13);
		this.Label3.TabIndex = 89;
		this.Label3.Text = "Keterangan 2 (F. Kom)";
		this.txtCompanyDetail3.Location = new System.Drawing.Point(126, 106);
		this.txtCompanyDetail3.MaxLength = 50;
		this.txtCompanyDetail3.Name = "txtCompanyDetail3";
		this.txtCompanyDetail3.Size = new System.Drawing.Size(293, 20);
		this.txtCompanyDetail3.TabIndex = 3;
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(10, 110);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(113, 13);
		this.Label4.TabIndex = 91;
		this.Label4.Text = "Keterangan 3 (F. Kom)";
		this.txtCompanyCity.Location = new System.Drawing.Point(126, 210);
		this.txtCompanyCity.MaxLength = 50;
		this.txtCompanyCity.Name = "txtCompanyCity";
		this.txtCompanyCity.Size = new System.Drawing.Size(293, 20);
		this.txtCompanyCity.TabIndex = 7;
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(10, 214);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(113, 13);
		this.Label5.TabIndex = 93;
		this.Label5.Text = "Kota (F. Pajak, F.Kom)";
		this.txtReceiptCity.Location = new System.Drawing.Point(126, 340);
		this.txtReceiptCity.MaxLength = 50;
		this.txtReceiptCity.Name = "txtReceiptCity";
		this.txtReceiptCity.Size = new System.Drawing.Size(293, 20);
		this.txtReceiptCity.TabIndex = 12;
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(10, 344);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(75, 13);
		this.Label6.TabIndex = 101;
		this.Label6.Text = "Kota (Kuitansi)";
		this.txtReceiptPersonName.Location = new System.Drawing.Point(126, 314);
		this.txtReceiptPersonName.MaxLength = 50;
		this.txtReceiptPersonName.Name = "txtReceiptPersonName";
		this.txtReceiptPersonName.Size = new System.Drawing.Size(293, 20);
		this.txtReceiptPersonName.TabIndex = 11;
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(10, 318);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(81, 13);
		this.Label7.TabIndex = 99;
		this.Label7.Text = "Nama (Kuitansi)";
		this.txtTaxPersonPosition.Location = new System.Drawing.Point(126, 262);
		this.txtTaxPersonPosition.MaxLength = 50;
		this.txtTaxPersonPosition.Name = "txtTaxPersonPosition";
		this.txtTaxPersonPosition.Size = new System.Drawing.Size(293, 20);
		this.txtTaxPersonPosition.TabIndex = 9;
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(10, 266);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(93, 13);
		this.Label8.TabIndex = 98;
		this.Label8.Text = "Jabatan (F. Pajak)";
		this.txtTaxPersonName.Location = new System.Drawing.Point(126, 236);
		this.txtTaxPersonName.MaxLength = 50;
		this.txtTaxPersonName.Name = "txtTaxPersonName";
		this.txtTaxPersonName.Size = new System.Drawing.Size(293, 20);
		this.txtTaxPersonName.TabIndex = 8;
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(10, 240);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(83, 13);
		this.Label9.TabIndex = 97;
		this.Label9.Text = "Nama (F. Pajak)";
		this.btnSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSaveClose.Location = new System.Drawing.Point(126, 392);
		this.btnSaveClose.Name = "btnSaveClose";
		this.btnSaveClose.Size = new System.Drawing.Size(93, 24);
		this.btnSaveClose.TabIndex = 20;
		this.btnSaveClose.Text = "Simpan && &Tutup";
		this.btnSaveClose.UseVisualStyleBackColor = true;
		this.Label10.AutoSize = true;
		this.Label10.Location = new System.Drawing.Point(10, 9);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(325, 13);
		this.Label10.TabIndex = 102;
		this.Label10.Text = "Setting ini mempengaruhi detail yang dicetak di Faktur dan Kuitansi.";
		this.txtReceiptCode.Location = new System.Drawing.Point(126, 288);
		this.txtReceiptCode.MaxLength = 10;
		this.txtReceiptCode.Name = "txtReceiptCode";
		this.txtReceiptCode.Size = new System.Drawing.Size(293, 20);
		this.txtReceiptCode.TabIndex = 10;
		this.Label11.AutoSize = true;
		this.Label11.Location = new System.Drawing.Point(10, 292);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(78, 13);
		this.Label11.TabIndex = 104;
		this.Label11.Text = "Kode (Kuitansi)";
		this.txtReceiptDescription.Location = new System.Drawing.Point(126, 366);
		this.txtReceiptDescription.MaxLength = 50;
		this.txtReceiptDescription.Name = "txtReceiptDescription";
		this.txtReceiptDescription.Size = new System.Drawing.Size(293, 20);
		this.txtReceiptDescription.TabIndex = 13;
		this.Label12.AutoSize = true;
		this.Label12.Location = new System.Drawing.Point(10, 370);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(96, 13);
		this.Label12.TabIndex = 106;
		this.Label12.Text = "Deskripsi (Kuitansi)";
		this.txtNPWP.Location = new System.Drawing.Point(126, 132);
		this.txtNPWP.MaxLength = 50;
		this.txtNPWP.Name = "txtNPWP";
		this.txtNPWP.Size = new System.Drawing.Size(293, 20);
		this.txtNPWP.TabIndex = 4;
		this.Label13.AutoSize = true;
		this.Label13.Location = new System.Drawing.Point(10, 136);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(40, 13);
		this.Label13.TabIndex = 108;
		this.Label13.Text = "NPWP";
		this.txtTaxNumber.Location = new System.Drawing.Point(126, 158);
		this.txtTaxNumber.MaxLength = 50;
		this.txtTaxNumber.Name = "txtTaxNumber";
		this.txtTaxNumber.Size = new System.Drawing.Size(293, 20);
		this.txtTaxNumber.TabIndex = 5;
		this.Label14.AutoSize = true;
		this.Label14.Location = new System.Drawing.Point(10, 162);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(95, 13);
		this.Label14.TabIndex = 110;
		this.Label14.Text = "No Awal (F. Pajak)";
		this.txtTaxAddress.Location = new System.Drawing.Point(126, 184);
		this.txtTaxAddress.MaxLength = 120;
		this.txtTaxAddress.Name = "txtTaxAddress";
		this.txtTaxAddress.Size = new System.Drawing.Size(293, 20);
		this.txtTaxAddress.TabIndex = 6;
		this.Label15.AutoSize = true;
		this.Label15.Location = new System.Drawing.Point(10, 188);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(87, 13);
		this.Label15.TabIndex = 112;
		this.Label15.Text = "Alamat (F. Pajak)";
		base.AcceptButton = this.btnSaveClose;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(431, 425);
		base.Controls.Add(this.txtTaxAddress);
		base.Controls.Add(this.Label15);
		base.Controls.Add(this.txtTaxNumber);
		base.Controls.Add(this.Label14);
		base.Controls.Add(this.txtNPWP);
		base.Controls.Add(this.Label13);
		base.Controls.Add(this.txtReceiptDescription);
		base.Controls.Add(this.Label12);
		base.Controls.Add(this.txtReceiptCode);
		base.Controls.Add(this.Label11);
		base.Controls.Add(this.Label10);
		base.Controls.Add(this.btnSaveClose);
		base.Controls.Add(this.txtReceiptCity);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.txtReceiptPersonName);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.txtTaxPersonPosition);
		base.Controls.Add(this.Label8);
		base.Controls.Add(this.txtTaxPersonName);
		base.Controls.Add(this.Label9);
		base.Controls.Add(this.txtCompanyCity);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.txtCompanyDetail3);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.txtCompanyDetail2);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.txtCompanyDetail1);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.txtCompanyName);
		base.Controls.Add(this.Label2);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSettingPrint";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Detail Pencetakan";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmSettingPrint()
	{
		base.KeyDown += frmSettingPrint_KeyDown;
		base.Load += frmSettingPrint_Load;
		InitializeComponent();
		base.MdiParent = MyProject.Forms.frmMenu;
	}

	private void frmSettingPrint_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void frmSettingPrint_Load(object sender, EventArgs e)
	{
		cPrintSetting cPrintSetting2 = new cPrintSetting(1);
		txtCompanyName.Text = cPrintSetting2.CompanyName;
		txtCompanyDetail1.Text = cPrintSetting2.CompanyDetail1;
		txtCompanyDetail2.Text = cPrintSetting2.CompanyDetail2;
		txtCompanyDetail3.Text = cPrintSetting2.CompanyDetail3;
		txtCompanyCity.Text = cPrintSetting2.CompanyCity;
		txtNPWP.Text = cPrintSetting2.NPWP;
		txtTaxNumber.Text = cPrintSetting2.TaxNumber;
		txtTaxAddress.Text = cPrintSetting2.TaxAddress;
		txtTaxPersonName.Text = cPrintSetting2.TaxPersonName;
		txtTaxPersonPosition.Text = cPrintSetting2.TaxPersonPosition;
		txtReceiptCode.Text = cPrintSetting2.SalesReceiptCode;
		txtReceiptPersonName.Text = cPrintSetting2.SalesReceiptPersonName;
		txtReceiptCity.Text = cPrintSetting2.SalesReceiptCity;
		txtReceiptDescription.Text = cPrintSetting2.SalesReceiptDescription;
	}

	private void btnSaveClose_Click(object sender, EventArgs e)
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
					cPrintSetting cPrintSetting2 = new cPrintSetting(0);
					cPrintSetting2.CompanyName = txtCompanyName.Text;
					cPrintSetting2.CompanyDetail1 = txtCompanyDetail1.Text;
					cPrintSetting2.CompanyDetail2 = txtCompanyDetail2.Text;
					cPrintSetting2.CompanyDetail3 = txtCompanyDetail3.Text;
					cPrintSetting2.CompanyCity = txtCompanyCity.Text;
					cPrintSetting2.NPWP = txtNPWP.Text;
					cPrintSetting2.TaxNumber = txtTaxNumber.Text;
					cPrintSetting2.TaxAddress = txtTaxAddress.Text;
					cPrintSetting2.TaxPersonName = txtTaxPersonName.Text;
					cPrintSetting2.TaxPersonPosition = txtTaxPersonPosition.Text;
					cPrintSetting2.SalesReceiptCode = txtReceiptCode.Text;
					cPrintSetting2.SalesReceiptPersonName = txtReceiptPersonName.Text;
					cPrintSetting2.SalesReceiptCity = txtReceiptCity.Text;
					cPrintSetting2.SalesReceiptDescription = txtReceiptDescription.Text;
					cPrintSetting2.Save();
					Interaction.MsgBox("Detail Pencetakan berhasil disimpan", MsgBoxStyle.Information);
					Close();
					goto end_IL_0001;
				}
				case 328:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSettingPrint", "btnDelete_Click", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 328;
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
