using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GCUv2.My;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

[DesignerGenerated]
public class frmSalesInvoiceDO : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSave")]
	private Button _btnSave;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvList")]
	private DataGridView _dgvList;

	private int _customerId;

	private double _invoiceId;

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
			KeyEventHandler value2 = dgvList_KeyDown;
			DataGridView dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.KeyDown -= value2;
			}
			_dgvList = value;
			dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.KeyDown += value2;
			}
		}
	}

	public int CustomerId
	{
		get
		{
			return _customerId;
		}
		set
		{
			_customerId = value;
		}
	}

	public double InvoiceId
	{
		get
		{
			return _invoiceId;
		}
		set
		{
			_invoiceId = value;
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
		this.btnSave = new System.Windows.Forms.Button();
		this.dgvList = new System.Windows.Forms.DataGridView();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		base.SuspendLayout();
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(211, 256);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(61, 24);
		this.btnSave.TabIndex = 1;
		this.btnSave.Text = "Update";
		this.btnSave.UseVisualStyleBackColor = true;
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.Location = new System.Drawing.Point(12, 12);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(260, 238);
		this.dgvList.TabIndex = 0;
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(285, 289);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.dgvList);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSalesInvoiceDO";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Daftar Pengiriman Pesanan";
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		base.ResumeLayout(false);
	}

	public frmSalesInvoiceDO(int customerId, double InvoiceId)
	{
		base.KeyDown += frmSalesInvoiceDO_KeyDown;
		InitializeComponent();
		_customerId = customerId;
		_invoiceId = InvoiceId;
		LoadData();
	}

	private void frmSalesInvoiceDO_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void LoadData()
	{
		DataTable dataTable = cDeliveryOrder.SearchAvailableDO(_customerId, _invoiceId);
		FormatGrid();
		checked
		{
			foreach (DataRow row in dataTable.Rows)
			{
				bool flag = false;
				int num = MyProject.Forms.frmSalesInvoice.dgvItem.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmSalesInvoice.dgvItem[17, i].Value, row["doId"], TextCompare: false))
					{
						flag = true;
						break;
					}
				}
				dgvList.Rows.Add(row["doId"], flag, row["doDate"], row["doNumber"]);
			}
		}
	}

	private void FormatGrid()
	{
		dgvList.Columns.Clear();
		dgvList.Rows.Clear();
		DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
		dgvList.Columns.Add("", "doId");
		dgvList.Columns.Add(dataGridViewCheckBoxColumn);
		dataGridViewCheckBoxColumn.HeaderText = "";
		dataGridViewCheckBoxColumn.Name = "chk";
		dgvList.Columns.Add("", "Tanggal");
		dgvList.Columns.Add("", "Nomer");
		dgvList.Columns[0].Visible = false;
		dgvList.Columns[0].Width = 0;
		dgvList.Columns[1].Width = 20;
		dgvList.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvList.Columns[2].Width = 80;
		dgvList.Columns[3].Width = 150;
		dgvList.Columns[2].ReadOnly = true;
		dgvList.Columns[3].ReadOnly = true;
		dgvList.RowHeadersVisible = false;
		dgvList.AllowUserToAddRows = false;
		dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvList.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvList.AllowUserToResizeRows = false;
	}

	private void dgvList_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			btnSave.Focus();
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			btnSave.Focus();
			e.SuppressKeyPress = true;
		}
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		MyProject.Forms.frmSalesInvoice.DOId = new double[1];
		checked
		{
			int num = dgvList.Rows.Count - 1;
			int num3 = default(int);
			for (int i = 0; i <= num; i++)
			{
				bool flag;
				if (Operators.ConditionalCompareObjectEqual(dgvList[1, i].EditedFormattedValue, true, TextCompare: false))
				{
					flag = false;
					int num2 = MyProject.Forms.frmSalesInvoice.dgvItem.Rows.Count - 1;
					for (int j = 0; j <= num2; j++)
					{
						if (Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmSalesInvoice.dgvItem[17, j].Value, dgvList[0, i].Value, TextCompare: false))
						{
							flag = true;
							break;
						}
					}
					frmSalesInvoice frmSalesInvoice2;
					if (!flag)
					{
						cDeliveryOrder cDeliveryOrder2 = new cDeliveryOrder(Conversions.ToDouble(dgvList[0, i].Value));
						ComboBox cboSource = (frmSalesInvoice2 = MyProject.Forms.frmSalesInvoice).cboStorage;
						Module1.comboBoundValue(ref cboSource, cDeliveryOrder2.StorageId);
						frmSalesInvoice2.cboStorage = cboSource;
						cDeliveryOrderItem[] item = cDeliveryOrder2.Item;
						foreach (cDeliveryOrderItem cDeliveryOrderItem2 in item)
						{
							cItemPrintDetail cItemPrintDetail2 = new cItemPrintDetail(cDeliveryOrderItem2.ItemId);
							double price = cSalesPriceCode.GetPrice(cDeliveryOrderItem2.ItemId, _customerId);
							MyProject.Forms.frmSalesInvoice.dgvItem.Rows.Add(cDeliveryOrderItem2.ItemId, cDeliveryOrderItem2.ItemName, "", Module1.formatCustomDecimal(Conversions.ToString(cDeliveryOrderItem2.DOQty), 3), Module1.formatCustomDecimal(Conversions.ToString(price), 2), Module1.formatCustomDecimal(Conversions.ToString(cDeliveryOrderItem2.DOQty * price), 2), price, cDeliveryOrderItem2.DOQty * price, cItemPrintDetail2.GeneralType, cItemPrintDetail2.LongName, cItemPrintDetail2.Packaging, cItemPrintDetail2.SmallUnit, cItemPrintDetail2.SmallQtyMultiplier, cItemPrintDetail2.LargeUnit, "", dgvList[3, i].Value, 0, dgvList[0, i].Value);
						}
					}
					num3++;
					(frmSalesInvoice2 = MyProject.Forms.frmSalesInvoice).DOId = (double[])Utils.CopyArray(frmSalesInvoice2.DOId, new double[num3 + 1]);
					MyProject.Forms.frmSalesInvoice.DOId[num3] = Conversions.ToDouble(dgvList[0, i].Value);
					continue;
				}
				flag = false;
				int num4 = MyProject.Forms.frmSalesInvoice.dgvItem.Rows.Count - 1;
				for (int j = num4; j >= 0; j += -1)
				{
					if (Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmSalesInvoice.dgvItem[17, j].Value, dgvList[0, i].Value, TextCompare: false))
					{
						MyProject.Forms.frmSalesInvoice.dgvItem.Rows.RemoveAt(j);
					}
				}
			}
			MyProject.Forms.frmSalesInvoice.calculateTotalPrice();
			MyProject.Forms.frmSalesInvoice.calculateDiscount();
			Close();
		}
	}
}
