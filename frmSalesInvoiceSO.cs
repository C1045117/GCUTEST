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
public class frmSalesInvoiceSO : Form
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
			DataGridViewCellEventHandler value3 = dgvList_CellContentClick;
			DataGridView dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.KeyDown -= value2;
				dataGridView.CellContentClick -= value3;
			}
			_dgvList = value;
			dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.KeyDown += value2;
				dataGridView.CellContentClick += value3;
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
		this.btnSave.Location = new System.Drawing.Point(265, 256);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(61, 24);
		this.btnSave.TabIndex = 1;
		this.btnSave.Text = "Update";
		this.btnSave.UseVisualStyleBackColor = true;
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.Location = new System.Drawing.Point(12, 12);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(314, 238);
		this.dgvList.TabIndex = 0;
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(338, 288);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.dgvList);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSalesInvoiceSO";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Daftar Pesanan Penjualan";
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		base.ResumeLayout(false);
	}

	public frmSalesInvoiceSO(int customerId, double InvoiceId)
	{
		base.KeyDown += frmSalesInvoiceSO_KeyDown;
		InitializeComponent();
		_customerId = customerId;
		_invoiceId = InvoiceId;
		LoadData();
	}

	private void frmSalesInvoiceSO_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void LoadData()
	{
		DataTable dataTable = cSalesOrder.Search(5, DateAndTime.Now, DateAndTime.Now, _customerId, Module1.pubGroupId, 0, _invoiceId);
		FormatGrid();
		checked
		{
			foreach (DataRow row in dataTable.Rows)
			{
				bool flag = false;
				int num = MyProject.Forms.frmSalesInvoice.dgvItem.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmSalesInvoice.dgvItem[16, i].Value, row["soId"], TextCompare: false))
					{
						flag = true;
						break;
					}
				}
				dgvList.Rows.Add(row["soId"], flag, row["soDate"], row["poNumber"], Module1.formatCustomDecimal(Conversions.ToString(Operators.SubtractObject(row["soTotalPrice"], row["soDiscount"])), 2));
			}
		}
	}

	private void FormatGrid()
	{
		dgvList.Columns.Clear();
		dgvList.Rows.Clear();
		DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
		dgvList.Columns.Add("", "soId");
		dgvList.Columns.Add(dataGridViewCheckBoxColumn);
		dataGridViewCheckBoxColumn.HeaderText = "";
		dataGridViewCheckBoxColumn.Name = "chk";
		dgvList.Columns.Add("", "Tanggal");
		dgvList.Columns.Add("", "Nomer PO");
		dgvList.Columns.Add("", "Total");
		dgvList.Columns[0].Visible = false;
		dgvList.Columns[0].Width = 0;
		dgvList.Columns[1].Width = 20;
		dgvList.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvList.Columns[2].Width = 80;
		dgvList.Columns[3].Width = 120;
		dgvList.Columns[4].Width = 80;
		dgvList.Columns[2].ReadOnly = true;
		dgvList.Columns[3].ReadOnly = true;
		dgvList.Columns[4].ReadOnly = true;
		dgvList.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
		MyProject.Forms.frmSalesInvoice.SOId = new double[1];
		bool flag = false;
		checked
		{
			int num = dgvList.Rows.Count - 1;
			int num3 = default(int);
			for (int i = 0; i <= num; i++)
			{
				bool flag2;
				if (Operators.ConditionalCompareObjectEqual(dgvList[1, i].EditedFormattedValue, true, TextCompare: false))
				{
					flag2 = false;
					int num2 = MyProject.Forms.frmSalesInvoice.dgvItem.Rows.Count - 1;
					for (int j = 0; j <= num2; j++)
					{
						if (Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmSalesInvoice.dgvItem[16, j].Value, dgvList[0, i].Value, TextCompare: false))
						{
							flag2 = true;
							break;
						}
					}
					if (!flag2)
					{
						cSalesOrder cSalesOrder2 = new cSalesOrder(Conversions.ToDouble(dgvList[0, i].Value));
						if (MyProject.Forms.frmSalesInvoice.CurrentId == 0.0)
						{
							cComboItem cComboItem2 = (cComboItem)MyProject.Forms.frmSalesInvoice.cboStorage.SelectedItem;
							cSalesOrderItem[] item = cSalesOrder2.Item;
							foreach (cSalesOrderItem cSalesOrderItem2 in item)
							{
								if (!cValidation.isInStock(Module1.pubCheckStock, Module1.pubBalanceDate, MyProject.Forms.frmSalesInvoice.dtpInvoice.Value, "not_used", MyProject.Forms.frmSalesInvoice.OriginalDate, cSalesOrderItem2.ItemId, 0, cSalesOrderItem2.Qty, 0.0, Conversions.ToInteger(cComboItem2.Value), 0, Module1.pubGroupId, 2))
								{
									Interaction.MsgBox("Stok " + cSalesOrderItem2.ItemName + " tidak tersedia.", MsgBoxStyle.Information);
									return;
								}
							}
						}
						cSalesOrderItem[] item2 = cSalesOrder2.Item;
						foreach (cSalesOrderItem cSalesOrderItem3 in item2)
						{
							cItemPrintDetail cItemPrintDetail2 = new cItemPrintDetail(cSalesOrderItem3.ItemId);
							MyProject.Forms.frmSalesInvoice.dgvItem.Rows.Add(cSalesOrderItem3.ItemId, cSalesOrderItem3.ItemName, "", Module1.formatCustomDecimal(Conversions.ToString(cSalesOrderItem3.Qty), 3), Module1.formatCustomDecimal(Conversions.ToString(cSalesOrderItem3.Price), 2), Module1.formatCustomDecimal(Conversions.ToString(cSalesOrderItem3.Qty * cSalesOrderItem3.Price), 2), cSalesOrderItem3.Price, cSalesOrderItem3.Qty * cSalesOrderItem3.Price, cItemPrintDetail2.GeneralType, cItemPrintDetail2.LongName, cItemPrintDetail2.Packaging, cItemPrintDetail2.SmallUnit, cItemPrintDetail2.SmallQtyMultiplier, cItemPrintDetail2.LargeUnit, dgvList[3, i].Value, "", dgvList[0, i].Value, 0);
						}
						MyProject.Forms.frmSalesInvoice.txtDiscountValue.Text = Module1.formatCustomDecimal(Conversions.ToString(cSalesOrder2.Discount), 2);
						MyProject.Forms.frmSalesInvoice.txtDiscountDescription.Text = cSalesOrder2.DiscountDescription;
						flag = true;
					}
					num3++;
					frmSalesInvoice frmSalesInvoice2;
					(frmSalesInvoice2 = MyProject.Forms.frmSalesInvoice).SOId = (double[])Utils.CopyArray(frmSalesInvoice2.SOId, new double[num3 + 1]);
					MyProject.Forms.frmSalesInvoice.SOId[num3] = Conversions.ToDouble(dgvList[0, i].Value);
					continue;
				}
				flag2 = false;
				int num4 = MyProject.Forms.frmSalesInvoice.dgvItem.Rows.Count - 1;
				for (int j = num4; j >= 0; j += -1)
				{
					if (Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmSalesInvoice.dgvItem[16, j].Value, dgvList[0, i].Value, TextCompare: false))
					{
						MyProject.Forms.frmSalesInvoice.dgvItem.Rows.RemoveAt(j);
						if (!flag)
						{
							MyProject.Forms.frmSalesInvoice.txtDiscountValue.Text = "";
							MyProject.Forms.frmSalesInvoice.txtDiscountDescription.Text = "";
						}
					}
				}
			}
			MyProject.Forms.frmSalesInvoice.calculateTotalPrice();
			Close();
		}
	}

	private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		dgvList.EndEdit();
		if (e.ColumnIndex != 1 || !Operators.ConditionalCompareObjectEqual(dgvList[1, dgvList.CurrentRow.Index].Value, true, TextCompare: false))
		{
			return;
		}
		checked
		{
			int num = dgvList.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (i != dgvList.CurrentRow.Index)
				{
					dgvList[1, i].Value = false;
				}
			}
		}
	}
}
