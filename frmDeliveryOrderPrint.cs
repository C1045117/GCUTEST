using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6;

namespace GCUv2;

[DesignerGenerated]
public class frmDeliveryOrderPrint : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnPrintLetter")]
	private Button _btnPrintLetter;

	internal virtual Button btnPrintLetter
	{
		[CompilerGenerated]
		get
		{
			return _btnPrintLetter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnPrintLetter_Click;
			Button button = _btnPrintLetter;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnPrintLetter = value;
			button = _btnPrintLetter;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("dgvItemLetter")]
	internal virtual DataGridView dgvItemLetter
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblInvoiceNoLetter")]
	internal virtual Label lblInvoiceNoLetter
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAddressLetter")]
	internal virtual Label lblAddressLetter
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNameLetter")]
	internal virtual Label lblNameLetter
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblYthLetter")]
	internal virtual Label lblYthLetter
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDateLetter")]
	internal virtual Label lblDateLetter
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
		this.btnPrintLetter = new System.Windows.Forms.Button();
		this.dgvItemLetter = new System.Windows.Forms.DataGridView();
		this.lblInvoiceNoLetter = new System.Windows.Forms.Label();
		this.lblAddressLetter = new System.Windows.Forms.Label();
		this.lblNameLetter = new System.Windows.Forms.Label();
		this.lblYthLetter = new System.Windows.Forms.Label();
		this.lblDateLetter = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.dgvItemLetter).BeginInit();
		base.SuspendLayout();
		this.btnPrintLetter.BackColor = System.Drawing.SystemColors.ButtonFace;
		this.btnPrintLetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnPrintLetter.Location = new System.Drawing.Point(393, 261);
		this.btnPrintLetter.Name = "btnPrintLetter";
		this.btnPrintLetter.Size = new System.Drawing.Size(61, 24);
		this.btnPrintLetter.TabIndex = 27;
		this.btnPrintLetter.Text = "Cetak";
		this.btnPrintLetter.UseVisualStyleBackColor = false;
		this.dgvItemLetter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvItemLetter.Location = new System.Drawing.Point(12, 100);
		this.dgvItemLetter.Name = "dgvItemLetter";
		this.dgvItemLetter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dgvItemLetter.Size = new System.Drawing.Size(442, 146);
		this.dgvItemLetter.TabIndex = 26;
		this.lblInvoiceNoLetter.AutoSize = true;
		this.lblInvoiceNoLetter.Location = new System.Drawing.Point(9, 84);
		this.lblInvoiceNoLetter.Name = "lblInvoiceNoLetter";
		this.lblInvoiceNoLetter.Size = new System.Drawing.Size(93, 13);
		this.lblInvoiceNoLetter.TabIndex = 25;
		this.lblInvoiceNoLetter.Text = "lblInvoiceNoLetter";
		this.lblAddressLetter.AutoSize = true;
		this.lblAddressLetter.Location = new System.Drawing.Point(271, 48);
		this.lblAddressLetter.Name = "lblAddressLetter";
		this.lblAddressLetter.Size = new System.Drawing.Size(82, 13);
		this.lblAddressLetter.TabIndex = 24;
		this.lblAddressLetter.Text = "lblAddressLetter";
		this.lblNameLetter.AutoSize = true;
		this.lblNameLetter.Location = new System.Drawing.Point(271, 35);
		this.lblNameLetter.Name = "lblNameLetter";
		this.lblNameLetter.Size = new System.Drawing.Size(72, 13);
		this.lblNameLetter.TabIndex = 23;
		this.lblNameLetter.Text = "lblNameLetter";
		this.lblYthLetter.AutoSize = true;
		this.lblYthLetter.Location = new System.Drawing.Point(271, 22);
		this.lblYthLetter.Name = "lblYthLetter";
		this.lblYthLetter.Size = new System.Drawing.Size(66, 13);
		this.lblYthLetter.TabIndex = 22;
		this.lblYthLetter.Text = "Kepada Yth,";
		this.lblDateLetter.AutoSize = true;
		this.lblDateLetter.Location = new System.Drawing.Point(271, 9);
		this.lblDateLetter.Name = "lblDateLetter";
		this.lblDateLetter.Size = new System.Drawing.Size(67, 13);
		this.lblDateLetter.TabIndex = 21;
		this.lblDateLetter.Text = "lblDateLetter";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(467, 297);
		base.Controls.Add(this.btnPrintLetter);
		base.Controls.Add(this.dgvItemLetter);
		base.Controls.Add(this.lblInvoiceNoLetter);
		base.Controls.Add(this.lblAddressLetter);
		base.Controls.Add(this.lblNameLetter);
		base.Controls.Add(this.lblYthLetter);
		base.Controls.Add(this.lblDateLetter);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmDeliveryOrderPrint";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Print Preview";
		((System.ComponentModel.ISupportInitialize)this.dgvItemLetter).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmDeliveryOrderPrint()
	{
		base.KeyDown += frmDeliveryOrderPrint_KeyDown;
		base.Load += frmDeliveryOrderPrint_Load;
		InitializeComponent();
		DoubleBuffered = true;
		formatGrid();
	}

	private void formatGrid()
	{
		dgvItemLetter.Columns.Add("", "No");
		dgvItemLetter.Columns.Add("", "Nama Barang");
		dgvItemLetter.Columns.Add("", "Kemasan");
		dgvItemLetter.Columns.Add("", "Qty");
		dgvItemLetter.Columns[0].Width = 30;
		dgvItemLetter.Columns[1].Width = 180;
		dgvItemLetter.Columns[2].Width = 100;
		dgvItemLetter.Columns[3].Width = 100;
		dgvItemLetter.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItemLetter.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItemLetter.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItemLetter.RowHeadersVisible = false;
		dgvItemLetter.AllowUserToAddRows = false;
		dgvItemLetter.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvItemLetter.ReadOnly = true;
		dgvItemLetter.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvItemLetter.AllowUserToResizeRows = false;
	}

	private void frmDeliveryOrderPrint_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void frmDeliveryOrderPrint_Load(object sender, EventArgs e)
	{
		dgvItemLetter.CurrentRow.Selected = false;
	}

	private void btnPrintLetter_Click(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						Printer val = new Printer();
						val.ScaleMode = 6;
						val.Width = 11907;
						val.Height = 7880;
						val.Font = new Font("Times New Roman", 11f);
						double num3 = 1.0;
						int num4 = 135;
						val.CurrentX = num4;
						val.CurrentY = (float)(num3 + 3.0);
						val.Print(new object[1] { lblDateLetter.Text });
						val.CurrentX = num4;
						val.CurrentY = (float)(num3 + 8.0);
						val.Print(new object[1] { lblYthLetter.Text });
						val.CurrentX = num4;
						val.CurrentY = (float)(num3 + 13.0);
						val.Print(new object[1] { lblNameLetter.Text });
						val.Font = new Font("Times New Roman", 10f);
						string[] array = Module1.divideString(lblAddressLetter.Text, 44);
						int num5 = (int)Math.Round(num3 + 18.0);
						int num6 = Information.LBound(array);
						int num7 = Information.UBound(array);
						int i;
						for (i = num6; i <= num7; i++)
						{
							val.CurrentX = num4;
							val.CurrentY = num5;
							val.Print(new object[1] { array[i] });
							num5 += 4;
						}
						val.Font = new Font("Times New Roman", 11f);
						val.CurrentX = 5f;
						val.CurrentY = (float)(num3 + 28.0);
						val.Print(new object[1] { lblInvoiceNoLetter.Text });
						val.Font = new Font("Times New Roman", 9f);
						num5 = 34;
						i = 0;
						do
						{
							val.Line(5f, (float)num5, 13f, (float)(num5 + 5), -1, true, false);
							val.Line(13f, (float)num5, 85f, (float)(num5 + 5), -1, true, false);
							val.Line(85f, (float)num5, 115f, (float)(num5 + 5), -1, true, false);
							val.Line(115f, (float)num5, 138f, (float)(num5 + 5), -1, true, false);
							num5 += 5;
							i++;
						}
						while (i <= 10);
						num5 = (int)Math.Round(num3 + 39.0);
						int num8 = dgvItemLetter.RowCount - 1;
						for (i = 0; i <= num8; i++)
						{
							val.CurrentX = 8f;
							val.CurrentY = num5;
							val.Print(new object[1] { dgvItemLetter[0, i].Value });
							val.CurrentX = 15f;
							val.CurrentY = num5;
							val.Print(new object[1] { dgvItemLetter[1, i].Value });
							val.CurrentX = 110f - val.TextWidth(Conversions.ToString(dgvItemLetter[2, i].Value));
							val.CurrentY = num5;
							val.Print(new object[1] { dgvItemLetter[2, i].Value });
							val.CurrentX = 136f - val.TextWidth(Conversions.ToString(dgvItemLetter[3, i].Value));
							val.CurrentY = num5;
							val.Print(new object[1] { dgvItemLetter[3, i].Value });
							num5 += 5;
						}
						num5 = 35;
						val.CurrentX = 7f;
						val.CurrentY = num5;
						val.Print(new object[1] { "No." });
						val.CurrentX = 15f;
						val.CurrentY = num5;
						val.Print(new object[1] { "Nama Barang" });
						val.CurrentX = 87f;
						val.CurrentY = num5;
						val.Print(new object[1] { "Kemasan" });
						val.CurrentX = 117f;
						val.CurrentY = num5;
						val.Print(new object[1] { "Banyaknya" });
						val.NewPage();
						val.EndDoc();
						goto end_IL_0001;
					}
					case 1194:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmDeliveryOrderPrint", "btnPrintLetter_click", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1194;
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
