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
public class frmPurchaseInvoiceRI : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvList")]
	private DataGridView _dgvList;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSave")]
	private Button _btnSave;

	private int _supplierId;

	private double _invoiceId;

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

	public int SupplierId
	{
		get
		{
			return _supplierId;
		}
		set
		{
			_supplierId = value;
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
		this.dgvList = new System.Windows.Forms.DataGridView();
		this.btnSave = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		base.SuspendLayout();
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.Location = new System.Drawing.Point(12, 12);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(260, 238);
		this.dgvList.TabIndex = 18;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(211, 256);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(61, 24);
		this.btnSave.TabIndex = 19;
		this.btnSave.Text = "Update";
		this.btnSave.UseVisualStyleBackColor = true;
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(284, 288);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.dgvList);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmPurchaseInvoiceRI";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Daftar Penerimaan Barang";
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		base.ResumeLayout(false);
	}

	public frmPurchaseInvoiceRI(int SupplierId, double InvoiceId)
	{
		base.KeyDown += frmPurchaseInvoiceRI_KeyDown;
		InitializeComponent();
		_supplierId = SupplierId;
		_invoiceId = InvoiceId;
		LoadRI();
	}

	private void frmPurchaseInvoiceRI_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void LoadRI()
	{
		DataTable dataTable = cReceivedItem.Search(3, DateAndTime.Now, DateAndTime.Now, _supplierId, 0, Module1.pubGroupId, 0, _invoiceId, 0, 0, 0);
		FormatGrid();
		checked
		{
			foreach (DataRow row in dataTable.Rows)
			{
				bool flag = false;
				int num = MyProject.Forms.frmPurchaseInvoice.dgvItem.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmPurchaseInvoice.dgvItem[18, i].Value, row["riId"], TextCompare: false))
					{
						flag = true;
						break;
					}
				}
				dgvList.Rows.Add(row["riId"], flag, row["riDate"], row["riNumber"]);
			}
		}
	}

	private void FormatGrid()
	{
		dgvList.Columns.Clear();
		dgvList.Rows.Clear();
		DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
		dgvList.Columns.Add("", "riId");
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
		MyProject.Forms.frmPurchaseInvoice.RIId = new double[1];
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
					int num2 = MyProject.Forms.frmPurchaseInvoice.dgvItem.Rows.Count - 1;
					for (int j = 0; j <= num2; j++)
					{
						if (Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmPurchaseInvoice.dgvItem[18, j].Value, dgvList[0, i].Value, TextCompare: false))
						{
							flag = true;
							break;
						}
					}
					frmPurchaseInvoice frmPurchaseInvoice2;
					if (!flag)
					{
						cReceivedItem cReceivedItem2 = new cReceivedItem(Conversions.ToDouble(dgvList[0, i].Value));
						if (MyProject.Forms.frmPurchaseInvoice.cboStorage.SelectedIndex == -1)
						{
							ComboBox cboSource = (frmPurchaseInvoice2 = MyProject.Forms.frmPurchaseInvoice).cboStorage;
							Module1.comboBoundValue(ref cboSource, cReceivedItem2.StorageId);
							frmPurchaseInvoice2.cboStorage = cboSource;
						}
						cReceivedItemItem[] item = cReceivedItem2.Item;
						foreach (cReceivedItemItem cReceivedItemItem2 in item)
						{
							cItemPurchasePrice cItemPurchasePrice2 = new cItemPurchasePrice(cReceivedItemItem2.ItemId, _supplierId, DateAndTime.Now, 0.0, cReceivedItemItem2.UnitName);
							MyProject.Forms.frmPurchaseInvoice.dgvItem.Rows.Add(0, cReceivedItemItem2.ItemId, cReceivedItem2.StorageId, cReceivedItem2.StorageName, cReceivedItemItem2.ItemName, "", cReceivedItemItem2.RIQty, cReceivedItemItem2.UnitName, Module1.formatCustomDecimal(Conversions.ToString(cReceivedItemItem2.RIQty), 3) + " " + cReceivedItemItem2.UnitName, cReceivedItemItem2.StockQty, Module1.formatCustomDecimal(Conversions.ToString(cReceivedItemItem2.StockQty), 3) + " " + cReceivedItemItem2.BaseUnitName, 0, 0, cReceivedItemItem2.RIQty, Module1.formatCustomDecimal(Conversions.ToString(cItemPurchasePrice2.Price), 2), 0, Module1.formatCustomDecimal(Conversions.ToString(cReceivedItemItem2.RIQty * cItemPurchasePrice2.Price), 2), cReceivedItem2.Number, cReceivedItem2.Id, cReceivedItemItem2.Id, cReceivedItemItem2.InventoryAccountId);
						}
					}
					num3++;
					(frmPurchaseInvoice2 = MyProject.Forms.frmPurchaseInvoice).RIId = (double[])Utils.CopyArray(frmPurchaseInvoice2.RIId, new double[num3 + 1]);
					MyProject.Forms.frmPurchaseInvoice.RIId[num3] = Conversions.ToDouble(dgvList[0, i].Value);
					continue;
				}
				flag = false;
				int num4 = MyProject.Forms.frmPurchaseInvoice.dgvItem.Rows.Count - 1;
				for (int j = num4; j >= 0; j += -1)
				{
					if (Operators.ConditionalCompareObjectEqual(MyProject.Forms.frmPurchaseInvoice.dgvItem[18, j].Value, dgvList[0, i].Value, TextCompare: false))
					{
						MyProject.Forms.frmPurchaseInvoice.dgvItem.Rows.RemoveAt(j);
					}
				}
			}
			MyProject.Forms.frmPurchaseInvoice.calculateTotalPrice();
			Close();
		}
	}
}
