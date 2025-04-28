using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6;

namespace GCUv2;

[DesignerGenerated]
public class frmPurchaseReturnPrint : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnPrintCommercial")]
	private Button _btnPrintCommercial;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnPrintTax")]
	private Button _btnPrintTax;

	[field: AccessedThroughProperty("lblPPN")]
	internal virtual Label lblPPN
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabControl1")]
	internal virtual TabControl TabControl1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage2")]
	internal virtual TabPage TabPage2
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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
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

	[field: AccessedThroughProperty("lblTotalPaymentCommercial")]
	internal virtual Label lblTotalPaymentCommercial
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

	[field: AccessedThroughProperty("lblDeductionCommercial")]
	internal virtual Label lblDeductionCommercial
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDiscountValueCommercial")]
	internal virtual Label lblDiscountValueCommercial
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTotalPriceCommercial")]
	internal virtual Label lblTotalPriceCommercial
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

	internal virtual Button btnPrintCommercial
	{
		[CompilerGenerated]
		get
		{
			return _btnPrintCommercial;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnPrintCommercial_Click;
			Button button = _btnPrintCommercial;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnPrintCommercial = value;
			button = _btnPrintCommercial;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("dgvItemCommercial")]
	internal virtual DataGridView dgvItemCommercial
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblInvoiceNoCommercial")]
	internal virtual Label lblInvoiceNoCommercial
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAddressCommercial")]
	internal virtual Label lblAddressCommercial
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNameCommercial")]
	internal virtual Label lblNameCommercial
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblYthCommercial")]
	internal virtual Label lblYthCommercial
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDateCommercial")]
	internal virtual Label lblDateCommercial
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage3")]
	internal virtual TabPage TabPage3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label21")]
	internal virtual Label Label21
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label20")]
	internal virtual Label Label20
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDPP")]
	internal virtual Label lblDPP
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnPrintTax
	{
		[CompilerGenerated]
		get
		{
			return _btnPrintTax;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnPrintTax_Click;
			Button button = _btnPrintTax;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnPrintTax = value;
			button = _btnPrintTax;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("dgvItemTax")]
	internal virtual DataGridView dgvItemTax
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTaxInvoiceNo")]
	internal virtual Label lblTaxInvoiceNo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTaxInvoiceDate")]
	internal virtual Label lblTaxInvoiceDate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPurchaseReturnNo")]
	internal virtual Label lblPurchaseReturnNo
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPurchaseReturnDate")]
	internal virtual Label lblPurchaseReturnDate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblInformation")]
	internal virtual Label lblInformation
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDiscount")]
	internal virtual Label lblDiscount
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
		this.lblPPN = new System.Windows.Forms.Label();
		this.TabControl1 = new System.Windows.Forms.TabControl();
		this.TabPage2 = new System.Windows.Forms.TabPage();
		this.Label8 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label13 = new System.Windows.Forms.Label();
		this.lblTotalPaymentCommercial = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.lblDeductionCommercial = new System.Windows.Forms.Label();
		this.lblDiscountValueCommercial = new System.Windows.Forms.Label();
		this.lblTotalPriceCommercial = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.btnPrintCommercial = new System.Windows.Forms.Button();
		this.dgvItemCommercial = new System.Windows.Forms.DataGridView();
		this.lblInvoiceNoCommercial = new System.Windows.Forms.Label();
		this.lblAddressCommercial = new System.Windows.Forms.Label();
		this.lblNameCommercial = new System.Windows.Forms.Label();
		this.lblYthCommercial = new System.Windows.Forms.Label();
		this.lblDateCommercial = new System.Windows.Forms.Label();
		this.TabPage3 = new System.Windows.Forms.TabPage();
		this.lblInformation = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.lblPurchaseReturnDate = new System.Windows.Forms.Label();
		this.lblPurchaseReturnNo = new System.Windows.Forms.Label();
		this.Label21 = new System.Windows.Forms.Label();
		this.Label20 = new System.Windows.Forms.Label();
		this.lblDPP = new System.Windows.Forms.Label();
		this.btnPrintTax = new System.Windows.Forms.Button();
		this.dgvItemTax = new System.Windows.Forms.DataGridView();
		this.lblTaxInvoiceNo = new System.Windows.Forms.Label();
		this.lblTaxInvoiceDate = new System.Windows.Forms.Label();
		this.lblDiscount = new System.Windows.Forms.Label();
		this.TabControl1.SuspendLayout();
		this.TabPage2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvItemCommercial).BeginInit();
		this.TabPage3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvItemTax).BeginInit();
		base.SuspendLayout();
		this.lblPPN.Location = new System.Drawing.Point(566, 260);
		this.lblPPN.Name = "lblPPN";
		this.lblPPN.Size = new System.Drawing.Size(144, 13);
		this.lblPPN.TabIndex = 170;
		this.lblPPN.Text = "lblPPN";
		this.lblPPN.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.TabControl1.Controls.Add(this.TabPage2);
		this.TabControl1.Controls.Add(this.TabPage3);
		this.TabControl1.Location = new System.Drawing.Point(12, 12);
		this.TabControl1.Name = "TabControl1";
		this.TabControl1.SelectedIndex = 0;
		this.TabControl1.Size = new System.Drawing.Size(738, 467);
		this.TabControl1.TabIndex = 15;
		this.TabPage2.Controls.Add(this.lblDiscount);
		this.TabPage2.Controls.Add(this.Label8);
		this.TabPage2.Controls.Add(this.Label5);
		this.TabPage2.Controls.Add(this.Label13);
		this.TabPage2.Controls.Add(this.lblTotalPaymentCommercial);
		this.TabPage2.Controls.Add(this.Label7);
		this.TabPage2.Controls.Add(this.lblDeductionCommercial);
		this.TabPage2.Controls.Add(this.lblDiscountValueCommercial);
		this.TabPage2.Controls.Add(this.lblTotalPriceCommercial);
		this.TabPage2.Controls.Add(this.Label1);
		this.TabPage2.Controls.Add(this.btnPrintCommercial);
		this.TabPage2.Controls.Add(this.dgvItemCommercial);
		this.TabPage2.Controls.Add(this.lblInvoiceNoCommercial);
		this.TabPage2.Controls.Add(this.lblAddressCommercial);
		this.TabPage2.Controls.Add(this.lblNameCommercial);
		this.TabPage2.Controls.Add(this.lblYthCommercial);
		this.TabPage2.Controls.Add(this.lblDateCommercial);
		this.TabPage2.Location = new System.Drawing.Point(4, 22);
		this.TabPage2.Name = "TabPage2";
		this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage2.Size = new System.Drawing.Size(730, 441);
		this.TabPage2.TabIndex = 1;
		this.TabPage2.Text = "F. Komersial";
		this.TabPage2.UseVisualStyleBackColor = true;
		this.Label8.BackColor = System.Drawing.Color.Silver;
		this.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Label8.Location = new System.Drawing.Point(23, 324);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(684, 1);
		this.Label8.TabIndex = 154;
		this.Label5.BackColor = System.Drawing.Color.Silver;
		this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Label5.Location = new System.Drawing.Point(22, 300);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(684, 1);
		this.Label5.TabIndex = 153;
		this.Label13.BackColor = System.Drawing.Color.Silver;
		this.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Label13.Location = new System.Drawing.Point(24, 264);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(684, 1);
		this.Label13.TabIndex = 151;
		this.lblTotalPaymentCommercial.Location = new System.Drawing.Point(566, 328);
		this.lblTotalPaymentCommercial.Name = "lblTotalPaymentCommercial";
		this.lblTotalPaymentCommercial.Size = new System.Drawing.Size(144, 13);
		this.lblTotalPaymentCommercial.TabIndex = 32;
		this.lblTotalPaymentCommercial.Text = "lblTotalPaymentCommercial";
		this.lblTotalPaymentCommercial.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(20, 328);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(138, 13);
		this.Label7.TabIndex = 31;
		this.Label7.Text = "Jumlah Yang Harus Dibayar";
		this.lblDeductionCommercial.Location = new System.Drawing.Point(566, 305);
		this.lblDeductionCommercial.Name = "lblDeductionCommercial";
		this.lblDeductionCommercial.Size = new System.Drawing.Size(144, 13);
		this.lblDeductionCommercial.TabIndex = 30;
		this.lblDeductionCommercial.Text = "lblDeductionCommercial";
		this.lblDeductionCommercial.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.lblDiscountValueCommercial.Location = new System.Drawing.Point(566, 276);
		this.lblDiscountValueCommercial.Name = "lblDiscountValueCommercial";
		this.lblDiscountValueCommercial.Size = new System.Drawing.Size(144, 13);
		this.lblDiscountValueCommercial.TabIndex = 28;
		this.lblDiscountValueCommercial.Text = "lblDiscountValueCommercial";
		this.lblDiscountValueCommercial.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.lblTotalPriceCommercial.Location = new System.Drawing.Point(566, 246);
		this.lblTotalPriceCommercial.Name = "lblTotalPriceCommercial";
		this.lblTotalPriceCommercial.Size = new System.Drawing.Size(144, 13);
		this.lblTotalPriceCommercial.TabIndex = 26;
		this.lblTotalPriceCommercial.Text = "lblTotalPriceCommercial";
		this.lblTotalPriceCommercial.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(20, 246);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(94, 13);
		this.Label1.TabIndex = 25;
		this.Label1.Text = "Jumlah Harga Jual";
		this.btnPrintCommercial.BackColor = System.Drawing.SystemColors.ButtonFace;
		this.btnPrintCommercial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnPrintCommercial.Location = new System.Drawing.Point(649, 402);
		this.btnPrintCommercial.Name = "btnPrintCommercial";
		this.btnPrintCommercial.Size = new System.Drawing.Size(61, 24);
		this.btnPrintCommercial.TabIndex = 24;
		this.btnPrintCommercial.Text = "Cetak";
		this.btnPrintCommercial.UseVisualStyleBackColor = false;
		this.dgvItemCommercial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvItemCommercial.Location = new System.Drawing.Point(23, 102);
		this.dgvItemCommercial.Name = "dgvItemCommercial";
		this.dgvItemCommercial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dgvItemCommercial.Size = new System.Drawing.Size(687, 132);
		this.dgvItemCommercial.TabIndex = 23;
		this.lblInvoiceNoCommercial.AutoSize = true;
		this.lblInvoiceNoCommercial.Location = new System.Drawing.Point(20, 86);
		this.lblInvoiceNoCommercial.Name = "lblInvoiceNoCommercial";
		this.lblInvoiceNoCommercial.Size = new System.Drawing.Size(120, 13);
		this.lblInvoiceNoCommercial.TabIndex = 22;
		this.lblInvoiceNoCommercial.Text = "lblInvoiceNoCommercial";
		this.lblAddressCommercial.AutoSize = true;
		this.lblAddressCommercial.Location = new System.Drawing.Point(381, 59);
		this.lblAddressCommercial.Name = "lblAddressCommercial";
		this.lblAddressCommercial.Size = new System.Drawing.Size(109, 13);
		this.lblAddressCommercial.TabIndex = 21;
		this.lblAddressCommercial.Text = "lblAddressCommercial";
		this.lblNameCommercial.AutoSize = true;
		this.lblNameCommercial.Location = new System.Drawing.Point(381, 46);
		this.lblNameCommercial.Name = "lblNameCommercial";
		this.lblNameCommercial.Size = new System.Drawing.Size(99, 13);
		this.lblNameCommercial.TabIndex = 20;
		this.lblNameCommercial.Text = "lblNameCommercial";
		this.lblYthCommercial.AutoSize = true;
		this.lblYthCommercial.Location = new System.Drawing.Point(381, 33);
		this.lblYthCommercial.Name = "lblYthCommercial";
		this.lblYthCommercial.Size = new System.Drawing.Size(66, 13);
		this.lblYthCommercial.TabIndex = 19;
		this.lblYthCommercial.Text = "Kepada Yth,";
		this.lblDateCommercial.AutoSize = true;
		this.lblDateCommercial.Location = new System.Drawing.Point(381, 20);
		this.lblDateCommercial.Name = "lblDateCommercial";
		this.lblDateCommercial.Size = new System.Drawing.Size(94, 13);
		this.lblDateCommercial.TabIndex = 18;
		this.lblDateCommercial.Text = "lblDateCommercial";
		this.TabPage3.BackColor = System.Drawing.Color.Gainsboro;
		this.TabPage3.Controls.Add(this.lblInformation);
		this.TabPage3.Controls.Add(this.Label3);
		this.TabPage3.Controls.Add(this.Label2);
		this.TabPage3.Controls.Add(this.lblPurchaseReturnDate);
		this.TabPage3.Controls.Add(this.lblPurchaseReturnNo);
		this.TabPage3.Controls.Add(this.Label21);
		this.TabPage3.Controls.Add(this.Label20);
		this.TabPage3.Controls.Add(this.lblPPN);
		this.TabPage3.Controls.Add(this.lblDPP);
		this.TabPage3.Controls.Add(this.btnPrintTax);
		this.TabPage3.Controls.Add(this.dgvItemTax);
		this.TabPage3.Controls.Add(this.lblTaxInvoiceNo);
		this.TabPage3.Controls.Add(this.lblTaxInvoiceDate);
		this.TabPage3.Location = new System.Drawing.Point(4, 22);
		this.TabPage3.Name = "TabPage3";
		this.TabPage3.Size = new System.Drawing.Size(730, 441);
		this.TabPage3.TabIndex = 2;
		this.TabPage3.Text = "F. Pajak";
		this.lblInformation.AutoSize = true;
		this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblInformation.ForeColor = System.Drawing.Color.Red;
		this.lblInformation.Location = new System.Drawing.Point(20, 406);
		this.lblInformation.Name = "lblInformation";
		this.lblInformation.Size = new System.Drawing.Size(599, 18);
		this.lblInformation.TabIndex = 193;
		this.lblInformation.Text = "Faktur Pajak tidak bisa dicetak karena Retur belum dihubungkan dengan Faktur Pembelian";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(33, 56);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(128, 13);
		this.Label3.TabIndex = 192;
		this.Label3.Text = "Atas Faktur Pajak Nomor:";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(33, 28);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(36, 13);
		this.Label2.TabIndex = 191;
		this.Label2.Text = "Retur:";
		this.lblPurchaseReturnDate.AutoSize = true;
		this.lblPurchaseReturnDate.Location = new System.Drawing.Point(280, 28);
		this.lblPurchaseReturnDate.Name = "lblPurchaseReturnDate";
		this.lblPurchaseReturnDate.Size = new System.Drawing.Size(117, 13);
		this.lblPurchaseReturnDate.TabIndex = 190;
		this.lblPurchaseReturnDate.Text = "lblPurchaseReturnDate";
		this.lblPurchaseReturnDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.lblPurchaseReturnNo.AutoSize = true;
		this.lblPurchaseReturnNo.Location = new System.Drawing.Point(166, 28);
		this.lblPurchaseReturnNo.Name = "lblPurchaseReturnNo";
		this.lblPurchaseReturnNo.Size = new System.Drawing.Size(108, 13);
		this.lblPurchaseReturnNo.TabIndex = 189;
		this.lblPurchaseReturnNo.Text = "lblPurchaseReturnNo";
		this.Label21.AutoSize = true;
		this.Label21.Location = new System.Drawing.Point(530, 260);
		this.Label21.Name = "Label21";
		this.Label21.Size = new System.Drawing.Size(29, 13);
		this.Label21.TabIndex = 188;
		this.Label21.Text = "PPN";
		this.Label20.AutoSize = true;
		this.Label20.Location = new System.Drawing.Point(530, 233);
		this.Label20.Name = "Label20";
		this.Label20.Size = new System.Drawing.Size(29, 13);
		this.Label20.TabIndex = 187;
		this.Label20.Text = "DPP";
		this.lblDPP.Location = new System.Drawing.Point(566, 233);
		this.lblDPP.Name = "lblDPP";
		this.lblDPP.Size = new System.Drawing.Size(144, 13);
		this.lblDPP.TabIndex = 169;
		this.lblDPP.Text = "lblDPP";
		this.lblDPP.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.btnPrintTax.BackColor = System.Drawing.SystemColors.ButtonFace;
		this.btnPrintTax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnPrintTax.Location = new System.Drawing.Point(649, 404);
		this.btnPrintTax.Name = "btnPrintTax";
		this.btnPrintTax.Size = new System.Drawing.Size(61, 24);
		this.btnPrintTax.TabIndex = 164;
		this.btnPrintTax.Text = "Cetak";
		this.btnPrintTax.UseVisualStyleBackColor = false;
		this.dgvItemTax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvItemTax.Location = new System.Drawing.Point(23, 99);
		this.dgvItemTax.Name = "dgvItemTax";
		this.dgvItemTax.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dgvItemTax.Size = new System.Drawing.Size(687, 118);
		this.dgvItemTax.TabIndex = 163;
		this.lblTaxInvoiceNo.AutoSize = true;
		this.lblTaxInvoiceNo.Location = new System.Drawing.Point(166, 56);
		this.lblTaxInvoiceNo.Name = "lblTaxInvoiceNo";
		this.lblTaxInvoiceNo.Size = new System.Drawing.Size(84, 13);
		this.lblTaxInvoiceNo.TabIndex = 159;
		this.lblTaxInvoiceNo.Text = "lblTaxInvoiceNo";
		this.lblTaxInvoiceDate.AutoSize = true;
		this.lblTaxInvoiceDate.Location = new System.Drawing.Point(280, 56);
		this.lblTaxInvoiceDate.Name = "lblTaxInvoiceDate";
		this.lblTaxInvoiceDate.Size = new System.Drawing.Size(93, 13);
		this.lblTaxInvoiceDate.TabIndex = 158;
		this.lblTaxInvoiceDate.Text = "lblTaxInvoiceDate";
		this.lblTaxInvoiceDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.lblDiscount.AutoSize = true;
		this.lblDiscount.Location = new System.Drawing.Point(21, 276);
		this.lblDiscount.Name = "lblDiscount";
		this.lblDiscount.Size = new System.Drawing.Size(133, 13);
		this.lblDiscount.TabIndex = 155;
		this.lblDiscount.Text = "Dikurangi Potongan Harga";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(759, 489);
		base.Controls.Add(this.TabControl1);
		base.KeyPreview = true;
		base.Name = "frmPurchaseReturnPrint";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Print Preview - Retur Pembelian";
		this.TabControl1.ResumeLayout(false);
		this.TabPage2.ResumeLayout(false);
		this.TabPage2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvItemCommercial).EndInit();
		this.TabPage3.ResumeLayout(false);
		this.TabPage3.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvItemTax).EndInit();
		base.ResumeLayout(false);
	}

	public frmPurchaseReturnPrint()
	{
		base.KeyDown += frmPurchaseReturnPrint_KeyDown;
		InitializeComponent();
		DoubleBuffered = true;
		formatGrid();
	}

	private void formatGrid()
	{
		dgvItemCommercial.Columns.Add("", "No");
		dgvItemCommercial.Columns.Add("", "Nama Barang");
		dgvItemCommercial.Columns.Add("", "Kemasan");
		dgvItemCommercial.Columns.Add("", "Banyaknya");
		dgvItemCommercial.Columns.Add("", "Harga Satuan");
		dgvItemCommercial.Columns.Add("", "Total");
		dgvItemCommercial.Columns[0].Width = 30;
		dgvItemCommercial.Columns[1].Width = 180;
		dgvItemCommercial.Columns[2].Width = 100;
		dgvItemCommercial.Columns[3].Width = 100;
		dgvItemCommercial.Columns[4].Width = 100;
		dgvItemCommercial.Columns[5].Width = 100;
		dgvItemCommercial.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItemCommercial.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItemCommercial.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItemCommercial.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItemCommercial.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItemCommercial.RowHeadersVisible = false;
		dgvItemCommercial.AllowUserToAddRows = false;
		dgvItemCommercial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvItemCommercial.ReadOnly = true;
		dgvItemCommercial.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvItemCommercial.AllowUserToResizeRows = false;
		dgvItemTax.Columns.Add("", "No");
		dgvItemTax.Columns.Add("", "Nama Barang");
		dgvItemTax.Columns.Add("", "Banyaknya");
		dgvItemTax.Columns.Add("", "Harga Satuan");
		dgvItemTax.Columns.Add("", "");
		dgvItemTax.Columns.Add("", "Total");
		dgvItemTax.Columns[0].Width = 30;
		dgvItemTax.Columns[1].Width = 180;
		dgvItemTax.Columns[2].Width = 100;
		dgvItemTax.Columns[3].Width = 100;
		dgvItemTax.Columns[4].Width = 1;
		dgvItemTax.Columns[5].Width = 100;
		dgvItemTax.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItemTax.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItemTax.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItemTax.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItemTax.RowHeadersVisible = false;
		dgvItemTax.AllowUserToAddRows = false;
		dgvItemTax.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvItemTax.ReadOnly = true;
		dgvItemTax.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvItemTax.AllowUserToResizeRows = false;
	}

	private void frmPurchaseReturnPrint_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void btnPrintCommercial_Click(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
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
						int num4 = 132;
						val.CurrentX = num4;
						val.CurrentY = (float)(num3 + 3.0 + (double)Module1.pubCustomY);
						val.Print(new object[1] { lblDateCommercial.Text });
						val.CurrentX = num4;
						val.CurrentY = (float)(num3 + 8.0 + (double)Module1.pubCustomY);
						val.Print(new object[1] { lblYthCommercial.Text });
						val.CurrentX = num4;
						val.CurrentY = (float)(num3 + 13.0 + (double)Module1.pubCustomY);
						val.Print(new object[1] { lblNameCommercial.Text });
						val.Font = new Font("Times New Roman", 10f);
						string[] array = Module1.divideString(lblAddressCommercial.Text, 44);
						int num5 = (int)Math.Round(num3 + 18.0);
						int num6 = Information.LBound(array);
						int num7 = Information.UBound(array);
						int i;
						for (i = num6; i <= num7; i++)
						{
							val.CurrentX = num4;
							val.CurrentY = num5 + Module1.pubCustomY;
							num5 += 4;
						}
						val.Font = new Font("Times New Roman", 11f);
						val.CurrentX = 5f;
						val.CurrentY = (float)(num3 + 28.0 + (double)Module1.pubCustomY);
						val.Print(new object[1] { lblInvoiceNoCommercial.Text });
						val.Font = new Font("Times New Roman", 9f);
						num5 = (int)Math.Round(num3 + 33.0);
						i = 0;
						do
						{
							val.Line(5f, (float)(num5 + Module1.pubCustomY), 14f, (float)(num5 + 5 + Module1.pubCustomY), -1, true, false);
							val.Line(14f, (float)(num5 + Module1.pubCustomY), 85f, (float)(num5 + 5 + Module1.pubCustomY), -1, true, false);
							val.Line(85f, (float)(num5 + Module1.pubCustomY), 113f, (float)(num5 + 5 + Module1.pubCustomY), -1, true, false);
							val.Line(113f, (float)(num5 + Module1.pubCustomY), 135f, (float)(num5 + 5 + Module1.pubCustomY), -1, true, false);
							val.Line(135f, (float)(num5 + Module1.pubCustomY), 166f, (float)(num5 + 5 + Module1.pubCustomY), -1, true, false);
							val.Line(166f, (float)(num5 + Module1.pubCustomY), 196f, (float)(num5 + 5 + Module1.pubCustomY), -1, true, false);
							num5 += 5;
							i++;
						}
						while (i <= 10);
						i = 0;
						do
						{
							val.Line(5f, (float)(num5 + Module1.pubCustomY), 166f, (float)(num5 + 5 + Module1.pubCustomY), -1, true, false);
							val.Line(166f, (float)(num5 + Module1.pubCustomY), 196f, (float)(num5 + 5 + Module1.pubCustomY), -1, true, false);
							num5 += 5;
							i++;
						}
						while (i <= 3);
						num5 = (int)Math.Round(num3 + 34.0);
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
						val.CurrentX = 139f;
						val.CurrentY = num5;
						val.Print(new object[1] { "Harga Satuan" });
						val.CurrentX = 169f;
						val.CurrentY = num5;
						val.Print(new object[1] { "Jumlah" });
						num5 = (int)Math.Round(num3 + 39.0);
						int num8 = dgvItemCommercial.RowCount - 1;
						for (i = 0; i <= num8; i++)
						{
							val.CurrentX = 8f;
							val.CurrentY = num5 + Module1.pubCustomY;
							val.Print(new object[1] { dgvItemCommercial[0, i].Value });
							val.CurrentX = 15f;
							val.CurrentY = num5 + Module1.pubCustomY;
							val.Print(new object[1] { dgvItemCommercial[1, i].Value });
							val.CurrentX = 110f - val.TextWidth(Conversions.ToString(dgvItemCommercial[2, i].Value));
							val.CurrentY = num5 + Module1.pubCustomY;
							val.Print(new object[1] { dgvItemCommercial[2, i].Value });
							val.CurrentX = 134f - val.TextWidth(Conversions.ToString(dgvItemCommercial[3, i].Value));
							val.CurrentY = num5 + Module1.pubCustomY;
							val.Print(new object[1] { dgvItemCommercial[3, i].Value });
							val.CurrentX = 139f;
							val.CurrentY = num5 + Module1.pubCustomY;
							val.Print(new object[1] { "Rp." });
							val.CurrentX = 165f - val.TextWidth(Conversions.ToString(dgvItemCommercial[4, i].Value));
							val.CurrentY = num5 + Module1.pubCustomY;
							val.Print(new object[1] { dgvItemCommercial[4, i].Value });
							val.CurrentX = 169f;
							val.CurrentY = num5 + Module1.pubCustomY;
							val.Print(new object[1] { "Rp." });
							val.CurrentX = 195f - val.TextWidth(Conversions.ToString(dgvItemCommercial[5, i].Value));
							val.CurrentY = num5 + Module1.pubCustomY;
							val.Print(new object[1] { dgvItemCommercial[5, i].Value });
							num5 += 5;
						}
						num4 = 169;
						num5 = (int)Math.Round(num3 + 89.0);
						int num9 = 195;
						val.CurrentX = 10f;
						val.CurrentY = num5 + Module1.pubCustomY;
						val.Print(new object[1] { "Jumlah Harga Jual" });
						val.CurrentX = num4;
						val.CurrentY = num5 + Module1.pubCustomY;
						val.Print(new object[1] { "Rp." });
						val.CurrentX = (float)num9 - val.TextWidth(lblTotalPriceCommercial.Text);
						val.CurrentY = num5 + Module1.pubCustomY;
						val.Print(new object[1] { lblTotalPriceCommercial.Text });
						num5 = (int)Math.Round(num3 + 94.0);
						if (Conversion.Val(lblDiscountValueCommercial.Text) > 0.0)
						{
							val.CurrentX = 10f;
							val.CurrentY = num5 + Module1.pubCustomY;
							val.Print(new object[1] { "Dikurangi Potongan Harga" });
						}
						val.CurrentX = num4;
						val.CurrentY = num5 + Module1.pubCustomY;
						val.Print(new object[1] { "Rp." });
						val.CurrentX = (float)num9 - val.TextWidth(lblDiscountValueCommercial.Text);
						val.CurrentY = num5 + Module1.pubCustomY;
						val.Print(new object[1] { lblDiscountValueCommercial.Text });
						num5 = (int)Math.Round(num3 + 99.0);
						val.CurrentX = num4;
						val.CurrentY = num5 + Module1.pubCustomY;
						val.Print(new object[1] { "Rp." });
						val.CurrentX = (float)num9 - val.TextWidth(lblDeductionCommercial.Text);
						val.CurrentY = num5 + Module1.pubCustomY;
						val.Print(new object[1] { lblDeductionCommercial.Text });
						num5 = (int)Math.Round(num3 + 104.0);
						val.CurrentX = 10f;
						val.CurrentY = num5 + Module1.pubCustomY;
						val.Print(new object[1] { "Jumlah yang harus di bayar" });
						val.CurrentX = num4;
						val.CurrentY = num5 + Module1.pubCustomY;
						val.Print(new object[1] { "Rp." });
						val.CurrentX = (float)num9 - val.TextWidth(lblTotalPaymentCommercial.Text);
						val.CurrentY = num5 + Module1.pubCustomY;
						val.Print(new object[1] { lblTotalPaymentCommercial.Text });
						num5 = (int)Math.Round(num3 + 110.0);
						val.CurrentX = 30f;
						val.CurrentY = num5 + Module1.pubCustomY;
						val.Print(new object[1] { "Tanda Terima," });
						val.CurrentX = 160f;
						val.CurrentY = num5 + Module1.pubCustomY;
						val.Print(new object[1] { "Hormat kami," });
						val.NewPage();
						val.EndDoc();
						goto end_IL_0001;
					}
					case 2809:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmPurchaseReturnPrint", "btnPrintCommercial_click", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 2809;
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

	private void btnPrintTax_Click(object sender, EventArgs e)
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
					Excel.Application application = (Excel.Application)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
					Workbook workbook = application.Workbooks.Open(System.Windows.Forms.Application.StartupPath + "\\templates\\MPajakRetur.xls", RuntimeHelpers.GetObjectValue(Missing.Value), true, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
					dgvItemTax.SelectAll();
					dgvItemTax.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
					Clipboard.SetDataObject(dgvItemTax.GetClipboardContent());
					dgvItemTax.ClearSelection();
					dgvItemTax.Rows[0].Selected = true;
					((_Application)application).get_Range((object)"A20", RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
					NewLateBinding.LateCall(application.ActiveSheet, null, "Paste", new object[0], null, null, null, IgnoreReturn: true);
					application.Cells[4, 3] = lblPurchaseReturnNo.Text;
					application.Cells[5, 3] = lblTaxInvoiceNo.Text;
					application.Cells[5, 6] = lblTaxInvoiceDate.Text;
					application.Cells[33, 6] = Module1.unformatNumber(lblDPP.Text);
					application.Cells[34, 6] = Module1.unformatNumber(lblPPN.Text);
					application.Cells[37, 6] = lblPurchaseReturnDate.Text;
					application.Visible = true;
					workbook = null;
					application = null;
					goto end_IL_0001;
				}
				case 580:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmPurchaseReturnPrint", "btnPrintTax_click", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 580;
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
