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
using MySql.Data.MySqlClient;

namespace GCUv2;

[DesignerGenerated]
public class frmSettingCloseData : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnCloseData")]
	private Button _btnCloseData;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnUpdate")]
	private Button _btnUpdate;

	[field: AccessedThroughProperty("lblDate")]
	internal virtual Label lblDate
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

	[field: AccessedThroughProperty("dtpCloseData")]
	internal virtual DateTimePicker dtpCloseData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnCloseData
	{
		[CompilerGenerated]
		get
		{
			return _btnCloseData;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnCloseData_Click;
			Button button = _btnCloseData;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnCloseData = value;
			button = _btnCloseData;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
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

	[field: AccessedThroughProperty("txtConfirmation")]
	internal virtual TextBox txtConfirmation
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnUpdate
	{
		[CompilerGenerated]
		get
		{
			return _btnUpdate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnUpdate_Click;
			Button button = _btnUpdate;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnUpdate = value;
			button = _btnUpdate;
			if (button != null)
			{
				button.Click += value2;
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
		this.lblDate = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.dtpCloseData = new System.Windows.Forms.DateTimePicker();
		this.btnCloseData = new System.Windows.Forms.Button();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.txtConfirmation = new System.Windows.Forms.TextBox();
		this.btnUpdate = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.lblDate.Location = new System.Drawing.Point(12, 28);
		this.lblDate.Name = "lblDate";
		this.lblDate.Size = new System.Drawing.Size(315, 18);
		this.lblDate.TabIndex = 0;
		this.lblDate.Text = "Batas tanggal penghapusan data sebelumnya:";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(12, 52);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(140, 13);
		this.Label2.TabIndex = 1;
		this.Label2.Text = "Batas tanggal penghapusan";
		this.dtpCloseData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpCloseData.Location = new System.Drawing.Point(159, 49);
		this.dtpCloseData.Name = "dtpCloseData";
		this.dtpCloseData.Size = new System.Drawing.Size(142, 20);
		this.dtpCloseData.TabIndex = 0;
		this.btnCloseData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCloseData.Location = new System.Drawing.Point(159, 101);
		this.btnCloseData.Name = "btnCloseData";
		this.btnCloseData.Size = new System.Drawing.Size(105, 24);
		this.btnCloseData.TabIndex = 10;
		this.btnCloseData.Text = "&Hapus Data";
		this.btnCloseData.UseVisualStyleBackColor = true;
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(12, 78);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(83, 13);
		this.Label5.TabIndex = 165;
		this.Label5.Text = "Kode Konfirmasi";
		this.Label3.AutoSize = true;
		this.Label3.ForeColor = System.Drawing.Color.Red;
		this.Label3.Location = new System.Drawing.Point(13, 9);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(288, 13);
		this.Label3.TabIndex = 167;
		this.Label3.Text = "JANGAN GUNAKAN FORM INI JIKA ANDA TIDAK YAKIN.";
		this.txtConfirmation.Location = new System.Drawing.Point(159, 75);
		this.txtConfirmation.Name = "txtConfirmation";
		this.txtConfirmation.Size = new System.Drawing.Size(142, 20);
		this.txtConfirmation.TabIndex = 1;
		this.btnUpdate.Location = new System.Drawing.Point(12, 101);
		this.btnUpdate.Name = "btnUpdate";
		this.btnUpdate.Size = new System.Drawing.Size(83, 24);
		this.btnUpdate.TabIndex = 168;
		this.btnUpdate.Text = "Update";
		this.btnUpdate.UseVisualStyleBackColor = true;
		base.AcceptButton = this.btnCloseData;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(332, 135);
		base.Controls.Add(this.btnUpdate);
		base.Controls.Add(this.txtConfirmation);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.btnCloseData);
		base.Controls.Add(this.dtpCloseData);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.lblDate);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSettingCloseData";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Penghapusan Data";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmSettingCloseData()
	{
		base.KeyDown += frmSettingDatabase_KeyDown;
		base.Load += frmSettingDatabase_Load;
		InitializeComponent();
		base.MdiParent = MyProject.Forms.frmMenu;
		if (Operators.CompareString(Module1.pubLogin, "adi", TextCompare: false) == 0)
		{
			btnUpdate.Visible = true;
		}
		else
		{
			btnUpdate.Visible = false;
		}
	}

	private void frmSettingDatabase_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void btnCloseData_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		MySqlTransaction val = default(MySqlTransaction);
		string text = default(string);
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
					if (DateTime.Compare(Module1.pubBalanceDate, dtpCloseData.Value.Date) >= 0)
					{
						Interaction.MsgBox("Batas Tanggal Penghapusan harus lebih besar dari batas Tanggal Penghapusan sebelumnya.");
					}
					else if (Operators.CompareString(txtConfirmation.Text, "TUTUP_DATA", TextCompare: false) != 0)
					{
						Interaction.MsgBox("Kode konfirmasi salah", MsgBoxStyle.Information);
						txtConfirmation.Focus();
					}
					else
					{
						if (MessageBox.Show("Apakah anda benar-benar yakin untuk menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.No)
						{
							goto end_IL_0001;
						}
						val = Module1.connectData.BeginTransaction();
						Cursor = Cursors.WaitCursor;
						Module1.pubCommandTimeout = 1200;
						MyProject.Forms.frmInformation.BackgroundWorker1.Dispose();
						Module1.SaveDebug("Update Supplier Balance");
						text = " SELECT * FROM suppliers ";
						DataTable dataTable = Module1.sqlTable(text, "data", Clone: false);
						IEnumerator enumerator = dataTable.Rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							int num3 = Conversions.ToInteger(dataRow["supId"]);
							double supplierBalance = cPurchaseInvoice.GetSupplierBalance(Module1.pubBalanceDate, dtpCloseData.Value, num3);
							text = " UPDATE suppliers  SET supUnpaid = " + Module1.unformatNumber(Conversions.ToString(supplierBalance)) + " WHERE supId = " + Conversions.ToString(num3);
							Module1.sqlNonQuery(text, "data");
						}
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
						Module1.SaveDebug("Update Stock - Start");
						text = " DELETE FROM produkstorages  WHERE prodid NOT IN (select prodid from produk) ";
						Module1.sqlNonQuery(text, "data");
						text = " SELECT * FROM produkstorages ";
						dataTable = Module1.sqlTable(text, "data", Clone: false);
						int num4 = 0;
						double num5 = 0.0;
						IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							DataRow dataRow2 = (DataRow)enumerator2.Current;
							int num6 = Conversions.ToInteger(dataRow2["prodId"]);
							int num7 = Conversions.ToInteger(dataRow2["storeId"]);
							double supplierBalance = cStock.getStock(num6, Module1.pubBalanceDate, dtpCloseData.Value, "", num7, 0, 0, blnNewGetStockCode: true);
							text = " UPDATE produkstorages  SET psQty = " + Module1.unformatNumber(Conversions.ToString(supplierBalance)) + " WHERE prodId = " + Conversions.ToString(num6) + " AND storeId = " + Conversions.ToString(num7);
							Module1.sqlNonQuery(text, "data");
							num4 = checked(num4 + 1);
							num5 += 1.0;
							if (num4 == 1000)
							{
								num4 = 0;
								Module1.SaveDebug("ItemId=" + Conversions.ToString(num6) + ", StorageId=" + Conversions.ToString(num7) + ", Counter=" + Conversions.ToString(num5));
							}
						}
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
						Module1.SaveDebug("Update Cash - Start");
						text = " SELECT * FROM account  WHERE accountCashBank = 1 ";
						dataTable = Module1.sqlTable(text, "data", Clone: false);
						IEnumerator enumerator3 = dataTable.Rows.GetEnumerator();
						while (enumerator3.MoveNext())
						{
							DataRow dataRow3 = (DataRow)enumerator3.Current;
							int num8 = Conversions.ToInteger(dataRow3["accountId"]);
							double supplierBalance = Conversions.ToDouble(cCashAccount.getBalance(Module1.pubBalanceDate, dtpCloseData.Value, num8));
							text = " UPDATE account  SET accountBalanceAmount = " + Module1.unformatNumber(Conversions.ToString(supplierBalance)) + ", accountBalanceDate = '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "' WHERE accountId = " + Conversions.ToString(num8);
							Module1.sqlNonQuery(text, "data");
						}
						if (enumerator3 is IDisposable)
						{
							(enumerator3 as IDisposable).Dispose();
						}
						Module1.SaveDebug("Update Bank - Start");
						text = " SELECT * FROM account  WHERE accountCashBank = 2 ";
						dataTable = Module1.sqlTable(text, "data", Clone: false);
						IEnumerator enumerator4 = dataTable.Rows.GetEnumerator();
						while (enumerator4.MoveNext())
						{
							DataRow dataRow4 = (DataRow)enumerator4.Current;
							int num8 = Conversions.ToInteger(dataRow4["accountId"]);
							double supplierBalance = Conversions.ToDouble(cBankAccount.getBalance(Module1.pubBalanceDate, dtpCloseData.Value, num8));
							text = " UPDATE account  SET accountBalanceAmount = " + Module1.unformatNumber(Conversions.ToString(supplierBalance)) + ", accountBalanceDate = '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "' WHERE accountId = " + Conversions.ToString(num8);
							Module1.sqlNonQuery(text, "data");
						}
						if (enumerator4 is IDisposable)
						{
							(enumerator4 as IDisposable).Dispose();
						}
						Module1.SaveDebug("Set penjCloseDate - Start");
						text = " UPDATE penjualan SET penjCloseDate = NULL ";
						Module1.sqlNonQuery(text, "data");
						text = " SELECT penjId, penjLunas  FROM penjualan  WHERE penjLunas < '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "' AND penjTotal-penjBs-penjDisc-penjPot-penjBayar = 0  AND penjId NOT IN (SELECT penjBsId FROM penjBs) ";
						dataTable = Module1.sqlTable(text, "data", Clone: false);
						IEnumerator enumerator5 = dataTable.Rows.GetEnumerator();
						while (enumerator5.MoveNext())
						{
							DataRow dataRow5 = (DataRow)enumerator5.Current;
							text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(" SELECT pbId, pbgId  FROM penjBayar  WHERE penjId = ", dataRow5["penjId"]), " AND pkId = 2 "));
							DataTable dataTable2 = Module1.sqlTable(text, "data", Clone: false);
							if (dataTable2.Rows.Count == 0)
							{
								text = Conversions.ToString(Operators.ConcatenateObject(" UPDATE penjualan  SET penjCloseDate = '" + Strings.Format(RuntimeHelpers.GetObjectValue(dataRow5["penjLunas"]), "yyyy-MM-dd") + "' WHERE penjId = ", dataRow5["penjId"]));
								Module1.sqlNonQuery(text, "data");
								continue;
							}
							DateTime dateTime = DateTime.MinValue;
							IEnumerator enumerator6 = dataTable2.Rows.GetEnumerator();
							while (enumerator6.MoveNext())
							{
								DataRow dataRow6 = (DataRow)enumerator6.Current;
								DataTable dataTable3;
								if (Operators.ConditionalCompareObjectEqual(dataRow6["pbgId"], 0, TextCompare: false))
								{
									text = Conversions.ToString(Operators.ConcatenateObject(" SELECT gcMasukDate  FROM girocek  WHERE pbId = ", dataRow6["pbId"]));
									dataTable3 = Module1.sqlTable(text, "data", Clone: false);
								}
								else
								{
									text = Conversions.ToString(Operators.ConcatenateObject(" SELECT gcMasukDate  FROM girocek  WHERE pbgId = ", dataRow6["pbgId"]));
									dataTable3 = Module1.sqlTable(text, "data", Clone: false);
								}
								if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable3.Rows[0]["gcMasukDate"])) && Operators.ConditionalCompareObjectGreater(dataTable3.Rows[0]["gcMasukDate"], dateTime, TextCompare: false))
								{
									dateTime = Conversions.ToDate(dataTable3.Rows[0]["gcMasukDate"]);
								}
							}
							if (enumerator6 is IDisposable)
							{
								(enumerator6 as IDisposable).Dispose();
							}
							if (DateTime.Compare(dateTime, DateTime.MinValue) > 0)
							{
								text = Conversions.ToString(Operators.ConcatenateObject(" UPDATE penjualan  SET penjCloseDate = '" + Strings.Format(dateTime, "yyyy-MM-dd") + "' WHERE penjId = ", dataRow5["penjId"]));
								Module1.sqlNonQuery(text, "data");
							}
						}
						if (enumerator5 is IDisposable)
						{
							(enumerator5 as IDisposable).Dispose();
						}
						Module1.SaveDebug("Delete Penjualan - Start");
						text = " DELETE FROM penjKui  WHERE penjId IN ( SELECT penjId FROM penjualan  WHERE penjBs = 0 AND penjCloseDate < '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "')";
						Module1.sqlNonQuery(text, "data");
						Module1.SaveDebug("Delete Penjualan - Kuitansi");
						text = " DELETE FROM kuitansi  WHERE kuiDate < '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "' AND kuiId NOT IN (SELECT kuiId FROM penjKui) ";
						Module1.sqlNonQuery(text, "data");
						Module1.SaveDebug("Delete Penjualan - SalesOrder");
						text = " DELETE FROM SalesOrder  WHERE soId IN (SELECT soId FROM penjProd WHERE penjId IN (  SELECT penjId FROM penjualan  WHERE penjCloseDate < '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "'))";
						Module1.sqlNonQuery(text, "data");
						Module1.SaveDebug("Delete Penjualan - SalesOrder_Item");
						text = " DELETE FROM SalesOrder_Item  WHERE soId NOT IN (SELECT soId FROM SalesOrder)";
						Module1.sqlNonQuery(text, "data");
						Module1.SaveDebug("Delete Penjualan - DeliveryOrder");
						text = " DELETE FROM DeliveryOrder  WHERE doId IN (SELECT doId FROM penjProd WHERE penjId IN (  SELECT penjId FROM penjualan  WHERE penjCloseDate < '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "'))";
						Module1.sqlNonQuery(text, "data");
						Module1.SaveDebug("Delete Penjualan - DeliveryOrder_Item");
						text = " DELETE FROM DeliveryOrder_Item  WHERE doId NOT IN (SELECT doId FROM DeliveryOrder)";
						Module1.sqlNonQuery(text, "data");
						Module1.SaveDebug("Delete Penjualan - GiroCek");
						text = " DELETE FROM GiroCek  WHERE pbId IN (  SELECT pbId FROM penjBayar WHERE penjId IN (  SELECT penjId FROM penjualan  WHERE penjBs = 0 AND penjCloseDate < '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "'))";
						Module1.sqlNonQuery(text, "data");
						text = " SELECT DISTINCT pbgId FROM penjBayar WHERE pbgId > 0 AND penjId IN (  SELECT penjId FROM penjualan  WHERE penjBs = 0 AND penjCloseDate < '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "')";
						dataTable = Module1.sqlTable(text, "data", Clone: false);
						IEnumerator enumerator7 = dataTable.Rows.GetEnumerator();
						while (enumerator7.MoveNext())
						{
							DataRow dataRow7 = (DataRow)enumerator7.Current;
							text = Conversions.ToString(Operators.ConcatenateObject(" DELETE FROM GiroCek  WHERE pbgId = ", dataRow7["pbgId"]));
							Module1.sqlNonQuery(text, "data");
						}
						if (enumerator7 is IDisposable)
						{
							(enumerator7 as IDisposable).Dispose();
						}
						Module1.SaveDebug("Delete Penjualan - PenjBayarGroup");
						text = " DELETE FROM PenjBayarGroup  WHERE pbgId IN (  SELECT pbgId FROM penjBayar WHERE pbgId > 0 AND penjId IN (  SELECT penjId FROM penjualan  WHERE penjBs = 0 AND penjCloseDate < '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "'))";
						Module1.sqlNonQuery(text, "data");
						Module1.SaveDebug("Delete Penjualan - penjBayar");
						text = " DELETE FROM PenjBayar  WHERE penjId IN ( SELECT penjId FROM penjualan  WHERE penjBs = 0 AND penjCloseDate < '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "')";
						Module1.sqlNonQuery(text, "data");
						Module1.SaveDebug("Delete Penjualan - penjProd");
						text = " DELETE FROM penjProd  WHERE penjId IN ( SELECT penjId FROM penjualan  WHERE penjBs = 0 AND penjCloseDate < '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "')";
						Module1.sqlNonQuery(text, "data");
						Module1.SaveDebug("Delete Penjualan");
						text = " DELETE FROM penjualan  WHERE penjBs = 0 AND penjCloseDate < '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "'";
						Module1.SaveDebug(text);
						Module1.sqlNonQuery(text, "data");
						Module1.SaveDebug("Delete Retur Penjualan - Start");
						text = " SELECT * FROM penjBs  WHERE penjId IN (SELECT penjId FROM penjualan  WHERE penjCloseDate < '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "' AND penjTotal-penjBs-penjDisc-penjPot-penjBayar = 0) ";
						dataTable = Module1.sqlTable(text, "data", Clone: false);
						IEnumerator enumerator8 = dataTable.Rows.GetEnumerator();
						while (enumerator8.MoveNext())
						{
							DataRow dataRow8 = (DataRow)enumerator8.Current;
							double num9 = Conversions.ToDouble(dataRow8["penjId"]);
							double num10 = Conversions.ToDouble(dataRow8["penjBsId"]);
							text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" SELECT penjDate FROM penjualan  WHERE penjId = ", dataRow8["penjBsId"]), " AND penjDate < '"), Strings.Format(dtpCloseData.Value, "yyyy-MM-dd")), "'"));
							DataTable dataTable2 = Module1.sqlTable(text, "data", Clone: false);
							if (dataTable2.Rows.Count == 1)
							{
								text = " DELETE FROM penjProd  WHERE penjId IN (" + Conversions.ToString(num9) + "," + Conversions.ToString(num10) + ")";
								Module1.sqlNonQuery(text, "data");
								text = " DELETE FROM GiroCek  WHERE pbId IN (  SELECT pbId FROM penjBayar WHERE penjId IN (" + Conversions.ToString(num9) + "," + Conversions.ToString(num10) + "))";
								Module1.sqlNonQuery(text, "data");
								text = " DELETE GiroCek.* FROM GiroCek  INNER JOIN  (SELECT pbgId FROM penjBayar WHERE pbgId > 0 AND penjId IN (" + Conversions.ToString(num9) + "," + Conversions.ToString(num10) + ")) pb  ON GiroCek.pbgId = pb.pbgId ";
								Module1.sqlNonQuery(text, "data");
								text = " DELETE FROM PenjBayarGroup  WHERE pbgId IN (  SELECT pbgId FROM penjBayar WHERE pbgId > 0 AND penjId IN (" + Conversions.ToString(num9) + "," + Conversions.ToString(num10) + "))";
								Module1.sqlNonQuery(text, "data");
								text = " DELETE FROM PenjBayar  WHERE penjId IN (" + Conversions.ToString(num9) + "," + Conversions.ToString(num10) + ")";
								Module1.sqlNonQuery(text, "data");
								text = " DELETE FROM penjualan  WHERE penjId IN (" + Conversions.ToString(num9) + "," + Conversions.ToString(num10) + ")";
								Module1.sqlNonQuery(text, "data");
								text = " DELETE FROM penjBs  WHERE penjId = " + Conversions.ToString(num9) + " AND penjBsId = " + Conversions.ToString(num10);
								Module1.sqlNonQuery(text, "data");
							}
						}
						if (enumerator8 is IDisposable)
						{
							(enumerator8 as IDisposable).Dispose();
						}
						Module1.SaveDebug("Set invCloseDate - Start");
						text = " UPDATE purchaseInvoices SET invCloseDate = NULL ";
						Module1.sqlNonQuery(text, "data");
						text = " SELECT invId, invDatePaid  FROM purchaseinvoices  WHERE invDatePaid < '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "' AND invDate < '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "' AND invTotal-invReturn-invDiscount-invDeduction-invPayment = 0  AND invId NOT IN (SELECT invId FROM purchaseinvoices_returns)  AND invId NOT IN (SELECT invReturnId FROM purchaseinvoices_returns)";
						dataTable = Module1.sqlTable(text, "data", Clone: false);
						IEnumerator enumerator9 = dataTable.Rows.GetEnumerator();
						while (enumerator9.MoveNext())
						{
							DataRow dataRow9 = (DataRow)enumerator9.Current;
							text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(" SELECT payId, mpayId  FROM purchaseinvoices_payments  WHERE invId = ", dataRow9["invId"]), " AND pcId = 2 "));
							DataTable dataTable2 = Module1.sqlTable(text, "data", Clone: false);
							if (dataTable2.Rows.Count == 0)
							{
								text = Conversions.ToString(Operators.ConcatenateObject(" UPDATE purchaseinvoices  SET invCloseDate = '" + Strings.Format(RuntimeHelpers.GetObjectValue(dataRow9["invDatePaid"]), "yyyy-MM-dd") + "' WHERE invId = ", dataRow9["invId"]));
								Module1.sqlNonQuery(text, "data");
								continue;
							}
							DateTime dateTime2 = DateTime.MinValue;
							IEnumerator enumerator10 = dataTable2.Rows.GetEnumerator();
							while (enumerator10.MoveNext())
							{
								DataRow dataRow10 = (DataRow)enumerator10.Current;
								DataTable dataTable3;
								if (Operators.ConditionalCompareObjectEqual(dataRow10["mpayId"], 0, TextCompare: false))
								{
									text = Conversions.ToString(Operators.ConcatenateObject(" SELECT cheqDate  FROM chequesOut  WHERE payId = ", dataRow10["payId"]));
									dataTable3 = Module1.sqlTable(text, "data", Clone: false);
								}
								else
								{
									text = Conversions.ToString(Operators.ConcatenateObject(" SELECT cheqDate  FROM chequesOut  WHERE mpayId = ", dataRow10["mpayId"]));
									dataTable3 = Module1.sqlTable(text, "data", Clone: false);
								}
								if (dataTable3.Rows.Count == 0)
								{
									dateTime2 = Conversions.ToDate(dataRow9["invDatePaid"]);
									Module1.SaveDebug(Conversions.ToString(Operators.ConcatenateObject("Temp Cheque Date, invId=", dataRow9["invId"])));
								}
								else if (Operators.ConditionalCompareObjectGreater(dataTable3.Rows[0]["cheqDate"], dateTime2, TextCompare: false))
								{
									dateTime2 = Conversions.ToDate(dataTable3.Rows[0]["cheqDate"]);
								}
							}
							if (enumerator10 is IDisposable)
							{
								(enumerator10 as IDisposable).Dispose();
							}
							text = Conversions.ToString(Operators.ConcatenateObject(" UPDATE purchaseInvoices  SET invCloseDate = '" + Strings.Format(dateTime2, "yyyy-MM-dd") + "' WHERE invId = ", dataRow9["invId"]));
							Module1.sqlNonQuery(text, "data");
						}
						if (enumerator9 is IDisposable)
						{
							(enumerator9 as IDisposable).Dispose();
						}
						Module1.SaveDebug("Delete Purchase Invoice - Start");
						text = " DELETE FROM ReceivedItem  WHERE riId IN (SELECT riId FROM PurchaseInvoices_Items WHERE invId IN (  SELECT invId FROM PurchaseInvoices  WHERE invCloseDate < '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "'))";
						Module1.sqlNonQuery(text, "data");
						text = " DELETE FROM ReceivedItem_Item  WHERE riId NOT IN (SELECT riId FROM ReceivedItem)";
						Module1.sqlNonQuery(text, "data");
						text = " DELETE FROM PurchaseInvoices_Items  WHERE invId IN ( SELECT invId FROM PurchaseInvoices  WHERE invCloseDate < '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "')";
						Module1.sqlNonQuery(text, "data");
						text = " DELETE FROM ChequesOut  WHERE payId IN ( SELECT payId FROM PurchaseInvoices_Payments  WHERE invId IN (  SELECT invId FROM PurchaseInvoices  WHERE invCloseDate < '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "'))";
						Module1.sqlNonQuery(text, "data");
						text = " DELETE FROM ChequesOut  WHERE mpayId IN ( SELECT mpayId FROM PurchaseInvoices_Payments  WHERE mpayId>0 AND invId IN (  SELECT invId FROM PurchaseInvoices  WHERE invCloseDate < '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "'))";
						Module1.sqlNonQuery(text, "data");
						text = " DELETE FROM PurchaseInvoices_MultiPayments  WHERE mpayId IN ( SELECT mpayId FROM PurchaseInvoices_payments  WHERE mpayId > 0 AND invId IN(  SELECT invId FROM purchaseinvoices  WHERE invCloseDate < '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "'))";
						Module1.sqlNonQuery(text, "data");
						text = " DELETE FROM PurchaseInvoices_Payments  WHERE invId IN ( SELECT invId FROM PurchaseInvoices  WHERE invCloseDate < '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "')";
						Module1.sqlNonQuery(text, "data");
						text = " DELETE FROM PurchaseInvoices  WHERE invCloseDate < '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "'";
						Module1.sqlNonQuery(text, "data");
						Module1.SaveDebug("Delete Purchase Return - Start");
						text = " SELECT * FROM purchaseinvoices_returns  WHERE invId IN (SELECT invId FROM purchaseinvoices  WHERE invDatePaid < '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "' AND invTotal-invReturn-invDiscount-invDeduction-invPayment = 0) ";
						dataTable = Module1.sqlTable(text, "data", Clone: false);
						IEnumerator enumerator11 = dataTable.Rows.GetEnumerator();
						while (enumerator11.MoveNext())
						{
							DataRow dataRow11 = (DataRow)enumerator11.Current;
							double num11 = Conversions.ToDouble(dataRow11["invId"]);
							double num12 = Conversions.ToDouble(dataRow11["invReturnId"]);
							text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" SELECT invDate FROM purchaseinvoices  WHERE invId = ", dataRow11["invReturnId"]), " AND invDate < '"), Strings.Format(dtpCloseData.Value, "yyyy-MM-dd")), "'"));
							DataTable dataTable2 = Module1.sqlTable(text, "data", Clone: false);
							if (dataTable2.Rows.Count == 1)
							{
								text = " DELETE FROM ReceivedItem  WHERE riId IN (SELECT riId FROM PurchaseInvoices_Items WHERE invId = " + Conversions.ToString(num11) + ")";
								Module1.sqlNonQuery(text, "data");
								text = " DELETE FROM ReceivedItem_Item  WHERE riId NOT IN (SELECT riId FROM ReceivedItem)";
								Module1.sqlNonQuery(text, "data");
								text = " DELETE FROM PurchaseInvoices_Items  WHERE invId IN (" + Conversions.ToString(num11) + "," + Conversions.ToString(num12) + ")";
								Module1.sqlNonQuery(text, "data");
								text = " DELETE FROM PurchaseInvoices_Returns  WHERE invId IN (" + Conversions.ToString(num11) + "," + Conversions.ToString(num12) + ")";
								Module1.sqlNonQuery(text, "data");
								text = " DELETE FROM ChequesOut  WHERE payId IN ( SELECT payId FROM PurchaseInvoices_Payments  WHERE invId IN (" + Conversions.ToString(num11) + "," + Conversions.ToString(num12) + "))";
								Module1.sqlNonQuery(text, "data");
								text = " DELETE FROM ChequesOut  WHERE mpayId IN ( SELECT mpayId FROM PurchaseInvoices_Payments  WHERE mpayId > 0 AND invId IN (" + Conversions.ToString(num11) + "," + Conversions.ToString(num12) + "))";
								Module1.sqlNonQuery(text, "data");
								text = " DELETE FROM PurchaseInvoices_MultiPayments  WHERE mpayId IN ( SELECT mpayId FROM PurchaseInvoices_Payments  WHERE mpayId > 0 AND invId IN (" + Conversions.ToString(num11) + "," + Conversions.ToString(num12) + "))";
								Module1.sqlNonQuery(text, "data");
								text = " DELETE FROM PurchaseInvoices_Payments  WHERE invId IN (" + Conversions.ToString(num11) + "," + Conversions.ToString(num12) + ")";
								Module1.sqlNonQuery(text, "data");
								text = " DELETE FROM PurchaseInvoices  WHERE invId IN (" + Conversions.ToString(num11) + "," + Conversions.ToString(num12) + ")";
								Module1.sqlNonQuery(text, "data");
								text = " DELETE FROM purchaseinvoices_returns  WHERE invId = " + Conversions.ToString(num11) + " AND invReturnId = " + Conversions.ToString(num12);
								Module1.sqlNonQuery(text, "data");
							}
						}
						if (enumerator11 is IDisposable)
						{
							(enumerator11 as IDisposable).Dispose();
						}
						Module1.SaveDebug("Delete PO and rest of tables - Start");
						text = " DELETE FROM transfer_item  WHERE transferId IN (  SELECT transferId FROM transfer  WHERE transferDate < '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "')";
						Module1.sqlNonQuery(text, "data");
						text = " DELETE FROM transfer  WHERE transferDate < '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "'";
						Module1.sqlNonQuery(text, "data");
						text = " DELETE FROM adjustments  WHERE adjDate < '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "'";
						Module1.sqlNonQuery(text, "data");
						text = " DELETE FROM processcomponents  WHERE proId IN (  SELECT proId FROM processes  WHERE proDate < '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "')";
						Module1.sqlNonQuery(text, "data");
						text = " DELETE FROM processextras  WHERE proId IN (  SELECT proId FROM processes  WHERE proDate < '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "')";
						Module1.sqlNonQuery(text, "data");
						text = " DELETE FROM processes  WHERE proDate < '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "'";
						Module1.sqlNonQuery(text, "data");
						text = " DELETE FROM usage_item  WHERE usageId IN (  SELECT usageId FROM usages  WHERE usageDate < '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "')";
						Module1.sqlNonQuery(text, "data");
						text = " DELETE FROM usages  WHERE usageDate < '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "'";
						Module1.sqlNonQuery(text, "data");
						text = " DELETE FROM voucher_account  WHERE voucherId IN (  SELECT voucherId FROM voucher  WHERE voucherDate < '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "')";
						Module1.sqlNonQuery(text, "data");
						text = " DELETE FROM voucher  WHERE voucherDate < '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "'";
						Module1.sqlNonQuery(text, "data");
						text = " UPDATE settings set setVal = '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "' WHERE setName = 'BalanceDate'";
						Module1.sqlNonQuery(text, "data");
						Module1.SaveDebug("Delete History - Start");
						text = " DELETE FROM " + Module1.pubDbHistory + ".history  WHERE histDate < '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "'";
						Module1.sqlNonQuery(text, "data");
						text = " DELETE FROM " + Module1.pubDbHistory + ".historyV2  WHERE histDate < '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "'";
						Module1.sqlNonQuery(text, "data");
						text = " DELETE FROM dailystock  WHERE stockDate < '" + Strings.Format(dtpCloseData.Value, "yyyy-MM-dd") + "'";
						Module1.sqlNonQuery(text, "data");
						Module1.pubBalanceDate = dtpCloseData.Value.Date;
						val.Commit();
						Cursor = Cursors.Default;
						Interaction.MsgBox("Penghapusan Data berhasil dilakukan.", MsgBoxStyle.Information);
						Module1.pubCommandTimeout = 60;
						goto end_IL_0001;
					}
					goto end_IL_0001_2;
				case 6586:
					num = -1;
					switch (num2)
					{
					case 2:
						Cursor = Cursors.Default;
						Module1.SaveError(Information.Err(), "frmSettingCloseData", "btnCloseData_click", text);
						val.Rollback();
						goto end_IL_0001_2;
					}
					break;
				}
				goto IL_19f0;
				end_IL_0001_2:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 6586;
				continue;
			}
			break;
			IL_19f0:
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

	private void frmSettingDatabase_Load(object sender, EventArgs e)
	{
		lblDate.Text = "Batas tanggal penghapusan data sebelumnya: " + Conversions.ToString(Module1.pubBalanceDate);
	}

	private void btnUpdate_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		string text = default(string);
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
					if (Operators.CompareString(txtConfirmation.Text, "COMPONENT_STOCK", TextCompare: false) != 0)
					{
						Interaction.MsgBox("Kode konfirmasi salah", MsgBoxStyle.Information);
						txtConfirmation.Focus();
						goto end_IL_0001;
					}
					MyProject.Forms.frmInformation.tmrInformation.Enabled = false;
					Cursor = Cursors.WaitCursor;
					text = " select distinct(a.itemId),itemName,a.storeId,storeName from processcomponents a, items b, storages c where comdate > '2017-01-01' and a.itemid = b.itemid  and c.storeid = a.storeId order by 2,4 ";
					DataTable dataTable = Module1.sqlTable(text, "data", Clone: false);
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						double stock = cStock.getStock(Conversions.ToInteger(dataRow["itemId"]), Module1.pubBalanceDate, DateAndTime.Now, "not_used", Conversions.ToInteger(dataRow["storeId"]), Module1.pubGroupId, 0, blnNewGetStockCode: false);
						double stock2 = cStock.getStock(Conversions.ToInteger(dataRow["itemId"]), Module1.pubBalanceDate, DateAndTime.Now, "not_used", Conversions.ToInteger(dataRow["storeId"]), Module1.pubGroupId, 0, blnNewGetStockCode: true);
						if (stock == stock2)
						{
							Module1.SaveDebug(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow["itemName"], " in "), dataRow["storeName"]), " is OK")));
						}
						else
						{
							Module1.SaveDebug(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("ERROR:", dataRow["itemName"]), " in "), dataRow["storeName"]), " is WRONG")));
						}
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					Cursor = Cursors.Default;
					goto end_IL_0001;
				}
				case 521:
					num = -1;
					switch (num2)
					{
					case 2:
						Cursor = Cursors.Default;
						Module1.SaveError(Information.Err(), "frmSettingCloseData", "btnUpdate_click", text);
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 521;
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
