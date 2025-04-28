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
public class frmReportCashBankDetail : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvList")]
	private DataGridView _dgvList;

	internal virtual DataGridView dgvList
	{
		[CompilerGenerated]
		get
		{
			return _dgvList;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = dgvList_DoubleClick;
			KeyEventHandler value3 = dgvList_KeyDown;
			DataGridView dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.DoubleClick -= value2;
				dataGridView.KeyDown -= value3;
			}
			_dgvList = value;
			dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.DoubleClick += value2;
				dataGridView.KeyDown += value3;
			}
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
		this.dgvList = new System.Windows.Forms.DataGridView();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		base.SuspendLayout();
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.Location = new System.Drawing.Point(12, 12);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(493, 305);
		this.dgvList.TabIndex = 185;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(517, 330);
		base.Controls.Add(this.dgvList);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmReportCashBankDetail";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Detail";
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		base.ResumeLayout(false);
	}

	public frmReportCashBankDetail()
	{
		base.KeyDown += frmReportCashBankDetail_KeyDown;
		InitializeComponent();
		base.MdiParent = MyProject.Forms.frmMenu;
	}

	private void frmReportCashBankDetail_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void dgvList_DoubleClick(object sender, EventArgs e)
	{
		getData();
	}

	private void dgvList_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			getData();
			e.SuppressKeyPress = true;
		}
	}

	private void getData()
	{
		if (Conversion.Val(RuntimeHelpers.GetObjectValue(dgvList[0, dgvList.CurrentRow.Index].Value)) == 1.0)
		{
			MyProject.Forms.frmSalesInvoice.Show();
			MyProject.Forms.frmSalesInvoice.prepareForm(SaveNew: false);
			MyProject.Forms.frmSalesInvoice.CurrentId = Conversions.ToDouble(dgvList[1, dgvList.CurrentRow.Index].Value);
			MyProject.Forms.frmSalesInvoice.LoadData();
			MyProject.Forms.frmSalesInvoice.Activate();
			MyProject.Forms.frmSalesInvoice.WindowState = FormWindowState.Normal;
		}
		else if (Conversion.Val(RuntimeHelpers.GetObjectValue(dgvList[0, dgvList.CurrentRow.Index].Value)) == 2.0)
		{
			MyProject.Forms.frmSalesReturn.Show();
			MyProject.Forms.frmSalesReturn.prepareForm(SaveNew: false);
			MyProject.Forms.frmSalesReturn.CurrentId = Conversions.ToDouble(dgvList[1, dgvList.CurrentRow.Index].Value);
			MyProject.Forms.frmSalesReturn.LoadData();
			MyProject.Forms.frmSalesReturn.Activate();
			MyProject.Forms.frmSalesReturn.WindowState = FormWindowState.Normal;
		}
		else if (Conversion.Val(RuntimeHelpers.GetObjectValue(dgvList[0, dgvList.CurrentRow.Index].Value)) == 3.0)
		{
			MyProject.Forms.frmPurchaseInvoice.Show();
			MyProject.Forms.frmPurchaseInvoice.prepareForm(SaveNew: false, KeepSupplier: false);
			MyProject.Forms.frmPurchaseInvoice.CurrentId = Conversions.ToDouble(dgvList[1, dgvList.CurrentRow.Index].Value);
			MyProject.Forms.frmPurchaseInvoice.LoadData();
			MyProject.Forms.frmPurchaseInvoice.Activate();
			MyProject.Forms.frmPurchaseInvoice.WindowState = FormWindowState.Normal;
		}
		else if (Conversion.Val(RuntimeHelpers.GetObjectValue(dgvList[0, dgvList.CurrentRow.Index].Value)) == 4.0)
		{
			MyProject.Forms.frmPurchaseReturn.Show();
			MyProject.Forms.frmPurchaseReturn.prepareForm(SaveNew: false, KeepSupplier: false);
			MyProject.Forms.frmPurchaseReturn.CurrentId = Conversions.ToDouble(dgvList[1, dgvList.CurrentRow.Index].Value);
			MyProject.Forms.frmPurchaseReturn.LoadData();
			MyProject.Forms.frmPurchaseReturn.Activate();
			MyProject.Forms.frmPurchaseReturn.WindowState = FormWindowState.Normal;
		}
	}

	public void LoadCustomerPayment(DateTime FirstDate, DateTime LastDate, int CashAccountId, int SalesId, int AreaId, int PaymentType)
	{
		DataTable dataTable = cCashAccount.CustomerPayment(FirstDate, LastDate, CashAccountId, SalesId, AreaId, PaymentType);
		FormatPaymentGrid(1);
		double num = default(double);
		foreach (DataRow row in dataTable.Rows)
		{
			dgvList.Rows.Add(Operators.ConditionalCompareObjectEqual(row["penjBsType"], 0, TextCompare: false) ? 1 : 2, row["penjId"], row["pbDate"], row["penjFaktur"], row["custName"], Module1.formatCustomDecimal(Conversions.ToString(row["pbAmount"]), 2));
			num = Conversions.ToDouble(Operators.AddObject(num, row["pbAmount"]));
		}
		dgvList.Rows.Add("", "", "", "Total", "", Module1.formatCustomDecimal(Conversions.ToString(num), 2));
	}

	public void LoadSupplierPayment(DateTime FirstDate, DateTime LastDate, int CashAccountId, int SupplierId)
	{
		DataTable dataTable = cCashAccount.SupplierPayment(FirstDate, LastDate, CashAccountId, SupplierId);
		FormatPaymentGrid(2);
		double num = default(double);
		foreach (DataRow row in dataTable.Rows)
		{
			dgvList.Rows.Add(Operators.ConditionalCompareObjectEqual(row["invIsReturn"], 0, TextCompare: false) ? 3 : 4, row["invId"], row["payDate"], row["invNumber"], row["supName"], Module1.formatCustomDecimal(Conversions.ToString(row["payAmount"]), 2));
			num = Conversions.ToDouble(Operators.AddObject(num, row["payAmount"]));
		}
		dgvList.Rows.Add("", "", "", "Total", "", Module1.formatCustomDecimal(Conversions.ToString(num), 2));
	}

	private void FormatPaymentGrid(int CustomerSupplier)
	{
		dgvList.Rows.Clear();
		dgvList.Columns.Clear();
		dgvList.Columns.Add("", "CustomerSupplier");
		dgvList.Columns.Add("", "id");
		dgvList.Columns.Add("", "Tanggal");
		dgvList.Columns.Add("", "No Faktur");
		if (CustomerSupplier == 1)
		{
			dgvList.Columns.Add("", "Customer");
		}
		else
		{
			dgvList.Columns.Add("", "Supplier");
		}
		dgvList.Columns.Add("", "Jumlah Bayar");
		dgvList.Columns[0].Visible = false;
		dgvList.Columns[1].Visible = false;
		dgvList.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvList.Columns[2].Width = 68;
		dgvList.Columns[3].Width = 100;
		dgvList.Columns[4].Width = 180;
		dgvList.Columns[5].Width = 90;
		dgvList.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.RowHeadersVisible = false;
		dgvList.AllowUserToAddRows = false;
		dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvList.ReadOnly = true;
		dgvList.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvList.AllowUserToResizeRows = false;
		dgvList.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Regular);
		foreach (object column in dgvList.Columns)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(column);
			NewLateBinding.LateSet(objectValue, null, "SortMode", new object[1] { DataGridViewColumnSortMode.NotSortable }, null, null);
		}
	}
}
