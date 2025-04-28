using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GCUv2.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using MigraDoc.RtfRendering;
using MySql.Data.MySqlClient;

namespace GCUv2;

[DesignerGenerated]
public class frmMenu : Form
{
	private bool _logout;

	private MySqlDataAdapter mysqlAdapter;

	private DataTable mysqlTable;

	private DataSet ds;

	private MySqlCommand SqlCmd;

	private DataTable changes;

	private MySqlCommandBuilder cb;

	private MySqlConnection dbCon;

	private string strQuery;

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSave")]
	private Button _btnSave;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvList")]
	private DataGridView _dgvList;

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button1_Click;
			Button button = _Button1;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("txtHost")]
	internal virtual TextBox txtHost
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button2
	{
		[CompilerGenerated]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button2_Click;
			Button button = _Button2;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button2 = value;
			button = _Button2;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("btnDataReader")]
	internal virtual Button btnDataReader
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

	[field: AccessedThroughProperty("Button3")]
	internal virtual Button Button3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MenuStrip1")]
	internal virtual MenuStrip MenuStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridView1")]
	internal virtual DataGridView DataGridView1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button4
	{
		[CompilerGenerated]
		get
		{
			return _Button4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button4_Click;
			Button button = _Button4;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button4 = value;
			button = _Button4;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button5
	{
		[CompilerGenerated]
		get
		{
			return _Button5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button5_Click;
			Button button = _Button5;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button5 = value;
			button = _Button5;
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

	public frmMenu()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		base.KeyDown += frmMenu_KeyDown;
		base.Load += frmMenu_Load;
		base.FormClosing += frmMenu_FormClosing;
		mysqlAdapter = new MySqlDataAdapter();
		mysqlTable = new DataTable();
		ds = new DataSet();
		SqlCmd = new MySqlCommand();
		changes = new DataTable();
		strQuery = "";
		InitializeComponent();
	}

	private void frmMenu_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void frmMenu_Load(object sender, EventArgs e)
	{
		DoubleBuffered = true;
		_logout = false;
		DataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
		MyProject.Forms.frmInformation.Show();
		string strSql = " SELECT * FROM pages  WHERE parentId = 0  AND pageMenu <> ''  AND (pageId IN    (SELECT pageId FROM groups_pages WHERE groupId = " + Conversions.ToString(Module1.pubGroupId) + " ) OR pageAlways=1)  ORDER BY pagePriority, pageName ";
		DataTable dataTable = new DataTable();
		DataTable dataTable2 = new DataTable();
		DataTable dataTable3 = new DataTable();
		dataTable = Module1.sqlTable(strSql, "read", Clone: false);
		checked
		{
			ToolStripMenuItem[] array = new ToolStripMenuItem[dataTable.Rows.Count + 1];
			foreach (DataRow row in dataTable.Rows)
			{
				string text = Conversions.ToString(row["pageMenu"]);
				int num = dataTable.Rows.IndexOf(row);
				array[num] = new ToolStripMenuItem(text);
				MenuStrip1.Items.Add(array[num]);
				array[num].Click += MenuItemClicked;
				strSql = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" SELECT * FROM pages  WHERE parentId = ", row["pageId"]), " AND pageMenu <> '' "), " AND (pageId IN  "), "  (SELECT pageId FROM groups_pages WHERE groupId = "), Module1.pubGroupId), " ) OR pageAlways=1) "), " ORDER BY pagePriority, pageName "));
				dataTable2 = Module1.sqlTable(strSql, "read", Clone: false);
				ToolStripMenuItem[] array2 = new ToolStripMenuItem[dataTable2.Rows.Count + 1];
				foreach (DataRow row2 in dataTable2.Rows)
				{
					text = Conversions.ToString(row2["pageMenu"]);
					int num2 = dataTable2.Rows.IndexOf(row2);
					array2[num2] = new ToolStripMenuItem(text);
					array[num].DropDownItems.Add(array2[num2]);
					if (Operators.ConditionalCompareObjectEqual(row2["pageSeparator"], 1, TextCompare: false))
					{
						array[num].DropDownItems.Add("-");
					}
					array2[num2].Click += MenuItemClicked;
					if (!Operators.ConditionalCompareObjectEqual(row2["pageIsParent"], 1, TextCompare: false))
					{
						continue;
					}
					strSql = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" SELECT * FROM pages  WHERE parentId = ", row2["pageId"]), " AND pageMenu <> '' "), " AND (pageId IN  "), "  (SELECT pageId FROM groups_pages WHERE groupId = "), Module1.pubGroupId), " ) OR pageAlways=1) "), " ORDER BY pagePriority, pageName "));
					dataTable3 = Module1.sqlTable(strSql, "read", Clone: false);
					ToolStripMenuItem[] array3 = new ToolStripMenuItem[dataTable3.Rows.Count + 1];
					foreach (DataRow row3 in dataTable3.Rows)
					{
						text = Conversions.ToString(row3["pageMenu"]);
						int num3 = dataTable3.Rows.IndexOf(row3);
						array3[num3] = new ToolStripMenuItem(text);
						array2[num2].DropDownItems.Add(array3[num3]);
						if (Operators.ConditionalCompareObjectEqual(row3["pageSeparator"], 1, TextCompare: false))
						{
							array2[num2].DropDownItems.Add("-");
						}
						array3[num3].Click += MenuItemClicked;
					}
				}
			}
		}
	}

	private void MenuItemClicked(object sender, EventArgs e)
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
					string text = sender.ToString();
					if (!Module1.pubDatabaseIsConnected & (Operators.CompareString(text, "&Logout", TextCompare: false) != 0))
					{
						Interaction.MsgBox("Database tidak terkoneksi. Silahkan coba tekan tombol 'Restart koneksi'", MsgBoxStyle.Information);
						goto end_IL_0001;
					}
					MyProject.Forms.frmTransferList.MdiParent = this;
					MyProject.Forms.frmSettingAdjustmentTypeList.MdiParent = this;
					switch (text)
					{
					case "Cari Customer":
						MyProject.Forms.frmCustomerSearch.Show();
						MyProject.Forms.frmCustomerSearch.Activate();
						MyProject.Forms.frmCustomerSearch.WindowState = FormWindowState.Normal;
						break;
					case "Pesanan Penjualan":
						MyProject.Forms.frmSalesOrderList.Show();
						MyProject.Forms.frmSalesOrderList.Activate();
						MyProject.Forms.frmSalesOrderList.WindowState = FormWindowState.Normal;
						break;
					case "Pengiriman Pesanan":
						MyProject.Forms.frmDeliveryOrderList.Show();
						MyProject.Forms.frmDeliveryOrderList.Activate();
						MyProject.Forms.frmDeliveryOrderList.WindowState = FormWindowState.Normal;
						break;
					case "Faktur Penjualan":
						MyProject.Forms.frmSalesInvoiceList.Show();
						MyProject.Forms.frmSalesInvoiceList.Activate();
						MyProject.Forms.frmSalesInvoiceList.WindowState = FormWindowState.Normal;
						break;
					case "Retur Penjualan":
						MyProject.Forms.frmSalesReturnList.Show();
						MyProject.Forms.frmSalesReturnList.Activate();
						MyProject.Forms.frmSalesReturnList.WindowState = FormWindowState.Normal;
						break;
					case "Pembayaran Customer":
						Cursor = Cursors.WaitCursor;
						MyProject.Forms.frmCustomerPaymentList.Show();
						MyProject.Forms.frmCustomerPaymentList.Activate();
						MyProject.Forms.frmCustomerPaymentList.WindowState = FormWindowState.Normal;
						Cursor = Cursors.Default;
						break;
					case "Kuitansi":
						MyProject.Forms.frmSalesReceiptList.Show();
						MyProject.Forms.frmSalesReceiptList.Activate();
						MyProject.Forms.frmSalesReceiptList.WindowState = FormWindowState.Normal;
						break;
					case "Cari Supplier":
						MyProject.Forms.frmSupplierSearch.Show();
						MyProject.Forms.frmSupplierSearch.Activate();
						MyProject.Forms.frmSupplierSearch.WindowState = FormWindowState.Normal;
						break;
					case "Penerimaan Barang":
						MyProject.Forms.frmReceivedItemList.Show();
						MyProject.Forms.frmReceivedItemList.Activate();
						MyProject.Forms.frmReceivedItemList.WindowState = FormWindowState.Normal;
						break;
					case "Faktur Pem&belian":
						MyProject.Forms.frmPurchaseInvoiceList.Show();
						MyProject.Forms.frmPurchaseInvoiceList.Activate();
						MyProject.Forms.frmPurchaseInvoiceList.WindowState = FormWindowState.Normal;
						break;
					case "Retur Pembelian":
						MyProject.Forms.frmPurchaseReturnList.Show();
						MyProject.Forms.frmPurchaseReturnList.Activate();
						MyProject.Forms.frmPurchaseReturnList.WindowState = FormWindowState.Normal;
						break;
					case "Pemba&yaran Supplier":
						MyProject.Forms.frmSupplierPaymentList.Show();
						MyProject.Forms.frmSupplierPaymentList.Activate();
						MyProject.Forms.frmSupplierPaymentList.WindowState = FormWindowState.Normal;
						break;
					case "Penyesu&aian":
						MyProject.Forms.frmAdjustmentList.Show();
						MyProject.Forms.frmAdjustmentList.Activate();
						MyProject.Forms.frmAdjustmentList.WindowState = FormWindowState.Normal;
						break;
					case "&Produksi":
						MyProject.Forms.frmProcessList.Show();
						MyProject.Forms.frmProcessList.Activate();
						MyProject.Forms.frmProcessList.WindowState = FormWindowState.Normal;
						break;
					case "&Transfer":
						MyProject.Forms.frmTransferList.Show();
						MyProject.Forms.frmTransferList.Activate();
						MyProject.Forms.frmTransferList.WindowState = FormWindowState.Normal;
						break;
					case "Pen&ggunaan":
						MyProject.Forms.frmUsageList.Show();
						MyProject.Forms.frmUsageList.Activate();
						MyProject.Forms.frmUsageList.WindowState = FormWindowState.Normal;
						break;
					case "Transaksi Kas":
						MyProject.Forms.frmCashTransactionList.Show();
						MyProject.Forms.frmCashTransactionList.Activate();
						MyProject.Forms.frmCashTransactionList.WindowState = FormWindowState.Normal;
						break;
					case "Transaksi Bank":
						MyProject.Forms.frmBankTransactionList.Show();
						MyProject.Forms.frmBankTransactionList.Activate();
						MyProject.Forms.frmBankTransactionList.WindowState = FormWindowState.Normal;
						break;
					case "Setor Cek/Giro":
						MyProject.Forms.frmChequeInList.Show();
						MyProject.Forms.frmChequeInList.Activate();
						MyProject.Forms.frmChequeInList.WindowState = FormWindowState.Normal;
						break;
					case "Bukti Jurnal Umum":
						MyProject.Forms.frmJournalTransactionList.Show();
						MyProject.Forms.frmJournalTransactionList.Activate();
						MyProject.Forms.frmJournalTransactionList.WindowState = FormWindowState.Normal;
						break;
					case "Report Penerimaan Barang":
						MyProject.Forms.frmReportReceivedItem.Show();
						MyProject.Forms.frmReportReceivedItem.Activate();
						MyProject.Forms.frmReportReceivedItem.WindowState = FormWindowState.Normal;
						break;
					case "Report Faktur Pem&belian":
						MyProject.Forms.frmReportPurchaseInvoice.Show();
						MyProject.Forms.frmReportPurchaseInvoice.Activate();
						MyProject.Forms.frmReportPurchaseInvoice.WindowState = FormWindowState.Normal;
						break;
					case "Report Pembelian per Barang":
						MyProject.Forms.frmReportPurchaseItem.Show();
						MyProject.Forms.frmReportPurchaseItem.Activate();
						MyProject.Forms.frmReportPurchaseItem.WindowState = FormWindowState.Normal;
						break;
					case "Report Retur Pembelian":
						MyProject.Forms.frmReportPurchaseReturn.Show();
						MyProject.Forms.frmReportPurchaseReturn.Activate();
						MyProject.Forms.frmReportPurchaseReturn.WindowState = FormWindowState.Normal;
						break;
					case "Report Tagihan &Kembang":
						MyProject.Forms.frmReportSupplierTransactionFlower.Show();
						MyProject.Forms.frmReportSupplierTransactionFlower.Activate();
						MyProject.Forms.frmReportSupplierTransactionFlower.WindowState = FormWindowState.Normal;
						break;
					case "Report Pemba&yaran Supplier":
						MyProject.Forms.frmReportSupplierPayment.Show();
						MyProject.Forms.frmReportSupplierPayment.Activate();
						MyProject.Forms.frmReportSupplierPayment.WindowState = FormWindowState.Normal;
						break;
					case "Report Pembayaran Retur Pembelian":
						MyProject.Forms.frmReportPurchaseReturnPayment.Show();
						MyProject.Forms.frmReportPurchaseReturnPayment.Activate();
						MyProject.Forms.frmReportPurchaseReturnPayment.WindowState = FormWindowState.Normal;
						break;
					case "Report Kebutuhan Bahan":
						MyProject.Forms.frmReportProductionPrediction.Show();
						MyProject.Forms.frmReportProductionPrediction.Activate();
						MyProject.Forms.frmReportProductionPrediction.WindowState = FormWindowState.Normal;
						break;
					case "Report &Produksi":
						MyProject.Forms.frmReportProcess.Show();
						MyProject.Forms.frmReportProcess.Activate();
						MyProject.Forms.frmReportProcess.WindowState = FormWindowState.Normal;
						break;
					case "Report Komponen":
						MyProject.Forms.frmReportComponent.Show();
						MyProject.Forms.frmReportComponent.Activate();
						MyProject.Forms.frmReportComponent.WindowState = FormWindowState.Normal;
						break;
					case "Report Penyesu&aian":
						MyProject.Forms.frmReportAdjustment.Show();
						MyProject.Forms.frmReportAdjustment.Activate();
						MyProject.Forms.frmReportAdjustment.WindowState = FormWindowState.Normal;
						break;
					case "Report &Transfer":
						MyProject.Forms.frmReportTransfer.Show();
						MyProject.Forms.frmReportTransfer.Activate();
						MyProject.Forms.frmReportTransfer.WindowState = FormWindowState.Normal;
						break;
					case "Report Pesanan Penjualan":
						MyProject.Forms.frmReportSalesOrder.Show();
						MyProject.Forms.frmReportSalesOrder.Activate();
						MyProject.Forms.frmReportSalesOrder.WindowState = FormWindowState.Normal;
						break;
					case "Report Pengiriman Pesanan":
						MyProject.Forms.frmReportDeliveryOrder.Show();
						MyProject.Forms.frmReportDeliveryOrder.Activate();
						MyProject.Forms.frmReportDeliveryOrder.WindowState = FormWindowState.Normal;
						break;
					case "Report Faktur Penjualan":
						MyProject.Forms.frmReportSalesInvoice.Show();
						MyProject.Forms.frmReportSalesInvoice.Activate();
						MyProject.Forms.frmReportSalesInvoice.WindowState = FormWindowState.Normal;
						break;
					case "Report Penjualan per Barang":
						MyProject.Forms.frmReportSalesItem.Show();
						MyProject.Forms.frmReportSalesItem.Activate();
						MyProject.Forms.frmReportSalesItem.WindowState = FormWindowState.Normal;
						break;
					case "Report Retur Penjualan":
						MyProject.Forms.frmReportSalesReturn.Show();
						MyProject.Forms.frmReportSalesReturn.Activate();
						MyProject.Forms.frmReportSalesReturn.WindowState = FormWindowState.Normal;
						break;
					case "Report Retur Penjualan per Barang":
						MyProject.Forms.frmReportSalesReturnItem.Show();
						MyProject.Forms.frmReportSalesReturnItem.Activate();
						MyProject.Forms.frmReportSalesReturnItem.WindowState = FormWindowState.Normal;
						break;
					case "Report Pembayaran Faktur":
						MyProject.Forms.frmReportSalesInvoicePayment.Show();
						MyProject.Forms.frmReportSalesInvoicePayment.Activate();
						MyProject.Forms.frmReportSalesInvoicePayment.WindowState = FormWindowState.Normal;
						break;
					case "Report Pembayaran Customer":
						MyProject.Forms.frmReportCustomerPayment.Show();
						MyProject.Forms.frmReportCustomerPayment.Activate();
						MyProject.Forms.frmReportCustomerPayment.WindowState = FormWindowState.Normal;
						break;
					case "Report Pembayaran Retur Penjualan":
						MyProject.Forms.frmReportSalesReturnPayment.Show();
						MyProject.Forms.frmReportSalesReturnPayment.Activate();
						MyProject.Forms.frmReportSalesReturnPayment.WindowState = FormWindowState.Normal;
						break;
					case "Report Penjualan Sales":
						MyProject.Forms.frmReportSalesPerson.Show();
						MyProject.Forms.frmReportSalesPerson.Activate();
						MyProject.Forms.frmReportSalesPerson.WindowState = FormWindowState.Normal;
						break;
					case "Report Kuitansi":
						MyProject.Forms.frmReportSalesReceipt.Show();
						MyProject.Forms.frmReportSalesReceipt.Activate();
						MyProject.Forms.frmReportSalesReceipt.WindowState = FormWindowState.Normal;
						break;
					case "Report Piutang":
						MyProject.Forms.frmReportReceivable.Show();
						MyProject.Forms.frmReportReceivable.Activate();
						MyProject.Forms.frmReportReceivable.WindowState = FormWindowState.Normal;
						break;
					case "Report Kolektor":
						MyProject.Forms.frmReportCollector.Show();
						MyProject.Forms.frmReportCollector.Activate();
						MyProject.Forms.frmReportCollector.WindowState = FormWindowState.Normal;
						break;
					case "Report Kunjungan":
						MyProject.Forms.frmReportCustomerVisit.Show();
						MyProject.Forms.frmReportCustomerVisit.Activate();
						MyProject.Forms.frmReportCustomerVisit.WindowState = FormWindowState.Normal;
						break;
					case "Report &Stok":
						MyProject.Forms.frmReportStock.Show();
						MyProject.Forms.frmReportStock.Activate();
						MyProject.Forms.frmReportStock.WindowState = FormWindowState.Normal;
						break;
					case "Report Pen&ggunaan":
						MyProject.Forms.frmReportUsage.Show();
						MyProject.Forms.frmReportUsage.Activate();
						MyProject.Forms.frmReportUsage.WindowState = FormWindowState.Normal;
						break;
					case "Report Standar Penggunaan":
						MyProject.Forms.frmReportVariance.Show();
						MyProject.Forms.frmReportVariance.Activate();
						MyProject.Forms.frmReportVariance.WindowState = FormWindowState.Normal;
						break;
					case "Report Cek/Giro Keluar":
						MyProject.Forms.frmReportChequeOut.Show();
						MyProject.Forms.frmReportChequeOut.Activate();
						MyProject.Forms.frmReportChequeOut.WindowState = FormWindowState.Normal;
						break;
					case "Report Cek/Giro Masuk":
						MyProject.Forms.frmReportChequeIn.Show();
						MyProject.Forms.frmReportChequeIn.Activate();
						MyProject.Forms.frmReportChequeIn.WindowState = FormWindowState.Normal;
						break;
					case "Report Transaksi Kas":
						MyProject.Forms.frmReportCashTransaction.Show();
						MyProject.Forms.frmReportCashTransaction.Activate();
						MyProject.Forms.frmReportCashTransaction.WindowState = FormWindowState.Normal;
						break;
					case "Report Transaksi Bank":
						MyProject.Forms.frmReportBankTransaction.Show();
						MyProject.Forms.frmReportBankTransaction.Activate();
						MyProject.Forms.frmReportBankTransaction.WindowState = FormWindowState.Normal;
						break;
					case "Report Bukti Jurnal Umum":
						MyProject.Forms.frmReportJournalTransaction.Show();
						MyProject.Forms.frmReportJournalTransaction.Activate();
						MyProject.Forms.frmReportJournalTransaction.WindowState = FormWindowState.Normal;
						break;
					case "Report Buku Kas":
						MyProject.Forms.frmReportCashBook.Show();
						MyProject.Forms.frmReportCashBook.Activate();
						MyProject.Forms.frmReportCashBook.WindowState = FormWindowState.Normal;
						break;
					case "Report Buku Bank":
						MyProject.Forms.frmReportBankBook.Show();
						MyProject.Forms.frmReportBankBook.Activate();
						MyProject.Forms.frmReportBankBook.WindowState = FormWindowState.Normal;
						break;
					case "Jurnal Umum":
						MyProject.Forms.frmReportGeneralJournal.Show();
						MyProject.Forms.frmReportGeneralJournal.Activate();
						MyProject.Forms.frmReportGeneralJournal.WindowState = FormWindowState.Normal;
						break;
					case "Report History":
						MyProject.Forms.frmReportHistory.Show();
						MyProject.Forms.frmReportHistory.Activate();
						MyProject.Forms.frmReportHistory.WindowState = FormWindowState.Normal;
						break;
					case "Report Aktivitas Produksi":
						MyProject.Forms.frmReportProductionActivity.Show();
						MyProject.Forms.frmReportProductionActivity.Activate();
						MyProject.Forms.frmReportProductionActivity.WindowState = FormWindowState.Normal;
						break;
					case "Report Nomer Faktur":
						MyProject.Forms.frmReportInvoiceNumber.Show();
						MyProject.Forms.frmReportInvoiceNumber.Activate();
						MyProject.Forms.frmReportInvoiceNumber.WindowState = FormWindowState.Normal;
						break;
					case "Report Rangkuman Marketing":
						MyProject.Forms.frmReportMarketingSummary.Show();
						MyProject.Forms.frmReportMarketingSummary.Activate();
						MyProject.Forms.frmReportMarketingSummary.WindowState = FormWindowState.Normal;
						break;
					case "Ganti Password":
						MyProject.Forms.frmSettingChangePassword.Show();
						MyProject.Forms.frmSettingChangePassword.Activate();
						MyProject.Forms.frmSettingChangePassword.WindowState = FormWindowState.Normal;
						break;
					case "User":
						MyProject.Forms.frmSettingUserList.Show();
						MyProject.Forms.frmSettingUserList.Activate();
						MyProject.Forms.frmSettingUserList.WindowState = FormWindowState.Normal;
						break;
					case "Cabang":
						MyProject.Forms.frmSettingBranchList.Show();
						MyProject.Forms.frmSettingBranchList.Activate();
						MyProject.Forms.frmSettingBranchList.WindowState = FormWindowState.Normal;
						break;
					case "Gudang":
						MyProject.Forms.frmSettingStorageList.Show();
						MyProject.Forms.frmSettingStorageList.Activate();
						MyProject.Forms.frmSettingStorageList.WindowState = FormWindowState.Normal;
						break;
					case "Kode Harga":
						MyProject.Forms.frmSettingSalesPriceCodeList.Show();
						MyProject.Forms.frmSettingSalesPriceCodeList.Activate();
						MyProject.Forms.frmSettingSalesPriceCodeList.WindowState = FormWindowState.Normal;
						break;
					case "Kode Customer":
						MyProject.Forms.frmSettingCustomerCodeList.Show();
						MyProject.Forms.frmSettingCustomerCodeList.Activate();
						MyProject.Forms.frmSettingCustomerCodeList.WindowState = FormWindowState.Normal;
						break;
					case "Batas Piutang && T.O.P":
						MyProject.Forms.frmSettingDropDown.Show();
						MyProject.Forms.frmSettingDropDown.Activate();
						MyProject.Forms.frmSettingDropDown.WindowState = FormWindowState.Normal;
						break;
					case "Bank":
						MyProject.Forms.frmSettingBankList.Show();
						MyProject.Forms.frmSettingBankList.Activate();
						MyProject.Forms.frmSettingBankList.WindowState = FormWindowState.Normal;
						break;
					case "Wilayah":
						MyProject.Forms.frmSettingAreaList.Show();
						MyProject.Forms.frmSettingAreaList.Activate();
						MyProject.Forms.frmSettingAreaList.WindowState = FormWindowState.Normal;
						break;
					case "Sales":
						MyProject.Forms.frmSettingSalesPersonList.Show();
						MyProject.Forms.frmSettingSalesPersonList.Activate();
						MyProject.Forms.frmSettingSalesPersonList.WindowState = FormWindowState.Normal;
						break;
					case "Diskon":
						MyProject.Forms.frmSettingDiscountList.Show();
						MyProject.Forms.frmSettingDiscountList.Activate();
						MyProject.Forms.frmSettingDiscountList.WindowState = FormWindowState.Normal;
						break;
					case "Detail Pencetakan":
						MyProject.Forms.frmSettingPrint.Show();
						MyProject.Forms.frmSettingPrint.Activate();
						MyProject.Forms.frmSettingPrint.WindowState = FormWindowState.Normal;
						break;
					case "Minimum Stok":
						MyProject.Forms.frmSettingMinimumStock.Show();
						MyProject.Forms.frmSettingMinimumStock.Activate();
						MyProject.Forms.frmSettingMinimumStock.WindowState = FormWindowState.Normal;
						break;
					case "No. Faktur Komersial":
						MyProject.Forms.frmSettingInvoiceNumber.Show();
						MyProject.Forms.frmSettingInvoiceNumber.Activate();
						MyProject.Forms.frmSettingInvoiceNumber.WindowState = FormWindowState.Normal;
						break;
					case "No. Faktur Pajak":
						MyProject.Forms.frmSettingTaxInvoiceNumber.Show();
						MyProject.Forms.frmSettingTaxInvoiceNumber.Activate();
						MyProject.Forms.frmSettingTaxInvoiceNumber.WindowState = FormWindowState.Normal;
						break;
					case "No. Retur Pajak":
						MyProject.Forms.frmSettingReturnTaxInvoiceNumber.Show();
						MyProject.Forms.frmSettingReturnTaxInvoiceNumber.Activate();
						MyProject.Forms.frmSettingReturnTaxInvoiceNumber.WindowState = FormWindowState.Normal;
						break;
					case "Mata Uang":
						MyProject.Forms.frmSettingCurrencyList.Show();
						MyProject.Forms.frmSettingCurrencyList.Activate();
						MyProject.Forms.frmSettingCurrencyList.WindowState = FormWindowState.Normal;
						break;
					case "Akun":
						MyProject.Forms.frmSettingAccountList.Show();
						MyProject.Forms.frmSettingAccountList.Activate();
						MyProject.Forms.frmSettingAccountList.WindowState = FormWindowState.Normal;
						break;
					case "Tipe Penyesuaian":
						MyProject.Forms.frmSettingAdjustmentTypeList.Show();
						MyProject.Forms.frmSettingAdjustmentTypeList.Activate();
						MyProject.Forms.frmSettingAdjustmentTypeList.WindowState = FormWindowState.Normal;
						break;
					case "Urutan Produksi":
						MyProject.Forms.frmSettingProductionStepInput.Show();
						MyProject.Forms.frmSettingProductionStepInput.Activate();
						MyProject.Forms.frmSettingProductionStepInput.WindowState = FormWindowState.Normal;
						break;
					case "Barang":
						MyProject.Forms.frmSettingItemList.Show();
						MyProject.Forms.frmSettingItemList.Activate();
						MyProject.Forms.frmSettingItemList.WindowState = FormWindowState.Normal;
						break;
					case "Kategori Barang":
						MyProject.Forms.frmSettingItemCategoryList.Show();
						MyProject.Forms.frmSettingItemCategoryList.Activate();
						MyProject.Forms.frmSettingItemCategoryList.WindowState = FormWindowState.Normal;
						break;
					case "Grup":
						Cursor = Cursors.WaitCursor;
						MyProject.Forms.frmSettingGroup.Show();
						MyProject.Forms.frmSettingGroup.Activate();
						MyProject.Forms.frmSettingGroup.WindowState = FormWindowState.Normal;
						Cursor = Cursors.Default;
						break;
					case "Penghapusan Data":
						MyProject.Forms.frmSettingCloseData.Show();
						MyProject.Forms.frmSettingCloseData.Activate();
						MyProject.Forms.frmSettingCloseData.WindowState = FormWindowState.Normal;
						break;
					case "Umum":
						MyProject.Forms.frmSettingGeneral.Show();
						MyProject.Forms.frmSettingGeneral.Activate();
						MyProject.Forms.frmSettingGeneral.WindowState = FormWindowState.Normal;
						break;
					case "&Logout":
						if (MessageBox.Show("Logout dari program?", "Konfirmasi", MessageBoxButtons.YesNo) != DialogResult.No)
						{
							_logout = true;
							MyProject.Forms.frmLogin.Show();
							MyProject.Forms.frmInformation.BackgroundWorker1.CancelAsync();
							MyProject.Forms.frmInformation.Close();
							Close();
						}
						break;
					}
					goto end_IL_0001;
				}
				case 6828:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmMenu", "MenuItemClicked", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 6828;
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

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		string text = "";
		DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		MySqlConnection val = new MySqlConnection("Server=" + txtHost.Text + ";Database=gcu_marketing;Uid=root;Pwd=adi");
		text = "select * from userlist";
		SqlCmd.CommandText = text;
		SqlCmd.Connection = val;
		val.Open();
		mysqlAdapter.SelectCommand = SqlCmd;
		((DbDataAdapter)(object)mysqlAdapter).Fill(ds, "penjualan");
		DataGridView1.DataSource = ds.Tables[0];
		val.Close();
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		DataGridView1.DataSource = null;
		DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dbCon = new MySqlConnection("Server=" + txtHost.Text + ";Database=gcu_marketing;Uid=root;Pwd=adi");
		strQuery = "select * from userlist";
		SqlCmd = new MySqlCommand(strQuery, dbCon);
		dbCon.Open();
		cb = new MySqlCommandBuilder(mysqlAdapter);
		mysqlAdapter.SelectCommand = SqlCmd;
		((DbDataAdapter)(object)mysqlAdapter).Fill(mysqlTable);
		DataGridView1.DataSource = mysqlTable;
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		if (mysqlTable.GetChanges() != null)
		{
			Interaction.MsgBox("save");
			((DbDataAdapter)(object)mysqlAdapter).Update(mysqlTable);
		}
		else
		{
			Interaction.MsgBox("no change");
		}
	}

	private void DataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
	{
		string headerText = DataGridView1.Columns[e.ColumnIndex].HeaderText;
		if (headerText.Equals("UserLogin") && string.IsNullOrEmpty(e.FormattedValue.ToString()))
		{
			DataGridView1.Rows[e.RowIndex].ErrorText = "User Name must not be empty";
			e.Cancel = true;
		}
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		Document val = new Document();
		Section val2 = new Section();
		val2 = val.AddSection();
		val2.AddParagraph("Testing migradoc");
		val2.AddParagraph();
		val2.AddParagraph("Second sentence");
		val2.AddParagraph();
		RtfDocumentRenderer val3 = new RtfDocumentRenderer();
		PdfDocumentRenderer val4 = new PdfDocumentRenderer();
		val4.Document = val;
		Table val5 = new Table();
		val5.Borders.Width = Unit.op_Implicit(0.75);
		Column val6 = new Column();
		val6 = val5.AddColumn(Unit.FromCentimeter(2.0));
		val6.Format.Alignment = (ParagraphAlignment)1;
		val5.AddColumn(Unit.FromCentimeter(5.0));
		Row val7 = new Row();
		val7 = val5.AddRow();
		val7.Shading.Color = Colors.PaleGoldenrod;
		val7.HeadingFormat = true;
		Cell val8 = new Cell();
		val8 = val7.Cells[0];
		val8.AddParagraph("Itemus");
		val8 = val7.Cells[1];
		val8.AddParagraph("Descriptum");
		int i = default(int);
		for (; i < 50; i = checked(i + 1))
		{
			val7 = val5.AddRow();
			val7.Shading.Color = Colors.PapayaWhip;
			val8 = val7.Cells[0];
			val8.AddParagraph("1");
			val8 = val7.Cells[1];
			val8.AddParagraph("number one very very long sentence can it cope it?");
			val7 = val5.AddRow();
			val8 = val7.Cells[0];
			val8.AddParagraph("2");
			val8 = val7.Cells[1];
			val8.AddParagraph("number two");
		}
		val.LastSection.Add(val5);
		Paragraph val9 = new Paragraph();
		val9.Format.Alignment = (ParagraphAlignment)1;
		val9.AddText("Page ");
		val9.AddPageField();
		val9.AddText(" of ");
		val9.AddNumPagesField();
		val2.Footers.Primary.Add(val9);
		val4.RenderDocument();
		val4.PdfDocument.Save(Application.StartupPath + "\\test.pdf");
	}

	private void CountLinesofCodeInDirectory(string DirectoryPath, ref int TotalWritten, ref int TotalDesigner)
	{
		checked
		{
			try
			{
				string[] files = Directory.GetFiles(DirectoryPath);
				foreach (string text in files)
				{
					if (text.EndsWith(".Designer.vb"))
					{
						TotalDesigner += File.ReadAllLines(text).Count();
					}
					else if (text.EndsWith(".vb"))
					{
						TotalWritten += File.ReadAllLines(text).Count();
					}
				}
				string[] directories = Directory.GetDirectories(DirectoryPath);
				foreach (string directoryPath in directories)
				{
					CountLinesofCodeInDirectory(directoryPath, ref TotalWritten, ref TotalDesigner);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button5_Click(object sender, EventArgs e)
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
					ProjectData.ClearProjectError();
					num2 = 2;
					goto end_IL_0001;
				case 41:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmMain", "button5", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 41;
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
		if (e.KeyCode == Keys.Delete && dgvList.RowCount > 1 && dgvList.CurrentRow.Index < checked(dgvList.RowCount - 1))
		{
			dgvList.Rows.RemoveAt(dgvList.CurrentRow.Index);
			e.SuppressKeyPress = true;
		}
	}

	private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
	{
		if ((!_logout & (e.CloseReason == CloseReason.UserClosing)) && MessageBox.Show("Tutup Program?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.No)
		{
			e.Cancel = true;
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
		this.Button1 = new System.Windows.Forms.Button();
		this.txtHost = new System.Windows.Forms.TextBox();
		this.Button2 = new System.Windows.Forms.Button();
		this.btnDataReader = new System.Windows.Forms.Button();
		this.btnSave = new System.Windows.Forms.Button();
		this.Button3 = new System.Windows.Forms.Button();
		this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
		this.DataGridView1 = new System.Windows.Forms.DataGridView();
		this.Button4 = new System.Windows.Forms.Button();
		this.Button5 = new System.Windows.Forms.Button();
		this.dgvList = new System.Windows.Forms.DataGridView();
		((System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		base.SuspendLayout();
		this.Button1.Location = new System.Drawing.Point(479, 413);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 1;
		this.Button1.Text = "Button1";
		this.Button1.UseVisualStyleBackColor = true;
		this.Button1.Visible = false;
		this.txtHost.Location = new System.Drawing.Point(373, 415);
		this.txtHost.Name = "txtHost";
		this.txtHost.Size = new System.Drawing.Size(100, 20);
		this.txtHost.TabIndex = 2;
		this.txtHost.Text = "192.168.1.3";
		this.txtHost.Visible = false;
		this.Button2.Location = new System.Drawing.Point(292, 415);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(75, 23);
		this.Button2.TabIndex = 3;
		this.Button2.Text = "Button2";
		this.Button2.UseVisualStyleBackColor = true;
		this.Button2.Visible = false;
		this.btnDataReader.Location = new System.Drawing.Point(560, 413);
		this.btnDataReader.Name = "btnDataReader";
		this.btnDataReader.Size = new System.Drawing.Size(75, 23);
		this.btnDataReader.TabIndex = 5;
		this.btnDataReader.Text = "DataReader";
		this.btnDataReader.UseVisualStyleBackColor = true;
		this.btnDataReader.Visible = false;
		this.btnSave.Location = new System.Drawing.Point(211, 415);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(75, 23);
		this.btnSave.TabIndex = 6;
		this.btnSave.Text = "Save";
		this.btnSave.UseVisualStyleBackColor = true;
		this.btnSave.Visible = false;
		this.Button3.Location = new System.Drawing.Point(12, 384);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(182, 52);
		this.Button3.TabIndex = 8;
		this.Button3.Text = "Module";
		this.Button3.UseVisualStyleBackColor = true;
		this.Button3.Visible = false;
		this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
		this.MenuStrip1.Name = "MenuStrip1";
		this.MenuStrip1.Size = new System.Drawing.Size(1008, 24);
		this.MenuStrip1.TabIndex = 9;
		this.MenuStrip1.Text = "MenuStrip1";
		this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
		this.DataGridView1.Location = new System.Drawing.Point(665, 334);
		this.DataGridView1.Name = "DataGridView1";
		this.DataGridView1.Size = new System.Drawing.Size(265, 80);
		this.DataGridView1.TabIndex = 5;
		this.DataGridView1.Visible = false;
		this.Button4.Location = new System.Drawing.Point(490, 442);
		this.Button4.Name = "Button4";
		this.Button4.Size = new System.Drawing.Size(257, 72);
		this.Button4.TabIndex = 12;
		this.Button4.Text = "pdf";
		this.Button4.UseVisualStyleBackColor = true;
		this.Button4.Visible = false;
		this.Button5.Location = new System.Drawing.Point(327, 530);
		this.Button5.Name = "Button5";
		this.Button5.Size = new System.Drawing.Size(99, 78);
		this.Button5.TabIndex = 16;
		this.Button5.Text = "Total Lines";
		this.Button5.UseVisualStyleBackColor = true;
		this.Button5.Visible = false;
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.Location = new System.Drawing.Point(12, 415);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(145, 204);
		this.dgvList.TabIndex = 18;
		this.dgvList.Visible = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.SystemColors.Control;
		base.ClientSize = new System.Drawing.Size(1008, 730);
		base.Controls.Add(this.dgvList);
		base.Controls.Add(this.Button5);
		base.Controls.Add(this.Button4);
		base.Controls.Add(this.DataGridView1);
		base.Controls.Add(this.Button3);
		base.Controls.Add(this.MenuStrip1);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.btnDataReader);
		base.Controls.Add(this.Button2);
		base.Controls.Add(this.txtHost);
		base.Controls.Add(this.Button1);
		base.IsMdiContainer = true;
		base.KeyPreview = true;
		base.MainMenuStrip = this.MenuStrip1;
		base.Name = "frmMenu";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Menu Utama";
		base.WindowState = System.Windows.Forms.FormWindowState.Maximized;
		((System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
