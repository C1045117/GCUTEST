using System;
using System.Collections;
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
public class frmCustomerMiniSearch : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSearch")]
	private Button _btnSearch;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvList")]
	private DataGridView _dgvList;

	private string _callerName;

	private int _branchId;

	internal virtual Button btnSearch
	{
		[CompilerGenerated]
		get
		{
			return _btnSearch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnSearch_Click;
			Button button = _btnSearch;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnSearch = value;
			button = _btnSearch;
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
			EventHandler value3 = dgvList_GotFocus;
			EventHandler value4 = dgvList_LostFocus;
			EventHandler value5 = dgvList_DoubleClick;
			DataGridView dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.KeyDown -= value2;
				dataGridView.GotFocus -= value3;
				dataGridView.LostFocus -= value4;
				dataGridView.DoubleClick -= value5;
			}
			_dgvList = value;
			dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.KeyDown += value2;
				dataGridView.GotFocus += value3;
				dataGridView.LostFocus += value4;
				dataGridView.DoubleClick += value5;
			}
		}
	}

	[field: AccessedThroughProperty("txtName")]
	internal virtual TextBox txtName
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

	public string CallerName
	{
		get
		{
			return _callerName;
		}
		set
		{
			_callerName = value;
		}
	}

	public int BranchId
	{
		get
		{
			return _branchId;
		}
		set
		{
			_branchId = value;
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
		this.btnSearch = new System.Windows.Forms.Button();
		this.dgvList = new System.Windows.Forms.DataGridView();
		this.txtName = new System.Windows.Forms.TextBox();
		this.Label2 = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		base.SuspendLayout();
		this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSearch.Location = new System.Drawing.Point(50, 38);
		this.btnSearch.Name = "btnSearch";
		this.btnSearch.Size = new System.Drawing.Size(47, 24);
		this.btnSearch.TabIndex = 1;
		this.btnSearch.Text = "&Cari";
		this.btnSearch.UseVisualStyleBackColor = true;
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.Location = new System.Drawing.Point(50, 68);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(553, 183);
		this.dgvList.TabIndex = 2;
		this.txtName.Location = new System.Drawing.Point(50, 12);
		this.txtName.Name = "txtName";
		this.txtName.Size = new System.Drawing.Size(199, 20);
		this.txtName.TabIndex = 0;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(8, 15);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(35, 13);
		this.Label2.TabIndex = 33;
		this.Label2.Text = "Nama";
		base.AcceptButton = this.btnSearch;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(615, 263);
		base.Controls.Add(this.btnSearch);
		base.Controls.Add(this.dgvList);
		base.Controls.Add(this.txtName);
		base.Controls.Add(this.Label2);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmCustomerMiniSearch";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Cari Customer";
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmCustomerMiniSearch()
	{
		base.KeyDown += frmCustomerMiniSearch_KeyDown;
		InitializeComponent();
		DoubleBuffered = true;
	}

	private void frmCustomerMiniSearch_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void formatGrid()
	{
		dgvList.Columns.Clear();
		dgvList.Columns.Add("", "custId");
		dgvList.Columns.Add("", "branchId");
		dgvList.Columns.Add("", "Nama");
		dgvList.Columns.Add("", "Alamat");
		dgvList.Columns.Add("", "Wilayah");
		dgvList.Columns.Add("", "PT");
		dgvList.Columns.Add("", "NPWP");
		dgvList.Columns.Add("", "storeId");
		dgvList.Columns.Add("", "unpaidLimit");
		dgvList.Columns[0].Visible = false;
		dgvList.Columns[1].Visible = false;
		dgvList.Columns[2].Width = 210;
		dgvList.Columns[3].Width = 200;
		dgvList.Columns[4].Width = 120;
		dgvList.Columns[5].Visible = false;
		dgvList.Columns[6].Visible = false;
		dgvList.Columns[7].Visible = false;
		dgvList.Columns[8].Visible = false;
		dgvList.RowHeadersVisible = false;
		dgvList.AllowUserToAddRows = false;
		dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvList.ReadOnly = true;
		dgvList.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvList.AllowUserToResizeRows = false;
	}

	private void btnSearch_Click(object sender, EventArgs e)
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
					int isParent = 99;
					if ((Operators.CompareString(_callerName, "SalesOrder", TextCompare: false) == 0) | (Operators.CompareString(_callerName, "DeliveryOrder", TextCompare: false) == 0) | (Operators.CompareString(_callerName, "SalesInvoice", TextCompare: false) == 0) | (Operators.CompareString(_callerName, "SalesReturn", TextCompare: false) == 0) | (Operators.CompareString(_callerName, "SalesReceipt", TextCompare: false) == 0))
					{
						isParent = 0;
					}
					DataTable dataTable = cCustomer.Search(Module1.cleanString(txtName.Text), "", 0, 0, 0, 0, 0, 1, BelongToGroup: false, 0, Module1.pubGroupId, _branchId, 0, 0, isParent);
					formatGrid();
					dgvList.Rows.Clear();
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						dgvList.Rows.Add(dataRow["custId"], dataRow["branchId"], dataRow["custName"], dataRow["custAddress"], dataRow["wilName"], dataRow["custPT"], dataRow["custNPWP"], dataRow["storeId"], dataRow["custPiutang"]);
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					if (dataTable.Rows.Count == 0)
					{
						Interaction.MsgBox("Data tidak ditemukan", MsgBoxStyle.Information);
						txtName.Focus();
					}
					else
					{
						dgvList.Focus();
					}
					goto end_IL_0001;
				}
				case 524:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmCustomerMiniSearch", "btnSearch_click", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 524;
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

	private void dgvList_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			sendCustomer();
			e.SuppressKeyPress = true;
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			btnSearch.Focus();
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			txtName.Focus();
			e.SuppressKeyPress = true;
		}
	}

	private void dgvList_GotFocus(object sender, EventArgs e)
	{
		if (dgvList.RowCount > 0)
		{
			dgvList.CurrentRow.Selected = true;
		}
	}

	private void dgvList_LostFocus(object sender, EventArgs e)
	{
		if (dgvList.RowCount > 0)
		{
			dgvList.CurrentRow.Selected = false;
		}
	}

	private void dgvList_DoubleClick(object sender, EventArgs e)
	{
		sendCustomer();
	}

	public void sendCustomer()
	{
		if (dgvList.RowCount > 0 && Operators.ConditionalCompareObjectGreater(dgvList[0, dgvList.CurrentRow.Index].Value, 0, TextCompare: false))
		{
			if (Operators.CompareString(_callerName, "SalesOrder", TextCompare: false) == 0)
			{
				MyProject.Forms.frmSalesOrder.CustomerId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
			}
			else if (Operators.CompareString(_callerName, "DeliveryOrder", TextCompare: false) == 0)
			{
				MyProject.Forms.frmDeliveryOrder.CustomerId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
			}
			else if (Operators.CompareString(_callerName, "SalesInvoice", TextCompare: false) == 0)
			{
				MyProject.Forms.frmSalesInvoice.CustomerId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
			}
			else if (Operators.CompareString(_callerName, "SalesReturn", TextCompare: false) == 0)
			{
				MyProject.Forms.frmSalesReturn.CustomerId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
			}
			else if (Operators.CompareString(_callerName, "CustomerPayment", TextCompare: false) == 0)
			{
				MyProject.Forms.frmCustomerPayment.CustomerId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
			}
			else if (Operators.CompareString(_callerName, "SalesReceipt", TextCompare: false) == 0)
			{
				MyProject.Forms.frmSalesReceipt.CustomerId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
			}
			else if (Operators.CompareString(_callerName, "ReportSalesOrder", TextCompare: false) == 0)
			{
				MyProject.Forms.frmReportSalesOrder.CustomerId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
				MyProject.Forms.frmReportSalesOrder.lblCustomerName.Text = Conversions.ToString(dgvList[2, dgvList.CurrentRow.Index].Value);
			}
			else if (Operators.CompareString(_callerName, "ReportDeliveryOrder", TextCompare: false) == 0)
			{
				MyProject.Forms.frmReportDeliveryOrder.CustomerId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
				MyProject.Forms.frmReportDeliveryOrder.lblCustomerName.Text = Conversions.ToString(dgvList[2, dgvList.CurrentRow.Index].Value);
			}
			else if (Operators.CompareString(_callerName, "ReportSalesItem", TextCompare: false) == 0)
			{
				MyProject.Forms.frmReportSalesItem.CustomerId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
				MyProject.Forms.frmReportSalesItem.lblCustomerName.Text = Conversions.ToString(dgvList[2, dgvList.CurrentRow.Index].Value);
			}
			else if (Operators.CompareString(_callerName, "ReportSalesInvoice", TextCompare: false) == 0)
			{
				MyProject.Forms.frmReportSalesInvoice.CustomerId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
				MyProject.Forms.frmReportSalesInvoice.lblCustomerName.Text = Conversions.ToString(dgvList[2, dgvList.CurrentRow.Index].Value);
			}
			else if (Operators.CompareString(_callerName, "ReportSalesReturn", TextCompare: false) == 0)
			{
				MyProject.Forms.frmReportSalesReturn.CustomerId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
				MyProject.Forms.frmReportSalesReturn.lblCustomerName.Text = Conversions.ToString(dgvList[2, dgvList.CurrentRow.Index].Value);
			}
			else if (Operators.CompareString(_callerName, "ReportSalesReturnItem", TextCompare: false) == 0)
			{
				MyProject.Forms.frmReportSalesReturnItem.CustomerId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
				MyProject.Forms.frmReportSalesReturnItem.lblCustomerName.Text = Conversions.ToString(dgvList[2, dgvList.CurrentRow.Index].Value);
			}
			else if (Operators.CompareString(_callerName, "ReportReceivable", TextCompare: false) == 0)
			{
				MyProject.Forms.frmReportReceivable.CustomerId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
				MyProject.Forms.frmReportReceivable.lblCustomerName.Text = Conversions.ToString(dgvList[2, dgvList.CurrentRow.Index].Value);
			}
			else if (Operators.CompareString(_callerName, "ReportCustomerPayment", TextCompare: false) == 0)
			{
				MyProject.Forms.frmReportCustomerPayment.CustomerId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
				MyProject.Forms.frmReportCustomerPayment.lblCustomerName.Text = Conversions.ToString(dgvList[2, dgvList.CurrentRow.Index].Value);
			}
			else if (Operators.CompareString(_callerName, "ReportSalesReturnPayment", TextCompare: false) == 0)
			{
				MyProject.Forms.frmReportSalesReturnPayment.CustomerId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
				MyProject.Forms.frmReportSalesReturnPayment.lblCustomerName.Text = Conversions.ToString(dgvList[2, dgvList.CurrentRow.Index].Value);
			}
			Close();
		}
	}
}
