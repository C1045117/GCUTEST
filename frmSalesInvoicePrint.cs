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
public class frmSalesInvoicePrint : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnPrintLetter")]
	private Button _btnPrintLetter;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnPrintCommercial")]
	private Button _btnPrintCommercial;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnPrintTax")]
	private Button _btnPrintTax;

	private double _id;

	private string _taxAddress;

	private string _NPWP;

	private int _totalPrintCommercial;

	private int _totalPrintTax;

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

	[field: AccessedThroughProperty("TabPage2")]
	internal virtual TabPage TabPage2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCompanyName")]
	internal virtual Label lblCompanyName
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

	[field: AccessedThroughProperty("lblCompanyDetail3")]
	internal virtual Label lblCompanyDetail3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCompanyDetail2")]
	internal virtual Label lblCompanyDetail2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCompanyDetail1")]
	internal virtual Label lblCompanyDetail1
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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

	[field: AccessedThroughProperty("Label13")]
	internal virtual Label Label13
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

	[field: AccessedThroughProperty("txtDiscountDescription")]
	internal virtual TextBox txtDiscountDescription
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

	[field: AccessedThroughProperty("txtDiscountDescriptionTax")]
	internal virtual TextBox txtDiscountDescriptionTax
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPPN")]
	internal virtual Label lblPPN
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

	[field: AccessedThroughProperty("lblDiscountValueTax")]
	internal virtual Label lblDiscountValueTax
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

	[field: AccessedThroughProperty("lblTotalPriceTax")]
	internal virtual Label lblTotalPriceTax
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

	[field: AccessedThroughProperty("lblNPWP")]
	internal virtual Label lblNPWP
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAddressTax")]
	internal virtual Label lblAddressTax
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNameTax")]
	internal virtual Label lblNameTax
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

	[field: AccessedThroughProperty("lblYear")]
	internal virtual Label lblYear
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkNPPKP")]
	internal virtual CheckBox chkNPPKP
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

	[field: AccessedThroughProperty("txtTaxPersonName")]
	internal virtual TextBox txtTaxPersonName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDateTax")]
	internal virtual TextBox txtDateTax
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCityTax")]
	internal virtual TextBox txtCityTax
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDPP")]
	internal virtual TextBox txtDPP
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtStar")]
	internal virtual TextBox txtStar
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label17")]
	internal virtual Label Label17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label16")]
	internal virtual Label Label16
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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
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

	[field: AccessedThroughProperty("Label19")]
	internal virtual Label Label19
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label18")]
	internal virtual Label Label18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTotalPrintCommercial")]
	internal virtual Label lblTotalPrintCommercial
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTotalPrintTax")]
	internal virtual Label lblTotalPrintTax
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public double Id
	{
		get
		{
			return _id;
		}
		set
		{
			_id = value;
		}
	}

	public string TaxAddress
	{
		get
		{
			return _taxAddress;
		}
		set
		{
			_taxAddress = value;
		}
	}

	public string NPWP
	{
		get
		{
			return _NPWP;
		}
		set
		{
			_NPWP = value;
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
		this.TabControl1 = new System.Windows.Forms.TabControl();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.btnPrintLetter = new System.Windows.Forms.Button();
		this.dgvItemLetter = new System.Windows.Forms.DataGridView();
		this.lblInvoiceNoLetter = new System.Windows.Forms.Label();
		this.lblAddressLetter = new System.Windows.Forms.Label();
		this.lblNameLetter = new System.Windows.Forms.Label();
		this.lblYthLetter = new System.Windows.Forms.Label();
		this.lblDateLetter = new System.Windows.Forms.Label();
		this.TabPage2 = new System.Windows.Forms.TabPage();
		this.Label8 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.txtDiscountDescription = new System.Windows.Forms.TextBox();
		this.Label13 = new System.Windows.Forms.Label();
		this.lblTotalPaymentCommercial = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.lblDeductionCommercial = new System.Windows.Forms.Label();
		this.lblDiscountValueCommercial = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.lblTotalPriceCommercial = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.btnPrintCommercial = new System.Windows.Forms.Button();
		this.dgvItemCommercial = new System.Windows.Forms.DataGridView();
		this.lblInvoiceNoCommercial = new System.Windows.Forms.Label();
		this.lblAddressCommercial = new System.Windows.Forms.Label();
		this.lblNameCommercial = new System.Windows.Forms.Label();
		this.lblYthCommercial = new System.Windows.Forms.Label();
		this.lblDateCommercial = new System.Windows.Forms.Label();
		this.lblCompanyDetail3 = new System.Windows.Forms.Label();
		this.lblCompanyDetail2 = new System.Windows.Forms.Label();
		this.lblCompanyDetail1 = new System.Windows.Forms.Label();
		this.lblCompanyName = new System.Windows.Forms.Label();
		this.TabPage3 = new System.Windows.Forms.TabPage();
		this.Label21 = new System.Windows.Forms.Label();
		this.Label20 = new System.Windows.Forms.Label();
		this.Label19 = new System.Windows.Forms.Label();
		this.Label18 = new System.Windows.Forms.Label();
		this.Label17 = new System.Windows.Forms.Label();
		this.Label16 = new System.Windows.Forms.Label();
		this.Label15 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.chkNPPKP = new System.Windows.Forms.CheckBox();
		this.txtTaxPersonPosition = new System.Windows.Forms.TextBox();
		this.txtTaxPersonName = new System.Windows.Forms.TextBox();
		this.txtDateTax = new System.Windows.Forms.TextBox();
		this.txtCityTax = new System.Windows.Forms.TextBox();
		this.txtDPP = new System.Windows.Forms.TextBox();
		this.txtStar = new System.Windows.Forms.TextBox();
		this.txtDiscountDescriptionTax = new System.Windows.Forms.TextBox();
		this.lblPPN = new System.Windows.Forms.Label();
		this.lblDPP = new System.Windows.Forms.Label();
		this.lblDiscountValueTax = new System.Windows.Forms.Label();
		this.Label11 = new System.Windows.Forms.Label();
		this.lblTotalPriceTax = new System.Windows.Forms.Label();
		this.Label14 = new System.Windows.Forms.Label();
		this.btnPrintTax = new System.Windows.Forms.Button();
		this.dgvItemTax = new System.Windows.Forms.DataGridView();
		this.lblNPWP = new System.Windows.Forms.Label();
		this.lblAddressTax = new System.Windows.Forms.Label();
		this.lblNameTax = new System.Windows.Forms.Label();
		this.lblTaxInvoiceNo = new System.Windows.Forms.Label();
		this.lblYear = new System.Windows.Forms.Label();
		this.lblTotalPrintCommercial = new System.Windows.Forms.Label();
		this.lblTotalPrintTax = new System.Windows.Forms.Label();
		this.TabControl1.SuspendLayout();
		this.TabPage1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvItemLetter).BeginInit();
		this.TabPage2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvItemCommercial).BeginInit();
		this.TabPage3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvItemTax).BeginInit();
		base.SuspendLayout();
		this.TabControl1.Controls.Add(this.TabPage1);
		this.TabControl1.Controls.Add(this.TabPage2);
		this.TabControl1.Controls.Add(this.TabPage3);
		this.TabControl1.Location = new System.Drawing.Point(12, 12);
		this.TabControl1.Name = "TabControl1";
		this.TabControl1.SelectedIndex = 0;
		this.TabControl1.Size = new System.Drawing.Size(738, 467);
		this.TabControl1.TabIndex = 14;
		this.TabPage1.Controls.Add(this.btnPrintLetter);
		this.TabPage1.Controls.Add(this.dgvItemLetter);
		this.TabPage1.Controls.Add(this.lblInvoiceNoLetter);
		this.TabPage1.Controls.Add(this.lblAddressLetter);
		this.TabPage1.Controls.Add(this.lblNameLetter);
		this.TabPage1.Controls.Add(this.lblYthLetter);
		this.TabPage1.Controls.Add(this.lblDateLetter);
		this.TabPage1.Location = new System.Drawing.Point(4, 22);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage1.Size = new System.Drawing.Size(730, 441);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = "Surat Jalan";
		this.TabPage1.UseVisualStyleBackColor = true;
		this.btnPrintLetter.BackColor = System.Drawing.SystemColors.ButtonFace;
		this.btnPrintLetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnPrintLetter.Location = new System.Drawing.Point(651, 401);
		this.btnPrintLetter.Name = "btnPrintLetter";
		this.btnPrintLetter.Size = new System.Drawing.Size(61, 24);
		this.btnPrintLetter.TabIndex = 20;
		this.btnPrintLetter.Text = "Cetak";
		this.btnPrintLetter.UseVisualStyleBackColor = false;
		this.dgvItemLetter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvItemLetter.Location = new System.Drawing.Point(17, 106);
		this.dgvItemLetter.Name = "dgvItemLetter";
		this.dgvItemLetter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dgvItemLetter.Size = new System.Drawing.Size(695, 146);
		this.dgvItemLetter.TabIndex = 19;
		this.lblInvoiceNoLetter.AutoSize = true;
		this.lblInvoiceNoLetter.Location = new System.Drawing.Point(14, 90);
		this.lblInvoiceNoLetter.Name = "lblInvoiceNoLetter";
		this.lblInvoiceNoLetter.Size = new System.Drawing.Size(93, 13);
		this.lblInvoiceNoLetter.TabIndex = 18;
		this.lblInvoiceNoLetter.Text = "lblInvoiceNoLetter";
		this.lblAddressLetter.AutoSize = true;
		this.lblAddressLetter.Location = new System.Drawing.Point(407, 54);
		this.lblAddressLetter.Name = "lblAddressLetter";
		this.lblAddressLetter.Size = new System.Drawing.Size(82, 13);
		this.lblAddressLetter.TabIndex = 17;
		this.lblAddressLetter.Text = "lblAddressLetter";
		this.lblNameLetter.AutoSize = true;
		this.lblNameLetter.Location = new System.Drawing.Point(407, 41);
		this.lblNameLetter.Name = "lblNameLetter";
		this.lblNameLetter.Size = new System.Drawing.Size(72, 13);
		this.lblNameLetter.TabIndex = 16;
		this.lblNameLetter.Text = "lblNameLetter";
		this.lblYthLetter.AutoSize = true;
		this.lblYthLetter.Location = new System.Drawing.Point(407, 28);
		this.lblYthLetter.Name = "lblYthLetter";
		this.lblYthLetter.Size = new System.Drawing.Size(66, 13);
		this.lblYthLetter.TabIndex = 15;
		this.lblYthLetter.Text = "Kepada Yth,";
		this.lblDateLetter.AutoSize = true;
		this.lblDateLetter.Location = new System.Drawing.Point(407, 15);
		this.lblDateLetter.Name = "lblDateLetter";
		this.lblDateLetter.Size = new System.Drawing.Size(67, 13);
		this.lblDateLetter.TabIndex = 14;
		this.lblDateLetter.Text = "lblDateLetter";
		this.TabPage2.Controls.Add(this.lblTotalPrintCommercial);
		this.TabPage2.Controls.Add(this.Label8);
		this.TabPage2.Controls.Add(this.Label5);
		this.TabPage2.Controls.Add(this.txtDiscountDescription);
		this.TabPage2.Controls.Add(this.Label13);
		this.TabPage2.Controls.Add(this.lblTotalPaymentCommercial);
		this.TabPage2.Controls.Add(this.Label7);
		this.TabPage2.Controls.Add(this.lblDeductionCommercial);
		this.TabPage2.Controls.Add(this.lblDiscountValueCommercial);
		this.TabPage2.Controls.Add(this.Label3);
		this.TabPage2.Controls.Add(this.lblTotalPriceCommercial);
		this.TabPage2.Controls.Add(this.Label1);
		this.TabPage2.Controls.Add(this.btnPrintCommercial);
		this.TabPage2.Controls.Add(this.dgvItemCommercial);
		this.TabPage2.Controls.Add(this.lblInvoiceNoCommercial);
		this.TabPage2.Controls.Add(this.lblAddressCommercial);
		this.TabPage2.Controls.Add(this.lblNameCommercial);
		this.TabPage2.Controls.Add(this.lblYthCommercial);
		this.TabPage2.Controls.Add(this.lblDateCommercial);
		this.TabPage2.Controls.Add(this.lblCompanyDetail3);
		this.TabPage2.Controls.Add(this.lblCompanyDetail2);
		this.TabPage2.Controls.Add(this.lblCompanyDetail1);
		this.TabPage2.Controls.Add(this.lblCompanyName);
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
		this.txtDiscountDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtDiscountDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtDiscountDescription.Location = new System.Drawing.Point(159, 272);
		this.txtDiscountDescription.Name = "txtDiscountDescription";
		this.txtDiscountDescription.Size = new System.Drawing.Size(140, 21);
		this.txtDiscountDescription.TabIndex = 152;
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
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(20, 276);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(133, 13);
		this.Label3.TabIndex = 27;
		this.Label3.Text = "Dikurangi Potongan Harga";
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
		this.lblCompanyDetail3.AutoSize = true;
		this.lblCompanyDetail3.Location = new System.Drawing.Point(20, 59);
		this.lblCompanyDetail3.Name = "lblCompanyDetail3";
		this.lblCompanyDetail3.Size = new System.Drawing.Size(94, 13);
		this.lblCompanyDetail3.TabIndex = 3;
		this.lblCompanyDetail3.Text = "lblCompanyDetail3";
		this.lblCompanyDetail2.AutoSize = true;
		this.lblCompanyDetail2.Location = new System.Drawing.Point(20, 46);
		this.lblCompanyDetail2.Name = "lblCompanyDetail2";
		this.lblCompanyDetail2.Size = new System.Drawing.Size(94, 13);
		this.lblCompanyDetail2.TabIndex = 2;
		this.lblCompanyDetail2.Text = "lblCompanyDetail2";
		this.lblCompanyDetail1.AutoSize = true;
		this.lblCompanyDetail1.Location = new System.Drawing.Point(20, 33);
		this.lblCompanyDetail1.Name = "lblCompanyDetail1";
		this.lblCompanyDetail1.Size = new System.Drawing.Size(94, 13);
		this.lblCompanyDetail1.TabIndex = 1;
		this.lblCompanyDetail1.Text = "lblCompanyDetail1";
		this.lblCompanyName.AutoSize = true;
		this.lblCompanyName.Location = new System.Drawing.Point(20, 20);
		this.lblCompanyName.Name = "lblCompanyName";
		this.lblCompanyName.Size = new System.Drawing.Size(89, 13);
		this.lblCompanyName.TabIndex = 0;
		this.lblCompanyName.Text = "lblCompanyName";
		this.TabPage3.BackColor = System.Drawing.Color.Gainsboro;
		this.TabPage3.Controls.Add(this.lblTotalPrintTax);
		this.TabPage3.Controls.Add(this.Label21);
		this.TabPage3.Controls.Add(this.Label20);
		this.TabPage3.Controls.Add(this.Label19);
		this.TabPage3.Controls.Add(this.Label18);
		this.TabPage3.Controls.Add(this.Label17);
		this.TabPage3.Controls.Add(this.Label16);
		this.TabPage3.Controls.Add(this.Label15);
		this.TabPage3.Controls.Add(this.Label4);
		this.TabPage3.Controls.Add(this.Label2);
		this.TabPage3.Controls.Add(this.chkNPPKP);
		this.TabPage3.Controls.Add(this.txtTaxPersonPosition);
		this.TabPage3.Controls.Add(this.txtTaxPersonName);
		this.TabPage3.Controls.Add(this.txtDateTax);
		this.TabPage3.Controls.Add(this.txtCityTax);
		this.TabPage3.Controls.Add(this.txtDPP);
		this.TabPage3.Controls.Add(this.txtStar);
		this.TabPage3.Controls.Add(this.txtDiscountDescriptionTax);
		this.TabPage3.Controls.Add(this.lblPPN);
		this.TabPage3.Controls.Add(this.lblDPP);
		this.TabPage3.Controls.Add(this.lblDiscountValueTax);
		this.TabPage3.Controls.Add(this.Label11);
		this.TabPage3.Controls.Add(this.lblTotalPriceTax);
		this.TabPage3.Controls.Add(this.Label14);
		this.TabPage3.Controls.Add(this.btnPrintTax);
		this.TabPage3.Controls.Add(this.dgvItemTax);
		this.TabPage3.Controls.Add(this.lblNPWP);
		this.TabPage3.Controls.Add(this.lblAddressTax);
		this.TabPage3.Controls.Add(this.lblNameTax);
		this.TabPage3.Controls.Add(this.lblTaxInvoiceNo);
		this.TabPage3.Controls.Add(this.lblYear);
		this.TabPage3.Location = new System.Drawing.Point(4, 22);
		this.TabPage3.Name = "TabPage3";
		this.TabPage3.Size = new System.Drawing.Size(730, 441);
		this.TabPage3.TabIndex = 2;
		this.TabPage3.Text = "F. Pajak";
		this.Label21.AutoSize = true;
		this.Label21.Location = new System.Drawing.Point(530, 305);
		this.Label21.Name = "Label21";
		this.Label21.Size = new System.Drawing.Size(29, 13);
		this.Label21.TabIndex = 188;
		this.Label21.Text = "PPN";
		this.Label20.AutoSize = true;
		this.Label20.Location = new System.Drawing.Point(530, 278);
		this.Label20.Name = "Label20";
		this.Label20.Size = new System.Drawing.Size(29, 13);
		this.Label20.TabIndex = 187;
		this.Label20.Text = "DPP";
		this.Label19.AutoSize = true;
		this.Label19.Location = new System.Drawing.Point(530, 252);
		this.Label19.Name = "Label19";
		this.Label19.Size = new System.Drawing.Size(49, 13);
		this.Label19.TabIndex = 186;
		this.Label19.Text = "Discount";
		this.Label18.AutoSize = true;
		this.Label18.Location = new System.Drawing.Point(530, 225);
		this.Label18.Name = "Label18";
		this.Label18.Size = new System.Drawing.Size(63, 13);
		this.Label18.TabIndex = 185;
		this.Label18.Text = "Total Harga";
		this.Label17.AutoSize = true;
		this.Label17.Location = new System.Drawing.Point(26, 227);
		this.Label17.Name = "Label17";
		this.Label17.Size = new System.Drawing.Size(35, 13);
		this.Label17.TabIndex = 184;
		this.Label17.Text = "*******";
		this.Label16.AutoSize = true;
		this.Label16.Location = new System.Drawing.Point(223, 386);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(34, 13);
		this.Label16.TabIndex = 183;
		this.Label16.Text = "Posisi";
		this.Label15.AutoSize = true;
		this.Label15.Location = new System.Drawing.Point(223, 359);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(35, 13);
		this.Label15.TabIndex = 182;
		this.Label15.Text = "Nama";
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(372, 314);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(46, 13);
		this.Label4.TabIndex = 181;
		this.Label4.Text = "Tanggal";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(223, 314);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(29, 13);
		this.Label2.TabIndex = 180;
		this.Label2.Text = "Kota";
		this.chkNPPKP.AutoSize = true;
		this.chkNPPKP.Location = new System.Drawing.Point(550, 409);
		this.chkNPPKP.Name = "chkNPPKP";
		this.chkNPPKP.Size = new System.Drawing.Size(93, 17);
		this.chkNPPKP.TabIndex = 179;
		this.chkNPPKP.Text = "Cetak NPPKP";
		this.chkNPPKP.UseVisualStyleBackColor = true;
		this.txtTaxPersonPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtTaxPersonPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtTaxPersonPosition.Location = new System.Drawing.Point(291, 384);
		this.txtTaxPersonPosition.Name = "txtTaxPersonPosition";
		this.txtTaxPersonPosition.Size = new System.Drawing.Size(140, 20);
		this.txtTaxPersonPosition.TabIndex = 178;
		this.txtTaxPersonName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtTaxPersonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtTaxPersonName.Location = new System.Drawing.Point(291, 357);
		this.txtTaxPersonName.Name = "txtTaxPersonName";
		this.txtTaxPersonName.Size = new System.Drawing.Size(140, 20);
		this.txtTaxPersonName.TabIndex = 177;
		this.txtDateTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtDateTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtDateTax.Location = new System.Drawing.Point(372, 330);
		this.txtDateTax.Name = "txtDateTax";
		this.txtDateTax.Size = new System.Drawing.Size(140, 20);
		this.txtDateTax.TabIndex = 176;
		this.txtCityTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtCityTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtCityTax.Location = new System.Drawing.Point(226, 330);
		this.txtCityTax.Name = "txtCityTax";
		this.txtCityTax.Size = new System.Drawing.Size(140, 20);
		this.txtCityTax.TabIndex = 175;
		this.txtDPP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtDPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtDPP.Location = new System.Drawing.Point(82, 276);
		this.txtDPP.Name = "txtDPP";
		this.txtDPP.Size = new System.Drawing.Size(140, 20);
		this.txtDPP.TabIndex = 174;
		this.txtStar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtStar.Location = new System.Drawing.Point(82, 223);
		this.txtStar.Name = "txtStar";
		this.txtStar.Size = new System.Drawing.Size(140, 20);
		this.txtStar.TabIndex = 173;
		this.txtDiscountDescriptionTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtDiscountDescriptionTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtDiscountDescriptionTax.Location = new System.Drawing.Point(82, 249);
		this.txtDiscountDescriptionTax.Name = "txtDiscountDescriptionTax";
		this.txtDiscountDescriptionTax.Size = new System.Drawing.Size(140, 20);
		this.txtDiscountDescriptionTax.TabIndex = 172;
		this.lblPPN.Location = new System.Drawing.Point(566, 305);
		this.lblPPN.Name = "lblPPN";
		this.lblPPN.Size = new System.Drawing.Size(144, 13);
		this.lblPPN.TabIndex = 170;
		this.lblPPN.Text = "lblPPN";
		this.lblPPN.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.lblDPP.Location = new System.Drawing.Point(566, 278);
		this.lblDPP.Name = "lblDPP";
		this.lblDPP.Size = new System.Drawing.Size(144, 13);
		this.lblDPP.TabIndex = 169;
		this.lblDPP.Text = "lblDPP";
		this.lblDPP.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.lblDiscountValueTax.Location = new System.Drawing.Point(566, 252);
		this.lblDiscountValueTax.Name = "lblDiscountValueTax";
		this.lblDiscountValueTax.Size = new System.Drawing.Size(144, 13);
		this.lblDiscountValueTax.TabIndex = 168;
		this.lblDiscountValueTax.Text = "lblDiscountValueTax";
		this.lblDiscountValueTax.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.Label11.AutoSize = true;
		this.Label11.Location = new System.Drawing.Point(26, 253);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(49, 13);
		this.Label11.TabIndex = 167;
		this.Label11.Text = "Discount";
		this.lblTotalPriceTax.Location = new System.Drawing.Point(566, 225);
		this.lblTotalPriceTax.Name = "lblTotalPriceTax";
		this.lblTotalPriceTax.Size = new System.Drawing.Size(144, 13);
		this.lblTotalPriceTax.TabIndex = 166;
		this.lblTotalPriceTax.Text = "lblTotalPriceTax";
		this.lblTotalPriceTax.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.Label14.AutoSize = true;
		this.Label14.Location = new System.Drawing.Point(26, 278);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(29, 13);
		this.Label14.TabIndex = 165;
		this.Label14.Text = "DPP";
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
		this.lblNPWP.AutoSize = true;
		this.lblNPWP.Location = new System.Drawing.Point(20, 83);
		this.lblNPWP.Name = "lblNPWP";
		this.lblNPWP.Size = new System.Drawing.Size(50, 13);
		this.lblNPWP.TabIndex = 162;
		this.lblNPWP.Text = "lblNPWP";
		this.lblAddressTax.AutoSize = true;
		this.lblAddressTax.Location = new System.Drawing.Point(21, 52);
		this.lblAddressTax.Name = "lblAddressTax";
		this.lblAddressTax.Size = new System.Drawing.Size(73, 13);
		this.lblAddressTax.TabIndex = 161;
		this.lblAddressTax.Text = "lblAddressTax";
		this.lblNameTax.AutoSize = true;
		this.lblNameTax.Location = new System.Drawing.Point(21, 39);
		this.lblNameTax.Name = "lblNameTax";
		this.lblNameTax.Size = new System.Drawing.Size(63, 13);
		this.lblNameTax.TabIndex = 160;
		this.lblNameTax.Text = "lblNameTax";
		this.lblTaxInvoiceNo.AutoSize = true;
		this.lblTaxInvoiceNo.Location = new System.Drawing.Point(333, 15);
		this.lblTaxInvoiceNo.Name = "lblTaxInvoiceNo";
		this.lblTaxInvoiceNo.Size = new System.Drawing.Size(84, 13);
		this.lblTaxInvoiceNo.TabIndex = 159;
		this.lblTaxInvoiceNo.Text = "lblTaxInvoiceNo";
		this.lblYear.Location = new System.Drawing.Point(297, 15);
		this.lblYear.Name = "lblYear";
		this.lblYear.Size = new System.Drawing.Size(39, 13);
		this.lblYear.TabIndex = 158;
		this.lblYear.Text = "lblYear";
		this.lblYear.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.lblTotalPrintCommercial.AutoSize = true;
		this.lblTotalPrintCommercial.ForeColor = System.Drawing.Color.Red;
		this.lblTotalPrintCommercial.Location = new System.Drawing.Point(19, 402);
		this.lblTotalPrintCommercial.Name = "lblTotalPrintCommercial";
		this.lblTotalPrintCommercial.Size = new System.Drawing.Size(116, 13);
		this.lblTotalPrintCommercial.TabIndex = 155;
		this.lblTotalPrintCommercial.Text = "lblTotalPrintCommercial";
		this.lblTotalPrintTax.AutoSize = true;
		this.lblTotalPrintTax.ForeColor = System.Drawing.Color.Red;
		this.lblTotalPrintTax.Location = new System.Drawing.Point(26, 409);
		this.lblTotalPrintTax.Name = "lblTotalPrintTax";
		this.lblTotalPrintTax.Size = new System.Drawing.Size(80, 13);
		this.lblTotalPrintTax.TabIndex = 189;
		this.lblTotalPrintTax.Text = "lblTotalPrintTax";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(760, 490);
		base.Controls.Add(this.TabControl1);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSalesInvoicePrint";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Print Preview - Faktur Penjualan";
		this.TabControl1.ResumeLayout(false);
		this.TabPage1.ResumeLayout(false);
		this.TabPage1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvItemLetter).EndInit();
		this.TabPage2.ResumeLayout(false);
		this.TabPage2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvItemCommercial).EndInit();
		this.TabPage3.ResumeLayout(false);
		this.TabPage3.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvItemTax).EndInit();
		base.ResumeLayout(false);
	}

	public frmSalesInvoicePrint()
	{
		base.KeyDown += frmSalesInvoicePrint_KeyDown;
		base.Load += frmSalesInvoicePrint_Load;
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
		dgvItemCommercial.Columns.Add("", "No");
		dgvItemCommercial.Columns.Add("", "Nama Barang");
		dgvItemCommercial.Columns.Add("", "Kemasan");
		dgvItemCommercial.Columns.Add("", "Qty");
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
		dgvItemTax.Columns.Add("", "Qty(kecil)");
		dgvItemTax.Columns.Add("", "Kemasan(kecil)");
		dgvItemTax.Columns.Add("", "Total");
		dgvItemTax.Columns[0].Width = 30;
		dgvItemTax.Columns[1].Width = 180;
		dgvItemTax.Columns[2].Width = 100;
		dgvItemTax.Columns[3].Width = 100;
		dgvItemTax.Columns[4].Width = 100;
		dgvItemTax.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItemTax.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItemTax.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvItemTax.RowHeadersVisible = false;
		dgvItemTax.AllowUserToAddRows = false;
		dgvItemTax.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvItemTax.ReadOnly = true;
		dgvItemTax.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvItemTax.AllowUserToResizeRows = false;
	}

	private void frmSalesInvoicePrint_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void frmSalesInvoicePrint_Load(object sender, EventArgs e)
	{
		dgvItemLetter.CurrentRow.Selected = false;
		_totalPrintCommercial = cSalesInvoice.GetTotalPrint(_id, 1);
		_totalPrintTax = cSalesInvoice.GetTotalPrint(_id, 2);
		lblTotalPrintCommercial.Text = "Faktur Komersial telah dicetak sebanyak " + Conversions.ToString(_totalPrintCommercial) + " kali.";
		lblTotalPrintTax.Text = "Faktur Pajak telah dicetak sebanyak " + Conversions.ToString(_totalPrintTax) + " kali.";
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
						int num4 = 132;
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
							Module1.SaveError(Information.Err(), "frmSalesInvoicePrint", "btnPrintLetter_click", "");
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

	private void btnPrintCommercial_Click(object sender, EventArgs e)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
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
						ProjectData.ClearProjectError();
						num2 = 2;
						if (_totalPrintCommercial <= 0 || MessageBox.Show("Faktur Komersial sudah pernah dicetak. Apakah hendak dicetak ulang?", "Konfirmasi", MessageBoxButtons.YesNo) != DialogResult.No)
						{
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
							for (int i = num6; i <= num7; i++)
							{
								val.CurrentX = num4;
								val.CurrentY = num5 + Module1.pubCustomY;
								val.Print(new object[1] { array[i] });
								num5 += 4;
							}
							val.Font = new Font("Times New Roman", 11f);
							val.CurrentX = 5f;
							val.CurrentY = (float)(num3 + 28.0 + (double)Module1.pubCustomY);
							val.Print(new object[1] { lblInvoiceNoCommercial.Text });
							val.Font = new Font("Times New Roman", 9f);
							num5 = (int)Math.Round(num3 + 39.0);
							int num8 = dgvItemCommercial.RowCount - 1;
							for (int i = 0; i <= num8; i++)
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
								val.CurrentX = 136f - val.TextWidth(Conversions.ToString(dgvItemCommercial[3, i].Value));
								val.CurrentY = num5 + Module1.pubCustomY;
								val.Print(new object[1] { dgvItemCommercial[3, i].Value });
								val.CurrentX = 141f;
								val.CurrentY = num5 + Module1.pubCustomY;
								val.Print(new object[1] { "Rp." });
								val.CurrentX = 167f - val.TextWidth(Conversions.ToString(dgvItemCommercial[4, i].Value));
								val.CurrentY = num5 + Module1.pubCustomY;
								val.Print(new object[1] { dgvItemCommercial[4, i].Value });
								val.CurrentX = 171f;
								val.CurrentY = num5 + Module1.pubCustomY;
								val.Print(new object[1] { "Rp." });
								val.CurrentX = 197f - val.TextWidth(Conversions.ToString(dgvItemCommercial[5, i].Value));
								val.CurrentY = num5 + Module1.pubCustomY;
								val.Print(new object[1] { dgvItemCommercial[5, i].Value });
								num5 += 5;
							}
							num4 = 171;
							num5 = (int)Math.Round(num3 + 89.0);
							int num9 = 197;
							val.CurrentX = 10f;
							val.CurrentY = num5 + Module1.pubCustomY;
							val.CurrentX = num4;
							val.CurrentY = num5 + Module1.pubCustomY;
							val.Print(new object[1] { "Rp." });
							val.CurrentX = (float)num9 - val.TextWidth(lblTotalPriceCommercial.Text);
							val.CurrentY = num5 + Module1.pubCustomY;
							val.Print(new object[1] { lblTotalPriceCommercial.Text });
							if (Operators.CompareString(txtDiscountDescription.Text, "", TextCompare: false) != 0)
							{
								num5 = (int)Math.Round(num3 + 94.0);
								val.CurrentX = 10f;
								val.CurrentY = num5 + Module1.pubCustomY;
								val.Print(new object[1] { "Dikurangi Potongan Harga " + txtDiscountDescription.Text });
							}
							num5 = (int)Math.Round(num3 + 94.0);
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
							val.CurrentX = num4;
							val.CurrentY = num5 + Module1.pubCustomY;
							val.Print(new object[1] { "Rp." });
							val.CurrentX = (float)num9 - val.TextWidth(lblTotalPaymentCommercial.Text);
							val.CurrentY = num5 + Module1.pubCustomY;
							val.Print(new object[1] { lblTotalPaymentCommercial.Text });
							val.NewPage();
							val.EndDoc();
							cSalesInvoice.SetTotalPrint(_id, 1);
							_totalPrintCommercial++;
							lblTotalPrintCommercial.Text = "Faktur Komersial telah dicetak sebanyak " + Conversions.ToString(_totalPrintCommercial) + " kali.";
						}
						goto end_IL_0001;
					case 2153:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmSalesInvoicePrint", "btnPrintCommercial_click", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 2153;
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
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
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
						ProjectData.ClearProjectError();
						num2 = 2;
						if (_totalPrintTax <= 0 || MessageBox.Show("Faktur Pajak sudah pernah dicetak. Apakah hendak dicetak ulang?", "Konfirmasi", MessageBoxButtons.YesNo) != DialogResult.No)
						{
							Printer val = new Printer();
							val.ScaleMode = 6;
							val.CurrentX = 22f;
							val.CurrentY = 15f;
							val.Font = new Font("Times New Roman", 11f);
							val.CurrentX = 106f;
							val.CurrentY = 17f;
							val.Print(new object[1] { lblYear.Text + lblTaxInvoiceNo.Text });
							val.CurrentX = 32f;
							val.CurrentY = 32f;
							val.Print(new object[1] { lblCompanyName.Text });
							val.CurrentX = 32f;
							val.CurrentY = 42f;
							val.Font = new Font("Times New Roman", 10f);
							val.Print(new object[1] { _taxAddress });
							val.Font = new Font("Times New Roman", 11f);
							val.CurrentX = 32f;
							val.CurrentY = 52f;
							val.Print(new object[1] { _NPWP });
							val.CurrentX = 32f;
							val.CurrentY = 69f;
							val.Print(new object[1] { Module1.cleanString(lblNameTax.Text) });
							val.CurrentX = 32f;
							val.CurrentY = 77f;
							val.Font = new Font("Times New Roman", 10f);
							val.Print(new object[1] { Module1.cleanString(lblAddressTax.Text) });
							val.Font = new Font("Times New Roman", 11f);
							val.CurrentX = 32f;
							val.CurrentY = 83f;
							val.Print(new object[1] { Module1.cleanString(lblNPWP.Text) });
							val.CurrentX = 155f;
							val.CurrentY = 83f;
							if (chkNPPKP.Checked)
							{
								val.Print(new object[1] { Module1.cleanString(lblNPWP.Text) });
							}
							int num3 = 190;
							val.CurrentY = 100f;
							int num4 = dgvItemTax.RowCount - 1;
							for (int i = 0; i <= num4; i++)
							{
								val.CurrentX = 14f;
								int num5 = (int)Math.Round(val.CurrentY);
								val.Print(new object[1] { dgvItemTax[0, i].Value });
								val.CurrentX = 29f;
								val.CurrentY = num5;
								val.Print(new object[1] { dgvItemTax[1, i].Value });
								val.CurrentX = 90f;
								val.CurrentY = num5;
								val.Print(new object[1] { dgvItemTax[2, i].Value });
								val.CurrentX = 98f;
								val.CurrentY = num5;
								val.Print(new object[1] { dgvItemTax[3, i].Value });
								val.CurrentX = (float)num3 - val.TextWidth(Conversions.ToString(dgvItemTax[4, i].Value));
								val.CurrentY = num5;
								val.Print(new object[1] { Operators.ConcatenateObject(dgvItemTax[4, i].Value, ",-") });
							}
							val.CurrentX = 31f;
							val.CurrentY = 179f;
							val.Print(new object[1] { txtStar.Text });
							val.CurrentX = (float)num3 - val.TextWidth(lblTotalPriceTax.Text);
							val.CurrentY = 179f;
							val.Print(new object[1] { lblTotalPriceTax.Text + ",-" });
							val.CurrentX = 65f;
							val.CurrentY = 185f;
							val.Print(new object[1] { txtDiscountDescriptionTax.Text });
							val.CurrentX = (float)num3 - val.TextWidth(lblDiscountValueTax.Text);
							val.CurrentY = 185f;
							if (Operators.CompareString(lblDiscountValueTax.Text, "", TextCompare: false) != 0)
							{
								val.Print(new object[1] { lblDiscountValueTax.Text + ",-" });
							}
							else
							{
								val.Print(new object[1] { "-" });
							}
							val.CurrentX = num3;
							val.CurrentY = 190f;
							val.Print(new object[1] { "-" });
							val.Font = new Font("Times New Roman", 9f);
							val.CurrentX = 62f;
							val.CurrentY = 197f;
							val.Print(new object[1] { txtDPP.Text });
							val.Font = new Font("Times New Roman", 11f);
							val.CurrentX = (float)num3 - val.TextWidth(lblDPP.Text);
							val.CurrentY = 197f;
							val.Print(new object[1] { lblDPP.Text + ",-" });
							val.CurrentX = (float)num3 - val.TextWidth(lblPPN.Text);
							val.CurrentY = 203f;
							val.Print(new object[1] { lblPPN.Text + ",-" });
							val.CurrentX = 127f;
							val.CurrentY = 213f;
							val.Print(new object[1] { txtCityTax.Text });
							val.CurrentX = 165f;
							val.CurrentY = 213f;
							val.Print(new object[1] { txtDateTax.Text });
							val.CurrentX = 165f - val.TextWidth(Strings.Trim(txtTaxPersonName.Text)) / 2f;
							val.CurrentY = 240f;
							val.Print(new object[1] { txtTaxPersonName.Text });
							val.CurrentX = 165f - val.TextWidth(Strings.Trim(txtTaxPersonPosition.Text)) / 2f;
							val.CurrentY = 245f;
							val.Print(new object[1] { txtTaxPersonPosition.Text });
							val.NewPage();
							val.EndDoc();
							cSalesInvoice.SetTotalPrint(_id, 2);
							_totalPrintTax++;
							lblTotalPrintTax.Text = "Faktur Pajak telah dicetak sebanyak " + Conversions.ToString(_totalPrintTax) + " kali.";
						}
						goto end_IL_0001;
					case 2018:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmSalesInvoicePrint", "btnPrintTax_click", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 2018;
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
